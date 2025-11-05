using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmMenuCompta : Form
  {
    public frmMenuCompta() { InitializeComponent(); }

    private void frmMenuCompta_Load(object sender, System.EventArgs e)
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
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdFactChaff_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmStatImpayesClient().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdChaff_Click(object sender, EventArgs e)
    {
      new frmAdminEtatComptaChaff().ShowDialog();
    }

    private void CmdTabBalAna_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new FrmSynthCompta().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdAvoir_Click(object sender, EventArgs e)
    {
      new frmListeAvoirsBloquees().ShowDialog();
    }

    private void CmdReportingAnaGrp_Click(object sender, EventArgs e)
    {
      new frmSyntheseREXGroupe().ShowDialog();
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmListeAttestationTVA().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdBIC_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmListeRSF().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void BtnReportAnaV2_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new FrmSynthComptaV2().ShowDialog();
      Cursor = Cursors.Default;
    }
  }
}

