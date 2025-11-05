<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeInformatique
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeInformatique))
    Me.LabelTitre = New System.Windows.Forms.Label()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.BtnInfoTablet = New System.Windows.Forms.Button()
    Me.BtnLicences = New System.Windows.Forms.Button()
    Me.ButtonImprimer = New System.Windows.Forms.Button()
    Me.ButtonRestaurer = New System.Windows.Forms.Button()
    Me.ButtonLstArchives = New System.Windows.Forms.Button()
    Me.ButtonArchiver = New System.Windows.Forms.Button()
    Me.ButtonDetails = New System.Windows.Forms.Button()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.BtnAjouter = New System.Windows.Forms.Button()
    Me.LabelSte = New System.Windows.Forms.Label()
    Me.cboSociete = New System.Windows.Forms.ComboBox()
    Me.GCListeOrdi = New DevExpress.XtraGrid.GridControl()
    Me.GVListeOrdi = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_BATT_RETOUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NORDINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VSOCIETE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VORDIMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VORDIMARQUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VORDITYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VORDINUMSERIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VORDIAFFECTATION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VORDI_ANYDESK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VORDIIMPL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DORDIDATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VORDINUMIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CORDIECO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VORDIOBS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GCListeOrdi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeOrdi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.BtnInfoTablet)
        Me.GroupBox1.Controls.Add(Me.BtnLicences)
        Me.GroupBox1.Controls.Add(Me.ButtonImprimer)
        Me.GroupBox1.Controls.Add(Me.ButtonRestaurer)
        Me.GroupBox1.Controls.Add(Me.ButtonLstArchives)
        Me.GroupBox1.Controls.Add(Me.ButtonArchiver)
        Me.GroupBox1.Controls.Add(Me.ButtonDetails)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnAjouter)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'BtnInfoTablet
        '
        resources.ApplyResources(Me.BtnInfoTablet, "BtnInfoTablet")
        Me.BtnInfoTablet.Name = "BtnInfoTablet"
        Me.BtnInfoTablet.UseVisualStyleBackColor = True
        '
        'BtnLicences
        '
        resources.ApplyResources(Me.BtnLicences, "BtnLicences")
        Me.BtnLicences.Name = "BtnLicences"
        Me.BtnLicences.UseVisualStyleBackColor = True
        '
        'ButtonImprimer
        '
        resources.ApplyResources(Me.ButtonImprimer, "ButtonImprimer")
        Me.ButtonImprimer.Name = "ButtonImprimer"
        Me.ButtonImprimer.UseVisualStyleBackColor = True
        '
        'ButtonRestaurer
        '
        resources.ApplyResources(Me.ButtonRestaurer, "ButtonRestaurer")
        Me.ButtonRestaurer.Name = "ButtonRestaurer"
        Me.ButtonRestaurer.UseVisualStyleBackColor = True
        '
        'ButtonLstArchives
        '
        resources.ApplyResources(Me.ButtonLstArchives, "ButtonLstArchives")
        Me.ButtonLstArchives.Name = "ButtonLstArchives"
        Me.ButtonLstArchives.UseVisualStyleBackColor = True
        '
        'ButtonArchiver
        '
        resources.ApplyResources(Me.ButtonArchiver, "ButtonArchiver")
        Me.ButtonArchiver.Name = "ButtonArchiver"
        Me.ButtonArchiver.UseVisualStyleBackColor = True
        '
        'ButtonDetails
        '
        resources.ApplyResources(Me.ButtonDetails, "ButtonDetails")
        Me.ButtonDetails.Name = "ButtonDetails"
        Me.ButtonDetails.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnAjouter
        '
        resources.ApplyResources(Me.BtnAjouter, "BtnAjouter")
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'LabelSte
        '
        resources.ApplyResources(Me.LabelSte, "LabelSte")
        Me.LabelSte.Name = "LabelSte"
        '
        'cboSociete
        '
        Me.cboSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSociete.FormattingEnabled = True
        resources.ApplyResources(Me.cboSociete, "cboSociete")
        Me.cboSociete.Name = "cboSociete"
        Me.cboSociete.Tag = "114"
        '
        'GCListeOrdi
        '
        resources.ApplyResources(Me.GCListeOrdi, "GCListeOrdi")
        Me.GCListeOrdi.MainView = Me.GVListeOrdi
        Me.GCListeOrdi.Name = "GCListeOrdi"
        Me.GCListeOrdi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeOrdi})
        '
        'GVListeOrdi
        '
        Me.GVListeOrdi.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
        Me.GVListeOrdi.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVListeOrdi.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Silver
        Me.GVListeOrdi.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVListeOrdi.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.White
        Me.GVListeOrdi.Appearance.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GVListeOrdi.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVListeOrdi.Appearance.FixedLine.BackColor = System.Drawing.Color.Silver
        Me.GVListeOrdi.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVListeOrdi.Appearance.FocusedCell.BackColor = System.Drawing.Color.Silver
        Me.GVListeOrdi.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GVListeOrdi.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListeOrdi.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVListeOrdi.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Red
        Me.GVListeOrdi.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVListeOrdi.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVListeOrdi.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVListeOrdi.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeOrdi.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeOrdi.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeOrdi.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeOrdi.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeOrdi.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVListeOrdi.Appearance.OddRow.Options.UseBackColor = True
        Me.GVListeOrdi.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVListeOrdi.Appearance.OddRow.Options.UseForeColor = True
        Me.GVListeOrdi.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.GVListeOrdi.Appearance.SelectedRow.BackColor2 = CType(resources.GetObject("GVListeOrdi.Appearance.SelectedRow.BackColor2"), System.Drawing.Color)
        Me.GVListeOrdi.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVListeOrdi.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListeOrdi.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVListeOrdi.AppearancePrint.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GVListeOrdi.AppearancePrint.FilterPanel.Options.UseBackColor = True
        Me.GVListeOrdi.AutoFillColumn = Me.VORDIOBS
        Me.GVListeOrdi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NORDINUM, Me.VSOCIETE, Me.VORDIMAT, Me.VORDIMARQUE, Me.VORDITYPE, Me.VORDINUMSERIE, Me.VORDIAFFECTATION, Me.VORDI_ANYDESK, Me.VORDIIMPL, Me.DORDIDATE, Me.VORDINUMIP, Me.CORDIECO, Me.VORDIOBS, Me.GCol_BATT_RETOUR})
        Me.GVListeOrdi.GridControl = Me.GCListeOrdi
        Me.GVListeOrdi.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVListeOrdi.Name = "GVListeOrdi"
        Me.GVListeOrdi.OptionsBehavior.Editable = False
        Me.GVListeOrdi.OptionsBehavior.ReadOnly = True
        Me.GVListeOrdi.OptionsCustomization.AllowGroup = False
        Me.GVListeOrdi.OptionsPrint.PrintPreview = True
        Me.GVListeOrdi.OptionsView.ColumnAutoWidth = False
        Me.GVListeOrdi.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListeOrdi.OptionsView.EnableAppearanceOddRow = True
        Me.GVListeOrdi.OptionsView.ShowAutoFilterRow = True
        Me.GVListeOrdi.OptionsView.ShowFooter = True
        Me.GVListeOrdi.OptionsView.ShowGroupPanel = False
        '
        'GCol_BATT_RETOUR
        '
        Me.GCol_BATT_RETOUR.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_BATT_RETOUR.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GCol_BATT_RETOUR, "GCol_BATT_RETOUR")
        Me.GCol_BATT_RETOUR.FieldName = "BATT_RETOUR"
        Me.GCol_BATT_RETOUR.Name = "GCol_BATT_RETOUR"
        '
        'NORDINUM
        '
        Me.NORDINUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NORDINUM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NORDINUM, "NORDINUM")
        Me.NORDINUM.FieldName = "NORDINUM"
        Me.NORDINUM.Name = "NORDINUM"
        Me.NORDINUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.NORDINUM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("NORDINUM.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'VSOCIETE
        '
        Me.VSOCIETE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VSOCIETE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VSOCIETE, "VSOCIETE")
        Me.VSOCIETE.FieldName = "VSOCIETE"
        Me.VSOCIETE.Name = "VSOCIETE"
        '
        'VORDIMAT
        '
        Me.VORDIMAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VORDIMAT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VORDIMAT, "VORDIMAT")
        Me.VORDIMAT.FieldName = "VORDIMAT"
        Me.VORDIMAT.Name = "VORDIMAT"
        Me.VORDIMAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VORDIMARQUE
        '
        Me.VORDIMARQUE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VORDIMARQUE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VORDIMARQUE, "VORDIMARQUE")
        Me.VORDIMARQUE.FieldName = "VORDIMARQUE"
        Me.VORDIMARQUE.Name = "VORDIMARQUE"
        Me.VORDIMARQUE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VORDITYPE
        '
        Me.VORDITYPE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VORDITYPE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VORDITYPE, "VORDITYPE")
        Me.VORDITYPE.FieldName = "VORDITYPE"
        Me.VORDITYPE.Name = "VORDITYPE"
        Me.VORDITYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VORDINUMSERIE
        '
        Me.VORDINUMSERIE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VORDINUMSERIE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VORDINUMSERIE, "VORDINUMSERIE")
        Me.VORDINUMSERIE.FieldName = "VORDINUMSERIE"
        Me.VORDINUMSERIE.Name = "VORDINUMSERIE"
        Me.VORDINUMSERIE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VORDIAFFECTATION
        '
        Me.VORDIAFFECTATION.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VORDIAFFECTATION.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VORDIAFFECTATION, "VORDIAFFECTATION")
        Me.VORDIAFFECTATION.FieldName = "VORDIAFFECTATION"
        Me.VORDIAFFECTATION.Name = "VORDIAFFECTATION"
        Me.VORDIAFFECTATION.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VORDI_ANYDESK
        '
        Me.VORDI_ANYDESK.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VORDI_ANYDESK.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VORDI_ANYDESK, "VORDI_ANYDESK")
        Me.VORDI_ANYDESK.FieldName = "VORDI_ANYDESK"
        Me.VORDI_ANYDESK.Name = "VORDI_ANYDESK"
        Me.VORDI_ANYDESK.OptionsColumn.ReadOnly = True
        '
        'VORDIIMPL
        '
        Me.VORDIIMPL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VORDIIMPL.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VORDIIMPL, "VORDIIMPL")
        Me.VORDIIMPL.FieldName = "VORDIIMPL"
        Me.VORDIIMPL.Name = "VORDIIMPL"
        Me.VORDIIMPL.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'DORDIDATE
        '
        Me.DORDIDATE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DORDIDATE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DORDIDATE, "DORDIDATE")
        Me.DORDIDATE.FieldName = "DORDIDATE"
        Me.DORDIDATE.Name = "DORDIDATE"
        Me.DORDIDATE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VORDINUMIP
        '
        Me.VORDINUMIP.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VORDINUMIP.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VORDINUMIP, "VORDINUMIP")
        Me.VORDINUMIP.FieldName = "VORDINUMIP"
        Me.VORDINUMIP.Name = "VORDINUMIP"
        Me.VORDINUMIP.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'CORDIECO
        '
        Me.CORDIECO.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.CORDIECO.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.CORDIECO, "CORDIECO")
        Me.CORDIECO.FieldName = "CORDIECO"
        Me.CORDIECO.Name = "CORDIECO"
        Me.CORDIECO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VORDIOBS
        '
        Me.VORDIOBS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VORDIOBS.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VORDIOBS, "VORDIOBS")
        Me.VORDIOBS.FieldName = "VORDIOBS"
        Me.VORDIOBS.Name = "VORDIOBS"
        Me.VORDIOBS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'frmListeInformatique
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnFermer
        Me.Controls.Add(Me.GCListeOrdi)
        Me.Controls.Add(Me.LabelSte)
        Me.Controls.Add(Me.cboSociete)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmListeInformatique"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GCListeOrdi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeOrdi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents ButtonImprimer As System.Windows.Forms.Button
  Friend WithEvents ButtonRestaurer As System.Windows.Forms.Button
  Friend WithEvents ButtonLstArchives As System.Windows.Forms.Button
  Friend WithEvents ButtonArchiver As System.Windows.Forms.Button
  Friend WithEvents ButtonDetails As System.Windows.Forms.Button
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents BtnAjouter As System.Windows.Forms.Button
  Friend WithEvents LabelSte As System.Windows.Forms.Label
  Friend WithEvents cboSociete As System.Windows.Forms.ComboBox
  Friend WithEvents BtnLicences As System.Windows.Forms.Button
  Private WithEvents GCListeOrdi As DevExpress.XtraGrid.GridControl
  Private WithEvents GVListeOrdi As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents VSOCIETE As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents VORDIMAT As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents VORDIMARQUE As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents VORDITYPE As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents VORDINUMSERIE As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents VORDIAFFECTATION As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents VORDIIMPL As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents DORDIDATE As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents VORDINUMIP As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents CORDIECO As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents VORDIOBS As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents NORDINUM As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BtnInfoTablet As Button
  Friend WithEvents GCol_BATT_RETOUR As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents VORDI_ANYDESK As DevExpress.XtraGrid.Columns.GridColumn
End Class
