<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSTTPartenaires
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSTTPartenaires))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NSTFNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VSTFNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VSTFCP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VSTFVIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VSTFPAYS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VSTFETRTYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DatePaetenaire = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CSTFGRPPARTVALIDE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NCT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VillesCibles = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Activités = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ACTIVITEPRINCIPALE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtRecupPresta = New System.Windows.Forms.Button()
        Me.BtrecupVilles = New System.Windows.Forms.Button()
        Me.ButtonVoir = New System.Windows.Forms.Button()
        Me.ButtonGestionPrestations = New System.Windows.Forms.Button()
        Me.ButtonGestionVillesCibles = New System.Windows.Forms.Button()
        Me.BtnAffectation = New System.Windows.Forms.Button()
        Me.ButtonExporter = New System.Windows.Forms.Button()
        Me.ButtonCarte = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.ListBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
        Me.LabelDetails = New System.Windows.Forms.Label()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Red
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.Font = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
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
        Me.GridView1.AppearancePrint.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView1.AppearancePrint.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NSTFNUM, Me.VSTFNOM, Me.VSTFCP, Me.VSTFVIL, Me.VSTFPAYS, Me.VSTFETRTYPE, Me.DatePaetenaire, Me.CSTFGRPPARTVALIDE, Me.NCT, Me.VillesCibles, Me.Activités, Me.ACTIVITEPRINCIPALE})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView1.OptionsPrint.PrintPreview = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'NSTFNUM
        '
        resources.ApplyResources(Me.NSTFNUM, "NSTFNUM")
        Me.NSTFNUM.FieldName = "NSTFNUM"
        Me.NSTFNUM.Name = "NSTFNUM"
        Me.NSTFNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.NSTFNUM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("NSTFNUM.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'VSTFNOM
        '
        Me.VSTFNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VSTFNOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VSTFNOM, "VSTFNOM")
        Me.VSTFNOM.FieldName = "VSTFNOM"
        Me.VSTFNOM.Name = "VSTFNOM"
        Me.VSTFNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.VSTFNOM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("VSTFNOM.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'VSTFCP
        '
        Me.VSTFCP.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VSTFCP.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VSTFCP, "VSTFCP")
        Me.VSTFCP.FieldName = "VSTFCP"
        Me.VSTFCP.Name = "VSTFCP"
        Me.VSTFCP.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VSTFVIL
        '
        Me.VSTFVIL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VSTFVIL.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VSTFVIL, "VSTFVIL")
        Me.VSTFVIL.FieldName = "VSTFVIL"
        Me.VSTFVIL.Name = "VSTFVIL"
        Me.VSTFVIL.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VSTFPAYS
        '
        Me.VSTFPAYS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VSTFPAYS.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VSTFPAYS, "VSTFPAYS")
        Me.VSTFPAYS.FieldName = "VSTFPAYS"
        Me.VSTFPAYS.Name = "VSTFPAYS"
        Me.VSTFPAYS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VSTFETRTYPE
        '
        Me.VSTFETRTYPE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VSTFETRTYPE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VSTFETRTYPE, "VSTFETRTYPE")
        Me.VSTFETRTYPE.FieldName = "VSTFETRTYPE"
        Me.VSTFETRTYPE.Name = "VSTFETRTYPE"
        Me.VSTFETRTYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'DatePaetenaire
        '
        Me.DatePaetenaire.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DatePaetenaire.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DatePaetenaire, "DatePaetenaire")
        Me.DatePaetenaire.FieldName = "DSTFGRPPARTENAIRE"
        Me.DatePaetenaire.Name = "DatePaetenaire"
        '
        'CSTFGRPPARTVALIDE
        '
        Me.CSTFGRPPARTVALIDE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.CSTFGRPPARTVALIDE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.CSTFGRPPARTVALIDE, "CSTFGRPPARTVALIDE")
        Me.CSTFGRPPARTVALIDE.FieldName = "CSTFGRPPARTVALIDE"
        Me.CSTFGRPPARTVALIDE.Name = "CSTFGRPPARTVALIDE"
        '
        'NCT
        '
        Me.NCT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NCT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NCT, "NCT")
        Me.NCT.FieldName = "NCT"
        Me.NCT.Name = "NCT"
        '
        'VillesCibles
        '
        Me.VillesCibles.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VillesCibles.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VillesCibles, "VillesCibles")
        Me.VillesCibles.FieldName = "VLISTEVILLES"
        Me.VillesCibles.Name = "VillesCibles"
        Me.VillesCibles.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'Activités
        '
        Me.Activités.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Activités.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Activités, "Activités")
        Me.Activités.FieldName = "VLISTEACTIVITES"
        Me.Activités.Name = "Activités"
        Me.Activités.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ACTIVITEPRINCIPALE
        '
        resources.ApplyResources(Me.ACTIVITEPRINCIPALE, "ACTIVITEPRINCIPALE")
        Me.ACTIVITEPRINCIPALE.FieldName = "ACTIVITEPRINCIPALE"
        Me.ACTIVITEPRINCIPALE.Name = "ACTIVITEPRINCIPALE"
        '
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtRecupPresta)
        Me.GroupBox1.Controls.Add(Me.BtrecupVilles)
        Me.GroupBox1.Controls.Add(Me.ButtonVoir)
        Me.GroupBox1.Controls.Add(Me.ButtonGestionPrestations)
        Me.GroupBox1.Controls.Add(Me.ButtonGestionVillesCibles)
        Me.GroupBox1.Controls.Add(Me.BtnAffectation)
        Me.GroupBox1.Controls.Add(Me.ButtonExporter)
        Me.GroupBox1.Controls.Add(Me.ButtonCarte)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'BtRecupPresta
        '
        resources.ApplyResources(Me.BtRecupPresta, "BtRecupPresta")
        Me.BtRecupPresta.Name = "BtRecupPresta"
        Me.BtRecupPresta.Tag = "456"
        Me.BtRecupPresta.UseVisualStyleBackColor = True
        '
        'BtrecupVilles
        '
        resources.ApplyResources(Me.BtrecupVilles, "BtrecupVilles")
        Me.BtrecupVilles.Name = "BtrecupVilles"
        Me.BtrecupVilles.Tag = "456"
        Me.BtrecupVilles.UseVisualStyleBackColor = True
        '
        'ButtonVoir
        '
        resources.ApplyResources(Me.ButtonVoir, "ButtonVoir")
        Me.ButtonVoir.Name = "ButtonVoir"
        Me.ButtonVoir.Tag = "449"
        Me.ButtonVoir.UseVisualStyleBackColor = True
        '
        'ButtonGestionPrestations
        '
        Me.ButtonGestionPrestations.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.ButtonGestionPrestations, "ButtonGestionPrestations")
        Me.ButtonGestionPrestations.Name = "ButtonGestionPrestations"
        Me.ButtonGestionPrestations.Tag = "455"
        Me.ButtonGestionPrestations.UseVisualStyleBackColor = False
        '
        'ButtonGestionVillesCibles
        '
        Me.ButtonGestionVillesCibles.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.ButtonGestionVillesCibles, "ButtonGestionVillesCibles")
        Me.ButtonGestionVillesCibles.Name = "ButtonGestionVillesCibles"
        Me.ButtonGestionVillesCibles.Tag = "455"
        Me.ButtonGestionVillesCibles.UseVisualStyleBackColor = False
        '
        'BtnAffectation
        '
        resources.ApplyResources(Me.BtnAffectation, "BtnAffectation")
        Me.BtnAffectation.Name = "BtnAffectation"
        Me.BtnAffectation.UseVisualStyleBackColor = True
        '
        'ButtonExporter
        '
        resources.ApplyResources(Me.ButtonExporter, "ButtonExporter")
        Me.ButtonExporter.Name = "ButtonExporter"
        Me.ButtonExporter.UseVisualStyleBackColor = True
        '
        'ButtonCarte
        '
        resources.ApplyResources(Me.ButtonCarte, "ButtonCarte")
        Me.ButtonCarte.Name = "ButtonCarte"
        Me.ButtonCarte.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'ListBoxControl1
        '
        Me.ListBoxControl1.Appearance.Font = CType(resources.GetObject("ListBoxControl1.Appearance.Font"), System.Drawing.Font)
        Me.ListBoxControl1.Appearance.Options.UseFont = True
        resources.ApplyResources(Me.ListBoxControl1, "ListBoxControl1")
        Me.ListBoxControl1.Name = "ListBoxControl1"
        '
        'LabelDetails
        '
        resources.ApplyResources(Me.LabelDetails, "LabelDetails")
        Me.LabelDetails.Name = "LabelDetails"
        '
        'frmSTTPartenaires
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LabelDetails)
        Me.Controls.Add(Me.ListBoxControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSTTPartenaires"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonExporter As System.Windows.Forms.Button
    Friend WithEvents ButtonCarte As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LabelDetails As System.Windows.Forms.Label
    Friend WithEvents BtnAffectation As System.Windows.Forms.Button
    Friend WithEvents ButtonGestionVillesCibles As System.Windows.Forms.Button
    Friend WithEvents ButtonGestionPrestations As System.Windows.Forms.Button
    Friend WithEvents ButtonVoir As System.Windows.Forms.Button
    Friend WithEvents BtRecupPresta As System.Windows.Forms.Button
    Friend WithEvents BtrecupVilles As System.Windows.Forms.Button
    Private WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents NSTFNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VSTFNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VSTFPAYS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VSTFVIL As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VSTFCP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Activités As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VillesCibles As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VSTFETRTYPE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ListBoxControl1 As DevExpress.XtraEditors.ListBoxControl
    Private WithEvents CSTFGRPPARTVALIDE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ACTIVITEPRINCIPALE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NCT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DatePaetenaire As DevExpress.XtraGrid.Columns.GridColumn
End Class
