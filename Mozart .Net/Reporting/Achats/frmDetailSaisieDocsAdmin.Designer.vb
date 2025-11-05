<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetailSaisieDocsAdmin
  Inherits System.Windows.Forms.Form

  'Form remplace la méthode Dispose pour nettoyer la liste des composants.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetailSaisieDocsAdmin))
    Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
    Dim ConstantLine2 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
    Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
    Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
    Dim Bar3DSeriesLabel2 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel()
    Dim SideBySideBar3DSeriesView2 As DevExpress.XtraCharts.SideBySideBar3DSeriesView = New DevExpress.XtraCharts.SideBySideBar3DSeriesView()
    Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
    Me.cboSociete = New System.Windows.Forms.ComboBox()
    Me.lblPerim = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.BtnPrint = New System.Windows.Forms.Button()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
    Me.BtValider = New System.Windows.Forms.Button()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.DTPFin = New System.Windows.Forms.DateTimePicker()
    Me.DTPDebut = New System.Windows.Forms.DateTimePicker()
    Me.GroupBox1.SuspendLayout()
    CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Bar3DSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(SideBySideBar3DSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GrpActions.SuspendLayout()
    Me.SuspendLayout()
    '
    'cboSociete
    '
    Me.cboSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    resources.ApplyResources(Me.cboSociete, "cboSociete")
    Me.cboSociete.FormattingEnabled = True
    Me.cboSociete.Name = "cboSociete"
    Me.cboSociete.Tag = "45"
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
    resources.ApplyResources(Me.Label4, "Label4")
    Me.Label4.Name = "Label4"
    Me.Label4.Tag = "45"
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
    'Label5
    '
    Me.Label5.BackColor = System.Drawing.Color.White
    resources.ApplyResources(Me.Label5, "Label5")
    Me.Label5.Name = "Label5"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.ChartControl1)
    resources.ApplyResources(Me.GroupBox1, "GroupBox1")
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.TabStop = False
    '
    'ChartControl1
    '
    XyDiagram2.AxisX.Label.Angle = CType(resources.GetObject("resource.Angle"), Integer)
    XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
    XyDiagram2.AxisY.AutoScaleBreaks.Enabled = True
    ConstantLine2.AxisValueSerializable = "1"
    ConstantLine2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
    ConstantLine2.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Solid
    ConstantLine2.LineStyle.Thickness = 2
    ConstantLine2.Name = "Objectif"
    ConstantLine2.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
    ConstantLine2.Title.Font = CType(resources.GetObject("resource.Font"), System.Drawing.Font)
    ConstantLine2.Title.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
    ConstantLine2.Visible = False
    XyDiagram2.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine2})
    XyDiagram2.AxisY.NumericScaleOptions.AutoGrid = False
    XyDiagram2.AxisY.NumericScaleOptions.CustomGridAlignment = 5.0R
    XyDiagram2.AxisY.NumericScaleOptions.GridAlignment = DevExpress.XtraCharts.NumericGridAlignment.Custom
    XyDiagram2.AxisY.ScaleBreakOptions.Color = System.Drawing.Color.SteelBlue
    XyDiagram2.AxisY.Tickmarks.MinorVisible = False
    XyDiagram2.AxisY.Title.Text = resources.GetString("resource.Text")
    XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
    XyDiagram2.AxisY.WholeRange.AutoSideMargins = False
    XyDiagram2.AxisY.WholeRange.SideMarginsValue = 0.93R
    Me.ChartControl1.Diagram = XyDiagram2
    resources.ApplyResources(Me.ChartControl1, "ChartControl1")
    Me.ChartControl1.Legend.EquallySpacedItems = False
    Me.ChartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
    Me.ChartControl1.Name = "ChartControl1"
    Series2.ArgumentDataMember = "VPERNOM"
    SideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
    SideBySideBarSeriesLabel2.TextPattern = "{V:N0}"
    Series2.Label = SideBySideBarSeriesLabel2
    Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
    Series2.ShowInLegend = False
    Series2.ValueDataMembersSerializable = "NBDOCUMENTS"
    SideBySideBarSeriesView2.Color = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
    SideBySideBarSeriesView2.ColorEach = True
    SideBySideBarSeriesView2.Transparency = CType(30, Byte)
    Series2.View = SideBySideBarSeriesView2
    Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
    Me.ChartControl1.SeriesTemplate.ArgumentDataMember = "VPERNOM"
    Bar3DSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
    Me.ChartControl1.SeriesTemplate.Label = Bar3DSeriesLabel2
    Me.ChartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
    Me.ChartControl1.SeriesTemplate.ValueDataMembersSerializable = "NBDOCUMENTS"
    Me.ChartControl1.SeriesTemplate.View = SideBySideBar3DSeriesView2
    ChartTitle2.Visibility = DevExpress.Utils.DefaultBoolean.[False]
    Me.ChartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
    '
    'BtValider
    '
    resources.ApplyResources(Me.BtValider, "BtValider")
    Me.BtValider.Name = "BtValider"
    Me.BtValider.UseVisualStyleBackColor = True
    '
    'Label3
    '
    resources.ApplyResources(Me.Label3, "Label3")
    Me.Label3.Name = "Label3"
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.Name = "Label1"
    '
    'GrpActions
    '
    Me.GrpActions.Controls.Add(Me.BtnPrint)
    Me.GrpActions.Controls.Add(Me.BtnFermer)
    resources.ApplyResources(Me.GrpActions, "GrpActions")
    Me.GrpActions.Name = "GrpActions"
    Me.GrpActions.TabStop = False
    '
    'LblTitre
    '
    resources.ApplyResources(Me.LblTitre, "LblTitre")
    Me.LblTitre.Name = "LblTitre"
    '
    'DTPFin
    '
    resources.ApplyResources(Me.DTPFin, "DTPFin")
    Me.DTPFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.DTPFin.Name = "DTPFin"
    '
    'DTPDebut
    '
    resources.ApplyResources(Me.DTPDebut, "DTPDebut")
    Me.DTPDebut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.DTPDebut.Name = "DTPDebut"
    '
    'frmDetailSaisieDocsAdmin
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.Controls.Add(Me.DTPDebut)
    Me.Controls.Add(Me.DTPFin)
    Me.Controls.Add(Me.cboSociete)
    Me.Controls.Add(Me.lblPerim)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.BtValider)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.GrpActions)
    Me.Controls.Add(Me.LblTitre)
    Me.Name = "frmDetailSaisieDocsAdmin"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.GroupBox1.ResumeLayout(False)
    CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Bar3DSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(SideBySideBar3DSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GrpActions.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents cboSociete As ComboBox
  Friend WithEvents lblPerim As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents BtnPrint As Button
  Friend WithEvents BtnFermer As Button
  Friend WithEvents Label5 As Label
  Friend WithEvents GroupBox1 As GroupBox
  Private WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
  Friend WithEvents BtValider As Button
  Friend WithEvents Label3 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents GrpActions As GroupBox
  Friend WithEvents LblTitre As Label
  Friend WithEvents DTPFin As DateTimePicker
  Friend WithEvents DTPDebut As DateTimePicker
End Class
