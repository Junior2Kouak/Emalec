using MZCtrlResources = MozartControls.Properties.Resources;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MozartNet;
using MozartCS.Properties;
using MozartLib;
using DevExpress.XtraGrid.Views.Grid;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeReclamation : Form
  {

    DataTable dt = new DataTable();

    TooltipGridTPE _tpe;

    public frmListeReclamation() { InitializeComponent(); }

    /* OK ------------------------------------------------------------*/
    private void frmListeReclamation_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_listeDiActionRecla " +
                $" WHERE CNCPCOMPTE = 'N' AND LANGUE = '{MozartParams.Langue}'" +
                $" order by NDINNUM DESC ");
        apiTGrid1.GridControl.DataSource = dt;

        InitTGrid1();

        _tpe = new TooltipGridTPE(apiTGrid1, toolTipController1);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }


    /* OK --------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;

      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      //écran de modification de la demande
      MozartParams.NumDi = Convert.ToInt32(currentRow["NDINNUM"]);
      MozartParams.NumAction = Convert.ToInt32(currentRow["NACTNUM"]);

      new frmAddAction() { mstrStatutDI = "M" }.ShowDialog();

      Cursor = Cursors.Default;

      // on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      //      if(mbRefresh)
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);

      //      mbRefresh = false;
      Cursor = Cursors.Default;
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void cmdDIweb_Click(object sender, EventArgs e)
    {
      new frmTauxConformite("G").ShowDialog();
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void cmdRMPT_Click(object sender, EventArgs e)
    {
      new frmTauxConformite("R").ShowDialog();
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void cmdArchive_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmListeReclamationArch().ShowDialog();
      Cursor = Cursors.Default;
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void InitTGrid1()
    {
      apiTGrid1.AddColumn(Resources.col_DI, "NDINNUM", 700);
      apiTGrid1.AddColumn("Date exécution", "DACTDEX", 850, "dd/mm/yy");
      apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1000, "", 0, true);
      apiTGrid1.AddColumn("N° Compte", "NDINCTE", 480);
      apiTGrid1.AddColumn(Resources.col_Enseigne, "VSITENSEIGNE", 600, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Chaff, "VDINCHAFF", 1000, "", 0, true);
      apiTGrid1.AddColumn("Chef de groupe", "VGRPNOM", 1000, "", 0, true);
      apiTGrid1.AddColumn("Nom intervenant", "VACTINT", 1000, "", 0, true);
      apiTGrid1.AddColumn("RRET", "VNOM_RRET", 1000, "", 0, true);
      apiTGrid1.AddColumn("NC prise en cpte", "CNCPCOMPTE", 1500);
      apiTGrid1.AddColumn(Resources.col_processusQua, "PROCESS", 2500);
      apiTGrid1.AddColumn("Cause Racine", "VLIBCAUSERACINE", 2500);
      apiTGrid1.AddColumn(Resources.col_Action, "VACTDES", 4500, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_T_echnique, "CTECCOD", 300, "", 2);
      apiTGrid1.AddColumn(Resources.col_P_restation, "CPRECOD", 300, "", 2, true);
      apiTGrid1.AddColumn(Resources.col_E_tat, "CETACOD", 300, "", 2, true);
      apiTGrid1.AddColumn(Resources.col_A_dministration, "CACTSTA", 230, "", 2);

      apiTGrid1.InitColumnList();
    }

    private void apiTGrid1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
    {
      GridView View = sender as GridView;

      if (e.RowHandle >= 0)
      {
        if (View.GetDataRow(e.RowHandle)["CNCPCOMPTE"].ToString().ToUpper() == "O")
        {
          e.Appearance.BackColor = System.Drawing.Color.Green;
          e.HighPriority = true;
        }
      }
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void cmdTauxACH_Click(object sender, EventArgs e)
    {
      new frmTauxConformite("C").ShowDialog();
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void cmdTauxMag_Click(object sender, EventArgs e)
    {
      new frmTauxConformite("M").ShowDialog();
    }



  }
}

