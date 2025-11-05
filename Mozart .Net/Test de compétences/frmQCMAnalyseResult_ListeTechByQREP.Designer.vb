<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQCMAnalyseResult_ListeTechByQREP
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.GVListeRepByTechQ = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Gcol_Rep_NIDFICQCM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_Rep_VQCMREPONSELIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_Rep_BQCMREPONSEVALID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_Rep_BFICQCMREPTECH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCListeTechByQuest = New DevExpress.XtraGrid.GridControl()
        Me.GVListeTechByQuest = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Col_NPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_NIDFICQCM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_NIDQCMQUESTION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_VPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.RepositoryItemHyperLinkEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.RepositoryItemHyperLinkEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        CType(Me.GVListeRepByTechQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCListeTechByQuest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeTechByQuest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GVListeRepByTechQ
        '
        Me.GVListeRepByTechQ.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Gcol_Rep_NIDFICQCM, Me.GCol_Rep_VQCMREPONSELIB, Me.GCol_Rep_BQCMREPONSEVALID, Me.GCol_Rep_BFICQCMREPTECH})
        Me.GVListeRepByTechQ.GridControl = Me.GCListeTechByQuest
        Me.GVListeRepByTechQ.Name = "GVListeRepByTechQ"
        Me.GVListeRepByTechQ.OptionsView.ShowGroupPanel = False
        '
        'Gcol_Rep_NIDFICQCM
        '
        Me.Gcol_Rep_NIDFICQCM.Caption = "Rep_NIDFICQCM"
        Me.Gcol_Rep_NIDFICQCM.Name = "Gcol_Rep_NIDFICQCM"
        '
        'GCol_Rep_VQCMREPONSELIB
        '
        Me.GCol_Rep_VQCMREPONSELIB.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GCol_Rep_VQCMREPONSELIB.AppearanceHeader.Options.UseFont = True
        Me.GCol_Rep_VQCMREPONSELIB.AppearanceHeader.Options.UseTextOptions = True
        Me.GCol_Rep_VQCMREPONSELIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_Rep_VQCMREPONSELIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_Rep_VQCMREPONSELIB.Caption = "Libellé Réponse"
        Me.GCol_Rep_VQCMREPONSELIB.FieldName = "VQCMREPONSELIB"
        Me.GCol_Rep_VQCMREPONSELIB.Name = "GCol_Rep_VQCMREPONSELIB"
        Me.GCol_Rep_VQCMREPONSELIB.OptionsColumn.AllowEdit = False
        Me.GCol_Rep_VQCMREPONSELIB.OptionsColumn.ReadOnly = True
        Me.GCol_Rep_VQCMREPONSELIB.Visible = True
        Me.GCol_Rep_VQCMREPONSELIB.VisibleIndex = 0
        Me.GCol_Rep_VQCMREPONSELIB.Width = 600
        '
        'GCol_Rep_BQCMREPONSEVALID
        '
        Me.GCol_Rep_BQCMREPONSEVALID.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GCol_Rep_BQCMREPONSEVALID.AppearanceHeader.Options.UseFont = True
        Me.GCol_Rep_BQCMREPONSEVALID.AppearanceHeader.Options.UseTextOptions = True
        Me.GCol_Rep_BQCMREPONSEVALID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_Rep_BQCMREPONSEVALID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_Rep_BQCMREPONSEVALID.Caption = "Réponse conforme"
        Me.GCol_Rep_BQCMREPONSEVALID.FieldName = "BQCMREPONSEVALID"
        Me.GCol_Rep_BQCMREPONSEVALID.Name = "GCol_Rep_BQCMREPONSEVALID"
        Me.GCol_Rep_BQCMREPONSEVALID.OptionsColumn.AllowEdit = False
        Me.GCol_Rep_BQCMREPONSEVALID.OptionsColumn.ReadOnly = True
        Me.GCol_Rep_BQCMREPONSEVALID.Visible = True
        Me.GCol_Rep_BQCMREPONSEVALID.VisibleIndex = 1
        Me.GCol_Rep_BQCMREPONSEVALID.Width = 244
        '
        'GCol_Rep_BFICQCMREPTECH
        '
        Me.GCol_Rep_BFICQCMREPTECH.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GCol_Rep_BFICQCMREPTECH.AppearanceHeader.Options.UseFont = True
        Me.GCol_Rep_BFICQCMREPTECH.AppearanceHeader.Options.UseTextOptions = True
        Me.GCol_Rep_BFICQCMREPTECH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_Rep_BFICQCMREPTECH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_Rep_BFICQCMREPTECH.Caption = "Réponse de la personne"
        Me.GCol_Rep_BFICQCMREPTECH.FieldName = "BFICQCMREPTECH"
        Me.GCol_Rep_BFICQCMREPTECH.Name = "GCol_Rep_BFICQCMREPTECH"
        Me.GCol_Rep_BFICQCMREPTECH.OptionsColumn.AllowEdit = False
        Me.GCol_Rep_BFICQCMREPTECH.OptionsColumn.ReadOnly = True
        Me.GCol_Rep_BFICQCMREPTECH.Visible = True
        Me.GCol_Rep_BFICQCMREPTECH.VisibleIndex = 2
        Me.GCol_Rep_BFICQCMREPTECH.Width = 249
        '
        'GCListeTechByQuest
        '
        GridLevelNode1.LevelTemplate = Me.GVListeRepByTechQ
        GridLevelNode1.RelationName = "Détail réponses"
        Me.GCListeTechByQuest.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GCListeTechByQuest.Location = New System.Drawing.Point(90, 41)
        Me.GCListeTechByQuest.MainView = Me.GVListeTechByQuest
        Me.GCListeTechByQuest.Name = "GCListeTechByQuest"
        Me.GCListeTechByQuest.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemHyperLinkEdit2, Me.RepositoryItemHyperLinkEdit3})
        Me.GCListeTechByQuest.Size = New System.Drawing.Size(1171, 732)
        Me.GCListeTechByQuest.TabIndex = 53
        Me.GCListeTechByQuest.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeTechByQuest, Me.GVListeRepByTechQ})
        '
        'GVListeTechByQuest
        '
        Me.GVListeTechByQuest.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListeTechByQuest.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeTechByQuest.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeTechByQuest.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeTechByQuest.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeTechByQuest.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListeTechByQuest.ColumnPanelRowHeight = 50
        Me.GVListeTechByQuest.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Col_NPERNUM, Me.Col_NIDFICQCM, Me.Col_NIDQCMQUESTION, Me.Col_VPERNOM})
        Me.GVListeTechByQuest.GridControl = Me.GCListeTechByQuest
        Me.GVListeTechByQuest.Name = "GVListeTechByQuest"
        Me.GVListeTechByQuest.OptionsBehavior.ReadOnly = True
        Me.GVListeTechByQuest.OptionsView.ShowAutoFilterRow = True
        Me.GVListeTechByQuest.OptionsView.ShowFooter = True
        Me.GVListeTechByQuest.OptionsView.ShowGroupPanel = False
        '
        'Col_NPERNUM
        '
        Me.Col_NPERNUM.Caption = "NPERNUM"
        Me.Col_NPERNUM.FieldName = "NPERNUM"
        Me.Col_NPERNUM.Name = "Col_NPERNUM"
        '
        'Col_NIDFICQCM
        '
        Me.Col_NIDFICQCM.Caption = "NIDFICQCM"
        Me.Col_NIDFICQCM.FieldName = "NIDFICQCM"
        Me.Col_NIDFICQCM.Name = "Col_NIDFICQCM"
        Me.Col_NIDFICQCM.OptionsColumn.AllowEdit = False
        Me.Col_NIDFICQCM.Width = 50
        '
        'Col_NIDQCMQUESTION
        '
        Me.Col_NIDQCMQUESTION.Caption = "NIDQCMQUESTION"
        Me.Col_NIDQCMQUESTION.FieldName = "NIDQCMQUESTION"
        Me.Col_NIDQCMQUESTION.Name = "Col_NIDQCMQUESTION"
        Me.Col_NIDQCMQUESTION.OptionsColumn.AllowEdit = False
        Me.Col_NIDQCMQUESTION.Width = 549
        '
        'Col_VPERNOM
        '
        Me.Col_VPERNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Col_VPERNOM.AppearanceHeader.Options.UseForeColor = True
        Me.Col_VPERNOM.Caption = "Nom"
        Me.Col_VPERNOM.FieldName = "VPERNOM"
        Me.Col_VPERNOM.Name = "Col_VPERNOM"
        Me.Col_VPERNOM.OptionsColumn.AllowEdit = False
        Me.Col_VPERNOM.OptionsColumn.ReadOnly = True
        Me.Col_VPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Col_VPERNOM.Visible = True
        Me.Col_VPERNOM.VisibleIndex = 0
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        Me.RepositoryItemHyperLinkEdit1.SingleClick = True
        '
        'RepositoryItemHyperLinkEdit2
        '
        Me.RepositoryItemHyperLinkEdit2.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit2.Name = "RepositoryItemHyperLinkEdit2"
        '
        'RepositoryItemHyperLinkEdit3
        '
        Me.RepositoryItemHyperLinkEdit3.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit3.Name = "RepositoryItemHyperLinkEdit3"
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(12, 710)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(72, 59)
        Me.BtnFermer.TabIndex = 54
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        Me.LblTitre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(88, 9)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(1176, 29)
        Me.LblTitre.TabIndex = 55
        Me.LblTitre.Text = "Liste des personnes ayant répondu correctement"
        '
        'frmQCMAnalyseResult_ListeTechByQREP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1276, 781)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.GCListeTechByQuest)
        Me.Name = "frmQCMAnalyseResult_ListeTechByQREP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Détail réponse par question"
        CType(Me.GVListeRepByTechQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCListeTechByQuest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeTechByQuest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents GCListeTechByQuest As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeTechByQuest As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Col_NPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_NIDFICQCM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_NIDQCMQUESTION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemHyperLinkEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents BtnFermer As Button
    Friend WithEvents LblTitre As Label
    Friend WithEvents GVListeRepByTechQ As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Col_VPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Gcol_Rep_NIDFICQCM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_Rep_VQCMREPONSELIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_Rep_BQCMREPONSEVALID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_Rep_BFICQCMREPTECH As DevExpress.XtraGrid.Columns.GridColumn
End Class
