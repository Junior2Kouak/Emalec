Public Class XR_Page_Generalites

    Dim _oRapport_Fm_Imp As CRapportFM
    Dim _NomServerSQL As String

    Public Sub New(ByVal c_Rapport_Fm_Imp As CRapportFM, ByVal c_NomServerSQL As String, ByVal p_NORDER As Int32)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        'Init
        Dim oTrad As New Class_Trad_Report("XR_Page_Generalites")

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _oRapport_Fm_Imp = c_Rapport_Fm_Imp
        _NomServerSQL = c_NomServerSQL

        XrrichTxtOrgaGen.Rtf = _oRapport_Fm_Imp.VCHAP_MSG

        'set traduction
        oTrad.SetTraductionOnReport(Me, _oRapport_Fm_Imp.sLangue)

        'on mets à jours les expressions :
        XrLblOrgaGenTitle.Text = p_NORDER.ToString & " - " & XrLblOrgaGenTitle.Text

    End Sub
End Class