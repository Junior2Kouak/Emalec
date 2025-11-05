using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmAnaGidtCli : Form
  {
    public int miNumClient;

    private SqlDataAdapter daAC = new SqlDataAdapter();
    private SqlDataAdapter daCR = new SqlDataAdapter();
    private readonly SqlCommandBuilder cbAC = new SqlCommandBuilder();
    private readonly SqlCommandBuilder cbCR = new SqlCommandBuilder();

    DataTable dtAC = new DataTable();
    DataTable dtCR = new DataTable();

    //Dim rsAC As ADODB.Recordset
    //Dim rsCR As ADODB.Recordset

    public frmAnaGidtCli()
    {
      InitializeComponent();
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void frmAnaGidtCli_Load(object sender, System.EventArgs e)
    {
      ModuleMain.Initboutons(this);

      InitRS();
      InitGrids();

      grdAffectCompt.btnExcel.Visible = grdAffectCompt.btnPrint.Visible = grdAffectCompt.chkColumnsList.Visible = false;
      grdCentreRes.btnExcel.Visible = grdCentreRes.btnPrint.Visible = grdCentreRes.chkColumnsList.Visible = false;
    }
    //Private Sub Form_Load()
    //  InitBoutons Me, frmMenu
    //  InitRS
    //  InitGrids
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitGrids()
    {
      grdAffectCompt.AddColumn(Resources.col_Code, "NCOD", 100);
      grdAffectCompt.AddColumn(Resources.col_Lbl, "VLIB", 600);
      grdAffectCompt.AddColumn("NCLINUM", "NCLINUM", 0);   // Utile pour la mise à jour

      grdAffectCompt.DelockColumn("NCOD");
      grdAffectCompt.DelockColumn("VLIB");

      grdAffectCompt.FilterBar = false;

      grdAffectCompt.dgv.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
      grdAffectCompt.dgv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
      grdAffectCompt.dgv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;

      grdAffectCompt.InitColumnList();


      grdCentreRes.AddColumn(Resources.col_Code, "NCOD", 100);
      grdCentreRes.AddColumn(Resources.col_Lbl, "VLIB", 600);
      grdCentreRes.AddColumn("NCLINUM", "NCLINUM", 0);    // Utile pour la mise à jour

      grdCentreRes.DelockColumn("NCOD");
      grdCentreRes.DelockColumn("VLIB");

      grdCentreRes.FilterBar = false;

      grdCentreRes.InitColumnList();

      grdCentreRes.dgv.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
      grdCentreRes.dgv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
      grdCentreRes.dgv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
    }
    //Private Sub InitGrids()
    //  grdAfectCompt.AddColumn "Code", "NCOD", 1000
    //  grdAfectCompt.AddColumn "Libellé", "VLIB", 2000

    //  grdAfectCompt.DelockColumn "NCOD"
    //  grdAfectCompt.DelockColumn "VLIB"
    //  grdAfectCompt.AllowAddNew = True
    //  grdAfectCompt.AllowDelete = True
    //  grdAfectCompt.FilterBar = False

    //  grdAfectCompt.Init rsAC

    //  grdCentreRes.AddColumn "Code", "NCOD", 1000
    //  grdCentreRes.AddColumn "Libellé", "VLIB", 2000

    //  grdCentreRes.DelockColumn "NCOD"
    //  grdCentreRes.DelockColumn "VLIB"
    //  grdCentreRes.AllowAddNew = True
    //  grdCentreRes.AllowDelete = True
    //  grdCentreRes.FilterBar = False

    //  grdCentreRes.Init rsCR
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitRS()
    {
      daAC = new SqlDataAdapter($"SELECT * FROM TGIDTCLIAC WHERE NCLINUM = {miNumClient} ORDER BY NCOD, VLIB", MozartDatabase.cnxMozart);
      daAC.Fill(dtAC);
      grdAffectCompt.GridControl.DataSource = dtAC;
      cbAC.DataAdapter = daAC;

      daCR = new SqlDataAdapter($"SELECT * FROM TGIDTCLICR WHERE NCLINUM = {miNumClient} ORDER BY NCOD, VLIB", MozartDatabase.cnxMozart);
      daCR.Fill(dtCR);
      grdCentreRes.GridControl.DataSource = dtCR;
      cbCR.DataAdapter = daCR;
    }
    //Private Sub InitRS()
    //  Set rsAC = New ADODB.Recordset
    //  Set rsCR = New ADODB.Recordset

    //  rsAC.Open "SELECT * FROM TGIDTCLIAC WHERE NCLINUM = " & frmDetailsClient.miNumClient & " ORDER BY NCOD, VLIB", cnx, adOpenDynamic, adLockOptimistic
    //  rsCR.Open "SELECT * FROM TGIDTCLICR WHERE NCLINUM = " & frmDetailsClient.miNumClient & " ORDER BY NCOD, VLIB", cnx, adOpenDynamic, adLockOptimistic
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      try
      {
        ColumnView viewAC = grdAffectCompt.GridControl.FocusedView as ColumnView;
        viewAC.CloseEditor();
        if (viewAC.UpdateCurrentRow())
          daAC.Update(dtAC);

        ColumnView viewCR = grdCentreRes.GridControl.FocusedView as ColumnView;
        viewCR.CloseEditor();
        if (viewCR.UpdateCurrentRow())
          daCR.Update(dtCR);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  On Error Resume Next
    //  rsAC.Close
    //  rsCR.Close
    //  Unload Me
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void grids_InitNewRowE(object sender, InitNewRowEventArgs e)
    {
      (sender as GridView).SetRowCellValue(e.RowHandle, "NCLINUM", miNumClient);
    }
    //Private Sub grdAfectCompt_OnAddNew()
    //  rsAC("NCLINUM").Value = frmDetailsClient.miNumClient
    //End Sub

    //Private Sub grdCentreRes_OnAddNew()
    // rsCR("NCLINUM").Value = frmDetailsClient.miNumClient
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void grids_PreviewKeyDownE(object sender, PreviewKeyDownEventArgs e)
    {
      GridView currentView = (sender as GridControl).FocusedView as GridView;
      if (e.KeyCode == Keys.Delete)
        currentView.DeleteRow(currentView.FocusedRowHandle);
    }
  }
}

