using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Views.Base;
using Microsoft.VisualBasic;
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
  public partial class frmListeActionAValider : Form
  {
    DataTable dt;

    TooltipGridTPE _tpe;

    public frmListeActionAValider() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmListeActionAValider_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        dt = new DataTable();
        apigrid.LoadData(dt, MozartDatabase.cnxMozart, "select * from api_v_ListeDI2");
        apigrid.GridControl.DataSource = dt;
        InitapiGrid();

        _tpe = new TooltipGridTPE(apigrid, toolTipController1);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    void InitapiGrid()
    {
      apigrid.AddColumn(Resources.col_DI, "NDINNUM", 700);
      apigrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1800);
      apigrid.AddColumn(Resources.col_Site, "VSITNOM", 1800);
      apigrid.AddColumn(Resources.col_Num, "NSITNUE", 1000);
      apigrid.AddColumn(Resources.col_Chaff, "VDINCHAFF", 1500);
      apigrid.AddColumn(Resources.col_Action, "VACTDES", 4500, "", 0, true);
      apigrid.AddColumn(Resources.col_T_echnique, "CTECCOD", 280, "", 2);
      apigrid.AddColumn(Resources.col_P_restation, "CPRECOD", 280, "", 2);
      apigrid.AddColumn(Resources.col_E_tat, "CETACOD", 280, "", 2);
      apigrid.AddColumn(Resources.col_A_dministration, "CACTSTA", 280, "", 2);
      apigrid.AddColumn("Exec", "DACTDEX", 1200);
      apigrid.AddColumn("Tech", "VPERNOM", 1400);
      apigrid.AddColumn(Resources.col_CP, "VSITCP", 800);
      apigrid.AddColumn(Resources.col_Pays, "VSITPAYS", 1000);

      apigrid.InitColumnList();
      apigrid.dgv.CustomColumnDisplayText += apigrid_CustomColumnDisplayText;
    }
    private void apigrid_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
    {
      if (e.Column.FieldName == "DACTDEX" && null != e.Value && !Convert.IsDBNull(e.Value))
        e.DisplayText = Strings.FormatDateTime((DateTime)e.Value, DateFormat.GeneralDate);
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apigrid.GetFocusedDataRow();
      if (null == row) return;
      //  écran de modification de la demande
      MozartParams.NumAction = (int)row["NACTNUM"];
      MozartParams.NumDi = (int)row["NDINNUM"];

      Cursor.Current = Cursors.WaitCursor;
      new frmAddAction { mstrStatutDI = "M", miNumClient = (int)row["NCLINUM"] }.ShowDialog();

      // on revient donc on réinitialise les variables globales
      MozartParams.NumAction = 0;
      MozartParams.NumDi = 0;

      //Cursor.Current = Cursors.WaitCursor;
      //apigrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void apigrid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }


  }
}

