<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGTPLot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGTPLot))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnSupprLine = New System.Windows.Forms.Button()
        Me.BtnAddLine = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GCGTPLOT = New DevExpress.XtraGrid.GridControl()
        Me.GVGTPLOT = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNGTPLOTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVGTPLOTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCGTPLOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVGTPLOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnSupprLine)
        Me.GrpActions.Controls.Add(Me.BtnAddLine)
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Controls.Add(Me.BtnSave)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnSupprLine
        '
        resources.ApplyResources(Me.BtnSupprLine, "BtnSupprLine")
        Me.BtnSupprLine.BackColor = System.Drawing.Color.LightGreen
        Me.BtnSupprLine.Name = "BtnSupprLine"
        Me.BtnSupprLine.UseVisualStyleBackColor = False
        '
        'BtnAddLine
        '
        resources.ApplyResources(Me.BtnAddLine, "BtnAddLine")
        Me.BtnAddLine.BackColor = System.Drawing.Color.LightGreen
        Me.BtnAddLine.Name = "BtnAddLine"
        Me.BtnAddLine.UseVisualStyleBackColor = False
        '
        'BtnQuit
        '
        resources.ApplyResources(Me.BtnQuit, "BtnQuit")
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        resources.ApplyResources(Me.BtnSave, "BtnSave")
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'GCGTPLOT
        '
        resources.ApplyResources(Me.GCGTPLOT, "GCGTPLOT")
        '
        '
        '
        Me.GCGTPLOT.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCGTPLOT.EmbeddedNavigator.AccessibleDescription")
        Me.GCGTPLOT.EmbeddedNavigator.AccessibleName = resources.GetString("GCGTPLOT.EmbeddedNavigator.AccessibleName")
        Me.GCGTPLOT.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCGTPLOT.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCGTPLOT.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCGTPLOT.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCGTPLOT.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCGTPLOT.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCGTPLOT.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCGTPLOT.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCGTPLOT.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCGTPLOT.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCGTPLOT.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCGTPLOT.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCGTPLOT.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCGTPLOT.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCGTPLOT.EmbeddedNavigator.ToolTip = resources.GetString("GCGTPLOT.EmbeddedNavigator.ToolTip")
        Me.GCGTPLOT.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCGTPLOT.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCGTPLOT.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCGTPLOT.EmbeddedNavigator.ToolTipTitle")
        Me.GCGTPLOT.MainView = Me.GVGTPLOT
        Me.GCGTPLOT.Name = "GCGTPLOT"
        Me.GCGTPLOT.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVGTPLOT})
        '
        'GVGTPLOT
        '
        Me.GVGTPLOT.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.ColumnFilterButton.BackColor2 = CType(resources.GetObject("GVGTPLOT.Appearance.ColumnFilterButton.BackColor2"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVGTPLOT.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVGTPLOT.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVGTPLOT.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVGTPLOT.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVGTPLOT.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.ColumnFilterButtonActive.BackColor2 = CType(resources.GetObject("GVGTPLOT.Appearance.ColumnFilterButtonActive.BackColor2"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVGTPLOT.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVGTPLOT.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVGTPLOT.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVGTPLOT.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVGTPLOT.Appearance.Empty.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.Empty.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.Empty.Image = CType(resources.GetObject("GVGTPLOT.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.Empty.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVGTPLOT.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.EvenRow.Image = CType(resources.GetObject("GVGTPLOT.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVGTPLOT.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.FilterCloseButton.BackColor2 = CType(resources.GetObject("GVGTPLOT.Appearance.FilterCloseButton.BackColor2"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVGTPLOT.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVGTPLOT.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVGTPLOT.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVGTPLOT.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.FilterPanel.Image = CType(resources.GetObject("GVGTPLOT.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVGTPLOT.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.FixedLine.Image = CType(resources.GetObject("GVGTPLOT.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVGTPLOT.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.FocusedRow.Image = CType(resources.GetObject("GVGTPLOT.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVGTPLOT.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.FooterPanel.BackColor2 = CType(resources.GetObject("GVGTPLOT.Appearance.FooterPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVGTPLOT.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.FooterPanel.Image = CType(resources.GetObject("GVGTPLOT.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVGTPLOT.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVGTPLOT.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.GroupButton.ForeColor = CType(resources.GetObject("GVGTPLOT.Appearance.GroupButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.GroupButton.Image = CType(resources.GetObject("GVGTPLOT.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVGTPLOT.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVGTPLOT.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVGTPLOT.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVGTPLOT.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.GroupFooter.Image = CType(resources.GetObject("GVGTPLOT.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVGTPLOT.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVGTPLOT.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVGTPLOT.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.GroupPanel.Image = CType(resources.GetObject("GVGTPLOT.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVGTPLOT.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVGTPLOT.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.GroupRow.Font = CType(resources.GetObject("GVGTPLOT.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.GVGTPLOT.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVGTPLOT.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.GroupRow.Image = CType(resources.GetObject("GVGTPLOT.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVGTPLOT.Appearance.GroupRow.Options.UseFont = True
        Me.GVGTPLOT.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVGTPLOT.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.HeaderPanel.BackColor2 = CType(resources.GetObject("GVGTPLOT.Appearance.HeaderPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVGTPLOT.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVGTPLOT.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVGTPLOT.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVGTPLOT.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVGTPLOT.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVGTPLOT.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVGTPLOT.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVGTPLOT.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVGTPLOT.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVGTPLOT.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVGTPLOT.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVGTPLOT.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVGTPLOT.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVGTPLOT.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.HorzLine.Image = CType(resources.GetObject("GVGTPLOT.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.OddRow.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVGTPLOT.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.OddRow.Image = CType(resources.GetObject("GVGTPLOT.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.OddRow.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.OddRow.Options.UseForeColor = True
        Me.GVGTPLOT.Appearance.Preview.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.Preview.ForeColor = CType(resources.GetObject("GVGTPLOT.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.Preview.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.Preview.Image = CType(resources.GetObject("GVGTPLOT.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.Preview.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.Preview.Options.UseForeColor = True
        Me.GVGTPLOT.Appearance.Row.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.Row.ForeColor = CType(resources.GetObject("GVGTPLOT.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.Row.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.Row.Image = CType(resources.GetObject("GVGTPLOT.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.Row.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.Row.Options.UseForeColor = True
        Me.GVGTPLOT.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.RowSeparator.Image = CType(resources.GetObject("GVGTPLOT.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVGTPLOT.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.SelectedRow.Image = CType(resources.GetObject("GVGTPLOT.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVGTPLOT.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVGTPLOT.Appearance.VertLine.BackColor = CType(resources.GetObject("GVGTPLOT.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVGTPLOT.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVGTPLOT.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVGTPLOT.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVGTPLOT.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLOT.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVGTPLOT.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLOT.Appearance.VertLine.Image = CType(resources.GetObject("GVGTPLOT.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVGTPLOT.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVGTPLOT, "GVGTPLOT")
        Me.GVGTPLOT.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIDTMP, Me.ColNGTPLOTID, Me.ColVGTPLOTNOM})
        Me.GVGTPLOT.GridControl = Me.GCGTPLOT
        Me.GVGTPLOT.Name = "GVGTPLOT"
        Me.GVGTPLOT.OptionsView.EnableAppearanceEvenRow = True
        Me.GVGTPLOT.OptionsView.EnableAppearanceOddRow = True
        Me.GVGTPLOT.OptionsView.ShowGroupPanel = False
        '
        'ColIDTMP
        '
        resources.ApplyResources(Me.ColIDTMP, "ColIDTMP")
        Me.ColIDTMP.FieldName = "IDTMP"
        Me.ColIDTMP.Name = "ColIDTMP"
        '
        'ColNGTPLOTID
        '
        resources.ApplyResources(Me.ColNGTPLOTID, "ColNGTPLOTID")
        Me.ColNGTPLOTID.FieldName = "NGTPLOTID"
        Me.ColNGTPLOTID.Name = "ColNGTPLOTID"
        '
        'ColVGTPLOTNOM
        '
        resources.ApplyResources(Me.ColVGTPLOTNOM, "ColVGTPLOTNOM")
        Me.ColVGTPLOTNOM.FieldName = "VGTPLOTNOM"
        Me.ColVGTPLOTNOM.Name = "ColVGTPLOTNOM"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'frmGTPLot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GCGTPLOT)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmGTPLot"
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCGTPLOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVGTPLOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSupprLine As System.Windows.Forms.Button
    Friend WithEvents BtnAddLine As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents GCGTPLOT As DevExpress.XtraGrid.GridControl
    Private WithEvents GVGTPLOT As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNGTPLOTID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVGTPLOTNOM As DevExpress.XtraGrid.Columns.GridColumn
End Class
