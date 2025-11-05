Imports System.Data.SqlClient
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports MozartLib

Public Class CRapportFM_Generate

  Dim _oGen_RapportFM As CRapportFM
  Dim _Export As String
  Public Sub New(ByRef c_oRapprtFM As CRapportFM, Optional ByVal c_Export As String = "PDF")

    _oGen_RapportFM = c_oRapprtFM
    _Export = c_Export

  End Sub

  Public Function GenerateRapportFM() As String

    If _oGen_RapportFM Is Nothing Then Return ""

    Dim sFileOut As String = ""

    'Dim oRapportFmDoc As New XReport_Rapport_fm_Main(_oGen_RapportFM, gstrNomServeur)

    Dim oRapportFmDoc As New XR_Page_Garde(_oGen_RapportFM, MozartParams.NomServeur)
    oRapportFmDoc.CreateDocument()


    If _oGen_RapportFM.bAfficheSite = True Then

      Dim oRapportFmDocListeSites As New XR_Page_Chap_ListeSiteRapport(_oGen_RapportFM, MozartParams.NomServeur)
      oRapportFmDocListeSites.CreateDocument()
      AddPagesInRapportFM(oRapportFmDoc, oRapportFmDocListeSites)

    End If

    'Dim oRapportFmDoc_Chap_XR_Page_Chap_DepannageSite As New XR_Page_Chap_DepannageSite(_oGen_RapportFM, gstrNomServeur, 0)
    'oRapportFmDoc_Chap_XR_Page_Chap_DepannageSite.CreateDocument()
    'If oRapportFmDoc_Chap_XR_Page_Chap_DepannageSite.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_XR_Page_Chap_DepannageSite)

    For Each DrChapitre As DataRow In _oGen_RapportFM.DtRapport_FM_Requetes.Rows

      Select Case DrChapitre.Item("VLIBDESCRIPT")
        Case "DetailReportGeneralites"

          ''XR_Page_Chap_SEMMARIS_StatHrReaByDomaine
          'Dim oRapportFmDoc_Semmaris_StatHRByDom As New XR_Page_Chap_SEMMARIS_StatHrReaByDomaine(_oGen_RapportFM, gstrNomServeur, DrChapitre.Item("NORDER"))
          'oRapportFmDoc_Semmaris_StatHRByDom.CreateDocument()

          'If oRapportFmDoc_Semmaris_StatHRByDom.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Semmaris_StatHRByDom)

          ''XR_Page_Chap_SEMMARIS_StatHrReaBySecteur
          'Dim oRapportFmDoc_Semmaris_StatHrReaBySecteur As New XR_Page_Chap_SEMMARIS_StatHrReaBySecteur(_oGen_RapportFM, gstrNomServeur, DrChapitre.Item("NORDER"))
          'oRapportFmDoc_Semmaris_StatHrReaBySecteur.CreateDocument()

          'If oRapportFmDoc_Semmaris_StatHrReaBySecteur.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Semmaris_StatHrReaBySecteur)

          Dim oRapportFmDoc_Gen As New XR_Page_Generalites(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Gen.CreateDocument()
          If oRapportFmDoc_Gen.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Gen)

        Case "DetailReportChap_Maintenance_AvecTableau_SansPlanning"
          Dim oRapportFmDoc_Chap_Maint As New XR_Page_Chap_Maintenance(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_Maint.CreateDocument()
          If oRapportFmDoc_Chap_Maint.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_Maint)

          Dim DTListeContrat As New DataTable
          Dim sqlcmdCont As New SqlCommand("[api_sp_Rapport_FM_Impression_ListeContratClientAffecte]", MozartDatabase.cnxMozart)
          sqlcmdCont.CommandType = CommandType.StoredProcedure
          sqlcmdCont.Parameters.Add("@P_NCLINUM", SqlDbType.Int).Value = _oGen_RapportFM.NCLINUM
          sqlcmdCont.Parameters.Add("@P_LANGUE", SqlDbType.VarChar).Value = _oGen_RapportFM.sLangue
          DTListeContrat.Load(sqlcmdCont.ExecuteReader)

        Case "DetailReportChap_Maintenance_AvecTableau_AvecPlanning"
          Dim oRapportFmDoc_Chap_Maint As New XR_Page_Chap_Maintenance(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_Maint.CreateDocument()
          If oRapportFmDoc_Chap_Maint.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_Maint)

          Dim DTListeContrat As New DataTable
          Dim sqlcmdCont As New SqlCommand("[api_sp_Rapport_FM_Impression_ListeContratClientAffecte]", MozartDatabase.cnxMozart)
          sqlcmdCont.CommandType = CommandType.StoredProcedure
          sqlcmdCont.Parameters.Add("@P_NCLINUM", SqlDbType.Int).Value = _oGen_RapportFM.NCLINUM
          sqlcmdCont.Parameters.Add("@P_LANGUE", SqlDbType.VarChar).Value = _oGen_RapportFM.sLangue
          DTListeContrat.Load(sqlcmdCont.ExecuteReader)

                    Dim oRapportFmDoc_Chap_Maint_TableauPrev As XtraReport = Nothing

                    For Each row As DataRow In DTListeContrat.Rows

                        'If oRapportFmDoc_Chap_Maint_TableauPrev Is Nothing Then
                        oRapportFmDoc_Chap_Maint_TableauPrev = New XR_Page_Chap_Maintenance_TableauPrev(_oGen_RapportFM, MozartParams.NomServeur, row.Item("NTYPECONTRAT"), row.Item("VTYPECONTRAT"))
                        oRapportFmDoc_Chap_Maint_TableauPrev.CreateDocument()
                        AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_Maint_TableauPrev)
                        'Else
                        'Dim oRapportFmDoc_Chap_Maint_TableauPrev_New As New XR_Page_Chap_Maintenance_TableauPrev(_oGen_RapportFM, MozartParams.NomServeur, row.Item("NTYPECONTRAT"), row.Item("VTYPECONTRAT"))
                        'oRapportFmDoc_Chap_Maint_TableauPrev_New.XrPageInfo_Chap_Maintenance.Visible = False
                        'oRapportFmDoc_Chap_Maint_TableauPrev_New.XrLblMaintenanceTitle.Visible = False
                        'AddInGROUPFooter(oRapportFmDoc_Chap_Maint_TableauPrev, oRapportFmDoc_Chap_Maint_TableauPrev_New)
                        'End If

                    Next
                    'If oRapportFmDoc_Chap_Maint_TableauPrev IsNot Nothing Then
                    '    oRapportFmDoc_Chap_Maint_TableauPrev.CreateDocument()
                    '    AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_Maint_TableauPrev)
                    'End If

                Case "DetailReportChap_Maintenance_AvecTableau_AvecPlanning_On_Period"
          Dim oRapportFmDoc_Chap_Maint As New XR_Page_Chap_Maintenance(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"), 1)
          oRapportFmDoc_Chap_Maint.CreateDocument()
          If oRapportFmDoc_Chap_Maint.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_Maint)

          Dim DTListeContrat As New DataTable
          Dim sqlcmdCont As New SqlCommand("[api_sp_Rapport_FM_Impression_ListeContratClientAffecte]", MozartDatabase.cnxMozart)
          sqlcmdCont.CommandType = CommandType.StoredProcedure
          sqlcmdCont.Parameters.Add("@P_NCLINUM", SqlDbType.Int).Value = _oGen_RapportFM.NCLINUM
          sqlcmdCont.Parameters.Add("@P_LANGUE", SqlDbType.VarChar).Value = _oGen_RapportFM.sLangue
          DTListeContrat.Load(sqlcmdCont.ExecuteReader)

          Dim oRapportFmDoc_Chap_Maint_TableauPrev As XtraReport = Nothing

          For Each row As DataRow In DTListeContrat.Rows

            If oRapportFmDoc_Chap_Maint_TableauPrev Is Nothing Then
              oRapportFmDoc_Chap_Maint_TableauPrev = New XR_Page_Chap_Maintenance_TableauPrev(_oGen_RapportFM, MozartParams.NomServeur, row.Item("NTYPECONTRAT"), row.Item("VTYPECONTRAT"), 1)
            Else
              Dim oRapportFmDoc_Chap_Maint_TableauPrev_New As New XR_Page_Chap_Maintenance_TableauPrev(_oGen_RapportFM, MozartParams.NomServeur, row.Item("NTYPECONTRAT"), row.Item("VTYPECONTRAT"), 1)
              oRapportFmDoc_Chap_Maint_TableauPrev_New.XrPageInfo_Chap_Maintenance.Visible = False
              oRapportFmDoc_Chap_Maint_TableauPrev_New.XrLblMaintenanceTitle.Visible = False
              AddInGROUPFooter(oRapportFmDoc_Chap_Maint_TableauPrev, oRapportFmDoc_Chap_Maint_TableauPrev_New)
            End If

          Next
          If oRapportFmDoc_Chap_Maint_TableauPrev IsNot Nothing Then
            oRapportFmDoc_Chap_Maint_TableauPrev.CreateDocument()
            AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_Maint_TableauPrev)
          End If

        Case "DetailReportChap_Maintenance_SansTableau_SansPlanning"
          Dim oRapportFmDoc_Chap_Maint As New XR_Page_Chap_Maintenance(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_Maint.DR_Chap_Maintenance_Tab.Visible = False
          oRapportFmDoc_Chap_Maint.CreateDocument()
          If oRapportFmDoc_Chap_Maint.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_Maint)

        Case "DetailReportChap_Maintenance_SansTableau_SansPlanning_On_Period"
          Dim oRapportFmDoc_Chap_Maint As New XR_Page_Chap_Maintenance(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"), 1)
          oRapportFmDoc_Chap_Maint.DR_Chap_Maintenance_Tab.Visible = False
          oRapportFmDoc_Chap_Maint.CreateDocument()
          If oRapportFmDoc_Chap_Maint.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_Maint)
        Case "DetailReportChap_Maintenance_SansTableau_AvecPlanning"
          Dim oRapportFmDoc_Chap_Maint As New XR_Page_Chap_Maintenance(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_Maint.DR_Chap_Maintenance_Tab.Visible = False
          oRapportFmDoc_Chap_Maint.CreateDocument()
          If oRapportFmDoc_Chap_Maint.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_Maint)

          Dim DTListeContrat As New DataTable
          Dim sqlcmdCont As New SqlCommand("[api_sp_Rapport_FM_Impression_ListeContratClientAffecte]", MozartDatabase.cnxMozart)
          sqlcmdCont.CommandType = CommandType.StoredProcedure
          sqlcmdCont.Parameters.Add("@P_NCLINUM", SqlDbType.Int).Value = _oGen_RapportFM.NCLINUM
          sqlcmdCont.Parameters.Add("@P_LANGUE", SqlDbType.VarChar).Value = _oGen_RapportFM.sLangue
          DTListeContrat.Load(sqlcmdCont.ExecuteReader)

          Dim oRapportFmDoc_Chap_Maint_TableauPrev As XtraReport = Nothing

          For Each row As DataRow In DTListeContrat.Rows

            If oRapportFmDoc_Chap_Maint_TableauPrev Is Nothing Then
              oRapportFmDoc_Chap_Maint_TableauPrev = New XR_Page_Chap_Maintenance_TableauPrev(_oGen_RapportFM, MozartParams.NomServeur, row.Item("NTYPECONTRAT"), row.Item("VTYPECONTRAT"))
            Else
              Dim oRapportFmDoc_Chap_Maint_TableauPrev_New As New XR_Page_Chap_Maintenance_TableauPrev(_oGen_RapportFM, MozartParams.NomServeur, row.Item("NTYPECONTRAT"), row.Item("VTYPECONTRAT"))
              oRapportFmDoc_Chap_Maint_TableauPrev_New.XrPageInfo_Chap_Maintenance.Visible = False
              oRapportFmDoc_Chap_Maint_TableauPrev_New.XrLblMaintenanceTitle.Visible = False
              AddInGROUPFooter(oRapportFmDoc_Chap_Maint_TableauPrev, oRapportFmDoc_Chap_Maint_TableauPrev_New)
            End If

          Next
          If oRapportFmDoc_Chap_Maint_TableauPrev IsNot Nothing Then
            oRapportFmDoc_Chap_Maint_TableauPrev.CreateDocument()
            AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_Maint_TableauPrev)
          End If
        Case "DetailReportChap_Maintenance_SansTableau_AvecPlanning_On_Period"
          Dim oRapportFmDoc_Chap_Maint As New XR_Page_Chap_Maintenance(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"), 1)
          oRapportFmDoc_Chap_Maint.DR_Chap_Maintenance_Tab.Visible = False
          oRapportFmDoc_Chap_Maint.CreateDocument()
          If oRapportFmDoc_Chap_Maint.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_Maint)

          Dim DTListeContrat As New DataTable
          Dim sqlcmdCont As New SqlCommand("[api_sp_Rapport_FM_Impression_ListeContratClientAffecte]", MozartDatabase.cnxMozart)
          sqlcmdCont.CommandType = CommandType.StoredProcedure
          sqlcmdCont.Parameters.Add("@P_NCLINUM", SqlDbType.Int).Value = _oGen_RapportFM.NCLINUM
          sqlcmdCont.Parameters.Add("@P_LANGUE", SqlDbType.VarChar).Value = _oGen_RapportFM.sLangue
          DTListeContrat.Load(sqlcmdCont.ExecuteReader)

          Dim oRapportFmDoc_Chap_Maint_TableauPrev As XtraReport = Nothing

          For Each row As DataRow In DTListeContrat.Rows

            If oRapportFmDoc_Chap_Maint_TableauPrev Is Nothing Then
              oRapportFmDoc_Chap_Maint_TableauPrev = New XR_Page_Chap_Maintenance_TableauPrev(_oGen_RapportFM, MozartParams.NomServeur, row.Item("NTYPECONTRAT"), row.Item("VTYPECONTRAT"), 1)
            Else
              Dim oRapportFmDoc_Chap_Maint_TableauPrev_New As New XR_Page_Chap_Maintenance_TableauPrev(_oGen_RapportFM, MozartParams.NomServeur, row.Item("NTYPECONTRAT"), row.Item("VTYPECONTRAT"), 1)
              oRapportFmDoc_Chap_Maint_TableauPrev_New.XrPageInfo_Chap_Maintenance.Visible = False
              oRapportFmDoc_Chap_Maint_TableauPrev_New.XrLblMaintenanceTitle.Visible = False
              AddInGROUPFooter(oRapportFmDoc_Chap_Maint_TableauPrev, oRapportFmDoc_Chap_Maint_TableauPrev_New)
            End If

          Next
          If oRapportFmDoc_Chap_Maint_TableauPrev IsNot Nothing Then
            oRapportFmDoc_Chap_Maint_TableauPrev.CreateDocument()
            AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_Maint_TableauPrev)
          End If
        Case "DetailReportChap_LDR"
          Dim oRapportFmDoc_Chap_LDR As New XR_Page_Chap_LDR(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_LDR.CreateDocument()
          If oRapportFmDoc_Chap_LDR.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_LDR)
        Case "DetailReportChap_Devis"
          Dim oRapportFmDoc_Chap_Devis As New XR_Page_Chap_Devis(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_Devis.CreateDocument()
          If oRapportFmDoc_Chap_Devis.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_Devis)
        Case "DetailReportChap_RapportIncident"
          Dim oRapportFmDoc_Chap_RapportIncident As New XR_Page_Chap_RapportIncident(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_RapportIncident.CreateDocument()
          If oRapportFmDoc_Chap_RapportIncident.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_RapportIncident)
        Case "DetailReport_ChapStatBySecteur"
          Dim oRapportFmDoc_Chap_StatBySecteur As New XR_Page_Chap_StatBySecteur(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_StatBySecteur.CreateDocument()
          If oRapportFmDoc_Chap_StatBySecteur.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_StatBySecteur)
        Case "DetailReport_ChapStatBySecteur_WO_Prev"
          Dim oRapportFmDoc_Chap_StatBySecteur As New XR_Page_Chap_StatBySecteur(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"), False)
          oRapportFmDoc_Chap_StatBySecteur.CreateDocument()
          If oRapportFmDoc_Chap_StatBySecteur.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_StatBySecteur)
        Case "DetailReport_ChapStatByTechnique"
          Dim oRapportFmDoc_Chap_StatByTechnique As New XR_Page_Chap_StatByTechnique(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_StatByTechnique.CreateDocument()
          If oRapportFmDoc_Chap_StatByTechnique.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_StatByTechnique)
        Case "DetailReport_ChapStatByTechnique_WO_Prev"
          Dim oRapportFmDoc_Chap_StatByTechnique As New XR_Page_Chap_StatByTechnique(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"), False)
          oRapportFmDoc_Chap_StatByTechnique.CreateDocument()
          If oRapportFmDoc_Chap_StatByTechnique.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_StatByTechnique)
        Case "DetailReport_ChapStatByPresta"
          Dim oRapportFmDoc_Chap_StatByPresta As New XR_Page_Chap_StatByPresta(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_StatByPresta.CreateDocument()
          If oRapportFmDoc_Chap_StatByPresta.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_StatByPresta)
        Case "DetailReport_ChapStatByPresta_WO_Prev"
          Dim oRapportFmDoc_Chap_StatByPresta As New XR_Page_Chap_StatByPresta(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"), False)
          oRapportFmDoc_Chap_StatByPresta.CreateDocument()
          If oRapportFmDoc_Chap_StatByPresta.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_StatByPresta)
        Case "DetailReport_ListeActionsAstreinte"
          Dim oRapportFmDoc_Chap_ActionsAstreinte As New XR_Page_Chap_ActionsAstreinte(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_ActionsAstreinte.CreateDocument()
          If oRapportFmDoc_Chap_ActionsAstreinte.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_ActionsAstreinte)
        Case "DetailReport_ChapStatGeneral"
          Dim oRapportFmDoc_Chap_StatGeneral As New XR_Page_Chap_StatGeneral(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_StatGeneral.CreateDocument()
          If oRapportFmDoc_Chap_StatGeneral.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_StatGeneral)
        Case "DetailReport_ChapStatGeneral_WO_Prev"
          Dim oRapportFmDoc_Chap_StatGeneral As New XR_Page_Chap_StatGeneral(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"), False)
          oRapportFmDoc_Chap_StatGeneral.CreateDocument()
          If oRapportFmDoc_Chap_StatGeneral.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_StatGeneral)
        Case "DetailReport_ChapStatByUrg"
                    Dim oRapportFmDoc_Chap_StatByUrg As New XR_Page_Chap_StatByUrg(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
                    oRapportFmDoc_Chap_StatByUrg.CreateDocument()
                    If oRapportFmDoc_Chap_StatByUrg.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_StatByUrg)
                Case "DetailReport_ChapStatDelaiDepannage"
                    Dim oRapportFmDoc_Chap_StatDelaiDepannage As New XR_Page_Chap_StatDelaiDepannage(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_StatDelaiDepannage.CreateDocument()
          If oRapportFmDoc_Chap_StatDelaiDepannage.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_StatDelaiDepannage)
        Case "DetailReport_ChapStatFactMens"
          Dim oRapportFmDoc_Chap_StatFactMens As New XR_Page_Chap_StatFactMens(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_StatFactMens.CreateDocument()
          If oRapportFmDoc_Chap_StatFactMens.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_StatFactMens)
        Case "DetailReport_ChapStatDevisByContrat"
          Dim oRapportFmDoc_Chap_StatDevisByContrat As New XR_Page_Chap_StatDevisByContrat(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_StatDevisByContrat.CreateDocument()
          If oRapportFmDoc_Chap_StatDevisByContrat.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_StatDevisByContrat)
        Case "DetailReport_ChapStatListeActCreeInMonth"
          Dim oRapportFmDoc_Chap_StatListeActCreeInMonth As New XR_Page_Chap_StatListeActCreeInMonth(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_StatListeActCreeInMonth.CreateDocument()
          If oRapportFmDoc_Chap_StatListeActCreeInMonth.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_StatListeActCreeInMonth)
        Case "DetailReport_ChapStatListeActCreeInMonth_WO_Prev"
          Dim oRapportFmDoc_Chap_StatListeActCreeInMonth As New XR_Page_Chap_StatListeActCreeInMonth(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"), False)
          oRapportFmDoc_Chap_StatListeActCreeInMonth.CreateDocument()
          If oRapportFmDoc_Chap_StatListeActCreeInMonth.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_StatListeActCreeInMonth)
        Case "DetailReport_ChapStatBySecteur_SEMMARIS"
        Case "DetailReport_ChapStatByLot_SEMMARIS"
        Case "DetailReport_ChapStatListeActCreeInMonth_SEMMARIS"

        Case "DetailReport_Chap_ImpayesClient_Liste"
          Dim oRapportFmDoc_Chap_ImpayesClient_Liste As New XR_Page_Chap_ImpayesClient_Liste(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_ImpayesClient_Liste.CreateDocument()
          If oRapportFmDoc_Chap_ImpayesClient_Liste.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_ImpayesClient_Liste)

        Case "DetailReport_Chap_ListeEnqClient"
          Dim oRapportFmDoc_Chap_ListeEnqClient As New XR_Page_Chap_QualEnqQualite(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_ListeEnqClient.CreateDocument()
          If oRapportFmDoc_Chap_ListeEnqClient.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_ListeEnqClient)
        Case "DetailReport_Chap_DepannageSite"
          Dim oRapportFmDoc_Chap_DepannageSite As New XR_Page_Chap_DepannageSite(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_DepannageSite.CreateDocument()
          If oRapportFmDoc_Chap_DepannageSite.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_DepannageSite)
        Case "DetailReport_Chap_StatCO2_On_Period"
          Dim oRapportFmDoc_Chap_StatCO2 As New XR_Page_Chap_Stat_CO2(_oGen_RapportFM, MozartParams.NomServeur, DrChapitre.Item("NORDER"))
          oRapportFmDoc_Chap_StatCO2.CreateDocument()
          If oRapportFmDoc_Chap_StatCO2.Pages.Count > 0 Then AddPagesInRapportFM(oRapportFmDoc, oRapportFmDoc_Chap_StatCO2)

      End Select

      'DrChapitre.Item("NORDER")

    Next

    oRapportFmDoc.PrintingSystem.ContinuousPageNumbering = True

    Dim sPath As String = MozartParams.CheminUtilisateurMozart & "PDF\"

    Select Case _Export
      Case "PDF"
        sFileOut = String.Format("{0}_{1}_{2}{3}{4}_Rapport_fm.PDF", _oGen_RapportFM.NIDRAPPORT_FM_CLI, _oGen_RapportFM.NCLINUM, Now.Year, Now.Month, Now.Day)
      Case "DOCX"
        sFileOut = String.Format("{0}_{1}_{2}{3}{4}_Rapport_fm.DOCX", _oGen_RapportFM.NIDRAPPORT_FM_CLI, _oGen_RapportFM.NCLINUM, Now.Year, Now.Month, Now.Day)
    End Select


    If File.Exists(sPath & sFileOut) = True Then File.Delete(sPath & sFileOut)

    Dim oPdfOptions As PdfExportOptions = oRapportFmDoc.ExportOptions.Pdf

    oPdfOptions.ConvertImagesToJpeg = False
    oPdfOptions.ImageQuality = PdfJpegImageQuality.Highest
    'oPdfOptions.PdfACompatibility = PdfACompatibility.PdfA3b

    'oPdfOptions.DocumentOptions.Author = 

    Select Case _Export
      Case "PDF"
        oRapportFmDoc.ExportToPdf(sPath & sFileOut, oPdfOptions)
      Case "DOCX"
        oRapportFmDoc.ExportToDocx(sPath & sFileOut)
    End Select

    Return sPath & sFileOut

  End Function

  Private Sub AddPagesInRapportFM(ByVal p_ReportMain As XtraReport, ByVal p_Report_ToAdd As XtraReport)

    For Each oPage As DevExpress.XtraPrinting.Page In p_Report_ToAdd.Pages
      p_ReportMain.Pages.Add(oPage)
    Next

  End Sub

  Public Shared Sub AddInGROUPFooter(report As XtraReport, detailReport As XtraReport)

    Dim band As GroupFooterBand = New GroupFooterBand()

    Try
      band.HeightF = 0
      report.Bands().Add(band)

      Dim subreport As New XRSubreport()
      subreport.ReportSource = detailReport
      band.Controls.Add(subreport)

    Catch ex As Exception
      MessageBox.Show("Type de report non valide !", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try

  End Sub

End Class
