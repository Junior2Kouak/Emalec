<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdminFouListeEIBase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdminFouListeEIBase))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.GColBaseCFOUACTIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnSupprimer = New System.Windows.Forms.Button()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GColVFOUMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNFOUNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVlisteFouEI = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColVSSCFOLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVFOUMAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVFOUTYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVFOUREF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCListeFouEI = New DevExpress.XtraGrid.GridControl()
        Me.GrpListe = New System.Windows.Forms.GroupBox()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.GrpListFouEIBase = New System.Windows.Forms.GroupBox()
        Me.GCListeFouEIBase = New DevExpress.XtraGrid.GridControl()
        Me.GVListeFouEIBase = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColBaseIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColBaseNFOUBASEXTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColBaseNFOUNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColBaseVSSCFOLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColBaseVFOUMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColBaseVFOUMAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColBaseVFOUTYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColBaseVFOUREF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LblLegende = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        CType(Me.GVlisteFouEI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCListeFouEI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpListe.SuspendLayout()
        Me.GrpListFouEIBase.SuspendLayout()
        CType(Me.GCListeFouEIBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeFouEIBase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GColBaseCFOUACTIF
        '
        resources.ApplyResources(Me.GColBaseCFOUACTIF, "GColBaseCFOUACTIF")
        Me.GColBaseCFOUACTIF.FieldName = "CFOUACTIF"
        Me.GColBaseCFOUACTIF.Name = "GColBaseCFOUACTIF"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnSupprimer)
        Me.GrpActions.Controls.Add(Me.BtnAjouter)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnSave)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnSupprimer
        '
        Me.BtnSupprimer.BackColor = System.Drawing.Color.LightGreen
        resources.ApplyResources(Me.BtnSupprimer, "BtnSupprimer")
        Me.BtnSupprimer.Name = "BtnSupprimer"
        Me.BtnSupprimer.UseVisualStyleBackColor = False
        '
        'BtnAjouter
        '
        Me.BtnAjouter.BackColor = System.Drawing.Color.PaleGreen
        resources.ApplyResources(Me.BtnAjouter, "BtnAjouter")
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.UseVisualStyleBackColor = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        resources.ApplyResources(Me.BtnSave, "BtnSave")
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'GColVFOUMAT
        '
        resources.ApplyResources(Me.GColVFOUMAT, "GColVFOUMAT")
        Me.GColVFOUMAT.FieldName = "VFOUMAT"
        Me.GColVFOUMAT.Name = "GColVFOUMAT"
        Me.GColVFOUMAT.OptionsColumn.AllowEdit = False
        Me.GColVFOUMAT.OptionsColumn.ReadOnly = True
        Me.GColVFOUMAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNFOUNUM
        '
        resources.ApplyResources(Me.GColNFOUNUM, "GColNFOUNUM")
        Me.GColNFOUNUM.FieldName = "NFOUNUM"
        Me.GColNFOUNUM.Name = "GColNFOUNUM"
        '
        'GVlisteFouEI
        '
        Me.GVlisteFouEI.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVlisteFouEI.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVlisteFouEI.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GVlisteFouEI.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVlisteFouEI.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVlisteFouEI.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVlisteFouEI.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVlisteFouEI.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVlisteFouEI.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.Empty.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVlisteFouEI.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVlisteFouEI.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVlisteFouEI.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVlisteFouEI.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVlisteFouEI.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GVlisteFouEI.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVlisteFouEI.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVlisteFouEI.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVlisteFouEI.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GVlisteFouEI.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVlisteFouEI.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVlisteFouEI.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GVlisteFouEI.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GVlisteFouEI.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVlisteFouEI.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVlisteFouEI.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVlisteFouEI.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVlisteFouEI.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVlisteFouEI.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVlisteFouEI.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVlisteFouEI.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVlisteFouEI.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVlisteFouEI.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVlisteFouEI.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVlisteFouEI.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVlisteFouEI.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVlisteFouEI.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVlisteFouEI.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVlisteFouEI.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVlisteFouEI.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVlisteFouEI.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVlisteFouEI.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GVlisteFouEI.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVlisteFouEI.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVlisteFouEI.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVlisteFouEI.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVlisteFouEI.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVlisteFouEI.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVlisteFouEI.Appearance.OddRow.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.OddRow.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.Preview.Font = CType(resources.GetObject("GVlisteFouEI.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVlisteFouEI.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVlisteFouEI.Appearance.Preview.Options.UseFont = True
        Me.GVlisteFouEI.Appearance.Preview.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVlisteFouEI.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVlisteFouEI.Appearance.Row.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.Row.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVlisteFouEI.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVlisteFouEI.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVlisteFouEI.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVlisteFouEI.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVlisteFouEI.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVlisteFouEI.Appearance.VertLine.Options.UseBackColor = True
        Me.GVlisteFouEI.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNFOUNUM, Me.GColVSSCFOLIB, Me.GColVFOUMAT, Me.GColVFOUMAR, Me.GColVFOUTYPE, Me.GColVFOUREF})
        Me.GVlisteFouEI.GridControl = Me.GCListeFouEI
        Me.GVlisteFouEI.Name = "GVlisteFouEI"
        Me.GVlisteFouEI.OptionsBehavior.Editable = False
        Me.GVlisteFouEI.OptionsBehavior.ReadOnly = True
        Me.GVlisteFouEI.OptionsView.EnableAppearanceEvenRow = True
        Me.GVlisteFouEI.OptionsView.EnableAppearanceOddRow = True
        Me.GVlisteFouEI.OptionsView.ShowAutoFilterRow = True
        Me.GVlisteFouEI.OptionsView.ShowGroupPanel = False
        '
        'GColVSSCFOLIB
        '
        resources.ApplyResources(Me.GColVSSCFOLIB, "GColVSSCFOLIB")
        Me.GColVSSCFOLIB.FieldName = "VSSCFOLIB"
        Me.GColVSSCFOLIB.Name = "GColVSSCFOLIB"
        Me.GColVSSCFOLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVFOUMAR
        '
        resources.ApplyResources(Me.GColVFOUMAR, "GColVFOUMAR")
        Me.GColVFOUMAR.FieldName = "VFOUMAR"
        Me.GColVFOUMAR.Name = "GColVFOUMAR"
        Me.GColVFOUMAR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVFOUTYPE
        '
        resources.ApplyResources(Me.GColVFOUTYPE, "GColVFOUTYPE")
        Me.GColVFOUTYPE.FieldName = "VFOUTYP"
        Me.GColVFOUTYPE.Name = "GColVFOUTYPE"
        Me.GColVFOUTYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVFOUREF
        '
        resources.ApplyResources(Me.GColVFOUREF, "GColVFOUREF")
        Me.GColVFOUREF.FieldName = "VFOUREF"
        Me.GColVFOUREF.Name = "GColVFOUREF"
        Me.GColVFOUREF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GCListeFouEI
        '
        resources.ApplyResources(Me.GCListeFouEI, "GCListeFouEI")
        Me.GCListeFouEI.MainView = Me.GVlisteFouEI
        Me.GCListeFouEI.Name = "GCListeFouEI"
        Me.GCListeFouEI.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVlisteFouEI})
        '
        'GrpListe
        '
        Me.GrpListe.Controls.Add(Me.GCListeFouEI)
        resources.ApplyResources(Me.GrpListe, "GrpListe")
        Me.GrpListe.Name = "GrpListe"
        Me.GrpListe.TabStop = False
        '
        'GrpListFouEIBase
        '
        Me.GrpListFouEIBase.Controls.Add(Me.GCListeFouEIBase)
        resources.ApplyResources(Me.GrpListFouEIBase, "GrpListFouEIBase")
        Me.GrpListFouEIBase.Name = "GrpListFouEIBase"
        Me.GrpListFouEIBase.TabStop = False
        '
        'GCListeFouEIBase
        '
        resources.ApplyResources(Me.GCListeFouEIBase, "GCListeFouEIBase")
        Me.GCListeFouEIBase.MainView = Me.GVListeFouEIBase
        Me.GCListeFouEIBase.Name = "GCListeFouEIBase"
        Me.GCListeFouEIBase.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeFouEIBase})
        '
        'GVListeFouEIBase
        '
        Me.GVListeFouEIBase.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColBaseIDTMP, Me.GColBaseNFOUBASEXTID, Me.GColBaseNFOUNUM, Me.GColBaseVSSCFOLIB, Me.GColBaseVFOUMAT, Me.GColBaseVFOUMAR, Me.GColBaseVFOUTYPE, Me.GColBaseVFOUREF, Me.GColBaseCFOUACTIF})
        StyleFormatCondition1.Appearance.Font = CType(resources.GetObject("resource.Font"), System.Drawing.Font)
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.GColBaseCFOUACTIF
        StyleFormatCondition1.Expression = "[CFOUACTIF] == 'O'"
        Me.GVListeFouEIBase.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GVListeFouEIBase.GridControl = Me.GCListeFouEIBase
        Me.GVListeFouEIBase.Name = "GVListeFouEIBase"
        Me.GVListeFouEIBase.OptionsBehavior.Editable = False
        Me.GVListeFouEIBase.OptionsBehavior.ReadOnly = True
        Me.GVListeFouEIBase.OptionsNavigation.AutoFocusNewRow = True
        Me.GVListeFouEIBase.OptionsView.ShowGroupPanel = False
        '
        'GColBaseIDTMP
        '
        resources.ApplyResources(Me.GColBaseIDTMP, "GColBaseIDTMP")
        Me.GColBaseIDTMP.FieldName = "IDTMP"
        Me.GColBaseIDTMP.Name = "GColBaseIDTMP"
        '
        'GColBaseNFOUBASEXTID
        '
        resources.ApplyResources(Me.GColBaseNFOUBASEXTID, "GColBaseNFOUBASEXTID")
        Me.GColBaseNFOUBASEXTID.FieldName = "NFOUBASEXTID"
        Me.GColBaseNFOUBASEXTID.Name = "GColBaseNFOUBASEXTID"
        '
        'GColBaseNFOUNUM
        '
        resources.ApplyResources(Me.GColBaseNFOUNUM, "GColBaseNFOUNUM")
        Me.GColBaseNFOUNUM.FieldName = "NFOUNUM"
        Me.GColBaseNFOUNUM.Name = "GColBaseNFOUNUM"
        '
        'GColBaseVSSCFOLIB
        '
        Me.GColBaseVSSCFOLIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColBaseVSSCFOLIB.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColBaseVSSCFOLIB, "GColBaseVSSCFOLIB")
        Me.GColBaseVSSCFOLIB.FieldName = "VSSCFOLIB"
        Me.GColBaseVSSCFOLIB.Name = "GColBaseVSSCFOLIB"
        '
        'GColBaseVFOUMAT
        '
        Me.GColBaseVFOUMAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColBaseVFOUMAT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColBaseVFOUMAT, "GColBaseVFOUMAT")
        Me.GColBaseVFOUMAT.FieldName = "VFOUMAT"
        Me.GColBaseVFOUMAT.Name = "GColBaseVFOUMAT"
        '
        'GColBaseVFOUMAR
        '
        Me.GColBaseVFOUMAR.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColBaseVFOUMAR.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColBaseVFOUMAR, "GColBaseVFOUMAR")
        Me.GColBaseVFOUMAR.FieldName = "VFOUMAR"
        Me.GColBaseVFOUMAR.Name = "GColBaseVFOUMAR"
        '
        'GColBaseVFOUTYPE
        '
        Me.GColBaseVFOUTYPE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColBaseVFOUTYPE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColBaseVFOUTYPE, "GColBaseVFOUTYPE")
        Me.GColBaseVFOUTYPE.FieldName = "VFOUTYP"
        Me.GColBaseVFOUTYPE.Name = "GColBaseVFOUTYPE"
        '
        'GColBaseVFOUREF
        '
        Me.GColBaseVFOUREF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColBaseVFOUREF.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColBaseVFOUREF, "GColBaseVFOUREF")
        Me.GColBaseVFOUREF.FieldName = "VFOUREF"
        Me.GColBaseVFOUREF.Name = "GColBaseVFOUREF"
        '
        'LblLegende
        '
        Me.LblLegende.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.LblLegende, "LblLegende")
        Me.LblLegende.Name = "LblLegende"
        '
        'FrmAdminFouListeEIBase
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblLegende)
        Me.Controls.Add(Me.GrpListFouEIBase)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GrpListe)
        Me.Name = "FrmAdminFouListeEIBase"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GVlisteFouEI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCListeFouEI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpListe.ResumeLayout(False)
        Me.GrpListFouEIBase.ResumeLayout(False)
        CType(Me.GCListeFouEIBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeFouEIBase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSupprimer As System.Windows.Forms.Button
    Friend WithEvents BtnAjouter As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents GrpListe As System.Windows.Forms.GroupBox
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GrpListFouEIBase As System.Windows.Forms.GroupBox
    Friend WithEvents LblLegende As System.Windows.Forms.Label
    Private WithEvents GColVFOUMAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNFOUNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVlisteFouEI As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCListeFouEI As DevExpress.XtraGrid.GridControl
    Private WithEvents GCListeFouEIBase As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeFouEIBase As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColBaseIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColBaseNFOUNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVFOUMAR As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVFOUTYPE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVFOUREF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVSSCFOLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColBaseVSSCFOLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColBaseVFOUMAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColBaseVFOUMAR As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColBaseVFOUTYPE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColBaseVFOUREF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColBaseNFOUBASEXTID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColBaseCFOUACTIF As DevExpress.XtraGrid.Columns.GridColumn
End Class
