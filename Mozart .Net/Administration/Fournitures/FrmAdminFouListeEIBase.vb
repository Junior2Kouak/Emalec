Imports System.Data.SqlClient
Imports MozartLib

Public Class FrmAdminFouListeEIBase

  Dim oSqlConn As New CGestionSQL
  Dim dtListeFou As DataTable
  Dim dtListeFouBase As DataTable

  Private Sub FrmAdminFouListeEIBase_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    oSqlConn.CloseConnexionSQL()

  End Sub

  Private Function ChangesDetected() As DialogResult

    Try

      'on teste si il y eu des modifs questions non enregistrer.
      If Not dtListeFouBase Is Nothing AndAlso Not dtListeFouBase.GetChanges Is Nothing Then

        If dtListeFouBase.GetChanges.Rows.Count > 0 Then

          Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.Admin_frmAdminFouListeElBase_mozart, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

            Case DialogResult.Yes
              BtnSave.PerformClick()
              Return DialogResult.Yes
            Case DialogResult.Cancel
              Return DialogResult.Cancel
            Case Else
              Return DialogResult.No
          End Select

        Else

          Return DialogResult.No

        End If

      Else

        Return DialogResult.No

      End If

    Catch ex As Exception

      MessageBox.Show(ex.Message)
      Return DialogResult.Cancel

    End Try

  End Function

  Private Sub FrmAdminFouListeEIBase_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    ChangesDetected()

  End Sub

  Private Sub FrmAdminFouListeEIBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    If oSqlConn.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

      LoadListeFournitureEI()
      LoadListeFournitureBaseEI()

    End If

  End Sub

  Private Sub LoadListeFournitureEI()

    Try

      'parametres NCFOCOD : 31 = EI EXTINCTEUR
      Dim sRequete As String = "api_sp_ListeFournituresBySerie 31"

      dtListeFou = New DataTable
      dtListeFou = ModDataGridView.LoadList(sRequete, oSqlConn.CnxSQLOpen)
      GCListeFouEI.DataSource = dtListeFou

      GrpListe.Text = String.Format(My.Resources.Admin_frmAdminFouListeElBase_liste, dtListeFou.Rows.Count)

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub LoadListeFournitureBaseEI()

    Try

      Dim sRequete As String = "api_sp_ListeFournituresEIBase"

      dtListeFouBase = New DataTable
      dtListeFouBase = ModDataGridView.LoadListWithIncrementAuto(sRequete, oSqlConn.CnxSQLOpen)
      GCListeFouEIBase.DataSource = dtListeFouBase

      GrpListFouEIBase.Text = String.Format(My.Resources.Admin_frmAdminFouListeElBase_listeref, dtListeFouBase.Rows.Count)

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

    Try

      Dim ODtSupprLine As DataTable = dtListeFouBase.GetChanges(DataRowState.Deleted)

      If Not ODtSupprLine Is Nothing Then

        ODtSupprLine.RejectChanges()

        'suppression des lignes supprimer dans la datable
        If ODtSupprLine.Rows.Count > 0 Then

          For Each oRowsSupp As DataRow In ODtSupprLine.Rows

            SupprLigneFournitureBaseEI(oRowsSupp)

          Next

        End If

      End If

      dtListeFouBase.AcceptChanges()

      'sauvegarde des nouvelles lignes 
      If dtListeFouBase.Rows.Count > 0 Then

        For Each oRowsNew As DataRow In dtListeFouBase.Rows

          SaveLigneFournitureBaseEI(oRowsNew)

        Next

      End If

      'on recharge les données
      LoadListeFournitureBaseEI()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SaveLigneFournitureBaseEI(ByVal oRowsSavTemp As DataRow)

    Try

      'avant d'enregistrer on test si le fichier existe toujours
      If CType(oRowsSavTemp.Item("NFOUBASEXTID"), Integer) = 0 Then

        Dim sqlcmdCreateLigne As New SqlCommand("api_sp_CreationFournitureBaseEI", oSqlConn.CnxSQLOpen)
        sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
        sqlcmdCreateLigne.Parameters.Add("@p_nfoubasextid", SqlDbType.Int)
        sqlcmdCreateLigne.Parameters("@p_nfoubasextid").Value = oRowsSavTemp.Item("NFOUBASEXTID")
        sqlcmdCreateLigne.Parameters.Add("@P_NFOUNUM", SqlDbType.Int)
        sqlcmdCreateLigne.Parameters("@P_NFOUNUM").Value = oRowsSavTemp.Item("NFOUNUM")

        sqlcmdCreateLigne.ExecuteNonQuery()

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SupprLigneFournitureBaseEI(ByVal oRowsSupprTemp As DataRow)

    Try

      If oRowsSupprTemp.Item("NFOUBASEXTID") > 0 Then

        Dim sqlcmdSupprLigne As New SqlCommand("api_sp_SuppressionFournitureBaseEI", oSqlConn.CnxSQLOpen)
        sqlcmdSupprLigne.CommandType = CommandType.StoredProcedure
        sqlcmdSupprLigne.Parameters.Add("@P_NFOUBASEXTID", SqlDbType.Int)
        sqlcmdSupprLigne.Parameters("@P_NFOUBASEXTID").Value = oRowsSupprTemp.Item("NFOUBASEXTID")

        sqlcmdSupprLigne.ExecuteNonQuery()

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub BtnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAjouter.Click

    Try

      If GVlisteFouEI.SelectedRowsCount > 0 Then

        'selection de la datarow référence
        Dim oDataRowRef As DataRow = GVlisteFouEI.GetDataRow(GVlisteFouEI.GetSelectedRows(0))

        If IsFouExistInBase(oDataRowRef.Item("NFOUNUM")) = False Then

          Dim oNewRow As DataRow = dtListeFouBase.NewRow

          oNewRow.Item("NFOUBASEXTID") = 0
          oNewRow.Item("NFOUNUM") = oDataRowRef.Item("NFOUNUM")
          oNewRow.Item("VSSCFOLIB") = oDataRowRef.Item("VSSCFOLIB")
          oNewRow.Item("VFOUMAT") = oDataRowRef.Item("VFOUMAT")
          oNewRow.Item("VFOUMAR") = oDataRowRef.Item("VFOUMAR")
          oNewRow.Item("VFOUTYP") = oDataRowRef.Item("VFOUTYP")
          oNewRow.Item("VFOUREF") = oDataRowRef.Item("VFOUREF")
          oNewRow.Item("CFOUACTIF") = "O"

          dtListeFouBase.Rows.Add(oNewRow)

          GrpListFouEIBase.Text = String.Format(My.Resources.Admin_frmAdminFouListeElBase_listeref, dtListeFouBase.Rows.Count)

        Else

          MessageBox.Show(My.Resources.Admin_frmAdminFouListeElBase_fourniture_existe_deja, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

      Else

        MessageBox.Show(My.Resources.Admin_frmAdminFouListeElBase_Selectionner_fourniture, My.Resources.Admin_frmAdminFouListeElBase_Selectionner, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Function IsFouExistInBase(ByVal p_NFOUNUM As Int32) As Boolean

    Try

      Dim bFouExist As Boolean = False

      For Each oRowExist As DataRow In dtListeFouBase.Rows

        If oRowExist.Item("NFOUNUM") = p_NFOUNUM Then

          bFouExist = True
          Exit For

        End If

      Next

      Return bFouExist

    Catch ex As Exception
      MessageBox.Show(ex.Message)
      Return False
    End Try

  End Function

  Private Sub BtnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupprimer.Click

    Try

      If dtListeFouBase.Rows.Count = 0 Then
        Return
      End If

      If GVListeFouEIBase.SelectedRowsCount < 0 Then
        MessageBox.Show(My.Resources.Admin_frmAdminFouListeElBase_SelectionnerF, My.Resources.Admin_frmAdminFouListeElBase_SupFourniture, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return
      End If

      ''mise à jour de la datatable
      If MessageBox.Show(My.Resources.Admin_frmAdminFouListeElBase_SupFourniture_msg, My.Resources.Global_confirmation_suppression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

        dtListeFouBase.Select("IDTMP=" + GVListeFouEIBase.GetDataRow(GVListeFouEIBase.GetSelectedRows(0)).Item("IDTMP").ToString)(0).Delete()

        GrpListFouEIBase.Text = String.Format(My.Resources.Admin_frmAdminFouListeElBase_listeref, dtListeFouBase.Rows.Count)

      End If

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

End Class