Imports DevExpress.XtraCharts
Imports System.Data.SqlClient
Imports MozartLib

Public Class frmTauxConformite

  Private dtStatKMS As New DataTable
  Private ReadOnly strTypeStat As String
  Private Min As Int16 = 100
  Private Max As Int16 = 0

  Public Sub New(ByVal p_Param As String)
    InitializeComponent()

    strTypeStat = p_Param
  End Sub

  Private Sub frmTauxConformite_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    Try

      Cursor.Current = Cursors.WaitCursor

      Select Case strTypeStat
        Case "R"
          dtStatKMS = ModDataGridView.LoadList("api_sp_StatQualTauxConfR", MozartDatabase.cnxMozart)
          lblPerim.Text = My.Resources.Reporting_RH_frmTauxConformite_Rapport & vbCrLf
          LblTitre.Text = My.Resources.Reporting_RH_frmTauxConformite_Taux
          lblObj.Text = My.Resources.Reporting_RH_frmTauxConformite_Objectif_1
          With CType(ChartBas.Diagram, XYDiagram)
            .AxisY.WholeRange.Auto = False
            .AxisY.WholeRange.SideMarginsValue = 0
            .AxisY.WholeRange.SetMinMaxValues(0, 2)
            .AxisY.Label.TextPattern = "{V:N1}"
          End With

          ' moyenne sur les 12 derniers mois
          lblMoy12.Text = String.Format("{0}{1}{2} %", lblMoy12.Text, vbCrLf, FormatNumber(CalculMoyenne12(), 1))
          Dim ConstHaut As XYDiagram = ChartBas.Diagram
          ConstHaut.AxisY.ConstantLines(0).AxisValue = 0.5
          ConstHaut.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_objectif

        Case "C"
          dtStatKMS = ModDataGridView.LoadList("api_sp_StatQualTauxConfC", MozartDatabase.cnxMozart)
          lblPerim.Text = My.Resources.Reporting_RH_frmTauxConformite_Rapport_achat & vbCrLf
          LblTitre.Text = My.Resources.Reporting_RH_frmTauxConformite_tauxACH
          lblObj.Text = My.Resources.Reporting_RH_frmTauxConformite_Objectif_1
          With CType(ChartBas.Diagram, XYDiagram)
            .AxisY.WholeRange.Auto = False
            .AxisY.WholeRange.SideMarginsValue = 0
            .AxisY.WholeRange.SetMinMaxValues(0, 2)
            .AxisY.Label.TextPattern = "{V:N1}"
          End With

          ' moyenne sur les 12 derniers mois
          lblMoy12.Text = String.Format("{0}{1}{2} %", lblMoy12.Text, vbCrLf, FormatNumber(CalculMoyenne12(), 1))
          Dim ConstHaut As XYDiagram = ChartBas.Diagram
          ConstHaut.AxisY.ConstantLines(0).AxisValue = 0.5
          ConstHaut.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_objectif

        Case "M"
          dtStatKMS = ModDataGridView.LoadList("api_sp_StatQualTauxConfM", MozartDatabase.cnxMozart)
          lblPerim.Text = "Taux de conformité Magasin" & vbCrLf
          LblTitre.Text = "Taux de conformité Magasin"
          lblObj.Text = My.Resources.Reporting_RH_frmTauxConformite_Objectif_1
          With CType(ChartBas.Diagram, XYDiagram)
            .AxisY.WholeRange.Auto = False
            .AxisY.WholeRange.SideMarginsValue = 0
            .AxisY.WholeRange.SetMinMaxValues(0, 2)
            .AxisY.Label.TextPattern = "{V:N1}"
          End With

          ' moyenne sur les 12 derniers mois
          lblMoy12.Text = String.Format("{0}{1}{2} %", lblMoy12.Text, vbCrLf, FormatNumber(CalculMoyenne12(), 1))
          Dim ConstHaut As XYDiagram = ChartBas.Diagram
          ConstHaut.AxisY.ConstantLines(0).AxisValue = 0.5
          ConstHaut.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_objectif

        Case "G"
          dtStatKMS = ModDataGridView.LoadList("api_sp_StatQualTauxConfG", MozartDatabase.cnxMozart)
          lblPerim.Text = My.Resources.Reporting_RH_frmTauxConformite_Rapport_gestion & vbCrLf
          LblTitre.Text = My.Resources.Reporting_RH_frmTauxConformite_Taux_GMPT
          lblObj.Text = My.Resources.Reporting_RH_frmTauxConformite_Objectif_1
          With CType(ChartBas.Diagram, XYDiagram)
            .AxisY.WholeRange.Auto = False
            .AxisY.WholeRange.SideMarginsValue = 0
            .AxisY.WholeRange.SetMinMaxValues(0, 1.5)
            .AxisY.Label.TextPattern = "{V:N1}"
          End With

          ' moyenne sur les 12 derniers mois
          lblMoy12.Text = String.Format("{0}{1}{2} %", lblMoy12.Text, vbCrLf, FormatNumber(CalculMoyenne12(), 2))
          Dim ConstHaut As XYDiagram = ChartBas.Diagram
          ConstHaut.AxisY.ConstantLines(0).AxisValue = 0.5
          ConstHaut.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_objectif

        Case "D"
          dtStatKMS = ModDataGridView.LoadList("api_sp_StatQualTauxDevis", MozartDatabase.cnxMozart)
          lblPerim.Text = My.Resources.Reporting_RH_frmTauxConformite_Rapport_devis & vbCrLf
          LblTitre.Text = My.Resources.Reporting_RH_frmTauxConformite_Taux_devis
          lblObj.Text = My.Resources.Reporting_RH_frmTauxConformite_Objectif55
          With CType(ChartBas.Diagram, XYDiagram)
            .AxisY.WholeRange.Auto = False
            .AxisY.WholeRange.SideMarginsValue = 0
            .AxisY.WholeRange.SetMinMaxValues(5, 80)
          End With

          ' moyenne sur les 12 derniers mois
          lblMoy12.Text = String.Format("{0}{1}{2} %", lblMoy12.Text, vbCrLf, FormatNumber(CalculMoyenne12(), 1))
          Dim ConstHaut As XYDiagram = ChartBas.Diagram
          ConstHaut.AxisY.ConstantLines(0).AxisValue = 70
          ConstHaut.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_objectif

        Case "A"
          Dim dtPer As New DataTable
          Dim dsPer As SqlDataAdapter = New SqlDataAdapter("SELECT 0 NPERNUM, '' VPERNOM UNION SELECT NPERNUM, VPERNOM + ' ' + VPERPRE 
                        FROM TPER WHERE CPERTYP in ('CA') AND CPERACTIF = 'O' AND BUTILISATEUR=0 AND VSOCIETE = '" & MozartParams.NomSociete & "' ORDER BY VPERNOM", MozartDatabase.cnxMozart)

          CboTech.Items.Clear()
          dsPer.Fill(dtPer)
          CboTech.DataSource = dtPer

          Dim dtPerCrea As New DataTable
          Dim dsPerCrea As SqlDataAdapter = New SqlDataAdapter("SELECT 0 NPERNUM, '' VPERNOM UNION SELECT NPERNUM, VPERNOM + ' ' + VPERPRE 
                        FROM TPER WHERE CPERTYP <>'TE' AND CPERACTIF = 'O' AND BUTILISATEUR=0 AND VSOCIETE = '" & MozartParams.NomSociete & "' ORDER BY VPERNOM", MozartDatabase.cnxMozart)

          cboCreateur.Items.Clear()
          dsPerCrea.Fill(dtPerCrea)
          cboCreateur.DataSource = dtPerCrea

          GroupBoxChaff.Visible = True
          GroupBoxCreateur.Visible = True

          lblPerim.Text = "Rapport entre le nombre de DI avec devis client ayant une date de commande Et le nombre total de DI avec devis client sur 36 mois glissants"
          LblTitre.Text = My.Resources.Reporting_RH_frmTauxConformite_Taux_devis
          lblObj.Text = My.Resources.Reporting_RH_frmTauxConformite_Objectif55

          cmdValider_Click(Nothing, Nothing)

          ' moyenne sur les 12 derniers mois
          lblMoy12.Text = $"Moyenne sur la période{vbCrLf}{FormatNumber(CalculMoyenne12(), 1)} %"
          Dim ConstHaut As XYDiagram = ChartBas.Diagram
          ConstHaut.AxisY.ConstantLines(0).AxisValue = 70
          ConstHaut.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_objectif

        Case "F"
          dtStatKMS = ModDataGridView.LoadList("api_sp_StatQualFacturation", MozartDatabase.cnxMozart)
          lblPerim.Text = My.Resources.Reporting_RH_frmTauxConformite_nbr_intervention & vbCrLf
          LblTitre.Text = My.Resources.Reporting_RH_frmTauxConformite_nbr_interv
          lblObj.Visible = False
          GVStat.Columns(1).Caption = My.Resources.Global_valeur
          With CType(ChartBas.Diagram, XYDiagram)
            .AxisY.VisualRange.Auto = True
            .AxisY.WholeRange.Auto = False
            .AxisY.WholeRange.SideMarginsValue = 0
            .AxisY.WholeRange.SetMinMaxValues(0, 15000)
            .AxisY.Title.Text = ""
          End With

          ' moyenne sur les 12 derniers mois
          lblMoy12.Text = lblMoy12.Text & vbCrLf & FormatNumber(CalculMoyenne12(), 0)
          Dim ConstHaut As XYDiagram = ChartBas.Diagram
          ConstHaut.AxisY.ConstantLines(0).AxisValue = FormatNumber(CalculMoyenne12(), 0)
          ConstHaut.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_moyenne

        Case "T"
          dtStatKMS = ModDataGridView.LoadList("api_sp_StatQualTauxSTT", MozartDatabase.cnxMozart)
          lblPerim.Text = My.Resources.Reporting_RH_frmTauxConformite_Rapport_Emalec.Replace("#gstrNomGroupe#", MozartParams.NomGroupe) & vbCrLf
          LblTitre.Text = My.Resources.Reporting_RH_frmTauxConformite_Taux_ss_trait
          lblObj.Text = My.Resources.Reporting_RH_frmTauxConformite_Objectif_30

          With CType(ChartBas.Diagram, XYDiagram)
            .AxisY.VisualRange.Auto = True
            .AxisY.WholeRange.Auto = False
            .AxisY.WholeRange.SideMarginsValue = 0
            .AxisY.WholeRange.SetMinMaxValues(0, 40)
            .AxisY.Title.Text = ""
          End With

          ' moyenne sur les 12 derniers mois
          lblMoy12.Text = lblMoy12.Text & vbCrLf & FormatNumber(CalculMoyenne12(), 0)
          Dim ConstHaut As XYDiagram = ChartBas.Diagram
          ConstHaut.AxisY.ConstantLines(0).AxisValue = 30
          ConstHaut.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_objectif

        Case "P" ' Ajout du 28/12/2015
          dtStatKMS = ModDataGridView.LoadList("api_sp_StatQualTauxPreparationDevis", MozartDatabase.cnxMozart)
          lblPerim.Text = My.Resources.Reporting_RH_frmTauxConformite_dif & vbCrLf
          LblTitre.Text = My.Resources.Reporting_RH_frmTauxConformite_delai
          lblObj.Text = My.Resources.Reporting_RH_frmTauxConformite_Objectif_70
          With CType(ChartBas.Diagram, XYDiagram)
            .AxisY.WholeRange.Auto = False
            .AxisY.WholeRange.SideMarginsValue = 0
            .AxisY.WholeRange.SetMinMaxValues(50, 100)
          End With

          ' moyenne sur les 12 derniers mois
          lblMoy12.Text = String.Format("{0}{1}{2} %", lblMoy12.Text, vbCrLf, FormatNumber(CalculMoyenne12(), 1))
          Dim ConstHaut As XYDiagram = ChartBas.Diagram
          ConstHaut.AxisY.ConstantLines(0).AxisValue = 80
          ConstHaut.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_objectif

        Case "D_POSTE"
          dtStatKMS = ModDataGridView.LoadList("[api_sp_StatQualTauxDevis_Poste]", MozartDatabase.cnxMozart)
          lblPerim.Text = "Rapport entre le nombre d'actions des techniciens postés avec devis client exécutées et le nombre total de devis client en Gestion MPT sur 36 mois glissants (les 3 derniers mois en cours ne sont pas pris en compte)" 'My.Resources.Reporting_RH_frmTauxConformite_Rapport_devis & vbCrLf
          LblTitre.Text = "Taux de transformation des devis des techniciens postés (hors devis en régul. et action en Devis en attente budget(B))" 'My.Resources.Reporting_RH_frmTauxConformite_Taux_devis
          lblObj.Text = My.Resources.Reporting_RH_frmTauxConformite_Objectif55
          With CType(ChartBas.Diagram, XYDiagram)
            .AxisY.WholeRange.Auto = False
            .AxisY.WholeRange.SideMarginsValue = 0
            .AxisY.WholeRange.SetMinMaxValues(5, 80)
          End With

          ' moyenne sur les 12 derniers mois
          lblMoy12.Text = String.Format("{0}{1}{2} %", lblMoy12.Text, vbCrLf, FormatNumber(CalculMoyenne12(), 1))
          Dim ConstHaut As XYDiagram = ChartBas.Diagram
          ConstHaut.AxisY.ConstantLines(0).AxisValue = 55
          ConstHaut.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_objectif

        Case "P_POSTE" ' Ajout du 12/10/2021
          dtStatKMS = ModDataGridView.LoadList("[api_sp_StatQualTauxPreparationDevis_Poste]", MozartDatabase.cnxMozart)
          lblPerim.Text = "Différence entre la date de création du devis client et la date de création de l'action < 5 jours sur 36 mois glissants pour les techniciens postés (on exclue les devis web techniciens)" 'My.Resources.Reporting_RH_frmTauxConformite_dif & vbCrLf
          LblTitre.Text = "Délai de préparation des devis clients pour les techniciens postés (on exclue les devis web techniciens)" 'My.Resources.Reporting_RH_frmTauxConformite_delai
          lblObj.Text = My.Resources.Reporting_RH_frmTauxConformite_Objectif_70
          With CType(ChartBas.Diagram, XYDiagram)
            .AxisY.WholeRange.Auto = False
            .AxisY.WholeRange.SideMarginsValue = 0
            .AxisY.WholeRange.SetMinMaxValues(50, 100)
          End With

          ' moyenne sur la période
          lblMoy12.Text = String.Format("{0}{1}{2} %", lblMoy12.Text, vbCrLf, FormatNumber(CalculMoyenne12(), 1))
          Dim ConstHaut As XYDiagram = ChartBas.Diagram
          ConstHaut.AxisY.ConstantLines(0).AxisValue = 70
          ConstHaut.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_objectif

        Case Else
          Exit Select
      End Select

      GCStat.DataSource = dtStatKMS
      ChartBas.DataSource = dtStatKMS

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RH_frmTauxConformite_sub + ex.Message, My.Resources.Global_Erreur)
    Finally
      Cursor.Current = Cursors.Default
    End Try
  End Sub


  Private Sub BtnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)

    oScreenShot.Print_Form()
  End Sub

  Private Sub GVStat_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVStat.CustomColumnDisplayText
    If e.Column.FieldName = "LIB" Then
      Dim year As String = e.Value.ToString.Substring(0, 4)
      Dim month As String = MonthName(e.Value.ToString.Substring(5, 2), True)
      e.DisplayText = String.Format("{0} {1}", month, year)
    End If
  End Sub

  Private Function CalculMoyenne12() As Decimal

    CalculMoyenne12 = 0

    Dim dtCopy As DataTable = dtStatKMS.Copy

    For Each drCopy As DataRow In dtCopy.Rows
      CalculMoyenne12 += drCopy.Item(0)
      If drCopy.Item(0) > Max Then Max = drCopy.Item(0)
      If drCopy.Item(0) < Min Then Min = drCopy.Item(0)
    Next

    Return If(dtCopy.Rows.Count = 0, 0, CalculMoyenne12 / dtCopy.Rows.Count)
  End Function

  Private Sub ChartBas_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles ChartBas.ObjectSelected

    ' Détails
    Select Case strTypeStat
      Case "R"
        Dim hitInfo As ChartHitInfo = e.HitInfo
        If hitInfo.SeriesPoint IsNot Nothing Then
          Dim oFrmDetailStat As New frmStatTauxConformiteDetails(hitInfo.SeriesPoint.Tag.Row.ItemArray, My.Resources.Reporting_RH_frmTauxConformite_tauxRMPT, "R")
          oFrmDetailStat.ShowDialog()
          oFrmDetailStat.Dispose()

        End If
      Case "G"
        Dim hitInfo As ChartHitInfo = e.HitInfo
        If hitInfo.SeriesPoint IsNot Nothing Then
          Dim oFrmDetailStat As New frmStatTauxConformiteDetails(hitInfo.SeriesPoint.Tag.Row.ItemArray, My.Resources.Reporting_RH_frmTauxConformite_tauxGMPT, "G")
          oFrmDetailStat.ShowDialog()
          oFrmDetailStat.Dispose()
        End If
      Case "C"
        Dim hitInfo As ChartHitInfo = e.HitInfo
        If hitInfo.SeriesPoint IsNot Nothing Then
          Dim oFrmDetailStat As New frmStatTauxConformiteDetails(hitInfo.SeriesPoint.Tag.Row.ItemArray, My.Resources.Reporting_RH_frmTauxConformite_tauxACH, "C")
          oFrmDetailStat.ShowDialog()
          oFrmDetailStat.Dispose()
        End If

      Case "M"
        Dim hitInfo As ChartHitInfo = e.HitInfo
        If hitInfo.SeriesPoint IsNot Nothing Then
          Dim oFrmDetailStat As New frmStatTauxConformiteDetails(hitInfo.SeriesPoint.Tag.Row.ItemArray, "Taux de conformité Magasin", "M")
          oFrmDetailStat.ShowDialog()
          oFrmDetailStat.Dispose()
        End If
      Case Else
        Exit Select
    End Select
  End Sub


  Private Sub cmdValider_Click(sender As Object, e As EventArgs) Handles cmdValider.Click
    fill($"api_sp_StatQualTauxDevisTravaux {CboTech.SelectedValue}")
  End Sub

  Private Sub cmdValidByCreateur_Click(sender As Object, e As EventArgs) Handles cmdValidByCreateur.Click
    ' execution de la requête sur le créateur choisi
    fill($"api_sp_StatQualTauxDevisTravauxByCreateur {cboCreateur.SelectedValue}")
  End Sub

  Private Sub fill(sQuery As String)
    Try
      dtStatKMS = ModDataGridView.LoadList(sQuery, MozartDatabase.cnxMozart)

      ' moyenne sur la période
      lblMoy12.Text = String.Format("{0}{1}{2} %", "Moyenne sur la période", vbCrLf, FormatNumber(CalculMoyenne12(), 1))

      ' tracer l'échelle des Y
      With CType(ChartBas.Diagram, XYDiagram)
        .AxisY.WholeRange.Auto = False
        .AxisY.WholeRange.SideMarginsValue = 0
        .AxisY.WholeRange.SetMinMaxValues(Min, Max)
      End With

      'réinitialisation des variables
      Min = 100
      Max = 0

      GCStat.DataSource = dtStatKMS
      ChartBas.DataSource = dtStatKMS
    Catch ex As Exception
      MessageBox.Show("Il n'y a pas de données.", "Information", MessageBoxButtons.OK)
    End Try
  End Sub

End Class
