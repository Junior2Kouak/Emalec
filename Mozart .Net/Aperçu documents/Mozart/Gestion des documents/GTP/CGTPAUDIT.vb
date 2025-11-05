Imports System.Data.SqlClient
Imports MozartLib

Public Class CGTPAUDIT

  Dim oGestConnectSQL As New CGestionSQL

  Dim dtGTPAudit As DataTable

  Public Sub New()

    Try

      'on ouvre la connexion
      oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete)

    Catch ex As Exception

      MessageBox.Show("Sub new dans CGTPAUDIT : " + ex.Message, "Erreur")

    End Try

  End Sub

  Private Sub Dispose()

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

  '*******************************************************************************
  '
  '*******************************************************************************
  Public Function GTPAuditLastBySite(ByRef p_NSITNUM As Int32) As DataTable

    Try

      dtGTPAudit = New DataTable

      Dim sqlcmdGTPAuditBySiteZone As New SqlCommand("api_sp_GTPAuditSiteLast", oGestConnectSQL.CnxSQLOpen)
      sqlcmdGTPAuditBySiteZone.CommandType = CommandType.StoredProcedure
      sqlcmdGTPAuditBySiteZone.Parameters.Add("@p_NSITNUM", SqlDbType.Int)
      sqlcmdGTPAuditBySiteZone.Parameters("@p_NSITNUM").Value = p_NSITNUM

      'akout colone pour id tmp
      Dim ColAutoInc As DataColumn = New DataColumn
      ColAutoInc.DataType = System.Type.GetType("System.Int32")
      ColAutoInc.ColumnName = "IDTMP"
      With ColAutoInc
        .AutoIncrement = True
        .AutoIncrementSeed = 0
        .AutoIncrementStep = 1
      End With

      dtGTPAudit.Columns.Add(ColAutoInc)

      dtGTPAudit.Load(sqlcmdGTPAuditBySiteZone.ExecuteReader)

      Return dtGTPAudit

    Catch ex As Exception

      MessageBox.Show("CGTPAUDIT dans GTPAuditLastBySite : " + ex.Message)
      Return Nothing

    End Try

  End Function


End Class
