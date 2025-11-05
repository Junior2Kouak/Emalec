Public Class frmReporting_Menu_GMTP_RMPT_Poste
    Private Sub frmReporting_Menu_GMTP_RMPT_Poste_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Initboutons(Me)

    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub
End Class