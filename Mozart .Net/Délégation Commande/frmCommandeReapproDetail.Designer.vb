<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCommandeReapproDetail
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
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnMessage = New System.Windows.Forms.Button()
        Me.BtnPasseCmd = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GCREAPPRO = New DevExpress.XtraGrid.GridControl()
        Me.GVREAPPRO = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNFOUNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVFOUMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNCMDQTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GColDCMDDATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNCMDWEBNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CboLieuLivr = New System.Windows.Forms.ComboBox()
        Me.DTP_LIVR = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCREAPPRO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVREAPPRO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnSave)
        Me.GrpActions.Controls.Add(Me.BtnMessage)
        Me.GrpActions.Controls.Add(Me.BtnPasseCmd)
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Location = New System.Drawing.Point(12, 12)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(137, 744)
        Me.GrpActions.TabIndex = 12
        Me.GrpActions.TabStop = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSave.Location = New System.Drawing.Point(6, 152)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(125, 44)
        Me.BtnSave.TabIndex = 12
        Me.BtnSave.Text = "Enregistrer"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnMessage
        '
        Me.BtnMessage.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnMessage.Location = New System.Drawing.Point(6, 390)
        Me.BtnMessage.Name = "BtnMessage"
        Me.BtnMessage.Size = New System.Drawing.Size(125, 45)
        Me.BtnMessage.TabIndex = 11
        Me.BtnMessage.Text = "Messages"
        Me.BtnMessage.UseVisualStyleBackColor = False
        '
        'BtnPasseCmd
        '
        Me.BtnPasseCmd.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnPasseCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnPasseCmd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPasseCmd.Location = New System.Drawing.Point(6, 212)
        Me.BtnPasseCmd.Name = "BtnPasseCmd"
        Me.BtnPasseCmd.Size = New System.Drawing.Size(125, 44)
        Me.BtnPasseCmd.TabIndex = 6
        Me.BtnPasseCmd.Text = "Transmission réappro"
        Me.BtnPasseCmd.UseVisualStyleBackColor = False
        '
        'BtnQuit
        '
        Me.BtnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnQuit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnQuit.Location = New System.Drawing.Point(6, 682)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(125, 45)
        Me.BtnQuit.TabIndex = 1
        Me.BtnQuit.Text = "Fermer"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(155, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(993, 30)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Liste des fournitures de la commande de réappro technicien à valider"
        '
        'GCREAPPRO
        '
        Me.GCREAPPRO.Location = New System.Drawing.Point(159, 154)
        Me.GCREAPPRO.MainView = Me.GVREAPPRO
        Me.GCREAPPRO.Name = "GCREAPPRO"
        Me.GCREAPPRO.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.GCREAPPRO.Size = New System.Drawing.Size(1377, 821)
        Me.GCREAPPRO.TabIndex = 11
        Me.GCREAPPRO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVREAPPRO})
        '
        'GVREAPPRO
        '
        Me.GVREAPPRO.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVREAPPRO.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVREAPPRO.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVREAPPRO.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVREAPPRO.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVREAPPRO.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVREAPPRO.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVREAPPRO.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVREAPPRO.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVREAPPRO.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVREAPPRO.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVREAPPRO.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVREAPPRO.Appearance.Empty.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVREAPPRO.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVREAPPRO.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVREAPPRO.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVREAPPRO.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVREAPPRO.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVREAPPRO.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVREAPPRO.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVREAPPRO.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVREAPPRO.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVREAPPRO.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVREAPPRO.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVREAPPRO.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVREAPPRO.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVREAPPRO.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GVREAPPRO.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVREAPPRO.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVREAPPRO.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVREAPPRO.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.GVREAPPRO.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVREAPPRO.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVREAPPRO.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVREAPPRO.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVREAPPRO.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVREAPPRO.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVREAPPRO.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVREAPPRO.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVREAPPRO.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVREAPPRO.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVREAPPRO.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVREAPPRO.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVREAPPRO.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVREAPPRO.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVREAPPRO.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVREAPPRO.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVREAPPRO.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVREAPPRO.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.GVREAPPRO.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVREAPPRO.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVREAPPRO.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVREAPPRO.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVREAPPRO.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVREAPPRO.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVREAPPRO.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVREAPPRO.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVREAPPRO.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVREAPPRO.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVREAPPRO.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GVREAPPRO.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVREAPPRO.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVREAPPRO.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVREAPPRO.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVREAPPRO.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVREAPPRO.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVREAPPRO.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVREAPPRO.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVREAPPRO.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVREAPPRO.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVREAPPRO.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVREAPPRO.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVREAPPRO.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVREAPPRO.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVREAPPRO.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVREAPPRO.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVREAPPRO.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVREAPPRO.Appearance.OddRow.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVREAPPRO.Appearance.OddRow.Options.UseForeColor = True
        Me.GVREAPPRO.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVREAPPRO.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVREAPPRO.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GVREAPPRO.Appearance.Preview.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.Preview.Options.UseFont = True
        Me.GVREAPPRO.Appearance.Preview.Options.UseForeColor = True
        Me.GVREAPPRO.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVREAPPRO.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVREAPPRO.Appearance.Row.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.Row.Options.UseForeColor = True
        Me.GVREAPPRO.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVREAPPRO.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVREAPPRO.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVREAPPRO.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVREAPPRO.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVREAPPRO.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GVREAPPRO.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVREAPPRO.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVREAPPRO.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVREAPPRO.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVREAPPRO.Appearance.VertLine.Options.UseBackColor = True
        Me.GVREAPPRO.ColumnPanelRowHeight = 50
        Me.GVREAPPRO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNPERNUM, Me.GColNFOUNUM, Me.GColVFOUMAT, Me.GColNCMDQTE, Me.GColDCMDDATE, Me.GColNCMDWEBNUM})
        Me.GVREAPPRO.GridControl = Me.GCREAPPRO
        Me.GVREAPPRO.Name = "GVREAPPRO"
        Me.GVREAPPRO.OptionsNavigation.AutoFocusNewRow = True
        Me.GVREAPPRO.OptionsView.EnableAppearanceOddRow = True
        Me.GVREAPPRO.OptionsView.ShowAutoFilterRow = True
        Me.GVREAPPRO.OptionsView.ShowFooter = True
        Me.GVREAPPRO.OptionsView.ShowGroupPanel = False
        Me.GVREAPPRO.RowHeight = 20
        '
        'GColNPERNUM
        '
        Me.GColNPERNUM.Caption = "NPERNUM"
        Me.GColNPERNUM.FieldName = "NPERNUM"
        Me.GColNPERNUM.Name = "GColNPERNUM"
        Me.GColNPERNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColNPERNUM.Width = 176
        '
        'GColNFOUNUM
        '
        Me.GColNFOUNUM.Caption = "NFOUNUM"
        Me.GColNFOUNUM.FieldName = "NFOUNUM"
        Me.GColNFOUNUM.Name = "GColNFOUNUM"
        '
        'GColVFOUMAT
        '
        Me.GColVFOUMAT.Caption = "Fourniture"
        Me.GColVFOUMAT.FieldName = "VFOUMAT"
        Me.GColVFOUMAT.Name = "GColVFOUMAT"
        Me.GColVFOUMAT.OptionsColumn.AllowEdit = False
        Me.GColVFOUMAT.OptionsColumn.ReadOnly = True
        Me.GColVFOUMAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVFOUMAT.Visible = True
        Me.GColVFOUMAT.VisibleIndex = 0
        '
        'GColNCMDQTE
        '
        Me.GColNCMDQTE.Caption = "Quantité demandée"
        Me.GColNCMDQTE.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GColNCMDQTE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColNCMDQTE.FieldName = "NCMDQTE"
        Me.GColNCMDQTE.Name = "GColNCMDQTE"
        Me.GColNCMDQTE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColNCMDQTE.Visible = True
        Me.GColNCMDQTE.VisibleIndex = 1
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatString = "n0"
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.EditFormat.FormatString = "n0"
        Me.RepositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GColDCMDDATE
        '
        Me.GColDCMDDATE.Caption = "DCMDDATE"
        Me.GColDCMDDATE.FieldName = "DCMDDATE"
        Me.GColDCMDDATE.Name = "GColDCMDDATE"
        '
        'GColNCMDWEBNUM
        '
        Me.GColNCMDWEBNUM.Caption = "NCMDWEBNUM"
        Me.GColNCMDWEBNUM.FieldName = "NCMDWEBNUM"
        Me.GColNCMDWEBNUM.Name = "GColNCMDWEBNUM"
        '
        'CboLieuLivr
        '
        Me.CboLieuLivr.DisplayMember = "VLIBLIVR"
        Me.CboLieuLivr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLieuLivr.FormattingEnabled = True
        Me.CboLieuLivr.Location = New System.Drawing.Point(379, 30)
        Me.CboLieuLivr.Name = "CboLieuLivr"
        Me.CboLieuLivr.Size = New System.Drawing.Size(311, 21)
        Me.CboLieuLivr.TabIndex = 14
        Me.CboLieuLivr.ValueMember = "CODE_LIVR"
        '
        'DTP_LIVR
        '
        Me.DTP_LIVR.Location = New System.Drawing.Point(379, 76)
        Me.DTP_LIVR.Name = "DTP_LIVR"
        Me.DTP_LIVR.Size = New System.Drawing.Size(372, 20)
        Me.DTP_LIVR.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(155, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 30)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Lieu de livraison"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(155, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(218, 30)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Date de livraison"
        '
        'frmCommandeReapproDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1908, 1061)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTP_LIVR)
        Me.Controls.Add(Me.CboLieuLivr)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GCREAPPRO)
        Me.Name = "frmCommandeReapproDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Liste des fournitures de la commande de réappro technicien à valider"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCREAPPRO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVREAPPRO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnMessage As Button
    Friend WithEvents BtnPasseCmd As Button
    Friend WithEvents BtnQuit As Button
    Friend WithEvents Label1 As Label
    Private WithEvents GCREAPPRO As DevExpress.XtraGrid.GridControl
    Private WithEvents GVREAPPRO As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CboLieuLivr As ComboBox
    Friend WithEvents DTP_LIVR As DateTimePicker
    Friend WithEvents GColNFOUNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVFOUMAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNCMDQTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GColDCMDDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNCMDWEBNUM As DevExpress.XtraGrid.Columns.GridColumn
End Class
