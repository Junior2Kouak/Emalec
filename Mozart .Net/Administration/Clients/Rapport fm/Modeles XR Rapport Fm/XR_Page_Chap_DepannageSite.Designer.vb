<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XR_Page_Chap_DepannageSite
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
        Dim StoredProcQuery2 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter5 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter6 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter7 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter8 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim StoredProcQuery3 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter9 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter10 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter11 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter12 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XR_Page_Chap_DepannageSite))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.Detail_Chap_Devis = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin_Chap_Devis = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin_Chap_Devis = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrCrossBandBoxBordersAllPage = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.PageFooter_Chap_Devis = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo_Chap_Maintenance = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.SDS_Chap_DepannageSite = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
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
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrChartLDRGraphNB = New DevExpress.XtraReports.UI.XRChart()
        Me.DetailReport1 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DetailReport3 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail3 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportHeader2 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrTableLDREntete = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRowLDREntete = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCellLDREntete_VSITENSEIGNE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCellLDREntete_VSITNOM = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCellLDREntete_DELAIEXE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.DetailReport2 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail2 = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeader1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DetailReport4 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail4 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportHeader3 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.XrChartLDRGraphNB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTableLDREntete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XrPageInfo_Chap_Maintenance.Font = New DevExpress.Drawing.DXFont("Century Gothic", 9.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrPageInfo_Chap_Maintenance.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPageInfo_Chap_Maintenance.Name = "XrPageInfo_Chap_Maintenance"
        Me.XrPageInfo_Chap_Maintenance.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo_Chap_Maintenance.SizeF = New System.Drawing.SizeF(772.9167!, 23.0!)
        Me.XrPageInfo_Chap_Maintenance.StylePriority.UseFont = False
        Me.XrPageInfo_Chap_Maintenance.StylePriority.UseTextAlignment = False
        Me.XrPageInfo_Chap_Maintenance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'SDS_Chap_DepannageSite
        '
        Me.SDS_Chap_DepannageSite.ConnectionName = "SRV-VMSQLPROD_MULTI_Connection 1"
        Me.SDS_Chap_DepannageSite.ConnectionOptions.DbCommandTimeout = 0
        MsSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows
        MsSqlConnectionParameters1.DatabaseName = "MULTI"
        MsSqlConnectionParameters1.ServerName = "SRV-VMSQLPROD"
        Me.SDS_Chap_DepannageSite.ConnectionParameters = MsSqlConnectionParameters1
        Me.SDS_Chap_DepannageSite.Name = "SDS_Chap_DepannageSite"
        StoredProcQuery1.Name = "api_sp_Rapport_FM_Impression_DepannageSite_Graph"
        QueryParameter1.Name = "@p_nclinum"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("?P_NCLINUM", GetType(Integer))
        QueryParameter2.Name = "@p_datedebut"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("?P_DATE_DEBUT_12M", GetType(Date))
        QueryParameter3.Name = "@p_datefin"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("?P_DATE_FIN_12M", GetType(Date))
        QueryParameter4.Name = "@p_nidrapport_fm_cli"
        QueryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter4.Value = New DevExpress.DataAccess.Expression("?P_NIDRAPPORT_FM_CLI", GetType(Integer))
        StoredProcQuery1.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter1, QueryParameter2, QueryParameter3, QueryParameter4})
        StoredProcQuery1.StoredProcName = "api_sp_Rapport_FM_Impression_DepannageSite_Graph"
        StoredProcQuery2.Name = "api_sp_Rapport_FM_Impression_DepannageSite_TOP_BY_MTT"
        QueryParameter5.Name = "@p_nclinum"
        QueryParameter5.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter5.Value = New DevExpress.DataAccess.Expression("?P_NCLINUM", GetType(Integer))
        QueryParameter6.Name = "@p_datedebut"
        QueryParameter6.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter6.Value = New DevExpress.DataAccess.Expression("?P_DATE_DEBUT_12M", GetType(Date))
        QueryParameter7.Name = "@p_datefin"
        QueryParameter7.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter7.Value = New DevExpress.DataAccess.Expression("?P_DATE_FIN_12M", GetType(Date))
        QueryParameter8.Name = "@p_nidrapport_fm_cli"
        QueryParameter8.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter8.Value = New DevExpress.DataAccess.Expression("?P_NIDRAPPORT_FM_CLI", GetType(Integer))
        StoredProcQuery2.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter5, QueryParameter6, QueryParameter7, QueryParameter8})
        StoredProcQuery2.StoredProcName = "api_sp_Rapport_FM_Impression_DepannageSite_TOP_BY_MTT"
        StoredProcQuery3.Name = "api_sp_Rapport_FM_Impression_DepannageSite_TOP_BY_NB"
        QueryParameter9.Name = "@p_nclinum"
        QueryParameter9.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter9.Value = New DevExpress.DataAccess.Expression("?P_NCLINUM", GetType(Integer))
        QueryParameter10.Name = "@p_datedebut"
        QueryParameter10.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter10.Value = New DevExpress.DataAccess.Expression("?P_DATE_DEBUT_12M", GetType(Date))
        QueryParameter11.Name = "@p_datefin"
        QueryParameter11.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter11.Value = New DevExpress.DataAccess.Expression("?P_DATE_FIN_12M", GetType(Date))
        QueryParameter12.Name = "@p_nidrapport_fm_cli"
        QueryParameter12.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter12.Value = New DevExpress.DataAccess.Expression("?P_NIDRAPPORT_FM_CLI", GetType(Integer))
        StoredProcQuery3.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter9, QueryParameter10, QueryParameter11, QueryParameter12})
        StoredProcQuery3.StoredProcName = "api_sp_Rapport_FM_Impression_DepannageSite_TOP_BY_NB"
        Me.SDS_Chap_DepannageSite.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1, StoredProcQuery2, StoredProcQuery3})
        Me.SDS_Chap_DepannageSite.ResultSchemaSerializable = resources.GetString("SDS_Chap_DepannageSite.ResultSchemaSerializable")
        '
        'RH_Chap_Devis
        '
        Me.RH_Chap_Devis.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLblTitreDevisAttenteDec})
        Me.RH_Chap_Devis.HeightF = 24.45834!
        Me.RH_Chap_Devis.Name = "RH_Chap_Devis"
        '
        'XrLblTitreDevisAttenteDec
        '
        Me.XrLblTitreDevisAttenteDec.Font = New DevExpress.Drawing.DXFont("Century Gothic", 10.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLblTitreDevisAttenteDec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrLblTitreDevisAttenteDec.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 0!)
        Me.XrLblTitreDevisAttenteDec.Name = "XrLblTitreDevisAttenteDec"
        Me.XrLblTitreDevisAttenteDec.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblTitreDevisAttenteDec.SizeF = New System.Drawing.SizeF(754.9998!, 24.45834!)
        Me.XrLblTitreDevisAttenteDec.StylePriority.UseFont = False
        Me.XrLblTitreDevisAttenteDec.StylePriority.UseForeColor = False
        Me.XrLblTitreDevisAttenteDec.Text = "Nombre de dépannages par site"
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
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrChartLDRGraphNB})
        Me.Detail.HeightF = 202.0416!
        Me.Detail.Name = "Detail"
        '
        'XrChartLDRGraphNB
        '
        Me.XrChartLDRGraphNB.BorderColor = System.Drawing.Color.Black
        Me.XrChartLDRGraphNB.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrChartLDRGraphNB.BorderWidth = 0.5!
        Me.XrChartLDRGraphNB.DataMember = "api_sp_Rapport_FM_Impression_DepannageSite_Graph"
        Me.XrChartLDRGraphNB.DataSource = Me.SDS_Chap_DepannageSite
        XyDiagram1.AxisX.Label.Angle = 90
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChartLDRGraphNB.Diagram = XyDiagram1
        Me.XrChartLDRGraphNB.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.XrChartLDRGraphNB.Legend.Name = "Default Legend"
        Me.XrChartLDRGraphNB.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChartLDRGraphNB.LocationFloat = New DevExpress.Utils.PointFloat(13.0004!, 10.00001!)
        Me.XrChartLDRGraphNB.Name = "XrChartLDRGraphNB"
        Series1.ArgumentDataMember = "AXE_X_LIB"
        SideBySideBarSeriesLabel1.DXFont = New DevExpress.Drawing.DXFont("Century Gothic", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        SideBySideBarSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series1.Name = "Series 1"
        Series1.ValueDataMembersSerializable = "MOY_DEP_BY_SITE"
        Me.XrChartLDRGraphNB.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.XrChartLDRGraphNB.SizeF = New System.Drawing.SizeF(754.9996!, 178.125!)
        Me.XrChartLDRGraphNB.StylePriority.UseBorderColor = False
        Me.XrChartLDRGraphNB.StylePriority.UseBorders = False
        Me.XrChartLDRGraphNB.StylePriority.UseBorderWidth = False
        ChartTitle1.Alignment = System.Drawing.StringAlignment.Near
        ChartTitle1.DXFont = New DevExpress.Drawing.DXFont("Century Gothic", 10.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        ChartTitle1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        ChartTitle1.Text = "Nombre d'interventions en dépannage par site / nombre de site total"
        ChartTitle1.TextColor = System.Drawing.Color.Black
        ChartTitle1.WordWrap = True
        Me.XrChartLDRGraphNB.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'DetailReport1
        '
        Me.DetailReport1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.ReportHeader, Me.DetailReport3})
        Me.DetailReport1.Level = 1
        Me.DetailReport1.Name = "DetailReport1"
        '
        'Detail1
        '
        Me.Detail1.HeightF = 0!
        Me.Detail1.Name = "Detail1"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.ReportHeader.HeightF = 24.45834!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Century Gothic", 10.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(754.9998!, 24.45834!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.Text = "Dépannage - Top 10 des sites par montant sur les 12 derniers mois"
        '
        'DetailReport3
        '
        Me.DetailReport3.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail3, Me.ReportHeader2})
        Me.DetailReport3.DataMember = "api_sp_Rapport_FM_Impression_DepannageSite_TOP_BY_MTT"
        Me.DetailReport3.DataSource = Me.SDS_Chap_DepannageSite
        Me.DetailReport3.Level = 0
        Me.DetailReport3.Name = "DetailReport3"
        '
        'Detail3
        '
        Me.Detail3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail3.HeightF = 25.0!
        Me.Detail3.Name = "Detail3"
        '
        'XrTable2
        '
        Me.XrTable2.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTable2.Font = New DevExpress.Drawing.DXFont("Century Gothic", 9.0!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(13.00043!, 0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(596.6661!, 25.0!)
        Me.XrTable2.StylePriority.UseBorderColor = False
        Me.XrTable2.StylePriority.UseFont = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 11.5R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VSITNOM]")})
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTableCell4.StylePriority.UseBorders = False
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "XrTableCell4"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell4.Weight = 0.20285222118285079R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MTT]")})
        Me.XrTableCell5.Multiline = True
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTableCell5.StylePriority.UseBorders = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "XrTableCell5"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell5.Weight = 0.11226608795491966R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NB_DEP]")})
        Me.XrTableCell6.Multiline = True
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.Text = "XrTableCell6"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell6.Weight = 0.16621410365236539R
        '
        'ReportHeader2
        '
        Me.ReportHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTableLDREntete})
        Me.ReportHeader2.HeightF = 61.45834!
        Me.ReportHeader2.Name = "ReportHeader2"
        '
        'XrTableLDREntete
        '
        Me.XrTableLDREntete.BackColor = System.Drawing.Color.DarkGray
        Me.XrTableLDREntete.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTableLDREntete.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableLDREntete.BorderWidth = 0.5!
        Me.XrTableLDREntete.Font = New DevExpress.Drawing.DXFont("Century Gothic", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableLDREntete.LocationFloat = New DevExpress.Utils.PointFloat(13.0004!, 9.999974!)
        Me.XrTableLDREntete.Name = "XrTableLDREntete"
        Me.XrTableLDREntete.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRowLDREntete})
        Me.XrTableLDREntete.SizeF = New System.Drawing.SizeF(596.6661!, 51.45837!)
        Me.XrTableLDREntete.StylePriority.UseBackColor = False
        Me.XrTableLDREntete.StylePriority.UseBorderColor = False
        Me.XrTableLDREntete.StylePriority.UseBorders = False
        Me.XrTableLDREntete.StylePriority.UseBorderWidth = False
        Me.XrTableLDREntete.StylePriority.UseFont = False
        Me.XrTableLDREntete.StylePriority.UseTextAlignment = False
        Me.XrTableLDREntete.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRowLDREntete
        '
        Me.XrTableRowLDREntete.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCellLDREntete_VSITENSEIGNE, Me.XrTableCellLDREntete_VSITNOM, Me.XrTableCellLDREntete_DELAIEXE})
        Me.XrTableRowLDREntete.Name = "XrTableRowLDREntete"
        Me.XrTableRowLDREntete.Weight = 1.0R
        '
        'XrTableCellLDREntete_VSITENSEIGNE
        '
        Me.XrTableCellLDREntete_VSITENSEIGNE.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCellLDREntete_VSITENSEIGNE.Font = New DevExpress.Drawing.DXFont("Century Gothic", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCellLDREntete_VSITENSEIGNE.ForeColor = System.Drawing.Color.White
        Me.XrTableCellLDREntete_VSITENSEIGNE.Name = "XrTableCellLDREntete_VSITENSEIGNE"
        Me.XrTableCellLDREntete_VSITENSEIGNE.StylePriority.UseBackColor = False
        Me.XrTableCellLDREntete_VSITENSEIGNE.StylePriority.UseFont = False
        Me.XrTableCellLDREntete_VSITENSEIGNE.StylePriority.UseForeColor = False
        Me.XrTableCellLDREntete_VSITENSEIGNE.StylePriority.UseTextAlignment = False
        Me.XrTableCellLDREntete_VSITENSEIGNE.Text = "Site"
        Me.XrTableCellLDREntete_VSITENSEIGNE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCellLDREntete_VSITENSEIGNE.Weight = 2.5145835674737302R
        '
        'XrTableCellLDREntete_VSITNOM
        '
        Me.XrTableCellLDREntete_VSITNOM.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCellLDREntete_VSITNOM.Font = New DevExpress.Drawing.DXFont("Century Gothic", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCellLDREntete_VSITNOM.ForeColor = System.Drawing.Color.White
        Me.XrTableCellLDREntete_VSITNOM.Name = "XrTableCellLDREntete_VSITNOM"
        Me.XrTableCellLDREntete_VSITNOM.StylePriority.UseBackColor = False
        Me.XrTableCellLDREntete_VSITNOM.StylePriority.UseFont = False
        Me.XrTableCellLDREntete_VSITNOM.StylePriority.UseForeColor = False
        Me.XrTableCellLDREntete_VSITNOM.Text = "Montant"
        Me.XrTableCellLDREntete_VSITNOM.Weight = 1.3916644889266312R
        '
        'XrTableCellLDREntete_DELAIEXE
        '
        Me.XrTableCellLDREntete_DELAIEXE.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCellLDREntete_DELAIEXE.Font = New DevExpress.Drawing.DXFont("Century Gothic", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCellLDREntete_DELAIEXE.ForeColor = System.Drawing.Color.White
        Me.XrTableCellLDREntete_DELAIEXE.Name = "XrTableCellLDREntete_DELAIEXE"
        Me.XrTableCellLDREntete_DELAIEXE.StylePriority.UseBackColor = False
        Me.XrTableCellLDREntete_DELAIEXE.StylePriority.UseFont = False
        Me.XrTableCellLDREntete_DELAIEXE.StylePriority.UseForeColor = False
        Me.XrTableCellLDREntete_DELAIEXE.Text = "Nombre d'interventions"
        Me.XrTableCellLDREntete_DELAIEXE.Weight = 2.0604129262584157R
        '
        'DetailReport2
        '
        Me.DetailReport2.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail2, Me.ReportHeader1, Me.DetailReport4})
        Me.DetailReport2.Level = 2
        Me.DetailReport2.Name = "DetailReport2"
        '
        'Detail2
        '
        Me.Detail2.HeightF = 0!
        Me.Detail2.Name = "Detail2"
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2})
        Me.ReportHeader1.HeightF = 35.7269!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Century Gothic", 10.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 10.00002!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(754.9998!, 24.45834!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.Text = "Dépannage - Top 10 des sites par nombre sur les 12 derniers mois"
        '
        'DetailReport4
        '
        Me.DetailReport4.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail4, Me.ReportHeader3})
        Me.DetailReport4.DataMember = "api_sp_Rapport_FM_Impression_DepannageSite_TOP_BY_NB"
        Me.DetailReport4.DataSource = Me.SDS_Chap_DepannageSite
        Me.DetailReport4.Level = 0
        Me.DetailReport4.Name = "DetailReport4"
        '
        'Detail4
        '
        Me.Detail4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.Detail4.HeightF = 25.0!
        Me.Detail4.Name = "Detail4"
        '
        'XrTable3
        '
        Me.XrTable3.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.Font = New DevExpress.Drawing.DXFont("Century Gothic", 9.0!)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(13.00043!, 0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(596.6661!, 25.0!)
        Me.XrTable3.StylePriority.UseBorderColor = False
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 11.5R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VSITNOM]")})
        Me.XrTableCell7.Multiline = True
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTableCell7.Text = "XrTableCell7"
        Me.XrTableCell7.Weight = 0.20285222118285079R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NB_DEP]")})
        Me.XrTableCell8.Multiline = True
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "XrTableCell8"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell8.Weight = 0.14755935144568561R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MTT]")})
        Me.XrTableCell9.Multiline = True
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "XrTableCell9"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell9.Weight = 0.13092084016159944R
        '
        'ReportHeader3
        '
        Me.ReportHeader3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.ReportHeader3.HeightF = 61.45837!
        Me.ReportHeader3.Name = "ReportHeader3"
        '
        'XrTable1
        '
        Me.XrTable1.BackColor = System.Drawing.Color.DarkGray
        Me.XrTable1.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.BorderWidth = 0.5!
        Me.XrTable1.Font = New DevExpress.Drawing.DXFont("Century Gothic", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(13.0004!, 9.999974!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(596.6661!, 51.45837!)
        Me.XrTable1.StylePriority.UseBackColor = False
        Me.XrTable1.StylePriority.UseBorderColor = False
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseBorderWidth = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell1.Font = New DevExpress.Drawing.DXFont("Century Gothic", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell1.ForeColor = System.Drawing.Color.White
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBackColor = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseForeColor = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "Site"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell1.Weight = 2.5145835674737302R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell2.Font = New DevExpress.Drawing.DXFont("Century Gothic", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell2.ForeColor = System.Drawing.Color.White
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBackColor = False
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseForeColor = False
        Me.XrTableCell2.Text = "Nombre d'interventions"
        Me.XrTableCell2.Weight = 1.829164460015358R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell3.Font = New DevExpress.Drawing.DXFont("Century Gothic", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell3.ForeColor = System.Drawing.Color.White
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBackColor = False
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseForeColor = False
        Me.XrTableCell3.Text = "Montant"
        Me.XrTableCell3.Weight = 1.6229129551696888R
        '
        'XR_Page_Chap_DepannageSite
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail_Chap_Devis, Me.TopMargin_Chap_Devis, Me.BottomMargin_Chap_Devis, Me.PageFooter_Chap_Devis, Me.RH_Chap_Devis, Me.DetailReport, Me.DetailReport1, Me.DetailReport2})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SDS_Chap_DepannageSite})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBoxBordersAllPage})
        Me.Margins = New DevExpress.Drawing.DXMargins(23.0!, 26.0!, 24.0!, 20.0!)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.P_NCLINUM, Me.P_VENSEIGNE, Me.P_DATE_DEBUT_12M, Me.P_DATE_FIN_12M, Me.P_DATE_DEBUT_PERIODE, Me.P_DATE_FIN_PERIODE, Me.P_DATE_DEBUT_ANNEE, Me.P_DATE_TODAY, Me.P_DATE_DEBUT_LASTMONTH, Me.P_DATE_FIN_LASTMONTH, Me.P_LANGUE, Me.P_NIDRAPPORT_FM_CLI})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "22.2"
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChartLDRGraphNB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTableLDREntete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail_Chap_Devis As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin_Chap_Devis As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin_Chap_Devis As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrCrossBandBoxBordersAllPage As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents PageFooter_Chap_Devis As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo_Chap_Maintenance As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents RH_Chap_Devis As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLblTitreDevisAttenteDec As DevExpress.XtraReports.UI.XRLabel
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
    Friend WithEvents SDS_Chap_DepannageSite As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents P_NIDRAPPORT_FM_CLI As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents DetailReport1 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents XrChartLDRGraphNB As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents DetailReport2 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail2 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeader1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DetailReport3 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail3 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeader2 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrTableLDREntete As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRowLDREntete As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCellLDREntete_VSITENSEIGNE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCellLDREntete_VSITNOM As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCellLDREntete_DELAIEXE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents DetailReport4 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail4 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeader3 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
End Class
