<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGTPGestClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGTPGestClient))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnSupprLine = New System.Windows.Forms.Button()
        Me.BtnAddLine = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GCGTPGESTCLI = New DevExpress.XtraGrid.GridControl()
        Me.GVGTPGESTCLI = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCGTPGESTCLI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVGTPGESTCLI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnModifier)
        Me.GrpActions.Controls.Add(Me.BtnSupprLine)
        Me.GrpActions.Controls.Add(Me.BtnAddLine)
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Controls.Add(Me.BtnSave)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnModifier
        '
        resources.ApplyResources(Me.BtnModifier, "BtnModifier")
        Me.BtnModifier.BackColor = System.Drawing.Color.LightGreen
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.UseVisualStyleBackColor = False
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
        'GCGTPGESTCLI
        '
        resources.ApplyResources(Me.GCGTPGESTCLI, "GCGTPGESTCLI")
        '
        '
        '
        Me.GCGTPGESTCLI.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCGTPGESTCLI.EmbeddedNavigator.AccessibleDescription")
        Me.GCGTPGESTCLI.EmbeddedNavigator.AccessibleName = resources.GetString("GCGTPGESTCLI.EmbeddedNavigator.AccessibleName")
        Me.GCGTPGESTCLI.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCGTPGESTCLI.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCGTPGESTCLI.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCGTPGESTCLI.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCGTPGESTCLI.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCGTPGESTCLI.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCGTPGESTCLI.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCGTPGESTCLI.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCGTPGESTCLI.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCGTPGESTCLI.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCGTPGESTCLI.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCGTPGESTCLI.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCGTPGESTCLI.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCGTPGESTCLI.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCGTPGESTCLI.EmbeddedNavigator.ToolTip = resources.GetString("GCGTPGESTCLI.EmbeddedNavigator.ToolTip")
        Me.GCGTPGESTCLI.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCGTPGESTCLI.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCGTPGESTCLI.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCGTPGESTCLI.EmbeddedNavigator.ToolTipTitle")
        Me.GCGTPGESTCLI.MainView = Me.GVGTPGESTCLI
        Me.GCGTPGESTCLI.Name = "GCGTPGESTCLI"
        Me.GCGTPGESTCLI.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVGTPGESTCLI})
        '
        'GVGTPGESTCLI
        '
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVGTPGESTCLI.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVGTPGESTCLI.Appearance.Empty.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.Empty.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.Empty.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.Empty.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.EvenRow.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVGTPGESTCLI.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVGTPGESTCLI.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVGTPGESTCLI.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVGTPGESTCLI.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.FilterPanel.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVGTPGESTCLI.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.FixedLine.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.FocusedCell.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVGTPGESTCLI.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.FocusedRow.BorderColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FocusedRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.FocusedRow.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVGTPGESTCLI.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVGTPGESTCLI.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.FooterPanel.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVGTPGESTCLI.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVGTPGESTCLI.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.GroupButton.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVGTPGESTCLI.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.GroupFooter.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVGTPGESTCLI.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVGTPGESTCLI.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.GroupPanel.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVGTPGESTCLI.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.GroupRow.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVGTPGESTCLI.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVGTPGESTCLI.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVGTPGESTCLI.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVGTPGESTCLI.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVGTPGESTCLI.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVGTPGESTCLI.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVGTPGESTCLI.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVGTPGESTCLI.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVGTPGESTCLI.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVGTPGESTCLI.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.HideSelectionRow.BorderColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HideSelectionRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVGTPGESTCLI.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVGTPGESTCLI.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.HorzLine.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.OddRow.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.OddRow.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.OddRow.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVGTPGESTCLI.Appearance.OddRow.Options.UseForeColor = True
        Me.GVGTPGESTCLI.Appearance.Preview.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.Preview.Font = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVGTPGESTCLI.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.Preview.ForeColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.Preview.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.Preview.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.Preview.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.Preview.Options.UseFont = True
        Me.GVGTPGESTCLI.Appearance.Preview.Options.UseForeColor = True
        Me.GVGTPGESTCLI.Appearance.Row.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.Row.ForeColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.Row.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.Row.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.Row.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.Row.Options.UseForeColor = True
        Me.GVGTPGESTCLI.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVGTPGESTCLI.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.RowSeparator.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.SelectedRow.BorderColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.SelectedRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.SelectedRow.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GVGTPGESTCLI.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVGTPGESTCLI.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.TopNewRow.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVGTPGESTCLI.Appearance.VertLine.BackColor = CType(resources.GetObject("GVGTPGESTCLI.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTCLI.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVGTPGESTCLI.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVGTPGESTCLI.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPGESTCLI.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVGTPGESTCLI.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPGESTCLI.Appearance.VertLine.Image = CType(resources.GetObject("GVGTPGESTCLI.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVGTPGESTCLI.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVGTPGESTCLI, "GVGTPGESTCLI")
        Me.GVGTPGESTCLI.ColumnPanelRowHeight = 60
        Me.GVGTPGESTCLI.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIDTMP, Me.ColNCLINUM, Me.ColVCLINOM})
        Me.GVGTPGESTCLI.GridControl = Me.GCGTPGESTCLI
        Me.GVGTPGESTCLI.Name = "GVGTPGESTCLI"
        Me.GVGTPGESTCLI.OptionsBehavior.Editable = False
        Me.GVGTPGESTCLI.OptionsBehavior.ReadOnly = True
        Me.GVGTPGESTCLI.OptionsNavigation.AutoFocusNewRow = True
        Me.GVGTPGESTCLI.OptionsView.EnableAppearanceEvenRow = True
        Me.GVGTPGESTCLI.OptionsView.EnableAppearanceOddRow = True
        Me.GVGTPGESTCLI.OptionsView.ShowAutoFilterRow = True
        Me.GVGTPGESTCLI.OptionsView.ShowFooter = True
        Me.GVGTPGESTCLI.OptionsView.ShowGroupPanel = False
        Me.GVGTPGESTCLI.RowHeight = 20
        '
        'ColIDTMP
        '
        resources.ApplyResources(Me.ColIDTMP, "ColIDTMP")
        Me.ColIDTMP.FieldName = "IDTMP"
        Me.ColIDTMP.Name = "ColIDTMP"
        '
        'ColNCLINUM
        '
        resources.ApplyResources(Me.ColNCLINUM, "ColNCLINUM")
        Me.ColNCLINUM.FieldName = "NCLINUM"
        Me.ColNCLINUM.Name = "ColNCLINUM"
        '
        'ColVCLINOM
        '
        resources.ApplyResources(Me.ColVCLINOM, "ColVCLINOM")
        Me.ColVCLINOM.FieldName = "VCLINOM"
        Me.ColVCLINOM.Name = "ColVCLINOM"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'frmGTPGestClient
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GCGTPGESTCLI)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmGTPGestClient"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCGTPGESTCLI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVGTPGESTCLI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSupprLine As System.Windows.Forms.Button
    Friend WithEvents BtnAddLine As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnModifier As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents GCGTPGESTCLI As DevExpress.XtraGrid.GridControl
    Private WithEvents GVGTPGESTCLI As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
End Class
