using MozartCS.Properties;
using System;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmMessageBox : Form
  {
    public string msMessage;
    public string msTitle;
    public byte mbReponse;
    public bool mbOK;

    //Public Property Let sMessage(ByVal New_Message As String)
    //    LblMessage.Caption = New_Message
    //End Property

    //Public Property Let sTitle(ByVal New_Title As String)
    //    Me.Caption = New_Title
    //End Property

    //Public Property Get Reponse() As Byte
    //    Reponse = iReponse
    //End Property

    //Public Property Let vbOK(ByVal New_bOK As Boolean)
    //    bOK = New_bOK
    //End Property

    public frmMessageBox()
    {
      InitializeComponent();
    }

    //'0:non
    //'1:oui
    //'2: annuler
    //Dim iReponse As Byte
    //Dim bOK As Boolean

    //Private Sub Form_Load()
    //    iReponse = 2
    //End Sub

      //Private Sub Form_Activate()
    //    If bOK = True Then
    //        CmdCancel.Caption = "§OK§"
    //        CmdYes.Visible = False
    //        CmdNo.Visible = False
    //    End If
    //End Sub

    private void frmMessageBox_Load(object sender, EventArgs e)
    {
      this.Text = msTitle;
      lblMessage.Text = msMessage;
      mbReponse = 2;

      if (mbOK)
      {
        cmdCancel.Text = Resources.txt_OK;
        cmdYes.Visible = false;
        cmdNo.Visible = false;
      }
    }

    //Private Sub CmdYes_Click()
    //    iReponse = 1
    //    Unload Me
    //End Sub
    private void cmdYes_Click(object sender, EventArgs e)
    {
      mbReponse = 1;
      Close();
    }

    //Private Sub CmdNo_Click()
    //    iReponse = 0
    //    Unload Me
    //End Sub
    private void cmdNo_Click(object sender, EventArgs e)
    {
      mbReponse = 0;
      Close();
    }

    //Private Sub CmdCancel_Click()
    //    iReponse = 2
    //    Unload Me
    //End Sub
    private void cmdCancel_Click(object sender, EventArgs e)
    {
      mbReponse = 2;
      Close();
    }

  }
}
