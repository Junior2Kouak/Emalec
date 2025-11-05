<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestCompetPersByCompet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestCompetPersByCompet))
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.LvlGColNCONTRATEXIST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkPersBAFFECTE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GVContrats = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LvlGColNCONTDOMNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LvlGColNTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LvlGColVTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCListPersByCompet = New DevExpress.XtraGrid.GridControl()
        Me.GVPersByCompet = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNIDCOMPETENCEPER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNIDCOMPET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVTYPELIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColBAFFECTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpboxActions = New System.Windows.Forms.GroupBox()
        Me.BtnParPers = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GrpBoxLstCompetenceByPer = New System.Windows.Forms.GroupBox()
        Me.BtnDeCocheAll = New System.Windows.Forms.Button()
        Me.BtnCocheAll = New System.Windows.Forms.Button()
        Me.GrpBoxCompetence = New System.Windows.Forms.GroupBox()
        Me.PvtGridCompetence = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PvtRowCPERTYPE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PvtRowNIDCOMPET = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PvtDataNIDCOMPETBYFONC = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PvtRowVLIBDOM_COMPET = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PvtRowVLIBCOMPET = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PvtColVTYPELIB = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PvtDataBAFFECTE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.RepItemChkBAFFECTE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RepItemChkPersBAFFECTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVContrats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCListPersByCompet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPersByCompet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpboxActions.SuspendLayout()
        Me.GrpBoxLstCompetenceByPer.SuspendLayout()
        Me.GrpBoxCompetence.SuspendLayout()
        CType(Me.PvtGridCompetence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkBAFFECTE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LvlGColNCONTRATEXIST
        '
        resources.ApplyResources(Me.LvlGColNCONTRATEXIST, "LvlGColNCONTRATEXIST")
        Me.LvlGColNCONTRATEXIST.ColumnEdit = Me.RepItemChkPersBAFFECTE
        Me.LvlGColNCONTRATEXIST.FieldName = "NCONTRATEXIST"
        Me.LvlGColNCONTRATEXIST.Name = "LvlGColNCONTRATEXIST"
        '
        'RepItemChkPersBAFFECTE
        '
        resources.ApplyResources(Me.RepItemChkPersBAFFECTE, "RepItemChkPersBAFFECTE")
        Me.RepItemChkPersBAFFECTE.Name = "RepItemChkPersBAFFECTE"
        Me.RepItemChkPersBAFFECTE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChkPersBAFFECTE.ValueGrayed = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'GVContrats
        '
        Me.GVContrats.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.LvlGColNCONTDOMNUM, Me.LvlGColNTYPECONTRAT, Me.LvlGColVTYPECONTRAT, Me.LvlGColNCONTRATEXIST})
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.LvlGColNCONTRATEXIST
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition2.Value1 = "1"
        Me.GVContrats.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.GVContrats.GridControl = Me.GCListPersByCompet
        Me.GVContrats.Name = "GVContrats"
        Me.GVContrats.OptionsView.ShowGroupPanel = False
        '
        'LvlGColNCONTDOMNUM
        '
        Me.LvlGColNCONTDOMNUM.FieldName = "NCONTDOMNUM"
        Me.LvlGColNCONTDOMNUM.Name = "LvlGColNCONTDOMNUM"
        Me.LvlGColNCONTDOMNUM.OptionsColumn.ReadOnly = True
        '
        'LvlGColNTYPECONTRAT
        '
        resources.ApplyResources(Me.LvlGColNTYPECONTRAT, "LvlGColNTYPECONTRAT")
        Me.LvlGColNTYPECONTRAT.FieldName = "NTYPECONTRAT"
        Me.LvlGColNTYPECONTRAT.Name = "LvlGColNTYPECONTRAT"
        Me.LvlGColNTYPECONTRAT.OptionsColumn.ReadOnly = True
        '
        'LvlGColVTYPECONTRAT
        '
        resources.ApplyResources(Me.LvlGColVTYPECONTRAT, "LvlGColVTYPECONTRAT")
        Me.LvlGColVTYPECONTRAT.FieldName = "VTYPECONTRAT"
        Me.LvlGColVTYPECONTRAT.FieldNameSortGroup = "NCONTDOMNUM"
        Me.LvlGColVTYPECONTRAT.Name = "LvlGColVTYPECONTRAT"
        Me.LvlGColVTYPECONTRAT.OptionsColumn.AllowEdit = False
        Me.LvlGColVTYPECONTRAT.OptionsColumn.ReadOnly = True
        '
        'GCListPersByCompet
        '
        resources.ApplyResources(Me.GCListPersByCompet, "GCListPersByCompet")
        Me.GCListPersByCompet.MainView = Me.GVPersByCompet
        Me.GCListPersByCompet.Name = "GCListPersByCompet"
        Me.GCListPersByCompet.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChkPersBAFFECTE})
        Me.GCListPersByCompet.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPersByCompet, Me.GVContrats})
        '
        'GVPersByCompet
        '
        Me.GVPersByCompet.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVPersByCompet.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVPersByCompet.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVPersByCompet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNPERNUM, Me.GColNIDCOMPETENCEPER, Me.GColNIDCOMPET, Me.GColVTYPELIB, Me.GColNOM, Me.GColBAFFECTE})
        Me.GVPersByCompet.GridControl = Me.GCListPersByCompet
        Me.GVPersByCompet.Name = "GVPersByCompet"
        Me.GVPersByCompet.OptionsDetail.ShowDetailTabs = False
        Me.GVPersByCompet.OptionsView.ShowGroupPanel = False
        '
        'GColNPERNUM
        '
        Me.GColNPERNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNPERNUM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColNPERNUM, "GColNPERNUM")
        Me.GColNPERNUM.FieldName = "NPERNUM"
        Me.GColNPERNUM.Name = "GColNPERNUM"
        '
        'GColNIDCOMPETENCEPER
        '
        Me.GColNIDCOMPETENCEPER.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNIDCOMPETENCEPER.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColNIDCOMPETENCEPER, "GColNIDCOMPETENCEPER")
        Me.GColNIDCOMPETENCEPER.FieldName = "NIDCOMPETENCEPER"
        Me.GColNIDCOMPETENCEPER.Name = "GColNIDCOMPETENCEPER"
        '
        'GColNIDCOMPET
        '
        Me.GColNIDCOMPET.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNIDCOMPET.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColNIDCOMPET, "GColNIDCOMPET")
        Me.GColNIDCOMPET.FieldName = "NIDCOMPET"
        Me.GColNIDCOMPET.Name = "GColNIDCOMPET"
        '
        'GColVTYPELIB
        '
        Me.GColVTYPELIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVTYPELIB.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVTYPELIB, "GColVTYPELIB")
        Me.GColVTYPELIB.FieldName = "VTYPELIB"
        Me.GColVTYPELIB.Name = "GColVTYPELIB"
        Me.GColVTYPELIB.OptionsColumn.AllowEdit = False
        Me.GColVTYPELIB.OptionsColumn.ReadOnly = True
        '
        'GColNOM
        '
        Me.GColNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColNOM, "GColNOM")
        Me.GColNOM.FieldName = "NOM"
        Me.GColNOM.Name = "GColNOM"
        Me.GColNOM.OptionsColumn.AllowEdit = False
        Me.GColNOM.OptionsColumn.ReadOnly = True
        '
        'GColBAFFECTE
        '
        Me.GColBAFFECTE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColBAFFECTE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColBAFFECTE, "GColBAFFECTE")
        Me.GColBAFFECTE.ColumnEdit = Me.RepItemChkPersBAFFECTE
        Me.GColBAFFECTE.FieldName = "BAFFECTE"
        Me.GColBAFFECTE.MaxWidth = 105
        Me.GColBAFFECTE.Name = "GColBAFFECTE"
        '
        'GrpboxActions
        '
        Me.GrpboxActions.Controls.Add(Me.BtnParPers)
        Me.GrpboxActions.Controls.Add(Me.BtnClose)
        Me.GrpboxActions.Controls.Add(Me.BtnSave)
        resources.ApplyResources(Me.GrpboxActions, "GrpboxActions")
        Me.GrpboxActions.Name = "GrpboxActions"
        Me.GrpboxActions.TabStop = False
        '
        'BtnParPers
        '
        resources.ApplyResources(Me.BtnParPers, "BtnParPers")
        Me.BtnParPers.Name = "BtnParPers"
        Me.BtnParPers.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        resources.ApplyResources(Me.BtnClose, "BtnClose")
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        resources.ApplyResources(Me.BtnSave, "BtnSave")
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'GrpBoxLstCompetenceByPer
        '
        Me.GrpBoxLstCompetenceByPer.Controls.Add(Me.BtnDeCocheAll)
        Me.GrpBoxLstCompetenceByPer.Controls.Add(Me.BtnCocheAll)
        Me.GrpBoxLstCompetenceByPer.Controls.Add(Me.GCListPersByCompet)
        resources.ApplyResources(Me.GrpBoxLstCompetenceByPer, "GrpBoxLstCompetenceByPer")
        Me.GrpBoxLstCompetenceByPer.Name = "GrpBoxLstCompetenceByPer"
        Me.GrpBoxLstCompetenceByPer.TabStop = False
        '
        'BtnDeCocheAll
        '
        resources.ApplyResources(Me.BtnDeCocheAll, "BtnDeCocheAll")
        Me.BtnDeCocheAll.Name = "BtnDeCocheAll"
        Me.BtnDeCocheAll.UseVisualStyleBackColor = True
        '
        'BtnCocheAll
        '
        resources.ApplyResources(Me.BtnCocheAll, "BtnCocheAll")
        Me.BtnCocheAll.Name = "BtnCocheAll"
        Me.BtnCocheAll.UseVisualStyleBackColor = True
        '
        'GrpBoxCompetence
        '
        Me.GrpBoxCompetence.Controls.Add(Me.PvtGridCompetence)
        resources.ApplyResources(Me.GrpBoxCompetence, "GrpBoxCompetence")
        Me.GrpBoxCompetence.Name = "GrpBoxCompetence"
        Me.GrpBoxCompetence.TabStop = False
        '
        'PvtGridCompetence
        '
        Me.PvtGridCompetence.Appearance.Cell.ForeColor = System.Drawing.Color.Black
        Me.PvtGridCompetence.Appearance.Cell.Options.UseForeColor = True
        Me.PvtGridCompetence.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black
        Me.PvtGridCompetence.Appearance.FieldValue.Options.UseForeColor = True
        Me.PvtGridCompetence.Appearance.FieldValueGrandTotal.ForeColor = System.Drawing.Color.Black
        Me.PvtGridCompetence.Appearance.FieldValueGrandTotal.Options.UseForeColor = True
        resources.ApplyResources(Me.PvtGridCompetence, "PvtGridCompetence")
        Me.PvtGridCompetence.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PvtRowCPERTYPE, Me.PvtRowNIDCOMPET, Me.PvtDataNIDCOMPETBYFONC, Me.PvtRowVLIBDOM_COMPET, Me.PvtRowVLIBCOMPET, Me.PvtColVTYPELIB, Me.PvtDataBAFFECTE})
        Me.PvtGridCompetence.Name = "PvtGridCompetence"
        Me.PvtGridCompetence.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.PvtGridCompetence.OptionsSelection.MultiSelect = False
        Me.PvtGridCompetence.OptionsView.ShowColumnGrandTotalHeader = False
        Me.PvtGridCompetence.OptionsView.ShowColumnGrandTotals = False
        Me.PvtGridCompetence.OptionsView.ShowColumnTotals = False
        Me.PvtGridCompetence.OptionsView.ShowDataHeaders = False
        Me.PvtGridCompetence.OptionsView.ShowFilterHeaders = False
        Me.PvtGridCompetence.OptionsView.ShowRowGrandTotalHeader = False
        Me.PvtGridCompetence.OptionsView.ShowRowGrandTotals = False
        Me.PvtGridCompetence.OptionsView.ShowRowTotals = False
        Me.PvtGridCompetence.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChkBAFFECTE})
        '
        'PvtRowCPERTYPE
        '
        Me.PvtRowCPERTYPE.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PvtRowCPERTYPE.FieldName = "CPERTYPE"
        Me.PvtRowCPERTYPE.Name = "PvtRowCPERTYPE"
        Me.PvtRowCPERTYPE.Visible = False
        resources.ApplyResources(Me.PvtRowCPERTYPE, "PvtRowCPERTYPE")
        '
        'PvtRowNIDCOMPET
        '
        Me.PvtRowNIDCOMPET.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PvtRowNIDCOMPET.AreaIndex = 2
        Me.PvtRowNIDCOMPET.FieldName = "NIDCOMPET"
        Me.PvtRowNIDCOMPET.Name = "PvtRowNIDCOMPET"
        Me.PvtRowNIDCOMPET.Visible = False
        resources.ApplyResources(Me.PvtRowNIDCOMPET, "PvtRowNIDCOMPET")
        '
        'PvtDataNIDCOMPETBYFONC
        '
        Me.PvtDataNIDCOMPETBYFONC.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PvtDataNIDCOMPETBYFONC.FieldName = "NIDCOMPETBYFONC"
        Me.PvtDataNIDCOMPETBYFONC.Name = "PvtDataNIDCOMPETBYFONC"
        Me.PvtDataNIDCOMPETBYFONC.Visible = False
        '
        'PvtRowVLIBDOM_COMPET
        '
        Me.PvtRowVLIBDOM_COMPET.Appearance.Header.ForeColor = System.Drawing.Color.Black
        Me.PvtRowVLIBDOM_COMPET.Appearance.Header.Options.UseForeColor = True
        Me.PvtRowVLIBDOM_COMPET.Appearance.Value.Options.UseTextOptions = True
        Me.PvtRowVLIBDOM_COMPET.Appearance.Value.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PvtRowVLIBDOM_COMPET.Appearance.Value.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PvtRowVLIBDOM_COMPET.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PvtRowVLIBDOM_COMPET.AreaIndex = 0
        resources.ApplyResources(Me.PvtRowVLIBDOM_COMPET, "PvtRowVLIBDOM_COMPET")
        Me.PvtRowVLIBDOM_COMPET.FieldName = "VLIBDOM_COMPET"
        Me.PvtRowVLIBDOM_COMPET.Name = "PvtRowVLIBDOM_COMPET"
        Me.PvtRowVLIBDOM_COMPET.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.[False]
        Me.PvtRowVLIBDOM_COMPET.Options.AllowEdit = False
        Me.PvtRowVLIBDOM_COMPET.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.PvtRowVLIBDOM_COMPET.Options.ReadOnly = True
        '
        'PvtRowVLIBCOMPET
        '
        Me.PvtRowVLIBCOMPET.Appearance.Header.ForeColor = System.Drawing.Color.Black
        Me.PvtRowVLIBCOMPET.Appearance.Header.Options.UseForeColor = True
        Me.PvtRowVLIBCOMPET.Appearance.Value.Options.UseTextOptions = True
        Me.PvtRowVLIBCOMPET.Appearance.Value.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PvtRowVLIBCOMPET.Appearance.Value.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PvtRowVLIBCOMPET.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PvtRowVLIBCOMPET.AreaIndex = 1
        resources.ApplyResources(Me.PvtRowVLIBCOMPET, "PvtRowVLIBCOMPET")
        Me.PvtRowVLIBCOMPET.FieldName = "VLIBCOMPET"
        Me.PvtRowVLIBCOMPET.Name = "PvtRowVLIBCOMPET"
        Me.PvtRowVLIBCOMPET.Options.AllowEdit = False
        Me.PvtRowVLIBCOMPET.Options.ReadOnly = True
        '
        'PvtColVTYPELIB
        '
        Me.PvtColVTYPELIB.Appearance.Cell.ForeColor = System.Drawing.Color.Black
        Me.PvtColVTYPELIB.Appearance.Cell.Options.UseForeColor = True
        Me.PvtColVTYPELIB.Appearance.CellGrandTotal.ForeColor = System.Drawing.Color.Black
        Me.PvtColVTYPELIB.Appearance.CellGrandTotal.Options.UseForeColor = True
        Me.PvtColVTYPELIB.Appearance.CellTotal.ForeColor = System.Drawing.Color.Black
        Me.PvtColVTYPELIB.Appearance.CellTotal.Options.UseForeColor = True
        Me.PvtColVTYPELIB.Appearance.Header.ForeColor = System.Drawing.Color.Black
        Me.PvtColVTYPELIB.Appearance.Header.Options.UseForeColor = True
        Me.PvtColVTYPELIB.Appearance.Value.Font = CType(resources.GetObject("PvtColVTYPELIB.Appearance.Value.Font"), System.Drawing.Font)
        Me.PvtColVTYPELIB.Appearance.Value.ForeColor = System.Drawing.Color.Black
        Me.PvtColVTYPELIB.Appearance.Value.Options.UseFont = True
        Me.PvtColVTYPELIB.Appearance.Value.Options.UseForeColor = True
        Me.PvtColVTYPELIB.Appearance.Value.Options.UseTextOptions = True
        Me.PvtColVTYPELIB.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PvtColVTYPELIB.Appearance.Value.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PvtColVTYPELIB.Appearance.Value.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PvtColVTYPELIB.Appearance.ValueGrandTotal.ForeColor = System.Drawing.Color.Black
        Me.PvtColVTYPELIB.Appearance.ValueGrandTotal.Options.UseForeColor = True
        Me.PvtColVTYPELIB.Appearance.ValueTotal.ForeColor = System.Drawing.Color.Black
        Me.PvtColVTYPELIB.Appearance.ValueTotal.Options.UseForeColor = True
        Me.PvtColVTYPELIB.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PvtColVTYPELIB.AreaIndex = 0
        resources.ApplyResources(Me.PvtColVTYPELIB, "PvtColVTYPELIB")
        Me.PvtColVTYPELIB.FieldName = "VTYPELIB"
        Me.PvtColVTYPELIB.Name = "PvtColVTYPELIB"
        Me.PvtColVTYPELIB.Options.AllowEdit = False
        Me.PvtColVTYPELIB.Options.ReadOnly = True
        '
        'PvtDataBAFFECTE
        '
        Me.PvtDataBAFFECTE.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PvtDataBAFFECTE.AreaIndex = 0
        Me.PvtDataBAFFECTE.FieldEdit = Me.RepItemChkBAFFECTE
        Me.PvtDataBAFFECTE.FieldName = "BAFFECTE"
        Me.PvtDataBAFFECTE.Name = "PvtDataBAFFECTE"
        Me.PvtDataBAFFECTE.Options.AllowEdit = False
        Me.PvtDataBAFFECTE.Options.ReadOnly = True
        '
        'RepItemChkBAFFECTE
        '
        resources.ApplyResources(Me.RepItemChkBAFFECTE, "RepItemChkBAFFECTE")
        Me.RepItemChkBAFFECTE.Name = "RepItemChkBAFFECTE"
        Me.RepItemChkBAFFECTE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChkBAFFECTE.ReadOnly = True
        Me.RepItemChkBAFFECTE.ValueChecked = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepItemChkBAFFECTE.ValueUnchecked = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'GridColumn1
        '
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        resources.ApplyResources(Me.GridColumn2, "GridColumn2")
        Me.GridColumn2.Name = "GridColumn2"
        '
        'frmGestCompetPersByCompet
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpBoxCompetence)
        Me.Controls.Add(Me.GrpBoxLstCompetenceByPer)
        Me.Controls.Add(Me.GrpboxActions)
        Me.Name = "frmGestCompetPersByCompet"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RepItemChkPersBAFFECTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVContrats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCListPersByCompet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPersByCompet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpboxActions.ResumeLayout(False)
        Me.GrpBoxLstCompetenceByPer.ResumeLayout(False)
        Me.GrpBoxCompetence.ResumeLayout(False)
        CType(Me.PvtGridCompetence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkBAFFECTE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpboxActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents GrpBoxLstCompetenceByPer As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBoxCompetence As System.Windows.Forms.GroupBox
    Friend WithEvents BtnParPers As System.Windows.Forms.Button
    Private WithEvents GCListPersByCompet As DevExpress.XtraGrid.GridControl
    Private WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVPersByCompet As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GVContrats As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents LvlGColNCONTDOMNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents LvlGColNTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents LvlGColVTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents LvlGColNCONTRATEXIST As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemChkPersBAFFECTE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents GColNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColBAFFECTE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVTYPELIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PvtGridCompetence As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PvtRowCPERTYPE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PvtRowNIDCOMPET As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PvtDataNIDCOMPETBYFONC As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PvtRowVLIBDOM_COMPET As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PvtRowVLIBCOMPET As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PvtColVTYPELIB As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PvtDataBAFFECTE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents RepItemChkBAFFECTE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GColNIDCOMPETENCEPER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNIDCOMPET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnDeCocheAll As System.Windows.Forms.Button
    Friend WithEvents BtnCocheAll As System.Windows.Forms.Button
End Class
