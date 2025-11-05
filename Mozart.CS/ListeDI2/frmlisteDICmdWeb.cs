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
  public partial class frmlisteDICmdWeb : Form
  {
    DataTable dt = new DataTable();

    public frmlisteDICmdWeb() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmlisteDICmdWeb_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_listeDiActionCmdWeb ORDER BY NDINNUM DESC");
        apiTGrid1.GridControl.DataSource = dt;

        InitTGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    /* --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      //écran de modification de la demande
      MozartParams.NumDi = (int)row["NDINNUM"];
      MozartParams.NumAction = (int)row["NACTNUM"];

      Cursor.Current = Cursors.WaitCursor;
      new frmAddAction
      {
        mstrStatutDI = "M",
      }.ShowDialog();

      //on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      Cursor.Current = Cursors.WaitCursor;
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }


    /* --------------------------------------------------------------------------------------- */
    private void apiTGrid1_DblClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }

    private void InitTGrid()
    {
      apiTGrid1.AddColumn(Resources.col_DI, "NDINNUM", 300);
      apiTGrid1.AddColumn(Resources.col_date_c, "DDINDATHEUR", 400, "dd/MM/yy");
      apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 800);
      apiTGrid1.AddColumn(Resources.col_Site, "VSITNOM", 800);
      apiTGrid1.AddColumn("N°", "NSITNUE", 400);
      apiTGrid1.AddColumn(Resources.col_Enseigne, "VSITENSEIGNE", 400);
      apiTGrid1.AddColumn(Resources.col_Chaff, "VPERNOM", 300);
      apiTGrid1.AddColumn(Resources.col_Action, "VACTDES", 1500, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Date, "DACTDATE", 500, "dd/MM/yy");
      apiTGrid1.AddColumn(Resources.col_etat, "CETACOD", 230, "", 2);
      apiTGrid1.AddColumn(Resources.col_Administration, "CACTSTA", 230, "", 2);
      apiTGrid1.AddColumn(Resources.col_OBS, "VACTOBS", 4000, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
      apiTGrid1.AddColumn(Resources.col_Site, "NSITNUM", 0);

      apiTGrid1.InitColumnList();
    }


  }
}

