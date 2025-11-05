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
  public partial class frmListeDeciWebArch : Form
  {
    //Dim adoRS As ADODB.Recordset
    DataTable dt = new DataTable();

    public frmListeDeciWebArch()
    {
      InitializeComponent();
    }

    private void frmListeDeciWebArch_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        apiGrid.LoadData(dt, MozartDatabase.cnxMozart, "select * from api_v_listeDeci_web where CWDECACTIF='N' order by DWDECDAT desc");
        apiGrid.GridControl.DataSource = dt;
        InitApigrid();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //On Error GoTo handler:
    //  InitBoutons Me, frmMenu
    //  ' ouverture du recordset
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "select * from api_v_listeDeci_web where CWDECACTIF='N' order by DWDECDAT desc", cnx
    //  InitApigrid
    //  Screen.MousePointer = vbDefault
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void InitApigrid()
    {
      apiGrid.AddColumn(Resources.col_Num, "NWDECNUM", 25);
      apiGrid.AddColumn(Resources.col_Date, "DWDECDAT", 180, "dd/mm/yyyy hh:mm:ss");
      apiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 80);
      apiGrid.AddColumn(Resources.col_Demandeur, "VUTILOG", 80);
      apiGrid.AddColumn(Resources.col_DI, "NDINNUM", 50);
      apiGrid.AddColumn(Resources.col_Site, "VSITNOM", 80);
      apiGrid.AddColumn(Resources.col_Num, "NSITNUE", 30);
      apiGrid.AddColumn(Resources.col_Action, "VACTDES", 250);
      apiGrid.AddColumn(Resources.col_DecisionClient, "VWDECLIB", 150);
      apiGrid.AddColumn(Resources.col_Rmq, "VWDECCOMM", 150);
      apiGrid.AddColumn(Resources.col_Actif, "CWDECACTIF", 0);
      apiGrid.AddColumn("NACTNUM", "NACTNUM", 0);
      apiGrid.AddColumn("NCLINUM", "NCLINUM", 0);
      apiGrid.AddColumn(Resources.col_Inter, "INTER", 30);
      apiGrid.AddColumn(Resources.col_Qui, "QUI", 30);

      apiGrid.InitColumnList();

    }
    //Private Sub InitApigrid()

    //  apiGrid.AddColumn "N°", "NWDECNUM", 400
    //  apiGrid.AddColumn "§Date arrivée§", "DWDECDAT", 1700, "dd/mm/yyyy hh:mm:ss"
    //  apiGrid.AddColumn "§Client§", "VCLINOM", 1200
    //  apiGrid.AddColumn "§Demandeur§", "VUTILOG", 1200
    //  apiGrid.AddColumn "§DI§", "NDINNUM", 700
    //  apiGrid.AddColumn "§Site§", "VSITNOM", 1200
    //  apiGrid.AddColumn "N°", "NSITNUE", 500
    //  apiGrid.AddColumn "§Action§", "VACTDES", 3800
    //  apiGrid.AddColumn "§Décision client§", "VWDECLIB", 2200
    //  apiGrid.AddColumn "§Rmq§", "VWDECCOMM", 2200
    //  apiGrid.AddColumn "§ACTIF§", "CWDECACTIF", 0
    //  apiGrid.AddColumn "NACTNUM", "NACTNUM", 0
    //  apiGrid.AddColumn "NCLINUM", "NCLINUM", 0
    //  apiGrid.AddColumn "§INTER§", "INTER", 400
    //  apiGrid.AddColumn "§QUI§", "QUI", 400
    //  apiGrid.Init adoRS
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //    ' fermeture de la fenetre
    //    Unload Me
    //  End Sub

    //Private Sub Form_Unload(Cancel As Integer)
    //    Screen.MousePointer = vbDefault
    //  End Sub
  }
}

