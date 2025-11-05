<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatFacturation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatFacturation))
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Me.PGFYYMM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.PGFMTT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGCStatFacChiffrage = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PGFNB = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGFVELFCRE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpFilter = New System.Windows.Forms.GroupBox()
        Me.ChkHsFact = New System.Windows.Forms.CheckBox()
        Me.CboMoisHsFact = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkBoxByFact = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkByMTT = New System.Windows.Forms.CheckBox()
        Me.ChkByNB = New System.Windows.Forms.CheckBox()
        Me.ChkLabelGraph = New System.Windows.Forms.CheckBox()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPDebut = New System.Windows.Forms.DateTimePicker()
        Me.ChkBoxMOY = New System.Windows.Forms.CheckBox()
        Me.ChartCtrlStatFacChiff = New DevExpress.XtraCharts.ChartControl()
        CType(Me.PGCStatFacChiffrage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.GrpFilter.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ChartCtrlStatFacChiff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PGFYYMM
        '
        Me.PGFYYMM.Appearance.Cell.Font = CType(resources.GetObject("PGFYYMM.Appearance.Cell.Font"), System.Drawing.Font)
        Me.PGFYYMM.Appearance.Cell.Options.UseFont = True
        Me.PGFYYMM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PGFYYMM.AreaIndex = 0
        resources.ApplyResources(Me.PGFYYMM, "PGFYYMM")
        Me.PGFYYMM.FieldName = "YYMM"
        Me.PGFYYMM.Name = "PGFYYMM"
        Me.PGFYYMM.SortBySummaryInfo.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Var
        Me.PGFYYMM.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Value
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'PGFMTT
        '
        Me.PGFMTT.Appearance.Header.Font = CType(resources.GetObject("PGFMTT.Appearance.Header.Font"), System.Drawing.Font)
        Me.PGFMTT.Appearance.Header.Options.UseFont = True
        Me.PGFMTT.Appearance.Header.Options.UseTextOptions = True
        Me.PGFMTT.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGFMTT.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGFMTT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PGFMTT.AreaIndex = 1
        resources.ApplyResources(Me.PGFMTT, "PGFMTT")
        Me.PGFMTT.CellFormat.FormatString = "c"
        Me.PGFMTT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PGFMTT.FieldName = "MTT"
        Me.PGFMTT.Name = "PGFMTT"
        '
        'PGCStatFacChiffrage
        '
        Me.PGCStatFacChiffrage.Appearance.ColumnHeaderArea.Font = CType(resources.GetObject("PGCStatFacChiffrage.Appearance.ColumnHeaderArea.Font"), System.Drawing.Font)
        Me.PGCStatFacChiffrage.Appearance.ColumnHeaderArea.Options.UseFont = True
        Me.PGCStatFacChiffrage.Appearance.ColumnHeaderArea.Options.UseTextOptions = True
        Me.PGCStatFacChiffrage.Appearance.ColumnHeaderArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGCStatFacChiffrage.Appearance.ColumnHeaderArea.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGCStatFacChiffrage.Appearance.DataHeaderArea.Font = CType(resources.GetObject("PGCStatFacChiffrage.Appearance.DataHeaderArea.Font"), System.Drawing.Font)
        Me.PGCStatFacChiffrage.Appearance.DataHeaderArea.Options.UseFont = True
        Me.PGCStatFacChiffrage.Appearance.DataHeaderArea.Options.UseTextOptions = True
        Me.PGCStatFacChiffrage.Appearance.DataHeaderArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGCStatFacChiffrage.Appearance.DataHeaderArea.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGCStatFacChiffrage.Appearance.FieldHeader.Font = CType(resources.GetObject("PGCStatFacChiffrage.Appearance.FieldHeader.Font"), System.Drawing.Font)
        Me.PGCStatFacChiffrage.Appearance.FieldHeader.Options.UseFont = True
        Me.PGCStatFacChiffrage.Appearance.HeaderArea.Font = CType(resources.GetObject("PGCStatFacChiffrage.Appearance.HeaderArea.Font"), System.Drawing.Font)
        Me.PGCStatFacChiffrage.Appearance.HeaderArea.Options.UseFont = True
        Me.PGCStatFacChiffrage.Appearance.HeaderArea.Options.UseTextOptions = True
        Me.PGCStatFacChiffrage.Appearance.HeaderArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGCStatFacChiffrage.Appearance.HeaderArea.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGCStatFacChiffrage.Appearance.RowHeaderArea.Font = CType(resources.GetObject("PGCStatFacChiffrage.Appearance.RowHeaderArea.Font"), System.Drawing.Font)
        Me.PGCStatFacChiffrage.Appearance.RowHeaderArea.Options.UseFont = True
        Me.PGCStatFacChiffrage.Appearance.RowHeaderArea.Options.UseTextOptions = True
        Me.PGCStatFacChiffrage.Appearance.RowHeaderArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGCStatFacChiffrage.Appearance.RowHeaderArea.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGCStatFacChiffrage.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PGFYYMM, Me.PGFMTT, Me.PGFNB, Me.PGFVELFCRE})
        resources.ApplyResources(Me.PGCStatFacChiffrage, "PGCStatFacChiffrage")
        Me.PGCStatFacChiffrage.Name = "PGCStatFacChiffrage"
        Me.PGCStatFacChiffrage.OptionsChartDataSource.MaxAllowedSeriesCount = 30
        Me.PGCStatFacChiffrage.OptionsChartDataSource.SelectionOnly = False
        Me.PGCStatFacChiffrage.OptionsView.ShowColumnGrandTotalHeader = False
        Me.PGCStatFacChiffrage.OptionsView.ShowColumnGrandTotals = False
        Me.PGCStatFacChiffrage.OptionsView.ShowDataHeaders = False
        Me.PGCStatFacChiffrage.OptionsView.ShowFilterHeaders = False
        Me.PGCStatFacChiffrage.OptionsView.ShowRowGrandTotalHeader = False
        Me.PGCStatFacChiffrage.OptionsView.ShowRowGrandTotals = False
        Me.PGCStatFacChiffrage.OptionsView.ShowRowTotals = False
        '
        'PGFNB
        '
        Me.PGFNB.Appearance.Cell.Options.UseFont = True
        Me.PGFNB.Appearance.Header.Font = CType(resources.GetObject("PGFNB.Appearance.Header.Font"), System.Drawing.Font)
        Me.PGFNB.Appearance.Header.Options.UseFont = True
        Me.PGFNB.Appearance.Header.Options.UseTextOptions = True
        Me.PGFNB.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGFNB.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGFNB.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PGFNB.AreaIndex = 0
        resources.ApplyResources(Me.PGFNB, "PGFNB")
        Me.PGFNB.CellFormat.FormatString = "### ### ###"
        Me.PGFNB.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PGFNB.FieldName = "NB"
        Me.PGFNB.Name = "PGFNB"
        '
        'PGFVELFCRE
        '
        Me.PGFVELFCRE.Appearance.Header.Font = CType(resources.GetObject("PGFVELFCRE.Appearance.Header.Font"), System.Drawing.Font)
        Me.PGFVELFCRE.Appearance.Header.Options.UseFont = True
        Me.PGFVELFCRE.Appearance.Header.Options.UseTextOptions = True
        Me.PGFVELFCRE.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGFVELFCRE.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGFVELFCRE.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PGFVELFCRE.AreaIndex = 0
        resources.ApplyResources(Me.PGFVELFCRE, "PGFVELFCRE")
        Me.PGFVELFCRE.FieldName = "VELFCRE"
        Me.PGFVELFCRE.Name = "PGFVELFCRE"
        Me.PGFVELFCRE.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
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
        'GrpFilter
        '
        Me.GrpFilter.Controls.Add(Me.ChkHsFact)
        Me.GrpFilter.Controls.Add(Me.CboMoisHsFact)
        Me.GrpFilter.Controls.Add(Me.GroupBox2)
        Me.GrpFilter.Controls.Add(Me.GroupBox1)
        Me.GrpFilter.Controls.Add(Me.ChkLabelGraph)
        Me.GrpFilter.Controls.Add(Me.BtnValid)
        Me.GrpFilter.Controls.Add(Me.Label2)
        Me.GrpFilter.Controls.Add(Me.Label1)
        Me.GrpFilter.Controls.Add(Me.DTPFin)
        Me.GrpFilter.Controls.Add(Me.DTPDebut)
        Me.GrpFilter.Controls.Add(Me.ChkBoxMOY)
        resources.ApplyResources(Me.GrpFilter, "GrpFilter")
        Me.GrpFilter.Name = "GrpFilter"
        Me.GrpFilter.TabStop = False
        '
        'ChkHsFact
        '
        resources.ApplyResources(Me.ChkHsFact, "ChkHsFact")
        Me.ChkHsFact.Name = "ChkHsFact"
        Me.ChkHsFact.UseVisualStyleBackColor = True
        '
        'CboMoisHsFact
        '
        Me.CboMoisHsFact.FormattingEnabled = True
        resources.ApplyResources(Me.CboMoisHsFact, "CboMoisHsFact")
        Me.CboMoisHsFact.Name = "CboMoisHsFact"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkBoxByFact)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'ChkBoxByFact
        '
        resources.ApplyResources(Me.ChkBoxByFact, "ChkBoxByFact")
        Me.ChkBoxByFact.Name = "ChkBoxByFact"
        Me.ChkBoxByFact.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkByMTT)
        Me.GroupBox1.Controls.Add(Me.ChkByNB)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'ChkByMTT
        '
        resources.ApplyResources(Me.ChkByMTT, "ChkByMTT")
        Me.ChkByMTT.Name = "ChkByMTT"
        Me.ChkByMTT.UseVisualStyleBackColor = True
        '
        'ChkByNB
        '
        resources.ApplyResources(Me.ChkByNB, "ChkByNB")
        Me.ChkByNB.Name = "ChkByNB"
        Me.ChkByNB.UseVisualStyleBackColor = True
        '
        'ChkLabelGraph
        '
        resources.ApplyResources(Me.ChkLabelGraph, "ChkLabelGraph")
        Me.ChkLabelGraph.Name = "ChkLabelGraph"
        Me.ChkLabelGraph.UseVisualStyleBackColor = True
        '
        'BtnValid
        '
        resources.ApplyResources(Me.BtnValid, "BtnValid")
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.UseVisualStyleBackColor = True
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
        'ChkBoxMOY
        '
        resources.ApplyResources(Me.ChkBoxMOY, "ChkBoxMOY")
        Me.ChkBoxMOY.Name = "ChkBoxMOY"
        Me.ChkBoxMOY.UseVisualStyleBackColor = True
        '
        'ChartCtrlStatFacChiff
        '
        Me.ChartCtrlStatFacChiff.Legend.Name = "Default Legend"
        resources.ApplyResources(Me.ChartCtrlStatFacChiff, "ChartCtrlStatFacChiff")
        Me.ChartCtrlStatFacChiff.Name = "ChartCtrlStatFacChiff"
        Me.ChartCtrlStatFacChiff.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartCtrlStatFacChiff.SeriesTemplate.Label = SideBySideBarSeriesLabel1
        '
        'frmStatFacturation
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.ChartCtrlStatFacChiff)
        Me.Controls.Add(Me.GrpFilter)
        Me.Controls.Add(Me.PGCStatFacChiffrage)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "frmStatFacturation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PGCStatFacChiffrage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.GrpFilter.ResumeLayout(False)
        Me.GrpFilter.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartCtrlStatFacChiff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GrpFilter As System.Windows.Forms.GroupBox
    Friend WithEvents ChkBoxMOY As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBoxByFact As System.Windows.Forms.CheckBox
    Friend WithEvents DTPFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPDebut As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnValid As System.Windows.Forms.Button
    Friend WithEvents ChkLabelGraph As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkByMTT As System.Windows.Forms.CheckBox
    Friend WithEvents ChkByNB As System.Windows.Forms.CheckBox
    Private WithEvents PGFYYMM As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PGFMTT As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PGCStatFacChiffrage As DevExpress.XtraPivotGrid.PivotGridControl
    Private WithEvents PGFNB As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PGFVELFCRE As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents ChartCtrlStatFacChiff As DevExpress.XtraCharts.ChartControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CboMoisHsFact As System.Windows.Forms.ComboBox
    Friend WithEvents ChkHsFact As System.Windows.Forms.CheckBox
End Class
