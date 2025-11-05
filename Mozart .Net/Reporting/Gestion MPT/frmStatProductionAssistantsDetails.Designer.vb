<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatProductionAssistantsDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatProductionAssistantsDetails))
        Me.lblDateJour = New System.Windows.Forms.Label()
        Me.GCStat = New DevExpress.XtraGrid.GridControl()
        Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.val1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.val2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.val3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.val4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.val5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.val6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.ButtonExporter = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.LabelTitre = New System.Windows.Forms.Label()
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
        Me.GVStat.ColumnPanelRowHeight = 80
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.val1, Me.val2, Me.val3, Me.val4, Me.val5, Me.val6})
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsView.ShowAutoFilterRow = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'val1
        '
        Me.val1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.val1.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.val1, "val1")
        Me.val1.FieldName = "val1"
        Me.val1.Name = "val1"
        '
        'val2
        '
        Me.val2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.val2.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.val2, "val2")
        Me.val2.FieldName = "val2"
        Me.val2.Name = "val2"
        '
        'val3
        '
        Me.val3.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.val3.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.val3, "val3")
        Me.val3.FieldName = "val3"
        Me.val3.Name = "val3"
        '
        'val4
        '
        Me.val4.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.val4.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.val4, "val4")
        Me.val4.FieldName = "val4"
        Me.val4.Name = "val4"
        '
        'val5
        '
        Me.val5.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.val5.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.val5, "val5")
        Me.val5.FieldName = "val5"
        Me.val5.Name = "val5"
        '
        'val6
        '
        Me.val6.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.val6.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.val6, "val6")
        Me.val6.FieldName = "val6"
        Me.val6.Name = "val6"
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
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'frmStatProductionAssistantsDetails
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.lblDateJour)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "frmStatProductionAssistantsDetails"
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
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents val1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents val2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents val3 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents val4 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents val5 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents val6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
