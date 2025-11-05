Imports System.Data.SqlClient
Imports MozartLib

Public Class CGTPUNITE

  Dim dtGTPUnite As DataTable

  Dim sLISTGTPEQUIPError As String

  Dim oGestConnectSQL As New CGestionSQL

  Public Sub New()

    Try

      'on ouvre la connexion
      oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete)

      sLISTGTPEQUIPError = ""

    Catch ex As Exception

      MessageBox.Show("Sub new dans CGTPUNITE : " + ex.Message, "Erreur")

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

  ReadOnly Property p_dtGTPUnite As DataTable
    Get
      Return dtGTPUnite
    End Get
  End Property

  '*******************************************************************************
  'Charge dans une table la liste des LOT GTP
  '*******************************************************************************
  Public Function ListeGTPUnite() As DataTable

    Try

      dtGTPUnite = New DataTable

      Dim sqlcmdGTPLstUnite As New SqlCommand("api_sp_GTPListeUnite", oGestConnectSQL.CnxSQLOpen)
      sqlcmdGTPLstUnite.CommandType = CommandType.StoredProcedure

      'akout colone pour id tmp
      Dim ColAutoInc As DataColumn = New DataColumn
      ColAutoInc.DataType = System.Type.GetType("System.Int32")
      ColAutoInc.ColumnName = "IDTMP"
      With ColAutoInc
        .AutoIncrement = True
        .AutoIncrementSeed = 0
        .AutoIncrementStep = 1
      End With

      dtGTPUnite.Columns.Add(ColAutoInc)

      dtGTPUnite.Load(sqlcmdGTPLstUnite.ExecuteReader)

      Return dtGTPUnite

    Catch ex As Exception

      MessageBox.Show("CGTPUNITE dans ListeGTPUnite : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Public Sub AddNewLineGTPUnite()

    Try

      Dim NewLineDataRow As DataRow = dtGTPUnite.NewRow

      NewLineDataRow("NGTPUNITEID") = 0

      dtGTPUnite.Rows.Add(NewLineDataRow)

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Sub SuppLineGTPLot(ByVal p_NIDTMP As Int32)

    dtGTPUnite.Select("IDTMP=" + p_NIDTMP.ToString)(0).Delete()

  End Sub

  Public Sub SaveGTPUnite()

    Try

      Dim ODtSupprLine As DataTable = dtGTPUnite.GetChanges(DataRowState.Deleted)
      If Not ODtSupprLine Is Nothing Then
        ODtSupprLine.RejectChanges()
        'suppression des lignes supprimer dans la datable
        If ODtSupprLine.Rows.Count > 0 Then
          For Each oRowsInvSupp As DataRow In ODtSupprLine.Rows
            SupprLigneGTPUnite(oRowsInvSupp)
          Next
        End If
      End If

      dtGTPUnite.AcceptChanges()
      'sauvegarde des lignes inventaires
      If dtGTPUnite.Rows.Count > 0 Then
        For Each oRowsInv As DataRow In dtGTPUnite.Rows
          SaveLigneGTPUnite(oRowsInv)
        Next
      End If

      ListeGTPUnite()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SaveLigneGTPUnite(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sqlcmdCreateLigne As New SqlCommand("api_sp_GTPUniteCreateLigne", oGestConnectSQL.CnxSQLOpen)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@p_NGTPUNITEID", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NGTPUNITEID").Value = oRowsSavTemp.Item("NGTPUNITEID")
      sqlcmdCreateLigne.Parameters.Add("@p_VGTPUNITENOM", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@p_VGTPUNITENOM").Value = oRowsSavTemp.Item("VGTPUNITENOM")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SupprLigneGTPUnite(ByVal oRowsSupprTemp As DataRow)

    Try

      If oRowsSupprTemp.Item("NGTPLOTID") > 0 Then

        Dim sqlcmdSupprLigne As New SqlCommand("api_sp_GTPUniteSupprLigne", oGestConnectSQL.CnxSQLOpen)
        sqlcmdSupprLigne.CommandType = CommandType.StoredProcedure
        sqlcmdSupprLigne.Parameters.Add("@P_NGTPUNITEID", SqlDbType.Int)
        sqlcmdSupprLigne.Parameters("@P_NGTPUNITEID").Value = oRowsSupprTemp.Item("NGTPUNITEID")

        sqlcmdSupprLigne.ExecuteNonQuery()

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Function ReturnSuppressionOK(ByVal NGTPUNITEID As Int32) As Int32

    Try

      Dim iNbUniteExitByGTP As Int32 = 0
      sLISTGTPEQUIPError = ""

      Dim sqlcmdVerifSuppr As New SqlCommand("api_sp_GTPUniteSupprVerif", oGestConnectSQL.CnxSQLOpen)
      sqlcmdVerifSuppr.CommandType = CommandType.StoredProcedure
      sqlcmdVerifSuppr.Parameters.Add("@p_NGTPUNITEID", SqlDbType.Int)
      sqlcmdVerifSuppr.Parameters("@p_NGTPUNITEID").Value = NGTPUNITEID

      Dim drsqlVerifSuppr As SqlDataReader = sqlcmdVerifSuppr.ExecuteReader

      If drsqlVerifSuppr.HasRows Then
        drsqlVerifSuppr.Read()
        iNbUniteExitByGTP = drsqlVerifSuppr.Item("NBUNITEGTP")
        sLISTGTPEQUIPError = drsqlVerifSuppr.Item("VLISTGTPEQUIP")
      Else
        iNbUniteExitByGTP = 0
      End If
      drsqlVerifSuppr.Close()

      Return iNbUniteExitByGTP

    Catch ex As Exception
      MessageBox.Show(ex.Message)
      Return 0
    End Try

  End Function

End Class
