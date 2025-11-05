using MozartNet;
using System;
using System.Windows.Forms;

namespace MozartCS
{

  public partial class frmAdminContrat : Form
  {
    public frmAdminContrat()
    {
      InitializeComponent();
    }

    //  Private Sub Form_Load()
    //    InitBoutons Me, frmMenu
    //    VerifMOZARTNET
    //  End Sub

    private void frmAdminContrat_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);
    }

    //  Private Sub cmdFermer_Click()
    //    Unload Me
    //  End Sub
    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    private void cmdGestDomTech_Click(object sender, EventArgs e)
    {
      frmGestionDomaineTech f = new frmGestionDomaineTech();
      f.ShowDialog();
    }

    private void cmdGestCont_Click(object sender, EventArgs e)
    {
      frmGestionTypeContrat f = new frmGestionTypeContrat();
      f.ShowDialog();
    }
  }
}
