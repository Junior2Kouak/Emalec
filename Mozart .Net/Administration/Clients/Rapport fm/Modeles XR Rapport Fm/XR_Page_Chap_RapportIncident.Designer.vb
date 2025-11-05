<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XR_Page_Chap_RapportIncident
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
        Dim MsSqlConnectionParameters1 As DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters()
        Dim StoredProcQuery1 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter3 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter4 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter5 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter6 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim StoredProcQuery2 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
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
        Dim StoredProcQuery4 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter16 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter17 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter18 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter19 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter20 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim StoredProcQuery5 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter21 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter22 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter23 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter24 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter25 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XR_Page_Chap_RapportIncident))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
    Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
    Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim PieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
    Dim PieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
    Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
    Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim PieSeriesLabel2 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
    Dim PieSeriesView2 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
    Dim ChartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
    Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim PieSeriesLabel3 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
    Dim PieSeriesView3 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
    Dim ChartTitle4 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
    Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
    Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
    Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
    Me.XrCrossBandBoxBordersAllPage = New DevExpress.XtraReports.UI.XRCrossBandBox()
    Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
    Me.XrPageInfo_Chap_Maintenance = New DevExpress.XtraReports.UI.XRPageInfo()
    Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
    Me.XrLblPerimetre_RapportIncident = New DevExpress.XtraReports.UI.XRLabel()
    Me.XrLblTitreRapportIncident = New DevExpress.XtraReports.UI.XRLabel()
    Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
    Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
    Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
    Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
    Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
    Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
    Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
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
    Me.DetailReport1 = New DevExpress.XtraReports.UI.DetailReportBand()
    Me.Detail2 = New DevExpress.XtraReports.UI.DetailBand()
    Me.XrChart1 = New DevExpress.XtraReports.UI.XRChart()
    Me.DetailReport2 = New DevExpress.XtraReports.UI.DetailReportBand()
    Me.Detail3 = New DevExpress.XtraReports.UI.DetailBand()
    Me.XrChart4 = New DevExpress.XtraReports.UI.XRChart()
    Me.XrChart3 = New DevExpress.XtraReports.UI.XRChart()
    Me.XrChart2 = New DevExpress.XtraReports.UI.XRChart()
    Me.P_NIDRAPPORT_FM_CLI = New DevExpress.XtraReports.Parameters.Parameter()
    CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XrChart4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XrChart3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XrChart2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(PieSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(PieSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.TopMargin.HeightF = 15.0!
    Me.TopMargin.Name = "TopMargin"
    Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
    '
    'BottomMargin
    '
    Me.BottomMargin.HeightF = 15.0!
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
    Me.XrCrossBandBoxBordersAllPage.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 7.518999!)
    Me.XrCrossBandBoxBordersAllPage.Name = "XrCrossBandBoxBordersAllPage"
    Me.XrCrossBandBoxBordersAllPage.StartBand = Me.TopMargin
    Me.XrCrossBandBoxBordersAllPage.StartPointFloat = New DevExpress.Utils.PointFloat(0!, 8.333335!)
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
    Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLblPerimetre_RapportIncident, Me.XrLblTitreRapportIncident})
    Me.ReportHeader.HeightF = 48.91667!
    Me.ReportHeader.Name = "ReportHeader"
    '
    'XrLblPerimetre_RapportIncident
    '
    Me.XrLblPerimetre_RapportIncident.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrLblPerimetre_RapportIncident.LocationFloat = New DevExpress.Utils.PointFloat(8.916846!, 24.45833!)
    Me.XrLblPerimetre_RapportIncident.Name = "XrLblPerimetre_RapportIncident"
    Me.XrLblPerimetre_RapportIncident.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLblPerimetre_RapportIncident.SizeF = New System.Drawing.SizeF(754.9998!, 24.45834!)
    Me.XrLblPerimetre_RapportIncident.StylePriority.UseFont = False
    Me.XrLblPerimetre_RapportIncident.Text = "Engagement de délai : 24h ouvrables pour la clôture de l'incident"
    '
    'XrLblTitreRapportIncident
    '
    Me.XrLblTitreRapportIncident.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrLblTitreRapportIncident.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
    Me.XrLblTitreRapportIncident.LocationFloat = New DevExpress.Utils.PointFloat(8.916846!, 0!)
    Me.XrLblTitreRapportIncident.Name = "XrLblTitreRapportIncident"
    Me.XrLblTitreRapportIncident.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
    Me.XrLblTitreRapportIncident.SizeF = New System.Drawing.SizeF(754.9998!, 24.45834!)
    Me.XrLblTitreRapportIncident.StylePriority.UseFont = False
    Me.XrLblTitreRapportIncident.StylePriority.UseForeColor = False
    Me.XrLblTitreRapportIncident.Text = "Gestion des demandes d'intervention sur le siège, avec le personnel posté"
    '
    'DetailReport
    '
    Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.GroupHeader1})
    Me.DetailReport.DataMember = "api_sp_Rapport_FM_Impression_RapportIncident_Poste"
    Me.DetailReport.DataSource = Me.SqlDataSource1
    Me.DetailReport.Level = 0
    Me.DetailReport.Name = "DetailReport"
    '
    'Detail1
    '
    Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
    Me.Detail1.HeightF = 15.0!
    Me.Detail1.Name = "Detail1"
    '
    'XrTable3
    '
    Me.XrTable3.BorderColor = System.Drawing.Color.DarkGray
    Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTable3.BorderWidth = 0.5!
    Me.XrTable3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(8.91681!, 0!)
    Me.XrTable3.Name = "XrTable3"
    Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
    Me.XrTable3.SizeF = New System.Drawing.SizeF(754.9999!, 15.0!)
    Me.XrTable3.StylePriority.UseBorderColor = False
    Me.XrTable3.StylePriority.UseBorders = False
    Me.XrTable3.StylePriority.UseBorderWidth = False
    Me.XrTable3.StylePriority.UseFont = False
    Me.XrTable3.StylePriority.UseTextAlignment = False
    Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrTableRow4
    '
    Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell22, Me.XrTableCell23, Me.XrTableCell24, Me.XrTableCell25, Me.XrTableCell26, Me.XrTableCell28})
    Me.XrTableRow4.Name = "XrTableRow4"
    Me.XrTableRow4.Weight = 11.5R
    '
    'XrTableCell22
    '
    Me.XrTableCell22.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VSITENSEIGNE]")})
    Me.XrTableCell22.Font = New System.Drawing.Font("Century Gothic", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrTableCell22.Name = "XrTableCell22"
    Me.XrTableCell22.StylePriority.UseFont = False
    Me.XrTableCell22.Weight = 1.2845860251546053R
    '
    'XrTableCell23
    '
    Me.XrTableCell23.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VSITNOM]")})
    Me.XrTableCell23.Font = New System.Drawing.Font("Century Gothic", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrTableCell23.Name = "XrTableCell23"
    Me.XrTableCell23.StylePriority.UseFont = False
    Me.XrTableCell23.Weight = 1.5505381715440432R
    '
    'XrTableCell24
    '
    Me.XrTableCell24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VACTDES]")})
    Me.XrTableCell24.Font = New System.Drawing.Font("Century Gothic", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrTableCell24.Name = "XrTableCell24"
    Me.XrTableCell24.StylePriority.UseFont = False
    Me.XrTableCell24.StylePriority.UseTextAlignment = False
    Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
    Me.XrTableCell24.Weight = 3.3971321552147913R
    '
    'XrTableCell25
    '
    Me.XrTableCell25.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DACTDATCRE]")})
    Me.XrTableCell25.Font = New System.Drawing.Font("Century Gothic", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrTableCell25.Name = "XrTableCell25"
    Me.XrTableCell25.StylePriority.UseFont = False
    Me.XrTableCell25.Weight = 1.0161291239176928R
    '
    'XrTableCell26
    '
    Me.XrTableCell26.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DACTDEX]")})
    Me.XrTableCell26.Font = New System.Drawing.Font("Century Gothic", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrTableCell26.Name = "XrTableCell26"
    Me.XrTableCell26.StylePriority.UseFont = False
    Me.XrTableCell26.Weight = 1.0236581984893496R
    '
    'XrTableCell28
    '
    Me.XrTableCell28.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[diffenh]")})
    Me.XrTableCell28.Font = New System.Drawing.Font("Century Gothic", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrTableCell28.Name = "XrTableCell28"
    Me.XrTableCell28.StylePriority.UseFont = False
    Me.XrTableCell28.Weight = 0.82042853242589509R
    '
    'GroupHeader1
    '
    Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
    Me.GroupHeader1.HeightF = 61.45837!
    Me.GroupHeader1.Name = "GroupHeader1"
    Me.GroupHeader1.RepeatEveryPage = True
    '
    'XrTable2
    '
    Me.XrTable2.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(241, Byte), Integer))
    Me.XrTable2.BorderColor = System.Drawing.Color.DarkGray
    Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrTable2.BorderWidth = 0.5!
    Me.XrTable2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(8.916846!, 9.999996!)
    Me.XrTable2.Name = "XrTable2"
    Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
    Me.XrTable2.SizeF = New System.Drawing.SizeF(754.9999!, 51.45837!)
    Me.XrTable2.StylePriority.UseBackColor = False
    Me.XrTable2.StylePriority.UseBorderColor = False
    Me.XrTable2.StylePriority.UseBorders = False
    Me.XrTable2.StylePriority.UseBorderWidth = False
    Me.XrTable2.StylePriority.UseFont = False
    Me.XrTable2.StylePriority.UseTextAlignment = False
    Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '
    'XrTableRow3
    '
    Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell15, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell18, Me.XrTableCell19, Me.XrTableCell21})
    Me.XrTableRow3.Name = "XrTableRow3"
    Me.XrTableRow3.Weight = 1.0R
    '
    'XrTableCell15
    '
    Me.XrTableCell15.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
    Me.XrTableCell15.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrTableCell15.ForeColor = System.Drawing.Color.White
    Me.XrTableCell15.Name = "XrTableCell15"
    Me.XrTableCell15.StylePriority.UseBackColor = False
    Me.XrTableCell15.StylePriority.UseFont = False
    Me.XrTableCell15.StylePriority.UseForeColor = False
    Me.XrTableCell15.StylePriority.UseTextAlignment = False
    Me.XrTableCell15.Text = "Enseigne"
    Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    Me.XrTableCell15.Weight = 1.056250228786054R
    '
    'XrTableCell16
    '
    Me.XrTableCell16.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
    Me.XrTableCell16.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrTableCell16.ForeColor = System.Drawing.Color.White
    Me.XrTableCell16.Name = "XrTableCell16"
    Me.XrTableCell16.StylePriority.UseBackColor = False
    Me.XrTableCell16.StylePriority.UseFont = False
    Me.XrTableCell16.StylePriority.UseForeColor = False
    Me.XrTableCell16.Text = "Sites"
    Me.XrTableCell16.Weight = 1.297914800297665R
    '
    'XrTableCell17
    '
    Me.XrTableCell17.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
    Me.XrTableCell17.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrTableCell17.ForeColor = System.Drawing.Color.White
    Me.XrTableCell17.Name = "XrTableCell17"
    Me.XrTableCell17.StylePriority.UseBackColor = False
    Me.XrTableCell17.StylePriority.UseFont = False
    Me.XrTableCell17.StylePriority.UseForeColor = False
    Me.XrTableCell17.Text = "Sujet"
    Me.XrTableCell17.Weight = 2.8208333003384367R
    '
    'XrTableCell18
    '
    Me.XrTableCell18.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
    Me.XrTableCell18.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrTableCell18.ForeColor = System.Drawing.Color.White
    Me.XrTableCell18.Name = "XrTableCell18"
    Me.XrTableCell18.StylePriority.UseBackColor = False
    Me.XrTableCell18.StylePriority.UseFont = False
    Me.XrTableCell18.StylePriority.UseForeColor = False
    Me.XrTableCell18.Text = "Date/h DI"
    Me.XrTableCell18.Weight = 0.84374876423824552R
    '
    'XrTableCell19
    '
    Me.XrTableCell19.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
    Me.XrTableCell19.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrTableCell19.ForeColor = System.Drawing.Color.White
    Me.XrTableCell19.Name = "XrTableCell19"
    Me.XrTableCell19.StylePriority.UseBackColor = False
    Me.XrTableCell19.StylePriority.UseFont = False
    Me.XrTableCell19.StylePriority.UseForeColor = False
    Me.XrTableCell19.Text = "Date/h réalisation"
    Me.XrTableCell19.Weight = 0.85000183427838183R
    '
    'XrTableCell21
    '
    Me.XrTableCell21.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
    Me.XrTableCell21.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrTableCell21.ForeColor = System.Drawing.Color.White
    Me.XrTableCell21.Name = "XrTableCell21"
    Me.XrTableCell21.StylePriority.UseBackColor = False
    Me.XrTableCell21.StylePriority.UseFont = False
    Me.XrTableCell21.StylePriority.UseForeColor = False
    Me.XrTableCell21.Text = "Délai réalisation (h)"
    Me.XrTableCell21.Weight = 0.68124965412614924R
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
    StoredProcQuery1.Name = "api_sp_Rapport_FM_Impression_RapportIncident_Poste"
    QueryParameter1.Name = "@p_nclinum"
    QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NCLINUM]", GetType(Integer))
    QueryParameter2.Name = "@p_datedebut"
    QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_DEBUT_PERIODE]", GetType(Date))
    QueryParameter3.Name = "@p_datefin"
    QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter3.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_FIN_PERIODE]", GetType(Date))
    QueryParameter4.Name = "@p_venseigne"
    QueryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter4.Value = New DevExpress.DataAccess.Expression("[Parameters.P_VENSEIGNE]", GetType(String))
    QueryParameter5.Name = "@p_slangue"
    QueryParameter5.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter5.Value = New DevExpress.DataAccess.Expression("[Parameters.P_LANGUE]", GetType(String))
    QueryParameter6.Name = "@p_nidrapport_fm_cli"
    QueryParameter6.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter6.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NIDRAPPORT_FM_CLI]", GetType(Integer))
    StoredProcQuery1.Parameters.Add(QueryParameter1)
    StoredProcQuery1.Parameters.Add(QueryParameter2)
    StoredProcQuery1.Parameters.Add(QueryParameter3)
    StoredProcQuery1.Parameters.Add(QueryParameter4)
    StoredProcQuery1.Parameters.Add(QueryParameter5)
    StoredProcQuery1.Parameters.Add(QueryParameter6)
    StoredProcQuery1.StoredProcName = "api_sp_Rapport_FM_Impression_RapportIncident_Poste"
    StoredProcQuery2.Name = "api_sp_Rapport_FM_Impression_DemandeCree_Graph_12M"
    QueryParameter7.Name = "@p_nclinum"
    QueryParameter7.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter7.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NCLINUM]", GetType(Integer))
    QueryParameter8.Name = "@p_datedebut"
    QueryParameter8.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter8.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_DEBUT_12M]", GetType(Date))
    QueryParameter9.Name = "@p_datefin"
    QueryParameter9.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter9.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_FIN_12M]", GetType(Date))
    QueryParameter10.Name = "@p_venseigne"
    QueryParameter10.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter10.Value = New DevExpress.DataAccess.Expression("[Parameters.P_VENSEIGNE]", GetType(String))
    StoredProcQuery2.Parameters.Add(QueryParameter7)
    StoredProcQuery2.Parameters.Add(QueryParameter8)
    StoredProcQuery2.Parameters.Add(QueryParameter9)
    StoredProcQuery2.Parameters.Add(QueryParameter10)
    StoredProcQuery2.Parameters.Add(QueryParameter6)
    StoredProcQuery2.StoredProcName = "api_sp_Rapport_FM_Impression_DemandeCree_Graph"
    StoredProcQuery3.Name = "api_sp_Rapport_FM_Impression_DelaiReaPoste_GraphPie_LastMonth"
    QueryParameter11.Name = "@p_nclinum"
    QueryParameter11.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter11.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NCLINUM]", GetType(Integer))
    QueryParameter12.Name = "@p_datedebut"
    QueryParameter12.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter12.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_DEBUT_LASTMONTH]", GetType(Date))
    QueryParameter13.Name = "@p_datefin"
    QueryParameter13.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter13.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_FIN_LASTMONTH]", GetType(Date))
    QueryParameter14.Name = "@p_venseigne"
    QueryParameter14.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter14.Value = New DevExpress.DataAccess.Expression("[Parameters.P_VENSEIGNE]", GetType(String))
    QueryParameter15.Name = "@p_slangue"
    QueryParameter15.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter15.Value = New DevExpress.DataAccess.Expression("[Parameters.P_LANGUE]", GetType(String))
    StoredProcQuery3.Parameters.Add(QueryParameter11)
    StoredProcQuery3.Parameters.Add(QueryParameter12)
    StoredProcQuery3.Parameters.Add(QueryParameter13)
    StoredProcQuery3.Parameters.Add(QueryParameter14)
    StoredProcQuery3.Parameters.Add(QueryParameter15)
    StoredProcQuery3.Parameters.Add(QueryParameter6)
    StoredProcQuery3.StoredProcName = "api_sp_Rapport_FM_Impression_DelaiReaPoste_GraphPie"
    StoredProcQuery4.Name = "api_sp_Rapport_FM_Impression_DelaiReaPoste_GraphPie_Year"
    QueryParameter16.Name = "@p_nclinum"
    QueryParameter16.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter16.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NCLINUM]", GetType(Integer))
    QueryParameter17.Name = "@p_datedebut"
    QueryParameter17.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter17.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_DEBUT_ANNEE]", GetType(Date))
    QueryParameter18.Name = "@p_datefin"
    QueryParameter18.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter18.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_FIN_LASTMONTH]", GetType(Date))
    QueryParameter19.Name = "@p_venseigne"
    QueryParameter19.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter19.Value = New DevExpress.DataAccess.Expression("[Parameters.P_VENSEIGNE]", GetType(String))
    QueryParameter20.Name = "@p_slangue"
    QueryParameter20.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter20.Value = New DevExpress.DataAccess.Expression("[Parameters.P_LANGUE]", GetType(String))
    StoredProcQuery4.Parameters.Add(QueryParameter16)
    StoredProcQuery4.Parameters.Add(QueryParameter17)
    StoredProcQuery4.Parameters.Add(QueryParameter18)
    StoredProcQuery4.Parameters.Add(QueryParameter19)
    StoredProcQuery4.Parameters.Add(QueryParameter20)
    StoredProcQuery4.Parameters.Add(QueryParameter6)
    StoredProcQuery4.StoredProcName = "api_sp_Rapport_FM_Impression_DelaiReaPoste_GraphPie"
    StoredProcQuery5.Name = "api_sp_Rapport_FM_Impression_DelaiReaPoste_GraphPie_12M"
    QueryParameter21.Name = "@p_nclinum"
    QueryParameter21.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter21.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NCLINUM]", GetType(Integer))
    QueryParameter22.Name = "@p_datedebut"
    QueryParameter22.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter22.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_DEBUT_12M]", GetType(Date))
    QueryParameter23.Name = "@p_datefin"
    QueryParameter23.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter23.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_FIN_12M]", GetType(Date))
    QueryParameter24.Name = "@p_venseigne"
    QueryParameter24.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter24.Value = New DevExpress.DataAccess.Expression("[Parameters.P_VENSEIGNE]", GetType(String))
    QueryParameter25.Name = "@p_slangue"
    QueryParameter25.Type = GetType(DevExpress.DataAccess.Expression)
    QueryParameter25.Value = New DevExpress.DataAccess.Expression("[Parameters.P_LANGUE]", GetType(String))
    StoredProcQuery5.Parameters.Add(QueryParameter21)
    StoredProcQuery5.Parameters.Add(QueryParameter22)
    StoredProcQuery5.Parameters.Add(QueryParameter23)
    StoredProcQuery5.Parameters.Add(QueryParameter24)
    StoredProcQuery5.Parameters.Add(QueryParameter25)
    StoredProcQuery5.Parameters.Add(QueryParameter6)
    StoredProcQuery5.StoredProcName = "api_sp_Rapport_FM_Impression_DelaiReaPoste_GraphPie"
    Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1, StoredProcQuery2, StoredProcQuery3, StoredProcQuery4, StoredProcQuery5})
    Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
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
    'DetailReport1
    '
    Me.DetailReport1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail2})
    Me.DetailReport1.Level = 1
    Me.DetailReport1.Name = "DetailReport1"
    '
    'Detail2
    '
    Me.Detail2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrChart1})
    Me.Detail2.HeightF = 198.0902!
    Me.Detail2.Name = "Detail2"
    '
    'XrChart1
    '
    Me.XrChart1.BorderColor = System.Drawing.Color.Black
    Me.XrChart1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrChart1.BorderWidth = 0.5!
    Me.XrChart1.DataMember = "api_sp_Rapport_FM_Impression_DemandeCree_Graph_12M"
    Me.XrChart1.DataSource = Me.SqlDataSource1
    XyDiagram1.AxisX.Label.Angle = 90
    XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
    XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
    XyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
    XyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
    XyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
    XyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
    Me.XrChart1.Diagram = XyDiagram1
    Me.XrChart1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
    Me.XrChart1.Legend.Name = "Default Legend"
    Me.XrChart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
    Me.XrChart1.LocationFloat = New DevExpress.Utils.PointFloat(8.91681!, 9.999996!)
    Me.XrChart1.Name = "XrChart1"
    Series1.ArgumentDataMember = "AXE_X_LIB"
    SideBySideBarSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
    SideBySideBarSeriesLabel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    SideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
    Series1.Label = SideBySideBarSeriesLabel1
    Series1.Name = "Series 1"
    Series1.ValueDataMembersSerializable = "NB_DEM_CREE"
    Me.XrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
    Me.XrChart1.SizeF = New System.Drawing.SizeF(754.9999!, 178.125!)
    Me.XrChart1.StylePriority.UseBorderColor = False
    Me.XrChart1.StylePriority.UseBorders = False
    Me.XrChart1.StylePriority.UseBorderWidth = False
    ChartTitle1.Alignment = System.Drawing.StringAlignment.Near
    ChartTitle1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    ChartTitle1.Text = "Nb de demandes par mois sur les 12 derniers mois"
    ChartTitle1.TextColor = System.Drawing.Color.Black
    Me.XrChart1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
    '
    'DetailReport2
    '
    Me.DetailReport2.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail3})
    Me.DetailReport2.Level = 2
    Me.DetailReport2.Name = "DetailReport2"
    '
    'Detail3
    '
    Me.Detail3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrChart4, Me.XrChart3, Me.XrChart2})
    Me.Detail3.HeightF = 271.875!
    Me.Detail3.Name = "Detail3"
    '
    'XrChart4
    '
    Me.XrChart4.BorderColor = System.Drawing.Color.Black
    Me.XrChart4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrChart4.BorderWidth = 0.5!
    Me.XrChart4.DataMember = "api_sp_Rapport_FM_Impression_DelaiReaPoste_GraphPie_12M"
    Me.XrChart4.DataSource = Me.SqlDataSource1
    Me.XrChart4.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
    Me.XrChart4.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
    Me.XrChart4.Legend.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrChart4.Legend.HorizontalIndent = 1
    Me.XrChart4.Legend.MarkerSize = New System.Drawing.Size(10, 10)
    Me.XrChart4.Legend.MaxVerticalPercentage = 50.0R
    Me.XrChart4.Legend.Name = "Default Legend"
    Me.XrChart4.LocationFloat = New DevExpress.Utils.PointFloat(536.8334!, 0!)
    Me.XrChart4.Name = "XrChart4"
    Me.XrChart4.PaletteName = "Green Red"
    Me.XrChart4.PaletteRepository.Add("Green Red", New DevExpress.XtraCharts.Palette("Green Red", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Lime, System.Drawing.Color.Lime), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
    Series2.ArgumentDataMember = "LIB"
    PieSeriesLabel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    PieSeriesLabel1.LineLength = 5
    PieSeriesLabel1.TextPattern = "{V:0%}"
    Series2.Label = PieSeriesLabel1
    Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
    Series2.LegendTextPattern = "{A}"
    Series2.Name = "Series 1"
    Series2.ValueDataMembersSerializable = "POURC_DELAI_24"
    Series2.View = PieSeriesView1
    Me.XrChart4.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
    Me.XrChart4.SizeF = New System.Drawing.SizeF(227.0833!, 271.875!)
    Me.XrChart4.StylePriority.UseBorderColor = False
    Me.XrChart4.StylePriority.UseBorders = False
    Me.XrChart4.StylePriority.UseBorderWidth = False
    ChartTitle2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    ChartTitle2.Text = "12 mois glissants"
    ChartTitle2.TextColor = System.Drawing.Color.Black
    Me.XrChart4.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
    '
    'XrChart3
    '
    Me.XrChart3.BorderColor = System.Drawing.Color.Black
    Me.XrChart3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrChart3.BorderWidth = 0.5!
    Me.XrChart3.DataMember = "api_sp_Rapport_FM_Impression_DelaiReaPoste_GraphPie_Year"
    Me.XrChart3.DataSource = Me.SqlDataSource1
    Me.XrChart3.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
    Me.XrChart3.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
    Me.XrChart3.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
    Me.XrChart3.Legend.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrChart3.Legend.HorizontalIndent = 1
    Me.XrChart3.Legend.MarkerSize = New System.Drawing.Size(10, 10)
    Me.XrChart3.Legend.MaxVerticalPercentage = 50.0R
    Me.XrChart3.Legend.Name = "Default Legend"
    Me.XrChart3.LocationFloat = New DevExpress.Utils.PointFloat(272.4773!, 0!)
    Me.XrChart3.Name = "XrChart3"
    Me.XrChart3.PaletteName = "Green Red"
    Me.XrChart3.PaletteRepository.Add("Green Red", New DevExpress.XtraCharts.Palette("Green Red", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Lime, System.Drawing.Color.Lime), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
    Series3.ArgumentDataMember = "LIB"
    PieSeriesLabel2.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
    PieSeriesLabel2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    PieSeriesLabel2.LineLength = 5
    PieSeriesLabel2.TextPattern = "{V:0%}"
    Series3.Label = PieSeriesLabel2
    Series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
    Series3.LegendTextPattern = "{A}"
    Series3.Name = "Series 1"
    Series3.ValueDataMembersSerializable = "POURC_DELAI_24"
    Series3.View = PieSeriesView2
    Me.XrChart3.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3}
    Me.XrChart3.SizeF = New System.Drawing.SizeF(227.0833!, 271.875!)
    Me.XrChart3.StylePriority.UseBorderColor = False
    Me.XrChart3.StylePriority.UseBorders = False
    Me.XrChart3.StylePriority.UseBorderWidth = False
    ChartTitle3.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
    ChartTitle3.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    ChartTitle3.Text = "Depuis le"
    ChartTitle3.TextColor = System.Drawing.Color.Black
    Me.XrChart3.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle3})
    '
    'XrChart2
    '
    Me.XrChart2.BorderColor = System.Drawing.Color.Black
    Me.XrChart2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
    Me.XrChart2.BorderWidth = 0.5!
    Me.XrChart2.DataMember = "api_sp_Rapport_FM_Impression_DelaiReaPoste_GraphPie_LastMonth"
    Me.XrChart2.DataSource = Me.SqlDataSource1
    Me.XrChart2.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
    Me.XrChart2.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
    Me.XrChart2.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
    Me.XrChart2.Legend.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XrChart2.Legend.HorizontalIndent = 1
    Me.XrChart2.Legend.MarkerSize = New System.Drawing.Size(10, 10)
    Me.XrChart2.Legend.MaxVerticalPercentage = 50.0R
    Me.XrChart2.Legend.Name = "Default Legend"
    Me.XrChart2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
    Me.XrChart2.LocationFloat = New DevExpress.Utils.PointFloat(8.91681!, 0!)
    Me.XrChart2.Name = "XrChart2"
    Me.XrChart2.PaletteName = "Green Red"
    Me.XrChart2.PaletteRepository.Add("Green Red", New DevExpress.XtraCharts.Palette("Green Red", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Lime, System.Drawing.Color.Lime), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
    Series4.ArgumentDataMember = "LIB"
    PieSeriesLabel3.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
    PieSeriesLabel3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    PieSeriesLabel3.LineLength = 5
    PieSeriesLabel3.TextPattern = "{V:0%}"
    Series4.Label = PieSeriesLabel3
    Series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
    Series4.LegendTextPattern = "{A}"
    Series4.Name = "Series 1"
    Series4.ValueDataMembersSerializable = "POURC_DELAI_24"
    Series4.View = PieSeriesView3
    Me.XrChart2.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series4}
    Me.XrChart2.SeriesTemplate.ArgumentDataMember = "LIB"
    Me.XrChart2.SeriesTemplate.ValueDataMembersSerializable = "POURC_DELAI_24"
    Me.XrChart2.SizeF = New System.Drawing.SizeF(227.0833!, 271.875!)
    Me.XrChart2.StylePriority.UseBorderColor = False
    Me.XrChart2.StylePriority.UseBorders = False
    Me.XrChart2.StylePriority.UseBorderWidth = False
    ChartTitle4.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
    ChartTitle4.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    ChartTitle4.Text = "Mois précédent"
    ChartTitle4.TextColor = System.Drawing.Color.Black
    Me.XrChart2.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle4})
    '
    'P_NIDRAPPORT_FM_CLI
    '
    Me.P_NIDRAPPORT_FM_CLI.Description = "NIDRAPPORT_FM_CLI"
        Me.P_NIDRAPPORT_FM_CLI.Name = "P_NIDRAPPORT_FM_CLI"
        Me.P_NIDRAPPORT_FM_CLI.Type = GetType(Integer)
        Me.P_NIDRAPPORT_FM_CLI.ValueInfo = "0"
        '
        'XR_Page_Chap_RapportIncident
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.ReportHeader, Me.DetailReport, Me.DetailReport1, Me.DetailReport2})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBoxBordersAllPage})
        Me.Margins = New System.Drawing.Printing.Margins(25, 26, 15, 15)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.P_NCLINUM, Me.P_VENSEIGNE, Me.P_DATE_DEBUT_12M, Me.P_DATE_FIN_12M, Me.P_DATE_DEBUT_PERIODE, Me.P_DATE_FIN_PERIODE, Me.P_DATE_DEBUT_ANNEE, Me.P_DATE_TODAY, Me.P_DATE_DEBUT_LASTMONTH, Me.P_DATE_FIN_LASTMONTH, Me.P_LANGUE, Me.P_NIDRAPPORT_FM_CLI})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "18.2"
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents XrLblPerimetre_RapportIncident As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLblTitreRapportIncident As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents DetailReport1 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail2 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents DetailReport2 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail3 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrChart1 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents XrChart4 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents XrChart3 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents XrChart2 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents P_NIDRAPPORT_FM_CLI As DevExpress.XtraReports.Parameters.Parameter
End Class
