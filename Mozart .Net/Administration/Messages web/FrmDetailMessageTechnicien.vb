Imports System.Data.SqlClient
Imports DevExpress.XtraRichEdit.API.Native
Imports MozartLib

Public Class FrmDetailMessageTechnicien


  Dim oSqlConn As New CGestionSQL
  Dim sType As String
  Dim NMESNUM As Int32
  Dim _societe As String

  'Etat du bouton "Reproduire la mise en forme"
  Private mState As Integer
  'Range de sélection pour la reproduction de la mise en forme
  Private mDocRange As DocumentRange


  Public Sub New(ByVal c_sType As String, ByVal i_msgNum As Int32, Optional ByVal c_vsociete As String = "")

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    sType = c_sType             ' mode création ou visu
    NMESNUM = i_msgNum           ' id de message
    If c_vsociete = "" Then
      _societe = MozartParams.NomSociete
    Else
      _societe = c_vsociete
    End If

  End Sub

  Private Sub FrmDetailMessageWeb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

    Try

      'on vérifie les droits user
      If ModMessWeb.Authorized(sType) = True Then

        ' titre 
        Me.Text = My.Resources.Admin_frmDetailMessageWeb_tech
        BarButtonItemInsertImg.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        BarButtonItemAddPJ.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        Initboutons(Me)
        LoadData()

      Else
        MessageBox.Show(My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_Droits, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Me.Close()
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub LoadData()

    Dim sRequete As String
    Dim sqlcmd As SqlCommand
    Dim dr As SqlDataReader


    sRequete = $"SELECT VMESHTML FROM TMESSAGETECH WHERE NMESNUM = {NMESNUM}"
    sqlcmd = New SqlCommand(sRequete, MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
    dr = sqlcmd.ExecuteReader
    If dr.HasRows = True Then

      dr.Read()
      RichEditCtrlMessWeb.HtmlText = dr.Item("VMESHTML")

    End If
    If dr.IsClosed = False Then dr.Close()

  End Sub

  Private Sub BarButtonItemClose_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemClose.ItemClick
    Me.Close()
  End Sub

  Private Sub FrmDetailMessageWeb_ResizeEnd(sender As Object, e As System.EventArgs) Handles Me.ResizeEnd

    RichEditCtrlMessWeb.Top = RibbonCtrlMessWeb.Top + RibbonCtrlMessWeb.Height
    RichEditCtrlMessWeb.Left = RibbonCtrlMessWeb.Left
    RichEditCtrlMessWeb.Width = RibbonCtrlMessWeb.Width
    RichEditCtrlMessWeb.Height = Me.Height - RibbonCtrlMessWeb.Height - RibbonCtrlMessWeb.Top

  End Sub

  Private Sub FrmDetailMessageWeb_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged

    RichEditCtrlMessWeb.Top = RibbonCtrlMessWeb.Top + RibbonCtrlMessWeb.Height
    RichEditCtrlMessWeb.Left = RibbonCtrlMessWeb.Left
    RichEditCtrlMessWeb.Width = RibbonCtrlMessWeb.Width
    RichEditCtrlMessWeb.Height = Me.Height - RibbonCtrlMessWeb.Height - RibbonCtrlMessWeb.Top

  End Sub

  Private Sub RichEditCtrlMessWeb_BeforeExport(sender As Object, e As DevExpress.XtraRichEdit.BeforeExportEventArgs) Handles RichEditCtrlMessWeb.BeforeExport

    'export en html sans le flux css
    Dim Options As DevExpress.XtraRichEdit.Export.HtmlDocumentExporterOptions = TryCast(e.Options, DevExpress.XtraRichEdit.Export.HtmlDocumentExporterOptions)

    If Not Options Is Nothing Then

      Options.CssPropertiesExportType = DevExpress.XtraRichEdit.Export.Html.CssPropertiesExportType.Inline

    End If

  End Sub

  Private Sub RichEditCtrlMessWeb_DocumentLoaded(sender As Object, e As System.EventArgs) Handles RichEditCtrlMessWeb.DocumentLoaded
    'init
    RichEditCtrlMessWeb.Document.DefaultCharacterProperties.FontName = "Arial"
    RichEditCtrlMessWeb.Document.DefaultCharacterProperties.FontSize = 11

  End Sub

  Private Sub RichEditCtrlMessWeb_EmptyDocumentCreated(sender As Object, e As System.EventArgs) Handles RichEditCtrlMessWeb.EmptyDocumentCreated

    RichEditCtrlMessWeb.Document.Unit = DevExpress.Office.DocumentUnit.Inch
    RichEditCtrlMessWeb.Document.Sections(0).Margins.Left = 0.5F
    RichEditCtrlMessWeb.Document.Sections(0).Margins.Right = 0.5F
    RichEditCtrlMessWeb.Document.Sections(0).Margins.Top = 0.5F
    RichEditCtrlMessWeb.Document.Sections(0).Margins.Bottom = 0.5F

  End Sub

  Private Sub frmGestionDocFicheRecru_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    If RichEditCtrlMessWeb.Modified = True Then

      Select Case MessageBox.Show(My.Resources.Global_ModifNonSauvegardé, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

        Case Windows.Forms.DialogResult.Yes
          SaveMessageWeb()
        Case Windows.Forms.DialogResult.Cancel
          e.Cancel = True

      End Select

    End If

  End Sub

  Private Sub SaveMessageWeb()



    Dim sqlupdate As New SqlCommand("api_sp_CreationMessageTechnicien", MozartDatabase.cnxMozart)
    sqlupdate.CommandType = System.Data.CommandType.StoredProcedure
    sqlupdate.Parameters.Add("@p_nmesnum", System.Data.SqlDbType.Int).Value = NMESNUM
    If Len(RichEditCtrlMessWeb.Text) > 121 Then
      sqlupdate.Parameters.Add("@p_vmeslib", System.Data.SqlDbType.VarChar).Value = RichEditCtrlMessWeb.Text.Substring(0, 120)
    Else
      sqlupdate.Parameters.Add("@p_vmeslib", System.Data.SqlDbType.VarChar).Value = RichEditCtrlMessWeb.Text
    End If
    sqlupdate.Parameters.Add("@p_vmeshtml", System.Data.SqlDbType.VarChar).Value = RichEditCtrlMessWeb.HtmlText
    sqlupdate.Parameters.Add("@p_vsociete", System.Data.SqlDbType.VarChar).Value = _societe
    sqlupdate.Parameters.Add("ID", SqlDbType.Int)
    sqlupdate.Parameters("ID").Direction = ParameterDirection.Output

    sqlupdate.ExecuteNonQuery()

    NMESNUM = sqlupdate.Parameters("ID").Value

    BarButtonItemSave.Enabled = False

    'raz pour afficher la fenetre sur mozart à tous le personnel mozart
    ModuleData.ExecuteNonQuery($"EXEC [api_sp_Msg_Personne_New] '{_societe}'")


  End Sub

  Private Sub RichEditCtrlMessWeb_RtfTextChanged(sender As Object, e As System.EventArgs) Handles RichEditCtrlMessWeb.RtfTextChanged
    BarButtonItemSave.Enabled = True
  End Sub


  Private Sub BarButtonItemSave_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemSave.ItemClick

    If MessageBox.Show(My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_Enreg, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

      SaveMessageWeb()
      RichEditCtrlMessWeb.Modified = False

    End If

  End Sub

  Private Sub BarButtonItemInsertImg_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemInsertImg.ItemClick

    OFD.Filter = My.Resources.Global_Filter_FilesImages
    OFD.ShowDialog()

    If OFD.FileName <> "" Then

      'on teste la taille du fichier
      'taille maxi 2 mo
      Dim oFileInfo As New FileInfo(OFD.FileName)
      If oFileInfo.Length > 2000000 Then
        If MessageBox.Show(My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_FileSizeMax, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) <> vbYes Then Exit Sub
      End If

      RichEditCtrlMessWeb.Document.Images.Insert(RichEditCtrlMessWeb.Document.CaretPosition, DevExpress.XtraRichEdit.API.Native.DocumentImageSource.FromStream((File.Open(OFD.FileName, FileMode.Open))))

    End If

  End Sub

  Private Sub BarButtonItemAddPJ_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAddPJ.ItemClick

    OFD.FileName = ""
    OFD.Filter = My.Resources.Global_Filter_FilesPDFImages
    OFD.ShowDialog()

    If OFD.FileName <> "" Then

      Dim sPathRepFilesLink As String
      Dim sUnderDirectory As String
      Dim UrlPJ As String = ""
      Dim sNomFileHTML As String = InputBox(My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_SaisieNomFile, My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_NomFile)

      If sNomFileHTML = "" Then Exit Sub

      'on teste la taille du fichier
      'taille maxi 2 mo
      Dim oFileInfo As New FileInfo(OFD.FileName)
      If oFileInfo.Length > 2000000 Then
        If MessageBox.Show(My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_FileSizeMax, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) <> vbYes Then Exit Sub
      End If

      'on teste si le fichier existe deja en le dossier dest
      'selon le type
      sPathRepFilesLink = RechercheParamByLib("REP_FILESLINK_TECH")
      sUnderDirectory = "AllTech"

      '-------------- Copy du fichier
      If Directory.Exists(sPathRepFilesLink) = False Then MessageBox.Show(String.Format(My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_DossierErreur, sPathRepFilesLink), My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
      If Directory.Exists(sPathRepFilesLink & MozartParams.NomSociete & "\" & sUnderDirectory & "\") = False Then MessageBox.Show(String.Format(My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_DossierErreur, sPathRepFilesLink & MozartParams.NomSociete & "\" & sUnderDirectory & "\"), My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub

      'copy du fichier selon le type
      If File.Exists(sPathRepFilesLink & MozartParams.NomSociete & "\" & sUnderDirectory & "\" & Path.GetFileName(OFD.FileName)) = True Then
        If MessageBox.Show(String.Format(My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_FileErreur & vbCrLf & My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_FileRemplace, sPathRepFilesLink & MozartParams.NomSociete & "\" & sUnderDirectory & "\" & Path.GetFileName(OFD.FileName)), My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) = vbYes Then
          File.Copy(OFD.FileName, sPathRepFilesLink & MozartParams.NomSociete & "\" & sUnderDirectory & "\" & Path.GetFileName(OFD.FileName), True)
        Else
          Exit Sub
        End If
      Else
        File.Copy(OFD.FileName, sPathRepFilesLink & MozartParams.NomSociete & "\" & sUnderDirectory & "\" & Path.GetFileName(OFD.FileName), True)
      End If

      UrlPJ = UrlEncrypt(sPathRepFilesLink & MozartParams.NomSociete & "\" & sUnderDirectory & "\" & Path.GetFileName(OFD.FileName))

      If UrlPJ = "" Then
        MessageBox.Show(My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_FileNC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Exit Sub
      End If

      'mise en forme
      UrlPJ = String.Format("./RedirectionDocument.aspx?Key={0}", UrlPJ)

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

      Dim linkImage As DocumentImage = RichEditCtrlMessWeb.Document.Images.Insert(RichEditCtrlMessWeb.Document.CaretPosition, DevExpress.XtraRichEdit.API.Native.DocumentImageSource.FromImage(oIconeDest))

      Dim insertedRange As DocumentRange = RichEditCtrlMessWeb.Document.InsertHtmlText(linkImage.Range.End, String.Format("<br>{0}", sNomFileHTML))

      Dim charProps As CharacterProperties = RichEditCtrlMessWeb.Document.BeginUpdateCharacters(insertedRange)
      charProps.FontName = RichEditCtrlMessWeb.Document.DefaultCharacterProperties.FontName
      charProps.FontSize = RichEditCtrlMessWeb.Document.DefaultCharacterProperties.FontSize
      RichEditCtrlMessWeb.Document.EndUpdateCharacters(charProps)

      Dim linkHref As Hyperlink = RichEditCtrlMessWeb.Document.Hyperlinks.Create(linkImage.Range)
      linkHref.NavigateUri = UrlPJ

    End If

  End Sub

  Private Function UrlEncrypt(ByVal p_file As String) As String

    Try
      Dim command As New SqlCommand(String.Format("SELECT dbo.[GenerateFileKeyOnlyFile]('{0}')", p_file), MozartDatabase.cnxMozart)
      Return command.ExecuteScalar()
    Catch ex As Exception
      'On retourne une chaîne vide s'il est impossible de decrypter la chaîne fournie
      Return ""
    End Try

  End Function

  Private Sub BarEditItemSociete_EditValueChanged(sender As Object, e As System.EventArgs) Handles BarEditItemSociete.EditValueChanged
    BarButtonItemSave.Enabled = True
    LoadData()
  End Sub

  Private Sub BarCheckItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem1.ItemClick
    Select Case mState
      Case 0
        BarCheckItem1.Checked = True
        mState = 1
        mDocRange = RichEditCtrlMessWeb.Document.Selection

      Case 1, 2
        BarCheckItem1.Checked = False
        mState = 0
    End Select
  End Sub

  Private Sub BarCheckItem1_ItemDoubleClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarCheckItem1.ItemDoubleClick
    BarCheckItem1.Checked = True
    mState = 2
    mDocRange = RichEditCtrlMessWeb.Document.Selection
  End Sub

  Private Sub RichEditCtrlMessWeb_MouseUp(sender As Object, e As MouseEventArgs) Handles RichEditCtrlMessWeb.MouseUp
    Dim lCharPropFrom As CharacterProperties
    Dim lCharPropTo As CharacterProperties

    With RichEditCtrlMessWeb
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

End Class