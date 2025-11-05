<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeFormation
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeFormation))
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.BtnArchives = New System.Windows.Forms.Button()
    Me.BtnPrintAttest = New System.Windows.Forms.Button()
    Me.cmdHabilitation = New System.Windows.Forms.Button()
    Me.BtnExcel = New System.Windows.Forms.Button()
    Me.BtnImp = New System.Windows.Forms.Button()
    Me.BtnMod = New System.Windows.Forms.Button()
    Me.BtnGestOrg = New System.Windows.Forms.Button()
    Me.BtnGestForm = New System.Windows.Forms.Button()
    Me.BtnSupprLine = New System.Windows.Forms.Button()
    Me.BtnAddLine = New System.Windows.Forms.Button()
    Me.BtnQuit = New System.Windows.Forms.Button()
    Me.ColVFORMOBS = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColVFORLIB = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColVFORTYPE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColLOTVGTPLOTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColLOTNGTPLOTID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColDFORMDATE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepItemGLUpEditUnite = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
    Me.RepItemGLUpEditViewUnite = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.ColUNITEIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColUNITENGTPUNITEID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColUNITEVGTPUNITENOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColDFORMDATERECYCLE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColLOTIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepIGLUpEditViewLot = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.RepItemGLUpEditGTPLot = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
    Me.ColVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColNFORMNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GVFORMATION = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.ColFORMATEUR = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColVFICHIER = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColChkCHK_VFICHIER = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.ColChkVisibleHab = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCFORMATION = New DevExpress.XtraGrid.GridControl()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btn = New System.Windows.Forms.Button()
    Me.GrpActions.SuspendLayout()
    CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GVFORMATION, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GCFORMATION, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GrpActions
    '
    Me.GrpActions.Controls.Add(Me.btn)
    Me.GrpActions.Controls.Add(Me.BtnArchives)
    Me.GrpActions.Controls.Add(Me.BtnPrintAttest)
    Me.GrpActions.Controls.Add(Me.cmdHabilitation)
    Me.GrpActions.Controls.Add(Me.BtnExcel)
    Me.GrpActions.Controls.Add(Me.BtnImp)
    Me.GrpActions.Controls.Add(Me.BtnMod)
    Me.GrpActions.Controls.Add(Me.BtnGestOrg)
    Me.GrpActions.Controls.Add(Me.BtnGestForm)
    Me.GrpActions.Controls.Add(Me.BtnSupprLine)
    Me.GrpActions.Controls.Add(Me.BtnAddLine)
    Me.GrpActions.Controls.Add(Me.BtnQuit)
    resources.ApplyResources(Me.GrpActions, "GrpActions")
    Me.GrpActions.Name = "GrpActions"
    Me.GrpActions.TabStop = False
    '
    'BtnArchives
    '
    Me.BtnArchives.BackColor = System.Drawing.Color.PaleGoldenrod
    resources.ApplyResources(Me.BtnArchives, "BtnArchives")
    Me.BtnArchives.Name = "BtnArchives"
    Me.BtnArchives.UseVisualStyleBackColor = False
    '
    'BtnPrintAttest
    '
    Me.BtnPrintAttest.BackColor = System.Drawing.Color.LightSteelBlue
    resources.ApplyResources(Me.BtnPrintAttest, "BtnPrintAttest")
    Me.BtnPrintAttest.Name = "BtnPrintAttest"
    Me.BtnPrintAttest.UseVisualStyleBackColor = False
    '
    'cmdHabilitation
    '
    Me.cmdHabilitation.BackColor = System.Drawing.Color.PaleGoldenrod
    resources.ApplyResources(Me.cmdHabilitation, "cmdHabilitation")
    Me.cmdHabilitation.Name = "cmdHabilitation"
    Me.cmdHabilitation.UseVisualStyleBackColor = False
    '
    'BtnExcel
    '
    Me.BtnExcel.BackColor = System.Drawing.Color.LightSteelBlue
    resources.ApplyResources(Me.BtnExcel, "BtnExcel")
    Me.BtnExcel.Name = "BtnExcel"
    Me.BtnExcel.UseVisualStyleBackColor = False
    '
    'BtnImp
    '
    Me.BtnImp.BackColor = System.Drawing.Color.LightSteelBlue
    resources.ApplyResources(Me.BtnImp, "BtnImp")
    Me.BtnImp.Name = "BtnImp"
    Me.BtnImp.UseVisualStyleBackColor = False
    '
    'BtnMod
    '
    Me.BtnMod.BackColor = System.Drawing.Color.LightGreen
    resources.ApplyResources(Me.BtnMod, "BtnMod")
    Me.BtnMod.Name = "BtnMod"
    Me.BtnMod.UseVisualStyleBackColor = False
    '
    'BtnGestOrg
    '
    Me.BtnGestOrg.BackColor = System.Drawing.Color.PaleGoldenrod
    resources.ApplyResources(Me.BtnGestOrg, "BtnGestOrg")
    Me.BtnGestOrg.Name = "BtnGestOrg"
    Me.BtnGestOrg.UseVisualStyleBackColor = False
    '
    'BtnGestForm
    '
    Me.BtnGestForm.BackColor = System.Drawing.Color.PaleGoldenrod
    resources.ApplyResources(Me.BtnGestForm, "BtnGestForm")
    Me.BtnGestForm.Name = "BtnGestForm"
    Me.BtnGestForm.UseVisualStyleBackColor = False
    '
    'BtnSupprLine
    '
    Me.BtnSupprLine.BackColor = System.Drawing.Color.LightGreen
    resources.ApplyResources(Me.BtnSupprLine, "BtnSupprLine")
    Me.BtnSupprLine.Name = "BtnSupprLine"
    Me.BtnSupprLine.UseVisualStyleBackColor = False
    '
    'BtnAddLine
    '
    Me.BtnAddLine.BackColor = System.Drawing.Color.LightGreen
    resources.ApplyResources(Me.BtnAddLine, "BtnAddLine")
    Me.BtnAddLine.Name = "BtnAddLine"
    Me.BtnAddLine.UseVisualStyleBackColor = False
    '
    'BtnQuit
    '
    resources.ApplyResources(Me.BtnQuit, "BtnQuit")
    Me.BtnQuit.Name = "BtnQuit"
    Me.BtnQuit.UseVisualStyleBackColor = True
    '
    'ColVFORMOBS
    '
    Me.ColVFORMOBS.AppearanceCell.Options.UseTextOptions = True
    Me.ColVFORMOBS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    resources.ApplyResources(Me.ColVFORMOBS, "ColVFORMOBS")
    Me.ColVFORMOBS.FieldName = "VFORMOBS"
    Me.ColVFORMOBS.Name = "ColVFORMOBS"
    Me.ColVFORMOBS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'ColVFORLIB
    '
    resources.ApplyResources(Me.ColVFORLIB, "ColVFORLIB")
    Me.ColVFORLIB.FieldName = "VFORLIB"
    Me.ColVFORLIB.Name = "ColVFORLIB"
    Me.ColVFORLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'ColVFORTYPE
    '
    resources.ApplyResources(Me.ColVFORTYPE, "ColVFORTYPE")
    Me.ColVFORTYPE.FieldName = "VFORTYPE"
    Me.ColVFORTYPE.Name = "ColVFORTYPE"
    Me.ColVFORTYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'ColLOTVGTPLOTNOM
    '
    resources.ApplyResources(Me.ColLOTVGTPLOTNOM, "ColLOTVGTPLOTNOM")
    Me.ColLOTVGTPLOTNOM.FieldName = "VGTPLOTNOM"
    Me.ColLOTVGTPLOTNOM.Name = "ColLOTVGTPLOTNOM"
    '
    'ColLOTNGTPLOTID
    '
    resources.ApplyResources(Me.ColLOTNGTPLOTID, "ColLOTNGTPLOTID")
    Me.ColLOTNGTPLOTID.FieldName = "NGTPLOTID"
    Me.ColLOTNGTPLOTID.Name = "ColLOTNGTPLOTID"
    '
    'ColDFORMDATE
    '
    Me.ColDFORMDATE.AppearanceCell.Options.UseTextOptions = True
    Me.ColDFORMDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.ColDFORMDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    resources.ApplyResources(Me.ColDFORMDATE, "ColDFORMDATE")
    Me.ColDFORMDATE.FieldName = "DFORMDATE"
    Me.ColDFORMDATE.Name = "ColDFORMDATE"
    Me.ColDFORMDATE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'RepItemGLUpEditUnite
    '
    resources.ApplyResources(Me.RepItemGLUpEditUnite, "RepItemGLUpEditUnite")
    Me.RepItemGLUpEditUnite.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemGLUpEditUnite.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.RepItemGLUpEditUnite.DisplayMember = "VGTPUNITENOM"
    Me.RepItemGLUpEditUnite.Name = "RepItemGLUpEditUnite"
    Me.RepItemGLUpEditUnite.ValueMember = "NGTPUNITEID"
    Me.RepItemGLUpEditUnite.View = Me.RepItemGLUpEditViewUnite
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
    'ColDFORMDATERECYCLE
    '
    Me.ColDFORMDATERECYCLE.AppearanceCell.Options.UseTextOptions = True
    Me.ColDFORMDATERECYCLE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.ColDFORMDATERECYCLE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    resources.ApplyResources(Me.ColDFORMDATERECYCLE, "ColDFORMDATERECYCLE")
    Me.ColDFORMDATERECYCLE.FieldName = "DFORMDATERECYCLE"
    Me.ColDFORMDATERECYCLE.Name = "ColDFORMDATERECYCLE"
    Me.ColDFORMDATERECYCLE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'ColLOTIDTMP
    '
    resources.ApplyResources(Me.ColLOTIDTMP, "ColLOTIDTMP")
    Me.ColLOTIDTMP.FieldName = "IDTMP"
    Me.ColLOTIDTMP.Name = "ColLOTIDTMP"
    '
    'RepIGLUpEditViewLot
    '
    Me.RepIGLUpEditViewLot.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColLOTIDTMP, Me.ColLOTNGTPLOTID, Me.ColLOTVGTPLOTNOM})
    Me.RepIGLUpEditViewLot.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.RepIGLUpEditViewLot.Name = "RepIGLUpEditViewLot"
    Me.RepIGLUpEditViewLot.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.RepIGLUpEditViewLot.OptionsView.ShowGroupPanel = False
    '
    'RepItemGLUpEditGTPLot
    '
    resources.ApplyResources(Me.RepItemGLUpEditGTPLot, "RepItemGLUpEditGTPLot")
    Me.RepItemGLUpEditGTPLot.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemGLUpEditGTPLot.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.RepItemGLUpEditGTPLot.DisplayMember = "VGTPLOTNOM"
    Me.RepItemGLUpEditGTPLot.Name = "RepItemGLUpEditGTPLot"
    Me.RepItemGLUpEditGTPLot.ValueMember = "NGTPLOTID"
    Me.RepItemGLUpEditGTPLot.View = Me.RepIGLUpEditViewLot
    '
    'ColVPERNOM
    '
    resources.ApplyResources(Me.ColVPERNOM, "ColVPERNOM")
    Me.ColVPERNOM.FieldName = "VPERNOM"
    Me.ColVPERNOM.Name = "ColVPERNOM"
    Me.ColVPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'ColNFORMNUM
    '
    resources.ApplyResources(Me.ColNFORMNUM, "ColNFORMNUM")
    Me.ColNFORMNUM.FieldName = "NFORMNUM"
    Me.ColNFORMNUM.Name = "ColNFORMNUM"
    '
    'ColIDTMP
    '
    resources.ApplyResources(Me.ColIDTMP, "ColIDTMP")
    Me.ColIDTMP.FieldName = "IDTMP"
    Me.ColIDTMP.Name = "ColIDTMP"
    '
    'GVFORMATION
    '
    Me.GVFORMATION.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.ColumnFilterButton.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.ColumnFilterButton.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.ColumnFilterButton.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.Empty.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.Empty.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVFORMATION.Appearance.Empty.BackColor2"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.Empty.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.EvenRow.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.EvenRow.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.EvenRow.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.EvenRow.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.FilterCloseButton.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.FilterCloseButton.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.FilterCloseButton.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVFORMATION.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.FilterPanel.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.FilterPanel.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.FixedLine.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.FixedLine.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.FocusedCell.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.FocusedCell.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.FocusedRow.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.FocusedRow.BorderColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.FocusedRow.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.FocusedRow.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.FocusedRow.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.FooterPanel.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.FooterPanel.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.FooterPanel.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupButton.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.GroupButton.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.GroupButton.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.GroupFooter.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.GroupFooter.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.GroupFooter.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVFORMATION.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.GroupPanel.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.GroupPanel.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupRow.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.GroupRow.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.GroupRow.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.GroupRow.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVFORMATION.Appearance.HeaderPanel.Font"), System.Drawing.Font)
    Me.GVFORMATION.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.HeaderPanel.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.HeaderPanel.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.HeaderPanel.Options.UseFont = True
    Me.GVFORMATION.Appearance.HeaderPanel.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.GVFORMATION.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GVFORMATION.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GVFORMATION.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.GVFORMATION.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.HideSelectionRow.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.HideSelectionRow.BorderColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.HideSelectionRow.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.HideSelectionRow.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.HideSelectionRow.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.HorzLine.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.HorzLine.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.OddRow.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.OddRow.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.OddRow.BorderColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.OddRow.ForeColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.OddRow.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.OddRow.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.OddRow.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.Preview.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.Preview.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.Preview.Font = CType(resources.GetObject("GVFORMATION.Appearance.Preview.Font"), System.Drawing.Font)
    Me.GVFORMATION.Appearance.Preview.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.Preview.ForeColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.Preview.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.Preview.Options.UseFont = True
    Me.GVFORMATION.Appearance.Preview.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.Row.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.Row.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.Row.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.Row.ForeColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.Row.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.Row.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVFORMATION.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.RowSeparator.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.SelectedRow.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.SelectedRow.BorderColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.SelectedRow.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.SelectedRow.Options.UseBorderColor = True
    Me.GVFORMATION.Appearance.SelectedRow.Options.UseForeColor = True
    Me.GVFORMATION.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.TopNewRow.Options.UseBackColor = True
    Me.GVFORMATION.Appearance.VertLine.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.VertLine.BackColor"), System.Drawing.Color)
    Me.GVFORMATION.Appearance.VertLine.Options.UseBackColor = True
    Me.GVFORMATION.ColumnPanelRowHeight = 50
    Me.GVFORMATION.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIDTMP, Me.ColNFORMNUM, Me.ColVPERNOM, Me.ColVFORLIB, Me.ColVFORTYPE, Me.ColFORMATEUR, Me.ColVFORMOBS, Me.ColDFORMDATE, Me.ColDFORMDATERECYCLE, Me.ColVFICHIER, Me.ColChkCHK_VFICHIER, Me.ColChkVisibleHab})
    Me.GVFORMATION.GridControl = Me.GCFORMATION
    Me.GVFORMATION.Name = "GVFORMATION"
    Me.GVFORMATION.OptionsBehavior.Editable = False
    Me.GVFORMATION.OptionsNavigation.AutoFocusNewRow = True
    Me.GVFORMATION.OptionsView.EnableAppearanceOddRow = True
    Me.GVFORMATION.OptionsView.ShowAutoFilterRow = True
    Me.GVFORMATION.OptionsView.ShowFooter = True
    Me.GVFORMATION.OptionsView.ShowGroupPanel = False
    Me.GVFORMATION.RowHeight = 20
    '
    'ColFORMATEUR
    '
    resources.ApplyResources(Me.ColFORMATEUR, "ColFORMATEUR")
    Me.ColFORMATEUR.FieldName = "FORMATEUR"
    Me.ColFORMATEUR.Name = "ColFORMATEUR"
    Me.ColFORMATEUR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'ColVFICHIER
    '
    resources.ApplyResources(Me.ColVFICHIER, "ColVFICHIER")
    Me.ColVFICHIER.FieldName = "VFICHIER"
    Me.ColVFICHIER.Name = "ColVFICHIER"
    '
    'ColChkCHK_VFICHIER
    '
    resources.ApplyResources(Me.ColChkCHK_VFICHIER, "ColChkCHK_VFICHIER")
    Me.ColChkCHK_VFICHIER.ColumnEdit = Me.RepositoryItemCheckEdit1
    Me.ColChkCHK_VFICHIER.FieldName = "CHK_VFICHIER"
    Me.ColChkCHK_VFICHIER.Name = "ColChkCHK_VFICHIER"
    '
    'RepositoryItemCheckEdit1
    '
    resources.ApplyResources(Me.RepositoryItemCheckEdit1, "RepositoryItemCheckEdit1")
    Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
    Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
    Me.RepositoryItemCheckEdit1.ReadOnly = True
    Me.RepositoryItemCheckEdit1.ValueChecked = "O"
    Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
    '
    'ColChkVisibleHab
    '
    resources.ApplyResources(Me.ColChkVisibleHab, "ColChkVisibleHab")
    Me.ColChkVisibleHab.ColumnEdit = Me.RepositoryItemCheckEdit1
    Me.ColChkVisibleHab.FieldName = "CFORCARTEPRO"
    Me.ColChkVisibleHab.Name = "ColChkVisibleHab"
    '
    'GCFORMATION
    '
    resources.ApplyResources(Me.GCFORMATION, "GCFORMATION")
    Me.GCFORMATION.MainView = Me.GVFORMATION
    Me.GCFORMATION.Name = "GCFORMATION"
    Me.GCFORMATION.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemGLUpEditGTPLot, Me.RepItemGLUpEditUnite, Me.RepositoryItemCheckEdit1})
    Me.GCFORMATION.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVFORMATION})
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.Name = "Label1"
    '
    'btn
    '
    Me.btn.BackColor = System.Drawing.Color.PaleGoldenrod
    resources.ApplyResources(Me.btn, "btn")
    Me.btn.Name = "btn"
    Me.btn.UseVisualStyleBackColor = False
    '
    'frmListeFormation
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.Controls.Add(Me.GrpActions)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.GCFORMATION)
    Me.Name = "frmListeFormation"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.GrpActions.ResumeLayout(False)
    CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GVFORMATION, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GCFORMATION, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnGestOrg As System.Windows.Forms.Button
    Friend WithEvents BtnGestForm As System.Windows.Forms.Button
    Friend WithEvents BtnSupprLine As System.Windows.Forms.Button
    Friend WithEvents BtnAddLine As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnMod As System.Windows.Forms.Button
    Friend WithEvents BtnExcel As System.Windows.Forms.Button
    Friend WithEvents BtnImp As System.Windows.Forms.Button
    Friend WithEvents cmdHabilitation As System.Windows.Forms.Button
    Private WithEvents ColVFORMOBS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVFORLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVFORTYPE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColLOTVGTPLOTNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColLOTNGTPLOTID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColDFORMDATE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemGLUpEditUnite As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepItemGLUpEditViewUnite As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColUNITEIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColUNITENGTPUNITEID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColUNITEVGTPUNITENOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColDFORMDATERECYCLE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColLOTIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepIGLUpEditViewLot As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents RepItemGLUpEditGTPLot As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents ColVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNFORMNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVFORMATION As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCFORMATION As DevExpress.XtraGrid.GridControl
    Private WithEvents ColFORMATEUR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColVFICHIER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColChkCHK_VFICHIER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BtnPrintAttest As Button
    Friend WithEvents BtnArchives As Button
  Friend WithEvents ColChkVisibleHab As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btn As Button
End Class
