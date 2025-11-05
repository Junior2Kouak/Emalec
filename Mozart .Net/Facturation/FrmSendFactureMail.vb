Imports MozartLib

Public Class FrmSendFactureMail

  Private sDestinataire As String
  Private sSubj As String
  Private sMsg As String
  Private sPJ As String
  Private sNomPJ As String
  Private ID As Int32
  Private UseCloud As String  ' (0 ou 1)
  Private sNomClient As String

  Public Sub New(ByVal c_sDest As Object, ByVal c_sSubj As Object, ByVal c_sMsg As Object, ByVal c_sPJ As Object, ByVal c_ID As Object, ByVal _UseCloud As String,
                 ByVal NomF As Object, ByVal NomCli As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    sDestinataire = c_sDest.ToString
    sSubj = c_sSubj.ToString
    sMsg = c_sMsg.ToString
    sPJ = c_sPJ.ToString
    ID = Convert.ToInt32(c_ID)
    UseCloud = _UseCloud
    sNomPJ = Trim(NomF.ToString)
    sNomClient = NomCli.ToString

  End Sub

  Private Sub FrmSendFactureMail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim oFileAttach As New CMailAttachement

    If (sNomClient.ToUpper = "WELDOM" Or sNomClient.ToUpper = "RANDSTAD") Then
      ' Cas spécifique Weldom, ajouté le 19/10/2016
      oFileAttach.GeneratePDF(MozartParams.NomServeur, MozartParams.NomSociete, ID, sNomPJ + ".pdf", False, UseCloud, sPJ)
    Else
      ' Cas par défaut, exemple H&M qui existe déjà avant le 19/10/2016
      oFileAttach.GeneratePDF(MozartParams.NomServeur, MozartParams.NomSociete, ID, My.Resources.Facturation_FrmSendFactureMail_attach + ID.ToString + ".pdf", True, UseCloud, sPJ)
    End If

    If oFileAttach.bError Then
      MessageBox.Show(oFileAttach.sError, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub
    End If

    If UseCloud <> "1" Then
      Dim oMail As New CSendMail With {
        .Dest = sDestinataire,
        .BlindCopyDest = "info@emalec.com",
        .Subject = sSubj,
        .Message = sMsg,
        .PJ = IIf(sPJ <> "", oFileAttach.sOutResult, "")
      }

      oMail.SendMail()

      oFileAttach.NettoyageFile(ID)
    End If

    Close()
  End Sub

End Class