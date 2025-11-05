Public Class FrmInfosClient

    Public strStatut As String
    Public strInfo As String

    Private Sub frmInfosClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtInfo.Text = strInfo
        Me.Text = My.Resources.Planification_FrmInfosClient_InfoSite
    End Sub

    Private Sub btnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub
End Class