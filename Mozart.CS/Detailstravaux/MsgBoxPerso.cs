using System.Drawing;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class MsgBoxPerso : Form
  {
    public MsgBoxPerso(string message, string titre, MessageBoxIcon icon, string bouton1 = "Oui",
                       string bouton2 = "Non", bool btCancel = false)
    {
      InitializeComponent();
      this.label1.Text = message;
      this.Text = titre;
      this.btYes.Text = bouton1;
      this.btNo.Text = bouton2;
      switch (icon)
      {
        case MessageBoxIcon.Question: this.pictureBox1.Image = SystemIcons.Question.ToBitmap(); break;
        case MessageBoxIcon.Exclamation: this.pictureBox1.Image = SystemIcons.Exclamation.ToBitmap(); break;
        case MessageBoxIcon.Information:
        default:
          this.pictureBox1.Image = SystemIcons.Information.ToBitmap(); break;
      }
      this.btCancel.Visible = btCancel;
    }
  }
}
