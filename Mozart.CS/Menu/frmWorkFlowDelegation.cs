using MozartLib;
using MozartNet;
using System;
using System.Windows.Forms;

namespace MozartCS.Menu
{
  public partial class frmWorkFlowDelegation : Form
  {
    public frmWorkFlowDelegation()
    {
      InitializeComponent();
    }

    private void frmWorkFlowDelegation_Load(object sender, EventArgs e)
    {
      //  couleur et nom de la société
      BackColor = ModuleMain.Couleur(MozartParams.NomSociete);

      ModuleMain.Initboutons(this);
    }

    private void cmdDelegCmde_Click(object sender, EventArgs e)
    {
      new frmListeDelegation().ShowDialog();
      Close();
    }

    private void cmdDelegDevis_Click(object sender, EventArgs e)
    {
      new frmListeDelegationDevis().ShowDialog();
      Close();
    }
  }
}
