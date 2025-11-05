using System;
using System.Windows.Forms;
using MozartCS.Properties;

namespace MozartCS
{
  public partial class frmCommandeInterim : Form
  {
    public frmCommandeInterim()
    {
      InitializeComponent();
    }

    //Private Sub Form_Load()
    //    txtDate.Text = Date
    //    txtHeure.Text = "08:00"
    //    txtduree.Text = " heures/jours"
    //    txtTaches.Text = "- ..." & vbCrLf & "- ..."
    //    txtCompetences.Text = "- ..." & vbCrLf & "- ..."
    //End Sub
    private void frmCommandeInterim_Load(object sender, EventArgs e)
    {
      txtDate.Text = DateTime.Now.ToShortDateString();
      txtHeure.Text = "08:00";
      txtDuree.Text = "heures/jours";
      txtTaches.Text = "- ..." + "\r\n" + "- ...";
      txtCompetences.Text = "- ..." + "\r\n" + "- ...";
    }

    //Private Sub cmdValider_Click()
    //  If txtNB.Text = "" Or txtDate.Text = "" Or txtCompetences.Text = "" Or txtduree.Text = "" Or txtHeure.Text = "" Or txtTaches.Text = "" Then
    //    MsgBox "§Tous les champes sont obligatoires.§", vbExclamation + vbOKOnly
    //    Exit Sub
    //  End If
    //  frmCommandeFournisseur.vNBInterim = txtNB.Text
    //  frmCommandeFournisseur.vDTintervInterim = txtDate.Text
    //  frmCommandeFournisseur.vCompetencesInterim = txtCompetences.Text
    //  frmCommandeFournisseur.vDureeIntervInterim = txtduree.Text
    //  frmCommandeFournisseur.vHrintervInterim = txtHeure.Text
    //  frmCommandeFournisseur.vTachesInterim = txtTaches.Text
    //  Unload Me
    //End Sub
    private void cmdValider_Click(object sender, EventArgs e)
    {
      if(txtNB.Text == "" || txtDate.Text == "" || txtCompetences.Text == "" || txtDuree.Text == "" || txtHeure.Text == "" || txtTaches.Text == "")
      {
        MessageBox.Show(Resources.msg_ChampsObligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      new frmCommandeFournisseur
      {
        vNBInterim = txtNB.Text,
        vDTintervInterim = txtDate.Text,
        vCompetencesInterim = txtCompetences.Text,
        vDureeIntervInterim = txtDuree.Text,
        vHrintervInterim = txtHeure.Text,
        vTachesInterim = txtTaches.Text
      }.ShowDialog();

      Dispose();
    }
  }
}
