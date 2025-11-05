<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeLicences
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeLicences))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonExporter = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.VUCLICENCE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VUCPROGRAMME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NORDINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VORDIAFFECTATION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VORDIIMPL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonExporter)
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
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
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
        Me.GridView1.Appearance.HeaderPanel.Font = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.VUCLICENCE, Me.VUCPROGRAMME, Me.NORDINUM, Me.VORDIAFFECTATION, Me.VORDIIMPL})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsPrint.PrintPreview = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'VUCLICENCE
        '
        Me.VUCLICENCE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VUCLICENCE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VUCLICENCE, "VUCLICENCE")
        Me.VUCLICENCE.FieldName = "VUCLICENCE"
        Me.VUCLICENCE.Name = "VUCLICENCE"
        Me.VUCLICENCE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.VUCLICENCE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("VUCLICENCE.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'VUCPROGRAMME
        '
        Me.VUCPROGRAMME.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VUCPROGRAMME.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VUCPROGRAMME, "VUCPROGRAMME")
        Me.VUCPROGRAMME.FieldName = "VUCPROGRAMME"
        Me.VUCPROGRAMME.Name = "VUCPROGRAMME"
        Me.VUCPROGRAMME.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'NORDINUM
        '
        Me.NORDINUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NORDINUM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NORDINUM, "NORDINUM")
        Me.NORDINUM.FieldName = "NORDINUM"
        Me.NORDINUM.Name = "NORDINUM"
        Me.NORDINUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
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
        'VORDIIMPL
        '
        Me.VORDIIMPL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VORDIIMPL.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VORDIIMPL, "VORDIIMPL")
        Me.VORDIIMPL.FieldName = "VORDIIMPL"
        Me.VORDIIMPL.Name = "VORDIIMPL"
        Me.VORDIIMPL.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'frmListeLicences
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "frmListeLicences"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents ButtonExporter As System.Windows.Forms.Button
    Private WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents VUCLICENCE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VUCPROGRAMME As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NORDINUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VORDIAFFECTATION As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VORDIIMPL As DevExpress.XtraGrid.Columns.GridColumn
End Class
