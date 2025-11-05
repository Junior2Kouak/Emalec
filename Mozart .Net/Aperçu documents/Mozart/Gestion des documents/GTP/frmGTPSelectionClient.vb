Public Class frmGTPSelectionClient
    
    Private Sub frmGTPSelectionClient_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oGestGTPClient As New CGTPClient 
        
        'charge lac ombo client
        CboClient.DataSource = oGestGTPClient.ListeClientCbo

        If oGestGTPClient.ListeClientCbo.Rows.Count = 0 Then BtnOk.Enabled = False 
           
    End Sub

    Private Sub BtnCancel_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close 
    End Sub

    Private Sub BtnOk_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnOk.Click

        'ajout du client en gestion de GTP
        'Dim oSQLCmd As New sqlcommand("", cnx)
        
        Dim ofrmGTPClient As New frmGTPClient(CboClient.SelectedValue, CboClient.Text)
        ofrmGTPClient.ShowDialog
        Me.Close

    End Sub

    Private Shared Sub SaveClientGTP()

        '

    End Sub


End Class