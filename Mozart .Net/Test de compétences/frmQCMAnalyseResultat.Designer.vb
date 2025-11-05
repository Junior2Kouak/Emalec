<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQCMAnalyseResultat
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
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView3 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Me.GCListeQuest = New DevExpress.XtraGrid.GridControl()
        Me.GVListeQuest = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Col_NIDQUESTION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_NQCMQUESTIONORDER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_VQUESTIONLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_NB_REP_OK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.Col_NB_REP_NOK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.Col_NB_REP_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.Col_NB_REP_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_PC_REP_OK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_PC_REP_NOK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_PC_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnExportXLSX = New System.Windows.Forms.Button()
        Me.BtnResultatsByQCM = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblQCMTXRep = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblQCMRenseign = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblQCMAffect = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChartAna = New DevExpress.XtraCharts.ChartControl()
        Me.SDF = New System.Windows.Forms.SaveFileDialog()
        CType(Me.GCListeQuest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeQuest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ChartAna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCListeQuest
        '
        Me.GCListeQuest.Location = New System.Drawing.Point(122, 159)
        Me.GCListeQuest.MainView = Me.GVListeQuest
        Me.GCListeQuest.Name = "GCListeQuest"
        Me.GCListeQuest.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemHyperLinkEdit2, Me.RepositoryItemHyperLinkEdit3})
        Me.GCListeQuest.Size = New System.Drawing.Size(1171, 732)
        Me.GCListeQuest.TabIndex = 52
        Me.GCListeQuest.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeQuest})
        '
        'GVListeQuest
        '
        Me.GVListeQuest.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListeQuest.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeQuest.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeQuest.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeQuest.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeQuest.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListeQuest.ColumnPanelRowHeight = 50
        Me.GVListeQuest.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Col_NIDQUESTION, Me.Col_NQCMQUESTIONORDER, Me.Col_VQUESTIONLIB, Me.Col_NB_REP_OK, Me.Col_NB_REP_NOK, Me.Col_NB_REP_NO, Me.Col_NB_REP_TOTAL, Me.Col_PC_REP_OK, Me.Col_PC_REP_NOK, Me.Col_PC_NO})
        Me.GVListeQuest.GridControl = Me.GCListeQuest
        Me.GVListeQuest.Name = "GVListeQuest"
        Me.GVListeQuest.OptionsBehavior.ReadOnly = True
        Me.GVListeQuest.OptionsView.ShowAutoFilterRow = True
        Me.GVListeQuest.OptionsView.ShowFooter = True
        Me.GVListeQuest.OptionsView.ShowGroupPanel = False
        '
        'Col_NIDQUESTION
        '
        Me.Col_NIDQUESTION.Caption = "NIDQUESTION"
        Me.Col_NIDQUESTION.FieldName = "NIDQUESTION"
        Me.Col_NIDQUESTION.Name = "Col_NIDQUESTION"
        '
        'Col_NQCMQUESTIONORDER
        '
        Me.Col_NQCMQUESTIONORDER.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Col_NQCMQUESTIONORDER.AppearanceHeader.Options.UseForeColor = True
        Me.Col_NQCMQUESTIONORDER.Caption = "N°"
        Me.Col_NQCMQUESTIONORDER.FieldName = "NQCMQUESTIONORDER"
        Me.Col_NQCMQUESTIONORDER.Name = "Col_NQCMQUESTIONORDER"
        Me.Col_NQCMQUESTIONORDER.OptionsColumn.AllowEdit = False
        Me.Col_NQCMQUESTIONORDER.Visible = True
        Me.Col_NQCMQUESTIONORDER.VisibleIndex = 0
        Me.Col_NQCMQUESTIONORDER.Width = 50
        '
        'Col_VQUESTIONLIB
        '
        Me.Col_VQUESTIONLIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Col_VQUESTIONLIB.AppearanceHeader.Options.UseForeColor = True
        Me.Col_VQUESTIONLIB.Caption = "Question"
        Me.Col_VQUESTIONLIB.FieldName = "VQUESTIONLIB"
        Me.Col_VQUESTIONLIB.Name = "Col_VQUESTIONLIB"
        Me.Col_VQUESTIONLIB.OptionsColumn.AllowEdit = False
        Me.Col_VQUESTIONLIB.Visible = True
        Me.Col_VQUESTIONLIB.VisibleIndex = 1
        Me.Col_VQUESTIONLIB.Width = 549
        '
        'Col_NB_REP_OK
        '
        Me.Col_NB_REP_OK.AppearanceCell.Options.UseTextOptions = True
        Me.Col_NB_REP_OK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_NB_REP_OK.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Col_NB_REP_OK.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Col_NB_REP_OK.AppearanceHeader.Options.UseForeColor = True
        Me.Col_NB_REP_OK.Caption = "Nb réponse correcte"
        Me.Col_NB_REP_OK.ColumnEdit = Me.RepositoryItemHyperLinkEdit2
        Me.Col_NB_REP_OK.FieldName = "NB_REP_OK"
        Me.Col_NB_REP_OK.Name = "Col_NB_REP_OK"
        Me.Col_NB_REP_OK.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NB_REP_OK", "{0:0.##}")})
        Me.Col_NB_REP_OK.Visible = True
        Me.Col_NB_REP_OK.VisibleIndex = 2
        Me.Col_NB_REP_OK.Width = 136
        '
        'RepositoryItemHyperLinkEdit2
        '
        Me.RepositoryItemHyperLinkEdit2.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit2.Name = "RepositoryItemHyperLinkEdit2"
        Me.RepositoryItemHyperLinkEdit2.SingleClick = True
        '
        'Col_NB_REP_NOK
        '
        Me.Col_NB_REP_NOK.AppearanceCell.Options.UseTextOptions = True
        Me.Col_NB_REP_NOK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_NB_REP_NOK.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Col_NB_REP_NOK.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Col_NB_REP_NOK.AppearanceHeader.Options.UseForeColor = True
        Me.Col_NB_REP_NOK.Caption = "Nb réponse incorrecte"
        Me.Col_NB_REP_NOK.ColumnEdit = Me.RepositoryItemHyperLinkEdit1
        Me.Col_NB_REP_NOK.FieldName = "NB_REP_NOK"
        Me.Col_NB_REP_NOK.Name = "Col_NB_REP_NOK"
        Me.Col_NB_REP_NOK.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NB_REP_NOK", "{0:0.##}")})
        Me.Col_NB_REP_NOK.Visible = True
        Me.Col_NB_REP_NOK.VisibleIndex = 3
        Me.Col_NB_REP_NOK.Width = 140
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        Me.RepositoryItemHyperLinkEdit1.SingleClick = True
        '
        'Col_NB_REP_NO
        '
        Me.Col_NB_REP_NO.AppearanceCell.Options.UseTextOptions = True
        Me.Col_NB_REP_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_NB_REP_NO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Col_NB_REP_NO.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Col_NB_REP_NO.AppearanceHeader.Options.UseForeColor = True
        Me.Col_NB_REP_NO.Caption = "Nb non réponse"
        Me.Col_NB_REP_NO.ColumnEdit = Me.RepositoryItemHyperLinkEdit3
        Me.Col_NB_REP_NO.FieldName = "NB_REP_NO"
        Me.Col_NB_REP_NO.Name = "Col_NB_REP_NO"
        Me.Col_NB_REP_NO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NB_REP_NO", "{0:0.##}")})
        Me.Col_NB_REP_NO.Visible = True
        Me.Col_NB_REP_NO.VisibleIndex = 4
        Me.Col_NB_REP_NO.Width = 68
        '
        'RepositoryItemHyperLinkEdit3
        '
        Me.RepositoryItemHyperLinkEdit3.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit3.Name = "RepositoryItemHyperLinkEdit3"
        Me.RepositoryItemHyperLinkEdit3.SingleClick = True
        '
        'Col_NB_REP_TOTAL
        '
        Me.Col_NB_REP_TOTAL.Caption = "NB_REP_TOTAL"
        Me.Col_NB_REP_TOTAL.FieldName = "NB_REP_TOTAL"
        Me.Col_NB_REP_TOTAL.Name = "Col_NB_REP_TOTAL"
        '
        'Col_PC_REP_OK
        '
        Me.Col_PC_REP_OK.AppearanceCell.Options.UseTextOptions = True
        Me.Col_PC_REP_OK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_PC_REP_OK.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Col_PC_REP_OK.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Col_PC_REP_OK.AppearanceHeader.Options.UseForeColor = True
        Me.Col_PC_REP_OK.Caption = "% réponse correcte"
        Me.Col_PC_REP_OK.DisplayFormat.FormatString = "p2"
        Me.Col_PC_REP_OK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Col_PC_REP_OK.FieldName = "PC_REP_OK"
        Me.Col_PC_REP_OK.Name = "Col_PC_REP_OK"
        Me.Col_PC_REP_OK.OptionsColumn.AllowEdit = False
        Me.Col_PC_REP_OK.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "PC_REP_OK", "{0:p2}")})
        Me.Col_PC_REP_OK.Visible = True
        Me.Col_PC_REP_OK.VisibleIndex = 5
        Me.Col_PC_REP_OK.Width = 68
        '
        'Col_PC_REP_NOK
        '
        Me.Col_PC_REP_NOK.AppearanceCell.Options.UseTextOptions = True
        Me.Col_PC_REP_NOK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_PC_REP_NOK.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Col_PC_REP_NOK.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Col_PC_REP_NOK.AppearanceHeader.Options.UseForeColor = True
        Me.Col_PC_REP_NOK.Caption = "% réponse incorrecte"
        Me.Col_PC_REP_NOK.DisplayFormat.FormatString = "p2"
        Me.Col_PC_REP_NOK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Col_PC_REP_NOK.FieldName = "PC_REP_NOK"
        Me.Col_PC_REP_NOK.Name = "Col_PC_REP_NOK"
        Me.Col_PC_REP_NOK.OptionsColumn.AllowEdit = False
        Me.Col_PC_REP_NOK.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "PC_REP_NOK", "{0:p2}")})
        Me.Col_PC_REP_NOK.Visible = True
        Me.Col_PC_REP_NOK.VisibleIndex = 6
        Me.Col_PC_REP_NOK.Width = 68
        '
        'Col_PC_NO
        '
        Me.Col_PC_NO.AppearanceCell.Options.UseTextOptions = True
        Me.Col_PC_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_PC_NO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Col_PC_NO.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Col_PC_NO.AppearanceHeader.Options.UseForeColor = True
        Me.Col_PC_NO.Caption = "% non réponse"
        Me.Col_PC_NO.DisplayFormat.FormatString = "p2"
        Me.Col_PC_NO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Col_PC_NO.FieldName = "PC_NO"
        Me.Col_PC_NO.Name = "Col_PC_NO"
        Me.Col_PC_NO.OptionsColumn.AllowEdit = False
        Me.Col_PC_NO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "PC_NO", "{0:p2}")})
        Me.Col_PC_NO.Visible = True
        Me.Col_PC_NO.VisibleIndex = 7
        Me.Col_PC_NO.Width = 74
        '
        'LblTitre
        '
        Me.LblTitre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(117, 9)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(1176, 29)
        Me.LblTitre.TabIndex = 54
        Me.LblTitre.Text = "Titre du QCM"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnExportXLSX)
        Me.GroupBox1.Controls.Add(Me.BtnResultatsByQCM)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(99, 653)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'BtnExportXLSX
        '
        Me.BtnExportXLSX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnExportXLSX.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnExportXLSX.Location = New System.Drawing.Point(6, 299)
        Me.BtnExportXLSX.Name = "BtnExportXLSX"
        Me.BtnExportXLSX.Size = New System.Drawing.Size(87, 55)
        Me.BtnExportXLSX.TabIndex = 10
        Me.BtnExportXLSX.Text = "Export XLSX"
        Me.BtnExportXLSX.UseVisualStyleBackColor = True
        '
        'BtnResultatsByQCM
        '
        Me.BtnResultatsByQCM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnResultatsByQCM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnResultatsByQCM.Location = New System.Drawing.Point(6, 150)
        Me.BtnResultatsByQCM.Name = "BtnResultatsByQCM"
        Me.BtnResultatsByQCM.Size = New System.Drawing.Size(87, 55)
        Me.BtnResultatsByQCM.TabIndex = 9
        Me.BtnResultatsByQCM.Text = "Résultats QCM Technicien"
        Me.BtnResultatsByQCM.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(7, 590)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblQCMTXRep)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.LblQCMRenseign)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.LblQCMAffect)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(122, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1171, 106)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        '
        'LblQCMTXRep
        '
        Me.LblQCMTXRep.BackColor = System.Drawing.Color.White
        Me.LblQCMTXRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblQCMTXRep.Location = New System.Drawing.Point(432, 37)
        Me.LblQCMTXRep.Name = "LblQCMTXRep"
        Me.LblQCMTXRep.Size = New System.Drawing.Size(121, 23)
        Me.LblQCMTXRep.TabIndex = 9
        Me.LblQCMTXRep.Text = "0"
        Me.LblQCMTXRep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(326, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Taux de réponse : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblQCMRenseign
        '
        Me.LblQCMRenseign.BackColor = System.Drawing.Color.White
        Me.LblQCMRenseign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblQCMRenseign.Location = New System.Drawing.Point(135, 60)
        Me.LblQCMRenseign.Name = "LblQCMRenseign"
        Me.LblQCMRenseign.Size = New System.Drawing.Size(121, 23)
        Me.LblQCMRenseign.TabIndex = 7
        Me.LblQCMRenseign.Text = "0"
        Me.LblQCMRenseign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(29, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "QCM renseigné : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblQCMAffect
        '
        Me.LblQCMAffect.BackColor = System.Drawing.Color.White
        Me.LblQCMAffect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblQCMAffect.Location = New System.Drawing.Point(135, 21)
        Me.LblQCMAffect.Name = "LblQCMAffect"
        Me.LblQCMAffect.Size = New System.Drawing.Size(121, 23)
        Me.LblQCMAffect.TabIndex = 2
        Me.LblQCMAffect.Text = "0"
        Me.LblQCMAffect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(29, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QCM affecté : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChartAna
        '
        Me.ChartAna.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.AxisX.Label.Angle = -45
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Label.TextPattern = "{V:0%}"
        XyDiagram1.AxisY.Title.Text = "(%)"
        XyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisualRange.Auto = False
        XyDiagram1.AxisY.VisualRange.AutoSideMargins = False
        XyDiagram1.AxisY.VisualRange.EndSideMargin = 0.01R
        XyDiagram1.AxisY.VisualRange.MaxValueSerializable = "1"
        XyDiagram1.AxisY.VisualRange.MinValueSerializable = "0"
        XyDiagram1.AxisY.VisualRange.StartSideMargin = 0.01R
        XyDiagram1.AxisY.WholeRange.Auto = False
        XyDiagram1.AxisY.WholeRange.AutoSideMargins = False
        XyDiagram1.AxisY.WholeRange.EndSideMargin = 0.01R
        XyDiagram1.AxisY.WholeRange.MaxValueSerializable = "1"
        XyDiagram1.AxisY.WholeRange.MinValueSerializable = "0"
        XyDiagram1.AxisY.WholeRange.StartSideMargin = 0.01R
        Me.ChartAna.Diagram = XyDiagram1
        Me.ChartAna.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.ChartAna.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
        Me.ChartAna.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.ChartAna.Legend.EquallySpacedItems = False
        Me.ChartAna.Legend.Name = "Default Legend"
        Me.ChartAna.Location = New System.Drawing.Point(1309, 159)
        Me.ChartAna.Name = "ChartAna"
        Series1.ArgumentDataMember = "NIDQUESTION"
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel1.TextPattern = "{V:N0}"
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LegendName = "Default Legend"
        Series1.LegendTextPattern = "% résponse correcte"
        Series1.Name = "SerOK"
        Series1.ValueDataMembersSerializable = "PC_REP_OK"
        SideBySideBarSeriesView1.Color = System.Drawing.Color.Lime
        Series1.View = SideBySideBarSeriesView1
        Series2.ArgumentDataMember = "NIDQUESTION"
        Series2.LegendTextPattern = "% résponse incorrecte"
        Series2.Name = "SerNOK"
        Series2.ValueDataMembersSerializable = "PC_REP_NOK"
        SideBySideBarSeriesView2.Color = System.Drawing.Color.Red
        Series2.View = SideBySideBarSeriesView2
        Series3.ArgumentDataMember = "NIDQUESTION"
        Series3.LegendTextPattern = "% non résponse"
        Series3.Name = "SerNO"
        Series3.ValueDataMembersSerializable = "PC_NO"
        SideBySideBarSeriesView3.Color = System.Drawing.Color.Gray
        Series3.View = SideBySideBarSeriesView3
        Me.ChartAna.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2, Series3}
        SideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartAna.SeriesTemplate.Label = SideBySideBarSeriesLabel2
        Me.ChartAna.Size = New System.Drawing.Size(790, 732)
        Me.ChartAna.TabIndex = 56
        '
        'frmQCMAnalyseResultat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(2111, 974)
        Me.Controls.Add(Me.ChartAna)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GCListeQuest)
        Me.Name = "frmQCMAnalyseResultat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QCM - Analyse des résultats"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCListeQuest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeQuest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartAna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents GCListeQuest As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeQuest As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Col_NIDQUESTION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_NQCMQUESTIONORDER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_VQUESTIONLIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_NB_REP_OK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_NB_REP_NOK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_NB_REP_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LblTitre As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Col_NB_REP_TOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_PC_REP_OK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_PC_REP_NOK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_PC_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LblQCMAffect As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblQCMTXRep As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblQCMRenseign As Label
    Friend WithEvents Label2 As Label
    Private WithEvents ChartAna As DevExpress.XtraCharts.ChartControl
    Friend WithEvents BtnResultatsByQCM As Button
    Friend WithEvents BtnExportXLSX As Button
    Friend WithEvents SDF As SaveFileDialog
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemHyperLinkEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemHyperLinkEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
End Class
