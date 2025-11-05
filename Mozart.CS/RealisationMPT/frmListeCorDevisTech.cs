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
  public partial class frmListeCorDevisTech : Form
  {
    //Dim adoRS As ADODB.Recordset
    DataTable dt = new DataTable();

    public frmListeCorDevisTech()
    {
      InitializeComponent();
    }

    private void frmListeCorDevisTech_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_ListeDevisCorrige");
        apiTGrid.GridControl.DataSource = dt;
        InitApigrid();
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
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "exec api_sp_ListeDevisCorrige", cnx

    //  InitApigrid

    //  Screen.MousePointer = vbDefault
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub

    private void InitApigrid()
    {
      apiTGrid.AddColumn(Resources.col_Num, "NWDEVNUM", 70);
      apiTGrid.AddColumn(Resources.col_Vue, "BCORLU", 50);
      apiTGrid.AddColumn(Resources.col_Correcteur, "VPERNOM", 150);
      apiTGrid.AddColumn(Resources.col_Date, "DATE", 90);
      apiTGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 90);
      apiTGrid.AddColumn(Resources.col_Site, "VSITNOM", 90);
      apiTGrid.AddColumn(Resources.col_Tech, "TECH", 90);
      apiTGrid.AddColumn(Resources.col_Titre, "TITRE", 90);

      apiTGrid.InitColumnList();
    }
    //Private Sub InitApigrid()

    //  apiTGrid.AddColumn "N°", "NWDEVNUM", 1000
    //  apiTGrid.AddColumn "Vue", "BCORLU", 800
    //  apiTGrid.AddColumn "Correcteur", "VPERNOM", 2000
    //  apiTGrid.AddColumn "Date", "DATE", 1300
    //  apiTGrid.AddColumn "Client", "VCLINOM", 2000
    //  apiTGrid.AddColumn "Site", "VSITNOM", 2500
    //  apiTGrid.AddColumn "Tech", "TECH", 2000
    //  apiTGrid.AddColumn "Titre", "TITRE", 3000

    //  apiTGrid.Init adoRS
    //End Sub

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      string[,] TdbGlobal = { { "", "" } };
      try
      {
        frmBrowser f = new frmBrowser();
        f.msInfosMail = "TWDEVIS|NPERNUM|0";
        f.mstrType = "TEC$" + row["VCLINOM"].ToString() + "$" + row["VSITNOM"].ToString();

        f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TCORDEVISTECH.RTF",
                  @"TCorDevisOut.rtf",
                  TdbGlobal,
                  $"exec api_sp_EditionCorDevis {row["NWDEVNUM"]}",
                  " (Visualisation correction devis)",
                  "PREVIEW");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdModifier_Click()
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //On Error GoTo handler
    //  frmBrowser.InfosMail = "TWDEVIS|NPERNUM|0"
    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.mstrType = "TEC$" & adoRS("VCLINOM") & "$" & adoRS("VSITNOM")
    //  frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\TCORDEVISTECH.RTF", _
    //                         "\TCorDevisOut.rtf", _
    //                         TdbGlobal(), _
    //                         "exec api_sp_EditionCorDevis " & adoRS("NWDEVNUM"), _
    //                         " (Visualisation correction devis)", _
    //                         "PREVIEW"
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Dispose();
    }
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub

  }
}

