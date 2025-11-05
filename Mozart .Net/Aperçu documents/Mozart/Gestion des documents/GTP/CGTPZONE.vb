Imports System.Data.SqlClient
Imports MozartLib

Public Class CGTPZONE

  Dim dtGTPZone As DataTable

  Dim oGestConnectSQL As New CGestionSQL

  Public Sub New()

    Try

      'on ouvre la connexion
      oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete)

    Catch ex As Exception

      MessageBox.Show("Sub new dans CGTPZONE : " + ex.Message, "Erreur")

    End Try

  End Sub

  Private Sub Dispose()

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

  ReadOnly Property p_dtGTPZone As DataTable
    Get
      Return dtGTPZone
    End Get
  End Property

  '*******************************************************************************
  'Charge dans une table la liste des LOT GTP
  '*******************************************************************************
  Public Function ListeGTPZone() As DataTable

    Try

      dtGTPZone = New DataTable

      Dim sqlcmdGTPZone As New SqlCommand("api_sp_GTPListeZone", oGestConnectSQL.CnxSQLOpen)
      sqlcmdGTPZone.CommandType = CommandType.StoredProcedure

      'akout colone pour id tmp
      Dim ColAutoInc As DataColumn = New DataColumn
      ColAutoInc.DataType = System.Type.GetType("System.Int32")
      ColAutoInc.ColumnName = "IDTMP"
      With ColAutoInc
        .AutoIncrement = True
        .AutoIncrementSeed = 0
        .AutoIncrementStep = 1
      End With

      dtGTPZone.Columns.Add(ColAutoInc)

      dtGTPZone.Load(sqlcmdGTPZone.ExecuteReader)

      Return dtGTPZone

    Catch ex As Exception

      MessageBox.Show("CGTPZONE dans ListeGTPZone : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Public Sub AddNewLineGTPZone()

    Try

      Dim NewLineDataRow As DataRow = dtGTPZone.NewRow

      NewLineDataRow("NGTPZONEID") = 0

      dtGTPZone.Rows.Add(NewLineDataRow)

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Sub SuppLineGTPZone(ByVal p_NIDTMP As Int32)

    dtGTPZone.Select("IDTMP=" + p_NIDTMP.ToString)(0).Delete()

  End Sub

  Public Sub SaveGTPZone()

    Try

      Dim ODtSupprLine As DataTable = dtGTPZone.GetChanges(DataRowState.Deleted)
      If Not ODtSupprLine Is Nothing Then
        ODtSupprLine.RejectChanges()
        'suppression des lignes supprimer dans la datable
        If ODtSupprLine.Rows.Count > 0 Then
          For Each oRowsInvSupp As DataRow In ODtSupprLine.Rows
            SupprLigneGTPZone(oRowsInvSupp)
          Next
        End If
      End If

      dtGTPZone.AcceptChanges()
      'sauvegarde des lignes inventaires
      If dtGTPZone.Rows.Count > 0 Then
        For Each oRowsInv As DataRow In dtGTPZone.Rows
          SaveLigneGTPZone(oRowsInv)
        Next
      End If

      ListeGTPZone()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SaveLigneGTPZone(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sqlcmdCreateLigne As New SqlCommand("api_sp_GTPZoneCreateLigne", oGestConnectSQL.CnxSQLOpen)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@p_NGTPZONEID", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NGTPZONEID").Value = oRowsSavTemp.Item("NGTPZONEID")
      sqlcmdCreateLigne.Parameters.Add("@p_VGTPZONENOM", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@p_VGTPZONENOM").Value = oRowsSavTemp.Item("VGTPZONENOM")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SupprLigneGTPZone(ByVal oRowsSupprTemp As DataRow)

    Try

      If oRowsSupprTemp.Item("NGTPZONEID") > 0 Then

        Dim sqlcmdSupprLigne As New SqlCommand("api_sp_GTPZoneSupprLigne", oGestConnectSQL.CnxSQLOpen)
        sqlcmdSupprLigne.CommandType = CommandType.StoredProcedure
        sqlcmdSupprLigne.Parameters.Add("@P_NGTPZONEID", SqlDbType.Int)
        sqlcmdSupprLigne.Parameters("@P_NGTPZONEID").Value = oRowsSupprTemp.Item("NGTPZONEID")

        sqlcmdSupprLigne.ExecuteNonQuery()

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Function ReturnSuppressionOK(ByVal NGTPZONEID As Int32) As Int32

    Try

      Dim iNbZoneExitByGTP As Int32 = 0

      Dim sqlcmdVerifSuppr As New SqlCommand("api_sp_GTPZoneSupprVerif", oGestConnectSQL.CnxSQLOpen)
      sqlcmdVerifSuppr.CommandType = CommandType.StoredProcedure
      sqlcmdVerifSuppr.Parameters.Add("@p_NGTPZONEID", SqlDbType.Int)
      sqlcmdVerifSuppr.Parameters("@p_NGTPZONEID").Value = NGTPZONEID

      Dim drsqlVerifSuppr As SqlDataReader = sqlcmdVerifSuppr.ExecuteReader

      If drsqlVerifSuppr.HasRows Then
        drsqlVerifSuppr.Read()
        iNbZoneExitByGTP = drsqlVerifSuppr.Item("NBZONEGTP")
        'sLISTGTPEQUIPError = drsqlVerifSuppr.Item("VLISTGTPEQUIP")
      Else
        iNbZoneExitByGTP = 0
      End If
      drsqlVerifSuppr.Close()

      Return iNbZoneExitByGTP

    Catch ex As Exception
      MessageBox.Show(ex.Message)
      Return 0
    End Try

  End Function

End Class
