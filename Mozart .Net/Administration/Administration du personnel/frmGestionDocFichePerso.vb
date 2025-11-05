Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraSpellChecker
Imports System.Globalization

Public Class frmGestionDocFichePerso

    Dim oFichePerso As CFichePerso
    Dim collection As ReadOnlyDocumentImageCollection

    Public Sub New(ByVal c_NPERNUM As Object)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        oFichePerso = New CFichePerso(c_NPERNUM)

    End Sub

    Private Sub frmGestionDocFichePerso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'copie des dicotionnarires
    Dim oDictionnary As New CDictionnaries("FR")
    Dim dic_fr_FR As SpellCheckerOpenOfficeDictionary = New SpellCheckerOpenOfficeDictionary
    dic_fr_FR.DictionaryPath = If(oDictionnary.DictionnaryFile <> "", oDictionnary.DictionnaryFile, "")
    dic_fr_FR.GrammarPath = If(oDictionnary.GrammarFile <> "", oDictionnary.GrammarFile, "")
    dic_fr_FR.Culture = New CultureInfo("fr-FR")
    SpellChecker.Dictionaries.Add(dic_fr_FR)

    If oFichePerso.DroitLectureDocRTFPersoIsOk() = False Then Me.Close()

        oFichePerso.LoadDocRTF()

        If oFichePerso.sDocRTFSrc <> "" Then

            RichEditCtrlFichePerso.Document.RtfText = oFichePerso.sDocRTFSrc

        Else

            If oFichePerso.sFileDocFichePerso_Old <> "" Then

                RichEditCtrlFichePerso.LoadDocument(oFichePerso.sFileDocFichePerso_Old)

            Else

                RichEditCtrlFichePerso.CreateNewDocument()

                RichEditCtrlFichePerso.RtfText = "{\rtf1\deff0{\fonttbl{\f0 Calibri;}{\f1 Arial;}}{\colortbl ;\red0\green0\blue255 ;}{\*\defchp \fs22}{\stylesheet {\ql\fs22 Normal;}{\*\cs1\fs22 Default Paragraph Font;}{\*\cs2\sbasedon1\fs22 Line Number;}" _
                                               & "{\*\cs3\ul\fs22\cf1 Hyperlink;}{\*\ts4\tsrowd\fs22\ql\tscellpaddfl3\tscellpaddl108\tscellpaddfb3\tscellpaddfr3\tscellpaddr108\tscellpaddft3\tsvertalt\cltxlrtb Normal Table;}" _
                                               & "{\*\ts5\tsrowd\sbasedon4\fs22\ql\trbrdrt\brdrs\brdrw10\trbrdrl\brdrs\brdrw10\trbrdrb\brdrs\brdrw10\trbrdrr\brdrs\brdrw10\trbrdrh\brdrs\brdrw10\trbrdrv\brdrs\brdrw10\tscellpaddfl3\tscellpaddl108\tscellpaddfr3\tscellpaddr108\tsvertalt\cltxlrtb Table Simple 1;}}" _
                                               & "{\*\listoverridetable}\nouicompat\splytwnine\htmautsp\sectd\marglsxn1417\margrsxn1417\margtsxn1417\margbsxn1417\pard\plain\qr{\f1\fs20\cf0 Date d'impression : }{\field{\*\fldinst{\f1\fs20\cf0  }}" _
                                               & "{\fldrslt{\f1\fs20\cf0 " & Now.Date.ToShortDateString & "}}}\f1\fs28\par\pard\plain\qr\f1\fs28\par\pard\plain\qr\f1\fs28\par\pard\plain\qc{\f1\fs28\cf0 FICHE PERSONNELLE de " & oFichePerso.sNomPer + " " + oFichePerso.sPrenomPer & "}\f1\fs28\par\pard\plain\ql\fs22\par}"

            End If

        End If

    End Sub

    Private Sub frmGestionDocFichePerso_ResizeEnd(sender As Object, e As System.EventArgs) Handles Me.ResizeEnd

        RichEditCtrlFichePerso.Top = RibbonCtrlFichePerso.Top + RibbonCtrlFichePerso.Height
        RichEditCtrlFichePerso.Left = RibbonCtrlFichePerso.Left
        RichEditCtrlFichePerso.Width = RibbonCtrlFichePerso.Width
        RichEditCtrlFichePerso.Height = Me.Height - RibbonCtrlFichePerso.Height - RibbonCtrlFichePerso.Top

    End Sub

    Private Sub frmGestionDocFichePerso_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged

        RichEditCtrlFichePerso.Top = RibbonCtrlFichePerso.Top + RibbonCtrlFichePerso.Height
        RichEditCtrlFichePerso.Left = RibbonCtrlFichePerso.Left
        RichEditCtrlFichePerso.Width = RibbonCtrlFichePerso.Width
        RichEditCtrlFichePerso.Height = Me.Height - RibbonCtrlFichePerso.Height - RibbonCtrlFichePerso.Top

    End Sub

    Private Sub RichEditCtrlFichePerso_EmptyDocumentCreated(sender As Object, e As System.EventArgs) Handles RichEditCtrlFichePerso.EmptyDocumentCreated

        RichEditCtrlFichePerso.Document.Unit = DevExpress.Office.DocumentUnit.Inch
        RichEditCtrlFichePerso.Document.Sections(0).Margins.Left = 0.5F
        RichEditCtrlFichePerso.Document.Sections(0).Margins.Right = 0.5F
        RichEditCtrlFichePerso.Document.Sections(0).Margins.Top = 0.5F
        RichEditCtrlFichePerso.Document.Sections(0).Margins.Bottom = 0.5F

    End Sub


    Private Sub BarButtonItemSave_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemSave.ItemClick

        oFichePerso.SaveDocRTF(RichEditCtrlFichePerso.Document.RtfText)

        RichEditCtrlFichePerso.Modified = False

    End Sub

    Private Sub BarButtonItemClose_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemClose.ItemClick

        Me.Close()

    End Sub


    Private Sub frmGestionDocFichePerso_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If RichEditCtrlFichePerso.Modified = True Then

            Select Case MessageBox.Show(My.Resources.Global_ModifNonSauvegardé, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

                Case Windows.Forms.DialogResult.Yes
                    oFichePerso.SaveDocRTF(RichEditCtrlFichePerso.Document.RtfText)
                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True

            End Select

        End If

    End Sub

    Private Sub RichEditCtrlFichePerso_PopupMenuShowing(sender As Object, e As DevExpress.XtraRichEdit.PopupMenuShowingEventArgs) Handles RichEditCtrlFichePerso.PopupMenuShowing

        collection = RichEditCtrlFichePerso.Document.Images.Get(RichEditCtrlFichePerso.Document.Selection)

        If collection.Count <> 0 Then

            Dim item As New DXMenuItem(My.Resources.Global_RognerImage, New EventHandler(AddressOf EditImage))
            item.Image = My.Resources.crop_symbol
            e.Menu.Items.Add(item)

        End If

    End Sub

    Private Sub EditImage(ByVal sender As Object, ByVal e As EventArgs)
        Dim image As Image = collection(0).Image.NativeImage

        Dim frmCroppingImage As New FrmImageCropping(image)
        frmCroppingImage.ShowDialog()

        If frmCroppingImage.Cancel = False Then

            If Not frmCroppingImage.cropBitmapOut Is Nothing Then

                Dim ImageOut As Bitmap = frmCroppingImage.cropBitmapOut
                If Not ImageOut Is Nothing Then

                    Dim ms As MemoryStream = New MemoryStream
                    ImageOut.Save(ms, ImageFormat.Jpeg)

                    RichEditCtrlFichePerso.Document.Delete(RichEditCtrlFichePerso.Document.Selection)
                    ms.Position = 0
                    RichEditCtrlFichePerso.Document.Images.Insert(RichEditCtrlFichePerso.Document.CaretPosition, image.FromStream(ms))
                    RichEditCtrlFichePerso.Refresh()

                    ImageOut.Dispose()

                End If

            End If

        End If
        frmCroppingImage.Dispose()

    End Sub

End Class