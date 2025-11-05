Imports System.Data.SqlClient
Imports MozartLib

Public Class CACCIDENT_TRAV

  Private _NACCIDENTID As Int32
  Private _DDATCRE As DateTime
  Private _VSOCIETE As String
  Private _NPERNUM As Int32
  Private _VPERNOM As String
  Private _BARRET As Boolean

  Public Property NACCIDENTID As Int32
    Get
      Return _NACCIDENTID
    End Get
    Set(value As Int32)
      _NACCIDENTID = value
    End Set
  End Property

  Public Property DDATCRE As DateTime
    Get
      Return _DDATCRE
    End Get
    Set(value As DateTime)
      _DDATCRE = value
    End Set
  End Property

  Public Property VSOCIETE As String
    Get
      Return _VSOCIETE
    End Get
    Set(value As String)
      _VSOCIETE = value
    End Set
  End Property

  Public Property NPERNUM As Int32
    Get
      Return _NPERNUM
    End Get
    Set(value As Int32)
      _NPERNUM = value
    End Set
  End Property

  Public Property VPERNOM As String
    Get
      Return _VPERNOM
    End Get
    Set(value As String)
      _VPERNOM = value
    End Set
  End Property

  Public Property BARRET As Boolean
    Get
      Return _BARRET
    End Get
    Set(value As Boolean)
      _BARRET = value
    End Set
  End Property

  Public Sub New(ByVal c_NACCIDENTID As Int32)

    _NACCIDENTID = c_NACCIDENTID

    LoadData()

  End Sub

  Private Sub LoadData()

    'on charge la datatable des fo de la commande web tech
    Dim sqlcmd_read As New SqlCommand("[api_sp_AccidentTrav_Detail]", MozartDatabase.cnxMozart)
    sqlcmd_read.CommandType = CommandType.StoredProcedure
    sqlcmd_read.Parameters.Add("@P_NACCIDENTID", SqlDbType.Int).Value = _NACCIDENTID
    sqlcmd_read.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = MozartParams.NomSociete

    Dim sql_dr As SqlDataReader = sqlcmd_read.ExecuteReader

    If sql_dr.HasRows Then

      While sql_dr.Read

        _NACCIDENTID = sql_dr.Item("NACCIDENTID")
        _DDATCRE = sql_dr.Item("DDATCRE")
        _VSOCIETE = sql_dr.Item("VSOCIETE")
        _NPERNUM = sql_dr.Item("NPERNUM")
        _VPERNOM = sql_dr.Item("VPERNOM")
        _BARRET = sql_dr.Item("BARRET")

      End While

    End If

    sql_dr.Close()

  End Sub

  Public Sub Save()

    Dim sqlcmd_save As New SqlCommand("[api_sp_AccidentTrav_Save]", MozartDatabase.cnxMozart)
    sqlcmd_save.CommandType = CommandType.StoredProcedure
    sqlcmd_save.Parameters.Add("@P_NACCIDENTID", SqlDbType.Int).Value = _NACCIDENTID
    sqlcmd_save.Parameters("@P_NACCIDENTID").Direction = ParameterDirection.InputOutput
    sqlcmd_save.Parameters.Add("@P_DDATCRE", SqlDbType.DateTime).Value = _DDATCRE
    sqlcmd_save.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = _NPERNUM
    sqlcmd_save.Parameters.Add("@P_BARRET", SqlDbType.VarChar).Value = _BARRET

    sqlcmd_save.ExecuteNonQuery()

    _NACCIDENTID = sqlcmd_save.Parameters("@P_NACCIDENTID").Value

  End Sub

  Public Sub Delete()

    Dim sqlcmd_save As New SqlCommand("[api_sp_AccidentTrav_Delete]", MozartDatabase.cnxMozart)
    sqlcmd_save.CommandType = CommandType.StoredProcedure
    sqlcmd_save.Parameters.Add("@P_NACCIDENTID", SqlDbType.Int).Value = _NACCIDENTID

    sqlcmd_save.ExecuteNonQuery()

    Init()

  End Sub

  Private Sub Init()

    _NACCIDENTID = 0
    _DDATCRE = Nothing
    _VSOCIETE = ""
    _NPERNUM = 0
    _VPERNOM = ""
    _BARRET = False

  End Sub


End Class

