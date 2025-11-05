Imports System.IO

Public Class frmGestDocDUPWebTech

  Dim sPathDocSiteWebDUP As String
  Dim sFileName As String

  Private Sub frmGestDocDUPWebTech_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    WBApercu.Navigate("about:blank")
  End Sub

  Private Sub frmGestDocDUPWebTech_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    sPathDocSiteWebDUP = String.Format(RechercheParamByLib("REP_FICHE_CE"))
    sFileName = "DUP1.pdf"

    WBApercu.Navigate("about:blank")

    If Directory.Exists(sPathDocSiteWebDUP) = True Then

      LoadDoc()

    Else

      BtnNew.Visible = False

    End If

  End Sub

  Private Sub LoadDoc()

    If File.Exists(sPathDocSiteWebDUP & sFileName) Then

      WBApercu.Navigate(sPathDocSiteWebDUP & sFileName)

    End If

  End Sub

  Private Sub BtnClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnClose.Click

    Me.Close()

  End Sub

  Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click

    'INIT
    WBApercu.Navigate("about:blank")

    Select Case MessageBox.Show(My.Resources.GestionDesDocument_frmGestionDocDUPWebTech_DUP, My.Resources.GestionDesDocument_frmGestionDocDUPWebTech_DUP_new, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

      Case Windows.Forms.DialogResult.Yes

        ODF.ShowDialog()

        If ODF.FileName <> "" Then

          'on save l'ancien
          If Directory.Exists(sPathDocSiteWebDUP & "Archives\") Then Directory.CreateDirectory(sPathDocSiteWebDUP & "Archives\")

          File.Copy(sPathDocSiteWebDUP & sFileName, String.Format(sPathDocSiteWebDUP & "Archives\DUP{0}{1}{2}.pdf", Now.Year, Now.Month, Now.Day), True)

          'on renomme le nouveau
          File.Copy(ODF.FileName, sPathDocSiteWebDUP & sFileName, True)

        End If


    End Select

    LoadDoc()

  End Sub

End Class