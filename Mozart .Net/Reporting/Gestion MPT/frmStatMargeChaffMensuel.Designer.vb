<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatMargeChaffMensuel
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
    Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
    Dim ConstantLine1 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
    Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
    Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
    Dim Bar3DSeriesLabel1 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel()
    Dim SideBySideBar3DSeriesView1 As DevExpress.XtraCharts.SideBySideBar3DSeriesView = New DevExpress.XtraCharts.SideBySideBar3DSeriesView()
    Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
    Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
    Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
    Me.MARGE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.GCStat = New DevExpress.XtraGrid.GridControl()
    Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.VCHAFF = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.BtnPrint = New System.Windows.Forms.Button()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.GrpPeriode = New System.Windows.Forms.GroupBox()
    Me.BtValider = New System.Windows.Forms.Button()
    Me.LblAnnee = New System.Windows.Forms.Label()
    Me.LblMois = New System.Windows.Forms.Label()
    Me.CboAnnee = New System.Windows.Forms.ComboBox()
    Me.CboMois = New System.Windows.Forms.ComboBox()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBar3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.GrpPeriode.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChartControl1
        '
        XyDiagram1.AxisX.Label.Angle = -90
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        ConstantLine1.AxisValueSerializable = "1"
        ConstantLine1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        ConstantLine1.LegendText = "Objectifs"
        ConstantLine1.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Solid
        ConstantLine1.LineStyle.Thickness = 2
        ConstantLine1.Name = "Objectif"
        ConstantLine1.Title.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        ConstantLine1.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        ConstantLine1.Title.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        ConstantLine1.Visible = False
        XyDiagram1.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine1})
        XyDiagram1.AxisY.Title.Text = "Nombre"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Legend.EquallySpacedItems = False
        Me.ChartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartControl1.Location = New System.Drawing.Point(3, 16)
        Me.ChartControl1.Name = "ChartControl1"
        Series1.ArgumentDataMember = "VPERNOM"
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel1.TextPattern = "{V:N0}"
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series1.LegendTextPattern = "  Nouveaux Sous-traitant"
        Series1.Name = "SeriesNbTech"
        Series1.ShowInLegend = False
        Series1.ValueDataMembersSerializable = "MARGE"
        SideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        SideBySideBarSeriesView1.Transparency = CType(30, Byte)
        Series1.View = SideBySideBarSeriesView1
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.ChartControl1.SeriesTemplate.ArgumentDataMember = "VPERNOM"
        Bar3DSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.SeriesTemplate.Label = Bar3DSeriesLabel1
        Me.ChartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.SeriesTemplate.ValueDataMembersSerializable = "MARGE"
        Me.ChartControl1.SeriesTemplate.View = SideBySideBar3DSeriesView1
        Me.ChartControl1.Size = New System.Drawing.Size(1451, 733)
        Me.ChartControl1.TabIndex = 1
        ChartTitle1.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        ChartTitle1.Text = ""
        ChartTitle1.TextColor = System.Drawing.Color.Black
        ChartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'MARGE
        '
        Me.MARGE.AppearanceCell.Options.UseTextOptions = True
        Me.MARGE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MARGE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.MARGE.AppearanceHeader.Options.UseForeColor = True
        Me.MARGE.Caption = "Marge analytique"
        Me.MARGE.DisplayFormat.FormatString = "{0} %"
        Me.MARGE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MARGE.FieldName = "MARGE"
        Me.MARGE.MinWidth = 15
        Me.MARGE.Name = "MARGE"
        Me.MARGE.Visible = True
        Me.MARGE.VisibleIndex = 1
        Me.MARGE.Width = 158
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChartControl1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(425, 111)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1457, 752)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        '
        'GCStat
        '
        GridLevelNode1.RelationName = "Level1"
        Me.GCStat.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GCStat.Location = New System.Drawing.Point(129, 128)
        Me.GCStat.MainView = Me.GVStat
        Me.GCStat.Name = "GCStat"
        Me.GCStat.Size = New System.Drawing.Size(286, 735)
        Me.GCStat.TabIndex = 85
        Me.GCStat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStat})
        '
        'GVStat
        '
        Me.GVStat.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVStat.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVStat.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVStat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.VCHAFF, Me.MARGE})
        Me.GVStat.DetailHeight = 284
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsEditForm.PopupEditFormWidth = 600
        Me.GVStat.OptionsView.ShowAutoFilterRow = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'VCHAFF
        '
        Me.VCHAFF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VCHAFF.AppearanceHeader.Options.UseForeColor = True
        Me.VCHAFF.Caption = "Chargé d'affaires"
        Me.VCHAFF.FieldName = "VPERNOM"
        Me.VCHAFF.MinWidth = 15
        Me.VCHAFF.Name = "VCHAFF"
        Me.VCHAFF.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.VCHAFF.Visible = True
        Me.VCHAFF.VisibleIndex = 0
        Me.VCHAFF.Width = 152
        '
        'LblTitre
        '
        Me.LblTitre.AutoSize = True
        Me.LblTitre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(126, 19)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(325, 19)
        Me.LblTitre.TabIndex = 75
        Me.LblTitre.Text = "Statistique de marge par chargé d'affaires"
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPrint.Location = New System.Drawing.Point(6, 19)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(75, 42)
        Me.BtnPrint.TabIndex = 2
        Me.BtnPrint.Text = "Imprimer"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(6, 798)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Location = New System.Drawing.Point(10, 11)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(110, 852)
        Me.GrpActions.TabIndex = 74
        Me.GrpActions.TabStop = False
        '
        'GrpPeriode
        '
        Me.GrpPeriode.Controls.Add(Me.BtValider)
        Me.GrpPeriode.Controls.Add(Me.LblAnnee)
        Me.GrpPeriode.Controls.Add(Me.LblMois)
        Me.GrpPeriode.Controls.Add(Me.CboAnnee)
        Me.GrpPeriode.Controls.Add(Me.CboMois)
        Me.GrpPeriode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GrpPeriode.Location = New System.Drawing.Point(129, 49)
        Me.GrpPeriode.Name = "GrpPeriode"
        Me.GrpPeriode.Size = New System.Drawing.Size(720, 56)
        Me.GrpPeriode.TabIndex = 87
        Me.GrpPeriode.TabStop = False
        Me.GrpPeriode.Text = "Période"
        '
        'BtValider
        '
        Me.BtValider.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtValider.Location = New System.Drawing.Point(605, 13)
        Me.BtValider.Name = "BtValider"
        Me.BtValider.Size = New System.Drawing.Size(84, 35)
        Me.BtValider.TabIndex = 4
        Me.BtValider.Text = "Valider"
        Me.BtValider.UseVisualStyleBackColor = True
        '
        'LblAnnee
        '
        Me.LblAnnee.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblAnnee.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblAnnee.Location = New System.Drawing.Point(307, 22)
        Me.LblAnnee.Name = "LblAnnee"
        Me.LblAnnee.Size = New System.Drawing.Size(70, 18)
        Me.LblAnnee.TabIndex = 3
        Me.LblAnnee.Text = "Année"
        '
        'LblMois
        '
        Me.LblMois.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblMois.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblMois.Location = New System.Drawing.Point(56, 22)
        Me.LblMois.Name = "LblMois"
        Me.LblMois.Size = New System.Drawing.Size(41, 18)
        Me.LblMois.TabIndex = 2
        Me.LblMois.Text = "Mois"
        '
        'CboAnnee
        '
        Me.CboAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAnnee.FormattingEnabled = True
        Me.CboAnnee.Location = New System.Drawing.Point(383, 19)
        Me.CboAnnee.Name = "CboAnnee"
        Me.CboAnnee.Size = New System.Drawing.Size(172, 24)
        Me.CboAnnee.TabIndex = 1
        '
        'CboMois
        '
        Me.CboMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMois.FormattingEnabled = True
        Me.CboMois.Location = New System.Drawing.Point(103, 19)
        Me.CboMois.Name = "CboMois"
        Me.CboMois.Size = New System.Drawing.Size(172, 24)
        Me.CboMois.TabIndex = 0
        '
        'frmStatMargeChaffMensuel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1901, 862)
        Me.Controls.Add(Me.GrpPeriode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmStatMargeChaffMensuel"
        Me.Text = "Marge analytique par chargé d'affaires"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBar3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.GrpPeriode.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
  Private WithEvents MARGE As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GroupBox1 As GroupBox
  Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
  Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents VCHAFF As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LblTitre As Label
  Friend WithEvents BtnPrint As Button
  Friend WithEvents BtnFermer As Button
  Friend WithEvents GrpActions As GroupBox
  Friend WithEvents GrpPeriode As System.Windows.Forms.GroupBox
  Friend WithEvents BtValider As System.Windows.Forms.Button
  Friend WithEvents LblAnnee As System.Windows.Forms.Label
  Friend WithEvents LblMois As System.Windows.Forms.Label
  Friend WithEvents CboAnnee As System.Windows.Forms.ComboBox
  Friend WithEvents CboMois As System.Windows.Forms.ComboBox
End Class
