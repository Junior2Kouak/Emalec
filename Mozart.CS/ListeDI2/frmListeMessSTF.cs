using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;
using MozartUC;

namespace MozartCS
{
  public partial class frmListeMessSTF : Form
  {
    DataTable dtMessSTF = new DataTable();

    public frmListeMessSTF()
    {
      InitializeComponent();
    }

    private void frmListeMessSTF_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiGrid.LoadData(dtMessSTF, MozartDatabase.cnxMozart, $"SELECT * FROM api_v_ListeWMessSTF WHERE DMESSSTFTRAITE IS NULL OR DMESSSTFTRAITE = ''");
        apiGrid.GridControl.DataSource = dtMessSTF;

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void CmdValid_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiGrid.GetFocusedDataRow();
        if (null == row) return;

        //écran de moficiation de la demande
        MozartParams.NumMsgSTWeb = (int)row["ID"];
        MozartParams.NumDi = (int)row["NDINNUM"];
        MozartParams.NumAction = (int)row["NACTNUM"];

        Cursor.Current = Cursors.WaitCursor;
        new frmAddAction()
        {
          mstrStatutDI = "MessageSTF"
        }.ShowDialog();

        Cursor.Current = Cursors.WaitCursor;

        //on revient donc on réinitialise les variables globales
        MozartParams.NumMsgSTWeb = 0;
        MozartParams.NumDi = 0;
        MozartParams.NumAction = 0;

        //on init le message
        apiGrid.Requery(dtMessSTF, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void InitApigrid()
    {
      apiGrid.AddColumn(MZCtrlResources.col_Date, "DDATECRE", 600, "dd/MM/yy", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiGrid.AddColumn("N° DI", "NDINNUM", 600, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1300);
      apiGrid.AddColumn(MZCtrlResources.col_Site, "VSITNOM", 1300);
      apiGrid.AddColumn(Resources.col_Chaff, "VDINCHAFF", 1000);
      apiGrid.AddColumn("Date exécution", "DDATEEXEC", 600, "dd/MM/yy HH:MM", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiGrid.AddColumn(MZCtrlResources.col_DateArr, "DACTARR", 600, "dd/MM/yy HH:MM", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiGrid.AddColumn(Resources.col_Nom_ST, "VSTFNOM", 1500);
      apiGrid.AddColumn(Resources.col_Intervenant, "VINTNOM", 1000);
      apiGrid.AddColumn(Resources.col_Message, "VMESSAGE", 2500);
      apiGrid.AddColumn("NACTNUM", "NACTNUM", 0);
      apiGrid.AddColumn("ID", "ID", 0);

      apiGrid.InitColumnList();
    }
  }
}
