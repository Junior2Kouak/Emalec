Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.ConnectionParameters
Imports MozartLib

Public Class XR_Page_Chap_StatByUrg

  Dim _oRapport_Fm_Imp As CRapportFM
  Dim _NomServerSQL As String

  Public Sub New(ByVal c_Rapport_Fm_Imp As CRapportFM, ByVal c_NomServerSQL As String, ByVal p_NORDER As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    'Init
    Dim oTrad As New Class_Trad_Report("XR_Page_Chap_StatByUrg")

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
    XrLblTitre_ChapStatByUrg.Text = p_NORDER.ToString & " - " & XrLblTitre_ChapStatByUrg.Text

    'titre des urgences
    XrChart27.Titles(0).Text = String.Format(XrChart27.Titles(0).Text, _oRapport_Fm_Imp.DtRapport_FM_DelaiByUrg.Select("[CURGCOD] = '1'")(0).Item("VDELAI"))
    XrChart28.Titles(0).Text = String.Format(XrChart28.Titles(0).Text, _oRapport_Fm_Imp.DtRapport_FM_DelaiByUrg.Select("[CURGCOD] = '2'")(0).Item("VDELAI"))
    XrChart29.Titles(0).Text = String.Format(XrChart29.Titles(0).Text, _oRapport_Fm_Imp.DtRapport_FM_DelaiByUrg.Select("[CURGCOD] = '3'")(0).Item("VDELAI"))
    XrChart30.Titles(0).Text = String.Format(XrChart30.Titles(0).Text, _oRapport_Fm_Imp.DtRapport_FM_DelaiByUrg.Select("[CURGCOD] = '4'")(0).Item("VDELAI"))
    XrChart31.Titles(0).Text = String.Format(XrChart31.Titles(0).Text, _oRapport_Fm_Imp.DtRapport_FM_DelaiByUrg.Select("[CURGCOD] = '5'")(0).Item("VDELAI"))

  End Sub
  Private Sub SqlDataSource1_ConfigureDataConnection(sender As Object, e As ConfigureDataConnectionEventArgs) Handles SqlDataSource1.ConfigureDataConnection

    Dim oParamSQL As MsSqlConnectionParameters = e.ConnectionParameters

    oParamSQL.ServerName = MozartParams.NomServeur
    oParamSQL.DatabaseName = "MULTI"
    oParamSQL.AuthorizationType = MsSqlAuthorizationType.Windows

  End Sub

End Class