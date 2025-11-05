<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XR_Page_Chap_SEMMARIS_StatFact
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
        Dim StoredProcQuery2 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter4 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter5 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter6 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XR_Page_Chap_SEMMARIS_StatFact))
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrCrossBandBoxBordersAllPage = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo_Chap_Maintenance = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
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
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPivotGrid3 = New DevExpress.XtraReports.UI.XRPivotGrid()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.XrPivotGridField9 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.XrPivotGridField10 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.XrPivotGridField11 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.XrPivotGridField12 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid()
        Me.XrPivotGridField5 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.XrPivotGridField6 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.XrPivotGridField7 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.XrPivotGridField8 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.XrLblTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPivotGrid2 = New DevExpress.XtraReports.UI.XRPivotGrid()
        Me.XrPivotGridField1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.XrPivotGridField2 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.XrPivotGridField3 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.XrPivotGridField4 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.DetailReport1 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail2 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrStyleCellTotal = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrStyleHeaderBlue = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrStyleHeaderGdTot = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrChart1 = New DevExpress.XtraReports.UI.XRChart()
        Me.XrChart2 = New DevExpress.XtraReports.UI.XRChart()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 17.70833!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.HeightF = 13.63894!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrCrossBandBoxBordersAllPage
        '
        Me.XrCrossBandBoxBordersAllPage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrCrossBandBoxBordersAllPage.BorderWidth = 1.0!
        Me.XrCrossBandBoxBordersAllPage.Dpi = 100.0!
        Me.XrCrossBandBoxBordersAllPage.EndBand = Me.BottomMargin
        Me.XrCrossBandBoxBordersAllPage.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 5.305607!)
        Me.XrCrossBandBoxBordersAllPage.LocationFloat = New DevExpress.Utils.PointFloat(0!, 8.333332!)
        Me.XrCrossBandBoxBordersAllPage.Name = "XrCrossBandBoxBordersAllPage"
        Me.XrCrossBandBoxBordersAllPage.StartBand = Me.TopMargin
        Me.XrCrossBandBoxBordersAllPage.StartPointFloat = New DevExpress.Utils.PointFloat(0!, 8.333332!)
        Me.XrCrossBandBoxBordersAllPage.WidthF = 1119.792!
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
        Me.XrPageInfo_Chap_Maintenance.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPageInfo_Chap_Maintenance.Name = "XrPageInfo_Chap_Maintenance"
        Me.XrPageInfo_Chap_Maintenance.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo_Chap_Maintenance.SizeF = New System.Drawing.SizeF(1118.75!, 23.0!)
        Me.XrPageInfo_Chap_Maintenance.StylePriority.UseFont = False
        Me.XrPageInfo_Chap_Maintenance.StylePriority.UseTextAlignment = False
        Me.XrPageInfo_Chap_Maintenance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ReportHeader
        '
        Me.ReportHeader.Dpi = 100.0!
        Me.ReportHeader.HeightF = 0!
        Me.ReportHeader.Name = "ReportHeader"
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
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1})
        Me.DetailReport.Dpi = 100.0!
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrPivotGrid3, Me.XrLabel1, Me.XrPivotGrid1, Me.XrLblTitle, Me.XrPivotGrid2})
        Me.Detail1.Dpi = 100.0!
        Me.Detail1.HeightF = 390.0!
        Me.Detail1.Name = "Detail1"
        '
        'XrLabel2
        '
        Me.XrLabel2.Dpi = 100.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(1.041667!, 262.2917!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(1117.708!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Statistique annuelle de la facturation par provenance"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPivotGrid3
        '
        Me.XrPivotGrid3.DataMember = "api_sp_Rapport_FM_Impression_Nb_HrRea_By_Lot_SEMMARIS"
        Me.XrPivotGrid3.DataSource = Me.SqlDataSource1
        Me.XrPivotGrid3.Dpi = 100.0!
        Me.XrPivotGrid3.FieldHeaderStyleName = "XrStyleHeaderBlue"
        Me.XrPivotGrid3.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() {Me.XrPivotGridField9, Me.XrPivotGridField10, Me.XrPivotGridField11, Me.XrPivotGridField12})
        Me.XrPivotGrid3.FieldValueGrandTotalStyleName = "XrStyleHeaderGdTot"
        Me.XrPivotGrid3.FieldValueTotalStyleName = "XrStyleHeaderBlue"
        Me.XrPivotGrid3.GrandTotalCellStyleName = "XrStyleCellTotal"
        Me.XrPivotGrid3.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 295.7084!)
        Me.XrPivotGrid3.Name = "XrPivotGrid3"
        Me.XrPivotGrid3.OptionsPrint.FilterSeparatorBarPadding = 3
        Me.XrPivotGrid3.OptionsView.ShowColumnGrandTotals = False
        Me.XrPivotGrid3.OptionsView.ShowColumnHeaders = False
        Me.XrPivotGrid3.OptionsView.ShowDataHeaders = False
        Me.XrPivotGrid3.SizeF = New System.Drawing.SizeF(1099.0!, 78.95835!)
        Me.XrPivotGrid3.TotalCellStyleName = "XrStyleCellTotal"
    '
    'SqlDataSource1
    '
    ' TB SAMSIC CITY SPEC
    ' Données spécifiques à un serveur
    Me.SqlDataSource1.ConnectionName = "SRV-VMSQLPROD_MULTI_Connection 1"
        MsSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows
        MsSqlConnectionParameters1.DatabaseName = "MULTI"
        MsSqlConnectionParameters1.ServerName = "SRV-VMSQLPROD"
        Me.SqlDataSource1.ConnectionParameters = MsSqlConnectionParameters1
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "api_sp_Rapport_FM_Impression_Nb_HrRea_By_Lot_SEMMARIS"
        QueryParameter1.Name = "@p_nclinum"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NCLINUM]", GetType(Integer))
        QueryParameter2.Name = "@p_datedebut"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_DEBUT_12M]", GetType(Date))
        QueryParameter3.Name = "@p_datefin"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_FIN_12M]", GetType(Date))
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.Parameters.Add(QueryParameter3)
        StoredProcQuery1.StoredProcName = "api_sp_Rapport_FM_Impression_Nb_HrRea_By_Lot_SEMMARIS"
        StoredProcQuery2.Name = "api_sp_Rapport_FM_Impression_Nb_HrRea_By_Lot_Graph_SEMMARIS"
        QueryParameter4.Name = "@p_nclinum"
        QueryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter4.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NCLINUM]", GetType(Integer))
        QueryParameter5.Name = "@p_datedebut"
        QueryParameter5.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter5.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_DEBUT_12M]", GetType(Date))
        QueryParameter6.Name = "@p_datefin"
        QueryParameter6.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter6.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_FIN_12M]", GetType(Date))
        StoredProcQuery2.Parameters.Add(QueryParameter4)
        StoredProcQuery2.Parameters.Add(QueryParameter5)
        StoredProcQuery2.Parameters.Add(QueryParameter6)
        StoredProcQuery2.StoredProcName = "api_sp_Rapport_FM_Impression_Nb_HrRea_By_Lot_Graph_SEMMARIS"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1, StoredProcQuery2})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'XrPivotGridField9
        '
        Me.XrPivotGridField9.Appearance.FieldValue.BackColor = System.Drawing.Color.White
        Me.XrPivotGridField9.Appearance.FieldValue.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPivotGridField9.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.XrPivotGridField9.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XrPivotGridField9.Appearance.FieldValue.WordWrap = True
        Me.XrPivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.XrPivotGridField9.AreaIndex = 0
        Me.XrPivotGridField9.Caption = "Domaine d'intervention"
        Me.XrPivotGridField9.FieldName = "VTYPECONTRAT"
        Me.XrPivotGridField9.Name = "XrPivotGridField9"
        Me.XrPivotGridField9.Width = 300
        '
        'XrPivotGridField10
        '
        Me.XrPivotGridField10.Appearance.FieldValue.BackColor = System.Drawing.Color.CornflowerBlue
        Me.XrPivotGridField10.Appearance.FieldValue.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPivotGridField10.Appearance.FieldValue.ForeColor = System.Drawing.Color.White
        Me.XrPivotGridField10.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.XrPivotGridField10.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XrPivotGridField10.Appearance.FieldValue.WordWrap = True
        Me.XrPivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.XrPivotGridField10.AreaIndex = 0
        Me.XrPivotGridField10.FieldName = "ANNEE_ID"
        Me.XrPivotGridField10.Name = "XrPivotGridField10"
        '
        'XrPivotGridField11
        '
        Me.XrPivotGridField11.Appearance.FieldValue.BackColor = System.Drawing.Color.CornflowerBlue
        Me.XrPivotGridField11.Appearance.FieldValue.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPivotGridField11.Appearance.FieldValue.ForeColor = System.Drawing.Color.White
        Me.XrPivotGridField11.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.XrPivotGridField11.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XrPivotGridField11.Appearance.FieldValue.WordWrap = True
        Me.XrPivotGridField11.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.XrPivotGridField11.AreaIndex = 1
        Me.XrPivotGridField11.FieldName = "MONTH_ID"
        Me.XrPivotGridField11.Name = "XrPivotGridField11"
        Me.XrPivotGridField11.Width = 45
        '
        'XrPivotGridField12
        '
        Me.XrPivotGridField12.Appearance.Cell.BackColor = System.Drawing.Color.White
        Me.XrPivotGridField12.Appearance.Cell.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPivotGridField12.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.XrPivotGridField12.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XrPivotGridField12.Appearance.Cell.WordWrap = True
        Me.XrPivotGridField12.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.XrPivotGridField12.AreaIndex = 0
        Me.XrPivotGridField12.CellFormat.FormatString = "n0"
        Me.XrPivotGridField12.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.XrPivotGridField12.FieldName = "TOT_HR_MONTH"
        Me.XrPivotGridField12.Name = "XrPivotGridField12"
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 100.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 136.0417!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1117.708!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Statistique annuelle de la facturation par domaine"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPivotGrid1
        '
        Me.XrPivotGrid1.DataMember = "api_sp_Rapport_FM_Impression_Nb_HrRea_By_Lot_SEMMARIS"
        Me.XrPivotGrid1.DataSource = Me.SqlDataSource1
        Me.XrPivotGrid1.Dpi = 100.0!
        Me.XrPivotGrid1.FieldHeaderStyleName = "XrStyleHeaderBlue"
        Me.XrPivotGrid1.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() {Me.XrPivotGridField5, Me.XrPivotGridField6, Me.XrPivotGridField7, Me.XrPivotGridField8})
        Me.XrPivotGrid1.FieldValueGrandTotalStyleName = "XrStyleHeaderGdTot"
        Me.XrPivotGrid1.FieldValueTotalStyleName = "XrStyleHeaderBlue"
        Me.XrPivotGrid1.GrandTotalCellStyleName = "XrStyleCellTotal"
        Me.XrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 171.4583!)
        Me.XrPivotGrid1.Name = "XrPivotGrid1"
        Me.XrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3
        Me.XrPivotGrid1.OptionsView.ShowColumnGrandTotals = False
        Me.XrPivotGrid1.OptionsView.ShowColumnHeaders = False
        Me.XrPivotGrid1.OptionsView.ShowDataHeaders = False
        Me.XrPivotGrid1.SizeF = New System.Drawing.SizeF(1099.0!, 78.95835!)
        Me.XrPivotGrid1.TotalCellStyleName = "XrStyleCellTotal"
        '
        'XrPivotGridField5
        '
        Me.XrPivotGridField5.Appearance.FieldValue.BackColor = System.Drawing.Color.White
        Me.XrPivotGridField5.Appearance.FieldValue.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPivotGridField5.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.XrPivotGridField5.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XrPivotGridField5.Appearance.FieldValue.WordWrap = True
        Me.XrPivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.XrPivotGridField5.AreaIndex = 0
        Me.XrPivotGridField5.Caption = "Domaine d'intervention"
        Me.XrPivotGridField5.FieldName = "VTYPECONTRAT"
        Me.XrPivotGridField5.Name = "XrPivotGridField5"
        Me.XrPivotGridField5.Width = 300
        '
        'XrPivotGridField6
        '
        Me.XrPivotGridField6.Appearance.FieldValue.BackColor = System.Drawing.Color.CornflowerBlue
        Me.XrPivotGridField6.Appearance.FieldValue.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPivotGridField6.Appearance.FieldValue.ForeColor = System.Drawing.Color.White
        Me.XrPivotGridField6.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.XrPivotGridField6.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XrPivotGridField6.Appearance.FieldValue.WordWrap = True
        Me.XrPivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.XrPivotGridField6.AreaIndex = 0
        Me.XrPivotGridField6.FieldName = "ANNEE_ID"
        Me.XrPivotGridField6.Name = "XrPivotGridField6"
        '
        'XrPivotGridField7
        '
        Me.XrPivotGridField7.Appearance.FieldValue.BackColor = System.Drawing.Color.CornflowerBlue
        Me.XrPivotGridField7.Appearance.FieldValue.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPivotGridField7.Appearance.FieldValue.ForeColor = System.Drawing.Color.White
        Me.XrPivotGridField7.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.XrPivotGridField7.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XrPivotGridField7.Appearance.FieldValue.WordWrap = True
        Me.XrPivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.XrPivotGridField7.AreaIndex = 1
        Me.XrPivotGridField7.FieldName = "MONTH_ID"
        Me.XrPivotGridField7.Name = "XrPivotGridField7"
        Me.XrPivotGridField7.Width = 45
        '
        'XrPivotGridField8
        '
        Me.XrPivotGridField8.Appearance.Cell.BackColor = System.Drawing.Color.White
        Me.XrPivotGridField8.Appearance.Cell.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPivotGridField8.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.XrPivotGridField8.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XrPivotGridField8.Appearance.Cell.WordWrap = True
        Me.XrPivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.XrPivotGridField8.AreaIndex = 0
        Me.XrPivotGridField8.CellFormat.FormatString = "n0"
        Me.XrPivotGridField8.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.XrPivotGridField8.FieldName = "TOT_HR_MONTH"
        Me.XrPivotGridField8.Name = "XrPivotGridField8"
        '
        'XrLblTitle
        '
        Me.XrLblTitle.Dpi = 100.0!
        Me.XrLblTitle.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrLblTitle.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.00001!)
        Me.XrLblTitle.Name = "XrLblTitle"
        Me.XrLblTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblTitle.SizeF = New System.Drawing.SizeF(1117.708!, 23.0!)
        Me.XrLblTitle.StylePriority.UseFont = False
        Me.XrLblTitle.StylePriority.UseForeColor = False
        Me.XrLblTitle.StylePriority.UseTextAlignment = False
        Me.XrLblTitle.Text = "Statistique annuelle de la facturation par secteur"
        Me.XrLblTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPivotGrid2
        '
        Me.XrPivotGrid2.DataMember = "api_sp_Rapport_FM_Impression_Nb_HrRea_By_Lot_SEMMARIS"
        Me.XrPivotGrid2.DataSource = Me.SqlDataSource1
        Me.XrPivotGrid2.Dpi = 100.0!
        Me.XrPivotGrid2.FieldHeaderStyleName = "XrStyleHeaderBlue"
        Me.XrPivotGrid2.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() {Me.XrPivotGridField1, Me.XrPivotGridField2, Me.XrPivotGridField3, Me.XrPivotGridField4})
        Me.XrPivotGrid2.FieldValueGrandTotalStyleName = "XrStyleHeaderGdTot"
        Me.XrPivotGrid2.FieldValueTotalStyleName = "XrStyleHeaderBlue"
        Me.XrPivotGrid2.GrandTotalCellStyleName = "XrStyleCellTotal"
        Me.XrPivotGrid2.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 45.41667!)
        Me.XrPivotGrid2.Name = "XrPivotGrid2"
        Me.XrPivotGrid2.OptionsPrint.FilterSeparatorBarPadding = 3
        Me.XrPivotGrid2.OptionsView.ShowColumnGrandTotals = False
        Me.XrPivotGrid2.OptionsView.ShowColumnHeaders = False
        Me.XrPivotGrid2.OptionsView.ShowDataHeaders = False
        Me.XrPivotGrid2.SizeF = New System.Drawing.SizeF(1099.0!, 78.95835!)
        Me.XrPivotGrid2.TotalCellStyleName = "XrStyleCellTotal"
        '
        'XrPivotGridField1
        '
        Me.XrPivotGridField1.Appearance.FieldValue.BackColor = System.Drawing.Color.White
        Me.XrPivotGridField1.Appearance.FieldValue.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPivotGridField1.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.XrPivotGridField1.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XrPivotGridField1.Appearance.FieldValue.WordWrap = True
        Me.XrPivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.XrPivotGridField1.AreaIndex = 0
        Me.XrPivotGridField1.Caption = "Secteurs d'intervention"
        Me.XrPivotGridField1.FieldName = "VTYPECONTRAT"
        Me.XrPivotGridField1.Name = "XrPivotGridField1"
        Me.XrPivotGridField1.Width = 300
        '
        'XrPivotGridField2
        '
        Me.XrPivotGridField2.Appearance.FieldValue.BackColor = System.Drawing.Color.CornflowerBlue
        Me.XrPivotGridField2.Appearance.FieldValue.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPivotGridField2.Appearance.FieldValue.ForeColor = System.Drawing.Color.White
        Me.XrPivotGridField2.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.XrPivotGridField2.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XrPivotGridField2.Appearance.FieldValue.WordWrap = True
        Me.XrPivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.XrPivotGridField2.AreaIndex = 0
        Me.XrPivotGridField2.FieldName = "ANNEE_ID"
        Me.XrPivotGridField2.Name = "XrPivotGridField2"
        '
        'XrPivotGridField3
        '
        Me.XrPivotGridField3.Appearance.FieldValue.BackColor = System.Drawing.Color.CornflowerBlue
        Me.XrPivotGridField3.Appearance.FieldValue.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPivotGridField3.Appearance.FieldValue.ForeColor = System.Drawing.Color.White
        Me.XrPivotGridField3.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.XrPivotGridField3.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XrPivotGridField3.Appearance.FieldValue.WordWrap = True
        Me.XrPivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.XrPivotGridField3.AreaIndex = 1
        Me.XrPivotGridField3.FieldName = "MONTH_ID"
        Me.XrPivotGridField3.Name = "XrPivotGridField3"
        Me.XrPivotGridField3.Width = 45
        '
        'XrPivotGridField4
        '
        Me.XrPivotGridField4.Appearance.Cell.BackColor = System.Drawing.Color.White
        Me.XrPivotGridField4.Appearance.Cell.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPivotGridField4.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.XrPivotGridField4.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XrPivotGridField4.Appearance.Cell.WordWrap = True
        Me.XrPivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.XrPivotGridField4.AreaIndex = 0
        Me.XrPivotGridField4.CellFormat.FormatString = "n0"
        Me.XrPivotGridField4.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.XrPivotGridField4.FieldName = "TOT_HR_MONTH"
        Me.XrPivotGridField4.Name = "XrPivotGridField4"
        '
        'DetailReport1
        '
        Me.DetailReport1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail2})
        Me.DetailReport1.Dpi = 100.0!
        Me.DetailReport1.Level = 1
        Me.DetailReport1.Name = "DetailReport1"
        '
        'Detail2
        '
        Me.Detail2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrChart2, Me.XrChart1, Me.XrLabel4, Me.XrLabel3})
        Me.Detail2.Dpi = 100.0!
        Me.Detail2.HeightF = 737.5!
        Me.Detail2.Name = "Detail2"
        '
        'XrStyleCellTotal
        '
        Me.XrStyleCellTotal.BackColor = System.Drawing.Color.White
        Me.XrStyleCellTotal.BorderColor = System.Drawing.Color.DarkGray
        Me.XrStyleCellTotal.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrStyleCellTotal.BorderWidth = 0.5!
        Me.XrStyleCellTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrStyleCellTotal.Name = "XrStyleCellTotal"
        Me.XrStyleCellTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrStyleCellTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrStyleHeaderBlue
        '
        Me.XrStyleHeaderBlue.BackColor = System.Drawing.Color.CornflowerBlue
        Me.XrStyleHeaderBlue.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrStyleHeaderBlue.BorderWidth = 0.5!
        Me.XrStyleHeaderBlue.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrStyleHeaderBlue.ForeColor = System.Drawing.Color.White
        Me.XrStyleHeaderBlue.Name = "XrStyleHeaderBlue"
        Me.XrStyleHeaderBlue.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrStyleHeaderBlue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrStyleHeaderGdTot
        '
        Me.XrStyleHeaderGdTot.BackColor = System.Drawing.Color.White
        Me.XrStyleHeaderGdTot.BorderColor = System.Drawing.Color.DarkGray
        Me.XrStyleHeaderGdTot.BorderWidth = 0.5!
        Me.XrStyleHeaderGdTot.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrStyleHeaderGdTot.ForeColor = System.Drawing.Color.Black
        Me.XrStyleHeaderGdTot.Name = "XrStyleHeaderGdTot"
        Me.XrStyleHeaderGdTot.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrStyleHeaderGdTot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 100.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 9.999974!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(1117.708!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Cumul de la facturation par secteur"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 100.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(2.083818!, 342.6251!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(1117.708!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Dépenses cumulées"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrChart1
        '
        Me.XrChart1.BorderColor = System.Drawing.Color.DarkGray
        Me.XrChart1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrChart1.BorderWidth = 0.5!
        Me.XrChart1.DataMember = "api_sp_Rapport_FM_Impression_Nb_HrRea_By_Lot_Graph_SEMMARIS"
        Me.XrChart1.DataSource = Me.SqlDataSource1
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram2.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram2.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram2.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram2.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart1.Diagram = XyDiagram2
        Me.XrChart1.Dpi = 100.0!
        Me.XrChart1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.XrChart1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
        Me.XrChart1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.XrChart1.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 47.91667!)
        Me.XrChart1.Name = "XrChart1"
        Me.XrChart1.SeriesDataMember = "VTYPECONTRAT"
        Me.XrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart1.SeriesTemplate.ArgumentDataMember = "AXE_X"
        Me.XrChart1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart1.SeriesTemplate.ValueDataMembersSerializable = "TOT_HR_MONTH"
        Me.XrChart1.SizeF = New System.Drawing.SizeF(1099.0!, 279.1667!)
        Me.XrChart1.StylePriority.UseBorderColor = False
        Me.XrChart1.StylePriority.UseBorders = False
        Me.XrChart1.StylePriority.UseBorderWidth = False
        ChartTitle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle2.Text = "Cumul de la facturation par secteur"
		ChartTitle2.TextColor = System.Drawing.Color.Black
        ChartTitle2.WordWrap = True
        Me.XrChart1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'XrChart2
        '
        Me.XrChart2.BorderColor = System.Drawing.Color.DarkGray
        Me.XrChart2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrChart2.BorderWidth = 0.5!
        Me.XrChart2.DataMember = "api_sp_Rapport_FM_Impression_Nb_HrRea_By_Lot_Graph_SEMMARIS"
        Me.XrChart2.DataSource = Me.SqlDataSource1
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart2.Diagram = XyDiagram1
        Me.XrChart2.Dpi = 100.0!
        Me.XrChart2.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.XrChart2.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
        Me.XrChart2.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.XrChart2.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 376.4584!)
        Me.XrChart2.Name = "XrChart2"
        Me.XrChart2.SeriesDataMember = "VTYPECONTRAT"
        Me.XrChart2.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart2.SeriesTemplate.ArgumentDataMember = "AXE_X"
        Me.XrChart2.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart2.SeriesTemplate.ValueDataMembersSerializable = "TOT_HR_MONTH"
        Me.XrChart2.SizeF = New System.Drawing.SizeF(1099.0!, 346.875!)
        Me.XrChart2.StylePriority.UseBorderColor = False
        Me.XrChart2.StylePriority.UseBorders = False
        Me.XrChart2.StylePriority.UseBorderWidth = False
        ChartTitle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartTitle1.Text = "Dépenses cumulées"
		ChartTitle1.TextColor = System.Drawing.Color.Black
        ChartTitle1.WordWrap = True
        Me.XrChart2.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'XR_Page_Chap_SEMMARIS_StatFact
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.ReportHeader, Me.DetailReport, Me.DetailReport1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBoxBordersAllPage})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 18, 14)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.P_NCLINUM, Me.P_VENSEIGNE, Me.P_DATE_DEBUT_12M, Me.P_DATE_FIN_12M, Me.P_DATE_DEBUT_PERIODE, Me.P_DATE_FIN_PERIODE, Me.P_DATE_DEBUT_ANNEE, Me.P_DATE_TODAY, Me.P_DATE_DEBUT_LASTMONTH, Me.P_DATE_FIN_LASTMONTH})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrStyleCellTotal, Me.XrStyleHeaderBlue, Me.XrStyleHeaderGdTot})
        Me.Version = "15.2"
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents DetailReport1 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail2 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents XrPivotGrid2 As DevExpress.XtraReports.UI.XRPivotGrid
    Friend WithEvents XrPivotGridField1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField2 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField3 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField4 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrStyleCellTotal As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrStyleHeaderBlue As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrStyleHeaderGdTot As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrLblTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPivotGrid3 As DevExpress.XtraReports.UI.XRPivotGrid
    Friend WithEvents XrPivotGridField9 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField10 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField11 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField12 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPivotGrid1 As DevExpress.XtraReports.UI.XRPivotGrid
    Friend WithEvents XrPivotGridField5 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField6 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField7 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField8 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrChart2 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents XrChart1 As DevExpress.XtraReports.UI.XRChart
End Class
