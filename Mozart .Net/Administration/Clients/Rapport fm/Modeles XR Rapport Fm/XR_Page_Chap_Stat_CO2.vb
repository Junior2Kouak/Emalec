Imports MozartLib

Public Class XR_Page_Chap_Stat_CO2

  Dim _oRapport_Fm_Imp As CRapportFM
  Dim _NomServerSQL As String
  Dim _sNameLastMonth As String

  Public Sub New(ByVal c_Rapport_Fm_Imp As CRapportFM, ByVal c_NomServerSQL As String, ByVal p_NORDER As Int32, Optional ByVal p_Periode As Int32 = 0)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    'Init
    Dim oTrad As New Class_Trad_Report("XR_Page_Chap_Stat_CO2")

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _oRapport_Fm_Imp = c_Rapport_Fm_Imp
    _NomServerSQL = c_NomServerSQL

    P_NCLINUM.Value = _oRapport_Fm_Imp.NCLINUM
    P_VSOCIETE.Value = MozartParams.NomSociete

    Select Case p_Periode
      Case 0
        P_DATE_DEBUT_PERIODE.Value = _oRapport_Fm_Imp.sDateDebut_This
        P_DATE_FIN_PERIODE.Value = _oRapport_Fm_Imp.sDateFin_This
      Case 1

        P_DATE_DEBUT_PERIODE.Value = _oRapport_Fm_Imp.sDateDebut_This
        P_DATE_FIN_PERIODE.Value = _oRapport_Fm_Imp.sDateFin_This

    End Select


    P_NIDRAPPORT_FM_CLI.Value = _oRapport_Fm_Imp.NIDRAPPORT_FM_CLI

    'set traduction
    oTrad.SetTraductionOnReport(Me, _oRapport_Fm_Imp.sLangue)

    'on mets à jours les expressions :
    XrLblStatCO2Title.Text = p_NORDER.ToString & " - " & XrLblStatCO2Title.Text

  End Sub
End Class