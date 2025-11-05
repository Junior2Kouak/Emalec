<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListeInfoTablet
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeInfoTablet))
    Me.LabelTitre = New System.Windows.Forms.Label()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonImprimer = New System.Windows.Forms.Button()
        Me.BtnInfoTablet = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GCListeTablet = New DevExpress.XtraGrid.GridControl()
        Me.GVListeTablet = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NORDINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ITEHTRIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ISOPHOSAV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DATE_VERIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CORDIACTIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VORDINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bRELOAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.npernum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GCListeTablet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeTablet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonImprimer)
        Me.GroupBox1.Controls.Add(Me.BtnInfoTablet)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'ButtonImprimer
        '
        resources.ApplyResources(Me.ButtonImprimer, "ButtonImprimer")
        Me.ButtonImprimer.Name = "ButtonImprimer"
        Me.ButtonImprimer.UseVisualStyleBackColor = True
        '
        'BtnInfoTablet
        '
        resources.ApplyResources(Me.BtnInfoTablet, "BtnInfoTablet")
        Me.BtnInfoTablet.Name = "BtnInfoTablet"
        Me.BtnInfoTablet.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GCListeTablet
        '
        resources.ApplyResources(Me.GCListeTablet, "GCListeTablet")
        Me.GCListeTablet.MainView = Me.GVListeTablet
        Me.GCListeTablet.Name = "GCListeTablet"
        Me.GCListeTablet.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeTablet})
        '
        'GVListeTablet
        '
        Me.GVListeTablet.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
        Me.GVListeTablet.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVListeTablet.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Silver
        Me.GVListeTablet.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVListeTablet.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.White
        Me.GVListeTablet.Appearance.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GVListeTablet.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVListeTablet.Appearance.FixedLine.BackColor = System.Drawing.Color.Silver
        Me.GVListeTablet.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVListeTablet.Appearance.FocusedCell.BackColor = System.Drawing.Color.Silver
        Me.GVListeTablet.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GVListeTablet.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListeTablet.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVListeTablet.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Red
        Me.GVListeTablet.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVListeTablet.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVListeTablet.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVListeTablet.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeTablet.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeTablet.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeTablet.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeTablet.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeTablet.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVListeTablet.Appearance.OddRow.Options.UseBackColor = True
        Me.GVListeTablet.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVListeTablet.Appearance.OddRow.Options.UseForeColor = True
        Me.GVListeTablet.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.GVListeTablet.Appearance.SelectedRow.BackColor2 = CType(resources.GetObject("GVListeTablet.Appearance.SelectedRow.BackColor2"), System.Drawing.Color)
        Me.GVListeTablet.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVListeTablet.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListeTablet.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVListeTablet.AppearancePrint.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GVListeTablet.AppearancePrint.FilterPanel.Options.UseBackColor = True
        Me.GVListeTablet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NORDINUM, Me.VPERNOM, Me.ITEHTRIS, Me.ISOPHOSAV, Me.DATE_VERIF, Me.OS, Me.CORDIACTIF, Me.VORDINOM, Me.bRELOAD, Me.npernum})
        Me.GVListeTablet.GridControl = Me.GCListeTablet
        Me.GVListeTablet.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVListeTablet.Name = "GVListeTablet"
        Me.GVListeTablet.OptionsBehavior.Editable = False
        Me.GVListeTablet.OptionsBehavior.ReadOnly = True
        Me.GVListeTablet.OptionsCustomization.AllowGroup = False
        Me.GVListeTablet.OptionsPrint.PrintPreview = True
        Me.GVListeTablet.OptionsView.ColumnAutoWidth = False
        Me.GVListeTablet.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListeTablet.OptionsView.EnableAppearanceOddRow = True
        Me.GVListeTablet.OptionsView.ShowAutoFilterRow = True
        Me.GVListeTablet.OptionsView.ShowFooter = True
        Me.GVListeTablet.OptionsView.ShowGroupPanel = False
        '
        'NORDINUM
        '
        Me.NORDINUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NORDINUM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NORDINUM, "NORDINUM")
        Me.NORDINUM.FieldName = "NTABLETNUM"
        Me.NORDINUM.Name = "NORDINUM"
        Me.NORDINUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.NORDINUM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("NORDINUM.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'VPERNOM
        '
        Me.VPERNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VPERNOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VPERNOM, "VPERNOM")
        Me.VPERNOM.FieldName = "VPERNOM"
        Me.VPERNOM.Name = "VPERNOM"
        Me.VPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ITEHTRIS
        '
        Me.ITEHTRIS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ITEHTRIS.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.ITEHTRIS, "ITEHTRIS")
        Me.ITEHTRIS.FieldName = "ITEHTRIS"
        Me.ITEHTRIS.Name = "ITEHTRIS"
        Me.ITEHTRIS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ISOPHOSAV
        '
        Me.ISOPHOSAV.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ISOPHOSAV.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.ISOPHOSAV, "ISOPHOSAV")
        Me.ISOPHOSAV.FieldName = "ISOPHOSAV"
        Me.ISOPHOSAV.Name = "ISOPHOSAV"
        Me.ISOPHOSAV.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'DATE_VERIF
        '
        Me.DATE_VERIF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DATE_VERIF.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DATE_VERIF, "DATE_VERIF")
        Me.DATE_VERIF.FieldName = "DATE_VERIF"
        Me.DATE_VERIF.Name = "DATE_VERIF"
        Me.DATE_VERIF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'OS
        '
        Me.OS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.OS.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.OS, "OS")
        Me.OS.FieldName = "OS"
        Me.OS.Name = "OS"
        Me.OS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'CORDIACTIF
        '
        Me.CORDIACTIF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.CORDIACTIF.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.CORDIACTIF, "CORDIACTIF")
        Me.CORDIACTIF.FieldName = "CORDIACTIF"
        Me.CORDIACTIF.Name = "CORDIACTIF"
        Me.CORDIACTIF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VORDINOM
        '
        Me.VORDINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VORDINOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VORDINOM, "VORDINOM")
        Me.VORDINOM.FieldName = "VORDINOM"
        Me.VORDINOM.Name = "VORDINOM"
        Me.VORDINOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'bRELOAD
        '
        Me.bRELOAD.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.bRELOAD.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.bRELOAD, "bRELOAD")
        Me.bRELOAD.FieldName = "bRELOAD"
        Me.bRELOAD.Name = "bRELOAD"
        Me.bRELOAD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'npernum
        '
        resources.ApplyResources(Me.npernum, "npernum")
        Me.npernum.FieldName = "npernum"
        Me.npernum.Name = "npernum"
        Me.npernum.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'frmListeInfoTablet
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GCListeTablet)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmListeInfoTablet"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GCListeTablet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeTablet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents LabelSte As System.Windows.Forms.Label
  Friend WithEvents cboSociete As System.Windows.Forms.ComboBox
  Private WithEvents GCListeTablet As DevExpress.XtraGrid.GridControl
  Private WithEvents GVListeTablet As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents ITEHTRIS As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents ISOPHOSAV As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents DATE_VERIF As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents OS As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents bRELOAD As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents npernum As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents VPERNOM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents CORDIACTIF As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents VORDINOM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents NORDINUM As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BtnInfoTablet As Button
    Friend WithEvents ButtonImprimer As Button
    Friend WithEvents SFD As SaveFileDialog
End Class
