<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSyntheseREXGroupe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSyntheseREXGroupe))
        Dim PivotGridCustomTotal1 As DevExpress.XtraPivotGrid.PivotGridCustomTotal = New DevExpress.XtraPivotGrid.PivotGridCustomTotal()
        Me.GrpPeriode = New System.Windows.Forms.GroupBox()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.LblAnnee = New System.Windows.Forms.Label()
        Me.LblMois = New System.Windows.Forms.Label()
        Me.CboAnnee = New System.Windows.Forms.ComboBox()
        Me.CboMois = New System.Windows.Forms.ComboBox()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnExportPDF = New System.Windows.Forms.Button()
        Me.BtnExportXLS = New System.Windows.Forms.Button()
        Me.PGCANAGRP = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PGFNORDERMOISANNEE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGFMOISANNEE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGFNORDERINTITULE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGFVINTITULE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGFVSOCIETE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGFNVALUE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGFNPOURC = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.SFDSynCompta = New System.Windows.Forms.SaveFileDialog()
        Me.GrpPeriode.SuspendLayout()
        Me.GrpActions.SuspendLayout()
        CType(Me.PGCANAGRP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpPeriode
        '
        resources.ApplyResources(Me.GrpPeriode, "GrpPeriode")
        Me.GrpPeriode.Controls.Add(Me.BtnValid)
        Me.GrpPeriode.Controls.Add(Me.LblAnnee)
        Me.GrpPeriode.Controls.Add(Me.LblMois)
        Me.GrpPeriode.Controls.Add(Me.CboAnnee)
        Me.GrpPeriode.Controls.Add(Me.CboMois)
        Me.GrpPeriode.Name = "GrpPeriode"
        Me.GrpPeriode.TabStop = False
        '
        'BtnValid
        '
        resources.ApplyResources(Me.BtnValid, "BtnValid")
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'LblAnnee
        '
        resources.ApplyResources(Me.LblAnnee, "LblAnnee")
        Me.LblAnnee.Name = "LblAnnee"
        '
        'LblMois
        '
        resources.ApplyResources(Me.LblMois, "LblMois")
        Me.LblMois.Name = "LblMois"
        '
        'CboAnnee
        '
        resources.ApplyResources(Me.CboAnnee, "CboAnnee")
        Me.CboAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAnnee.FormattingEnabled = True
        Me.CboAnnee.Name = "CboAnnee"
        '
        'CboMois
        '
        resources.ApplyResources(Me.CboMois, "CboMois")
        Me.CboMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMois.FormattingEnabled = True
        Me.CboMois.Name = "CboMois"
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnExportPDF)
        Me.GrpActions.Controls.Add(Me.BtnExportXLS)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.BackColor = System.Drawing.Color.LightYellow
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = False
        '
        'BtnExportPDF
        '
        resources.ApplyResources(Me.BtnExportPDF, "BtnExportPDF")
        Me.BtnExportPDF.BackColor = System.Drawing.Color.LightYellow
        Me.BtnExportPDF.Name = "BtnExportPDF"
        Me.BtnExportPDF.UseVisualStyleBackColor = False
        '
        'BtnExportXLS
        '
        resources.ApplyResources(Me.BtnExportXLS, "BtnExportXLS")
        Me.BtnExportXLS.BackColor = System.Drawing.Color.LightYellow
        Me.BtnExportXLS.Name = "BtnExportXLS"
        Me.BtnExportXLS.UseVisualStyleBackColor = False
        '
        'PGCANAGRP
        '
        resources.ApplyResources(Me.PGCANAGRP, "PGCANAGRP")
        Me.PGCANAGRP.Appearance.CustomTotalCell.Font = CType(resources.GetObject("PGCANAGRP.Appearance.CustomTotalCell.Font"), System.Drawing.Font)
        Me.PGCANAGRP.Appearance.CustomTotalCell.FontSizeDelta = CType(resources.GetObject("PGCANAGRP.Appearance.CustomTotalCell.FontSizeDelta"), Integer)
        Me.PGCANAGRP.Appearance.CustomTotalCell.FontStyleDelta = CType(resources.GetObject("PGCANAGRP.Appearance.CustomTotalCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.PGCANAGRP.Appearance.CustomTotalCell.GradientMode = CType(resources.GetObject("PGCANAGRP.Appearance.CustomTotalCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.PGCANAGRP.Appearance.CustomTotalCell.Image = CType(resources.GetObject("PGCANAGRP.Appearance.CustomTotalCell.Image"), System.Drawing.Image)
        Me.PGCANAGRP.Appearance.CustomTotalCell.Options.UseFont = True
        Me.PGCANAGRP.Appearance.DataHeaderArea.Font = CType(resources.GetObject("PGCANAGRP.Appearance.DataHeaderArea.Font"), System.Drawing.Font)
        Me.PGCANAGRP.Appearance.DataHeaderArea.FontSizeDelta = CType(resources.GetObject("PGCANAGRP.Appearance.DataHeaderArea.FontSizeDelta"), Integer)
        Me.PGCANAGRP.Appearance.DataHeaderArea.FontStyleDelta = CType(resources.GetObject("PGCANAGRP.Appearance.DataHeaderArea.FontStyleDelta"), System.Drawing.FontStyle)
        Me.PGCANAGRP.Appearance.DataHeaderArea.GradientMode = CType(resources.GetObject("PGCANAGRP.Appearance.DataHeaderArea.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.PGCANAGRP.Appearance.DataHeaderArea.Image = CType(resources.GetObject("PGCANAGRP.Appearance.DataHeaderArea.Image"), System.Drawing.Image)
        Me.PGCANAGRP.Appearance.DataHeaderArea.Options.UseFont = True
        Me.PGCANAGRP.Appearance.TotalCell.Font = CType(resources.GetObject("PGCANAGRP.Appearance.TotalCell.Font"), System.Drawing.Font)
        Me.PGCANAGRP.Appearance.TotalCell.FontSizeDelta = CType(resources.GetObject("PGCANAGRP.Appearance.TotalCell.FontSizeDelta"), Integer)
        Me.PGCANAGRP.Appearance.TotalCell.FontStyleDelta = CType(resources.GetObject("PGCANAGRP.Appearance.TotalCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.PGCANAGRP.Appearance.TotalCell.GradientMode = CType(resources.GetObject("PGCANAGRP.Appearance.TotalCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.PGCANAGRP.Appearance.TotalCell.Image = CType(resources.GetObject("PGCANAGRP.Appearance.TotalCell.Image"), System.Drawing.Image)
        Me.PGCANAGRP.Appearance.TotalCell.Options.UseFont = True
        Me.PGCANAGRP.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PGFNORDERMOISANNEE, Me.PGFMOISANNEE, Me.PGFNORDERINTITULE, Me.PGFVINTITULE, Me.PGFVSOCIETE, Me.PGFNVALUE, Me.PGFNPOURC})
        Me.PGCANAGRP.Name = "PGCANAGRP"
        Me.PGCANAGRP.OptionsCustomization.AllowSortBySummary = False
        Me.PGCANAGRP.OptionsPrint.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PGCANAGRP.OptionsPrint.UsePrintAppearance = True
        Me.PGCANAGRP.OptionsView.ShowColumnGrandTotalHeader = False
        Me.PGCANAGRP.OptionsView.ShowColumnGrandTotals = False
        Me.PGCANAGRP.OptionsView.ShowColumnHeaders = False
        Me.PGCANAGRP.OptionsView.ShowColumnTotals = False
        Me.PGCANAGRP.OptionsView.ShowDataHeaders = False
        Me.PGCANAGRP.OptionsView.ShowFilterHeaders = False
        Me.PGCANAGRP.OptionsView.ShowRowGrandTotalHeader = False
        Me.PGCANAGRP.OptionsView.ShowRowGrandTotals = False
        '
        'PGFNORDERMOISANNEE
        '
        Me.PGFNORDERMOISANNEE.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PGFNORDERMOISANNEE.AreaIndex = 1
        resources.ApplyResources(Me.PGFNORDERMOISANNEE, "PGFNORDERMOISANNEE")
        Me.PGFNORDERMOISANNEE.FieldName = "NORDERMOISANNEE"
        Me.PGFNORDERMOISANNEE.Name = "PGFNORDERMOISANNEE"
        Me.PGFNORDERMOISANNEE.Options.ShowInPrefilter = False
        Me.PGFNORDERMOISANNEE.Visible = False
        '
        'PGFMOISANNEE
        '
        Me.PGFMOISANNEE.Appearance.Value.Font = CType(resources.GetObject("PGFMOISANNEE.Appearance.Value.Font"), System.Drawing.Font)
        Me.PGFMOISANNEE.Appearance.Value.FontSizeDelta = CType(resources.GetObject("PGFMOISANNEE.Appearance.Value.FontSizeDelta"), Integer)
        Me.PGFMOISANNEE.Appearance.Value.FontStyleDelta = CType(resources.GetObject("PGFMOISANNEE.Appearance.Value.FontStyleDelta"), System.Drawing.FontStyle)
        Me.PGFMOISANNEE.Appearance.Value.GradientMode = CType(resources.GetObject("PGFMOISANNEE.Appearance.Value.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.PGFMOISANNEE.Appearance.Value.Image = CType(resources.GetObject("PGFMOISANNEE.Appearance.Value.Image"), System.Drawing.Image)
        Me.PGFMOISANNEE.Appearance.Value.Options.UseFont = True
        Me.PGFMOISANNEE.Appearance.Value.Options.UseTextOptions = True
        Me.PGFMOISANNEE.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGFMOISANNEE.Appearance.Value.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGFMOISANNEE.Appearance.Value.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PGFMOISANNEE.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PGFMOISANNEE.AreaIndex = 0
        resources.ApplyResources(Me.PGFMOISANNEE, "PGFMOISANNEE")
        Me.PGFMOISANNEE.FieldName = "MOISANNEE"
        Me.PGFMOISANNEE.Name = "PGFMOISANNEE"
        Me.PGFMOISANNEE.Options.ReadOnly = True
        Me.PGFMOISANNEE.Options.ShowInPrefilter = False
        Me.PGFMOISANNEE.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom
        '
        'PGFNORDERINTITULE
        '
        Me.PGFNORDERINTITULE.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PGFNORDERINTITULE.AreaIndex = 2
        resources.ApplyResources(Me.PGFNORDERINTITULE, "PGFNORDERINTITULE")
        Me.PGFNORDERINTITULE.FieldName = "NORDERINTITULE"
        Me.PGFNORDERINTITULE.Name = "PGFNORDERINTITULE"
        Me.PGFNORDERINTITULE.Options.ShowInPrefilter = False
        Me.PGFNORDERINTITULE.Options.ShowValues = False
        Me.PGFNORDERINTITULE.Visible = False
        '
        'PGFVINTITULE
        '
        Me.PGFVINTITULE.Appearance.Value.Font = CType(resources.GetObject("PGFVINTITULE.Appearance.Value.Font"), System.Drawing.Font)
        Me.PGFVINTITULE.Appearance.Value.FontSizeDelta = CType(resources.GetObject("PGFVINTITULE.Appearance.Value.FontSizeDelta"), Integer)
        Me.PGFVINTITULE.Appearance.Value.FontStyleDelta = CType(resources.GetObject("PGFVINTITULE.Appearance.Value.FontStyleDelta"), System.Drawing.FontStyle)
        Me.PGFVINTITULE.Appearance.Value.GradientMode = CType(resources.GetObject("PGFVINTITULE.Appearance.Value.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.PGFVINTITULE.Appearance.Value.Image = CType(resources.GetObject("PGFVINTITULE.Appearance.Value.Image"), System.Drawing.Image)
        Me.PGFVINTITULE.Appearance.Value.Options.UseFont = True
        Me.PGFVINTITULE.Appearance.Value.Options.UseTextOptions = True
        Me.PGFVINTITULE.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGFVINTITULE.Appearance.Value.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGFVINTITULE.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PGFVINTITULE.AreaIndex = 0
        resources.ApplyResources(Me.PGFVINTITULE, "PGFVINTITULE")
        PivotGridCustomTotal1.Appearance.Font = CType(resources.GetObject("resource.Font"), System.Drawing.Font)
        PivotGridCustomTotal1.Appearance.FontSizeDelta = CType(resources.GetObject("resource.FontSizeDelta"), Integer)
        PivotGridCustomTotal1.Appearance.FontStyleDelta = CType(resources.GetObject("resource.FontStyleDelta"), System.Drawing.FontStyle)
        PivotGridCustomTotal1.Appearance.GradientMode = CType(resources.GetObject("resource.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        PivotGridCustomTotal1.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        PivotGridCustomTotal1.Appearance.Options.UseFont = True
        PivotGridCustomTotal1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.PGFVINTITULE.CustomTotals.AddRange(New DevExpress.XtraPivotGrid.PivotGridCustomTotal() {PivotGridCustomTotal1})
        Me.PGFVINTITULE.FieldName = "VINTITULE"
        Me.PGFVINTITULE.Name = "PGFVINTITULE"
        Me.PGFVINTITULE.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.PGFVINTITULE.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[False]
        Me.PGFVINTITULE.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.PGFVINTITULE.Options.AllowSortBySummary = DevExpress.Utils.DefaultBoolean.[False]
        Me.PGFVINTITULE.Options.ReadOnly = True
        Me.PGFVINTITULE.Options.ShowInPrefilter = False
        Me.PGFVINTITULE.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom
        Me.PGFVINTITULE.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals
        '
        'PGFVSOCIETE
        '
        Me.PGFVSOCIETE.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PGFVSOCIETE.AreaIndex = 1
        resources.ApplyResources(Me.PGFVSOCIETE, "PGFVSOCIETE")
        Me.PGFVSOCIETE.FieldName = "VSOCIETE"
        Me.PGFVSOCIETE.Name = "PGFVSOCIETE"
        Me.PGFVSOCIETE.Options.ReadOnly = True
        '
        'PGFNVALUE
        '
        Me.PGFNVALUE.Appearance.Header.Font = CType(resources.GetObject("PGFNVALUE.Appearance.Header.Font"), System.Drawing.Font)
        Me.PGFNVALUE.Appearance.Header.FontSizeDelta = CType(resources.GetObject("PGFNVALUE.Appearance.Header.FontSizeDelta"), Integer)
        Me.PGFNVALUE.Appearance.Header.FontStyleDelta = CType(resources.GetObject("PGFNVALUE.Appearance.Header.FontStyleDelta"), System.Drawing.FontStyle)
        Me.PGFNVALUE.Appearance.Header.GradientMode = CType(resources.GetObject("PGFNVALUE.Appearance.Header.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.PGFNVALUE.Appearance.Header.Image = CType(resources.GetObject("PGFNVALUE.Appearance.Header.Image"), System.Drawing.Image)
        Me.PGFNVALUE.Appearance.Header.Options.UseFont = True
        Me.PGFNVALUE.Appearance.Header.Options.UseTextOptions = True
        Me.PGFNVALUE.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGFNVALUE.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGFNVALUE.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PGFNVALUE.Appearance.Value.Font = CType(resources.GetObject("PGFNVALUE.Appearance.Value.Font"), System.Drawing.Font)
        Me.PGFNVALUE.Appearance.Value.FontSizeDelta = CType(resources.GetObject("PGFNVALUE.Appearance.Value.FontSizeDelta"), Integer)
        Me.PGFNVALUE.Appearance.Value.FontStyleDelta = CType(resources.GetObject("PGFNVALUE.Appearance.Value.FontStyleDelta"), System.Drawing.FontStyle)
        Me.PGFNVALUE.Appearance.Value.GradientMode = CType(resources.GetObject("PGFNVALUE.Appearance.Value.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.PGFNVALUE.Appearance.Value.Image = CType(resources.GetObject("PGFNVALUE.Appearance.Value.Image"), System.Drawing.Image)
        Me.PGFNVALUE.Appearance.Value.Options.UseFont = True
        Me.PGFNVALUE.Appearance.Value.Options.UseTextOptions = True
        Me.PGFNVALUE.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGFNVALUE.Appearance.Value.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGFNVALUE.Appearance.Value.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PGFNVALUE.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PGFNVALUE.AreaIndex = 0
        resources.ApplyResources(Me.PGFNVALUE, "PGFNVALUE")
        Me.PGFNVALUE.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.PGFNVALUE.FieldName = "NVALUE"
        Me.PGFNVALUE.Name = "PGFNVALUE"
        Me.PGFNVALUE.Options.ReadOnly = True
        Me.PGFNVALUE.Options.ShowInPrefilter = False
        '
        'PGFNPOURC
        '
        Me.PGFNPOURC.Appearance.Header.Font = CType(resources.GetObject("PGFNPOURC.Appearance.Header.Font"), System.Drawing.Font)
        Me.PGFNPOURC.Appearance.Header.FontSizeDelta = CType(resources.GetObject("PGFNPOURC.Appearance.Header.FontSizeDelta"), Integer)
        Me.PGFNPOURC.Appearance.Header.FontStyleDelta = CType(resources.GetObject("PGFNPOURC.Appearance.Header.FontStyleDelta"), System.Drawing.FontStyle)
        Me.PGFNPOURC.Appearance.Header.GradientMode = CType(resources.GetObject("PGFNPOURC.Appearance.Header.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.PGFNPOURC.Appearance.Header.Image = CType(resources.GetObject("PGFNPOURC.Appearance.Header.Image"), System.Drawing.Image)
        Me.PGFNPOURC.Appearance.Header.Options.UseFont = True
        Me.PGFNPOURC.Appearance.Header.Options.UseTextOptions = True
        Me.PGFNPOURC.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGFNPOURC.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGFNPOURC.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PGFNPOURC.Appearance.Value.Font = CType(resources.GetObject("PGFNPOURC.Appearance.Value.Font"), System.Drawing.Font)
        Me.PGFNPOURC.Appearance.Value.FontSizeDelta = CType(resources.GetObject("PGFNPOURC.Appearance.Value.FontSizeDelta"), Integer)
        Me.PGFNPOURC.Appearance.Value.FontStyleDelta = CType(resources.GetObject("PGFNPOURC.Appearance.Value.FontStyleDelta"), System.Drawing.FontStyle)
        Me.PGFNPOURC.Appearance.Value.GradientMode = CType(resources.GetObject("PGFNPOURC.Appearance.Value.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.PGFNPOURC.Appearance.Value.Image = CType(resources.GetObject("PGFNPOURC.Appearance.Value.Image"), System.Drawing.Image)
        Me.PGFNPOURC.Appearance.Value.Options.UseFont = True
        Me.PGFNPOURC.Appearance.Value.Options.UseTextOptions = True
        Me.PGFNPOURC.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGFNPOURC.Appearance.Value.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGFNPOURC.Appearance.Value.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PGFNPOURC.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PGFNPOURC.AreaIndex = 1
        resources.ApplyResources(Me.PGFNPOURC, "PGFNPOURC")
        Me.PGFNPOURC.FieldName = "NPOURC"
        Me.PGFNPOURC.Name = "PGFNPOURC"
        '
        'SFDSynCompta
        '
        resources.ApplyResources(Me.SFDSynCompta, "SFDSynCompta")
        '
        'frmSyntheseREXGroupe
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.PGCANAGRP)
        Me.Controls.Add(Me.GrpPeriode)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmSyntheseREXGroupe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpPeriode.ResumeLayout(False)
        Me.GrpActions.ResumeLayout(False)
        CType(Me.PGCANAGRP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpPeriode As System.Windows.Forms.GroupBox
    Friend WithEvents BtnValid As System.Windows.Forms.Button
    Friend WithEvents LblAnnee As System.Windows.Forms.Label
    Friend WithEvents LblMois As System.Windows.Forms.Label
    Friend WithEvents CboAnnee As System.Windows.Forms.ComboBox
    Friend WithEvents CboMois As System.Windows.Forms.ComboBox
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnExportPDF As System.Windows.Forms.Button
    Friend WithEvents BtnExportXLS As System.Windows.Forms.Button
    Friend WithEvents SFDSynCompta As System.Windows.Forms.SaveFileDialog
    Private WithEvents PGCANAGRP As DevExpress.XtraPivotGrid.PivotGridControl
    Private WithEvents PGFMOISANNEE As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PGFVINTITULE As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PGFVSOCIETE As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PGFNVALUE As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PGFNORDERINTITULE As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PGFNORDERMOISANNEE As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PGFNPOURC As DevExpress.XtraPivotGrid.PivotGridField
End Class
