Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPivotGrid
Imports MozartLib

Public Class frmStatFacturationEI

  Dim oGestConnectSQL As New CGestionSQL

  Dim dtStatFacturationCA As DataSet

  Dim oSeriesMoy As Series
  Dim oAxeSecondaryY As SecondaryAxisY
  Dim LineTendanceNB As RegressionLine
  Dim LineTendanceMTT As RegressionLine

  'on definit la couleur du compte 240 
  Dim oColor240 As Color
  'on definit la couleur du compte 263
  Dim oColor263 As Color

  Private Sub frmStatFacturationEI_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

  Private Sub frmStatFacturationEI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'Init          
      oColor240 = Color.RoyalBlue
      oColor263 = Color.OrangeRed

      LblLine240.BackColor = oColor240
      LblLine263.BackColor = oColor263

      DTPFin.Value = "01/" + Now.Month.ToString + "/" + Now.Year.ToString
      DTPDebut.Value = DTPFin.Value.AddMonths(-36)

      LineTendanceNB = New RegressionLine(ValueLevel.Value)
      LineTendanceNB.Visible = True
      LineTendanceNB.ShowInLegend = False
      LineTendanceNB.LineStyle.Thickness = 2
      LineTendanceNB.Name = My.Resources.Global_courbe_Tendance

      LineTendanceMTT = New RegressionLine(ValueLevel.Value)
      LineTendanceMTT.Visible = False
      LineTendanceMTT.ShowInLegend = False
      LineTendanceMTT.LineStyle.Thickness = 2
      LineTendanceMTT.Name = My.Resources.Global_courbe_Tendance

      'on ouvre la connexion
      If oGestConnectSQL.ConnexionSQLTimeOut(MozartParams.NomServeur, MozartParams.NomSociete, 0) = True Then

        LoadStat()

      End If

      'element cocher par défaut
      'ChkByNB.Checked = True 
      'PGFNB.Visible = True
      'ChkBoxByFact.Checked = False 
      'PGFVELFCRE.Visible = False 
      'ChkByMTT.Checked = False  
      'PGFMTT.Visible = False
      'ChkBoxMOY.Checked = False  
      'oSeriesMoy.Visible = False 
      'ChkLabelGraph.Checked = True             

      'ajout d'un deuxieme axe Y
      oAxeSecondaryY = New SecondaryAxisY(My.Resources.Global_montant)
      oAxeSecondaryY.Alignment = AxisAlignment.Far
      oAxeSecondaryY.Title.Text = My.Resources.Global_Montant_chiffrage
      oAxeSecondaryY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
      oAxeSecondaryY.Visibility = DevExpress.Utils.DefaultBoolean.True

      'CType(ChartCtrlStatFacChiff.Diagram, XYDiagram).SecondaryAxesY.Add(oAxeSecondaryY)              

      'ajuot des courbes de tendances
      'CType(ChartCtrlStatFacChiff.Series(0).View, BarSeriesView).Indicators.Add(LineTendanceMTT)
      'CType(ChartCtrlStatFacChiff.Series(0).View, BarSeriesView).Indicators.Add(LineTendanceNB)                 

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatFacturationEI_Sub1 + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub LoadStat()

    Try

      Dim CmdSql As New SqlCommand("api_sp_StatFacturationEIGraph", oGestConnectSQL.CnxSQLOpen)

      CmdSql.CommandType = CommandType.StoredProcedure
      CmdSql.Parameters.Add("@dateDebut", SqlDbType.DateTime).Value = DTPDebut.Value.ToShortDateString
      CmdSql.Parameters.Add("@dateFin", SqlDbType.DateTime).Value = DTPFin.Value.ToShortDateString

      Dim dr As SqlDataAdapter = New SqlDataAdapter(CmdSql)

      dtStatFacturationCA = New DataSet

      dr.Fill(dtStatFacturationCA)

      ChartCtrlCA.DataSource = dtStatFacturationCA.Tables(0)
      ChartCtrlPer.DataSource = dtStatFacturationCA.Tables(1)
      ChartCtrlCAbyPer.DataSource = dtStatFacturationCA.Tables(2)

      ChtCtrlTxChargePlanning.DataSource = dtStatFacturationCA.Tables(3)

      LoadResultAnaEI()

      LoadResultTxChargeStructEI()

      'creation des courbes de tendances pour le graph : Résultat d’exploitation 
      For Each oSerieTmp As Series In ChtCtrlAna.Series

        oSerieTmp.ShowInLegend = False
        CType(oSerieTmp.View, BarSeriesView).Indicators.Add(CreateLineTendance(oSerieTmp.Name))
        'ajout du format sur le top label en %
        Dim oSerieTmpPointLabel As SideBySideBarSeriesLabel = CType(oSerieTmp.Label, SideBySideBarSeriesLabel)
        'oSerieTmpPointLabel.PointOptions.Pattern = "{V} %"
        'oSerieTmpPointLabel.PointOptions.ValueNumericOptions.Precision = 0  
        'oSerieTmpPointLabel.PointOptions.ValueNumericOptions.Format = NumericFormat.Number

        oSerieTmpPointLabel.TextPattern = "{V:N0} %"
        oSerieTmp.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
        oSerieTmpPointLabel.Position = BarSeriesLabelPosition.Top

      Next

      'creation des courbes de tendances pour le graph : taux de structure 
      For Each oSerieTmp As Series In ChtCtrlChargeStruct.Series

        oSerieTmp.ShowInLegend = False
        CType(oSerieTmp.View, BarSeriesView).Indicators.Add(CreateLineTendance(oSerieTmp.Name))
        'ajout du format sur le top label en %
        Dim oSerieTmpPointLabel As SideBySideBarSeriesLabel = CType(oSerieTmp.Label, SideBySideBarSeriesLabel)
        'oSerieTmpPointLabel.PointOptions.Pattern = "{V} %"
        'oSerieTmpPointLabel.PointOptions.ValueNumericOptions.Precision = 0
        'oSerieTmpPointLabel.PointOptions.ValueNumericOptions.Format = NumericFormat.Number

        oSerieTmp.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
        oSerieTmpPointLabel.Position = BarSeriesLabelPosition.Top
        oSerieTmpPointLabel.TextPattern = "{V:N0} %"

      Next

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatFacturationEI_Sub2 + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Function CreateLineTendance(ByVal sNameSerie As String) As RegressionLine

    Try

      Dim LineTendanceMTT As New RegressionLine(ValueLevel.Value)
      LineTendanceMTT.Visible = True
      LineTendanceMTT.ShowInLegend = False
      LineTendanceMTT.LineStyle.Thickness = 2
      LineTendanceMTT.Color = Color.Fuchsia
      LineTendanceMTT.Name = String.Format(My.Resources.Global_Courbe, sNameSerie)
      Select Case sNameSerie

        Case "240"
          LineTendanceMTT.Color = oColor240
        Case "263"
          LineTendanceMTT.Color = oColor263
      End Select



      Return LineTendanceMTT

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatFacturationEI_Sub3 + ex.Message, My.Resources.Global_Erreur)
      Return Nothing

    End Try

  End Function

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub BtnValid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnValid.Click

    LoadStat()

  End Sub

  Private Sub LoadResultAnaEI()

    Try

      Dim pvtAna As New PivotGridControl

      Dim pvtfieldAxeRowANNEE As New PivotGridField
      pvtfieldAxeRowANNEE.Area = PivotArea.RowArea
      pvtfieldAxeRowANNEE.FieldName = My.Resources.Global_annee
      pvtfieldAxeRowANNEE.Visible = True
      'pvtfieldAxeRowANNEE.SortMode = PivotSortMode.Value 

      Dim pvtfieldAxeRowMOIS As New PivotGridField
      pvtfieldAxeRowMOIS.Area = PivotArea.RowArea
      pvtfieldAxeRowMOIS.FieldName = My.Resources.Global_mois
      pvtfieldAxeRowMOIS.Visible = True
      ' pvtfieldAxeRowMOIS.SortMode = PivotSortMode.Value  

      Dim pvtfieldAxeCol As New PivotGridField
      pvtfieldAxeCol.Area = PivotArea.ColumnArea
      pvtfieldAxeCol.FieldName = "NCANNUM"
      ' pvtfieldAxeCol.SortMode = PivotSortMode.None 

      Dim pvtfieldAxeValue As New PivotGridField
      pvtfieldAxeValue.Area = PivotArea.DataArea
      pvtfieldAxeValue.FieldName = "NPOURCMOIS"
      pvtfieldAxeValue.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
      pvtfieldAxeValue.ValueFormat.FormatString = "2p"

      pvtAna.OptionsCustomization.AllowSort = False

      pvtAna.Fields.Add(pvtfieldAxeRowANNEE)
      pvtAna.Fields.Add(pvtfieldAxeRowMOIS)
      pvtAna.Fields.Add(pvtfieldAxeCol)
      pvtAna.Fields.Add(pvtfieldAxeValue)

      pvtAna.DataSource = dtStatFacturationCA.Tables(4)

      pvtAna.OptionsChartDataSource.SelectionOnly = False
      pvtAna.OptionsChartDataSource.ProvideRowGrandTotals = False
      pvtAna.OptionsChartDataSource.ProvideColumnGrandTotals = False
      pvtAna.OptionsChartDataSource.ProvideColumnTotals = False
      pvtAna.OptionsChartDataSource.ProvideRowTotals = False

      ChtCtrlAna.DataSource = pvtAna

      Dim oAxis As XYDiagram = ChtCtrlAna.Diagram
      oAxis.AxisY.Title.Text = "(en % du CA)"
      oAxis.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
      oAxis.AxisY.Title.Font = New Font(oAxis.AxisY.Title.Font.FontFamily, 10, FontStyle.Bold)


      oAxis.AxisX.Label.Angle = 90

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatFacturationEI_Sub4 + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub LoadResultTxChargeStructEI()

    Try

      Dim pvtAna As New PivotGridControl

      Dim pvtfieldAxeRowANNEE As New PivotGridField
      pvtfieldAxeRowANNEE.Area = PivotArea.RowArea
      pvtfieldAxeRowANNEE.FieldName = My.Resources.Global_annee
      pvtfieldAxeRowANNEE.Visible = True
      'pvtfieldAxeRowANNEE.SortMode = PivotSortMode.Value 

      Dim pvtfieldAxeRowMOIS As New PivotGridField
      pvtfieldAxeRowMOIS.Area = PivotArea.RowArea
      pvtfieldAxeRowMOIS.FieldName = My.Resources.Global_mois
      pvtfieldAxeRowMOIS.Visible = True
      ' pvtfieldAxeRowMOIS.SortMode = PivotSortMode.Value  

      Dim pvtfieldAxeCol As New PivotGridField
      pvtfieldAxeCol.Area = PivotArea.ColumnArea
      pvtfieldAxeCol.FieldName = "NCANNUM"
      ' pvtfieldAxeCol.SortMode = PivotSortMode.None 

      Dim pvtfieldAxeValue As New PivotGridField
      pvtfieldAxeValue.Area = PivotArea.DataArea
      pvtfieldAxeValue.FieldName = "NPOURCMOIS"
      pvtfieldAxeValue.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
      'pvtfieldAxeValue.ValueFormat.FormatString = "p"

      pvtAna.OptionsCustomization.AllowSort = False

      pvtAna.Fields.Add(pvtfieldAxeRowANNEE)
      pvtAna.Fields.Add(pvtfieldAxeRowMOIS)
      pvtAna.Fields.Add(pvtfieldAxeCol)
      pvtAna.Fields.Add(pvtfieldAxeValue)

      pvtAna.DataSource = dtStatFacturationCA.Tables(5)

      pvtAna.OptionsChartDataSource.SelectionOnly = False
      pvtAna.OptionsChartDataSource.ProvideRowGrandTotals = False
      pvtAna.OptionsChartDataSource.ProvideColumnGrandTotals = False
      pvtAna.OptionsChartDataSource.ProvideColumnTotals = False
      pvtAna.OptionsChartDataSource.ProvideRowTotals = False

      ChtCtrlChargeStruct.DataSource = pvtAna

      Dim oAxis As XYDiagram = ChtCtrlChargeStruct.Diagram
      oAxis.AxisY.Title.Text = My.Resources.Reporting_Facturation_frmStatFacturationEI_CA
      oAxis.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
      oAxis.AxisY.Title.Font = New Font(oAxis.AxisY.Title.Font.FontFamily, 10, FontStyle.Bold)

      oAxis.AxisX.Label.Angle = 90

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatFacturationEI_Sub5 + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub ChtCtrlAna_CustomDrawAxisLabel(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs) Handles ChtCtrlAna.CustomDrawAxisLabel

    Dim axis As AxisBase = e.Item.Axis

    If TypeOf axis Is AxisX Then

      Dim year As String = e.Item.Text.Split("|")(0)

      Dim month As String = e.Item.Text.Split("|")(1)

      e.Item.Text = String.Format("{0}/{1}", month, year)

    End If

  End Sub

  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

    Dim oScreenShot As New CSreenShot(Me, True)

    oScreenShot.Print_Form()

  End Sub

  Private Sub RedimForm()

    GrpCA.Width = IIf((Me.Width - 200) / 2 > 772, 772, (Me.Width - 200) / 2)
    GrpTauxChargeEI.Left = GrpCA.Width + 183
    GrpTauxChargeEI.Width = IIf((Me.Width - 200) / 2 > 772, 772, (Me.Width - 200) / 2)

    GrpPer.Width = IIf((Me.Width - 200) / 2 > 772, 772, (Me.Width - 200) / 2)
    GrpAna.Left = GrpPer.Width + 183
    GrpAna.Width = IIf((Me.Width - 200) / 2 > 772, 772, (Me.Width - 200) / 2)

    GrpCAMoyByTech.Width = IIf((Me.Width - 200) / 2 > 772, 772, (Me.Width - 200) / 2)
    GrpChargeStruct.Left = GrpCAMoyByTech.Width + 183
    GrpChargeStruct.Width = IIf((Me.Width - 200) / 2 > 772, 772, (Me.Width - 200) / 2)


  End Sub

  Private Sub frmStatFacturationEI_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
    RedimForm()
  End Sub

  Private Sub ChtCtrlAna_CustomDrawSeries(sender As Object, e As DevExpress.XtraCharts.CustomDrawSeriesEventArgs) Handles ChtCtrlAna.CustomDrawSeries

    Dim oPalette() As PaletteEntry = ChtCtrlAna.GetPaletteEntries(ChtCtrlAna.Series.Count)

    Select Case e.Series.Name

      Case "240"
        LblColLeg240.BackColor = oPalette(0).Color
      Case "263"
        LblColLeg263.BackColor = oPalette(1).Color

    End Select

  End Sub

  Private Sub ChtCtrlChargeStruct_CustomDrawSeries(sender As Object, e As DevExpress.XtraCharts.CustomDrawSeriesEventArgs) Handles ChtCtrlChargeStruct.CustomDrawSeries

    Dim oPalette() As PaletteEntry = ChtCtrlAna.GetPaletteEntries(ChtCtrlAna.Series.Count)

    Select Case e.Series.Name

      Case "240"
        e.Series.View.Color = oPalette(0).Color
      Case "263"
        e.Series.View.Color = oPalette(1).Color

    End Select

  End Sub
End Class