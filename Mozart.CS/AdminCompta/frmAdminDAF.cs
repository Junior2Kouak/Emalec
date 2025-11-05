using MozartLib;
using MozartNet;
using System;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmAdminDAF : Form
  {
    public frmAdminDAF()
    {
      InitializeComponent();
    }

    private void frmAdminDAF_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      bool bEnable = (MozartParams.strUID == "GIRAUD-BY");
      cmdAdminRegleTVA.Enabled = bEnable;
      cmdTypePrestaTVAIntra.Enabled = bEnable;
    }

    private void cmdAdminDAF_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmAdminDAF_TauxAna().ShowDialog();
      Cursor = Cursors.Default;

      Close();
    }

    private void cmdAdminRegleTVA_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmAdminReglesTVA().ShowDialog();
      Cursor = Cursors.Default;

      // Je met le close mais il serait peut être plus judicieux de ne pas fermer cette fenêtre, si on veut juste vérifier le paramétrage
      Close();
    }

    private void cmdTypePrestaTVAIntra_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmAdminTypePrestaTVAIntra().ShowDialog();
      Cursor = Cursors.Default;

      // Je met le close mais il serait peut être plus judicieux de ne pas fermer cette fenêtre, si on veut juste vérifier le paramétrage
      Close();
    }

    private void cmdAdminTvaFilliale_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmAdminTVAFilliales().ShowDialog();
      Cursor = Cursors.Default;
      
      // Je met le close mais il serait peut être plus judicieux de ne pas fermer cette fenêtre, si on veut juste vérifier le paramétrage
      Close();
    }
  }
}
