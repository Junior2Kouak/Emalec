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
  public partial class frmListeLogweb : Form
  {
    DataTable dt = new DataTable();

    public frmListeLogweb()
    {
      InitializeComponent();
    }

    private void frmListeLogweb_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        apiGrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_listeLog_web");
        apiGrid.GridControl.DataSource = dt;

        InitApigrid();
        //InitNbConnex();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApigrid()
    {
      apiGrid.AddColumn(Resources.col_Type, "VTYPE", 2000);
      apiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2800);
      apiGrid.AddColumn(Resources.col_Date, "DLOGDAC", 1700, "Date");
      apiGrid.AddColumn(Resources.col_Login, "UP", 1800);
      apiGrid.AddColumn(Resources.col_Description, "VMSG", 5700);
      apiGrid.AddColumn(Resources.col_NumCLI, "NCLINUM", 0);
      apiGrid.AddColumn(Resources.col_Type, "CLOGTYP", 0);

      apiGrid.InitColumnList();
    }

    //private void InitNbConnex()
    //{
    //  string sSQL = "select count(nlognum) From Commun.dbo.twlog where dlogdac between dateadd(mm,-12,getdate()) and getdate() and SOCIETE = App_Name()";
    //  lblNbPages.Text = $"{ModuleData.ExecuteScalarInt(sSQL)}";

    //  sSQL = "select count(nlognum) From Commun.dbo.twlog where dlogdac between dateadd(mm,-12,getdate()) and getdate() and SOCIETE = App_Name() and VLOGPAG = 'CNX'";
    //  lblNbConnex.Text = $"{ModuleData.ExecuteScalarInt(sSQL)}";
    //}

    private void frmListeLogweb_FormClosing(object sender, FormClosingEventArgs e)
    {
      Cursor.Current = Cursors.Default;
    }

    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Dispose();
    }
  }
}

