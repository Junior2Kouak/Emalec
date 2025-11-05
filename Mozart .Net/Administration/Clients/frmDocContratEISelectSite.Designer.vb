<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocContratEISelectSite
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocContratEISelectSite))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnGenerate = New System.Windows.Forms.Button()
        Me.GrpContact = New System.Windows.Forms.GroupBox()
        Me.GridLookUpContact = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpContactView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNCCLNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCCLNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCCLFONC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpListeSites = New System.Windows.Forms.GroupBox()
        Me.BtnDecoche = New System.Windows.Forms.Button()
        Me.BtnCoche = New System.Windows.Forms.Button()
        Me.GCListeSites = New DevExpress.XtraGrid.GridControl()
        Me.GVListeSites = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColCheckSite = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemCheckEditSite = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GColNSITNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNSITNUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSITAD1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSITCP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSITVIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions.SuspendLayout()
        Me.GrpContact.SuspendLayout()
        CType(Me.GridLookUpContact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpContactView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpListeSites.SuspendLayout()
        CType(Me.GCListeSites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeSites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemCheckEditSite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnClose)
        Me.GrpActions.Controls.Add(Me.BtnGenerate)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnClose
        '
        resources.ApplyResources(Me.BtnClose, "BtnClose")
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnGenerate
        '
        resources.ApplyResources(Me.BtnGenerate, "BtnGenerate")
        Me.BtnGenerate.Name = "BtnGenerate"
        Me.BtnGenerate.UseVisualStyleBackColor = True
        '
        'GrpContact
        '
        Me.GrpContact.Controls.Add(Me.GridLookUpContact)
        resources.ApplyResources(Me.GrpContact, "GrpContact")
        Me.GrpContact.Name = "GrpContact"
        Me.GrpContact.TabStop = False
        '
        'GridLookUpContact
        '
        resources.ApplyResources(Me.GridLookUpContact, "GridLookUpContact")
        Me.GridLookUpContact.Name = "GridLookUpContact"
        Me.GridLookUpContact.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GridLookUpContact.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.GridLookUpContact.Properties.DisplayMember = "VCCLNOM"
        Me.GridLookUpContact.Properties.NullText = resources.GetString("GridLookUpContact.Properties.NullText")
        Me.GridLookUpContact.Properties.PopupFormSize = New System.Drawing.Size(382, 400)
        Me.GridLookUpContact.Properties.PopupView = Me.GridLookUpContactView
        Me.GridLookUpContact.Properties.ShowNullValuePrompt = CType((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused Or DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly), DevExpress.XtraEditors.ShowNullValuePromptOptions)
        Me.GridLookUpContact.Properties.ValueMember = "NCCLNUM"
        '
        'GridLookUpContactView
        '
        Me.GridLookUpContactView.Appearance.HeaderPanel.Font = CType(resources.GetObject("GridLookUpContactView.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GridLookUpContactView.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridLookUpContactView.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridLookUpContactView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridLookUpContactView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridLookUpContactView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNCCLNUM, Me.GColVCCLNOM, Me.GColVCCLFONC})
        Me.GridLookUpContactView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpContactView.Name = "GridLookUpContactView"
        Me.GridLookUpContactView.OptionsBehavior.ReadOnly = True
        Me.GridLookUpContactView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpContactView.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpContactView.OptionsView.ShowGroupPanel = False
        '
        'GColNCCLNUM
        '
        resources.ApplyResources(Me.GColNCCLNUM, "GColNCCLNUM")
        Me.GColNCCLNUM.FieldName = "NCCLNUM"
        Me.GColNCCLNUM.Name = "GColNCCLNUM"
        '
        'GColVCCLNOM
        '
        resources.ApplyResources(Me.GColVCCLNOM, "GColVCCLNOM")
        Me.GColVCCLNOM.FieldName = "VCCLNOM"
        Me.GColVCCLNOM.Name = "GColVCCLNOM"
        Me.GColVCCLNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVCCLFONC
        '
        resources.ApplyResources(Me.GColVCCLFONC, "GColVCCLFONC")
        Me.GColVCCLFONC.FieldName = "VCCLFONC"
        Me.GColVCCLFONC.Name = "GColVCCLFONC"
        Me.GColVCCLFONC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GrpListeSites
        '
        Me.GrpListeSites.Controls.Add(Me.BtnDecoche)
        Me.GrpListeSites.Controls.Add(Me.BtnCoche)
        Me.GrpListeSites.Controls.Add(Me.GCListeSites)
        resources.ApplyResources(Me.GrpListeSites, "GrpListeSites")
        Me.GrpListeSites.Name = "GrpListeSites"
        Me.GrpListeSites.TabStop = False
        '
        'BtnDecoche
        '
        resources.ApplyResources(Me.BtnDecoche, "BtnDecoche")
        Me.BtnDecoche.Name = "BtnDecoche"
        Me.BtnDecoche.UseVisualStyleBackColor = True
        '
        'BtnCoche
        '
        resources.ApplyResources(Me.BtnCoche, "BtnCoche")
        Me.BtnCoche.Name = "BtnCoche"
        Me.BtnCoche.UseVisualStyleBackColor = True
        '
        'GCListeSites
        '
        resources.ApplyResources(Me.GCListeSites, "GCListeSites")
        Me.GCListeSites.MainView = Me.GVListeSites
        Me.GCListeSites.Name = "GCListeSites"
        Me.GCListeSites.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemCheckEditSite})
        Me.GCListeSites.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeSites})
        '
        'GVListeSites
        '
        Me.GVListeSites.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVListeSites.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVListeSites.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeSites.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeSites.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeSites.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeSites.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCheckSite, Me.GColNSITNUM, Me.GColVSITNOM, Me.GColNSITNUE, Me.GColVSITAD1, Me.GColVSITCP, Me.GColVSITVIL})
        Me.GVListeSites.GridControl = Me.GCListeSites
        Me.GVListeSites.Name = "GVListeSites"
        Me.GVListeSites.OptionsView.ShowAutoFilterRow = True
        Me.GVListeSites.OptionsView.ShowFooter = True
        Me.GVListeSites.OptionsView.ShowGroupPanel = False
        '
        'GColCheckSite
        '
        Me.GColCheckSite.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColCheckSite.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColCheckSite, "GColCheckSite")
        Me.GColCheckSite.ColumnEdit = Me.RepItemCheckEditSite
        Me.GColCheckSite.FieldName = "CHECKSITE"
        Me.GColCheckSite.Name = "GColCheckSite"
        '
        'RepItemCheckEditSite
        '
        resources.ApplyResources(Me.RepItemCheckEditSite, "RepItemCheckEditSite")
        Me.RepItemCheckEditSite.Name = "RepItemCheckEditSite"
        Me.RepItemCheckEditSite.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemCheckEditSite.ValueChecked = 1
        Me.RepItemCheckEditSite.ValueUnchecked = 0
        '
        'GColNSITNUM
        '
        Me.GColNSITNUM.FieldName = "NSITNUM"
        Me.GColNSITNUM.Name = "GColNSITNUM"
        '
        'GColVSITNOM
        '
        Me.GColVSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVSITNOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVSITNOM, "GColVSITNOM")
        Me.GColVSITNOM.FieldName = "VSITNOM"
        Me.GColVSITNOM.Name = "GColVSITNOM"
        Me.GColVSITNOM.OptionsColumn.AllowEdit = False
        Me.GColVSITNOM.OptionsColumn.ReadOnly = True
        Me.GColVSITNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNSITNUE
        '
        Me.GColNSITNUE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNSITNUE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColNSITNUE, "GColNSITNUE")
        Me.GColNSITNUE.FieldName = "NSITNUE"
        Me.GColNSITNUE.Name = "GColNSITNUE"
        Me.GColNSITNUE.OptionsColumn.AllowEdit = False
        Me.GColNSITNUE.OptionsColumn.ReadOnly = True
        Me.GColNSITNUE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVSITAD1
        '
        Me.GColVSITAD1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVSITAD1.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVSITAD1, "GColVSITAD1")
        Me.GColVSITAD1.FieldName = "VSITAD1"
        Me.GColVSITAD1.Name = "GColVSITAD1"
        Me.GColVSITAD1.OptionsColumn.AllowEdit = False
        Me.GColVSITAD1.OptionsColumn.ReadOnly = True
        Me.GColVSITAD1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVSITCP
        '
        Me.GColVSITCP.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVSITCP.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVSITCP, "GColVSITCP")
        Me.GColVSITCP.FieldName = "VSITCP"
        Me.GColVSITCP.Name = "GColVSITCP"
        Me.GColVSITCP.OptionsColumn.AllowEdit = False
        Me.GColVSITCP.OptionsColumn.ReadOnly = True
        Me.GColVSITCP.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVSITVIL
        '
        Me.GColVSITVIL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVSITVIL.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVSITVIL, "GColVSITVIL")
        Me.GColVSITVIL.FieldName = "VSITVIL"
        Me.GColVSITVIL.Name = "GColVSITVIL"
        Me.GColVSITVIL.OptionsColumn.AllowEdit = False
        Me.GColVSITVIL.OptionsColumn.ReadOnly = True
        Me.GColVSITVIL.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'frmDocContratEISelectSite
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpListeSites)
        Me.Controls.Add(Me.GrpContact)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmDocContratEISelectSite"
        Me.GrpActions.ResumeLayout(False)
        Me.GrpContact.ResumeLayout(False)
        CType(Me.GridLookUpContact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpContactView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpListeSites.ResumeLayout(False)
        CType(Me.GCListeSites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeSites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemCheckEditSite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnGenerate As System.Windows.Forms.Button
    Friend WithEvents GrpContact As System.Windows.Forms.GroupBox
    Friend WithEvents GrpListeSites As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDecoche As System.Windows.Forms.Button
    Friend WithEvents BtnCoche As System.Windows.Forms.Button
    Private WithEvents GCListeSites As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeSites As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GridLookUpContact As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridLookUpContactView As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNCCLNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCCLNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCCLFONC As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNSITNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNSITNUE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVSITAD1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVSITCP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVSITVIL As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCheckSite As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemCheckEditSite As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
