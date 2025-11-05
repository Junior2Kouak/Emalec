<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestContratCompetByTech
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestContratCompetByTech))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.LvlGColNCONTRATEXIST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkCONTRATEXIST = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GVContrats = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LvlGColNCONTDOMNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LvlGColNTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LvlGColVTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCListContByDom = New DevExpress.XtraGrid.GridControl()
        Me.GVDomaines = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNCONTDOMNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCONTDOMLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNCONTRATEXIST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNSERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpboxActions = New System.Windows.Forms.GroupBox()
        Me.BtnExportXLS = New System.Windows.Forms.Button()
        Me.BtnGestModif = New System.Windows.Forms.Button()
        Me.BtnParContrat = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GrpBoxLstContrat = New System.Windows.Forms.GroupBox()
        Me.GrpBoxTechs = New System.Windows.Forms.GroupBox()
        Me.GCListTech = New DevExpress.XtraGrid.GridControl()
        Me.GVListTech = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSERLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVTECH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        CType(Me.RepItemChkCONTRATEXIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVContrats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCListContByDom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDomaines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpboxActions.SuspendLayout()
        Me.GrpBoxLstContrat.SuspendLayout()
        Me.GrpBoxTechs.SuspendLayout()
        CType(Me.GCListTech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListTech, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GVContrats.GridControl = Me.GCListContByDom
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
        'GCListContByDom
        '
        resources.ApplyResources(Me.GCListContByDom, "GCListContByDom")
        Me.GCListContByDom.MainView = Me.GVDomaines
        Me.GCListContByDom.Name = "GCListContByDom"
        Me.GCListContByDom.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChkCONTRATEXIST})
        Me.GCListContByDom.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDomaines, Me.GVContrats})
        '
        'GVDomaines
        '
        Me.GVDomaines.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNCONTDOMNUM, Me.GColVCONTDOMLIB, Me.GColNTYPECONTRAT, Me.GColVTYPECONTRAT, Me.GColNCONTRATEXIST})
        Me.GVDomaines.GridControl = Me.GCListContByDom
        Me.GVDomaines.Name = "GVDomaines"
        Me.GVDomaines.OptionsDetail.ShowDetailTabs = False
        Me.GVDomaines.OptionsView.ShowGroupPanel = False
        '
        'GColNCONTDOMNUM
        '
        resources.ApplyResources(Me.GColNCONTDOMNUM, "GColNCONTDOMNUM")
        Me.GColNCONTDOMNUM.FieldName = "NCONTDOMNUM"
        Me.GColNCONTDOMNUM.Name = "GColNCONTDOMNUM"
        Me.GColNCONTDOMNUM.OptionsColumn.ReadOnly = True
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
        '
        'GColNTYPECONTRAT
        '
        resources.ApplyResources(Me.GColNTYPECONTRAT, "GColNTYPECONTRAT")
        Me.GColNTYPECONTRAT.FieldName = "NTYPECONTRAT"
        Me.GColNTYPECONTRAT.Name = "GColNTYPECONTRAT"
        '
        'GColVTYPECONTRAT
        '
        Me.GColVTYPECONTRAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVTYPECONTRAT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVTYPECONTRAT, "GColVTYPECONTRAT")
        Me.GColVTYPECONTRAT.FieldName = "VTYPECONTRAT"
        Me.GColVTYPECONTRAT.Name = "GColVTYPECONTRAT"
        '
        'GColNCONTRATEXIST
        '
        Me.GColNCONTRATEXIST.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNCONTRATEXIST.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColNCONTRATEXIST, "GColNCONTRATEXIST")
        Me.GColNCONTRATEXIST.ColumnEdit = Me.RepItemChkCONTRATEXIST
        Me.GColNCONTRATEXIST.FieldName = "NCONTRATEXIST"
        Me.GColNCONTRATEXIST.MinWidth = 105
        Me.GColNCONTRATEXIST.Name = "GColNCONTRATEXIST"
        '
        'GColNSERNUM
        '
        resources.ApplyResources(Me.GColNSERNUM, "GColNSERNUM")
        Me.GColNSERNUM.FieldName = "NSERNUM"
        Me.GColNSERNUM.Name = "GColNSERNUM"
        '
        'GrpboxActions
        '
        Me.GrpboxActions.Controls.Add(Me.BtnExportXLS)
        Me.GrpboxActions.Controls.Add(Me.BtnGestModif)
        Me.GrpboxActions.Controls.Add(Me.BtnParContrat)
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
        'BtnGestModif
        '
        resources.ApplyResources(Me.BtnGestModif, "BtnGestModif")
        Me.BtnGestModif.Name = "BtnGestModif"
        Me.BtnGestModif.UseVisualStyleBackColor = True
        '
        'BtnParContrat
        '
        resources.ApplyResources(Me.BtnParContrat, "BtnParContrat")
        Me.BtnParContrat.Name = "BtnParContrat"
        Me.BtnParContrat.UseVisualStyleBackColor = True
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
        Me.GrpBoxLstContrat.Controls.Add(Me.GCListContByDom)
        resources.ApplyResources(Me.GrpBoxLstContrat, "GrpBoxLstContrat")
        Me.GrpBoxLstContrat.Name = "GrpBoxLstContrat"
        Me.GrpBoxLstContrat.TabStop = False
        '
        'GrpBoxTechs
        '
        Me.GrpBoxTechs.Controls.Add(Me.GCListTech)
        resources.ApplyResources(Me.GrpBoxTechs, "GrpBoxTechs")
        Me.GrpBoxTechs.Name = "GrpBoxTechs"
        Me.GrpBoxTechs.TabStop = False
        '
        'GCListTech
        '
        resources.ApplyResources(Me.GCListTech, "GCListTech")
        Me.GCListTech.MainView = Me.GVListTech
        Me.GCListTech.Name = "GCListTech"
        Me.GCListTech.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListTech})
        '
        'GVListTech
        '
        Me.GVListTech.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNPERNUM, Me.GColVSERLIB, Me.GColVTECH, Me.GColNSERNUM})
        Me.GVListTech.GridControl = Me.GCListTech
        Me.GVListTech.Name = "GVListTech"
        Me.GVListTech.OptionsView.ShowAutoFilterRow = True
        Me.GVListTech.OptionsView.ShowGroupPanel = False
        '
        'GColNPERNUM
        '
        resources.ApplyResources(Me.GColNPERNUM, "GColNPERNUM")
        Me.GColNPERNUM.Name = "GColNPERNUM"
        '
        'GColVSERLIB
        '
        Me.GColVSERLIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVSERLIB.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVSERLIB, "GColVSERLIB")
        Me.GColVSERLIB.FieldName = "VSERLIB"
        Me.GColVSERLIB.Name = "GColVSERLIB"
        Me.GColVSERLIB.OptionsColumn.AllowEdit = False
        Me.GColVSERLIB.OptionsColumn.ReadOnly = True
        Me.GColVSERLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVTECH
        '
        Me.GColVTECH.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVTECH.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVTECH, "GColVTECH")
        Me.GColVTECH.FieldName = "TECH"
        Me.GColVTECH.Name = "GColVTECH"
        Me.GColVTECH.OptionsColumn.AllowEdit = False
        Me.GColVTECH.OptionsColumn.ReadOnly = True
        Me.GColVTECH.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
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
        'frmGestContratCompetByTech
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpBoxTechs)
        Me.Controls.Add(Me.GrpBoxLstContrat)
        Me.Controls.Add(Me.GrpboxActions)
        Me.Name = "frmGestContratCompetByTech"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RepItemChkCONTRATEXIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVContrats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCListContByDom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDomaines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpboxActions.ResumeLayout(False)
        Me.GrpBoxLstContrat.ResumeLayout(False)
        Me.GrpBoxTechs.ResumeLayout(False)
        CType(Me.GCListTech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListTech, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpboxActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents GrpBoxLstContrat As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBoxTechs As System.Windows.Forms.GroupBox
    Friend WithEvents BtnParContrat As System.Windows.Forms.Button
    Private WithEvents GCListContByDom As DevExpress.XtraGrid.GridControl
    Private WithEvents GCListTech As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListTech As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVTECH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVSERLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNSERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVDomaines As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNCONTDOMNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCONTDOMLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVContrats As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents LvlGColNCONTDOMNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents LvlGColNTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents LvlGColVTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents LvlGColNCONTRATEXIST As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemChkCONTRATEXIST As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents GColNTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNCONTRATEXIST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnGestModif As Button
    Friend WithEvents SFD As SaveFileDialog
    Friend WithEvents BtnExportXLS As Button
End Class
