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
  public partial class frmListeDataTabletSTFArch : Form
  {
    DataTable dt = new DataTable();

    //    Dim rsGrid As New ADODB.Recordset;
    public frmListeDataTabletSTFArch()
    {
      InitializeComponent();
    }

    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    //VB6
    //Private Sub Form_Load()
    //  On Error GoTo Handler:
    //  InitBoutons Me, frmMenu
    //  rsGrid.Open "exec api_sp_ListeActTabletSTF 'N'", cnx
    //  InitData
    //Exit Sub
    //Resume
    //Handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    private void frmListeDataTabletSTFArch_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_ListeActTabletSTF 'N'");
        apiTGrid1.GridControl.DataSource = dt;
        InitApiGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    //VB6
    //Private Sub InitData()
    //  apiTgrid.AddColumn "Réception", "DDATRECEPT", 1500
    //  apiTgrid.AddColumn "Tech", "TECH", 1500
    //  apiTgrid.AddColumn "Di", "NDINNUM", 800
    //  apiTgrid.AddColumn "Client", "VCLINOM", 1500
    //  apiTgrid.AddColumn "Site", "VSITNOM", 1500
    //  apiTgrid.AddColumn "Act", "VACTDES", 3000
    //  apiTgrid.AddColumn "Date arrivée", "DACTARR", 2000
    //  apiTgrid.AddColumn "Date exec", "DACTDEX", 2000
    //  apiTgrid.AddColumn "Traitement", "DDATVALIDATION", 2000
    //  apiTgrid.AddColumn "Par", "UTIL", 1500
    //  ' Tooltip sur des cellules
    //  apiTgrid.AddCellTip "VACTDES", &HFDF0DA
    //  apiTgrid.Init rsGrid
    //End Sub

    private void InitApiGrid()
    {
      apiTGrid1.AddColumn(Resources.col_Reception, "DDATRECEPT", 1500, "Date");
      apiTGrid1.AddColumn(Resources.col_Tech, "TECH", 1500);
      apiTGrid1.AddColumn(Resources.col_DI, "NDINNUM", 800);
      apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1500);
      apiTGrid1.AddColumn(Resources.col_Site, "VSITNOM", 1500);
      apiTGrid1.AddColumn(Resources.col_Act, "VACTDES", 4000, "", 0, true);//Tooltip sur des cellules
      apiTGrid1.AddColumn(Resources.col_DateArrivee, "DACTARR", 1500, "Date");
      apiTGrid1.AddColumn(Resources.col_DateExec, "DACTDEX", 1500, "Date");
      apiTGrid1.AddColumn(Resources.col_Traitement, "DDATVALIDATION", 1500, "Date");
      apiTGrid1.AddColumn(Resources.col_Par, "UTIL", 1500);

      apiTGrid1.InitColumnList();
    }

    //Private Sub Form_Unload(Cancel As Integer)
    //  rsGrid.Close
    //  Set rsGrid = Nothing
    //End Sub

  }
}
