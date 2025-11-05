Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports MozartLib

Public Class XR_Page_Chap_ListeSiteRapport

  Dim _oRapport_Fm_Imp As CRapportFM
  Dim _NomServerSQL As String

  Public Sub New(ByVal c_Rapport_Fm_Imp As CRapportFM, ByVal c_NomServerSQL As String)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    'Init
    Dim oTrad As New Class_Trad_Report("XR_Page_Chap_ListeSiteRapport")

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _oRapport_Fm_Imp = c_Rapport_Fm_Imp
    _NomServerSQL = c_NomServerSQL

    P_NIDRAPPORT_FM_CLI.Value = _oRapport_Fm_Imp.NIDRAPPORT_FM_CLI

    'set traduction
    oTrad.SetTraductionOnReport(Me, _oRapport_Fm_Imp.sLangue)
    XrLabel1.TextFormatString = oTrad.GetExpression("{0} site(s) sélectionné(s)", _oRapport_Fm_Imp.sLangue)



  End Sub

  Private Sub SqlDataSource1_ConfigureDataConnection(sender As Object, e As ConfigureDataConnectionEventArgs) Handles SqlDataSource1.ConfigureDataConnection

    Dim oParamSQL As MsSqlConnectionParameters = e.ConnectionParameters

    oParamSQL.ServerName = MozartParams.NomServeur
    oParamSQL.DatabaseName = "MULTI"
    oParamSQL.AuthorizationType = MsSqlAuthorizationType.Windows

  End Sub

End Class