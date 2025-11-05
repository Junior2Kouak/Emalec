Public Class FrmBrowser

    Public StartingAddress As String
    Public sStatutForm As String

    Private WithEvents DocToPrint As New Printing.PrintDocument

    Private Sub frmBrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'WebBrowser1.Navigate(StartingAddress)
    webView21.Source = New Uri(StartingAddress)
  End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        sStatutForm = ""
        Me.Close()
    End Sub

  Private Sub FrmBrowser_Resize(sender As Object, e As EventArgs) Handles Me.Resize

    webView21.Width = Me.Width
    webView21.Height = Me.Height

  End Sub
End Class