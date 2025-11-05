using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmTableHDetail : Form
  {

    DataTable dt = new DataTable();

    public int miCompte;
    public string mstrPersonne;
    public int miPersonne;
    public int miMois;
    public int miAnnee;
    public string mstrType;
    //
    //Dim adoRS As ADODB.Recordset
    //Attribute adoRS.VB_VarHelpID = -1
    //Public miCompte As Integer
    //Public mstrPersonne As String
    //Public miPersonne As Integer
    //Public miMois As Integer
    //Public miAnnee As Integer
    //Public mstrType As String
    //

    public frmTableHDetail()
    {
      InitializeComponent();
    }

    private void frmTableHDetail_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        Label1.Text = $"{Label1.Tag} {mstrPersonne} sur le compte {miCompte}";

        loadDatatable();
        InitApigrid();

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub Form_Load()
    //    
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //  
    //  Label1.Caption = Label1.Tag & mstrPersonne & " sur le compte " & miCompte
    //  
    //  ' ouverture du recordset
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "exec api_sp_DetailHeuresTech " & miPersonne & ", " & miCompte & ", " & miMois & ", " & miAnnee, cnx
    //  
    //  InitApigrid
    //    
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //    
    //End Sub
    //

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void InitApigrid()
    {
      try
      {
        apiTGrid1.AddColumn(Resources.col_DI, "NDINNUM", 690);
        apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1400);
        apiTGrid1.AddColumn(Resources.col_Site, "VSITNOM", 1600);
        apiTGrid1.AddColumn(Resources.col_datePla, "DACTPLA", 900, "dd/mm/yy");
        apiTGrid1.AddColumn(Resources.col_dateEx, "DACTDEX", 900, "dd/mm/yy");
        apiTGrid1.AddColumn(Resources.col_attach, "VACTATT", 1100);
        apiTGrid1.AddColumn(Resources.col_duree, "NACTDUR", 800, "", 2);

        if (mstrType == "COUT")
          apiTGrid1.AddColumn(Resources.col_cout, "Cout", 900, "", 2);
        else
          apiTGrid1.AddColumn(Resources.col_cout, "Cout", 0, "", 2);

        apiTGrid1.AddColumn(Resources.col_etat, "CETACOD", 800, "", 2);
        apiTGrid1.AddColumn(Resources.col_Action, "VACTDES", 4900);

        apiTGrid1.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub InitApigrid()
    //  
    //On Error GoTo handler
    //            
    //  ApiGrid.AddColumn "§DI§", 690
    //  ApiGrid.AddColumn "§Client§", 1400
    //  ApiGrid.AddColumn "§Site§", 1600
    //  ApiGrid.AddColumn "§Date Pla§", 900, "dd/mm/yy"
    //  ApiGrid.AddColumn "§Date Ex§", 900, "dd/mm/yy"
    //  ApiGrid.AddColumn "§Attach§", 1100
    //  ApiGrid.AddColumn "§Durée §", 800, , 2
    //  If mstrType = "COUT" Then
    //    ApiGrid.AddColumn "§Coût§", 900, , 2
    //    ApiGrid.AddColumn "§Etat §", 700, , 2
    //    ApiGrid.AddColumn "§Action§", 4100
    //  Else
    //    ApiGrid.AddColumn "§Coût§", 0, , 2
    //    ApiGrid.AddColumn "§Etat §", 800, , 2
    //    ApiGrid.AddColumn "§Action§", 4900
    //  End If
    //  
    //  ApiGrid.Init adoRS
    //  
    //Exit Sub
    //
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void loadDatatable()
    {
      apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_DetailHeuresTech " + miPersonne + ", " + miCompte + ", " + miMois + ", " + miAnnee);
      apiTGrid1.GridControl.DataSource = dt;
    }

    /* TODO frmAddAction---------------------------------------------------------------------*/
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      Cursor = Cursors.WaitCursor;

      //  écran de modification de la demande
      // frmAddAction f = new frmAddAction();
      //f.mstrStatutDI = "M";

      //MozartParams.NumDi = Convert.ToInt32(Strings.Mid(apiTGrid1.GetFocusedDataRow()["NDINNUM"].ToString(), 3));
      //MozartParams.NumAction = 0;

      //f.showDialog();

      //Cursor = Cursors.WaitCursor;

      //  on revient donc on réinitialise les variables globales
      //MozartParams.NumDi = 0;
      //MozartParams.NumAction = 0;

      //  rafraichissement de la datatable
      //loadDatatable();
      //Cursor = Cursors.Default;
    }

    //Private Sub cmdModifier_Click()
    //    
    //Dim aux
    //  
    //  If adoRS.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  ' écran de modification de la demande
    //  frmAddAction.mstrStatutDI = "M"
    //  giNumDi = Mid(adoRS("NDINNUM").value, 3)
    //  glNumAction = 0
    //  frmAddAction.Show vbModal
    //  
    //  Screen.MousePointer = vbHourglass
    //    
    //    
    //  ' on revient donc on réinitialise les variables globales
    //  giNumDi = 0
    //  glNumAction = 0
    //  
    //  ' rafraichissement du recordset
    //  On Error Resume Next
    //  aux = adoRS.AbsolutePosition
    //  adoRS.Requery
    //  adoRS.AbsolutePosition = aux
    //  
    //  InitApigrid
    //  Screen.MousePointer = vbDefault
    //
    //End Sub
    //

    /* TODO méthode PrintGrid---------------------------------------------------------------------*/
    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      //  impression du datagrid
      Cursor = Cursors.WaitCursor;

      //TODO méthode PrintGrid pour apiTGrid
      apiTGrid1.btnPrint_Click(null, null);
      Cursor = Cursors.Default;
    }

    //Private Sub cmdImprimer_Click()
    //  ' impression du datagrid
    //  Screen.MousePointer = vbHourglass
    //  ApiGrid.PrintGrid Me
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void Form_Unload(int Cancel)
    {
      Cursor = Cursors.Default;
    }

    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void apiTGrid1_DoubleClick(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }

    //Private Sub apigrid_DblClick()
    //  Call cmdModifier_Click
    //End Sub
    //
  }
}