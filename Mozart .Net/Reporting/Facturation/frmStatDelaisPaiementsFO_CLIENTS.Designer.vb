Imports DevExpress.Xpf.Editors

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStatDelaisPaiementsFO_CLIENTS
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatDelaisPaiementsFO_CLIENTS))
    Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
    Dim ConstantLine1 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
    Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
    Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
    Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
    Dim ConstantLine2 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
    Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
    Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.BtnPrint = New System.Windows.Forms.Button()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.GCStat = New DevExpress.XtraGrid.GridControl()
    Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.VSTFNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.VFACREF = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.DFACRECEPT = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.DDATBAP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.DIFF = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.lblTitre2 = New System.Windows.Forms.Label()
    Me.BtValider = New System.Windows.Forms.Button()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.VCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.NFACNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.DFACDAT = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.DFACREGT = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.DIFFClient = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GrpPer = New System.Windows.Forms.GroupBox()
    Me.Chart1 = New DevExpress.XtraCharts.ChartControl()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.Chart2 = New DevExpress.XtraCharts.ChartControl()
    Me.txtDateDebut = New DevExpress.XtraEditors.DateEdit()
    Me.txtDateFin = New DevExpress.XtraEditors.DateEdit()
    Me.apiSocieteAuto1 = New MozartUC.apiSocieteAuto()
    Me.GrpActions.SuspendLayout()
    CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GrpPer.SuspendLayout()
    CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox1.SuspendLayout()
    CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDateDebut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDateDebut.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDateFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDateFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
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
    Me.GVStat.ColumnPanelRowHeight = 50
    Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.VSTFNOM, Me.VFACREF, Me.DFACRECEPT, Me.DDATBAP, Me.DIFF})
    Me.GVStat.GridControl = Me.GCStat
    Me.GVStat.Name = "GVStat"
    Me.GVStat.OptionsBehavior.Editable = False
    Me.GVStat.OptionsBehavior.ReadOnly = True
    Me.GVStat.OptionsView.ShowAutoFilterRow = True
    Me.GVStat.OptionsView.ShowFooter = True
    Me.GVStat.OptionsView.ShowGroupPanel = False
    '
    'VSTFNOM
    '
    Me.VSTFNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.VSTFNOM.AppearanceHeader.Options.UseForeColor = True
    resources.ApplyResources(Me.VSTFNOM, "VSTFNOM")
    Me.VSTFNOM.FieldName = "VSTFNOM"
    Me.VSTFNOM.Name = "VSTFNOM"
    Me.VSTFNOM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("VSTFNOM.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("VSTFNOM.Summary1"), resources.GetString("VSTFNOM.Summary2"))})
    '
    'VFACREF
    '
    Me.VFACREF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.VFACREF.AppearanceHeader.Options.UseForeColor = True
    resources.ApplyResources(Me.VFACREF, "VFACREF")
    Me.VFACREF.FieldName = "VFACREF"
    Me.VFACREF.Name = "VFACREF"
    '
    'DFACRECEPT
    '
    Me.DFACRECEPT.AppearanceCell.Options.UseTextOptions = True
    Me.DFACRECEPT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.DFACRECEPT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.DFACRECEPT.AppearanceHeader.Options.UseForeColor = True
    resources.ApplyResources(Me.DFACRECEPT, "DFACRECEPT")
    Me.DFACRECEPT.FieldName = "DFACRECEPT"
    Me.DFACRECEPT.Name = "DFACRECEPT"
    '
    'DDATBAP
    '
    Me.DDATBAP.AppearanceCell.Options.UseTextOptions = True
    Me.DDATBAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.DDATBAP.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.DDATBAP.AppearanceHeader.Options.UseForeColor = True
    resources.ApplyResources(Me.DDATBAP, "DDATBAP")
    Me.DDATBAP.FieldName = "DDATBAP"
    Me.DDATBAP.Name = "DDATBAP"
    '
    'DIFF
    '
    Me.DIFF.AppearanceCell.Options.UseTextOptions = True
    Me.DIFF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.DIFF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.DIFF.AppearanceHeader.Options.UseForeColor = True
    resources.ApplyResources(Me.DIFF, "DIFF")
    Me.DIFF.DisplayFormat.FormatString = "{0:n0}"
    Me.DIFF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.DIFF.FieldName = "DIFF"
    Me.DIFF.Name = "DIFF"
    '
    'lblTitre2
    '
    resources.ApplyResources(Me.lblTitre2, "lblTitre2")
    Me.lblTitre2.Name = "lblTitre2"
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
    'Label2
    '
    resources.ApplyResources(Me.Label2, "Label2")
    Me.Label2.Name = "Label2"
    '
    'Label4
    '
    resources.ApplyResources(Me.Label4, "Label4")
    Me.Label4.Name = "Label4"
    '
    'GridControl1
    '
    resources.ApplyResources(Me.GridControl1, "GridControl1")
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'GridView1
    '
    Me.GridView1.Appearance.HeaderPanel.Font = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.Font"), System.Drawing.Font)
    Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
    Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.GridView1.ColumnPanelRowHeight = 50
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.VCLINOM, Me.NFACNUM, Me.DFACDAT, Me.DFACREGT, Me.DIFFClient})
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsBehavior.Editable = False
    Me.GridView1.OptionsBehavior.ReadOnly = True
    Me.GridView1.OptionsView.ShowAutoFilterRow = True
    Me.GridView1.OptionsView.ShowFooter = True
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'VCLINOM
    '
    Me.VCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.VCLINOM.AppearanceHeader.Options.UseForeColor = True
    resources.ApplyResources(Me.VCLINOM, "VCLINOM")
    Me.VCLINOM.FieldName = "VCLINOM"
    Me.VCLINOM.Name = "VCLINOM"
    Me.VCLINOM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("VCLINOM.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("VCLINOM.Summary1"), resources.GetString("VCLINOM.Summary2"))})
    '
    'NFACNUM
    '
    Me.NFACNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.NFACNUM.AppearanceHeader.Options.UseForeColor = True
    resources.ApplyResources(Me.NFACNUM, "NFACNUM")
    Me.NFACNUM.FieldName = "NFACNUM"
    Me.NFACNUM.Name = "NFACNUM"
    '
    'DFACDAT
    '
    Me.DFACDAT.AppearanceCell.Options.UseTextOptions = True
    Me.DFACDAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.DFACDAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.DFACDAT.AppearanceHeader.Options.UseForeColor = True
    resources.ApplyResources(Me.DFACDAT, "DFACDAT")
    Me.DFACDAT.FieldName = "DFACDAT"
    Me.DFACDAT.Name = "DFACDAT"
    '
    'DFACREGT
    '
    Me.DFACREGT.AppearanceCell.Options.UseTextOptions = True
    Me.DFACREGT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.DFACREGT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.DFACREGT.AppearanceHeader.Options.UseForeColor = True
    resources.ApplyResources(Me.DFACREGT, "DFACREGT")
    Me.DFACREGT.FieldName = "DFACREGT"
    Me.DFACREGT.Name = "DFACREGT"
    '
    'DIFFClient
    '
    Me.DIFFClient.AppearanceCell.Options.UseTextOptions = True
    Me.DIFFClient.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.DIFFClient.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.DIFFClient.AppearanceHeader.Options.UseForeColor = True
    resources.ApplyResources(Me.DIFFClient, "DIFFClient")
    Me.DIFFClient.DisplayFormat.FormatString = "{0:n0}"
    Me.DIFFClient.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.DIFFClient.FieldName = "DIFF"
    Me.DIFFClient.Name = "DIFFClient"
    '
    'GrpPer
    '
    Me.GrpPer.Controls.Add(Me.Chart1)
    resources.ApplyResources(Me.GrpPer, "GrpPer")
    Me.GrpPer.Name = "GrpPer"
    Me.GrpPer.TabStop = False
    '
    'Chart1
    '
    XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
    ConstantLine1.AxisValueSerializable = "1"
    ConstantLine1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
    ConstantLine1.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Solid
    ConstantLine1.LineStyle.Thickness = 2
    ConstantLine1.Name = "Objectif"
    ConstantLine1.Title.DXFont = CType(resources.GetObject("resource.DXFont"), DevExpress.Drawing.DXFont)
    ConstantLine1.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
    ConstantLine1.Title.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
    ConstantLine1.Visible = False
    XyDiagram1.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine1})
    XyDiagram1.AxisY.Title.Text = resources.GetString("resource.Text")
    XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
    XyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
    Me.Chart1.Diagram = XyDiagram1
    resources.ApplyResources(Me.Chart1, "Chart1")
    Me.Chart1.Legend.EquallySpacedItems = False
    Me.Chart1.Legend.Name = "Default Legend"
    Me.Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
    Me.Chart1.Name = "Chart1"
    Series1.ArgumentDataMember = "libelle"
    Series1.ValueDataMembersSerializable = "combien"
    Me.Chart1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
    SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
    Me.Chart1.SeriesTemplate.Label = SideBySideBarSeriesLabel1
    resources.ApplyResources(ChartTitle1, "ChartTitle1")
    ChartTitle1.TextColor = System.Drawing.Color.Black
    Me.Chart1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.Chart2)
    resources.ApplyResources(Me.GroupBox1, "GroupBox1")
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.TabStop = False
    '
    'Chart2
    '
    XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
    ConstantLine2.AxisValueSerializable = "1"
    ConstantLine2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
    ConstantLine2.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Solid
    ConstantLine2.LineStyle.Thickness = 2
    ConstantLine2.Name = "Objectif"
    ConstantLine2.Title.DXFont = CType(resources.GetObject("resource.DXFont1"), DevExpress.Drawing.DXFont)
    ConstantLine2.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
    ConstantLine2.Title.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
    ConstantLine2.Visible = False
    XyDiagram2.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine2})
    XyDiagram2.AxisY.Title.Text = resources.GetString("resource.Text1")
    XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
    XyDiagram2.AxisY.WholeRange.AlwaysShowZeroLevel = False
    Me.Chart2.Diagram = XyDiagram2
    resources.ApplyResources(Me.Chart2, "Chart2")
    Me.Chart2.Legend.EquallySpacedItems = False
    Me.Chart2.Legend.Name = "Default Legend"
    Me.Chart2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
    Me.Chart2.Name = "Chart2"
    Series2.ArgumentDataMember = "libelle"
    Series2.ValueDataMembersSerializable = "combien"
    Me.Chart2.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
    SideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
    Me.Chart2.SeriesTemplate.Label = SideBySideBarSeriesLabel2
    resources.ApplyResources(ChartTitle2, "ChartTitle2")
    ChartTitle2.TextColor = System.Drawing.Color.Black
    Me.Chart2.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
    '
    'txtDateDebut
    '
    resources.ApplyResources(Me.txtDateDebut, "txtDateDebut")
    Me.txtDateDebut.Name = "txtDateDebut"
    Me.txtDateDebut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateDebut.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.txtDateDebut.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateDebut.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)), New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateDebut.Properties.CalendarTimeProperties.Buttons1"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    '
    'txtDateFin
    '
    resources.ApplyResources(Me.txtDateFin, "txtDateFin")
    Me.txtDateFin.Name = "txtDateFin"
    Me.txtDateFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateFin.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.txtDateFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateFin.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)), New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateFin.Properties.CalendarTimeProperties.Buttons1"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    '
    'apiSocieteAuto1
    '
    Me.apiSocieteAuto1.CacheOneSoc = False
    resources.ApplyResources(Me.apiSocieteAuto1, "apiSocieteAuto1")
    Me.apiSocieteAuto1.IdMenuParent = CType(518, Short)
    Me.apiSocieteAuto1.ListIndex = CType(-1, Short)
    Me.apiSocieteAuto1.Name = "apiSocieteAuto1"
    '
    'frmStatDelaisPaiementsFO_CLIENTS
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.CancelButton = Me.BtnFermer
    Me.Controls.Add(Me.apiSocieteAuto1)
    Me.Controls.Add(Me.txtDateFin)
    Me.Controls.Add(Me.txtDateDebut)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.GrpPer)
    Me.Controls.Add(Me.GridControl1)
    Me.Controls.Add(Me.BtValider)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.lblTitre2)
    Me.Controls.Add(Me.GCStat)
    Me.Controls.Add(Me.LblTitre)
    Me.Controls.Add(Me.GrpActions)
    Me.Name = "frmStatDelaisPaiementsFO_CLIENTS"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.GrpActions.ResumeLayout(False)
    CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GrpPer.ResumeLayout(False)
    CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox1.ResumeLayout(False)
    CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDateDebut.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDateDebut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDateFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDateFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents BtnPrint As System.Windows.Forms.Button
  Friend WithEvents LblTitre As System.Windows.Forms.Label
  Friend WithEvents lblTitre2 As System.Windows.Forms.Label
  Friend WithEvents BtValider As System.Windows.Forms.Button
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents GrpPer As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
  Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents VSTFNOM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents VFACREF As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents DFACRECEPT As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents DDATBAP As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents DIFF As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents VCLINOM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents NFACNUM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents DFACDAT As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents DFACREGT As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents DIFFClient As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents Chart1 As DevExpress.XtraCharts.ChartControl
  Private WithEvents Chart2 As DevExpress.XtraCharts.ChartControl
  Friend WithEvents apiSocieteAuto1 As MozartUC.apiSocieteAuto
  Friend WithEvents txtDateDebut As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtDateFin As DevExpress.XtraEditors.DateEdit
End Class
