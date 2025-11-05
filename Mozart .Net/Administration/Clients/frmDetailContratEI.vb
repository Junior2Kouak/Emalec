Imports DevExpress.XtraRichEdit
Imports MozartLib

Public Class frmDetailContratEI

  Dim _ContratEI As C_CONTRATEI

  Dim _NIDDONCCONTEI As Int32
  Dim _RelanceContrat As String

  Public Sub New(ByVal c_ContratEI As C_CONTRATEI, Optional ByVal C_RelContrat As String = "")

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _ContratEI = c_ContratEI
    _RelanceContrat = C_RelContrat

  End Sub

  Private Sub frmDetailContratEI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'label bouton envoi mail selon le type relance ou pas
    If _RelanceContrat = "R" Then
      BarButtonItemContratEI.Caption = My.Resources.Clients_frmDetailContratEl_Relancer
    Else
      BarButtonItemContratEI.Caption = My.Resources.Clients_frmDetailContratEl_Envoyer
    End If

    If _ContratEI.FileContratEI = "" Then
      RichEditCtrlContratEI.Document.RtfText = _ContratEI.RTFTEXT
    Else
      RichEditCtrlContratEI.LoadDocument(_ContratEI.FileContratEI, DocumentFormat.Undefined)
    End If

  End Sub

  Private Sub frmDetailContratEI_ResizeEnd(sender As Object, e As System.EventArgs) Handles Me.ResizeEnd
    RichEditCtrlContratEI.Top = RibbonCtrlContratEI.Top + RibbonCtrlContratEI.Height
    RichEditCtrlContratEI.Left = RibbonCtrlContratEI.Left
    RichEditCtrlContratEI.Width = RibbonCtrlContratEI.Width
    RichEditCtrlContratEI.Height = Me.Height - RibbonCtrlContratEI.Height - RibbonCtrlContratEI.Top
  End Sub

  Private Sub frmDetailContratEI_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged
    RichEditCtrlContratEI.Top = RibbonCtrlContratEI.Top + RibbonCtrlContratEI.Height
    RichEditCtrlContratEI.Left = RibbonCtrlContratEI.Left
    RichEditCtrlContratEI.Width = RibbonCtrlContratEI.Width
    RichEditCtrlContratEI.Height = Me.Height - RibbonCtrlContratEI.Height - RibbonCtrlContratEI.Top
  End Sub

  Private Sub BarButtonItemSaveContratEI_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemSaveContratEI.ItemClick

    _ContratEI.SaveDocRTF(RichEditCtrlContratEI.Document.RtfText)


    'on genere le fichier pdf
    Dim sFileOutPDF As String = String.Format("{0}PDF\EI_CONTRAT_{1}_{2}.pdf", MozartParams.CheminUtilisateurMozart, _ContratEI.NCLINUM, _ContratEI.NIDDOCCONTEI)

    'nettoyage
    If File.Exists(sFileOutPDF) Then File.Delete(sFileOutPDF)

    If Directory.Exists(Path.GetPathRoot(sFileOutPDF)) = False Then Directory.CreateDirectory(Path.GetPathRoot(sFileOutPDF))

    RichEditCtrlContratEI.ExportToPdf(sFileOutPDF)

    'on enregistre le contrat dans la table des contrat
    _ContratEI.SaveContratEiByClient(sFileOutPDF)

    'nettoyage
    '_ContratEI.Reinit(sFileOutPDF)

  End Sub

  Private Sub BarButtonItemContratEI_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemContratEI.ItemClick

    'on teste si le contrat existe dans la table
    If _ContratEI.NIDDOCCONTEI = 0 Then MessageBox.Show(My.Resources.Admin_frmDetailContratEl_saveC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

    'on test si le contrat a deja été envoyé
    If _ContratEI.DDOCCONTEIENVOI <> "" And _RelanceContrat <> "R" Then

      Select Case MessageBox.Show(String.Format(My.Resources.Admin_frmDetailContratEl_contrat_envoyé & vbCrLf & My.Resources.Admin_frmDetailContratEl_renvoyer, _ContratEI.DDOCCONTEIENVOI), My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
        Case vbYes
        Case Else
          Exit Sub
      End Select
    End If

    'on genere le fichier pdf
    Dim sFileOutPDF As String = String.Format("{0}PDF\EI_CONTRAT_{1}_{2}.pdf", MozartParams.CheminUtilisateurMozart, _ContratEI.NCLINUM, _ContratEI.NIDDOCCONTEI)

    'nettoyage
    If File.Exists(sFileOutPDF) Then File.Delete(sFileOutPDF)

    If Directory.Exists(Path.GetPathRoot(sFileOutPDF)) = False Then Directory.CreateDirectory(Path.GetPathRoot(sFileOutPDF))

    RichEditCtrlContratEI.ExportToPdf(sFileOutPDF)

    If File.Exists(sFileOutPDF) Then

      Dim oFrmSendMailCCL As New frmSendMailSelectContact(_ContratEI, sFileOutPDF, _RelanceContrat)
      oFrmSendMailCCL.ShowDialog()

    End If

  End Sub

End Class