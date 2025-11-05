<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevisAttenteChaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevisAttenteChaff))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim ConstantLine1 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim Bar3DSeriesLabel1 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel()
        Dim SideBySideBar3DSeriesView1 As DevExpress.XtraCharts.SideBySideBar3DSeriesView = New DevExpress.XtraCharts.SideBySideBar3DSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim ConstantLine2 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Bar3DSeriesLabel2 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel()
        Dim SideBySideBar3DSeriesView2 As DevExpress.XtraCharts.SideBySideBar3DSeriesView = New DevExpress.XtraCharts.SideBySideBar3DSeriesView()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.GrpPer = New System.Windows.Forms.GroupBox()
        Me.ChartControl0 = New DevExpress.XtraCharts.ChartControl()
        Me.lblPerim = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GrpPer.SuspendLayout()
        CType(Me.ChartControl0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBar3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Bar3DSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBar3DSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpPer
        '
        resources.ApplyResources(Me.GrpPer, "GrpPer")
        Me.GrpPer.Controls.Add(Me.ChartControl0)
        Me.GrpPer.Name = "GrpPer"
        Me.GrpPer.TabStop = False
        '
        'ChartControl0
        '
        resources.ApplyResources(Me.ChartControl0, "ChartControl0")
        XyDiagram1.AxisX.Label.Angle = CType(resources.GetObject("resource.Angle"), Integer)
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        ConstantLine1.AxisValueSerializable = "1"
        ConstantLine1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        resources.ApplyResources(ConstantLine1, "ConstantLine1")
        ConstantLine1.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Solid
        ConstantLine1.LineStyle.Thickness = 2
        ConstantLine1.Name = "Objectif"
        ConstantLine1.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        ConstantLine1.Title.Font = CType(resources.GetObject("resource.Font"), System.Drawing.Font)
        ConstantLine1.Title.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        ConstantLine1.Visible = False
        XyDiagram1.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine1})
        XyDiagram1.AxisY.Title.Text = resources.GetString("resource.Text")
        XyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl0.Diagram = XyDiagram1
        Me.ChartControl0.Legend.EquallySpacedItems = False
        Me.ChartControl0.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartControl0.Name = "ChartControl0"
        Series1.ArgumentDataMember = "Chaff"
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.Label = SideBySideBarSeriesLabel1
        resources.ApplyResources(Series1, "Series1")
        Series1.Tag = "NPERNUM"
        Series1.ToolTipHintDataMember = "NPERNUM"
        Series1.ValueDataMembersSerializable = "MNT"
        Me.ChartControl0.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Bar3DSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl0.SeriesTemplate.Label = Bar3DSeriesLabel1
        Me.ChartControl0.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl0.SeriesTemplate.View = SideBySideBar3DSeriesView1
        resources.ApplyResources(ChartTitle1, "ChartTitle1")
		ChartTitle1.TextColor = System.Drawing.Color.Black
        Me.ChartControl0.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'lblPerim
        '
        resources.ApplyResources(Me.lblPerim, "lblPerim")
        Me.lblPerim.BackColor = System.Drawing.Color.White
        Me.lblPerim.ForeColor = System.Drawing.Color.Black
        Me.lblPerim.Name = "lblPerim"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Name = "Label4"
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
        ConstantLine2.AxisValueSerializable = "1"
        ConstantLine2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        resources.ApplyResources(ConstantLine2, "ConstantLine2")
        ConstantLine2.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Solid
        ConstantLine2.LineStyle.Thickness = 2
        ConstantLine2.Name = "Objectif"
        ConstantLine2.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        ConstantLine2.Title.Font = CType(resources.GetObject("resource.Font1"), System.Drawing.Font)
        ConstantLine2.Title.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        ConstantLine2.Visible = False
        XyDiagram2.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine2})
        XyDiagram2.AxisY.Title.Text = resources.GetString("resource.Text1")
        XyDiagram2.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram2
        Me.ChartControl1.Legend.EquallySpacedItems = False
        Me.ChartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartControl1.Name = "ChartControl1"
        Series2.ArgumentDataMember = "Chaff"
        SideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel2.TextPattern = "{V:N0}"
        Series2.Label = SideBySideBarSeriesLabel2
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        resources.ApplyResources(Series2, "Series2")
        Series2.ShowInLegend = False
        Series2.Tag = "NPERNUM"
        Series2.ToolTipHintDataMember = "NPERNUM"
        Series2.ValueDataMembersSerializable = "NB"
        SideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        SideBySideBarSeriesView1.Transparency = CType(30, Byte)
        Series2.View = SideBySideBarSeriesView1
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        Bar3DSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.SeriesTemplate.Label = Bar3DSeriesLabel2
        Me.ChartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.SeriesTemplate.View = SideBySideBar3DSeriesView2
        resources.ApplyResources(ChartTitle2, "ChartTitle2")
		ChartTitle2.TextColor = System.Drawing.Color.Black
        Me.ChartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Name = "Label3"
        '
        'frmDevisAttenteChaff
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.lblPerim)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GrpPer)
        Me.Name = "frmDevisAttenteChaff"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpPer.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBar3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Bar3DSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBar3DSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpPer As System.Windows.Forms.GroupBox
    Friend WithEvents lblPerim As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents ChartControl0 As DevExpress.XtraCharts.ChartControl
    Private WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
End Class
