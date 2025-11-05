<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailsCaseWithDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetailsCaseWithDetail))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.GColDetlNVALFAC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVDetail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColDetlNUMERO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetlNVALENGAGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetlNSTFNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetlVSTFNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCDetailCase = New DevExpress.XtraGrid.GridControl()
        Me.GVSUM = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColVSTFNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCOlNVALENGAGESUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNVALFACSUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNSTFNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GVDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCDetailCase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSUM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GColDetlNVALFAC
        '
        Me.GColDetlNVALFAC.AppearanceHeader.Font = CType(resources.GetObject("GColDetlNVALFAC.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDetlNVALFAC.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColDetlNVALFAC.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColDetlNVALFAC.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColDetlNVALFAC.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDetlNVALFAC.AppearanceHeader.GradientMode = CType(resources.GetObject("GColDetlNVALFAC.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDetlNVALFAC.AppearanceHeader.Image = CType(resources.GetObject("GColDetlNVALFAC.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColDetlNVALFAC.AppearanceHeader.Options.UseFont = True
        Me.GColDetlNVALFAC.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetlNVALFAC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetlNVALFAC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDetlNVALFAC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColDetlNVALFAC, "GColDetlNVALFAC")
        Me.GColDetlNVALFAC.DisplayFormat.FormatString = "c2"
        Me.GColDetlNVALFAC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColDetlNVALFAC.FieldName = "NVALFAC"
        Me.GColDetlNVALFAC.Name = "GColDetlNVALFAC"
        '
        'GVDetail
        '
        resources.ApplyResources(Me.GVDetail, "GVDetail")
        Me.GVDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColDetlNUMERO, Me.GColDetlNVALENGAGE, Me.GColDetlNVALFAC, Me.GColDetlNSTFNUM, Me.GColDetlVSTFNOM})
        StyleFormatCondition1.Appearance.Font = CType(resources.GetObject("resource.Font"), System.Drawing.Font)
        StyleFormatCondition1.Appearance.FontSizeDelta = CType(resources.GetObject("resource.FontSizeDelta"), Integer)
        StyleFormatCondition1.Appearance.FontStyleDelta = CType(resources.GetObject("resource.FontStyleDelta"), System.Drawing.FontStyle)
        StyleFormatCondition1.Appearance.ForeColor = CType(resources.GetObject("resource.ForeColor"), System.Drawing.Color)
        StyleFormatCondition1.Appearance.GradientMode = CType(resources.GetObject("resource.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        StyleFormatCondition1.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.GColDetlNVALFAC
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[NVALENGAGE]<[NVALFAC]"
        Me.GVDetail.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GVDetail.GridControl = Me.GCDetailCase
        Me.GVDetail.Name = "GVDetail"
        Me.GVDetail.OptionsBehavior.Editable = False
        Me.GVDetail.OptionsBehavior.ReadOnly = True
        Me.GVDetail.OptionsDetail.ShowDetailTabs = False
        Me.GVDetail.OptionsView.ShowGroupPanel = False
        '
        'GColDetlNUMERO
        '
        Me.GColDetlNUMERO.AppearanceHeader.Font = CType(resources.GetObject("GColDetlNUMERO.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDetlNUMERO.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColDetlNUMERO.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColDetlNUMERO.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColDetlNUMERO.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDetlNUMERO.AppearanceHeader.GradientMode = CType(resources.GetObject("GColDetlNUMERO.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDetlNUMERO.AppearanceHeader.Image = CType(resources.GetObject("GColDetlNUMERO.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColDetlNUMERO.AppearanceHeader.Options.UseFont = True
        Me.GColDetlNUMERO.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetlNUMERO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetlNUMERO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDetlNUMERO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColDetlNUMERO, "GColDetlNUMERO")
        Me.GColDetlNUMERO.DisplayFormat.FormatString = "CF {0}"
        Me.GColDetlNUMERO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GColDetlNUMERO.FieldName = "NCOMNUM"
        Me.GColDetlNUMERO.Name = "GColDetlNUMERO"
        '
        'GColDetlNVALENGAGE
        '
        Me.GColDetlNVALENGAGE.AppearanceHeader.Font = CType(resources.GetObject("GColDetlNVALENGAGE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDetlNVALENGAGE.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColDetlNVALENGAGE.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColDetlNVALENGAGE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColDetlNVALENGAGE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDetlNVALENGAGE.AppearanceHeader.GradientMode = CType(resources.GetObject("GColDetlNVALENGAGE.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDetlNVALENGAGE.AppearanceHeader.Image = CType(resources.GetObject("GColDetlNVALENGAGE.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColDetlNVALENGAGE.AppearanceHeader.Options.UseFont = True
        Me.GColDetlNVALENGAGE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetlNVALENGAGE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetlNVALENGAGE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDetlNVALENGAGE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColDetlNVALENGAGE, "GColDetlNVALENGAGE")
        Me.GColDetlNVALENGAGE.DisplayFormat.FormatString = "c2"
        Me.GColDetlNVALENGAGE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColDetlNVALENGAGE.FieldName = "NVALENGAGE"
        Me.GColDetlNVALENGAGE.Name = "GColDetlNVALENGAGE"
        '
        'GColDetlNSTFNUM
        '
        resources.ApplyResources(Me.GColDetlNSTFNUM, "GColDetlNSTFNUM")
        Me.GColDetlNSTFNUM.FieldName = "NSTFNUM"
        Me.GColDetlNSTFNUM.Name = "GColDetlNSTFNUM"
        '
        'GColDetlVSTFNOM
        '
        resources.ApplyResources(Me.GColDetlVSTFNOM, "GColDetlVSTFNOM")
        Me.GColDetlVSTFNOM.FieldName = "VSTFNOM"
        Me.GColDetlVSTFNOM.Name = "GColDetlVSTFNOM"
        '
        'GCDetailCase
        '
        resources.ApplyResources(Me.GCDetailCase, "GCDetailCase")
        '
        '
        '
        Me.GCDetailCase.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCDetailCase.EmbeddedNavigator.AccessibleDescription")
        Me.GCDetailCase.EmbeddedNavigator.AccessibleName = resources.GetString("GCDetailCase.EmbeddedNavigator.AccessibleName")
        Me.GCDetailCase.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCDetailCase.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCDetailCase.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCDetailCase.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCDetailCase.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCDetailCase.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCDetailCase.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCDetailCase.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCDetailCase.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCDetailCase.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCDetailCase.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCDetailCase.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCDetailCase.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCDetailCase.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCDetailCase.EmbeddedNavigator.ToolTip = resources.GetString("GCDetailCase.EmbeddedNavigator.ToolTip")
        Me.GCDetailCase.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCDetailCase.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCDetailCase.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCDetailCase.EmbeddedNavigator.ToolTipTitle")
        GridLevelNode1.LevelTemplate = Me.GVDetail
        GridLevelNode1.RelationName = "LvlDetail"
        Me.GCDetailCase.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GCDetailCase.MainView = Me.GVSUM
        Me.GCDetailCase.Name = "GCDetailCase"
        Me.GCDetailCase.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSUM, Me.GVDetail})
        '
        'GVSUM
        '
        Me.GVSUM.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVSUM.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVSUM.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVSUM.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVSUM.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVSUM.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSUM.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSUM.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSUM.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVSUM.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVSUM.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVSUM.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVSUM.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVSUM.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSUM.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSUM.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSUM.Appearance.Empty.BackColor = CType(resources.GetObject("GVSUM.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVSUM.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVSUM.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.Empty.GradientMode = CType(resources.GetObject("GVSUM.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.Empty.Image = CType(resources.GetObject("GVSUM.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.Empty.Options.UseBackColor = True
        Me.GVSUM.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVSUM.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVSUM.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVSUM.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVSUM.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.EvenRow.Image = CType(resources.GetObject("GVSUM.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSUM.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVSUM.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSUM.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVSUM.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVSUM.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVSUM.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVSUM.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVSUM.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSUM.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSUM.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSUM.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVSUM.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVSUM.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVSUM.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVSUM.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVSUM.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.FilterPanel.Image = CType(resources.GetObject("GVSUM.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSUM.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSUM.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVSUM.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVSUM.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.FixedLine.Image = CType(resources.GetObject("GVSUM.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSUM.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVSUM.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVSUM.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVSUM.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.FocusedCell.Image = CType(resources.GetObject("GVSUM.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSUM.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSUM.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVSUM.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.FocusedRow.BorderColor = CType(resources.GetObject("GVSUM.Appearance.FocusedRow.BorderColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVSUM.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVSUM.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.FocusedRow.Image = CType(resources.GetObject("GVSUM.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSUM.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVSUM.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSUM.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVSUM.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVSUM.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVSUM.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVSUM.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.FooterPanel.Image = CType(resources.GetObject("GVSUM.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSUM.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSUM.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSUM.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVSUM.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVSUM.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVSUM.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.GroupButton.Image = CType(resources.GetObject("GVSUM.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSUM.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSUM.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVSUM.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVSUM.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVSUM.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVSUM.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.GroupFooter.Image = CType(resources.GetObject("GVSUM.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSUM.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSUM.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSUM.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVSUM.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVSUM.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVSUM.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVSUM.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVSUM.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.GroupPanel.Image = CType(resources.GetObject("GVSUM.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSUM.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSUM.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVSUM.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVSUM.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVSUM.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVSUM.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.GroupRow.Image = CType(resources.GetObject("GVSUM.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSUM.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSUM.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSUM.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVSUM.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVSUM.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVSUM.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVSUM.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVSUM.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVSUM.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVSUM.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSUM.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSUM.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVSUM.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSUM.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVSUM.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVSUM.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVSUM.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVSUM.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.HideSelectionRow.BorderColor = CType(resources.GetObject("GVSUM.Appearance.HideSelectionRow.BorderColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVSUM.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVSUM.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVSUM.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSUM.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVSUM.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSUM.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVSUM.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVSUM.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.HorzLine.Image = CType(resources.GetObject("GVSUM.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSUM.Appearance.OddRow.BackColor = CType(resources.GetObject("GVSUM.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVSUM.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVSUM.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVSUM.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.OddRow.Image = CType(resources.GetObject("GVSUM.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSUM.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVSUM.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSUM.Appearance.Preview.Font = CType(resources.GetObject("GVSUM.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVSUM.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.Preview.ForeColor = CType(resources.GetObject("GVSUM.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.Preview.GradientMode = CType(resources.GetObject("GVSUM.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.Preview.Image = CType(resources.GetObject("GVSUM.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.Preview.Options.UseFont = True
        Me.GVSUM.Appearance.Preview.Options.UseForeColor = True
        Me.GVSUM.Appearance.Row.BackColor = CType(resources.GetObject("GVSUM.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.Row.ForeColor = CType(resources.GetObject("GVSUM.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.Row.GradientMode = CType(resources.GetObject("GVSUM.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.Row.Image = CType(resources.GetObject("GVSUM.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.Row.Options.UseBackColor = True
        Me.GVSUM.Appearance.Row.Options.UseForeColor = True
        Me.GVSUM.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVSUM.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVSUM.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVSUM.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVSUM.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.RowSeparator.Image = CType(resources.GetObject("GVSUM.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSUM.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVSUM.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVSUM.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVSUM.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.SelectedRow.Image = CType(resources.GetObject("GVSUM.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSUM.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSUM.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVSUM.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVSUM.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.TopNewRow.Image = CType(resources.GetObject("GVSUM.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSUM.Appearance.VertLine.BackColor = CType(resources.GetObject("GVSUM.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVSUM.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVSUM.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVSUM.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVSUM.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSUM.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVSUM.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSUM.Appearance.VertLine.Image = CType(resources.GetObject("GVSUM.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVSUM.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVSUM, "GVSUM")
        Me.GVSUM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColVSTFNOM, Me.GCOlNVALENGAGESUM, Me.GColNVALFACSUM, Me.GColNSTFNUM})
        StyleFormatCondition2.Appearance.Font = CType(resources.GetObject("resource.Font1"), System.Drawing.Font)
        StyleFormatCondition2.Appearance.FontSizeDelta = CType(resources.GetObject("resource.FontSizeDelta1"), Integer)
        StyleFormatCondition2.Appearance.FontStyleDelta = CType(resources.GetObject("resource.FontStyleDelta1"), System.Drawing.FontStyle)
        StyleFormatCondition2.Appearance.ForeColor = CType(resources.GetObject("resource.ForeColor1"), System.Drawing.Color)
        StyleFormatCondition2.Appearance.GradientMode = CType(resources.GetObject("resource.GradientMode1"), System.Drawing.Drawing2D.LinearGradientMode)
        StyleFormatCondition2.Appearance.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.GColNVALFACSUM
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "[NVALFACSUM]>[NVALENGAGESUM]"
        Me.GVSUM.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.GVSUM.GridControl = Me.GCDetailCase
        Me.GVSUM.Name = "GVSUM"
        Me.GVSUM.OptionsBehavior.Editable = False
        Me.GVSUM.OptionsBehavior.ReadOnly = True
        Me.GVSUM.OptionsDetail.ShowDetailTabs = False
        Me.GVSUM.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSUM.OptionsView.EnableAppearanceOddRow = True
        Me.GVSUM.OptionsView.ShowFooter = True
        Me.GVSUM.OptionsView.ShowGroupPanel = False
        '
        'GColVSTFNOM
        '
        resources.ApplyResources(Me.GColVSTFNOM, "GColVSTFNOM")
        Me.GColVSTFNOM.FieldName = "VSTFNOM"
        Me.GColVSTFNOM.Name = "GColVSTFNOM"
        '
        'GCOlNVALENGAGESUM
        '
        resources.ApplyResources(Me.GCOlNVALENGAGESUM, "GCOlNVALENGAGESUM")
        Me.GCOlNVALENGAGESUM.DisplayFormat.FormatString = "c2"
        Me.GCOlNVALENGAGESUM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GCOlNVALENGAGESUM.FieldName = "NVALENGAGESUM"
        Me.GCOlNVALENGAGESUM.Name = "GCOlNVALENGAGESUM"
        Me.GCOlNVALENGAGESUM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GCOlNVALENGAGESUM.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("GCOlNVALENGAGESUM.Summary1"), resources.GetString("GCOlNVALENGAGESUM.Summary2"))})
        '
        'GColNVALFACSUM
        '
        resources.ApplyResources(Me.GColNVALFACSUM, "GColNVALFACSUM")
        Me.GColNVALFACSUM.DisplayFormat.FormatString = "c2"
        Me.GColNVALFACSUM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColNVALFACSUM.FieldName = "NVALFACSUM"
        Me.GColNVALFACSUM.Name = "GColNVALFACSUM"
        Me.GColNVALFACSUM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GColNVALFACSUM.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("GColNVALFACSUM.Summary1"), resources.GetString("GColNVALFACSUM.Summary2"))})
        '
        'GColNSTFNUM
        '
        resources.ApplyResources(Me.GColNSTFNUM, "GColNSTFNUM")
        Me.GColNSTFNUM.FieldName = "NSTFNUM"
        Me.GColNSTFNUM.Name = "GColNSTFNUM"
        '
        'frmDetailsCaseWithDetail
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GCDetailCase)
        Me.Name = "frmDetailsCaseWithDetail"
        CType(Me.GVDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCDetailCase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSUM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents GCDetailCase As DevExpress.XtraGrid.GridControl
    Private WithEvents GVSUM As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColVSTFNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCOlNVALENGAGESUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNVALFACSUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColDetlNUMERO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetlNVALENGAGE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetlNVALFAC As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetlNSTFNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNSTFNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetlVSTFNOM As DevExpress.XtraGrid.Columns.GridColumn
End Class
