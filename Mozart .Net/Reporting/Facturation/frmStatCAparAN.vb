Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPrinting
Imports ADODB
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraPrintingLinks

Public Class frmStatCAparAN

  Private oStat As Object

  Public Sub New(sSociete As String)
    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    oStat = New CStat_CA_SOC_AN(sSociete)

    lblSociete.Text = sSociete
  End Sub

  Private Sub frmStatFacturationCA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    lblDateJour.Text = My.Resources.Global_le & " " & Date.Today

    Try
      If oStat Is Nothing Then MessageBox.Show(My.Resources.Global_aucune_stat, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

      'Init
      Me.Text = oStat.sTitleForm
      LblTitre.Text = oStat.sTitleLabel

      Me.Cursor = Cursors.WaitCursor

      oStat.LoadDataStat()

      InitGridView()

      GCStat.DataSource = oStat.Dt_Stat

      ChartGraph.Series.Add(oStat.CreateSeries)

      With CType(ChartGraph.Diagram, XYDiagram)
        .AxisX.Label.Angle = oStat.AxisX_Label_Angle

        .AxisY.Label.TextPattern = "{V:C0}"
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

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatCaparAn_Sub1 + ex.Message, My.Resources.Global_Erreur)

    Finally
      Me.Cursor = Cursors.Default
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

      Return LineTendanceMTT

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatCaparAn_Sub2 + ex.Message, My.Resources.Global_Erreur)
      Return Nothing
    End Try
  End Function

  Private Sub InitGridView()
    'Init
    GVStat.Columns.Clear()

    For i As Integer = 0 To (oStat.Dt_Stat.Columns.Count - 1)
      GVStat.Columns.Add(oStat.NamingColumn(i))
    Next
  End Sub

  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
    If MessageBox.Show(My.Resources.Global_imp_graph_tab, My.Resources.Global_Impression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then
      Dim AllPageLink As New CompositeLink(New PrintingSystem())

      Dim pcLinkGraph As New PrintableComponentLink()
      Dim pcLinkTableau As New PrintableComponentLink()

      pcLinkGraph.Component = ChartGraph
      pcLinkTableau.Component = GCStat

      AllPageLink.Links.Add(pcLinkGraph)
      AllPageLink.Links.Add(pcLinkTableau)

      AllPageLink.Links(0).Margins.Left = 2
      AllPageLink.Links(0).Margins.Right = 2
      AllPageLink.Links(0).Margins.Top = 2
      AllPageLink.Links(0).Margins.Bottom = 2
      AllPageLink.Links(0).Landscape = True

      AllPageLink.Links(1).Margins.Left = 2
      AllPageLink.Links(1).Margins.Right = 2
      AllPageLink.Links(1).Margins.Top = 2
      AllPageLink.Links(1).Margins.Bottom = 2
      AllPageLink.Links(1).Landscape = False

      AllPageLink.CreatePageForEachLink()

      AllPageLink.PrintDlg()
    End If
  End Sub

  Private Sub GVStat_ColumnFilterChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVStat.ColumnFilterChanged
    For Each oSeriesTmp As Series In ChartGraph.Series
      Dim op As CriteriaOperator = GVStat.ActiveFilterCriteria 'filterControl1.FilterCriteria

      Dim filterString As String = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(op)
      oStat.SetFilterSeries(oSeriesTmp, filterString)
    Next
  End Sub
End Class
