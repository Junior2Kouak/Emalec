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
  public partial class frmListeDIArchivWeb : Form
  {
    DataTable dt = new DataTable();
    //Dim adoRS As ADODB.Recordset

    public frmListeDIArchivWeb()
    {
      InitializeComponent();
    }

    private void frmListeDIArchivWeb_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        apiGrid.LoadData(dt, MozartDatabase.cnxMozart, "SELECT * FROM api_v_listedi_web ORDER BY NDIWNUM desc");
        apiGrid.GridControl.DataSource = dt;
        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //  On Error GoTo handler:
    //    InitBoutons Me, frmMenu
    //    ' ouverture du recordset
    //    Set adoRS = New ADODB.Recordset
    //    adoRS.Open "select * from api_v_listedi_web order by NDIWNUM desc", cnx
    //    InitApigrid
    //  Exit Sub
    //  handler:
    //    ShowError "Form_Load de " & Me.Name
    //  End Sub   

    /* OK --------------------------------------------------------------------------*/
    private void InitApigrid()
    {
      apiGrid.AddColumn(Resources.col_Num, "NDIWNUM", 800);
      apiGrid.AddColumn(Resources.col_Date, "DDIWDAT", 1700, "dd/mm/yyyy hh:mm:ss");
      apiGrid.AddColumn(Resources.col_Demandeur, "VDINNOM", 1250);
      apiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1500);
      apiGrid.AddColumn(Resources.col_Ref, "VDIWREFCLI", 1000);
      apiGrid.AddColumn(Resources.col_Site, "VSITNOM", 1600);
      apiGrid.AddColumn(Resources.col_Num, "NSITNUE", 500);
      apiGrid.AddColumn(Resources.col_Description, "TDIWDES", 3500);
      apiGrid.AddColumn(Resources.col_NumDI, "NDINNUM", 900);
      apiGrid.AddColumn(Resources.col_NumCLI, "NCLINUM", 0);
      apiGrid.AddColumn(Resources.col_NumCLI, "NSITNUM", 0);
      apiGrid.AddColumn(Resources.col_NumSit, "DACTDAT", 0);

      apiGrid.InitColumnList();
    }
    //Private Sub InitApigrid()
    //    apiGrid.AddColumn "Num", "NDIWNUM", 800
    //    apiGrid.AddColumn "§Date C§", "DDIWDAT", 1700, "dd/mm/yyyy hh:mm:ss"
    //    apiGrid.AddColumn "§Demandeur§", "VDINNOM", 1250
    //    apiGrid.AddColumn "§Client§", "VCLINOM", 1500
    //    apiGrid.AddColumn "§Réf§", "VDIWREFCLI", 1000
    //    apiGrid.AddColumn "§Site§", "VSITNOM", 1600
    //    apiGrid.AddColumn "N°", "NSITNUE", 500
    //    apiGrid.AddColumn "§Description§", "TDIWDES", 3500
    //    apiGrid.AddColumn "§Num DI§", "NDINNUM", 900
    //    apiGrid.AddColumn "NumCli", "NCLINUM", 0
    //    apiGrid.AddColumn "NumCli", "NSITNUM", 0
    //    apiGrid.AddColumn "NumSit", "DACTDAT", 0

    //    apiGrid.Init adoRS
    //  End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      if (apiGrid.GetFocusedDataRow() == null) return;

      string[,] TdbGlobal = { { "DATE", DateTime.Now.ToShortDateString() } };

      frmBrowser f = new frmBrowser();
      f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TDiWeb.html",
                      @"TDiWeb.Out.rtf",
                      TdbGlobal,
                      "SELECT * FROM api_v_listedi_web WHERE NDIWNUM = " + apiGrid.GetFocusedDataRow()["NDIWNUM"].ToString(),
                      " (Visualisation devis)",
                      "PREVIEW");

    }
    //Private Sub cmdVisu_Click()
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //  If adoRS.EOF Then Exit Sub

    //  On Error Resume Next

    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\TDiWeb.html", _
    //                              "\TDiWeb.out.html", _
    //                              TdbGlobal(), _
    //                              "select * from api_v_listedi_web where NDIWNUM = " & adoRS("NDIWNUM"), _
    //                              " (Visualisation devis)", _
    //                              "PREVIEW"

    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Close();
    }
    //    Private Sub cmdQuitter_Click()
    //  ' fermeture de la fenetre
    //  Unload Me

    //End Sub
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
  }
}

