using MozartNet;
using System;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmGIDTCopieObjets : Form
  {
    private int mlNumClient;
    private int mlSiteOrigine;
    private string msSiteOrigine;

    public frmGIDTCopieObjets(int plNumClient, int plSiteOrigine, string sSiteOrigine)
    {
      InitializeComponent();

      mlNumClient = plNumClient;
      mlSiteOrigine = plSiteOrigine;
      msSiteOrigine = sSiteOrigine;
    }

    private void frmGIDTCopieObjets_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);
      label1.Text += msSiteOrigine;

      string sSql = $"SELECT NSITNUM, VSITNOM FROM TSIT WHERE CSITACTIF='O' AND NCLINUM = {mlNumClient} ORDER BY VSITNOM";
      ModuleData.RemplirCombo(cboSite, sSql, false);
      cboSite.ValueMember = "NSITNUM";
      cboSite.DisplayMember = "VSITNOM";
    }

    private void cmdCopier_Click(object sender, EventArgs e)
    {
      if (cboSite.SelectedIndex == 0)
      {
        return;
      }

      string sSql = $"exec api_sp_GIDT_CopieObjet {mlSiteOrigine}, {cboSite.GetItemData()}";
      string lMsg = ModuleData.ExecuteScalarString(sSql);
      MessageBox.Show(lMsg, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
  }
}
