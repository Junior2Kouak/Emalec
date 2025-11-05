<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStatRHTempsTravail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatRHTempsTravail))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition6 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.GColDetailTPSTRAV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColMasterDUREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GrpDetail = New System.Windows.Forms.GroupBox()
        Me.LblTech = New System.Windows.Forms.Label()
        Me.LblDureeTotal = New System.Windows.Forms.Label()
        Me.LblTitreTech = New System.Windows.Forms.Label()
        Me.GCDETAIL = New DevExpress.XtraGrid.GridControl()
        Me.GVDETAIL = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColDetailNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailDATCLASS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailARRIVEE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailDEPART = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailDUREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailTPSPREVU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailCOMMENTAIRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailCOLOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailCIPLMULTI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpList = New System.Windows.Forms.GroupBox()
        Me.GCMASTER = New DevExpress.XtraGrid.GridControl()
        Me.GVMASTER = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColMasterNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColMasterTECH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColMasterVSERV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColMasterCOLOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpDate = New System.Windows.Forms.GroupBox()
        Me.BtnEdition = New System.Windows.Forms.Button()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.CboSem = New System.Windows.Forms.ComboBox()
        Me.CboAnnee = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpPave = New System.Windows.Forms.GroupBox()
        Me.GCPAVE = New DevExpress.XtraGrid.GridControl()
        Me.GVPAVE = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColPAVE_NCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPAVE_VCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPAVE_VSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPAVE_VSITVIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPAVE_NIPLNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPAVE_CODEPAVE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPAVE_DUREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPAVE_DIPLDATJ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPAVE_CIPLMULT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpACT = New System.Windows.Forms.GroupBox()
        Me.GCACT = New DevExpress.XtraGrid.GridControl()
        Me.GVACT = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColACT_NIPLNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColACT_NDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColACT_NACTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColACT_VACTDES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColACT_VISA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEditMOZART = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColACT_DACTARR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColACT_DACTDEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColACT_NACTDUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColACT_DVISAARR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColACT_DVISAEXEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColACT_NACTNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColACT_BTNIPLMULT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEditMulti = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColAct_CIPLMULT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAct_NCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpGeoloc = New System.Windows.Forms.GroupBox()
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions.SuspendLayout()
        Me.GrpDetail.SuspendLayout()
        CType(Me.GCDETAIL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDETAIL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpList.SuspendLayout()
        CType(Me.GCMASTER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVMASTER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpDate.SuspendLayout()
        Me.GrpPave.SuspendLayout()
        CType(Me.GCPAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpACT.SuspendLayout()
        CType(Me.GCACT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVACT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEditMOZART, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEditMulti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpGeoloc.SuspendLayout()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GColDetailTPSTRAV
        '
        Me.GColDetailTPSTRAV.AppearanceCell.Font = CType(resources.GetObject("GColDetailTPSTRAV.AppearanceCell.Font"), System.Drawing.Font)
        Me.GColDetailTPSTRAV.AppearanceCell.Options.UseFont = True
        Me.GColDetailTPSTRAV.AppearanceCell.Options.UseTextOptions = True
        Me.GColDetailTPSTRAV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailTPSTRAV.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDetailTPSTRAV.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDetailTPSTRAV.AppearanceHeader.Options.UseForeColor = True
        Me.GColDetailTPSTRAV.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetailTPSTRAV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailTPSTRAV.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDetailTPSTRAV.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColDetailTPSTRAV, "GColDetailTPSTRAV")
        Me.GColDetailTPSTRAV.FieldName = "TPSTRAV"
        Me.GColDetailTPSTRAV.Name = "GColDetailTPSTRAV"
        '
        'GColMasterDUREE
        '
        Me.GColMasterDUREE.AppearanceCell.Font = CType(resources.GetObject("GColMasterDUREE.AppearanceCell.Font"), System.Drawing.Font)
        Me.GColMasterDUREE.AppearanceCell.Options.UseFont = True
        Me.GColMasterDUREE.AppearanceCell.Options.UseTextOptions = True
        Me.GColMasterDUREE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColMasterDUREE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColMasterDUREE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColMasterDUREE.AppearanceHeader.Options.UseForeColor = True
        Me.GColMasterDUREE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColMasterDUREE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColMasterDUREE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColMasterDUREE, "GColMasterDUREE")
        Me.GColMasterDUREE.DisplayFormat.FormatString = "{0)"
        Me.GColMasterDUREE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GColMasterDUREE.FieldName = "DUREE"
        Me.GColMasterDUREE.Name = "GColMasterDUREE"
        Me.GColMasterDUREE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GrpDetail
        '
        Me.GrpDetail.Controls.Add(Me.LblTech)
        Me.GrpDetail.Controls.Add(Me.LblDureeTotal)
        Me.GrpDetail.Controls.Add(Me.LblTitreTech)
        Me.GrpDetail.Controls.Add(Me.GCDETAIL)
        resources.ApplyResources(Me.GrpDetail, "GrpDetail")
        Me.GrpDetail.Name = "GrpDetail"
        Me.GrpDetail.TabStop = False
        '
        'LblTech
        '
        resources.ApplyResources(Me.LblTech, "LblTech")
        Me.LblTech.Name = "LblTech"
        '
        'LblDureeTotal
        '
        resources.ApplyResources(Me.LblDureeTotal, "LblDureeTotal")
        Me.LblDureeTotal.Name = "LblDureeTotal"
        '
        'LblTitreTech
        '
        resources.ApplyResources(Me.LblTitreTech, "LblTitreTech")
        Me.LblTitreTech.Name = "LblTitreTech"
        '
        'GCDETAIL
        '
        resources.ApplyResources(Me.GCDETAIL, "GCDETAIL")
        Me.GCDETAIL.MainView = Me.GVDETAIL
        Me.GCDETAIL.Name = "GCDETAIL"
        Me.GCDETAIL.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDETAIL})
        '
        'GVDETAIL
        '
        Me.GVDETAIL.ColumnPanelRowHeight = 50
        Me.GVDETAIL.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColDetailNPERNUM, Me.GColDetailDATCLASS, Me.GColDetailARRIVEE, Me.GColDetailDEPART, Me.GColDetailDUREE, Me.GColDetailTPSTRAV, Me.GColDetailTPSPREVU, Me.GColDetailCOMMENTAIRE, Me.GColDetailCOLOR, Me.GColDetailCIPLMULTI})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Salmon
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Column = Me.GColDetailTPSTRAV
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[COLOR] == 'R'"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.LightGreen
        StyleFormatCondition2.Appearance.Font = CType(resources.GetObject("resource.Font"), System.Drawing.Font)
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Column = Me.GColDetailTPSTRAV
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "[COLOR] == 'V'"
        Me.GVDETAIL.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GVDETAIL.GridControl = Me.GCDETAIL
        Me.GVDETAIL.Name = "GVDETAIL"
        Me.GVDETAIL.OptionsBehavior.Editable = False
        Me.GVDETAIL.OptionsBehavior.ReadOnly = True
        Me.GVDETAIL.OptionsNavigation.AutoMoveRowFocus = False
        Me.GVDETAIL.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVDETAIL.OptionsSelection.EnableAppearanceHideSelection = False
        Me.GVDETAIL.OptionsView.ShowGroupPanel = False
        '
        'GColDetailNPERNUM
        '
        resources.ApplyResources(Me.GColDetailNPERNUM, "GColDetailNPERNUM")
        Me.GColDetailNPERNUM.FieldName = "NPERNUM"
        Me.GColDetailNPERNUM.Name = "GColDetailNPERNUM"
        '
        'GColDetailDATCLASS
        '
        Me.GColDetailDATCLASS.AppearanceCell.Options.UseTextOptions = True
        Me.GColDetailDATCLASS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailDATCLASS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDetailDATCLASS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDetailDATCLASS.AppearanceHeader.Options.UseForeColor = True
        Me.GColDetailDATCLASS.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetailDATCLASS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailDATCLASS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetailDATCLASS, "GColDetailDATCLASS")
        Me.GColDetailDATCLASS.FieldName = "DATCLASS"
        Me.GColDetailDATCLASS.Name = "GColDetailDATCLASS"
        '
        'GColDetailARRIVEE
        '
        Me.GColDetailARRIVEE.AppearanceCell.Options.UseTextOptions = True
        Me.GColDetailARRIVEE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailARRIVEE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDetailARRIVEE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDetailARRIVEE.AppearanceHeader.Options.UseForeColor = True
        Me.GColDetailARRIVEE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetailARRIVEE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailARRIVEE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetailARRIVEE, "GColDetailARRIVEE")
        Me.GColDetailARRIVEE.FieldName = "ARRIVEE"
        Me.GColDetailARRIVEE.Name = "GColDetailARRIVEE"
        '
        'GColDetailDEPART
        '
        Me.GColDetailDEPART.AppearanceCell.Options.UseTextOptions = True
        Me.GColDetailDEPART.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailDEPART.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDetailDEPART.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDetailDEPART.AppearanceHeader.Options.UseForeColor = True
        Me.GColDetailDEPART.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetailDEPART.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailDEPART.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetailDEPART, "GColDetailDEPART")
        Me.GColDetailDEPART.FieldName = "DEPART"
        Me.GColDetailDEPART.Name = "GColDetailDEPART"
        '
        'GColDetailDUREE
        '
        Me.GColDetailDUREE.AppearanceCell.Options.UseTextOptions = True
        Me.GColDetailDUREE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailDUREE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDetailDUREE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDetailDUREE.AppearanceHeader.Options.UseForeColor = True
        Me.GColDetailDUREE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetailDUREE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailDUREE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetailDUREE, "GColDetailDUREE")
        Me.GColDetailDUREE.FieldName = "DUREE"
        Me.GColDetailDUREE.Name = "GColDetailDUREE"
        '
        'GColDetailTPSPREVU
        '
        Me.GColDetailTPSPREVU.AppearanceCell.Options.UseTextOptions = True
        Me.GColDetailTPSPREVU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailTPSPREVU.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDetailTPSPREVU.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDetailTPSPREVU.AppearanceHeader.Options.UseForeColor = True
        Me.GColDetailTPSPREVU.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetailTPSPREVU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailTPSPREVU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetailTPSPREVU, "GColDetailTPSPREVU")
        Me.GColDetailTPSPREVU.FieldName = "TPSPREVU"
        Me.GColDetailTPSPREVU.Name = "GColDetailTPSPREVU"
        '
        'GColDetailCOMMENTAIRE
        '
        Me.GColDetailCOMMENTAIRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDetailCOMMENTAIRE.AppearanceHeader.Options.UseForeColor = True
        Me.GColDetailCOMMENTAIRE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetailCOMMENTAIRE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailCOMMENTAIRE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetailCOMMENTAIRE, "GColDetailCOMMENTAIRE")
        Me.GColDetailCOMMENTAIRE.FieldName = "COMMENTAIRE"
        Me.GColDetailCOMMENTAIRE.Name = "GColDetailCOMMENTAIRE"
        '
        'GColDetailCOLOR
        '
        resources.ApplyResources(Me.GColDetailCOLOR, "GColDetailCOLOR")
        Me.GColDetailCOLOR.FieldName = "COLOR"
        Me.GColDetailCOLOR.Name = "GColDetailCOLOR"
        '
        'GColDetailCIPLMULTI
        '
        resources.ApplyResources(Me.GColDetailCIPLMULTI, "GColDetailCIPLMULTI")
        Me.GColDetailCIPLMULTI.FieldName = "CIPLMULT"
        Me.GColDetailCIPLMULTI.Name = "GColDetailCIPLMULTI"
        '
        'GrpList
        '
        Me.GrpList.Controls.Add(Me.GCMASTER)
        resources.ApplyResources(Me.GrpList, "GrpList")
        Me.GrpList.Name = "GrpList"
        Me.GrpList.TabStop = False
        '
        'GCMASTER
        '
        resources.ApplyResources(Me.GCMASTER, "GCMASTER")
        Me.GCMASTER.MainView = Me.GVMASTER
        Me.GCMASTER.Name = "GCMASTER"
        Me.GCMASTER.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVMASTER})
        '
        'GVMASTER
        '
        Me.GVMASTER.Appearance.FocusedRow.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GVMASTER.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVMASTER.Appearance.SelectedRow.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GVMASTER.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVMASTER.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColMasterNPERNUM, Me.GColMasterTECH, Me.GColMasterVSERV, Me.GColMasterDUREE, Me.GColMasterCOLOR})
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Salmon
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Column = Me.GColMasterDUREE
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition3.Expression = "[COLOR] == 'R'"
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.LightGreen
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.Column = Me.GColMasterDUREE
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition4.Expression = "[COLOR] == 'V'"
        Me.GVMASTER.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition3, StyleFormatCondition4})
        Me.GVMASTER.GridControl = Me.GCMASTER
        Me.GVMASTER.Name = "GVMASTER"
        Me.GVMASTER.OptionsBehavior.Editable = False
        Me.GVMASTER.OptionsBehavior.ReadOnly = True
        Me.GVMASTER.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVMASTER.OptionsView.ShowAutoFilterRow = True
        Me.GVMASTER.OptionsView.ShowGroupPanel = False
        '
        'GColMasterNPERNUM
        '
        resources.ApplyResources(Me.GColMasterNPERNUM, "GColMasterNPERNUM")
        Me.GColMasterNPERNUM.FieldName = "NPERNUM"
        Me.GColMasterNPERNUM.Name = "GColMasterNPERNUM"
        '
        'GColMasterTECH
        '
        Me.GColMasterTECH.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColMasterTECH.AppearanceHeader.Options.UseForeColor = True
        Me.GColMasterTECH.AppearanceHeader.Options.UseTextOptions = True
        Me.GColMasterTECH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColMasterTECH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColMasterTECH, "GColMasterTECH")
        Me.GColMasterTECH.FieldName = "TECH"
        Me.GColMasterTECH.Name = "GColMasterTECH"
        Me.GColMasterTECH.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColMasterVSERV
        '
        Me.GColMasterVSERV.AppearanceCell.Options.UseTextOptions = True
        Me.GColMasterVSERV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColMasterVSERV.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColMasterVSERV.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColMasterVSERV.AppearanceHeader.Options.UseForeColor = True
        Me.GColMasterVSERV.AppearanceHeader.Options.UseTextOptions = True
        Me.GColMasterVSERV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColMasterVSERV.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColMasterVSERV, "GColMasterVSERV")
        Me.GColMasterVSERV.FieldName = "VSERV"
        Me.GColMasterVSERV.Name = "GColMasterVSERV"
        Me.GColMasterVSERV.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColMasterCOLOR
        '
        Me.GColMasterCOLOR.AppearanceHeader.Options.UseTextOptions = True
        Me.GColMasterCOLOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColMasterCOLOR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColMasterCOLOR, "GColMasterCOLOR")
        Me.GColMasterCOLOR.FieldName = "COLOR"
        Me.GColMasterCOLOR.Name = "GColMasterCOLOR"
        '
        'GrpDate
        '
        Me.GrpDate.BackColor = System.Drawing.Color.Wheat
        Me.GrpDate.Controls.Add(Me.BtnEdition)
        Me.GrpDate.Controls.Add(Me.BtnValid)
        Me.GrpDate.Controls.Add(Me.CboSem)
        Me.GrpDate.Controls.Add(Me.CboAnnee)
        Me.GrpDate.Controls.Add(Me.Label2)
        Me.GrpDate.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GrpDate, "GrpDate")
        Me.GrpDate.Name = "GrpDate"
        Me.GrpDate.TabStop = False
        '
        'BtnEdition
        '
        resources.ApplyResources(Me.BtnEdition, "BtnEdition")
        Me.BtnEdition.Name = "BtnEdition"
        Me.BtnEdition.Tag = "419"
        Me.BtnEdition.UseVisualStyleBackColor = True
        '
        'BtnValid
        '
        resources.ApplyResources(Me.BtnValid, "BtnValid")
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'CboSem
        '
        Me.CboSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.CboSem, "CboSem")
        Me.CboSem.FormattingEnabled = True
        Me.CboSem.Name = "CboSem"
        '
        'CboAnnee
        '
        Me.CboAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.CboAnnee, "CboAnnee")
        Me.CboAnnee.FormattingEnabled = True
        Me.CboAnnee.Name = "CboAnnee"
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
        'GrpPave
        '
        Me.GrpPave.Controls.Add(Me.GCPAVE)
        resources.ApplyResources(Me.GrpPave, "GrpPave")
        Me.GrpPave.Name = "GrpPave"
        Me.GrpPave.TabStop = False
        '
        'GCPAVE
        '
        resources.ApplyResources(Me.GCPAVE, "GCPAVE")
        Me.GCPAVE.MainView = Me.GVPAVE
        Me.GCPAVE.Name = "GCPAVE"
        Me.GCPAVE.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPAVE})
        '
        'GVPAVE
        '
        Me.GVPAVE.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColPAVE_NCLINUM, Me.ColPAVE_VCLINOM, Me.ColPAVE_VSITNOM, Me.ColPAVE_VSITVIL, Me.ColPAVE_NIPLNUM, Me.ColPAVE_CODEPAVE, Me.ColPAVE_DUREE, Me.ColPAVE_DIPLDATJ, Me.ColPAVE_CIPLMULT})
        Me.GVPAVE.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition5, StyleFormatCondition6})
        Me.GVPAVE.GridControl = Me.GCPAVE
        Me.GVPAVE.Name = "GVPAVE"
        Me.GVPAVE.OptionsView.ShowGroupPanel = False
        '
        'ColPAVE_NCLINUM
        '
        resources.ApplyResources(Me.ColPAVE_NCLINUM, "ColPAVE_NCLINUM")
        Me.ColPAVE_NCLINUM.FieldName = "NCLINUM"
        Me.ColPAVE_NCLINUM.Name = "ColPAVE_NCLINUM"
        '
        'ColPAVE_VCLINOM
        '
        Me.ColPAVE_VCLINOM.AppearanceCell.Options.UseTextOptions = True
        Me.ColPAVE_VCLINOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPAVE_VCLINOM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColPAVE_VCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColPAVE_VCLINOM.AppearanceHeader.Options.UseForeColor = True
        Me.ColPAVE_VCLINOM.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPAVE_VCLINOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPAVE_VCLINOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColPAVE_VCLINOM, "ColPAVE_VCLINOM")
        Me.ColPAVE_VCLINOM.FieldName = "VCLINOM"
        Me.ColPAVE_VCLINOM.Name = "ColPAVE_VCLINOM"
        Me.ColPAVE_VCLINOM.OptionsColumn.AllowEdit = False
        Me.ColPAVE_VCLINOM.OptionsColumn.ReadOnly = True
        '
        'ColPAVE_VSITNOM
        '
        Me.ColPAVE_VSITNOM.AppearanceCell.Options.UseTextOptions = True
        Me.ColPAVE_VSITNOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPAVE_VSITNOM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColPAVE_VSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColPAVE_VSITNOM.AppearanceHeader.Options.UseForeColor = True
        Me.ColPAVE_VSITNOM.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPAVE_VSITNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPAVE_VSITNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColPAVE_VSITNOM, "ColPAVE_VSITNOM")
        Me.ColPAVE_VSITNOM.FieldName = "VSITNOM"
        Me.ColPAVE_VSITNOM.Name = "ColPAVE_VSITNOM"
        Me.ColPAVE_VSITNOM.OptionsColumn.AllowEdit = False
        Me.ColPAVE_VSITNOM.OptionsColumn.ReadOnly = True
        '
        'ColPAVE_VSITVIL
        '
        Me.ColPAVE_VSITVIL.AppearanceCell.Options.UseTextOptions = True
        Me.ColPAVE_VSITVIL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPAVE_VSITVIL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColPAVE_VSITVIL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColPAVE_VSITVIL.AppearanceHeader.Options.UseForeColor = True
        Me.ColPAVE_VSITVIL.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPAVE_VSITVIL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPAVE_VSITVIL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColPAVE_VSITVIL, "ColPAVE_VSITVIL")
        Me.ColPAVE_VSITVIL.FieldName = "VSITVIL"
        Me.ColPAVE_VSITVIL.Name = "ColPAVE_VSITVIL"
        Me.ColPAVE_VSITVIL.OptionsColumn.AllowEdit = False
        Me.ColPAVE_VSITVIL.OptionsColumn.ReadOnly = True
        '
        'ColPAVE_NIPLNUM
        '
        resources.ApplyResources(Me.ColPAVE_NIPLNUM, "ColPAVE_NIPLNUM")
        Me.ColPAVE_NIPLNUM.FieldName = "NIPLNUM"
        Me.ColPAVE_NIPLNUM.Name = "ColPAVE_NIPLNUM"
        Me.ColPAVE_NIPLNUM.OptionsColumn.AllowEdit = False
        Me.ColPAVE_NIPLNUM.OptionsColumn.ReadOnly = True
        '
        'ColPAVE_CODEPAVE
        '
        Me.ColPAVE_CODEPAVE.AppearanceCell.Options.UseTextOptions = True
        Me.ColPAVE_CODEPAVE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPAVE_CODEPAVE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColPAVE_CODEPAVE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColPAVE_CODEPAVE.AppearanceHeader.Options.UseForeColor = True
        Me.ColPAVE_CODEPAVE.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPAVE_CODEPAVE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPAVE_CODEPAVE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColPAVE_CODEPAVE, "ColPAVE_CODEPAVE")
        Me.ColPAVE_CODEPAVE.FieldName = "CODEPAVE"
        Me.ColPAVE_CODEPAVE.Name = "ColPAVE_CODEPAVE"
        Me.ColPAVE_CODEPAVE.OptionsColumn.AllowEdit = False
        Me.ColPAVE_CODEPAVE.OptionsColumn.ReadOnly = True
        '
        'ColPAVE_DUREE
        '
        Me.ColPAVE_DUREE.AppearanceCell.Options.UseTextOptions = True
        Me.ColPAVE_DUREE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPAVE_DUREE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColPAVE_DUREE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColPAVE_DUREE.AppearanceHeader.Options.UseForeColor = True
        Me.ColPAVE_DUREE.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPAVE_DUREE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPAVE_DUREE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColPAVE_DUREE, "ColPAVE_DUREE")
        Me.ColPAVE_DUREE.FieldName = "DUREE"
        Me.ColPAVE_DUREE.Name = "ColPAVE_DUREE"
        Me.ColPAVE_DUREE.OptionsColumn.AllowEdit = False
        Me.ColPAVE_DUREE.OptionsColumn.ReadOnly = True
        '
        'ColPAVE_DIPLDATJ
        '
        resources.ApplyResources(Me.ColPAVE_DIPLDATJ, "ColPAVE_DIPLDATJ")
        Me.ColPAVE_DIPLDATJ.FieldName = "DIPLDATJ"
        Me.ColPAVE_DIPLDATJ.Name = "ColPAVE_DIPLDATJ"
        '
        'ColPAVE_CIPLMULT
        '
        resources.ApplyResources(Me.ColPAVE_CIPLMULT, "ColPAVE_CIPLMULT")
        Me.ColPAVE_CIPLMULT.FieldName = "CIPLMULT"
        Me.ColPAVE_CIPLMULT.Name = "ColPAVE_CIPLMULT"
        '
        'GrpACT
        '
        Me.GrpACT.Controls.Add(Me.GCACT)
        resources.ApplyResources(Me.GrpACT, "GrpACT")
        Me.GrpACT.Name = "GrpACT"
        Me.GrpACT.TabStop = False
        '
        'GCACT
        '
        resources.ApplyResources(Me.GCACT, "GCACT")
        Me.GCACT.MainView = Me.GVACT
        Me.GCACT.Name = "GCACT"
        Me.GCACT.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEditMulti, Me.RepositoryItemButtonEditMOZART})
        Me.GCACT.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVACT})
        '
        'GVACT
        '
        Me.GVACT.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColACT_NIPLNUM, Me.ColACT_NDINNUM, Me.ColACT_NACTID, Me.ColACT_VACTDES, Me.ColACT_VISA, Me.ColACT_DACTARR, Me.ColACT_DACTDEX, Me.ColACT_NACTDUR, Me.ColACT_DVISAARR, Me.ColACT_DVISAEXEC, Me.ColACT_NACTNUM, Me.ColACT_BTNIPLMULT, Me.ColAct_CIPLMULT, Me.ColAct_NCLINUM})
        Me.GVACT.GridControl = Me.GCACT
        Me.GVACT.Name = "GVACT"
        Me.GVACT.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVACT.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GVACT.OptionsSelection.EnableAppearanceHideSelection = False
        Me.GVACT.OptionsView.ShowGroupPanel = False
        '
        'ColACT_NIPLNUM
        '
        resources.ApplyResources(Me.ColACT_NIPLNUM, "ColACT_NIPLNUM")
        Me.ColACT_NIPLNUM.FieldName = "NIPLNUM"
        Me.ColACT_NIPLNUM.Name = "ColACT_NIPLNUM"
        Me.ColACT_NIPLNUM.OptionsColumn.AllowEdit = False
        Me.ColACT_NIPLNUM.OptionsColumn.ReadOnly = True
        '
        'ColACT_NDINNUM
        '
        Me.ColACT_NDINNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColACT_NDINNUM.AppearanceHeader.Options.UseForeColor = True
        Me.ColACT_NDINNUM.AppearanceHeader.Options.UseTextOptions = True
        Me.ColACT_NDINNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColACT_NDINNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColACT_NDINNUM, "ColACT_NDINNUM")
        Me.ColACT_NDINNUM.FieldName = "NDINNUM"
        Me.ColACT_NDINNUM.Name = "ColACT_NDINNUM"
        Me.ColACT_NDINNUM.OptionsColumn.AllowEdit = False
        Me.ColACT_NDINNUM.OptionsColumn.ReadOnly = True
        '
        'ColACT_NACTID
        '
        Me.ColACT_NACTID.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColACT_NACTID.AppearanceHeader.Options.UseForeColor = True
        Me.ColACT_NACTID.AppearanceHeader.Options.UseTextOptions = True
        Me.ColACT_NACTID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColACT_NACTID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColACT_NACTID, "ColACT_NACTID")
        Me.ColACT_NACTID.FieldName = "NACTID"
        Me.ColACT_NACTID.Name = "ColACT_NACTID"
        Me.ColACT_NACTID.OptionsColumn.AllowEdit = False
        Me.ColACT_NACTID.OptionsColumn.ReadOnly = True
        '
        'ColACT_VACTDES
        '
        Me.ColACT_VACTDES.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColACT_VACTDES.AppearanceHeader.Options.UseForeColor = True
        Me.ColACT_VACTDES.AppearanceHeader.Options.UseTextOptions = True
        Me.ColACT_VACTDES.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColACT_VACTDES.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColACT_VACTDES, "ColACT_VACTDES")
        Me.ColACT_VACTDES.FieldName = "VACTDES"
        Me.ColACT_VACTDES.Name = "ColACT_VACTDES"
        Me.ColACT_VACTDES.OptionsColumn.AllowEdit = False
        Me.ColACT_VACTDES.OptionsColumn.ReadOnly = True
        '
        'ColACT_VISA
        '
        Me.ColACT_VISA.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColACT_VISA.AppearanceHeader.Options.UseForeColor = True
        Me.ColACT_VISA.AppearanceHeader.Options.UseTextOptions = True
        Me.ColACT_VISA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColACT_VISA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColACT_VISA, "ColACT_VISA")
        Me.ColACT_VISA.ColumnEdit = Me.RepositoryItemButtonEditMOZART
        Me.ColACT_VISA.FieldName = "VISA"
        Me.ColACT_VISA.Name = "ColACT_VISA"
        '
        'RepositoryItemButtonEditMOZART
        '
        resources.ApplyResources(Me.RepositoryItemButtonEditMOZART, "RepositoryItemButtonEditMOZART")
        SerializableAppearanceObject1.Options.UseFont = True
        SerializableAppearanceObject1.Options.UseTextOptions = True
        SerializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        SerializableAppearanceObject1.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        SerializableAppearanceObject2.Options.UseFont = True
        SerializableAppearanceObject2.Options.UseTextOptions = True
        SerializableAppearanceObject2.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        SerializableAppearanceObject2.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        SerializableAppearanceObject3.Options.UseFont = True
        SerializableAppearanceObject3.Options.UseTextOptions = True
        SerializableAppearanceObject3.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        SerializableAppearanceObject3.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        SerializableAppearanceObject4.Options.UseFont = True
        SerializableAppearanceObject4.Options.UseTextOptions = True
        SerializableAppearanceObject4.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        SerializableAppearanceObject4.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.RepositoryItemButtonEditMOZART.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemButtonEditMOZART.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines), resources.GetString("RepositoryItemButtonEditMOZART.Buttons1"), CType(resources.GetObject("RepositoryItemButtonEditMOZART.Buttons2"), Integer), CType(resources.GetObject("RepositoryItemButtonEditMOZART.Buttons3"), Boolean), CType(resources.GetObject("RepositoryItemButtonEditMOZART.Buttons4"), Boolean), CType(resources.GetObject("RepositoryItemButtonEditMOZART.Buttons5"), Boolean), EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, resources.GetString("RepositoryItemButtonEditMOZART.Buttons6"), CType(resources.GetObject("RepositoryItemButtonEditMOZART.Buttons7"), Object), CType(resources.GetObject("RepositoryItemButtonEditMOZART.Buttons8"), DevExpress.Utils.SuperToolTip), CType(resources.GetObject("RepositoryItemButtonEditMOZART.Buttons9"), DevExpress.Utils.ToolTipAnchor))})
        Me.RepositoryItemButtonEditMOZART.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.RepositoryItemButtonEditMOZART.Name = "RepositoryItemButtonEditMOZART"
        Me.RepositoryItemButtonEditMOZART.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColACT_DACTARR
        '
        Me.ColACT_DACTARR.AppearanceCell.Font = CType(resources.GetObject("ColACT_DACTARR.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColACT_DACTARR.AppearanceCell.Options.UseFont = True
        Me.ColACT_DACTARR.AppearanceCell.Options.UseTextOptions = True
        Me.ColACT_DACTARR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColACT_DACTARR.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColACT_DACTARR.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColACT_DACTARR.AppearanceHeader.Options.UseForeColor = True
        Me.ColACT_DACTARR.AppearanceHeader.Options.UseTextOptions = True
        Me.ColACT_DACTARR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColACT_DACTARR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColACT_DACTARR, "ColACT_DACTARR")
        Me.ColACT_DACTARR.DisplayFormat.FormatString = "g"
        Me.ColACT_DACTARR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColACT_DACTARR.FieldName = "DACTARR"
        Me.ColACT_DACTARR.Name = "ColACT_DACTARR"
        Me.ColACT_DACTARR.OptionsColumn.AllowEdit = False
        Me.ColACT_DACTARR.OptionsColumn.ReadOnly = True
        '
        'ColACT_DACTDEX
        '
        Me.ColACT_DACTDEX.AppearanceCell.Font = CType(resources.GetObject("ColACT_DACTDEX.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColACT_DACTDEX.AppearanceCell.Options.UseFont = True
        Me.ColACT_DACTDEX.AppearanceCell.Options.UseTextOptions = True
        Me.ColACT_DACTDEX.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColACT_DACTDEX.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColACT_DACTDEX.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColACT_DACTDEX.AppearanceHeader.Options.UseForeColor = True
        Me.ColACT_DACTDEX.AppearanceHeader.Options.UseTextOptions = True
        Me.ColACT_DACTDEX.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColACT_DACTDEX.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColACT_DACTDEX, "ColACT_DACTDEX")
        Me.ColACT_DACTDEX.DisplayFormat.FormatString = "g"
        Me.ColACT_DACTDEX.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColACT_DACTDEX.FieldName = "DACTDEX"
        Me.ColACT_DACTDEX.Name = "ColACT_DACTDEX"
        Me.ColACT_DACTDEX.OptionsColumn.AllowEdit = False
        Me.ColACT_DACTDEX.OptionsColumn.ReadOnly = True
        '
        'ColACT_NACTDUR
        '
        Me.ColACT_NACTDUR.AppearanceCell.Options.UseTextOptions = True
        Me.ColACT_NACTDUR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColACT_NACTDUR.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColACT_NACTDUR.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColACT_NACTDUR.AppearanceHeader.Options.UseForeColor = True
        Me.ColACT_NACTDUR.AppearanceHeader.Options.UseTextOptions = True
        Me.ColACT_NACTDUR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColACT_NACTDUR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColACT_NACTDUR, "ColACT_NACTDUR")
        Me.ColACT_NACTDUR.FieldName = "NACTDUR"
        Me.ColACT_NACTDUR.Name = "ColACT_NACTDUR"
        Me.ColACT_NACTDUR.OptionsColumn.AllowEdit = False
        Me.ColACT_NACTDUR.OptionsColumn.ReadOnly = True
        '
        'ColACT_DVISAARR
        '
        Me.ColACT_DVISAARR.AppearanceHeader.Options.UseTextOptions = True
        Me.ColACT_DVISAARR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColACT_DVISAARR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColACT_DVISAARR, "ColACT_DVISAARR")
        Me.ColACT_DVISAARR.FieldName = "DVISAARR"
        Me.ColACT_DVISAARR.Name = "ColACT_DVISAARR"
        '
        'ColACT_DVISAEXEC
        '
        Me.ColACT_DVISAEXEC.AppearanceHeader.Options.UseTextOptions = True
        Me.ColACT_DVISAEXEC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColACT_DVISAEXEC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColACT_DVISAEXEC, "ColACT_DVISAEXEC")
        Me.ColACT_DVISAEXEC.FieldName = "DVISAEXEC"
        Me.ColACT_DVISAEXEC.Name = "ColACT_DVISAEXEC"
        '
        'ColACT_NACTNUM
        '
        resources.ApplyResources(Me.ColACT_NACTNUM, "ColACT_NACTNUM")
        Me.ColACT_NACTNUM.FieldName = "NACTNUM"
        Me.ColACT_NACTNUM.Name = "ColACT_NACTNUM"
        '
        'ColACT_BTNIPLMULT
        '
        Me.ColACT_BTNIPLMULT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColACT_BTNIPLMULT.AppearanceHeader.Options.UseForeColor = True
        Me.ColACT_BTNIPLMULT.AppearanceHeader.Options.UseTextOptions = True
        Me.ColACT_BTNIPLMULT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColACT_BTNIPLMULT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColACT_BTNIPLMULT, "ColACT_BTNIPLMULT")
        Me.ColACT_BTNIPLMULT.ColumnEdit = Me.RepositoryItemButtonEditMulti
        Me.ColACT_BTNIPLMULT.Name = "ColACT_BTNIPLMULT"
        '
        'RepositoryItemButtonEditMulti
        '
        resources.ApplyResources(Me.RepositoryItemButtonEditMulti, "RepositoryItemButtonEditMulti")
        SerializableAppearanceObject5.Options.UseFont = True
        SerializableAppearanceObject6.Options.UseFont = True
        SerializableAppearanceObject7.Options.UseFont = True
        SerializableAppearanceObject8.Options.UseFont = True
        Me.RepositoryItemButtonEditMulti.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemButtonEditMulti.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines), resources.GetString("RepositoryItemButtonEditMulti.Buttons1"), CType(resources.GetObject("RepositoryItemButtonEditMulti.Buttons2"), Integer), CType(resources.GetObject("RepositoryItemButtonEditMulti.Buttons3"), Boolean), CType(resources.GetObject("RepositoryItemButtonEditMulti.Buttons4"), Boolean), CType(resources.GetObject("RepositoryItemButtonEditMulti.Buttons5"), Boolean), EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, resources.GetString("RepositoryItemButtonEditMulti.Buttons6"), CType(resources.GetObject("RepositoryItemButtonEditMulti.Buttons7"), Object), CType(resources.GetObject("RepositoryItemButtonEditMulti.Buttons8"), DevExpress.Utils.SuperToolTip), CType(resources.GetObject("RepositoryItemButtonEditMulti.Buttons9"), DevExpress.Utils.ToolTipAnchor))})
        Me.RepositoryItemButtonEditMulti.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.RepositoryItemButtonEditMulti.Name = "RepositoryItemButtonEditMulti"
        Me.RepositoryItemButtonEditMulti.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColAct_CIPLMULT
        '
        resources.ApplyResources(Me.ColAct_CIPLMULT, "ColAct_CIPLMULT")
        Me.ColAct_CIPLMULT.FieldName = "CIPLMULT"
        Me.ColAct_CIPLMULT.Name = "ColAct_CIPLMULT"
        '
        'ColAct_NCLINUM
        '
        resources.ApplyResources(Me.ColAct_NCLINUM, "ColAct_NCLINUM")
        Me.ColAct_NCLINUM.FieldName = "NCLINUM"
        Me.ColAct_NCLINUM.Name = "ColAct_NCLINUM"
        '
        'GrpGeoloc
        '
        Me.GrpGeoloc.Controls.Add(Me.WebView21)
        resources.ApplyResources(Me.GrpGeoloc, "GrpGeoloc")
        Me.GrpGeoloc.Name = "GrpGeoloc"
        Me.GrpGeoloc.TabStop = False
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.BackColor = System.Drawing.Color.White
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        resources.ApplyResources(Me.WebView21, "WebView21")
        Me.WebView21.Name = "WebView21"
        Me.WebView21.ZoomFactor = 1.0R
        '
        'GridColumn1
        '
        Me.GridColumn1.Name = "GridColumn1"
        '
        'frmStatRHTempsTravail
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpGeoloc)
        Me.Controls.Add(Me.GrpACT)
        Me.Controls.Add(Me.GrpPave)
        Me.Controls.Add(Me.GrpDate)
        Me.Controls.Add(Me.GrpList)
        Me.Controls.Add(Me.GrpDetail)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmStatRHTempsTravail"
        Me.GrpActions.ResumeLayout(False)
        Me.GrpDetail.ResumeLayout(False)
        CType(Me.GCDETAIL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDETAIL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpList.ResumeLayout(False)
        CType(Me.GCMASTER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVMASTER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpDate.ResumeLayout(False)
        Me.GrpPave.ResumeLayout(False)
        CType(Me.GCPAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPAVE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpACT.ResumeLayout(False)
        CType(Me.GCACT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVACT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEditMOZART, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEditMulti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpGeoloc.ResumeLayout(False)
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents GrpDetail As System.Windows.Forms.GroupBox
    Friend WithEvents LblTitreTech As System.Windows.Forms.Label
    Friend WithEvents LblDureeTotal As System.Windows.Forms.Label
    Friend WithEvents GrpList As System.Windows.Forms.GroupBox
    Friend WithEvents GrpDate As System.Windows.Forms.GroupBox
    Friend WithEvents CboSem As System.Windows.Forms.ComboBox
    Friend WithEvents CboAnnee As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnValid As System.Windows.Forms.Button
    Friend WithEvents GrpPave As System.Windows.Forms.GroupBox
    Friend WithEvents GrpACT As System.Windows.Forms.GroupBox
    Friend WithEvents GrpGeoloc As System.Windows.Forms.GroupBox
    Friend WithEvents LblTech As System.Windows.Forms.Label
    Friend WithEvents BtnEdition As System.Windows.Forms.Button
    Private WithEvents GCDETAIL As DevExpress.XtraGrid.GridControl
    Private WithEvents GVDETAIL As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColDetailNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailDATCLASS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailARRIVEE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailDEPART As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailDUREE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailTPSTRAV As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailTPSPREVU As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailCOMMENTAIRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailCOLOR As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCMASTER As DevExpress.XtraGrid.GridControl
    Private WithEvents GVMASTER As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColMasterNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColMasterTECH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColMasterVSERV As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColMasterDUREE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColMasterCOLOR As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCPAVE As DevExpress.XtraGrid.GridControl
    Private WithEvents GVPAVE As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCACT As DevExpress.XtraGrid.GridControl
    Private WithEvents GVACT As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColPAVE_VCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColPAVE_VSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColPAVE_NIPLNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColPAVE_CODEPAVE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColPAVE_DUREE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColACT_NDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColACT_VACTDES As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColACT_VISA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColACT_DACTARR As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColACT_DACTDEX As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColACT_NACTDUR As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColACT_DVISAARR As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColACT_DVISAEXEC As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepositoryItemButtonEditMOZART As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Private WithEvents ColPAVE_VSITVIL As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColACT_NACTID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColPAVE_NCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColACT_NIPLNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColACT_NACTNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColACT_BTNIPLMULT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColPAVE_DIPLDATJ As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepositoryItemButtonEditMulti As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Private WithEvents ColPAVE_CIPLMULT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailCIPLMULTI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColAct_CIPLMULT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColAct_NCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
End Class
