using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeVisites : Form
  {
    private DataTable dt = new DataTable();

    private bool mBModeArchives;

    public frmListeVisites()
    {
      InitializeComponent();

      mBModeArchives = false;
    }

    private void frmListeVisites_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      fillGrid();
    }

    private void initGrid()
    {
      apiTGridVisites.ClearColumns();

      apiTGridVisites.AddColumn("NVISITE", "NVISITE", 0);
      apiTGridVisites.AddColumn(MZCtrlResources.col_DateArr, "DVISITEDATARR", 900, "dd/MM/yy");
      apiTGridVisites.AddColumn(MZCtrlResources.col_HeureArr, "DVISITEHEURARR", 900, "HH:mm:ss");
      if (mBModeArchives)
      {
        apiTGridVisites.AddColumn(MZCtrlResources.col_DateSortie, "DVISITEDATDEP", 900, "dd/MM/yy");
        apiTGridVisites.AddColumn(MZCtrlResources.col_HeureSortie, "DVISITEHEURDEP", 900, "HH:mm:ss");
      }
      apiTGridVisites.AddColumn(MZCtrlResources.visiteur, "VVISITEUR", 1200);
      apiTGridVisites.AddColumn(MZCtrlResources.societe, "VSOCV", 1500);
      apiTGridVisites.AddColumn(MZCtrlResources.collaborateur, "VCOLLAB", 1200);
      apiTGridVisites.AddColumn(MZCtrlResources.motif, "VMOTIFNOM", 2500);

      apiTGridVisites.InitColumnList();
    }

    private void cmdAjouterVisite_Click(object sender, EventArgs e)
    {
      new frmDetailVisite().ShowDialog();

      apiTGridVisites.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdDetails_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridVisites.GetFocusedDataRow();
      if (currentRow == null) return;

      new frmDetailVisite(Convert.ToInt32(currentRow["NVISITE"])).ShowDialog();

      apiTGridVisites.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdListeArchives_Click(object sender, EventArgs e)
    {
      if (mBModeArchives)
      {
        // On est en mode archives, on passe en mode normal
        Label1.Text = "Liste des visites";
        cmdListeArchives.Text = "Liste des archives";

        cmdTerminer.Visible = true;
        cmdAjouterVisite.Visible = true;
      }
      else
      {
        // On est en mode normal, on passe en mode archives
        Label1.Text = "Liste des visites archivées";
        cmdListeArchives.Text = "Retour";

        cmdTerminer.Visible = false;
        cmdAjouterVisite.Visible = false;
      }

      mBModeArchives = !mBModeArchives;

      fillGrid();
    }

    private void fillGrid()
    {
      string lTestDate = mBModeArchives ? "NOT" : "";

      string lSql = $"SELECT NVISITE, DVISITEDATARR, DVISITEDATARR AS DVISITEHEURARR, DVISITEDATDEP, DVISITEDATDEP AS DVISITEHEURDEP,";
      lSql += $" CASE WHEN (VVISITENOMV + VVISITEPREV) = '' THEN '' ELSE CVISITECIV + ' ' + VVISITENOMV + ' ' + VVISITEPREV END AS VVISITEUR, VVISITEMAIL,";
      lSql += $" VVISITETEL, VVISITERS + CASE WHEN VVISITESERV = '' THEN '' ELSE ' / ' + VVISITESERV END AS VSOCV, VVISITENOMC + ' ' + VVISITEPREC AS VCOLLAB, VMOTIFNOM, VVISITECOM";
      lSql += $" FROM TVISITE";
      lSql += $" INNER JOIN TREF_MOTIFVISITE on TVISITE.NVISITEMOTIF = TREF_MOTIFVISITE.NMOTIFVISITE";
      lSql += $" WHERE VSOCIETE='{MozartParams.NomSociete}' AND DVISITEDATDEP IS {lTestDate} NULL AND LANGUE='{MozartParams.Langue}'";
      apiTGridVisites.LoadData(dt, MozartDatabase.cnxMozart, lSql);
      apiTGridVisites.GridControl.DataSource = dt;

      initGrid();
    }

    private void cmdTerminer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGridVisites.GetFocusedDataRow();
        if (currentRow == null) return;

        new frmDetailVisite(Convert.ToInt32(currentRow["NVISITE"]), true).ShowDialog();

        apiTGridVisites.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}
