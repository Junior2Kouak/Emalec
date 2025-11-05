Imports System.Data.SqlClient
Imports MozartLib

Public Class CPrestationSousSerie

  Dim _dtListeSousSerie As DataTable

  Dim _NPREST_SS_SERIE_ID As Int32
  Dim _VPREST_SS_SERIE_LIB As String
  Dim _BPREST_SS_SERIE_ACTIF As Boolean

  Dim _bPrestaSousSerieActif As Boolean

  Public ReadOnly Property dtListeSousSerie As DataTable
    Get
      Return _dtListeSousSerie
    End Get

  End Property

  Public Property bPrestaSousSerieActif As Boolean
    Get
      Return _bPrestaSousSerieActif
    End Get
    Set(ByVal value As Boolean)
      _bPrestaSousSerieActif = value
    End Set
  End Property

  Public Property NPREST_SS_SERIE_ID As Int32
    Get
      Return _NPREST_SS_SERIE_ID
    End Get
    Set(ByVal value As Int32)
      _NPREST_SS_SERIE_ID = value
    End Set
  End Property

  Public Property VPREST_TYPE_LIB As String
    Get
      Return _VPREST_SS_SERIE_LIB
    End Get
    Set(ByVal value As String)
      _VPREST_SS_SERIE_LIB = value
    End Set
  End Property

  Public Property BPREST_SS_SERIE_ACTIF As Boolean
    Get
      Return _BPREST_SS_SERIE_ACTIF
    End Get
    Set(ByVal value As Boolean)
      _BPREST_SS_SERIE_ACTIF = value
    End Set
  End Property

  Public Sub New()

    _bPrestaSousSerieActif = True

    LoadDataListeSousSerie()

  End Sub

  Public Sub LoadDataListeSousSerie(Optional ByVal p_withblank As Boolean = True)

    _dtListeSousSerie = New DataTable
    Dim sReq As String = ""
    If p_withblank = True Then
      sReq = String.Format("SELECT NPREST_SS_SERIE_ID, VPREST_SS_SERIE_LIB FROM TREF_PREST_SS_SERIE WITH (NOLOCK) WHERE BPREST_SS_SERIE_ACTIF = {0} UNION SELECT 0, '' ORDER BY VPREST_SS_SERIE_LIB", If(_bPrestaSousSerieActif = True, 1, 0))
    Else
      sReq = String.Format("SELECT NPREST_SS_SERIE_ID, VPREST_SS_SERIE_LIB FROM TREF_PREST_SS_SERIE WITH (NOLOCK) WHERE BPREST_SS_SERIE_ACTIF = {0} ORDER BY VPREST_SS_SERIE_LIB", If(_bPrestaSousSerieActif = True, 1, 0))
    End If

    Dim sqlcmd As New SqlCommand(sReq, MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
        _dtListeSousSerie.Load(sqlcmd.ExecuteReader())

    End Sub

    Public Sub LoadDataSousSerie(ByVal p_NPREST_SS_SERIE_ID As Int32)

        Dim dr As SqlDataReader
    Dim sqlcmd As New SqlCommand(String.Format("SELECT [NPREST_SS_SERIE_ID], [VPREST_SS_SERIE_LIB], [BPREST_SS_SERIE_ACTIF] FROM TREF_PREST_SS_SERIE WITH (NOLOCK) WHERE NPREST_SS_SERIE_ID = {0} ORDER BY VPREST_SS_SERIE_LIB", p_NPREST_SS_SERIE_ID), MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
        dr = sqlcmd.ExecuteReader()

        dr.Read()
        _NPREST_SS_SERIE_ID = dr.Item("NPREST_SS_SERIE_ID")
        _VPREST_SS_SERIE_LIB = dr.Item("VPREST_SS_SERIE_LIB")
        _BPREST_SS_SERIE_ACTIF = dr.Item("BPREST_SS_SERIE_ACTIF")

        dr.Close()

    End Sub
    Public Sub SaveSousSerie()

    Dim sqlcmd As New SqlCommand("[api_sp_SavePrestationSousSerie]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@p_NPREST_SS_SERIE_ID", SqlDbType.Int).Value = _NPREST_SS_SERIE_ID
        sqlcmd.Parameters.Add("@p_VPREST_SS_SERIE_LIB", SqlDbType.VarChar).Value = _VPREST_SS_SERIE_LIB
        sqlcmd.Parameters.Add("@p_BPREST_SS_SERIE_ACTIF", SqlDbType.Bit).Value = _BPREST_SS_SERIE_ACTIF
        sqlcmd.ExecuteNonQuery()

    End Sub
    Public Sub ArchiverSousSerie(ByVal p_NPREST_SS_SERIE_ID As Int32)

    Dim sqlcmd As New SqlCommand(String.Format("UPDATE TREF_PREST_SS_SERIE SET BPREST_SS_SERIE_ACTIF = 0 WHERE NPREST_SS_SERIE_ID = {0}", p_NPREST_SS_SERIE_ID), MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
        _dtListeSousSerie.Load(sqlcmd.ExecuteReader())

    End Sub

    Public Sub RestaurerSousSerie(ByVal p_NPREST_SS_SERIE_ID As Int32)

    Dim sqlcmd As New SqlCommand(String.Format("UPDATE TREF_PREST_SS_SERIE SET BPREST_SS_SERIE_ACTIF = 1 WHERE NPREST_SS_SERIE_ID = {0}", p_NPREST_SS_SERIE_ID), MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
        _dtListeSousSerie.Load(sqlcmd.ExecuteReader())

    End Sub

End Class
