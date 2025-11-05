using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Views.Grid;
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
  public partial class frmListeReclamationArch : Form
  {
    DataTable dt = new DataTable();
    TooltipGridTPE _tpe;

    public frmListeReclamationArch() { InitializeComponent(); }

    private void frmListeReclamationArch_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_listeDiActionRecla " +
                $" WHERE  CNCPCOMPTE = 'O' AND LANGUE = '{MozartParams.Langue}'" +
                $" order by NDINNUM DESC ");
        apiTGrid1.GridControl.DataSource = dt;

        InitTGrid();

        _tpe = new TooltipGridTPE(apiTGrid1, toolTipController1);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      Cursor = Cursors.WaitCursor;

      //écran de modification de la demande
      MozartParams.NumDi = Convert.ToInt32(Utils.BlankIfNull(currentRow["NDINNUM"]));
      MozartParams.NumAction = Convert.ToInt32(Utils.BlankIfNull(currentRow["NACTNUM"]));

      new frmAddAction() { mstrStatutDI = "M" }.ShowDialog();

      //on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      Cursor = Cursors.Default;
    }

    private void InitTGrid()
    {
      apiTGrid1.AddColumn(Resources.col_DI, "NDINNUM", 700);
      apiTGrid1.AddColumn(Resources.col_date_c, "DDINDATHEUR", 850, "dd/mm/yy");
      apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1000, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Site, "VSITNOM", 1350, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_sitenum, "NSITNUE", 480);
      apiTGrid1.AddColumn(Resources.col_Enseigne, "VSITENSEIGNE", 600, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_processusQua, "PROCESS", 2500);
      apiTGrid1.AddColumn("Cause Racine", "VLIBCAUSERACINE", 2500);
      apiTGrid1.AddColumn(Resources.col_Chaff, "VDINCHAFF", 1000);
      apiTGrid1.AddColumn("RRET", "VNOM_RRET", 1300, "", 0, true);
      apiTGrid1.AddColumn("NC prise en cpte", "CNCPCOMPTE", 1300);
      apiTGrid1.AddColumn(Resources.col_Action, "VACTDES", 4500, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Date, "DACTDATE", 850, "dd/mm/yy");
      apiTGrid1.AddColumn(Resources.col_Technicien, "VACTINT", 800, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_T_echnique, "CTECCOD", 360, "", 2);
      apiTGrid1.AddColumn(Resources.col_P_restation, "CPRECOD", 360, "", 2, true);
      apiTGrid1.AddColumn(Resources.col_E_tat, "CETACOD", 360, "", 2, true);
      apiTGrid1.AddColumn(Resources.col_A_dministration, "CACTSTA", 400, "", 2);
      apiTGrid1.AddColumn(Resources.col_OBS, "VACTOBS", 2100, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_OBSM, "VACTOBSM", 2100, "", 0, true);

      apiTGrid1.InitColumnList();
    }

    private void apiTGrid1_RowStyle(object sender, RowStyleEventArgs e)
    {
      GridView View = sender as GridView;

      if (e.RowHandle >= 0)
      {
        if (View.GetDataRow(e.RowHandle)["CNCPCOMPTE"].ToString().ToUpper() == "O")
        {
          e.Appearance.BackColor = System.Drawing.Color.Lime;
          e.HighPriority = true;
        }
      }
    }
  }
}

