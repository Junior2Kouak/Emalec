Imports System.Data.SqlClient
Imports MozartLib

Public Class CFICSITUDANG_SUIVIACT

  Private _NIDFICSITUDANG_SUIVIACT As Int32
  Private _NIDFICSITUDANG_SERVER As Int32
  Private _VSUIVIACTION_COM As String
  Private _NSUIVIACTION_ETAT As Int32

  Private _dtDetailFicheSituDang_SuiviAct As DataTable
  Private _dt_cbo_Etataction As DataTable

#Region "PROPERTY VARIABLES"
  Public Property NIDFICSITUDANG_SUIVIACT As Int32
    Get
      Return _NIDFICSITUDANG_SUIVIACT
    End Get
    Set(value As Int32)
      If _NIDFICSITUDANG_SUIVIACT = value Then
        Return
      End If
      _NIDFICSITUDANG_SUIVIACT = value
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

  Public Property VSUIVIACTION_COM As String
    Get
      Return _VSUIVIACTION_COM
    End Get
    Set(value As String)
      If _VSUIVIACTION_COM = value Then
        Return
      End If
      _VSUIVIACTION_COM = value
    End Set
  End Property

  Public Property NSUIVIACTION_ETAT As Int32
    Get
      Return _NSUIVIACTION_ETAT
    End Get
    Set(value As Int32)
      If _NSUIVIACTION_ETAT = value Then
        Return
      End If
      _NSUIVIACTION_ETAT = value
    End Set
  End Property

#End Region

  Public Sub New(ByVal c_NIDFICSITUDANG_SUIVIACT As Int32, ByVal c_NIDFICSITUDANG_SERVER As Int32)

    _NIDFICSITUDANG_SUIVIACT = c_NIDFICSITUDANG_SUIVIACT
    _NIDFICSITUDANG_SERVER = c_NIDFICSITUDANG_SERVER

    LoadDataFicheSituationDanger_SuiviAction()

  End Sub

  Public Sub LoadDataFicheSituationDanger_SuiviAction()

    _dtDetailFicheSituDang_SuiviAct = New DataTable

    Dim sqlcmdLoad As New SqlCommand("[api_sp_FicheSituationDanger_SuiviAction_Detail]", MozartDatabase.cnxMozart)
    sqlcmdLoad.CommandType = CommandType.StoredProcedure
        sqlcmdLoad.Parameters.Add("@P_NIDFICSITUDANG_SUIVIACT", SqlDbType.Int).Value = _NIDFICSITUDANG_SUIVIACT
        sqlcmdLoad.Parameters.Add("@P_NIDFICSITUDANG_SERVER", SqlDbType.Int).Value = _NIDFICSITUDANG_SERVER
        _dtDetailFicheSituDang_SuiviAct.Load(sqlcmdLoad.ExecuteReader)

        If _dtDetailFicheSituDang_SuiviAct.Rows.Count > 0 Then

            For Each drLoading As DataRow In _dtDetailFicheSituDang_SuiviAct.Rows

                _NIDFICSITUDANG_SUIVIACT = drLoading.Item("NIDFICSITUDANG_SUIVIACT")
                _NIDFICSITUDANG_SERVER = drLoading.Item("NIDFICSITUDANG_SERVER")
                _VSUIVIACTION_COM = drLoading.Item("VSUIVIACTION_COM")
                _NSUIVIACTION_ETAT = drLoading.Item("NSUIVIACTION_ETAT")

            Next

        End If

    End Sub

    Public Sub LoadDataCboEtatAction()

        _dt_cbo_Etataction = New DataTable

    Dim sqlcmdLoad As New SqlCommand("[api_sp_FicheSituationDanger_SuiviAction_ListeEtat]", MozartDatabase.cnxMozart)
    sqlcmdLoad.CommandType = CommandType.StoredProcedure
        _dt_cbo_Etataction.Load(sqlcmdLoad.ExecuteReader)

    End Sub

    Public Sub SaveFicheSituDanger_SuiviAction()

    Dim sqlcmdSave As New SqlCommand("[api_sp_FicheSituationDanger_SuiviAction_Save]", MozartDatabase.cnxMozart)
    sqlcmdSave.CommandType = CommandType.StoredProcedure
        sqlcmdSave.Parameters.Add("@P_NIDFICSITUDANG_SUIVIACT", SqlDbType.Int).Value = _NIDFICSITUDANG_SUIVIACT
        sqlcmdSave.Parameters("@P_NIDFICSITUDANG_SUIVIACT").Direction = ParameterDirection.InputOutput
        sqlcmdSave.Parameters.Add("@P_NIDFICSITUDANG_SERVER", SqlDbType.Int).Value = _NIDFICSITUDANG_SERVER
        sqlcmdSave.Parameters.Add("@P_VSUIVIACTION_COM", SqlDbType.VarChar).Value = _VSUIVIACTION_COM
        sqlcmdSave.Parameters.Add("@P_NSUIVIACTION_ETAT", SqlDbType.Int).Value = _NSUIVIACTION_ETAT

        sqlcmdSave.ExecuteNonQuery()

        _NIDFICSITUDANG_SUIVIACT = sqlcmdSave.Parameters("@P_NIDFICSITUDANG_SUIVIACT").Value

    End Sub

End Class
