<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportingGeographiqueEurope
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportingGeographiqueEurope))
        Me.GCRECEPTIONS = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColREGION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CA = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.ComboBoxPrest = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBoxTech = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonExporter = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPourcFrance = New System.Windows.Forms.Label()
        Me.lblPourcItalie = New System.Windows.Forms.Label()
        Me.lblPourcAllemagne = New System.Windows.Forms.Label()
        Me.lblPourcAngleterre = New System.Windows.Forms.Label()
        Me.lblPourcPortugal = New System.Windows.Forms.Label()
        Me.lblPourcBelgique = New System.Windows.Forms.Label()
        Me.lblPourcEspagne = New System.Windows.Forms.Label()
        Me.lblPourcSuede = New System.Windows.Forms.Label()
        Me.lblPourcFinlande = New System.Windows.Forms.Label()
        Me.lblPourcDanemark = New System.Windows.Forms.Label()
        Me.lblPourcAutriche = New System.Windows.Forms.Label()
        Me.lblPourcSuisse = New System.Windows.Forms.Label()
        Me.lblPourcNorvege = New System.Windows.Forms.Label()
        Me.lblPourcIrlande = New System.Windows.Forms.Label()
        Me.lblPourcPaysBas = New System.Windows.Forms.Label()
        Me.lblPourcGrece = New System.Windows.Forms.Label()
        Me.lblPourcPologne = New System.Windows.Forms.Label()
        Me.lblPourcRepTcheque = New System.Windows.Forms.Label()
        Me.lblPourcSlovaquie = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPourcLuxembourg = New System.Windows.Forms.Label()
        Me.CheckedComboBoxEdit1 = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        CType(Me.GCRECEPTIONS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckedComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NCLINUM, Me.GridColumn1, Me.VCLINOM, Me.GColREGION, Me.CA})
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
        'NCLINUM
        '
        resources.ApplyResources(Me.NCLINUM, "NCLINUM")
        Me.NCLINUM.FieldName = "NCLINUM"
        Me.NCLINUM.Name = "NCLINUM"
        '
        'GridColumn1
        '
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.FieldName = "VSOCIETE"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'VCLINOM
        '
        resources.ApplyResources(Me.VCLINOM, "VCLINOM")
        Me.VCLINOM.FieldName = "VCLINOM"
        Me.VCLINOM.Name = "VCLINOM"
        '
        'GColREGION
        '
        resources.ApplyResources(Me.GColREGION, "GColREGION")
        Me.GColREGION.FieldName = "PAYS"
        Me.GColREGION.Name = "GColREGION"
        '
        'CA
        '
        Me.CA.AppearanceCell.Options.UseTextOptions = True
        Me.CA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        resources.ApplyResources(Me.CA, "CA")
        Me.CA.FieldName = "CA"
        Me.CA.Name = "CA"
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
        'ComboBoxPrest
        '
        Me.ComboBoxPrest.DisplayMember = "VPRELIB"
        Me.ComboBoxPrest.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBoxPrest, "ComboBoxPrest")
        Me.ComboBoxPrest.Name = "ComboBoxPrest"
        Me.ComboBoxPrest.ValueMember = "CPRECOD"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ButtonExporter)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnPrint)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
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
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MozartNet.My.Resources.Resources.CarteEurope
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'lblPourcFrance
        '
        Me.lblPourcFrance.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcFrance, "lblPourcFrance")
        Me.lblPourcFrance.Name = "lblPourcFrance"
        '
        'lblPourcItalie
        '
        Me.lblPourcItalie.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcItalie, "lblPourcItalie")
        Me.lblPourcItalie.Name = "lblPourcItalie"
        '
        'lblPourcAllemagne
        '
        Me.lblPourcAllemagne.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcAllemagne, "lblPourcAllemagne")
        Me.lblPourcAllemagne.Name = "lblPourcAllemagne"
        '
        'lblPourcAngleterre
        '
        Me.lblPourcAngleterre.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcAngleterre, "lblPourcAngleterre")
        Me.lblPourcAngleterre.Name = "lblPourcAngleterre"
        '
        'lblPourcPortugal
        '
        Me.lblPourcPortugal.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcPortugal, "lblPourcPortugal")
        Me.lblPourcPortugal.Name = "lblPourcPortugal"
        '
        'lblPourcBelgique
        '
        Me.lblPourcBelgique.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcBelgique, "lblPourcBelgique")
        Me.lblPourcBelgique.Name = "lblPourcBelgique"
        '
        'lblPourcEspagne
        '
        Me.lblPourcEspagne.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcEspagne, "lblPourcEspagne")
        Me.lblPourcEspagne.Name = "lblPourcEspagne"
        '
        'lblPourcSuede
        '
        Me.lblPourcSuede.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcSuede, "lblPourcSuede")
        Me.lblPourcSuede.Name = "lblPourcSuede"
        '
        'lblPourcFinlande
        '
        Me.lblPourcFinlande.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcFinlande, "lblPourcFinlande")
        Me.lblPourcFinlande.Name = "lblPourcFinlande"
        '
        'lblPourcDanemark
        '
        Me.lblPourcDanemark.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcDanemark, "lblPourcDanemark")
        Me.lblPourcDanemark.Name = "lblPourcDanemark"
        '
        'lblPourcAutriche
        '
        Me.lblPourcAutriche.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcAutriche, "lblPourcAutriche")
        Me.lblPourcAutriche.Name = "lblPourcAutriche"
        '
        'lblPourcSuisse
        '
        Me.lblPourcSuisse.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcSuisse, "lblPourcSuisse")
        Me.lblPourcSuisse.Name = "lblPourcSuisse"
        '
        'lblPourcNorvege
        '
        Me.lblPourcNorvege.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcNorvege, "lblPourcNorvege")
        Me.lblPourcNorvege.Name = "lblPourcNorvege"
        '
        'lblPourcIrlande
        '
        Me.lblPourcIrlande.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcIrlande, "lblPourcIrlande")
        Me.lblPourcIrlande.Name = "lblPourcIrlande"
        '
        'lblPourcPaysBas
        '
        Me.lblPourcPaysBas.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcPaysBas, "lblPourcPaysBas")
        Me.lblPourcPaysBas.Name = "lblPourcPaysBas"
        '
        'lblPourcGrece
        '
        Me.lblPourcGrece.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcGrece, "lblPourcGrece")
        Me.lblPourcGrece.Name = "lblPourcGrece"
        '
        'lblPourcPologne
        '
        Me.lblPourcPologne.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcPologne, "lblPourcPologne")
        Me.lblPourcPologne.Name = "lblPourcPologne"
        '
        'lblPourcRepTcheque
        '
        Me.lblPourcRepTcheque.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcRepTcheque, "lblPourcRepTcheque")
        Me.lblPourcRepTcheque.Name = "lblPourcRepTcheque"
        '
        'lblPourcSlovaquie
        '
        Me.lblPourcSlovaquie.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcSlovaquie, "lblPourcSlovaquie")
        Me.lblPourcSlovaquie.Name = "lblPourcSlovaquie"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'lblPourcLuxembourg
        '
        Me.lblPourcLuxembourg.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPourcLuxembourg, "lblPourcLuxembourg")
        Me.lblPourcLuxembourg.Name = "lblPourcLuxembourg"
        '
        'CheckedComboBoxEdit1
        '
        resources.ApplyResources(Me.CheckedComboBoxEdit1, "CheckedComboBoxEdit1")
        Me.CheckedComboBoxEdit1.Name = "CheckedComboBoxEdit1"
        Me.CheckedComboBoxEdit1.Properties.AllowMultiSelect = True
        Me.CheckedComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("CheckedComboBoxEdit1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.CheckedComboBoxEdit1.Properties.DisplayMember = "VSOCIETE"
        Me.CheckedComboBoxEdit1.Properties.ValueMember = "VSOCIETE"
        '
        'frmReportingGeographiqueEurope
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.CheckedComboBoxEdit1)
        Me.Controls.Add(Me.lblPourcLuxembourg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPourcSlovaquie)
        Me.Controls.Add(Me.lblPourcRepTcheque)
        Me.Controls.Add(Me.lblPourcPologne)
        Me.Controls.Add(Me.lblPourcGrece)
        Me.Controls.Add(Me.lblPourcPaysBas)
        Me.Controls.Add(Me.lblPourcIrlande)
        Me.Controls.Add(Me.lblPourcNorvege)
        Me.Controls.Add(Me.lblPourcSuisse)
        Me.Controls.Add(Me.lblPourcAutriche)
        Me.Controls.Add(Me.lblPourcDanemark)
        Me.Controls.Add(Me.lblPourcFinlande)
        Me.Controls.Add(Me.lblPourcSuede)
        Me.Controls.Add(Me.lblPourcEspagne)
        Me.Controls.Add(Me.lblPourcBelgique)
        Me.Controls.Add(Me.lblPourcPortugal)
        Me.Controls.Add(Me.lblPourcAngleterre)
        Me.Controls.Add(Me.lblPourcAllemagne)
        Me.Controls.Add(Me.lblPourcItalie)
        Me.Controls.Add(Me.lblPourcFrance)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GCRECEPTIONS)
        Me.Controls.Add(Me.ComboBoxPrest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxTech)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmReportingGeographiqueEurope"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCRECEPTIONS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckedComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBoxPrest As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBoxTech As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonExporter As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPourcFrance As System.Windows.Forms.Label
    Friend WithEvents lblPourcItalie As System.Windows.Forms.Label
    Friend WithEvents lblPourcAllemagne As System.Windows.Forms.Label
    Friend WithEvents lblPourcAngleterre As System.Windows.Forms.Label
    Friend WithEvents lblPourcPortugal As System.Windows.Forms.Label
    Friend WithEvents lblPourcBelgique As System.Windows.Forms.Label
    Friend WithEvents lblPourcEspagne As System.Windows.Forms.Label
    Friend WithEvents lblPourcSuede As System.Windows.Forms.Label
    Friend WithEvents lblPourcFinlande As System.Windows.Forms.Label
    Friend WithEvents lblPourcDanemark As System.Windows.Forms.Label
    Friend WithEvents lblPourcAutriche As System.Windows.Forms.Label
    Friend WithEvents lblPourcSuisse As System.Windows.Forms.Label
    Friend WithEvents lblPourcNorvege As System.Windows.Forms.Label
    Friend WithEvents lblPourcIrlande As System.Windows.Forms.Label
    Friend WithEvents lblPourcPaysBas As System.Windows.Forms.Label
    Friend WithEvents lblPourcGrece As System.Windows.Forms.Label
    Friend WithEvents lblPourcPologne As System.Windows.Forms.Label
    Friend WithEvents lblPourcRepTcheque As System.Windows.Forms.Label
    Friend WithEvents lblPourcSlovaquie As System.Windows.Forms.Label
    Private WithEvents GCRECEPTIONS As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents NCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColREGION As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents CA As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As Label
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblPourcLuxembourg As Label
    Friend WithEvents CheckedComboBoxEdit1 As DevExpress.XtraEditors.CheckedComboBoxEdit
End Class
