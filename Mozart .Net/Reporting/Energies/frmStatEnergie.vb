Public Class frmStatEnergie

  Private Sub cmdGestDomTech_Click(sender As Object, e As EventArgs) Handles cmdGestDomTech.Click

    Dim ofrmListeReleveEnergieParClient As New frmListeReleveEnergieParClient()
    ofrmListeReleveEnergieParClient.ShowDialog()

  End Sub
  Private Sub cmdFermer_Click(sender As Object, e As EventArgs) Handles cmdFermer.Click
    Me.Close()
  End Sub

End Class