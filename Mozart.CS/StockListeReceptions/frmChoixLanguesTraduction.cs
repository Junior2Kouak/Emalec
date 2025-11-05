using MozartNet;
using MozartLib;
using System;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmChoixLanguesTraduction : Form
  {
    //Public slgFrom As String
    //Public slgTo As String
    public string msLgFrom;
    public string msLgTo;

    public frmChoixLanguesTraduction()
    {
      InitializeComponent();
    }

    //Private Sub cmdValider_Click()
    //  If lstLgFrom.Text = "" Then Exit Sub
    //  If lstLgTo.Text = "" Then Exit Sub
    //  If lstLgFrom.Text = lstLgTo.Text Then Exit Sub
    //  slgFrom = Mid(lstLgFrom.Text, InStr(lstLgFrom.Text, "(") + 1, 2)
    //  slgTo = Mid(lstLgTo.Text, InStr(lstLgTo.Text, "(") + 1, 2)
    //  Unload Me
    //End Sub

    private void cmdValider_Click(object sender, EventArgs e)
    {
      if (lstLgFrom.Text == "" || lstLgTo.Text == "" || lstLgFrom.Text == lstLgTo.Text)
        return;

      msLgFrom = lstLgFrom.Text.Substring(lstLgFrom.Text.IndexOf("(") + 1, 2);
      msLgTo = lstLgTo.Text.Substring(lstLgTo.Text.IndexOf("(") + 1, 2);
      Dispose();
    }

    //Private Sub Form_Load()
    //  Select Case gstrLangue
    //  Case "FR"
    //    lstLgFrom.ListIndex = 0
    //  Case "EN"
    //    lstLgFrom.ListIndex = 1
    //  Case "ES"
    //    lstLgFrom.ListIndex = 2
    //  Case "NL"
    //    lstLgFrom.ListIndex = 3
    //  Case "DE"
    //    lstLgFrom.ListIndex = 4
    //  Case "IT"
    //    lstLgFrom.ListIndex = 5
    //  End Select
    //End Sub

    private void frmChoixLanguesTraduction_Load(object sender, EventArgs e)
    {
      switch (MozartParams.Langue)
      {
        case "FR":
          lstLgFrom.SelectedIndex = 0;
          break;
        case "EN":
          lstLgFrom.SelectedIndex = 1;
          break;
        case "ES":
          lstLgFrom.SelectedIndex = 2;
          break;
        case "NL":
          lstLgFrom.SelectedIndex = 3;
          break;
        case "DE":
          lstLgFrom.SelectedIndex = 4;
          break;
        case "IT":
          lstLgFrom.SelectedIndex = 5;
          break;
      }
    }

    //Private Sub cmdFermer_Click()
    //  slgFrom = ""
    //  slgTo = ""
    //  Unload Me
    //End Sub

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      msLgFrom = "";
      msLgTo = "";
      Dispose();
    }

  }
}
