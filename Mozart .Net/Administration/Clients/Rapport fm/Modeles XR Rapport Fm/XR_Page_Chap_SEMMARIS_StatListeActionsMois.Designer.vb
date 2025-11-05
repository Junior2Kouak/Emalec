<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XR_Page_Chap_SEMMARIS_StatListeActionsMois
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XR_Page_Chap_SEMMARIS_StatListeActionsMois))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrCrossBandBoxBordersAllPage = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo_Chap_Maintenance = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLblTitle = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.DetailReport1 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail2 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrStyleCellTotal = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrStyleHeaderBlue = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrStyleHeaderGdTot = New DevExpress.XtraReports.UI.XRControlStyle()
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLblTitle})
        Me.ReportHeader.Dpi = 100.0!
        Me.ReportHeader.HeightF = 23.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLblTitle
        '
        Me.XrLblTitle.Dpi = 100.0!
        Me.XrLblTitle.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrLblTitle.LocationFloat = New DevExpress.Utils.PointFloat(1.042032!, 0!)
        Me.XrLblTitle.Name = "XrLblTitle"
        Me.XrLblTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblTitle.SizeF = New System.Drawing.SizeF(1117.708!, 23.0!)
        Me.XrLblTitle.StylePriority.UseFont = False
        Me.XrLblTitle.StylePriority.UseForeColor = False
        Me.XrLblTitle.StylePriority.UseTextAlignment = False
        Me.XrLblTitle.Text = "Statistique annuelle réalisées sur heures de service par domaines d'interventions" &
    ""
        Me.XrLblTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        Me.Detail1.Dpi = 100.0!
        Me.Detail1.HeightF = 529.5834!
        Me.Detail1.Name = "Detail1"
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
        'DetailReport1
        '
        Me.DetailReport1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail2})
        Me.DetailReport1.Dpi = 100.0!
        Me.DetailReport1.Level = 1
        Me.DetailReport1.Name = "DetailReport1"
        '
        'Detail2
        '
        Me.Detail2.Dpi = 100.0!
        Me.Detail2.HeightF = 0!
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
        'XR_Page_Chap_SEMMARIS_StatListeActionsMois
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
    Friend WithEvents XrLblTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents XrStyleCellTotal As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrStyleHeaderBlue As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrStyleHeaderGdTot As DevExpress.XtraReports.UI.XRControlStyle
End Class
