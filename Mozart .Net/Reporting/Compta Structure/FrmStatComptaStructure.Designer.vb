<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStatComptaStructure
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
        Dim SecondaryAxisY1 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
        Dim SecondaryAxisY2 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedLineSeriesView1 As DevExpress.XtraCharts.StackedLineSeriesView = New DevExpress.XtraCharts.StackedLineSeriesView()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedLineSeriesView2 As DevExpress.XtraCharts.StackedLineSeriesView = New DevExpress.XtraCharts.StackedLineSeriesView()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedLineSeriesView3 As DevExpress.XtraCharts.StackedLineSeriesView = New DevExpress.XtraCharts.StackedLineSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.GVDetailPers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GDetailPersColANNEE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetailPersColVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetailPersColVPERPRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetailPersColVSOCIETE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetailPersColDPERENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetailPersColDPERSOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCStat = New DevExpress.XtraGrid.GridControl()
        Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColANNEE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColTOT_CA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNBPER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColRATIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.ChartCtrlCA = New DevExpress.XtraCharts.ChartControl()
        CType(Me.GVDetailPers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ChartCtrlCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SecondaryAxisY1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SecondaryAxisY2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedLineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedLineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedLineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GVDetailPers
        '
        Me.GVDetailPers.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVDetailPers.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVDetailPers.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVDetailPers.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVDetailPers.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVDetailPers.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVDetailPers.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GDetailPersColANNEE, Me.GDetailPersColVPERNOM, Me.GDetailPersColVPERPRE, Me.GDetailPersColVSOCIETE, Me.GDetailPersColDPERENT, Me.GDetailPersColDPERSOR})
        Me.GVDetailPers.GridControl = Me.GCStat
        Me.GVDetailPers.Name = "GVDetailPers"
        Me.GVDetailPers.OptionsView.ShowGroupPanel = False
        '
        'GDetailPersColANNEE
        '
        Me.GDetailPersColANNEE.Caption = "ANNEE"
        Me.GDetailPersColANNEE.FieldName = "ANNEE"
        Me.GDetailPersColANNEE.Name = "GDetailPersColANNEE"
        Me.GDetailPersColANNEE.OptionsColumn.AllowEdit = False
        Me.GDetailPersColANNEE.OptionsColumn.ReadOnly = True
        '
        'GDetailPersColVPERNOM
        '
        Me.GDetailPersColVPERNOM.AppearanceCell.Options.UseTextOptions = True
        Me.GDetailPersColVPERNOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GDetailPersColVPERNOM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GDetailPersColVPERNOM.Caption = "Nom"
        Me.GDetailPersColVPERNOM.FieldName = "VPERNOM"
        Me.GDetailPersColVPERNOM.Name = "GDetailPersColVPERNOM"
        Me.GDetailPersColVPERNOM.OptionsColumn.AllowEdit = False
        Me.GDetailPersColVPERNOM.OptionsColumn.ReadOnly = True
        Me.GDetailPersColVPERNOM.Visible = True
        Me.GDetailPersColVPERNOM.VisibleIndex = 0
        '
        'GDetailPersColVPERPRE
        '
        Me.GDetailPersColVPERPRE.AppearanceCell.Options.UseTextOptions = True
        Me.GDetailPersColVPERPRE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GDetailPersColVPERPRE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GDetailPersColVPERPRE.Caption = "Prénom"
        Me.GDetailPersColVPERPRE.FieldName = "VPERPRE"
        Me.GDetailPersColVPERPRE.Name = "GDetailPersColVPERPRE"
        Me.GDetailPersColVPERPRE.OptionsColumn.AllowEdit = False
        Me.GDetailPersColVPERPRE.OptionsColumn.ReadOnly = True
        Me.GDetailPersColVPERPRE.Visible = True
        Me.GDetailPersColVPERPRE.VisibleIndex = 1
        '
        'GDetailPersColVSOCIETE
        '
        Me.GDetailPersColVSOCIETE.AppearanceCell.Options.UseTextOptions = True
        Me.GDetailPersColVSOCIETE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GDetailPersColVSOCIETE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GDetailPersColVSOCIETE.Caption = "Société"
        Me.GDetailPersColVSOCIETE.FieldName = "VSOCIETE"
        Me.GDetailPersColVSOCIETE.Name = "GDetailPersColVSOCIETE"
        Me.GDetailPersColVSOCIETE.OptionsColumn.AllowEdit = False
        Me.GDetailPersColVSOCIETE.OptionsColumn.ReadOnly = True
        Me.GDetailPersColVSOCIETE.Visible = True
        Me.GDetailPersColVSOCIETE.VisibleIndex = 2
        '
        'GDetailPersColDPERENT
        '
        Me.GDetailPersColDPERENT.AppearanceCell.Options.UseTextOptions = True
        Me.GDetailPersColDPERENT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GDetailPersColDPERENT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GDetailPersColDPERENT.Caption = "Date entrée"
        Me.GDetailPersColDPERENT.FieldName = "DPERENT"
        Me.GDetailPersColDPERENT.Name = "GDetailPersColDPERENT"
        Me.GDetailPersColDPERENT.OptionsColumn.AllowEdit = False
        Me.GDetailPersColDPERENT.OptionsColumn.ReadOnly = True
        Me.GDetailPersColDPERENT.Visible = True
        Me.GDetailPersColDPERENT.VisibleIndex = 3
        '
        'GDetailPersColDPERSOR
        '
        Me.GDetailPersColDPERSOR.AppearanceCell.Options.UseTextOptions = True
        Me.GDetailPersColDPERSOR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GDetailPersColDPERSOR.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GDetailPersColDPERSOR.Caption = "Date sortie"
        Me.GDetailPersColDPERSOR.FieldName = "DPERSOR"
        Me.GDetailPersColDPERSOR.Name = "GDetailPersColDPERSOR"
        Me.GDetailPersColDPERSOR.OptionsColumn.AllowEdit = False
        Me.GDetailPersColDPERSOR.OptionsColumn.ReadOnly = True
        Me.GDetailPersColDPERSOR.Visible = True
        Me.GDetailPersColDPERSOR.VisibleIndex = 4
        '
        'GCStat
        '
        Me.GCStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GCStat.Location = New System.Drawing.Point(122, 50)
        Me.GCStat.MainView = Me.GVStat
        Me.GCStat.Name = "GCStat"
        Me.GCStat.Size = New System.Drawing.Size(596, 813)
        Me.GCStat.TabIndex = 34
        Me.GCStat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStat, Me.GVDetailPers})
        '
        'GVStat
        '
        Me.GVStat.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GVStat.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVStat.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVStat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVStat.ColumnPanelRowHeight = 50
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColANNEE, Me.GColTOT_CA, Me.GColNBPER, Me.GColRATIO})
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsCustomization.AllowGroup = False
        Me.GVStat.OptionsPrint.PrintFilterInfo = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'GColANNEE
        '
        Me.GColANNEE.AppearanceCell.Options.UseTextOptions = True
        Me.GColANNEE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColANNEE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColANNEE.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColANNEE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColANNEE.AppearanceHeader.Options.UseForeColor = True
        Me.GColANNEE.Caption = "Année"
        Me.GColANNEE.FieldName = "ANNEE"
        Me.GColANNEE.MinWidth = 10
        Me.GColANNEE.Name = "GColANNEE"
        Me.GColANNEE.OptionsColumn.AllowEdit = False
        Me.GColANNEE.OptionsColumn.ReadOnly = True
        Me.GColANNEE.Visible = True
        Me.GColANNEE.VisibleIndex = 0
        Me.GColANNEE.Width = 100
        '
        'GColTOT_CA
        '
        Me.GColTOT_CA.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColTOT_CA.AppearanceHeader.Options.UseForeColor = True
        Me.GColTOT_CA.Caption = "Chiffre d'affaires du groupe EMALEC"
        Me.GColTOT_CA.DisplayFormat.FormatString = "C0"
        Me.GColTOT_CA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColTOT_CA.FieldName = "TOT_CA"
        Me.GColTOT_CA.MinWidth = 100
        Me.GColTOT_CA.Name = "GColTOT_CA"
        Me.GColTOT_CA.OptionsColumn.AllowEdit = False
        Me.GColTOT_CA.OptionsColumn.ReadOnly = True
        Me.GColTOT_CA.Visible = True
        Me.GColTOT_CA.VisibleIndex = 1
        Me.GColTOT_CA.Width = 150
        '
        'GColNBPER
        '
        Me.GColNBPER.AppearanceCell.Options.UseTextOptions = True
        Me.GColNBPER.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNBPER.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColNBPER.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNBPER.AppearanceHeader.Options.UseForeColor = True
        Me.GColNBPER.Caption = "Nombre de personnes en comptabilité"
        Me.GColNBPER.DisplayFormat.FormatString = "n0"
        Me.GColNBPER.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColNBPER.FieldName = "NBPER"
        Me.GColNBPER.Name = "GColNBPER"
        Me.GColNBPER.OptionsColumn.AllowEdit = False
        Me.GColNBPER.OptionsColumn.ReadOnly = True
        Me.GColNBPER.Visible = True
        Me.GColNBPER.VisibleIndex = 2
        Me.GColNBPER.Width = 161
        '
        'GColRATIO
        '
        Me.GColRATIO.AppearanceCell.Options.UseTextOptions = True
        Me.GColRATIO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColRATIO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColRATIO.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColRATIO.AppearanceHeader.Options.UseForeColor = True
        Me.GColRATIO.Caption = "Ratio Nbr de personnes / Million €"
        Me.GColRATIO.DisplayFormat.FormatString = "n2"
        Me.GColRATIO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColRATIO.FieldName = "RATIO"
        Me.GColRATIO.Name = "GColRATIO"
        Me.GColRATIO.OptionsColumn.AllowEdit = False
        Me.GColRATIO.OptionsColumn.ReadOnly = True
        Me.GColRATIO.Visible = True
        Me.GColRATIO.VisibleIndex = 3
        Me.GColRATIO.Width = 167
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnPrint)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(87, 857)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(7, 803)
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
        Me.BtnPrint.Location = New System.Drawing.Point(7, 20)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(74, 48)
        Me.BtnPrint.TabIndex = 0
        Me.BtnPrint.Text = "Imprimer"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelTitre.Location = New System.Drawing.Point(118, 23)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(387, 19)
        Me.LabelTitre.TabIndex = 32
        Me.LabelTitre.Text = "Statistique : Comptabilité Structure Toutes filiales "
        '
        'ChartCtrlCA
        '
        Me.ChartCtrlCA.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Label.TextPattern = "{V:c0}"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        SecondaryAxisY1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SecondaryAxisY1.AxisID = 0
        SecondaryAxisY1.Name = "SecAxisYNBPER"
        SecondaryAxisY1.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        SecondaryAxisY1.VisibleInPanesSerializable = "-1"
        SecondaryAxisY1.VisualRange.Auto = False
        SecondaryAxisY1.VisualRange.AutoSideMargins = False
        SecondaryAxisY1.VisualRange.EndSideMargin = 1.0R
        SecondaryAxisY1.VisualRange.MaxValueSerializable = "20"
        SecondaryAxisY1.VisualRange.MinValueSerializable = "0"
        SecondaryAxisY1.VisualRange.StartSideMargin = 1.0R
        SecondaryAxisY1.WholeRange.Auto = False
        SecondaryAxisY1.WholeRange.AutoSideMargins = False
        SecondaryAxisY1.WholeRange.EndSideMargin = 1.0R
        SecondaryAxisY1.WholeRange.MaxValueSerializable = "20"
        SecondaryAxisY1.WholeRange.MinValueSerializable = "0"
        SecondaryAxisY1.WholeRange.StartSideMargin = 1.0R
        SecondaryAxisY2.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        SecondaryAxisY2.AxisID = 1
        SecondaryAxisY2.Name = "SecAxisYRATIO"
        SecondaryAxisY2.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        SecondaryAxisY2.VisibleInPanesSerializable = "-1"
        SecondaryAxisY2.VisualRange.Auto = False
        SecondaryAxisY2.VisualRange.AutoSideMargins = False
        SecondaryAxisY2.VisualRange.EndSideMargin = 0.01R
        SecondaryAxisY2.VisualRange.MaxValueSerializable = "0.5"
        SecondaryAxisY2.VisualRange.MinValueSerializable = "0"
        SecondaryAxisY2.VisualRange.StartSideMargin = 0.01R
        SecondaryAxisY2.WholeRange.AlwaysShowZeroLevel = False
        SecondaryAxisY2.WholeRange.Auto = False
        SecondaryAxisY2.WholeRange.AutoSideMargins = False
        SecondaryAxisY2.WholeRange.EndSideMargin = 0.01R
        SecondaryAxisY2.WholeRange.MaxValueSerializable = "0.5"
        SecondaryAxisY2.WholeRange.MinValueSerializable = "0"
        SecondaryAxisY2.WholeRange.StartSideMargin = 0.01R
        XyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {SecondaryAxisY1, SecondaryAxisY2})
        Me.ChartCtrlCA.Diagram = XyDiagram1
        Me.ChartCtrlCA.Location = New System.Drawing.Point(722, 54)
        Me.ChartCtrlCA.Name = "ChartCtrlCA"
        Series1.ArgumentDataMember = "ANNEE"
        Series1.CrosshairLabelPattern = "Chiffres d'affaires : {V}"
        Series1.LegendTextPattern = "Chiffres d'affaires"
        Series1.Name = "SerieCA"
        Series1.ValueDataMembersSerializable = "TOT_CA"
        StackedLineSeriesView1.LineStyle.Thickness = 4
        Series1.View = StackedLineSeriesView1
        Series2.ArgumentDataMember = "ANNEE"
        Series2.CrosshairLabelPattern = "Nb Personnes : {V}"
        Series2.LegendTextPattern = "Nb Personnes"
        Series2.Name = "SerieNBPER"
        Series2.ValueDataMembersSerializable = "NBPER"
        StackedLineSeriesView2.AxisYName = "SecAxisYNBPER"
        StackedLineSeriesView2.LineStyle.Thickness = 4
        Series2.View = StackedLineSeriesView2
        Series3.ArgumentDataMember = "ANNEE"
        Series3.CrosshairLabelPattern = "Ratio : {V}"
        Series3.LegendTextPattern = "Ratio"
        Series3.Name = "SerieRATIO"
        Series3.ValueDataMembersSerializable = "RATIO"
        StackedLineSeriesView3.AxisYName = "SecAxisYRATIO"
        StackedLineSeriesView3.LineStyle.Thickness = 4
        Series3.View = StackedLineSeriesView3
        Me.ChartCtrlCA.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2, Series3}
        Me.ChartCtrlCA.Size = New System.Drawing.Size(1063, 812)
        Me.ChartCtrlCA.TabIndex = 35
        ChartTitle1.Text = "Comptabilité structure toutes filiales"
        ChartTitle1.TextColor = System.Drawing.Color.Black
        Me.ChartCtrlCA.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'FrmStatComptaStructure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(2049, 901)
        Me.Controls.Add(Me.ChartCtrlCA)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "FrmStatComptaStructure"
        Me.Text = "Statistique - Comptabilité Structure"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GVDetailPers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(SecondaryAxisY1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SecondaryAxisY2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedLineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedLineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedLineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartCtrlCA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColANNEE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColTOT_CA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents GColNBPER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColRATIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChartCtrlCA As DevExpress.XtraCharts.ChartControl
    Friend WithEvents GVDetailPers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GDetailPersColANNEE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GDetailPersColVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GDetailPersColVPERPRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GDetailPersColVSOCIETE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GDetailPersColDPERENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GDetailPersColDPERSOR As DevExpress.XtraGrid.Columns.GridColumn
End Class
