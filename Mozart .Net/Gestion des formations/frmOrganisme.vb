Public Class frmOrganisme

	Dim oGestOrg As CORGANISME

	Private Sub frmOrganisme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		oGestOrg = New CORGANISME

		GCORGANISME.DataSource = oGestOrg.ListeOrganisme

	End Sub

	Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click

		Me.Close()

	End Sub

	Private Sub frmfrmOrganisme_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

		Try

			If (Not oGestOrg.p_dtORG.GetChanges Is Nothing AndAlso oGestOrg.p_dtORG.GetChanges.Rows.Count > 0) Then

                Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.Global_modif_confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

                    Case vbYes
                        BtnSave.PerformClick()
                        Me.Close()
                    Case vbCancel
                        e.Cancel = True
                    Case Else
                        e.Cancel = False

                End Select

            End If

		Catch ex As Exception

			MessageBox.Show(ex.Message)

		End Try

	End Sub

	Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

		Try

			oGestOrg.SaveOrg()

			GCORGANISME.DataSource = oGestOrg.ListeOrganisme

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try

	End Sub

	Private Sub BtnAddLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddLine.Click
		Try

			oGestOrg.AddNewLineORG()

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub

	Private Sub BtnSupprLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupprLine.Click

		Try

			If GVORGANISME.SelectedRowsCount > 0 Then
				'si handle row est inférieur à 0 alors elle ne fait pas partir de la datatable
				If GVORGANISME.GetSelectedRows(0) < 0 Then
                    MessageBox.Show(My.Resources.Global_selectionner_une_ligne, My.Resources.Global_suppression_organisme, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
				End If
			Else
                MessageBox.Show(My.Resources.Global_selectionner_une_ligne, My.Resources.Global_suppression_organisme, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
			End If

            'mise à jour de la datatable
            If MessageBox.Show(My.Resources.Global_supprimer_organisme_message, My.Resources.Global_confirmation_suppression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

                If oGestOrg.ReturnSuppressionOK(GVORGANISME.GetDataRow(GVORGANISME.GetSelectedRows(0)).Item("NORGNUM")) = 0 Then
                    oGestOrg.SuppLineORG(GVORGANISME.GetDataRow(GVORGANISME.GetSelectedRows(0)).Item("IDTMP"))
                Else
                    MessageBox.Show(My.Resources.GestionDesFormation_frmOrganisme_supp_impo, My.Resources.Global_confirmation_suppression, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            End If

        Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try

	End Sub

End Class