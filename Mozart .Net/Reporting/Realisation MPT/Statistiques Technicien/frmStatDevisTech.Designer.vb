<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatDevisTech
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatDevisTech))
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
        Me.ChartTot = New DevExpress.XtraCharts.ChartControl()
        Me.LblPeriode = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCStatTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStatTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDetail, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GCStatTot
        '
        resources.ApplyResources(Me.GCStatTot, "GCStatTot")
        '
        '
        '
        Me.GCStatTot.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCStatTot.EmbeddedNavigator.AccessibleDescription")
        Me.GCStatTot.EmbeddedNavigator.AccessibleName = resources.GetString("GCStatTot.EmbeddedNavigator.AccessibleName")
        Me.GCStatTot.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCStatTot.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCStatTot.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCStatTot.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCStatTot.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCStatTot.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCStatTot.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCStatTot.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCStatTot.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCStatTot.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCStatTot.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCStatTot.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCStatTot.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCStatTot.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCStatTot.EmbeddedNavigator.ToolTip = resources.GetString("GCStatTot.EmbeddedNavigator.ToolTip")
        Me.GCStatTot.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCStatTot.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCStatTot.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCStatTot.EmbeddedNavigator.ToolTipTitle")
        Me.GCStatTot.MainView = Me.GVStatTot
        Me.GCStatTot.Name = "GCStatTot"
        Me.GCStatTot.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStatTot})
        '
        'GVStatTot
        '
        Me.GVStatTot.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVStatTot.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVStatTot.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVStatTot.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVStatTot.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVStatTot.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVStatTot.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVStatTot.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVStatTot.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVStatTot.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVStatTot.Appearance.Empty.BackColor = CType(resources.GetObject("GVStatTot.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVStatTot.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVStatTot.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.Empty.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.Empty.Image = CType(resources.GetObject("GVStatTot.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.Empty.Options.UseBackColor = True
        Me.GVStatTot.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVStatTot.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVStatTot.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVStatTot.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.EvenRow.Image = CType(resources.GetObject("GVStatTot.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVStatTot.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVStatTot.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVStatTot.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVStatTot.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVStatTot.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVStatTot.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVStatTot.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVStatTot.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVStatTot.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVStatTot.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVStatTot.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.FilterPanel.Image = CType(resources.GetObject("GVStatTot.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVStatTot.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVStatTot.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVStatTot.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.FixedLine.Image = CType(resources.GetObject("GVStatTot.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVStatTot.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVStatTot.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVStatTot.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.FocusedCell.Image = CType(resources.GetObject("GVStatTot.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVStatTot.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVStatTot.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVStatTot.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVStatTot.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.FocusedRow.Image = CType(resources.GetObject("GVStatTot.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVStatTot.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVStatTot.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVStatTot.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVStatTot.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.FooterPanel.Image = CType(resources.GetObject("GVStatTot.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVStatTot.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVStatTot.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVStatTot.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVStatTot.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.GroupButton.Image = CType(resources.GetObject("GVStatTot.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVStatTot.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVStatTot.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVStatTot.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVStatTot.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.GroupFooter.Image = CType(resources.GetObject("GVStatTot.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVStatTot.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVStatTot.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVStatTot.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVStatTot.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVStatTot.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVStatTot.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.GroupPanel.Image = CType(resources.GetObject("GVStatTot.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVStatTot.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVStatTot.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVStatTot.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVStatTot.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVStatTot.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.GroupRow.Image = CType(resources.GetObject("GVStatTot.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVStatTot.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVStatTot.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVStatTot.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVStatTot.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVStatTot.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVStatTot.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVStatTot.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVStatTot.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVStatTot.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVStatTot.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVStatTot.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVStatTot.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.HorzLine.BorderColor = CType(resources.GetObject("GVStatTot.Appearance.HorzLine.BorderColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.HorzLine.Image = CType(resources.GetObject("GVStatTot.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVStatTot.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.OddRow.BackColor = CType(resources.GetObject("GVStatTot.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVStatTot.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVStatTot.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.OddRow.Image = CType(resources.GetObject("GVStatTot.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.OddRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.OddRow.Options.UseForeColor = True
        Me.GVStatTot.Appearance.Preview.BackColor = CType(resources.GetObject("GVStatTot.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.Preview.Font = CType(resources.GetObject("GVStatTot.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVStatTot.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.Preview.ForeColor = CType(resources.GetObject("GVStatTot.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.Preview.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.Preview.Image = CType(resources.GetObject("GVStatTot.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.Preview.Options.UseBackColor = True
        Me.GVStatTot.Appearance.Preview.Options.UseFont = True
        Me.GVStatTot.Appearance.Preview.Options.UseForeColor = True
        Me.GVStatTot.Appearance.Row.BackColor = CType(resources.GetObject("GVStatTot.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.Row.ForeColor = CType(resources.GetObject("GVStatTot.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.Row.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.Row.Image = CType(resources.GetObject("GVStatTot.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.Row.Options.UseBackColor = True
        Me.GVStatTot.Appearance.Row.Options.UseForeColor = True
        Me.GVStatTot.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVStatTot.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVStatTot.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVStatTot.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.RowSeparator.Image = CType(resources.GetObject("GVStatTot.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVStatTot.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVStatTot.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVStatTot.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.SelectedRow.Image = CType(resources.GetObject("GVStatTot.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVStatTot.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVStatTot.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.TopNewRow.Image = CType(resources.GetObject("GVStatTot.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.VertLine.BackColor = CType(resources.GetObject("GVStatTot.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.VertLine.BorderColor = CType(resources.GetObject("GVStatTot.Appearance.VertLine.BorderColor"), System.Drawing.Color)
        Me.GVStatTot.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVStatTot.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVStatTot.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVStatTot.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStatTot.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVStatTot.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStatTot.Appearance.VertLine.Image = CType(resources.GetObject("GVStatTot.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVStatTot.Appearance.VertLine.Options.UseBackColor = True
        Me.GVStatTot.Appearance.VertLine.Options.UseBorderColor = True
        resources.ApplyResources(Me.GVStatTot, "GVStatTot")
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
        Me.GColTotTech.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColTotTech.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColTotTech.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColTotTech.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColTotTech.AppearanceHeader.GradientMode = CType(resources.GetObject("GColTotTech.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColTotTech.AppearanceHeader.Image = CType(resources.GetObject("GColTotTech.AppearanceHeader.Image"), System.Drawing.Image)
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
        Me.GColTot.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColTot.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColTot.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColTot.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColTot.AppearanceHeader.GradientMode = CType(resources.GetObject("GColTot.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColTot.AppearanceHeader.Image = CType(resources.GetObject("GColTot.AppearanceHeader.Image"), System.Drawing.Image)
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
        '
        '
        '
        Me.GCDetail.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCDetail.EmbeddedNavigator.AccessibleDescription")
        Me.GCDetail.EmbeddedNavigator.AccessibleName = resources.GetString("GCDetail.EmbeddedNavigator.AccessibleName")
        Me.GCDetail.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCDetail.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCDetail.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCDetail.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCDetail.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCDetail.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCDetail.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCDetail.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCDetail.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCDetail.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCDetail.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCDetail.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCDetail.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCDetail.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCDetail.EmbeddedNavigator.ToolTip = resources.GetString("GCDetail.EmbeddedNavigator.ToolTip")
        Me.GCDetail.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCDetail.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCDetail.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCDetail.EmbeddedNavigator.ToolTipTitle")
        Me.GCDetail.MainView = Me.GVDetail
        Me.GCDetail.Name = "GCDetail"
        Me.GCDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDetail})
        '
        'GVDetail
        '
        Me.GVDetail.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.ColumnFilterButton.BackColor2 = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButton.BackColor2"), System.Drawing.Color)
        Me.GVDetail.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVDetail.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVDetail.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVDetail.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.ColumnFilterButtonActive.BackColor2 = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButtonActive.BackColor2"), System.Drawing.Color)
        Me.GVDetail.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVDetail.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVDetail.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVDetail.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVDetail.Appearance.Empty.BackColor = CType(resources.GetObject("GVDetail.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.Empty.GradientMode = CType(resources.GetObject("GVDetail.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.Empty.Image = CType(resources.GetObject("GVDetail.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.Empty.Options.UseBackColor = True
        Me.GVDetail.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVDetail.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVDetail.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVDetail.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.EvenRow.Image = CType(resources.GetObject("GVDetail.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVDetail.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.FilterCloseButton.BackColor2 = CType(resources.GetObject("GVDetail.Appearance.FilterCloseButton.BackColor2"), System.Drawing.Color)
        Me.GVDetail.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVDetail.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVDetail.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVDetail.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVDetail.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVDetail.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVDetail.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVDetail.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVDetail.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVDetail.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVDetail.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.FilterPanel.Image = CType(resources.GetObject("GVDetail.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVDetail.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVDetail.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVDetail.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVDetail.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.FixedLine.Image = CType(resources.GetObject("GVDetail.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVDetail.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVDetail.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVDetail.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVDetail.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.FocusedCell.Image = CType(resources.GetObject("GVDetail.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVDetail.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVDetail.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVDetail.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVDetail.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVDetail.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.FocusedRow.Image = CType(resources.GetObject("GVDetail.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVDetail.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.FooterPanel.BackColor2 = CType(resources.GetObject("GVDetail.Appearance.FooterPanel.BackColor2"), System.Drawing.Color)
        Me.GVDetail.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVDetail.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVDetail.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVDetail.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.FooterPanel.Image = CType(resources.GetObject("GVDetail.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVDetail.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVDetail.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVDetail.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVDetail.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVDetail.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.GroupButton.ForeColor = CType(resources.GetObject("GVDetail.Appearance.GroupButton.ForeColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVDetail.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.GroupButton.Image = CType(resources.GetObject("GVDetail.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVDetail.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVDetail.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVDetail.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVDetail.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVDetail.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVDetail.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVDetail.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.GroupFooter.Image = CType(resources.GetObject("GVDetail.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVDetail.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVDetail.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVDetail.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVDetail.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVDetail.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVDetail.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.GroupPanel.Image = CType(resources.GetObject("GVDetail.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVDetail.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVDetail.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVDetail.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVDetail.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.GroupRow.Font = CType(resources.GetObject("GVDetail.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.GVDetail.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVDetail.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVDetail.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.GroupRow.Image = CType(resources.GetObject("GVDetail.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVDetail.Appearance.GroupRow.Options.UseFont = True
        Me.GVDetail.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVDetail.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.HeaderPanel.BackColor2 = CType(resources.GetObject("GVDetail.Appearance.HeaderPanel.BackColor2"), System.Drawing.Color)
        Me.GVDetail.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVDetail.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVDetail.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVDetail.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVDetail.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVDetail.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVDetail.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVDetail.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVDetail.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVDetail.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVDetail.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVDetail.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVDetail.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVDetail.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.HorzLine.Image = CType(resources.GetObject("GVDetail.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVDetail.Appearance.OddRow.BackColor = CType(resources.GetObject("GVDetail.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVDetail.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVDetail.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.OddRow.Image = CType(resources.GetObject("GVDetail.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.OddRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.OddRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.Preview.BackColor = CType(resources.GetObject("GVDetail.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.Preview.ForeColor = CType(resources.GetObject("GVDetail.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.Preview.GradientMode = CType(resources.GetObject("GVDetail.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.Preview.Image = CType(resources.GetObject("GVDetail.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.Preview.Options.UseBackColor = True
        Me.GVDetail.Appearance.Preview.Options.UseForeColor = True
        Me.GVDetail.Appearance.Row.BackColor = CType(resources.GetObject("GVDetail.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.Row.ForeColor = CType(resources.GetObject("GVDetail.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.Row.GradientMode = CType(resources.GetObject("GVDetail.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.Row.Image = CType(resources.GetObject("GVDetail.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.Row.Options.UseBackColor = True
        Me.GVDetail.Appearance.Row.Options.UseForeColor = True
        Me.GVDetail.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVDetail.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVDetail.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.RowSeparator.Image = CType(resources.GetObject("GVDetail.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVDetail.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVDetail.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVDetail.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVDetail.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.SelectedRow.Image = CType(resources.GetObject("GVDetail.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.VertLine.BackColor = CType(resources.GetObject("GVDetail.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVDetail.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVDetail.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVDetail.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVDetail.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetail.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVDetail.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetail.Appearance.VertLine.Image = CType(resources.GetObject("GVDetail.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVDetail.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVDetail, "GVDetail")
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
        Me.GColDetNDINNUM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColDetNDINNUM.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColDetNDINNUM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColDetNDINNUM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDetNDINNUM.AppearanceHeader.GradientMode = CType(resources.GetObject("GColDetNDINNUM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDetNDINNUM.AppearanceHeader.Image = CType(resources.GetObject("GColDetNDINNUM.AppearanceHeader.Image"), System.Drawing.Image)
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
        Me.GColDetDACTDEX.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColDetDACTDEX.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColDetDACTDEX.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColDetDACTDEX.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDetDACTDEX.AppearanceHeader.GradientMode = CType(resources.GetObject("GColDetDACTDEX.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDetDACTDEX.AppearanceHeader.Image = CType(resources.GetObject("GColDetDACTDEX.AppearanceHeader.Image"), System.Drawing.Image)
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
        Me.GColDetVACTDES.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColDetVACTDES.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColDetVACTDES.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColDetVACTDES.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDetVACTDES.AppearanceHeader.GradientMode = CType(resources.GetObject("GColDetVACTDES.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDetVACTDES.AppearanceHeader.Image = CType(resources.GetObject("GColDetVACTDES.AppearanceHeader.Image"), System.Drawing.Image)
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
        Me.GColDetVCLINOM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColDetVCLINOM.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColDetVCLINOM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColDetVCLINOM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDetVCLINOM.AppearanceHeader.GradientMode = CType(resources.GetObject("GColDetVCLINOM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDetVCLINOM.AppearanceHeader.Image = CType(resources.GetObject("GColDetVCLINOM.AppearanceHeader.Image"), System.Drawing.Image)
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
        Me.GColDetVSITNOM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColDetVSITNOM.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColDetVSITNOM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColDetVSITNOM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDetVSITNOM.AppearanceHeader.GradientMode = CType(resources.GetObject("GColDetVSITNOM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDetVSITNOM.AppearanceHeader.Image = CType(resources.GetObject("GColDetVSITNOM.AppearanceHeader.Image"), System.Drawing.Image)
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
        Me.GColDetVPERNOM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColDetVPERNOM.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColDetVPERNOM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColDetVPERNOM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDetVPERNOM.AppearanceHeader.GradientMode = CType(resources.GetObject("GColDetVPERNOM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDetVPERNOM.AppearanceHeader.Image = CType(resources.GetObject("GColDetVPERNOM.AppearanceHeader.Image"), System.Drawing.Image)
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
        Me.GColDetNELFFOU.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColDetNELFFOU.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColDetNELFFOU.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColDetNELFFOU.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDetNELFFOU.AppearanceHeader.GradientMode = CType(resources.GetObject("GColDetNELFFOU.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDetNELFFOU.AppearanceHeader.Image = CType(resources.GetObject("GColDetNELFFOU.AppearanceHeader.Image"), System.Drawing.Image)
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
        'ChartTot
        '
        resources.ApplyResources(Me.ChartTot, "ChartTot")
        XyDiagram2.AxisX.Label.Angle = CType(resources.GetObject("resource.Angle"), Integer)
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartTot.Diagram = XyDiagram2
        Me.ChartTot.Name = "ChartTot"
        Series2.ArgumentDataMember = "Tech"
        SideBySideBarSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series2.Label = SideBySideBarSeriesLabel3
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        resources.ApplyResources(Series2, "Series2")
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
        'frmStatDevisTech
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblPeriode)
        Me.Controls.Add(Me.ChartTot)
        Me.Controls.Add(Me.GCDetail)
        Me.Controls.Add(Me.GCStatTot)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmStatDevisTech"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCStatTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStatTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDetail, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents ChartTot As DevExpress.XtraCharts.ChartControl
End Class
