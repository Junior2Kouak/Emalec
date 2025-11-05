Imports System.Data.SqlClient
Imports MozartLib

Public Class CGTPGESTCLI

  Dim oGestConnectSQL As New CGestionSQL
  Dim dtGTPClient As DataTable

  Public Sub New()

    Try

      'on ouvre la connexion
      oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete)

    Catch ex As Exception

      MessageBox.Show("Sub new dans CGTPCLIENT : " + ex.Message, "Erreur")

    End Try

  End Sub

  Private Sub Dispose()

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

  '*******************************************************************************
  'Charge dans une table la liste des Client en gestion GTP
  '*******************************************************************************
  Public Function ListeGTPClient() As DataTable

    Try

      dtGTPClient = New DataTable

      Dim sqlcmdGTPClientLst As New SqlCommand("api_sp_GTPGestClient", oGestConnectSQL.CnxSQLOpen)
      sqlcmdGTPClientLst.CommandType = CommandType.StoredProcedure

      'akout colone pour id tmp
      Dim ColAutoInc As DataColumn = New DataColumn
      ColAutoInc.DataType = System.Type.GetType("System.Int32")
      ColAutoInc.ColumnName = "IDTMP"
      With ColAutoInc
        .AutoIncrement = True
        .AutoIncrementSeed = 0
        .AutoIncrementStep = 1
      End With

      dtGTPClient.Columns.Add(ColAutoInc)

      dtGTPClient.Load(sqlcmdGTPClientLst.ExecuteReader)

      Return dtGTPClient

    Catch ex As Exception

      MessageBox.Show("CGTPCLIENT dans ListeGTPClient : " + ex.Message)
      Return Nothing

    End Try

  End Function

End Class
