<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevisNombreParCreateur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevisNombreParCreateur))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim ConstantLine1 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Bar3DSeriesLabel1 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel()
        Dim SideBySideBar3DSeriesView1 As DevExpress.XtraCharts.SideBySideBar3DSeriesView = New DevExpress.XtraCharts.SideBySideBar3DSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.GCStat = New DevExpress.XtraGrid.GridControl()
        Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PRENOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCHEF_GRP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DEVISSIMPLESST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DEVISSIMPLEAST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DEVISCOMPLEXESST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DEVISCOMPLEXEAST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtValider = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnCalendar2 = New System.Windows.Forms.Button()
        Me.txtDtCreaAu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCalendar1 = New System.Windows.Forms.Button()
        Me.txtDtCreaDu = New System.Windows.Forms.TextBox()
        Me.cboSociete = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDateAu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDateDu = New System.Windows.Forms.Label()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBar3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
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
        Me.GVStat.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVStat.ColumnPanelRowHeight = 80
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NPERNUM, Me.NOM, Me.PRENOM, Me.GColVCHEF_GRP, Me.DEVISSIMPLESST, Me.DEVISSIMPLEAST, Me.DEVISCOMPLEXESST, Me.DEVISCOMPLEXEAST, Me.SOM, Me.GridColumn2, Me.GridColumn1})
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
        Me.NPERNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NPERNUM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NPERNUM, "NPERNUM")
        Me.NPERNUM.FieldName = "NPERNUM"
        Me.NPERNUM.Name = "NPERNUM"
        '
        'NOM
        '
        Me.NOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NOM, "NOM")
        Me.NOM.FieldName = "VPERNOM"
        Me.NOM.Name = "NOM"
        '
        'PRENOM
        '
        Me.PRENOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.PRENOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.PRENOM, "PRENOM")
        Me.PRENOM.FieldName = "VPERPRE"
        Me.PRENOM.Name = "PRENOM"
        '
        'GColVCHEF_GRP
        '
        Me.GColVCHEF_GRP.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVCHEF_GRP.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVCHEF_GRP, "GColVCHEF_GRP")
        Me.GColVCHEF_GRP.FieldName = "VCHEF_GRP"
        Me.GColVCHEF_GRP.Name = "GColVCHEF_GRP"
        '
        'DEVISSIMPLESST
        '
        Me.DEVISSIMPLESST.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DEVISSIMPLESST.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DEVISSIMPLESST, "DEVISSIMPLESST")
        Me.DEVISSIMPLESST.FieldName = "NBDEVISSIMPLESSSSTT"
        Me.DEVISSIMPLESST.Name = "DEVISSIMPLESST"
        '
        'DEVISSIMPLEAST
        '
        Me.DEVISSIMPLEAST.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DEVISSIMPLEAST.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DEVISSIMPLEAST, "DEVISSIMPLEAST")
        Me.DEVISSIMPLEAST.FieldName = "NBDEVISSIMPLESAVSTT"
        Me.DEVISSIMPLEAST.Name = "DEVISSIMPLEAST"
        '
        'DEVISCOMPLEXESST
        '
        Me.DEVISCOMPLEXESST.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DEVISCOMPLEXESST.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DEVISCOMPLEXESST, "DEVISCOMPLEXESST")
        Me.DEVISCOMPLEXESST.FieldName = "NBDEVISCOMPLEXESSSSTT"
        Me.DEVISCOMPLEXESST.Name = "DEVISCOMPLEXESST"
        '
        'DEVISCOMPLEXEAST
        '
        Me.DEVISCOMPLEXEAST.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DEVISCOMPLEXEAST.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DEVISCOMPLEXEAST, "DEVISCOMPLEXEAST")
        Me.DEVISCOMPLEXEAST.FieldName = "NBDEVISCOMPLEXESAVSTT"
        Me.DEVISCOMPLEXEAST.Name = "DEVISCOMPLEXEAST"
        '
        'SOM
        '
        Me.SOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.SOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.SOM, "SOM")
        Me.SOM.FieldName = "NB_DCL_CREE"
        Me.SOM.Name = "SOM"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn2.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn2, "GridColumn2")
        Me.GridColumn2.FieldName = "NB_DCL_VALID"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn1.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.DisplayFormat.FormatString = "p2"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn1.FieldName = "TX_RETOUR"
        Me.GridColumn1.Name = "GridColumn1"
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
        XyDiagram1.AxisX.Label.DXFont = CType(resources.GetObject("resource.DXFont"), DevExpress.Drawing.DXFont)
        XyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowHide = CType(resources.GetObject("resource.AllowHide"), Boolean)
        XyDiagram1.AxisX.Reverse = True
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Alignment = CType(resources.GetObject("resource.Alignment"), DevExpress.XtraCharts.AxisAlignment)
        ConstantLine1.AxisValueSerializable = "1"
        ConstantLine1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        ConstantLine1.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Solid
        ConstantLine1.LineStyle.Thickness = 2
        ConstantLine1.Name = "Objectif"
        ConstantLine1.Title.DXFont = CType(resources.GetObject("resource.DXFont1"), DevExpress.Drawing.DXFont)
        ConstantLine1.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        ConstantLine1.Title.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        ConstantLine1.Visible = False
        XyDiagram1.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine1})
        XyDiagram1.AxisY.Title.Text = resources.GetString("resource.Text")
        XyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.Rotated = True
        Me.ChartControl1.Diagram = XyDiagram1
        resources.ApplyResources(Me.ChartControl1, "ChartControl1")
        Me.ChartControl1.Legend.EquallySpacedItems = False
        Me.ChartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartControl1.Name = "ChartControl1"
        Series1.ArgumentDataMember = "VPERNOMPRE"
        resources.ApplyResources(SideBySideBarSeriesLabel1, "SideBySideBarSeriesLabel1")
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel1.TextPattern = "{V:N0}"
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series1.ShowInLegend = False
        Series1.ValueDataMembersSerializable = "NB_DCL_CREE"
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
        'MonthCalendar1
        '
        resources.ApplyResources(Me.MonthCalendar1, "MonthCalendar1")
        Me.MonthCalendar1.Name = "MonthCalendar1"
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
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
        'BtValider
        '
        resources.ApplyResources(Me.BtValider, "BtValider")
        Me.BtValider.Name = "BtValider"
        Me.BtValider.UseVisualStyleBackColor = True
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'BtnCalendar2
        '
        Me.BtnCalendar2.Image = Global.MozartNet.My.Resources.Resources.choix_calendrier
        resources.ApplyResources(Me.BtnCalendar2, "BtnCalendar2")
        Me.BtnCalendar2.Name = "BtnCalendar2"
        Me.BtnCalendar2.UseVisualStyleBackColor = True
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
        'BtnCalendar1
        '
        Me.BtnCalendar1.Image = Global.MozartNet.My.Resources.Resources.choix_calendrier
        resources.ApplyResources(Me.BtnCalendar1, "BtnCalendar1")
        Me.BtnCalendar1.Name = "BtnCalendar1"
        Me.BtnCalendar1.UseVisualStyleBackColor = True
        '
        'txtDtCreaDu
        '
        resources.ApplyResources(Me.txtDtCreaDu, "txtDtCreaDu")
        Me.txtDtCreaDu.Name = "txtDtCreaDu"
        '
        'cboSociete
        '
        Me.cboSociete.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cboSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboSociete, "cboSociete")
        Me.cboSociete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboSociete.FormattingEnabled = True
        Me.cboSociete.Name = "cboSociete"
        Me.cboSociete.Tag = "559"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'lblDateAu
        '
        resources.ApplyResources(Me.lblDateAu, "lblDateAu")
        Me.lblDateAu.Name = "lblDateAu"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'lblDateDu
        '
        resources.ApplyResources(Me.lblDateDu, "lblDateDu")
        Me.lblDateDu.Name = "lblDateDu"
        '
        'frmDevisNombreParCreateur
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.lblDateDu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDateAu)
        Me.Controls.Add(Me.cboSociete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.BtValider)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnCalendar2)
        Me.Controls.Add(Me.txtDtCreaAu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnCalendar1)
        Me.Controls.Add(Me.txtDtCreaDu)
        Me.Name = "frmDevisNombreParCreateur"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBar3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
  Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents NPERNUM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents NOM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents PRENOM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents DEVISSIMPLESST As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents DEVISSIMPLEAST As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents DEVISCOMPLEXESST As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents DEVISCOMPLEXEAST As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents SOM As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Private WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
  Friend WithEvents LblTitre As System.Windows.Forms.Label
  Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents BtValider As System.Windows.Forms.Button
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents BtnCalendar2 As System.Windows.Forms.Button
  Friend WithEvents txtDtCreaAu As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
  Friend WithEvents BtnCalendar1 As System.Windows.Forms.Button
  Friend WithEvents txtDtCreaDu As System.Windows.Forms.TextBox
  Friend WithEvents cboSociete As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lblDateAu As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lblDateDu As System.Windows.Forms.Label
    Friend WithEvents GColVCHEF_GRP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
