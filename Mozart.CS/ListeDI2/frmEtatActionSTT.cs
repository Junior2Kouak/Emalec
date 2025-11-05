using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmEtatActionSTT : Form
  {
    DataTable dt = new DataTable();
    //Dim adors As ADODB.Recordset

    TooltipGridTPE _tpe;

    public frmEtatActionSTT() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmEtatActionSTT_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //ouverture du recordset
        apigrid.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeEtatActionSTT");
        apigrid.GridControl.DataSource = dt;

        InitapiGrid();

        _tpe = new TooltipGridTPE(apigrid, toolTipController1);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()
    //
    //Dim sSQL As String
    //
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    // 
    //  ' ouverture du recordset
    //  Set adors = New ADODB.Recordset
    //  sSQL = "exec api_sp_ListeEtatActionSTT "
    //  adors.Open sSQL, cnx
    //    
    //  InitapiGrid
    //    
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load  dans " & Me.Name
    //    
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitapiGrid()
    {
      apigrid.AddColumn(Resources.col_DI, "NDINNUM", 600);
      apigrid.AddColumn(Resources.col_stt, "VSTFNOM", 2000);
      apigrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2000);
      apigrid.AddColumn(Resources.col_Site, "VSITNOM", 2000);
      apigrid.AddColumn(Resources.col_ChefGroupe, "RESP_GRP", 1200);
      apigrid.AddColumn(Resources.col_Chaff, "VDINCHAFF", 1200);
      apigrid.AddColumn(Resources.col_Contrat, "NCSTNUM", 600);
      apigrid.AddColumn(Resources.col_Action, "VACTDES", 3700, "", 0, true);
      apigrid.AddColumn(Resources.col_T_echnique, "CTECCOD", 300, "", 2);
      apigrid.AddColumn(Resources.col_P_restation, "CPRECOD", 300, "", 2);
      apigrid.AddColumn(Resources.col_E_tat, "CETACOD", 300, "", 2);
      apigrid.AddColumn(Resources.col_A_dministration, "CACTSTA", 300, "", 2);
      apigrid.AddColumn(Resources.col_Date, "DACTDEX", 800, "dd/MM/yy", 2);
      //apigrid.AddColumn("CP", "VSITCP", 800);
      apigrid.AddColumn(Resources.col_Pays, "VSITPAYS", 1000);
      apigrid.AddColumn(Resources.col_attach, "ATTACH", 800, "", 2);
      apigrid.AddColumn(Resources.col_Facture, "FAC", 800, "", 2);

      apigrid.InitColumnList();
      apigrid.dgv.OptionsView.ColumnAutoWidth = false;
    }
    //Private Sub InitapiGrid()
    //  
    //On Error GoTo handler
    //
    //  apigrid.AddColumn "DI", "NDINNUM", 700
    //  apigrid.AddColumn "STT", "VSTFNOM", 2000
    //  apigrid.AddColumn "Client", "VCLINOM", 2000
    //  apigrid.AddColumn "Site", "VSITNOM", 2000
    //  apigrid.AddColumn "Chaff", "VDINCHAFF", 1500
    //  apigrid.AddColumn "Action", "VACTDES", 5000, , , True
    //  apigrid.AddColumn "T echnique", "CTECCOD", 230, , 2
    //  apigrid.AddColumn "P restation", "CPRECOD", 230, , 2
    //  apigrid.AddColumn "E tat", "CETACOD", 230, , 2
    //  apigrid.AddColumn "A dministration", "CACTSTA", 230, , 2
    //  apigrid.AddColumn "date", "DACTDEX", 1000, "dd/mm/yy", 2
    //  '-apigrid.AddColumn "CP", "VSITCP", 800
    //  apigrid.AddColumn "Pays", "VSITPAYS", 1000
    //  apigrid.AddColumn "Attach", "ATTACH", 1000, , 2
    //  apigrid.AddColumn "Facture", "FAC", 1000, , 2
    //
    //  ' Style sur une colonne
    //  apigrid.AddCellStyle "ATTACH", "", &H0, &H80FF&       ' Surligner les DI de la personne loguée (spécifique ds apiTGridT)
    //  apigrid.AddCellStyle "FAC", "", &H0, &HFF          ' Dépannage en rouge, orange ou jaune (spécifique ds apiTGridT)
    //  
    //  apigrid.Init adors
    //  
    //Exit Sub
    //
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void apigrid_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle >= 0)
      {
        GridView view = sender as GridView;
        if (e.Column.Name == "ATTACH")
        {
          if ((string)view.GetDataRow(e.RowHandle)["ATTACH"] == "OUI")
            e.Appearance.BackColor = MozartColors.ColorHC0FFC0; //Vert
          else if ((string)view.GetDataRow(e.RowHandle)["ATTACH"] == "NON")
            e.Appearance.BackColor = MozartColors.colorHC0C0FF; // D - O : Rouge 
        }
        else if (e.Column.Name == "FAC")
        {
          if ((string)view.GetDataRow(e.RowHandle)["FAC"] == "OUI")
            e.Appearance.BackColor = MozartColors.ColorHC0FFC0; //Vert
          else if ((string)view.GetDataRow(e.RowHandle)["FAC"] == "NON")
            e.Appearance.BackColor = MozartColors.colorHC0C0FF; // D - O : Rouge 
        }
      }
    }
    //Private Sub apigrid_FetchCellStyle(Cols As TrueOleDBGrid80.Columns, BookMark As Variant, col As Integer, DataField As String, CellText As String, CellStyle As TrueOleDBGrid80.StyleDisp)
    //' Gestion spécifique des couleurs
    //  
    //  On Error Resume Next
    //  
    //  ' Dépannages non planifiés (2 conditions CPRECOD & CETACOD)
    //  If (DataField = "ATTACH" And CellText = "OUI") Then CellStyle.BackColor = &HC0FFC0  ' Vert
    //  If (DataField = "ATTACH" And CellText = "NON") Then CellStyle.BackColor = &HC0C0FF  ' D - O : Rouge
    //  If (DataField = "FAC" And CellText = "OUI") Then CellStyle.BackColor = &HC0FFC0     ' Vert
    //  If (DataField = "FAC" And CellText = "NON") Then CellStyle.BackColor = &HC0C0FF     ' D - O : Rouge
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apigrid.GetFocusedDataRow();
      if (row == null) return;

      //écran de modification de la demande
      MozartParams.NumDi = (int)row["NDINNUM"];
      MozartParams.NumAction = (int)row["NACTNUM"];

      Cursor.Current = Cursors.WaitCursor;
      new frmAddAction
      {
        mstrStatutDI = "M",
      }.ShowDialog();

      //on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      apigrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdModifier_Click()
    //Dim aux As Integer
    //
    //  If adors.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  ' écran de modification de la demande
    //  frmAddAction.mstrStatutDI = "M"
    //  giNumDi = val(adors("NDINNUM").value)
    //  glNumAction = val(adors("NACTNUM").value)
    //  frmAddAction.Show vbModal
    //  
    //  Screen.MousePointer = vbHourglass
    //    
    //  ' on revient donc on réinitialise les variables globales
    //  giNumDi = 0
    //  glNumAction = 0
    //  
    //  On Error Resume Next
    //  aux = adors.AbsolutePosition
    //  adors.Requery
    //  adors.AbsolutePosition = aux
    //
    //  Screen.MousePointer = vbDefault
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  ' fermeture de la fenetre
    //  Unload Me
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void apigrid_DblClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }
    //Private Sub apigrid_DblClick()
    //  Call cmdModifier_Click
    //End Sub
    //
    //
    //

  }
}

