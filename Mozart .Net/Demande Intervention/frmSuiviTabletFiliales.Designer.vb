<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuiviTabletFiliales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuiviTabletFiliales))
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.btnActif = New System.Windows.Forms.Button()
        Me.btnConsultArchives = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GCStat = New DevExpress.XtraGrid.GridControl()
        Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NACTNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DDATET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VFILIALE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VRMQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VACTDES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.btnValider)
        Me.GrpActions.Controls.Add(Me.btnActif)
        Me.GrpActions.Controls.Add(Me.btnConsultArchives)
        Me.GrpActions.Controls.Add(Me.Button1)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'btnValider
        '
        resources.ApplyResources(Me.btnValider, "btnValider")
        Me.btnValider.Name = "btnValider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'btnActif
        '
        resources.ApplyResources(Me.btnActif, "btnActif")
        Me.btnActif.Name = "btnActif"
        Me.btnActif.UseVisualStyleBackColor = True
        '
        'btnConsultArchives
        '
        resources.ApplyResources(Me.btnConsultArchives, "btnConsultArchives")
        Me.btnConsultArchives.Name = "btnConsultArchives"
        Me.btnConsultArchives.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
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
        Me.GVStat.ColumnPanelRowHeight = 90
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NACTNUM, Me.NDINNUM, Me.DDATET, Me.VFILIALE, Me.VCLINOM, Me.VSITNOM, Me.VRMQ, Me.VACTDES})
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsView.ShowAutoFilterRow = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'NACTNUM
        '
        Me.NACTNUM.FieldName = "NACTNUM"
        Me.NACTNUM.Name = "NACTNUM"
        '
        'NDINNUM
        '
        resources.ApplyResources(Me.NDINNUM, "NDINNUM")
        Me.NDINNUM.FieldName = "NDINNUM"
        Me.NDINNUM.Name = "NDINNUM"
        '
        'DDATET
        '
        Me.DDATET.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DDATET.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DDATET, "DDATET")
        Me.DDATET.FieldName = "DDATET"
        Me.DDATET.Name = "DDATET"
        '
        'VFILIALE
        '
        Me.VFILIALE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VFILIALE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VFILIALE, "VFILIALE")
        Me.VFILIALE.FieldName = "VFILIALE"
        Me.VFILIALE.Name = "VFILIALE"
        '
        'VCLINOM
        '
        Me.VCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VCLINOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VCLINOM, "VCLINOM")
        Me.VCLINOM.FieldName = "VCLINOM"
        Me.VCLINOM.Name = "VCLINOM"
        '
        'VSITNOM
        '
        Me.VSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VSITNOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VSITNOM, "VSITNOM")
        Me.VSITNOM.FieldName = "VSITNOM"
        Me.VSITNOM.Name = "VSITNOM"
        '
        'VRMQ
        '
        Me.VRMQ.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VRMQ.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VRMQ, "VRMQ")
        Me.VRMQ.FieldName = "VRMQ"
        Me.VRMQ.Name = "VRMQ"
        '
        'VACTDES
        '
        Me.VACTDES.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VACTDES.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VACTDES, "VACTDES")
        Me.VACTDES.FieldName = "VACTDES"
        Me.VACTDES.Name = "VACTDES"
        '
        'frmSuiviTabletFiliales
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmSuiviTabletFiliales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
  Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
  Friend WithEvents btnValider As System.Windows.Forms.Button
  Friend WithEvents btnActif As System.Windows.Forms.Button
  Friend WithEvents btnConsultArchives As System.Windows.Forms.Button
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents NACTNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VACTDES As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VFILIALE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DDATET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VRMQ As DevExpress.XtraGrid.Columns.GridColumn
End Class
