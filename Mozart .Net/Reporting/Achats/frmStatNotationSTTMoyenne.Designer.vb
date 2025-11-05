<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatNotationSTTMoyenne
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
    Dim RegressionLine1 As DevExpress.XtraCharts.RegressionLine = New DevExpress.XtraCharts.RegressionLine()
    Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
    Me.GroupBox3 = New System.Windows.Forms.GroupBox()
    Me.lblmoyenne = New System.Windows.Forms.Label()
    Me.lblObj = New System.Windows.Forms.Label()
    Me.lblPerim = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.lblMoy12 = New System.Windows.Forms.Label()
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.BtnPrint = New System.Windows.Forms.Button()
    Me.GCStat = New DevExpress.XtraGrid.GridControl()
    Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.ColPériode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColValeur = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.GrpPer = New System.Windows.Forms.GroupBox()
    Me.ChartBas = New DevExpress.XtraCharts.ChartControl()
        Me.GroupBox3.SuspendLayout()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPer.SuspendLayout()
        CType(Me.ChartBas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RegressionLine1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblmoyenne)
        Me.GroupBox3.Controls.Add(Me.lblObj)
        Me.GroupBox3.Controls.Add(Me.lblPerim)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lblMoy12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(1229, 38)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(220, 378)
        Me.GroupBox3.TabIndex = 54
        Me.GroupBox3.TabStop = False
        '
        'lblmoyenne
        '
        Me.lblmoyenne.BackColor = System.Drawing.Color.White
        Me.lblmoyenne.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmoyenne.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblmoyenne.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblmoyenne.Location = New System.Drawing.Point(6, 325)
        Me.lblmoyenne.Name = "lblmoyenne"
        Me.lblmoyenne.Size = New System.Drawing.Size(208, 32)
        Me.lblmoyenne.TabIndex = 39
        Me.lblmoyenne.Text = "Moy"
        Me.lblmoyenne.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblObj
        '
        Me.lblObj.BackColor = System.Drawing.Color.White
        Me.lblObj.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblObj.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblObj.Location = New System.Drawing.Point(6, 263)
        Me.lblObj.Name = "lblObj"
        Me.lblObj.Size = New System.Drawing.Size(208, 30)
        Me.lblObj.TabIndex = 38
        Me.lblObj.Text = "Objectif mensuel : > 70%"
        '
        'lblPerim
        '
        Me.lblPerim.BackColor = System.Drawing.Color.White
        Me.lblPerim.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lblPerim.ForeColor = System.Drawing.Color.Black
        Me.lblPerim.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPerim.Location = New System.Drawing.Point(6, 48)
        Me.lblPerim.Name = "lblPerim"
        Me.lblPerim.Size = New System.Drawing.Size(208, 177)
        Me.lblPerim.TabIndex = 37
        Me.lblPerim.Text = "Objectif qualité mensuel : 70% de note entre 70 et 100.             Moyenne sur l" &
    "es notations de 0 à 100 lors de chaque intervention du sous-traitant "
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(6, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 30)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Périmètre de l'indicateur"
        '
        'lblMoy12
        '
        Me.lblMoy12.BackColor = System.Drawing.Color.White
        Me.lblMoy12.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lblMoy12.ForeColor = System.Drawing.Color.Black
        Me.lblMoy12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMoy12.Location = New System.Drawing.Point(6, 293)
        Me.lblMoy12.Name = "lblMoy12"
        Me.lblMoy12.Size = New System.Drawing.Size(208, 32)
        Me.lblMoy12.TabIndex = 35
        Me.lblMoy12.Text = "Taux actuel :"
        Me.lblMoy12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Location = New System.Drawing.Point(12, 38)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(89, 644)
        Me.GrpActions.TabIndex = 52
        Me.GrpActions.TabStop = False
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(6, 579)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPrint.Location = New System.Drawing.Point(6, 16)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(75, 48)
        Me.BtnPrint.TabIndex = 0
        Me.BtnPrint.Text = "Imprimer"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'GCStat
        '
        Me.GCStat.Location = New System.Drawing.Point(110, 54)
        Me.GCStat.MainView = Me.GVStat
        Me.GCStat.Name = "GCStat"
        Me.GCStat.Size = New System.Drawing.Size(200, 628)
        Me.GCStat.TabIndex = 55
        Me.GCStat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStat})
        '
        'GVStat
        '
        Me.GVStat.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVStat.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVStat.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVStat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColPériode, Me.ColValeur})
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'ColPériode
        '
        Me.ColPériode.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColPériode.AppearanceHeader.Options.UseForeColor = True
        Me.ColPériode.Caption = "Note"
        Me.ColPériode.FieldName = "vstflib"
        Me.ColPériode.Name = "ColPériode"
        Me.ColPériode.Visible = True
        Me.ColPériode.VisibleIndex = 0
        '
        'ColValeur
        '
        Me.ColValeur.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColValeur.AppearanceHeader.Options.UseForeColor = True
        Me.ColValeur.Caption = "Valeur (%)"
        Me.ColValeur.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColValeur.FieldName = "POURC"
        Me.ColValeur.Name = "ColValeur"
        Me.ColValeur.Visible = True
        Me.ColValeur.VisibleIndex = 1
        '
        'LblTitre
        '
        Me.LblTitre.AutoSize = True
        Me.LblTitre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(105, 14)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(200, 19)
        Me.LblTitre.TabIndex = 53
        Me.LblTitre.Text = "Notation des prestataires"
        '
        'GrpPer
        '
        Me.GrpPer.Controls.Add(Me.ChartBas)
        Me.GrpPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GrpPer.Location = New System.Drawing.Point(320, 38)
        Me.GrpPer.Name = "GrpPer"
        Me.GrpPer.Size = New System.Drawing.Size(897, 644)
        Me.GrpPer.TabIndex = 56
        Me.GrpPer.TabStop = False
        '
        'ChartBas
        '
        XyDiagram1.AxisX.Label.Angle = 90
        XyDiagram1.AxisX.Reverse = True
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        ConstantLine1.AxisValueSerializable = "1"
        ConstantLine1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        ConstantLine1.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Solid
        ConstantLine1.LineStyle.Thickness = 2
        ConstantLine1.Name = "Objectif"
        ConstantLine1.Title.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        ConstantLine1.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        ConstantLine1.Title.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        ConstantLine1.Visible = False
        XyDiagram1.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine1})
        XyDiagram1.AxisY.Label.TextPattern = "{V:N0}"
        XyDiagram1.AxisY.Title.Text = "(%)"
        XyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartBas.Diagram = XyDiagram1
        Me.ChartBas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartBas.Legend.EquallySpacedItems = False
        Me.ChartBas.Legend.Name = "Default Legend"
        Me.ChartBas.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartBas.Location = New System.Drawing.Point(3, 16)
        Me.ChartBas.Name = "ChartBas"
        Series1.ArgumentDataMember = "vstflib"
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel1.TextPattern = "{V:N0}"
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series1.ShowInLegend = False
        Series1.ValueDataMembersSerializable = "POURC"
        SideBySideBarSeriesView1.Color = System.Drawing.Color.DodgerBlue
        RegressionLine1.Color = System.Drawing.Color.Fuchsia
        RegressionLine1.Visible = False
        SideBySideBarSeriesView1.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {RegressionLine1})
        Series1.View = SideBySideBarSeriesView1
        Me.ChartBas.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        SideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartBas.SeriesTemplate.Label = SideBySideBarSeriesLabel2
        Me.ChartBas.Size = New System.Drawing.Size(891, 625)
        Me.ChartBas.TabIndex = 1
        '
        'frmStatNotationSTTMoyenne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1469, 766)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpPer)
        Me.Name = "frmStatNotationSTTMoyenne"
        Me.Text = "Moyenne des notations des prestataires"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPer.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RegressionLine1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartBas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
  Friend WithEvents lblObj As Label
  Friend WithEvents lblPerim As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents lblMoy12 As Label
  Friend WithEvents GrpActions As GroupBox
  Friend WithEvents BtnFermer As Button
  Friend WithEvents BtnPrint As Button
  Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
  Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents ColPériode As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents ColValeur As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LblTitre As Label
  Friend WithEvents GrpPer As GroupBox
  Private WithEvents ChartBas As DevExpress.XtraCharts.ChartControl
  Friend WithEvents lblmoyenne As Label
End Class
