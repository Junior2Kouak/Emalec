Imports System.Data.SqlClient
Imports MozartLib

Public Class CGestionDoc

  Dim _sType As String

  Dim _DtListGestDoc As DataTable

  ReadOnly Property DtListGestDoc As DataTable
    Get
      Return _DtListGestDoc
    End Get
  End Property

  Public Sub New(ByVal c_sType As String)

    _sType = c_sType
    LoadData("O")

  End Sub

  Public Sub RefreshData(ByVal p_Actif As String)
    LoadData(p_Actif)
  End Sub

  Private Sub LoadData(ByVal p_Actif As String)

    Try

      Dim sqlcmd As New SqlCommand("[api_sp_ListeGestDocFicheTech]", MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.Add("@p_TYPE", SqlDbType.Char).Value = _sType
            sqlcmd.Parameters.Add("@p_ACTIF", SqlDbType.Char).Value = p_Actif

            _DtListGEstDoc = New DataTable
            _DtListGEstDoc.Load(sqlcmd.ExecuteReader)

        Catch ex As Exception

            MessageBox.Show("LoadData dans CGestionDoc : " + ex.Message)

        End Try

    End Sub

    Public Sub ArchiverDocument(ByVal p_NIDFICHE As Int32)

        Try

      Dim sqlcmd As New SqlCommand("[api_sp_GestDocArchiver]", MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.Add("@p_NIDFICHE", SqlDbType.Int).Value = p_NIDFICHE

            sqlcmd.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show("LoadData dans CGestionDoc : " + ex.Message)

        End Try

    End Sub

End Class
