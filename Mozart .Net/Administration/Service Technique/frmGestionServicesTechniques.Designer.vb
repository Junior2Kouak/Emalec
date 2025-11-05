<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionServicesTechniques
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionServicesTechniques))
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonExporter = New System.Windows.Forms.Button()
        Me.ButtonAjouter = New System.Windows.Forms.Button()
        Me.ButtonDetails = New System.Windows.Forms.Button()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Num = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Adresse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Ville = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ContactTechnique = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ContactSécurité = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonExporter)
        Me.GroupBox1.Controls.Add(Me.ButtonAjouter)
        Me.GroupBox1.Controls.Add(Me.ButtonDetails)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'ButtonExporter
        '
        resources.ApplyResources(Me.ButtonExporter, "ButtonExporter")
        Me.ButtonExporter.Name = "ButtonExporter"
        Me.ButtonExporter.UseVisualStyleBackColor = True
        '
        'ButtonAjouter
        '
        resources.ApplyResources(Me.ButtonAjouter, "ButtonAjouter")
        Me.ButtonAjouter.Name = "ButtonAjouter"
        Me.ButtonAjouter.Tag = "465"
        Me.ButtonAjouter.UseVisualStyleBackColor = True
        '
        'ButtonDetails
        '
        resources.ApplyResources(Me.ButtonDetails, "ButtonDetails")
        Me.ButtonDetails.Name = "ButtonDetails"
        Me.ButtonDetails.UseVisualStyleBackColor = True
        '
        'GridControl1
        '
        resources.ApplyResources(Me.GridControl1, "GridControl1")
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Red
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.SelectedRow.BackColor2 = CType(resources.GetObject("GridView1.Appearance.SelectedRow.BackColor2"), System.Drawing.Color)
        Me.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Num, Me.Nom, Me.Adresse, Me.Ville, Me.ContactTechnique, Me.ContactSécurité})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsPrint.PrintPreview = True
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Num
        '
        resources.ApplyResources(Me.Num, "Num")
        Me.Num.FieldName = "NSERVTECHNUM"
        Me.Num.Name = "Num"
        '
        'Nom
        '
        Me.Nom.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Nom.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Nom, "Nom")
        Me.Nom.FieldName = "VSERVTECHNOM"
        Me.Nom.Name = "Nom"
        Me.Nom.OptionsColumn.AllowEdit = False
        Me.Nom.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Nom.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("Nom.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'Adresse
        '
        Me.Adresse.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Adresse.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Adresse, "Adresse")
        Me.Adresse.FieldName = "VSERVTECHAD1"
        Me.Adresse.Name = "Adresse"
        Me.Adresse.OptionsColumn.AllowEdit = False
        Me.Adresse.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'Ville
        '
        Me.Ville.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Ville.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Ville, "Ville")
        Me.Ville.FieldName = "VSERVTECHVIL"
        Me.Ville.Name = "Ville"
        Me.Ville.OptionsColumn.AllowEdit = False
        Me.Ville.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ContactTechnique
        '
        Me.ContactTechnique.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ContactTechnique.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.ContactTechnique, "ContactTechnique")
        Me.ContactTechnique.FieldName = "CONTTECH"
        Me.ContactTechnique.Name = "ContactTechnique"
        Me.ContactTechnique.OptionsColumn.AllowEdit = False
        Me.ContactTechnique.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ContactSécurité
        '
        Me.ContactSécurité.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ContactSécurité.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.ContactSécurité, "ContactSécurité")
        Me.ContactSécurité.FieldName = "CONTSEC"
        Me.ContactSécurité.Name = "ContactSécurité"
        Me.ContactSécurité.OptionsColumn.AllowEdit = False
        Me.ContactSécurité.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'frmGestionServicesTechniques
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmGestionServicesTechniques"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents ButtonAjouter As System.Windows.Forms.Button
  Friend WithEvents ButtonDetails As System.Windows.Forms.Button
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents ButtonExporter As System.Windows.Forms.Button
    Private WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents Nom As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Adresse As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Ville As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ContactTechnique As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ContactSécurité As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Num As DevExpress.XtraGrid.Columns.GridColumn
End Class
