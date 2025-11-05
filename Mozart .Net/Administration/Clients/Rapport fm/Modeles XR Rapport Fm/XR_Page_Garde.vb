Public Class XR_Page_Garde

    Dim _oRapport_Fm_Imp As CRapportFM
    Dim _NomServerSQL As String
    Dim oTrad As Class_Trad_Report

    Public Sub New(ByVal c_Rapport_Fm_Imp As CRapportFM, ByVal c_NomServerSQL As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        'Init
        oTrad = New Class_Trad_Report("XR_Page_Garde")

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _oRapport_Fm_Imp = c_Rapport_Fm_Imp
        _NomServerSQL = c_NomServerSQL

        'page sommaire
        XrPictBoxBandeau.Image = _oRapport_Fm_Imp.iBandeauClient 'My.Resources.Bandeau_RAPPORT_FM

        XrPictLogoLOGOCLIENT.Image = _oRapport_Fm_Imp.iLogoClient
        XrPictLogoGROUP.Image = _oRapport_Fm_Imp.iLogoGroup

        XrLblVCLINOM.Text = _oRapport_Fm_Imp.VCLINOM

        XrLblIntitule.Text = _oRapport_Fm_Imp.VRAPPORT_FM_TITLE

        'set traduction
        oTrad.SetTraductionOnReport(Me, _oRapport_Fm_Imp.sLangue)

        XrLblPeriode.Text = String.Format(XrLblPeriode.Text, _oRapport_Fm_Imp.sDateDebut_This.ToShortDateString, _oRapport_Fm_Imp.sDateFin_This.ToShortDateString)

        AfficheSommaire()

        'on mets à jours les expressions :
        XrLbldateEdition.Text = XrLbldateEdition.Text & " " & Now.Date.ToShortDateString

    End Sub

    Private Sub AfficheSommaire()

        Dim sSommaire As String = ""

        If Not _oRapport_Fm_Imp.DtRapport_FM_Requetes Is Nothing Then

            For Each drRequetes As DataRow In _oRapport_Fm_Imp.DtRapport_FM_Requetes.Rows

                sSommaire = sSommaire & (drRequetes.Item("NORDER")).ToString & " - " & oTrad.GetExpression(drRequetes.Item("VLIBCHAPITRE"), _oRapport_Fm_Imp.sLangue) & vbCrLf

            Next

        End If

        XrRichTxtSommaire.Text = sSommaire

    End Sub

End Class