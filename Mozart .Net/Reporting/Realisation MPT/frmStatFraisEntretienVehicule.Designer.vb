<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatFraisEntretienVehicule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatFraisEntretienVehicule))
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpPeriode = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblDateDeb = New System.Windows.Forms.Label()
        Me.DTPFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPDebut = New System.Windows.Forms.DateTimePicker()
        Me.btnValid = New System.Windows.Forms.Button()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnArchives = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GCStat = New DevExpress.XtraGrid.GridControl()
        Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNVEHNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVVEHIMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNCOMNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVFOUMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDCOMDAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNLCOPT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpPeriode.SuspendLayout()
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
        'GrpPeriode
        '
        Me.GrpPeriode.Controls.Add(Me.Label1)
        Me.GrpPeriode.Controls.Add(Me.LblDateDeb)
        Me.GrpPeriode.Controls.Add(Me.DTPFin)
        Me.GrpPeriode.Controls.Add(Me.DTPDebut)
        Me.GrpPeriode.Controls.Add(Me.btnValid)
        resources.ApplyResources(Me.GrpPeriode, "GrpPeriode")
        Me.GrpPeriode.Name = "GrpPeriode"
        Me.GrpPeriode.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'LblDateDeb
        '
        resources.ApplyResources(Me.LblDateDeb, "LblDateDeb")
        Me.LblDateDeb.Name = "LblDateDeb"
        '
        'DTPFin
        '
        resources.ApplyResources(Me.DTPFin, "DTPFin")
        Me.DTPFin.Name = "DTPFin"
        '
        'DTPDebut
        '
        resources.ApplyResources(Me.DTPDebut, "DTPDebut")
        Me.DTPDebut.Name = "DTPDebut"
        '
        'btnValid
        '
        resources.ApplyResources(Me.btnValid, "btnValid")
        Me.btnValid.Name = "btnValid"
        Me.btnValid.UseVisualStyleBackColor = True
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnArchives)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnArchives
        '
        resources.ApplyResources(Me.BtnArchives, "BtnArchives")
        Me.BtnArchives.Name = "BtnArchives"
        Me.BtnArchives.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
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
        Me.GVStat.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.GVStat.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStat.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStat.Appearance.GroupRow.BackColor = System.Drawing.Color.LemonChiffon
        Me.GVStat.Appearance.GroupRow.Font = CType(resources.GetObject("GVStat.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.GVStat.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVStat.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVStat.Appearance.GroupRow.Options.UseFont = True
        Me.GVStat.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVStat.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVStat.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVStat.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVStat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNVEHNUM, Me.ColVVEHIMAT, Me.ColNDINNUM, Me.ColNCOMNUM, Me.ColVFOUMAT, Me.ColDCOMDAT, Me.ColNLCOPT})
        Me.GVStat.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType(resources.GetObject("GVStat.GroupSummary"), DevExpress.Data.SummaryItemType), resources.GetString("GVStat.GroupSummary1"), CType(resources.GetObject("GVStat.GroupSummary2"), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("GVStat.GroupSummary3"))})
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsPrint.PrintPreview = True
        Me.GVStat.OptionsView.ShowAutoFilterRow = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'ColNVEHNUM
        '
        resources.ApplyResources(Me.ColNVEHNUM, "ColNVEHNUM")
        Me.ColNVEHNUM.FieldName = "NVEHNUM"
        Me.ColNVEHNUM.Name = "ColNVEHNUM"
        Me.ColNVEHNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColVVEHIMAT
        '
        Me.ColVVEHIMAT.AppearanceHeader.Font = CType(resources.GetObject("ColVVEHIMAT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColVVEHIMAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColVVEHIMAT.AppearanceHeader.Options.UseFont = True
        Me.ColVVEHIMAT.AppearanceHeader.Options.UseForeColor = True
        Me.ColVVEHIMAT.AppearanceHeader.Options.UseTextOptions = True
        Me.ColVVEHIMAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVVEHIMAT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColVVEHIMAT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.ColVVEHIMAT, "ColVVEHIMAT")
        Me.ColVVEHIMAT.FieldName = "VVEHIMAT"
        Me.ColVVEHIMAT.Name = "ColVVEHIMAT"
        Me.ColVVEHIMAT.OptionsColumn.AllowEdit = False
        Me.ColVVEHIMAT.OptionsColumn.ReadOnly = True
        Me.ColVVEHIMAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColNDINNUM
        '
        Me.ColNDINNUM.AppearanceCell.Options.UseTextOptions = True
        Me.ColNDINNUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNDINNUM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNDINNUM.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColNDINNUM.AppearanceHeader.Font = CType(resources.GetObject("ColNDINNUM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColNDINNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColNDINNUM.AppearanceHeader.Options.UseFont = True
        Me.ColNDINNUM.AppearanceHeader.Options.UseForeColor = True
        Me.ColNDINNUM.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNDINNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNDINNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNDINNUM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.ColNDINNUM, "ColNDINNUM")
        Me.ColNDINNUM.FieldName = "NDINNUM"
        Me.ColNDINNUM.Name = "ColNDINNUM"
        Me.ColNDINNUM.OptionsColumn.AllowEdit = False
        Me.ColNDINNUM.OptionsColumn.ReadOnly = True
        Me.ColNDINNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColNCOMNUM
        '
        Me.ColNCOMNUM.AppearanceHeader.Font = CType(resources.GetObject("ColNCOMNUM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColNCOMNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColNCOMNUM.AppearanceHeader.Options.UseFont = True
        Me.ColNCOMNUM.AppearanceHeader.Options.UseForeColor = True
        Me.ColNCOMNUM.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNCOMNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNCOMNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNCOMNUM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.ColNCOMNUM, "ColNCOMNUM")
        Me.ColNCOMNUM.FieldName = "NCOMNUM"
        Me.ColNCOMNUM.Name = "ColNCOMNUM"
        Me.ColNCOMNUM.OptionsColumn.AllowEdit = False
        Me.ColNCOMNUM.OptionsColumn.ReadOnly = True
        Me.ColNCOMNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColVFOUMAT
        '
        Me.ColVFOUMAT.AppearanceCell.Options.UseTextOptions = True
        Me.ColVFOUMAT.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColVFOUMAT.AppearanceHeader.Font = CType(resources.GetObject("ColVFOUMAT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColVFOUMAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColVFOUMAT.AppearanceHeader.Options.UseFont = True
        Me.ColVFOUMAT.AppearanceHeader.Options.UseForeColor = True
        Me.ColVFOUMAT.AppearanceHeader.Options.UseTextOptions = True
        Me.ColVFOUMAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVFOUMAT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColVFOUMAT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.ColVFOUMAT, "ColVFOUMAT")
        Me.ColVFOUMAT.FieldName = "VFOUMAT"
        Me.ColVFOUMAT.Name = "ColVFOUMAT"
        Me.ColVFOUMAT.OptionsColumn.AllowEdit = False
        Me.ColVFOUMAT.OptionsColumn.ReadOnly = True
        Me.ColVFOUMAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColDCOMDAT
        '
        Me.ColDCOMDAT.AppearanceCell.Options.UseTextOptions = True
        Me.ColDCOMDAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDCOMDAT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColDCOMDAT.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDCOMDAT.AppearanceHeader.Font = CType(resources.GetObject("ColDCOMDAT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColDCOMDAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColDCOMDAT.AppearanceHeader.Options.UseFont = True
        Me.ColDCOMDAT.AppearanceHeader.Options.UseForeColor = True
        Me.ColDCOMDAT.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDCOMDAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDCOMDAT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColDCOMDAT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.ColDCOMDAT, "ColDCOMDAT")
        Me.ColDCOMDAT.FieldName = "DCOMDAT"
        Me.ColDCOMDAT.Name = "ColDCOMDAT"
        Me.ColDCOMDAT.OptionsColumn.AllowEdit = False
        Me.ColDCOMDAT.OptionsColumn.ReadOnly = True
        Me.ColDCOMDAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColNLCOPT
        '
        Me.ColNLCOPT.AppearanceHeader.Font = CType(resources.GetObject("ColNLCOPT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColNLCOPT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColNLCOPT.AppearanceHeader.Options.UseFont = True
        Me.ColNLCOPT.AppearanceHeader.Options.UseForeColor = True
        Me.ColNLCOPT.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNLCOPT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNLCOPT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNLCOPT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.ColNLCOPT, "ColNLCOPT")
        Me.ColNLCOPT.DisplayFormat.FormatString = "{0:c0}"
        Me.ColNLCOPT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColNLCOPT.FieldName = "NLCOPT"
        Me.ColNLCOPT.Name = "ColNLCOPT"
        Me.ColNLCOPT.OptionsColumn.AllowEdit = False
        Me.ColNLCOPT.OptionsColumn.ReadOnly = True
        Me.ColNLCOPT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColNLCOPT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColNLCOPT.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColNLCOPT.Summary1"), resources.GetString("ColNLCOPT.Summary2"))})
        '
        'frmStatFraisEntretienVehicule
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpPeriode)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmStatFraisEntretienVehicule"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpPeriode.ResumeLayout(False)
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GrpPeriode As System.Windows.Forms.GroupBox
    Friend WithEvents btnValid As System.Windows.Forms.Button
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblDateDeb As System.Windows.Forms.Label
    Friend WithEvents DTPFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPDebut As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnArchives As System.Windows.Forms.Button
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColNVEHNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVVEHIMAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNCOMNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVFOUMAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNLCOPT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColDCOMDAT As DevExpress.XtraGrid.Columns.GridColumn
End Class
