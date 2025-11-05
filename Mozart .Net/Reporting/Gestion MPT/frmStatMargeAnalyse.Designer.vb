<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatMargeAnalyse
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatMargeAnalyse))
    Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
    Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
    Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
    Dim ConstantLine1 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
    Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
    Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
    Dim RegressionLine1 As DevExpress.XtraCharts.RegressionLine = New DevExpress.XtraCharts.RegressionLine()
    Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
    Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
    Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
    Dim ConstantLine2 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
    Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
    Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
    Dim RegressionLine2 As DevExpress.XtraCharts.RegressionLine = New DevExpress.XtraCharts.RegressionLine()
    Dim SideBySideBarSeriesLabel4 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
    Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
    Dim XyDiagram3 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
    Dim ConstantLine3 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
    Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim SideBySideBarSeriesLabel5 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
    Dim SideBySideBarSeriesView3 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
    Dim RegressionLine3 As DevExpress.XtraCharts.RegressionLine = New DevExpress.XtraCharts.RegressionLine()
    Dim SideBySideBarSeriesLabel6 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
    Dim ChartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
    Me.MoyHeures = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCStat = New DevExpress.XtraGrid.GridControl()
    Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.nclinum = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.npernum = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.vclinom = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ncannum = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.CHAFF = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.CA = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.MargeNetteAnalytique = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.NbAct = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.MntMoyFact = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.NbHeuresStruct = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BudgRestant = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BtValider = New System.Windows.Forms.Button()
    Me.BtnDate2 = New System.Windows.Forms.Button()
    Me.txtDtFin = New System.Windows.Forms.TextBox()
    Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
    Me.BtnDate1 = New System.Windows.Forms.Button()
    Me.txtDtDebut = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.BtnExport = New System.Windows.Forms.Button()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Grp1 = New System.Windows.Forms.GroupBox()
    Me.Chart1 = New DevExpress.XtraCharts.ChartControl()
    Me.Grp2 = New System.Windows.Forms.GroupBox()
    Me.Chart2 = New DevExpress.XtraCharts.ChartControl()
    Me.Grp3 = New System.Windows.Forms.GroupBox()
    Me.Chart3 = New DevExpress.XtraCharts.ChartControl()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.Grp1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RegressionLine1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grp2.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RegressionLine2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grp3.SuspendLayout()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RegressionLine3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MoyHeures
        '
        Me.MoyHeures.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.MoyHeures.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.MoyHeures, "MoyHeures")
        Me.MoyHeures.DisplayFormat.FormatString = "n0"
        Me.MoyHeures.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MoyHeures.FieldName = "MoyHeures"
        Me.MoyHeures.Name = "MoyHeures"
        '
        'GCStat
        '
        resources.ApplyResources(Me.GCStat, "GCStat")
        Me.GCStat.MainView = Me.GVStat
        Me.GCStat.Name = "GCStat"
        Me.GCStat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStat})
        '
        'GVStat
        '
        Me.GVStat.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVStat.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVStat.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVStat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVStat.ColumnPanelRowHeight = 75
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nclinum, Me.npernum, Me.vclinom, Me.ncannum, Me.CHAFF, Me.CA, Me.MargeNetteAnalytique, Me.NbAct, Me.MntMoyFact, Me.NbHeuresStruct, Me.MoyHeures, Me.BudgRestant})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.MoyHeures
        GridFormatRule1.Name = "Colsup20"
        FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Red
        FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Greater
        FormatConditionRuleValue1.Value1 = CType(20, Short)
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.GVStat.FormatRules.Add(GridFormatRule1)
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsView.ShowAutoFilterRow = True
        Me.GVStat.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'nclinum
        '
        resources.ApplyResources(Me.nclinum, "nclinum")
        Me.nclinum.FieldName = "nclinum"
        Me.nclinum.MinWidth = 10
        Me.nclinum.Name = "nclinum"
        '
        'npernum
        '
        resources.ApplyResources(Me.npernum, "npernum")
        Me.npernum.FieldName = "npernum"
        Me.npernum.Name = "npernum"
        '
        'vclinom
        '
        Me.vclinom.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.vclinom.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.vclinom, "vclinom")
        Me.vclinom.FieldName = "vclinom"
        Me.vclinom.Name = "vclinom"
        Me.vclinom.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.vclinom.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("vclinom.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("vclinom.Summary1"), resources.GetString("vclinom.Summary2"))})
        '
        'ncannum
        '
        Me.ncannum.AppearanceCell.Options.UseTextOptions = True
        Me.ncannum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ncannum.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ncannum.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.ncannum, "ncannum")
        Me.ncannum.FieldName = "ncannum"
        Me.ncannum.Name = "ncannum"
        '
        'CHAFF
        '
        Me.CHAFF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.CHAFF.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.CHAFF, "CHAFF")
        Me.CHAFF.FieldName = "CHAFF"
        Me.CHAFF.Name = "CHAFF"
        Me.CHAFF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'CA
        '
        Me.CA.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.CA.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.CA, "CA")
        Me.CA.DisplayFormat.FormatString = "n0"
        Me.CA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CA.FieldName = "CA"
        Me.CA.Name = "CA"
        '
        'MargeNetteAnalytique
        '
        Me.MargeNetteAnalytique.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.MargeNetteAnalytique.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.MargeNetteAnalytique, "MargeNetteAnalytique")
        Me.MargeNetteAnalytique.FieldName = "MargeNette"
        Me.MargeNetteAnalytique.Name = "MargeNetteAnalytique"
        '
        'NbAct
        '
        Me.NbAct.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NbAct.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NbAct, "NbAct")
        Me.NbAct.DisplayFormat.FormatString = "n0"
        Me.NbAct.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NbAct.FieldName = "NbAct"
        Me.NbAct.Name = "NbAct"
        '
        'MntMoyFact
        '
        Me.MntMoyFact.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.MntMoyFact.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.MntMoyFact, "MntMoyFact")
        Me.MntMoyFact.DisplayFormat.FormatString = "n0"
        Me.MntMoyFact.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MntMoyFact.FieldName = "MntMoyFact"
        Me.MntMoyFact.Name = "MntMoyFact"
        '
        'NbHeuresStruct
        '
        Me.NbHeuresStruct.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NbHeuresStruct.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NbHeuresStruct, "NbHeuresStruct")
        Me.NbHeuresStruct.DisplayFormat.FormatString = "n0"
        Me.NbHeuresStruct.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NbHeuresStruct.FieldName = "NbHeuresStruct"
        Me.NbHeuresStruct.Name = "NbHeuresStruct"
        '
        'BudgRestant
        '
        Me.BudgRestant.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BudgRestant.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.BudgRestant, "BudgRestant")
        Me.BudgRestant.FieldName = "BudgRestant"
        Me.BudgRestant.Name = "BudgRestant"
        '
        'BtValider
        '
        resources.ApplyResources(Me.BtValider, "BtValider")
        Me.BtValider.Name = "BtValider"
        Me.BtValider.UseVisualStyleBackColor = True
        '
        'BtnDate2
        '
        Me.BtnDate2.Image = Global.MozartNet.My.Resources.Resources.choix_calendrier
        resources.ApplyResources(Me.BtnDate2, "BtnDate2")
        Me.BtnDate2.Name = "BtnDate2"
        Me.BtnDate2.UseVisualStyleBackColor = True
        '
        'txtDtFin
        '
        resources.ApplyResources(Me.txtDtFin, "txtDtFin")
        Me.txtDtFin.Name = "txtDtFin"
        '
        'MonthCalendar1
        '
        resources.ApplyResources(Me.MonthCalendar1, "MonthCalendar1")
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.Tag = ""
        '
        'BtnDate1
        '
        Me.BtnDate1.Image = Global.MozartNet.My.Resources.Resources.choix_calendrier
        resources.ApplyResources(Me.BtnDate1, "BtnDate1")
        Me.BtnDate1.Name = "BtnDate1"
        Me.BtnDate1.UseVisualStyleBackColor = True
        '
        'txtDtDebut
        '
        resources.ApplyResources(Me.txtDtDebut, "txtDtDebut")
        Me.txtDtDebut.Name = "txtDtDebut"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnExport)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnExport
        '
        resources.ApplyResources(Me.BtnExport, "BtnExport")
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Grp1
        '
        Me.Grp1.Controls.Add(Me.Chart1)
        resources.ApplyResources(Me.Grp1, "Grp1")
        Me.Grp1.Name = "Grp1"
        Me.Grp1.TabStop = False
        '
        'Chart1
        '
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        ConstantLine1.AxisValueSerializable = "1"
        ConstantLine1.Color = System.Drawing.Color.Fuchsia
        resources.ApplyResources(ConstantLine1, "ConstantLine1")
        ConstantLine1.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Solid
        ConstantLine1.LineStyle.Thickness = 2
        ConstantLine1.Name = "Moyenne"
        ConstantLine1.ShowInLegend = False
        ConstantLine1.Title.DXFont = CType(resources.GetObject("resource.DXFont"), DevExpress.Drawing.DXFont)
        ConstantLine1.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        ConstantLine1.Title.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        ConstantLine1.Visible = False
        XyDiagram1.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine1})
        XyDiagram1.AxisY.Title.Text = resources.GetString("resource.Text")
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
        Me.Chart1.Diagram = XyDiagram1
        resources.ApplyResources(Me.Chart1, "Chart1")
        Me.Chart1.Legend.EquallySpacedItems = False
        Me.Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.Chart1.Name = "Chart1"
        Series1.ArgumentDataMember = "periode"
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel1.TextPattern = "{V:N0}"
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series1.LegendTextPattern = "  Nouveaux Sous-traitant"
        resources.ApplyResources(Series1, "Series1")
        Series1.ShowInLegend = False
        Series1.ValueDataMembersSerializable = "MoyHeures"
        SideBySideBarSeriesView1.Color = System.Drawing.Color.DodgerBlue
        SideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient
        RegressionLine1.Color = System.Drawing.Color.Fuchsia
        resources.ApplyResources(RegressionLine1, "RegressionLine1")
        SideBySideBarSeriesView1.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {RegressionLine1})
        Series1.View = SideBySideBarSeriesView1
        Me.Chart1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        SideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.Chart1.SeriesTemplate.Label = SideBySideBarSeriesLabel2
        resources.ApplyResources(ChartTitle1, "ChartTitle1")
        ChartTitle1.TextColor = System.Drawing.Color.Black
        Me.Chart1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'Grp2
        '
        Me.Grp2.Controls.Add(Me.Chart2)
        resources.ApplyResources(Me.Grp2, "Grp2")
        Me.Grp2.Name = "Grp2"
        Me.Grp2.TabStop = False
        '
        'Chart2
        '
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        ConstantLine2.AxisValueSerializable = "1"
        ConstantLine2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        resources.ApplyResources(ConstantLine2, "ConstantLine2")
        ConstantLine2.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Solid
        ConstantLine2.LineStyle.Thickness = 2
        ConstantLine2.Name = "Moyenne"
        ConstantLine2.ShowInLegend = False
        ConstantLine2.Title.DXFont = CType(resources.GetObject("resource.DXFont1"), DevExpress.Drawing.DXFont)
        ConstantLine2.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        ConstantLine2.Title.Text = resources.GetString("resource.Text1")
        ConstantLine2.Title.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        ConstantLine2.Visible = False
        XyDiagram2.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine2})
        XyDiagram2.AxisY.Title.Text = resources.GetString("resource.Text2")
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.WholeRange.AlwaysShowZeroLevel = False
        Me.Chart2.Diagram = XyDiagram2
        resources.ApplyResources(Me.Chart2, "Chart2")
        Me.Chart2.Legend.EquallySpacedItems = False
        Me.Chart2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.Chart2.Name = "Chart2"
        Series2.ArgumentDataMember = "periode"
        SideBySideBarSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel3.TextPattern = "{V:N0}"
        Series2.Label = SideBySideBarSeriesLabel3
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series2.LegendTextPattern = "  Nouveaux Sous-traitant"
        resources.ApplyResources(Series2, "Series2")
        Series2.ShowInLegend = False
        Series2.ValueDataMembersSerializable = "BudgRestant"
        SideBySideBarSeriesView2.Color = System.Drawing.Color.DodgerBlue
        SideBySideBarSeriesView2.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient
        RegressionLine2.Color = System.Drawing.Color.Fuchsia
        resources.ApplyResources(RegressionLine2, "RegressionLine2")
        SideBySideBarSeriesView2.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {RegressionLine2})
        Series2.View = SideBySideBarSeriesView2
        Me.Chart2.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        SideBySideBarSeriesLabel4.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.Chart2.SeriesTemplate.Label = SideBySideBarSeriesLabel4
        resources.ApplyResources(ChartTitle2, "ChartTitle2")
        ChartTitle2.TextColor = System.Drawing.Color.Black
        Me.Chart2.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'Grp3
        '
        Me.Grp3.Controls.Add(Me.Chart3)
        resources.ApplyResources(Me.Grp3, "Grp3")
        Me.Grp3.Name = "Grp3"
        Me.Grp3.TabStop = False
        '
        'Chart3
        '
        XyDiagram3.AxisX.VisibleInPanesSerializable = "-1"
        ConstantLine3.AxisValueSerializable = "1"
        ConstantLine3.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        resources.ApplyResources(ConstantLine3, "ConstantLine3")
        ConstantLine3.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Solid
        ConstantLine3.LineStyle.Thickness = 2
        ConstantLine3.Name = "Moyenne"
        ConstantLine3.ShowInLegend = False
        ConstantLine3.Title.DXFont = CType(resources.GetObject("resource.DXFont2"), DevExpress.Drawing.DXFont)
        ConstantLine3.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        ConstantLine3.Title.Text = resources.GetString("resource.Text3")
        ConstantLine3.Title.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        ConstantLine3.Visible = False
        XyDiagram3.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine3})
        XyDiagram3.AxisY.Title.Text = resources.GetString("resource.Text4")
        XyDiagram3.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram3.AxisY.WholeRange.AlwaysShowZeroLevel = False
        Me.Chart3.Diagram = XyDiagram3
        resources.ApplyResources(Me.Chart3, "Chart3")
        Me.Chart3.Legend.EquallySpacedItems = False
        Me.Chart3.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.Chart3.Name = "Chart3"
        Series3.ArgumentDataMember = "periode"
        SideBySideBarSeriesLabel5.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel5.TextPattern = "{V:N0}"
        Series3.Label = SideBySideBarSeriesLabel5
        Series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series3.LegendTextPattern = "  Nouveaux Sous-traitant"
        resources.ApplyResources(Series3, "Series3")
        Series3.ShowInLegend = False
        Series3.ValueDataMembersSerializable = "BudgRestant"
        SideBySideBarSeriesView3.Color = System.Drawing.Color.DodgerBlue
        SideBySideBarSeriesView3.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient
        RegressionLine3.Color = System.Drawing.Color.Fuchsia
        resources.ApplyResources(RegressionLine3, "RegressionLine3")
        SideBySideBarSeriesView3.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {RegressionLine3})
        Series3.View = SideBySideBarSeriesView3
        Me.Chart3.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3}
        SideBySideBarSeriesLabel6.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.Chart3.SeriesTemplate.Label = SideBySideBarSeriesLabel6
        resources.ApplyResources(ChartTitle3, "ChartTitle3")
        ChartTitle3.TextColor = System.Drawing.Color.Black
        Me.Chart3.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle3})
        '
        'frmStatMargeAnalyse
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Grp3)
        Me.Controls.Add(Me.Grp2)
        Me.Controls.Add(Me.Grp1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.BtValider)
        Me.Controls.Add(Me.BtnDate2)
        Me.Controls.Add(Me.txtDtFin)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.BtnDate1)
        Me.Controls.Add(Me.txtDtDebut)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "frmStatMargeAnalyse"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.Grp1.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RegressionLine1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grp2.ResumeLayout(False)
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RegressionLine2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grp3.ResumeLayout(False)
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RegressionLine3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtValider As System.Windows.Forms.Button
    Friend WithEvents BtnDate2 As System.Windows.Forms.Button
    Friend WithEvents txtDtFin As System.Windows.Forms.TextBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents BtnDate1 As System.Windows.Forms.Button
    Friend WithEvents txtDtDebut As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnExport As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Grp1 As System.Windows.Forms.GroupBox
    Friend WithEvents Grp2 As System.Windows.Forms.GroupBox
    Friend WithEvents Grp3 As System.Windows.Forms.GroupBox
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents nclinum As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents vclinom As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ncannum As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents CHAFF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents CA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NbAct As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MntMoyFact As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NbHeuresStruct As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MoyHeures As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents BudgRestant As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MargeNetteAnalytique As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Chart1 As DevExpress.XtraCharts.ChartControl
    Private WithEvents Chart2 As DevExpress.XtraCharts.ChartControl
    Private WithEvents npernum As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Chart3 As DevExpress.XtraCharts.ChartControl
End Class
