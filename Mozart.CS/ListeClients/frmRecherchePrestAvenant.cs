using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmRecherchePrestAvenant : Form
  {
    public int miNumDevis;
    public int miNumAvenant;
    public DataTable mdtPrestationSaisie;

    private DataTable dtPrest = new DataTable();
    private int iNumCli;

    public frmRecherchePrestAvenant() { InitializeComponent(); }

    private void frmRecherchePrestAvenant_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        string sSql = $"SELECT TDIN.NCLINUM FROM TAVENANT WITH (NOLOCK) INNER JOIN TDCL WITH (NOLOCK) ON TDCL.NDCLNUM = TAVENANT.NDCLNUM INNER JOIN TACT WITH (NOLOCK) " +
                      $"ON TDCL.NACTNUM = TACT.NACTNUM INNER JOIN TDIN WITH (NOLOCK) ON TDIN.NDINNUM = TACT.NDINNUM WHERE NAVENANTNUM = {miNumAvenant}";

        iNumCli = (int)ModuleData.ExecuteScalarInt(sSql);

        //  On charge toutes les prestations dans la grille du haut
        apiTGridPrest.LoadData(dtPrest, MozartDatabase.cnxMozart, "exec api_sp_listePrestation " + iNumCli + ", 'N'");

        InitgridPrest();
        InitgridPrestSaisie();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      if (dtPrest.Rows.Count == 0)
        return;

      AjouterEnreg(apiTGridPrest.GetFocusedDataRow());
    }

    private void AjouterEnreg(DataRow curRow)
    {
      try
      {
        DataRow newRow = mdtPrestationSaisie.NewRow();
        newRow["NSSCATID"] = 0; //
        newRow["NCLASSID"] = 0;
        newRow["NAVENANTNUM"] = miNumAvenant;
        newRow["NPRESTID"] = curRow["NPRESTID"];
        newRow["NPRESTSERID"] = curRow["NPRESTSERID"];
        newRow["VPRESTSER"] = curRow["VPRESTSER"];
        newRow["VPRESTLIB"] = curRow["VPRESTLIB"];
        newRow["VPRESTUNITE"] = curRow["VPRESTUNITE"];
        newRow["NPRESTSERMOHT"] = curRow["NPRESTSERMOHT"];
        newRow["NPRESTQTEMO"] = curRow["NPRESTQTEMO"];
        newRow["NPRESTFOHT"] = curRow["NPRESTFOHT"];
        newRow["NQTE"] = 1;
        newRow["NTOTALHT"] = Utils.ZeroIfNull(curRow["NPRIXCLI"]) == 0 ? curRow["TOTAL"] : curRow["NPRIXCLI"];
        newRow["NPRIXCLI"] = Utils.ZeroIfNull(curRow["NPRIXCLI"]) == 0 ? -1 : curRow["NPRIXCLI"];

        mdtPrestationSaisie.Rows.Add(newRow);

        using (SqlCommand cmd = new SqlCommand("api_sp_CreationLigneAvenantPrestation", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);
          //
          cmd.Parameters["@NumAvenant"].Value = miNumAvenant;
          cmd.Parameters["@NprestId"].Value = curRow["NPRESTID"];
          cmd.Parameters["@NumDevis"].Value = miNumDevis;
          cmd.Parameters["@NpresSerId"].Value = curRow["NPRESTSERID"];
          cmd.Parameters["@VUnite"].Value = curRow["VPRESTUNITE"];
          cmd.Parameters["@nQteMo"].Value = curRow["NPRESTQTEMO"];
          cmd.Parameters["@nFO"].Value = curRow["NPRESTFOHT"];
          cmd.Parameters["@nMOHT"].Value = curRow["NPRESTSERMOHT"];
          cmd.Parameters["@Qte"].Value = curRow["NPRESTQTEMO"];
          cmd.Parameters["@nPrixCli"].Value = curRow["NPRIXCLI"];
          cmd.Parameters["@vPrestLib"].Value = curRow["VPRESTLIB"].ToString().Replace("'", "''");

          using (SqlDataReader drP = ModuleData.ExecuteReader($"SELECT NLAVENANTPRESTNUM, NPRESTID, NSSCATID, NCLASSID, VPRESTLIB FROM TLAVENANTPREST WHERE NAVENANTNUM = {miNumAvenant}"))
          {
            if (drP.Read())
            {
              cmd.Parameters["@nCatid"].Value = Utils.ZeroIfNull(drP["NCLASSID"]);
              cmd.Parameters["@vPrestLib"].Value = drP["VPRESTLIB"];
              cmd.Parameters["@vSscatid"].Value = drP["NSSCATID"];
            }
          }

          cmd.ExecuteNonQuery();

        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGridPrestSaisie.GetFocusedDataRow();
        if (row == null) return;

        // suppression de la ligne courante
        ModuleData.ExecuteNonQuery($"DELETE from TLAVENANTPREST where NLAVENANTPRESTNUM =     {row["NLAVENANTPRESTNUM"]}");
        ModuleData.ExecuteNonQuery($"DELETE from TLAVENANTPRESTFOU where NLAVENANTPRESTNUM = {row["NLAVENANTPRESTNUM"]}");
        mdtPrestationSaisie.Rows.Remove(row);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiTGridPrest_DoubleClickE(object sender, EventArgs e)
    {
      cmdAjouter_Click(null, null);
    }

    private void InitgridPrest()
    {
      apiTGridPrest.AddColumn(Resources.col_Serie, "VPRESTSER", 1500);
      apiTGridPrest.AddColumn(Resources.col_Prestation, "VPRESTLIB", 5000);
      apiTGridPrest.AddColumn(Resources.col_unite, "VPRESTUNITE", 1000, "", 2);
      apiTGridPrest.AddColumn(Resources.col_Creator, "VPRESTQUICRE", 1800, "", 2);
      apiTGridPrest.AddColumn(Resources.col_MO_HT, "NPRESTSERMOHT", 1000, "Currency", 2);
      apiTGridPrest.AddColumn(Resources.col_qte_MO, "NPRESTQTEMO", 1000, "#", 2);
      apiTGridPrest.AddColumn(Resources.col_fournitures, "NPRESTFOHT", 1300, "Currency", 2);
      apiTGridPrest.AddColumn(Resources.col_PrixDeVente, "NPRIXCLI", 1500, "Currency", 2);
      apiTGridPrest.AddColumn(Resources.col_Total, "TOTAL", 1000, "Currency", 2);

      apiTGridPrest.InitColumnList();
      apiTGridPrest.GridControl.DataSource = dtPrest;
    }

    private void apiTGridPrest_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (null == e.CellValue) return;

      if (e.Column.Name == "COULEUR")
      {
        if (e.CellValue.ToString() == "O")
          e.Appearance.ForeColor = Color.Red;
      }
    }

    private void InitgridPrestSaisie()
    {
      apiTGridPrestSaisie.AddColumn("Chap", "NCLASSID", 500);
      apiTGridPrestSaisie.AddColumn("Ind1", "NSSCATID", 500);
      apiTGridPrestSaisie.AddColumn(Resources.col_Serie, "VPRESTSER", 1500);
      apiTGridPrestSaisie.AddColumn(Resources.col_Prestation, "VPRESTLIB", 5000);
      apiTGridPrestSaisie.AddColumn(Resources.col_unite, "VPRESTUNITE", 1000, "", 2);
      apiTGridPrestSaisie.AddColumn(Resources.col_MO_HT, "NPRESTSERMOHT", 1000, "Currency", 2);

      apiTGridPrestSaisie.AddColumn(Resources.col_qte_MO, "NPRESTQTEMO", 1000, "#", 2);
      apiTGridPrestSaisie.AddColumn(Resources.col_fournitures, "NPRESTFOHT", 1300, "Currency", 2);
      apiTGridPrestSaisie.AddColumn(Resources.col_qte2, "NQTE", 500, "#", 2);
      apiTGridPrestSaisie.AddColumn(Resources.col_Total, "NTOTALHT", 1000, "Currency", 2);

      apiTGridPrestSaisie.DelockColumn("NQTE");
      apiTGridPrestSaisie.DelockColumn("NCLASSID");
      apiTGridPrestSaisie.DelockColumn("NSSCATID");

      if (!mdtPrestationSaisie.Columns.Contains("NTOTALHT"))
        mdtPrestationSaisie.Columns.Add(new DataColumn("NTOTALHT", Type.GetType("System.Double")));

      foreach (DataRow row in mdtPrestationSaisie.Rows)
      {
        row["NTOTALHT"] = Utils.ZeroIfNull(row["NPRIXCLITOT"]) == 0 ? row["TOTAL"] : row["NPRIXCLITOT"];
      }

      apiTGridPrestSaisie.InitColumnList();
      apiTGridPrestSaisie.GridControl.DataSource = mdtPrestationSaisie;
    }

    private void apiTGridPrestSaisie_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.RowHandle >= 0 && e.Column.Name == "NQTE")
        e.Appearance.BackColor = Color.FromArgb(255, 160, 0);
    }
    
    private void apiTGridPrestSaisie_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      DataRow row = apiTGridPrestSaisie.GetFocusedDataRow();
      if (null == row) return;

      //  Colonne des chapitres 1
      if (e.Column.Name == "NCLASSID")
        ModuleData.ExecuteNonQuery("UPDATE TLAVENANTPREST SET NCLASSID = " + row["NCLASSID"] + " WHERE NLAVENANTPRESTNUM = " + row["NLAVENANTPRESTNUM"]);

      //  Colonne des chapitres 2
      if (e.Column.Name == "NSSCATID")
        ModuleData.ExecuteNonQuery("UPDATE TLAVENANTPREST SET NSSCATID = " + row["NSSCATID"] + " WHERE NLAVENANTPRESTNUM = " + row["NLAVENANTPRESTNUM"]);

      //  ' si on met à jour la quantité, on recalcul le total HT
      if (e.Column.Name == "NQTE")
      {
        // si on a un prix client on fait le calcul avec
        if (Utils.ZeroIfNull(row["NPRIXCLI"]) < 0)
          row["NTOTALHT"] = (Convert.ToDouble(row["NPRESTSERMOHT"]) * Convert.ToDouble(row["NPRESTQTEMO"]) + Convert.ToDouble(row["NPRESTFOHT"])) * Convert.ToDouble(row["NQTE"]);
        else
          row["NTOTALHT"] = Convert.ToDouble(row["NPRIXCLI"]) * Convert.ToDouble(row["NQTE"]);

        ModuleData.ExecuteNonQuery("UPDATE TLAVENANTPREST SET NQTE = " + row["NQTE"].ToString().Replace(",", ".") + " WHERE NLAVENANTPRESTNUM = " + row["NLAVENANTPRESTNUM"]);
      }
    }

    private void chkPrestationUtil_CheckedChanged(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      apiTGridPrest.LoadData(dtPrest, MozartDatabase.cnxMozart, $"exec api_sp_listePrestation {iNumCli}, {(chkPrestation.Checked ? "'O'" : "'N'")}, {(chkUtil.Checked ? "'O'" : "'N'")}");
      chkPrestation.Text = chkPrestation.Checked ? Resources.msg_prix_vente_only : Resources.msg_affiche_prestations;
      Cursor.Current = Cursors.Default;
    }
  }
}

