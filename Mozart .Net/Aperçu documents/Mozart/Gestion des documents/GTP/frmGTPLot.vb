Public Class frmGTPLot

    Dim oGestGTPLot As CGTPLOT
    
    Private Sub frmGTPLot_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load

        oGestGTPLot = New CGTPLOT 

        GCGTPLOT.DataSource = oGestGTPLot.ListeGTPLot 

    End Sub

    Private Sub BtnQuit_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnQuit.Click

        Me.Close 

    End Sub
    
    Private Sub frmGTPLot_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try

            If (Not oGestGTPLot.p_dtGTPLot.GetChanges Is Nothing AndAlso oGestGTPLot.p_dtGTPLot.GetChanges.Rows.Count > 0) Then

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
            
            oGestGTPLot.SaveGTPLot
           
            GCGTPLOT.DataSource = oGestGTPLot.ListeGTPLot

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnAddLine_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnAddLine.Click
        Try

            oGestGTPLot.AddNewLineGTPLot

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnSupprLine_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnSupprLine.Click

        Try

            If GVGTPLOT.SelectedRowsCount > 0 Then
                'si handle row est inférieur à 0 alors elle ne fait pas partir de la datatable
                If GVGTPLOT.GetSelectedRows(0) < 0 Then
                    MessageBox.Show(My.Resources.Global_select_lot, My.Resources.Global_suppression_lot, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
            Else
                MessageBox.Show(My.Resources.Global_select_lot, My.Resources.Global_suppression_lot, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            'mise à jour de la datatable
            If MessageBox.Show(My.Resources.Global_suppression_lot_msg, My.Resources.Global_confirmation_suppression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

                If oGestGTPLot.ReturnSuppressionOK(GVGTPLOT.GetDataRow(GVGTPLOT.GetSelectedRows(0)).Item("NGTPLOTID")) = 0 Then
                    oGestGTPLot.SuppLineGTPLot(GVGTPLOT.GetDataRow(GVGTPLOT.GetSelectedRows(0)).Item("IDTMP"))
                Else
                    MessageBox.Show(My.Resources.Aperçu_frmGtpLot_suppression_impossible & vbCrLf & oGestGTPLot.p_sLISTGTPEQUIPError, My.Resources.Global_confirmation_suppression, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class