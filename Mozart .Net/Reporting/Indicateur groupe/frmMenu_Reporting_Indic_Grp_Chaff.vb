Public Class frmMenu_Reporting_Indic_Grp_Chaff
    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnChaffProcess_Click(sender As Object, e As EventArgs) Handles BtnChaffProcess.Click

        Dim ofrmStatChefGroupeProcess As New frmStatChefGroupe(0)
        ofrmStatChefGroupeProcess.ShowDialog()
        ofrmStatChefGroupeProcess.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim ofrmStatChefGroupeFinan As New frmStatChefGroupe(1)
        ofrmStatChefGroupeFinan.ShowDialog()
        ofrmStatChefGroupeFinan.Dispose()

    End Sub
End Class