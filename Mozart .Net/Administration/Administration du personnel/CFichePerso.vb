Imports System.Data.SqlClient
Imports MozartLib

Public Class CFichePerso

  Dim _NIDDOCRTFPERSO As Int32
  Dim _VFILENAME As String
  Dim _NPERNUM As Int32

  Dim _sNomPer As String
  Dim _sPrenomPer As String

  Dim sPathFichesPerso As String

  Dim _sDocRTFSrc As String

  Dim _sFileDocFichePerso_Old As String

  Public ReadOnly Property sFileDocFichePerso_Old As String
    Get
      Return _sFileDocFichePerso_Old
    End Get
  End Property

  Public ReadOnly Property sDocRTFSrc As String
    Get
      Return _sDocRTFSrc
    End Get
  End Property

  Public ReadOnly Property sNomPer As String
    Get
      Return _sNomPer
    End Get
  End Property

  Public ReadOnly Property sPrenomPer As String
    Get
      Return _sPrenomPer
    End Get
  End Property

  Public Sub New(ByVal c_NPERNUM As Object)

    _NPERNUM = Convert.ToInt32(c_NPERNUM)

  End Sub

  Public Sub LoadDocRTF()

    'Init
    _NIDDOCRTFPERSO = 0
    _VFILENAME = ""
    _sDocRTFSrc = ""
    _sFileDocFichePerso_Old = ""

    'chargement des path
    'LoadPathFichesPerso()
    'on charge le nom de la personne
    LoadInfoPer()

    Dim osqlcmdRead As New SqlCommand("[api_sp_OpenDocRTFPerso]", MozartDatabase.cnxMozart)

    osqlcmdRead.CommandType = CommandType.StoredProcedure
    osqlcmdRead.Parameters.Add("@p_NPERNUM", SqlDbType.Int).Value = _NPERNUM

    Dim osqldr As SqlDataReader = osqlcmdRead.ExecuteReader

    If osqldr.HasRows Then

      osqldr.Read()
      _NIDDOCRTFPERSO = osqldr.Item("NIDDOCRTFPERSO")
      _VFILENAME = osqldr.Item("VFILENAME")
      _sDocRTFSrc = osqldr.Item("VRTFTEXT")
    End If

    'Else

    '  ' FG cette gestion des fichiers perso est obsolète  31/01/22
    '  ' c'est maintenant dans la table
    '  'si pas de fiche dans la table alors on charge la fiche
    '  If File.Exists(String.Format("{0}{1}\Fiches_personnelles\Fiche_" & _NPERNUM & ".doc", sPathFichesPerso, gstrNomSociete)) Then

    '            _sFileDocFichePerso_Old = String.Format("{0}{1}\Fiches_personnelles\Fiche_" & _NPERNUM & ".doc", sPathFichesPerso, gstrNomSociete)

    '  End If

    'End If

    If osqldr.IsClosed = False Then osqldr.Close()

  End Sub

  Private Sub LoadInfoPer()

    Dim sqlcmdper As New SqlCommand(String.Format("SELECT TPER.VPERNOM, TPER.VPERPRE FROM TPER WITH (NOLOCK) WHERE TPER.NPERNUM = {0}", _NPERNUM), MozartDatabase.cnxMozart)
    sqlcmdper.CommandType = CommandType.Text
    Dim sqlRPer As SqlDataReader = sqlcmdper.ExecuteReader()

    If sqlRPer.HasRows Then

      sqlRPer.Read()
      _sNomPer = sqlRPer.Item("VPERNOM")
      _sPrenomPer = sqlRPer.Item("VPERPRE")

    End If
    sqlRPer.Close()

  End Sub

  Private Sub LoadPathFichesPerso()

    Dim osqlpathfile As New SqlCommand(String.Format("SELECT VPARVAL FROM TPAR WITH (NOLOCK) WHERE VSOCIETE = '{0}' AND VPARLIB = '{1}'", MozartParams.NomSociete, "REP_DOC_PERSONNEL"), MozartDatabase.cnxMozart)
    osqlpathfile.CommandType = CommandType.Text
    sPathFichesPerso = osqlpathfile.ExecuteScalar()

  End Sub

  Public Function DroitLectureDocRTFPersoIsOk() As Boolean

    Dim osqlcmdDroit As New SqlCommand(String.Format("SELECT COUNT(*) AS NB FROM TAUT WITH (NOLOCK) WHERE NCANNUM = 9999 AND NPERNUM = dbo.GetUserId()"), MozartDatabase.cnxMozart)

    osqlcmdDroit.CommandType = CommandType.Text

    Dim iDroit As Int16 = osqlcmdDroit.ExecuteScalar()

    If iDroit > 0 Then
      Return True
    Else
      Return False
    End If

  End Function

  Public Sub SaveDocRTF(ByVal p_sSrcRTF As String)

    Dim osqlcmdSave As New SqlCommand("[api_sp_CreateDocRTFPerso]", MozartDatabase.cnxMozart)

    osqlcmdSave.CommandType = CommandType.StoredProcedure
    osqlcmdSave.Parameters.Add("@p_NIDDOCRTFPERSO", SqlDbType.Int).Value = _NIDDOCRTFPERSO
    osqlcmdSave.Parameters.Add("@p_NPERNUM", SqlDbType.Int).Value = _NPERNUM
    osqlcmdSave.Parameters.Add("@p_VFILENAME", SqlDbType.VarChar).Value = String.Format("Fiche_{0}", _NPERNUM)
    osqlcmdSave.Parameters.Add("@p_VRTFTEXT", SqlDbType.VarChar).Value = p_sSrcRTF 'RichEditCtrlDocRTFPerso.Document.RtfText

    _NIDDOCRTFPERSO = osqlcmdSave.ExecuteScalar

  End Sub

End Class
