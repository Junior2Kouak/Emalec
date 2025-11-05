using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
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
  public partial class frmDevisClientAvenant : Form
  {
    public int miNumDCLPrest;
    public int miNumDemandeur; // doit être renseigné par frmDevisClientPrestation

    private DataTable dtPrestations = new DataTable();
    private DataTable dtAvenants = new DataTable();
    private DataTable dtCategories = new DataTable();
    private bool bModifPossible = false;

    private SqlDataAdapter daCat = new SqlDataAdapter();
    private readonly SqlCommandBuilder cbCat = new SqlCommandBuilder();

    public frmDevisClientAvenant() { InitializeComponent(); }

    private void frmDevisClientAvenant_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiGridAvenant.LoadData(dtAvenants, MozartDatabase.cnxMozart, "EXEC api_sp_ListeAvenantPrest " + miNumDCLPrest);
        if (dtAvenants.Rows.Count > 0)
        {
          DataRow row0 = dtAvenants.Rows[0];
          apiGridPrestation.LoadData(dtPrestations, MozartDatabase.cnxMozart, $"exec api_sp_listePrestDevisAvenant {row0["NAVENANTNUM"]}");
          txtPrestation.Text = Utils.BlankIfNull(row0["VAVEPRESTATION"]);

          InitRs();
          InitGrid();
        }

        InitapiGridH();
        InitapiGridB();

        txtHT.Text = CalculTotHT();
        bModifPossible = ModifPossible();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void apiGridAvenant_Click(object sender, EventArgs e)
    {
      DataRow row = apiGridAvenant.GetFocusedDataRow();
      if (row == null) return;

      bModifPossible = ModifPossible();
      apiGridPrestation.LoadData(dtPrestations, MozartDatabase.cnxMozart, $"exec api_sp_listePrestDevisAvenant {row["NAVENANTNUM"]}");
      txtPrestation.Text = Utils.BlankIfNull(row["VAVEPRESTATION"]);
      txtHT.Text = CalculTotHT();

      InitRs();
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      string sLibAvenant = Interaction.InputBox("Entrer le libellé du devis", "Libellé du devis TS");
      if (sLibAvenant == "") return;

      using (SqlCommand cmd = new SqlCommand("api_sp_CreationAvenant", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        cmd.Parameters["@iNumAvenant"].Value = 0;
        cmd.Parameters["@iNumDCL"].Value = miNumDCLPrest;
        cmd.Parameters["@dDatAvenant"].Value = DateTime.Now.ToShortDateString();
        cmd.Parameters["@vLibAvenant"].Value = sLibAvenant;
        cmd.Parameters["@vPrestAvenant"].Value = txtPrestation.Text;
        cmd.ExecuteNonQuery();
      }

      apiGridAvenant.Requery(dtAvenants, MozartDatabase.cnxMozart);

      int value = apiGridAvenant.dgv.RowCount - 1;
      apiGridAvenant.dgv.TopRowIndex = value;
      apiGridAvenant.dgv.FocusedRowHandle = value;

      apiGridAvenant_Click(null, null);
    }

    private void CmdEnregistrer_Click(object sender, EventArgs e)
    {
      DataRow row = apiGridAvenant.GetFocusedDataRow();
      if (row == null) return;

      try
      {
        ModuleData.ExecuteNonQuery($"UPDATE TAVENANT SET VAVEPRESTATION = '{txtPrestation.Text.Replace("'", "''")}' WHERE NAVENANTNUM = {row["NAVENANTNUM"]}");
        apiGridAvenant.Requery(dtAvenants, MozartDatabase.cnxMozart);

        ColumnView viewCat = apiGridCat.GridControl.FocusedView as ColumnView;
        viewCat.CloseEditor();
        if (viewCat.UpdateCurrentRow())
          daCat.Update(dtCategories);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      DataRow row = apiGridAvenant.GetFocusedDataRow();
      if (row == null) return;

      try
      {
        if (!bModifPossible)
        {
          MessageBox.Show(Resources.msg_impossible_devis_passe_avenant, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (MessageBox.Show("Voulez-vous supprimer ce devis?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          ModuleData.ExecuteNonQuery($"DELETE FROM TAVENANT WHERE NAVENANTNUM = {row["NAVENANTNUM"]}");
          ModuleData.ExecuteNonQuery($"DELETE FROM TLAVENANTPREST WHERE NAVENANTNUM = {row["NAVENANTNUM"]}");
          ModuleData.ExecuteNonQuery($"DELETE FROM TLAVENANTPRESTFOU WHERE NAVENANTNUM = {row["NAVENANTNUM"]}");

          apiGridAvenant.Requery(dtAvenants, MozartDatabase.cnxMozart);
          txtHT.Text = CalculTotHT();
          apiGridAvenant_Click(null, null);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void InitapiGridH()
    {
      apiGridAvenant.AddColumn("NAVENANTNUM", "NAVENANTNUM", 0);
      apiGridAvenant.AddColumn("NDCLNUM", "NDCLNUM", 0);
      apiGridAvenant.AddColumn(Resources.col_Date, "DAVENANTCREA", 1500);
      apiGridAvenant.AddColumn(Resources.col_lib_devis, "VAVENANTLIB", 6000);
      apiGridAvenant.AddColumn(Resources.col_coef_MO, "NAVMOE", 1500, "", 2);
      apiGridAvenant.AddColumn(Resources.col_coef_FOU, "NAVFOU", 1500, "", 2);
      apiGridAvenant.AddColumn(Resources.col_valid_client, "CVALIDATION", 1500, "", 2);

      apiGridAvenant.DelockColumn("NAVMOE");
      apiGridAvenant.DelockColumn("NAVFOU");
      apiGridAvenant.DelockColumn("VAVENANTLIB");

      apiGridAvenant.InitColumnList();
      apiGridAvenant.GridControl.DataSource = dtAvenants;
    }

    private void InitapiGridB()
    {
      apiGridPrestation.AddColumn("ID", "NLAVENANTPRESTNUM", 0);
      apiGridPrestation.AddColumn("Chap", "NCLASSID", 500);
      apiGridPrestation.AddColumn("Index1", "NSSCATID", 500);
      apiGridPrestation.AddColumn(Resources.col_Prestation, "VPRESTLIB", 5000);
      apiGridPrestation.AddColumn(Resources.col_unite, "VPRESTUNITE", 400, "", 2);
      apiGridPrestation.AddColumn(Resources.col_qte2, "NQTE", 500, "", 2);
      apiGridPrestation.AddColumn(Resources.col_totalHT, "NPRESTSERMOHT", 1000, "Currency", 2);
      apiGridPrestation.AddColumn(Resources.col_Nb_H, "NPRESTQTEMO", 650, "", 2);
      apiGridPrestation.AddColumn(Resources.col_fournitures, "FOU", 1500, "Currency", 2);
      apiGridPrestation.AddColumn(Resources.col_Total, "TOTAL", 1200, "Currency", 2);
      apiGridPrestation.AddColumn(Resources.col_Coeff, "TOTALCOEF", 1600, "Currency", 2);
      apiGridPrestation.AddColumn(Resources.col_Prix_Client, "NPRIXCLITOT", 1000, "Currency", 2);

      apiGridPrestation.DelockColumn("NCLASSID");
      apiGridPrestation.DelockColumn("NSSCATID");

      apiGridPrestation.InitColumnList();
      apiGridPrestation.GridControl.DataSource = dtPrestations;
    }

    private void apiGridPrestation_RowStyle(object sender, RowStyleEventArgs e)
    {
      if (e.RowHandle >= 0)
      {
        if ((sender as GridView).GetDataRow(e.RowHandle)["COULEUR"].ToString().ToUpper() == "O")
        {
          e.Appearance.ForeColor = Color.Red;
          e.HighPriority = true;
        }
      }
    }

    private string CalculTotHT()
    {
      double TotalMO = 0;
      double TotalFO = 0;
      double TotalPrixCli = 0;

      DataRow rowAvenant = apiGridAvenant.GetFocusedDataRow();
      if (rowAvenant == null) return "";

      foreach (DataRow rowP in dtPrestations.Rows)
      {
        if (Utils.ZeroIfNull(rowP["NPRIXCLI"]) == 0)
        {
          TotalMO += Convert.ToDouble(rowP["NPRESTSERMOHT"]) * Convert.ToDouble(rowP["NPRESTQTEMO"]) * Convert.ToDouble(rowP["NQTE"]);
          TotalFO += Convert.ToDouble(rowP["NPRESTFOHT"]) * Convert.ToDouble(rowP["NQTE"]);
        }
        else
          TotalPrixCli += Convert.ToDouble(rowP["NPRIXCLI"]) * Convert.ToDouble(rowP["NQTE"]);
      }

      TotalMO *= Convert.ToDouble(rowAvenant["NAVMOE"]);
      TotalFO *= Convert.ToDouble(rowAvenant["NAVFOU"]);

      return (TotalMO + TotalFO + TotalPrixCli).ToString("# ##0.00");
    }

    private bool ModifPossible()
    {
      bool bRet = true;
      if (dtAvenants.Rows.Count == 0)
        return bRet;
      else
      {
        DataRow row = apiGridAvenant.GetFocusedDataRow();
        bRet = ((int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TAVANCEMENT INNER JOIN TLAVENANTPREST ON TAVANCEMENT.NLAVENANTPRESTNUM " +
                                                 $" = TLAVENANTPREST.NLAVENANTPRESTNUM WHERE NAVENANTNUM = {row["NAVENANTNUM"]}") == 0);
      }
      return bRet;
    }

    private void CmdPrest_Click(object sender, EventArgs e)
    {
      DataRow row = apiGridAvenant.GetFocusedDataRow();
      if (row == null) return;

      if (!bModifPossible)
      {
        MessageBox.Show(Resources.msg_impossible_devis_valide, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      frmRecherchePrestAvenant f = new frmRecherchePrestAvenant();
      f.miNumDevis = Convert.ToInt32(row["NDCLNUM"]);
      f.miNumAvenant = Convert.ToInt32(row["NAVENANTNUM"]);
      f.mdtPrestationSaisie = dtPrestations;
      f.ShowDialog();

      apiGridPrestation.Requery(dtPrestations, MozartDatabase.cnxMozart);
      txtHT.Text = CalculTotHT();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow rowAvenant = apiGridAvenant.GetFocusedDataRow();
        if (rowAvenant == null) return;

        if (rowAvenant["CVALIDATION"].ToString() == "NON")
          ModuleData.ExecuteNonQuery($"UPDATE TAVENANT SET CVALIDATION = 'OUI', DVALIDATION = getdate(), NQUIVALIDATION = {MozartParams.UID} WHERE NAVENANTNUM = {rowAvenant["NAVENANTNUM"]}");
        else
        {
          if (bModifPossible)
            if (MessageBox.Show("Voulez-vous invalider ce devis?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
              ModuleData.ExecuteNonQuery($"UPDATE TAVENANT SET CVALIDATION = 'NON', DVALIDATION = null, NQUIVALIDATION = null WHERE NAVENANTNUM = {rowAvenant["NAVENANTNUM"]}");
        }
        apiGridAvenant.Requery(dtAvenants, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow rowAvenant = apiGridAvenant.GetFocusedDataRow();
        if (rowAvenant == null) return;

        DataRow rowPrestation = apiGridPrestation.GetFocusedDataRow();
        if (rowPrestation == null) return;

        string[,] TdbGlobal = { { "Copie", "ORIGINAL" } };

        frmBrowser f = new frmBrowser();

        //  on fait un traitement spécifique abvec NCCLCODE
        f.msInfosMail = "TCCL|NCCLCODE|" + miNumDemandeur;     // TABLE | ID    --VL 16/11/04

        f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TDevisClientTS.rtf",
                        $@"TDevisClientTS_{rowAvenant["NAVENANTNUM"]}.rtf",
                        TdbGlobal,
                        $"exec api_sp_ImpDevisTS {rowAvenant["NAVENANTNUM"]}",
                        " (Visualisation devis client)",
                        "PREVIEW");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //private void apiGridAvenant_CellValueChanged(object sender, CellValueChangedEventArgs e)
    //{
    //  DataRow row = apiGridPrestation.GetFocusedDataRow();

    //  //modif du coef MO ou FOU --> requery pour charger les nouveaux tarifs + calcul Total
    //  if (e.RowHandle == 4 || e.RowHandle == 5)
    //  {
    //    apiGridAvenant.Requery(dtAvenants, MozartDatabase.cnxMozart);
    //    CalculTotHT();
    //  }
    //}

    //private void apiGridPrestation_CellValueChanged(object sender, CellValueChangedEventArgs e)
    //{
    //  DataRow row = apiGridPrestation.GetFocusedDataRow();

    //  if (e.RowHandle == 0) // colonne chapitre 1
    //    ModuleData.ExecuteNonQuery($"UPDATE TLAVENANTPREST SET NCLASSID = {row["NCLASSID"]} WHERE NLAVENANTPRESTNUM = {row["NLAVENANTPRESTNUM"]}");

    //  if (e.RowHandle == 1) // colonne chapitre 2
    //    ModuleData.ExecuteNonQuery($"UPDATE TLAVENANTPREST SET NSSCATID = {row["NSSCATID"]} WHERE NLAVENANTPRESTNUM = {row["NLAVENANTPRESTNUM"]}");
    //}

    private void apiGridAvenant_CellValueChanging(object sender, CellValueChangedEventArgs e)
    {
      if (!bModifPossible)
      {
        MessageBox.Show(Resources.msg_impossible_devis_passe_avenant, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        (sender as GridView).CancelUpdateCurrentRow();
      }
    }

    private void InitGrid()
    {
      apiGridCat.AddColumn("NAVENANTNUM", "NAVENANTNUM", 0);
      apiGridCat.AddColumn("Chapitre", "NCATID", 1500, "", 2);
      apiGridCat.AddColumn("Libellé", "VCATLIB", 4000);

      apiGridCat.DelockColumn("NCATID");
      apiGridCat.DelockColumn("VCATLIB");

      apiGridCat.dgv.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
      apiGridCat.dgv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
      apiGridCat.dgv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;

      apiGridCat.InitColumnList();
    }

    private void InitRs()
    {
      ColumnView viewCat = apiGridCat.GridControl.FocusedView as ColumnView;
      viewCat.CloseEditor();
      if (viewCat.UpdateCurrentRow())
        daCat.Update(dtCategories);

      dtCategories.Clear();

      DataRow row = apiGridAvenant.GetFocusedDataRow();
      string sSql;
      if (row == null)
        sSql = $"SELECT NCATID, VCATLIB, NAVENANTNUM FROM TLAVENANTPRESTCAT WHERE NAVENANTNUM = {dtAvenants.Rows[0]["NAVENANTNUM"]} ORDER BY NCATID";
      else
        sSql = $"SELECT NCATID, VCATLIB, NAVENANTNUM FROM TLAVENANTPRESTCAT WHERE NAVENANTNUM = {row["NAVENANTNUM"]} ORDER BY NCATID";

      daCat = new SqlDataAdapter(sSql, MozartDatabase.cnxMozart);
      daCat.Fill(dtCategories);
      apiGridCat.GridControl.DataSource = dtCategories;
      cbCat.DataAdapter = daCat;
    }

    private void apiGridCat_InitNewRowE(object sender, InitNewRowEventArgs e)
    {
      DataRow rowAv = apiGridAvenant.GetFocusedDataRow();
      (sender as GridView).SetRowCellValue(e.RowHandle, "NAVENANTNUM", rowAv["NAVENANTNUM"]);
    }

    private void apiGridCat_ValidateRowE(object sender, ValidateRowEventArgs e)
    {
    }
  }
}
