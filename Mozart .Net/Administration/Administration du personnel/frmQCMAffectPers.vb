Imports DevExpress.XtraEditors 

Public Class frmQCMAffectPers

    Dim oQCM As C_QCM

    Private Sub frmQCMAffectPers_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Not oQCM.p_dtListPersByPer is Nothing andalso Not oQCM.p_dtListPersByPer.GetChanges(DataRowState.Modified) is Nothing Then

            Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.Admin_frmQCMAffectPers_AffectationQCM, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

                Case DialogResult.Yes
                    BtnSave.PerformClick()
                    e.Cancel = False
                Case DialogResult.No
                    e.Cancel = False
                Case DialogResult.Cancel
                    e.Cancel = True
            End Select

        End If

    End Sub 

    Private Sub frmQCMAffectPers_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load

        oQCM = New C_QCM 
        
        GCListQCM.DataSource = oQCM.ListeQCM()

    End Sub

    Private Sub BtnQuit_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnQuit.Click

        Me.Close 

    End Sub

    Private Sub GVListQCM_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVListQCM.FocusedRowChanged
            

        'detect changement
        Try

            If e.PrevFocusedRowHandle > 0 AndAlso Not oQCM.p_dtListPersByPer is Nothing andalso Not oQCM.p_dtListPersByPer.GetChanges(DataRowState.Modified) is Nothing Then

                If MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.Admin_frmQCMAffectPers_AffectationQCM, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                    oQCM.SaveListPersByQCM(GVListQCM.GetDataRow(e.PrevFocusedRowHandle).Item("NIDQCMNUM"))

                End If

            End If                               

        Catch ex As Exception

            MessageBox.Show(My.Resources.Admin_frmQCMAffectPers_GVlistQCM + ex.Message)

        End Try    

        'on charge la liste du personnel en fonction du QCM
        If e.FocusedRowHandle >= 0 Then
            LblQCMSelect.Text = GVListQCM.GetDataRow(e.FocusedRowHandle).Item("VQCMTITRE")
            GCPers.DataSource = oQCM.ListePersByQCM(GVListQCM.GetDataRow(e.FocusedRowHandle).Item("NIDQCMNUM"))
        Else
            LblQCMSelect.Text = My.Resources.Admin_frmQCMAffectPers_AucunQCM
            GCPers.DataSource = Nothing
        End If


    End Sub

    Private Sub RepositoryItemCheckEditCHECK_CheckedChanged(sender As Object, e As System.EventArgs) Handles RepositoryItemCheckEditCHECK.CheckedChanged
        Dim odtr As DataRow = GVPers.GetDataRow(GVPers.GetSelectedRows(0))

        If Not odtr Is Nothing AndAlso odtr.Item("CHECK") = 1 Then

      'si test non démarrer, on peut toujours le desaffecter
      'If oQCM.QCMEnCours(odtr.Item("NPERNUM"), GVListQCM.GetDataRow(GVListQCM.GetSelectedRows(0)).Item("NIDQCMNUM")) = True Then
      'sinon on force le check a cocher
      'CType(sender, CheckEdit).Checked = repo
      odtr.Item("CHECK") = If(CType(sender, CheckEdit).Checked = True, 1, 0)
      '   End If

    End If
        GVPers.PostEditor()
        GCPers.Refresh()
    End Sub

    Private Sub RepositoryItemCheckEditCHECK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEditCHECK.Click

        Try

            'Dim odtr As DataRow = GVPers.GetDataRow(GVPers.GetSelectedRows(0))

            'If Not odtr Is Nothing AndAlso odtr.Item("CHECK") = 1 Then

            '    CType(sender, CheckEdit).Checked = True
            '    odtr.Item("CHECK") = 1

            'End If
           
            ''odtr.Item("NPERNUM") and  and 
            ''si la case est decoche, on test si un qcm est en cours (date de debut renseigne), si c'est le cas on demande une confirmation de decoche ce qui supprimera le questionnaire
            'If Not odtr Is Nothing AndAlso odtr.Item("CHECK") = 1 AndAlso oQCM.QCMEnCours(odtr.Item("NPERNUM"), GVListQCM.GetDataRow(GVListQCM.GetSelectedRows(0)).Item("NIDQCMNUM")) = True Then

            '    Dim sMessage As String = String.Format("{0} a démarré ce test mais ne l'a pas terminé." + vbCrLf + "Voulez-vous vraiment supprimer ce test ?", odtr.Item("VPERNOM"))

            '    If MessageBox.Show(sMessage, "Confirmation suppression", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

            '        CType(sender, CheckEdit).Checked = False
            '        odtr.Item("CHECK") = 0

            '    Else

            '        CType(sender, CheckEdit).Checked = True
            '        odtr.Item("CHECK") = 1

            '    End If

            'End If

        Catch ex As Exception

            MessageBox.Show(My.Resources.Admin_frmQCMAffectPers_Repository + ex.Message)

        End Try

    End Sub

    Private Sub BtnSave_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnSave.Click

        Me.Cursor = Cursors.WaitCursor
        oQCM.SaveListPersByQCM(GVListQCM.GetDataRow(GVListQCM.GetSelectedRows(0)).Item("NIDQCMNUM"))
        Me.Cursor = Cursors.Default

        'refresh
        GCPers.DataSource = oQCM.ListePersByQCM(GVListQCM.GetDataRow(GVListQCM.GetSelectedRows(0)).Item("NIDQCMNUM"))

    End Sub

    Private Sub BtnCoche_Click(sender As System.Object, e As System.EventArgs) Handles BtnCoche.Click

        CocherAllFilterTous_Or_DecocheAllFilter(oQCM.p_dtListPersByPer, "CHECK", GVPers.ActiveFilterCriteria, True)
        GCPers.Refresh()

    End Sub

    Private Sub BtnDecoche_Click(sender As System.Object, e As System.EventArgs) Handles BtnDecoche.Click

        CocherAllFilterTous_Or_DecocheAllFilter(oQCM.p_dtListPersByPer, "CHECK", GVPers.ActiveFilterCriteria, False)
        GCPers.Refresh()
    End Sub

    Private Sub GVPers_CustomDrawFooter(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GVPers.CustomDrawFooter

        Dim oPos As Rectangle = e.Bounds
        Dim oFormat As New StringFormat
        Dim iNbPerSelected As Int32 = 0

        oPos.Location = New Point(oPos.Left + 1, oPos.Top + 1)
        oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)

        oFormat.Alignment = StringAlignment.Center

        Dim dttemp As DataTable = GCPers.DataSource

        If dttemp Is Nothing Then Return

        For Each odrtemp As DataRow In dttemp.Rows

            If odrtemp.Item("CHECK") = 1 Then
                iNbPerSelected = iNbPerSelected + 1
            End If

        Next

        e.Appearance.DrawString(e.Cache, String.Format(My.Resources.Global_NbrPersonne, iNbPerSelected, oQCM.p_dtListPersByPer.Rows.Count), oPos, oFormat)
        e.Handled = True

    End Sub

End Class