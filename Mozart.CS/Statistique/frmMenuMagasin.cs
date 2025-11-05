using System.Windows.Forms;
using MozartNet;

namespace MozartCS
{
  public partial class frmMenuMagasin : Form
  {
    public frmMenuMagasin()
    {
      InitializeComponent();
      ModuleMain.Initboutons(this);
    }

    //Private Sub CmdDelais_Click()
    //  modMain.VerifMOZARTNET
    //  Shell gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " " & "frmStatMagasin", vbNormalFocus
    //End Sub
    private void cmdDelais_Click(object sender, System.EventArgs e)
    {
      frmStatMagasin frm = new frmStatMagasin();
      frm.ShowDialog();
    }

    //Private Sub Command1_Click()
    //  modMain.VerifMOZARTNET
    //  Shell gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " " & "frmStatMagasin2", vbNormalFocus
    //End Sub
    private void cmdDelais2_Click(object sender, System.EventArgs e)
    {
      frmStatMagasin2 frm = new frmStatMagasin2();
      frm.ShowDialog();
    }



   

    private void cmdTauxMag_Click(object sender, System.EventArgs e)
    {
      frmTauxConformite frm = new frmTauxConformite("M");
      frm.ShowDialog();
    }

    private void cmdEtalonnage_Click(object sender, System.EventArgs e)
    {
      frmStatMagasinDelaisEtalonnage frm = new frmStatMagasinDelaisEtalonnage();
      frm.ShowDialog();
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
  }
}
