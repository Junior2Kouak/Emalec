using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixIntercalaires : Form
  {
    public frmChoixIntercalaires()
    {
      InitializeComponent();
    }

    private void frmChoixIntercalaires_Load(object sender, System.EventArgs e)
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

    private void cmdValider_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      if (optSitesClient.Checked)
      {
        Cursor.Current = Cursors.WaitCursor;
        frmIntercalaires f = new frmIntercalaires();
        f.mstrType = "INTERCALAIRES";
        f.ShowDialog();
      }
      else if (optTexteLibre.Checked)
      {
        Cursor.Current = Cursors.WaitCursor;
        new frmIntercalairesLibre().ShowDialog();
      }
      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdValider_Click()
    //
    //  If optInter(0) Then
    //    frmIntercalaires.mstrType = "INTERCALAIRES"
    //    frmIntercalaires.Show vbModal
    //  End If
    //    
    //  If optInter(1) Then frmIntercalairesLibre.Show vbModal
    //    
    //End Sub
  }
}

