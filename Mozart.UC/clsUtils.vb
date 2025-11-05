Imports System.Windows.Forms
Imports MozartLib

Public Class Utils

  Private Declare Sub keybd_event Lib "user32.dll" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As UInteger, ByVal dwExtraInfo As UIntPtr)

  Public Shared gstrNomPoste As String
  Public Shared gstrSociete As String
  Public Shared gintUID As Long
  Public Shared gintTEL As Long


  Public Shared bDialOK As Boolean
  Shared Function PhoneCall(telNumber As String) As Boolean
    ' 3 cas possibles
    ' -	1 : en utilisant l’outil l'outil ISICOM si disponible sur le poste (IsiPCB.exe)
    ' -	2 : Si pas possible, en utilisant l’outil AVAYA si disponible sur le poste (AvayaCallAssistant.exe)
    ' -	3 : sinon via TAPI

    Try
      Cursor.Current = Cursors.WaitCursor
      bDialOK = False
      If IsProcessIsRunning("IsiPCB") Then
        MakePhoneCallISICOM(telNumber)
        bDialOK = True
        'ElseIf IsProcessIsRunning("AvayaCallAssistant") Then
        '  MakePhoneCallAVAYA(telNumber)
      Else
        'MakePhoneCallTAPI(telNumber)
      End If
      Return bDialOK

    Catch ex As Exception
      MessageBox.Show("Erreur TAPI : " & ex.Message & " - " & ex.StackTrace)
      Return False
    End Try
    Cursor.Current = Cursors.Default

  End Function

  Shared Sub MakePhoneCallISICOM(numero As String)
    Dim Cti As New CtiServerConnector.Control

    Cti.Connect("srv-vmisicom", 5110, MozartParams.UserTelInt)
    ' And register Agent After : Attention avec le Kit CTI, l'agent a utiliser est le "102"

    Cti.MakeCall(numero)
  End Sub

  Private Shared Function IsProcessIsRunning(process As String) As Boolean
    Return (Diagnostics.Process.GetProcessesByName(process).Length <> 0)
  End Function

End Class
