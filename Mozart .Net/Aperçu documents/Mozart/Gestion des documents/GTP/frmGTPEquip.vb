Imports System.Data.SqlClient   

Public Class frmGTPEquip
    
    Dim oGTPLot As CGTPLOT 
    Dim oGTPUnite As CGTPUNITE 
    Dim oGTPEQUIP As CGTPEQUIP
    
    Private dragVisibleIndex As Integer = -1
    Private dragAbsIndex As Integer = -1

    Private Sub frmGTPEquip_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            

            oGTPLot = New CGTPLOT
            oGTPUnite = New CGTPUNITE
            oGTPEQUIP = New CGTPEQUIP()                               

            RepItemGLUpEditGTPLot.DataSource = oGTPLot.ListeGTPLot
            RepItemGLUpEditUnite.DataSource = oGTPUnite.ListeGTPUnite  

            GCGTPEMALEC.DataSource = oGTPEQUIP.ListeGTPEquip

            Label1.Text = Me.Text 
            
        Catch ex As Exception

            MessageBox.Show(My.Resources.Aperçu_frmGTPEquip_SubLoad + ex.Message, My.Resources.Global_Erreur)

        End Try

    End Sub

    Private Sub BtnQuit_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnQuit.Click

        Me.close

    End Sub

    Private Sub frmGTPEquip_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try

            If (Not oGTPEQUIP.p_dtGTPEquip.GetChanges Is Nothing AndAlso oGTPEQUIP.p_dtGTPEquip.GetChanges.Rows.Count > 0) Then

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

            oGTPEQUIP.SaveGTPEquip
           
            GCGTPEMALEC.DataSource = oGTPEQUIP.ListeGTPEquip

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnAddLine_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnAddLine.Click
        Try

            oGTPEQUIP.AddNewLineGTPEquip            

            GVGTPEMALEC.SelectRow(GVGTPEMALEC.RowCount)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnSupprLine_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnSupprLine.Click

        Try

            If GVGTPEMALEC.SelectedRowsCount > 0 Then
                'si handle row est inférieur à 0 alors elle ne fait pas partir de la datatable
                If GVGTPEMALEC.GetSelectedRows(0) < 0 Then
                    MessageBox.Show(My.Resources.Global_select_equipement, My.Resources.Global_Suppression_equipement, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
            Else
                MessageBox.Show(My.Resources.Global_select_equipement, My.Resources.Global_Suppression_equipement, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            'mise à jour de la datatable
            If MessageBox.Show(My.Resources.Global_supression_equipement_msg, My.Resources.Global_confirmation_suppression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

                oGTPEQUIP.SuppLineGTPEquip(GVGTPEMALEC.GetDataRow(GVGTPEMALEC.GetSelectedRows(0)).Item("IDTMP"))

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnGestLot_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnGestLot.Click

        Try

            Dim oFrmGestLot As New frmGTPLot
            oFrmGestLot.ShowDialog()

            'mise à jour de la combo
            RepItemGLUpEditGTPLot.DataSource = oGTPLot.ListeGTPLot

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnGestUnite_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnGestUnite.Click

        Try

            Dim oFrmGestUnite As New frmGTPUnite
            oFrmGestUnite.ShowDialog()

            'mise à jour de la combo
            RepItemGLUpEditUnite.DataSource = oGTPUnite.ListeGTPUnite

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnGestZone_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnGestZone.Click

        Try

            Dim oFrmGestZone As New frmGTPZone
            oFrmGestZone.ShowDialog()
            
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class
