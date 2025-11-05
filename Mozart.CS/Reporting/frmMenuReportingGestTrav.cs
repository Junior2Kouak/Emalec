using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmMenuReportingGestTrav : Form
  {
    public frmMenuReportingGestTrav()
    {
      InitializeComponent();
    }

    private void frmMenuReportingGestTrav_Load(object sender, EventArgs e)
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

    private void BtnChargeDevPrev_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmGestTrav_ChargeDevPrevisionel().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdDev_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmTauxConformite("A").ShowDialog();
      Cursor.Current = Cursors.Default;
    }
  }
}
