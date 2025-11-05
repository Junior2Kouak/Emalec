Imports System.Data.SqlClient
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.XtraCharts
Imports DevExpress.XtraReports.UI
Imports MozartLib

Public Class XReport_Rapport_fm_Main

  Dim _oRapport_Fm_Imp As CRapportFM

  Dim _NomServerSQL As String

  Dim sNameLastMonth As String

  Dim SumDelaiDepannage_Moy As Int32 = 0
  Dim SumDelaiDepannage_Nb_Inter As Int32 = 0

  Dim SumDevisNbrTot As Int32 = 0
  Dim SumDevisNbrRea As Int32 = 0
  Dim SumDevisNbrARea As Int32 = 0
  Dim SumDevisNbrCde As Int32 = 0
  Dim SumDevisNbrAttente As Int32 = 0
  Dim SumDevisNbrNoSuite As Int32 = 0

  Public Sub New(ByVal c_Rapport_Fm_Imp As CRapportFM, ByVal c_NomServerSQL As String)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _oRapport_Fm_Imp = c_Rapport_Fm_Imp
    _NomServerSQL = c_NomServerSQL

    'param
    ParamNCLINUM.Value = _oRapport_Fm_Imp.NCLINUM
    ParamVENSEIGNE.Value = "$TS"

    ParamDateDebut_PeriodeSelect.Value = _oRapport_Fm_Imp.sDateDebut_This
    ParamDateFin_PeriodeSelect.Value = _oRapport_Fm_Imp.sDateFin_This

    ParamDateDebut_LastMonth.Value = DateAdd(DateInterval.Month, -1, DateAdd(DateInterval.Day, -_oRapport_Fm_Imp.sDateFin_This.Day, _oRapport_Fm_Imp.sDateFin_This)) 'sDateDebut_Last
    ParamDateFin_LastMonth.Value = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Day, -_oRapport_Fm_Imp.sDateFin_This.Day, _oRapport_Fm_Imp.sDateFin_This))

    If _oRapport_Fm_Imp.sDateDebut_Annee = Nothing Then
      ParamDateDebut_ThisYear.Value = CDate("01/01/" & _oRapport_Fm_Imp.sDateFin_This.Year)
    Else
      ParamDateDebut_ThisYear.Value = CDate(_oRapport_Fm_Imp.sDateDebut_Annee)
    End If


    ParamDateFin_ThisYear.Value = CDate(_oRapport_Fm_Imp.sDateFin_This)

    ParamDateFin_Last12M.Value = DateAdd(DateInterval.Day, -_oRapport_Fm_Imp.sDateFin_This.Day, _oRapport_Fm_Imp.sDateFin_This)
    ParamDateDebut_Last12M.Value = DateAdd(DateInterval.Month, -12, ParamDateFin_Last12M.Value)

    sNameLastMonth = MonthName(CDate(ParamDateFin_LastMonth.Value).Month).Substring(0, 1).ToUpper + MonthName(CDate(ParamDateFin_LastMonth.Value).Month).Substring(1, MonthName(CDate(ParamDateFin_LastMonth.Value).Month).Length - 1)

    'Ajout des tradcutions
    'SetTraduction()

    'Get traduction
    GetTraduction()

    'page sommaire
    XrPictBoxBandeau.Image = My.Resources.Bandeau_RAPPORT_FM

    XrLbldateEdition.Text = "Edition du " & Now.Date.ToShortDateString

    'remplacement
    XrPictLogoVSOCIETE.Image = _oRapport_Fm_Imp.iLogoSociete
    XrPictLogoLOGOCLIENT.Image = _oRapport_Fm_Imp.iLogoClient
    XrPictLogoGROUP.Image = _oRapport_Fm_Imp.iLogoGroup

    XrLblVCLINOM.Text = _oRapport_Fm_Imp.VCLINOM

    XrLblRapportFmTitle.Text = _oRapport_Fm_Imp.VRAPPORT_FM_TITLE
    XrLblPeriode.Text = _oRapport_Fm_Imp.VPERIODE

    XrrichTxtOrgaGen.Rtf = _oRapport_Fm_Imp.VCHAP_MSG

    XrRichTxtSommaire.Rtf = XrRichTxtSommaire.Rtf.Replace("#VCLINOM#", _oRapport_Fm_Imp.VCLINOM)

    'title chart
    XrChartPieMaintenancePrevExe_LastM.Titles(0).Text = sNameLastMonth & " " & CDate(ParamDateFin_LastMonth.Value).Year
    XrChartLDR_Pie_LastMonth.Titles(0).Text = sNameLastMonth & " " & CDate(ParamDateFin_LastMonth.Value).Year
    XrChart2.Titles(0).Text = sNameLastMonth & " " & CDate(ParamDateFin_LastMonth.Value).Year

    XrChartPieMaintenancePrevExe_Year.Titles(0).Text = "Depuis le " & CDate(ParamDateDebut_ThisYear.Value).ToShortDateString
    XrChartLDR_Pie_Year.Titles(0).Text = "Depuis le " & CDate(ParamDateDebut_ThisYear.Value).ToShortDateString
    XrChart3.Titles(0).Text = "Depuis le " & CDate(ParamDateDebut_ThisYear.Value).ToShortDateString

    'titre des urgences
    XrChart27.Titles(0).Text = String.Format(XrChart27.Titles(0).Text, _oRapport_Fm_Imp.DtRapport_FM_DelaiByUrg.Select("[CURGCOD] = '1'")(0).Item("VDELAI"))
    XrChart28.Titles(0).Text = String.Format(XrChart28.Titles(0).Text, _oRapport_Fm_Imp.DtRapport_FM_DelaiByUrg.Select("[CURGCOD] = '2'")(0).Item("VDELAI"))
    XrChart29.Titles(0).Text = String.Format(XrChart29.Titles(0).Text, _oRapport_Fm_Imp.DtRapport_FM_DelaiByUrg.Select("[CURGCOD] = '3'")(0).Item("VDELAI"))
    XrChart30.Titles(0).Text = String.Format(XrChart30.Titles(0).Text, _oRapport_Fm_Imp.DtRapport_FM_DelaiByUrg.Select("[CURGCOD] = '4'")(0).Item("VDELAI"))
    XrChart31.Titles(0).Text = String.Format(XrChart31.Titles(0).Text, _oRapport_Fm_Imp.DtRapport_FM_DelaiByUrg.Select("[CURGCOD] = '5'")(0).Item("VDELAI"))

    AfficheSommaire()

    AfficheRequete()

  End Sub

  Private Sub AfficheSommaire()

    Dim sSommaire As String = ""

    If Not _oRapport_Fm_Imp.DtRapport_FM_Requetes Is Nothing Then

      For Each drRequetes As DataRow In _oRapport_Fm_Imp.DtRapport_FM_Requetes.Rows

        sSommaire = sSommaire & (drRequetes.Item("NORDER")).ToString & " - " & drRequetes.Item("VLIBCHAPITRE") & vbCrLf

      Next

    End If

    XrRichTxtSommaire.Text = sSommaire

  End Sub

  Private Sub AfficheRequete()

    For Each oband As Band In Me.Bands

      Dim t As Type = oband.GetType()

      If t.Equals(GetType(DetailReportBand)) Then

        'modificaiton du nom de la societe
        XrTableCell711.Text = "Devis réalisés par " & MozartParams.NomSociete
        XrTableCell712.Text = "Devis à finaliser " & MozartParams.NomSociete
        XrTableCell704.Text = "Délai moyen de réalisation travaux pour " & MozartParams.NomSociete & " (j)"

        XrTableCell749.Text = "Devis réalisés par " & MozartParams.NomSociete
        XrTableCell750.Text = "Devis à finaliser " & MozartParams.NomSociete
        XrTableCell765.Text = "Délai moyen de réalisation travaux pour " & MozartParams.NomSociete & " (j)"

        Dim xrCtrlBandLevel As DetailReportBand = oband
        'on affiche toujours la 1ere page SOMMAIRE
        If xrCtrlBandLevel.Level = 0 Then
          oband.Visible = True
          'Return
        Else

          If GetOrderRequeteRapportFM(oband.Name) >= 0 And oband.Name <> "Detail" Then
            oband.Visible = True
          Else
            oband.Visible = False
          End If

        End If

      Else

        oband.Visible = True

      End If

    Next

    'gestion des levels
    For Each drLevel As DataRow In _oRapport_Fm_Imp.DtRapport_FM_Requetes.Rows

      Dim xrCtrlBandLevel As DetailReportBand = TryCast(Me.FindControl(drLevel.Item("VLIBDESCRIPT"), False), DetailReportBand)

      xrCtrlBandLevel.Level = drLevel.Item("NORDER")

      'gestion de la numérotation des chapitres selon le sommaire
      Select Case drLevel.Item("VLIBDESCRIPT")
        Case "DetailReportChap_Maintenance"
          XrLblMaintenanceTitle.Text = xrCtrlBandLevel.Level & Space(1) & "-" & Space(1) & XrLblMaintenanceTitle.Text
        Case "DetailReportChap_LDR"
          XrLblLDRTitle.Text = xrCtrlBandLevel.Level & Space(1) & "-" & Space(1) & XrLblLDRTitle.Text
        Case "DetailReportChap_Devis"
          XrLblTitreDevisAttenteDec.Text = xrCtrlBandLevel.Level & Space(1) & "-" & Space(1) & XrLblTitreDevisAttenteDec.Text
        Case "DetailReportChap_RapportIncident"
          XrLblTitreRapportIncident.Text = xrCtrlBandLevel.Level & Space(1) & "-" & Space(1) & XrLblTitreRapportIncident.Text
        Case "DetailReport_ChapStatBySecteur"
          XrLblTitre_ChapStatBySecteur.Text = xrCtrlBandLevel.Level & Space(1) & "-" & Space(1) & XrLblTitre_ChapStatBySecteur.Text
        Case "DetailReport_ChapStatByTechnique"
          XrLblTitre_ChapStatByTechnique.Text = xrCtrlBandLevel.Level & Space(1) & "-" & Space(1) & XrLblTitre_ChapStatByTechnique.Text
        Case "DetailReport_ChapStatByPresta"
          XrLblTitre_ChapStatByPresta.Text = xrCtrlBandLevel.Level & Space(1) & "-" & Space(1) & XrLblTitre_ChapStatByPresta.Text
        Case "DetailReport_ListeActionsAstreinte"
          XrLblTitreListeActionsAsteinte.Text = xrCtrlBandLevel.Level & Space(1) & "-" & Space(1) & XrLblTitreListeActionsAsteinte.Text
        Case "DetailReport_ChapStatGeneral"
          XrLblTitre_ChapStat_StatGeneral.Text = xrCtrlBandLevel.Level & Space(1) & "-" & Space(1) & XrLblTitre_ChapStat_StatGeneral.Text
        Case "DetailReport_ChapStatByUrg"
          XrLblTitre_ChapStatByUrg.Text = xrCtrlBandLevel.Level & Space(1) & "-" & Space(1) & XrLblTitre_ChapStatByUrg.Text
        Case "DetailReport_ChapStatDelaiDepannage"
          XrLblTitre_ChapStatDelaiDepannage.Text = xrCtrlBandLevel.Level & Space(1) & "-" & Space(1) & XrLblTitre_ChapStatDelaiDepannage.Text
        Case "DetailReport_ChapStatFactMens"
          XrLblTitre_ChapStatFactMens.Text = xrCtrlBandLevel.Level & Space(1) & "-" & Space(1) & XrLblTitre_ChapStatFactMens.Text
        Case "DetailReport_ChapStatDevisByContrat"
          XrLblTitre_ChapStatNbrDevisByContrat.Text = xrCtrlBandLevel.Level & Space(1) & "-" & Space(1) & XrLblTitre_ChapStatNbrDevisByContrat.Text
        Case "DetailReport_ChapStatListeActCreeInMonth"
          XrLblTitre_ChapStatListeActCreeInMonth.Text = xrCtrlBandLevel.Level & Space(1) & "-" & Space(1) & XrLblTitre_ChapStatListeActCreeInMonth.Text
        Case "DetailReport_ChapStatBySecteur_SEMMARIS"
          XrLblTitre_ChapStatBySecteur_SEMMARIS.Text = xrCtrlBandLevel.Level & Space(1) & "-" & Space(1) & XrLblTitre_ChapStatBySecteur_SEMMARIS.Text
        Case "DetailReport_ChapStatByLot_SEMMARIS"
          XrLblTitre_ChapStatByLot_SEMMARIS.Text = xrCtrlBandLevel.Level & Space(1) & "-" & Space(1) & XrLblTitre_ChapStatByLot_SEMMARIS.Text
        Case "DetailReport_ChapStatListeActCreeInMonth_SEMMARIS"
          XrLblTitre_ChapStatListeActCreeInMonth_SEMMARIS.Text = xrCtrlBandLevel.Level & Space(1) & "-" & Space(1) & XrLblTitre_ChapStatListeActCreeInMonth_SEMMARIS.Text
      End Select

    Next

  End Sub

  Private Function GetOrderRequeteRapportFM(ByVal p_requete_search As String) As Int32

    If Not _oRapport_Fm_Imp.DtRapport_FM_Requetes Is Nothing Then

      For Each drRequetes As DataRow In _oRapport_Fm_Imp.DtRapport_FM_Requetes.Rows

        If drRequetes.Item("VLIBDESCRIPT") = p_requete_search Then

          Return drRequetes.Item("NORDER")

        End If

      Next

    End If

    Return -1

  End Function

  Private Sub SqlDS_Imp_Rapport_Fm_Hebdo_ConfigureDataConnection(sender As Object, e As DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs) Handles SqlDS_Imp_Rapport_Fm_Hebdo.ConfigureDataConnection

    Dim oParamConnection As MsSqlConnectionParameters = e.ConnectionParameters

    If Not oParamConnection Is Nothing Then

      oParamConnection.ServerName = _NomServerSQL

    End If

  End Sub

  Private Sub XrLabelDelaiDepannage_Delai_Moy_SummaryGetResult(sender As Object, e As SummaryGetResultEventArgs) Handles XrLabelDelaiDepannage_Delai_Moy.SummaryGetResult

    e.Result = Convert.ToDecimal(SumDelaiDepannage_Moy / SumDelaiDepannage_Nb_Inter)
    e.Handled = True

  End Sub

  Private Sub XrLabelDelaiDepannage_Delai_Moy_SummaryRowChanged(sender As Object, e As EventArgs) Handles XrLabelDelaiDepannage_Delai_Moy.SummaryRowChanged

    SumDelaiDepannage_Moy = SumDelaiDepannage_Moy + Convert.ToInt32(DetailReport_SC_StatDelaiDepannage_Tab.GetCurrentColumnValue("NB_J") * DetailReport_SC_StatDelaiDepannage_Tab.GetCurrentColumnValue("TOTAL_ACT"))
    SumDelaiDepannage_Nb_Inter = SumDelaiDepannage_Nb_Inter + Convert.ToInt32(DetailReport_SC_StatDelaiDepannage_Tab.GetCurrentColumnValue("TOTAL_ACT"))

  End Sub

  Private Sub XrLabelDelaiDepannage_Delai_Moy_SummaryReset(sender As Object, e As EventArgs) Handles XrLabelDelaiDepannage_Delai_Moy.SummaryReset
    SumDelaiDepannage_Moy = 0
    SumDelaiDepannage_Nb_Inter = 0
  End Sub

  Private Sub XrTableCell731_SummaryRowChanged(sender As Object, e As EventArgs) Handles XrTableCell731.SummaryRowChanged
    SumDevisNbrTot = SumDevisNbrTot + Convert.ToInt32(DetailReport_SC_StatDevisByContrat_Nbr_Tab.GetCurrentColumnValue("TOT"))
    SumDevisNbrRea = SumDevisNbrRea + Convert.ToInt32(DetailReport_SC_StatDevisByContrat_Nbr_Tab.GetCurrentColumnValue("FAIT"))
  End Sub

  Private Sub XrTableCell731_SummaryGetResult(sender As Object, e As SummaryGetResultEventArgs) Handles XrTableCell731.SummaryGetResult

    e.Result = String.Format("{0:n2}", Convert.ToDecimal(SumDevisNbrRea / SumDevisNbrTot))
    e.Handled = True

  End Sub

  Private Sub XrTableCell731_SummaryReset(sender As Object, e As EventArgs) Handles XrTableCell731.SummaryReset
    SumDevisNbrTot = 0
    SumDevisNbrRea = 0
  End Sub

  Private Sub XrTableCell736_SummaryRowChanged(sender As Object, e As EventArgs) Handles XrTableCell736.SummaryRowChanged
    SumDevisNbrARea = SumDevisNbrARea + Convert.ToInt32(DetailReport_SC_StatDevisByContrat_Nbr_Tab.GetCurrentColumnValue("AFAIRE"))
  End Sub

  Private Sub XrTableCell736_SummaryReset(sender As Object, e As EventArgs) Handles XrTableCell736.SummaryReset
    SumDevisNbrARea = 0
  End Sub

  Private Sub XrTableCell736_SummaryGetResult(sender As Object, e As SummaryGetResultEventArgs) Handles XrTableCell736.SummaryGetResult
    e.Result = String.Format("{0:n2}", Convert.ToDecimal(SumDevisNbrARea / SumDevisNbrTot))
    e.Handled = True
  End Sub

  Private Sub SetTraduction()

    'recherche de tous les labels
    For Each oXrLblRapport As XRLabel In Me.AllControls(Of XRLabel)

      If oXrLblRapport.Name <> oXrLblRapport.Text Then

        InsertTraduction(oXrLblRapport.Text)

      End If

    Next

    'recherche de tous les title des charts
    For Each oXrChartTitleRapport As XRChart In Me.AllControls(Of XRChart)

      For Each oTitle As ChartTitle In oXrChartTitleRapport.Titles
        InsertTraduction(oTitle.Text)
      Next

    Next

    'recherche de tous les title des charts
    For Each oXrCellRapport As XRTableCell In Me.AllControls(Of XRTableCell)

      If oXrCellRapport.Name <> oXrCellRapport.Text And oXrCellRapport.Text <> "" Then
        InsertTraduction(oXrCellRapport.Text)
      End If

    Next

  End Sub

  Private Sub GetTraduction()

    'recherche de tous les labels
    For Each oXrLblRapport As XRLabel In Me.AllControls(Of XRLabel)

      If oXrLblRapport.Name <> oXrLblRapport.Text Then

        oXrLblRapport.Text = SelectTraduction(oXrLblRapport.Text)

      End If

    Next

    'recherche de tous les title des charts
    For Each oXrChartTitleRapport As XRChart In Me.AllControls(Of XRChart)

      For Each oTitle As ChartTitle In oXrChartTitleRapport.Titles
        oTitle.Text = SelectTraduction(oTitle.Text)
      Next

    Next

    'recherche de tous les title des charts
    For Each oXrCellRapport As XRTableCell In Me.AllControls(Of XRTableCell)

      If oXrCellRapport.Name <> oXrCellRapport.Text And oXrCellRapport.Text <> "" Then
        oXrCellRapport.Text = SelectTraduction(oXrCellRapport.Text)
      End If

    Next

  End Sub

  Private Sub InsertTraduction(ByVal p_Chaine As String)

    Dim sqlcmdInsert As New SqlCommand("[api_sp_InsertTLGMOZART]", MozartDatabase.cnxMozart)
    sqlcmdInsert.CommandType = CommandType.StoredProcedure
    sqlcmdInsert.Parameters.Add("@P_FICHIER", SqlDbType.VarChar).Value = "XReport_Rapport_fm_Main"
    sqlcmdInsert.Parameters.Add("@P_CHAINE", SqlDbType.VarChar).Value = p_Chaine
    sqlcmdInsert.ExecuteNonQuery()

  End Sub

  Private Function SelectTraduction(ByVal p_Chaine As String) As String

    Dim sqlcmdGet As New SqlCommand("[api_sp_GetTraduction]", MozartDatabase.cnxMozart)
    sqlcmdGet.CommandType = CommandType.StoredProcedure
    sqlcmdGet.Parameters.Add("@p_vexpress", SqlDbType.VarChar, -1).Value = p_Chaine
    sqlcmdGet.Parameters.Add("@p_vlangue", SqlDbType.VarChar, 3).Value = _oRapport_Fm_Imp.sLangue
    sqlcmdGet.Parameters.Add("@out_vexpress_trad", SqlDbType.VarChar, -1).Value = p_Chaine
    sqlcmdGet.Parameters("@out_vexpress_trad").Direction = ParameterDirection.InputOutput
    sqlcmdGet.Parameters.Add("@fichier", SqlDbType.VarChar, 255).Value = "XReport_Rapport_fm_Main"
    sqlcmdGet.ExecuteNonQuery()

    Return sqlcmdGet.Parameters("@out_vexpress_trad").Value

  End Function

End Class