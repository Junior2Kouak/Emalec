Public Class UCContactSTF

    Private Sub UCContactSTF_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'INIT
        TxtINTNom.Text = My.Resources.WizardSTF_UCContactSTF_Expr1

    End Sub

    Private Sub TxtINTNom_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles TxtINTNom.EditValueChanged
        If TxtINTNom.Text <> "" Then TxtINTNom.BackColor = Color.White
    End Sub

    Private Sub TxtINTTel_LostFocus(sender As Object, e As System.EventArgs) Handles TxtINTTel.LostFocus
        If TxtINTTel.Text.Length > 2 AndAlso TxtINTTel.Text.Substring(0, 2) <> "00" And IsNumeric(TxtINTTel.Text) = True Then TxtINTTel.Text = formatPhoneNumber(TxtINTTel.Text, "0# ## ## ## ##").Replace(" ", ".")
    End Sub

    Private Sub TxtINTFax_LostFocus(sender As Object, e As System.EventArgs) Handles TxtINTFax.LostFocus
        If TxtINTFax.Text.Length > 2 AndAlso TxtINTFax.Text.Substring(0, 2) <> "00" And IsNumeric(TxtINTFax.Text) = True Then TxtINTFax.Text = formatPhoneNumber(TxtINTFax.Text, "0# ## ## ## ##").Replace(" ", ".")
    End Sub

    Private Sub TxtINTPort_LostFocus(sender As Object, e As System.EventArgs) Handles TxtINTPort.LostFocus
        If TxtINTPort.Text.Length > 2 AndAlso TxtINTPort.Text.Substring(0, 2) <> "00" And IsNumeric(TxtINTPort.Text) = True Then TxtINTPort.Text = formatPhoneNumber(TxtINTPort.Text, "0# ## ## ## ##").Replace(" ", ".")
    End Sub

    Private Sub TxtINTAstr_LostFocus(sender As Object, e As System.EventArgs) Handles TxtINTAstr.LostFocus
        If TxtINTAstr.Text.Length > 2 AndAlso TxtINTAstr.Text.Substring(0, 2) <> "00" And IsNumeric(TxtINTAstr.Text) = True Then TxtINTAstr.Text = formatPhoneNumber(TxtINTAstr.Text, "0# ## ## ## ##").Replace(" ", ".")
    End Sub

    Private Sub TxtINTPrenom_LostFocus(sender As Object, e As System.EventArgs) Handles TxtINTPrenom.LostFocus

        If TxtINTPrenom.Text <> "" Then
            TxtINTPrenom.Text = TxtINTPrenom.Text.TrimStart
            TxtINTPrenom.Text = TxtINTPrenom.Text.Substring(0, 1).ToUpper + TxtINTPrenom.Text.Substring(1, TxtINTPrenom.Text.Length - 1)
        End If

    End Sub

    Private Sub TxtINTMail_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtINTMail.TextChanged
        If TxtINTMail.Text <> "" Then TxtINTMail.BackColor = Color.White
    End Sub

    Private Sub TxtINTTel_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtINTTel.TextChanged
        If TxtINTTel.Text <> "" Then TxtINTTel.BackColor = Color.White
    End Sub
End Class
