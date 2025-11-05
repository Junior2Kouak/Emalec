Imports System.Data.SqlClient
Imports MozartLib

Public Class CGTPEQUIP

  Dim dtGTPEQUIP As DataTable

  Dim oGestConnectSQL As New CGestionSQL

  Public Sub New()

    Try

      'on ouvre la connexion
      oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete)

    Catch ex As Exception

      MessageBox.Show("Sub new dans CGTPEQUIP : " + ex.Message, "Erreur")

    End Try

  End Sub

  Private Sub Dispose()

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

  ReadOnly Property p_dtGTPEQUIP As DataTable
    Get
      Return dtGTPEQUIP
    End Get
  End Property

  '*******************************************************************************
  'Charge dans une table la liste des equipements GTP EQUIPEMENT
  '*******************************************************************************
  Public Function ListeGTPEquip() As DataTable

    Try

      dtGTPEQUIP = New DataTable

      Dim sqlcmdGTPEquip As New SqlCommand("api_sp_GTPListeEquip", oGestConnectSQL.CnxSQLOpen)
      sqlcmdGTPEquip.CommandType = CommandType.StoredProcedure

      'akout colone pour id tmp
      Dim ColAutoInc As DataColumn = New DataColumn
      ColAutoInc.DataType = System.Type.GetType("System.Int32")
      ColAutoInc.ColumnName = "IDTMP"
      With ColAutoInc
        .AutoIncrement = True
        .AutoIncrementSeed = 0
        .AutoIncrementStep = 1
      End With

      dtGTPEQUIP.Columns.Add(ColAutoInc)

      dtGTPEQUIP.Load(sqlcmdGTPEquip.ExecuteReader)

      Return dtGTPEQUIP

    Catch ex As Exception

      MessageBox.Show("CGTPEquip dans ListeGTPEquip : " + ex.Message)
      Return Nothing

    End Try

  End Function

  '*******************************************************************************
  'Charge dans une table la liste des equipements GTP EQUIPEMENT avec le details (nom du lot, nom de l'unite de mesure etc ...)
  '*******************************************************************************
  Public Function ListeGTPEquipDetails() As DataTable

    Try

      dtGTPEQUIP = New DataTable

      Dim sqlcmdGTPEquip As New SqlCommand("api_sp_GTPListeEquipDetails", oGestConnectSQL.CnxSQLOpen)
      sqlcmdGTPEquip.CommandType = CommandType.StoredProcedure

      'akout colone pour id tmp
      Dim ColAutoInc As DataColumn = New DataColumn
      ColAutoInc.DataType = System.Type.GetType("System.Int32")
      ColAutoInc.ColumnName = "IDTMP"
      With ColAutoInc
        .AutoIncrement = True
        .AutoIncrementSeed = 0
        .AutoIncrementStep = 1
      End With

      dtGTPEQUIP.Columns.Add(ColAutoInc)

      dtGTPEQUIP.Load(sqlcmdGTPEquip.ExecuteReader)

      Return dtGTPEQUIP

    Catch ex As Exception

      MessageBox.Show("CGTPEquip dans ListeGTPEquipDetails : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Public Sub AddNewLineGTPEquip()

    Try

      'Dim NewLineDataRow As DataRow = dtGTPEQUIP.NewRow

      'NewLineDataRow("NGTPMAINID") = 0
      'NewLineDataRow("NGTPLOTID") = 0
      'NewLineDataRow("NGTPUNITEID") = 0            

      'dtGTPEQUIP.Rows.Add(NewLineDataRow)

      Dim oFrmGTPNewEquip As New frmGTPNewEquipement(dtGTPEQUIP)
      oFrmGTPNewEquip.ShowDialog()


    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Sub SuppLineGTPEquip(ByVal p_NIDTMP As Int32)

    dtGTPEQUIP.Select("IDTMP=" + p_NIDTMP.ToString)(0).Delete()

  End Sub

  Public Sub SaveGTPEquip()

    Try

      Dim ODtSupprLine As DataTable = dtGTPEQUIP.GetChanges(DataRowState.Deleted)
      If Not ODtSupprLine Is Nothing Then
        ODtSupprLine.RejectChanges()
        'suppression des lignes supprimer dans la datable
        If ODtSupprLine.Rows.Count > 0 Then
          For Each oRowsInvSupp As DataRow In ODtSupprLine.Rows
            SupprLigneGTPEquip(oRowsInvSupp)
          Next
        End If
      End If

      dtGTPEQUIP.AcceptChanges()
      'sauvegarde des lignes inventaires
      If dtGTPEQUIP.Rows.Count > 0 Then
        For Each oRowsInv As DataRow In dtGTPEQUIP.Rows
          SaveLigneGTPEquip(oRowsInv)
        Next
      End If

      ListeGTPEquip()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SaveLigneGTPEquip(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sqlcmdCreateLigne As New SqlCommand("api_sp_GTPEquipCreateLigne", oGestConnectSQL.CnxSQLOpen)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@p_NGTPMAINID", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NGTPMAINID").Value = oRowsSavTemp.Item("NGTPMAINID")
      sqlcmdCreateLigne.Parameters.Add("@p_NGTPLOTID", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NGTPLOTID").Value = oRowsSavTemp.Item("NGTPLOTID")
      sqlcmdCreateLigne.Parameters.Add("@p_VGTPEQUIP", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@p_VGTPEQUIP").Value = oRowsSavTemp.Item("VGTPEQUIP")
      sqlcmdCreateLigne.Parameters.Add("@p_VGTPPRECIS", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@p_VGTPPRECIS").Value = oRowsSavTemp.Item("VGTPPRECIS")
      sqlcmdCreateLigne.Parameters.Add("@p_NGTPUNITEID", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NGTPUNITEID").Value = oRowsSavTemp.Item("NGTPUNITEID")
      sqlcmdCreateLigne.Parameters.Add("@p_NGTPCOUTUNIT", SqlDbType.Decimal)
      sqlcmdCreateLigne.Parameters("@p_NGTPCOUTUNIT").Value = oRowsSavTemp.Item("NGTPCOUTUNIT")
      sqlcmdCreateLigne.Parameters.Add("@p_NGTPDURVIE", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NGTPDURVIE").Value = oRowsSavTemp.Item("NGTPDURVIE")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SupprLigneGTPEquip(ByVal oRowsSupprTemp As DataRow)

    Try

      If oRowsSupprTemp.Item("NCLINUM") > 0 Then

        Dim sqlcmdSupprLigne As New SqlCommand("api_sp_GTPEquipSupprLigne", oGestConnectSQL.CnxSQLOpen)
        sqlcmdSupprLigne.CommandType = CommandType.StoredProcedure
        sqlcmdSupprLigne.Parameters.Add("@P_NGTPMAINID", SqlDbType.Int)
        sqlcmdSupprLigne.Parameters("@P_NGTPMAINID").Value = oRowsSupprTemp.Item("NGTPMAINID")

        sqlcmdSupprLigne.ExecuteNonQuery()

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

End Class
