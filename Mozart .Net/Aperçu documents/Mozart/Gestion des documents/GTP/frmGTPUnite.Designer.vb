<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGTPUnite
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGTPUnite))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnSupprLine = New System.Windows.Forms.Button()
        Me.BtnAddLine = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GCGTPUNITE = New DevExpress.XtraGrid.GridControl()
        Me.GVGTPUNITE = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNGTPUNITEID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVGTPUNITENOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCGTPUNITE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVGTPUNITE, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GCGTPUNITE
        '
        resources.ApplyResources(Me.GCGTPUNITE, "GCGTPUNITE")
        '
        '
        '
        Me.GCGTPUNITE.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCGTPUNITE.EmbeddedNavigator.AccessibleDescription")
        Me.GCGTPUNITE.EmbeddedNavigator.AccessibleName = resources.GetString("GCGTPUNITE.EmbeddedNavigator.AccessibleName")
        Me.GCGTPUNITE.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCGTPUNITE.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCGTPUNITE.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCGTPUNITE.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCGTPUNITE.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCGTPUNITE.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCGTPUNITE.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCGTPUNITE.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCGTPUNITE.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCGTPUNITE.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCGTPUNITE.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCGTPUNITE.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCGTPUNITE.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCGTPUNITE.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCGTPUNITE.EmbeddedNavigator.ToolTip = resources.GetString("GCGTPUNITE.EmbeddedNavigator.ToolTip")
        Me.GCGTPUNITE.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCGTPUNITE.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCGTPUNITE.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCGTPUNITE.EmbeddedNavigator.ToolTipTitle")
        Me.GCGTPUNITE.MainView = Me.GVGTPUNITE
        Me.GCGTPUNITE.Name = "GCGTPUNITE"
        Me.GCGTPUNITE.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVGTPUNITE})
        '
        'GVGTPUNITE
        '
        Me.GVGTPUNITE.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.ColumnFilterButton.BackColor2 = CType(resources.GetObject("GVGTPUNITE.Appearance.ColumnFilterButton.BackColor2"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVGTPUNITE.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVGTPUNITE.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVGTPUNITE.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVGTPUNITE.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.ColumnFilterButtonActive.BackColor2 = CType(resources.GetObject("GVGTPUNITE.Appearance.ColumnFilterButtonActive.BackColor2"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVGTPUNITE.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVGTPUNITE.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVGTPUNITE.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVGTPUNITE.Appearance.Empty.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.Empty.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.Empty.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.Empty.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVGTPUNITE.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.EvenRow.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVGTPUNITE.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.FilterCloseButton.BackColor2 = CType(resources.GetObject("GVGTPUNITE.Appearance.FilterCloseButton.BackColor2"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVGTPUNITE.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVGTPUNITE.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVGTPUNITE.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.FilterPanel.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVGTPUNITE.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.FixedLine.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVGTPUNITE.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.FocusedRow.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVGTPUNITE.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.FooterPanel.BackColor2 = CType(resources.GetObject("GVGTPUNITE.Appearance.FooterPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVGTPUNITE.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.FooterPanel.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVGTPUNITE.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.GroupButton.ForeColor = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.GroupButton.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVGTPUNITE.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVGTPUNITE.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.GroupFooter.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVGTPUNITE.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVGTPUNITE.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.GroupPanel.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVGTPUNITE.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.GroupRow.Font = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.GVGTPUNITE.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.GroupRow.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVGTPUNITE.Appearance.GroupRow.Options.UseFont = True
        Me.GVGTPUNITE.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVGTPUNITE.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.HeaderPanel.BackColor2 = CType(resources.GetObject("GVGTPUNITE.Appearance.HeaderPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVGTPUNITE.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVGTPUNITE.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVGTPUNITE.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVGTPUNITE.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVGTPUNITE.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVGTPUNITE.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVGTPUNITE.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVGTPUNITE.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVGTPUNITE.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVGTPUNITE.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVGTPUNITE.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVGTPUNITE.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.HorzLine.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.OddRow.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVGTPUNITE.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.OddRow.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.OddRow.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.OddRow.Options.UseForeColor = True
        Me.GVGTPUNITE.Appearance.Preview.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.Preview.ForeColor = CType(resources.GetObject("GVGTPUNITE.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.Preview.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.Preview.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.Preview.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.Preview.Options.UseForeColor = True
        Me.GVGTPUNITE.Appearance.Row.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.Row.ForeColor = CType(resources.GetObject("GVGTPUNITE.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.Row.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.Row.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.Row.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.Row.Options.UseForeColor = True
        Me.GVGTPUNITE.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.RowSeparator.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVGTPUNITE.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.SelectedRow.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVGTPUNITE.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVGTPUNITE.Appearance.VertLine.BackColor = CType(resources.GetObject("GVGTPUNITE.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVGTPUNITE.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVGTPUNITE.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVGTPUNITE.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPUNITE.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVGTPUNITE.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPUNITE.Appearance.VertLine.Image = CType(resources.GetObject("GVGTPUNITE.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVGTPUNITE.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVGTPUNITE, "GVGTPUNITE")
        Me.GVGTPUNITE.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIDTMP, Me.ColNGTPUNITEID, Me.ColVGTPUNITENOM})
        Me.GVGTPUNITE.GridControl = Me.GCGTPUNITE
        Me.GVGTPUNITE.Name = "GVGTPUNITE"
        Me.GVGTPUNITE.OptionsView.EnableAppearanceEvenRow = True
        Me.GVGTPUNITE.OptionsView.EnableAppearanceOddRow = True
        Me.GVGTPUNITE.OptionsView.ShowGroupPanel = False
        '
        'ColIDTMP
        '
        resources.ApplyResources(Me.ColIDTMP, "ColIDTMP")
        Me.ColIDTMP.FieldName = "IDTMP"
        Me.ColIDTMP.Name = "ColIDTMP"
        '
        'ColNGTPUNITEID
        '
        resources.ApplyResources(Me.ColNGTPUNITEID, "ColNGTPUNITEID")
        Me.ColNGTPUNITEID.FieldName = "NGTPUNTIEID"
        Me.ColNGTPUNITEID.Name = "ColNGTPUNITEID"
        '
        'ColVGTPUNITENOM
        '
        resources.ApplyResources(Me.ColVGTPUNITENOM, "ColVGTPUNITENOM")
        Me.ColVGTPUNITENOM.FieldName = "VGTPUNITENOM"
        Me.ColVGTPUNITENOM.Name = "ColVGTPUNITENOM"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'frmGTPUnite
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GCGTPUNITE)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmGTPUnite"
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCGTPUNITE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVGTPUNITE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSupprLine As System.Windows.Forms.Button
    Friend WithEvents BtnAddLine As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents GCGTPUNITE As DevExpress.XtraGrid.GridControl
    Private WithEvents GVGTPUNITE As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNGTPUNITEID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVGTPUNITENOM As DevExpress.XtraGrid.Columns.GridColumn
End Class
