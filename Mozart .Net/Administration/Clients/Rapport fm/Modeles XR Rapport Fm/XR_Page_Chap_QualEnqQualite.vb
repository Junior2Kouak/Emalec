Imports System.Drawing.Printing
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraReports.UI
Imports MozartLib

Public Class XR_Page_Chap_QualEnqQualite

  Dim _oRapport_Fm_Imp As CRapportFM
  Dim _NomServerSQL As String

  Public Sub New(ByVal c_Rapport_Fm_Imp As CRapportFM, ByVal c_NomServerSQL As String, ByVal p_NORDER As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    'Init
    Dim oTrad As New Class_Trad_Report("XR_Page_Chap_QualEnqQualite")

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _oRapport_Fm_Imp = c_Rapport_Fm_Imp
    _NomServerSQL = c_NomServerSQL

    P_NCLINUM.Value = _oRapport_Fm_Imp.NCLINUM

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
    XrLblTitreQualEnq.Text = p_NORDER.ToString & " - " & XrLblTitreQualEnq.Text
    If XrChart_Chap_QualEnq_Pie_PresOnPeriod.Titles.Count > 0 Then XrChart_Chap_QualEnq_Pie_PresOnPeriod.Titles(0).Text = oTrad.GetExpression("Présentation", _oRapport_Fm_Imp.sLangue) & vbCrLf & oTrad.GetExpression("Du", _oRapport_Fm_Imp.sLangue) & " " + Convert.ToDateTime(P_DATE_DEBUT_PERIODE.Value).ToShortDateString + " " & oTrad.GetExpression("au", _oRapport_Fm_Imp.sLangue) & " " + Convert.ToDateTime(P_DATE_FIN_PERIODE.Value).ToShortDateString
    If XrChart_Chap_QualEnq_Pie_ReaOnPeriod.Titles.Count > 0 Then XrChart_Chap_QualEnq_Pie_ReaOnPeriod.Titles(0).Text = oTrad.GetExpression("Réalisation", _oRapport_Fm_Imp.sLangue) & vbCrLf & oTrad.GetExpression("Du", _oRapport_Fm_Imp.sLangue) & " " + Convert.ToDateTime(P_DATE_DEBUT_PERIODE.Value).ToShortDateString + " " & oTrad.GetExpression("au", _oRapport_Fm_Imp.sLangue) & " " + Convert.ToDateTime(P_DATE_FIN_PERIODE.Value).ToShortDateString
    If XrChart_Chap_QualEnq_Pie_PropOnPeriod.Titles.Count > 0 Then XrChart_Chap_QualEnq_Pie_PropOnPeriod.Titles(0).Text = "Propreté" & vbCrLf & oTrad.GetExpression("Du", _oRapport_Fm_Imp.sLangue) & " " + Convert.ToDateTime(P_DATE_DEBUT_PERIODE.Value).ToShortDateString + " " & oTrad.GetExpression("au", _oRapport_Fm_Imp.sLangue) & " " + Convert.ToDateTime(P_DATE_FIN_PERIODE.Value).ToShortDateString

    If XrChart_Chap_QualEnq_Pie_PresOn12M.Titles.Count > 0 Then XrChart_Chap_QualEnq_Pie_PresOn12M.Titles(0).Text = oTrad.GetExpression("Présentation", _oRapport_Fm_Imp.sLangue) & vbCrLf & oTrad.GetExpression("Sur 12 mois glissants", _oRapport_Fm_Imp.sLangue)
    If XrChart_Chap_QualEnq_Pie_ReaOn12M.Titles.Count > 0 Then XrChart_Chap_QualEnq_Pie_ReaOn12M.Titles(0).Text = oTrad.GetExpression("Réalisation", _oRapport_Fm_Imp.sLangue) & vbCrLf & oTrad.GetExpression("Sur 12 mois glissants", _oRapport_Fm_Imp.sLangue)
    If XrChart_Chap_QualEnq_Pie_PropOn12M.Titles.Count > 0 Then XrChart_Chap_QualEnq_Pie_PropOn12M.Titles(0).Text = oTrad.GetExpression("Propreté", _oRapport_Fm_Imp.sLangue) & vbCrLf & oTrad.GetExpression("Sur 12 mois glissants", _oRapport_Fm_Imp.sLangue)

  End Sub

  Private Sub SDS_Chap_Devis_ConfigureDataConnection(sender As Object, e As ConfigureDataConnectionEventArgs) Handles SDS_Chap_EnqQual.ConfigureDataConnection

    Dim oParamSQL As MsSqlConnectionParameters = e.ConnectionParameters

    oParamSQL.ServerName = MozartParams.NomServeur
    oParamSQL.DatabaseName = "MULTI"
    oParamSQL.AuthorizationType = MsSqlAuthorizationType.Windows

  End Sub

    Private Sub XC_X1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XC_A1.BeforePrint, XC_A2.BeforePrint, XC_A3.BeforePrint

        Dim oCell As XRTableCell = TryCast(sender, XRTableCell)

        If oCell Is Nothing Then Return

        If sender.Value = "green" Then
            sender.Text = ""
            sender.BackColor = Color.Green
        Else
            sender.Text = ""
            sender.BackColor = Color.White
        End If

    End Sub

    Private Sub XC_X2_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XC_B1.BeforePrint, XC_B2.BeforePrint, XC_B3.BeforePrint

        Dim oCell As XRTableCell = TryCast(sender, XRTableCell)
        If oCell Is Nothing Then Return
        If sender.Value = "orange" Then
            sender.Text = ""
            sender.BackColor = Color.Orange
        Else
            sender.Text = ""
            sender.BackColor = Color.White
        End If

    End Sub

    Private Sub XC_X3_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XC_C1.BeforePrint, XC_C2.BeforePrint, XC_C3.BeforePrint

        Dim oCell As XRTableCell = TryCast(sender, XRTableCell)
        If oCell Is Nothing Then Return
        If sender.Value = "red" Then
            sender.Text = ""
            sender.BackColor = Color.Red
        Else
            sender.Text = ""
            sender.BackColor = Color.White
        End If

    End Sub
End Class