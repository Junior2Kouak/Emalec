Public Class frmGTPZone

    Dim oGestGTPZone As CGTPZone
    
    Private Sub frmGTPZone_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load

        oGestGTPZone = New CGTPZone 

        GCGTPZONE.DataSource = oGestGTPZone.ListeGTPZone

    End Sub

    Private Sub BtnQuit_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnQuit.Click

        Me.Close 

    End Sub
    
    Private Sub frmGTPZone_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try

            If (Not oGestGTPZone.p_dtGTPZone.GetChanges Is Nothing AndAlso oGestGTPZone.p_dtGTPZone.GetChanges.Rows.Count > 0) Then

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

    Private Sub BtnSave_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnSave.Click

        Try
            
            oGestGTPZone.SaveGTPZone
           
            GCGTPZONE.DataSource = oGestGTPZone.ListeGTPZone

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnAddLine_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnAddLine.Click
        Try

            oGestGTPZone.AddNewLineGTPZone

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnSupprLine_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnSupprLine.Click

        Try

            If GVGTPZONE.SelectedRowsCount > 0 Then
                'si handle row est inférieur à 0 alors elle ne fait pas partir de la datatable
                If GVGTPZONE.GetSelectedRows(0) < 0 Then
                    MessageBox.Show(My.Resources.Global_select_zone, My.Resources.Global_suppression_zone, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
            Else
                MessageBox.Show(My.Resources.Global_select_zone, My.Resources.Global_suppression_zone, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            'mise à jour de la datatable
            If MessageBox.Show(My.Resources.Global_suppression_zone_msg, My.Resources.Global_confirmation_suppression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

                If oGestGTPZone.ReturnSuppressionOK(GVGTPZONE.GetDataRow(GVGTPZONE.GetSelectedRows(0)).Item("NGTPUNITEID")) = 0 Then
                    oGestGTPZone.SuppLineGTPZone(GVGTPZONE.GetDataRow(GVGTPZONE.GetSelectedRows(0)).Item("IDTMP"))
                Else
                    MessageBox.Show(My.Resources.Aperçu_frmGTPZone_suppression_impossible, My.Resources.Global_confirmation_suppression, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class