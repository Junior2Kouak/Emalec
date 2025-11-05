<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQCMListeResultByQCMCandidat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQCMListeResultByQCMCandidat))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.GColVFICQCMETACORRECT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GCQCM = New DevExpress.XtraGrid.GridControl()
        Me.GVQCM = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNIDFICQCM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNIDQCMNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNIDCANDIDAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVNOMTECH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDFICQCMCRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVATTREP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDFICQCMTERM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColTPSQCM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVFICQCMRESULT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVDETRESULT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNBREPNOVERIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDVALIDCORRECTENVOI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDRETCORRECTSIGNTECH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpBoxActions = New System.Windows.Forms.GroupBox()
        Me.BtnExportXLSX = New System.Windows.Forms.Button()
        Me.BtnEditRep = New System.Windows.Forms.Button()
        Me.BtnDetail = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.SDF = New System.Windows.Forms.SaveFileDialog()
        CType(Me.GCQCM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVQCM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GColVFICQCMETACORRECT
        '
        Me.GColVFICQCMETACORRECT.AppearanceCell.Options.UseTextOptions = True
        Me.GColVFICQCMETACORRECT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVFICQCMETACORRECT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVFICQCMETACORRECT.AppearanceHeader.Font = CType(resources.GetObject("GColVFICQCMETACORRECT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVFICQCMETACORRECT.AppearanceHeader.Options.UseFont = True
        Me.GColVFICQCMETACORRECT.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVFICQCMETACORRECT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVFICQCMETACORRECT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVFICQCMETACORRECT, "GColVFICQCMETACORRECT")
        Me.GColVFICQCMETACORRECT.FieldName = "VFICQCMETACORRECT"
        Me.GColVFICQCMETACORRECT.Name = "GColVFICQCMETACORRECT"
        Me.GColVFICQCMETACORRECT.OptionsColumn.AllowEdit = False
        Me.GColVFICQCMETACORRECT.OptionsColumn.ReadOnly = True
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GCQCM
        '
        resources.ApplyResources(Me.GCQCM, "GCQCM")
        Me.GCQCM.MainView = Me.GVQCM
        Me.GCQCM.Name = "GCQCM"
        Me.GCQCM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVQCM})
        '
        'GVQCM
        '
        Me.GVQCM.ColumnPanelRowHeight = 80
        Me.GVQCM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNIDFICQCM, Me.GColNIDQCMNUM, Me.GColNIDCANDIDAT, Me.GColVNOMTECH, Me.GColDFICQCMCRE, Me.GColVATTREP, Me.GColDFICQCMTERM, Me.GColTPSQCM, Me.GColVFICQCMRESULT, Me.GColVDETRESULT, Me.GColVFICQCMETACORRECT, Me.GColNBREPNOVERIF, Me.GColDVALIDCORRECTENVOI, Me.GColDRETCORRECTSIGNTECH})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Orange
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Column = Me.GColVFICQCMETACORRECT
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "Correction prête à être envoyée"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Column = Me.GColVFICQCMETACORRECT
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "Correction envoyée, en attente de retour technicien"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Lime
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Column = Me.GColVFICQCMETACORRECT
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = "Le technicien a vérifié les corrections et signé le QCM"
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.Gainsboro
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.Column = Me.GColVFICQCMETACORRECT
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Value1 = "Il reste des réponses à contrôler"
        StyleFormatCondition5.Appearance.BackColor = System.Drawing.Color.Yellow
        StyleFormatCondition5.Appearance.Options.UseBackColor = True
        StyleFormatCondition5.Column = Me.GColVFICQCMETACORRECT
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition5.Value1 = "Le technicien n''a toujours pas répondu au QCM"
        Me.GVQCM.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4, StyleFormatCondition5})
        Me.GVQCM.GridControl = Me.GCQCM
        Me.GVQCM.Name = "GVQCM"
        Me.GVQCM.OptionsView.ShowAutoFilterRow = True
        Me.GVQCM.OptionsView.ShowGroupPanel = False
        '
        'GColNIDFICQCM
        '
        resources.ApplyResources(Me.GColNIDFICQCM, "GColNIDFICQCM")
        Me.GColNIDFICQCM.FieldName = "NIDFICQCM"
        Me.GColNIDFICQCM.Name = "GColNIDFICQCM"
        '
        'GColNIDQCMNUM
        '
        resources.ApplyResources(Me.GColNIDQCMNUM, "GColNIDQCMNUM")
        Me.GColNIDQCMNUM.FieldName = "NIDQCMNUM"
        Me.GColNIDQCMNUM.Name = "GColNIDQCMNUM"
        '
        'GColNIDCANDIDAT
        '
        resources.ApplyResources(Me.GColNIDCANDIDAT, "GColNIDCANDIDAT")
        Me.GColNIDCANDIDAT.FieldName = "NIDCANDIDAT"
        Me.GColNIDCANDIDAT.Name = "GColNIDCANDIDAT"
        '
        'GColVNOMTECH
        '
        Me.GColVNOMTECH.AppearanceHeader.Font = CType(resources.GetObject("GColVNOMTECH.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVNOMTECH.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVNOMTECH.AppearanceHeader.Options.UseFont = True
        Me.GColVNOMTECH.AppearanceHeader.Options.UseForeColor = True
        Me.GColVNOMTECH.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVNOMTECH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVNOMTECH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVNOMTECH, "GColVNOMTECH")
        Me.GColVNOMTECH.FieldName = "VNOMTECH"
        Me.GColVNOMTECH.Name = "GColVNOMTECH"
        Me.GColVNOMTECH.OptionsColumn.AllowEdit = False
        Me.GColVNOMTECH.OptionsColumn.ReadOnly = True
        Me.GColVNOMTECH.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColDFICQCMCRE
        '
        Me.GColDFICQCMCRE.AppearanceCell.Options.UseTextOptions = True
        Me.GColDFICQCMCRE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDFICQCMCRE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDFICQCMCRE.AppearanceHeader.Font = CType(resources.GetObject("GColDFICQCMCRE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDFICQCMCRE.AppearanceHeader.Options.UseFont = True
        Me.GColDFICQCMCRE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDFICQCMCRE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDFICQCMCRE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDFICQCMCRE, "GColDFICQCMCRE")
        Me.GColDFICQCMCRE.FieldName = "DFICQCMCRE"
        Me.GColDFICQCMCRE.Name = "GColDFICQCMCRE"
        Me.GColDFICQCMCRE.OptionsColumn.AllowEdit = False
        Me.GColDFICQCMCRE.OptionsColumn.ReadOnly = True
        Me.GColDFICQCMCRE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVATTREP
        '
        Me.GColVATTREP.AppearanceCell.Options.UseTextOptions = True
        Me.GColVATTREP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVATTREP.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVATTREP.AppearanceHeader.Font = CType(resources.GetObject("GColVATTREP.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVATTREP.AppearanceHeader.Options.UseFont = True
        Me.GColVATTREP.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVATTREP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVATTREP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVATTREP, "GColVATTREP")
        Me.GColVATTREP.FieldName = "VATTREP"
        Me.GColVATTREP.Name = "GColVATTREP"
        Me.GColVATTREP.OptionsColumn.AllowEdit = False
        Me.GColVATTREP.OptionsColumn.ReadOnly = True
        Me.GColVATTREP.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColDFICQCMTERM
        '
        Me.GColDFICQCMTERM.AppearanceCell.Options.UseTextOptions = True
        Me.GColDFICQCMTERM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDFICQCMTERM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDFICQCMTERM.AppearanceHeader.Font = CType(resources.GetObject("GColDFICQCMTERM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDFICQCMTERM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDFICQCMTERM.AppearanceHeader.Options.UseFont = True
        Me.GColDFICQCMTERM.AppearanceHeader.Options.UseForeColor = True
        Me.GColDFICQCMTERM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDFICQCMTERM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDFICQCMTERM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDFICQCMTERM, "GColDFICQCMTERM")
        Me.GColDFICQCMTERM.FieldName = "DFICQCMTERM"
        Me.GColDFICQCMTERM.Name = "GColDFICQCMTERM"
        Me.GColDFICQCMTERM.OptionsColumn.AllowEdit = False
        Me.GColDFICQCMTERM.OptionsColumn.ReadOnly = True
        Me.GColDFICQCMTERM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColTPSQCM
        '
        Me.GColTPSQCM.AppearanceCell.Options.UseTextOptions = True
        Me.GColTPSQCM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColTPSQCM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColTPSQCM.AppearanceHeader.Font = CType(resources.GetObject("GColTPSQCM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColTPSQCM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColTPSQCM.AppearanceHeader.Options.UseFont = True
        Me.GColTPSQCM.AppearanceHeader.Options.UseForeColor = True
        Me.GColTPSQCM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColTPSQCM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColTPSQCM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColTPSQCM, "GColTPSQCM")
        Me.GColTPSQCM.FieldName = "TPSQCM"
        Me.GColTPSQCM.Name = "GColTPSQCM"
        Me.GColTPSQCM.OptionsColumn.AllowEdit = False
        Me.GColTPSQCM.OptionsColumn.ReadOnly = True
        Me.GColTPSQCM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVFICQCMRESULT
        '
        Me.GColVFICQCMRESULT.AppearanceCell.Options.UseTextOptions = True
        Me.GColVFICQCMRESULT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVFICQCMRESULT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVFICQCMRESULT.AppearanceHeader.Font = CType(resources.GetObject("GColVFICQCMRESULT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVFICQCMRESULT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVFICQCMRESULT.AppearanceHeader.Options.UseFont = True
        Me.GColVFICQCMRESULT.AppearanceHeader.Options.UseForeColor = True
        Me.GColVFICQCMRESULT.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVFICQCMRESULT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVFICQCMRESULT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVFICQCMRESULT, "GColVFICQCMRESULT")
        Me.GColVFICQCMRESULT.FieldName = "VFICQCMRESULT"
        Me.GColVFICQCMRESULT.Name = "GColVFICQCMRESULT"
        Me.GColVFICQCMRESULT.OptionsColumn.AllowEdit = False
        Me.GColVFICQCMRESULT.OptionsColumn.ReadOnly = True
        Me.GColVFICQCMRESULT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVDETRESULT
        '
        Me.GColVDETRESULT.AppearanceCell.Options.UseTextOptions = True
        Me.GColVDETRESULT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVDETRESULT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVDETRESULT.AppearanceHeader.Font = CType(resources.GetObject("GColVDETRESULT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVDETRESULT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVDETRESULT.AppearanceHeader.Options.UseFont = True
        Me.GColVDETRESULT.AppearanceHeader.Options.UseForeColor = True
        Me.GColVDETRESULT.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVDETRESULT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVDETRESULT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVDETRESULT, "GColVDETRESULT")
        Me.GColVDETRESULT.FieldName = "VDETRESULT"
        Me.GColVDETRESULT.Name = "GColVDETRESULT"
        Me.GColVDETRESULT.OptionsColumn.AllowEdit = False
        Me.GColVDETRESULT.OptionsColumn.ReadOnly = True
        Me.GColVDETRESULT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNBREPNOVERIF
        '
        resources.ApplyResources(Me.GColNBREPNOVERIF, "GColNBREPNOVERIF")
        Me.GColNBREPNOVERIF.FieldName = "NBREPNOVERIF"
        Me.GColNBREPNOVERIF.Name = "GColNBREPNOVERIF"
        '
        'GColDVALIDCORRECTENVOI
        '
        Me.GColDVALIDCORRECTENVOI.AppearanceCell.Options.UseTextOptions = True
        Me.GColDVALIDCORRECTENVOI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDVALIDCORRECTENVOI.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDVALIDCORRECTENVOI.AppearanceHeader.Font = CType(resources.GetObject("GColDVALIDCORRECTENVOI.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDVALIDCORRECTENVOI.AppearanceHeader.Options.UseFont = True
        Me.GColDVALIDCORRECTENVOI.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDVALIDCORRECTENVOI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDVALIDCORRECTENVOI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDVALIDCORRECTENVOI.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColDVALIDCORRECTENVOI, "GColDVALIDCORRECTENVOI")
        Me.GColDVALIDCORRECTENVOI.FieldName = "DVALIDCORRECTENVOI"
        Me.GColDVALIDCORRECTENVOI.Name = "GColDVALIDCORRECTENVOI"
        '
        'GColDRETCORRECTSIGNTECH
        '
        Me.GColDRETCORRECTSIGNTECH.AppearanceCell.Options.UseTextOptions = True
        Me.GColDRETCORRECTSIGNTECH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDRETCORRECTSIGNTECH.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDRETCORRECTSIGNTECH.AppearanceHeader.Font = CType(resources.GetObject("GColDRETCORRECTSIGNTECH.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDRETCORRECTSIGNTECH.AppearanceHeader.Options.UseFont = True
        Me.GColDRETCORRECTSIGNTECH.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDRETCORRECTSIGNTECH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDRETCORRECTSIGNTECH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDRETCORRECTSIGNTECH.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColDRETCORRECTSIGNTECH, "GColDRETCORRECTSIGNTECH")
        Me.GColDRETCORRECTSIGNTECH.FieldName = "DRETCORRECTSIGNTECH"
        Me.GColDRETCORRECTSIGNTECH.Name = "GColDRETCORRECTSIGNTECH"
        '
        'GrpBoxActions
        '
        Me.GrpBoxActions.Controls.Add(Me.BtnExportXLSX)
        Me.GrpBoxActions.Controls.Add(Me.BtnEditRep)
        Me.GrpBoxActions.Controls.Add(Me.BtnDetail)
        Me.GrpBoxActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpBoxActions, "GrpBoxActions")
        Me.GrpBoxActions.Name = "GrpBoxActions"
        Me.GrpBoxActions.TabStop = False
        '
        'BtnExportXLSX
        '
        resources.ApplyResources(Me.BtnExportXLSX, "BtnExportXLSX")
        Me.BtnExportXLSX.Name = "BtnExportXLSX"
        Me.BtnExportXLSX.UseVisualStyleBackColor = True
        '
        'BtnEditRep
        '
        Me.BtnEditRep.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.BtnEditRep, "BtnEditRep")
        Me.BtnEditRep.Name = "BtnEditRep"
        Me.BtnEditRep.UseVisualStyleBackColor = False
        '
        'BtnDetail
        '
        Me.BtnDetail.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.BtnDetail, "BtnDetail")
        Me.BtnDetail.Name = "BtnDetail"
        Me.BtnDetail.UseVisualStyleBackColor = False
        '
        'BtnFermer
        '
        Me.BtnFermer.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = False
        '
        'frmQCMListeResultByQCMCandidat
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GCQCM)
        Me.Controls.Add(Me.GrpBoxActions)
        Me.Name = "frmQCMListeResultByQCMCandidat"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCQCM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVQCM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GrpBoxActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDetail As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnEditRep As System.Windows.Forms.Button
    Private WithEvents GCQCM As DevExpress.XtraGrid.GridControl
    Private WithEvents GVQCM As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNIDFICQCM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNIDQCMNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNIDCANDIDAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVNOMTECH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDFICQCMCRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVATTREP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDFICQCMTERM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColTPSQCM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVFICQCMRESULT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVDETRESULT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVFICQCMETACORRECT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNBREPNOVERIF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDVALIDCORRECTENVOI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDRETCORRECTSIGNTECH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SDF As SaveFileDialog
    Friend WithEvents BtnExportXLSX As Button
End Class
