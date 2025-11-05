Public Class UCQSE
  Private Sub UCQSE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub chkFO_CheckedChanged(sender As Object, e As EventArgs) Handles chkFO.CheckedChanged

    If (chkFO.Checked) Then
      For Each c In GBON.Controls
        If TypeOf c Is CheckBox Then
          c.Checked = False
          c.Enabled = False
        End If
      Next
    Else
      For Each c In GBON.Controls
        If TypeOf c Is CheckBox Then
          c.Checked = False
          c.Enabled = True
        End If
      Next
    End If

  End Sub

  Private Sub chk_CheckedChanged(sender As Object, e As EventArgs) Handles chkO3.CheckedChanged, chkO2.CheckedChanged, chkO1.CheckedChanged, chkN3.CheckedChanged, chkN2.CheckedChanged, chkN1.CheckedChanged
    Dim nom As String = sender.Name

    If (CType(sender, CheckBox).Checked) Then
      Select Case nom
        Case "chkO1"
          chkN1.Checked = False
        Case "chkO2"
          chkN2.Checked = False
        Case "chkO3"
          chkN3.Checked = False
        Case "chkN1"
          chkO1.Checked = False
        Case "chkN2"
          chkO2.Checked = False
        Case "chkN3"
          chkO3.Checked = False
      End Select
    End If
  End Sub
End Class
