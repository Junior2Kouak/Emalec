<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListePlanPrevTechApprob
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListePlanPrevTechApprob))
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.btnVisualiser = New System.Windows.Forms.Button()
    Me.BtnQuit = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.GCLSTPLANPREV = New DevExpress.XtraGrid.GridControl()
    Me.GVLSTPLANPREV = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GCol_VTYPPROCLIB = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColVSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColVTITRE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColDPROCTECHAPPROBSIGN = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.VFICHIER = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColIPROCTECHAPPROBSIGN = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepItemGLUpEditGTPLot = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
    Me.RepIGLUpEditViewLot = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.ColLOTIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColLOTNGTPLOTID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColLOTVGTPLOTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepItemGLUpEditUnite = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
    Me.RepItemGLUpEditViewUnite = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.ColUNITEIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColUNITENGTPUNITEID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColUNITEVGTPUNITENOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
    Me.BtValider = New System.Windows.Forms.Button()
    Me.BtnDate2 = New System.Windows.Forms.Button()
    Me.txtDtFin = New System.Windows.Forms.TextBox()
    Me.BtnDate1 = New System.Windows.Forms.Button()
    Me.txtDtDebut = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.BtnExportXLS = New System.Windows.Forms.Button()
    Me.SFD = New System.Windows.Forms.SaveFileDialog()
    Me.GrpActions.SuspendLayout()
    CType(Me.GCLSTPLANPREV, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GVLSTPLANPREV, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GrpActions
    '
    Me.GrpActions.Controls.Add(Me.BtnExportXLS)
    Me.GrpActions.Controls.Add(Me.btnVisualiser)
    Me.GrpActions.Controls.Add(Me.BtnQuit)
    resources.ApplyResources(Me.GrpActions, "GrpActions")
    Me.GrpActions.Name = "GrpActions"
    Me.GrpActions.TabStop = False
    '
    'btnVisualiser
    '
    resources.ApplyResources(Me.btnVisualiser, "btnVisualiser")
    Me.btnVisualiser.Name = "btnVisualiser"
    Me.btnVisualiser.UseVisualStyleBackColor = True
    '
    'BtnQuit
    '
    resources.ApplyResources(Me.BtnQuit, "BtnQuit")
    Me.BtnQuit.Name = "BtnQuit"
    Me.BtnQuit.UseVisualStyleBackColor = True
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.Name = "Label1"
    '
    'GCLSTPLANPREV
    '
    resources.ApplyResources(Me.GCLSTPLANPREV, "GCLSTPLANPREV")
    Me.GCLSTPLANPREV.MainView = Me.GVLSTPLANPREV
    Me.GCLSTPLANPREV.Name = "GCLSTPLANPREV"
    Me.GCLSTPLANPREV.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemGLUpEditGTPLot, Me.RepItemGLUpEditUnite})
    Me.GCLSTPLANPREV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVLSTPLANPREV})
    '
    'GVLSTPLANPREV
    '
    Me.GVLSTPLANPREV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
    Me.GVLSTPLANPREV.Appearance.ColumnFilterButton.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
    Me.GVLSTPLANPREV.Appearance.ColumnFilterButton.Options.UseForeColor = True
    Me.GVLSTPLANPREV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
    Me.GVLSTPLANPREV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
    Me.GVLSTPLANPREV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
    Me.GVLSTPLANPREV.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVLSTPLANPREV.Appearance.Empty.BackColor2"), System.Drawing.Color)
    Me.GVLSTPLANPREV.Appearance.Empty.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
    Me.GVLSTPLANPREV.Appearance.EvenRow.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.EvenRow.Options.UseBorderColor = True
    Me.GVLSTPLANPREV.Appearance.EvenRow.Options.UseForeColor = True
    Me.GVLSTPLANPREV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
    Me.GVLSTPLANPREV.Appearance.FilterCloseButton.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.FilterCloseButton.Options.UseBorderColor = True
    Me.GVLSTPLANPREV.Appearance.FilterCloseButton.Options.UseForeColor = True
    Me.GVLSTPLANPREV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVLSTPLANPREV.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
    Me.GVLSTPLANPREV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
    Me.GVLSTPLANPREV.Appearance.FilterPanel.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.FilterPanel.Options.UseForeColor = True
    Me.GVLSTPLANPREV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.FixedLine.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
    Me.GVLSTPLANPREV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
    Me.GVLSTPLANPREV.Appearance.FocusedCell.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.FocusedCell.Options.UseForeColor = True
    Me.GVLSTPLANPREV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
    Me.GVLSTPLANPREV.Appearance.FocusedRow.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.FocusedRow.Options.UseForeColor = True
    Me.GVLSTPLANPREV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
    Me.GVLSTPLANPREV.Appearance.FooterPanel.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.FooterPanel.Options.UseBorderColor = True
    Me.GVLSTPLANPREV.Appearance.FooterPanel.Options.UseForeColor = True
    Me.GVLSTPLANPREV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.GroupButton.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.GroupButton.Options.UseBorderColor = True
    Me.GVLSTPLANPREV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
    Me.GVLSTPLANPREV.Appearance.GroupFooter.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.GroupFooter.Options.UseBorderColor = True
    Me.GVLSTPLANPREV.Appearance.GroupFooter.Options.UseForeColor = True
    Me.GVLSTPLANPREV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVLSTPLANPREV.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
    Me.GVLSTPLANPREV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
    Me.GVLSTPLANPREV.Appearance.GroupPanel.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.GroupPanel.Options.UseForeColor = True
    Me.GVLSTPLANPREV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
    Me.GVLSTPLANPREV.Appearance.GroupRow.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.GroupRow.Options.UseBorderColor = True
    Me.GVLSTPLANPREV.Appearance.GroupRow.Options.UseForeColor = True
    Me.GVLSTPLANPREV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVLSTPLANPREV.Appearance.HeaderPanel.Font"), System.Drawing.Font)
    Me.GVLSTPLANPREV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
    Me.GVLSTPLANPREV.Appearance.HeaderPanel.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.HeaderPanel.Options.UseBorderColor = True
    Me.GVLSTPLANPREV.Appearance.HeaderPanel.Options.UseFont = True
    Me.GVLSTPLANPREV.Appearance.HeaderPanel.Options.UseForeColor = True
    Me.GVLSTPLANPREV.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.GVLSTPLANPREV.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GVLSTPLANPREV.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GVLSTPLANPREV.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.GVLSTPLANPREV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.HideSelectionRow.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.HideSelectionRow.Options.UseForeColor = True
    Me.GVLSTPLANPREV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.HorzLine.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.HorzLine.Options.UseBorderColor = True
    Me.GVLSTPLANPREV.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
    Me.GVLSTPLANPREV.Appearance.OddRow.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.OddRow.Options.UseBorderColor = True
    Me.GVLSTPLANPREV.Appearance.OddRow.Options.UseForeColor = True
    Me.GVLSTPLANPREV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.Preview.Font = CType(resources.GetObject("GVLSTPLANPREV.Appearance.Preview.Font"), System.Drawing.Font)
    Me.GVLSTPLANPREV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.Preview.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.Preview.Options.UseFont = True
    Me.GVLSTPLANPREV.Appearance.Preview.Options.UseForeColor = True
    Me.GVLSTPLANPREV.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.Row.ForeColor = System.Drawing.Color.Black
    Me.GVLSTPLANPREV.Appearance.Row.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.Row.Options.UseForeColor = True
    Me.GVLSTPLANPREV.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVLSTPLANPREV.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
    Me.GVLSTPLANPREV.Appearance.RowSeparator.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
    Me.GVLSTPLANPREV.Appearance.SelectedRow.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.SelectedRow.Options.UseForeColor = True
    Me.GVLSTPLANPREV.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
    Me.GVLSTPLANPREV.Appearance.TopNewRow.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
    Me.GVLSTPLANPREV.Appearance.VertLine.Options.UseBackColor = True
    Me.GVLSTPLANPREV.Appearance.VertLine.Options.UseBorderColor = True
    Me.GVLSTPLANPREV.ColumnPanelRowHeight = 50
    Me.GVLSTPLANPREV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_VTYPPROCLIB, Me.ColVCLINOM, Me.ColVSITNOM, Me.ColVTITRE, Me.ColVPERNOM, Me.ColDPROCTECHAPPROBSIGN, Me.VFICHIER, Me.ColIPROCTECHAPPROBSIGN})
    Me.GVLSTPLANPREV.GridControl = Me.GCLSTPLANPREV
    Me.GVLSTPLANPREV.Name = "GVLSTPLANPREV"
    Me.GVLSTPLANPREV.OptionsBehavior.Editable = False
    Me.GVLSTPLANPREV.OptionsNavigation.AutoFocusNewRow = True
    Me.GVLSTPLANPREV.OptionsView.EnableAppearanceEvenRow = True
    Me.GVLSTPLANPREV.OptionsView.EnableAppearanceOddRow = True
    Me.GVLSTPLANPREV.OptionsView.ShowAutoFilterRow = True
    Me.GVLSTPLANPREV.OptionsView.ShowFooter = True
    Me.GVLSTPLANPREV.OptionsView.ShowGroupPanel = False
    Me.GVLSTPLANPREV.RowHeight = 20
    '
    'GCol_VTYPPROCLIB
    '
    resources.ApplyResources(Me.GCol_VTYPPROCLIB, "GCol_VTYPPROCLIB")
    Me.GCol_VTYPPROCLIB.FieldName = "VTYPPROCLIB"
    Me.GCol_VTYPPROCLIB.Name = "GCol_VTYPPROCLIB"
    '
    'ColVCLINOM
    '
    resources.ApplyResources(Me.ColVCLINOM, "ColVCLINOM")
    Me.ColVCLINOM.FieldName = "VCLINOM"
    Me.ColVCLINOM.Name = "ColVCLINOM"
    Me.ColVCLINOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'ColVSITNOM
    '
    Me.ColVSITNOM.AppearanceCell.Options.UseTextOptions = True
    Me.ColVSITNOM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    resources.ApplyResources(Me.ColVSITNOM, "ColVSITNOM")
    Me.ColVSITNOM.FieldName = "VSITNOM"
    Me.ColVSITNOM.Name = "ColVSITNOM"
    Me.ColVSITNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'ColVTITRE
    '
    resources.ApplyResources(Me.ColVTITRE, "ColVTITRE")
    Me.ColVTITRE.FieldName = "VTITRE"
    Me.ColVTITRE.Name = "ColVTITRE"
    '
    'ColVPERNOM
    '
    Me.ColVPERNOM.AppearanceCell.Options.UseTextOptions = True
    Me.ColVPERNOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.ColVPERNOM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    resources.ApplyResources(Me.ColVPERNOM, "ColVPERNOM")
    Me.ColVPERNOM.FieldName = "VPERNOM"
    Me.ColVPERNOM.Name = "ColVPERNOM"
    Me.ColVPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'ColDPROCTECHAPPROBSIGN
    '
    Me.ColDPROCTECHAPPROBSIGN.AppearanceCell.Options.UseTextOptions = True
    Me.ColDPROCTECHAPPROBSIGN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.ColDPROCTECHAPPROBSIGN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    resources.ApplyResources(Me.ColDPROCTECHAPPROBSIGN, "ColDPROCTECHAPPROBSIGN")
    Me.ColDPROCTECHAPPROBSIGN.FieldName = "DPROCTECHAPPROBSIGN"
    Me.ColDPROCTECHAPPROBSIGN.Name = "ColDPROCTECHAPPROBSIGN"
    Me.ColDPROCTECHAPPROBSIGN.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'VFICHIER
    '
    resources.ApplyResources(Me.VFICHIER, "VFICHIER")
    Me.VFICHIER.FieldName = "VFICHIER"
    Me.VFICHIER.Name = "VFICHIER"
    '
    'ColIPROCTECHAPPROBSIGN
    '
    resources.ApplyResources(Me.ColIPROCTECHAPPROBSIGN, "ColIPROCTECHAPPROBSIGN")
    Me.ColIPROCTECHAPPROBSIGN.FieldName = "IPROCTECHAPPROBSIGN"
    Me.ColIPROCTECHAPPROBSIGN.Name = "ColIPROCTECHAPPROBSIGN"
    '
    'RepItemGLUpEditGTPLot
    '
    resources.ApplyResources(Me.RepItemGLUpEditGTPLot, "RepItemGLUpEditGTPLot")
    Me.RepItemGLUpEditGTPLot.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemGLUpEditGTPLot.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.RepItemGLUpEditGTPLot.DisplayMember = "VGTPLOTNOM"
    Me.RepItemGLUpEditGTPLot.Name = "RepItemGLUpEditGTPLot"
    Me.RepItemGLUpEditGTPLot.PopupView = Me.RepIGLUpEditViewLot
    Me.RepItemGLUpEditGTPLot.ValueMember = "NGTPLOTID"
    '
    'RepIGLUpEditViewLot
    '
    Me.RepIGLUpEditViewLot.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColLOTIDTMP, Me.ColLOTNGTPLOTID, Me.ColLOTVGTPLOTNOM})
    Me.RepIGLUpEditViewLot.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.RepIGLUpEditViewLot.Name = "RepIGLUpEditViewLot"
    Me.RepIGLUpEditViewLot.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.RepIGLUpEditViewLot.OptionsView.ShowGroupPanel = False
    '
    'ColLOTIDTMP
    '
    resources.ApplyResources(Me.ColLOTIDTMP, "ColLOTIDTMP")
    Me.ColLOTIDTMP.FieldName = "IDTMP"
    Me.ColLOTIDTMP.Name = "ColLOTIDTMP"
    '
    'ColLOTNGTPLOTID
    '
    resources.ApplyResources(Me.ColLOTNGTPLOTID, "ColLOTNGTPLOTID")
    Me.ColLOTNGTPLOTID.FieldName = "NGTPLOTID"
    Me.ColLOTNGTPLOTID.Name = "ColLOTNGTPLOTID"
    '
    'ColLOTVGTPLOTNOM
    '
    resources.ApplyResources(Me.ColLOTVGTPLOTNOM, "ColLOTVGTPLOTNOM")
    Me.ColLOTVGTPLOTNOM.FieldName = "VGTPLOTNOM"
    Me.ColLOTVGTPLOTNOM.Name = "ColLOTVGTPLOTNOM"
    '
    'RepItemGLUpEditUnite
    '
    resources.ApplyResources(Me.RepItemGLUpEditUnite, "RepItemGLUpEditUnite")
    Me.RepItemGLUpEditUnite.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemGLUpEditUnite.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.RepItemGLUpEditUnite.DisplayMember = "VGTPUNITENOM"
    Me.RepItemGLUpEditUnite.Name = "RepItemGLUpEditUnite"
    Me.RepItemGLUpEditUnite.PopupView = Me.RepItemGLUpEditViewUnite
    Me.RepItemGLUpEditUnite.ValueMember = "NGTPUNITEID"
    '
    'RepItemGLUpEditViewUnite
    '
    Me.RepItemGLUpEditViewUnite.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColUNITEIDTMP, Me.ColUNITENGTPUNITEID, Me.ColUNITEVGTPUNITENOM})
    Me.RepItemGLUpEditViewUnite.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.RepItemGLUpEditViewUnite.Name = "RepItemGLUpEditViewUnite"
    Me.RepItemGLUpEditViewUnite.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.RepItemGLUpEditViewUnite.OptionsView.ShowGroupPanel = False
    '
    'ColUNITEIDTMP
    '
    resources.ApplyResources(Me.ColUNITEIDTMP, "ColUNITEIDTMP")
    Me.ColUNITEIDTMP.FieldName = "IDTMP"
    Me.ColUNITEIDTMP.Name = "ColUNITEIDTMP"
    '
    'ColUNITENGTPUNITEID
    '
    resources.ApplyResources(Me.ColUNITENGTPUNITEID, "ColUNITENGTPUNITEID")
    Me.ColUNITENGTPUNITEID.FieldName = "NGTPUNITEID"
    Me.ColUNITENGTPUNITEID.Name = "ColUNITENGTPUNITEID"
    '
    'ColUNITEVGTPUNITENOM
    '
    resources.ApplyResources(Me.ColUNITEVGTPUNITENOM, "ColUNITEVGTPUNITENOM")
    Me.ColUNITEVGTPUNITENOM.FieldName = "VGTPUNITENOM"
    Me.ColUNITEVGTPUNITENOM.Name = "ColUNITEVGTPUNITENOM"
    '
    'MonthCalendar1
    '
    resources.ApplyResources(Me.MonthCalendar1, "MonthCalendar1")
    Me.MonthCalendar1.Name = "MonthCalendar1"
    '
    'BtValider
    '
    resources.ApplyResources(Me.BtValider, "BtValider")
    Me.BtValider.Name = "BtValider"
    Me.BtValider.UseVisualStyleBackColor = True
    '
    'BtnDate2
    '
    Me.BtnDate2.Image = Global.MozartNet.My.Resources.Resources.choix_calendrier
    resources.ApplyResources(Me.BtnDate2, "BtnDate2")
    Me.BtnDate2.Name = "BtnDate2"
    Me.BtnDate2.UseVisualStyleBackColor = True
    '
    'txtDtFin
    '
    resources.ApplyResources(Me.txtDtFin, "txtDtFin")
    Me.txtDtFin.Name = "txtDtFin"
    '
    'BtnDate1
    '
    Me.BtnDate1.Image = Global.MozartNet.My.Resources.Resources.choix_calendrier
    resources.ApplyResources(Me.BtnDate1, "BtnDate1")
    Me.BtnDate1.Name = "BtnDate1"
    Me.BtnDate1.UseVisualStyleBackColor = True
    '
    'txtDtDebut
    '
    resources.ApplyResources(Me.txtDtDebut, "txtDtDebut")
    Me.txtDtDebut.Name = "txtDtDebut"
    '
    'Label3
    '
    resources.ApplyResources(Me.Label3, "Label3")
    Me.Label3.Name = "Label3"
    '
    'Label2
    '
    resources.ApplyResources(Me.Label2, "Label2")
    Me.Label2.Name = "Label2"
    '
    'Label4
    '
    resources.ApplyResources(Me.Label4, "Label4")
    Me.Label4.Name = "Label4"
    '
    'BtnExportXLS
    '
    resources.ApplyResources(Me.BtnExportXLS, "BtnExportXLS")
    Me.BtnExportXLS.Name = "BtnExportXLS"
    Me.BtnExportXLS.Tag = ""
    Me.BtnExportXLS.UseVisualStyleBackColor = True
    '
    'frmListePlanPrevTechApprob
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.Controls.Add(Me.MonthCalendar1)
    Me.Controls.Add(Me.BtValider)
    Me.Controls.Add(Me.BtnDate2)
    Me.Controls.Add(Me.txtDtFin)
    Me.Controls.Add(Me.BtnDate1)
    Me.Controls.Add(Me.txtDtDebut)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.GrpActions)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.GCLSTPLANPREV)
    Me.Name = "frmListePlanPrevTechApprob"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.GrpActions.ResumeLayout(False)
    CType(Me.GCLSTPLANPREV, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GVLSTPLANPREV, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVisualiser As System.Windows.Forms.Button
    Private WithEvents GCLSTPLANPREV As DevExpress.XtraGrid.GridControl
    Private WithEvents GVLSTPLANPREV As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColDPROCTECHAPPROBSIGN As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemGLUpEditGTPLot As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepIGLUpEditViewLot As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColLOTIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColLOTNGTPLOTID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColLOTVGTPLOTNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemGLUpEditUnite As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepItemGLUpEditViewUnite As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColUNITEIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColUNITENGTPUNITEID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColUNITEVGTPUNITENOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVTITRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VFICHIER As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColIPROCTECHAPPROBSIGN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents BtValider As Button
    Friend WithEvents BtnDate2 As Button
    Friend WithEvents txtDtFin As TextBox
    Friend WithEvents BtnDate1 As Button
    Friend WithEvents txtDtDebut As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GCol_VTYPPROCLIB As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BtnExportXLS As Button
  Friend WithEvents SFD As SaveFileDialog
End Class
