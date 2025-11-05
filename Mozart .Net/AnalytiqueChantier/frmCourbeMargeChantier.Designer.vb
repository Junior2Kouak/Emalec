<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourbeMargeChantier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCourbeMargeChantier))
        Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Me.ChartGraph = New DevExpress.XtraCharts.ChartControl()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnImprim = New System.Windows.Forms.Button()
        Me.btnFermer = New System.Windows.Forms.Button()
        CType(Me.ChartGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChartGraph
        '
        resources.ApplyResources(Me.ChartGraph, "ChartGraph")
        Me.ChartGraph.Name = "ChartGraph"
        Me.ChartGraph.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        PointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartGraph.SeriesTemplate.Label = PointSeriesLabel1
        Me.ChartGraph.SeriesTemplate.View = LineSeriesView1
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnImprim)
        Me.GrpActions.Controls.Add(Me.btnFermer)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnImprim
        '
        resources.ApplyResources(Me.BtnImprim, "BtnImprim")
        Me.BtnImprim.Name = "BtnImprim"
        Me.BtnImprim.UseVisualStyleBackColor = True
        '
        'btnFermer
        '
        resources.ApplyResources(Me.btnFermer, "btnFermer")
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'frmCourbeMargeChantier
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.ChartGraph)
        Me.Name = "frmCourbeMargeChantier"
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnImprim As System.Windows.Forms.Button
    Friend WithEvents btnFermer As System.Windows.Forms.Button
    Private WithEvents ChartGraph As DevExpress.XtraCharts.ChartControl
End Class
