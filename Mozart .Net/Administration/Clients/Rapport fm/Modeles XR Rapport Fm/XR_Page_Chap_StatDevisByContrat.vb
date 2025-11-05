Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraReports.UI
Imports MozartLib

Public Class XR_Page_Chap_StatDevisByContrat

  Dim _oRapport_Fm_Imp As CRapportFM
  Dim _NomServerSQL As String
  Dim SumDevisNbrTot As Int32 = 0
  Dim SumDevisNbrRea As Int32 = 0
  Dim SumDevisNbrARea As Int32 = 0

  Public Sub New(ByVal c_Rapport_Fm_Imp As CRapportFM, ByVal c_NomServerSQL As String, ByVal p_NORDER As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    'Init
    Dim oTrad As New Class_Trad_Report("XR_Page_Chap_StatDevisByContrat")

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

    P_LANGUE.Value = _oRapport_Fm_Imp.sLangue

    P_NIDRAPPORT_FM_CLI.Value = _oRapport_Fm_Imp.NIDRAPPORT_FM_CLI

    'set traduction
    oTrad.SetTraductionOnReport(Me, _oRapport_Fm_Imp.sLangue)

    'on mets à jours les expressions :
    XrLblTitre_ChapStatNbrDevisByContrat.Text = p_NORDER.ToString & " - " & XrLblTitre_ChapStatNbrDevisByContrat.Text

    'modificaiton du nom de la societe
    XrTableCell711.Text = XrTableCell711.Text & " " & MozartParams.NomSociete
    XrTableCell712.Text = XrTableCell712.Text & " " & MozartParams.NomSociete
    XrTableCell704.Text = String.Format(XrTableCell704.Text, MozartParams.NomSociete)

    XrTableCell749.Text = XrTableCell749.Text & " " & MozartParams.NomSociete
    XrTableCell750.Text = XrTableCell750.Text & " " & MozartParams.NomSociete
    XrTableCell765.Text = String.Format(XrTableCell765.Text, MozartParams.NomSociete)

  End Sub
  Private Sub SqlDataSource1_ConfigureDataConnection(sender As Object, e As ConfigureDataConnectionEventArgs) Handles SqlDataSource1.ConfigureDataConnection

    Dim oParamSQL As MsSqlConnectionParameters = e.ConnectionParameters

    oParamSQL.ServerName = MozartParams.NomServeur
    oParamSQL.DatabaseName = "MULTI"
    oParamSQL.AuthorizationType = MsSqlAuthorizationType.Windows

  End Sub

  Private Sub XrTableCell731_SummaryRowChanged(sender As Object, e As EventArgs)
    SumDevisNbrTot = SumDevisNbrTot + Convert.ToInt32(DetailReport3.GetCurrentColumnValue("TOT"))
    SumDevisNbrRea = SumDevisNbrRea + Convert.ToInt32(DetailReport3.GetCurrentColumnValue("FAIT"))
  End Sub

  Private Sub XrTableCell731_SummaryGetResult(sender As Object, e As SummaryGetResultEventArgs)

    e.Result = String.Format("{0:n2}", Convert.ToDecimal(SumDevisNbrRea / SumDevisNbrTot))
    e.Handled = True

  End Sub

  Private Sub XrTableCell731_SummaryReset(sender As Object, e As EventArgs)
    SumDevisNbrTot = 0
    SumDevisNbrRea = 0
  End Sub

  Private Sub XrTableCell736_SummaryRowChanged(sender As Object, e As EventArgs)
    SumDevisNbrARea = SumDevisNbrARea + Convert.ToInt32(DetailReport5.GetCurrentColumnValue("AFAIRE"))
  End Sub

  Private Sub XrTableCell736_SummaryReset(sender As Object, e As EventArgs)
    SumDevisNbrARea = 0
  End Sub

  Private Sub XrTableCell736_SummaryGetResult(sender As Object, e As SummaryGetResultEventArgs)
    e.Result = String.Format("{0:n2}", Convert.ToDecimal(SumDevisNbrARea / SumDevisNbrTot))
    e.Handled = True
  End Sub

End Class