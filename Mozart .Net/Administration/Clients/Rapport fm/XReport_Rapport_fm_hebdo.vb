Imports DevExpress.DataAccess.ConnectionParameters
Imports MozartLib

Public Class XReport_Rapport_fm_hebdo

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
    XrRichTxtSommaire.Rtf = XrRichTxtSommaire.Rtf.Replace("#VDATEDEBUTLAST#", CDate(_oRapport_Fm_Imp.sDateDebut_Last).ToShortDateString)
    XrRichTxtSommaire.Rtf = XrRichTxtSommaire.Rtf.Replace("#VDATEFINLAST#", CDate(_oRapport_Fm_Imp.sDateFin_Last).ToShortDateString)
    XrRichTxtSommaire.Rtf = XrRichTxtSommaire.Rtf.Replace("#VDATEDEBUTACTU#", CDate(_oRapport_Fm_Imp.sDateDebut_This).ToShortDateString)
    XrRichTxtSommaire.Rtf = XrRichTxtSommaire.Rtf.Replace("#VDATEFINACTU#", CDate(_oRapport_Fm_Imp.sDateFin_This).ToShortDateString)
    XrRichTxtSommaire.Rtf = XrRichTxtSommaire.Rtf.Replace("#DATENOW#", Now.ToShortDateString)

    'pied de page
    XrLblEdition.Text = String.Format("Edition {0} - {1}", MozartParams.NomSociete, Now.ToShortDateString)

    'définition des périodes
    XrLblNettoyagePrevExeTitle.Text = String.Format("Préventifs réalisés la semaine du {0} au {1}", CDate(_oRapport_Fm_Imp.sDateDebut_Last).ToShortDateString, CDate(_oRapport_Fm_Imp.sDateFin_Last).ToShortDateString)  'précédente
    XrLblNettoyagePrevPlaTitle.Text = String.Format("Préventifs planifiés la semaine du {0} au {1}", CDate(_oRapport_Fm_Imp.sDateDebut_This).ToShortDateString, CDate(_oRapport_Fm_Imp.sDateFin_This).ToShortDateString) 'actuelle
    XrLblNettoyageOtherPrestExeTitle.Text = String.Format("Autres prestations réalisées la semaine du {0} au {1}", CDate(_oRapport_Fm_Imp.sDateDebut_Last).ToShortDateString, CDate(_oRapport_Fm_Imp.sDateFin_Last).ToShortDateString) 'Autres prestations réalisées la semaine dernière" 'précédente
    XrLblNettoyageOtherPrestPlaTitle.Text = String.Format("Autres prestations planifiées la semaine du {0} au {1}", CDate(_oRapport_Fm_Imp.sDateDebut_This).ToShortDateString, CDate(_oRapport_Fm_Imp.sDateFin_This).ToShortDateString) 'actuelle
    XrLblNettoyageActDeciClientTitle.Text = String.Format("Actions en attente de validation de {0} au {1}", _oRapport_Fm_Imp.VCLINOM, Now.ToShortDateString)

    XrLblAccueilPrevExeTitle.Text = String.Format("Préventifs réalisés la semaine du {0} au {1}", CDate(_oRapport_Fm_Imp.sDateDebut_Last).ToShortDateString, CDate(_oRapport_Fm_Imp.sDateFin_Last).ToShortDateString)  'précédente
    XrLblAccueilPrevPlaTitle.Text = String.Format("Préventifs planifiés la semaine du {0} au {1}", CDate(_oRapport_Fm_Imp.sDateDebut_This).ToShortDateString, CDate(_oRapport_Fm_Imp.sDateFin_This).ToShortDateString) 'actuelle
    XrLblAccueilOtherPrestExe.Text = String.Format("Autres prestations réalisées la semaine du {0} au {1}", CDate(_oRapport_Fm_Imp.sDateDebut_Last).ToShortDateString, CDate(_oRapport_Fm_Imp.sDateFin_Last).ToShortDateString) 'Autres prestations réalisées la semaine dernière" 'précédente
    XrLblAccueilOtherPrestPla.Text = String.Format("Autres prestations planifiées la semaine du {0} au {1}", CDate(_oRapport_Fm_Imp.sDateDebut_This).ToShortDateString, CDate(_oRapport_Fm_Imp.sDateFin_This).ToShortDateString) 'actuelle
    XrLblAccueilActDeciClientTitle.Text = String.Format("Actions en attente de validation de {0} au {1}", _oRapport_Fm_Imp.VCLINOM, Now.ToShortDateString)

    XrLblMultitechPrevExeTitle.Text = String.Format("Préventifs réalisés la semaine du {0} au {1}", CDate(_oRapport_Fm_Imp.sDateDebut_Last).ToShortDateString, CDate(_oRapport_Fm_Imp.sDateFin_Last).ToShortDateString)  'précédente
    XrLblMultitechPrevPlaTitle.Text = String.Format("Préventifs planifiés la semaine du {0} au {1}", CDate(_oRapport_Fm_Imp.sDateDebut_This).ToShortDateString, CDate(_oRapport_Fm_Imp.sDateFin_This).ToShortDateString) 'actuelle
    XrLblMultitechOtherPrestExe.Text = String.Format("Autres prestations réalisées la semaine du {0} au {1}", CDate(_oRapport_Fm_Imp.sDateDebut_Last).ToShortDateString, CDate(_oRapport_Fm_Imp.sDateFin_Last).ToShortDateString) 'Autres prestations réalisées la semaine dernière" 'précédente
    XrLblMultitechOtherPrestPla.Text = String.Format("Autres prestations planifiées la semaine du {0} au {1}", CDate(_oRapport_Fm_Imp.sDateDebut_This).ToShortDateString, CDate(_oRapport_Fm_Imp.sDateFin_This).ToShortDateString) 'actuelle
    XrLblMultitechActDeciClientTitle.Text = String.Format("Actions en attente de validation de {0} au {1}", _oRapport_Fm_Imp.VCLINOM, Now.ToShortDateString)

    XrLblBauxActEnCoursTitle.Text = String.Format("Actions en cours de traitement au {0}", Now.ToShortDateString)

    XrLblDechetsActEnCoursTitle.Text = String.Format("Actions en cours de traitement au {0}", Now.ToShortDateString)

  End Sub

  Private Sub SqlDS_Imp_Rapport_Fm_Hebdo_ConfigureDataConnection(sender As Object, e As DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs) Handles SqlDS_Imp_Rapport_Fm_Hebdo.ConfigureDataConnection

    Dim oParamConnection As MsSqlConnectionParameters = e.ConnectionParameters

    If Not oParamConnection Is Nothing Then

      oParamConnection.ServerName = _NomServerSQL

    End If

  End Sub

  Private Sub PageFooter_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles PageFooter.BeforePrint



  End Sub
End Class