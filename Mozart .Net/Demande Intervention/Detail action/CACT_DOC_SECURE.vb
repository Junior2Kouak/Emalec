Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Permissions
Imports MozartLib

Public Class CACT_DOC_SECURE

  Dim _NIDACTDOCDESCURE As Int32
  Dim _NACTNUM As Int32
  Dim _VFILE As String
  Dim _NQUICREE As Int32
  Dim _DQUICREE As String
  Dim _VFILEDESCRIPT As String
  Dim _VFILENAME As String
  Dim _NQUIMODIF As Int32
  Dim _DQUIMODIF As String

  Dim _PathActDocSecure As String

  Public ReadOnly Property NIDACTDOCDESCURE As Int32
    Get
      NIDACTDOCDESCURE = _NIDACTDOCDESCURE
    End Get
  End Property

  Public ReadOnly Property NACTNUM As Int32
    Get
      NACTNUM = _NACTNUM
    End Get
  End Property

  Public Property VFILE As String
    Get
      VFILE = _VFILE
    End Get
    Set(value As String)
      _VFILE = value
    End Set
  End Property

  Public ReadOnly Property NQUICREE As Int32
    Get
      NQUICREE = _NQUICREE
    End Get
  End Property

  Public ReadOnly Property DQUICREE As String
    Get
      DQUICREE = _DQUICREE
    End Get
  End Property

  Public Property VFILEDESCRIPT As String
    Get
      VFILEDESCRIPT = _VFILEDESCRIPT
    End Get
    Set(value As String)
      _VFILEDESCRIPT = value
    End Set
  End Property
  Public Property VFILENAME As String
    Get
      VFILENAME = _VFILENAME
    End Get
    Set(value As String)
      _VFILENAME = value
    End Set
  End Property

  Public ReadOnly Property NQUIMODIF As Int32
    Get
      NQUIMODIF = _NQUIMODIF
    End Get
  End Property
  Public ReadOnly Property DQUIMODIF As String
    Get
      DQUIMODIF = _DQUIMODIF
    End Get
  End Property
  Public ReadOnly Property PathActDocSecure As String
    Get
      PathActDocSecure = _PathActDocSecure
    End Get
  End Property

  Public Sub New(ByVal c_NIDACTDOCDESCURE As Int32, ByVal c_NACTNUM As Int32)

    _NIDACTDOCDESCURE = c_NIDACTDOCDESCURE
    _NACTNUM = c_NACTNUM

    LoadData()

  End Sub

  Public Sub LoadData()

    Dim DtRead As New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_actDocSecure_Load]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_NIDACTDOCSECURE", SqlDbType.Int).Value = _NIDACTDOCDESCURE
        sqlcmd.Parameters.Add("@P_NACTNUM", SqlDbType.Int).Value = _NACTNUM
        DtRead.Load(sqlcmd.ExecuteReader())

        For Each Dr As DataRow In DtRead.Rows
            _VFILE = Dr.Item("VFILE")
            _NQUICREE = Dr.Item("NQUICREE")
            _DQUICREE = Dr.Item("DQUICREE")
            _VFILEDESCRIPT = Dr.Item("VFILEDESCRIPT")
            _VFILENAME = Dr.Item("VFILENAME")
            _NQUIMODIF = Dr.Item("NQUIMODIF")
            _DQUIMODIF = Dr.Item("DQUIMODIF")
            _PathActDocSecure = Dr.Item("PATH_ACT_DOC_SECURE")
        Next


    End Sub

    Public Sub SaveActDocSecure(ByVal p_newfile As String)

        Dim bCopyFileOK As Boolean = False

        If GetDroitAccesPath().bDroit = True Then

            'copie du fichier si nom du fichier est différent
            If p_newfile <> _PathActDocSecure & _VFILE Then

                If File.Exists(p_newfile) = True Then

                    'on supprime l'ancien fichier
                    If File.Exists(_PathActDocSecure & _VFILE) Then File.Delete(_PathActDocSecure & _VFILE)

                    bCopyFileOK = True

                Else
                    MessageBox.Show(String.Format("le fichier source '{0}' n'existe pas", p_newfile), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If

      Dim sqlcmd As New SqlCommand("[api_sp_actDocSecure_Save]", MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.Add("@P_NIDACTDOCSECURE", SqlDbType.Int).Value = _NIDACTDOCDESCURE
            sqlcmd.Parameters("@P_NIDACTDOCSECURE").Direction = ParameterDirection.InputOutput
            sqlcmd.Parameters.Add("@P_NACTNUM", SqlDbType.Int).Value = _NACTNUM
            sqlcmd.Parameters.Add("@P_VFILE", SqlDbType.VarChar).Value = _VFILE
            sqlcmd.Parameters.Add("@P_VFILEDESCRIPT", SqlDbType.VarChar).Value = _VFILEDESCRIPT
            sqlcmd.Parameters.Add("@P_VFILENAME", SqlDbType.VarChar).Value = _VFILENAME
            sqlcmd.ExecuteNonQuery()

            _NIDACTDOCDESCURE = sqlcmd.Parameters("@P_NIDACTDOCSECURE").Value

            If bCopyFileOK = True Then

                'copy du nouveau fichier
                Dim sNewFilename As String = _NIDACTDOCDESCURE & "_" & Path.GetFileName(p_newfile)
                If File.Exists(_PathActDocSecure & sNewFilename) Then
                    MessageBox.Show(String.Format("Le fichier '{0}' n'existe pas", sNewFilename), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else
                    File.Copy(p_newfile, _PathActDocSecure & sNewFilename)
                    _VFILE = sNewFilename

          Dim sqlupdate As New SqlCommand("[api_sp_actDocSecure_UpdateFile]", MozartDatabase.cnxMozart)
          sqlupdate.CommandType = CommandType.StoredProcedure
                    sqlupdate.Parameters.Add("@P_NIDACTDOCSECURE", SqlDbType.Int).Value = _NIDACTDOCDESCURE
                    sqlupdate.Parameters.Add("@P_VFILE", SqlDbType.VarChar).Value = sNewFilename
                    sqlupdate.ExecuteNonQuery()

                End If

            End If

        Else

            MessageBox.Show(GetDroitAccesPath().sMessageErreur, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub


    Public Sub DeleteActDocSecure()

        If _NIDACTDOCDESCURE = 0 Then Exit Sub

        If GetDroitAccesPath().bDroit = True Then

      Dim sqlcmddel As New SqlCommand("[api_sp_actDocSecure_Delete]", MozartDatabase.cnxMozart)
      sqlcmddel.CommandType = CommandType.StoredProcedure
            sqlcmddel.Parameters.Add("@P_NIDACTDOCSECURE", SqlDbType.Int).Value = _NIDACTDOCDESCURE
            sqlcmddel.ExecuteNonQuery()

            'suppression du fichier
            If File.Exists(_PathActDocSecure & _VFILE) = True Then
                File.Delete(_PathActDocSecure & _VFILE)
            End If

        Else

            MessageBox.Show(GetDroitAccesPath().sMessageErreur, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Public Function GetDroitAccesPath() As CGETDROIT

        'INIT
        GetDroitAccesPath = New CGETDROIT(False, "")

        If _PathActDocSecure = "" Then GetDroitAccesPath.sMessageErreur = String.Format("Le dossier {0} n'existe pas dans les paramêtres de la société", _PathActDocSecure) : Return GetDroitAccesPath

        If Directory.Exists(_PathActDocSecure) = True Then

            For Each sFile As String In Directory.GetFiles(_PathActDocSecure)



            Next

            GetDroitAccesPath.bDroit = True

        Else
            GetDroitAccesPath.sMessageErreur = String.Format("Le dossiesr {0} n'existe pas.", _PathActDocSecure)
        End If

    End Function

End Class
