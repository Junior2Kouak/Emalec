<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListeCompteAnaByCliAndChaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeCompteAnaByCliAndChaff))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnAffectSuperviseur = New System.Windows.Forms.Button()
        Me.BtnAffectAssChaff = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnAffectFact = New System.Windows.Forms.Button()
        Me.BtnAffectAss = New System.Windows.Forms.Button()
        Me.BtnAffectChaff = New System.Windows.Forms.Button()
        Me.BtnModif = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GrpListe = New System.Windows.Forms.GroupBox()
        Me.GCListCptByCliAndChaff = New DevExpress.XtraGrid.GridControl()
        Me.GVListCptByCliAndChaff = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNPERNUMASS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNPERNUMFACT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColTOT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNCANNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCANLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVGRPMANAGELIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCHAFF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColASSCHAFF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColASS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColFACTU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVLISTE_CHAFF_SUPERVISEUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.BtnExportXLS = New System.Windows.Forms.Button()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.GrpActions.SuspendLayout()
        Me.GrpListe.SuspendLayout()
        CType(Me.GCListCptByCliAndChaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListCptByCliAndChaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnExportXLS)
        Me.GrpActions.Controls.Add(Me.BtnAffectSuperviseur)
        Me.GrpActions.Controls.Add(Me.BtnAffectAssChaff)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Controls.Add(Me.BtnAffectFact)
        Me.GrpActions.Controls.Add(Me.BtnAffectAss)
        Me.GrpActions.Controls.Add(Me.BtnAffectChaff)
        Me.GrpActions.Controls.Add(Me.BtnModif)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnAffectSuperviseur
        '
        resources.ApplyResources(Me.BtnAffectSuperviseur, "BtnAffectSuperviseur")
        Me.BtnAffectSuperviseur.Name = "BtnAffectSuperviseur"
        Me.BtnAffectSuperviseur.UseVisualStyleBackColor = True
        '
        'BtnAffectAssChaff
        '
        resources.ApplyResources(Me.BtnAffectAssChaff, "BtnAffectAssChaff")
        Me.BtnAffectAssChaff.Name = "BtnAffectAssChaff"
        Me.BtnAffectAssChaff.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Tag = "136"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnAffectFact
        '
        resources.ApplyResources(Me.BtnAffectFact, "BtnAffectFact")
        Me.BtnAffectFact.Name = "BtnAffectFact"
        Me.BtnAffectFact.UseVisualStyleBackColor = True
        '
        'BtnAffectAss
        '
        resources.ApplyResources(Me.BtnAffectAss, "BtnAffectAss")
        Me.BtnAffectAss.Name = "BtnAffectAss"
        Me.BtnAffectAss.UseVisualStyleBackColor = True
        '
        'BtnAffectChaff
        '
        resources.ApplyResources(Me.BtnAffectChaff, "BtnAffectChaff")
        Me.BtnAffectChaff.Name = "BtnAffectChaff"
        Me.BtnAffectChaff.UseVisualStyleBackColor = True
        '
        'BtnModif
        '
        resources.ApplyResources(Me.BtnModif, "BtnModif")
        Me.BtnModif.Name = "BtnModif"
        Me.BtnModif.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GrpListe
        '
        Me.GrpListe.Controls.Add(Me.GCListCptByCliAndChaff)
        resources.ApplyResources(Me.GrpListe, "GrpListe")
        Me.GrpListe.Name = "GrpListe"
        Me.GrpListe.TabStop = False
        '
        'GCListCptByCliAndChaff
        '
        resources.ApplyResources(Me.GCListCptByCliAndChaff, "GCListCptByCliAndChaff")
        Me.GCListCptByCliAndChaff.MainView = Me.GVListCptByCliAndChaff
        Me.GCListCptByCliAndChaff.Name = "GCListCptByCliAndChaff"
        Me.GCListCptByCliAndChaff.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListCptByCliAndChaff})
        '
        'GVListCptByCliAndChaff
        '
        Me.GVListCptByCliAndChaff.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GVListCptByCliAndChaff.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVListCptByCliAndChaff.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVListCptByCliAndChaff.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCliAndChaff.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVListCptByCliAndChaff.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVListCptByCliAndChaff.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVListCptByCliAndChaff.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVListCptByCliAndChaff.Appearance.Empty.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCliAndChaff.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVListCptByCliAndChaff.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVListCptByCliAndChaff.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GVListCptByCliAndChaff.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVListCptByCliAndChaff.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVListCptByCliAndChaff.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVListCptByCliAndChaff.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVListCptByCliAndChaff.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCliAndChaff.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVListCptByCliAndChaff.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVListCptByCliAndChaff.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCliAndChaff.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVListCptByCliAndChaff.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVListCptByCliAndChaff.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVListCptByCliAndChaff.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVListCptByCliAndChaff.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCliAndChaff.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVListCptByCliAndChaff.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVListCptByCliAndChaff.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVListCptByCliAndChaff.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCliAndChaff.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVListCptByCliAndChaff.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVListCptByCliAndChaff.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVListCptByCliAndChaff.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVListCptByCliAndChaff.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCliAndChaff.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVListCptByCliAndChaff.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCliAndChaff.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVListCptByCliAndChaff.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVListCptByCliAndChaff.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCliAndChaff.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVListCptByCliAndChaff.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVListCptByCliAndChaff.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVListCptByCliAndChaff.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVListCptByCliAndChaff.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCliAndChaff.Appearance.OddRow.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVListCptByCliAndChaff.Appearance.OddRow.Options.UseForeColor = True
        Me.GVListCptByCliAndChaff.Appearance.Preview.Font = CType(resources.GetObject("GVListCptByCliAndChaff.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVListCptByCliAndChaff.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.Preview.Options.UseFont = True
        Me.GVListCptByCliAndChaff.Appearance.Preview.Options.UseForeColor = True
        Me.GVListCptByCliAndChaff.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCliAndChaff.Appearance.Row.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.Row.Options.UseForeColor = True
        Me.GVListCptByCliAndChaff.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVListCptByCliAndChaff.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVListCptByCliAndChaff.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVListCptByCliAndChaff.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVListCptByCliAndChaff.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVListCptByCliAndChaff.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCliAndChaff.Appearance.VertLine.Options.UseBackColor = True
        Me.GVListCptByCliAndChaff.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNCLINUM, Me.GColNPERNUMASS, Me.GColNPERNUMFACT, Me.GColVCLINOM, Me.GColTOT, Me.GColNCANNUM, Me.GColVCANLIB, Me.GColVGRPMANAGELIB, Me.GColCHAFF, Me.GColASSCHAFF, Me.GColASS, Me.GColFACTU, Me.GColVLISTE_CHAFF_SUPERVISEUR, Me.GCol_NPERNUM})
        Me.GVListCptByCliAndChaff.GridControl = Me.GCListCptByCliAndChaff
        Me.GVListCptByCliAndChaff.Name = "GVListCptByCliAndChaff"
        Me.GVListCptByCliAndChaff.OptionsBehavior.Editable = False
        Me.GVListCptByCliAndChaff.OptionsBehavior.ReadOnly = True
        Me.GVListCptByCliAndChaff.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListCptByCliAndChaff.OptionsView.EnableAppearanceOddRow = True
        Me.GVListCptByCliAndChaff.OptionsView.RowAutoHeight = True
        Me.GVListCptByCliAndChaff.OptionsView.ShowAutoFilterRow = True
        Me.GVListCptByCliAndChaff.OptionsView.ShowFooter = True
        Me.GVListCptByCliAndChaff.OptionsView.ShowGroupPanel = False
        '
        'GColNCLINUM
        '
        resources.ApplyResources(Me.GColNCLINUM, "GColNCLINUM")
        Me.GColNCLINUM.FieldName = "NCLINUM"
        Me.GColNCLINUM.Name = "GColNCLINUM"
        Me.GColNCLINUM.OptionsColumn.AllowEdit = False
        Me.GColNCLINUM.OptionsColumn.ReadOnly = True
        Me.GColNCLINUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNPERNUMASS
        '
        resources.ApplyResources(Me.GColNPERNUMASS, "GColNPERNUMASS")
        Me.GColNPERNUMASS.FieldName = "NPERNUMASS"
        Me.GColNPERNUMASS.Name = "GColNPERNUMASS"
        '
        'GColNPERNUMFACT
        '
        resources.ApplyResources(Me.GColNPERNUMFACT, "GColNPERNUMFACT")
        Me.GColNPERNUMFACT.FieldName = "NPERNUMFACT"
        Me.GColNPERNUMFACT.Name = "GColNPERNUMFACT"
        '
        'GColVCLINOM
        '
        Me.GColVCLINOM.AppearanceHeader.Font = CType(resources.GetObject("GColVCLINOM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVCLINOM.AppearanceHeader.Options.UseFont = True
        Me.GColVCLINOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVCLINOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVCLINOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVCLINOM, "GColVCLINOM")
        Me.GColVCLINOM.FieldName = "VCLINOM"
        Me.GColVCLINOM.Name = "GColVCLINOM"
        Me.GColVCLINOM.OptionsColumn.AllowEdit = False
        Me.GColVCLINOM.OptionsColumn.ReadOnly = True
        Me.GColVCLINOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColTOT
        '
        Me.GColTOT.AppearanceHeader.Font = CType(resources.GetObject("GColTOT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColTOT.AppearanceHeader.Options.UseFont = True
        Me.GColTOT.AppearanceHeader.Options.UseTextOptions = True
        Me.GColTOT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColTOT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColTOT, "GColTOT")
        Me.GColTOT.DisplayFormat.FormatString = "c0"
        Me.GColTOT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColTOT.FieldName = "TOT"
        Me.GColTOT.Name = "GColTOT"
        Me.GColTOT.OptionsColumn.AllowEdit = False
        Me.GColTOT.OptionsColumn.ReadOnly = True
        Me.GColTOT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GColTOT.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("GColTOT.Summary1"), resources.GetString("GColTOT.Summary2"))})
        '
        'GColNCANNUM
        '
        Me.GColNCANNUM.AppearanceCell.Options.UseTextOptions = True
        Me.GColNCANNUM.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.GColNCANNUM.AppearanceHeader.Font = CType(resources.GetObject("GColNCANNUM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColNCANNUM.AppearanceHeader.Options.UseFont = True
        Me.GColNCANNUM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColNCANNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNCANNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColNCANNUM, "GColNCANNUM")
        Me.GColNCANNUM.FieldName = "NCANNUM"
        Me.GColNCANNUM.Name = "GColNCANNUM"
        Me.GColNCANNUM.OptionsColumn.AllowEdit = False
        Me.GColNCANNUM.OptionsColumn.ReadOnly = True
        Me.GColNCANNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
        '
        'GColVCANLIB
        '
        Me.GColVCANLIB.AppearanceHeader.Font = CType(resources.GetObject("GColVCANLIB.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVCANLIB.AppearanceHeader.Options.UseFont = True
        Me.GColVCANLIB.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVCANLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVCANLIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVCANLIB, "GColVCANLIB")
        Me.GColVCANLIB.FieldName = "VCANLIB"
        Me.GColVCANLIB.Name = "GColVCANLIB"
        Me.GColVCANLIB.OptionsColumn.AllowEdit = False
        Me.GColVCANLIB.OptionsColumn.ReadOnly = True
        Me.GColVCANLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVGRPMANAGELIB
        '
        Me.GColVGRPMANAGELIB.AppearanceHeader.Font = CType(resources.GetObject("GColVGRPMANAGELIB.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVGRPMANAGELIB.AppearanceHeader.Options.UseFont = True
        Me.GColVGRPMANAGELIB.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVGRPMANAGELIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVGRPMANAGELIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVGRPMANAGELIB.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVGRPMANAGELIB, "GColVGRPMANAGELIB")
        Me.GColVGRPMANAGELIB.FieldName = "VGRPMANAGELIB"
        Me.GColVGRPMANAGELIB.Name = "GColVGRPMANAGELIB"
        '
        'GColCHAFF
        '
        Me.GColCHAFF.AppearanceHeader.Font = CType(resources.GetObject("GColCHAFF.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColCHAFF.AppearanceHeader.Options.UseFont = True
        Me.GColCHAFF.AppearanceHeader.Options.UseTextOptions = True
        Me.GColCHAFF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCHAFF.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColCHAFF.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColCHAFF, "GColCHAFF")
        Me.GColCHAFF.FieldName = "CHAFF"
        Me.GColCHAFF.Name = "GColCHAFF"
        '
        'GColASSCHAFF
        '
        Me.GColASSCHAFF.AppearanceHeader.Font = CType(resources.GetObject("GColASSCHAFF.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColASSCHAFF.AppearanceHeader.Options.UseFont = True
        Me.GColASSCHAFF.AppearanceHeader.Options.UseTextOptions = True
        Me.GColASSCHAFF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GColASSCHAFF, "GColASSCHAFF")
        Me.GColASSCHAFF.FieldName = "ASSCHAFF"
        Me.GColASSCHAFF.Name = "GColASSCHAFF"
        '
        'GColASS
        '
        Me.GColASS.AppearanceHeader.Font = CType(resources.GetObject("GColASS.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColASS.AppearanceHeader.Options.UseFont = True
        Me.GColASS.AppearanceHeader.Options.UseTextOptions = True
        Me.GColASS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColASS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColASS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColASS, "GColASS")
        Me.GColASS.FieldName = "ASS"
        Me.GColASS.Name = "GColASS"
        '
        'GColFACTU
        '
        Me.GColFACTU.AppearanceHeader.Font = CType(resources.GetObject("GColFACTU.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColFACTU.AppearanceHeader.Options.UseFont = True
        Me.GColFACTU.AppearanceHeader.Options.UseTextOptions = True
        Me.GColFACTU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColFACTU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColFACTU.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColFACTU, "GColFACTU")
        Me.GColFACTU.FieldName = "FACTU"
        Me.GColFACTU.Name = "GColFACTU"
        '
        'GColVLISTE_CHAFF_SUPERVISEUR
        '
        Me.GColVLISTE_CHAFF_SUPERVISEUR.AppearanceHeader.Font = CType(resources.GetObject("GColVLISTE_CHAFF_SUPERVISEUR.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVLISTE_CHAFF_SUPERVISEUR.AppearanceHeader.Options.UseFont = True
        Me.GColVLISTE_CHAFF_SUPERVISEUR.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVLISTE_CHAFF_SUPERVISEUR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVLISTE_CHAFF_SUPERVISEUR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVLISTE_CHAFF_SUPERVISEUR, "GColVLISTE_CHAFF_SUPERVISEUR")
        Me.GColVLISTE_CHAFF_SUPERVISEUR.FieldName = "VLISTE_CHAFF_SUPERVISEUR"
        Me.GColVLISTE_CHAFF_SUPERVISEUR.Name = "GColVLISTE_CHAFF_SUPERVISEUR"
        '
        'GCol_NPERNUM
        '
        resources.ApplyResources(Me.GCol_NPERNUM, "GCol_NPERNUM")
        Me.GCol_NPERNUM.FieldName = "NPERNUM"
        Me.GCol_NPERNUM.Name = "GCol_NPERNUM"
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'BtnExportXLS
        '
        resources.ApplyResources(Me.BtnExportXLS, "BtnExportXLS")
        Me.BtnExportXLS.Name = "BtnExportXLS"
        Me.BtnExportXLS.Tag = "136"
        Me.BtnExportXLS.UseVisualStyleBackColor = True
        '
        'frmListeCompteAnaByCliAndChaff
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GrpListe)
        Me.Name = "frmListeCompteAnaByCliAndChaff"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.GrpListe.ResumeLayout(False)
        CType(Me.GCListCptByCliAndChaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListCptByCliAndChaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents GrpListe As System.Windows.Forms.GroupBox
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents BtnModif As System.Windows.Forms.Button
    Friend WithEvents BtnAffectChaff As System.Windows.Forms.Button
    Friend WithEvents BtnAffectFact As System.Windows.Forms.Button
    Friend WithEvents BtnAffectAss As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Private WithEvents GCListCptByCliAndChaff As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListCptByCliAndChaff As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColTOT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNCANNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCANLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVGRPMANAGELIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCHAFF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColASS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColFACTU As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNPERNUMASS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNPERNUMFACT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColASSCHAFF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnAffectAssChaff As Button
    Friend WithEvents GColVLISTE_CHAFF_SUPERVISEUR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnAffectSuperviseur As Button
    Friend WithEvents GCol_NPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnExportXLS As Button
    Friend WithEvents SFD As SaveFileDialog
End Class
