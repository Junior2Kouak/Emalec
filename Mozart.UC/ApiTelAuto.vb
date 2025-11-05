Imports System.Windows.Forms
Imports MozartLib

Public Class ApiTelAuto

    Public bDialOK As Boolean = False

    Public Sub TelDial(sValue As String)
        bDialOK = False
        Dial(sValue)

  End Sub

  Private Sub Dial(telNumber As String)

        bDialOK = Utils.PhoneCall(telNumber)

    End Sub

  Private Sub ApiTelAuto_Click(sender As Object, e As EventArgs) Handles imgTel.Click
    OnClick(e)
  End Sub
End Class
