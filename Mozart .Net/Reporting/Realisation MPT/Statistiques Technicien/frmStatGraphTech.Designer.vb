<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatGraphTech
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatGraphTech))
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.ChartGraphTech = New DevExpress.XtraCharts.ChartControl()
        Me.BtnImprimer = New System.Windows.Forms.Button()
        CType(Me.ChartGraphTech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartGraphTech
        '
        XyDiagram1.AxisX.Label.Angle = CType(resources.GetObject("resource.Angle"), Integer)
        XyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
        XyDiagram1.AxisY.WholeRange.Auto = False
        XyDiagram1.AxisY.WholeRange.AutoSideMargins = False
        XyDiagram1.AxisY.WholeRange.MaxValueSerializable = "12"
        XyDiagram1.AxisY.WholeRange.MinValueSerializable = "0"
        XyDiagram1.AxisY.WholeRange.SideMarginsValue = 0R
        Me.ChartGraphTech.Diagram = XyDiagram1
        resources.ApplyResources(Me.ChartGraphTech, "ChartGraphTech")
        Me.ChartGraphTech.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartGraphTech.Name = "ChartGraphTech"
        Series1.ArgumentDataMember = "DIPLDATJ"
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        resources.ApplyResources(Series1, "Series1")
        Series1.ValueDataMembersSerializable = "Heures"
        Me.ChartGraphTech.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        SideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartGraphTech.SeriesTemplate.Label = SideBySideBarSeriesLabel2
		ChartTitle1.TextColor = System.Drawing.Color.Black
        ChartTitle1.WordWrap = True
        Me.ChartGraphTech.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'BtnImprimer
        '
        resources.ApplyResources(Me.BtnImprimer, "BtnImprimer")
        Me.BtnImprimer.Name = "BtnImprimer"
        Me.BtnImprimer.UseVisualStyleBackColor = True
        '
        'frmStatGraphTech
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnImprimer)
        Me.Controls.Add(Me.ChartGraphTech)
        Me.Name = "frmStatGraphTech"
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartGraphTech, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnImprimer As System.Windows.Forms.Button
    Private WithEvents ChartGraphTech As DevExpress.XtraCharts.ChartControl
End Class
