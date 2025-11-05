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
  public partial class frmListeInfoSites : Form
  {
    DataTable dt = new DataTable();

    public frmListeInfoSites() { InitializeComponent(); }

    private void frmListeInfoSites_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_listeDiActionNonInfoSite ORDER BY DACTDATE, VCLINOM, VSITNOM");
        apiTGrid1.GridControl.DataSource = dt;

        InitTGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      //écran de modification de la demande
      MozartParams.NumDi = (int)row["NDINNUM"];
      MozartParams.NumAction = (int)row["NACTNUM"];

      Cursor.Current = Cursors.WaitCursor;

      new frmAddAction()
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

    private void apiTGrid1_DblClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }

    private void InitTGrid()
    {
      apiTGrid1.AddColumn(Resources.col_DI, "NDINNUM", 700);
      apiTGrid1.AddColumn(Resources.col_date_c, "DDINDATHEUR", 850, "dd/MM/yy");
      apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1000);
      apiTGrid1.AddColumn(Resources.col_Site, "VSITNOM", 1350);
      apiTGrid1.AddColumn("N°", "NSITNUE", 480);
      apiTGrid1.AddColumn(Resources.col_Enseigne, "VSITENSEIGNE", 600);
      apiTGrid1.AddColumn(Resources.col_Chaff, "VPERNOM", 1000);
      apiTGrid1.AddColumn(Resources.col_Action, "VACTDES", 4500, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Date, "DACTDATE", 850, "dd/MM/yy");
      apiTGrid1.AddColumn("Intervenant", "VACTINT", 800);
      apiTGrid1.AddColumn(Resources.col_Technique, "CTECCOD", 350);
      apiTGrid1.AddColumn(Resources.col_Prestation, "CPRECOD", 350, "", 2);
      apiTGrid1.AddColumn(Resources.col_etat, "CETACOD", 350, "", 2);
      apiTGrid1.AddColumn(Resources.col_Administration, "CACTSTA", 350, "", 2);
      apiTGrid1.AddColumn("Observations manuelles", "VACTOBSM", 2100, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_OBS, "VACTOBS", 2100, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Type, "VSITTYPE", 1000, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_RM, "VCCLNOM", 1000, "", 0, true);      // Resp Maintenance
      apiTGrid1.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
      apiTGrid1.AddColumn("Type", "CACTTYT", 600);
      apiTGrid1.AddColumn(Resources.col_Site, "NSITNUM", 0);
      apiTGrid1.AddColumn(Resources.col_HorsWeb, "CACTVUEWEB", 0);
      apiTGrid1.AddColumn(Resources.col_Num_CDE, "VACTNUMCDE", 800);
      apiTGrid1.AddColumn(Resources.col_CP, "VSITCP", 800);

      apiTGrid1.InitColumnList();
    }
  }
}
