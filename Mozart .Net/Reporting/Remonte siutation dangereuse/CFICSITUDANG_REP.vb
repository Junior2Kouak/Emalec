Imports System.Data.SqlClient
Imports MozartLib

Public Class CFICSITUDANG_REP

  Private _NIDFICSITUDANG_REP As Int32
  Private _NIDFICSITUDANG_SERVER As Int32
  Private _CHK_HUMAINE As Boolean
  Private _CHK_CONSIGNE As Boolean
  Private _CHK_ORGANISATION As Boolean
  Private _CHK_FORMATION As Boolean
  Private _CHK_MATERIEL As Boolean
  Private _CHK_MILIEU As Boolean
  Private _CHK_AUTRE As Boolean
  Private _VAUTRES As String
  Private _NCOTATION As Int32
  Private _NRISQUE As Int32
  Private _VREPONSE As String
  Private _DATE_REP_CREE As String
  Private _BVALID_REP As Boolean
  Private _NQUIREP As Int32
  Private _VQUIREP As String
  Private _VQUIFONC As String
  Private _DTECH_LU As String
  Private _DREPVALID As String

  Private _dtDetailFicheSituDang_Rep As DataTable
  Private _dtDetailCotationSitu As DataTable

#Region "PROPERTY VARIABLES"
  Public Property NIDFICSITUDANG_REP As Int32
    Get
      Return _NIDFICSITUDANG_REP
    End Get
    Set(value As Int32)
      If _NIDFICSITUDANG_REP = value Then
        Return
      End If
      _NIDFICSITUDANG_REP = value
    End Set
  End Property
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

  Public Property CHK_HUMAINE As Boolean
    Get
      Return _CHK_HUMAINE
    End Get
    Set(value As Boolean)
      If _CHK_HUMAINE = value Then
        Return
      End If
      _CHK_HUMAINE = value
    End Set
  End Property

  Public Property CHK_CONSIGNE As Boolean
    Get
      Return _CHK_CONSIGNE
    End Get
    Set(value As Boolean)
      If _CHK_CONSIGNE = value Then
        Return
      End If
      _CHK_CONSIGNE = value
    End Set
  End Property

  Public Property CHK_ORGANISATION As Boolean
    Get
      Return _CHK_ORGANISATION
    End Get
    Set(value As Boolean)
      If _CHK_ORGANISATION = value Then
        Return
      End If
      _CHK_ORGANISATION = value
    End Set
  End Property

  Public Property CHK_FORMATION As Boolean
    Get
      Return _CHK_FORMATION
    End Get
    Set(value As Boolean)
      If _CHK_FORMATION = value Then
        Return
      End If
      _CHK_FORMATION = value
    End Set
  End Property

  Public Property CHK_MATERIEL As Boolean
    Get
      Return _CHK_MATERIEL
    End Get
    Set(value As Boolean)
      If _CHK_MATERIEL = value Then
        Return
      End If
      _CHK_MATERIEL = value
    End Set
  End Property

  Public Property CHK_MILIEU As Boolean
    Get
      Return _CHK_MILIEU
    End Get
    Set(value As Boolean)
      If _CHK_MILIEU = value Then
        Return
      End If
      _CHK_MILIEU = value
    End Set
  End Property

  Public Property CHK_AUTRE As Boolean
    Get
      Return _CHK_AUTRE
    End Get
    Set(value As Boolean)
      If _CHK_AUTRE = value Then
        Return
      End If
      _CHK_AUTRE = value
    End Set
  End Property

  Public Property VAUTRES As String
    Get
      Return _VAUTRES
    End Get
    Set(value As String)
      If _VAUTRES = value Then
        Return
      End If
      _VAUTRES = value
    End Set
  End Property

  Public Property NCOTATION As String
    Get
      Return _NCOTATION
    End Get
    Set(value As String)
      If _NCOTATION = value Then
        Return
      End If
      _NCOTATION = value
    End Set
  End Property

  Public Property NRISQUE As String
    Get
      Return _NRISQUE
    End Get
    Set(value As String)
      If _NRISQUE = value Then
        Return
      End If
      _NRISQUE = value
    End Set
  End Property

  Public Property VREPONSE As String
    Get
      Return _VREPONSE
    End Get
    Set(value As String)
      If _VREPONSE = value Then
        Return
      End If
      _VREPONSE = value
    End Set
  End Property

  Public ReadOnly Property DATE_REP_CREE As String
    Get
      Return _DATE_REP_CREE
    End Get
  End Property

  Public Property BVALID_REP As Boolean
    Get
      Return _BVALID_REP
    End Get
    Set(value As Boolean)
      If _BVALID_REP = value Then
        Return
      End If
      _BVALID_REP = value
    End Set
  End Property

  Public ReadOnly Property NQUIREP As Int32
    Get
      Return _NQUIREP
    End Get
  End Property

  Public ReadOnly Property VQUIREP As String
    Get
      Return _VQUIREP
    End Get
  End Property

  Public ReadOnly Property VQUIFONC As String
    Get
      Return _VQUIFONC
    End Get
  End Property

  Public ReadOnly Property DTECH_LU As String
    Get
      Return _DTECH_LU
    End Get
  End Property

  Public Property DREPVALID As String
    Get
      Return _DREPVALID
    End Get
    Set(value As String)
      If _DREPVALID = value Then
        Return
      End If
      _DREPVALID = value
    End Set
  End Property
  Public ReadOnly Property dtDetailCotationSitu As DataTable
    Get
      Return _dtDetailCotationSitu
    End Get
  End Property

#End Region

  Public Sub New(ByVal c_NIDFICSITUDANG_REP As Int32, ByVal c_NIDFICSITUDANG_SERVER As Int32)

    _NIDFICSITUDANG_REP = c_NIDFICSITUDANG_REP
    _NIDFICSITUDANG_SERVER = c_NIDFICSITUDANG_SERVER

    LoadDataFicheSituationDanger_Reponse()

  End Sub

  Public Sub LoadDataFicheSituationDanger_Reponse()

    _dtDetailFicheSituDang_Rep = New DataTable

    Dim sqlcmdLoad As New SqlCommand("[api_sp_FicheSituationDanger_Reponse_Detail]", MozartDatabase.cnxMozart)
    sqlcmdLoad.CommandType = CommandType.StoredProcedure
    sqlcmdLoad.Parameters.Add("@P_NIDFICSITUDANG_REP", SqlDbType.Int).Value = _NIDFICSITUDANG_REP
    sqlcmdLoad.Parameters.Add("@P_NIDFICSITUDANG_SERVER", SqlDbType.Int).Value = _NIDFICSITUDANG_SERVER
    _dtDetailFicheSituDang_Rep.Load(sqlcmdLoad.ExecuteReader)

    If _dtDetailFicheSituDang_Rep.Rows.Count > 0 Then

      For Each drLoading As DataRow In _dtDetailFicheSituDang_Rep.Rows

        _NIDFICSITUDANG_REP = drLoading.Item("NIDFICSITUDANG_REP")
        _NIDFICSITUDANG_SERVER = drLoading.Item("NIDFICSITUDANG_SERVER")
        _CHK_HUMAINE = drLoading.Item("BCHKHUMA")
        _CHK_CONSIGNE = drLoading.Item("BCHKCONS")
        _CHK_ORGANISATION = drLoading.Item("BCHKORGA")
        _CHK_FORMATION = drLoading.Item("BCHKFORM")
        _CHK_MATERIEL = drLoading.Item("BCHKMATE")
        _CHK_MILIEU = drLoading.Item("BCHKMILI")
        _CHK_AUTRE = drLoading.Item("BCHKAUTRES")
        _VAUTRES = drLoading.Item("VAUTRES")
        _NCOTATION = drLoading.Item("NCOTATION")
        _VREPONSE = drLoading.Item("VREPONSE")
        _DATE_REP_CREE = drLoading.Item("DREPCREE")
        _BVALID_REP = drLoading.Item("BVALID_REP")
        _NQUIREP = drLoading.Item("NQUIREP")
        _VQUIREP = drLoading.Item("VQUIREP")
        _VQUIFONC = drLoading.Item("VQUIFONC")
        _DTECH_LU = drLoading.Item("DTECH_LU").ToString
        _DREPVALID = drLoading.Item("DREPVALID").ToString
        _NRISQUE = drLoading.Item("NRISQUE")

      Next

    End If

  End Sub

  Public Sub LoadDataCotationSituation()

    _dtDetailCotationSitu = New DataTable

    Dim sqlcmdLoad As New SqlCommand("[api_sp_FicheSituationDanger_Liste_Cotation]", MozartDatabase.cnxMozart)
    sqlcmdLoad.CommandType = CommandType.StoredProcedure
    _dtDetailCotationSitu.Load(sqlcmdLoad.ExecuteReader)

  End Sub

  Public Sub SaveFicheSituDanger_Reponse()


    Dim sqlcmdSave As New SqlCommand("[api_sp_FicheSituationDanger_Reponse_Save]", MozartDatabase.cnxMozart)
    sqlcmdSave.CommandType = CommandType.StoredProcedure
        sqlcmdSave.Parameters.Add("@P_NIDFICSITUDANG_REP", SqlDbType.Int).Value = _NIDFICSITUDANG_REP
        sqlcmdSave.Parameters("@P_NIDFICSITUDANG_REP").Direction = ParameterDirection.InputOutput
        sqlcmdSave.Parameters.Add("@P_NIDFICSITUDANG_SERVER", SqlDbType.Int).Value = _NIDFICSITUDANG_SERVER
        sqlcmdSave.Parameters.Add("@P_BCHKHUMA", SqlDbType.Bit).Value = _CHK_HUMAINE
        sqlcmdSave.Parameters.Add("@P_BCHKCONS", SqlDbType.Bit).Value = _CHK_CONSIGNE
        sqlcmdSave.Parameters.Add("@P_BCHKORGA", SqlDbType.Bit).Value = _CHK_ORGANISATION
        sqlcmdSave.Parameters.Add("@P_BCHKFORM", SqlDbType.Bit).Value = _CHK_FORMATION
        sqlcmdSave.Parameters.Add("@P_BCHKMATE", SqlDbType.Bit).Value = _CHK_MATERIEL
        sqlcmdSave.Parameters.Add("@P_BCHKMILI", SqlDbType.Bit).Value = _CHK_MILIEU
        sqlcmdSave.Parameters.Add("@P_BCHKAUTRES", SqlDbType.Bit).Value = _CHK_AUTRE
        sqlcmdSave.Parameters.Add("@P_VAUTRES", SqlDbType.VarChar).Value = _VAUTRES
    sqlcmdSave.Parameters.Add("@P_NCOTATION", SqlDbType.Int).Value = _NCOTATION
    sqlcmdSave.Parameters.Add("@P_NRISQUE", SqlDbType.Int).Value = _NRISQUE
    sqlcmdSave.Parameters.Add("@P_VREPONSE", SqlDbType.VarChar).Value = _VREPONSE
        sqlcmdSave.Parameters.Add("@P_DREPCREE", SqlDbType.DateTime).Value = If(_DATE_REP_CREE = "", DBNull.Value, _DATE_REP_CREE)
        sqlcmdSave.Parameters.Add("@P_BVALID_REP", SqlDbType.Bit).Value = _BVALID_REP
        sqlcmdSave.Parameters.Add("@P_NQUIREP", SqlDbType.Int).Value = _NQUIREP
        sqlcmdSave.Parameters.Add("@P_VQUIREP", SqlDbType.VarChar).Value = _VQUIREP
        sqlcmdSave.Parameters.Add("@P_VQUIFONC", SqlDbType.VarChar).Value = _VQUIFONC
        sqlcmdSave.Parameters.Add("@P_DTECH_LU", SqlDbType.DateTime).Value = If(_DTECH_LU = "", DBNull.Value, _DTECH_LU)
        sqlcmdSave.Parameters.Add("@P_DREPVALID", SqlDbType.DateTime).Value = If(_DREPVALID = "", DBNull.Value, _DREPVALID)

        sqlcmdSave.ExecuteNonQuery()

        NIDFICSITUDANG_REP = sqlcmdSave.Parameters("@P_NIDFICSITUDANG_REP").Value

    End Sub

End Class
