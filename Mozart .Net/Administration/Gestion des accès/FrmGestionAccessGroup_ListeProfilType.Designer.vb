<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionAccessGroup_ListeProfilType
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
        Me.GCProfils = New DevExpress.XtraGrid.GridControl()
        Me.GVProfils = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColCoche = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkNCOCHE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GCol_CPERTYP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NSERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VTYPELIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VTYPEDETAILLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        CType(Me.GCProfils, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVProfils, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkNCOCHE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCProfils
        '
        Me.GCProfils.Location = New System.Drawing.Point(12, 65)
        Me.GCProfils.MainView = Me.GVProfils
        Me.GCProfils.Name = "GCProfils"
        Me.GCProfils.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChkNCOCHE})
        Me.GCProfils.Size = New System.Drawing.Size(568, 342)
        Me.GCProfils.TabIndex = 0
        Me.GCProfils.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVProfils})
        '
        'GVProfils
        '
        Me.GVProfils.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVProfils.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVProfils.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVProfils.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVProfils.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVProfils.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVProfils.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCoche, Me.GCol_CPERTYP, Me.GCol_ID, Me.GCol_NSERNUM, Me.GCol_VTYPELIB, Me.GCol_VTYPEDETAILLIB})
        Me.GVProfils.GridControl = Me.GCProfils
        Me.GVProfils.Name = "GVProfils"
        Me.GVProfils.OptionsView.ShowAutoFilterRow = True
        Me.GVProfils.OptionsView.ShowGroupPanel = False
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
        Me.GColCoche.Width = 70
        '
        'RepItemChkNCOCHE
        '
        Me.RepItemChkNCOCHE.AutoHeight = False
        Me.RepItemChkNCOCHE.Name = "RepItemChkNCOCHE"
        Me.RepItemChkNCOCHE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChkNCOCHE.ValueChecked = 1
        Me.RepItemChkNCOCHE.ValueUnchecked = 0
        '
        'GCol_CPERTYP
        '
        Me.GCol_CPERTYP.Caption = "CPERTYP"
        Me.GCol_CPERTYP.FieldName = "CPERTYP"
        Me.GCol_CPERTYP.Name = "GCol_CPERTYP"
        '
        'GCol_ID
        '
        Me.GCol_ID.Caption = "ID"
        Me.GCol_ID.FieldName = "ID"
        Me.GCol_ID.Name = "GCol_ID"
        '
        'GCol_NSERNUM
        '
        Me.GCol_NSERNUM.Caption = "NSERNUM"
        Me.GCol_NSERNUM.FieldName = "NSERNUM"
        Me.GCol_NSERNUM.Name = "GCol_NSERNUM"
        '
        'GCol_VTYPELIB
        '
        Me.GCol_VTYPELIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VTYPELIB.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VTYPELIB.Caption = "Type"
        Me.GCol_VTYPELIB.FieldName = "VTYPELIB"
        Me.GCol_VTYPELIB.Name = "GCol_VTYPELIB"
        Me.GCol_VTYPELIB.Visible = True
        Me.GCol_VTYPELIB.VisibleIndex = 1
        Me.GCol_VTYPELIB.Width = 160
        '
        'GCol_VTYPEDETAILLIB
        '
        Me.GCol_VTYPEDETAILLIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VTYPEDETAILLIB.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VTYPEDETAILLIB.Caption = "Poste"
        Me.GCol_VTYPEDETAILLIB.FieldName = "VTYPEDETAILLIB"
        Me.GCol_VTYPEDETAILLIB.Name = "GCol_VTYPEDETAILLIB"
        Me.GCol_VTYPEDETAILLIB.Visible = True
        Me.GCol_VTYPEDETAILLIB.VisibleIndex = 2
        Me.GCol_VTYPEDETAILLIB.Width = 163
        '
        'BtnValid
        '
        Me.BtnValid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValid.Location = New System.Drawing.Point(485, 413)
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.Size = New System.Drawing.Size(95, 32)
        Me.BtnValid.TabIndex = 1
        Me.BtnValid.Text = "Valider"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(374, 413)
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
        Me.LblTitre.Size = New System.Drawing.Size(568, 43)
        Me.LblTitre.TabIndex = 53
        Me.LblTitre.Text = "Appliquer le(s) profil(s) type suivant à {0} :"
        '
        'FrmGestionAccessGroup_ListeProfilType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(592, 457)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnValid)
        Me.Controls.Add(Me.GCProfils)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGestionAccessGroup_ListeProfilType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Liste des profils type"
        CType(Me.GCProfils, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVProfils, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkNCOCHE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GCProfils As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVProfils As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GColCoche As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnValid As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents RepItemChkNCOCHE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents LblTitre As Label
    Friend WithEvents GCol_CPERTYP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VTYPELIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NSERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VTYPEDETAILLIB As DevExpress.XtraGrid.Columns.GridColumn
End Class
