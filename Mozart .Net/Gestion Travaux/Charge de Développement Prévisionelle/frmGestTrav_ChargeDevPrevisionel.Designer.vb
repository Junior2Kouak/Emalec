<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestTrav_ChargeDevPrevisionel
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
    Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
    Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
    Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
    Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
    Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
    Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
    Dim GridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
    Dim FormatConditionRuleValue4 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
    Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
    Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Me.GColNDCLREUSSITEPOURC = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColDACTDAT = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCCHARGEDEV = New DevExpress.XtraGrid.GridControl()
    Me.GVCHARGEDEV = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GColNACTNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColNDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVDINACTID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVACTTITLE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColNDCLHT = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColDACTDATMOD = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVACTOBS = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.BtnQuit = New System.Windows.Forms.Button()
    Me.ChartChargeDevPrev = New DevExpress.XtraCharts.ChartControl()
    Me.GrpFilter = New System.Windows.Forms.GroupBox()
    Me.BtnValider = New System.Windows.Forms.Button()
    Me.Label25 = New System.Windows.Forms.Label()
    Me.Label26 = New System.Windows.Forms.Label()
    Me.DTPFin = New System.Windows.Forms.DateTimePicker()
    Me.DTPDebut = New System.Windows.Forms.DateTimePicker()
        CType(Me.GCCHARGEDEV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCHARGEDEV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        CType(Me.ChartChargeDevPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'GColNDCLREUSSITEPOURC
        '
        Me.GColNDCLREUSSITEPOURC.Caption = "% de chances de réussite"
        Me.GColNDCLREUSSITEPOURC.FieldName = "NDCLREUSSITEPOURC"
        Me.GColNDCLREUSSITEPOURC.Name = "GColNDCLREUSSITEPOURC"
        Me.GColNDCLREUSSITEPOURC.OptionsColumn.AllowEdit = False
        Me.GColNDCLREUSSITEPOURC.OptionsColumn.ReadOnly = True
        Me.GColNDCLREUSSITEPOURC.Visible = True
        Me.GColNDCLREUSSITEPOURC.VisibleIndex = 6
        Me.GColNDCLREUSSITEPOURC.Width = 85
        '
        'GColDACTDAT
        '
        Me.GColDACTDAT.Caption = "Date prévisionelle travaux"
        Me.GColDACTDAT.FieldName = "DACTDAT"
        Me.GColDACTDAT.Name = "GColDACTDAT"
        Me.GColDACTDAT.OptionsColumn.AllowEdit = False
        Me.GColDACTDAT.OptionsColumn.ReadOnly = True
        Me.GColDACTDAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColDACTDAT.Visible = True
        Me.GColDACTDAT.VisibleIndex = 1
        Me.GColDACTDAT.Width = 90
        '
        'GCCHARGEDEV
        '
        Me.GCCHARGEDEV.Location = New System.Drawing.Point(141, 45)
        Me.GCCHARGEDEV.MainView = Me.GVCHARGEDEV
        Me.GCCHARGEDEV.Name = "GCCHARGEDEV"
        Me.GCCHARGEDEV.Size = New System.Drawing.Size(950, 711)
        Me.GCCHARGEDEV.TabIndex = 8
        Me.GCCHARGEDEV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVCHARGEDEV})
        '
        'GVCHARGEDEV
        '
        Me.GVCHARGEDEV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEV.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVCHARGEDEV.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVCHARGEDEV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVCHARGEDEV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVCHARGEDEV.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVCHARGEDEV.Appearance.Empty.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEV.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVCHARGEDEV.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVCHARGEDEV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEV.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVCHARGEDEV.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVCHARGEDEV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVCHARGEDEV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEV.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVCHARGEDEV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVCHARGEDEV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEV.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVCHARGEDEV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVCHARGEDEV.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVCHARGEDEV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEV.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVCHARGEDEV.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVCHARGEDEV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVCHARGEDEV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVCHARGEDEV.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVCHARGEDEV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVCHARGEDEV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEV.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVCHARGEDEV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEV.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVCHARGEDEV.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVCHARGEDEV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GVCHARGEDEV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVCHARGEDEV.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVCHARGEDEV.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVCHARGEDEV.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVCHARGEDEV.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVCHARGEDEV.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVCHARGEDEV.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVCHARGEDEV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEV.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVCHARGEDEV.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVCHARGEDEV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEV.Appearance.OddRow.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVCHARGEDEV.Appearance.OddRow.Options.UseForeColor = True
        Me.GVCHARGEDEV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVCHARGEDEV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.Preview.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.Preview.Options.UseFont = True
        Me.GVCHARGEDEV.Appearance.Preview.Options.UseForeColor = True
        Me.GVCHARGEDEV.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEV.Appearance.Row.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.Row.Options.UseForeColor = True
        Me.GVCHARGEDEV.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVCHARGEDEV.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GVCHARGEDEV.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVCHARGEDEV.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVCHARGEDEV.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVCHARGEDEV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVCHARGEDEV.Appearance.VertLine.Options.UseBackColor = True
        Me.GVCHARGEDEV.ColumnPanelRowHeight = 60
        Me.GVCHARGEDEV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNACTNUM, Me.GColNDINNUM, Me.GColVDINACTID, Me.GColDACTDAT, Me.GColVCLINOM, Me.GColVSITNOM, Me.GColVACTTITLE, Me.GColNDCLHT, Me.GColNDCLREUSSITEPOURC, Me.GColVPERNOM, Me.GColDACTDATMOD, Me.GColVACTOBS})
        GridFormatRule1.Column = Me.GColNDCLREUSSITEPOURC
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.Red
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue1.Expression = "[NDCLREUSSITEPOURC] < 30 And ([NDCLREUSSITEPOURC] Is Null) = False"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.Column = Me.GColNDCLREUSSITEPOURC
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.Yellow
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue2.Expression = "[NDCLREUSSITEPOURC] >= 30 And [NDCLREUSSITEPOURC] < 60"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        GridFormatRule3.Column = Me.GColNDCLREUSSITEPOURC
        GridFormatRule3.Name = "Format2"
        FormatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.LimeGreen
        FormatConditionRuleValue3.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue3.Expression = "[NDCLREUSSITEPOURC] > 74"
        GridFormatRule3.Rule = FormatConditionRuleValue3
        GridFormatRule4.ApplyToRow = True
        GridFormatRule4.Column = Me.GColDACTDAT
        GridFormatRule4.Name = "Format3"
        FormatConditionRuleValue4.Appearance.ForeColor = System.Drawing.Color.Red
        FormatConditionRuleValue4.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue4.Expression = "[DACTDAT] < LocalDateTimeToday()"
        GridFormatRule4.Rule = FormatConditionRuleValue4
        Me.GVCHARGEDEV.FormatRules.Add(GridFormatRule1)
        Me.GVCHARGEDEV.FormatRules.Add(GridFormatRule2)
        Me.GVCHARGEDEV.FormatRules.Add(GridFormatRule3)
        Me.GVCHARGEDEV.FormatRules.Add(GridFormatRule4)
        Me.GVCHARGEDEV.GridControl = Me.GCCHARGEDEV
        Me.GVCHARGEDEV.Name = "GVCHARGEDEV"
        Me.GVCHARGEDEV.OptionsBehavior.Editable = False
        Me.GVCHARGEDEV.OptionsNavigation.AutoFocusNewRow = True
        Me.GVCHARGEDEV.OptionsView.EnableAppearanceOddRow = True
        Me.GVCHARGEDEV.OptionsView.ShowAutoFilterRow = True
        Me.GVCHARGEDEV.OptionsView.ShowFooter = True
        Me.GVCHARGEDEV.OptionsView.ShowGroupPanel = False
        Me.GVCHARGEDEV.RowHeight = 20
        '
        'GColNACTNUM
        '
        Me.GColNACTNUM.Caption = "NACTNUM"
        Me.GColNACTNUM.FieldName = "NACTNUM"
        Me.GColNACTNUM.Name = "GColNACTNUM"
        '
        'GColNDINNUM
        '
        Me.GColNDINNUM.Caption = "NDINNUM"
        Me.GColNDINNUM.FieldName = "NDINNUM"
        Me.GColNDINNUM.Name = "GColNDINNUM"
        '
        'GColVDINACTID
        '
        Me.GColVDINACTID.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline)
        Me.GColVDINACTID.AppearanceCell.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GColVDINACTID.AppearanceCell.Options.UseFont = True
        Me.GColVDINACTID.AppearanceCell.Options.UseForeColor = True
        Me.GColVDINACTID.Caption = "DI / Action"
        Me.GColVDINACTID.FieldName = "VDINACTID"
        Me.GColVDINACTID.Name = "GColVDINACTID"
        Me.GColVDINACTID.OptionsColumn.ReadOnly = True
        Me.GColVDINACTID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVDINACTID.Visible = True
        Me.GColVDINACTID.VisibleIndex = 0
        Me.GColVDINACTID.Width = 54
        '
        'GColVCLINOM
        '
        Me.GColVCLINOM.Caption = "Client"
        Me.GColVCLINOM.FieldName = "VCLINOM"
        Me.GColVCLINOM.Name = "GColVCLINOM"
        Me.GColVCLINOM.OptionsColumn.AllowEdit = False
        Me.GColVCLINOM.OptionsColumn.ReadOnly = True
        Me.GColVCLINOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVCLINOM.Visible = True
        Me.GColVCLINOM.VisibleIndex = 2
        Me.GColVCLINOM.Width = 92
        '
        'GColVSITNOM
        '
        Me.GColVSITNOM.Caption = "Site"
        Me.GColVSITNOM.FieldName = "VSITNOM"
        Me.GColVSITNOM.Name = "GColVSITNOM"
        Me.GColVSITNOM.OptionsColumn.AllowEdit = False
        Me.GColVSITNOM.OptionsColumn.ReadOnly = True
        Me.GColVSITNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVSITNOM.Visible = True
        Me.GColVSITNOM.VisibleIndex = 3
        Me.GColVSITNOM.Width = 92
        '
        'GColVACTTITLE
        '
        Me.GColVACTTITLE.Caption = "Prestation"
        Me.GColVACTTITLE.FieldName = "VACTTITLE"
        Me.GColVACTTITLE.Name = "GColVACTTITLE"
        Me.GColVACTTITLE.OptionsColumn.AllowEdit = False
        Me.GColVACTTITLE.OptionsColumn.ReadOnly = True
        Me.GColVACTTITLE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVACTTITLE.Visible = True
        Me.GColVACTTITLE.VisibleIndex = 4
        Me.GColVACTTITLE.Width = 136
        '
        'GColNDCLHT
        '
        Me.GColNDCLHT.Caption = "Montant prévisionnel HT"
        Me.GColNDCLHT.DisplayFormat.FormatString = "c0"
        Me.GColNDCLHT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GColNDCLHT.FieldName = "NDCLHT"
        Me.GColNDCLHT.Name = "GColNDCLHT"
        Me.GColNDCLHT.OptionsColumn.AllowEdit = False
        Me.GColNDCLHT.OptionsColumn.ReadOnly = True
        Me.GColNDCLHT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColNDCLHT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NDCLHT", "{0:c0}")})
        Me.GColNDCLHT.Visible = True
        Me.GColNDCLHT.VisibleIndex = 5
        Me.GColNDCLHT.Width = 90
        '
        'GColVPERNOM
        '
        Me.GColVPERNOM.Caption = "Chargé d'affaires"
        Me.GColVPERNOM.FieldName = "VPERCHAFFNOM"
        Me.GColVPERNOM.Name = "GColVPERNOM"
        Me.GColVPERNOM.OptionsColumn.AllowEdit = False
        Me.GColVPERNOM.OptionsColumn.ReadOnly = True
        Me.GColVPERNOM.Visible = True
        Me.GColVPERNOM.VisibleIndex = 7
        Me.GColVPERNOM.Width = 71
        '
        'GColDACTDATMOD
        '
        Me.GColDACTDATMOD.Caption = "Date dernière modification"
        Me.GColDACTDATMOD.DisplayFormat.FormatString = "d"
        Me.GColDACTDATMOD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GColDACTDATMOD.FieldName = "DACTDATMOD"
        Me.GColDACTDATMOD.Name = "GColDACTDATMOD"
        Me.GColDACTDATMOD.OptionsColumn.AllowEdit = False
        Me.GColDACTDATMOD.OptionsColumn.ReadOnly = True
        Me.GColDACTDATMOD.Visible = True
        Me.GColDACTDATMOD.VisibleIndex = 8
        Me.GColDACTDATMOD.Width = 78
        '
        'GColVACTOBS
        '
        Me.GColVACTOBS.Caption = "Commentaires"
        Me.GColVACTOBS.FieldName = "VACTOBS"
        Me.GColVACTOBS.Name = "GColVACTOBS"
        Me.GColVACTOBS.OptionsColumn.AllowEdit = False
        Me.GColVACTOBS.OptionsColumn.ReadOnly = True
        Me.GColVACTOBS.Visible = True
        Me.GColVACTOBS.VisibleIndex = 9
        Me.GColVACTOBS.Width = 144
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(141, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(993, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Charge de développement prévisionnel - Tous Corps d'Etat"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Location = New System.Drawing.Point(12, 12)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(123, 744)
        Me.GrpActions.TabIndex = 9
        Me.GrpActions.TabStop = False
        '
        'BtnQuit
        '
        Me.BtnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnQuit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnQuit.Location = New System.Drawing.Point(6, 682)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(108, 45)
        Me.BtnQuit.TabIndex = 1
        Me.BtnQuit.Text = "Fermer"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'ChartChargeDevPrev
        '
        XyDiagram1.AxisX.Label.Angle = 270
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Title.Text = "Montant HT en €"
        XyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartChargeDevPrev.Diagram = XyDiagram1
        Me.ChartChargeDevPrev.Legend.Name = "Default Legend"
        Me.ChartChargeDevPrev.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartChargeDevPrev.Location = New System.Drawing.Point(1109, 132)
        Me.ChartChargeDevPrev.Name = "ChartChargeDevPrev"
        Series1.ArgumentDataMember = "AXE_X"
        Series1.Name = "Series 1"
        Series1.ValueDataMembersSerializable = "TOTAL_NDCLHT"
        Me.ChartChargeDevPrev.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.ChartChargeDevPrev.Size = New System.Drawing.Size(671, 607)
        Me.ChartChargeDevPrev.TabIndex = 11
        '
        'GrpFilter
        '
        Me.GrpFilter.Controls.Add(Me.BtnValider)
        Me.GrpFilter.Controls.Add(Me.Label25)
        Me.GrpFilter.Controls.Add(Me.Label26)
        Me.GrpFilter.Controls.Add(Me.DTPFin)
        Me.GrpFilter.Controls.Add(Me.DTPDebut)
        Me.GrpFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GrpFilter.Location = New System.Drawing.Point(1109, 45)
        Me.GrpFilter.Name = "GrpFilter"
        Me.GrpFilter.Size = New System.Drawing.Size(671, 64)
        Me.GrpFilter.TabIndex = 129
        Me.GrpFilter.TabStop = False
        Me.GrpFilter.Text = "Période de date prévisionelle travaux"
        '
        'BtnValider
        '
        Me.BtnValider.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnValider.Location = New System.Drawing.Point(556, 16)
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.Size = New System.Drawing.Size(105, 36)
        Me.BtnValider.TabIndex = 8
        Me.BtnValider.Text = "Valider"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(286, 25)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 27)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Au"
        '
        'Label26
        '
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(14, 26)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(33, 27)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Du"
        '
        'DTPFin
        '
        Me.DTPFin.Location = New System.Drawing.Point(325, 23)
        Me.DTPFin.Name = "DTPFin"
        Me.DTPFin.Size = New System.Drawing.Size(225, 22)
        Me.DTPFin.TabIndex = 5
        '
        'DTPDebut
        '
        Me.DTPDebut.Location = New System.Drawing.Point(52, 23)
        Me.DTPDebut.Name = "DTPDebut"
        Me.DTPDebut.Size = New System.Drawing.Size(228, 22)
        Me.DTPDebut.TabIndex = 4
        '
        'frmGestTrav_ChargeDevPrevisionel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(2410, 1048)
        Me.Controls.Add(Me.GrpFilter)
        Me.Controls.Add(Me.ChartChargeDevPrev)
        Me.Controls.Add(Me.GCCHARGEDEV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmGestTrav_ChargeDevPrevisionel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charge de développement prévisionnel - Groupe Aménagement TCE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCCHARGEDEV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCHARGEDEV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartChargeDevPrev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpFilter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents GCCHARGEDEV As DevExpress.XtraGrid.GridControl
    Private WithEvents GVCHARGEDEV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnQuit As Button
    Friend WithEvents ChartChargeDevPrev As DevExpress.XtraCharts.ChartControl
    Friend WithEvents GColNACTNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVDINACTID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColDACTDAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVACTTITLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNDCLHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNDCLREUSSITEPOURC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColDACTDATMOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVACTOBS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrpFilter As GroupBox
    Friend WithEvents BtnValider As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents DTPFin As DateTimePicker
    Friend WithEvents DTPDebut As DateTimePicker
End Class
