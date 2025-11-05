<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatDelaiFact
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatDelaiFact))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim ConstantLine1 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim RegressionLine1 As DevExpress.XtraCharts.RegressionLine = New DevExpress.XtraCharts.RegressionLine()
        Dim SideBySideBarSeriesLabel4 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Me.GCStat = New DevExpress.XtraGrid.GridControl()
        Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColPériode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColValeur = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.lblObj = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblPerim = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMoy12 = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.GrpPer = New System.Windows.Forms.GroupBox()
        Me.ChartCtrl = New DevExpress.XtraCharts.ChartControl()
        Me.GrpFilter = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPDebut = New System.Windows.Forms.DateTimePicker()
        Me.GCBas = New DevExpress.XtraGrid.GridControl()
        Me.GVStatBas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblObj36 = New System.Windows.Forms.Label()
        Me.lblPerim36 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblMoy36 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChartBas = New DevExpress.XtraCharts.ChartControl()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GrpActions.SuspendLayout()
        Me.GrpPer.SuspendLayout()
        CType(Me.ChartCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpFilter.SuspendLayout()
        CType(Me.GCBas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStatBas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ChartBas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RegressionLine1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColPériode, Me.ColValeur})
        Me.GVStat.DetailHeight = 284
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsEditForm.PopupEditFormWidth = 600
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'ColPériode
        '
        Me.ColPériode.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColPériode.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.ColPériode, "ColPériode")
        Me.ColPériode.FieldName = "LIB"
        Me.ColPériode.MinWidth = 15
        Me.ColPériode.Name = "ColPériode"
        '
        'ColValeur
        '
        Me.ColValeur.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColValeur.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.ColValeur, "ColValeur")
        Me.ColValeur.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColValeur.FieldName = "NB"
        Me.ColValeur.MinWidth = 15
        Me.ColValeur.Name = "ColValeur"
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'lblObj
        '
        Me.lblObj.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblObj, "lblObj")
        Me.lblObj.Name = "lblObj"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblObj)
        Me.GroupBox3.Controls.Add(Me.lblPerim)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lblMoy12)
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
        'lblMoy12
        '
        Me.lblMoy12.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblMoy12, "lblMoy12")
        Me.lblMoy12.ForeColor = System.Drawing.Color.Black
        Me.lblMoy12.Name = "lblMoy12"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'GrpPer
        '
        Me.GrpPer.Controls.Add(Me.ChartCtrl)
        resources.ApplyResources(Me.GrpPer, "GrpPer")
        Me.GrpPer.Name = "GrpPer"
        Me.GrpPer.TabStop = False
        '
        'ChartCtrl
        '
        Me.ChartCtrl.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.AxisX.Label.Angle = CType(resources.GetObject("resource.Angle"), Integer)
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Title.Text = resources.GetString("resource.Text")
        XyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartCtrl.Diagram = XyDiagram1
        resources.ApplyResources(Me.ChartCtrl, "ChartCtrl")
        Me.ChartCtrl.Legend.EquallySpacedItems = False
        Me.ChartCtrl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartCtrl.Name = "ChartCtrl"
        Series1.ArgumentDataMember = "LIB"
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel1.TextPattern = "{V:N0}"
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series1.ValueDataMembersSerializable = "NB"
        SideBySideBarSeriesView1.Color = System.Drawing.Color.DodgerBlue
        Series1.View = SideBySideBarSeriesView1
        Me.ChartCtrl.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        SideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartCtrl.SeriesTemplate.Label = SideBySideBarSeriesLabel2
        '
        'GrpFilter
        '
        Me.GrpFilter.Controls.Add(Me.ComboBox1)
        Me.GrpFilter.Controls.Add(Me.Label3)
        Me.GrpFilter.Controls.Add(Me.BtnValid)
        Me.GrpFilter.Controls.Add(Me.Label2)
        Me.GrpFilter.Controls.Add(Me.Label1)
        Me.GrpFilter.Controls.Add(Me.DTPFin)
        Me.GrpFilter.Controls.Add(Me.DTPDebut)
        resources.ApplyResources(Me.GrpFilter, "GrpFilter")
        Me.GrpFilter.Name = "GrpFilter"
        Me.GrpFilter.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Tag = "345"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
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
        'GCBas
        '
        resources.ApplyResources(Me.GCBas, "GCBas")
        Me.GCBas.MainView = Me.GVStatBas
        Me.GCBas.Name = "GCBas"
        Me.GCBas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStatBas})
        '
        'GVStatBas
        '
        Me.GVStatBas.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVStatBas.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVStatBas.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVStatBas.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVStatBas.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStatBas.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStatBas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GVStatBas.DetailHeight = 284
        Me.GVStatBas.GridControl = Me.GCBas
        Me.GVStatBas.Name = "GVStatBas"
        Me.GVStatBas.OptionsBehavior.Editable = False
        Me.GVStatBas.OptionsBehavior.ReadOnly = True
        Me.GVStatBas.OptionsEditForm.PopupEditFormWidth = 600
        Me.GVStatBas.OptionsView.ShowFooter = True
        Me.GVStatBas.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn1.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.FieldName = "LIB"
        Me.GridColumn1.MinWidth = 15
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn2.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn2, "GridColumn2")
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "NB"
        Me.GridColumn2.MinWidth = 15
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblObj36)
        Me.GroupBox2.Controls.Add(Me.lblPerim36)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblMoy36)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'lblObj36
        '
        Me.lblObj36.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblObj36, "lblObj36")
        Me.lblObj36.Name = "lblObj36"
        '
        'lblPerim36
        '
        Me.lblPerim36.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPerim36, "lblPerim36")
        Me.lblPerim36.ForeColor = System.Drawing.Color.Black
        Me.lblPerim36.Name = "lblPerim36"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'lblMoy36
        '
        Me.lblMoy36.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblMoy36, "lblMoy36")
        Me.lblMoy36.ForeColor = System.Drawing.Color.Black
        Me.lblMoy36.Name = "lblMoy36"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChartBas)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'ChartBas
        '
        XyDiagram2.AxisX.Label.Angle = CType(resources.GetObject("resource.Angle1"), Integer)
        XyDiagram2.AxisX.Reverse = True
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        ConstantLine1.AxisValueSerializable = "1"
        ConstantLine1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        ConstantLine1.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Solid
        ConstantLine1.LineStyle.Thickness = 2
        ConstantLine1.Name = "Objectif"
        ConstantLine1.Title.DXFont = CType(resources.GetObject("resource.DXFont"), DevExpress.Drawing.DXFont)
        ConstantLine1.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        ConstantLine1.Title.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        XyDiagram2.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine1})
        XyDiagram2.AxisY.Label.TextPattern = "{V:N0}"
        XyDiagram2.AxisY.Title.Text = resources.GetString("resource.Text1")
        XyDiagram2.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartBas.Diagram = XyDiagram2
        resources.ApplyResources(Me.ChartBas, "ChartBas")
        Me.ChartBas.Legend.EquallySpacedItems = False
        Me.ChartBas.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartBas.Name = "ChartBas"
        Series2.ArgumentDataMember = "LIB"
        SideBySideBarSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel3.TextPattern = "{V:N0}"
        Series2.Label = SideBySideBarSeriesLabel3
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series2.ShowInLegend = False
        Series2.ValueDataMembersSerializable = "NB"
        SideBySideBarSeriesView2.Color = System.Drawing.Color.DodgerBlue
        RegressionLine1.Color = System.Drawing.Color.Fuchsia
        SideBySideBarSeriesView2.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {RegressionLine1})
        Series2.View = SideBySideBarSeriesView2
        Me.ChartBas.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        SideBySideBarSeriesLabel4.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartBas.SeriesTemplate.Label = SideBySideBarSeriesLabel4
        '
        'frmStatDelaiFact
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GCBas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GrpFilter)
        Me.Controls.Add(Me.GrpPer)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmStatDelaiFact"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GrpActions.ResumeLayout(False)
        Me.GrpPer.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpFilter.ResumeLayout(False)
        Me.GrpFilter.PerformLayout()
        CType(Me.GCBas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStatBas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RegressionLine1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartBas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents lblObj As System.Windows.Forms.Label
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents lblPerim As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents lblMoy12 As System.Windows.Forms.Label
  Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
  Friend WithEvents BtnPrint As System.Windows.Forms.Button
  Friend WithEvents GrpPer As System.Windows.Forms.GroupBox
  Friend WithEvents GrpFilter As System.Windows.Forms.GroupBox
  Friend WithEvents BtnValid As System.Windows.Forms.Button
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents DTPFin As System.Windows.Forms.DateTimePicker
  Friend WithEvents DTPDebut As System.Windows.Forms.DateTimePicker
  Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
  Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents ColPériode As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents ColValeur As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents ChartCtrl As DevExpress.XtraCharts.ChartControl
  Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Private WithEvents GCBas As DevExpress.XtraGrid.GridControl
  Private WithEvents GVStatBas As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents lblObj36 As System.Windows.Forms.Label
  Friend WithEvents lblPerim36 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents lblMoy36 As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Private WithEvents ChartBas As DevExpress.XtraCharts.ChartControl
End Class
