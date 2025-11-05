<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTauxConformite
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTauxConformite))
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim ConstantLine2 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim RegressionLine2 As DevExpress.XtraCharts.RegressionLine = New DevExpress.XtraCharts.RegressionLine()
        Dim SideBySideBarSeriesLabel4 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblObj = New System.Windows.Forms.Label()
        Me.lblPerim = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMoy12 = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GCStat = New DevExpress.XtraGrid.GridControl()
        Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColPériode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColValeur = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpPer = New System.Windows.Forms.GroupBox()
        Me.ChartBas = New DevExpress.XtraCharts.ChartControl()
        Me.CboTech = New System.Windows.Forms.ComboBox()
        Me.cmdValider = New System.Windows.Forms.Button()
        Me.GroupBoxChaff = New System.Windows.Forms.GroupBox()
        Me.GroupBoxCreateur = New System.Windows.Forms.GroupBox()
        Me.cboCreateur = New System.Windows.Forms.ComboBox()
        Me.cmdValidByCreateur = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPer.SuspendLayout()
        CType(Me.ChartBas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RegressionLine2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxChaff.SuspendLayout()
        Me.GroupBoxCreateur.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Controls.Add(Me.lblObj)
        Me.GroupBox3.Controls.Add(Me.lblPerim)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lblMoy12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'lblObj
        '
        Me.lblObj.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblObj, "lblObj")
        Me.lblObj.Name = "lblObj"
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
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
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
        resources.ApplyResources(Me.ColPériode, "ColPériode")
        Me.ColPériode.FieldName = "LIB"
        Me.ColPériode.Name = "ColPériode"
        '
        'ColValeur
        '
        Me.ColValeur.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColValeur.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.ColValeur, "ColValeur")
        Me.ColValeur.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColValeur.FieldName = "NB"
        Me.ColValeur.Name = "ColValeur"
        '
        'GrpPer
        '
        resources.ApplyResources(Me.GrpPer, "GrpPer")
        Me.GrpPer.Controls.Add(Me.ChartBas)
        Me.GrpPer.Name = "GrpPer"
        Me.GrpPer.TabStop = False
        '
        'ChartBas
        '
        resources.ApplyResources(Me.ChartBas, "ChartBas")
        XyDiagram2.AxisX.Label.Angle = CType(resources.GetObject("resource.Angle"), Integer)
        XyDiagram2.AxisX.Reverse = True
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        ConstantLine2.AxisValueSerializable = "1"
        ConstantLine2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        ConstantLine2.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Solid
        ConstantLine2.LineStyle.Thickness = 2
        ConstantLine2.Name = "Objectif"
        ConstantLine2.Title.DXFont = CType(resources.GetObject("resource.DXFont"), DevExpress.Drawing.DXFont)
        ConstantLine2.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        ConstantLine2.Title.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        XyDiagram2.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine2})
        XyDiagram2.AxisY.Label.TextPattern = "{V:N0}"
        XyDiagram2.AxisY.Title.Text = resources.GetString("resource.Text")
        XyDiagram2.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartBas.Diagram = XyDiagram2
        Me.ChartBas.Legend.EquallySpacedItems = False
        Me.ChartBas.Legend.Name = "Default Legend"
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
        RegressionLine2.Color = System.Drawing.Color.Fuchsia
        SideBySideBarSeriesView2.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {RegressionLine2})
        Series2.View = SideBySideBarSeriesView2
        Me.ChartBas.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        SideBySideBarSeriesLabel4.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartBas.SeriesTemplate.Label = SideBySideBarSeriesLabel4
        '
        'CboTech
        '
        Me.CboTech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboTech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboTech.DisplayMember = "VPERNOM"
        Me.CboTech.FormattingEnabled = True
        resources.ApplyResources(Me.CboTech, "CboTech")
        Me.CboTech.Name = "CboTech"
        Me.CboTech.ValueMember = "NPERNUM"
        '
        'cmdValider
        '
        resources.ApplyResources(Me.cmdValider, "cmdValider")
        Me.cmdValider.Name = "cmdValider"
        Me.cmdValider.UseVisualStyleBackColor = True
        '
        'GroupBoxChaff
        '
        resources.ApplyResources(Me.GroupBoxChaff, "GroupBoxChaff")
        Me.GroupBoxChaff.Controls.Add(Me.CboTech)
        Me.GroupBoxChaff.Controls.Add(Me.cmdValider)
        Me.GroupBoxChaff.Name = "GroupBoxChaff"
        Me.GroupBoxChaff.TabStop = False
        '
        'GroupBoxCreateur
        '
        resources.ApplyResources(Me.GroupBoxCreateur, "GroupBoxCreateur")
        Me.GroupBoxCreateur.Controls.Add(Me.cboCreateur)
        Me.GroupBoxCreateur.Controls.Add(Me.cmdValidByCreateur)
        Me.GroupBoxCreateur.Name = "GroupBoxCreateur"
        Me.GroupBoxCreateur.TabStop = False
        '
        'cboCreateur
        '
        Me.cboCreateur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboCreateur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCreateur.DisplayMember = "VPERNOM"
        Me.cboCreateur.FormattingEnabled = True
        resources.ApplyResources(Me.cboCreateur, "cboCreateur")
        Me.cboCreateur.Name = "cboCreateur"
        Me.cboCreateur.ValueMember = "NPERNUM"
        '
        'cmdValidByCreateur
        '
        resources.ApplyResources(Me.cmdValidByCreateur, "cmdValidByCreateur")
        Me.cmdValidByCreateur.Name = "cmdValidByCreateur"
        Me.cmdValidByCreateur.UseVisualStyleBackColor = True
        '
        'frmTauxConformite
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnFermer
        Me.Controls.Add(Me.GroupBoxCreateur)
        Me.Controls.Add(Me.GroupBoxChaff)
        Me.Controls.Add(Me.GrpPer)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "frmTauxConformite"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPer.ResumeLayout(False)
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RegressionLine2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartBas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxChaff.ResumeLayout(False)
        Me.GroupBoxCreateur.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents lblObj As System.Windows.Forms.Label
  Friend WithEvents lblPerim As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents lblMoy12 As System.Windows.Forms.Label
  Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents BtnPrint As System.Windows.Forms.Button
  Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GrpPer As System.Windows.Forms.GroupBox
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColPériode As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColValeur As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ChartBas As DevExpress.XtraCharts.ChartControl
    Friend WithEvents CboTech As ComboBox
    Friend WithEvents cmdValider As Button
    Friend WithEvents GroupBoxChaff As GroupBox
    Friend WithEvents GroupBoxCreateur As GroupBox
    Friend WithEvents cboCreateur As ComboBox
    Friend WithEvents cmdValidByCreateur As Button
End Class
