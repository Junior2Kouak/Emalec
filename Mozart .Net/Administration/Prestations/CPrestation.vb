Imports System.Data.SqlClient
Imports MozartLib

Public Class CPrestation

  Dim _dtDetailPrest As DataTable
  Dim _dtDetailPrestaFou As DataTable

  Dim _dtCboType As DataTable
  Dim _dtCboSerie As DataTable
  Dim _dtCboSousSerie As DataTable

  Dim _NPRESTID As Int32
  Dim _NPRESTSERID As Int32
  Dim _NPREST_SS_SERIE_ID As Int32
  Dim _NPREST_TYPE_ID As Int32
  Dim _VPRESTUNITE As String
  Dim _NPRESTQTEMO As Decimal
  Dim _CREATEUR As String
  Dim _NPRESTIDCREE As Int32
  Dim _DPRESTCRE As String
  Dim _MODIF As String
  Dim _DPRESTMOD As String
  Dim _VPRESTLIB As String
  Dim _NPRESTFOHT As Decimal
  Dim _VPRESTCODE As String

  Property dtDetailPrestaFou As DataTable
    Get
      Return _dtDetailPrestaFou
    End Get
    Set(ByVal value As DataTable)
      _dtDetailPrestaFou = value
    End Set
  End Property

  Public Property NPRESTID As Int32
    Get
      Return _NPRESTID
    End Get
    Set(ByVal value As Int32)
      _NPRESTID = value
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

  Public Property NPREST_TYPE_ID As Int32
    Get
      Return _NPREST_TYPE_ID
    End Get
    Set(ByVal value As Int32)
      _NPREST_TYPE_ID = value
    End Set
  End Property

  Public Property NPRESTSERID As Int32
    Get
      Return _NPRESTSERID
    End Get
    Set(ByVal value As Int32)
      _NPRESTSERID = value
    End Set
  End Property

  Public Property VPRESTUNITE As String
    Get
      Return _VPRESTUNITE
    End Get
    Set(ByVal value As String)
      _VPRESTUNITE = value
    End Set
  End Property

  Public Property NPRESTQTEMO As Decimal
    Get
      Return _NPRESTQTEMO
    End Get
    Set(ByVal value As Decimal)
      _NPRESTQTEMO = value
    End Set
  End Property

  Public Property CREATEUR As String
    Get
      Return _CREATEUR
    End Get
    Set(ByVal value As String)
      _CREATEUR = value
    End Set
  End Property
  Public Property NPRESTIDCREE As Int32
    Get
      Return _NPRESTIDCREE
    End Get
    Set(ByVal value As Int32)
      _NPRESTIDCREE = value
    End Set
  End Property
  Public Property DPRESTCRE As String
    Get
      Return _DPRESTCRE
    End Get
    Set(ByVal value As String)
      _DPRESTCRE = value
    End Set
  End Property
  Public Property MODIF As String
    Get
      Return _MODIF
    End Get
    Set(ByVal value As String)
      _MODIF = value
    End Set
  End Property
  Public Property DPRESTMOD As String
    Get
      Return _DPRESTMOD
    End Get
    Set(ByVal value As String)
      _DPRESTMOD = value
    End Set
  End Property
  Public Property VPRESTLIB As String
    Get
      Return _VPRESTLIB
    End Get
    Set(ByVal value As String)
      _VPRESTLIB = value
    End Set
  End Property

  Public Property NPRESTFOHT As Decimal
    Get
      Return _NPRESTFOHT
    End Get
    Set(ByVal value As Decimal)
      _NPRESTFOHT = value
    End Set
  End Property

  Public Property VPRESTCODE As String
    Get
      Return _VPRESTCODE
    End Get
    Set(ByVal value As String)
      _VPRESTCODE = value
    End Set
  End Property

  Public Sub New(ByVal c_NPRESTID As Int32)

    _NPRESTID = c_NPRESTID

    Loaddata()
    LoadDataListeFourniture()

  End Sub

  Private Sub LoadDataCbo()

    _dtCboType = New DataTable
    _dtCboSerie = New DataTable
    _dtCboSousSerie = New DataTable

    Dim sqlcmd As New SqlCommand("SELECT NPRESTSERID,VPRESTSER FROM TPRESTSER ORDER BY VPRESTSER", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
    _dtCboSerie.Load(sqlcmd.ExecuteReader())

  End Sub

  Public Sub Loaddata()

    _dtDetailPrest = New DataTable

    Dim sqlcmd As New SqlCommand("SELECT * FROM api_v_DetailsPrestation where nprestid =" & _NPRESTID.ToString, MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
    _dtDetailPrest.Load(sqlcmd.ExecuteReader())


    If _dtDetailPrest.Rows.Count > 0 Then

      _NPRESTID = _dtDetailPrest.Rows(0).Item("NPRESTID")
      _NPRESTSERID = _dtDetailPrest.Rows(0).Item("NPRESTSERID")
      _NPREST_SS_SERIE_ID = _dtDetailPrest.Rows(0).Item("NPREST_SS_SERIE_ID")
      _NPREST_TYPE_ID = _dtDetailPrest.Rows(0).Item("NPREST_TYPE_ID")
      _VPRESTUNITE = _dtDetailPrest.Rows(0).Item("VPRESTUNITE")
      _NPRESTQTEMO = ModuleMain.ZeroIfNull(_dtDetailPrest.Rows(0).Item("NPRESTQTEMO"))
      _CREATEUR = _dtDetailPrest.Rows(0).Item("CREATEUR")
      _NPRESTIDCREE = _dtDetailPrest.Rows(0).Item("NPRESTIDCREE")
      _DPRESTCRE = _dtDetailPrest.Rows(0).Item("DPRESTCRE")
      _MODIF = _dtDetailPrest.Rows(0).Item("MODIF")
      _DPRESTMOD = _dtDetailPrest.Rows(0).Item("DPRESTMOD")
      _VPRESTLIB = _dtDetailPrest.Rows(0).Item("VPRESTLIB")
      _NPRESTFOHT = ModuleMain.ZeroIfNull(_dtDetailPrest.Rows(0).Item("NPRESTFOHT"))
      _VPRESTCODE = _dtDetailPrest.Rows(0).Item("VPRESTCODE").ToString

    End If

  End Sub

  Public Sub LoadDataListeFourniture()

    _dtDetailPrestaFou = New DataTable

    Dim sqlcmd As New SqlCommand("api_sp_RetourArticlesPrestation", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@iNumPrest", SqlDbType.Int).Value = _NPRESTID
    _dtDetailPrestaFou.Load(sqlcmd.ExecuteReader())

  End Sub

  Public Sub SavePrestation()

    Dim sqlSave As New SqlCommand("[api_sp_creationPrestation]", MozartDatabase.cnxMozart)
    sqlSave.CommandType = CommandType.StoredProcedure
    sqlSave.Parameters.Add("@iNum", SqlDbType.Int).Value = _NPRESTID
    sqlSave.Parameters("@iNum").Direction = ParameterDirection.InputOutput
    sqlSave.Parameters.Add("@iPrestSerNum", SqlDbType.Int).Value = _NPRESTSERID
    sqlSave.Parameters.Add("@Libelle", SqlDbType.VarChar).Value = _VPRESTLIB
    sqlSave.Parameters.Add("@Unite", SqlDbType.VarChar).Value = _VPRESTUNITE
    sqlSave.Parameters.Add("@QteMO", SqlDbType.Decimal).Value = _NPRESTQTEMO
    sqlSave.Parameters.Add("@FourHT", SqlDbType.Decimal).Value = _NPRESTFOHT
    sqlSave.Parameters.Add("@vprestcode", SqlDbType.VarChar).Value = _VPRESTCODE
    sqlSave.Parameters.Add("@nprest_type", SqlDbType.Int).Value = _NPREST_TYPE_ID
    sqlSave.Parameters.Add("@prest_ss_serie", SqlDbType.Int).Value = _NPREST_SS_SERIE_ID

    sqlSave.ExecuteNonQuery()

    _NPRESTID = sqlSave.Parameters("@iNum").Value

  End Sub

  Public Sub RestaurerPrestation()

    Dim sqlcmd As New SqlCommand("api_sp_ReactiverPrest", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@iNumPrest", SqlDbType.Int).Value = _NPRESTID
    sqlcmd.ExecuteNonQuery()

  End Sub

  Public Sub ArchiverPrestation()

    Dim sqlcmd As New SqlCommand("api_sp_DesactiverPrest", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@iNumPrest", SqlDbType.Int).Value = _NPRESTID
    sqlcmd.ExecuteNonQuery()

  End Sub

  Public Sub SaveFourniturePrestation(Optional ByVal p_ModeCopy As Boolean = False)

    If p_ModeCopy = True Then

      If _dtDetailPrestaFou IsNot Nothing Then
        'api_sp_RetourArticlesPrestation
        _dtDetailPrestaFou.AcceptChanges()
        Dim dtChangesAddedAndModif As DataTable = _dtDetailPrestaFou
        If dtChangesAddedAndModif IsNot Nothing Then
          For Each drInsertUpdate As DataRow In dtChangesAddedAndModif.Rows
            InsertSaveFourniture(drInsertUpdate.Item("NumArticle"), drInsertUpdate.Item("Quantite"))
          Next
        End If
      End If


    Else

      'api_sp_RetourArticlesPrestation
      Dim dtChangesAddedAndModif As DataTable = _dtDetailPrestaFou.GetChanges(DataRowState.Added + DataRowState.Modified)
      If dtChangesAddedAndModif IsNot Nothing Then
        For Each drInsertUpdate As DataRow In dtChangesAddedAndModif.Rows
          InsertSaveFourniture(drInsertUpdate.Item("NumArticle"), drInsertUpdate.Item("Quantite"))
        Next
      End If

      Dim dtDelete As DataTable = _dtDetailPrestaFou.GetChanges(DataRowState.Deleted)
      If dtDelete IsNot Nothing Then
        dtDelete.RejectChanges()
        For Each drDelete As DataRow In dtDelete.Rows
          DeleteFourniture(drDelete.Item("NumArticle"))
        Next
      End If

    End If

  End Sub

  Private Sub InsertSaveFourniture(ByVal P_NFOUNUM As Int32, ByVal P_NQTE As Decimal)

    Dim sqlcmdInsert As New SqlCommand("api_sp_CreationLignePrestArt", MozartDatabase.cnxMozart)
    sqlcmdInsert.CommandType = CommandType.StoredProcedure
    sqlcmdInsert.Parameters.Add("@iPrestNum", SqlDbType.Int).Value = _NPRESTID
    sqlcmdInsert.Parameters.Add("@iFouNum", SqlDbType.Int).Value = P_NFOUNUM
    sqlcmdInsert.Parameters.Add("@nQte", SqlDbType.Decimal).Value = P_NQTE
    sqlcmdInsert.ExecuteNonQuery()

  End Sub

  Private Sub DeleteFourniture(ByVal P_NFOUNUM As Int32)

    Dim sqlcmdDelete As New SqlCommand("[api_sp_SupprimerLignePrestArt]", MozartDatabase.cnxMozart)
    sqlcmdDelete.CommandType = CommandType.StoredProcedure
    sqlcmdDelete.Parameters.Add("@iPrestNum", SqlDbType.Int).Value = _NPRESTID
    sqlcmdDelete.Parameters.Add("@iFouNum", SqlDbType.Int).Value = P_NFOUNUM
    sqlcmdDelete.ExecuteNonQuery()

  End Sub

End Class
