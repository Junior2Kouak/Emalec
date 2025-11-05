<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XR_Page_Chap_StatListeActCreeInMonth
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XR_Page_Chap_StatListeActCreeInMonth))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrCrossBandBoxBordersAllPage = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo_Chap_Maintenance = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLblTitre_ChapStatListeActCreeInMonth = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.XrTable107 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow110 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell937 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell938 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell939 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell940 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell941 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell942 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell943 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell944 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable106 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow109 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell925 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell929 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell930 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell931 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell932 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell933 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell934 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell935 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.P_NIDRAPPORT_FM_CLI = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_WITH_PREV = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.XrTable107, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable106, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TopMargin.HeightF = 14.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 12.0!
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
        Me.XrCrossBandBoxBordersAllPage.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 5.750002!)
        Me.XrCrossBandBoxBordersAllPage.Name = "XrCrossBandBoxBordersAllPage"
        Me.XrCrossBandBoxBordersAllPage.StartBand = Me.TopMargin
        Me.XrCrossBandBoxBordersAllPage.StartPointFloat = New DevExpress.Utils.PointFloat(0!, 8.333332!)
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLblTitre_ChapStatListeActCreeInMonth})
        Me.ReportHeader.HeightF = 23.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLblTitre_ChapStatListeActCreeInMonth
        '
        Me.XrLblTitre_ChapStatListeActCreeInMonth.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblTitre_ChapStatListeActCreeInMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrLblTitre_ChapStatListeActCreeInMonth.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 0!)
        Me.XrLblTitre_ChapStatListeActCreeInMonth.Name = "XrLblTitre_ChapStatListeActCreeInMonth"
        Me.XrLblTitre_ChapStatListeActCreeInMonth.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblTitre_ChapStatListeActCreeInMonth.SizeF = New System.Drawing.SizeF(754.9998!, 23.0!)
        Me.XrLblTitre_ChapStatListeActCreeInMonth.StylePriority.UseFont = False
        Me.XrLblTitre_ChapStatListeActCreeInMonth.StylePriority.UseForeColor = False
        Me.XrLblTitre_ChapStatListeActCreeInMonth.Text = "Liste des actions créées dans la période"
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
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.GroupHeader1})
        Me.DetailReport.DataMember = "api_sp_Rapport_FM_Impression_ListeActCreeInMonth"
        Me.DetailReport.DataSource = Me.SqlDataSource1
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable107})
        Me.Detail1.HeightF = 15.0!
        Me.Detail1.Name = "Detail1"
        '
        'XrTable107
        '
        Me.XrTable107.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTable107.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable107.BorderWidth = 0.5!
        Me.XrTable107.Font = New System.Drawing.Font("Century Gothic", 7.25!)
        Me.XrTable107.LocationFloat = New DevExpress.Utils.PointFloat(10.0001!, 0!)
        Me.XrTable107.Name = "XrTable107"
        Me.XrTable107.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow110})
        Me.XrTable107.SizeF = New System.Drawing.SizeF(754.9998!, 15.0!)
        Me.XrTable107.StylePriority.UseBorderColor = False
        Me.XrTable107.StylePriority.UseBorders = False
        Me.XrTable107.StylePriority.UseBorderWidth = False
        Me.XrTable107.StylePriority.UseFont = False
        Me.XrTable107.StylePriority.UseTextAlignment = False
        Me.XrTable107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow110
        '
        Me.XrTableRow110.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell937, Me.XrTableCell938, Me.XrTableCell939, Me.XrTableCell940, Me.XrTableCell941, Me.XrTableCell942, Me.XrTableCell943, Me.XrTableCell2, Me.XrTableCell944})
        Me.XrTableRow110.Name = "XrTableRow110"
        Me.XrTableRow110.Weight = 11.5R
        '
        'XrTableCell937
        '
        Me.XrTableCell937.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VSITNOM]")})
        Me.XrTableCell937.Name = "XrTableCell937"
        Me.XrTableCell937.Text = "XrTableCell937"
        Me.XrTableCell937.Weight = 0.24162238045844275R
        '
        'XrTableCell938
        '
        Me.XrTableCell938.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VPRELIB]")})
        Me.XrTableCell938.Name = "XrTableCell938"
        Me.XrTableCell938.Text = "XrTableCell938"
        Me.XrTableCell938.Weight = 0.112022967356928R
        '
        'XrTableCell939
        '
        Me.XrTableCell939.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NDINNUM]")})
        Me.XrTableCell939.Name = "XrTableCell939"
        Me.XrTableCell939.Text = "XrTableCell939"
        Me.XrTableCell939.Weight = 0.072934213309430118R
        '
        'XrTableCell940
        '
        Me.XrTableCell940.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VACTNUMCDE]")})
        Me.XrTableCell940.Name = "XrTableCell940"
        Me.XrTableCell940.Text = "XrTableCell940"
        Me.XrTableCell940.Weight = 0.0763289019511321R
        '
        'XrTableCell941
        '
        Me.XrTableCell941.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VACTNUMGMAO]")})
        Me.XrTableCell941.Name = "XrTableCell941"
        Me.XrTableCell941.Text = "XrTableCell941"
        Me.XrTableCell941.Weight = 0.086538054986588175R
        '
        'XrTableCell942
        '
        Me.XrTableCell942.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VACTDES]")})
        Me.XrTableCell942.Name = "XrTableCell942"
        Me.XrTableCell942.Text = "XrTableCell942"
        Me.XrTableCell942.Weight = 0.28842421305720412R
        '
        'XrTableCell943
        '
        Me.XrTableCell943.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DACTDATCRE]")})
        Me.XrTableCell943.Name = "XrTableCell943"
        Me.XrTableCell943.Text = "XrTableCell943"
        Me.XrTableCell943.Weight = 0.11661126089164341R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DACTPLA]")})
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "XrTableCell2"
        Me.XrTableCell2.Weight = 0.13889703506890794R
        '
        'XrTableCell944
        '
        Me.XrTableCell944.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DACTDEX]")})
        Me.XrTableCell944.Name = "XrTableCell944"
        Me.XrTableCell944.Text = "XrTableCell944"
        Me.XrTableCell944.Weight = 0.10913587201234909R
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable106})
        Me.GroupHeader1.HeightF = 61.45838!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = True
        '
        'XrTable106
        '
        Me.XrTable106.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.XrTable106.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTable106.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable106.BorderWidth = 0.5!
        Me.XrTable106.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable106.LocationFloat = New DevExpress.Utils.PointFloat(10.00005!, 9.999993!)
        Me.XrTable106.Name = "XrTable106"
        Me.XrTable106.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow109})
        Me.XrTable106.SizeF = New System.Drawing.SizeF(754.9999!, 51.45837!)
        Me.XrTable106.StylePriority.UseBackColor = False
        Me.XrTable106.StylePriority.UseBorderColor = False
        Me.XrTable106.StylePriority.UseBorders = False
        Me.XrTable106.StylePriority.UseBorderWidth = False
        Me.XrTable106.StylePriority.UseFont = False
        Me.XrTable106.StylePriority.UseTextAlignment = False
        Me.XrTable106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow109
        '
        Me.XrTableRow109.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell925, Me.XrTableCell929, Me.XrTableCell930, Me.XrTableCell931, Me.XrTableCell932, Me.XrTableCell933, Me.XrTableCell934, Me.XrTableCell1, Me.XrTableCell935})
        Me.XrTableRow109.Name = "XrTableRow109"
        Me.XrTableRow109.Weight = 1.0R
        '
        'XrTableCell925
        '
        Me.XrTableCell925.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell925.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell925.ForeColor = System.Drawing.Color.White
        Me.XrTableCell925.Name = "XrTableCell925"
        Me.XrTableCell925.StylePriority.UseBackColor = False
        Me.XrTableCell925.StylePriority.UseFont = False
        Me.XrTableCell925.StylePriority.UseForeColor = False
        Me.XrTableCell925.Text = "Site"
        Me.XrTableCell925.Weight = 1.5913643412154628R
        '
        'XrTableCell929
        '
        Me.XrTableCell929.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell929.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell929.ForeColor = System.Drawing.Color.White
        Me.XrTableCell929.Name = "XrTableCell929"
        Me.XrTableCell929.StylePriority.UseBackColor = False
        Me.XrTableCell929.StylePriority.UseFont = False
        Me.XrTableCell929.StylePriority.UseForeColor = False
        Me.XrTableCell929.Text = "Prestation"
        Me.XrTableCell929.Weight = 0.737801233919176R
        '
        'XrTableCell930
        '
        Me.XrTableCell930.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell930.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell930.ForeColor = System.Drawing.Color.White
        Me.XrTableCell930.Name = "XrTableCell930"
        Me.XrTableCell930.StylePriority.UseBackColor = False
        Me.XrTableCell930.StylePriority.UseFont = False
        Me.XrTableCell930.StylePriority.UseForeColor = False
        Me.XrTableCell930.Text = "DI"
        Me.XrTableCell930.Weight = 0.48035600709819176R
        '
        'XrTableCell931
        '
        Me.XrTableCell931.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell931.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell931.ForeColor = System.Drawing.Color.White
        Me.XrTableCell931.Name = "XrTableCell931"
        Me.XrTableCell931.StylePriority.UseBackColor = False
        Me.XrTableCell931.StylePriority.UseFont = False
        Me.XrTableCell931.StylePriority.UseForeColor = False
        Me.XrTableCell931.Text = "N° CDE"
        Me.XrTableCell931.Weight = 0.502715185678652R
        '
        'XrTableCell932
        '
        Me.XrTableCell932.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell932.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell932.ForeColor = System.Drawing.Color.White
        Me.XrTableCell932.Name = "XrTableCell932"
        Me.XrTableCell932.StylePriority.UseBackColor = False
        Me.XrTableCell932.StylePriority.UseFont = False
        Me.XrTableCell932.StylePriority.UseForeColor = False
        Me.XrTableCell932.Text = "N° GMAO"
        Me.XrTableCell932.Weight = 0.56995393796005156R
        '
        'XrTableCell933
        '
        Me.XrTableCell933.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell933.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell933.ForeColor = System.Drawing.Color.White
        Me.XrTableCell933.Name = "XrTableCell933"
        Me.XrTableCell933.StylePriority.UseBackColor = False
        Me.XrTableCell933.StylePriority.UseFont = False
        Me.XrTableCell933.StylePriority.UseForeColor = False
        Me.XrTableCell933.Text = "Action"
        Me.XrTableCell933.Weight = 1.8996086996251065R
        '
        'XrTableCell934
        '
        Me.XrTableCell934.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell934.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell934.ForeColor = System.Drawing.Color.White
        Me.XrTableCell934.Name = "XrTableCell934"
        Me.XrTableCell934.StylePriority.UseBackColor = False
        Me.XrTableCell934.StylePriority.UseFont = False
        Me.XrTableCell934.StylePriority.UseForeColor = False
        Me.XrTableCell934.Text = "Date création"
        Me.XrTableCell934.Weight = 0.76802072257347687R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell1.ForeColor = System.Drawing.Color.White
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBackColor = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseForeColor = False
        Me.XrTableCell1.Text = "Date de planification"
        Me.XrTableCell1.Weight = 0.91479840548266433R
        '
        'XrTableCell935
        '
        Me.XrTableCell935.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell935.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell935.ForeColor = System.Drawing.Color.White
        Me.XrTableCell935.Name = "XrTableCell935"
        Me.XrTableCell935.StylePriority.UseBackColor = False
        Me.XrTableCell935.StylePriority.UseFont = False
        Me.XrTableCell935.StylePriority.UseForeColor = False
        Me.XrTableCell935.Text = "Date exécution"
        Me.XrTableCell935.Weight = 0.71878840742611649R
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
        StoredProcQuery1.Name = "api_sp_Rapport_FM_Impression_ListeActCreeInMonth"
        QueryParameter1.Name = "@p_nclinum"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NCLINUM]", GetType(Integer))
        QueryParameter2.Name = "@p_datedebut"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_DEBUT_PERIODE]", GetType(Date))
        QueryParameter3.Name = "@p_datefin"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("[Parameters.P_DATE_FIN_PERIODE]", GetType(Date))
        QueryParameter4.Name = "@p_slangue"
        QueryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter4.Value = New DevExpress.DataAccess.Expression("[Parameters.P_LANGUE]", GetType(String))
        QueryParameter5.Name = "@p_nidrapport_fm_cli"
        QueryParameter5.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter5.Value = New DevExpress.DataAccess.Expression("[Parameters.P_NIDRAPPORT_FM_CLI]", GetType(Integer))
        QueryParameter6.Name = "@p_WithPrev"
        QueryParameter6.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter6.Value = New DevExpress.DataAccess.Expression("[Parameters.P_WITH_PREV]", GetType(Boolean))
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.Parameters.Add(QueryParameter3)
        StoredProcQuery1.Parameters.Add(QueryParameter4)
        StoredProcQuery1.Parameters.Add(QueryParameter5)
        StoredProcQuery1.Parameters.Add(QueryParameter6)
        StoredProcQuery1.StoredProcName = "api_sp_Rapport_FM_Impression_ListeActCreeInMonth"
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
        'P_WITH_PREV
        '
        Me.P_WITH_PREV.Description = "AVEC PREV"
        Me.P_WITH_PREV.Name = "P_WITH_PREV"
        Me.P_WITH_PREV.Type = GetType(Boolean)
        Me.P_WITH_PREV.ValueInfo = "True"
        '
        'XR_Page_Chap_StatListeActCreeInMonth
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.ReportHeader, Me.DetailReport})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBoxBordersAllPage})
        Me.Margins = New System.Drawing.Printing.Margins(25, 22, 14, 12)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.P_NCLINUM, Me.P_VENSEIGNE, Me.P_DATE_DEBUT_12M, Me.P_DATE_FIN_12M, Me.P_DATE_DEBUT_PERIODE, Me.P_DATE_FIN_PERIODE, Me.P_DATE_DEBUT_ANNEE, Me.P_DATE_TODAY, Me.P_DATE_DEBUT_LASTMONTH, Me.P_DATE_FIN_LASTMONTH, Me.P_LANGUE, Me.P_NIDRAPPORT_FM_CLI, Me.P_WITH_PREV})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "18.2"
        CType(Me.XrTable107, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable106, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents XrLblTitre_ChapStatListeActCreeInMonth As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents XrTable107 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow110 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell937 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell938 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell939 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell940 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell941 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell942 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell943 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell944 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable106 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow109 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell925 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell929 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell930 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell931 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell932 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell933 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell934 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell935 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents P_NIDRAPPORT_FM_CLI As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents P_WITH_PREV As DevExpress.XtraReports.Parameters.Parameter
End Class
