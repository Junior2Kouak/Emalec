<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XR_Page_Chap_Maintenance
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
        Dim QueryParameter11 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim StoredProcQuery3 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter12 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter13 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter14 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter15 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter16 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim StoredProcQuery4 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter17 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter18 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter19 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter20 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter21 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim StoredProcQuery5 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter22 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter23 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter24 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter25 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter26 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XR_Page_Chap_Maintenance))
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
        Me.Detail_Chap_Maintenance = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin_Chap_Maintenance = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin_Chap_Maintenance = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrCrossBandBoxBordersAllPage = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.RH_Chap_Maintenance = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLblMaintenanceTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.DR_Chap_Maintenance_Tab = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail_Chap_Maintenance_Tab = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable_Data_Chap_Maintenance_Tab = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow_Data_Chap_Maintenance_Tab = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XtTab_Data_VENSEIGNE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Data_VSITNOM = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Data_LOT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Data_NBPLA = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Data_NBEXE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Data_TXREA = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GH_Chap_Maintenance_Tab = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable_Entete_Chap_Maintenance_Tab = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow_Entete_Chap_Maintenance_Tab = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XtTab_Entete_VENSEIGNE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Entete_VSITNOM = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Entete_LOT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Entete_NBPLA = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Entete_NBEXE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Entete_TXREA = New DevExpress.XtraReports.UI.XRTableCell()
        Me.SDS_CHap_Maintenance = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.P_NCLINUM = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_VENSEIGNE = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_DATE_DEBUT_12M = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_DATE_FIN_12M = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PageFooter_Chap_Maintenance = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo_Chap_Maintenance = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.DR_Chap_Maintenance_Graph = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail_Chap_Maintenance_Graph = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrChartMaintenancePrevGraph = New DevExpress.XtraReports.UI.XRChart()
        Me.DR_Chap_Maintenance_Pie = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail_Chap_Maintenance_Pie = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrChart_Chap_Maintenance_Pie_Last12M = New DevExpress.XtraReports.UI.XRChart()
        Me.XrChart_Chap_Maintenance_Pie_Year = New DevExpress.XtraReports.UI.XRChart()
        Me.XrChart_Chap_Maintenance_Pie_LastM = New DevExpress.XtraReports.UI.XRChart()
        Me.P_DATE_DEBUT_PERIODE = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_DATE_FIN_PERIODE = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_DATE_DEBUT_ANNEE = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_DATE_TODAY = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_DATE_DEBUT_LASTMONTH = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_DATE_FIN_LASTMONTH = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_LANGUE = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_NIDRAPPORT_FM_CLI = New DevExpress.XtraReports.Parameters.Parameter()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        CType(Me.XrTable_Data_Chap_Maintenance_Tab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable_Entete_Chap_Maintenance_Tab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChartMaintenancePrevGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart_Chap_Maintenance_Pie_Last12M, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart_Chap_Maintenance_Pie_Year, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart_Chap_Maintenance_Pie_LastM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail_Chap_Maintenance
        '
        Me.Detail_Chap_Maintenance.HeightF = 0!
        Me.Detail_Chap_Maintenance.Name = "Detail_Chap_Maintenance"
        Me.Detail_Chap_Maintenance.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail_Chap_Maintenance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin_Chap_Maintenance
        '
        Me.TopMargin_Chap_Maintenance.HeightF = 17.0!
        Me.TopMargin_Chap_Maintenance.Name = "TopMargin_Chap_Maintenance"
        Me.TopMargin_Chap_Maintenance.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin_Chap_Maintenance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin_Chap_Maintenance
        '
        Me.BottomMargin_Chap_Maintenance.HeightF = 12.0!
        Me.BottomMargin_Chap_Maintenance.Name = "BottomMargin_Chap_Maintenance"
        Me.BottomMargin_Chap_Maintenance.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin_Chap_Maintenance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrCrossBandBoxBordersAllPage
        '
        Me.XrCrossBandBoxBordersAllPage.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandBoxBordersAllPage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrCrossBandBoxBordersAllPage.BorderWidth = 1.0!
        Me.XrCrossBandBoxBordersAllPage.EndBand = Me.BottomMargin_Chap_Maintenance
        Me.XrCrossBandBoxBordersAllPage.EndPointFloat = New DevExpress.Utils.PointFloat(0.625001!, 7.043085!)
        Me.XrCrossBandBoxBordersAllPage.Name = "XrCrossBandBoxBordersAllPage"
        Me.XrCrossBandBoxBordersAllPage.StartBand = Me.TopMargin_Chap_Maintenance
        Me.XrCrossBandBoxBordersAllPage.StartPointFloat = New DevExpress.Utils.PointFloat(0.625001!, 9.374997!)
        Me.XrCrossBandBoxBordersAllPage.WidthF = 775.4166!
        '
        'RH_Chap_Maintenance
        '
        Me.RH_Chap_Maintenance.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLblMaintenanceTitle})
        Me.RH_Chap_Maintenance.HeightF = 23.0!
        Me.RH_Chap_Maintenance.Name = "RH_Chap_Maintenance"
        '
        'XrLblMaintenanceTitle
        '
        Me.XrLblMaintenanceTitle.Font = New DevExpress.Drawing.DXFont("Century Gothic", 10.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLblMaintenanceTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrLblMaintenanceTitle.LocationFloat = New DevExpress.Utils.PointFloat(11.00032!, 0!)
        Me.XrLblMaintenanceTitle.Name = "XrLblMaintenanceTitle"
        Me.XrLblMaintenanceTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblMaintenanceTitle.SizeF = New System.Drawing.SizeF(754.9998!, 23.0!)
        Me.XrLblMaintenanceTitle.StylePriority.UseFont = False
        Me.XrLblMaintenanceTitle.StylePriority.UseForeColor = False
        Me.XrLblMaintenanceTitle.Text = "Respect du plan de maintenance"
        '
        'DR_Chap_Maintenance_Tab
        '
        Me.DR_Chap_Maintenance_Tab.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail_Chap_Maintenance_Tab, Me.GH_Chap_Maintenance_Tab})
        Me.DR_Chap_Maintenance_Tab.DataMember = "api_sp_Rapport_FM_Impression_PlanRealisation"
        Me.DR_Chap_Maintenance_Tab.DataSource = Me.SDS_CHap_Maintenance
        Me.DR_Chap_Maintenance_Tab.Level = 0
        Me.DR_Chap_Maintenance_Tab.Name = "DR_Chap_Maintenance_Tab"
        '
        'Detail_Chap_Maintenance_Tab
        '
        Me.Detail_Chap_Maintenance_Tab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable_Data_Chap_Maintenance_Tab})
        Me.Detail_Chap_Maintenance_Tab.HeightF = 15.0!
        Me.Detail_Chap_Maintenance_Tab.Name = "Detail_Chap_Maintenance_Tab"
        '
        'XrTable_Data_Chap_Maintenance_Tab
        '
        Me.XrTable_Data_Chap_Maintenance_Tab.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTable_Data_Chap_Maintenance_Tab.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable_Data_Chap_Maintenance_Tab.BorderWidth = 0.5!
        Me.XrTable_Data_Chap_Maintenance_Tab.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTable_Data_Chap_Maintenance_Tab.LocationFloat = New DevExpress.Utils.PointFloat(11.00045!, 0!)
        Me.XrTable_Data_Chap_Maintenance_Tab.Name = "XrTable_Data_Chap_Maintenance_Tab"
        Me.XrTable_Data_Chap_Maintenance_Tab.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow_Data_Chap_Maintenance_Tab})
        Me.XrTable_Data_Chap_Maintenance_Tab.SizeF = New System.Drawing.SizeF(754.9997!, 15.0!)
        Me.XrTable_Data_Chap_Maintenance_Tab.StylePriority.UseBorderColor = False
        Me.XrTable_Data_Chap_Maintenance_Tab.StylePriority.UseBorders = False
        Me.XrTable_Data_Chap_Maintenance_Tab.StylePriority.UseBorderWidth = False
        Me.XrTable_Data_Chap_Maintenance_Tab.StylePriority.UseFont = False
        Me.XrTable_Data_Chap_Maintenance_Tab.StylePriority.UseTextAlignment = False
        Me.XrTable_Data_Chap_Maintenance_Tab.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow_Data_Chap_Maintenance_Tab
        '
        Me.XrTableRow_Data_Chap_Maintenance_Tab.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XtTab_Data_VENSEIGNE, Me.XtTab_Data_VSITNOM, Me.XtTab_Data_LOT, Me.XtTab_Data_NBPLA, Me.XtTab_Data_NBEXE, Me.XtTab_Data_TXREA})
        Me.XrTableRow_Data_Chap_Maintenance_Tab.Name = "XrTableRow_Data_Chap_Maintenance_Tab"
        Me.XrTableRow_Data_Chap_Maintenance_Tab.Weight = 11.5R
        '
        'XtTab_Data_VENSEIGNE
        '
        Me.XtTab_Data_VENSEIGNE.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VSITENSEIGNE]")})
        Me.XtTab_Data_VENSEIGNE.Name = "XtTab_Data_VENSEIGNE"
        Me.XtTab_Data_VENSEIGNE.Text = "XtTab_Data_VENSEIGNE"
        Me.XtTab_Data_VENSEIGNE.Weight = 0.46402764623919768R
        '
        'XtTab_Data_VSITNOM
        '
        Me.XtTab_Data_VSITNOM.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VSITNOM]")})
        Me.XtTab_Data_VSITNOM.Name = "XtTab_Data_VSITNOM"
        Me.XtTab_Data_VSITNOM.Text = "XtTab_Data_VSITNOM"
        Me.XtTab_Data_VSITNOM.Weight = 0.781222643633608R
        '
        'XtTab_Data_LOT
        '
        Me.XtTab_Data_LOT.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VTYPECONTRAT]")})
        Me.XtTab_Data_LOT.Name = "XtTab_Data_LOT"
        Me.XtTab_Data_LOT.Text = "XtTab_Data_LOT"
        Me.XtTab_Data_LOT.Weight = 1.1334622865369777R
        '
        'XtTab_Data_NBPLA
        '
        Me.XtTab_Data_NBPLA.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NBPLA]")})
        Me.XtTab_Data_NBPLA.Name = "XtTab_Data_NBPLA"
        Me.XtTab_Data_NBPLA.Text = "XtTab_Data_NBPLA"
        Me.XtTab_Data_NBPLA.TextFormatString = "{0:n0}"
        Me.XtTab_Data_NBPLA.Weight = 0.32879880176033593R
        '
        'XtTab_Data_NBEXE
        '
        Me.XtTab_Data_NBEXE.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NBEXE]")})
        Me.XtTab_Data_NBEXE.Name = "XtTab_Data_NBEXE"
        Me.XtTab_Data_NBEXE.Text = "XtTab_Data_NBEXE"
        Me.XtTab_Data_NBEXE.TextFormatString = "{0:n0}"
        Me.XtTab_Data_NBEXE.Weight = 0.31003912579027648R
        '
        'XtTab_Data_TXREA
        '
        Me.XtTab_Data_TXREA.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TXREA]")})
        Me.XtTab_Data_TXREA.Name = "XtTab_Data_TXREA"
        Me.XtTab_Data_TXREA.Text = "XtTab_Data_TXREA"
        Me.XtTab_Data_TXREA.TextFormatString = "{0:0%}"
        Me.XtTab_Data_TXREA.Weight = 0.29928240425989178R
        '
        'GH_Chap_Maintenance_Tab
        '
        Me.GH_Chap_Maintenance_Tab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable_Entete_Chap_Maintenance_Tab})
        Me.GH_Chap_Maintenance_Tab.HeightF = 45.41667!
        Me.GH_Chap_Maintenance_Tab.Name = "GH_Chap_Maintenance_Tab"
        Me.GH_Chap_Maintenance_Tab.RepeatEveryPage = True
        '
        'XrTable_Entete_Chap_Maintenance_Tab
        '
        Me.XrTable_Entete_Chap_Maintenance_Tab.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.XrTable_Entete_Chap_Maintenance_Tab.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTable_Entete_Chap_Maintenance_Tab.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable_Entete_Chap_Maintenance_Tab.BorderWidth = 0.5!
        Me.XrTable_Entete_Chap_Maintenance_Tab.Font = New DevExpress.Drawing.DXFont("Century Gothic", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTable_Entete_Chap_Maintenance_Tab.LocationFloat = New DevExpress.Utils.PointFloat(11.00041!, 9.999998!)
        Me.XrTable_Entete_Chap_Maintenance_Tab.Name = "XrTable_Entete_Chap_Maintenance_Tab"
        Me.XrTable_Entete_Chap_Maintenance_Tab.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow_Entete_Chap_Maintenance_Tab})
        Me.XrTable_Entete_Chap_Maintenance_Tab.SizeF = New System.Drawing.SizeF(754.9997!, 35.41667!)
        Me.XrTable_Entete_Chap_Maintenance_Tab.StylePriority.UseBackColor = False
        Me.XrTable_Entete_Chap_Maintenance_Tab.StylePriority.UseBorderColor = False
        Me.XrTable_Entete_Chap_Maintenance_Tab.StylePriority.UseBorders = False
        Me.XrTable_Entete_Chap_Maintenance_Tab.StylePriority.UseBorderWidth = False
        Me.XrTable_Entete_Chap_Maintenance_Tab.StylePriority.UseFont = False
        Me.XrTable_Entete_Chap_Maintenance_Tab.StylePriority.UseTextAlignment = False
        Me.XrTable_Entete_Chap_Maintenance_Tab.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow_Entete_Chap_Maintenance_Tab
        '
        Me.XrTableRow_Entete_Chap_Maintenance_Tab.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XtTab_Entete_VENSEIGNE, Me.XtTab_Entete_VSITNOM, Me.XtTab_Entete_LOT, Me.XtTab_Entete_NBPLA, Me.XtTab_Entete_NBEXE, Me.XtTab_Entete_TXREA})
        Me.XrTableRow_Entete_Chap_Maintenance_Tab.Name = "XrTableRow_Entete_Chap_Maintenance_Tab"
        Me.XrTableRow_Entete_Chap_Maintenance_Tab.Weight = 1.0R
        '
        'XtTab_Entete_VENSEIGNE
        '
        Me.XtTab_Entete_VENSEIGNE.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XtTab_Entete_VENSEIGNE.Font = New DevExpress.Drawing.DXFont("Century Gothic", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XtTab_Entete_VENSEIGNE.ForeColor = System.Drawing.Color.White
        Me.XtTab_Entete_VENSEIGNE.Name = "XtTab_Entete_VENSEIGNE"
        Me.XtTab_Entete_VENSEIGNE.StylePriority.UseBackColor = False
        Me.XtTab_Entete_VENSEIGNE.StylePriority.UseFont = False
        Me.XtTab_Entete_VENSEIGNE.StylePriority.UseForeColor = False
        Me.XtTab_Entete_VENSEIGNE.StylePriority.UseTextAlignment = False
        Me.XtTab_Entete_VENSEIGNE.Text = "Enseigne"
        Me.XtTab_Entete_VENSEIGNE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XtTab_Entete_VENSEIGNE.Weight = 1.056250228786054R
        '
        'XtTab_Entete_VSITNOM
        '
        Me.XtTab_Entete_VSITNOM.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XtTab_Entete_VSITNOM.Font = New DevExpress.Drawing.DXFont("Century Gothic", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XtTab_Entete_VSITNOM.ForeColor = System.Drawing.Color.White
        Me.XtTab_Entete_VSITNOM.Name = "XtTab_Entete_VSITNOM"
        Me.XtTab_Entete_VSITNOM.StylePriority.UseBackColor = False
        Me.XtTab_Entete_VSITNOM.StylePriority.UseFont = False
        Me.XtTab_Entete_VSITNOM.StylePriority.UseForeColor = False
        Me.XtTab_Entete_VSITNOM.Text = "Sites"
        Me.XtTab_Entete_VSITNOM.Weight = 1.7782707888681086R
        '
        'XtTab_Entete_LOT
        '
        Me.XtTab_Entete_LOT.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XtTab_Entete_LOT.Font = New DevExpress.Drawing.DXFont("Century Gothic", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XtTab_Entete_LOT.ForeColor = System.Drawing.Color.White
        Me.XtTab_Entete_LOT.Name = "XtTab_Entete_LOT"
        Me.XtTab_Entete_LOT.StylePriority.UseBackColor = False
        Me.XtTab_Entete_LOT.StylePriority.UseFont = False
        Me.XtTab_Entete_LOT.StylePriority.UseForeColor = False
        Me.XtTab_Entete_LOT.Text = "Lots"
        Me.XtTab_Entete_LOT.Weight = 2.5800618825213766R
        '
        'XtTab_Entete_NBPLA
        '
        Me.XtTab_Entete_NBPLA.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XtTab_Entete_NBPLA.Font = New DevExpress.Drawing.DXFont("Century Gothic", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XtTab_Entete_NBPLA.ForeColor = System.Drawing.Color.White
        Me.XtTab_Entete_NBPLA.Name = "XtTab_Entete_NBPLA"
        Me.XtTab_Entete_NBPLA.StylePriority.UseBackColor = False
        Me.XtTab_Entete_NBPLA.StylePriority.UseFont = False
        Me.XtTab_Entete_NBPLA.StylePriority.UseForeColor = False
        Me.XtTab_Entete_NBPLA.Text = "Nombre planifié"
        Me.XtTab_Entete_NBPLA.Weight = 0.7484355802161563R
        '
        'XtTab_Entete_NBEXE
        '
        Me.XtTab_Entete_NBEXE.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XtTab_Entete_NBEXE.Font = New DevExpress.Drawing.DXFont("Century Gothic", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XtTab_Entete_NBEXE.ForeColor = System.Drawing.Color.White
        Me.XtTab_Entete_NBEXE.Name = "XtTab_Entete_NBEXE"
        Me.XtTab_Entete_NBEXE.StylePriority.UseBackColor = False
        Me.XtTab_Entete_NBEXE.StylePriority.UseFont = False
        Me.XtTab_Entete_NBEXE.StylePriority.UseForeColor = False
        Me.XtTab_Entete_NBEXE.Text = "Nombre réalisé"
        Me.XtTab_Entete_NBEXE.Weight = 0.70573046174953835R
        '
        'XtTab_Entete_TXREA
        '
        Me.XtTab_Entete_TXREA.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XtTab_Entete_TXREA.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XtTab_Entete_TXREA.Font = New DevExpress.Drawing.DXFont("Century Gothic", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XtTab_Entete_TXREA.ForeColor = System.Drawing.Color.White
        Me.XtTab_Entete_TXREA.Name = "XtTab_Entete_TXREA"
        Me.XtTab_Entete_TXREA.StylePriority.UseBackColor = False
        Me.XtTab_Entete_TXREA.StylePriority.UseBorderColor = False
        Me.XtTab_Entete_TXREA.StylePriority.UseFont = False
        Me.XtTab_Entete_TXREA.StylePriority.UseForeColor = False
        Me.XtTab_Entete_TXREA.Text = "Taux réalisation"
        Me.XtTab_Entete_TXREA.Weight = 0.68124682300802719R
        '
        'SDS_CHap_Maintenance
        '
        Me.SDS_CHap_Maintenance.ConnectionName = "SRV-VMSQLPROD_MULTI_Connection 1"
        Me.SDS_CHap_Maintenance.ConnectionOptions.DbCommandTimeout = 0
        MsSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows
        MsSqlConnectionParameters1.DatabaseName = "MULTI"
        MsSqlConnectionParameters1.ServerName = "SRV-VMSQLPROD"
        Me.SDS_CHap_Maintenance.ConnectionParameters = MsSqlConnectionParameters1
        Me.SDS_CHap_Maintenance.Name = "SDS_CHap_Maintenance"
        StoredProcQuery1.Name = "api_sp_Rapport_FM_Impression_PlanRealisation"
        QueryParameter1.Name = "@p_nclinum"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NCLINUM]", GetType(Integer))
        QueryParameter2.Name = "@p_venseigne"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.P_VENSEIGNE]", GetType(String))
        QueryParameter3.Name = "@p_datedebut"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_DEBUT_PERIODE]", GetType(Date))
        QueryParameter4.Name = "@p_datefin"
        QueryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter4.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_FIN_PERIODE]", GetType(Date))
        QueryParameter5.Name = "@p_slangue"
        QueryParameter5.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter5.Value = New DevExpress.DataAccess.Expression("[Parameters.P_LANGUE]", GetType(String))
        QueryParameter6.Name = "@p_nidrapport_fm_cli"
        QueryParameter6.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter6.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NIDRAPPORT_FM_CLI]", GetType(Integer))
        StoredProcQuery1.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter1, QueryParameter2, QueryParameter3, QueryParameter4, QueryParameter5, QueryParameter6})
        StoredProcQuery1.StoredProcName = "api_sp_Rapport_FM_Impression_PlanRealisation"
        StoredProcQuery2.Name = "api_sp_Rapport_FM_Impression_PlanRealisation_Graph12M"
        QueryParameter7.Name = "@p_nclinum"
        QueryParameter7.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter7.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NCLINUM]", GetType(Integer))
        QueryParameter8.Name = "@p_venseigne"
        QueryParameter8.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter8.Value = New DevExpress.DataAccess.Expression("[Parameters.P_VENSEIGNE]", GetType(String))
        QueryParameter9.Name = "@p_datedebut"
        QueryParameter9.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter9.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_DEBUT_12M]", GetType(Date))
        QueryParameter10.Name = "@p_datefin"
        QueryParameter10.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter10.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_FIN_12M]", GetType(Date))
        QueryParameter11.Name = "@p_slangue"
        QueryParameter11.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter11.Value = New DevExpress.DataAccess.Expression("[Parameters.P_LANGUE]", GetType(String))
        StoredProcQuery2.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter7, QueryParameter8, QueryParameter9, QueryParameter10, QueryParameter11, QueryParameter6})
        StoredProcQuery2.StoredProcName = "api_sp_Rapport_FM_Impression_PlanRealisation_Graph12M"
        StoredProcQuery3.Name = "api_sp_Rapport_FM_Impression_PlanRealisation_GraphCirculaire_LastMonth"
        QueryParameter12.Name = "@p_nclinum"
        QueryParameter12.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter12.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NCLINUM]", GetType(Integer))
        QueryParameter13.Name = "@p_venseigne"
        QueryParameter13.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter13.Value = New DevExpress.DataAccess.Expression("[Parameters.P_VENSEIGNE]", GetType(String))
        QueryParameter14.Name = "@p_datedebut"
        QueryParameter14.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter14.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_DEBUT_LASTMONTH]", GetType(Date))
        QueryParameter15.Name = "@p_datefin"
        QueryParameter15.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter15.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_FIN_LASTMONTH]", GetType(Date))
        QueryParameter16.Name = "@p_slangue"
        QueryParameter16.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter16.Value = New DevExpress.DataAccess.Expression("[Parameters.P_LANGUE]", GetType(String))
        StoredProcQuery3.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter12, QueryParameter13, QueryParameter14, QueryParameter15, QueryParameter16, QueryParameter6})
        StoredProcQuery3.StoredProcName = "api_sp_Rapport_FM_Impression_PlanRealisation_GraphCirculaire"
        StoredProcQuery4.Name = "api_sp_Rapport_FM_Impression_PlanRealisation_GraphCirculaire_Year"
        QueryParameter17.Name = "@p_nclinum"
        QueryParameter17.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter17.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NCLINUM]", GetType(Integer))
        QueryParameter18.Name = "@p_venseigne"
        QueryParameter18.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter18.Value = New DevExpress.DataAccess.Expression("[Parameters.P_VENSEIGNE]", GetType(String))
        QueryParameter19.Name = "@p_datedebut"
        QueryParameter19.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter19.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_DEBUT_ANNEE]", GetType(Date))
        QueryParameter20.Name = "@p_datefin"
        QueryParameter20.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter20.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_FIN_PERIODE]", GetType(Date))
        QueryParameter21.Name = "@p_slangue"
        QueryParameter21.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter21.Value = New DevExpress.DataAccess.Expression("[Parameters.P_LANGUE]", GetType(String))
        StoredProcQuery4.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter17, QueryParameter18, QueryParameter19, QueryParameter20, QueryParameter21, QueryParameter6})
        StoredProcQuery4.StoredProcName = "api_sp_Rapport_FM_Impression_PlanRealisation_GraphCirculaire"
        StoredProcQuery5.Name = "api_sp_Rapport_FM_Impression_PlanRealisation_GraphCirculaire_12M"
        QueryParameter22.Name = "@p_nclinum"
        QueryParameter22.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter22.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NCLINUM]", GetType(Integer))
        QueryParameter23.Name = "@p_venseigne"
        QueryParameter23.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter23.Value = New DevExpress.DataAccess.Expression("[Parameters.P_VENSEIGNE]", GetType(String))
        QueryParameter24.Name = "@p_datedebut"
        QueryParameter24.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter24.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_DEBUT_12M]", GetType(Date))
        QueryParameter25.Name = "@p_datefin"
        QueryParameter25.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter25.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_FIN_PERIODE]", GetType(Date))
        QueryParameter26.Name = "@p_slangue"
        QueryParameter26.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter26.Value = New DevExpress.DataAccess.Expression("[Parameters.P_LANGUE]", GetType(String))
        StoredProcQuery5.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter22, QueryParameter23, QueryParameter24, QueryParameter25, QueryParameter26, QueryParameter6})
        StoredProcQuery5.StoredProcName = "api_sp_Rapport_FM_Impression_PlanRealisation_GraphCirculaire"
        Me.SDS_CHap_Maintenance.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1, StoredProcQuery2, StoredProcQuery3, StoredProcQuery4, StoredProcQuery5})
        Me.SDS_CHap_Maintenance.ResultSchemaSerializable = resources.GetString("SDS_CHap_Maintenance.ResultSchemaSerializable")
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
        Me.P_DATE_DEBUT_12M.AllowNull = True
        Me.P_DATE_DEBUT_12M.Description = "Date debut sur 12 Mois"
        Me.P_DATE_DEBUT_12M.Name = "P_DATE_DEBUT_12M"
        Me.P_DATE_DEBUT_12M.Type = GetType(Date)
        '
        'P_DATE_FIN_12M
        '
        Me.P_DATE_FIN_12M.AllowNull = True
        Me.P_DATE_FIN_12M.Description = "Date Fin sur 12 mois"
        Me.P_DATE_FIN_12M.Name = "P_DATE_FIN_12M"
        Me.P_DATE_FIN_12M.Type = GetType(Date)
        '
        'PageFooter_Chap_Maintenance
        '
        Me.PageFooter_Chap_Maintenance.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo_Chap_Maintenance})
        Me.PageFooter_Chap_Maintenance.HeightF = 24.34212!
        Me.PageFooter_Chap_Maintenance.Name = "PageFooter_Chap_Maintenance"
        '
        'XrPageInfo_Chap_Maintenance
        '
        Me.XrPageInfo_Chap_Maintenance.Font = New DevExpress.Drawing.DXFont("Century Gothic", 9.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrPageInfo_Chap_Maintenance.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPageInfo_Chap_Maintenance.Name = "XrPageInfo_Chap_Maintenance"
        Me.XrPageInfo_Chap_Maintenance.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo_Chap_Maintenance.SizeF = New System.Drawing.SizeF(772.9167!, 23.0!)
        Me.XrPageInfo_Chap_Maintenance.StylePriority.UseFont = False
        Me.XrPageInfo_Chap_Maintenance.StylePriority.UseTextAlignment = False
        Me.XrPageInfo_Chap_Maintenance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'DR_Chap_Maintenance_Graph
        '
        Me.DR_Chap_Maintenance_Graph.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail_Chap_Maintenance_Graph})
        Me.DR_Chap_Maintenance_Graph.DataSource = Me.SDS_CHap_Maintenance
        Me.DR_Chap_Maintenance_Graph.Level = 1
        Me.DR_Chap_Maintenance_Graph.Name = "DR_Chap_Maintenance_Graph"
        '
        'Detail_Chap_Maintenance_Graph
        '
        Me.Detail_Chap_Maintenance_Graph.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrChartMaintenancePrevGraph})
        Me.Detail_Chap_Maintenance_Graph.HeightF = 199.8264!
        Me.Detail_Chap_Maintenance_Graph.Name = "Detail_Chap_Maintenance_Graph"
        '
        'XrChartMaintenancePrevGraph
        '
        Me.XrChartMaintenancePrevGraph.BorderColor = System.Drawing.Color.Black
        Me.XrChartMaintenancePrevGraph.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrChartMaintenancePrevGraph.BorderWidth = 0.5!
        Me.XrChartMaintenancePrevGraph.DataMember = "api_sp_Rapport_FM_Impression_PlanRealisation_Graph12M"
        Me.XrChartMaintenancePrevGraph.DataSource = Me.SDS_CHap_Maintenance
        XyDiagram1.AxisX.Label.Angle = 90
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChartMaintenancePrevGraph.Diagram = XyDiagram1
        Me.XrChartMaintenancePrevGraph.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.XrChartMaintenancePrevGraph.Legend.Name = "Default Legend"
        Me.XrChartMaintenancePrevGraph.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChartMaintenancePrevGraph.LocationFloat = New DevExpress.Utils.PointFloat(11.00045!, 9.999998!)
        Me.XrChartMaintenancePrevGraph.Name = "XrChartMaintenancePrevGraph"
        Series1.ArgumentDataMember = "AXE_X_LIB"
        SideBySideBarSeriesLabel1.DXFont = New DevExpress.Drawing.DXFont("Century Gothic", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        SideBySideBarSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.Name = "Series 1"
        Series1.ValueDataMembersSerializable = "NBPREVEXE"
        Me.XrChartMaintenancePrevGraph.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.XrChartMaintenancePrevGraph.SeriesTemplate.ArgumentDataMember = "AXE_X_LIB"
        Me.XrChartMaintenancePrevGraph.SeriesTemplate.ValueDataMembersSerializable = "NBPREVEXE"
        Me.XrChartMaintenancePrevGraph.SizeF = New System.Drawing.SizeF(754.9997!, 178.125!)
        Me.XrChartMaintenancePrevGraph.StylePriority.UseBorderColor = False
        Me.XrChartMaintenancePrevGraph.StylePriority.UseBorders = False
        Me.XrChartMaintenancePrevGraph.StylePriority.UseBorderWidth = False
        ChartTitle1.Alignment = System.Drawing.StringAlignment.Near
        ChartTitle1.DXFont = New DevExpress.Drawing.DXFont("Century Gothic", 10.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        ChartTitle1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        ChartTitle1.Text = "Nb préventifs réalisés par mois dans les 12 derniers mois"
        ChartTitle1.TextColor = System.Drawing.Color.Black
        Me.XrChartMaintenancePrevGraph.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'DR_Chap_Maintenance_Pie
        '
        Me.DR_Chap_Maintenance_Pie.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail_Chap_Maintenance_Pie})
        Me.DR_Chap_Maintenance_Pie.DataSource = Me.SDS_CHap_Maintenance
        Me.DR_Chap_Maintenance_Pie.Level = 2
        Me.DR_Chap_Maintenance_Pie.Name = "DR_Chap_Maintenance_Pie"
        '
        'Detail_Chap_Maintenance_Pie
        '
        Me.Detail_Chap_Maintenance_Pie.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrChart_Chap_Maintenance_Pie_Last12M, Me.XrChart_Chap_Maintenance_Pie_Year, Me.XrChart_Chap_Maintenance_Pie_LastM})
        Me.Detail_Chap_Maintenance_Pie.HeightF = 271.875!
        Me.Detail_Chap_Maintenance_Pie.Name = "Detail_Chap_Maintenance_Pie"
        '
        'XrChart_Chap_Maintenance_Pie_Last12M
        '
        Me.XrChart_Chap_Maintenance_Pie_Last12M.BorderColor = System.Drawing.Color.Black
        Me.XrChart_Chap_Maintenance_Pie_Last12M.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrChart_Chap_Maintenance_Pie_Last12M.BorderWidth = 0.5!
        Me.XrChart_Chap_Maintenance_Pie_Last12M.DataMember = "api_sp_Rapport_FM_Impression_PlanRealisation_GraphCirculaire_12M"
        Me.XrChart_Chap_Maintenance_Pie_Last12M.DataSource = Me.SDS_CHap_Maintenance
        Me.XrChart_Chap_Maintenance_Pie_Last12M.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.XrChart_Chap_Maintenance_Pie_Last12M.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.XrChart_Chap_Maintenance_Pie_Last12M.Legend.DXFont = New DevExpress.Drawing.DXFont("Century Gothic", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrChart_Chap_Maintenance_Pie_Last12M.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        Me.XrChart_Chap_Maintenance_Pie_Last12M.Legend.MarkerSize = New System.Drawing.Size(10, 10)
        Me.XrChart_Chap_Maintenance_Pie_Last12M.Legend.MaxVerticalPercentage = 50.0R
        Me.XrChart_Chap_Maintenance_Pie_Last12M.Legend.Name = "Default Legend"
        Me.XrChart_Chap_Maintenance_Pie_Last12M.LocationFloat = New DevExpress.Utils.PointFloat(538.9166!, 0!)
        Me.XrChart_Chap_Maintenance_Pie_Last12M.Name = "XrChart_Chap_Maintenance_Pie_Last12M"
        Me.XrChart_Chap_Maintenance_Pie_Last12M.PaletteName = "Green Red"
        Me.XrChart_Chap_Maintenance_Pie_Last12M.PaletteRepository.Add("Green Red", New DevExpress.XtraCharts.Palette("Green Red", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Lime, System.Drawing.Color.Lime), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
        Series2.ArgumentDataMember = "LIB"
        PieSeriesLabel1.DXFont = New DevExpress.Drawing.DXFont("Century Gothic", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        PieSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel1.LineLength = 5
        PieSeriesLabel1.TextPattern = "{VP:0.00%}"
        Series2.Label = PieSeriesLabel1
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series2.LegendTextPattern = "{A:0.00%}"
        Series2.Name = "Series 1"
        Series2.ValueDataMembersSerializable = "TXREA"
        Series2.View = PieSeriesView1
        Me.XrChart_Chap_Maintenance_Pie_Last12M.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        Me.XrChart_Chap_Maintenance_Pie_Last12M.SizeF = New System.Drawing.SizeF(227.0833!, 271.875!)
        Me.XrChart_Chap_Maintenance_Pie_Last12M.StylePriority.UseBorderColor = False
        Me.XrChart_Chap_Maintenance_Pie_Last12M.StylePriority.UseBorders = False
        Me.XrChart_Chap_Maintenance_Pie_Last12M.StylePriority.UseBorderWidth = False
        ChartTitle2.DXFont = New DevExpress.Drawing.DXFont("Century Gothic", 10.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        ChartTitle2.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        ChartTitle2.Text = "12 mois glissants"
        ChartTitle2.TextColor = System.Drawing.Color.Black
        Me.XrChart_Chap_Maintenance_Pie_Last12M.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'XrChart_Chap_Maintenance_Pie_Year
        '
        Me.XrChart_Chap_Maintenance_Pie_Year.BorderColor = System.Drawing.Color.Black
        Me.XrChart_Chap_Maintenance_Pie_Year.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrChart_Chap_Maintenance_Pie_Year.BorderWidth = 0.5!
        Me.XrChart_Chap_Maintenance_Pie_Year.DataMember = "api_sp_Rapport_FM_Impression_PlanRealisation_GraphCirculaire_Year"
        Me.XrChart_Chap_Maintenance_Pie_Year.DataSource = Me.SDS_CHap_Maintenance
        Me.XrChart_Chap_Maintenance_Pie_Year.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.XrChart_Chap_Maintenance_Pie_Year.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.XrChart_Chap_Maintenance_Pie_Year.Legend.DXFont = New DevExpress.Drawing.DXFont("Century Gothic", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrChart_Chap_Maintenance_Pie_Year.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        Me.XrChart_Chap_Maintenance_Pie_Year.Legend.HorizontalIndent = 1
        Me.XrChart_Chap_Maintenance_Pie_Year.Legend.MarkerSize = New System.Drawing.Size(10, 10)
        Me.XrChart_Chap_Maintenance_Pie_Year.Legend.MaxVerticalPercentage = 50.0R
        Me.XrChart_Chap_Maintenance_Pie_Year.Legend.Name = "Default Legend"
        Me.XrChart_Chap_Maintenance_Pie_Year.LocationFloat = New DevExpress.Utils.PointFloat(280.3842!, 0!)
        Me.XrChart_Chap_Maintenance_Pie_Year.Name = "XrChart_Chap_Maintenance_Pie_Year"
        Me.XrChart_Chap_Maintenance_Pie_Year.PaletteName = "Green Red"
        Me.XrChart_Chap_Maintenance_Pie_Year.PaletteRepository.Add("Green Red", New DevExpress.XtraCharts.Palette("Green Red", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Lime, System.Drawing.Color.Lime), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
        Series3.ArgumentDataMember = "LIB"
        Series3.ColorDataMember = "VCOLOR"
        PieSeriesLabel2.DXFont = New DevExpress.Drawing.DXFont("Century Gothic", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        PieSeriesLabel2.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel2.LineLength = 5
        PieSeriesLabel2.TextPattern = "{VP:0.00%}"
        Series3.Label = PieSeriesLabel2
        Series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series3.LegendTextPattern = "{A}"
        Series3.Name = "Series 1"
        Series3.ValueDataMembersSerializable = "TXREA"
        Series3.View = PieSeriesView2
        Me.XrChart_Chap_Maintenance_Pie_Year.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3}
        Me.XrChart_Chap_Maintenance_Pie_Year.SizeF = New System.Drawing.SizeF(227.0833!, 271.875!)
        Me.XrChart_Chap_Maintenance_Pie_Year.StylePriority.UseBorderColor = False
        Me.XrChart_Chap_Maintenance_Pie_Year.StylePriority.UseBorders = False
        Me.XrChart_Chap_Maintenance_Pie_Year.StylePriority.UseBorderWidth = False
        ChartTitle3.DXFont = New DevExpress.Drawing.DXFont("Century Gothic", 10.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        ChartTitle3.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        ChartTitle3.Text = "Depuis le"
        ChartTitle3.TextColor = System.Drawing.Color.Black
        Me.XrChart_Chap_Maintenance_Pie_Year.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle3})
        '
        'XrChart_Chap_Maintenance_Pie_LastM
        '
        Me.XrChart_Chap_Maintenance_Pie_LastM.BorderColor = System.Drawing.Color.Black
        Me.XrChart_Chap_Maintenance_Pie_LastM.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrChart_Chap_Maintenance_Pie_LastM.BorderWidth = 0.5!
        Me.XrChart_Chap_Maintenance_Pie_LastM.DataMember = "api_sp_Rapport_FM_Impression_PlanRealisation_GraphCirculaire_LastMonth"
        Me.XrChart_Chap_Maintenance_Pie_LastM.DataSource = Me.SDS_CHap_Maintenance
        Me.XrChart_Chap_Maintenance_Pie_LastM.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.XrChart_Chap_Maintenance_Pie_LastM.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.XrChart_Chap_Maintenance_Pie_LastM.Legend.DXFont = New DevExpress.Drawing.DXFont("Century Gothic", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrChart_Chap_Maintenance_Pie_LastM.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        Me.XrChart_Chap_Maintenance_Pie_LastM.Legend.HorizontalIndent = 1
        Me.XrChart_Chap_Maintenance_Pie_LastM.Legend.MarkerSize = New System.Drawing.Size(10, 10)
        Me.XrChart_Chap_Maintenance_Pie_LastM.Legend.MaxVerticalPercentage = 50.0R
        Me.XrChart_Chap_Maintenance_Pie_LastM.Legend.Name = "Default Legend"
        Me.XrChart_Chap_Maintenance_Pie_LastM.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.XrChart_Chap_Maintenance_Pie_LastM.LocationFloat = New DevExpress.Utils.PointFloat(11.00045!, 0!)
        Me.XrChart_Chap_Maintenance_Pie_LastM.Name = "XrChart_Chap_Maintenance_Pie_LastM"
        Me.XrChart_Chap_Maintenance_Pie_LastM.PaletteName = "Green Red"
        Me.XrChart_Chap_Maintenance_Pie_LastM.PaletteRepository.Add("Green Red", New DevExpress.XtraCharts.Palette("Green Red", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Lime, System.Drawing.Color.Lime), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red)}))
        Series4.ArgumentDataMember = "LIB"
        Series4.ColorDataMember = "VCOLOR"
        PieSeriesLabel3.DXFont = New DevExpress.Drawing.DXFont("Century Gothic", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        PieSeriesLabel3.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel3.LineLength = 5
        PieSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel3.TextPattern = "{VP:0.00%}"
        Series4.Label = PieSeriesLabel3
        Series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series4.LegendTextPattern = "{A}"
        Series4.Name = "Series 1"
        Series4.ValueDataMembersSerializable = "TXREA"
        Series4.View = PieSeriesView3
        Me.XrChart_Chap_Maintenance_Pie_LastM.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series4}
        Me.XrChart_Chap_Maintenance_Pie_LastM.SeriesTemplate.ArgumentDataMember = "LIB"
        Me.XrChart_Chap_Maintenance_Pie_LastM.SeriesTemplate.ColorDataMember = "VCOLOR"
        Me.XrChart_Chap_Maintenance_Pie_LastM.SeriesTemplate.ValueDataMembersSerializable = "TXREA"
        Me.XrChart_Chap_Maintenance_Pie_LastM.SizeF = New System.Drawing.SizeF(227.0833!, 271.875!)
        Me.XrChart_Chap_Maintenance_Pie_LastM.StylePriority.UseBorderColor = False
        Me.XrChart_Chap_Maintenance_Pie_LastM.StylePriority.UseBorders = False
        Me.XrChart_Chap_Maintenance_Pie_LastM.StylePriority.UseBorderWidth = False
        ChartTitle4.DXFont = New DevExpress.Drawing.DXFont("Century Gothic", 10.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        ChartTitle4.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[False]
        ChartTitle4.Text = "Mois précédent"
        ChartTitle4.TextColor = System.Drawing.Color.Black
        Me.XrChart_Chap_Maintenance_Pie_LastM.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle4})
        '
        'P_DATE_DEBUT_PERIODE
        '
        Me.P_DATE_DEBUT_PERIODE.AllowNull = True
        Me.P_DATE_DEBUT_PERIODE.Description = "Date début de la période sélecrionnée"
        Me.P_DATE_DEBUT_PERIODE.Name = "P_DATE_DEBUT_PERIODE"
        Me.P_DATE_DEBUT_PERIODE.Type = GetType(Date)
        '
        'P_DATE_FIN_PERIODE
        '
        Me.P_DATE_FIN_PERIODE.AllowNull = True
        Me.P_DATE_FIN_PERIODE.Description = "Date fin de la période sélectionnée"
        Me.P_DATE_FIN_PERIODE.Name = "P_DATE_FIN_PERIODE"
        Me.P_DATE_FIN_PERIODE.Type = GetType(Date)
        '
        'P_DATE_DEBUT_ANNEE
        '
        Me.P_DATE_DEBUT_ANNEE.AllowNull = True
        Me.P_DATE_DEBUT_ANNEE.Description = "Date début de l'année"
        Me.P_DATE_DEBUT_ANNEE.Name = "P_DATE_DEBUT_ANNEE"
        Me.P_DATE_DEBUT_ANNEE.Type = GetType(Date)
        '
        'P_DATE_TODAY
        '
        Me.P_DATE_TODAY.AllowNull = True
        Me.P_DATE_TODAY.Description = "Date du jour"
        Me.P_DATE_TODAY.Name = "P_DATE_TODAY"
        Me.P_DATE_TODAY.Type = GetType(Date)
        '
        'P_DATE_DEBUT_LASTMONTH
        '
        Me.P_DATE_DEBUT_LASTMONTH.AllowNull = True
        Me.P_DATE_DEBUT_LASTMONTH.Description = "Date debut du dernier mois"
        Me.P_DATE_DEBUT_LASTMONTH.Name = "P_DATE_DEBUT_LASTMONTH"
        Me.P_DATE_DEBUT_LASTMONTH.Type = GetType(Date)
        '
        'P_DATE_FIN_LASTMONTH
        '
        Me.P_DATE_FIN_LASTMONTH.AllowNull = True
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
        'GroupFooter1
        '
        Me.GroupFooter1.HeightF = 0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XR_Page_Chap_Maintenance
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail_Chap_Maintenance, Me.TopMargin_Chap_Maintenance, Me.BottomMargin_Chap_Maintenance, Me.RH_Chap_Maintenance, Me.DR_Chap_Maintenance_Tab, Me.PageFooter_Chap_Maintenance, Me.DR_Chap_Maintenance_Graph, Me.DR_Chap_Maintenance_Pie, Me.GroupFooter1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SDS_CHap_Maintenance})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBoxBordersAllPage})
        Me.Margins = New DevExpress.Drawing.DXMargins(27.0!, 22.0!, 17.0!, 12.0!)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ParameterPanelLayoutItems.AddRange(New DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem() {New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.P_NCLINUM, DevExpress.XtraReports.Parameters.Orientation.Horizontal), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.P_VENSEIGNE, DevExpress.XtraReports.Parameters.Orientation.Horizontal), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.P_DATE_DEBUT_12M, DevExpress.XtraReports.Parameters.Orientation.Horizontal), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.P_DATE_FIN_12M, DevExpress.XtraReports.Parameters.Orientation.Horizontal), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.P_DATE_DEBUT_PERIODE, DevExpress.XtraReports.Parameters.Orientation.Horizontal), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.P_DATE_FIN_PERIODE, DevExpress.XtraReports.Parameters.Orientation.Horizontal), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.P_DATE_DEBUT_ANNEE, DevExpress.XtraReports.Parameters.Orientation.Horizontal), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.P_DATE_TODAY, DevExpress.XtraReports.Parameters.Orientation.Horizontal), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.P_DATE_DEBUT_LASTMONTH, DevExpress.XtraReports.Parameters.Orientation.Horizontal), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.P_DATE_FIN_LASTMONTH, DevExpress.XtraReports.Parameters.Orientation.Horizontal), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.P_LANGUE, DevExpress.XtraReports.Parameters.Orientation.Horizontal), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.P_NIDRAPPORT_FM_CLI, DevExpress.XtraReports.Parameters.Orientation.Horizontal)})
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.P_NCLINUM, Me.P_VENSEIGNE, Me.P_DATE_DEBUT_12M, Me.P_DATE_FIN_12M, Me.P_DATE_DEBUT_PERIODE, Me.P_DATE_FIN_PERIODE, Me.P_DATE_DEBUT_ANNEE, Me.P_DATE_TODAY, Me.P_DATE_DEBUT_LASTMONTH, Me.P_DATE_FIN_LASTMONTH, Me.P_LANGUE, Me.P_NIDRAPPORT_FM_CLI})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "22.2"
        CType(Me.XrTable_Data_Chap_Maintenance_Tab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable_Entete_Chap_Maintenance_Tab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChartMaintenancePrevGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart_Chap_Maintenance_Pie_Last12M, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart_Chap_Maintenance_Pie_Year, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart_Chap_Maintenance_Pie_LastM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail_Chap_Maintenance As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin_Chap_Maintenance As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin_Chap_Maintenance As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrCrossBandBoxBordersAllPage As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents RH_Chap_Maintenance As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents DR_Chap_Maintenance_Tab As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail_Chap_Maintenance_Tab As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLblMaintenanceTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents P_NCLINUM As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_VENSEIGNE As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_DATE_DEBUT_12M As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_DATE_FIN_12M As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PageFooter_Chap_Maintenance As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo_Chap_Maintenance As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents DR_Chap_Maintenance_Graph As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail_Chap_Maintenance_Graph As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents DR_Chap_Maintenance_Pie As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail_Chap_Maintenance_Pie As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents SDS_CHap_Maintenance As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents XrTable_Data_Chap_Maintenance_Tab As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow_Data_Chap_Maintenance_Tab As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XtTab_Data_VENSEIGNE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Data_VSITNOM As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Data_LOT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Data_NBPLA As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Data_NBEXE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Data_TXREA As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GH_Chap_Maintenance_Tab As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrChartMaintenancePrevGraph As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents XrTable_Entete_Chap_Maintenance_Tab As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow_Entete_Chap_Maintenance_Tab As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XtTab_Entete_VENSEIGNE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Entete_VSITNOM As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Entete_LOT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Entete_NBPLA As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Entete_NBEXE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Entete_TXREA As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents P_DATE_DEBUT_PERIODE As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_DATE_FIN_PERIODE As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_DATE_DEBUT_ANNEE As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_DATE_TODAY As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_DATE_DEBUT_LASTMONTH As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_DATE_FIN_LASTMONTH As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrChart_Chap_Maintenance_Pie_Last12M As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents XrChart_Chap_Maintenance_Pie_Year As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents XrChart_Chap_Maintenance_Pie_LastM As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents P_LANGUE As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_NIDRAPPORT_FM_CLI As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
End Class
