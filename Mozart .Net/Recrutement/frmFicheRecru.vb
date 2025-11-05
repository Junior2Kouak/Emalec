Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Utils.Menu

Public Class frmFicheRecru

    Dim oFicheRecrutement As CFicheRecrutement
    Dim collection As ReadOnlyDocumentImageCollection

    Public Sub New(ByVal c_NRECRUNUM As Object)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        oFicheRecrutement = New CFicheRecrutement(c_NRECRUNUM)

    End Sub

    Private Sub frmFicheRecru_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        oFicheRecrutement.LoadDocRTF()

        If oFicheRecrutement.sDocRTFSrc <> "" Then

            RichEditCtrlFicheRecru.Document.RtfText = oFicheRecrutement.sDocRTFSrc

        Else

            If oFicheRecrutement.sFileDocFicheRecru_Old <> "" Then

                RichEditCtrlFicheRecru.LoadDocument(oFicheRecrutement.sFileDocFicheRecru_Old)

            Else

                RichEditCtrlFicheRecru.CreateNewDocument()

                RichEditCtrlFicheRecru.RtfText = "{\rtf1\deff0{\fonttbl{\f0 Calibri;}{\f1 Arial;}}{\colortbl ;\red0\green0\blue255 ;}{\*\defchp \fs22}{\stylesheet {\ql\fs22 Normal;}{\*\cs1\fs22 Default Paragraph Font;}{\*\cs2\sbasedon1\fs22 Line Number;}" _
                                                & "{\*\cs3\ul\fs22\cf1 Hyperlink;}{\*\ts4\tsrowd\fs22\ql\tscellpaddfl3\tscellpaddl108\tscellpaddfb3\tscellpaddfr3\tscellpaddr108\tscellpaddft3\tsvertalt\cltxlrtb Normal Table;}" _
                                                & "{\*\ts5\tsrowd\sbasedon4\fs22\ql\trbrdrt\brdrs\brdrw10\trbrdrl\brdrs\brdrw10\trbrdrb\brdrs\brdrw10\trbrdrr\brdrs\brdrw10\trbrdrh\brdrs\brdrw10\trbrdrv\brdrs\brdrw10\tscellpaddfl3\tscellpaddl108\tscellpaddfr3\tscellpaddr108\tsvertalt\cltxlrtb Table Simple 1;}}" _
                                                & "{\*\listoverridetable}\nouicompat\splytwnine\htmautsp\sectd\marglsxn1417\margrsxn1417\margtsxn1417\margbsxn1417\pard\plain\qr{\f1\fs20\cf0 Date d'impression : }{\field{\*\fldinst{\f1\fs20\cf0  }}" _
                                                & "{\fldrslt{\f1\fs20\cf0 " & Now.Date.ToShortDateString & "}}}\f1\fs28\par\pard\plain\qr\f1\fs28\par\pard\plain\qr\f1\fs28\par\pard\plain\qc{\f1\fs28\cf0 FICHE PERSONNELLE de " & oFicheRecrutement.sNomPer + " " + oFicheRecrutement.sPrenomPer & "}\f1\fs28\par\pard\plain\ql\fs22\par}"

            End If

        End If

    End Sub

    Private Sub frmGestionDocFicheRecru_ResizeEnd(sender As Object, e As System.EventArgs) Handles Me.ResizeEnd

        RichEditCtrlFicheRecru.Top = RibbonCtrlRecru.Top + RibbonCtrlRecru.Height
        RichEditCtrlFicheRecru.Left = RibbonCtrlRecru.Left
        RichEditCtrlFicheRecru.Width = RibbonCtrlRecru.Width
        RichEditCtrlFicheRecru.Height = Me.Height - RibbonCtrlRecru.Height - RibbonCtrlRecru.Top

    End Sub

    Private Sub frmGestionDocFicheRecru_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged

        RichEditCtrlFicheRecru.Top = RibbonCtrlRecru.Top + RibbonCtrlRecru.Height
        RichEditCtrlFicheRecru.Left = RibbonCtrlRecru.Left
        RichEditCtrlFicheRecru.Width = RibbonCtrlRecru.Width
        RichEditCtrlFicheRecru.Height = Me.Height - RibbonCtrlRecru.Height - RibbonCtrlRecru.Top

    End Sub

    Private Sub RichEditCtrlFicheRecru_EmptyDocumentCreated(sender As Object, e As System.EventArgs) Handles RichEditCtrlFicheRecru.EmptyDocumentCreated

        RichEditCtrlFicheRecru.Document.Unit = DevExpress.Office.DocumentUnit.Inch
        RichEditCtrlFicheRecru.Document.Sections(0).Margins.Left = 0.5F
        RichEditCtrlFicheRecru.Document.Sections(0).Margins.Right = 0.5F
        RichEditCtrlFicheRecru.Document.Sections(0).Margins.Top = 0.5F
        RichEditCtrlFicheRecru.Document.Sections(0).Margins.Bottom = 0.5F

    End Sub

    Private Sub BarButtonItemSave_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemSave.ItemClick

        oFicheRecrutement.SaveDocRTF(RichEditCtrlFicheRecru.Document.RtfText)
        RichEditCtrlFicheRecru.Modified = False

    End Sub

    Private Sub BarButtonItemClose_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemClose.ItemClick

        Me.Close()

    End Sub

    Private Sub frmGestionDocFicheRecru_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If RichEditCtrlFicheRecru.Modified = True Then

            Select Case MessageBox.Show(My.Resources.Global_ModifNonSauvegardé, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

                Case Windows.Forms.DialogResult.Yes
                    oFicheRecrutement.SaveDocRTF(RichEditCtrlFicheRecru.Document.RtfText)
                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True

            End Select

        End If

    End Sub

    Private Sub RichEditCtrlFicheRecru_PopupMenuShowing(sender As Object, e As DevExpress.XtraRichEdit.PopupMenuShowingEventArgs) Handles RichEditCtrlFicheRecru.PopupMenuShowing

        collection = RichEditCtrlFicheRecru.Document.Images.Get(RichEditCtrlFicheRecru.Document.Selection)

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

                    RichEditCtrlFicheRecru.Document.Delete(RichEditCtrlFicheRecru.Document.Selection)
                    ms.Position = 0
                    RichEditCtrlFicheRecru.Document.Images.Insert(RichEditCtrlFicheRecru.Document.CaretPosition, image.FromStream(ms))
                    RichEditCtrlFicheRecru.Refresh()

                    ImageOut.Dispose()

                End If

            End If

        End If
        frmCroppingImage.Dispose()

    End Sub

End Class