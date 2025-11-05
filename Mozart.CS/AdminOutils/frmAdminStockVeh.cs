using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmAdminStockVeh : Form
  {
    public frmAdminStockVeh()
    {
      InitializeComponent();
    }

    private void frmAdminStockVeh_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        Cursor.Current = Cursors.Default;
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

    private void cmdListe_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeReapproVehiTechnicien().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdListeReap_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmAdminReapro().ShowDialog();
      Cursor.Current = Cursors.Default;
    }
  }
}