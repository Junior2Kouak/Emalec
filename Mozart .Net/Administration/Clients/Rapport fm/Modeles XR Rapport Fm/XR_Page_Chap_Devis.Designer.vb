<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XR_Page_Chap_Devis
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
        Me.components = New System.ComponentModel.Container()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim MsSqlConnectionParameters1 As DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters()
        Dim StoredProcQuery1 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter3 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter4 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XR_Page_Chap_Devis))
        Me.Detail_Chap_Devis = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin_Chap_Devis = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin_Chap_Devis = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrCrossBandBoxBordersAllPage = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.PageFooter_Chap_Devis = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo_Chap_Maintenance = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.DR_Chap_Devis_Tab = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail_Chap_Devis_Tab = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GH_Chap_Devis_Tab = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTableDevisAValid_Entete = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SDS_Chap_Devis = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.RH_Chap_Devis = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLblTitreDevisAttenteDec = New DevExpress.XtraReports.UI.XRLabel()
        Me.P_NCLINUM = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_VENSEIGNE = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_DATE_DEBUT_12M = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_DATE_FIN_12M = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_DATE_DEBUT_PERIODE = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_DATE_FIN_PERIODE = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_DATE_DEBUT_ANNEE = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_DATE_TODAY = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_DATE_DEBUT_LASTMONTH = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_DATE_FIN_LASTMONTH = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_LANGUE = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_NIDRAPPORT_FM_CLI = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTableDevisAValid_Entete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail_Chap_Devis
        '
        Me.Detail_Chap_Devis.HeightF = 0!
        Me.Detail_Chap_Devis.Name = "Detail_Chap_Devis"
        Me.Detail_Chap_Devis.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail_Chap_Devis.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin_Chap_Devis
        '
        Me.TopMargin_Chap_Devis.HeightF = 24.0!
        Me.TopMargin_Chap_Devis.Name = "TopMargin_Chap_Devis"
        Me.TopMargin_Chap_Devis.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin_Chap_Devis.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin_Chap_Devis
        '
        Me.BottomMargin_Chap_Devis.HeightF = 20.0!
        Me.BottomMargin_Chap_Devis.Name = "BottomMargin_Chap_Devis"
        Me.BottomMargin_Chap_Devis.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin_Chap_Devis.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrCrossBandBoxBordersAllPage
        '
        Me.XrCrossBandBoxBordersAllPage.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBoxBordersAllPage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrCrossBandBoxBordersAllPage.BorderWidth = 1.0!
        Me.XrCrossBandBoxBordersAllPage.EndBand = Me.BottomMargin_Chap_Devis
        Me.XrCrossBandBoxBordersAllPage.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 10.15515!)
        Me.XrCrossBandBoxBordersAllPage.Name = "XrCrossBandBoxBordersAllPage"
        Me.XrCrossBandBoxBordersAllPage.StartBand = Me.TopMargin_Chap_Devis
        Me.XrCrossBandBoxBordersAllPage.StartPointFloat = New DevExpress.Utils.PointFloat(0!, 12.84722!)
        Me.XrCrossBandBoxBordersAllPage.WidthF = 776.0416!
        '
        'PageFooter_Chap_Devis
        '
        Me.PageFooter_Chap_Devis.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo_Chap_Maintenance})
        Me.PageFooter_Chap_Devis.HeightF = 23.0!
        Me.PageFooter_Chap_Devis.Name = "PageFooter_Chap_Devis"
        '
        'XrPageInfo_Chap_Maintenance
        '
        Me.XrPageInfo_Chap_Maintenance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo_Chap_Maintenance.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPageInfo_Chap_Maintenance.Name = "XrPageInfo_Chap_Maintenance"
        Me.XrPageInfo_Chap_Maintenance.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo_Chap_Maintenance.SizeF = New System.Drawing.SizeF(772.9167!, 23.0!)
        Me.XrPageInfo_Chap_Maintenance.StylePriority.UseFont = False
        Me.XrPageInfo_Chap_Maintenance.StylePriority.UseTextAlignment = False
        Me.XrPageInfo_Chap_Maintenance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'DR_Chap_Devis_Tab
        '
        Me.DR_Chap_Devis_Tab.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail_Chap_Devis_Tab, Me.GH_Chap_Devis_Tab, Me.ReportFooter})
        Me.DR_Chap_Devis_Tab.DataMember = "api_sp_Rapport_FM_Impression_DevisAValider_Tableau"
        Me.DR_Chap_Devis_Tab.DataSource = Me.SDS_Chap_Devis
        Me.DR_Chap_Devis_Tab.Level = 0
        Me.DR_Chap_Devis_Tab.Name = "DR_Chap_Devis_Tab"
        '
        'Detail_Chap_Devis_Tab
        '
        Me.Detail_Chap_Devis_Tab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail_Chap_Devis_Tab.HeightF = 15.0!
        Me.Detail_Chap_Devis_Tab.Name = "Detail_Chap_Devis_Tab"
        '
        'XrTable1
        '
        Me.XrTable1.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.BorderWidth = 0.5!
        Me.XrTable1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(12.50007!, 0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(752.4999!, 15.0!)
        Me.XrTable1.StylePriority.UseBorderColor = False
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseBorderWidth = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell6, Me.XrTableCell14})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 11.5R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VSITNOM]")})
        Me.XrTableCell9.Font = New System.Drawing.Font("Century Gothic", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.Weight = 2.1114669886020443R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VACTTITLE]")})
        Me.XrTableCell10.Font = New System.Drawing.Font("Century Gothic", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell10.Weight = 1.9605749711474187R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DACTDATCRE]")})
        Me.XrTableCell11.Font = New System.Drawing.Font("Century Gothic", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.Weight = 0.85806257826036758R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DDCLDCRE]")})
        Me.XrTableCell12.Font = New System.Drawing.Font("Century Gothic", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.Weight = 0.827959094438301R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NDCLHT]")})
        Me.XrTableCell13.Font = New System.Drawing.Font("Century Gothic", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.Weight = 0.99856424646124675R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NDCLNUM]")})
        Me.XrTableCell6.Font = New System.Drawing.Font("Century Gothic", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.Weight = 1.2720432709082195R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NB_J_VALID]")})
        Me.XrTableCell14.Font = New System.Drawing.Font("Century Gothic", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseFont = False
        Me.XrTableCell14.Weight = 1.0336921442950624R
        '
        'GH_Chap_Devis_Tab
        '
        Me.GH_Chap_Devis_Tab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTableDevisAValid_Entete})
        Me.GH_Chap_Devis_Tab.HeightF = 61.45837!
        Me.GH_Chap_Devis_Tab.Name = "GH_Chap_Devis_Tab"
        Me.GH_Chap_Devis_Tab.RepeatEveryPage = True
        '
        'XrTableDevisAValid_Entete
        '
        Me.XrTableDevisAValid_Entete.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.XrTableDevisAValid_Entete.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTableDevisAValid_Entete.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableDevisAValid_Entete.BorderWidth = 0.5!
        Me.XrTableDevisAValid_Entete.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableDevisAValid_Entete.LocationFloat = New DevExpress.Utils.PointFloat(12.50007!, 10.00001!)
        Me.XrTableDevisAValid_Entete.Name = "XrTableDevisAValid_Entete"
        Me.XrTableDevisAValid_Entete.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTableDevisAValid_Entete.SizeF = New System.Drawing.SizeF(752.4999!, 51.45837!)
        Me.XrTableDevisAValid_Entete.StylePriority.UseBackColor = False
        Me.XrTableDevisAValid_Entete.StylePriority.UseBorderColor = False
        Me.XrTableDevisAValid_Entete.StylePriority.UseBorders = False
        Me.XrTableDevisAValid_Entete.StylePriority.UseBorderWidth = False
        Me.XrTableDevisAValid_Entete.StylePriority.UseFont = False
        Me.XrTableDevisAValid_Entete.StylePriority.UseTextAlignment = False
        Me.XrTableDevisAValid_Entete.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell7, Me.XrTableCell1, Me.XrTableCell8})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell2.ForeColor = System.Drawing.Color.White
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBackColor = False
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseForeColor = False
        Me.XrTableCell2.Text = "Sites"
        Me.XrTableCell2.Weight = 1.7532715345515637R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell3.ForeColor = System.Drawing.Color.White
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBackColor = False
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseForeColor = False
        Me.XrTableCell3.Text = "Objet du devis"
        Me.XrTableCell3.Weight = 1.6279778823476119R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell4.ForeColor = System.Drawing.Color.White
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseBackColor = False
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.StylePriority.UseForeColor = False
        Me.XrTableCell4.Text = "Date DI"
        Me.XrTableCell4.Weight = 0.71249876766694709R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell5.ForeColor = System.Drawing.Color.White
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseBackColor = False
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UseForeColor = False
        Me.XrTableCell5.Text = "Date du devis"
        Me.XrTableCell5.Weight = 0.68750122966072669R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell7.ForeColor = System.Drawing.Color.White
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseBackColor = False
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UseForeColor = False
        Me.XrTableCell7.Text = "Montant €ht"
        Me.XrTableCell7.Weight = 0.82916563254339792R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell1.ForeColor = System.Drawing.Color.White
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBackColor = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseForeColor = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "N° Devis"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell1.Weight = 1.056250228786054R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell8.ForeColor = System.Drawing.Color.White
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBackColor = False
        Me.XrTableCell8.StylePriority.UseFont = False
        Me.XrTableCell8.StylePriority.UseForeColor = False
        Me.XrTableCell8.Text = "Délai attente de validation (j)"
        Me.XrTableCell8.Weight = 0.85833323545925388R
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.ReportFooter.HeightF = 42.87491!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([NDCLHT])")})
        Me.XrLabel1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(433.7499!, 10.00001!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(331.25!, 23.00001!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel1.Summary = XrSummary1
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel1.TextFormatString = "TOTAL : {0:n2}"
        '
        'SDS_Chap_Devis
        '
        Me.SDS_Chap_Devis.ConnectionName = "SRV-VMSQLPROD_MULTI_Connection 1"
        Me.SDS_Chap_Devis.ConnectionOptions.DbCommandTimeout = 0
        MsSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows
        MsSqlConnectionParameters1.DatabaseName = "MULTI"
        MsSqlConnectionParameters1.ServerName = "SRV-VMSQLPROD"
        Me.SDS_Chap_Devis.ConnectionParameters = MsSqlConnectionParameters1
        Me.SDS_Chap_Devis.Name = "SDS_Chap_Devis"
        StoredProcQuery1.Name = "api_sp_Rapport_FM_Impression_DevisAValider_Tableau"
        QueryParameter1.Name = "@p_nclinum"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NCLINUM]", GetType(Integer))
        QueryParameter2.Name = "@p_venseigne"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.P_VENSEIGNE]", GetType(String))
        QueryParameter3.Name = "@p_slangue"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("[Parameters.P_LANGUE]", GetType(String))
        QueryParameter4.Name = "@p_nidrapport_fm_cli"
        QueryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter4.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NIDRAPPORT_FM_CLI]", GetType(Integer))
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.Parameters.Add(QueryParameter3)
        StoredProcQuery1.Parameters.Add(QueryParameter4)
        StoredProcQuery1.StoredProcName = "api_sp_Rapport_FM_Impression_DevisAValider_Tableau"
        Me.SDS_Chap_Devis.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SDS_Chap_Devis.ResultSchemaSerializable = resources.GetString("SDS_Chap_Devis.ResultSchemaSerializable")
        '
        'RH_Chap_Devis
        '
        Me.RH_Chap_Devis.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLblTitreDevisAttenteDec})
        Me.RH_Chap_Devis.HeightF = 24.45834!
        Me.RH_Chap_Devis.Name = "RH_Chap_Devis"
        '
        'XrLblTitreDevisAttenteDec
        '
        Me.XrLblTitreDevisAttenteDec.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblTitreDevisAttenteDec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrLblTitreDevisAttenteDec.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 0!)
        Me.XrLblTitreDevisAttenteDec.Name = "XrLblTitreDevisAttenteDec"
        Me.XrLblTitreDevisAttenteDec.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblTitreDevisAttenteDec.SizeF = New System.Drawing.SizeF(754.9998!, 24.45834!)
        Me.XrLblTitreDevisAttenteDec.StylePriority.UseFont = False
        Me.XrLblTitreDevisAttenteDec.StylePriority.UseForeColor = False
        Me.XrLblTitreDevisAttenteDec.Text = "Devis en attente de validation du client  à la date du rapport"
        '
        'P_NCLINUM
        '
        Me.P_NCLINUM.Description = "NCLINUM"
        Me.P_NCLINUM.Name = "P_NCLINUM"
        Me.P_NCLINUM.Type = GetType(Integer)
        Me.P_NCLINUM.ValueInfo = "0"
        '
        'P_VENSEIGNE
        '
        Me.P_VENSEIGNE.Description = "Enseigne"
        Me.P_VENSEIGNE.Name = "P_VENSEIGNE"
        '
        'P_DATE_DEBUT_12M
        '
        Me.P_DATE_DEBUT_12M.Description = "Date debut sur 12 Mois"
        Me.P_DATE_DEBUT_12M.Name = "P_DATE_DEBUT_12M"
        Me.P_DATE_DEBUT_12M.Type = GetType(Date)
        '
        'P_DATE_FIN_12M
        '
        Me.P_DATE_FIN_12M.Description = "Date Fin sur 12 mois"
        Me.P_DATE_FIN_12M.Name = "P_DATE_FIN_12M"
        Me.P_DATE_FIN_12M.Type = GetType(Date)
        '
        'P_DATE_DEBUT_PERIODE
        '
        Me.P_DATE_DEBUT_PERIODE.Description = "Date début de la période sélecrionnée"
        Me.P_DATE_DEBUT_PERIODE.Name = "P_DATE_DEBUT_PERIODE"
        Me.P_DATE_DEBUT_PERIODE.Type = GetType(Date)
        '
        'P_DATE_FIN_PERIODE
        '
        Me.P_DATE_FIN_PERIODE.Description = "Date fin de la période sélectionnée"
        Me.P_DATE_FIN_PERIODE.Name = "P_DATE_FIN_PERIODE"
        Me.P_DATE_FIN_PERIODE.Type = GetType(Date)
        '
        'P_DATE_DEBUT_ANNEE
        '
        Me.P_DATE_DEBUT_ANNEE.Description = "Date début de l'année"
        Me.P_DATE_DEBUT_ANNEE.Name = "P_DATE_DEBUT_ANNEE"
        Me.P_DATE_DEBUT_ANNEE.Type = GetType(Date)
        '
        'P_DATE_TODAY
        '
        Me.P_DATE_TODAY.Description = "Date du jour"
        Me.P_DATE_TODAY.Name = "P_DATE_TODAY"
        Me.P_DATE_TODAY.Type = GetType(Date)
        '
        'P_DATE_DEBUT_LASTMONTH
        '
        Me.P_DATE_DEBUT_LASTMONTH.Description = "Date debut du dernier mois"
        Me.P_DATE_DEBUT_LASTMONTH.Name = "P_DATE_DEBUT_LASTMONTH"
        Me.P_DATE_DEBUT_LASTMONTH.Type = GetType(Date)
        '
        'P_DATE_FIN_LASTMONTH
        '
        Me.P_DATE_FIN_LASTMONTH.Description = "Date fin du dernier mois"
        Me.P_DATE_FIN_LASTMONTH.Name = "P_DATE_FIN_LASTMONTH"
        Me.P_DATE_FIN_LASTMONTH.Type = GetType(Date)
        '
        'P_LANGUE
        '
        Me.P_LANGUE.Description = "Langue"
        Me.P_LANGUE.Name = "P_LANGUE"
        Me.P_LANGUE.ValueInfo = "FR"
        '
        'P_NIDRAPPORT_FM_CLI
        '
        Me.P_NIDRAPPORT_FM_CLI.Description = "NIDRAPPORT_FM_CLI"
        Me.P_NIDRAPPORT_FM_CLI.Name = "P_NIDRAPPORT_FM_CLI"
        Me.P_NIDRAPPORT_FM_CLI.Type = GetType(Integer)
        Me.P_NIDRAPPORT_FM_CLI.ValueInfo = "0"
        '
        'XR_Page_Chap_Devis
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail_Chap_Devis, Me.TopMargin_Chap_Devis, Me.BottomMargin_Chap_Devis, Me.PageFooter_Chap_Devis, Me.DR_Chap_Devis_Tab, Me.RH_Chap_Devis})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SDS_Chap_Devis})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBoxBordersAllPage})
        Me.Margins = New System.Drawing.Printing.Margins(23, 26, 24, 20)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.P_NCLINUM, Me.P_VENSEIGNE, Me.P_DATE_DEBUT_12M, Me.P_DATE_FIN_12M, Me.P_DATE_DEBUT_PERIODE, Me.P_DATE_FIN_PERIODE, Me.P_DATE_DEBUT_ANNEE, Me.P_DATE_TODAY, Me.P_DATE_DEBUT_LASTMONTH, Me.P_DATE_FIN_LASTMONTH, Me.P_LANGUE, Me.P_NIDRAPPORT_FM_CLI})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "18.2"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTableDevisAValid_Entete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail_Chap_Devis As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin_Chap_Devis As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin_Chap_Devis As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrCrossBandBoxBordersAllPage As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents PageFooter_Chap_Devis As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo_Chap_Maintenance As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents DR_Chap_Devis_Tab As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail_Chap_Devis_Tab As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents RH_Chap_Devis As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLblTitreDevisAttenteDec As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GH_Chap_Devis_Tab As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTableDevisAValid_Entete As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents P_NCLINUM As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_VENSEIGNE As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_DATE_DEBUT_12M As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_DATE_FIN_12M As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_DATE_DEBUT_PERIODE As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_DATE_FIN_PERIODE As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_DATE_DEBUT_ANNEE As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_DATE_TODAY As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_DATE_DEBUT_LASTMONTH As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_DATE_FIN_LASTMONTH As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_LANGUE As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents SDS_Chap_Devis As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents P_NIDRAPPORT_FM_CLI As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
End Class
