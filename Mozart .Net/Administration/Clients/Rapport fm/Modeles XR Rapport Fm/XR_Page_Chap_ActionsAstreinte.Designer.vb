<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XR_Page_Chap_ActionsAstreinte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XR_Page_Chap_ActionsAstreinte))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrCrossBandBoxBordersAllPage = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo_Chap_Maintenance = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLblPerimetre_ListActionsAstreinte = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLblTitreListeActionsAsteinte = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.XrTable21 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow22 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell242 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell243 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell244 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell245 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell246 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell247 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell248 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable20 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow21 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell235 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell236 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell237 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell238 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell239 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell240 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell241 = New DevExpress.XtraReports.UI.XRTableCell()
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLblPerimetre_ListActionsAstreinte, Me.XrLblTitreListeActionsAsteinte})
        Me.ReportHeader.HeightF = 47.45834!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLblPerimetre_ListActionsAstreinte
        '
        Me.XrLblPerimetre_ListActionsAstreinte.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblPerimetre_ListActionsAstreinte.LocationFloat = New DevExpress.Utils.PointFloat(10.49999!, 23.0!)
        Me.XrLblPerimetre_ListActionsAstreinte.Name = "XrLblPerimetre_ListActionsAstreinte"
        Me.XrLblPerimetre_ListActionsAstreinte.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblPerimetre_ListActionsAstreinte.SizeF = New System.Drawing.SizeF(754.9998!, 24.45834!)
        Me.XrLblPerimetre_ListActionsAstreinte.StylePriority.UseFont = False
        Me.XrLblPerimetre_ListActionsAstreinte.Text = "Toutes prestations"
        '
        'XrLblTitreListeActionsAsteinte
        '
        Me.XrLblTitreListeActionsAsteinte.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblTitreListeActionsAsteinte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrLblTitreListeActionsAsteinte.LocationFloat = New DevExpress.Utils.PointFloat(10.49999!, 0!)
        Me.XrLblTitreListeActionsAsteinte.Name = "XrLblTitreListeActionsAsteinte"
        Me.XrLblTitreListeActionsAsteinte.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblTitreListeActionsAsteinte.SizeF = New System.Drawing.SizeF(754.9998!, 23.0!)
        Me.XrLblTitreListeActionsAsteinte.StylePriority.UseFont = False
        Me.XrLblTitreListeActionsAsteinte.StylePriority.UseForeColor = False
        Me.XrLblTitreListeActionsAsteinte.Text = "Liste des interventions en astreinte par contrat et secteur sur la période"
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
        Me.DetailReport.DataMember = "api_sp_Rapport_FM_Impression_Lst_act_Astreinte"
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
        Me.XrTable21.SizeF = New System.Drawing.SizeF(751.4584!, 15.0!)
        Me.XrTable21.StylePriority.UseBorderColor = False
        Me.XrTable21.StylePriority.UseBorders = False
        Me.XrTable21.StylePriority.UseBorderWidth = False
        Me.XrTable21.StylePriority.UseFont = False
        Me.XrTable21.StylePriority.UseTextAlignment = False
        Me.XrTable21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow22
        '
        Me.XrTableRow22.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell242, Me.XrTableCell243, Me.XrTableCell244, Me.XrTableCell245, Me.XrTableCell246, Me.XrTableCell247, Me.XrTableCell248})
        Me.XrTableRow22.Name = "XrTableRow22"
        Me.XrTableRow22.Weight = 11.5R
        '
        'XrTableCell242
        '
        Me.XrTableCell242.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VTYPECONTRAT]")})
        Me.XrTableCell242.Name = "XrTableCell242"
        Me.XrTableCell242.Text = "XrTableCell242"
        Me.XrTableCell242.Weight = 1.6235458013062836R
        '
        'XrTableCell243
        '
        Me.XrTableCell243.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VSITSECTEUR]")})
        Me.XrTableCell243.Name = "XrTableCell243"
        Me.XrTableCell243.Text = "XrTableCell243"
        Me.XrTableCell243.Weight = 1.1814715116767474R
        '
        'XrTableCell244
        '
        Me.XrTableCell244.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VSITNOM]")})
        Me.XrTableCell244.Name = "XrTableCell244"
        Me.XrTableCell244.Text = "XrTableCell244"
        Me.XrTableCell244.Weight = 1.4586724525369621R
        '
        'XrTableCell245
        '
        Me.XrTableCell245.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NDINNUM]")})
        Me.XrTableCell245.Name = "XrTableCell245"
        Me.XrTableCell245.Text = "XrTableCell245"
        Me.XrTableCell245.Weight = 0.81200167794090183R
        '
        'XrTableCell246
        '
        Me.XrTableCell246.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VACTDES]")})
        Me.XrTableCell246.Name = "XrTableCell246"
        Me.XrTableCell246.StylePriority.UseTextAlignment = False
        Me.XrTableCell246.Text = "XrTableCell246"
        Me.XrTableCell246.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell246.Weight = 1.6527265252891048R
        '
        'XrTableCell247
        '
        Me.XrTableCell247.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DACTDATCRE]")})
        Me.XrTableCell247.Name = "XrTableCell247"
        Me.XrTableCell247.Text = "XrTableCell247"
        Me.XrTableCell247.Weight = 1.2300049221900202R
        '
        'XrTableCell248
        '
        Me.XrTableCell248.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DACTDEX]")})
        Me.XrTableCell248.Name = "XrTableCell248"
        Me.XrTableCell248.Text = "XrTableCell248"
        Me.XrTableCell248.Weight = 1.0913989451963158R
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
        Me.XrTable20.SizeF = New System.Drawing.SizeF(751.4584!, 51.45837!)
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
        Me.XrTableRow21.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell235, Me.XrTableCell236, Me.XrTableCell237, Me.XrTableCell238, Me.XrTableCell239, Me.XrTableCell240, Me.XrTableCell241})
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
        Me.XrTableCell235.Text = "Contrat"
        Me.XrTableCell235.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell235.Weight = 1.348124234722152R
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
        Me.XrTableCell236.Text = "Secteur"
        Me.XrTableCell236.Weight = 0.98104276019439018R
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
        Me.XrTableCell237.Text = "Site"
        Me.XrTableCell237.Weight = 1.2112191747626413R
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
        Me.XrTableCell238.Text = "N° DI"
        Me.XrTableCell238.Weight = 0.67425139542849277R
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
        Me.XrTableCell239.Text = "Action"
        Me.XrTableCell239.Weight = 1.3723525563235797R
        '
        'XrTableCell240
        '
        Me.XrTableCell240.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell240.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell240.ForeColor = System.Drawing.Color.White
        Me.XrTableCell240.Name = "XrTableCell240"
        Me.XrTableCell240.StylePriority.UseBackColor = False
        Me.XrTableCell240.StylePriority.UseFont = False
        Me.XrTableCell240.StylePriority.UseForeColor = False
        Me.XrTableCell240.Text = "Date création action"
        Me.XrTableCell240.Weight = 1.0213440175068833R
        '
        'XrTableCell241
        '
        Me.XrTableCell241.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell241.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell241.ForeColor = System.Drawing.Color.White
        Me.XrTableCell241.Name = "XrTableCell241"
        Me.XrTableCell241.StylePriority.UseBackColor = False
        Me.XrTableCell241.StylePriority.UseFont = False
        Me.XrTableCell241.StylePriority.UseForeColor = False
        Me.XrTableCell241.Text = "Date exécution"
        Me.XrTableCell241.Weight = 0.906249337578744R
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
        StoredProcQuery1.Name = "api_sp_Rapport_FM_Impression_Lst_act_Astreinte"
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
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.Parameters.Add(QueryParameter3)
        StoredProcQuery1.Parameters.Add(QueryParameter4)
        StoredProcQuery1.Parameters.Add(QueryParameter5)
        StoredProcQuery1.StoredProcName = "api_sp_Rapport_FM_Impression_Lst_act_Astreinte"
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
        'XR_Page_Chap_ActionsAstreinte
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.ReportHeader, Me.DetailReport})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBoxBordersAllPage})
        Me.Margins = New System.Drawing.Printing.Margins(25, 26, 18, 21)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.P_NCLINUM, Me.P_VENSEIGNE, Me.P_DATE_DEBUT_12M, Me.P_DATE_FIN_12M, Me.P_DATE_DEBUT_PERIODE, Me.P_DATE_FIN_PERIODE, Me.P_DATE_DEBUT_ANNEE, Me.P_DATE_TODAY, Me.P_DATE_DEBUT_LASTMONTH, Me.P_DATE_FIN_LASTMONTH, Me.P_LANGUE, Me.P_NIDRAPPORT_FM_CLI})
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
    Friend WithEvents XrLblPerimetre_ListActionsAstreinte As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLblTitreListeActionsAsteinte As DevExpress.XtraReports.UI.XRLabel
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
    Friend WithEvents XrTableCell247 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell248 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable20 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow21 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell235 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell236 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell237 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell238 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell239 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell240 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell241 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents P_NIDRAPPORT_FM_CLI As DevExpress.XtraReports.Parameters.Parameter
End Class
