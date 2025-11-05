<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQCMAffectPers
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQCMAffectPers))
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.BtnQuit = New System.Windows.Forms.Button()
    Me.BtnSave = New System.Windows.Forms.Button()
    Me.GrpBoxListQCM = New System.Windows.Forms.GroupBox()
    Me.GCListQCM = New DevExpress.XtraGrid.GridControl()
    Me.GVListQCM = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GColNIDQCMNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVQCMTITRE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVQCMTYPELIB = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColDQCMCREE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColNQCMTYPEID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GrpBoxPers = New System.Windows.Forms.GroupBox()
    Me.LblQCMSelect = New System.Windows.Forms.Label()
    Me.BtnDecoche = New System.Windows.Forms.Button()
    Me.BtnCoche = New System.Windows.Forms.Button()
    Me.GCPers = New DevExpress.XtraGrid.GridControl()
    Me.GVPers = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GColCHECK = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemCheckEditCHECK = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.GColNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVPERPRE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVSERLIB = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColCPERTYP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GrpActions.SuspendLayout()
    Me.GrpBoxListQCM.SuspendLayout()
    CType(Me.GCListQCM, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GVListQCM, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GrpBoxPers.SuspendLayout()
    CType(Me.GCPers, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GVPers, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEditCHECK, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GrpActions
    '
    resources.ApplyResources(Me.GrpActions, "GrpActions")
    Me.GrpActions.Controls.Add(Me.BtnQuit)
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
    'GrpBoxListQCM
    '
    resources.ApplyResources(Me.GrpBoxListQCM, "GrpBoxListQCM")
    Me.GrpBoxListQCM.Controls.Add(Me.GCListQCM)
    Me.GrpBoxListQCM.Name = "GrpBoxListQCM"
    Me.GrpBoxListQCM.TabStop = False
    '
    'GCListQCM
    '
    resources.ApplyResources(Me.GCListQCM, "GCListQCM")
    Me.GCListQCM.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCListQCM.EmbeddedNavigator.AccessibleDescription")
    Me.GCListQCM.EmbeddedNavigator.AccessibleName = resources.GetString("GCListQCM.EmbeddedNavigator.AccessibleName")
    Me.GCListQCM.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCListQCM.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
    Me.GCListQCM.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCListQCM.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
    Me.GCListQCM.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCListQCM.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
    Me.GCListQCM.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCListQCM.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
    Me.GCListQCM.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCListQCM.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
    Me.GCListQCM.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCListQCM.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
    Me.GCListQCM.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCListQCM.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
    Me.GCListQCM.EmbeddedNavigator.ToolTip = resources.GetString("GCListQCM.EmbeddedNavigator.ToolTip")
    Me.GCListQCM.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCListQCM.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
    Me.GCListQCM.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCListQCM.EmbeddedNavigator.ToolTipTitle")
    Me.GCListQCM.MainView = Me.GVListQCM
    Me.GCListQCM.Name = "GCListQCM"
    Me.GCListQCM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListQCM})
    '
    'GVListQCM
    '
    Me.GVListQCM.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVListQCM.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVListQCM.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVListQCM.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVListQCM.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.ColumnFilterButton.Options.UseBackColor = True
    Me.GVListQCM.Appearance.ColumnFilterButton.Options.UseBorderColor = True
    Me.GVListQCM.Appearance.ColumnFilterButton.Options.UseForeColor = True
    Me.GVListQCM.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVListQCM.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVListQCM.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVListQCM.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVListQCM.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
    Me.GVListQCM.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
    Me.GVListQCM.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
    Me.GVListQCM.Appearance.Empty.BackColor = CType(resources.GetObject("GVListQCM.Appearance.Empty.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVListQCM.Appearance.Empty.BackColor2"), System.Drawing.Color)
    Me.GVListQCM.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.Empty.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.Empty.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.Empty.Image = CType(resources.GetObject("GVListQCM.Appearance.Empty.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.Empty.Options.UseBackColor = True
    Me.GVListQCM.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVListQCM.Appearance.EvenRow.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVListQCM.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.EvenRow.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVListQCM.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.EvenRow.Image = CType(resources.GetObject("GVListQCM.Appearance.EvenRow.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.EvenRow.Options.UseBackColor = True
    Me.GVListQCM.Appearance.EvenRow.Options.UseBorderColor = True
    Me.GVListQCM.Appearance.EvenRow.Options.UseForeColor = True
    Me.GVListQCM.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVListQCM.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVListQCM.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVListQCM.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVListQCM.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.FilterCloseButton.Options.UseBackColor = True
    Me.GVListQCM.Appearance.FilterCloseButton.Options.UseBorderColor = True
    Me.GVListQCM.Appearance.FilterCloseButton.Options.UseForeColor = True
    Me.GVListQCM.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVListQCM.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVListQCM.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
    Me.GVListQCM.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.FilterPanel.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVListQCM.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.FilterPanel.Image = CType(resources.GetObject("GVListQCM.Appearance.FilterPanel.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.FilterPanel.Options.UseBackColor = True
    Me.GVListQCM.Appearance.FilterPanel.Options.UseForeColor = True
    Me.GVListQCM.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVListQCM.Appearance.FixedLine.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.FixedLine.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.FixedLine.Image = CType(resources.GetObject("GVListQCM.Appearance.FixedLine.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.FixedLine.Options.UseBackColor = True
    Me.GVListQCM.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVListQCM.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.FocusedCell.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVListQCM.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.FocusedCell.Image = CType(resources.GetObject("GVListQCM.Appearance.FocusedCell.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.FocusedCell.Options.UseBackColor = True
    Me.GVListQCM.Appearance.FocusedCell.Options.UseForeColor = True
    Me.GVListQCM.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVListQCM.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.FocusedRow.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVListQCM.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.FocusedRow.Image = CType(resources.GetObject("GVListQCM.Appearance.FocusedRow.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.FocusedRow.Options.UseBackColor = True
    Me.GVListQCM.Appearance.FocusedRow.Options.UseForeColor = True
    Me.GVListQCM.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVListQCM.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVListQCM.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.FooterPanel.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVListQCM.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.FooterPanel.Image = CType(resources.GetObject("GVListQCM.Appearance.FooterPanel.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.FooterPanel.Options.UseBackColor = True
    Me.GVListQCM.Appearance.FooterPanel.Options.UseBorderColor = True
    Me.GVListQCM.Appearance.FooterPanel.Options.UseForeColor = True
    Me.GVListQCM.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVListQCM.Appearance.GroupButton.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVListQCM.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.GroupButton.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.GroupButton.Image = CType(resources.GetObject("GVListQCM.Appearance.GroupButton.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.GroupButton.Options.UseBackColor = True
    Me.GVListQCM.Appearance.GroupButton.Options.UseBorderColor = True
    Me.GVListQCM.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVListQCM.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVListQCM.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.GroupFooter.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVListQCM.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.GroupFooter.Image = CType(resources.GetObject("GVListQCM.Appearance.GroupFooter.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.GroupFooter.Options.UseBackColor = True
    Me.GVListQCM.Appearance.GroupFooter.Options.UseBorderColor = True
    Me.GVListQCM.Appearance.GroupFooter.Options.UseForeColor = True
    Me.GVListQCM.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVListQCM.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVListQCM.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
    Me.GVListQCM.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.GroupPanel.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVListQCM.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.GroupPanel.Image = CType(resources.GetObject("GVListQCM.Appearance.GroupPanel.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.GroupPanel.Options.UseBackColor = True
    Me.GVListQCM.Appearance.GroupPanel.Options.UseForeColor = True
    Me.GVListQCM.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVListQCM.Appearance.GroupRow.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVListQCM.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.GroupRow.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVListQCM.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.GroupRow.Image = CType(resources.GetObject("GVListQCM.Appearance.GroupRow.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.GroupRow.Options.UseBackColor = True
    Me.GVListQCM.Appearance.GroupRow.Options.UseBorderColor = True
    Me.GVListQCM.Appearance.GroupRow.Options.UseForeColor = True
    Me.GVListQCM.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVListQCM.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVListQCM.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVListQCM.Appearance.HeaderPanel.Font"), System.Drawing.Font)
    Me.GVListQCM.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.HeaderPanel.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVListQCM.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVListQCM.Appearance.HeaderPanel.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.HeaderPanel.Options.UseBackColor = True
    Me.GVListQCM.Appearance.HeaderPanel.Options.UseBorderColor = True
    Me.GVListQCM.Appearance.HeaderPanel.Options.UseFont = True
    Me.GVListQCM.Appearance.HeaderPanel.Options.UseForeColor = True
    Me.GVListQCM.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVListQCM.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVListQCM.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVListQCM.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.HideSelectionRow.Options.UseBackColor = True
    Me.GVListQCM.Appearance.HideSelectionRow.Options.UseForeColor = True
    Me.GVListQCM.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVListQCM.Appearance.HorzLine.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.HorzLine.BorderColor = CType(resources.GetObject("GVListQCM.Appearance.HorzLine.BorderColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.HorzLine.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.HorzLine.Image = CType(resources.GetObject("GVListQCM.Appearance.HorzLine.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.HorzLine.Options.UseBackColor = True
    Me.GVListQCM.Appearance.HorzLine.Options.UseBorderColor = True
    Me.GVListQCM.Appearance.OddRow.BackColor = CType(resources.GetObject("GVListQCM.Appearance.OddRow.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVListQCM.Appearance.OddRow.BorderColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.OddRow.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVListQCM.Appearance.OddRow.ForeColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.OddRow.Image = CType(resources.GetObject("GVListQCM.Appearance.OddRow.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.OddRow.Options.UseBackColor = True
    Me.GVListQCM.Appearance.OddRow.Options.UseBorderColor = True
    Me.GVListQCM.Appearance.OddRow.Options.UseForeColor = True
    Me.GVListQCM.Appearance.Preview.BackColor = CType(resources.GetObject("GVListQCM.Appearance.Preview.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.Preview.Font = CType(resources.GetObject("GVListQCM.Appearance.Preview.Font"), System.Drawing.Font)
    Me.GVListQCM.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.Preview.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.Preview.ForeColor = CType(resources.GetObject("GVListQCM.Appearance.Preview.ForeColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.Preview.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.Preview.Image = CType(resources.GetObject("GVListQCM.Appearance.Preview.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.Preview.Options.UseBackColor = True
    Me.GVListQCM.Appearance.Preview.Options.UseFont = True
    Me.GVListQCM.Appearance.Preview.Options.UseForeColor = True
    Me.GVListQCM.Appearance.Row.BackColor = CType(resources.GetObject("GVListQCM.Appearance.Row.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.Row.Font = CType(resources.GetObject("GVListQCM.Appearance.Row.Font"), System.Drawing.Font)
    Me.GVListQCM.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.Row.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.Row.ForeColor = CType(resources.GetObject("GVListQCM.Appearance.Row.ForeColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.Row.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.Row.Image = CType(resources.GetObject("GVListQCM.Appearance.Row.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.Row.Options.UseBackColor = True
    Me.GVListQCM.Appearance.Row.Options.UseFont = True
    Me.GVListQCM.Appearance.Row.Options.UseForeColor = True
    Me.GVListQCM.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVListQCM.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVListQCM.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
    Me.GVListQCM.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.RowSeparator.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.RowSeparator.Image = CType(resources.GetObject("GVListQCM.Appearance.RowSeparator.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.RowSeparator.Options.UseBackColor = True
    Me.GVListQCM.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVListQCM.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.SelectedRow.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVListQCM.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.SelectedRow.Image = CType(resources.GetObject("GVListQCM.Appearance.SelectedRow.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.SelectedRow.Options.UseBackColor = True
    Me.GVListQCM.Appearance.SelectedRow.Options.UseForeColor = True
    Me.GVListQCM.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVListQCM.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.TopNewRow.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.TopNewRow.Image = CType(resources.GetObject("GVListQCM.Appearance.TopNewRow.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.TopNewRow.Options.UseBackColor = True
    Me.GVListQCM.Appearance.VertLine.BackColor = CType(resources.GetObject("GVListQCM.Appearance.VertLine.BackColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.VertLine.BorderColor = CType(resources.GetObject("GVListQCM.Appearance.VertLine.BorderColor"), System.Drawing.Color)
    Me.GVListQCM.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVListQCM.Appearance.VertLine.FontSizeDelta"), Integer)
    Me.GVListQCM.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVListQCM.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVListQCM.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVListQCM.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVListQCM.Appearance.VertLine.Image = CType(resources.GetObject("GVListQCM.Appearance.VertLine.Image"), System.Drawing.Image)
    Me.GVListQCM.Appearance.VertLine.Options.UseBackColor = True
    Me.GVListQCM.Appearance.VertLine.Options.UseBorderColor = True
    resources.ApplyResources(Me.GVListQCM, "GVListQCM")
    Me.GVListQCM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNIDQCMNUM, Me.GColVQCMTITRE, Me.GColVQCMTYPELIB, Me.GColDQCMCREE, Me.GColNQCMTYPEID})
    Me.GVListQCM.GridControl = Me.GCListQCM
    Me.GVListQCM.Name = "GVListQCM"
    Me.GVListQCM.OptionsBehavior.Editable = False
    Me.GVListQCM.OptionsBehavior.ReadOnly = True
    Me.GVListQCM.OptionsView.EnableAppearanceEvenRow = True
    Me.GVListQCM.OptionsView.EnableAppearanceOddRow = True
    Me.GVListQCM.OptionsView.ShowAutoFilterRow = True
    Me.GVListQCM.OptionsView.ShowGroupPanel = False
    '
    'GColNIDQCMNUM
    '
    resources.ApplyResources(Me.GColNIDQCMNUM, "GColNIDQCMNUM")
    Me.GColNIDQCMNUM.FieldName = "NIDQCMNUM"
    Me.GColNIDQCMNUM.Name = "GColNIDQCMNUM"
    '
    'GColVQCMTITRE
    '
    resources.ApplyResources(Me.GColVQCMTITRE, "GColVQCMTITRE")
    Me.GColVQCMTITRE.FieldName = "VQCMTITRE"
    Me.GColVQCMTITRE.Name = "GColVQCMTITRE"
    Me.GColVQCMTITRE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GColVQCMTYPELIB
    '
    resources.ApplyResources(Me.GColVQCMTYPELIB, "GColVQCMTYPELIB")
    Me.GColVQCMTYPELIB.FieldName = "VQCMTYPELIB"
    Me.GColVQCMTYPELIB.Name = "GColVQCMTYPELIB"
    Me.GColVQCMTYPELIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GColDQCMCREE
    '
    resources.ApplyResources(Me.GColDQCMCREE, "GColDQCMCREE")
    Me.GColDQCMCREE.FieldName = "DQCMCREE"
    Me.GColDQCMCREE.Name = "GColDQCMCREE"
    Me.GColDQCMCREE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GColNQCMTYPEID
    '
    resources.ApplyResources(Me.GColNQCMTYPEID, "GColNQCMTYPEID")
    Me.GColNQCMTYPEID.FieldName = "NQCMTYPEID"
    Me.GColNQCMTYPEID.Name = "GColNQCMTYPEID"
    '
    'GrpBoxPers
    '
    resources.ApplyResources(Me.GrpBoxPers, "GrpBoxPers")
    Me.GrpBoxPers.Controls.Add(Me.LblQCMSelect)
    Me.GrpBoxPers.Controls.Add(Me.BtnDecoche)
    Me.GrpBoxPers.Controls.Add(Me.BtnCoche)
    Me.GrpBoxPers.Controls.Add(Me.GCPers)
    Me.GrpBoxPers.Name = "GrpBoxPers"
    Me.GrpBoxPers.TabStop = False
    '
    'LblQCMSelect
    '
    resources.ApplyResources(Me.LblQCMSelect, "LblQCMSelect")
    Me.LblQCMSelect.BackColor = System.Drawing.Color.Yellow
    Me.LblQCMSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LblQCMSelect.Name = "LblQCMSelect"
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
    'GCPers
    '
    resources.ApplyResources(Me.GCPers, "GCPers")
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
    resources.ApplyResources(Me.GColVPERNOM, "GColVPERNOM")
    Me.GColVPERNOM.FieldName = "VPERNOM"
    Me.GColVPERNOM.Name = "GColVPERNOM"
    Me.GColVPERNOM.OptionsColumn.AllowEdit = False
    Me.GColVPERNOM.OptionsColumn.ReadOnly = True
    Me.GColVPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GColVPERPRE
    '
    resources.ApplyResources(Me.GColVPERPRE, "GColVPERPRE")
    Me.GColVPERPRE.FieldName = "VPERPRE"
    Me.GColVPERPRE.Name = "GColVPERPRE"
    Me.GColVPERPRE.OptionsColumn.AllowEdit = False
    Me.GColVPERPRE.OptionsColumn.ReadOnly = True
    Me.GColVPERPRE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GColVSERLIB
    '
    resources.ApplyResources(Me.GColVSERLIB, "GColVSERLIB")
    Me.GColVSERLIB.FieldName = "VSERLIB"
    Me.GColVSERLIB.Name = "GColVSERLIB"
    Me.GColVSERLIB.OptionsColumn.AllowEdit = False
    Me.GColVSERLIB.OptionsColumn.ReadOnly = True
    Me.GColVSERLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GColCPERTYP
    '
    resources.ApplyResources(Me.GColCPERTYP, "GColCPERTYP")
    Me.GColCPERTYP.FieldName = "CPERTYP"
    Me.GColCPERTYP.Name = "GColCPERTYP"
    Me.GColCPERTYP.OptionsColumn.AllowEdit = False
    Me.GColCPERTYP.OptionsColumn.ReadOnly = True
    Me.GColCPERTYP.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'frmQCMAffectPers
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.Controls.Add(Me.GrpBoxPers)
    Me.Controls.Add(Me.GrpBoxListQCM)
    Me.Controls.Add(Me.GrpActions)
    Me.Name = "frmQCMAffectPers"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.GrpActions.ResumeLayout(False)
    Me.GrpBoxListQCM.ResumeLayout(False)
    CType(Me.GCListQCM, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GVListQCM, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GrpBoxPers.ResumeLayout(False)
    CType(Me.GCPers, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GVPers, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEditCHECK, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents GrpBoxListQCM As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBoxPers As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDecoche As System.Windows.Forms.Button
    Friend WithEvents BtnCoche As System.Windows.Forms.Button
    Friend WithEvents LblQCMSelect As System.Windows.Forms.Label
    Private WithEvents GCListQCM As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListQCM As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNIDQCMNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVQCMTITRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVQCMTYPELIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDQCMCREE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNQCMTYPEID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCPers As DevExpress.XtraGrid.GridControl
    Private WithEvents GVPers As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVPERPRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVSERLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCPERTYP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCHECK As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepositoryItemCheckEditCHECK As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
