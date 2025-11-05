Imports System.Data.SqlClient
Imports System.Reflection
Imports DevExpress.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.BandedGrid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports MozartControls
Imports MozartLib
Imports MZUtils = MozartControls.Utils

Public Class FrmSynthComptaV2

  Dim TotAjust As Int32
  Dim TotCA As Int32
  Dim TotCharge As Int32
  Dim TotCA_Cumul_Mois As Int32
  Dim TotResulatANA_Cumul_Mois As Int32
  Dim TotCA_GestProjet As Int32
  Dim TotResultAna_GestProjet As Int32

  Dim TotCA_OBJ As Int32
  Dim TotOBJRESULTANA_MTT As Int32

  Dim Tot_Indic_Direct_CA As Int32
  Dim Tot_Indic_Direct_MBE As Int32
  Dim Tot_Indic_Direct_REX As Int32
  Dim Tot_Indic_Direct_CABUDGET As Int32
  Dim Tot_Indic_Direct_ResultatAna_avec_PC As Int32
  Dim Tot_Indic_Direct_ResultatAna_BUDGET_MTT As Int32
  Dim Tot_Indic_Direct_ResultatAna_Dep_ST As Int32
  Dim Tot_Indic_Direct_ResultatAna_Dep_Achat As Int32
  Dim Tot_Indic_Direct_ResultatAna_Dep_HR_Chantier As Int32
  Dim Tot_Indic_Direct_ResultatAna_Dep_DepKMS As Int32


  Dim Tot_Bilan_FG_ResultatAna As Int32
  Dim Tot_Bilan_FG_CA As Int32
  Dim Tot_Bilan_FG_Dep_reel As Int32

  Dim dtSynthCompta As DataTable
  Dim dtSynthIndic_Direct As DataTable
  Dim dtNCANNUMDoublon As DataTable
  Dim dtBalanceAna As DataTable
  Dim dtAnaREX As DataTable

  Dim sCOEFF_FRAIS_GENERAUX As String
  Dim nCOEFF_FRAIS_GENERAUX As Decimal

  Private mMoisNum As Integer
  Private mAnneeNum As Integer

  Private Sub FrmSynthCompta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      mAnneeNum = 999999
      mMoisNum = 999999

      Dim DateMaxANAHISTO As Nullable(Of DateTime)

      'init boutons
      Initboutons(Me)

      TotAjust = 0
      TotCA = 0
      TotCharge = 0

      GBBALDEP.Caption = "Dépenses réelles" & vbCrLf & "(hors cessions internes ana)"

            'on rempli les combo mois et année
            CboMois.DisplayMember = "VALUE"
      CboMois.ValueMember = "ID"

      CboAnnee.ValueMember = "ID"
      CboAnnee.DisplayMember = "VALUE"

      CboMois.DataSource = MozartDatabase.GetDataTable($"EXEC [api_sp_Reporting_Analytique_ListeMoisByAnnee] 0, '{MozartParams.NomSociete}'")

      CboAnnee.DataSource = MozartDatabase.GetDataTable($"EXEC [api_sp_Reporting_Analytique_ListeAnneeByMois] 0, '{MozartParams.NomSociete}'")

      'sélection automatique de la date max
      Dim sqlcmdauto As New SqlCommand("EXEC api_sp_Reporting_Analytique_GetLastDateReporting '" + MozartParams.NomSociete + "'", MozartDatabase.cnxMozart)
      Dim drauto As SqlDataReader = sqlcmdauto.ExecuteReader
      If drauto.HasRows Then
        drauto.Read()
        DateMaxANAHISTO = Convert.ToDateTime(drauto("DDATEMAX"))
      End If
      drauto.Close()

      If Not IsDBNull(DateMaxANAHISTO) Then

        mMoisNum = DatePart(DateInterval.Month, CType(DateMaxANAHISTO, DateTime))
        mAnneeNum = DatePart(DateInterval.Year, CType(DateMaxANAHISTO, DateTime))

        CboMois.SelectedValue = mMoisNum
        CboAnnee.SelectedValue = mAnneeNum

        LoadDatas(sender)

        LoadReportingVisible()

                If GetMaxDate(mMoisNum, mAnneeNum) = "" Then
                    LblDateLastMAJ.Visible = False
                Else
                    LblDateLastMAJ.Text = $"Date de la dernière mise à jour : {GetMaxDate(mMoisNum, mAnneeNum)}"
                End If

            End If

      AddHandler CboMois.SelectedIndexChanged, AddressOf CboMois_SelectedIndexChanged
      AddHandler CboAnnee.SelectedIndexChanged, AddressOf CboAnnee_SelectedIndexChanged

      'gestion de l affichage selon le droit chef de groupe
      If RechercheDroitMenu(625) Then

        'on renomme l'onglet
        XTPBilanCpt.Text = "Bilan par compte du chef de groupe"

        'pour les chef de groupe on cahce automatiquement les autres onglets
        XTPBalanceAna.PageVisible = False
        XTPREX.PageVisible = False
        XTP_Ind_Direct.PageVisible = False

      End If

      initColors()



        Catch ex As Exception

      MessageBox.Show(My.Resources.TabSyntheseCompta_frmSynthCompta_sub + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

    Private Function GetMaxDate(ByVal p_mois As Int16, ByVal p_annee As Int16) As String

        Return MozartDatabase.ExecuteScalarString("EXEC [api_sp_AnaHisto_GetLastDateLog] " & p_mois & ", " & p_annee)

    End Function
    Private Sub initColors()
    BGC_NOBJCA.AppearanceCell.BackColor = Color.Bisque
    BGC_NOBJCA_PC.AppearanceCell.BackColor = Color.Bisque
    BGC_NOBJRESULTANA_PC.AppearanceCell.BackColor = Color.Bisque
    BGC_NOBJRESULTATANA_DIFF.AppearanceCell.BackColor = Color.Bisque
  End Sub

  Private Sub LoadReportingVisible()

    'il faut sélectionner un mois et année
    If CboMois.SelectedValue Is Nothing OrElse CboMois.SelectedValue = 0 Then
      'MessageBox.Show("Il faut sélectionner un mois", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      ChkNotVisibleLastReport.Visible = False
      Return
    End If
    If CboAnnee.SelectedValue Is Nothing OrElse CboAnnee.SelectedValue = 999999 Then
      'MessageBox.Show("Il faut sélectionner une année", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      ChkNotVisibleLastReport.Visible = False
      Return
    End If

    'on affiche la case à cocher si on a les droits
    If RechercheDroitMenu(ChkNotVisibleLastReport.HelpContextID) Then

      ChkNotVisibleLastReport.Visible = True

    ElseIf RechercheDroitMenu(713) Then

      ChkNotVisibleLastReport.Visible = True
      ChkNotVisibleLastReport.Enabled = False

    End If

    'load data checkbox
    Dim sqlcmdChx As New SqlCommand("[api_sp_Reporting_Analytique_GetVisible]", MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.StoredProcedure
    }
    sqlcmdChx.Parameters.Add("@p_mois", SqlDbType.Int).Value = CboMois.SelectedValue
    sqlcmdChx.Parameters.Add("@p_annee", SqlDbType.Int).Value = CboAnnee.SelectedValue
    sqlcmdChx.Parameters.Add("@p_vsociete", SqlDbType.VarChar).Value = MozartParams.NomSociete
    Dim sqldrchx As SqlDataReader = sqlcmdChx.ExecuteReader
    If sqldrchx.HasRows Then

      sqldrchx.Read()
      If sqldrchx.Item("BANAHISTO_VISIBLE_ALL") = 0 Then
        ChkNotVisibleLastReport.CheckState = CheckState.Checked
      Else
        ChkNotVisibleLastReport.CheckState = CheckState.Unchecked
      End If

    Else
      ChkNotVisibleLastReport.CheckState = CheckState.Unchecked

    End If
    sqldrchx.Close()

  End Sub

  Private Sub LoadData(ByVal pFiltreSurChaff As Boolean)
    'initialise les champs ##
    GBMOISPREC.Caption = "RAPPEL #MOIS#/#ANNEE#"
    GBANNEEPREC.Caption = "RAPPEL #ANNEE#"
    GBBALANNEEPREC.Caption = "RAPPEL #ANNEE#"

    GBand_OBJ.Caption = $"OBJECTIF {mAnneeNum}"
    GBand_Obj_ResultAna.Caption = GBand_OBJ.Caption

    'titre et label
    Dim sDatePrec As Date = DateAdd(DateInterval.Month, -1, New DateTime(mAnneeNum, mMoisNum, 1))

    GBANNEEPREC.Caption = GBANNEEPREC.Caption.Replace("#ANNEE#", (mAnneeNum - 1).ToString)
    GBBALANNEEPREC.Caption = GBBALANNEEPREC.Caption.Replace("#ANNEE#", (mAnneeNum - 1).ToString)
    GBMOISPREC.Caption = GBMOISPREC.Caption.Replace("#MOIS#", DatePart(DateInterval.Month, sDatePrec).ToString).Replace("#ANNEE#", DatePart(DateInterval.Year, sDatePrec).ToString)

    'data tableau
    dtNCANNUMDoublon = New DataTable

    If mAnneeNum >= 2018 Then

      'If p_INIT_T1 Then
      '  dtSynthCompta = MozartDatabase.GetDataTable($"api_sp_TableauSynthComptaSamsicV2 {mMoisNum}, {mAnneeNum}, '{MozartParams.NomSociete}', 1")
      'Else
      'End If 
      If pFiltreSurChaff Then
        Dim lTmpDatatable As DataTable = MozartDatabase.GetDataTable($"api_sp_TableauSynthComptaSamsicV2 {mMoisNum}, {mAnneeNum}, '{MozartParams.NomSociete}'")
        Try
          dtSynthCompta = (From lTmp In lTmpDatatable.AsEnumerable() Where lTmp.Field(Of Integer?)("NCHAFFNUM") = MozartParams.UID Select lTmp).CopyToDataTable()
        Catch ex As Exception
        End Try
      Else
        dtSynthCompta = MozartDatabase.GetDataTable($"api_sp_TableauSynthComptaSamsicV2 {mMoisNum}, {mAnneeNum}, '{MozartParams.NomSociete}'")
      End If

      dtBalanceAna = MozartDatabase.GetDataTable($"api_sp_TableauSynthComptaBalanceSamsicV2 {mMoisNum}, {mAnneeNum}, '{MozartParams.NomSociete}'")

    Else

      dtSynthCompta = MozartDatabase.GetDataTable($"api_sp_TableauSynthCompta {mMoisNum}, {mAnneeNum}, '{MozartParams.NomSociete}'")
      dtBalanceAna = MozartDatabase.GetDataTable($"api_sp_TableauSynthComptaBalance {mMoisNum}, {mAnneeNum}, '{MozartParams.NomSociete}'")

    End If

    'nom colonne 6/7 eme
    BandedGridColumn11.Caption = mMoisNum & "/" & New DateTime(mAnneeNum, mMoisNum, 1).AddMonths(-1).Month.ToString & "ème"

    dtSynthIndic_Direct = MozartDatabase.GetDataTable($"api_sp_TableauSynthComptaSamsic_IndicDirect_V2 {mMoisNum}, {mAnneeNum}, '{MozartParams.NomSociete}'")

    Dim sqlcmdGetCoeff As New SqlCommand("[api_sp_ReportingAnalytique_GetCoefFraisGeneraux]", MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.StoredProcedure
    }
    sqlcmdGetCoeff.Parameters.Add("@VSOCIETE", SqlDbType.VarChar).Value = MozartParams.NomSociete
    sqlcmdGetCoeff.Parameters.Add("@MOIS", SqlDbType.Int).Value = mMoisNum
    sqlcmdGetCoeff.Parameters.Add("@ANNEE", SqlDbType.Int).Value = mAnneeNum
    Dim sqldr As SqlDataReader = sqlcmdGetCoeff.ExecuteReader

    If sqldr.HasRows Then

      sqldr.Read()
      sCOEFF_FRAIS_GENERAUX = sqldr.Item("VCOEFF_LISTE")

    End If
    sqldr.Close()

    'load taux fg réel
    sqlcmdGetCoeff = New SqlCommand("[api_sp_ReportingAnalytique_GetTauxFG_Reel]", MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.StoredProcedure
    }
    sqlcmdGetCoeff.Parameters.Add("@VSOCIETE", SqlDbType.VarChar).Value = MozartParams.NomSociete
    sqlcmdGetCoeff.Parameters.Add("@p_moisnum", SqlDbType.Int).Value = mMoisNum
    sqlcmdGetCoeff.Parameters.Add("@p_anneenum", SqlDbType.Int).Value = mAnneeNum
    sqldr = sqlcmdGetCoeff.ExecuteReader
    'Init
    BandedGridColumn19.Caption = "Répart. FG Réels ()"

    If sqldr.HasRows Then

      sqldr.Read()
      nCOEFF_FRAIS_GENERAUX = sqldr.Item("TAUX_FG")


    End If
    sqldr.Close()

    BandedGridColumn19.Caption = String.Format("Répart. FG Réels ({0:p1})", nCOEFF_FRAIS_GENERAUX)

    'affichage du taux dans les colonnes
    BGCMois_1_EC_NRESULTANA_MOIS_EC.Caption = String.Format("Résultat ana (avec {0:n0} %)", sCOEFF_FRAIS_GENERAUX)
    BGCProjet_NPROJET_NPROJET_RESULTANA.Caption = String.Format("Résultat ana (avec {0:n0} %)", sCOEFF_FRAIS_GENERAUX)
    BGCOD.Caption = String.Format("{0:n0} % Fgx", sCOEFF_FRAIS_GENERAUX)
    BGCResultAjust.Caption = String.Format("Résultat ana (avec {0:n0} %)", sCOEFF_FRAIS_GENERAUX)
    GBandResultatAna.Caption = String.Format("Résultat ana (avec {0:n0} %)", sCOEFF_FRAIS_GENERAUX)
    BGCol_T4_RESULTAJUST.Caption = String.Format("Résultat ana (avec {0:n0} %)", sCOEFF_FRAIS_GENERAUX)

    BGCCAMONTHLASTYEAR.Caption = String.Format("CA N-1 (à fin {0}/{1})", mMoisNum, mAnneeNum - 1)

    dtNCANNUMDoublon = ReturnDTDoublonsChaffOnCAN()

    GCSynthCompta.DataSource = dtSynthCompta
    GCIndic_Direct.DataSource = dtSynthIndic_Direct
    GCBalanceAna.DataSource = dtBalanceAna

    LoadDataAnaREX()

    'permet de dérouler seulement les comptes actifs
    If AdvBGVBilanAna.IsValidRowHandle(-2) Then
      AdvBGVBilanAna.ExpandGroupRow(-2)
    Else
      If AdvBGVBilanAna.IsValidRowHandle(-1) Then
        AdvBGVBilanAna.ExpandGroupRow(-1)
      End If
    End If

    'permet de dérouler seulement les comptes actifs
    If AdvBGVBilanAnaSoc.IsValidRowHandle(-2) Then
      AdvBGVBilanAnaSoc.ExpandGroupRow(-2)
    Else
      If AdvBGVBilanAnaSoc.IsValidRowHandle(-1) Then
        AdvBGVBilanAnaSoc.ExpandGroupRow(-1)
      End If
    End If

    'permet de dérouler seulement les comptes actifs
    If ABGV_Indic_Direct.IsValidRowHandle(-2) Then
      ABGV_Indic_Direct.ExpandGroupRow(-2)
    Else
      If ABGV_Indic_Direct.IsValidRowHandle(-1) Then
        ABGV_Indic_Direct.ExpandGroupRow(-1)
      End If
    End If

  End Sub

  Private Sub LoadDataByChefGroupe()
    'initialise les champs ##
    GBMOISPREC.Caption = "RAPPEL #MOIS#/#ANNEE#"
    GBANNEEPREC.Caption = "RAPPEL #ANNEE#"
    GBBALANNEEPREC.Caption = "RAPPEL #ANNEE#"

    'titre et label
    Dim sDatePrec As Date = DateAdd(DateInterval.Month, -1, New DateTime(mAnneeNum, mMoisNum, 1))

    GBANNEEPREC.Caption = GBANNEEPREC.Caption.Replace("#ANNEE#", (mAnneeNum - 1).ToString)
    GBBALANNEEPREC.Caption = GBBALANNEEPREC.Caption.Replace("#ANNEE#", (mAnneeNum - 1).ToString)
    GBMOISPREC.Caption = GBMOISPREC.Caption.Replace("#MOIS#", DatePart(DateInterval.Month, sDatePrec).ToString).Replace("#ANNEE#", DatePart(DateInterval.Year, sDatePrec).ToString)

    'data tableau
    dtSynthCompta = New DataTable
    dtNCANNUMDoublon = New DataTable

    If mAnneeNum >= 2018 Then
      dtSynthCompta = MozartDatabase.GetDataTable($"api_sp_TableauSynthComptaSamsicByChefGroupe {mMoisNum}, {mAnneeNum}, '{MozartParams.NomSociete}'")
    Else
      dtSynthCompta = MozartDatabase.GetDataTable($"api_sp_TableauSynthComptaByChefGroupe {mMoisNum}, {mAnneeNum}, '{MozartParams.NomSociete}'")
    End If

    dtNCANNUMDoublon = ReturnDTDoublonsChaffOnCAN()

    GCSynthCompta.DataSource = dtSynthCompta

    'permet de dérouler seulement les comptes actifs
    If AdvBGVBilanAna.IsValidRowHandle(-2) Then
      AdvBGVBilanAna.ExpandGroupRow(-2)
    Else
      If AdvBGVBilanAna.IsValidRowHandle(-1) Then
        AdvBGVBilanAna.ExpandGroupRow(-1)
      End If
    End If

    'permet de dérouler seulement les comptes actifs
    If AdvBGVBilanAnaSoc.IsValidRowHandle(-2) Then
      AdvBGVBilanAnaSoc.ExpandGroupRow(-2)
    Else
      If AdvBGVBilanAnaSoc.IsValidRowHandle(-1) Then
        AdvBGVBilanAnaSoc.ExpandGroupRow(-1)
      End If
    End If

    'load taux fg réel
    Dim sqlcmdGetCoeff As New SqlCommand("[api_sp_ReportingAnalytique_GetCoefFraisGeneraux]", MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.StoredProcedure
    }
    sqlcmdGetCoeff.Parameters.Add("@VSOCIETE", SqlDbType.VarChar).Value = MozartParams.NomSociete
    sqlcmdGetCoeff.Parameters.Add("@MOIS", SqlDbType.Int).Value = mMoisNum
    sqlcmdGetCoeff.Parameters.Add("@ANNEE", SqlDbType.Int).Value = mAnneeNum
    Dim sqldr As SqlDataReader = sqlcmdGetCoeff.ExecuteReader

    If sqldr.HasRows Then

      sqldr.Read()
      sCOEFF_FRAIS_GENERAUX = sqldr.Item("VCOEFF_LISTE")

    End If
    sqldr.Close()

    'affichage du taux dans les colonnes
    BGCMois_1_EC_NRESULTANA_MOIS_EC.Caption = String.Format("Résultat ana (avec {0:n0} %)", sCOEFF_FRAIS_GENERAUX)
    BGCProjet_NPROJET_NPROJET_RESULTANA.Caption = String.Format("Résultat ana (avec {0:n0} %)", sCOEFF_FRAIS_GENERAUX)
    BGCOD.Caption = String.Format("{0:n0} % Fgx", sCOEFF_FRAIS_GENERAUX)
    BGCResultAjust.Caption = String.Format("Résultat ana (avec {0:n0} %)", sCOEFF_FRAIS_GENERAUX)

  End Sub

  Private Sub AdvBGVBilanAna_CustomColumnDisplayText(sender As Object, e As CustomColumnDisplayTextEventArgs) Handles AdvBGVBilanAna.CustomColumnDisplayText

    If e.Column.FieldName = "DPVRECEPT" Then

      If AdvBGVBilanAna.GetListSourceRowCellValue(e.ListSourceRowIndex, BGCCTYPECTE) = "T" Then

        If IsDBNull(e.Value) Then
          e.DisplayText = "NON"
        End If

      Else

        e.DisplayText = ""

      End If

    End If

  End Sub

  Private Sub AdvBGVBilanAna_CustomDrawGroupRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles AdvBGVBilanAna.CustomDrawGroupRow

    Dim view As GridView = TryCast(sender, GridView)
    Dim info As GridGroupRowInfo = TryCast(e.Info, GridGroupRowInfo)
    If info.Column.FieldName = "CCTEANAACTIF" Then

      Select Case view.GetGroupRowValue(e.RowHandle, info.Column).ToString
        Case "O"
          info.GroupText = My.Resources.TabSyntheseCompta_frmSynthCompta_actif
        Case Else
          info.GroupText = My.Resources.TabSyntheseCompta_frmSynthCompta_archivé
      End Select

    End If

  End Sub

  Private Sub ABGV_Indic_Direct_CustomDrawGroupRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles ABGV_Indic_Direct.CustomDrawGroupRow, ABGV_Indic_Direct.CustomDrawGroupRow

    Dim view As GridView = TryCast(sender, GridView)
    Dim info As GridGroupRowInfo = TryCast(e.Info, GridGroupRowInfo)
    If info.Column.FieldName = "CCTEANAACTIF" Then

      Select Case view.GetGroupRowValue(e.RowHandle, info.Column).ToString
        Case "O"
          info.GroupText = My.Resources.TabSyntheseCompta_frmSynthCompta_actif
        Case Else
          info.GroupText = My.Resources.TabSyntheseCompta_frmSynthCompta_archivé
      End Select

    End If

  End Sub

  Private Sub AdvBandedGridView1_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles AdvBGVBilanAna.CustomSummaryCalculate

    Dim summaryID As String = CType(e.Item, GridSummaryItem).Tag.ToString
    Dim View As AdvBandedGridView = CType(sender, AdvBandedGridView)

    If e.SummaryProcess = CustomSummaryProcess.Start Then

      Select Case summaryID
        Case "" ' The total summary calculated against the 'UnitPrice' column. 
                    'e.TotalValue = TotAjust / TotCA  
        Case "BGCPourcCA"
          TotAjust = 0
          TotCA = 0
          Tot_Bilan_FG_ResultatAna = 0
        Case "BGCPourcChargeStruct"
          TotCharge = 0
          TotCA = 0
        Case "BGCMois_1_EC_NPCRESULTANA_MOIS_EC"
          TotCA_Cumul_Mois = 0
          TotResulatANA_Cumul_Mois = 0
        Case "BGCProjet_NPROJET_RESULTANA_PC"
          TotCA_GestProjet = 0
          TotResultAna_GestProjet = 0
        Case "NOBJCA_PC"
          TotCA_OBJ = 0
        Case "NOBJRESULTANA_PC"
          TotOBJRESULTANA_MTT = 0

      End Select

    End If

    If e.SummaryProcess = CustomSummaryProcess.Calculate Then

      Select Case summaryID
        Case "" ' The total summary calculated against the 'UnitPrice' column. 
                    'e.TotalValue = TotAjust / TotCA  
        Case "BGCPourcCA"
          TotAjust += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "RESULTAJUST"))
          TotCA += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "NCASYNCOMPTA"))
        Case "BGCPourcChargeStruct"
          TotCharge += Convert.ToInt32(View.GetDataRow(e.RowHandle).Item("NCHARGEDETAIL"))
          TotCA += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "NCASYNCOMPTA"))
        Case "BGCMois_1_EC_NPCRESULTANA_MOIS_EC"
          TotCA_Cumul_Mois += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "NTOT_CA_MOIS_EC"))
          TotResulatANA_Cumul_Mois += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "NRESULTANA_MOIS_EC"))
        Case "BGCProjet_NPROJET_RESULTANA_PC"

          If View.GetRowCellValue(e.RowHandle, "NPROJET_CA") IsNot Nothing AndAlso View.GetRowCellValue(e.RowHandle, "NPROJET_CA").ToString <> "" Then
            TotCA_GestProjet += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "NPROJET_CA"))
          End If
          If View.GetRowCellValue(e.RowHandle, "NPROJET_RESULTANA") IsNot Nothing AndAlso View.GetRowCellValue(e.RowHandle, "NPROJET_RESULTANA").ToString <> "" Then
            TotResultAna_GestProjet += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "NPROJET_RESULTANA"))
          End If
        Case "NOBJCA_PC"
          If View.GetRowCellValue(e.RowHandle, "NOBJCA") IsNot Nothing AndAlso View.GetRowCellValue(e.RowHandle, "NOBJCA").ToString <> "" Then
            TotCA_OBJ += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "NOBJCA"))
          End If
        Case "NOBJRESULTANA_PC"
          If View.GetRowCellValue(e.RowHandle, "NOBJRESULTANA_MTT") IsNot Nothing AndAlso View.GetRowCellValue(e.RowHandle, "NOBJRESULTANA_MTT").ToString <> "" Then
            TotOBJRESULTANA_MTT += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "NOBJRESULTANA_MTT"))
          End If

      End Select

    End If

    If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

      Select Case summaryID
        Case "BGCPourcCA" ' The total summary calculated against the 'UnitPrice' column.
          If TotCA = 0 Then
            e.TotalValue = "0 %"
          Else
            e.TotalValue = Convert.ToDecimal((TotAjust / TotCA) * 100).ToString("N2")
          End If
          Tot_Bilan_FG_CA = TotCA

        Case "BGCPourcChargeStruct" ' The total summary calculated against the 'UnitPrice' column.
          If TotCA = 0 Then
            e.TotalValue = "0 %"
          Else

            e.TotalValue = Convert.ToDecimal((TotCharge / TotCA) * 100).ToString("N2")

          End If

        Case "BGCMois_1_EC_NPCRESULTANA_MOIS_EC"

          If TotCA_Cumul_Mois = 0 Then
            e.TotalValue = 0
          Else

            e.TotalValue = Convert.ToDecimal((TotResulatANA_Cumul_Mois / TotCA_Cumul_Mois) * 100).ToString("N2")

          End If

        Case "BGCProjet_NPROJET_RESULTANA_PC"

          If TotCA_GestProjet = 0 Then
            e.TotalValue = 0
          Else

            e.TotalValue = Convert.ToDecimal((TotResultAna_GestProjet / TotCA_GestProjet) * 100).ToString("N2")

          End If

        Case "NOBJCA_PC"

          If TotCA_OBJ = 0 Then
            e.TotalValue = 0
          Else
            e.TotalValue = ((Convert.ToDecimal(TotCA / TotCA_OBJ) - 1) * 100).ToString("N1")
          End If

        Case "NOBJRESULTANA_PC"

          If TotCA = 0 Then
            e.TotalValue = 0
          Else
            e.TotalValue = Convert.ToDecimal(100.0 * Convert.ToDecimal(NANAOBJ_OBJ_MTT.SummaryItem.SummaryValue) / TotCA).ToString("N2")
          End If

        Case "NOBJRESULTATANA_DIFF"

          If TotCA = 0 Then
            e.TotalValue = 0
          Else
            e.TotalValue = Convert.ToDecimal((100 * (TotAjust - Convert.ToDecimal(NANAOBJ_OBJ_MTT.SummaryItem.SummaryValue)) / TotCA)).ToString("N2")
          End If

      End Select

    End If

  End Sub

  Private Sub ABGV_Indic_Direct_CustomSummaryCalculate(sender As Object, e As CustomSummaryEventArgs) Handles ABGV_Indic_Direct.CustomSummaryCalculate

    Dim summaryID As String = CType(e.Item, GridSummaryItem).Tag.ToString
    Dim View As AdvBandedGridView = CType(sender, AdvBandedGridView)

    If e.SummaryProcess = CustomSummaryProcess.Start Then

      Select Case summaryID
        Case "" ' The total summary calculated against the 'UnitPrice' column. 
                    'e.TotalValue = TotAjust / TotCA  
        Case "BandedGridColumn27"
          Tot_Indic_Direct_CA = 0
          Tot_Indic_Direct_MBE = 0

        Case "BandedGridColumn4"
          Tot_Indic_Direct_CA = 0
          Tot_Indic_Direct_REX = 0

        Case "NCA_BUDGET_MONTH_PC"
          Tot_Indic_Direct_CABUDGET = 0
        Case "NPOURCCAENCOURS"
          Tot_Indic_Direct_ResultatAna_avec_PC = 0
        Case "NBUDGETRESULTANA_PC"
          Tot_Indic_Direct_ResultatAna_BUDGET_MTT = 0
        Case "NBUDGETRESULTANA_DIFF"
        Case "TOT_DEPENSES_ST_PC"
          Tot_Indic_Direct_ResultatAna_Dep_ST = 0
        Case "TOT_DEPENSES_ACHAT_PC"
          Tot_Indic_Direct_ResultatAna_Dep_Achat = 0
        Case "TOT_DEPENSES_HR_CHANTIER_PC"
          Tot_Indic_Direct_ResultatAna_Dep_HR_Chantier = 0
        Case "TOT_DEPENSES_KMS_PC"
          Tot_Indic_Direct_ResultatAna_Dep_DepKMS = 0

      End Select

    End If

    If e.SummaryProcess = CustomSummaryProcess.Calculate Then

      Select Case summaryID
        Case "" ' The total summary calculated against the 'UnitPrice' column. 
                    'e.TotalValue = TotAjust / TotCA  
        Case "BandedGridColumn27"
          Tot_Indic_Direct_MBE += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "TOT_RESULT_MBE"))
          Tot_Indic_Direct_CA += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "NCASYNCOMPTA"))
        Case "BandedGridColumn4"
          Tot_Indic_Direct_REX += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "TOT_RESULT_REX"))
          Tot_Indic_Direct_CA += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "NCASYNCOMPTA"))

        Case "NCA_BUDGET_MONTH_PC"
          If IsDBNull((View.GetRowCellValue(e.RowHandle, "NCA_BUDGET_MONTH"))) = False Then Tot_Indic_Direct_CABUDGET += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "NCA_BUDGET_MONTH"))
        Case "NPOURCCAENCOURS"
          If IsDBNull((View.GetRowCellValue(e.RowHandle, "RESULTAJUST"))) = False Then Tot_Indic_Direct_ResultatAna_avec_PC += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "RESULTAJUST"))
        Case "NBUDGETRESULTANA_PC"
          If IsDBNull((View.GetRowCellValue(e.RowHandle, "NBUDGETRESULTANA_MTT"))) = False Then Tot_Indic_Direct_ResultatAna_BUDGET_MTT += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "NBUDGETRESULTANA_MTT"))
        Case "NBUDGETRESULTANA_DIFF"

        Case "TOT_DEPENSES_ST_PC"
          If IsDBNull((View.GetRowCellValue(e.RowHandle, "TOT_DEPENSES_ST"))) = False Then Tot_Indic_Direct_ResultatAna_Dep_ST += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "TOT_DEPENSES_ST"))
        Case "TOT_DEPENSES_ACHAT_PC"
          If IsDBNull((View.GetRowCellValue(e.RowHandle, "TOT_DEPENSES_ACHAT"))) = False Then Tot_Indic_Direct_ResultatAna_Dep_Achat += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "TOT_DEPENSES_ACHAT"))
        Case "TOT_DEPENSES_HR_CHANTIER_PC"
          If IsDBNull((View.GetRowCellValue(e.RowHandle, "TOT_DEPENSES_HR_CHANTIER"))) = False Then Tot_Indic_Direct_ResultatAna_Dep_HR_Chantier += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "TOT_DEPENSES_HR_CHANTIER"))
        Case "TOT_DEPENSES_KMS_PC"
          If IsDBNull((View.GetRowCellValue(e.RowHandle, "TOT_DEPENSES_KMS"))) = False Then Tot_Indic_Direct_ResultatAna_Dep_DepKMS += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "TOT_DEPENSES_KMS"))

      End Select

    End If

    If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

      Select Case summaryID
        Case "BandedGridColumn27" ' The total summary calculated against the 'UnitPrice' column.
          If Tot_Indic_Direct_CA = 0 Then
            e.TotalValue = 0
          Else
            e.TotalValue = Convert.ToDecimal((Tot_Indic_Direct_MBE / Tot_Indic_Direct_CA) * 100).ToString("N2")
          End If

        Case "BandedGridColumn4" ' The total summary calculated against the 'UnitPrice' column.
          If Tot_Indic_Direct_CA = 0 Then
            e.TotalValue = 0
          Else
            e.TotalValue = Convert.ToDecimal((Tot_Indic_Direct_REX / Tot_Indic_Direct_CA) * 100).ToString("N2")
          End If

        Case "NCA_BUDGET_MONTH_PC"
          If Tot_Indic_Direct_CABUDGET = 0 Then
            e.TotalValue = 0
          Else
            e.TotalValue = Convert.ToDecimal((Tot_Indic_Direct_CA / Tot_Indic_Direct_CABUDGET - 1) * 100).ToString("N0")
          End If
        Case "NPOURCCAENCOURS"
          If Tot_Indic_Direct_CA = 0 Then
            e.TotalValue = 0
          Else
            e.TotalValue = Convert.ToDecimal((Tot_Indic_Direct_ResultatAna_avec_PC / Tot_Indic_Direct_CA) * 100).ToString("N0")
          End If
        Case "NBUDGETRESULTANA_PC"
          If Tot_Indic_Direct_CA = 0 Then
            e.TotalValue = 0
          Else
            e.TotalValue = Convert.ToDecimal((Tot_Indic_Direct_ResultatAna_BUDGET_MTT / Tot_Indic_Direct_CA) * 100).ToString("N2")
          End If

        Case "NBUDGETRESULTANA_DIFF"
          If Tot_Indic_Direct_CA = 0 Then
            e.TotalValue = 0
          Else
            e.TotalValue = (Convert.ToDecimal((Tot_Indic_Direct_ResultatAna_avec_PC / Tot_Indic_Direct_CA) * 100) - Convert.ToDecimal((Tot_Indic_Direct_ResultatAna_BUDGET_MTT / Tot_Indic_Direct_CA) * 100)).ToString("N0")
          End If
        Case "TOT_DEPENSES_ST_PC"
          If Tot_Indic_Direct_CA = 0 Then
            e.TotalValue = 0
          Else
            e.TotalValue = Convert.ToDecimal((Tot_Indic_Direct_ResultatAna_Dep_ST / Tot_Indic_Direct_CA) * 100).ToString("N0")
          End If
        Case "TOT_DEPENSES_ACHAT_PC"
          If Tot_Indic_Direct_CA = 0 Then
            e.TotalValue = 0
          Else
            e.TotalValue = Convert.ToDecimal((Tot_Indic_Direct_ResultatAna_Dep_Achat / Tot_Indic_Direct_CA) * 100).ToString("N0")
          End If
        Case "TOT_DEPENSES_HR_CHANTIER_PC"
          If Tot_Indic_Direct_CA = 0 Then
            e.TotalValue = 0
          Else
            e.TotalValue = Convert.ToDecimal((Tot_Indic_Direct_ResultatAna_Dep_HR_Chantier / Tot_Indic_Direct_CA) * 100).ToString("N0")
          End If
        Case "TOT_DEPENSES_KMS_PC"
          If Tot_Indic_Direct_CA = 0 Then
            e.TotalValue = 0
          Else
            e.TotalValue = Convert.ToDecimal((Tot_Indic_Direct_ResultatAna_Dep_DepKMS / Tot_Indic_Direct_CA) * 100).ToString("N0")
          End If
      End Select

    End If

  End Sub

  Private Sub AdvBGVBilanAnaSoc_CustomSummaryCalculate(sender As Object, e As CustomSummaryEventArgs) Handles AdvBGVBilanAnaSoc.CustomSummaryCalculate

    Dim summaryID As String = CType(e.Item, GridSummaryItem).Tag.ToString
    Dim View As AdvBandedGridView = CType(sender, AdvBandedGridView)

    If e.SummaryProcess = CustomSummaryProcess.Start Then

      Select Case summaryID
        Case "" ' The total summary calculated against the 'UnitPrice' column. 
                    'e.TotalValue = TotAjust / TotCA  
        Case "BGColAnaNPOURCREAJUST"
          Tot_Bilan_FG_ResultatAna = 0
        Case "BGColBalAnaNPOURCDEPREEL"
          Tot_Bilan_FG_Dep_reel = 0

      End Select

    End If

    If e.SummaryProcess = CustomSummaryProcess.Calculate Then

      Select Case summaryID
        Case "" ' The total summary calculated against the 'UnitPrice' column. 
                    'e.TotalValue = TotAjust / TotCA  
        Case "BGColAnaNPOURCREAJUST"
          Tot_Bilan_FG_ResultatAna += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "TOTREAJUST"))
        Case "BGColBalAnaNPOURCDEPREEL"
          If View.GetRowCellValue(e.RowHandle, "NDEPREEL") IsNot Nothing AndAlso View.GetRowCellValue(e.RowHandle, "NDEPREEL").ToString <> "" Then
            Tot_Bilan_FG_Dep_reel += Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "NDEPREEL"))
          End If

      End Select

    End If

    If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

      Select Case summaryID
        Case "BGColAnaNPOURCREAJUST" ' The total summary calculated against the 'UnitPrice' column.
          If Tot_Bilan_FG_CA = 0 Then
            e.TotalValue = 0
          Else
            e.TotalValue = Convert.ToDecimal((Tot_Bilan_FG_ResultatAna / Tot_Bilan_FG_CA) * 100).ToString("N2")
          End If
        Case "BGColBalAnaNPOURCDEPREEL" ' The total summary calculated against the 'UnitPrice' column.
          If Tot_Bilan_FG_CA = 0 Then
            e.TotalValue = 0
          Else
            e.TotalValue = Convert.ToDecimal((Tot_Bilan_FG_Dep_reel / Tot_Bilan_FG_CA) * 100).ToString("N2")
          End If

      End Select

    End If

  End Sub

  Private Sub LoadDataAnaREX()

    Try
      dtAnaREX = MozartDatabase.GetDataTable($"exec api_sp_TableauSynthComptaREXV2 {mMoisNum}, {mAnneeNum}, '{MozartParams.NomSociete}'")

      GCAnaREX.DataSource = dtAnaREX

    Catch ex As Exception
      MessageBox.Show(My.Resources.TabSyntheseCompta_frmSynthCompta_sub2 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub BtnExportXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportXLS.Click

    'il faut sélectionner un mois et année
    If Not periodSelected(True) Then Return

    SFDSynCompta.FileName = ""

    Dim options = New XlsxExportOptionsEx With {
      .ExportType = DevExpress.Export.ExportType.WYSIWYG
    }

    'on exprote selon l ongelt sélectionner
    Select Case XTBCSynthCompta.SelectedTabPage.Name

      Case "XTPBilanCpt"

        SFDSynCompta.Filter = "Fichiers EXCEL (*.xlsx)|*.xlsx"
        SFDSynCompta.ShowDialog()

        If SFDSynCompta.FileName <> "" Then

          AdvBGVBilanAna.OptionsPrint.AutoWidth = False
          AdvBGVBilanAna.ExportToXlsx(SFDSynCompta.FileName, options)

        End If

      Case "XTPBalanceAna"

        SFDSynCompta.Filter = "Fichiers EXCEL (*.xlsx)|*.xlsx"
        SFDSynCompta.ShowDialog()

        If SFDSynCompta.FileName <> "" Then

          AdvBGVBilanAnaSoc.OptionsPrint.AutoWidth = False
          AdvBGVBilanAnaSoc.ExportToXlsx(SFDSynCompta.FileName, options)

        End If

      Case "XTPREX"

        SFDSynCompta.Filter = "Fichiers EXCEL (*.xlsx)|*.xlsx"
        SFDSynCompta.ShowDialog()

        If SFDSynCompta.FileName <> "" Then

          AdvBandedGVAnaREX.OptionsPrint.AutoWidth = False
          AdvBandedGVAnaREX.ExportToXlsx(SFDSynCompta.FileName, options)

        End If

      Case "XTP_Ind_Direct"

        SFDSynCompta.Filter = "Fichiers EXCEL (*.xlsx)|*.xlsx"
        SFDSynCompta.ShowDialog()

        If SFDSynCompta.FileName <> "" Then

          ABGV_Indic_Direct.OptionsPrint.AutoWidth = False
          ABGV_Indic_Direct.ExportToXlsx(SFDSynCompta.FileName, options)

        End If

      Case Else

        MessageBox.Show("Exportation impossible !", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return

    End Select

  End Sub

  Private Sub FrmSynthCompta_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged

    XTBCSynthCompta.Size = New Size(Me.Size.Width - XTBCSynthCompta.Location.X - GrpActions.Location.X - 30, Me.Size.Height - (XTBCSynthCompta.Location.Y * 2) - 40)

  End Sub

  Private Sub BtnValid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnValid.Click, BtnRefresh.Click

    'il faut sélectionner un mois et année
    If Not periodSelected(True, True) Then Exit Sub

    Try

      Me.Cursor = Cursors.WaitCursor

      Dim DataExist As Integer

      Dim sqlcmdVerifdata As New SqlCommand("api_sp_VerifDataAnalytique", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      'on passse le 1er de chaque mois en guise test pour le mois et l'année
      sqlcmdVerifdata.Parameters.Add("@p_dateverif", SqlDbType.DateTime)
      sqlcmdVerifdata.Parameters("@p_dateverif").Value = New DateTime(CboAnnee.SelectedValue.ToString, CboMois.SelectedValue.ToString, 1)

      Dim drVerif As SqlDataReader = sqlcmdVerifdata.ExecuteReader
      drVerif.Read()
      DataExist = drVerif("NBEXIST")
      drVerif.Close()

      If DataExist = 0 Then
        MessageBox.Show("Il n'existe pas de données sur cette période !", "Pas de données", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      Else

        'If sender.name = "BtnRefresh" AndAlso MessageBox.Show("Voulez-vous rafraichir les données du reporting ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) <> DialogResult.Yes Then
        '  Return
        'End If

        'init
        GCSynthCompta.DataSource = Nothing
        GCBalanceAna.DataSource = Nothing
        GCAnaREX.DataSource = Nothing

        mAnneeNum = CboAnnee.SelectedValue
        mMoisNum = CboMois.SelectedValue

                If GetMaxDate(mMoisNum, mAnneeNum) = "" Then
                    LblDateLastMAJ.Visible = False
                Else
                    LblDateLastMAJ.Text = $"Date de la dernière mise à jour : {GetMaxDate(mMoisNum, mAnneeNum)}"
                End If

                LoadDatas(sender)

      End If

    Catch ex As Exception
      MessageBox.Show("Sub BtnValid_Click dans FrmSynthCompta : " + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally

      Me.Cursor = Cursors.Default

    End Try

  End Sub

  Private Sub LoadDatas(ByVal sender As Object)
    If RechercheDroitMenu(625) Then
      'affichage auto du max date
      LoadDataByChefGroupe()
    ElseIf RechercheDroitMenu(369) Then
      'LoadData(sender.name = "BtnRefresh")
      LoadData(False)
    ElseIf RechercheDroitMenu(751) Then
      LoadData(True)
    Else
      XTPBilanCpt.PageVisible = False
    End If
  End Sub

  Private Function periodSelected(bDisplayError As Boolean, Optional bUpDateMemberField As Boolean = False) As Boolean
    If bUpDateMemberField Then
      If (CboAnnee.SelectedIndex <= 0 Or CboMois.SelectedIndex <= 0) Then
        If bDisplayError Then
          MessageBox.Show("Il faut sélectionner un mois et une année", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Return False
      End If

      mMoisNum = CboMois.SelectedValue
      mAnneeNum = CboAnnee.SelectedValue

    End If

    'il faut sélectionner un mois et année
    If mMoisNum = 9999999 Then
      If bDisplayError Then
        MessageBox.Show("Il faut sélectionner un mois", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If

      Return False
    End If

    If mAnneeNum = 999999 Then
      If bDisplayError Then
        MessageBox.Show("Il faut sélectionner une année", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If

      Return False
    End If

    Return True
  End Function

  Private Sub BtnExportPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportPDF.Click

    'il faut sélectionner un mois et année
    If Not periodSelected(True) Then Exit Sub

    SFDSynCompta.FileName = ""

    'on exprote selon l ongelt sélectionner
    Select Case XTBCSynthCompta.SelectedTabPage.Name

      Case "XTPBilanCpt"

        SFDSynCompta.Filter = "Fichiers PDF (*.pdf)|*.pdf"
        SFDSynCompta.ShowDialog()

        If SFDSynCompta.FileName <> "" Then

          CustomizeForExport(XTBCSynthCompta.SelectedTabPageIndex, 0)

          AdvBGVBilanAna.OptionsPrint.AutoWidth = True

          Dim ps As New PrintingSystemBase()
          Dim link As New DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(ps)

          AddHandler link.CreateReportHeaderArea, AddressOf PrintableComponentLink_CreateReportHeaderArea

          link.Component = GCSynthCompta
          link.Landscape = True
          link.Margins.Left = 1
          link.Margins.Right = 1
          link.Margins.Top = 1
          link.Margins.Bottom = 1
          link.CreateDocument()

          link.PrintingSystemBase.ExportToPdf(SFDSynCompta.FileName)

          CustomizeForExport(XTBCSynthCompta.SelectedTabPageIndex, 1)

        End If

      Case "XTPBalanceAna"

        SFDSynCompta.Filter = "Fichiers PDF (*.pdf)|*.pdf"
        SFDSynCompta.ShowDialog()

        If SFDSynCompta.FileName <> "" Then

          CustomizeForExport(XTBCSynthCompta.SelectedTabPageIndex, 0)

          AdvBGVBilanAnaSoc.OptionsPrint.AutoWidth = True

          Dim ps As New PrintingSystemBase()
          Dim link As New DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(ps)
          AddHandler link.CreateReportHeaderArea, AddressOf PrintableComponentLink_CreateReportHeaderArea
          link.Component = GCBalanceAna
          link.Landscape = True
          link.Margins.Left = 1
          link.Margins.Right = 1
          link.Margins.Top = 1
          link.Margins.Bottom = 1
          link.CreateDocument()
          link.PrintingSystemBase.ExportToPdf(SFDSynCompta.FileName)

          CustomizeForExport(XTBCSynthCompta.SelectedTabPageIndex, 1)

        End If

      Case "XTPREX"

        SFDSynCompta.Filter = "Fichiers PDF (*.pdf)|*.pdf"
        SFDSynCompta.ShowDialog()

        If SFDSynCompta.FileName <> "" Then

          CustomizeForExport(XTBCSynthCompta.SelectedTabPageIndex, 0)

          AdvBandedGVAnaREX.OptionsPrint.AutoWidth = True

          Dim ps As New PrintingSystemBase()
          Dim link As New DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(ps)
          AddHandler link.CreateReportHeaderArea, AddressOf PrintableComponentLink_CreateReportHeaderArea
          link.Component = GCAnaREX
          link.Landscape = True
          link.Margins.Left = 1
          link.Margins.Right = 1
          link.Margins.Top = 1
          link.Margins.Bottom = 1
          link.CreateDocument()
          link.PrintingSystemBase.ExportToPdf(SFDSynCompta.FileName)

          CustomizeForExport(XTBCSynthCompta.SelectedTabPageIndex, 1)

        End If

      Case "XTP_Ind_Direct"

        SFDSynCompta.Filter = "Fichiers PDF (*.pdf)|*.pdf"
        SFDSynCompta.ShowDialog()

        If SFDSynCompta.FileName <> "" Then

          CustomizeForExport(XTBCSynthCompta.SelectedTabPageIndex, 0)

          ABGV_Indic_Direct.OptionsPrint.AutoWidth = True

          Dim ps As New PrintingSystemBase()
          Dim link As New DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(ps)
          AddHandler link.CreateReportHeaderArea, AddressOf PrintableComponentLink_CreateReportHeaderArea
          link.Component = GCIndic_Direct
          link.Landscape = True
          link.Margins.Left = 1
          link.Margins.Right = 1
          link.Margins.Top = 1
          link.Margins.Bottom = 1
          link.CreateDocument()
          link.PrintingSystemBase.ExportToPdf(SFDSynCompta.FileName)

          CustomizeForExport(XTBCSynthCompta.SelectedTabPageIndex, 1)

        End If

      Case Else

        MessageBox.Show(My.Resources.TabSyntheseCompta_frmSynthCompta_export_impo, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Select

  End Sub

  Private Sub PrintableComponentLink_CreateReportHeaderArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs)

    Dim brick As TextBrick

    brick = e.Graph.DrawString(String.Format("{0} {1} {2}", My.Resources.TabSyntheseCompta_frmSynthCompta_Titre_PinrtDoc_Header, MonthName(mMoisNum).ToUpper, mAnneeNum.ToString()),
                               Color.Black, New RectangleF(0, 0, 1016, 20), BorderSide.None)

    brick.Font = New Font("Arial", 10)

    brick.StringFormat = New BrickStringFormat(StringAlignment.Center)

  End Sub

  Private Sub AdvBandedGVAnaREX_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles AdvBandedGVAnaREX.CustomDrawCell

    Dim oDatarowTmp As DataRow = AdvBandedGVAnaREX.GetDataRow(e.RowHandle)

    Select Case oDatarowTmp.Item("NID")

      Case 1
        e.Appearance.Font = New Font(e.Appearance.Font.Name, e.Appearance.Font.Size, FontStyle.Bold)

      Case 6, 8
        e.Appearance.BackColor = Color.LightYellow
        e.Appearance.Font = New Font(e.Appearance.Font.Name, e.Appearance.Font.Size, FontStyle.Bold)

    End Select

  End Sub

  Private Sub GCSynthCompta_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles GCSynthCompta.Paint

    Dim gridPaint As GridControl = CType(sender, GridControl)

    If gridPaint Is Nothing Then Return

    Dim AdvbandGridViewPaint As BandedGridView = TryCast(gridPaint.FocusedView, AdvBandedGridView)

    If AdvbandGridViewPaint Is Nothing Then Return

    Dim viewInfo As AdvBandedGridViewInfo = TryCast(AdvbandGridViewPaint.GetViewInfo(), AdvBandedGridViewInfo)
    Dim oPen As New Pen(Brushes.Black, 2)

    For Each band As GridBand In AdvbandGridViewPaint.Bands

      Dim bandInfo As GridBandInfoArgs = viewInfo.BandsInfo(band)

      If bandInfo IsNot Nothing Then  'AndAlso bandInfo.Bounds.Right < gridPaint.Width

        'on récupère la position la position de la colonne chaff
        Dim bandInfoChaff As GridBandInfoArgs = viewInfo.BandsInfo(GBChaff)

        If bandInfoChaff Is Nothing Then Return

        Dim iPosXChaff As Int32 = bandInfoChaff.Bounds.X + bandInfoChaff.Bounds.Width

        'ligne vertciale droite de haut en bas
        Dim startPoint As New Point(bandInfo.Bounds.Right - 1, bandInfo.Bounds.Y)
        Dim endPoint As New Point(bandInfo.Bounds.Right - 1, viewInfo.ViewRects.Footer.Bottom)

        'ligne verticale gauche, haut en abs
        Dim startPointLeft As New Point(bandInfo.Bounds.Left - 1, bandInfo.Bounds.Y)
        Dim endPointLeft As New Point(bandInfo.Bounds.Left - 1, viewInfo.ViewRects.Footer.Bottom)

        'Console.WriteLine("Pos Chaff : " & iPosYChaff)

        'ligne vertical
        Select Case band.Name

          Case "GBChaff"

            e.Graphics.DrawLine(oPen, startPoint, endPoint)

          Case "gridBand1"  'mois en cours

            If startPoint.X < iPosXChaff Then startPoint.X = iPosXChaff : endPoint.X = startPoint.X

            e.Graphics.DrawLine(oPen, startPoint, endPoint)
            ' e.Graphics.DrawLine(oPen, startPointLeft, endPointLeft)

            For Each bandin1 As GridBand In band.Children

              Dim bandInfoIn1 As GridBandInfoArgs = viewInfo.BandsInfo.FindBand(bandin1)

              If bandInfoIn1 IsNot Nothing Then

                'ligne verticale a droite
                Dim startPoint_In_1 As New Point(bandInfoIn1.Bounds.Right - 1, bandInfoIn1.Bounds.Y)
                Dim endPoint_In_1 As New Point(bandInfoIn1.Bounds.Right - 1, viewInfo.ViewRects.Footer.Bottom)

                'ligne verticale à gauche
                Dim startPointLeft_In_1 As New Point(bandInfoIn1.Bounds.Left - 1, bandInfoIn1.Bounds.Y)
                Dim endPointLeft_In_1 As New Point(bandInfoIn1.Bounds.Left - 1, viewInfo.ViewRects.Footer.Bottom)

                'ligne hozizontal
                Dim startPointHLeft_In_1 As New Point(bandInfoIn1.Bounds.Left - 1, bandInfoIn1.Bounds.Y)
                Dim endPointHRight_In_1 As New Point(bandInfoIn1.Bounds.Right - 1, bandInfoIn1.Bounds.Y)

                If startPoint_In_1.X < iPosXChaff Then startPoint_In_1.X = iPosXChaff : endPoint_In_1.X = startPoint_In_1.X
                If startPointLeft_In_1.X < iPosXChaff Then startPointLeft_In_1.X = iPosXChaff : endPointLeft_In_1.X = startPointLeft_In_1.X

                If startPointHLeft_In_1.X < iPosXChaff Then startPointHLeft_In_1.X = iPosXChaff
                If endPointHRight_In_1.X < iPosXChaff Then endPointHRight_In_1.X = iPosXChaff

                Select Case bandin1.Name

                  Case "gridBand1"
                    e.Graphics.DrawLine(oPen, startPointLeft_In_1, endPointLeft_In_1)
                    e.Graphics.DrawLine(oPen, startPoint_In_1, endPoint_In_1)
                    e.Graphics.DrawLine(oPen, startPointHLeft_In_1, endPointHRight_In_1)

                  Case "gridBand4"
                    e.Graphics.DrawLine(oPen, startPointHLeft_In_1, endPointHRight_In_1)

                  Case "gridBand2"
                    e.Graphics.DrawLine(oPen, startPointHLeft_In_1, endPointHRight_In_1)

                  Case "gridBand3"
                    e.Graphics.DrawLine(oPen, startPointHLeft_In_1, endPointHRight_In_1)

                  Case "kpiMoisEnCours"
                    e.Graphics.DrawLine(oPen, startPoint_In_1, endPoint_In_1)
                    'e.Graphics.DrawLine(oPen, startPointLeft_In_1, endPointLeft_In_1)
                    e.Graphics.DrawLine(oPen, startPointHLeft_In_1, endPointHRight_In_1)

                End Select

              End If

            Next

          Case "gridBand5"  'travaux (gestion projets)
            If startPoint.X < iPosXChaff Then startPoint.X = iPosXChaff : endPoint.X = startPoint.X

            e.Graphics.DrawLine(oPen, startPoint, endPoint)

          Case "GBBILANRESULT"  'données cumulées

            If startPoint.X < iPosXChaff Then startPoint.X = iPosXChaff : endPoint.X = startPoint.X

            'ligne hozizontal haut
            Dim startPointHLeft_In_GBRESULT As New Point(bandInfo.Bounds.Left - 1, bandInfo.Bounds.Y)
            Dim endPointHRight_In_GBRESULT As New Point(bandInfo.Bounds.Right - 1, bandInfo.Bounds.Y)

            'ligne horizontal bas
            Dim startPointBLeft_In_GBRESULT As New Point(bandInfo.Bounds.Left - 1, bandInfo.Bounds.Bottom)
            Dim endPointBRight_In_GBRESULT As New Point(bandInfo.Bounds.Right - 1, bandInfo.Bounds.Bottom)

            If startPointHLeft_In_GBRESULT.X < iPosXChaff Then startPointHLeft_In_GBRESULT.X = iPosXChaff
            If endPointHRight_In_GBRESULT.X < iPosXChaff Then endPointHRight_In_GBRESULT.X = iPosXChaff

            If startPointBLeft_In_GBRESULT.X < iPosXChaff Then startPointBLeft_In_GBRESULT.X = iPosXChaff
            If endPointBRight_In_GBRESULT.X < iPosXChaff Then endPointBRight_In_GBRESULT.X = iPosXChaff

            e.Graphics.DrawLine(oPen, startPointHLeft_In_GBRESULT, endPointHRight_In_GBRESULT)
            e.Graphics.DrawLine(oPen, startPointBLeft_In_GBRESULT, endPointBRight_In_GBRESULT)

            e.Graphics.DrawLine(oPen, startPoint, endPoint)

            For Each bandinGBResult As GridBand In band.Children

              Dim bandInfoInGBResult As GridBandInfoArgs = viewInfo.BandsInfo.FindBand(bandinGBResult)

              Select Case bandinGBResult.Name
                Case "GBProd"

                  'ligne a droite
                  If bandInfoInGBResult IsNot Nothing Then
                    e.Graphics.DrawLine(oPen, New Point(If(bandInfoInGBResult.Bounds.Right < iPosXChaff, iPosXChaff, bandInfoInGBResult.Bounds.Right), bandInfoInGBResult.Bounds.Y), New Point(If(bandInfoInGBResult.Bounds.Right < iPosXChaff, iPosXChaff, bandInfoInGBResult.Bounds.Right), viewInfo.ViewRects.Footer.Bottom))

                    'ligne horizontal bas
                    Dim startPointBLeft_In_GBProd As New Point(bandInfoInGBResult.Bounds.Left - 1, bandInfoInGBResult.Bounds.Bottom)
                    Dim endPointBRight_In_GBProd As New Point(bandInfoInGBResult.Bounds.Right - 1, bandInfoInGBResult.Bounds.Bottom)
                    If startPointBLeft_In_GBProd.X < iPosXChaff Then startPointBLeft_In_GBProd.X = iPosXChaff
                    If endPointBRight_In_GBProd.X < iPosXChaff Then endPointBRight_In_GBProd.X = iPosXChaff

                    e.Graphics.DrawLine(oPen, startPointBLeft_In_GBProd, endPointBRight_In_GBProd)

                    Dim bandInfoInGBProd As GridBandInfoArgs = viewInfo.BandsInfo.FindBand(bandinGBResult)

                    For Each bandinGPPROD As GridBand In bandinGBResult.Children

                      Dim bandInfoIn2 As GridBandInfoArgs = viewInfo.BandsInfo.FindBand(bandinGPPROD)

                      If bandInfoIn2 Is Nothing Then Return

                      'ligne verticale droite
                      Dim startPoint_In_2 As New Point(bandInfoIn2.Bounds.Right - 1, bandInfoIn2.Bounds.Y)
                      Dim endPoint_In_2 As New Point(bandInfoIn2.Bounds.Right - 1, viewInfo.ViewRects.Footer.Bottom)

                      'ligne verticale gauche
                      Dim startPointLeft_In_2 As New Point(bandInfoIn2.Bounds.Left - 1, bandInfoIn2.Bounds.Y)
                      Dim endPointLeft_In_2 As New Point(bandInfoIn2.Bounds.Left - 1, viewInfo.ViewRects.Footer.Bottom)

                      If startPoint_In_2.X < iPosXChaff Then startPoint_In_2.X = iPosXChaff : endPoint_In_2.X = startPoint_In_2.X
                      If startPointLeft_In_2.X < iPosXChaff Then startPointLeft_In_2.X = iPosXChaff : endPointLeft_In_2.X = startPointLeft_In_2.X

                      'ligne hozizontal
                      Dim startPointHLeft_In_2 As New Point(bandInfoIn2.Bounds.Left - 1, bandInfoIn2.Bounds.Y)
                      Dim endPointHRight_In_2 As New Point(bandInfoIn2.Bounds.Right - 1, bandInfoIn2.Bounds.Y)
                      If startPointHLeft_In_2.X < iPosXChaff Then startPointHLeft_In_2.X = iPosXChaff
                      If endPointHRight_In_2.X < iPosXChaff Then endPointHRight_In_2.X = iPosXChaff

                    Next
                  End If
                Case "GBResultFG"

                  Dim bandInfoInGBResultFG As GridBandInfoArgs = viewInfo.BandsInfo.FindBand(bandinGBResult)

                  If bandInfoInGBResult Is Nothing Then Return

                  'ligne horizontal bas
                  Dim startPointBLeft_In_GBResultFG As New Point(bandInfoInGBResult.Bounds.Left - 1, bandInfoInGBResult.Bounds.Bottom)
                  Dim endPointBRight_In_GBResultFG As New Point(bandInfoInGBResult.Bounds.Right - 1, bandInfoInGBResult.Bounds.Bottom)
                  If startPointBLeft_In_GBResultFG.X < iPosXChaff Then startPointBLeft_In_GBResultFG.X = iPosXChaff
                  If endPointBRight_In_GBResultFG.X < iPosXChaff Then endPointBRight_In_GBResultFG.X = iPosXChaff

                  e.Graphics.DrawLine(oPen, startPointBLeft_In_GBResultFG, endPointBRight_In_GBResultFG)
                  e.Graphics.DrawLine(oPen, startPoint, endPoint)

                  For Each bandin3 As GridBand In bandinGBResult.Children

                    Dim bandInfoIn3 As GridBandInfoArgs = viewInfo.BandsInfo.FindBand(bandin3)

                    If Not bandInfoIn3 Is Nothing Then

                      'ligne verticale droite
                      Dim startPoint_In_3 As New Point(bandInfoIn3.Bounds.Right - 1, bandInfoIn3.Bounds.Y)
                      Dim endPoint_In_3 As New Point(bandInfoIn3.Bounds.Right - 1, viewInfo.ViewRects.Footer.Bottom)

                      'ligne verticale gauche
                      Dim startPointLeft_In_3 As New Point(bandInfoIn3.Bounds.Left - 1, bandInfoIn3.Bounds.Y)
                      Dim endPointLeft_In_3 As New Point(bandInfoIn3.Bounds.Left - 1, viewInfo.ViewRects.Footer.Bottom)

                      If startPoint_In_3.X < iPosXChaff Then startPoint_In_3.X = iPosXChaff : endPointLeft_In_3.X = startPoint_In_3.X
                      If startPointLeft_In_3.X < iPosXChaff Then startPointLeft_In_3.X = iPosXChaff : endPointLeft_In_3.X = startPointLeft_In_3.X

                      'ligne hozizontal haut
                      Dim startPointHLeft_In_3 As New Point(bandInfoIn3.Bounds.Left - 1, bandInfoIn3.Bounds.Y)
                      Dim endPointHRight_In_3 As New Point(bandInfoIn3.Bounds.Right - 1, bandInfoIn3.Bounds.Y)
                      If startPointHLeft_In_3.X < iPosXChaff Then startPointHLeft_In_3.X = iPosXChaff
                      If endPointHRight_In_3.X < iPosXChaff Then endPointHRight_In_3.X = iPosXChaff

                      Select Case bandin3.Name

                        Case "GBMOISPREC"
                          e.Graphics.DrawLine(oPen, startPointHLeft_In_3, endPointHRight_In_3)

                        Case "GBANNEEPREC"
                          e.Graphics.DrawLine(oPen, startPointHLeft_In_3, endPointHRight_In_3)

                      End Select

                    End If

                  Next

              End Select

            Next

          Case "GBTxChargeStruct"

            e.Graphics.DrawLine(oPen, startPoint, endPoint)

        End Select

        'ligne horizontale
        e.Graphics.DrawLine(oPen, New Point(1, viewInfo.ViewRects.ColumnPanel.Bottom), New Point(bandInfo.Bounds.Right - 1, viewInfo.ViewRects.ColumnPanel.Bottom))

        e.Graphics.DrawLine(oPen, New Point(1, 1), New Point(bandInfo.Bounds.Right - 1, 1))
        e.Graphics.DrawLine(oPen, New Point(1, 1), New Point(1, viewInfo.ViewRects.Footer.Bottom))

        e.Graphics.DrawLine(oPen, New Point(1, viewInfo.ViewRects.Footer.Top + 2), New Point(bandInfo.Bounds.Right - 1, viewInfo.ViewRects.Footer.Top + 2))

        e.Graphics.DrawLine(oPen, New Point(1, viewInfo.ViewRects.Footer.Bottom), New Point(bandInfo.Bounds.Right - 1, viewInfo.ViewRects.Footer.Bottom))


        'quadrillage spécifique par colonne
        For Each cols As BandedGridColumn In AdvbandGridViewPaint.Columns

          Dim viewInfoCol As GridColumnInfoArgs = TryCast(viewInfo.ColumnsInfo(cols), GridColumnInfoArgs)

          If viewInfoCol IsNot Nothing Then  'AndAlso viewInfoCol.Bounds.Bottom < gridPaint.Height

            'ligne horizontale TOP de la colonne header
            Dim ColstartPoint As New Point(viewInfoCol.Bounds.Left - 1, viewInfoCol.Bounds.Top)
            Dim ColendPoint As New Point(viewInfoCol.Bounds.Right - 1, viewInfoCol.Bounds.Top)
            If ColstartPoint.X < iPosXChaff Then ColstartPoint.X = iPosXChaff
            If ColendPoint.X < iPosXChaff Then ColendPoint.X = iPosXChaff


            'ligne verticale LEFT
            Dim ColVerticalLEFTStartPoint As New Point(viewInfoCol.Bounds.Left - 1, viewInfoCol.Bounds.Top)
            Dim ColVerticalLEFTEndPoint As New Point(viewInfoCol.Bounds.Left - 1, viewInfo.ViewRects.Footer.Bottom)

            If ColVerticalLEFTStartPoint.X < iPosXChaff Then ColVerticalLEFTStartPoint.X = iPosXChaff : ColVerticalLEFTEndPoint.X = ColVerticalLEFTStartPoint.X

            'ligne verticale RIGHT
            Dim ColVerticalRIGHTStartPoint As New Point(viewInfoCol.Bounds.Right - 1, viewInfoCol.Bounds.Top)
            Dim ColVerticalRIGHTEndPoint As New Point(viewInfoCol.Bounds.Right - 1, viewInfo.ViewRects.Footer.Bottom)

            If ColVerticalRIGHTStartPoint.X < iPosXChaff Then ColVerticalRIGHTStartPoint.X = iPosXChaff : ColVerticalRIGHTEndPoint.X = ColVerticalRIGHTStartPoint.X

          End If

        Next

      End If

    Next band

  End Sub

  Private Sub GCIndic_Direct_Paint(sender As Object, e As PaintEventArgs) Handles GCIndic_Direct.Paint

    Dim gridPaint As GridControl = CType(sender, GridControl)

    If gridPaint Is Nothing Then Return

    Dim AdvbandGridViewPaint As BandedGridView = TryCast(gridPaint.FocusedView, AdvBandedGridView)

    If AdvbandGridViewPaint Is Nothing Then Return

    Dim viewInfo As AdvBandedGridViewInfo = TryCast(AdvbandGridViewPaint.GetViewInfo(), AdvBandedGridViewInfo)
    Dim oPen As New Pen(Brushes.Black, 2)

    For Each band As GridBand In AdvbandGridViewPaint.Bands

      Dim bandInfo As GridBandInfoArgs = viewInfo.BandsInfo(band)

      If Not bandInfo Is Nothing AndAlso bandInfo.Bounds.Right < gridPaint.Width Then

        Dim startPoint As New Point(bandInfo.Bounds.Right - 1, bandInfo.Bounds.Y)
        Dim endPoint As New Point(bandInfo.Bounds.Right - 1, viewInfo.ViewRects.Footer.Bottom)

        Dim startPointLeft As New Point(bandInfo.Bounds.Left - 1, bandInfo.Bounds.Y)
        Dim endPointLeft As New Point(bandInfo.Bounds.Left - 1, viewInfo.ViewRects.Footer.Bottom)

        'ligne vertical
        Select Case band.Name

          Case "GridBand16"

            e.Graphics.DrawLine(oPen, New Point(1, bandInfo.Bounds.Y), New Point(1, viewInfo.ViewRects.Footer.Bottom))

            e.Graphics.DrawLine(oPen, startPointLeft, endPointLeft)
            e.Graphics.DrawLine(oPen, startPoint, endPoint)

          Case "GridBand20"
            e.Graphics.DrawLine(oPen, startPoint, endPoint)

        End Select

      End If

    Next band

    'quadrillage spécifique par colonne
    For Each cols As BandedGridColumn In AdvbandGridViewPaint.Columns

      Dim viewInfoCol As GridColumnInfoArgs = viewInfo.ColumnsInfo(cols)

      If viewInfoCol IsNot Nothing Then

        'ligne horizontale TOP de la colonne header
        Dim ColstartPoint As New Point(viewInfoCol.Bounds.Left - 1, viewInfoCol.Bounds.Top)
        Dim ColendPoint As New Point(viewInfoCol.Bounds.Right - 1, viewInfoCol.Bounds.Top)

        'ligne verticale LEFT
        Dim ColVerticalLEFTStartPoint As New Point(viewInfoCol.Bounds.Left - 1, viewInfoCol.Bounds.Top)
        Dim ColVerticalLEFTEndPoint As New Point(viewInfoCol.Bounds.Left - 1, viewInfo.ViewRects.Footer.Bottom)

        'ligne verticale RIGHT
        Dim ColVerticalRIGHTStartPoint As New Point(viewInfoCol.Bounds.Right - 1, viewInfoCol.Bounds.Top)
        Dim ColVerticalRIGHTEndPoint As New Point(viewInfoCol.Bounds.Right - 1, viewInfo.ViewRects.Footer.Bottom)

        Select Case cols.FieldName

          Case "NSECANASYNCOMPTA"

            e.Graphics.DrawLine(oPen, ColstartPoint, ColendPoint)

          Case "TOT_RESULT_MBE"

            e.Graphics.DrawLine(oPen, ColstartPoint, ColendPoint)
            e.Graphics.DrawLine(oPen, ColVerticalLEFTStartPoint, ColVerticalLEFTEndPoint)

          Case "NPOURC_CA_MBE"

            e.Graphics.DrawLine(oPen, ColstartPoint, ColendPoint)
            e.Graphics.DrawLine(oPen, ColVerticalRIGHTStartPoint, ColVerticalRIGHTEndPoint)

          Case "NTOT_REPART_FG_REEL"

            e.Graphics.DrawLine(oPen, ColstartPoint, ColendPoint)
            e.Graphics.DrawLine(oPen, ColVerticalRIGHTStartPoint, ColVerticalRIGHTEndPoint)

          Case "TOT_RESULT_REX"
            e.Graphics.DrawLine(oPen, ColstartPoint, ColendPoint)
          Case "NPOURC_CA_REX"
            e.Graphics.DrawLine(oPen, ColstartPoint, ColendPoint)

        End Select

      End If

    Next

  End Sub

  Private Sub GCBalanceAna_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GCBalanceAna.Paint

    Dim gridPaint As GridControl = CType(sender, GridControl)

    If gridPaint Is Nothing Then Return

    Dim AdvbandGridViewPaint As BandedGridView = TryCast(gridPaint.FocusedView, AdvBandedGridView)

    If AdvbandGridViewPaint Is Nothing Then Return

    Dim viewInfo As AdvBandedGridViewInfo = TryCast(AdvbandGridViewPaint.GetViewInfo(), AdvBandedGridViewInfo)
    Dim oPen As New Pen(Brushes.Black, 2)

    For Each band As GridBand In AdvbandGridViewPaint.Bands

      Dim bandInfo As GridBandInfoArgs = viewInfo.BandsInfo(band)

      If bandInfo IsNot Nothing AndAlso bandInfo.Bounds.Right < gridPaint.Width Then

        Dim startPoint As New Point(bandInfo.Bounds.Right - 1, bandInfo.Bounds.Y)
        Dim endPoint As New Point(bandInfo.Bounds.Right - 1, viewInfo.ViewRects.Footer.Bottom)

        'ligne vertical
        Select Case band.Name
          Case "GBBALDEP"

            e.Graphics.DrawLine(oPen, New Point(1, bandInfo.Bounds.Y), New Point(1, viewInfo.ViewRects.Footer.Bottom))
            e.Graphics.DrawLine(oPen, startPoint, endPoint)

          Case "GBBALREAJUSTE"
            e.Graphics.DrawLine(oPen, startPoint, endPoint)

          Case "GBBALTAB"
            e.Graphics.DrawLine(oPen, startPoint, endPoint)

        End Select

        'ligne horizontale
        Select Case band.Name
          Case "GBBALTAB"
            e.Graphics.DrawLine(oPen, New Point(1, viewInfo.ViewRects.ColumnPanel.Bottom), New Point(bandInfo.Bounds.Right - 1, viewInfo.ViewRects.ColumnPanel.Bottom))
            e.Graphics.DrawLine(oPen, New Point(1, 1), New Point(bandInfo.Bounds.Right - 1, 1))
            e.Graphics.DrawLine(oPen, New Point(1, viewInfo.ViewRects.Footer.Top + 2), New Point(bandInfo.Bounds.Right - 1, viewInfo.ViewRects.Footer.Top + 2))
            e.Graphics.DrawLine(oPen, New Point(1, viewInfo.ViewRects.Footer.Bottom), New Point(bandInfo.Bounds.Right - 1, viewInfo.ViewRects.Footer.Bottom))

        End Select

      End If

    Next band

    'quadrillage spécifique par colonne
    For Each cols As BandedGridColumn In AdvbandGridViewPaint.Columns

      Dim viewInfoCol As GridColumnInfoArgs = viewInfo.ColumnsInfo(cols)

      If viewInfoCol IsNot Nothing Then  'AndAlso viewInfoCol.Bounds.Bottom < gridPaint.Height

        'ligne horizontale TOP de la colonne header
        Dim ColstartPoint As New Point(viewInfoCol.Bounds.Left - 1, viewInfoCol.Bounds.Top)
        Dim ColendPoint As New Point(viewInfoCol.Bounds.Right - 1, viewInfoCol.Bounds.Top)

        'ligne verticale LEFT
        Dim ColVerticalLEFTStartPoint As New Point(viewInfoCol.Bounds.Left - 1, viewInfoCol.Bounds.Top)
        Dim ColVerticalLEFTEndPoint As New Point(viewInfoCol.Bounds.Left - 1, viewInfo.ViewRects.Footer.Bottom)

        'ligne verticale RIGHT
        Dim ColVerticalRIGHTStartPoint As New Point(viewInfoCol.Bounds.Right - 1, viewInfoCol.Bounds.Top)
        Dim ColVerticalRIGHTEndPoint As New Point(viewInfoCol.Bounds.Right - 1, viewInfo.ViewRects.Footer.Bottom)

        Select Case cols.FieldName
          Case "TOTREAJUST"
            e.Graphics.DrawLine(oPen, ColstartPoint, ColendPoint)
            e.Graphics.DrawLine(oPen, ColVerticalLEFTStartPoint, ColVerticalLEFTEndPoint)

          Case "NPOURCREAJUST"
            e.Graphics.DrawLine(oPen, ColstartPoint, ColendPoint)
            e.Graphics.DrawLine(oPen, ColVerticalRIGHTStartPoint, ColVerticalRIGHTEndPoint)

          Case "NECART_M1_M"
            e.Graphics.DrawLine(oPen, ColVerticalRIGHTStartPoint, ColVerticalRIGHTEndPoint)

        End Select

      End If

    Next

  End Sub

  Private Sub GCAnaREX_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles GCAnaREX.Paint

    Dim gridPaint As GridControl = CType(sender, GridControl)

    If gridPaint Is Nothing Then Return

    Dim AdvbandGridViewPaint As BandedGridView = TryCast(gridPaint.FocusedView, AdvBandedGridView)

    If AdvbandGridViewPaint Is Nothing Then Return

    Dim viewInfo As AdvBandedGridViewInfo = TryCast(AdvbandGridViewPaint.GetViewInfo(), AdvBandedGridViewInfo)

    Dim oPen As New Pen(Brushes.Black, 2)

    'quadrillage spécifique par colonne
    For Each cols As BandedGridColumn In AdvbandGridViewPaint.Columns

      Dim viewInfoCol As GridColumnInfoArgs = TryCast(viewInfo.ColumnsInfo(cols.VisibleIndex + 1), GridColumnInfoArgs)

      If Not viewInfoCol Is Nothing AndAlso viewInfoCol.Bounds.Bottom < gridPaint.Height Then

        'ligne horizontale TOP de la colonne header
        Dim ColstartPoint As New Point(viewInfoCol.Bounds.Left - 1, viewInfoCol.Bounds.Top)
        Dim ColendPoint As New Point(viewInfoCol.Bounds.Right - 1, viewInfoCol.Bounds.Top)

        'ligne horizontale BOTTOM de la colonne header
        Dim ColBOTTOMstartPoint As New Point(viewInfoCol.Bounds.Left - 1, viewInfoCol.Bounds.Bottom)
        Dim ColBOTTOMendPoint As New Point(viewInfoCol.Bounds.Right - 1, viewInfoCol.Bounds.Bottom)

        'ligne horizontale derniere ligne
        Dim ColLastRowStartPoint As New Point(viewInfoCol.Bounds.Left - 1, viewInfo.ViewRects.EmptyRows.Top)
        Dim ColLastRowEndPoint As New Point(viewInfoCol.Bounds.Right - 1, viewInfo.ViewRects.EmptyRows.Top)

        'ligne horizontale resultat
        Dim ColCellResultStartPoint As New Point(viewInfoCol.Bounds.Left - 1, viewInfo.ViewRects.EmptyRows.Top - viewInfo.MinRowHeight - 1)
        Dim ColCellResultEndPoint As New Point(viewInfoCol.Bounds.Right - 1, viewInfo.ViewRects.EmptyRows.Top - viewInfo.MinRowHeight - 1)

        'ligne verticale LEFT
        Dim ColVerticalLEFTStartPoint As New Point(viewInfoCol.Bounds.Left - 1, viewInfoCol.Bounds.Top)
        Dim ColVerticalLEFTEndPoint As New Point(viewInfoCol.Bounds.Left - 1, viewInfo.ViewRects.EmptyRows.Top)

        'ligne verticale RIGHT
        Dim ColVerticalRIGHTStartPoint As New Point(viewInfoCol.Bounds.Right - 1, viewInfoCol.Bounds.Top)
        Dim ColVerticalRIGHTEndPoint As New Point(viewInfoCol.Bounds.Right - 1, viewInfo.ViewRects.EmptyRows.Top)

        Select Case cols.FieldName
          Case "NRESULT"

            e.Graphics.DrawLine(oPen, ColstartPoint, ColendPoint)
            e.Graphics.DrawLine(oPen, ColBOTTOMstartPoint, ColBOTTOMendPoint)
            e.Graphics.DrawLine(oPen, ColLastRowStartPoint, ColLastRowEndPoint)
            e.Graphics.DrawLine(oPen, ColVerticalLEFTStartPoint, ColVerticalLEFTEndPoint)
            e.Graphics.DrawLine(oPen, ColVerticalRIGHTStartPoint, ColVerticalRIGHTEndPoint)
            e.Graphics.DrawLine(oPen, ColCellResultStartPoint, ColCellResultEndPoint)

        End Select

      End If

    Next

  End Sub

  'recherche des doublons sur un meme compte ana -> 2 chaff
  Private Function ReturnDTDoublonsChaffOnCAN() As DataTable

    Try
      Dim dtNCANNUM As New DataTable

      dtNCANNUM.Columns.Add("NCANNUM", GetType(Int32))

      Dim req = From RowSum In dtSynthCompta.AsEnumerable
                Group RowSum By NCANNUM = RowSum.Field(Of Int32)("NCANNUM") Into g = Group
                Where g.Count() > 1
                Select New With {Key NCANNUM}

      For Each result In req
        dtNCANNUM.Rows.Add(New Object() {result.NCANNUM})
      Next

      Return dtNCANNUM

    Catch ex As Exception

      'MessageBox.Show(My.Resources.TabSyntheseCompta_frmSynthCompta_sub5 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return Nothing

    End Try

  End Function

  Private Sub AdvBGVBilanAna_RowCellClick(ByVal sender As Object, ByVal e As RowCellClickEventArgs) Handles AdvBGVBilanAna.RowCellClick
    If e.RowHandle = -1 Then Exit Sub

    Dim drDetail As DataRow = AdvBGVBilanAna.GetDataRow(e.RowHandle)

    If e.Button = MouseButtons.Right Then
      Dim sMsg As String = ""

      If drDetail IsNot Nothing Then

        Select Case e.Column.FieldName

          Case "NCASYNCOMPTA"

            sMsg = String.Format("- Montant des encours MOZARIS (FAE / PCA) au 31/12/N-1 : {0:c2}" + vbCrLf +
                               "- Montant facturé dans MOZARIS : {1:c2}" + vbCrLf +
                               "- Encours MOZARIS du mois M (FAE / PCA) : {2:c2}" + vbCrLf +
                               "- Encours manuel mois M (FAE/PCA/AAE) : {3:c2}",
                               drDetail.Item("NODBILANDETAIL"), drDetail.Item("NCADETAIL"), drDetail.Item("NENCOURSDETAIL"), drDetail.Item("NPROD_CUMUL_VAR_NANAFACTEABLITOT"))

          Case "NPOURCHRSTRUCT"

            sMsg = String.Format(My.Resources.TabSyntheseCompta_frmSynthCompta_montant5, drDetail.Item("NCHARGEDETAIL"))

          Case "NSECANASYNCOMPTA"

            sMsg = String.Format(My.Resources.TabSyntheseCompta_frmSynthCompta_msg_sect_taux_horaire_part1 & vbCrLf & My.Resources.TabSyntheseCompta_frmSynthCompta_msg_sect_taux_horaire_part2 & vbCrLf & My.Resources.TabSyntheseCompta_frmSynthCompta_msg_sect_taux_horaire_part3,
                               drDetail.Item("AJUSTE_TX_HOR"),
                               drDetail.Item("NSECANASYNCOMPTA") - drDetail.Item("AJUSTE_TX_HOR"),
                               drDetail.Item("NSECANASYNCOMPTA"))

          Case "NTOT_CA_MOIS_EC"

            sMsg = String.Format("- Montant facturé dans MOZARIS : {0:c2}" & vbCrLf & vbCrLf _
                              & "- Variation des encours MOZARIS (FAE / PCA) : {1:c2}" & vbCrLf _
                              & Space(3) & "- Mois M-1 extournés : {2:c2}" & vbCrLf _
                              & Space(3) & "- Mois M : {3:c2}" & vbCrLf & vbCrLf _
                              & "-  Variation des encours manuels (FAE / PCA / AAE) : {4:c2}" & vbCrLf _
                              & Space(3) & "- Mois M-1 extournés : {5:c2}" & vbCrLf _
                              & Space(3) & "- Mois M : {6:c2}",
                               drDetail.Item("NCA_MOIS_EC"),
                               drDetail.Item("NENCOURS_MOIS_EC"), drDetail.Item("NMOIS_1_ENCOURS"), drDetail.Item("NENCOURSDETAIL"),
                               drDetail.Item("NPROD_CUMUL_VAR_NANAFACTEABLITOT"), drDetail.Item("NANAFACTEABLITOT_MOIS_1"), drDetail.Item("NANAFACTEABLITOT"))

          Case "NTOT_ENCOURS_MOIS_EC"

            sMsg = String.Format("- Variation des encours MOZARIS (FAE / PCA) : {0:c2}" & vbCrLf _
                              & Space(3) & "- Mois M-1 extournés : {1:c2}" & vbCrLf _
                              & Space(3) & "- Mois M : {2:c2}" & vbCrLf _
                              & "-  Variation des encours manuels (FAE / PCA / AAE) : {3:c2}" & vbCrLf _
                              & Space(3) & "- Mois M-1 extournés : {4:c2}" & vbCrLf _
                              & Space(3) & "- Mois M : {5:c2}",
                               drDetail.Item("NENCOURS_MOIS_EC"), drDetail.Item("NMOIS_1_ENCOURS"), drDetail.Item("NENCOURSDETAIL"),
                               drDetail.Item("NPROD_CUMUL_VAR_NANAFACTEABLITOT"), drDetail.Item("NANAFACTEABLITOT_MOIS_1"), drDetail.Item("NANAFACTEABLITOT"))


          Case "NPROJET_CA"

            Dim sqlcmdMsg As New SqlCommand("[api_sp_ReportingAnalytique_ListeCAByCompteAndAnnee]", MozartDatabase.cnxMozart) With {
            .CommandType = CommandType.StoredProcedure
          }
            sqlcmdMsg.Parameters.Add("@NCANNUM", SqlDbType.Int).Value = drDetail.Item("NCANNUM")
            sqlcmdMsg.Parameters.Add("@VSOCIETE", SqlDbType.VarChar).Value = MozartParams.NomSociete
            sqlcmdMsg.Parameters.Add("@MOIS", SqlDbType.Int).Value = mMoisNum
            sqlcmdMsg.Parameters.Add("@ANNEE", SqlDbType.Int).Value = mAnneeNum

            Dim dtData As New DataTable
            dtData.Load(sqlcmdMsg.ExecuteReader)


            sMsg = "Production" & vbCrLf & vbCrLf

            For Each drData As DataRow In dtData.Rows

              sMsg += String.Format("- {0} : {1:c2}" & vbCrLf, drData.Item("ANNEE"), drData.Item("CA"))

            Next


          Case "NPROD_CUMUL_ENCOURS_PROD"

            sMsg = String.Format("- Encours MOZARIS mois M (FAE/PCA)  : {0:c2}" + vbCrLf +
                               "- Encours manuel mois M (FAE / PCA / AAE) : {1:c2}",
                                drDetail.Item("NENCOURSDETAIL"), drDetail.Item("NPROD_CUMUL_VAR_NANAFACTEABLITOT"))

          Case "NRESULTANA_MOIS_EC"

            Dim n_COEFF_FG As Decimal
            If Decimal.TryParse(sCOEFF_FRAIS_GENERAUX, n_COEFF_FG) Then
              n_COEFF_FG = Decimal.Parse(sCOEFF_FRAIS_GENERAUX)
            Else
              n_COEFF_FG = 0
            End If

            sMsg = String.Format("- Résultat comptable : {0:c2}" + vbCrLf +
                               "- Frais généraux : {1:c2}",
                                (drDetail.Item("NRESULTANA_MOIS_EC") + (drDetail.Item("NTOT_CA_MOIS_EC") * (n_COEFF_FG / 100))), (drDetail.Item("NTOT_CA_MOIS_EC") * (n_COEFF_FG / 100)) * (-1))


          Case "NKPICUMULMOIS", "NKPIMOISPREC", "NKPIANNEEPREC", "NKPIMOISENCOURS"

            sMsg = buildKPINoteDetails(e, drDetail.Item("NCANNUM"))

        End Select

        If sMsg <> "" Then
          MessageBox.Show(sMsg, My.Resources.TabSyntheseCompta_frmSynthCompta_detail, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

      End If

    End If

  End Sub

  Private Function buildKPINoteDetails(ByVal e As RowCellClickEventArgs, pNumCan As Integer) As String
    Dim lSql As String = ""

    Try
      Select Case e.Column.FieldName
        Case "NKPICUMULMOIS"
          lSql = $"SELECT SUM(NNOTE_DEPAST) / {mMoisNum} AS NNOTE_DEPAST, SUM(NNOTE_DEPRAP) / {mMoisNum} AS NNOTE_DEPRAP, SUM(NNOTE_DEPMOY) / {mMoisNum} AS NNOTE_DEPMOY,"
          lSql += $" SUM(NNOTE_DEPLEN) / {mMoisNum} As NNOTE_DEPLEN, SUM(NNOTE_DEP) / {mMoisNum} As NNOTE_DEP,"
          lSql += $" SUM(NNOTE_PREV) / {mMoisNum} As NNOTE_PREV, SUM(NNOTE_DEVIS)  / {mMoisNum} As NNOTE_DEVIS, SUM(NNOTE_RESOLUTION ) / {mMoisNum} As NNOTE_RESOLUTION,"
          lSql += $" SUM(NNOTE_ENQUETEQUAL)  / {mMoisNum} As NNOTE_ENQUETEQUAL, SUM(NNOTE_PDP)  / {mMoisNum} As NNOTE_PDP, SUM(NNOTE_GLOBALE ) / {mMoisNum} As NNOTE_GLOBALE"
          lSql += $" FROM TREPORT_ANA INNER JOIN TREPORT_ANA_T1 On TREPORT_ANA_T1.NREPORT_ANA_ID = TREPORT_ANA.NREPORT_ANA_ID"
          lSql += $" INNER JOIN TKPI_HISTO On TKPI_HISTO.NCPTE_ANA = TREPORT_ANA_T1.NCANNUM And MONTH(TKPI_HISTO.DDATE_HISTO) <= {mMoisNum} And YEAR(TKPI_HISTO.DDATE_HISTO) = {mAnneeNum}"
          lSql += $" INNER JOIN TCLI On TCLI.NCLINUM = TKPI_HISTO.NCLINUM And TCLI.VSOCIETE = '{MozartParams.NomSociete}'"
          lSql += $" WHERE TREPORT_ANA.NREPORT_ANA_MOIS = {mMoisNum} AND TREPORT_ANA.NREPORT_ANA_ANEE = {mAnneeNum} AND TREPORT_ANA.VSOCIETE = '{MozartParams.NomSociete}'"
          lSql += $" AND TREPORT_ANA_T1.NCANNUM = {pNumCan} GROUP BY TREPORT_ANA_T1.NCANNUM"

        Case "NKPIMOISPREC"
          Dim sMoisPrec As Date = DateAdd(DateInterval.Month, -1, New DateTime(mAnneeNum, mMoisNum, 1))
          Dim iMoisPrec As Integer = sMoisPrec.Month()
          Dim iAnneePrec As Integer = sMoisPrec.Year()

          lSql = $"SELECT SUM(NNOTE_DEPAST) / {iMoisPrec} AS NNOTE_DEPAST, SUM(NNOTE_DEPRAP) / {iMoisPrec} AS NNOTE_DEPRAP, SUM(NNOTE_DEPMOY) / {iMoisPrec} AS NNOTE_DEPMOY,"
          lSql += $" SUM(NNOTE_DEPLEN) / {iMoisPrec} AS NNOTE_DEPLEN,"
          lSql += $" SUM(NNOTE_DEP) / {iMoisPrec} As NNOTE_DEP, SUM(NNOTE_PREV) / {iMoisPrec} As NNOTE_PREV, SUM(NNOTE_DEVIS) / {iMoisPrec} NNOTE_DEVIS,"
          lSql += $" SUM(NNOTE_RESOLUTION ) / {iMoisPrec} AS NNOTE_RESOLUTION, SUM(NNOTE_ENQUETEQUAL) / {iMoisPrec} AS NNOTE_ENQUETEQUAL, SUM(NNOTE_PDP) / {iMoisPrec} AS NNOTE_PDP,"
          lSql += $" SUM(NNOTE_GLOBALE) / {iMoisPrec} AS NNOTE_GLOBALE"
          lSql += $" FROM TREPORT_ANA INNER JOIN TREPORT_ANA_T1 On TREPORT_ANA_T1.NREPORT_ANA_ID = TREPORT_ANA.NREPORT_ANA_ID"
          lSql += $" INNER JOIN TKPI_HISTO On TKPI_HISTO.NCPTE_ANA = TREPORT_ANA_T1.NCANNUM And YEAR(TKPI_HISTO.DDATE_HISTO) = {iAnneePrec} AND TKPI_HISTO.DDATE_HISTO <= CAST('{sMoisPrec}' AS DATE)"
          lSql += $" INNER JOIN TCLI On TCLI.NCLINUM = TKPI_HISTO.NCLINUM And TCLI.VSOCIETE = '{MozartParams.NomSociete}'"
          lSql += $" WHERE TREPORT_ANA.NREPORT_ANA_MOIS = {mMoisNum} AND TREPORT_ANA.NREPORT_ANA_ANEE = {mAnneeNum} AND TREPORT_ANA.VSOCIETE = '{MozartParams.NomSociete}'"
          lSql += $" AND TREPORT_ANA_T1.NCANNUM = {pNumCan} GROUP BY TREPORT_ANA_T1.NCANNUM"

        Case "NKPIANNEEPREC"
          lSql = $"SELECT SUM(NNOTE_DEPAST) / 12 AS NNOTE_DEPAST, SUM(NNOTE_DEPRAP) / 12 AS NNOTE_DEPRAP, SUM(NNOTE_DEPMOY) / 12 AS NNOTE_DEPMOY, SUM(NNOTE_DEPLEN ) / 12 AS NNOTE_DEPLEN,"
          lSql += $" SUM(NNOTE_DEP) /12 AS NNOTE_DEP, SUM(NNOTE_PREV) / 12 AS NNOTE_PREV, SUM(NNOTE_DEVIS) / 12 AS NNOTE_DEVIS,"
          lSql += $" SUM(NNOTE_RESOLUTION ) / 12 AS NNOTE_RESOLUTION, SUM(NNOTE_ENQUETEQUAL) / 12 AS NNOTE_ENQUETEQUAL, SUM(NNOTE_PDP) / 12 AS NNOTE_PDP, SUM(NNOTE_GLOBALE ) / 12 AS NNOTE_GLOBALE"
          lSql += $" FROM TREPORT_ANA INNER JOIN TREPORT_ANA_T1 ON TREPORT_ANA_T1.NREPORT_ANA_ID = TREPORT_ANA.NREPORT_ANA_ID"
          lSql += $" INNER JOIN TKPI_HISTO ON TKPI_HISTO.NCPTE_ANA = TREPORT_ANA_T1.NCANNUM AND YEAR(TKPI_HISTO.DDATE_HISTO) = {mAnneeNum - 1}"
          lSql += $" INNER JOIN TCLI ON TCLI.NCLINUM = TKPI_HISTO.NCLINUM AND TCLI.VSOCIETE = '{MozartParams.NomSociete}'"
          lSql += $" WHERE TREPORT_ANA.NREPORT_ANA_MOIS = {mMoisNum} AND TREPORT_ANA.NREPORT_ANA_ANEE = {mAnneeNum} AND TREPORT_ANA.VSOCIETE = '{MozartParams.NomSociete}'"
          lSql += $" AND TREPORT_ANA_T1.NCANNUM = {pNumCan} GROUP BY TREPORT_ANA_T1.NCANNUM"

        Case "NKPIMOISENCOURS"
          ' Fait en dessous
        Case Else
          Return ""
      End Select

      Dim sReturnValue As String
      Dim lRow As DataRow

      If e.Column.FieldName = "NKPIMOISENCOURS" Then
        lRow = AdvBGVBilanAna.GetDataRow(e.RowHandle)
      Else
        Dim lDt As DataTable = MozartDatabase.GetDataTable(lSql)
        lRow = lDt.Rows(0)
      End If

      sReturnValue = $" - Dépannage Astreinte : {lRow.Item("NNOTE_DEPAST")} / 5{vbCrLf}"
      sReturnValue += $" - Dépannage Rapide : {lRow.Item("NNOTE_DEPRAP")} / 10{vbCrLf}"
      sReturnValue += $" - Dépannage Moyen : {lRow.Item("NNOTE_DEPMOY")} / 10{vbCrLf}"
      sReturnValue += $" - Dépannage Lent : {lRow.Item("NNOTE_DEPLEN")} / 5{vbCrLf}"
      sReturnValue += $" - Préventif : {lRow.Item("NNOTE_PREV")} / 20{vbCrLf}"
      sReturnValue += $" - Devis : {lRow.Item("NNOTE_DEVIS")} / 15{vbCrLf}"
      sReturnValue += $" - Résolution : {lRow.Item("NNOTE_RESOLUTION")} / 15{vbCrLf}"
      sReturnValue += $" - Enquête Qualité : {lRow.Item("NNOTE_ENQUETEQUAL")} / 10{vbCrLf}"
      sReturnValue += $" - PDP : {lRow.Item("NNOTE_PDP")} / 10"

      Return sReturnValue

    Catch ex As Exception
      Return ""
    End Try

  End Function

  '*******************************************************************************************************************************************************
  'Cette fonction permet d afficher les lignes qui ont 2 chaff sur un compte analytique en jaune
  '*******************************************************************************************************************************************************
  Private Sub AdvBGVBilanAna_RowStyle(ByVal sender As Object, ByVal e As RowStyleEventArgs) Handles AdvBGVBilanAna.RowStyle
    If e.RowHandle < 0 Then Exit Sub

    For Each oDTRNCANNUM As DataRow In dtNCANNUMDoublon.Rows
      If oDTRNCANNUM.Item("NCANNUM") = AdvBGVBilanAna.GetDataRow(e.RowHandle).Item("NCANNUM") Then
        e.Appearance.BackColor = Color.Yellow
      End If
    Next

  End Sub

  '********************************************************************************************************
  'Cette fonction permet de customizer le tableau avnat export
  '********************************************************************************************************
  Private Sub CustomizeForExport(ByVal p_iOnglet As Int32, ByVal p_iSensExport As Int32)

    Dim lFontSize As Single

    If p_iSensExport = 0 Then
      lFontSize = 6
    Else
      lFontSize = 8.25
    End If

    Select Case p_iOnglet
      Case 0
        BGCSectAna.AppearanceCell.Font = New Font(BGCSectAna.AppearanceCell.Font.Name, lFontSize, FontStyle.Bold)

        BGCOD.AppearanceCell.Font = New Font(BGCOD.AppearanceCell.Font.Name, lFontSize, FontStyle.Bold)

        BGCENCOURS.AppearanceCell.Font = New Font(BGCENCOURS.AppearanceCell.Font.Name, lFontSize, FontStyle.Bold)

        BGCENCOURSMANU.AppearanceCell.Font = New Font(BGCENCOURSMANU.AppearanceCell.Font.Name, lFontSize, FontStyle.Bold)
        BGCResultAjust.AppearanceCell.Font = New Font(BGCResultAjust.AppearanceCell.Font.Name, lFontSize, FontStyle.Bold)
        BGCPourcCA.AppearanceCell.Font = New Font(BGCPourcCA.AppearanceCell.Font.Name, lFontSize, FontStyle.Bold)
        BGCPourcRapportMoisPrec.AppearanceCell.Font = New Font(BGCPourcRapportMoisPrec.AppearanceCell.Font.Name, lFontSize, FontStyle.Bold)
        BGCRapportAnneePrec.AppearanceCell.Font = New Font(BGCRapportAnneePrec.AppearanceCell.Font.Name, lFontSize, FontStyle.Bold)

      Case 1
        BGColBalAnaNPOURCDEPREEL.AppearanceCell.Font = New Font(BGCENCOURSMANU.AppearanceCell.Font.Name, lFontSize, FontStyle.Bold)
        BGColBalAnaTOTREAJUST.AppearanceCell.Font = New Font(BGColBalAnaTOTREAJUST.AppearanceCell.Font.Name, lFontSize, FontStyle.Bold)
        BGColBalAnaDIFFPOURCANNEE.AppearanceCell.Font = New Font(BGColBalAnaDIFFPOURCANNEE.AppearanceCell.Font.Name, lFontSize, FontStyle.Bold)

      Case 2
        BGColNDIFFPOURCCALASTMOIS.AppearanceCell.Font = New Font(BGColNDIFFPOURCCALASTMOIS.AppearanceCell.Font.Name, lFontSize, FontStyle.Bold)
        BGColNDIFFPOURCCALASTYEAR.AppearanceCell.Font = New Font(BGColNDIFFPOURCCALASTYEAR.AppearanceCell.Font.Name, lFontSize, FontStyle.Bold)

    End Select

  End Sub

  Private Sub AdvBGVBilanAnaSoc_CustomDrawFooterCell(sender As Object, e As FooterCellCustomDrawEventArgs) Handles AdvBGVBilanAnaSoc.CustomDrawFooterCell
    If e.Column.FieldName = "POURCANNEE" Then
      e.Info.DisplayText = "1 %"
    End If
  End Sub

  Private Sub AdvBGVBilanAnaSoc_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles AdvBGVBilanAnaSoc.RowCellClick

    If e.Button <> MouseButtons.Right Or e.RowHandle <> -1 Then
      Exit Sub
    End If

    Dim sMsg As String = ""

    Dim drDetail As DataRow = AdvBGVBilanAnaSoc.GetDataRow(e.RowHandle)

    If drDetail Is Nothing Then
      Exit Sub
    End If

    Select Case e.Column.FieldName
      Case "NSOLDE"
        sMsg = String.Format(My.Resources.TabSyntheseCompta_frmSynthCompta_msg_sect_taux_horaire_part1 & vbCrLf & My.Resources.TabSyntheseCompta_frmSynthCompta_msg_sect_taux_horaire_part2 & vbCrLf & My.Resources.TabSyntheseCompta_frmSynthCompta_msg_sect_taux_horaire_part3, drDetail.Item("AJUSTE_TX_HOR"), drDetail.Item("NSOLDE") - drDetail.Item("AJUSTE_TX_HOR"), drDetail.Item("NSOLDE"))

      Case "TOTREAJUST"
        sMsg = String.Format("- Dont encours MOZARIS : {0:c2}", drDetail.Item("NAJUSTE"))

    End Select

    MessageBox.Show(sMsg, My.Resources.TabSyntheseCompta_frmSynthCompta_detail, MessageBoxButtons.OK, MessageBoxIcon.Information)

  End Sub

  Private Sub AdvBGVBilanAnaSoc_CustomDrawGroupRow(sender As Object, e As RowObjectCustomDrawEventArgs) Handles AdvBGVBilanAnaSoc.CustomDrawGroupRow
    Dim view As GridView = TryCast(sender, GridView)
    Dim info As GridGroupRowInfo = TryCast(e.Info, GridGroupRowInfo)

    If info.Column.FieldName = "CCTEANAACTIF" Then

      Select Case view.GetGroupRowValue(e.RowHandle, info.Column).ToString
        Case "O"
          info.GroupText = My.Resources.TabSyntheseCompta_frmSynthCompta_actif
        Case Else
          info.GroupText = My.Resources.TabSyntheseCompta_frmSynthCompta_archivé
      End Select

    End If
  End Sub

  Private Sub BtnGlossaire_Click(sender As Object, e As EventArgs) Handles BtnGlossaire.Click

    MessageBox.Show("Glossaire" & vbCrLf & vbCrLf &
                    "FAE = Facture A Etablir" & vbCrLf &
                     Space(4) & "=> Prestation exécutée avant la date de référence du reporting mais qui n'est pas encore facturé au client" & vbCrLf & vbCrLf &
                    "PCA = Produit Constatés d'Avance" & vbCrLf &
                     Space(4) & "=> Facture établie pour une prestation non exécutée avant la date de référence du reporting" & vbCrLf & vbCrLf &
                    "AAE = Avoir A Etablir" & vbCrLf &
                     Space(4) & "Avoir non établi avant la date de référence du reporting" & vbCrLf & vbCrLf &
                    "FNP = Facture Non Parvenue" & vbCrLf &
                     Space(4) & "=> Facture fournisseur non reçue concernant une prestation exécutée avant la date de référence du reporting" & vbCrLf & vbCrLf &
                    "CCA = Charges Constatés d'Avance" & vbCrLf &
                     Space(4) & "=> Facture fournisseur reçue concernant une prestation non exécutée avant la date de référence du reporting" & vbCrLf & vbCrLf &
                    "AAR = Avoir A Recevoir" & vbCrLf &
                    Space(4) & "=> Avoir fournisseur non reçu avant la date de référence du reporting")

  End Sub

  Private Sub ChkNotVisibleLastReport_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNotVisibleLastReport.CheckedChanged

    'il faut sélectionner un mois et année
    If Not periodSelected(True) Then
      Return
    End If

    Dim sqlcmdupdate As New SqlCommand("api_sp_Reporting_Analytique_SetVisible", MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.StoredProcedure
    }
    sqlcmdupdate.Parameters.Add("@p_mois", SqlDbType.Int).Value = CboMois.SelectedValue
    sqlcmdupdate.Parameters.Add("@p_annee", SqlDbType.Int).Value = CboAnnee.SelectedValue
    sqlcmdupdate.Parameters.Add("@p_vsociete", SqlDbType.VarChar).Value = MozartParams.NomSociete
    sqlcmdupdate.Parameters.Add("@p_visible", SqlDbType.Bit).Value = If(ChkNotVisibleLastReport.CheckState = CheckState.Checked, 0, 1)
    sqlcmdupdate.ExecuteNonQuery()

  End Sub

  Private Sub BtnExportAllXLS_Click(sender As Object, e As EventArgs) Handles BtnExportAllXLS.Click
    'il faut sélectionner un mois et année
    If Not periodSelected(True) Then
      Return
    End If

    SFDSynCompta.FileName = ""
    SFDSynCompta.Filter = "Fichiers EXCEL (*.xlsx)|*.xlsx"
    SFDSynCompta.ShowDialog()

    If SFDSynCompta.FileName <> "" Then

      Dim sFileName As String = SFDSynCompta.FileName.ToLower()

      If XTPBilanCpt.Visible Then

        AdvBGVBilanAna.OptionsPrint.AutoWidth = False

        If File.Exists(sFileName.Insert(sFileName.LastIndexOf(".xlsx"), "_Bilan_par_compte_T1")) Then
          MessageBox.Show("Le fichier existe déjà !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          AdvBGVBilanAna.ExportToXlsx(sFileName.Insert(sFileName.LastIndexOf(".xlsx"), "_Bilan_par_compte_T1"), New XlsxExportOptionsEx() With {.SheetName = "Bilan par compte (T1)", .ExportType = DevExpress.Export.ExportType.WYSIWYG})
        End If

      End If

      If XTP_Ind_Direct.Visible Then

        ABGV_Indic_Direct.OptionsPrint.AutoWidth = False

        If File.Exists(sFileName.Insert(sFileName.LastIndexOf(".xlsx"), "_Indicateurs_Direction_T4")) Then
          MessageBox.Show("Le fichier existe déjà !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          ABGV_Indic_Direct.ExportToXlsx(sFileName.Insert(sFileName.LastIndexOf(".xlsx"), "_Indicateurs_Direction_T4"), New XlsxExportOptionsEx() With {.SheetName = "Indicateurs Direction (T4)", .ExportType = DevExpress.Export.ExportType.WYSIWYG})
        End If

      End If

      If XTPBalanceAna.Visible Then

        AdvBGVBilanAnaSoc.OptionsPrint.AutoWidth = False

        If File.Exists(sFileName.Insert(sFileName.LastIndexOf(".xlsx"), "_Bilan_frais_généraux_T2")) Then
          MessageBox.Show("Le fichier existe déjà !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          AdvBGVBilanAnaSoc.ExportToXlsx(sFileName.Insert(sFileName.LastIndexOf(".xlsx"), "_Bilan_frais_généraux_T2"), New XlsxExportOptionsEx() With {.SheetName = "Bilan frais généraux (T2)", .ExportType = DevExpress.Export.ExportType.WYSIWYG})
        End If

      End If

      If XTPREX.Visible Then

        AdvBandedGVAnaREX.OptionsPrint.AutoWidth = False

        If File.Exists(sFileName.Insert(sFileName.LastIndexOf(".xlsx"), "_Résultats_T3")) Then
          MessageBox.Show("Le fichier existe déjà !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          AdvBandedGVAnaREX.ExportToXlsx(sFileName.Insert(sFileName.LastIndexOf(".xlsx"), "_Résultats_T3"), New XlsxExportOptionsEx() With {.SheetName = "Résultats (T3)", .ExportType = DevExpress.Export.ExportType.WYSIWYG})
        End If

      End If

      MessageBox.Show("Exportation des onglets terminée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End If

  End Sub

  Private Sub CboMois_SelectedIndexChanged(sender As Object, e As EventArgs)
    If CboMois.SelectedValue <> 0 Then  'mois sélectionné

      RemoveHandler CboAnnee.SelectedIndexChanged, AddressOf CboAnnee_SelectedIndexChanged

      'si année selectionnée
      If CboAnnee.SelectedValue IsNot Nothing AndAlso CboAnnee.SelectedValue.ToString <> "999999" Then
        Dim saveannee As Int16 = CboAnnee.SelectedValue
        CboAnnee.DataSource = MozartDatabase.GetDataTable($"EXEC api_sp_Reporting_Analytique_ListeAnneeByMois {CboMois.SelectedValue}, '{MozartParams.NomSociete}'")
        CboAnnee.SelectedValue = saveannee
      Else
        CboAnnee.DataSource = MozartDatabase.GetDataTable($"EXEC api_sp_Reporting_Analytique_ListeAnneeByMois 0, '{MozartParams.NomSociete}'")
      End If

      AddHandler CboAnnee.SelectedIndexChanged, AddressOf CboAnnee_SelectedIndexChanged
    ElseIf CboMois.SelectedValue = 0 Then  'mois vide

      RemoveHandler CboAnnee.SelectedIndexChanged, AddressOf CboAnnee_SelectedIndexChanged
      'si année sélectionné, alors on recharge tout en gardant l'année
      If CboAnnee.SelectedValue IsNot Nothing AndAlso CboAnnee.SelectedValue.ToString <> "999999" Then
        Dim saveannee As Int16 = CboAnnee.SelectedValue
        CboAnnee.DataSource = MozartDatabase.GetDataTable($"EXEC api_sp_Reporting_Analytique_ListeAnneeByMois 0, '{MozartParams.NomSociete}'")
        CboAnnee.SelectedValue = saveannee
      Else
        CboAnnee.DataSource = MozartDatabase.GetDataTable($"EXEC api_sp_Reporting_Analytique_ListeAnneeByMois 0, '{MozartParams.NomSociete}'")
      End If

      AddHandler CboAnnee.SelectedIndexChanged, AddressOf CboAnnee_SelectedIndexChanged
    End If

    LoadReportingVisible()
  End Sub

  Private Sub CboAnnee_SelectedIndexChanged(sender As Object, e As EventArgs)
    If CboAnnee.SelectedValue <> 0 Then  'année sélectionnée

      RemoveHandler CboMois.SelectedIndexChanged, AddressOf CboMois_SelectedIndexChanged

      'si mois selectionnée
      If CboMois.SelectedValue IsNot Nothing AndAlso CboMois.SelectedValue.ToString <> "999999" Then
        Dim savemois As Int16 = CboMois.SelectedValue
        CboMois.DataSource = MozartDatabase.GetDataTable($"EXEC api_sp_Reporting_Analytique_ListeMoisByAnnee {CboAnnee.SelectedValue}, '{MozartParams.NomSociete}'")
        CboMois.SelectedValue = savemois
      Else
        CboMois.DataSource = MozartDatabase.GetDataTable($"EXEC api_sp_Reporting_Analytique_ListeMoisByAnnee 0, '{MozartParams.NomSociete}'")
      End If

      AddHandler CboMois.SelectedIndexChanged, AddressOf CboMois_SelectedIndexChanged

    ElseIf CboAnnee.SelectedValue = 0 Then  'année vide

      RemoveHandler CboMois.SelectedIndexChanged, AddressOf CboMois_SelectedIndexChanged

      'si mois sélectionné, alors on recharge tout en gardant le mois
      If CboMois.SelectedValue IsNot Nothing AndAlso CboMois.SelectedValue.ToString <> "999999" Then
        Dim savemois As Int16 = CboMois.SelectedValue
        CboMois.DataSource = MozartDatabase.GetDataTable($"EXEC api_sp_Reporting_Analytique_ListeMoisByAnnee 0, '{MozartParams.NomSociete}'")
        CboMois.SelectedValue = savemois
      Else
        CboMois.DataSource = MozartDatabase.GetDataTable($"EXEC api_sp_Reporting_Analytique_ListeMoisByAnnee 0, '{MozartParams.NomSociete}'")
      End If

      AddHandler CboMois.SelectedIndexChanged, AddressOf CboMois_SelectedIndexChanged
    End If

    LoadReportingVisible()
  End Sub

  Private Sub cmdEvolKPI_Click(sender As Object, e As EventArgs) Handles cmdEvolKPI.Click
    Try
      Cursor = Cursors.WaitCursor

      Dim lFrmKPIEvolution As New frmKPIEvolution()
      lFrmKPIEvolution.ShowDialog()

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    Finally
      Cursor = Cursors.Default
    End Try
  End Sub

End Class
