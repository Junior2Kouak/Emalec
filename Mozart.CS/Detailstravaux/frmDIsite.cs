using MZCtrlResources = MozartControls.Properties.Resources;
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
  public partial class frmDIsite : Form
  {
    public int miNumSite;

    DataTable dt = new DataTable();
    DataTable dt1 = new DataTable();

    TooltipGridTPE _tpe;

    //Public miNumSite As Long
    //
    //Dim adoRS As ADODB.Recordset
    //Dim adors1 As ADODB.Recordset

    public frmDIsite() { InitializeComponent(); }

    private void frmDIsite_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        cmdModifier.Visible = false;//bouton sans action => masqué

        //Ouverture du recordset
        ApiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_listeDiAction where NSITNUM = {miNumSite} order by ndinnum desc");
        ApiGrid.GridControl.DataSource = dt;
        ApiGrid.dgv.OptionsView.ColumnAutoWidth = false;

        InitApigrid();
        _tpe = new TooltipGridTPE(ApiGrid, toolTipController1);

        ApiGrid1.LoadData(dt1, MozartDatabase.cnxMozart, $"select * from  api_v_ListeDiArchives where NSITNUM = {miNumSite} AND NPERNUM = {MozartParams.UID} AND VSOCIETE = '{MozartParams.NomSociete}' order by DDINDATHEUR desc");
        ApiGrid1.GridControl.DataSource = dt1;
        ApiGrid1.dgv.OptionsView.ColumnAutoWidth = false;

        InitApigrid1();
        _tpe = new TooltipGridTPE(ApiGrid1, toolTipController1);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //    
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //  
    //  ' ouverture du recordset
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "select * from api_v_listeDiAction where NSITNUM = " & miNumSite & " order by ndinnum desc", cnx
    //  
    //  InitApigrid
    //  
    //  Set adors1 = New ADODB.Recordset
    //  adors1.Open "select * from  api_v_ListeDiArchives where NSITNUM = " & miNumSite & " AND NPERNUM=" & gintUID & " AND VSOCIETE = '" & gstrNomSociete & "' order by DDINDATHEUR desc", cnx
    //  
    //  InitApigrid1
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      //Fermeture de la fenêtre
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  ' fermeture de la fenetre
    //  Unload Me
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      ApiGrid.AddColumn(Resources.col_DI, "NDINNUM", 600);
      ApiGrid.AddColumn(Resources.col_date_c, "DDINDATHEUR", 850, "dd/MM/yy");
      ApiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 970);
      ApiGrid.AddColumn(Resources.col_Site, "VSITNOM", 1350);
      ApiGrid.AddColumn("N°", "NSITNUE", 450);
      ApiGrid.AddColumn(Resources.col_Enseigne, "VSITENSEIGNE", 450);
      ApiGrid.AddColumn(Resources.col_Chaff, "VPERNOM", 450);
      ApiGrid.AddColumn(Resources.col_Action, "VACTDES", 4870);
      ApiGrid.AddColumn(Resources.col_Date, "DACTDATE", 850, "dd/MM/yy");
      ApiGrid.AddColumn(Resources.col_Technicien, "VACTINT", 450);
      ApiGrid.AddColumn(Resources.col_T_echnique, "CTECCOD", 450);
      ApiGrid.AddColumn(Resources.col_P_restation, "CPRECOD", 450);
      ApiGrid.AddColumn(Resources.col_E_tat, "CETACOD", 450);
      ApiGrid.AddColumn(Resources.col_A_dministration, "CACTSTA", 470);
      ApiGrid.AddColumn(Resources.col_OBS, "VACTOBS", 1000);
      ApiGrid.AddColumn(Resources.col_OBSM, "VACTOBSM", 1000);
      ApiGrid.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
      ApiGrid.AddColumn(Resources.col_type_intervenant, "CACTTYT", 0);
      ApiGrid.AddColumn("NumSite", "NSITNUM", 0);
      ApiGrid.AddColumn("VSITCP", "VSITCP", 1350);
      ApiGrid.AddColumn("VCCLNOM", "VCCLNOM", 1350);
      ApiGrid.AddColumn("TRI", "TRI", 1350);
      ApiGrid.AddColumn("QUI", "QUI", 1350);
      ApiGrid.AddColumn("CACTVUEWEB", "CACTVUEWEB", 1350);
      ApiGrid.AddColumn("VACTNUMCDE", "VACTNUMCDE", 1350);
      ApiGrid.AddColumn("ST", "ST", 1350);
      ApiGrid.AddColumn("NACTVAL", "NACTVAL", 1350, "0.##");
      ApiGrid.AddColumn("VSITPAYS", "VSITPAYS", 1350);
      ApiGrid.AddColumn("INTERVENANT", "INTERVENANT", 1350);

      ApiGrid.InitColumnList();
    }
    //Private Sub InitApigrid()
    //  
    //On Error GoTo handler
    //   
    //  ApiGrid.AddColumn "§DI§", "NDINNUM", 600
    //  ApiGrid.AddColumn "§Date C§", "DDINDATHEUR", 780, "dd/mm/yy"
    //  ApiGrid.AddColumn "§Client§", "VCLINOM", 970
    //  ApiGrid.AddColumn "§Site§", "VSITNOM", 1350
    //  ApiGrid.AddColumn "N°", "NSITNUE", 480
    //  ApiGrid.AddColumn "§Enseigne§", "VSITENSEIGNE", 400
    //  ApiGrid.AddColumn "§Chaff§", "VPERNOM", 360
    //  ApiGrid.AddColumn "§Action§", "VACTDES", 4870
    //  ApiGrid.AddColumn "§Date §", "DACTDATE", 770, "dd/mm/yy"
    //  ApiGrid.AddColumn "§Technicien§", "VACTINT", 400
    //  ApiGrid.AddColumn "§T echnique§", "CTECCOD", 230
    //  ApiGrid.AddColumn "§P restation§", "CPRECOD", 230
    //  ApiGrid.AddColumn "§E tat§", "CETACOD", 230
    //  ApiGrid.AddColumn "§A dministration§", "CACTSTA", 230
    //  ApiGrid.AddColumn "§Obs§", "VACTOBS", 1000
    //  ApiGrid.AddColumn "§NumAction§", "NACTNUM", 0
    //  ApiGrid.AddColumn "§type d'intervenant§", "CACTTYT", 0
    //  ApiGrid.AddColumn "NumSite", "NSITNUM", 0
    //  ApiGrid.AddColumn "VSITCP", "VSITCP", 1350
    //  ApiGrid.AddColumn "VSITTYPE", "VSITTYPE", 1350
    //  ApiGrid.AddColumn "VCCLNOM", "VCCLNOM", 1350
    //  ApiGrid.AddColumn "TRI", "TRI", 1350
    //  ApiGrid.AddColumn "QUI", "QUI", 1350
    //  ApiGrid.AddColumn "CACTVUEWEB", "CACTVUEWEB", 1350
    //  ApiGrid.AddColumn "VACTNUMCDE", "VACTNUMCDE", 1350
    //  ApiGrid.AddColumn "ST", "ST", 1350
    //  ApiGrid.AddColumn "NACTVAL", "NACTVAL", 1350
    //  ApiGrid.AddColumn "VSITPAYS", "VSITPAYS", 1350
    //  ApiGrid.AddColumn "INTERVENANT", "INTERVENANT", 1350
    //  
    //  ApiGrid.AddCellTip "VACTDES", &HFDF0DA
    //  ApiGrid.AddCellTip "VACTOBS", &HFDF0DA
    //  
    //  ApiGrid.Init adoRS
    //  
    //Exit Sub
    //
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitApigrid1()
    {
      ApiGrid1.AddColumn(Resources.col_DI, "NDINNUM", 600);
      ApiGrid1.AddColumn(Resources.col_attach, "VACTATT", 780);
      ApiGrid1.AddColumn(Resources.col_date_c, "DDINDATHEUR", 780, "dd/MM/yy");
      ApiGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 970);
      ApiGrid1.AddColumn(Resources.col_Site, "VSITNOM", 1350);
      ApiGrid1.AddColumn("N°", "NSITNUE", 450);
      ApiGrid1.AddColumn(Resources.col_Enseigne, "VSITENSEIGNE", 450);
      ApiGrid1.AddColumn(Resources.col_Chaff, "VPERNOM", 450);
      ApiGrid1.AddColumn(Resources.col_Action, "VACTDES", 4870);
      ApiGrid1.AddColumn(Resources.col_Date, "DACTDATE", 770, "dd/MM/yy");
      ApiGrid1.AddColumn(Resources.col_Tech, "VACTINT", 450);
      ApiGrid1.AddColumn(Resources.col_Technique, "CTECCOD", 450);
      ApiGrid1.AddColumn(Resources.col_Prestation, "CPRECOD", 450);
      ApiGrid1.AddColumn(Resources.col_etat, "CETACOD", 450);
      ApiGrid1.AddColumn(Resources.col_Administratif, "CACTSTA", 470);
      ApiGrid1.AddColumn(Resources.col_Observation, "VACTOBS", 1000);
      ApiGrid1.AddColumn(Resources.col_OBSM, "VACTOBSM", 1000);
      ApiGrid1.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
      ApiGrid1.AddColumn(Resources.col_type_intervenant, "CACTTYT", 0);
      ApiGrid1.AddColumn("NumSite", "NSITNUM", 0);
      ApiGrid1.AddColumn("a", "a", 100);
      ApiGrid1.AddColumn("b", "b", 100);
      ApiGrid1.AddColumn("c", "c", 100);
      ApiGrid1.AddColumn("VACTNUMCDE", "VACTNUMCDE", 1000);
      ApiGrid1.AddColumn("ST", "ST", 1350);
      ApiGrid1.AddColumn("VCCLNOM", "VCCLNOM", 1000);
      ApiGrid1.AddColumn("VSITCP", "VSITCP", 1000);
      ApiGrid1.AddColumn("VSITPAYS", "VSITPAYS", 1000);

      ApiGrid1.InitColumnList();
    }
    //Private Sub InitApigrid1()
    //  
    //On Error GoTo handler
    //  
    //  ApiGrid1.AddColumn "§DI§", "NDINNUM", 600
    //  ApiGrid1.AddColumn "§Attach§", "VACTATT", 1000
    //  ApiGrid1.AddColumn "§Date C§", "DDINDATHEUR", 900, "dd/mm/yy"
    //  ApiGrid1.AddColumn "§Client§", "VCLINOM", 1300
    //  ApiGrid1.AddColumn "§Site§", "VSITNOM", 1300
    //  ApiGrid1.AddColumn "N°", "NSITNUE", 500
    //  ApiGrid1.AddColumn "§Enseigne§", "VSITENSEIGNE", 500
    //  ApiGrid1.AddColumn "§Chaff§", "VPERNOM", 500
    //  ApiGrid1.AddColumn "§Action§", "VACTDES", 3200
    //  ApiGrid1.AddColumn "§Date §", "DACTDATE", 800, "dd/mm/yy"
    //  ApiGrid1.AddColumn "§Tech§", "VACTINT", 500
    //  ApiGrid1.AddColumn "§Technique§", "CTECCOD", 200
    //  ApiGrid1.AddColumn "§Prestation§", "CPRECOD", 200
    //  ApiGrid1.AddColumn "§Etat§", "CETACOD", 200
    //  ApiGrid1.AddColumn "§Administratif§", "CACTSTA", 200
    //  ApiGrid1.AddColumn "§Observation§", "VACTOBS", 1100
    //  ApiGrid1.AddColumn "§NumAction§", "NACTNUM", 0
    //  ApiGrid1.AddColumn "§type d'intervenant§", "CACTTYT", 0
    //  ApiGrid1.AddColumn "NumSite", "NSITNUM", 0
    //  ApiGrid1.AddColumn "a", "a", 100
    //  ApiGrid1.AddColumn "b", "b", 100
    //  ApiGrid1.AddColumn "c", "c", 100
    //  ApiGrid1.AddColumn "VACTNUMCDE", "VACTNUMCDE", 1000
    //  ApiGrid1.AddColumn "ST", "ST", 10
    //  ApiGrid1.AddColumn "VCCLNOM", "VCCLNOM", 1000
    //  ApiGrid1.AddColumn "VSITCP", "VSITCP", 1000
    //  ApiGrid1.AddColumn "VSITPAYS", "VSITPAYS", 1000
    //  
    //  ApiGrid1.AddCellTip "VACTDES", &HFDF0DA
    //  ApiGrid1.AddCellTip "VACTOBS", &HFDF0DA
    //  
    //  ApiGrid1.Init adors1
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid1 dans " & Me.Name
    //End Sub
    //
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub apigrid_DblClick()
    // 
    //'Dim aux
    //'
    //'  If adoRS.EOF Then Exit Sub
    //'
    //'  Screen.MousePointer = vbHourglass
    //'
    //'  ' écran de modification de la demande
    //'  frmAddAction.mstrStatutDI = "M"
    //'  glNumAction = adoRS("NACTNUM").Value
    //'  giNumDi = Val(adoRS("NDINNUM").Value)
    //'  frmAddAction.Show vbModal
    //'
    //'  Screen.MousePointer = vbHourglass
    //'
    //'
    //'  ' on revient donc on réinitialise les variables globales
    //'  giNumDi = 0
    //'  glNumAction = 0
    //'
    //'  ' rafraichissement du recordset
    //'  On Error Resume Next
    //'  aux = adoRS.AbsolutePosition
    //'  adoRS.Requery
    //'  adoRS.AbsolutePosition = aux
    //'
    //'  InitApigrid
    //'  Screen.MousePointer = vbDefault
    // 
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub apigrid1_DblClick()
    // 
    //'Dim aux
    //'
    //'  If adoRS1.EOF Then Exit Sub
    //'
    //'  Screen.MousePointer = vbHourglass
    //'
    //'  ' écran de modification de la demande
    //'  frmAddAction.mstrStatutDI = "M"
    //'  glNumAction = adoRS1("NACTNUM").Value
    //'  giNumDi = Val(adoRS1("NDINNUM").Value)
    //'  frmAddAction.Show vbModal
    //'
    //'  Screen.MousePointer = vbHourglass
    //'
    //'
    //'  ' on revient donc on réinitialise les variables globales
    //'  giNumDi = 0
    //'  glNumAction = 0
    //'
    //'  ' rafraichissement du recordset
    //'  On Error Resume Next
    //'  aux = adoRS1.AbsolutePosition
    //'  adoRS1.Requery
    //'  adoRS1.AbsolutePosition = aux
    //'
    //'  InitApigrid1
    //'  Screen.MousePointer = vbDefault
    // 
    //End Sub
    //

  }
}

