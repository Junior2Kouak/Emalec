<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSyntheseEnquetesQual
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboClient = New System.Windows.Forms.ComboBox()
        Me.BtValider = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GCListeFouEI = New DevExpress.XtraGrid.GridControl()
        Me.BandedGridView2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand12 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn21 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn22 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.DTPFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPDebut = New System.Windows.Forms.DateTimePicker()
        CType(Me.GCListeFouEI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(524, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(521, 19)
        Me.Label6.TabIndex = 132
        Me.Label6.Text = "La liste des clients dépend de vos droits et des enquêtes existantes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(128, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Client :"
        '
        'cboClient
        '
        Me.cboClient.DisplayMember = "VCLINOM"
        Me.cboClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClient.FormattingEnabled = True
        Me.cboClient.Location = New System.Drawing.Point(230, 134)
        Me.cboClient.Name = "cboClient"
        Me.cboClient.Size = New System.Drawing.Size(272, 21)
        Me.cboClient.TabIndex = 130
        Me.cboClient.ValueMember = "NCLINUM"
        '
        'BtValider
        '
        Me.BtValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtValider.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtValider.Location = New System.Drawing.Point(945, 73)
        Me.BtValider.Name = "BtValider"
        Me.BtValider.Size = New System.Drawing.Size(75, 31)
        Me.BtValider.TabIndex = 129
        Me.BtValider.Text = "Valider"
        Me.BtValider.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(128, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 19)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Période d'exécution des actions :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(127, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1173, 26)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Synthèse des enquêtes qualités"
        '
        'GCListeFouEI
        '
        Me.GCListeFouEI.Location = New System.Drawing.Point(132, 185)
        Me.GCListeFouEI.MainView = Me.BandedGridView2
        Me.GCListeFouEI.Name = "GCListeFouEI"
        Me.GCListeFouEI.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit2})
        Me.GCListeFouEI.Size = New System.Drawing.Size(794, 451)
        Me.GCListeFouEI.TabIndex = 133
        Me.GCListeFouEI.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView2})
        '
        'BandedGridView2
        '
        Me.BandedGridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.BandedGridView2.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.BandedGridView2.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.BandedGridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.BandedGridView2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.BandedGridView2.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView2.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.BandedGridView2.Appearance.Empty.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView2.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView2.Appearance.EvenRow.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.EvenRow.Options.UseBorderColor = True
        Me.BandedGridView2.Appearance.EvenRow.Options.UseForeColor = True
        Me.BandedGridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.BandedGridView2.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.BandedGridView2.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.BandedGridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView2.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.BandedGridView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView2.Appearance.FilterPanel.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.FilterPanel.Options.UseForeColor = True
        Me.BandedGridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.BandedGridView2.Appearance.FixedLine.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.BandedGridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.BandedGridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BandedGridView2.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BandedGridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.BandedGridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.BandedGridView2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.BandedGridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView2.Appearance.FooterPanel.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.BandedGridView2.Appearance.FooterPanel.Options.UseForeColor = True
        Me.BandedGridView2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView2.Appearance.GroupButton.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.GroupButton.Options.UseBorderColor = True
        Me.BandedGridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView2.Appearance.GroupFooter.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.BandedGridView2.Appearance.GroupFooter.Options.UseForeColor = True
        Me.BandedGridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView2.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.BandedGridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView2.Appearance.GroupPanel.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.GroupPanel.Options.UseForeColor = True
        Me.BandedGridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView2.Appearance.GroupRow.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.GroupRow.Options.UseBorderColor = True
        Me.BandedGridView2.Appearance.GroupRow.Options.UseForeColor = True
        Me.BandedGridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView2.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.BandedGridView2.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.BandedGridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BandedGridView2.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BandedGridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.BandedGridView2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.BandedGridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView2.Appearance.HorzLine.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView2.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView2.Appearance.OddRow.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.OddRow.Options.UseBorderColor = True
        Me.BandedGridView2.Appearance.OddRow.Options.UseForeColor = True
        Me.BandedGridView2.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.BandedGridView2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BandedGridView2.Appearance.Preview.Options.UseFont = True
        Me.BandedGridView2.Appearance.Preview.Options.UseForeColor = True
        Me.BandedGridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView2.Appearance.Row.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.Row.Options.UseForeColor = True
        Me.BandedGridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView2.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.BandedGridView2.Appearance.RowSeparator.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BandedGridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.BandedGridView2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.BandedGridView2.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.BandedGridView2.Appearance.TopNewRow.Options.UseBackColor = True
        Me.BandedGridView2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView2.Appearance.VertLine.Options.UseBackColor = True
        Me.BandedGridView2.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand12})
        Me.BandedGridView2.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BandedGridColumn2, Me.BandedGridColumn1, Me.BandedGridColumn21, Me.BandedGridColumn22})
        Me.BandedGridView2.CustomizationFormBounds = New System.Drawing.Rectangle(1072, 596, 216, 208)
        Me.BandedGridView2.GridControl = Me.GCListeFouEI
        Me.BandedGridView2.GroupCount = 1
        Me.BandedGridView2.Name = "BandedGridView2"
        Me.BandedGridView2.OptionsBehavior.AutoExpandAllGroups = True
        Me.BandedGridView2.OptionsBehavior.Editable = False
        Me.BandedGridView2.OptionsBehavior.ReadOnly = True
        Me.BandedGridView2.OptionsView.EnableAppearanceEvenRow = True
        Me.BandedGridView2.OptionsView.EnableAppearanceOddRow = True
        Me.BandedGridView2.OptionsView.RowAutoHeight = True
        Me.BandedGridView2.OptionsView.ShowAutoFilterRow = True
        Me.BandedGridView2.OptionsView.ShowGroupPanel = False
        Me.BandedGridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.BandedGridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridBand12
        '
        Me.GridBand12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand12.Columns.Add(Me.BandedGridColumn2)
        Me.GridBand12.Columns.Add(Me.BandedGridColumn1)
        Me.GridBand12.Columns.Add(Me.BandedGridColumn21)
        Me.GridBand12.Columns.Add(Me.BandedGridColumn22)
        Me.GridBand12.Name = "GridBand12"
        Me.GridBand12.VisibleIndex = 0
        Me.GridBand12.Width = 776
        '
        'BandedGridColumn2
        '
        Me.BandedGridColumn2.Caption = "Rubrique"
        Me.BandedGridColumn2.FieldName = "QUEST"
        Me.BandedGridColumn2.Name = "BandedGridColumn2"
        Me.BandedGridColumn2.Visible = True
        Me.BandedGridColumn2.Width = 201
        '
        'BandedGridColumn1
        '
        Me.BandedGridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn1.Caption = "Réponse"
        Me.BandedGridColumn1.FieldName = "REP"
        Me.BandedGridColumn1.Name = "BandedGridColumn1"
        Me.BandedGridColumn1.OptionsColumn.FixedWidth = True
        Me.BandedGridColumn1.Visible = True
        Me.BandedGridColumn1.Width = 235
        '
        'BandedGridColumn21
        '
        Me.BandedGridColumn21.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn21.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn21.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn21.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn21.Caption = "Technicien"
        Me.BandedGridColumn21.FieldName = "TECH"
        Me.BandedGridColumn21.Name = "BandedGridColumn21"
        Me.BandedGridColumn21.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.BandedGridColumn21.Visible = True
        Me.BandedGridColumn21.Width = 163
        '
        'BandedGridColumn22
        '
        Me.BandedGridColumn22.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn22.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn22.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn22.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn22.Caption = "Sous-traitant"
        Me.BandedGridColumn22.FieldName = "STT"
        Me.BandedGridColumn22.Name = "BandedGridColumn22"
        Me.BandedGridColumn22.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.BandedGridColumn22.Visible = True
        Me.BandedGridColumn22.Width = 177
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExport)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.btnFermer)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(96, 773)
        Me.GroupBox1.TabIndex = 134
        Me.GroupBox1.TabStop = False
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnExport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExport.Location = New System.Drawing.Point(6, 111)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(84, 48)
        Me.btnExport.TabIndex = 47
        Me.btnExport.Text = "Exporter liste (xls)"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrint.Location = New System.Drawing.Point(6, 44)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(83, 48)
        Me.btnPrint.TabIndex = 46
        Me.btnPrint.Text = "Imprimer"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnFermer
        '
        Me.btnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFermer.Location = New System.Drawing.Point(6, 726)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(83, 41)
        Me.btnFermer.TabIndex = 1
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(681, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 27)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Au"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(401, 78)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 27)
        Me.Label26.TabIndex = 137
        Me.Label26.Text = "Du :"
        '
        'DTPFin
        '
        Me.DTPFin.Location = New System.Drawing.Point(718, 78)
        Me.DTPFin.Name = "DTPFin"
        Me.DTPFin.Size = New System.Drawing.Size(221, 20)
        Me.DTPFin.TabIndex = 136
        '
        'DTPDebut
        '
        Me.DTPDebut.Location = New System.Drawing.Point(457, 78)
        Me.DTPDebut.Name = "DTPDebut"
        Me.DTPDebut.Size = New System.Drawing.Size(218, 20)
        Me.DTPDebut.TabIndex = 135
        '
        'frmSyntheseEnquetesQual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1516, 829)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.DTPFin)
        Me.Controls.Add(Me.DTPDebut)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GCListeFouEI)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboClient)
        Me.Controls.Add(Me.BtValider)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSyntheseEnquetesQual"
        Me.Text = "Synthèse des enquêtes qualités"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCListeFouEI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboClient As ComboBox
    Friend WithEvents BtValider As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Private WithEvents GCListeFouEI As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand12 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn21 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn22 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExport As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnFermer As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents DTPFin As DateTimePicker
    Friend WithEvents DTPDebut As DateTimePicker
End Class
