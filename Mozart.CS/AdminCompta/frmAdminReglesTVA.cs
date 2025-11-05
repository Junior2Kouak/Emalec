using MozartNet;
using System;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmAdminReglesTVA : Form
  {
    public frmAdminReglesTVA()
    {
      InitializeComponent();
    }

    private void frmAdminReglesTVA_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);
    }
  }
}
