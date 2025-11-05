<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestTechClient
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
        Me.GrpBoxPers = New System.Windows.Forms.GroupBox()
        Me.BtnDecoche = New System.Windows.Forms.Button()
        Me.BtnCoche = New System.Windows.Forms.Button()
        Me.GCGestCliTech = New DevExpress.XtraGrid.GridControl()
        Me.GVGestCliTech = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColBCLITECHCOCHE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEditBCLITECHCOCHE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GColNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVPERPRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSERLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpBoxPers.SuspendLayout()
        CType(Me.GCGestCliTech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVGestCliTech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEditBCLITECHCOCHE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpBoxPers
        '
        Me.GrpBoxPers.Controls.Add(Me.BtnDecoche)
        Me.GrpBoxPers.Controls.Add(Me.BtnCoche)
        Me.GrpBoxPers.Controls.Add(Me.GCGestCliTech)
        Me.GrpBoxPers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GrpBoxPers.Location = New System.Drawing.Point(156, 46)
        Me.GrpBoxPers.Name = "GrpBoxPers"
        Me.GrpBoxPers.Size = New System.Drawing.Size(1160, 526)
        Me.GrpBoxPers.TabIndex = 22
        Me.GrpBoxPers.TabStop = False
        Me.GrpBoxPers.Text = "Sélection du personnel"
        '
        'BtnDecoche
        '
        Me.BtnDecoche.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnDecoche.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnDecoche.Location = New System.Drawing.Point(120, 490)
        Me.BtnDecoche.Name = "BtnDecoche"
        Me.BtnDecoche.Size = New System.Drawing.Size(108, 30)
        Me.BtnDecoche.TabIndex = 20
        Me.BtnDecoche.Text = "Décocher Tous"
        Me.BtnDecoche.UseVisualStyleBackColor = True
        '
        'BtnCoche
        '
        Me.BtnCoche.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnCoche.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCoche.Location = New System.Drawing.Point(6, 490)
        Me.BtnCoche.Name = "BtnCoche"
        Me.BtnCoche.Size = New System.Drawing.Size(108, 30)
        Me.BtnCoche.TabIndex = 19
        Me.BtnCoche.Text = "Cocher Tous"
        Me.BtnCoche.UseVisualStyleBackColor = True
        '
        'GCGestCliTech
        '
        Me.GCGestCliTech.Location = New System.Drawing.Point(6, 21)
        Me.GCGestCliTech.MainView = Me.GVGestCliTech
        Me.GCGestCliTech.Name = "GCGestCliTech"
        Me.GCGestCliTech.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEditBCLITECHCOCHE})
        Me.GCGestCliTech.Size = New System.Drawing.Size(1148, 463)
        Me.GCGestCliTech.TabIndex = 18
        Me.GCGestCliTech.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVGestCliTech})
        '
        'GVGestCliTech
        '
        Me.GVGestCliTech.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVGestCliTech.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVGestCliTech.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliTech.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVGestCliTech.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVGestCliTech.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVGestCliTech.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVGestCliTech.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliTech.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVGestCliTech.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVGestCliTech.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVGestCliTech.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVGestCliTech.Appearance.Empty.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVGestCliTech.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVGestCliTech.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliTech.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVGestCliTech.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVGestCliTech.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVGestCliTech.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVGestCliTech.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliTech.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVGestCliTech.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVGestCliTech.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVGestCliTech.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVGestCliTech.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliTech.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVGestCliTech.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVGestCliTech.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVGestCliTech.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliTech.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVGestCliTech.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GVGestCliTech.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVGestCliTech.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVGestCliTech.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVGestCliTech.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVGestCliTech.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliTech.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVGestCliTech.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVGestCliTech.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVGestCliTech.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVGestCliTech.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVGestCliTech.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVGestCliTech.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVGestCliTech.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliTech.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVGestCliTech.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVGestCliTech.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVGestCliTech.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVGestCliTech.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliTech.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVGestCliTech.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVGestCliTech.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVGestCliTech.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliTech.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVGestCliTech.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVGestCliTech.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVGestCliTech.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVGestCliTech.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GVGestCliTech.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliTech.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVGestCliTech.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVGestCliTech.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVGestCliTech.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVGestCliTech.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVGestCliTech.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVGestCliTech.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVGestCliTech.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVGestCliTech.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVGestCliTech.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVGestCliTech.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVGestCliTech.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVGestCliTech.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVGestCliTech.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVGestCliTech.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliTech.Appearance.OddRow.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVGestCliTech.Appearance.OddRow.Options.UseForeColor = True
        Me.GVGestCliTech.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVGestCliTech.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVGestCliTech.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVGestCliTech.Appearance.Preview.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.Preview.Options.UseFont = True
        Me.GVGestCliTech.Appearance.Preview.Options.UseForeColor = True
        Me.GVGestCliTech.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVGestCliTech.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GVGestCliTech.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliTech.Appearance.Row.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.Row.Options.UseFont = True
        Me.GVGestCliTech.Appearance.Row.Options.UseForeColor = True
        Me.GVGestCliTech.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVGestCliTech.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVGestCliTech.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVGestCliTech.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliTech.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVGestCliTech.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVGestCliTech.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVGestCliTech.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVGestCliTech.Appearance.VertLine.Options.UseBackColor = True
        Me.GVGestCliTech.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVGestCliTech.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColBCLITECHCOCHE, Me.GColNPERNUM, Me.GColVPERNOM, Me.GColVPERPRE, Me.GColVSERLIB, Me.GColVCLINOM})
        Me.GVGestCliTech.GridControl = Me.GCGestCliTech
        Me.GVGestCliTech.Name = "GVGestCliTech"
        Me.GVGestCliTech.OptionsView.EnableAppearanceEvenRow = True
        Me.GVGestCliTech.OptionsView.EnableAppearanceOddRow = True
        Me.GVGestCliTech.OptionsView.ShowAutoFilterRow = True
        Me.GVGestCliTech.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVGestCliTech.OptionsView.ShowFooter = True
        Me.GVGestCliTech.OptionsView.ShowGroupPanel = False
        '
        'GColBCLITECHCOCHE
        '
        Me.GColBCLITECHCOCHE.Caption = "Affecte"
        Me.GColBCLITECHCOCHE.ColumnEdit = Me.RepositoryItemCheckEditBCLITECHCOCHE
        Me.GColBCLITECHCOCHE.FieldName = "BCLITECHCOCHE"
        Me.GColBCLITECHCOCHE.Name = "GColBCLITECHCOCHE"
        Me.GColBCLITECHCOCHE.Visible = True
        Me.GColBCLITECHCOCHE.VisibleIndex = 0
        Me.GColBCLITECHCOCHE.Width = 70
        '
        'RepositoryItemCheckEditBCLITECHCOCHE
        '
        Me.RepositoryItemCheckEditBCLITECHCOCHE.AutoHeight = False
        Me.RepositoryItemCheckEditBCLITECHCOCHE.Name = "RepositoryItemCheckEditBCLITECHCOCHE"
        Me.RepositoryItemCheckEditBCLITECHCOCHE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEditBCLITECHCOCHE.ValueChecked = 1
        Me.RepositoryItemCheckEditBCLITECHCOCHE.ValueUnchecked = 0
        '
        'GColNPERNUM
        '
        Me.GColNPERNUM.Caption = "NPERNUM"
        Me.GColNPERNUM.FieldName = "NPERNUM"
        Me.GColNPERNUM.Name = "GColNPERNUM"
        Me.GColNPERNUM.OptionsColumn.ReadOnly = True
        '
        'GColVPERNOM
        '
        Me.GColVPERNOM.Caption = "Nom"
        Me.GColVPERNOM.FieldName = "VPERNOM"
        Me.GColVPERNOM.Name = "GColVPERNOM"
        Me.GColVPERNOM.OptionsColumn.AllowEdit = False
        Me.GColVPERNOM.OptionsColumn.ReadOnly = True
        Me.GColVPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVPERNOM.Visible = True
        Me.GColVPERNOM.VisibleIndex = 1
        Me.GColVPERNOM.Width = 265
        '
        'GColVPERPRE
        '
        Me.GColVPERPRE.Caption = "Prénom"
        Me.GColVPERPRE.FieldName = "VPERPRE"
        Me.GColVPERPRE.Name = "GColVPERPRE"
        Me.GColVPERPRE.OptionsColumn.AllowEdit = False
        Me.GColVPERPRE.OptionsColumn.ReadOnly = True
        Me.GColVPERPRE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVPERPRE.Visible = True
        Me.GColVPERPRE.VisibleIndex = 2
        Me.GColVPERPRE.Width = 265
        '
        'GColVSERLIB
        '
        Me.GColVSERLIB.Caption = "Service"
        Me.GColVSERLIB.FieldName = "VSERLIB"
        Me.GColVSERLIB.Name = "GColVSERLIB"
        Me.GColVSERLIB.OptionsColumn.AllowEdit = False
        Me.GColVSERLIB.OptionsColumn.ReadOnly = True
        Me.GColVSERLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVSERLIB.Visible = True
        Me.GColVSERLIB.VisibleIndex = 3
        Me.GColVSERLIB.Width = 265
        '
        'GColVCLINOM
        '
        Me.GColVCLINOM.Caption = "Client"
        Me.GColVCLINOM.FieldName = "VCLINOM"
        Me.GColVCLINOM.Name = "GColVCLINOM"
        Me.GColVCLINOM.OptionsColumn.AllowEdit = False
        Me.GColVCLINOM.OptionsColumn.ReadOnly = True
        Me.GColVCLINOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVCLINOM.Visible = True
        Me.GColVCLINOM.VisibleIndex = 4
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Controls.Add(Me.BtnSave)
        Me.GrpActions.Location = New System.Drawing.Point(15, 5)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(120, 567)
        Me.GrpActions.TabIndex = 21
        Me.GrpActions.TabStop = False
        '
        'BtnQuit
        '
        Me.BtnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnQuit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnQuit.Location = New System.Drawing.Point(6, 503)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(108, 45)
        Me.BtnQuit.TabIndex = 6
        Me.BtnQuit.Text = "Fermer"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSave.Location = New System.Drawing.Point(6, 71)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(108, 44)
        Me.BtnSave.TabIndex = 5
        Me.BtnSave.Text = "Enregistrer"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        Me.LblTitre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(151, 9)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(1165, 29)
        Me.LblTitre.TabIndex = 25
        Me.LblTitre.Text = "Gestion des contremaitres des clients"
        '
        'FrmGestTechClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1478, 642)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpBoxPers)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "FrmGestTechClient"
        Me.Text = "FrmGestTechClient"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpBoxPers.ResumeLayout(False)
        CType(Me.GCGestCliTech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVGestCliTech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEditBCLITECHCOCHE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpBoxPers As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDecoche As System.Windows.Forms.Button
    Friend WithEvents BtnCoche As System.Windows.Forms.Button
    Private WithEvents GCGestCliTech As DevExpress.XtraGrid.GridControl
    Private WithEvents GVGestCliTech As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColBCLITECHCOCHE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepositoryItemCheckEditBCLITECHCOCHE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents GColNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVPERPRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVSERLIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GColVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
End Class
