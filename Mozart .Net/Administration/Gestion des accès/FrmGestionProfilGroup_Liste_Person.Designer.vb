<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionProfilGroup_Liste_Person
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
    Me.BtnValid = New System.Windows.Forms.Button()
    Me.BtnCancel = New System.Windows.Forms.Button()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.GCPers = New DevExpress.XtraGrid.GridControl()
    Me.GVPers = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GCol_NPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_VPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_FONC = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_VSOCIETE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_VPERADSI = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GCPers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnValid
        '
        Me.BtnValid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValid.Location = New System.Drawing.Point(462, 530)
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.Size = New System.Drawing.Size(95, 32)
        Me.BtnValid.TabIndex = 1
        Me.BtnValid.Text = "Valider"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(363, 530)
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
        'GCPers
        '
        Me.GCPers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GCPers.Location = New System.Drawing.Point(16, 65)
        Me.GCPers.MainView = Me.GVPers
        Me.GCPers.Name = "GCPers"
        Me.GCPers.Size = New System.Drawing.Size(541, 448)
        Me.GCPers.TabIndex = 54
        Me.GCPers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPers})
        '
        'GVPers
        '
        Me.GVPers.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVPers.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVPers.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVPers.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVPers.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_NPERNUM, Me.GCol_VPERNOM, Me.GCol_FONC, Me.GCol_VSOCIETE, Me.GCol_VPERADSI})
        Me.GVPers.GridControl = Me.GCPers
        Me.GVPers.Name = "GVPers"
        Me.GVPers.OptionsBehavior.Editable = False
        Me.GVPers.OptionsBehavior.ReadOnly = True
        Me.GVPers.OptionsCustomization.AllowGroup = False
        Me.GVPers.OptionsPrint.PrintPreview = True
        Me.GVPers.OptionsSelection.MultiSelect = True
        Me.GVPers.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GVPers.OptionsView.ShowAutoFilterRow = True
        Me.GVPers.OptionsView.ShowFooter = True
        Me.GVPers.OptionsView.ShowGroupPanel = False
        '
        'GCol_NPERNUM
        '
        Me.GCol_NPERNUM.FieldName = "NPERNUM"
        Me.GCol_NPERNUM.Name = "GCol_NPERNUM"
        Me.GCol_NPERNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_NPERNUM.Width = 130
        '
        'GCol_VPERNOM
        '
        Me.GCol_VPERNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VPERNOM.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VPERNOM.Caption = "Nom"
        Me.GCol_VPERNOM.FieldName = "VPERNOM"
        Me.GCol_VPERNOM.Name = "GCol_VPERNOM"
        Me.GCol_VPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_VPERNOM.Visible = True
        Me.GCol_VPERNOM.VisibleIndex = 1
        Me.GCol_VPERNOM.Width = 116
        '
        'GCol_FONC
        '
        Me.GCol_FONC.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_FONC.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_FONC.Caption = "Fonction"
        Me.GCol_FONC.FieldName = "FONC"
        Me.GCol_FONC.Name = "GCol_FONC"
        Me.GCol_FONC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_FONC.Visible = True
        Me.GCol_FONC.VisibleIndex = 2
        Me.GCol_FONC.Width = 80
        '
        'GCol_VSOCIETE
        '
        Me.GCol_VSOCIETE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VSOCIETE.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VSOCIETE.Caption = "Société"
        Me.GCol_VSOCIETE.FieldName = "VSOCIETE"
        Me.GCol_VSOCIETE.Name = "GCol_VSOCIETE"
        Me.GCol_VSOCIETE.Visible = True
        Me.GCol_VSOCIETE.VisibleIndex = 3
        Me.GCol_VSOCIETE.Width = 86
        '
        'GCol_VPERADSI
        '
        Me.GCol_VPERADSI.Caption = "VPERADSI"
        Me.GCol_VPERADSI.FieldName = "VPERADSI"
        Me.GCol_VPERADSI.Name = "GCol_VPERADSI"
        '
        'FrmGestionProfilGroup_Liste_Person
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(569, 574)
        Me.Controls.Add(Me.GCPers)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnValid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGestionProfilGroup_Liste_Person"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Liste des filiales"
        CType(Me.GCPers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnValid As Button
  Friend WithEvents BtnCancel As Button
  Friend WithEvents LblTitre As Label
  Private WithEvents GCPers As DevExpress.XtraGrid.GridControl
  Private WithEvents GVPers As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents GCol_NPERNUM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GCol_VPERNOM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GCol_FONC As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_VSOCIETE As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_VPERADSI As DevExpress.XtraGrid.Columns.GridColumn
End Class
