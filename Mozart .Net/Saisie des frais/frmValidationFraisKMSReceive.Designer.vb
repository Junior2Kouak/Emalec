<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValidationFraisKMSReceive
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmValidationFraisKMSReceive))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.BGColVISAFRAIS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColVTYPEREPASDETAIL = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColNKMSPARCOURS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnArchives = New System.Windows.Forms.Button()
        Me.BtnImp = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GCFraisJourSyntheseSem = New DevExpress.XtraGrid.GridControl()
        Me.BGFraisJourSyntheseSem = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GBandDate = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGColNIDFRAISJOUR = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColNIDKMSTECH = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColNIDREPASTECHUNIQUE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColVPERNOMTECH = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColDFRAISJOUR = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColVVEHTECH = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBandDestination = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGColVCLINOM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColVSITNOM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBandKms = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGColNKMSDEPART = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColNKMSARRIVEE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColNCANNUM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBandIndemnites = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGColNMONTANTGD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBandTransfert = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGColDFRAISJOURTRANS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColDVISAFRAIS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColBKMSTECHASTREINTE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColBFRAISJOURTRANSVALID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColNVEHNUM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColNPERNUM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColVTYPEREPAS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColBKMSTECHVEHLOC = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpSelectPeriode = New System.Windows.Forms.GroupBox()
        Me.GLookUpTech = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEditListeTech = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GVListeTechNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVListeTechVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblTech = New System.Windows.Forms.Label()
        Me.lblsem = New System.Windows.Forms.Label()
        Me.DateEditChoixSem = New DevExpress.XtraEditors.DateEdit()
        Me.GrpActions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GCFraisJourSyntheseSem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BGFraisJourSyntheseSem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSelectPeriode.SuspendLayout()
        CType(Me.GLookUpTech.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEditListeTech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditChoixSem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditChoixSem.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BGColVISAFRAIS
        '
        Me.BGColVISAFRAIS.AppearanceCell.Font = CType(resources.GetObject("BGColVISAFRAIS.AppearanceCell.Font"), System.Drawing.Font)
        Me.BGColVISAFRAIS.AppearanceCell.ForeColor = System.Drawing.Color.Blue
        Me.BGColVISAFRAIS.AppearanceCell.Options.UseFont = True
        Me.BGColVISAFRAIS.AppearanceCell.Options.UseForeColor = True
        Me.BGColVISAFRAIS.AppearanceCell.Options.UseTextOptions = True
        Me.BGColVISAFRAIS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVISAFRAIS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColVISAFRAIS.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BGColVISAFRAIS.AppearanceHeader.Font = CType(resources.GetObject("BGColVISAFRAIS.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColVISAFRAIS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColVISAFRAIS.AppearanceHeader.Options.UseFont = True
        Me.BGColVISAFRAIS.AppearanceHeader.Options.UseForeColor = True
        Me.BGColVISAFRAIS.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColVISAFRAIS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVISAFRAIS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColVISAFRAIS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        resources.ApplyResources(Me.BGColVISAFRAIS, "BGColVISAFRAIS")
        Me.BGColVISAFRAIS.FieldName = "VISAFRAIS"
        Me.BGColVISAFRAIS.Name = "BGColVISAFRAIS"
        Me.BGColVISAFRAIS.OptionsColumn.AllowEdit = False
        Me.BGColVISAFRAIS.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.BGColVISAFRAIS.OptionsColumn.AllowMove = False
        Me.BGColVISAFRAIS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.BGColVISAFRAIS.OptionsColumn.ReadOnly = True
        '
        'BGColVTYPEREPASDETAIL
        '
        Me.BGColVTYPEREPASDETAIL.AppearanceCell.Font = CType(resources.GetObject("BGColVTYPEREPASDETAIL.AppearanceCell.Font"), System.Drawing.Font)
        Me.BGColVTYPEREPASDETAIL.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.BGColVTYPEREPASDETAIL.AppearanceCell.Options.UseFont = True
        Me.BGColVTYPEREPASDETAIL.AppearanceCell.Options.UseForeColor = True
        Me.BGColVTYPEREPASDETAIL.AppearanceCell.Options.UseTextOptions = True
        Me.BGColVTYPEREPASDETAIL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVTYPEREPASDETAIL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColVTYPEREPASDETAIL.AppearanceHeader.Font = CType(resources.GetObject("BGColVTYPEREPASDETAIL.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColVTYPEREPASDETAIL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColVTYPEREPASDETAIL.AppearanceHeader.Options.UseFont = True
        Me.BGColVTYPEREPASDETAIL.AppearanceHeader.Options.UseForeColor = True
        Me.BGColVTYPEREPASDETAIL.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColVTYPEREPASDETAIL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVTYPEREPASDETAIL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGColVTYPEREPASDETAIL, "BGColVTYPEREPASDETAIL")
        Me.BGColVTYPEREPASDETAIL.FieldName = "VTYPEREPASDETAIL"
        Me.BGColVTYPEREPASDETAIL.Name = "BGColVTYPEREPASDETAIL"
        Me.BGColVTYPEREPASDETAIL.OptionsColumn.AllowEdit = False
        Me.BGColVTYPEREPASDETAIL.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.BGColVTYPEREPASDETAIL.OptionsColumn.AllowMove = False
        Me.BGColVTYPEREPASDETAIL.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.BGColVTYPEREPASDETAIL.OptionsColumn.ReadOnly = True
        '
        'BGColNKMSPARCOURS
        '
        Me.BGColNKMSPARCOURS.AppearanceCell.Options.UseTextOptions = True
        Me.BGColNKMSPARCOURS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.BGColNKMSPARCOURS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColNKMSPARCOURS.AppearanceHeader.Font = CType(resources.GetObject("BGColNKMSPARCOURS.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColNKMSPARCOURS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColNKMSPARCOURS.AppearanceHeader.Options.UseFont = True
        Me.BGColNKMSPARCOURS.AppearanceHeader.Options.UseForeColor = True
        Me.BGColNKMSPARCOURS.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColNKMSPARCOURS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColNKMSPARCOURS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColNKMSPARCOURS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGColNKMSPARCOURS, "BGColNKMSPARCOURS")
        Me.BGColNKMSPARCOURS.DisplayFormat.FormatString = "n0"
        Me.BGColNKMSPARCOURS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGColNKMSPARCOURS.FieldName = "NKMSPARCOURS"
        Me.BGColNKMSPARCOURS.Name = "BGColNKMSPARCOURS"
        Me.BGColNKMSPARCOURS.OptionsColumn.AllowEdit = False
        Me.BGColNKMSPARCOURS.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.BGColNKMSPARCOURS.OptionsColumn.AllowMove = False
        Me.BGColNKMSPARCOURS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.BGColNKMSPARCOURS.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGColNKMSPARCOURS.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGColNKMSPARCOURS.Summary1"), resources.GetString("BGColNKMSPARCOURS.Summary2"))})
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnArchives)
        Me.GrpActions.Controls.Add(Me.BtnImp)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnArchives
        '
        Me.BtnArchives.BackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.BtnArchives, "BtnArchives")
        Me.BtnArchives.Name = "BtnArchives"
        Me.BtnArchives.UseVisualStyleBackColor = False
        '
        'BtnImp
        '
        Me.BtnImp.BackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.BtnImp, "BtnImp")
        Me.BtnImp.Name = "BtnImp"
        Me.BtnImp.UseVisualStyleBackColor = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GCFraisJourSyntheseSem)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'GCFraisJourSyntheseSem
        '
        resources.ApplyResources(Me.GCFraisJourSyntheseSem, "GCFraisJourSyntheseSem")
        Me.GCFraisJourSyntheseSem.MainView = Me.BGFraisJourSyntheseSem
        Me.GCFraisJourSyntheseSem.Name = "GCFraisJourSyntheseSem"
        Me.GCFraisJourSyntheseSem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BGFraisJourSyntheseSem})
        '
        'BGFraisJourSyntheseSem
        '
        Me.BGFraisJourSyntheseSem.BandPanelRowHeight = 40
        Me.BGFraisJourSyntheseSem.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GBandDate, Me.GBandDestination, Me.GBandKms, Me.GBandIndemnites, Me.GBandTransfert})
        Me.BGFraisJourSyntheseSem.ColumnPanelRowHeight = 40
        Me.BGFraisJourSyntheseSem.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BGColNIDFRAISJOUR, Me.BGColNIDKMSTECH, Me.BGColVPERNOMTECH, Me.BGColNIDREPASTECHUNIQUE, Me.BGColDFRAISJOUR, Me.BGColDFRAISJOURTRANS, Me.BGColVCLINOM, Me.BGColVSITNOM, Me.BGColNKMSDEPART, Me.BGColNKMSARRIVEE, Me.BGColNKMSPARCOURS, Me.BGColNCANNUM, Me.BGColBKMSTECHASTREINTE, Me.BGColVTYPEREPASDETAIL, Me.BGColVISAFRAIS, Me.BGColBFRAISJOURTRANSVALID, Me.BGColDVISAFRAIS, Me.BGColNVEHNUM, Me.BGColVVEHTECH, Me.BGColNPERNUM, Me.BGColNMONTANTGD, Me.BGColVTYPEREPAS, Me.BGColBKMSTECHVEHLOC})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Yellow
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Column = Me.BGColVISAFRAIS
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "ISNULL([DVISAFRAIS]) == TRUE"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Yellow
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Column = Me.BGColVTYPEREPASDETAIL
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "[VTYPEREPAS] == 'GD' AND [NMONTANTGD]  <=  0"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Column = Me.BGColNKMSPARCOURS
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition3.Expression = "[NKMSPARCOURS] >= 1000"
        StyleFormatCondition3.Value1 = "1000"
        Me.BGFraisJourSyntheseSem.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.BGFraisJourSyntheseSem.GridControl = Me.GCFraisJourSyntheseSem
        Me.BGFraisJourSyntheseSem.Name = "BGFraisJourSyntheseSem"
        Me.BGFraisJourSyntheseSem.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.BGFraisJourSyntheseSem.OptionsView.AllowCellMerge = True
        Me.BGFraisJourSyntheseSem.OptionsView.ShowFooter = True
        Me.BGFraisJourSyntheseSem.OptionsView.ShowGroupPanel = False
        Me.BGFraisJourSyntheseSem.RowHeight = 40
        '
        'GBandDate
        '
        Me.GBandDate.AppearanceHeader.Font = CType(resources.GetObject("GBandDate.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBandDate.AppearanceHeader.Options.UseFont = True
        Me.GBandDate.AppearanceHeader.Options.UseTextOptions = True
        Me.GBandDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBandDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GBandDate.Columns.Add(Me.BGColNIDFRAISJOUR)
        Me.GBandDate.Columns.Add(Me.BGColNIDKMSTECH)
        Me.GBandDate.Columns.Add(Me.BGColNIDREPASTECHUNIQUE)
        Me.GBandDate.Columns.Add(Me.BGColVPERNOMTECH)
        Me.GBandDate.Columns.Add(Me.BGColDFRAISJOUR)
        Me.GBandDate.Columns.Add(Me.BGColVVEHTECH)
        resources.ApplyResources(Me.GBandDate, "GBandDate")
        Me.GBandDate.VisibleIndex = 0
        '
        'BGColNIDFRAISJOUR
        '
        resources.ApplyResources(Me.BGColNIDFRAISJOUR, "BGColNIDFRAISJOUR")
        Me.BGColNIDFRAISJOUR.FieldName = "NIDFRAISJOUR"
        Me.BGColNIDFRAISJOUR.Name = "BGColNIDFRAISJOUR"
        '
        'BGColNIDKMSTECH
        '
        resources.ApplyResources(Me.BGColNIDKMSTECH, "BGColNIDKMSTECH")
        Me.BGColNIDKMSTECH.FieldName = "NIDKMSTECH"
        Me.BGColNIDKMSTECH.Name = "BGColNIDKMSTECH"
        '
        'BGColNIDREPASTECHUNIQUE
        '
        resources.ApplyResources(Me.BGColNIDREPASTECHUNIQUE, "BGColNIDREPASTECHUNIQUE")
        Me.BGColNIDREPASTECHUNIQUE.FieldName = "NIDREPASTECHUNIQUE"
        Me.BGColNIDREPASTECHUNIQUE.Name = "BGColNIDREPASTECHUNIQUE"
        '
        'BGColVPERNOMTECH
        '
        Me.BGColVPERNOMTECH.AppearanceCell.Options.UseTextOptions = True
        Me.BGColVPERNOMTECH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVPERNOMTECH.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColVPERNOMTECH.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BGColVPERNOMTECH.AppearanceHeader.Font = CType(resources.GetObject("BGColVPERNOMTECH.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColVPERNOMTECH.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColVPERNOMTECH.AppearanceHeader.Options.UseFont = True
        Me.BGColVPERNOMTECH.AppearanceHeader.Options.UseForeColor = True
        Me.BGColVPERNOMTECH.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColVPERNOMTECH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVPERNOMTECH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColVPERNOMTECH.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGColVPERNOMTECH, "BGColVPERNOMTECH")
        Me.BGColVPERNOMTECH.FieldName = "VPERNOMTECH"
        Me.BGColVPERNOMTECH.Name = "BGColVPERNOMTECH"
        '
        'BGColDFRAISJOUR
        '
        Me.BGColDFRAISJOUR.AppearanceCell.Options.UseTextOptions = True
        Me.BGColDFRAISJOUR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColDFRAISJOUR.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColDFRAISJOUR.AppearanceHeader.Font = CType(resources.GetObject("BGColDFRAISJOUR.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColDFRAISJOUR.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColDFRAISJOUR.AppearanceHeader.Options.UseFont = True
        Me.BGColDFRAISJOUR.AppearanceHeader.Options.UseForeColor = True
        Me.BGColDFRAISJOUR.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColDFRAISJOUR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColDFRAISJOUR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGColDFRAISJOUR, "BGColDFRAISJOUR")
        Me.BGColDFRAISJOUR.DisplayFormat.FormatString = "d"
        Me.BGColDFRAISJOUR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.BGColDFRAISJOUR.FieldName = "DFRAISJOUR"
        Me.BGColDFRAISJOUR.Name = "BGColDFRAISJOUR"
        Me.BGColDFRAISJOUR.OptionsColumn.AllowEdit = False
        Me.BGColDFRAISJOUR.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.BGColDFRAISJOUR.OptionsColumn.AllowMove = False
        Me.BGColDFRAISJOUR.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.BGColDFRAISJOUR.OptionsColumn.ReadOnly = True
        '
        'BGColVVEHTECH
        '
        Me.BGColVVEHTECH.AppearanceCell.Options.UseTextOptions = True
        Me.BGColVVEHTECH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVVEHTECH.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColVVEHTECH.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BGColVVEHTECH.AppearanceHeader.Font = CType(resources.GetObject("BGColVVEHTECH.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColVVEHTECH.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColVVEHTECH.AppearanceHeader.Options.UseFont = True
        Me.BGColVVEHTECH.AppearanceHeader.Options.UseForeColor = True
        Me.BGColVVEHTECH.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColVVEHTECH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVVEHTECH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColVVEHTECH.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGColVVEHTECH, "BGColVVEHTECH")
        Me.BGColVVEHTECH.FieldName = "VVEHTECH"
        Me.BGColVVEHTECH.Name = "BGColVVEHTECH"
        '
        'GBandDestination
        '
        Me.GBandDestination.AppearanceHeader.Font = CType(resources.GetObject("GBandDestination.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBandDestination.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GBandDestination.AppearanceHeader.Options.UseFont = True
        Me.GBandDestination.AppearanceHeader.Options.UseForeColor = True
        Me.GBandDestination.AppearanceHeader.Options.UseTextOptions = True
        Me.GBandDestination.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBandDestination.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GBandDestination, "GBandDestination")
        Me.GBandDestination.Columns.Add(Me.BGColVCLINOM)
        Me.GBandDestination.Columns.Add(Me.BGColVSITNOM)
        Me.GBandDestination.VisibleIndex = 1
        '
        'BGColVCLINOM
        '
        Me.BGColVCLINOM.AppearanceCell.Options.UseTextOptions = True
        Me.BGColVCLINOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVCLINOM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColVCLINOM.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BGColVCLINOM.AppearanceHeader.Font = CType(resources.GetObject("BGColVCLINOM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColVCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColVCLINOM.AppearanceHeader.Options.UseFont = True
        Me.BGColVCLINOM.AppearanceHeader.Options.UseForeColor = True
        Me.BGColVCLINOM.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColVCLINOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVCLINOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGColVCLINOM, "BGColVCLINOM")
        Me.BGColVCLINOM.FieldName = "VCLINOM"
        Me.BGColVCLINOM.Name = "BGColVCLINOM"
        Me.BGColVCLINOM.OptionsColumn.AllowEdit = False
        Me.BGColVCLINOM.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.BGColVCLINOM.OptionsColumn.AllowMove = False
        Me.BGColVCLINOM.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.BGColVCLINOM.OptionsColumn.ReadOnly = True
        '
        'BGColVSITNOM
        '
        Me.BGColVSITNOM.AppearanceCell.Font = CType(resources.GetObject("BGColVSITNOM.AppearanceCell.Font"), System.Drawing.Font)
        Me.BGColVSITNOM.AppearanceCell.Options.UseFont = True
        Me.BGColVSITNOM.AppearanceCell.Options.UseTextOptions = True
        Me.BGColVSITNOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVSITNOM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColVSITNOM.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BGColVSITNOM.AppearanceHeader.Font = CType(resources.GetObject("BGColVSITNOM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColVSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColVSITNOM.AppearanceHeader.Options.UseFont = True
        Me.BGColVSITNOM.AppearanceHeader.Options.UseForeColor = True
        Me.BGColVSITNOM.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColVSITNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVSITNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGColVSITNOM, "BGColVSITNOM")
        Me.BGColVSITNOM.FieldName = "VSITNOM"
        Me.BGColVSITNOM.Name = "BGColVSITNOM"
        Me.BGColVSITNOM.OptionsColumn.AllowEdit = False
        Me.BGColVSITNOM.OptionsColumn.AllowMove = False
        Me.BGColVSITNOM.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.BGColVSITNOM.OptionsColumn.ReadOnly = True
        '
        'GBandKms
        '
        Me.GBandKms.AppearanceHeader.Font = CType(resources.GetObject("GBandKms.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBandKms.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GBandKms.AppearanceHeader.Options.UseFont = True
        Me.GBandKms.AppearanceHeader.Options.UseForeColor = True
        Me.GBandKms.AppearanceHeader.Options.UseTextOptions = True
        Me.GBandKms.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBandKms.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GBandKms, "GBandKms")
        Me.GBandKms.Columns.Add(Me.BGColNKMSDEPART)
        Me.GBandKms.Columns.Add(Me.BGColNKMSARRIVEE)
        Me.GBandKms.Columns.Add(Me.BGColNKMSPARCOURS)
        Me.GBandKms.Columns.Add(Me.BGColNCANNUM)
        Me.GBandKms.VisibleIndex = 2
        '
        'BGColNKMSDEPART
        '
        Me.BGColNKMSDEPART.AppearanceCell.Options.UseTextOptions = True
        Me.BGColNKMSDEPART.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.BGColNKMSDEPART.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColNKMSDEPART.AppearanceHeader.Font = CType(resources.GetObject("BGColNKMSDEPART.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColNKMSDEPART.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColNKMSDEPART.AppearanceHeader.Options.UseFont = True
        Me.BGColNKMSDEPART.AppearanceHeader.Options.UseForeColor = True
        Me.BGColNKMSDEPART.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColNKMSDEPART.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColNKMSDEPART.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColNKMSDEPART.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGColNKMSDEPART, "BGColNKMSDEPART")
        Me.BGColNKMSDEPART.DisplayFormat.FormatString = "n0"
        Me.BGColNKMSDEPART.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGColNKMSDEPART.FieldName = "NKMSDEPART"
        Me.BGColNKMSDEPART.Name = "BGColNKMSDEPART"
        Me.BGColNKMSDEPART.OptionsColumn.AllowEdit = False
        Me.BGColNKMSDEPART.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.BGColNKMSDEPART.OptionsColumn.AllowMove = False
        Me.BGColNKMSDEPART.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'BGColNKMSARRIVEE
        '
        Me.BGColNKMSARRIVEE.AppearanceCell.Options.UseTextOptions = True
        Me.BGColNKMSARRIVEE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.BGColNKMSARRIVEE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColNKMSARRIVEE.AppearanceHeader.Font = CType(resources.GetObject("BGColNKMSARRIVEE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColNKMSARRIVEE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColNKMSARRIVEE.AppearanceHeader.Options.UseFont = True
        Me.BGColNKMSARRIVEE.AppearanceHeader.Options.UseForeColor = True
        Me.BGColNKMSARRIVEE.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColNKMSARRIVEE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColNKMSARRIVEE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColNKMSARRIVEE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGColNKMSARRIVEE, "BGColNKMSARRIVEE")
        Me.BGColNKMSARRIVEE.DisplayFormat.FormatString = "n0"
        Me.BGColNKMSARRIVEE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGColNKMSARRIVEE.FieldName = "NKMSARRIVEE"
        Me.BGColNKMSARRIVEE.Name = "BGColNKMSARRIVEE"
        Me.BGColNKMSARRIVEE.OptionsColumn.AllowEdit = False
        Me.BGColNKMSARRIVEE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.BGColNKMSARRIVEE.OptionsColumn.AllowMove = False
        Me.BGColNKMSARRIVEE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'BGColNCANNUM
        '
        Me.BGColNCANNUM.AppearanceCell.Options.UseTextOptions = True
        Me.BGColNCANNUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColNCANNUM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColNCANNUM.AppearanceHeader.Font = CType(resources.GetObject("BGColNCANNUM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColNCANNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColNCANNUM.AppearanceHeader.Options.UseFont = True
        Me.BGColNCANNUM.AppearanceHeader.Options.UseForeColor = True
        Me.BGColNCANNUM.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColNCANNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColNCANNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGColNCANNUM, "BGColNCANNUM")
        Me.BGColNCANNUM.FieldName = "NCANNUM"
        Me.BGColNCANNUM.Name = "BGColNCANNUM"
        Me.BGColNCANNUM.OptionsColumn.AllowEdit = False
        Me.BGColNCANNUM.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.BGColNCANNUM.OptionsColumn.AllowMove = False
        Me.BGColNCANNUM.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.BGColNCANNUM.OptionsColumn.ReadOnly = True
        '
        'GBandIndemnites
        '
        Me.GBandIndemnites.AppearanceHeader.Font = CType(resources.GetObject("GBandIndemnites.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBandIndemnites.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GBandIndemnites.AppearanceHeader.Options.UseFont = True
        Me.GBandIndemnites.AppearanceHeader.Options.UseForeColor = True
        Me.GBandIndemnites.AppearanceHeader.Options.UseTextOptions = True
        Me.GBandIndemnites.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBandIndemnites.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GBandIndemnites, "GBandIndemnites")
        Me.GBandIndemnites.Columns.Add(Me.BGColVTYPEREPASDETAIL)
        Me.GBandIndemnites.Columns.Add(Me.BGColNMONTANTGD)
        Me.GBandIndemnites.VisibleIndex = 3
        '
        'BGColNMONTANTGD
        '
        Me.BGColNMONTANTGD.AppearanceCell.Options.UseTextOptions = True
        Me.BGColNMONTANTGD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColNMONTANTGD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColNMONTANTGD.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BGColNMONTANTGD.AppearanceHeader.Font = CType(resources.GetObject("BGColNMONTANTGD.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColNMONTANTGD.AppearanceHeader.Options.UseFont = True
        Me.BGColNMONTANTGD.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColNMONTANTGD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColNMONTANTGD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGColNMONTANTGD, "BGColNMONTANTGD")
        Me.BGColNMONTANTGD.FieldName = "NMONTANTGD"
        Me.BGColNMONTANTGD.Name = "BGColNMONTANTGD"
        '
        'GBandTransfert
        '
        Me.GBandTransfert.AppearanceHeader.Font = CType(resources.GetObject("GBandTransfert.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBandTransfert.AppearanceHeader.Options.UseFont = True
        Me.GBandTransfert.AppearanceHeader.Options.UseTextOptions = True
        Me.GBandTransfert.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBandTransfert.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GBandTransfert.Columns.Add(Me.BGColDFRAISJOURTRANS)
        Me.GBandTransfert.Columns.Add(Me.BGColVISAFRAIS)
        Me.GBandTransfert.Columns.Add(Me.BGColDVISAFRAIS)
        resources.ApplyResources(Me.GBandTransfert, "GBandTransfert")
        Me.GBandTransfert.VisibleIndex = 4
        '
        'BGColDFRAISJOURTRANS
        '
        resources.ApplyResources(Me.BGColDFRAISJOURTRANS, "BGColDFRAISJOURTRANS")
        Me.BGColDFRAISJOURTRANS.FieldName = "DFRAISJOURTRANS"
        Me.BGColDFRAISJOURTRANS.Name = "BGColDFRAISJOURTRANS"
        '
        'BGColDVISAFRAIS
        '
        resources.ApplyResources(Me.BGColDVISAFRAIS, "BGColDVISAFRAIS")
        Me.BGColDVISAFRAIS.FieldName = "DVISAFRAIS"
        Me.BGColDVISAFRAIS.Name = "BGColDVISAFRAIS"
        '
        'BGColBKMSTECHASTREINTE
        '
        resources.ApplyResources(Me.BGColBKMSTECHASTREINTE, "BGColBKMSTECHASTREINTE")
        Me.BGColBKMSTECHASTREINTE.Name = "BGColBKMSTECHASTREINTE"
        '
        'BGColBFRAISJOURTRANSVALID
        '
        resources.ApplyResources(Me.BGColBFRAISJOURTRANSVALID, "BGColBFRAISJOURTRANSVALID")
        Me.BGColBFRAISJOURTRANSVALID.FieldName = "BFRAISJOURTRANSVALID"
        Me.BGColBFRAISJOURTRANSVALID.Name = "BGColBFRAISJOURTRANSVALID"
        '
        'BGColNVEHNUM
        '
        resources.ApplyResources(Me.BGColNVEHNUM, "BGColNVEHNUM")
        Me.BGColNVEHNUM.FieldName = "NVEHNUM"
        Me.BGColNVEHNUM.Name = "BGColNVEHNUM"
        '
        'BGColNPERNUM
        '
        resources.ApplyResources(Me.BGColNPERNUM, "BGColNPERNUM")
        Me.BGColNPERNUM.FieldName = "NPERNUM"
        Me.BGColNPERNUM.Name = "BGColNPERNUM"
        '
        'BGColVTYPEREPAS
        '
        resources.ApplyResources(Me.BGColVTYPEREPAS, "BGColVTYPEREPAS")
        Me.BGColVTYPEREPAS.FieldName = "VTYPEREPAS"
        Me.BGColVTYPEREPAS.Name = "BGColVTYPEREPAS"
        '
        'BGColBKMSTECHVEHLOC
        '
        resources.ApplyResources(Me.BGColBKMSTECHVEHLOC, "BGColBKMSTECHVEHLOC")
        Me.BGColBKMSTECHVEHLOC.FieldName = "BKMSTECHVEHLOC"
        Me.BGColBKMSTECHVEHLOC.Name = "BGColBKMSTECHVEHLOC"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'GrpSelectPeriode
        '
        Me.GrpSelectPeriode.Controls.Add(Me.GLookUpTech)
        Me.GrpSelectPeriode.Controls.Add(Me.lblTech)
        Me.GrpSelectPeriode.Controls.Add(Me.lblsem)
        Me.GrpSelectPeriode.Controls.Add(Me.DateEditChoixSem)
        resources.ApplyResources(Me.GrpSelectPeriode, "GrpSelectPeriode")
        Me.GrpSelectPeriode.Name = "GrpSelectPeriode"
        Me.GrpSelectPeriode.TabStop = False
        '
        'GLookUpTech
        '
        resources.ApplyResources(Me.GLookUpTech, "GLookUpTech")
        Me.GLookUpTech.Name = "GLookUpTech"
        Me.GLookUpTech.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GLookUpTech.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.GLookUpTech.Properties.DisplayMember = "VPERNOM"
        Me.GLookUpTech.Properties.NullText = resources.GetString("GLookUpTech.Properties.NullText")
        Me.GLookUpTech.Properties.PopupView = Me.GridLookUpEditListeTech
        Me.GLookUpTech.Properties.ShowNullValuePrompt = CType((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused Or DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly), DevExpress.XtraEditors.ShowNullValuePromptOptions)
        Me.GLookUpTech.Properties.ValueMember = "NPERNUM"
        '
        'GridLookUpEditListeTech
        '
        Me.GridLookUpEditListeTech.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GVListeTechNPERNUM, Me.GVListeTechVPERNOM})
        Me.GridLookUpEditListeTech.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEditListeTech.Name = "GridLookUpEditListeTech"
        Me.GridLookUpEditListeTech.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEditListeTech.OptionsView.ShowGroupPanel = False
        '
        'GVListeTechNPERNUM
        '
        resources.ApplyResources(Me.GVListeTechNPERNUM, "GVListeTechNPERNUM")
        Me.GVListeTechNPERNUM.FieldName = "NPERNUM"
        Me.GVListeTechNPERNUM.Name = "GVListeTechNPERNUM"
        '
        'GVListeTechVPERNOM
        '
        Me.GVListeTechVPERNOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GVListeTechVPERNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeTechVPERNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GVListeTechVPERNOM, "GVListeTechVPERNOM")
        Me.GVListeTechVPERNOM.FieldName = "VPERNOM"
        Me.GVListeTechVPERNOM.Name = "GVListeTechVPERNOM"
        '
        'lblTech
        '
        resources.ApplyResources(Me.lblTech, "lblTech")
        Me.lblTech.Name = "lblTech"
        '
        'lblsem
        '
        resources.ApplyResources(Me.lblsem, "lblsem")
        Me.lblsem.Name = "lblsem"
        '
        'DateEditChoixSem
        '
        resources.ApplyResources(Me.DateEditChoixSem, "DateEditChoixSem")
        Me.DateEditChoixSem.Name = "DateEditChoixSem"
        Me.DateEditChoixSem.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEditChoixSem.Properties.Appearance.Font = CType(resources.GetObject("DateEditChoixSem.Properties.Appearance.Font"), System.Drawing.Font)
        Me.DateEditChoixSem.Properties.Appearance.Options.UseFont = True
        Me.DateEditChoixSem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateEditChoixSem.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.DateEditChoixSem.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEditChoixSem.Properties.CalendarTimeProperties.ShowNullValuePrompt = CType((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused Or DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly), DevExpress.XtraEditors.ShowNullValuePromptOptions)
        Me.DateEditChoixSem.Properties.ShowNullValuePrompt = CType((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused Or DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly), DevExpress.XtraEditors.ShowNullValuePromptOptions)
        Me.DateEditChoixSem.Properties.ShowWeekNumbers = True
        Me.DateEditChoixSem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'frmValidationFraisKMSReceive
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpSelectPeriode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmValidationFraisKMSReceive"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GCFraisJourSyntheseSem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BGFraisJourSyntheseSem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSelectPeriode.ResumeLayout(False)
        CType(Me.GLookUpTech.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEditListeTech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditChoixSem.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditChoixSem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
	Friend WithEvents BtnImp As System.Windows.Forms.Button
	Friend WithEvents BtnFermer As System.Windows.Forms.Button
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpSelectPeriode As System.Windows.Forms.GroupBox
    Friend WithEvents lblsem As System.Windows.Forms.Label
    Friend WithEvents BtnArchives As System.Windows.Forms.Button
    Friend WithEvents lblTech As System.Windows.Forms.Label
    Private WithEvents GCFraisJourSyntheseSem As DevExpress.XtraGrid.GridControl
    Private WithEvents BGFraisJourSyntheseSem As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Private WithEvents BGColNIDFRAISJOUR As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNIDKMSTECH As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNIDREPASTECHUNIQUE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColDFRAISJOUR As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColVCLINOM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColVSITNOM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNKMSDEPART As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNKMSARRIVEE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNKMSPARCOURS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNCANNUM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColVTYPEREPASDETAIL As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColDFRAISJOURTRANS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColBFRAISJOURTRANSVALID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColVPERNOMTECH As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColVISAFRAIS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColDVISAFRAIS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNVEHNUM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColVVEHTECH As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNPERNUM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNMONTANTGD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColVTYPEREPAS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents DateEditChoixSem As DevExpress.XtraEditors.DateEdit
    Private WithEvents GLookUpTech As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridLookUpEditListeTech As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GVListeTechNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVListeTechVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents BGColBKMSTECHASTREINTE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColBKMSTECHVEHLOC As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents GBandDate As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBandDestination As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBandKms As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBandIndemnites As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBandTransfert As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
