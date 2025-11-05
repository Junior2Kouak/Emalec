<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionProfilGroup_Liste_Filiales
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
        Me.GCFiliales = New DevExpress.XtraGrid.GridControl()
        Me.GVFiliales = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColCoche = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkNCOCHE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GCol_VSOCIETE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        CType(Me.GCFiliales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVFiliales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkNCOCHE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCFiliales
        '
        Me.GCFiliales.Location = New System.Drawing.Point(12, 65)
        Me.GCFiliales.MainView = Me.GVFiliales
        Me.GCFiliales.Name = "GCFiliales"
        Me.GCFiliales.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChkNCOCHE})
        Me.GCFiliales.Size = New System.Drawing.Size(411, 342)
        Me.GCFiliales.TabIndex = 0
        Me.GCFiliales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVFiliales})
        '
        'GVFiliales
        '
        Me.GVFiliales.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVFiliales.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVFiliales.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVFiliales.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVFiliales.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVFiliales.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVFiliales.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCoche, Me.GCol_VSOCIETE})
        Me.GVFiliales.GridControl = Me.GCFiliales
        Me.GVFiliales.Name = "GVFiliales"
        Me.GVFiliales.OptionsView.ShowAutoFilterRow = True
        Me.GVFiliales.OptionsView.ShowGroupPanel = False
        '
        'GColCoche
        '
        Me.GColCoche.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColCoche.AppearanceHeader.Options.UseForeColor = True
        Me.GColCoche.Caption = "Coche"
        Me.GColCoche.ColumnEdit = Me.RepItemChkNCOCHE
        Me.GColCoche.FieldName = "NCOCHE"
        Me.GColCoche.Name = "GColCoche"
        Me.GColCoche.Visible = True
        Me.GColCoche.VisibleIndex = 0
        Me.GColCoche.Width = 100
        '
        'RepItemChkNCOCHE
        '
        Me.RepItemChkNCOCHE.AutoHeight = False
        Me.RepItemChkNCOCHE.Name = "RepItemChkNCOCHE"
        Me.RepItemChkNCOCHE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChkNCOCHE.ValueChecked = 1
        Me.RepItemChkNCOCHE.ValueUnchecked = 0
        '
        'GCol_VSOCIETE
        '
        Me.GCol_VSOCIETE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VSOCIETE.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VSOCIETE.Caption = "Filiale"
        Me.GCol_VSOCIETE.FieldName = "VSOCIETE"
        Me.GCol_VSOCIETE.Name = "GCol_VSOCIETE"
        Me.GCol_VSOCIETE.OptionsColumn.AllowEdit = False
        Me.GCol_VSOCIETE.OptionsColumn.ReadOnly = True
        Me.GCol_VSOCIETE.Visible = True
        Me.GCol_VSOCIETE.VisibleIndex = 1
        Me.GCol_VSOCIETE.Width = 293
        '
        'BtnValid
        '
        Me.BtnValid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValid.Location = New System.Drawing.Point(328, 413)
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.Size = New System.Drawing.Size(95, 32)
        Me.BtnValid.TabIndex = 1
        Me.BtnValid.Text = "Valider"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(217, 413)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(89, 32)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Annuler"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        Me.LblTitre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(12, 19)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(411, 43)
        Me.LblTitre.TabIndex = 53
        Me.LblTitre.Text = "Dupliquer le profil de {0} vers les filiales sélectionnées ci-dessous :"
        '
        'FrmGestionProfilGroup_Liste_Filiales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(436, 457)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnValid)
        Me.Controls.Add(Me.GCFiliales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGestionProfilGroup_Liste_Filiales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Liste des filiales"
        CType(Me.GCFiliales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVFiliales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkNCOCHE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GCFiliales As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVFiliales As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GColCoche As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VSOCIETE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnValid As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents RepItemChkNCOCHE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents LblTitre As Label
End Class
