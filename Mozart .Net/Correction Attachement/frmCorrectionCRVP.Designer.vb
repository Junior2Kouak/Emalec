<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCorrectionCRVP
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.RepColMarqueVFOUEXTMARQLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabCtrlExt = New DevExpress.XtraTab.XtraTabControl()
        Me.TabExtInv = New DevExpress.XtraTab.XtraTabPage()
        Me.GCExtInv = New DevExpress.XtraGrid.GridControl()
        Me.GVExtInv = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNEXTINVID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNACTNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNFOUNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLEditLstFou = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepItemGridLookUpEditViewLstFou = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColLstNFOUNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLstVFOUMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVEXTINVLMARQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGridLookUpMarque = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepItemGViewMarque = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepColMarqueBOLD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVEXTEMPL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEditVEXTEMPL = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ColVEXTNUMERO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEditVEXTNUMERO = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ColNEXTINVIDL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNEXTINVLANNEE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGridLstInvAnnee = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepItemGrdViewLstAnnee = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIDANNEE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNANNEE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVerifOUI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemCheckVERIFOUI = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ColVerifNON = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemCheckVERIFNON = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ColActions = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGridLookUpAction = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepItemGridLookUpViewAction = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColObservation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ReItemTextEditObservation = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BtnExtInvEquipSuppLine = New System.Windows.Forms.Button()
        Me.BtnExtInvEquipNewLine = New System.Windows.Forms.Button()
        Me.TabExtBordereau = New DevExpress.XtraTab.XtraTabPage()
        Me.GCExtBord = New DevExpress.XtraGrid.GridControl()
        Me.GVExtBord = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNEXTBORDID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNEXTBORDNACTNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNEXTBORDFOU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLEditLstFouBord = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GVCboLstFouBord = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColBordNFOUNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColBordVFOUMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColFouBordPrixCli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNEXTBORDQTEUSE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEditNEXTBORDQTEUSE = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ColNEXTBORDQTEREPL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEditNEXTBORDQTEREPL = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ColNEXTBORDIDL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNEXTBORDIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnExtBordSuppLine = New System.Windows.Forms.Button()
        Me.BtnExtBordNewLine = New System.Windows.Forms.Button()
        Me.TabExtAct = New DevExpress.XtraTab.XtraTabPage()
        Me.TxtExtActCR = New System.Windows.Forms.TextBox()
        Me.TabEtatDemande = New DevExpress.XtraTab.XtraTabPage()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnEnregistrer = New System.Windows.Forms.Button()
        Me.TxtVEXTACT_OBS = New System.Windows.Forms.TextBox()
        CType(Me.TabCtrlExt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCtrlExt.SuspendLayout()
        Me.TabExtInv.SuspendLayout()
        CType(Me.GCExtInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVExtInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLEditLstFou, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGridLookUpEditViewLstFou, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGridLookUpMarque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGViewMarque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEditVEXTEMPL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEditVEXTNUMERO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGridLstInvAnnee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGrdViewLstAnnee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemCheckVERIFOUI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemCheckVERIFNON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGridLookUpAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGridLookUpViewAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReItemTextEditObservation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabExtBordereau.SuspendLayout()
        CType(Me.GCExtBord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVExtBord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLEditLstFouBord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCboLstFouBord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEditNEXTBORDQTEUSE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEditNEXTBORDQTEREPL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabExtAct.SuspendLayout()
        Me.TabEtatDemande.SuspendLayout()
        Me.SuspendLayout()
        '
        'RepColMarqueVFOUEXTMARQLIB
        '
        Me.RepColMarqueVFOUEXTMARQLIB.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.RepColMarqueVFOUEXTMARQLIB.AppearanceCell.Options.UseFont = True
        Me.RepColMarqueVFOUEXTMARQLIB.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RepColMarqueVFOUEXTMARQLIB.AppearanceHeader.Options.UseFont = True
        Me.RepColMarqueVFOUEXTMARQLIB.AppearanceHeader.Options.UseTextOptions = True
        Me.RepColMarqueVFOUEXTMARQLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepColMarqueVFOUEXTMARQLIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.RepColMarqueVFOUEXTMARQLIB.Caption = "Marque"
        Me.RepColMarqueVFOUEXTMARQLIB.FieldName = "VFOUEXTMARQLIB"
        Me.RepColMarqueVFOUEXTMARQLIB.Name = "RepColMarqueVFOUEXTMARQLIB"
        Me.RepColMarqueVFOUEXTMARQLIB.Visible = True
        Me.RepColMarqueVFOUEXTMARQLIB.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn2.Caption = "Actions"
        Me.GridColumn2.FieldName = "VACTION"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'TabCtrlExt
        '
        Me.TabCtrlExt.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabCtrlExt.AppearancePage.Header.Options.UseFont = True
        Me.TabCtrlExt.Location = New System.Drawing.Point(104, 12)
        Me.TabCtrlExt.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TabCtrlExt.Name = "TabCtrlExt"
        Me.TabCtrlExt.SelectedTabPage = Me.TabExtInv
        Me.TabCtrlExt.Size = New System.Drawing.Size(1279, 710)
        Me.TabCtrlExt.TabIndex = 26
        Me.TabCtrlExt.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabExtInv, Me.TabExtBordereau, Me.TabExtAct, Me.TabEtatDemande})
        '
        'TabExtInv
        '
        Me.TabExtInv.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TabExtInv.Appearance.Header.Options.UseFont = True
        Me.TabExtInv.Controls.Add(Me.GCExtInv)
        Me.TabExtInv.Controls.Add(Me.BtnExtInvEquipSuppLine)
        Me.TabExtInv.Controls.Add(Me.BtnExtInvEquipNewLine)
        Me.TabExtInv.Name = "TabExtInv"
        Me.TabExtInv.Size = New System.Drawing.Size(1277, 682)
        Me.TabExtInv.Text = "Maintenance des équipements"
        '
        'GCExtInv
        '
        Me.GCExtInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.GCExtInv.Location = New System.Drawing.Point(111, 7)
        Me.GCExtInv.MainView = Me.GVExtInv
        Me.GCExtInv.Name = "GCExtInv"
        Me.GCExtInv.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemGLEditLstFou, Me.RepositoryItemTextEditVEXTEMPL, Me.RepositoryItemTextEditVEXTNUMERO, Me.RepItemGridLstInvAnnee, Me.RepItemGridLookUpMarque, Me.RepItemCheckVERIFOUI, Me.RepItemCheckVERIFNON, Me.ReItemTextEditObservation, Me.RepItemGridLookUpAction})
        Me.GCExtInv.Size = New System.Drawing.Size(1115, 665)
        Me.GCExtInv.TabIndex = 18
        Me.GCExtInv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVExtInv})
        '
        'GVExtInv
        '
        Me.GVExtInv.Appearance.Row.BackColor = System.Drawing.Color.Beige
        Me.GVExtInv.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GVExtInv.Appearance.Row.Options.UseBackColor = True
        Me.GVExtInv.Appearance.Row.Options.UseFont = True
        Me.GVExtInv.ColumnPanelRowHeight = 45
        Me.GVExtInv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNEXTINVID, Me.ColNACTNUM, Me.ColNFOUNUM, Me.ColVEXTINVLMARQ, Me.ColVEXTEMPL, Me.ColVEXTNUMERO, Me.ColNEXTINVIDL, Me.ColNIDTMP, Me.ColNEXTINVLANNEE, Me.ColVerifOUI, Me.ColVerifNON, Me.ColActions, Me.ColObservation})
        Me.GVExtInv.GridControl = Me.GCExtInv
        Me.GVExtInv.Name = "GVExtInv"
        Me.GVExtInv.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVExtInv.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GVExtInv.OptionsView.ShowGroupPanel = False
        Me.GVExtInv.RowHeight = 25
        '
        'ColNEXTINVID
        '
        Me.ColNEXTINVID.Caption = "NEXTINVID"
        Me.ColNEXTINVID.FieldName = "NEXTINVID"
        Me.ColNEXTINVID.Name = "ColNEXTINVID"
        '
        'ColNACTNUM
        '
        Me.ColNACTNUM.Caption = "NACTNUM"
        Me.ColNACTNUM.FieldName = "NACTNUM"
        Me.ColNACTNUM.Name = "ColNACTNUM"
        '
        'ColNFOUNUM
        '
        Me.ColNFOUNUM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ColNFOUNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColNFOUNUM.AppearanceHeader.Options.UseFont = True
        Me.ColNFOUNUM.AppearanceHeader.Options.UseForeColor = True
        Me.ColNFOUNUM.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNFOUNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNFOUNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNFOUNUM.Caption = "Fourniture"
        Me.ColNFOUNUM.ColumnEdit = Me.RepItemGLEditLstFou
        Me.ColNFOUNUM.FieldName = "NFOUNUM"
        Me.ColNFOUNUM.Name = "ColNFOUNUM"
        Me.ColNFOUNUM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.ColNFOUNUM.Visible = True
        Me.ColNFOUNUM.VisibleIndex = 0
        Me.ColNFOUNUM.Width = 370
        '
        'RepItemGLEditLstFou
        '
        Me.RepItemGLEditLstFou.AutoHeight = False
        Me.RepItemGLEditLstFou.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepItemGLEditLstFou.DisplayMember = "VFOUMAT"
        Me.RepItemGLEditLstFou.ImmediatePopup = True
        Me.RepItemGLEditLstFou.Name = "RepItemGLEditLstFou"
        Me.RepItemGLEditLstFou.NullText = ""
        Me.RepItemGLEditLstFou.PopupView = Me.RepItemGridLookUpEditViewLstFou
        Me.RepItemGLEditLstFou.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.RepItemGLEditLstFou.ShowPopupShadow = False
        Me.RepItemGLEditLstFou.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepItemGLEditLstFou.ValueMember = "NFOUNUM"
        '
        'RepItemGridLookUpEditViewLstFou
        '
        Me.RepItemGridLookUpEditViewLstFou.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.RepItemGridLookUpEditViewLstFou.Appearance.HeaderPanel.Options.UseFont = True
        Me.RepItemGridLookUpEditViewLstFou.Appearance.Row.BackColor = System.Drawing.Color.LightCyan
        Me.RepItemGridLookUpEditViewLstFou.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.RepItemGridLookUpEditViewLstFou.Appearance.Row.Options.UseBackColor = True
        Me.RepItemGridLookUpEditViewLstFou.Appearance.Row.Options.UseFont = True
        Me.RepItemGridLookUpEditViewLstFou.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColLstNFOUNUM, Me.ColLstVFOUMAT})
        Me.RepItemGridLookUpEditViewLstFou.DetailHeight = 600
        Me.RepItemGridLookUpEditViewLstFou.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepItemGridLookUpEditViewLstFou.Name = "RepItemGridLookUpEditViewLstFou"
        Me.RepItemGridLookUpEditViewLstFou.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepItemGridLookUpEditViewLstFou.OptionsView.ShowAutoFilterRow = True
        Me.RepItemGridLookUpEditViewLstFou.OptionsView.ShowGroupPanel = False
        Me.RepItemGridLookUpEditViewLstFou.RowHeight = 25
        '
        'ColLstNFOUNUM
        '
        Me.ColLstNFOUNUM.Caption = "NFOUNUM"
        Me.ColLstNFOUNUM.FieldName = "NFOUNUM"
        Me.ColLstNFOUNUM.Name = "ColLstNFOUNUM"
        '
        'ColLstVFOUMAT
        '
        Me.ColLstVFOUMAT.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ColLstVFOUMAT.AppearanceCell.Options.UseFont = True
        Me.ColLstVFOUMAT.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ColLstVFOUMAT.AppearanceHeader.Options.UseFont = True
        Me.ColLstVFOUMAT.AppearanceHeader.Options.UseTextOptions = True
        Me.ColLstVFOUMAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLstVFOUMAT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColLstVFOUMAT.Caption = "Liste des fournitures"
        Me.ColLstVFOUMAT.FieldName = "VFOUMAT"
        Me.ColLstVFOUMAT.Name = "ColLstVFOUMAT"
        Me.ColLstVFOUMAT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.ColLstVFOUMAT.Visible = True
        Me.ColLstVFOUMAT.VisibleIndex = 0
        Me.ColLstVFOUMAT.Width = 300
        '
        'ColVEXTINVLMARQ
        '
        Me.ColVEXTINVLMARQ.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ColVEXTINVLMARQ.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColVEXTINVLMARQ.AppearanceHeader.Options.UseFont = True
        Me.ColVEXTINVLMARQ.AppearanceHeader.Options.UseForeColor = True
        Me.ColVEXTINVLMARQ.AppearanceHeader.Options.UseTextOptions = True
        Me.ColVEXTINVLMARQ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVEXTINVLMARQ.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColVEXTINVLMARQ.Caption = "Marque"
        Me.ColVEXTINVLMARQ.ColumnEdit = Me.RepItemGridLookUpMarque
        Me.ColVEXTINVLMARQ.FieldName = "VEXTINVLMARQ"
        Me.ColVEXTINVLMARQ.Name = "ColVEXTINVLMARQ"
        Me.ColVEXTINVLMARQ.Visible = True
        Me.ColVEXTINVLMARQ.VisibleIndex = 4
        Me.ColVEXTINVLMARQ.Width = 101
        '
        'RepItemGridLookUpMarque
        '
        Me.RepItemGridLookUpMarque.AutoHeight = False
        Me.RepItemGridLookUpMarque.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepItemGridLookUpMarque.DisplayMember = "VFOUEXTMARQLIB"
        Me.RepItemGridLookUpMarque.Name = "RepItemGridLookUpMarque"
        Me.RepItemGridLookUpMarque.NullText = ""
        Me.RepItemGridLookUpMarque.PopupView = Me.RepItemGViewMarque
        Me.RepItemGridLookUpMarque.ValueMember = "VFOUEXTMARQLIB"
        '
        'RepItemGViewMarque
        '
        Me.RepItemGViewMarque.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.RepItemGViewMarque.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.RepItemGViewMarque.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.RepItemGViewMarque.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.RepItemGViewMarque.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.RepItemGViewMarque.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.RepItemGViewMarque.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.RepItemGViewMarque.Appearance.Empty.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.RepItemGViewMarque.Appearance.EvenRow.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.EvenRow.Options.UseForeColor = True
        Me.RepItemGViewMarque.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.RepItemGViewMarque.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.RepItemGViewMarque.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.RepItemGViewMarque.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.RepItemGViewMarque.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.RepItemGViewMarque.Appearance.FilterPanel.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.FilterPanel.Options.UseForeColor = True
        Me.RepItemGViewMarque.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.FixedLine.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.RepItemGViewMarque.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.RepItemGViewMarque.Appearance.FocusedCell.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.FocusedCell.Options.UseForeColor = True
        Me.RepItemGViewMarque.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.RepItemGViewMarque.Appearance.FocusedRow.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.FocusedRow.Options.UseForeColor = True
        Me.RepItemGViewMarque.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.RepItemGViewMarque.Appearance.FooterPanel.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.RepItemGViewMarque.Appearance.FooterPanel.Options.UseForeColor = True
        Me.RepItemGViewMarque.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.GroupButton.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.GroupButton.Options.UseBorderColor = True
        Me.RepItemGViewMarque.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.RepItemGViewMarque.Appearance.GroupFooter.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.RepItemGViewMarque.Appearance.GroupFooter.Options.UseForeColor = True
        Me.RepItemGViewMarque.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.RepItemGViewMarque.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.RepItemGViewMarque.Appearance.GroupPanel.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.GroupPanel.Options.UseForeColor = True
        Me.RepItemGViewMarque.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.RepItemGViewMarque.Appearance.GroupRow.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.GroupRow.Options.UseBorderColor = True
        Me.RepItemGViewMarque.Appearance.GroupRow.Options.UseForeColor = True
        Me.RepItemGViewMarque.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.RepItemGViewMarque.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.RepItemGViewMarque.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.RepItemGViewMarque.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.RepItemGViewMarque.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.HorzLine.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.RepItemGViewMarque.Appearance.OddRow.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.OddRow.Options.UseForeColor = True
        Me.RepItemGViewMarque.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.RepItemGViewMarque.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.Preview.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.Preview.Options.UseFont = True
        Me.RepItemGViewMarque.Appearance.Preview.Options.UseForeColor = True
        Me.RepItemGViewMarque.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.RepItemGViewMarque.Appearance.Row.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.Row.Options.UseBorderColor = True
        Me.RepItemGViewMarque.Appearance.Row.Options.UseForeColor = True
        Me.RepItemGViewMarque.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.RepItemGViewMarque.Appearance.RowSeparator.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.SelectedRow.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.RepItemGViewMarque.Appearance.TopNewRow.Options.UseBackColor = True
        Me.RepItemGViewMarque.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RepItemGViewMarque.Appearance.VertLine.Options.UseBackColor = True
        Me.RepItemGViewMarque.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.RepColMarqueBOLD, Me.RepColMarqueVFOUEXTMARQLIB})
        Me.RepItemGViewMarque.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Column = Me.RepColMarqueVFOUEXTMARQLIB
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[BOLD] = 1"
        Me.RepItemGViewMarque.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.RepItemGViewMarque.Name = "RepItemGViewMarque"
        Me.RepItemGViewMarque.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepItemGViewMarque.OptionsView.EnableAppearanceEvenRow = True
        Me.RepItemGViewMarque.OptionsView.EnableAppearanceOddRow = True
        Me.RepItemGViewMarque.OptionsView.ShowGroupPanel = False
        Me.RepItemGViewMarque.RowHeight = 25
        '
        'RepColMarqueBOLD
        '
        Me.RepColMarqueBOLD.Caption = "BOLD"
        Me.RepColMarqueBOLD.FieldName = "BOLD"
        Me.RepColMarqueBOLD.Name = "RepColMarqueBOLD"
        '
        'ColVEXTEMPL
        '
        Me.ColVEXTEMPL.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ColVEXTEMPL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColVEXTEMPL.AppearanceHeader.Options.UseFont = True
        Me.ColVEXTEMPL.AppearanceHeader.Options.UseForeColor = True
        Me.ColVEXTEMPL.AppearanceHeader.Options.UseTextOptions = True
        Me.ColVEXTEMPL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVEXTEMPL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColVEXTEMPL.Caption = "Emplacement"
        Me.ColVEXTEMPL.ColumnEdit = Me.RepositoryItemTextEditVEXTEMPL
        Me.ColVEXTEMPL.FieldName = "VEXTINVEMPL"
        Me.ColVEXTEMPL.Name = "ColVEXTEMPL"
        Me.ColVEXTEMPL.Visible = True
        Me.ColVEXTEMPL.VisibleIndex = 1
        Me.ColVEXTEMPL.Width = 95
        '
        'RepositoryItemTextEditVEXTEMPL
        '
        Me.RepositoryItemTextEditVEXTEMPL.AutoHeight = False
        Me.RepositoryItemTextEditVEXTEMPL.MaxLength = 200
        Me.RepositoryItemTextEditVEXTEMPL.Name = "RepositoryItemTextEditVEXTEMPL"
        '
        'ColVEXTNUMERO
        '
        Me.ColVEXTNUMERO.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ColVEXTNUMERO.AppearanceCell.Options.UseFont = True
        Me.ColVEXTNUMERO.AppearanceCell.Options.UseTextOptions = True
        Me.ColVEXTNUMERO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVEXTNUMERO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColVEXTNUMERO.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ColVEXTNUMERO.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColVEXTNUMERO.AppearanceHeader.Options.UseFont = True
        Me.ColVEXTNUMERO.AppearanceHeader.Options.UseForeColor = True
        Me.ColVEXTNUMERO.AppearanceHeader.Options.UseTextOptions = True
        Me.ColVEXTNUMERO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVEXTNUMERO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColVEXTNUMERO.Caption = "Numéro"
        Me.ColVEXTNUMERO.ColumnEdit = Me.RepositoryItemTextEditVEXTNUMERO
        Me.ColVEXTNUMERO.FieldName = "VEXTINVLNUMERO"
        Me.ColVEXTNUMERO.Name = "ColVEXTNUMERO"
        Me.ColVEXTNUMERO.Visible = True
        Me.ColVEXTNUMERO.VisibleIndex = 2
        Me.ColVEXTNUMERO.Width = 94
        '
        'RepositoryItemTextEditVEXTNUMERO
        '
        Me.RepositoryItemTextEditVEXTNUMERO.AutoHeight = False
        Me.RepositoryItemTextEditVEXTNUMERO.MaxLength = 20
        Me.RepositoryItemTextEditVEXTNUMERO.Name = "RepositoryItemTextEditVEXTNUMERO"
        '
        'ColNEXTINVIDL
        '
        Me.ColNEXTINVIDL.Caption = "NEXTINVIDL"
        Me.ColNEXTINVIDL.FieldName = "NEXTINVLID"
        Me.ColNEXTINVIDL.Name = "ColNEXTINVIDL"
        '
        'ColNIDTMP
        '
        Me.ColNIDTMP.Caption = "NIDTMP"
        Me.ColNIDTMP.FieldName = "NIDTMP"
        Me.ColNIDTMP.Name = "ColNIDTMP"
        '
        'ColNEXTINVLANNEE
        '
        Me.ColNEXTINVLANNEE.AppearanceCell.Options.UseTextOptions = True
        Me.ColNEXTINVLANNEE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNEXTINVLANNEE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNEXTINVLANNEE.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ColNEXTINVLANNEE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColNEXTINVLANNEE.AppearanceHeader.Options.UseFont = True
        Me.ColNEXTINVLANNEE.AppearanceHeader.Options.UseForeColor = True
        Me.ColNEXTINVLANNEE.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNEXTINVLANNEE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNEXTINVLANNEE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNEXTINVLANNEE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColNEXTINVLANNEE.Caption = "Année estampillée"
        Me.ColNEXTINVLANNEE.ColumnEdit = Me.RepItemGridLstInvAnnee
        Me.ColNEXTINVLANNEE.FieldName = "NEXTINVLANNEE"
        Me.ColNEXTINVLANNEE.Name = "ColNEXTINVLANNEE"
        Me.ColNEXTINVLANNEE.Visible = True
        Me.ColNEXTINVLANNEE.VisibleIndex = 3
        Me.ColNEXTINVLANNEE.Width = 100
        '
        'RepItemGridLstInvAnnee
        '
        Me.RepItemGridLstInvAnnee.Appearance.Options.UseTextOptions = True
        Me.RepItemGridLstInvAnnee.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepItemGridLstInvAnnee.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.RepItemGridLstInvAnnee.AutoHeight = False
        Me.RepItemGridLstInvAnnee.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepItemGridLstInvAnnee.DisplayMember = "NANNEE"
        Me.RepItemGridLstInvAnnee.ImmediatePopup = True
        Me.RepItemGridLstInvAnnee.Name = "RepItemGridLstInvAnnee"
        Me.RepItemGridLstInvAnnee.NullText = ""
        Me.RepItemGridLstInvAnnee.PopupView = Me.RepItemGrdViewLstAnnee
        Me.RepItemGridLstInvAnnee.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.RepItemGridLstInvAnnee.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepItemGridLstInvAnnee.ValueMember = "IDANNEE"
        '
        'RepItemGrdViewLstAnnee
        '
        Me.RepItemGrdViewLstAnnee.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.RepItemGrdViewLstAnnee.Appearance.HeaderPanel.Options.UseFont = True
        Me.RepItemGrdViewLstAnnee.Appearance.Row.BackColor = System.Drawing.Color.LightCyan
        Me.RepItemGrdViewLstAnnee.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.RepItemGrdViewLstAnnee.Appearance.Row.Options.UseBackColor = True
        Me.RepItemGrdViewLstAnnee.Appearance.Row.Options.UseFont = True
        Me.RepItemGrdViewLstAnnee.ColumnPanelRowHeight = 25
        Me.RepItemGrdViewLstAnnee.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIDANNEE, Me.ColNANNEE})
        Me.RepItemGrdViewLstAnnee.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepItemGrdViewLstAnnee.Name = "RepItemGrdViewLstAnnee"
        Me.RepItemGrdViewLstAnnee.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepItemGrdViewLstAnnee.OptionsView.ShowGroupPanel = False
        Me.RepItemGrdViewLstAnnee.RowHeight = 25
        '
        'ColIDANNEE
        '
        Me.ColIDANNEE.Caption = "IDANNEE"
        Me.ColIDANNEE.FieldName = "IDANNEE"
        Me.ColIDANNEE.Name = "ColIDANNEE"
        '
        'ColNANNEE
        '
        Me.ColNANNEE.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ColNANNEE.AppearanceCell.Options.UseFont = True
        Me.ColNANNEE.AppearanceCell.Options.UseTextOptions = True
        Me.ColNANNEE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNANNEE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNANNEE.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ColNANNEE.AppearanceHeader.Options.UseFont = True
        Me.ColNANNEE.Caption = "ANNEE"
        Me.ColNANNEE.FieldName = "NANNEE"
        Me.ColNANNEE.Name = "ColNANNEE"
        Me.ColNANNEE.Visible = True
        Me.ColNANNEE.VisibleIndex = 0
        Me.ColNANNEE.Width = 20
        '
        'ColVerifOUI
        '
        Me.ColVerifOUI.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ColVerifOUI.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColVerifOUI.AppearanceHeader.Options.UseFont = True
        Me.ColVerifOUI.AppearanceHeader.Options.UseForeColor = True
        Me.ColVerifOUI.AppearanceHeader.Options.UseTextOptions = True
        Me.ColVerifOUI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVerifOUI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColVerifOUI.Caption = "Vérifié"
        Me.ColVerifOUI.ColumnEdit = Me.RepItemCheckVERIFOUI
        Me.ColVerifOUI.FieldName = "BEXTVERIFOUI"
        Me.ColVerifOUI.Name = "ColVerifOUI"
        Me.ColVerifOUI.Visible = True
        Me.ColVerifOUI.VisibleIndex = 5
        Me.ColVerifOUI.Width = 62
        '
        'RepItemCheckVERIFOUI
        '
        Me.RepItemCheckVERIFOUI.AutoHeight = False
        Me.RepItemCheckVERIFOUI.Name = "RepItemCheckVERIFOUI"
        Me.RepItemCheckVERIFOUI.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'ColVerifNON
        '
        Me.ColVerifNON.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ColVerifNON.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColVerifNON.AppearanceHeader.Options.UseFont = True
        Me.ColVerifNON.AppearanceHeader.Options.UseForeColor = True
        Me.ColVerifNON.AppearanceHeader.Options.UseTextOptions = True
        Me.ColVerifNON.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVerifNON.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColVerifNON.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColVerifNON.Caption = "Non vérifié"
        Me.ColVerifNON.ColumnEdit = Me.RepItemCheckVERIFNON
        Me.ColVerifNON.FieldName = "BEXTVERIFNON"
        Me.ColVerifNON.Name = "ColVerifNON"
        Me.ColVerifNON.Visible = True
        Me.ColVerifNON.VisibleIndex = 6
        Me.ColVerifNON.Width = 64
        '
        'RepItemCheckVERIFNON
        '
        Me.RepItemCheckVERIFNON.AutoHeight = False
        Me.RepItemCheckVERIFNON.Name = "RepItemCheckVERIFNON"
        Me.RepItemCheckVERIFNON.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'ColActions
        '
        Me.ColActions.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ColActions.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColActions.AppearanceHeader.Options.UseFont = True
        Me.ColActions.AppearanceHeader.Options.UseForeColor = True
        Me.ColActions.AppearanceHeader.Options.UseTextOptions = True
        Me.ColActions.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColActions.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColActions.Caption = "Action"
        Me.ColActions.ColumnEdit = Me.RepItemGridLookUpAction
        Me.ColActions.FieldName = "VEXTINVACTION"
        Me.ColActions.Name = "ColActions"
        Me.ColActions.Visible = True
        Me.ColActions.VisibleIndex = 7
        Me.ColActions.Width = 79
        '
        'RepItemGridLookUpAction
        '
        Me.RepItemGridLookUpAction.AutoHeight = False
        Me.RepItemGridLookUpAction.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepItemGridLookUpAction.DisplayMember = "VACTION"
        Me.RepItemGridLookUpAction.Name = "RepItemGridLookUpAction"
        Me.RepItemGridLookUpAction.NullText = ""
        Me.RepItemGridLookUpAction.PopupView = Me.RepItemGridLookUpViewAction
        Me.RepItemGridLookUpAction.ValueMember = "VACTION"
        '
        'RepItemGridLookUpViewAction
        '
        Me.RepItemGridLookUpViewAction.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.RepItemGridLookUpViewAction.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.RepItemGridLookUpViewAction.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.RepItemGridLookUpViewAction.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.RepItemGridLookUpViewAction.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.RepItemGridLookUpViewAction.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.RepItemGridLookUpViewAction.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.RepItemGridLookUpViewAction.Appearance.Empty.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.RepItemGridLookUpViewAction.Appearance.EvenRow.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.EvenRow.Options.UseForeColor = True
        Me.RepItemGridLookUpViewAction.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.RepItemGridLookUpViewAction.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.RepItemGridLookUpViewAction.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.RepItemGridLookUpViewAction.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.RepItemGridLookUpViewAction.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.RepItemGridLookUpViewAction.Appearance.FilterPanel.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.FilterPanel.Options.UseForeColor = True
        Me.RepItemGridLookUpViewAction.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.FixedLine.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.RepItemGridLookUpViewAction.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.RepItemGridLookUpViewAction.Appearance.FocusedCell.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.FocusedCell.Options.UseForeColor = True
        Me.RepItemGridLookUpViewAction.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.RepItemGridLookUpViewAction.Appearance.FocusedRow.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.FocusedRow.Options.UseForeColor = True
        Me.RepItemGridLookUpViewAction.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.RepItemGridLookUpViewAction.Appearance.FooterPanel.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.RepItemGridLookUpViewAction.Appearance.FooterPanel.Options.UseForeColor = True
        Me.RepItemGridLookUpViewAction.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.GroupButton.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.GroupButton.Options.UseBorderColor = True
        Me.RepItemGridLookUpViewAction.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.RepItemGridLookUpViewAction.Appearance.GroupFooter.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.RepItemGridLookUpViewAction.Appearance.GroupFooter.Options.UseForeColor = True
        Me.RepItemGridLookUpViewAction.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.RepItemGridLookUpViewAction.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.RepItemGridLookUpViewAction.Appearance.GroupPanel.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.GroupPanel.Options.UseForeColor = True
        Me.RepItemGridLookUpViewAction.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.RepItemGridLookUpViewAction.Appearance.GroupRow.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.GroupRow.Options.UseBorderColor = True
        Me.RepItemGridLookUpViewAction.Appearance.GroupRow.Options.UseForeColor = True
        Me.RepItemGridLookUpViewAction.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.RepItemGridLookUpViewAction.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.RepItemGridLookUpViewAction.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.RepItemGridLookUpViewAction.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.RepItemGridLookUpViewAction.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.HorzLine.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.RepItemGridLookUpViewAction.Appearance.OddRow.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.OddRow.Options.UseForeColor = True
        Me.RepItemGridLookUpViewAction.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.RepItemGridLookUpViewAction.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.Preview.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.Preview.Options.UseFont = True
        Me.RepItemGridLookUpViewAction.Appearance.Preview.Options.UseForeColor = True
        Me.RepItemGridLookUpViewAction.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.RepItemGridLookUpViewAction.Appearance.Row.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.Row.Options.UseBorderColor = True
        Me.RepItemGridLookUpViewAction.Appearance.Row.Options.UseForeColor = True
        Me.RepItemGridLookUpViewAction.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.RepItemGridLookUpViewAction.Appearance.RowSeparator.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.SelectedRow.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.RepItemGridLookUpViewAction.Appearance.TopNewRow.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RepItemGridLookUpViewAction.Appearance.VertLine.Options.UseBackColor = True
        Me.RepItemGridLookUpViewAction.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.RepItemGridLookUpViewAction.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Column = Me.GridColumn2
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "[BOLD] = 1"
        Me.RepItemGridLookUpViewAction.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.RepItemGridLookUpViewAction.Name = "RepItemGridLookUpViewAction"
        Me.RepItemGridLookUpViewAction.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepItemGridLookUpViewAction.OptionsView.EnableAppearanceEvenRow = True
        Me.RepItemGridLookUpViewAction.OptionsView.EnableAppearanceOddRow = True
        Me.RepItemGridLookUpViewAction.OptionsView.ShowGroupPanel = False
        Me.RepItemGridLookUpViewAction.RowHeight = 25
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "ID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'ColObservation
        '
        Me.ColObservation.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ColObservation.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColObservation.AppearanceHeader.Options.UseFont = True
        Me.ColObservation.AppearanceHeader.Options.UseForeColor = True
        Me.ColObservation.AppearanceHeader.Options.UseTextOptions = True
        Me.ColObservation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColObservation.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColObservation.Caption = "Observations"
        Me.ColObservation.ColumnEdit = Me.ReItemTextEditObservation
        Me.ColObservation.FieldName = "VEXTINVOBS"
        Me.ColObservation.Name = "ColObservation"
        Me.ColObservation.Visible = True
        Me.ColObservation.VisibleIndex = 8
        Me.ColObservation.Width = 125
        '
        'ReItemTextEditObservation
        '
        Me.ReItemTextEditObservation.AutoHeight = False
        Me.ReItemTextEditObservation.Name = "ReItemTextEditObservation"
        '
        'BtnExtInvEquipSuppLine
        '
        Me.BtnExtInvEquipSuppLine.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnExtInvEquipSuppLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnExtInvEquipSuppLine.Location = New System.Drawing.Point(7, 86)
        Me.BtnExtInvEquipSuppLine.Name = "BtnExtInvEquipSuppLine"
        Me.BtnExtInvEquipSuppLine.Size = New System.Drawing.Size(98, 67)
        Me.BtnExtInvEquipSuppLine.TabIndex = 17
        Me.BtnExtInvEquipSuppLine.Text = "Supprimer Equipement"
        Me.BtnExtInvEquipSuppLine.UseVisualStyleBackColor = True
        '
        'BtnExtInvEquipNewLine
        '
        Me.BtnExtInvEquipNewLine.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnExtInvEquipNewLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnExtInvEquipNewLine.Location = New System.Drawing.Point(7, 7)
        Me.BtnExtInvEquipNewLine.Name = "BtnExtInvEquipNewLine"
        Me.BtnExtInvEquipNewLine.Size = New System.Drawing.Size(98, 73)
        Me.BtnExtInvEquipNewLine.TabIndex = 16
        Me.BtnExtInvEquipNewLine.Text = "Ajouter Equipement"
        Me.BtnExtInvEquipNewLine.UseVisualStyleBackColor = True
        '
        'TabExtBordereau
        '
        Me.TabExtBordereau.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TabExtBordereau.Appearance.Header.Options.UseFont = True
        Me.TabExtBordereau.Controls.Add(Me.GCExtBord)
        Me.TabExtBordereau.Controls.Add(Me.BtnExtBordSuppLine)
        Me.TabExtBordereau.Controls.Add(Me.BtnExtBordNewLine)
        Me.TabExtBordereau.Name = "TabExtBordereau"
        Me.TabExtBordereau.Size = New System.Drawing.Size(1277, 682)
        Me.TabExtBordereau.Text = "Bordereau pièces détachées"
        '
        'GCExtBord
        '
        Me.GCExtBord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GCExtBord.Location = New System.Drawing.Point(111, 7)
        Me.GCExtBord.MainView = Me.GVExtBord
        Me.GCExtBord.Name = "GCExtBord"
        Me.GCExtBord.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemGLEditLstFouBord, Me.RepositoryItemTextEditNEXTBORDQTEUSE, Me.RepositoryItemTextEditNEXTBORDQTEREPL})
        Me.GCExtBord.Size = New System.Drawing.Size(1115, 665)
        Me.GCExtBord.TabIndex = 18
        Me.GCExtBord.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVExtBord})
        '
        'GVExtBord
        '
        Me.GVExtBord.Appearance.Row.BackColor = System.Drawing.Color.LightYellow
        Me.GVExtBord.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.GVExtBord.Appearance.Row.Options.UseBackColor = True
        Me.GVExtBord.Appearance.Row.Options.UseFont = True
        Me.GVExtBord.ColumnPanelRowHeight = 50
        Me.GVExtBord.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNEXTBORDID, Me.ColNEXTBORDNACTNUM, Me.ColNEXTBORDFOU, Me.ColNEXTBORDQTEUSE, Me.ColNEXTBORDQTEREPL, Me.ColNEXTBORDIDL, Me.ColNEXTBORDIDTMP})
        Me.GVExtBord.GridControl = Me.GCExtBord
        Me.GVExtBord.Name = "GVExtBord"
        Me.GVExtBord.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVExtBord.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GVExtBord.OptionsView.ShowGroupPanel = False
        Me.GVExtBord.RowHeight = 25
        '
        'ColNEXTBORDID
        '
        Me.ColNEXTBORDID.Caption = "NEXTBORDID"
        Me.ColNEXTBORDID.FieldName = "NEXTBORDID"
        Me.ColNEXTBORDID.Name = "ColNEXTBORDID"
        '
        'ColNEXTBORDNACTNUM
        '
        Me.ColNEXTBORDNACTNUM.Caption = "NACTNUM"
        Me.ColNEXTBORDNACTNUM.FieldName = "NACTNUM"
        Me.ColNEXTBORDNACTNUM.Name = "ColNEXTBORDNACTNUM"
        '
        'ColNEXTBORDFOU
        '
        Me.ColNEXTBORDFOU.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ColNEXTBORDFOU.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColNEXTBORDFOU.AppearanceHeader.Options.UseFont = True
        Me.ColNEXTBORDFOU.AppearanceHeader.Options.UseForeColor = True
        Me.ColNEXTBORDFOU.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNEXTBORDFOU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNEXTBORDFOU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNEXTBORDFOU.Caption = "Fourniture"
        Me.ColNEXTBORDFOU.ColumnEdit = Me.RepItemGLEditLstFouBord
        Me.ColNEXTBORDFOU.FieldName = "NFOUNUM"
        Me.ColNEXTBORDFOU.Name = "ColNEXTBORDFOU"
        Me.ColNEXTBORDFOU.Visible = True
        Me.ColNEXTBORDFOU.VisibleIndex = 0
        Me.ColNEXTBORDFOU.Width = 704
        '
        'RepItemGLEditLstFouBord
        '
        Me.RepItemGLEditLstFouBord.AutoHeight = False
        Me.RepItemGLEditLstFouBord.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepItemGLEditLstFouBord.DisplayMember = "VFOUMAT"
        Me.RepItemGLEditLstFouBord.ImmediatePopup = True
        Me.RepItemGLEditLstFouBord.Name = "RepItemGLEditLstFouBord"
        Me.RepItemGLEditLstFouBord.NullText = ""
        Me.RepItemGLEditLstFouBord.PopupView = Me.GVCboLstFouBord
        Me.RepItemGLEditLstFouBord.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.RepItemGLEditLstFouBord.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepItemGLEditLstFouBord.ValueMember = "NFOUNUM"
        '
        'GVCboLstFouBord
        '
        Me.GVCboLstFouBord.Appearance.Row.BackColor = System.Drawing.Color.LightCyan
        Me.GVCboLstFouBord.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.GVCboLstFouBord.Appearance.Row.Options.UseBackColor = True
        Me.GVCboLstFouBord.Appearance.Row.Options.UseFont = True
        Me.GVCboLstFouBord.ColumnPanelRowHeight = 25
        Me.GVCboLstFouBord.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColBordNFOUNUM, Me.ColBordVFOUMAT, Me.GColFouBordPrixCli})
        Me.GVCboLstFouBord.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVCboLstFouBord.Name = "GVCboLstFouBord"
        Me.GVCboLstFouBord.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVCboLstFouBord.OptionsView.ShowAutoFilterRow = True
        Me.GVCboLstFouBord.OptionsView.ShowGroupPanel = False
        Me.GVCboLstFouBord.RowHeight = 25
        '
        'ColBordNFOUNUM
        '
        Me.ColBordNFOUNUM.Caption = "NFOUNUM"
        Me.ColBordNFOUNUM.FieldName = "NFOUNUM"
        Me.ColBordNFOUNUM.Name = "ColBordNFOUNUM"
        '
        'ColBordVFOUMAT
        '
        Me.ColBordVFOUMAT.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ColBordVFOUMAT.AppearanceHeader.Options.UseFont = True
        Me.ColBordVFOUMAT.AppearanceHeader.Options.UseTextOptions = True
        Me.ColBordVFOUMAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColBordVFOUMAT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColBordVFOUMAT.Caption = "Liste des fournitures"
        Me.ColBordVFOUMAT.FieldName = "VFOUMAT"
        Me.ColBordVFOUMAT.Name = "ColBordVFOUMAT"
        Me.ColBordVFOUMAT.Visible = True
        Me.ColBordVFOUMAT.VisibleIndex = 0
        Me.ColBordVFOUMAT.Width = 300
        '
        'GColFouBordPrixCli
        '
        Me.GColFouBordPrixCli.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GColFouBordPrixCli.AppearanceHeader.Options.UseFont = True
        Me.GColFouBordPrixCli.AppearanceHeader.Options.UseTextOptions = True
        Me.GColFouBordPrixCli.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColFouBordPrixCli.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColFouBordPrixCli.Caption = "Prix de vente (En €)"
        Me.GColFouBordPrixCli.FieldName = "NPUHTCLI"
        Me.GColFouBordPrixCli.Name = "GColFouBordPrixCli"
        Me.GColFouBordPrixCli.Visible = True
        Me.GColFouBordPrixCli.VisibleIndex = 1
        '
        'ColNEXTBORDQTEUSE
        '
        Me.ColNEXTBORDQTEUSE.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ColNEXTBORDQTEUSE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColNEXTBORDQTEUSE.AppearanceHeader.Options.UseFont = True
        Me.ColNEXTBORDQTEUSE.AppearanceHeader.Options.UseForeColor = True
        Me.ColNEXTBORDQTEUSE.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNEXTBORDQTEUSE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNEXTBORDQTEUSE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNEXTBORDQTEUSE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColNEXTBORDQTEUSE.Caption = "Quantité utilisée aujoud'hui"
        Me.ColNEXTBORDQTEUSE.ColumnEdit = Me.RepositoryItemTextEditNEXTBORDQTEUSE
        Me.ColNEXTBORDQTEUSE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColNEXTBORDQTEUSE.FieldName = "NEXTBORDQTEUSE"
        Me.ColNEXTBORDQTEUSE.Name = "ColNEXTBORDQTEUSE"
        Me.ColNEXTBORDQTEUSE.Visible = True
        Me.ColNEXTBORDQTEUSE.VisibleIndex = 1
        Me.ColNEXTBORDQTEUSE.Width = 193
        '
        'RepositoryItemTextEditNEXTBORDQTEUSE
        '
        Me.RepositoryItemTextEditNEXTBORDQTEUSE.AutoHeight = False
        Me.RepositoryItemTextEditNEXTBORDQTEUSE.MaxLength = 200
        Me.RepositoryItemTextEditNEXTBORDQTEUSE.Name = "RepositoryItemTextEditNEXTBORDQTEUSE"
        '
        'ColNEXTBORDQTEREPL
        '
        Me.ColNEXTBORDQTEREPL.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ColNEXTBORDQTEREPL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColNEXTBORDQTEREPL.AppearanceHeader.Options.UseFont = True
        Me.ColNEXTBORDQTEREPL.AppearanceHeader.Options.UseForeColor = True
        Me.ColNEXTBORDQTEREPL.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNEXTBORDQTEREPL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNEXTBORDQTEREPL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColNEXTBORDQTEREPL.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColNEXTBORDQTEREPL.Caption = "Quantité à remplacer lors de la prochaine visite"
        Me.ColNEXTBORDQTEREPL.ColumnEdit = Me.RepositoryItemTextEditNEXTBORDQTEREPL
        Me.ColNEXTBORDQTEREPL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColNEXTBORDQTEREPL.FieldName = "NEXTBORDQTEREPL"
        Me.ColNEXTBORDQTEREPL.Name = "ColNEXTBORDQTEREPL"
        Me.ColNEXTBORDQTEREPL.Visible = True
        Me.ColNEXTBORDQTEREPL.VisibleIndex = 2
        Me.ColNEXTBORDQTEREPL.Width = 220
        '
        'RepositoryItemTextEditNEXTBORDQTEREPL
        '
        Me.RepositoryItemTextEditNEXTBORDQTEREPL.AutoHeight = False
        Me.RepositoryItemTextEditNEXTBORDQTEREPL.MaxLength = 20
        Me.RepositoryItemTextEditNEXTBORDQTEREPL.Name = "RepositoryItemTextEditNEXTBORDQTEREPL"
        '
        'ColNEXTBORDIDL
        '
        Me.ColNEXTBORDIDL.Caption = "NEXTBORDIDL"
        Me.ColNEXTBORDIDL.FieldName = "NEXTBORDIDL"
        Me.ColNEXTBORDIDL.Name = "ColNEXTBORDIDL"
        '
        'ColNEXTBORDIDTMP
        '
        Me.ColNEXTBORDIDTMP.Caption = "NIDTMP"
        Me.ColNEXTBORDIDTMP.FieldName = "NIDTMP"
        Me.ColNEXTBORDIDTMP.Name = "ColNEXTBORDIDTMP"
        '
        'BtnExtBordSuppLine
        '
        Me.BtnExtBordSuppLine.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnExtBordSuppLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnExtBordSuppLine.Location = New System.Drawing.Point(7, 86)
        Me.BtnExtBordSuppLine.Name = "BtnExtBordSuppLine"
        Me.BtnExtBordSuppLine.Size = New System.Drawing.Size(98, 67)
        Me.BtnExtBordSuppLine.TabIndex = 17
        Me.BtnExtBordSuppLine.Text = "Supprimer Fourniture"
        Me.BtnExtBordSuppLine.UseVisualStyleBackColor = True
        '
        'BtnExtBordNewLine
        '
        Me.BtnExtBordNewLine.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnExtBordNewLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnExtBordNewLine.Location = New System.Drawing.Point(7, 7)
        Me.BtnExtBordNewLine.Name = "BtnExtBordNewLine"
        Me.BtnExtBordNewLine.Size = New System.Drawing.Size(98, 73)
        Me.BtnExtBordNewLine.TabIndex = 16
        Me.BtnExtBordNewLine.Text = "Ajouter Fourniture"
        Me.BtnExtBordNewLine.UseVisualStyleBackColor = True
        '
        'TabExtAct
        '
        Me.TabExtAct.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TabExtAct.Appearance.Header.Options.UseFont = True
        Me.TabExtAct.Controls.Add(Me.TxtExtActCR)
        Me.TabExtAct.Name = "TabExtAct"
        Me.TabExtAct.Size = New System.Drawing.Size(1277, 682)
        Me.TabExtAct.Text = "Observations lors de la visite"
        '
        'TxtExtActCR
        '
        Me.TxtExtActCR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TxtExtActCR.Location = New System.Drawing.Point(3, 3)
        Me.TxtExtActCR.Multiline = True
        Me.TxtExtActCR.Name = "TxtExtActCR"
        Me.TxtExtActCR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtExtActCR.Size = New System.Drawing.Size(1223, 673)
        Me.TxtExtActCR.TabIndex = 27
        '
        'TabEtatDemande
        '
        Me.TabEtatDemande.Controls.Add(Me.TxtVEXTACT_OBS)
        Me.TabEtatDemande.Name = "TabEtatDemande"
        Me.TabEtatDemande.Size = New System.Drawing.Size(1277, 682)
        Me.TabEtatDemande.Text = "Etat de la demande"
        '
        'BtnQuit
        '
        Me.BtnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnQuit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnQuit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnQuit.Location = New System.Drawing.Point(12, 305)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(86, 73)
        Me.BtnQuit.TabIndex = 29
        Me.BtnQuit.Text = "Quitter"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'BtnEnregistrer
        '
        Me.BtnEnregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEnregistrer.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnEnregistrer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnEnregistrer.Location = New System.Drawing.Point(12, 12)
        Me.BtnEnregistrer.Name = "BtnEnregistrer"
        Me.BtnEnregistrer.Size = New System.Drawing.Size(86, 79)
        Me.BtnEnregistrer.TabIndex = 27
        Me.BtnEnregistrer.Text = "Regénérer le CRVP"
        Me.BtnEnregistrer.UseVisualStyleBackColor = True
        '
        'TxtVEXTACT_OBS
        '
        Me.TxtVEXTACT_OBS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtVEXTACT_OBS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TxtVEXTACT_OBS.Location = New System.Drawing.Point(27, 5)
        Me.TxtVEXTACT_OBS.Multiline = True
        Me.TxtVEXTACT_OBS.Name = "TxtVEXTACT_OBS"
        Me.TxtVEXTACT_OBS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtVEXTACT_OBS.Size = New System.Drawing.Size(1223, 673)
        Me.TxtVEXTACT_OBS.TabIndex = 28
        '
        'frmCorrectionCRVP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1395, 739)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnEnregistrer)
        Me.Controls.Add(Me.TabCtrlExt)
        Me.Name = "frmCorrectionCRVP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Correction CRVP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TabCtrlExt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCtrlExt.ResumeLayout(False)
        Me.TabExtInv.ResumeLayout(False)
        CType(Me.GCExtInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVExtInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLEditLstFou, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGridLookUpEditViewLstFou, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGridLookUpMarque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGViewMarque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEditVEXTEMPL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEditVEXTNUMERO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGridLstInvAnnee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGrdViewLstAnnee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemCheckVERIFOUI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemCheckVERIFNON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGridLookUpAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGridLookUpViewAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReItemTextEditObservation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabExtBordereau.ResumeLayout(False)
        CType(Me.GCExtBord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVExtBord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLEditLstFouBord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCboLstFouBord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEditNEXTBORDQTEUSE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEditNEXTBORDQTEREPL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabExtAct.ResumeLayout(False)
        Me.TabExtAct.PerformLayout()
        Me.TabEtatDemande.ResumeLayout(False)
        Me.TabEtatDemande.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabCtrlExt As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabExtInv As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCExtInv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVExtInv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNEXTINVID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNACTNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNFOUNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemGLEditLstFou As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepItemGridLookUpEditViewLstFou As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColLstNFOUNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLstVFOUMAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColVEXTINVLMARQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemGridLookUpMarque As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepItemGViewMarque As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepColMarqueBOLD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepColMarqueVFOUEXTMARQLIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColVEXTEMPL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEditVEXTEMPL As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ColVEXTNUMERO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEditVEXTNUMERO As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ColNEXTINVIDL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNEXTINVLANNEE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemGridLstInvAnnee As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepItemGrdViewLstAnnee As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIDANNEE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNANNEE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColVerifOUI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemCheckVERIFOUI As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ColVerifNON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemCheckVERIFNON As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ColActions As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemGridLookUpAction As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepItemGridLookUpViewAction As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColObservation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReItemTextEditObservation As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BtnExtInvEquipSuppLine As Button
    Friend WithEvents BtnExtInvEquipNewLine As Button
    Friend WithEvents TabExtBordereau As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCExtBord As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVExtBord As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNEXTBORDID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNEXTBORDNACTNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNEXTBORDFOU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemGLEditLstFouBord As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GVCboLstFouBord As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColBordNFOUNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColBordVFOUMAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColFouBordPrixCli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNEXTBORDQTEUSE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEditNEXTBORDQTEUSE As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ColNEXTBORDQTEREPL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEditNEXTBORDQTEREPL As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ColNEXTBORDIDL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNEXTBORDIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnExtBordSuppLine As Button
    Friend WithEvents BtnExtBordNewLine As Button
    Friend WithEvents TabExtAct As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TxtExtActCR As TextBox
    Friend WithEvents BtnQuit As Button
    Friend WithEvents BtnEnregistrer As Button
    Friend WithEvents TabEtatDemande As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TxtVEXTACT_OBS As TextBox
End Class
