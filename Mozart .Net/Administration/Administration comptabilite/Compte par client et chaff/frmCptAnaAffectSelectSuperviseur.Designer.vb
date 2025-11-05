<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCptAnaAffectSelectSuperviseur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCptAnaAffectSelectSuperviseur))
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnValidate = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GCListePer = New DevExpress.XtraGrid.GridControl()
        Me.GVListePer = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNCOCHE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheck_NCOCHE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GCol_NPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCOl_VPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VPERPRE = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GCListePer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListePer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheck_NCOCHE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.BackgroundImage = Global.MozartNet.My.Resources.Resources._stop
        resources.ApplyResources(Me.BtnCancel, "BtnCancel")
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnValidate
        '
        Me.BtnValidate.BackgroundImage = Global.MozartNet.My.Resources.Resources.clean
        resources.ApplyResources(Me.BtnValidate, "BtnValidate")
        Me.BtnValidate.Name = "BtnValidate"
        Me.BtnValidate.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GCListePer
        '
        resources.ApplyResources(Me.GCListePer, "GCListePer")
        Me.GCListePer.MainView = Me.GVListePer
        Me.GCListePer.Name = "GCListePer"
        Me.GCListePer.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheck_NCOCHE})
        Me.GCListePer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListePer})
        '
        'GVListePer
        '
        Me.GVListePer.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVListePer.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVListePer.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListePer.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListePer.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListePer.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListePer.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListePer.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNCOCHE, Me.GCol_NPERNUM, Me.GCOl_VPERNOM, Me.GCol_VPERPRE})
        Me.GVListePer.GridControl = Me.GCListePer
        Me.GVListePer.Name = "GVListePer"
        Me.GVListePer.OptionsView.ShowAutoFilterRow = True
        Me.GVListePer.OptionsView.ShowGroupPanel = False
        '
        'GColNCOCHE
        '
        Me.GColNCOCHE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNCOCHE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColNCOCHE, "GColNCOCHE")
        Me.GColNCOCHE.ColumnEdit = Me.RepositoryItemCheck_NCOCHE
        Me.GColNCOCHE.FieldName = "NCOCHE"
        Me.GColNCOCHE.Name = "GColNCOCHE"
        '
        'RepositoryItemCheck_NCOCHE
        '
        resources.ApplyResources(Me.RepositoryItemCheck_NCOCHE, "RepositoryItemCheck_NCOCHE")
        Me.RepositoryItemCheck_NCOCHE.Name = "RepositoryItemCheck_NCOCHE"
        Me.RepositoryItemCheck_NCOCHE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheck_NCOCHE.ValueChecked = 1
        Me.RepositoryItemCheck_NCOCHE.ValueUnchecked = 0
        '
        'GCol_NPERNUM
        '
        resources.ApplyResources(Me.GCol_NPERNUM, "GCol_NPERNUM")
        Me.GCol_NPERNUM.FieldName = "NPERNUM_PARENT"
        Me.GCol_NPERNUM.Name = "GCol_NPERNUM"
        '
        'GCOl_VPERNOM
        '
        Me.GCOl_VPERNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCOl_VPERNOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GCOl_VPERNOM, "GCOl_VPERNOM")
        Me.GCOl_VPERNOM.FieldName = "VPERNOM"
        Me.GCOl_VPERNOM.Name = "GCOl_VPERNOM"
        Me.GCOl_VPERNOM.OptionsColumn.AllowEdit = False
        Me.GCOl_VPERNOM.OptionsColumn.ReadOnly = True
        Me.GCOl_VPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GCol_VPERPRE
        '
        Me.GCol_VPERPRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VPERPRE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GCol_VPERPRE, "GCol_VPERPRE")
        Me.GCol_VPERPRE.FieldName = "VPERPRE"
        Me.GCol_VPERPRE.Name = "GCol_VPERPRE"
        Me.GCol_VPERPRE.OptionsColumn.AllowEdit = False
        Me.GCol_VPERPRE.OptionsColumn.ReadOnly = True
        Me.GCol_VPERPRE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'frmCptAnaAffectSelectSuperviseur
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GCListePer)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnValidate)
        Me.Name = "frmCptAnaAffectSelectSuperviseur"
        CType(Me.GCListePer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListePer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheck_NCOCHE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnValidate As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GCListePer As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVListePer As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCol_NPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCOl_VPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNCOCHE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheck_NCOCHE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GCol_VPERPRE As DevExpress.XtraGrid.Columns.GridColumn
End Class
