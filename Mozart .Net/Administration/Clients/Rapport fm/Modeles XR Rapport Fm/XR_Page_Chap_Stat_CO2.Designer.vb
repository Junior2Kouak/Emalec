<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XR_Page_Chap_Stat_CO2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XR_Page_Chap_Stat_CO2))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedBarSeriesView1 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedBarSeriesView2 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedBarSeriesView3 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim Series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedBarSeriesView4 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrCrossBandBoxBordersAllPage = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo_Chap_Maintenance = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLblStatCO2Title = New DevExpress.XtraReports.UI.XRLabel()
        Me.DR_Chap_StatCO2_Tableau = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail_Chap_StatCO2_Tab = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable_Data_Chap_Maintenance_Tab = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow_Data_Chap_Maintenance_Tab = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XtTab_Data_VENSEIGNE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Data_CO2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GH_Chap_StatCO2_Tab = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrTable_Entete_Chap_Maintenance_Tab = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow_Entete_Chap_Maintenance_Tab = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XtTab_Entete_VMOIS = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Entete_VVAL = New DevExpress.XtraReports.UI.XRTableCell()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.DR_Chap_StatCO2_Graph = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail_Stat_CO2_Graph = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrChartMaintenancePrevGraph = New DevExpress.XtraReports.UI.XRChart()
        Me.P_DATE_DEBUT_PERIODE = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_DATE_FIN_PERIODE = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_NCLINUM = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_NIDRAPPORT_FM_CLI = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_VSOCIETE = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.XrTable_Data_Chap_Maintenance_Tab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable_Entete_Chap_Maintenance_Tab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChartMaintenancePrevGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TopMargin.HeightF = 23.95833!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 26.74999!
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
        Me.XrCrossBandBoxBordersAllPage.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 12.16664!)
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLblStatCO2Title})
        Me.ReportHeader.HeightF = 23.95833!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLblStatCO2Title
        '
        Me.XrLblStatCO2Title.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblStatCO2Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrLblStatCO2Title.LocationFloat = New DevExpress.Utils.PointFloat(11.00032!, 0!)
        Me.XrLblStatCO2Title.Name = "XrLblStatCO2Title"
        Me.XrLblStatCO2Title.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblStatCO2Title.SizeF = New System.Drawing.SizeF(754.9998!, 23.0!)
        Me.XrLblStatCO2Title.StylePriority.UseFont = False
        Me.XrLblStatCO2Title.StylePriority.UseForeColor = False
        Me.XrLblStatCO2Title.Text = "Statistique d'émission de CO2 sur une période"
        '
        'DR_Chap_StatCO2_Tableau
        '
        Me.DR_Chap_StatCO2_Tableau.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail_Chap_StatCO2_Tab, Me.GH_Chap_StatCO2_Tab})
        Me.DR_Chap_StatCO2_Tableau.DataMember = "api_sp_Rapport_FM_Impression_StatEmalecCO2_Periode"
        Me.DR_Chap_StatCO2_Tableau.DataSource = Me.SqlDataSource1
        Me.DR_Chap_StatCO2_Tableau.Level = 0
        Me.DR_Chap_StatCO2_Tableau.Name = "DR_Chap_StatCO2_Tableau"
        '
        'Detail_Chap_StatCO2_Tab
        '
        Me.Detail_Chap_StatCO2_Tab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable_Data_Chap_Maintenance_Tab})
        Me.Detail_Chap_StatCO2_Tab.HeightF = 15.0!
        Me.Detail_Chap_StatCO2_Tab.Name = "Detail_Chap_StatCO2_Tab"
        '
        'XrTable_Data_Chap_Maintenance_Tab
        '
        Me.XrTable_Data_Chap_Maintenance_Tab.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTable_Data_Chap_Maintenance_Tab.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable_Data_Chap_Maintenance_Tab.BorderWidth = 0.5!
        Me.XrTable_Data_Chap_Maintenance_Tab.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable_Data_Chap_Maintenance_Tab.LocationFloat = New DevExpress.Utils.PointFloat(11.00045!, 0!)
        Me.XrTable_Data_Chap_Maintenance_Tab.Name = "XrTable_Data_Chap_Maintenance_Tab"
        Me.XrTable_Data_Chap_Maintenance_Tab.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow_Data_Chap_Maintenance_Tab})
        Me.XrTable_Data_Chap_Maintenance_Tab.SizeF = New System.Drawing.SizeF(363.6605!, 15.0!)
        Me.XrTable_Data_Chap_Maintenance_Tab.StylePriority.UseBorderColor = False
        Me.XrTable_Data_Chap_Maintenance_Tab.StylePriority.UseBorders = False
        Me.XrTable_Data_Chap_Maintenance_Tab.StylePriority.UseBorderWidth = False
        Me.XrTable_Data_Chap_Maintenance_Tab.StylePriority.UseFont = False
        Me.XrTable_Data_Chap_Maintenance_Tab.StylePriority.UseTextAlignment = False
        Me.XrTable_Data_Chap_Maintenance_Tab.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow_Data_Chap_Maintenance_Tab
        '
        Me.XrTableRow_Data_Chap_Maintenance_Tab.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XtTab_Data_VENSEIGNE, Me.XtTab_Data_CO2})
        Me.XrTableRow_Data_Chap_Maintenance_Tab.Name = "XrTableRow_Data_Chap_Maintenance_Tab"
        Me.XrTableRow_Data_Chap_Maintenance_Tab.Weight = 11.5R
        '
        'XtTab_Data_VENSEIGNE
        '
        Me.XtTab_Data_VENSEIGNE.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MOIS]")})
        Me.XtTab_Data_VENSEIGNE.Name = "XtTab_Data_VENSEIGNE"
        Me.XtTab_Data_VENSEIGNE.Text = "XtTab_Data_VMOIS"
        Me.XtTab_Data_VENSEIGNE.TextFormatString = "{0:MM/yyyy}"
        Me.XtTab_Data_VENSEIGNE.Weight = 0.74775221039635387R
        '
        'XtTab_Data_CO2
        '
        Me.XtTab_Data_CO2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CO2TOT]")})
        Me.XtTab_Data_CO2.Name = "XtTab_Data_CO2"
        Me.XtTab_Data_CO2.StylePriority.UseTextAlignment = False
        Me.XtTab_Data_CO2.Text = "XtTab_Data_VEMISSION_CO2"
        Me.XtTab_Data_CO2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XtTab_Data_CO2.Weight = 0.84986592372679826R
        '
        'GH_Chap_StatCO2_Tab
        '
        Me.GH_Chap_StatCO2_Tab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable_Entete_Chap_Maintenance_Tab})
        Me.GH_Chap_StatCO2_Tab.HeightF = 45.41667!
        Me.GH_Chap_StatCO2_Tab.Name = "GH_Chap_StatCO2_Tab"
        '
        'XrTable_Entete_Chap_Maintenance_Tab
        '
        Me.XrTable_Entete_Chap_Maintenance_Tab.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.XrTable_Entete_Chap_Maintenance_Tab.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTable_Entete_Chap_Maintenance_Tab.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable_Entete_Chap_Maintenance_Tab.BorderWidth = 0.5!
        Me.XrTable_Entete_Chap_Maintenance_Tab.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable_Entete_Chap_Maintenance_Tab.LocationFloat = New DevExpress.Utils.PointFloat(11.00041!, 9.999998!)
        Me.XrTable_Entete_Chap_Maintenance_Tab.Name = "XrTable_Entete_Chap_Maintenance_Tab"
        Me.XrTable_Entete_Chap_Maintenance_Tab.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow_Entete_Chap_Maintenance_Tab})
        Me.XrTable_Entete_Chap_Maintenance_Tab.SizeF = New System.Drawing.SizeF(363.6605!, 35.41667!)
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
        Me.XrTableRow_Entete_Chap_Maintenance_Tab.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XtTab_Entete_VMOIS, Me.XtTab_Entete_VVAL})
        Me.XrTableRow_Entete_Chap_Maintenance_Tab.Name = "XrTableRow_Entete_Chap_Maintenance_Tab"
        Me.XrTableRow_Entete_Chap_Maintenance_Tab.Weight = 1.0R
        '
        'XtTab_Entete_VMOIS
        '
        Me.XtTab_Entete_VMOIS.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XtTab_Entete_VMOIS.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtTab_Entete_VMOIS.ForeColor = System.Drawing.Color.White
        Me.XtTab_Entete_VMOIS.Name = "XtTab_Entete_VMOIS"
        Me.XtTab_Entete_VMOIS.StylePriority.UseBackColor = False
        Me.XtTab_Entete_VMOIS.StylePriority.UseFont = False
        Me.XtTab_Entete_VMOIS.StylePriority.UseForeColor = False
        Me.XtTab_Entete_VMOIS.StylePriority.UseTextAlignment = False
        Me.XtTab_Entete_VMOIS.Text = "Mois"
        Me.XtTab_Entete_VMOIS.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XtTab_Entete_VMOIS.Weight = 1.7020835575043278R
        '
        'XtTab_Entete_VVAL
        '
        Me.XtTab_Entete_VVAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XtTab_Entete_VVAL.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtTab_Entete_VVAL.ForeColor = System.Drawing.Color.White
        Me.XtTab_Entete_VVAL.Name = "XtTab_Entete_VVAL"
        Me.XtTab_Entete_VVAL.StylePriority.UseBackColor = False
        Me.XtTab_Entete_VVAL.StylePriority.UseFont = False
        Me.XtTab_Entete_VVAL.StylePriority.UseForeColor = False
        Me.XtTab_Entete_VVAL.Text = "CO2 (Kg)"
        Me.XtTab_Entete_VVAL.Weight = 1.9345210897327569R
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "localhost_MULTI_Connection"
        Me.SqlDataSource1.ConnectionOptions.DbCommandTimeout = 0
        MsSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows
        MsSqlConnectionParameters1.DatabaseName = "MULTI"
        MsSqlConnectionParameters1.ServerName = "SRV-VMSQLPROD"
        Me.SqlDataSource1.ConnectionParameters = MsSqlConnectionParameters1
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "api_sp_Rapport_FM_Impression_StatEmalecCO2_Periode"
        QueryParameter1.Name = "@dateDebut"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("?P_DATE_DEBUT_PERIODE", GetType(Date))
        QueryParameter2.Name = "@dateFin"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("?P_DATE_FIN_PERIODE", GetType(Date))
        QueryParameter3.Name = "@vSociete"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("?P_VSOCIETE", GetType(String))
        QueryParameter4.Name = "@p_nclinum"
        QueryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter4.Value = New DevExpress.DataAccess.Expression("?P_NCLINUM", GetType(Integer))
        QueryParameter5.Name = "@p_nidrapport_fm_cli"
        QueryParameter5.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter5.Value = New DevExpress.DataAccess.Expression("?P_NIDRAPPORT_FM_CLI", GetType(Integer))
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.Parameters.Add(QueryParameter3)
        StoredProcQuery1.Parameters.Add(QueryParameter4)
        StoredProcQuery1.Parameters.Add(QueryParameter5)
        StoredProcQuery1.StoredProcName = "api_sp_Rapport_FM_Impression_StatEmalecCO2_Periode"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'DR_Chap_StatCO2_Graph
        '
        Me.DR_Chap_StatCO2_Graph.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail_Stat_CO2_Graph})
        Me.DR_Chap_StatCO2_Graph.Level = 1
        Me.DR_Chap_StatCO2_Graph.Name = "DR_Chap_StatCO2_Graph"
        '
        'Detail_Stat_CO2_Graph
        '
        Me.Detail_Stat_CO2_Graph.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrChartMaintenancePrevGraph})
        Me.Detail_Stat_CO2_Graph.HeightF = 327.0833!
        Me.Detail_Stat_CO2_Graph.Name = "Detail_Stat_CO2_Graph"
        '
        'XrChartMaintenancePrevGraph
        '
        Me.XrChartMaintenancePrevGraph.BorderColor = System.Drawing.Color.Black
        Me.XrChartMaintenancePrevGraph.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrChartMaintenancePrevGraph.BorderWidth = 0.5!
        Me.XrChartMaintenancePrevGraph.DataMember = "api_sp_Rapport_FM_Impression_StatEmalecCO2_Periode"
        Me.XrChartMaintenancePrevGraph.DataSource = Me.SqlDataSource1
        XyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
        XyDiagram1.AxisX.Label.Angle = 90
        XyDiagram1.AxisX.Label.TextPattern = "{A:MM/yyyy}"
        XyDiagram1.AxisX.MinorCount = 1
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisX.WholeRange.AutoSideMargins = False
        XyDiagram1.AxisX.WholeRange.SideMarginsValue = 1.0R
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChartMaintenancePrevGraph.Diagram = XyDiagram1
        Me.XrChartMaintenancePrevGraph.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
        Me.XrChartMaintenancePrevGraph.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
        Me.XrChartMaintenancePrevGraph.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.XrChartMaintenancePrevGraph.Legend.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.XrChartMaintenancePrevGraph.Legend.Name = "Default Legend"
        Me.XrChartMaintenancePrevGraph.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.XrChartMaintenancePrevGraph.LocationFloat = New DevExpress.Utils.PointFloat(11.00045!, 10.00001!)
        Me.XrChartMaintenancePrevGraph.Name = "XrChartMaintenancePrevGraph"
        Series1.ArgumentDataMember = "MOIS"
        SideBySideBarSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series1.LegendTextPattern = "intervenants terrain"
        Series1.Name = "Series 1"
        Series1.ValueDataMembersSerializable = "CO2EI"
        Series2.ArgumentDataMember = "MOIS"
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series2.LegendTextPattern = "Personnel de bureau"
        Series2.Name = "Series 2"
        Series2.ValueDataMembersSerializable = "CO2EB"
        Series2.View = StackedBarSeriesView1
        Series3.ArgumentDataMember = "MOIS"
        Series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series3.LegendTextPattern = "Voyages d'affaires - avion et train"
        Series3.Name = "Series 3"
        Series3.ValueDataMembersSerializable = "CO2EV"
        Series3.View = StackedBarSeriesView2
        Series4.ArgumentDataMember = "MOIS"
        Series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series4.LegendTextPattern = "Consommation des batiments"
        Series4.Name = "Series 4"
        Series4.ValueDataMembersSerializable = "CO2ES"
        Series4.View = StackedBarSeriesView3
        Series5.ArgumentDataMember = "MOIS"
        Series5.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series5.LegendTextPattern = "Logistique"
        Series5.Name = "Series 5"
        Series5.ValueDataMembersSerializable = "CO2EL"
        Series5.View = StackedBarSeriesView4
        Me.XrChartMaintenancePrevGraph.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2, Series3, Series4, Series5}
        Me.XrChartMaintenancePrevGraph.SeriesTemplate.ArgumentDataMember = "MOIS"
        Me.XrChartMaintenancePrevGraph.SeriesTemplate.ValueDataMembersSerializable = "EMISSION_CO2"
        Me.XrChartMaintenancePrevGraph.SizeF = New System.Drawing.SizeF(754.9997!, 307.0834!)
        Me.XrChartMaintenancePrevGraph.StylePriority.UseBorderColor = False
        Me.XrChartMaintenancePrevGraph.StylePriority.UseBorders = False
        Me.XrChartMaintenancePrevGraph.StylePriority.UseBorderWidth = False
        ChartTitle1.Alignment = System.Drawing.StringAlignment.Near
        ChartTitle1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        ChartTitle1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle1.Text = "Quantité d'émission de CO2 (en Kg) par mois"
		ChartTitle1.TextColor = System.Drawing.Color.Black
        Me.XrChartMaintenancePrevGraph.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
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
        'P_NCLINUM
        '
        Me.P_NCLINUM.Description = "NCLINUM"
        Me.P_NCLINUM.Name = "P_NCLINUM"
        Me.P_NCLINUM.Type = GetType(Integer)
        Me.P_NCLINUM.ValueInfo = "0"
        '
        'P_NIDRAPPORT_FM_CLI
        '
        Me.P_NIDRAPPORT_FM_CLI.Description = "NIDRAPPORT_FM_CLI"
        Me.P_NIDRAPPORT_FM_CLI.Name = "P_NIDRAPPORT_FM_CLI"
        Me.P_NIDRAPPORT_FM_CLI.Type = GetType(Integer)
        Me.P_NIDRAPPORT_FM_CLI.ValueInfo = "0"
        '
        'P_VSOCIETE
        '
        Me.P_VSOCIETE.Description = "VSOCIETE"
        Me.P_VSOCIETE.Name = "P_VSOCIETE"
        Me.P_VSOCIETE.ValueInfo = "0"
        '
        'XR_Page_Chap_Stat_CO2
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.ReportHeader, Me.DR_Chap_StatCO2_Tableau, Me.DR_Chap_StatCO2_Graph})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBoxBordersAllPage})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 24, 27)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.P_DATE_DEBUT_PERIODE, Me.P_DATE_FIN_PERIODE, Me.P_NCLINUM, Me.P_NIDRAPPORT_FM_CLI, Me.P_VSOCIETE})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "18.2"
        CType(Me.XrTable_Data_Chap_Maintenance_Tab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable_Entete_Chap_Maintenance_Tab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChartMaintenancePrevGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
  Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
  Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
  Friend WithEvents XrCrossBandBoxBordersAllPage As DevExpress.XtraReports.UI.XRCrossBandBox
  Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
  Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
  Friend WithEvents XrPageInfo_Chap_Maintenance As DevExpress.XtraReports.UI.XRPageInfo
  Friend WithEvents XrLblStatCO2Title As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DR_Chap_StatCO2_Tableau As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail_Chap_StatCO2_Tab As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents DR_Chap_StatCO2_Graph As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail_Stat_CO2_Graph As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents GH_Chap_StatCO2_Tab As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrTable_Entete_Chap_Maintenance_Tab As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow_Entete_Chap_Maintenance_Tab As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XtTab_Entete_VMOIS As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Entete_VVAL As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable_Data_Chap_Maintenance_Tab As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow_Data_Chap_Maintenance_Tab As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XtTab_Data_VENSEIGNE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Data_CO2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrChartMaintenancePrevGraph As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents P_DATE_DEBUT_PERIODE As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_DATE_FIN_PERIODE As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_NCLINUM As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_NIDRAPPORT_FM_CLI As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_VSOCIETE As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
End Class
