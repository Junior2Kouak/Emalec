using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmMenuStatEI : Form
  {
    public frmMenuStatEI() { InitializeComponent(); }

    private void frmMenuStatEI_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void CmdClientsEI_Click(object sender, EventArgs e)
    {
      new frmListeClientsEI().ShowDialog();
    }

    private void cmdEI_Click(object sender, EventArgs e)
    {
      new frmTableauBordEI().ShowDialog();
    }

    private void CmdStatEIReappro_Click(object sender, EventArgs e)
    {
      new frmStatEIReappro().ShowDialog();
    }

    private void cmdStatEI_Click(object sender, EventArgs e)
    {
      new frmStatEI().ShowDialog();
    }

    private void cmdFactEi_Click(object sender, EventArgs e)
    {
      new frmStatFacturationEISemaine().ShowDialog();
    }

    private void cmdExt_Click(object sender, EventArgs e)
    {
      new frmStatModeleTXCharge("EXT").ShowDialog();
    }

    private void CmdStatFacEI_Click(object sender, EventArgs e)
    {
      new frmStatFacturationEI().ShowDialog();
    }

    private void cmdTechnicoEI_Click(object sender, EventArgs e)
    {
      new frmCompareTechEI().ShowDialog();
    }

    private void cmdChargeEI_Click(object sender, EventArgs e)
    {
      new frmChargeRegionEI().ShowDialog();
    }

    private void cmdSuiviRealPlanEvacEI_Click(object sender, EventArgs e)
    {
      new frmSuiviPlansEvacEI().ShowDialog();
    }
  }
}

