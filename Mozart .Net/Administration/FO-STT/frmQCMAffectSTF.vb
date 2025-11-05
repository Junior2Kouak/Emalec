Imports DevExpress.XtraEditors

Public Class frmQCMAffectSTF

  Dim oQCM As C_QCM_STF

  Private Sub frmQCMAffectPers_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    If Not oQCM.p_dtListSTFBySTF Is Nothing AndAlso Not oQCM.p_dtListSTFBySTF.GetChanges(DataRowState.Modified) Is Nothing Then

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

  Private Sub frmQCMAffectPers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    oQCM = New C_QCM_STF

    GCListQCM.DataSource = oQCM.ListeQCM()

  End Sub

  Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click

    Me.Close

  End Sub

  Private Sub GVListQCM_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVListQCM.FocusedRowChanged


    'detect changement
    Try

      If e.PrevFocusedRowHandle > 0 AndAlso Not oQCM.p_dtListSTFBySTF Is Nothing AndAlso Not oQCM.p_dtListSTFBySTF.GetChanges(DataRowState.Modified) Is Nothing Then

        If MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.Admin_frmQCMAffectPers_AffectationQCM, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

          oQCM.SaveListSTFByQCM(GVListQCM.GetDataRow(e.PrevFocusedRowHandle).Item("NIDQCMNUM"))

        End If

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.Admin_frmQCMAffectPers_GVlistQCM + ex.Message)

    End Try

    'on charge la liste du personnel en fonction du QCM
    If e.FocusedRowHandle >= 0 Then
      LblQCMSelect.Text = GVListQCM.GetDataRow(e.FocusedRowHandle).Item("VQCMTITRE")
      GCSTF.DataSource = oQCM.ListeSTFByQCM(GVListQCM.GetDataRow(e.FocusedRowHandle).Item("NIDQCMNUM"))
    Else
      LblQCMSelect.Text = My.Resources.Admin_frmQCMAffectPers_AucunQCM
      GCSTF.DataSource = Nothing
    End If


  End Sub

  Private Sub RepositoryItemCheckEditCHECK_CheckedChanged(sender As Object, e As System.EventArgs) Handles RepositoryItemCheckEditCHECK.CheckedChanged
    Dim odtr As DataRow = GVSTF.GetDataRow(GVSTF.GetSelectedRows(0))

    If Not odtr Is Nothing AndAlso odtr.Item("CHECK") = 1 Then

      'si test non démarrer, on peut toujours le desaffecter
      If oQCM.QCMEnCours(odtr.Item("NACCNUM"), GVListQCM.GetDataRow(GVListQCM.GetSelectedRows(0)).Item("NIDQCMNUM")) = True Then
        'sinon on force le check a cocher
        CType(sender, CheckEdit).Checked = True
        odtr.Item("CHECK") = 1
      End If

    End If
    GVSTF.PostEditor()
    GCSTF.Refresh()
  End Sub

  Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

    Me.Cursor = Cursors.WaitCursor
    oQCM.SaveListSTFByQCM(GVListQCM.GetDataRow(GVListQCM.GetSelectedRows(0)).Item("NIDQCMNUM"))
    Me.Cursor = Cursors.Default

    'refresh
    GCSTF.DataSource = oQCM.ListeSTFByQCM(GVListQCM.GetDataRow(GVListQCM.GetSelectedRows(0)).Item("NIDQCMNUM"))

  End Sub

  Private Sub BtnCoche_Click(sender As System.Object, e As System.EventArgs) Handles BtnCoche.Click

    CocherAllFilterTous_Or_DecocheAllFilter(oQCM.p_dtListSTFBySTF, "CHECK", GVSTF.ActiveFilterCriteria, True)
    GCSTF.Refresh()

  End Sub

  Private Sub BtnDecoche_Click(sender As System.Object, e As System.EventArgs) Handles BtnDecoche.Click

    CocherAllFilterTous_Or_DecocheAllFilter(oQCM.p_dtListSTFBySTF, "CHECK", GVSTF.ActiveFilterCriteria, False)
    GCSTF.Refresh()
  End Sub

  Private Sub GVSTF_CustomDrawFooter(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GVSTF.CustomDrawFooter

    Dim oPos As Rectangle = e.Bounds
    Dim oFormat As New StringFormat
    Dim iNbPerSelected As Int32 = 0

    oPos.Location = New Point(oPos.Left + 1, oPos.Top + 1)
    oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)

    oFormat.Alignment = StringAlignment.Center

    Dim dttemp As DataTable = GCSTF.DataSource

    If dttemp Is Nothing Then Return

    For Each odrtemp As DataRow In dttemp.Rows

      If odrtemp.Item("CHECK") = 1 Then
        iNbPerSelected = iNbPerSelected + 1
      End If

    Next

    e.Appearance.DrawString(e.Cache, String.Format(My.Resources.Global_NbrPersonne, iNbPerSelected, oQCM.p_dtListSTFBySTF.Rows.Count), oPos, oFormat)
    e.Handled = True

  End Sub

End Class