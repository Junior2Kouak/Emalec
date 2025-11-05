<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotationFO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotationFO))
        Me.lblDateJour = New System.Windows.Forms.Label()
        Me.GCStat = New DevExpress.XtraGrid.GridControl()
        Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.nstfnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.vstfnom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nbcommandes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nbcourriers = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.delaiFact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.notation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.ButtonExporter = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDateJour
        '
        resources.ApplyResources(Me.lblDateJour, "lblDateJour")
        Me.lblDateJour.Name = "lblDateJour"
        '
        'GCStat
        '
        resources.ApplyResources(Me.GCStat, "GCStat")
        Me.GCStat.MainView = Me.GVStat
        Me.GCStat.Name = "GCStat"
        Me.GCStat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStat})
        '
        'GVStat
        '
        Me.GVStat.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVStat.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVStat.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVStat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVStat.ColumnPanelRowHeight = 40
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nstfnum, Me.vstfnom, Me.nbcommandes, Me.nbcourriers, Me.delaiFact, Me.notation})
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsView.ShowAutoFilterRow = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'nstfnum
        '
        resources.ApplyResources(Me.nstfnum, "nstfnum")
        Me.nstfnum.FieldName = "nstfnum"
        Me.nstfnum.Name = "nstfnum"
        '
        'vstfnom
        '
        Me.vstfnom.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.vstfnom.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.vstfnom, "vstfnom")
        Me.vstfnom.FieldName = "vstfnom"
        Me.vstfnom.Name = "vstfnom"
        '
        'nbcommandes
        '
        Me.nbcommandes.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.nbcommandes.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.nbcommandes, "nbcommandes")
        Me.nbcommandes.FieldName = "nbcommandes"
        Me.nbcommandes.Name = "nbcommandes"
        '
        'nbcourriers
        '
        Me.nbcourriers.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.nbcourriers.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.nbcourriers, "nbcourriers")
        Me.nbcourriers.FieldName = "nbcourriers"
        Me.nbcourriers.Name = "nbcourriers"
        '
        'delaiFact
        '
        Me.delaiFact.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.delaiFact.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.delaiFact, "delaiFact")
        Me.delaiFact.FieldName = "delaiFact"
        Me.delaiFact.Name = "delaiFact"
        '
        'notation
        '
        Me.notation.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.notation.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.notation, "notation")
        Me.notation.FieldName = "notation"
        Me.notation.Name = "notation"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.ButtonExporter)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
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
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'frmNotationFO
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDateJour)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "frmNotationFO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDateJour As System.Windows.Forms.Label
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonExporter As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents nstfnum As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents vstfnom As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents nbcommandes As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents nbcourriers As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents delaiFact As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents notation As DevExpress.XtraGrid.Columns.GridColumn
End Class
