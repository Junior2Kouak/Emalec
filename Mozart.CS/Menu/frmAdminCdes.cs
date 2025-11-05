using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmAdminCdes : Form
  {
    public frmAdminCdes() { InitializeComponent(); }

    private void frmAdminCdes_Load(object sender, System.EventArgs e)
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

    private void cmdCdesDI_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      new frmListeOutilsAcmd().ShowDialog();

      Cursor.Current = Cursors.Default;
    }

    private void cmdCdesPlanifiées_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      new frmListeCommandesFour()
      {
        mstrStatutCom = "P", //Commandes planifiées
      }.ShowDialog();

      Cursor.Current = Cursors.Default;
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
  }
}

