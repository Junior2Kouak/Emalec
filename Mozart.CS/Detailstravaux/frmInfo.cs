using System;
using System.Windows.Forms;
using MozartCS.Properties;

namespace MozartCS
{
  public partial class frmInfo : Form
  {
    public string msType;
    public string msInfo;

    public System.Diagnostics.Process p = new System.Diagnostics.Process();

    public frmInfo()
    {
      InitializeComponent();

    }
  
    private void frmInfo_Load(object sender, EventArgs e)
    {
      if (msType == "Site")
        this.Text = Resources.tlt_InfoSite;
      else
        this.Text = Resources.tlt_InfoClient;

      txtInfo.Text = msInfo;
    }

		private void txtInfo_LinkClicked(object sender, LinkClickedEventArgs e)
		{
      p = System.Diagnostics.Process.Start("msedge.exe", e.LinkText);
    }
	}
}
