using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmDocGamme : Form
  {
    public frmDocGamme()
    {
      InitializeComponent();
    }

    private void frmDocGamme_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdTram_Click(object sender, EventArgs e)
    {
      new frmTramesGammeEmalec().ShowDialog();
    }

    private void cmdCli_Click(object sender, EventArgs e)
    {
      new frmTrameGammeClient().ShowDialog();
    }

    private void cmdSite_Click(object sender, EventArgs e)
    {
      new frmTrameGammeSite().ShowDialog();
    }
  }
}