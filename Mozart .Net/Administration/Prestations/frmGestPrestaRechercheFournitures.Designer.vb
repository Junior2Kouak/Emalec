<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestPrestaRechercheFournitures
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
        Me.GrpBoxListeFO = New System.Windows.Forms.GroupBox()
        Me.ChkNoGereStock = New System.Windows.Forms.CheckBox()
        Me.ucSelectArticle = New MozartNet.UCSelectArticle()
        Me.ChkGereStock = New System.Windows.Forms.CheckBox()
        Me.GCListeFoToPresta = New DevExpress.XtraGrid.GridControl()
        Me.GVListeFoToPresta = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_SRC_NFOUNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SRC_VFOUSER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SRC_VSTFGRPNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SRC_VFOUMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SRC_VFOUMAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SRC_VFOUTYP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SRC_VFOUREF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SRC_NFOUNBLOT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SRC_NFOUQTESTOCK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SRC_FPUHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SRC_DATEPRIX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SRC_CCODEG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnSuppFO = New System.Windows.Forms.Button()
        Me.BtnAddFo = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GC_FO_DEST = New DevExpress.XtraGrid.GridControl()
        Me.GV_FO_DEST = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SRC_VREFFAB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpBoxListeFO.SuspendLayout()
        CType(Me.GCListeFoToPresta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeFoToPresta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GC_FO_DEST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_FO_DEST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpBoxListeFO
        '
        Me.GrpBoxListeFO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpBoxListeFO.Controls.Add(Me.ChkNoGereStock)
        Me.GrpBoxListeFO.Controls.Add(Me.ucSelectArticle)
        Me.GrpBoxListeFO.Controls.Add(Me.ChkGereStock)
        Me.GrpBoxListeFO.Controls.Add(Me.GCListeFoToPresta)
        Me.GrpBoxListeFO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxListeFO.ForeColor = System.Drawing.Color.Firebrick
        Me.GrpBoxListeFO.Location = New System.Drawing.Point(198, 44)
        Me.GrpBoxListeFO.Name = "GrpBoxListeFO"
        Me.GrpBoxListeFO.Size = New System.Drawing.Size(1609, 460)
        Me.GrpBoxListeFO.TabIndex = 0
        Me.GrpBoxListeFO.TabStop = False
        Me.GrpBoxListeFO.Text = "Liste des fournitures"
        '
        'ChkNoGereStock
        '
        Me.ChkNoGereStock.AutoSize = True
        Me.ChkNoGereStock.ForeColor = System.Drawing.Color.Black
        Me.ChkNoGereStock.Location = New System.Drawing.Point(678, 19)
        Me.ChkNoGereStock.Name = "ChkNoGereStock"
        Me.ChkNoGereStock.Size = New System.Drawing.Size(232, 19)
        Me.ChkNoGereStock.TabIndex = 11
        Me.ChkNoGereStock.Text = "Fournitures en stock non gérées"
        Me.ChkNoGereStock.UseVisualStyleBackColor = True
        '
        'ucSelectArticle
        '
        Me.ucSelectArticle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucSelectArticle.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ucSelectArticle.Location = New System.Drawing.Point(6, 44)
        Me.ucSelectArticle.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ucSelectArticle.Name = "ucSelectArticle"
        Me.ucSelectArticle.Size = New System.Drawing.Size(1596, 113)
        Me.ucSelectArticle.TabIndex = 33
        '
        'ChkGereStock
        '
        Me.ChkGereStock.AutoSize = True
        Me.ChkGereStock.ForeColor = System.Drawing.Color.Black
        Me.ChkGereStock.Location = New System.Drawing.Point(429, 19)
        Me.ChkGereStock.Name = "ChkGereStock"
        Me.ChkGereStock.Size = New System.Drawing.Size(204, 19)
        Me.ChkGereStock.TabIndex = 10
        Me.ChkGereStock.Text = "Fournitures gérées en stock"
        Me.ChkGereStock.UseVisualStyleBackColor = True
        '
        'GCListeFoToPresta
        '
        Me.GCListeFoToPresta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCListeFoToPresta.Location = New System.Drawing.Point(6, 163)
        Me.GCListeFoToPresta.MainView = Me.GVListeFoToPresta
        Me.GCListeFoToPresta.Name = "GCListeFoToPresta"
        Me.GCListeFoToPresta.Size = New System.Drawing.Size(1597, 291)
        Me.GCListeFoToPresta.TabIndex = 9
        Me.GCListeFoToPresta.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeFoToPresta})
        '
        'GVListeFoToPresta
        '
        Me.GVListeFoToPresta.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GVListeFoToPresta.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVListeFoToPresta.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVListeFoToPresta.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVListeFoToPresta.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVListeFoToPresta.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVListeFoToPresta.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVListeFoToPresta.Appearance.Empty.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVListeFoToPresta.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVListeFoToPresta.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVListeFoToPresta.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GVListeFoToPresta.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVListeFoToPresta.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVListeFoToPresta.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVListeFoToPresta.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListeFoToPresta.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVListeFoToPresta.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVListeFoToPresta.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVListeFoToPresta.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVListeFoToPresta.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVListeFoToPresta.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVListeFoToPresta.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVListeFoToPresta.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListeFoToPresta.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVListeFoToPresta.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVListeFoToPresta.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVListeFoToPresta.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVListeFoToPresta.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVListeFoToPresta.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVListeFoToPresta.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVListeFoToPresta.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListeFoToPresta.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVListeFoToPresta.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVListeFoToPresta.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVListeFoToPresta.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVListeFoToPresta.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListeFoToPresta.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListeFoToPresta.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVListeFoToPresta.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeFoToPresta.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVListeFoToPresta.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeFoToPresta.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeFoToPresta.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeFoToPresta.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListeFoToPresta.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVListeFoToPresta.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVListeFoToPresta.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVListeFoToPresta.Appearance.OddRow.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVListeFoToPresta.Appearance.OddRow.Options.UseForeColor = True
        Me.GVListeFoToPresta.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVListeFoToPresta.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.Preview.Options.UseFont = True
        Me.GVListeFoToPresta.Appearance.Preview.Options.UseForeColor = True
        Me.GVListeFoToPresta.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVListeFoToPresta.Appearance.Row.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.Row.Options.UseForeColor = True
        Me.GVListeFoToPresta.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVListeFoToPresta.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVListeFoToPresta.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVListeFoToPresta.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVListeFoToPresta.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVListeFoToPresta.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeFoToPresta.Appearance.VertLine.Options.UseBackColor = True
        Me.GVListeFoToPresta.ColumnPanelRowHeight = 40
        Me.GVListeFoToPresta.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_SRC_NFOUNUM, Me.GCol_SRC_VFOUSER, Me.GCol_SRC_VFOUMAT, Me.GCol_SRC_VFOUMAR, Me.GCol_SRC_VFOUTYP, Me.GCol_SRC_VFOUREF, Me.GCol_SRC_NFOUNBLOT, Me.GCol_SRC_NFOUQTESTOCK, Me.GCol_SRC_FPUHT, Me.GCol_SRC_VSTFGRPNOM, Me.GCol_SRC_VREFFAB, Me.GCol_SRC_DATEPRIX, Me.GCol_SRC_CCODEG})
        Me.GVListeFoToPresta.GridControl = Me.GCListeFoToPresta
        Me.GVListeFoToPresta.Name = "GVListeFoToPresta"
        Me.GVListeFoToPresta.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListeFoToPresta.OptionsView.EnableAppearanceOddRow = True
        Me.GVListeFoToPresta.OptionsView.RowAutoHeight = True
        Me.GVListeFoToPresta.OptionsView.ShowAutoFilterRow = True
        Me.GVListeFoToPresta.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVListeFoToPresta.OptionsView.ShowFooter = True
        Me.GVListeFoToPresta.OptionsView.ShowGroupPanel = False
        '
        'GCol_SRC_NFOUNUM
        '
        Me.GCol_SRC_NFOUNUM.FieldName = "NFOUNUM"
        Me.GCol_SRC_NFOUNUM.Name = "GCol_SRC_NFOUNUM"
        Me.GCol_SRC_NFOUNUM.OptionsColumn.AllowEdit = False
        Me.GCol_SRC_NFOUNUM.OptionsColumn.ReadOnly = True
        '
        'GCol_SRC_VFOUSER
        '
        Me.GCol_SRC_VFOUSER.Caption = "Série"
        Me.GCol_SRC_VFOUSER.FieldName = "VFOUSER"
        Me.GCol_SRC_VFOUSER.Name = "GCol_SRC_VFOUSER"
        Me.GCol_SRC_VFOUSER.OptionsColumn.AllowEdit = False
        Me.GCol_SRC_VFOUSER.OptionsColumn.ReadOnly = True
        Me.GCol_SRC_VFOUSER.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_SRC_VFOUSER.Visible = True
        Me.GCol_SRC_VFOUSER.VisibleIndex = 0
        '
        'GCol_SRC_VSTFGRPNOM
        '
        Me.GCol_SRC_VSTFGRPNOM.Caption = "Fournisseur"
        Me.GCol_SRC_VSTFGRPNOM.FieldName = "VSTFGRPNOM"
        Me.GCol_SRC_VSTFGRPNOM.Name = "GCol_SRC_VSTFGRPNOM"
        Me.GCol_SRC_VSTFGRPNOM.OptionsColumn.AllowEdit = False
        Me.GCol_SRC_VSTFGRPNOM.OptionsColumn.ReadOnly = True
        Me.GCol_SRC_VSTFGRPNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_SRC_VSTFGRPNOM.Visible = True
        Me.GCol_SRC_VSTFGRPNOM.VisibleIndex = 8
        '
        'GCol_SRC_VFOUMAT
        '
        Me.GCol_SRC_VFOUMAT.Caption = "Matériel"
        Me.GCol_SRC_VFOUMAT.FieldName = "VFOUMAT"
        Me.GCol_SRC_VFOUMAT.Name = "GCol_SRC_VFOUMAT"
        Me.GCol_SRC_VFOUMAT.OptionsColumn.AllowEdit = False
        Me.GCol_SRC_VFOUMAT.OptionsColumn.ReadOnly = True
        Me.GCol_SRC_VFOUMAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_SRC_VFOUMAT.Visible = True
        Me.GCol_SRC_VFOUMAT.VisibleIndex = 1
        Me.GCol_SRC_VFOUMAT.Width = 300
        '
        'GCol_SRC_VFOUMAR
        '
        Me.GCol_SRC_VFOUMAR.Caption = "Marque"
        Me.GCol_SRC_VFOUMAR.FieldName = "VFOUMAR"
        Me.GCol_SRC_VFOUMAR.Name = "GCol_SRC_VFOUMAR"
        Me.GCol_SRC_VFOUMAR.OptionsColumn.AllowEdit = False
        Me.GCol_SRC_VFOUMAR.OptionsColumn.ReadOnly = True
        Me.GCol_SRC_VFOUMAR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_SRC_VFOUMAR.Visible = True
        Me.GCol_SRC_VFOUMAR.VisibleIndex = 2
        '
        'GCol_SRC_VFOUTYP
        '
        Me.GCol_SRC_VFOUTYP.Caption = "Type"
        Me.GCol_SRC_VFOUTYP.FieldName = "VFOUTYP"
        Me.GCol_SRC_VFOUTYP.Name = "GCol_SRC_VFOUTYP"
        Me.GCol_SRC_VFOUTYP.OptionsColumn.AllowEdit = False
        Me.GCol_SRC_VFOUTYP.OptionsColumn.ReadOnly = True
        Me.GCol_SRC_VFOUTYP.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_SRC_VFOUTYP.Visible = True
        Me.GCol_SRC_VFOUTYP.VisibleIndex = 3
        '
        'GCol_SRC_VFOUREF
        '
        Me.GCol_SRC_VFOUREF.Caption = "Réf Fab"
        Me.GCol_SRC_VFOUREF.FieldName = "VFOUREF"
        Me.GCol_SRC_VFOUREF.Name = "GCol_SRC_VFOUREF"
        Me.GCol_SRC_VFOUREF.OptionsColumn.AllowEdit = False
        Me.GCol_SRC_VFOUREF.OptionsColumn.ReadOnly = True
        Me.GCol_SRC_VFOUREF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_SRC_VFOUREF.Visible = True
        Me.GCol_SRC_VFOUREF.VisibleIndex = 4
        '
        'GCol_SRC_NFOUNBLOT
        '
        Me.GCol_SRC_NFOUNBLOT.Caption = "PCB"
        Me.GCol_SRC_NFOUNBLOT.FieldName = "NFOUNBLOT"
        Me.GCol_SRC_NFOUNBLOT.Name = "GCol_SRC_NFOUNBLOT"
        Me.GCol_SRC_NFOUNBLOT.OptionsColumn.AllowEdit = False
        Me.GCol_SRC_NFOUNBLOT.OptionsColumn.ReadOnly = True
        Me.GCol_SRC_NFOUNBLOT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_SRC_NFOUNBLOT.Visible = True
        Me.GCol_SRC_NFOUNBLOT.VisibleIndex = 5
        Me.GCol_SRC_NFOUNBLOT.Width = 50
        '
        'GCol_SRC_NFOUQTESTOCK
        '
        Me.GCol_SRC_NFOUQTESTOCK.Caption = "Stock"
        Me.GCol_SRC_NFOUQTESTOCK.FieldName = "NFOUQTESTOCK"
        Me.GCol_SRC_NFOUQTESTOCK.Name = "GCol_SRC_NFOUQTESTOCK"
        Me.GCol_SRC_NFOUQTESTOCK.OptionsColumn.AllowEdit = False
        Me.GCol_SRC_NFOUQTESTOCK.OptionsColumn.ReadOnly = True
        Me.GCol_SRC_NFOUQTESTOCK.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_SRC_NFOUQTESTOCK.Visible = True
        Me.GCol_SRC_NFOUQTESTOCK.VisibleIndex = 6
        Me.GCol_SRC_NFOUQTESTOCK.Width = 100
        '
        'GCol_SRC_FPUHT
        '
        Me.GCol_SRC_FPUHT.Caption = "Prix U"
        Me.GCol_SRC_FPUHT.DisplayFormat.FormatString = "n2"
        Me.GCol_SRC_FPUHT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GCol_SRC_FPUHT.FieldName = "FPUHT"
        Me.GCol_SRC_FPUHT.Name = "GCol_SRC_FPUHT"
        Me.GCol_SRC_FPUHT.OptionsColumn.AllowEdit = False
        Me.GCol_SRC_FPUHT.OptionsColumn.ReadOnly = True
        Me.GCol_SRC_FPUHT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_SRC_FPUHT.Visible = True
        Me.GCol_SRC_FPUHT.VisibleIndex = 7
        Me.GCol_SRC_FPUHT.Width = 100
        '
        'GCol_SRC_DATEPRIX
        '
        Me.GCol_SRC_DATEPRIX.Caption = "Date Prix"
        Me.GCol_SRC_DATEPRIX.FieldName = "Date prix"
        Me.GCol_SRC_DATEPRIX.Name = "GCol_SRC_DATEPRIX"
        Me.GCol_SRC_DATEPRIX.Visible = True
        Me.GCol_SRC_DATEPRIX.VisibleIndex = 10
        '
        'GCol_SRC_CCODEG
        '
        Me.GCol_SRC_CCODEG.Caption = "CCODEG"
        Me.GCol_SRC_CCODEG.FieldName = "CCODEG"
        Me.GCol_SRC_CCODEG.Name = "GCol_SRC_CCODEG"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnSuppFO)
        Me.GrpActions.Controls.Add(Me.BtnAddFo)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Location = New System.Drawing.Point(12, 12)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(159, 749)
        Me.GrpActions.TabIndex = 2
        Me.GrpActions.TabStop = False
        '
        'BtnSuppFO
        '
        Me.BtnSuppFO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSuppFO.Location = New System.Drawing.Point(26, 468)
        Me.BtnSuppFO.Name = "BtnSuppFO"
        Me.BtnSuppFO.Size = New System.Drawing.Size(117, 47)
        Me.BtnSuppFO.TabIndex = 6
        Me.BtnSuppFO.Text = "Supprimer"
        Me.BtnSuppFO.UseVisualStyleBackColor = True
        '
        'BtnAddFo
        '
        Me.BtnAddFo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddFo.Location = New System.Drawing.Point(26, 182)
        Me.BtnAddFo.Name = "BtnAddFo"
        Me.BtnAddFo.Size = New System.Drawing.Size(117, 47)
        Me.BtnAddFo.TabIndex = 5
        Me.BtnAddFo.Text = "Ajouter"
        Me.BtnAddFo.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFermer.Location = New System.Drawing.Point(26, 672)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(117, 47)
        Me.BtnFermer.TabIndex = 3
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelTitre.Location = New System.Drawing.Point(193, 12)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(258, 29)
        Me.LabelTitre.TabIndex = 31
        Me.LabelTitre.Text = "Sélection des articles"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GC_FO_DEST)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox1.Location = New System.Drawing.Point(198, 510)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1609, 349)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sélection des fournitures"
        '
        'GC_FO_DEST
        '
        Me.GC_FO_DEST.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GC_FO_DEST.Location = New System.Drawing.Point(6, 20)
        Me.GC_FO_DEST.MainView = Me.GV_FO_DEST
        Me.GC_FO_DEST.Name = "GC_FO_DEST"
        Me.GC_FO_DEST.Size = New System.Drawing.Size(1597, 320)
        Me.GC_FO_DEST.TabIndex = 9
        Me.GC_FO_DEST.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_FO_DEST})
        '
        'GV_FO_DEST
        '
        Me.GV_FO_DEST.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_FO_DEST.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_FO_DEST.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GV_FO_DEST.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_FO_DEST.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_FO_DEST.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_FO_DEST.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_FO_DEST.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_FO_DEST.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_FO_DEST.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_FO_DEST.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_FO_DEST.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV_FO_DEST.Appearance.Empty.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_FO_DEST.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_FO_DEST.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_FO_DEST.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GV_FO_DEST.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_FO_DEST.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_FO_DEST.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_FO_DEST.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GV_FO_DEST.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_FO_DEST.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_FO_DEST.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_FO_DEST.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_FO_DEST.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_FO_DEST.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_FO_DEST.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GV_FO_DEST.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_FO_DEST.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_FO_DEST.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_FO_DEST.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GV_FO_DEST.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GV_FO_DEST.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_FO_DEST.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GV_FO_DEST.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_FO_DEST.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_FO_DEST.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_FO_DEST.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_FO_DEST.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_FO_DEST.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_FO_DEST.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_FO_DEST.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_FO_DEST.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_FO_DEST.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_FO_DEST.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_FO_DEST.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_FO_DEST.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_FO_DEST.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_FO_DEST.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_FO_DEST.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_FO_DEST.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_FO_DEST.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_FO_DEST.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_FO_DEST.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_FO_DEST.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_FO_DEST.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_FO_DEST.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_FO_DEST.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_FO_DEST.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_FO_DEST.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GV_FO_DEST.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_FO_DEST.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_FO_DEST.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV_FO_DEST.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_FO_DEST.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GV_FO_DEST.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_FO_DEST.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV_FO_DEST.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GV_FO_DEST.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GV_FO_DEST.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_FO_DEST.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_FO_DEST.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GV_FO_DEST.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_FO_DEST.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_FO_DEST.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_FO_DEST.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_FO_DEST.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_FO_DEST.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.OddRow.Options.UseBorderColor = True
        Me.GV_FO_DEST.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_FO_DEST.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV_FO_DEST.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_FO_DEST.Appearance.Preview.Options.UseFont = True
        Me.GV_FO_DEST.Appearance.Preview.Options.UseForeColor = True
        Me.GV_FO_DEST.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_FO_DEST.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_FO_DEST.Appearance.Row.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.Row.Options.UseForeColor = True
        Me.GV_FO_DEST.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_FO_DEST.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV_FO_DEST.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_FO_DEST.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV_FO_DEST.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV_FO_DEST.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV_FO_DEST.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV_FO_DEST.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_FO_DEST.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_FO_DEST.ColumnPanelRowHeight = 40
        Me.GV_FO_DEST.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn10, Me.GridColumn3, Me.GridColumn8})
        Me.GV_FO_DEST.GridControl = Me.GC_FO_DEST
        Me.GV_FO_DEST.Name = "GV_FO_DEST"
        Me.GV_FO_DEST.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_FO_DEST.OptionsView.EnableAppearanceOddRow = True
        Me.GV_FO_DEST.OptionsView.RowAutoHeight = True
        Me.GV_FO_DEST.OptionsView.ShowAutoFilterRow = True
        Me.GV_FO_DEST.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV_FO_DEST.OptionsView.ShowFooter = True
        Me.GV_FO_DEST.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "NFOUNUM"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Série"
        Me.GridColumn2.FieldName = "Serie"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Matériel"
        Me.GridColumn4.FieldName = "Article"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 300
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Marque"
        Me.GridColumn5.FieldName = "Marque"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Type"
        Me.GridColumn6.FieldName = "VFOUTYP"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Réf"
        Me.GridColumn7.FieldName = "VFOUREF"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Prix U"
        Me.GridColumn10.DisplayFormat.FormatString = "n2"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "Prix U"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 5
        Me.GridColumn10.Width = 80
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn3.Caption = "Quantité"
        Me.GridColumn3.DisplayFormat.FormatString = "n2"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Quantite"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 6
        Me.GridColumn3.Width = 120
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Prix total"
        Me.GridColumn8.DisplayFormat.FormatString = "n2"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "Prix Total"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Prix Total", "Total={0:n2}")})
        Me.GridColumn8.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        '
        'GCol_SRC_VREFFAB
        '
        Me.GCol_SRC_VREFFAB.Caption = "Réf Fou"
        Me.GCol_SRC_VREFFAB.FieldName = "VSTFFOUREFCLI"
        Me.GCol_SRC_VREFFAB.Name = "GCol_SRC_VREFFAB"
        Me.GCol_SRC_VREFFAB.Visible = True
        Me.GCol_SRC_VREFFAB.VisibleIndex = 9
        '
        'frmGestPrestaRechercheFournitures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnFermer
        Me.ClientSize = New System.Drawing.Size(1819, 862)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GrpBoxListeFO)
        Me.KeyPreview = True
        Me.Name = "frmGestPrestaRechercheFournitures"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recherche des articles pour la commande"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpBoxListeFO.ResumeLayout(False)
        Me.GrpBoxListeFO.PerformLayout()
        CType(Me.GCListeFoToPresta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeFoToPresta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GC_FO_DEST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_FO_DEST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrpBoxListeFO As GroupBox
    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnSuppFO As Button
    Friend WithEvents BtnAddFo As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents LabelTitre As Label
    Private WithEvents GCListeFoToPresta As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeFoToPresta As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCol_SRC_NFOUNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SRC_VFOUSER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SRC_VFOUMAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SRC_VFOUMAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SRC_VFOUTYP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SRC_VFOUREF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SRC_NFOUNBLOT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SRC_NFOUQTESTOCK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SRC_FPUHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChkNoGereStock As CheckBox
    Friend WithEvents ChkGereStock As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents GC_FO_DEST As DevExpress.XtraGrid.GridControl
    Private WithEvents GV_FO_DEST As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SRC_CCODEG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ucSelectArticle As UCSelectArticle
    Friend WithEvents GCol_SRC_VSTFGRPNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SRC_DATEPRIX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SRC_VREFFAB As DevExpress.XtraGrid.Columns.GridColumn
End Class
