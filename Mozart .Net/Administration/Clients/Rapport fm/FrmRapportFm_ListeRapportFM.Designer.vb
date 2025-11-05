<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRapportFm_ListeRapportFM
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
        Me.GCListeRapportFM = New DevExpress.XtraGrid.GridControl()
        Me.GVListeRapportFM = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_NIDRAPPORT_FM_CLI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_DDATEDEB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_DDATEFIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VLANGUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_DDATMOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_DDATSEND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VMAILDEST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VRAPPORT_FM_TITRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VETAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.ChkArchives = New System.Windows.Forms.CheckBox()
        Me.BtnArchiver = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnSendTo = New System.Windows.Forms.Button()
        Me.BtnAddRapportFM = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        CType(Me.GCListeRapportFM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeRapportFM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCListeRapportFM
        '
        Me.GCListeRapportFM.Location = New System.Drawing.Point(175, 65)
        Me.GCListeRapportFM.MainView = Me.GVListeRapportFM
        Me.GCListeRapportFM.Name = "GCListeRapportFM"
        Me.GCListeRapportFM.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1})
        Me.GCListeRapportFM.Size = New System.Drawing.Size(1343, 827)
        Me.GCListeRapportFM.TabIndex = 11
        Me.GCListeRapportFM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeRapportFM})
        '
        'GVListeRapportFM
        '
        Me.GVListeRapportFM.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListeRapportFM.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeRapportFM.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeRapportFM.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeRapportFM.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeRapportFM.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListeRapportFM.ColumnPanelRowHeight = 60
        Me.GVListeRapportFM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_NIDRAPPORT_FM_CLI, Me.GCol_NCLINUM, Me.GCol_DDATEDEB, Me.GCol_DDATEFIN, Me.GCol_VPERNOM, Me.GCol_VLANGUE, Me.GCol_DDATMOD, Me.GCol_DDATSEND, Me.GCol_VMAILDEST, Me.GCol_VRAPPORT_FM_TITRE, Me.GCol_VETAT, Me.GridColumn1})
        Me.GVListeRapportFM.GridControl = Me.GCListeRapportFM
        Me.GVListeRapportFM.Name = "GVListeRapportFM"
        Me.GVListeRapportFM.OptionsBehavior.ReadOnly = True
        Me.GVListeRapportFM.OptionsView.ShowAutoFilterRow = True
        Me.GVListeRapportFM.OptionsView.ShowGroupPanel = False
        '
        'GCol_NIDRAPPORT_FM_CLI
        '
        Me.GCol_NIDRAPPORT_FM_CLI.FieldName = "NIDRAPPORT_FM_CLI"
        Me.GCol_NIDRAPPORT_FM_CLI.Name = "GCol_NIDRAPPORT_FM_CLI"
        '
        'GCol_NCLINUM
        '
        Me.GCol_NCLINUM.FieldName = "NCLINUM"
        Me.GCol_NCLINUM.Name = "GCol_NCLINUM"
        Me.GCol_NCLINUM.OptionsColumn.AllowEdit = False
        Me.GCol_NCLINUM.OptionsColumn.ReadOnly = True
        Me.GCol_NCLINUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GCol_DDATEDEB
        '
        Me.GCol_DDATEDEB.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_DDATEDEB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_DDATEDEB.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_DDATEDEB.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GCol_DDATEDEB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_DDATEDEB.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_DDATEDEB.Caption = "Date début"
        Me.GCol_DDATEDEB.FieldName = "DDATEDEB"
        Me.GCol_DDATEDEB.Name = "GCol_DDATEDEB"
        Me.GCol_DDATEDEB.OptionsColumn.AllowEdit = False
        Me.GCol_DDATEDEB.OptionsColumn.ReadOnly = True
        Me.GCol_DDATEDEB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_DDATEDEB.Visible = True
        Me.GCol_DDATEDEB.VisibleIndex = 0
        Me.GCol_DDATEDEB.Width = 98
        '
        'GCol_DDATEFIN
        '
        Me.GCol_DDATEFIN.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_DDATEFIN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_DDATEFIN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_DDATEFIN.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GCol_DDATEFIN.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_DDATEFIN.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_DDATEFIN.Caption = "Date fin"
        Me.GCol_DDATEFIN.FieldName = "DDATEFIN"
        Me.GCol_DDATEFIN.Name = "GCol_DDATEFIN"
        Me.GCol_DDATEFIN.OptionsColumn.AllowEdit = False
        Me.GCol_DDATEFIN.OptionsColumn.ReadOnly = True
        Me.GCol_DDATEFIN.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_DDATEFIN.Visible = True
        Me.GCol_DDATEFIN.VisibleIndex = 1
        Me.GCol_DDATEFIN.Width = 107
        '
        'GCol_VPERNOM
        '
        Me.GCol_VPERNOM.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_VPERNOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_VPERNOM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_VPERNOM.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GCol_VPERNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VPERNOM.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VPERNOM.Caption = "Dernière modification"
        Me.GCol_VPERNOM.FieldName = "VPERNOM"
        Me.GCol_VPERNOM.Name = "GCol_VPERNOM"
        Me.GCol_VPERNOM.OptionsColumn.AllowEdit = False
        Me.GCol_VPERNOM.OptionsColumn.ReadOnly = True
        Me.GCol_VPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_VPERNOM.Visible = True
        Me.GCol_VPERNOM.VisibleIndex = 2
        Me.GCol_VPERNOM.Width = 100
        '
        'GCol_VLANGUE
        '
        Me.GCol_VLANGUE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VLANGUE.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VLANGUE.Caption = "Langue"
        Me.GCol_VLANGUE.FieldName = "VLANGUE"
        Me.GCol_VLANGUE.Name = "GCol_VLANGUE"
        Me.GCol_VLANGUE.OptionsColumn.AllowEdit = False
        Me.GCol_VLANGUE.OptionsColumn.ReadOnly = True
        Me.GCol_VLANGUE.Visible = True
        Me.GCol_VLANGUE.VisibleIndex = 4
        Me.GCol_VLANGUE.Width = 104
        '
        'GCol_DDATMOD
        '
        Me.GCol_DDATMOD.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_DDATMOD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_DDATMOD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_DDATMOD.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GCol_DDATMOD.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_DDATMOD.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_DDATMOD.Caption = "Date dernière modification"
        Me.GCol_DDATMOD.FieldName = "DDATMOD"
        Me.GCol_DDATMOD.Name = "GCol_DDATMOD"
        Me.GCol_DDATMOD.OptionsColumn.AllowEdit = False
        Me.GCol_DDATMOD.OptionsColumn.ReadOnly = True
        Me.GCol_DDATMOD.Visible = True
        Me.GCol_DDATMOD.VisibleIndex = 3
        Me.GCol_DDATMOD.Width = 113
        '
        'GCol_DDATSEND
        '
        Me.GCol_DDATSEND.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_DDATSEND.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_DDATSEND.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_DDATSEND.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GCol_DDATSEND.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_DDATSEND.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_DDATSEND.Caption = "Date dernière envoi"
        Me.GCol_DDATSEND.FieldName = "DDATSEND"
        Me.GCol_DDATSEND.Name = "GCol_DDATSEND"
        Me.GCol_DDATSEND.OptionsColumn.AllowEdit = False
        Me.GCol_DDATSEND.OptionsColumn.ReadOnly = True
        Me.GCol_DDATSEND.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_DDATSEND.Visible = True
        Me.GCol_DDATSEND.VisibleIndex = 7
        Me.GCol_DDATSEND.Width = 116
        '
        'GCol_VMAILDEST
        '
        Me.GCol_VMAILDEST.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_VMAILDEST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_VMAILDEST.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_VMAILDEST.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GCol_VMAILDEST.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VMAILDEST.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VMAILDEST.Caption = "Destinataire(s) du dernier envoi"
        Me.GCol_VMAILDEST.FieldName = "VMAILDEST"
        Me.GCol_VMAILDEST.Name = "GCol_VMAILDEST"
        Me.GCol_VMAILDEST.OptionsColumn.AllowEdit = False
        Me.GCol_VMAILDEST.OptionsColumn.ReadOnly = True
        Me.GCol_VMAILDEST.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_VMAILDEST.Visible = True
        Me.GCol_VMAILDEST.VisibleIndex = 8
        Me.GCol_VMAILDEST.Width = 144
        '
        'GCol_VRAPPORT_FM_TITRE
        '
        Me.GCol_VRAPPORT_FM_TITRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VRAPPORT_FM_TITRE.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VRAPPORT_FM_TITRE.Caption = "Titre"
        Me.GCol_VRAPPORT_FM_TITRE.FieldName = "VRAPPORT_FM_TITRE"
        Me.GCol_VRAPPORT_FM_TITRE.Name = "GCol_VRAPPORT_FM_TITRE"
        Me.GCol_VRAPPORT_FM_TITRE.Visible = True
        Me.GCol_VRAPPORT_FM_TITRE.VisibleIndex = 5
        Me.GCol_VRAPPORT_FM_TITRE.Width = 396
        '
        'GCol_VETAT
        '
        Me.GCol_VETAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VETAT.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VETAT.Caption = "Etat dernière génération"
        Me.GCol_VETAT.FieldName = "VETAT"
        Me.GCol_VETAT.Name = "GCol_VETAT"
        Me.GCol_VETAT.Visible = True
        Me.GCol_VETAT.VisibleIndex = 6
        Me.GCol_VETAT.Width = 140
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn1.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn1.Caption = "Historique envoi"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemHyperLinkEdit1
        Me.GridColumn1.FieldName = "HT_VOIR"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 9
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        Me.RepositoryItemHyperLinkEdit1.SingleClick = True
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.ChkArchives)
        Me.GrpActions.Controls.Add(Me.BtnArchiver)
        Me.GrpActions.Controls.Add(Me.BtnModifier)
        Me.GrpActions.Controls.Add(Me.BtnSendTo)
        Me.GrpActions.Controls.Add(Me.BtnAddRapportFM)
        Me.GrpActions.Controls.Add(Me.BtnClose)
        Me.GrpActions.Location = New System.Drawing.Point(12, 12)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(157, 670)
        Me.GrpActions.TabIndex = 10
        Me.GrpActions.TabStop = False
        '
        'ChkArchives
        '
        Me.ChkArchives.AutoSize = True
        Me.ChkArchives.Location = New System.Drawing.Point(27, 327)
        Me.ChkArchives.Name = "ChkArchives"
        Me.ChkArchives.Size = New System.Drawing.Size(103, 17)
        Me.ChkArchives.TabIndex = 19
        Me.ChkArchives.Text = "Voir les archives"
        Me.ChkArchives.UseVisualStyleBackColor = True
        '
        'BtnArchiver
        '
        Me.BtnArchiver.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnArchiver.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnArchiver.Location = New System.Drawing.Point(15, 271)
        Me.BtnArchiver.Name = "BtnArchiver"
        Me.BtnArchiver.Size = New System.Drawing.Size(131, 35)
        Me.BtnArchiver.TabIndex = 8
        Me.BtnArchiver.Text = "Archiver"
        Me.BtnArchiver.UseVisualStyleBackColor = True
        '
        'BtnModifier
        '
        Me.BtnModifier.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnModifier.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnModifier.Location = New System.Drawing.Point(15, 146)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(131, 35)
        Me.BtnModifier.TabIndex = 7
        Me.BtnModifier.Text = "Modifier"
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'BtnSendTo
        '
        Me.BtnSendTo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSendTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSendTo.Location = New System.Drawing.Point(15, 206)
        Me.BtnSendTo.Name = "BtnSendTo"
        Me.BtnSendTo.Size = New System.Drawing.Size(131, 35)
        Me.BtnSendTo.TabIndex = 6
        Me.BtnSendTo.Text = "Envoyer à"
        Me.BtnSendTo.UseVisualStyleBackColor = True
        '
        'BtnAddRapportFM
        '
        Me.BtnAddRapportFM.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAddRapportFM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnAddRapportFM.Location = New System.Drawing.Point(15, 87)
        Me.BtnAddRapportFM.Name = "BtnAddRapportFM"
        Me.BtnAddRapportFM.Size = New System.Drawing.Size(131, 35)
        Me.BtnAddRapportFM.TabIndex = 5
        Me.BtnAddRapportFM.Text = "Créer un rapport FM"
        Me.BtnAddRapportFM.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnClose.Location = New System.Drawing.Point(15, 627)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(131, 35)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "Fermer"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        Me.LblTitre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitre.Location = New System.Drawing.Point(175, 12)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(994, 36)
        Me.LblTitre.TabIndex = 13
        Me.LblTitre.Text = "Liste des rapports FM du client {0}"
        Me.LblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmRapportFm_ListeRapportFM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1530, 922)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GCListeRapportFM)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "FrmRapportFm_ListeRapportFM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Liste des rapports FM du client"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCListeRapportFM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeRapportFM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.GrpActions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents GCListeRapportFM As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeRapportFM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblTitre As Label
    Friend WithEvents GCol_NIDRAPPORT_FM_CLI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnAddRapportFM As Button
    Friend WithEvents BtnSendTo As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents GCol_DDATEDEB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_DDATEFIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_DDATSEND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VMAILDEST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_DDATMOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VLANGUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnArchiver As Button
    Friend WithEvents GCol_VRAPPORT_FM_TITRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChkArchives As CheckBox
    Friend WithEvents GCol_VETAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
End Class
