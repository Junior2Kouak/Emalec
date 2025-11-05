using System.Windows.Forms;
using MozartNet;

namespace MozartCS
{
  public partial class frmMenuStatPlanning : Form
  {
    public frmMenuStatPlanning()
    {
      InitializeComponent();
      ModuleMain.Initboutons(this);
    }

    private void frmMenuStatPlanning_Load(object sender, System.EventArgs e)
    {

    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdStatPlanning_Click(object sender, System.EventArgs e)
    {
      new frmStatModeleTXCharge("MULTI").ShowDialog();
    }

    private void cmdCouv_Click(object sender, System.EventArgs e)
    {
      new frmStatOccupationPlanificateur().ShowDialog();
    }

    private void cmdTauxDeplPlanifs_Click(object sender, System.EventArgs e)
    {
      new frmTauxDeplacementPlanifs().ShowDialog();
    }

    private void cmdStatClim_Click(object sender, System.EventArgs e)
    {
      new frmStatModeleTXCharge("CLIM").ShowDialog();
    }

    private void BtnStatPlanningByReg_Click(object sender, System.EventArgs e)
    { 
        new frmStatPlanning_Delai_Pla_Reg(0).ShowDialog();
    }

    private void BtnStatPlanningByPers_Click(object sender, System.EventArgs e)
    {
      new frmStatPlanning_Delai_Pla_Reg(1).ShowDialog();
    }

    private void BtnStatPlanningDelaiPrevention_Click(object sender, System.EventArgs e)
    {
      new frmStatPlanning_Delai_Pla_Reg(2).ShowDialog();
    }
  }
}
