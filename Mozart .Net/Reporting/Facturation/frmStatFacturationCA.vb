Imports System.Data.SqlClient
Imports System.Text
Imports DevExpress.Data.Filtering
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Printing
Imports DevExpress.XtraPrinting
Imports MozartLib

Public Class frmStatFacturationCA

  Private oStat As CStat_CA_SOC
  Private toolTipController As New ToolTipController()

  Public Sub New()
    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    apiSocieteAuto1.Init(MozartDatabase.cnxMozart, MozartParams.NomSociete)

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    oStat = New CStat_CA_SOC(apiSocieteAuto1.Text)
  End Sub

  Private Sub frmStatFacturationCA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    lblDateJour.Text = ", le " & Date.Today

    chargeListe()
  End Sub

  Private Sub chargeListe()
    Try
      Me.Cursor = Cursors.WaitCursor

      If oStat Is Nothing Then
        MessageBox.Show(My.Resources.Global_aucune_stat, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.Cursor = Cursors.Default
        Exit Sub
      End If

      'Init
      Me.Text = oStat.sTitleForm
      LblTitre.Text = oStat.sTitleLabel

      oStat.LoadDataStat()

      InitGridView()

      GCStat.DataSource = oStat.Dt_Stat

      ChartGraph.Series.Clear()
      ChartGraph.Series.Add(oStat.CreateSeries)

      If (oStat.Dt_Stat Is Nothing) OrElse (oStat.Dt_Stat.Rows.Count = 0) Then
        MessageBox.Show(My.Resources.Global_aucune_stat, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.Cursor = Cursors.Default
        Exit Sub
      End If

      ' pour l'affichage du CA sur 12 mois, on recherche la valeur dans une ligne du recordset en colonne 3
      lblTotal.Text = FormatCurrency(oStat.Dt_Stat.rows(0)(3))

      With CType(ChartGraph.Diagram, XYDiagram)
        .AxisX.Label.Angle = oStat.AxisX_Label_Angle
        .AxisY.Label.TextPattern = "{V:N0}"
      End With

      'creation des courbes de tendances pour le graph : 
      For Each oSerieTmp As Series In ChartGraph.Series
        oSerieTmp.ShowInLegend = False
        CType(oSerieTmp.View, BarSeriesView).Indicators.Add(CreateLineTendance(oSerieTmp.Name))

        'ajout du format sur le top label en %
        Dim oSerieTmpPointLabel As SideBySideBarSeriesLabel = CType(oSerieTmp.Label, SideBySideBarSeriesLabel)
        oSerieTmpPointLabel.TextPattern = "{V:P0}"
      Next

      If ChartGraph.Titles.Count = 0 Then ChartGraph.Titles.Add(oStat.TitleChart)

      ChartGraph.AppearanceName = "Gray"
      ChartGraph.PaletteName = "Mixed"
      ChartGraph.PaletteBaseColorNumber = 0

      CType(ChartGraph.Series(0).View, SideBySideBarSeriesView).ColorEach = False
    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatFacturationCa_Sub1 + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Function CreateLineTendance(ByVal sNameSerie As String) As RegressionLine
    Try
      Dim LineTendanceMTT As New RegressionLine(ValueLevel.Value) With {
        .Visible = True,
        .ShowInLegend = False
      }
      LineTendanceMTT.LineStyle.Thickness = 2
      LineTendanceMTT.Name = String.Format(My.Resources.Global_Courbe, sNameSerie)

      Return LineTendanceMTT
    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatFacturationCa_Sub2 + ex.Message, My.Resources.Global_Erreur)
      Return Nothing
    End Try
  End Function

  Private Sub InitGridView()
    Dim i As Int32

    'Init
    GVStat.Columns.Clear()

    For i = 0 To (oStat.Dt_Stat.Columns.Count - 1)
      GVStat.Columns.Add(oStat.NamingColumn(i))
    Next
  End Sub

  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
    If MessageBox.Show(My.Resources.Global_imp_graph_tab, My.Resources.Global_Impression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then
      Dim frmPrintDialog As New PrintDialog

      If (frmPrintDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then

        Dim pcLinkGraph As New PrintableComponentLink(New PrintingSystem()) With {
          .Component = ChartGraph,
          .Margins = New System.Drawing.Printing.Margins(5, 5, 5, 5),
          .Landscape = True
        }

        Dim pcLinkTableau As New PrintableComponentLink(New PrintingSystem()) With {
          .Component = GCStat,
          .Margins = New System.Drawing.Printing.Margins(5, 5, 5, 5),
          .Landscape = False
        }

        ChartGraph.OptionsPrint.SizeMode = PrintSizeMode.Stretch
        pcLinkGraph.CreateDocument(False)

        pcLinkGraph.Print(frmPrintDialog.PrinterSettings.PrinterName)

        GVStat.OptionsPrint.AutoWidth = False
        pcLinkTableau.CreateDocument(False)

        pcLinkTableau.Print(frmPrintDialog.PrinterSettings.PrinterName)

        MessageBox.Show(My.Resources.Global_impression_terminé, My.Resources.Global_Impression, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    End If
  End Sub

  Private Sub GVStat_ColumnFilterChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVStat.ColumnFilterChanged
    For Each oSeriesTmp As Series In ChartGraph.Series
      Dim op As CriteriaOperator = GVStat.ActiveFilterCriteria 'filterControl1.FilterCriteria

      Dim filterString As String = CriteriaToWhereClauseHelper.GetDataSetWhere(op)

      oStat.SetFilterSeries(oSeriesTmp, filterString)
    Next
  End Sub

  Private Sub cmdCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCA.Click
    Dim ofrmStatCAparAN As New frmStatCAparAN(apiSocieteAuto1.Text)

    ofrmStatCAparAN.ShowDialog()
  End Sub

  Private Sub ChartGraph_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ChartGraph.MouseMove
    Dim hitInfo As ChartHitInfo = ChartGraph.CalcHitInfo(e.Location)
    Dim builder As New StringBuilder()

    If hitInfo.SeriesPoint IsNot Nothing Then
      builder.AppendLine(My.Resources.Reporting_Facturation_frmStatFacturationCa_periode & hitInfo.SeriesPoint.Argument)
      If (Not hitInfo.SeriesPoint.IsEmpty) Then
        builder.AppendLine("  CA: " & FormatCurrency(hitInfo.SeriesPoint.Values(0)))
      End If
    End If
    If builder.Length > 0 Then
      toolTipController.ShowHint(builder.ToString(), ChartGraph.PointToScreen(e.Location))
    Else
      toolTipController.HideHint()
    End If
  End Sub

  Private Sub ChartGraph_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles ChartGraph.MouseLeave
    toolTipController.HideHint()
  End Sub

  Private Sub BtValider_Click(sender As System.Object, e As System.EventArgs) Handles BtValider.Click
    oStat = New CStat_CA_SOC(apiSocieteAuto1.Text)

    chargeListe()
  End Sub
End Class
