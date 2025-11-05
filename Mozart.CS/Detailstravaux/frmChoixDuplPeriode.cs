using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixDuplPeriode : Form
  {
    private string mDateSouhaitee;
    private int mNACTNUM;

    public frmChoixDuplPeriode(string pDateSouhaitee, int pNActNum)
    {
      InitializeComponent();

      mDateSouhaitee = pDateSouhaitee;
      mNACTNUM = pNActNum;
    }

    private void frmChoixDuplPeriode_Load(object sender, System.EventArgs e)
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

    private void cmdQuot_Click(object sender, EventArgs e)
    {
      new frmChoixPeriodeDuplicateAct(mDateSouhaitee, mNACTNUM).ShowDialog();

      Dispose();
    }

    private void cmdMens_Click(object sender, EventArgs e)
    {
      new frmDuplicateActMens(mNACTNUM)
      {
      }.ShowDialog();

      Dispose();
    }
  }
}

