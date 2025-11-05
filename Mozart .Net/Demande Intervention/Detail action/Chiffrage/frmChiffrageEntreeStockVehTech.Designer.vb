<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiffrageEntreeStockVehTech
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChiffrageEntreeStockVehTech))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnValider = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GCListeFoRet = New DevExpress.XtraGrid.GridControl()
        Me.GVListeFoRet = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColCHECK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEditCHECK = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GColVTECHNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCCFOCOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVFOUMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVFOUMAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNFOUQTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNFOUQTESTILLENTER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNFOU_IN_VEHTSTOCK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNACTNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNFOUNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNPERNUM_CHAFF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCListeFoRet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeFoRet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEditCHECK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnValider)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnValider
        '
        resources.ApplyResources(Me.BtnValider, "BtnValider")
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'GCListeFoRet
        '
        resources.ApplyResources(Me.GCListeFoRet, "GCListeFoRet")
        '
        '
        '
        Me.GCListeFoRet.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCListeFoRet.EmbeddedNavigator.AccessibleDescription")
        Me.GCListeFoRet.EmbeddedNavigator.AccessibleName = resources.GetString("GCListeFoRet.EmbeddedNavigator.AccessibleName")
        Me.GCListeFoRet.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCListeFoRet.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCListeFoRet.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCListeFoRet.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCListeFoRet.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCListeFoRet.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCListeFoRet.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCListeFoRet.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCListeFoRet.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCListeFoRet.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCListeFoRet.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCListeFoRet.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCListeFoRet.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCListeFoRet.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCListeFoRet.EmbeddedNavigator.ToolTip = resources.GetString("GCListeFoRet.EmbeddedNavigator.ToolTip")
        Me.GCListeFoRet.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCListeFoRet.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCListeFoRet.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCListeFoRet.EmbeddedNavigator.ToolTipTitle")
        Me.GCListeFoRet.MainView = Me.GVListeFoRet
        Me.GCListeFoRet.Name = "GCListeFoRet"
        Me.GCListeFoRet.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEditCHECK})
        Me.GCListeFoRet.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeFoRet})
        '
        'GVListeFoRet
        '
        Me.GVListeFoRet.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVListeFoRet.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVListeFoRet.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVListeFoRet.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVListeFoRet.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVListeFoRet.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVListeFoRet.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVListeFoRet.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVListeFoRet.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVListeFoRet.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVListeFoRet.Appearance.Empty.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVListeFoRet.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.Empty.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.Empty.Image = CType(resources.GetObject("GVListeFoRet.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.Empty.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVListeFoRet.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVListeFoRet.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.EvenRow.Image = CType(resources.GetObject("GVListeFoRet.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVListeFoRet.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVListeFoRet.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVListeFoRet.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVListeFoRet.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVListeFoRet.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVListeFoRet.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVListeFoRet.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVListeFoRet.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVListeFoRet.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.FilterPanel.Image = CType(resources.GetObject("GVListeFoRet.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVListeFoRet.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.FixedLine.Image = CType(resources.GetObject("GVListeFoRet.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVListeFoRet.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.FocusedCell.Image = CType(resources.GetObject("GVListeFoRet.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVListeFoRet.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVListeFoRet.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.FocusedRow.Image = CType(resources.GetObject("GVListeFoRet.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVListeFoRet.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVListeFoRet.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVListeFoRet.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.FooterPanel.Image = CType(resources.GetObject("GVListeFoRet.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVListeFoRet.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVListeFoRet.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVListeFoRet.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.GroupButton.Image = CType(resources.GetObject("GVListeFoRet.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVListeFoRet.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVListeFoRet.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVListeFoRet.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.GroupFooter.Image = CType(resources.GetObject("GVListeFoRet.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVListeFoRet.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVListeFoRet.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVListeFoRet.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVListeFoRet.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.GroupPanel.Image = CType(resources.GetObject("GVListeFoRet.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVListeFoRet.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVListeFoRet.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVListeFoRet.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.GroupRow.Image = CType(resources.GetObject("GVListeFoRet.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVListeFoRet.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVListeFoRet.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVListeFoRet.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVListeFoRet.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVListeFoRet.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVListeFoRet.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVListeFoRet.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVListeFoRet.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeFoRet.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVListeFoRet.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVListeFoRet.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVListeFoRet.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVListeFoRet.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.HorzLine.BorderColor = CType(resources.GetObject("GVListeFoRet.Appearance.HorzLine.BorderColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.HorzLine.Image = CType(resources.GetObject("GVListeFoRet.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVListeFoRet.Appearance.OddRow.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVListeFoRet.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVListeFoRet.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.OddRow.Image = CType(resources.GetObject("GVListeFoRet.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.OddRow.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVListeFoRet.Appearance.OddRow.Options.UseForeColor = True
        Me.GVListeFoRet.Appearance.Preview.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.Preview.Font = CType(resources.GetObject("GVListeFoRet.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVListeFoRet.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.Preview.ForeColor = CType(resources.GetObject("GVListeFoRet.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.Preview.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.Preview.Image = CType(resources.GetObject("GVListeFoRet.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.Preview.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.Preview.Options.UseFont = True
        Me.GVListeFoRet.Appearance.Preview.Options.UseForeColor = True
        Me.GVListeFoRet.Appearance.Row.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.Row.Font = CType(resources.GetObject("GVListeFoRet.Appearance.Row.Font"), System.Drawing.Font)
        Me.GVListeFoRet.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.Row.ForeColor = CType(resources.GetObject("GVListeFoRet.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.Row.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.Row.Image = CType(resources.GetObject("GVListeFoRet.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.Row.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.Row.Options.UseFont = True
        Me.GVListeFoRet.Appearance.Row.Options.UseForeColor = True
        Me.GVListeFoRet.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVListeFoRet.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.RowSeparator.Image = CType(resources.GetObject("GVListeFoRet.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVListeFoRet.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.SelectedRow.Image = CType(resources.GetObject("GVListeFoRet.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVListeFoRet.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.TopNewRow.Image = CType(resources.GetObject("GVListeFoRet.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.VertLine.BackColor = CType(resources.GetObject("GVListeFoRet.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.VertLine.BorderColor = CType(resources.GetObject("GVListeFoRet.Appearance.VertLine.BorderColor"), System.Drawing.Color)
        Me.GVListeFoRet.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVListeFoRet.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVListeFoRet.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVListeFoRet.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFoRet.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVListeFoRet.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFoRet.Appearance.VertLine.Image = CType(resources.GetObject("GVListeFoRet.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVListeFoRet.Appearance.VertLine.Options.UseBackColor = True
        Me.GVListeFoRet.Appearance.VertLine.Options.UseBorderColor = True
        resources.ApplyResources(Me.GVListeFoRet, "GVListeFoRet")
        Me.GVListeFoRet.ColumnPanelRowHeight = 75
        Me.GVListeFoRet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCHECK, Me.GColVTECHNOM, Me.GColCCFOCOD, Me.GColVFOUMAT, Me.GColVFOUMAR, Me.GColNFOUQTE, Me.GColNFOUQTESTILLENTER, Me.GColNFOU_IN_VEHTSTOCK, Me.GColNACTNUM, Me.GColNPERNUM, Me.GColNFOUNUM, Me.GColNCLINUM, Me.GColNPERNUM_CHAFF})
        Me.GVListeFoRet.GridControl = Me.GCListeFoRet
        Me.GVListeFoRet.Name = "GVListeFoRet"
        Me.GVListeFoRet.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListeFoRet.OptionsView.EnableAppearanceOddRow = True
        Me.GVListeFoRet.OptionsView.ShowAutoFilterRow = True
        Me.GVListeFoRet.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVListeFoRet.OptionsView.ShowFooter = True
        Me.GVListeFoRet.OptionsView.ShowGroupPanel = False
        '
        'GColCHECK
        '
        Me.GColCHECK.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColCHECK.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColCHECK.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColCHECK.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColCHECK.AppearanceHeader.GradientMode = CType(resources.GetObject("GColCHECK.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColCHECK.AppearanceHeader.Image = CType(resources.GetObject("GColCHECK.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColCHECK.AppearanceHeader.Options.UseTextOptions = True
        Me.GColCHECK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCHECK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColCHECK.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColCHECK, "GColCHECK")
        Me.GColCHECK.ColumnEdit = Me.RepositoryItemCheckEditCHECK
        Me.GColCHECK.FieldName = "NCOCHE"
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
        'GColVTECHNOM
        '
        Me.GColVTECHNOM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColVTECHNOM.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColVTECHNOM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColVTECHNOM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColVTECHNOM.AppearanceHeader.GradientMode = CType(resources.GetObject("GColVTECHNOM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVTECHNOM.AppearanceHeader.Image = CType(resources.GetObject("GColVTECHNOM.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColVTECHNOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVTECHNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVTECHNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVTECHNOM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVTECHNOM, "GColVTECHNOM")
        Me.GColVTECHNOM.FieldName = "VTECHNOM"
        Me.GColVTECHNOM.Name = "GColVTECHNOM"
        Me.GColVTECHNOM.OptionsColumn.AllowEdit = False
        Me.GColVTECHNOM.OptionsColumn.ReadOnly = True
        Me.GColVTECHNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColCCFOCOD
        '
        Me.GColCCFOCOD.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColCCFOCOD.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColCCFOCOD.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColCCFOCOD.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColCCFOCOD.AppearanceHeader.GradientMode = CType(resources.GetObject("GColCCFOCOD.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColCCFOCOD.AppearanceHeader.Image = CType(resources.GetObject("GColCCFOCOD.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColCCFOCOD.AppearanceHeader.Options.UseTextOptions = True
        Me.GColCCFOCOD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCCFOCOD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColCCFOCOD.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColCCFOCOD, "GColCCFOCOD")
        Me.GColCCFOCOD.FieldName = "CCFOCOD"
        Me.GColCCFOCOD.Name = "GColCCFOCOD"
        Me.GColCCFOCOD.OptionsColumn.AllowEdit = False
        Me.GColCCFOCOD.OptionsColumn.ReadOnly = True
        Me.GColCCFOCOD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVFOUMAT
        '
        Me.GColVFOUMAT.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColVFOUMAT.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColVFOUMAT.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColVFOUMAT.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColVFOUMAT.AppearanceHeader.GradientMode = CType(resources.GetObject("GColVFOUMAT.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVFOUMAT.AppearanceHeader.Image = CType(resources.GetObject("GColVFOUMAT.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColVFOUMAT.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVFOUMAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVFOUMAT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVFOUMAT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVFOUMAT, "GColVFOUMAT")
        Me.GColVFOUMAT.FieldName = "VFOUMAT"
        Me.GColVFOUMAT.Name = "GColVFOUMAT"
        Me.GColVFOUMAT.OptionsColumn.AllowEdit = False
        Me.GColVFOUMAT.OptionsColumn.ReadOnly = True
        Me.GColVFOUMAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVFOUMAR
        '
        Me.GColVFOUMAR.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColVFOUMAR.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColVFOUMAR.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColVFOUMAR.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColVFOUMAR.AppearanceHeader.GradientMode = CType(resources.GetObject("GColVFOUMAR.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVFOUMAR.AppearanceHeader.Image = CType(resources.GetObject("GColVFOUMAR.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColVFOUMAR.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVFOUMAR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVFOUMAR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVFOUMAR.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVFOUMAR, "GColVFOUMAR")
        Me.GColVFOUMAR.FieldName = "VFOUMAR"
        Me.GColVFOUMAR.Name = "GColVFOUMAR"
        Me.GColVFOUMAR.OptionsColumn.AllowEdit = False
        Me.GColVFOUMAR.OptionsColumn.ReadOnly = True
        '
        'GColNFOUQTE
        '
        Me.GColNFOUQTE.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColNFOUQTE.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColNFOUQTE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColNFOUQTE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColNFOUQTE.AppearanceHeader.GradientMode = CType(resources.GetObject("GColNFOUQTE.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColNFOUQTE.AppearanceHeader.Image = CType(resources.GetObject("GColNFOUQTE.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColNFOUQTE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColNFOUQTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNFOUQTE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColNFOUQTE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColNFOUQTE, "GColNFOUQTE")
        Me.GColNFOUQTE.FieldName = "NFOUQTE"
        Me.GColNFOUQTE.Name = "GColNFOUQTE"
        Me.GColNFOUQTE.OptionsColumn.AllowEdit = False
        Me.GColNFOUQTE.OptionsColumn.ReadOnly = True
        '
        'GColNFOUQTESTILLENTER
        '
        Me.GColNFOUQTESTILLENTER.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColNFOUQTESTILLENTER.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColNFOUQTESTILLENTER.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColNFOUQTESTILLENTER.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColNFOUQTESTILLENTER.AppearanceHeader.GradientMode = CType(resources.GetObject("GColNFOUQTESTILLENTER.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColNFOUQTESTILLENTER.AppearanceHeader.Image = CType(resources.GetObject("GColNFOUQTESTILLENTER.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColNFOUQTESTILLENTER.AppearanceHeader.Options.UseTextOptions = True
        Me.GColNFOUQTESTILLENTER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNFOUQTESTILLENTER.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColNFOUQTESTILLENTER.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColNFOUQTESTILLENTER, "GColNFOUQTESTILLENTER")
        Me.GColNFOUQTESTILLENTER.FieldName = "NFOUQTESTILLENTER"
        Me.GColNFOUQTESTILLENTER.Name = "GColNFOUQTESTILLENTER"
        Me.GColNFOUQTESTILLENTER.OptionsColumn.AllowEdit = False
        Me.GColNFOUQTESTILLENTER.OptionsColumn.ReadOnly = True
        '
        'GColNFOU_IN_VEHTSTOCK
        '
        Me.GColNFOU_IN_VEHTSTOCK.AppearanceCell.BackColor = CType(resources.GetObject("GColNFOU_IN_VEHTSTOCK.AppearanceCell.BackColor"), System.Drawing.Color)
        Me.GColNFOU_IN_VEHTSTOCK.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColNFOU_IN_VEHTSTOCK.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColNFOU_IN_VEHTSTOCK.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColNFOU_IN_VEHTSTOCK.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColNFOU_IN_VEHTSTOCK.AppearanceCell.GradientMode = CType(resources.GetObject("GColNFOU_IN_VEHTSTOCK.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColNFOU_IN_VEHTSTOCK.AppearanceCell.Image = CType(resources.GetObject("GColNFOU_IN_VEHTSTOCK.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColNFOU_IN_VEHTSTOCK.AppearanceCell.Options.UseBackColor = True
        Me.GColNFOU_IN_VEHTSTOCK.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColNFOU_IN_VEHTSTOCK.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColNFOU_IN_VEHTSTOCK.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColNFOU_IN_VEHTSTOCK.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColNFOU_IN_VEHTSTOCK.AppearanceHeader.GradientMode = CType(resources.GetObject("GColNFOU_IN_VEHTSTOCK.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColNFOU_IN_VEHTSTOCK.AppearanceHeader.Image = CType(resources.GetObject("GColNFOU_IN_VEHTSTOCK.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColNFOU_IN_VEHTSTOCK.AppearanceHeader.Options.UseTextOptions = True
        Me.GColNFOU_IN_VEHTSTOCK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNFOU_IN_VEHTSTOCK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColNFOU_IN_VEHTSTOCK.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColNFOU_IN_VEHTSTOCK, "GColNFOU_IN_VEHTSTOCK")
        Me.GColNFOU_IN_VEHTSTOCK.FieldName = "NFOUVEH_IN"
        Me.GColNFOU_IN_VEHTSTOCK.Name = "GColNFOU_IN_VEHTSTOCK"
        '
        'GColNACTNUM
        '
        resources.ApplyResources(Me.GColNACTNUM, "GColNACTNUM")
        Me.GColNACTNUM.FieldName = "NACTNUM"
        Me.GColNACTNUM.Name = "GColNACTNUM"
        '
        'GColNPERNUM
        '
        resources.ApplyResources(Me.GColNPERNUM, "GColNPERNUM")
        Me.GColNPERNUM.FieldName = "NPERNUM"
        Me.GColNPERNUM.Name = "GColNPERNUM"
        Me.GColNPERNUM.OptionsColumn.ReadOnly = True
        '
        'GColNFOUNUM
        '
        Me.GColNFOUNUM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColNFOUNUM.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColNFOUNUM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColNFOUNUM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColNFOUNUM.AppearanceHeader.GradientMode = CType(resources.GetObject("GColNFOUNUM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColNFOUNUM.AppearanceHeader.Image = CType(resources.GetObject("GColNFOUNUM.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColNFOUNUM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColNFOUNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNFOUNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColNFOUNUM, "GColNFOUNUM")
        Me.GColNFOUNUM.FieldName = "NFOUNUM"
        Me.GColNFOUNUM.Name = "GColNFOUNUM"
        Me.GColNFOUNUM.OptionsColumn.AllowEdit = False
        Me.GColNFOUNUM.OptionsColumn.ReadOnly = True
        Me.GColNFOUNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNCLINUM
        '
        resources.ApplyResources(Me.GColNCLINUM, "GColNCLINUM")
        Me.GColNCLINUM.FieldName = "NCLINUM"
        Me.GColNCLINUM.Name = "GColNCLINUM"
        '
        'GColNPERNUM_CHAFF
        '
        resources.ApplyResources(Me.GColNPERNUM_CHAFF, "GColNPERNUM_CHAFF")
        Me.GColNPERNUM_CHAFF.FieldName = "NPERNUM_CHAFF"
        Me.GColNPERNUM_CHAFF.Name = "GColNPERNUM_CHAFF"
        '
        'frmChiffrageEntreeStockVehTech
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GCListeFoRet)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "frmChiffrageEntreeStockVehTech"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCListeFoRet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeFoRet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEditCHECK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnValider As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Private WithEvents GCListeFoRet As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeFoRet As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColCHECK As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepositoryItemCheckEditCHECK As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents GColNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVTECHNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNFOUNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCCFOCOD As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVFOUMAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVFOUMAR As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNFOUQTE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNFOUQTESTILLENTER As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNACTNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNFOU_IN_VEHTSTOCK As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNPERNUM_CHAFF As DevExpress.XtraGrid.Columns.GridColumn
End Class
