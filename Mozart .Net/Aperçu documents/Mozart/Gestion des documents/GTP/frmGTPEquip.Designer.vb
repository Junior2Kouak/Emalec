<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGTPEquip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGTPEquip))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnGestZone = New System.Windows.Forms.Button()
        Me.BtnGestUnite = New System.Windows.Forms.Button()
        Me.BtnGestLot = New System.Windows.Forms.Button()
        Me.BtnSupprLine = New System.Windows.Forms.Button()
        Me.BtnAddLine = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GCGTPEMALEC = New DevExpress.XtraGrid.GridControl()
        Me.GVGTPEMALEC = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNGTPMAINID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNGTPLOTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLUpEditGTPLot = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepIGLUpEditViewLot = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColLOTIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLOTNGTPLOTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLOTVGTPLOTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVGTPEQUIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVGTPPRECIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNGTPDURVIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNGTPUNITEID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLUpEditUnite = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepItemGLUpEditViewUnite = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColUNITEIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUNITENGTPUNITEID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUNITEVGTPUNITENOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNGTPCOUTUNIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCGTPEMALEC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVGTPEMALEC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnGestZone)
        Me.GrpActions.Controls.Add(Me.BtnGestUnite)
        Me.GrpActions.Controls.Add(Me.BtnGestLot)
        Me.GrpActions.Controls.Add(Me.BtnSupprLine)
        Me.GrpActions.Controls.Add(Me.BtnAddLine)
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Controls.Add(Me.BtnSave)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnGestZone
        '
        resources.ApplyResources(Me.BtnGestZone, "BtnGestZone")
        Me.BtnGestZone.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.BtnGestZone.Name = "BtnGestZone"
        Me.BtnGestZone.UseVisualStyleBackColor = False
        '
        'BtnGestUnite
        '
        resources.ApplyResources(Me.BtnGestUnite, "BtnGestUnite")
        Me.BtnGestUnite.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.BtnGestUnite.Name = "BtnGestUnite"
        Me.BtnGestUnite.UseVisualStyleBackColor = False
        '
        'BtnGestLot
        '
        resources.ApplyResources(Me.BtnGestLot, "BtnGestLot")
        Me.BtnGestLot.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.BtnGestLot.Name = "BtnGestLot"
        Me.BtnGestLot.UseVisualStyleBackColor = False
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
        'GCGTPEMALEC
        '
        resources.ApplyResources(Me.GCGTPEMALEC, "GCGTPEMALEC")
        '
        '
        '
        Me.GCGTPEMALEC.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCGTPEMALEC.EmbeddedNavigator.AccessibleDescription")
        Me.GCGTPEMALEC.EmbeddedNavigator.AccessibleName = resources.GetString("GCGTPEMALEC.EmbeddedNavigator.AccessibleName")
        Me.GCGTPEMALEC.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCGTPEMALEC.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCGTPEMALEC.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCGTPEMALEC.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCGTPEMALEC.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCGTPEMALEC.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCGTPEMALEC.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCGTPEMALEC.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCGTPEMALEC.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCGTPEMALEC.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCGTPEMALEC.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCGTPEMALEC.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCGTPEMALEC.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCGTPEMALEC.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCGTPEMALEC.EmbeddedNavigator.ToolTip = resources.GetString("GCGTPEMALEC.EmbeddedNavigator.ToolTip")
        Me.GCGTPEMALEC.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCGTPEMALEC.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCGTPEMALEC.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCGTPEMALEC.EmbeddedNavigator.ToolTipTitle")
        Me.GCGTPEMALEC.MainView = Me.GVGTPEMALEC
        Me.GCGTPEMALEC.Name = "GCGTPEMALEC"
        Me.GCGTPEMALEC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemGLUpEditGTPLot, Me.RepItemGLUpEditUnite})
        Me.GCGTPEMALEC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVGTPEMALEC})
        '
        'GVGTPEMALEC
        '
        Me.GVGTPEMALEC.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVGTPEMALEC.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVGTPEMALEC.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVGTPEMALEC.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVGTPEMALEC.Appearance.Empty.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVGTPEMALEC.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.Empty.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.Empty.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.Empty.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.EvenRow.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVGTPEMALEC.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVGTPEMALEC.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVGTPEMALEC.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVGTPEMALEC.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVGTPEMALEC.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.FilterPanel.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVGTPEMALEC.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.FixedLine.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.FocusedCell.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVGTPEMALEC.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.FocusedRow.BorderColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.FocusedRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.FocusedRow.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVGTPEMALEC.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVGTPEMALEC.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.FooterPanel.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVGTPEMALEC.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVGTPEMALEC.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.GroupButton.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVGTPEMALEC.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.GroupFooter.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVGTPEMALEC.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVGTPEMALEC.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.GroupPanel.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVGTPEMALEC.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.GroupRow.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVGTPEMALEC.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVGTPEMALEC.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVGTPEMALEC.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVGTPEMALEC.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVGTPEMALEC.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVGTPEMALEC.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVGTPEMALEC.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVGTPEMALEC.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVGTPEMALEC.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVGTPEMALEC.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVGTPEMALEC.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.HideSelectionRow.BorderColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.HideSelectionRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVGTPEMALEC.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVGTPEMALEC.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.HorzLine.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.OddRow.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.OddRow.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.OddRow.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVGTPEMALEC.Appearance.OddRow.Options.UseForeColor = True
        Me.GVGTPEMALEC.Appearance.Preview.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.Preview.Font = CType(resources.GetObject("GVGTPEMALEC.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVGTPEMALEC.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.Preview.ForeColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.Preview.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.Preview.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.Preview.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.Preview.Options.UseFont = True
        Me.GVGTPEMALEC.Appearance.Preview.Options.UseForeColor = True
        Me.GVGTPEMALEC.Appearance.Row.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.Row.ForeColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.Row.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.Row.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.Row.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.Row.Options.UseForeColor = True
        Me.GVGTPEMALEC.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVGTPEMALEC.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.RowSeparator.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.SelectedRow.BorderColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.SelectedRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.SelectedRow.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GVGTPEMALEC.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVGTPEMALEC.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.TopNewRow.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVGTPEMALEC.Appearance.VertLine.BackColor = CType(resources.GetObject("GVGTPEMALEC.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVGTPEMALEC.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVGTPEMALEC.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVGTPEMALEC.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPEMALEC.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVGTPEMALEC.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPEMALEC.Appearance.VertLine.Image = CType(resources.GetObject("GVGTPEMALEC.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVGTPEMALEC.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVGTPEMALEC, "GVGTPEMALEC")
        Me.GVGTPEMALEC.ColumnPanelRowHeight = 60
        Me.GVGTPEMALEC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIDTMP, Me.ColNGTPMAINID, Me.ColNGTPLOTID, Me.ColVGTPEQUIP, Me.ColVGTPPRECIS, Me.ColNGTPDURVIE, Me.ColNGTPUNITEID, Me.ColNGTPCOUTUNIT})
        Me.GVGTPEMALEC.GridControl = Me.GCGTPEMALEC
        Me.GVGTPEMALEC.Name = "GVGTPEMALEC"
        Me.GVGTPEMALEC.OptionsNavigation.AutoFocusNewRow = True
        Me.GVGTPEMALEC.OptionsView.EnableAppearanceEvenRow = True
        Me.GVGTPEMALEC.OptionsView.EnableAppearanceOddRow = True
        Me.GVGTPEMALEC.OptionsView.ShowAutoFilterRow = True
        Me.GVGTPEMALEC.OptionsView.ShowFooter = True
        Me.GVGTPEMALEC.OptionsView.ShowGroupPanel = False
        Me.GVGTPEMALEC.RowHeight = 20
        '
        'ColIDTMP
        '
        resources.ApplyResources(Me.ColIDTMP, "ColIDTMP")
        Me.ColIDTMP.FieldName = "IDTMP"
        Me.ColIDTMP.Name = "ColIDTMP"
        '
        'ColNGTPMAINID
        '
        resources.ApplyResources(Me.ColNGTPMAINID, "ColNGTPMAINID")
        Me.ColNGTPMAINID.FieldName = "NGTPMAINID"
        Me.ColNGTPMAINID.Name = "ColNGTPMAINID"
        '
        'ColNGTPLOTID
        '
        resources.ApplyResources(Me.ColNGTPLOTID, "ColNGTPLOTID")
        Me.ColNGTPLOTID.ColumnEdit = Me.RepItemGLUpEditGTPLot
        Me.ColNGTPLOTID.FieldName = "NGTPLOTID"
        Me.ColNGTPLOTID.Name = "ColNGTPLOTID"
        '
        'RepItemGLUpEditGTPLot
        '
        resources.ApplyResources(Me.RepItemGLUpEditGTPLot, "RepItemGLUpEditGTPLot")
        Me.RepItemGLUpEditGTPLot.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemGLUpEditGTPLot.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepItemGLUpEditGTPLot.DisplayMember = "VGTPLOTNOM"
        Me.RepItemGLUpEditGTPLot.Name = "RepItemGLUpEditGTPLot"
        Me.RepItemGLUpEditGTPLot.ValueMember = "NGTPLOTID"
        Me.RepItemGLUpEditGTPLot.View = Me.RepIGLUpEditViewLot
        '
        'RepIGLUpEditViewLot
        '
        resources.ApplyResources(Me.RepIGLUpEditViewLot, "RepIGLUpEditViewLot")
        Me.RepIGLUpEditViewLot.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColLOTIDTMP, Me.ColLOTNGTPLOTID, Me.ColLOTVGTPLOTNOM})
        Me.RepIGLUpEditViewLot.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepIGLUpEditViewLot.Name = "RepIGLUpEditViewLot"
        Me.RepIGLUpEditViewLot.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepIGLUpEditViewLot.OptionsView.ShowGroupPanel = False
        '
        'ColLOTIDTMP
        '
        resources.ApplyResources(Me.ColLOTIDTMP, "ColLOTIDTMP")
        Me.ColLOTIDTMP.FieldName = "IDTMP"
        Me.ColLOTIDTMP.Name = "ColLOTIDTMP"
        '
        'ColLOTNGTPLOTID
        '
        resources.ApplyResources(Me.ColLOTNGTPLOTID, "ColLOTNGTPLOTID")
        Me.ColLOTNGTPLOTID.FieldName = "NGTPLOTID"
        Me.ColLOTNGTPLOTID.Name = "ColLOTNGTPLOTID"
        '
        'ColLOTVGTPLOTNOM
        '
        resources.ApplyResources(Me.ColLOTVGTPLOTNOM, "ColLOTVGTPLOTNOM")
        Me.ColLOTVGTPLOTNOM.FieldName = "VGTPLOTNOM"
        Me.ColLOTVGTPLOTNOM.Name = "ColLOTVGTPLOTNOM"
        '
        'ColVGTPEQUIP
        '
        resources.ApplyResources(Me.ColVGTPEQUIP, "ColVGTPEQUIP")
        Me.ColVGTPEQUIP.FieldName = "VGTPEQUIP"
        Me.ColVGTPEQUIP.Name = "ColVGTPEQUIP"
        '
        'ColVGTPPRECIS
        '
        resources.ApplyResources(Me.ColVGTPPRECIS, "ColVGTPPRECIS")
        Me.ColVGTPPRECIS.FieldName = "VGTPPRECIS"
        Me.ColVGTPPRECIS.Name = "ColVGTPPRECIS"
        '
        'ColNGTPDURVIE
        '
        Me.ColNGTPDURVIE.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ColNGTPDURVIE.AppearanceCell.FontSizeDelta"), Integer)
        Me.ColNGTPDURVIE.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ColNGTPDURVIE.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColNGTPDURVIE.AppearanceCell.GradientMode = CType(resources.GetObject("ColNGTPDURVIE.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColNGTPDURVIE.AppearanceCell.Image = CType(resources.GetObject("ColNGTPDURVIE.AppearanceCell.Image"), System.Drawing.Image)
        Me.ColNGTPDURVIE.AppearanceCell.Options.UseTextOptions = True
        Me.ColNGTPDURVIE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNGTPDURVIE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColNGTPDURVIE, "ColNGTPDURVIE")
        Me.ColNGTPDURVIE.FieldName = "NGTPDURVIE"
        Me.ColNGTPDURVIE.Name = "ColNGTPDURVIE"
        '
        'ColNGTPUNITEID
        '
        Me.ColNGTPUNITEID.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ColNGTPUNITEID.AppearanceCell.FontSizeDelta"), Integer)
        Me.ColNGTPUNITEID.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ColNGTPUNITEID.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColNGTPUNITEID.AppearanceCell.GradientMode = CType(resources.GetObject("ColNGTPUNITEID.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColNGTPUNITEID.AppearanceCell.Image = CType(resources.GetObject("ColNGTPUNITEID.AppearanceCell.Image"), System.Drawing.Image)
        Me.ColNGTPUNITEID.AppearanceCell.Options.UseTextOptions = True
        Me.ColNGTPUNITEID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNGTPUNITEID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColNGTPUNITEID, "ColNGTPUNITEID")
        Me.ColNGTPUNITEID.ColumnEdit = Me.RepItemGLUpEditUnite
        Me.ColNGTPUNITEID.FieldName = "NGTPUNITEID"
        Me.ColNGTPUNITEID.Name = "ColNGTPUNITEID"
        '
        'RepItemGLUpEditUnite
        '
        resources.ApplyResources(Me.RepItemGLUpEditUnite, "RepItemGLUpEditUnite")
        Me.RepItemGLUpEditUnite.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemGLUpEditUnite.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepItemGLUpEditUnite.DisplayMember = "VGTPUNITENOM"
        Me.RepItemGLUpEditUnite.Name = "RepItemGLUpEditUnite"
        Me.RepItemGLUpEditUnite.ValueMember = "NGTPUNITEID"
        Me.RepItemGLUpEditUnite.View = Me.RepItemGLUpEditViewUnite
        '
        'RepItemGLUpEditViewUnite
        '
        resources.ApplyResources(Me.RepItemGLUpEditViewUnite, "RepItemGLUpEditViewUnite")
        Me.RepItemGLUpEditViewUnite.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColUNITEIDTMP, Me.ColUNITENGTPUNITEID, Me.ColUNITEVGTPUNITENOM})
        Me.RepItemGLUpEditViewUnite.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepItemGLUpEditViewUnite.Name = "RepItemGLUpEditViewUnite"
        Me.RepItemGLUpEditViewUnite.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepItemGLUpEditViewUnite.OptionsView.ShowGroupPanel = False
        '
        'ColUNITEIDTMP
        '
        resources.ApplyResources(Me.ColUNITEIDTMP, "ColUNITEIDTMP")
        Me.ColUNITEIDTMP.FieldName = "IDTMP"
        Me.ColUNITEIDTMP.Name = "ColUNITEIDTMP"
        '
        'ColUNITENGTPUNITEID
        '
        resources.ApplyResources(Me.ColUNITENGTPUNITEID, "ColUNITENGTPUNITEID")
        Me.ColUNITENGTPUNITEID.FieldName = "NGTPUNITEID"
        Me.ColUNITENGTPUNITEID.Name = "ColUNITENGTPUNITEID"
        '
        'ColUNITEVGTPUNITENOM
        '
        resources.ApplyResources(Me.ColUNITEVGTPUNITENOM, "ColUNITEVGTPUNITENOM")
        Me.ColUNITEVGTPUNITENOM.FieldName = "VGTPUNITENOM"
        Me.ColUNITEVGTPUNITENOM.Name = "ColUNITEVGTPUNITENOM"
        '
        'ColNGTPCOUTUNIT
        '
        Me.ColNGTPCOUTUNIT.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ColNGTPCOUTUNIT.AppearanceCell.FontSizeDelta"), Integer)
        Me.ColNGTPCOUTUNIT.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ColNGTPCOUTUNIT.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColNGTPCOUTUNIT.AppearanceCell.GradientMode = CType(resources.GetObject("ColNGTPCOUTUNIT.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColNGTPCOUTUNIT.AppearanceCell.Image = CType(resources.GetObject("ColNGTPCOUTUNIT.AppearanceCell.Image"), System.Drawing.Image)
        Me.ColNGTPCOUTUNIT.AppearanceCell.Options.UseTextOptions = True
        Me.ColNGTPCOUTUNIT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColNGTPCOUTUNIT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColNGTPCOUTUNIT, "ColNGTPCOUTUNIT")
        Me.ColNGTPCOUTUNIT.DisplayFormat.FormatString = "### ### ##0. 000"
        Me.ColNGTPCOUTUNIT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColNGTPCOUTUNIT.FieldName = "NGTPCOUTUNIT"
        Me.ColNGTPCOUTUNIT.Name = "ColNGTPCOUTUNIT"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'frmGTPEquip
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GCGTPEMALEC)
        Me.Name = "frmGTPEquip"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCGTPEMALEC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVGTPEMALEC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnSupprLine As System.Windows.Forms.Button
    Friend WithEvents BtnAddLine As System.Windows.Forms.Button
    Friend WithEvents BtnGestZone As System.Windows.Forms.Button
    Friend WithEvents BtnGestUnite As System.Windows.Forms.Button
    Friend WithEvents BtnGestLot As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents GCGTPEMALEC As DevExpress.XtraGrid.GridControl
    Private WithEvents GVGTPEMALEC As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColNGTPMAINID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNGTPLOTID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVGTPEQUIP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVGTPPRECIS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNGTPDURVIE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNGTPUNITEID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNGTPCOUTUNIT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemGLUpEditGTPLot As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepIGLUpEditViewLot As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColLOTNGTPLOTID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColLOTVGTPLOTNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColLOTIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemGLUpEditUnite As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepItemGLUpEditViewUnite As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColUNITEIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColUNITENGTPUNITEID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColUNITEVGTPUNITENOM As DevExpress.XtraGrid.Columns.GridColumn
End Class
