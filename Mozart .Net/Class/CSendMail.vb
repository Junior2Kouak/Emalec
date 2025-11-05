Imports System.Data.SqlClient
Imports MozartLib

Public Class CSendMail

  Private _Dest As String
  Private _CopyDest As String
  Private _BlindCopyDest As String

  Dim _Subject As String
  Dim _Message As String
  Dim _PJ As String

  Dim _bAfficheMsgSucces As Boolean
  Dim _Error As String

  Dim sNewPJForSend As String

  Dim sPathDestPJ As String

  Private Const iLimitSizePJ As Int32 = 10000000 '10 Mo

  Property Dest As String
    Get
      Return _Dest
    End Get
    Set(ByVal value As String)
      _Dest = removeExtraSemiColon(value)
    End Set
  End Property

  Property CopyDest As String
    Get
      Return _CopyDest
    End Get
    Set(ByVal value As String)
      _CopyDest = removeExtraSemiColon(value)
    End Set
  End Property

  Property BlindCopyDest As String
    Get
      Return _BlindCopyDest
    End Get
    Set(ByVal value As String)
      _BlindCopyDest = removeExtraSemiColon(value)
    End Set
  End Property

  Property Subject As String
    Get
      Return _Subject
    End Get
    Set(ByVal value As String)
      _Subject = value
    End Set
  End Property

  Property Message As String
    Get
      Return _Message
    End Get
    Set(ByVal value As String)
      _Message = value
    End Set
  End Property

  Property PJ As String
    Get
      Return _PJ
    End Get
    Set(ByVal value As String)
      _PJ = value
    End Set
  End Property

  Property bAfficheMsgSucces As Boolean
    Get
      Return _bAfficheMsgSucces
    End Get
    Set(ByVal value As Boolean)
      _bAfficheMsgSucces = value
    End Set
  End Property

  Public ReadOnly Property sError As String
    Get
      Return _Error
    End Get
  End Property

  Public Sub New()

    Dest = ""
    CopyDest = ""
    BlindCopyDest = ""
    _Subject = ""
    _Message = ""
    _PJ = ""
    _Error = ""
    _bAfficheMsgSucces = True

    If Directory.Exists(String.Format("\\{0}\PJMail\", MozartParams.NomServeur)) Then
      sPathDestPJ = String.Format("\\{0}\PJMail\", MozartParams.NomServeur)
    Else
      sPathDestPJ = ""
    End If

  End Sub

  Public Sub SendMail(Optional ByVal p_cformat As String = "")

    Dim sSQL_Requery As String
    Dim oRegUtils As New RegexUtils

    'init 
    sNewPJForSend = ""
    _Error = ""

    If _bAfficheMsgSucces Then
      If sPathDestPJ = "" Then
        MessageBox.Show("Le dossier d'envoi des pièces jointes n'est pas accessible !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        _Error = "Le dossier d'envoi des pièces jointes n'est pas accessible !"
        Exit Sub
      End If

      If Dest = "" Then
        MessageBox.Show("Il faut obligatoirement un destinataire !", "Erreur")
        _Error = "Il faut obligatoirement un destinataire !"
        Exit Sub
      End If
    End If

    Dim sListMail() As String

    If Dest.Length > 1 AndAlso Dest.Substring(Dest.Length - 1, 1) = ";" Then
      Dest = Dest.Substring(0, Dest.Length - 1)
    End If
    sListMail = Split(Trim(Dest), ";")

    For Each sEmail As String In sListMail

      If Not oRegUtils.IsValidEmail(Trim(sEmail)) And _bAfficheMsgSucces Then
        MessageBox.Show(String.Format("L'adresse mail n'est pas correcte : {0}", sEmail), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        _Error = "L'adresse mail n'est pas correcte"
        Exit Sub
      End If

    Next

    If CopyDest.Length > 1 AndAlso CopyDest.Substring(CopyDest.Length - 1, 1) = ";" Then
      CopyDest = CopyDest.Substring(0, CopyDest.Length - 1)
    End If

    If Trim(CopyDest) <> "" Then
      sListMail = Split(Trim(CopyDest), ";")
      For Each sEmail As String In sListMail
        If Not oRegUtils.IsValidEmail(Trim(sEmail)) And _bAfficheMsgSucces Then
          MessageBox.Show(String.Format("L'adresse mail n'est pas correcte : {0}", sEmail), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
          _Error = "L'adresse mail n'est pas correcte"
          Exit Sub
        End If
      Next
    End If

    If BlindCopyDest.Length > 1 AndAlso BlindCopyDest.Substring(BlindCopyDest.Length - 1, 1) = ";" Then
      BlindCopyDest = BlindCopyDest.Substring(0, BlindCopyDest.Length - 1)
    End If

    If Trim(BlindCopyDest) <> "" Then
      sListMail = Split(Trim(BlindCopyDest), ";")
      For Each sEmail As String In sListMail
        If Not oRegUtils.IsValidEmail(Trim(sEmail)) And _bAfficheMsgSucces Then
          MessageBox.Show(String.Format("L'adresse mail n'est pas correcte : {0}", sEmail), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
          _Error = "L'adresse mail n'est pas correcte"
          Exit Sub
        End If
      Next
    End If

    If _PJ <> "" Then

      If Not isValidSizePJ(_PJ) Then
        If _bAfficheMsgSucces Then
          MessageBox.Show(String.Format("Un fichier joint n'existe pas ou la taille des pièces jointes dépasse la limite autorisée : {0} Mo", iLimitSizePJ / 1000000), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
          _Error = "Un fichier joint n'existe pas ou la taille des pièces jointes dépasse la limite autorisée"
          Exit Sub
        End If
      Else
        If Not CopyFilePJ(_PJ, sNewPJForSend) And _bAfficheMsgSucces Then
          MessageBox.Show("Erreur dans la copie des pièces jointes !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
          _Error = "Erreur dans la copie des pièces jointes"
          Exit Sub
        End If
      End If

    End If

    sSQL_Requery = "EXEC msdb..sp_send_dbmail "
    sSQL_Requery += "@profile_name = 'Web" & MozartParams.NomSociete & "', "
    sSQL_Requery += "@recipients   = '" & Trim(Dest) & "', "
    If (p_cformat = "HTML") Then sSQL_Requery += "@body_format   = '" & Trim(p_cformat) & "', "
    sSQL_Requery += "@body         = '" & _Message.Replace("'", "''") & "', "
    sSQL_Requery += "@subject      = '" & _Subject.Replace("'", "''") & "', "
    sSQL_Requery += "@file_attachments = '" & sNewPJForSend.Replace("'", "''") & "' ,"
    sSQL_Requery += "@copy_recipients ='" & Trim(CopyDest) & "', "
    sSQL_Requery += "@blind_copy_recipients ='" & Trim(BlindCopyDest) & "'"

    Dim oSqlConnectSender As New CGestionSQL

    Try

      Dim sqlcmdSend As New SqlCommand(sSQL_Requery, MozartDatabase.cnxMozart)
      sqlcmdSend.ExecuteNonQuery()
      If _bAfficheMsgSucces Then
        MessageBox.Show("Le mail a été envoyé !", "Confirmation envoi", MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If

    Catch ex As Exception

      _Error = ex.Message
      If _bAfficheMsgSucces Then
          MessageBox.Show("Erreur dans SendMail() de la classe CSendMail", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Try

  End Sub

  'Remplace tous les points virgules continus en 1 seul et retourne la chaine 
  Private Function removeExtraSemiColon(pEntryString As String)
    Dim lTmp As String = Trim(pEntryString.Replace(";;", ";"))

    If lTmp = pEntryString Then
      Return lTmp
    End If

    Return removeExtraSemiColon(lTmp)
  End Function

  Private Function isValidSizePJ(ByVal p_SPJ As String) As Boolean

    Dim TabFile() As String = Split(p_SPJ, ";")

    Dim oFileInfoDet As FileInfo

    Dim i As Int32
    Dim iSizeTot As Int64 = 0

    Try

      For i = 0 To TabFile.Count - 1

        If File.Exists(TabFile(i)) Then

          oFileInfoDet = New FileInfo(TabFile(i))
          iSizeTot += oFileInfoDet.Length

        Else
          _Error = String.Format("le fichier n'existe pas dans : {0}", TabFile(i))
          MessageBox.Show(String.Format("le fichier n'existe pas dans : {0}", TabFile(i)), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
          Return False

        End If
      Next

      'si pieces jointes > 10 Mo.
      'Envoi interdit
      If iSizeTot >= iLimitSizePJ Then
        Return False
      Else
        Return True
      End If

    Catch ex As Exception

      MessageBox.Show(String.Format("Erreur CopyFilePJ() dans CSendMail : {0}", ex.Message), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return False

    End Try

  End Function

  'Cette fonction permet de copier les pj sur le dossier d envoi de sql
  Private Function CopyFilePJ(ByVal p_SPJ As String, ByRef p_SNEWPJ As String) As Boolean

    Try

      Dim TabFile() As String = Split(p_SPJ, ";")
      Dim i As Int32

      For i = 0 To TabFile.Count - 1

        If File.Exists(TabFile(i)) Then

          File.Copy(TabFile(i), sPathDestPJ & Path.GetFileName(TabFile(i)), True)

          If p_SNEWPJ.Length = 0 Then
            p_SNEWPJ = sPathDestPJ & Path.GetFileName(TabFile(i))
          Else
            p_SNEWPJ = p_SNEWPJ.Insert(p_SNEWPJ.Length, ";" + sPathDestPJ & Path.GetFileName(TabFile(i)))
          End If

        End If

      Next i

      Return True

    Catch ex As Exception

      _Error = String.Format("Erreur CopyFilePJ() dans CSendMail : {0}", ex.Message)
      MessageBox.Show(String.Format("Erreur CopyFilePJ() dans CSendMail : {0}", ex.Message), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return False

    End Try

  End Function

End Class
