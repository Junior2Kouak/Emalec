<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestCompteAnaAffectation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestCompteAnaAffectation))
        Me.GrpBoxPers = New System.Windows.Forms.GroupBox()
        Me.LblCANSelect = New System.Windows.Forms.Label()
        Me.GCPers = New DevExpress.XtraGrid.GridControl()
        Me.GVPers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColCHECK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEditCHECK = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GColNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVPERPRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSERLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCPERTYP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDecoche = New System.Windows.Forms.Button()
        Me.BtnCoche = New System.Windows.Forms.Button()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GrpBoxPers.SuspendLayout()
        CType(Me.GCPers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEditCHECK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpBoxPers
        '
        resources.ApplyResources(Me.GrpBoxPers, "GrpBoxPers")
        Me.GrpBoxPers.Controls.Add(Me.LblCANSelect)
        Me.GrpBoxPers.Controls.Add(Me.GCPers)
        Me.GrpBoxPers.Name = "GrpBoxPers"
        Me.GrpBoxPers.TabStop = False
        '
        'LblCANSelect
        '
        resources.ApplyResources(Me.LblCANSelect, "LblCANSelect")
        Me.LblCANSelect.BackColor = System.Drawing.Color.Yellow
        Me.LblCANSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCANSelect.Name = "LblCANSelect"
        '
        'GCPers
        '
        resources.ApplyResources(Me.GCPers, "GCPers")
        '
        '
        '
        Me.GCPers.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCPers.EmbeddedNavigator.AccessibleDescription")
        Me.GCPers.EmbeddedNavigator.AccessibleName = resources.GetString("GCPers.EmbeddedNavigator.AccessibleName")
        Me.GCPers.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCPers.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCPers.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCPers.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCPers.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCPers.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCPers.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCPers.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCPers.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCPers.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCPers.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCPers.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCPers.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCPers.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCPers.EmbeddedNavigator.ToolTip = resources.GetString("GCPers.EmbeddedNavigator.ToolTip")
        Me.GCPers.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCPers.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCPers.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCPers.EmbeddedNavigator.ToolTipTitle")
        Me.GCPers.MainView = Me.GVPers
        Me.GCPers.Name = "GCPers"
        Me.GCPers.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEditCHECK})
        Me.GCPers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPers})
        '
        'GVPers
        '
        Me.GVPers.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVPers.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVPers.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVPers.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVPers.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVPers.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVPers.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVPers.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVPers.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVPers.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVPers.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVPers.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVPers.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVPers.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVPers.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVPers.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVPers.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVPers.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVPers.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVPers.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVPers.Appearance.Empty.BackColor = CType(resources.GetObject("GVPers.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVPers.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVPers.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.Empty.GradientMode = CType(resources.GetObject("GVPers.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.Empty.Image = CType(resources.GetObject("GVPers.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.Empty.Options.UseBackColor = True
        Me.GVPers.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVPers.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVPers.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVPers.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVPers.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVPers.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVPers.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.EvenRow.Image = CType(resources.GetObject("GVPers.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVPers.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVPers.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVPers.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVPers.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVPers.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVPers.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVPers.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVPers.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVPers.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVPers.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVPers.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVPers.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVPers.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVPers.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVPers.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVPers.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVPers.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVPers.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVPers.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.FilterPanel.Image = CType(resources.GetObject("GVPers.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVPers.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVPers.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVPers.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVPers.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.FixedLine.Image = CType(resources.GetObject("GVPers.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVPers.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVPers.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVPers.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVPers.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVPers.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.FocusedCell.Image = CType(resources.GetObject("GVPers.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVPers.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVPers.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVPers.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVPers.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVPers.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVPers.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.FocusedRow.Image = CType(resources.GetObject("GVPers.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVPers.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVPers.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVPers.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVPers.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVPers.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVPers.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVPers.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVPers.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.FooterPanel.Image = CType(resources.GetObject("GVPers.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVPers.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVPers.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVPers.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVPers.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVPers.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVPers.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVPers.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.GroupButton.Image = CType(resources.GetObject("GVPers.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVPers.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVPers.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVPers.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVPers.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVPers.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVPers.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVPers.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVPers.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.GroupFooter.Image = CType(resources.GetObject("GVPers.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVPers.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVPers.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVPers.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVPers.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVPers.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVPers.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVPers.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVPers.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVPers.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.GroupPanel.Image = CType(resources.GetObject("GVPers.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVPers.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVPers.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVPers.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVPers.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVPers.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVPers.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVPers.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVPers.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.GroupRow.Image = CType(resources.GetObject("GVPers.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVPers.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVPers.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVPers.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVPers.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVPers.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVPers.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVPers.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVPers.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVPers.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVPers.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVPers.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVPers.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVPers.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVPers.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVPers.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVPers.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVPers.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVPers.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVPers.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVPers.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVPers.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVPers.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVPers.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVPers.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.HorzLine.BorderColor = CType(resources.GetObject("GVPers.Appearance.HorzLine.BorderColor"), System.Drawing.Color)
        Me.GVPers.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVPers.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.HorzLine.Image = CType(resources.GetObject("GVPers.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVPers.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVPers.Appearance.OddRow.BackColor = CType(resources.GetObject("GVPers.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVPers.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVPers.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVPers.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVPers.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVPers.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.OddRow.Image = CType(resources.GetObject("GVPers.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.OddRow.Options.UseBackColor = True
        Me.GVPers.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVPers.Appearance.OddRow.Options.UseForeColor = True
        Me.GVPers.Appearance.Preview.BackColor = CType(resources.GetObject("GVPers.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.Preview.Font = CType(resources.GetObject("GVPers.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVPers.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.Preview.ForeColor = CType(resources.GetObject("GVPers.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVPers.Appearance.Preview.GradientMode = CType(resources.GetObject("GVPers.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.Preview.Image = CType(resources.GetObject("GVPers.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.Preview.Options.UseBackColor = True
        Me.GVPers.Appearance.Preview.Options.UseFont = True
        Me.GVPers.Appearance.Preview.Options.UseForeColor = True
        Me.GVPers.Appearance.Row.BackColor = CType(resources.GetObject("GVPers.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.Row.Font = CType(resources.GetObject("GVPers.Appearance.Row.Font"), System.Drawing.Font)
        Me.GVPers.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.Row.ForeColor = CType(resources.GetObject("GVPers.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVPers.Appearance.Row.GradientMode = CType(resources.GetObject("GVPers.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.Row.Image = CType(resources.GetObject("GVPers.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.Row.Options.UseBackColor = True
        Me.GVPers.Appearance.Row.Options.UseFont = True
        Me.GVPers.Appearance.Row.Options.UseForeColor = True
        Me.GVPers.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVPers.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVPers.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVPers.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVPers.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.RowSeparator.Image = CType(resources.GetObject("GVPers.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVPers.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVPers.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVPers.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVPers.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVPers.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.SelectedRow.Image = CType(resources.GetObject("GVPers.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVPers.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVPers.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVPers.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVPers.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.TopNewRow.Image = CType(resources.GetObject("GVPers.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVPers.Appearance.VertLine.BackColor = CType(resources.GetObject("GVPers.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVPers.Appearance.VertLine.BorderColor = CType(resources.GetObject("GVPers.Appearance.VertLine.BorderColor"), System.Drawing.Color)
        Me.GVPers.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVPers.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVPers.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVPers.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVPers.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVPers.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVPers.Appearance.VertLine.Image = CType(resources.GetObject("GVPers.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVPers.Appearance.VertLine.Options.UseBackColor = True
        Me.GVPers.Appearance.VertLine.Options.UseBorderColor = True
        resources.ApplyResources(Me.GVPers, "GVPers")
        Me.GVPers.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCHECK, Me.GColNPERNUM, Me.GColVPERNOM, Me.GColVPERPRE, Me.GColVSERLIB, Me.GColCPERTYP})
        Me.GVPers.GridControl = Me.GCPers
        Me.GVPers.Name = "GVPers"
        Me.GVPers.OptionsView.EnableAppearanceEvenRow = True
        Me.GVPers.OptionsView.EnableAppearanceOddRow = True
        Me.GVPers.OptionsView.ShowAutoFilterRow = True
        Me.GVPers.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVPers.OptionsView.ShowFooter = True
        Me.GVPers.OptionsView.ShowGroupPanel = False
        '
        'GColCHECK
        '
        Me.GColCHECK.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColCHECK.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColCHECK.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColCHECK.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColCHECK.AppearanceHeader.GradientMode = CType(resources.GetObject("GColCHECK.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColCHECK.AppearanceHeader.Image = CType(resources.GetObject("GColCHECK.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColCHECK.AppearanceHeader.Options.UseTextOptions = True
        Me.GColCHECK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColCHECK, "GColCHECK")
        Me.GColCHECK.ColumnEdit = Me.RepositoryItemCheckEditCHECK
        Me.GColCHECK.FieldName = "CHECK"
        Me.GColCHECK.Name = "GColCHECK"
        '
        'RepositoryItemCheckEditCHECK
        '
        resources.ApplyResources(Me.RepositoryItemCheckEditCHECK, "RepositoryItemCheckEditCHECK")
        Me.RepositoryItemCheckEditCHECK.Name = "RepositoryItemCheckEditCHECK"
        Me.RepositoryItemCheckEditCHECK.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEditCHECK.ValueChecked = 1
        Me.RepositoryItemCheckEditCHECK.ValueUnchecked = 0
        '
        'GColNPERNUM
        '
        resources.ApplyResources(Me.GColNPERNUM, "GColNPERNUM")
        Me.GColNPERNUM.FieldName = "NPERNUM"
        Me.GColNPERNUM.Name = "GColNPERNUM"
        Me.GColNPERNUM.OptionsColumn.ReadOnly = True
        '
        'GColVPERNOM
        '
        Me.GColVPERNOM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColVPERNOM.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColVPERNOM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColVPERNOM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColVPERNOM.AppearanceHeader.GradientMode = CType(resources.GetObject("GColVPERNOM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVPERNOM.AppearanceHeader.Image = CType(resources.GetObject("GColVPERNOM.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColVPERNOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVPERNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVPERNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVPERNOM, "GColVPERNOM")
        Me.GColVPERNOM.FieldName = "VPERNOM"
        Me.GColVPERNOM.Name = "GColVPERNOM"
        Me.GColVPERNOM.OptionsColumn.AllowEdit = False
        Me.GColVPERNOM.OptionsColumn.ReadOnly = True
        Me.GColVPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVPERPRE
        '
        Me.GColVPERPRE.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColVPERPRE.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColVPERPRE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColVPERPRE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColVPERPRE.AppearanceHeader.GradientMode = CType(resources.GetObject("GColVPERPRE.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVPERPRE.AppearanceHeader.Image = CType(resources.GetObject("GColVPERPRE.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColVPERPRE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVPERPRE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVPERPRE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVPERPRE, "GColVPERPRE")
        Me.GColVPERPRE.FieldName = "VPERPRE"
        Me.GColVPERPRE.Name = "GColVPERPRE"
        Me.GColVPERPRE.OptionsColumn.AllowEdit = False
        Me.GColVPERPRE.OptionsColumn.ReadOnly = True
        Me.GColVPERPRE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVSERLIB
        '
        Me.GColVSERLIB.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColVSERLIB.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColVSERLIB.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColVSERLIB.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColVSERLIB.AppearanceHeader.GradientMode = CType(resources.GetObject("GColVSERLIB.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVSERLIB.AppearanceHeader.Image = CType(resources.GetObject("GColVSERLIB.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColVSERLIB.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVSERLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVSERLIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVSERLIB, "GColVSERLIB")
        Me.GColVSERLIB.FieldName = "VSERLIB"
        Me.GColVSERLIB.Name = "GColVSERLIB"
        Me.GColVSERLIB.OptionsColumn.AllowEdit = False
        Me.GColVSERLIB.OptionsColumn.ReadOnly = True
        Me.GColVSERLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColCPERTYP
        '
        Me.GColCPERTYP.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColCPERTYP.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColCPERTYP.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColCPERTYP.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColCPERTYP.AppearanceHeader.GradientMode = CType(resources.GetObject("GColCPERTYP.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColCPERTYP.AppearanceHeader.Image = CType(resources.GetObject("GColCPERTYP.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColCPERTYP.AppearanceHeader.Options.UseTextOptions = True
        Me.GColCPERTYP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCPERTYP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColCPERTYP, "GColCPERTYP")
        Me.GColCPERTYP.FieldName = "CPERTYP"
        Me.GColCPERTYP.Name = "GColCPERTYP"
        Me.GColCPERTYP.OptionsColumn.AllowEdit = False
        Me.GColCPERTYP.OptionsColumn.ReadOnly = True
        Me.GColCPERTYP.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'BtnDecoche
        '
        resources.ApplyResources(Me.BtnDecoche, "BtnDecoche")
        Me.BtnDecoche.Name = "BtnDecoche"
        Me.BtnDecoche.UseVisualStyleBackColor = True
        '
        'BtnCoche
        '
        resources.ApplyResources(Me.BtnCoche, "BtnCoche")
        Me.BtnCoche.Name = "BtnCoche"
        Me.BtnCoche.UseVisualStyleBackColor = True
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Controls.Add(Me.BtnCoche)
        Me.GrpActions.Controls.Add(Me.BtnDecoche)
        Me.GrpActions.Controls.Add(Me.BtnSave)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
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
        'frmGestCompteAnaAffectation
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GrpBoxPers)
        Me.Name = "frmGestCompteAnaAffectation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpBoxPers.ResumeLayout(False)
        CType(Me.GCPers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEditCHECK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpBoxPers As System.Windows.Forms.GroupBox
    Friend WithEvents LblCANSelect As System.Windows.Forms.Label
    Friend WithEvents BtnDecoche As System.Windows.Forms.Button
    Friend WithEvents BtnCoche As System.Windows.Forms.Button
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Private WithEvents GCPers As DevExpress.XtraGrid.GridControl
    Private WithEvents GVPers As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColCHECK As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepositoryItemCheckEditCHECK As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents GColNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVPERPRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVSERLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCPERTYP As DevExpress.XtraGrid.Columns.GridColumn
End Class
