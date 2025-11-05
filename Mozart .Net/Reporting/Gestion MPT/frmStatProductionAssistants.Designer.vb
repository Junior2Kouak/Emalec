<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatProductionAssistants
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatProductionAssistants))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim ConstantLine1 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Bar3DSeriesLabel1 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel()
        Dim SideBySideBar3DSeriesView1 As DevExpress.XtraCharts.SideBySideBar3DSeriesView = New DevExpress.XtraCharts.SideBySideBar3DSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.BtValider = New System.Windows.Forms.Button()
        Me.lblDateJour = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnDate3 = New System.Windows.Forms.Button()
        Me.txtDtCreaAu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.BtnDate1 = New System.Windows.Forms.Button()
        Me.txtDtCreaDu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GCStat = New DevExpress.XtraGrid.GridControl()
        Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Assistant = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VTYPEDETAILLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.ButtonExporter = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBar3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtValider
        '
        resources.ApplyResources(Me.BtValider, "BtValider")
        Me.BtValider.Name = "BtValider"
        Me.BtValider.UseVisualStyleBackColor = True
        '
        'lblDateJour
        '
        resources.ApplyResources(Me.lblDateJour, "lblDateJour")
        Me.lblDateJour.Name = "lblDateJour"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'BtnDate3
        '
        Me.BtnDate3.Image = Global.MozartNet.My.Resources.Resources.choix_calendrier
        resources.ApplyResources(Me.BtnDate3, "BtnDate3")
        Me.BtnDate3.Name = "BtnDate3"
        Me.BtnDate3.UseVisualStyleBackColor = True
        '
        'txtDtCreaAu
        '
        resources.ApplyResources(Me.txtDtCreaAu, "txtDtCreaAu")
        Me.txtDtCreaAu.Name = "txtDtCreaAu"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'MonthCalendar1
        '
        resources.ApplyResources(Me.MonthCalendar1, "MonthCalendar1")
        Me.MonthCalendar1.Name = "MonthCalendar1"
        '
        'BtnDate1
        '
        Me.BtnDate1.Image = Global.MozartNet.My.Resources.Resources.choix_calendrier
        resources.ApplyResources(Me.BtnDate1, "BtnDate1")
        Me.BtnDate1.Name = "BtnDate1"
        Me.BtnDate1.UseVisualStyleBackColor = True
        '
        'txtDtCreaDu
        '
        resources.ApplyResources(Me.txtDtCreaDu, "txtDtCreaDu")
        Me.txtDtCreaDu.Name = "txtDtCreaDu"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
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
        Me.GVStat.ColumnPanelRowHeight = 80
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NPERNUM, Me.GridColumn19, Me.Assistant, Me.VTYPEDETAILLIB, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn21, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn16, Me.GridColumn15, Me.GridColumn17, Me.GridColumn18, Me.GridColumn20, Me.SOM})
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsView.ShowAutoFilterRow = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'NPERNUM
        '
        resources.ApplyResources(Me.NPERNUM, "NPERNUM")
        Me.NPERNUM.FieldName = "NPERNUM"
        Me.NPERNUM.Name = "NPERNUM"
        '
        'GridColumn19
        '
        Me.GridColumn19.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn19.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn19, "GridColumn19")
        Me.GridColumn19.FieldName = "LIBGROUPE"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.ReadOnly = True
        Me.GridColumn19.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'Assistant
        '
        Me.Assistant.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Assistant.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Assistant, "Assistant")
        Me.Assistant.FieldName = "PERS"
        Me.Assistant.Name = "Assistant"
        '
        'VTYPEDETAILLIB
        '
        Me.VTYPEDETAILLIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VTYPEDETAILLIB.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VTYPEDETAILLIB, "VTYPEDETAILLIB")
        Me.VTYPEDETAILLIB.FieldName = "VTYPEDETAILLIB"
        Me.VTYPEDETAILLIB.Name = "VTYPEDETAILLIB"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn1.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.FieldName = "NBACTCRE"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn2.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn2, "GridColumn2")
        Me.GridColumn2.FieldName = "NBCDEFOUCREE"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn3.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn3, "GridColumn3")
        Me.GridColumn3.FieldName = "NBDEMANDESDEVIS"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn4.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn4, "GridColumn4")
        Me.GridColumn4.FieldName = "NBCONTRATSSTT"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn21
        '
        Me.GridColumn21.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn21.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn21, "GridColumn21")
        Me.GridColumn21.FieldName = "NBRECEPTATT"
        Me.GridColumn21.Name = "GridColumn21"
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn5.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn5, "GridColumn5")
        Me.GridColumn5.FieldName = "NBDEVISSIMPLESSSSTT"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn6.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn6, "GridColumn6")
        Me.GridColumn6.FieldName = "NBDEVISSIMPLESAVSTT"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn7.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn7, "GridColumn7")
        Me.GridColumn7.FieldName = "NBDEVISCOMPLEXESSSSTT"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn8.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn8, "GridColumn8")
        Me.GridColumn8.FieldName = "NBDEVISCOMPLEXESAVSTT"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn9.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn9, "GridColumn9")
        Me.GridColumn9.FieldName = "NBSORTIESSTOCK"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn10.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn10, "GridColumn10")
        Me.GridColumn10.FieldName = "NBINFOSITES"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn11.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn11, "GridColumn11")
        Me.GridColumn11.FieldName = "NBNVSTTBASE"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn12.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn12, "GridColumn12")
        Me.GridColumn12.FieldName = "NBPLANIFTECH"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn13.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn13, "GridColumn13")
        Me.GridColumn13.FieldName = "NBVALIDREALISATION"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn14.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn14, "GridColumn14")
        Me.GridColumn14.FieldName = "NBRETOURTABLET"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn16.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn16, "GridColumn16")
        Me.GridColumn16.FieldName = "NBOM"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn15.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn15, "GridColumn15")
        Me.GridColumn15.FieldName = "NBACTARR"
        Me.GridColumn15.Name = "GridColumn15"
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn17.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn17, "GridColumn17")
        Me.GridColumn17.FieldName = "NBFACCREE"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn18.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn18, "GridColumn18")
        Me.GridColumn18.FieldName = "NBCHIFFCREE"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn20
        '
        Me.GridColumn20.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn20.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn20, "GridColumn20")
        Me.GridColumn20.FieldName = "NBENQQUEL"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'SOM
        '
        Me.SOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.SOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.SOM, "SOM")
        Me.SOM.FieldName = "SOM"
        Me.SOM.Name = "SOM"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.ButtonExporter)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'ButtonExporter
        '
        resources.ApplyResources(Me.ButtonExporter, "ButtonExporter")
        Me.ButtonExporter.Name = "ButtonExporter"
        Me.ButtonExporter.UseVisualStyleBackColor = True
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChartControl1)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'ChartControl1
        '
        XyDiagram1.AxisX.Label.Angle = CType(resources.GetObject("resource.Angle"), Integer)
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
        Me.ChartControl1.Diagram = XyDiagram1
        resources.ApplyResources(Me.ChartControl1, "ChartControl1")
        Me.ChartControl1.Legend.EquallySpacedItems = False
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartControl1.Name = "ChartControl1"
        Series1.ArgumentDataMember = "PERS"
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel1.TextPattern = "{V:N0}"
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series1.ShowInLegend = False
        Series1.ValueDataMembersSerializable = "SOM"
        SideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        SideBySideBarSeriesView1.Transparency = CType(30, Byte)
        Series1.View = SideBySideBarSeriesView1
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Bar3DSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.SeriesTemplate.Label = Bar3DSeriesLabel1
        Me.ChartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.SeriesTemplate.View = SideBySideBar3DSeriesView1
        ChartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "VTYPEDETAILLIB"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.ValueMember = "ID"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'frmStatProductionAssistants
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtValider)
        Me.Controls.Add(Me.lblDateJour)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnDate3)
        Me.Controls.Add(Me.txtDtCreaAu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.BtnDate1)
        Me.Controls.Add(Me.txtDtCreaDu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "frmStatProductionAssistants"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBar3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtValider As System.Windows.Forms.Button
  Friend WithEvents lblDateJour As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents BtnDate3 As System.Windows.Forms.Button
  Friend WithEvents txtDtCreaAu As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
  Friend WithEvents BtnDate1 As System.Windows.Forms.Button
  Friend WithEvents txtDtCreaDu As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonExporter As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents Assistant As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents SOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Private WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VTYPEDETAILLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
End Class
