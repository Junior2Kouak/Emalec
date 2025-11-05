using DevExpress.XtraGrid.Views.Grid;
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
  public partial class frmRecherchePrestation : Form
  {
    public int miDclNum;
    public int miNumAction;     // <-- MozartParams.NumAction
    public bool mbAfficheInfoFou = true;
    public DataTable mdtPrestSaisie;   // <-- vient de frmDevisClientPrestation

    private int iNumCli;
    DataTable dtPrestations = new DataTable();


    public frmRecherchePrestation() { InitializeComponent(); }

    private void frmRecherchePrestation_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        iNumCli = (int)ModuleData.ExecuteScalarInt($"SELECT NCLINUM FROM TDCL WITH (NOLOCK), TACT WITH (NOLOCK), TDIN WITH (NOLOCK) WHERE TDCL.NACTNUM = TACT.NACTNUM " +
                                                   $"AND TACT.NDINNUM = TDIN.NDINNUM AND TDCL.NDCLNUM = {miDclNum}");

        //  on charge toutes les prestations dans la grille du haut
        apiTGridPrest.LoadData(dtPrestations, MozartDatabase.cnxMozart, $"exec api_sp_listePrestation {iNumCli}, 'N'");

        InitGridPrest();
        InitGridPrestSaisie();

        InitRSPrestSaisie();

        if (mbAfficheInfoFou)
        {
          string sActFou = ModuleData.ExecuteScalarString($"SELECT VACTFOU FROM TACT WITH (NOLOCK) WHERE  VACTFOU is not null and VACTFOU <> '' AND NACTNUM= {miNumAction}");
          if (sActFou != "")
          {
            apiToolTip1.Width = 400;
            apiToolTip1.Texte = sActFou; //textbox
            apiToolTip1.Titre = Resources.lbl_Demande_technicien;
            apiToolTip1.PrintTexte("");
            apiToolTip1.Texte += "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            apiToolTip1.Visible = true;
          }
        }

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

    private void chkPrestation_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.Default;

        apiTGridPrest.LoadData(dtPrestations, MozartDatabase.cnxMozart, $"exec api_sp_listePrestation {iNumCli}, '{(chkPrestation.Checked ? "O" : "N")}'");
        chkPrestation.Text = chkPrestation.Checked ? Resources.msg_prix_vente_only : Resources.msg_affiche_prestations;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      AjouterEnreg();
    }

    private void AjouterEnreg()
    {
      try
      {
        DataRow rowH = apiTGridPrest.GetFocusedDataRow();
        if (rowH == null) return;

        if (!VerifPrest(Convert.ToInt32(rowH["NPRESTID"])))
        {
          MessageBox.Show("Une fourniture de cette prestation a un prix de vente à 0, vous ne pouvez pas l'ajouter.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        DataRow newrow = mdtPrestSaisie.NewRow();
        newrow["CAT"] = "0.0";
        newrow["VPRESTCODE"] = rowH["VPRESTCODE"];
        newrow["NPRESTID"] = rowH["NPRESTID"];
        newrow["NPRESTSERID"] = rowH["NPRESTSERID"];
        newrow["VPRESTSER"] = rowH["VPRESTSER"];
        newrow["VPRESTLIB"] = rowH["VPRESTLIB"];
        newrow["VPRESTLIB"] = rowH["VPRESTLIB"];
        newrow["VPRESTUNITE"] = rowH["VPRESTUNITE"];
        newrow["NPRESTSERMOHT"] = rowH["NPRESTSERMOHT"];
        newrow["NPRESTQTEMO"] = rowH["NPRESTQTEMO"];
        newrow["NPRESTFOHT"] = rowH["NPRESTFOHT"];
        newrow["NQTE"] = 1;
        newrow["NTOTALHT"] = Convert.ToDecimal(Utils.ZeroIfNull((rowH["NPRIXCLI"])) == 0 ? rowH["TOTAL"] : rowH["NPRIXCLI"]);//TOTAL
        newrow["NPRIXCLI"] = Convert.ToDecimal(Utils.ZeroIfNull(rowH["NPRIXCLI"]) == 0 ? -1 : rowH["NPRIXCLI"]);
        newrow["NIDFICHEFO"] = 0;
        newrow["NIDFICHEMO"] = 0;
        newrow["BLDCLPREST_NUIT"] = 0;
        newrow["NPRESTSERCOEFNUIT"] = rowH["NPRESTSERCOEFNUIT"];
        newrow["NPRESTSERMOHT_BASE"] = rowH["NPRESTSERMOHT"];
        newrow["NPRIXCLINUIT"] = rowH["NPRIXCLINUIT"];
        newrow["NCOEFFPRIX"] = 1.7;

        using (SqlCommand cmd = new SqlCommand("api_sp_CreationLigneDevisPrestation", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@NumDevis"].Value = miDclNum;
          cmd.Parameters["@NprestId"].Value = newrow["NPRESTID"];
          cmd.Parameters["@NpresSerId"].Value = newrow["NPRESTSERID"];
          cmd.Parameters["@VUnite"].Value = newrow["VPRESTUNITE"];
          cmd.Parameters["@nQteMo"].Value = newrow["NPRESTQTEMO"];
          cmd.Parameters["@nFO"].Value = newrow["NPRESTFOHT"];
          cmd.Parameters["@nMOHT"].Value = newrow["NPRESTSERMOHT"];
          cmd.Parameters["@Qte"].Value = newrow["NQTE"];
          cmd.Parameters["@nPrixCli"].Value = newrow["NPRIXCLI"];
          cmd.Parameters["@vPrestLib"].Value = newrow["VPRESTLIB"];

          cmd.Parameters["@nPrixCliNuit"].Value = newrow["NPRIXCLINUIT"];
          cmd.Parameters["@NCOEFFPRIX"].Value = newrow["NCOEFFPRIX"];

          using (SqlDataReader drP = ModuleData.ExecuteReader($"SELECT NLDCLPRESTID,NPRESTID,NCATID,NSSCATID,NSS2CATID,VPRESTLIB, NIDFICHEFO, NIDFICHEMO FROM TLDCLPREST " +
                                                       $"WHERE NDCLNUM = {miDclNum} AND NLDCLPRESTID = {newrow["NLDCLPRESTID"]}"))
          {
            if (drP.Read())
            {
              cmd.Parameters["@nCatid"].Value = Utils.ZeroIfNull(drP["NCATID"]);
              cmd.Parameters["@nSSCatid"].Value = Utils.ZeroIfNull(drP["NSSCATID"]);
              cmd.Parameters["@nSS2Catid"].Value = Utils.ZeroIfNull(drP["NSS2CATID"]);
              cmd.Parameters["@nSS2Catid"].Value = drP["VPRESTLIB"];
              cmd.Parameters["@nidfichefo"].Value = Utils.ZeroIfNull(drP["NIDFICHEFO"]);
              cmd.Parameters["@nidfichemo"].Value = Utils.ZeroIfNull(drP["NIDFICHEMO"]);
            }
          }
          cmd.ExecuteNonQuery();
          newrow["NLDCLPRESTID"] = Convert.ToInt32(cmd.Parameters[0].Value);
        }

        newrow["NDCLNUM"] = miDclNum;

        mdtPrestSaisie.Rows.Add(newrow);
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
        // impossible de supprimer une prestation si elle est utilisée dans un contrat STT de prestation
        // il faut donc faire le test
        if ((int)ModuleData.ExecuteScalarInt($"select count(NLDCLPRESTID) from TCSTPREST INNER JOIN TCST ON TCST.NCSTNUM=TCSTPREST.NCSTNUM AND CCSTACTIF='O' where NLDCLPRESTID = {row["NLDCLPRESTID"]}") > 0)
        {
          MessageBox.Show("Prestation utilisée dans un contrat STT de prestation.\r\nImpossible de la supprimer du devis client.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          ModuleData.ExecuteNonQuery($"DELETE from TLDCLPREST where NLDCLPRESTID =    {row["NLDCLPRESTID"]}");
          ModuleData.ExecuteNonQuery($"DELETE from TLDCLPRESTFOU where NLDCLPRESTID = {row["NLDCLPRESTID"]}");
          mdtPrestSaisie.Rows.Remove(row);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    private void apiTGridPrest_DoubleClickE(object sender, EventArgs e)
    {
      cmdAjouter_Click(null, null);
    }

    private void InitGridPrest()
    {
      apiTGridPrest.AddColumn(Resources.col_Type, "VPREST_TYPE_LIB", 1500);
      apiTGridPrest.AddColumn(Resources.col_Serie, "VPRESTSER", 1500);
      apiTGridPrest.AddColumn(Resources.col_ss_serie, "VPREST_SS_SERIE_LIB", 1500);
      apiTGridPrest.AddColumn(Resources.col_Code, "VPRESTCODE", 1000);
      apiTGridPrest.AddColumn(Resources.col_Prestation, "VPRESTLIB", 9000);
      apiTGridPrest.AddColumn(Resources.col_unite, "VPRESTUNITE", 1000, "", 2);
      apiTGridPrest.AddColumn(Resources.col_Creator, "VPRESTQUICRE", 1800, "", 2);
      apiTGridPrest.AddColumn(Resources.col_MO_HT, "NPRESTSERMOHT", 1000, "Currency", 2);
      apiTGridPrest.AddColumn(Resources.col_qte_MO, "NPRESTQTEMO", 1000, "#", 2);
      apiTGridPrest.AddColumn(Resources.col_fournitures, "NPRESTFOHT", 1300, "Currency", 2);
      apiTGridPrest.AddColumn(Resources.col_PrixDeVente, "NPRIXCLI", 1500, "Currency", 2);
      apiTGridPrest.AddColumn(Resources.col_prix_vente_nuit, "NPRIXCLINUIT", 1500, "Currency", 2);
      apiTGridPrest.AddColumn(Resources.col_Total, "TOTAL", 1000, "Currency", 2);

      apiTGridPrest.InitColumnList();
      apiTGridPrest.GridControl.DataSource = dtPrestations;
    }

    private void apiTGridPrest_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
    {
      GridView View = sender as GridView;
      if (e.RowHandle >= 0)
      {
        if (View.GetDataRow(e.RowHandle)["COULEUR"].ToString().ToUpper() == "O")
        {
          e.Appearance.ForeColor = Color.Red;
          e.HighPriority = true;
        }
      }
    }

    private void InitGridPrestSaisie()
    {
      apiTGridPrestSaisie.AddColumn(Resources.col_categorie, "CAT", 700);
      apiTGridPrestSaisie.AddColumn("Code", "VPRESTCODE", 700);
      apiTGridPrestSaisie.AddColumn(Resources.col_Serie, "VPRESTSER", 1500);
      apiTGridPrestSaisie.AddColumn(Resources.col_Prestation, "VPRESTLIB", 7000);
      apiTGridPrestSaisie.AddColumn(Resources.col_unite, "VPRESTUNITE", 1000, "", 2);
      apiTGridPrestSaisie.AddColumn(Resources.col_MO_HT, "NPRESTSERMOHT", 1000, "Currency", 2);
      apiTGridPrestSaisie.AddColumn(Resources.col_qte_MO, "NPRESTQTEMO", 1000, "#", 2);
      apiTGridPrestSaisie.AddColumn(Resources.col_fournitures, "NPRESTFOHT", 1300, "Currency", 2);
      apiTGridPrestSaisie.AddColumn(Resources.col_qte2, "NQTE", 500, "0.##", 2);
      apiTGridPrestSaisie.AddColumn(Resources.col_J_N, "BLDCLPREST_NUIT", 750, "", 2, false, false, true);
      apiTGridPrestSaisie.AddColumn(Resources.col_Total, "NTOTALHT", 1000, "Currency", 2);
      apiTGridPrestSaisie.AddColumn("NPRESTSERCOEFNUIT", "NPRESTSERCOEFNUIT", 0);
      apiTGridPrestSaisie.AddColumn("NPRESTSERMOHT_BASE", "NPRESTSERMOHT_BASE", 0);
      apiTGridPrestSaisie.AddColumn("NPRIXCLINUIT", "NPRIXCLINUIT", 0);
      apiTGridPrestSaisie.AddColumn("NCOEFFPRIX", "NCOEFFPRIX", 0);

      apiTGridPrestSaisie.DelockColumn("NQTE");
      apiTGridPrestSaisie.DelockColumn("BLDCLPREST_NUIT");

      mdtPrestSaisie.Columns["NQTE"].ReadOnly = false;
      mdtPrestSaisie.Columns["BLDCLPREST_NUIT"].ReadOnly = false;

      apiTGridPrestSaisie.InitColumnList();
      apiTGridPrestSaisie.GridControl.DataSource = mdtPrestSaisie;
    }

    private void apiTGridPrestSaisie_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.RowHandle >= 0 && e.Column.Name == "NQTE")
        e.Appearance.BackColor = Color.FromArgb(255, 160, 0);
    }

    private void InitRSPrestSaisie()
    {
      // Ajouter la colonne NTOTALHT qui ne vient pas de la procstock
      if (!mdtPrestSaisie.Columns.Contains("NTOTALHT"))
        mdtPrestSaisie.Columns.Add(new DataColumn("NTOTALHT", Type.GetType("System.Double")));

      foreach (DataRow row in mdtPrestSaisie.Rows)
      {
        row["NTOTALHT"] = Utils.ZeroIfNull(row["NPRIXCLITOT"]) == 0 ? row["TOTAL"] : row["NPRIXCLITOT"];
        row["NPRIXCLI"] = Utils.ZeroIfNull(row["NPRIXCLI"]) == 0 ? -1 : row["NPRIXCLI"];
        row["NPRIXCLINUIT"] = Utils.ZeroIfNull(row["NPRIXCLINUIT"]) == 0 ? -1 : row["NPRIXCLINUIT"];
      }
    }

    private void apiTGridPrestSaisie_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      DataRow row = apiTGridPrestSaisie.GetFocusedDataRow();
      if (null == row) return;

      //  ' si on met à jour la quantité, on recalcule le total HT
      if (e.Column.Name == "NQTE")
      {
        // si on a un prix client on fait le calcul avec
        if (Utils.ZeroIfNull(row["NPRIXCLI"]) < 0)
          row["NTOTALHT"] = (Convert.ToDouble(row["NPRESTSERMOHT"]) * Convert.ToDouble(row["NPRESTQTEMO"]) + Convert.ToDouble(row["NPRESTFOHT"])) * Convert.ToDouble(row["NQTE"]);
        else
          row["NTOTALHT"] = Convert.ToDouble(row["NPRIXCLI"]) * Convert.ToDouble(row["NQTE"]);

        ModuleData.ExecuteNonQuery($"UPDATE TLDCLPREST SET NQTE = {row["NQTE"].ToString().Replace(",", ".")} WHERE NLDCLPRESTID = {row["NLDCLPRESTID"]}");
      }
    }
    //gestion du tarif jour/nuit
    private void apiTGridPrestSaisie_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      DataRow row = apiTGridPrestSaisie.GetFocusedDataRow();
      if (null == row) return;

      if (e.Column.Name == "BLDCLPREST_NUIT")
      {
        // si on a un prix client on fait le calcul avec
        if (Utils.ZeroIfNull(row["NPRIXCLI"]) < 0)
        {

          if (Convert.ToDouble(row["NPRESTSERMOHT"]) == Convert.ToDouble(row["NPRESTSERMOHT_BASE"]))
          { // si le tarif nuit vient d'être choché
            row["BLDCLPREST_NUIT"] = true;
            row["NPRESTSERMOHT"] = Convert.ToDouble(row["NPRESTSERMOHT_BASE"]) * Convert.ToDouble(row["NPRESTSERCOEFNUIT"]);
          }
          else
          {
            row["BLDCLPREST_NUIT"] = false;
            row["NPRESTSERMOHT"] = Convert.ToDouble(row["NPRESTSERMOHT_BASE"]);
          }

          row["NTOTALHT"] = (Convert.ToDouble(row["NPRESTSERMOHT"]) * Convert.ToDouble(row["NPRESTQTEMO"]) + Convert.ToDouble(row["NPRESTFOHT"])) * Convert.ToDouble(row["NQTE"]);
        }
        else
        {
          if (Convert.ToDouble(row["NPRESTSERMOHT"]) == Convert.ToDouble(row["NPRESTSERMOHT_BASE"]))
          { // si le tarif nuit vient d'être choché
            row["BLDCLPREST_NUIT"] = true;
            row["NPRESTSERMOHT"] = Convert.ToDouble(row["NPRESTSERMOHT_BASE"]) * Convert.ToDouble(row["NPRESTSERCOEFNUIT"]);
            row["NTOTALHT"] = Utils.ZeroIfNull(row["NPRIXCLINUIT"]) * Convert.ToDouble(row["NQTE"]);
          }
          else
          {
            row["BLDCLPREST_NUIT"] = false;
            row["NTOTALHT"] = Utils.ZeroIfNull(row["NPRIXCLI"]) * Convert.ToDouble(row["NQTE"]);
          }
        }
        ModuleData.ExecuteNonQuery($"UPDATE TLDCLPREST SET BLDCLPREST_NUIT = {(Convert.ToInt32(row["BLDCLPREST_NUIT"]) == 1 ? "1" : "0")}, " +
                                   $"NPRESTSERMOHT = {row["NPRESTSERMOHT"].ToString().Replace(",", ".")} WHERE NLDCLPRESTID = {row["NLDCLPRESTID"]}");
      }
    }

    private bool VerifPrest(int iPrestId)
    {
      return ModuleData.ExecuteScalarObject($"SELECT NFOUNUM FROM TLPRESTFOU Where NPRESTID = {iPrestId} AND ISNULL((SELECT min(FPUHT/FPUNITE) " +
                                            $"FROM TSTFFOU WHERE (FPUHT/FPUNITE) > 0  AND NFOUNUM = TLPRESTFOU.NFOUNUM GROUP BY NFOUNUM), 0) =0") == null;
    }

    private void chkUtil_CheckedChanged(object sender, EventArgs e)
    {
      apiTGridPrest.LoadData(dtPrestations, MozartDatabase.cnxMozart, $"exec api_sp_listePrestation {iNumCli}, {(chkPrestation.Checked ? "'O'" : "'N'")}, {(chkUtil.Checked ? "'O'" : "'N'")}");
      chkPrestation.Text = chkPrestation.Checked ? Resources.msg_prix_vente_only : Resources.msg_affiche_prestations;
    }
  }
}
