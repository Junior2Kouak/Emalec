Imports System.Data.SqlClient
Imports MozartLib

Public Class CGTPLOT

  Dim dtGTPLot As DataTable

  Dim sLISTGTPEQUIPError As String

  Dim oGestConnectSQL As New CGestionSQL

  Public Sub New()

    Try

      'on ouvre la connexion
      oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete)

      sLISTGTPEQUIPError = ""

    Catch ex As Exception

      MessageBox.Show("Sub new dans CGTPLOT : " + ex.Message, "Erreur")

    End Try

  End Sub

  Private Sub Dispose()

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

  ReadOnly Property p_sLISTGTPEQUIPError As String
    Get
      Return sLISTGTPEQUIPError
    End Get
  End Property

  ReadOnly Property p_dtGTPLot As DataTable
    Get
      Return dtGTPLot
    End Get
  End Property

  '*******************************************************************************
  'Charge dans une table la liste des LOT GTP
  '*******************************************************************************
  Public Function ListeGTPLot() As DataTable

    Try

      dtGTPLot = New DataTable

      Dim sqlcmdGTPLstLot As New SqlCommand("api_sp_GTPListeLot", oGestConnectSQL.CnxSQLOpen)
      sqlcmdGTPLstLot.CommandType = CommandType.StoredProcedure

      'akout colone pour id tmp
      Dim ColAutoInc As DataColumn = New DataColumn
      ColAutoInc.DataType = System.Type.GetType("System.Int32")
      ColAutoInc.ColumnName = "IDTMP"
      With ColAutoInc
        .AutoIncrement = True
        .AutoIncrementSeed = 0
        .AutoIncrementStep = 1
      End With

      dtGTPLot.Columns.Add(ColAutoInc)

      dtGTPLot.Load(sqlcmdGTPLstLot.ExecuteReader)

      Return dtGTPLot

    Catch ex As Exception

      MessageBox.Show("CGTPLOT dans ListeGTPLot : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Public Sub AddNewLineGTPLot()

    Try

      Dim NewLineDataRow As DataRow = dtGTPLot.NewRow

      NewLineDataRow("NGTPLOTID") = 0

      dtGTPLot.Rows.Add(NewLineDataRow)

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Sub SuppLineGTPLot(ByVal p_NIDTMP As Int32)

    dtGTPLot.Select("IDTMP=" + p_NIDTMP.ToString)(0).Delete()

  End Sub

  Public Sub SaveGTPLot()

    Try

      Dim ODtSupprLine As DataTable = dtGTPLot.GetChanges(DataRowState.Deleted)
      If Not ODtSupprLine Is Nothing Then
        ODtSupprLine.RejectChanges()
        'suppression des lignes supprimer dans la datable
        If ODtSupprLine.Rows.Count > 0 Then
          For Each oRowsInvSupp As DataRow In ODtSupprLine.Rows
            SupprLigneGTPLot(oRowsInvSupp)
          Next
        End If
      End If

      dtGTPLot.AcceptChanges()
      'sauvegarde des lignes inventaires
      If dtGTPLot.Rows.Count > 0 Then
        For Each oRowsInv As DataRow In dtGTPLot.Rows
          SaveLigneGTPLot(oRowsInv)
        Next
      End If

      ListeGTPLot()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SaveLigneGTPLot(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sqlcmdCreateLigne As New SqlCommand("api_sp_GTPLotCreateLigne", oGestConnectSQL.CnxSQLOpen)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@p_NGTPLOTID", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NGTPLOTID").Value = oRowsSavTemp.Item("NGTPLOTID")
      sqlcmdCreateLigne.Parameters.Add("@p_VGTPLOTNOM", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@p_VGTPLOTNOM").Value = oRowsSavTemp.Item("VGTPLOTNOM")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SupprLigneGTPLot(ByVal oRowsSupprTemp As DataRow)

    Try

      If oRowsSupprTemp.Item("NGTPLOTID") > 0 Then

        Dim sqlcmdSupprLigne As New SqlCommand("api_sp_GTPLotSupprLigne", oGestConnectSQL.CnxSQLOpen)
        sqlcmdSupprLigne.CommandType = CommandType.StoredProcedure
        sqlcmdSupprLigne.Parameters.Add("@P_NGTPLOTID", SqlDbType.Int)
        sqlcmdSupprLigne.Parameters("@P_NGTPLOTID").Value = oRowsSupprTemp.Item("NGTPLOTID")

        sqlcmdSupprLigne.ExecuteNonQuery()

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Function ReturnSuppressionOK(ByVal NGTPLOTID As Int32) As Int32

    Try

      Dim iNbLotExitByGTP As Int32 = 0
      sLISTGTPEQUIPError = ""

      Dim sqlcmdVerifSuppr As New SqlCommand("api_sp_GTPLotSupprVerif", oGestConnectSQL.CnxSQLOpen)
      sqlcmdVerifSuppr.CommandType = CommandType.StoredProcedure
      sqlcmdVerifSuppr.Parameters.Add("@p_NGTPLOTID", SqlDbType.Int)
      sqlcmdVerifSuppr.Parameters("@p_NGTPLOTID").Value = NGTPLOTID

      Dim drsqlVerifSuppr As SqlDataReader = sqlcmdVerifSuppr.ExecuteReader

      If drsqlVerifSuppr.HasRows Then
        drsqlVerifSuppr.Read()
        iNbLotExitByGTP = drsqlVerifSuppr.Item("NBLOTGTP")
        sLISTGTPEQUIPError = drsqlVerifSuppr.Item("VLISTGTPEQUIP")
      Else
        iNbLotExitByGTP = 0
      End If
      drsqlVerifSuppr.Close()

      Return iNbLotExitByGTP

    Catch ex As Exception
      MessageBox.Show(ex.Message)
      Return 0
    End Try

  End Function

End Class
