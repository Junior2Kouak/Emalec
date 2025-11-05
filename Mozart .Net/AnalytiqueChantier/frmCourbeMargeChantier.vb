Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPrinting
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraPrintingLinks

Public Class frmCourbeMargeChantier

    Dim oCourbeMarge As Object

    Public Sub New(ByVal c_NIDCHANTIER As Int32)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

        oCourbeMarge = New CGRAPH_HISTO_CHANTIER(c_NIDCHANTIER)

    End Sub

    Private Sub frmCourbeMargeChantier_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try

            If oCourbeMarge Is Nothing Then MessageBox.Show(My.Resources.Admin_frmCourbeMargeChantier_AucuneDonnée, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

            'Init
            Me.Text = oCourbeMarge.sTitleForm

            Me.Cursor = Cursors.WaitCursor

            oCourbeMarge.LoadDataStat()

            ChartGraph.Series.Add(oCourbeMarge.CreateSeries)

            With CType(ChartGraph.Diagram, XYDiagram)
                .AxisX.Label.Angle = oCourbeMarge.AxisX_Label_Angle
                '.AxisY.NumericOptions.Format = oCourbeMarge.FormatAxeY
                '.AxisY.Range.Auto = True
                '.EnableAxisXZooming = True
                '.EnableAxisXScrolling = True
                .AxisY.VisualRange.Auto = True
                .AxisY.Label.TextPattern = "{V:N0}"
            End With

            'creation des courbes de tendances pour le graph : 
            For Each oSerieTmp As Series In ChartGraph.Series

                oSerieTmp.ShowInLegend = False
                CType(oSerieTmp.View, LineSeriesView).Indicators.Add(CreateLineTendance(oSerieTmp.Name))

                CType(oSerieTmp.View, LineSeriesView).LineMarkerOptions.Kind = MarkerKind.Circle
                CType(oSerieTmp.View, LineSeriesView).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True

                'ajout du format sur le top label en %
                Dim oSerieTmpPointLabel As PointSeriesLabel = CType(oSerieTmp.Label, PointSeriesLabel)
                'oSerieTmpPointLabel.PointOptions.Pattern = "{V} %"
                'oSerieTmpPointLabel.PointOptions.ValueNumericOptions.Precision = 0
                'oSerieTmpPointLabel.PointOptions.ValueNumericOptions.Format = NumericFormat.Number

                oSerieTmpPointLabel.TextPattern = "{V:P0}"



            Next

            If ChartGraph.Titles.Count = 0 Then ChartGraph.Titles.Add(oCourbeMarge.TitleChart)

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(My.Resources.Admin_frmCourbeMargeChantier_Load + ex.Message, My.Resources.Global_Erreur)

        Finally
            Me.Cursor = Cursors.Default

        End Try

    End Sub

    Private Sub btnFermer_Click(sender As System.Object, e As System.EventArgs) Handles btnFermer.Click
        Me.Close()
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

            MessageBox.Show(My.Resources.Admin_frmCourbeMargeChantier_SubTendance + ex.Message, My.Resources.Global_Erreur)
            Return Nothing

        End Try

    End Function

    Private Sub BtnImprim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprim.Click

        If MessageBox.Show(My.Resources.Global_imp_graph_tab, My.Resources.Global_Impression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

            Dim AllPageLink As CompositeLink = New CompositeLink(New PrintingSystem())

            Dim pcLinkGraph As PrintableComponentLink = New PrintableComponentLink()

            pcLinkGraph.Component = ChartGraph

            AllPageLink.Links.Add(pcLinkGraph)

            AllPageLink.Links(0).Margins.Left = 2
            AllPageLink.Links(0).Margins.Right = 2
            AllPageLink.Links(0).Margins.Top = 2
            AllPageLink.Links(0).Margins.Bottom = 2
            AllPageLink.Links(0).Landscape = True

            AllPageLink.PrintDlg()

        End If

    End Sub

End Class