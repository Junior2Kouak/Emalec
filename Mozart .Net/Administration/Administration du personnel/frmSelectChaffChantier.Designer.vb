<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectChaffChantier
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectChaffChantier))
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.BtnQuit = New System.Windows.Forms.Button()
    Me.BtnSave = New System.Windows.Forms.Button()
    Me.GCPers = New DevExpress.XtraGrid.GridControl()
    Me.GVPers = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GColCHECK = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemCheckEditCHECK = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.GColNPERCHAFF = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVPERPRE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LabelTitre = New System.Windows.Forms.Label()
    Me.GrpActions.SuspendLayout()
    CType(Me.GCPers, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GVPers, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEditCHECK, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GrpActions
    '
    Me.GrpActions.Controls.Add(Me.BtnQuit)
    Me.GrpActions.Controls.Add(Me.BtnSave)
    resources.ApplyResources(Me.GrpActions, "GrpActions")
    Me.GrpActions.Name = "GrpActions"
    Me.GrpActions.TabStop = False
    '
    'BtnQuit
    '
    resources.ApplyResources(Me.BtnQuit, "BtnQuit")
    Me.BtnQuit.Name = "BtnQuit"
    Me.BtnQuit.UseVisualStyleBackColor = True
    '
    'BtnSave
    '
    resources.ApplyResources(Me.BtnSave, "BtnSave")
    Me.BtnSave.Name = "BtnSave"
    Me.BtnSave.UseVisualStyleBackColor = True
    '
    'GCPers
    '
    resources.ApplyResources(Me.GCPers, "GCPers")
    Me.GCPers.MainView = Me.GVPers
    Me.GCPers.Name = "GCPers"
    Me.GCPers.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEditCHECK})
    Me.GCPers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPers})
    '
    'GVPers
    '
    Me.GVPers.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
    Me.GVPers.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
    Me.GVPers.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
    Me.GVPers.Appearance.ColumnFilterButton.Options.UseBackColor = True
    Me.GVPers.Appearance.ColumnFilterButton.Options.UseBorderColor = True
    Me.GVPers.Appearance.ColumnFilterButton.Options.UseForeColor = True
    Me.GVPers.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
    Me.GVPers.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
    Me.GVPers.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
    Me.GVPers.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
    Me.GVPers.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
    Me.GVPers.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
    Me.GVPers.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVPers.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVPers.Appearance.Empty.BackColor2"), System.Drawing.Color)
    Me.GVPers.Appearance.Empty.Options.UseBackColor = True
    Me.GVPers.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
    Me.GVPers.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
    Me.GVPers.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
    Me.GVPers.Appearance.EvenRow.Options.UseBackColor = True
    Me.GVPers.Appearance.EvenRow.Options.UseBorderColor = True
    Me.GVPers.Appearance.EvenRow.Options.UseForeColor = True
    Me.GVPers.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
    Me.GVPers.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
    Me.GVPers.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
    Me.GVPers.Appearance.FilterCloseButton.Options.UseBackColor = True
    Me.GVPers.Appearance.FilterCloseButton.Options.UseBorderColor = True
    Me.GVPers.Appearance.FilterCloseButton.Options.UseForeColor = True
    Me.GVPers.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVPers.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVPers.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
    Me.GVPers.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
    Me.GVPers.Appearance.FilterPanel.Options.UseBackColor = True
    Me.GVPers.Appearance.FilterPanel.Options.UseForeColor = True
    Me.GVPers.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
    Me.GVPers.Appearance.FixedLine.Options.UseBackColor = True
    Me.GVPers.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
    Me.GVPers.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
    Me.GVPers.Appearance.FocusedCell.Options.UseBackColor = True
    Me.GVPers.Appearance.FocusedCell.Options.UseForeColor = True
    Me.GVPers.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
    Me.GVPers.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
    Me.GVPers.Appearance.FocusedRow.Options.UseBackColor = True
    Me.GVPers.Appearance.FocusedRow.Options.UseForeColor = True
    Me.GVPers.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
    Me.GVPers.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
    Me.GVPers.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
    Me.GVPers.Appearance.FooterPanel.Options.UseBackColor = True
    Me.GVPers.Appearance.FooterPanel.Options.UseBorderColor = True
    Me.GVPers.Appearance.FooterPanel.Options.UseForeColor = True
    Me.GVPers.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
    Me.GVPers.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
    Me.GVPers.Appearance.GroupButton.Options.UseBackColor = True
    Me.GVPers.Appearance.GroupButton.Options.UseBorderColor = True
    Me.GVPers.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
    Me.GVPers.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
    Me.GVPers.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
    Me.GVPers.Appearance.GroupFooter.Options.UseBackColor = True
    Me.GVPers.Appearance.GroupFooter.Options.UseBorderColor = True
    Me.GVPers.Appearance.GroupFooter.Options.UseForeColor = True
    Me.GVPers.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVPers.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVPers.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
    Me.GVPers.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
    Me.GVPers.Appearance.GroupPanel.Options.UseBackColor = True
    Me.GVPers.Appearance.GroupPanel.Options.UseForeColor = True
    Me.GVPers.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
    Me.GVPers.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
    Me.GVPers.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
    Me.GVPers.Appearance.GroupRow.Options.UseBackColor = True
    Me.GVPers.Appearance.GroupRow.Options.UseBorderColor = True
    Me.GVPers.Appearance.GroupRow.Options.UseForeColor = True
    Me.GVPers.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
    Me.GVPers.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
    Me.GVPers.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVPers.Appearance.HeaderPanel.Font"), System.Drawing.Font)
    Me.GVPers.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
    Me.GVPers.Appearance.HeaderPanel.Options.UseBackColor = True
    Me.GVPers.Appearance.HeaderPanel.Options.UseBorderColor = True
    Me.GVPers.Appearance.HeaderPanel.Options.UseFont = True
    Me.GVPers.Appearance.HeaderPanel.Options.UseForeColor = True
    Me.GVPers.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.GVPers.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GVPers.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GVPers.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
    Me.GVPers.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
    Me.GVPers.Appearance.HideSelectionRow.Options.UseBackColor = True
    Me.GVPers.Appearance.HideSelectionRow.Options.UseForeColor = True
    Me.GVPers.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
    Me.GVPers.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
    Me.GVPers.Appearance.HorzLine.Options.UseBackColor = True
    Me.GVPers.Appearance.HorzLine.Options.UseBorderColor = True
    Me.GVPers.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVPers.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVPers.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
    Me.GVPers.Appearance.OddRow.Options.UseBackColor = True
    Me.GVPers.Appearance.OddRow.Options.UseBorderColor = True
    Me.GVPers.Appearance.OddRow.Options.UseForeColor = True
    Me.GVPers.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
    Me.GVPers.Appearance.Preview.Font = CType(resources.GetObject("GVPers.Appearance.Preview.Font"), System.Drawing.Font)
    Me.GVPers.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
    Me.GVPers.Appearance.Preview.Options.UseBackColor = True
    Me.GVPers.Appearance.Preview.Options.UseFont = True
    Me.GVPers.Appearance.Preview.Options.UseForeColor = True
    Me.GVPers.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVPers.Appearance.Row.Font = CType(resources.GetObject("GVPers.Appearance.Row.Font"), System.Drawing.Font)
    Me.GVPers.Appearance.Row.ForeColor = System.Drawing.Color.Black
    Me.GVPers.Appearance.Row.Options.UseBackColor = True
    Me.GVPers.Appearance.Row.Options.UseFont = True
    Me.GVPers.Appearance.Row.Options.UseForeColor = True
    Me.GVPers.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVPers.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVPers.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
    Me.GVPers.Appearance.RowSeparator.Options.UseBackColor = True
    Me.GVPers.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
    Me.GVPers.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
    Me.GVPers.Appearance.SelectedRow.Options.UseBackColor = True
    Me.GVPers.Appearance.SelectedRow.Options.UseForeColor = True
    Me.GVPers.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
    Me.GVPers.Appearance.TopNewRow.Options.UseBackColor = True
    Me.GVPers.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
    Me.GVPers.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
    Me.GVPers.Appearance.VertLine.Options.UseBackColor = True
    Me.GVPers.Appearance.VertLine.Options.UseBorderColor = True
    Me.GVPers.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCHECK, Me.GColNPERCHAFF, Me.GColVPERNOM, Me.GColVPERPRE})
    Me.GVPers.GridControl = Me.GCPers
    Me.GVPers.Name = "GVPers"
    Me.GVPers.OptionsView.EnableAppearanceEvenRow = True
    Me.GVPers.OptionsView.EnableAppearanceOddRow = True
    Me.GVPers.OptionsView.ShowAutoFilterRow = True
    Me.GVPers.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
    Me.GVPers.OptionsView.ShowFooter = True
    Me.GVPers.OptionsView.ShowGroupPanel = False
    '
    'GColCHECK
    '
    resources.ApplyResources(Me.GColCHECK, "GColCHECK")
    Me.GColCHECK.ColumnEdit = Me.RepositoryItemCheckEditCHECK
    Me.GColCHECK.FieldName = "BAFFECTE"
    Me.GColCHECK.Name = "GColCHECK"
    '
    'RepositoryItemCheckEditCHECK
    '
    resources.ApplyResources(Me.RepositoryItemCheckEditCHECK, "RepositoryItemCheckEditCHECK")
    Me.RepositoryItemCheckEditCHECK.Name = "RepositoryItemCheckEditCHECK"
    Me.RepositoryItemCheckEditCHECK.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
    Me.RepositoryItemCheckEditCHECK.ValueChecked = 1
    Me.RepositoryItemCheckEditCHECK.ValueUnchecked = 0
    '
    'GColNPERCHAFF
    '
    resources.ApplyResources(Me.GColNPERCHAFF, "GColNPERCHAFF")
    Me.GColNPERCHAFF.FieldName = "NPERCHAFF"
    Me.GColNPERCHAFF.Name = "GColNPERCHAFF"
    Me.GColNPERCHAFF.OptionsColumn.ReadOnly = True
    '
    'GColVPERNOM
    '
    resources.ApplyResources(Me.GColVPERNOM, "GColVPERNOM")
    Me.GColVPERNOM.FieldName = "VPERNOM"
    Me.GColVPERNOM.Name = "GColVPERNOM"
    Me.GColVPERNOM.OptionsColumn.AllowEdit = False
    Me.GColVPERNOM.OptionsColumn.ReadOnly = True
    Me.GColVPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GColVPERPRE
    '
    resources.ApplyResources(Me.GColVPERPRE, "GColVPERPRE")
    Me.GColVPERPRE.FieldName = "VPERPRE"
    Me.GColVPERPRE.Name = "GColVPERPRE"
    Me.GColVPERPRE.OptionsColumn.AllowEdit = False
    Me.GColVPERPRE.OptionsColumn.ReadOnly = True
    Me.GColVPERPRE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'LabelTitre
    '
    resources.ApplyResources(Me.LabelTitre, "LabelTitre")
    Me.LabelTitre.Name = "LabelTitre"
    '
    'frmSelectChaffChantier
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.Controls.Add(Me.LabelTitre)
    Me.Controls.Add(Me.GCPers)
    Me.Controls.Add(Me.GrpActions)
    Me.Name = "frmSelectChaffChantier"
    Me.GrpActions.ResumeLayout(False)
    CType(Me.GCPers, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GVPers, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEditCHECK, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Private WithEvents GCPers As DevExpress.XtraGrid.GridControl
    Private WithEvents GVPers As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColCHECK As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepositoryItemCheckEditCHECK As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents GColNPERCHAFF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVPERPRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
End Class
