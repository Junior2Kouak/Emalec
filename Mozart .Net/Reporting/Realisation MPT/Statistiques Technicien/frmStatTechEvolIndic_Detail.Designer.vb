<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatTechEvolIndic_Detail
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim RegressionLine1 As DevExpress.XtraCharts.RegressionLine = New DevExpress.XtraCharts.RegressionLine()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.BtnImprimer = New System.Windows.Forms.Button()
        Me.ChartGraphTech = New DevExpress.XtraCharts.ChartControl()
        CType(Me.ChartGraphTech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RegressionLine1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnImprimer
        '
        Me.BtnImprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnImprimer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnImprimer.Location = New System.Drawing.Point(1275, 12)
        Me.BtnImprimer.Name = "BtnImprimer"
        Me.BtnImprimer.Size = New System.Drawing.Size(96, 32)
        Me.BtnImprimer.TabIndex = 3
        Me.BtnImprimer.Text = "Imprimer"
        Me.BtnImprimer.UseVisualStyleBackColor = True
        '
        'ChartGraphTech
        '
        XyDiagram1.AxisX.Label.Angle = 90
        XyDiagram1.AxisX.NumericScaleOptions.AutoGrid = False
        XyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.WholeRange.AutoSideMargins = False
        XyDiagram1.AxisY.WholeRange.SideMarginsValue = 0R
        Me.ChartGraphTech.Diagram = XyDiagram1
        Me.ChartGraphTech.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartGraphTech.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartGraphTech.Location = New System.Drawing.Point(0, 0)
        Me.ChartGraphTech.Name = "ChartGraphTech"
        Series1.ArgumentDataMember = "MOIS"
        Series1.Name = "Series 1"
        Series1.ValueDataMembersSerializable = "NVALSTAT"
        Series1.View = LineSeriesView1
        Me.ChartGraphTech.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.ChartGraphTech.SeriesTemplate.ArgumentDataMember = "MOIS"
        PointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartGraphTech.SeriesTemplate.Label = PointSeriesLabel1
        Me.ChartGraphTech.SeriesTemplate.ValueDataMembersSerializable = "NVALSTAT"
        RegressionLine1.Name = "RegressionLine 1"
        LineSeriesView2.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {RegressionLine1})
        Me.ChartGraphTech.SeriesTemplate.View = LineSeriesView2
        Me.ChartGraphTech.Size = New System.Drawing.Size(1490, 859)
        Me.ChartGraphTech.TabIndex = 2
		ChartTitle1.TextColor = System.Drawing.Color.Black
        ChartTitle1.WordWrap = True
        Me.ChartGraphTech.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'frmStatTechEvolIndic_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1490, 859)
        Me.Controls.Add(Me.BtnImprimer)
        Me.Controls.Add(Me.ChartGraphTech)
        Me.Name = "frmStatTechEvolIndic_Detail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Détail Evolution du {0}"
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RegressionLine1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartGraphTech, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnImprimer As Button
    Private WithEvents ChartGraphTech As DevExpress.XtraCharts.ChartControl
End Class
