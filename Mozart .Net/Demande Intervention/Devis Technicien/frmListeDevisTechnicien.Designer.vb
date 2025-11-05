<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeDevisTechnicien
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
        Me.BtnDeleteDevis = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.GCDevisTechListe = New DevExpress.XtraGrid.GridControl()
        Me.GVDevisTechListe = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColDevisTechVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDevisTechVSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDevisTechDDEVISTECHSAISIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDevisTechVDEVISTECHTITRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDevisTechVDEVISTECHSUJET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDevisTechNDEVISTECHNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkDest = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        CType(Me.GCDevisTechListe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDevisTechListe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkDest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnDeleteDevis
        '
        Me.BtnDeleteDevis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDeleteDevis.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnDeleteDevis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnDeleteDevis.Location = New System.Drawing.Point(12, 141)
        Me.BtnDeleteDevis.Name = "BtnDeleteDevis"
        Me.BtnDeleteDevis.Size = New System.Drawing.Size(110, 51)
        Me.BtnDeleteDevis.TabIndex = 34
        Me.BtnDeleteDevis.Text = "Supprimer"
        Me.BtnDeleteDevis.UseVisualStyleBackColor = True
        '
        'BtnModifier
        '
        Me.BtnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModifier.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnModifier.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnModifier.Location = New System.Drawing.Point(12, 77)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(110, 58)
        Me.BtnModifier.TabIndex = 33
        Me.BtnModifier.Text = "Modifier"
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'BtnValid
        '
        Me.BtnValid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnValid.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnValid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnValid.Location = New System.Drawing.Point(1236, 12)
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.Size = New System.Drawing.Size(118, 59)
        Me.BtnValid.TabIndex = 32
        Me.BtnValid.Text = "Envoyer"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'btnAjouter
        '
        Me.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAjouter.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAjouter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAjouter.Location = New System.Drawing.Point(12, 12)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(110, 59)
        Me.btnAjouter.TabIndex = 30
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'BtnQuit
        '
        Me.BtnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnQuit.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BtnQuit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnQuit.Location = New System.Drawing.Point(12, 689)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(110, 41)
        Me.BtnQuit.TabIndex = 29
        Me.BtnQuit.Text = "Fermer"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'GCDevisTechListe
        '
        Me.GCDevisTechListe.Location = New System.Drawing.Point(128, 12)
        Me.GCDevisTechListe.MainView = Me.GVDevisTechListe
        Me.GCDevisTechListe.Name = "GCDevisTechListe"
        Me.GCDevisTechListe.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChkDest})
        Me.GCDevisTechListe.Size = New System.Drawing.Size(1102, 718)
        Me.GCDevisTechListe.TabIndex = 35
        Me.GCDevisTechListe.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDevisTechListe})
        '
        'GVDevisTechListe
        '
        Me.GVDevisTechListe.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVDevisTechListe.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVDevisTechListe.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVDevisTechListe.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVDevisTechListe.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVDevisTechListe.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColDevisTechVCLINOM, Me.ColDevisTechVSITNOM, Me.ColDevisTechDDEVISTECHSAISIE, Me.ColDevisTechVDEVISTECHTITRE, Me.ColDevisTechVDEVISTECHSUJET, Me.ColDevisTechNDEVISTECHNUM})
        Me.GVDevisTechListe.GridControl = Me.GCDevisTechListe
        Me.GVDevisTechListe.Name = "GVDevisTechListe"
        Me.GVDevisTechListe.OptionsView.ShowGroupPanel = False
        '
        'ColDevisTechVCLINOM
        '
        Me.ColDevisTechVCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColDevisTechVCLINOM.AppearanceHeader.Options.UseForeColor = True
        Me.ColDevisTechVCLINOM.Caption = "Client"
        Me.ColDevisTechVCLINOM.FieldName = "VCLINOM"
        Me.ColDevisTechVCLINOM.Name = "ColDevisTechVCLINOM"
        Me.ColDevisTechVCLINOM.OptionsColumn.AllowEdit = False
        Me.ColDevisTechVCLINOM.OptionsColumn.ReadOnly = True
        Me.ColDevisTechVCLINOM.Visible = True
        Me.ColDevisTechVCLINOM.VisibleIndex = 0
        Me.ColDevisTechVCLINOM.Width = 250
        '
        'ColDevisTechVSITNOM
        '
        Me.ColDevisTechVSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColDevisTechVSITNOM.AppearanceHeader.Options.UseForeColor = True
        Me.ColDevisTechVSITNOM.Caption = "Site"
        Me.ColDevisTechVSITNOM.FieldName = "VSITNOM"
        Me.ColDevisTechVSITNOM.Name = "ColDevisTechVSITNOM"
        Me.ColDevisTechVSITNOM.OptionsColumn.AllowEdit = False
        Me.ColDevisTechVSITNOM.OptionsColumn.ReadOnly = True
        Me.ColDevisTechVSITNOM.Visible = True
        Me.ColDevisTechVSITNOM.VisibleIndex = 1
        Me.ColDevisTechVSITNOM.Width = 300
        '
        'ColDevisTechDDEVISTECHSAISIE
        '
        Me.ColDevisTechDDEVISTECHSAISIE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColDevisTechDDEVISTECHSAISIE.AppearanceHeader.Options.UseForeColor = True
        Me.ColDevisTechDDEVISTECHSAISIE.Caption = "Date saisie"
        Me.ColDevisTechDDEVISTECHSAISIE.FieldName = "DDEVISTECHSAISIE"
        Me.ColDevisTechDDEVISTECHSAISIE.Name = "ColDevisTechDDEVISTECHSAISIE"
        Me.ColDevisTechDDEVISTECHSAISIE.OptionsColumn.AllowEdit = False
        Me.ColDevisTechDDEVISTECHSAISIE.OptionsColumn.ReadOnly = True
        Me.ColDevisTechDDEVISTECHSAISIE.Visible = True
        Me.ColDevisTechDDEVISTECHSAISIE.VisibleIndex = 2
        Me.ColDevisTechDDEVISTECHSAISIE.Width = 100
        '
        'ColDevisTechVDEVISTECHTITRE
        '
        Me.ColDevisTechVDEVISTECHTITRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColDevisTechVDEVISTECHTITRE.AppearanceHeader.Options.UseForeColor = True
        Me.ColDevisTechVDEVISTECHTITRE.Caption = "Titre"
        Me.ColDevisTechVDEVISTECHTITRE.FieldName = "VDEVISTECHTITRE"
        Me.ColDevisTechVDEVISTECHTITRE.Name = "ColDevisTechVDEVISTECHTITRE"
        Me.ColDevisTechVDEVISTECHTITRE.OptionsColumn.AllowEdit = False
        Me.ColDevisTechVDEVISTECHTITRE.OptionsColumn.ReadOnly = True
        Me.ColDevisTechVDEVISTECHTITRE.Visible = True
        Me.ColDevisTechVDEVISTECHTITRE.VisibleIndex = 3
        Me.ColDevisTechVDEVISTECHTITRE.Width = 211
        '
        'ColDevisTechVDEVISTECHSUJET
        '
        Me.ColDevisTechVDEVISTECHSUJET.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColDevisTechVDEVISTECHSUJET.AppearanceHeader.Options.UseForeColor = True
        Me.ColDevisTechVDEVISTECHSUJET.Caption = "Sujet"
        Me.ColDevisTechVDEVISTECHSUJET.FieldName = "VDEVISTECHSUJET"
        Me.ColDevisTechVDEVISTECHSUJET.Name = "ColDevisTechVDEVISTECHSUJET"
        Me.ColDevisTechVDEVISTECHSUJET.OptionsColumn.AllowEdit = False
        Me.ColDevisTechVDEVISTECHSUJET.OptionsColumn.ReadOnly = True
        Me.ColDevisTechVDEVISTECHSUJET.Visible = True
        Me.ColDevisTechVDEVISTECHSUJET.VisibleIndex = 4
        Me.ColDevisTechVDEVISTECHSUJET.Width = 223
        '
        'ColDevisTechNDEVISTECHNUM
        '
        Me.ColDevisTechNDEVISTECHNUM.Caption = "NDEVISTECHNUM"
        Me.ColDevisTechNDEVISTECHNUM.FieldName = "NDEVISTECHNUM"
        Me.ColDevisTechNDEVISTECHNUM.Name = "ColDevisTechNDEVISTECHNUM"
        Me.ColDevisTechNDEVISTECHNUM.OptionsColumn.AllowEdit = False
        Me.ColDevisTechNDEVISTECHNUM.OptionsColumn.ReadOnly = True
        '
        'RepItemChkDest
        '
        Me.RepItemChkDest.AutoHeight = False
        Me.RepItemChkDest.Name = "RepItemChkDest"
        Me.RepItemChkDest.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChkDest.ValueChecked = CType(1, Short)
        Me.RepItemChkDest.ValueGrayed = CType(0, Short)
        Me.RepItemChkDest.ValueUnchecked = CType(0, Short)
        '
        'frmListeDevisTechnicien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1372, 746)
        Me.Controls.Add(Me.GCDevisTechListe)
        Me.Controls.Add(Me.BtnDeleteDevis)
        Me.Controls.Add(Me.BtnModifier)
        Me.Controls.Add(Me.BtnValid)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.BtnQuit)
        Me.Name = "frmListeDevisTechnicien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Liste des devis clients en cours de modification / prêt à l'envoi"
        CType(Me.GCDevisTechListe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDevisTechListe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkDest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnDeleteDevis As System.Windows.Forms.Button
    Friend WithEvents BtnModifier As System.Windows.Forms.Button
    Friend WithEvents BtnValid As System.Windows.Forms.Button
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Private WithEvents GCDevisTechListe As DevExpress.XtraGrid.GridControl
    Private WithEvents GVDevisTechListe As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents RepItemChkDest As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents ColDevisTechVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDevisTechVSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDevisTechDDEVISTECHSAISIE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDevisTechVDEVISTECHTITRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDevisTechVDEVISTECHSUJET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDevisTechNDEVISTECHNUM As DevExpress.XtraGrid.Columns.GridColumn
End Class
