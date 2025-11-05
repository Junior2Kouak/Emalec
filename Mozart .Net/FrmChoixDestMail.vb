Imports System.Data.SqlClient
Imports MozartLib

Public Class FrmChoixDestMail

  Dim _dtListeDest As DataTable

  Dim _sSujet As String
  Dim _sMessage As String

  Dim _sType As String = ""

  Dim _sBlindCopy_Recipients As String

  Dim oPJ As CPiecesJointes

  Dim _NCLINUM As Int32 = 0

  Public _sqlcmdFinishUpdate As SqlCommand

  Public Property sqlcmdFinishUpdate As SqlCommand
    Get
      Return _sqlcmdFinishUpdate
    End Get
    Set(value As SqlCommand)
      _sqlcmdFinishUpdate = value
    End Set
  End Property

  Public Property sMessage As String
    Get
      Return _sMessage
    End Get
    Set(value As String)
      _sMessage = value
    End Set
  End Property

  Public Property sSujet As String
    Get
      Return _sSujet
    End Get
    Set(value As String)
      _sSujet = value
    End Set
  End Property

  Public Property sBlindCopy_Recipients As String
    Get
      Return _sBlindCopy_Recipients
    End Get
    Set(value As String)
      _sBlindCopy_Recipients = value
    End Set
  End Property


  Public Property NCLINUM As Int32
    Get
      Return _NCLINUM
    End Get
    Set(value As Int32)
      _NCLINUM = value
    End Set
  End Property

  Public Property sType As String
    Get
      Return _sType
    End Get
    Set(value As String)
      _sType = value
    End Set
  End Property

  Public Sub New(Optional ByVal c_CPJ As CPiecesJointes = Nothing)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    oPJ = c_CPJ

  End Sub

  Private Sub FrmChoixDestMail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'INIT
    TxtAdrMailSupp.Text = ""

    TxtSujet.Text = _sSujet
    TxtMessage.Text = _sMessage

    'on chrage la liste des destinataires
    Loaddata()

  End Sub

  Private Sub Loaddata()

    _dtListeDest = New DataTable

    Dim sReqSQL As String

    Select Case _sType
      Case "FrmRapportFm_ListeRapportFM", "FrmRapportFM_Detail"
        sReqSQL = "[api_sp_ListeDestMailByClient]"
      Case Else
        sReqSQL = "[api_sp_ListeDestMailByClient]"

    End Select


    Dim sqlcmd As New SqlCommand(sReqSQL, MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    ' TB SAMSIC CITY SPEC
    ' à véfier : Id spécifique à un client
    sqlcmd.Parameters.Add("@P_NCLINUM", SqlDbType.Int).Value = _NCLINUM
    _dtListeDest.Load(sqlcmd.ExecuteReader)

    _dtListeDest.Columns("NCOCHE").ReadOnly = False

    GCDest.DataSource = _dtListeDest

  End Sub

  Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
    Me.Close()
  End Sub

  Private Function GetListeDestCoche() As String

    Dim sListMail As String = ""

    For Each drSelect As DataRow In _dtListeDest.Rows

      If drSelect.Item("NCOCHE") = 1 Then

        sListMail = sListMail & drSelect.Item("VCCLMAIL") & ";"

      End If

    Next

    'on retire le dernier ;
    If sListMail <> "" AndAlso sListMail.Substring(sListMail.Length - 1, 1) = ";" Then sListMail = sListMail.Substring(0, sListMail.Length - 1)

    Return sListMail

  End Function

  Private Sub btnEnvoi_Click(sender As Object, e As EventArgs) Handles btnEnvoi.Click

    'tets champ libre si adresse mail correcte
    If TxtAdrMailSupp.Text <> "" AndAlso IsEmail(TxtAdrMailSupp.Text) = False Then
      MessageBox.Show("L'adresse mail n'est pas correcte !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If

    'test si personne coché et champ vide
    If _dtListeDest.Select("[NCOCHE] = 1").Count = 0 And TxtAdrMailSupp.Text = "" Then
      MessageBox.Show("Il faut un sélectionner au moins un destinataire !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If

    'test sujet vide
    If TxtSujet.Text = "" Then
      MessageBox.Show("Il faut un sujet !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If

    'test message vide
    If TxtMessage.Text = "" Then
      MessageBox.Show("Il faut un message !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If

    'envoi du mail
    Dim sListDest As String = GetListeDestCoche()

    Dim oReg As New RegexUtilities

    If TxtAdrMailSupp.Text <> "" Then

      'teste chaque adresse
      For Each sMail As String In TxtAdrMailSupp.Text.Split(";")

        If oReg.IsValidEmail(sMail) = True Then

          If sListDest = "" Then
            sListDest = sMail
          Else
            sListDest = sListDest + ";" + sMail
          End If

        Else

          MessageBox.Show("le format de l'adresse mail " & sMail & " n'est pas correcte !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

      Next


    End If

    Dim sqlSend As New SqlCommand("[api_sp_SendMailWithParam]", MozartDatabase.cnxMozart)

    sqlSend.CommandType = CommandType.StoredProcedure
    sqlSend.Parameters.Add("@p_gstrnomsociete", SqlDbType.VarChar).Value = MozartParams.NomSociete
    sqlSend.Parameters.Add("@p_lstDest", SqlDbType.VarChar).Value = sListDest
    sqlSend.Parameters.Add("@p_copydest", SqlDbType.VarChar).Value = ""
    sqlSend.Parameters.Add("@p_blindcopydest", SqlDbType.VarChar).Value = _sBlindCopy_Recipients '"info@emalec.com"
    sqlSend.Parameters.Add("@p_subject", SqlDbType.VarChar).Value = TxtSujet.Text
    sqlSend.Parameters.Add("@p_message", SqlDbType.VarChar).Value = TxtMessage.Text
    If Not oPJ Is Nothing Then sqlSend.Parameters.Add("@p_file_attachments", SqlDbType.VarChar).Value = oPJ.DtPJToString

    sqlSend.ExecuteNonQuery()

    If Not _sqlcmdFinishUpdate Is Nothing Then TraitementEnvoiMail()

    MessageBox.Show("Message envoyé avec succès", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

    Me.Close()


  End Sub

  Public Sub TraitementEnvoiMail()

    _sqlcmdFinishUpdate.ExecuteNonQuery()

  End Sub

End Class