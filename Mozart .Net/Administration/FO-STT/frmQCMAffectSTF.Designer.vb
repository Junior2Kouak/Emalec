<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQCMAffectSTF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQCMAffectSTF))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GrpBoxListQCM = New System.Windows.Forms.GroupBox()
        Me.GCListQCM = New DevExpress.XtraGrid.GridControl()
        Me.GVListQCM = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNIDQCMNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVQCMTITRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVQCMTYPELIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDQCMCREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNQCMTYPEID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpBoxPers = New System.Windows.Forms.GroupBox()
        Me.LblQCMSelect = New System.Windows.Forms.Label()
        Me.BtnDecoche = New System.Windows.Forms.Button()
        Me.BtnCoche = New System.Windows.Forms.Button()
        Me.GCSTF = New DevExpress.XtraGrid.GridControl()
        Me.GVSTF = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColCHECK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEditCHECK = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GColnaccnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVINTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColvstfnom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_nsttnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_nintnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions.SuspendLayout()
        Me.GrpBoxListQCM.SuspendLayout()
        CType(Me.GCListQCM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListQCM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxPers.SuspendLayout()
        CType(Me.GCSTF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSTF, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GrpBoxListQCM
        '
        Me.GrpBoxListQCM.Controls.Add(Me.GCListQCM)
        resources.ApplyResources(Me.GrpBoxListQCM, "GrpBoxListQCM")
        Me.GrpBoxListQCM.Name = "GrpBoxListQCM"
        Me.GrpBoxListQCM.TabStop = False
        '
        'GCListQCM
        '
        resources.ApplyResources(Me.GCListQCM, "GCListQCM")
        Me.GCListQCM.MainView = Me.GVListQCM
        Me.GCListQCM.Name = "GCListQCM"
        Me.GCListQCM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListQCM})
        '
        'GVListQCM
        '
        Me.GVListQCM.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVListQCM.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVListQCM.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVListQCM.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVListQCM.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVListQCM.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVListQCM.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVListQCM.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVListQCM.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVListQCM.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVListQCM.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVListQCM.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVListQCM.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVListQCM.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVListQCM.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVListQCM.Appearance.Empty.Options.UseBackColor = True
        Me.GVListQCM.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVListQCM.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVListQCM.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVListQCM.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVListQCM.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVListQCM.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVListQCM.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVListQCM.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVListQCM.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVListQCM.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVListQCM.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVListQCM.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVListQCM.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVListQCM.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVListQCM.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVListQCM.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListQCM.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVListQCM.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVListQCM.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVListQCM.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVListQCM.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVListQCM.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVListQCM.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListQCM.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVListQCM.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GVListQCM.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVListQCM.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVListQCM.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVListQCM.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVListQCM.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVListQCM.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListQCM.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVListQCM.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVListQCM.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVListQCM.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVListQCM.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVListQCM.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVListQCM.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVListQCM.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVListQCM.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVListQCM.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVListQCM.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVListQCM.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVListQCM.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVListQCM.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVListQCM.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVListQCM.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVListQCM.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListQCM.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVListQCM.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVListQCM.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVListQCM.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVListQCM.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVListQCM.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVListQCM.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVListQCM.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVListQCM.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVListQCM.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVListQCM.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVListQCM.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVListQCM.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListQCM.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVListQCM.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVListQCM.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListQCM.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVListQCM.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListQCM.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVListQCM.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVListQCM.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVListQCM.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVListQCM.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVListQCM.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVListQCM.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVListQCM.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVListQCM.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVListQCM.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVListQCM.Appearance.OddRow.Options.UseBackColor = True
        Me.GVListQCM.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVListQCM.Appearance.OddRow.Options.UseForeColor = True
        Me.GVListQCM.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVListQCM.Appearance.Preview.Font = CType(resources.GetObject("GVListQCM.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVListQCM.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVListQCM.Appearance.Preview.Options.UseBackColor = True
        Me.GVListQCM.Appearance.Preview.Options.UseFont = True
        Me.GVListQCM.Appearance.Preview.Options.UseForeColor = True
        Me.GVListQCM.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVListQCM.Appearance.Row.Font = CType(resources.GetObject("GVListQCM.Appearance.Row.Font"), System.Drawing.Font)
        Me.GVListQCM.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVListQCM.Appearance.Row.Options.UseBackColor = True
        Me.GVListQCM.Appearance.Row.Options.UseFont = True
        Me.GVListQCM.Appearance.Row.Options.UseForeColor = True
        Me.GVListQCM.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVListQCM.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVListQCM.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVListQCM.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVListQCM.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVListQCM.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVListQCM.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListQCM.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVListQCM.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVListQCM.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVListQCM.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVListQCM.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVListQCM.Appearance.VertLine.Options.UseBackColor = True
        Me.GVListQCM.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVListQCM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNIDQCMNUM, Me.GColVQCMTITRE, Me.GColVQCMTYPELIB, Me.GColDQCMCREE, Me.GColNQCMTYPEID})
        Me.GVListQCM.GridControl = Me.GCListQCM
        Me.GVListQCM.Name = "GVListQCM"
        Me.GVListQCM.OptionsBehavior.Editable = False
        Me.GVListQCM.OptionsBehavior.ReadOnly = True
        Me.GVListQCM.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListQCM.OptionsView.EnableAppearanceOddRow = True
        Me.GVListQCM.OptionsView.ShowAutoFilterRow = True
        Me.GVListQCM.OptionsView.ShowGroupPanel = False
        '
        'GColNIDQCMNUM
        '
        resources.ApplyResources(Me.GColNIDQCMNUM, "GColNIDQCMNUM")
        Me.GColNIDQCMNUM.FieldName = "NIDQCMNUM"
        Me.GColNIDQCMNUM.Name = "GColNIDQCMNUM"
        '
        'GColVQCMTITRE
        '
        resources.ApplyResources(Me.GColVQCMTITRE, "GColVQCMTITRE")
        Me.GColVQCMTITRE.FieldName = "VQCMTITRE"
        Me.GColVQCMTITRE.Name = "GColVQCMTITRE"
        Me.GColVQCMTITRE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVQCMTYPELIB
        '
        resources.ApplyResources(Me.GColVQCMTYPELIB, "GColVQCMTYPELIB")
        Me.GColVQCMTYPELIB.FieldName = "VQCMTYPELIB"
        Me.GColVQCMTYPELIB.Name = "GColVQCMTYPELIB"
        Me.GColVQCMTYPELIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColDQCMCREE
        '
        resources.ApplyResources(Me.GColDQCMCREE, "GColDQCMCREE")
        Me.GColDQCMCREE.FieldName = "DQCMCREE"
        Me.GColDQCMCREE.Name = "GColDQCMCREE"
        Me.GColDQCMCREE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNQCMTYPEID
        '
        resources.ApplyResources(Me.GColNQCMTYPEID, "GColNQCMTYPEID")
        Me.GColNQCMTYPEID.FieldName = "NQCMTYPEID"
        Me.GColNQCMTYPEID.Name = "GColNQCMTYPEID"
        '
        'GrpBoxPers
        '
        Me.GrpBoxPers.Controls.Add(Me.LblQCMSelect)
        Me.GrpBoxPers.Controls.Add(Me.BtnDecoche)
        Me.GrpBoxPers.Controls.Add(Me.BtnCoche)
        Me.GrpBoxPers.Controls.Add(Me.GCSTF)
        resources.ApplyResources(Me.GrpBoxPers, "GrpBoxPers")
        Me.GrpBoxPers.Name = "GrpBoxPers"
        Me.GrpBoxPers.TabStop = False
        '
        'LblQCMSelect
        '
        Me.LblQCMSelect.BackColor = System.Drawing.Color.Yellow
        Me.LblQCMSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.LblQCMSelect, "LblQCMSelect")
        Me.LblQCMSelect.Name = "LblQCMSelect"
        '
        'BtnDecoche
        '
        resources.ApplyResources(Me.BtnDecoche, "BtnDecoche")
        Me.BtnDecoche.Name = "BtnDecoche"
        Me.BtnDecoche.UseVisualStyleBackColor = True
        '
        'BtnCoche
        '
        resources.ApplyResources(Me.BtnCoche, "BtnCoche")
        Me.BtnCoche.Name = "BtnCoche"
        Me.BtnCoche.UseVisualStyleBackColor = True
        '
        'GCSTF
        '
        resources.ApplyResources(Me.GCSTF, "GCSTF")
        Me.GCSTF.MainView = Me.GVSTF
        Me.GCSTF.Name = "GCSTF"
        Me.GCSTF.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEditCHECK})
        Me.GCSTF.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSTF})
        '
        'GVSTF
        '
        Me.GVSTF.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSTF.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSTF.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVSTF.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSTF.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSTF.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSTF.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSTF.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSTF.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVSTF.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSTF.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSTF.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSTF.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSTF.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVPers.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVSTF.Appearance.Empty.Options.UseBackColor = True
        Me.GVSTF.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVSTF.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVSTF.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSTF.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSTF.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVSTF.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSTF.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSTF.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSTF.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVSTF.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSTF.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSTF.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSTF.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSTF.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVPers.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVSTF.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSTF.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSTF.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSTF.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSTF.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSTF.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVSTF.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSTF.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSTF.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSTF.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GVSTF.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVSTF.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSTF.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSTF.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSTF.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSTF.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSTF.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSTF.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSTF.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSTF.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSTF.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSTF.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSTF.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSTF.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSTF.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSTF.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVSTF.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSTF.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSTF.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSTF.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSTF.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVPers.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVSTF.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSTF.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSTF.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSTF.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSTF.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSTF.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVSTF.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSTF.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSTF.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSTF.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSTF.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSTF.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVPers.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVSTF.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSTF.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSTF.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSTF.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVSTF.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSTF.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVSTF.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSTF.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSTF.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSTF.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSTF.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSTF.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSTF.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVSTF.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSTF.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSTF.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSTF.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSTF.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVSTF.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSTF.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSTF.Appearance.Preview.Font = CType(resources.GetObject("GVPers.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVSTF.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSTF.Appearance.Preview.Options.UseBackColor = True
        Me.GVSTF.Appearance.Preview.Options.UseFont = True
        Me.GVSTF.Appearance.Preview.Options.UseForeColor = True
        Me.GVSTF.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSTF.Appearance.Row.Font = CType(resources.GetObject("GVPers.Appearance.Row.Font"), System.Drawing.Font)
        Me.GVSTF.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSTF.Appearance.Row.Options.UseBackColor = True
        Me.GVSTF.Appearance.Row.Options.UseFont = True
        Me.GVSTF.Appearance.Row.Options.UseForeColor = True
        Me.GVSTF.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSTF.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVPers.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVSTF.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSTF.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVSTF.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSTF.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSTF.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSTF.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSTF.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSTF.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSTF.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSTF.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSTF.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVSTF.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCHECK, Me.GColvstfnom, Me.GColVINTNOM, Me.GCol_nsttnum, Me.GCol_nintnum, Me.GColnaccnum})
        Me.GVSTF.GridControl = Me.GCSTF
        Me.GVSTF.Name = "GVSTF"
        Me.GVSTF.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSTF.OptionsView.EnableAppearanceOddRow = True
        Me.GVSTF.OptionsView.ShowAutoFilterRow = True
        Me.GVSTF.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVSTF.OptionsView.ShowFooter = True
        Me.GVSTF.OptionsView.ShowGroupPanel = False
        '
        'GColCHECK
        '
        resources.ApplyResources(Me.GColCHECK, "GColCHECK")
        Me.GColCHECK.ColumnEdit = Me.RepositoryItemCheckEditCHECK
        Me.GColCHECK.FieldName = "CHECK"
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
        'GColnaccnum
        '
        resources.ApplyResources(Me.GColnaccnum, "GColnaccnum")
        Me.GColnaccnum.FieldName = "naccnum"
        Me.GColnaccnum.Name = "GColnaccnum"
        Me.GColnaccnum.OptionsColumn.ReadOnly = True
        '
        'GColVINTNOM
        '
        resources.ApplyResources(Me.GColVINTNOM, "GColVINTNOM")
        Me.GColVINTNOM.FieldName = "VINTNOM"
        Me.GColVINTNOM.Name = "GColVINTNOM"
        Me.GColVINTNOM.OptionsColumn.AllowEdit = False
        Me.GColVINTNOM.OptionsColumn.ReadOnly = True
        Me.GColVINTNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColvstfnom
        '
        resources.ApplyResources(Me.GColvstfnom, "GColvstfnom")
        Me.GColvstfnom.FieldName = "vstfnom"
        Me.GColvstfnom.Name = "GColvstfnom"
        Me.GColvstfnom.OptionsColumn.AllowEdit = False
        Me.GColvstfnom.OptionsColumn.ReadOnly = True
        Me.GColvstfnom.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GCol_nsttnum
        '
        resources.ApplyResources(Me.GCol_nsttnum, "GCol_nsttnum")
        Me.GCol_nsttnum.FieldName = "nsttnum"
        Me.GCol_nsttnum.Name = "GCol_nsttnum"
        '
        'GCol_nintnum
        '
        resources.ApplyResources(Me.GCol_nintnum, "GCol_nintnum")
        Me.GCol_nintnum.FieldName = "nintnum"
        Me.GCol_nintnum.Name = "GCol_nintnum"
        '
        'frmQCMAffectSTF
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpBoxPers)
        Me.Controls.Add(Me.GrpBoxListQCM)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmQCMAffectSTF"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.GrpBoxListQCM.ResumeLayout(False)
        CType(Me.GCListQCM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListQCM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxPers.ResumeLayout(False)
        CType(Me.GCSTF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSTF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEditCHECK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
  Friend WithEvents BtnQuit As System.Windows.Forms.Button
  Friend WithEvents BtnSave As System.Windows.Forms.Button
  Friend WithEvents GrpBoxListQCM As System.Windows.Forms.GroupBox
  Friend WithEvents GrpBoxPers As System.Windows.Forms.GroupBox
  Friend WithEvents BtnDecoche As System.Windows.Forms.Button
  Friend WithEvents BtnCoche As System.Windows.Forms.Button
  Friend WithEvents LblQCMSelect As System.Windows.Forms.Label
  Private WithEvents GCListQCM As DevExpress.XtraGrid.GridControl
  Private WithEvents GVListQCM As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents GColNIDQCMNUM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GColVQCMTITRE As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GColVQCMTYPELIB As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GColDQCMCREE As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GColNQCMTYPEID As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GCSTF As DevExpress.XtraGrid.GridControl
  Private WithEvents GVSTF As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents GColnaccnum As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GColVINTNOM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GColvstfnom As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCHECK As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepositoryItemCheckEditCHECK As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GCol_nsttnum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_nintnum As DevExpress.XtraGrid.Columns.GridColumn
End Class
