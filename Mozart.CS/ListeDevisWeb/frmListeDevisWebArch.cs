using DevExpress.Data.Filtering;
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
  public partial class frmListeDevisWebArch : Form
  {
    DataTable dt = new DataTable();

    public frmListeDevisWebArch(CriteriaOperator pCriteriaOperator)
    {
      InitializeComponent();

      apiTGrid1.dgv.ActiveFilterCriteria = pCriteriaOperator;
    }

    private void frmListeDevisWebArch_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        string sSQL = $"select * from api_v_ListeDevisWebTech WHERE DWDEVDTRAITE is not null " +
                      $" and DWDEVDATE > DATEADD(MM, -18, GETDATE()) order by DWDEVDATE desc";

        // ouverture du recordset
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apiTGrid1.GridControl.DataSource = dt;
        InitApigrid1();
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

    private void cmdRestaurer_Click(object sender, EventArgs e)
    {
      DataRow currRow = apiTGrid1.GetFocusedDataRow();
      if (currRow == null) return;

      if (Utils.ZeroIfNull(currRow["NACTNUM"]) > 1)
      {
        MessageBox.Show(Resources.msg_restaure_devis_imp, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (MessageBox.Show(Resources.msg_devis_restaur_confirm, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      MozartDatabase.ExecuteNonQuery($"update TWDEVIS set DWDEVDTRAITE = null where NWDEVNUM = {currRow["NWDEVNUM"]}");

      //  rafraichissement du recordset
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      DataRow currRow = apiTGrid1.GetFocusedDataRow();
      if (currRow == null) return;

      string[,] TdbGlobal = { { "COPIE", "COPIE" } };

      new frmBrowser
      {
        miPlanningAn = 0
      }.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TDevisTechWeb.html",
                      @"TDevisTechWeb.out.html",
                      TdbGlobal,
                      $"select * from api_v_ListeDevisWebTech where NWDEVNUM={currRow["NWDEVNUM"]}",
                      " (Visualisation devis)", "PREVIEW");
    }

    private void InitApigrid1()
    {
      apiTGrid1.AddColumn("Num", "NWDEVNUM", 600);
      apiTGrid1.AddColumn(Resources.col_Technicien, "VPERNOM", 1100, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(MZCtrlResources.col_DateArr, "DWDEVDATE", 850, "Date", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn("Date d'archivage", "DWDEVDTRAITE", 850, "Date", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn("Qui a archivé", "QUIARCHIVE", 850, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1400, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(MZCtrlResources.col_Site, "VSITNOM", 1500, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(Resources.col_Titre, "VWDEVTITRE", 1700, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(Resources.col_Chaff, "CHAFF", 1000, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(Resources.col_Description, "LIB", 2500, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(Resources.col_fournitures, "VWDEVFOU", 2500, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(MZCtrlResources.col_Etat, "ETAT", 1500);
      apiTGrid1.AddColumn("numcli", "NCLINUM", 0);
      apiTGrid1.AddColumn("numsite", "NSITNUM", 0);
      apiTGrid1.AddColumn(Resources.col_heure, "NHEUREJ", 0);
      apiTGrid1.AddColumn(Resources.col_heuren, "NHEUREN", 0);
      apiTGrid1.AddColumn(Resources.col_Tech, "NBTECH", 0);
      apiTGrid1.AddColumn("NACTNUM", "NACTNUM", 0);

      //  ' Tooltip sur des cellules
      apiTGrid1.InitColumnList();
    }
  }
}
