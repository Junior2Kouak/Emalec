<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportingFacturation
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportingFacturation))
    Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim PieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
    Dim PieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
    Dim PieSeriesLabel2 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
    Dim PieSeriesView2 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
    Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
    Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
    Me.GCStat = New DevExpress.XtraGrid.GridControl()
    Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.VPRELIB = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.MntHT = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColNPRTHT = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.BtnPrint = New System.Windows.Forms.Button()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.lblPerim = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cboClient = New System.Windows.Forms.ComboBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.ComboSociete = New System.Windows.Forms.ComboBox()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChartControl1
        '
        resources.ApplyResources(Me.ChartControl1, "ChartControl1")
        Me.ChartControl1.AppearanceNameSerializable = "Chameleon"
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.PaletteName = "Mixed"
        Series1.ArgumentDataMember = "VPRELIB"
        PieSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
        PieSeriesLabel1.Shadow.Color = System.Drawing.Color.DimGray
        PieSeriesLabel1.TextPattern = "{A} : {VP:P1}"
        Series1.Label = PieSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series1.ValueDataMembersSerializable = "MntHT"
        Series1.View = PieSeriesView1
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        PieSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.SeriesTemplate.Label = PieSeriesLabel2
        Me.ChartControl1.SeriesTemplate.View = PieSeriesView2
        Me.ChartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'GCStat
        '
        resources.ApplyResources(Me.GCStat, "GCStat")
        Me.GCStat.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCStat.EmbeddedNavigator.AccessibleDescription")
        Me.GCStat.EmbeddedNavigator.AccessibleName = resources.GetString("GCStat.EmbeddedNavigator.AccessibleName")
        Me.GCStat.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCStat.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCStat.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCStat.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCStat.EmbeddedNavigator.AutoSize = CType(resources.GetObject("GCStat.EmbeddedNavigator.AutoSize"), Boolean)
        Me.GCStat.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCStat.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCStat.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCStat.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCStat.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCStat.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCStat.EmbeddedNavigator.Margin = CType(resources.GetObject("GCStat.EmbeddedNavigator.Margin"), System.Windows.Forms.Padding)
        Me.GCStat.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCStat.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCStat.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCStat.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCStat.EmbeddedNavigator.ToolTip = resources.GetString("GCStat.EmbeddedNavigator.ToolTip")
        Me.GCStat.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCStat.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCStat.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCStat.EmbeddedNavigator.ToolTipTitle")
        Me.GCStat.MainView = Me.GVStat
        Me.GCStat.Name = "GCStat"
        Me.GCStat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStat})
        '
        'GVStat
        '
        resources.ApplyResources(Me.GVStat, "GVStat")
        Me.GVStat.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVStat.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVStat.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVStat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.VPRELIB, Me.MntHT, Me.ColNPRTHT})
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsView.ShowAutoFilterRow = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'VPRELIB
        '
        resources.ApplyResources(Me.VPRELIB, "VPRELIB")
        Me.VPRELIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VPRELIB.AppearanceHeader.Options.UseForeColor = True
        Me.VPRELIB.FieldName = "VPRELIB"
        Me.VPRELIB.Name = "VPRELIB"
        Me.VPRELIB.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem()})
        '
        'MntHT
        '
        resources.ApplyResources(Me.MntHT, "MntHT")
        Me.MntHT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.MntHT.AppearanceHeader.Options.UseForeColor = True
        Me.MntHT.DisplayFormat.FormatString = "{0:c0}"
        Me.MntHT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MntHT.FieldName = "MNTHT"
        Me.MntHT.Name = "MntHT"
        Me.MntHT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("MntHT.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("MntHT.Summary1"), resources.GetString("MntHT.Summary2"))})
        '
        'ColNPRTHT
        '
        resources.ApplyResources(Me.ColNPRTHT, "ColNPRTHT")
        Me.ColNPRTHT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColNPRTHT.AppearanceHeader.Options.UseForeColor = True
        Me.ColNPRTHT.DisplayFormat.FormatString = "{0:p2}"
        Me.ColNPRTHT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColNPRTHT.FieldName = "NPRTHT"
        Me.ColNPRTHT.Name = "ColNPRTHT"
        '
        'BtValider
        '
        resources.ApplyResources(Me.BtValider, "BtValider")
        Me.BtValider.Name = "BtValider"
        Me.BtValider.UseVisualStyleBackColor = True
        '
        'BtnDate2
        '
        resources.ApplyResources(Me.BtnDate2, "BtnDate2")
        Me.BtnDate2.Image = Global.MozartNet.My.Resources.Resources.choix_calendrier
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
        resources.ApplyResources(Me.BtnDate1, "BtnDate1")
        Me.BtnDate1.Image = Global.MozartNet.My.Resources.Resources.choix_calendrier
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
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
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
        'cboClient
        '
        resources.ApplyResources(Me.cboClient, "cboClient")
        Me.cboClient.DisplayMember = "VCLINOM"
        Me.cboClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClient.FormattingEnabled = True
        Me.cboClient.Name = "cboClient"
        Me.cboClient.ValueMember = "NCLINUM"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'ComboSociete
        '
        resources.ApplyResources(Me.ComboSociete, "ComboSociete")
        Me.ComboSociete.DisplayMember = "VCLINOM"
        Me.ComboSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSociete.FormattingEnabled = True
        Me.ComboSociete.Name = "ComboSociete"
        Me.ComboSociete.Tag = "485"
        Me.ComboSociete.ValueMember = "NCLINUM"
        '
        'frmReportingFacturation
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboSociete)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboClient)
        Me.Controls.Add(Me.lblPerim)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ChartControl1)
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
        Me.Name = "frmReportingFacturation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
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
    Friend WithEvents lblPerim As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboClient As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents VPRELIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MntHT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNPRTHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboSociete As ComboBox
End Class
