Imports DevExpress.DataAccess.ConnectionParameters

Public Class XReport_Rapport_fm_mensuel

    Dim _oRapport_Fm_Imp As Object

    Dim _NomServerSQL As String

    Public Sub New(ByVal c_Rapport_Fm_Imp As Object, ByVal c_NomServerSQL As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _oRapport_Fm_Imp = c_Rapport_Fm_Imp
        _NomServerSQL = c_NomServerSQL

        'param
        ParamNCLINUM.Value = _oRapport_Fm_Imp.NCLINUM
        ParamVENSEIGNE.Value = _oRapport_Fm_Imp.VENSEIGNE
        ParamDateDebut_Last.Value = _oRapport_Fm_Imp.sDateDebut_Last
        ParamDateFin_Last.Value = _oRapport_Fm_Imp.sDateFin_Last
        ParamDateDebut_This.Value = _oRapport_Fm_Imp.sDateDebut_This
        ParamDateFin_This.Value = _oRapport_Fm_Imp.sDateFin_This

        'remplacement
        XrPictLogoVSOCIETE.Image = _oRapport_Fm_Imp.iLogoSociete
        XrPictLogoLOGOCLIENT.Image = _oRapport_Fm_Imp.iLogoClient

        XrLblVCLINOM.Text = _oRapport_Fm_Imp.VCLINOM

        XrLblRapportFmTitle.Text = _oRapport_Fm_Imp.VRAPPORT_FM_TITLE
        XrLblPeriode.Text = _oRapport_Fm_Imp.VPERIODE

        XrOrgaGenLblVCLINOM.Text = _oRapport_Fm_Imp.VCLINOM
        XrrichTxtOrgaGen.Rtf = _oRapport_Fm_Imp.VCHAP_MSG

        XrRichTxtSommaire.Rtf = XrRichTxtSommaire.Rtf.Replace("#VCLINOM#", _oRapport_Fm_Imp.VCLINOM)

    End Sub

    Private Sub SqlDS_Imp_Rapport_Fm_Hebdo_ConfigureDataConnection(sender As Object, e As DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs) Handles SqlDS_Imp_Rapport_Fm_Mensuel.ConfigureDataConnection

        Dim oParamConnection As MsSqlConnectionParameters = e.ConnectionParameters

        If Not oParamConnection Is Nothing Then

            oParamConnection.ServerName = _NomServerSQL

        End If

    End Sub

    Private Sub PageFooter_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles PageFooter.BeforePrint



    End Sub
End Class