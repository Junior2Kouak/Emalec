Imports System.Data.SqlClient
Imports MozartLib

Public Class CDEVISTECH

  Dim _NDEVISTECHNUM As Int32
  Dim _NPERNUM As Int32
  Dim _NCLINUM As Int32
  Dim _NSITNUM As Int32
  Dim _NDINCTE As Int32
  Dim _VCLINOM As String
  Dim _VSITNOM As String
  Dim _DDEVISTECHDATE As String
  Dim _DDEVISTECHSAISIE As String
  Dim _VDEVISTECHTITRE As String
  Dim _VDEVISTECHSUJET As String
  Dim _VDEVISTECHCONSTAT As String
  Dim _VDEVISTECHPREST As String
  Dim _VDEVISTECHFOU As String
  Dim _VDEVISTECHSECU As String
  Dim _NDEVISTECHHJ As Int32
  Dim _NDEVISTECHHP As Int32
  Dim _NDEVISTECHHN As Int32
  Dim _NDEVISTECHNB As Int32
  Dim _BDEVISTECHVALID As Boolean
  Dim _BDEVISTECHSYNC As Boolean

  Dim _dtCboClient As DataTable
  Dim _dtCboSite As DataTable
  Dim _dtCboCompte As DataTable

  ReadOnly Property NDEVISTECHNUM As Int32
    Get
      Return _NDEVISTECHNUM
    End Get
  End Property
  Property NPERNUM As Int32
    Get
      Return _NPERNUM
    End Get
    Set(value As Int32)
      _NPERNUM = value
    End Set
  End Property
  Property NCLINUM As Int32
    Get
      Return _NCLINUM
    End Get
    Set(value As Int32)
      _NCLINUM = value
    End Set
  End Property
  Property NSITNUM As Int32
    Get
      Return _NSITNUM
    End Get
    Set(value As Int32)
      _NSITNUM = value
    End Set
  End Property
  Property NDINCTE As Int32
    Get
      Return _NDINCTE
    End Get
    Set(value As Int32)
      _NDINCTE = value
    End Set
  End Property
  Property VCLINOM As String
    Get
      Return _VCLINOM
    End Get
    Set(value As String)
      _VCLINOM = value
    End Set
  End Property
  Property VSITNOM As String
    Get
      Return _VSITNOM
    End Get
    Set(value As String)
      _VSITNOM = value
    End Set
  End Property
  Property DDEVISTECHDATE As String
    Get
      Return _DDEVISTECHDATE
    End Get
    Set(value As String)
      _DDEVISTECHDATE = value
    End Set
  End Property
  Property DDEVISTECHSAISIE As String
    Get
      Return _DDEVISTECHSAISIE
    End Get
    Set(value As String)
      _DDEVISTECHSAISIE = value
    End Set
  End Property
  Property VDEVISTECHTITRE As String
    Get
      Return _VDEVISTECHTITRE
    End Get
    Set(value As String)
      _VDEVISTECHTITRE = value
    End Set
  End Property
  Property VDEVISTECHSUJET As String
    Get
      Return _VDEVISTECHSUJET
    End Get
    Set(value As String)
      _VDEVISTECHSUJET = value
    End Set
  End Property
  Property VDEVISTECHCONSTAT As String
    Get
      Return _VDEVISTECHCONSTAT
    End Get
    Set(value As String)
      _VDEVISTECHCONSTAT = value
    End Set
  End Property
  Property VDEVISTECHPREST As String
    Get
      Return _VDEVISTECHPREST
    End Get
    Set(value As String)
      _VDEVISTECHPREST = value
    End Set
  End Property
  Property VDEVISTECHFOU As String
    Get
      Return _VDEVISTECHFOU
    End Get
    Set(value As String)
      _VDEVISTECHFOU = value
    End Set
  End Property

  Property VDEVISTECHSECU As String
    Get
      Return _VDEVISTECHSECU
    End Get
    Set(value As String)
      _VDEVISTECHSECU = value
    End Set
  End Property

  Property NDEVISTECHHJ As Int32
    Get
      Return _NDEVISTECHHJ
    End Get
    Set(value As Int32)
      _NDEVISTECHHJ = value
    End Set
  End Property
  Property NDEVISTECHHP As Int32
    Get
      Return _NDEVISTECHHP
    End Get
    Set(value As Int32)
      _NDEVISTECHHP = value
    End Set
  End Property
  Property NDEVISTECHHN As Int32
    Get
      Return _NDEVISTECHHN
    End Get
    Set(value As Int32)
      _NDEVISTECHHN = value
    End Set
  End Property
  Property NDEVISTECHNB As Int32
    Get
      Return _NDEVISTECHNB
    End Get
    Set(value As Int32)
      _NDEVISTECHNB = value
    End Set
  End Property
  Property BDEVISTECHVALID As Boolean
    Get
      Return _BDEVISTECHVALID
    End Get
    Set(value As Boolean)
      _BDEVISTECHVALID = value
    End Set
  End Property
  Property BDEVISTECHSYNC As Boolean
    Get
      Return _BDEVISTECHSYNC
    End Get
    Set(value As Boolean)
      _BDEVISTECHSYNC = value
    End Set
  End Property

  Public Sub New(ByVal c_NDEVISTECHNUM As Int32, ByVal c_NPERNUM As Int32)

    _NDEVISTECHNUM = c_NDEVISTECHNUM
    _NPERNUM = c_NPERNUM

    LoadData()

  End Sub

  Public Sub LoadData()

    Dim dtReader As New DataTable

    Dim sqlcmdLoad As New SqlCommand("api_sp_DevisTech_Detail", MozartDatabase.cnxMozart)
    sqlcmdLoad.CommandType = CommandType.StoredProcedure
        sqlcmdLoad.Parameters.Add("@P_NDEVISTECHNUM", SqlDbType.Int).Value = _NDEVISTECHNUM

        dtReader.Load(sqlcmdLoad.ExecuteReader)

        If dtReader.Rows.Count > 0 Then

            _NPERNUM = dtReader.Rows(0).Item("NPERNUM")
            _NCLINUM = dtReader.Rows(0).Item("NCLINUM")
            _NSITNUM = dtReader.Rows(0).Item("NSITNUM")
            _NDINCTE = dtReader.Rows(0).Item("NDINCTE")
            _VCLINOM = dtReader.Rows(0).Item("VCLINOM")
            _VSITNOM = dtReader.Rows(0).Item("VSITNOM")
            _DDEVISTECHDATE = dtReader.Rows(0).Item("DDEVISTECHDATE")
            _DDEVISTECHSAISIE = dtReader.Rows(0).Item("DDEVISTECHSAISIE")
            _VDEVISTECHTITRE = dtReader.Rows(0).Item("VDEVISTECHTITRE")
            _VDEVISTECHSUJET = dtReader.Rows(0).Item("VDEVISTECHSUJET")
            _VDEVISTECHCONSTAT = dtReader.Rows(0).Item("VDEVISTECHCONSTAT")
            _VDEVISTECHPREST = dtReader.Rows(0).Item("VDEVISTECHPREST")
            _VDEVISTECHFOU = dtReader.Rows(0).Item("VDEVISTECHFOU")
            _NDEVISTECHHJ = dtReader.Rows(0).Item("NDEVISTECHHJ")
            _NDEVISTECHHP = dtReader.Rows(0).Item("NDEVISTECHHP")
            _NDEVISTECHHN = dtReader.Rows(0).Item("NDEVISTECHHN")
            _NDEVISTECHNB = dtReader.Rows(0).Item("NDEVISTECHNB")
            _BDEVISTECHVALID = dtReader.Rows(0).Item("BDEVISTECHVALID")
      _BDEVISTECHSYNC = dtReader.Rows(0).Item("BDEVISTECHSYNC")
      _VDEVISTECHSECU = dtReader.Rows(0).Item("VDEVISTECHSECU")

    Else

            _NDEVISTECHNUM = 0

        End If

    End Sub

    Public Function GetDataTableClient() As DataTable

        _dtCboClient = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_DevisTech_ListeComboClient]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@p_NPERNUM", SqlDbType.Int).Value = _NPERNUM
        _dtCboClient.Load(sqlcmd.ExecuteReader)

        Return _dtCboClient

    End Function

    Public Function GetDataTableSiteByClient(ByVal p_NCLINUM As Int32, ByVal p_NPERNUM As Int32) As DataTable

        _dtCboSite = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_DevisTech_ListeComboSite]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@p_NCLINUM", SqlDbType.Int).Value = p_NCLINUM
        sqlcmd.Parameters.Add("@p_NPERNUM", SqlDbType.Int).Value = p_NPERNUM
        _dtCboSite.Load(sqlcmd.ExecuteReader)

        Return _dtCboSite

    End Function

    Public Function GetDataTableCompteByClient(ByVal p_NCLINUM As Int32, ByVal p_NPERNUM As Int32) As DataTable

        _dtCboCompte = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_DevisTech_ListeComboCompte]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@p_NCLINUM", SqlDbType.Int).Value = p_NCLINUM
        sqlcmd.Parameters.Add("@p_NPERNUM", SqlDbType.Int).Value = p_NPERNUM
        _dtCboCompte.Load(sqlcmd.ExecuteReader)

        Return _dtCboCompte

    End Function

    Public Sub SaveDevisTech()

    Dim sqlcmdSave As New SqlCommand("[api_sp_DevisTech_Save]", MozartDatabase.cnxMozart)
    sqlcmdSave.CommandType = CommandType.StoredProcedure
        sqlcmdSave.Parameters.Add("@p_ndevistechnum", SqlDbType.Int).Value = _NDEVISTECHNUM
        sqlcmdSave.Parameters("@p_ndevistechnum").Direction = ParameterDirection.InputOutput
        sqlcmdSave.Parameters.Add("@p_npernum", SqlDbType.Int).Value = _NPERNUM
        sqlcmdSave.Parameters.Add("@p_nclinum", SqlDbType.Int).Value = _NCLINUM
        sqlcmdSave.Parameters.Add("@p_vclinom", SqlDbType.VarChar).Value = _VCLINOM
        sqlcmdSave.Parameters.Add("@p_nsitnum", SqlDbType.Int).Value = _NSITNUM
        sqlcmdSave.Parameters.Add("@p_vsitnom", SqlDbType.VarChar).Value = _VSITNOM
        sqlcmdSave.Parameters.Add("@p_ndincte", SqlDbType.Int).Value = _NDINCTE
        sqlcmdSave.Parameters.Add("@p_ddevistechdate", SqlDbType.DateTime).Value = _DDEVISTECHDATE
        sqlcmdSave.Parameters.Add("@p_ddevistechsaisie", SqlDbType.DateTime).Value = _DDEVISTECHSAISIE
        sqlcmdSave.Parameters.Add("@p_vdevistechtitre", SqlDbType.VarChar).Value = _VDEVISTECHTITRE
        sqlcmdSave.Parameters.Add("@p_vdevistechsujet", SqlDbType.VarChar).Value = _VDEVISTECHSUJET
        sqlcmdSave.Parameters.Add("@p_vdevistechconstat", SqlDbType.VarChar).Value = _VDEVISTECHCONSTAT
        sqlcmdSave.Parameters.Add("@p_vdevistechprest", SqlDbType.VarChar).Value = _VDEVISTECHPREST
    sqlcmdSave.Parameters.Add("@p_vdevistechfou", SqlDbType.VarChar).Value = _VDEVISTECHFOU
    sqlcmdSave.Parameters.Add("@p_ndevistechhj", SqlDbType.Int).Value = _NDEVISTECHHJ
        sqlcmdSave.Parameters.Add("@p_ndevistechhp", SqlDbType.Int).Value = _NDEVISTECHHP
        sqlcmdSave.Parameters.Add("@p_ndevistechhn", SqlDbType.Int).Value = _NDEVISTECHHN
        sqlcmdSave.Parameters.Add("@p_ndevistechnb", SqlDbType.Int).Value = _NDEVISTECHNB
        sqlcmdSave.Parameters.Add("@p_bdevistechvalid", SqlDbType.Bit).Value = _BDEVISTECHVALID
    sqlcmdSave.Parameters.Add("@p_bdevistechsync", SqlDbType.Int).Value = _BDEVISTECHSYNC
    sqlcmdSave.Parameters.Add("@p_vdevistechsecu", SqlDbType.VarChar).Value = _VDEVISTECHSECU

    sqlcmdSave.ExecuteNonQuery()

        _NDEVISTECHNUM = sqlcmdSave.Parameters("@p_ndevistechnum").Value

    End Sub

    Public Sub DeleteDevisTech()

    Dim sqlcmdSave As New SqlCommand("[api_sp_DevisTech_Delete]", MozartDatabase.cnxMozart)
    sqlcmdSave.CommandType = CommandType.StoredProcedure
        sqlcmdSave.Parameters.Add("@p_ndevistechnum", SqlDbType.Int).Value = _NDEVISTECHNUM

        sqlcmdSave.ExecuteNonQuery()

    End Sub

    Public Sub SendDevisTech()

        Dim nIDTempServer As Int32

    Dim sqlcmdSave As New SqlCommand("api_sp_TabletSynchroTDEVISTECH", MozartDatabase.cnxMozart)
    sqlcmdSave.CommandType = CommandType.StoredProcedure
        sqlcmdSave.Parameters.Add("@ndevistechnum", SqlDbType.Int).Value = _NDEVISTECHNUM
        sqlcmdSave.Parameters.Add("@npernum", SqlDbType.Int).Value = _NPERNUM
        sqlcmdSave.Parameters.Add("@nclinum", SqlDbType.Int).Value = _NCLINUM
        sqlcmdSave.Parameters.Add("@nsitnum", SqlDbType.Int).Value = _NSITNUM
        sqlcmdSave.Parameters.Add("@ndincte", SqlDbType.Int).Value = _NDINCTE
        sqlcmdSave.Parameters.Add("@vclinom", SqlDbType.VarChar).Value = _VCLINOM
        sqlcmdSave.Parameters.Add("@vsitnom", SqlDbType.VarChar).Value = _VSITNOM
        sqlcmdSave.Parameters.Add("@ddevisdate", SqlDbType.DateTime).Value = _DDEVISTECHDATE
        sqlcmdSave.Parameters.Add("@ddevissaisie", SqlDbType.DateTime).Value = _DDEVISTECHSAISIE
        sqlcmdSave.Parameters.Add("@vdevistitre", SqlDbType.VarChar).Value = _VDEVISTECHTITRE
        sqlcmdSave.Parameters.Add("@vdevissujet", SqlDbType.VarChar).Value = _VDEVISTECHSUJET
        sqlcmdSave.Parameters.Add("@vdevisconstat", SqlDbType.VarChar).Value = _VDEVISTECHCONSTAT
        sqlcmdSave.Parameters.Add("@vdevisprest", SqlDbType.VarChar).Value = _VDEVISTECHPREST
        sqlcmdSave.Parameters.Add("@vdevisfou", SqlDbType.VarChar).Value = _VDEVISTECHFOU
        sqlcmdSave.Parameters.Add("@ndevisHJ", SqlDbType.VarChar).Value = _NDEVISTECHHJ
        sqlcmdSave.Parameters.Add("@ndevisHP", SqlDbType.VarChar).Value = _NDEVISTECHHP
        sqlcmdSave.Parameters.Add("@ndevisHN", SqlDbType.VarChar).Value = _NDEVISTECHHN
        sqlcmdSave.Parameters.Add("@ndevisNB", SqlDbType.VarChar).Value = _NDEVISTECHNB
        sqlcmdSave.Parameters.Add("@nidsynchrotransat", SqlDbType.Int).Value = 0
    sqlcmdSave.Parameters.Add("@p_vdevistech_secu", SqlDbType.VarChar).Value = _VDEVISTECHSECU


    nIDTempServer = sqlcmdSave.ExecuteScalar()

        '--envoi des photos
        Dim dtDevisPhotosToSend As New DataTable
    Dim sqlListPhotosDevisTech As New SqlCommand("SELECT NDEVISTECHPHOTONUM, IDEVISTECHIMG, VDEVISTECHPHOTONOM FROM TDEVISTECHPHOTO WITH (NOLOCK) WHERE TDEVISTECHPHOTO.NDEVISTECHNUM = " & _NDEVISTECHNUM.ToString, MozartDatabase.cnxMozart)
    sqlListPhotosDevisTech.CommandType = CommandType.Text
        dtDevisPhotosToSend.Load(sqlListPhotosDevisTech.ExecuteReader)

        Dim sqlcmdsavePhotos As SqlCommand

        For Each rPhoto As DataRow In dtDevisPhotosToSend.Rows

      sqlcmdsavePhotos = New SqlCommand("api_sp_TabletSynchroTDEVISTECHPHOTO", MozartDatabase.cnxMozart)
      sqlcmdsavePhotos.CommandType = CommandType.StoredProcedure

            sqlcmdsavePhotos.Parameters.Add("@nsynchrodevistechnum", SqlDbType.Int).Value = nIDTempServer
            sqlcmdsavePhotos.Parameters.Add("@ndevistechphotonum", SqlDbType.Int).Value = rPhoto("NDEVISTECHPHOTONUM")
            sqlcmdsavePhotos.Parameters.Add("@ndevistechnum", SqlDbType.Int).Value = _NDEVISTECHNUM
            sqlcmdsavePhotos.Parameters.Add("@idevisimg", SqlDbType.Image).Value = rPhoto("IDEVISTECHIMG")
            sqlcmdsavePhotos.Parameters.Add("@vdevistechphotonom", SqlDbType.VarChar).Value = rPhoto("VDEVISTECHPHOTONOM")

            sqlcmdsavePhotos.ExecuteNonQuery()

            sqlcmdsavePhotos.Parameters.Clear()

        Next

    '--mise à jour du tableau

    Dim sqlDevisTechSend As New SqlCommand("[api_sp_DevisTech_UpdateSend]", MozartDatabase.cnxMozart)
    sqlDevisTechSend.CommandType = CommandType.StoredProcedure
        sqlDevisTechSend.Parameters.Add("@p_NDEVISTECHNUM", SqlDbType.Int).Value = _NDEVISTECHNUM

        sqlDevisTechSend.ExecuteNonQuery()

    End Sub

End Class
