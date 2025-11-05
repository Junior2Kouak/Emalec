Imports System.Data.SqlClient
Imports MozartLib

Public Class CFORMATION

  Dim dtForm As DataTable
  Dim oGestConnectSQL As New CGestionSQL

  Public Sub New()

    Try

      'on ouvre la connexion
      oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete)

    Catch ex As Exception

      MessageBox.Show("Sub new dans CFormation : " + ex.Message, "Erreur")

    End Try

  End Sub

  Private Sub Dispose()

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

  ReadOnly Property p_datatable As DataTable
    Get
      Return dtForm
    End Get
  End Property

  '*******************************************************************************
  'Charge dans une table la liste des formations
  '*******************************************************************************
  Public Function ListeFormation(Optional ByVal p_CPERACTIF As String = "O") As DataTable

    Try

      dtForm = New DataTable

      Dim sqlcmd As New SqlCommand("api_sp_ListeFormation", oGestConnectSQL.CnxSQLOpen)
      sqlcmd.CommandType = CommandType.StoredProcedure
      sqlcmd.Parameters.Add("@p_NFORMNUM", SqlDbType.Int)
      sqlcmd.Parameters("@p_NFORMNUM").Value = 0
      sqlcmd.Parameters.Add("@p_CPERACTIF", SqlDbType.Char).Value = p_CPERACTIF

      'akout colone pour id tmp
      Dim ColAutoInc As DataColumn = New DataColumn
      ColAutoInc.DataType = System.Type.GetType("System.Int32")
      ColAutoInc.ColumnName = "IDTMP"
      With ColAutoInc
        .AutoIncrement = True
        .AutoIncrementSeed = 0
        .AutoIncrementStep = 1
      End With

      dtForm.Columns.Add(ColAutoInc)

      dtForm.Load(sqlcmd.ExecuteReader)

      Return dtForm

    Catch ex As Exception

      MessageBox.Show("ListeFormation dans CFormation : " + ex.Message)
      Return Nothing

    End Try

  End Function

  'Public Sub AddNewLine()

  '	Try

  '		Dim oFrmGTPNewEquip As New frmGTPNewEquipement(dtForm)
  '		oFrmGTPNewEquip.ShowDialog()


  '	Catch ex As Exception
  '		MessageBox.Show(ex.Message)
  '	End Try

  'End Sub

  'Public Sub SuppLine(ByVal p_NIDTMP As Int32)

  '	dtForm.Select("IDTMP=" + p_NIDTMP.ToString)(0).Delete()

  'End Sub

  'Public Sub SaveGTPEquip()

  '	Try

  '		Dim ODtSupprLine As DataTable = dtForm.GetChanges(DataRowState.Deleted)
  '		If Not ODtSupprLine Is Nothing Then
  '			ODtSupprLine.RejectChanges()
  '			'suppression des lignes supprimer dans la datable
  '			If ODtSupprLine.Rows.Count > 0 Then
  '				For Each oRowsInvSupp As DataRow In ODtSupprLine.Rows
  '					SupprLigneGTPEquip(oRowsInvSupp)
  '				Next
  '			End If
  '		End If

  '		dtForm.AcceptChanges()
  '		'sauvegarde des lignes inventaires
  '		If dtForm.Rows.Count > 0 Then
  '			For Each oRowsInv As DataRow In dtForm.Rows
  '				SaveLigneGTPEquip(oRowsInv)
  '			Next
  '		End If

  '		ListeFormation()

  '	Catch ex As Exception
  '		MessageBox.Show(ex.Message)
  '	End Try

  'End Sub

  'Private Sub SaveLigneGTPEquip(ByVal oRowsSavTemp As DataRow)

  '	Try

  '		Dim sqlcmdCreateLigne As New SqlCommand("api_sp_GTPEquipCreateLigne", oGestConnectSQL.CnxSQLOpen)
  '		sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
  '		sqlcmdCreateLigne.Parameters.Add("@p_NGTPMAINID", SqlDbType.Int)
  '		sqlcmdCreateLigne.Parameters("@p_NGTPMAINID").Value = oRowsSavTemp.Item("NGTPMAINID")
  '		sqlcmdCreateLigne.Parameters.Add("@p_NGTPLOTID", SqlDbType.Int)
  '		sqlcmdCreateLigne.Parameters("@p_NGTPLOTID").Value = oRowsSavTemp.Item("NGTPLOTID")
  '		sqlcmdCreateLigne.Parameters.Add("@p_VGTPEQUIP", SqlDbType.varchar)
  '		sqlcmdCreateLigne.Parameters("@p_VGTPEQUIP").Value = oRowsSavTemp.Item("VGTPEQUIP")
  '		sqlcmdCreateLigne.Parameters.Add("@p_VGTPPRECIS", SqlDbType.varchar)
  '		sqlcmdCreateLigne.Parameters("@p_VGTPPRECIS").Value = oRowsSavTemp.Item("VGTPPRECIS")
  '		sqlcmdCreateLigne.Parameters.Add("@p_NGTPUNITEID", SqlDbType.int)
  '		sqlcmdCreateLigne.Parameters("@p_NGTPUNITEID").Value = oRowsSavTemp.Item("NGTPUNITEID")
  '		sqlcmdCreateLigne.Parameters.Add("@p_NGTPCOUTUNIT", SqlDbType.Decimal)
  '		sqlcmdCreateLigne.Parameters("@p_NGTPCOUTUNIT").Value = oRowsSavTemp.Item("NGTPCOUTUNIT")
  '		sqlcmdCreateLigne.Parameters.Add("@p_NGTPDURVIE", SqlDbType.int)
  '		sqlcmdCreateLigne.Parameters("@p_NGTPDURVIE").Value = oRowsSavTemp.Item("NGTPDURVIE")

  '		sqlcmdCreateLigne.ExecuteNonQuery()

  '	Catch ex As Exception
  '		MessageBox.Show(ex.Message)
  '	End Try

  'End Sub

  'Private Sub SupprLigneGTPEquip(ByVal oRowsSupprTemp As DataRow)

  '	Try

  '		If oRowsSupprTemp.Item("NCLINUM") > 0 Then

  '			Dim sqlcmdSupprLigne As New SqlCommand("api_sp_GTPEquipSupprLigne", oGestConnectSQL.CnxSQLOpen)
  '			sqlcmdSupprLigne.CommandType = CommandType.StoredProcedure
  '			sqlcmdSupprLigne.Parameters.Add("@P_NGTPMAINID", SqlDbType.Int)
  '			sqlcmdSupprLigne.Parameters("@P_NGTPMAINID").Value = oRowsSupprTemp.Item("NGTPMAINID")

  '			sqlcmdSupprLigne.ExecuteNonQuery()

  '		End If

  '	Catch ex As Exception
  '		MessageBox.Show(ex.Message)
  '	End Try

  'End Sub

End Class
