using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmStatQualActNonConfDetail : Form
  {
    public int p_npernum;
    public string p_vpernom;
    public int p_ntypestat;

    DataTable dt = new DataTable();

    TooltipGridTPE _tpe;

    public frmStatQualActNonConfDetail() { InitializeComponent(); }

    private void frmStatQualActNonConfDetail_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        string Titre_Form = "";

        switch (p_ntypestat)
        {
          case 1:
            Titre_Form = Resources.txt_Dep_Planifies;
            break;
          case 2:
            Titre_Form = Resources.txt_Actions_Planifs;
            break;
          case 3:
            Titre_Form = Resources.txt_Actions_a_Planifs;
            break;
          case 4:
            Titre_Form = Resources.txt_Devis_a_Faire;
            break;
          case 5:
            Titre_Form = Resources.txt_Actions_Exe_Infacturees;
            break;
          case 6:
            Titre_Form = Resources.txt_Actions_En_Attente;
            break;
          case 7:
            Titre_Form = Resources.txt_Actions_Planif_Sup_Egal_30j;
            break;
          case 8:
            Titre_Form = Resources.txt_Actions_Planif_Sup_Egal_60j;
            break;
          case 9:
            Titre_Form = Resources.txt_Actions_Planif_Sup_Egal_90j;
            break;
        }

        lbltitre.Text += $" {Titre_Form} {Resources.txt_Pour} {p_vpernom}";
        this.Text += $" {Titre_Form} {Resources.txt_Pour} {p_vpernom}";

        LoadGrid(p_ntypestat);

        _tpe = new TooltipGridTPE(apiTGrid, toolTipController1);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    //Private Sub Form_Load()
    //
    //On Error GoTo handler
    //
    //    Dim Titre_Form As String
    //
    //    InitBoutons Me, frmMenu
    //    
    //    If cnxRep.state = adStateOpen Then cnxRep.Close
    //  
    //    ' ouverture connexion
    //    'cnxRep.Open gstrConnexionStringReplique
    //    
    //    ' TB SAMSIC CITY BASE
    //    cnxRep.Open gstrConnexion
    //    ' cnxRep.Open "PROVIDER=SQLOLEDB.1;Initial Catalog=MULTI;Data Source=" & gstrNomServeur & ";trusted_connection=yes;App=" & gstrNomSociete & ";"
    //    cnxRep.CommandTimeout = 150
    //               
    //    Set ado_rsdetbychaff = New ADODB.Recordset
    //    
    //    Select Case p_ntypestat
    //        Case 1:  Titre_Form = "§Dépannages planifiés§"
    //        Case 2:  Titre_Form = "§Actions planifiées§"
    //        Case 3:  Titre_Form = "§Actions à planifiées§"
    //        Case 4:  Titre_Form = "§Devis à faire§"
    //        Case 5:  Titre_Form = "§Actions exécutées non facturées§"
    //        Case 6:  Titre_Form = "§Actions en attente§"
    //        Case 7:  Titre_Form = "§Actions à planifier ou planifiées >=30j§"
    //        Case 8:  Titre_Form = "§Actions à planifier ou planifiées >=60j§"
    //        Case 9:  Titre_Form = "§Actions à planifier ou planifiées >=90j§"
    //    End Select
    //       
    //    lbltitre.Caption = lbltitre.Caption + Space(1) + Titre_Form + " §pour§ " + p_vpernom
    //    Me.Caption = Me.Caption + Space(1) + Titre_Form + " §pour§ " + p_vpernom
    //       
    //    Screen.MousePointer = vbDefault
    //    
    //    InitGrid
    //    
    //    Call LoadGrid(p_ntypestat)
    //    Exit Sub
    //  
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row) return;

      Cursor.Current = Cursors.WaitCursor;

      MozartParams.NumDi = (int)Utils.ZeroIfNull(row["NDINNUM"]);
      MozartParams.NumAction = (int)Utils.ZeroIfNull(row["NACTNUM"]);

      //écran de modification de la demande
      new frmAddAction()
      {
        mstrStatutDI = "M",
      }.ShowDialog();

      //on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdModifier_Click()
    //
    //On Error GoTo handler
    //
    //    If ado_rsdetbychaff.RecordCount = 0 Then Exit Sub
    //
    //    Screen.MousePointer = vbHourglass
    //       
    //    ' écran de modification de la demande
    //    frmAddAction.mstrStatutDI = "M"
    //    giNumDi = val(ado_rsdetbychaff("NDINNUM").value)
    //    glNumAction = val(ado_rsdetbychaff("NACTNUM").value)
    //    frmAddAction.Show vbModal
    //    
    //    Screen.MousePointer = vbHourglass
    //      
    //    ' on revient donc on réinitialise les variables globales
    //    giNumDi = 0
    //    glNumAction = 0
    //    Screen.MousePointer = vbDefault
    //    Exit Sub
    //  
    //handler:
    //  ShowError "cmdModifier_Click dans " & Me.Name
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //
    //    If ado_rsdetbychaff.state = adStateOpen Then ado_rsdetbychaff.Close
    //    Set ado_rsdetbychaff = Nothing
    //   
    //    If cnxRep.state = adStateOpen Then cnxRep.Close
    //   
    //    Screen.MousePointer = vbDefault
    //    
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void LoadGrid(int iTypeStat)
    {
      string sRequeteParam = "";

      Cursor.Current = Cursors.WaitCursor;

      if (iTypeStat != 0)
      {
        sRequeteParam = $"exec api_sp_StatActionNonConformeCHAFFDetail '{MozartParams.NomSociete}', {p_npernum}, {iTypeStat}";

        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, sRequeteParam);
        apiTGrid.GridControl.DataSource = dt;

        InitGrid();
      }
      Cursor.Current = Cursors.Default;
    }
    //Private Sub LoadGrid(ByVal iTypeStat As Integer)
    //
    //    Dim sRequeteParam As String
    //
    //    On Error GoTo handler
    //
    //    Screen.MousePointer = vbHourglass
    //
    //    If ado_rsdetbychaff.state = adStateOpen Then ado_rsdetbychaff.Close
    //    
    //    If iTypeStat <> 0 Then
    //        sRequeteParam = "exec api_sp_StatActionNonConformeCHAFFDetail '" & gstrNomSociete & "', " & p_npernum & ", " & iTypeStat
    //        
    //        ado_rsdetbychaff.Open sRequeteParam, cnxRep
    //        
    //        apiTGrid.Init ado_rsdetbychaff
    //        ado_rsdetbychaff.Requery
    //    End If
    //    Screen.MousePointer = vbDefault
    //    
    //    Exit Sub
    //  
    //handler:
    //  ShowError "LoadGrid dans " & Me.Name
    //  Screen.MousePointer = vbDefault
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
    private void InitGrid()
    {
      apiTGrid.AddColumn(Resources.col_DI, "NDINNUM", 900);
      apiTGrid.AddColumn(MZCtrlResources.date_creation, "DDINDATHEUR", 2000, "Date");
      apiTGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2000);
      apiTGrid.AddColumn(Resources.col_Site, "VSITNOM", 2000);
      apiTGrid.AddColumn(Resources.col_T_echnique, "CTECCOD", 260, "", 2);
      apiTGrid.AddColumn(Resources.col_P_restation, "CPRECOD", 260, "", 2);
      apiTGrid.AddColumn(Resources.col_E_tat, "CETACOD", 260, "", 2);
      apiTGrid.AddColumn(Resources.col_Etat_Facturation, "CACTSTA", 300, "", 2);
      apiTGrid.AddColumn(Resources.col_Action, "VACTDES", 7000);
      apiTGrid.AddColumn(Resources.col_Observations, "VACTOBS", 1700);

      apiTGrid.InitColumnList();
    }
    //Public Sub InitGrid()
    //
    //On Error GoTo handler
    //
    //  apiTGrid.AddColumn "§DI§", "NDINNUM", 900
    //  apiTGrid.AddColumn "§Date création§", "DDINDATHEUR", 2000
    //  apiTGrid.AddColumn "§Client§", "VCLINOM", 2000
    //  apiTGrid.AddColumn "§Site§", "VSITNOM", 2000
    //  apiTGrid.AddColumn "§T echnique§", "CTECCOD", 230, , 2
    //  apiTGrid.AddColumn "§P restation§", "CPRECOD", 230, , 2
    //  apiTGrid.AddColumn "§E tat§", "CETACOD", 230, , 2
    //  apiTGrid.AddColumn "§Etat Facturation§", "CACTSTA", 230, , 2
    //  apiTGrid.AddColumn "§Action§", "VACTDES", 7000
    //  apiTGrid.AddColumn "§Observations§", "VACTOBS", 1700
    //
    //  Exit Sub
    //  
    //handler:
    //  ShowError "Initgrid dans " & Me.Name
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

  }
}

