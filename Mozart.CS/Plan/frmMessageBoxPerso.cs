using MozartCS.Properties;
using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmMessageBoxPerso : Form
  {
    public bool mbOK = false;
    public string msTypeMessage = "";

    //Dim sTypeMessage As String
    //Dim bResponse As Boolean

    public frmMessageBoxPerso() { InitializeComponent(); }

    /* TODO --------------------------------------------------------------------------------------- */
    private void frmMessageBoxPerso_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        switch (msTypeMessage)
        {
          case "AIDE_TECH":
            LblMessage.Text = "Attention, vous allez déplacer la planification d'une action groupée.\r\nIl y a plusieurs techniciens ou sous traitants planifiés au même moment pour réaliser cette prestation.\r\nVérifier les conséquences.";
            LblQuestion.Text = "Voulez-vous continuer ?";
            //ImgIcone.Load($@"{Utils.RechercheParam("MOZART_SYSTEM_FILES")}Icones\Aide_technicien.jpg");
            ImgIcone.Image = Resources.Aide_technicien;
            break;
          case "NACELLE":
            LblMessage.Text = "Attention, cette action nécessite l'utilisation d'une nacelle et le technicien n'a pas le permis requis.";
            LblQuestion.Text = "Voulez-vous continuer ?";
            //ImgIcone.Load($@"{Utils.RechercheParam("MOZART_SYSTEM_FILES")}Icones\Nacelle.jpg");
            ImgIcone.Image = Resources.Nacelle;
            break;
          default:
            break;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()
    //
    //    'INIT
    //    bResponse = False
    //    Select Case sTypeMessage
    //        Case "AIDE_TECH"
    //        
    //            LblMessage.Caption = "Attention, vous allez déplacer la planification d'une action groupée." & vbCrLf & _
    //                                    "Il y a plusieurs techniciens ou sous traitants planifiés au même moment pour réaliser cette prestation." & vbCrLf & _
    //                                    "Vérifier les conséquences."
    //            LblQuestion.Caption = "Voulez-vous continuer ?"
    //            
    //            ' TB SAMSIC CITY PATH
    //            Set ImgIcone.Picture = LoadPicture(RechercheParam("MOZART_SYSTEM_FILES") & "Icones\Aide_technicien.jpg")
    //            ' Set ImgIcone.Picture = LoadPicture("\\SRV-VMDIR01\MOZART_SYSTEM\Icones\Aide_technicien.jpg")
    //        Case "NACELLE"
    //            LblMessage.Caption = "Attention, cette action nécessite l'utilisation d'une nacelle et le technicien n' a pas le permis requis."
    //            LblQuestion.Caption = "Voulez-vous continuer ?"
    //            
    //            ' TB SAMSIC CITY PATH
    //            Set ImgIcone.Picture = LoadPicture(RechercheParam("MOZART_SYSTEM_FILES") & "Icones\Nacelle.jpg")
    //            ' Set ImgIcone.Picture = LoadPicture("\\SRV-VMDIR01\MOZART_SYSTEM\Icones\Nacelle.jpg")
    //    End Select
    //End Sub

    /* TODO --------------------------------------------------------------------------------------- */
    private void BtnNo_Click(object sender, System.EventArgs e)
    {
      mbOK = false;
      Dispose();
    }
    //Private Sub BtnNo_Click()
    //    bResponse = False
    //    Unload Me
    //End Sub

    /* TODO --------------------------------------------------------------------------------------- */
    private void BtnYes_Click(object sender, EventArgs e)
    {
      mbOK = true;
      Dispose();
    }
    //Private Sub BtnNo_Click()
    //    bResponse = False
    //    Unload Me
    //End Sub


    //Public Property Get bOK() As Boolean
    //  bOK = bResponse
    //End Property

    //Public Property Let SetTypeMessage(ByVal New_Type As String)
    //  sTypeMessage = New_Type
    //End Property


  }
}