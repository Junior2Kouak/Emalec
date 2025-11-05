<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminRepartitionAnaHrDetail
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
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnEnreg = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.G_CAT = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblValDI = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkDI = New System.Windows.Forms.CheckBox()
        Me.ChkExclusion = New System.Windows.Forms.CheckBox()
        Me.G_NPERNUM = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.G_V_NPERNUM = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnSupp = New System.Windows.Forms.Button()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.GCRepartition = New DevExpress.XtraGrid.GridControl()
        Me.GVRepartition = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NIDPER_REPART_ANA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NCANNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R_NCANNUM = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NVAL_REPART_ANA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R_NVAL_REPART_ANA = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.G_CAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.G_NPERNUM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.G_V_NPERNUM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCRepartition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVRepartition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.R_NCANNUM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.R_NVAL_REPART_ANA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelTitre.Location = New System.Drawing.Point(102, 9)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(566, 29)
        Me.LabelTitre.TabIndex = 40
        Me.LabelTitre.Text = "Répartition Analytique Heures Personnel - Détail"
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(18, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Personne :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnFermer
        '
        Me.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(3, 361)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnEnreg)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(87, 415)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'BtnEnreg
        '
        Me.BtnEnreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnEnreg.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnEnreg.Location = New System.Drawing.Point(4, 19)
        Me.BtnEnreg.Name = "BtnEnreg"
        Me.BtnEnreg.Size = New System.Drawing.Size(80, 48)
        Me.BtnEnreg.TabIndex = 10
        Me.BtnEnreg.Text = "Enregistrer"
        Me.BtnEnreg.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.G_CAT)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.LblValDI)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ChkDI)
        Me.GroupBox3.Controls.Add(Me.ChkExclusion)
        Me.GroupBox3.Controls.Add(Me.G_NPERNUM)
        Me.GroupBox3.Controls.Add(Me.BtnSupp)
        Me.GroupBox3.Controls.Add(Me.BtnAjouter)
        Me.GroupBox3.Controls.Add(Me.GCRepartition)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(107, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(795, 488)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        '
        'G_CAT
        '
        Me.G_CAT.EditValue = "NCAT"
        Me.G_CAT.Location = New System.Drawing.Point(114, 86)
        Me.G_CAT.Name = "G_CAT"
        Me.G_CAT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.G_CAT.Properties.DisplayMember = "VCAT"
        Me.G_CAT.Properties.NullText = ""
        Me.G_CAT.Properties.PopupView = Me.GridView1
        Me.G_CAT.Properties.ValueMember = "NCAT"
        Me.G_CAT.Size = New System.Drawing.Size(291, 20)
        Me.G_CAT.TabIndex = 70
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "NCAT"
        Me.GridColumn5.FieldName = "NCAT"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Catégorie"
        Me.GridColumn6.FieldName = "VCAT"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(18, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 28)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Catégorie :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblValDI
        '
        Me.LblValDI.BackColor = System.Drawing.Color.White
        Me.LblValDI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblValDI.Location = New System.Drawing.Point(534, 153)
        Me.LblValDI.Name = "LblValDI"
        Me.LblValDI.Size = New System.Drawing.Size(89, 27)
        Me.LblValDI.TabIndex = 68
        Me.LblValDI.Text = "0 %"
        Me.LblValDI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblValDI.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(363, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Valeur répartition sur DI"
        Me.Label1.Visible = False
        '
        'ChkDI
        '
        Me.ChkDI.AutoSize = True
        Me.ChkDI.Location = New System.Drawing.Point(114, 159)
        Me.ChkDI.Name = "ChkDI"
        Me.ChkDI.Size = New System.Drawing.Size(214, 17)
        Me.ChkDI.TabIndex = 66
        Me.ChkDI.Text = "Heures restantes imputées sur DI"
        Me.ChkDI.UseVisualStyleBackColor = True
        '
        'ChkExclusion
        '
        Me.ChkExclusion.AutoSize = True
        Me.ChkExclusion.Location = New System.Drawing.Point(114, 127)
        Me.ChkExclusion.Name = "ChkExclusion"
        Me.ChkExclusion.Size = New System.Drawing.Size(215, 17)
        Me.ChkExclusion.TabIndex = 65
        Me.ChkExclusion.Text = "Exclusion du transfert des heures"
        Me.ChkExclusion.UseVisualStyleBackColor = True
        '
        'G_NPERNUM
        '
        Me.G_NPERNUM.EditValue = "NPERNUM"
        Me.G_NPERNUM.Location = New System.Drawing.Point(114, 42)
        Me.G_NPERNUM.Name = "G_NPERNUM"
        Me.G_NPERNUM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.G_NPERNUM.Properties.DisplayMember = "VPERNOM"
        Me.G_NPERNUM.Properties.NullText = ""
        Me.G_NPERNUM.Properties.PopupView = Me.G_V_NPERNUM
        Me.G_NPERNUM.Properties.ValueMember = "NPERNUM"
        Me.G_NPERNUM.Size = New System.Drawing.Size(659, 20)
        Me.G_NPERNUM.TabIndex = 64
        '
        'G_V_NPERNUM
        '
        Me.G_V_NPERNUM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.G_V_NPERNUM.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.G_V_NPERNUM.Name = "G_V_NPERNUM"
        Me.G_V_NPERNUM.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.G_V_NPERNUM.OptionsView.ShowAutoFilterRow = True
        Me.G_V_NPERNUM.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "NPERNUM"
        Me.GridColumn1.FieldName = "NPERNUM"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nom"
        Me.GridColumn2.FieldName = "VPERNOM"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Société"
        Me.GridColumn3.FieldName = "vsociete"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Fonction"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'BtnSupp
        '
        Me.BtnSupp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSupp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSupp.Location = New System.Drawing.Point(10, 263)
        Me.BtnSupp.Name = "BtnSupp"
        Me.BtnSupp.Size = New System.Drawing.Size(80, 48)
        Me.BtnSupp.TabIndex = 62
        Me.BtnSupp.Text = "Supprimer"
        Me.BtnSupp.UseVisualStyleBackColor = True
        '
        'BtnAjouter
        '
        Me.BtnAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAjouter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnAjouter.Location = New System.Drawing.Point(10, 200)
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.Size = New System.Drawing.Size(80, 48)
        Me.BtnAjouter.TabIndex = 61
        Me.BtnAjouter.Text = "Ajouter"
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'GCRepartition
        '
        Me.GCRepartition.Location = New System.Drawing.Point(114, 200)
        Me.GCRepartition.MainView = Me.GVRepartition
        Me.GCRepartition.Name = "GCRepartition"
        Me.GCRepartition.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.R_NCANNUM, Me.R_NVAL_REPART_ANA})
        Me.GCRepartition.Size = New System.Drawing.Size(659, 241)
        Me.GCRepartition.TabIndex = 60
        Me.GCRepartition.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVRepartition})
        '
        'GVRepartition
        '
        Me.GVRepartition.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IDTMP, Me.NIDPER_REPART_ANA, Me.NCANNUM, Me.NVAL_REPART_ANA})
        Me.GVRepartition.GridControl = Me.GCRepartition
        Me.GVRepartition.Name = "GVRepartition"
        Me.GVRepartition.OptionsView.ShowFooter = True
        Me.GVRepartition.OptionsView.ShowGroupPanel = False
        '
        'IDTMP
        '
        Me.IDTMP.Caption = "IDTMP"
        Me.IDTMP.FieldName = "IDTMP"
        Me.IDTMP.Name = "IDTMP"
        '
        'NIDPER_REPART_ANA
        '
        Me.NIDPER_REPART_ANA.Caption = "NIDPER_REPART_ANA"
        Me.NIDPER_REPART_ANA.FieldName = "NIDPER_REPART_ANA"
        Me.NIDPER_REPART_ANA.Name = "NIDPER_REPART_ANA"
        Me.NIDPER_REPART_ANA.OptionsColumn.AllowEdit = False
        Me.NIDPER_REPART_ANA.OptionsColumn.ReadOnly = True
        '
        'NCANNUM
        '
        Me.NCANNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NCANNUM.AppearanceHeader.Options.UseForeColor = True
        Me.NCANNUM.Caption = "N° Compte"
        Me.NCANNUM.ColumnEdit = Me.R_NCANNUM
        Me.NCANNUM.FieldName = "NCANNUM"
        Me.NCANNUM.Name = "NCANNUM"
        Me.NCANNUM.Visible = True
        Me.NCANNUM.VisibleIndex = 0
        '
        'R_NCANNUM
        '
        Me.R_NCANNUM.AutoHeight = False
        Me.R_NCANNUM.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.R_NCANNUM.DisplayMember = "vcanlib"
        Me.R_NCANNUM.Name = "R_NCANNUM"
        Me.R_NCANNUM.NullText = ""
        Me.R_NCANNUM.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.R_NCANNUM.ValueMember = "ncannum"
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "N° Compte"
        Me.GridColumn7.FieldName = "ncannum"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Libellé Compte"
        Me.GridColumn8.FieldName = "vcanlib_only"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "GridColumn9"
        Me.GridColumn9.FieldName = "vcanlib"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'NVAL_REPART_ANA
        '
        Me.NVAL_REPART_ANA.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NVAL_REPART_ANA.AppearanceHeader.Options.UseForeColor = True
        Me.NVAL_REPART_ANA.Caption = "Valeur répartition"
        Me.NVAL_REPART_ANA.ColumnEdit = Me.R_NVAL_REPART_ANA
        Me.NVAL_REPART_ANA.DisplayFormat.FormatString = "{0:n0} %"
        Me.NVAL_REPART_ANA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NVAL_REPART_ANA.FieldName = "NVAL_REPART_ANA"
        Me.NVAL_REPART_ANA.Name = "NVAL_REPART_ANA"
        Me.NVAL_REPART_ANA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NVAL_REPART_ANA", "TOTAL (en %)={0:0.##}")})
        Me.NVAL_REPART_ANA.Visible = True
        Me.NVAL_REPART_ANA.VisibleIndex = 1
        '
        'R_NVAL_REPART_ANA
        '
        Me.R_NVAL_REPART_ANA.AutoHeight = False
        Me.R_NVAL_REPART_ANA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.R_NVAL_REPART_ANA.DisplayFormat.FormatString = "{0:n0} %"
        Me.R_NVAL_REPART_ANA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.R_NVAL_REPART_ANA.EditFormat.FormatString = "n0"
        Me.R_NVAL_REPART_ANA.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.R_NVAL_REPART_ANA.EditValueChangedDelay = 1
        Me.R_NVAL_REPART_ANA.Mask.EditMask = "n0"
        Me.R_NVAL_REPART_ANA.Mask.UseMaskAsDisplayFormat = True
        Me.R_NVAL_REPART_ANA.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.R_NVAL_REPART_ANA.Name = "R_NVAL_REPART_ANA"
        Me.R_NVAL_REPART_ANA.ValidateOnEnterKey = True
        '
        'frmAdminRepartitionAnaHrDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnFermer
        Me.ClientSize = New System.Drawing.Size(1000, 587)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmAdminRepartitionAnaHrDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Répartition Analytique Heures Personnel - Détail"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.G_CAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.G_NPERNUM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.G_V_NPERNUM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCRepartition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVRepartition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.R_NCANNUM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.R_NVAL_REPART_ANA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitre As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnFermer As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnEnreg As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GCRepartition As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVRepartition As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtnSupp As Button
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents NIDPER_REPART_ANA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NCANNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R_NCANNUM As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NVAL_REPART_ANA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R_NVAL_REPART_ANA As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents G_NPERNUM As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents G_V_NPERNUM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChkDI As CheckBox
    Friend WithEvents ChkExclusion As CheckBox
    Friend WithEvents LblValDI As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents G_CAT As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As Label
End Class
