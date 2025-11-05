<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XReport_Rapport_fm_mensuel
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
        Dim StoredProcQuery4 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter13 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter14 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter15 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter16 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim StoredProcQuery5 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter17 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter18 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter19 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter20 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim StoredProcQuery6 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter21 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter22 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter23 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter24 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim StoredProcQuery7 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter25 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter26 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter27 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter28 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim StoredProcQuery8 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter29 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter30 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XReport_Rapport_fm_mensuel))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfoFooter = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.SqlDS_Imp_Rapport_Fm_Mensuel = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.ParamNCLINUM = New DevExpress.XtraReports.Parameters.Parameter()
        Me.ParamVENSEIGNE = New DevExpress.XtraReports.Parameters.Parameter()
        Me.ParamDateDebut_Last = New DevExpress.XtraReports.Parameters.Parameter()
        Me.ParamDateFin_Last = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrRichTxtFooterSommaire = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichTxtSommaire = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrPictLogoVSOCIETE = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictLogoLOGOCLIENT = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPageBreakAfterOrgaGen = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.XrrichTxtOrgaGen = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrOrgaGenLblVCLINOM = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLblOrgaGenTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageBreakAfterSommaire = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.XrLblPeriode = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLblRapportFmTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLblIntitule1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLblVCLINOM = New DevExpress.XtraReports.UI.XRLabel()
        Me.DetailReportPlanRea = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.DetailPlanRea = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeaderPlanRea = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLblPlanReaTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterPlanRea = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DetailReportPlanReaTab = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.DetailNettoyagePlanReaTab = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeaderPlanReaTab = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrTablePlanReaTabEntete = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRowEntetePlanReaTab = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableRowEntetePlanReaTabVENSEIGNE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRowEntetePlanReaTabVSITNOM = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRowEntetePlanReaTabVPRELIB = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRowEntetePlanReaTabVACTDES = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRowEntetePlanReaTabDACTDEX = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRowEntetePlanReaTabXX = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLblPlanReaTabTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterPlanReaTab = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ParamDateDebut_This = New DevExpress.XtraReports.Parameters.Parameter()
        Me.ParamDateFin_This = New DevExpress.XtraReports.Parameters.Parameter()
        Me.DetailReportLDR = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.DetailLDR = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeaderLDR = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLblLDRTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterLDR = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.DetailReportLDR3Month = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.DetailLDR3Month = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeaderLDR3Month = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrTableLDR3MonthEntete = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRowEnteteLDR3Month = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XtTabRowEnteteLDR3MonthVENSEIGNE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTabRowEnteteLDR3MonthVSITNOM = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTabRowEnteteLDR3MonthVPRELIB = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTabRowEnteteLDR3MonthVACTDES = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTabRowEnteteLDR3MonthDACTDEX = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLblLDR3MonthTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterLDR3Month = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DetailReportLDRDevisAValider = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.DetailLDRDevisAValider = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeaderLDRDevisAValider = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrTableLDRDevisAValiderEntete = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRowLDRDevisAValider = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XtTabLDRDevisAValiderVENSEIGNE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTabLDRDevisAValiderVSITNOM = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTabLDRDevisAValiderVPRELIB = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTabLDRDevisAValiderVACTDES = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTabLDRDevisAValiderDACTPLA = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLblLDRDevisAValiderTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterLDRDevisAValider = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DetailReportEquipements = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.DetailEquipements = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeaderEquipements = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLblEquipementsTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterEquipements = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.DetailReportEquipementsTab = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.DetailBauxEquipementsTab = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeaderEquipementsTab = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrTableEquipementsTabEntete = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRowEquipementsTab = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XtTabRowEquipementsTabVENSEIGNE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTabRowEquipementsTabVSITNOM = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTabRowEquipementsTabVPRELIB = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTabRowEquipementsTabVACTDES = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XtTabRowEquipementsTabDDATDEMANDE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLblEquipementsTabTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterEquipementsTab = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DetailReportBonInter = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.DetailBonInter = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeaderBonInter = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLblBonInterTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterBonInter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.DetailReportBonInterTab = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.DetailDechetsBonInterTab = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeaderBonInterTab = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrTableBonInterTabEntete = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRowEnteteBonInterTab = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableRowEnteteBonInterTabVENSEIGNE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRowEnteteBonInterTabVSITNOM = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRowEnteteBonInterTabVPRELIB = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRowEnteteBonInterTabVACTDES = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRowEnteteBonInterTabDDATDEMANDE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLblBonInterTabTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterBonInterTab = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCrossBandBoxBordersAllPage = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.XrStyleTitreTableau = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrStyleTitreContrat = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrStyleEnteteTableau = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrStyleTableauContenu = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailReportDepUrgTechOnSite = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.DetailDepUrgTechOnSite = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeaderDepUrgTechOnSite = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterDepUrgTechOnSite = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.DetailReportDepUrgTechOnSiteTab = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.DetailDepUrgTechOnSiteTab = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeaderDepUrgTechOnSiteTab = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooterDepUrgTechOnSiteTab = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DetailReportDepUrgTechOutSite = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.DetailDepUrgTechOutSite = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeaderDepUrgTechOutSite = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterDepUrgTechOutSite = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.DetailReportDepUrgTechOutSiteTab = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.DetailDepUrgTechOutSiteTab = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeaderDepUrgTechOutSiteTab = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooterDepUrgTechOutSiteTab = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DetailReportDepNoUrg = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.DetailDepNoUrg = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeaderDepNoUrg = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterDepNoUrg = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.DetailReportDepNoUrgTab = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.DetailDepNoUrgTab = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeaderDepNoUrgTab = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooterDepNoUrgTab = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable6 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable7 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable8 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell55 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell56 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell57 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell58 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable9 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell59 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell60 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell61 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell62 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell63 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell64 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable10 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell65 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell66 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell67 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell68 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell69 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell70 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable11 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell71 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell72 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell73 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell74 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell75 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell76 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell77 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell78 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.CalculatedFieldMoyDelai = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.XrRichTxtFooterSommaire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichTxtSommaire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrrichTxtOrgaGen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTablePlanReaTabEntete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTableLDR3MonthEntete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTableLDRDevisAValiderEntete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTableEquipementsTabEntete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTableBonInterTabEntete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 24.9583206!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfoFooter})
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.HeightF = 60.4166718!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfoFooter
        '
        Me.XrPageInfoFooter.Dpi = 100.0!
        Me.XrPageInfoFooter.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfoFooter.LocationFloat = New DevExpress.Utils.PointFloat(1.04166698!, 27.4164791!)
        Me.XrPageInfoFooter.Name = "XrPageInfoFooter"
        Me.XrPageInfoFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfoFooter.SizeF = New System.Drawing.SizeF(773.958313!, 23.0!)
        Me.XrPageInfoFooter.StylePriority.UseFont = False
        Me.XrPageInfoFooter.StylePriority.UseTextAlignment = False
        Me.XrPageInfoFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
    '
    'SqlDS_Imp_Rapport_Fm_Mensuel
    '
    ' TB SAMSIC CITY SPEC
    ' Données spécifiques à un serveur
    Me.SqlDS_Imp_Rapport_Fm_Mensuel.ConnectionName = "srv-sql05_MULTI_Connection"
        MsSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows
        MsSqlConnectionParameters1.DatabaseName = "MULTI"
        MsSqlConnectionParameters1.ServerName = "srv-sql05"
        Me.SqlDS_Imp_Rapport_Fm_Mensuel.ConnectionParameters = MsSqlConnectionParameters1
        Me.SqlDS_Imp_Rapport_Fm_Mensuel.Name = "SqlDS_Imp_Rapport_Fm_Mensuel"
        StoredProcQuery1.Name = "api_sp_Rapport_FM_Impression_PlanRealisation"
        QueryParameter1.Name = "@p_nclinum"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamNCLINUM]", GetType(Integer))
        QueryParameter2.Name = "@p_venseigne"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamVENSEIGNE]", GetType(String))
        QueryParameter3.Name = "@p_datedebut"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamDateDebut_This]", GetType(Date))
        QueryParameter4.Name = "@p_datefin"
        QueryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter4.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamDateFin_This]", GetType(Date))
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.Parameters.Add(QueryParameter3)
        StoredProcQuery1.Parameters.Add(QueryParameter4)
        StoredProcQuery1.StoredProcName = "api_sp_Rapport_FM_Impression_PlanRealisation"
        StoredProcQuery2.Name = "api_sp_Rapport_FM_Impression_RealisationLDR"
        QueryParameter5.Name = "@p_nclinum"
        QueryParameter5.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter5.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamNCLINUM]", GetType(Integer))
        QueryParameter6.Name = "@p_venseigne"
        QueryParameter6.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter6.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamVENSEIGNE]", GetType(String))
        QueryParameter7.Name = "@p_datedebut"
        QueryParameter7.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter7.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamDateDebut_This]", GetType(Date))
        QueryParameter8.Name = "@p_datefin"
        QueryParameter8.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter8.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamDateFin_This]", GetType(Date))
        StoredProcQuery2.Parameters.Add(QueryParameter5)
        StoredProcQuery2.Parameters.Add(QueryParameter6)
        StoredProcQuery2.Parameters.Add(QueryParameter7)
        StoredProcQuery2.Parameters.Add(QueryParameter8)
        StoredProcQuery2.StoredProcName = "api_sp_Rapport_FM_Impression_RealisationLDR"
        StoredProcQuery3.Name = "api_sp_Rapport_FM_Impression_MAJEquipement"
        QueryParameter9.Name = "@p_nclinum"
        QueryParameter9.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter9.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamNCLINUM]", GetType(Integer))
        QueryParameter10.Name = "@p_venseigne"
        QueryParameter10.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter10.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamVENSEIGNE]", GetType(String))
        QueryParameter11.Name = "@p_datedebut"
        QueryParameter11.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter11.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamDateDebut_This]", GetType(Date))
        QueryParameter12.Name = "@p_datefin"
        QueryParameter12.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter12.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamDateFin_This]", GetType(Date))
        StoredProcQuery3.Parameters.Add(QueryParameter9)
        StoredProcQuery3.Parameters.Add(QueryParameter10)
        StoredProcQuery3.Parameters.Add(QueryParameter11)
        StoredProcQuery3.Parameters.Add(QueryParameter12)
        StoredProcQuery3.StoredProcName = "api_sp_Rapport_FM_Impression_MAJEquipement"
        StoredProcQuery4.Name = "api_sp_Rapport_FM_Impression_RemiseBonIntervention"
        QueryParameter13.Name = "@p_nclinum"
        QueryParameter13.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter13.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamNCLINUM]", GetType(Integer))
        QueryParameter14.Name = "@p_venseigne"
        QueryParameter14.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter14.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamVENSEIGNE]", GetType(String))
        QueryParameter15.Name = "@p_datedebut"
        QueryParameter15.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter15.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamDateDebut_This]", GetType(Date))
        QueryParameter16.Name = "@p_datefin"
        QueryParameter16.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter16.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamDateFin_This]", GetType(Date))
        StoredProcQuery4.Parameters.Add(QueryParameter13)
        StoredProcQuery4.Parameters.Add(QueryParameter14)
        StoredProcQuery4.Parameters.Add(QueryParameter15)
        StoredProcQuery4.Parameters.Add(QueryParameter16)
        StoredProcQuery4.StoredProcName = "api_sp_Rapport_FM_Impression_RemiseBonIntervention"
        StoredProcQuery5.Name = "api_sp_Rapport_FM_Impression_DepannageUrgTechOnSite"
        QueryParameter17.Name = "@p_nclinum"
        QueryParameter17.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter17.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamNCLINUM]", GetType(Integer))
        QueryParameter18.Name = "@p_venseigne"
        QueryParameter18.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter18.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamVENSEIGNE]", GetType(String))
        QueryParameter19.Name = "@p_datedebut"
        QueryParameter19.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter19.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamDateDebut_This]", GetType(Date))
        QueryParameter20.Name = "@p_datefin"
        QueryParameter20.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter20.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamDateFin_This]", GetType(Date))
        StoredProcQuery5.Parameters.Add(QueryParameter17)
        StoredProcQuery5.Parameters.Add(QueryParameter18)
        StoredProcQuery5.Parameters.Add(QueryParameter19)
        StoredProcQuery5.Parameters.Add(QueryParameter20)
        StoredProcQuery5.StoredProcName = "api_sp_Rapport_FM_Impression_DepannageUrgTechOnSite"
        StoredProcQuery6.Name = "api_sp_Rapport_FM_Impression_DepannageUrgTechOutSite"
        QueryParameter21.Name = "@p_nclinum"
        QueryParameter21.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter21.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamNCLINUM]", GetType(Integer))
        QueryParameter22.Name = "@p_venseigne"
        QueryParameter22.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter22.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamVENSEIGNE]", GetType(String))
        QueryParameter23.Name = "@p_datedebut"
        QueryParameter23.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter23.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamDateDebut_This]", GetType(Date))
        QueryParameter24.Name = "@p_datefin"
        QueryParameter24.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter24.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamDateFin_This]", GetType(Date))
        StoredProcQuery6.Parameters.Add(QueryParameter21)
        StoredProcQuery6.Parameters.Add(QueryParameter22)
        StoredProcQuery6.Parameters.Add(QueryParameter23)
        StoredProcQuery6.Parameters.Add(QueryParameter24)
        StoredProcQuery6.StoredProcName = "api_sp_Rapport_FM_Impression_DepannageUrgTechOutSite"
        StoredProcQuery7.Name = "api_sp_Rapport_FM_Impression_DepannageNonUrg"
        QueryParameter25.Name = "@p_nclinum"
        QueryParameter25.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter25.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamNCLINUM]", GetType(Integer))
        QueryParameter26.Name = "@p_venseigne"
        QueryParameter26.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter26.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamVENSEIGNE]", GetType(String))
        QueryParameter27.Name = "@p_datedebut"
        QueryParameter27.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter27.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamDateDebut_This]", GetType(Date))
        QueryParameter28.Name = "@p_datefin"
        QueryParameter28.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter28.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamDateFin_This]", GetType(Date))
        StoredProcQuery7.Parameters.Add(QueryParameter25)
        StoredProcQuery7.Parameters.Add(QueryParameter26)
        StoredProcQuery7.Parameters.Add(QueryParameter27)
        StoredProcQuery7.Parameters.Add(QueryParameter28)
        StoredProcQuery7.StoredProcName = "api_sp_Rapport_FM_Impression_DepannageNonUrg"
        StoredProcQuery8.Name = "api_sp_Rapport_FM_Impression_LDRDevisAValider"
        QueryParameter29.Name = "@p_nclinum"
        QueryParameter29.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter29.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamNCLINUM]", GetType(Integer))
        QueryParameter30.Name = "@p_venseigne"
        QueryParameter30.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter30.Value = New DevExpress.DataAccess.Expression("[Parameters.ParamVENSEIGNE]", GetType(String))
        StoredProcQuery8.Parameters.Add(QueryParameter29)
        StoredProcQuery8.Parameters.Add(QueryParameter30)
        StoredProcQuery8.StoredProcName = "api_sp_Rapport_FM_Impression_LDRDevisAValider"
        Me.SqlDS_Imp_Rapport_Fm_Mensuel.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1, StoredProcQuery2, StoredProcQuery3, StoredProcQuery4, StoredProcQuery5, StoredProcQuery6, StoredProcQuery7, StoredProcQuery8})
        Me.SqlDS_Imp_Rapport_Fm_Mensuel.ResultSchemaSerializable = resources.GetString("SqlDS_Imp_Rapport_Fm_Mensuel.ResultSchemaSerializable")
        '
        'ParamNCLINUM
        '
        Me.ParamNCLINUM.Name = "ParamNCLINUM"
        Me.ParamNCLINUM.Type = GetType(Integer)
        Me.ParamNCLINUM.ValueInfo = "0"
        '
        'ParamVENSEIGNE
        '
        Me.ParamVENSEIGNE.Name = "ParamVENSEIGNE"
        '
        'ParamDateDebut_Last
        '
        Me.ParamDateDebut_Last.Name = "ParamDateDebut_Last"
        Me.ParamDateDebut_Last.Type = GetType(Date)
        '
        'ParamDateFin_Last
        '
        Me.ParamDateFin_Last.Name = "ParamDateFin_Last"
        Me.ParamDateFin_Last.Type = GetType(Date)
        '
        'PageHeader
        '
        Me.PageHeader.Dpi = 100.0!
        Me.PageHeader.HeightF = 0.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Dpi = 100.0!
        Me.PageFooter.HeightF = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'ReportHeader
        '
        Me.ReportHeader.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.ReportHeader.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichTxtFooterSommaire, Me.XrRichTxtSommaire, Me.XrPictLogoVSOCIETE, Me.XrPictLogoLOGOCLIENT, Me.XrPageBreakAfterOrgaGen, Me.XrrichTxtOrgaGen, Me.XrOrgaGenLblVCLINOM, Me.XrLblOrgaGenTitle, Me.XrPageBreakAfterSommaire, Me.XrLblPeriode, Me.XrLblRapportFmTitle, Me.XrLblIntitule1, Me.XrLblVCLINOM})
        Me.ReportHeader.Dpi = 100.0!
        Me.ReportHeader.HeightF = 1479.16699!
        Me.ReportHeader.Name = "ReportHeader"
        Me.ReportHeader.StylePriority.UseBorderDashStyle = False
        Me.ReportHeader.StylePriority.UseBorders = False
        '
        'XrRichTxtFooterSommaire
        '
        Me.XrRichTxtFooterSommaire.Dpi = 100.0!
        Me.XrRichTxtFooterSommaire.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrRichTxtFooterSommaire.LocationFloat = New DevExpress.Utils.PointFloat(9.9993391!, 963.5!)
        Me.XrRichTxtFooterSommaire.Name = "XrRichTxtFooterSommaire"
        Me.XrRichTxtFooterSommaire.SerializableRtfString = resources.GetString("XrRichTxtFooterSommaire.SerializableRtfString")
        Me.XrRichTxtFooterSommaire.SizeF = New System.Drawing.SizeF(754.999817!, 60.5!)
        Me.XrRichTxtFooterSommaire.StylePriority.UseFont = False
        '
        'XrRichTxtSommaire
        '
        Me.XrRichTxtSommaire.Dpi = 100.0!
        Me.XrRichTxtSommaire.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrRichTxtSommaire.LocationFloat = New DevExpress.Utils.PointFloat(10.0001001!, 297.875!)
        Me.XrRichTxtSommaire.Name = "XrRichTxtSommaire"
        Me.XrRichTxtSommaire.SerializableRtfString = resources.GetString("XrRichTxtSommaire.SerializableRtfString")
        Me.XrRichTxtSommaire.SizeF = New System.Drawing.SizeF(754.999817!, 646.95813!)
        Me.XrRichTxtSommaire.StylePriority.UseFont = False
        '
        'XrPictLogoVSOCIETE
        '
        Me.XrPictLogoVSOCIETE.Dpi = 100.0!
        Me.XrPictLogoVSOCIETE.LocationFloat = New DevExpress.Utils.PointFloat(10.0001001!, 10.0000095!)
        Me.XrPictLogoVSOCIETE.Name = "XrPictLogoVSOCIETE"
        Me.XrPictLogoVSOCIETE.SizeF = New System.Drawing.SizeF(165.743103!, 33.4166718!)
        Me.XrPictLogoVSOCIETE.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrPictLogoLOGOCLIENT
        '
        Me.XrPictLogoLOGOCLIENT.Dpi = 100.0!
        Me.XrPictLogoLOGOCLIENT.LocationFloat = New DevExpress.Utils.PointFloat(517.08252!, 10.0000095!)
        Me.XrPictLogoLOGOCLIENT.Name = "XrPictLogoLOGOCLIENT"
        Me.XrPictLogoLOGOCLIENT.SizeF = New System.Drawing.SizeF(247.916702!, 72.0800018!)
        Me.XrPictLogoLOGOCLIENT.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrPageBreakAfterOrgaGen
        '
        Me.XrPageBreakAfterOrgaGen.Dpi = 100.0!
        Me.XrPageBreakAfterOrgaGen.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 1467.16699!)
        Me.XrPageBreakAfterOrgaGen.Name = "XrPageBreakAfterOrgaGen"
        '
        'XrrichTxtOrgaGen
        '
        Me.XrrichTxtOrgaGen.Dpi = 100.0!
        Me.XrrichTxtOrgaGen.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrrichTxtOrgaGen.LocationFloat = New DevExpress.Utils.PointFloat(10.0001001!, 1159.375!)
        Me.XrrichTxtOrgaGen.Name = "XrrichTxtOrgaGen"
        Me.XrrichTxtOrgaGen.SerializableRtfString = resources.GetString("XrrichTxtOrgaGen.SerializableRtfString")
        Me.XrrichTxtOrgaGen.SizeF = New System.Drawing.SizeF(754.999817!, 283.416595!)
        Me.XrrichTxtOrgaGen.StylePriority.UseFont = False
        '
        'XrOrgaGenLblVCLINOM
        '
        Me.XrOrgaGenLblVCLINOM.Dpi = 100.0!
        Me.XrOrgaGenLblVCLINOM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrOrgaGenLblVCLINOM.LocationFloat = New DevExpress.Utils.PointFloat(9.9993391!, 1112.5!)
        Me.XrOrgaGenLblVCLINOM.Name = "XrOrgaGenLblVCLINOM"
        Me.XrOrgaGenLblVCLINOM.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrOrgaGenLblVCLINOM.SizeF = New System.Drawing.SizeF(754.999817!, 31.25!)
        Me.XrOrgaGenLblVCLINOM.StylePriority.UseFont = False
        Me.XrOrgaGenLblVCLINOM.StylePriority.UseTextAlignment = False
        Me.XrOrgaGenLblVCLINOM.Text = "VCLINOM"
        Me.XrOrgaGenLblVCLINOM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLblOrgaGenTitle
        '
        Me.XrLblOrgaGenTitle.Dpi = 100.0!
        Me.XrLblOrgaGenTitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblOrgaGenTitle.LocationFloat = New DevExpress.Utils.PointFloat(10.0001001!, 1054.16699!)
        Me.XrLblOrgaGenTitle.Name = "XrLblOrgaGenTitle"
        Me.XrLblOrgaGenTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblOrgaGenTitle.SizeF = New System.Drawing.SizeF(754.999817!, 39.7916298!)
        Me.XrLblOrgaGenTitle.StyleName = "XrStyleTitreContrat"
        Me.XrLblOrgaGenTitle.Text = "ORGANISATION GENERALE"
        Me.XrLblOrgaGenTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPageBreakAfterSommaire
        '
        Me.XrPageBreakAfterSommaire.Dpi = 100.0!
        Me.XrPageBreakAfterSommaire.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 1036.54199!)
        Me.XrPageBreakAfterSommaire.Name = "XrPageBreakAfterSommaire"
        '
        'XrLblPeriode
        '
        Me.XrLblPeriode.Dpi = 100.0!
        Me.XrLblPeriode.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblPeriode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.XrLblPeriode.LocationFloat = New DevExpress.Utils.PointFloat(10.0000095!, 243.75!)
        Me.XrLblPeriode.Name = "XrLblPeriode"
        Me.XrLblPeriode.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblPeriode.SizeF = New System.Drawing.SizeF(754.999878!, 42.7083397!)
        Me.XrLblPeriode.StylePriority.UseFont = False
        Me.XrLblPeriode.StylePriority.UseForeColor = False
        Me.XrLblPeriode.StylePriority.UseTextAlignment = False
        Me.XrLblPeriode.Text = "Periode"
        Me.XrLblPeriode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLblRapportFmTitle
        '
        Me.XrLblRapportFmTitle.Dpi = 100.0!
        Me.XrLblRapportFmTitle.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblRapportFmTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.XrLblRapportFmTitle.LocationFloat = New DevExpress.Utils.PointFloat(10.0000095!, 201.041702!)
        Me.XrLblRapportFmTitle.Name = "XrLblRapportFmTitle"
        Me.XrLblRapportFmTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblRapportFmTitle.SizeF = New System.Drawing.SizeF(754.999878!, 42.7083397!)
        Me.XrLblRapportFmTitle.StylePriority.UseFont = False
        Me.XrLblRapportFmTitle.StylePriority.UseForeColor = False
        Me.XrLblRapportFmTitle.StylePriority.UseTextAlignment = False
        Me.XrLblRapportFmTitle.Text = "Rapport Title"
        Me.XrLblRapportFmTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLblIntitule1
        '
        Me.XrLblIntitule1.Dpi = 100.0!
        Me.XrLblIntitule1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblIntitule1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.XrLblIntitule1.LocationFloat = New DevExpress.Utils.PointFloat(10.0000095!, 158.333298!)
        Me.XrLblIntitule1.Name = "XrLblIntitule1"
        Me.XrLblIntitule1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblIntitule1.SizeF = New System.Drawing.SizeF(754.999878!, 42.7083397!)
        Me.XrLblIntitule1.StylePriority.UseFont = False
        Me.XrLblIntitule1.StylePriority.UseForeColor = False
        Me.XrLblIntitule1.StylePriority.UseTextAlignment = False
        Me.XrLblIntitule1.Text = "Contrat FM"
        Me.XrLblIntitule1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLblVCLINOM
        '
        Me.XrLblVCLINOM.Dpi = 100.0!
        Me.XrLblVCLINOM.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblVCLINOM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.XrLblVCLINOM.LocationFloat = New DevExpress.Utils.PointFloat(9.99999809!, 115.625!)
        Me.XrLblVCLINOM.Name = "XrLblVCLINOM"
        Me.XrLblVCLINOM.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblVCLINOM.SizeF = New System.Drawing.SizeF(754.999878!, 42.7083397!)
        Me.XrLblVCLINOM.StylePriority.UseFont = False
        Me.XrLblVCLINOM.StylePriority.UseForeColor = False
        Me.XrLblVCLINOM.StylePriority.UseTextAlignment = False
        Me.XrLblVCLINOM.Text = "VCLINOM"
        Me.XrLblVCLINOM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'DetailReportPlanRea
        '
        Me.DetailReportPlanRea.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailPlanRea, Me.ReportHeaderPlanRea, Me.ReportFooterPlanRea, Me.DetailReportPlanReaTab})
        Me.DetailReportPlanRea.Dpi = 100.0!
        Me.DetailReportPlanRea.Level = 0
        Me.DetailReportPlanRea.Name = "DetailReportPlanRea"
        '
        'DetailPlanRea
        '
        Me.DetailPlanRea.Dpi = 100.0!
        Me.DetailPlanRea.HeightF = 0.0!
        Me.DetailPlanRea.Name = "DetailPlanRea"
        '
        'ReportHeaderPlanRea
        '
        Me.ReportHeaderPlanRea.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLblPlanReaTitle})
        Me.ReportHeaderPlanRea.Dpi = 100.0!
        Me.ReportHeaderPlanRea.HeightF = 59.7916908!
        Me.ReportHeaderPlanRea.Name = "ReportHeaderPlanRea"
        '
        'XrLblPlanReaTitle
        '
        Me.XrLblPlanReaTitle.BackColor = System.Drawing.Color.LightGray
        Me.XrLblPlanReaTitle.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLblPlanReaTitle.BorderWidth = 0.5!
        Me.XrLblPlanReaTitle.Dpi = 100.0!
        Me.XrLblPlanReaTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblPlanReaTitle.LocationFloat = New DevExpress.Utils.PointFloat(10.0001001!, 9.99997425!)
        Me.XrLblPlanReaTitle.Name = "XrLblPlanReaTitle"
        Me.XrLblPlanReaTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblPlanReaTitle.SizeF = New System.Drawing.SizeF(754.999817!, 37.2916908!)
        Me.XrLblPlanReaTitle.StyleName = "XrStyleTitreContrat"
        Me.XrLblPlanReaTitle.Text = "RESPECT DU PLAN DE MAINTENANCE"
        Me.XrLblPlanReaTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ReportFooterPlanRea
        '
        Me.ReportFooterPlanRea.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5})
        Me.ReportFooterPlanRea.Dpi = 100.0!
        Me.ReportFooterPlanRea.HeightF = 23.0000591!
        Me.ReportFooterPlanRea.Name = "ReportFooterPlanRea"
        '
        'XrLabel5
        '
        Me.XrLabel5.Dpi = 100.0!
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(314.583313!, 0.0000635782926!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'DetailReportPlanReaTab
        '
        Me.DetailReportPlanReaTab.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailNettoyagePlanReaTab, Me.ReportHeaderPlanReaTab, Me.ReportFooterPlanReaTab})
        Me.DetailReportPlanReaTab.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DetailReportPlanReaTab.DataMember = "api_sp_Rapport_FM_Impression_PlanRealisation"
        Me.DetailReportPlanReaTab.DataSource = Me.SqlDS_Imp_Rapport_Fm_Mensuel
        Me.DetailReportPlanReaTab.Dpi = 100.0!
        Me.DetailReportPlanReaTab.Level = 0
        Me.DetailReportPlanReaTab.Name = "DetailReportPlanReaTab"
        '
        'DetailNettoyagePlanReaTab
        '
        Me.DetailNettoyagePlanReaTab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable4})
        Me.DetailNettoyagePlanReaTab.Dpi = 100.0!
        Me.DetailNettoyagePlanReaTab.HeightF = 25.0!
        Me.DetailNettoyagePlanReaTab.Name = "DetailNettoyagePlanReaTab"
        '
        'ReportHeaderPlanReaTab
        '
        Me.ReportHeaderPlanReaTab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTablePlanReaTabEntete, Me.XrLblPlanReaTabTitle})
        Me.ReportHeaderPlanReaTab.Dpi = 100.0!
        Me.ReportHeaderPlanReaTab.HeightF = 85.4166718!
        Me.ReportHeaderPlanReaTab.Name = "ReportHeaderPlanReaTab"
        Me.ReportHeaderPlanReaTab.StylePriority.UseBorders = False
        '
        'XrTablePlanReaTabEntete
        '
        Me.XrTablePlanReaTabEntete.BackColor = System.Drawing.Color.LightSkyBlue
        Me.XrTablePlanReaTabEntete.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTablePlanReaTabEntete.BorderWidth = 0.25!
        Me.XrTablePlanReaTabEntete.Dpi = 100.0!
        Me.XrTablePlanReaTabEntete.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTablePlanReaTabEntete.LocationFloat = New DevExpress.Utils.PointFloat(9.9993391!, 50.0!)
        Me.XrTablePlanReaTabEntete.Name = "XrTablePlanReaTabEntete"
        Me.XrTablePlanReaTabEntete.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRowEntetePlanReaTab})
        Me.XrTablePlanReaTabEntete.SizeF = New System.Drawing.SizeF(754.999878!, 35.4166718!)
        Me.XrTablePlanReaTabEntete.StyleName = "XrStyleEnteteTableau"
        Me.XrTablePlanReaTabEntete.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRowEntetePlanReaTab
        '
        Me.XrTableRowEntetePlanReaTab.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableRowEntetePlanReaTabVENSEIGNE, Me.XrTableRowEntetePlanReaTabVSITNOM, Me.XrTableRowEntetePlanReaTabVPRELIB, Me.XrTableRowEntetePlanReaTabVACTDES, Me.XrTableRowEntetePlanReaTabDACTDEX, Me.XrTableRowEntetePlanReaTabXX})
        Me.XrTableRowEntetePlanReaTab.Dpi = 100.0!
        Me.XrTableRowEntetePlanReaTab.Name = "XrTableRowEntetePlanReaTab"
        Me.XrTableRowEntetePlanReaTab.Weight = 1.0R
        '
        'XrTableRowEntetePlanReaTabVENSEIGNE
        '
        Me.XrTableRowEntetePlanReaTabVENSEIGNE.Dpi = 100.0!
        Me.XrTableRowEntetePlanReaTabVENSEIGNE.Name = "XrTableRowEntetePlanReaTabVENSEIGNE"
        Me.XrTableRowEntetePlanReaTabVENSEIGNE.StylePriority.UseTextAlignment = False
        Me.XrTableRowEntetePlanReaTabVENSEIGNE.Text = "Enseigne"
        Me.XrTableRowEntetePlanReaTabVENSEIGNE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableRowEntetePlanReaTabVENSEIGNE.Weight = 1.056250228786054R
        '
        'XrTableRowEntetePlanReaTabVSITNOM
        '
        Me.XrTableRowEntetePlanReaTabVSITNOM.Dpi = 100.0!
        Me.XrTableRowEntetePlanReaTabVSITNOM.Name = "XrTableRowEntetePlanReaTabVSITNOM"
        Me.XrTableRowEntetePlanReaTabVSITNOM.Text = "Sites"
        Me.XrTableRowEntetePlanReaTabVSITNOM.Weight = 1.5595209236801946R
        '
        'XrTableRowEntetePlanReaTabVPRELIB
        '
        Me.XrTableRowEntetePlanReaTabVPRELIB.Dpi = 100.0!
        Me.XrTableRowEntetePlanReaTabVPRELIB.Name = "XrTableRowEntetePlanReaTabVPRELIB"
        Me.XrTableRowEntetePlanReaTabVPRELIB.Text = "Lots"
        Me.XrTableRowEntetePlanReaTabVPRELIB.Weight = 2.5696436440302399R
        '
        'XrTableRowEntetePlanReaTabVACTDES
        '
        Me.XrTableRowEntetePlanReaTabVACTDES.Dpi = 100.0!
        Me.XrTableRowEntetePlanReaTabVACTDES.Name = "XrTableRowEntetePlanReaTabVACTDES"
        Me.XrTableRowEntetePlanReaTabVACTDES.Text = "Nombre planifié"
        Me.XrTableRowEntetePlanReaTabVACTDES.Weight = 0.8383770162569818R
        '
        'XrTableRowEntetePlanReaTabDACTDEX
        '
        Me.XrTableRowEntetePlanReaTabDACTDEX.Dpi = 100.0!
        Me.XrTableRowEntetePlanReaTabDACTDEX.Name = "XrTableRowEntetePlanReaTabDACTDEX"
        Me.XrTableRowEntetePlanReaTabDACTDEX.Text = "Nombre réalisé"
        Me.XrTableRowEntetePlanReaTabDACTDEX.Weight = 0.78125662322950218R
        '
        'XrTableRowEntetePlanReaTabXX
        '
        Me.XrTableRowEntetePlanReaTabXX.Dpi = 100.0!
        Me.XrTableRowEntetePlanReaTabXX.Name = "XrTableRowEntetePlanReaTabXX"
        Me.XrTableRowEntetePlanReaTabXX.Text = "Taux de réalisation"
        Me.XrTableRowEntetePlanReaTabXX.Weight = 0.74494963505826584R
        '
        'XrLblPlanReaTabTitle
        '
        Me.XrLblPlanReaTabTitle.Dpi = 100.0!
        Me.XrLblPlanReaTabTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblPlanReaTabTitle.LocationFloat = New DevExpress.Utils.PointFloat(9.9993391!, 10.0000095!)
        Me.XrLblPlanReaTabTitle.Name = "XrLblPlanReaTabTitle"
        Me.XrLblPlanReaTabTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblPlanReaTabTitle.SizeF = New System.Drawing.SizeF(754.999817!, 23.0!)
        Me.XrLblPlanReaTabTitle.StyleName = "XrStyleTitreTableau"
        Me.XrLblPlanReaTabTitle.Text = "Réalisation"
        '
        'ReportFooterPlanReaTab
        '
        Me.ReportFooterPlanReaTab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.ReportFooterPlanReaTab.Dpi = 100.0!
        Me.ReportFooterPlanReaTab.HeightF = 23.0!
        Me.ReportFooterPlanReaTab.Name = "ReportFooterPlanReaTab"
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 100.0!
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(314.583313!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'ParamDateDebut_This
        '
        Me.ParamDateDebut_This.Name = "ParamDateDebut_This"
        Me.ParamDateDebut_This.Type = GetType(Date)
        '
        'ParamDateFin_This
        '
        Me.ParamDateFin_This.Name = "ParamDateFin_This"
        Me.ParamDateFin_This.Type = GetType(Date)
        '
        'DetailReportLDR
        '
        Me.DetailReportLDR.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailLDR, Me.ReportHeaderLDR, Me.ReportFooterLDR, Me.DetailReportLDR3Month, Me.DetailReportLDRDevisAValider})
        Me.DetailReportLDR.Dpi = 100.0!
        Me.DetailReportLDR.Level = 1
        Me.DetailReportLDR.Name = "DetailReportLDR"
        '
        'DetailLDR
        '
        Me.DetailLDR.Dpi = 100.0!
        Me.DetailLDR.HeightF = 0.0!
        Me.DetailLDR.Name = "DetailLDR"
        '
        'ReportHeaderLDR
        '
        Me.ReportHeaderLDR.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLblLDRTitle})
        Me.ReportHeaderLDR.Dpi = 100.0!
        Me.ReportHeaderLDR.HeightF = 58.3333282!
        Me.ReportHeaderLDR.Name = "ReportHeaderLDR"
        '
        'XrLblLDRTitle
        '
        Me.XrLblLDRTitle.BackColor = System.Drawing.Color.LightGray
        Me.XrLblLDRTitle.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLblLDRTitle.Dpi = 100.0!
        Me.XrLblLDRTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblLDRTitle.LocationFloat = New DevExpress.Utils.PointFloat(9.9993391!, 10.0001001!)
        Me.XrLblLDRTitle.Name = "XrLblLDRTitle"
        Me.XrLblLDRTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblLDRTitle.SizeF = New System.Drawing.SizeF(755.0!, 37.2900009!)
        Me.XrLblLDRTitle.StyleName = "XrStyleTitreContrat"
        Me.XrLblLDRTitle.Text = "REALISATION DES LEVEES DE RESERVES DES RAPPORTS DES ORGANISMES DE CONTROLES"
        Me.XrLblLDRTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ReportFooterLDR
        '
        Me.ReportFooterLDR.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel13})
        Me.ReportFooterLDR.Dpi = 100.0!
        Me.ReportFooterLDR.HeightF = 26.0416698!
        Me.ReportFooterLDR.Name = "ReportFooterLDR"
        '
        'DetailReportLDR3Month
        '
        Me.DetailReportLDR3Month.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailLDR3Month, Me.ReportHeaderLDR3Month, Me.ReportFooterLDR3Month})
        Me.DetailReportLDR3Month.DataMember = "api_sp_Rapport_FM_Impression_RealisationLDR"
        Me.DetailReportLDR3Month.DataSource = Me.SqlDS_Imp_Rapport_Fm_Mensuel
        Me.DetailReportLDR3Month.Dpi = 100.0!
        Me.DetailReportLDR3Month.Level = 0
        Me.DetailReportLDR3Month.Name = "DetailReportLDR3Month"
        '
        'DetailLDR3Month
        '
        Me.DetailLDR3Month.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable11})
        Me.DetailLDR3Month.Dpi = 100.0!
        Me.DetailLDR3Month.HeightF = 25.0!
        Me.DetailLDR3Month.Name = "DetailLDR3Month"
        '
        'ReportHeaderLDR3Month
        '
        Me.ReportHeaderLDR3Month.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTableLDR3MonthEntete, Me.XrLblLDR3MonthTitle})
        Me.ReportHeaderLDR3Month.Dpi = 100.0!
        Me.ReportHeaderLDR3Month.HeightF = 127.083298!
        Me.ReportHeaderLDR3Month.Name = "ReportHeaderLDR3Month"
        '
        'XrTableLDR3MonthEntete
        '
        Me.XrTableLDR3MonthEntete.BackColor = System.Drawing.Color.LightSkyBlue
        Me.XrTableLDR3MonthEntete.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableLDR3MonthEntete.BorderWidth = 0.25!
        Me.XrTableLDR3MonthEntete.Dpi = 100.0!
        Me.XrTableLDR3MonthEntete.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableLDR3MonthEntete.LocationFloat = New DevExpress.Utils.PointFloat(10.0006104!, 78.125!)
        Me.XrTableLDR3MonthEntete.Name = "XrTableLDR3MonthEntete"
        Me.XrTableLDR3MonthEntete.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRowEnteteLDR3Month})
        Me.XrTableLDR3MonthEntete.SizeF = New System.Drawing.SizeF(754.998474!, 48.9583397!)
        Me.XrTableLDR3MonthEntete.StyleName = "XrStyleEnteteTableau"
        Me.XrTableLDR3MonthEntete.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRowEnteteLDR3Month
        '
        Me.XrTableRowEnteteLDR3Month.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XtTabRowEnteteLDR3MonthVENSEIGNE, Me.XtTabRowEnteteLDR3MonthVSITNOM, Me.XtTabRowEnteteLDR3MonthVPRELIB, Me.XtTabRowEnteteLDR3MonthVACTDES, Me.XtTabRowEnteteLDR3MonthDACTDEX, Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3})
        Me.XrTableRowEnteteLDR3Month.Dpi = 100.0!
        Me.XrTableRowEnteteLDR3Month.Name = "XrTableRowEnteteLDR3Month"
        Me.XrTableRowEnteteLDR3Month.Weight = 1.0R
        '
        'XtTabRowEnteteLDR3MonthVENSEIGNE
        '
        Me.XtTabRowEnteteLDR3MonthVENSEIGNE.Dpi = 100.0!
        Me.XtTabRowEnteteLDR3MonthVENSEIGNE.Name = "XtTabRowEnteteLDR3MonthVENSEIGNE"
        Me.XtTabRowEnteteLDR3MonthVENSEIGNE.StylePriority.UseTextAlignment = False
        Me.XtTabRowEnteteLDR3MonthVENSEIGNE.Text = "Enseigne"
        Me.XtTabRowEnteteLDR3MonthVENSEIGNE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XtTabRowEnteteLDR3MonthVENSEIGNE.Weight = 1.041666793823242R
        '
        'XtTabRowEnteteLDR3MonthVSITNOM
        '
        Me.XtTabRowEnteteLDR3MonthVSITNOM.Dpi = 100.0!
        Me.XtTabRowEnteteLDR3MonthVSITNOM.Name = "XtTabRowEnteteLDR3MonthVSITNOM"
        Me.XtTabRowEnteteLDR3MonthVSITNOM.Text = "Sites"
        Me.XtTabRowEnteteLDR3MonthVSITNOM.Weight = 1.4528329756478009R
        '
        'XtTabRowEnteteLDR3MonthVPRELIB
        '
        Me.XtTabRowEnteteLDR3MonthVPRELIB.Dpi = 100.0!
        Me.XtTabRowEnteteLDR3MonthVPRELIB.Name = "XtTabRowEnteteLDR3MonthVPRELIB"
        Me.XtTabRowEnteteLDR3MonthVPRELIB.Text = "Lots"
        Me.XtTabRowEnteteLDR3MonthVPRELIB.Weight = 1.5127808129630429R
        '
        'XtTabRowEnteteLDR3MonthVACTDES
        '
        Me.XtTabRowEnteteLDR3MonthVACTDES.Dpi = 100.0!
        Me.XtTabRowEnteteLDR3MonthVACTDES.Name = "XtTabRowEnteteLDR3MonthVACTDES"
        Me.XtTabRowEnteteLDR3MonthVACTDES.Text = "Date saisie rapport"
        Me.XtTabRowEnteteLDR3MonthVACTDES.Weight = 0.54566482530766369R
        '
        'XtTabRowEnteteLDR3MonthDACTDEX
        '
        Me.XtTabRowEnteteLDR3MonthDACTDEX.Dpi = 100.0!
        Me.XtTabRowEnteteLDR3MonthDACTDEX.Name = "XtTabRowEnteteLDR3MonthDACTDEX"
        Me.XtTabRowEnteteLDR3MonthDACTDEX.Text = "Date de réalisation du devis"
        Me.XtTabRowEnteteLDR3MonthDACTDEX.Weight = 0.58082603249088183R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Dpi = 100.0!
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "Date de validation du devis"
        Me.XrTableCell1.Weight = 0.7399014442021512R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Dpi = 100.0!
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "Date de réalisation"
        Me.XrTableCell2.Weight = 0.61590051980791904R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Dpi = 100.0!
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "Délai de réalisation (Jours)"
        Me.XrTableCell3.Weight = 0.71041598108353188R
        '
        'XrLblLDR3MonthTitle
        '
        Me.XrLblLDR3MonthTitle.Dpi = 100.0!
        Me.XrLblLDR3MonthTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblLDR3MonthTitle.LocationFloat = New DevExpress.Utils.PointFloat(9.99943447!, 10.0001001!)
        Me.XrLblLDR3MonthTitle.Name = "XrLblLDR3MonthTitle"
        Me.XrLblLDR3MonthTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblLDR3MonthTitle.SizeF = New System.Drawing.SizeF(755.000183!, 50.0833397!)
        Me.XrLblLDR3MonthTitle.StyleName = "XrStyleTitreTableau"
        Me.XrLblLDR3MonthTitle.Text = "Levée des réserves sous 3 mois après transmission des rapports (Sous réserves de " & _
    "la validation des devis)"
        '
        'ReportFooterLDR3Month
        '
        Me.ReportFooterLDR3Month.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel22, Me.XrLabel6})
        Me.ReportFooterLDR3Month.Dpi = 100.0!
        Me.ReportFooterLDR3Month.HeightF = 61.5416794!
        Me.ReportFooterLDR3Month.Name = "ReportFooterLDR3Month"
        '
        'XrLabel6
        '
        Me.XrLabel6.Dpi = 100.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(9.9993391!, 10.0001001!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(201.160507!, 23.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Soit un délai moyen de"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailReportLDRDevisAValider
        '
        Me.DetailReportLDRDevisAValider.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailLDRDevisAValider, Me.ReportHeaderLDRDevisAValider, Me.ReportFooterLDRDevisAValider})
        Me.DetailReportLDRDevisAValider.DataMember = "api_sp_Rapport_FM_Impression_LDRDevisAValider"
        Me.DetailReportLDRDevisAValider.DataSource = Me.SqlDS_Imp_Rapport_Fm_Mensuel
        Me.DetailReportLDRDevisAValider.Dpi = 100.0!
        Me.DetailReportLDRDevisAValider.Level = 1
        Me.DetailReportLDRDevisAValider.Name = "DetailReportLDRDevisAValider"
        '
        'DetailLDRDevisAValider
        '
        Me.DetailLDRDevisAValider.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable5})
        Me.DetailLDRDevisAValider.Dpi = 100.0!
        Me.DetailLDRDevisAValider.HeightF = 25.0!
        Me.DetailLDRDevisAValider.Name = "DetailLDRDevisAValider"
        '
        'ReportHeaderLDRDevisAValider
        '
        Me.ReportHeaderLDRDevisAValider.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTableLDRDevisAValiderEntete, Me.XrLblLDRDevisAValiderTitle})
        Me.ReportHeaderLDRDevisAValider.Dpi = 100.0!
        Me.ReportHeaderLDRDevisAValider.HeightF = 93.1249924!
        Me.ReportHeaderLDRDevisAValider.Name = "ReportHeaderLDRDevisAValider"
        '
        'XrTableLDRDevisAValiderEntete
        '
        Me.XrTableLDRDevisAValiderEntete.BackColor = System.Drawing.Color.LightSkyBlue
        Me.XrTableLDRDevisAValiderEntete.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableLDRDevisAValiderEntete.BorderWidth = 0.25!
        Me.XrTableLDRDevisAValiderEntete.Dpi = 100.0!
        Me.XrTableLDRDevisAValiderEntete.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.XrTableLDRDevisAValiderEntete.LocationFloat = New DevExpress.Utils.PointFloat(9.99943447!, 50.0!)
        Me.XrTableLDRDevisAValiderEntete.Name = "XrTableLDRDevisAValiderEntete"
        Me.XrTableLDRDevisAValiderEntete.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRowLDRDevisAValider})
        Me.XrTableLDRDevisAValiderEntete.SizeF = New System.Drawing.SizeF(754.999695!, 43.1249886!)
        Me.XrTableLDRDevisAValiderEntete.StyleName = "XrStyleEnteteTableau"
        Me.XrTableLDRDevisAValiderEntete.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRowLDRDevisAValider
        '
        Me.XrTableRowLDRDevisAValider.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XtTabLDRDevisAValiderVENSEIGNE, Me.XtTabLDRDevisAValiderVSITNOM, Me.XtTabLDRDevisAValiderVPRELIB, Me.XtTabLDRDevisAValiderVACTDES, Me.XtTabLDRDevisAValiderDACTPLA, Me.XrTableCell4, Me.XrTableCell5})
        Me.XrTableRowLDRDevisAValider.Dpi = 100.0!
        Me.XrTableRowLDRDevisAValider.Name = "XrTableRowLDRDevisAValider"
        Me.XrTableRowLDRDevisAValider.Weight = 1.0R
        '
        'XtTabLDRDevisAValiderVENSEIGNE
        '
        Me.XtTabLDRDevisAValiderVENSEIGNE.Dpi = 100.0!
        Me.XtTabLDRDevisAValiderVENSEIGNE.Name = "XtTabLDRDevisAValiderVENSEIGNE"
        Me.XtTabLDRDevisAValiderVENSEIGNE.StylePriority.UseTextAlignment = False
        Me.XtTabLDRDevisAValiderVENSEIGNE.Text = "Enseigne"
        Me.XtTabLDRDevisAValiderVENSEIGNE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XtTabLDRDevisAValiderVENSEIGNE.Weight = 1.041666793823242R
        '
        'XtTabLDRDevisAValiderVSITNOM
        '
        Me.XtTabLDRDevisAValiderVSITNOM.Dpi = 100.0!
        Me.XtTabLDRDevisAValiderVSITNOM.Name = "XtTabLDRDevisAValiderVSITNOM"
        Me.XtTabLDRDevisAValiderVSITNOM.Text = "Sites"
        Me.XtTabLDRDevisAValiderVSITNOM.Weight = 1.452842023306719R
        '
        'XtTabLDRDevisAValiderVPRELIB
        '
        Me.XtTabLDRDevisAValiderVPRELIB.Dpi = 100.0!
        Me.XtTabLDRDevisAValiderVPRELIB.Name = "XtTabLDRDevisAValiderVPRELIB"
        Me.XtTabLDRDevisAValiderVPRELIB.Text = "Lots"
        Me.XtTabLDRDevisAValiderVPRELIB.Weight = 2.0584441453315194R
        '
        'XtTabLDRDevisAValiderVACTDES
        '
        Me.XtTabLDRDevisAValiderVACTDES.Dpi = 100.0!
        Me.XtTabLDRDevisAValiderVACTDES.Name = "XtTabLDRDevisAValiderVACTDES"
        Me.XtTabLDRDevisAValiderVACTDES.Text = "Date DI"
        Me.XtTabLDRDevisAValiderVACTDES.Weight = 0.6801622908452819R
        '
        'XtTabLDRDevisAValiderDACTPLA
        '
        Me.XtTabLDRDevisAValiderDACTPLA.Dpi = 100.0!
        Me.XtTabLDRDevisAValiderDACTPLA.Name = "XtTabLDRDevisAValiderDACTPLA"
        Me.XtTabLDRDevisAValiderDACTPLA.Text = "Date du devis"
        Me.XtTabLDRDevisAValiderDACTPLA.Weight = 0.64056411176696115R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Dpi = 100.0!
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "Montant €ht"
        Me.XrTableCell4.Weight = 0.61590003206836019R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Dpi = 100.0!
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "Nombre de jours validation"
        Me.XrTableCell5.Weight = 0.71041516142972494R
        '
        'XrLblLDRDevisAValiderTitle
        '
        Me.XrLblLDRDevisAValiderTitle.Dpi = 100.0!
        Me.XrLblLDRDevisAValiderTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline)
        Me.XrLblLDRDevisAValiderTitle.LocationFloat = New DevExpress.Utils.PointFloat(9.99943447!, 10.0001001!)
        Me.XrLblLDRDevisAValiderTitle.Name = "XrLblLDRDevisAValiderTitle"
        Me.XrLblLDRDevisAValiderTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblLDRDevisAValiderTitle.SizeF = New System.Drawing.SizeF(754.999878!, 23.0!)
        Me.XrLblLDRDevisAValiderTitle.StyleName = "XrStyleTitreTableau"
        Me.XrLblLDRDevisAValiderTitle.Text = "Devis restant à valider"
        '
        'ReportFooterLDRDevisAValider
        '
        Me.ReportFooterLDRDevisAValider.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel17})
        Me.ReportFooterLDRDevisAValider.Dpi = 100.0!
        Me.ReportFooterLDRDevisAValider.HeightF = 23.0!
        Me.ReportFooterLDRDevisAValider.Name = "ReportFooterLDRDevisAValider"
        '
        'XrLabel17
        '
        Me.XrLabel17.Dpi = 100.0!
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(314.583313!, 0.0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'DetailReportEquipements
        '
        Me.DetailReportEquipements.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailEquipements, Me.ReportHeaderEquipements, Me.ReportFooterEquipements, Me.DetailReportEquipementsTab})
        Me.DetailReportEquipements.Dpi = 100.0!
        Me.DetailReportEquipements.Level = 2
        Me.DetailReportEquipements.Name = "DetailReportEquipements"
        Me.DetailReportEquipements.Visible = False
        '
        'DetailEquipements
        '
        Me.DetailEquipements.Dpi = 100.0!
        Me.DetailEquipements.HeightF = 0.0!
        Me.DetailEquipements.Name = "DetailEquipements"
        '
        'ReportHeaderEquipements
        '
        Me.ReportHeaderEquipements.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLblEquipementsTitle})
        Me.ReportHeaderEquipements.Dpi = 100.0!
        Me.ReportHeaderEquipements.HeightF = 61.4583282!
        Me.ReportHeaderEquipements.Name = "ReportHeaderEquipements"
        '
        'XrLblEquipementsTitle
        '
        Me.XrLblEquipementsTitle.Dpi = 100.0!
        Me.XrLblEquipementsTitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblEquipementsTitle.LocationFloat = New DevExpress.Utils.PointFloat(9.9993391!, 10.0001001!)
        Me.XrLblEquipementsTitle.Name = "XrLblEquipementsTitle"
        Me.XrLblEquipementsTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblEquipementsTitle.SizeF = New System.Drawing.SizeF(754.999878!, 41.4582405!)
        Me.XrLblEquipementsTitle.StyleName = "XrStyleTitreContrat"
        Me.XrLblEquipementsTitle.Text = "MISE A JOUR DES EQUIPEMENTS"
        '
        'ReportFooterEquipements
        '
        Me.ReportFooterEquipements.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel14})
        Me.ReportFooterEquipements.Dpi = 100.0!
        Me.ReportFooterEquipements.HeightF = 23.0!
        Me.ReportFooterEquipements.Name = "ReportFooterEquipements"
        '
        'DetailReportEquipementsTab
        '
        Me.DetailReportEquipementsTab.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailBauxEquipementsTab, Me.ReportHeaderEquipementsTab, Me.ReportFooterEquipementsTab})
        Me.DetailReportEquipementsTab.DataMember = "api_sp_Rapport_FM_Impression_MAJEquipement"
        Me.DetailReportEquipementsTab.DataSource = Me.SqlDS_Imp_Rapport_Fm_Mensuel
        Me.DetailReportEquipementsTab.Dpi = 100.0!
        Me.DetailReportEquipementsTab.Level = 0
        Me.DetailReportEquipementsTab.Name = "DetailReportEquipementsTab"
        '
        'DetailBauxEquipementsTab
        '
        Me.DetailBauxEquipementsTab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable6})
        Me.DetailBauxEquipementsTab.Dpi = 100.0!
        Me.DetailBauxEquipementsTab.HeightF = 25.0!
        Me.DetailBauxEquipementsTab.Name = "DetailBauxEquipementsTab"
        '
        'ReportHeaderEquipementsTab
        '
        Me.ReportHeaderEquipementsTab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTableEquipementsTabEntete, Me.XrLblEquipementsTabTitle})
        Me.ReportHeaderEquipementsTab.Dpi = 100.0!
        Me.ReportHeaderEquipementsTab.HeightF = 85.4166565!
        Me.ReportHeaderEquipementsTab.Name = "ReportHeaderEquipementsTab"
        '
        'XrTableEquipementsTabEntete
        '
        Me.XrTableEquipementsTabEntete.BackColor = System.Drawing.Color.LightSkyBlue
        Me.XrTableEquipementsTabEntete.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableEquipementsTabEntete.BorderWidth = 0.25!
        Me.XrTableEquipementsTabEntete.Dpi = 100.0!
        Me.XrTableEquipementsTabEntete.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.XrTableEquipementsTabEntete.LocationFloat = New DevExpress.Utils.PointFloat(10.00033!, 50.0!)
        Me.XrTableEquipementsTabEntete.Name = "XrTableEquipementsTabEntete"
        Me.XrTableEquipementsTabEntete.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRowEquipementsTab})
        Me.XrTableEquipementsTabEntete.SizeF = New System.Drawing.SizeF(754.998779!, 35.4166603!)
        Me.XrTableEquipementsTabEntete.StyleName = "XrStyleEnteteTableau"
        Me.XrTableEquipementsTabEntete.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRowEquipementsTab
        '
        Me.XrTableRowEquipementsTab.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XtTabRowEquipementsTabVENSEIGNE, Me.XtTabRowEquipementsTabVSITNOM, Me.XtTabRowEquipementsTabVPRELIB, Me.XtTabRowEquipementsTabVACTDES, Me.XtTabRowEquipementsTabDDATDEMANDE, Me.XrTableCell6})
        Me.XrTableRowEquipementsTab.Dpi = 100.0!
        Me.XrTableRowEquipementsTab.Name = "XrTableRowEquipementsTab"
        Me.XrTableRowEquipementsTab.Weight = 1.0R
        '
        'XtTabRowEquipementsTabVENSEIGNE
        '
        Me.XtTabRowEquipementsTabVENSEIGNE.Dpi = 100.0!
        Me.XtTabRowEquipementsTabVENSEIGNE.Name = "XtTabRowEquipementsTabVENSEIGNE"
        Me.XtTabRowEquipementsTabVENSEIGNE.StylePriority.UseTextAlignment = False
        Me.XtTabRowEquipementsTabVENSEIGNE.Text = "Enseigne"
        Me.XtTabRowEquipementsTabVENSEIGNE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XtTabRowEquipementsTabVENSEIGNE.Weight = 1.041666793823242R
        '
        'XtTabRowEquipementsTabVSITNOM
        '
        Me.XtTabRowEquipementsTabVSITNOM.Dpi = 100.0!
        Me.XtTabRowEquipementsTabVSITNOM.Name = "XtTabRowEquipementsTabVSITNOM"
        Me.XtTabRowEquipementsTabVSITNOM.Text = "Sites"
        Me.XtTabRowEquipementsTabVSITNOM.Weight = 1.661458206176758R
        '
        'XtTabRowEquipementsTabVPRELIB
        '
        Me.XtTabRowEquipementsTabVPRELIB.Dpi = 100.0!
        Me.XtTabRowEquipementsTabVPRELIB.Name = "XtTabRowEquipementsTabVPRELIB"
        Me.XtTabRowEquipementsTabVPRELIB.Text = "Niveau 1"
        Me.XtTabRowEquipementsTabVPRELIB.Weight = 1.0650589423559946R
        '
        'XtTabRowEquipementsTabVACTDES
        '
        Me.XtTabRowEquipementsTabVACTDES.Dpi = 100.0!
        Me.XtTabRowEquipementsTabVACTDES.Name = "XtTabRowEquipementsTabVACTDES"
        Me.XtTabRowEquipementsTabVACTDES.Text = "Niveau 2"
        Me.XtTabRowEquipementsTabVACTDES.Weight = 1.3655908228350819R
        '
        'XtTabRowEquipementsTabDDATDEMANDE
        '
        Me.XtTabRowEquipementsTabDDATDEMANDE.Dpi = 100.0!
        Me.XtTabRowEquipementsTabDDATDEMANDE.Name = "XtTabRowEquipementsTabDDATDEMANDE"
        Me.XtTabRowEquipementsTabDDATDEMANDE.Text = "Niveau 3"
        Me.XtTabRowEquipementsTabDDATDEMANDE.Weight = 1.1683047880535273R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Dpi = 100.0!
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Text = "Date de saisie"
        Me.XrTableCell6.Weight = 0.89791314093209484R
        '
        'XrLblEquipementsTabTitle
        '
        Me.XrLblEquipementsTabTitle.Dpi = 100.0!
        Me.XrLblEquipementsTabTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline)
        Me.XrLblEquipementsTabTitle.LocationFloat = New DevExpress.Utils.PointFloat(10.00033!, 10.0001001!)
        Me.XrLblEquipementsTabTitle.Name = "XrLblEquipementsTabTitle"
        Me.XrLblEquipementsTabTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblEquipementsTabTitle.SizeF = New System.Drawing.SizeF(754.999084!, 23.0!)
        Me.XrLblEquipementsTabTitle.StyleName = "XrStyleTitreTableau"
        Me.XrLblEquipementsTabTitle.Text = "Equipements mise à jour dans le mois"
        '
        'ReportFooterEquipementsTab
        '
        Me.ReportFooterEquipementsTab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel15})
        Me.ReportFooterEquipementsTab.Dpi = 100.0!
        Me.ReportFooterEquipementsTab.HeightF = 23.0!
        Me.ReportFooterEquipementsTab.Name = "ReportFooterEquipementsTab"
        '
        'XrLabel15
        '
        Me.XrLabel15.Dpi = 100.0!
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(337.5!, 0.0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'DetailReportBonInter
        '
        Me.DetailReportBonInter.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailBonInter, Me.ReportHeaderBonInter, Me.ReportFooterBonInter, Me.DetailReportBonInterTab})
        Me.DetailReportBonInter.DataSource = Me.SqlDS_Imp_Rapport_Fm_Mensuel
        Me.DetailReportBonInter.Dpi = 100.0!
        Me.DetailReportBonInter.Level = 3
        Me.DetailReportBonInter.Name = "DetailReportBonInter"
        '
        'DetailBonInter
        '
        Me.DetailBonInter.Dpi = 100.0!
        Me.DetailBonInter.HeightF = 0.0!
        Me.DetailBonInter.Name = "DetailBonInter"
        '
        'ReportHeaderBonInter
        '
        Me.ReportHeaderBonInter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLblBonInterTitle})
        Me.ReportHeaderBonInter.Dpi = 100.0!
        Me.ReportHeaderBonInter.HeightF = 61.8733711!
        Me.ReportHeaderBonInter.Name = "ReportHeaderBonInter"
        '
        'XrLblBonInterTitle
        '
        Me.XrLblBonInterTitle.BackColor = System.Drawing.Color.LightGray
        Me.XrLblBonInterTitle.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLblBonInterTitle.Dpi = 100.0!
        Me.XrLblBonInterTitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLblBonInterTitle.LocationFloat = New DevExpress.Utils.PointFloat(9.99943447!, 10.0001001!)
        Me.XrLblBonInterTitle.Name = "XrLblBonInterTitle"
        Me.XrLblBonInterTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblBonInterTitle.SizeF = New System.Drawing.SizeF(755.0!, 37.2900009!)
        Me.XrLblBonInterTitle.StyleName = "XrStyleTitreContrat"
        Me.XrLblBonInterTitle.Text = "RAPPORT D'INCIDENT ET REMISE DES BONS D'INTERVENTION"
        Me.XrLblBonInterTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ReportFooterBonInter
        '
        Me.ReportFooterBonInter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel18})
        Me.ReportFooterBonInter.Dpi = 100.0!
        Me.ReportFooterBonInter.HeightF = 23.0!
        Me.ReportFooterBonInter.Name = "ReportFooterBonInter"
        '
        'DetailReportBonInterTab
        '
        Me.DetailReportBonInterTab.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailDechetsBonInterTab, Me.ReportHeaderBonInterTab, Me.ReportFooterBonInterTab})
        Me.DetailReportBonInterTab.DataMember = "api_sp_Rapport_FM_Impression_RemiseBonIntervention"
        Me.DetailReportBonInterTab.DataSource = Me.SqlDS_Imp_Rapport_Fm_Mensuel
        Me.DetailReportBonInterTab.Dpi = 100.0!
        Me.DetailReportBonInterTab.Level = 0
        Me.DetailReportBonInterTab.Name = "DetailReportBonInterTab"
        '
        'DetailDechetsBonInterTab
        '
        Me.DetailDechetsBonInterTab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable7})
        Me.DetailDechetsBonInterTab.Dpi = 100.0!
        Me.DetailDechetsBonInterTab.HeightF = 25.0!
        Me.DetailDechetsBonInterTab.Name = "DetailDechetsBonInterTab"
        '
        'ReportHeaderBonInterTab
        '
        Me.ReportHeaderBonInterTab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTableBonInterTabEntete, Me.XrLblBonInterTabTitle})
        Me.ReportHeaderBonInterTab.Dpi = 100.0!
        Me.ReportHeaderBonInterTab.HeightF = 85.4166565!
        Me.ReportHeaderBonInterTab.Name = "ReportHeaderBonInterTab"
        '
        'XrTableBonInterTabEntete
        '
        Me.XrTableBonInterTabEntete.BackColor = System.Drawing.Color.LightSkyBlue
        Me.XrTableBonInterTabEntete.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableBonInterTabEntete.BorderWidth = 0.25!
        Me.XrTableBonInterTabEntete.Dpi = 100.0!
        Me.XrTableBonInterTabEntete.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.XrTableBonInterTabEntete.LocationFloat = New DevExpress.Utils.PointFloat(9.99943447!, 50.0!)
        Me.XrTableBonInterTabEntete.Name = "XrTableBonInterTabEntete"
        Me.XrTableBonInterTabEntete.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRowEnteteBonInterTab})
        Me.XrTableBonInterTabEntete.SizeF = New System.Drawing.SizeF(754.999695!, 35.4166603!)
        Me.XrTableBonInterTabEntete.StyleName = "XrStyleEnteteTableau"
        Me.XrTableBonInterTabEntete.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRowEnteteBonInterTab
        '
        Me.XrTableRowEnteteBonInterTab.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableRowEnteteBonInterTabVENSEIGNE, Me.XrTableRowEnteteBonInterTabVSITNOM, Me.XrTableRowEnteteBonInterTabVPRELIB, Me.XrTableRowEnteteBonInterTabVACTDES, Me.XrTableRowEnteteBonInterTabDDATDEMANDE, Me.XrTableCell7, Me.XrTableCell8})
        Me.XrTableRowEnteteBonInterTab.Dpi = 100.0!
        Me.XrTableRowEnteteBonInterTab.Name = "XrTableRowEnteteBonInterTab"
        Me.XrTableRowEnteteBonInterTab.Weight = 1.0R
        '
        'XrTableRowEnteteBonInterTabVENSEIGNE
        '
        Me.XrTableRowEnteteBonInterTabVENSEIGNE.Dpi = 100.0!
        Me.XrTableRowEnteteBonInterTabVENSEIGNE.Name = "XrTableRowEnteteBonInterTabVENSEIGNE"
        Me.XrTableRowEnteteBonInterTabVENSEIGNE.StylePriority.UseTextAlignment = False
        Me.XrTableRowEnteteBonInterTabVENSEIGNE.Text = "Enseigne"
        Me.XrTableRowEnteteBonInterTabVENSEIGNE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableRowEnteteBonInterTabVENSEIGNE.Weight = 1.041666793823242R
        '
        'XrTableRowEnteteBonInterTabVSITNOM
        '
        Me.XrTableRowEnteteBonInterTabVSITNOM.Dpi = 100.0!
        Me.XrTableRowEnteteBonInterTabVSITNOM.Name = "XrTableRowEnteteBonInterTabVSITNOM"
        Me.XrTableRowEnteteBonInterTabVSITNOM.Text = "Sites"
        Me.XrTableRowEnteteBonInterTabVSITNOM.Weight = 1.661458206176758R
        '
        'XrTableRowEnteteBonInterTabVPRELIB
        '
        Me.XrTableRowEnteteBonInterTabVPRELIB.Dpi = 100.0!
        Me.XrTableRowEnteteBonInterTabVPRELIB.Name = "XrTableRowEnteteBonInterTabVPRELIB"
        Me.XrTableRowEnteteBonInterTabVPRELIB.Text = "Sujet"
        Me.XrTableRowEnteteBonInterTabVPRELIB.Weight = 1.6213499452035254R
        '
        'XrTableRowEnteteBonInterTabVACTDES
        '
        Me.XrTableRowEnteteBonInterTabVACTDES.Dpi = 100.0!
        Me.XrTableRowEnteteBonInterTabVACTDES.Name = "XrTableRowEnteteBonInterTabVACTDES"
        Me.XrTableRowEnteteBonInterTabVACTDES.Text = "Date/h DI"
        Me.XrTableRowEnteteBonInterTabVACTDES.Weight = 0.6205534814379573R
        '
        'XrTableRowEnteteBonInterTabDDATDEMANDE
        '
        Me.XrTableRowEnteteBonInterTabDDATDEMANDE.Dpi = 100.0!
        Me.XrTableRowEnteteBonInterTabDDATDEMANDE.Name = "XrTableRowEnteteBonInterTabDDATDEMANDE"
        Me.XrTableRowEnteteBonInterTabDDATDEMANDE.Text = "Date /h réalisation"
        Me.XrTableRowEnteteBonInterTabDDATDEMANDE.Weight = 0.79951090806038416R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Dpi = 100.0!
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Text = "Date/h rapport"
        Me.XrTableCell7.Weight = 0.74503853883574389R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Dpi = 100.0!
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Text = "Délai rapport (h)"
        Me.XrTableCell8.Weight = 0.7104154711658095R
        '
        'XrLblBonInterTabTitle
        '
        Me.XrLblBonInterTabTitle.Dpi = 100.0!
        Me.XrLblBonInterTabTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline)
        Me.XrLblBonInterTabTitle.LocationFloat = New DevExpress.Utils.PointFloat(10.00033!, 10.0001001!)
        Me.XrLblBonInterTabTitle.Name = "XrLblBonInterTabTitle"
        Me.XrLblBonInterTabTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLblBonInterTabTitle.SizeF = New System.Drawing.SizeF(754.999084!, 23.0!)
        Me.XrLblBonInterTabTitle.StyleName = "XrStyleTitreTableau"
        Me.XrLblBonInterTabTitle.Text = "Engagement : 24h ouvrables suivant la clôture de l'incident"
        '
        'ReportFooterBonInterTab
        '
        Me.ReportFooterBonInterTab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel16})
        Me.ReportFooterBonInterTab.Dpi = 100.0!
        Me.ReportFooterBonInterTab.HeightF = 23.0!
        Me.ReportFooterBonInterTab.Name = "ReportFooterBonInterTab"
        '
        'XrLabel16
        '
        Me.XrLabel16.Dpi = 100.0!
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(337.5!, 0.0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'XrCrossBandBoxBordersAllPage
        '
        Me.XrCrossBandBoxBordersAllPage.BorderColor = System.Drawing.Color.Silver
        Me.XrCrossBandBoxBordersAllPage.BorderWidth = 1.0!
        Me.XrCrossBandBoxBordersAllPage.Dpi = 100.0!
        Me.XrCrossBandBoxBordersAllPage.EndBand = Me.BottomMargin
        Me.XrCrossBandBoxBordersAllPage.EndPointFloat = New DevExpress.Utils.PointFloat(0.0!, 24.9165897!)
        Me.XrCrossBandBoxBordersAllPage.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 21.875!)
        Me.XrCrossBandBoxBordersAllPage.Name = "XrCrossBandBoxBordersAllPage"
        Me.XrCrossBandBoxBordersAllPage.StartBand = Me.TopMargin
        Me.XrCrossBandBoxBordersAllPage.StartPointFloat = New DevExpress.Utils.PointFloat(0.0!, 21.875!)
        Me.XrCrossBandBoxBordersAllPage.WidthF = 775.0!
        '
        'XrStyleTitreTableau
        '
        Me.XrStyleTitreTableau.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrStyleTitreTableau.Name = "XrStyleTitreTableau"
        Me.XrStyleTitreTableau.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrStyleTitreContrat
        '
        Me.XrStyleTitreContrat.BackColor = System.Drawing.Color.LightGray
        Me.XrStyleTitreContrat.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrStyleTitreContrat.BorderWidth = 0.5!
        Me.XrStyleTitreContrat.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrStyleTitreContrat.Name = "XrStyleTitreContrat"
        Me.XrStyleTitreContrat.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrStyleEnteteTableau
        '
        Me.XrStyleEnteteTableau.BackColor = System.Drawing.Color.LightSkyBlue
        Me.XrStyleEnteteTableau.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrStyleEnteteTableau.BorderWidth = 0.25!
        Me.XrStyleEnteteTableau.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrStyleEnteteTableau.Name = "XrStyleEnteteTableau"
        Me.XrStyleEnteteTableau.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrStyleTableauContenu
        '
        Me.XrStyleTableauContenu.BackColor = System.Drawing.Color.LightCyan
        Me.XrStyleTableauContenu.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrStyleTableauContenu.BorderWidth = 0.25!
        Me.XrStyleTableauContenu.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrStyleTableauContenu.Name = "XrStyleTableauContenu"
        Me.XrStyleTableauContenu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'DetailReportDepUrgTechOnSite
        '
        Me.DetailReportDepUrgTechOnSite.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailDepUrgTechOnSite, Me.ReportHeaderDepUrgTechOnSite, Me.ReportFooterDepUrgTechOnSite, Me.DetailReportDepUrgTechOnSiteTab})
        Me.DetailReportDepUrgTechOnSite.Dpi = 100.0!
        Me.DetailReportDepUrgTechOnSite.Level = 4
        Me.DetailReportDepUrgTechOnSite.Name = "DetailReportDepUrgTechOnSite"
        '
        'DetailDepUrgTechOnSite
        '
        Me.DetailDepUrgTechOnSite.Dpi = 100.0!
        Me.DetailDepUrgTechOnSite.HeightF = 0.0!
        Me.DetailDepUrgTechOnSite.Name = "DetailDepUrgTechOnSite"
        '
        'ReportHeaderDepUrgTechOnSite
        '
        Me.ReportHeaderDepUrgTechOnSite.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2})
        Me.ReportHeaderDepUrgTechOnSite.Dpi = 100.0!
        Me.ReportHeaderDepUrgTechOnSite.HeightF = 63.5416718!
        Me.ReportHeaderDepUrgTechOnSite.Name = "ReportHeaderDepUrgTechOnSite"
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.LightGray
        Me.XrLabel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.Dpi = 100.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(9.99914837!, 9.99997425!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(755.0!, 37.2900009!)
        Me.XrLabel2.StyleName = "XrStyleTitreContrat"
        Me.XrLabel2.Text = "REACTIVITE SUR DEPANNAGE URGENT (Tech sur site)"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ReportFooterDepUrgTechOnSite
        '
        Me.ReportFooterDepUrgTechOnSite.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel19})
        Me.ReportFooterDepUrgTechOnSite.Dpi = 100.0!
        Me.ReportFooterDepUrgTechOnSite.HeightF = 23.0!
        Me.ReportFooterDepUrgTechOnSite.Name = "ReportFooterDepUrgTechOnSite"
        '
        'DetailReportDepUrgTechOnSiteTab
        '
        Me.DetailReportDepUrgTechOnSiteTab.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailDepUrgTechOnSiteTab, Me.ReportHeaderDepUrgTechOnSiteTab, Me.ReportFooterDepUrgTechOnSiteTab})
        Me.DetailReportDepUrgTechOnSiteTab.DataMember = "api_sp_Rapport_FM_Impression_DepannageUrgTechOnSite"
        Me.DetailReportDepUrgTechOnSiteTab.DataSource = Me.SqlDS_Imp_Rapport_Fm_Mensuel
        Me.DetailReportDepUrgTechOnSiteTab.Dpi = 100.0!
        Me.DetailReportDepUrgTechOnSiteTab.Level = 0
        Me.DetailReportDepUrgTechOnSiteTab.Name = "DetailReportDepUrgTechOnSiteTab"
        '
        'DetailDepUrgTechOnSiteTab
        '
        Me.DetailDepUrgTechOnSiteTab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable8})
        Me.DetailDepUrgTechOnSiteTab.Dpi = 100.0!
        Me.DetailDepUrgTechOnSiteTab.HeightF = 25.0!
        Me.DetailDepUrgTechOnSiteTab.Name = "DetailDepUrgTechOnSiteTab"
        '
        'ReportHeaderDepUrgTechOnSiteTab
        '
        Me.ReportHeaderDepUrgTechOnSiteTab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrTable1})
        Me.ReportHeaderDepUrgTechOnSiteTab.Dpi = 100.0!
        Me.ReportHeaderDepUrgTechOnSiteTab.HeightF = 101.666603!
        Me.ReportHeaderDepUrgTechOnSiteTab.Name = "ReportHeaderDepUrgTechOnSiteTab"
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 100.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.0009298!, 12.2917204!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(754.999084!, 23.0!)
        Me.XrLabel3.StyleName = "XrStyleTitreTableau"
        Me.XrLabel3.Text = "Engagement : 15 mn"
        '
        'XrTable1
        '
        Me.XrTable1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.BorderWidth = 0.25!
        Me.XrTable1.Dpi = 100.0!
        Me.XrTable1.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(10.0000296!, 52.2916107!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(754.999084!, 49.375!)
        Me.XrTable1.StyleName = "XrStyleEnteteTableau"
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell14})
        Me.XrTableRow1.Dpi = 100.0!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Dpi = 100.0!
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "Enseigne"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell9.Weight = 1.041666793823242R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Dpi = 100.0!
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Text = "Sites"
        Me.XrTableCell10.Weight = 1.661458206176758R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Dpi = 100.0!
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Text = "Sujet"
        Me.XrTableCell11.Weight = 2.2418987616357557R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Dpi = 100.0!
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Text = "Date/h DI"
        Me.XrTableCell12.Weight = 0.57616350034146213R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Dpi = 100.0!
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Text = "Date /h réalisation"
        Me.XrTableCell13.Weight = 0.96838538062215052R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Dpi = 100.0!
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Text = "Délai intervention (mn)"
        Me.XrTableCell14.Weight = 0.7104148890727493R
        '
        'ReportFooterDepUrgTechOnSiteTab
        '
        Me.ReportFooterDepUrgTechOnSiteTab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4})
        Me.ReportFooterDepUrgTechOnSiteTab.Dpi = 100.0!
        Me.ReportFooterDepUrgTechOnSiteTab.HeightF = 23.0!
        Me.ReportFooterDepUrgTechOnSiteTab.Name = "ReportFooterDepUrgTechOnSiteTab"
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 100.0!
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(330.208313!, 0.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'DetailReportDepUrgTechOutSite
        '
        Me.DetailReportDepUrgTechOutSite.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailDepUrgTechOutSite, Me.ReportHeaderDepUrgTechOutSite, Me.ReportFooterDepUrgTechOutSite, Me.DetailReportDepUrgTechOutSiteTab})
        Me.DetailReportDepUrgTechOutSite.Dpi = 100.0!
        Me.DetailReportDepUrgTechOutSite.Level = 5
        Me.DetailReportDepUrgTechOutSite.Name = "DetailReportDepUrgTechOutSite"
        '
        'DetailDepUrgTechOutSite
        '
        Me.DetailDepUrgTechOutSite.Dpi = 100.0!
        Me.DetailDepUrgTechOutSite.HeightF = 0.0!
        Me.DetailDepUrgTechOutSite.Name = "DetailDepUrgTechOutSite"
        '
        'ReportHeaderDepUrgTechOutSite
        '
        Me.ReportHeaderDepUrgTechOutSite.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel8})
        Me.ReportHeaderDepUrgTechOutSite.Dpi = 100.0!
        Me.ReportHeaderDepUrgTechOutSite.HeightF = 56.25!
        Me.ReportHeaderDepUrgTechOutSite.Name = "ReportHeaderDepUrgTechOutSite"
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.LightGray
        Me.XrLabel8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel8.Dpi = 100.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(9.99914837!, 9.99997425!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(755.0!, 37.2900009!)
        Me.XrLabel8.StyleName = "XrStyleTitreContrat"
        Me.XrLabel8.Text = "REACTVITE SUR DEPANNAGE URGENT (Tech hors site)"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ReportFooterDepUrgTechOutSite
        '
        Me.ReportFooterDepUrgTechOutSite.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel20})
        Me.ReportFooterDepUrgTechOutSite.Dpi = 100.0!
        Me.ReportFooterDepUrgTechOutSite.HeightF = 23.0!
        Me.ReportFooterDepUrgTechOutSite.Name = "ReportFooterDepUrgTechOutSite"
        '
        'DetailReportDepUrgTechOutSiteTab
        '
        Me.DetailReportDepUrgTechOutSiteTab.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailDepUrgTechOutSiteTab, Me.ReportHeaderDepUrgTechOutSiteTab, Me.ReportFooterDepUrgTechOutSiteTab})
        Me.DetailReportDepUrgTechOutSiteTab.DataMember = "api_sp_Rapport_FM_Impression_DepannageUrgTechOutSite"
        Me.DetailReportDepUrgTechOutSiteTab.DataSource = Me.SqlDS_Imp_Rapport_Fm_Mensuel
        Me.DetailReportDepUrgTechOutSiteTab.Dpi = 100.0!
        Me.DetailReportDepUrgTechOutSiteTab.Level = 0
        Me.DetailReportDepUrgTechOutSiteTab.Name = "DetailReportDepUrgTechOutSiteTab"
        '
        'DetailDepUrgTechOutSiteTab
        '
        Me.DetailDepUrgTechOutSiteTab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable9})
        Me.DetailDepUrgTechOutSiteTab.Dpi = 100.0!
        Me.DetailDepUrgTechOutSiteTab.HeightF = 25.0!
        Me.DetailDepUrgTechOutSiteTab.Name = "DetailDepUrgTechOutSiteTab"
        '
        'ReportHeaderDepUrgTechOutSiteTab
        '
        Me.ReportHeaderDepUrgTechOutSiteTab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7, Me.XrTable2})
        Me.ReportHeaderDepUrgTechOutSiteTab.Dpi = 100.0!
        Me.ReportHeaderDepUrgTechOutSiteTab.HeightF = 94.6874466!
        Me.ReportHeaderDepUrgTechOutSiteTab.Name = "ReportHeaderDepUrgTechOutSiteTab"
        '
        'XrLabel7
        '
        Me.XrLabel7.Dpi = 100.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(10.0009003!, 5.31255007!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(754.999084!, 23.0!)
        Me.XrLabel7.StyleName = "XrStyleTitreTableau"
        Me.XrLabel7.Text = "Engagement : 2h ouvrables"
        '
        'XrTable2
        '
        Me.XrTable2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.BorderWidth = 0.25!
        Me.XrTable2.Dpi = 100.0!
        Me.XrTable2.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 45.3124504!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(754.999084!, 49.375!)
        Me.XrTable2.StyleName = "XrStyleEnteteTableau"
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell15, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell18, Me.XrTableCell19, Me.XrTableCell20})
        Me.XrTableRow2.Dpi = 100.0!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Dpi = 100.0!
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.StylePriority.UseTextAlignment = False
        Me.XrTableCell15.Text = "Enseigne"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell15.Weight = 1.041666793823242R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Dpi = 100.0!
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Text = "Sites"
        Me.XrTableCell16.Weight = 1.661458206176758R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Dpi = 100.0!
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Text = "Sujet"
        Me.XrTableCell17.Weight = 2.2418987616357557R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Dpi = 100.0!
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Text = "Date/h DI"
        Me.XrTableCell18.Weight = 0.57616350034146213R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Dpi = 100.0!
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Text = "Date /h réalisation"
        Me.XrTableCell19.Weight = 0.96838538062215052R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Dpi = 100.0!
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.Text = "Délai intervention (mn)"
        Me.XrTableCell20.Weight = 0.7104148890727493R
        '
        'ReportFooterDepUrgTechOutSiteTab
        '
        Me.ReportFooterDepUrgTechOutSiteTab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel9})
        Me.ReportFooterDepUrgTechOutSiteTab.Dpi = 100.0!
        Me.ReportFooterDepUrgTechOutSiteTab.HeightF = 23.0!
        Me.ReportFooterDepUrgTechOutSiteTab.Name = "ReportFooterDepUrgTechOutSiteTab"
        '
        'XrLabel9
        '
        Me.XrLabel9.Dpi = 100.0!
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(330.208313!, 0.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'DetailReportDepNoUrg
        '
        Me.DetailReportDepNoUrg.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailDepNoUrg, Me.ReportHeaderDepNoUrg, Me.ReportFooterDepNoUrg, Me.DetailReportDepNoUrgTab})
        Me.DetailReportDepNoUrg.Dpi = 100.0!
        Me.DetailReportDepNoUrg.Level = 6
        Me.DetailReportDepNoUrg.Name = "DetailReportDepNoUrg"
        '
        'DetailDepNoUrg
        '
        Me.DetailDepNoUrg.Dpi = 100.0!
        Me.DetailDepNoUrg.HeightF = 0.0!
        Me.DetailDepNoUrg.Name = "DetailDepNoUrg"
        '
        'ReportHeaderDepNoUrg
        '
        Me.ReportHeaderDepNoUrg.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10})
        Me.ReportHeaderDepNoUrg.Dpi = 100.0!
        Me.ReportHeaderDepNoUrg.HeightF = 58.3333282!
        Me.ReportHeaderDepNoUrg.Name = "ReportHeaderDepNoUrg"
        '
        'XrLabel10
        '
        Me.XrLabel10.BackColor = System.Drawing.Color.LightGray
        Me.XrLabel10.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel10.Dpi = 100.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(9.99912453!, 9.99997425!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(755.0!, 37.2900009!)
        Me.XrLabel10.StyleName = "XrStyleTitreContrat"
        Me.XrLabel10.Text = "REACTIVITE SUR DEPANNAGE NON URGENT"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ReportFooterDepNoUrg
        '
        Me.ReportFooterDepNoUrg.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel21})
        Me.ReportFooterDepNoUrg.Dpi = 100.0!
        Me.ReportFooterDepNoUrg.HeightF = 23.0!
        Me.ReportFooterDepNoUrg.Name = "ReportFooterDepNoUrg"
        '
        'DetailReportDepNoUrgTab
        '
        Me.DetailReportDepNoUrgTab.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.DetailDepNoUrgTab, Me.ReportHeaderDepNoUrgTab, Me.ReportFooterDepNoUrgTab})
        Me.DetailReportDepNoUrgTab.DataMember = "api_sp_Rapport_FM_Impression_DepannageNonUrg"
        Me.DetailReportDepNoUrgTab.DataSource = Me.SqlDS_Imp_Rapport_Fm_Mensuel
        Me.DetailReportDepNoUrgTab.Dpi = 100.0!
        Me.DetailReportDepNoUrgTab.Level = 0
        Me.DetailReportDepNoUrgTab.Name = "DetailReportDepNoUrgTab"
        '
        'DetailDepNoUrgTab
        '
        Me.DetailDepNoUrgTab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable10})
        Me.DetailDepNoUrgTab.Dpi = 100.0!
        Me.DetailDepNoUrgTab.HeightF = 25.0!
        Me.DetailDepNoUrgTab.Name = "DetailDepNoUrgTab"
        '
        'ReportHeaderDepNoUrgTab
        '
        Me.ReportHeaderDepNoUrgTab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel11, Me.XrTable3})
        Me.ReportHeaderDepNoUrgTab.Dpi = 100.0!
        Me.ReportHeaderDepNoUrgTab.HeightF = 94.6874466!
        Me.ReportHeaderDepNoUrgTab.Name = "ReportHeaderDepNoUrgTab"
        '
        'XrLabel11
        '
        Me.XrLabel11.Dpi = 100.0!
        Me.XrLabel11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(10.0009003!, 5.31255007!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(754.999084!, 23.0!)
        Me.XrLabel11.StyleName = "XrStyleTitreTableau"
        Me.XrLabel11.Text = "Engagement : 24h ouvrables"
        '
        'XrTable3
        '
        Me.XrTable3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.BorderWidth = 0.25!
        Me.XrTable3.Dpi = 100.0!
        Me.XrTable3.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 45.3124504!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(754.999084!, 49.375!)
        Me.XrTable3.StyleName = "XrStyleEnteteTableau"
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell21, Me.XrTableCell22, Me.XrTableCell23, Me.XrTableCell24, Me.XrTableCell25, Me.XrTableCell26})
        Me.XrTableRow3.Dpi = 100.0!
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.Dpi = 100.0!
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        Me.XrTableCell21.Text = "Enseigne"
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell21.Weight = 1.041666793823242R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.Dpi = 100.0!
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.Text = "Sites"
        Me.XrTableCell22.Weight = 1.661458206176758R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.Dpi = 100.0!
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.Text = "Sujet"
        Me.XrTableCell23.Weight = 2.2418987616357557R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.Dpi = 100.0!
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.Text = "Date/h DI"
        Me.XrTableCell24.Weight = 0.57616350034146213R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.Dpi = 100.0!
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.Text = "Date /h réalisation"
        Me.XrTableCell25.Weight = 0.96838538062215052R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Dpi = 100.0!
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.Text = "Délai intervention (mn)"
        Me.XrTableCell26.Weight = 0.7104148890727493R
        '
        'ReportFooterDepNoUrgTab
        '
        Me.ReportFooterDepNoUrgTab.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12})
        Me.ReportFooterDepNoUrgTab.Dpi = 100.0!
        Me.ReportFooterDepNoUrgTab.HeightF = 23.0!
        Me.ReportFooterDepNoUrgTab.Name = "ReportFooterDepNoUrgTab"
        '
        'XrLabel12
        '
        Me.XrLabel12.Dpi = 100.0!
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(330.208313!, 0.0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'XrTable4
        '
        Me.XrTable4.Dpi = 100.0!
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(10.0009298!, 0.0!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(754.99823!, 25.0!)
        Me.XrTable4.StyleName = "XrStyleTableauContenu"
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell27, Me.XrTableCell28, Me.XrTableCell29, Me.XrTableCell30, Me.XrTableCell31, Me.XrTableCell32})
        Me.XrTableRow4.Dpi = 100.0!
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 11.5R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_PlanRealisation.VSITENSEIGNE")})
        Me.XrTableCell27.Dpi = 100.0!
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.Text = "XrTableCell27"
        Me.XrTableCell27.Weight = 0.47965343544948891R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_PlanRealisation.VSITNOM")})
        Me.XrTableCell28.Dpi = 100.0!
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.Text = "XrTableCell28"
        Me.XrTableCell28.Weight = 0.7082044503983792R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_PlanRealisation.VTYPECONTRAT")})
        Me.XrTableCell29.Dpi = 100.0!
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.Text = "XrTableCell29"
        Me.XrTableCell29.Weight = 1.1669177775524227R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_PlanRealisation.NBPLA")})
        Me.XrTableCell30.Dpi = 100.0!
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.Text = "XrTableCell30"
        Me.XrTableCell30.Weight = 0.38072029668075258R
        '
        'XrTableCell31
        '
        Me.XrTableCell31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_PlanRealisation.NBEXE")})
        Me.XrTableCell31.Dpi = 100.0!
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.Text = "XrTableCell31"
        Me.XrTableCell31.Weight = 0.35478183044851158R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_PlanRealisation.TXREA", "{0:0%}")})
        Me.XrTableCell32.Dpi = 100.0!
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.Text = "XrTableCell32"
        Me.XrTableCell32.Weight = 0.33829363804187351R
        '
        'XrTable5
        '
        Me.XrTable5.Dpi = 100.0!
        Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(9.99912453!, 0.0!)
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5})
        Me.XrTable5.SizeF = New System.Drawing.SizeF(755.000916!, 25.0!)
        Me.XrTable5.StyleName = "XrStyleTableauContenu"
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell33, Me.XrTableCell34, Me.XrTableCell35, Me.XrTableCell36, Me.XrTableCell37, Me.XrTableCell38, Me.XrTableCell39})
        Me.XrTableRow5.Dpi = 100.0!
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 11.5R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_LDRDevisAValider.VSITENSEIGNE")})
        Me.XrTableCell33.Dpi = 100.0!
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.Text = "XrTableCell33"
        Me.XrTableCell33.Weight = 1.3503247875049291R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_LDRDevisAValider.VSITNOM")})
        Me.XrTableCell34.Dpi = 100.0!
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.Text = "XrTableCell34"
        Me.XrTableCell34.Weight = 1.883298878824522R
        '
        'XrTableCell35
        '
        Me.XrTableCell35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_LDRDevisAValider.VTYPECONTRAT")})
        Me.XrTableCell35.Dpi = 100.0!
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.Text = "XrTableCell35"
        Me.XrTableCell35.Weight = 2.6683515584373096R
        '
        'XrTableCell36
        '
        Me.XrTableCell36.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_LDRDevisAValider.DDINDAT")})
        Me.XrTableCell36.Dpi = 100.0!
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.Text = "XrTableCell36"
        Me.XrTableCell36.Weight = 0.88169114995547515R
        '
        'XrTableCell37
        '
        Me.XrTableCell37.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_LDRDevisAValider.DDCLDAT")})
        Me.XrTableCell37.Dpi = 100.0!
        Me.XrTableCell37.Name = "XrTableCell37"
        Me.XrTableCell37.Text = "XrTableCell37"
        Me.XrTableCell37.Weight = 0.83036093806159372R
        '
        'XrTableCell38
        '
        Me.XrTableCell38.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_LDRDevisAValider.NDCLHT")})
        Me.XrTableCell38.Dpi = 100.0!
        Me.XrTableCell38.Name = "XrTableCell38"
        Me.XrTableCell38.Text = "XrTableCell38"
        Me.XrTableCell38.Weight = 0.79838900784218658R
        '
        'XrTableCell39
        '
        Me.XrTableCell39.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_LDRDevisAValider.DATEDIFFVALID")})
        Me.XrTableCell39.Dpi = 100.0!
        Me.XrTableCell39.Name = "XrTableCell39"
        Me.XrTableCell39.Text = "XrTableCell39"
        Me.XrTableCell39.Weight = 0.92091701270731652R
        '
        'XrLabel13
        '
        Me.XrLabel13.Dpi = 100.0!
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(314.583313!, 3.0416491!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'XrTable6
        '
        Me.XrTable6.Dpi = 100.0!
        Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(10.0009298!, 0.0!)
        Me.XrTable6.Name = "XrTable6"
        Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6})
        Me.XrTable6.SizeF = New System.Drawing.SizeF(754.99823!, 25.0!)
        Me.XrTable6.StyleName = "XrStyleTableauContenu"
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell40, Me.XrTableCell41, Me.XrTableCell42, Me.XrTableCell43, Me.XrTableCell44, Me.XrTableCell45})
        Me.XrTableRow6.Dpi = 100.0!
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 11.5R
        '
        'XrTableCell40
        '
        Me.XrTableCell40.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_MAJEquipement.VSITENSEIGNE")})
        Me.XrTableCell40.Dpi = 100.0!
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.Text = "XrTableCell40"
        Me.XrTableCell40.Weight = 0.49603120997590033R
        '
        'XrTableCell41
        '
        Me.XrTableCell41.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_MAJEquipement.VSITNOM")})
        Me.XrTableCell41.Dpi = 100.0!
        Me.XrTableCell41.Name = "XrTableCell41"
        Me.XrTableCell41.Text = "XrTableCell41"
        Me.XrTableCell41.Weight = 0.79117061627416807R
        '
        'XrTableCell42
        '
        Me.XrTableCell42.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_MAJEquipement.VNIV1")})
        Me.XrTableCell42.Dpi = 100.0!
        Me.XrTableCell42.Name = "XrTableCell42"
        Me.XrTableCell42.Text = "XrTableCell42"
        Me.XrTableCell42.Weight = 0.50717180935547446R
        '
        'XrTableCell43
        '
        Me.XrTableCell43.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_MAJEquipement.VNIV2")})
        Me.XrTableCell43.Dpi = 100.0!
        Me.XrTableCell43.Name = "XrTableCell43"
        Me.XrTableCell43.Text = "XrTableCell43"
        Me.XrTableCell43.Weight = 0.650282667348137R
        '
        'XrTableCell44
        '
        Me.XrTableCell44.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_MAJEquipement.VNIV3")})
        Me.XrTableCell44.Dpi = 100.0!
        Me.XrTableCell44.Name = "XrTableCell44"
        Me.XrTableCell44.Text = "XrTableCell44"
        Me.XrTableCell44.Weight = 0.55633648787088863R
        '
        'XrTableCell45
        '
        Me.XrTableCell45.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_MAJEquipement.DATESAISIE")})
        Me.XrTableCell45.Dpi = 100.0!
        Me.XrTableCell45.Name = "XrTableCell45"
        Me.XrTableCell45.Text = "XrTableCell45"
        Me.XrTableCell45.Weight = 0.42757863774685989R
        '
        'XrLabel14
        '
        Me.XrLabel14.Dpi = 100.0!
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(337.5!, 0.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'XrTable7
        '
        Me.XrTable7.Dpi = 100.0!
        Me.XrTable7.LocationFloat = New DevExpress.Utils.PointFloat(10.0009298!, 0.0!)
        Me.XrTable7.Name = "XrTable7"
        Me.XrTable7.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7})
        Me.XrTable7.SizeF = New System.Drawing.SizeF(754.99823!, 25.0!)
        Me.XrTable7.StyleName = "XrStyleTableauContenu"
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell46, Me.XrTableCell47, Me.XrTableCell48, Me.XrTableCell49, Me.XrTableCell50, Me.XrTableCell51, Me.XrTableCell52})
        Me.XrTableRow7.Dpi = 100.0!
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 11.5R
        '
        'XrTableCell46
        '
        Me.XrTableCell46.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_RemiseBonIntervention.VSITENSEIGNE")})
        Me.XrTableCell46.Dpi = 100.0!
        Me.XrTableCell46.Name = "XrTableCell46"
        Me.XrTableCell46.Text = "XrTableCell46"
        Me.XrTableCell46.Weight = 1.3502943828149603R
        '
        'XrTableCell47
        '
        Me.XrTableCell47.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_RemiseBonIntervention.VSITNOM")})
        Me.XrTableCell47.Dpi = 100.0!
        Me.XrTableCell47.Name = "XrTableCell47"
        Me.XrTableCell47.Text = "XrTableCell47"
        Me.XrTableCell47.Weight = 2.1537543324620509R
        '
        'XrTableCell48
        '
        Me.XrTableCell48.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_RemiseBonIntervention.VACTDES")})
        Me.XrTableCell48.Dpi = 100.0!
        Me.XrTableCell48.Name = "XrTableCell48"
        Me.XrTableCell48.Text = "XrTableCell48"
        Me.XrTableCell48.Weight = 2.1017497782855701R
        '
        'XrTableCell49
        '
        Me.XrTableCell49.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_RemiseBonIntervention.DDINDAT")})
        Me.XrTableCell49.Dpi = 100.0!
        Me.XrTableCell49.Name = "XrTableCell49"
        Me.XrTableCell49.Text = "XrTableCell49"
        Me.XrTableCell49.Weight = 0.80442576252288722R
        '
        'XrTableCell50
        '
        Me.XrTableCell50.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_RemiseBonIntervention.DACTDEX")})
        Me.XrTableCell50.Dpi = 100.0!
        Me.XrTableCell50.Name = "XrTableCell50"
        Me.XrTableCell50.Text = "XrTableCell50"
        Me.XrTableCell50.Weight = 1.036404524502277R
        '
        'XrTableCell51
        '
        Me.XrTableCell51.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_RemiseBonIntervention.DDATECRE")})
        Me.XrTableCell51.Dpi = 100.0!
        Me.XrTableCell51.Name = "XrTableCell51"
        Me.XrTableCell51.Text = "XrTableCell51"
        Me.XrTableCell51.Weight = 0.96579500983476729R
        '
        'XrTableCell52
        '
        Me.XrTableCell52.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_RemiseBonIntervention.diffenh")})
        Me.XrTableCell52.Dpi = 100.0!
        Me.XrTableCell52.Name = "XrTableCell52"
        Me.XrTableCell52.Text = "XrTableCell52"
        Me.XrTableCell52.Weight = 0.92090954291082006R
        '
        'XrLabel18
        '
        Me.XrLabel18.Dpi = 100.0!
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(337.5!, 0.0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'XrLabel19
        '
        Me.XrLabel19.Dpi = 100.0!
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(330.208313!, 0.0!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'XrTable8
        '
        Me.XrTable8.Dpi = 100.0!
        Me.XrTable8.LocationFloat = New DevExpress.Utils.PointFloat(10.0009298!, 0.0!)
        Me.XrTable8.Name = "XrTable8"
        Me.XrTable8.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow8})
        Me.XrTable8.SizeF = New System.Drawing.SizeF(754.99823!, 25.0!)
        Me.XrTable8.StyleName = "XrStyleTableauContenu"
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell53, Me.XrTableCell54, Me.XrTableCell55, Me.XrTableCell56, Me.XrTableCell57, Me.XrTableCell58})
        Me.XrTableRow8.Dpi = 100.0!
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Weight = 11.5R
        '
        'XrTableCell53
        '
        Me.XrTableCell53.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_DepannageUrgTechOnSite.VSITENSEIGNE")})
        Me.XrTableCell53.Dpi = 100.0!
        Me.XrTableCell53.Name = "XrTableCell53"
        Me.XrTableCell53.Text = "XrTableCell53"
        Me.XrTableCell53.Weight = 0.48322925004869166R
        '
        'XrTableCell54
        '
        Me.XrTableCell54.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_DepannageUrgTechOnSite.VSITNOM")})
        Me.XrTableCell54.Dpi = 100.0!
        Me.XrTableCell54.Name = "XrTableCell54"
        Me.XrTableCell54.Text = "XrTableCell54"
        Me.XrTableCell54.Weight = 0.77075154412335167R
        '
        'XrTableCell55
        '
        Me.XrTableCell55.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_DepannageUrgTechOnSite.VACTDES")})
        Me.XrTableCell55.Dpi = 100.0!
        Me.XrTableCell55.Name = "XrTableCell55"
        Me.XrTableCell55.Text = "XrTableCell55"
        Me.XrTableCell55.Weight = 1.0400215470329806R
        '
        'XrTableCell56
        '
        Me.XrTableCell56.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_DepannageUrgTechOnSite.DDINDAT")})
        Me.XrTableCell56.Dpi = 100.0!
        Me.XrTableCell56.Name = "XrTableCell56"
        Me.XrTableCell56.Text = "XrTableCell56"
        Me.XrTableCell56.Weight = 0.26728279966532864R
        '
        'XrTableCell57
        '
        Me.XrTableCell57.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_DepannageUrgTechOnSite.DACTDEX")})
        Me.XrTableCell57.Dpi = 100.0!
        Me.XrTableCell57.Name = "XrTableCell57"
        Me.XrTableCell57.Text = "XrTableCell57"
        Me.XrTableCell57.Weight = 0.44923664108213229R
        '
        'XrTableCell58
        '
        Me.XrTableCell58.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_DepannageUrgTechOnSite.diffenmin")})
        Me.XrTableCell58.Dpi = 100.0!
        Me.XrTableCell58.Name = "XrTableCell58"
        Me.XrTableCell58.Text = "XrTableCell58"
        Me.XrTableCell58.Weight = 0.32956221680587028R
        '
        'XrTable9
        '
        Me.XrTable9.Dpi = 100.0!
        Me.XrTable9.LocationFloat = New DevExpress.Utils.PointFloat(10.0009298!, 0.0!)
        Me.XrTable9.Name = "XrTable9"
        Me.XrTable9.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow9})
        Me.XrTable9.SizeF = New System.Drawing.SizeF(754.99823!, 25.0!)
        Me.XrTable9.StyleName = "XrStyleTableauContenu"
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell59, Me.XrTableCell60, Me.XrTableCell61, Me.XrTableCell62, Me.XrTableCell63, Me.XrTableCell64})
        Me.XrTableRow9.Dpi = 100.0!
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Weight = 11.5R
        '
        'XrTableCell59
        '
        Me.XrTableCell59.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_DepannageUrgTechOutSite.VSITENSEIGNE")})
        Me.XrTableCell59.Dpi = 100.0!
        Me.XrTableCell59.Name = "XrTableCell59"
        Me.XrTableCell59.Text = "XrTableCell59"
        Me.XrTableCell59.Weight = 0.4960263533929104R
        '
        'XrTableCell60
        '
        Me.XrTableCell60.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_DepannageUrgTechOutSite.VSITNOM")})
        Me.XrTableCell60.Dpi = 100.0!
        Me.XrTableCell60.Name = "XrTableCell60"
        Me.XrTableCell60.Text = "XrTableCell60"
        Me.XrTableCell60.Weight = 0.7911729899896327R
        '
        'XrTableCell61
        '
        Me.XrTableCell61.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_DepannageUrgTechOutSite.VACTDES")})
        Me.XrTableCell61.Dpi = 100.0!
        Me.XrTableCell61.Name = "XrTableCell61"
        Me.XrTableCell61.Text = "XrTableCell61"
        Me.XrTableCell61.Weight = 1.0675770647227143R
        '
        'XrTableCell62
        '
        Me.XrTableCell62.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_DepannageUrgTechOutSite.DDINDAT")})
        Me.XrTableCell62.Dpi = 100.0!
        Me.XrTableCell62.Name = "XrTableCell62"
        Me.XrTableCell62.Text = "XrTableCell62"
        Me.XrTableCell62.Weight = 0.27436384409469861R
        '
        'XrTableCell63
        '
        Me.XrTableCell63.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_DepannageUrgTechOutSite.DACTDEX")})
        Me.XrTableCell63.Dpi = 100.0!
        Me.XrTableCell63.Name = "XrTableCell63"
        Me.XrTableCell63.Text = "XrTableCell63"
        Me.XrTableCell63.Weight = 0.46113700283511R
        '
        'XrTableCell64
        '
        Me.XrTableCell64.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_DepannageUrgTechOutSite.diffenmin")})
        Me.XrTableCell64.Dpi = 100.0!
        Me.XrTableCell64.Name = "XrTableCell64"
        Me.XrTableCell64.Text = "XrTableCell64"
        Me.XrTableCell64.Weight = 0.33829417353636243R
        '
        'XrLabel20
        '
        Me.XrLabel20.Dpi = 100.0!
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(330.208313!, 0.0!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'XrLabel21
        '
        Me.XrLabel21.Dpi = 100.0!
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(330.208313!, 0.0!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'XrTable10
        '
        Me.XrTable10.Dpi = 100.0!
        Me.XrTable10.LocationFloat = New DevExpress.Utils.PointFloat(9.99912453!, 0.0!)
        Me.XrTable10.Name = "XrTable10"
        Me.XrTable10.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow10})
        Me.XrTable10.SizeF = New System.Drawing.SizeF(755.0!, 25.0!)
        Me.XrTable10.StyleName = "XrStyleTableauContenu"
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell65, Me.XrTableCell66, Me.XrTableCell67, Me.XrTableCell68, Me.XrTableCell69, Me.XrTableCell70})
        Me.XrTableRow10.Dpi = 100.0!
        Me.XrTableRow10.Name = "XrTableRow10"
        Me.XrTableRow10.Weight = 11.5R
        '
        'XrTableCell65
        '
        Me.XrTableCell65.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_DepannageNonUrg.VSITENSEIGNE")})
        Me.XrTableCell65.Dpi = 100.0!
        Me.XrTableCell65.Name = "XrTableCell65"
        Me.XrTableCell65.Text = "XrTableCell65"
        Me.XrTableCell65.Weight = 0.49603332692762531R
        '
        'XrTableCell66
        '
        Me.XrTableCell66.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_DepannageNonUrg.VSITNOM")})
        Me.XrTableCell66.Dpi = 100.0!
        Me.XrTableCell66.Name = "XrTableCell66"
        Me.XrTableCell66.Text = "XrTableCell66"
        Me.XrTableCell66.Weight = 0.79117079403677848R
        '
        'XrTableCell67
        '
        Me.XrTableCell67.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_DepannageNonUrg.VACTDES")})
        Me.XrTableCell67.Dpi = 100.0!
        Me.XrTableCell67.Name = "XrTableCell67"
        Me.XrTableCell67.Text = "XrTableCell67"
        Me.XrTableCell67.Weight = 1.0675748913493379R
        '
        'XrTableCell68
        '
        Me.XrTableCell68.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_DepannageNonUrg.DDINDAT")})
        Me.XrTableCell68.Dpi = 100.0!
        Me.XrTableCell68.Name = "XrTableCell68"
        Me.XrTableCell68.Text = "XrTableCell68"
        Me.XrTableCell68.Weight = 0.27436290152702214R
        '
        'XrTableCell69
        '
        Me.XrTableCell69.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_DepannageNonUrg.DACTDEX")})
        Me.XrTableCell69.Dpi = 100.0!
        Me.XrTableCell69.Name = "XrTableCell69"
        Me.XrTableCell69.Text = "XrTableCell69"
        Me.XrTableCell69.Weight = 0.4611369931483561R
        '
        'XrTableCell70
        '
        Me.XrTableCell70.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_DepannageNonUrg.diffenmin")})
        Me.XrTableCell70.Dpi = 100.0!
        Me.XrTableCell70.Name = "XrTableCell70"
        Me.XrTableCell70.Text = "XrTableCell70"
        Me.XrTableCell70.Weight = 0.33829252158230844R
        '
        'XrTable11
        '
        Me.XrTable11.Dpi = 100.0!
        Me.XrTable11.LocationFloat = New DevExpress.Utils.PointFloat(10.0009298!, 0.0!)
        Me.XrTable11.Name = "XrTable11"
        Me.XrTable11.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow11})
        Me.XrTable11.SizeF = New System.Drawing.SizeF(754.99823!, 25.0!)
        Me.XrTable11.StyleName = "XrStyleTableauContenu"
        '
        'XrTableRow11
        '
        Me.XrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell71, Me.XrTableCell72, Me.XrTableCell73, Me.XrTableCell74, Me.XrTableCell75, Me.XrTableCell76, Me.XrTableCell77, Me.XrTableCell78})
        Me.XrTableRow11.Dpi = 100.0!
        Me.XrTableRow11.Name = "XrTableRow11"
        Me.XrTableRow11.Weight = 11.5R
        '
        'XrTableCell71
        '
        Me.XrTableCell71.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_RealisationLDR.VSITENSEIGNE")})
        Me.XrTableCell71.Dpi = 100.0!
        Me.XrTableCell71.Name = "XrTableCell71"
        Me.XrTableCell71.Text = "XrTableCell71"
        Me.XrTableCell71.Weight = 0.14934126073408377R
        '
        'XrTableCell72
        '
        Me.XrTableCell72.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_RealisationLDR.VSITNOM")})
        Me.XrTableCell72.Dpi = 100.0!
        Me.XrTableCell72.Name = "XrTableCell72"
        Me.XrTableCell72.Text = "XrTableCell72"
        Me.XrTableCell72.Weight = 0.20829337961359293R
        '
        'XrTableCell73
        '
        Me.XrTableCell73.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_RealisationLDR.VTYPECONTRAT")})
        Me.XrTableCell73.Dpi = 100.0!
        Me.XrTableCell73.Name = "XrTableCell73"
        Me.XrTableCell73.Text = "XrTableCell73"
        Me.XrTableCell73.Weight = 0.21688652458614452R
        '
        'XrTableCell74
        '
        Me.XrTableCell74.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_RealisationLDR.DATESAISIERAPPORT")})
        Me.XrTableCell74.Dpi = 100.0!
        Me.XrTableCell74.Name = "XrTableCell74"
        Me.XrTableCell74.Text = "XrTableCell74"
        Me.XrTableCell74.Weight = 0.078231587268137226R
        '
        'XrTableCell75
        '
        Me.XrTableCell75.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_RealisationLDR.DATEREADEVIS")})
        Me.XrTableCell75.Dpi = 100.0!
        Me.XrTableCell75.Name = "XrTableCell75"
        Me.XrTableCell75.Text = "XrTableCell75"
        Me.XrTableCell75.Weight = 0.083272965188440518R
        '
        'XrTableCell76
        '
        Me.XrTableCell76.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_RealisationLDR.DATEVALIDDEVIS")})
        Me.XrTableCell76.Dpi = 100.0!
        Me.XrTableCell76.Name = "XrTableCell76"
        Me.XrTableCell76.Text = "XrTableCell76"
        Me.XrTableCell76.Weight = 0.10607918671610998R
        '
        'XrTableCell77
        '
        Me.XrTableCell77.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_RealisationLDR.DATEREA")})
        Me.XrTableCell77.Dpi = 100.0!
        Me.XrTableCell77.Name = "XrTableCell77"
        Me.XrTableCell77.Text = "XrTableCell77"
        Me.XrTableCell77.Weight = 0.088301241576221809R
        '
        'XrTableCell78
        '
        Me.XrTableCell78.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_RealisationLDR.DELAIEXE")})
        Me.XrTableCell78.Dpi = 100.0!
        Me.XrTableCell78.Name = "XrTableCell78"
        Me.XrTableCell78.Text = "XrTableCell78"
        Me.XrTableCell78.Weight = 0.10185191883339823R
        '
        'CalculatedFieldMoyDelai
        '
        Me.CalculatedFieldMoyDelai.DataMember = "api_sp_Rapport_FM_Impression_RealisationLDR"
        Me.CalculatedFieldMoyDelai.DataSource = Me.SqlDS_Imp_Rapport_Fm_Mensuel
        Me.CalculatedFieldMoyDelai.Expression = "[].Avg([DELAIEXE])"
        Me.CalculatedFieldMoyDelai.Name = "CalculatedFieldMoyDelai"
        '
        'XrLabel22
        '
        Me.XrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "api_sp_Rapport_FM_Impression_RealisationLDR.CalculatedFieldMoyDelai", "{0:# jours.}")})
        Me.XrLabel22.Dpi = 100.0!
        Me.XrLabel22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(211.159805!, 10.0001001!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(219.048492!, 23.0!)
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "XrLabel22"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XReport_Rapport_fm_mensuel
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.PageFooter, Me.ReportHeader, Me.DetailReportPlanRea, Me.DetailReportLDR, Me.DetailReportEquipements, Me.DetailReportBonInter, Me.DetailReportDepUrgTechOnSite, Me.DetailReportDepUrgTechOutSite, Me.DetailReportDepNoUrg})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CalculatedFieldMoyDelai})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDS_Imp_Rapport_Fm_Mensuel})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBoxBordersAllPage})
        Me.Margins = New System.Drawing.Printing.Margins(26, 26, 25, 60)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.ParamNCLINUM, Me.ParamVENSEIGNE, Me.ParamDateDebut_Last, Me.ParamDateFin_Last, Me.ParamDateDebut_This, Me.ParamDateFin_This})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrStyleTitreTableau, Me.XrStyleTitreContrat, Me.XrStyleEnteteTableau, Me.XrStyleTableauContenu})
        Me.Version = "15.2"
        CType(Me.XrRichTxtFooterSommaire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichTxtSommaire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrrichTxtOrgaGen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTablePlanReaTabEntete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTableLDR3MonthEntete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTableLDRDevisAValiderEntete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTableEquipementsTabEntete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTableBonInterTabEntete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents SqlDS_Imp_Rapport_Fm_Mensuel As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents ParamNCLINUM As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ParamVENSEIGNE As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ParamDateDebut_Last As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ParamDateFin_Last As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLblVCLINOM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLblPeriode As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLblRapportFmTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLblIntitule1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageBreakAfterSommaire As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents XrrichTxtOrgaGen As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrPageBreakAfterOrgaGen As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents XrPictLogoVSOCIETE As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictLogoLOGOCLIENT As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrRichTxtSommaire As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichTxtFooterSommaire As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrOrgaGenLblVCLINOM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLblOrgaGenTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DetailReportPlanRea As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents DetailPlanRea As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeaderPlanRea As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooterPlanRea As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLblPlanReaTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DetailReportPlanReaTab As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents DetailNettoyagePlanReaTab As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeaderPlanReaTab As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooterPlanReaTab As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLblPlanReaTabTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTablePlanReaTabEntete As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRowEntetePlanReaTab As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableRowEntetePlanReaTabVENSEIGNE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRowEntetePlanReaTabVACTDES As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRowEntetePlanReaTabDACTDEX As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRowEntetePlanReaTabVSITNOM As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRowEntetePlanReaTabVPRELIB As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ParamDateDebut_This As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ParamDateFin_This As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents DetailReportLDR As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents DetailLDR As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeaderLDR As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooterLDR As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLblLDRTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DetailReportLDR3Month As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents DetailLDR3Month As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeaderLDR3Month As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooterLDR3Month As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents DetailReportLDRDevisAValider As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents DetailLDRDevisAValider As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeaderLDRDevisAValider As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooterLDRDevisAValider As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLblLDR3MonthTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableLDR3MonthEntete As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRowEnteteLDR3Month As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XtTabRowEnteteLDR3MonthVENSEIGNE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTabRowEnteteLDR3MonthVSITNOM As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTabRowEnteteLDR3MonthVPRELIB As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTabRowEnteteLDR3MonthVACTDES As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTabRowEnteteLDR3MonthDACTDEX As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableLDRDevisAValiderEntete As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRowLDRDevisAValider As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XtTabLDRDevisAValiderVENSEIGNE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTabLDRDevisAValiderVSITNOM As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTabLDRDevisAValiderVPRELIB As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTabLDRDevisAValiderVACTDES As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTabLDRDevisAValiderDACTPLA As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLblLDRDevisAValiderTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DetailReportEquipements As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents DetailEquipements As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents DetailReportBonInter As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents DetailBonInter As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeaderEquipements As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooterEquipements As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents ReportHeaderBonInter As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooterBonInter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents DetailReportEquipementsTab As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents DetailBauxEquipementsTab As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeaderEquipementsTab As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooterEquipementsTab As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents DetailReportBonInterTab As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents DetailDechetsBonInterTab As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeaderBonInterTab As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooterBonInterTab As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLblEquipementsTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableEquipementsTabEntete As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRowEquipementsTab As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XtTabRowEquipementsTabVENSEIGNE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTabRowEquipementsTabVSITNOM As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTabRowEquipementsTabVPRELIB As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTabRowEquipementsTabVACTDES As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XtTabRowEquipementsTabDDATDEMANDE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLblEquipementsTabTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLblBonInterTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableBonInterTabEntete As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRowEnteteBonInterTab As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableRowEnteteBonInterTabVENSEIGNE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRowEnteteBonInterTabVSITNOM As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRowEnteteBonInterTabVPRELIB As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRowEnteteBonInterTabVACTDES As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRowEnteteBonInterTabDDATDEMANDE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLblBonInterTabTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandBoxBordersAllPage As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrStyleTitreTableau As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrStyleTitreContrat As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrStyleEnteteTableau As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrStyleTableauContenu As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfoFooter As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrTableRowEntetePlanReaTabXX As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents DetailReportDepUrgTechOnSite As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents DetailDepUrgTechOnSite As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeaderDepUrgTechOnSite As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooterDepUrgTechOnSite As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents DetailReportDepUrgTechOnSiteTab As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents DetailDepUrgTechOnSiteTab As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeaderDepUrgTechOnSiteTab As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooterDepUrgTechOnSiteTab As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents DetailReportDepUrgTechOutSite As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents DetailDepUrgTechOutSite As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeaderDepUrgTechOutSite As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooterDepUrgTechOutSite As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents DetailReportDepUrgTechOutSiteTab As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents DetailDepUrgTechOutSiteTab As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeaderDepUrgTechOutSiteTab As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooterDepUrgTechOutSiteTab As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents DetailReportDepNoUrg As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents DetailDepNoUrg As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeaderDepNoUrg As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooterDepNoUrg As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents DetailReportDepNoUrgTab As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents DetailDepNoUrgTab As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeaderDepNoUrgTab As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooterDepNoUrgTab As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell42 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell43 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell44 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell45 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable7 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell46 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell47 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell48 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell49 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell51 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell52 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable8 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell53 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell54 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell55 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell56 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell57 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell58 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable9 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell59 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell60 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell61 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell62 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell63 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell64 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable10 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell65 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell66 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell67 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell68 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell69 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell70 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable11 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow11 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell71 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell72 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell73 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell74 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell75 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell76 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell77 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell78 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents CalculatedFieldMoyDelai As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
End Class
