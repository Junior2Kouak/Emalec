<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGTPSite
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGTPSite))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnSupprLine = New System.Windows.Forms.Button()
        Me.BtnAddLine = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GrpSite = New System.Windows.Forms.GroupBox()
        Me.GCGTPSIT = New DevExpress.XtraGrid.GridControl()
        Me.GVGTPSIT = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColSitIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitNSITNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitNGTPMAINID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitVGTPLOTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitVGTPPRECIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitNGTPZONEID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLUpEditZone = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepItemGLUpEditViewZone = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColViewNGTPZONEID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColViewVGTPZONENOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitVGTPUNITENOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitVGTPEQUIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitNGTPSITINSTANNEE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitNGTPSITQTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitVGTPSITOBS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpClient = New System.Windows.Forms.GroupBox()
        Me.BtnSelectAll = New System.Windows.Forms.Button()
        Me.GCGTPClient = New DevExpress.XtraGrid.GridControl()
        Me.GVGTPClient = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColCliNGTPCLIID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliNCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliNGTPMAINID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliVGTPLOTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliVGTPEQUIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliVGTPPRECIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliNGTPDURVIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliVGTPUNITENOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliNGTPCOUTUNIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        Me.GrpSite.SuspendLayout()
        CType(Me.GCGTPSIT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVGTPSIT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditZone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditViewZone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpClient.SuspendLayout()
        CType(Me.GCGTPClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVGTPClient, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GrpSite
        '
        resources.ApplyResources(Me.GrpSite, "GrpSite")
        Me.GrpSite.Controls.Add(Me.GCGTPSIT)
        Me.GrpSite.Name = "GrpSite"
        Me.GrpSite.TabStop = False
        '
        'GCGTPSIT
        '
        resources.ApplyResources(Me.GCGTPSIT, "GCGTPSIT")
        '
        '
        '
        Me.GCGTPSIT.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCGTPSIT.EmbeddedNavigator.AccessibleDescription")
        Me.GCGTPSIT.EmbeddedNavigator.AccessibleName = resources.GetString("GCGTPSIT.EmbeddedNavigator.AccessibleName")
        Me.GCGTPSIT.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCGTPSIT.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCGTPSIT.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCGTPSIT.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCGTPSIT.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCGTPSIT.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCGTPSIT.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCGTPSIT.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCGTPSIT.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCGTPSIT.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCGTPSIT.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCGTPSIT.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCGTPSIT.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCGTPSIT.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCGTPSIT.EmbeddedNavigator.ToolTip = resources.GetString("GCGTPSIT.EmbeddedNavigator.ToolTip")
        Me.GCGTPSIT.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCGTPSIT.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCGTPSIT.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCGTPSIT.EmbeddedNavigator.ToolTipTitle")
        Me.GCGTPSIT.MainView = Me.GVGTPSIT
        Me.GCGTPSIT.Name = "GCGTPSIT"
        Me.GCGTPSIT.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemGLUpEditZone})
        Me.GCGTPSIT.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVGTPSIT})
        '
        'GVGTPSIT
        '
        Me.GVGTPSIT.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVGTPSIT.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVGTPSIT.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVGTPSIT.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVGTPSIT.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVGTPSIT.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVGTPSIT.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVGTPSIT.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVGTPSIT.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVGTPSIT.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVGTPSIT.Appearance.Empty.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVGTPSIT.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.Empty.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.Empty.Image = CType(resources.GetObject("GVGTPSIT.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.Empty.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVGTPSIT.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVGTPSIT.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.EvenRow.Image = CType(resources.GetObject("GVGTPSIT.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVGTPSIT.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVGTPSIT.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVGTPSIT.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVGTPSIT.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVGTPSIT.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVGTPSIT.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVGTPSIT.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVGTPSIT.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVGTPSIT.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.FilterPanel.Image = CType(resources.GetObject("GVGTPSIT.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVGTPSIT.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVGTPSIT.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.FocusedCell.Image = CType(resources.GetObject("GVGTPSIT.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVGTPSIT.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVGTPSIT.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.FocusedRow.Image = CType(resources.GetObject("GVGTPSIT.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVGTPSIT.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVGTPSIT.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVGTPSIT.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.FooterPanel.Image = CType(resources.GetObject("GVGTPSIT.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVGTPSIT.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVGTPSIT.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVGTPSIT.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.GroupButton.Image = CType(resources.GetObject("GVGTPSIT.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVGTPSIT.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVGTPSIT.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVGTPSIT.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.GroupFooter.Image = CType(resources.GetObject("GVGTPSIT.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVGTPSIT.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVGTPSIT.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVGTPSIT.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVGTPSIT.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.GroupPanel.Image = CType(resources.GetObject("GVGTPSIT.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVGTPSIT.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVGTPSIT.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVGTPSIT.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.GroupRow.Image = CType(resources.GetObject("GVGTPSIT.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVGTPSIT.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVGTPSIT.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVGTPSIT.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVGTPSIT.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVGTPSIT.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVGTPSIT.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVGTPSIT.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVGTPSIT.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVGTPSIT.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVGTPSIT.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVGTPSIT.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVGTPSIT.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVGTPSIT.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVGTPSIT.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.HideSelectionRow.BorderColor = CType(resources.GetObject("GVGTPSIT.Appearance.HideSelectionRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVGTPSIT.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVGTPSIT.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVGTPSIT.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVGTPSIT.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.HorzLine.BorderColor = CType(resources.GetObject("GVGTPSIT.Appearance.HorzLine.BorderColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.HorzLine.Image = CType(resources.GetObject("GVGTPSIT.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVGTPSIT.Appearance.OddRow.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVGTPSIT.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVGTPSIT.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.OddRow.Image = CType(resources.GetObject("GVGTPSIT.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.OddRow.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVGTPSIT.Appearance.OddRow.Options.UseForeColor = True
        Me.GVGTPSIT.Appearance.Preview.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.Preview.BorderColor = CType(resources.GetObject("GVGTPSIT.Appearance.Preview.BorderColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.Preview.Font = CType(resources.GetObject("GVGTPSIT.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVGTPSIT.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.Preview.ForeColor = CType(resources.GetObject("GVGTPSIT.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.Preview.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.Preview.Image = CType(resources.GetObject("GVGTPSIT.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.Preview.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.Preview.Options.UseBorderColor = True
        Me.GVGTPSIT.Appearance.Preview.Options.UseFont = True
        Me.GVGTPSIT.Appearance.Preview.Options.UseForeColor = True
        Me.GVGTPSIT.Appearance.Row.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.Row.BorderColor = CType(resources.GetObject("GVGTPSIT.Appearance.Row.BorderColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.Row.ForeColor = CType(resources.GetObject("GVGTPSIT.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.Row.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.Row.Image = CType(resources.GetObject("GVGTPSIT.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.Row.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.Row.Options.UseBorderColor = True
        Me.GVGTPSIT.Appearance.Row.Options.UseForeColor = True
        Me.GVGTPSIT.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVGTPSIT.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.RowSeparator.Image = CType(resources.GetObject("GVGTPSIT.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVGTPSIT.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.SelectedRow.Image = CType(resources.GetObject("GVGTPSIT.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVGTPSIT.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.TopNewRow.Image = CType(resources.GetObject("GVGTPSIT.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVGTPSIT.Appearance.VertLine.BackColor = CType(resources.GetObject("GVGTPSIT.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVGTPSIT.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVGTPSIT.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVGTPSIT.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVGTPSIT.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPSIT.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVGTPSIT.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPSIT.Appearance.VertLine.Image = CType(resources.GetObject("GVGTPSIT.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVGTPSIT.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVGTPSIT, "GVGTPSIT")
        Me.GVGTPSIT.ColumnPanelRowHeight = 60
        Me.GVGTPSIT.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColSitIDTMP, Me.ColSitNSITNUM, Me.ColSitNGTPMAINID, Me.ColSitVGTPLOTNOM, Me.ColSitVGTPPRECIS, Me.ColSitNGTPZONEID, Me.ColSitVGTPUNITENOM, Me.ColSitVGTPEQUIP, Me.ColSitNGTPSITINSTANNEE, Me.ColSitNGTPSITQTE, Me.ColSitVGTPSITOBS})
        Me.GVGTPSIT.GridControl = Me.GCGTPSIT
        Me.GVGTPSIT.Name = "GVGTPSIT"
        Me.GVGTPSIT.OptionsNavigation.AutoFocusNewRow = True
        Me.GVGTPSIT.OptionsView.EnableAppearanceEvenRow = True
        Me.GVGTPSIT.OptionsView.EnableAppearanceOddRow = True
        Me.GVGTPSIT.OptionsView.ShowAutoFilterRow = True
        Me.GVGTPSIT.OptionsView.ShowGroupPanel = False
        Me.GVGTPSIT.RowHeight = 20
        '
        'ColSitIDTMP
        '
        resources.ApplyResources(Me.ColSitIDTMP, "ColSitIDTMP")
        Me.ColSitIDTMP.FieldName = "IDTMP"
        Me.ColSitIDTMP.Name = "ColSitIDTMP"
        '
        'ColSitNSITNUM
        '
        resources.ApplyResources(Me.ColSitNSITNUM, "ColSitNSITNUM")
        Me.ColSitNSITNUM.FieldName = "NSITNUM"
        Me.ColSitNSITNUM.Name = "ColSitNSITNUM"
        '
        'ColSitNGTPMAINID
        '
        resources.ApplyResources(Me.ColSitNGTPMAINID, "ColSitNGTPMAINID")
        Me.ColSitNGTPMAINID.FieldName = "NGTPMAINID"
        Me.ColSitNGTPMAINID.Name = "ColSitNGTPMAINID"
        '
        'ColSitVGTPLOTNOM
        '
        resources.ApplyResources(Me.ColSitVGTPLOTNOM, "ColSitVGTPLOTNOM")
        Me.ColSitVGTPLOTNOM.FieldName = "VGTPLOTNOM"
        Me.ColSitVGTPLOTNOM.Name = "ColSitVGTPLOTNOM"
        Me.ColSitVGTPLOTNOM.OptionsColumn.AllowEdit = False
        Me.ColSitVGTPLOTNOM.OptionsColumn.ReadOnly = True
        '
        'ColSitVGTPPRECIS
        '
        resources.ApplyResources(Me.ColSitVGTPPRECIS, "ColSitVGTPPRECIS")
        Me.ColSitVGTPPRECIS.FieldName = "VGTPPRECIS"
        Me.ColSitVGTPPRECIS.Name = "ColSitVGTPPRECIS"
        Me.ColSitVGTPPRECIS.OptionsColumn.AllowEdit = False
        Me.ColSitVGTPPRECIS.OptionsColumn.ReadOnly = True
        '
        'ColSitNGTPZONEID
        '
        resources.ApplyResources(Me.ColSitNGTPZONEID, "ColSitNGTPZONEID")
        Me.ColSitNGTPZONEID.ColumnEdit = Me.RepItemGLUpEditZone
        Me.ColSitNGTPZONEID.FieldName = "NGTPZONEID"
        Me.ColSitNGTPZONEID.Name = "ColSitNGTPZONEID"
        '
        'RepItemGLUpEditZone
        '
        resources.ApplyResources(Me.RepItemGLUpEditZone, "RepItemGLUpEditZone")
        Me.RepItemGLUpEditZone.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemGLUpEditZone.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepItemGLUpEditZone.DisplayMember = "VGTPZONENOM"
        Me.RepItemGLUpEditZone.Name = "RepItemGLUpEditZone"
        Me.RepItemGLUpEditZone.ValueMember = "NGTPZONEID"
        Me.RepItemGLUpEditZone.View = Me.RepItemGLUpEditViewZone
        '
        'RepItemGLUpEditViewZone
        '
        resources.ApplyResources(Me.RepItemGLUpEditViewZone, "RepItemGLUpEditViewZone")
        Me.RepItemGLUpEditViewZone.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColViewNGTPZONEID, Me.ColViewVGTPZONENOM})
        Me.RepItemGLUpEditViewZone.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepItemGLUpEditViewZone.Name = "RepItemGLUpEditViewZone"
        Me.RepItemGLUpEditViewZone.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepItemGLUpEditViewZone.OptionsView.ShowGroupPanel = False
        '
        'ColViewNGTPZONEID
        '
        resources.ApplyResources(Me.ColViewNGTPZONEID, "ColViewNGTPZONEID")
        Me.ColViewNGTPZONEID.FieldName = "NGTPZONEID"
        Me.ColViewNGTPZONEID.Name = "ColViewNGTPZONEID"
        '
        'ColViewVGTPZONENOM
        '
        resources.ApplyResources(Me.ColViewVGTPZONENOM, "ColViewVGTPZONENOM")
        Me.ColViewVGTPZONENOM.FieldName = "VGTPZONENOM"
        Me.ColViewVGTPZONENOM.Name = "ColViewVGTPZONENOM"
        '
        'ColSitVGTPUNITENOM
        '
        Me.ColSitVGTPUNITENOM.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ColSitVGTPUNITENOM.AppearanceCell.FontSizeDelta"), Integer)
        Me.ColSitVGTPUNITENOM.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ColSitVGTPUNITENOM.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColSitVGTPUNITENOM.AppearanceCell.GradientMode = CType(resources.GetObject("ColSitVGTPUNITENOM.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColSitVGTPUNITENOM.AppearanceCell.Image = CType(resources.GetObject("ColSitVGTPUNITENOM.AppearanceCell.Image"), System.Drawing.Image)
        Me.ColSitVGTPUNITENOM.AppearanceCell.Options.UseTextOptions = True
        Me.ColSitVGTPUNITENOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSitVGTPUNITENOM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColSitVGTPUNITENOM, "ColSitVGTPUNITENOM")
        Me.ColSitVGTPUNITENOM.FieldName = "VGTPUNITENOM"
        Me.ColSitVGTPUNITENOM.Name = "ColSitVGTPUNITENOM"
        Me.ColSitVGTPUNITENOM.OptionsColumn.AllowEdit = False
        Me.ColSitVGTPUNITENOM.OptionsColumn.ReadOnly = True
        '
        'ColSitVGTPEQUIP
        '
        resources.ApplyResources(Me.ColSitVGTPEQUIP, "ColSitVGTPEQUIP")
        Me.ColSitVGTPEQUIP.FieldName = "VGTPEQUIP"
        Me.ColSitVGTPEQUIP.Name = "ColSitVGTPEQUIP"
        Me.ColSitVGTPEQUIP.OptionsColumn.AllowEdit = False
        Me.ColSitVGTPEQUIP.OptionsColumn.ReadOnly = True
        '
        'ColSitNGTPSITINSTANNEE
        '
        Me.ColSitNGTPSITINSTANNEE.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ColSitNGTPSITINSTANNEE.AppearanceCell.FontSizeDelta"), Integer)
        Me.ColSitNGTPSITINSTANNEE.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ColSitNGTPSITINSTANNEE.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColSitNGTPSITINSTANNEE.AppearanceCell.GradientMode = CType(resources.GetObject("ColSitNGTPSITINSTANNEE.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColSitNGTPSITINSTANNEE.AppearanceCell.Image = CType(resources.GetObject("ColSitNGTPSITINSTANNEE.AppearanceCell.Image"), System.Drawing.Image)
        Me.ColSitNGTPSITINSTANNEE.AppearanceCell.Options.UseTextOptions = True
        Me.ColSitNGTPSITINSTANNEE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSitNGTPSITINSTANNEE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColSitNGTPSITINSTANNEE, "ColSitNGTPSITINSTANNEE")
        Me.ColSitNGTPSITINSTANNEE.FieldName = "NGTPSITINSTANNEE"
        Me.ColSitNGTPSITINSTANNEE.Name = "ColSitNGTPSITINSTANNEE"
        '
        'ColSitNGTPSITQTE
        '
        Me.ColSitNGTPSITQTE.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ColSitNGTPSITQTE.AppearanceCell.FontSizeDelta"), Integer)
        Me.ColSitNGTPSITQTE.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ColSitNGTPSITQTE.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColSitNGTPSITQTE.AppearanceCell.GradientMode = CType(resources.GetObject("ColSitNGTPSITQTE.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColSitNGTPSITQTE.AppearanceCell.Image = CType(resources.GetObject("ColSitNGTPSITQTE.AppearanceCell.Image"), System.Drawing.Image)
        Me.ColSitNGTPSITQTE.AppearanceCell.Options.UseTextOptions = True
        Me.ColSitNGTPSITQTE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColSitNGTPSITQTE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColSitNGTPSITQTE, "ColSitNGTPSITQTE")
        Me.ColSitNGTPSITQTE.DisplayFormat.FormatString = "d0"
        Me.ColSitNGTPSITQTE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColSitNGTPSITQTE.FieldName = "NGTPSITQTE"
        Me.ColSitNGTPSITQTE.Name = "ColSitNGTPSITQTE"
        '
        'ColSitVGTPSITOBS
        '
        resources.ApplyResources(Me.ColSitVGTPSITOBS, "ColSitVGTPSITOBS")
        Me.ColSitVGTPSITOBS.FieldName = "VGTPSITOBS"
        Me.ColSitVGTPSITOBS.Name = "ColSitVGTPSITOBS"
        '
        'GrpClient
        '
        resources.ApplyResources(Me.GrpClient, "GrpClient")
        Me.GrpClient.Controls.Add(Me.BtnSelectAll)
        Me.GrpClient.Controls.Add(Me.GCGTPClient)
        Me.GrpClient.Name = "GrpClient"
        Me.GrpClient.TabStop = False
        '
        'BtnSelectAll
        '
        resources.ApplyResources(Me.BtnSelectAll, "BtnSelectAll")
        Me.BtnSelectAll.Name = "BtnSelectAll"
        Me.BtnSelectAll.UseVisualStyleBackColor = True
        '
        'GCGTPClient
        '
        resources.ApplyResources(Me.GCGTPClient, "GCGTPClient")
        '
        '
        '
        Me.GCGTPClient.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCGTPClient.EmbeddedNavigator.AccessibleDescription")
        Me.GCGTPClient.EmbeddedNavigator.AccessibleName = resources.GetString("GCGTPClient.EmbeddedNavigator.AccessibleName")
        Me.GCGTPClient.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCGTPClient.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCGTPClient.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCGTPClient.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCGTPClient.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCGTPClient.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCGTPClient.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCGTPClient.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCGTPClient.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCGTPClient.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCGTPClient.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCGTPClient.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCGTPClient.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCGTPClient.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCGTPClient.EmbeddedNavigator.ToolTip = resources.GetString("GCGTPClient.EmbeddedNavigator.ToolTip")
        Me.GCGTPClient.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCGTPClient.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCGTPClient.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCGTPClient.EmbeddedNavigator.ToolTipTitle")
        Me.GCGTPClient.MainView = Me.GVGTPClient
        Me.GCGTPClient.Name = "GCGTPClient"
        Me.GCGTPClient.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVGTPClient})
        '
        'GVGTPClient
        '
        Me.GVGTPClient.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVGTPClient.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVGTPClient.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVGTPClient.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVGTPClient.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVGTPClient.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVGTPClient.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVGTPClient.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVGTPClient.Appearance.Empty.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVGTPClient.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.Empty.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.Empty.Image = CType(resources.GetObject("GVGTPClient.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.Empty.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVGTPClient.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.EvenRow.Image = CType(resources.GetObject("GVGTPClient.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVGTPClient.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVGTPClient.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVGTPClient.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVGTPClient.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVGTPClient.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVGTPClient.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVGTPClient.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.FilterPanel.Image = CType(resources.GetObject("GVGTPClient.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVGTPClient.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.FixedLine.Image = CType(resources.GetObject("GVGTPClient.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.FocusedCell.Image = CType(resources.GetObject("GVGTPClient.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVGTPClient.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.FocusedRow.Image = CType(resources.GetObject("GVGTPClient.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVGTPClient.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVGTPClient.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.FooterPanel.Image = CType(resources.GetObject("GVGTPClient.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVGTPClient.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVGTPClient.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVGTPClient.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.GroupButton.Image = CType(resources.GetObject("GVGTPClient.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVGTPClient.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVGTPClient.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.GroupFooter.Image = CType(resources.GetObject("GVGTPClient.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVGTPClient.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVGTPClient.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVGTPClient.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.GroupPanel.Image = CType(resources.GetObject("GVGTPClient.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVGTPClient.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVGTPClient.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.GroupRow.Image = CType(resources.GetObject("GVGTPClient.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVGTPClient.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVGTPClient.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVGTPClient.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVGTPClient.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVGTPClient.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVGTPClient.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVGTPClient.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVGTPClient.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVGTPClient.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVGTPClient.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVGTPClient.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVGTPClient.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVGTPClient.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVGTPClient.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVGTPClient.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.HorzLine.BorderColor = CType(resources.GetObject("GVGTPClient.Appearance.HorzLine.BorderColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.HorzLine.Image = CType(resources.GetObject("GVGTPClient.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVGTPClient.Appearance.OddRow.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVGTPClient.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.OddRow.Image = CType(resources.GetObject("GVGTPClient.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.OddRow.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVGTPClient.Appearance.OddRow.Options.UseForeColor = True
        Me.GVGTPClient.Appearance.Preview.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.Preview.Font = CType(resources.GetObject("GVGTPClient.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVGTPClient.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.Preview.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.Preview.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.Preview.Image = CType(resources.GetObject("GVGTPClient.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.Preview.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.Preview.Options.UseFont = True
        Me.GVGTPClient.Appearance.Preview.Options.UseForeColor = True
        Me.GVGTPClient.Appearance.Row.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.Row.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.Row.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.Row.Image = CType(resources.GetObject("GVGTPClient.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.Row.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.Row.Options.UseForeColor = True
        Me.GVGTPClient.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVGTPClient.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.RowSeparator.Image = CType(resources.GetObject("GVGTPClient.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.SelectedRow.Image = CType(resources.GetObject("GVGTPClient.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVGTPClient.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.TopNewRow.Image = CType(resources.GetObject("GVGTPClient.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.VertLine.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.VertLine.BorderColor = CType(resources.GetObject("GVGTPClient.Appearance.VertLine.BorderColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.VertLine.Image = CType(resources.GetObject("GVGTPClient.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.VertLine.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.VertLine.Options.UseBorderColor = True
        resources.ApplyResources(Me.GVGTPClient, "GVGTPClient")
        Me.GVGTPClient.ColumnPanelRowHeight = 60
        Me.GVGTPClient.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColCliNGTPCLIID, Me.ColCliNCLINUM, Me.ColCliNGTPMAINID, Me.ColCliVGTPLOTNOM, Me.ColCliVGTPEQUIP, Me.ColCliVGTPPRECIS, Me.ColCliNGTPDURVIE, Me.ColCliVGTPUNITENOM, Me.ColCliNGTPCOUTUNIT})
        Me.GVGTPClient.CustomizationFormBounds = New System.Drawing.Rectangle(570, 575, 208, 170)
        Me.GVGTPClient.GridControl = Me.GCGTPClient
        Me.GVGTPClient.Name = "GVGTPClient"
        Me.GVGTPClient.OptionsBehavior.Editable = False
        Me.GVGTPClient.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVGTPClient.OptionsSelection.MultiSelect = True
        Me.GVGTPClient.OptionsView.EnableAppearanceEvenRow = True
        Me.GVGTPClient.OptionsView.EnableAppearanceOddRow = True
        Me.GVGTPClient.OptionsView.ShowAutoFilterRow = True
        Me.GVGTPClient.OptionsView.ShowGroupPanel = False
        Me.GVGTPClient.RowHeight = 20
        '
        'ColCliNGTPCLIID
        '
        resources.ApplyResources(Me.ColCliNGTPCLIID, "ColCliNGTPCLIID")
        Me.ColCliNGTPCLIID.FieldName = "NGTPCLIID"
        Me.ColCliNGTPCLIID.Name = "ColCliNGTPCLIID"
        '
        'ColCliNCLINUM
        '
        resources.ApplyResources(Me.ColCliNCLINUM, "ColCliNCLINUM")
        Me.ColCliNCLINUM.FieldName = "NCLINUM"
        Me.ColCliNCLINUM.Name = "ColCliNCLINUM"
        '
        'ColCliNGTPMAINID
        '
        resources.ApplyResources(Me.ColCliNGTPMAINID, "ColCliNGTPMAINID")
        Me.ColCliNGTPMAINID.FieldName = "NGTPMAINID"
        Me.ColCliNGTPMAINID.Name = "ColCliNGTPMAINID"
        '
        'ColCliVGTPLOTNOM
        '
        resources.ApplyResources(Me.ColCliVGTPLOTNOM, "ColCliVGTPLOTNOM")
        Me.ColCliVGTPLOTNOM.FieldName = "VGTPLOTNOM"
        Me.ColCliVGTPLOTNOM.Name = "ColCliVGTPLOTNOM"
        '
        'ColCliVGTPEQUIP
        '
        resources.ApplyResources(Me.ColCliVGTPEQUIP, "ColCliVGTPEQUIP")
        Me.ColCliVGTPEQUIP.FieldName = "VGTPEQUIP"
        Me.ColCliVGTPEQUIP.Name = "ColCliVGTPEQUIP"
        '
        'ColCliVGTPPRECIS
        '
        resources.ApplyResources(Me.ColCliVGTPPRECIS, "ColCliVGTPPRECIS")
        Me.ColCliVGTPPRECIS.FieldName = "VGTPPRECIS"
        Me.ColCliVGTPPRECIS.Name = "ColCliVGTPPRECIS"
        '
        'ColCliNGTPDURVIE
        '
        Me.ColCliNGTPDURVIE.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ColCliNGTPDURVIE.AppearanceCell.FontSizeDelta"), Integer)
        Me.ColCliNGTPDURVIE.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ColCliNGTPDURVIE.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColCliNGTPDURVIE.AppearanceCell.GradientMode = CType(resources.GetObject("ColCliNGTPDURVIE.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColCliNGTPDURVIE.AppearanceCell.Image = CType(resources.GetObject("ColCliNGTPDURVIE.AppearanceCell.Image"), System.Drawing.Image)
        Me.ColCliNGTPDURVIE.AppearanceCell.Options.UseTextOptions = True
        Me.ColCliNGTPDURVIE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCliNGTPDURVIE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColCliNGTPDURVIE, "ColCliNGTPDURVIE")
        Me.ColCliNGTPDURVIE.FieldName = "NGTPDURVIE"
        Me.ColCliNGTPDURVIE.Name = "ColCliNGTPDURVIE"
        '
        'ColCliVGTPUNITENOM
        '
        Me.ColCliVGTPUNITENOM.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ColCliVGTPUNITENOM.AppearanceCell.FontSizeDelta"), Integer)
        Me.ColCliVGTPUNITENOM.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ColCliVGTPUNITENOM.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColCliVGTPUNITENOM.AppearanceCell.GradientMode = CType(resources.GetObject("ColCliVGTPUNITENOM.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColCliVGTPUNITENOM.AppearanceCell.Image = CType(resources.GetObject("ColCliVGTPUNITENOM.AppearanceCell.Image"), System.Drawing.Image)
        Me.ColCliVGTPUNITENOM.AppearanceCell.Options.UseTextOptions = True
        Me.ColCliVGTPUNITENOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCliVGTPUNITENOM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColCliVGTPUNITENOM, "ColCliVGTPUNITENOM")
        Me.ColCliVGTPUNITENOM.FieldName = "VGTPUNITENOM"
        Me.ColCliVGTPUNITENOM.Name = "ColCliVGTPUNITENOM"
        '
        'ColCliNGTPCOUTUNIT
        '
        Me.ColCliNGTPCOUTUNIT.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ColCliNGTPCOUTUNIT.AppearanceCell.FontSizeDelta"), Integer)
        Me.ColCliNGTPCOUTUNIT.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ColCliNGTPCOUTUNIT.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColCliNGTPCOUTUNIT.AppearanceCell.GradientMode = CType(resources.GetObject("ColCliNGTPCOUTUNIT.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColCliNGTPCOUTUNIT.AppearanceCell.Image = CType(resources.GetObject("ColCliNGTPCOUTUNIT.AppearanceCell.Image"), System.Drawing.Image)
        Me.ColCliNGTPCOUTUNIT.AppearanceCell.Options.UseTextOptions = True
        Me.ColCliNGTPCOUTUNIT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColCliNGTPCOUTUNIT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColCliNGTPCOUTUNIT, "ColCliNGTPCOUTUNIT")
        Me.ColCliNGTPCOUTUNIT.FieldName = "NGTPCOUTUNIT"
        Me.ColCliNGTPCOUTUNIT.Name = "ColCliNGTPCOUTUNIT"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'frmGTPSite
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpClient)
        Me.Controls.Add(Me.GrpSite)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmGTPSite"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.GrpSite.ResumeLayout(False)
        CType(Me.GCGTPSIT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVGTPSIT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditZone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditViewZone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpClient.ResumeLayout(False)
        CType(Me.GCGTPClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVGTPClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnSupprLine As System.Windows.Forms.Button
    Friend WithEvents BtnAddLine As System.Windows.Forms.Button
    Friend WithEvents GrpSite As System.Windows.Forms.GroupBox
    Friend WithEvents GrpClient As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSelectAll As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents GCGTPSIT As DevExpress.XtraGrid.GridControl
    Private WithEvents GVGTPSIT As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColSitIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitNSITNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitVGTPLOTNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitVGTPEQUIP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitVGTPPRECIS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitNGTPZONEID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemGLUpEditZone As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepItemGLUpEditViewZone As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColViewNGTPZONEID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColViewVGTPZONENOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitVGTPUNITENOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitNGTPSITINSTANNEE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitNGTPSITQTE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitVGTPSITOBS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCGTPClient As DevExpress.XtraGrid.GridControl
    Private WithEvents GVGTPClient As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColCliNGTPCLIID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColCliNCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColCliNGTPMAINID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColCliVGTPLOTNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColCliVGTPEQUIP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColCliVGTPPRECIS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColCliNGTPDURVIE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColCliVGTPUNITENOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColCliNGTPCOUTUNIT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitNGTPMAINID As DevExpress.XtraGrid.Columns.GridColumn
End Class
