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
  public partial class frmAttachDetailHr : Form
  {

    DataTable dt = new DataTable();

    public frmAttachDetailHr()
    {
      InitializeComponent();
    }


    private void frmAttachDetailHr_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        long lNumAction = MozartParams.NumAction;

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"EXEC [api_sp_ListeAttachDetailHr] {lNumAction}");
        apiTGrid1.GridControl.DataSource = dt;
        InitApigrid();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApigrid()
    {
      apiTGrid1.AddColumn(Resources.col_Jour, "DJOUR", 80);
      apiTGrid1.AddColumn(Resources.col_NbHrAteliers, "NB_HR_ATELIER", 120, "0.##", 1);
      apiTGrid1.AddColumn(Resources.col_NbHrSites, "NB_HR_SITE", 120, "0.##", 1);
      apiTGrid1.AddColumn(Resources.col_NbHrRoutes, "NB_HR_ROUTE", 120, "0.##", 1);
      apiTGrid1.AddColumn(Resources.col_NbRepas, "NB_REPAS", 120, "0.##", 1);
      apiTGrid1.AddColumn(Resources.col_NbNuitee, "NB_NUITEE", 120, "0.##", 1);
      apiTGrid1.AddColumn(Resources.col_TotHrs, "TOT_NB_HR_JOUR", 120, "0.##", 1);
      apiTGrid1.AddColumn("CETAT", "CETAT", 0);
      apiTGrid1.AddColumn("NATTACH_DET_ID_SERVER", "NATTACH_DET_ID_SERVER", 0);
      apiTGrid1.AddColumn("NATTACH_DET_ID", "NATTACH_DET_ID", 0);
      apiTGrid1.AddColumn("NIPLNUM", "NIPLNUM", 0);

      apiTGrid1.InitColumnList();
    }


    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }
  }
}

