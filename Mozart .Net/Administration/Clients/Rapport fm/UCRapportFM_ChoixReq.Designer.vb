<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCRapportFM_ChoixReq
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.GCListeReqByCliRapportFM = New DevExpress.XtraGrid.GridControl()
        Me.GVListeReqByCliRapportFM = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_NIDRAPPORT_FM_CLI_ORDER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NIDRAPPORT_FM_CLI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NIDREQ_RAPPORT_FM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NCOCHE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemChkNCOCHE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GCol_NORDER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VLIBCHAPITRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnUp = New System.Windows.Forms.Button()
        Me.BtnDown = New System.Windows.Forms.Button()
        CType(Me.GCListeReqByCliRapportFM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeReqByCliRapportFM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemChkNCOCHE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblInfo
        '
        Me.LblInfo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo.Location = New System.Drawing.Point(110, 65)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(636, 29)
        Me.LblInfo.TabIndex = 16
        Me.LblInfo.Text = "Label1"
        '
        'GCListeReqByCliRapportFM
        '
        Me.GCListeReqByCliRapportFM.Location = New System.Drawing.Point(113, 110)
        Me.GCListeReqByCliRapportFM.MainView = Me.GVListeReqByCliRapportFM
        Me.GCListeReqByCliRapportFM.Name = "GCListeReqByCliRapportFM"
        Me.GCListeReqByCliRapportFM.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemChkNCOCHE})
        Me.GCListeReqByCliRapportFM.Size = New System.Drawing.Size(1006, 627)
        Me.GCListeReqByCliRapportFM.TabIndex = 15
        Me.GCListeReqByCliRapportFM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeReqByCliRapportFM})
        '
        'GVListeReqByCliRapportFM
        '
        Me.GVListeReqByCliRapportFM.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListeReqByCliRapportFM.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeReqByCliRapportFM.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeReqByCliRapportFM.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeReqByCliRapportFM.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeReqByCliRapportFM.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListeReqByCliRapportFM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_NIDRAPPORT_FM_CLI_ORDER, Me.GCol_NIDRAPPORT_FM_CLI, Me.GCol_NIDREQ_RAPPORT_FM, Me.GCol_NCOCHE, Me.GCol_NORDER, Me.GCol_VLIBCHAPITRE})
        Me.GVListeReqByCliRapportFM.GridControl = Me.GCListeReqByCliRapportFM
        Me.GVListeReqByCliRapportFM.Name = "GVListeReqByCliRapportFM"
        Me.GVListeReqByCliRapportFM.OptionsView.ShowAutoFilterRow = True
        Me.GVListeReqByCliRapportFM.OptionsView.ShowGroupPanel = False
        '
        'GCol_NIDRAPPORT_FM_CLI_ORDER
        '
        Me.GCol_NIDRAPPORT_FM_CLI_ORDER.Caption = "NIDRAPPORT_FM_CLI_ORDER"
        Me.GCol_NIDRAPPORT_FM_CLI_ORDER.FieldName = "NIDRAPPORT_FM_CLI_ORDER"
        Me.GCol_NIDRAPPORT_FM_CLI_ORDER.Name = "GCol_NIDRAPPORT_FM_CLI_ORDER"
        '
        'GCol_NIDRAPPORT_FM_CLI
        '
        Me.GCol_NIDRAPPORT_FM_CLI.Caption = "NIDRAPPORT_FM_CLI"
        Me.GCol_NIDRAPPORT_FM_CLI.FieldName = "NIDRAPPORT_FM_CLI"
        Me.GCol_NIDRAPPORT_FM_CLI.Name = "GCol_NIDRAPPORT_FM_CLI"
        '
        'GCol_NIDREQ_RAPPORT_FM
        '
        Me.GCol_NIDREQ_RAPPORT_FM.FieldName = "NIDREQ_RAPPORT_FM"
        Me.GCol_NIDREQ_RAPPORT_FM.Name = "GCol_NIDREQ_RAPPORT_FM"
        '
        'GCol_NCOCHE
        '
        Me.GCol_NCOCHE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_NCOCHE.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_NCOCHE.Caption = "Sélectionner"
        Me.GCol_NCOCHE.ColumnEdit = Me.RepositoryItemChkNCOCHE
        Me.GCol_NCOCHE.FieldName = "NCOCHE"
        Me.GCol_NCOCHE.Name = "GCol_NCOCHE"
        Me.GCol_NCOCHE.Visible = True
        Me.GCol_NCOCHE.VisibleIndex = 0
        Me.GCol_NCOCHE.Width = 90
        '
        'RepositoryItemChkNCOCHE
        '
        Me.RepositoryItemChkNCOCHE.AutoHeight = False
        Me.RepositoryItemChkNCOCHE.Name = "RepositoryItemChkNCOCHE"
        Me.RepositoryItemChkNCOCHE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemChkNCOCHE.ValueChecked = 1
        Me.RepositoryItemChkNCOCHE.ValueUnchecked = 0
        '
        'GCol_NORDER
        '
        Me.GCol_NORDER.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_NORDER.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_NORDER.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_NORDER.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GCol_NORDER.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_NORDER.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_NORDER.Caption = "Ordre"
        Me.GCol_NORDER.FieldName = "NORDER"
        Me.GCol_NORDER.Name = "GCol_NORDER"
        Me.GCol_NORDER.OptionsColumn.AllowEdit = False
        Me.GCol_NORDER.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom
        Me.GCol_NORDER.Visible = True
        Me.GCol_NORDER.VisibleIndex = 1
        '
        'GCol_VLIBCHAPITRE
        '
        Me.GCol_VLIBCHAPITRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VLIBCHAPITRE.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VLIBCHAPITRE.Caption = "Libellé requete"
        Me.GCol_VLIBCHAPITRE.FieldName = "VLIBCHAPITRE"
        Me.GCol_VLIBCHAPITRE.Name = "GCol_VLIBCHAPITRE"
        Me.GCol_VLIBCHAPITRE.OptionsColumn.AllowEdit = False
        Me.GCol_VLIBCHAPITRE.OptionsColumn.ReadOnly = True
        Me.GCol_VLIBCHAPITRE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_VLIBCHAPITRE.Visible = True
        Me.GCol_VLIBCHAPITRE.VisibleIndex = 2
        Me.GCol_VLIBCHAPITRE.Width = 528
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(386, 40)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Choix des requêtes pour le rapport FM"
        '
        'BtnUp
        '
        Me.BtnUp.Location = New System.Drawing.Point(35, 305)
        Me.BtnUp.Name = "BtnUp"
        Me.BtnUp.Size = New System.Drawing.Size(72, 50)
        Me.BtnUp.TabIndex = 18
        Me.BtnUp.Text = "Monter"
        Me.BtnUp.UseVisualStyleBackColor = True
        '
        'BtnDown
        '
        Me.BtnDown.Location = New System.Drawing.Point(35, 361)
        Me.BtnDown.Name = "BtnDown"
        Me.BtnDown.Size = New System.Drawing.Size(72, 50)
        Me.BtnDown.TabIndex = 19
        Me.BtnDown.Text = "Descendre"
        Me.BtnDown.UseVisualStyleBackColor = True
        '
        'UCRapportFM_ChoixReq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.BtnDown)
        Me.Controls.Add(Me.BtnUp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblInfo)
        Me.Controls.Add(Me.GCListeReqByCliRapportFM)
        Me.Name = "UCRapportFM_ChoixReq"
        Me.Size = New System.Drawing.Size(1161, 767)
        CType(Me.GCListeReqByCliRapportFM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeReqByCliRapportFM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemChkNCOCHE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblInfo As Label
    Private WithEvents GCListeReqByCliRapportFM As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeReqByCliRapportFM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCol_NIDRAPPORT_FM_CLI_ORDER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NIDRAPPORT_FM_CLI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NIDREQ_RAPPORT_FM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NCOCHE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemChkNCOCHE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GCol_NORDER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VLIBCHAPITRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnUp As Button
    Friend WithEvents BtnDown As Button
End Class
