<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTableAnalytiqueH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTableAnalytiqueH))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnExportXLS = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.PGCHeures = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PGF_VPERNOM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGF_NCANNUM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGF_TOTALHR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGF_NPERNUM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGF_CPERTYP = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.GrpPeriode = New System.Windows.Forms.GroupBox()
        Me.CboAnnee = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CboMois = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridCboMois = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblRef = New System.Windows.Forms.Label()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.GColCboAnneeNIDANNEE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCboMoisNIDMOIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCboMoisSMOISNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions.SuspendLayout()
        CType(Me.PGCHeures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPeriode.SuspendLayout()
        CType(Me.CboAnnee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboMois.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCboMois, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnExportXLS)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnExportXLS
        '
        resources.ApplyResources(Me.BtnExportXLS, "BtnExportXLS")
        Me.BtnExportXLS.Name = "BtnExportXLS"
        Me.BtnExportXLS.Tag = "136"
        Me.BtnExportXLS.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Tag = "136"
        Me.BtnPrint.UseVisualStyleBackColor = True
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
        'PGCHeures
        '
        Me.PGCHeures.Appearance.Cell.ForeColor = System.Drawing.Color.Black
        Me.PGCHeures.Appearance.Cell.Options.UseForeColor = True
        Me.PGCHeures.Appearance.ColumnHeaderArea.Font = CType(resources.GetObject("PGCHeures.Appearance.ColumnHeaderArea.Font"), System.Drawing.Font)
        Me.PGCHeures.Appearance.ColumnHeaderArea.ForeColor = System.Drawing.Color.Black
        Me.PGCHeures.Appearance.ColumnHeaderArea.Options.UseFont = True
        Me.PGCHeures.Appearance.ColumnHeaderArea.Options.UseForeColor = True
        Me.PGCHeures.Appearance.ColumnHeaderArea.Options.UseTextOptions = True
        Me.PGCHeures.Appearance.ColumnHeaderArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGCHeures.Appearance.ColumnHeaderArea.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGCHeures.Appearance.FieldValueGrandTotal.ForeColor = System.Drawing.Color.Black
        Me.PGCHeures.Appearance.FieldValueGrandTotal.Options.UseForeColor = True
        Me.PGCHeures.Appearance.FieldValueTotal.ForeColor = System.Drawing.Color.Black
        Me.PGCHeures.Appearance.FieldValueTotal.Options.UseForeColor = True
        Me.PGCHeures.Appearance.GrandTotalCell.ForeColor = System.Drawing.Color.Black
        Me.PGCHeures.Appearance.GrandTotalCell.Options.UseForeColor = True
        Me.PGCHeures.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PGF_VPERNOM, Me.PGF_NCANNUM, Me.PGF_TOTALHR, Me.PGF_NPERNUM, Me.PGF_CPERTYP})
        resources.ApplyResources(Me.PGCHeures, "PGCHeures")
        Me.PGCHeures.Name = "PGCHeures"
        Me.PGCHeures.OptionsPrint.PageSettings.Landscape = True
        Me.PGCHeures.OptionsPrint.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PGCHeures.OptionsPrint.UsePrintAppearance = True
        Me.PGCHeures.OptionsView.ShowDataHeaders = False
        Me.PGCHeures.OptionsView.ShowFilterHeaders = False
        '
        'PGF_VPERNOM
        '
        Me.PGF_VPERNOM.Appearance.Cell.ForeColor = System.Drawing.Color.Black
        Me.PGF_VPERNOM.Appearance.Cell.Options.UseForeColor = True
        Me.PGF_VPERNOM.Appearance.CellGrandTotal.ForeColor = System.Drawing.Color.Black
        Me.PGF_VPERNOM.Appearance.CellGrandTotal.Options.UseForeColor = True
        Me.PGF_VPERNOM.Appearance.CellTotal.ForeColor = System.Drawing.Color.Black
        Me.PGF_VPERNOM.Appearance.CellTotal.Options.UseForeColor = True
        Me.PGF_VPERNOM.Appearance.Header.Font = CType(resources.GetObject("PGF_VPERNOM.Appearance.Header.Font"), System.Drawing.Font)
        Me.PGF_VPERNOM.Appearance.Header.ForeColor = System.Drawing.Color.Black
        Me.PGF_VPERNOM.Appearance.Header.Options.UseFont = True
        Me.PGF_VPERNOM.Appearance.Header.Options.UseForeColor = True
        Me.PGF_VPERNOM.Appearance.Value.ForeColor = System.Drawing.Color.Black
        Me.PGF_VPERNOM.Appearance.Value.Options.UseForeColor = True
        Me.PGF_VPERNOM.Appearance.ValueGrandTotal.ForeColor = System.Drawing.Color.Black
        Me.PGF_VPERNOM.Appearance.ValueGrandTotal.Options.UseForeColor = True
        Me.PGF_VPERNOM.Appearance.ValueTotal.ForeColor = System.Drawing.Color.Black
        Me.PGF_VPERNOM.Appearance.ValueTotal.Options.UseForeColor = True
        Me.PGF_VPERNOM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PGF_VPERNOM.AreaIndex = 0
        resources.ApplyResources(Me.PGF_VPERNOM, "PGF_VPERNOM")
        Me.PGF_VPERNOM.FieldName = "VPERNOM"
        Me.PGF_VPERNOM.Name = "PGF_VPERNOM"
        Me.PGF_VPERNOM.Options.ReadOnly = True
        '
        'PGF_NCANNUM
        '
        Me.PGF_NCANNUM.Appearance.Cell.ForeColor = System.Drawing.Color.Black
        Me.PGF_NCANNUM.Appearance.Cell.Options.UseForeColor = True
        Me.PGF_NCANNUM.Appearance.CellGrandTotal.ForeColor = System.Drawing.Color.Black
        Me.PGF_NCANNUM.Appearance.CellGrandTotal.Options.UseForeColor = True
        Me.PGF_NCANNUM.Appearance.CellTotal.ForeColor = System.Drawing.Color.Black
        Me.PGF_NCANNUM.Appearance.CellTotal.Options.UseForeColor = True
        Me.PGF_NCANNUM.Appearance.Header.Font = CType(resources.GetObject("PGF_NCANNUM.Appearance.Header.Font"), System.Drawing.Font)
        Me.PGF_NCANNUM.Appearance.Header.ForeColor = System.Drawing.Color.Black
        Me.PGF_NCANNUM.Appearance.Header.Options.UseFont = True
        Me.PGF_NCANNUM.Appearance.Header.Options.UseForeColor = True
        Me.PGF_NCANNUM.Appearance.Header.Options.UseTextOptions = True
        Me.PGF_NCANNUM.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGF_NCANNUM.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGF_NCANNUM.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PGF_NCANNUM.Appearance.Value.ForeColor = System.Drawing.Color.Black
        Me.PGF_NCANNUM.Appearance.Value.Options.UseForeColor = True
        Me.PGF_NCANNUM.Appearance.ValueGrandTotal.ForeColor = System.Drawing.Color.Black
        Me.PGF_NCANNUM.Appearance.ValueGrandTotal.Options.UseForeColor = True
        Me.PGF_NCANNUM.Appearance.ValueTotal.ForeColor = System.Drawing.Color.Black
        Me.PGF_NCANNUM.Appearance.ValueTotal.Options.UseForeColor = True
        Me.PGF_NCANNUM.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PGF_NCANNUM.AreaIndex = 0
        resources.ApplyResources(Me.PGF_NCANNUM, "PGF_NCANNUM")
        Me.PGF_NCANNUM.FieldName = "NCANNUM"
        Me.PGF_NCANNUM.Name = "PGF_NCANNUM"
        Me.PGF_NCANNUM.Options.ReadOnly = True
        '
        'PGF_TOTALHR
        '
        Me.PGF_TOTALHR.Appearance.CellGrandTotal.ForeColor = System.Drawing.Color.Black
        Me.PGF_TOTALHR.Appearance.CellGrandTotal.Options.UseForeColor = True
        Me.PGF_TOTALHR.Appearance.ValueGrandTotal.ForeColor = System.Drawing.Color.Black
        Me.PGF_TOTALHR.Appearance.ValueGrandTotal.Options.UseForeColor = True
        Me.PGF_TOTALHR.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PGF_TOTALHR.AreaIndex = 0
        resources.ApplyResources(Me.PGF_TOTALHR, "PGF_TOTALHR")
        Me.PGF_TOTALHR.CellFormat.FormatString = "n0"
        Me.PGF_TOTALHR.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PGF_TOTALHR.FieldName = "TOTALHR"
        Me.PGF_TOTALHR.Name = "PGF_TOTALHR"
        Me.PGF_TOTALHR.Options.AllowEdit = False
        Me.PGF_TOTALHR.Options.ReadOnly = True
        Me.PGF_TOTALHR.Options.ShowInFilter = False
        Me.PGF_TOTALHR.Options.ShowInPrefilter = False
        '
        'PGF_NPERNUM
        '
        Me.PGF_NPERNUM.Appearance.CellGrandTotal.ForeColor = System.Drawing.Color.Black
        Me.PGF_NPERNUM.Appearance.CellGrandTotal.Options.UseForeColor = True
        Me.PGF_NPERNUM.Appearance.ValueGrandTotal.ForeColor = System.Drawing.Color.Black
        Me.PGF_NPERNUM.Appearance.ValueGrandTotal.Options.UseForeColor = True
        Me.PGF_NPERNUM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PGF_NPERNUM.AreaIndex = 0
        Me.PGF_NPERNUM.FieldName = "NPERNUM"
        Me.PGF_NPERNUM.Name = "PGF_NPERNUM"
        Me.PGF_NPERNUM.Visible = False
        '
        'PGF_CPERTYP
        '
        Me.PGF_CPERTYP.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PGF_CPERTYP.AreaIndex = 1
        Me.PGF_CPERTYP.FieldName = "CPERTYP"
        Me.PGF_CPERTYP.Name = "PGF_CPERTYP"
        Me.PGF_CPERTYP.Visible = False
        '
        'GrpPeriode
        '
        Me.GrpPeriode.Controls.Add(Me.CboAnnee)
        Me.GrpPeriode.Controls.Add(Me.CboMois)
        Me.GrpPeriode.Controls.Add(Me.Label2)
        Me.GrpPeriode.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GrpPeriode, "GrpPeriode")
        Me.GrpPeriode.Name = "GrpPeriode"
        Me.GrpPeriode.TabStop = False
        '
        'CboAnnee
        '
        resources.ApplyResources(Me.CboAnnee, "CboAnnee")
        Me.CboAnnee.Name = "CboAnnee"
        Me.CboAnnee.Properties.Appearance.Options.UseTextOptions = True
        Me.CboAnnee.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CboAnnee.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.CboAnnee.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("CboAnnee.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.CboAnnee.Properties.DisplayMember = "NIDANNEE"
        Me.CboAnnee.Properties.NullText = resources.GetString("CboAnnee.Properties.NullText")
        Me.CboAnnee.Properties.PopupFormSize = New System.Drawing.Size(200, 300)
        Me.CboAnnee.Properties.PopupSizeable = False
        Me.CboAnnee.Properties.PopupView = Me.GridView1
        Me.CboAnnee.Properties.ValueMember = "NIDANNEE"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCboAnneeNIDANNEE})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'CboMois
        '
        resources.ApplyResources(Me.CboMois, "CboMois")
        Me.CboMois.Name = "CboMois"
        Me.CboMois.Properties.Appearance.Options.UseTextOptions = True
        Me.CboMois.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CboMois.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.CboMois.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("CboMois.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.CboMois.Properties.DisplayMember = "SMOISNAME"
        Me.CboMois.Properties.NullText = resources.GetString("CboMois.Properties.NullText")
        Me.CboMois.Properties.PopupFormSize = New System.Drawing.Size(120, 300)
        Me.CboMois.Properties.PopupSizeable = False
        Me.CboMois.Properties.PopupView = Me.GridCboMois
        Me.CboMois.Properties.ValueMember = "NIDMOIS"
        '
        'GridCboMois
        '
        Me.GridCboMois.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCboMoisNIDMOIS, Me.GColCboMoisSMOISNAME})
        Me.GridCboMois.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridCboMois.Name = "GridCboMois"
        Me.GridCboMois.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridCboMois.OptionsView.ShowGroupPanel = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'LblRef
        '
        resources.ApplyResources(Me.LblRef, "LblRef")
        Me.LblRef.Name = "LblRef"
        '
        'GColCboAnneeNIDANNEE
        '
        Me.GColCboAnneeNIDANNEE.AppearanceCell.Options.UseTextOptions = True
        Me.GColCboAnneeNIDANNEE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCboAnneeNIDANNEE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColCboAnneeNIDANNEE.AppearanceHeader.Font = CType(resources.GetObject("GColCboAnneeNIDANNEE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColCboAnneeNIDANNEE.AppearanceHeader.Options.UseFont = True
        Me.GColCboAnneeNIDANNEE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColCboAnneeNIDANNEE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCboAnneeNIDANNEE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColCboAnneeNIDANNEE, "GColCboAnneeNIDANNEE")
        Me.GColCboAnneeNIDANNEE.FieldName = "NIDANNEE"
        Me.GColCboAnneeNIDANNEE.Name = "GColCboAnneeNIDANNEE"
        Me.GColCboAnneeNIDANNEE.OptionsColumn.AllowEdit = False
        Me.GColCboAnneeNIDANNEE.OptionsColumn.ReadOnly = True
        '
        'GColCboMoisNIDMOIS
        '
        resources.ApplyResources(Me.GColCboMoisNIDMOIS, "GColCboMoisNIDMOIS")
        Me.GColCboMoisNIDMOIS.FieldName = "NIDMOIS"
        Me.GColCboMoisNIDMOIS.Name = "GColCboMoisNIDMOIS"
        '
        'GColCboMoisSMOISNAME
        '
        Me.GColCboMoisSMOISNAME.AppearanceCell.Options.UseTextOptions = True
        Me.GColCboMoisSMOISNAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCboMoisSMOISNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColCboMoisSMOISNAME.AppearanceHeader.Font = CType(resources.GetObject("GColCboMoisSMOISNAME.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColCboMoisSMOISNAME.AppearanceHeader.Options.UseFont = True
        Me.GColCboMoisSMOISNAME.AppearanceHeader.Options.UseTextOptions = True
        Me.GColCboMoisSMOISNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCboMoisSMOISNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColCboMoisSMOISNAME, "GColCboMoisSMOISNAME")
        Me.GColCboMoisSMOISNAME.FieldName = "SMOISNAME"
        Me.GColCboMoisSMOISNAME.Name = "GColCboMoisSMOISNAME"
        Me.GColCboMoisSMOISNAME.OptionsColumn.AllowEdit = False
        Me.GColCboMoisSMOISNAME.OptionsColumn.ReadOnly = True
        '
        'frmTableAnalytiqueH
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblRef)
        Me.Controls.Add(Me.GrpPeriode)
        Me.Controls.Add(Me.PGCHeures)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "frmTableAnalytiqueH"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.PGCHeures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPeriode.ResumeLayout(False)
        CType(Me.CboAnnee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboMois.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCboMois, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GrpPeriode As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblRef As System.Windows.Forms.Label
    Private WithEvents PGCHeures As DevExpress.XtraPivotGrid.PivotGridControl
    Private WithEvents PGF_VPERNOM As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PGF_NCANNUM As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PGF_TOTALHR As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents CboAnnee As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents CboMois As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridCboMois As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColCboMoisNIDMOIS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCboMoisSMOISNAME As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCboAnneeNIDANNEE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents PGF_NPERNUM As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PGF_CPERTYP As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents BtnExportXLS As Button
    Friend WithEvents SFD As SaveFileDialog
End Class
