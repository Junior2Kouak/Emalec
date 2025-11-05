Imports System.Data.SqlClient
Imports MozartLib

Public Class CPrestationSerie

  Dim _DtListeSerie As DataTable

  Dim _NPRESTSERID As Int32
  Dim _VPRESTSER As String
  Dim _NPRESTSERMOHT As Decimal
  Dim _CPRESTSER_ACTIF As Boolean
  Dim _NPRESTSERCOEFNUIT As Decimal

  Dim _bPrestaSerieActif As Boolean

  Public ReadOnly Property DtListeSerie As DataTable
    Get
      Return _DtListeSerie
    End Get

  End Property

  Public Property NPRESTSERID As Int32
    Get
      Return _NPRESTSERID
    End Get
    Set(ByVal value As Int32)
      _NPRESTSERID = value
    End Set
  End Property

  Public Property VPRESTSER As String
    Get
      Return _VPRESTSER
    End Get
    Set(ByVal value As String)
      _VPRESTSER = value
    End Set
  End Property

  Public Property NPRESTSERMOHT As Decimal
    Get
      Return _NPRESTSERMOHT
    End Get
    Set(ByVal value As Decimal)
      _NPRESTSERMOHT = value
    End Set
  End Property

  Public Property CPRESTSER_ACTIF As Boolean
    Get
      Return _CPRESTSER_ACTIF
    End Get
    Set(ByVal value As Boolean)
      _CPRESTSER_ACTIF = value
    End Set
  End Property

  Public Property bPrestaSerieActif As Boolean
    Get
      Return _bPrestaSerieActif
    End Get
    Set(ByVal value As Boolean)
      _bPrestaSerieActif = value
    End Set
  End Property

  Public Property NPRESTSERCOEFNUIT As Decimal
    Get
      Return _NPRESTSERCOEFNUIT
    End Get
    Set(ByVal value As Decimal)
      _NPRESTSERCOEFNUIT = value
    End Set
  End Property

  Public Sub New()

    _bPrestaSerieActif = True
    LoadDataListeSerie()

  End Sub

  Public Sub LoadDataSerie(ByVal p_NPRESTSERID As Int32)

    Dim dr As SqlDataReader
    Dim sqlcmd As New SqlCommand(String.Format("SELECT NPRESTSERID, VPRESTSER, NPRESTSERMOHT, CPRESTSER_ACTIF, ISNULL(NPRESTSERCOEFNUIT, 2) AS NPRESTSERCOEFNUIT FROM TPRESTSER WITH (NOLOCK) WHERE NPRESTID = {0}", p_NPRESTSERID), MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
        dr = sqlcmd.ExecuteReader()

        dr.Read()
        _NPRESTSERID = dr.Item("NPRESTSERID")
        _VPRESTSER = dr.Item("VPRESTSER")
        _NPRESTSERMOHT = dr.Item("NPRESTSERMOHT")
        _CPRESTSER_ACTIF = dr.Item("CPRESTSER_ACTIF")
        _NPRESTSERCOEFNUIT = dr.Item("NPRESTSERCOEFNUIT")

        dr.Close()

    End Sub

    Public Sub LoadDataListeSerie(Optional ByVal p_withblank As Boolean = True)

        _DtListeSerie = New DataTable

        Dim sReq As String = ""
        If p_withblank = True Then
            sReq = String.Format("SELECT NPRESTSERID, VPRESTSER, NPRESTSERMOHT, ISNULL(NPRESTSERCOEFNUIT, 2) AS NPRESTSERCOEFNUIT FROM TPRESTSER WITH (NOLOCK) WHERE CPRESTSER_ACTIF = {0} UNION SELECT 0, '', 0, 0 ORDER BY VPRESTSER", If(_bPrestaSerieActif = True, 1, 0))
        Else
            sReq = String.Format("SELECT NPRESTSERID, VPRESTSER, NPRESTSERMOHT, ISNULL(NPRESTSERCOEFNUIT, 2) AS NPRESTSERCOEFNUIT FROM TPRESTSER WITH (NOLOCK) WHERE CPRESTSER_ACTIF = {0} ORDER BY VPRESTSER", If(_bPrestaSerieActif = True, 1, 0))
        End If

    Dim sqlcmd As New SqlCommand(sReq, MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
        _DtListeSerie.Load(sqlcmd.ExecuteReader())

    End Sub

    Public Sub SaveSerie()

    Dim sqlcmd As New SqlCommand("[api_sp_SavePrestationSerie]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@p_NPRESTSERID", SqlDbType.Int).Value = _NPRESTSERID
        sqlcmd.Parameters.Add("@p_VPRESTSER", SqlDbType.VarChar).Value = _VPRESTSER
        sqlcmd.Parameters.Add("@p_NPRESTSERMOHT", SqlDbType.Int).Value = _NPRESTSERMOHT
        sqlcmd.Parameters.Add("@p_CPRESTSER_ACTIF", SqlDbType.Bit).Value = If(_CPRESTSER_ACTIF = True, 1, 0)
        sqlcmd.ExecuteNonQuery()

    End Sub

    Public Sub ArchiverSerie(ByVal p_NPRESTSERID As Int32)

    Dim sqlcmd As New SqlCommand(String.Format("UPDATE TPRESTSER SET CPRESTSER_ACTIF = 0 WHERE NPRESTSERID = {0}", p_NPRESTSERID), MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
        _DtListeSerie.Load(sqlcmd.ExecuteReader())

    End Sub

    Public Sub RestaurerSerie(ByVal p_NPRESTSERID As Int32)

    Dim sqlcmd As New SqlCommand(String.Format("UPDATE TPRESTSER SET CPRESTSER_ACTIF = 1 WHERE NPRESTSERID = {0}", p_NPRESTSERID), MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
        _DtListeSerie.Load(sqlcmd.ExecuteReader())

    End Sub

    Public Function GetSeriePrixMo(ByVal p_NPRESTSERID As Int32) As Decimal

        If p_NPRESTSERID = 0 Then Return 0

        If _DtListeSerie.Select(String.Format("NPRESTSERID = {0}", p_NPRESTSERID)).Count = 0 Then Return 0

        Return _DtListeSerie.Select(String.Format("NPRESTSERID = {0}", p_NPRESTSERID))(0).Item("NPRESTSERMOHT")

    End Function

    Public Function GetSerieCoefNuit(ByVal p_NPRESTSERID As Int32) As Decimal

        If p_NPRESTSERID = 0 Then Return 1

        If _DtListeSerie.Select(String.Format("NPRESTSERID = {0}", p_NPRESTSERID)).Count = 0 Then Return 0

        Return _DtListeSerie.Select(String.Format("NPRESTSERID = {0}", p_NPRESTSERID))(0).Item("NPRESTSERCOEFNUIT")

    End Function

End Class
