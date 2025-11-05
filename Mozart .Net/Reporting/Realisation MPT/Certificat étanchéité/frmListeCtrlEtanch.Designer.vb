<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeCtrlEtanch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeCtrlEtanch))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCStat = New DevExpress.XtraGrid.GridControl()
        Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_NCOCHE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkNCOCHE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GCol_NDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VIDENT_EQUIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VNATUREFLUID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NCHARGETOT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NTONNAGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_PERIODICITE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_DCERTFLUIDCREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VNOMOPERATEUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_CERTIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GCol_BSD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnExportXLS = New System.Windows.Forms.Button()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRechercher = New System.Windows.Forms.Button()
        Me.GlookUpSite = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GVCboSite = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColCboSiteNCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCboSiteVSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GlookUpClient = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GVCboClient = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCCboClientNCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCCboClientVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DTP_Fin = New System.Windows.Forms.DateTimePicker()
        Me.DTP_Debut = New System.Windows.Forms.DateTimePicker()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkNCOCHE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GlookUpSite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCboSite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GlookUpClient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCboClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn3.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn3, "GridColumn3")
        Me.GridColumn3.FieldName = "NFLUIDEVIERGE"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GridColumn3.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("GridColumn3.Summary1"), resources.GetString("GridColumn3.Summary2"))})
        '
        'GCStat
        '
        resources.ApplyResources(Me.GCStat, "GCStat")
        Me.GCStat.MainView = Me.GVStat
        Me.GCStat.Name = "GCStat"
        Me.GCStat.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChkNCOCHE, Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemHyperLinkEdit2, Me.RepositoryItemButtonEdit1})
        Me.GCStat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStat})
        '
        'GVStat
        '
        Me.GVStat.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.GVStat.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStat.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVStat.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVStat.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVStat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVStat.ColumnPanelRowHeight = 60
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_NCOCHE, Me.GCol_NDINNUM, Me.GCol_VCLINOM, Me.GCol_VSITNOM, Me.GCol_VIDENT_EQUIP, Me.GCol_VNATUREFLUID, Me.GCol_NCHARGETOT, Me.GCol_NTONNAGE, Me.GCol_PERIODICITE, Me.GCol_DCERTFLUIDCREE, Me.GCol_VNOMOPERATEUR, Me.GCol_CERTIF, Me.GCol_BSD, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.GVStat.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        GridFormatRule1.Column = Me.GridColumn3
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.GreenYellow
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue1.Expression = "[NFLUIDEVIERGE] > 0"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.GVStat.FormatRules.Add(GridFormatRule1)
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVStat.OptionsCustomization.AllowGroup = False
        Me.GVStat.OptionsPrint.ExpandAllDetails = True
        Me.GVStat.OptionsPrint.PrintPreview = True
        Me.GVStat.OptionsView.ShowAutoFilterRow = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'GCol_NCOCHE
        '
        Me.GCol_NCOCHE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_NCOCHE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GCol_NCOCHE, "GCol_NCOCHE")
        Me.GCol_NCOCHE.ColumnEdit = Me.RepItemChkNCOCHE
        Me.GCol_NCOCHE.FieldName = "NCOCHE"
        Me.GCol_NCOCHE.Name = "GCol_NCOCHE"
        '
        'RepItemChkNCOCHE
        '
        resources.ApplyResources(Me.RepItemChkNCOCHE, "RepItemChkNCOCHE")
        Me.RepItemChkNCOCHE.Name = "RepItemChkNCOCHE"
        Me.RepItemChkNCOCHE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChkNCOCHE.ValueChecked = 1
        Me.RepItemChkNCOCHE.ValueUnchecked = 0
        '
        'GCol_NDINNUM
        '
        Me.GCol_NDINNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_NDINNUM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GCol_NDINNUM, "GCol_NDINNUM")
        Me.GCol_NDINNUM.FieldName = "NDINNUM"
        Me.GCol_NDINNUM.Name = "GCol_NDINNUM"
        Me.GCol_NDINNUM.OptionsColumn.AllowEdit = False
        Me.GCol_NDINNUM.OptionsColumn.ReadOnly = True
        '
        'GCol_VCLINOM
        '
        Me.GCol_VCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VCLINOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GCol_VCLINOM, "GCol_VCLINOM")
        Me.GCol_VCLINOM.FieldName = "VCLINOM"
        Me.GCol_VCLINOM.Name = "GCol_VCLINOM"
        Me.GCol_VCLINOM.OptionsColumn.AllowEdit = False
        Me.GCol_VCLINOM.OptionsColumn.ReadOnly = True
        '
        'GCol_VSITNOM
        '
        Me.GCol_VSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VSITNOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GCol_VSITNOM, "GCol_VSITNOM")
        Me.GCol_VSITNOM.FieldName = "VSITNOM"
        Me.GCol_VSITNOM.Name = "GCol_VSITNOM"
        Me.GCol_VSITNOM.OptionsColumn.AllowEdit = False
        Me.GCol_VSITNOM.OptionsColumn.ReadOnly = True
        '
        'GCol_VIDENT_EQUIP
        '
        Me.GCol_VIDENT_EQUIP.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VIDENT_EQUIP.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GCol_VIDENT_EQUIP, "GCol_VIDENT_EQUIP")
        Me.GCol_VIDENT_EQUIP.FieldName = "VIDENT_EQUIP"
        Me.GCol_VIDENT_EQUIP.Name = "GCol_VIDENT_EQUIP"
        Me.GCol_VIDENT_EQUIP.OptionsColumn.AllowEdit = False
        Me.GCol_VIDENT_EQUIP.OptionsColumn.ReadOnly = True
        '
        'GCol_VNATUREFLUID
        '
        Me.GCol_VNATUREFLUID.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VNATUREFLUID.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GCol_VNATUREFLUID, "GCol_VNATUREFLUID")
        Me.GCol_VNATUREFLUID.FieldName = "VNATUREFLUID"
        Me.GCol_VNATUREFLUID.Name = "GCol_VNATUREFLUID"
        Me.GCol_VNATUREFLUID.OptionsColumn.AllowEdit = False
        Me.GCol_VNATUREFLUID.OptionsColumn.ReadOnly = True
        '
        'GCol_NCHARGETOT
        '
        Me.GCol_NCHARGETOT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_NCHARGETOT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GCol_NCHARGETOT, "GCol_NCHARGETOT")
        Me.GCol_NCHARGETOT.FieldName = "NCHARGETOT"
        Me.GCol_NCHARGETOT.Name = "GCol_NCHARGETOT"
        Me.GCol_NCHARGETOT.OptionsColumn.AllowEdit = False
        Me.GCol_NCHARGETOT.OptionsColumn.ReadOnly = True
        '
        'GCol_NTONNAGE
        '
        Me.GCol_NTONNAGE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_NTONNAGE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GCol_NTONNAGE, "GCol_NTONNAGE")
        Me.GCol_NTONNAGE.FieldName = "NTONNAGE"
        Me.GCol_NTONNAGE.Name = "GCol_NTONNAGE"
        Me.GCol_NTONNAGE.OptionsColumn.AllowEdit = False
        Me.GCol_NTONNAGE.OptionsColumn.ReadOnly = True
        '
        'GCol_PERIODICITE
        '
        Me.GCol_PERIODICITE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_PERIODICITE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GCol_PERIODICITE, "GCol_PERIODICITE")
        Me.GCol_PERIODICITE.FieldName = "PERIODICITE"
        Me.GCol_PERIODICITE.Name = "GCol_PERIODICITE"
        Me.GCol_PERIODICITE.OptionsColumn.AllowEdit = False
        Me.GCol_PERIODICITE.OptionsColumn.ReadOnly = True
        '
        'GCol_DCERTFLUIDCREE
        '
        Me.GCol_DCERTFLUIDCREE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_DCERTFLUIDCREE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GCol_DCERTFLUIDCREE, "GCol_DCERTFLUIDCREE")
        Me.GCol_DCERTFLUIDCREE.FieldName = "DCERTFLUIDCREE"
        Me.GCol_DCERTFLUIDCREE.Name = "GCol_DCERTFLUIDCREE"
        Me.GCol_DCERTFLUIDCREE.OptionsColumn.AllowEdit = False
        Me.GCol_DCERTFLUIDCREE.OptionsColumn.ReadOnly = True
        '
        'GCol_VNOMOPERATEUR
        '
        Me.GCol_VNOMOPERATEUR.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VNOMOPERATEUR.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GCol_VNOMOPERATEUR, "GCol_VNOMOPERATEUR")
        Me.GCol_VNOMOPERATEUR.FieldName = "VNOMOPERATEUR"
        Me.GCol_VNOMOPERATEUR.Name = "GCol_VNOMOPERATEUR"
        Me.GCol_VNOMOPERATEUR.OptionsColumn.AllowEdit = False
        Me.GCol_VNOMOPERATEUR.OptionsColumn.ReadOnly = True
        '
        'GCol_CERTIF
        '
        Me.GCol_CERTIF.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_CERTIF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_CERTIF.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_CERTIF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_CERTIF.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GCol_CERTIF, "GCol_CERTIF")
        Me.GCol_CERTIF.ColumnEdit = Me.RepositoryItemHyperLinkEdit1
        Me.GCol_CERTIF.FieldName = "CERTIF"
        Me.GCol_CERTIF.Name = "GCol_CERTIF"
        Me.GCol_CERTIF.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemHyperLinkEdit1
        '
        resources.ApplyResources(Me.RepositoryItemHyperLinkEdit1, "RepositoryItemHyperLinkEdit1")
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        Me.RepositoryItemHyperLinkEdit1.SingleClick = True
        '
        'GCol_BSD
        '
        Me.GCol_BSD.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_BSD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_BSD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_BSD.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_BSD.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GCol_BSD, "GCol_BSD")
        Me.GCol_BSD.ColumnEdit = Me.RepositoryItemHyperLinkEdit2
        Me.GCol_BSD.FieldName = "BSD"
        Me.GCol_BSD.Name = "GCol_BSD"
        Me.GCol_BSD.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemHyperLinkEdit2
        '
        resources.ApplyResources(Me.RepositoryItemHyperLinkEdit2, "RepositoryItemHyperLinkEdit2")
        Me.RepositoryItemHyperLinkEdit2.Name = "RepositoryItemHyperLinkEdit2"
        Me.RepositoryItemHyperLinkEdit2.SingleClick = True
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn1.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.FieldName = "NFLUIDERECUP"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GridColumn1.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("GridColumn1.Summary1"), resources.GetString("GridColumn1.Summary2"))})
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn2.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn2, "GridColumn2")
        Me.GridColumn2.FieldName = "NFLUIDRECYC"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GridColumn2.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("GridColumn2.Summary1"), resources.GetString("GridColumn2.Summary2"))})
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn4.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn4.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GridColumn4, "GridColumn4")
        Me.GridColumn4.FieldName = "NFLUIDERETOURNE"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GridColumn4.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("GridColumn4.Summary1"), resources.GetString("GridColumn4.Summary2"))})
        '
        'GridColumn5
        '
        resources.ApplyResources(Me.GridColumn5, "GridColumn5")
        Me.GridColumn5.FieldName = "VFILECERT"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        resources.ApplyResources(Me.GridColumn6, "GridColumn6")
        Me.GridColumn6.FieldName = "VFILEBSD"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'RepositoryItemButtonEdit1
        '
        resources.ApplyResources(Me.RepositoryItemButtonEdit1, "RepositoryItemButtonEdit1")
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnExportXLS)
        Me.GrpActions.Controls.Add(Me.BtnSend)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnExportXLS
        '
        resources.ApplyResources(Me.BtnExportXLS, "BtnExportXLS")
        Me.BtnExportXLS.Name = "BtnExportXLS"
        Me.BtnExportXLS.UseVisualStyleBackColor = True
        '
        'BtnSend
        '
        resources.ApplyResources(Me.BtnSend, "BtnSend")
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnRechercher)
        Me.GroupBox1.Controls.Add(Me.GlookUpSite)
        Me.GroupBox1.Controls.Add(Me.GlookUpClient)
        Me.GroupBox1.Controls.Add(Me.DTP_Fin)
        Me.GroupBox1.Controls.Add(Me.DTP_Debut)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
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
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'BtnRechercher
        '
        resources.ApplyResources(Me.BtnRechercher, "BtnRechercher")
        Me.BtnRechercher.Name = "BtnRechercher"
        Me.BtnRechercher.UseVisualStyleBackColor = True
        '
        'GlookUpSite
        '
        resources.ApplyResources(Me.GlookUpSite, "GlookUpSite")
        Me.GlookUpSite.Name = "GlookUpSite"
        Me.GlookUpSite.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GlookUpSite.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.GlookUpSite.Properties.DisplayMember = "VSITNOM"
        Me.GlookUpSite.Properties.NullText = resources.GetString("GlookUpSite.Properties.NullText")
        Me.GlookUpSite.Properties.PopupView = Me.GVCboSite
        Me.GlookUpSite.Properties.ValueMember = "NSITNUM"
        '
        'GVCboSite
        '
        Me.GVCboSite.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCboSiteNCLINUM, Me.GColCboSiteVSITNOM})
        Me.GVCboSite.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVCboSite.Name = "GVCboSite"
        Me.GVCboSite.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVCboSite.OptionsView.ShowAutoFilterRow = True
        Me.GVCboSite.OptionsView.ShowGroupPanel = False
        '
        'GColCboSiteNCLINUM
        '
        Me.GColCboSiteNCLINUM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColCboSiteNCLINUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCboSiteNCLINUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColCboSiteNCLINUM, "GColCboSiteNCLINUM")
        Me.GColCboSiteNCLINUM.FieldName = "NCLINUM"
        Me.GColCboSiteNCLINUM.Name = "GColCboSiteNCLINUM"
        Me.GColCboSiteNCLINUM.OptionsColumn.AllowEdit = False
        Me.GColCboSiteNCLINUM.OptionsColumn.ReadOnly = True
        '
        'GColCboSiteVSITNOM
        '
        Me.GColCboSiteVSITNOM.AppearanceHeader.Font = CType(resources.GetObject("GColCboSiteVSITNOM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColCboSiteVSITNOM.AppearanceHeader.Options.UseFont = True
        Me.GColCboSiteVSITNOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColCboSiteVSITNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCboSiteVSITNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColCboSiteVSITNOM, "GColCboSiteVSITNOM")
        Me.GColCboSiteVSITNOM.FieldName = "VSITNOM"
        Me.GColCboSiteVSITNOM.Name = "GColCboSiteVSITNOM"
        Me.GColCboSiteVSITNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GlookUpClient
        '
        resources.ApplyResources(Me.GlookUpClient, "GlookUpClient")
        Me.GlookUpClient.Name = "GlookUpClient"
        Me.GlookUpClient.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GlookUpClient.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.GlookUpClient.Properties.DisplayMember = "VCLINOM"
        Me.GlookUpClient.Properties.NullText = resources.GetString("GlookUpClient.Properties.NullText")
        Me.GlookUpClient.Properties.PopupView = Me.GVCboClient
        Me.GlookUpClient.Properties.ValueMember = "NCLINUM"
        '
        'GVCboClient
        '
        Me.GVCboClient.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCCboClientNCLINUM, Me.GCCboClientVCLINOM})
        Me.GVCboClient.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVCboClient.Name = "GVCboClient"
        Me.GVCboClient.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVCboClient.OptionsView.ShowAutoFilterRow = True
        Me.GVCboClient.OptionsView.ShowGroupPanel = False
        '
        'GCCboClientNCLINUM
        '
        Me.GCCboClientNCLINUM.AppearanceHeader.Options.UseTextOptions = True
        Me.GCCboClientNCLINUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCCboClientNCLINUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCCboClientNCLINUM.FieldName = "NCLINUM"
        Me.GCCboClientNCLINUM.Name = "GCCboClientNCLINUM"
        Me.GCCboClientNCLINUM.OptionsColumn.AllowEdit = False
        Me.GCCboClientNCLINUM.OptionsColumn.ReadOnly = True
        '
        'GCCboClientVCLINOM
        '
        Me.GCCboClientVCLINOM.AppearanceHeader.Font = CType(resources.GetObject("GCCboClientVCLINOM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GCCboClientVCLINOM.AppearanceHeader.Options.UseFont = True
        Me.GCCboClientVCLINOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GCCboClientVCLINOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCCboClientVCLINOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GCCboClientVCLINOM, "GCCboClientVCLINOM")
        Me.GCCboClientVCLINOM.FieldName = "VCLINOM"
        Me.GCCboClientVCLINOM.Name = "GCCboClientVCLINOM"
        Me.GCCboClientVCLINOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'DTP_Fin
        '
        resources.ApplyResources(Me.DTP_Fin, "DTP_Fin")
        Me.DTP_Fin.Name = "DTP_Fin"
        '
        'DTP_Debut
        '
        resources.ApplyResources(Me.DTP_Debut, "DTP_Debut")
        Me.DTP_Debut.Name = "DTP_Debut"
        '
        'frmListeCtrlEtanch
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmListeCtrlEtanch"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkNCOCHE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GlookUpSite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCboSite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GlookUpClient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCboClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LblTitre As Label
    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnExportXLS As Button
    Friend WithEvents BtnSend As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DTP_Fin As DateTimePicker
    Friend WithEvents DTP_Debut As DateTimePicker
    Friend WithEvents BtnRechercher As Button
    Private WithEvents GlookUpSite As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GVCboSite As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColCboSiteNCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCboSiteVSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GlookUpClient As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GVCboClient As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCCboClientNCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCCboClientVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GCol_NCOCHE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VIDENT_EQUIP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VNATUREFLUID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NCHARGETOT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NTONNAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_PERIODICITE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_DCERTFLUIDCREE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VNOMOPERATEUR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_CERTIF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_BSD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemChkNCOCHE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents SFD As SaveFileDialog
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemHyperLinkEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
