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
  public partial class frmListeFactSTTRecu : Form
  {
    DataTable dt;

    TooltipGridTPE _tpe;

    public frmListeFactSTTRecu() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmListeFactSTTRecu_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        dt = new DataTable();
        apigrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_ListeSTTNonFact");
        apigrid.GridControl.DataSource = dt;
        InitApigrid();

        _tpe = new TooltipGridTPE(apigrid, toolTipController1);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }


    /* --------------------------------------------------------------------------------------- */
    void InitApigrid()
    {
      apigrid.AddColumn(Resources.col_DI, "NDINNUM", 700);
      apigrid.AddColumn("STT", "VSTFNOM", 2000);
      apigrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1400);
      apigrid.AddColumn(Resources.col_Site, "VSITNOM", 1800);
      apigrid.AddColumn(Resources.col_Num, "NSITNUE", 1000);
      apigrid.AddColumn(Resources.col_Action, "VACTDES", 3000, "", 0, true);
      apigrid.AddColumn(Resources.col_T_echnique, "CTECCOD", 230, "", 2);
      apigrid.AddColumn(Resources.col_P_restation, "CPRECOD", 230, "", 2);
      apigrid.AddColumn(Resources.col_E_tat, "CETACOD", 230, "", 2);
      apigrid.AddColumn(Resources.col_A_dministration, "CACTSTA", 230, "", 2);
      apigrid.AddColumn(Resources.col_CP, "VSITCP", 800);
      apigrid.AddColumn(Resources.col_Pays, "VSITPAYS", 1000);

      apigrid.InitColumnList();
    }

    /* --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apigrid.GetFocusedDataRow();
      if (null == row) return;
      //  écran de modification de la demande
      MozartParams.NumAction = (int)row["NACTNUM"];
      MozartParams.NumDi = (int)row["NDINNUM"];

      Cursor.Current = Cursors.WaitCursor;
      new frmAddAction { mstrStatutDI = "M" }.ShowDialog();

      // on revient donc on réinitialise les variables globales
      MozartParams.NumAction = 0;
      MozartParams.NumDi = 0;

      Cursor.Current = Cursors.WaitCursor;
      apigrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }


    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    /* --------------------------------------------------------------------------------------- */
    private void apigrid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }


  }
}

