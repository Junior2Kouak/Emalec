Imports System.Data.SqlClient
Imports MozartLib

Public Class CGTPGESTSIT

  Dim oGestConnectSQL As New CGestionSQL
  Dim dtGTPSite As DataTable

  Public Sub New()

    Try

      'on ouvre la connexion
      oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete)

    Catch ex As Exception

      MessageBox.Show("Sub new dans CGTPGESTSIT : " + ex.Message, "Erreur")

    End Try

  End Sub

  Private Sub Dispose()

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

  '*******************************************************************************
  'Charge dans une table la liste des sites et des clients
  '*******************************************************************************
  Public Function ListeGTPSite() As DataTable

    Try

      dtGTPSite = New DataTable

      Dim sqlcmdGTPSiteLst As New SqlCommand("api_sp_GTPGestSite", oGestConnectSQL.CnxSQLOpen)
      sqlcmdGTPSiteLst.CommandType = CommandType.StoredProcedure

      'akout colone pour id tmp
      Dim ColAutoInc As DataColumn = New DataColumn
      ColAutoInc.DataType = System.Type.GetType("System.Int32")
      ColAutoInc.ColumnName = "IDTMP"
      With ColAutoInc
        .AutoIncrement = True
        .AutoIncrementSeed = 0
        .AutoIncrementStep = 1
      End With

      dtGTPSite.Columns.Add(ColAutoInc)

      dtGTPSite.Load(sqlcmdGTPSiteLst.ExecuteReader)

      Return dtGTPSite

    Catch ex As Exception

      MessageBox.Show("CGTPGESTSIT dans ListeGTPSite : " + ex.Message)
      Return Nothing

    End Try

  End Function

End Class
