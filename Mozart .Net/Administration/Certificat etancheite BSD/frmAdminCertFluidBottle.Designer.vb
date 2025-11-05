<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminCertFluidBottle
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
        Me.ColUNITEVGTPUNITENOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUNITEIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLUpEditViewUnite = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColUNITENGTPUNITEID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLUpEditUnite = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ColLOTVGTPLOTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLOTNGTPLOTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLOTIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepIGLUpEditViewLot = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepItemGLUpEditGTPLot = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ColVBOTTLE_REF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVTYPEFLUIDE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNBOTTLE_CONTENANT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNBOTTLE_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColKEY_BOTTLE_UNIQUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVLSTCERTFLUID_BOTTLE = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNIDTYPEFLUIDE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDBOTTLE_CREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVBOTTLETYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVBOTTLECONTENANT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_NBOTTLEQTERESTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.ColVTECHNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCLSTCERTFLUID_BOTTLE = New DevExpress.XtraGrid.GridControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnArchives = New System.Windows.Forms.Button()
        Me.BtnArchiver = New System.Windows.Forms.Button()
        Me.BtnModif = New System.Windows.Forms.Button()
        CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVLSTCERTFLUID_BOTTLE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCLSTCERTFLUID_BOTTLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColUNITEVGTPUNITENOM
        '
        Me.ColUNITEVGTPUNITENOM.Caption = "Unité de mesure"
        Me.ColUNITEVGTPUNITENOM.FieldName = "VGTPUNITENOM"
        Me.ColUNITEVGTPUNITENOM.Name = "ColUNITEVGTPUNITENOM"
        Me.ColUNITEVGTPUNITENOM.Visible = True
        Me.ColUNITEVGTPUNITENOM.VisibleIndex = 0
        '
        'ColUNITEIDTMP
        '
        Me.ColUNITEIDTMP.Caption = "IDTMP"
        Me.ColUNITEIDTMP.FieldName = "IDTMP"
        Me.ColUNITEIDTMP.Name = "ColUNITEIDTMP"
        '
        'RepItemGLUpEditViewUnite
        '
        Me.RepItemGLUpEditViewUnite.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColUNITEIDTMP, Me.ColUNITENGTPUNITEID, Me.ColUNITEVGTPUNITENOM})
        Me.RepItemGLUpEditViewUnite.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepItemGLUpEditViewUnite.Name = "RepItemGLUpEditViewUnite"
        Me.RepItemGLUpEditViewUnite.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepItemGLUpEditViewUnite.OptionsView.ShowGroupPanel = False
        '
        'ColUNITENGTPUNITEID
        '
        Me.ColUNITENGTPUNITEID.Caption = "NGTPUNITEID"
        Me.ColUNITENGTPUNITEID.FieldName = "NGTPUNITEID"
        Me.ColUNITENGTPUNITEID.Name = "ColUNITENGTPUNITEID"
        '
        'RepItemGLUpEditUnite
        '
        Me.RepItemGLUpEditUnite.AutoHeight = False
        Me.RepItemGLUpEditUnite.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepItemGLUpEditUnite.DisplayMember = "VGTPUNITENOM"
        Me.RepItemGLUpEditUnite.Name = "RepItemGLUpEditUnite"
        Me.RepItemGLUpEditUnite.NullText = ""
        Me.RepItemGLUpEditUnite.PopupView = Me.RepItemGLUpEditViewUnite
        Me.RepItemGLUpEditUnite.ValueMember = "NGTPUNITEID"
        '
        'ColLOTVGTPLOTNOM
        '
        Me.ColLOTVGTPLOTNOM.Caption = "Nom du Lot"
        Me.ColLOTVGTPLOTNOM.FieldName = "VGTPLOTNOM"
        Me.ColLOTVGTPLOTNOM.Name = "ColLOTVGTPLOTNOM"
        Me.ColLOTVGTPLOTNOM.Visible = True
        Me.ColLOTVGTPLOTNOM.VisibleIndex = 0
        '
        'ColLOTNGTPLOTID
        '
        Me.ColLOTNGTPLOTID.Caption = "NGTPLOTID"
        Me.ColLOTNGTPLOTID.FieldName = "NGTPLOTID"
        Me.ColLOTNGTPLOTID.Name = "ColLOTNGTPLOTID"
        '
        'ColLOTIDTMP
        '
        Me.ColLOTIDTMP.Caption = "IDTMP"
        Me.ColLOTIDTMP.FieldName = "IDTMP"
        Me.ColLOTIDTMP.Name = "ColLOTIDTMP"
        '
        'RepIGLUpEditViewLot
        '
        Me.RepIGLUpEditViewLot.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColLOTIDTMP, Me.ColLOTNGTPLOTID, Me.ColLOTVGTPLOTNOM})
        Me.RepIGLUpEditViewLot.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepIGLUpEditViewLot.Name = "RepIGLUpEditViewLot"
        Me.RepIGLUpEditViewLot.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepIGLUpEditViewLot.OptionsView.ShowGroupPanel = False
        '
        'RepItemGLUpEditGTPLot
        '
        Me.RepItemGLUpEditGTPLot.AutoHeight = False
        Me.RepItemGLUpEditGTPLot.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepItemGLUpEditGTPLot.DisplayMember = "VGTPLOTNOM"
        Me.RepItemGLUpEditGTPLot.Name = "RepItemGLUpEditGTPLot"
        Me.RepItemGLUpEditGTPLot.NullText = ""
        Me.RepItemGLUpEditGTPLot.PopupView = Me.RepIGLUpEditViewLot
        Me.RepItemGLUpEditGTPLot.ValueMember = "NGTPLOTID"
        '
        'ColVBOTTLE_REF
        '
        Me.ColVBOTTLE_REF.Caption = "N° identification"
        Me.ColVBOTTLE_REF.FieldName = "VBOTTLE_REF"
        Me.ColVBOTTLE_REF.Name = "ColVBOTTLE_REF"
        Me.ColVBOTTLE_REF.OptionsColumn.AllowEdit = False
        Me.ColVBOTTLE_REF.OptionsColumn.ReadOnly = True
        Me.ColVBOTTLE_REF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColVBOTTLE_REF.Visible = True
        Me.ColVBOTTLE_REF.VisibleIndex = 5
        '
        'ColVTYPEFLUIDE
        '
        Me.ColVTYPEFLUIDE.Caption = "Nature du fluide"
        Me.ColVTYPEFLUIDE.FieldName = "VTYPEFLUIDE"
        Me.ColVTYPEFLUIDE.Name = "ColVTYPEFLUIDE"
        Me.ColVTYPEFLUIDE.OptionsColumn.AllowEdit = False
        Me.ColVTYPEFLUIDE.OptionsColumn.ReadOnly = True
        Me.ColVTYPEFLUIDE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColVTYPEFLUIDE.Visible = True
        Me.ColVTYPEFLUIDE.VisibleIndex = 2
        '
        'ColNBOTTLE_CONTENANT
        '
        Me.ColNBOTTLE_CONTENANT.AppearanceCell.Options.UseTextOptions = True
        Me.ColNBOTTLE_CONTENANT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNBOTTLE_CONTENANT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNBOTTLE_CONTENANT.FieldName = "NBOTTLE_CONTENANT"
        Me.ColNBOTTLE_CONTENANT.Name = "ColNBOTTLE_CONTENANT"
        Me.ColNBOTTLE_CONTENANT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColNBOTTLE_CONTENANT.Width = 183
        '
        'ColNBOTTLE_TYPE
        '
        Me.ColNBOTTLE_TYPE.Caption = "NBOTTLE_TYPE"
        Me.ColNBOTTLE_TYPE.FieldName = "NBOTTLE_TYPE"
        Me.ColNBOTTLE_TYPE.Name = "ColNBOTTLE_TYPE"
        Me.ColNBOTTLE_TYPE.Width = 350
        '
        'ColNPERNUM
        '
        Me.ColNPERNUM.AppearanceCell.Options.UseTextOptions = True
        Me.ColNPERNUM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNPERNUM.Caption = "NPERNUM"
        Me.ColNPERNUM.FieldName = "NPERNUM"
        Me.ColNPERNUM.Name = "ColNPERNUM"
        Me.ColNPERNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColNPERNUM.Width = 250
        '
        'ColKEY_BOTTLE_UNIQUE
        '
        Me.ColKEY_BOTTLE_UNIQUE.Caption = "KEY_BOTTLE_UNIQUE"
        Me.ColKEY_BOTTLE_UNIQUE.FieldName = "KEY_BOTTLE_UNIQUE"
        Me.ColKEY_BOTTLE_UNIQUE.Name = "ColKEY_BOTTLE_UNIQUE"
        Me.ColKEY_BOTTLE_UNIQUE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColKEY_BOTTLE_UNIQUE.Width = 212
        '
        'GVLSTCERTFLUID_BOTTLE
        '
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.Empty.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.OddRow.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.OddRow.Options.UseForeColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.Preview.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.Preview.Options.UseFont = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.Preview.Options.UseForeColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.Row.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.Row.Options.UseForeColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.VertLine.Options.UseBackColor = True
        Me.GVLSTCERTFLUID_BOTTLE.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVLSTCERTFLUID_BOTTLE.ColumnPanelRowHeight = 50
        Me.GVLSTCERTFLUID_BOTTLE.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColKEY_BOTTLE_UNIQUE, Me.ColNPERNUM, Me.ColNIDTYPEFLUIDE, Me.ColNBOTTLE_TYPE, Me.ColNBOTTLE_CONTENANT, Me.ColDBOTTLE_CREE, Me.ColVBOTTLETYPE, Me.ColVTYPEFLUIDE, Me.ColVBOTTLECONTENANT, Me.Col_NBOTTLEQTERESTE, Me.ColVBOTTLE_REF, Me.ColVTECHNOM, Me.GridColumn1})
        Me.GVLSTCERTFLUID_BOTTLE.GridControl = Me.GCLSTCERTFLUID_BOTTLE
        Me.GVLSTCERTFLUID_BOTTLE.Name = "GVLSTCERTFLUID_BOTTLE"
        Me.GVLSTCERTFLUID_BOTTLE.OptionsBehavior.Editable = False
        Me.GVLSTCERTFLUID_BOTTLE.OptionsNavigation.AutoFocusNewRow = True
        Me.GVLSTCERTFLUID_BOTTLE.OptionsView.EnableAppearanceEvenRow = True
        Me.GVLSTCERTFLUID_BOTTLE.OptionsView.EnableAppearanceOddRow = True
        Me.GVLSTCERTFLUID_BOTTLE.OptionsView.ShowAutoFilterRow = True
        Me.GVLSTCERTFLUID_BOTTLE.OptionsView.ShowFooter = True
        Me.GVLSTCERTFLUID_BOTTLE.OptionsView.ShowGroupPanel = False
        Me.GVLSTCERTFLUID_BOTTLE.RowHeight = 20
        '
        'ColNIDTYPEFLUIDE
        '
        Me.ColNIDTYPEFLUIDE.AppearanceCell.Options.UseTextOptions = True
        Me.ColNIDTYPEFLUIDE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNIDTYPEFLUIDE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNIDTYPEFLUIDE.Caption = "NIDTYPEFLUIDE"
        Me.ColNIDTYPEFLUIDE.FieldName = "NIDTYPEFLUIDE"
        Me.ColNIDTYPEFLUIDE.Name = "ColNIDTYPEFLUIDE"
        Me.ColNIDTYPEFLUIDE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColNIDTYPEFLUIDE.Width = 180
        '
        'ColDBOTTLE_CREE
        '
        Me.ColDBOTTLE_CREE.Caption = "Date création"
        Me.ColDBOTTLE_CREE.FieldName = "DBOTTLE_CREE"
        Me.ColDBOTTLE_CREE.Name = "ColDBOTTLE_CREE"
        Me.ColDBOTTLE_CREE.OptionsColumn.AllowEdit = False
        Me.ColDBOTTLE_CREE.OptionsColumn.ReadOnly = True
        Me.ColDBOTTLE_CREE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColDBOTTLE_CREE.Visible = True
        Me.ColDBOTTLE_CREE.VisibleIndex = 0
        '
        'ColVBOTTLETYPE
        '
        Me.ColVBOTTLETYPE.Caption = "Type bouteille"
        Me.ColVBOTTLETYPE.FieldName = "VBOTTLETYPE"
        Me.ColVBOTTLETYPE.Name = "ColVBOTTLETYPE"
        Me.ColVBOTTLETYPE.OptionsColumn.AllowEdit = False
        Me.ColVBOTTLETYPE.OptionsColumn.ReadOnly = True
        Me.ColVBOTTLETYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColVBOTTLETYPE.Visible = True
        Me.ColVBOTTLETYPE.VisibleIndex = 1
        '
        'ColVBOTTLECONTENANT
        '
        Me.ColVBOTTLECONTENANT.Caption = "Contenance"
        Me.ColVBOTTLECONTENANT.FieldName = "VBOTTLECONTENANT"
        Me.ColVBOTTLECONTENANT.Name = "ColVBOTTLECONTENANT"
        Me.ColVBOTTLECONTENANT.OptionsColumn.AllowEdit = False
        Me.ColVBOTTLECONTENANT.OptionsColumn.ReadOnly = True
        Me.ColVBOTTLECONTENANT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColVBOTTLECONTENANT.Visible = True
        Me.ColVBOTTLECONTENANT.VisibleIndex = 3
        '
        'Col_NBOTTLEQTERESTE
        '
        Me.Col_NBOTTLEQTERESTE.Caption = "Quantité restante"
        Me.Col_NBOTTLEQTERESTE.ColumnEdit = Me.RepositoryItemProgressBar1
        Me.Col_NBOTTLEQTERESTE.FieldName = "NBOTTLEQTERESTE"
        Me.Col_NBOTTLEQTERESTE.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.Col_NBOTTLEQTERESTE.Name = "Col_NBOTTLEQTERESTE"
        Me.Col_NBOTTLEQTERESTE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Col_NBOTTLEQTERESTE.Visible = True
        Me.Col_NBOTTLEQTERESTE.VisibleIndex = 4
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.DisplayFormat.FormatString = "{0:n0}"
        Me.RepositoryItemProgressBar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RepositoryItemProgressBar1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.RepositoryItemProgressBar1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        Me.RepositoryItemProgressBar1.PercentView = False
        Me.RepositoryItemProgressBar1.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
        Me.RepositoryItemProgressBar1.ReadOnly = True
        Me.RepositoryItemProgressBar1.ShowTitle = True
        Me.RepositoryItemProgressBar1.Step = 1
        '
        'ColVTECHNOM
        '
        Me.ColVTECHNOM.Caption = "Technicien"
        Me.ColVTECHNOM.FieldName = "VTECHNOM"
        Me.ColVTECHNOM.Name = "ColVTECHNOM"
        Me.ColVTECHNOM.OptionsColumn.AllowEdit = False
        Me.ColVTECHNOM.OptionsColumn.ReadOnly = True
        Me.ColVTECHNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColVTECHNOM.Visible = True
        Me.ColVTECHNOM.VisibleIndex = 6
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "N° Commande"
        Me.GridColumn1.FieldName = "NCOMNUM"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 7
        '
        'GCLSTCERTFLUID_BOTTLE
        '
        Me.GCLSTCERTFLUID_BOTTLE.Location = New System.Drawing.Point(135, 42)
        Me.GCLSTCERTFLUID_BOTTLE.MainView = Me.GVLSTCERTFLUID_BOTTLE
        Me.GCLSTCERTFLUID_BOTTLE.Name = "GCLSTCERTFLUID_BOTTLE"
        Me.GCLSTCERTFLUID_BOTTLE.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemGLUpEditGTPLot, Me.RepItemGLUpEditUnite, Me.RepositoryItemProgressBar1})
        Me.GCLSTCERTFLUID_BOTTLE.Size = New System.Drawing.Size(1193, 705)
        Me.GCLSTCERTFLUID_BOTTLE.TabIndex = 11
        Me.GCLSTCERTFLUID_BOTTLE.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVLSTCERTFLUID_BOTTLE})
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(135, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(993, 30)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Administration des bouteilles de fluides actives"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAdd.Location = New System.Drawing.Point(6, 50)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(108, 45)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Ajouter"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'BtnQuit
        '
        Me.BtnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnQuit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnQuit.Location = New System.Drawing.Point(6, 654)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(108, 45)
        Me.BtnQuit.TabIndex = 1
        Me.BtnQuit.Text = "Fermer"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnArchives)
        Me.GrpActions.Controls.Add(Me.BtnArchiver)
        Me.GrpActions.Controls.Add(Me.BtnModif)
        Me.GrpActions.Controls.Add(Me.btnAdd)
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Location = New System.Drawing.Point(6, 42)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(123, 705)
        Me.GrpActions.TabIndex = 12
        Me.GrpActions.TabStop = False
        '
        'BtnArchives
        '
        Me.BtnArchives.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnArchives.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnArchives.Location = New System.Drawing.Point(6, 331)
        Me.BtnArchives.Name = "BtnArchives"
        Me.BtnArchives.Size = New System.Drawing.Size(108, 45)
        Me.BtnArchives.TabIndex = 5
        Me.BtnArchives.Text = "Archives"
        Me.BtnArchives.UseVisualStyleBackColor = True
        '
        'BtnArchiver
        '
        Me.BtnArchiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnArchiver.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnArchiver.Location = New System.Drawing.Point(6, 152)
        Me.BtnArchiver.Name = "BtnArchiver"
        Me.BtnArchiver.Size = New System.Drawing.Size(108, 45)
        Me.BtnArchiver.TabIndex = 4
        Me.BtnArchiver.Text = "Archiver"
        Me.BtnArchiver.UseVisualStyleBackColor = True
        '
        'BtnModif
        '
        Me.BtnModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnModif.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnModif.Location = New System.Drawing.Point(6, 101)
        Me.BtnModif.Name = "BtnModif"
        Me.BtnModif.Size = New System.Drawing.Size(108, 45)
        Me.BtnModif.TabIndex = 3
        Me.BtnModif.Text = "Modifier"
        Me.BtnModif.UseVisualStyleBackColor = True
        '
        'frmAdminCertFluidBottle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1780, 932)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GCLSTCERTFLUID_BOTTLE)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmAdminCertFluidBottle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Administration des bouteilles de fluides"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVLSTCERTFLUID_BOTTLE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCLSTCERTFLUID_BOTTLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ColUNITEVGTPUNITENOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColUNITEIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemGLUpEditViewUnite As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColUNITENGTPUNITEID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemGLUpEditUnite As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents ColLOTVGTPLOTNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColLOTNGTPLOTID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColLOTIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepIGLUpEditViewLot As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents RepItemGLUpEditGTPLot As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents ColVBOTTLE_REF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVTYPEFLUIDE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNBOTTLE_CONTENANT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNBOTTLE_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColKEY_BOTTLE_UNIQUE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVLSTCERTFLUID_BOTTLE As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColNIDTYPEFLUIDE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCLSTCERTFLUID_BOTTLE As DevExpress.XtraGrid.GridControl
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents BtnQuit As Button
    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnArchives As Button
    Friend WithEvents BtnArchiver As Button
    Friend WithEvents BtnModif As Button
    Friend WithEvents ColDBOTTLE_CREE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColVBOTTLETYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColVBOTTLECONTENANT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColVTECHNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_NBOTTLEQTERESTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
