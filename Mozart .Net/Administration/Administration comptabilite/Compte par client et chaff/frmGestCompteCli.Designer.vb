<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestCompteCli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestCompteCli))
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.btnLienFiliale = New System.Windows.Forms.Button()
        Me.BtnRestaurer = New System.Windows.Forms.Button()
        Me.ChkArchives = New System.Windows.Forms.CheckBox()
        Me.BtnArchiver = New System.Windows.Forms.Button()
        Me.BtnModif = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GrpListe = New System.Windows.Forms.GroupBox()
        Me.GCListCptByCli = New DevExpress.XtraGrid.GridControl()
        Me.GVListCptByCli = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNCANNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCANLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColLIBGROUPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColASS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColASSCHAFF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColFAC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCCANACTIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNPERNUMASS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNPERNUMASSCHAFF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNPERNUMFAC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolCCANDEFWEBCLI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions.SuspendLayout()
        Me.GrpListe.SuspendLayout()
        CType(Me.GCListCptByCli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListCptByCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.btnLienFiliale)
        Me.GrpActions.Controls.Add(Me.BtnRestaurer)
        Me.GrpActions.Controls.Add(Me.ChkArchives)
        Me.GrpActions.Controls.Add(Me.BtnArchiver)
        Me.GrpActions.Controls.Add(Me.BtnModif)
        Me.GrpActions.Controls.Add(Me.BtnNew)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'btnLienFiliale
        '
        resources.ApplyResources(Me.btnLienFiliale, "btnLienFiliale")
        Me.btnLienFiliale.Name = "btnLienFiliale"
        Me.btnLienFiliale.Tag = ""
        Me.btnLienFiliale.UseVisualStyleBackColor = True
        '
        'BtnRestaurer
        '
        resources.ApplyResources(Me.BtnRestaurer, "BtnRestaurer")
        Me.BtnRestaurer.Name = "BtnRestaurer"
        Me.BtnRestaurer.Tag = "23"
        Me.BtnRestaurer.UseVisualStyleBackColor = True
        '
        'ChkArchives
        '
        resources.ApplyResources(Me.ChkArchives, "ChkArchives")
        Me.ChkArchives.Name = "ChkArchives"
        Me.ChkArchives.UseVisualStyleBackColor = True
        '
        'BtnArchiver
        '
        resources.ApplyResources(Me.BtnArchiver, "BtnArchiver")
        Me.BtnArchiver.Name = "BtnArchiver"
        Me.BtnArchiver.Tag = "23"
        Me.BtnArchiver.UseVisualStyleBackColor = True
        '
        'BtnModif
        '
        resources.ApplyResources(Me.BtnModif, "BtnModif")
        Me.BtnModif.Name = "BtnModif"
        Me.BtnModif.Tag = "23"
        Me.BtnModif.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        resources.ApplyResources(Me.BtnNew, "BtnNew")
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Tag = "22"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GrpListe
        '
        Me.GrpListe.Controls.Add(Me.GCListCptByCli)
        resources.ApplyResources(Me.GrpListe, "GrpListe")
        Me.GrpListe.Name = "GrpListe"
        Me.GrpListe.TabStop = False
        '
        'GCListCptByCli
        '
        resources.ApplyResources(Me.GCListCptByCli, "GCListCptByCli")
        Me.GCListCptByCli.MainView = Me.GVListCptByCli
        Me.GCListCptByCli.Name = "GCListCptByCli"
        Me.GCListCptByCli.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListCptByCli})
        '
        'GVListCptByCli
        '
        Me.GVListCptByCli.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCli.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCli.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GVListCptByCli.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVListCptByCli.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVListCptByCli.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListCptByCli.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListCptByCli.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCli.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVListCptByCli.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVListCptByCli.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCli.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVListCptByCli.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVListCptByCli.Appearance.Empty.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCli.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCli.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCli.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVListCptByCli.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVListCptByCli.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCli.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCli.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GVListCptByCli.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVListCptByCli.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVListCptByCli.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCli.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVListCptByCli.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVListCptByCli.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCli.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVListCptByCli.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GVListCptByCli.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVListCptByCli.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCli.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVListCptByCli.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GVListCptByCli.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GVListCptByCli.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVListCptByCli.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVListCptByCli.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVListCptByCli.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCli.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCli.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCli.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVListCptByCli.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVListCptByCli.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCli.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCli.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVListCptByCli.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListCptByCli.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListCptByCli.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCli.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVListCptByCli.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVListCptByCli.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCli.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVListCptByCli.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVListCptByCli.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCli.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVListCptByCli.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListCptByCli.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListCptByCli.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCli.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVListCptByCli.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVListCptByCli.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListCptByCli.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListCptByCli.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCli.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVListCptByCli.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVListCptByCli.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GVListCptByCli.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListCptByCli.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCli.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVListCptByCli.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVListCptByCli.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCli.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCli.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCli.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCli.Appearance.OddRow.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVListCptByCli.Appearance.OddRow.Options.UseForeColor = True
        Me.GVListCptByCli.Appearance.Preview.Font = CType(resources.GetObject("GVListCptByCli.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVListCptByCli.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListCptByCli.Appearance.Preview.Options.UseFont = True
        Me.GVListCptByCli.Appearance.Preview.Options.UseForeColor = True
        Me.GVListCptByCli.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCli.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVListCptByCli.Appearance.Row.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.Row.Options.UseForeColor = True
        Me.GVListCptByCli.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListCptByCli.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVListCptByCli.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVListCptByCli.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListCptByCli.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVListCptByCli.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVListCptByCli.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVListCptByCli.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVListCptByCli.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListCptByCli.Appearance.VertLine.Options.UseBackColor = True
        Me.GVListCptByCli.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNPERNUM, Me.GColVPERNOM, Me.GColNCANNUM, Me.GColVCANLIB, Me.GColLIBGROUPE, Me.GColASS, Me.GColASSCHAFF, Me.GColFAC, Me.GColCCANACTIF, Me.GColNPERNUMASS, Me.GColNPERNUMASSCHAFF, Me.GColNPERNUMFAC, Me.gcolCCANDEFWEBCLI})
        Me.GVListCptByCli.GridControl = Me.GCListCptByCli
        Me.GVListCptByCli.Name = "GVListCptByCli"
        Me.GVListCptByCli.OptionsBehavior.Editable = False
        Me.GVListCptByCli.OptionsBehavior.ReadOnly = True
        Me.GVListCptByCli.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListCptByCli.OptionsView.EnableAppearanceOddRow = True
        Me.GVListCptByCli.OptionsView.RowAutoHeight = True
        Me.GVListCptByCli.OptionsView.ShowAutoFilterRow = True
        Me.GVListCptByCli.OptionsView.ShowFooter = True
        Me.GVListCptByCli.OptionsView.ShowGroupPanel = False
        '
        'GColNPERNUM
        '
        Me.GColNPERNUM.AppearanceCell.Options.UseTextOptions = True
        Me.GColNPERNUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GColNPERNUM, "GColNPERNUM")
        Me.GColNPERNUM.FieldName = "NPERNUM"
        Me.GColNPERNUM.Name = "GColNPERNUM"
        Me.GColNPERNUM.OptionsColumn.AllowEdit = False
        Me.GColNPERNUM.OptionsColumn.ReadOnly = True
        Me.GColNPERNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVPERNOM
        '
        Me.GColVPERNOM.AppearanceHeader.Font = CType(resources.GetObject("GColVPERNOM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVPERNOM.AppearanceHeader.Options.UseFont = True
        Me.GColVPERNOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVPERNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVPERNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVPERNOM, "GColVPERNOM")
        Me.GColVPERNOM.FieldName = "VPERNOM"
        Me.GColVPERNOM.Name = "GColVPERNOM"
        Me.GColVPERNOM.OptionsColumn.AllowEdit = False
        Me.GColVPERNOM.OptionsColumn.ReadOnly = True
        Me.GColVPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
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
        'GColLIBGROUPE
        '
        Me.GColLIBGROUPE.AppearanceHeader.Font = CType(resources.GetObject("GColLIBGROUPE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColLIBGROUPE.AppearanceHeader.Options.UseFont = True
        Me.GColLIBGROUPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColLIBGROUPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColLIBGROUPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColLIBGROUPE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColLIBGROUPE, "GColLIBGROUPE")
        Me.GColLIBGROUPE.FieldName = "LIBGROUPE"
        Me.GColLIBGROUPE.Name = "GColLIBGROUPE"
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
        'GColFAC
        '
        Me.GColFAC.AppearanceHeader.Font = CType(resources.GetObject("GColFAC.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColFAC.AppearanceHeader.Options.UseFont = True
        Me.GColFAC.AppearanceHeader.Options.UseTextOptions = True
        Me.GColFAC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColFAC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColFAC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColFAC, "GColFAC")
        Me.GColFAC.FieldName = "FAC"
        Me.GColFAC.Name = "GColFAC"
        '
        'GColCCANACTIF
        '
        resources.ApplyResources(Me.GColCCANACTIF, "GColCCANACTIF")
        Me.GColCCANACTIF.FieldName = "CCANACTIF"
        Me.GColCCANACTIF.Name = "GColCCANACTIF"
        '
        'GColNPERNUMASS
        '
        Me.GColNPERNUMASS.FieldName = "NPERNUMASS"
        Me.GColNPERNUMASS.Name = "GColNPERNUMASS"
        '
        'GColNPERNUMASSCHAFF
        '
        Me.GColNPERNUMASSCHAFF.FieldName = "NPERNUMASSCHAFF"
        Me.GColNPERNUMASSCHAFF.Name = "GColNPERNUMASSCHAFF"
        '
        'GColNPERNUMFAC
        '
        Me.GColNPERNUMFAC.FieldName = "NPERNUMFAC"
        Me.GColNPERNUMFAC.Name = "GColNPERNUMFAC"
        '
        'gcolCCANDEFWEBCLI
        '
        Me.gcolCCANDEFWEBCLI.AppearanceCell.Options.UseTextOptions = True
        Me.gcolCCANDEFWEBCLI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcolCCANDEFWEBCLI.AppearanceHeader.Font = CType(resources.GetObject("gcolCCANDEFWEBCLI.AppearanceHeader.Font"), System.Drawing.Font)
        Me.gcolCCANDEFWEBCLI.AppearanceHeader.Options.UseFont = True
        Me.gcolCCANDEFWEBCLI.AppearanceHeader.Options.UseTextOptions = True
        Me.gcolCCANDEFWEBCLI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.gcolCCANDEFWEBCLI, "gcolCCANDEFWEBCLI")
        Me.gcolCCANDEFWEBCLI.FieldName = "CCANDEFWEBCLI"
        Me.gcolCCANDEFWEBCLI.Name = "gcolCCANDEFWEBCLI"
        '
        'frmGestCompteCli
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnFermer
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GrpListe)
        Me.Name = "frmGestCompteCli"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.GrpListe.ResumeLayout(False)
        CType(Me.GCListCptByCli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListCptByCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents GrpListe As System.Windows.Forms.GroupBox
    Friend WithEvents BtnModif As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnArchiver As System.Windows.Forms.Button
    Friend WithEvents ChkArchives As System.Windows.Forms.CheckBox
    Friend WithEvents BtnRestaurer As System.Windows.Forms.Button
    Private WithEvents GCListCptByCli As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListCptByCli As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNCANNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCANLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColLIBGROUPE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColASS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColFAC As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCCANACTIF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNPERNUMASS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNPERNUMFAC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColASSCHAFF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNPERNUMASSCHAFF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolCCANDEFWEBCLI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnLienFiliale As Button
End Class
