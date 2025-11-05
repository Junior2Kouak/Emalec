<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminModeleTexte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminModeleTexte))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnDetail = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnSupprimer = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GCListeModelText = New DevExpress.XtraGrid.GridControl()
        Me.GVListeModelText = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNIDMODELTEXT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCHAPITRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSSCHAPITRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVTEXTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GColDDATEMOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpListe = New System.Windows.Forms.GroupBox()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCListeModelText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeModelText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpListe.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnDetail)
        Me.GrpActions.Controls.Add(Me.BtnNew)
        Me.GrpActions.Controls.Add(Me.BtnSupprimer)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnDetail
        '
        resources.ApplyResources(Me.BtnDetail, "BtnDetail")
        Me.BtnDetail.Name = "BtnDetail"
        Me.BtnDetail.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        resources.ApplyResources(Me.BtnNew, "BtnNew")
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnSupprimer
        '
        resources.ApplyResources(Me.BtnSupprimer, "BtnSupprimer")
        Me.BtnSupprimer.Name = "BtnSupprimer"
        Me.BtnSupprimer.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GCListeModelText
        '
        resources.ApplyResources(Me.GCListeModelText, "GCListeModelText")
        Me.GCListeModelText.MainView = Me.GVListeModelText
        Me.GCListeModelText.Name = "GCListeModelText"
        Me.GCListeModelText.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.GCListeModelText.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeModelText})
        '
        'GVListeModelText
        '
        Me.GVListeModelText.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeModelText.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeModelText.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GVListeModelText.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVListeModelText.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVListeModelText.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListeModelText.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListeModelText.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVListeModelText.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVListeModelText.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVListeModelText.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeModelText.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVListeModelText.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVListeModelText.Appearance.Empty.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeModelText.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeModelText.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVListeModelText.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVListeModelText.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVListeModelText.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeModelText.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeModelText.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GVListeModelText.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVListeModelText.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVListeModelText.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeModelText.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVListeModelText.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVListeModelText.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListeModelText.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVListeModelText.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GVListeModelText.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVListeModelText.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVListeModelText.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVListeModelText.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GVListeModelText.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GVListeModelText.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVListeModelText.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVListeModelText.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVListeModelText.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeModelText.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeModelText.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListeModelText.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVListeModelText.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVListeModelText.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeModelText.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeModelText.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVListeModelText.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListeModelText.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListeModelText.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVListeModelText.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVListeModelText.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVListeModelText.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeModelText.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVListeModelText.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVListeModelText.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListeModelText.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVListeModelText.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListeModelText.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListeModelText.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVListeModelText.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVListeModelText.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVListeModelText.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListeModelText.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListeModelText.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListeModelText.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVListeModelText.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVListeModelText.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GVListeModelText.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListeModelText.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeModelText.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVListeModelText.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVListeModelText.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeModelText.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeModelText.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeModelText.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVListeModelText.Appearance.OddRow.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVListeModelText.Appearance.OddRow.Options.UseForeColor = True
        Me.GVListeModelText.Appearance.Preview.Font = CType(resources.GetObject("GVListeModelText.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVListeModelText.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListeModelText.Appearance.Preview.Options.UseFont = True
        Me.GVListeModelText.Appearance.Preview.Options.UseForeColor = True
        Me.GVListeModelText.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeModelText.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVListeModelText.Appearance.Row.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.Row.Options.UseForeColor = True
        Me.GVListeModelText.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeModelText.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVListeModelText.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVListeModelText.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListeModelText.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVListeModelText.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVListeModelText.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVListeModelText.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVListeModelText.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListeModelText.Appearance.VertLine.Options.UseBackColor = True
        Me.GVListeModelText.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNIDMODELTEXT, Me.GColVCHAPITRE, Me.GColVSSCHAPITRE, Me.GColVTEXTE, Me.GColDDATEMOD})
        Me.GVListeModelText.GridControl = Me.GCListeModelText
        Me.GVListeModelText.Name = "GVListeModelText"
        Me.GVListeModelText.OptionsBehavior.Editable = False
        Me.GVListeModelText.OptionsBehavior.ReadOnly = True
        Me.GVListeModelText.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListeModelText.OptionsView.EnableAppearanceOddRow = True
        Me.GVListeModelText.OptionsView.RowAutoHeight = True
        Me.GVListeModelText.OptionsView.ShowAutoFilterRow = True
        Me.GVListeModelText.OptionsView.ShowGroupPanel = False
        '
        'GColNIDMODELTEXT
        '
        resources.ApplyResources(Me.GColNIDMODELTEXT, "GColNIDMODELTEXT")
        Me.GColNIDMODELTEXT.FieldName = "NIDMODELTEXT"
        Me.GColNIDMODELTEXT.Name = "GColNIDMODELTEXT"
        Me.GColNIDMODELTEXT.OptionsColumn.AllowEdit = False
        Me.GColNIDMODELTEXT.OptionsColumn.ReadOnly = True
        Me.GColNIDMODELTEXT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVCHAPITRE
        '
        Me.GColVCHAPITRE.AppearanceHeader.Font = CType(resources.GetObject("GColVCHAPITRE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVCHAPITRE.AppearanceHeader.Options.UseFont = True
        Me.GColVCHAPITRE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVCHAPITRE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVCHAPITRE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVCHAPITRE, "GColVCHAPITRE")
        Me.GColVCHAPITRE.FieldName = "VCHAPITRE"
        Me.GColVCHAPITRE.Name = "GColVCHAPITRE"
        Me.GColVCHAPITRE.OptionsColumn.AllowEdit = False
        Me.GColVCHAPITRE.OptionsColumn.ReadOnly = True
        Me.GColVCHAPITRE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVSSCHAPITRE
        '
        Me.GColVSSCHAPITRE.AppearanceHeader.Font = CType(resources.GetObject("GColVSSCHAPITRE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVSSCHAPITRE.AppearanceHeader.Options.UseFont = True
        Me.GColVSSCHAPITRE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVSSCHAPITRE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVSSCHAPITRE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVSSCHAPITRE, "GColVSSCHAPITRE")
        Me.GColVSSCHAPITRE.FieldName = "VSSCHAPITRE"
        Me.GColVSSCHAPITRE.Name = "GColVSSCHAPITRE"
        Me.GColVSSCHAPITRE.OptionsColumn.AllowEdit = False
        Me.GColVSSCHAPITRE.OptionsColumn.ReadOnly = True
        '
        'GColVTEXTE
        '
        Me.GColVTEXTE.AppearanceCell.Options.UseTextOptions = True
        Me.GColVTEXTE.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.GColVTEXTE.AppearanceHeader.Font = CType(resources.GetObject("GColVTEXTE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVTEXTE.AppearanceHeader.Options.UseFont = True
        Me.GColVTEXTE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVTEXTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVTEXTE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVTEXTE, "GColVTEXTE")
        Me.GColVTEXTE.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.GColVTEXTE.FieldName = "VTEXTE"
        Me.GColVTEXTE.Name = "GColVTEXTE"
        Me.GColVTEXTE.OptionsColumn.AllowEdit = False
        Me.GColVTEXTE.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'GColDDATEMOD
        '
        Me.GColDDATEMOD.AppearanceHeader.Font = CType(resources.GetObject("GColDDATEMOD.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDDATEMOD.AppearanceHeader.Options.UseFont = True
        Me.GColDDATEMOD.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDDATEMOD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDDATEMOD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDDATEMOD, "GColDDATEMOD")
        Me.GColDDATEMOD.FieldName = "DDATEMOD"
        Me.GColDDATEMOD.Name = "GColDDATEMOD"
        Me.GColDDATEMOD.OptionsColumn.AllowEdit = False
        Me.GColDDATEMOD.OptionsColumn.ReadOnly = True
        Me.GColDDATEMOD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GrpListe
        '
        resources.ApplyResources(Me.GrpListe, "GrpListe")
        Me.GrpListe.Controls.Add(Me.GCListeModelText)
        Me.GrpListe.Name = "GrpListe"
        Me.GrpListe.TabStop = False
        '
        'frmAdminModeleTexte
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnFermer
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GrpListe)
        Me.Name = "frmAdminModeleTexte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCListeModelText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeModelText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpListe.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSupprimer As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents GrpListe As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDetail As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Private WithEvents GCListeModelText As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeModelText As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNIDMODELTEXT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCHAPITRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVSSCHAPITRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVTEXTE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDDATEMOD As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
End Class
