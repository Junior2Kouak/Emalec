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
  public partial class frmStatWebClient : Form
  {
    DataTable dt = new DataTable();
    DataTable dt2 = new DataTable();

    public frmStatWebClient()
    {
      InitializeComponent();
    }

    private void frmStatWebClient_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        apiGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_StatConnexion  ");
        apiGrid1.GridControl.DataSource = dt;

        InitApigrid();
        InitApigrid2();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiGrid1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow currentRow = apiGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      Cursor.Current = Cursors.WaitCursor;

      apiGrid2.LoadData(dt2, MozartDatabase.cnxMozart, $"api_sp_listeLog_web_client {currentRow["NCLINUM"]}");
      apiGrid2.GridControl.DataSource = dt2;
      Cursor.Current = Cursors.Default;
    }

    private void InitApigrid()
    {
      apiGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 3400);
      apiGrid1.AddColumn(Resources.col_Connexion, "NB", 1400, "", 2);
      apiGrid1.AddColumn(Resources.col_NumCLI, "NCLINUM", 0);

      apiGrid1.InitColumnList();
    }

    private void InitApigrid2()
    {
      apiGrid2.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 3200);
      apiGrid2.AddColumn(Resources.col_Login, "VUTILOG", 2000);
      apiGrid2.AddColumn(Resources.col_Connexion, "NB", 1400, "", 2);

      apiGrid2.InitColumnList();
    }

    private void frmStatWebClient_FormClosing(object sender, FormClosingEventArgs e)
    {
      Cursor.Current = Cursors.Default;
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}