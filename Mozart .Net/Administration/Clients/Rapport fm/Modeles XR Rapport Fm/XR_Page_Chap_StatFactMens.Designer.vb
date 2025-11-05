<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XR_Page_Chap_StatFactMens
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim MsSqlConnectionParameters1 As DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters()
        Dim StoredProcQuery1 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter3 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter4 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter5 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim StoredProcQuery2 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter6 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter7 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter8 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter9 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter10 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim StoredProcQuery3 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter11 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter12 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter13 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter14 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter15 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XR_Page_Chap_StatFactMens))
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim PieSeriesView2 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesLabel2 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PieSeriesView3 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim PieSeriesView4 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim ChartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrCrossBandBoxBordersAllPage = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo_Chap_Maintenance = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLblTitre_ChapStatFactMens = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable79 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow80 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell691 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell692 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable78 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow79 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell689 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell690 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.DetailReport1 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail2 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrChart1 = New DevExpress.XtraReports.UI.XRChart()
        Me.XrChart35 = New DevExpress.XtraReports.UI.XRChart()
        Me.XrChart33 = New DevExpress.XtraReports.UI.XRChart()
        Me.P_NIDRAPPORT_FM_CLI = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.XrTable79, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable78, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 13.54166!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 10.54544!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrCrossBandBoxBordersAllPage
        '
        Me.XrCrossBandBoxBordersAllPage.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBoxBordersAllPage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrCrossBandBoxBordersAllPage.BorderWidth = 1.0!
        Me.XrCrossBandBoxBordersAllPage.EndBand = Me.BottomMargin
        Me.XrCrossBandBoxBordersAllPage.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 4.01137!)
        Me.XrCrossBandBoxBordersAllPage.Name = "XrCrossBandBoxBordersAllPage"
        Me.XrCrossBandBoxBordersAllPage.StartBand = Me.TopMargin
        Me.XrCrossBandBoxBordersAllPage.StartPointFloat = New DevExpress.Utils.PointFloat(0!, 8.333333!)
        Me.XrCrossBandBoxBordersAllPage.WidthF = 772.9167!
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo_Chap_Maintenance})
        Me.PageFooter.HeightF = 23.0!
        Me.PageFooter.Name = "PageFooter"
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
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLblTitre_ChapStatFactMens})
        Me.ReportHeader.HeightF = 23.00001!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLblTitre_ChapStatFactMens
        '
        Me.XrLblTitre_ChapStatFactMens.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblTitre_ChapStatFactMens.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrLblTitre_ChapStatFactMens.LocationFloat = New DevExpress.Utils.PointFloat(12.0002!, 0.00001324548!)
        Me.XrLblTitre_ChapStatFactMens.Name = "XrLblTitre_ChapStatFactMens"
        Me.XrLblTitre_ChapStatFactMens.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblTitre_ChapStatFactMens.SizeF = New System.Drawing.SizeF(754.9998!, 23.0!)
        Me.XrLblTitre_ChapStatFactMens.StylePriority.UseFont = False
        Me.XrLblTitre_ChapStatFactMens.StylePriority.UseForeColor = False
        Me.XrLblTitre_ChapStatFactMens.Text = "Facturation mensuelle sur 12 mois glissant"
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
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.GroupHeader1, Me.ReportFooter})
        Me.DetailReport.DataMember = "api_sp_Rapport_FM_Impression_StatFacturationByMonth"
        Me.DetailReport.DataSource = Me.SqlDataSource1
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable79})
        Me.Detail1.HeightF = 15.0!
        Me.Detail1.Name = "Detail1"
        '
        'XrTable79
        '
        Me.XrTable79.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTable79.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable79.BorderWidth = 0.5!
        Me.XrTable79.Font = New System.Drawing.Font("Century Gothic", 7.25!)
        Me.XrTable79.LocationFloat = New DevExpress.Utils.PointFloat(12.0002!, 0!)
        Me.XrTable79.Name = "XrTable79"
        Me.XrTable79.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow80})
        Me.XrTable79.SizeF = New System.Drawing.SizeF(389.677!, 15.0!)
        Me.XrTable79.StylePriority.UseBorderColor = False
        Me.XrTable79.StylePriority.UseBorders = False
        Me.XrTable79.StylePriority.UseBorderWidth = False
        Me.XrTable79.StylePriority.UseFont = False
        Me.XrTable79.StylePriority.UseTextAlignment = False
        Me.XrTable79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow80
        '
        Me.XrTableRow80.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell691, Me.XrTableCell692})
        Me.XrTableRow80.Name = "XrTableRow80"
        Me.XrTableRow80.Weight = 11.5R
        '
        'XrTableCell691
        '
        Me.XrTableCell691.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTableCell691.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell691.BorderWidth = 0.5!
        Me.XrTableCell691.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LIB_MONTH]")})
        Me.XrTableCell691.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell691.Name = "XrTableCell691"
        Me.XrTableCell691.StylePriority.UseBorderColor = False
        Me.XrTableCell691.StylePriority.UseBorders = False
        Me.XrTableCell691.StylePriority.UseBorderWidth = False
        Me.XrTableCell691.StylePriority.UseFont = False
        Me.XrTableCell691.Text = "XrTableCell691"
        Me.XrTableCell691.Weight = 0.060545483287416151R
        '
        'XrTableCell692
        '
        Me.XrTableCell692.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TOT_THT]")})
        Me.XrTableCell692.Name = "XrTableCell692"
        Me.XrTableCell692.StylePriority.UseTextAlignment = False
        Me.XrTableCell692.Text = "XrTableCell692"
        Me.XrTableCell692.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell692.TextFormatString = "{0:c0}"
        Me.XrTableCell692.Weight = 0.11381601141214968R
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable78})
        Me.GroupHeader1.HeightF = 61.45838!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = True
        '
        'XrTable78
        '
        Me.XrTable78.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.XrTable78.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTable78.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable78.BorderWidth = 0.5!
        Me.XrTable78.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable78.LocationFloat = New DevExpress.Utils.PointFloat(12.00019!, 10.0!)
        Me.XrTable78.Name = "XrTable78"
        Me.XrTable78.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow79})
        Me.XrTable78.SizeF = New System.Drawing.SizeF(389.677!, 51.45837!)
        Me.XrTable78.StylePriority.UseBackColor = False
        Me.XrTable78.StylePriority.UseBorderColor = False
        Me.XrTable78.StylePriority.UseBorders = False
        Me.XrTable78.StylePriority.UseBorderWidth = False
        Me.XrTable78.StylePriority.UseFont = False
        Me.XrTable78.StylePriority.UseTextAlignment = False
        Me.XrTable78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow79
        '
        Me.XrTableRow79.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell689, Me.XrTableCell690})
        Me.XrTableRow79.Name = "XrTableRow79"
        Me.XrTableRow79.Weight = 1.0R
        '
        'XrTableCell689
        '
        Me.XrTableCell689.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell689.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell689.ForeColor = System.Drawing.Color.White
        Me.XrTableCell689.Name = "XrTableCell689"
        Me.XrTableCell689.StylePriority.UseBackColor = False
        Me.XrTableCell689.StylePriority.UseFont = False
        Me.XrTableCell689.StylePriority.UseForeColor = False
        Me.XrTableCell689.Text = "Mois"
        Me.XrTableCell689.Weight = 0.90403423193587618R
        '
        'XrTableCell690
        '
        Me.XrTableCell690.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell690.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell690.ForeColor = System.Drawing.Color.White
        Me.XrTableCell690.Name = "XrTableCell690"
        Me.XrTableCell690.StylePriority.UseBackColor = False
        Me.XrTableCell690.StylePriority.UseFont = False
        Me.XrTableCell690.StylePriority.UseForeColor = False
        Me.XrTableCell690.Text = "Montant"
        Me.XrTableCell690.Weight = 1.69944207518198R
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel54})
        Me.ReportFooter.HeightF = 33.00001!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel54
        '
        Me.XrLabel54.BorderColor = System.Drawing.Color.DarkGray
        Me.XrLabel54.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel54.BorderWidth = 0.5!
        Me.XrLabel54.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([TOT_THT])")})
        Me.XrLabel54.Font = New System.Drawing.Font("Century Gothic", 7.25!)
        Me.XrLabel54.LocationFloat = New DevExpress.Utils.PointFloat(147.3121!, 10.00001!)
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel54.SizeF = New System.Drawing.SizeF(254.3651!, 23.0!)
        Me.XrLabel54.StylePriority.UseBorderColor = False
        Me.XrLabel54.StylePriority.UseBorders = False
        Me.XrLabel54.StylePriority.UseBorderWidth = False
        Me.XrLabel54.StylePriority.UseFont = False
        Me.XrLabel54.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel54.Summary = XrSummary1
        Me.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel54.TextFormatString = "TOTAL : {0:c0}"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "SRV-VMSQLPROD_MULTI_Connection 1"
        Me.SqlDataSource1.ConnectionOptions.DbCommandTimeout = 0
        MsSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows
        MsSqlConnectionParameters1.DatabaseName = "MULTI"
        MsSqlConnectionParameters1.ServerName = "SRV-VMSQLPROD"
        Me.SqlDataSource1.ConnectionParameters = MsSqlConnectionParameters1
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "api_sp_Rapport_FM_Impression_StatFacturationByMonth"
        QueryParameter1.Name = "@p_nclinum"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NCLINUM]", GetType(Integer))
        QueryParameter2.Name = "@p_datedebut"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_DEBUT_12M]", GetType(Date))
        QueryParameter3.Name = "@p_datefin"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_FIN_12M]", GetType(Date))
        QueryParameter4.Name = "@p_slangue"
        QueryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter4.Value = New DevExpress.DataAccess.Expression("[Parameters.P_LANGUE]", GetType(String))
        QueryParameter5.Name = "@p_nidrapport_fm_cli"
        QueryParameter5.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter5.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NIDRAPPORT_FM_CLI]", GetType(Integer))
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.Parameters.Add(QueryParameter3)
        StoredProcQuery1.Parameters.Add(QueryParameter4)
        StoredProcQuery1.Parameters.Add(QueryParameter5)
        StoredProcQuery1.StoredProcName = "api_sp_Rapport_FM_Impression_StatFacturationByMonth"
        StoredProcQuery2.Name = "api_sp_Rapport_FM_Impression_StatFacturation_Pie_By_Pre_LastMonth"
        QueryParameter6.Name = "@p_nclinum"
        QueryParameter6.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter6.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NCLINUM]", GetType(Integer))
        QueryParameter7.Name = "@p_datedebut"
        QueryParameter7.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter7.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_DEBUT_LASTMONTH]", GetType(Date))
        QueryParameter8.Name = "@p_datefin"
        QueryParameter8.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter8.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_FIN_LASTMONTH]", GetType(Date))
        QueryParameter9.Name = "@p_slangue"
        QueryParameter9.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter9.Value = New DevExpress.DataAccess.Expression("[Parameters.P_LANGUE]", GetType(String))
        QueryParameter10.Name = "@p_nidrapport_fm_cli"
        QueryParameter10.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter10.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NIDRAPPORT_FM_CLI]", GetType(Integer))
        StoredProcQuery2.Parameters.Add(QueryParameter6)
        StoredProcQuery2.Parameters.Add(QueryParameter7)
        StoredProcQuery2.Parameters.Add(QueryParameter8)
        StoredProcQuery2.Parameters.Add(QueryParameter9)
        StoredProcQuery2.Parameters.Add(QueryParameter10)
        StoredProcQuery2.StoredProcName = "api_sp_Rapport_FM_Impression_StatFacturation_Pie_By_Pre"
        StoredProcQuery3.Name = "api_sp_Rapport_FM_Impression_StatFacturation_Pie_By_Pre_12Month"
        QueryParameter11.Name = "@p_nclinum"
        QueryParameter11.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter11.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NCLINUM]", GetType(Integer))
        QueryParameter12.Name = "@p_datedebut"
        QueryParameter12.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter12.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_DEBUT_12M]", GetType(Date))
        QueryParameter13.Name = "@p_datefin"
        QueryParameter13.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter13.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_FIN_12M]", GetType(Date))
        QueryParameter14.Name = "@p_slangue"
        QueryParameter14.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter14.Value = New DevExpress.DataAccess.Expression("[Parameters.P_LANGUE]", GetType(String))
        QueryParameter15.Name = "@p_nidrapport_fm_cli"
        QueryParameter15.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter15.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NIDRAPPORT_FM_CLI]", GetType(Integer))
        StoredProcQuery3.Parameters.Add(QueryParameter11)
        StoredProcQuery3.Parameters.Add(QueryParameter12)
        StoredProcQuery3.Parameters.Add(QueryParameter13)
        StoredProcQuery3.Parameters.Add(QueryParameter14)
        StoredProcQuery3.Parameters.Add(QueryParameter15)
        StoredProcQuery3.StoredProcName = "api_sp_Rapport_FM_Impression_StatFacturation_Pie_By_Pre"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1, StoredProcQuery2, StoredProcQuery3})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'DetailReport1
        '
        Me.DetailReport1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail2})
        Me.DetailReport1.Level = 1
        Me.DetailReport1.Name = "DetailReport1"
        '
        'Detail2
        '
        Me.Detail2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrChart1, Me.XrChart35, Me.XrChart33})
        Me.Detail2.HeightF = 488.05!
        Me.Detail2.Name = "Detail2"
        '
        'XrChart1
        '
        Me.XrChart1.BorderColor = System.Drawing.Color.Black
        Me.XrChart1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrChart1.BorderWidth = 1.0!
        Me.XrChart1.DataMember = "api_sp_Rapport_FM_Impression_StatFacturation_Pie_By_Pre_12Month"
        Me.XrChart1.DataSource = Me.SqlDataSource1
        Me.XrChart1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center
        Me.XrChart1.Legend.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrChart1.Legend.MarkerSize = New System.Drawing.Size(6, 6)
        Me.XrChart1.Legend.Name = "Default Legend"
        Me.XrChart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart1.LocationFloat = New DevExpress.Utils.PointFloat(411.7914!, 252.9583!)
        Me.XrChart1.Name = "XrChart1"
        Me.XrChart1.PaletteName = "Aspect"
        Series1.ArgumentDataMember = "VPRELIB"
        PieSeriesLabel1.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns
        PieSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
        PieSeriesLabel1.TextPattern = "{VP:0.00%} {A}"
        Series1.Label = PieSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.LegendTextPattern = "{A}"
        Series1.Name = "Series 1"
        Series1.ValueDataMembersSerializable = "TOTELF"
        Series1.View = PieSeriesView1
        Me.XrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.XrChart1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart1.SeriesTemplate.View = PieSeriesView2
        Me.XrChart1.SizeF = New System.Drawing.SizeF(355.2086!, 226.9252!)
        Me.XrChart1.StylePriority.UseBorderColor = False
        Me.XrChart1.StylePriority.UseBorders = False
        Me.XrChart1.StylePriority.UseBorderWidth = False
        ChartTitle1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle1.Text = "Facturation sur les 12 mois glissant"
		ChartTitle1.TextColor = System.Drawing.Color.Black
        Me.XrChart1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'XrChart35
        '
        Me.XrChart35.AppearanceNameSerializable = "Chameleon"
        Me.XrChart35.BorderColor = System.Drawing.Color.Black
        Me.XrChart35.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrChart35.BorderWidth = 1.0!
        Me.XrChart35.DataMember = "api_sp_Rapport_FM_Impression_StatFacturation_Pie_By_Pre_LastMonth"
        Me.XrChart35.DataSource = Me.SqlDataSource1
        Me.XrChart35.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center
        Me.XrChart35.Legend.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrChart35.Legend.MarkerSize = New System.Drawing.Size(6, 6)
        Me.XrChart35.Legend.Name = "Default Legend"
        Me.XrChart35.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart35.LocationFloat = New DevExpress.Utils.PointFloat(12.0002!, 252.9583!)
        Me.XrChart35.Name = "XrChart35"
        Me.XrChart35.PaletteName = "Aspect"
        Series2.ArgumentDataMember = "VPRELIB"
        PieSeriesLabel2.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PieSeriesLabel2.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns
        PieSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
        PieSeriesLabel2.TextPattern = "{VP:0.00%} {A}"
        Series2.Label = PieSeriesLabel2
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series2.LegendTextPattern = "{A}"
        Series2.Name = "Series 1"
        Series2.ValueDataMembersSerializable = "TOTELF"
        Series2.View = PieSeriesView3
        Me.XrChart35.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        Me.XrChart35.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart35.SeriesTemplate.View = PieSeriesView4
        Me.XrChart35.SizeF = New System.Drawing.SizeF(389.677!, 226.9252!)
        Me.XrChart35.StylePriority.UseBorderColor = False
        Me.XrChart35.StylePriority.UseBorders = False
        Me.XrChart35.StylePriority.UseBorderWidth = False
        ChartTitle2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle2.Text = "Facturation sur le dernier mois"
		ChartTitle2.TextColor = System.Drawing.Color.Black
        Me.XrChart35.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'XrChart33
        '
        Me.XrChart33.BorderColor = System.Drawing.Color.Black
        Me.XrChart33.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrChart33.BorderWidth = 1.0!
        Me.XrChart33.DataMember = "api_sp_Rapport_FM_Impression_StatFacturationByMonth"
        Me.XrChart33.DataSource = Me.SqlDataSource1
        XyDiagram1.AxisX.Label.Angle = 270
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart33.Diagram = XyDiagram1
        Me.XrChart33.Legend.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrChart33.Legend.MarkerSize = New System.Drawing.Size(10, 10)
        Me.XrChart33.Legend.Name = "Default Legend"
        Me.XrChart33.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart33.LocationFloat = New DevExpress.Utils.PointFloat(12.00019!, 9.999996!)
        Me.XrChart33.Name = "XrChart33"
        Series3.ArgumentDataMember = "LIB_MONTH"
        SideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        Series3.Label = SideBySideBarSeriesLabel1
        Series3.Name = "Series 1"
        Series3.ValueDataMembersSerializable = "TOT_THT"
        Me.XrChart33.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3}
        Me.XrChart33.SeriesTemplate.ArgumentDataMember = "LIB_MONTH"
        Me.XrChart33.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart33.SizeF = New System.Drawing.SizeF(754.9998!, 230.7527!)
        Me.XrChart33.StylePriority.UseBorderColor = False
        Me.XrChart33.StylePriority.UseBorders = False
        Me.XrChart33.StylePriority.UseBorderWidth = False
        ChartTitle3.Alignment = System.Drawing.StringAlignment.Near
        ChartTitle3.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle3.Text = "Montant facturés par mois"
		ChartTitle3.TextColor = System.Drawing.Color.Black
        Me.XrChart33.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle3})
        '
        'P_NIDRAPPORT_FM_CLI
        '
        Me.P_NIDRAPPORT_FM_CLI.Description = "NIDRAPPORT_FM_CLI"
        Me.P_NIDRAPPORT_FM_CLI.Name = "P_NIDRAPPORT_FM_CLI"
        Me.P_NIDRAPPORT_FM_CLI.Type = GetType(Integer)
        Me.P_NIDRAPPORT_FM_CLI.ValueInfo = "0"
        '
        'XR_Page_Chap_StatFactMens
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.ReportHeader, Me.DetailReport, Me.DetailReport1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBoxBordersAllPage})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 14, 11)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.P_NCLINUM, Me.P_VENSEIGNE, Me.P_DATE_DEBUT_12M, Me.P_DATE_FIN_12M, Me.P_DATE_DEBUT_PERIODE, Me.P_DATE_FIN_PERIODE, Me.P_DATE_DEBUT_ANNEE, Me.P_DATE_TODAY, Me.P_DATE_DEBUT_LASTMONTH, Me.P_DATE_FIN_LASTMONTH, Me.P_LANGUE, Me.P_NIDRAPPORT_FM_CLI})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "18.2"
        CType(Me.XrTable79, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable78, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrCrossBandBoxBordersAllPage As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrPageInfo_Chap_Maintenance As DevExpress.XtraReports.UI.XRPageInfo
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
    Friend WithEvents XrLblTitre_ChapStatFactMens As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrTable79 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow80 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell691 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell692 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable78 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow79 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell689 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell690 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DetailReport1 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail2 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrChart33 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents P_NIDRAPPORT_FM_CLI As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrChart1 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents XrChart35 As DevExpress.XtraReports.UI.XRChart
End Class
