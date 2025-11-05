<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGTPZone
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGTPZone))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnSupprLine = New System.Windows.Forms.Button()
        Me.BtnAddLine = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GCGTPZONE = New DevExpress.XtraGrid.GridControl()
        Me.GVGTPZONE = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNGTPZONEID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVGTPZONENOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCGTPZONE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVGTPZONE, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GCGTPZONE
        '
        resources.ApplyResources(Me.GCGTPZONE, "GCGTPZONE")
        '
        '
        '
        Me.GCGTPZONE.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCGTPZONE.EmbeddedNavigator.AccessibleDescription")
        Me.GCGTPZONE.EmbeddedNavigator.AccessibleName = resources.GetString("GCGTPZONE.EmbeddedNavigator.AccessibleName")
        Me.GCGTPZONE.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCGTPZONE.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCGTPZONE.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCGTPZONE.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCGTPZONE.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCGTPZONE.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCGTPZONE.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCGTPZONE.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCGTPZONE.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCGTPZONE.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCGTPZONE.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCGTPZONE.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCGTPZONE.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCGTPZONE.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCGTPZONE.EmbeddedNavigator.ToolTip = resources.GetString("GCGTPZONE.EmbeddedNavigator.ToolTip")
        Me.GCGTPZONE.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCGTPZONE.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCGTPZONE.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCGTPZONE.EmbeddedNavigator.ToolTipTitle")
        Me.GCGTPZONE.MainView = Me.GVGTPZONE
        Me.GCGTPZONE.Name = "GCGTPZONE"
        Me.GCGTPZONE.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVGTPZONE})
        '
        'GVGTPZONE
        '
        Me.GVGTPZONE.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVGTPZONE.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVGTPZONE.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVGTPZONE.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVGTPZONE.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVGTPZONE.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVGTPZONE.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVGTPZONE.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVGTPZONE.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVGTPZONE.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVGTPZONE.Appearance.Empty.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVGTPZONE.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.Empty.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.Empty.Image = CType(resources.GetObject("GVGTPZONE.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.Empty.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVGTPZONE.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVGTPZONE.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.EvenRow.Image = CType(resources.GetObject("GVGTPZONE.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVGTPZONE.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVGTPZONE.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVGTPZONE.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVGTPZONE.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVGTPZONE.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVGTPZONE.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVGTPZONE.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVGTPZONE.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVGTPZONE.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.FilterPanel.Image = CType(resources.GetObject("GVGTPZONE.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVGTPZONE.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.FixedLine.Image = CType(resources.GetObject("GVGTPZONE.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVGTPZONE.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.FocusedCell.Image = CType(resources.GetObject("GVGTPZONE.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVGTPZONE.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVGTPZONE.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.FocusedRow.Image = CType(resources.GetObject("GVGTPZONE.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVGTPZONE.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVGTPZONE.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVGTPZONE.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.FooterPanel.Image = CType(resources.GetObject("GVGTPZONE.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVGTPZONE.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVGTPZONE.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVGTPZONE.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.GroupButton.Image = CType(resources.GetObject("GVGTPZONE.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVGTPZONE.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVGTPZONE.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVGTPZONE.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.GroupFooter.Image = CType(resources.GetObject("GVGTPZONE.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVGTPZONE.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVGTPZONE.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVGTPZONE.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVGTPZONE.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.GroupPanel.Image = CType(resources.GetObject("GVGTPZONE.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVGTPZONE.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVGTPZONE.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVGTPZONE.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.GroupRow.Image = CType(resources.GetObject("GVGTPZONE.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVGTPZONE.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVGTPZONE.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVGTPZONE.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVGTPZONE.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVGTPZONE.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVGTPZONE.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVGTPZONE.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVGTPZONE.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVGTPZONE.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVGTPZONE.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVGTPZONE.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVGTPZONE.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVGTPZONE.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVGTPZONE.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVGTPZONE.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVGTPZONE.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.HorzLine.BorderColor = CType(resources.GetObject("GVGTPZONE.Appearance.HorzLine.BorderColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.HorzLine.Image = CType(resources.GetObject("GVGTPZONE.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVGTPZONE.Appearance.OddRow.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVGTPZONE.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVGTPZONE.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.OddRow.Image = CType(resources.GetObject("GVGTPZONE.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.OddRow.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVGTPZONE.Appearance.OddRow.Options.UseForeColor = True
        Me.GVGTPZONE.Appearance.Preview.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.Preview.Font = CType(resources.GetObject("GVGTPZONE.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVGTPZONE.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.Preview.ForeColor = CType(resources.GetObject("GVGTPZONE.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.Preview.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.Preview.Image = CType(resources.GetObject("GVGTPZONE.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.Preview.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.Preview.Options.UseFont = True
        Me.GVGTPZONE.Appearance.Preview.Options.UseForeColor = True
        Me.GVGTPZONE.Appearance.Row.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.Row.ForeColor = CType(resources.GetObject("GVGTPZONE.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.Row.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.Row.Image = CType(resources.GetObject("GVGTPZONE.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.Row.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.Row.Options.UseForeColor = True
        Me.GVGTPZONE.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVGTPZONE.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.RowSeparator.Image = CType(resources.GetObject("GVGTPZONE.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVGTPZONE.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.SelectedRow.Image = CType(resources.GetObject("GVGTPZONE.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVGTPZONE.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.TopNewRow.Image = CType(resources.GetObject("GVGTPZONE.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.VertLine.BackColor = CType(resources.GetObject("GVGTPZONE.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.VertLine.BorderColor = CType(resources.GetObject("GVGTPZONE.Appearance.VertLine.BorderColor"), System.Drawing.Color)
        Me.GVGTPZONE.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVGTPZONE.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVGTPZONE.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVGTPZONE.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPZONE.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVGTPZONE.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPZONE.Appearance.VertLine.Image = CType(resources.GetObject("GVGTPZONE.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVGTPZONE.Appearance.VertLine.Options.UseBackColor = True
        Me.GVGTPZONE.Appearance.VertLine.Options.UseBorderColor = True
        resources.ApplyResources(Me.GVGTPZONE, "GVGTPZONE")
        Me.GVGTPZONE.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIDTMP, Me.ColNGTPZONEID, Me.ColVGTPZONENOM})
        Me.GVGTPZONE.GridControl = Me.GCGTPZONE
        Me.GVGTPZONE.Name = "GVGTPZONE"
        Me.GVGTPZONE.OptionsView.EnableAppearanceEvenRow = True
        Me.GVGTPZONE.OptionsView.EnableAppearanceOddRow = True
        Me.GVGTPZONE.OptionsView.ShowGroupPanel = False
        '
        'ColIDTMP
        '
        resources.ApplyResources(Me.ColIDTMP, "ColIDTMP")
        Me.ColIDTMP.FieldName = "IDTMP"
        Me.ColIDTMP.Name = "ColIDTMP"
        '
        'ColNGTPZONEID
        '
        resources.ApplyResources(Me.ColNGTPZONEID, "ColNGTPZONEID")
        Me.ColNGTPZONEID.FieldName = "NGTPZONEID"
        Me.ColNGTPZONEID.Name = "ColNGTPZONEID"
        '
        'ColVGTPZONENOM
        '
        resources.ApplyResources(Me.ColVGTPZONENOM, "ColVGTPZONENOM")
        Me.ColVGTPZONENOM.FieldName = "VGTPZONENOM"
        Me.ColVGTPZONENOM.Name = "ColVGTPZONENOM"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'frmGTPZone
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GCGTPZONE)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmGTPZone"
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCGTPZONE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVGTPZONE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSupprLine As System.Windows.Forms.Button
    Friend WithEvents BtnAddLine As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents GCGTPZONE As DevExpress.XtraGrid.GridControl
    Private WithEvents GVGTPZONE As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNGTPZONEID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVGTPZONENOM As DevExpress.XtraGrid.Columns.GridColumn
End Class
