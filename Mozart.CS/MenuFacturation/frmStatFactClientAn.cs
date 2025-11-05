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
  public partial class frmStatFactClientAn : Form
  {
    private int mlNumMenu;
    private DataTable dt = new DataTable();

    public frmStatFactClientAn(int pNumMenu)
    {
      InitializeComponent();

      mlNumMenu = pNumMenu;
    }

    private void frmStatFactClientAn_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_StatFactClientParAn '{MozartParams.NomSocieteTemp}', {mlNumMenu}, {MozartParams.UID}");
        apiTGrid1.GridControl.DataSource = dt;
        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    private void InitApigrid()
    {
      try
      {
        apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2700);
        apiTGrid1.AddColumn("2002", "AN2002", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("2003", "AN2003", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("2004", "AN2004", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("2005", "AN2005", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("2006", "AN2006", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("2007", "AN2007", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("2008", "AN2008", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("2009", "AN2009", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("2010", "AN2010", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("2011", "AN2011", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("2012", "AN2012", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("2013", "AN2013", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("2014", "AN2014", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("2015", "AN2015", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("2016", "AN2016", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("2017", "AN2017", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("2018", "AN2018", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("2019", "AN2019", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("2020", "AN2020", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn(Resources.col_TotEuroHT, "TOTAL", 1100, "# ### ###", 2);
        apiTGrid1.AddColumn("NCLINUM", "NCLINUM", 0);

        apiTGrid1.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow != null)
      {
        new frmStatCAClientParAN(currentRow["NCLINUM"]).ShowDialog();
      }
    }
  }
}

