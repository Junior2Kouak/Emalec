using System;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmObservationsAdd : Form
  {
    // Public TxtObsAdd As String
    public string msObsAdd;

    public frmObservationsAdd()
    {
      InitializeComponent();
    }

    private void frmObservationsAdd_Load(object sender, EventArgs e)
    {
      txtObs.Text = msObsAdd;
    }

    private void cmdValObs_Click(object sender, EventArgs e)
    {
      msObsAdd = txtObs.Text;
      this.Close();
    }
    //Private Sub cmdValObs_Click()
    //    TxtObsAdd = TxtObs.Text
    //    Call Unload(Me)
    //End Sub

    private void cmdAnObs_Click(object sender, EventArgs e)
    {
      msObsAdd = "";
      Dispose();
    }
    //Private Sub cmdAnObs_Click()
    //    TxtObsAdd = ""
    //    Call Unload(Me)
    //End Sub
  }
}
