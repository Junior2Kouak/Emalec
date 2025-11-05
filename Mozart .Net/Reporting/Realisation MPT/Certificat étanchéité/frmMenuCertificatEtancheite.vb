Public Class frmMenuCertificatEtancheite
    Private Sub BtnListeCtrlEtanch_Click(sender As Object, e As EventArgs) Handles BtnListeCtrlEtanch.Click
        Dim ofrmListeCtrlEtanch As New frmListeCtrlEtanch()
        ofrmListeCtrlEtanch.ShowDialog()
    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnPlanningCtrlEtanch_Click(sender As Object, e As EventArgs) Handles BtnPlanningCtrlEtanch.Click
        Dim ofrmCtrlEtanchPeriodicite As New frmCtrlEtanchPeriodicite()
        ofrmCtrlEtanchPeriodicite.ShowDialog()
    End Sub
End Class