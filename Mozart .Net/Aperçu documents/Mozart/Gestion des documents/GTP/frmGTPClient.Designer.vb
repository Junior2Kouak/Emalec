<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGTPClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGTPClient))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnSupprLine = New System.Windows.Forms.Button()
        Me.BtnAddLine = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GrpboxClient = New System.Windows.Forms.GroupBox()
        Me.GCGTPClient = New DevExpress.XtraGrid.GridControl()
        Me.GVGTPClient = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColCliIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliNGTPCLIID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliNCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliNGTPMAINID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliVGTPLOTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliVGTPEQUIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliVGTPPRECIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliNGTPDURVIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliVGTPUNITENOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCliNGTPCOUTUNIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLUpEditGTPZone = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GrpBoxLstEquipemetCommun = New System.Windows.Forms.GroupBox()
        Me.BtnSelectAll = New System.Windows.Forms.Button()
        Me.GCGTPLstEMALEC = New DevExpress.XtraGrid.GridControl()
        Me.GVGTPLstEMALEC = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColMainNGTPMAINID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMainVGTPLOTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMainVGTPEQUIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMainVGTPPRECIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMainNGTPDURVIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMainVGTPUNITENOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMainNGTPCOUTUNIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        Me.GrpboxClient.SuspendLayout()
        CType(Me.GCGTPClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVGTPClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditGTPZone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxLstEquipemetCommun.SuspendLayout()
        CType(Me.GCGTPLstEMALEC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVGTPLstEMALEC, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GrpboxClient
        '
        resources.ApplyResources(Me.GrpboxClient, "GrpboxClient")
        Me.GrpboxClient.Controls.Add(Me.GCGTPClient)
        Me.GrpboxClient.Name = "GrpboxClient"
        Me.GrpboxClient.TabStop = False
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
        Me.GVGTPClient.Appearance.HideSelectionRow.BorderColor = CType(resources.GetObject("GVGTPClient.Appearance.HideSelectionRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVGTPClient.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.HideSelectionRow.Options.UseBorderColor = True
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
        Me.GVGTPClient.Appearance.Preview.BorderColor = CType(resources.GetObject("GVGTPClient.Appearance.Preview.BorderColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.Preview.Font = CType(resources.GetObject("GVGTPClient.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVGTPClient.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.Preview.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.Preview.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.Preview.Image = CType(resources.GetObject("GVGTPClient.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.Preview.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.Preview.Options.UseBorderColor = True
        Me.GVGTPClient.Appearance.Preview.Options.UseFont = True
        Me.GVGTPClient.Appearance.Preview.Options.UseForeColor = True
        Me.GVGTPClient.Appearance.Row.BackColor = CType(resources.GetObject("GVGTPClient.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.Row.BorderColor = CType(resources.GetObject("GVGTPClient.Appearance.Row.BorderColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.Row.ForeColor = CType(resources.GetObject("GVGTPClient.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVGTPClient.Appearance.Row.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.Row.Image = CType(resources.GetObject("GVGTPClient.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.Row.Options.UseBackColor = True
        Me.GVGTPClient.Appearance.Row.Options.UseBorderColor = True
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
        Me.GVGTPClient.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVGTPClient.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVGTPClient.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVGTPClient.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPClient.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVGTPClient.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPClient.Appearance.VertLine.Image = CType(resources.GetObject("GVGTPClient.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVGTPClient.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVGTPClient, "GVGTPClient")
        Me.GVGTPClient.ColumnPanelRowHeight = 60
        Me.GVGTPClient.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColCliIDTMP, Me.ColCliNGTPCLIID, Me.ColCliNCLINUM, Me.ColCliNGTPMAINID, Me.ColCliVGTPLOTNOM, Me.ColCliVGTPEQUIP, Me.ColCliVGTPPRECIS, Me.ColCliNGTPDURVIE, Me.ColCliVGTPUNITENOM, Me.ColCliNGTPCOUTUNIT})
        Me.GVGTPClient.CustomizationFormBounds = New System.Drawing.Rectangle(570, 575, 208, 170)
        Me.GVGTPClient.GridControl = Me.GCGTPClient
        Me.GVGTPClient.Name = "GVGTPClient"
        Me.GVGTPClient.OptionsBehavior.Editable = False
        Me.GVGTPClient.OptionsNavigation.AutoFocusNewRow = True
        Me.GVGTPClient.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVGTPClient.OptionsView.EnableAppearanceEvenRow = True
        Me.GVGTPClient.OptionsView.EnableAppearanceOddRow = True
        Me.GVGTPClient.OptionsView.ShowAutoFilterRow = True
        Me.GVGTPClient.OptionsView.ShowGroupPanel = False
        Me.GVGTPClient.RowHeight = 20
        '
        'ColCliIDTMP
        '
        resources.ApplyResources(Me.ColCliIDTMP, "ColCliIDTMP")
        Me.ColCliIDTMP.FieldName = "IDTMP"
        Me.ColCliIDTMP.Name = "ColCliIDTMP"
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
        'RepItemGLUpEditGTPZone
        '
        resources.ApplyResources(Me.RepItemGLUpEditGTPZone, "RepItemGLUpEditGTPZone")
        Me.RepItemGLUpEditGTPZone.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemGLUpEditGTPZone.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepItemGLUpEditGTPZone.DisplayMember = "VGTPZONENAME"
        Me.RepItemGLUpEditGTPZone.Name = "RepItemGLUpEditGTPZone"
        Me.RepItemGLUpEditGTPZone.ValueMember = "NGTPZONEID"
        Me.RepItemGLUpEditGTPZone.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        resources.ApplyResources(Me.RepositoryItemGridLookUpEdit1View, "RepositoryItemGridLookUpEdit1View")
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GrpBoxLstEquipemetCommun
        '
        resources.ApplyResources(Me.GrpBoxLstEquipemetCommun, "GrpBoxLstEquipemetCommun")
        Me.GrpBoxLstEquipemetCommun.Controls.Add(Me.BtnSelectAll)
        Me.GrpBoxLstEquipemetCommun.Controls.Add(Me.GCGTPLstEMALEC)
        Me.GrpBoxLstEquipemetCommun.Name = "GrpBoxLstEquipemetCommun"
        Me.GrpBoxLstEquipemetCommun.TabStop = False
        '
        'BtnSelectAll
        '
        resources.ApplyResources(Me.BtnSelectAll, "BtnSelectAll")
        Me.BtnSelectAll.Name = "BtnSelectAll"
        Me.BtnSelectAll.UseVisualStyleBackColor = True
        '
        'GCGTPLstEMALEC
        '
        resources.ApplyResources(Me.GCGTPLstEMALEC, "GCGTPLstEMALEC")
        '
        '
        '
        Me.GCGTPLstEMALEC.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCGTPLstEMALEC.EmbeddedNavigator.AccessibleDescription")
        Me.GCGTPLstEMALEC.EmbeddedNavigator.AccessibleName = resources.GetString("GCGTPLstEMALEC.EmbeddedNavigator.AccessibleName")
        Me.GCGTPLstEMALEC.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCGTPLstEMALEC.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCGTPLstEMALEC.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCGTPLstEMALEC.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCGTPLstEMALEC.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCGTPLstEMALEC.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCGTPLstEMALEC.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCGTPLstEMALEC.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCGTPLstEMALEC.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCGTPLstEMALEC.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCGTPLstEMALEC.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCGTPLstEMALEC.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCGTPLstEMALEC.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCGTPLstEMALEC.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCGTPLstEMALEC.EmbeddedNavigator.ToolTip = resources.GetString("GCGTPLstEMALEC.EmbeddedNavigator.ToolTip")
        Me.GCGTPLstEMALEC.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCGTPLstEMALEC.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCGTPLstEMALEC.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCGTPLstEMALEC.EmbeddedNavigator.ToolTipTitle")
        Me.GCGTPLstEMALEC.MainView = Me.GVGTPLstEMALEC
        Me.GCGTPLstEMALEC.Name = "GCGTPLstEMALEC"
        Me.GCGTPLstEMALEC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVGTPLstEMALEC})
        '
        'GVGTPLstEMALEC
        '
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVGTPLstEMALEC.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVGTPLstEMALEC.Appearance.Empty.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.Empty.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.Empty.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.Empty.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.EvenRow.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVGTPLstEMALEC.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVGTPLstEMALEC.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVGTPLstEMALEC.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVGTPLstEMALEC.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.FilterPanel.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVGTPLstEMALEC.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.FixedLine.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.FocusedCell.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVGTPLstEMALEC.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.FocusedRow.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVGTPLstEMALEC.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.FooterPanel.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVGTPLstEMALEC.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVGTPLstEMALEC.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.GroupButton.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVGTPLstEMALEC.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.GroupFooter.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVGTPLstEMALEC.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVGTPLstEMALEC.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.GroupPanel.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVGTPLstEMALEC.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.GroupRow.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVGTPLstEMALEC.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVGTPLstEMALEC.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVGTPLstEMALEC.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVGTPLstEMALEC.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVGTPLstEMALEC.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVGTPLstEMALEC.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVGTPLstEMALEC.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVGTPLstEMALEC.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVGTPLstEMALEC.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVGTPLstEMALEC.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVGTPLstEMALEC.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.HorzLine.BorderColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HorzLine.BorderColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.HorzLine.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVGTPLstEMALEC.Appearance.OddRow.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.OddRow.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.OddRow.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVGTPLstEMALEC.Appearance.OddRow.Options.UseForeColor = True
        Me.GVGTPLstEMALEC.Appearance.Preview.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.Preview.Font = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVGTPLstEMALEC.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.Preview.ForeColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.Preview.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.Preview.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.Preview.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.Preview.Options.UseFont = True
        Me.GVGTPLstEMALEC.Appearance.Preview.Options.UseForeColor = True
        Me.GVGTPLstEMALEC.Appearance.Row.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.Row.ForeColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.Row.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.Row.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.Row.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.Row.Options.UseForeColor = True
        Me.GVGTPLstEMALEC.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.RowSeparator.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.SelectedRow.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVGTPLstEMALEC.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.TopNewRow.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.VertLine.BackColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.VertLine.BorderColor = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.VertLine.BorderColor"), System.Drawing.Color)
        Me.GVGTPLstEMALEC.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVGTPLstEMALEC.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPLstEMALEC.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPLstEMALEC.Appearance.VertLine.Image = CType(resources.GetObject("GVGTPLstEMALEC.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVGTPLstEMALEC.Appearance.VertLine.Options.UseBackColor = True
        Me.GVGTPLstEMALEC.Appearance.VertLine.Options.UseBorderColor = True
        resources.ApplyResources(Me.GVGTPLstEMALEC, "GVGTPLstEMALEC")
        Me.GVGTPLstEMALEC.ColumnPanelRowHeight = 60
        Me.GVGTPLstEMALEC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColMainNGTPMAINID, Me.ColMainVGTPLOTNOM, Me.ColMainVGTPEQUIP, Me.ColMainVGTPPRECIS, Me.ColMainNGTPDURVIE, Me.ColMainVGTPUNITENOM, Me.ColMainNGTPCOUTUNIT})
        Me.GVGTPLstEMALEC.CustomizationFormBounds = New System.Drawing.Rectangle(570, 575, 208, 170)
        Me.GVGTPLstEMALEC.GridControl = Me.GCGTPLstEMALEC
        Me.GVGTPLstEMALEC.Name = "GVGTPLstEMALEC"
        Me.GVGTPLstEMALEC.OptionsBehavior.Editable = False
        Me.GVGTPLstEMALEC.OptionsBehavior.ReadOnly = True
        Me.GVGTPLstEMALEC.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVGTPLstEMALEC.OptionsSelection.MultiSelect = True
        Me.GVGTPLstEMALEC.OptionsView.EnableAppearanceEvenRow = True
        Me.GVGTPLstEMALEC.OptionsView.EnableAppearanceOddRow = True
        Me.GVGTPLstEMALEC.OptionsView.ShowAutoFilterRow = True
        Me.GVGTPLstEMALEC.OptionsView.ShowGroupPanel = False
        Me.GVGTPLstEMALEC.RowHeight = 20
        '
        'ColMainNGTPMAINID
        '
        resources.ApplyResources(Me.ColMainNGTPMAINID, "ColMainNGTPMAINID")
        Me.ColMainNGTPMAINID.FieldName = "NGTPMAINID"
        Me.ColMainNGTPMAINID.Name = "ColMainNGTPMAINID"
        '
        'ColMainVGTPLOTNOM
        '
        resources.ApplyResources(Me.ColMainVGTPLOTNOM, "ColMainVGTPLOTNOM")
        Me.ColMainVGTPLOTNOM.FieldName = "VGTPLOTNOM"
        Me.ColMainVGTPLOTNOM.Name = "ColMainVGTPLOTNOM"
        '
        'ColMainVGTPEQUIP
        '
        resources.ApplyResources(Me.ColMainVGTPEQUIP, "ColMainVGTPEQUIP")
        Me.ColMainVGTPEQUIP.FieldName = "VGTPEQUIP"
        Me.ColMainVGTPEQUIP.Name = "ColMainVGTPEQUIP"
        '
        'ColMainVGTPPRECIS
        '
        resources.ApplyResources(Me.ColMainVGTPPRECIS, "ColMainVGTPPRECIS")
        Me.ColMainVGTPPRECIS.FieldName = "VGTPPRECIS"
        Me.ColMainVGTPPRECIS.Name = "ColMainVGTPPRECIS"
        '
        'ColMainNGTPDURVIE
        '
        Me.ColMainNGTPDURVIE.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ColMainNGTPDURVIE.AppearanceCell.FontSizeDelta"), Integer)
        Me.ColMainNGTPDURVIE.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ColMainNGTPDURVIE.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColMainNGTPDURVIE.AppearanceCell.GradientMode = CType(resources.GetObject("ColMainNGTPDURVIE.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColMainNGTPDURVIE.AppearanceCell.Image = CType(resources.GetObject("ColMainNGTPDURVIE.AppearanceCell.Image"), System.Drawing.Image)
        Me.ColMainNGTPDURVIE.AppearanceCell.Options.UseTextOptions = True
        Me.ColMainNGTPDURVIE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColMainNGTPDURVIE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColMainNGTPDURVIE, "ColMainNGTPDURVIE")
        Me.ColMainNGTPDURVIE.FieldName = "NGTPDURVIE"
        Me.ColMainNGTPDURVIE.Name = "ColMainNGTPDURVIE"
        '
        'ColMainVGTPUNITENOM
        '
        Me.ColMainVGTPUNITENOM.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ColMainVGTPUNITENOM.AppearanceCell.FontSizeDelta"), Integer)
        Me.ColMainVGTPUNITENOM.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ColMainVGTPUNITENOM.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColMainVGTPUNITENOM.AppearanceCell.GradientMode = CType(resources.GetObject("ColMainVGTPUNITENOM.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColMainVGTPUNITENOM.AppearanceCell.Image = CType(resources.GetObject("ColMainVGTPUNITENOM.AppearanceCell.Image"), System.Drawing.Image)
        Me.ColMainVGTPUNITENOM.AppearanceCell.Options.UseTextOptions = True
        Me.ColMainVGTPUNITENOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColMainVGTPUNITENOM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColMainVGTPUNITENOM, "ColMainVGTPUNITENOM")
        Me.ColMainVGTPUNITENOM.FieldName = "VGTPUNITENOM"
        Me.ColMainVGTPUNITENOM.Name = "ColMainVGTPUNITENOM"
        '
        'ColMainNGTPCOUTUNIT
        '
        Me.ColMainNGTPCOUTUNIT.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ColMainNGTPCOUTUNIT.AppearanceCell.FontSizeDelta"), Integer)
        Me.ColMainNGTPCOUTUNIT.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ColMainNGTPCOUTUNIT.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColMainNGTPCOUTUNIT.AppearanceCell.GradientMode = CType(resources.GetObject("ColMainNGTPCOUTUNIT.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColMainNGTPCOUTUNIT.AppearanceCell.Image = CType(resources.GetObject("ColMainNGTPCOUTUNIT.AppearanceCell.Image"), System.Drawing.Image)
        Me.ColMainNGTPCOUTUNIT.AppearanceCell.Options.UseTextOptions = True
        Me.ColMainNGTPCOUTUNIT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColMainNGTPCOUTUNIT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColMainNGTPCOUTUNIT, "ColMainNGTPCOUTUNIT")
        Me.ColMainNGTPCOUTUNIT.FieldName = "NGTPCOUTUNIT"
        Me.ColMainNGTPCOUTUNIT.Name = "ColMainNGTPCOUTUNIT"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'frmGTPClient
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpBoxLstEquipemetCommun)
        Me.Controls.Add(Me.GrpboxClient)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmGTPClient"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.GrpboxClient.ResumeLayout(False)
        CType(Me.GCGTPClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVGTPClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditGTPZone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxLstEquipemetCommun.ResumeLayout(False)
        CType(Me.GCGTPLstEMALEC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVGTPLstEMALEC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSupprLine As System.Windows.Forms.Button
    Friend WithEvents BtnAddLine As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents GrpboxClient As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBoxLstEquipemetCommun As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSelectAll As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents GCGTPClient As DevExpress.XtraGrid.GridControl
    Private WithEvents GVGTPClient As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColCliIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColCliNGTPCLIID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColCliNCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColCliNGTPMAINID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemGLUpEditGTPZone As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCGTPLstEMALEC As DevExpress.XtraGrid.GridControl
    Private WithEvents GVGTPLstEMALEC As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColMainNGTPMAINID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColMainVGTPLOTNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColCliVGTPLOTNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColCliVGTPEQUIP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColCliVGTPPRECIS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColCliNGTPDURVIE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColCliVGTPUNITENOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColCliNGTPCOUTUNIT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColMainVGTPEQUIP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColMainVGTPPRECIS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColMainNGTPDURVIE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColMainVGTPUNITENOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColMainNGTPCOUTUNIT As DevExpress.XtraGrid.Columns.GridColumn
End Class
