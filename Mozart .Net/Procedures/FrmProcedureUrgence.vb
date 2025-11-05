' *******************************************************************************************************
' *******************************************************************************************************
' CETTE CLASSE EST UNE REFONTE DE LA CLASSE FRMPROCEDURE.CS POUR GERER UN AFFICHAGE DES PROCEDURES EN RTF
'
' *******************************************************************************************************
Imports DevExpress.XtraRichEdit.API.Native
Imports MozartLib

Public Class FrmProcedureUrgence

  'Etat du bouton "Reproduire la mise en forme"
  Private mState As Integer
  'Range de sélection pour la reproduction de la mise en forme
  Private mDocRange As DocumentRange

  Private Sub FrmProcedureUrgence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Try
      Cursor.Current = Cursors.WaitCursor
      Initboutons(Me)
      InitFeuille()

      BarButtonItemSave.Enabled = RechercheDroitMenu(201)
      RichEditCtrlProcUrge.ReadOnly = Not BarButtonItemSave.Enabled
    Catch ex As Exception
    Finally
      Cursor.Current = Cursors.Default
    End Try
  End Sub

  Private Sub InitFeuille()
    RichEditCtrlProcUrge.RtfText = ModuleData.RechercheParam("PROCEDURES", MozartParams.NomSociete)
  End Sub

  Private Sub BarButtonItemSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemSave.ItemClick
    Try
      If RichEditCtrlProcUrge.Modified Then
        If MessageBox.Show(My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_Enreg, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
          saveModif()
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub BarButtonItemClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemClose.ItemClick
    Close()
  End Sub

  Private Sub BarCheckItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem1.ItemClick
    Select Case mState
      Case 0
        BarCheckItem1.Checked = True
        mState = 1
        mDocRange = RichEditCtrlProcUrge.Document.Selection

      Case 1, 2
        BarCheckItem1.Checked = False
        mState = 0
    End Select
  End Sub

  Private Sub BarCheckItem1_ItemDoubleClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem1.ItemDoubleClick
    BarCheckItem1.Checked = True
    mState = 2
    mDocRange = RichEditCtrlProcUrge.Document.Selection
  End Sub

  Private Sub RichEditCtrlProcUrge_MouseUp(sender As Object, e As MouseEventArgs) Handles RichEditCtrlProcUrge.MouseUp
    Dim lCharPropFrom As CharacterProperties
    Dim lCharPropTo As CharacterProperties

    With RichEditCtrlProcUrge
      If mState <> 0 Then
        lCharPropTo = .Document.BeginUpdateCharacters(.Document.Selection)
        lCharPropFrom = .Document.BeginUpdateCharacters(mDocRange.Start, 1)
        lCharPropTo.Assign(lCharPropFrom)
        .Document.EndUpdateCharacters(lCharPropFrom)
        .Document.EndUpdateCharacters(lCharPropTo)

        If mState = 1 Then
          mState = 0
          BarCheckItem1.Checked = False
        End If
      End If
    End With
  End Sub

  Private Sub FrmProcedureUrgence_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    If RichEditCtrlProcUrge.Modified = True Then
      Select Case MessageBox.Show(My.Resources.Global_ModifNonSauvegardé, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
        Case Windows.Forms.DialogResult.Yes
          saveModif()
        Case Windows.Forms.DialogResult.Cancel
          e.Cancel = True
      End Select
    End If
  End Sub

  Private Sub saveModif()
    ModuleData.CnxExecute($"UPDATE TPAR SET VPARVAL = '{RichEditCtrlProcUrge.RtfText.Replace("'", "''")}' WHERE VPARLIB='PROCEDURES' AND VSOCIETE = '{MozartParams.NomSociete}'")
    RichEditCtrlProcUrge.Modified = False
  End Sub

  Private Sub BarButtonItemInsertImg_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemInsertImg.ItemClick
    OFD.FileName = ""
    OFD.Filter = My.Resources.Global_Filter_FilesImages
    OFD.ShowDialog()

    If OFD.FileName <> "" Then

      'on teste la taille du fichier
      'taille maxi 2 mo
      Dim oFileInfo As New FileInfo(OFD.FileName)
      If oFileInfo.Length > 2000000 Then
        If MessageBox.Show(My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_FileSizeMax, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) <> vbYes Then Exit Sub
      End If

      RichEditCtrlProcUrge.Document.Images.Insert(RichEditCtrlProcUrge.Document.CaretPosition, DevExpress.XtraRichEdit.API.Native.DocumentImageSource.FromStream((File.Open(OFD.FileName, FileMode.Open))))
    End If
  End Sub

  Private Sub BarButtonItemAddPJ_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAddPJ.ItemClick
    OFD.FileName = ""
    OFD.Filter = My.Resources.Global_Filter_FilesPDFImages
    OFD.ShowDialog()

    If OFD.FileName = "" Then
      Exit Sub
    End If

    Dim sPathRepFilesLink As String

    Dim sNomFile As String = InputBox(My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_SaisieNomFile, My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_NomFile)
    If sNomFile = "" Then
      Exit Sub
    End If

    'on teste la taille du fichier : Taille maxi 2 mo
    Dim oFileInfo As New FileInfo(OFD.FileName)
    If oFileInfo.Length > 2000000 Then
      If MessageBox.Show(My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_FileSizeMax, My.Resources.Global_Confirmation,
                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) <> vbYes Then
        Exit Sub
      End If
    End If

    sPathRepFilesLink = RechercheParamByLib("REP_FILESLINK_PROCURGE") & "\" & MozartParams.NomSociete
    If Not Directory.Exists(sPathRepFilesLink) Then
      Directory.CreateDirectory(sPathRepFilesLink)
    End If

    'copie du fichier
    If Not Directory.Exists(sPathRepFilesLink) Then
      MessageBox.Show(String.Format(My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_DossierErreur, sPathRepFilesLink), My.Resources.Global_Erreur,
                      MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub
    End If

    Dim lFullFileName As String = sPathRepFilesLink & "\" & Path.GetFileName(sNomFile) & Path.GetExtension(OFD.FileName)

    If File.Exists(lFullFileName) Then
      If MessageBox.Show(String.Format(My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_FileErreur & vbCrLf & My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_FileRemplace,
                         lFullFileName), My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) <> vbYes Then
        Exit Sub
      End If
    End If

    File.Copy(OFD.FileName, lFullFileName, True)

    Dim oIconeSrc As Bitmap
    Select Case Path.GetExtension(OFD.FileName).ToUpper
      Case ".PDF"
        oIconeSrc = New Bitmap(My.Resources.PDF)
      Case ".JPG", ".BMP", ".PNG"
        oIconeSrc = New Bitmap(My.Resources.Icone_photo)
      Case Else
        oIconeSrc = New Bitmap(My.Resources.Icone_File)
    End Select

    Dim oIconeDest As New Bitmap(48, 48)
    Dim gr_dest As Graphics = Graphics.FromImage(oIconeDest)
    gr_dest.DrawImage(oIconeSrc, 0, 0, oIconeDest.Width + 1, oIconeDest.Height + 1)

    With RichEditCtrlProcUrge
      Dim linkImage As DocumentImage = .Document.Images.Insert(.Document.CaretPosition, DocumentImageSource.FromImage(oIconeDest))
      Dim linkHref As Hyperlink = .Document.Hyperlinks.Create(linkImage.Range)
      linkHref.NavigateUri = lFullFileName
    End With
  End Sub

  Private Sub FrmProcedureUrgence_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    If GetAfficheProcUrgence() = True Then

      SetAfficheProcUrgence(False)

    End If

  End Sub
End Class