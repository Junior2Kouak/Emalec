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
  public partial class frmStatMenuWebClient : Form
  {
    DataTable dt = new DataTable();
    public frmStatMenuWebClient()
    {
      InitializeComponent();
    }

    private void frmStatMenuWebClient_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        apiGrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_StatMenuWeb");
        apiGrid.GridControl.DataSource = dt;

        InitApigrid();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApigrid()
    {
      apiGrid.AddColumn(Resources.col_Menu, "MENUP", 4200);
      apiGrid.AddColumn(Resources.col_SousMenu, "MENUS", 5500);
      apiGrid.AddColumn(Resources.col_Utilisation, "NB", 1200, "", 2);

      apiGrid.InitColumnList();
    }

    private void frmStatMenuWebClient_FormClosing(object sender, FormClosingEventArgs e)
    {
      Cursor = Cursors.Default;
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
  }
}

