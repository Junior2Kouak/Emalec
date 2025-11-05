<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XR_Page_Garde
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XR_Page_Garde))
        Me.Detail_Page_Garde = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin_Page_Garde = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin_Page_Garde = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DR_PageGarde = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Dt_PageGarde = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLblSommaire = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrRichTxtSommaire = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrLblPeriode = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLblRapportFmTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLblIntitule = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLblVCLINOM = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictLogoLOGOCLIENT = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictBoxBandeau = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictLogoGROUP = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.RF_PageGarde = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLbldateEdition = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCrossBandBoxBordersAllPage = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo_Chap_Maintenance = New DevExpress.XtraReports.UI.XRPageInfo()
        CType(Me.XrRichTxtSommaire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail_Page_Garde
        '
        Me.Detail_Page_Garde.HeightF = 0!
        Me.Detail_Page_Garde.Name = "Detail_Page_Garde"
        Me.Detail_Page_Garde.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail_Page_Garde.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin_Page_Garde
        '
        Me.TopMargin_Page_Garde.HeightF = 13.35119!
        Me.TopMargin_Page_Garde.Name = "TopMargin_Page_Garde"
        Me.TopMargin_Page_Garde.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin_Page_Garde.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin_Page_Garde
        '
        Me.BottomMargin_Page_Garde.HeightF = 9.083111!
        Me.BottomMargin_Page_Garde.Name = "BottomMargin_Page_Garde"
        Me.BottomMargin_Page_Garde.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin_Page_Garde.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DR_PageGarde
        '
        Me.DR_PageGarde.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Dt_PageGarde, Me.RF_PageGarde})
        Me.DR_PageGarde.Level = 0
        Me.DR_PageGarde.Name = "DR_PageGarde"
        '
        'Dt_PageGarde
        '
        Me.Dt_PageGarde.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLblSommaire, Me.XrRichTxtSommaire, Me.XrLblPeriode, Me.XrLblRapportFmTitle, Me.XrLblIntitule, Me.XrLblVCLINOM, Me.XrPictLogoLOGOCLIENT, Me.XrPictBoxBandeau, Me.XrPictLogoGROUP})
        Me.Dt_PageGarde.HeightF = 916.6667!
        Me.Dt_PageGarde.Name = "Dt_PageGarde"
        '
        'XrLblSommaire
        '
        Me.XrLblSommaire.Font = New DevExpress.Drawing.DXFont("Century Gothic", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLblSommaire.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 650.4584!)
        Me.XrLblSommaire.Name = "XrLblSommaire"
        Me.XrLblSommaire.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblSommaire.SizeF = New System.Drawing.SizeF(757.4998!, 23.0!)
        Me.XrLblSommaire.StylePriority.UseFont = False
        Me.XrLblSommaire.Text = "SOMMAIRE"
        '
        'XrRichTxtSommaire
        '
        Me.XrRichTxtSommaire.Font = New DevExpress.Drawing.DXFont("Century Gothic", 10.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrRichTxtSommaire.LocationFloat = New DevExpress.Utils.PointFloat(12.50002!, 673.4584!)
        Me.XrRichTxtSommaire.Name = "XrRichTxtSommaire"
        Me.XrRichTxtSommaire.SerializableRtfString = resources.GetString("XrRichTxtSommaire.SerializableRtfString")
        Me.XrRichTxtSommaire.SizeF = New System.Drawing.SizeF(757.9164!, 233.2083!)
        Me.XrRichTxtSommaire.StylePriority.UseFont = False
        '
        'XrLblPeriode
        '
        Me.XrLblPeriode.Font = New DevExpress.Drawing.DXFont("Century Gothic", 18.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLblPeriode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrLblPeriode.LocationFloat = New DevExpress.Utils.PointFloat(9.999895!, 572.9167!)
        Me.XrLblPeriode.Name = "XrLblPeriode"
        Me.XrLblPeriode.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblPeriode.SizeF = New System.Drawing.SizeF(754.9999!, 42.70834!)
        Me.XrLblPeriode.StylePriority.UseFont = False
        Me.XrLblPeriode.StylePriority.UseForeColor = False
        Me.XrLblPeriode.StylePriority.UseTextAlignment = False
        Me.XrLblPeriode.Text = "Période du {0} au {1}"
        Me.XrLblPeriode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLblRapportFmTitle
        '
        Me.XrLblRapportFmTitle.Font = New DevExpress.Drawing.DXFont("Century Gothic", 18.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLblRapportFmTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrLblRapportFmTitle.LocationFloat = New DevExpress.Utils.PointFloat(9.999919!, 530.2083!)
        Me.XrLblRapportFmTitle.Name = "XrLblRapportFmTitle"
        Me.XrLblRapportFmTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblRapportFmTitle.SizeF = New System.Drawing.SizeF(753.9581!, 42.70834!)
        Me.XrLblRapportFmTitle.StylePriority.UseFont = False
        Me.XrLblRapportFmTitle.StylePriority.UseForeColor = False
        Me.XrLblRapportFmTitle.StylePriority.UseTextAlignment = False
        Me.XrLblRapportFmTitle.Text = "Rapport d'activité"
        Me.XrLblRapportFmTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLblIntitule
        '
        Me.XrLblIntitule.Font = New DevExpress.Drawing.DXFont("Century Gothic", 18.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLblIntitule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrLblIntitule.LocationFloat = New DevExpress.Utils.PointFloat(9.999895!, 487.5!)
        Me.XrLblIntitule.Name = "XrLblIntitule"
        Me.XrLblIntitule.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblIntitule.SizeF = New System.Drawing.SizeF(754.9999!, 42.70834!)
        Me.XrLblIntitule.StylePriority.UseFont = False
        Me.XrLblIntitule.StylePriority.UseForeColor = False
        Me.XrLblIntitule.StylePriority.UseTextAlignment = False
        Me.XrLblIntitule.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLblVCLINOM
        '
        Me.XrLblVCLINOM.Font = New DevExpress.Drawing.DXFont("Century Gothic", 20.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLblVCLINOM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrLblVCLINOM.LocationFloat = New DevExpress.Utils.PointFloat(9.999935!, 444.7917!)
        Me.XrLblVCLINOM.Name = "XrLblVCLINOM"
        Me.XrLblVCLINOM.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblVCLINOM.SizeF = New System.Drawing.SizeF(754.9999!, 42.70834!)
        Me.XrLblVCLINOM.StylePriority.UseFont = False
        Me.XrLblVCLINOM.StylePriority.UseForeColor = False
        Me.XrLblVCLINOM.StylePriority.UseTextAlignment = False
        Me.XrLblVCLINOM.Text = "VCLINOM"
        Me.XrLblVCLINOM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPictLogoLOGOCLIENT
        '
        Me.XrPictLogoLOGOCLIENT.LocationFloat = New DevExpress.Utils.PointFloat(14.99998!, 10.00001!)
        Me.XrPictLogoLOGOCLIENT.Name = "XrPictLogoLOGOCLIENT"
        Me.XrPictLogoLOGOCLIENT.SizeF = New System.Drawing.SizeF(205.2083!, 48.0!)
        Me.XrPictLogoLOGOCLIENT.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'XrPictBoxBandeau
        '
        Me.XrPictBoxBandeau.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 242.2917!)
        Me.XrPictBoxBandeau.Name = "XrPictBoxBandeau"
        Me.XrPictBoxBandeau.SizeF = New System.Drawing.SizeF(753.9581!, 165.7083!)
        Me.XrPictBoxBandeau.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'XrPictLogoGROUP
        '
        Me.XrPictLogoGROUP.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopRight
        Me.XrPictLogoGROUP.LocationFloat = New DevExpress.Utils.PointFloat(376.4583!, 10.00001!)
        Me.XrPictLogoGROUP.Name = "XrPictLogoGROUP"
        Me.XrPictLogoGROUP.SizeF = New System.Drawing.SizeF(388.5417!, 95.91666!)
        Me.XrPictLogoGROUP.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'RF_PageGarde
        '
        Me.RF_PageGarde.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLbldateEdition})
        Me.RF_PageGarde.HeightF = 23.0!
        Me.RF_PageGarde.Name = "RF_PageGarde"
        Me.RF_PageGarde.PrintAtBottom = True
        '
        'XrLbldateEdition
        '
        Me.XrLbldateEdition.Font = New DevExpress.Drawing.DXFont("Century Gothic", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLbldateEdition.LocationFloat = New DevExpress.Utils.PointFloat(525.0002!, 0!)
        Me.XrLbldateEdition.Name = "XrLbldateEdition"
        Me.XrLbldateEdition.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLbldateEdition.SizeF = New System.Drawing.SizeF(242.4996!, 23.0!)
        Me.XrLbldateEdition.StylePriority.UseFont = False
        Me.XrLbldateEdition.StylePriority.UseTextAlignment = False
        Me.XrLbldateEdition.Text = "Edition du"
        Me.XrLbldateEdition.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrCrossBandBoxBordersAllPage
        '
        Me.XrCrossBandBoxBordersAllPage.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBoxBordersAllPage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrCrossBandBoxBordersAllPage.BorderWidth = 1.0!
        Me.XrCrossBandBoxBordersAllPage.EndBand = Me.BottomMargin_Page_Garde
        Me.XrCrossBandBoxBordersAllPage.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 4.270735!)
        Me.XrCrossBandBoxBordersAllPage.Name = "XrCrossBandBoxBordersAllPage"
        Me.XrCrossBandBoxBordersAllPage.StartBand = Me.TopMargin_Page_Garde
        Me.XrCrossBandBoxBordersAllPage.StartPointFloat = New DevExpress.Utils.PointFloat(0!, 7.291666!)
        Me.XrCrossBandBoxBordersAllPage.WidthF = 771.4581!
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo_Chap_Maintenance})
        Me.PageFooter.HeightF = 23.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo_Chap_Maintenance
        '
        Me.XrPageInfo_Chap_Maintenance.Font = New DevExpress.Drawing.DXFont("Century Gothic", 9.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrPageInfo_Chap_Maintenance.LocationFloat = New DevExpress.Utils.PointFloat(2.083294!, 0!)
        Me.XrPageInfo_Chap_Maintenance.Name = "XrPageInfo_Chap_Maintenance"
        Me.XrPageInfo_Chap_Maintenance.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo_Chap_Maintenance.SizeF = New System.Drawing.SizeF(768.3332!, 23.0!)
        Me.XrPageInfo_Chap_Maintenance.StylePriority.UseFont = False
        Me.XrPageInfo_Chap_Maintenance.StylePriority.UseTextAlignment = False
        Me.XrPageInfo_Chap_Maintenance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XR_Page_Garde
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail_Page_Garde, Me.TopMargin_Page_Garde, Me.BottomMargin_Page_Garde, Me.DR_PageGarde, Me.PageFooter})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBoxBordersAllPage})
        Me.Margins = New DevExpress.Drawing.DXMargins(29.0!, 23.0!, 13.35119!, 9.083111!)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "22.2"
        CType(Me.XrRichTxtSommaire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail_Page_Garde As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin_Page_Garde As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin_Page_Garde As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents DR_PageGarde As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Dt_PageGarde As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents RF_PageGarde As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLbldateEdition As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictLogoGROUP As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictBoxBandeau As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictLogoLOGOCLIENT As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLblVCLINOM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLblIntitule As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLblRapportFmTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLblPeriode As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrRichTxtSommaire As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrCrossBandBoxBordersAllPage As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo_Chap_Maintenance As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLblSommaire As DevExpress.XtraReports.UI.XRLabel
End Class
