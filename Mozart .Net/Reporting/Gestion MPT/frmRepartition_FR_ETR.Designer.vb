<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepartition_FR_ETR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepartition_FR_ETR))
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim PieSeriesLabel2 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PieSeriesView2 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.GCStat = New DevExpress.XtraGrid.GridControl()
        Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.vclinom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nsitnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.vsitnom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PAYS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MntHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtValider = New System.Windows.Forms.Button()
        Me.BtnDate2 = New System.Windows.Forms.Button()
        Me.txtDtFin = New System.Windows.Forms.TextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.BtnDate1 = New System.Windows.Forms.Button()
        Me.txtDtDebut = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCHAFF = New System.Windows.Forms.ComboBox()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NCLINUM, Me.vclinom, Me.nsitnum, Me.vsitnom, Me.PAYS, Me.MntHT})
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsView.ShowAutoFilterRow = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'NCLINUM
        '
        resources.ApplyResources(Me.NCLINUM, "NCLINUM")
        Me.NCLINUM.FieldName = "NCLINUM"
        Me.NCLINUM.MinWidth = 10
        Me.NCLINUM.Name = "NCLINUM"
        '
        'vclinom
        '
        Me.vclinom.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.vclinom.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.vclinom, "vclinom")
        Me.vclinom.FieldName = "vclinom"
        Me.vclinom.Name = "vclinom"
        '
        'nsitnum
        '
        resources.ApplyResources(Me.nsitnum, "nsitnum")
        Me.nsitnum.FieldName = "nsitnum"
        Me.nsitnum.Name = "nsitnum"
        '
        'vsitnom
        '
        Me.vsitnom.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.vsitnom.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.vsitnom, "vsitnom")
        Me.vsitnom.FieldName = "vsitnom"
        Me.vsitnom.Name = "vsitnom"
        Me.vsitnom.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("vsitnom.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'PAYS
        '
        Me.PAYS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.PAYS.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.PAYS, "PAYS")
        Me.PAYS.FieldName = "PAYS"
        Me.PAYS.Name = "PAYS"
        '
        'MntHT
        '
        Me.MntHT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.MntHT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.MntHT, "MntHT")
        Me.MntHT.FieldName = "MntHT"
        Me.MntHT.Name = "MntHT"
        Me.MntHT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("MntHT.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'BtValider
        '
        resources.ApplyResources(Me.BtValider, "BtValider")
        Me.BtValider.Name = "BtValider"
        Me.BtValider.UseVisualStyleBackColor = True
        '
        'BtnDate2
        '
        Me.BtnDate2.Image = Global.MozartNet.My.Resources.Resources.choix_calendrier
        resources.ApplyResources(Me.BtnDate2, "BtnDate2")
        Me.BtnDate2.Name = "BtnDate2"
        Me.BtnDate2.UseVisualStyleBackColor = True
        '
        'txtDtFin
        '
        resources.ApplyResources(Me.txtDtFin, "txtDtFin")
        Me.txtDtFin.Name = "txtDtFin"
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
        'txtDtDebut
        '
        resources.ApplyResources(Me.txtDtDebut, "txtDtDebut")
        Me.txtDtDebut.Name = "txtDtDebut"
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
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.Button1)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
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
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'cboCHAFF
        '
        Me.cboCHAFF.DisplayMember = "NOM"
        Me.cboCHAFF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCHAFF.FormattingEnabled = True
        resources.ApplyResources(Me.cboCHAFF, "cboCHAFF")
        Me.cboCHAFF.Name = "cboCHAFF"
        Me.cboCHAFF.ValueMember = "npernum"
        '
        'ChartControl1
        '
        Me.ChartControl1.AppearanceNameSerializable = "Chameleon"
        resources.ApplyResources(Me.ChartControl1, "ChartControl1")
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.PaletteName = "Flow"
        Series1.ArgumentDataMember = "PAYS"
        resources.ApplyResources(PieSeriesLabel1, "PieSeriesLabel1")
        PieSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside
        PieSeriesLabel1.TextPattern = "{A} : {VP:P1}"
        Series1.Label = PieSeriesLabel1
        resources.ApplyResources(Series1, "Series1")
        Series1.ValueDataMembersSerializable = "MntHT"
        Series1.View = PieSeriesView1
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        PieSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.SeriesTemplate.Label = PieSeriesLabel2
        Me.ChartControl1.SeriesTemplate.View = PieSeriesView2
        resources.ApplyResources(ChartTitle1, "ChartTitle1")
        ChartTitle1.TextColor = System.Drawing.Color.Black
        Me.ChartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'frmRepartition_FR_ETR
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.ChartControl1)
        Me.Controls.Add(Me.cboCHAFF)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.BtValider)
        Me.Controls.Add(Me.BtnDate2)
        Me.Controls.Add(Me.txtDtFin)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.BtnDate1)
        Me.Controls.Add(Me.txtDtDebut)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "frmRepartition_FR_ETR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtValider As System.Windows.Forms.Button
    Friend WithEvents BtnDate2 As System.Windows.Forms.Button
    Friend WithEvents txtDtFin As System.Windows.Forms.TextBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents BtnDate1 As System.Windows.Forms.Button
    Friend WithEvents txtDtDebut As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboCHAFF As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Private WithEvents NCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents vclinom As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents nsitnum As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents vsitnom As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents PAYS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MntHT As DevExpress.XtraGrid.Columns.GridColumn
End Class
