Imports System.Data.SqlClient
Imports MozartLib

Public Class CPLA_AUTO_PREVIEW

  Friend NPLA_AUTO_ID_PREVIEW As Int32
  Friend NPLA_AUTO_ID As Int32
  Friend DPLA_AUTO_PREVIEW As DateTime?
  Friend PC_ACT_ETAT_P As Decimal
  Friend PC_ACT_ETAT_S As Decimal
  Friend TOT_ACT_ETAT_P As Int32
  Friend TOT_ACT_ETAT_S As Int32
  Friend TOT_ACT As Int32

  Friend DTPLA_AUTO_ACT_PREVIEW As DataTable

  Public Sub New() 'ByVal c_NPLA_AUTO_ID As Int32)

    'NPLA_AUTO_ID = c_NPLA_AUTO_ID

    LoadData()

  End Sub

  Private Sub LoadData()

    'liste des actions
    DTPLA_AUTO_ACT_PREVIEW = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_Planif_Auto_Preview_Detail]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
		'sqlcmd.Parameters.Add("@P_NPLA_AUTO_ID", SqlDbType.Int).Value = NPLA_AUTO_ID
		DTPLA_AUTO_ACT_PREVIEW.Load(sqlcmd.ExecuteReader())

	End Sub

End Class
