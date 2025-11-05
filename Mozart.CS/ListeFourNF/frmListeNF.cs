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
  public partial class frmListeNF : Form
  {
    DataTable dt = new DataTable();
    public long miNumDI = 0;
    public int miNumClient;

    public frmListeNF()
    {
      InitializeComponent();
    }

    private void frmListeNF_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        string sSQL = $"exec api_sp_ListeActionNF {miNumDI}";

        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apiTGrid.GridControl.DataSource = dt;

        InitApigrid();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApigrid()
    {
      apiTGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1800);
      apiTGrid.AddColumn(Resources.col_Site, "VSITNOM", 2800);
      apiTGrid.AddColumn(Resources.col_DI, "NUMDI", 1000);
      apiTGrid.AddColumn(Resources.col_Action, "VACTDES", 3800);
      apiTGrid.AddColumn(Resources.col_euro_heure, "NNFTOTH", 1500, "currency", 1);
      apiTGrid.AddColumn(Resources.col_euro_depl, "NNFTOTDEP", 1500, "currency", 1);
      apiTGrid.AddColumn(Resources.col_four, "NNFFOU", 1500, "currency", 1);
      apiTGrid.AddColumn(Resources.col_stt, "NNFSTT", 1500, "currency", 1);
      apiTGrid.AddColumn(Resources.col_Total, "NNFTHT", 1500, "currency", 1);
      apiTGrid.AddColumn("NACTNUM", "NACTNUM", 0);


      apiTGrid.InitColumnList();
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      new frmDetailNF
      {
        mstrStatutElemFact = "M",
        miNumAction = Convert.ToInt32(row["NACTNUM"]),
        miNumClient = miNumClient,
        miNumDI = miNumDI
      }.ShowDialog();

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdNouveau_Click(object sender, EventArgs e)
    {
      new frmDetailNF
      {
        mstrStatutElemFact = "C",
        miNumAction = 0,
        miNumClient = miNumClient,
        miNumDI = miNumDI
      }.ShowDialog();

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);

    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show(Resources.msg_confirm_del_ligne, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) != DialogResult.Yes)
        return;

      ModuleData.CnxExecute($"DELETE FROM TNF WHERE NACTNUM = {Convert.ToInt32(row["NACTNUM"])}");

      ModuleData.CnxExecute($"DELETE FROM TFNF WHERE NACTNUM = {Convert.ToInt32(row["NACTNUM"])}");

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);

    }
  }
}

