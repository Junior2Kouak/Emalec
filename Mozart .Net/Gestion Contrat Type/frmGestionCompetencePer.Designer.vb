<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionCompetencePer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionCompetencePer))
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GrpboxActions = New System.Windows.Forms.GroupBox()
        Me.BtnListeArchives = New System.Windows.Forms.Button()
        Me.BtnArchiver = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnModif = New System.Windows.Forms.Button()
        Me.PvtGridCompetence = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PvtRowNIDDOM_COMPET = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PvtRowNIDCOMPET = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PvtDataNIDCOMPETBYFONC = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PvtRowVLIBDOM_COMPET = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PvtRowVLIBCOMPET = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PvtColVTYPELIB = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PvtDataBAFFECTE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.RepItemChkBAFFECTE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GrpboxActions.SuspendLayout()
        CType(Me.PvtGridCompetence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkBAFFECTE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'PvtGridCompetence
        '
        Me.PvtGridCompetence.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PvtRowNIDDOM_COMPET, Me.PvtRowNIDCOMPET, Me.PvtDataNIDCOMPETBYFONC, Me.PvtRowVLIBDOM_COMPET, Me.PvtRowVLIBCOMPET, Me.PvtColVTYPELIB, Me.PvtDataBAFFECTE})
        resources.ApplyResources(Me.PvtGridCompetence, "PvtGridCompetence")
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
        'PvtRowNIDDOM_COMPET
        '
        Me.PvtRowNIDDOM_COMPET.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PvtRowNIDDOM_COMPET.AreaIndex = 2
        Me.PvtRowNIDDOM_COMPET.FieldName = "NIDDOM_COMPET"
        Me.PvtRowNIDDOM_COMPET.Name = "PvtRowNIDDOM_COMPET"
        Me.PvtRowNIDDOM_COMPET.Visible = False
        resources.ApplyResources(Me.PvtRowNIDDOM_COMPET, "PvtRowNIDDOM_COMPET")
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
        Me.PvtColVTYPELIB.Appearance.Value.Font = CType(resources.GetObject("PvtColVTYPELIB.Appearance.Value.Font"), System.Drawing.Font)
        Me.PvtColVTYPELIB.Appearance.Value.Options.UseFont = True
        Me.PvtColVTYPELIB.Appearance.Value.Options.UseTextOptions = True
        Me.PvtColVTYPELIB.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PvtColVTYPELIB.Appearance.Value.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PvtColVTYPELIB.Appearance.Value.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
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
        '
        'RepItemChkBAFFECTE
        '
        resources.ApplyResources(Me.RepItemChkBAFFECTE, "RepItemChkBAFFECTE")
        Me.RepItemChkBAFFECTE.Name = "RepItemChkBAFFECTE"
        Me.RepItemChkBAFFECTE.ValueChecked = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepItemChkBAFFECTE.ValueUnchecked = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'frmGestionCompetencePer
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.PvtGridCompetence)
        Me.Controls.Add(Me.GrpboxActions)
        Me.Name = "frmGestionCompetencePer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpboxActions.ResumeLayout(False)
        CType(Me.PvtGridCompetence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkBAFFECTE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents GrpboxActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnModif As System.Windows.Forms.Button
    Friend WithEvents BtnListeArchives As System.Windows.Forms.Button
    Friend WithEvents BtnArchiver As System.Windows.Forms.Button
    Friend WithEvents PvtGridCompetence As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PvtDataNIDCOMPETBYFONC As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents RepItemChkBAFFECTE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PvtRowVLIBDOM_COMPET As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PvtRowVLIBCOMPET As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PvtColVTYPELIB As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PvtDataBAFFECTE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PvtRowNIDDOM_COMPET As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PvtRowNIDCOMPET As DevExpress.XtraPivotGrid.PivotGridField

End Class
