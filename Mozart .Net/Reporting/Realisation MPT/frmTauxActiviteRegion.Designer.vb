<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTauxActiviteRegion
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTauxActiviteRegion))
    Me.GCRECEPTIONS = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GColREGION = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColNBHEURES = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColNBCONTRATS = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.lblPourcProvence = New System.Windows.Forms.Label()
    Me.lblPourcLanguedoc = New System.Windows.Forms.Label()
    Me.lblPourcAuvergne = New System.Windows.Forms.Label()
    Me.lblPourcAquitaine = New System.Windows.Forms.Label()
    Me.lblPourcBourgogne = New System.Windows.Forms.Label()
    Me.lblPourcPaysLoire = New System.Windows.Forms.Label()
    Me.lblPourcAlsace = New System.Windows.Forms.Label()
    Me.lblPourcIDF = New System.Windows.Forms.Label()
    Me.lblPourcCentre = New System.Windows.Forms.Label()
    Me.lblPourcNord = New System.Windows.Forms.Label()
    Me.ButtonExporter = New System.Windows.Forms.Button()
    Me.lblPourcNormandie = New System.Windows.Forms.Label()
    Me.lblPourcBretagne = New System.Windows.Forms.Label()
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.ComboBoxTech = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.BtnPrint = New System.Windows.Forms.Button()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.lblPourcLanguedocH = New System.Windows.Forms.Label()
    Me.lblPourcAquitaineH = New System.Windows.Forms.Label()
    Me.lblPourcAuvergneH = New System.Windows.Forms.Label()
    Me.lblPourcPaysLoireH = New System.Windows.Forms.Label()
    Me.lblPourcBretagneH = New System.Windows.Forms.Label()
    Me.lblPourcIDFH = New System.Windows.Forms.Label()
    Me.lblPourcNormandieH = New System.Windows.Forms.Label()
    Me.lblPourcCentreH = New System.Windows.Forms.Label()
    Me.lblPourcAlsaceH = New System.Windows.Forms.Label()
    Me.lblPourcProvenceH = New System.Windows.Forms.Label()
    Me.lblPourcNordH = New System.Windows.Forms.Label()
    Me.lblPourcBourgogneH = New System.Windows.Forms.Label()
    Me.GridControlDetails = New DevExpress.XtraGrid.GridControl()
    Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.ndinnum = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.vclinom = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.vsitnom = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.nregcod = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.vactdes = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GCRECEPTIONS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridControlDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCRECEPTIONS
        '
        resources.ApplyResources(Me.GCRECEPTIONS, "GCRECEPTIONS")
        Me.GCRECEPTIONS.MainView = Me.GridView1
        Me.GCRECEPTIONS.Name = "GCRECEPTIONS"
        Me.GCRECEPTIONS.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemGLUpEditGTPLot, Me.RepItemGLUpEditUnite})
        Me.GCRECEPTIONS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GridView1.Appearance.Empty.BackColor2 = CType(resources.GetObject("GridView1.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GridView1.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GridView1.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.GridView1.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GridView1.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.Font = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.Preview.Font = CType(resources.GetObject("GridView1.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GridView1.Appearance.Preview.Options.UseBackColor = True
        Me.GridView1.Appearance.Preview.Options.UseFont = True
        Me.GridView1.Appearance.Preview.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GridView1.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GridView1.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GridView1.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.ColumnPanelRowHeight = 30
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColREGION, Me.GColNBHEURES, Me.GColNBCONTRATS})
        Me.GridView1.GridControl = Me.GCRECEPTIONS
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType(resources.GetObject("GridView1.GroupSummary"), DevExpress.Data.SummaryItemType), resources.GetString("GridView1.GroupSummary1"), Me.GColNBCONTRATS, resources.GetString("GridView1.GroupSummary2")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType(resources.GetObject("GridView1.GroupSummary3"), DevExpress.Data.SummaryItemType), resources.GetString("GridView1.GroupSummary4"), Me.GColNBHEURES, resources.GetString("GridView1.GroupSummary5"))})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.RowHeight = 20
        '
        'GColREGION
        '
        resources.ApplyResources(Me.GColREGION, "GColREGION")
        Me.GColREGION.FieldName = "REGION"
        Me.GColREGION.Name = "GColREGION"
        '
        'GColNBHEURES
        '
        Me.GColNBHEURES.AppearanceCell.Options.UseTextOptions = True
        Me.GColNBHEURES.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        resources.ApplyResources(Me.GColNBHEURES, "GColNBHEURES")
        Me.GColNBHEURES.FieldName = "NBHEURES"
        Me.GColNBHEURES.Name = "GColNBHEURES"
        '
        'GColNBCONTRATS
        '
        resources.ApplyResources(Me.GColNBCONTRATS, "GColNBCONTRATS")
        Me.GColNBCONTRATS.FieldName = "NBCONTRATS"
        Me.GColNBCONTRATS.Name = "GColNBCONTRATS"
        '
        'RepItemGLUpEditGTPLot
        '
        resources.ApplyResources(Me.RepItemGLUpEditGTPLot, "RepItemGLUpEditGTPLot")
        Me.RepItemGLUpEditGTPLot.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemGLUpEditGTPLot.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepItemGLUpEditGTPLot.DisplayMember = "VGTPLOTNOM"
        Me.RepItemGLUpEditGTPLot.Name = "RepItemGLUpEditGTPLot"
        Me.RepItemGLUpEditGTPLot.PopupView = Me.RepIGLUpEditViewLot
        Me.RepItemGLUpEditGTPLot.ValueMember = "NGTPLOTID"
        '
        'RepIGLUpEditViewLot
        '
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
        Me.RepItemGLUpEditUnite.PopupView = Me.RepItemGLUpEditViewUnite
        Me.RepItemGLUpEditUnite.ValueMember = "NGTPUNITEID"
        '
        'RepItemGLUpEditViewUnite
        '
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
        'lblPourcProvence
        '
        Me.lblPourcProvence.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcProvence, "lblPourcProvence")
        Me.lblPourcProvence.Name = "lblPourcProvence"
        '
        'lblPourcLanguedoc
        '
        Me.lblPourcLanguedoc.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcLanguedoc, "lblPourcLanguedoc")
        Me.lblPourcLanguedoc.Name = "lblPourcLanguedoc"
        '
        'lblPourcAuvergne
        '
        Me.lblPourcAuvergne.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcAuvergne, "lblPourcAuvergne")
        Me.lblPourcAuvergne.Name = "lblPourcAuvergne"
        '
        'lblPourcAquitaine
        '
        Me.lblPourcAquitaine.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcAquitaine, "lblPourcAquitaine")
        Me.lblPourcAquitaine.Name = "lblPourcAquitaine"
        '
        'lblPourcBourgogne
        '
        Me.lblPourcBourgogne.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcBourgogne, "lblPourcBourgogne")
        Me.lblPourcBourgogne.Name = "lblPourcBourgogne"
        '
        'lblPourcPaysLoire
        '
        Me.lblPourcPaysLoire.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcPaysLoire, "lblPourcPaysLoire")
        Me.lblPourcPaysLoire.Name = "lblPourcPaysLoire"
        '
        'lblPourcAlsace
        '
        Me.lblPourcAlsace.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcAlsace, "lblPourcAlsace")
        Me.lblPourcAlsace.Name = "lblPourcAlsace"
        '
        'lblPourcIDF
        '
        Me.lblPourcIDF.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcIDF, "lblPourcIDF")
        Me.lblPourcIDF.Name = "lblPourcIDF"
        '
        'lblPourcCentre
        '
        Me.lblPourcCentre.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcCentre, "lblPourcCentre")
        Me.lblPourcCentre.Name = "lblPourcCentre"
        '
        'lblPourcNord
        '
        Me.lblPourcNord.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcNord, "lblPourcNord")
        Me.lblPourcNord.Name = "lblPourcNord"
        '
        'ButtonExporter
        '
        resources.ApplyResources(Me.ButtonExporter, "ButtonExporter")
        Me.ButtonExporter.Name = "ButtonExporter"
        Me.ButtonExporter.UseVisualStyleBackColor = True
        '
        'lblPourcNormandie
        '
        Me.lblPourcNormandie.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcNormandie, "lblPourcNormandie")
        Me.lblPourcNormandie.Name = "lblPourcNormandie"
        '
        'lblPourcBretagne
        '
        Me.lblPourcBretagne.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcBretagne, "lblPourcBretagne")
        Me.lblPourcBretagne.Name = "lblPourcBretagne"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MozartNet.My.Resources.Resources.CarteRegionsFrance
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'ComboBoxTech
        '
        Me.ComboBoxTech.DisplayMember = "VTECLIB"
        Me.ComboBoxTech.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBoxTech, "ComboBoxTech")
        Me.ComboBoxTech.Name = "ComboBoxTech"
        Me.ComboBoxTech.ValueMember = "CTECCOD"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonExporter)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnPrint)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'lblPourcLanguedocH
        '
        Me.lblPourcLanguedocH.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.lblPourcLanguedocH, "lblPourcLanguedocH")
        Me.lblPourcLanguedocH.Name = "lblPourcLanguedocH"
        '
        'lblPourcAquitaineH
        '
        Me.lblPourcAquitaineH.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.lblPourcAquitaineH, "lblPourcAquitaineH")
        Me.lblPourcAquitaineH.Name = "lblPourcAquitaineH"
        '
        'lblPourcAuvergneH
        '
        Me.lblPourcAuvergneH.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.lblPourcAuvergneH, "lblPourcAuvergneH")
        Me.lblPourcAuvergneH.Name = "lblPourcAuvergneH"
        '
        'lblPourcPaysLoireH
        '
        Me.lblPourcPaysLoireH.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.lblPourcPaysLoireH, "lblPourcPaysLoireH")
        Me.lblPourcPaysLoireH.Name = "lblPourcPaysLoireH"
        '
        'lblPourcBretagneH
        '
        Me.lblPourcBretagneH.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.lblPourcBretagneH, "lblPourcBretagneH")
        Me.lblPourcBretagneH.Name = "lblPourcBretagneH"
        '
        'lblPourcIDFH
        '
        Me.lblPourcIDFH.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.lblPourcIDFH, "lblPourcIDFH")
        Me.lblPourcIDFH.Name = "lblPourcIDFH"
        '
        'lblPourcNormandieH
        '
        Me.lblPourcNormandieH.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.lblPourcNormandieH, "lblPourcNormandieH")
        Me.lblPourcNormandieH.Name = "lblPourcNormandieH"
        '
        'lblPourcCentreH
        '
        Me.lblPourcCentreH.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.lblPourcCentreH, "lblPourcCentreH")
        Me.lblPourcCentreH.Name = "lblPourcCentreH"
        '
        'lblPourcAlsaceH
        '
        Me.lblPourcAlsaceH.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.lblPourcAlsaceH, "lblPourcAlsaceH")
        Me.lblPourcAlsaceH.Name = "lblPourcAlsaceH"
        '
        'lblPourcProvenceH
        '
        Me.lblPourcProvenceH.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.lblPourcProvenceH, "lblPourcProvenceH")
        Me.lblPourcProvenceH.Name = "lblPourcProvenceH"
        '
        'lblPourcNordH
        '
        Me.lblPourcNordH.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.lblPourcNordH, "lblPourcNordH")
        Me.lblPourcNordH.Name = "lblPourcNordH"
        '
        'lblPourcBourgogneH
        '
        Me.lblPourcBourgogneH.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.lblPourcBourgogneH, "lblPourcBourgogneH")
        Me.lblPourcBourgogneH.Name = "lblPourcBourgogneH"
        '
        'GridControlDetails
        '
        resources.ApplyResources(Me.GridControlDetails, "GridControlDetails")
        Me.GridControlDetails.MainView = Me.GridView2
        Me.GridControlDetails.Name = "GridControlDetails"
        Me.GridControlDetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Red
        Me.GridView2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HeaderPanel.Font = CType(resources.GetObject("GridView2.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView2.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView2.Appearance.OddRow.Options.UseBorderColor = True
        Me.GridView2.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.SelectedRow.BackColor2 = CType(resources.GetObject("GridView2.Appearance.SelectedRow.BackColor2"), System.Drawing.Color)
        Me.GridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView2.AppearancePrint.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView2.AppearancePrint.FilterPanel.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ndinnum, Me.vclinom, Me.vsitnom, Me.nregcod, Me.vactdes})
        Me.GridView2.GridControl = Me.GridControlDetails
        Me.GridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView2.OptionsPrint.PrintPreview = True
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView2.OptionsView.EnableAppearanceOddRow = True
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'ndinnum
        '
        Me.ndinnum.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ndinnum.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.ndinnum, "ndinnum")
        Me.ndinnum.FieldName = "ndinnum"
        Me.ndinnum.Name = "ndinnum"
        Me.ndinnum.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ndinnum.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'vclinom
        '
        Me.vclinom.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.vclinom.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.vclinom, "vclinom")
        Me.vclinom.FieldName = "vclinom"
        Me.vclinom.Name = "vclinom"
        '
        'vsitnom
        '
        Me.vsitnom.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.vsitnom.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.vsitnom, "vsitnom")
        Me.vsitnom.FieldName = "vsitnom"
        Me.vsitnom.Name = "vsitnom"
        '
        'nregcod
        '
        Me.nregcod.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.nregcod.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.nregcod, "nregcod")
        Me.nregcod.FieldName = "nregcod"
        Me.nregcod.Name = "nregcod"
        '
        'vactdes
        '
        Me.vactdes.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.vactdes.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.vactdes, "vactdes")
        Me.vactdes.FieldName = "vactdes"
        Me.vactdes.Name = "vactdes"
        '
        'frmTauxActiviteRegion
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GridControlDetails)
        Me.Controls.Add(Me.lblPourcBourgogneH)
        Me.Controls.Add(Me.lblPourcNordH)
        Me.Controls.Add(Me.lblPourcProvenceH)
        Me.Controls.Add(Me.lblPourcAlsaceH)
        Me.Controls.Add(Me.lblPourcCentreH)
        Me.Controls.Add(Me.lblPourcNormandieH)
        Me.Controls.Add(Me.lblPourcIDFH)
        Me.Controls.Add(Me.lblPourcBretagneH)
        Me.Controls.Add(Me.lblPourcPaysLoireH)
        Me.Controls.Add(Me.lblPourcAuvergneH)
        Me.Controls.Add(Me.lblPourcAquitaineH)
        Me.Controls.Add(Me.lblPourcLanguedocH)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GCRECEPTIONS)
        Me.Controls.Add(Me.lblPourcProvence)
        Me.Controls.Add(Me.lblPourcLanguedoc)
        Me.Controls.Add(Me.lblPourcAuvergne)
        Me.Controls.Add(Me.lblPourcAquitaine)
        Me.Controls.Add(Me.lblPourcBourgogne)
        Me.Controls.Add(Me.lblPourcPaysLoire)
        Me.Controls.Add(Me.lblPourcAlsace)
        Me.Controls.Add(Me.lblPourcIDF)
        Me.Controls.Add(Me.lblPourcCentre)
        Me.Controls.Add(Me.lblPourcNord)
        Me.Controls.Add(Me.lblPourcNormandie)
        Me.Controls.Add(Me.lblPourcBretagne)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBoxTech)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTauxActiviteRegion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCRECEPTIONS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridControlDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents GCRECEPTIONS As DevExpress.XtraGrid.GridControl
  Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents GColNBCONTRATS As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GColREGION As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GColNBHEURES As DevExpress.XtraGrid.Columns.GridColumn
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
  Friend WithEvents lblPourcProvence As System.Windows.Forms.Label
  Friend WithEvents lblPourcLanguedoc As System.Windows.Forms.Label
  Friend WithEvents lblPourcAuvergne As System.Windows.Forms.Label
  Friend WithEvents lblPourcAquitaine As System.Windows.Forms.Label
  Friend WithEvents lblPourcBourgogne As System.Windows.Forms.Label
  Friend WithEvents lblPourcPaysLoire As System.Windows.Forms.Label
  Friend WithEvents lblPourcAlsace As System.Windows.Forms.Label
  Friend WithEvents lblPourcIDF As System.Windows.Forms.Label
  Friend WithEvents lblPourcCentre As System.Windows.Forms.Label
  Friend WithEvents lblPourcNord As System.Windows.Forms.Label
  Friend WithEvents ButtonExporter As System.Windows.Forms.Button
  Friend WithEvents lblPourcNormandie As System.Windows.Forms.Label
  Friend WithEvents lblPourcBretagne As System.Windows.Forms.Label
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents ComboBoxTech As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents BtnPrint As System.Windows.Forms.Button
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents lblPourcLanguedocH As System.Windows.Forms.Label
  Friend WithEvents lblPourcAquitaineH As System.Windows.Forms.Label
  Friend WithEvents lblPourcAuvergneH As System.Windows.Forms.Label
  Friend WithEvents lblPourcPaysLoireH As System.Windows.Forms.Label
  Friend WithEvents lblPourcBretagneH As System.Windows.Forms.Label
  Friend WithEvents lblPourcIDFH As System.Windows.Forms.Label
  Friend WithEvents lblPourcNormandieH As System.Windows.Forms.Label
  Friend WithEvents lblPourcCentreH As System.Windows.Forms.Label
  Friend WithEvents lblPourcAlsaceH As System.Windows.Forms.Label
  Friend WithEvents lblPourcProvenceH As System.Windows.Forms.Label
  Friend WithEvents lblPourcNordH As System.Windows.Forms.Label
  Friend WithEvents lblPourcBourgogneH As System.Windows.Forms.Label
  Private WithEvents GridControlDetails As DevExpress.XtraGrid.GridControl
  Private WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents ndinnum As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents vclinom As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents vsitnom As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents nregcod As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents vactdes As DevExpress.XtraGrid.Columns.GridColumn
End Class
