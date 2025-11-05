<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestContratClient
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
    Me.GrpBoxActions = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GCContrat = New DevExpress.XtraGrid.GridControl()
        Me.GVContrat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColCHECK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEditCHECK = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GColNTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNMONTANTCONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCODEFACT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCODEOPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVDELAIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.BtnHelpKPI_DateContractuel = New System.Windows.Forms.Button()
        Me.GrpBoxActions.SuspendLayout()
        CType(Me.GCContrat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVContrat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEditCHECK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpBoxActions
        '
        Me.GrpBoxActions.Controls.Add(Me.Button1)
        Me.GrpBoxActions.Controls.Add(Me.BtnSave)
        Me.GrpBoxActions.Location = New System.Drawing.Point(12, 12)
        Me.GrpBoxActions.Name = "GrpBoxActions"
        Me.GrpBoxActions.Size = New System.Drawing.Size(150, 590)
        Me.GrpBoxActions.TabIndex = 12
        Me.GrpBoxActions.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(9, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 48)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Export EXCEL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSave.Location = New System.Drawing.Point(9, 55)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(131, 44)
        Me.BtnSave.TabIndex = 13
        Me.BtnSave.Text = "Enregistrer"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnFermer
        '
        Me.BtnFermer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnFermer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(18, 639)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(134, 38)
        Me.BtnFermer.TabIndex = 6
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = False
        '
        'GCContrat
        '
        Me.GCContrat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCContrat.Location = New System.Drawing.Point(177, 39)
        Me.GCContrat.MainView = Me.GVContrat
        Me.GCContrat.Name = "GCContrat"
        Me.GCContrat.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEditCHECK})
        Me.GCContrat.Size = New System.Drawing.Size(1263, 638)
        Me.GCContrat.TabIndex = 21
        Me.GCContrat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVContrat})
        '
        'GVContrat
        '
        Me.GVContrat.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVContrat.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVContrat.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVContrat.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVContrat.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVContrat.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVContrat.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVContrat.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVContrat.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVContrat.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVContrat.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVContrat.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVContrat.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVContrat.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVContrat.Appearance.Empty.Options.UseBackColor = True
        Me.GVContrat.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVContrat.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVContrat.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVContrat.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVContrat.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVContrat.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVContrat.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVContrat.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVContrat.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVContrat.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVContrat.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVContrat.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVContrat.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVContrat.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVContrat.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVContrat.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVContrat.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVContrat.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVContrat.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVContrat.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVContrat.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVContrat.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVContrat.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVContrat.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GVContrat.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVContrat.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVContrat.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVContrat.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVContrat.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVContrat.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVContrat.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVContrat.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVContrat.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVContrat.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVContrat.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVContrat.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVContrat.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVContrat.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVContrat.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVContrat.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVContrat.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVContrat.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVContrat.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVContrat.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVContrat.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVContrat.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVContrat.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVContrat.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVContrat.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVContrat.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVContrat.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVContrat.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVContrat.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVContrat.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVContrat.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVContrat.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVContrat.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GVContrat.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVContrat.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVContrat.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVContrat.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVContrat.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVContrat.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVContrat.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVContrat.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVContrat.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVContrat.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVContrat.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVContrat.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVContrat.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVContrat.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVContrat.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVContrat.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVContrat.Appearance.OddRow.Options.UseBackColor = True
        Me.GVContrat.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVContrat.Appearance.OddRow.Options.UseForeColor = True
        Me.GVContrat.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVContrat.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVContrat.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVContrat.Appearance.Preview.Options.UseBackColor = True
        Me.GVContrat.Appearance.Preview.Options.UseFont = True
        Me.GVContrat.Appearance.Preview.Options.UseForeColor = True
        Me.GVContrat.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVContrat.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GVContrat.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVContrat.Appearance.Row.Options.UseBackColor = True
        Me.GVContrat.Appearance.Row.Options.UseFont = True
        Me.GVContrat.Appearance.Row.Options.UseForeColor = True
        Me.GVContrat.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVContrat.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVContrat.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVContrat.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVContrat.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVContrat.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVContrat.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVContrat.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVContrat.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVContrat.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVContrat.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVContrat.Appearance.VertLine.Options.UseBackColor = True
        Me.GVContrat.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVContrat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCHECK, Me.GColNTYPECONTRAT, Me.GColVTYPECONTRAT, Me.GColNMONTANTCONTRAT, Me.GColVCODEFACT, Me.GColVCODEOPE, Me.GColVDELAIS, Me.GColNCLINUM})
        Me.GVContrat.GridControl = Me.GCContrat
        Me.GVContrat.Name = "GVContrat"
        Me.GVContrat.OptionsView.EnableAppearanceEvenRow = True
        Me.GVContrat.OptionsView.EnableAppearanceOddRow = True
        Me.GVContrat.OptionsView.ShowAutoFilterRow = True
        Me.GVContrat.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVContrat.OptionsView.ShowFooter = True
        Me.GVContrat.OptionsView.ShowGroupPanel = False
        '
        'GColCHECK
        '
        Me.GColCHECK.AppearanceHeader.Options.UseTextOptions = True
        Me.GColCHECK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCHECK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColCHECK.Caption = "Affecte"
        Me.GColCHECK.ColumnEdit = Me.RepositoryItemCheckEditCHECK
        Me.GColCHECK.FieldName = "BCONTRATAFFECTE"
        Me.GColCHECK.Name = "GColCHECK"
        Me.GColCHECK.Visible = True
        Me.GColCHECK.VisibleIndex = 0
        Me.GColCHECK.Width = 127
        '
        'RepositoryItemCheckEditCHECK
        '
        Me.RepositoryItemCheckEditCHECK.AutoHeight = False
        Me.RepositoryItemCheckEditCHECK.Name = "RepositoryItemCheckEditCHECK"
        Me.RepositoryItemCheckEditCHECK.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEditCHECK.ValueChecked = 1
        Me.RepositoryItemCheckEditCHECK.ValueUnchecked = 0
        '
        'GColNTYPECONTRAT
        '
        Me.GColNTYPECONTRAT.Caption = "NTYPECONTRAT"
        Me.GColNTYPECONTRAT.FieldName = "NTYPECONTRAT"
        Me.GColNTYPECONTRAT.Name = "GColNTYPECONTRAT"
        Me.GColNTYPECONTRAT.OptionsColumn.ReadOnly = True
        '
        'GColVTYPECONTRAT
        '
        Me.GColVTYPECONTRAT.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVTYPECONTRAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVTYPECONTRAT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVTYPECONTRAT.Caption = "Type contrat"
        Me.GColVTYPECONTRAT.FieldName = "VTYPECONTRAT"
        Me.GColVTYPECONTRAT.Name = "GColVTYPECONTRAT"
        Me.GColVTYPECONTRAT.OptionsColumn.AllowEdit = False
        Me.GColVTYPECONTRAT.OptionsColumn.ReadOnly = True
        Me.GColVTYPECONTRAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVTYPECONTRAT.Visible = True
        Me.GColVTYPECONTRAT.VisibleIndex = 1
        Me.GColVTYPECONTRAT.Width = 385
        '
        'GColNMONTANTCONTRAT
        '
        Me.GColNMONTANTCONTRAT.AppearanceHeader.Options.UseTextOptions = True
        Me.GColNMONTANTCONTRAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNMONTANTCONTRAT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColNMONTANTCONTRAT.Caption = "Montant contrat"
        Me.GColNMONTANTCONTRAT.DisplayFormat.FormatString = "n2"
        Me.GColNMONTANTCONTRAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColNMONTANTCONTRAT.FieldName = "NMONTANTCONTRAT"
        Me.GColNMONTANTCONTRAT.Name = "GColNMONTANTCONTRAT"
        Me.GColNMONTANTCONTRAT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NMONTANTCONTRAT", "Total ={0:n2}")})
        Me.GColNMONTANTCONTRAT.Visible = True
        Me.GColNMONTANTCONTRAT.VisibleIndex = 2
        Me.GColNMONTANTCONTRAT.Width = 135
        '
        'GColVCODEFACT
        '
        Me.GColVCODEFACT.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVCODEFACT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVCODEFACT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVCODEFACT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColVCODEFACT.Caption = "Code"
        Me.GColVCODEFACT.FieldName = "VCODEFACT"
        Me.GColVCODEFACT.Name = "GColVCODEFACT"
        Me.GColVCODEFACT.Visible = True
        Me.GColVCODEFACT.VisibleIndex = 3
        Me.GColVCODEFACT.Width = 135
        '
        'GColVCODEOPE
        '
        Me.GColVCODEOPE.AppearanceCell.Options.UseTextOptions = True
        Me.GColVCODEOPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVCODEOPE.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColVCODEOPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVCODEOPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVCODEOPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVCODEOPE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColVCODEOPE.Caption = "Afficher sur le web le planning préventif "
        Me.GColVCODEOPE.FieldName = "VCODEOPE"
        Me.GColVCODEOPE.Name = "GColVCODEOPE"
        Me.GColVCODEOPE.Visible = True
        Me.GColVCODEOPE.VisibleIndex = 4
        Me.GColVCODEOPE.Width = 287
        '
        'GColVDELAIS
        '
        Me.GColVDELAIS.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVDELAIS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVDELAIS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVDELAIS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColVDELAIS.Caption = "Afficher pour intervention web"
        Me.GColVDELAIS.FieldName = "VDELAIS"
        Me.GColVDELAIS.Name = "GColVDELAIS"
        Me.GColVDELAIS.Visible = True
        Me.GColVDELAIS.VisibleIndex = 5
        Me.GColVDELAIS.Width = 176
        '
        'GColNCLINUM
        '
        Me.GColNCLINUM.Caption = "NCLINUM"
        Me.GColNCLINUM.FieldName = "NCLINUM"
        Me.GColNCLINUM.Name = "GColNCLINUM"
        '
        'LblTitre
        '
        Me.LblTitre.AutoSize = True
        Me.LblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitre.ForeColor = System.Drawing.Color.IndianRed
        Me.LblTitre.Location = New System.Drawing.Point(173, 12)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(329, 24)
        Me.LblTitre.TabIndex = 20
        Me.LblTitre.Text = "Gestion des contrats du client : {0}"
        '
        'BtnHelpKPI_DateContractuel
        '
        Me.BtnHelpKPI_DateContractuel.BackgroundImage = Global.MozartNet.My.Resources.Resources._49277
        Me.BtnHelpKPI_DateContractuel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHelpKPI_DateContractuel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnHelpKPI_DateContractuel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnHelpKPI_DateContractuel.Location = New System.Drawing.Point(1013, 3)
        Me.BtnHelpKPI_DateContractuel.Name = "BtnHelpKPI_DateContractuel"
        Me.BtnHelpKPI_DateContractuel.Size = New System.Drawing.Size(49, 30)
        Me.BtnHelpKPI_DateContractuel.TabIndex = 109
        Me.BtnHelpKPI_DateContractuel.UseVisualStyleBackColor = True
        '
        'frmGestContratClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnFermer
        Me.ClientSize = New System.Drawing.Size(1452, 689)
        Me.Controls.Add(Me.BtnHelpKPI_DateContractuel)
        Me.Controls.Add(Me.GCContrat)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpBoxActions)
        Me.Name = "frmGestContratClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion des contrats du client"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpBoxActions.ResumeLayout(False)
        CType(Me.GCContrat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVContrat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEditCHECK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpBoxActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents GCContrat As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVContrat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GColCHECK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEditCHECK As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GColNTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GColVCODEFACT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVCODEOPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVDELAIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNMONTANTCONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents SFD As SaveFileDialog
    Friend WithEvents BtnHelpKPI_DateContractuel As Button
End Class
