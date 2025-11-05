Public Class frmGTPGestClient

    Dim oGTPGestCli As CGTPGESTCLI 

    Private Sub frmGTPGestClient_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load

        oGTPGestCli = New CGTPGESTCLI
        
        GCGTPGESTCLI.DataSource = oGTPGestCli.ListeGTPClient 

    End Sub

    Private Sub BtnQuit_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnQuit.Click

        Me.Close 
        
    End Sub

    Private Sub BtnAddLine_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnAddLine.Click

        Dim oGestSelectCli As New frmGTPSelectionClient 
        oGestSelectCli.ShowDialog

        GCGTPGESTCLI.DataSource = oGTPGestCli.ListeGTPClient

    End Sub

    Private Sub BtnSupprLine_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnSupprLine.Click

        'If GVGTPGESTCLI.SelectedRowsCount > 0 Then
        '    'si handle row est inférieur à 0 alors elle ne fait pas partir de la datatable
        '    If GVGTPGESTCLI.GetSelectedRows(0) < 0 Then
        '        MessageBox.Show("Il faut sélectionner un client", "Suppression client", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Return
        '    End If
        'Else
        '    MessageBox.Show("Il faut sélectionner un client", "Suppression client", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Return
        'End If
            
        ''mise à jour de la datatable
        'If MessageBox.Show("Voulez-vous vraiment supprimer ce client ?", "Confirmation suppression", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

        '    oGTPGestCli.SuppLineGTPClient(GVGTPGESTCLI.GetDataRow(GVGTPGESTCLI.GetSelectedRows(0)).Item("IDTMP"))

        'End If

    End Sub

    Private Sub BtnModifier_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnModifier.Click

        If GVGTPGESTCLI.SelectedRowsCount > 0 then

            Dim ofrmGTPClient As New frmGTPClient(GVGTPGESTCLI.GetDataRow(GVGTPGESTCLI.GetSelectedRows(0)).Item("NCLINUM"), GVGTPGESTCLI.GetDataRow(GVGTPGESTCLI.GetSelectedRows(0)).Item("VCLINOM"))
            ofrmGTPClient.ShowDialog

        Else
            MessageBox.Show(My.Resources.Aperçu_frmGTPGestClient_select_client, My.Resources.Aperçu_frmGTPGestClient_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub BtnSave_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnSave.Click

        'oGTPGestCli.SaveGTPClient 

    End Sub

End Class