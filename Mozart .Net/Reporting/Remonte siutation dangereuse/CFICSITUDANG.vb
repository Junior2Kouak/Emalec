Imports System.Data.SqlClient
Imports System.IO
Imports MozartLib

Public Class CFICSITUDANG

  Private _NIDFICSITUDANG_SERVER As Int32
  Private _NACTNUM As Int32
  Private _NPERNUM As Int32
  Private _VNOMTECH As String
  Private _NTYPESITUATION_CHK_1 As Boolean
  Private _NTYPESITUATION_CHK_2 As Boolean
  Private _NTYPESITUATION_CHK_3 As Boolean
  Private _NVICTIME_CHK_1 As Boolean
  Private _NVICTIME_CHK_2 As Boolean
  Private _NVICTIME_CHK_3 As Boolean
  Private _VVICTIME_INFO_1 As String
  Private _VVICTIME_INFO_2 As String
  Private _VVICTIME_INFO_3 As String
  Private _VFAITS_INFO As String
  Private _DFICSITUDANG_DATCREE As String
  Private _BFICSITUDANG_TOSEND As Boolean
  Private _DFICSITUDANG_SEND As String

  Private _NDINNUM As Int32
  Private _sSITE As String

  Private _dtDetailFicheSituDang As DataTable
  Private _dtDetailFicheSituDang_Photos As DataTable

#Region "PROPERTY VARIABLES"


  Public Property NIDFICSITUDANG_SERVER As Int32
    Get
      Return _NIDFICSITUDANG_SERVER
    End Get
    Set(value As Int32)
      If _NIDFICSITUDANG_SERVER = value Then
        Return
      End If
      _NIDFICSITUDANG_SERVER = value
    End Set
  End Property

  Public Property VNOMTECH As String
    Get
      Return _VNOMTECH
    End Get
    Set(value As String)
      If _VNOMTECH = value Then
        Return
      End If
      _VNOMTECH = value
    End Set

  End Property


  Public Property NTYPESITUATION_CHK_1 As Boolean
    Get
      Return _NTYPESITUATION_CHK_1
    End Get
    Set(value As Boolean)
      If _NTYPESITUATION_CHK_1 = value Then
        Return
      End If
      _NTYPESITUATION_CHK_1 = value
    End Set
  End Property

  Public Property NVICTIME_CHK_1 As Boolean
    Get
      Return _NVICTIME_CHK_1
    End Get
    Set(value As Boolean)
      If _NVICTIME_CHK_1 = value Then
        Return
      End If
      _NVICTIME_CHK_1 = value
    End Set
  End Property

  Public Property VVICTIME_INFO_1 As String
    Get
      Return _VVICTIME_INFO_1
    End Get
    Set(value As String)
      If _VVICTIME_INFO_1 = value Then
        Return
      End If
      _VVICTIME_INFO_1 = value
    End Set
  End Property

  Public Property NTYPESITUATION_CHK_2 As Boolean
    Get
      Return _NTYPESITUATION_CHK_2
    End Get
    Set(value As Boolean)
      If _NTYPESITUATION_CHK_2 = value Then
        Return
      End If
      _NTYPESITUATION_CHK_2 = value
    End Set
  End Property

  Public Property NVICTIME_CHK_2 As Boolean
    Get
      Return _NVICTIME_CHK_2
    End Get
    Set(value As Boolean)
      If _NVICTIME_CHK_2 = value Then
        Return
      End If
      _NVICTIME_CHK_2 = value
    End Set
  End Property

  Public Property VVICTIME_INFO_2 As String
    Get
      Return _VVICTIME_INFO_2
    End Get
    Set(value As String)
      If _VVICTIME_INFO_2 = value Then
        Return
      End If
      _VVICTIME_INFO_2 = value
    End Set
  End Property

  Public Property NTYPESITUATION_CHK_3 As Boolean
    Get
      Return _NTYPESITUATION_CHK_3
    End Get
    Set(value As Boolean)
      If _NTYPESITUATION_CHK_3 = value Then
        Return
      End If
      _NTYPESITUATION_CHK_3 = value
    End Set
  End Property

  Public Property NVICTIME_CHK_3 As Boolean
    Get
      Return _NVICTIME_CHK_3
    End Get
    Set(value As Boolean)
      If _NVICTIME_CHK_3 = value Then
        Return
      End If
      _NVICTIME_CHK_3 = value
    End Set
  End Property

  Public Property VVICTIME_INFO_3 As String
    Get
      Return _VVICTIME_INFO_3
    End Get
    Set(value As String)
      If _VVICTIME_INFO_3 = value Then
        Return
      End If
      _VVICTIME_INFO_3 = value
    End Set
  End Property

  Public Property VFAITS_INFO As String
    Get
      Return _VFAITS_INFO
    End Get
    Set(value As String)
      If _VFAITS_INFO = value Then
        Return
      End If
      _VFAITS_INFO = value
    End Set
  End Property

  Public Property DFICSITUDANG_DATCREE As String
    Get
      Return _DFICSITUDANG_DATCREE
    End Get
    Set(value As String)
      If _DFICSITUDANG_DATCREE = value Then
        Return
      End If
      _DFICSITUDANG_DATCREE = value
    End Set
  End Property

  Public Property BFICSITUDANG_TOSEND As Boolean
    Get
      Return _BFICSITUDANG_TOSEND
    End Get
    Set(value As Boolean)
      If _BFICSITUDANG_TOSEND = value Then
        Return
      End If
      _BFICSITUDANG_TOSEND = value
    End Set
  End Property

  Public Property DFICSITUDANG_SEND As String
    Get
      Return _DFICSITUDANG_SEND
    End Get
    Set(value As String)
      If _DFICSITUDANG_SEND = value Then
        Return
      End If
      _DFICSITUDANG_SEND = value
    End Set
  End Property

  Public Property NDINNUM As Int32
    Get
      Return _NDINNUM
    End Get
    Set(value As Int32)
      If _NDINNUM = value Then
        Return
      End If
      _NDINNUM = value
    End Set
  End Property
  Public Property NACTNUM As Int32
    Get
      Return _NACTNUM
    End Get
    Set(value As Int32)
      If _NACTNUM = value Then
        Return
      End If
      _NACTNUM = value
    End Set
  End Property

  Public Property SSITE As String
    Get
      Return _sSITE
    End Get
    Set(value As String)
      If _sSITE = value Then
        Return
      End If
      _sSITE = value
    End Set

  End Property

  Public Property NPERNUM As Int32
    Get
      Return _NPERNUM
    End Get
    Set(value As Int32)
      If _NPERNUM = value Then
        Return
      End If
      _NPERNUM = value
    End Set
  End Property


  Public Property DtDetailFicheSituDang_Photos As DataTable
    Get
      Return _dtDetailFicheSituDang_Photos
    End Get
    Set(value As DataTable)
      _dtDetailFicheSituDang_Photos = value
    End Set
  End Property

#End Region

  Public Sub New(ByVal c_NIDFICSITUDANG_SERVER As Int32, ByVal c_NACTNUM As Int32, ByVal c_NPERNUM As Int32) 'ByVal c_NIDFICSITUDANG As Int32,

    _NIDFICSITUDANG_SERVER = c_NIDFICSITUDANG_SERVER
    _NACTNUM = c_NACTNUM
    _NPERNUM = c_NPERNUM

    LoadDataFicheSituationDanger()
    LoadDataFicheSituationDangerPhotos()

  End Sub

  Public Sub LoadDataFicheSituationDanger()

    _dtDetailFicheSituDang = New DataTable

    Dim sqlcmdLoad As New SqlCommand("[api_sp_FicheSituationDangerDetail]", MozartDatabase.cnxMozart)
    sqlcmdLoad.CommandType = CommandType.StoredProcedure
        sqlcmdLoad.Parameters.Add("@P_NIDFICSITUDANG_SERVER", SqlDbType.Int).Value = _NIDFICSITUDANG_SERVER
        sqlcmdLoad.Parameters.Add("@P_NACTNUM", SqlDbType.Int).Value = _NACTNUM
        sqlcmdLoad.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = _NPERNUM
        _dtDetailFicheSituDang.Load(sqlcmdLoad.ExecuteReader)

        If _dtDetailFicheSituDang.Rows.Count > 0 Then

            For Each drLoading As DataRow In _dtDetailFicheSituDang.Rows

                _NIDFICSITUDANG_SERVER = drLoading.Item("NIDFICSITUDANG_SERVER")
                _NACTNUM = drLoading.Item("NACTNUM")
                _NPERNUM = drLoading.Item("NPERNUM")
                _VNOMTECH = drLoading.Item("VNOMTECH")
                _NTYPESITUATION_CHK_1 = drLoading.Item("NTYPESITU_CHK_1")
                _NVICTIME_CHK_1 = drLoading.Item("NVICTIME_CHK_1")
                _VVICTIME_INFO_1 = drLoading.Item("VVICTIME_INFO_1")
                _NTYPESITUATION_CHK_2 = drLoading.Item("NTYPESITU_CHK_2")
                _NVICTIME_CHK_2 = drLoading.Item("NVICTIME_CHK_2")
                _VVICTIME_INFO_2 = drLoading.Item("VVICTIME_INFO_2")
                _NTYPESITUATION_CHK_3 = drLoading.Item("NTYPESITU_CHK_3")
                _NVICTIME_CHK_3 = drLoading.Item("NVICTIME_CHK_3")
                _VVICTIME_INFO_3 = drLoading.Item("VVICTIME_INFO_3")
                _VFAITS_INFO = drLoading.Item("VFAITS_INFO")
                _DFICSITUDANG_DATCREE = drLoading.Item("DFICSITUDANG_DATCREE").ToString
                _BFICSITUDANG_TOSEND = drLoading.Item("BFICSITUDANG_TOSEND")
                _DFICSITUDANG_SEND = drLoading.Item("DFICSITUDANG_SEND").ToString
                _NDINNUM = drLoading.Item("NDINNUM")
                _sSITE = drLoading.Item("VLIEU")

            Next

        Else

            _NIDFICSITUDANG_SERVER = 0
            _NACTNUM = 0
            _NPERNUM = 0
            _VNOMTECH = ""
            _NTYPESITUATION_CHK_1 = 0
            _NVICTIME_CHK_1 = 0
            _VVICTIME_INFO_1 = ""
            _NTYPESITUATION_CHK_2 = 0
            _NVICTIME_CHK_2 = 0
            _VVICTIME_INFO_2 = ""
            _NTYPESITUATION_CHK_3 = 0
            _NVICTIME_CHK_3 = 0
            _VVICTIME_INFO_3 = ""
            _VFAITS_INFO = ""
            _DFICSITUDANG_DATCREE = Now.Date
            _BFICSITUDANG_TOSEND = 0
            _DFICSITUDANG_SEND = Nothing
            _NDINNUM = Nothing
            _sSITE = ""

        End If

    End Sub

    Public Sub LoadDataFicheSituationDangerPhotos()

        _dtDetailFicheSituDang_Photos = New DataTable

    Dim sqlcmdLoad As New SqlCommand("[api_sp_FicheSituationDanger_ListePhotos]", MozartDatabase.cnxMozart)
    sqlcmdLoad.CommandType = CommandType.StoredProcedure
        sqlcmdLoad.Parameters.Add("@P_NIDFICSITUDANG_SERVER", SqlDbType.Int).Value = _NIDFICSITUDANG_SERVER
        _dtDetailFicheSituDang_Photos.Load(sqlcmdLoad.ExecuteReader)

    End Sub

    Public Sub Addphoto(ByVal p_NomPhoto As String, ByVal p_pathfilephoto As String)

    'définir la proc stock de sauvegarde
    Dim Cmd As New SqlCommand("[api_sp_FicheSituationDanger_AddPhotos]", MozartDatabase.cnxMozart)
    Cmd.CommandType = CommandType.StoredProcedure

        Cmd.Parameters.Add("@P_NIDFICSITUDANG_PHOTO_SERVER", SqlDbType.Int).Value = 0
        Cmd.Parameters.Add("@P_NIDFICSITUDANG_SERVER", SqlDbType.Int).Value = _NIDFICSITUDANG_SERVER
        Cmd.Parameters.Add("@P_VPHOTOS_LIB", SqlDbType.VarChar).Value = p_NomPhoto
        Cmd.Parameters.Add("@P_IMG_PHOTO", SqlDbType.Image).Value = ConvertImagetoSQL(ImageResizeForImageSQL(p_pathfilephoto))
        Cmd.ExecuteNonQuery()

    End Sub

    Public Sub DelPhoto(ByVal p_NIDFICSITUDANG_PHOTO_SERVER As Int32)

    'définir la proc stock de sauvegarde
    Dim Cmd As New SqlCommand("[api_sp_FicheSituationDanger_DelPhotos]", MozartDatabase.cnxMozart)
    Cmd.CommandType = CommandType.StoredProcedure
        Cmd.Parameters.Add("@P_NIDFICSITUDANG_PHOTO_SERVER", SqlDbType.Int).Value = p_NIDFICSITUDANG_PHOTO_SERVER
        Cmd.ExecuteNonQuery()

    End Sub

    Public Sub ArchiverFicheSituDang()

    'définir la proc stock de sauvegarde
    Dim Cmd As New SqlCommand("[api_sp_FicheSituationDanger_Archiver]", MozartDatabase.cnxMozart)
    Cmd.CommandType = CommandType.StoredProcedure
        Cmd.Parameters.Add("@P_NIDFICSITUDANG_SERVER", SqlDbType.Int).Value = _NIDFICSITUDANG_SERVER
        Cmd.ExecuteNonQuery()

    End Sub

    Public Sub SaveFicheSituDang()

    Dim sqlcmdSave As New SqlCommand("[api_sp_FicSituDanger_Save]", MozartDatabase.cnxMozart)
    sqlcmdSave.CommandType = CommandType.StoredProcedure
        sqlcmdSave.Parameters.Add("@P_NIDFICSITUDANG_SERVER", SqlDbType.Int).Value = _NIDFICSITUDANG_SERVER
        sqlcmdSave.Parameters("@P_NIDFICSITUDANG_SERVER").Direction = ParameterDirection.InputOutput
        sqlcmdSave.Parameters.Add("@P_NACTNUM", SqlDbType.Int).Value = _NACTNUM
        sqlcmdSave.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = _NPERNUM
        sqlcmdSave.Parameters.Add("@P_NTYPESITU_CHK_1", SqlDbType.Int).Value = _NTYPESITUATION_CHK_1
        sqlcmdSave.Parameters.Add("@P_NVICTIME_CHK_1", SqlDbType.Int).Value = _NVICTIME_CHK_1
        sqlcmdSave.Parameters.Add("@P_VVICTIME_INFO_1", SqlDbType.VarChar).Value = _VVICTIME_INFO_1
        sqlcmdSave.Parameters.Add("@P_NTYPESITU_CHK_2", SqlDbType.Int).Value = _NTYPESITUATION_CHK_2
        sqlcmdSave.Parameters.Add("@P_NVICTIME_CHK_2", SqlDbType.Int).Value = _NVICTIME_CHK_2
        sqlcmdSave.Parameters.Add("@P_VVICTIME_INFO_2", SqlDbType.VarChar).Value = _VVICTIME_INFO_2
        sqlcmdSave.Parameters.Add("@P_NTYPESITU_CHK_3", SqlDbType.Int).Value = _NTYPESITUATION_CHK_3
        sqlcmdSave.Parameters.Add("@P_NVICTIME_CHK_3", SqlDbType.Int).Value = _NVICTIME_CHK_3
        sqlcmdSave.Parameters.Add("@P_VVICTIME_INFO_3", SqlDbType.VarChar).Value = _VVICTIME_INFO_3
        sqlcmdSave.Parameters.Add("@P_VFAITS_INFO", SqlDbType.VarChar).Value = _VFAITS_INFO
        sqlcmdSave.Parameters.Add("@P_NDINNUM", SqlDbType.Int).Value = _NDINNUM
        sqlcmdSave.Parameters.Add("@P_VNOMTECH", SqlDbType.VarChar).Value = _VNOMTECH
        sqlcmdSave.Parameters.Add("@P_VLIEU", SqlDbType.VarChar).Value = _sSITE
        sqlcmdSave.Parameters.Add("@P_DFICSITUDANG_DATCREE", SqlDbType.DateTime).Value = If(_DFICSITUDANG_DATCREE = "", Nothing, _DFICSITUDANG_DATCREE)
        sqlcmdSave.Parameters.Add("@P_BFICSITUDANG_TOSEND", SqlDbType.Bit).Value = _BFICSITUDANG_TOSEND
        sqlcmdSave.Parameters.Add("@P_DFICSITUDANG_SEND", SqlDbType.DateTime).Value = If(_DFICSITUDANG_SEND = "", Nothing, _DFICSITUDANG_SEND)
        sqlcmdSave.ExecuteNonQuery()

        _NIDFICSITUDANG_SERVER = sqlcmdSave.Parameters("@P_NIDFICSITUDANG_SERVER").Value

    End Sub

End Class
