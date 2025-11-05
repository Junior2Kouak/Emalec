<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatKMTech
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatKMTech))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim ConstantLine1 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim RegressionLine1 As DevExpress.XtraCharts.RegressionLine = New DevExpress.XtraCharts.RegressionLine()
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.PGCStatKms = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PGFMois = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGFKMHR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGFKMTOT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGFHRTOT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPerim = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMoy12 = New System.Windows.Forms.Label()
        Me.lblMoy = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpPer = New System.Windows.Forms.GroupBox()
        Me.ChartCtrl = New DevExpress.XtraCharts.ChartControl()
        Me.GrpActions.SuspendLayout()
        CType(Me.PGCStatKms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GrpPer.SuspendLayout()
        CType(Me.ChartCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RegressionLine1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
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
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'PGCStatKms
        '
        Me.PGCStatKms.Appearance.ColumnHeaderArea.Font = CType(resources.GetObject("PGCStatKms.Appearance.ColumnHeaderArea.Font"), System.Drawing.Font)
        Me.PGCStatKms.Appearance.ColumnHeaderArea.Options.UseFont = True
        Me.PGCStatKms.Appearance.ColumnHeaderArea.Options.UseTextOptions = True
        Me.PGCStatKms.Appearance.ColumnHeaderArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGCStatKms.Appearance.ColumnHeaderArea.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGCStatKms.Appearance.DataHeaderArea.Font = CType(resources.GetObject("PGCStatKms.Appearance.DataHeaderArea.Font"), System.Drawing.Font)
        Me.PGCStatKms.Appearance.DataHeaderArea.Options.UseFont = True
        Me.PGCStatKms.Appearance.DataHeaderArea.Options.UseTextOptions = True
        Me.PGCStatKms.Appearance.DataHeaderArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGCStatKms.Appearance.DataHeaderArea.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGCStatKms.Appearance.FieldHeader.Font = CType(resources.GetObject("PGCStatKms.Appearance.FieldHeader.Font"), System.Drawing.Font)
        Me.PGCStatKms.Appearance.FieldHeader.Options.UseFont = True
        Me.PGCStatKms.Appearance.HeaderArea.Font = CType(resources.GetObject("PGCStatKms.Appearance.HeaderArea.Font"), System.Drawing.Font)
        Me.PGCStatKms.Appearance.HeaderArea.Options.UseFont = True
        Me.PGCStatKms.Appearance.HeaderArea.Options.UseTextOptions = True
        Me.PGCStatKms.Appearance.HeaderArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGCStatKms.Appearance.HeaderArea.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGCStatKms.Appearance.RowHeaderArea.Font = CType(resources.GetObject("PGCStatKms.Appearance.RowHeaderArea.Font"), System.Drawing.Font)
        Me.PGCStatKms.Appearance.RowHeaderArea.Options.UseFont = True
        Me.PGCStatKms.Appearance.RowHeaderArea.Options.UseTextOptions = True
        Me.PGCStatKms.Appearance.RowHeaderArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGCStatKms.Appearance.RowHeaderArea.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGCStatKms.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PGFMois, Me.PGFKMHR, Me.PGFKMTOT, Me.PGFHRTOT})
        resources.ApplyResources(Me.PGCStatKms, "PGCStatKms")
        Me.PGCStatKms.Name = "PGCStatKms"
        Me.PGCStatKms.OptionsView.ShowColumnGrandTotalHeader = False
        Me.PGCStatKms.OptionsView.ShowColumnGrandTotals = False
        Me.PGCStatKms.OptionsView.ShowColumnHeaders = False
        Me.PGCStatKms.OptionsView.ShowColumnTotals = False
        Me.PGCStatKms.OptionsView.ShowDataHeaders = False
        Me.PGCStatKms.OptionsView.ShowFilterHeaders = False
        Me.PGCStatKms.OptionsView.ShowRowGrandTotalHeader = False
        Me.PGCStatKms.OptionsView.ShowRowGrandTotals = False
        Me.PGCStatKms.OptionsView.ShowRowTotals = False
        '
        'PGFMois
        '
        Me.PGFMois.Appearance.Cell.Font = CType(resources.GetObject("PGFMois.Appearance.Cell.Font"), System.Drawing.Font)
        Me.PGFMois.Appearance.Cell.Options.UseFont = True
        Me.PGFMois.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PGFMois.AreaIndex = 0
        resources.ApplyResources(Me.PGFMois, "PGFMois")
        Me.PGFMois.FieldName = "periode"
        Me.PGFMois.Name = "PGFMois"
        Me.PGFMois.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PGFMois.SortBySummaryInfo.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Var
        Me.PGFMois.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'PGFKMHR
        '
        Me.PGFKMHR.Appearance.Header.Font = CType(resources.GetObject("PGFKMHR.Appearance.Header.Font"), System.Drawing.Font)
        Me.PGFKMHR.Appearance.Header.Options.UseFont = True
        Me.PGFKMHR.Appearance.Header.Options.UseTextOptions = True
        Me.PGFKMHR.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGFKMHR.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGFKMHR.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PGFKMHR.AreaIndex = 2
        resources.ApplyResources(Me.PGFKMHR, "PGFKMHR")
        Me.PGFKMHR.CellFormat.FormatString = "d"
        Me.PGFKMHR.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PGFKMHR.FieldName = "KMHR"
        Me.PGFKMHR.Name = "PGFKMHR"
        '
        'PGFKMTOT
        '
        Me.PGFKMTOT.Appearance.Cell.Options.UseFont = True
        Me.PGFKMTOT.Appearance.Header.Font = CType(resources.GetObject("PGFKMTOT.Appearance.Header.Font"), System.Drawing.Font)
        Me.PGFKMTOT.Appearance.Header.Options.UseFont = True
        Me.PGFKMTOT.Appearance.Header.Options.UseTextOptions = True
        Me.PGFKMTOT.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGFKMTOT.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGFKMTOT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PGFKMTOT.AreaIndex = 0
        resources.ApplyResources(Me.PGFKMTOT, "PGFKMTOT")
        Me.PGFKMTOT.CellFormat.FormatString = "### ### ### ###"
        Me.PGFKMTOT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PGFKMTOT.FieldName = "KMTOT"
        Me.PGFKMTOT.Name = "PGFKMTOT"
        '
        'PGFHRTOT
        '
        Me.PGFHRTOT.Appearance.Header.Font = CType(resources.GetObject("PGFHRTOT.Appearance.Header.Font"), System.Drawing.Font)
        Me.PGFHRTOT.Appearance.Header.Options.UseFont = True
        Me.PGFHRTOT.Appearance.Header.Options.UseTextOptions = True
        Me.PGFHRTOT.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGFHRTOT.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGFHRTOT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PGFHRTOT.AreaIndex = 1
        resources.ApplyResources(Me.PGFHRTOT, "PGFHRTOT")
        Me.PGFHRTOT.CellFormat.FormatString = "### ### ### ###"
        Me.PGFHRTOT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PGFHRTOT.FieldName = "HRTOT"
        Me.PGFHRTOT.Name = "PGFHRTOT"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lblPerim)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lblMoy12)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
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
        'lblMoy
        '
        Me.lblMoy.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblMoy, "lblMoy")
        Me.lblMoy.ForeColor = System.Drawing.Color.Black
        Me.lblMoy.Name = "lblMoy"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'GrpPer
        '
        Me.GrpPer.Controls.Add(Me.ChartCtrl)
        resources.ApplyResources(Me.GrpPer, "GrpPer")
        Me.GrpPer.Name = "GrpPer"
        Me.GrpPer.TabStop = False
        '
        'ChartCtrl
        '
        XyDiagram1.AxisX.Label.Angle = CType(resources.GetObject("resource.Angle"), Integer)
        XyDiagram1.AxisX.Reverse = True
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
        XyDiagram1.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine1})
        XyDiagram1.AxisY.Title.Text = resources.GetString("resource.Text")
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartCtrl.Diagram = XyDiagram1
        resources.ApplyResources(Me.ChartCtrl, "ChartCtrl")
        Me.ChartCtrl.Legend.EquallySpacedItems = False
        Me.ChartCtrl.Legend.Name = "Default Legend"
        Me.ChartCtrl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartCtrl.Name = "ChartCtrl"
        Series1.ArgumentDataMember = "MOISANNEE"
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel1.TextPattern = "{V:N0}"
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        resources.ApplyResources(Series1, "Series1")
        Series1.ShowInLegend = False
        Series1.ValueDataMembersSerializable = "KMHR"
        SideBySideBarSeriesView1.Color = System.Drawing.Color.DodgerBlue
        RegressionLine1.Color = System.Drawing.Color.Fuchsia
        resources.ApplyResources(RegressionLine1, "RegressionLine1")
        SideBySideBarSeriesView1.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {RegressionLine1})
        Series1.View = SideBySideBarSeriesView1
        Me.ChartCtrl.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        SideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartCtrl.SeriesTemplate.Label = SideBySideBarSeriesLabel2
        '
        'frmStatKMTech
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpPer)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PGCStatKms)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmStatKMTech"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.PGCStatKms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GrpPer.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RegressionLine1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
  Friend WithEvents LblTitre As System.Windows.Forms.Label
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPerim As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMoy12 As System.Windows.Forms.Label
    Friend WithEvents lblMoy As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GrpPer As System.Windows.Forms.GroupBox
    Private WithEvents PGCStatKms As DevExpress.XtraPivotGrid.PivotGridControl
    Private WithEvents PGFMois As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PGFKMHR As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PGFKMTOT As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PGFHRTOT As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents ChartCtrl As DevExpress.XtraCharts.ChartControl
End Class
