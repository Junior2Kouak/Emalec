

Public Class frmGTPSelectionClientSite
    
    Dim oGTPSite As CGTPSIT 
    Dim oGTPEmalec As CGTPEQUIP 

    Private Sub frmGTPSelectionClientSite_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load
                    
        oGTPSite = New CGTPSIT
        
        'on charge la combo client
        CboClient.DataSource = oGTPSite.ListeClientCbo

    End Sub

    Private Sub BtnOk_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnOk.Click
        
        Dim ofrmGTPSite As New frmGTPSite(CboClient.SelectedValue, CboClient.Text, CboSite.SelectedValue, CboSite.Text)
        ofrmGTPSite.ShowDialog
        Me.Close 

    End Sub

    Private Sub CboClient_SelectedIndexChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles CboClient.SelectedIndexChanged

        CboSite.DataSource = oGTPSite.ListeSiteCbo(CboClient.SelectedValue)
        
    End Sub

    Private Sub BtnCancel_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnCancel.Click

        Me.Close 

    End Sub

End Class