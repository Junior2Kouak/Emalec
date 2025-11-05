
Imports System.Data.SqlClient
Imports MozartLib

Public Class CORGANISME

  Dim dt As DataTable
  Dim oGestConnectSQL As New CGestionSQL

  Public Sub New()

    Try

      'on ouvre la connexion
      oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete)

    Catch ex As Exception

      MessageBox.Show("Sub new dans CORGANISME : " + ex.Message, "Erreur")

    End Try

  End Sub

  Private Sub Dispose()

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

  ReadOnly Property p_dtORG As DataTable
    Get
      Return dt
    End Get
  End Property

  '*******************************************************************************
  'Charge dans une table la liste des LOT GTP
  '*******************************************************************************
  Public Function ListeOrganisme() As DataTable

    Try

      dt = New DataTable

      Dim sqlcmd As New SqlCommand("select NORGNUM, VORGNOM, VORGADRESSE, VORGOBS  FROM dbo.TREF_ORGFORMATION ORDER BY VORGNOM", oGestConnectSQL.CnxSQLOpen)
      sqlcmd.CommandType = CommandType.Text

      'akout colone pour id tmp
      Dim ColAutoInc As DataColumn = New DataColumn
      ColAutoInc.DataType = System.Type.GetType("System.Int32")
      ColAutoInc.ColumnName = "IDTMP"
      With ColAutoInc
        .AutoIncrement = True
        .AutoIncrementSeed = 0
        .AutoIncrementStep = 1
      End With

      dt.Columns.Add(ColAutoInc)

      dt.Load(sqlcmd.ExecuteReader)

      Return dt

    Catch ex As Exception

      MessageBox.Show("ListeOrganisme dans CORGANISME : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Public Sub AddNewLineORG()

    Try

      Dim NewLineDataRow As DataRow = dt.NewRow

      NewLineDataRow("NORGNUM") = 0

      dt.Rows.Add(NewLineDataRow)

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Sub SuppLineORG(ByVal p_NIDTMP As Int32)

    dt.Select("IDTMP=" + p_NIDTMP.ToString)(0).Delete()

  End Sub

  Public Sub SaveOrg()

    Try

      Dim ODtSupprLine As DataTable = dt.GetChanges(DataRowState.Deleted)
      If Not ODtSupprLine Is Nothing Then
        ODtSupprLine.RejectChanges()
        'suppression des lignes supprimer dans la datable
        If ODtSupprLine.Rows.Count > 0 Then
          For Each oRowsInvSupp As DataRow In ODtSupprLine.Rows
            SupprLigneOrg(oRowsInvSupp)
          Next
        End If
      End If

      dt.AcceptChanges()
      'sauvegarde des lignes inventaires
      If dt.Rows.Count > 0 Then
        For Each oRowsInv As DataRow In dt.Rows
          SaveLigneOrg(oRowsInv)
        Next
      End If

      ListeOrganisme()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SaveLigneOrg(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sql As New SqlCommand("api_sp_CreationOrganisme", oGestConnectSQL.CnxSQLOpen)
      sql.CommandType = CommandType.StoredProcedure
      sql.Parameters.Add("@p_NORGNUM", SqlDbType.Int)
      sql.Parameters("@p_NORGNUM").Value = oRowsSavTemp.Item("NORGNUM")
      sql.Parameters.Add("@p_VORGNOM", SqlDbType.VarChar)
      sql.Parameters("@p_VORGNOM").Value = oRowsSavTemp.Item("VORGNOM")
      sql.Parameters.Add("@p_VORGADR", SqlDbType.VarChar)
      sql.Parameters("@p_VORGADR").Value = oRowsSavTemp.Item("VORGADRESSE")
      sql.Parameters.Add("@p_VORGOBS", SqlDbType.VarChar)
      sql.Parameters("@p_VORGOBS").Value = oRowsSavTemp.Item("VORGOBS")

      sql.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SupprLigneOrg(ByVal oRowsSupprTemp As DataRow)

    Try

      If oRowsSupprTemp.Item("NORGNUM") > 0 Then

        Dim sqlcmdSupprLigne As New SqlCommand("DELETE FROM dbo.TREF_ORGFORMATION WHERE NORGNUM=" + oRowsSupprTemp.Item("NORGNUM").ToString, oGestConnectSQL.CnxSQLOpen)
        sqlcmdSupprLigne.CommandType = CommandType.Text
        sqlcmdSupprLigne.ExecuteNonQuery()

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Function ReturnSuppressionOK(ByVal NGTPLOTID As Int32) As Int32

    Try

      Return 0

      'Dim iNbLotExitByGTP As Int32 = 0

      'Dim sqlcmdVerifSuppr As New SqlCommand("api_sp_GTPLotSupprVerif", oGestConnectSQL.CnxSQLOpen)
      'sqlcmdVerifSuppr.CommandType = CommandType.StoredProcedure
      'sqlcmdVerifSuppr.Parameters.Add("@p_NGTPLOTID", SqlDbType.Int)
      'sqlcmdVerifSuppr.Parameters("@p_NGTPLOTID").Value = NGTPLOTID

      'Dim drsqlVerifSuppr As SqlDataReader = sqlcmdVerifSuppr.ExecuteReader

      'If drsqlVerifSuppr.HasRows Then
      '	drsqlVerifSuppr.Read()
      '	iNbLotExitByGTP = drsqlVerifSuppr.Item("NBLOTGTP")
      'Else
      '	iNbLotExitByGTP = 0
      'End If
      'drsqlVerifSuppr.Close()

      'Return iNbLotExitByGTP

    Catch ex As Exception
      MessageBox.Show(ex.Message)
      Return 0
    End Try

  End Function

End Class
