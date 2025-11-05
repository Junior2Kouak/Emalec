Imports MozartLib
Imports MozartNet.My.Resources
Imports System.Data.SqlClient

Public Class FrmMasterWizardSTF

  Dim iIndexUserCtrl As Int32

  Dim oUsrCtrlInit As New UCInitSTF
  Dim oUsrCtrlQSE As New UCQSE
  Dim oUsrCtrlInfoSTF As New UCInfoSTF
  Dim oUsrCtrlInfoDoublon As New UCInfoDoublon
  Dim oUsrCtrlSiteSTF As New UCSiteSTF
  Dim oUsrCtrlVillesCiblesSTF As New UCVillesCibles
  Dim oUsrCtrlPrestationsSTF As New UCPrestations
  Dim oUsrCtrlContactSTF As New UCContactSTF
  Dim oUsrCtrlFin As New UCFin

  Private Sub FrmMaster_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try

      'init
      PanelMaster.Location = New Point(0, 0)
      PanelMaster.Size = New Size(Me.Size.Width, PanelMaster.Size.Height)

      Me.Text = Me.Text & " " & MozartParams.NomServeur

      LoadLogoSociete()

      'on charge tous les user control en respectant l'ordre
      PanelMaster.Controls.Add(oUsrCtrlInit) '0
      PanelMaster.Controls.Add(oUsrCtrlQSE) '1
      PanelMaster.Controls.Add(oUsrCtrlInfoSTF) '2
      PanelMaster.Controls.Add(oUsrCtrlInfoDoublon) '3
      PanelMaster.Controls.Add(oUsrCtrlSiteSTF) '4
      PanelMaster.Controls.Add(oUsrCtrlVillesCiblesSTF) '5
      PanelMaster.Controls.Add(oUsrCtrlPrestationsSTF) '6
      PanelMaster.Controls.Add(oUsrCtrlContactSTF) '7
      PanelMaster.Controls.Add(oUsrCtrlFin) '8

      iIndexUserCtrl = 0
      VisibleUserCtrl(iIndexUserCtrl)

    Catch ex As Exception

      MessageBox.Show("FrmMaster_Load -> FrmMaster : " + ex.Message)

    End Try

  End Sub

  Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click

    Me.Close()

  End Sub

  Private Sub LoadLogoSociete()

    Select Case MozartParams.NomSociete.ToUpper
      Case "EMALEC" : PictSociete.Image = My.Resources.SAMSIC_EMALEC
      Case "ALC" : PictSociete.Image = My.Resources.SAMSIC_EMALEC
      Case "SCS" : PictSociete.Image = My.Resources.SAMSIC_EMALEC
      Case "EQUIPAGE" : PictSociete.Image = My.Resources.SAMSIC_EMALEC
      Case "FITELEC" : PictSociete.Image = My.Resources.SAMSIC_EMALEC
      Case "MAGESTIME" : PictSociete.Image = My.Resources.SAMSIC_EMALEC
      Case "EMALECFACILITEAM" : PictSociete.Image = My.Resources.SAMSIC_EMALEC
      Case "EMALECMPM" : PictSociete.Image = My.Resources.SAMSIC_EMALEC
      Case "EMALECDEV" : PictSociete.Image = My.Resources.SAMSIC_EMALEC
      Case "EMALECLUXEMBOURG" : PictSociete.Image = My.Resources.SAMSIC_EMALEC
      Case "EMALECSUISSE" : PictSociete.Image = My.Resources.SAMSIC_EMALEC
      Case "EMALECIDF" : PictSociete.Image = My.Resources.SAMSIC_EMALEC
      Case "EMALECESPAGNE" : PictSociete.Image = My.Resources.SAMSIC_EMALEC
      Case Else : PictSociete.Image = Nothing
    End Select

  End Sub

  Private Sub VisibleUserCtrl(ByVal p_iIndexVisible As Int32)

    Dim i As Int32 = 0

    For Each oUserCtrlVisible As Control In PanelMaster.Controls

      If p_iIndexVisible = i Then
        oUserCtrlVisible.Visible = True
      Else
        oUserCtrlVisible.Visible = False
      End If
      i = i + 1

    Next

    'champ focus par défaut
    Select Case p_iIndexVisible

      Case 2
        oUsrCtrlInfoSTF.TxtSTFNom.Focus()
      Case 3
      Case 4
        oUsrCtrlSiteSTF.TxtSiteSTFNom.Focus()
      Case 5
      Case 6
      Case 7
        oUsrCtrlContactSTF.TxtINTNom.Focus()
      Case 8

    End Select

  End Sub

  Private Sub BtnNext_Click(sender As System.Object, e As System.EventArgs) Handles BtnNext.Click

    If VerifSaisieChamp(1) = False Then Exit Sub
    iIndexUserCtrl = iIndexUserCtrl + 1
    If iIndexUserCtrl >= PanelMaster.Controls.Count - 1 Then
      BtnLast.Visible = True
      BtnNext.Visible = False
      BtnFinish.Visible = True
    Else
      BtnLast.Visible = True
      BtnNext.Visible = True
      BtnFinish.Visible = False
    End If

    'si c'est seulement un fournisseur pas besoin de définir les villes et activites
    If oUsrCtrlInfoSTF.ChkFO.Checked = True And oUsrCtrlInfoSTF.ChkSTM.Checked = False And oUsrCtrlInfoSTF.ChkSTI.Checked = False And oUsrCtrlInfoSTF.ChkSTG.Checked = False Then

      If iIndexUserCtrl + 1 = 6 Then
        iIndexUserCtrl = 7
      End If

    End If

    SetDefaultData(1)
    VisibleUserCtrl(iIndexUserCtrl)
  End Sub

  Private Sub BtnLast_Click(sender As System.Object, e As System.EventArgs) Handles BtnLast.Click

    If VerifSaisieChamp(-1) = False Then Exit Sub
    iIndexUserCtrl = iIndexUserCtrl - 1
    If iIndexUserCtrl <= 0 Then
      BtnLast.Visible = False
      BtnNext.Visible = True
      BtnFinish.Visible = False
    Else
      BtnLast.Visible = True
      BtnNext.Visible = True
      BtnFinish.Visible = False
    End If

    'si c'est seulement un fournisseur pas besoin de définir les villes et activites
    If oUsrCtrlInfoSTF.ChkFO.Checked = True And oUsrCtrlInfoSTF.ChkSTM.Checked = False And oUsrCtrlInfoSTF.ChkSTI.Checked = False And oUsrCtrlInfoSTF.ChkSTG.Checked = False Then

      ' If iIndexUserCtrl - 1 = 4 Then
      'iIndexUserCtrl = 3
      'End If
      If iIndexUserCtrl - 1 = 5 Then
        iIndexUserCtrl = 4
      End If


    End If

    SetDefaultData(-1)
    VisibleUserCtrl(iIndexUserCtrl)

  End Sub

  Private Sub FrmMaster_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    oUsrCtrlInit.Dispose()
    oUsrCtrlInfoSTF.Dispose()
    oUsrCtrlInfoDoublon.Dispose()
    oUsrCtrlSiteSTF.Dispose()
    oUsrCtrlContactSTF.Dispose()
    oUsrCtrlFin.Dispose()


  End Sub

  Private Function VerifSaisieChamp(ByVal p_LASTNEXT As Int16) As Boolean

    Dim bOK As Boolean = True

    If p_LASTNEXT = 1 Then

      Select Case iIndexUserCtrl

        Case 0
        Case 1
          ' si la case fournisseur n'est pas cochée, il faut tester les autres cases
          ' si rien de coché, il faut bloquer
          If oUsrCtrlQSE.chkFO.CheckState <> CheckState.Checked Then
            If (oUsrCtrlQSE.chkO1.Checked = True And oUsrCtrlQSE.chkO2.Checked = True And oUsrCtrlQSE.chkO3.Checked = True) Then
              ' seul cas ou on peut passer
            Else

              '              If (oUsrCtrlQSE.chkN1.CheckState = CheckState.Checked Or oUsrCtrlQSE.chkN2.Checked Or oUsrCtrlQSE.chkN3.Checked) Then
              MessageBox.Show("Erreur de saisie, il faut cocher les cases OUI pour continuer (ou bien cocher la case Fournisseur)", WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
              oUsrCtrlInfoSTF.TxtVSTFCP.BackColor = Color.Yellow
              oUsrCtrlInfoSTF.TxtVSTFCP.Focus()
              bOK = False
              Exit Select
            End If
          End If
        Case 2

          If oUsrCtrlInfoSTF.TxtSTFNom.Text = "" Then

            MessageBox.Show(WizardSTF_FrmMaster_Expr1, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            oUsrCtrlInfoSTF.TxtSTFNom.BackColor = Color.Yellow
            oUsrCtrlInfoSTF.TxtSTFNom.Focus()
            bOK = False
            Exit Select

          End If

          If oUsrCtrlInfoSTF.TxtVSTFCP.Text = "" Then

            MessageBox.Show(WizardSTF_FrmMaster_Expr3, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            oUsrCtrlInfoSTF.TxtVSTFCP.BackColor = Color.Yellow
            oUsrCtrlInfoSTF.TxtVSTFCP.Focus()
            bOK = False
            Exit Select

          Else

            If oUsrCtrlInfoSTF.GridSTFPays.EditValue = 1 And oUsrCtrlInfoSTF.TxtVSTFCP.Text.Length <> 5 Then

              MessageBox.Show(WizardSTF_FrmMaster_Expr4, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
              oUsrCtrlInfoSTF.TxtVSTFCP.BackColor = Color.Yellow
              oUsrCtrlInfoSTF.TxtVSTFCP.Focus()

            End If

          End If

          If (oUsrCtrlInfoSTF.GridSTFVille.Text = "" And oUsrCtrlInfoSTF.GridSTFPays.EditValue = 1) Or (oUsrCtrlInfoSTF._TxtVILLE.Text = "" And oUsrCtrlInfoSTF.GridSTFPays.EditValue <> 1) Then

            MessageBox.Show(WizardSTF_FrmMaster_Expr5, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            If oUsrCtrlInfoSTF.GridSTFPays.EditValue = 1 Then
              oUsrCtrlInfoSTF.GridSTFVille.BackColor = Color.Yellow
              oUsrCtrlInfoSTF.GridSTFVille.Focus()
            Else
              oUsrCtrlInfoSTF._TxtVILLE.BackColor = Color.Yellow
              oUsrCtrlInfoSTF._TxtVILLE.Focus()
            End If
            bOK = False
            Exit Select

          End If

          If oUsrCtrlInfoSTF.ChkFO.CheckState <> CheckState.Checked And oUsrCtrlInfoSTF.ChkSTG.CheckState <> CheckState.Checked And oUsrCtrlInfoSTF.ChkSTI.CheckState <> CheckState.Checked And oUsrCtrlInfoSTF.ChkSTM.CheckState <> CheckState.Checked Then

            MessageBox.Show(WizardSTF_FrmMaster_Expr6, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            bOK = False
            Exit Select

          End If

          If oUsrCtrlInfoSTF.GridSTFStatutSoc.Text = "" And (oUsrCtrlInfoSTF.ChkSTG.CheckState = CheckState.Checked Or oUsrCtrlInfoSTF.ChkSTI.CheckState = CheckState.Checked Or oUsrCtrlInfoSTF.ChkSTM.CheckState = CheckState.Checked) Then

            MessageBox.Show(WizardSTF_FrmMaster_Expr7, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            oUsrCtrlInfoSTF.GridSTFStatutSoc.BackColor = Color.Yellow
            oUsrCtrlInfoSTF.Focus()
            bOK = False
            Exit Select

          End If

          If oUsrCtrlInfoSTF.TxtSTFCA.Text = "" And (oUsrCtrlInfoSTF.ChkSTG.CheckState = CheckState.Checked Or oUsrCtrlInfoSTF.ChkSTI.CheckState = CheckState.Checked Or oUsrCtrlInfoSTF.ChkSTM.CheckState = CheckState.Checked) Then

            MessageBox.Show(WizardSTF_FrmMaster_Expr8, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            oUsrCtrlInfoSTF.TxtSTFCA.BackColor = Color.Yellow
            oUsrCtrlInfoSTF.TxtSTFCA.Focus()
            bOK = False
            Exit Select

          End If

          'en sql int = 2147483647 maxi
          If oUsrCtrlInfoSTF.TxtSTFCA.Text <> "" And (oUsrCtrlInfoSTF.ChkSTG.CheckState = CheckState.Checked Or oUsrCtrlInfoSTF.ChkSTI.CheckState = CheckState.Checked Or oUsrCtrlInfoSTF.ChkSTM.CheckState = CheckState.Checked) Then

            If oUsrCtrlInfoSTF.TxtSTFCA.EditValue > 2147483647 Then
              MessageBox.Show(WizardSTF_FrmMaster_Expr9 & vbCrLf & WizardSTF_FrmMaster_Expr10, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
              oUsrCtrlInfoSTF.TxtSTFCA.BackColor = Color.Yellow
              oUsrCtrlInfoSTF.TxtSTFCA.Focus()
              bOK = False
              Exit Select
            End If

          End If

          'test siret modif le 05/08/2016 avlidé avec bertrand schei
          If oUsrCtrlInfoSTF.TxtSTFSIRET.Text = "" Then
            oUsrCtrlInfoSTF.TxtSTFSIRET.BackColor = Color.Yellow
            oUsrCtrlInfoSTF.TxtSTFSIRET.Focus()
            bOK = False
            Exit Select
          Else

            If oUsrCtrlInfoSTF.TxtSTFSIRET.Text <> "" AndAlso VerifSIRET(oUsrCtrlInfoSTF.TxtSTFSIRET.Text) = False Then
              oUsrCtrlInfoSTF.TxtSTFSIRET.BackColor = Color.Yellow
              oUsrCtrlInfoSTF.TxtSTFSIRET.Focus()
              bOK = False
              Exit Select
            End If

          End If

        Case 3
        Case 4

          If oUsrCtrlSiteSTF.TxtSiteSTFNom.Text = "" Then

            MessageBox.Show(WizardSTF_FrmMaster_Expr1, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            oUsrCtrlSiteSTF.TxtSiteSTFNom.BackColor = Color.Yellow
            oUsrCtrlSiteSTF.TxtSiteSTFNom.Focus()
            bOK = False
            Exit Select

          End If

          If oUsrCtrlSiteSTF.TxtVSITSTFCP.Text = "" Then

            MessageBox.Show(WizardSTF_FrmMaster_Expr3, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            oUsrCtrlSiteSTF.TxtVSITSTFCP.BackColor = Color.Yellow
            oUsrCtrlSiteSTF.TxtVSITSTFCP.Focus()
            bOK = False
            Exit Select

          Else

            If oUsrCtrlSiteSTF.GridSITSTFPays.EditValue = 1 And oUsrCtrlSiteSTF.TxtVSITSTFCP.Text.Length <> 5 Then

              MessageBox.Show(WizardSTF_FrmMaster_Expr4, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
              oUsrCtrlSiteSTF.TxtVSITSTFCP.BackColor = Color.Yellow
              oUsrCtrlSiteSTF.TxtVSITSTFCP.Focus()

            End If

          End If

          If (oUsrCtrlSiteSTF.GridSITSTFVille.Text = "" And oUsrCtrlSiteSTF.GridSITSTFPays.EditValue = 1) Or (oUsrCtrlSiteSTF._TxtVILLE.Text = "" And oUsrCtrlSiteSTF.GridSITSTFPays.EditValue <> 1) Then

            MessageBox.Show(WizardSTF_FrmMaster_Expr5, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            If oUsrCtrlSiteSTF.GridSITSTFPays.EditValue = 1 Then
              oUsrCtrlSiteSTF.GridSITSTFVille.BackColor = Color.Yellow
              oUsrCtrlSiteSTF.GridSITSTFVille.Focus()
            Else
              oUsrCtrlSiteSTF._TxtVILLE.BackColor = Color.Yellow
              oUsrCtrlSiteSTF._TxtVILLE.Focus()
            End If
            bOK = False
            Exit Select

          End If
        Case 5

          'on teste si une ville a été sélectionné
          If oUsrCtrlVillesCiblesSTF.dsVillesCibles.Tables("TMPVILLESCIBLES").Select("[COCHE]=1").Count = 0 Then

            MessageBox.Show(WizardSTF_FrmMaster_Expr11, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            bOK = False
            Exit Select

          End If

        Case 6

          'on teste si une prestation a été sélectionnée
          If oUsrCtrlPrestationsSTF.dsPresta.Tables("TMPPRESTA").Select("[COCHEETUDE]=1 OR [COCHEINSTALL]=1 OR [COCHEPREV]=1 OR [COCHEDEP]=1 OR [COCHEASTR]=1").Count = 0 Then

            MessageBox.Show(WizardSTF_FrmMaster_Expr12, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            bOK = False
            Exit Select

          End If

        Case 7

          If oUsrCtrlContactSTF.TxtINTNom.Text = "" Then

            MessageBox.Show(WizardSTF_FrmMaster_Expr13, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            oUsrCtrlContactSTF.TxtINTNom.BackColor = Color.Yellow
            oUsrCtrlContactSTF.TxtINTNom.Focus()
            bOK = False
            Exit Select

          End If

          If oUsrCtrlContactSTF.TxtINTTel.Text = "" Then

            MessageBox.Show(WizardSTF_FrmMaster_Expr14, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            oUsrCtrlContactSTF.TxtINTTel.BackColor = Color.Yellow
            oUsrCtrlContactSTF.TxtINTTel.Focus()
            bOK = False
            Exit Select

          End If

          If oUsrCtrlContactSTF.TxtINTMail.Text = "" Then

            MessageBox.Show(WizardSTF_FrmMaster_Expr32, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

          Else

            'adresse mail
            Dim oRegEx As New RegexUtilities

            If oRegEx.IsValidEmail(oUsrCtrlContactSTF.TxtINTMail.Text) = False Then
              MessageBox.Show(WizardSTF_FrmMaster_Expr15, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
              oUsrCtrlContactSTF.TxtINTMail.BackColor = Color.Yellow
              oUsrCtrlContactSTF.TxtINTMail.Focus()
              bOK = False
              Exit Select
            End If

          End If

          If VerifDoublon() = True Then bOK = False : Exit Select

      End Select

    End If

    Return bOK

  End Function

  Private Function VerifDoublon() As Boolean

    Dim bVerif As Boolean = False
    Dim sqlcmdVerif As SqlCommand
    Dim drVerif As SqlDataReader

    'vérif tel
    If oUsrCtrlContactSTF.TxtINTTel.Text <> "" And oUsrCtrlContactSTF.TxtINTTel.Text <> "...." Then

      sqlcmdVerif = New SqlCommand(String.Format("SELECT VSTFGRPNOM ,VSTFNOM, VINTNOM FROM TINT, TSTF, TSTFGRP WHERE TINT.NSTFNUM = TSTF.NSTFNUM AND TSTFGRP.NSTFGRPNUM = TSTF.NSTFGRPNUM AND REPLACE(REPLACE(VINTTEL,'.',''),' ','') = REPLACE(REPLACE('{0}','.',''),' ','')", oUsrCtrlContactSTF.TxtINTTel.Text), MozartDatabase.cnxMozart)
      sqlcmdVerif.CommandType = CommandType.Text
      drVerif = sqlcmdVerif.ExecuteReader

      If drVerif.HasRows Then

        drVerif.Read()
        MessageBox.Show(String.Format(WizardSTF_FrmMaster_Expr16 & " : " & vbCrLf & " - " & WizardSTF_FrmMaster_Expr17 & " : {0} - " & WizardSTF_FrmMaster_Expr18 & " : {1} - " & WizardSTF_FrmMaster_Expr19 & " : {2}", drVerif.Item("VSTFGRPNOM"), drVerif.Item("VSTFNOM"), drVerif.Item("VINTNOM")), My.Resources.WizardClient_Global_Msg1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        oUsrCtrlContactSTF.TxtINTTel.BackColor = Color.Yellow
        oUsrCtrlContactSTF.TxtINTTel.Focus()
        bVerif = True

      End If

      drVerif.Close()

      If bVerif = True Then Return bVerif

    End If

    'vérif fax
    If oUsrCtrlContactSTF.TxtINTFax.Text <> "" And oUsrCtrlContactSTF.TxtINTFax.Text <> "...." Then

      sqlcmdVerif = New SqlCommand(String.Format("SELECT VSTFGRPNOM ,VSTFNOM, VINTNOM FROM TINT, TSTF, TSTFGRP WHERE TINT.NSTFNUM = TSTF.NSTFNUM AND TSTFGRP.NSTFGRPNUM = TSTF.NSTFGRPNUM AND REPLACE(REPLACE(VINTFAX,'.',''),' ','') = REPLACE(REPLACE('{0}','.',''),' ','')", oUsrCtrlContactSTF.TxtINTFax.Text), MozartDatabase.cnxMozart)
      sqlcmdVerif.CommandType = CommandType.Text
      drVerif = sqlcmdVerif.ExecuteReader

      If drVerif.HasRows Then

        drVerif.Read()
        MessageBox.Show(String.Format(WizardSTF_FrmMaster_Expr20 & " : " & vbCrLf & " - " & WizardSTF_FrmMaster_Expr17 & " : {0} - " & WizardSTF_FrmMaster_Expr18 & " : {1} - " & WizardSTF_FrmMaster_Expr19 & " : {2}", drVerif.Item("VSTFGRPNOM"), drVerif.Item("VSTFNOM"), drVerif.Item("VINTNOM")), My.Resources.WizardClient_Global_Msg1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        oUsrCtrlContactSTF.TxtINTFax.BackColor = Color.Yellow
        oUsrCtrlContactSTF.TxtINTFax.Focus()
        bVerif = True

      End If

      drVerif.Close()

      If bVerif = True Then Return bVerif

    End If

    'vérif mail
    If oUsrCtrlContactSTF.TxtINTMail.Text <> "" Then

      sqlcmdVerif = New SqlCommand(String.Format("SELECT VSTFGRPNOM ,VSTFNOM, VINTNOM FROM TINT, TSTF, TSTFGRP WHERE TINT.NSTFNUM = TSTF.NSTFNUM AND TSTFGRP.NSTFGRPNUM = TSTF.NSTFGRPNUM AND VINTMAIL = '{0}'", oUsrCtrlContactSTF.TxtINTMail.Text), MozartDatabase.cnxMozart)
      sqlcmdVerif.CommandType = CommandType.Text
      drVerif = sqlcmdVerif.ExecuteReader

      If drVerif.HasRows Then

        drVerif.Read()
        MessageBox.Show(String.Format(WizardSTF_FrmMaster_Expr21 & " : " & vbCrLf & " - " & WizardSTF_FrmMaster_Expr17 & " : {0} - " & WizardSTF_FrmMaster_Expr18 & " : {1} - " & WizardSTF_FrmMaster_Expr19 & " : {2}", drVerif.Item("VSTFGRPNOM"), drVerif.Item("VSTFNOM"), drVerif.Item("VINTNOM")), My.Resources.WizardClient_Global_Msg1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        oUsrCtrlContactSTF.TxtINTMail.BackColor = Color.Yellow
        oUsrCtrlContactSTF.TxtINTMail.Focus()
        bVerif = True

      End If

      drVerif.Close()

      If bVerif = True Then Return bVerif

    End If

    Return bVerif

  End Function

  Private Sub SetDefaultData(ByVal p_LASTNEXT As Int16)

    Dim bOK As Boolean = True

    'NEXT
    If p_LASTNEXT = 1 Then

      Select Case iIndexUserCtrl

        Case 0
        Case 1

        Case 2
          If oUsrCtrlInfoSTF.GridSTFPays.Text = "" Then oUsrCtrlInfoSTF.GridSTFPays.EditValue = 1
        Case 3
          If oUsrCtrlInfoSTF.TxtSTFNom.Text <> "" Then oUsrCtrlInfoDoublon.VerifDoublonSTF(oUsrCtrlInfoSTF.TxtSTFNom.Text)
        Case 4

          If oUsrCtrlSiteSTF.TxtSiteSTFNom.Text = "" Then oUsrCtrlSiteSTF.TxtSiteSTFNom.Text = oUsrCtrlInfoSTF.TxtSTFNom.Text
          If oUsrCtrlSiteSTF.GridSITSTFPays.Text = "" Then oUsrCtrlSiteSTF.GridSITSTFPays.EditValue = oUsrCtrlInfoSTF.GridSTFPays.EditValue
          If oUsrCtrlSiteSTF.TxtVSITSTFAD1.Text = "" Then oUsrCtrlSiteSTF.TxtVSITSTFAD1.Text = oUsrCtrlInfoSTF.TxtVSTFAD1.Text
          If oUsrCtrlSiteSTF.TxtVSITSTFAD2.Text = "" Then oUsrCtrlSiteSTF.TxtVSITSTFAD2.Text = oUsrCtrlInfoSTF.TxtVSTFAD2.Text
          If oUsrCtrlSiteSTF.TxtVSITSTFCP.Text = "" Then oUsrCtrlSiteSTF.TxtVSITSTFCP.Text = oUsrCtrlInfoSTF.TxtVSTFCP.Text
          If oUsrCtrlSiteSTF._TxtVILLE.Text = "" And oUsrCtrlSiteSTF.GridSITSTFPays.Text <> "FRANCE" Then oUsrCtrlSiteSTF._TxtVILLE.Text = oUsrCtrlInfoSTF._TxtVILLE.Text

          If oUsrCtrlSiteSTF._TxtVILLE.Text = "" And oUsrCtrlSiteSTF.GridSITSTFPays.Text = "FRANCE" Then oUsrCtrlSiteSTF.GridSITSTFVille.EditValue = oUsrCtrlInfoSTF.GridSTFVille.EditValue

        Case 5

          If oUsrCtrlSiteSTF.GridSITSTFPays.Text <> "" Then oUsrCtrlVillesCiblesSTF.LoadData(oUsrCtrlSiteSTF.GridSITSTFPays.Text)

        Case 6
        Case 7
        Case 8

      End Select

      'LAST
    ElseIf p_LASTNEXT = -1 Then

      Select Case iIndexUserCtrl

        Case 0
        Case 1
        Case 2
        Case 3
        Case 4
        Case 5
        Case 6
        Case 7
        Case 8

      End Select

    End If



  End Sub

  Private Sub BtnFinish_Click(sender As System.Object, e As System.EventArgs) Handles BtnFinish.Click

    If MessageBox.Show(String.Format(WizardSTF_FrmMaster_Expr22 & " {0}." & vbCrLf & WizardSTF_FrmMaster_Expr23, oUsrCtrlInfoSTF.TxtSTFNom.Text), WizardSTF_FrmMaster_Expr2, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

      Dim NSTFGRPNUM As Int32 = 0
      Dim NSTFNUM As Int32 = 0
      Dim NINTNUM As Int32 = 0

      'creation du FO/ST 
      NSTFGRPNUM = CreateSTFGRP()
      If NSTFGRPNUM = 0 Then MessageBox.Show(WizardSTF_FrmMaster_Expr24, My.Resources.WizardClient_Global_Msg1, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub

      'creation site STF
      NSTFNUM = CreateSiteSTF(NSTFGRPNUM)
      If NSTFNUM = 0 Then MessageBox.Show(WizardSTF_FrmMaster_Expr25, My.Resources.WizardClient_Global_Msg1, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub

      'creation intervenant
      NINTNUM = CreateContactSTF(NSTFNUM)
      If NINTNUM = 0 Then MessageBox.Show(WizardSTF_FrmMaster_Expr26, My.Resources.WizardClient_Global_Msg1, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub


      'on envoi un mail demandant les docs admins
      If oUsrCtrlContactSTF.TxtINTMail.Text <> "" And (oUsrCtrlInfoSTF.ChkSTM.Checked = True Or oUsrCtrlInfoSTF.ChkSTI.Checked = True Or oUsrCtrlInfoSTF.ChkSTG.Checked = True) Then

        MessageBox.Show(WizardSTF_FrmMaster_Expr27, WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.None)

        'envoi du mail

        Dim sqlcmdMail As New SqlCommand("api_sp_SendMailSTF_DemandeDocsAdmin", MozartDatabase.cnxMozart)
        'Dim sqlcmdMail As New SqlCommand("api_sp_SendMailSTFDocManquant", cnx)
        sqlcmdMail.CommandType = CommandType.StoredProcedure
        sqlcmdMail.Parameters.Add("@nintnum", SqlDbType.Int).Value = NINTNUM
        sqlcmdMail.ExecuteNonQuery()

      End If

      MessageBox.Show(String.Format(WizardSTF_FrmMaster_Expr28 & " {0}" & vbCrLf & vbCrLf & " " & WizardSTF_FrmMaster_Expr29, oUsrCtrlInfoSTF.TxtSTFNom.Text), WizardSTF_FrmMaster_Expr2, MessageBoxButtons.OK, MessageBoxIcon.None)

      Me.Close()

    End If

  End Sub

  Private Function CreateSTFGRP() As Int32

    Dim sTypeFPOST As String = ""

    Dim sqlCreateCFOST As New SqlCommand("[api_sp_CreationWizardFOST]", MozartDatabase.cnxMozart)
    sqlCreateCFOST.CommandType = CommandType.StoredProcedure
    sqlCreateCFOST.Parameters.Add("@vstfgrpnom", SqlDbType.VarChar).Value = oUsrCtrlInfoSTF.TxtSTFNom.Text
    sqlCreateCFOST.Parameters.Add("@vstfgrpAd1", SqlDbType.VarChar).Value = oUsrCtrlInfoSTF.TxtVSTFAD1.Text
    sqlCreateCFOST.Parameters.Add("@vstfgrpAd2", SqlDbType.VarChar).Value = oUsrCtrlInfoSTF.TxtVSTFAD2.Text
    sqlCreateCFOST.Parameters.Add("@vstfgrpCP", SqlDbType.VarChar).Value = oUsrCtrlInfoSTF.TxtVSTFCP.Text
    sqlCreateCFOST.Parameters.Add("@vstfgrpVille", SqlDbType.VarChar).Value = If(oUsrCtrlInfoSTF.GridSTFPays.EditValue = 1, oUsrCtrlInfoSTF.GridSTFVille.Text, oUsrCtrlInfoSTF._TxtVILLE.Text)
    sqlCreateCFOST.Parameters.Add("@vstfgrpcpcedex", SqlDbType.VarChar).Value = oUsrCtrlInfoSTF.TxtVSTFCPCedex.Text
    sqlCreateCFOST.Parameters.Add("@vstfgrpcedex", SqlDbType.VarChar).Value = oUsrCtrlInfoSTF.TxtVSTFCEDEX.Text
    sqlCreateCFOST.Parameters.Add("@vstfgrpPays", SqlDbType.VarChar).Value = oUsrCtrlInfoSTF.GridSTFPays.Text

    If oUsrCtrlInfoSTF.ChkFO.Checked = True And oUsrCtrlInfoSTF.ChkSTM.Checked = False And oUsrCtrlInfoSTF.ChkSTI.Checked = False And oUsrCtrlInfoSTF.ChkSTG.Checked = False Then
      sTypeFPOST = "FO"
    ElseIf oUsrCtrlInfoSTF.ChkFO.Checked = True And (oUsrCtrlInfoSTF.ChkSTM.Checked = True Or oUsrCtrlInfoSTF.ChkSTI.Checked = True Or oUsrCtrlInfoSTF.ChkSTG.Checked = True) Then
      sTypeFPOST = "FT"
    ElseIf oUsrCtrlInfoSTF.ChkFO.Checked = False And (oUsrCtrlInfoSTF.ChkSTM.Checked = True Or oUsrCtrlInfoSTF.ChkSTI.Checked = True Or oUsrCtrlInfoSTF.ChkSTG.Checked = True) Then
      sTypeFPOST = "ST"
    End If

    sqlCreateCFOST.Parameters.Add("@vstfgrpType", SqlDbType.VarChar).Value = sTypeFPOST
    sqlCreateCFOST.Parameters.Add("@istfgrpTypFo", SqlDbType.Int).Value = If(oUsrCtrlInfoSTF.ChkFO.Checked = True, 1, 0)
    sqlCreateCFOST.Parameters.Add("@istfgrpTypMaint", SqlDbType.Int).Value = If(oUsrCtrlInfoSTF.ChkSTM.Checked = True, 1, 0)
    sqlCreateCFOST.Parameters.Add("@istfgrpTypInstall", SqlDbType.Int).Value = If(oUsrCtrlInfoSTF.ChkSTI.Checked = True, 1, 0)
    sqlCreateCFOST.Parameters.Add("@istfgrpTypGarant", SqlDbType.Int).Value = If(oUsrCtrlInfoSTF.ChkSTG.Checked = True, 1, 0)
    sqlCreateCFOST.Parameters.Add("@nstfgrpsocial", SqlDbType.Int).Value = oUsrCtrlInfoSTF.GridSTFStatutSoc.EditValue
    If oUsrCtrlInfoSTF.TxtSTFCA.Text <> "" Then sqlCreateCFOST.Parameters.Add("@stfgrpCA", SqlDbType.BigInt).Value = oUsrCtrlInfoSTF.TxtSTFCA.EditValue
    sqlCreateCFOST.Parameters.Add("@vstfgrpSIREN", SqlDbType.VarChar).Value = oUsrCtrlInfoSTF.TxtSTFSIRET.Text

    Return Convert.ToInt32(sqlCreateCFOST.ExecuteScalar())

  End Function

  Private Function CreateSiteSTF(ByVal P_NSTFGRPNUM As Int32) As Int32

    Dim sTypeFPOST As String = ""

    Dim sqlCreateSiteSTF As New SqlCommand("[api_sp_CreationWizardSiteSTF]", MozartDatabase.cnxMozart)
    sqlCreateSiteSTF.CommandType = CommandType.StoredProcedure
    sqlCreateSiteSTF.Parameters.Add("@nstfgrpnum", SqlDbType.Int).Value = P_NSTFGRPNUM
    sqlCreateSiteSTF.Parameters.Add("@vstfnom", SqlDbType.VarChar).Value = oUsrCtrlSiteSTF.TxtSiteSTFNom.Text
    sqlCreateSiteSTF.Parameters.Add("@vstfAd1", SqlDbType.VarChar).Value = oUsrCtrlSiteSTF.TxtVSITSTFAD1.Text
    sqlCreateSiteSTF.Parameters.Add("@vstfAd2", SqlDbType.VarChar).Value = oUsrCtrlSiteSTF.TxtVSITSTFAD2.Text
    sqlCreateSiteSTF.Parameters.Add("@vstfCP", SqlDbType.VarChar).Value = oUsrCtrlSiteSTF.TxtVSITSTFCP.Text
    sqlCreateSiteSTF.Parameters.Add("@vstfVille", SqlDbType.VarChar).Value = If(oUsrCtrlSiteSTF.GridSITSTFPays.EditValue = 1, oUsrCtrlSiteSTF.GridSITSTFVille.Text, oUsrCtrlSiteSTF._TxtVILLE.Text)
    sqlCreateSiteSTF.Parameters.Add("@vstfcpcedex", SqlDbType.VarChar).Value = oUsrCtrlSiteSTF.TxtVSITSTFCPCedex.Text
    sqlCreateSiteSTF.Parameters.Add("@vstfcedex", SqlDbType.VarChar).Value = oUsrCtrlSiteSTF.TxtVSITSTFCEDEX.Text
    sqlCreateSiteSTF.Parameters.Add("@vstfPays", SqlDbType.VarChar).Value = oUsrCtrlSiteSTF.GridSITSTFPays.Text
    sqlCreateSiteSTF.Parameters.Add("@vlangueabr", SqlDbType.VarChar).Value = oUsrCtrlSiteSTF.GridSITSTFLangue.EditValue

    If oUsrCtrlInfoSTF.ChkFO.Checked = True And oUsrCtrlInfoSTF.ChkSTM.Checked = False And oUsrCtrlInfoSTF.ChkSTI.Checked = False And oUsrCtrlInfoSTF.ChkSTG.Checked = False Then
      sTypeFPOST = "FO"
    ElseIf oUsrCtrlInfoSTF.ChkFO.Checked = True And (oUsrCtrlInfoSTF.ChkSTM.Checked = True Or oUsrCtrlInfoSTF.ChkSTI.Checked = True Or oUsrCtrlInfoSTF.ChkSTG.Checked = True) Then
      sTypeFPOST = "FT"
    ElseIf oUsrCtrlInfoSTF.ChkFO.Checked = False And (oUsrCtrlInfoSTF.ChkSTM.Checked = True Or oUsrCtrlInfoSTF.ChkSTI.Checked = True Or oUsrCtrlInfoSTF.ChkSTG.Checked = True) Then
      sTypeFPOST = "ST"
    End If

    sqlCreateSiteSTF.Parameters.Add("@vstfType", SqlDbType.VarChar).Value = sTypeFPOST

    sqlCreateSiteSTF.Parameters.Add("@istfTypFo", SqlDbType.Int).Value = If(oUsrCtrlInfoSTF.ChkFO.Checked = True, 1, 0)
    sqlCreateSiteSTF.Parameters.Add("@istfTypMaint", SqlDbType.Int).Value = If(oUsrCtrlInfoSTF.ChkSTM.Checked = True, 1, 0)
    sqlCreateSiteSTF.Parameters.Add("@istfTypInstall", SqlDbType.Int).Value = If(oUsrCtrlInfoSTF.ChkSTI.Checked = True, 1, 0)
    sqlCreateSiteSTF.Parameters.Add("@istfTypGarant", SqlDbType.Int).Value = If(oUsrCtrlInfoSTF.ChkSTG.Checked = True, 1, 0)
    sqlCreateSiteSTF.Parameters.Add("@vstfsiret", SqlDbType.VarChar).Value = oUsrCtrlInfoSTF.TxtSTFSIRET.Text
    If oUsrCtrlSiteSTF.TxtSITSTFCoutHor.Text <> "" Then sqlCreateSiteSTF.Parameters.Add("@istfmoe", SqlDbType.Int).Value = oUsrCtrlSiteSTF.TxtSITSTFCoutHor.EditValue
    If oUsrCtrlSiteSTF.TxtSITSTFCoutDep.Text <> "" Then sqlCreateSiteSTF.Parameters.Add("@istfdep", SqlDbType.Int).Value = oUsrCtrlSiteSTF.TxtSITSTFCoutDep.EditValue
    sqlCreateSiteSTF.Parameters.Add("@vstftelastr", SqlDbType.VarChar).Value = oUsrCtrlContactSTF.TxtINTAstr.Text

    'save villes cibles
    Dim sLstVilles As String = ""
    Dim sLstVillesRecherche As String = ""

    If Not oUsrCtrlVillesCiblesSTF.dsVillesCibles Is Nothing Then

      For Each drVillesSelect As DataRow In oUsrCtrlVillesCiblesSTF.dsVillesCibles.Tables("TMPVILLESCIBLES").Rows

        If drVillesSelect.Item("COCHE") = 1 Then

          sLstVilles = sLstVilles & drVillesSelect.Item("ID") & ";"
          sLstVillesRecherche = sLstVillesRecherche & drVillesSelect.Item("VILLE") & ";"

        End If

      Next

    End If

    'save activites
    Dim sLstActivites As String = ""
    Dim sLstActivitesRecherche As String = ""

    If Not oUsrCtrlPrestationsSTF.dsPresta Is Nothing Then

      For Each drPrestaSelect As DataRow In oUsrCtrlPrestationsSTF.dsPresta.Tables("TMPPRESTA").Rows

        If drPrestaSelect.Item("COCHEETUDE") = 1 Then
          sLstActivites = sLstActivites & drPrestaSelect.Item("ID") & "_Etud;"
        End If

        If drPrestaSelect.Item("COCHEINSTALL") = 1 Then
          sLstActivites = sLstActivites & drPrestaSelect.Item("ID") & "_Inst;"
        End If

        If drPrestaSelect.Item("COCHEPREV") = 1 Then
          sLstActivites = sLstActivites & drPrestaSelect.Item("ID") & "_Maint;"
        End If

        If drPrestaSelect.Item("COCHEDEP") = 1 Then
          sLstActivites = sLstActivites & drPrestaSelect.Item("ID") & "_Dep;"
        End If

        If drPrestaSelect.Item("COCHEASTR") = 1 Then
          sLstActivites = sLstActivites & drPrestaSelect.Item("ID") & "_Astr;"
        End If

        If drPrestaSelect.Item("COCHEETUDE") = 1 Or drPrestaSelect.Item("COCHEINSTALL") = 1 Or drPrestaSelect.Item("COCHEPREV") = 1 Or drPrestaSelect.Item("COCHEDEP") = 1 Or drPrestaSelect.Item("COCHEASTR") = 1 Then

          'rappel de la catégorie
          If sLstActivitesRecherche.Contains(drPrestaSelect.Item("VCATEGORIE")) = True Then
            sLstActivitesRecherche = sLstActivitesRecherche & drPrestaSelect.Item("VACTIVITE") & ";"
          Else
            sLstActivitesRecherche = sLstActivitesRecherche & drPrestaSelect.Item("VCATEGORIE") & ";"
            sLstActivitesRecherche = sLstActivitesRecherche & drPrestaSelect.Item("VACTIVITE") & ";"

          End If

        End If

      Next

    End If

    'on ne sauvegarde que les villes et activités si sous traitant (au moins)
    If sTypeFPOST = "" Or sTypeFPOST <> "FO" Then

      sqlCreateSiteSTF.Parameters.Add("@vstfvilles", SqlDbType.VarChar).Value = sLstVilles
      sqlCreateSiteSTF.Parameters.Add("@vstfvillesrecherche", SqlDbType.VarChar).Value = sLstVillesRecherche

      sqlCreateSiteSTF.Parameters.Add("@vstfactivites", SqlDbType.VarChar).Value = sLstActivites
      sqlCreateSiteSTF.Parameters.Add("@vstfactvitesrecherche", SqlDbType.VarChar).Value = sLstActivitesRecherche

    End If

    Return Convert.ToInt32(sqlCreateSiteSTF.ExecuteScalar())

  End Function

  Private Function CreateContactSTF(ByVal P_NSTFNUM As Int32) As Int32

    Dim sqlCreateTINTSTF As New SqlCommand("[api_sp_CreationWizardContactSTF]", MozartDatabase.cnxMozart)
    sqlCreateTINTSTF.CommandType = CommandType.StoredProcedure
    sqlCreateTINTSTF.Parameters.Add("@nstfnum", SqlDbType.Int).Value = P_NSTFNUM
    sqlCreateTINTSTF.Parameters.Add("@vintciv", SqlDbType.VarChar).Value = oUsrCtrlContactSTF.CboINTCiv.Text
    sqlCreateTINTSTF.Parameters.Add("@vintnom", SqlDbType.VarChar).Value = oUsrCtrlContactSTF.TxtINTNom.Text
    sqlCreateTINTSTF.Parameters.Add("@vintpre", SqlDbType.VarChar).Value = oUsrCtrlContactSTF.TxtINTPrenom.Text
    sqlCreateTINTSTF.Parameters.Add("@vinttel", SqlDbType.VarChar).Value = oUsrCtrlContactSTF.TxtINTTel.Text
    sqlCreateTINTSTF.Parameters.Add("@vintfax", SqlDbType.VarChar).Value = oUsrCtrlContactSTF.TxtINTFax.Text
    sqlCreateTINTSTF.Parameters.Add("@vintmail", SqlDbType.VarChar).Value = oUsrCtrlContactSTF.TxtINTMail.Text
    sqlCreateTINTSTF.Parameters.Add("@vintpor", SqlDbType.VarChar).Value = oUsrCtrlContactSTF.TxtINTPort.Text
    sqlCreateTINTSTF.Parameters.Add("@vintfonc", SqlDbType.VarChar).Value = oUsrCtrlContactSTF.TxtINTFonction.Text

    Return Convert.ToInt32(sqlCreateTINTSTF.ExecuteScalar())

  End Function

  Private Function VerifSIRET(ByVal P_VSTFSIRET As String) As Boolean

    Dim bOKVerifSIRET As Boolean = False

    Dim sqlVerifSIRET As New SqlCommand("[api_sp_VerifSirenSTF]", MozartDatabase.cnxMozart)
    sqlVerifSIRET.CommandType = CommandType.StoredProcedure
    sqlVerifSIRET.Parameters.Add("@P_NUMSIREN", SqlDbType.VarChar).Value = P_VSTFSIRET
    Dim sqldr As SqlDataReader = sqlVerifSIRET.ExecuteReader
    If sqldr.HasRows Then

      bOKVerifSIRET = False
      sqldr.Read()
      MessageBox.Show(WizardSTF_FrmMaster_Expr30 & vbCrLf & " - " & WizardSTF_FrmMaster_Expr31 & " : " & sqldr.Item("VSTFNOM"), My.Resources.WizardClient_Global_Msg1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    Else

      bOKVerifSIRET = True

    End If
    sqldr.Close()

    Return bOKVerifSIRET

  End Function

End Class
