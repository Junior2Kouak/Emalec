<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XR_Page_Chap_ListeSiteRapport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XR_Page_Chap_ListeSiteRapport))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrCrossBandBoxBordersAllPage = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo_Chap_Maintenance = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable21 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow22 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell242 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell243 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell244 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell245 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell246 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable20 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow21 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell235 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell236 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell237 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell238 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell239 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportHeader1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLblTitreListeSites = New DevExpress.XtraReports.UI.XRLabel()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.P_NIDRAPPORT_FM_CLI = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.XrTable21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable20, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TopMargin.HeightF = 18.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 21.0!
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
        Me.XrCrossBandBoxBordersAllPage.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 6.41666!)
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
        Me.ReportHeader.HeightF = 0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.GroupHeader1, Me.ReportHeader1})
        Me.DetailReport.DataMember = "api_sp_Rapport_FM_Impression_ListeSitesRapport"
        Me.DetailReport.DataSource = Me.SqlDataSource1
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable21})
        Me.Detail1.HeightF = 15.0!
        Me.Detail1.Name = "Detail1"
        '
        'XrTable21
        '
        Me.XrTable21.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTable21.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable21.BorderWidth = 0.5!
        Me.XrTable21.Font = New System.Drawing.Font("Century Gothic", 7.25!)
        Me.XrTable21.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 0!)
        Me.XrTable21.Name = "XrTable21"
        Me.XrTable21.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow22})
        Me.XrTable21.SizeF = New System.Drawing.SizeF(759.3751!, 15.0!)
        Me.XrTable21.StylePriority.UseBorderColor = False
        Me.XrTable21.StylePriority.UseBorders = False
        Me.XrTable21.StylePriority.UseBorderWidth = False
        Me.XrTable21.StylePriority.UseFont = False
        Me.XrTable21.StylePriority.UseTextAlignment = False
        Me.XrTable21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow22
        '
        Me.XrTableRow22.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell242, Me.XrTableCell243, Me.XrTableCell244, Me.XrTableCell245, Me.XrTableCell246})
        Me.XrTableRow22.Name = "XrTableRow22"
        Me.XrTableRow22.Weight = 11.5R
        '
        'XrTableCell242
        '
        Me.XrTableCell242.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VSITNOM]")})
        Me.XrTableCell242.Name = "XrTableCell242"
        Me.XrTableCell242.Text = "XrTableCell242"
        Me.XrTableCell242.Weight = 2.7776689262075021R
        '
        'XrTableCell243
        '
        Me.XrTableCell243.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NSITNUE]")})
        Me.XrTableCell243.Name = "XrTableCell243"
        Me.XrTableCell243.Text = "XrTableCell243"
        Me.XrTableCell243.Weight = 0.88875868016969939R
        '
        'XrTableCell244
        '
        Me.XrTableCell244.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VSITENSEIGNE]")})
        Me.XrTableCell244.Name = "XrTableCell244"
        Me.XrTableCell244.Text = "XrTableCell244"
        Me.XrTableCell244.Weight = 1.8684705636562431R
        '
        'XrTableCell245
        '
        Me.XrTableCell245.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VSITVIL]")})
        Me.XrTableCell245.Name = "XrTableCell245"
        Me.XrTableCell245.Text = "XrTableCell245"
        Me.XrTableCell245.Weight = 1.6608663717751406R
        '
        'XrTableCell246
        '
        Me.XrTableCell246.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VSITPAYS]")})
        Me.XrTableCell246.Name = "XrTableCell246"
        Me.XrTableCell246.StylePriority.UseTextAlignment = False
        Me.XrTableCell246.Text = "XrTableCell246"
        Me.XrTableCell246.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell246.Weight = 1.9493977690080802R
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable20})
        Me.GroupHeader1.HeightF = 61.45837!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = True
        '
        'XrTable20
        '
        Me.XrTable20.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.XrTable20.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTable20.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable20.BorderWidth = 0.5!
        Me.XrTable20.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable20.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 9.999997!)
        Me.XrTable20.Name = "XrTable20"
        Me.XrTable20.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow21})
        Me.XrTable20.SizeF = New System.Drawing.SizeF(759.3751!, 51.45837!)
        Me.XrTable20.StylePriority.UseBackColor = False
        Me.XrTable20.StylePriority.UseBorderColor = False
        Me.XrTable20.StylePriority.UseBorders = False
        Me.XrTable20.StylePriority.UseBorderWidth = False
        Me.XrTable20.StylePriority.UseFont = False
        Me.XrTable20.StylePriority.UseTextAlignment = False
        Me.XrTable20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow21
        '
        Me.XrTableRow21.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell235, Me.XrTableCell236, Me.XrTableCell237, Me.XrTableCell238, Me.XrTableCell239})
        Me.XrTableRow21.Name = "XrTableRow21"
        Me.XrTableRow21.Weight = 1.0R
        '
        'XrTableCell235
        '
        Me.XrTableCell235.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell235.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell235.ForeColor = System.Drawing.Color.White
        Me.XrTableCell235.Name = "XrTableCell235"
        Me.XrTableCell235.StylePriority.UseBackColor = False
        Me.XrTableCell235.StylePriority.UseFont = False
        Me.XrTableCell235.StylePriority.UseForeColor = False
        Me.XrTableCell235.StylePriority.UseTextAlignment = False
        Me.XrTableCell235.Text = "Site"
        Me.XrTableCell235.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell235.Weight = 2.3064573242931434R
        '
        'XrTableCell236
        '
        Me.XrTableCell236.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell236.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell236.ForeColor = System.Drawing.Color.White
        Me.XrTableCell236.Name = "XrTableCell236"
        Me.XrTableCell236.StylePriority.UseBackColor = False
        Me.XrTableCell236.StylePriority.UseFont = False
        Me.XrTableCell236.StylePriority.UseForeColor = False
        Me.XrTableCell236.Text = "N° Site"
        Me.XrTableCell236.Weight = 0.73798674014498777R
        '
        'XrTableCell237
        '
        Me.XrTableCell237.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell237.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell237.ForeColor = System.Drawing.Color.White
        Me.XrTableCell237.Name = "XrTableCell237"
        Me.XrTableCell237.StylePriority.UseBackColor = False
        Me.XrTableCell237.StylePriority.UseFont = False
        Me.XrTableCell237.StylePriority.UseForeColor = False
        Me.XrTableCell237.Text = "Enseigne"
        Me.XrTableCell237.Weight = 1.5514974807614979R
        '
        'XrTableCell238
        '
        Me.XrTableCell238.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell238.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell238.ForeColor = System.Drawing.Color.White
        Me.XrTableCell238.Name = "XrTableCell238"
        Me.XrTableCell238.StylePriority.UseBackColor = False
        Me.XrTableCell238.StylePriority.UseFont = False
        Me.XrTableCell238.StylePriority.UseForeColor = False
        Me.XrTableCell238.Text = "Ville"
        Me.XrTableCell238.Weight = 1.3791125107983797R
        '
        'XrTableCell239
        '
        Me.XrTableCell239.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell239.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell239.ForeColor = System.Drawing.Color.White
        Me.XrTableCell239.Name = "XrTableCell239"
        Me.XrTableCell239.StylePriority.UseBackColor = False
        Me.XrTableCell239.StylePriority.UseFont = False
        Me.XrTableCell239.StylePriority.UseForeColor = False
        Me.XrTableCell239.Text = "Pays"
        Me.XrTableCell239.Weight = 1.6186962349260949R
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLblTitreListeSites})
        Me.ReportHeader1.HeightF = 23.0!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'XrLabel1
        '
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount([VSITNOM])")})
        Me.XrLabel1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(143.6248!, 0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(294.0944!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel1.Summary = XrSummary1
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel1.TextFormatString = "{0} site(s) sélectionné(s)"
        '
        'XrLblTitreListeSites
        '
        Me.XrLblTitreListeSites.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblTitreListeSites.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrLblTitreListeSites.LocationFloat = New DevExpress.Utils.PointFloat(10.50008!, 0!)
        Me.XrLblTitreListeSites.Name = "XrLblTitreListeSites"
        Me.XrLblTitreListeSites.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblTitreListeSites.SizeF = New System.Drawing.SizeF(133.1248!, 23.0!)
        Me.XrLblTitreListeSites.StylePriority.UseFont = False
        Me.XrLblTitreListeSites.StylePriority.UseForeColor = False
        Me.XrLblTitreListeSites.StylePriority.UseTextAlignment = False
        Me.XrLblTitreListeSites.Text = "Liste des sites :"
        Me.XrLblTitreListeSites.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
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
        StoredProcQuery1.Name = "api_sp_Rapport_FM_Impression_ListeSitesRapport"
        QueryParameter1.Name = "@p_nidrapport_fm_cli"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("?P_NIDRAPPORT_FM_CLI", GetType(Integer))
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.StoredProcName = "api_sp_Rapport_FM_Impression_ListeSitesRapport"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'P_NIDRAPPORT_FM_CLI
        '
        Me.P_NIDRAPPORT_FM_CLI.Description = "NIDRAPPORT_FM_CLI"
        Me.P_NIDRAPPORT_FM_CLI.Name = "P_NIDRAPPORT_FM_CLI"
        Me.P_NIDRAPPORT_FM_CLI.Type = GetType(Integer)
        Me.P_NIDRAPPORT_FM_CLI.ValueInfo = "0"
        '
        'XR_Page_Chap_ListeSiteRapport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.ReportHeader, Me.DetailReport})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBoxBordersAllPage})
        Me.Margins = New System.Drawing.Printing.Margins(25, 26, 18, 21)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.P_NIDRAPPORT_FM_CLI})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "18.2"
        CType(Me.XrTable21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrCrossBandBoxBordersAllPage As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrPageInfo_Chap_Maintenance As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable21 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow22 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell242 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell243 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell244 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell245 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell246 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable20 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow21 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell235 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell236 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell237 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell238 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell239 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents P_NIDRAPPORT_FM_CLI As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ReportHeader1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLblTitreListeSites As DevExpress.XtraReports.UI.XRLabel
End Class
