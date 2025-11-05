Imports System.Data.SqlClient
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraCharts
Imports System.Text
Imports DevExpress.Utils
Imports MozartLib

Public Class frmStatAchat

  Dim oGestConnectSQL As New CGestionSQL

  Dim dtStatAchat As DataSet

  Dim bAllPer As Boolean

  Dim oSeriesMoy As Series
  Dim oAxeSecondaryY As SecondaryAxisY
  Dim LineTendanceNB As RegressionLine
  Dim LineTendanceMTT As RegressionLine
  Private toolTipController As New ToolTipController()

  Public Sub New(ByVal c_AllPer As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    bAllPer = Convert.ToByte(c_AllPer)

  End Sub


  Private Sub frmStatAchat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try
      'Init           
      If bAllPer = False Then
        Me.Text = My.Resources.Reporting_achat_frmStatAchat_Indicateur
        Label3.Text = My.Resources.Reporting_achat_frmStatAchat_Indicateur
      Else
        Me.Text = My.Resources.Reporting_achat_frmStatAchat_Indicateur_global
        Label3.Text = My.Resources.Reporting_achat_frmStatAchat_Indicateur_global
      End If


      LineTendanceMTT = New RegressionLine(ValueLevel.Value)
      LineTendanceMTT.Visible = True
      LineTendanceMTT.ShowInLegend = False
      LineTendanceMTT.LineStyle.Thickness = 1
      LineTendanceMTT.Color = Color.Fuchsia
      LineTendanceMTT.Name = My.Resources.Global_courbe_Tendance

      'on ouvre la connexion
      If oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then
        LoadStat()
        LoadMoyenne()
      End If

      ' ajout d'une line objectif
      Dim LineObj = New ConstantLine(My.Resources.Reporting_achat_frmStatAchat_objectif, 2000)
      LineObj.Color = Color.Lime
      LineObj.Title.TextColor = Color.Lime
      LineObj.ShowInLegend = False

      'ajout des courbes de tendances sur le total (series 3)
      For Each oSeries As Series In ChtCtrlAna.Series
        If oSeries.Name = "TOTAL" Then
          CType(oSeries.View, BarSeriesView).Indicators.Add(LineTendanceMTT)
          CType(oSeries.View, BarSeriesView).AxisY.ConstantLines.Add(LineObj)
          Exit For
        End If
      Next

      For Each oSeries As Series In ChartCtrlPFOU.Series
        If oSeries.Name = "TOTAL" Then
          CType(oSeries.View, BarSeriesView).Indicators.Add(LineTendanceMTT)
          CType(oSeries.View, BarSeriesView).AxisY.ConstantLines.Add(LineObj)
          Exit For
        End If
      Next

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_achat_frmStatAchat_SubLoad + ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub ChartGraph_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles ChartCtrlPer.MouseLeave
    toolTipController.HideHint()
  End Sub

  Private Sub frmStatAchat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    oGestConnectSQL.CloseConnexionSQL()
  End Sub

  Private Sub LoadStat()

    Try
      Dim CmdSql As New SqlCommand("api_sp_IndicateurAchatGraph", oGestConnectSQL.CnxSQLOpen)

      CmdSql.CommandType = CommandType.StoredProcedure
      CmdSql.Parameters.Add("@ALL_PER", SqlDbType.Bit).Value = bAllPer
      Dim dr As SqlDataAdapter = New SqlDataAdapter(CmdSql)
      dtStatAchat = New DataSet

      dr.Fill(dtStatAchat)

      ChartCtrlPer.DataSource = dtStatAchat.Tables(0)
      ChartCtrlRavel.DataSource = dtStatAchat.Tables(1)
      ChartCtrlFou.DataSource = dtStatAchat.Tables(2)
      ChartCtrlDOCSTF.DataSource = dtStatAchat.Tables(5)

      LoadResulSTT()
      LoadResulFOU()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_achat_frmStatAchat_SubLoadStat + ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub LoadResulSTT()

    Try
      Dim pvtAna As New PivotGridControl

      'Dim pvtfieldAxeRowPERIODE As New PivotGridField
      'pvtfieldAxeRowPERIODE.Area = PivotArea.RowArea
      'pvtfieldAxeRowPERIODE.FieldName = "AXE_X"
      'pvtfieldAxeRowPERIODE.Visible = True
      ''pvtfieldAxeRowPERIODE.SortMode = PivotSortMode.None

      Dim pvtfieldAxeRowANNEE As New PivotGridField
      pvtfieldAxeRowANNEE.Area = PivotArea.RowArea
      pvtfieldAxeRowANNEE.FieldName = "ANNEE" 'My.Resources.Global_annee
      pvtfieldAxeRowANNEE.Visible = True
      'pvtfieldAxeRowANNEE.SortMode = PivotSortMode.Value 

      Dim pvtfieldAxeRowMOIS As New PivotGridField
      pvtfieldAxeRowMOIS.Area = PivotArea.RowArea
      pvtfieldAxeRowMOIS.FieldName = My.Resources.Global_mois
      pvtfieldAxeRowMOIS.Visible = True
      ' pvtfieldAxeRowMOIS.SortMode = PivotSortMode.Value  

      Dim pvtfieldAxeCol As New PivotGridField
      pvtfieldAxeCol.Area = PivotArea.ColumnArea
      pvtfieldAxeCol.FieldName = My.Resources.Global_sens
      ' pvtfieldAxeCol.SortMode = PivotSortMode.None 

      Dim pvtfieldAxeValue As New PivotGridField
      pvtfieldAxeValue.Area = PivotArea.DataArea
      pvtfieldAxeValue.FieldName = My.Resources.Global_prix
      pvtfieldAxeValue.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
      pvtfieldAxeValue.ValueFormat.FormatString = "2p"

      pvtAna.OptionsCustomization.AllowSort = False

      pvtAna.Fields.Add(pvtfieldAxeRowANNEE)
      pvtAna.Fields.Add(pvtfieldAxeRowMOIS)
      '  pvtAna.Fields.Add(pvtfieldAxeRowPERIODE)
      pvtAna.Fields.Add(pvtfieldAxeCol)
      pvtAna.Fields.Add(pvtfieldAxeValue)

      pvtAna.DataSource = dtStatAchat.Tables(3)

      pvtAna.OptionsChartDataSource.SelectionOnly = False
      pvtAna.OptionsChartDataSource.ProvideRowGrandTotals = False
      pvtAna.OptionsChartDataSource.ProvideColumnGrandTotals = False
      pvtAna.OptionsChartDataSource.ProvideColumnTotals = False
      pvtAna.OptionsChartDataSource.ProvideRowTotals = False

      ChtCtrlAna.DataSource = pvtAna

      '      ChtCtrlAna.Series(2).LabelsVisibility = DefaultBoolean.False
      'ChtCtrlAna.Series(1).LabelsVisibility = DefaultBoolean.False
      ChtCtrlAna.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Left
      ChtCtrlAna.Legend.AlignmentVertical = LegendAlignmentVertical.Top
      'ChtCtrlAna.SeriesTemplate.ArgumentScaleType = ScaleType.DateTime


      Dim oAxis As XYDiagram = ChtCtrlAna.Diagram
      oAxis.AxisY.Title.Text = My.Resources.Global_MONTANT_euro
      oAxis.AxisY.Title.Visibility = DefaultBoolean.True
      oAxis.AxisX.Label.Angle = 90

      'oAxis.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Manual
      'oAxis.AxisX.DateTimeScaleOptions.AggregateFunction = AggregateFunction.None
      'oAxis.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Month
      'oAxis.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeMeasureUnit.Month

      'oAxis.AxisX.DateTimeScaleOptions.AutoGrid = False
      'oAxis.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Month
      'oAxis.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Month

      'oAxis.AxisX.NumericScaleOptions.GridSpacing = 1

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_achat_frmStatAchat_subloadSTT + ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub LoadResulFOU()

    Try
      Dim pvtAna As New PivotGridControl

      'Dim pvtfieldAxeRowPERIODE As New PivotGridField
      'pvtfieldAxeRowPERIODE.Area = PivotArea.RowArea
      'pvtfieldAxeRowPERIODE.FieldName = "AXE_X"
      'pvtfieldAxeRowPERIODE.Visible = True
      ''pvtfieldAxeRowPERIODE.SortMode = PivotSortMode.None

      Dim pvtfieldAxeRowANNEE As New PivotGridField
      pvtfieldAxeRowANNEE.Area = PivotArea.RowArea
      pvtfieldAxeRowANNEE.FieldName = "ANNEE" 'My.Resources.Global_annee
      pvtfieldAxeRowANNEE.Visible = True
      'pvtfieldAxeRowANNEE.SortMode = PivotSortMode.Value 

      Dim pvtfieldAxeRowMOIS As New PivotGridField
      pvtfieldAxeRowMOIS.Area = PivotArea.RowArea
      pvtfieldAxeRowMOIS.FieldName = My.Resources.Global_mois
      pvtfieldAxeRowMOIS.Visible = True
      ' pvtfieldAxeRowMOIS.SortMode = PivotSortMode.Value  

      Dim pvtfieldAxeCol As New PivotGridField
      pvtfieldAxeCol.Area = PivotArea.ColumnArea
      pvtfieldAxeCol.FieldName = My.Resources.Global_sens
      ' pvtfieldAxeCol.SortMode = PivotSortMode.None 

      Dim pvtfieldAxeValue As New PivotGridField
      pvtfieldAxeValue.Area = PivotArea.DataArea
      pvtfieldAxeValue.FieldName = My.Resources.Global_prix
      pvtfieldAxeValue.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
      pvtfieldAxeValue.ValueFormat.FormatString = "2p"

      pvtAna.OptionsCustomization.AllowSort = False

      pvtAna.Fields.Add(pvtfieldAxeRowANNEE)
      pvtAna.Fields.Add(pvtfieldAxeRowMOIS)
      '  pvtAna.Fields.Add(pvtfieldAxeRowPERIODE)
      pvtAna.Fields.Add(pvtfieldAxeCol)
      pvtAna.Fields.Add(pvtfieldAxeValue)

      pvtAna.DataSource = dtStatAchat.Tables(4)

      pvtAna.OptionsChartDataSource.SelectionOnly = False
      pvtAna.OptionsChartDataSource.ProvideRowGrandTotals = False
      pvtAna.OptionsChartDataSource.ProvideColumnGrandTotals = False
      pvtAna.OptionsChartDataSource.ProvideColumnTotals = False
      pvtAna.OptionsChartDataSource.ProvideRowTotals = False

      ChartCtrlPFOU.DataSource = pvtAna

      'ChartCtrlPFOU.Series(2).LabelsVisibility = DefaultBoolean.False
      'ChartCtrlPFOU.Series(1).LabelsVisibility = DefaultBoolean.False
      ChartCtrlPFOU.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Left
      ChartCtrlPFOU.Legend.AlignmentVertical = LegendAlignmentVertical.Top

      Dim oAxis As XYDiagram = ChartCtrlPFOU.Diagram
      oAxis.AxisY.Title.Text = My.Resources.Global_MONTANT_euro
      oAxis.AxisY.Title.Visibility = DefaultBoolean.True

      oAxis.AxisX.Label.Angle = 90

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_achat_frmStatAchat_subloadFOU + ex.Message, My.Resources.Global_Erreur)
    End Try

  End Sub

  Private Sub LoadMoyenne()

    Try
      Dim CmdSql As New SqlCommand("api_sp_StatAchatMoy", oGestConnectSQL.CnxSQLOpen)
      CmdSql.CommandType = CommandType.StoredProcedure
      CmdSql.Parameters.Add("@ALL_PER", SqlDbType.Bit).Value = bAllPer
      Dim dr As SqlDataReader = CmdSql.ExecuteReader
      If dr.HasRows = True Then
        While dr.Read()
          lblSTT.Text = lblSTT.Text & vbCrLf & dr("AVGSTT").ToString
          lbllibfou.Text = lbllibfou.Text & vbCrLf & dr("AVGLIBFOU").ToString
          lblCour.Text = lblCour.Text & vbCrLf & dr("AVGCOUR").ToString
          lblDOC.Text = lblDOC.Text & vbCrLf & dr("AVGDOC").ToString
          lblModSTT.Text = lblModSTT.Text & vbCrLf & dr("AVGPRIXSTT").ToString & " €"
          lblModFou.Text = lblModFou.Text & vbCrLf & dr("AVGPRIXFOU").ToString & " €"
        End While
      End If
      dr.Close()
      CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_achat_frmStatAchat_subloadgeneral + ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

  Private Sub ChartCtrlPer_ObjectSelected(sender As Object, e As DevExpress.XtraCharts.HotTrackEventArgs) Handles ChartCtrlPer.ObjectSelected

    Dim vToolTipHint, vArgument As String
    Dim builder As New StringBuilder()

    If e.HitInfo.InSeries Then
      Dim point As SeriesPoint = CType(e.AdditionalObject, SeriesPoint)
      If point IsNot Nothing Then
        vArgument = point.Argument
        vToolTipHint = point.ToolTipHint

        Dim Param = Split(vArgument, "/")

        'Dim cmd As New SqlCommand("api_sp_StatDetailLibelleFou", cnx)      Ca marche pas, ça!
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("@iAnnee", SqlDbType.Int).Value = Param(0)
        'cmd.Parameters.Add("@iMois", SqlDbType.Int).Value = Param(1)
        'cmd.Parameters.Add("@all_per", SqlDbType.Bit).Value = bAllPer

        Dim sSql As String
        If bAllPer = True Then
          sSql = String.Format("SELECT distinct VSTFNOM FROM TSTF WHERE DATEPART([YY], DSTFCREE) = {0} AND DATEPART([MM], DSTFCREE) = {1}", Param(0), Param(1))
        Else
          sSql = String.Format("SELECT distinct VSTFNOM FROM TSTF WHERE (NSTFQUICREE = 2473) AND DATEPART([YY], DSTFCREE) = {0} AND DATEPART([MM], DSTFCREE) = {1}", Param(0), Param(1))
        End If

        Dim cmd As New SqlCommand(sSql, MozartDatabase.cnxMozart)
        cmd.CommandType = CommandType.Text
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.HasRows = True Then
          While dr.Read()
            builder.AppendLine(dr("VSTFNOM"))
          End While
        End If
        dr.Close()
        cmd.Dispose()
      End If
      If builder.Length > 0 Then
        toolTipController.ShowHint(builder.ToString()) ', ChartCtrlPer.PointToScreen(e.Location))
      Else
        toolTipController.HideHint()
      End If

    End If

  End Sub

  Private Sub ChartCtrlFou_ObjectSelected(sender As Object, e As DevExpress.XtraCharts.HotTrackEventArgs) Handles ChartCtrlFou.ObjectSelected

    Dim vToolTipHint, vArgument As String

    If e.HitInfo.InSeries Then
      Dim point As SeriesPoint = CType(e.AdditionalObject, SeriesPoint)
      If point IsNot Nothing Then
        vArgument = point.Argument
        vToolTipHint = point.ToolTipHint

        Dim oFrmDetailStat As New frmDetailStatLib(vArgument, bAllPer)
        oFrmDetailStat.ShowDialog()

      End If
    End If

  End Sub

  Private Sub ChtCtrlAna_ObjectSelected(sender As Object, e As DevExpress.XtraCharts.HotTrackEventArgs) Handles ChtCtrlAna.ObjectSelected

    Dim vToolTipHint, vArgument As String

    If e.HitInfo.InSeries Then
      Dim point As SeriesPoint = CType(e.AdditionalObject, SeriesPoint)
      If point IsNot Nothing Then
        vArgument = point.Argument
        vToolTipHint = point.ToolTipHint

        Dim Param = Split(vArgument, "|")
        Dim obj As Series = e.HitInfo.Series
        Dim aux As String = Param(0) + "/" + Param(1) + "/" + obj.Name

        Dim oFrmDetailForm As New frmDetailStatSTT(aux, bAllPer)
        oFrmDetailForm.ShowDialog()
      End If
    End If

  End Sub

  Private Sub ChartCtrlPFOU_ObjectSelected(sender As Object, e As DevExpress.XtraCharts.HotTrackEventArgs) Handles ChartCtrlPFOU.ObjectSelected

    Dim vToolTipHint, vArgument As String

    If e.HitInfo.InSeries Then
      Dim point As SeriesPoint = CType(e.AdditionalObject, SeriesPoint)
      If point IsNot Nothing Then
        vArgument = point.Argument
        vToolTipHint = point.ToolTipHint

        Dim Param = Split(vArgument, "|")
        Dim obj As Series = e.HitInfo.Series
        Dim aux As String = Param(0) + "/" + Param(1) + "/" + obj.Name

        Dim oFrmDetailForm As New frmDetailStatFOU(aux, bAllPer)
        oFrmDetailForm.ShowDialog()
      End If
    End If

  End Sub

End Class