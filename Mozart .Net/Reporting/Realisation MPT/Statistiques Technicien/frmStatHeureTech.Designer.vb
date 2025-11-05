<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatHeureTech
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatHeureTech))
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim SideBySideBarSeriesLabel4 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnGraphTech = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.GCStatTot = New DevExpress.XtraGrid.GridControl()
        Me.GVStatTot = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColTotVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColTotHEURES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColTotSOCIETE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColTYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCDetail = New DevExpress.XtraGrid.GridControl()
        Me.GVDetail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColDetNDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetDACTDEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetVACTATT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetVSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetNACTDUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCSem = New DevExpress.XtraGrid.GridControl()
        Me.GVSem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColSemDIPLDATJ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColSemJour = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColSemHeures = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChartTot = New DevExpress.XtraCharts.ChartControl()
        Me.LblPeriode = New System.Windows.Forms.Label()
        Me.GCAnnee = New DevExpress.XtraGrid.GridControl()
        Me.GVAnnee = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColAnneeANNEE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColAnneeSEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColAnneeHeures = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColAnneeHRREF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LblHRRef = New System.Windows.Forms.Label()
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
        CType(Me.GCAnnee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVAnnee, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GrpActions.Controls.Add(Me.BtnGraphTech)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnGraphTech
        '
        resources.ApplyResources(Me.BtnGraphTech, "BtnGraphTech")
        Me.BtnGraphTech.Name = "BtnGraphTech"
        Me.BtnGraphTech.UseVisualStyleBackColor = True
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
        Me.GVStatTot.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColTotVPERNOM, Me.GColTotHEURES, Me.GColNPERNUM, Me.GColTotSOCIETE, Me.GColTYPE})
        Me.GVStatTot.GridControl = Me.GCStatTot
        Me.GVStatTot.Name = "GVStatTot"
        Me.GVStatTot.OptionsBehavior.Editable = False
        Me.GVStatTot.OptionsBehavior.ReadOnly = True
        Me.GVStatTot.OptionsView.EnableAppearanceEvenRow = True
        Me.GVStatTot.OptionsView.EnableAppearanceOddRow = True
        Me.GVStatTot.OptionsView.ShowGroupPanel = False
        '
        'GColTotVPERNOM
        '
        Me.GColTotVPERNOM.AppearanceHeader.Font = CType(resources.GetObject("GColTotVPERNOM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColTotVPERNOM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColTotVPERNOM.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColTotVPERNOM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColTotVPERNOM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColTotVPERNOM.AppearanceHeader.GradientMode = CType(resources.GetObject("GColTotVPERNOM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColTotVPERNOM.AppearanceHeader.Image = CType(resources.GetObject("GColTotVPERNOM.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColTotVPERNOM.AppearanceHeader.Options.UseFont = True
        Me.GColTotVPERNOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColTotVPERNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColTotVPERNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColTotVPERNOM, "GColTotVPERNOM")
        Me.GColTotVPERNOM.FieldName = "VPERNOM"
        Me.GColTotVPERNOM.Name = "GColTotVPERNOM"
        Me.GColTotVPERNOM.OptionsColumn.AllowEdit = False
        Me.GColTotVPERNOM.OptionsColumn.ReadOnly = True
        '
        'GColTotHEURES
        '
        Me.GColTotHEURES.AppearanceHeader.Font = CType(resources.GetObject("GColTotHEURES.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColTotHEURES.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColTotHEURES.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColTotHEURES.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColTotHEURES.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColTotHEURES.AppearanceHeader.GradientMode = CType(resources.GetObject("GColTotHEURES.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColTotHEURES.AppearanceHeader.Image = CType(resources.GetObject("GColTotHEURES.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColTotHEURES.AppearanceHeader.Options.UseFont = True
        Me.GColTotHEURES.AppearanceHeader.Options.UseTextOptions = True
        Me.GColTotHEURES.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColTotHEURES.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColTotHEURES, "GColTotHEURES")
        Me.GColTotHEURES.DisplayFormat.FormatString = "{0:n0}"
        Me.GColTotHEURES.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColTotHEURES.FieldName = "Heures"
        Me.GColTotHEURES.Name = "GColTotHEURES"
        Me.GColTotHEURES.OptionsColumn.AllowEdit = False
        Me.GColTotHEURES.OptionsColumn.ReadOnly = True
        '
        'GColNPERNUM
        '
        resources.ApplyResources(Me.GColNPERNUM, "GColNPERNUM")
        Me.GColNPERNUM.FieldName = "NPERNUM"
        Me.GColNPERNUM.Name = "GColNPERNUM"
        '
        'GColTotSOCIETE
        '
        resources.ApplyResources(Me.GColTotSOCIETE, "GColTotSOCIETE")
        Me.GColTotSOCIETE.FieldName = "SOCIETE"
        Me.GColTotSOCIETE.Name = "GColTotSOCIETE"
        '
        'GColTYPE
        '
        resources.ApplyResources(Me.GColTYPE, "GColTYPE")
        Me.GColTYPE.FieldName = "TYPE"
        Me.GColTYPE.Name = "GColTYPE"
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
        Me.GVDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColDetNDINNUM, Me.GColDetDACTDEX, Me.GColDetVACTATT, Me.GColDetVCLINOM, Me.GColDetVSITNOM, Me.GColDetVPERNOM, Me.GColDetNACTDUR})
        Me.GVDetail.GridControl = Me.GCDetail
        Me.GVDetail.Name = "GVDetail"
        Me.GVDetail.OptionsBehavior.Editable = False
        Me.GVDetail.OptionsBehavior.ReadOnly = True
        Me.GVDetail.OptionsView.EnableAppearanceEvenRow = True
        Me.GVDetail.OptionsView.EnableAppearanceOddRow = True
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
        'GColDetVACTATT
        '
        Me.GColDetVACTATT.AppearanceHeader.Font = CType(resources.GetObject("GColDetVACTATT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDetVACTATT.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColDetVACTATT.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColDetVACTATT.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColDetVACTATT.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDetVACTATT.AppearanceHeader.GradientMode = CType(resources.GetObject("GColDetVACTATT.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDetVACTATT.AppearanceHeader.Image = CType(resources.GetObject("GColDetVACTATT.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColDetVACTATT.AppearanceHeader.Options.UseFont = True
        Me.GColDetVACTATT.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetVACTATT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetVACTATT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetVACTATT, "GColDetVACTATT")
        Me.GColDetVACTATT.FieldName = "VACTATT"
        Me.GColDetVACTATT.Name = "GColDetVACTATT"
        Me.GColDetVACTATT.OptionsColumn.AllowEdit = False
        Me.GColDetVACTATT.OptionsColumn.ReadOnly = True
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
        'GColDetNACTDUR
        '
        Me.GColDetNACTDUR.AppearanceHeader.Font = CType(resources.GetObject("GColDetNACTDUR.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDetNACTDUR.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColDetNACTDUR.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColDetNACTDUR.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColDetNACTDUR.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDetNACTDUR.AppearanceHeader.GradientMode = CType(resources.GetObject("GColDetNACTDUR.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDetNACTDUR.AppearanceHeader.Image = CType(resources.GetObject("GColDetNACTDUR.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColDetNACTDUR.AppearanceHeader.Options.UseFont = True
        Me.GColDetNACTDUR.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetNACTDUR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetNACTDUR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetNACTDUR, "GColDetNACTDUR")
        Me.GColDetNACTDUR.DisplayFormat.FormatString = "{0:n0}"
        Me.GColDetNACTDUR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColDetNACTDUR.FieldName = "NACTDUR"
        Me.GColDetNACTDUR.Name = "GColDetNACTDUR"
        Me.GColDetNACTDUR.OptionsColumn.AllowEdit = False
        Me.GColDetNACTDUR.OptionsColumn.ReadOnly = True
        '
        'GCSem
        '
        resources.ApplyResources(Me.GCSem, "GCSem")
        '
        '
        '
        Me.GCSem.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCSem.EmbeddedNavigator.AccessibleDescription")
        Me.GCSem.EmbeddedNavigator.AccessibleName = resources.GetString("GCSem.EmbeddedNavigator.AccessibleName")
        Me.GCSem.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCSem.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCSem.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCSem.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCSem.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCSem.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCSem.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCSem.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCSem.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCSem.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCSem.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCSem.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCSem.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCSem.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCSem.EmbeddedNavigator.ToolTip = resources.GetString("GCSem.EmbeddedNavigator.ToolTip")
        Me.GCSem.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCSem.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCSem.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCSem.EmbeddedNavigator.ToolTipTitle")
        Me.GCSem.MainView = Me.GVSem
        Me.GCSem.Name = "GCSem"
        Me.GCSem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSem})
        '
        'GVSem
        '
        Me.GVSem.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.ColumnFilterButton.BackColor2 = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButton.BackColor2"), System.Drawing.Color)
        Me.GVSem.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVSem.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVSem.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSem.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSem.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSem.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.ColumnFilterButtonActive.BackColor2 = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButtonActive.BackColor2"), System.Drawing.Color)
        Me.GVSem.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVSem.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVSem.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVSem.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSem.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSem.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSem.Appearance.Empty.BackColor = CType(resources.GetObject("GVSem.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.Empty.GradientMode = CType(resources.GetObject("GVSem.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.Empty.Image = CType(resources.GetObject("GVSem.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.Empty.Options.UseBackColor = True
        Me.GVSem.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVSem.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVSem.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVSem.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVSem.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.EvenRow.Image = CType(resources.GetObject("GVSem.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSem.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSem.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVSem.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.FilterCloseButton.BackColor2 = CType(resources.GetObject("GVSem.Appearance.FilterCloseButton.BackColor2"), System.Drawing.Color)
        Me.GVSem.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVSem.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVSem.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVSem.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVSem.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVSem.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVSem.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSem.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSem.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSem.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVSem.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVSem.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVSem.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVSem.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.FilterPanel.Image = CType(resources.GetObject("GVSem.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSem.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSem.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVSem.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVSem.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.FixedLine.Image = CType(resources.GetObject("GVSem.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSem.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVSem.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVSem.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVSem.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVSem.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.FocusedCell.Image = CType(resources.GetObject("GVSem.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSem.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSem.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVSem.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVSem.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVSem.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVSem.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.FocusedRow.Image = CType(resources.GetObject("GVSem.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSem.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSem.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVSem.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.FooterPanel.BackColor2 = CType(resources.GetObject("GVSem.Appearance.FooterPanel.BackColor2"), System.Drawing.Color)
        Me.GVSem.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVSem.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVSem.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVSem.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVSem.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVSem.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.FooterPanel.Image = CType(resources.GetObject("GVSem.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSem.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSem.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSem.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVSem.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVSem.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVSem.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.GroupButton.ForeColor = CType(resources.GetObject("GVSem.Appearance.GroupButton.ForeColor"), System.Drawing.Color)
        Me.GVSem.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVSem.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.GroupButton.Image = CType(resources.GetObject("GVSem.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSem.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSem.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVSem.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVSem.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVSem.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVSem.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVSem.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVSem.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVSem.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.GroupFooter.Image = CType(resources.GetObject("GVSem.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSem.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSem.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSem.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVSem.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVSem.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVSem.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVSem.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.GroupPanel.Image = CType(resources.GetObject("GVSem.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSem.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSem.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVSem.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVSem.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVSem.Appearance.GroupRow.Font = CType(resources.GetObject("GVSem.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.GVSem.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVSem.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVSem.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVSem.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.GroupRow.Image = CType(resources.GetObject("GVSem.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSem.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSem.Appearance.GroupRow.Options.UseFont = True
        Me.GVSem.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSem.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVSem.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.HeaderPanel.BackColor2 = CType(resources.GetObject("GVSem.Appearance.HeaderPanel.BackColor2"), System.Drawing.Color)
        Me.GVSem.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVSem.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVSem.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVSem.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVSem.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVSem.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVSem.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSem.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSem.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSem.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVSem.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVSem.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVSem.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVSem.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVSem.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSem.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSem.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVSem.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVSem.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.HorzLine.Image = CType(resources.GetObject("GVSem.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSem.Appearance.OddRow.BackColor = CType(resources.GetObject("GVSem.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVSem.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVSem.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVSem.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.OddRow.Image = CType(resources.GetObject("GVSem.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSem.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSem.Appearance.Preview.BackColor = CType(resources.GetObject("GVSem.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.Preview.ForeColor = CType(resources.GetObject("GVSem.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVSem.Appearance.Preview.GradientMode = CType(resources.GetObject("GVSem.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.Preview.Image = CType(resources.GetObject("GVSem.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.Preview.Options.UseBackColor = True
        Me.GVSem.Appearance.Preview.Options.UseForeColor = True
        Me.GVSem.Appearance.Row.BackColor = CType(resources.GetObject("GVSem.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.Row.ForeColor = CType(resources.GetObject("GVSem.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVSem.Appearance.Row.GradientMode = CType(resources.GetObject("GVSem.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.Row.Image = CType(resources.GetObject("GVSem.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.Row.Options.UseBackColor = True
        Me.GVSem.Appearance.Row.Options.UseForeColor = True
        Me.GVSem.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVSem.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVSem.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.RowSeparator.Image = CType(resources.GetObject("GVSem.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSem.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVSem.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVSem.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVSem.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVSem.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.SelectedRow.Image = CType(resources.GetObject("GVSem.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSem.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSem.Appearance.VertLine.BackColor = CType(resources.GetObject("GVSem.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVSem.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVSem.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVSem.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVSem.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSem.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVSem.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSem.Appearance.VertLine.Image = CType(resources.GetObject("GVSem.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVSem.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVSem, "GVSem")
        Me.GVSem.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColSemDIPLDATJ, Me.GColSemJour, Me.GColSemHeures})
        Me.GVSem.GridControl = Me.GCSem
        Me.GVSem.Name = "GVSem"
        Me.GVSem.OptionsBehavior.Editable = False
        Me.GVSem.OptionsBehavior.ReadOnly = True
        Me.GVSem.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSem.OptionsView.EnableAppearanceOddRow = True
        Me.GVSem.OptionsView.ShowGroupPanel = False
        '
        'GColSemDIPLDATJ
        '
        Me.GColSemDIPLDATJ.AppearanceHeader.Font = CType(resources.GetObject("GColSemDIPLDATJ.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColSemDIPLDATJ.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColSemDIPLDATJ.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColSemDIPLDATJ.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColSemDIPLDATJ.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColSemDIPLDATJ.AppearanceHeader.GradientMode = CType(resources.GetObject("GColSemDIPLDATJ.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColSemDIPLDATJ.AppearanceHeader.Image = CType(resources.GetObject("GColSemDIPLDATJ.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColSemDIPLDATJ.AppearanceHeader.Options.UseFont = True
        Me.GColSemDIPLDATJ.AppearanceHeader.Options.UseTextOptions = True
        Me.GColSemDIPLDATJ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColSemDIPLDATJ.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColSemDIPLDATJ, "GColSemDIPLDATJ")
        Me.GColSemDIPLDATJ.FieldName = "DIPLDATJ"
        Me.GColSemDIPLDATJ.Name = "GColSemDIPLDATJ"
        Me.GColSemDIPLDATJ.OptionsColumn.AllowEdit = False
        Me.GColSemDIPLDATJ.OptionsColumn.ReadOnly = True
        '
        'GColSemJour
        '
        Me.GColSemJour.AppearanceHeader.Font = CType(resources.GetObject("GColSemJour.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColSemJour.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColSemJour.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColSemJour.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColSemJour.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColSemJour.AppearanceHeader.GradientMode = CType(resources.GetObject("GColSemJour.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColSemJour.AppearanceHeader.Image = CType(resources.GetObject("GColSemJour.AppearanceHeader.Image"), System.Drawing.Image)
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
        'GColSemHeures
        '
        Me.GColSemHeures.AppearanceHeader.Font = CType(resources.GetObject("GColSemHeures.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColSemHeures.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColSemHeures.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColSemHeures.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColSemHeures.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColSemHeures.AppearanceHeader.GradientMode = CType(resources.GetObject("GColSemHeures.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColSemHeures.AppearanceHeader.Image = CType(resources.GetObject("GColSemHeures.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColSemHeures.AppearanceHeader.Options.UseFont = True
        Me.GColSemHeures.AppearanceHeader.Options.UseTextOptions = True
        Me.GColSemHeures.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColSemHeures.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColSemHeures, "GColSemHeures")
        Me.GColSemHeures.DisplayFormat.FormatString = "{0:n0}"
        Me.GColSemHeures.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColSemHeures.FieldName = "Heures"
        Me.GColSemHeures.Name = "GColSemHeures"
        Me.GColSemHeures.OptionsColumn.AllowEdit = False
        Me.GColSemHeures.OptionsColumn.ReadOnly = True
        '
        'ChartTot
        '
        resources.ApplyResources(Me.ChartTot, "ChartTot")
        XyDiagram2.AxisX.Label.Angle = CType(resources.GetObject("resource.Angle"), Integer)
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartTot.Diagram = XyDiagram2
        Me.ChartTot.Name = "ChartTot"
        Me.ChartTot.PaletteName = "Mixed"
        Series2.ArgumentDataMember = "VPERNOM"
        SideBySideBarSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series2.Label = SideBySideBarSeriesLabel3
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        resources.ApplyResources(Series2, "Series2")
        Series2.ShowInLegend = False
        Series2.ValueDataMembersSerializable = "HEURES"
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
        'GCAnnee
        '
        resources.ApplyResources(Me.GCAnnee, "GCAnnee")
        '
        '
        '
        Me.GCAnnee.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCAnnee.EmbeddedNavigator.AccessibleDescription")
        Me.GCAnnee.EmbeddedNavigator.AccessibleName = resources.GetString("GCAnnee.EmbeddedNavigator.AccessibleName")
        Me.GCAnnee.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCAnnee.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCAnnee.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCAnnee.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCAnnee.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCAnnee.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCAnnee.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCAnnee.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCAnnee.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCAnnee.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCAnnee.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCAnnee.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCAnnee.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCAnnee.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCAnnee.EmbeddedNavigator.ToolTip = resources.GetString("GCAnnee.EmbeddedNavigator.ToolTip")
        Me.GCAnnee.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCAnnee.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCAnnee.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCAnnee.EmbeddedNavigator.ToolTipTitle")
        Me.GCAnnee.MainView = Me.GVAnnee
        Me.GCAnnee.Name = "GCAnnee"
        Me.GCAnnee.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVAnnee})
        '
        'GVAnnee
        '
        Me.GVAnnee.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVAnnee.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.ColumnFilterButton.BackColor2 = CType(resources.GetObject("GVAnnee.Appearance.ColumnFilterButton.BackColor2"), System.Drawing.Color)
        Me.GVAnnee.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVAnnee.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVAnnee.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVAnnee.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVAnnee.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVAnnee.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVAnnee.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVAnnee.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.ColumnFilterButtonActive.BackColor2 = CType(resources.GetObject("GVAnnee.Appearance.ColumnFilterButtonActive.BackColor2"), System.Drawing.Color)
        Me.GVAnnee.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVAnnee.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVAnnee.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVAnnee.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVAnnee.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVAnnee.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVAnnee.Appearance.Empty.BackColor = CType(resources.GetObject("GVAnnee.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.Empty.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.Empty.Image = CType(resources.GetObject("GVAnnee.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.Empty.Options.UseBackColor = True
        Me.GVAnnee.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVAnnee.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVAnnee.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.EvenRow.Image = CType(resources.GetObject("GVAnnee.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVAnnee.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVAnnee.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVAnnee.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.FilterCloseButton.BackColor2 = CType(resources.GetObject("GVAnnee.Appearance.FilterCloseButton.BackColor2"), System.Drawing.Color)
        Me.GVAnnee.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVAnnee.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVAnnee.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVAnnee.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVAnnee.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVAnnee.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVAnnee.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVAnnee.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVAnnee.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.FilterPanel.Image = CType(resources.GetObject("GVAnnee.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVAnnee.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVAnnee.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVAnnee.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.FixedLine.Image = CType(resources.GetObject("GVAnnee.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVAnnee.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVAnnee.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVAnnee.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.FocusedCell.Image = CType(resources.GetObject("GVAnnee.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVAnnee.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVAnnee.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVAnnee.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVAnnee.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.FocusedRow.Image = CType(resources.GetObject("GVAnnee.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVAnnee.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVAnnee.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVAnnee.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.FooterPanel.BackColor2 = CType(resources.GetObject("GVAnnee.Appearance.FooterPanel.BackColor2"), System.Drawing.Color)
        Me.GVAnnee.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVAnnee.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVAnnee.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.FooterPanel.Image = CType(resources.GetObject("GVAnnee.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVAnnee.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVAnnee.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVAnnee.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVAnnee.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVAnnee.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.GroupButton.ForeColor = CType(resources.GetObject("GVAnnee.Appearance.GroupButton.ForeColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.GroupButton.Image = CType(resources.GetObject("GVAnnee.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVAnnee.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVAnnee.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVAnnee.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVAnnee.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVAnnee.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVAnnee.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.GroupFooter.Image = CType(resources.GetObject("GVAnnee.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVAnnee.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVAnnee.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVAnnee.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVAnnee.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVAnnee.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.GroupPanel.Image = CType(resources.GetObject("GVAnnee.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVAnnee.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVAnnee.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVAnnee.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVAnnee.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.GroupRow.Font = CType(resources.GetObject("GVAnnee.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.GVAnnee.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVAnnee.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.GroupRow.Image = CType(resources.GetObject("GVAnnee.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVAnnee.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVAnnee.Appearance.GroupRow.Options.UseFont = True
        Me.GVAnnee.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVAnnee.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVAnnee.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.HeaderPanel.BackColor2 = CType(resources.GetObject("GVAnnee.Appearance.HeaderPanel.BackColor2"), System.Drawing.Color)
        Me.GVAnnee.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVAnnee.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVAnnee.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVAnnee.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVAnnee.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVAnnee.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVAnnee.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVAnnee.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVAnnee.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVAnnee.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVAnnee.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVAnnee.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVAnnee.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.HorzLine.Image = CType(resources.GetObject("GVAnnee.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVAnnee.Appearance.OddRow.BackColor = CType(resources.GetObject("GVAnnee.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVAnnee.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.OddRow.Image = CType(resources.GetObject("GVAnnee.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.OddRow.Options.UseBackColor = True
        Me.GVAnnee.Appearance.OddRow.Options.UseForeColor = True
        Me.GVAnnee.Appearance.Preview.BackColor = CType(resources.GetObject("GVAnnee.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.Preview.ForeColor = CType(resources.GetObject("GVAnnee.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.Preview.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.Preview.Image = CType(resources.GetObject("GVAnnee.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.Preview.Options.UseBackColor = True
        Me.GVAnnee.Appearance.Preview.Options.UseForeColor = True
        Me.GVAnnee.Appearance.Row.BackColor = CType(resources.GetObject("GVAnnee.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.Row.ForeColor = CType(resources.GetObject("GVAnnee.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.Row.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.Row.Image = CType(resources.GetObject("GVAnnee.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.Row.Options.UseBackColor = True
        Me.GVAnnee.Appearance.Row.Options.UseForeColor = True
        Me.GVAnnee.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVAnnee.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.RowSeparator.Image = CType(resources.GetObject("GVAnnee.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVAnnee.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVAnnee.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVAnnee.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.SelectedRow.Image = CType(resources.GetObject("GVAnnee.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVAnnee.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVAnnee.Appearance.VertLine.BackColor = CType(resources.GetObject("GVAnnee.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVAnnee.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVAnnee.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVAnnee.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVAnnee.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVAnnee.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVAnnee.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVAnnee.Appearance.VertLine.Image = CType(resources.GetObject("GVAnnee.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVAnnee.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVAnnee, "GVAnnee")
        Me.GVAnnee.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColAnneeANNEE, Me.GColAnneeSEM, Me.GColAnneeHeures, Me.GColAnneeHRREF})
        Me.GVAnnee.GridControl = Me.GCAnnee
        Me.GVAnnee.Name = "GVAnnee"
        Me.GVAnnee.OptionsBehavior.Editable = False
        Me.GVAnnee.OptionsBehavior.ReadOnly = True
        Me.GVAnnee.OptionsView.EnableAppearanceEvenRow = True
        Me.GVAnnee.OptionsView.EnableAppearanceOddRow = True
        Me.GVAnnee.OptionsView.ShowGroupPanel = False
        '
        'GColAnneeANNEE
        '
        Me.GColAnneeANNEE.AppearanceHeader.Font = CType(resources.GetObject("GColAnneeANNEE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColAnneeANNEE.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColAnneeANNEE.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColAnneeANNEE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColAnneeANNEE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColAnneeANNEE.AppearanceHeader.GradientMode = CType(resources.GetObject("GColAnneeANNEE.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColAnneeANNEE.AppearanceHeader.Image = CType(resources.GetObject("GColAnneeANNEE.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColAnneeANNEE.AppearanceHeader.Options.UseFont = True
        Me.GColAnneeANNEE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColAnneeANNEE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColAnneeANNEE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColAnneeANNEE, "GColAnneeANNEE")
        Me.GColAnneeANNEE.FieldName = "ANNEE"
        Me.GColAnneeANNEE.Name = "GColAnneeANNEE"
        Me.GColAnneeANNEE.OptionsColumn.AllowEdit = False
        Me.GColAnneeANNEE.OptionsColumn.ReadOnly = True
        '
        'GColAnneeSEM
        '
        Me.GColAnneeSEM.AppearanceHeader.Font = CType(resources.GetObject("GColAnneeSEM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColAnneeSEM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColAnneeSEM.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColAnneeSEM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColAnneeSEM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColAnneeSEM.AppearanceHeader.GradientMode = CType(resources.GetObject("GColAnneeSEM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColAnneeSEM.AppearanceHeader.Image = CType(resources.GetObject("GColAnneeSEM.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColAnneeSEM.AppearanceHeader.Options.UseFont = True
        Me.GColAnneeSEM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColAnneeSEM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColAnneeSEM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColAnneeSEM, "GColAnneeSEM")
        Me.GColAnneeSEM.FieldName = "SEM"
        Me.GColAnneeSEM.Name = "GColAnneeSEM"
        Me.GColAnneeSEM.OptionsColumn.AllowEdit = False
        Me.GColAnneeSEM.OptionsColumn.ReadOnly = True
        '
        'GColAnneeHeures
        '
        Me.GColAnneeHeures.AppearanceHeader.Font = CType(resources.GetObject("GColAnneeHeures.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColAnneeHeures.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColAnneeHeures.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColAnneeHeures.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColAnneeHeures.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColAnneeHeures.AppearanceHeader.GradientMode = CType(resources.GetObject("GColAnneeHeures.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColAnneeHeures.AppearanceHeader.Image = CType(resources.GetObject("GColAnneeHeures.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColAnneeHeures.AppearanceHeader.Options.UseFont = True
        Me.GColAnneeHeures.AppearanceHeader.Options.UseTextOptions = True
        Me.GColAnneeHeures.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColAnneeHeures.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColAnneeHeures, "GColAnneeHeures")
        Me.GColAnneeHeures.DisplayFormat.FormatString = "{0:n0}"
        Me.GColAnneeHeures.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColAnneeHeures.FieldName = "Heures"
        Me.GColAnneeHeures.Name = "GColAnneeHeures"
        Me.GColAnneeHeures.OptionsColumn.AllowEdit = False
        Me.GColAnneeHeures.OptionsColumn.ReadOnly = True
        '
        'GColAnneeHRREF
        '
        Me.GColAnneeHRREF.AppearanceHeader.Font = CType(resources.GetObject("GColAnneeHRREF.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColAnneeHRREF.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColAnneeHRREF.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColAnneeHRREF.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColAnneeHRREF.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColAnneeHRREF.AppearanceHeader.GradientMode = CType(resources.GetObject("GColAnneeHRREF.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColAnneeHRREF.AppearanceHeader.Image = CType(resources.GetObject("GColAnneeHRREF.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColAnneeHRREF.AppearanceHeader.Options.UseFont = True
        Me.GColAnneeHRREF.AppearanceHeader.Options.UseTextOptions = True
        Me.GColAnneeHRREF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColAnneeHRREF.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColAnneeHRREF, "GColAnneeHRREF")
        Me.GColAnneeHRREF.DisplayFormat.FormatString = "{0:n0}"
        Me.GColAnneeHRREF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColAnneeHRREF.FieldName = "HRREF"
        Me.GColAnneeHRREF.Name = "GColAnneeHRREF"
        Me.GColAnneeHRREF.OptionsColumn.AllowEdit = False
        Me.GColAnneeHRREF.OptionsColumn.ReadOnly = True
        '
        'LblHRRef
        '
        resources.ApplyResources(Me.LblHRRef, "LblHRRef")
        Me.LblHRRef.Name = "LblHRRef"
        '
        'frmStatHeureTech
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblHRRef)
        Me.Controls.Add(Me.GCAnnee)
        Me.Controls.Add(Me.LblPeriode)
        Me.Controls.Add(Me.ChartTot)
        Me.Controls.Add(Me.GCSem)
        Me.Controls.Add(Me.GCDetail)
        Me.Controls.Add(Me.GCStatTot)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmStatHeureTech"
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
        CType(Me.GCAnnee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVAnnee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents LblPeriode As System.Windows.Forms.Label
    Friend WithEvents LblHRRef As System.Windows.Forms.Label
    Friend WithEvents BtnGraphTech As System.Windows.Forms.Button
    Private WithEvents GCStatTot As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStatTot As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCDetail As DevExpress.XtraGrid.GridControl
    Private WithEvents GVDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCSem As DevExpress.XtraGrid.GridControl
    Private WithEvents GVSem As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColTotVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColTotHEURES As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetNDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetDACTDEX As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetVACTATT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetVSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetNACTDUR As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColSemDIPLDATJ As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColSemJour As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColSemHeures As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ChartTot As DevExpress.XtraCharts.ChartControl
    Private WithEvents GColTotSOCIETE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColTYPE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCAnnee As DevExpress.XtraGrid.GridControl
    Private WithEvents GVAnnee As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColAnneeANNEE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColAnneeSEM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColAnneeHeures As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColAnneeHRREF As DevExpress.XtraGrid.Columns.GridColumn
End Class
