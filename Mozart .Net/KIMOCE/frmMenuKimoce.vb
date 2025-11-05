Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Text
Imports MozartNet.clsKimoce
Imports MozartControls
Imports MZUtils = MozartControls.Utils
Imports MozartLib

Public Class frmMenuKimoce

  'Const cstRepData As String = "C:\Users\Paput.EMALEC\Desktop\KIMOCE\data\"
  'Const cstFichierCmd = "C:\Users\Paput.EMALEC\Desktop\KIMOCE\ClientIAS3_V5.1\exemples\scripts_win\"
  Const cstRepData As String = "\\srv-vmapps\d$\Programmes\ServeurKimoce\data\"
  Const cstFichierCmd = "\\srv-vmapps\d$\Programmes\ServeurKimoce\scripts\"


  Dim _NACTNUM As Int32
  Dim _ACTION As String

  Public Sub New(ByVal NACTNUM As Object, ByVal ACTION As String)
    InitializeComponent()

    _NACTNUM = NACTNUM
    _ACTION = ACTION

  End Sub

  Private Sub frmMenuKimoce_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ModuleMain.Initboutons(Me)

    'LogInfo("Start Kimoce.exe")

    If _NACTNUM <> 0 Then
      txtNumAction.Text = _NACTNUM
      GetInfoDI()
    End If

    Me.Visible = True

    If (Debugger.IsAttached) Then
      cmdGetDiKimoce.Visible = True
    End If

  End Sub

  Private Sub cmdGetListDI_Click(sender As Object, e As EventArgs) Handles cmdGetDiKimoce.Click

    Try

      MessageBox.Show($"Cette fonction est lancée automatiquement toutes les 15 minutes{Environment.NewLine}{My.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Try

      Cursor.Current = Cursors.Default
    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
  End Sub

  Public Sub cmdSendPEC_Click(sender As Object, e As EventArgs) Handles cmdSendPEC.Click

    Try

      ' mise à jour du code dans la table Kimoce
      ' ensuite le robot prendra cette action pour envoyer les informations
      UpdateStatus(_NACTNUM, txtNumKimoce.Text, "BSTATUSNEW")

      LogInfo($"DI: {txtNumKimoce.Text}, {vbTab}Demande envoie PriseEnCharge DI: {txtNumKimoce.Text}, Date: {Date.Now}")

      MessageBox.Show($"Prise en charge envoyée au serveur.{Environment.NewLine}(attente de 15 minutes pour traitement).", My.Resources.Global_Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    Catch ex As Exception
      LogInfo($"DI: {txtNumDI.Text}, {vbTab}Error: {ex.Message}{Environment.NewLine}{Environment.NewLine}{My.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}")
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    Finally
      Cursor.Current = Cursors.Default
    End Try
  End Sub

  Private Sub cmdSendDatePlanif_Click(sender As Object, e As EventArgs) Handles cmdSendDatePlanif.Click


    Try

      ' mise à jour du code dans la table Kimoce
      ' ensuite le robot prendra cette action pour envoyer les informations
      UpdateStatus(_NACTNUM, txtNumKimoce.Text, "BSTATUSPLANNING")

      LogInfo($"DI: {txtNumKimoce.Text}, {vbTab}Demande envoie Date planification DI: {txtNumKimoce.Text}, Date: {Date.Now}")

      MessageBox.Show($"Date de planification envoyée au serveur.{Environment.NewLine}(attente de 15 minutes pour traitement).", My.Resources.Global_Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    Catch ex As Exception
      LogInfo($"DI: {txtNumDI.Text}, {vbTab}Error: {ex.Message}{Environment.NewLine}{My.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}")
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    Finally
      Cursor.Current = Cursors.Default
    End Try

  End Sub

  Private Sub cmdSendDateInter_Click(sender As Object, e As EventArgs) Handles cmdSendDateInter.Click
    Try

      ' mise à jour du code dans la table Kimoce
      ' ensuite le robot prendra cette action pour envoyer les informations
      UpdateStatus(_NACTNUM, txtNumKimoce.Text, "BSTATUSEXEC")

      LogInfo($"DI: {txtNumKimoce.Text}, {vbTab}Demande envoie Date intervention DI: {txtNumKimoce.Text}, Date: {Date.Now}")

      MessageBox.Show($"Date d'exécution envoyée au serveur.{Environment.NewLine}(attente de 15 minutes pour traitement).", My.Resources.Global_Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


    Catch ex As Exception
      LogInfo($"DI: {txtNumDI.Text}, {vbTab}Error: {ex.Message}{Environment.NewLine}{My.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}")
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    Finally
      Cursor.Current = Cursors.Default
    End Try
  End Sub

  Private Sub cmdSendCloture_Click(sender As Object, e As EventArgs) Handles cmdSendCloture.Click
    Try

      ' mise à jour du code dans la table Kimoce
      ' ensuite le robot prendra cette action pour envoyer les informations
      UpdateStatus(_NACTNUM, txtNumKimoce.Text, "BSTATUSCLOSE")

      LogInfo($"DI: {txtNumKimoce.Text}, {vbTab}Demande envoie Cloture intervention DI: {txtNumKimoce.Text}, Date: {Date.Now}")

      MessageBox.Show($"Cloture de l'intervention envoyée au serveur.{Environment.NewLine}(attente de 10 minutes pour traitement).{Environment.NewLine}", My.Resources.Global_Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


    Catch ex As Exception
      LogInfo($"DI: {txtNumDI.Text}, {vbTab}Error: {ex.Message}{Environment.NewLine}{My.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}")
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    Finally
      Cursor.Current = Cursors.Default
    End Try
  End Sub

  Private Sub GetInfoDI()

    Try
      Dim nDinNum As Integer = 0
      ' Infos DI / Action
      Dim sql As String = $"select A.NDINNUM, S.NACTNUM, IsNull(S.NKIMNUM, 0) NKIMNUM, VDIEMALEC, VKIMDESC  from TACT A inner join TDIKIMOCE S On A.NACTNUM = S.NACTNUM where A.NACTNUM = {_NACTNUM}"
      Using cmd As New SqlCommand(sql, MozartDatabase.cnxMozart)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
          nDinNum = dr("NDINNUM")
          txtNumDI.Text = nDinNum
          txtNumKimoce.Text = dr("NKIMNUM")
          txtDiDesc.Text = $"{dr("VKIMDESC")}{vbCrLf}DI / Action : {dr("VDIEMALEC")}"
        Else
          lblStatus.Text = "Il n'existe pas de DI KIMOCE associée à cette action !"
        End If

        dr.Close()
      End Using

    Catch ex As Exception
      LogInfo($"DI: {txtNumDI.Text}, {vbTab}Error: {ex.Message}{Environment.NewLine}{My.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}")
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
  End Sub

  Private Sub LogInfo(sMessage As String)
    ExecuteNonQuery($"Insert into TKIMOCE_LOG (VLOGMSG) Values ('{sMessage.Replace("'", "''")}')")
  End Sub


  Private Sub UpdateStatus(nActNum As Long, nKimNum As String, vStatus As String)
    Try
      Using cmd As New SqlCommand($"UPDATE TDIKIMOCE SET {vStatus} = 1 WHERE NACTNUM = {nActNum} AND NKIMNUM = '{nKimNum}'", MozartDatabase.cnxMozart)
        cmd.ExecuteNonQuery()
      End Using
    Catch ex As Exception
      LogInfo($"DIKIM: {nKimNum}, ACTION: {nActNum}, {vbTab}Error: {ex.Message}{Environment.NewLine}{My.Resources.Global_dans} {MethodBase.GetCurrentMethod().Name}")
    End Try
  End Sub

  Private Sub cmdFermer_Click(sender As Object, e As EventArgs) Handles cmdFermer.Click
    Dispose()
  End Sub

End Class