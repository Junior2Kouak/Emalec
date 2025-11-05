<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCauserieListeResultByPER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCauserieListeResultByPER))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.GColVFICQCMETACORRECT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVQCMTITRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GColDFICQCMCRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColTPSQCM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVATTREP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNIDQCMNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDFICQCMTERM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnEditRep = New System.Windows.Forms.Button()
        Me.GColNIDFICQCM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnArchives = New System.Windows.Forms.Button()
        Me.GrpBoxActions = New System.Windows.Forms.GroupBox()
        Me.BtnExportXLSX = New System.Windows.Forms.Button()
        Me.BtnDetail = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GVCAUSERIE = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNBREPNOVERIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDVALIDCORRECTENVOI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDRETCORRECTSIGNTECH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCCAUSERIE = New DevExpress.XtraGrid.GridControl()
        Me.SDF = New System.Windows.Forms.SaveFileDialog()
        Me.GrpBoxActions.SuspendLayout()
        CType(Me.GVCAUSERIE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCCAUSERIE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GColVFICQCMETACORRECT
        '
        Me.GColVFICQCMETACORRECT.AppearanceCell.Options.UseTextOptions = True
        Me.GColVFICQCMETACORRECT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVFICQCMETACORRECT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVFICQCMETACORRECT.AppearanceHeader.Font = CType(resources.GetObject("GColVFICQCMETACORRECT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVFICQCMETACORRECT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVFICQCMETACORRECT.AppearanceHeader.Options.UseFont = True
        Me.GColVFICQCMETACORRECT.AppearanceHeader.Options.UseForeColor = True
        Me.GColVFICQCMETACORRECT.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVFICQCMETACORRECT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVFICQCMETACORRECT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVFICQCMETACORRECT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVFICQCMETACORRECT, "GColVFICQCMETACORRECT")
        Me.GColVFICQCMETACORRECT.FieldName = "VFICQCMETACORRECT"
        Me.GColVFICQCMETACORRECT.Name = "GColVFICQCMETACORRECT"
        Me.GColVFICQCMETACORRECT.OptionsColumn.AllowEdit = False
        Me.GColVFICQCMETACORRECT.OptionsColumn.ReadOnly = True
        '
        'GColVQCMTITRE
        '
        Me.GColVQCMTITRE.AppearanceHeader.Font = CType(resources.GetObject("GColVQCMTITRE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVQCMTITRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVQCMTITRE.AppearanceHeader.Options.UseFont = True
        Me.GColVQCMTITRE.AppearanceHeader.Options.UseForeColor = True
        Me.GColVQCMTITRE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVQCMTITRE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVQCMTITRE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVQCMTITRE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVQCMTITRE, "GColVQCMTITRE")
        Me.GColVQCMTITRE.FieldName = "VQCMTITRE"
        Me.GColVQCMTITRE.Name = "GColVQCMTITRE"
        Me.GColVQCMTITRE.OptionsColumn.AllowEdit = False
        Me.GColVQCMTITRE.OptionsColumn.ReadOnly = True
        Me.GColVQCMTITRE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = False
        '
        'GColDFICQCMCRE
        '
        Me.GColDFICQCMCRE.AppearanceCell.Options.UseTextOptions = True
        Me.GColDFICQCMCRE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDFICQCMCRE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDFICQCMCRE.AppearanceHeader.Font = CType(resources.GetObject("GColDFICQCMCRE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDFICQCMCRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDFICQCMCRE.AppearanceHeader.Options.UseFont = True
        Me.GColDFICQCMCRE.AppearanceHeader.Options.UseForeColor = True
        Me.GColDFICQCMCRE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDFICQCMCRE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDFICQCMCRE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDFICQCMCRE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColDFICQCMCRE, "GColDFICQCMCRE")
        Me.GColDFICQCMCRE.FieldName = "DFICQCMCRE"
        Me.GColDFICQCMCRE.Name = "GColDFICQCMCRE"
        Me.GColDFICQCMCRE.OptionsColumn.AllowEdit = False
        Me.GColDFICQCMCRE.OptionsColumn.ReadOnly = True
        Me.GColDFICQCMCRE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNPERNUM
        '
        resources.ApplyResources(Me.GColNPERNUM, "GColNPERNUM")
        Me.GColNPERNUM.FieldName = "NPERNUM"
        Me.GColNPERNUM.Name = "GColNPERNUM"
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
        Me.GColTPSQCM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColTPSQCM, "GColTPSQCM")
        Me.GColTPSQCM.FieldName = "TPSQCM"
        Me.GColTPSQCM.Name = "GColTPSQCM"
        Me.GColTPSQCM.OptionsColumn.AllowEdit = False
        Me.GColTPSQCM.OptionsColumn.ReadOnly = True
        Me.GColTPSQCM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVATTREP
        '
        Me.GColVATTREP.AppearanceCell.Options.UseTextOptions = True
        Me.GColVATTREP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVATTREP.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVATTREP.AppearanceHeader.Font = CType(resources.GetObject("GColVATTREP.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVATTREP.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVATTREP.AppearanceHeader.Options.UseFont = True
        Me.GColVATTREP.AppearanceHeader.Options.UseForeColor = True
        Me.GColVATTREP.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVATTREP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVATTREP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVATTREP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVATTREP, "GColVATTREP")
        Me.GColVATTREP.FieldName = "VATTREP"
        Me.GColVATTREP.Name = "GColVATTREP"
        Me.GColVATTREP.OptionsColumn.AllowEdit = False
        Me.GColVATTREP.OptionsColumn.ReadOnly = True
        Me.GColVATTREP.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNIDQCMNUM
        '
        resources.ApplyResources(Me.GColNIDQCMNUM, "GColNIDQCMNUM")
        Me.GColNIDQCMNUM.FieldName = "NIDQCMNUM"
        Me.GColNIDQCMNUM.Name = "GColNIDQCMNUM"
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
        Me.GColDFICQCMTERM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColDFICQCMTERM, "GColDFICQCMTERM")
        Me.GColDFICQCMTERM.FieldName = "DFICQCMTERM"
        Me.GColDFICQCMTERM.Name = "GColDFICQCMTERM"
        Me.GColDFICQCMTERM.OptionsColumn.AllowEdit = False
        Me.GColDFICQCMTERM.OptionsColumn.ReadOnly = True
        Me.GColDFICQCMTERM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'BtnEditRep
        '
        Me.BtnEditRep.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.BtnEditRep, "BtnEditRep")
        Me.BtnEditRep.Name = "BtnEditRep"
        Me.BtnEditRep.UseVisualStyleBackColor = False
        '
        'GColNIDFICQCM
        '
        resources.ApplyResources(Me.GColNIDFICQCM, "GColNIDFICQCM")
        Me.GColNIDFICQCM.FieldName = "NIDFICQCM"
        Me.GColNIDFICQCM.Name = "GColNIDFICQCM"
        '
        'BtnArchives
        '
        Me.BtnArchives.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.BtnArchives, "BtnArchives")
        Me.BtnArchives.Name = "BtnArchives"
        Me.BtnArchives.UseVisualStyleBackColor = False
        '
        'GrpBoxActions
        '
        Me.GrpBoxActions.Controls.Add(Me.BtnExportXLSX)
        Me.GrpBoxActions.Controls.Add(Me.BtnEditRep)
        Me.GrpBoxActions.Controls.Add(Me.BtnArchives)
        Me.GrpBoxActions.Controls.Add(Me.BtnDetail)
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
        'BtnDetail
        '
        Me.BtnDetail.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.BtnDetail, "BtnDetail")
        Me.BtnDetail.Name = "BtnDetail"
        Me.BtnDetail.UseVisualStyleBackColor = False
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GVCAUSERIE
        '
        Me.GVCAUSERIE.Appearance.FocusedCell.BackColor = System.Drawing.Color.Gainsboro
        Me.GVCAUSERIE.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVCAUSERIE.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gainsboro
        Me.GVCAUSERIE.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVCAUSERIE.ColumnPanelRowHeight = 80
        Me.GVCAUSERIE.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNIDFICQCM, Me.GColNIDQCMNUM, Me.GColNPERNUM, Me.GColVQCMTITRE, Me.GColDFICQCMCRE, Me.GColVATTREP, Me.GColDFICQCMTERM, Me.GColTPSQCM, Me.GColVFICQCMETACORRECT, Me.GColNBREPNOVERIF, Me.GColDVALIDCORRECTENVOI, Me.GColDRETCORRECTSIGNTECH})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Orange
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "Correction prête à être envoyée"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "Correction envoyée, en attente de retour technicien"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Lime
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = "Le technicien a vérifié les corrections et signé la causerie"
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.Gainsboro
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Value1 = "Il reste des réponses à contrôler"
        StyleFormatCondition5.Appearance.BackColor = System.Drawing.Color.Yellow
        StyleFormatCondition5.Appearance.Options.UseBackColor = True
        StyleFormatCondition5.Column = Me.GColVFICQCMETACORRECT
        StyleFormatCondition5.Value1 = "Le technicien n'a toujours pas répondu à la causerie"
        Me.GVCAUSERIE.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4, StyleFormatCondition5})
        Me.GVCAUSERIE.GridControl = Me.GCCAUSERIE
        Me.GVCAUSERIE.Name = "GVCAUSERIE"
        Me.GVCAUSERIE.OptionsView.ShowAutoFilterRow = True
        Me.GVCAUSERIE.OptionsView.ShowGroupPanel = False
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
        Me.GColDVALIDCORRECTENVOI.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDVALIDCORRECTENVOI.AppearanceHeader.Options.UseFont = True
        Me.GColDVALIDCORRECTENVOI.AppearanceHeader.Options.UseForeColor = True
        Me.GColDVALIDCORRECTENVOI.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDVALIDCORRECTENVOI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDVALIDCORRECTENVOI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDVALIDCORRECTENVOI.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColDVALIDCORRECTENVOI, "GColDVALIDCORRECTENVOI")
        Me.GColDVALIDCORRECTENVOI.FieldName = "DVALIDCORRECTENVOI"
        Me.GColDVALIDCORRECTENVOI.Name = "GColDVALIDCORRECTENVOI"
        Me.GColDVALIDCORRECTENVOI.OptionsColumn.AllowEdit = False
        Me.GColDVALIDCORRECTENVOI.OptionsColumn.ReadOnly = True
        '
        'GColDRETCORRECTSIGNTECH
        '
        Me.GColDRETCORRECTSIGNTECH.AppearanceCell.Options.UseTextOptions = True
        Me.GColDRETCORRECTSIGNTECH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDRETCORRECTSIGNTECH.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDRETCORRECTSIGNTECH.AppearanceHeader.Font = CType(resources.GetObject("GColDRETCORRECTSIGNTECH.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDRETCORRECTSIGNTECH.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDRETCORRECTSIGNTECH.AppearanceHeader.Options.UseFont = True
        Me.GColDRETCORRECTSIGNTECH.AppearanceHeader.Options.UseForeColor = True
        Me.GColDRETCORRECTSIGNTECH.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDRETCORRECTSIGNTECH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDRETCORRECTSIGNTECH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDRETCORRECTSIGNTECH.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColDRETCORRECTSIGNTECH, "GColDRETCORRECTSIGNTECH")
        Me.GColDRETCORRECTSIGNTECH.FieldName = "DRETCORRECTSIGNTECH"
        Me.GColDRETCORRECTSIGNTECH.Name = "GColDRETCORRECTSIGNTECH"
        Me.GColDRETCORRECTSIGNTECH.OptionsColumn.AllowEdit = False
        Me.GColDRETCORRECTSIGNTECH.OptionsColumn.ReadOnly = True
        '
        'GCCAUSERIE
        '
        resources.ApplyResources(Me.GCCAUSERIE, "GCCAUSERIE")
        Me.GCCAUSERIE.MainView = Me.GVCAUSERIE
        Me.GCCAUSERIE.Name = "GCCAUSERIE"
        Me.GCCAUSERIE.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVCAUSERIE})
        '
        'frmCauserieListeResultByPER
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnFermer
        Me.Controls.Add(Me.GrpBoxActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GCCAUSERIE)
        Me.Controls.Add(Me.BtnFermer)
        Me.Name = "frmCauserieListeResultByPER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpBoxActions.ResumeLayout(False)
        CType(Me.GVCAUSERIE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCCAUSERIE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnEditRep As System.Windows.Forms.Button
    Friend WithEvents BtnArchives As System.Windows.Forms.Button
    Friend WithEvents GrpBoxActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDetail As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Private WithEvents GColVQCMTITRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDFICQCMCRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColTPSQCM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVATTREP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNIDQCMNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDFICQCMTERM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNIDFICQCM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVCAUSERIE As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCCAUSERIE As DevExpress.XtraGrid.GridControl
    Private WithEvents GColVFICQCMETACORRECT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNBREPNOVERIF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDVALIDCORRECTENVOI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDRETCORRECTSIGNTECH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnExportXLSX As Button
    Friend WithEvents SDF As SaveFileDialog
End Class
