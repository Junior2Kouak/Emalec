Imports System.Data.SqlClient
Imports MozartLib

Public Class CFicheRecrutement

  Dim _NIDDOCRTFRECRU As Int32
  Dim _VFILENAME As String
  Dim _NRECRUNUM As Int32

  Dim _sNomPer As String
  Dim _sPrenomPer As String

  Dim sPathFichesRecru As String

  Dim _sDocRTFSrc As String

  Dim _sFileDocFicheRecru_Old As String

  Public ReadOnly Property sFileDocFicheRecru_Old As String
    Get
      Return _sFileDocFicheRecru_Old
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

  Public Sub New(ByVal c_NRECRUNUM As Object)

    _NRECRUNUM = Convert.ToInt32(c_NRECRUNUM)

  End Sub

  Public Sub LoadDocRTF()

    'Init
    _NIDDOCRTFRECRU = 0
    _VFILENAME = ""
    _sDocRTFSrc = ""
    _sFileDocFicheRecru_Old = ""

    _sNomPer = ""
    _sPrenomPer = ""

    'chargement des path
    'LoadPathFichesRecru()
    'on charge le nom de la personne
    LoadInfoPer()

    Dim osqlcmdRead As New SqlCommand("[api_sp_OpenDocRTFRecru]", MozartDatabase.cnxMozart)

    osqlcmdRead.CommandType = CommandType.StoredProcedure
    osqlcmdRead.Parameters.Add("@p_NRECRUNUM", SqlDbType.Int).Value = _NRECRUNUM

    Dim osqldr As SqlDataReader = osqlcmdRead.ExecuteReader

    If osqldr.HasRows Then

      osqldr.Read()
      _NIDDOCRTFRECRU = osqldr.Item("NIDDOCRTFRECRU")
      _VFILENAME = osqldr.Item("VFILENAME")
      _sDocRTFSrc = osqldr.Item("VRTFTEXT")
    End If

    If osqldr.IsClosed = False Then osqldr.Close()

  End Sub

  Private Sub LoadInfoPer()

    Dim sqlcmdper As New SqlCommand(String.Format("SELECT TRECRU.VPERNOM, TRECRU.VPERPRE FROM TRECRU WITH (NOLOCK) WHERE TRECRU.NPERNUM = {0}", _NRECRUNUM), MozartDatabase.cnxMozart)
    sqlcmdper.CommandType = CommandType.Text
    Dim sqlRPer As SqlDataReader = sqlcmdper.ExecuteReader()

    If sqlRPer.HasRows Then

      sqlRPer.Read()
      _sNomPer = sqlRPer.Item("VPERNOM")
      _sPrenomPer = sqlRPer.Item("VPERPRE")

    End If
    sqlRPer.Close()

  End Sub

  Private Sub LoadPathFichesRecru()

    Dim osqlpathfile As New SqlCommand(String.Format("SELECT VPARVAL FROM TPAR WITH (NOLOCK) WHERE VSOCIETE = '{0}' AND VPARLIB = '{1}'", MozartParams.NomSociete, "REP_DOC_PERSONNEL"), MozartDatabase.cnxMozart)
    osqlpathfile.CommandType = CommandType.Text
    sPathFichesRecru = osqlpathfile.ExecuteScalar()

  End Sub

  Public Sub SaveDocRTF(ByVal p_sSrcRTF As String)

    Dim osqlcmdSave As New SqlCommand("[api_sp_CreateDocRTFRecru]", MozartDatabase.cnxMozart)

    osqlcmdSave.CommandType = CommandType.StoredProcedure
    osqlcmdSave.Parameters.Add("@p_NIDDOCRTFRECRU", SqlDbType.Int).Value = _NIDDOCRTFRECRU
    osqlcmdSave.Parameters.Add("@p_NRECRUNUM", SqlDbType.Int).Value = _NRECRUNUM
    osqlcmdSave.Parameters.Add("@p_VFILENAME", SqlDbType.VarChar).Value = String.Format("FicheRecru_{0}", _NRECRUNUM)
    osqlcmdSave.Parameters.Add("@p_VRTFTEXT", SqlDbType.VarChar).Value = p_sSrcRTF 'RichEditCtrlDocRTFPerso.Document.RtfText

    _NIDDOCRTFRECRU = osqlcmdSave.ExecuteScalar

  End Sub

End Class
