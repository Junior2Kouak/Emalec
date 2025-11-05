using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmSuiviContratsClients : Form
  {
    private DataTable dtData;
    private bool bArchives;

    public frmSuiviContratsClients()
    {
      InitializeComponent();
    }

    private void frmSuiviContratsClients_Load(object sender, EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        bArchives = false;

        Loaddata();
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }

    private void Loaddata()
    {
      dtData = new DataTable();

      dtData.Load(MozartDatabase.ExecuteReader("EXEC [api_sp_SuiviClientele_Tableau]"));

      GCMain.DataSource = dtData;
    }

    private void ChkCliActif_CheckedChanged(object sender, EventArgs e)
    {
      if (ChkCliActif.Checked)
      {
        ABGV_Main.ActiveFilterString = "[NB_ACT] > 0";
      }
      else
      {
        ABGV_Main.ActiveFilterString = "[NB_ACT] = 0";
      }      
    }

    private void BtnPrixCliPays_Click(object sender, EventArgs e)
    {
      DataRow row = ABGV_Main.GetFocusedDataRow();
      if (row == null) return;

      int bookmark = ABGV_Main.FocusedRowHandle;

      new frmPrixClientContrat { miNumClient = (int)row["NCLINUM"], sNomClient = (string)row["VCLINOM"] }.ShowDialog();

      ABGV_Main.FocusedRowHandle = bookmark;
    }

    private void BtnContrat_Click(object sender, EventArgs e)
    {
      DataRow row = ABGV_Main.GetFocusedDataRow();
      if (row == null) return;

      int bookmark = ABGV_Main.FocusedRowHandle;

      new frmClientsContrats_Liste((int)row["NCLINUM"]) { sNomClient = (string)row["VCLINOM"] }.ShowDialog();
      ABGV_Main.FocusedRowHandle = bookmark;
    }

    private void BtnPlanPrev_Click(object sender, EventArgs e)
    {
      DataRow row = ABGV_Main.GetFocusedDataRow();
      if (row == null) return;

      int bookmark = ABGV_Main.FocusedRowHandle;

      new frmGestProcedure
      {
        miNumSite = 0,
        mstrType = "PLANPREVCLIENT",
        miNumClient = (int)row["NCLINUM"],
        msTitre = $" du client : {row["VCLINOM"]}"
      }.ShowDialog();

      ABGV_Main.FocusedRowHandle = bookmark;
    }

    private void BtnAchives_Click(object sender, EventArgs e)
    {     
      if (bArchives)
      {
        Label14.Text = "SUIVI DE LA CLIENTELE : Clients actifs";
        BtnAchives.Text = "Listes archives";
        ABGV_Main.ActiveFilterString = "[CCLIACTIF] = 'O'";
        ChkCliActif.Visible = true;
      }
      else
      {
        Label14.Text = "SUIVI DE LA CLIENTELE : Clients archivés";
        BtnAchives.Text = "Listes actifs";
        ABGV_Main.ActiveFilterString = "[CCLIACTIF] = 'N'";
        ChkCliActif.Visible = false;
      }

      bArchives = !bArchives;
    }

    private void RepoHyperLinkPays_Click(object sender, EventArgs e)
    {
      DataRow row = ABGV_Main.GetFocusedDataRow();
      if (row == null) return;

      int bookmark = ABGV_Main.FocusedRowHandle;

      new frmSuiviContratsClients_ListePaysByContrat() { NIDCONTRATCLI_DETAIL = (int)Utils.ZeroIfNull(row["NIDCONTRATCLI_DETAIL"]) }.ShowDialog();

      ABGV_Main.FocusedRowHandle = bookmark;
    }

		private void cmdExcel_Click(object sender, EventArgs e)
		{
      string fileName = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\ListeComptesAnalytiques_{DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString()}.xls";
      GCMain.ExportToXls(fileName);
      System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));

    }
  }
}
