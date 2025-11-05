<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatFacturationEISemaine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatFacturationEISemaine))
        Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.PGrid = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldSemaine = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTechnicien = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMontant = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNPERNUM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblPerim = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChartStatEI = New DevExpress.XtraCharts.ChartControl()
        Me.GrpActions.SuspendLayout()
        CType(Me.PGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ChartStatEI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnFermer)
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
        'PGrid
        '
        Me.PGrid.Appearance.ColumnHeaderArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PGrid.Appearance.ColumnHeaderArea.Options.UseBackColor = True
        Me.PGrid.Appearance.ColumnHeaderArea.Options.UseTextOptions = True
        Me.PGrid.Appearance.ColumnHeaderArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGrid.Appearance.ColumnHeaderArea.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGrid.Appearance.DataHeaderArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PGrid.Appearance.DataHeaderArea.Font = CType(resources.GetObject("PGrid.Appearance.DataHeaderArea.Font"), System.Drawing.Font)
        Me.PGrid.Appearance.DataHeaderArea.Options.UseBackColor = True
        Me.PGrid.Appearance.DataHeaderArea.Options.UseFont = True
        Me.PGrid.Appearance.FieldHeader.ForeColor = System.Drawing.Color.Black
        Me.PGrid.Appearance.FieldHeader.Options.UseForeColor = True
        Me.PGrid.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black
        Me.PGrid.Appearance.FieldValue.Options.UseForeColor = True
        Me.PGrid.Appearance.FieldValue.Options.UseTextOptions = True
        Me.PGrid.Appearance.FieldValue.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PGrid.Appearance.FieldValue.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGrid.Appearance.FieldValueGrandTotal.Font = CType(resources.GetObject("PGrid.Appearance.FieldValueGrandTotal.Font"), System.Drawing.Font)
        Me.PGrid.Appearance.FieldValueGrandTotal.ForeColor = System.Drawing.Color.Black
        Me.PGrid.Appearance.FieldValueGrandTotal.Options.UseFont = True
        Me.PGrid.Appearance.FieldValueGrandTotal.Options.UseForeColor = True
        Me.PGrid.Appearance.FieldValueGrandTotal.Options.UseTextOptions = True
        Me.PGrid.Appearance.FieldValueGrandTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGrid.Appearance.FieldValueGrandTotal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.PGrid.Appearance.FieldValueTotal.ForeColor = System.Drawing.Color.Black
        Me.PGrid.Appearance.FieldValueTotal.Options.UseForeColor = True
        Me.PGrid.Appearance.GrandTotalCell.Options.UseTextOptions = True
        Me.PGrid.Appearance.GrandTotalCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PGrid.Appearance.GrandTotalCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGrid.Appearance.RowHeaderArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PGrid.Appearance.RowHeaderArea.Options.UseBackColor = True
        Me.PGrid.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldSemaine, Me.fieldTechnicien, Me.fieldMontant, Me.fieldNPERNUM})
        resources.ApplyResources(Me.PGrid, "PGrid")
        Me.PGrid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.PGrid.Name = "PGrid"
        Me.PGrid.OptionsChartDataSource.DataProvideMode = DevExpress.XtraPivotGrid.PivotChartDataProvideMode.UseCustomSettings
        Me.PGrid.OptionsChartDataSource.MaxAllowedSeriesCount = 50
        Me.PGrid.OptionsChartDataSource.ProvideColumnGrandTotals = True
        Me.PGrid.OptionsChartDataSource.ProvideDataByColumns = False
        Me.PGrid.OptionsChartDataSource.ProvideRowGrandTotals = True
        Me.PGrid.OptionsChartDataSource.ProvideRowTotals = True
        Me.PGrid.OptionsChartDataSource.SelectionOnly = False
        Me.PGrid.OptionsCustomization.AllowDrag = False
        Me.PGrid.OptionsCustomization.AllowDragInCustomizationForm = False
        Me.PGrid.OptionsCustomization.AllowEdit = False
        Me.PGrid.OptionsCustomization.AllowExpand = False
        Me.PGrid.OptionsCustomization.AllowExpandOnDoubleClick = False
        Me.PGrid.OptionsCustomization.AllowFilter = False
        Me.PGrid.OptionsCustomization.AllowResizing = False
        Me.PGrid.OptionsCustomization.FilterPanelVisible = DevExpress.XtraPivotGrid.FilterPanelVisible.Never
        Me.PGrid.OptionsSelection.CellSelection = False
        Me.PGrid.OptionsSelection.MultiSelect = False
        Me.PGrid.OptionsView.ShowColumnGrandTotals = False
        '
        'fieldSemaine
        '
        Me.fieldSemaine.Appearance.Cell.ForeColor = System.Drawing.Color.Black
        Me.fieldSemaine.Appearance.Cell.Options.UseForeColor = True
        Me.fieldSemaine.Appearance.Header.ForeColor = System.Drawing.Color.Black
        Me.fieldSemaine.Appearance.Header.Options.UseForeColor = True
        Me.fieldSemaine.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldSemaine.AreaIndex = 0
        resources.ApplyResources(Me.fieldSemaine, "fieldSemaine")
        Me.fieldSemaine.FieldName = "CLASS"
        Me.fieldSemaine.Name = "fieldSemaine"
        Me.fieldSemaine.Options.ShowCustomTotals = False
        Me.fieldSemaine.Options.ShowGrandTotal = False
        Me.fieldSemaine.Options.ShowTotals = False
        Me.fieldSemaine.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom
        Me.fieldSemaine.TotalValueFormat.FormatString = "### ### ###"
        '
        'fieldTechnicien
        '
        Me.fieldTechnicien.Appearance.Cell.ForeColor = System.Drawing.Color.Black
        Me.fieldTechnicien.Appearance.Cell.Options.UseForeColor = True
        Me.fieldTechnicien.Appearance.Header.ForeColor = System.Drawing.Color.Black
        Me.fieldTechnicien.Appearance.Header.Options.UseForeColor = True
        Me.fieldTechnicien.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldTechnicien.AreaIndex = 0
        resources.ApplyResources(Me.fieldTechnicien, "fieldTechnicien")
        Me.fieldTechnicien.FieldName = "TECHNICIEN"
        Me.fieldTechnicien.Name = "fieldTechnicien"
        Me.fieldTechnicien.Options.ShowCustomTotals = False
        Me.fieldTechnicien.Options.ShowGrandTotal = False
        Me.fieldTechnicien.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom
        '
        'fieldMontant
        '
        Me.fieldMontant.Appearance.Header.ForeColor = System.Drawing.Color.Black
        Me.fieldMontant.Appearance.Header.Options.UseForeColor = True
        Me.fieldMontant.Appearance.ValueGrandTotal.BackColor = System.Drawing.Color.Silver
        Me.fieldMontant.Appearance.ValueGrandTotal.Font = CType(resources.GetObject("fieldMontant.Appearance.ValueGrandTotal.Font"), System.Drawing.Font)
        Me.fieldMontant.Appearance.ValueGrandTotal.Options.UseBackColor = True
        Me.fieldMontant.Appearance.ValueGrandTotal.Options.UseFont = True
        Me.fieldMontant.Appearance.ValueGrandTotal.Options.UseTextOptions = True
        Me.fieldMontant.Appearance.ValueGrandTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.fieldMontant.Appearance.ValueGrandTotal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fieldMontant.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldMontant.AreaIndex = 0
        resources.ApplyResources(Me.fieldMontant, "fieldMontant")
        Me.fieldMontant.CellFormat.FormatString = "### ### ###"
        Me.fieldMontant.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMontant.FieldName = "MONTANT"
        Me.fieldMontant.Name = "fieldMontant"
        Me.fieldMontant.Options.ShowCustomTotals = False
        Me.fieldMontant.Options.ShowTotals = False
        Me.fieldMontant.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom
        '
        'fieldNPERNUM
        '
        Me.fieldNPERNUM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNPERNUM.AreaIndex = 1
        Me.fieldNPERNUM.FieldName = "NPERNUM"
        Me.fieldNPERNUM.Name = "fieldNPERNUM"
        Me.fieldNPERNUM.Visible = False
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblPerim)
        Me.GroupBox3.Controls.Add(Me.Label4)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'lblPerim
        '
        Me.lblPerim.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPerim, "lblPerim")
        Me.lblPerim.ForeColor = System.Drawing.Color.Black
        Me.lblPerim.Name = "lblPerim"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'ChartStatEI
        '
        resources.ApplyResources(Me.ChartStatEI, "ChartStatEI")
        Me.ChartStatEI.Name = "ChartStatEI"
        Me.ChartStatEI.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        SideBySideBarSeriesLabel3.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        Me.ChartStatEI.SeriesTemplate.Label = SideBySideBarSeriesLabel3
        '
        'frmStatFacturationEISemaine
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.ChartStatEI)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.PGrid)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmStatFacturationEISemaine"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.PGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartStatEI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPerim As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents PGrid As DevExpress.XtraPivotGrid.PivotGridControl
    Private WithEvents fieldSemaine As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents fieldTechnicien As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents fieldMontant As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents fieldNPERNUM As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents ChartStatEI As DevExpress.XtraCharts.ChartControl
End Class
