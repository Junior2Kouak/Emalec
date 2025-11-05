<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifODBilanAnnuel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModifODBilanAnnuel))
        Me.GCODBilanAnnuel = New DevExpress.XtraGrid.GridControl()
        Me.GVODBILANANNUEL = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNIDODBILAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNCANNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNMONTANT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TextEditNMONTANT = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ColVODBILAN_COM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TextEditVCOMMENTAIRE = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GrpCriteres = New System.Windows.Forms.GroupBox()
        Me.CboAnnee = New System.Windows.Forms.ComboBox()
        Me.LblTitre = New System.Windows.Forms.Label()
        CType(Me.GCODBilanAnnuel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVODBILANANNUEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditNMONTANT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditVCOMMENTAIRE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.GrpCriteres.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCODBilanAnnuel
        '
        resources.ApplyResources(Me.GCODBilanAnnuel, "GCODBilanAnnuel")
        Me.GCODBilanAnnuel.MainView = Me.GVODBILANANNUEL
        Me.GCODBilanAnnuel.Name = "GCODBilanAnnuel"
        Me.GCODBilanAnnuel.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.TextEditNMONTANT, Me.TextEditVCOMMENTAIRE})
        Me.GCODBilanAnnuel.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVODBILANANNUEL})
        '
        'GVODBILANANNUEL
        '
        Me.GVODBILANANNUEL.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVODBILANANNUEL.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVODBILANANNUEL.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVODBILANANNUEL.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVODBILANANNUEL.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVODBILANANNUEL.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVODBILANANNUEL.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVODBILANANNUEL.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVODBILANANNUEL.Appearance.Empty.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVODBILANANNUEL.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVODBILANANNUEL.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVODBILANANNUEL.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVODBILANANNUEL.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVODBILANANNUEL.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVODBILANANNUEL.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVODBILANANNUEL.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVODBILANANNUEL.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVODBILANANNUEL.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVODBILANANNUEL.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVODBILANANNUEL.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVODBILANANNUEL.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVODBILANANNUEL.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVODBILANANNUEL.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVODBILANANNUEL.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVODBILANANNUEL.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVODBILANANNUEL.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVODBILANANNUEL.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVODBILANANNUEL.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVODBILANANNUEL.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVODBILANANNUEL.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVODBILANANNUEL.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVODBILANANNUEL.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVODBILANANNUEL.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVODBILANANNUEL.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVODBILANANNUEL.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVODBILANANNUEL.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVODBILANANNUEL.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVODBILANANNUEL.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVODBILANANNUEL.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVODBILANANNUEL.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVODBILANANNUEL.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVODBILANANNUEL.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVODBILANANNUEL.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVODBILANANNUEL.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVODBILANANNUEL.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVODBILANANNUEL.Appearance.OddRow.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVODBILANANNUEL.Appearance.OddRow.Options.UseForeColor = True
        Me.GVODBILANANNUEL.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.Preview.Font = CType(resources.GetObject("GVODBILANANNUEL.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVODBILANANNUEL.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.Preview.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.Preview.Options.UseFont = True
        Me.GVODBILANANNUEL.Appearance.Preview.Options.UseForeColor = True
        Me.GVODBILANANNUEL.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVODBILANANNUEL.Appearance.Row.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.Row.Options.UseForeColor = True
        Me.GVODBILANANNUEL.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVODBILANANNUEL.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVODBILANANNUEL.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVODBILANANNUEL.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GVODBILANANNUEL.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVODBILANANNUEL.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVODBILANANNUEL.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVODBILANANNUEL.Appearance.VertLine.Options.UseBackColor = True
        Me.GVODBILANANNUEL.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNIDODBILAN, Me.ColNCANNUM, Me.ColNMONTANT, Me.ColVODBILAN_COM})
        Me.GVODBILANANNUEL.GridControl = Me.GCODBilanAnnuel
        Me.GVODBILANANNUEL.Name = "GVODBILANANNUEL"
        Me.GVODBILANANNUEL.OptionsView.EnableAppearanceEvenRow = True
        Me.GVODBILANANNUEL.OptionsView.EnableAppearanceOddRow = True
        Me.GVODBILANANNUEL.OptionsView.ShowFooter = True
        Me.GVODBILANANNUEL.OptionsView.ShowGroupPanel = False
        '
        'ColNIDODBILAN
        '
        resources.ApplyResources(Me.ColNIDODBILAN, "ColNIDODBILAN")
        Me.ColNIDODBILAN.FieldName = "NIDODBILAN"
        Me.ColNIDODBILAN.Name = "ColNIDODBILAN"
        Me.ColNIDODBILAN.OptionsColumn.AllowEdit = False
        Me.ColNIDODBILAN.OptionsColumn.ReadOnly = True
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
        'ColNMONTANT
        '
        Me.ColNMONTANT.AppearanceHeader.Font = CType(resources.GetObject("ColNMONTANT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColNMONTANT.AppearanceHeader.Options.UseFont = True
        Me.ColNMONTANT.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNMONTANT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNMONTANT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColNMONTANT, "ColNMONTANT")
        Me.ColNMONTANT.ColumnEdit = Me.TextEditNMONTANT
        Me.ColNMONTANT.DisplayFormat.FormatString = "d0"
        Me.ColNMONTANT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColNMONTANT.FieldName = "NMONTANT"
        Me.ColNMONTANT.Name = "ColNMONTANT"
        Me.ColNMONTANT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColNMONTANT.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColNMONTANT.Summary1"), resources.GetString("ColNMONTANT.Summary2"))})
        '
        'TextEditNMONTANT
        '
        Me.TextEditNMONTANT.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        resources.ApplyResources(Me.TextEditNMONTANT, "TextEditNMONTANT")
        Me.TextEditNMONTANT.Name = "TextEditNMONTANT"
        '
        'ColVODBILAN_COM
        '
        Me.ColVODBILAN_COM.AppearanceHeader.Font = CType(resources.GetObject("ColVODBILAN_COM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColVODBILAN_COM.AppearanceHeader.Options.UseFont = True
        Me.ColVODBILAN_COM.AppearanceHeader.Options.UseTextOptions = True
        Me.ColVODBILAN_COM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVODBILAN_COM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColVODBILAN_COM, "ColVODBILAN_COM")
        Me.ColVODBILAN_COM.FieldName = "VODBILAN_COM"
        Me.ColVODBILAN_COM.Name = "ColVODBILAN_COM"
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
        'GrpCriteres
        '
        Me.GrpCriteres.Controls.Add(Me.CboAnnee)
        resources.ApplyResources(Me.GrpCriteres, "GrpCriteres")
        Me.GrpCriteres.Name = "GrpCriteres"
        Me.GrpCriteres.TabStop = False
        '
        'CboAnnee
        '
        Me.CboAnnee.FormattingEnabled = True
        resources.ApplyResources(Me.CboAnnee, "CboAnnee")
        Me.CboAnnee.Name = "CboAnnee"
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'frmModifODBilanAnnuel
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpCriteres)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GCODBilanAnnuel)
        Me.Name = "frmModifODBilanAnnuel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCODBilanAnnuel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVODBILANANNUEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditNMONTANT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditVCOMMENTAIRE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.GrpCriteres.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents GrpCriteres As System.Windows.Forms.GroupBox
    Friend WithEvents CboAnnee As System.Windows.Forms.ComboBox
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Private WithEvents GCODBilanAnnuel As DevExpress.XtraGrid.GridControl
    Private WithEvents GVODBILANANNUEL As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColNCANNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TextEditNMONTANT As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Private WithEvents ColNMONTANT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TextEditVCOMMENTAIRE As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Private WithEvents ColNIDODBILAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColVODBILAN_COM As DevExpress.XtraGrid.Columns.GridColumn
End Class
