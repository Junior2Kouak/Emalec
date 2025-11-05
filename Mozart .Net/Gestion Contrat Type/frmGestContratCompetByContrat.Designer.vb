<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestContratCompetByContrat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestContratCompetByContrat))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.LvlGColNCONTRATEXIST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkCONTRATEXIST = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GVContrats = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LvlGColNCONTDOMNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LvlGColNTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LvlGColVTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCListTechByCont = New DevExpress.XtraGrid.GridControl()
        Me.GVTech = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVTECH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNCONTRATEXIST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSERLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpboxActions = New System.Windows.Forms.GroupBox()
        Me.BtnExportXLS = New System.Windows.Forms.Button()
        Me.BtnParTech = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GrpBoxLstContrat = New System.Windows.Forms.GroupBox()
        Me.GrpBoxContrats = New System.Windows.Forms.GroupBox()
        Me.GCListContrat = New DevExpress.XtraGrid.GridControl()
        Me.GVListContrat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCONTDOMLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        CType(Me.RepItemChkCONTRATEXIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVContrats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCListTechByCont, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVTech, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpboxActions.SuspendLayout()
        Me.GrpBoxLstContrat.SuspendLayout()
        Me.GrpBoxContrats.SuspendLayout()
        CType(Me.GCListContrat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListContrat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LvlGColNCONTRATEXIST
        '
        resources.ApplyResources(Me.LvlGColNCONTRATEXIST, "LvlGColNCONTRATEXIST")
        Me.LvlGColNCONTRATEXIST.ColumnEdit = Me.RepItemChkCONTRATEXIST
        Me.LvlGColNCONTRATEXIST.FieldName = "NCONTRATEXIST"
        Me.LvlGColNCONTRATEXIST.Name = "LvlGColNCONTRATEXIST"
        '
        'RepItemChkCONTRATEXIST
        '
        resources.ApplyResources(Me.RepItemChkCONTRATEXIST, "RepItemChkCONTRATEXIST")
        Me.RepItemChkCONTRATEXIST.Name = "RepItemChkCONTRATEXIST"
        Me.RepItemChkCONTRATEXIST.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChkCONTRATEXIST.ValueChecked = 1
        Me.RepItemChkCONTRATEXIST.ValueGrayed = 2
        Me.RepItemChkCONTRATEXIST.ValueUnchecked = 0
        '
        'GVContrats
        '
        Me.GVContrats.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.LvlGColNCONTDOMNUM, Me.LvlGColNTYPECONTRAT, Me.LvlGColVTYPECONTRAT, Me.LvlGColNCONTRATEXIST})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.LvlGColNCONTRATEXIST
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition1.Value1 = "1"
        Me.GVContrats.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GVContrats.GridControl = Me.GCListTechByCont
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
        'GCListTechByCont
        '
        resources.ApplyResources(Me.GCListTechByCont, "GCListTechByCont")
        Me.GCListTechByCont.MainView = Me.GVTech
        Me.GCListTechByCont.Name = "GCListTechByCont"
        Me.GCListTechByCont.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChkCONTRATEXIST})
        Me.GCListTechByCont.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVTech, Me.GVContrats})
        '
        'GVTech
        '
        Me.GVTech.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVTech.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVTech.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVTech.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNPERNUM, Me.GColVTECH, Me.GColNCONTRATEXIST, Me.GColVSERLIB})
        Me.GVTech.GridControl = Me.GCListTechByCont
        Me.GVTech.Name = "GVTech"
        Me.GVTech.OptionsDetail.ShowDetailTabs = False
        Me.GVTech.OptionsView.ShowGroupPanel = False
        '
        'GColNPERNUM
        '
        resources.ApplyResources(Me.GColNPERNUM, "GColNPERNUM")
        Me.GColNPERNUM.FieldName = "NPERNUM"
        Me.GColNPERNUM.Name = "GColNPERNUM"
        '
        'GColVTECH
        '
        Me.GColVTECH.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVTECH.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVTECH, "GColVTECH")
        Me.GColVTECH.FieldName = "VTECH"
        Me.GColVTECH.Name = "GColVTECH"
        '
        'GColNCONTRATEXIST
        '
        Me.GColNCONTRATEXIST.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNCONTRATEXIST.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColNCONTRATEXIST, "GColNCONTRATEXIST")
        Me.GColNCONTRATEXIST.ColumnEdit = Me.RepItemChkCONTRATEXIST
        Me.GColNCONTRATEXIST.FieldName = "NCONTRATEXIST"
        Me.GColNCONTRATEXIST.MaxWidth = 105
        Me.GColNCONTRATEXIST.Name = "GColNCONTRATEXIST"
        '
        'GColVSERLIB
        '
        Me.GColVSERLIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVSERLIB.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVSERLIB, "GColVSERLIB")
        Me.GColVSERLIB.FieldName = "VSERLIB"
        Me.GColVSERLIB.Name = "GColVSERLIB"
        '
        'GrpboxActions
        '
        Me.GrpboxActions.Controls.Add(Me.BtnExportXLS)
        Me.GrpboxActions.Controls.Add(Me.BtnParTech)
        Me.GrpboxActions.Controls.Add(Me.BtnClose)
        Me.GrpboxActions.Controls.Add(Me.BtnSave)
        resources.ApplyResources(Me.GrpboxActions, "GrpboxActions")
        Me.GrpboxActions.Name = "GrpboxActions"
        Me.GrpboxActions.TabStop = False
        '
        'BtnExportXLS
        '
        resources.ApplyResources(Me.BtnExportXLS, "BtnExportXLS")
        Me.BtnExportXLS.Name = "BtnExportXLS"
        Me.BtnExportXLS.Tag = ""
        Me.BtnExportXLS.UseVisualStyleBackColor = True
        '
        'BtnParTech
        '
        resources.ApplyResources(Me.BtnParTech, "BtnParTech")
        Me.BtnParTech.Name = "BtnParTech"
        Me.BtnParTech.UseVisualStyleBackColor = True
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
        'GrpBoxLstContrat
        '
        Me.GrpBoxLstContrat.Controls.Add(Me.GCListTechByCont)
        resources.ApplyResources(Me.GrpBoxLstContrat, "GrpBoxLstContrat")
        Me.GrpBoxLstContrat.Name = "GrpBoxLstContrat"
        Me.GrpBoxLstContrat.TabStop = False
        '
        'GrpBoxContrats
        '
        Me.GrpBoxContrats.Controls.Add(Me.GCListContrat)
        resources.ApplyResources(Me.GrpBoxContrats, "GrpBoxContrats")
        Me.GrpBoxContrats.Name = "GrpBoxContrats"
        Me.GrpBoxContrats.TabStop = False
        '
        'GCListContrat
        '
        resources.ApplyResources(Me.GCListContrat, "GCListContrat")
        Me.GCListContrat.MainView = Me.GVListContrat
        Me.GCListContrat.Name = "GCListContrat"
        Me.GCListContrat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListContrat})
        '
        'GVListContrat
        '
        Me.GVListContrat.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListContrat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListContrat.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListContrat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNTYPECONTRAT, Me.GColVCONTDOMLIB, Me.GColVTYPECONTRAT})
        Me.GVListContrat.GridControl = Me.GCListContrat
        Me.GVListContrat.Name = "GVListContrat"
        Me.GVListContrat.OptionsView.ShowAutoFilterRow = True
        Me.GVListContrat.OptionsView.ShowGroupPanel = False
        '
        'GColNTYPECONTRAT
        '
        resources.ApplyResources(Me.GColNTYPECONTRAT, "GColNTYPECONTRAT")
        Me.GColNTYPECONTRAT.FieldName = "NTYPECONTRAT"
        Me.GColNTYPECONTRAT.Name = "GColNTYPECONTRAT"
        '
        'GColVCONTDOMLIB
        '
        Me.GColVCONTDOMLIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVCONTDOMLIB.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVCONTDOMLIB, "GColVCONTDOMLIB")
        Me.GColVCONTDOMLIB.FieldName = "VCONTDOMLIB"
        Me.GColVCONTDOMLIB.Name = "GColVCONTDOMLIB"
        Me.GColVCONTDOMLIB.OptionsColumn.AllowEdit = False
        Me.GColVCONTDOMLIB.OptionsColumn.ReadOnly = True
        Me.GColVCONTDOMLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVTYPECONTRAT
        '
        Me.GColVTYPECONTRAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVTYPECONTRAT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVTYPECONTRAT, "GColVTYPECONTRAT")
        Me.GColVTYPECONTRAT.FieldName = "VTYPECONTRAT"
        Me.GColVTYPECONTRAT.Name = "GColVTYPECONTRAT"
        Me.GColVTYPECONTRAT.OptionsColumn.AllowEdit = False
        Me.GColVTYPECONTRAT.OptionsColumn.ReadOnly = True
        Me.GColVTYPECONTRAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
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
        'frmGestContratCompetByContrat
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpBoxContrats)
        Me.Controls.Add(Me.GrpBoxLstContrat)
        Me.Controls.Add(Me.GrpboxActions)
        Me.Name = "frmGestContratCompetByContrat"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RepItemChkCONTRATEXIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVContrats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCListTechByCont, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVTech, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpboxActions.ResumeLayout(False)
        Me.GrpBoxLstContrat.ResumeLayout(False)
        Me.GrpBoxContrats.ResumeLayout(False)
        CType(Me.GCListContrat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListContrat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpboxActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents GrpBoxLstContrat As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBoxContrats As System.Windows.Forms.GroupBox
    Friend WithEvents BtnParTech As System.Windows.Forms.Button
    Private WithEvents GCListTechByCont As DevExpress.XtraGrid.GridControl
    Private WithEvents GCListContrat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListContrat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCONTDOMLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVTech As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GVContrats As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents LvlGColNCONTDOMNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents LvlGColNTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents LvlGColVTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents LvlGColNCONTRATEXIST As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemChkCONTRATEXIST As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents GColNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVTECH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNCONTRATEXIST As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVSERLIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SFD As SaveFileDialog
    Friend WithEvents BtnExportXLS As Button
End Class
