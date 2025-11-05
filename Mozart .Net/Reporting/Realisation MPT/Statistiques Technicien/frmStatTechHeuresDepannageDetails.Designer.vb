<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatTechHeuresDepannageDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatTechHeuresDepannageDetails))
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.ButtonExporter = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.GCRECEPTIONS = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VACTDES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.duree = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DACTDEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CACTSTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NELFHEU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLUpEditGTPLot = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepIGLUpEditViewLot = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColLOTIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLOTNGTPLOTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLOTVGTPLOTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLUpEditUnite = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepItemGLUpEditViewUnite = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColUNITEIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUNITENGTPUNITEID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUNITEVGTPUNITENOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelTech = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCRECEPTIONS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.ButtonExporter)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'ButtonExporter
        '
        resources.ApplyResources(Me.ButtonExporter, "ButtonExporter")
        Me.ButtonExporter.Name = "ButtonExporter"
        Me.ButtonExporter.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'GCRECEPTIONS
        '
        resources.ApplyResources(Me.GCRECEPTIONS, "GCRECEPTIONS")
        '
        '
        '
        Me.GCRECEPTIONS.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCRECEPTIONS.EmbeddedNavigator.AccessibleDescription")
        Me.GCRECEPTIONS.EmbeddedNavigator.AccessibleName = resources.GetString("GCRECEPTIONS.EmbeddedNavigator.AccessibleName")
        Me.GCRECEPTIONS.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCRECEPTIONS.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCRECEPTIONS.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCRECEPTIONS.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCRECEPTIONS.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCRECEPTIONS.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCRECEPTIONS.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCRECEPTIONS.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCRECEPTIONS.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCRECEPTIONS.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCRECEPTIONS.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCRECEPTIONS.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCRECEPTIONS.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCRECEPTIONS.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCRECEPTIONS.EmbeddedNavigator.ToolTip = resources.GetString("GCRECEPTIONS.EmbeddedNavigator.ToolTip")
        Me.GCRECEPTIONS.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCRECEPTIONS.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCRECEPTIONS.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCRECEPTIONS.EmbeddedNavigator.ToolTipTitle")
        Me.GCRECEPTIONS.MainView = Me.GridView1
        Me.GCRECEPTIONS.Name = "GCRECEPTIONS"
        Me.GCRECEPTIONS.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemGLUpEditGTPLot, Me.RepItemGLUpEditUnite})
        Me.GCRECEPTIONS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GridView1.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GridView1.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GridView1.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GridView1.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView1.Appearance.Empty.BackColor = CType(resources.GetObject("GridView1.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.Empty.BackColor2 = CType(resources.GetObject("GridView1.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GridView1.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.Empty.GradientMode = CType(resources.GetObject("GridView1.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.Empty.Image = CType(resources.GetObject("GridView1.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.BackColor = CType(resources.GetObject("GridView1.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GridView1.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GridView1.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GridView1.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GridView1.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GridView1.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.EvenRow.Image = CType(resources.GetObject("GridView1.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GridView1.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GridView1.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GridView1.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GridView1.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GridView1.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GridView1.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GridView1.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GridView1.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GridView1.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GridView1.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GridView1.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GridView1.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GridView1.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.FilterPanel.Image = CType(resources.GetObject("GridView1.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.FixedLine.BackColor = CType(resources.GetObject("GridView1.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GridView1.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.FixedLine.Image = CType(resources.GetObject("GridView1.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GridView1.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GridView1.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GridView1.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GridView1.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.FocusedCell.Image = CType(resources.GetObject("GridView1.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GridView1.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.FocusedRow.BorderColor = CType(resources.GetObject("GridView1.Appearance.FocusedRow.BorderColor"), System.Drawing.Color)
        Me.GridView1.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GridView1.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GridView1.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GridView1.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.FocusedRow.Image = CType(resources.GetObject("GridView1.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GridView1.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GridView1.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GridView1.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GridView1.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GridView1.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GridView1.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.FooterPanel.Image = CType(resources.GetObject("GridView1.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupButton.BackColor = CType(resources.GetObject("GridView1.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GridView1.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GridView1.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GridView1.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.GroupButton.Image = CType(resources.GetObject("GridView1.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GridView1.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GridView1.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GridView1.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GridView1.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GridView1.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GridView1.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.GroupFooter.Image = CType(resources.GetObject("GridView1.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GridView1.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GridView1.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GridView1.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GridView1.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GridView1.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GridView1.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.GroupPanel.Image = CType(resources.GetObject("GridView1.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupRow.BackColor = CType(resources.GetObject("GridView1.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GridView1.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GridView1.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GridView1.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GridView1.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GridView1.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.GroupRow.Image = CType(resources.GetObject("GridView1.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GridView1.Appearance.HeaderPanel.Font = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GridView1.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GridView1.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.HeaderPanel.Image = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GridView1.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.HideSelectionRow.BorderColor = CType(resources.GetObject("GridView1.Appearance.HideSelectionRow.BorderColor"), System.Drawing.Color)
        Me.GridView1.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GridView1.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GridView1.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GridView1.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GridView1.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HorzLine.BackColor = CType(resources.GetObject("GridView1.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GridView1.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.HorzLine.Image = CType(resources.GetObject("GridView1.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.BackColor = CType(resources.GetObject("GridView1.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.OddRow.BorderColor = CType(resources.GetObject("GridView1.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GridView1.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.OddRow.ForeColor = CType(resources.GetObject("GridView1.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GridView1.Appearance.OddRow.GradientMode = CType(resources.GetObject("GridView1.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.OddRow.Image = CType(resources.GetObject("GridView1.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView1.Appearance.Preview.BackColor = CType(resources.GetObject("GridView1.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.Preview.Font = CType(resources.GetObject("GridView1.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GridView1.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.Preview.ForeColor = CType(resources.GetObject("GridView1.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GridView1.Appearance.Preview.GradientMode = CType(resources.GetObject("GridView1.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.Preview.Image = CType(resources.GetObject("GridView1.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.Preview.Options.UseBackColor = True
        Me.GridView1.Appearance.Preview.Options.UseFont = True
        Me.GridView1.Appearance.Preview.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.BackColor = CType(resources.GetObject("GridView1.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.Row.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.Row.ForeColor = CType(resources.GetObject("GridView1.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GridView1.Appearance.Row.GradientMode = CType(resources.GetObject("GridView1.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.Row.Image = CType(resources.GetObject("GridView1.Appearance.Row.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GridView1.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GridView1.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GridView1.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GridView1.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.RowSeparator.Image = CType(resources.GetObject("GridView1.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GridView1.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.SelectedRow.BorderColor = CType(resources.GetObject("GridView1.Appearance.SelectedRow.BorderColor"), System.Drawing.Color)
        Me.GridView1.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GridView1.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GridView1.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GridView1.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.SelectedRow.Image = CType(resources.GetObject("GridView1.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GridView1.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GridView1.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.TopNewRow.Image = CType(resources.GetObject("GridView1.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GridView1.Appearance.VertLine.BackColor = CType(resources.GetObject("GridView1.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GridView1.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GridView1.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GridView1.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GridView1.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GridView1.Appearance.VertLine.GradientMode = CType(resources.GetObject("GridView1.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridView1.Appearance.VertLine.Image = CType(resources.GetObject("GridView1.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GridView1, "GridView1")
        Me.GridView1.ColumnPanelRowHeight = 30
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NPERNUM, Me.VCLINOM, Me.VSITNOM, Me.VACTDES, Me.NDINNUM, Me.duree, Me.DACTDEX, Me.CACTSTA, Me.NELFHEU})
        Me.GridView1.GridControl = Me.GCRECEPTIONS
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.RowHeight = 20
        '
        'NPERNUM
        '
        resources.ApplyResources(Me.NPERNUM, "NPERNUM")
        Me.NPERNUM.FieldName = "NPERNUM"
        Me.NPERNUM.Name = "NPERNUM"
        '
        'VCLINOM
        '
        resources.ApplyResources(Me.VCLINOM, "VCLINOM")
        Me.VCLINOM.FieldName = "VCLINOM"
        Me.VCLINOM.Name = "VCLINOM"
        '
        'VSITNOM
        '
        resources.ApplyResources(Me.VSITNOM, "VSITNOM")
        Me.VSITNOM.FieldName = "VSITNOM"
        Me.VSITNOM.Name = "VSITNOM"
        '
        'VACTDES
        '
        resources.ApplyResources(Me.VACTDES, "VACTDES")
        Me.VACTDES.FieldName = "VACTDES"
        Me.VACTDES.Name = "VACTDES"
        '
        'NDINNUM
        '
        resources.ApplyResources(Me.NDINNUM, "NDINNUM")
        Me.NDINNUM.FieldName = "NDINNUM"
        Me.NDINNUM.Name = "NDINNUM"
        '
        'duree
        '
        resources.ApplyResources(Me.duree, "duree")
        Me.duree.FieldName = "duree"
        Me.duree.Name = "duree"
        '
        'DACTDEX
        '
        resources.ApplyResources(Me.DACTDEX, "DACTDEX")
        Me.DACTDEX.FieldName = "DACTDEX"
        Me.DACTDEX.Name = "DACTDEX"
        '
        'CACTSTA
        '
        resources.ApplyResources(Me.CACTSTA, "CACTSTA")
        Me.CACTSTA.FieldName = "CACTSTA"
        Me.CACTSTA.Name = "CACTSTA"
        '
        'NELFHEU
        '
        resources.ApplyResources(Me.NELFHEU, "NELFHEU")
        Me.NELFHEU.FieldName = "NELFHEU"
        Me.NELFHEU.Name = "NELFHEU"
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
        'LabelTech
        '
        resources.ApplyResources(Me.LabelTech, "LabelTech")
        Me.LabelTech.Name = "LabelTech"
        '
        'frmStatTechHeuresDepannageDetails
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LabelTech)
        Me.Controls.Add(Me.GCRECEPTIONS)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmStatTechHeuresDepannageDetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCRECEPTIONS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
  Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents ButtonExporter As System.Windows.Forms.Button
    Friend WithEvents LabelTech As System.Windows.Forms.Label
    Private WithEvents GCRECEPTIONS As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents NPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VACTDES As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents duree As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DACTDEX As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemGLUpEditGTPLot As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepIGLUpEditViewLot As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColLOTIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColLOTNGTPLOTID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColLOTVGTPLOTNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemGLUpEditUnite As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepItemGLUpEditViewUnite As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColUNITEIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColUNITENGTPUNITEID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColUNITEVGTPUNITENOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents CACTSTA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NELFHEU As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VSITNOM As DevExpress.XtraGrid.Columns.GridColumn
End Class
