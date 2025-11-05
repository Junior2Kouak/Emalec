Public Class frmCommandeReapproMessageAdd
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        TxtMessage.Text = ""
        Me.Close()
    End Sub

    Private Sub BtnMessageAdd_Click(sender As Object, e As EventArgs) Handles BtnMessageAdd.Click
        Me.Close()
    End Sub
End Class