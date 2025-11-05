using MZCtrlResources = MozartControls.Properties.Resources;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MozartNet;
using MozartCS.Properties;
using MZUtils = MozartControls.Utils;
using MozartLib;

namespace MozartCS
{
  public partial class frmListeChiffrageNF : Form
  {
    DataTable dt = new DataTable();
    public long miNumDI = 0;
    public long miNumClient;

    public frmListeChiffrageNF()
    {
      InitializeComponent();
    }

    private void frmStatFourNF_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        string sSQL = $"exec api_sp_ListeChiffragesNF {miNumDI}";

        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apiTGrid.GridControl.DataSource = dt;

        InitApigrid();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void InitApigrid()
    {
      apiTGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1800);
      apiTGrid.AddColumn(Resources.col_Site, "VSITNOM", 2800);
      apiTGrid.AddColumn(Resources.col_DI, "NUMDI", 1000);
      apiTGrid.AddColumn(Resources.col_Action, "VACTDES", 3800);
      apiTGrid.AddColumn(Resources.col_euro_heure, "NELFNFTMO", 1500, "currency", 1);
      apiTGrid.AddColumn(Resources.col_euro_depl, "NELFNFTDEP", 1500, "currency", 1);
      apiTGrid.AddColumn(Resources.col_four, "NELFNFFOU", 1500, "currency", 1);
      apiTGrid.AddColumn(Resources.col_Forfait, "NELFNFFOR", 1500, "currency", 1);
      apiTGrid.AddColumn(Resources.col_Total, "NELFNFTHT", 1500, "currency", 1);
      apiTGrid.AddColumn("NELFNFNUM", "NELFNFNUM", 0);
      apiTGrid.AddColumn("NACTNUM", "NACTNUM", 0);


      apiTGrid.InitColumnList();
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      new frmChiffrageNF
      {
        mstrStatutElemFact = "M",
        miNumElemFact = Convert.ToInt32(row["NELFNFNUM"]),
        miNumDI = miNumDI
      }.ShowDialog();

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdNouveau_Click(object sender, EventArgs e)
    {
      new frmChiffrageNF
      {
        miNumElemFact = 0,
        mstrStatutElemFact = "C",
        miNumDI = miNumDI
      }.ShowDialog();

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);

    }

		private void cmdSupprimer_Click(object sender, EventArgs e)
		{
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show(Resources.msg_Confirm_Suppr_Lot, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
      
      MozartDatabase.ExecuteNonQuery($"Delete from TELFNF where NELFNFNUM = {Convert.ToInt32(row["NELFNFNUM"])}");


      //  traitement des articles sélectionnés - on supprime tous les articles de la table TFNF
      // un trigger de delete supprime dans TSTOCK
      MozartDatabase.ExecuteNonQuery($"Delete from TFNF where BTYPEP3=1 AND NACTNUM = {Convert.ToInt32(row["NACTNUM"])}");

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);

    }
  }
}

