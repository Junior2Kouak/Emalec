<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransRetourDevis
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransRetourDevis))
    Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
    Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
    Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
    Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
    Me.ComboBox1 = New System.Windows.Forms.ComboBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.lblNomClient = New System.Windows.Forms.Label()
    Me.BtValider = New System.Windows.Forms.Button()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.BtnDate4 = New System.Windows.Forms.Button()
    Me.txtDtExecAu = New System.Windows.Forms.TextBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.BtnDate3 = New System.Windows.Forms.Button()
    Me.txtDtCreaAu = New System.Windows.Forms.TextBox()
    Me.BtnDate2 = New System.Windows.Forms.Button()
    Me.txtDtExecDu = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.ButtonExporter = New System.Windows.Forms.Button()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.BtnDate1 = New System.Windows.Forms.Button()
    Me.txtDtCreaDu = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.ChartCtrlStatRetourDevis = New DevExpress.XtraCharts.ChartControl()
    Me.PnlChart = New System.Windows.Forms.Panel()
    Me.BtnClose = New System.Windows.Forms.Button()
    Me.GCStat = New DevExpress.XtraGrid.GridControl()
    Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.VCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ChefGroupe = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.chaff = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.CompteAnalytique = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.NBDevisCrees = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.MTDevisCrees = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.NBDevisExec = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.MTDevisExec = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.TxRetourNbDevis = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.TxRetourMontantDevis = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.TauxTransf = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.NbDevisRefuses = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.HeuresTravail = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.CoutDevisRefuses = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.NCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.NPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GrpActions.SuspendLayout()
        CType(Me.ChartCtrlStatRetourDevis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlChart.SuspendLayout()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "chaff"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.ValueMember = "npernum"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'lblNomClient
        '
        resources.ApplyResources(Me.lblNomClient, "lblNomClient")
        Me.lblNomClient.Name = "lblNomClient"
        '
        'BtValider
        '
        resources.ApplyResources(Me.BtValider, "BtValider")
        Me.BtValider.Name = "BtValider"
        Me.BtValider.UseVisualStyleBackColor = True
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'BtnDate4
        '
        Me.BtnDate4.Image = Global.MozartNet.My.Resources.Resources.choix_calendrier
        resources.ApplyResources(Me.BtnDate4, "BtnDate4")
        Me.BtnDate4.Name = "BtnDate4"
        Me.BtnDate4.UseVisualStyleBackColor = True
        '
        'txtDtExecAu
        '
        resources.ApplyResources(Me.txtDtExecAu, "txtDtExecAu")
        Me.txtDtExecAu.Name = "txtDtExecAu"
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
        'BtnDate2
        '
        Me.BtnDate2.Image = Global.MozartNet.My.Resources.Resources.choix_calendrier
        resources.ApplyResources(Me.BtnDate2, "BtnDate2")
        Me.BtnDate2.Name = "BtnDate2"
        Me.BtnDate2.UseVisualStyleBackColor = True
        '
        'txtDtExecDu
        '
        resources.ApplyResources(Me.txtDtExecDu, "txtDtExecDu")
        Me.txtDtExecDu.Name = "txtDtExecDu"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
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
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
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
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.ButtonExporter)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'ChartCtrlStatRetourDevis
        '
        XyDiagram1.AxisX.AutoScaleBreaks.MaxCount = 24
        XyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
        XyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
        XyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
        XyDiagram1.AxisX.Label.TextPattern = "{A:MMM yyyy}"
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.MinorCount = 1
        XyDiagram1.AxisY.NumericScaleOptions.AutoGrid = False
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartCtrlStatRetourDevis.Diagram = XyDiagram1
        Me.ChartCtrlStatRetourDevis.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        resources.ApplyResources(Me.ChartCtrlStatRetourDevis, "ChartCtrlStatRetourDevis")
        Me.ChartCtrlStatRetourDevis.Name = "ChartCtrlStatRetourDevis"
        Series1.ArgumentDataMember = "yymm"
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        resources.ApplyResources(Series1, "Series1")
        Series1.ValueDataMembersSerializable = "NBDevisCrees"
        SideBySideBarSeriesView1.Color = System.Drawing.Color.DodgerBlue
        Series1.View = SideBySideBarSeriesView1
        Series2.ArgumentDataMember = "yymm"
        Series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        resources.ApplyResources(Series2, "Series2")
        Series2.ValueDataMembersSerializable = "NBDevisExec"
        SideBySideBarSeriesView2.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(77, Byte), Integer))
        Series2.View = SideBySideBarSeriesView2
        Series3.ArgumentDataMember = "yymm"
        Series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series3.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
        Series3.ShowInLegend = False
        Series3.ValueDataMembersSerializable = "NBDevisExec"
        LineSeriesView1.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(77, Byte), Integer))
        LineSeriesView1.LineStyle.LineJoin = System.Drawing.Drawing2D.LineJoin.MiterClipped
        Series3.View = LineSeriesView1
        Me.ChartCtrlStatRetourDevis.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2, Series3}
        '
        'PnlChart
        '
        Me.PnlChart.Controls.Add(Me.BtnClose)
        Me.PnlChart.Controls.Add(Me.ChartCtrlStatRetourDevis)
        resources.ApplyResources(Me.PnlChart, "PnlChart")
        Me.PnlChart.Name = "PnlChart"
        '
        'BtnClose
        '
        resources.ApplyResources(Me.BtnClose, "BtnClose")
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'GCStat
        '
        resources.ApplyResources(Me.GCStat, "GCStat")
        Me.GCStat.MainView = Me.GVStat
        Me.GCStat.Name = "GCStat"
        Me.GCStat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStat, Me.GridView1})
        '
        'GVStat
        '
        Me.GVStat.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVStat.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVStat.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVStat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.VCLINOM, Me.ChefGroupe, Me.chaff, Me.CompteAnalytique, Me.NBDevisCrees, Me.MTDevisCrees, Me.NBDevisExec, Me.MTDevisExec, Me.TxRetourNbDevis, Me.TxRetourMontantDevis, Me.TauxTransf, Me.NbDevisRefuses, Me.HeuresTravail, Me.CoutDevisRefuses, Me.NCLINUM, Me.NPERNUM})
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsView.AllowHtmlDrawHeaders = True
        Me.GVStat.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'VCLINOM
        '
        Me.VCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VCLINOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VCLINOM, "VCLINOM")
        Me.VCLINOM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VCLINOM.FieldName = "VCLINOM"
        Me.VCLINOM.Name = "VCLINOM"
        Me.VCLINOM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("VCLINOM.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("VCLINOM.Summary1"), resources.GetString("VCLINOM.Summary2"))})
        '
        'ChefGroupe
        '
        Me.ChefGroupe.AppearanceCell.Options.UseTextOptions = True
        Me.ChefGroupe.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ChefGroupe.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ChefGroupe.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.ChefGroupe, "ChefGroupe")
        Me.ChefGroupe.FieldName = "chefgroupe"
        Me.ChefGroupe.Name = "ChefGroupe"
        '
        'chaff
        '
        Me.chaff.AppearanceCell.Options.UseTextOptions = True
        Me.chaff.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.chaff.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.chaff.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.chaff, "chaff")
        Me.chaff.FieldName = "chaff"
        Me.chaff.Name = "chaff"
        '
        'CompteAnalytique
        '
        Me.CompteAnalytique.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.CompteAnalytique.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.CompteAnalytique, "CompteAnalytique")
        Me.CompteAnalytique.FieldName = "libcptana"
        Me.CompteAnalytique.Name = "CompteAnalytique"
        '
        'NBDevisCrees
        '
        Me.NBDevisCrees.AppearanceCell.Options.UseTextOptions = True
        Me.NBDevisCrees.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NBDevisCrees.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NBDevisCrees.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NBDevisCrees, "NBDevisCrees")
        Me.NBDevisCrees.DisplayFormat.FormatString = "F0"
        Me.NBDevisCrees.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NBDevisCrees.FieldName = "NBDevisCrees"
        Me.NBDevisCrees.Name = "NBDevisCrees"
        Me.NBDevisCrees.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("NBDevisCrees.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("NBDevisCrees.Summary1"), resources.GetString("NBDevisCrees.Summary2"))})
        '
        'MTDevisCrees
        '
        Me.MTDevisCrees.AppearanceCell.Options.UseTextOptions = True
        Me.MTDevisCrees.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MTDevisCrees.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.MTDevisCrees.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.MTDevisCrees, "MTDevisCrees")
        Me.MTDevisCrees.DisplayFormat.FormatString = "{0:n0} €"
        Me.MTDevisCrees.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MTDevisCrees.FieldName = "MTDevisCrees"
        Me.MTDevisCrees.Name = "MTDevisCrees"
        Me.MTDevisCrees.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("MTDevisCrees.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("MTDevisCrees.Summary1"), resources.GetString("MTDevisCrees.Summary2"))})
        '
        'NBDevisExec
        '
        Me.NBDevisExec.AppearanceCell.Options.UseTextOptions = True
        Me.NBDevisExec.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NBDevisExec.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NBDevisExec.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NBDevisExec, "NBDevisExec")
        Me.NBDevisExec.DisplayFormat.FormatString = "F0"
        Me.NBDevisExec.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NBDevisExec.FieldName = "NBDevisExec"
        Me.NBDevisExec.Name = "NBDevisExec"
        Me.NBDevisExec.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("NBDevisExec.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("NBDevisExec.Summary1"), resources.GetString("NBDevisExec.Summary2"))})
        '
        'MTDevisExec
        '
        Me.MTDevisExec.AppearanceCell.Options.UseTextOptions = True
        Me.MTDevisExec.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MTDevisExec.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.MTDevisExec.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.MTDevisExec, "MTDevisExec")
        Me.MTDevisExec.DisplayFormat.FormatString = "{0:n0} €"
        Me.MTDevisExec.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MTDevisExec.FieldName = "MTDevisExec"
        Me.MTDevisExec.Name = "MTDevisExec"
        Me.MTDevisExec.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("MTDevisExec.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("MTDevisExec.Summary1"), resources.GetString("MTDevisExec.Summary2"))})
        '
        'TxRetourNbDevis
        '
        Me.TxRetourNbDevis.AppearanceCell.Options.UseTextOptions = True
        Me.TxRetourNbDevis.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.TxRetourNbDevis, "TxRetourNbDevis")
        Me.TxRetourNbDevis.DisplayFormat.FormatString = "{0} %"
        Me.TxRetourNbDevis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxRetourNbDevis.FieldName = "NbTxRetourDevis"
        Me.TxRetourNbDevis.Name = "TxRetourNbDevis"
        '
        'TxRetourMontantDevis
        '
        Me.TxRetourMontantDevis.AppearanceCell.Options.UseTextOptions = True
        Me.TxRetourMontantDevis.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TxRetourMontantDevis.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TxRetourMontantDevis.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.TxRetourMontantDevis, "TxRetourMontantDevis")
        Me.TxRetourMontantDevis.DisplayFormat.FormatString = "{0} %"
        Me.TxRetourMontantDevis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxRetourMontantDevis.FieldName = "MTTxRetourDevis"
        Me.TxRetourMontantDevis.Name = "TxRetourMontantDevis"
        '
        'TauxTransf
        '
        Me.TauxTransf.AppearanceCell.Options.UseTextOptions = True
        Me.TauxTransf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TauxTransf.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TauxTransf.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.TauxTransf, "TauxTransf")
        Me.TauxTransf.DisplayFormat.FormatString = "{0} %"
        Me.TauxTransf.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TauxTransf.FieldName = "TauxTransf"
        Me.TauxTransf.Name = "TauxTransf"
        '
        'NbDevisRefuses
        '
        Me.NbDevisRefuses.AppearanceCell.Options.UseTextOptions = True
        Me.NbDevisRefuses.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NbDevisRefuses.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NbDevisRefuses.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NbDevisRefuses, "NbDevisRefuses")
        Me.NbDevisRefuses.DisplayFormat.FormatString = "F0"
        Me.NbDevisRefuses.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NbDevisRefuses.FieldName = "NbDevisRefuses"
        Me.NbDevisRefuses.Name = "NbDevisRefuses"
        Me.NbDevisRefuses.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("NbDevisRefuses.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("NbDevisRefuses.Summary1"), resources.GetString("NbDevisRefuses.Summary2"))})
        '
        'HeuresTravail
        '
        Me.HeuresTravail.AppearanceCell.Options.UseTextOptions = True
        Me.HeuresTravail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.HeuresTravail.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.HeuresTravail.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.HeuresTravail, "HeuresTravail")
        Me.HeuresTravail.DisplayFormat.FormatString = "F0"
        Me.HeuresTravail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.HeuresTravail.FieldName = "HeuresDevisRefuses"
        Me.HeuresTravail.Name = "HeuresTravail"
        Me.HeuresTravail.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("HeuresTravail.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("HeuresTravail.Summary1"), resources.GetString("HeuresTravail.Summary2"))})
        '
        'CoutDevisRefuses
        '
        Me.CoutDevisRefuses.AppearanceCell.Options.UseTextOptions = True
        Me.CoutDevisRefuses.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CoutDevisRefuses.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.CoutDevisRefuses.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.CoutDevisRefuses, "CoutDevisRefuses")
        Me.CoutDevisRefuses.DisplayFormat.FormatString = "{0:n0} €"
        Me.CoutDevisRefuses.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CoutDevisRefuses.FieldName = "CoutDevisRefuses"
        Me.CoutDevisRefuses.Name = "CoutDevisRefuses"
        Me.CoutDevisRefuses.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("CoutDevisRefuses.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("CoutDevisRefuses.Summary1"), resources.GetString("CoutDevisRefuses.Summary2"))})
        '
        'NCLINUM
        '
        Me.NCLINUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NCLINUM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NCLINUM, "NCLINUM")
        Me.NCLINUM.FieldName = "nclinum"
        Me.NCLINUM.Name = "NCLINUM"
        '
        'NPERNUM
        '
        Me.NPERNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NPERNUM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NPERNUM, "NPERNUM")
        Me.NPERNUM.FieldName = "npernumchaff"
        Me.NPERNUM.Name = "NPERNUM"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GCStat
        Me.GridView1.Name = "GridView1"
        '
        'frmTransRetourDevis
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblNomClient)
        Me.Controls.Add(Me.BtValider)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnDate4)
        Me.Controls.Add(Me.txtDtExecAu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnDate3)
        Me.Controls.Add(Me.txtDtCreaAu)
        Me.Controls.Add(Me.BtnDate2)
        Me.Controls.Add(Me.txtDtExecDu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.BtnDate1)
        Me.Controls.Add(Me.txtDtCreaDu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PnlChart)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmTransRetourDevis"
        Me.GrpActions.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartCtrlStatRetourDevis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlChart.ResumeLayout(False)
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblNomClient As System.Windows.Forms.Label
    Friend WithEvents BtValider As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnDate4 As System.Windows.Forms.Button
    Friend WithEvents txtDtExecAu As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnDate3 As System.Windows.Forms.Button
    Friend WithEvents txtDtCreaAu As System.Windows.Forms.TextBox
    Friend WithEvents BtnDate2 As System.Windows.Forms.Button
    Friend WithEvents txtDtExecDu As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents ButtonExporter As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnDate1 As System.Windows.Forms.Button
    Friend WithEvents txtDtCreaDu As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents ChartCtrlStatRetourDevis As DevExpress.XtraCharts.ChartControl
    Friend WithEvents PnlChart As System.Windows.Forms.Panel
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents VCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChefGroupe As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents chaff As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompteAnalytique As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NBDevisCrees As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MTDevisCrees As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NBDevisExec As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MTDevisExec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxRetourNbDevis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxRetourMontantDevis As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TauxTransf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NbDevisRefuses As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CoutDevisRefuses As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents HeuresTravail As DevExpress.XtraGrid.Columns.GridColumn
End Class
