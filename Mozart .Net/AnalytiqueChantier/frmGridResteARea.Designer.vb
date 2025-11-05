<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGridResteARea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGridResteARea))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue4 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule5 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue5 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule6 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue6 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.GVDetail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColDetail_NIDFICHE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetail_NDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetail_NACTNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetail_VDINACT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemHyperLinkVDINACT = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GColDetail_NDETAILNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetail_DACTDEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetail_NREA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCResteARea = New DevExpress.XtraGrid.GridControl()
        Me.GVResteARea = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNIDFICHE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNVAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNREAH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNVALREA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNVALAJUSTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTOT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPOURC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVCOMMENTAIRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNIDANACHAFICTYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNVALOBJ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNDIFFOBJ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpGrid = New System.Windows.Forms.GroupBox()
        Me.BtnValider = New System.Windows.Forms.Button()
        Me.BtnExportXLS = New System.Windows.Forms.Button()
        Me.BtnExportPDF = New System.Windows.Forms.Button()
        Me.SDF = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.GVDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemHyperLinkVDINACT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCResteARea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVResteARea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'GVDetail
        '
        Me.GVDetail.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVDetail.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVDetail.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVDetail.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVDetail.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVDetail.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVDetail.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColDetail_NIDFICHE, Me.GColDetail_NDINNUM, Me.GColDetail_NACTNUM, Me.GColDetail_VDINACT, Me.GColDetail_NDETAILNUM, Me.GColDetail_DACTDEX, Me.GColDetail_NREA})
        Me.GVDetail.GridControl = Me.GCResteARea
        Me.GVDetail.Name = "GVDetail"
        Me.GVDetail.OptionsBehavior.Editable = False
        Me.GVDetail.OptionsBehavior.ReadOnly = True
        Me.GVDetail.OptionsView.ShowFooter = True
        Me.GVDetail.OptionsView.ShowGroupPanel = False
        '
        'GColDetail_NIDFICHE
        '
        resources.ApplyResources(Me.GColDetail_NIDFICHE, "GColDetail_NIDFICHE")
        Me.GColDetail_NIDFICHE.FieldName = "NIDFICHE"
        Me.GColDetail_NIDFICHE.Name = "GColDetail_NIDFICHE"
        '
        'GColDetail_NDINNUM
        '
        resources.ApplyResources(Me.GColDetail_NDINNUM, "GColDetail_NDINNUM")
        Me.GColDetail_NDINNUM.FieldName = "NDINNUM"
        Me.GColDetail_NDINNUM.Name = "GColDetail_NDINNUM"
        '
        'GColDetail_NACTNUM
        '
        resources.ApplyResources(Me.GColDetail_NACTNUM, "GColDetail_NACTNUM")
        Me.GColDetail_NACTNUM.FieldName = "NACTNUM"
        Me.GColDetail_NACTNUM.Name = "GColDetail_NACTNUM"
        '
        'GColDetail_VDINACT
        '
        Me.GColDetail_VDINACT.AppearanceCell.Font = CType(resources.GetObject("GColDetail_VDINACT.AppearanceCell.Font"), System.Drawing.Font)
        Me.GColDetail_VDINACT.AppearanceCell.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GColDetail_VDINACT.AppearanceCell.Options.UseFont = True
        Me.GColDetail_VDINACT.AppearanceCell.Options.UseForeColor = True
        Me.GColDetail_VDINACT.AppearanceCell.Options.UseTextOptions = True
        Me.GColDetail_VDINACT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetail_VDINACT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetail_VDINACT, "GColDetail_VDINACT")
        Me.GColDetail_VDINACT.ColumnEdit = Me.RepItemHyperLinkVDINACT
        Me.GColDetail_VDINACT.FieldName = "VDINACT"
        Me.GColDetail_VDINACT.Name = "GColDetail_VDINACT"
        Me.GColDetail_VDINACT.OptionsColumn.AllowEdit = False
        Me.GColDetail_VDINACT.OptionsColumn.ReadOnly = True
        '
        'RepItemHyperLinkVDINACT
        '
        resources.ApplyResources(Me.RepItemHyperLinkVDINACT, "RepItemHyperLinkVDINACT")
        Me.RepItemHyperLinkVDINACT.Name = "RepItemHyperLinkVDINACT"
        '
        'GColDetail_NDETAILNUM
        '
        Me.GColDetail_NDETAILNUM.AppearanceCell.Options.UseTextOptions = True
        Me.GColDetail_NDETAILNUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetail_NDETAILNUM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDetail_NDETAILNUM.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColDetail_NDETAILNUM, "GColDetail_NDETAILNUM")
        Me.GColDetail_NDETAILNUM.FieldName = "NDETAILNUM"
        Me.GColDetail_NDETAILNUM.Name = "GColDetail_NDETAILNUM"
        '
        'GColDetail_DACTDEX
        '
        Me.GColDetail_DACTDEX.AppearanceCell.Options.UseTextOptions = True
        Me.GColDetail_DACTDEX.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetail_DACTDEX.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetail_DACTDEX, "GColDetail_DACTDEX")
        Me.GColDetail_DACTDEX.FieldName = "DACTDEX"
        Me.GColDetail_DACTDEX.Name = "GColDetail_DACTDEX"
        '
        'GColDetail_NREA
        '
        resources.ApplyResources(Me.GColDetail_NREA, "GColDetail_NREA")
        Me.GColDetail_NREA.DisplayFormat.FormatString = "{0:n2}"
        Me.GColDetail_NREA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColDetail_NREA.FieldName = "NREA"
        Me.GColDetail_NREA.Name = "GColDetail_NREA"
        Me.GColDetail_NREA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GColDetail_NREA.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("GColDetail_NREA.Summary1"), resources.GetString("GColDetail_NREA.Summary2"))})
        '
        'GCResteARea
        '
        resources.ApplyResources(Me.GCResteARea, "GCResteARea")
        GridLevelNode1.LevelTemplate = Me.GVDetail
        GridLevelNode1.RelationName = "LvlDetail"
        Me.GCResteARea.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GCResteARea.MainView = Me.GVResteARea
        Me.GCResteARea.Name = "GCResteARea"
        Me.GCResteARea.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemHyperLinkVDINACT})
        Me.GCResteARea.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVResteARea, Me.GVDetail})
        '
        'GVResteARea
        '
        Me.GVResteARea.Appearance.Row.BackColor = System.Drawing.Color.LightCyan
        Me.GVResteARea.Appearance.Row.Options.UseBackColor = True
        Me.GVResteARea.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVResteARea.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVResteARea.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNIDFICHE, Me.ColVLIB, Me.ColNVAL, Me.ColNREAH, Me.ColNVALREA, Me.ColNVALAJUSTE, Me.ColTOT, Me.ColDIF, Me.ColPOURC, Me.ColVCOMMENTAIRE, Me.ColNIDANACHAFICTYPE, Me.ColNVALOBJ, Me.ColNDIFFOBJ})
        GridFormatRule1.Column = Me.ColDIF
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Red
        FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Greater
        FormatConditionRuleValue1.Value1 = "0"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.Column = Me.ColDIF
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.Green
        FormatConditionRuleValue2.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual
        FormatConditionRuleValue2.Value1 = "0"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        GridFormatRule3.Column = Me.ColPOURC
        GridFormatRule3.Name = "Format2"
        FormatConditionRuleValue3.Appearance.ForeColor = System.Drawing.Color.Red
        FormatConditionRuleValue3.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Greater
        FormatConditionRuleValue3.Value1 = "0"
        GridFormatRule3.Rule = FormatConditionRuleValue3
        GridFormatRule4.Column = Me.ColPOURC
        GridFormatRule4.Name = "Format3"
        FormatConditionRuleValue4.Appearance.ForeColor = System.Drawing.Color.Green
        FormatConditionRuleValue4.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual
        FormatConditionRuleValue4.Value1 = "0"
        GridFormatRule4.Rule = FormatConditionRuleValue4
        GridFormatRule5.Column = Me.ColNDIFFOBJ
        GridFormatRule5.Name = "Format4"
        FormatConditionRuleValue5.Appearance.ForeColor = System.Drawing.Color.Green
        FormatConditionRuleValue5.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue5.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue5.Expression = "[NDIFFOBJ] < 0"
        GridFormatRule5.Rule = FormatConditionRuleValue5
        GridFormatRule6.Column = Me.ColNDIFFOBJ
        GridFormatRule6.Name = "Format5"
        FormatConditionRuleValue6.Appearance.ForeColor = System.Drawing.Color.Red
        FormatConditionRuleValue6.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue6.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue6.Expression = "[NDIFFOBJ] >= 0"
        GridFormatRule6.Rule = FormatConditionRuleValue6
        Me.GVResteARea.FormatRules.Add(GridFormatRule1)
        Me.GVResteARea.FormatRules.Add(GridFormatRule2)
        Me.GVResteARea.FormatRules.Add(GridFormatRule3)
        Me.GVResteARea.FormatRules.Add(GridFormatRule4)
        Me.GVResteARea.FormatRules.Add(GridFormatRule5)
        Me.GVResteARea.FormatRules.Add(GridFormatRule6)
        Me.GVResteARea.GridControl = Me.GCResteARea
        Me.GVResteARea.Name = "GVResteARea"
        Me.GVResteARea.OptionsView.ShowAutoFilterRow = True
        Me.GVResteARea.OptionsView.ShowFooter = True
        Me.GVResteARea.OptionsView.ShowGroupPanel = False
        Me.GVResteARea.PaintStyleName = "Flat"
        '
        'ColNIDFICHE
        '
        Me.ColNIDFICHE.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNIDFICHE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNIDFICHE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColNIDFICHE, "ColNIDFICHE")
        Me.ColNIDFICHE.FieldName = "NIDFICHE"
        Me.ColNIDFICHE.Name = "ColNIDFICHE"
        Me.ColNIDFICHE.OptionsColumn.AllowEdit = False
        Me.ColNIDFICHE.OptionsColumn.ReadOnly = True
        '
        'ColVLIB
        '
        Me.ColVLIB.AppearanceCell.Font = CType(resources.GetObject("ColVLIB.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColVLIB.AppearanceCell.Options.UseFont = True
        Me.ColVLIB.AppearanceHeader.Font = CType(resources.GetObject("ColVLIB.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColVLIB.AppearanceHeader.Options.UseFont = True
        Me.ColVLIB.AppearanceHeader.Options.UseTextOptions = True
        Me.ColVLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVLIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColVLIB, "ColVLIB")
        Me.ColVLIB.FieldName = "VLIB"
        Me.ColVLIB.Name = "ColVLIB"
        Me.ColVLIB.OptionsColumn.AllowEdit = False
        Me.ColVLIB.OptionsColumn.ReadOnly = True
        Me.ColVLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColNVAL
        '
        Me.ColNVAL.AppearanceCell.Font = CType(resources.GetObject("ColNVAL.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColNVAL.AppearanceCell.Options.UseFont = True
        Me.ColNVAL.AppearanceHeader.Font = CType(resources.GetObject("ColNVAL.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColNVAL.AppearanceHeader.Options.UseFont = True
        Me.ColNVAL.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNVAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNVAL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColNVAL, "ColNVAL")
        Me.ColNVAL.DisplayFormat.FormatString = "c0"
        Me.ColNVAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColNVAL.FieldName = "NVAL"
        Me.ColNVAL.Name = "ColNVAL"
        Me.ColNVAL.OptionsColumn.AllowEdit = False
        Me.ColNVAL.OptionsColumn.ReadOnly = True
        Me.ColNVAL.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColNVAL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColNVAL.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColNVAL.Summary1"), resources.GetString("ColNVAL.Summary2"))})
        '
        'ColNREAH
        '
        Me.ColNREAH.AppearanceCell.Font = CType(resources.GetObject("ColNREAH.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColNREAH.AppearanceCell.Options.UseFont = True
        Me.ColNREAH.AppearanceHeader.Font = CType(resources.GetObject("ColNREAH.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColNREAH.AppearanceHeader.Options.UseFont = True
        Me.ColNREAH.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNREAH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNREAH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColNREAH, "ColNREAH")
        Me.ColNREAH.DisplayFormat.FormatString = "c0"
        Me.ColNREAH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColNREAH.FieldName = "NREAH"
        Me.ColNREAH.Name = "ColNREAH"
        Me.ColNREAH.OptionsColumn.AllowEdit = False
        Me.ColNREAH.OptionsColumn.ReadOnly = True
        Me.ColNREAH.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColNREAH.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColNREAH.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColNREAH.Summary1"), resources.GetString("ColNREAH.Summary2"))})
        '
        'ColNVALREA
        '
        Me.ColNVALREA.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.ColNVALREA.AppearanceCell.Font = CType(resources.GetObject("ColNVALREA.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColNVALREA.AppearanceCell.Options.UseBackColor = True
        Me.ColNVALREA.AppearanceCell.Options.UseFont = True
        Me.ColNVALREA.AppearanceHeader.Font = CType(resources.GetObject("ColNVALREA.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColNVALREA.AppearanceHeader.Options.UseFont = True
        Me.ColNVALREA.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNVALREA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNVALREA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColNVALREA, "ColNVALREA")
        Me.ColNVALREA.DisplayFormat.FormatString = "c0"
        Me.ColNVALREA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColNVALREA.FieldName = "NVALREA"
        Me.ColNVALREA.Name = "ColNVALREA"
        Me.ColNVALREA.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColNVALREA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColNVALREA.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColNVALREA.Summary1"), resources.GetString("ColNVALREA.Summary2"))})
        '
        'ColNVALAJUSTE
        '
        Me.ColNVALAJUSTE.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.ColNVALAJUSTE.AppearanceCell.Options.UseBackColor = True
        Me.ColNVALAJUSTE.AppearanceHeader.Font = CType(resources.GetObject("ColNVALAJUSTE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColNVALAJUSTE.AppearanceHeader.Options.UseFont = True
        Me.ColNVALAJUSTE.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNVALAJUSTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNVALAJUSTE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNVALAJUSTE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.ColNVALAJUSTE, "ColNVALAJUSTE")
        Me.ColNVALAJUSTE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColNVALAJUSTE.FieldName = "NVALAJUSTE"
        Me.ColNVALAJUSTE.Name = "ColNVALAJUSTE"
        Me.ColNVALAJUSTE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColNVALAJUSTE.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColNVALAJUSTE.Summary1"), resources.GetString("ColNVALAJUSTE.Summary2"))})
        '
        'ColTOT
        '
        Me.ColTOT.AppearanceCell.Font = CType(resources.GetObject("ColTOT.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColTOT.AppearanceCell.Options.UseFont = True
        Me.ColTOT.AppearanceHeader.Font = CType(resources.GetObject("ColTOT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColTOT.AppearanceHeader.Options.UseFont = True
        Me.ColTOT.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTOT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTOT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColTOT, "ColTOT")
        Me.ColTOT.DisplayFormat.FormatString = "0"
        Me.ColTOT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTOT.FieldName = "TOT"
        Me.ColTOT.Name = "ColTOT"
        Me.ColTOT.OptionsColumn.AllowEdit = False
        Me.ColTOT.OptionsColumn.ReadOnly = True
        Me.ColTOT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColTOT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColTOT.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColTOT.Summary1"), resources.GetString("ColTOT.Summary2"))})
        '
        'ColDIF
        '
        Me.ColDIF.AppearanceCell.Font = CType(resources.GetObject("ColDIF.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColDIF.AppearanceCell.Options.UseFont = True
        Me.ColDIF.AppearanceHeader.Font = CType(resources.GetObject("ColDIF.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColDIF.AppearanceHeader.Options.UseFont = True
        Me.ColDIF.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDIF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDIF.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColDIF, "ColDIF")
        Me.ColDIF.DisplayFormat.FormatString = "0"
        Me.ColDIF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColDIF.FieldName = "DIF"
        Me.ColDIF.Name = "ColDIF"
        Me.ColDIF.OptionsColumn.AllowEdit = False
        Me.ColDIF.OptionsColumn.ReadOnly = True
        Me.ColDIF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColDIF.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColDIF.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColDIF.Summary1"), resources.GetString("ColDIF.Summary2"))})
        '
        'ColPOURC
        '
        Me.ColPOURC.AppearanceCell.Font = CType(resources.GetObject("ColPOURC.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColPOURC.AppearanceCell.Options.UseFont = True
        Me.ColPOURC.AppearanceHeader.Font = CType(resources.GetObject("ColPOURC.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColPOURC.AppearanceHeader.Options.UseFont = True
        Me.ColPOURC.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPOURC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPOURC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColPOURC, "ColPOURC")
        Me.ColPOURC.FieldName = "POURC"
        Me.ColPOURC.Name = "ColPOURC"
        Me.ColPOURC.OptionsColumn.AllowEdit = False
        Me.ColPOURC.OptionsColumn.ReadOnly = True
        Me.ColPOURC.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColPOURC.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'ColVCOMMENTAIRE
        '
        Me.ColVCOMMENTAIRE.AppearanceCell.Font = CType(resources.GetObject("ColVCOMMENTAIRE.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColVCOMMENTAIRE.AppearanceCell.Options.UseFont = True
        Me.ColVCOMMENTAIRE.AppearanceHeader.Font = CType(resources.GetObject("ColVCOMMENTAIRE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColVCOMMENTAIRE.AppearanceHeader.Options.UseFont = True
        Me.ColVCOMMENTAIRE.AppearanceHeader.Options.UseTextOptions = True
        Me.ColVCOMMENTAIRE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVCOMMENTAIRE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColVCOMMENTAIRE, "ColVCOMMENTAIRE")
        Me.ColVCOMMENTAIRE.FieldName = "VCOMMENTAIRE"
        Me.ColVCOMMENTAIRE.Name = "ColVCOMMENTAIRE"
        Me.ColVCOMMENTAIRE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColNIDANACHAFICTYPE
        '
        resources.ApplyResources(Me.ColNIDANACHAFICTYPE, "ColNIDANACHAFICTYPE")
        Me.ColNIDANACHAFICTYPE.FieldName = "NIDANACHAFICTYPE"
        Me.ColNIDANACHAFICTYPE.Name = "ColNIDANACHAFICTYPE"
        '
        'ColNVALOBJ
        '
        Me.ColNVALOBJ.AppearanceCell.Options.UseTextOptions = True
        Me.ColNVALOBJ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColNVALOBJ.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNVALOBJ.AppearanceHeader.Font = CType(resources.GetObject("ColNVALOBJ.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColNVALOBJ.AppearanceHeader.Options.UseFont = True
        Me.ColNVALOBJ.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNVALOBJ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNVALOBJ.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNVALOBJ.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.ColNVALOBJ, "ColNVALOBJ")
        Me.ColNVALOBJ.FieldName = "NVALOBJ"
        Me.ColNVALOBJ.Name = "ColNVALOBJ"
        Me.ColNVALOBJ.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColNVALOBJ.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColNVALOBJ.Summary1"), resources.GetString("ColNVALOBJ.Summary2"))})
        '
        'ColNDIFFOBJ
        '
        Me.ColNDIFFOBJ.AppearanceCell.Options.UseTextOptions = True
        Me.ColNDIFFOBJ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColNDIFFOBJ.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNDIFFOBJ.AppearanceHeader.Font = CType(resources.GetObject("ColNDIFFOBJ.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColNDIFFOBJ.AppearanceHeader.Options.UseFont = True
        Me.ColNDIFFOBJ.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNDIFFOBJ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNDIFFOBJ.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNDIFFOBJ.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.ColNDIFFOBJ, "ColNDIFFOBJ")
        Me.ColNDIFFOBJ.FieldName = "NDIFFOBJ"
        Me.ColNDIFFOBJ.Name = "ColNDIFFOBJ"
        Me.ColNDIFFOBJ.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColNDIFFOBJ.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColNDIFFOBJ.Summary1"), resources.GetString("ColNDIFFOBJ.Summary2"))})
        '
        'btnClose
        '
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Name = "btnClose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'grpGrid
        '
        resources.ApplyResources(Me.grpGrid, "grpGrid")
        Me.grpGrid.Controls.Add(Me.GCResteARea)
        Me.grpGrid.Name = "grpGrid"
        Me.grpGrid.TabStop = False
        '
        'BtnValider
        '
        resources.ApplyResources(Me.BtnValider, "BtnValider")
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'BtnExportXLS
        '
        resources.ApplyResources(Me.BtnExportXLS, "BtnExportXLS")
        Me.BtnExportXLS.Name = "BtnExportXLS"
        Me.BtnExportXLS.UseVisualStyleBackColor = True
        '
        'BtnExportPDF
        '
        resources.ApplyResources(Me.BtnExportPDF, "BtnExportPDF")
        Me.BtnExportPDF.Name = "BtnExportPDF"
        Me.BtnExportPDF.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'frmGridResteARea
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.CancelButton = Me.btnClose
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnExportPDF)
        Me.Controls.Add(Me.BtnExportXLS)
        Me.Controls.Add(Me.BtnValider)
        Me.Controls.Add(Me.grpGrid)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmGridResteARea"
        CType(Me.GVDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemHyperLinkVDINACT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCResteARea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVResteARea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGrid.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents grpGrid As System.Windows.Forms.GroupBox
    Friend WithEvents BtnValider As System.Windows.Forms.Button
    Friend WithEvents BtnExportXLS As System.Windows.Forms.Button
    Friend WithEvents BtnExportPDF As System.Windows.Forms.Button
    Friend WithEvents SDF As System.Windows.Forms.SaveFileDialog
    Private WithEvents GCResteARea As DevExpress.XtraGrid.GridControl
    Private WithEvents GVResteARea As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColNIDFICHE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNVAL As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNREAH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNVALREA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColTOT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColDIF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVCOMMENTAIRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColPOURC As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNIDANACHAFICTYPE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColDetail_NIDFICHE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetail_NDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetail_NACTNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetail_DACTDEX As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetail_NREA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetail_VDINACT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemHyperLinkVDINACT As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Private WithEvents ColNVALAJUSTE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetail_NDETAILNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ColNVALOBJ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNDIFFOBJ As DevExpress.XtraGrid.Columns.GridColumn
End Class
