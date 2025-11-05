Imports System.Runtime.InteropServices
Imports MozartLib

Public Class frmVisuDoc

  Dim s_PathUrl As String
  Dim _Type As String = ""

  Dim ClassObj As Object
  Dim sSujet As String
  Dim sMessage As String

  Dim _NCLINUM As Int32 = 0

  Public Property NCLINUM As Int32
    Get
      Return _NCLINUM
    End Get
    Set(value As Int32)
      _NCLINUM = value
    End Set
  End Property

  'Cette focntion de DLL est tuilisé pour libérer l'espace alloué dans la mémoire pour un document chargé dans un webbrowser : evéite le message 0x00000014
  <DllImport("ole32.dll")>
  Public Shared Sub CoFreeUnusedLibraries()
  End Sub

  'constructeur de la classe
  Public Sub New(ByVal c_PathUrl As String, Optional ByVal c_bVisuMail As Boolean = False, Optional ByVal c_Type As String = "", Optional ByVal c_ClassObj As Object = Nothing)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    s_PathUrl = c_PathUrl
    _Type = c_Type

    Select Case _Type
      Case "FrmRapportFm_ListeRapportFM", "FrmRapportFM_Detail"
        ClassObj = TryCast(c_ClassObj, CRapportFM)

        If ClassObj.sLangue = "EN" Then

          sSujet = "Business Review " & MozartParams.NomSociete & " from " & CDate(ClassObj.sDateDebut_This).ToShortDateString & " to " & CDate(ClassObj.sDateFin_This).ToShortDateString
          sMessage = "Hello," & vbCrLf & vbCrLf &
                                "Please find attached the Business Review from  " & CDate(ClassObj.sDateDebut_This).ToShortDateString & " to " & CDate(ClassObj.sDateFin_This).ToShortDateString & vbCrLf & vbCrLf &
                                "We wish you a nice day and remain available if you have any questions." & vbCrLf &
                                "Kind regards," & vbCrLf &
                                MozartParams.NomSociete & vbCrLf & vbCrLf &
                                "NB : This mail is sent from our server, please do not reply to this address."

        Else 'fr par défaut

          sSujet = "Rapport d'activité " & MozartParams.NomSociete & " du " & CDate(ClassObj.sDateDebut_This).ToShortDateString & " au " & CDate(ClassObj.sDateFin_This).ToShortDateString
          sMessage = "Bonjour," & vbCrLf & vbCrLf &
                                "Veuillez trouver en pièce jointe le rapport d'activité du " & CDate(ClassObj.sDateDebut_This).ToShortDateString & " au " & CDate(ClassObj.sDateFin_This).ToShortDateString & vbCrLf & vbCrLf &
                                "Vous en souhaitant bonne réception et restant à votre disposition." & vbCrLf &
                                "Cordialement," & vbCrLf &
                                MozartParams.NomSociete & vbCrLf & vbCrLf &
                                "NB : Ce mail est envoyé depuis notre serveur, veuillez ne pas répondre à cette adresse."

        End If
    End Select

    BtnSend.Visible = c_bVisuMail

  End Sub

  Private Sub frmVisuDoc_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    'Ce code permet de géré le message d'erreur 0x0000014
    WebBrowser.Visible = False
    WebBrowser.Navigate("about:blank")
    While (WebBrowser.IsBusy = True)
      Application.DoEvents()
    End While
    WebBrowser.Dispose()
    CoFreeUnusedLibraries()
  End Sub

  Private Sub frmVisuDoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'mise en forme 
    ResizeComponent()

    'affichage du document
    Dim urlstr As String
    urlstr = EncodeUrl(s_PathUrl)
    ' NL, le 16/08/16 : Mis en commentaires car pb avec EncodeUrl qui remplace les é par des #09... A voir si pb...
    'WebBrowser.Navigate(urlstr)
    WebBrowser.Navigate(s_PathUrl)

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub frmVisuDoc_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    ResizeComponent()
  End Sub

  Private Sub ResizeComponent()

    'mise en forme 
    'WebBrowser.Top = 0
    'WebBrowser.Left = 0
    WebBrowser.Width = Me.Width - WebBrowser.Left - 20
    WebBrowser.Height = Me.Height - WebBrowser.Top - 10

  End Sub

  Private Function EncodeUrl(ByVal sUrl As String) As String
    Return New UriBuilder(sUrl).Uri.AbsoluteUri
  End Function

  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
    WebBrowser.Print()
  End Sub

  Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click

    Dim oPJ As New CPiecesJointes
    oPJ.AddPJ(Path.GetFileName(s_PathUrl), s_PathUrl)

    Dim oFrmChoixDest As New FrmChoixDestMail(oPJ)
    If Not ClassObj Is Nothing Then oFrmChoixDest.sqlcmdFinishUpdate = ClassObj.SqlCmdUpdateSend.Clone
    oFrmChoixDest.NCLINUM = _NCLINUM
    oFrmChoixDest.sSujet = sSujet
    oFrmChoixDest.sMessage = sMessage
    ' TB SAMSIC CITY SPEC
    If MozartParams.NomGroupe = "EMALEC" Then
      oFrmChoixDest.sBlindCopy_Recipients = "info@emalec.com"
    End If ' TODO_TB SAMSIC CITY -> else pour samsic

    oFrmChoixDest.ShowDialog()

  End Sub

End Class