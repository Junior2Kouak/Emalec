using MZCtrlResources = MozartControls.Properties.Resources;
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
  public partial class frmStatContratClient : Form
  {
    //Public mstrNomClient As String
    //Public miNumClient As String
    //Dim lRs As ADODB.Recordset
    public string msNomClient;
    public string miNumClient;
    public DateTime dateFrom;  // <= frmChoixDate.txtDateA(0)
    public DateTime dateTo;    // <= frmChoixDate.txtDateA(1)

    DataTable dt = new DataTable();

    public frmStatContratClient()
    {
      InitializeComponent();
    }

    private void frmStatContratClient_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        string sSQL = $"EXEC api_sp_StatistiqueContratClient {miNumClient}, '{dateFrom}', '{dateTo}'";
        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apiTGrid.GridControl.DataSource = dt;
        InitApigrid();
        Cursor.Current = Cursors.Default;
        lblTitre.Text = $"{MZCtrlResources.col_Client} : {msNomClient}  {lblTitre.Text}";
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //On Error GoTo Handler:
    //  InitBoutons Me, frmMenu
    //  If cnxRep.state = adStateOpen Then cnxRep.Close
    //  ' ouverture connexion
    //  'cnxRep.Open gstrConnexionStringReplique
    //  ' TB SAMSIC CITY BASE
    //  cnxRep.Open gstrConnexion
    //  ' cnxRep.Open "PROVIDER=SQLOLEDB.1;Initial Catalog=MULTI;Data Source=" & gstrNomServeur & ";trusted_connection=yes;App=" & gstrNomSociete & ";"
    //  cnxRep.CommandTimeout = 150
    //  Set lRs = New ADODB.Recordset
    //  lRs.CursorLocation = adUseClient
    //  lRs.Open "EXEC api_sp_StatistiqueContratClient " & miNumClient & ", '" & frmChoixDate.txtDateA(0) & "', '" & frmChoixDate.txtDateA(1) & "'", cnxRep, adOpenForwardOnly, adLockReadOnly
    //  Screen.MousePointer = vbDefault
    //  If lRs.EOF Then Exit Sub
    //  lbltitre = "§Client : §" & mstrNomClient & lbltitre
    //  InitApigrid
    //  Exit Sub
    //  Resume
    //Handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    private void InitApigrid()
    {
      apiTGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 3600);
      apiTGrid.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 2200);
      apiTGrid.AddColumn(Resources.col_NbSites, "Nb Sites", 800, "", 2);
      apiTGrid.AddColumn(Resources.col_NbInter, "Nb Inter", 800);
      apiTGrid.AddColumn(Resources.col_Montant, "Montant", 1200, "# ### ###", 1);
      apiTGrid.AddColumn(Resources.col_Ratio, "Ratio", 800);
      apiTGrid.AddColumn("Clinum", "NCLINUM", 0);

      apiTGrid.InitColumnList();

    }
    //Private Sub InitApigrid()
    //On Error GoTo Handler
    //  apiGrid.AddColumn "§Client§", 3600
    //  apiGrid.AddColumn "§Contrat§", 2200
    //  apiGrid.AddColumn "§Nb sites§", 800, , 2
    //  apiGrid.AddColumn "§Nb inter§", 800
    //  apiGrid.AddColumn "§Montant§", 1200, "# ### ### ", 1
    //  apiGrid.AddColumn "§Ratio§", 800
    //  apiGrid.AddColumn "Clinum", 0

    //  apiGrid.Init lRs

    //Exit Sub
    //Handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  On Error Resume Next
    //  lRs.Close
    //  Unload Me
    //End Sub

  }
}

