<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestionContratSite
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
    Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.RepItemGLUpEditViewUnite = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.ColUNITEIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColUNITENGTPUNITEID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColUNITEVGTPUNITENOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColLOTIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepIGLUpEditViewLot = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.ColLOTNGTPLOTID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColLOTVGTPLOTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepItemGLUpEditUnite = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
    Me.RepItemGLUpEditGTPLot = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
    Me.NSITNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.NTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GVFORMATION = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.VTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.VSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.VSITPAYS = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.enseigne = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.NSITNUE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gestion = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCFORMATION = New DevExpress.XtraGrid.GridControl()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.BtnExcel = New System.Windows.Forms.Button()
    Me.BtnMod = New System.Windows.Forms.Button()
    Me.BtnQuit = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.GVCboChaff = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GCCboChaffNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCCboChaffNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GlookUpContrat = New DevExpress.XtraEditors.GridLookUpEdit()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.BtnGestForm = New System.Windows.Forms.Button()
    Me.lblColonne = New System.Windows.Forms.Label()
    Me.cmdValiderListe = New System.Windows.Forms.Button()
    Me.cmdValiderLigne = New System.Windows.Forms.Button()
    Me.CboValeur = New System.Windows.Forms.ComboBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GVFORMATION, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GCFORMATION, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GrpActions.SuspendLayout()
    CType(Me.GVCboChaff, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GlookUpContrat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'RepositoryItemCheckEdit1
    '
    Me.RepositoryItemCheckEdit1.AutoHeight = False
    Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
    Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
    Me.RepositoryItemCheckEdit1.ReadOnly = True
    Me.RepositoryItemCheckEdit1.ValueChecked = "O"
    Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
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
    Me.ColUNITEIDTMP.Caption = "IDTMP"
    Me.ColUNITEIDTMP.FieldName = "IDTMP"
    Me.ColUNITEIDTMP.Name = "ColUNITEIDTMP"
    '
    'ColUNITENGTPUNITEID
    '
    Me.ColUNITENGTPUNITEID.Caption = "NGTPUNITEID"
    Me.ColUNITENGTPUNITEID.FieldName = "NGTPUNITEID"
    Me.ColUNITENGTPUNITEID.Name = "ColUNITENGTPUNITEID"
    '
    'ColUNITEVGTPUNITENOM
    '
    Me.ColUNITEVGTPUNITENOM.Caption = "Unité de mesure"
    Me.ColUNITEVGTPUNITENOM.FieldName = "VGTPUNITENOM"
    Me.ColUNITEVGTPUNITENOM.Name = "ColUNITEVGTPUNITENOM"
    Me.ColUNITEVGTPUNITENOM.Visible = True
    Me.ColUNITEVGTPUNITENOM.VisibleIndex = 0
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
    'ColLOTNGTPLOTID
    '
    Me.ColLOTNGTPLOTID.Caption = "NGTPLOTID"
    Me.ColLOTNGTPLOTID.FieldName = "NGTPLOTID"
    Me.ColLOTNGTPLOTID.Name = "ColLOTNGTPLOTID"
    '
    'ColLOTVGTPLOTNOM
    '
    Me.ColLOTVGTPLOTNOM.Caption = "Nom du Lot"
    Me.ColLOTVGTPLOTNOM.FieldName = "VGTPLOTNOM"
    Me.ColLOTVGTPLOTNOM.Name = "ColLOTVGTPLOTNOM"
    Me.ColLOTVGTPLOTNOM.Visible = True
    Me.ColLOTVGTPLOTNOM.VisibleIndex = 0
    '
    'RepItemGLUpEditUnite
    '
    Me.RepItemGLUpEditUnite.AutoHeight = False
    Me.RepItemGLUpEditUnite.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepItemGLUpEditUnite.DisplayMember = "VGTPUNITENOM"
    Me.RepItemGLUpEditUnite.Name = "RepItemGLUpEditUnite"
    Me.RepItemGLUpEditUnite.NullText = ""
    Me.RepItemGLUpEditUnite.ValueMember = "NGTPUNITEID"
    Me.RepItemGLUpEditUnite.View = Me.RepItemGLUpEditViewUnite
    '
    'RepItemGLUpEditGTPLot
    '
    Me.RepItemGLUpEditGTPLot.AutoHeight = False
    Me.RepItemGLUpEditGTPLot.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepItemGLUpEditGTPLot.DisplayMember = "VGTPLOTNOM"
    Me.RepItemGLUpEditGTPLot.Name = "RepItemGLUpEditGTPLot"
    Me.RepItemGLUpEditGTPLot.NullText = ""
    Me.RepItemGLUpEditGTPLot.ValueMember = "NGTPLOTID"
    Me.RepItemGLUpEditGTPLot.View = Me.RepIGLUpEditViewLot
    '
    'NSITNUM
    '
    Me.NSITNUM.Caption = "NSITNUM"
    Me.NSITNUM.FieldName = "NSITNUM"
    Me.NSITNUM.Name = "NSITNUM"
    '
    'NTYPECONTRAT
    '
    Me.NTYPECONTRAT.Caption = "NTYPECONTRAT"
    Me.NTYPECONTRAT.FieldName = "NTYPECONTRAT"
    Me.NTYPECONTRAT.Name = "NTYPECONTRAT"
    '
    'GVFORMATION
    '
    Me.GVFORMATION.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.GVFORMATION.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.GVFORMATION.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
    Me.GVFORMATION.Appearance.ColumnFilterButton.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.ColumnFilterButton.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.ColumnFilterButton.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
    Me.GVFORMATION.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
    Me.GVFORMATION.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
    Me.GVFORMATION.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.GVFORMATION.Appearance.Empty.BackColor2 = System.Drawing.Color.White
    Me.GVFORMATION.Appearance.Empty.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
    Me.GVFORMATION.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
    Me.GVFORMATION.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
    Me.GVFORMATION.Appearance.EvenRow.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.EvenRow.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.EvenRow.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
    Me.GVFORMATION.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
    Me.GVFORMATION.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
    Me.GVFORMATION.Appearance.FilterCloseButton.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.FilterCloseButton.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.FilterCloseButton.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.GVFORMATION.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
    Me.GVFORMATION.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
    Me.GVFORMATION.Appearance.FilterPanel.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.FilterPanel.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
    Me.GVFORMATION.Appearance.FixedLine.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
    Me.GVFORMATION.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
    Me.GVFORMATION.Appearance.FocusedCell.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.FocusedCell.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
    Me.GVFORMATION.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
    Me.GVFORMATION.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
    Me.GVFORMATION.Appearance.FocusedRow.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.FocusedRow.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.FocusedRow.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.GVFORMATION.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.GVFORMATION.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
    Me.GVFORMATION.Appearance.FooterPanel.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.FooterPanel.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.FooterPanel.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
    Me.GVFORMATION.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
    Me.GVFORMATION.Appearance.GroupButton.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.GroupButton.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.GVFORMATION.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.GVFORMATION.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
    Me.GVFORMATION.Appearance.GroupFooter.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.GroupFooter.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.GroupFooter.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
    Me.GVFORMATION.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
    Me.GVFORMATION.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
    Me.GVFORMATION.Appearance.GroupPanel.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.GroupPanel.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.GVFORMATION.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.GVFORMATION.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
    Me.GVFORMATION.Appearance.GroupRow.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.GroupRow.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.GroupRow.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.GVFORMATION.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.GVFORMATION.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
    Me.GVFORMATION.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
    Me.GVFORMATION.Appearance.HeaderPanel.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.HeaderPanel.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.HeaderPanel.Options.UseFont = True
    Me.GVFORMATION.Appearance.HeaderPanel.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.GVFORMATION.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GVFORMATION.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GVFORMATION.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.GVFORMATION.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
    Me.GVFORMATION.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
    Me.GVFORMATION.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
    Me.GVFORMATION.Appearance.HideSelectionRow.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.HideSelectionRow.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.HideSelectionRow.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.GVFORMATION.Appearance.HorzLine.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVFORMATION.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVFORMATION.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
    Me.GVFORMATION.Appearance.OddRow.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.OddRow.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.OddRow.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
    Me.GVFORMATION.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
    Me.GVFORMATION.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
    Me.GVFORMATION.Appearance.Preview.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.Preview.Options.UseFont = True
    Me.GVFORMATION.Appearance.Preview.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVFORMATION.Appearance.Row.ForeColor = System.Drawing.Color.Black
    Me.GVFORMATION.Appearance.Row.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.Row.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.GVFORMATION.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
    Me.GVFORMATION.Appearance.RowSeparator.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
    Me.GVFORMATION.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
    Me.GVFORMATION.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
    Me.GVFORMATION.Appearance.SelectedRow.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.SelectedRow.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.SelectedRow.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
    Me.GVFORMATION.Appearance.TopNewRow.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.GVFORMATION.Appearance.VertLine.Options.UseBackColor = True
    Me.GVFORMATION.ColumnPanelRowHeight = 50
    Me.GVFORMATION.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NTYPECONTRAT, Me.NSITNUM, Me.VTYPECONTRAT, Me.VSITNOM, Me.VSITPAYS, Me.enseigne, Me.NSITNUE, Me.gestion})
    Me.GVFORMATION.GridControl = Me.GCFORMATION
    Me.GVFORMATION.Name = "GVFORMATION"
    Me.GVFORMATION.OptionsBehavior.Editable = False
    Me.GVFORMATION.OptionsNavigation.AutoFocusNewRow = True
    Me.GVFORMATION.OptionsView.EnableAppearanceOddRow = True
    Me.GVFORMATION.OptionsView.ShowAutoFilterRow = True
    Me.GVFORMATION.OptionsView.ShowFooter = True
    Me.GVFORMATION.OptionsView.ShowGroupPanel = False
    Me.GVFORMATION.RowHeight = 20
    '
    'VTYPECONTRAT
    '
    Me.VTYPECONTRAT.Caption = "Contrat"
    Me.VTYPECONTRAT.FieldName = "VTYPECONTRAT"
    Me.VTYPECONTRAT.Name = "VTYPECONTRAT"
    Me.VTYPECONTRAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    Me.VTYPECONTRAT.Visible = True
    Me.VTYPECONTRAT.VisibleIndex = 0
    Me.VTYPECONTRAT.Width = 497
    '
    'VSITNOM
    '
    Me.VSITNOM.Caption = "Site"
    Me.VSITNOM.FieldName = "VSITNOM"
    Me.VSITNOM.Name = "VSITNOM"
    Me.VSITNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    Me.VSITNOM.Visible = True
    Me.VSITNOM.VisibleIndex = 1
    Me.VSITNOM.Width = 176
    '
    'VSITPAYS
    '
    Me.VSITPAYS.Caption = "Pays"
    Me.VSITPAYS.FieldName = "VSITPAYS"
    Me.VSITPAYS.Name = "VSITPAYS"
    Me.VSITPAYS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    Me.VSITPAYS.Visible = True
    Me.VSITPAYS.VisibleIndex = 2
    Me.VSITPAYS.Width = 90
    '
    'enseigne
    '
    Me.enseigne.Caption = "Enseigne"
    Me.enseigne.FieldName = "VSITENSEIGNE"
    Me.enseigne.Name = "enseigne"
    Me.enseigne.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    Me.enseigne.Visible = True
    Me.enseigne.VisibleIndex = 3
    Me.enseigne.Width = 133
    '
    'NSITNUE
    '
    Me.NSITNUE.AppearanceCell.Options.UseTextOptions = True
    Me.NSITNUE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.NSITNUE.Caption = "N°"
    Me.NSITNUE.FieldName = "NSITNUE"
    Me.NSITNUE.Name = "NSITNUE"
    Me.NSITNUE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    Me.NSITNUE.Visible = True
    Me.NSITNUE.VisibleIndex = 4
    Me.NSITNUE.Width = 107
    '
    'gestion
    '
    Me.gestion.AppearanceCell.Options.UseTextOptions = True
    Me.gestion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gestion.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.gestion.Caption = "Gestion"
    Me.gestion.FieldName = "VCONTETAT"
    Me.gestion.Name = "gestion"
    Me.gestion.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    Me.gestion.Visible = True
    Me.gestion.VisibleIndex = 5
    Me.gestion.Width = 106
    '
    'GCFORMATION
    '
    Me.GCFORMATION.Location = New System.Drawing.Point(141, 95)
    Me.GCFORMATION.MainView = Me.GVFORMATION
    Me.GCFORMATION.Name = "GCFORMATION"
    Me.GCFORMATION.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemGLUpEditGTPLot, Me.RepItemGLUpEditUnite, Me.RepositoryItemCheckEdit1})
    Me.GCFORMATION.Size = New System.Drawing.Size(1395, 711)
    Me.GCFORMATION.TabIndex = 8
    Me.GCFORMATION.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVFORMATION})
    '
    'Label1
    '
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
    Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.Label1.Location = New System.Drawing.Point(141, 12)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(993, 30)
    Me.Label1.TabIndex = 10
    Me.Label1.Text = "Gestion des contrats sur les sites"
    '
    'GrpActions
    '
    Me.GrpActions.Controls.Add(Me.BtnExcel)
    Me.GrpActions.Controls.Add(Me.BtnMod)
    Me.GrpActions.Controls.Add(Me.BtnQuit)
    Me.GrpActions.Location = New System.Drawing.Point(12, 12)
    Me.GrpActions.Name = "GrpActions"
    Me.GrpActions.Size = New System.Drawing.Size(123, 801)
    Me.GrpActions.TabIndex = 9
    Me.GrpActions.TabStop = False
    '
    'BtnExcel
    '
    Me.BtnExcel.BackColor = System.Drawing.Color.LightSteelBlue
    Me.BtnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
    Me.BtnExcel.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.BtnExcel.Location = New System.Drawing.Point(6, 133)
    Me.BtnExcel.Name = "BtnExcel"
    Me.BtnExcel.Size = New System.Drawing.Size(108, 45)
    Me.BtnExcel.TabIndex = 8
    Me.BtnExcel.Text = "Export Excel"
    Me.BtnExcel.UseVisualStyleBackColor = False
    '
    'BtnMod
    '
    Me.BtnMod.BackColor = System.Drawing.Color.LightGreen
    Me.BtnMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
    Me.BtnMod.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.BtnMod.Location = New System.Drawing.Point(6, 83)
    Me.BtnMod.Name = "BtnMod"
    Me.BtnMod.Size = New System.Drawing.Size(108, 44)
    Me.BtnMod.TabIndex = 6
    Me.BtnMod.Text = "Modifier"
    Me.BtnMod.UseVisualStyleBackColor = False
    Me.BtnMod.Visible = False
    '
    'BtnQuit
    '
    Me.BtnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.BtnQuit.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.BtnQuit.Location = New System.Drawing.Point(6, 750)
    Me.BtnQuit.Name = "BtnQuit"
    Me.BtnQuit.Size = New System.Drawing.Size(108, 45)
    Me.BtnQuit.TabIndex = 1
    Me.BtnQuit.Text = "Fermer"
    Me.BtnQuit.UseVisualStyleBackColor = True
    '
    'Label2
    '
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
    Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.Label2.Location = New System.Drawing.Point(145, 48)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(166, 23)
    Me.Label2.TabIndex = 22
    Me.Label2.Text = "Choix du contrat :"
    '
    'GVCboChaff
    '
    Me.GVCboChaff.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCCboChaffNPERNUM, Me.GCCboChaffNOM})
    Me.GVCboChaff.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GVCboChaff.Name = "GVCboChaff"
    Me.GVCboChaff.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GVCboChaff.OptionsView.ShowAutoFilterRow = True
    Me.GVCboChaff.OptionsView.ShowGroupPanel = False
    '
    'GCCboChaffNPERNUM
    '
    Me.GCCboChaffNPERNUM.AppearanceHeader.Options.UseTextOptions = True
    Me.GCCboChaffNPERNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GCCboChaffNPERNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GCCboChaffNPERNUM.FieldName = "NTYPECONTRAT"
    Me.GCCboChaffNPERNUM.Name = "GCCboChaffNPERNUM"
    Me.GCCboChaffNPERNUM.OptionsColumn.AllowEdit = False
    Me.GCCboChaffNPERNUM.OptionsColumn.ReadOnly = True
    '
    'GCCboChaffNOM
    '
    Me.GCCboChaffNOM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
    Me.GCCboChaffNOM.AppearanceHeader.Options.UseFont = True
    Me.GCCboChaffNOM.AppearanceHeader.Options.UseTextOptions = True
    Me.GCCboChaffNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GCCboChaffNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GCCboChaffNOM.Caption = "Contrat"
    Me.GCCboChaffNOM.FieldName = "VTYPECONTRAT"
    Me.GCCboChaffNOM.Name = "GCCboChaffNOM"
    Me.GCCboChaffNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    Me.GCCboChaffNOM.Visible = True
    Me.GCCboChaffNOM.VisibleIndex = 0
    '
    'GlookUpContrat
    '
    Me.GlookUpContrat.EditValue = ""
    Me.GlookUpContrat.Location = New System.Drawing.Point(290, 49)
    Me.GlookUpContrat.Name = "GlookUpContrat"
    Me.GlookUpContrat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.GlookUpContrat.Properties.DisplayMember = "VTYPECONTRAT"
    Me.GlookUpContrat.Properties.NullText = ""
    Me.GlookUpContrat.Properties.ValueMember = "NTYPECONTRAT"
    Me.GlookUpContrat.Properties.View = Me.GVCboChaff
    Me.GlookUpContrat.Size = New System.Drawing.Size(328, 20)
    Me.GlookUpContrat.TabIndex = 23
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.NavajoWhite
    Me.Panel1.Controls.Add(Me.BtnGestForm)
    Me.Panel1.Controls.Add(Me.lblColonne)
    Me.Panel1.Controls.Add(Me.cmdValiderListe)
    Me.Panel1.Controls.Add(Me.cmdValiderLigne)
    Me.Panel1.Controls.Add(Me.CboValeur)
    Me.Panel1.Controls.Add(Me.Label4)
    Me.Panel1.Controls.Add(Me.Label3)
    Me.Panel1.Location = New System.Drawing.Point(656, 224)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(326, 280)
    Me.Panel1.TabIndex = 24
    Me.Panel1.Visible = False
    '
    'BtnGestForm
    '
    Me.BtnGestForm.BackColor = System.Drawing.Color.PaleGoldenrod
    Me.BtnGestForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.BtnGestForm.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.BtnGestForm.Location = New System.Drawing.Point(23, 218)
    Me.BtnGestForm.Name = "BtnGestForm"
    Me.BtnGestForm.Size = New System.Drawing.Size(260, 33)
    Me.BtnGestForm.TabIndex = 29
    Me.BtnGestForm.Text = "Annuler"
    Me.BtnGestForm.UseVisualStyleBackColor = False
    '
    'lblColonne
    '
    Me.lblColonne.BackColor = System.Drawing.Color.Transparent
    Me.lblColonne.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
    Me.lblColonne.ForeColor = System.Drawing.Color.Red
    Me.lblColonne.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.lblColonne.Location = New System.Drawing.Point(212, 23)
    Me.lblColonne.Name = "lblColonne"
    Me.lblColonne.Size = New System.Drawing.Size(84, 23)
    Me.lblColonne.TabIndex = 28
    Me.lblColonne.Text = "Valeur :"
    '
    'cmdValiderListe
    '
    Me.cmdValiderListe.BackColor = System.Drawing.Color.PaleGoldenrod
    Me.cmdValiderListe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.cmdValiderListe.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.cmdValiderListe.Location = New System.Drawing.Point(23, 179)
    Me.cmdValiderListe.Name = "cmdValiderListe"
    Me.cmdValiderListe.Size = New System.Drawing.Size(260, 33)
    Me.cmdValiderListe.TabIndex = 27
    Me.cmdValiderListe.Text = "VALIDER pour toutes les lignes filtrées"
    Me.cmdValiderListe.UseVisualStyleBackColor = False
    '
    'cmdValiderLigne
    '
    Me.cmdValiderLigne.BackColor = System.Drawing.Color.PaleGoldenrod
    Me.cmdValiderLigne.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.cmdValiderLigne.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.cmdValiderLigne.Location = New System.Drawing.Point(23, 138)
    Me.cmdValiderLigne.Name = "cmdValiderLigne"
    Me.cmdValiderLigne.Size = New System.Drawing.Size(260, 35)
    Me.cmdValiderLigne.TabIndex = 26
    Me.cmdValiderLigne.Text = "VALIDER pour cette ligne"
    Me.cmdValiderLigne.UseVisualStyleBackColor = False
    '
    'CboValeur
    '
    Me.CboValeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CboValeur.FormattingEnabled = True
    Me.CboValeur.Items.AddRange(New Object() {"OUI", "NON"})
    Me.CboValeur.Location = New System.Drawing.Point(91, 73)
    Me.CboValeur.Name = "CboValeur"
    Me.CboValeur.Size = New System.Drawing.Size(98, 21)
    Me.CboValeur.TabIndex = 25
    '
    'Label4
    '
    Me.Label4.BackColor = System.Drawing.Color.Transparent
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
    Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.Label4.Location = New System.Drawing.Point(20, 73)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(84, 23)
    Me.Label4.TabIndex = 24
    Me.Label4.Text = "Valeur :"
    '
    'Label3
    '
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
    Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.Label3.Location = New System.Drawing.Point(3, 23)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(186, 23)
    Me.Label3.TabIndex = 23
    Me.Label3.Text = "Gestion de la colonne : "
    '
    'frmGestionContratSite
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.ClientSize = New System.Drawing.Size(1999, 973)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.GlookUpContrat)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.GrpActions)
    Me.Controls.Add(Me.GCFORMATION)
    Me.Name = "frmGestionContratSite"
    Me.Text = "frmGestionContratSite"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GVFORMATION, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GCFORMATION, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GrpActions.ResumeLayout(False)
    CType(Me.GVCboChaff, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GlookUpContrat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Private WithEvents RepItemGLUpEditViewUnite As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents ColUNITEIDTMP As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents ColUNITENGTPUNITEID As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents ColUNITEVGTPUNITENOM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents ColLOTIDTMP As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents RepIGLUpEditViewLot As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents ColLOTNGTPLOTID As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents ColLOTVGTPLOTNOM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents RepItemGLUpEditUnite As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
  Private WithEvents RepItemGLUpEditGTPLot As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
  Private WithEvents NSITNUM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents NTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GVFORMATION As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents VTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents VSITNOM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents VSITPAYS As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents enseigne As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents NSITNUE As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents gestion As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GCFORMATION As DevExpress.XtraGrid.GridControl
  Friend WithEvents Label1 As Label
  Friend WithEvents GrpActions As GroupBox
  Friend WithEvents BtnExcel As Button
  Friend WithEvents BtnMod As Button
  Friend WithEvents BtnQuit As Button
  Friend WithEvents Label2 As Label
  Private WithEvents GVCboChaff As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents GCCboChaffNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GCCboChaffNOM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GlookUpContrat As DevExpress.XtraEditors.GridLookUpEdit
  Friend WithEvents Panel1 As Panel
  Friend WithEvents Label4 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents lblColonne As Label
  Friend WithEvents cmdValiderListe As Button
  Friend WithEvents cmdValiderLigne As Button
  Friend WithEvents CboValeur As ComboBox
  Friend WithEvents BtnGestForm As Button
End Class
