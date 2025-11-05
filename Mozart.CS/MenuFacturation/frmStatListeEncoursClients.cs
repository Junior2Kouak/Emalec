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
  public partial class frmStatListeEncoursClients : Form
  {
    private DataTable dt = new DataTable();

    public frmStatListeEncoursClients()
    {
      InitializeComponent();
    }

    private void frmStatListeEncoursClients_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);
        InitApigrid();

        ApiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"EXEC api_sp_ListeFactRetardClient");
        ApiGrid.GridControl.DataSource = dt;
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

    private void cmdDetail_Click(object sender, System.EventArgs e)
    {
      DataRow currentRow = ApiGrid.GetFocusedDataRow();
      if (currentRow != null)
      {
        int iCliNum = currentRow["NCLINUM"].ToString() != "" ? (int)currentRow["NCLINUM"] : 0;

        if (iCliNum != 0)
        {
          new frmStatEncoursClient(currentRow["VCLINOM"].ToString(), iCliNum).ShowDialog();
        }
      }
    }

    private void InitApigrid()
    {
      ApiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 3450);
      ApiGrid.AddColumn(Resources.col_nb_factures, "NB", 1100, "# ### ### ", 1);
      ApiGrid.AddColumn(Resources.col_EncoursTotal, "TTC", 1500, "# ### ### ", 1);
      ApiGrid.AddColumn("§DU§", "DU", 0, "# ### ### ", 1);                            // invisible
      ApiGrid.AddColumn(Resources.col_EncoursTTCechu, "TTCECH", 1500, "# ### ### ", 1);
      ApiGrid.AddColumn(Resources.col_EncoursDuEchu, "DUECH", 1500, "# ### ### ", 1);
      ApiGrid.AddColumn(Resources.col_NCLINUM, "NCLINUM", 0);                         // invisible

      ApiGrid.InitColumnList();
    }
  }
}

