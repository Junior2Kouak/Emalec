<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionDomaineCompetence
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionDomaineCompetence))
        Me.GCDomaineCompet = New DevExpress.XtraGrid.GridControl()
        Me.GVListeDomaineCompet = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNIDDOM_COMPET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVLIBDOM_COMPET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemCboOrder = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GrpboxActions = New System.Windows.Forms.GroupBox()
        Me.BtnListeArchives = New System.Windows.Forms.Button()
        Me.BtnArchiver = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnModif = New System.Windows.Forms.Button()
        CType(Me.GCDomaineCompet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeDomaineCompet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemCboOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpboxActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCDomaineCompet
        '
        resources.ApplyResources(Me.GCDomaineCompet, "GCDomaineCompet")
        Me.GCDomaineCompet.MainView = Me.GVListeDomaineCompet
        Me.GCDomaineCompet.Name = "GCDomaineCompet"
        Me.GCDomaineCompet.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemCboOrder})
        Me.GCDomaineCompet.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeDomaineCompet})
        '
        'GVListeDomaineCompet
        '
        Me.GVListeDomaineCompet.Appearance.Row.BackColor = CType(resources.GetObject("GVListeDomaineCompet.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVListeDomaineCompet.Appearance.Row.Options.UseBackColor = True
        Me.GVListeDomaineCompet.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVListeDomaineCompet.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVListeDomaineCompet.Appearance.SelectedRow.Font = CType(resources.GetObject("GVListeDomaineCompet.Appearance.SelectedRow.Font"), System.Drawing.Font)
        Me.GVListeDomaineCompet.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListeDomaineCompet.Appearance.SelectedRow.Options.UseFont = True
        Me.GVListeDomaineCompet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColIDTMP, Me.GColNIDDOM_COMPET, Me.GColVLIBDOM_COMPET})
        Me.GVListeDomaineCompet.GridControl = Me.GCDomaineCompet
        Me.GVListeDomaineCompet.Name = "GVListeDomaineCompet"
        Me.GVListeDomaineCompet.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVListeDomaineCompet.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVListeDomaineCompet.OptionsBehavior.Editable = False
        Me.GVListeDomaineCompet.OptionsBehavior.ReadOnly = True
        Me.GVListeDomaineCompet.OptionsCustomization.AllowSort = False
        Me.GVListeDomaineCompet.OptionsView.ShowAutoFilterRow = True
        Me.GVListeDomaineCompet.OptionsView.ShowGroupPanel = False
        Me.GVListeDomaineCompet.RowHeight = 30
        '
        'GColIDTMP
        '
        resources.ApplyResources(Me.GColIDTMP, "GColIDTMP")
        Me.GColIDTMP.FieldName = "IDTMP"
        Me.GColIDTMP.Name = "GColIDTMP"
        Me.GColIDTMP.OptionsColumn.ReadOnly = True
        '
        'GColNIDDOM_COMPET
        '
        resources.ApplyResources(Me.GColNIDDOM_COMPET, "GColNIDDOM_COMPET")
        Me.GColNIDDOM_COMPET.FieldName = "NIDDOM_COMPET"
        Me.GColNIDDOM_COMPET.Name = "GColNIDDOM_COMPET"
        Me.GColNIDDOM_COMPET.OptionsColumn.ReadOnly = True
        '
        'GColVLIBDOM_COMPET
        '
        Me.GColVLIBDOM_COMPET.AppearanceCell.Font = CType(resources.GetObject("GColVLIBDOM_COMPET.AppearanceCell.Font"), System.Drawing.Font)
        Me.GColVLIBDOM_COMPET.AppearanceCell.Options.UseFont = True
        Me.GColVLIBDOM_COMPET.AppearanceHeader.Font = CType(resources.GetObject("GColVLIBDOM_COMPET.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVLIBDOM_COMPET.AppearanceHeader.Options.UseFont = True
        Me.GColVLIBDOM_COMPET.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVLIBDOM_COMPET.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVLIBDOM_COMPET.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVLIBDOM_COMPET, "GColVLIBDOM_COMPET")
        Me.GColVLIBDOM_COMPET.FieldName = "VLIBDOM_COMPET"
        Me.GColVLIBDOM_COMPET.Name = "GColVLIBDOM_COMPET"
        Me.GColVLIBDOM_COMPET.OptionsColumn.AllowEdit = False
        Me.GColVLIBDOM_COMPET.OptionsColumn.ReadOnly = True
        Me.GColVLIBDOM_COMPET.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'RepItemCboOrder
        '
        Me.RepItemCboOrder.Appearance.Font = CType(resources.GetObject("RepItemCboOrder.Appearance.Font"), System.Drawing.Font)
        Me.RepItemCboOrder.Appearance.Options.UseFont = True
        Me.RepItemCboOrder.Appearance.Options.UseTextOptions = True
        Me.RepItemCboOrder.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepItemCboOrder.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.RepItemCboOrder.AppearanceDropDown.BackColor = CType(resources.GetObject("RepItemCboOrder.AppearanceDropDown.BackColor"), System.Drawing.Color)
        Me.RepItemCboOrder.AppearanceDropDown.Font = CType(resources.GetObject("RepItemCboOrder.AppearanceDropDown.Font"), System.Drawing.Font)
        Me.RepItemCboOrder.AppearanceDropDown.Options.UseBackColor = True
        Me.RepItemCboOrder.AppearanceDropDown.Options.UseFont = True
        Me.RepItemCboOrder.AppearanceDropDown.Options.UseTextOptions = True
        Me.RepItemCboOrder.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.RepItemCboOrder, "RepItemCboOrder")
        Me.RepItemCboOrder.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemCboOrder.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepItemCboOrder.Name = "RepItemCboOrder"
        '
        'BtnClose
        '
        resources.ApplyResources(Me.BtnClose, "BtnClose")
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'GrpboxActions
        '
        Me.GrpboxActions.Controls.Add(Me.BtnListeArchives)
        Me.GrpboxActions.Controls.Add(Me.BtnArchiver)
        Me.GrpboxActions.Controls.Add(Me.BtnNew)
        Me.GrpboxActions.Controls.Add(Me.BtnModif)
        Me.GrpboxActions.Controls.Add(Me.BtnClose)
        resources.ApplyResources(Me.GrpboxActions, "GrpboxActions")
        Me.GrpboxActions.Name = "GrpboxActions"
        Me.GrpboxActions.TabStop = False
        '
        'BtnListeArchives
        '
        resources.ApplyResources(Me.BtnListeArchives, "BtnListeArchives")
        Me.BtnListeArchives.Name = "BtnListeArchives"
        Me.BtnListeArchives.UseVisualStyleBackColor = True
        '
        'BtnArchiver
        '
        resources.ApplyResources(Me.BtnArchiver, "BtnArchiver")
        Me.BtnArchiver.Name = "BtnArchiver"
        Me.BtnArchiver.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        resources.ApplyResources(Me.BtnNew, "BtnNew")
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnModif
        '
        resources.ApplyResources(Me.BtnModif, "BtnModif")
        Me.BtnModif.Name = "BtnModif"
        Me.BtnModif.UseVisualStyleBackColor = True
        '
        'frmGestionDomaineCompetence
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GCDomaineCompet)
        Me.Controls.Add(Me.GrpboxActions)
        Me.Name = "frmGestionDomaineCompetence"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCDomaineCompet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeDomaineCompet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemCboOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpboxActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents GrpboxActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnModif As System.Windows.Forms.Button
    Friend WithEvents BtnListeArchives As System.Windows.Forms.Button
    Friend WithEvents BtnArchiver As System.Windows.Forms.Button
    Private WithEvents GCDomaineCompet As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeDomaineCompet As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNIDDOM_COMPET As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVLIBDOM_COMPET As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemCboOrder As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
End Class
