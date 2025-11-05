<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestContratsSites
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestContratsSites))
        Me.GridSite = New DevExpress.XtraGrid.GridControl()
        Me.GridViewSite = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.VSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GESTION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NBINT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.HINT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.INTERP2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.INTERP3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridViewContrat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridContrat = New DevExpress.XtraGrid.GridControl()
        Me.MenuForm = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridMain = New DevExpress.XtraGrid.GridControl()
        Me.GridViewMain = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NSIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LIBCONT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.GridSite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewContrat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridContrat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuForm.SuspendLayout()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridSite
        '
        resources.ApplyResources(Me.GridSite, "GridSite")
        Me.GridSite.MainView = Me.GridViewSite
        Me.GridSite.Name = "GridSite"
        Me.GridSite.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSite})
        '
        'GridViewSite
        '
        Me.GridViewSite.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.VSITNOM, Me.CONTRAT, Me.GESTION, Me.NBINT, Me.HINT, Me.INTERP2, Me.INTERP3})
        Me.GridViewSite.GridControl = Me.GridSite
        Me.GridViewSite.Name = "GridViewSite"
        '
        'VSITNOM
        '
        Me.VSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VSITNOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VSITNOM, "VSITNOM")
        Me.VSITNOM.FieldName = "VSITNOM"
        Me.VSITNOM.Name = "VSITNOM"
        '
        'CONTRAT
        '
        Me.CONTRAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.CONTRAT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.CONTRAT, "CONTRAT")
        Me.CONTRAT.FieldName = "VTYPECONTRAT"
        Me.CONTRAT.Name = "CONTRAT"
        '
        'GESTION
        '
        Me.GESTION.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GESTION.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GESTION, "GESTION")
        Me.GESTION.FieldName = "GESTION"
        Me.GESTION.Name = "GESTION"
        '
        'NBINT
        '
        Me.NBINT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NBINT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NBINT, "NBINT")
        Me.NBINT.FieldName = "NBINT"
        Me.NBINT.Name = "NBINT"
        '
        'HINT
        '
        Me.HINT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.HINT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.HINT, "HINT")
        Me.HINT.FieldName = "HINT"
        Me.HINT.Name = "HINT"
        '
        'INTERP2
        '
        Me.INTERP2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.INTERP2.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.INTERP2, "INTERP2")
        Me.INTERP2.FieldName = "INTERP2"
        Me.INTERP2.Name = "INTERP2"
        '
        'INTERP3
        '
        Me.INTERP3.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.INTERP3.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.INTERP3, "INTERP3")
        Me.INTERP3.FieldName = "INTERP3"
        Me.INTERP3.Name = "INTERP3"
        '
        'GridViewContrat
        '
        Me.GridViewContrat.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridViewContrat.Appearance.FocusedRow.BackColor2 = CType(resources.GetObject("GridViewContrat.Appearance.FocusedRow.BackColor2"), System.Drawing.Color)
        Me.GridViewContrat.Appearance.FocusedRow.Font = CType(resources.GetObject("GridViewContrat.Appearance.FocusedRow.Font"), System.Drawing.Font)
        Me.GridViewContrat.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridViewContrat.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridViewContrat.Appearance.FocusedRow.Options.UseFont = True
        Me.GridViewContrat.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridViewContrat.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridViewContrat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridViewContrat.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridViewContrat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NTYPECONTRAT, Me.VTYPECONTRAT})
        Me.GridViewContrat.GridControl = Me.GridContrat
        Me.GridViewContrat.Name = "GridViewContrat"
        Me.GridViewContrat.OptionsCustomization.AllowColumnMoving = False
        Me.GridViewContrat.OptionsCustomization.AllowColumnResizing = False
        Me.GridViewContrat.OptionsCustomization.AllowFilter = False
        Me.GridViewContrat.OptionsCustomization.AllowGroup = False
        Me.GridViewContrat.OptionsCustomization.AllowQuickHideColumns = False
        Me.GridViewContrat.OptionsView.ShowGroupPanel = False
        '
        'NTYPECONTRAT
        '
        resources.ApplyResources(Me.NTYPECONTRAT, "NTYPECONTRAT")
        Me.NTYPECONTRAT.FieldName = "NTYPECONTRAT"
        Me.NTYPECONTRAT.Name = "NTYPECONTRAT"
        '
        'VTYPECONTRAT
        '
        Me.VTYPECONTRAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VTYPECONTRAT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VTYPECONTRAT, "VTYPECONTRAT")
        Me.VTYPECONTRAT.FieldName = "VTYPECONTRAT"
        Me.VTYPECONTRAT.Name = "VTYPECONTRAT"
        Me.VTYPECONTRAT.OptionsColumn.AllowEdit = False
        Me.VTYPECONTRAT.OptionsColumn.ReadOnly = True
        '
        'GridContrat
        '
        resources.ApplyResources(Me.GridContrat, "GridContrat")
        Me.GridContrat.MainView = Me.GridViewContrat
        Me.GridContrat.Name = "GridContrat"
        Me.GridContrat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewContrat})
        '
        'MenuForm
        '
        Me.MenuForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem1, Me.MenuItem2})
        Me.MenuForm.Name = "Menu"
        resources.ApplyResources(Me.MenuForm, "MenuForm")
        '
        'MenuItem1
        '
        Me.MenuItem1.Name = "MenuItem1"
        resources.ApplyResources(Me.MenuItem1, "MenuItem1")
        '
        'MenuItem2
        '
        Me.MenuItem2.Name = "MenuItem2"
        resources.ApplyResources(Me.MenuItem2, "MenuItem2")
        '
        'GridMain
        '
        resources.ApplyResources(Me.GridMain, "GridMain")
        Me.GridMain.MainView = Me.GridViewMain
        Me.GridMain.Name = "GridMain"
        Me.GridMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewMain})
        '
        'GridViewMain
        '
        Me.GridViewMain.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridViewMain.Appearance.FocusedRow.BackColor2 = CType(resources.GetObject("GridViewMain.Appearance.FocusedRow.BackColor2"), System.Drawing.Color)
        Me.GridViewMain.Appearance.FocusedRow.Font = CType(resources.GetObject("GridViewMain.Appearance.FocusedRow.Font"), System.Drawing.Font)
        Me.GridViewMain.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridViewMain.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridViewMain.Appearance.FocusedRow.Options.UseFont = True
        Me.GridViewMain.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridViewMain.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridViewMain.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridViewMain.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridViewMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NSIT, Me.LIBCONT, Me.SIT})
        Me.GridViewMain.GridControl = Me.GridMain
        Me.GridViewMain.Name = "GridViewMain"
        Me.GridViewMain.OptionsCustomization.AllowColumnMoving = False
        Me.GridViewMain.OptionsCustomization.AllowColumnResizing = False
        Me.GridViewMain.OptionsCustomization.AllowFilter = False
        Me.GridViewMain.OptionsCustomization.AllowGroup = False
        Me.GridViewMain.OptionsCustomization.AllowQuickHideColumns = False
        Me.GridViewMain.OptionsView.ShowGroupPanel = False
        '
        'NSIT
        '
        resources.ApplyResources(Me.NSIT, "NSIT")
        Me.NSIT.FieldName = "NSITNUM"
        Me.NSIT.Name = "NSIT"
        '
        'LIBCONT
        '
        Me.LIBCONT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.LIBCONT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.LIBCONT, "LIBCONT")
        Me.LIBCONT.FieldName = "VTYPECONTRAT"
        Me.LIBCONT.Name = "LIBCONT"
        '
        'SIT
        '
        Me.SIT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.SIT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.SIT, "SIT")
        Me.SIT.FieldName = "VSITNOM"
        Me.SIT.Name = "SIT"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmGestContratsSites
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GridMain)
        Me.Controls.Add(Me.GridContrat)
        Me.Controls.Add(Me.GridSite)
        Me.Name = "frmGestContratsSites"
        CType(Me.GridSite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewContrat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridContrat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuForm.ResumeLayout(False)
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuForm As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents GridSite As DevExpress.XtraGrid.GridControl
    Private WithEvents GridViewSite As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GridViewContrat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents NTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridContrat As DevExpress.XtraGrid.GridControl
    Private WithEvents VSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents CONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GESTION As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NBINT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents HINT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents INTERP2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents INTERP3 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridMain As DevExpress.XtraGrid.GridControl
    Private WithEvents GridViewMain As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents SIT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NSIT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents LIBCONT As DevExpress.XtraGrid.Columns.GridColumn
End Class
