<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatFournitureTech
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatFournitureTech))
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim SideBySideBarSeriesLabel4 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.GCStatTot = New DevExpress.XtraGrid.GridControl()
        Me.GVStatTot = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColTotTech = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColTot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCDetail = New DevExpress.XtraGrid.GridControl()
        Me.GVDetail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColDetNDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetDACTDEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetVACTDES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetVSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetNELFFOU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCSem = New DevExpress.XtraGrid.GridControl()
        Me.GVSem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColSemDACTDEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColSemJour = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColSemMontant = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChartTot = New DevExpress.XtraCharts.ChartControl()
        Me.LblPeriode = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCStatTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStatTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCSem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
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
        'GCStatTot
        '
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
        Me.GVStatTot.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColTotTech, Me.GColTot, Me.GColNPERNUM})
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
        Me.GColTotTech.FieldName = "Tech"
        Me.GColTotTech.Name = "GColTotTech"
        Me.GColTotTech.OptionsColumn.AllowEdit = False
        Me.GColTotTech.OptionsColumn.ReadOnly = True
        '
        'GColTot
        '
        Me.GColTot.AppearanceHeader.Font = CType(resources.GetObject("GColTot.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColTot.AppearanceHeader.Options.UseFont = True
        Me.GColTot.AppearanceHeader.Options.UseTextOptions = True
        Me.GColTot.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColTot.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColTot, "GColTot")
        Me.GColTot.DisplayFormat.FormatString = "{0:c0}"
        Me.GColTot.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColTot.FieldName = "Montant"
        Me.GColTot.Name = "GColTot"
        Me.GColTot.OptionsColumn.AllowEdit = False
        Me.GColTot.OptionsColumn.ReadOnly = True
        Me.GColTot.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GColTot.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("GColTot.Summary1"), resources.GetString("GColTot.Summary2"))})
        '
        'GColNPERNUM
        '
        resources.ApplyResources(Me.GColNPERNUM, "GColNPERNUM")
        Me.GColNPERNUM.FieldName = "npernum"
        Me.GColNPERNUM.Name = "GColNPERNUM"
        '
        'GCDetail
        '
        resources.ApplyResources(Me.GCDetail, "GCDetail")
        Me.GCDetail.MainView = Me.GVDetail
        Me.GCDetail.Name = "GCDetail"
        Me.GCDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDetail})
        '
        'GVDetail
        '
        Me.GVDetail.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.ColumnFilterButton.BackColor2 = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButton.BackColor2"), System.Drawing.Color)
        Me.GVDetail.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVDetail.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVDetail.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVDetail.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVDetail.Appearance.ColumnFilterButtonActive.BackColor2 = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButtonActive.BackColor2"), System.Drawing.Color)
        Me.GVDetail.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVDetail.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVDetail.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVDetail.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVDetail.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.Empty.Options.UseBackColor = True
        Me.GVDetail.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.FilterCloseButton.BackColor2 = CType(resources.GetObject("GVDetail.Appearance.FilterCloseButton.BackColor2"), System.Drawing.Color)
        Me.GVDetail.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVDetail.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVDetail.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVDetail.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVDetail.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVDetail.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVDetail.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVDetail.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GVDetail.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVDetail.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVDetail.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVDetail.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GVDetail.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.FooterPanel.BackColor2 = CType(resources.GetObject("GVDetail.Appearance.FooterPanel.BackColor2"), System.Drawing.Color)
        Me.GVDetail.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVDetail.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVDetail.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVDetail.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVDetail.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVDetail.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVDetail.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVDetail.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVDetail.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVDetail.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVDetail.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVDetail.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVDetail.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVDetail.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVDetail.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVDetail.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVDetail.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVDetail.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVDetail.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVDetail.Appearance.GroupRow.Font = CType(resources.GetObject("GVDetail.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.GVDetail.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVDetail.Appearance.GroupRow.Options.UseFont = True
        Me.GVDetail.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.HeaderPanel.BackColor2 = CType(resources.GetObject("GVDetail.Appearance.HeaderPanel.BackColor2"), System.Drawing.Color)
        Me.GVDetail.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVDetail.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVDetail.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVDetail.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVDetail.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVDetail.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVDetail.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVDetail.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVDetail.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.OddRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.OddRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVDetail.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVDetail.Appearance.Preview.Options.UseBackColor = True
        Me.GVDetail.Appearance.Preview.Options.UseForeColor = True
        Me.GVDetail.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.Row.Options.UseBackColor = True
        Me.GVDetail.Appearance.Row.Options.UseForeColor = True
        Me.GVDetail.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVDetail.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GVDetail.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVDetail.Appearance.VertLine.Options.UseBackColor = True
        Me.GVDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColDetNDINNUM, Me.GColDetDACTDEX, Me.GColDetVACTDES, Me.GColDetVCLINOM, Me.GColDetVSITNOM, Me.GColDetVPERNOM, Me.GColDetNELFFOU})
        Me.GVDetail.GridControl = Me.GCDetail
        Me.GVDetail.Name = "GVDetail"
        Me.GVDetail.OptionsBehavior.Editable = False
        Me.GVDetail.OptionsBehavior.ReadOnly = True
        Me.GVDetail.OptionsView.EnableAppearanceEvenRow = True
        Me.GVDetail.OptionsView.EnableAppearanceOddRow = True
        Me.GVDetail.OptionsView.ShowFooter = True
        Me.GVDetail.OptionsView.ShowGroupPanel = False
        '
        'GColDetNDINNUM
        '
        Me.GColDetNDINNUM.AppearanceHeader.Font = CType(resources.GetObject("GColDetNDINNUM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDetNDINNUM.AppearanceHeader.Options.UseFont = True
        Me.GColDetNDINNUM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetNDINNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetNDINNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetNDINNUM, "GColDetNDINNUM")
        Me.GColDetNDINNUM.FieldName = "NDINNUM"
        Me.GColDetNDINNUM.Name = "GColDetNDINNUM"
        Me.GColDetNDINNUM.OptionsColumn.AllowEdit = False
        Me.GColDetNDINNUM.OptionsColumn.ReadOnly = True
        '
        'GColDetDACTDEX
        '
        Me.GColDetDACTDEX.AppearanceHeader.Font = CType(resources.GetObject("GColDetDACTDEX.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDetDACTDEX.AppearanceHeader.Options.UseFont = True
        Me.GColDetDACTDEX.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetDACTDEX.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetDACTDEX.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetDACTDEX, "GColDetDACTDEX")
        Me.GColDetDACTDEX.FieldName = "DACTDEX"
        Me.GColDetDACTDEX.Name = "GColDetDACTDEX"
        Me.GColDetDACTDEX.OptionsColumn.AllowEdit = False
        Me.GColDetDACTDEX.OptionsColumn.ReadOnly = True
        '
        'GColDetVACTDES
        '
        Me.GColDetVACTDES.AppearanceHeader.Font = CType(resources.GetObject("GColDetVACTDES.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDetVACTDES.AppearanceHeader.Options.UseFont = True
        Me.GColDetVACTDES.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetVACTDES.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetVACTDES.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetVACTDES, "GColDetVACTDES")
        Me.GColDetVACTDES.FieldName = "VACTDES"
        Me.GColDetVACTDES.Name = "GColDetVACTDES"
        Me.GColDetVACTDES.OptionsColumn.AllowEdit = False
        Me.GColDetVACTDES.OptionsColumn.ReadOnly = True
        '
        'GColDetVCLINOM
        '
        Me.GColDetVCLINOM.AppearanceHeader.Font = CType(resources.GetObject("GColDetVCLINOM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDetVCLINOM.AppearanceHeader.Options.UseFont = True
        Me.GColDetVCLINOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetVCLINOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetVCLINOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetVCLINOM, "GColDetVCLINOM")
        Me.GColDetVCLINOM.FieldName = "VCLINOM"
        Me.GColDetVCLINOM.Name = "GColDetVCLINOM"
        Me.GColDetVCLINOM.OptionsColumn.AllowEdit = False
        Me.GColDetVCLINOM.OptionsColumn.ReadOnly = True
        '
        'GColDetVSITNOM
        '
        Me.GColDetVSITNOM.AppearanceHeader.Font = CType(resources.GetObject("GColDetVSITNOM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDetVSITNOM.AppearanceHeader.Options.UseFont = True
        Me.GColDetVSITNOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetVSITNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetVSITNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetVSITNOM, "GColDetVSITNOM")
        Me.GColDetVSITNOM.FieldName = "VSITNOM"
        Me.GColDetVSITNOM.Name = "GColDetVSITNOM"
        Me.GColDetVSITNOM.OptionsColumn.AllowEdit = False
        Me.GColDetVSITNOM.OptionsColumn.ReadOnly = True
        '
        'GColDetVPERNOM
        '
        Me.GColDetVPERNOM.AppearanceHeader.Font = CType(resources.GetObject("GColDetVPERNOM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDetVPERNOM.AppearanceHeader.Options.UseFont = True
        Me.GColDetVPERNOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetVPERNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetVPERNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetVPERNOM, "GColDetVPERNOM")
        Me.GColDetVPERNOM.FieldName = "VPERNOM"
        Me.GColDetVPERNOM.Name = "GColDetVPERNOM"
        Me.GColDetVPERNOM.OptionsColumn.AllowEdit = False
        Me.GColDetVPERNOM.OptionsColumn.ReadOnly = True
        '
        'GColDetNELFFOU
        '
        Me.GColDetNELFFOU.AppearanceHeader.Font = CType(resources.GetObject("GColDetNELFFOU.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDetNELFFOU.AppearanceHeader.Options.UseFont = True
        Me.GColDetNELFFOU.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetNELFFOU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetNELFFOU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetNELFFOU, "GColDetNELFFOU")
        Me.GColDetNELFFOU.DisplayFormat.FormatString = "{0:c0}"
        Me.GColDetNELFFOU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColDetNELFFOU.FieldName = "NELFFOU"
        Me.GColDetNELFFOU.Name = "GColDetNELFFOU"
        Me.GColDetNELFFOU.OptionsColumn.AllowEdit = False
        Me.GColDetNELFFOU.OptionsColumn.ReadOnly = True
        Me.GColDetNELFFOU.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GColDetNELFFOU.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("GColDetNELFFOU.Summary1"), resources.GetString("GColDetNELFFOU.Summary2"))})
        '
        'GCSem
        '
        resources.ApplyResources(Me.GCSem, "GCSem")
        Me.GCSem.MainView = Me.GVSem
        Me.GCSem.Name = "GCSem"
        Me.GCSem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSem})
        '
        'GVSem
        '
        Me.GVSem.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVSem.Appearance.ColumnFilterButton.BackColor2 = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButton.BackColor2"), System.Drawing.Color)
        Me.GVSem.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVSem.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVSem.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSem.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSem.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSem.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVSem.Appearance.ColumnFilterButtonActive.BackColor2 = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButtonActive.BackColor2"), System.Drawing.Color)
        Me.GVSem.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVSem.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVSem.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSem.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSem.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSem.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GVSem.Appearance.Empty.Options.UseBackColor = True
        Me.GVSem.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVSem.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSem.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSem.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSem.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVSem.Appearance.FilterCloseButton.BackColor2 = CType(resources.GetObject("GVSem.Appearance.FilterCloseButton.BackColor2"), System.Drawing.Color)
        Me.GVSem.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVSem.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVSem.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVSem.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSem.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSem.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSem.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVSem.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GVSem.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSem.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSem.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GVSem.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSem.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVSem.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSem.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSem.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSem.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GVSem.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVSem.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSem.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSem.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVSem.Appearance.FooterPanel.BackColor2 = CType(resources.GetObject("GVSem.Appearance.FooterPanel.BackColor2"), System.Drawing.Color)
        Me.GVSem.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVSem.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSem.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVSem.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSem.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSem.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSem.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVSem.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVSem.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GVSem.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSem.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSem.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVSem.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVSem.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVSem.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVSem.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSem.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSem.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSem.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVSem.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVSem.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSem.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSem.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVSem.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVSem.Appearance.GroupRow.Font = CType(resources.GetObject("GVSem.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.GVSem.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVSem.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSem.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSem.Appearance.GroupRow.Options.UseFont = True
        Me.GVSem.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSem.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVSem.Appearance.HeaderPanel.BackColor2 = CType(resources.GetObject("GVSem.Appearance.HeaderPanel.BackColor2"), System.Drawing.Color)
        Me.GVSem.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVSem.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSem.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVSem.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSem.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSem.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSem.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVSem.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVSem.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSem.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSem.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVSem.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSem.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GVSem.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSem.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSem.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSem.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVSem.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVSem.Appearance.Preview.Options.UseBackColor = True
        Me.GVSem.Appearance.Preview.Options.UseForeColor = True
        Me.GVSem.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GVSem.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSem.Appearance.Row.Options.UseBackColor = True
        Me.GVSem.Appearance.Row.Options.UseForeColor = True
        Me.GVSem.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GVSem.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSem.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GVSem.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVSem.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSem.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSem.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVSem.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSem.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColSemDACTDEX, Me.GColSemJour, Me.GColSemMontant})
        Me.GVSem.GridControl = Me.GCSem
        Me.GVSem.Name = "GVSem"
        Me.GVSem.OptionsBehavior.Editable = False
        Me.GVSem.OptionsBehavior.ReadOnly = True
        Me.GVSem.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSem.OptionsView.EnableAppearanceOddRow = True
        Me.GVSem.OptionsView.ShowFooter = True
        Me.GVSem.OptionsView.ShowGroupPanel = False
        '
        'GColSemDACTDEX
        '
        Me.GColSemDACTDEX.AppearanceHeader.Font = CType(resources.GetObject("GColSemDACTDEX.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColSemDACTDEX.AppearanceHeader.Options.UseFont = True
        Me.GColSemDACTDEX.AppearanceHeader.Options.UseTextOptions = True
        Me.GColSemDACTDEX.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColSemDACTDEX.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColSemDACTDEX, "GColSemDACTDEX")
        Me.GColSemDACTDEX.FieldName = "DACTDEX"
        Me.GColSemDACTDEX.Name = "GColSemDACTDEX"
        Me.GColSemDACTDEX.OptionsColumn.AllowEdit = False
        Me.GColSemDACTDEX.OptionsColumn.ReadOnly = True
        '
        'GColSemJour
        '
        Me.GColSemJour.AppearanceHeader.Font = CType(resources.GetObject("GColSemJour.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColSemJour.AppearanceHeader.Options.UseFont = True
        Me.GColSemJour.AppearanceHeader.Options.UseTextOptions = True
        Me.GColSemJour.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColSemJour.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColSemJour, "GColSemJour")
        Me.GColSemJour.FieldName = "jour"
        Me.GColSemJour.Name = "GColSemJour"
        Me.GColSemJour.OptionsColumn.AllowEdit = False
        Me.GColSemJour.OptionsColumn.ReadOnly = True
        '
        'GColSemMontant
        '
        Me.GColSemMontant.AppearanceHeader.Font = CType(resources.GetObject("GColSemMontant.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColSemMontant.AppearanceHeader.Options.UseFont = True
        Me.GColSemMontant.AppearanceHeader.Options.UseTextOptions = True
        Me.GColSemMontant.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColSemMontant.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColSemMontant, "GColSemMontant")
        Me.GColSemMontant.DisplayFormat.FormatString = "{0:c0}"
        Me.GColSemMontant.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColSemMontant.FieldName = "montant"
        Me.GColSemMontant.Name = "GColSemMontant"
        Me.GColSemMontant.OptionsColumn.AllowEdit = False
        Me.GColSemMontant.OptionsColumn.ReadOnly = True
        Me.GColSemMontant.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GColSemMontant.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("GColSemMontant.Summary1"), resources.GetString("GColSemMontant.Summary2"))})
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
        Series2.ArgumentDataMember = "Tech"
        SideBySideBarSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series2.Label = SideBySideBarSeriesLabel3
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series2.ShowInLegend = False
        Series2.ValueDataMembersSerializable = "Montant"
        SideBySideBarSeriesView2.ColorEach = True
        Series2.View = SideBySideBarSeriesView2
        Me.ChartTot.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        SideBySideBarSeriesLabel4.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartTot.SeriesTemplate.Label = SideBySideBarSeriesLabel4
        '
        'LblPeriode
        '
        resources.ApplyResources(Me.LblPeriode, "LblPeriode")
        Me.LblPeriode.Name = "LblPeriode"
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
        'frmStatFournitureTech
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblPeriode)
        Me.Controls.Add(Me.ChartTot)
        Me.Controls.Add(Me.GCSem)
        Me.Controls.Add(Me.GCDetail)
        Me.Controls.Add(Me.GCStatTot)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmStatFournitureTech"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCStatTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStatTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCSem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartTot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents LblPeriode As System.Windows.Forms.Label
    Private WithEvents GCStatTot As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStatTot As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCDetail As DevExpress.XtraGrid.GridControl
    Private WithEvents GVDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCSem As DevExpress.XtraGrid.GridControl
    Private WithEvents GVSem As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColTotTech As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColTot As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetNDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetDACTDEX As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetVACTDES As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetVSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetNELFFOU As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColSemDACTDEX As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColSemJour As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColSemMontant As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ChartTot As DevExpress.XtraCharts.ChartControl
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
