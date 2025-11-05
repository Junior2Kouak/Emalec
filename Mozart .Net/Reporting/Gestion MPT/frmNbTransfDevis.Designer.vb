<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNbTransfDevis
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNbTransfDevis))
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.ButtonExporter = New System.Windows.Forms.Button()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.GCStat = New DevExpress.XtraGrid.GridControl()
    Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.VCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.chaff = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.NBDevisCrees = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.MTDevisCrees = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.NBDevisExec = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.MTDevisExec = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.TauxTransf = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
    Me.BtnDate1 = New System.Windows.Forms.Button()
    Me.txtDtCreaDu = New System.Windows.Forms.TextBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.BtnDate2 = New System.Windows.Forms.Button()
    Me.txtDtExecDu = New System.Windows.Forms.TextBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.BtnDate3 = New System.Windows.Forms.Button()
    Me.txtDtCreaAu = New System.Windows.Forms.TextBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.BtnDate4 = New System.Windows.Forms.Button()
    Me.txtDtExecAu = New System.Windows.Forms.TextBox()
    Me.BtValider = New System.Windows.Forms.Button()
    Me.lblDateJour = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.VCLINOM, Me.chaff, Me.NBDevisCrees, Me.MTDevisCrees, Me.NBDevisExec, Me.MTDevisExec, Me.TauxTransf})
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'VCLINOM
        '
        Me.VCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VCLINOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VCLINOM, "VCLINOM")
        Me.VCLINOM.FieldName = "VCLINOM"
        Me.VCLINOM.Name = "VCLINOM"
        Me.VCLINOM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("VCLINOM.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'chaff
        '
        Me.chaff.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.chaff.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.chaff, "chaff")
        Me.chaff.FieldName = "chaff"
        Me.chaff.Name = "chaff"
        '
        'NBDevisCrees
        '
        Me.NBDevisCrees.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NBDevisCrees.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NBDevisCrees, "NBDevisCrees")
        Me.NBDevisCrees.DisplayFormat.FormatString = "F0"
        Me.NBDevisCrees.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NBDevisCrees.FieldName = "NBDevisCrees"
        Me.NBDevisCrees.Name = "NBDevisCrees"
        Me.NBDevisCrees.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("NBDevisCrees.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'MTDevisCrees
        '
        Me.MTDevisCrees.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.MTDevisCrees.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.MTDevisCrees, "MTDevisCrees")
        Me.MTDevisCrees.DisplayFormat.FormatString = "{0:n0}"
        Me.MTDevisCrees.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MTDevisCrees.FieldName = "MTDevisCrees"
        Me.MTDevisCrees.Name = "MTDevisCrees"
        Me.MTDevisCrees.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("MTDevisCrees.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'NBDevisExec
        '
        Me.NBDevisExec.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NBDevisExec.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NBDevisExec, "NBDevisExec")
        Me.NBDevisExec.DisplayFormat.FormatString = "F0"
        Me.NBDevisExec.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NBDevisExec.FieldName = "NBDevisExec"
        Me.NBDevisExec.Name = "NBDevisExec"
        Me.NBDevisExec.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("NBDevisExec.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'MTDevisExec
        '
        Me.MTDevisExec.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.MTDevisExec.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.MTDevisExec, "MTDevisExec")
        Me.MTDevisExec.DisplayFormat.FormatString = "{0:n0}"
        Me.MTDevisExec.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MTDevisExec.FieldName = "MTDevisExec"
        Me.MTDevisExec.Name = "MTDevisExec"
        Me.MTDevisExec.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("MTDevisExec.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'TauxTransf
        '
        Me.TauxTransf.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TauxTransf.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.TauxTransf, "TauxTransf")
        Me.TauxTransf.FieldName = "TauxTransf"
        Me.TauxTransf.Name = "TauxTransf"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
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
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
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
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
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
        'frmNbTransfDevis
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblDateJour)
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
        Me.Controls.Add(Me.BtnDate1)
        Me.Controls.Add(Me.txtDtCreaDu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "frmNbTransfDevis"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents BtnDate1 As System.Windows.Forms.Button
    Friend WithEvents txtDtCreaDu As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnDate2 As System.Windows.Forms.Button
    Friend WithEvents txtDtExecDu As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnDate3 As System.Windows.Forms.Button
    Friend WithEvents txtDtCreaAu As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnDate4 As System.Windows.Forms.Button
    Friend WithEvents txtDtExecAu As System.Windows.Forms.TextBox
    Friend WithEvents BtValider As System.Windows.Forms.Button
    Friend WithEvents ButtonExporter As System.Windows.Forms.Button
    Friend WithEvents lblDateJour As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents VCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NBDevisCrees As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MTDevisCrees As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NBDevisExec As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MTDevisExec As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents chaff As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TauxTransf As DevExpress.XtraGrid.Columns.GridColumn
End Class
