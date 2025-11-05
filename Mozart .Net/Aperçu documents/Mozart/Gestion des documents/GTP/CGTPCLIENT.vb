Imports System.Data.SqlClient
Imports MozartLib

Public Class CGTPCLIENT

  Dim dtGTPClient As DataTable
  Dim NCLINUM As Int32

  Dim oGestConnectSQL As New CGestionSQL

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

  ReadOnly Property p_dtGTPClient As DataTable
    Get
      Return dtGTPClient
    End Get
  End Property

  Property p_NCLINUM As Int32
    Get
      Return NCLINUM
    End Get
    Set(ByVal value As Int32)
      NCLINUM = value
    End Set
  End Property

  '*******************************************************************************
  'Charge dans une table la liste des LOT GTP
  '*******************************************************************************
  Public Function ListeGTPClient() As DataTable

    Try

      dtGTPClient = New DataTable

      Dim sqlcmdGTPClientLst As New SqlCommand("api_sp_GTPClientListe", oGestConnectSQL.CnxSQLOpen)
      sqlcmdGTPClientLst.CommandType = CommandType.StoredProcedure
      sqlcmdGTPClientLst.Parameters.Add("@p_nclinum", SqlDbType.Int)
      sqlcmdGTPClientLst.Parameters("@p_nclinum").Value = NCLINUM

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

  Public Sub AddNewLineGTPClient(ByVal p_oDataRowInsert As DataRow)

    Try

      Dim NewLineDataRow As DataRow = dtGTPClient.NewRow

      NewLineDataRow("NGTPCLIID") = 0
      NewLineDataRow("NCLINUM") = NCLINUM
      NewLineDataRow("NGTPMAINID") = p_oDataRowInsert("NGTPMAINID")
      NewLineDataRow("VGTPLOTNOM") = p_oDataRowInsert("VGTPLOTNOM")
      NewLineDataRow("VGTPEQUIP") = p_oDataRowInsert("VGTPEQUIP")
      NewLineDataRow("VGTPPRECIS") = p_oDataRowInsert("VGTPPRECIS")
      NewLineDataRow("VGTPUNITENOM") = p_oDataRowInsert("VGTPUNITENOM")
      NewLineDataRow("NGTPCOUTUNIT") = p_oDataRowInsert("NGTPCOUTUNIT")
      NewLineDataRow("NGTPDURVIE") = p_oDataRowInsert("NGTPDURVIE")

      dtGTPClient.Rows.Add(NewLineDataRow)

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Sub SuppLineGTPClient(ByVal p_NIDTMP As Int32)

    dtGTPClient.Select("IDTMP=" + p_NIDTMP.ToString)(0).Delete()

  End Sub

  Public Sub SaveGTPClient()

    Try

      Dim ODtSupprLine As DataTable = dtGTPClient.GetChanges(DataRowState.Deleted)
      If Not ODtSupprLine Is Nothing Then
        ODtSupprLine.RejectChanges()
        'suppression des lignes supprimer dans la datable
        If ODtSupprLine.Rows.Count > 0 Then
          For Each oRowsInvSupp As DataRow In ODtSupprLine.Rows
            SupprLigneGTPClient(oRowsInvSupp)
          Next
        End If
      End If

      dtGTPClient.AcceptChanges()
      'sauvegarde des lignes inventaires
      If dtGTPClient.Rows.Count > 0 Then
        For Each oRowsInv As DataRow In dtGTPClient.Rows
          SaveLigneGTPClient(oRowsInv)
        Next
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SaveLigneGTPClient(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sqlcmdCreateLigne As New SqlCommand("api_sp_GTPClientCreateLigne", oGestConnectSQL.CnxSQLOpen)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@p_NGTPCLIID", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NGTPCLIID").Value = oRowsSavTemp.Item("NGTPCLIID")
      sqlcmdCreateLigne.Parameters.Add("@p_NCLINUM", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NCLINUM").Value = oRowsSavTemp.Item("NCLINUM")
      sqlcmdCreateLigne.Parameters.Add("@p_NGTPMAINID", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NGTPMAINID").Value = oRowsSavTemp.Item("NGTPMAINID")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SupprLigneGTPClient(ByVal oRowsSupprTemp As DataRow)

    Try

      If oRowsSupprTemp.Item("NGTPCLIID") > 0 Then

        Dim sqlcmdSupprLigne As New SqlCommand("api_sp_GTPClientSupprLigne", oGestConnectSQL.CnxSQLOpen)
        sqlcmdSupprLigne.CommandType = CommandType.StoredProcedure
        sqlcmdSupprLigne.Parameters.Add("@P_NGTPCLIID", SqlDbType.Int)
        sqlcmdSupprLigne.Parameters("@P_NGTPCLIID").Value = oRowsSupprTemp.Item("NGTPCLIID")

        sqlcmdSupprLigne.ExecuteNonQuery()

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Function ReturnSuppressionOK(ByVal NGTPMAINID As Int32) As Int32

    Try

      Dim iNbSiteClientExitByGTP As Int32 = 0

      Dim sqlcmdVerifSuppr As New SqlCommand("api_sp_GTPClientSupprVerif", oGestConnectSQL.CnxSQLOpen)
      sqlcmdVerifSuppr.CommandType = CommandType.StoredProcedure
      sqlcmdVerifSuppr.Parameters.Add("@p_NCLINUM", SqlDbType.Int)
      sqlcmdVerifSuppr.Parameters("@p_NCLINUM").Value = NCLINUM
      sqlcmdVerifSuppr.Parameters.Add("@p_NGTPMAINID", SqlDbType.Int)
      sqlcmdVerifSuppr.Parameters("@p_NGTPMAINID").Value = NGTPMAINID

      Dim drsqlVerifSuppr As SqlDataReader = sqlcmdVerifSuppr.ExecuteReader

      If drsqlVerifSuppr.HasRows Then
        drsqlVerifSuppr.Read()
        iNbSiteClientExitByGTP = drsqlVerifSuppr.Item("NBSITCLIGTP")
        'sLISTGTPEQUIPError = drsqlVerifSuppr.Item("VLISTGTPEQUIP")
      Else
        iNbSiteClientExitByGTP = 0
      End If
      drsqlVerifSuppr.Close()

      Return iNbSiteClientExitByGTP

    Catch ex As Exception
      MessageBox.Show(ex.Message)
      Return 0
    End Try

  End Function

  Public Function ListeClientCbo() As DataTable

    Try

      Dim dtLstClient As New DataTable

      Dim sqlcmdGTPClientLst As New SqlCommand("SELECT NCLINUM, VCLINOM FROM TCLI WHERE VSOCIETE = APP_NAME() AND CCLIACTIF = 'O' ORDER BY VCLINOM", oGestConnectSQL.CnxSQLOpen)

      dtLstClient.Load(sqlcmdGTPClientLst.ExecuteReader)

      Return dtLstClient

    Catch ex As Exception

      MessageBox.Show("CGTPCLIENT dans ListeClientCbo : " + ex.Message)
      Return Nothing

    End Try

  End Function

End Class
