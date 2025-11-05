using DevExpress.Data.Filtering;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestClientPrixPrestation : Form
  {
    public int miNumCli;
    public string msCliNom;

    DataTable dtPrix = new DataTable();
    DataTable dtPrest = new DataTable();

    public frmGestClientPrixPrestation() { InitializeComponent(); }

    private void frmGestClientPrixPrestation_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        string sql = $"SELECT NPRESTSERID, VPRESTSER FROM TPRESTSER WHERE CPRESTSER_ACTIF = 1";
        txtCritFouSer.Init(MozartDatabase.cnxMozart, sql, "NPRESTSERID", "VPRESTSER",
                          new List<string>() { Resources.col_Num, MZCtrlResources.col_Serie }, 250, 550, true);

        InitRs();

        InitForm();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdCoef_Click(object sender, EventArgs e)
    {
      new frmSaisieCoefPrestation()
      {
        msCliNom = msCliNom,
        miNumCli = miNumCli
      }.ShowDialog();

      Cursor.Current = Cursors.WaitCursor;

      apiTGridPrix.Requery(dtPrix, MozartDatabase.cnxMozart);

      Cursor.Current = Cursors.Default;
    }

    private void cmdAjout_Click(object sender, EventArgs e)
    {
      string sSQL;

      DataRow row = apiTGridPrest.GetFocusedDataRow();
      if (row == null) return;

      Cursor.Current = Cursors.WaitCursor;

      int nprestid = (int)Utils.ZeroIfNull(row["NPRESTID"]);

      //on insert le prix client en base
      sSQL = $"INSERT INTO TPRESTPRIXCLI(NPRESTID, NCLINUM, NPRIXCLI) VALUES({Utils.ZeroIfNull(row["NPRESTID"])}, {miNumCli}, {Utils.ZeroIfNull(row["PRIX"]).ToString().Replace(",", ".")})";

      ModuleData.CnxExecute(sSQL);

      apiTGridPrest.Requery(dtPrest, MozartDatabase.cnxMozart);
      apiTGridPrix.Requery(dtPrix, MozartDatabase.cnxMozart);

      //on repositionne le curseur
      for (int i = 0; i < dtPrix.Rows.Count; i++)
      {
        if ((int)Utils.ZeroIfNull(dtPrix.Rows[i]["NPRESTID"]) == nprestid)
        {
          (apiTGridPrix.GridControl.DefaultView as GridView).FocusedRowHandle = i;
        }
      }

      Cursor.Current = Cursors.Default;
    }

    private void cmdSup_Click(object sender, EventArgs e)
    {
      string sSQL;

      DataRow row = apiTGridPrix.GetFocusedDataRow();
      if (row == null) return;

      Cursor.Current = Cursors.WaitCursor;

      sSQL = $"DELETE FROM TPRESTPRIXCLI WHERE NPRESTID = {Utils.ZeroIfNull(row["NPRESTID"])} AND NCLINUm = {miNumCli}";
      ModuleData.CnxExecute(sSQL);

      apiTGridPrest.Requery(dtPrest, MozartDatabase.cnxMozart);
      apiTGridPrix.Requery(dtPrix, MozartDatabase.cnxMozart);

      Cursor.Current = Cursors.Default;
    }

    private void InitRs()
    {
      string sSQL;


      sSQL = "SELECT TPREST.NPRESTID, VPRESTSER, VPRESTLIB, VPRESTVUEWEBCLI, VPRESTCODE, " +
             "dbo.CalculPrixPrest(TPREST.NPRESTID) AS PRIX, " +
             "NPRIXCLI, (NPRESTQTEMO*NPRESTSERMOHT) AS PRIXMO, dbo.CalculFouPrest(TPREST.NPRESTID) AS PRIXFO, " +
             "CASE WHEN (CASE WHEN dbo.CalculPrixPrest(TPREST.NPRESTID) = 0 THEN NPRIXCLI Else dbo.CalculPrixPrest (TPREST.NPRESTID) END) = 0 THEN 0 ELSE CONVERT(decimal(9, 2), (NPRIXCLI / (CASE WHEN dbo.CalculPrixPrest(TPREST.NPRESTID) = 0 THEN NPRIXCLI Else dbo.CalculPrixPrest (TPREST.NPRESTID) END))) END As COEF " +
             "From TPREST, TPRESTPRIXCLI, TPRESTSER " +
             "Where TPREST.NPRESTID = TPRESTPRIXCLI.NPRESTID " +
             "AND TPREST.NPRESTSERID = TPRESTSER.NPRESTSERID " +
             $"AND TPRESTPRIXCLI.NCLINUM = {miNumCli} " +
             "AND CPRESTACTIF = 'O'";

      apiTGridPrix.LoadData(dtPrix, MozartDatabase.cnxMozart, sSQL);
      apiTGridPrix.GridControl.DataSource = dtPrix;
    }

    private void InitForm()
    {
      apiTGridPrest.AddColumn("NPRESTID", "NPRESTID", 0);
      apiTGridPrest.AddColumn(Resources.col_Serie, "VPRESTSER", 1500);
      apiTGridPrest.AddColumn(Resources.col_Prestation, "VPRESTLIB", 6000);
      apiTGridPrest.AddColumn(Resources.col_Code, "VPRESTCODE", 1000);
      apiTGridPrest.AddColumn(Resources.col_Prix_Revient_MO, "PRIXMO", 2000, "Currency", 2);
      apiTGridPrest.AddColumn(Resources.col_Prix_Revient_FO, "PRIXFO", 2000, "Currency", 2);
      apiTGridPrest.AddColumn(Resources.col_Prix_Revient_TOTAL, "PRIX", 2000, "Currency", 2);

      apiTGridPrest.InitColumnList();

      apiTGridPrix.AddColumn("NPRESTID", "NPRESTID", 0);
      apiTGridPrix.AddColumn(Resources.col_Serie, "VPRESTSER", 1500);
     //apiTGridPrix.AddColumn("Affichage web", "VPRESTVUEWEBCLI", 1400);
      apiTGridPrix.AddColumn(Resources.col_Prestation, "VPRESTLIB", 7000);
      apiTGridPrix.AddColumn(Resources.col_Code, "VPRESTCODE", 1000);
      apiTGridPrix.AddColumn(Resources.col_Prix_Revient_TOTAL, "PRIX", 1900, "Currency", 2);
      apiTGridPrix.AddColumn(Resources.col_PrixDeVente, "NPRIXCLI", 1900, "Currency", 2);
      apiTGridPrix.AddColumn(Resources.col_Coeff, "COEF", 1000, "0.00", 2);

      apiTGridPrix.DelockColumn("NPRIXCLI");
      //apiTGridPrix.DelockColumn("VPRESTVUEWEBCLI");
      apiTGridPrix.InitColumnList();

      Label2.Text += " " + msCliNom;


   /*   GridView gridView1 = apiTGridPrix.GridControl.MainView as GridView;
      RepositoryItemComboBox riComboBox = new RepositoryItemComboBox();
      riComboBox.Items.Add("NON");
      riComboBox.Items.Add("OUI");
      riComboBox.TextEditStyle = TextEditStyles.DisableTextEditor;
      gridView1.Columns["VPRESTVUEWEBCLI"].ColumnEdit = riComboBox;
      apiTGridPrix.GridControl.RepositoryItems.Add(riComboBox);
   */

    }

    private void apiTGridPrix_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      string sSQL;

      DataRow row = apiTGridPrix.GetFocusedDataRow();
      if (row == null) return;

      //on met a jour le prix
      if (e.Column.Name == "NPRIXCLI")
      {
        sSQL = $"UPDATE TPRESTPRIXCLI SET NPRIXCLI = {Utils.ZeroIfNull(row["NPRIXCLI"]).ToString().Replace(",", ".")} " +
               $"WHERE NCLINUM = {miNumCli} AND NPRESTID = {Utils.ZeroIfNull(row["NPRESTID"])}";

        ModuleData.CnxExecute(sSQL);
      }

      //if (e.Column.Name == "VPRESTVUEWEBCLI")
      //{
      //  sSQL = $"update TPRESTPRIXCLI set VPRESTVUEWEBCLI='{e.Value}' WHERE NCLINUM = {miNumCli} AND NPRESTID = {Utils.ZeroIfNull(row["NPRESTID"])}";
      //  ModuleData.CnxExecute(sSQL);
      //}

    }

    private void cmdFind_Click(object sender, EventArgs e)
    {
      string lReq;
      string sFiltre = "";

      Cursor.Current = Cursors.WaitCursor;

      if (txtCritFouSer.GetText().Trim() != "") sFiltre = sFiltre + $" AND VPRESTSER like '%{txtCritFouSer.GetText()}%'";
      if (TxtCritPresta.Text.Trim() != "") sFiltre = sFiltre + $" AND VPRESTLIB like '%{TxtCritPresta.Text.Replace("'", "''")}%'";
      if (TxtCritCreateur.Text.Trim() != "") sFiltre = sFiltre + $" AND VPRESTQUICRE like '%{TxtCritCreateur.Text.Replace("'", "''")}%'";
      if (TxtCritCode.Text.Trim() != "") sFiltre = sFiltre + $" AND VPRESTCODE like '%{TxtCritCode.Text.Replace("'", "''")}%'";

      // Au moins un filtre doit être renseigné
      if (sFiltre == "")
      {
        MessageBox.Show(Resources.msg_must_type_filter, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      lReq = "SELECT TPREST.NPRESTID, VPRESTSER, VPRESTLIB, VPRESTCODE, VPRESTQUICRE, " +
             "dbo.CalculPrixPrest(TPREST.NPRESTID) AS PRIX, " +
             "(NPRESTQTEMO*NPRESTSERMOHT) AS PRIXMO, dbo.CalculFouPrest(TPREST.NPRESTID) AS PRIXFO " +
             "From TPREST, TPRESTSER " +
             "Where TPREST.NPRESTSERID = TPRESTSER.NPRESTSERID " +
             $"AND TPREST.NPRESTID NOT IN (SELECT NPRESTID FROM TPRESTPRIXCLI WHERE NCLINUM = {miNumCli}) " +
             $"AND CPRESTACTIF = 'O' {sFiltre}";


      apiTGridPrest.LoadData(dtPrest, MozartDatabase.cnxMozart, lReq);
      apiTGridPrest.GridControl.DataSource = dtPrest;

      Cursor.Current = Cursors.Default;

    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
  }
}

