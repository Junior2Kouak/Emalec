<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailsDevisParChaff
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
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetailsDevisParChaff))
Me.GroupBox1 = New System.Windows.Forms.GroupBox()
Me.BtnFermer = New System.Windows.Forms.Button()
Me.ColLOTNGTPLOTID = New DevExpress.XtraGrid.Columns.GridColumn()
Me.ColLOTIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
Me.RepIGLUpEditViewLot = New DevExpress.XtraGrid.Views.Grid.GridView()
Me.ColLOTVGTPLOTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
Me.RepItemGLUpEditGTPLot = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
Me.RepItemGLUpEditUnite = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
Me.RepItemGLUpEditViewUnite = New DevExpress.XtraGrid.Views.Grid.GridView()
Me.ColUNITEIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
Me.ColUNITENGTPUNITEID = New DevExpress.XtraGrid.Columns.GridColumn()
Me.ColUNITEVGTPUNITENOM = New DevExpress.XtraGrid.Columns.GridColumn()
Me.vactdes = New DevExpress.XtraGrid.Columns.GridColumn()
Me.ndclht = New DevExpress.XtraGrid.Columns.GridColumn()
Me.vsitnom = New DevExpress.XtraGrid.Columns.GridColumn()
Me.LblDetails = New System.Windows.Forms.Label()
Me.GcDevis = New DevExpress.XtraGrid.GridControl()
Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
Me.ndclnum = New DevExpress.XtraGrid.Columns.GridColumn()
Me.ddcldat = New DevExpress.XtraGrid.Columns.GridColumn()
Me.ndinnum = New DevExpress.XtraGrid.Columns.GridColumn()
Me.vclinom = New DevExpress.XtraGrid.Columns.GridColumn()
Me.LblCreesTranformes = New System.Windows.Forms.Label()
Me.LblChaff = New System.Windows.Forms.Label()
Me.LblNomChaff = New System.Windows.Forms.Label()
Me.LblDateFin = New System.Windows.Forms.Label()
Me.LblEtLe = New System.Windows.Forms.Label()
Me.LblDteDebut = New System.Windows.Forms.Label()
Me.Label2 = New System.Windows.Forms.Label()
Me.Label1 = New System.Windows.Forms.Label()
Me.LblCli = New System.Windows.Forms.Label()
Me.LblPeriode = New System.Windows.Forms.Label()
Me.GroupBox1.SuspendLayout()
CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.GcDevis, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'GroupBox1
'
resources.ApplyResources(Me.GroupBox1, "GroupBox1")
Me.GroupBox1.Controls.Add(Me.BtnFermer)
Me.GroupBox1.Name = "GroupBox1"
Me.GroupBox1.TabStop = False
'
'BtnFermer
'
resources.ApplyResources(Me.BtnFermer, "BtnFermer")
Me.BtnFermer.Name = "BtnFermer"
Me.BtnFermer.UseVisualStyleBackColor = True
'
'ColLOTNGTPLOTID
'
resources.ApplyResources(Me.ColLOTNGTPLOTID, "ColLOTNGTPLOTID")
Me.ColLOTNGTPLOTID.FieldName = "NGTPLOTID"
Me.ColLOTNGTPLOTID.Name = "ColLOTNGTPLOTID"
'
'ColLOTIDTMP
'
resources.ApplyResources(Me.ColLOTIDTMP, "ColLOTIDTMP")
Me.ColLOTIDTMP.FieldName = "IDTMP"
Me.ColLOTIDTMP.Name = "ColLOTIDTMP"
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
'ColLOTVGTPLOTNOM
'
resources.ApplyResources(Me.ColLOTVGTPLOTNOM, "ColLOTVGTPLOTNOM")
Me.ColLOTVGTPLOTNOM.FieldName = "VGTPLOTNOM"
Me.ColLOTVGTPLOTNOM.Name = "ColLOTVGTPLOTNOM"
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
'vactdes
'
resources.ApplyResources(Me.vactdes, "vactdes")
Me.vactdes.FieldName = "VACTDES"
Me.vactdes.Name = "vactdes"
'
'ndclht
'
Me.ndclht.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ndclht.AppearanceCell.FontSizeDelta"), Integer)
Me.ndclht.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ndclht.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
Me.ndclht.AppearanceCell.GradientMode = CType(resources.GetObject("ndclht.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.ndclht.AppearanceCell.Image = CType(resources.GetObject("ndclht.AppearanceCell.Image"), System.Drawing.Image)
Me.ndclht.AppearanceCell.Options.UseTextOptions = True
Me.ndclht.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
resources.ApplyResources(Me.ndclht, "ndclht")
Me.ndclht.DisplayFormat.FormatString = "{0:n0} €"
Me.ndclht.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
Me.ndclht.FieldName = "NDCLHT"
Me.ndclht.Name = "ndclht"
Me.ndclht.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ndclht.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ndclht.Summary1"), resources.GetString("ndclht.Summary2"))})
'
'vsitnom
'
resources.ApplyResources(Me.vsitnom, "vsitnom")
Me.vsitnom.FieldName = "VSITNOM"
Me.vsitnom.Name = "vsitnom"
'
'LblDetails
'
resources.ApplyResources(Me.LblDetails, "LblDetails")
Me.LblDetails.ForeColor = System.Drawing.SystemColors.GrayText
Me.LblDetails.Name = "LblDetails"
'
'GcDevis
'
resources.ApplyResources(Me.GcDevis, "GcDevis")
Me.GcDevis.EmbeddedNavigator.AccessibleDescription = resources.GetString("GcDevis.EmbeddedNavigator.AccessibleDescription")
Me.GcDevis.EmbeddedNavigator.AccessibleName = resources.GetString("GcDevis.EmbeddedNavigator.AccessibleName")
Me.GcDevis.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GcDevis.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
Me.GcDevis.EmbeddedNavigator.Anchor = CType(resources.GetObject("GcDevis.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
Me.GcDevis.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GcDevis.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
Me.GcDevis.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GcDevis.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
Me.GcDevis.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GcDevis.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
Me.GcDevis.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GcDevis.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
Me.GcDevis.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GcDevis.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
Me.GcDevis.EmbeddedNavigator.ToolTip = resources.GetString("GcDevis.EmbeddedNavigator.ToolTip")
Me.GcDevis.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GcDevis.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
Me.GcDevis.EmbeddedNavigator.ToolTipTitle = resources.GetString("GcDevis.EmbeddedNavigator.ToolTipTitle")
Me.GcDevis.MainView = Me.GVStat
Me.GcDevis.Name = "GcDevis"
Me.GcDevis.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemGLUpEditGTPLot, Me.RepItemGLUpEditUnite})
Me.GcDevis.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStat})
'
'GVStat
'
Me.GVStat.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVStat.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVStat.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
Me.GVStat.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
Me.GVStat.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVStat.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
Me.GVStat.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVStat.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVStat.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
Me.GVStat.Appearance.ColumnFilterButton.Options.UseBackColor = True
Me.GVStat.Appearance.ColumnFilterButton.Options.UseBorderColor = True
Me.GVStat.Appearance.ColumnFilterButton.Options.UseForeColor = True
Me.GVStat.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVStat.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVStat.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
Me.GVStat.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
Me.GVStat.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVStat.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
Me.GVStat.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVStat.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVStat.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
Me.GVStat.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
Me.GVStat.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
Me.GVStat.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
Me.GVStat.Appearance.Empty.BackColor = CType(resources.GetObject("GVStat.Appearance.Empty.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVStat.Appearance.Empty.BackColor2"), System.Drawing.Color)
Me.GVStat.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.Empty.FontSizeDelta"), Integer)
Me.GVStat.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.Empty.GradientMode = CType(resources.GetObject("GVStat.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.Empty.Image = CType(resources.GetObject("GVStat.Appearance.Empty.Image"), System.Drawing.Image)
Me.GVStat.Appearance.Empty.Options.UseBackColor = True
Me.GVStat.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVStat.Appearance.EvenRow.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVStat.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
Me.GVStat.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.EvenRow.FontSizeDelta"), Integer)
Me.GVStat.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVStat.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
Me.GVStat.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVStat.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.EvenRow.Image = CType(resources.GetObject("GVStat.Appearance.EvenRow.Image"), System.Drawing.Image)
Me.GVStat.Appearance.EvenRow.Options.UseBackColor = True
Me.GVStat.Appearance.EvenRow.Options.UseBorderColor = True
Me.GVStat.Appearance.EvenRow.Options.UseForeColor = True
Me.GVStat.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVStat.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVStat.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
Me.GVStat.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
Me.GVStat.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVStat.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
Me.GVStat.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVStat.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVStat.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
Me.GVStat.Appearance.FilterCloseButton.Options.UseBackColor = True
Me.GVStat.Appearance.FilterCloseButton.Options.UseBorderColor = True
Me.GVStat.Appearance.FilterCloseButton.Options.UseForeColor = True
Me.GVStat.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVStat.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVStat.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
Me.GVStat.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.FilterPanel.FontSizeDelta"), Integer)
Me.GVStat.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVStat.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
Me.GVStat.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVStat.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.FilterPanel.Image = CType(resources.GetObject("GVStat.Appearance.FilterPanel.Image"), System.Drawing.Image)
Me.GVStat.Appearance.FilterPanel.Options.UseBackColor = True
Me.GVStat.Appearance.FilterPanel.Options.UseForeColor = True
Me.GVStat.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVStat.Appearance.FixedLine.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.FixedLine.FontSizeDelta"), Integer)
Me.GVStat.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVStat.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.FixedLine.Image = CType(resources.GetObject("GVStat.Appearance.FixedLine.Image"), System.Drawing.Image)
Me.GVStat.Appearance.FixedLine.Options.UseBackColor = True
Me.GVStat.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVStat.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.FocusedCell.FontSizeDelta"), Integer)
Me.GVStat.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVStat.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
Me.GVStat.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVStat.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.FocusedCell.Image = CType(resources.GetObject("GVStat.Appearance.FocusedCell.Image"), System.Drawing.Image)
Me.GVStat.Appearance.FocusedCell.Options.UseBackColor = True
Me.GVStat.Appearance.FocusedCell.Options.UseForeColor = True
Me.GVStat.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVStat.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.FocusedRow.BorderColor = CType(resources.GetObject("GVStat.Appearance.FocusedRow.BorderColor"), System.Drawing.Color)
Me.GVStat.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.FocusedRow.FontSizeDelta"), Integer)
Me.GVStat.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVStat.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
Me.GVStat.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVStat.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.FocusedRow.Image = CType(resources.GetObject("GVStat.Appearance.FocusedRow.Image"), System.Drawing.Image)
Me.GVStat.Appearance.FocusedRow.Options.UseBackColor = True
Me.GVStat.Appearance.FocusedRow.Options.UseBorderColor = True
Me.GVStat.Appearance.FocusedRow.Options.UseForeColor = True
Me.GVStat.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVStat.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVStat.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
Me.GVStat.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.FooterPanel.FontSizeDelta"), Integer)
Me.GVStat.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVStat.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
Me.GVStat.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVStat.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.FooterPanel.Image = CType(resources.GetObject("GVStat.Appearance.FooterPanel.Image"), System.Drawing.Image)
Me.GVStat.Appearance.FooterPanel.Options.UseBackColor = True
Me.GVStat.Appearance.FooterPanel.Options.UseBorderColor = True
Me.GVStat.Appearance.FooterPanel.Options.UseForeColor = True
Me.GVStat.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVStat.Appearance.GroupButton.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVStat.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
Me.GVStat.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.GroupButton.FontSizeDelta"), Integer)
Me.GVStat.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVStat.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.GroupButton.Image = CType(resources.GetObject("GVStat.Appearance.GroupButton.Image"), System.Drawing.Image)
Me.GVStat.Appearance.GroupButton.Options.UseBackColor = True
Me.GVStat.Appearance.GroupButton.Options.UseBorderColor = True
Me.GVStat.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVStat.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVStat.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
Me.GVStat.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.GroupFooter.FontSizeDelta"), Integer)
Me.GVStat.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVStat.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
Me.GVStat.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVStat.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.GroupFooter.Image = CType(resources.GetObject("GVStat.Appearance.GroupFooter.Image"), System.Drawing.Image)
Me.GVStat.Appearance.GroupFooter.Options.UseBackColor = True
Me.GVStat.Appearance.GroupFooter.Options.UseBorderColor = True
Me.GVStat.Appearance.GroupFooter.Options.UseForeColor = True
Me.GVStat.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVStat.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVStat.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
Me.GVStat.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.GroupPanel.FontSizeDelta"), Integer)
Me.GVStat.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVStat.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
Me.GVStat.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVStat.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.GroupPanel.Image = CType(resources.GetObject("GVStat.Appearance.GroupPanel.Image"), System.Drawing.Image)
Me.GVStat.Appearance.GroupPanel.Options.UseBackColor = True
Me.GVStat.Appearance.GroupPanel.Options.UseForeColor = True
Me.GVStat.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVStat.Appearance.GroupRow.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVStat.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
Me.GVStat.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.GroupRow.FontSizeDelta"), Integer)
Me.GVStat.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVStat.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
Me.GVStat.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVStat.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.GroupRow.Image = CType(resources.GetObject("GVStat.Appearance.GroupRow.Image"), System.Drawing.Image)
Me.GVStat.Appearance.GroupRow.Options.UseBackColor = True
Me.GVStat.Appearance.GroupRow.Options.UseBorderColor = True
Me.GVStat.Appearance.GroupRow.Options.UseForeColor = True
Me.GVStat.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
Me.GVStat.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.Font"), System.Drawing.Font)
Me.GVStat.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.FontSizeDelta"), Integer)
Me.GVStat.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
Me.GVStat.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.Image"), System.Drawing.Image)
Me.GVStat.Appearance.HeaderPanel.Options.UseBackColor = True
Me.GVStat.Appearance.HeaderPanel.Options.UseBorderColor = True
Me.GVStat.Appearance.HeaderPanel.Options.UseFont = True
Me.GVStat.Appearance.HeaderPanel.Options.UseForeColor = True
Me.GVStat.Appearance.HeaderPanel.Options.UseTextOptions = True
Me.GVStat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
Me.GVStat.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
Me.GVStat.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
Me.GVStat.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVStat.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.HideSelectionRow.BorderColor = CType(resources.GetObject("GVStat.Appearance.HideSelectionRow.BorderColor"), System.Drawing.Color)
Me.GVStat.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
Me.GVStat.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVStat.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
Me.GVStat.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVStat.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVStat.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
Me.GVStat.Appearance.HideSelectionRow.Options.UseBackColor = True
Me.GVStat.Appearance.HideSelectionRow.Options.UseBorderColor = True
Me.GVStat.Appearance.HideSelectionRow.Options.UseForeColor = True
Me.GVStat.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVStat.Appearance.HorzLine.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.HorzLine.FontSizeDelta"), Integer)
Me.GVStat.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVStat.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.HorzLine.Image = CType(resources.GetObject("GVStat.Appearance.HorzLine.Image"), System.Drawing.Image)
Me.GVStat.Appearance.HorzLine.Options.UseBackColor = True
Me.GVStat.Appearance.OddRow.BackColor = CType(resources.GetObject("GVStat.Appearance.OddRow.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVStat.Appearance.OddRow.BorderColor"), System.Drawing.Color)
Me.GVStat.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.OddRow.FontSizeDelta"), Integer)
Me.GVStat.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVStat.Appearance.OddRow.ForeColor"), System.Drawing.Color)
Me.GVStat.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVStat.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.OddRow.Image = CType(resources.GetObject("GVStat.Appearance.OddRow.Image"), System.Drawing.Image)
Me.GVStat.Appearance.OddRow.Options.UseBackColor = True
Me.GVStat.Appearance.OddRow.Options.UseBorderColor = True
Me.GVStat.Appearance.OddRow.Options.UseForeColor = True
Me.GVStat.Appearance.Preview.BackColor = CType(resources.GetObject("GVStat.Appearance.Preview.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.Preview.Font = CType(resources.GetObject("GVStat.Appearance.Preview.Font"), System.Drawing.Font)
Me.GVStat.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.Preview.FontSizeDelta"), Integer)
Me.GVStat.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.Preview.ForeColor = CType(resources.GetObject("GVStat.Appearance.Preview.ForeColor"), System.Drawing.Color)
Me.GVStat.Appearance.Preview.GradientMode = CType(resources.GetObject("GVStat.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.Preview.Image = CType(resources.GetObject("GVStat.Appearance.Preview.Image"), System.Drawing.Image)
Me.GVStat.Appearance.Preview.Options.UseBackColor = True
Me.GVStat.Appearance.Preview.Options.UseFont = True
Me.GVStat.Appearance.Preview.Options.UseForeColor = True
Me.GVStat.Appearance.Row.BackColor = CType(resources.GetObject("GVStat.Appearance.Row.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.Row.FontSizeDelta"), Integer)
Me.GVStat.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.Row.ForeColor = CType(resources.GetObject("GVStat.Appearance.Row.ForeColor"), System.Drawing.Color)
Me.GVStat.Appearance.Row.GradientMode = CType(resources.GetObject("GVStat.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.Row.Image = CType(resources.GetObject("GVStat.Appearance.Row.Image"), System.Drawing.Image)
Me.GVStat.Appearance.Row.Options.UseBackColor = True
Me.GVStat.Appearance.Row.Options.UseForeColor = True
Me.GVStat.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVStat.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVStat.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
Me.GVStat.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.RowSeparator.FontSizeDelta"), Integer)
Me.GVStat.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVStat.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.RowSeparator.Image = CType(resources.GetObject("GVStat.Appearance.RowSeparator.Image"), System.Drawing.Image)
Me.GVStat.Appearance.RowSeparator.Options.UseBackColor = True
Me.GVStat.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVStat.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.SelectedRow.BorderColor = CType(resources.GetObject("GVStat.Appearance.SelectedRow.BorderColor"), System.Drawing.Color)
Me.GVStat.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.SelectedRow.FontSizeDelta"), Integer)
Me.GVStat.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVStat.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
Me.GVStat.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVStat.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.SelectedRow.Image = CType(resources.GetObject("GVStat.Appearance.SelectedRow.Image"), System.Drawing.Image)
Me.GVStat.Appearance.SelectedRow.Options.UseBackColor = True
Me.GVStat.Appearance.SelectedRow.Options.UseBorderColor = True
Me.GVStat.Appearance.SelectedRow.Options.UseForeColor = True
Me.GVStat.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVStat.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.TopNewRow.FontSizeDelta"), Integer)
Me.GVStat.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVStat.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.TopNewRow.Image = CType(resources.GetObject("GVStat.Appearance.TopNewRow.Image"), System.Drawing.Image)
Me.GVStat.Appearance.TopNewRow.Options.UseBackColor = True
Me.GVStat.Appearance.VertLine.BackColor = CType(resources.GetObject("GVStat.Appearance.VertLine.BackColor"), System.Drawing.Color)
Me.GVStat.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.VertLine.FontSizeDelta"), Integer)
Me.GVStat.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
Me.GVStat.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVStat.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.GVStat.Appearance.VertLine.Image = CType(resources.GetObject("GVStat.Appearance.VertLine.Image"), System.Drawing.Image)
Me.GVStat.Appearance.VertLine.Options.UseBackColor = True
resources.ApplyResources(Me.GVStat, "GVStat")
Me.GVStat.ColumnPanelRowHeight = 30
Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ndclnum, Me.ddcldat, Me.ndinnum, Me.vclinom, Me.vsitnom, Me.ndclht, Me.vactdes})
Me.GVStat.GridControl = Me.GcDevis
Me.GVStat.Name = "GVStat"
Me.GVStat.OptionsBehavior.Editable = False
Me.GVStat.OptionsNavigation.AutoFocusNewRow = True
Me.GVStat.OptionsView.EnableAppearanceOddRow = True
Me.GVStat.OptionsView.ShowAutoFilterRow = True
Me.GVStat.OptionsView.ShowFooter = True
Me.GVStat.OptionsView.ShowGroupPanel = False
Me.GVStat.RowHeight = 20
'
'ndclnum
'
Me.ndclnum.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ndclnum.AppearanceCell.FontSizeDelta"), Integer)
Me.ndclnum.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ndclnum.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
Me.ndclnum.AppearanceCell.GradientMode = CType(resources.GetObject("ndclnum.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.ndclnum.AppearanceCell.Image = CType(resources.GetObject("ndclnum.AppearanceCell.Image"), System.Drawing.Image)
Me.ndclnum.AppearanceCell.Options.UseTextOptions = True
Me.ndclnum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
resources.ApplyResources(Me.ndclnum, "ndclnum")
Me.ndclnum.FieldName = "NDCLNUM"
Me.ndclnum.Name = "ndclnum"
Me.ndclnum.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ndclnum.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ndclnum.Summary1"), resources.GetString("ndclnum.Summary2"))})
'
'ddcldat
'
Me.ddcldat.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ddcldat.AppearanceCell.FontSizeDelta"), Integer)
Me.ddcldat.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ddcldat.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
Me.ddcldat.AppearanceCell.GradientMode = CType(resources.GetObject("ddcldat.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.ddcldat.AppearanceCell.Image = CType(resources.GetObject("ddcldat.AppearanceCell.Image"), System.Drawing.Image)
Me.ddcldat.AppearanceCell.Options.UseTextOptions = True
Me.ddcldat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
resources.ApplyResources(Me.ddcldat, "ddcldat")
Me.ddcldat.FieldName = "DDCLDAT"
Me.ddcldat.Name = "ddcldat"
'
'ndinnum
'
Me.ndinnum.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ndinnum.AppearanceCell.FontSizeDelta"), Integer)
Me.ndinnum.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ndinnum.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
Me.ndinnum.AppearanceCell.GradientMode = CType(resources.GetObject("ndinnum.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
Me.ndinnum.AppearanceCell.Image = CType(resources.GetObject("ndinnum.AppearanceCell.Image"), System.Drawing.Image)
Me.ndinnum.AppearanceCell.Options.UseTextOptions = True
Me.ndinnum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
resources.ApplyResources(Me.ndinnum, "ndinnum")
Me.ndinnum.FieldName = "NDINNUM"
Me.ndinnum.Name = "ndinnum"
'
'vclinom
'
resources.ApplyResources(Me.vclinom, "vclinom")
Me.vclinom.FieldName = "VCLINOM"
Me.vclinom.Name = "vclinom"
'
'LblCreesTranformes
'
resources.ApplyResources(Me.LblCreesTranformes, "LblCreesTranformes")
Me.LblCreesTranformes.ForeColor = System.Drawing.SystemColors.GrayText
Me.LblCreesTranformes.Name = "LblCreesTranformes"
'
'LblChaff
'
resources.ApplyResources(Me.LblChaff, "LblChaff")
Me.LblChaff.ForeColor = System.Drawing.Color.Black
Me.LblChaff.Name = "LblChaff"
'
'LblNomChaff
'
resources.ApplyResources(Me.LblNomChaff, "LblNomChaff")
Me.LblNomChaff.ForeColor = System.Drawing.SystemColors.ActiveCaption
Me.LblNomChaff.Name = "LblNomChaff"
'
'LblDateFin
'
resources.ApplyResources(Me.LblDateFin, "LblDateFin")
Me.LblDateFin.ForeColor = System.Drawing.SystemColors.ActiveCaption
Me.LblDateFin.Name = "LblDateFin"
'
'LblEtLe
'
resources.ApplyResources(Me.LblEtLe, "LblEtLe")
Me.LblEtLe.ForeColor = System.Drawing.SystemColors.ActiveCaption
Me.LblEtLe.Name = "LblEtLe"
'
'LblDteDebut
'
resources.ApplyResources(Me.LblDteDebut, "LblDteDebut")
Me.LblDteDebut.ForeColor = System.Drawing.SystemColors.ActiveCaption
Me.LblDteDebut.Name = "LblDteDebut"
'
'Label2
'
resources.ApplyResources(Me.Label2, "Label2")
Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
Me.Label2.Name = "Label2"
'
'Label1
'
resources.ApplyResources(Me.Label1, "Label1")
Me.Label1.Name = "Label1"
'
'LblCli
'
resources.ApplyResources(Me.LblCli, "LblCli")
Me.LblCli.ForeColor = System.Drawing.SystemColors.ActiveCaption
Me.LblCli.Name = "LblCli"
'
'LblPeriode
'
resources.ApplyResources(Me.LblPeriode, "LblPeriode")
Me.LblPeriode.Name = "LblPeriode"
'
'frmDetailsDevisParChaff
'
resources.ApplyResources(Me, "$this")
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.BackColor = System.Drawing.Color.Wheat
Me.Controls.Add(Me.LblPeriode)
Me.Controls.Add(Me.Label1)
Me.Controls.Add(Me.LblCli)
Me.Controls.Add(Me.Label2)
Me.Controls.Add(Me.LblDateFin)
Me.Controls.Add(Me.LblEtLe)
Me.Controls.Add(Me.LblDteDebut)
Me.Controls.Add(Me.LblNomChaff)
Me.Controls.Add(Me.LblChaff)
Me.Controls.Add(Me.GroupBox1)
Me.Controls.Add(Me.LblDetails)
Me.Controls.Add(Me.GcDevis)
Me.Controls.Add(Me.LblCreesTranformes)
Me.Name = "frmDetailsDevisParChaff"
Me.GroupBox1.ResumeLayout(False)
CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.GcDevis, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Private WithEvents ColLOTNGTPLOTID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColLOTIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepIGLUpEditViewLot As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColLOTVGTPLOTNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemGLUpEditGTPLot As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepItemGLUpEditUnite As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepItemGLUpEditViewUnite As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColUNITEIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColUNITENGTPUNITEID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColUNITEVGTPUNITENOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents vactdes As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ndclht As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents vsitnom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LblDetails As System.Windows.Forms.Label
    Private WithEvents GcDevis As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ndclnum As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ddcldat As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ndinnum As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents vclinom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LblCreesTranformes As System.Windows.Forms.Label
    Friend WithEvents LblChaff As System.Windows.Forms.Label
    Friend WithEvents LblNomChaff As System.Windows.Forms.Label
    Friend WithEvents LblDateFin As System.Windows.Forms.Label
    Friend WithEvents LblEtLe As System.Windows.Forms.Label
    Friend WithEvents LblDteDebut As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblCli As System.Windows.Forms.Label
    Friend WithEvents LblPeriode As System.Windows.Forms.Label
End Class
