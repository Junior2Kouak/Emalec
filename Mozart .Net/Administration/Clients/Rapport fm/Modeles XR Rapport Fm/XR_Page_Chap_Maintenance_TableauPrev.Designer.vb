<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XR_Page_Chap_Maintenance_TableauPrev
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XR_Page_Chap_Maintenance_TableauPrev))
        Me.Detail_Chap_Maintenance = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin_Chap_Maintenance = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin_Chap_Maintenance = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrCrossBandBoxBordersAllPage = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.RH_Chap_Maintenance = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLblMaintenanceTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.SDS_Chap_Maintenance_TabPrev = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.P_NCLINUM = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_NTYPECONTRAT = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PageFooter_Chap_Maintenance = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo_Chap_Maintenance = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.P_NIDRAPPORT_FM_CLI = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XtTab_Entete_TXREA = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Entete_NBEXE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Entete_NBPLA = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Entete_VSITNOM = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Entete_VENSEIGNE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow_Entete_Chap_Maintenance_Tab = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable_Entete_Chap_Maintenance_Tab = New DevExpress.XtraReports.UI.XRTable()
        Me.GH_Chap_Maintenance_Tab = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XCD_03 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_02 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_01 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Data_LOT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Data_VSITNOM = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTab_Data_VENSEIGNE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow_Data_Chap_Maintenance_Tab = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XCD_04 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_05 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_06 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_07 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_08 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_09 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_37 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_38 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_39 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_40 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_41 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_42 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_43 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_44 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_45 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_46 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_47 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_48 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_49 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_51 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XCD_52 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell101 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable_Data_Chap_Maintenance_Tab = New DevExpress.XtraReports.UI.XRTable()
        Me.Detail_Chap_Maintenance_Tab = New DevExpress.XtraReports.UI.DetailBand()
        Me.DR_Chap_Maintenance_Tab = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.P_ANNEE = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.XrTable_Entete_Chap_Maintenance_Tab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable_Data_Chap_Maintenance_Tab, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XrCrossBandBoxBordersAllPage.EndPointFloat = New DevExpress.Utils.PointFloat(0.6250064!, 7.043076!)
        Me.XrCrossBandBoxBordersAllPage.Name = "XrCrossBandBoxBordersAllPage"
        Me.XrCrossBandBoxBordersAllPage.StartBand = Me.TopMargin_Chap_Maintenance
        Me.XrCrossBandBoxBordersAllPage.StartPointFloat = New DevExpress.Utils.PointFloat(0.6250064!, 9.375!)
        Me.XrCrossBandBoxBordersAllPage.WidthF = 1119.375!
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
        Me.XrLblMaintenanceTitle.SizeF = New System.Drawing.SizeF(1099.0!, 23.0!)
        Me.XrLblMaintenanceTitle.StylePriority.UseFont = False
        Me.XrLblMaintenanceTitle.StylePriority.UseForeColor = False
        Me.XrLblMaintenanceTitle.Text = "Planning annuel"
        '
        'SDS_Chap_Maintenance_TabPrev
        '
        Me.SDS_Chap_Maintenance_TabPrev.ConnectionName = "SRV-VMSQLPROD_MULTI_Connection 1"
        Me.SDS_Chap_Maintenance_TabPrev.ConnectionOptions.DbCommandTimeout = 0
        MsSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows
        MsSqlConnectionParameters1.DatabaseName = "MULTI"
        MsSqlConnectionParameters1.ServerName = "SRV-VMSQLPROD"
        Me.SDS_Chap_Maintenance_TabPrev.ConnectionParameters = MsSqlConnectionParameters1
        Me.SDS_Chap_Maintenance_TabPrev.Name = "SDS_Chap_Maintenance_TabPrev"
        StoredProcQuery1.Name = "api_sp_Rapport_FM_Impression_PlanningAnnuelContrat"
        QueryParameter1.Name = "@iAnnee"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("?P_ANNEE", GetType(Integer))
        QueryParameter2.Name = "@nclinum"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("?P_NCLINUM", GetType(Integer))
        QueryParameter3.Name = "@p_ntypecontrat"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("?P_NTYPECONTRAT", GetType(Integer))
        QueryParameter4.Name = "@p_nidrapport_fm_cli"
        QueryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter4.Value = New DevExpress.DataAccess.Expression("?P_NIDRAPPORT_FM_CLI", GetType(Integer))
        StoredProcQuery1.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter1, QueryParameter2, QueryParameter3, QueryParameter4})
        StoredProcQuery1.StoredProcName = "api_sp_Rapport_FM_Impression_PlanningAnnuelContrat"
        Me.SDS_Chap_Maintenance_TabPrev.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SDS_Chap_Maintenance_TabPrev.ResultSchemaSerializable = resources.GetString("SDS_Chap_Maintenance_TabPrev.ResultSchemaSerializable")
        '
        'P_NCLINUM
        '
        Me.P_NCLINUM.Description = "NCLINUM"
        Me.P_NCLINUM.Name = "P_NCLINUM"
        Me.P_NCLINUM.Type = GetType(Integer)
        Me.P_NCLINUM.ValueInfo = "0"
        '
        'P_NTYPECONTRAT
        '
        Me.P_NTYPECONTRAT.Description = "Date Fin sur 12 mois"
        Me.P_NTYPECONTRAT.Name = "P_NTYPECONTRAT"
        Me.P_NTYPECONTRAT.Type = GetType(Date)
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
        Me.XrPageInfo_Chap_Maintenance.SizeF = New System.Drawing.SizeF(1118.958!, 23.0!)
        Me.XrPageInfo_Chap_Maintenance.StylePriority.UseFont = False
        Me.XrPageInfo_Chap_Maintenance.StylePriority.UseTextAlignment = False
        Me.XrPageInfo_Chap_Maintenance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'P_NIDRAPPORT_FM_CLI
        '
        Me.P_NIDRAPPORT_FM_CLI.Description = "NIDRAPPORT_FM_CLI"
        Me.P_NIDRAPPORT_FM_CLI.Name = "P_NIDRAPPORT_FM_CLI"
        Me.P_NIDRAPPORT_FM_CLI.Type = GetType(Integer)
        Me.P_NIDRAPPORT_FM_CLI.ValueInfo = "0"
        '
        'XtTab_Entete_TXREA
        '
        Me.XtTab_Entete_TXREA.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XtTab_Entete_TXREA.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XtTab_Entete_TXREA.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XtTab_Entete_TXREA.ForeColor = System.Drawing.Color.White
        Me.XtTab_Entete_TXREA.Name = "XtTab_Entete_TXREA"
        Me.XtTab_Entete_TXREA.StylePriority.UseBackColor = False
        Me.XtTab_Entete_TXREA.StylePriority.UseBorderColor = False
        Me.XtTab_Entete_TXREA.StylePriority.UseFont = False
        Me.XtTab_Entete_TXREA.StylePriority.UseForeColor = False
        Me.XtTab_Entete_TXREA.Text = "02"
        Me.XtTab_Entete_TXREA.Weight = 0.17166699097372157R
        '
        'XtTab_Entete_NBEXE
        '
        Me.XtTab_Entete_NBEXE.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XtTab_Entete_NBEXE.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XtTab_Entete_NBEXE.ForeColor = System.Drawing.Color.White
        Me.XtTab_Entete_NBEXE.Name = "XtTab_Entete_NBEXE"
        Me.XtTab_Entete_NBEXE.StylePriority.UseBackColor = False
        Me.XtTab_Entete_NBEXE.StylePriority.UseFont = False
        Me.XtTab_Entete_NBEXE.StylePriority.UseForeColor = False
        Me.XtTab_Entete_NBEXE.Text = "01"
        Me.XtTab_Entete_NBEXE.Weight = 0.17166698063651534R
        '
        'XtTab_Entete_NBPLA
        '
        Me.XtTab_Entete_NBPLA.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XtTab_Entete_NBPLA.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XtTab_Entete_NBPLA.ForeColor = System.Drawing.Color.White
        Me.XtTab_Entete_NBPLA.Name = "XtTab_Entete_NBPLA"
        Me.XtTab_Entete_NBPLA.StylePriority.UseBackColor = False
        Me.XtTab_Entete_NBPLA.StylePriority.UseFont = False
        Me.XtTab_Entete_NBPLA.StylePriority.UseForeColor = False
        Me.XtTab_Entete_NBPLA.Text = "Pays"
        Me.XtTab_Entete_NBPLA.Weight = 0.55766321020806009R
        '
        'XtTab_Entete_VSITNOM
        '
        Me.XtTab_Entete_VSITNOM.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XtTab_Entete_VSITNOM.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XtTab_Entete_VSITNOM.ForeColor = System.Drawing.Color.White
        Me.XtTab_Entete_VSITNOM.Name = "XtTab_Entete_VSITNOM"
        Me.XtTab_Entete_VSITNOM.StylePriority.UseBackColor = False
        Me.XtTab_Entete_VSITNOM.StylePriority.UseFont = False
        Me.XtTab_Entete_VSITNOM.StylePriority.UseForeColor = False
        Me.XtTab_Entete_VSITNOM.Text = "N°"
        Me.XtTab_Entete_VSITNOM.Weight = 0.61895653935070749R
        '
        'XtTab_Entete_VENSEIGNE
        '
        Me.XtTab_Entete_VENSEIGNE.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XtTab_Entete_VENSEIGNE.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XtTab_Entete_VENSEIGNE.ForeColor = System.Drawing.Color.White
        Me.XtTab_Entete_VENSEIGNE.Name = "XtTab_Entete_VENSEIGNE"
        Me.XtTab_Entete_VENSEIGNE.StylePriority.UseBackColor = False
        Me.XtTab_Entete_VENSEIGNE.StylePriority.UseFont = False
        Me.XtTab_Entete_VENSEIGNE.StylePriority.UseForeColor = False
        Me.XtTab_Entete_VENSEIGNE.StylePriority.UseTextAlignment = False
        Me.XtTab_Entete_VENSEIGNE.Text = "Site"
        Me.XtTab_Entete_VENSEIGNE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XtTab_Entete_VENSEIGNE.Weight = 0.91091961724249892R
        '
        'XrTableRow_Entete_Chap_Maintenance_Tab
        '
        Me.XrTableRow_Entete_Chap_Maintenance_Tab.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XtTab_Entete_VENSEIGNE, Me.XtTab_Entete_VSITNOM, Me.XtTab_Entete_NBPLA, Me.XtTab_Entete_NBEXE, Me.XtTab_Entete_TXREA, Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell14, Me.XrTableCell15, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell18, Me.XrTableCell19, Me.XrTableCell20, Me.XrTableCell21, Me.XrTableCell22, Me.XrTableCell23, Me.XrTableCell24, Me.XrTableCell25, Me.XrTableCell26, Me.XrTableCell27, Me.XrTableCell28, Me.XrTableCell29, Me.XrTableCell30, Me.XrTableCell31, Me.XrTableCell32, Me.XrTableCell33, Me.XrTableCell34, Me.XrTableCell35, Me.XrTableCell36, Me.XrTableCell37, Me.XrTableCell38, Me.XrTableCell39, Me.XrTableCell40, Me.XrTableCell41, Me.XrTableCell42, Me.XrTableCell43, Me.XrTableCell44, Me.XrTableCell45, Me.XrTableCell46, Me.XrTableCell47, Me.XrTableCell48, Me.XrTableCell49, Me.XrTableCell50, Me.XrTableCell51})
        Me.XrTableRow_Entete_Chap_Maintenance_Tab.Name = "XrTableRow_Entete_Chap_Maintenance_Tab"
        Me.XrTableRow_Entete_Chap_Maintenance_Tab.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell1.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell1.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell1.ForeColor = System.Drawing.Color.White
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBackColor = False
        Me.XrTableCell1.StylePriority.UseBorderColor = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseForeColor = False
        Me.XrTableCell1.Text = "03"
        Me.XrTableCell1.Weight = 0.17166698986212489R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell2.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell2.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell2.ForeColor = System.Drawing.Color.White
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBackColor = False
        Me.XrTableCell2.StylePriority.UseBorderColor = False
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseForeColor = False
        Me.XrTableCell2.Text = "04"
        Me.XrTableCell2.Weight = 0.17166698986212486R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell3.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell3.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell3.ForeColor = System.Drawing.Color.White
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBackColor = False
        Me.XrTableCell3.StylePriority.UseBorderColor = False
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseForeColor = False
        Me.XrTableCell3.Text = "05"
        Me.XrTableCell3.Weight = 0.17166698986212489R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell4.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell4.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell4.ForeColor = System.Drawing.Color.White
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseBackColor = False
        Me.XrTableCell4.StylePriority.UseBorderColor = False
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.StylePriority.UseForeColor = False
        Me.XrTableCell4.Text = "06"
        Me.XrTableCell4.Weight = 0.17166698986212486R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell5.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell5.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell5.ForeColor = System.Drawing.Color.White
        Me.XrTableCell5.Multiline = True
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseBackColor = False
        Me.XrTableCell5.StylePriority.UseBorderColor = False
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UseForeColor = False
        Me.XrTableCell5.Text = "07"
        Me.XrTableCell5.Weight = 0.17166698986212489R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell6.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell6.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell6.ForeColor = System.Drawing.Color.White
        Me.XrTableCell6.Multiline = True
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseBackColor = False
        Me.XrTableCell6.StylePriority.UseBorderColor = False
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.StylePriority.UseForeColor = False
        Me.XrTableCell6.Text = "08"
        Me.XrTableCell6.Weight = 0.17166698986212486R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell7.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell7.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell7.ForeColor = System.Drawing.Color.White
        Me.XrTableCell7.Multiline = True
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseBackColor = False
        Me.XrTableCell7.StylePriority.UseBorderColor = False
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UseForeColor = False
        Me.XrTableCell7.Text = "09"
        Me.XrTableCell7.Weight = 0.17820865121620794R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell8.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell8.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell8.ForeColor = System.Drawing.Color.White
        Me.XrTableCell8.Multiline = True
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBackColor = False
        Me.XrTableCell8.StylePriority.UseBorderColor = False
        Me.XrTableCell8.StylePriority.UseFont = False
        Me.XrTableCell8.StylePriority.UseForeColor = False
        Me.XrTableCell8.Text = "10"
        Me.XrTableCell8.Weight = 0.17166698986212489R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell9.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell9.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell9.ForeColor = System.Drawing.Color.White
        Me.XrTableCell9.Multiline = True
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseBackColor = False
        Me.XrTableCell9.StylePriority.UseBorderColor = False
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UseForeColor = False
        Me.XrTableCell9.Text = "11"
        Me.XrTableCell9.Weight = 0.17166698986212486R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell10.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell10.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell10.ForeColor = System.Drawing.Color.White
        Me.XrTableCell10.Multiline = True
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseBackColor = False
        Me.XrTableCell10.StylePriority.UseBorderColor = False
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.StylePriority.UseForeColor = False
        Me.XrTableCell10.Text = "12"
        Me.XrTableCell10.Weight = 0.17166698986212489R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell11.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell11.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell11.ForeColor = System.Drawing.Color.White
        Me.XrTableCell11.Multiline = True
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseBackColor = False
        Me.XrTableCell11.StylePriority.UseBorderColor = False
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.StylePriority.UseForeColor = False
        Me.XrTableCell11.Text = "13"
        Me.XrTableCell11.Weight = 0.17166698986212486R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell12.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell12.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell12.ForeColor = System.Drawing.Color.White
        Me.XrTableCell12.Multiline = True
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseBackColor = False
        Me.XrTableCell12.StylePriority.UseBorderColor = False
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.StylePriority.UseForeColor = False
        Me.XrTableCell12.Text = "14"
        Me.XrTableCell12.Weight = 0.17166698986212489R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell13.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell13.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell13.ForeColor = System.Drawing.Color.White
        Me.XrTableCell13.Multiline = True
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseBackColor = False
        Me.XrTableCell13.StylePriority.UseBorderColor = False
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.StylePriority.UseForeColor = False
        Me.XrTableCell13.Text = "15"
        Me.XrTableCell13.Weight = 0.17166698986212486R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell14.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell14.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell14.ForeColor = System.Drawing.Color.White
        Me.XrTableCell14.Multiline = True
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseBackColor = False
        Me.XrTableCell14.StylePriority.UseBorderColor = False
        Me.XrTableCell14.StylePriority.UseFont = False
        Me.XrTableCell14.StylePriority.UseForeColor = False
        Me.XrTableCell14.Text = "16"
        Me.XrTableCell14.Weight = 0.17166698986212489R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell15.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell15.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell15.ForeColor = System.Drawing.Color.White
        Me.XrTableCell15.Multiline = True
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.StylePriority.UseBackColor = False
        Me.XrTableCell15.StylePriority.UseBorderColor = False
        Me.XrTableCell15.StylePriority.UseFont = False
        Me.XrTableCell15.StylePriority.UseForeColor = False
        Me.XrTableCell15.Text = "17"
        Me.XrTableCell15.Weight = 0.17166698986212486R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell16.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell16.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell16.ForeColor = System.Drawing.Color.White
        Me.XrTableCell16.Multiline = True
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseBackColor = False
        Me.XrTableCell16.StylePriority.UseBorderColor = False
        Me.XrTableCell16.StylePriority.UseFont = False
        Me.XrTableCell16.StylePriority.UseForeColor = False
        Me.XrTableCell16.Text = "18"
        Me.XrTableCell16.Weight = 0.17166698986212489R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell17.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell17.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell17.ForeColor = System.Drawing.Color.White
        Me.XrTableCell17.Multiline = True
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseBackColor = False
        Me.XrTableCell17.StylePriority.UseBorderColor = False
        Me.XrTableCell17.StylePriority.UseFont = False
        Me.XrTableCell17.StylePriority.UseForeColor = False
        Me.XrTableCell17.Text = "19"
        Me.XrTableCell17.Weight = 0.17166698986212486R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell18.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell18.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell18.ForeColor = System.Drawing.Color.White
        Me.XrTableCell18.Multiline = True
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StylePriority.UseBackColor = False
        Me.XrTableCell18.StylePriority.UseBorderColor = False
        Me.XrTableCell18.StylePriority.UseFont = False
        Me.XrTableCell18.StylePriority.UseForeColor = False
        Me.XrTableCell18.Text = "20"
        Me.XrTableCell18.Weight = 0.17166698986212489R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell19.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell19.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell19.ForeColor = System.Drawing.Color.White
        Me.XrTableCell19.Multiline = True
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.StylePriority.UseBackColor = False
        Me.XrTableCell19.StylePriority.UseBorderColor = False
        Me.XrTableCell19.StylePriority.UseFont = False
        Me.XrTableCell19.StylePriority.UseForeColor = False
        Me.XrTableCell19.Text = "21"
        Me.XrTableCell19.Weight = 0.17166698986212486R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell20.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell20.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell20.ForeColor = System.Drawing.Color.White
        Me.XrTableCell20.Multiline = True
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.StylePriority.UseBackColor = False
        Me.XrTableCell20.StylePriority.UseBorderColor = False
        Me.XrTableCell20.StylePriority.UseFont = False
        Me.XrTableCell20.StylePriority.UseForeColor = False
        Me.XrTableCell20.Text = "22"
        Me.XrTableCell20.Weight = 0.17166698986212489R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell21.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell21.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell21.ForeColor = System.Drawing.Color.White
        Me.XrTableCell21.Multiline = True
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseBackColor = False
        Me.XrTableCell21.StylePriority.UseBorderColor = False
        Me.XrTableCell21.StylePriority.UseFont = False
        Me.XrTableCell21.StylePriority.UseForeColor = False
        Me.XrTableCell21.Text = "23"
        Me.XrTableCell21.Weight = 0.17166698986212486R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell22.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell22.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell22.ForeColor = System.Drawing.Color.White
        Me.XrTableCell22.Multiline = True
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.StylePriority.UseBackColor = False
        Me.XrTableCell22.StylePriority.UseBorderColor = False
        Me.XrTableCell22.StylePriority.UseFont = False
        Me.XrTableCell22.StylePriority.UseForeColor = False
        Me.XrTableCell22.Text = "24"
        Me.XrTableCell22.Weight = 0.17166702151690746R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell23.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell23.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell23.ForeColor = System.Drawing.Color.White
        Me.XrTableCell23.Multiline = True
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.StylePriority.UseBackColor = False
        Me.XrTableCell23.StylePriority.UseBorderColor = False
        Me.XrTableCell23.StylePriority.UseFont = False
        Me.XrTableCell23.StylePriority.UseForeColor = False
        Me.XrTableCell23.Text = "25"
        Me.XrTableCell23.Weight = 0.17166702711337029R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell24.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell24.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell24.ForeColor = System.Drawing.Color.White
        Me.XrTableCell24.Multiline = True
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.StylePriority.UseBackColor = False
        Me.XrTableCell24.StylePriority.UseBorderColor = False
        Me.XrTableCell24.StylePriority.UseFont = False
        Me.XrTableCell24.StylePriority.UseForeColor = False
        Me.XrTableCell24.Text = "26"
        Me.XrTableCell24.Weight = 0.17166702711337031R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell25.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell25.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell25.ForeColor = System.Drawing.Color.White
        Me.XrTableCell25.Multiline = True
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.StylePriority.UseBackColor = False
        Me.XrTableCell25.StylePriority.UseBorderColor = False
        Me.XrTableCell25.StylePriority.UseFont = False
        Me.XrTableCell25.StylePriority.UseForeColor = False
        Me.XrTableCell25.Text = "27"
        Me.XrTableCell25.Weight = 0.17166702711337034R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell26.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell26.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell26.ForeColor = System.Drawing.Color.White
        Me.XrTableCell26.Multiline = True
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.StylePriority.UseBackColor = False
        Me.XrTableCell26.StylePriority.UseBorderColor = False
        Me.XrTableCell26.StylePriority.UseFont = False
        Me.XrTableCell26.StylePriority.UseForeColor = False
        Me.XrTableCell26.Text = "28"
        Me.XrTableCell26.Weight = 0.17166702711337029R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell27.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell27.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell27.ForeColor = System.Drawing.Color.White
        Me.XrTableCell27.Multiline = True
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.StylePriority.UseBackColor = False
        Me.XrTableCell27.StylePriority.UseBorderColor = False
        Me.XrTableCell27.StylePriority.UseFont = False
        Me.XrTableCell27.StylePriority.UseForeColor = False
        Me.XrTableCell27.Text = "29"
        Me.XrTableCell27.Weight = 0.17166702711337031R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell28.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell28.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell28.ForeColor = System.Drawing.Color.White
        Me.XrTableCell28.Multiline = True
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.StylePriority.UseBackColor = False
        Me.XrTableCell28.StylePriority.UseBorderColor = False
        Me.XrTableCell28.StylePriority.UseFont = False
        Me.XrTableCell28.StylePriority.UseForeColor = False
        Me.XrTableCell28.Text = "30"
        Me.XrTableCell28.Weight = 0.17166702711337029R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell29.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell29.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell29.ForeColor = System.Drawing.Color.White
        Me.XrTableCell29.Multiline = True
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.StylePriority.UseBackColor = False
        Me.XrTableCell29.StylePriority.UseBorderColor = False
        Me.XrTableCell29.StylePriority.UseFont = False
        Me.XrTableCell29.StylePriority.UseForeColor = False
        Me.XrTableCell29.Text = "31"
        Me.XrTableCell29.Weight = 0.17166702711337029R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell30.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell30.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell30.ForeColor = System.Drawing.Color.White
        Me.XrTableCell30.Multiline = True
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.StylePriority.UseBackColor = False
        Me.XrTableCell30.StylePriority.UseBorderColor = False
        Me.XrTableCell30.StylePriority.UseFont = False
        Me.XrTableCell30.StylePriority.UseForeColor = False
        Me.XrTableCell30.Text = "32"
        Me.XrTableCell30.Weight = 0.17166702711337034R
        '
        'XrTableCell31
        '
        Me.XrTableCell31.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell31.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell31.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell31.ForeColor = System.Drawing.Color.White
        Me.XrTableCell31.Multiline = True
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.StylePriority.UseBackColor = False
        Me.XrTableCell31.StylePriority.UseBorderColor = False
        Me.XrTableCell31.StylePriority.UseFont = False
        Me.XrTableCell31.StylePriority.UseForeColor = False
        Me.XrTableCell31.Text = "33"
        Me.XrTableCell31.Weight = 0.17166702711337031R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell32.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell32.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell32.ForeColor = System.Drawing.Color.White
        Me.XrTableCell32.Multiline = True
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.StylePriority.UseBackColor = False
        Me.XrTableCell32.StylePriority.UseBorderColor = False
        Me.XrTableCell32.StylePriority.UseFont = False
        Me.XrTableCell32.StylePriority.UseForeColor = False
        Me.XrTableCell32.Text = "34"
        Me.XrTableCell32.Weight = 0.1716670271133702R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell33.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell33.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell33.ForeColor = System.Drawing.Color.White
        Me.XrTableCell33.Multiline = True
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.StylePriority.UseBackColor = False
        Me.XrTableCell33.StylePriority.UseBorderColor = False
        Me.XrTableCell33.StylePriority.UseFont = False
        Me.XrTableCell33.StylePriority.UseForeColor = False
        Me.XrTableCell33.Text = "35"
        Me.XrTableCell33.Weight = 0.17166702711337034R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell34.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell34.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell34.ForeColor = System.Drawing.Color.White
        Me.XrTableCell34.Multiline = True
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.StylePriority.UseBackColor = False
        Me.XrTableCell34.StylePriority.UseBorderColor = False
        Me.XrTableCell34.StylePriority.UseFont = False
        Me.XrTableCell34.StylePriority.UseForeColor = False
        Me.XrTableCell34.Text = "36"
        Me.XrTableCell34.Weight = 0.17166702711337026R
        '
        'XrTableCell35
        '
        Me.XrTableCell35.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell35.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell35.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell35.ForeColor = System.Drawing.Color.White
        Me.XrTableCell35.Multiline = True
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.StylePriority.UseBackColor = False
        Me.XrTableCell35.StylePriority.UseBorderColor = False
        Me.XrTableCell35.StylePriority.UseFont = False
        Me.XrTableCell35.StylePriority.UseForeColor = False
        Me.XrTableCell35.Text = "37"
        Me.XrTableCell35.Weight = 0.17166702711337023R
        '
        'XrTableCell36
        '
        Me.XrTableCell36.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell36.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell36.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell36.ForeColor = System.Drawing.Color.White
        Me.XrTableCell36.Multiline = True
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.StylePriority.UseBackColor = False
        Me.XrTableCell36.StylePriority.UseBorderColor = False
        Me.XrTableCell36.StylePriority.UseFont = False
        Me.XrTableCell36.StylePriority.UseForeColor = False
        Me.XrTableCell36.Text = "38"
        Me.XrTableCell36.Weight = 0.17166702711337034R
        '
        'XrTableCell37
        '
        Me.XrTableCell37.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell37.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell37.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell37.ForeColor = System.Drawing.Color.White
        Me.XrTableCell37.Multiline = True
        Me.XrTableCell37.Name = "XrTableCell37"
        Me.XrTableCell37.StylePriority.UseBackColor = False
        Me.XrTableCell37.StylePriority.UseBorderColor = False
        Me.XrTableCell37.StylePriority.UseFont = False
        Me.XrTableCell37.StylePriority.UseForeColor = False
        Me.XrTableCell37.Text = "39"
        Me.XrTableCell37.Weight = 0.17166702711337023R
        '
        'XrTableCell38
        '
        Me.XrTableCell38.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell38.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell38.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell38.ForeColor = System.Drawing.Color.White
        Me.XrTableCell38.Multiline = True
        Me.XrTableCell38.Name = "XrTableCell38"
        Me.XrTableCell38.StylePriority.UseBackColor = False
        Me.XrTableCell38.StylePriority.UseBorderColor = False
        Me.XrTableCell38.StylePriority.UseFont = False
        Me.XrTableCell38.StylePriority.UseForeColor = False
        Me.XrTableCell38.Text = "40"
        Me.XrTableCell38.Weight = 0.17166702711337037R
        '
        'XrTableCell39
        '
        Me.XrTableCell39.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell39.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell39.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell39.ForeColor = System.Drawing.Color.White
        Me.XrTableCell39.Multiline = True
        Me.XrTableCell39.Name = "XrTableCell39"
        Me.XrTableCell39.StylePriority.UseBackColor = False
        Me.XrTableCell39.StylePriority.UseBorderColor = False
        Me.XrTableCell39.StylePriority.UseFont = False
        Me.XrTableCell39.StylePriority.UseForeColor = False
        Me.XrTableCell39.Text = "41"
        Me.XrTableCell39.Weight = 0.17166702711337023R
        '
        'XrTableCell40
        '
        Me.XrTableCell40.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell40.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell40.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell40.ForeColor = System.Drawing.Color.White
        Me.XrTableCell40.Multiline = True
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.StylePriority.UseBackColor = False
        Me.XrTableCell40.StylePriority.UseBorderColor = False
        Me.XrTableCell40.StylePriority.UseFont = False
        Me.XrTableCell40.StylePriority.UseForeColor = False
        Me.XrTableCell40.Text = "42"
        Me.XrTableCell40.Weight = 0.17166702711337037R
        '
        'XrTableCell41
        '
        Me.XrTableCell41.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell41.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell41.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell41.ForeColor = System.Drawing.Color.White
        Me.XrTableCell41.Multiline = True
        Me.XrTableCell41.Name = "XrTableCell41"
        Me.XrTableCell41.StylePriority.UseBackColor = False
        Me.XrTableCell41.StylePriority.UseBorderColor = False
        Me.XrTableCell41.StylePriority.UseFont = False
        Me.XrTableCell41.StylePriority.UseForeColor = False
        Me.XrTableCell41.Text = "43"
        Me.XrTableCell41.Weight = 0.17166702711337023R
        '
        'XrTableCell42
        '
        Me.XrTableCell42.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell42.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell42.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell42.ForeColor = System.Drawing.Color.White
        Me.XrTableCell42.Multiline = True
        Me.XrTableCell42.Name = "XrTableCell42"
        Me.XrTableCell42.StylePriority.UseBackColor = False
        Me.XrTableCell42.StylePriority.UseBorderColor = False
        Me.XrTableCell42.StylePriority.UseFont = False
        Me.XrTableCell42.StylePriority.UseForeColor = False
        Me.XrTableCell42.Text = "44"
        Me.XrTableCell42.Weight = 0.17166702711337026R
        '
        'XrTableCell43
        '
        Me.XrTableCell43.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell43.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell43.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell43.ForeColor = System.Drawing.Color.White
        Me.XrTableCell43.Multiline = True
        Me.XrTableCell43.Name = "XrTableCell43"
        Me.XrTableCell43.StylePriority.UseBackColor = False
        Me.XrTableCell43.StylePriority.UseBorderColor = False
        Me.XrTableCell43.StylePriority.UseFont = False
        Me.XrTableCell43.StylePriority.UseForeColor = False
        Me.XrTableCell43.Text = "45"
        Me.XrTableCell43.Weight = 0.17166702711337012R
        '
        'XrTableCell44
        '
        Me.XrTableCell44.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell44.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell44.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell44.ForeColor = System.Drawing.Color.White
        Me.XrTableCell44.Multiline = True
        Me.XrTableCell44.Name = "XrTableCell44"
        Me.XrTableCell44.StylePriority.UseBackColor = False
        Me.XrTableCell44.StylePriority.UseBorderColor = False
        Me.XrTableCell44.StylePriority.UseFont = False
        Me.XrTableCell44.StylePriority.UseForeColor = False
        Me.XrTableCell44.Text = "46"
        Me.XrTableCell44.Weight = 0.17166702711337037R
        '
        'XrTableCell45
        '
        Me.XrTableCell45.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell45.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell45.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell45.ForeColor = System.Drawing.Color.White
        Me.XrTableCell45.Multiline = True
        Me.XrTableCell45.Name = "XrTableCell45"
        Me.XrTableCell45.StylePriority.UseBackColor = False
        Me.XrTableCell45.StylePriority.UseBorderColor = False
        Me.XrTableCell45.StylePriority.UseFont = False
        Me.XrTableCell45.StylePriority.UseForeColor = False
        Me.XrTableCell45.Text = "47"
        Me.XrTableCell45.Weight = 0.17166702711332896R
        '
        'XrTableCell46
        '
        Me.XrTableCell46.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell46.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell46.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell46.ForeColor = System.Drawing.Color.White
        Me.XrTableCell46.Multiline = True
        Me.XrTableCell46.Name = "XrTableCell46"
        Me.XrTableCell46.StylePriority.UseBackColor = False
        Me.XrTableCell46.StylePriority.UseBorderColor = False
        Me.XrTableCell46.StylePriority.UseFont = False
        Me.XrTableCell46.StylePriority.UseForeColor = False
        Me.XrTableCell46.Text = "48"
        Me.XrTableCell46.Weight = 0.17166702711332896R
        '
        'XrTableCell47
        '
        Me.XrTableCell47.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell47.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell47.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell47.ForeColor = System.Drawing.Color.White
        Me.XrTableCell47.Multiline = True
        Me.XrTableCell47.Name = "XrTableCell47"
        Me.XrTableCell47.StylePriority.UseBackColor = False
        Me.XrTableCell47.StylePriority.UseBorderColor = False
        Me.XrTableCell47.StylePriority.UseFont = False
        Me.XrTableCell47.StylePriority.UseForeColor = False
        Me.XrTableCell47.Text = "49"
        Me.XrTableCell47.Weight = 0.17166702711332896R
        '
        'XrTableCell48
        '
        Me.XrTableCell48.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell48.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell48.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell48.ForeColor = System.Drawing.Color.White
        Me.XrTableCell48.Multiline = True
        Me.XrTableCell48.Name = "XrTableCell48"
        Me.XrTableCell48.StylePriority.UseBackColor = False
        Me.XrTableCell48.StylePriority.UseBorderColor = False
        Me.XrTableCell48.StylePriority.UseFont = False
        Me.XrTableCell48.StylePriority.UseForeColor = False
        Me.XrTableCell48.Text = "50"
        Me.XrTableCell48.Weight = 0.17166702711332896R
        '
        'XrTableCell49
        '
        Me.XrTableCell49.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell49.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell49.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell49.ForeColor = System.Drawing.Color.White
        Me.XrTableCell49.Multiline = True
        Me.XrTableCell49.Name = "XrTableCell49"
        Me.XrTableCell49.StylePriority.UseBackColor = False
        Me.XrTableCell49.StylePriority.UseBorderColor = False
        Me.XrTableCell49.StylePriority.UseFont = False
        Me.XrTableCell49.StylePriority.UseForeColor = False
        Me.XrTableCell49.Text = "51"
        Me.XrTableCell49.Weight = 0.17166702711332896R
        '
        'XrTableCell50
        '
        Me.XrTableCell50.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell50.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell50.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell50.ForeColor = System.Drawing.Color.White
        Me.XrTableCell50.Multiline = True
        Me.XrTableCell50.Name = "XrTableCell50"
        Me.XrTableCell50.StylePriority.UseBackColor = False
        Me.XrTableCell50.StylePriority.UseBorderColor = False
        Me.XrTableCell50.StylePriority.UseFont = False
        Me.XrTableCell50.StylePriority.UseForeColor = False
        Me.XrTableCell50.Text = "52"
        Me.XrTableCell50.Weight = 0.17166702711332896R
        '
        'XrTableCell51
        '
        Me.XrTableCell51.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.XrTableCell51.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XrTableCell51.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell51.ForeColor = System.Drawing.Color.White
        Me.XrTableCell51.Multiline = True
        Me.XrTableCell51.Name = "XrTableCell51"
        Me.XrTableCell51.StylePriority.UseBackColor = False
        Me.XrTableCell51.StylePriority.UseBorderColor = False
        Me.XrTableCell51.StylePriority.UseFont = False
        Me.XrTableCell51.StylePriority.UseForeColor = False
        Me.XrTableCell51.Text = "NB"
        Me.XrTableCell51.Weight = 0.26170973045468549R
        '
        'XrTable_Entete_Chap_Maintenance_Tab
        '
        Me.XrTable_Entete_Chap_Maintenance_Tab.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.XrTable_Entete_Chap_Maintenance_Tab.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTable_Entete_Chap_Maintenance_Tab.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable_Entete_Chap_Maintenance_Tab.BorderWidth = 0.5!
        Me.XrTable_Entete_Chap_Maintenance_Tab.Font = New DevExpress.Drawing.DXFont("Century Gothic", 5.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTable_Entete_Chap_Maintenance_Tab.LocationFloat = New DevExpress.Utils.PointFloat(1.666662!, 9.999998!)
        Me.XrTable_Entete_Chap_Maintenance_Tab.Name = "XrTable_Entete_Chap_Maintenance_Tab"
        Me.XrTable_Entete_Chap_Maintenance_Tab.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow_Entete_Chap_Maintenance_Tab})
        Me.XrTable_Entete_Chap_Maintenance_Tab.SizeF = New System.Drawing.SizeF(1117.291!, 35.41667!)
        Me.XrTable_Entete_Chap_Maintenance_Tab.StylePriority.UseBackColor = False
        Me.XrTable_Entete_Chap_Maintenance_Tab.StylePriority.UseBorderColor = False
        Me.XrTable_Entete_Chap_Maintenance_Tab.StylePriority.UseBorders = False
        Me.XrTable_Entete_Chap_Maintenance_Tab.StylePriority.UseBorderWidth = False
        Me.XrTable_Entete_Chap_Maintenance_Tab.StylePriority.UseFont = False
        Me.XrTable_Entete_Chap_Maintenance_Tab.StylePriority.UseTextAlignment = False
        Me.XrTable_Entete_Chap_Maintenance_Tab.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GH_Chap_Maintenance_Tab
        '
        Me.GH_Chap_Maintenance_Tab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable_Entete_Chap_Maintenance_Tab})
        Me.GH_Chap_Maintenance_Tab.HeightF = 45.41667!
        Me.GH_Chap_Maintenance_Tab.Name = "GH_Chap_Maintenance_Tab"
        Me.GH_Chap_Maintenance_Tab.RepeatEveryPage = True
        '
        'XCD_03
        '
        Me.XCD_03.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM3]")})
        Me.XCD_03.Name = "XCD_03"
        Me.XCD_03.Text = "XCD_03"
        Me.XCD_03.TextFormatString = "{0:0%}"
        Me.XCD_03.Weight = 0.07468381535698132R
        '
        'XCD_02
        '
        Me.XCD_02.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM2]")})
        Me.XCD_02.Name = "XCD_02"
        Me.XCD_02.Text = "XCD_02"
        Me.XCD_02.TextFormatString = "{0:n0}"
        Me.XCD_02.Weight = 0.074683547622094615R
        '
        'XCD_01
        '
        Me.XCD_01.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM1]")})
        Me.XCD_01.Name = "XCD_01"
        Me.XCD_01.Text = "XCD_01"
        Me.XCD_01.TextFormatString = "{0:n0}"
        Me.XCD_01.Weight = 0.074683683205250873R
        '
        'XtTab_Data_LOT
        '
        Me.XtTab_Data_LOT.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VSITPAYS]")})
        Me.XtTab_Data_LOT.Name = "XtTab_Data_LOT"
        Me.XtTab_Data_LOT.Text = "XtTab_Data_LOT"
        Me.XtTab_Data_LOT.Weight = 0.24261116323070531R
        '
        'XtTab_Data_VSITNOM
        '
        Me.XtTab_Data_VSITNOM.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NSITNUE]")})
        Me.XtTab_Data_VSITNOM.Name = "XtTab_Data_VSITNOM"
        Me.XtTab_Data_VSITNOM.Text = "XtTab_Data_VSITNOM"
        Me.XtTab_Data_VSITNOM.Weight = 0.26927689805452693R
        '
        'XtTab_Data_VENSEIGNE
        '
        Me.XtTab_Data_VENSEIGNE.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VSITNOM]")})
        Me.XtTab_Data_VENSEIGNE.Name = "XtTab_Data_VENSEIGNE"
        Me.XtTab_Data_VENSEIGNE.Text = "XtTab_Data_VENSEIGNE"
        Me.XtTab_Data_VENSEIGNE.Weight = 0.39629531553996916R
        '
        'XrTableRow_Data_Chap_Maintenance_Tab
        '
        Me.XrTableRow_Data_Chap_Maintenance_Tab.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XtTab_Data_VENSEIGNE, Me.XtTab_Data_VSITNOM, Me.XtTab_Data_LOT, Me.XCD_01, Me.XCD_02, Me.XCD_03, Me.XCD_04, Me.XCD_05, Me.XCD_06, Me.XCD_07, Me.XCD_08, Me.XCD_09, Me.XCD_10, Me.XCD_11, Me.XCD_12, Me.XCD_13, Me.XCD_14, Me.XCD_15, Me.XCD_16, Me.XCD_17, Me.XCD_18, Me.XCD_19, Me.XCD_20, Me.XCD_21, Me.XCD_22, Me.XCD_23, Me.XCD_24, Me.XCD_25, Me.XCD_26, Me.XCD_27, Me.XCD_28, Me.XCD_29, Me.XCD_30, Me.XCD_31, Me.XCD_32, Me.XCD_33, Me.XCD_34, Me.XCD_35, Me.XCD_36, Me.XCD_37, Me.XCD_38, Me.XCD_39, Me.XCD_40, Me.XCD_41, Me.XCD_42, Me.XCD_43, Me.XCD_44, Me.XCD_45, Me.XCD_46, Me.XCD_47, Me.XCD_48, Me.XCD_49, Me.XCD_50, Me.XCD_51, Me.XCD_52, Me.XrTableCell101})
        Me.XrTableRow_Data_Chap_Maintenance_Tab.Name = "XrTableRow_Data_Chap_Maintenance_Tab"
        Me.XrTableRow_Data_Chap_Maintenance_Tab.Weight = 11.5R
        '
        'XCD_04
        '
        Me.XCD_04.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM4]")})
        Me.XCD_04.Multiline = True
        Me.XCD_04.Name = "XCD_04"
        Me.XCD_04.Text = "XCD_04"
        Me.XCD_04.Weight = 0.07468381535698132R
        '
        'XCD_05
        '
        Me.XCD_05.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM5]")})
        Me.XCD_05.Multiline = True
        Me.XCD_05.Name = "XCD_05"
        Me.XCD_05.Text = "XCD_05"
        Me.XCD_05.Weight = 0.07468381535698132R
        '
        'XCD_06
        '
        Me.XCD_06.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM6]")})
        Me.XCD_06.Multiline = True
        Me.XCD_06.Name = "XCD_06"
        Me.XCD_06.Text = "XCD_06"
        Me.XCD_06.Weight = 0.07468381535698132R
        '
        'XCD_07
        '
        Me.XCD_07.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM7]")})
        Me.XCD_07.Multiline = True
        Me.XCD_07.Name = "XCD_07"
        Me.XCD_07.Text = "XCD_07"
        Me.XCD_07.Weight = 0.07468381535698132R
        '
        'XCD_08
        '
        Me.XCD_08.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM8]")})
        Me.XCD_08.Multiline = True
        Me.XCD_08.Name = "XCD_08"
        Me.XCD_08.Text = "XCD_08"
        Me.XCD_08.Weight = 0.07468381535698132R
        '
        'XCD_09
        '
        Me.XCD_09.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM9]")})
        Me.XCD_09.Multiline = True
        Me.XCD_09.Name = "XCD_09"
        Me.XCD_09.Text = "XCD_09"
        Me.XCD_09.Weight = 0.077528170016469555R
        '
        'XCD_10
        '
        Me.XCD_10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM10]")})
        Me.XCD_10.Multiline = True
        Me.XCD_10.Name = "XCD_10"
        Me.XCD_10.Text = "XCD_10"
        Me.XCD_10.Weight = 0.07468363939212086R
        '
        'XCD_11
        '
        Me.XCD_11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM11]")})
        Me.XCD_11.Multiline = True
        Me.XCD_11.Name = "XCD_11"
        Me.XCD_11.Text = "XCD_11"
        Me.XCD_11.Weight = 0.07468363939212086R
        '
        'XCD_12
        '
        Me.XCD_12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM12]")})
        Me.XCD_12.Multiline = True
        Me.XCD_12.Name = "XCD_12"
        Me.XCD_12.Text = "XCD_12"
        Me.XCD_12.Weight = 0.074683505323655738R
        '
        'XCD_13
        '
        Me.XCD_13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM13]")})
        Me.XCD_13.Multiline = True
        Me.XCD_13.Name = "XCD_13"
        Me.XCD_13.Text = "XCD_13"
        Me.XCD_13.Weight = 0.07468363939212086R
        '
        'XCD_14
        '
        Me.XCD_14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM14]")})
        Me.XCD_14.Multiline = True
        Me.XCD_14.Name = "XCD_14"
        Me.XCD_14.Text = "XCD_14"
        Me.XCD_14.Weight = 0.074683773460585967R
        '
        'XCD_15
        '
        Me.XCD_15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM15]")})
        Me.XCD_15.Multiline = True
        Me.XCD_15.Name = "XCD_15"
        Me.XCD_15.Text = "XCD_15"
        Me.XCD_15.Weight = 0.07468363939212086R
        '
        'XCD_16
        '
        Me.XCD_16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM16]")})
        Me.XCD_16.Multiline = True
        Me.XCD_16.Name = "XCD_16"
        Me.XCD_16.Text = "XCD_16"
        Me.XCD_16.Weight = 0.07468363939212086R
        '
        'XCD_17
        '
        Me.XCD_17.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM17]")})
        Me.XCD_17.Multiline = True
        Me.XCD_17.Name = "XCD_17"
        Me.XCD_17.Text = "XCD_17"
        Me.XCD_17.Weight = 0.074683773460585967R
        '
        'XCD_18
        '
        Me.XCD_18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM18]")})
        Me.XCD_18.Multiline = True
        Me.XCD_18.Name = "XCD_18"
        Me.XCD_18.Text = "XCD_18"
        Me.XCD_18.Weight = 0.074683371255190631R
        '
        'XCD_19
        '
        Me.XCD_19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM19]")})
        Me.XCD_19.Multiline = True
        Me.XCD_19.Name = "XCD_19"
        Me.XCD_19.Text = "XCD_19"
        Me.XCD_19.Weight = 0.074684175665981317R
        '
        'XCD_20
        '
        Me.XCD_20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM20]")})
        Me.XCD_20.Multiline = True
        Me.XCD_20.Name = "XCD_20"
        Me.XCD_20.Text = "XCD_20"
        Me.XCD_20.Weight = 0.07468363939212086R
        '
        'XCD_21
        '
        Me.XCD_21.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM21]")})
        Me.XCD_21.Multiline = True
        Me.XCD_21.Name = "XCD_21"
        Me.XCD_21.Text = "XCD_21"
        Me.XCD_21.Weight = 0.074683639392120846R
        '
        'XCD_22
        '
        Me.XCD_22.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM22]")})
        Me.XCD_22.Multiline = True
        Me.XCD_22.Name = "XCD_22"
        Me.XCD_22.Text = "XCD_22"
        Me.XCD_22.Weight = 0.07468363939212086R
        '
        'XCD_23
        '
        Me.XCD_23.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM23]")})
        Me.XCD_23.Multiline = True
        Me.XCD_23.Name = "XCD_23"
        Me.XCD_23.Text = "XCD_23"
        Me.XCD_23.Weight = 0.074683907529051088R
        '
        'XCD_24
        '
        Me.XCD_24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM24]")})
        Me.XCD_24.Multiline = True
        Me.XCD_24.Name = "XCD_24"
        Me.XCD_24.Text = "XCD_24"
        Me.XCD_24.Weight = 0.074683371255190617R
        '
        'XCD_25
        '
        Me.XCD_25.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM25]")})
        Me.XCD_25.Multiline = True
        Me.XCD_25.Name = "XCD_25"
        Me.XCD_25.Text = "XCD_25"
        Me.XCD_25.Weight = 0.074683639392120846R
        '
        'XCD_26
        '
        Me.XCD_26.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM26]")})
        Me.XCD_26.Multiline = True
        Me.XCD_26.Name = "XCD_26"
        Me.XCD_26.Text = "XCD_26"
        Me.XCD_26.Weight = 0.07468363939212086R
        '
        'XCD_27
        '
        Me.XCD_27.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM27]")})
        Me.XCD_27.Multiline = True
        Me.XCD_27.Name = "XCD_27"
        Me.XCD_27.Text = "XCD_27"
        Me.XCD_27.Weight = 0.07468363939212086R
        '
        'XCD_28
        '
        Me.XCD_28.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM28]")})
        Me.XCD_28.Multiline = True
        Me.XCD_28.Name = "XCD_28"
        Me.XCD_28.Text = "XCD_28"
        Me.XCD_28.Weight = 0.07468363939212086R
        '
        'XCD_29
        '
        Me.XCD_29.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM29]")})
        Me.XCD_29.Multiline = True
        Me.XCD_29.Name = "XCD_29"
        Me.XCD_29.Text = "XCD_29"
        Me.XCD_29.Weight = 0.07468363939212086R
        '
        'XCD_30
        '
        Me.XCD_30.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM30]")})
        Me.XCD_30.Multiline = True
        Me.XCD_30.Name = "XCD_30"
        Me.XCD_30.Text = "XCD_30"
        Me.XCD_30.Weight = 0.074682776326376668R
        '
        'XCD_31
        '
        Me.XCD_31.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM31]")})
        Me.XCD_31.Multiline = True
        Me.XCD_31.Name = "XCD_31"
        Me.XCD_31.Text = "XCD_31"
        Me.XCD_31.Weight = 0.074684175665981317R
        '
        'XCD_32
        '
        Me.XCD_32.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM32]")})
        Me.XCD_32.Multiline = True
        Me.XCD_32.Name = "XCD_32"
        Me.XCD_32.Text = "XCD_32"
        Me.XCD_32.Weight = 0.07468363939212086R
        '
        'XCD_33
        '
        Me.XCD_33.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM33]")})
        Me.XCD_33.Multiline = True
        Me.XCD_33.Name = "XCD_33"
        Me.XCD_33.Text = "XCD_33"
        Me.XCD_33.Weight = 0.07468363939212086R
        '
        'XCD_34
        '
        Me.XCD_34.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM34]")})
        Me.XCD_34.Multiline = True
        Me.XCD_34.Name = "XCD_34"
        Me.XCD_34.Text = "XCD_34"
        Me.XCD_34.Weight = 0.07468363939212086R
        '
        'XCD_35
        '
        Me.XCD_35.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM35]")})
        Me.XCD_35.Multiline = True
        Me.XCD_35.Name = "XCD_35"
        Me.XCD_35.Text = "XCD_35"
        Me.XCD_35.Weight = 0.07468363939212086R
        '
        'XCD_36
        '
        Me.XCD_36.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM36]")})
        Me.XCD_36.Multiline = True
        Me.XCD_36.Name = "XCD_36"
        Me.XCD_36.Text = "XCD_36"
        Me.XCD_36.Weight = 0.07468363939212086R
        '
        'XCD_37
        '
        Me.XCD_37.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM37]")})
        Me.XCD_37.Multiline = True
        Me.XCD_37.Name = "XCD_37"
        Me.XCD_37.Text = "XCD_37"
        Me.XCD_37.Weight = 0.0718440441631442R
        '
        'XCD_38
        '
        Me.XCD_38.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM38]")})
        Me.XCD_38.Multiline = True
        Me.XCD_38.Name = "XCD_38"
        Me.XCD_38.Text = "XCD_38"
        Me.XCD_38.Weight = 0.074683907529051088R
        '
        'XCD_39
        '
        Me.XCD_39.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM39]")})
        Me.XCD_39.Multiline = True
        Me.XCD_39.Name = "XCD_39"
        Me.XCD_39.Text = "XCD_39"
        Me.XCD_39.Weight = 0.0775232094832603R
        '
        'XCD_40
        '
        Me.XCD_40.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM40]")})
        Me.XCD_40.Multiline = True
        Me.XCD_40.Name = "XCD_40"
        Me.XCD_40.Text = "XCD_40"
        Me.XCD_40.Weight = 0.074683907529051088R
        '
        'XCD_41
        '
        Me.XCD_41.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM41]")})
        Me.XCD_41.Multiline = True
        Me.XCD_41.Name = "XCD_41"
        Me.XCD_41.Text = "XCD_41"
        Me.XCD_41.Weight = 0.074683103118260388R
        '
        'XCD_42
        '
        Me.XCD_42.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM42]")})
        Me.XCD_42.Multiline = True
        Me.XCD_42.Name = "XCD_42"
        Me.XCD_42.Text = "XCD_42"
        Me.XCD_42.Weight = 0.07468363939212086R
        '
        'XCD_43
        '
        Me.XCD_43.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM43]")})
        Me.XCD_43.Multiline = True
        Me.XCD_43.Name = "XCD_43"
        Me.XCD_43.Text = "XCD_43"
        Me.XCD_43.Weight = 0.07468363939212086R
        '
        'XCD_44
        '
        Me.XCD_44.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM44]")})
        Me.XCD_44.Multiline = True
        Me.XCD_44.Name = "XCD_44"
        Me.XCD_44.Text = "XCD_44"
        Me.XCD_44.Weight = 0.074683371255190631R
        '
        'XCD_45
        '
        Me.XCD_45.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM45]")})
        Me.XCD_45.Multiline = True
        Me.XCD_45.Name = "XCD_45"
        Me.XCD_45.Text = "XCD_45"
        Me.XCD_45.Weight = 0.074684175665981317R
        '
        'XCD_46
        '
        Me.XCD_46.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM46]")})
        Me.XCD_46.Multiline = True
        Me.XCD_46.Name = "XCD_46"
        Me.XCD_46.Text = "XCD_46"
        Me.XCD_46.Weight = 0.074683371255190617R
        '
        'XCD_47
        '
        Me.XCD_47.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM47]")})
        Me.XCD_47.Multiline = True
        Me.XCD_47.Name = "XCD_47"
        Me.XCD_47.Text = "XCD_47"
        Me.XCD_47.Weight = 0.074683907529051088R
        '
        'XCD_48
        '
        Me.XCD_48.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM48]")})
        Me.XCD_48.Multiline = True
        Me.XCD_48.Name = "XCD_48"
        Me.XCD_48.Text = "XCD_48"
        Me.XCD_48.Weight = 0.07468363939212086R
        '
        'XCD_49
        '
        Me.XCD_49.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM49]")})
        Me.XCD_49.Multiline = True
        Me.XCD_49.Name = "XCD_49"
        Me.XCD_49.Text = "XCD_49"
        Me.XCD_49.Weight = 0.07468363939212086R
        '
        'XCD_50
        '
        Me.XCD_50.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM50]")})
        Me.XCD_50.Multiline = True
        Me.XCD_50.Name = "XCD_50"
        Me.XCD_50.Text = "XCD_50"
        Me.XCD_50.Weight = 0.074683103118260388R
        '
        'XCD_51
        '
        Me.XCD_51.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM51]")})
        Me.XCD_51.Multiline = True
        Me.XCD_51.Name = "XCD_51"
        Me.XCD_51.Text = "XCD_51"
        Me.XCD_51.Weight = 0.07468363939212086R
        '
        'XCD_52
        '
        Me.XCD_52.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CSEM52]")})
        Me.XCD_52.Multiline = True
        Me.XCD_52.Name = "XCD_52"
        Me.XCD_52.Text = "XCD_52"
        Me.XCD_52.Weight = 0.07468363939212086R
        '
        'XrTableCell101
        '
        Me.XrTableCell101.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[total]")})
        Me.XrTableCell101.Multiline = True
        Me.XrTableCell101.Name = "XrTableCell101"
        Me.XrTableCell101.Text = "XrTableCell101"
        Me.XrTableCell101.Weight = 0.11385679418079879R
        '
        'XrTable_Data_Chap_Maintenance_Tab
        '
        Me.XrTable_Data_Chap_Maintenance_Tab.BorderColor = System.Drawing.Color.DarkGray
        Me.XrTable_Data_Chap_Maintenance_Tab.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable_Data_Chap_Maintenance_Tab.BorderWidth = 0.5!
        Me.XrTable_Data_Chap_Maintenance_Tab.Font = New DevExpress.Drawing.DXFont("Century Gothic", 6.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTable_Data_Chap_Maintenance_Tab.LocationFloat = New DevExpress.Utils.PointFloat(1.666656!, 0!)
        Me.XrTable_Data_Chap_Maintenance_Tab.Name = "XrTable_Data_Chap_Maintenance_Tab"
        Me.XrTable_Data_Chap_Maintenance_Tab.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow_Data_Chap_Maintenance_Tab})
        Me.XrTable_Data_Chap_Maintenance_Tab.SizeF = New System.Drawing.SizeF(1117.291!, 15.0!)
        Me.XrTable_Data_Chap_Maintenance_Tab.StylePriority.UseBorderColor = False
        Me.XrTable_Data_Chap_Maintenance_Tab.StylePriority.UseBorders = False
        Me.XrTable_Data_Chap_Maintenance_Tab.StylePriority.UseBorderWidth = False
        Me.XrTable_Data_Chap_Maintenance_Tab.StylePriority.UseFont = False
        Me.XrTable_Data_Chap_Maintenance_Tab.StylePriority.UseTextAlignment = False
        Me.XrTable_Data_Chap_Maintenance_Tab.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Detail_Chap_Maintenance_Tab
        '
        Me.Detail_Chap_Maintenance_Tab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable_Data_Chap_Maintenance_Tab})
        Me.Detail_Chap_Maintenance_Tab.HeightF = 15.0!
        Me.Detail_Chap_Maintenance_Tab.Name = "Detail_Chap_Maintenance_Tab"
        '
        'DR_Chap_Maintenance_Tab
        '
        Me.DR_Chap_Maintenance_Tab.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail_Chap_Maintenance_Tab, Me.GH_Chap_Maintenance_Tab, Me.ReportHeader})
        Me.DR_Chap_Maintenance_Tab.DataMember = "api_sp_Rapport_FM_Impression_PlanningAnnuelContrat"
        Me.DR_Chap_Maintenance_Tab.DataSource = Me.SDS_Chap_Maintenance_TabPrev
        Me.DR_Chap_Maintenance_Tab.Level = 0
        Me.DR_Chap_Maintenance_Tab.Name = "DR_Chap_Maintenance_Tab"
        Me.DR_Chap_Maintenance_Tab.ReportPrintOptions.PrintOnEmptyDataSource = False
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.ReportHeader.HeightF = 26.99559!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Century Gothic", 10.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 3.995594!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1099.0!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Type de contrat : "
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'P_ANNEE
        '
        Me.P_ANNEE.Description = "ANNEE"
        Me.P_ANNEE.Name = "P_ANNEE"
        Me.P_ANNEE.Type = GetType(Integer)
        Me.P_ANNEE.ValueInfo = "0"
        '
        'XR_Page_Chap_Maintenance_TableauPrev
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail_Chap_Maintenance, Me.TopMargin_Chap_Maintenance, Me.BottomMargin_Chap_Maintenance, Me.RH_Chap_Maintenance, Me.DR_Chap_Maintenance_Tab, Me.PageFooter_Chap_Maintenance})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SDS_Chap_Maintenance_TabPrev})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBoxBordersAllPage})
        Me.Landscape = True
        Me.Margins = New DevExpress.Drawing.DXMargins(27.0!, 22.0!, 17.0!, 12.0!)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.P_NCLINUM, Me.P_NTYPECONTRAT, Me.P_NIDRAPPORT_FM_CLI, Me.P_ANNEE})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "22.2"
        CType(Me.XrTable_Entete_Chap_Maintenance_Tab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable_Data_Chap_Maintenance_Tab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail_Chap_Maintenance As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin_Chap_Maintenance As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin_Chap_Maintenance As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrCrossBandBoxBordersAllPage As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents RH_Chap_Maintenance As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLblMaintenanceTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents P_NCLINUM As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents P_NTYPECONTRAT As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PageFooter_Chap_Maintenance As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo_Chap_Maintenance As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents SDS_Chap_Maintenance_TabPrev As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents P_NIDRAPPORT_FM_CLI As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XtTab_Entete_TXREA As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Entete_NBEXE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Entete_NBPLA As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Entete_VSITNOM As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Entete_VENSEIGNE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow_Entete_Chap_Maintenance_Tab As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable_Entete_Chap_Maintenance_Tab As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents GH_Chap_Maintenance_Tab As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XCD_03 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_02 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_01 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Data_LOT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Data_VSITNOM As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTab_Data_VENSEIGNE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow_Data_Chap_Maintenance_Tab As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTable_Data_Chap_Maintenance_Tab As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents Detail_Chap_Maintenance_Tab As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents DR_Chap_Maintenance_Tab As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell42 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell43 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell44 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell45 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell46 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell47 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell48 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell49 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell51 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_04 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_05 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_06 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_07 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_08 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_09 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_37 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_40 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_42 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_43 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_44 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_45 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_46 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_47 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_48 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_49 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_51 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XCD_52 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell101 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents P_ANNEE As DevExpress.XtraReports.Parameters.Parameter
End Class
