using MozartNet;
using MozartCS.Properties;
using System;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmInfosClient : Form
  {
    //Public strInfo As String
    //Public strStatut As String
    public string msInfo;
    public string msStatut;

    public frmInfosClient()
    {
      InitializeComponent();
      ModuleMain.Initboutons(this);
    }

    //Private Sub Form_Load()
    //  On Error Resume Next
    //  InitBoutons Me, frmMenu
    //  txtInfo = strInfo
    //  If strStatut = "C" Then
    //    Me.Caption = "§Informations client§"
    //  ElseIf strStatut = "S" Then
    //    Me.Caption = "§Informations site§"
    //  ElseIf strStatut = "F" Then
    //    Me.Caption = "§Informations sous-traitant§"
    //  ElseIf strStatut = "O" Then
    //    Me.Caption = "§Observations sur le sous-traitant§"
    //  End If
    //End Sub
    private void frmInfosClient_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      txtInfo.Text = msInfo;

      if (msStatut == "C")
        this.Text = Resources.txt_InfosClient;
      else if (msStatut == "S")
        this.Text = Resources.txt_IntosSite;
      else if (msStatut == "F")
        this.Text = Resources.txt_InfosST;
      else if (msStatut == "O")
        this.Text = Resources.txt_ObsSurST;
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      this.Dispose();
    }
  }
}
