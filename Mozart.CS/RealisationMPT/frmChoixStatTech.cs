using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmChoixStatTech : Form
  {
    public frmChoixStatTech() { InitializeComponent(); }

    private void frmChoixStatTech_Load(object sender, System.EventArgs e)
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

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdStatTechTs_Click(object sender, EventArgs e)
    {
      new frmChoixDateStatTech("T").ShowDialog();
      Dispose();
    }

    private void CmdStatTechInd_Click(object sender, EventArgs e)
    {
      new frmStatTechIndividuel().ShowDialog();
      Dispose();
    }
  }
}

