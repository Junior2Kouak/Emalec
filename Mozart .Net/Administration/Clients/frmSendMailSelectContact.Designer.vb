<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSendMailSelectContact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSendMailSelectContact))
        Me.GCListeContact = New DevExpress.XtraGrid.GridControl()
        Me.GVListeContact = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColCheckCCL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemCheckEditCCLSelect = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GColNCCLNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCCLNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCCLFONC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCCLMAIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnSendContrat = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        CType(Me.GCListeContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemCheckEditCCLSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCListeContact
        '
        resources.ApplyResources(Me.GCListeContact, "GCListeContact")
        Me.GCListeContact.MainView = Me.GVListeContact
        Me.GCListeContact.Name = "GCListeContact"
        Me.GCListeContact.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemCheckEditCCLSelect})
        Me.GCListeContact.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeContact})
        '
        'GVListeContact
        '
        Me.GVListeContact.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVListeContact.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVListeContact.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeContact.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeContact.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeContact.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeContact.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListeContact.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCheckCCL, Me.GColNCCLNUM, Me.GColVCCLNOM, Me.GColVCCLFONC, Me.GColVCCLMAIL})
        Me.GVListeContact.GridControl = Me.GCListeContact
        Me.GVListeContact.Name = "GVListeContact"
        Me.GVListeContact.OptionsView.ShowAutoFilterRow = True
        Me.GVListeContact.OptionsView.ShowFooter = True
        Me.GVListeContact.OptionsView.ShowGroupPanel = False
        '
        'GColCheckCCL
        '
        Me.GColCheckCCL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColCheckCCL.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColCheckCCL, "GColCheckCCL")
        Me.GColCheckCCL.ColumnEdit = Me.RepItemCheckEditCCLSelect
        Me.GColCheckCCL.FieldName = "CHECKCCL"
        Me.GColCheckCCL.Name = "GColCheckCCL"
        '
        'RepItemCheckEditCCLSelect
        '
        resources.ApplyResources(Me.RepItemCheckEditCCLSelect, "RepItemCheckEditCCLSelect")
        Me.RepItemCheckEditCCLSelect.Name = "RepItemCheckEditCCLSelect"
        Me.RepItemCheckEditCCLSelect.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemCheckEditCCLSelect.ValueChecked = CType(1, Short)
        Me.RepItemCheckEditCCLSelect.ValueUnchecked = CType(0, Short)
        '
        'GColNCCLNUM
        '
        Me.GColNCCLNUM.FieldName = "NCCLNUM"
        Me.GColNCCLNUM.Name = "GColNCCLNUM"
        '
        'GColVCCLNOM
        '
        Me.GColVCCLNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVCCLNOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVCCLNOM, "GColVCCLNOM")
        Me.GColVCCLNOM.FieldName = "VCCLNOM"
        Me.GColVCCLNOM.Name = "GColVCCLNOM"
        Me.GColVCCLNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVCCLFONC
        '
        Me.GColVCCLFONC.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVCCLFONC.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVCCLFONC, "GColVCCLFONC")
        Me.GColVCCLFONC.FieldName = "VCCLFONC"
        Me.GColVCCLFONC.Name = "GColVCCLFONC"
        Me.GColVCCLFONC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVCCLMAIL
        '
        Me.GColVCCLMAIL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVCCLMAIL.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVCCLMAIL, "GColVCCLMAIL")
        Me.GColVCCLMAIL.FieldName = "VCCLMAIL"
        Me.GColVCCLMAIL.Name = "GColVCCLMAIL"
        Me.GColVCCLMAIL.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnSendContrat)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnSendContrat
        '
        resources.ApplyResources(Me.BtnSendContrat, "BtnSendContrat")
        Me.BtnSendContrat.Name = "BtnSendContrat"
        Me.BtnSendContrat.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'frmSendMailSelectContact
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GCListeContact)
        Me.Name = "frmSendMailSelectContact"
        CType(Me.GCListeContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemCheckEditCCLSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents BtnSendContrat As System.Windows.Forms.Button
    Private WithEvents GCListeContact As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeContact As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColVCCLNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCCLFONC As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCCLMAIL As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNCCLNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCheckCCL As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemCheckEditCCLSelect As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
