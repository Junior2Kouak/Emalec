<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevisAFaire
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevisAFaire))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedBarSeriesLabel1 As DevExpress.XtraCharts.StackedBarSeriesLabel = New DevExpress.XtraCharts.StackedBarSeriesLabel()
        Dim StackedBarSeriesView1 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedBarSeriesLabel2 As DevExpress.XtraCharts.StackedBarSeriesLabel = New DevExpress.XtraCharts.StackedBarSeriesLabel()
        Dim StackedBarSeriesView2 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim StackedBarSeriesView3 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedBarSeriesLabel3 As DevExpress.XtraCharts.StackedBarSeriesLabel = New DevExpress.XtraCharts.StackedBarSeriesLabel()
        Dim StackedBarSeriesView4 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedBarSeriesLabel4 As DevExpress.XtraCharts.StackedBarSeriesLabel = New DevExpress.XtraCharts.StackedBarSeriesLabel()
        Dim StackedBarSeriesView5 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim StackedBarSeriesView6 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.GrpPer = New System.Windows.Forms.GroupBox()
        Me.ChartBas = New DevExpress.XtraCharts.ChartControl()
        Me.lblPerim2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        Me.GrpPer.SuspendLayout()
        CType(Me.ChartBas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'GrpPer
        '
        resources.ApplyResources(Me.GrpPer, "GrpPer")
        Me.GrpPer.Controls.Add(Me.ChartBas)
        Me.GrpPer.Name = "GrpPer"
        Me.GrpPer.TabStop = False
        '
        'ChartBas
        '
        resources.ApplyResources(Me.ChartBas, "ChartBas")
        XyDiagram1.AxisX.Label.Angle = CType(resources.GetObject("resource.Angle"), Integer)
        XyDiagram1.AxisX.Label.Font = CType(resources.GetObject("resource.Font"), System.Drawing.Font)
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Title.Font = CType(resources.GetObject("resource.Font1"), System.Drawing.Font)
        XyDiagram1.AxisY.Title.Text = resources.GetString("resource.Text")
        XyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartBas.Diagram = XyDiagram1
        Me.ChartBas.Legend.EquallySpacedItems = False
        Me.ChartBas.Name = "ChartBas"
        Series1.ArgumentDataMember = "client"
        StackedBarSeriesLabel1.TextPattern = "{V:N0}"
        Series1.Label = StackedBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        resources.ApplyResources(Series1, "Series1")
        Series1.Tag = "NCLINUM"
        Series1.ValueDataMembersSerializable = "NB_dev"
        StackedBarSeriesView1.Color = System.Drawing.Color.Red
        StackedBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
        Series1.View = StackedBarSeriesView1
        Series2.ArgumentDataMember = "client"
        StackedBarSeriesLabel2.TextPattern = "{V:N0}"
        Series2.Label = StackedBarSeriesLabel2
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        resources.ApplyResources(Series2, "Series2")
        Series2.Tag = "NCLINUM"
        Series2.ValueDataMembersSerializable = "NB_devwebtech"
        StackedBarSeriesView2.Color = System.Drawing.Color.Blue
        StackedBarSeriesView2.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
        Series2.View = StackedBarSeriesView2
        Me.ChartBas.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
        Me.ChartBas.SeriesTemplate.View = StackedBarSeriesView3
        resources.ApplyResources(ChartTitle1, "ChartTitle1")
		ChartTitle1.TextColor = System.Drawing.Color.Black
        Me.ChartBas.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'lblPerim2
        '
        resources.ApplyResources(Me.lblPerim2, "lblPerim2")
        Me.lblPerim2.BackColor = System.Drawing.Color.White
        Me.lblPerim2.ForeColor = System.Drawing.Color.Black
        Me.lblPerim2.Name = "lblPerim2"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.ChartControl1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'ChartControl1
        '
        resources.ApplyResources(Me.ChartControl1, "ChartControl1")
        XyDiagram2.AxisX.Label.Angle = CType(resources.GetObject("resource.Angle1"), Integer)
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.Title.Font = CType(resources.GetObject("resource.Font2"), System.Drawing.Font)
        XyDiagram2.AxisY.Title.Text = resources.GetString("resource.Text1")
        XyDiagram2.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram2
        Me.ChartControl1.Legend.EquallySpacedItems = False
        Me.ChartControl1.Name = "ChartControl1"
        Series3.ArgumentDataMember = "chaff"
        StackedBarSeriesLabel3.TextPattern = "{V:N0}"
        Series3.Label = StackedBarSeriesLabel3
        Series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        resources.ApplyResources(Series3, "Series3")
        Series3.Tag = "NPERNUM"
        Series3.ValueDataMembersSerializable = "NB_dev"
        StackedBarSeriesView4.Color = System.Drawing.Color.Red
        StackedBarSeriesView4.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
        Series3.View = StackedBarSeriesView4
        Series4.ArgumentDataMember = "chaff"
        StackedBarSeriesLabel4.TextPattern = "{V:N0}"
        Series4.Label = StackedBarSeriesLabel4
        Series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        resources.ApplyResources(Series4, "Series4")
        Series4.Tag = "NPERNUM"
        Series4.ValueDataMembersSerializable = "NB_devwebtech"
        StackedBarSeriesView5.Color = System.Drawing.Color.Blue
        StackedBarSeriesView5.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
        Series4.View = StackedBarSeriesView5
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3, Series4}
        Me.ChartControl1.SeriesTemplate.View = StackedBarSeriesView6
        resources.ApplyResources(ChartTitle2, "ChartTitle2")
		ChartTitle2.TextColor = System.Drawing.Color.Black
        Me.ChartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Name = "Label5"
        '
        'frmDevisAFaire
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPerim2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GrpPer)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmDevisAFaire"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.GrpPer.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartBas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents BtnPrint As System.Windows.Forms.Button
  Friend WithEvents GrpPer As System.Windows.Forms.GroupBox
    Friend WithEvents lblPerim2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents ChartBas As DevExpress.XtraCharts.ChartControl
    Private WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
End Class
