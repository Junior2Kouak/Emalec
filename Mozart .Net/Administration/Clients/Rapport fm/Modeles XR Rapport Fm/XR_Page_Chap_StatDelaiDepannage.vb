Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraReports.UI
Imports MozartLib

Public Class XR_Page_Chap_StatDelaiDepannage

  Dim _oRapport_Fm_Imp As CRapportFM
  Dim _NomServerSQL As String

  Dim SumDelaiDepannage_Moy As Int32 = 0
  Dim SumDelaiDepannage_Nb_Inter As Int32 = 0

  Public Sub New(ByVal c_Rapport_Fm_Imp As CRapportFM, ByVal c_NomServerSQL As String, ByVal p_NORDER As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    'Init
    Dim oTrad As New Class_Trad_Report("XR_Page_Chap_StatDelaiDepannage")

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

    P_NIDRAPPORT_FM_CLI.Value = _oRapport_Fm_Imp.NIDRAPPORT_FM_CLI

    'set traduction
    oTrad.SetTraductionOnReport(Me, _oRapport_Fm_Imp.sLangue)

    'on mets à jours les expressions :
    XrLblTitre_ChapStatDelaiDepannage.Text = p_NORDER.ToString & " - " & XrLblTitre_ChapStatDelaiDepannage.Text

  End Sub

  Private Sub XrLabelDelaiDepannage_Delai_Moy_SummaryGetResult(sender As Object, e As SummaryGetResultEventArgs) Handles XrLabelDelaiDepannage_Delai_Moy.SummaryGetResult

    e.Result = Convert.ToDecimal(SumDelaiDepannage_Moy / SumDelaiDepannage_Nb_Inter)
    e.Handled = True

  End Sub

  Private Sub XrLabelDelaiDepannage_Delai_Moy_SummaryRowChanged(sender As Object, e As EventArgs) Handles XrLabelDelaiDepannage_Delai_Moy.SummaryRowChanged

    SumDelaiDepannage_Moy = SumDelaiDepannage_Moy + Convert.ToInt32(DetailReport.GetCurrentColumnValue("NB_J") * DetailReport.GetCurrentColumnValue("TOTAL_ACT"))
    SumDelaiDepannage_Nb_Inter = SumDelaiDepannage_Nb_Inter + Convert.ToInt32(DetailReport.GetCurrentColumnValue("TOTAL_ACT"))

  End Sub

  Private Sub XrLabelDelaiDepannage_Delai_Moy_SummaryReset(sender As Object, e As EventArgs) Handles XrLabelDelaiDepannage_Delai_Moy.SummaryReset
    SumDelaiDepannage_Moy = 0
    SumDelaiDepannage_Nb_Inter = 0
  End Sub

  Private Sub SqlDataSource1_ConfigureDataConnection(sender As Object, e As ConfigureDataConnectionEventArgs) Handles SqlDataSource1.ConfigureDataConnection

    Dim oParamSQL As MsSqlConnectionParameters = e.ConnectionParameters

    oParamSQL.ServerName = MozartParams.NomServeur
    oParamSQL.DatabaseName = "MULTI"
    oParamSQL.AuthorizationType = MsSqlAuthorizationType.Windows

  End Sub

End Class