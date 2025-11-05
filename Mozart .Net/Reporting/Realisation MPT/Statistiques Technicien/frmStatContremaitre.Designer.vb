<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatContremaitre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatContremaitre))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.GCStatTot = New DevExpress.XtraGrid.GridControl()
        Me.GVStatTot = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColContremaitre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNbTech = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColValeur = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColClass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.ChartTot = New DevExpress.XtraCharts.ChartControl()
        Me.LblPeriode = New System.Windows.Forms.Label()
        Me.LblTitre = New System.Windows.Forms.Label()
        CType(Me.GCStatTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStatTot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        CType(Me.ChartTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GVStatTot.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColContremaitre, Me.GColNbTech, Me.GColValeur, Me.GColClass, Me.GColP})
        Me.GVStatTot.GridControl = Me.GCStatTot
        Me.GVStatTot.Name = "GVStatTot"
        Me.GVStatTot.OptionsBehavior.Editable = False
        Me.GVStatTot.OptionsBehavior.ReadOnly = True
        Me.GVStatTot.OptionsView.EnableAppearanceEvenRow = True
        Me.GVStatTot.OptionsView.EnableAppearanceOddRow = True
        Me.GVStatTot.OptionsView.ShowFooter = True
        Me.GVStatTot.OptionsView.ShowGroupPanel = False
        '
        'GColContremaitre
        '
        Me.GColContremaitre.AppearanceHeader.Font = CType(resources.GetObject("GColContremaitre.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColContremaitre.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColContremaitre.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColContremaitre.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColContremaitre.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColContremaitre.AppearanceHeader.GradientMode = CType(resources.GetObject("GColContremaitre.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColContremaitre.AppearanceHeader.Image = CType(resources.GetObject("GColContremaitre.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColContremaitre.AppearanceHeader.Options.UseFont = True
        Me.GColContremaitre.AppearanceHeader.Options.UseTextOptions = True
        Me.GColContremaitre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColContremaitre.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColContremaitre, "GColContremaitre")
        Me.GColContremaitre.FieldName = "VPERNOM"
        Me.GColContremaitre.Name = "GColContremaitre"
        Me.GColContremaitre.OptionsColumn.AllowEdit = False
        Me.GColContremaitre.OptionsColumn.ReadOnly = True
        '
        'GColNbTech
        '
        Me.GColNbTech.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColNbTech.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColNbTech.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColNbTech.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColNbTech.AppearanceCell.GradientMode = CType(resources.GetObject("GColNbTech.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColNbTech.AppearanceCell.Image = CType(resources.GetObject("GColNbTech.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColNbTech.AppearanceCell.Options.UseTextOptions = True
        Me.GColNbTech.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNbTech.AppearanceHeader.Font = CType(resources.GetObject("GColNbTech.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColNbTech.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColNbTech.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColNbTech.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColNbTech.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColNbTech.AppearanceHeader.GradientMode = CType(resources.GetObject("GColNbTech.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColNbTech.AppearanceHeader.Image = CType(resources.GetObject("GColNbTech.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColNbTech.AppearanceHeader.Options.UseFont = True
        Me.GColNbTech.AppearanceHeader.Options.UseTextOptions = True
        Me.GColNbTech.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GColNbTech, "GColNbTech")
        Me.GColNbTech.FieldName = "Nbr"
        Me.GColNbTech.Name = "GColNbTech"
        '
        'GColValeur
        '
        Me.GColValeur.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColValeur.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColValeur.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColValeur.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColValeur.AppearanceCell.GradientMode = CType(resources.GetObject("GColValeur.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColValeur.AppearanceCell.Image = CType(resources.GetObject("GColValeur.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColValeur.AppearanceCell.Options.UseTextOptions = True
        Me.GColValeur.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColValeur.AppearanceHeader.Font = CType(resources.GetObject("GColValeur.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColValeur.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColValeur.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColValeur.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColValeur.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColValeur.AppearanceHeader.GradientMode = CType(resources.GetObject("GColValeur.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColValeur.AppearanceHeader.Image = CType(resources.GetObject("GColValeur.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColValeur.AppearanceHeader.Options.UseFont = True
        Me.GColValeur.AppearanceHeader.Options.UseTextOptions = True
        Me.GColValeur.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColValeur.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColValeur, "GColValeur")
        Me.GColValeur.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColValeur.FieldName = "valeur"
        Me.GColValeur.Name = "GColValeur"
        Me.GColValeur.OptionsColumn.AllowEdit = False
        Me.GColValeur.OptionsColumn.ReadOnly = True
        '
        'GColClass
        '
        Me.GColClass.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColClass.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColClass.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColClass.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColClass.AppearanceCell.GradientMode = CType(resources.GetObject("GColClass.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColClass.AppearanceCell.Image = CType(resources.GetObject("GColClass.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColClass.AppearanceCell.Options.UseTextOptions = True
        Me.GColClass.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColClass.AppearanceHeader.Font = CType(resources.GetObject("GColClass.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColClass.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColClass.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColClass.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColClass.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColClass.AppearanceHeader.GradientMode = CType(resources.GetObject("GColClass.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColClass.AppearanceHeader.Image = CType(resources.GetObject("GColClass.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColClass.AppearanceHeader.Options.UseFont = True
        Me.GColClass.AppearanceHeader.Options.UseTextOptions = True
        Me.GColClass.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GColClass, "GColClass")
        Me.GColClass.FieldName = "CLASS"
        Me.GColClass.Name = "GColClass"
        '
        'GColP
        '
        Me.GColP.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColP.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColP.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColP.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColP.AppearanceCell.GradientMode = CType(resources.GetObject("GColP.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColP.AppearanceCell.Image = CType(resources.GetObject("GColP.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColP.AppearanceCell.Options.UseTextOptions = True
        Me.GColP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColP.AppearanceHeader.Font = CType(resources.GetObject("GColP.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColP.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColP.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColP.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColP.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColP.AppearanceHeader.GradientMode = CType(resources.GetObject("GColP.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColP.AppearanceHeader.Image = CType(resources.GetObject("GColP.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColP.AppearanceHeader.Options.UseFont = True
        Me.GColP.AppearanceHeader.Options.UseTextOptions = True
        Me.GColP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GColP, "GColP")
        Me.GColP.DisplayFormat.FormatString = "{0} %"
        Me.GColP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GColP.FieldName = "P"
        Me.GColP.Name = "GColP"
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
        'ChartTot
        '
        resources.ApplyResources(Me.ChartTot, "ChartTot")
        XyDiagram1.AxisX.Label.Angle = CType(resources.GetObject("resource.Angle"), Integer)
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartTot.Diagram = XyDiagram1
        Me.ChartTot.Name = "ChartTot"
        Series1.ArgumentDataMember = "vpernom"
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        resources.ApplyResources(Series1, "Series1")
        Series1.ShowInLegend = False
        Series1.ValueDataMembersSerializable = "valeur"
        SideBySideBarSeriesView1.ColorEach = True
        Series1.View = SideBySideBarSeriesView1
        Me.ChartTot.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        SideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartTot.SeriesTemplate.Label = SideBySideBarSeriesLabel2
		ChartTitle1.TextColor = System.Drawing.Color.Black
        Me.ChartTot.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
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
        'frmStatContremaitre
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblPeriode)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.ChartTot)
        Me.Controls.Add(Me.GCStatTot)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmStatContremaitre"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCStatTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStatTot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents GColContremaitre As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColValeur As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ChartTot As DevExpress.XtraCharts.ChartControl
    Private WithEvents GColNbTech As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColClass As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColP As DevExpress.XtraGrid.Columns.GridColumn
End Class
