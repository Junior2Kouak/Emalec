Imports System.Data.SqlClient
Imports DevExpress.XtraRichEdit.API.Native
Imports MozartLib

Public Class FrmDetailMessageMozart


  Dim oSqlConn As New CGestionSQL
  Dim sType As String
  Dim NINFONUM As Integer


  Public Sub New(ByVal i_msgNum As Integer)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    NINFONUM = i_msgNum           ' id de message

  End Sub

  Private Sub FrmDetailMessageWeb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

    Try

      ' titre 
      Me.Text = My.Resources.Admin_frmDetailMessageWeb_tech
      LoadData()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub LoadData()

    Dim sRequete As String
    Dim sqlcmd As SqlCommand
    Dim dr As SqlDataReader

    sRequete = String.Format("SELECT ISNULL(LINFOTXT, '') AS LINFOTXT FROM TINFO WHERE NINFONUM = {0}", NINFONUM)
    sqlcmd = New SqlCommand(sRequete, MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
    dr = sqlcmd.ExecuteReader
    If dr.HasRows = True Then
      dr.Read()
      RichEditCtrlMessWeb.RtfText = dr.Item("LINFOTXT")
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

  Private Sub frm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

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

    Dim sqlupdate As New SqlCommand("api_sp_CreationInfo", MozartDatabase.cnxMozart)
    sqlupdate.CommandType = System.Data.CommandType.StoredProcedure
    sqlupdate.Parameters.Add("@num", System.Data.SqlDbType.Int).Value = NINFONUM
    sqlupdate.Parameters.Add("@ltext", System.Data.SqlDbType.VarChar).Value = RichEditCtrlMessWeb.RtfText
    sqlupdate.Parameters.Add("@vText", System.Data.SqlDbType.VarChar).Value = RichEditCtrlMessWeb.Text
    sqlupdate.Parameters.Add("ID", SqlDbType.Int)

    sqlupdate.Parameters("ID").Direction = ParameterDirection.Output

    sqlupdate.ExecuteNonQuery()

    NINFONUM = sqlupdate.Parameters("ID").Value

    BarButtonItemSave.Enabled = False

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
      Select Case sType

        Case "T"
          sPathRepFilesLink = RechercheParamByLib("REP_FILESLINK_TECH")
          sUnderDirectory = "AllTech"

        Case "P"
          sPathRepFilesLink = RechercheParamByLib("REP_FILESLINK_TECH")
          sUnderDirectory = "AllCont"

        Case "O"
          sPathRepFilesLink = RechercheParamByLib("REP_FILESLINK_TECH")
          sUnderDirectory = String.Format("ByTech\{0}", BarEditItemTech.EditValue)
          If Directory.Exists(sPathRepFilesLink & MozartParams.NomSociete & "\" & sUnderDirectory & "\") = False Then Directory.CreateDirectory(sPathRepFilesLink & MozartParams.NomSociete & "\" & sUnderDirectory & "\")
        Case Else

          MessageBox.Show(String.Format(My.Resources.Admin_MessagesWeb_FrmDetailMessageWeb_TypeInconnu, sType), My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
          Exit Sub

      End Select

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

End Class