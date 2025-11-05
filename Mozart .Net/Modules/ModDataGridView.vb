Imports System.Data.SqlClient
Imports MozartLib

Module ModDataGridView

  Friend Function LoadList(ByVal sRequete As String, ByVal oCnxUse As SqlConnection) As DataTable
    Return MozartDatabase.GetDataTable(sRequete)
  End Function

  Friend Function LoadListWithIncrementAuto(ByVal sRequete As String, ByVal oCnxUse As SqlConnection) As DataTable

    Dim dtLoadList As New DataTable

    Try

      Dim ColAutoInc As New DataColumn With {
        .DataType = Type.GetType("System.Int64"),
        .ColumnName = "IDTMP",
        .AutoIncrement = True,
        .AutoIncrementSeed = 0,
      .AutoIncrementStep = 1
      }

      dtLoadList.Columns.Add(ColAutoInc)

      Dim cmdLoadList As New SqlCommand(sRequete, oCnxUse) With {
        .CommandTimeout = 0
      }
      dtLoadList.Load(cmdLoadList.ExecuteReader)

      Return dtLoadList

    Catch ex As Exception

      MessageBox.Show("Module ModDataGridView dans LoadList : " + ex.Message, "Erreur")
      Return dtLoadList

    End Try

  End Function

End Module
