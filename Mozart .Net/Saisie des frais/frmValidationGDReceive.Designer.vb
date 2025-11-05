<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValidationGDReceive
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmValidationGDReceive))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition6 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.BGColVISAFRAISGD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColVSITNOM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColVSITCP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColVSITVIL = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColNREGCOD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColVSITPAYS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColVTYPEREPASDETAIL = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.lblTech = New System.Windows.Forms.Label()
        Me.lblSem = New System.Windows.Forms.Label()
        Me.DateEditChoixSem = New DevExpress.XtraEditors.DateEdit()
        Me.GrpSelectPeriode = New System.Windows.Forms.GroupBox()
        Me.GLookUpTech = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEditListeTech = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GVListeTechNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVListeTechVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnArchives = New System.Windows.Forms.Button()
        Me.BtnImp = New System.Windows.Forms.Button()
        Me.BGFraisJourSyntheseGD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GBandDate = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGColNIDFRAISJOUR = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColNIDKMSTECH = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColNIDREPASTECHUNIQUE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColVPERNOMTECH = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColDFRAISJOUR = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBandDestination = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGColVCLINOM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBandKms = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GBandIndemnites = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGColNMONTANTGD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBandTransfert = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGColDFRAISJOURTRANS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColVCOMMREPAS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColDVISAGD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColNIDKMSTECHUNIQUE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColBFRAISJOURTRANSVALID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColNPERNUM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColVTYPEREPAS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColBKMSTECHASTREINTE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GCFraisJourSyntheseGD = New DevExpress.XtraGrid.GridControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        CType(Me.DateEditChoixSem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditChoixSem.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSelectPeriode.SuspendLayout()
        CType(Me.GLookUpTech.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEditListeTech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BGFraisJourSyntheseGD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCFraisJourSyntheseGD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'BGColVISAFRAISGD
        '
        Me.BGColVISAFRAISGD.AppearanceCell.Font = CType(resources.GetObject("BGColVISAFRAISGD.AppearanceCell.Font"), System.Drawing.Font)
        Me.BGColVISAFRAISGD.AppearanceCell.ForeColor = System.Drawing.Color.Blue
        Me.BGColVISAFRAISGD.AppearanceCell.Options.UseFont = True
        Me.BGColVISAFRAISGD.AppearanceCell.Options.UseForeColor = True
        Me.BGColVISAFRAISGD.AppearanceCell.Options.UseTextOptions = True
        Me.BGColVISAFRAISGD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVISAFRAISGD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColVISAFRAISGD.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BGColVISAFRAISGD.AppearanceHeader.Font = CType(resources.GetObject("BGColVISAFRAISGD.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColVISAFRAISGD.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColVISAFRAISGD.AppearanceHeader.Options.UseFont = True
        Me.BGColVISAFRAISGD.AppearanceHeader.Options.UseForeColor = True
        Me.BGColVISAFRAISGD.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColVISAFRAISGD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVISAFRAISGD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColVISAFRAISGD.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        resources.ApplyResources(Me.BGColVISAFRAISGD, "BGColVISAFRAISGD")
        Me.BGColVISAFRAISGD.FieldName = "VISAFRAISGD"
        Me.BGColVISAFRAISGD.Name = "BGColVISAFRAISGD"
        Me.BGColVISAFRAISGD.OptionsColumn.AllowEdit = False
        Me.BGColVISAFRAISGD.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.BGColVISAFRAISGD.OptionsColumn.AllowMove = False
        Me.BGColVISAFRAISGD.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.BGColVISAFRAISGD.OptionsColumn.ReadOnly = True
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
        'BGColVSITCP
        '
        Me.BGColVSITCP.AppearanceCell.Options.UseTextOptions = True
        Me.BGColVSITCP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVSITCP.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColVSITCP.AppearanceHeader.Font = CType(resources.GetObject("BGColVSITCP.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColVSITCP.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColVSITCP.AppearanceHeader.Options.UseFont = True
        Me.BGColVSITCP.AppearanceHeader.Options.UseForeColor = True
        Me.BGColVSITCP.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColVSITCP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVSITCP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGColVSITCP, "BGColVSITCP")
        Me.BGColVSITCP.FieldName = "VSITCP"
        Me.BGColVSITCP.Name = "BGColVSITCP"
        Me.BGColVSITCP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        '
        'BGColVSITVIL
        '
        Me.BGColVSITVIL.AppearanceCell.Options.UseTextOptions = True
        Me.BGColVSITVIL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVSITVIL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColVSITVIL.AppearanceHeader.Font = CType(resources.GetObject("BGColVSITVIL.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColVSITVIL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColVSITVIL.AppearanceHeader.Options.UseFont = True
        Me.BGColVSITVIL.AppearanceHeader.Options.UseForeColor = True
        Me.BGColVSITVIL.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColVSITVIL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVSITVIL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGColVSITVIL, "BGColVSITVIL")
        Me.BGColVSITVIL.FieldName = "VSITVIL"
        Me.BGColVSITVIL.Name = "BGColVSITVIL"
        Me.BGColVSITVIL.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        '
        'BGColNREGCOD
        '
        Me.BGColNREGCOD.AppearanceCell.Options.UseTextOptions = True
        Me.BGColNREGCOD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColNREGCOD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColNREGCOD.AppearanceHeader.Font = CType(resources.GetObject("BGColNREGCOD.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColNREGCOD.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColNREGCOD.AppearanceHeader.Options.UseFont = True
        Me.BGColNREGCOD.AppearanceHeader.Options.UseForeColor = True
        Me.BGColNREGCOD.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColNREGCOD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColNREGCOD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGColNREGCOD, "BGColNREGCOD")
        Me.BGColNREGCOD.FieldName = "NREGCOD"
        Me.BGColNREGCOD.Name = "BGColNREGCOD"
        Me.BGColNREGCOD.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        '
        'BGColVSITPAYS
        '
        Me.BGColVSITPAYS.AppearanceCell.Options.UseTextOptions = True
        Me.BGColVSITPAYS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVSITPAYS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColVSITPAYS.AppearanceHeader.Font = CType(resources.GetObject("BGColVSITPAYS.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColVSITPAYS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColVSITPAYS.AppearanceHeader.Options.UseFont = True
        Me.BGColVSITPAYS.AppearanceHeader.Options.UseForeColor = True
        Me.BGColVSITPAYS.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColVSITPAYS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVSITPAYS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGColVSITPAYS, "BGColVSITPAYS")
        Me.BGColVSITPAYS.FieldName = "VSITPAYS"
        Me.BGColVSITPAYS.Name = "BGColVSITPAYS"
        Me.BGColVSITPAYS.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
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
        'lblTech
        '
        resources.ApplyResources(Me.lblTech, "lblTech")
        Me.lblTech.Name = "lblTech"
        '
        'lblSem
        '
        resources.ApplyResources(Me.lblSem, "lblSem")
        Me.lblSem.Name = "lblSem"
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
        Me.DateEditChoixSem.Properties.ShowWeekNumbers = True
        Me.DateEditChoixSem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GrpSelectPeriode
        '
        Me.GrpSelectPeriode.Controls.Add(Me.GLookUpTech)
        Me.GrpSelectPeriode.Controls.Add(Me.lblTech)
        Me.GrpSelectPeriode.Controls.Add(Me.lblSem)
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
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
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
        'BGFraisJourSyntheseGD
        '
        Me.BGFraisJourSyntheseGD.BandPanelRowHeight = 40
        Me.BGFraisJourSyntheseGD.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GBandDate, Me.GBandDestination, Me.GBandKms, Me.GBandIndemnites, Me.GBandTransfert})
        Me.BGFraisJourSyntheseGD.ColumnPanelRowHeight = 40
        Me.BGFraisJourSyntheseGD.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BGColNIDFRAISJOUR, Me.BGColNIDKMSTECH, Me.BGColVPERNOMTECH, Me.BGColNIDKMSTECHUNIQUE, Me.BGColNIDREPASTECHUNIQUE, Me.BGColDFRAISJOUR, Me.BGColDFRAISJOURTRANS, Me.BGColVCLINOM, Me.BGColVSITNOM, Me.BGColVTYPEREPASDETAIL, Me.BGColVISAFRAISGD, Me.BGColBFRAISJOURTRANSVALID, Me.BGColDVISAGD, Me.BGColNPERNUM, Me.BGColNMONTANTGD, Me.BGColVTYPEREPAS, Me.BGColVSITCP, Me.BGColVSITVIL, Me.BGColNREGCOD, Me.BGColVCOMMREPAS, Me.BGColVSITPAYS, Me.BGColBKMSTECHASTREINTE})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Yellow
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Column = Me.BGColVISAFRAISGD
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "ISNULL([DVISAGD]) == TRUE"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Column = Me.BGColVSITNOM
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "[BKMSTECHASTREINTE] == True"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Column = Me.BGColVSITCP
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition3.Expression = "[BKMSTECHASTREINTE] == True"
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.Column = Me.BGColVSITVIL
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition4.Expression = "[BKMSTECHASTREINTE] == True"
        StyleFormatCondition5.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition5.Appearance.Options.UseBackColor = True
        StyleFormatCondition5.Column = Me.BGColNREGCOD
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition5.Expression = "[BKMSTECHASTREINTE] == True"
        StyleFormatCondition6.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition6.Appearance.Options.UseBackColor = True
        StyleFormatCondition6.Column = Me.BGColVSITPAYS
        StyleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition6.Expression = "[BKMSTECHASTREINTE] == True"
        Me.BGFraisJourSyntheseGD.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4, StyleFormatCondition5, StyleFormatCondition6})
        Me.BGFraisJourSyntheseGD.GridControl = Me.GCFraisJourSyntheseGD
        Me.BGFraisJourSyntheseGD.Name = "BGFraisJourSyntheseGD"
        Me.BGFraisJourSyntheseGD.OptionsBehavior.Editable = False
        Me.BGFraisJourSyntheseGD.OptionsBehavior.ReadOnly = True
        Me.BGFraisJourSyntheseGD.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.BGFraisJourSyntheseGD.OptionsView.AllowCellMerge = True
        Me.BGFraisJourSyntheseGD.OptionsView.ShowFooter = True
        Me.BGFraisJourSyntheseGD.OptionsView.ShowGroupPanel = False
        Me.BGFraisJourSyntheseGD.RowHeight = 40
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
        Me.GBandDestination.Columns.Add(Me.BGColVSITCP)
        Me.GBandDestination.Columns.Add(Me.BGColVSITVIL)
        Me.GBandDestination.Columns.Add(Me.BGColNREGCOD)
        Me.GBandDestination.Columns.Add(Me.BGColVSITPAYS)
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
        'GBandKms
        '
        Me.GBandKms.AppearanceHeader.Font = CType(resources.GetObject("GBandKms.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBandKms.AppearanceHeader.Options.UseFont = True
        Me.GBandKms.AppearanceHeader.Options.UseTextOptions = True
        Me.GBandKms.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBandKms.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GBandKms, "GBandKms")
        Me.GBandKms.VisibleIndex = -1
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
        Me.GBandIndemnites.VisibleIndex = 2
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
        Me.GBandTransfert.Columns.Add(Me.BGColVCOMMREPAS)
        Me.GBandTransfert.Columns.Add(Me.BGColVISAFRAISGD)
        Me.GBandTransfert.Columns.Add(Me.BGColDVISAGD)
        resources.ApplyResources(Me.GBandTransfert, "GBandTransfert")
        Me.GBandTransfert.VisibleIndex = 3
        '
        'BGColDFRAISJOURTRANS
        '
        resources.ApplyResources(Me.BGColDFRAISJOURTRANS, "BGColDFRAISJOURTRANS")
        Me.BGColDFRAISJOURTRANS.FieldName = "DFRAISJOURTRANS"
        Me.BGColDFRAISJOURTRANS.Name = "BGColDFRAISJOURTRANS"
        '
        'BGColVCOMMREPAS
        '
        Me.BGColVCOMMREPAS.AppearanceCell.Options.UseTextOptions = True
        Me.BGColVCOMMREPAS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVCOMMREPAS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColVCOMMREPAS.AppearanceHeader.Font = CType(resources.GetObject("BGColVCOMMREPAS.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColVCOMMREPAS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColVCOMMREPAS.AppearanceHeader.Options.UseFont = True
        Me.BGColVCOMMREPAS.AppearanceHeader.Options.UseForeColor = True
        Me.BGColVCOMMREPAS.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColVCOMMREPAS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVCOMMREPAS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColVCOMMREPAS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGColVCOMMREPAS, "BGColVCOMMREPAS")
        Me.BGColVCOMMREPAS.FieldName = "VCOMMREPAS"
        Me.BGColVCOMMREPAS.Name = "BGColVCOMMREPAS"
        Me.BGColVCOMMREPAS.OptionsColumn.AllowEdit = False
        Me.BGColVCOMMREPAS.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        '
        'BGColDVISAGD
        '
        resources.ApplyResources(Me.BGColDVISAGD, "BGColDVISAGD")
        Me.BGColDVISAGD.FieldName = "DVISAGD"
        Me.BGColDVISAGD.Name = "BGColDVISAGD"
        '
        'BGColNIDKMSTECHUNIQUE
        '
        resources.ApplyResources(Me.BGColNIDKMSTECHUNIQUE, "BGColNIDKMSTECHUNIQUE")
        Me.BGColNIDKMSTECHUNIQUE.Name = "BGColNIDKMSTECHUNIQUE"
        '
        'BGColBFRAISJOURTRANSVALID
        '
        resources.ApplyResources(Me.BGColBFRAISJOURTRANSVALID, "BGColBFRAISJOURTRANSVALID")
        Me.BGColBFRAISJOURTRANSVALID.FieldName = "BFRAISJOURTRANSVALID"
        Me.BGColBFRAISJOURTRANSVALID.Name = "BGColBFRAISJOURTRANSVALID"
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
        'BGColBKMSTECHASTREINTE
        '
        resources.ApplyResources(Me.BGColBKMSTECHASTREINTE, "BGColBKMSTECHASTREINTE")
        Me.BGColBKMSTECHASTREINTE.FieldName = "BKMSTECHASTREINTE"
        Me.BGColBKMSTECHASTREINTE.Name = "BGColBKMSTECHASTREINTE"
        '
        'GCFraisJourSyntheseGD
        '
        resources.ApplyResources(Me.GCFraisJourSyntheseGD, "GCFraisJourSyntheseGD")
        Me.GCFraisJourSyntheseGD.MainView = Me.BGFraisJourSyntheseGD
        Me.GCFraisJourSyntheseGD.Name = "GCFraisJourSyntheseGD"
        Me.GCFraisJourSyntheseGD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BGFraisJourSyntheseGD})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GCFraisJourSyntheseGD)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
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
        'frmValidationGDReceive
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpSelectPeriode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmValidationGDReceive"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DateEditChoixSem.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditChoixSem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSelectPeriode.ResumeLayout(False)
        CType(Me.GLookUpTech.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEditListeTech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BGFraisJourSyntheseGD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCFraisJourSyntheseGD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTech As System.Windows.Forms.Label
    Friend WithEvents lblSem As System.Windows.Forms.Label
    Friend WithEvents GrpSelectPeriode As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnArchives As System.Windows.Forms.Button
    Friend WithEvents BtnImp As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Private WithEvents BGColVISAFRAISGD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColBFRAISJOURTRANSVALID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColDVISAGD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColDFRAISJOURTRANS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColVTYPEREPASDETAIL As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNMONTANTGD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNPERNUM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColVTYPEREPAS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents GVListeTechVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DateEditChoixSem As DevExpress.XtraEditors.DateEdit
    Private WithEvents GVListeTechNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GLookUpTech As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridLookUpEditListeTech As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents BGFraisJourSyntheseGD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Private WithEvents BGColNIDFRAISJOUR As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNIDKMSTECH As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNIDREPASTECHUNIQUE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColVPERNOMTECH As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColDFRAISJOUR As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColVCLINOM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColVSITNOM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents GCFraisJourSyntheseGD As DevExpress.XtraGrid.GridControl
    Private WithEvents BGColVSITCP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColVSITVIL As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNREGCOD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColVSITPAYS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents GBandDate As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBandDestination As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBandKms As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBandIndemnites As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBandTransfert As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents BGColVCOMMREPAS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColBKMSTECHASTREINTE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNIDKMSTECHUNIQUE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
