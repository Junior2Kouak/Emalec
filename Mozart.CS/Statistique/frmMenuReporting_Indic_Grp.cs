using System;
using System.Windows.Forms;
using MozartNet;

namespace MozartCS
{
  public partial class frmMenuReporting_Indic_Grp : Form
  {
    public frmMenuReporting_Indic_Grp()
    {
      InitializeComponent();
      ModuleMain.Initboutons(this);
    }

    private void cmdIndicChaff_Click(object sender, EventArgs e)
    {
      frmMenu_Reporting_Indic_Grp_Chaff frm = new frmMenu_Reporting_Indic_Grp_Chaff();
      frm.ShowDialog();

    }

    private void cmdIndicAss_Click(object sender, EventArgs e)
    {
      
      frmStatIndicGroupeByAss frm = new frmStatIndicGroupeByAss();
      frm.ShowDialog();
    }

    private void CmdFactClient_Click(object sender, EventArgs e)
    {
      frmStatIndicGroupeFactByClient frm = new frmStatIndicGroupeFactByClient();
      frm.ShowDialog();
    }

    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      this.Dispose();
    }

    private void btnRavel_Click(object sender, EventArgs e)
    {
      frmStatRavel frm = new frmStatRavel();
      frm.sType = "CHAFF";
      frm.ShowDialog();
    }
  }
}
