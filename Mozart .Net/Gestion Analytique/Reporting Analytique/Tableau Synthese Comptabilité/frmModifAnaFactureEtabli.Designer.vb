<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifAnaFactureEtabli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModifAnaFactureEtabli))
        Me.GCANAFACTETABLI = New DevExpress.XtraGrid.GridControl()
        Me.GVANAFACTETABLI = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNIDANAFACETABLI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNCANNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNANAFACTEABLITOT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TextEditNMONTANT = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TextEditVCOMMENTAIRE = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.ColVANAFAC_COM = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GCANAFACTETABLI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVANAFACTETABLI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditNMONTANT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditVCOMMENTAIRE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCANAFACTETABLI
        '
        resources.ApplyResources(Me.GCANAFACTETABLI, "GCANAFACTETABLI")
        Me.GCANAFACTETABLI.MainView = Me.GVANAFACTETABLI
        Me.GCANAFACTETABLI.Name = "GCANAFACTETABLI"
        Me.GCANAFACTETABLI.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.TextEditNMONTANT, Me.TextEditVCOMMENTAIRE})
        Me.GCANAFACTETABLI.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVANAFACTETABLI})
        '
        'GVANAFACTETABLI
        '
        Me.GVANAFACTETABLI.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVANAFACTETABLI.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVANAFACTETABLI.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVANAFACTETABLI.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVANAFACTETABLI.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVANAFACTETABLI.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVANAFACTETABLI.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVANAFACTETABLI.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVANAFACTETABLI.Appearance.Empty.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVANAFACTETABLI.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVANAFACTETABLI.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVANAFACTETABLI.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVANAFACTETABLI.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVANAFACTETABLI.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVANAFACTETABLI.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVANAFACTETABLI.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVANAFACTETABLI.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVANAFACTETABLI.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVANAFACTETABLI.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVANAFACTETABLI.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVANAFACTETABLI.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVANAFACTETABLI.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVANAFACTETABLI.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVANAFACTETABLI.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVANAFACTETABLI.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVANAFACTETABLI.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVANAFACTETABLI.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVANAFACTETABLI.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVANAFACTETABLI.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVANAFACTETABLI.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVANAFACTETABLI.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVANAFACTETABLI.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVANAFACTETABLI.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVANAFACTETABLI.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVANAFACTETABLI.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVANAFACTETABLI.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVANAFACTETABLI.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVANAFACTETABLI.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVANAFACTETABLI.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVANAFACTETABLI.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVANAFACTETABLI.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVANAFACTETABLI.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVANAFACTETABLI.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVANAFACTETABLI.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVANAFACTETABLI.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVANAFACTETABLI.Appearance.OddRow.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVANAFACTETABLI.Appearance.OddRow.Options.UseForeColor = True
        Me.GVANAFACTETABLI.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.Preview.Font = CType(resources.GetObject("GVANAFACTETABLI.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVANAFACTETABLI.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.Preview.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.Preview.Options.UseFont = True
        Me.GVANAFACTETABLI.Appearance.Preview.Options.UseForeColor = True
        Me.GVANAFACTETABLI.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVANAFACTETABLI.Appearance.Row.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.Row.Options.UseForeColor = True
        Me.GVANAFACTETABLI.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVANAFACTETABLI.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVANAFACTETABLI.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVANAFACTETABLI.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GVANAFACTETABLI.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVANAFACTETABLI.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVANAFACTETABLI.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVANAFACTETABLI.Appearance.VertLine.Options.UseBackColor = True
        Me.GVANAFACTETABLI.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNIDANAFACETABLI, Me.ColNCANNUM, Me.ColNANAFACTEABLITOT, Me.ColVANAFAC_COM})
        Me.GVANAFACTETABLI.GridControl = Me.GCANAFACTETABLI
        Me.GVANAFACTETABLI.Name = "GVANAFACTETABLI"
        Me.GVANAFACTETABLI.OptionsView.EnableAppearanceEvenRow = True
        Me.GVANAFACTETABLI.OptionsView.EnableAppearanceOddRow = True
        Me.GVANAFACTETABLI.OptionsView.ShowFooter = True
        Me.GVANAFACTETABLI.OptionsView.ShowGroupPanel = False
        '
        'ColNIDANAFACETABLI
        '
        resources.ApplyResources(Me.ColNIDANAFACETABLI, "ColNIDANAFACETABLI")
        Me.ColNIDANAFACETABLI.FieldName = "NIDANAFACETABLI"
        Me.ColNIDANAFACETABLI.Name = "ColNIDANAFACETABLI"
        Me.ColNIDANAFACETABLI.OptionsColumn.AllowEdit = False
        Me.ColNIDANAFACETABLI.OptionsColumn.ReadOnly = True
        '
        'ColNCANNUM
        '
        Me.ColNCANNUM.AppearanceHeader.Font = CType(resources.GetObject("ColNCANNUM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColNCANNUM.AppearanceHeader.Options.UseFont = True
        Me.ColNCANNUM.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNCANNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNCANNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColNCANNUM, "ColNCANNUM")
        Me.ColNCANNUM.FieldName = "NCANNUM"
        Me.ColNCANNUM.Name = "ColNCANNUM"
        Me.ColNCANNUM.OptionsColumn.AllowEdit = False
        Me.ColNCANNUM.OptionsColumn.ReadOnly = True
        '
        'ColNANAFACTEABLITOT
        '
        Me.ColNANAFACTEABLITOT.AppearanceHeader.Font = CType(resources.GetObject("ColNANAFACTEABLITOT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColNANAFACTEABLITOT.AppearanceHeader.Options.UseFont = True
        Me.ColNANAFACTEABLITOT.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNANAFACTEABLITOT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNANAFACTEABLITOT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColNANAFACTEABLITOT, "ColNANAFACTEABLITOT")
        Me.ColNANAFACTEABLITOT.ColumnEdit = Me.TextEditNMONTANT
        Me.ColNANAFACTEABLITOT.DisplayFormat.FormatString = "{0:n0}"
        Me.ColNANAFACTEABLITOT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColNANAFACTEABLITOT.FieldName = "NANAFACTEABLITOT"
        Me.ColNANAFACTEABLITOT.Name = "ColNANAFACTEABLITOT"
        Me.ColNANAFACTEABLITOT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColNANAFACTEABLITOT.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColNANAFACTEABLITOT.Summary1"), resources.GetString("ColNANAFACTEABLITOT.Summary2"))})
        '
        'TextEditNMONTANT
        '
        Me.TextEditNMONTANT.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        resources.ApplyResources(Me.TextEditNMONTANT, "TextEditNMONTANT")
        Me.TextEditNMONTANT.Name = "TextEditNMONTANT"
        '
        'TextEditVCOMMENTAIRE
        '
        resources.ApplyResources(Me.TextEditVCOMMENTAIRE, "TextEditVCOMMENTAIRE")
        Me.TextEditVCOMMENTAIRE.MaxLength = 1000
        Me.TextEditVCOMMENTAIRE.Name = "TextEditVCOMMENTAIRE"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Controls.Add(Me.BtnSave)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnQuit
        '
        resources.ApplyResources(Me.BtnQuit, "BtnQuit")
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        resources.ApplyResources(Me.BtnSave, "BtnSave")
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'ColVANAFAC_COM
        '
        Me.ColVANAFAC_COM.AppearanceHeader.Font = CType(resources.GetObject("GridColumn1.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColVANAFAC_COM.AppearanceHeader.Options.UseFont = True
        Me.ColVANAFAC_COM.AppearanceHeader.Options.UseTextOptions = True
        Me.ColVANAFAC_COM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVANAFAC_COM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColVANAFAC_COM, "ColVANAFAC_COM")
        Me.ColVANAFAC_COM.FieldName = "VANAFAC_COM"
        Me.ColVANAFAC_COM.Name = "ColVANAFAC_COM"
        '
        'frmModifAnaFactureEtabli
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GCANAFACTETABLI)
        Me.Name = "frmModifAnaFactureEtabli"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCANAFACTETABLI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVANAFACTETABLI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditNMONTANT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditVCOMMENTAIRE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Private WithEvents GCANAFACTETABLI As DevExpress.XtraGrid.GridControl
    Private WithEvents GVANAFACTETABLI As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColNCANNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TextEditNMONTANT As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Private WithEvents ColNANAFACTEABLITOT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TextEditVCOMMENTAIRE As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Private WithEvents ColNIDANAFACETABLI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColVANAFAC_COM As DevExpress.XtraGrid.Columns.GridColumn
End Class
