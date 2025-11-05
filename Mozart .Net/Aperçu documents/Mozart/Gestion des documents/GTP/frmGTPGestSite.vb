Public Class frmGTPGestSite

    Dim oGTPGestSit As CGTPGESTSIT

    Private Sub frmGTPGestClient_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load

        oGTPGestSit = New CGTPGESTSIT
        
        GCGTPGESTSIT.DataSource = oGTPGestSit.ListeGTPSite 

    End Sub

    Private Sub BtnQuit_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnQuit.Click

        Me.Close 
        
    End Sub

    Private Sub BtnAddLine_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnAddLine.Click

        Dim oGestSelectSite As New frmGTPSelectionClientSite 
        oGestSelectSite.ShowDialog

        GCGTPGESTSIT.DataSource = oGTPGestSit.ListeGTPSite

    End Sub

    Private Sub BtnSupprLine_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnSupprLine.Click

        'If GVGTPGESTSIT.SelectedRowsCount > 0 Then
        '    'si handle row est inférieur à 0 alors elle ne fait pas partir de la datatable
        '    If GVGTPGESTSIT.GetSelectedRows(0) < 0 Then
        '        MessageBox.Show("Il faut sélectionner un client", "Suppression client", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Return
        '    End If
        'Else
        '    MessageBox.Show("Il faut sélectionner un client", "Suppression client", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Return
        'End If
            
        ''mise à jour de la datatable
        'If MessageBox.Show("Voulez-vous vraiment supprimer ce client ?", "Confirmation suppression", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

        '    oGTPGestSit.SuppLineGTPClient(GVGTPGESTCLI.GetDataRow(GVGTPGESTCLI.GetSelectedRows(0)).Item("IDTMP"))

        'End If

    End Sub

    Private Sub BtnModifier_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnModifier.Click

        If GVGTPGESTSIT.SelectedRowsCount > 0 then

            Dim ofrmGTPSite As New frmGTPSite(GVGTPGESTSIT.GetDataRow(GVGTPGESTSIT.GetSelectedRows(0)).Item("NCLINUM"), GVGTPGESTSIT.GetDataRow(GVGTPGESTSIT.GetSelectedRows(0)).Item("VCLINOM"), GVGTPGESTSIT.GetDataRow(GVGTPGESTSIT.GetSelectedRows(0)).Item("NSITNUM"), GVGTPGESTSIT.GetDataRow(GVGTPGESTSIT.GetSelectedRows(0)).Item("VSITNOM"))
            ofrmGTPSite.ShowDialog

        Else
            MessageBox.Show(My.Resources.Aperçu_frmGTPGestClient_select_client, My.Resources.Aperçu_frmGTPGestClient_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub BtnSave_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnSave.Click

        'oGTPGestSit.SaveGTPClient 

    End Sub

    Private Sub BtnAudit_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnAudit.Click

        Dim ofrmGTPAUDIT As New frmGTPAudit(GVGTPGESTSIT.GetDataRow(GVGTPGESTSIT.GetSelectedRows(0)).Item("NSITNUM"), GVGTPGESTSIT.GetDataRow(GVGTPGESTSIT.GetSelectedRows(0)).Item("VSITNOM"), GVGTPGESTSIT.GetDataRow(GVGTPGESTSIT.GetSelectedRows(0)).Item("VCLINOM"))
        ofrmGTPAUDIT.ShowDialog

    End Sub

End Class