<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTauxDeplacementPlanifs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTauxDeplacementPlanifs))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim ConstantLine1 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim RegressionLine1 As DevExpress.XtraCharts.RegressionLine = New DevExpress.XtraCharts.RegressionLine()
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExportDetails = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.ButtonExporter = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Semaine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.totalPlanif = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nbNvPlanif = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nbModifPlanif = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Taux = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nbMaxDeplace = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nbActPlus3fois3S = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpPer = New System.Windows.Forms.GroupBox()
        Me.ChartCtrlPer = New DevExpress.XtraCharts.ChartControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GridControlDetails = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ndinnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nactnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.vclinom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.vsitnom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nregcod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.vactdes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelDetails = New System.Windows.Forms.Label()
        Me.lblDateJour = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPer.SuspendLayout()
        CType(Me.ChartCtrlPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RegressionLine1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControlDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExportDetails)
        Me.GroupBox1.Controls.Add(Me.BtnPrint)
        Me.GroupBox1.Controls.Add(Me.ButtonExporter)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'btnExportDetails
        '
        resources.ApplyResources(Me.btnExportDetails, "btnExportDetails")
        Me.btnExportDetails.Name = "btnExportDetails"
        Me.btnExportDetails.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'ButtonExporter
        '
        resources.ApplyResources(Me.ButtonExporter, "ButtonExporter")
        Me.ButtonExporter.Name = "ButtonExporter"
        Me.ButtonExporter.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'GridControl1
        '
        resources.ApplyResources(Me.GridControl1, "GridControl1")
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Red
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.Font = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.SelectedRow.BackColor2 = CType(resources.GetObject("GridView1.Appearance.SelectedRow.BackColor2"), System.Drawing.Color)
        Me.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.AppearancePrint.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView1.AppearancePrint.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Semaine, Me.totalPlanif, Me.nbNvPlanif, Me.nbModifPlanif, Me.Taux, Me.nbMaxDeplace, Me.nbActPlus3fois3S})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView1.OptionsPrint.PrintPreview = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Semaine
        '
        Me.Semaine.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Semaine.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Semaine, "Semaine")
        Me.Semaine.FieldName = "numSemaine"
        Me.Semaine.Name = "Semaine"
        '
        'totalPlanif
        '
        Me.totalPlanif.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.totalPlanif.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.totalPlanif, "totalPlanif")
        Me.totalPlanif.FieldName = "totalPlanif"
        Me.totalPlanif.Name = "totalPlanif"
        Me.totalPlanif.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.totalPlanif.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("totalPlanif.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'nbNvPlanif
        '
        Me.nbNvPlanif.AppearanceCell.Font = CType(resources.GetObject("nbNvPlanif.AppearanceCell.Font"), System.Drawing.Font)
        Me.nbNvPlanif.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nbNvPlanif.AppearanceCell.Options.UseFont = True
        Me.nbNvPlanif.AppearanceCell.Options.UseForeColor = True
        Me.nbNvPlanif.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.nbNvPlanif.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.nbNvPlanif, "nbNvPlanif")
        Me.nbNvPlanif.FieldName = "nbNvPlanif"
        Me.nbNvPlanif.Name = "nbNvPlanif"
        Me.nbNvPlanif.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'nbModifPlanif
        '
        Me.nbModifPlanif.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.nbModifPlanif.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.nbModifPlanif, "nbModifPlanif")
        Me.nbModifPlanif.FieldName = "nbModifPlanif"
        Me.nbModifPlanif.Name = "nbModifPlanif"
        '
        'Taux
        '
        Me.Taux.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Taux.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Taux, "Taux")
        Me.Taux.FieldName = "Taux"
        Me.Taux.Name = "Taux"
        '
        'nbMaxDeplace
        '
        Me.nbMaxDeplace.AppearanceCell.Font = CType(resources.GetObject("nbMaxDeplace.AppearanceCell.Font"), System.Drawing.Font)
        Me.nbMaxDeplace.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nbMaxDeplace.AppearanceCell.Options.UseFont = True
        Me.nbMaxDeplace.AppearanceCell.Options.UseForeColor = True
        Me.nbMaxDeplace.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.nbMaxDeplace.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.nbMaxDeplace, "nbMaxDeplace")
        Me.nbMaxDeplace.FieldName = "nbMaxDeplace"
        Me.nbMaxDeplace.Name = "nbMaxDeplace"
        '
        'nbActPlus3fois3S
        '
        Me.nbActPlus3fois3S.AppearanceCell.Font = CType(resources.GetObject("nbActPlus3fois3S.AppearanceCell.Font"), System.Drawing.Font)
        Me.nbActPlus3fois3S.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nbActPlus3fois3S.AppearanceCell.Options.UseFont = True
        Me.nbActPlus3fois3S.AppearanceCell.Options.UseForeColor = True
        Me.nbActPlus3fois3S.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.nbActPlus3fois3S.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.nbActPlus3fois3S, "nbActPlus3fois3S")
        Me.nbActPlus3fois3S.FieldName = "nbActPlus3fois3S"
        Me.nbActPlus3fois3S.Name = "nbActPlus3fois3S"
        '
        'GrpPer
        '
        Me.GrpPer.Controls.Add(Me.ChartCtrlPer)
        resources.ApplyResources(Me.GrpPer, "GrpPer")
        Me.GrpPer.Name = "GrpPer"
        Me.GrpPer.TabStop = False
        '
        'ChartCtrlPer
        '
        XyDiagram1.AxisX.Label.Angle = CType(resources.GetObject("resource.Angle"), Integer)
        XyDiagram1.AxisX.Title.Text = resources.GetString("resource.Text")
        XyDiagram1.AxisX.Title.TextColor = System.Drawing.Color.Black
        XyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisX.WholeRange.AutoSideMargins = False
        XyDiagram1.AxisX.WholeRange.EndSideMargin = 0.4R
        XyDiagram1.AxisX.WholeRange.StartSideMargin = 0.4R
        ConstantLine1.AxisValueSerializable = "1"
        ConstantLine1.Color = System.Drawing.Color.Lime
        ConstantLine1.LineStyle.Thickness = 2
        ConstantLine1.Name = "Objectif"
        ConstantLine1.Title.DXFont = CType(resources.GetObject("resource.DXFont"), DevExpress.Drawing.DXFont)
        ConstantLine1.Title.TextColor = System.Drawing.Color.Lime
        ConstantLine1.Title.Visible = False
        XyDiagram1.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine1})
        XyDiagram1.AxisY.Title.Text = resources.GetString("resource.Text1")
        XyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
        Me.ChartCtrlPer.Diagram = XyDiagram1
        resources.ApplyResources(Me.ChartCtrlPer, "ChartCtrlPer")
        Me.ChartCtrlPer.Legend.EquallySpacedItems = False
        Me.ChartCtrlPer.Legend.Name = "Default Legend"
        Me.ChartCtrlPer.Name = "ChartCtrlPer"
        Series1.ArgumentDataMember = "AXE_X"
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel1.TextPattern = "{V:N0}"
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LegendTextPattern = "{V:P2}"
        Series1.ShowInLegend = False
        Series1.ValueDataMembersSerializable = "Taux"
        SideBySideBarSeriesView1.Color = System.Drawing.Color.DodgerBlue
        RegressionLine1.Color = System.Drawing.Color.Fuchsia
        SideBySideBarSeriesView1.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {RegressionLine1})
        Series1.View = SideBySideBarSeriesView1
        Me.ChartCtrlPer.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        SideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartCtrlPer.SeriesTemplate.Label = SideBySideBarSeriesLabel2
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'GridControlDetails
        '
        resources.ApplyResources(Me.GridControlDetails, "GridControlDetails")
        Me.GridControlDetails.MainView = Me.GridView2
        Me.GridControlDetails.Name = "GridControlDetails"
        Me.GridControlDetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Red
        Me.GridView2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HeaderPanel.Font = CType(resources.GetObject("GridView2.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView2.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView2.Appearance.OddRow.Options.UseBorderColor = True
        Me.GridView2.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.SelectedRow.BackColor2 = CType(resources.GetObject("GridView2.Appearance.SelectedRow.BackColor2"), System.Drawing.Color)
        Me.GridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView2.AppearancePrint.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView2.AppearancePrint.FilterPanel.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ndinnum, Me.nactnum, Me.vclinom, Me.vsitnom, Me.nregcod, Me.vactdes})
        Me.GridView2.GridControl = Me.GridControlDetails
        Me.GridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView2.OptionsPrint.PrintPreview = True
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView2.OptionsView.EnableAppearanceOddRow = True
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'ndinnum
        '
        Me.ndinnum.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ndinnum.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.ndinnum, "ndinnum")
        Me.ndinnum.FieldName = "ndinnum"
        Me.ndinnum.Name = "ndinnum"
        Me.ndinnum.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ndinnum.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'nactnum
        '
        Me.nactnum.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.nactnum.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.nactnum, "nactnum")
        Me.nactnum.FieldName = "nactnum"
        Me.nactnum.Name = "nactnum"
        Me.nactnum.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'vclinom
        '
        Me.vclinom.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.vclinom.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.vclinom, "vclinom")
        Me.vclinom.FieldName = "vclinom"
        Me.vclinom.Name = "vclinom"
        '
        'vsitnom
        '
        Me.vsitnom.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.vsitnom.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.vsitnom, "vsitnom")
        Me.vsitnom.FieldName = "vsitnom"
        Me.vsitnom.Name = "vsitnom"
        '
        'nregcod
        '
        Me.nregcod.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.nregcod.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.nregcod, "nregcod")
        Me.nregcod.FieldName = "nregcod"
        Me.nregcod.Name = "nregcod"
        '
        'vactdes
        '
        Me.vactdes.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.vactdes.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.vactdes, "vactdes")
        Me.vactdes.FieldName = "vactdes"
        Me.vactdes.Name = "vactdes"
        '
        'LabelDetails
        '
        resources.ApplyResources(Me.LabelDetails, "LabelDetails")
        Me.LabelDetails.Name = "LabelDetails"
        '
        'lblDateJour
        '
        resources.ApplyResources(Me.lblDateJour, "lblDateJour")
        Me.lblDateJour.Name = "lblDateJour"
        '
        'frmTauxDeplacementPlanifs
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.lblDateJour)
        Me.Controls.Add(Me.LabelDetails)
        Me.Controls.Add(Me.GridControlDetails)
        Me.Controls.Add(Me.GrpPer)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "frmTauxDeplacementPlanifs"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPer.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RegressionLine1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartCtrlPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControlDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents BtnPrint As System.Windows.Forms.Button
  Friend WithEvents ButtonExporter As System.Windows.Forms.Button
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents GrpPer As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents LabelDetails As System.Windows.Forms.Label
    Friend WithEvents btnExportDetails As System.Windows.Forms.Button
    Friend WithEvents lblDateJour As System.Windows.Forms.Label
    Private WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents Semaine As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents totalPlanif As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents nbNvPlanif As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents nbModifPlanif As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Taux As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents nbMaxDeplace As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents nbActPlus3fois3S As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ChartCtrlPer As DevExpress.XtraCharts.ChartControl
    Private WithEvents GridControlDetails As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ndinnum As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents nactnum As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents vclinom As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents vsitnom As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents vactdes As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents nregcod As DevExpress.XtraGrid.Columns.GridColumn
End Class
