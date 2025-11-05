<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatTurnOver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatTurnOver))
        Dim XyDiagram3 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim ConstantLine3 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel5 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView3 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim RegressionLine3 As DevExpress.XtraCharts.RegressionLine = New DevExpress.XtraCharts.RegressionLine()
        Dim SideBySideBarSeriesLabel6 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim ChartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.lblDateJour = New System.Windows.Forms.Label()
        Me.BtValider = New System.Windows.Forms.Button()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpPer = New System.Windows.Forms.GroupBox()
        Me.Chart1 = New DevExpress.XtraCharts.ChartControl()
        Me.lblPerim = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNbSalaries = New System.Windows.Forms.Label()
        Me.apiSocieteAuto1 = New MozartUC.apiSocieteAuto()
        Me.GrpActions.SuspendLayout()
        Me.GrpPer.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RegressionLine3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDateJour
        '
        resources.ApplyResources(Me.lblDateJour, "lblDateJour")
        Me.lblDateJour.Name = "lblDateJour"
        '
        'BtValider
        '
        resources.ApplyResources(Me.BtValider, "BtValider")
        Me.BtValider.Name = "BtValider"
        Me.BtValider.UseVisualStyleBackColor = True
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GrpPer
        '
        resources.ApplyResources(Me.GrpPer, "GrpPer")
        Me.GrpPer.Controls.Add(Me.Chart1)
        Me.GrpPer.Name = "GrpPer"
        Me.GrpPer.TabStop = False
        '
        'Chart1
        '
        XyDiagram3.AxisX.NumericScaleOptions.AutoGrid = False
        XyDiagram3.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram3.AxisX.WholeRange.AutoSideMargins = False
        XyDiagram3.AxisX.WholeRange.EndSideMargin = 0.4R
        XyDiagram3.AxisX.WholeRange.StartSideMargin = 0.4R
        ConstantLine3.AxisValueSerializable = "1"
        ConstantLine3.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        resources.ApplyResources(ConstantLine3, "ConstantLine3")
        ConstantLine3.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Solid
        ConstantLine3.LineStyle.Thickness = 2
        ConstantLine3.Name = "Objectif"
        ConstantLine3.Title.DXFont = CType(resources.GetObject("resource.DXFont"), DevExpress.Drawing.DXFont)
        ConstantLine3.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        ConstantLine3.Title.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        ConstantLine3.Visible = False
        XyDiagram3.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine3})
        XyDiagram3.AxisY.Title.Text = resources.GetString("resource.Text")
        XyDiagram3.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram3.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram3.AxisY.WholeRange.AlwaysShowZeroLevel = False
        Me.Chart1.Diagram = XyDiagram3
        resources.ApplyResources(Me.Chart1, "Chart1")
        Me.Chart1.Legend.EquallySpacedItems = False
        Me.Chart1.Legend.Name = "Default Legend"
        Me.Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.Chart1.Name = "Chart1"
        Series3.ArgumentDataMember = "ANNEE"
        SideBySideBarSeriesLabel5.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel5.TextPattern = "{V:N0}"
        Series3.Label = SideBySideBarSeriesLabel5
        Series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        resources.ApplyResources(Series3, "Series3")
        Series3.ShowInLegend = False
        Series3.ValueDataMembersSerializable = "TURNOVER"
        SideBySideBarSeriesView3.Color = System.Drawing.Color.DodgerBlue
        SideBySideBarSeriesView3.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient
        RegressionLine3.Color = System.Drawing.Color.Fuchsia
        resources.ApplyResources(RegressionLine3, "RegressionLine3")
        SideBySideBarSeriesView3.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {RegressionLine3})
        Series3.View = SideBySideBarSeriesView3
        Me.Chart1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3}
        SideBySideBarSeriesLabel6.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.Chart1.SeriesTemplate.Label = SideBySideBarSeriesLabel6
        resources.ApplyResources(ChartTitle3, "ChartTitle3")
        ChartTitle3.TextColor = System.Drawing.Color.Black
        ChartTitle3.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.Chart1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle3})
        '
        'lblPerim
        '
        resources.ApplyResources(Me.lblPerim, "lblPerim")
        Me.lblPerim.BackColor = System.Drawing.Color.White
        Me.lblPerim.ForeColor = System.Drawing.Color.Black
        Me.lblPerim.Name = "lblPerim"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Name = "Label4"
        '
        'lblNbSalaries
        '
        resources.ApplyResources(Me.lblNbSalaries, "lblNbSalaries")
        Me.lblNbSalaries.Name = "lblNbSalaries"
        '
        'apiSocieteAuto1
        '
        Me.apiSocieteAuto1.CacheOneSoc = False
        resources.ApplyResources(Me.apiSocieteAuto1, "apiSocieteAuto1")
        Me.apiSocieteAuto1.IdMenuParent = CType(411, Short)
        Me.apiSocieteAuto1.ListIndex = CType(-1, Short)
        Me.apiSocieteAuto1.Name = "apiSocieteAuto1"
        '
        'frmStatTurnOver
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnFermer
        Me.Controls.Add(Me.apiSocieteAuto1)
        Me.Controls.Add(Me.lblNbSalaries)
        Me.Controls.Add(Me.lblPerim)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GrpPer)
        Me.Controls.Add(Me.lblDateJour)
        Me.Controls.Add(Me.BtValider)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "frmStatTurnOver"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.GrpPer.ResumeLayout(False)
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RegressionLine3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDateJour As System.Windows.Forms.Label
  Friend WithEvents BtValider As System.Windows.Forms.Button
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GrpPer As System.Windows.Forms.GroupBox
    Friend WithEvents lblPerim As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblNbSalaries As System.Windows.Forms.Label
    Private WithEvents Chart1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents apiSocieteAuto1 As MozartUC.apiSocieteAuto
End Class
