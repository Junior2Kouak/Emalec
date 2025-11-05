using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatQualActNonConf : Form
  {
    DataTable dt = new DataTable();

    public frmStatQualActNonConf() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmStatQualActNonConf_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //Init
        Label7.Text += "" + DateTime.Now.ToShortDateString();
        apiTGrid.FilterBar = false;

        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, "SELECT NPERNUM, VPERNOM, NACTDEPPLA, NACTPLA, NACTAPLA, NACTDEVAFAIRE, NACTEXEATTFACT, NACTATTENTE, NACTACCEPT30J, NACTACCEPT60J, NACTACCEPT90J FROM [STATISTIQUE].dbo.[TSTATACTANO] ORDER BY VPERNOM");
        apiTGrid.GridControl.DataSource = dt;

        InitGrid();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    /* TODO --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //
    //On Error GoTo handler
    //
    //    InitBoutons Me, frmMenu
    //    
    //    Screen.MousePointer = vbDefault
    //  
    //    'Init
    //    Label7.Caption = Label7.Caption & Date
    //    apiTGrid.FilterBar = False
    //    
    //    InitGrid
    //    
    //    ado_rs.Open "SELECT NPERNUM, VPERNOM, NACTDEPPLA, NACTPLA, NACTAPLA, NACTDEVAFAIRE, NACTEXEATTFACT, NACTATTENTE, NACTACCEPT30J, NACTACCEPT60J, NACTACCEPT90J FROM [STATISTIQUE].dbo.[TSTATACTANO] ORDER BY VPERNOM", cnx
    //    If ado_rs.RecordCount > 0 Then apiTGrid.Init ado_rs
    //
    //    Exit Sub
    //  
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void apiTGrid_RowCellClick(object sender, RowCellClickEventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row) return;

      if (e.Column.AbsoluteIndex == 0)
        return;

      new frmStatQualActNonConfDetail()
      {
        p_npernum = (int)Utils.ZeroIfBlank(row["NPERNUM"]),
        p_vpernom = Utils.BlankIfNull(row["VPERNOM"]),
        p_ntypestat = e.Column.AbsoluteIndex,
      }.ShowDialog();
    }
    //Private Sub apiTGrid_Click()
    //
    //    If apiTGrid.col > 0 Then
    //    
    //        If ado_rs.RecordCount = 0 Then Exit Sub
    //
    //        frmStatQualActNonConfDetail.p_NPERNUM = ado_rs("NPERNUM")
    //        frmStatQualActNonConfDetail.p_vpernom = ado_rs("VPERNOM")
    //        frmStatQualActNonConfDetail.p_ntypestat = apiTGrid.col
    //        frmStatQualActNonConfDetail.Show vbModal
    //    
    //    End If
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitGrid()
    {
      apiTGrid.AddColumn(Resources.col_ChargeAffaires, "VPERNOM", 2200, "", 2);
      apiTGrid.AddColumn(Resources.txt_Dep_Planifies, "NACTDEPPLA", 1400, "", 2);
      apiTGrid.AddColumn(Resources.col_Planifies, "NACTPLA", 1400, "", 2);
      apiTGrid.AddColumn(Resources.col_a_Planifier, "NACTAPLA", 1400, "", 2);
      apiTGrid.AddColumn(Resources.txt_Devis_a_Faire, "NACTDEVAFAIRE", 1400, "", 2);
      apiTGrid.AddColumn(Resources.col_Exe_Non_Fact_ceJour, "NACTEXEATTFACT", 1400, "", 2);
      apiTGrid.AddColumn("En attente accord client", "NACTATTENTE", 1400, "", 2);
      apiTGrid.AddColumn(Resources.col_sup30, "NACTACCEPT30J", 1700, "", 2);
      apiTGrid.AddColumn(Resources.col_sup60, "NACTACCEPT60J", 1700, "", 2);
      apiTGrid.AddColumn(Resources.col_sup90, "NACTACCEPT90J", 1700, "", 2);

      apiTGrid.InitColumnList();
    }
    //Private Sub InitGrid()
    //
    //On Error GoTo handler
    //
    //  apiTGrid.AddColumn "§Chargé d'affaires§", "VPERNOM", 2200, , 2
    //  apiTGrid.AddColumn "§Dépannages planifiés§", "NACTDEPPLA", 1400, , 2
    //  apiTGrid.AddColumn "§Planifiés§", "NACTPLA", 1400, , 2
    //  apiTGrid.AddColumn "§A planifier§", "NACTAPLA", 1400, , 2
    //  apiTGrid.AddColumn "§Devis à faire§", "NACTDEVAFAIRE", 1400, , 2
    //  apiTGrid.AddColumn "§Exé non fact à ce jour§", "NACTEXEATTFACT", 1400, , 2
    //  apiTGrid.AddColumn "En attente accord client", "NACTATTENTE", 1400, , 2
    //  apiTGrid.AddColumn "§> 30j§", "NACTACCEPT30J", 1700, , 2
    //  apiTGrid.AddColumn "§> 60j§", "NACTACCEPT60J", 1700, , 2
    //  apiTGrid.AddColumn "§> 90j§", "NACTACCEPT90J", 1700, , 2
    //  
    //  Exit Sub
    //  
    //handler:
    //  ShowError "Initgrid dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //
    //    Unload Me
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //
    //    If ado_rs.State = adStateOpen Then ado_rs.Close
    //    Set ado_rs = Nothing
    //    
    //End Sub
    //

  }
}

