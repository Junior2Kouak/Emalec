<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanifAuto_Liste
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode3 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue4 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule5 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue5 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.GCol_2_NPLA_AUTO_ID_RESULT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVListePreviewByPlaAuto = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_2_NPLA_AUTO_ID_PREVIEW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_2_DPLA_AUTO_PREVIEW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_2_PC_ACT_ETAT_P = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_2_PC_ACT_ETAT_S = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_2_TOT_ACT_ETAT_P = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_2_TOT_ACT_ETAT_S = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_2_TOT_ACT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_2_BREADYTOPLANIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChk_BREADYTOPLANIF = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GCPLANIFAUTO = New DevExpress.XtraGrid.GridControl()
        Me.GVPLANIFAUTO = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNPLA_AUTO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVPERIODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVJOUR_FORBIDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVTECH_MODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVBLOC_PAVE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDDATECREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDDATEMOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVQUICREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVQUIMOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDDATE_TRAITEMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCPLA_AUTO_ETAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVPLA_AUTO_ETAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit_NCOCHE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GVListePreviewByAction = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNCOCHE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_3_NPLA_AUTO_ACT_ID_PREVIEW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_3_NPLA_AUTO_ID_PREVIEW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_3_NPLA_AUTO_ACT_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_3_VCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_3_VSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_3_VTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_3_NDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_3_DACTDAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_3_VACTDES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_3_NACTDUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_3_NDUREE_J = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_3_VPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_3_DACTPLA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_3_NCODE_ERROR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_3_VPLA_AUTO_ACT_LOG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_3_CETAT_ACT_PLA_AUTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVListeResultPlanifByAction = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_4_NACTNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_4_NIPLNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_4_VCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_4_VSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_4_NDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_4_DACTDAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_4_VACTDES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_4_NACTDUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_4_CETACOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_4_VPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_4_DACTPLA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_4_DACTPLA_PREVIEW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_4_NCODE_ERROR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnChangeEtat = New System.Windows.Forms.Button()
        Me.BtnArchives = New System.Windows.Forms.Button()
        Me.BtnMod = New System.Windows.Forms.Button()
        Me.BtnSupprLine = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        CType(Me.GVListePreviewByPlaAuto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChk_BREADYTOPLANIF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPLANIFAUTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPLANIFAUTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit_NCOCHE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListePreviewByAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeResultPlanifByAction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCol_2_NPLA_AUTO_ID_RESULT
        '
        Me.GCol_2_NPLA_AUTO_ID_RESULT.Caption = "NPLA_AUTO_ID_RESULT"
        Me.GCol_2_NPLA_AUTO_ID_RESULT.FieldName = "NPLA_AUTO_ID_RESULT"
        Me.GCol_2_NPLA_AUTO_ID_RESULT.Name = "GCol_2_NPLA_AUTO_ID_RESULT"
        '
        'GVListePreviewByPlaAuto
        '
        Me.GVListePreviewByPlaAuto.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListePreviewByPlaAuto.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListePreviewByPlaAuto.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListePreviewByPlaAuto.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListePreviewByPlaAuto.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListePreviewByPlaAuto.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListePreviewByPlaAuto.Appearance.ViewCaption.BackColor = System.Drawing.Color.NavajoWhite
        Me.GVListePreviewByPlaAuto.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListePreviewByPlaAuto.Appearance.ViewCaption.Options.UseBackColor = True
        Me.GVListePreviewByPlaAuto.Appearance.ViewCaption.Options.UseFont = True
        Me.GVListePreviewByPlaAuto.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_2_NPLA_AUTO_ID_PREVIEW, Me.GCol_2_DPLA_AUTO_PREVIEW, Me.GCol_2_PC_ACT_ETAT_P, Me.GCol_2_PC_ACT_ETAT_S, Me.GCol_2_TOT_ACT_ETAT_P, Me.GCol_2_TOT_ACT_ETAT_S, Me.GCol_2_TOT_ACT, Me.GCol_2_BREADYTOPLANIF, Me.GCol_2_NPLA_AUTO_ID_RESULT})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.GCol_2_NPLA_AUTO_ID_RESULT
        GridFormatRule1.Enabled = False
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.GreenYellow
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Expression = "[NPLA_AUTO_ID_RESULT] > 0"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.GVListePreviewByPlaAuto.FormatRules.Add(GridFormatRule1)
        Me.GVListePreviewByPlaAuto.GridControl = Me.GCPLANIFAUTO
        Me.GVListePreviewByPlaAuto.Name = "GVListePreviewByPlaAuto"
        Me.GVListePreviewByPlaAuto.OptionsView.ShowGroupPanel = False
        Me.GVListePreviewByPlaAuto.ViewCaption = "Liste des simulations de planification"
        '
        'GCol_2_NPLA_AUTO_ID_PREVIEW
        '
        Me.GCol_2_NPLA_AUTO_ID_PREVIEW.Caption = "NPLA_AUTO_ID_PREVIEW"
        Me.GCol_2_NPLA_AUTO_ID_PREVIEW.FieldName = "NPLA_AUTO_ID_PREVIEW"
        Me.GCol_2_NPLA_AUTO_ID_PREVIEW.Name = "GCol_2_NPLA_AUTO_ID_PREVIEW"
        Me.GCol_2_NPLA_AUTO_ID_PREVIEW.OptionsColumn.AllowEdit = False
        '
        'GCol_2_DPLA_AUTO_PREVIEW
        '
        Me.GCol_2_DPLA_AUTO_PREVIEW.Caption = "Date Simulation"
        Me.GCol_2_DPLA_AUTO_PREVIEW.DisplayFormat.FormatString = "d"
        Me.GCol_2_DPLA_AUTO_PREVIEW.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GCol_2_DPLA_AUTO_PREVIEW.FieldName = "DPLA_AUTO_PREVIEW"
        Me.GCol_2_DPLA_AUTO_PREVIEW.Name = "GCol_2_DPLA_AUTO_PREVIEW"
        Me.GCol_2_DPLA_AUTO_PREVIEW.OptionsColumn.AllowEdit = False
        Me.GCol_2_DPLA_AUTO_PREVIEW.OptionsColumn.ReadOnly = True
        Me.GCol_2_DPLA_AUTO_PREVIEW.Visible = True
        Me.GCol_2_DPLA_AUTO_PREVIEW.VisibleIndex = 0
        '
        'GCol_2_PC_ACT_ETAT_P
        '
        Me.GCol_2_PC_ACT_ETAT_P.Caption = "% actions planifiées"
        Me.GCol_2_PC_ACT_ETAT_P.DisplayFormat.FormatString = "{0:n2 %}"
        Me.GCol_2_PC_ACT_ETAT_P.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GCol_2_PC_ACT_ETAT_P.FieldName = "PC_ACT_ETAT_P"
        Me.GCol_2_PC_ACT_ETAT_P.Name = "GCol_2_PC_ACT_ETAT_P"
        Me.GCol_2_PC_ACT_ETAT_P.OptionsColumn.AllowEdit = False
        Me.GCol_2_PC_ACT_ETAT_P.OptionsColumn.ReadOnly = True
        Me.GCol_2_PC_ACT_ETAT_P.Visible = True
        Me.GCol_2_PC_ACT_ETAT_P.VisibleIndex = 1
        '
        'GCol_2_PC_ACT_ETAT_S
        '
        Me.GCol_2_PC_ACT_ETAT_S.Caption = "% actions non planifiées"
        Me.GCol_2_PC_ACT_ETAT_S.FieldName = "PC_ACT_ETAT_S"
        Me.GCol_2_PC_ACT_ETAT_S.Name = "GCol_2_PC_ACT_ETAT_S"
        Me.GCol_2_PC_ACT_ETAT_S.OptionsColumn.AllowEdit = False
        Me.GCol_2_PC_ACT_ETAT_S.OptionsColumn.ReadOnly = True
        Me.GCol_2_PC_ACT_ETAT_S.Visible = True
        Me.GCol_2_PC_ACT_ETAT_S.VisibleIndex = 2
        '
        'GCol_2_TOT_ACT_ETAT_P
        '
        Me.GCol_2_TOT_ACT_ETAT_P.Caption = "Nb Actions planifiées"
        Me.GCol_2_TOT_ACT_ETAT_P.DisplayFormat.FormatString = "n0"
        Me.GCol_2_TOT_ACT_ETAT_P.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GCol_2_TOT_ACT_ETAT_P.FieldName = "TOT_ACT_ETAT_P"
        Me.GCol_2_TOT_ACT_ETAT_P.Name = "GCol_2_TOT_ACT_ETAT_P"
        Me.GCol_2_TOT_ACT_ETAT_P.OptionsColumn.AllowEdit = False
        Me.GCol_2_TOT_ACT_ETAT_P.OptionsColumn.ReadOnly = True
        Me.GCol_2_TOT_ACT_ETAT_P.Visible = True
        Me.GCol_2_TOT_ACT_ETAT_P.VisibleIndex = 3
        '
        'GCol_2_TOT_ACT_ETAT_S
        '
        Me.GCol_2_TOT_ACT_ETAT_S.Caption = "Nb Actions non planifiées"
        Me.GCol_2_TOT_ACT_ETAT_S.DisplayFormat.FormatString = "n0"
        Me.GCol_2_TOT_ACT_ETAT_S.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GCol_2_TOT_ACT_ETAT_S.FieldName = "TOT_ACT_ETAT_S"
        Me.GCol_2_TOT_ACT_ETAT_S.Name = "GCol_2_TOT_ACT_ETAT_S"
        Me.GCol_2_TOT_ACT_ETAT_S.OptionsColumn.AllowEdit = False
        Me.GCol_2_TOT_ACT_ETAT_S.OptionsColumn.ReadOnly = True
        Me.GCol_2_TOT_ACT_ETAT_S.Visible = True
        Me.GCol_2_TOT_ACT_ETAT_S.VisibleIndex = 4
        '
        'GCol_2_TOT_ACT
        '
        Me.GCol_2_TOT_ACT.Caption = "Nb Total d'actions"
        Me.GCol_2_TOT_ACT.DisplayFormat.FormatString = "n0"
        Me.GCol_2_TOT_ACT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GCol_2_TOT_ACT.FieldName = "TOT_ACT"
        Me.GCol_2_TOT_ACT.Name = "GCol_2_TOT_ACT"
        Me.GCol_2_TOT_ACT.OptionsColumn.AllowEdit = False
        Me.GCol_2_TOT_ACT.OptionsColumn.ReadOnly = True
        Me.GCol_2_TOT_ACT.Visible = True
        Me.GCol_2_TOT_ACT.VisibleIndex = 5
        '
        'GCol_2_BREADYTOPLANIF
        '
        Me.GCol_2_BREADYTOPLANIF.Caption = "Valider pour planification"
        Me.GCol_2_BREADYTOPLANIF.ColumnEdit = Me.RepItemChk_BREADYTOPLANIF
        Me.GCol_2_BREADYTOPLANIF.FieldName = "BREADYTOPLANIF"
        Me.GCol_2_BREADYTOPLANIF.Name = "GCol_2_BREADYTOPLANIF"
        Me.GCol_2_BREADYTOPLANIF.Visible = True
        Me.GCol_2_BREADYTOPLANIF.VisibleIndex = 6
        '
        'RepItemChk_BREADYTOPLANIF
        '
        Me.RepItemChk_BREADYTOPLANIF.AutoHeight = False
        Me.RepItemChk_BREADYTOPLANIF.Name = "RepItemChk_BREADYTOPLANIF"
        Me.RepItemChk_BREADYTOPLANIF.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'GCPLANIFAUTO
        '
        GridLevelNode1.LevelTemplate = Me.GVListePreviewByPlaAuto
        GridLevelNode2.LevelTemplate = Me.GVListePreviewByAction
        GridLevelNode2.RelationName = "LvlResultPreview"
        GridLevelNode3.LevelTemplate = Me.GVListeResultPlanifByAction
        GridLevelNode3.RelationName = "LvlResultPlanif"
        GridLevelNode1.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2, GridLevelNode3})
        GridLevelNode1.RelationName = "PREVIEWs"
        Me.GCPLANIFAUTO.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GCPLANIFAUTO.Location = New System.Drawing.Point(141, 45)
        Me.GCPLANIFAUTO.MainView = Me.GVPLANIFAUTO
        Me.GCPLANIFAUTO.Name = "GCPLANIFAUTO"
        Me.GCPLANIFAUTO.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChk_BREADYTOPLANIF, Me.RepositoryItemCheckEdit_NCOCHE})
        Me.GCPLANIFAUTO.Size = New System.Drawing.Size(1447, 711)
        Me.GCPLANIFAUTO.TabIndex = 8
        Me.GCPLANIFAUTO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPLANIFAUTO, Me.GVListePreviewByAction, Me.GVListeResultPlanifByAction, Me.GVListePreviewByPlaAuto})
        '
        'GVPLANIFAUTO
        '
        Me.GVPLANIFAUTO.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVPLANIFAUTO.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVPLANIFAUTO.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVPLANIFAUTO.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVPLANIFAUTO.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVPLANIFAUTO.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVPLANIFAUTO.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVPLANIFAUTO.Appearance.Empty.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVPLANIFAUTO.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVPLANIFAUTO.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVPLANIFAUTO.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVPLANIFAUTO.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVPLANIFAUTO.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVPLANIFAUTO.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVPLANIFAUTO.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVPLANIFAUTO.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVPLANIFAUTO.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVPLANIFAUTO.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVPLANIFAUTO.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVPLANIFAUTO.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVPLANIFAUTO.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVPLANIFAUTO.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVPLANIFAUTO.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVPLANIFAUTO.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVPLANIFAUTO.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVPLANIFAUTO.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVPLANIFAUTO.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVPLANIFAUTO.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVPLANIFAUTO.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVPLANIFAUTO.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVPLANIFAUTO.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVPLANIFAUTO.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVPLANIFAUTO.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVPLANIFAUTO.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVPLANIFAUTO.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVPLANIFAUTO.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GVPLANIFAUTO.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVPLANIFAUTO.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVPLANIFAUTO.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVPLANIFAUTO.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVPLANIFAUTO.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVPLANIFAUTO.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVPLANIFAUTO.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVPLANIFAUTO.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVPLANIFAUTO.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVPLANIFAUTO.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVPLANIFAUTO.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVPLANIFAUTO.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVPLANIFAUTO.Appearance.OddRow.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVPLANIFAUTO.Appearance.OddRow.Options.UseForeColor = True
        Me.GVPLANIFAUTO.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVPLANIFAUTO.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.Preview.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.Preview.Options.UseFont = True
        Me.GVPLANIFAUTO.Appearance.Preview.Options.UseForeColor = True
        Me.GVPLANIFAUTO.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVPLANIFAUTO.Appearance.Row.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.Row.Options.UseForeColor = True
        Me.GVPLANIFAUTO.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVPLANIFAUTO.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVPLANIFAUTO.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GVPLANIFAUTO.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVPLANIFAUTO.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVPLANIFAUTO.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVPLANIFAUTO.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVPLANIFAUTO.Appearance.VertLine.Options.UseBackColor = True
        Me.GVPLANIFAUTO.ColumnPanelRowHeight = 50
        Me.GVPLANIFAUTO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNPLA_AUTO_ID, Me.GColVPERIODE, Me.GColVJOUR_FORBIDEN, Me.GColVTECH_MODE, Me.GColVBLOC_PAVE, Me.GColDDATECREE, Me.GColDDATEMOD, Me.GColVQUICREE, Me.GColVQUIMOD, Me.GColDDATE_TRAITEMENT, Me.GColCPLA_AUTO_ETAT, Me.GColVPLA_AUTO_ETAT})
        Me.GVPLANIFAUTO.GridControl = Me.GCPLANIFAUTO
        Me.GVPLANIFAUTO.Name = "GVPLANIFAUTO"
        Me.GVPLANIFAUTO.OptionsBehavior.Editable = False
        Me.GVPLANIFAUTO.OptionsNavigation.AutoFocusNewRow = True
        Me.GVPLANIFAUTO.OptionsView.EnableAppearanceOddRow = True
        Me.GVPLANIFAUTO.OptionsView.ShowAutoFilterRow = True
        Me.GVPLANIFAUTO.OptionsView.ShowFooter = True
        Me.GVPLANIFAUTO.OptionsView.ShowGroupPanel = False
        Me.GVPLANIFAUTO.RowHeight = 20
        '
        'ColNPLA_AUTO_ID
        '
        Me.ColNPLA_AUTO_ID.Caption = "N°"
        Me.ColNPLA_AUTO_ID.FieldName = "NPLA_AUTO_ID"
        Me.ColNPLA_AUTO_ID.Name = "ColNPLA_AUTO_ID"
        Me.ColNPLA_AUTO_ID.Visible = True
        Me.ColNPLA_AUTO_ID.VisibleIndex = 0
        '
        'GColVPERIODE
        '
        Me.GColVPERIODE.Caption = "Période"
        Me.GColVPERIODE.FieldName = "VPERIODE"
        Me.GColVPERIODE.Name = "GColVPERIODE"
        Me.GColVPERIODE.OptionsColumn.AllowEdit = False
        Me.GColVPERIODE.OptionsColumn.ReadOnly = True
        Me.GColVPERIODE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVPERIODE.Visible = True
        Me.GColVPERIODE.VisibleIndex = 1
        Me.GColVPERIODE.Width = 350
        '
        'GColVJOUR_FORBIDEN
        '
        Me.GColVJOUR_FORBIDEN.Caption = "Journée interdites"
        Me.GColVJOUR_FORBIDEN.FieldName = "VJOUR_FORBIDEN"
        Me.GColVJOUR_FORBIDEN.Name = "GColVJOUR_FORBIDEN"
        Me.GColVJOUR_FORBIDEN.OptionsColumn.AllowEdit = False
        Me.GColVJOUR_FORBIDEN.OptionsColumn.ReadOnly = True
        Me.GColVJOUR_FORBIDEN.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVJOUR_FORBIDEN.Visible = True
        Me.GColVJOUR_FORBIDEN.VisibleIndex = 2
        Me.GColVJOUR_FORBIDEN.Width = 80
        '
        'GColVTECH_MODE
        '
        Me.GColVTECH_MODE.Caption = "Choix technicien"
        Me.GColVTECH_MODE.FieldName = "VTECH_MODE"
        Me.GColVTECH_MODE.Name = "GColVTECH_MODE"
        Me.GColVTECH_MODE.OptionsColumn.AllowEdit = False
        Me.GColVTECH_MODE.OptionsColumn.ReadOnly = True
        Me.GColVTECH_MODE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVTECH_MODE.Visible = True
        Me.GColVTECH_MODE.VisibleIndex = 3
        Me.GColVTECH_MODE.Width = 280
        '
        'GColVBLOC_PAVE
        '
        Me.GColVBLOC_PAVE.Caption = "Blocage pavé"
        Me.GColVBLOC_PAVE.FieldName = "VBLOC_PAVE"
        Me.GColVBLOC_PAVE.Name = "GColVBLOC_PAVE"
        Me.GColVBLOC_PAVE.OptionsColumn.AllowEdit = False
        Me.GColVBLOC_PAVE.OptionsColumn.ReadOnly = True
        Me.GColVBLOC_PAVE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVBLOC_PAVE.Visible = True
        Me.GColVBLOC_PAVE.VisibleIndex = 4
        Me.GColVBLOC_PAVE.Width = 108
        '
        'GColDDATECREE
        '
        Me.GColDDATECREE.Caption = "Date création demande"
        Me.GColDDATECREE.FieldName = "DDATECREE"
        Me.GColDDATECREE.Name = "GColDDATECREE"
        Me.GColDDATECREE.OptionsColumn.AllowEdit = False
        Me.GColDDATECREE.OptionsColumn.ReadOnly = True
        Me.GColDDATECREE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColDDATECREE.Visible = True
        Me.GColDDATECREE.VisibleIndex = 5
        Me.GColDDATECREE.Width = 108
        '
        'GColDDATEMOD
        '
        Me.GColDDATEMOD.Caption = "Date dernière modification"
        Me.GColDDATEMOD.FieldName = "DDATEMOD"
        Me.GColDDATEMOD.Name = "GColDDATEMOD"
        Me.GColDDATEMOD.OptionsColumn.AllowEdit = False
        Me.GColDDATEMOD.OptionsColumn.ReadOnly = True
        Me.GColDDATEMOD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColDDATEMOD.Visible = True
        Me.GColDDATEMOD.VisibleIndex = 6
        Me.GColDDATEMOD.Width = 108
        '
        'GColVQUICREE
        '
        Me.GColVQUICREE.Caption = "Créateur"
        Me.GColVQUICREE.FieldName = "VQUICREE"
        Me.GColVQUICREE.Name = "GColVQUICREE"
        Me.GColVQUICREE.OptionsColumn.AllowEdit = False
        Me.GColVQUICREE.OptionsColumn.ReadOnly = True
        Me.GColVQUICREE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVQUICREE.Visible = True
        Me.GColVQUICREE.VisibleIndex = 7
        Me.GColVQUICREE.Width = 108
        '
        'GColVQUIMOD
        '
        Me.GColVQUIMOD.Caption = "Dernier modificateur"
        Me.GColVQUIMOD.FieldName = "VQUIMOD"
        Me.GColVQUIMOD.Name = "GColVQUIMOD"
        Me.GColVQUIMOD.OptionsColumn.AllowEdit = False
        Me.GColVQUIMOD.OptionsColumn.ReadOnly = True
        Me.GColVQUIMOD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVQUIMOD.Visible = True
        Me.GColVQUIMOD.VisibleIndex = 8
        Me.GColVQUIMOD.Width = 108
        '
        'GColDDATE_TRAITEMENT
        '
        Me.GColDDATE_TRAITEMENT.Caption = "Date traitement"
        Me.GColDDATE_TRAITEMENT.FieldName = "DDATE_TRAITEMENT"
        Me.GColDDATE_TRAITEMENT.Name = "GColDDATE_TRAITEMENT"
        Me.GColDDATE_TRAITEMENT.OptionsColumn.AllowEdit = False
        Me.GColDDATE_TRAITEMENT.OptionsColumn.ReadOnly = True
        Me.GColDDATE_TRAITEMENT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColCPLA_AUTO_ETAT
        '
        Me.GColCPLA_AUTO_ETAT.Caption = "CPLA_AUTO_ETAT"
        Me.GColCPLA_AUTO_ETAT.FieldName = "CPLA_AUTO_ETAT"
        Me.GColCPLA_AUTO_ETAT.Name = "GColCPLA_AUTO_ETAT"
        '
        'GColVPLA_AUTO_ETAT
        '
        Me.GColVPLA_AUTO_ETAT.Caption = "Etat demande"
        Me.GColVPLA_AUTO_ETAT.FieldName = "VPLA_AUTO_ETAT"
        Me.GColVPLA_AUTO_ETAT.Name = "GColVPLA_AUTO_ETAT"
        Me.GColVPLA_AUTO_ETAT.OptionsColumn.AllowEdit = False
        Me.GColVPLA_AUTO_ETAT.OptionsColumn.ReadOnly = True
        Me.GColVPLA_AUTO_ETAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVPLA_AUTO_ETAT.Visible = True
        Me.GColVPLA_AUTO_ETAT.VisibleIndex = 9
        Me.GColVPLA_AUTO_ETAT.Width = 127
        '
        'RepositoryItemCheckEdit_NCOCHE
        '
        Me.RepositoryItemCheckEdit_NCOCHE.AutoHeight = False
        Me.RepositoryItemCheckEdit_NCOCHE.Name = "RepositoryItemCheckEdit_NCOCHE"
        Me.RepositoryItemCheckEdit_NCOCHE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit_NCOCHE.ValueChecked = CType(1, Byte)
        Me.RepositoryItemCheckEdit_NCOCHE.ValueUnchecked = CType(0, Byte)
        '
        'GVListePreviewByAction
        '
        Me.GVListePreviewByAction.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListePreviewByAction.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListePreviewByAction.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListePreviewByAction.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListePreviewByAction.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListePreviewByAction.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListePreviewByAction.Appearance.ViewCaption.BackColor = System.Drawing.Color.Azure
        Me.GVListePreviewByAction.Appearance.ViewCaption.Options.UseBackColor = True
        Me.GVListePreviewByAction.ColumnPanelRowHeight = 50
        Me.GVListePreviewByAction.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNCOCHE, Me.GCol_3_NPLA_AUTO_ACT_ID_PREVIEW, Me.GCol_3_NPLA_AUTO_ID_PREVIEW, Me.GCol_3_NPLA_AUTO_ACT_ID, Me.GCol_3_VCLINOM, Me.GCol_3_VSITNOM, Me.GCol_3_VTYPECONTRAT, Me.GCol_3_NDINNUM, Me.GCol_3_DACTDAT, Me.GCol_3_VACTDES, Me.GCol_3_NACTDUR, Me.GCol_3_NDUREE_J, Me.GCol_3_VPERNOM, Me.GCol_3_DACTPLA, Me.GCol_3_NCODE_ERROR, Me.GCol_3_VPLA_AUTO_ACT_LOG, Me.GCol_3_CETAT_ACT_PLA_AUTO})
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Column = Me.GCol_3_CETAT_ACT_PLA_AUTO
        GridFormatRule2.Name = "Format0"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.Lime
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue2.Expression = "[CETAT_ACT_PLA_AUTO] = 'P' And IsNull([NCODE_ERROR], 0) = 0"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        GridFormatRule3.ApplyToRow = True
        GridFormatRule3.Column = Me.GCol_3_CETAT_ACT_PLA_AUTO
        GridFormatRule3.Name = "Format1"
        FormatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.Red
        FormatConditionRuleValue3.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue3.Expression = "[CETAT_ACT_PLA_AUTO] = 'S'"
        GridFormatRule3.Rule = FormatConditionRuleValue3
        GridFormatRule4.ApplyToRow = True
        GridFormatRule4.Column = Me.GCol_3_CETAT_ACT_PLA_AUTO
        GridFormatRule4.Name = "Format2"
        FormatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.Orange
        FormatConditionRuleValue4.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue4.Expression = "[CETAT_ACT_PLA_AUTO] = 'P' And [NCODE_ERROR] > 0"
        GridFormatRule4.Rule = FormatConditionRuleValue4
        Me.GVListePreviewByAction.FormatRules.Add(GridFormatRule2)
        Me.GVListePreviewByAction.FormatRules.Add(GridFormatRule3)
        Me.GVListePreviewByAction.FormatRules.Add(GridFormatRule4)
        Me.GVListePreviewByAction.GridControl = Me.GCPLANIFAUTO
        Me.GVListePreviewByAction.Name = "GVListePreviewByAction"
        Me.GVListePreviewByAction.OptionsView.ShowGroupPanel = False
        Me.GVListePreviewByAction.ViewCaption = "Liste des actions"
        '
        'GColNCOCHE
        '
        Me.GColNCOCHE.Caption = "Sélection"
        Me.GColNCOCHE.FieldName = "NCOCHE"
        Me.GColNCOCHE.Name = "GColNCOCHE"
        Me.GColNCOCHE.Width = 78
        '
        'GCol_3_NPLA_AUTO_ACT_ID_PREVIEW
        '
        Me.GCol_3_NPLA_AUTO_ACT_ID_PREVIEW.Caption = "NPLA_AUTO_ACT_ID_PREVIEW"
        Me.GCol_3_NPLA_AUTO_ACT_ID_PREVIEW.FieldName = "NPLA_AUTO_ACT_ID_PREVIEW"
        Me.GCol_3_NPLA_AUTO_ACT_ID_PREVIEW.Name = "GCol_3_NPLA_AUTO_ACT_ID_PREVIEW"
        '
        'GCol_3_NPLA_AUTO_ID_PREVIEW
        '
        Me.GCol_3_NPLA_AUTO_ID_PREVIEW.Caption = "NPLA_AUTO_ID_PREVIEW"
        Me.GCol_3_NPLA_AUTO_ID_PREVIEW.FieldName = "NPLA_AUTO_ID_PREVIEW"
        Me.GCol_3_NPLA_AUTO_ID_PREVIEW.Name = "GCol_3_NPLA_AUTO_ID_PREVIEW"
        '
        'GCol_3_NPLA_AUTO_ACT_ID
        '
        Me.GCol_3_NPLA_AUTO_ACT_ID.Caption = "NPLA_AUTO_ACT_ID"
        Me.GCol_3_NPLA_AUTO_ACT_ID.FieldName = "NPLA_AUTO_ACT_ID"
        Me.GCol_3_NPLA_AUTO_ACT_ID.Name = "GCol_3_NPLA_AUTO_ACT_ID"
        '
        'GCol_3_VCLINOM
        '
        Me.GCol_3_VCLINOM.Caption = "Client"
        Me.GCol_3_VCLINOM.FieldName = "VCLINOM"
        Me.GCol_3_VCLINOM.Name = "GCol_3_VCLINOM"
        Me.GCol_3_VCLINOM.OptionsColumn.AllowEdit = False
        Me.GCol_3_VCLINOM.OptionsColumn.ReadOnly = True
        Me.GCol_3_VCLINOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_3_VCLINOM.Visible = True
        Me.GCol_3_VCLINOM.VisibleIndex = 0
        Me.GCol_3_VCLINOM.Width = 134
        '
        'GCol_3_VSITNOM
        '
        Me.GCol_3_VSITNOM.Caption = "Site"
        Me.GCol_3_VSITNOM.FieldName = "VSITNOM"
        Me.GCol_3_VSITNOM.Name = "GCol_3_VSITNOM"
        Me.GCol_3_VSITNOM.OptionsColumn.AllowEdit = False
        Me.GCol_3_VSITNOM.OptionsColumn.ReadOnly = True
        Me.GCol_3_VSITNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_3_VSITNOM.Visible = True
        Me.GCol_3_VSITNOM.VisibleIndex = 1
        Me.GCol_3_VSITNOM.Width = 134
        '
        'GCol_3_VTYPECONTRAT
        '
        Me.GCol_3_VTYPECONTRAT.Caption = "Contrat"
        Me.GCol_3_VTYPECONTRAT.FieldName = "VTYPECONTRAT"
        Me.GCol_3_VTYPECONTRAT.Name = "GCol_3_VTYPECONTRAT"
        Me.GCol_3_VTYPECONTRAT.OptionsColumn.AllowEdit = False
        Me.GCol_3_VTYPECONTRAT.OptionsColumn.ReadOnly = True
        Me.GCol_3_VTYPECONTRAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_3_VTYPECONTRAT.Visible = True
        Me.GCol_3_VTYPECONTRAT.VisibleIndex = 2
        Me.GCol_3_VTYPECONTRAT.Width = 143
        '
        'GCol_3_NDINNUM
        '
        Me.GCol_3_NDINNUM.Caption = "N° DI"
        Me.GCol_3_NDINNUM.FieldName = "NDINNUM"
        Me.GCol_3_NDINNUM.Name = "GCol_3_NDINNUM"
        Me.GCol_3_NDINNUM.OptionsColumn.AllowEdit = False
        Me.GCol_3_NDINNUM.OptionsColumn.ReadOnly = True
        Me.GCol_3_NDINNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_3_NDINNUM.Visible = True
        Me.GCol_3_NDINNUM.VisibleIndex = 3
        Me.GCol_3_NDINNUM.Width = 73
        '
        'GCol_3_DACTDAT
        '
        Me.GCol_3_DACTDAT.Caption = "Date souhaitée"
        Me.GCol_3_DACTDAT.FieldName = "DACTDAT"
        Me.GCol_3_DACTDAT.Name = "GCol_3_DACTDAT"
        Me.GCol_3_DACTDAT.OptionsColumn.AllowEdit = False
        Me.GCol_3_DACTDAT.OptionsColumn.ReadOnly = True
        Me.GCol_3_DACTDAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_3_DACTDAT.Visible = True
        Me.GCol_3_DACTDAT.VisibleIndex = 4
        Me.GCol_3_DACTDAT.Width = 78
        '
        'GCol_3_VACTDES
        '
        Me.GCol_3_VACTDES.Caption = "Action"
        Me.GCol_3_VACTDES.FieldName = "VACTDES"
        Me.GCol_3_VACTDES.Name = "GCol_3_VACTDES"
        Me.GCol_3_VACTDES.OptionsColumn.AllowEdit = False
        Me.GCol_3_VACTDES.OptionsColumn.ReadOnly = True
        Me.GCol_3_VACTDES.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_3_VACTDES.Visible = True
        Me.GCol_3_VACTDES.VisibleIndex = 5
        Me.GCol_3_VACTDES.Width = 265
        '
        'GCol_3_NACTDUR
        '
        Me.GCol_3_NACTDUR.Caption = "Durée action"
        Me.GCol_3_NACTDUR.FieldName = "NACTDUR"
        Me.GCol_3_NACTDUR.Name = "GCol_3_NACTDUR"
        Me.GCol_3_NACTDUR.OptionsColumn.AllowEdit = False
        Me.GCol_3_NACTDUR.OptionsColumn.ReadOnly = True
        Me.GCol_3_NACTDUR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_3_NACTDUR.Visible = True
        Me.GCol_3_NACTDUR.VisibleIndex = 6
        Me.GCol_3_NACTDUR.Width = 67
        '
        'GCol_3_NDUREE_J
        '
        Me.GCol_3_NDUREE_J.Caption = "Nb Heures déjà planifié sur le technicien"
        Me.GCol_3_NDUREE_J.FieldName = "NDUREE_J"
        Me.GCol_3_NDUREE_J.Name = "GCol_3_NDUREE_J"
        Me.GCol_3_NDUREE_J.OptionsColumn.AllowEdit = False
        Me.GCol_3_NDUREE_J.OptionsColumn.ReadOnly = True
        Me.GCol_3_NDUREE_J.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_3_NDUREE_J.Visible = True
        Me.GCol_3_NDUREE_J.VisibleIndex = 7
        Me.GCol_3_NDUREE_J.Width = 115
        '
        'GCol_3_VPERNOM
        '
        Me.GCol_3_VPERNOM.Caption = "Technicien"
        Me.GCol_3_VPERNOM.FieldName = "VPERNOM"
        Me.GCol_3_VPERNOM.Name = "GCol_3_VPERNOM"
        Me.GCol_3_VPERNOM.OptionsColumn.AllowEdit = False
        Me.GCol_3_VPERNOM.OptionsColumn.ReadOnly = True
        Me.GCol_3_VPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_3_VPERNOM.Visible = True
        Me.GCol_3_VPERNOM.VisibleIndex = 8
        Me.GCol_3_VPERNOM.Width = 150
        '
        'GCol_3_DACTPLA
        '
        Me.GCol_3_DACTPLA.Caption = "Date planification"
        Me.GCol_3_DACTPLA.FieldName = "DACTPLA"
        Me.GCol_3_DACTPLA.Name = "GCol_3_DACTPLA"
        Me.GCol_3_DACTPLA.OptionsColumn.AllowEdit = False
        Me.GCol_3_DACTPLA.OptionsColumn.ReadOnly = True
        Me.GCol_3_DACTPLA.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_3_DACTPLA.Visible = True
        Me.GCol_3_DACTPLA.VisibleIndex = 9
        Me.GCol_3_DACTPLA.Width = 99
        '
        'GCol_3_NCODE_ERROR
        '
        Me.GCol_3_NCODE_ERROR.Caption = "Code Erreur"
        Me.GCol_3_NCODE_ERROR.FieldName = "NCODE_ERROR"
        Me.GCol_3_NCODE_ERROR.Name = "GCol_3_NCODE_ERROR"
        Me.GCol_3_NCODE_ERROR.OptionsColumn.AllowEdit = False
        Me.GCol_3_NCODE_ERROR.OptionsColumn.ReadOnly = True
        Me.GCol_3_NCODE_ERROR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_3_NCODE_ERROR.Visible = True
        Me.GCol_3_NCODE_ERROR.VisibleIndex = 10
        Me.GCol_3_NCODE_ERROR.Width = 67
        '
        'GCol_3_VPLA_AUTO_ACT_LOG
        '
        Me.GCol_3_VPLA_AUTO_ACT_LOG.Caption = "Log"
        Me.GCol_3_VPLA_AUTO_ACT_LOG.FieldName = "VPLA_AUTO_ACT_LOG"
        Me.GCol_3_VPLA_AUTO_ACT_LOG.Name = "GCol_3_VPLA_AUTO_ACT_LOG"
        Me.GCol_3_VPLA_AUTO_ACT_LOG.OptionsColumn.AllowEdit = False
        Me.GCol_3_VPLA_AUTO_ACT_LOG.OptionsColumn.ReadOnly = True
        Me.GCol_3_VPLA_AUTO_ACT_LOG.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_3_VPLA_AUTO_ACT_LOG.Visible = True
        Me.GCol_3_VPLA_AUTO_ACT_LOG.VisibleIndex = 11
        Me.GCol_3_VPLA_AUTO_ACT_LOG.Width = 52
        '
        'GCol_3_CETAT_ACT_PLA_AUTO
        '
        Me.GCol_3_CETAT_ACT_PLA_AUTO.Caption = "CETAT_ACT_PLA_AUTO"
        Me.GCol_3_CETAT_ACT_PLA_AUTO.FieldName = "CETAT_ACT_PLA_AUTO"
        Me.GCol_3_CETAT_ACT_PLA_AUTO.Name = "GCol_3_CETAT_ACT_PLA_AUTO"
        '
        'GVListeResultPlanifByAction
        '
        Me.GVListeResultPlanifByAction.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListeResultPlanifByAction.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeResultPlanifByAction.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeResultPlanifByAction.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeResultPlanifByAction.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeResultPlanifByAction.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListeResultPlanifByAction.ColumnPanelRowHeight = 40
        Me.GVListeResultPlanifByAction.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_4_NACTNUM, Me.GCol_4_NIPLNUM, Me.GCol_4_VCLINOM, Me.GCol_4_VSITNOM, Me.GCol_4_NDINNUM, Me.GCol_4_DACTDAT, Me.GCol_4_VACTDES, Me.GCol_4_NACTDUR, Me.GCol_4_CETACOD, Me.GCol_4_VPERNOM, Me.GCol_4_DACTPLA, Me.GCol_4_DACTPLA_PREVIEW, Me.GCol_4_NCODE_ERROR, Me.GridColumn1})
        GridFormatRule5.ApplyToRow = True
        GridFormatRule5.Column = Me.GCol_4_DACTPLA
        GridFormatRule5.Name = "Format0"
        FormatConditionRuleValue5.Appearance.BackColor = System.Drawing.Color.Orange
        FormatConditionRuleValue5.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue5.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue5.Expression = "[DACTPLA] <> [DACTPLA_PREVIEW]"
        GridFormatRule5.Rule = FormatConditionRuleValue5
        Me.GVListeResultPlanifByAction.FormatRules.Add(GridFormatRule5)
        Me.GVListeResultPlanifByAction.GridControl = Me.GCPLANIFAUTO
        Me.GVListeResultPlanifByAction.Name = "GVListeResultPlanifByAction"
        Me.GVListeResultPlanifByAction.OptionsView.ShowGroupPanel = False
        Me.GVListeResultPlanifByAction.OptionsView.ShowViewCaption = True
        Me.GVListeResultPlanifByAction.ViewCaption = "Résultat de la planification"
        '
        'GCol_4_NACTNUM
        '
        Me.GCol_4_NACTNUM.Caption = "NACTNUM"
        Me.GCol_4_NACTNUM.FieldName = "NACTNUM"
        Me.GCol_4_NACTNUM.Name = "GCol_4_NACTNUM"
        '
        'GCol_4_NIPLNUM
        '
        Me.GCol_4_NIPLNUM.Caption = "NIPLNUM"
        Me.GCol_4_NIPLNUM.FieldName = "NIPLNUM"
        Me.GCol_4_NIPLNUM.Name = "GCol_4_NIPLNUM"
        '
        'GCol_4_VCLINOM
        '
        Me.GCol_4_VCLINOM.Caption = "Client"
        Me.GCol_4_VCLINOM.FieldName = "VCLINOM"
        Me.GCol_4_VCLINOM.Name = "GCol_4_VCLINOM"
        Me.GCol_4_VCLINOM.OptionsColumn.AllowEdit = False
        Me.GCol_4_VCLINOM.OptionsColumn.ReadOnly = True
        Me.GCol_4_VCLINOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_4_VCLINOM.Visible = True
        Me.GCol_4_VCLINOM.VisibleIndex = 0
        Me.GCol_4_VCLINOM.Width = 212
        '
        'GCol_4_VSITNOM
        '
        Me.GCol_4_VSITNOM.Caption = "Site"
        Me.GCol_4_VSITNOM.FieldName = "VSITNOM"
        Me.GCol_4_VSITNOM.Name = "GCol_4_VSITNOM"
        Me.GCol_4_VSITNOM.OptionsColumn.AllowEdit = False
        Me.GCol_4_VSITNOM.OptionsColumn.ReadOnly = True
        Me.GCol_4_VSITNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_4_VSITNOM.Visible = True
        Me.GCol_4_VSITNOM.VisibleIndex = 1
        Me.GCol_4_VSITNOM.Width = 204
        '
        'GCol_4_NDINNUM
        '
        Me.GCol_4_NDINNUM.Caption = "N° DI"
        Me.GCol_4_NDINNUM.FieldName = "NDINNUM"
        Me.GCol_4_NDINNUM.Name = "GCol_4_NDINNUM"
        Me.GCol_4_NDINNUM.OptionsColumn.AllowEdit = False
        Me.GCol_4_NDINNUM.OptionsColumn.ReadOnly = True
        Me.GCol_4_NDINNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_4_NDINNUM.Visible = True
        Me.GCol_4_NDINNUM.VisibleIndex = 2
        Me.GCol_4_NDINNUM.Width = 80
        '
        'GCol_4_DACTDAT
        '
        Me.GCol_4_DACTDAT.Caption = "Date souhaitée de l'action"
        Me.GCol_4_DACTDAT.DisplayFormat.FormatString = "d"
        Me.GCol_4_DACTDAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GCol_4_DACTDAT.FieldName = "DACTDAT"
        Me.GCol_4_DACTDAT.Name = "GCol_4_DACTDAT"
        Me.GCol_4_DACTDAT.OptionsColumn.AllowEdit = False
        Me.GCol_4_DACTDAT.OptionsColumn.ReadOnly = True
        Me.GCol_4_DACTDAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_4_DACTDAT.Visible = True
        Me.GCol_4_DACTDAT.VisibleIndex = 3
        Me.GCol_4_DACTDAT.Width = 99
        '
        'GCol_4_VACTDES
        '
        Me.GCol_4_VACTDES.Caption = "Action"
        Me.GCol_4_VACTDES.FieldName = "VACTDES"
        Me.GCol_4_VACTDES.Name = "GCol_4_VACTDES"
        Me.GCol_4_VACTDES.OptionsColumn.AllowEdit = False
        Me.GCol_4_VACTDES.OptionsColumn.ReadOnly = True
        Me.GCol_4_VACTDES.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_4_VACTDES.Visible = True
        Me.GCol_4_VACTDES.VisibleIndex = 4
        Me.GCol_4_VACTDES.Width = 353
        '
        'GCol_4_NACTDUR
        '
        Me.GCol_4_NACTDUR.Caption = "Durée action"
        Me.GCol_4_NACTDUR.FieldName = "NACTDUR"
        Me.GCol_4_NACTDUR.Name = "GCol_4_NACTDUR"
        Me.GCol_4_NACTDUR.OptionsColumn.AllowEdit = False
        Me.GCol_4_NACTDUR.OptionsColumn.ReadOnly = True
        Me.GCol_4_NACTDUR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_4_NACTDUR.Visible = True
        Me.GCol_4_NACTDUR.VisibleIndex = 5
        Me.GCol_4_NACTDUR.Width = 52
        '
        'GCol_4_CETACOD
        '
        Me.GCol_4_CETACOD.Caption = "Etat action"
        Me.GCol_4_CETACOD.FieldName = "CETACOD"
        Me.GCol_4_CETACOD.Name = "GCol_4_CETACOD"
        Me.GCol_4_CETACOD.OptionsColumn.AllowEdit = False
        Me.GCol_4_CETACOD.OptionsColumn.ReadOnly = True
        Me.GCol_4_CETACOD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_4_CETACOD.Visible = True
        Me.GCol_4_CETACOD.VisibleIndex = 6
        Me.GCol_4_CETACOD.Width = 44
        '
        'GCol_4_VPERNOM
        '
        Me.GCol_4_VPERNOM.Caption = "Technicien"
        Me.GCol_4_VPERNOM.FieldName = "VPERNOM"
        Me.GCol_4_VPERNOM.Name = "GCol_4_VPERNOM"
        Me.GCol_4_VPERNOM.OptionsColumn.AllowEdit = False
        Me.GCol_4_VPERNOM.OptionsColumn.ReadOnly = True
        Me.GCol_4_VPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_4_VPERNOM.Visible = True
        Me.GCol_4_VPERNOM.VisibleIndex = 7
        Me.GCol_4_VPERNOM.Width = 91
        '
        'GCol_4_DACTPLA
        '
        Me.GCol_4_DACTPLA.Caption = "Date planification de l'action"
        Me.GCol_4_DACTPLA.DisplayFormat.FormatString = "d"
        Me.GCol_4_DACTPLA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GCol_4_DACTPLA.FieldName = "DACTPLA"
        Me.GCol_4_DACTPLA.Name = "GCol_4_DACTPLA"
        Me.GCol_4_DACTPLA.OptionsColumn.AllowEdit = False
        Me.GCol_4_DACTPLA.OptionsColumn.ReadOnly = True
        Me.GCol_4_DACTPLA.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_4_DACTPLA.Visible = True
        Me.GCol_4_DACTPLA.VisibleIndex = 8
        Me.GCol_4_DACTPLA.Width = 108
        '
        'GCol_4_DACTPLA_PREVIEW
        '
        Me.GCol_4_DACTPLA_PREVIEW.Caption = "Date planification de la preview"
        Me.GCol_4_DACTPLA_PREVIEW.DisplayFormat.FormatString = "d"
        Me.GCol_4_DACTPLA_PREVIEW.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GCol_4_DACTPLA_PREVIEW.FieldName = "DACTPLA_PREVIEW"
        Me.GCol_4_DACTPLA_PREVIEW.Name = "GCol_4_DACTPLA_PREVIEW"
        Me.GCol_4_DACTPLA_PREVIEW.OptionsColumn.AllowEdit = False
        Me.GCol_4_DACTPLA_PREVIEW.OptionsColumn.ReadOnly = True
        Me.GCol_4_DACTPLA_PREVIEW.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_4_DACTPLA_PREVIEW.Visible = True
        Me.GCol_4_DACTPLA_PREVIEW.VisibleIndex = 9
        Me.GCol_4_DACTPLA_PREVIEW.Width = 186
        '
        'GCol_4_NCODE_ERROR
        '
        Me.GCol_4_NCODE_ERROR.Caption = "Code Erreur"
        Me.GCol_4_NCODE_ERROR.FieldName = "NCODE_ERROR"
        Me.GCol_4_NCODE_ERROR.Name = "GCol_4_NCODE_ERROR"
        Me.GCol_4_NCODE_ERROR.OptionsColumn.AllowEdit = False
        Me.GCol_4_NCODE_ERROR.OptionsColumn.ReadOnly = True
        Me.GCol_4_NCODE_ERROR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_4_NCODE_ERROR.Visible = True
        Me.GCol_4_NCODE_ERROR.VisibleIndex = 10
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "NPLA_AUTO_ACT_ID_PREVIEW"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 11
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(141, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(993, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Liste des demandes de planifications automatiques en attente de traitement"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnChangeEtat)
        Me.GrpActions.Controls.Add(Me.BtnArchives)
        Me.GrpActions.Controls.Add(Me.BtnMod)
        Me.GrpActions.Controls.Add(Me.BtnSupprLine)
        Me.GrpActions.Controls.Add(Me.BtnAdd)
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Location = New System.Drawing.Point(12, 12)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(123, 744)
        Me.GrpActions.TabIndex = 9
        Me.GrpActions.TabStop = False
        '
        'BtnChangeEtat
        '
        Me.BtnChangeEtat.BackColor = System.Drawing.Color.Beige
        Me.BtnChangeEtat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnChangeEtat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnChangeEtat.Location = New System.Drawing.Point(6, 227)
        Me.BtnChangeEtat.Name = "BtnChangeEtat"
        Me.BtnChangeEtat.Size = New System.Drawing.Size(108, 50)
        Me.BtnChangeEtat.TabIndex = 12
        Me.BtnChangeEtat.Tag = ""
        Me.BtnChangeEtat.Text = "Changer Etat -> En Attente"
        Me.BtnChangeEtat.UseVisualStyleBackColor = False
        Me.BtnChangeEtat.Visible = False
        '
        'BtnArchives
        '
        Me.BtnArchives.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.BtnArchives.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnArchives.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnArchives.Location = New System.Drawing.Point(6, 390)
        Me.BtnArchives.Name = "BtnArchives"
        Me.BtnArchives.Size = New System.Drawing.Size(108, 45)
        Me.BtnArchives.TabIndex = 11
        Me.BtnArchives.Text = "Archives"
        Me.BtnArchives.UseVisualStyleBackColor = False
        '
        'BtnMod
        '
        Me.BtnMod.BackColor = System.Drawing.Color.LightGreen
        Me.BtnMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnMod.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnMod.Location = New System.Drawing.Point(6, 83)
        Me.BtnMod.Name = "BtnMod"
        Me.BtnMod.Size = New System.Drawing.Size(108, 44)
        Me.BtnMod.TabIndex = 6
        Me.BtnMod.Text = "Ouvrir"
        Me.BtnMod.UseVisualStyleBackColor = False
        '
        'BtnSupprLine
        '
        Me.BtnSupprLine.BackColor = System.Drawing.Color.LightGreen
        Me.BtnSupprLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnSupprLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSupprLine.Location = New System.Drawing.Point(6, 133)
        Me.BtnSupprLine.Name = "BtnSupprLine"
        Me.BtnSupprLine.Size = New System.Drawing.Size(108, 45)
        Me.BtnSupprLine.TabIndex = 3
        Me.BtnSupprLine.Text = "Archiver"
        Me.BtnSupprLine.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.LightGreen
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnAdd.Location = New System.Drawing.Point(6, 33)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(108, 44)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "Ajouter"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnQuit
        '
        Me.BtnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnQuit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnQuit.Location = New System.Drawing.Point(6, 682)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(108, 45)
        Me.BtnQuit.TabIndex = 1
        Me.BtnQuit.Text = "Fermer"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'frmPlanifAuto_Liste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 914)
        Me.Controls.Add(Me.GCPLANIFAUTO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmPlanifAuto_Liste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Liste des demandes de planifications automatiques en attente de traitement"
        CType(Me.GVListePreviewByPlaAuto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChk_BREADYTOPLANIF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPLANIFAUTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPLANIFAUTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit_NCOCHE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListePreviewByAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeResultPlanifByAction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents GCPLANIFAUTO As DevExpress.XtraGrid.GridControl
    Private WithEvents GVPLANIFAUTO As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColNPLA_AUTO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnArchives As Button
    Friend WithEvents BtnMod As Button
    Friend WithEvents BtnSupprLine As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnQuit As Button
    Friend WithEvents GColVPERIODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVJOUR_FORBIDEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVTECH_MODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVBLOC_PAVE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColDDATECREE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColDDATEMOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVQUICREE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVQUIMOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColDDATE_TRAITEMENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColCPLA_AUTO_ETAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVPLA_AUTO_ETAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnChangeEtat As Button
    Friend WithEvents GVListePreviewByPlaAuto As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCol_2_NPLA_AUTO_ID_PREVIEW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_2_DPLA_AUTO_PREVIEW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_2_PC_ACT_ETAT_P As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_2_PC_ACT_ETAT_S As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_2_TOT_ACT_ETAT_P As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_2_TOT_ACT_ETAT_S As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_2_TOT_ACT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_2_BREADYTOPLANIF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_2_NPLA_AUTO_ID_RESULT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemChk_BREADYTOPLANIF As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GVListePreviewByAction As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GColNCOCHE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_3_NPLA_AUTO_ACT_ID_PREVIEW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_3_NPLA_AUTO_ID_PREVIEW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_3_NPLA_AUTO_ACT_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_3_VCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_3_VSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_3_NDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_3_VTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_3_NCODE_ERROR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_3_DACTDAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_3_DACTPLA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_3_VPLA_AUTO_ACT_LOG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_3_VPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_3_CETAT_ACT_PLA_AUTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit_NCOCHE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GCol_3_VACTDES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_3_NACTDUR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_3_NDUREE_J As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVListeResultPlanifByAction As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCol_4_NACTNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_4_NIPLNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_4_VCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_4_VSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_4_NDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_4_DACTDAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_4_VACTDES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_4_NACTDUR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_4_CETACOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_4_VPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_4_DACTPLA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_4_DACTPLA_PREVIEW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_4_NCODE_ERROR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
