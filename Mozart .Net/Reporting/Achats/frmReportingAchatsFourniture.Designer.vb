<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportingAchatsFourniture
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportingAchatsFourniture))
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
    Me.vfoumat = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.vfouser = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.qte = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.mnt = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.pourc = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.ButtonExporter = New System.Windows.Forms.Button()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.BtValider = New System.Windows.Forms.Button()
    Me.lblGroupeEMALEC = New System.Windows.Forms.Label()
    Me.ComboBox1 = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GVStat.ColumnPanelRowHeight = 40
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.vfoumat, Me.vfouser, Me.qte, Me.mnt, Me.pourc})
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsView.ShowAutoFilterRow = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'vfoumat
        '
        Me.vfoumat.AppearanceCell.Font = CType(resources.GetObject("vfoumat.AppearanceCell.Font"), System.Drawing.Font)
        Me.vfoumat.AppearanceCell.Options.UseFont = True
        Me.vfoumat.AppearanceHeader.Font = CType(resources.GetObject("vfoumat.AppearanceHeader.Font"), System.Drawing.Font)
        Me.vfoumat.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.vfoumat.AppearanceHeader.Options.UseFont = True
        Me.vfoumat.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.vfoumat, "vfoumat")
        Me.vfoumat.FieldName = "vfoumat"
        Me.vfoumat.Name = "vfoumat"
        Me.vfoumat.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'vfouser
        '
        Me.vfouser.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.vfouser.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.vfouser, "vfouser")
        Me.vfouser.FieldName = "vfouser"
        Me.vfouser.Name = "vfouser"
        '
        'qte
        '
        Me.qte.AppearanceCell.Font = CType(resources.GetObject("qte.AppearanceCell.Font"), System.Drawing.Font)
        Me.qte.AppearanceCell.Options.UseFont = True
        Me.qte.AppearanceHeader.Font = CType(resources.GetObject("qte.AppearanceHeader.Font"), System.Drawing.Font)
        Me.qte.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.qte.AppearanceHeader.Options.UseFont = True
        Me.qte.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.qte, "qte")
        Me.qte.FieldName = "qte"
        Me.qte.Name = "qte"
        '
        'mnt
        '
        Me.mnt.AppearanceCell.Font = CType(resources.GetObject("mnt.AppearanceCell.Font"), System.Drawing.Font)
        Me.mnt.AppearanceCell.Options.UseFont = True
        Me.mnt.AppearanceHeader.Font = CType(resources.GetObject("mnt.AppearanceHeader.Font"), System.Drawing.Font)
        Me.mnt.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.mnt.AppearanceHeader.Options.UseFont = True
        Me.mnt.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.mnt, "mnt")
        Me.mnt.DisplayFormat.FormatString = "{0:n0}"
        Me.mnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.mnt.FieldName = "mnt"
        Me.mnt.Name = "mnt"
        Me.mnt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("mnt.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("mnt.Summary1"), resources.GetString("mnt.Summary2"))})
        '
        'pourc
        '
        Me.pourc.AppearanceCell.Font = CType(resources.GetObject("pourc.AppearanceCell.Font"), System.Drawing.Font)
        Me.pourc.AppearanceCell.Options.UseFont = True
        Me.pourc.AppearanceHeader.Font = CType(resources.GetObject("pourc.AppearanceHeader.Font"), System.Drawing.Font)
        Me.pourc.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.pourc.AppearanceHeader.Options.UseFont = True
        Me.pourc.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.pourc, "pourc")
        Me.pourc.DisplayFormat.FormatString = "{0:n2}"
        Me.pourc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.pourc.FieldName = "pourc"
        Me.pourc.Name = "pourc"
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
        'BtValider
        '
        resources.ApplyResources(Me.BtValider, "BtValider")
        Me.BtValider.Name = "BtValider"
        Me.BtValider.UseVisualStyleBackColor = True
        '
        'lblGroupeEMALEC
        '
        resources.ApplyResources(Me.lblGroupeEMALEC, "lblGroupeEMALEC")
        Me.lblGroupeEMALEC.Name = "lblGroupeEMALEC"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Tag = "502"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'frmReportingAchatsFourniture
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.lblGroupeEMALEC)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
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
        Me.Name = "frmReportingAchatsFourniture"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents BtValider As System.Windows.Forms.Button
    Friend WithEvents lblGroupeEMALEC As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents vfoumat As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents qte As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents mnt As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents pourc As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents vfouser As DevExpress.XtraGrid.Columns.GridColumn
End Class
