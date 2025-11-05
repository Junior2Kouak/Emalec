Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPivotGrid
Imports MozartLib

Public Class frmCompareTechEI
  Dim CnxEI As New CGestionSQL
  Dim ds, dsg As DataSet

  Private Sub frmCompareTechEI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    Try
      If CnxEI.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then
        DTPFin.Value = Now.ToString
        DTPDebut.Value = DTPFin.Value.AddMonths(-12)

        LoadDataGridView()


      Else
        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmcompareTech_sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub LoadDataGridView()

    Try
      Me.Cursor = Cursors.WaitCursor
      ds = New DataSet

      Dim cmdLoadList As New SqlCommand("api_sp_StatCompareTechEI", CnxEI.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure
      cmdLoadList.Parameters.Add("@dateDebut", SqlDbType.DateTime).Value = DTPDebut.Value.ToShortDateString
      cmdLoadList.Parameters.Add("@dateFin", SqlDbType.DateTime).Value = DTPFin.Value.ToShortDateString

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(ds)

      GCStat.DataSource = ds.Tables(0)

      'Gestion des graphiques
      dsg = New DataSet
      Dim cmdg As New SqlCommand("api_sp_StatCompareTechEI_Graph", CnxEI.CnxSQLOpen)
      cmdg.CommandType = CommandType.StoredProcedure
      cmdg.Parameters.Add("@dateDebut", SqlDbType.DateTime).Value = DTPDebut.Value.ToShortDateString
      cmdg.Parameters.Add("@dateFin", SqlDbType.DateTime).Value = DTPFin.Value.ToShortDateString
      Dim sqlAdpatg As SqlDataAdapter = New SqlDataAdapter(cmdg)
      sqlAdpatg.Fill(dsg)

      LoadChartCA()
      LoadChartNBPROSP()
      LoadChartNBRDV()
      LoadChartRatio()

      'ChartStatEI.PaletteName = "Mixed"
      'ChartRatio.PaletteName = "Pastel Kit"
      'ChartNBPROSP.PaletteName = "Apex"

      Dim list As IList(Of StructColorSeries)
      list = New List(Of StructColorSeries)
      LoadColorByTechEI(list)

      '********************************************************** CHART EI *********************************************************************
      For Each oSerieTmp As Series In ChartStatEI.Series

        Dim tabSplit() As String = Split(oSerieTmp.Name, "|")

        'oSerieTmp.View = New SideBySideBarSeriesView
        oSerieTmp.View.Color = SearchByNomTech(list, LTrim(RTrim(tabSplit(0)))).oColor

        CType(oSerieTmp.View, SideBySideBarSeriesView).Indicators.Add(CreateLineTendance(oSerieTmp.Name, SearchByNomTech(list, LTrim(RTrim(tabSplit(0)))).oColor))
      Next
      '*****************************************************************************************************************************************

      '********************************************************** CHART RATIO PLANNING *********************************************************************   
      For Each oSerieTmp As Series In ChartRatio.Series

        Dim tabSplit() As String = Split(oSerieTmp.Name, "|")
        oSerieTmp.View.Color = SearchByNomTech(list, LTrim(RTrim(tabSplit(0)))).oColor

        If LTrim(RTrim(tabSplit(1))) = "INT" Then
          oSerieTmp.View.Color = Drawing.Color.Yellow
          oSerieTmp.LegendText = LTrim(RTrim(tabSplit(0))) & My.Resources.Reporting_RealisationMPT_frmcompareTech_interne
          'CType(oSerieTmp.View, SideBySideStackedBarSeriesView).FillStyle.FillMode = FillMode.Hatch
        Else
          oSerieTmp.LegendText = LTrim(RTrim(tabSplit(0)))
          'courbe de tendance
          CType(oSerieTmp.View, SideBySideStackedBarSeriesView).Indicators.Add(CreateLineTendance(oSerieTmp.Name, SearchByNomTech(list, LTrim(RTrim(tabSplit(0)))).oColor))
        End If

        CType(oSerieTmp.View, SideBySideStackedBarSeriesView).StackedGroup = LTrim(RTrim(tabSplit(0)))

      Next
      '*****************************************************************************************************************************************

      '********************************************************** CHART NB PROSP *********************************************************************
      For Each oSerieTmp As Series In ChartNBPROSP.Series
        Dim tabSplit() As String = Split(oSerieTmp.Name, "|")
        oSerieTmp.View.Color = SearchByNomTech(list, LTrim(RTrim(tabSplit(0)))).oColor
        'courbe de tendance
        ' CType(oSerieTmp.View, SideBySideBarSeriesView).Indicators.Add(CreateLineTendance(oSerieTmp.Name, SearchByNomTech(list, LTrim(RTrim(tabSplit(0)))).oColor))
      Next
      '**********************************************************************************************************************************************

      '********************************************************** CHART NB RDV *********************************************************************
      For Each oSerieTmp As Series In ChartNBRDV.Series
        Dim tabSplit() As String = Split(oSerieTmp.Name, "|")
        oSerieTmp.View.Color = SearchByNomTech(list, LTrim(RTrim(tabSplit(0)))).oColor
        'courbe de tendance
        ' CType(oSerieTmp.View, SideBySideBarSeriesView).Indicators.Add(CreateLineTendance(oSerieTmp.Name, SearchByNomTech(list, LTrim(RTrim(tabSplit(0)))).oColor))
      Next
      '**********************************************************************************************************************************************

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmcompareTech_sub2 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub LoadColorByTechEI(ByVal c_list As List(Of StructColorSeries))

    Dim paletteEntries() As PaletteEntry
    Dim i As Int32 = 0

    paletteEntries = ChartRatio.GetPaletteEntries(ChartRatio.Series.Count)

    Dim sqlcmdLstTech As New SqlCommand("SELECT VPERNOM + ' ' + VPERPRE AS VPERNOM FROM TPER WITH(NOLOCK) WHERE TPER.CPERTYP = 'TE' AND TPER.NSERNUM = 11 AND TPER.CPERACTIF='O' AND TPER.VSOCIETE = APP_NAME()", MozartDatabase.cnxMozart)
    sqlcmdLstTech.CommandType = CommandType.Text

    Dim DrTech As SqlDataReader = sqlcmdLstTech.ExecuteReader()
    If DrTech.HasRows Then

      While DrTech.Read

        c_list.Add(New StructColorSeries() With {.sNameTech = DrTech.Item("VPERNOM"), .oColor = paletteEntries(i).Color})
        i = i + 1

      End While

    End If
    DrTech.Close()

  End Sub

  Private Function SearchByNomTech(ByVal list As List(Of StructColorSeries), ByVal NomTech As String) As StructColorSeries
    Return list.Find(Function(s As StructColorSeries) s.sNameTech = NomTech)
  End Function

  Private Sub LoadChartCA()

    Try
      Dim pvtAna As New PivotGridControl

      Dim pvtfieldAxeRowMOIS As New PivotGridField
      pvtfieldAxeRowMOIS.Area = PivotArea.RowArea
      pvtfieldAxeRowMOIS.FieldName = My.Resources.Global_AXIS
      pvtfieldAxeRowMOIS.Visible = True
      pvtfieldAxeRowMOIS.SortMode = PivotSortMode.Value

      Dim pvtfieldAxeCol As New PivotGridField
      pvtfieldAxeCol.Area = PivotArea.ColumnArea
      pvtfieldAxeCol.FieldName = My.Resources.Global_technicien_maj
      pvtfieldAxeCol.SortMode = PivotSortMode.None

      Dim pvtfieldAxeValue As New PivotGridField
      pvtfieldAxeValue.Area = PivotArea.DataArea
      pvtfieldAxeValue.FieldName = "CA"
      pvtfieldAxeValue.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
      pvtfieldAxeValue.ValueFormat.FormatString = "2p"

      pvtAna.OptionsCustomization.AllowSort = False

      pvtAna.Fields.Add(pvtfieldAxeRowMOIS)
      pvtAna.Fields.Add(pvtfieldAxeCol)
      pvtAna.Fields.Add(pvtfieldAxeValue)

      pvtAna.DataSource = dsg.Tables(0)

      pvtAna.OptionsChartDataSource.SelectionOnly = False
      pvtAna.OptionsChartDataSource.ProvideRowGrandTotals = False
      pvtAna.OptionsChartDataSource.ProvideColumnGrandTotals = False
      pvtAna.OptionsChartDataSource.ProvideColumnTotals = False
      pvtAna.OptionsChartDataSource.ProvideRowTotals = False

      ChartStatEI.DataSource = pvtAna

      ChartStatEI.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
      ChartStatEI.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Left
      ChartStatEI.Legend.AlignmentVertical = LegendAlignmentVertical.Top

      ChartStatEI.AppearanceName = "Gray"
      ChartStatEI.PaletteBaseColorNumber = 0

      Dim oAxis As XYDiagram = ChartStatEI.Diagram
      oAxis.AxisY.Title.Text = My.Resources.Global_MONTANT_euro
      oAxis.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
      '      oAxis.AxisX.Label.Angle = 90

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmcompareTech_sub3 + ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub LoadChartNBPROSP()

    Try
      Dim pvtAna As New PivotGridControl

      Dim pvtfieldAxeRowMOIS As New PivotGridField
      pvtfieldAxeRowMOIS.Area = PivotArea.RowArea
      pvtfieldAxeRowMOIS.FieldName = My.Resources.Global_AXIS
      pvtfieldAxeRowMOIS.Visible = True
      pvtfieldAxeRowMOIS.SortMode = PivotSortMode.Value

      Dim pvtfieldAxeCol As New PivotGridField
      pvtfieldAxeCol.Area = PivotArea.ColumnArea
      pvtfieldAxeCol.FieldName = My.Resources.Global_technicien_maj
      pvtfieldAxeCol.SortMode = PivotSortMode.None

      Dim pvtfieldAxeValue As New PivotGridField
      pvtfieldAxeValue.Area = PivotArea.DataArea
      pvtfieldAxeValue.FieldName = "CA"
      pvtfieldAxeValue.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
      pvtfieldAxeValue.ValueFormat.FormatString = "2p"

      pvtAna.OptionsCustomization.AllowSort = False

      pvtAna.Fields.Add(pvtfieldAxeRowMOIS)
      pvtAna.Fields.Add(pvtfieldAxeCol)
      pvtAna.Fields.Add(pvtfieldAxeValue)

      pvtAna.DataSource = dsg.Tables(1)

      pvtAna.OptionsChartDataSource.SelectionOnly = False
      pvtAna.OptionsChartDataSource.ProvideRowGrandTotals = False
      pvtAna.OptionsChartDataSource.ProvideColumnGrandTotals = False
      pvtAna.OptionsChartDataSource.ProvideColumnTotals = False
      pvtAna.OptionsChartDataSource.ProvideRowTotals = False

      ChartNBPROSP.DataSource = pvtAna

      ChartNBPROSP.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
      ChartNBPROSP.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Left
      ChartNBPROSP.Legend.AlignmentVertical = LegendAlignmentVertical.Top
      ChartNBPROSP.Legend.MaxHorizontalPercentage = 100
      ChartNBPROSP.Legend.MaxVerticalPercentage = 100
      'ChartNBPROSP.Legend.MarkerVisible = True
      ChartNBPROSP.AppearanceName = "Gray"
      ChartNBPROSP.PaletteBaseColorNumber = 0


      Dim oAxis As XYDiagram = ChartNBPROSP.Diagram
      oAxis.AxisY.Title.Text = My.Resources.Global_nbrPropect
      oAxis.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
      '      oAxis.AxisX.Label.Angle = 90

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmcompareTech_sub4 + ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub LoadChartNBRDV()

    Try
      Dim pvtAna As New PivotGridControl

      Dim pvtfieldAxeRowMOIS As New PivotGridField
      pvtfieldAxeRowMOIS.Area = PivotArea.RowArea
      pvtfieldAxeRowMOIS.FieldName = My.Resources.Global_AXIS
      pvtfieldAxeRowMOIS.Visible = True
      'pvtfieldAxeRowMOIS.SortMode = PivotSortMode.Value

      Dim pvtfieldAxeCol As New PivotGridField
      pvtfieldAxeCol.Area = PivotArea.ColumnArea
      pvtfieldAxeCol.FieldName = My.Resources.Global_technicien_maj
      'pvtfieldAxeCol.SortMode = PivotSortMode.None

      Dim pvtfieldAxeValue As New PivotGridField
      pvtfieldAxeValue.Area = PivotArea.DataArea
      pvtfieldAxeValue.FieldName = "CA"
      pvtfieldAxeValue.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
      pvtfieldAxeValue.ValueFormat.FormatString = "2p"

      pvtAna.OptionsCustomization.AllowSort = False

      pvtAna.Fields.Add(pvtfieldAxeRowMOIS)
      pvtAna.Fields.Add(pvtfieldAxeCol)
      pvtAna.Fields.Add(pvtfieldAxeValue)

      pvtAna.DataSource = dsg.Tables(2)

      pvtAna.OptionsChartDataSource.SelectionOnly = False
      pvtAna.OptionsChartDataSource.ProvideRowGrandTotals = False
      pvtAna.OptionsChartDataSource.ProvideColumnGrandTotals = False
      pvtAna.OptionsChartDataSource.ProvideColumnTotals = False
      pvtAna.OptionsChartDataSource.ProvideRowTotals = False

      ChartNBRDV.DataSource = pvtAna

      ChartNBRDV.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
      ChartNBRDV.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Left
      ChartNBRDV.Legend.AlignmentVertical = LegendAlignmentVertical.Top
      ChartNBRDV.Legend.MaxHorizontalPercentage = 100
      ChartNBRDV.Legend.MaxVerticalPercentage = 100

      ChartNBRDV.AppearanceName = "Gray"
      ChartNBRDV.PaletteBaseColorNumber = 0

      Dim oAxis As XYDiagram = ChartNBRDV.Diagram
      oAxis.AxisY.Title.Text = My.Resources.Global_nbrRDV
      oAxis.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
      '      oAxis.AxisX.Label.Angle = 90

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmcompareTech_sub5 + ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub LoadChartRatio()

    Try
      Dim pvtAna As New PivotGridControl

      Dim pvtfieldAxeRowMOIS As New PivotGridField
      pvtfieldAxeRowMOIS.Area = PivotArea.RowArea
      pvtfieldAxeRowMOIS.FieldName = My.Resources.Global_AXIS
      pvtfieldAxeRowMOIS.Visible = True
      'pvtfieldAxeRowMOIS.SortMode = PivotSortMode.Value

      Dim pvtfieldAxeColTECH As New PivotGridField
      pvtfieldAxeColTECH.Area = PivotArea.ColumnArea
      pvtfieldAxeColTECH.FieldName = My.Resources.Global_technicien_maj
      'pvtfieldAxeCol.SortMode = PivotSortMode.None

      Dim pvtfieldAxeColTYPE As New PivotGridField
      pvtfieldAxeColTYPE.Area = PivotArea.ColumnArea
      pvtfieldAxeColTYPE.FieldName = "CTYPE"
      'pvtfieldAxeCol.SortMode = PivotSortMode.None

      Dim pvtfieldAxeValueCli As New PivotGridField
      pvtfieldAxeValueCli.Area = PivotArea.DataArea
      pvtfieldAxeValueCli.FieldName = "CA"
      pvtfieldAxeValueCli.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
      pvtfieldAxeValueCli.ValueFormat.FormatString = "2p"

      pvtAna.OptionsCustomization.AllowSort = False

      pvtAna.Fields.Add(pvtfieldAxeRowMOIS)
      pvtAna.Fields.Add(pvtfieldAxeColTECH)
      pvtAna.Fields.Add(pvtfieldAxeColTYPE)
      pvtAna.Fields.Add(pvtfieldAxeValueCli)

      pvtAna.DataSource = dsg.Tables(3)

      pvtAna.OptionsChartDataSource.SelectionOnly = False
      pvtAna.OptionsChartDataSource.ProvideRowGrandTotals = False
      pvtAna.OptionsChartDataSource.ProvideColumnGrandTotals = False
      pvtAna.OptionsChartDataSource.ProvideColumnTotals = False
      pvtAna.OptionsChartDataSource.ProvideRowTotals = False

      ChartRatio.DataSource = pvtAna

      ChartRatio.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
      ChartRatio.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Left
      ChartRatio.Legend.AlignmentVertical = LegendAlignmentVertical.Top

      ChartRatio.AppearanceName = "Gray"
      ChartRatio.PaletteBaseColorNumber = 0

      Dim oAxis As XYDiagram = ChartRatio.Diagram
      oAxis.AxisY.Title.Text = My.Resources.Reporting_RealisationMPT_frmcompareTech_charge
      oAxis.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
      '      oAxis.AxisX.Label.Angle = 90

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmcompareTech_sub6 + ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub



  Private Function CreateLineTendance(ByVal sNameSerie As String, ByVal sColorSerie As Drawing.Color) As RegressionLine

    Try

      Dim LineTendanceMTT As New RegressionLine(ValueLevel.Value)
      LineTendanceMTT.Visible = True
      LineTendanceMTT.ShowInLegend = False
      LineTendanceMTT.LineStyle.Thickness = 2
      LineTendanceMTT.Name = sNameSerie
      LineTendanceMTT.Color = sColorSerie

      Return LineTendanceMTT

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmcompareTech_sub7 + ex.Message, My.Resources.Global_Erreur)
      Return Nothing

    End Try

  End Function

  Private Sub GVStat_EndSorting(sender As Object, e As System.EventArgs) Handles GVStat.EndSorting
    GVStat.TopRowIndex = 0
    GVStat.FocusedRowHandle = 0
  End Sub

  Private Sub BtnValider_Click(sender As System.Object, e As System.EventArgs) Handles BtnValider.Click
    LoadDataGridView()
  End Sub

  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub btnArdite_Click(sender As System.Object, e As System.EventArgs) Handles btnGraph.Click
    Dim tech As String = GVStat.GetDataRow(GVStat.GetSelectedRows(0)).Item(My.Resources.Global_technicien_maj)
    For Each oSerieTmp As Series In ChartStatEI.Series
      If InStr(oSerieTmp.Name, tech) = 0 Then
        oSerieTmp.Visible = False
      Else
        oSerieTmp.Visible = True
      End If
    Next
    For Each oSerieTmp As Series In ChartRatio.Series
      If InStr(oSerieTmp.Name, tech) = 0 Then
        oSerieTmp.Visible = False
      Else
        oSerieTmp.Visible = True
      End If
    Next
    For Each oSerieTmp As Series In ChartNBPROSP.Series
      If InStr(oSerieTmp.Name, tech) = 0 Then
        oSerieTmp.Visible = False
      Else
        oSerieTmp.Visible = True
      End If
    Next
    For Each oSerieTmp As Series In ChartNBRDV.Series
      If InStr(oSerieTmp.Name, tech) = 0 Then
        oSerieTmp.Visible = False
      Else
        oSerieTmp.Visible = True
      End If
    Next
  End Sub

  Private Sub btnTGraph_Click(sender As System.Object, e As System.EventArgs) Handles btnTGraph.Click
    For Each oSerieTmp As Series In ChartStatEI.Series
      oSerieTmp.Visible = True
    Next
    For Each oSerieTmp As Series In ChartRatio.Series
      oSerieTmp.Visible = True
    Next
    For Each oSerieTmp As Series In ChartNBPROSP.Series
      oSerieTmp.Visible = True
    Next
    For Each oSerieTmp As Series In ChartNBRDV.Series
      oSerieTmp.Visible = True
    Next
  End Sub

  'Private Sub ChartStatEI_CustomDrawAxisLabel(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs) Handles ChartStatEI.CustomDrawAxisLabel

  '  Dim oAxis As AxisBase = e.Item.Axis

  '  If (TypeOf oAxis Is AxisY Or TypeOf oAxis Is AxisY3D Or TypeOf oAxis Is RadarAxisY) Then

  '    e.Item.Text = String.Format("{0:c0}", Convert.ToInt32(e.Item.Text))
  '    Dim oAxisTitle As Object = Convert.ChangeType(oAxis, oAxis.GetType)
  '    oAxisTitle.Title.Text = "Montant en €"
  '    oAxisTitle.Title.Visible = True

  '  ElseIf (TypeOf oAxis Is AxisX Or TypeOf oAxis Is AxisX3D Or TypeOf oAxis Is RadarAxisX) Then

  '    Dim oAxisTitle As Object = Convert.ChangeType(oAxis, oAxis.GetType)
  '    oAxisTitle.Title.Text = "Par semaine"
  '    oAxisTitle.Title.Visible = True

  '  End If

  'End Sub

  'Private Sub ChtCtrlChargeStruct_CustomDrawSeries(sender As Object, e As DevExpress.XtraCharts.CustomDrawSeriesEventArgs) Handles ChartRatio.CustomDrawSeries, ChartStatEI.CustomDrawSeries, ChartNBRDV.CustomDrawSeries, ChartNBPROSP.CustomDrawSeries

  '  Dim oPalette() As PaletteEntry = ChartRatio.GetPaletteEntries(ChartRatio.Series.Count)
  '  e.Series.View.Color = color(e.Series.Name)
  'End Sub

End Class


Public Structure StructColorSeries
  Property sNameTech As String
  Property oColor As Color
End Structure