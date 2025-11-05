using MozartNet;
using System;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmAdminWeb : Form
  {
    public frmAdminWeb()
    {
      InitializeComponent();
    }

    private void frmAdminWeb_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);
    }

    private void cmdMG_Click(object sender, EventArgs e)
    {
      OpenFrmListeMessageWeb("C");
    }

    private void cmdMC_Click(object sender, EventArgs e)
    {
      OpenFrmListeMessageWeb("A");
    }

    private void cmdTech_Click(object sender, EventArgs e)
    {
      OpenFrmListeMessageWeb("T");
    }

    private void cmdCont_Click(object sender, EventArgs e)
    {
      OpenFrmListeMessageWeb("P");
    }

    private void OpenFrmListeMessageWeb(string sType)
    {
      FrmListeMessageWeb form = new FrmListeMessageWeb(sType);
      form.ShowDialog();
    }

    private void cmdTechs_Click(object sender, EventArgs e)
    {
      FrmListeMessageWebTech form = new FrmListeMessageWebTech();
      form.ShowDialog();
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      this.Dispose();
    }

		private void cmdMessageToutTech_Click(object sender, EventArgs e)
		{
			frmMessageTechnicien form = new frmMessageTechnicien();
			form.ShowDialog();

		}
	}
}
