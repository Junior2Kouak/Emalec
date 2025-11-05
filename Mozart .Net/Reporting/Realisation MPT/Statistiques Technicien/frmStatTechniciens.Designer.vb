<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatTechniciens
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatTechniciens))
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim SideBySideBarSeriesLabel4 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.GCStatTot = New DevExpress.XtraGrid.GridControl()
        Me.GVStatTot = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColTotTech = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColValeur = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.ChartTot = New DevExpress.XtraCharts.ChartControl()
        Me.LblPeriode = New System.Windows.Forms.Label()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.BtnExportXLS = New System.Windows.Forms.Button()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        CType(Me.GCStatTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStatTot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        CType(Me.ChartTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCStatTot
        '
        Me.GCStatTot.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[True]
        resources.ApplyResources(Me.GCStatTot, "GCStatTot")
        Me.GCStatTot.MainView = Me.GVStatTot
        Me.GCStatTot.Name = "GCStatTot"
        Me.GCStatTot.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStatTot})
        '
        'GVStatTot
        '
        Me.GVStatTot.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVStatTot.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVStatTot.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVStatTot.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVStatTot.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVStatTot.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVStatTot.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVStatTot.Appearance.Empty.Options.UseBackColor = True
        Me.GVStatTot.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVStatTot.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVStatTot.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVStatTot.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVStatTot.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVStatTot.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVStatTot.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVStatTot.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVStatTot.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVStatTot.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVStatTot.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVStatTot.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVStatTot.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVStatTot.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVStatTot.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVStatTot.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVStatTot.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVStatTot.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GVStatTot.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVStatTot.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVStatTot.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVStatTot.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVStatTot.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVStatTot.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVStatTot.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVStatTot.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVStatTot.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVStatTot.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVStatTot.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVStatTot.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVStatTot.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVStatTot.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVStatTot.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVStatTot.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVStatTot.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVStatTot.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVStatTot.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVStatTot.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVStatTot.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVStatTot.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVStatTot.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVStatTot.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVStatTot.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVStatTot.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVStatTot.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVStatTot.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVStatTot.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVStatTot.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVStatTot.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVStatTot.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVStatTot.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVStatTot.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.OddRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.OddRow.Options.UseForeColor = True
        Me.GVStatTot.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVStatTot.Appearance.Preview.Font = CType(resources.GetObject("GVStatTot.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVStatTot.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVStatTot.Appearance.Preview.Options.UseBackColor = True
        Me.GVStatTot.Appearance.Preview.Options.UseFont = True
        Me.GVStatTot.Appearance.Preview.Options.UseForeColor = True
        Me.GVStatTot.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVStatTot.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.Row.Options.UseBackColor = True
        Me.GVStatTot.Appearance.Row.Options.UseForeColor = True
        Me.GVStatTot.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVStatTot.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVStatTot.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVStatTot.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVStatTot.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVStatTot.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVStatTot.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVStatTot.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVStatTot.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVStatTot.Appearance.VertLine.Options.UseBackColor = True
        Me.GVStatTot.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVStatTot.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColTotTech, Me.GColValeur})
        Me.GVStatTot.GridControl = Me.GCStatTot
        Me.GVStatTot.Name = "GVStatTot"
        Me.GVStatTot.OptionsBehavior.Editable = False
        Me.GVStatTot.OptionsBehavior.ReadOnly = True
        Me.GVStatTot.OptionsView.EnableAppearanceEvenRow = True
        Me.GVStatTot.OptionsView.EnableAppearanceOddRow = True
        Me.GVStatTot.OptionsView.ShowFooter = True
        Me.GVStatTot.OptionsView.ShowGroupPanel = False
        '
        'GColTotTech
        '
        Me.GColTotTech.AppearanceHeader.Font = CType(resources.GetObject("GColTotTech.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColTotTech.AppearanceHeader.Options.UseFont = True
        Me.GColTotTech.AppearanceHeader.Options.UseTextOptions = True
        Me.GColTotTech.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColTotTech.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColTotTech, "GColTotTech")
        Me.GColTotTech.FieldName = "vpernom"
        Me.GColTotTech.Name = "GColTotTech"
        Me.GColTotTech.OptionsColumn.AllowEdit = False
        Me.GColTotTech.OptionsColumn.ReadOnly = True
        '
        'GColValeur
        '
        Me.GColValeur.AppearanceHeader.Font = CType(resources.GetObject("GColValeur.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColValeur.AppearanceHeader.Options.UseFont = True
        Me.GColValeur.AppearanceHeader.Options.UseTextOptions = True
        Me.GColValeur.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColValeur.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColValeur, "GColValeur")
        Me.GColValeur.DisplayFormat.FormatString = "{0:c0}"
        Me.GColValeur.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GColValeur.FieldName = "valeur"
        Me.GColValeur.Name = "GColValeur"
        Me.GColValeur.OptionsColumn.AllowEdit = False
        Me.GColValeur.OptionsColumn.ReadOnly = True
        Me.GColValeur.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GColValeur.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("GColValeur.Summary1"), resources.GetString("GColValeur.Summary2"))})
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnExportXLS)
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
        'ChartTot
        '
        XyDiagram2.AxisX.Label.Angle = CType(resources.GetObject("resource.Angle"), Integer)
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartTot.Diagram = XyDiagram2
        Me.ChartTot.Legend.Name = "Default Legend"
        resources.ApplyResources(Me.ChartTot, "ChartTot")
        Me.ChartTot.Name = "ChartTot"
        Series2.ArgumentDataMember = "vpernom"
        SideBySideBarSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series2.Label = SideBySideBarSeriesLabel3
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        resources.ApplyResources(Series2, "Series2")
        Series2.ShowInLegend = False
        Series2.ValueDataMembersSerializable = "valeur"
        SideBySideBarSeriesView2.ColorEach = True
        Series2.View = SideBySideBarSeriesView2
        Me.ChartTot.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        SideBySideBarSeriesLabel4.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartTot.SeriesTemplate.Label = SideBySideBarSeriesLabel4
		ChartTitle2.TextColor = System.Drawing.Color.Black
        Me.ChartTot.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'LblPeriode
        '
        resources.ApplyResources(Me.LblPeriode, "LblPeriode")
        Me.LblPeriode.Name = "LblPeriode"
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'BtnExportXLS
        '
        resources.ApplyResources(Me.BtnExportXLS, "BtnExportXLS")
        Me.BtnExportXLS.Name = "BtnExportXLS"
        Me.BtnExportXLS.Tag = ""
        Me.BtnExportXLS.UseVisualStyleBackColor = True
        '
        'frmStatTechniciens
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblPeriode)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.ChartTot)
        Me.Controls.Add(Me.GCStatTot)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmStatTechniciens"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCStatTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStatTot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartTot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents LblPeriode As System.Windows.Forms.Label
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Private WithEvents GCStatTot As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStatTot As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColTotTech As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColValeur As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ChartTot As DevExpress.XtraCharts.ChartControl
    Friend WithEvents BtnExportXLS As Button
    Friend WithEvents SFD As SaveFileDialog
End Class
