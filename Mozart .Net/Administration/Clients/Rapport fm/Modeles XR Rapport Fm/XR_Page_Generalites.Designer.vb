<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XR_Page_Generalites
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XR_Page_Generalites))
        Me.Detail_Generalites = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrrichTxtOrgaGen = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrLblOrgaGenTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin_Generalites = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin_Generalites = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrCrossBandBoxBordersAllPage = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo_Chap_Maintenance = New DevExpress.XtraReports.UI.XRPageInfo()
        CType(Me.XrrichTxtOrgaGen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail_Generalites
        '
        Me.Detail_Generalites.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrrichTxtOrgaGen, Me.XrLblOrgaGenTitle})
        Me.Detail_Generalites.Dpi = 100.0!
        Me.Detail_Generalites.HeightF = 930.6671!
        Me.Detail_Generalites.Name = "Detail_Generalites"
        Me.Detail_Generalites.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail_Generalites.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrrichTxtOrgaGen
        '
        Me.XrrichTxtOrgaGen.Dpi = 100.0!
        Me.XrrichTxtOrgaGen.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrrichTxtOrgaGen.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 52.70834!)
        Me.XrrichTxtOrgaGen.Name = "XrrichTxtOrgaGen"
        Me.XrrichTxtOrgaGen.SerializableRtfString = resources.GetString("XrrichTxtOrgaGen.SerializableRtfString")
        Me.XrrichTxtOrgaGen.SizeF = New System.Drawing.SizeF(754.9998!, 867.9588!)
        Me.XrrichTxtOrgaGen.StylePriority.UseFont = False
        '
        'XrLblOrgaGenTitle
        '
        Me.XrLblOrgaGenTitle.BorderColor = System.Drawing.Color.Black
        Me.XrLblOrgaGenTitle.Dpi = 100.0!
        Me.XrLblOrgaGenTitle.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblOrgaGenTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrLblOrgaGenTitle.LocationFloat = New DevExpress.Utils.PointFloat(11.00016!, 10.00001!)
        Me.XrLblOrgaGenTitle.Name = "XrLblOrgaGenTitle"
        Me.XrLblOrgaGenTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblOrgaGenTitle.SizeF = New System.Drawing.SizeF(754.9998!, 31.25!)
        Me.XrLblOrgaGenTitle.StylePriority.UseBorderColor = False
        Me.XrLblOrgaGenTitle.StylePriority.UseFont = False
        Me.XrLblOrgaGenTitle.StylePriority.UseForeColor = False
        Me.XrLblOrgaGenTitle.StylePriority.UseTextAlignment = False
        Me.XrLblOrgaGenTitle.Text = "Généralités"
        Me.XrLblOrgaGenTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TopMargin_Generalites
        '
        Me.TopMargin_Generalites.Dpi = 100.0!
        Me.TopMargin_Generalites.HeightF = 14.32292!
        Me.TopMargin_Generalites.Name = "TopMargin_Generalites"
        Me.TopMargin_Generalites.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin_Generalites.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin_Generalites
        '
        Me.BottomMargin_Generalites.Dpi = 100.0!
        Me.BottomMargin_Generalites.HeightF = 10.04243!
        Me.BottomMargin_Generalites.Name = "BottomMargin_Generalites"
        Me.BottomMargin_Generalites.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin_Generalites.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrCrossBandBoxBordersAllPage
        '
        Me.XrCrossBandBoxBordersAllPage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrCrossBandBoxBordersAllPage.BorderWidth = 1.0!
        Me.XrCrossBandBoxBordersAllPage.Dpi = 100.0!
        Me.XrCrossBandBoxBordersAllPage.EndBand = Me.BottomMargin_Generalites
        Me.XrCrossBandBoxBordersAllPage.EndPointFloat = New DevExpress.Utils.PointFloat(0.6249994!, 3.783417!)
        Me.XrCrossBandBoxBordersAllPage.LocationFloat = New DevExpress.Utils.PointFloat(0.6249994!, 9.374995!)
        Me.XrCrossBandBoxBordersAllPage.Name = "XrCrossBandBoxBordersAllPage"
        Me.XrCrossBandBoxBordersAllPage.StartBand = Me.TopMargin_Generalites
        Me.XrCrossBandBoxBordersAllPage.StartPointFloat = New DevExpress.Utils.PointFloat(0.6249994!, 9.374995!)
        Me.XrCrossBandBoxBordersAllPage.WidthF = 775.4167!
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo_Chap_Maintenance})
        Me.PageFooter.Dpi = 100.0!
        Me.PageFooter.HeightF = 23.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo_Chap_Maintenance
        '
        Me.XrPageInfo_Chap_Maintenance.Dpi = 100.0!
        Me.XrPageInfo_Chap_Maintenance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo_Chap_Maintenance.LocationFloat = New DevExpress.Utils.PointFloat(0.6249984!, 0!)
        Me.XrPageInfo_Chap_Maintenance.Name = "XrPageInfo_Chap_Maintenance"
        Me.XrPageInfo_Chap_Maintenance.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo_Chap_Maintenance.SizeF = New System.Drawing.SizeF(772.9167!, 23.0!)
        Me.XrPageInfo_Chap_Maintenance.StylePriority.UseFont = False
        Me.XrPageInfo_Chap_Maintenance.StylePriority.UseTextAlignment = False
        Me.XrPageInfo_Chap_Maintenance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XR_Page_Generalites
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail_Generalites, Me.TopMargin_Generalites, Me.BottomMargin_Generalites, Me.PageFooter})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBoxBordersAllPage})
        Me.Margins = New System.Drawing.Printing.Margins(27, 24, 14, 10)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "15.2"
        CType(Me.XrrichTxtOrgaGen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail_Generalites As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin_Generalites As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin_Generalites As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLblOrgaGenTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrrichTxtOrgaGen As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrCrossBandBoxBordersAllPage As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo_Chap_Maintenance As DevExpress.XtraReports.UI.XRPageInfo
End Class
