Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraReports.UI.PivotGrid
Imports MozartLib

Public Class XR_Page_Chap_SEMMARIS_StatNbActByDomaine

  Dim _oRapport_Fm_Imp As CRapportFM
  Dim _NomServerSQL As String
  Dim _sNameLastMonth As String

  Public Sub New(ByVal c_Rapport_Fm_Imp As CRapportFM, ByVal c_NomServerSQL As String, ByVal p_NORDER As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    'Init
    Dim oTrad As New Class_Trad_Report("XR_Page_Chap_SEMMARIS_StatHrReaByDomaine")

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _oRapport_Fm_Imp = c_Rapport_Fm_Imp
    _NomServerSQL = c_NomServerSQL

    P_NCLINUM.Value = _oRapport_Fm_Imp.NCLINUM
    P_VENSEIGNE.Value = "$TS"
    P_DATE_DEBUT_PERIODE.Value = _oRapport_Fm_Imp.sDateDebut_This
    P_DATE_FIN_PERIODE.Value = _oRapport_Fm_Imp.sDateFin_This

    P_DATE_TODAY.Value = Now.Date

    P_DATE_FIN_LASTMONTH.Value = DateAdd(DateInterval.Day, -DatePart(DateInterval.Day, Now.Date), Now.Date)
    P_DATE_DEBUT_LASTMONTH.Value = DateAdd(DateInterval.Day, -DatePart(DateInterval.Day, P_DATE_FIN_LASTMONTH.Value), P_DATE_FIN_LASTMONTH.Value).AddDays(1)

    P_DATE_DEBUT_ANNEE.Value = CDate("01/01/" & Now.Year.ToString)

    P_DATE_FIN_12M.Value = DateAdd(DateInterval.Day, -DatePart(DateInterval.Day, Now.Date), Now.Date)
    P_DATE_DEBUT_12M.Value = DateAdd(DateInterval.Month, -12, P_DATE_FIN_12M.Value)

    'set traduction
    oTrad.SetTraductionOnReport(Me, _oRapport_Fm_Imp.sLangue)

    _sNameLastMonth = MonthName(CDate(P_DATE_FIN_LASTMONTH.Value).Month).Substring(0, 1).ToUpper + MonthName(CDate(P_DATE_FIN_LASTMONTH.Value).Month).Substring(1, MonthName(CDate(P_DATE_FIN_LASTMONTH.Value).Month).Length - 1)

    'on mets à jours les expressions :
    XrLblTitle.Text = p_NORDER.ToString & " - " & XrLblTitle.Text

    'XrChart_Chap_Maintenance_Pie_LastM.Titles(0).Text = _sNameLastMonth & " " & CDate(P_DATE_FIN_LASTMONTH.Value).Year
    'XrChart_Chap_Maintenance_Pie_Year.Titles(0).Text = XrChart_Chap_Maintenance_Pie_Year.Titles(0).Text & " " & CDate(P_DATE_DEBUT_ANNEE.Value).ToShortDateString

  End Sub
  Private Sub SqlDataSource1_ConfigureDataConnection(sender As Object, e As ConfigureDataConnectionEventArgs) Handles SqlDataSource1.ConfigureDataConnection

    Dim oParamSQL As MsSqlConnectionParameters = e.ConnectionParameters

    oParamSQL.ServerName = MozartParams.NomServeur
    oParamSQL.DatabaseName = "MULTI"
    oParamSQL.AuthorizationType = MsSqlAuthorizationType.Windows

  End Sub

  Private Sub XrPivotGrid1_FieldValueDisplayText(sender As Object, e As PivotFieldDisplayTextEventArgs) Handles XrPivotGrid2.FieldValueDisplayText

    If e.ValueType = DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal Then

      If e.IsColumn Then
        e.DisplayText = "Total"
      Else
        e.DisplayText = "Total"
      End If

    ElseIf e.ValueType = DevExpress.XtraPivotGrid.PivotGridValueType.Total Then

      If e.IsColumn Then
        e.DisplayText = String.Format("Total " & vbCrLf & "{0}", e.Value)
      Else
        e.DisplayText = "Total"
      End If

    End If

  End Sub

  Private Sub XrPivotGrid2_CustomColumnWidth(sender As Object, e As PivotCustomColumnWidthEventArgs) Handles XrPivotGrid2.CustomColumnWidth

    If e.ValueType = DevExpress.XtraPivotGrid.PivotGridValueType.Total Then

      e.ColumnWidth = 60

    End If

  End Sub
End Class
