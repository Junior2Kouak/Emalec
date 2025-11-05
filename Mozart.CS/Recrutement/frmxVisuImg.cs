using Microsoft.VisualBasic;
using MozartLib;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmxVisuImg : Form
  {
    public string msImage;

    public frmxVisuImg()
    {
      InitializeComponent();
    }

    private void frmxVisuImg_Load(object sender, EventArgs e)
    {
      int w = 0;
      int h = 0;

      if (Strings.UCase(Strings.Mid(msImage, Strings.InStrRev(msImage, "."))) == ".PDF")
      {
        browser.Navigate(msImage);
        Image1.Visible = false;
      }
      else
      {
        Image img = Image.FromFile(msImage);
        Image1.Image = new Bitmap(img);
        img.Dispose();

        //Image1.SizeMode = PictureBoxSizeMode.Normal;
        double ratio = Convert.ToDouble(Image1.Height) / Convert.ToDouble(Image1.Width);
        if (Image1.Height > (this.Height - 20) || Image1.Width > (this.Width - 20))
        {
          if (Image1.Height > (this.Height - 20))
          {
            h = this.Height - 20;
            w = Convert.ToInt32(h / ratio);
          }
          if (w > this.Width)
          {
            w = this.Width - 20;
            h = Convert.ToInt32(w * ratio);
          }
          Image1.SizeMode = PictureBoxSizeMode.StretchImage;
          Image1.Height = h;
          Image1.Width = w;
        }
        else
        {
          Image1.Left = (this.Width - Image1.Width) / 2;
          Image1.Top = (this.Height - Image1.Height) / 2;
        }
        browser.Visible = false;
      }
      Cursor.Current = Cursors.Default;
    }
    //VB6
    //Private Sub Form_Load()
    //  Dim w, h As Integer
    //  If UCase(Mid(mstrImage, InStrRev(mstrImage, "."))) = ".PDF" Then
    //    Browser.Navigate mstrImage
    //    Image1.Visible = False
    //  Else
    //    Image1.Picture = LoadPicture(mstrImage)
    //    Image1.Stretch = False
    //    If Image1.height > (Me.height - 100) Or Image1.width > (Me.width - 100) Then
    //      If Image1.height > (Me.height - 100) Then
    //        h = (Me.height - 100)
    //        w = Image1.width* (Me.height - 100) / Image1.height
    //     ElseIf Image1.width > (Me.width - 100) Then
    //       w = (Me.width - 100)
    //        h = Image1.height* (Me.width - 100) / Image1.width
    //     End If
    //     Image1.Stretch = True
    //     Image1.height = h
    //     Image1.width = w
    //   End If
    //   Image1.Left = (Me.width - Image1.width) / 2
    //   Image1.Top = (Me.height - Image1.height) / 2
    //   Browser.Visible = False
    // End If
    // Screen.MousePointer = vbDefault
    //End Sub

    /* OK--------------------------------------------------------------------------------------- */
    private void frmxVisuImg_Resize(object sender, EventArgs e)
    {
      browser.Width = this.Width - 13;
      browser.Height = this.Height - 67;
    }
    //VB6
    //Private Sub Form_Resize()
    //  Browser.width = Me.width - 200
    //  Browser.height = Me.height - 1000
    //End Sub

    /* OK--------------------------------------------------------------------------------------- */
    private void mnuEnregImage_Click(object sender, EventArgs e)
    {
      try
      {
        SaveFileDialog SaveFileDialog1 = new SaveFileDialog
        {
          //SaveFileDialog1.CancelError = true;
          Title = Properties.Resources.tlt_EnregistrerSous,
          FileName = $"{MozartParams.CheminUtilisateurMozart}image1.jpg"
        };

        SaveFileDialog1.ShowDialog();

        File.Copy(msImage, SaveFileDialog1.FileName, overwrite: true);
      }
      catch { }
    }
    //VB6
    //Private Sub mnuEnregImage_Click()
    //Dim fs As New FileSystemObject
    //  On Error GoTo errHandler
    //  CommonDialog1.CancelError = True
    //  CommonDialog1.DialogTitle = "§Enregistrer l'image sous ...§"
    //  CommonDialog1.FileName = gstrCheminUtilisateur & "\Mozart\image1.jpg"
    //  On Error GoTo ExitHandler
    //  CommonDialog1.ShowSave
    //  On Error GoTo errHandler
    //  fs.CopyFile mstrImage, CommonDialog1.FileName
    //ExitHandler:
    //  Exit Sub
    //errHandler:
    //  'L'utilisateur a cliqué sur Annuler
    //  ShowError "command2_Click dans " & Me.Name
    //End Sub

    /* OK--------------------------------------------------------------------------------------- */
    private void Image1_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        mnuAffichage.Show(Cursor.Position);
      }
    }
    //VB6
    //Private Sub Image1_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    //  If Button = 2 Then
    //    PopupMenu mnuAffichage
    //  End If
    //End Sub
  }
}
