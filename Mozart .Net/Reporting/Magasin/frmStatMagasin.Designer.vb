<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatMagasin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatMagasin))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim ConstantLine1 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedBarSeriesLabel1 As DevExpress.XtraCharts.StackedBarSeriesLabel = New DevExpress.XtraCharts.StackedBarSeriesLabel()
        Dim StackedBarSeriesView1 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim RegressionLine1 As DevExpress.XtraCharts.RegressionLine = New DevExpress.XtraCharts.RegressionLine()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedBarSeriesLabel2 As DevExpress.XtraCharts.StackedBarSeriesLabel = New DevExpress.XtraCharts.StackedBarSeriesLabel()
        Dim StackedBarSeriesView2 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim RegressionLine2 As DevExpress.XtraCharts.RegressionLine = New DevExpress.XtraCharts.RegressionLine()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedBarSeriesLabel3 As DevExpress.XtraCharts.StackedBarSeriesLabel = New DevExpress.XtraCharts.StackedBarSeriesLabel()
        Dim StackedBarSeriesView3 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim RegressionLine3 As DevExpress.XtraCharts.RegressionLine = New DevExpress.XtraCharts.RegressionLine()
        Dim StackedBarSeriesView4 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim ConstantLine2 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim RegressionLine4 As DevExpress.XtraCharts.RegressionLine = New DevExpress.XtraCharts.RegressionLine()
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblObj = New System.Windows.Forms.Label()
        Me.lblPerim = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMoy12 = New System.Windows.Forms.Label()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblObjBas = New System.Windows.Forms.Label()
        Me.lblPerim2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMoy2 = New System.Windows.Forms.Label()
        Me.GrpPer = New System.Windows.Forms.GroupBox()
        Me.ChartBas = New DevExpress.XtraCharts.ChartControl()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChartHaut = New DevExpress.XtraCharts.ChartControl()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GCStatHaut = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GCstatBas = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.GrpActions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrpPer.SuspendLayout()
        CType(Me.ChartBas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RegressionLine1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RegressionLine2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RegressionLine3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedBarSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ChartHaut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RegressionLine4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GCStatHaut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.GCstatBas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblObj)
        Me.GroupBox3.Controls.Add(Me.lblPerim)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lblMoy12)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'lblObj
        '
        Me.lblObj.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblObj, "lblObj")
        Me.lblObj.Name = "lblObj"
        '
        'lblPerim
        '
        Me.lblPerim.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPerim, "lblPerim")
        Me.lblPerim.ForeColor = System.Drawing.Color.Black
        Me.lblPerim.Name = "lblPerim"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'lblMoy12
        '
        Me.lblMoy12.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblMoy12, "lblMoy12")
        Me.lblMoy12.ForeColor = System.Drawing.Color.Black
        Me.lblMoy12.Name = "lblMoy12"
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblObjBas)
        Me.GroupBox1.Controls.Add(Me.lblPerim2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblMoy2)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'lblObjBas
        '
        Me.lblObjBas.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblObjBas, "lblObjBas")
        Me.lblObjBas.Name = "lblObjBas"
        '
        'lblPerim2
        '
        Me.lblPerim2.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPerim2, "lblPerim2")
        Me.lblPerim2.ForeColor = System.Drawing.Color.Black
        Me.lblPerim2.Name = "lblPerim2"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'lblMoy2
        '
        Me.lblMoy2.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblMoy2, "lblMoy2")
        Me.lblMoy2.ForeColor = System.Drawing.Color.Black
        Me.lblMoy2.Name = "lblMoy2"
        '
        'GrpPer
        '
        Me.GrpPer.Controls.Add(Me.ChartBas)
        resources.ApplyResources(Me.GrpPer, "GrpPer")
        Me.GrpPer.Name = "GrpPer"
        Me.GrpPer.TabStop = False
        '
        'ChartBas
        '
        XyDiagram1.AxisX.Label.Angle = CType(resources.GetObject("resource.Angle"), Integer)
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        ConstantLine1.AxisValueSerializable = "1"
        ConstantLine1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        resources.ApplyResources(ConstantLine1, "ConstantLine1")
        ConstantLine1.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Solid
        ConstantLine1.LineStyle.Thickness = 2
        ConstantLine1.Name = "Objectif"
        ConstantLine1.Title.DXFont = CType(resources.GetObject("resource.DXFont"), DevExpress.Drawing.DXFont)
        ConstantLine1.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        ConstantLine1.Title.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        XyDiagram1.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine1})
        XyDiagram1.AxisY.Title.Text = resources.GetString("resource.Text")
        XyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartBas.Diagram = XyDiagram1
        resources.ApplyResources(Me.ChartBas, "ChartBas")
        Me.ChartBas.Legend.AlignmentHorizontal = CType(resources.GetObject("ChartBas.Legend.AlignmentHorizontal"), DevExpress.XtraCharts.LegendAlignmentHorizontal)
        Me.ChartBas.Legend.AlignmentVertical = CType(resources.GetObject("ChartBas.Legend.AlignmentVertical"), DevExpress.XtraCharts.LegendAlignmentVertical)
        Me.ChartBas.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.ChartBas.Legend.EquallySpacedItems = False
        Me.ChartBas.Legend.Name = "Default Legend"
        Me.ChartBas.Name = "ChartBas"
        Series1.ArgumentDataMember = "LIB"
        StackedBarSeriesLabel1.TextPattern = "{V:N0}"
        Series1.Label = StackedBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series1.LegendName = "Default Legend"
        Series1.LegendTextPattern = "Sorties de stock"
        resources.ApplyResources(Series1, "Series1")
        Series1.ValueDataMembersSerializable = "NB"
        StackedBarSeriesView1.Color = System.Drawing.Color.DodgerBlue
        RegressionLine1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(RegressionLine1, "RegressionLine1")
        StackedBarSeriesView1.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {RegressionLine1})
        Series1.View = StackedBarSeriesView1
        Series2.ArgumentDataMember = "LIB"
        StackedBarSeriesLabel2.TextPattern = "{V:N0}"
        Series2.Label = StackedBarSeriesLabel2
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series2.LegendTextPattern = "BL Libres"
        resources.ApplyResources(Series2, "Series2")
        Series2.ValueDataMembersSerializable = "NB2"
        StackedBarSeriesView2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        RegressionLine2.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        resources.ApplyResources(RegressionLine2, "RegressionLine2")
        StackedBarSeriesView2.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {RegressionLine2})
        Series2.View = StackedBarSeriesView2
        Series3.ArgumentDataMember = "LIB"
        StackedBarSeriesLabel3.TextPattern = "{V:N0}"
        Series3.Label = StackedBarSeriesLabel3
        Series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series3.LegendTextPattern = "Fournitures du batiment"
        resources.ApplyResources(Series3, "Series3")
        Series3.ValueDataMembersSerializable = "NB3"
        StackedBarSeriesView3.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        RegressionLine3.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        resources.ApplyResources(RegressionLine3, "RegressionLine3")
        StackedBarSeriesView3.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {RegressionLine3})
        Series3.View = StackedBarSeriesView3
        Me.ChartBas.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2, Series3}
        Me.ChartBas.SeriesTemplate.View = StackedBarSeriesView4
        resources.ApplyResources(ChartTitle1, "ChartTitle1")
        ChartTitle1.TextColor = System.Drawing.Color.Black
        Me.ChartBas.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChartHaut)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'ChartHaut
        '
        XyDiagram2.AxisX.Label.Angle = CType(resources.GetObject("resource.Angle1"), Integer)
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        ConstantLine2.AxisValueSerializable = "1"
        ConstantLine2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        ConstantLine2.LineStyle.Thickness = 2
        ConstantLine2.Name = "Objectif"
        ConstantLine2.Title.DXFont = CType(resources.GetObject("resource.DXFont1"), DevExpress.Drawing.DXFont)
        ConstantLine2.Title.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        XyDiagram2.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine2})
        XyDiagram2.AxisY.Title.Text = resources.GetString("resource.Text1")
        XyDiagram2.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.WholeRange.AlwaysShowZeroLevel = False
        Me.ChartHaut.Diagram = XyDiagram2
        resources.ApplyResources(Me.ChartHaut, "ChartHaut")
        Me.ChartHaut.Legend.AlignmentHorizontal = CType(resources.GetObject("ChartHaut.Legend.AlignmentHorizontal"), DevExpress.XtraCharts.LegendAlignmentHorizontal)
        Me.ChartHaut.Legend.EquallySpacedItems = False
        Me.ChartHaut.Legend.Name = "Default Legend"
        Me.ChartHaut.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartHaut.Name = "ChartHaut"
        Series4.ArgumentDataMember = "LIB"
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel1.TextPattern = "{V:N0}"
        Series4.Label = SideBySideBarSeriesLabel1
        Series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        resources.ApplyResources(Series4, "Series4")
        Series4.ShowInLegend = False
        Series4.ValueDataMembersSerializable = "NB"
        SideBySideBarSeriesView1.Color = System.Drawing.Color.DodgerBlue
        resources.ApplyResources(RegressionLine4, "RegressionLine4")
        SideBySideBarSeriesView1.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {RegressionLine4})
        Series4.View = SideBySideBarSeriesView1
        Me.ChartHaut.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series4}
        SideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartHaut.SeriesTemplate.Label = SideBySideBarSeriesLabel2
        resources.ApplyResources(ChartTitle2, "ChartTitle2")
        ChartTitle2.TextColor = System.Drawing.Color.Black
        Me.ChartHaut.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GCStatHaut)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'GCStatHaut
        '
        resources.ApplyResources(Me.GCStatHaut, "GCStatHaut")
        Me.GCStatHaut.MainView = Me.GridView2
        Me.GCStatHaut.Name = "GCStatHaut"
        Me.GCStatHaut.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.HeaderPanel.Font = CType(resources.GetObject("GridView2.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
        Me.GridView2.GridControl = Me.GCStatHaut
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn3, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn3.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn3, "GridColumn3")
        Me.GridColumn3.FieldName = "LIB"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn4.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn4, "GridColumn4")
        Me.GridColumn4.FieldName = "NB"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GCstatBas)
        Me.GroupBox5.Controls.Add(Me.GrpPer)
        Me.GroupBox5.Controls.Add(Me.GroupBox1)
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'GCstatBas
        '
        resources.ApplyResources(Me.GCstatBas, "GCstatBas")
        Me.GCstatBas.MainView = Me.GridView1
        Me.GCstatBas.Name = "GCstatBas"
        Me.GCstatBas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.GridControl = Me.GCstatBas
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn1.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.FieldName = "LIB"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn2.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn2, "GridColumn2")
        Me.GridColumn2.FieldName = "TOTAL"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'frmStatMagasin
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmStatMagasin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GrpActions.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GrpPer.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RegressionLine1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RegressionLine2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RegressionLine3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedBarSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartBas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RegressionLine4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartHaut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GCStatHaut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.GCstatBas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents lblObj As System.Windows.Forms.Label
  Friend WithEvents lblPerim As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents lblMoy12 As System.Windows.Forms.Label
  Friend WithEvents BtnPrint As System.Windows.Forms.Button
  Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents lblPerim2 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lblMoy2 As System.Windows.Forms.Label
  Friend WithEvents GrpPer As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblObjBas As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents ChartBas As DevExpress.XtraCharts.ChartControl
    Private WithEvents ChartHaut As DevExpress.XtraCharts.ChartControl
    Private WithEvents GCstatBas As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCStatHaut As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
