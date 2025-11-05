<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestDroitAnalytiqueByPer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnCopyDroit = New System.Windows.Forms.Button()
        Me.BtnAffichage = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.GCComptes = New DevExpress.XtraGrid.GridControl()
        Me.GVComptes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCCpt_NCOCHE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkCPT_NCOCHE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GCCpt_NCANNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCCpt_VCANLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCCpt_CTYPECTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCPers = New DevExpress.XtraGrid.GridControl()
        Me.GVPers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCPer_NCOCHE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkNCOCHE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GCPer_NPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCPer_VPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCPer_VTYPELIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnCheckedAll = New System.Windows.Forms.Button()
        Me.BtnUnCheckedAll = New System.Windows.Forms.Button()
        Me.ChkCptArch = New System.Windows.Forms.CheckBox()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCComptes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVComptes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkCPT_NCOCHE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkNCOCHE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(172, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 19)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Gestion des droits analytiques"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnCopyDroit)
        Me.GrpActions.Controls.Add(Me.BtnAffichage)
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Location = New System.Drawing.Point(21, 12)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(120, 803)
        Me.GrpActions.TabIndex = 36
        Me.GrpActions.TabStop = False
        '
        'BtnCopyDroit
        '
        Me.BtnCopyDroit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnCopyDroit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCopyDroit.Location = New System.Drawing.Point(6, 240)
        Me.BtnCopyDroit.Name = "BtnCopyDroit"
        Me.BtnCopyDroit.Size = New System.Drawing.Size(108, 44)
        Me.BtnCopyDroit.TabIndex = 8
        Me.BtnCopyDroit.Text = "Copier droits compte"
        Me.BtnCopyDroit.UseVisualStyleBackColor = True
        '
        'BtnAffichage
        '
        Me.BtnAffichage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAffichage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnAffichage.Location = New System.Drawing.Point(6, 73)
        Me.BtnAffichage.Name = "BtnAffichage"
        Me.BtnAffichage.Size = New System.Drawing.Size(108, 44)
        Me.BtnAffichage.TabIndex = 7
        Me.BtnAffichage.Text = "Droits par personne"
        Me.BtnAffichage.UseVisualStyleBackColor = True
        '
        'BtnQuit
        '
        Me.BtnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnQuit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnQuit.Location = New System.Drawing.Point(12, 752)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(108, 45)
        Me.BtnQuit.TabIndex = 6
        Me.BtnQuit.Text = "Fermer"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'GCComptes
        '
        Me.GCComptes.Location = New System.Drawing.Point(176, 85)
        Me.GCComptes.MainView = Me.GVComptes
        Me.GCComptes.Name = "GCComptes"
        Me.GCComptes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChkCPT_NCOCHE})
        Me.GCComptes.Size = New System.Drawing.Size(545, 730)
        Me.GCComptes.TabIndex = 38
        Me.GCComptes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVComptes})
        '
        'GVComptes
        '
        Me.GVComptes.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVComptes.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVComptes.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVComptes.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVComptes.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVComptes.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.GVComptes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCCpt_NCOCHE, Me.GCCpt_NCANNUM, Me.GCCpt_VCANLIB, Me.GCCpt_CTYPECTE})
        Me.GVComptes.GridControl = Me.GCComptes
        Me.GVComptes.Name = "GVComptes"
        Me.GVComptes.OptionsView.ShowAutoFilterRow = True
        Me.GVComptes.OptionsView.ShowGroupPanel = False
        '
        'GCCpt_NCOCHE
        '
        Me.GCCpt_NCOCHE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCCpt_NCOCHE.AppearanceHeader.Options.UseForeColor = True
        Me.GCCpt_NCOCHE.Caption = "Octroyer"
        Me.GCCpt_NCOCHE.ColumnEdit = Me.RepItemChkCPT_NCOCHE
        Me.GCCpt_NCOCHE.FieldName = "NCOCHE"
        Me.GCCpt_NCOCHE.Name = "GCCpt_NCOCHE"
        Me.GCCpt_NCOCHE.Visible = True
        Me.GCCpt_NCOCHE.VisibleIndex = 0
        Me.GCCpt_NCOCHE.Width = 70
        '
        'RepItemChkCPT_NCOCHE
        '
        Me.RepItemChkCPT_NCOCHE.AutoHeight = False
        Me.RepItemChkCPT_NCOCHE.Name = "RepItemChkCPT_NCOCHE"
        Me.RepItemChkCPT_NCOCHE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChkCPT_NCOCHE.ValueChecked = 1
        Me.RepItemChkCPT_NCOCHE.ValueUnchecked = 0
        '
        'GCCpt_NCANNUM
        '
        Me.GCCpt_NCANNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCCpt_NCANNUM.AppearanceHeader.Options.UseForeColor = True
        Me.GCCpt_NCANNUM.Caption = "N° Compte"
        Me.GCCpt_NCANNUM.FieldName = "NCANNUM"
        Me.GCCpt_NCANNUM.Name = "GCCpt_NCANNUM"
        Me.GCCpt_NCANNUM.OptionsColumn.AllowEdit = False
        Me.GCCpt_NCANNUM.OptionsColumn.ReadOnly = True
        Me.GCCpt_NCANNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
        Me.GCCpt_NCANNUM.Visible = True
        Me.GCCpt_NCANNUM.VisibleIndex = 1
        Me.GCCpt_NCANNUM.Width = 120
        '
        'GCCpt_VCANLIB
        '
        Me.GCCpt_VCANLIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCCpt_VCANLIB.AppearanceHeader.Options.UseForeColor = True
        Me.GCCpt_VCANLIB.Caption = "Libellé du compte"
        Me.GCCpt_VCANLIB.FieldName = "VCANLIB"
        Me.GCCpt_VCANLIB.Name = "GCCpt_VCANLIB"
        Me.GCCpt_VCANLIB.OptionsColumn.AllowEdit = False
        Me.GCCpt_VCANLIB.OptionsColumn.ReadOnly = True
        Me.GCCpt_VCANLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCCpt_VCANLIB.Visible = True
        Me.GCCpt_VCANLIB.VisibleIndex = 2
        Me.GCCpt_VCANLIB.Width = 290
        '
        'GCCpt_CTYPECTE
        '
        Me.GCCpt_CTYPECTE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCCpt_CTYPECTE.AppearanceHeader.Options.UseForeColor = True
        Me.GCCpt_CTYPECTE.Caption = "Type compte"
        Me.GCCpt_CTYPECTE.FieldName = "CTYPECTE"
        Me.GCCpt_CTYPECTE.Name = "GCCpt_CTYPECTE"
        Me.GCCpt_CTYPECTE.Visible = True
        Me.GCCpt_CTYPECTE.VisibleIndex = 3
        Me.GCCpt_CTYPECTE.Width = 100
        '
        'GCPers
        '
        Me.GCPers.Location = New System.Drawing.Point(752, 85)
        Me.GCPers.MainView = Me.GVPers
        Me.GCPers.Name = "GCPers"
        Me.GCPers.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChkNCOCHE})
        Me.GCPers.Size = New System.Drawing.Size(575, 730)
        Me.GCPers.TabIndex = 39
        Me.GCPers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPers})
        '
        'GVPers
        '
        Me.GVPers.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVPers.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVPers.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVPers.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVPers.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVPers.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVPers.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCPer_NCOCHE, Me.GCPer_NPERNUM, Me.GCPer_VPERNOM, Me.GCPer_VTYPELIB})
        Me.GVPers.GridControl = Me.GCPers
        Me.GVPers.Name = "GVPers"
        Me.GVPers.OptionsView.ShowAutoFilterRow = True
        Me.GVPers.OptionsView.ShowGroupPanel = False
        '
        'GCPer_NCOCHE
        '
        Me.GCPer_NCOCHE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCPer_NCOCHE.AppearanceHeader.Options.UseForeColor = True
        Me.GCPer_NCOCHE.Caption = "Octroyé"
        Me.GCPer_NCOCHE.ColumnEdit = Me.RepItemChkNCOCHE
        Me.GCPer_NCOCHE.FieldName = "NCOCHE"
        Me.GCPer_NCOCHE.Name = "GCPer_NCOCHE"
        Me.GCPer_NCOCHE.Visible = True
        Me.GCPer_NCOCHE.VisibleIndex = 0
        '
        'RepItemChkNCOCHE
        '
        Me.RepItemChkNCOCHE.AutoHeight = False
        Me.RepItemChkNCOCHE.Name = "RepItemChkNCOCHE"
        Me.RepItemChkNCOCHE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChkNCOCHE.ValueChecked = 1
        Me.RepItemChkNCOCHE.ValueUnchecked = 0
        '
        'GCPer_NPERNUM
        '
        Me.GCPer_NPERNUM.Caption = "NPERNUM"
        Me.GCPer_NPERNUM.FieldName = "NPERNUM"
        Me.GCPer_NPERNUM.Name = "GCPer_NPERNUM"
        '
        'GCPer_VPERNOM
        '
        Me.GCPer_VPERNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCPer_VPERNOM.AppearanceHeader.Options.UseForeColor = True
        Me.GCPer_VPERNOM.Caption = "Nom"
        Me.GCPer_VPERNOM.FieldName = "VPERNOM"
        Me.GCPer_VPERNOM.Name = "GCPer_VPERNOM"
        Me.GCPer_VPERNOM.OptionsColumn.AllowEdit = False
        Me.GCPer_VPERNOM.OptionsColumn.ReadOnly = True
        Me.GCPer_VPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCPer_VPERNOM.Visible = True
        Me.GCPer_VPERNOM.VisibleIndex = 1
        Me.GCPer_VPERNOM.Width = 159
        '
        'GCPer_VTYPELIB
        '
        Me.GCPer_VTYPELIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCPer_VTYPELIB.AppearanceHeader.Options.UseForeColor = True
        Me.GCPer_VTYPELIB.Caption = "Fonction"
        Me.GCPer_VTYPELIB.FieldName = "VTYPELIB"
        Me.GCPer_VTYPELIB.Name = "GCPer_VTYPELIB"
        Me.GCPer_VTYPELIB.OptionsColumn.AllowEdit = False
        Me.GCPer_VTYPELIB.OptionsColumn.ReadOnly = True
        Me.GCPer_VTYPELIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCPer_VTYPELIB.Visible = True
        Me.GCPer_VTYPELIB.VisibleIndex = 2
        Me.GCPer_VTYPELIB.Width = 164
        '
        'BtnCheckedAll
        '
        Me.BtnCheckedAll.Location = New System.Drawing.Point(752, 821)
        Me.BtnCheckedAll.Name = "BtnCheckedAll"
        Me.BtnCheckedAll.Size = New System.Drawing.Size(121, 34)
        Me.BtnCheckedAll.TabIndex = 40
        Me.BtnCheckedAll.Text = "Cocher tous"
        Me.BtnCheckedAll.UseVisualStyleBackColor = True
        '
        'BtnUnCheckedAll
        '
        Me.BtnUnCheckedAll.Location = New System.Drawing.Point(879, 821)
        Me.BtnUnCheckedAll.Name = "BtnUnCheckedAll"
        Me.BtnUnCheckedAll.Size = New System.Drawing.Size(121, 34)
        Me.BtnUnCheckedAll.TabIndex = 41
        Me.BtnUnCheckedAll.Text = "Décocher tous"
        Me.BtnUnCheckedAll.UseVisualStyleBackColor = True
        '
        'ChkCptArch
        '
        Me.ChkCptArch.AutoSize = True
        Me.ChkCptArch.Location = New System.Drawing.Point(346, 62)
        Me.ChkCptArch.Name = "ChkCptArch"
        Me.ChkCptArch.Size = New System.Drawing.Size(146, 17)
        Me.ChkCptArch.TabIndex = 42
        Me.ChkCptArch.Text = "Voir les comptes archivés"
        Me.ChkCptArch.UseVisualStyleBackColor = True
        '
        'frmGestDroitAnalytiqueByPer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1437, 904)
        Me.Controls.Add(Me.ChkCptArch)
        Me.Controls.Add(Me.BtnUnCheckedAll)
        Me.Controls.Add(Me.BtnCheckedAll)
        Me.Controls.Add(Me.GCPers)
        Me.Controls.Add(Me.GCComptes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmGestDroitAnalytiqueByPer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion des droits analytiques"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCComptes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVComptes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkCPT_NCOCHE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkNCOCHE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnQuit As Button
    Friend WithEvents GCComptes As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVComptes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCPers As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCCpt_NCANNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCCpt_VCANLIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCCpt_CTYPECTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCPer_NPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCPer_VPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCPer_VTYPELIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCPer_NCOCHE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemChkNCOCHE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BtnCheckedAll As Button
    Friend WithEvents BtnUnCheckedAll As Button
    Friend WithEvents BtnCopyDroit As Button
    Friend WithEvents BtnAffichage As Button
    Friend WithEvents ChkCptArch As CheckBox
    Friend WithEvents GCCpt_NCOCHE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemChkCPT_NCOCHE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
