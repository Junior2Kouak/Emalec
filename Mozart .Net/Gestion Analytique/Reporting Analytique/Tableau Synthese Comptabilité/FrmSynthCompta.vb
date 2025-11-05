Imports System.Data.SqlClient
Imports DevExpress.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.BandedGrid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports MozartLib

Public Class FrmSynthCompta

  Dim TotAjust As Int32
  Dim TotCA As Int32
  Dim TotCharge As Int32

  Dim dtSynthCompta As DataTable
  Dim dtNCANNUMDoublon As DataTable
  Dim dtBalanceAna As DataTable
  Dim dtAnaREX As DataTable


  Private Sub FrmSynthCompta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      Dim DateMaxANAHISTO As Nullable(Of DateTime)

      'init boutons
      Initboutons(Me)

      TotAjust = 0
      TotCA = 0
      TotCharge = 0

      'on rempli les combo mois et année
      CboMois.DisplayMember = "VALUE"
      CboMois.ValueMember = "ID"
      CboMois.DataSource = MozartDatabase.GetDataTable($"SELECT MONTH(DDATCRE) AS ID, MONTH(DDATCRE) AS VALUE FROM TANAHISTO WHERE YEAR(DDATCRE) > 2012 AND VSOCIETE = '{MozartParams.NomSociete}' GROUP BY MONTH(DDATCRE) ORDER BY MONTH(DDATCRE)")

      CboAnnee.ValueMember = "ID"
      CboAnnee.DisplayMember = "VALUE"
      CboAnnee.DataSource = MozartDatabase.GetDataTable($"SELECT YEAR(DDATCRE) AS ID, YEAR(DDATCRE) AS VALUE FROM TANAHISTO WHERE YEAR(DDATCRE) > 2012 AND VSOCIETE = '{MozartParams.NomSociete}' GROUP BY YEAR(DDATCRE) ORDER BY YEAR(DDATCRE) DESC")

      'sélection automatique de la date max
      Dim sqlcmdauto As New SqlCommand($"select MAX(DDATCRE) AS DDATEMAX FROM TANAHISTO WHERE VSOCIETE = '{MozartParams.NomSociete}'", MozartDatabase.cnxMozart)
      Dim drauto As SqlDataReader = sqlcmdauto.ExecuteReader
      If drauto.HasRows Then
        drauto.Read()
        DateMaxANAHISTO = Convert.ToDateTime(drauto("DDATEMAX"))
      End If
      drauto.Close()

      If IsDBNull(DateMaxANAHISTO) = False Then

        CboMois.SelectedValue = DatePart(DateInterval.Month, CType(DateMaxANAHISTO, DateTime))
        CboAnnee.SelectedValue = DatePart(DateInterval.Year, CType(DateMaxANAHISTO, DateTime))

        If RechercheDroitMenu(625) Then

          'affichage auto du max date
          LoadDataByChefGroupe()

        ElseIf RechercheDroitMenu(369) Then

          'affichage auto du max date
          LoadData()

        Else

          XTPBilanCpt.PageVisible = False

        End If

      End If

      'gestion de l affichage selon le droit chef de groupe
      If RechercheDroitMenu(625) Then

        'on renomme l'onglet
        XTPBilanCpt.Text = "Bilan par compte du chef de groupe"

        'pour les chef de groupe on cahce automatiquement les autres onglets
        XTPBalanceAna.PageVisible = False
        XTPREX.PageVisible = False

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.TabSyntheseCompta_frmSynthCompta_sub + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub LoadData()

    Dim iNumMois As Integer = CboMois.SelectedValue
    Dim iNumAnnee As Integer = CboAnnee.SelectedValue

    'initialise les champs ##
    GBMOISPREC.Caption = "RAPPEL #MOIS#/#ANNEE#"
    GBANNEEPREC.Caption = "RAPPEL #ANNEE#"
    GBBALANNEEPREC.Caption = "RAPPEL #ANNEE#"

    'titre et label
    Dim sDatePrec As Date = DateAdd(DateInterval.Month, -1, CDate("01/" + iNumMois.ToString + "/" + iNumAnnee.ToString))

    GBANNEEPREC.Caption = GBANNEEPREC.Caption.Replace("#ANNEE#", (iNumAnnee - 1).ToString)
    GBBALANNEEPREC.Caption = GBBALANNEEPREC.Caption.Replace("#ANNEE#", (iNumAnnee - 1).ToString)
    GBMOISPREC.Caption = GBMOISPREC.Caption.Replace("#MOIS#", DatePart(DateInterval.Month, sDatePrec).ToString).Replace("#ANNEE#", DatePart(DateInterval.Year, sDatePrec).ToString)

    'data tableau
    dtSynthCompta = New DataTable
    dtBalanceAna = New DataTable
    dtNCANNUMDoublon = New DataTable

    If iNumAnnee >= 2018 Then

      dtSynthCompta = MozartDatabase.GetDataTable($"api_sp_TableauSynthComptaSamsic {iNumMois}, {iNumAnnee}, '{MozartParams.NomSociete}'")
      dtBalanceAna = MozartDatabase.GetDataTable($"api_sp_TableauSynthComptaBalanceSamsic {iNumMois}, {iNumAnnee}, '{MozartParams.NomSociete}'")

    Else

      dtSynthCompta = MozartDatabase.GetDataTable($"api_sp_TableauSynthCompta {iNumMois}, {iNumAnnee}, '{MozartParams.NomSociete}'")
      dtBalanceAna = MozartDatabase.GetDataTable($"api_sp_TableauSynthComptaBalance {iNumMois}, {iNumAnnee}, '{MozartParams.NomSociete}'")

    End If

    dtNCANNUMDoublon = ReturnDTDoublonsChaffOnCAN()

    GCSynthCompta.DataSource = dtSynthCompta
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

  End Sub

  Private Sub LoadDataByChefGroupe()

    Dim iNumMois As Integer = CboMois.SelectedValue
    Dim iNumAnnee As Integer = CboAnnee.SelectedValue

    'initialise les champs ##
    GBMOISPREC.Caption = "RAPPEL #MOIS#/#ANNEE#"
    GBANNEEPREC.Caption = "RAPPEL #ANNEE#"
    GBBALANNEEPREC.Caption = "RAPPEL #ANNEE#"

    'titre et label
    Dim sDatePrec As Date = DateAdd(DateInterval.Month, -1, CDate("01/" + iNumMois.ToString + "/" + iNumAnnee.ToString))

    GBANNEEPREC.Caption = GBANNEEPREC.Caption.Replace("#ANNEE#", (iNumAnnee - 1).ToString)
    GBBALANNEEPREC.Caption = GBBALANNEEPREC.Caption.Replace("#ANNEE#", (iNumAnnee - 1).ToString)
    GBMOISPREC.Caption = GBMOISPREC.Caption.Replace("#MOIS#", DatePart(DateInterval.Month, sDatePrec).ToString).Replace("#ANNEE#", DatePart(DateInterval.Year, sDatePrec).ToString)

    'data tableau
    dtSynthCompta = New DataTable
    dtNCANNUMDoublon = New DataTable

    If iNumAnnee >= 2018 Then
      dtSynthCompta = MozartDatabase.GetDataTable($"api_sp_TableauSynthComptaSamsicByChefGroupe {iNumMois}, {iNumAnnee}, '{MozartParams.NomSociete}'")
    Else
      dtSynthCompta = MozartDatabase.GetDataTable($"api_sp_TableauSynthComptaByChefGroupe {iNumMois}, {iNumAnnee}, '{MozartParams.NomSociete}'")
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

  End Sub

  Private Sub AdvBGVBilanAna_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles AdvBGVBilanAna.CustomColumnDisplayText

    If e.Column.FieldName = "DPVRECEPT" Then

      If AdvBGVBilanAna.GetListSourceRowCellValue(e.ListSourceRowIndex, BGCCTYPECTE) = "T" Then

        If IsDBNull(e.Value) = True Then
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
        Case "BGCPourcChargeStruct"
          TotCharge = 0
          TotCA = 0
      End Select

    End If

    If e.SummaryProcess = CustomSummaryProcess.Calculate Then

      Select Case summaryID
        Case "" ' The total summary calculated against the 'UnitPrice' column. 
                    'e.TotalValue = TotAjust / TotCA  
        Case "BGCPourcCA"
          TotAjust = TotAjust + Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "RESULTAJUST"))
          TotCA = TotCA + Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "NCASYNCOMPTA"))
        Case "BGCPourcChargeStruct"
          TotCharge = TotCharge + Convert.ToInt32(View.GetDataRow(e.RowHandle).Item("NCHARGEDETAIL"))
          TotCA = TotCA + Convert.ToInt32(View.GetRowCellValue(e.RowHandle, "NCASYNCOMPTA"))
      End Select

    End If

    If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

      Select Case summaryID
        Case "BGCPourcCA" ' The total summary calculated against the 'UnitPrice' column.
          If TotCA = 0 Then
            e.TotalValue = "0 %"
          Else
            e.TotalValue = Convert.ToDecimal((TotAjust / TotCA) * 100).ToString("N2") + " %"
          End If
        Case "BGCPourcChargeStruct" ' The total summary calculated against the 'UnitPrice' column.
          If TotCA = 0 Then
            e.TotalValue = "0 %"
          Else

            If CboAnnee.SelectedValue >= 2018 Then
              e.TotalValue = Convert.ToDecimal(((TotCharge * (2.25 / 1.74)) / TotCA) * 100).ToString("N2") + " %"
            Else
              e.TotalValue = Convert.ToDecimal((TotCharge / TotCA) * 100).ToString("N2") + " %"
            End If

          End If

      End Select

    End If

  End Sub

  Private Sub LoadDataAnaREX()

    Try
      Dim iNumMois As Integer = CboMois.SelectedValue
      Dim iNumAnnee As Integer = CboAnnee.SelectedValue

      dtAnaREX = New DataTable

      dtAnaREX = MozartDatabase.GetDataTable($"exec api_sp_TableauSynthComptaREX {iNumMois}, {iNumAnnee}, '{MozartParams.NomSociete}'")

      GCAnaREX.DataSource = dtAnaREX

    Catch ex As Exception
      MessageBox.Show(My.Resources.TabSyntheseCompta_frmSynthCompta_sub2 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub BtnExportXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportXLS.Click

    If CboMois.SelectedValue Is Nothing Or CboAnnee.SelectedValue Is Nothing Then Return

    SFDSynCompta.FileName = ""

    'on exprote selon l ongelt sélectionner
    Select Case XTBCSynthCompta.SelectedTabPageIndex

      Case 0

        SFDSynCompta.Filter = "Fichiers EXCEL (*.xls)|*.xls"
        SFDSynCompta.ShowDialog()

        If SFDSynCompta.FileName <> "" Then

          AdvBGVBilanAna.OptionsPrint.AutoWidth = False
          AdvBGVBilanAna.ExportToXls(SFDSynCompta.FileName)

        End If

      Case 1

        SFDSynCompta.Filter = "Fichiers EXCEL (*.xls)|*.xls"
        SFDSynCompta.ShowDialog()

        If SFDSynCompta.FileName <> "" Then

          AdvBGVBilanAnaSoc.OptionsPrint.AutoWidth = False
          AdvBGVBilanAnaSoc.ExportToXls(SFDSynCompta.FileName)

        End If

      Case 2

        SFDSynCompta.Filter = "Fichiers EXCEL (*.xls)|*.xls"
        SFDSynCompta.ShowDialog()

        If SFDSynCompta.FileName <> "" Then

          AdvBandedGVAnaREX.OptionsPrint.AutoWidth = False
          AdvBandedGVAnaREX.ExportToXls(SFDSynCompta.FileName)

        End If

      Case Else

        MessageBox.Show("Exportation impossible !", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Select

  End Sub

  Private Sub FrmSynthCompta_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged

    XTBCSynthCompta.Size = New Size(Me.Size.Width - XTBCSynthCompta.Location.X - GrpActions.Location.X, Me.Size.Height - (XTBCSynthCompta.Location.Y * 2) - 40)

  End Sub

  Private Sub BtnValid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnValid.Click

    If CboMois.SelectedValue Is Nothing Or CboAnnee.SelectedValue Is Nothing Then Return

    Try

      Me.Cursor = Cursors.WaitCursor

      'init
      GCSynthCompta.DataSource = Nothing
      GCBalanceAna.DataSource = Nothing
      GCAnaREX.DataSource = Nothing

      Dim DataExist As Integer

      Dim sqlcmdVerifdata As New SqlCommand("api_sp_VerifDataAnalytique", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      'on passse le 1er de chaque mois en guise test pour le mois et l'année
      sqlcmdVerifdata.Parameters.Add("@p_dateverif", SqlDbType.DateTime)
      sqlcmdVerifdata.Parameters("@p_dateverif").Value = "01/" + CboMois.SelectedValue.ToString + "/" + CboAnnee.SelectedValue.ToString

      Dim drVerif As SqlDataReader = sqlcmdVerifdata.ExecuteReader
      drVerif.Read()
      DataExist = drVerif("NBEXIST")
      drVerif.Close()

      If DataExist = 0 Then
        MessageBox.Show("Il n'existe pas de données sur cette période !", "Pas de données", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      Else

        If RechercheDroitMenu(625) Then
          'affichage auto du max date
          LoadDataByChefGroupe()
        ElseIf RechercheDroitMenu(369) Then
          LoadData()
        Else
          XTPBilanCpt.PageVisible = False
        End If


      End If

    Catch ex As Exception
      MessageBox.Show("Sub BtnValid_Click dans FrmSynthCompta : " + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally

      Me.Cursor = Cursors.Default

    End Try

  End Sub

  Private Sub BtnExportPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportPDF.Click

    If CboMois.SelectedValue Is Nothing Or CboAnnee.SelectedValue Is Nothing Then Return

    SFDSynCompta.FileName = ""

    'on exprote selon l ongelt sélectionner
    Select Case XTBCSynthCompta.SelectedTabPageIndex

      Case 0

        SFDSynCompta.Filter = "Fichiers PDF (*.pdf)|*.pdf"
        SFDSynCompta.ShowDialog()

        If SFDSynCompta.FileName <> "" Then

          CustomizeForExport(XTBCSynthCompta.SelectedTabPageIndex, 0)

          AdvBGVBilanAna.OptionsPrint.AutoWidth = True

          Dim ps As New DevExpress.XtraPrinting.PrintingSystemBase()
          Dim link As DevExpress.XtraPrintingLinks.PrintableComponentLinkBase = New DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(ps)

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

      Case 1

        SFDSynCompta.Filter = "Fichiers PDF (*.pdf)|*.pdf"
        SFDSynCompta.ShowDialog()

        If SFDSynCompta.FileName <> "" Then

          CustomizeForExport(XTBCSynthCompta.SelectedTabPageIndex, 0)

          AdvBGVBilanAnaSoc.OptionsPrint.AutoWidth = True

          Dim ps As New DevExpress.XtraPrinting.PrintingSystemBase()
          Dim link As DevExpress.XtraPrintingLinks.PrintableComponentLinkBase = New DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(ps)
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

      Case 2

        SFDSynCompta.Filter = "Fichiers PDF (*.pdf)|*.pdf"
        SFDSynCompta.ShowDialog()

        If SFDSynCompta.FileName <> "" Then

          CustomizeForExport(XTBCSynthCompta.SelectedTabPageIndex, 0)

          AdvBandedGVAnaREX.OptionsPrint.AutoWidth = True

          Dim ps As New DevExpress.XtraPrinting.PrintingSystemBase()
          Dim link As DevExpress.XtraPrintingLinks.PrintableComponentLinkBase = New DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(ps)
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

      Case Else

        MessageBox.Show(My.Resources.TabSyntheseCompta_frmSynthCompta_export_impo, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Select

  End Sub

  Private Sub PrintableComponentLink_CreateReportHeaderArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs)

    Dim brick As DevExpress.XtraPrinting.TextBrick

    brick = e.Graph.DrawString(String.Format("{0} {1} {2}", My.Resources.TabSyntheseCompta_frmSynthCompta_Titre_PinrtDoc_Header, MonthName(Convert.ToInt32(CboMois.Text)).ToUpper, CboAnnee.Text), Color.Black, New RectangleF(0, 0, 1016, 20), DevExpress.XtraPrinting.BorderSide.None)

    brick.Font = New Font("Arial", 10)

    brick.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)

  End Sub

  Private Sub BtnDepenseAna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDepenseAna.Click

    If CboMois.SelectedValue Is Nothing Or CboAnnee.SelectedValue Is Nothing Then Return

    'test si dépenses existe pour ce mois
    'on vérifie s'il existe des données dans TANAHISTO sur ce mois et cette année
    Dim sqlcmd As New SqlCommand(String.Format("SELECT COUNT(NIDANADEP) AS EXISTDEP FROM TANADEP WHERE DATEPART([MM],DDATCRE) = {0} AND DATEPART([YY],DDATCRE) = {1} AND VSOCIETE = '{2}'", CboMois.SelectedValue, CboAnnee.SelectedValue, MozartParams.NomSociete), MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text

    Dim dr As SqlDataReader = sqlcmd.ExecuteReader

    Try

      If dr.HasRows = True Then

        dr.Read()
        If dr.Item("EXISTDEP") > 0 Then

          Dim oFrmDepensesAnalytique As New FrmDepensesAnalytique(Convert.ToDateTime("01/" + CboMois.SelectedValue.ToString + "/" + CboAnnee.SelectedValue.ToString))
          oFrmDepensesAnalytique.Show()

        Else

          MessageBox.Show(My.Resources.TabSyntheseCompta_frmSynthCompta_export_pasdedépo, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

      Else

        MessageBox.Show(My.Resources.TabSyntheseCompta_frmSynthCompta_export_pasdedépo, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.TabSyntheseCompta_frmSynthCompta_sub4, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally

      If dr.IsClosed = False Then dr.Close()

    End Try

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

  Private Sub GCSynthCompta_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GCSynthCompta.Paint

    Dim gridPaint As GridControl = CType(sender, GridControl)

    If gridPaint Is Nothing Then
      Return
    End If

    Dim AdvbandGridViewPaint As BandedGridView = TryCast(gridPaint.FocusedView, AdvBandedGridView)

    If AdvbandGridViewPaint Is Nothing Then
      Return
    End If

    Dim viewInfo As AdvBandedGridViewInfo = TryCast(AdvbandGridViewPaint.GetViewInfo(), AdvBandedGridViewInfo)
    Dim oPen As New Pen(Brushes.Black, 2)

    For Each band As GridBand In AdvbandGridViewPaint.Bands

      Dim bandInfo As GridBandInfoArgs = viewInfo.BandsInfo(band)

      If Not bandInfo Is Nothing AndAlso bandInfo.Bounds.Right < gridPaint.Width Then

        Dim startPoint As New Point(bandInfo.Bounds.Right - 1, bandInfo.Bounds.Y)
        Dim endPoint As New Point(bandInfo.Bounds.Right - 1, viewInfo.ViewRects.Footer.Bottom)

        'ligne vertical
        Select Case band.Name

          Case "GBProd"

            e.Graphics.DrawLine(oPen, New Point(1, bandInfo.Bounds.Y), New Point(1, viewInfo.ViewRects.Footer.Bottom))

            e.Graphics.DrawLine(oPen, startPoint, endPoint)

          Case "GBResultFG"

            e.Graphics.DrawLine(oPen, startPoint, endPoint)

          Case "GBTxChargeStruct"

            e.Graphics.DrawLine(oPen, startPoint, endPoint)

        End Select

        'ligne horizontale
        Select Case band.Name
          Case "GBTxChargeStruct"

            e.Graphics.DrawLine(oPen, New Point(1, viewInfo.ViewRects.ColumnPanel.Bottom), New Point(bandInfo.Bounds.Right - 1, viewInfo.ViewRects.ColumnPanel.Bottom))

            e.Graphics.DrawLine(oPen, New Point(1, 1), New Point(bandInfo.Bounds.Right - 1, 1))

            e.Graphics.DrawLine(oPen, New Point(1, viewInfo.ViewRects.Footer.Top + 2), New Point(bandInfo.Bounds.Right - 1, viewInfo.ViewRects.Footer.Top + 2))

            e.Graphics.DrawLine(oPen, New Point(1, viewInfo.ViewRects.Footer.Bottom), New Point(bandInfo.Bounds.Right - 1, viewInfo.ViewRects.Footer.Bottom))

        End Select

        'quadrillage spécifique par colonne
        For Each cols As BandedGridColumn In AdvbandGridViewPaint.Columns

          Dim viewInfoCol As GridColumnInfoArgs = TryCast(viewInfo.ColumnsInfo(cols.VisibleIndex + 1), GridColumnInfoArgs)

          If Not viewInfoCol Is Nothing AndAlso viewInfoCol.Bounds.Bottom < gridPaint.Height Then

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
              Case "RESULTAJUST"

                e.Graphics.DrawLine(oPen, ColstartPoint, ColendPoint)
                e.Graphics.DrawLine(oPen, ColVerticalLEFTStartPoint, ColVerticalLEFTEndPoint)

              Case "NPOURCCAENCOURS"

                e.Graphics.DrawLine(oPen, ColstartPoint, ColendPoint)
                e.Graphics.DrawLine(oPen, ColVerticalRIGHTStartPoint, ColVerticalRIGHTEndPoint)

            End Select

          End If

        Next

      End If

    Next band

  End Sub

  Private Sub GCBalanceAna_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GCBalanceAna.Paint

    Dim gridPaint As GridControl = CType(sender, GridControl)

    If gridPaint Is Nothing Then
      Return
    End If

    Dim AdvbandGridViewPaint As BandedGridView = TryCast(gridPaint.FocusedView, AdvBandedGridView)

    If AdvbandGridViewPaint Is Nothing Then
      Return
    End If

    Dim viewInfo As AdvBandedGridViewInfo = TryCast(AdvbandGridViewPaint.GetViewInfo(), AdvBandedGridViewInfo)
    Dim oPen As New Pen(Brushes.Black, 2)

    For Each band As GridBand In AdvbandGridViewPaint.Bands

      Dim bandInfo As GridBandInfoArgs = viewInfo.BandsInfo(band)

      If Not bandInfo Is Nothing AndAlso bandInfo.Bounds.Right < gridPaint.Width Then

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

      Dim viewInfoCol As GridColumnInfoArgs = TryCast(viewInfo.ColumnsInfo(cols.VisibleIndex + 1), GridColumnInfoArgs)

      If Not viewInfoCol Is Nothing AndAlso viewInfoCol.Bounds.Bottom < gridPaint.Height Then

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

        End Select

      End If

    Next

  End Sub

  Private Sub GCAnaREX_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GCAnaREX.Paint

    Dim gridPaint As GridControl = CType(sender, GridControl)

    If gridPaint Is Nothing Then
      Return
    End If

    Dim AdvbandGridViewPaint As BandedGridView = TryCast(gridPaint.FocusedView, AdvBandedGridView)

    If AdvbandGridViewPaint Is Nothing Then
      Return
    End If

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

      MessageBox.Show(My.Resources.TabSyntheseCompta_frmSynthCompta_sub5 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return Nothing

    End Try

  End Function

  Private Sub AdvBGVBilanAna_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles AdvBGVBilanAna.RowCellClick

    If e.Button = MouseButtons.Right And e.RowHandle <> -1 Then

      Dim sMsg As String = ""

      Dim drDetail As DataRow = AdvBGVBilanAna.GetDataRow(e.RowHandle)

      If Not drDetail Is Nothing Then

        Select Case e.Column.FieldName

          Case "NCASYNCOMPTA"

            sMsg = String.Format(My.Resources.TabSyntheseCompta_frmSynthCompta_montant1 + vbCrLf + My.Resources.TabSyntheseCompta_frmSynthCompta_montant2 + vbCrLf + My.Resources.TabSyntheseCompta_frmSynthCompta_montant3 + vbCrLf + My.Resources.TabSyntheseCompta_frmSynthCompta_montant4, drDetail.Item("NODBILANDETAIL"), drDetail.Item("NCADETAIL"), drDetail.Item("NENCOURSDETAIL"), drDetail.Item("NANAFACTEABLITOT"))

          Case "NPOURCHRSTRUCT"

            sMsg = String.Format(My.Resources.TabSyntheseCompta_frmSynthCompta_montant5, drDetail.Item("NCHARGEDETAIL"))

          Case "NSECANASYNCOMPTA"

            sMsg = String.Format(My.Resources.TabSyntheseCompta_frmSynthCompta_msg_sect_taux_horaire_part1 & vbCrLf & My.Resources.TabSyntheseCompta_frmSynthCompta_msg_sect_taux_horaire_part2 & vbCrLf & My.Resources.TabSyntheseCompta_frmSynthCompta_msg_sect_taux_horaire_part3,
                                             drDetail.Item("AJUSTE_TX_HOR"),
                                             drDetail.Item("NSECANASYNCOMPTA") - drDetail.Item("AJUSTE_TX_HOR"),
                                             drDetail.Item("NSECANASYNCOMPTA"))

        End Select

        MessageBox.Show(sMsg, My.Resources.TabSyntheseCompta_frmSynthCompta_detail, MessageBoxButtons.OK, MessageBoxIcon.Information)

      End If

    End If

  End Sub

  '*******************************************************************************************************************************************************
  'Cette fonction permet d afficher les lignes qui ont 2 chaff sur un compte analytique en jaune
  '*******************************************************************************************************************************************************
  Private Sub AdvBGVBilanAna_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles AdvBGVBilanAna.RowStyle

    If e.RowHandle >= 0 Then

      For Each oDTRNCANNUM As DataRow In dtNCANNUMDoublon.Rows

        If oDTRNCANNUM.Item("NCANNUM") = AdvBGVBilanAna.GetDataRow(e.RowHandle).Item("NCANNUM") Then

          e.Appearance.BackColor = Color.Yellow

        End If

      Next

    End If

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

  Private Sub AdvBGVBilanAnaSoc_CustomDrawFooterCell(sender As Object, e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs) Handles AdvBGVBilanAnaSoc.CustomDrawFooterCell

    If e.Column.FieldName = "POURCANNEE" Then

      e.Info.DisplayText = "1 %"

    End If

  End Sub

  Private Sub AdvBGVBilanAnaSoc_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles AdvBGVBilanAnaSoc.RowCellClick

    If e.Button = MouseButtons.Right And e.RowHandle <> -1 Then

      Dim sMsg As String = ""

      Dim drDetail As DataRow = AdvBGVBilanAnaSoc.GetDataRow(e.RowHandle)

      If Not drDetail Is Nothing Then

        Select Case e.Column.FieldName

          Case "NSOLDE"

            sMsg = String.Format(My.Resources.TabSyntheseCompta_frmSynthCompta_msg_sect_taux_horaire_part1 & vbCrLf & My.Resources.TabSyntheseCompta_frmSynthCompta_msg_sect_taux_horaire_part2 & vbCrLf & My.Resources.TabSyntheseCompta_frmSynthCompta_msg_sect_taux_horaire_part3, drDetail.Item("AJUSTE_TX_HOR"), drDetail.Item("NSOLDE") - drDetail.Item("AJUSTE_TX_HOR"), drDetail.Item("NSOLDE"))

        End Select

        MessageBox.Show(sMsg, My.Resources.TabSyntheseCompta_frmSynthCompta_detail, MessageBoxButtons.OK, MessageBoxIcon.Information)

      End If

    End If

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
End Class
