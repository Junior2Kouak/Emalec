Imports MozartLib

Public Class frmGTPGestion

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub BtnGTPEMALEC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGTPEMALEC.Click

    Dim ofrmGTPEquip As New frmGTPEquip
    ofrmGTPEquip.ShowDialog()

  End Sub

  Private Sub BtnGTPClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGTPClient.Click

    Dim ofrmGTPGestClient As New frmGTPGestClient
    ofrmGTPGestClient.ShowDialog()

  End Sub

  Private Sub frmGTPGestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ' TB SAMSIC CITY RES
    BtnGTPEMALEC.Text += MozartParams.NomGroupe

  End Sub

  Private Sub BtnGTPSite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGTPSite.Click

    Dim ofrmGTPGestSite As New frmGTPGestSite
    ofrmGTPGestSite.ShowDialog()

  End Sub

End Class