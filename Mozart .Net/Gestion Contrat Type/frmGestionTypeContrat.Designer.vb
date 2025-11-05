<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionTypeContrat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionTypeContrat))
        Me.GCContrat = New DevExpress.XtraGrid.GridControl()
        Me.GVListeContrat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNCONTGESTNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNCONTDOMNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepGLUpEditDom = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepItemGLkUpEditDomaineView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColNCONTDOMNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCONTDOMLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNEDITRECRU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkRecru = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GrpboxActions = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        CType(Me.GCContrat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeContrat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepGLUpEditDom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLkUpEditDomaineView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkRecru, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpboxActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCContrat
        '
        resources.ApplyResources(Me.GCContrat, "GCContrat")
        Me.GCContrat.MainView = Me.GVListeContrat
        Me.GCContrat.Name = "GCContrat"
        Me.GCContrat.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChkRecru, Me.RepGLUpEditDom})
        Me.GCContrat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeContrat})
        '
        'GVListeContrat
        '
        Me.GVListeContrat.Appearance.Row.BackColor = System.Drawing.Color.LightCyan
        Me.GVListeContrat.Appearance.Row.Options.UseBackColor = True
        Me.GVListeContrat.Appearance.SelectedRow.BackColor = System.Drawing.Color.Gainsboro
        Me.GVListeContrat.Appearance.SelectedRow.Font = CType(resources.GetObject("GVListeContrat.Appearance.SelectedRow.Font"), System.Drawing.Font)
        Me.GVListeContrat.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListeContrat.Appearance.SelectedRow.Options.UseFont = True
        Me.GVListeContrat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColIDTMP, Me.GColNCONTGESTNUM, Me.GColNTYPECONTRAT, Me.GColVTYPECONTRAT, Me.GColNCONTDOMNUM, Me.GColNEDITRECRU})
        Me.GVListeContrat.GridControl = Me.GCContrat
        Me.GVListeContrat.Name = "GVListeContrat"
        Me.GVListeContrat.OptionsView.ShowAutoFilterRow = True
        Me.GVListeContrat.OptionsView.ShowGroupPanel = False
        '
        'GColIDTMP
        '
        resources.ApplyResources(Me.GColIDTMP, "GColIDTMP")
        Me.GColIDTMP.FieldName = "IDTMP"
        Me.GColIDTMP.Name = "GColIDTMP"
        Me.GColIDTMP.OptionsColumn.ReadOnly = True
        '
        'GColNCONTGESTNUM
        '
        resources.ApplyResources(Me.GColNCONTGESTNUM, "GColNCONTGESTNUM")
        Me.GColNCONTGESTNUM.FieldName = "NCONTGESTNUM"
        Me.GColNCONTGESTNUM.Name = "GColNCONTGESTNUM"
        Me.GColNCONTGESTNUM.OptionsColumn.ReadOnly = True
        '
        'GColNTYPECONTRAT
        '
        resources.ApplyResources(Me.GColNTYPECONTRAT, "GColNTYPECONTRAT")
        Me.GColNTYPECONTRAT.FieldName = "NTYPECONTRAT"
        Me.GColNTYPECONTRAT.Name = "GColNTYPECONTRAT"
        Me.GColNTYPECONTRAT.OptionsColumn.ReadOnly = True
        '
        'GColVTYPECONTRAT
        '
        Me.GColVTYPECONTRAT.AppearanceHeader.Font = CType(resources.GetObject("GColVTYPECONTRAT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVTYPECONTRAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVTYPECONTRAT.AppearanceHeader.Options.UseFont = True
        Me.GColVTYPECONTRAT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVTYPECONTRAT, "GColVTYPECONTRAT")
        Me.GColVTYPECONTRAT.FieldName = "VTYPECONTRAT"
        Me.GColVTYPECONTRAT.Name = "GColVTYPECONTRAT"
        Me.GColVTYPECONTRAT.OptionsColumn.AllowEdit = False
        Me.GColVTYPECONTRAT.OptionsColumn.ReadOnly = True
        Me.GColVTYPECONTRAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNCONTDOMNUM
        '
        Me.GColNCONTDOMNUM.AppearanceHeader.Font = CType(resources.GetObject("GColNCONTDOMNUM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColNCONTDOMNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNCONTDOMNUM.AppearanceHeader.Options.UseFont = True
        Me.GColNCONTDOMNUM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColNCONTDOMNUM, "GColNCONTDOMNUM")
        Me.GColNCONTDOMNUM.ColumnEdit = Me.RepGLUpEditDom
        Me.GColNCONTDOMNUM.FieldName = "NCONTDOMNUM"
        Me.GColNCONTDOMNUM.Name = "GColNCONTDOMNUM"
        Me.GColNCONTDOMNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'RepGLUpEditDom
        '
        resources.ApplyResources(Me.RepGLUpEditDom, "RepGLUpEditDom")
        Me.RepGLUpEditDom.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepGLUpEditDom.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepGLUpEditDom.DisplayMember = "VCONTDOMLIB"
        Me.RepGLUpEditDom.Name = "RepGLUpEditDom"
        Me.RepGLUpEditDom.PopupView = Me.RepItemGLkUpEditDomaineView
        Me.RepGLUpEditDom.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepGLUpEditDom.ValueMember = "NCONTDOMNUM"
        '
        'RepItemGLkUpEditDomaineView
        '
        Me.RepItemGLkUpEditDomaineView.Appearance.Row.BackColor = System.Drawing.Color.PaleGreen
        Me.RepItemGLkUpEditDomaineView.Appearance.Row.Options.UseBackColor = True
        Me.RepItemGLkUpEditDomaineView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColNCONTDOMNUM, Me.GColVCONTDOMLIB})
        Me.RepItemGLkUpEditDomaineView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepItemGLkUpEditDomaineView.Name = "RepItemGLkUpEditDomaineView"
        Me.RepItemGLkUpEditDomaineView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepItemGLkUpEditDomaineView.OptionsView.ShowGroupPanel = False
        '
        'GridColNCONTDOMNUM
        '
        resources.ApplyResources(Me.GridColNCONTDOMNUM, "GridColNCONTDOMNUM")
        Me.GridColNCONTDOMNUM.FieldName = "NCONTDOMNUM"
        Me.GridColNCONTDOMNUM.Name = "GridColNCONTDOMNUM"
        '
        'GColVCONTDOMLIB
        '
        resources.ApplyResources(Me.GColVCONTDOMLIB, "GColVCONTDOMLIB")
        Me.GColVCONTDOMLIB.FieldName = "VCONTDOMLIB"
        Me.GColVCONTDOMLIB.Name = "GColVCONTDOMLIB"
        '
        'GColNEDITRECRU
        '
        Me.GColNEDITRECRU.AppearanceHeader.Font = CType(resources.GetObject("GColNEDITRECRU.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColNEDITRECRU.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNEDITRECRU.AppearanceHeader.Options.UseFont = True
        Me.GColNEDITRECRU.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColNEDITRECRU, "GColNEDITRECRU")
        Me.GColNEDITRECRU.ColumnEdit = Me.RepItemChkRecru
        Me.GColNEDITRECRU.FieldName = "NEDITRECRU"
        Me.GColNEDITRECRU.Name = "GColNEDITRECRU"
        Me.GColNEDITRECRU.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'RepItemChkRecru
        '
        resources.ApplyResources(Me.RepItemChkRecru, "RepItemChkRecru")
        Me.RepItemChkRecru.Name = "RepItemChkRecru"
        Me.RepItemChkRecru.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChkRecru.ValueChecked = 1
        Me.RepItemChkRecru.ValueGrayed = 2
        Me.RepItemChkRecru.ValueUnchecked = 0
        '
        'GrpboxActions
        '
        Me.GrpboxActions.Controls.Add(Me.BtnClose)
        Me.GrpboxActions.Controls.Add(Me.BtnSave)
        resources.ApplyResources(Me.GrpboxActions, "GrpboxActions")
        Me.GrpboxActions.Name = "GrpboxActions"
        Me.GrpboxActions.TabStop = False
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
        'frmGestionTypeContrat
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpboxActions)
        Me.Controls.Add(Me.GCContrat)
        Me.Name = "frmGestionTypeContrat"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCContrat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeContrat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepGLUpEditDom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLkUpEditDomaineView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkRecru, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpboxActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpboxActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Private WithEvents GCContrat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeContrat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNCONTGESTNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNCONTDOMNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNEDITRECRU As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemChkRecru As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents RepGLUpEditDom As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepItemGLkUpEditDomaineView As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GridColNCONTDOMNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCONTDOMLIB As DevExpress.XtraGrid.Columns.GridColumn
End Class
