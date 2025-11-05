<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestionRevisionPrixCFoClients
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
        Me.GColTYPEPRIX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCOEFF_ART = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNPUHTCLI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpBoxLstFO = New System.Windows.Forms.GroupBox()
        Me.GCGestCliFOPrix = New DevExpress.XtraGrid.GridControl()
        Me.GVGestCliFOPrix = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVFOUMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVFOUMAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVFOUTYP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVFOUREF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNFOUNBLOT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNBUTIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColFPUHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNFOUNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEditBCLITECHCOCHE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnDelFO = New System.Windows.Forms.Button()
        Me.BtnRevisePrix = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnExportXLS = New System.Windows.Forms.Button()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.GrpBoxLstFO.SuspendLayout()
        CType(Me.GCGestCliFOPrix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVGestCliFOPrix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEditBCLITECHCOCHE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GColTYPEPRIX
        '
        Me.GColTYPEPRIX.Caption = "TYPEPRIX"
        Me.GColTYPEPRIX.FieldName = "TYPEPRIX"
        Me.GColTYPEPRIX.Name = "GColTYPEPRIX"
        '
        'GColCOEFF_ART
        '
        Me.GColCOEFF_ART.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.GColCOEFF_ART.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GColCOEFF_ART.AppearanceCell.Options.UseBackColor = True
        Me.GColCOEFF_ART.AppearanceCell.Options.UseFont = True
        Me.GColCOEFF_ART.Caption = "Coeff"
        Me.GColCOEFF_ART.DisplayFormat.FormatString = "n2"
        Me.GColCOEFF_ART.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColCOEFF_ART.FieldName = "COEFF_ART"
        Me.GColCOEFF_ART.Name = "GColCOEFF_ART"
        Me.GColCOEFF_ART.OptionsColumn.AllowEdit = False
        Me.GColCOEFF_ART.OptionsColumn.ReadOnly = True
        Me.GColCOEFF_ART.Visible = True
        Me.GColCOEFF_ART.VisibleIndex = 8
        Me.GColCOEFF_ART.Width = 104
        '
        'GColNPUHTCLI
        '
        Me.GColNPUHTCLI.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.GColNPUHTCLI.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GColNPUHTCLI.AppearanceCell.Options.UseBackColor = True
        Me.GColNPUHTCLI.AppearanceCell.Options.UseFont = True
        Me.GColNPUHTCLI.Caption = "Prix Client"
        Me.GColNPUHTCLI.DisplayFormat.FormatString = "c2"
        Me.GColNPUHTCLI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GColNPUHTCLI.FieldName = "NPUHTCLI"
        Me.GColNPUHTCLI.Name = "GColNPUHTCLI"
        Me.GColNPUHTCLI.OptionsColumn.AllowEdit = False
        Me.GColNPUHTCLI.OptionsColumn.ReadOnly = True
        Me.GColNPUHTCLI.Visible = True
        Me.GColNPUHTCLI.VisibleIndex = 9
        Me.GColNPUHTCLI.Width = 129
        '
        'LblTitre
        '
        Me.LblTitre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(144, 9)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(831, 29)
        Me.LblTitre.TabIndex = 28
        Me.LblTitre.Text = "Liste des prix clients des articles"
        '
        'GrpBoxLstFO
        '
        Me.GrpBoxLstFO.Controls.Add(Me.GCGestCliFOPrix)
        Me.GrpBoxLstFO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GrpBoxLstFO.Location = New System.Drawing.Point(149, 46)
        Me.GrpBoxLstFO.Name = "GrpBoxLstFO"
        Me.GrpBoxLstFO.Size = New System.Drawing.Size(1474, 790)
        Me.GrpBoxLstFO.TabIndex = 27
        Me.GrpBoxLstFO.TabStop = False
        Me.GrpBoxLstFO.Text = "Liste des articles"
        '
        'GCGestCliFOPrix
        '
        Me.GCGestCliFOPrix.Location = New System.Drawing.Point(6, 21)
        Me.GCGestCliFOPrix.MainView = Me.GVGestCliFOPrix
        Me.GCGestCliFOPrix.Name = "GCGestCliFOPrix"
        Me.GCGestCliFOPrix.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEditBCLITECHCOCHE})
        Me.GCGestCliFOPrix.Size = New System.Drawing.Size(1462, 763)
        Me.GCGestCliFOPrix.TabIndex = 18
        Me.GCGestCliFOPrix.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVGestCliFOPrix})
        '
        'GVGestCliFOPrix
        '
        Me.GVGestCliFOPrix.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliFOPrix.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVGestCliFOPrix.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVGestCliFOPrix.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliFOPrix.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVGestCliFOPrix.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVGestCliFOPrix.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVGestCliFOPrix.Appearance.Empty.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliFOPrix.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVGestCliFOPrix.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVGestCliFOPrix.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliFOPrix.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVGestCliFOPrix.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVGestCliFOPrix.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVGestCliFOPrix.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliFOPrix.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVGestCliFOPrix.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliFOPrix.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVGestCliFOPrix.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVGestCliFOPrix.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVGestCliFOPrix.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliFOPrix.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVGestCliFOPrix.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVGestCliFOPrix.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVGestCliFOPrix.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliFOPrix.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVGestCliFOPrix.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliFOPrix.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVGestCliFOPrix.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVGestCliFOPrix.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GVGestCliFOPrix.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliFOPrix.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVGestCliFOPrix.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVGestCliFOPrix.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVGestCliFOPrix.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVGestCliFOPrix.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVGestCliFOPrix.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVGestCliFOPrix.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVGestCliFOPrix.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVGestCliFOPrix.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliFOPrix.Appearance.OddRow.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVGestCliFOPrix.Appearance.OddRow.Options.UseForeColor = True
        Me.GVGestCliFOPrix.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVGestCliFOPrix.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.Preview.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.Preview.Options.UseFont = True
        Me.GVGestCliFOPrix.Appearance.Preview.Options.UseForeColor = True
        Me.GVGestCliFOPrix.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GVGestCliFOPrix.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliFOPrix.Appearance.Row.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.Row.Options.UseFont = True
        Me.GVGestCliFOPrix.Appearance.Row.Options.UseForeColor = True
        Me.GVGestCliFOPrix.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVGestCliFOPrix.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVGestCliFOPrix.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVGestCliFOPrix.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVGestCliFOPrix.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVGestCliFOPrix.Appearance.VertLine.Options.UseBackColor = True
        Me.GVGestCliFOPrix.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVGestCliFOPrix.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColVCLINOM, Me.GColVFOUMAT, Me.GColVFOUMAR, Me.GColVFOUTYP, Me.GColVFOUREF, Me.GColNFOUNBLOT, Me.GColNBUTIL, Me.GColFPUHT, Me.GColCOEFF_ART, Me.GColNPUHTCLI, Me.GColNFOUNUM, Me.GColNCLINUM, Me.GColTYPEPRIX})
        GridFormatRule1.Column = Me.GColTYPEPRIX
        GridFormatRule1.ColumnApplyTo = Me.GColCOEFF_ART
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Value1 = "B"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.Column = Me.GColTYPEPRIX
        GridFormatRule2.ColumnApplyTo = Me.GColCOEFF_ART
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.Red
        FormatConditionRuleValue2.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Value1 = "C"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        GridFormatRule3.Column = Me.GColTYPEPRIX
        GridFormatRule3.ColumnApplyTo = Me.GColNPUHTCLI
        GridFormatRule3.Name = "Format2"
        FormatConditionRuleValue3.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleValue3.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue3.Value1 = "B"
        GridFormatRule3.Rule = FormatConditionRuleValue3
        GridFormatRule4.Column = Me.GColTYPEPRIX
        GridFormatRule4.ColumnApplyTo = Me.GColNPUHTCLI
        GridFormatRule4.Name = "Format3"
        FormatConditionRuleValue4.Appearance.ForeColor = System.Drawing.Color.Red
        FormatConditionRuleValue4.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue4.Value1 = "C"
        GridFormatRule4.Rule = FormatConditionRuleValue4
        Me.GVGestCliFOPrix.FormatRules.Add(GridFormatRule1)
        Me.GVGestCliFOPrix.FormatRules.Add(GridFormatRule2)
        Me.GVGestCliFOPrix.FormatRules.Add(GridFormatRule3)
        Me.GVGestCliFOPrix.FormatRules.Add(GridFormatRule4)
        Me.GVGestCliFOPrix.GridControl = Me.GCGestCliFOPrix
        Me.GVGestCliFOPrix.Name = "GVGestCliFOPrix"
        Me.GVGestCliFOPrix.OptionsBehavior.ReadOnly = True
        Me.GVGestCliFOPrix.OptionsView.EnableAppearanceEvenRow = True
        Me.GVGestCliFOPrix.OptionsView.EnableAppearanceOddRow = True
        Me.GVGestCliFOPrix.OptionsView.ShowAutoFilterRow = True
        Me.GVGestCliFOPrix.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVGestCliFOPrix.OptionsView.ShowFooter = True
        Me.GVGestCliFOPrix.OptionsView.ShowGroupPanel = False
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
        Me.GColVCLINOM.VisibleIndex = 0
        Me.GColVCLINOM.Width = 240
        '
        'GColVFOUMAT
        '
        Me.GColVFOUMAT.Caption = "Matériel"
        Me.GColVFOUMAT.FieldName = "VFOUMAT"
        Me.GColVFOUMAT.Name = "GColVFOUMAT"
        Me.GColVFOUMAT.OptionsColumn.AllowEdit = False
        Me.GColVFOUMAT.OptionsColumn.ReadOnly = True
        Me.GColVFOUMAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVFOUMAT.Visible = True
        Me.GColVFOUMAT.VisibleIndex = 1
        Me.GColVFOUMAT.Width = 255
        '
        'GColVFOUMAR
        '
        Me.GColVFOUMAR.Caption = "Marque"
        Me.GColVFOUMAR.FieldName = "VFOUMAR"
        Me.GColVFOUMAR.Name = "GColVFOUMAR"
        Me.GColVFOUMAR.OptionsColumn.AllowEdit = False
        Me.GColVFOUMAR.OptionsColumn.ReadOnly = True
        Me.GColVFOUMAR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVFOUMAR.Visible = True
        Me.GColVFOUMAR.VisibleIndex = 2
        Me.GColVFOUMAR.Width = 150
        '
        'GColVFOUTYP
        '
        Me.GColVFOUTYP.Caption = "Type"
        Me.GColVFOUTYP.FieldName = "VFOUTYP"
        Me.GColVFOUTYP.Name = "GColVFOUTYP"
        Me.GColVFOUTYP.OptionsColumn.AllowEdit = False
        Me.GColVFOUTYP.OptionsColumn.ReadOnly = True
        Me.GColVFOUTYP.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVFOUTYP.Visible = True
        Me.GColVFOUTYP.VisibleIndex = 3
        Me.GColVFOUTYP.Width = 150
        '
        'GColVFOUREF
        '
        Me.GColVFOUREF.Caption = "Référence"
        Me.GColVFOUREF.FieldName = "VFOUREF"
        Me.GColVFOUREF.Name = "GColVFOUREF"
        Me.GColVFOUREF.OptionsColumn.AllowEdit = False
        Me.GColVFOUREF.OptionsColumn.FixedWidth = True
        Me.GColVFOUREF.Visible = True
        Me.GColVFOUREF.VisibleIndex = 4
        Me.GColVFOUREF.Width = 104
        '
        'GColNFOUNBLOT
        '
        Me.GColNFOUNBLOT.Caption = "PCB"
        Me.GColNFOUNBLOT.FieldName = "NFOUNBLOT"
        Me.GColNFOUNBLOT.Name = "GColNFOUNBLOT"
        Me.GColNFOUNBLOT.OptionsColumn.AllowEdit = False
        Me.GColNFOUNBLOT.OptionsColumn.FixedWidth = True
        Me.GColNFOUNBLOT.Visible = True
        Me.GColNFOUNBLOT.VisibleIndex = 5
        Me.GColNFOUNBLOT.Width = 104
        '
        'GColNBUTIL
        '
        Me.GColNBUTIL.Caption = "Conso"
        Me.GColNBUTIL.FieldName = "NBUTIL"
        Me.GColNBUTIL.Name = "GColNBUTIL"
        Me.GColNBUTIL.OptionsColumn.AllowEdit = False
        Me.GColNBUTIL.OptionsColumn.ReadOnly = True
        Me.GColNBUTIL.Visible = True
        Me.GColNBUTIL.VisibleIndex = 6
        Me.GColNBUTIL.Width = 104
        '
        'GColFPUHT
        '
        Me.GColFPUHT.Caption = "Prix"
        Me.GColFPUHT.DisplayFormat.FormatString = "c2"
        Me.GColFPUHT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GColFPUHT.FieldName = "FPUHT"
        Me.GColFPUHT.Name = "GColFPUHT"
        Me.GColFPUHT.OptionsColumn.AllowEdit = False
        Me.GColFPUHT.OptionsColumn.ReadOnly = True
        Me.GColFPUHT.Visible = True
        Me.GColFPUHT.VisibleIndex = 7
        Me.GColFPUHT.Width = 104
        '
        'GColNFOUNUM
        '
        Me.GColNFOUNUM.Caption = "NFOUNUM"
        Me.GColNFOUNUM.FieldName = "NFOUNUM"
        Me.GColNFOUNUM.Name = "GColNFOUNUM"
        '
        'GColNCLINUM
        '
        Me.GColNCLINUM.Caption = "NCLINUM"
        Me.GColNCLINUM.FieldNameSortGroup = "NCLINUM"
        Me.GColNCLINUM.Name = "GColNCLINUM"
        '
        'RepositoryItemCheckEditBCLITECHCOCHE
        '
        Me.RepositoryItemCheckEditBCLITECHCOCHE.AutoHeight = False
        Me.RepositoryItemCheckEditBCLITECHCOCHE.Name = "RepositoryItemCheckEditBCLITECHCOCHE"
        Me.RepositoryItemCheckEditBCLITECHCOCHE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEditBCLITECHCOCHE.ValueChecked = 1
        Me.RepositoryItemCheckEditBCLITECHCOCHE.ValueUnchecked = 0
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnExportXLS)
        Me.GrpActions.Controls.Add(Me.BtnDelFO)
        Me.GrpActions.Controls.Add(Me.BtnRevisePrix)
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Location = New System.Drawing.Point(8, 5)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(120, 567)
        Me.GrpActions.TabIndex = 26
        Me.GrpActions.TabStop = False
        '
        'BtnDelFO
        '
        Me.BtnDelFO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnDelFO.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnDelFO.Location = New System.Drawing.Point(6, 261)
        Me.BtnDelFO.Name = "BtnDelFO"
        Me.BtnDelFO.Size = New System.Drawing.Size(108, 84)
        Me.BtnDelFO.TabIndex = 8
        Me.BtnDelFO.Text = "Supprimer cette FO de la liste des prix de vente de ce client"
        Me.BtnDelFO.UseVisualStyleBackColor = True
        '
        'BtnRevisePrix
        '
        Me.BtnRevisePrix.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnRevisePrix.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnRevisePrix.Location = New System.Drawing.Point(6, 123)
        Me.BtnRevisePrix.Name = "BtnRevisePrix"
        Me.BtnRevisePrix.Size = New System.Drawing.Size(108, 44)
        Me.BtnRevisePrix.TabIndex = 7
        Me.BtnRevisePrix.Text = "Révision des prix"
        Me.BtnRevisePrix.UseVisualStyleBackColor = True
        '
        'BtnQuit
        '
        Me.BtnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnQuit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnQuit.Location = New System.Drawing.Point(6, 503)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(108, 45)
        Me.BtnQuit.TabIndex = 6
        Me.BtnQuit.Text = "Fermer"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1387, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "En blanc : prix de la base * coefficient"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(1387, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "En rouge : prix client"
        '
        'BtnExportXLS
        '
        Me.BtnExportXLS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExportXLS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnExportXLS.Location = New System.Drawing.Point(6, 189)
        Me.BtnExportXLS.Name = "BtnExportXLS"
        Me.BtnExportXLS.Size = New System.Drawing.Size(108, 41)
        Me.BtnExportXLS.TabIndex = 10
        Me.BtnExportXLS.Tag = ""
        Me.BtnExportXLS.Text = "Exporter en EXCEL"
        Me.BtnExportXLS.UseVisualStyleBackColor = True
        '
        'frmGestionRevisionPrixCFoClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1635, 898)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpBoxLstFO)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmGestionRevisionPrixCFoClients"
        Me.Text = "Liste des prix clients des articles"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpBoxLstFO.ResumeLayout(False)
        CType(Me.GCGestCliFOPrix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVGestCliFOPrix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEditBCLITECHCOCHE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitre As Label
    Friend WithEvents GrpBoxLstFO As GroupBox
    Private WithEvents GCGestCliFOPrix As DevExpress.XtraGrid.GridControl
    Private WithEvents GVGestCliFOPrix As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents RepositoryItemCheckEditBCLITECHCOCHE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents GColVFOUMAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVFOUMAR As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVFOUTYP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnQuit As Button
    Friend WithEvents GColVFOUREF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNFOUNBLOT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNBUTIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColFPUHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColCOEFF_ART As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNPUHTCLI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNFOUNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnRevisePrix As Button
    Friend WithEvents BtnDelFO As Button
    Friend WithEvents GColTYPEPRIX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnExportXLS As Button
    Friend WithEvents SFD As SaveFileDialog
End Class
