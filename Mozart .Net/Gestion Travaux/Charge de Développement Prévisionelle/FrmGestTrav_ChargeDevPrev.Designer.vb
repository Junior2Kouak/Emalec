<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestTrav_ChargeDevPrev
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
        Me.GColNDCLREUSSITEPOURC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GCCHARGEDEVTCE = New DevExpress.XtraGrid.GridControl()
        Me.GVCHARGEDEVTCE = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNACTNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVDINACTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDACTDAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVACTTITLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNDCLHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDACTDATMOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVACTOBS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCCHARGEDEVTCE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCHARGEDEVTCE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GColNDCLREUSSITEPOURC
        '
        Me.GColNDCLREUSSITEPOURC.Caption = "% de chances de réussite"
        Me.GColNDCLREUSSITEPOURC.FieldName = "NDCLREUSSITEPOURC"
        Me.GColNDCLREUSSITEPOURC.Name = "GColNDCLREUSSITEPOURC"
        Me.GColNDCLREUSSITEPOURC.OptionsColumn.AllowEdit = False
        Me.GColNDCLREUSSITEPOURC.OptionsColumn.ReadOnly = True
        Me.GColNDCLREUSSITEPOURC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColNDCLREUSSITEPOURC.Visible = True
        Me.GColNDCLREUSSITEPOURC.VisibleIndex = 6
        Me.GColNDCLREUSSITEPOURC.Width = 109
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Location = New System.Drawing.Point(7, 9)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(123, 331)
        Me.GrpActions.TabIndex = 9
        Me.GrpActions.TabStop = False
        '
        'BtnQuit
        '
        Me.BtnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnQuit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnQuit.Location = New System.Drawing.Point(6, 272)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(108, 45)
        Me.BtnQuit.TabIndex = 1
        Me.BtnQuit.Text = "Fermer"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(136, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(993, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Charge de développement prévisionnel - Groupe Aménagement TCE"
        '
        'GCCHARGEDEVTCE
        '
        Me.GCCHARGEDEVTCE.Location = New System.Drawing.Point(136, 42)
        Me.GCCHARGEDEVTCE.MainView = Me.GVCHARGEDEVTCE
        Me.GCCHARGEDEVTCE.Name = "GCCHARGEDEVTCE"
        Me.GCCHARGEDEVTCE.Size = New System.Drawing.Size(1278, 711)
        Me.GCCHARGEDEVTCE.TabIndex = 8
        Me.GCCHARGEDEVTCE.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVCHARGEDEVTCE})
        '
        'GVCHARGEDEVTCE
        '
        Me.GVCHARGEDEVTCE.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEVTCE.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVCHARGEDEVTCE.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVCHARGEDEVTCE.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEVTCE.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVCHARGEDEVTCE.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVCHARGEDEVTCE.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVCHARGEDEVTCE.Appearance.Empty.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEVTCE.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVCHARGEDEVTCE.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVCHARGEDEVTCE.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEVTCE.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVCHARGEDEVTCE.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVCHARGEDEVTCE.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVCHARGEDEVTCE.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEVTCE.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVCHARGEDEVTCE.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVCHARGEDEVTCE.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEVTCE.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVCHARGEDEVTCE.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEVTCE.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVCHARGEDEVTCE.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVCHARGEDEVTCE.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEVTCE.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVCHARGEDEVTCE.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVCHARGEDEVTCE.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVCHARGEDEVTCE.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEVTCE.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVCHARGEDEVTCE.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVCHARGEDEVTCE.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVCHARGEDEVTCE.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEVTCE.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVCHARGEDEVTCE.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEVTCE.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVCHARGEDEVTCE.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVCHARGEDEVTCE.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GVCHARGEDEVTCE.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEVTCE.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVCHARGEDEVTCE.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVCHARGEDEVTCE.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVCHARGEDEVTCE.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVCHARGEDEVTCE.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVCHARGEDEVTCE.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVCHARGEDEVTCE.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVCHARGEDEVTCE.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEVTCE.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVCHARGEDEVTCE.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVCHARGEDEVTCE.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEVTCE.Appearance.OddRow.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVCHARGEDEVTCE.Appearance.OddRow.Options.UseForeColor = True
        Me.GVCHARGEDEVTCE.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVCHARGEDEVTCE.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.Preview.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.Preview.Options.UseFont = True
        Me.GVCHARGEDEVTCE.Appearance.Preview.Options.UseForeColor = True
        Me.GVCHARGEDEVTCE.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEVTCE.Appearance.Row.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.Row.Options.UseForeColor = True
        Me.GVCHARGEDEVTCE.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVCHARGEDEVTCE.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVCHARGEDEVTCE.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GVCHARGEDEVTCE.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVCHARGEDEVTCE.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVCHARGEDEVTCE.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVCHARGEDEVTCE.Appearance.VertLine.Options.UseBackColor = True
        Me.GVCHARGEDEVTCE.ColumnPanelRowHeight = 50
        Me.GVCHARGEDEVTCE.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNACTNUM, Me.GColNDINNUM, Me.GColVDINACTID, Me.GColDACTDAT, Me.GColVCLINOM, Me.GColVSITNOM, Me.GColVACTTITLE, Me.GColNDCLHT, Me.GColNDCLREUSSITEPOURC, Me.GColVPERNOM, Me.GColDACTDATMOD, Me.GColVACTOBS})
        Me.GVCHARGEDEVTCE.GridControl = Me.GCCHARGEDEVTCE
        Me.GVCHARGEDEVTCE.Name = "GVCHARGEDEVTCE"
        Me.GVCHARGEDEVTCE.OptionsBehavior.Editable = False
        Me.GVCHARGEDEVTCE.OptionsNavigation.AutoFocusNewRow = True
        Me.GVCHARGEDEVTCE.OptionsView.EnableAppearanceOddRow = True
        Me.GVCHARGEDEVTCE.OptionsView.ShowAutoFilterRow = True
        Me.GVCHARGEDEVTCE.OptionsView.ShowFooter = True
        Me.GVCHARGEDEVTCE.OptionsView.ShowGroupPanel = False
        Me.GVCHARGEDEVTCE.RowHeight = 20
        '
        'GColNACTNUM
        '
        Me.GColNACTNUM.FieldName = "NACTNUM"
        Me.GColNACTNUM.Name = "GColNACTNUM"
        '
        'GColNDINNUM
        '
        Me.GColNDINNUM.FieldName = "NDINNUM"
        Me.GColNDINNUM.Name = "GColNDINNUM"
        '
        'GColVDINACTID
        '
        Me.GColVDINACTID.Caption = "DI / Action"
        Me.GColVDINACTID.FieldName = "VDINACTID"
        Me.GColVDINACTID.Name = "GColVDINACTID"
        Me.GColVDINACTID.OptionsColumn.ReadOnly = True
        Me.GColVDINACTID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVDINACTID.Visible = True
        Me.GColVDINACTID.VisibleIndex = 0
        Me.GColVDINACTID.Width = 100
        '
        'GColDACTDAT
        '
        Me.GColDACTDAT.Caption = "Date prévisionnelle travaux"
        Me.GColDACTDAT.FieldName = "DACTDAT"
        Me.GColDACTDAT.Name = "GColDACTDAT"
        Me.GColDACTDAT.OptionsColumn.AllowEdit = False
        Me.GColDACTDAT.OptionsColumn.ReadOnly = True
        Me.GColDACTDAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColDACTDAT.Visible = True
        Me.GColDACTDAT.VisibleIndex = 1
        Me.GColDACTDAT.Width = 128
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
        Me.GColVCLINOM.Width = 128
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
        Me.GColVSITNOM.Width = 128
        '
        'GColVACTTITLE
        '
        Me.GColVACTTITLE.Caption = "Prestations"
        Me.GColVACTTITLE.FieldName = "VACTTITLE"
        Me.GColVACTTITLE.Name = "GColVACTTITLE"
        Me.GColVACTTITLE.OptionsColumn.AllowEdit = False
        Me.GColVACTTITLE.OptionsColumn.ReadOnly = True
        Me.GColVACTTITLE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVACTTITLE.Visible = True
        Me.GColVACTTITLE.VisibleIndex = 4
        Me.GColVACTTITLE.Width = 220
        '
        'GColNDCLHT
        '
        Me.GColNDCLHT.Caption = "Montant prévisionel HT"
        Me.GColNDCLHT.FieldName = "NDCLHT"
        Me.GColNDCLHT.Name = "GColNDCLHT"
        Me.GColNDCLHT.OptionsColumn.AllowEdit = False
        Me.GColNDCLHT.OptionsColumn.ReadOnly = True
        Me.GColNDCLHT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColNDCLHT.Visible = True
        Me.GColNDCLHT.VisibleIndex = 5
        Me.GColNDCLHT.Width = 109
        '
        'GColVPERNOM
        '
        Me.GColVPERNOM.Caption = "Créateur du devis"
        Me.GColVPERNOM.FieldName = "VPERNOM"
        Me.GColVPERNOM.Name = "GColVPERNOM"
        Me.GColVPERNOM.OptionsColumn.AllowEdit = False
        Me.GColVPERNOM.OptionsColumn.ReadOnly = True
        Me.GColVPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVPERNOM.Visible = True
        Me.GColVPERNOM.VisibleIndex = 7
        Me.GColVPERNOM.Width = 109
        '
        'GColDACTDATMOD
        '
        Me.GColDACTDATMOD.Caption = "Date dernierè modif action"
        Me.GColDACTDATMOD.FieldName = "DACTDATMOD"
        Me.GColDACTDATMOD.Name = "GColDACTDATMOD"
        Me.GColDACTDATMOD.OptionsColumn.AllowEdit = False
        Me.GColDACTDATMOD.OptionsColumn.ReadOnly = True
        Me.GColDACTDATMOD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColDACTDATMOD.Visible = True
        Me.GColDACTDATMOD.VisibleIndex = 8
        Me.GColDACTDATMOD.Width = 109
        '
        'GColVACTOBS
        '
        Me.GColVACTOBS.Caption = "Commentaires"
        Me.GColVACTOBS.FieldName = "VACTOBS"
        Me.GColVACTOBS.Name = "GColVACTOBS"
        Me.GColVACTOBS.OptionsColumn.AllowEdit = False
        Me.GColVACTOBS.OptionsColumn.ReadOnly = True
        Me.GColVACTOBS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVACTOBS.Visible = True
        Me.GColVACTOBS.VisibleIndex = 9
        Me.GColVACTOBS.Width = 120
        '
        'FrmGestTrav_ChargeDevPrev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(2089, 922)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GCCHARGEDEVTCE)
        Me.Name = "FrmGestTrav_ChargeDevPrev"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charge de développement prévisionnel - Groupe Aménagement TCE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCCHARGEDEVTCE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCHARGEDEVTCE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnQuit As Button
    Friend WithEvents Label1 As Label
    Private WithEvents GCCHARGEDEVTCE As DevExpress.XtraGrid.GridControl
    Private WithEvents GVCHARGEDEVTCE As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GColVDINACTID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColDACTDAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVACTTITLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNDCLHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNDCLREUSSITEPOURC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNACTNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColDACTDATMOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVACTOBS As DevExpress.XtraGrid.Columns.GridColumn

End Class
