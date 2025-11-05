<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompareTechEI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompareTechEI))
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideStackedBarSeriesView1 As DevExpress.XtraCharts.SideBySideStackedBarSeriesView = New DevExpress.XtraCharts.SideBySideStackedBarSeriesView()
        Me.Technico = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCStat = New DevExpress.XtraGrid.GridControl()
        Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Prospects = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NBRDV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PLA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpFilter = New System.Windows.Forms.GroupBox()
        Me.BtnValider = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPDebut = New System.Windows.Forms.DateTimePicker()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.btnTGraph = New System.Windows.Forms.Button()
        Me.btnGraph = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.bntValider = New System.Windows.Forms.Button()
        Me.ChartStatEI = New DevExpress.XtraCharts.ChartControl()
        Me.ChartNBPROSP = New DevExpress.XtraCharts.ChartControl()
        Me.ChartNBRDV = New DevExpress.XtraCharts.ChartControl()
        Me.ChartRatio = New DevExpress.XtraCharts.ChartControl()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpFilter.SuspendLayout()
        Me.GrpActions.SuspendLayout()
        CType(Me.ChartStatEI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartNBPROSP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartNBRDV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideStackedBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Technico
        '
        Me.Technico.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Technico.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Technico, "Technico")
        Me.Technico.FieldName = "TECHNICIEN"
        Me.Technico.Name = "Technico"
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
        Me.GVStat.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVStat.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVStat.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVStat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Technico, Me.Prospects, Me.NBRDV, Me.PLA, Me.CA})
        Me.GVStat.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType(resources.GetObject("GVStat.GroupSummary"), DevExpress.Data.SummaryItemType), resources.GetString("GVStat.GroupSummary1"), CType(resources.GetObject("GVStat.GroupSummary2"), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("GVStat.GroupSummary3"))})
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsPrint.ExpandAllDetails = True
        Me.GVStat.OptionsPrint.PrintPreview = True
        Me.GVStat.OptionsView.ShowAutoFilterRow = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'Prospects
        '
        Me.Prospects.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Prospects.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Prospects, "Prospects")
        Me.Prospects.FieldName = "NBPROSP"
        Me.Prospects.Name = "Prospects"
        Me.Prospects.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("Prospects.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'NBRDV
        '
        Me.NBRDV.AppearanceCell.Options.UseTextOptions = True
        Me.NBRDV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NBRDV.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.NBRDV.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NBRDV.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NBRDV, "NBRDV")
        Me.NBRDV.FieldName = "NBRDV"
        Me.NBRDV.Name = "NBRDV"
        Me.NBRDV.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("NBRDV.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'PLA
        '
        Me.PLA.AppearanceCell.Options.UseTextOptions = True
        Me.PLA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PLA.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PLA.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.PLA.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.PLA, "PLA")
        Me.PLA.FieldName = "RATIOCHARGE"
        Me.PLA.Name = "PLA"
        Me.PLA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("PLA.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'CA
        '
        Me.CA.AppearanceCell.Options.UseTextOptions = True
        Me.CA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CA.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.CA.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.CA.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.CA, "CA")
        Me.CA.DisplayFormat.FormatString = "### ### ###"
        Me.CA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.CA.FieldName = "CA"
        Me.CA.Name = "CA"
        Me.CA.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom
        Me.CA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("CA.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GrpFilter
        '
        Me.GrpFilter.Controls.Add(Me.BtnValider)
        Me.GrpFilter.Controls.Add(Me.Label2)
        Me.GrpFilter.Controls.Add(Me.Label1)
        Me.GrpFilter.Controls.Add(Me.DTPFin)
        Me.GrpFilter.Controls.Add(Me.DTPDebut)
        resources.ApplyResources(Me.GrpFilter, "GrpFilter")
        Me.GrpFilter.Name = "GrpFilter"
        Me.GrpFilter.TabStop = False
        '
        'BtnValider
        '
        resources.ApplyResources(Me.BtnValider, "BtnValider")
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.UseVisualStyleBackColor = True
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
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.btnTGraph)
        Me.GrpActions.Controls.Add(Me.btnGraph)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'btnTGraph
        '
        resources.ApplyResources(Me.btnTGraph, "btnTGraph")
        Me.btnTGraph.Name = "btnTGraph"
        Me.btnTGraph.UseVisualStyleBackColor = True
        '
        'btnGraph
        '
        resources.ApplyResources(Me.btnGraph, "btnGraph")
        Me.btnGraph.Name = "btnGraph"
        Me.btnGraph.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'bntValider
        '
        resources.ApplyResources(Me.bntValider, "bntValider")
        Me.bntValider.Name = "bntValider"
        Me.bntValider.UseVisualStyleBackColor = True
        '
        'ChartStatEI
        '
        resources.ApplyResources(Me.ChartStatEI, "ChartStatEI")
        Me.ChartStatEI.Name = "ChartStatEI"
        Me.ChartStatEI.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartStatEI.SeriesTemplate.Label = SideBySideBarSeriesLabel1
        '
        'ChartNBPROSP
        '
        Me.ChartNBPROSP.Legend.DXFont = CType(resources.GetObject("ChartNBPROSP.Legend.DXFont"), DevExpress.Drawing.DXFont)
        resources.ApplyResources(Me.ChartNBPROSP, "ChartNBPROSP")
        Me.ChartNBPROSP.Name = "ChartNBPROSP"
        Me.ChartNBPROSP.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        SideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartNBPROSP.SeriesTemplate.Label = SideBySideBarSeriesLabel2
        '
        'ChartNBRDV
        '
        resources.ApplyResources(Me.ChartNBRDV, "ChartNBRDV")
        Me.ChartNBRDV.Name = "ChartNBRDV"
        Me.ChartNBRDV.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        SideBySideBarSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartNBRDV.SeriesTemplate.Label = SideBySideBarSeriesLabel3
        '
        'ChartRatio
        '
        resources.ApplyResources(Me.ChartRatio, "ChartRatio")
        Me.ChartRatio.Name = "ChartRatio"
        Me.ChartRatio.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartRatio.SeriesTemplate.View = SideBySideStackedBarSeriesView1
        '
        'frmCompareTechEI
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.ChartRatio)
        Me.Controls.Add(Me.ChartNBRDV)
        Me.Controls.Add(Me.ChartNBPROSP)
        Me.Controls.Add(Me.ChartStatEI)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GrpFilter)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "frmCompareTechEI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpFilter.ResumeLayout(False)
        Me.GrpActions.ResumeLayout(False)
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartStatEI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartNBPROSP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartNBRDV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideStackedBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartRatio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GrpFilter As System.Windows.Forms.GroupBox
    Friend WithEvents BtnValider As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPDebut As System.Windows.Forms.DateTimePicker
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents bntValider As System.Windows.Forms.Button
    Friend WithEvents btnGraph As System.Windows.Forms.Button
    Friend WithEvents btnTGraph As System.Windows.Forms.Button
    Private WithEvents Technico As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents Prospects As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NBRDV As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents PLA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents CA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ChartStatEI As DevExpress.XtraCharts.ChartControl
    Private WithEvents ChartNBPROSP As DevExpress.XtraCharts.ChartControl
    Private WithEvents ChartNBRDV As DevExpress.XtraCharts.ChartControl
    Private WithEvents ChartRatio As DevExpress.XtraCharts.ChartControl
End Class
