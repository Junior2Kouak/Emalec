<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSynthCompta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSynthCompta))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition6 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition7 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition8 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition9 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition10 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.BGColBalAnaDIFFPOURCANNEE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCPourcRapportMoisPrec = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCPourcCA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCRapportAnneePrec = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColNDIFFPOURCCALASTMOIS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColNDIFFPOURCCALASTYEAR = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnDepenseAna = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnExportPDF = New System.Windows.Forms.Button()
        Me.BtnExportXLS = New System.Windows.Forms.Button()
        Me.SFDSynCompta = New System.Windows.Forms.SaveFileDialog()
        Me.XTPBalanceAna = New DevExpress.XtraTab.XtraTabPage()
        Me.GCBalanceAna = New DevExpress.XtraGrid.GridControl()
        Me.AdvBGVBilanAnaSoc = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GBBALCOMPTE = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGColBalAnaNCANNUM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColBalAnaVCANLIB = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBBALDEP = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGColBalAnaNDEPREEL = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColBalAnaNPOURCDEPREEL = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBBALTAB = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GBBALREAJUSTE = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGColBalAnaNSOLDE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColBalAnaOD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColBalAnaNAJUSTE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColBalAnaTOTREAJUST = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColAnaNPOURCREAJUST = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBBALANNEEPREC = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGColBalAnaPOURCANNEE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColBalAnaAJUSTE_TX_HOR = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColBalAnaCCTEANAACTIF = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.XTPBilanCpt = New DevExpress.XtraTab.XtraTabPage()
        Me.GCSynthCompta = New DevExpress.XtraGrid.GridControl()
        Me.AdvBGVBilanAna = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GBCompte = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGCNum = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCCTYPECTE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGVNRFAPOURC = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCCCTEANAACTIF = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCLibANA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBChaff = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGVLIBGROUPE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCChaff = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBProd = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGCMttCA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCCAMONTHLASTYEAR = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCPourcProd = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBResultFG = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GBBILANREAJUSTE = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGCSectAna = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCOD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCENCOURS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCENCOURSMANU = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCResultAjust = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBMOISPREC = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGCPourcMoisPrec = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBANNEEPREC = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGCPourcAnneePrec = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBBILANRESULT = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGCPourcTotal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBPartFG = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGCPartFGMtt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCPourcFG = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBTxChargeStruct = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGCPourcChargeStruct = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCPVRECEPT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCRESTDUTOT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCTXCONVERSEDCL = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCAJUSTE_TX_HOR = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.XTBCSynthCompta = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPREX = New DevExpress.XtraTab.XtraTabPage()
        Me.GCAnaREX = New DevExpress.XtraGrid.GridControl()
        Me.AdvBandedGVAnaREX = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GBREX = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGColNID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColVINTITULE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColNRESULT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColNPOURCCA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBREXMOIS = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGColNPOURCCALASTMOIS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBREXAN = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGColNPOURCCALASTYEAR = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GrpPeriode = New System.Windows.Forms.GroupBox()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.LblAnnee = New System.Windows.Forms.Label()
        Me.LblMois = New System.Windows.Forms.Label()
        Me.CboAnnee = New System.Windows.Forms.ComboBox()
        Me.CboMois = New System.Windows.Forms.ComboBox()
        Me.GrpActions.SuspendLayout()
        Me.XTPBalanceAna.SuspendLayout()
        CType(Me.GCBalanceAna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBGVBilanAnaSoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPBilanCpt.SuspendLayout()
        CType(Me.GCSynthCompta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBGVBilanAna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XTBCSynthCompta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTBCSynthCompta.SuspendLayout()
        Me.XTPREX.SuspendLayout()
        CType(Me.GCAnaREX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGVAnaREX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPeriode.SuspendLayout()
        Me.SuspendLayout()
        '
        'BGColBalAnaDIFFPOURCANNEE
        '
        Me.BGColBalAnaDIFFPOURCANNEE.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BGColBalAnaDIFFPOURCANNEE.AppearanceCell.Options.UseBackColor = True
        Me.BGColBalAnaDIFFPOURCANNEE.AppearanceHeader.Font = CType(resources.GetObject("BGColBalAnaDIFFPOURCANNEE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColBalAnaDIFFPOURCANNEE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaDIFFPOURCANNEE.AppearanceHeader.Options.UseFont = True
        Me.BGColBalAnaDIFFPOURCANNEE.AppearanceHeader.Options.UseForeColor = True
        Me.BGColBalAnaDIFFPOURCANNEE.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColBalAnaDIFFPOURCANNEE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColBalAnaDIFFPOURCANNEE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGColBalAnaDIFFPOURCANNEE, "BGColBalAnaDIFFPOURCANNEE")
        Me.BGColBalAnaDIFFPOURCANNEE.DisplayFormat.FormatString = "0.0 %"
        Me.BGColBalAnaDIFFPOURCANNEE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.BGColBalAnaDIFFPOURCANNEE.FieldName = "DIFFPOURCANNEE"
        Me.BGColBalAnaDIFFPOURCANNEE.Name = "BGColBalAnaDIFFPOURCANNEE"
        '
        'BGCPourcRapportMoisPrec
        '
        Me.BGCPourcRapportMoisPrec.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BGCPourcRapportMoisPrec.AppearanceCell.Options.UseBackColor = True
        Me.BGCPourcRapportMoisPrec.AppearanceHeader.Font = CType(resources.GetObject("BGCPourcRapportMoisPrec.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCPourcRapportMoisPrec.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCPourcRapportMoisPrec.AppearanceHeader.Options.UseFont = True
        Me.BGCPourcRapportMoisPrec.AppearanceHeader.Options.UseForeColor = True
        Me.BGCPourcRapportMoisPrec.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCPourcRapportMoisPrec.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCPourcRapportMoisPrec.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCPourcRapportMoisPrec.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCPourcRapportMoisPrec, "BGCPourcRapportMoisPrec")
        Me.BGCPourcRapportMoisPrec.DisplayFormat.FormatString = "0 %"
        Me.BGCPourcRapportMoisPrec.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.BGCPourcRapportMoisPrec.FieldName = "DIFFMOIS"
        Me.BGCPourcRapportMoisPrec.Name = "BGCPourcRapportMoisPrec"
        '
        'BGCPourcCA
        '
        Me.BGCPourcCA.AppearanceCell.Font = CType(resources.GetObject("BGCPourcCA.AppearanceCell.Font"), System.Drawing.Font)
        Me.BGCPourcCA.AppearanceCell.Options.UseFont = True
        Me.BGCPourcCA.AppearanceHeader.Font = CType(resources.GetObject("BGCPourcCA.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCPourcCA.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCPourcCA.AppearanceHeader.Options.UseFont = True
        Me.BGCPourcCA.AppearanceHeader.Options.UseForeColor = True
        Me.BGCPourcCA.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCPourcCA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCPourcCA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCPourcCA.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCPourcCA, "BGCPourcCA")
        Me.BGCPourcCA.DisplayFormat.FormatString = "0.0 %"
        Me.BGCPourcCA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.BGCPourcCA.FieldName = "NPOURCCAENCOURS"
        Me.BGCPourcCA.Name = "BGCPourcCA"
        Me.BGCPourcCA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGCPourcCA.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGCPourcCA.Summary1"), resources.GetString("BGCPourcCA.Summary2"), resources.GetString("BGCPourcCA.Summary3"))})
        '
        'BGCRapportAnneePrec
        '
        Me.BGCRapportAnneePrec.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BGCRapportAnneePrec.AppearanceCell.Options.UseBackColor = True
        Me.BGCRapportAnneePrec.AppearanceHeader.Font = CType(resources.GetObject("BGCRapportAnneePrec.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCRapportAnneePrec.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCRapportAnneePrec.AppearanceHeader.Options.UseFont = True
        Me.BGCRapportAnneePrec.AppearanceHeader.Options.UseForeColor = True
        Me.BGCRapportAnneePrec.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCRapportAnneePrec.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCRapportAnneePrec.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCRapportAnneePrec.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCRapportAnneePrec, "BGCRapportAnneePrec")
        Me.BGCRapportAnneePrec.DisplayFormat.FormatString = "0 %"
        Me.BGCRapportAnneePrec.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.BGCRapportAnneePrec.FieldName = "DIFFAN"
        Me.BGCRapportAnneePrec.Name = "BGCRapportAnneePrec"
        '
        'BGColNDIFFPOURCCALASTMOIS
        '
        Me.BGColNDIFFPOURCCALASTMOIS.AppearanceHeader.Font = CType(resources.GetObject("BGColNDIFFPOURCCALASTMOIS.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColNDIFFPOURCCALASTMOIS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColNDIFFPOURCCALASTMOIS.AppearanceHeader.Options.UseFont = True
        Me.BGColNDIFFPOURCCALASTMOIS.AppearanceHeader.Options.UseForeColor = True
        Me.BGColNDIFFPOURCCALASTMOIS.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColNDIFFPOURCCALASTMOIS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColNDIFFPOURCCALASTMOIS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColNDIFFPOURCCALASTMOIS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGColNDIFFPOURCCALASTMOIS, "BGColNDIFFPOURCCALASTMOIS")
        Me.BGColNDIFFPOURCCALASTMOIS.DisplayFormat.FormatString = "n2"
        Me.BGColNDIFFPOURCCALASTMOIS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGColNDIFFPOURCCALASTMOIS.FieldName = "NDIFFPOURCCALASTMOIS"
        Me.BGColNDIFFPOURCCALASTMOIS.Name = "BGColNDIFFPOURCCALASTMOIS"
        '
        'BGColNDIFFPOURCCALASTYEAR
        '
        Me.BGColNDIFFPOURCCALASTYEAR.AppearanceHeader.Font = CType(resources.GetObject("BGColNDIFFPOURCCALASTYEAR.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColNDIFFPOURCCALASTYEAR.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColNDIFFPOURCCALASTYEAR.AppearanceHeader.Options.UseFont = True
        Me.BGColNDIFFPOURCCALASTYEAR.AppearanceHeader.Options.UseForeColor = True
        Me.BGColNDIFFPOURCCALASTYEAR.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColNDIFFPOURCCALASTYEAR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColNDIFFPOURCCALASTYEAR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColNDIFFPOURCCALASTYEAR.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGColNDIFFPOURCCALASTYEAR, "BGColNDIFFPOURCCALASTYEAR")
        Me.BGColNDIFFPOURCCALASTYEAR.DisplayFormat.FormatString = "n2"
        Me.BGColNDIFFPOURCCALASTYEAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGColNDIFFPOURCCALASTYEAR.FieldName = "NDIFFPOURCCALASTYEAR"
        Me.BGColNDIFFPOURCCALASTYEAR.Name = "BGColNDIFFPOURCCALASTYEAR"
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnDepenseAna)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnExportPDF)
        Me.GrpActions.Controls.Add(Me.BtnExportXLS)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnDepenseAna
        '
        Me.BtnDepenseAna.BackColor = System.Drawing.Color.PaleGreen
        resources.ApplyResources(Me.BtnDepenseAna, "BtnDepenseAna")
        Me.BtnDepenseAna.Name = "BtnDepenseAna"
        Me.BtnDepenseAna.UseVisualStyleBackColor = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.BackColor = System.Drawing.Color.LightYellow
        Me.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = False
        '
        'BtnExportPDF
        '
        Me.BtnExportPDF.BackColor = System.Drawing.Color.LightYellow
        resources.ApplyResources(Me.BtnExportPDF, "BtnExportPDF")
        Me.BtnExportPDF.Name = "BtnExportPDF"
        Me.BtnExportPDF.UseVisualStyleBackColor = False
        '
        'BtnExportXLS
        '
        Me.BtnExportXLS.BackColor = System.Drawing.Color.LightYellow
        resources.ApplyResources(Me.BtnExportXLS, "BtnExportXLS")
        Me.BtnExportXLS.Name = "BtnExportXLS"
        Me.BtnExportXLS.UseVisualStyleBackColor = False
        '
        'XTPBalanceAna
        '
        Me.XTPBalanceAna.Controls.Add(Me.GCBalanceAna)
        Me.XTPBalanceAna.Name = "XTPBalanceAna"
        resources.ApplyResources(Me.XTPBalanceAna, "XTPBalanceAna")
        Me.XTPBalanceAna.Tag = "370"
        '
        'GCBalanceAna
        '
        resources.ApplyResources(Me.GCBalanceAna, "GCBalanceAna")
        Me.GCBalanceAna.MainView = Me.AdvBGVBilanAnaSoc
        Me.GCBalanceAna.Name = "GCBalanceAna"
        Me.GCBalanceAna.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBGVBilanAnaSoc})
        '
        'AdvBGVBilanAnaSoc
        '
        Me.AdvBGVBilanAnaSoc.AppearancePrint.BandPanel.Font = CType(resources.GetObject("AdvBGVBilanAnaSoc.AppearancePrint.BandPanel.Font"), System.Drawing.Font)
        Me.AdvBGVBilanAnaSoc.AppearancePrint.BandPanel.Options.UseFont = True
        Me.AdvBGVBilanAnaSoc.AppearancePrint.BandPanel.Options.UseTextOptions = True
        Me.AdvBGVBilanAnaSoc.AppearancePrint.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AdvBGVBilanAnaSoc.AppearancePrint.BandPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.AdvBGVBilanAnaSoc.AppearancePrint.BandPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBGVBilanAnaSoc.AppearancePrint.FooterPanel.Font = CType(resources.GetObject("AdvBGVBilanAnaSoc.AppearancePrint.FooterPanel.Font"), System.Drawing.Font)
        Me.AdvBGVBilanAnaSoc.AppearancePrint.FooterPanel.Options.UseFont = True
        Me.AdvBGVBilanAnaSoc.AppearancePrint.HeaderPanel.Font = CType(resources.GetObject("AdvBGVBilanAnaSoc.AppearancePrint.HeaderPanel.Font"), System.Drawing.Font)
        Me.AdvBGVBilanAnaSoc.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.AdvBGVBilanAnaSoc.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.AdvBGVBilanAnaSoc.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AdvBGVBilanAnaSoc.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.AdvBGVBilanAnaSoc.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBGVBilanAnaSoc.AppearancePrint.Row.Font = CType(resources.GetObject("AdvBGVBilanAnaSoc.AppearancePrint.Row.Font"), System.Drawing.Font)
        Me.AdvBGVBilanAnaSoc.AppearancePrint.Row.Options.UseFont = True
        Me.AdvBGVBilanAnaSoc.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GBBALCOMPTE, Me.GBBALDEP, Me.GBBALTAB})
        Me.AdvBGVBilanAnaSoc.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BGColBalAnaNCANNUM, Me.BGColBalAnaVCANLIB, Me.BGColBalAnaNDEPREEL, Me.BGColBalAnaNPOURCDEPREEL, Me.BGColBalAnaNSOLDE, Me.BGColBalAnaOD, Me.BGColBalAnaNAJUSTE, Me.BGColBalAnaTOTREAJUST, Me.BGColAnaNPOURCREAJUST, Me.BGColBalAnaPOURCANNEE, Me.BGColBalAnaDIFFPOURCANNEE, Me.BGColBalAnaAJUSTE_TX_HOR, Me.BGColBalAnaCCTEANAACTIF})
        Me.AdvBGVBilanAnaSoc.CustomizationFormBounds = New System.Drawing.Rectangle(1328, 569, 214, 206)
        GridFormatRule1.Column = Me.BGColBalAnaDIFFPOURCANNEE
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.Font = CType(resources.GetObject("resource.Font"), System.Drawing.Font)
        FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Red
        FormatConditionRuleValue1.Appearance.Options.UseFont = True
        FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual
        FormatConditionRuleValue1.Value1 = "0"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.Column = Me.BGColBalAnaDIFFPOURCANNEE
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.Font = CType(resources.GetObject("resource.Font1"), System.Drawing.Font)
        FormatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.Green
        FormatConditionRuleValue2.Appearance.Options.UseFont = True
        FormatConditionRuleValue2.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Greater
        FormatConditionRuleValue2.Value1 = "0"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        Me.AdvBGVBilanAnaSoc.FormatRules.Add(GridFormatRule1)
        Me.AdvBGVBilanAnaSoc.FormatRules.Add(GridFormatRule2)
        Me.AdvBGVBilanAnaSoc.GridControl = Me.GCBalanceAna
        Me.AdvBGVBilanAnaSoc.GroupCount = 1
        Me.AdvBGVBilanAnaSoc.LevelIndent = 0
        Me.AdvBGVBilanAnaSoc.Name = "AdvBGVBilanAnaSoc"
        Me.AdvBGVBilanAnaSoc.OptionsBehavior.Editable = False
        Me.AdvBGVBilanAnaSoc.OptionsBehavior.ReadOnly = True
        Me.AdvBGVBilanAnaSoc.OptionsCustomization.AllowBandMoving = False
        Me.AdvBGVBilanAnaSoc.OptionsCustomization.AllowBandResizing = False
        Me.AdvBGVBilanAnaSoc.OptionsPrint.ExpandAllGroups = False
        Me.AdvBGVBilanAnaSoc.OptionsView.ShowFooter = True
        Me.AdvBGVBilanAnaSoc.OptionsView.ShowGroupPanel = False
        Me.AdvBGVBilanAnaSoc.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.BGColBalAnaCCTEANAACTIF, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GBBALCOMPTE
        '
        Me.GBBALCOMPTE.AppearanceHeader.Font = CType(resources.GetObject("GBBALCOMPTE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBBALCOMPTE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GBBALCOMPTE.AppearanceHeader.Options.UseFont = True
        Me.GBBALCOMPTE.AppearanceHeader.Options.UseForeColor = True
        Me.GBBALCOMPTE.AppearanceHeader.Options.UseTextOptions = True
        Me.GBBALCOMPTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBBALCOMPTE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GBBALCOMPTE, "GBBALCOMPTE")
        Me.GBBALCOMPTE.Columns.Add(Me.BGColBalAnaNCANNUM)
        Me.GBBALCOMPTE.Columns.Add(Me.BGColBalAnaVCANLIB)
        Me.GBBALCOMPTE.VisibleIndex = 0
        '
        'BGColBalAnaNCANNUM
        '
        Me.BGColBalAnaNCANNUM.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaNCANNUM.AppearanceCell.Options.UseForeColor = True
        Me.BGColBalAnaNCANNUM.AppearanceCell.Options.UseTextOptions = True
        Me.BGColBalAnaNCANNUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColBalAnaNCANNUM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColBalAnaNCANNUM.AppearanceHeader.Font = CType(resources.GetObject("BGColBalAnaNCANNUM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColBalAnaNCANNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaNCANNUM.AppearanceHeader.Options.UseFont = True
        Me.BGColBalAnaNCANNUM.AppearanceHeader.Options.UseForeColor = True
        Me.BGColBalAnaNCANNUM.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColBalAnaNCANNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColBalAnaNCANNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColBalAnaNCANNUM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGColBalAnaNCANNUM, "BGColBalAnaNCANNUM")
        Me.BGColBalAnaNCANNUM.FieldName = "NCANNUM"
        Me.BGColBalAnaNCANNUM.Name = "BGColBalAnaNCANNUM"
        '
        'BGColBalAnaVCANLIB
        '
        Me.BGColBalAnaVCANLIB.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BGColBalAnaVCANLIB.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaVCANLIB.AppearanceCell.Options.UseBackColor = True
        Me.BGColBalAnaVCANLIB.AppearanceCell.Options.UseForeColor = True
        Me.BGColBalAnaVCANLIB.AppearanceCell.Options.UseTextOptions = True
        Me.BGColBalAnaVCANLIB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColBalAnaVCANLIB.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColBalAnaVCANLIB.AppearanceHeader.Font = CType(resources.GetObject("BGColBalAnaVCANLIB.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColBalAnaVCANLIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaVCANLIB.AppearanceHeader.Options.UseFont = True
        Me.BGColBalAnaVCANLIB.AppearanceHeader.Options.UseForeColor = True
        Me.BGColBalAnaVCANLIB.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColBalAnaVCANLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColBalAnaVCANLIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGColBalAnaVCANLIB, "BGColBalAnaVCANLIB")
        Me.BGColBalAnaVCANLIB.FieldName = "VCANLIB"
        Me.BGColBalAnaVCANLIB.Name = "BGColBalAnaVCANLIB"
        '
        'GBBALDEP
        '
        Me.GBBALDEP.AppearanceHeader.Font = CType(resources.GetObject("GBBALDEP.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBBALDEP.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GBBALDEP.AppearanceHeader.Options.UseFont = True
        Me.GBBALDEP.AppearanceHeader.Options.UseForeColor = True
        Me.GBBALDEP.AppearanceHeader.Options.UseTextOptions = True
        Me.GBBALDEP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBBALDEP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GBBALDEP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GBBALDEP, "GBBALDEP")
        Me.GBBALDEP.Columns.Add(Me.BGColBalAnaNDEPREEL)
        Me.GBBALDEP.Columns.Add(Me.BGColBalAnaNPOURCDEPREEL)
        Me.GBBALDEP.VisibleIndex = 1
        '
        'BGColBalAnaNDEPREEL
        '
        Me.BGColBalAnaNDEPREEL.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BGColBalAnaNDEPREEL.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaNDEPREEL.AppearanceCell.Options.UseBackColor = True
        Me.BGColBalAnaNDEPREEL.AppearanceCell.Options.UseForeColor = True
        Me.BGColBalAnaNDEPREEL.AppearanceHeader.Font = CType(resources.GetObject("BGColBalAnaNDEPREEL.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColBalAnaNDEPREEL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaNDEPREEL.AppearanceHeader.Options.UseFont = True
        Me.BGColBalAnaNDEPREEL.AppearanceHeader.Options.UseForeColor = True
        Me.BGColBalAnaNDEPREEL.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColBalAnaNDEPREEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColBalAnaNDEPREEL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGColBalAnaNDEPREEL, "BGColBalAnaNDEPREEL")
        Me.BGColBalAnaNDEPREEL.DisplayFormat.FormatString = "### ### ### ##0"
        Me.BGColBalAnaNDEPREEL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGColBalAnaNDEPREEL.FieldName = "NDEPREEL"
        Me.BGColBalAnaNDEPREEL.Name = "BGColBalAnaNDEPREEL"
        Me.BGColBalAnaNDEPREEL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGColBalAnaNDEPREEL.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGColBalAnaNDEPREEL.Summary1"), resources.GetString("BGColBalAnaNDEPREEL.Summary2"), resources.GetString("BGColBalAnaNDEPREEL.Summary3"))})
        '
        'BGColBalAnaNPOURCDEPREEL
        '
        Me.BGColBalAnaNPOURCDEPREEL.AppearanceCell.Font = CType(resources.GetObject("BGColBalAnaNPOURCDEPREEL.AppearanceCell.Font"), System.Drawing.Font)
        Me.BGColBalAnaNPOURCDEPREEL.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaNPOURCDEPREEL.AppearanceCell.Options.UseFont = True
        Me.BGColBalAnaNPOURCDEPREEL.AppearanceCell.Options.UseForeColor = True
        Me.BGColBalAnaNPOURCDEPREEL.AppearanceHeader.Font = CType(resources.GetObject("BGColBalAnaNPOURCDEPREEL.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColBalAnaNPOURCDEPREEL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaNPOURCDEPREEL.AppearanceHeader.Options.UseFont = True
        Me.BGColBalAnaNPOURCDEPREEL.AppearanceHeader.Options.UseForeColor = True
        Me.BGColBalAnaNPOURCDEPREEL.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColBalAnaNPOURCDEPREEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColBalAnaNPOURCDEPREEL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColBalAnaNPOURCDEPREEL.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGColBalAnaNPOURCDEPREEL, "BGColBalAnaNPOURCDEPREEL")
        Me.BGColBalAnaNPOURCDEPREEL.DisplayFormat.FormatString = "0.0 %"
        Me.BGColBalAnaNPOURCDEPREEL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.BGColBalAnaNPOURCDEPREEL.FieldName = "NPOURCDEPREEL"
        Me.BGColBalAnaNPOURCDEPREEL.Name = "BGColBalAnaNPOURCDEPREEL"
        Me.BGColBalAnaNPOURCDEPREEL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGColBalAnaNPOURCDEPREEL.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGColBalAnaNPOURCDEPREEL.Summary1"), resources.GetString("BGColBalAnaNPOURCDEPREEL.Summary2"))})
        '
        'GBBALTAB
        '
        Me.GBBALTAB.AppearanceHeader.Font = CType(resources.GetObject("GBBALTAB.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBBALTAB.AppearanceHeader.Options.UseFont = True
        Me.GBBALTAB.AppearanceHeader.Options.UseTextOptions = True
        Me.GBBALTAB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBBALTAB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GBBALTAB.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GBBALREAJUSTE, Me.GBBALANNEEPREC})
        resources.ApplyResources(Me.GBBALTAB, "GBBALTAB")
        Me.GBBALTAB.VisibleIndex = 2
        '
        'GBBALREAJUSTE
        '
        Me.GBBALREAJUSTE.AppearanceHeader.Font = CType(resources.GetObject("GBBALREAJUSTE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBBALREAJUSTE.AppearanceHeader.Options.UseFont = True
        Me.GBBALREAJUSTE.AppearanceHeader.Options.UseTextOptions = True
        Me.GBBALREAJUSTE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GBBALREAJUSTE.Columns.Add(Me.BGColBalAnaNSOLDE)
        Me.GBBALREAJUSTE.Columns.Add(Me.BGColBalAnaOD)
        Me.GBBALREAJUSTE.Columns.Add(Me.BGColBalAnaNAJUSTE)
        Me.GBBALREAJUSTE.Columns.Add(Me.BGColBalAnaTOTREAJUST)
        Me.GBBALREAJUSTE.Columns.Add(Me.BGColAnaNPOURCREAJUST)
        resources.ApplyResources(Me.GBBALREAJUSTE, "GBBALREAJUSTE")
        Me.GBBALREAJUSTE.VisibleIndex = 0
        '
        'BGColBalAnaNSOLDE
        '
        Me.BGColBalAnaNSOLDE.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaNSOLDE.AppearanceCell.Options.UseForeColor = True
        Me.BGColBalAnaNSOLDE.AppearanceHeader.Font = CType(resources.GetObject("BGColBalAnaNSOLDE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColBalAnaNSOLDE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaNSOLDE.AppearanceHeader.Options.UseFont = True
        Me.BGColBalAnaNSOLDE.AppearanceHeader.Options.UseForeColor = True
        Me.BGColBalAnaNSOLDE.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColBalAnaNSOLDE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColBalAnaNSOLDE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGColBalAnaNSOLDE, "BGColBalAnaNSOLDE")
        Me.BGColBalAnaNSOLDE.DisplayFormat.FormatString = "### ### ### ##0"
        Me.BGColBalAnaNSOLDE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGColBalAnaNSOLDE.FieldName = "NSOLDE"
        Me.BGColBalAnaNSOLDE.Name = "BGColBalAnaNSOLDE"
        Me.BGColBalAnaNSOLDE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGColBalAnaNSOLDE.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGColBalAnaNSOLDE.Summary1"), resources.GetString("BGColBalAnaNSOLDE.Summary2"))})
        '
        'BGColBalAnaOD
        '
        Me.BGColBalAnaOD.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaOD.AppearanceCell.Options.UseForeColor = True
        Me.BGColBalAnaOD.AppearanceHeader.Font = CType(resources.GetObject("BGColBalAnaOD.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColBalAnaOD.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaOD.AppearanceHeader.Options.UseFont = True
        Me.BGColBalAnaOD.AppearanceHeader.Options.UseForeColor = True
        Me.BGColBalAnaOD.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColBalAnaOD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColBalAnaOD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColBalAnaOD.DisplayFormat.FormatString = "### ### ### ##0"
        Me.BGColBalAnaOD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGColBalAnaOD.FieldName = "NOD"
        Me.BGColBalAnaOD.Name = "BGColBalAnaOD"
        Me.BGColBalAnaOD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGColBalAnaOD.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGColBalAnaOD.Summary1"), resources.GetString("BGColBalAnaOD.Summary2"))})
        resources.ApplyResources(Me.BGColBalAnaOD, "BGColBalAnaOD")
        '
        'BGColBalAnaNAJUSTE
        '
        Me.BGColBalAnaNAJUSTE.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaNAJUSTE.AppearanceCell.Options.UseForeColor = True
        Me.BGColBalAnaNAJUSTE.AppearanceHeader.Font = CType(resources.GetObject("BGColBalAnaNAJUSTE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColBalAnaNAJUSTE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaNAJUSTE.AppearanceHeader.Options.UseFont = True
        Me.BGColBalAnaNAJUSTE.AppearanceHeader.Options.UseForeColor = True
        Me.BGColBalAnaNAJUSTE.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColBalAnaNAJUSTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColBalAnaNAJUSTE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGColBalAnaNAJUSTE, "BGColBalAnaNAJUSTE")
        Me.BGColBalAnaNAJUSTE.DisplayFormat.FormatString = "### ### ### ##0"
        Me.BGColBalAnaNAJUSTE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGColBalAnaNAJUSTE.FieldName = "NAJUSTE"
        Me.BGColBalAnaNAJUSTE.Name = "BGColBalAnaNAJUSTE"
        Me.BGColBalAnaNAJUSTE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGColBalAnaNAJUSTE.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGColBalAnaNAJUSTE.Summary1"), resources.GetString("BGColBalAnaNAJUSTE.Summary2"))})
        '
        'BGColBalAnaTOTREAJUST
        '
        Me.BGColBalAnaTOTREAJUST.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BGColBalAnaTOTREAJUST.AppearanceCell.Font = CType(resources.GetObject("BGColBalAnaTOTREAJUST.AppearanceCell.Font"), System.Drawing.Font)
        Me.BGColBalAnaTOTREAJUST.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaTOTREAJUST.AppearanceCell.Options.UseBackColor = True
        Me.BGColBalAnaTOTREAJUST.AppearanceCell.Options.UseFont = True
        Me.BGColBalAnaTOTREAJUST.AppearanceCell.Options.UseForeColor = True
        Me.BGColBalAnaTOTREAJUST.AppearanceHeader.Font = CType(resources.GetObject("BGColBalAnaTOTREAJUST.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColBalAnaTOTREAJUST.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaTOTREAJUST.AppearanceHeader.Options.UseFont = True
        Me.BGColBalAnaTOTREAJUST.AppearanceHeader.Options.UseForeColor = True
        Me.BGColBalAnaTOTREAJUST.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColBalAnaTOTREAJUST.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColBalAnaTOTREAJUST.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGColBalAnaTOTREAJUST, "BGColBalAnaTOTREAJUST")
        Me.BGColBalAnaTOTREAJUST.DisplayFormat.FormatString = "### ### ### ##0"
        Me.BGColBalAnaTOTREAJUST.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGColBalAnaTOTREAJUST.FieldName = "TOTREAJUST"
        Me.BGColBalAnaTOTREAJUST.Name = "BGColBalAnaTOTREAJUST"
        Me.BGColBalAnaTOTREAJUST.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGColBalAnaTOTREAJUST.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGColBalAnaTOTREAJUST.Summary1"), resources.GetString("BGColBalAnaTOTREAJUST.Summary2"), resources.GetString("BGColBalAnaTOTREAJUST.Summary3"))})
        '
        'BGColAnaNPOURCREAJUST
        '
        Me.BGColAnaNPOURCREAJUST.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.BGColAnaNPOURCREAJUST.AppearanceCell.Options.UseForeColor = True
        Me.BGColAnaNPOURCREAJUST.AppearanceHeader.Font = CType(resources.GetObject("BGColAnaNPOURCREAJUST.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColAnaNPOURCREAJUST.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColAnaNPOURCREAJUST.AppearanceHeader.Options.UseFont = True
        Me.BGColAnaNPOURCREAJUST.AppearanceHeader.Options.UseForeColor = True
        Me.BGColAnaNPOURCREAJUST.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColAnaNPOURCREAJUST.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColAnaNPOURCREAJUST.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGColAnaNPOURCREAJUST, "BGColAnaNPOURCREAJUST")
        Me.BGColAnaNPOURCREAJUST.DisplayFormat.FormatString = "0.0 %"
        Me.BGColAnaNPOURCREAJUST.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.BGColAnaNPOURCREAJUST.FieldName = "NPOURCREAJUST"
        Me.BGColAnaNPOURCREAJUST.Name = "BGColAnaNPOURCREAJUST"
        Me.BGColAnaNPOURCREAJUST.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGColAnaNPOURCREAJUST.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGColAnaNPOURCREAJUST.Summary1"), resources.GetString("BGColAnaNPOURCREAJUST.Summary2"))})
        '
        'GBBALANNEEPREC
        '
        Me.GBBALANNEEPREC.AppearanceHeader.Font = CType(resources.GetObject("GBBALANNEEPREC.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBBALANNEEPREC.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GBBALANNEEPREC.AppearanceHeader.Options.UseFont = True
        Me.GBBALANNEEPREC.AppearanceHeader.Options.UseForeColor = True
        Me.GBBALANNEEPREC.AppearanceHeader.Options.UseTextOptions = True
        Me.GBBALANNEEPREC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBBALANNEEPREC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GBBALANNEEPREC, "GBBALANNEEPREC")
        Me.GBBALANNEEPREC.Columns.Add(Me.BGColBalAnaPOURCANNEE)
        Me.GBBALANNEEPREC.Columns.Add(Me.BGColBalAnaDIFFPOURCANNEE)
        Me.GBBALANNEEPREC.VisibleIndex = 1
        '
        'BGColBalAnaPOURCANNEE
        '
        Me.BGColBalAnaPOURCANNEE.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BGColBalAnaPOURCANNEE.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaPOURCANNEE.AppearanceCell.Options.UseBackColor = True
        Me.BGColBalAnaPOURCANNEE.AppearanceCell.Options.UseForeColor = True
        Me.BGColBalAnaPOURCANNEE.AppearanceHeader.Font = CType(resources.GetObject("BGColBalAnaPOURCANNEE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColBalAnaPOURCANNEE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColBalAnaPOURCANNEE.AppearanceHeader.Options.UseFont = True
        Me.BGColBalAnaPOURCANNEE.AppearanceHeader.Options.UseForeColor = True
        Me.BGColBalAnaPOURCANNEE.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColBalAnaPOURCANNEE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColBalAnaPOURCANNEE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGColBalAnaPOURCANNEE, "BGColBalAnaPOURCANNEE")
        Me.BGColBalAnaPOURCANNEE.DisplayFormat.FormatString = "0.0 %"
        Me.BGColBalAnaPOURCANNEE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.BGColBalAnaPOURCANNEE.FieldName = "POURCANNEE"
        Me.BGColBalAnaPOURCANNEE.Name = "BGColBalAnaPOURCANNEE"
        Me.BGColBalAnaPOURCANNEE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGColBalAnaPOURCANNEE.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGColBalAnaPOURCANNEE.Summary1"), resources.GetString("BGColBalAnaPOURCANNEE.Summary2"))})
        '
        'BGColBalAnaAJUSTE_TX_HOR
        '
        resources.ApplyResources(Me.BGColBalAnaAJUSTE_TX_HOR, "BGColBalAnaAJUSTE_TX_HOR")
        Me.BGColBalAnaAJUSTE_TX_HOR.FieldName = "AJUSTE_TX_HOR"
        Me.BGColBalAnaAJUSTE_TX_HOR.Name = "BGColBalAnaAJUSTE_TX_HOR"
        '
        'BGColBalAnaCCTEANAACTIF
        '
        resources.ApplyResources(Me.BGColBalAnaCCTEANAACTIF, "BGColBalAnaCCTEANAACTIF")
        Me.BGColBalAnaCCTEANAACTIF.FieldName = "CCTEANAACTIF"
        Me.BGColBalAnaCCTEANAACTIF.Name = "BGColBalAnaCCTEANAACTIF"
        '
        'XTPBilanCpt
        '
        Me.XTPBilanCpt.Controls.Add(Me.GCSynthCompta)
        Me.XTPBilanCpt.Name = "XTPBilanCpt"
        resources.ApplyResources(Me.XTPBilanCpt, "XTPBilanCpt")
        Me.XTPBilanCpt.Tag = ""
        '
        'GCSynthCompta
        '
        resources.ApplyResources(Me.GCSynthCompta, "GCSynthCompta")
        Me.GCSynthCompta.MainView = Me.AdvBGVBilanAna
        Me.GCSynthCompta.Name = "GCSynthCompta"
        Me.GCSynthCompta.Tag = "369"
        Me.GCSynthCompta.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBGVBilanAna})
        '
        'AdvBGVBilanAna
        '
        Me.AdvBGVBilanAna.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Black
        Me.AdvBGVBilanAna.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.AdvBGVBilanAna.Appearance.GroupRow.Font = CType(resources.GetObject("AdvBGVBilanAna.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.AdvBGVBilanAna.Appearance.GroupRow.Options.UseFont = True
        Me.AdvBGVBilanAna.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Black
        Me.AdvBGVBilanAna.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.AdvBGVBilanAna.AppearancePrint.BandPanel.Font = CType(resources.GetObject("AdvBGVBilanAna.AppearancePrint.BandPanel.Font"), System.Drawing.Font)
        Me.AdvBGVBilanAna.AppearancePrint.BandPanel.Options.UseFont = True
        Me.AdvBGVBilanAna.AppearancePrint.BandPanel.Options.UseTextOptions = True
        Me.AdvBGVBilanAna.AppearancePrint.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AdvBGVBilanAna.AppearancePrint.BandPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.AdvBGVBilanAna.AppearancePrint.BandPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBGVBilanAna.AppearancePrint.FooterPanel.Font = CType(resources.GetObject("AdvBGVBilanAna.AppearancePrint.FooterPanel.Font"), System.Drawing.Font)
        Me.AdvBGVBilanAna.AppearancePrint.FooterPanel.Options.UseFont = True
        Me.AdvBGVBilanAna.AppearancePrint.HeaderPanel.Font = CType(resources.GetObject("AdvBGVBilanAna.AppearancePrint.HeaderPanel.Font"), System.Drawing.Font)
        Me.AdvBGVBilanAna.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.AdvBGVBilanAna.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.AdvBGVBilanAna.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AdvBGVBilanAna.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.AdvBGVBilanAna.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBGVBilanAna.AppearancePrint.Row.Font = CType(resources.GetObject("AdvBGVBilanAna.AppearancePrint.Row.Font"), System.Drawing.Font)
        Me.AdvBGVBilanAna.AppearancePrint.Row.Options.UseFont = True
        Me.AdvBGVBilanAna.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GBCompte, Me.GBChaff, Me.GBProd, Me.GBResultFG, Me.GBPartFG, Me.GBTxChargeStruct})
        Me.AdvBGVBilanAna.ColumnPanelRowHeight = 40
        Me.AdvBGVBilanAna.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BGCNum, Me.BGCCTYPECTE, Me.BGVNRFAPOURC, Me.BGCLibANA, Me.BGVLIBGROUPE, Me.BGCChaff, Me.BGCMttCA, Me.BGCPourcProd, Me.BGCSectAna, Me.BGCOD, Me.BGCENCOURS, Me.BGCENCOURSMANU, Me.BGCResultAjust, Me.BGCPourcCA, Me.BGCPourcMoisPrec, Me.BGCPourcRapportMoisPrec, Me.BGCPourcAnneePrec, Me.BGCRapportAnneePrec, Me.BGCPourcTotal, Me.BGCPartFGMtt, Me.BGCPourcFG, Me.BGCPourcChargeStruct, Me.BGCCCTEANAACTIF, Me.BGCPVRECEPT, Me.BGCCAMONTHLASTYEAR, Me.BGCRESTDUTOT, Me.BGCTXCONVERSEDCL, Me.BGCAJUSTE_TX_HOR})
        StyleFormatCondition1.Appearance.Font = CType(resources.GetObject("resource.Font2"), System.Drawing.Font)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.BGCPourcRapportMoisPrec
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.Font = CType(resources.GetObject("resource.Font3"), System.Drawing.Font)
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.ForestGreen
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.BGCPourcRapportMoisPrec
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition2.Value1 = "0"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition3.Appearance.Font = CType(resources.GetObject("resource.Font4"), System.Drawing.Font)
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Appearance.Options.UseFont = True
        StyleFormatCondition3.Column = Me.BGCPourcCA
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition3.Value1 = "0"
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition4.Appearance.Font = CType(resources.GetObject("resource.Font5"), System.Drawing.Font)
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.Appearance.Options.UseFont = True
        StyleFormatCondition4.Column = Me.BGCPourcCA
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition4.Value1 = "0"
        StyleFormatCondition5.Appearance.Font = CType(resources.GetObject("resource.Font6"), System.Drawing.Font)
        StyleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition5.Appearance.Options.UseFont = True
        StyleFormatCondition5.Appearance.Options.UseForeColor = True
        StyleFormatCondition5.Column = Me.BGCRapportAnneePrec
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition5.Value1 = "0"
        StyleFormatCondition6.Appearance.Font = CType(resources.GetObject("resource.Font7"), System.Drawing.Font)
        StyleFormatCondition6.Appearance.ForeColor = System.Drawing.Color.ForestGreen
        StyleFormatCondition6.Appearance.Options.UseFont = True
        StyleFormatCondition6.Appearance.Options.UseForeColor = True
        StyleFormatCondition6.Column = Me.BGCRapportAnneePrec
        StyleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition6.Value1 = "0"
        Me.AdvBGVBilanAna.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4, StyleFormatCondition5, StyleFormatCondition6})
        Me.AdvBGVBilanAna.GridControl = Me.GCSynthCompta
        Me.AdvBGVBilanAna.GroupCount = 1
        Me.AdvBGVBilanAna.LevelIndent = 0
        Me.AdvBGVBilanAna.Name = "AdvBGVBilanAna"
        Me.AdvBGVBilanAna.OptionsBehavior.Editable = False
        Me.AdvBGVBilanAna.OptionsBehavior.ReadOnly = True
        Me.AdvBGVBilanAna.OptionsCustomization.AllowBandMoving = False
        Me.AdvBGVBilanAna.OptionsCustomization.AllowBandResizing = False
        Me.AdvBGVBilanAna.OptionsPrint.AutoWidth = False
        Me.AdvBGVBilanAna.OptionsPrint.ExpandAllGroups = False
        Me.AdvBGVBilanAna.OptionsView.ShowFooter = True
        Me.AdvBGVBilanAna.OptionsView.ShowGroupPanel = False
        Me.AdvBGVBilanAna.OptionsView.ShowGroupPanelColumnsAsSingleRow = True
        Me.AdvBGVBilanAna.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.BGCCCTEANAACTIF, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GBCompte
        '
        Me.GBCompte.AppearanceHeader.Font = CType(resources.GetObject("GBCompte.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBCompte.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GBCompte.AppearanceHeader.Options.UseFont = True
        Me.GBCompte.AppearanceHeader.Options.UseForeColor = True
        Me.GBCompte.AppearanceHeader.Options.UseTextOptions = True
        Me.GBCompte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBCompte.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GBCompte, "GBCompte")
        Me.GBCompte.Columns.Add(Me.BGCNum)
        Me.GBCompte.Columns.Add(Me.BGCCTYPECTE)
        Me.GBCompte.Columns.Add(Me.BGVNRFAPOURC)
        Me.GBCompte.Columns.Add(Me.BGCCCTEANAACTIF)
        Me.GBCompte.Columns.Add(Me.BGCLibANA)
        Me.GBCompte.VisibleIndex = 0
        '
        'BGCNum
        '
        Me.BGCNum.AppearanceCell.Options.UseTextOptions = True
        Me.BGCNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCNum.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCNum.AppearanceHeader.Font = CType(resources.GetObject("BGCNum.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCNum.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCNum.AppearanceHeader.Options.UseFont = True
        Me.BGCNum.AppearanceHeader.Options.UseForeColor = True
        Me.BGCNum.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCNum.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCNum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCNum, "BGCNum")
        Me.BGCNum.FieldName = "NCANNUM"
        Me.BGCNum.Name = "BGCNum"
        '
        'BGCCTYPECTE
        '
        Me.BGCCTYPECTE.AppearanceCell.Options.UseTextOptions = True
        Me.BGCCTYPECTE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCCTYPECTE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCCTYPECTE.AppearanceHeader.Font = CType(resources.GetObject("BGCCTYPECTE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCCTYPECTE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCCTYPECTE.AppearanceHeader.Options.UseFont = True
        Me.BGCCTYPECTE.AppearanceHeader.Options.UseForeColor = True
        Me.BGCCTYPECTE.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCCTYPECTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCCTYPECTE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BGCCTYPECTE, "BGCCTYPECTE")
        Me.BGCCTYPECTE.FieldName = "CTYPECTE"
        Me.BGCCTYPECTE.Name = "BGCCTYPECTE"
        '
        'BGVNRFAPOURC
        '
        Me.BGVNRFAPOURC.AppearanceCell.Options.UseTextOptions = True
        Me.BGVNRFAPOURC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.BGVNRFAPOURC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGVNRFAPOURC.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BGVNRFAPOURC.AppearanceHeader.Font = CType(resources.GetObject("BGVNRFAPOURC.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGVNRFAPOURC.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGVNRFAPOURC.AppearanceHeader.Options.UseFont = True
        Me.BGVNRFAPOURC.AppearanceHeader.Options.UseForeColor = True
        Me.BGVNRFAPOURC.AppearanceHeader.Options.UseTextOptions = True
        Me.BGVNRFAPOURC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGVNRFAPOURC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGVNRFAPOURC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGVNRFAPOURC, "BGVNRFAPOURC")
        Me.BGVNRFAPOURC.DisplayFormat.FormatString = "p2"
        Me.BGVNRFAPOURC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGVNRFAPOURC.FieldName = "NRFAPOURC"
        Me.BGVNRFAPOURC.Name = "BGVNRFAPOURC"
        '
        'BGCCCTEANAACTIF
        '
        resources.ApplyResources(Me.BGCCCTEANAACTIF, "BGCCCTEANAACTIF")
        Me.BGCCCTEANAACTIF.FieldName = "CCTEANAACTIF"
        Me.BGCCCTEANAACTIF.Name = "BGCCCTEANAACTIF"
        '
        'BGCLibANA
        '
        Me.BGCLibANA.AppearanceCell.Options.UseTextOptions = True
        Me.BGCLibANA.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCLibANA.AppearanceHeader.Font = CType(resources.GetObject("BGCLibANA.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCLibANA.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCLibANA.AppearanceHeader.Options.UseFont = True
        Me.BGCLibANA.AppearanceHeader.Options.UseForeColor = True
        Me.BGCLibANA.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCLibANA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCLibANA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCLibANA.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCLibANA, "BGCLibANA")
        Me.BGCLibANA.FieldName = "VCANLIB"
        Me.BGCLibANA.Name = "BGCLibANA"
        '
        'GBChaff
        '
        Me.GBChaff.AppearanceHeader.Font = CType(resources.GetObject("GBChaff.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBChaff.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GBChaff.AppearanceHeader.Options.UseFont = True
        Me.GBChaff.AppearanceHeader.Options.UseForeColor = True
        Me.GBChaff.AppearanceHeader.Options.UseTextOptions = True
        Me.GBChaff.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBChaff.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GBChaff, "GBChaff")
        Me.GBChaff.Columns.Add(Me.BGVLIBGROUPE)
        Me.GBChaff.Columns.Add(Me.BGCChaff)
        Me.GBChaff.VisibleIndex = 1
        '
        'BGVLIBGROUPE
        '
        Me.BGVLIBGROUPE.AppearanceCell.Options.UseTextOptions = True
        Me.BGVLIBGROUPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGVLIBGROUPE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGVLIBGROUPE.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BGVLIBGROUPE.AppearanceHeader.Font = CType(resources.GetObject("BGVLIBGROUPE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGVLIBGROUPE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGVLIBGROUPE.AppearanceHeader.Options.UseFont = True
        Me.BGVLIBGROUPE.AppearanceHeader.Options.UseForeColor = True
        Me.BGVLIBGROUPE.AppearanceHeader.Options.UseTextOptions = True
        Me.BGVLIBGROUPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGVLIBGROUPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGVLIBGROUPE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGVLIBGROUPE, "BGVLIBGROUPE")
        Me.BGVLIBGROUPE.FieldName = "VLIBGROUPE"
        Me.BGVLIBGROUPE.Name = "BGVLIBGROUPE"
        '
        'BGCChaff
        '
        Me.BGCChaff.AppearanceCell.Options.UseTextOptions = True
        Me.BGCChaff.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCChaff.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCChaff.AppearanceHeader.Font = CType(resources.GetObject("BGCChaff.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCChaff.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCChaff.AppearanceHeader.Options.UseFont = True
        Me.BGCChaff.AppearanceHeader.Options.UseForeColor = True
        Me.BGCChaff.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCChaff.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCChaff.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCChaff.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCChaff, "BGCChaff")
        Me.BGCChaff.FieldName = "VCHAFF"
        Me.BGCChaff.Name = "BGCChaff"
        '
        'GBProd
        '
        Me.GBProd.AppearanceHeader.Font = CType(resources.GetObject("GBProd.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBProd.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GBProd.AppearanceHeader.Options.UseFont = True
        Me.GBProd.AppearanceHeader.Options.UseForeColor = True
        Me.GBProd.AppearanceHeader.Options.UseTextOptions = True
        Me.GBProd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBProd.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GBProd, "GBProd")
        Me.GBProd.Columns.Add(Me.BGCMttCA)
        Me.GBProd.Columns.Add(Me.BGCCAMONTHLASTYEAR)
        Me.GBProd.Columns.Add(Me.BGCPourcProd)
        Me.GBProd.VisibleIndex = 2
        '
        'BGCMttCA
        '
        Me.BGCMttCA.AppearanceHeader.Font = CType(resources.GetObject("BGCMttCA.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCMttCA.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCMttCA.AppearanceHeader.Options.UseFont = True
        Me.BGCMttCA.AppearanceHeader.Options.UseForeColor = True
        Me.BGCMttCA.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCMttCA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCMttCA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCMttCA.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        resources.ApplyResources(Me.BGCMttCA, "BGCMttCA")
        Me.BGCMttCA.DisplayFormat.FormatString = "### ### ### ##0"
        Me.BGCMttCA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGCMttCA.FieldName = "NCASYNCOMPTA"
        Me.BGCMttCA.Name = "BGCMttCA"
        Me.BGCMttCA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGCMttCA.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGCMttCA.Summary1"), resources.GetString("BGCMttCA.Summary2"), resources.GetString("BGCMttCA.Summary3"))})
        '
        'BGCCAMONTHLASTYEAR
        '
        Me.BGCCAMONTHLASTYEAR.AppearanceHeader.Font = CType(resources.GetObject("BGCCAMONTHLASTYEAR.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCCAMONTHLASTYEAR.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCCAMONTHLASTYEAR.AppearanceHeader.Options.UseFont = True
        Me.BGCCAMONTHLASTYEAR.AppearanceHeader.Options.UseForeColor = True
        Me.BGCCAMONTHLASTYEAR.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCCAMONTHLASTYEAR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCCAMONTHLASTYEAR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCCAMONTHLASTYEAR.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCCAMONTHLASTYEAR, "BGCCAMONTHLASTYEAR")
        Me.BGCCAMONTHLASTYEAR.DisplayFormat.FormatString = "### ### ### ##0"
        Me.BGCCAMONTHLASTYEAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGCCAMONTHLASTYEAR.FieldName = "CAMONTHLASTYEAR"
        Me.BGCCAMONTHLASTYEAR.Name = "BGCCAMONTHLASTYEAR"
        '
        'BGCPourcProd
        '
        Me.BGCPourcProd.AppearanceHeader.Font = CType(resources.GetObject("BGCPourcProd.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCPourcProd.AppearanceHeader.Options.UseFont = True
        Me.BGCPourcProd.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCPourcProd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCPourcProd.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCPourcProd.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCPourcProd, "BGCPourcProd")
        Me.BGCPourcProd.DisplayFormat.FormatString = "0 %"
        Me.BGCPourcProd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.BGCPourcProd.FieldName = "NPOURCTOTCA"
        Me.BGCPourcProd.Name = "BGCPourcProd"
        Me.BGCPourcProd.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGCPourcProd.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGCPourcProd.Summary1"), resources.GetString("BGCPourcProd.Summary2"))})
        '
        'GBResultFG
        '
        Me.GBResultFG.AppearanceHeader.Font = CType(resources.GetObject("GBResultFG.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBResultFG.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GBResultFG.AppearanceHeader.Options.UseFont = True
        Me.GBResultFG.AppearanceHeader.Options.UseForeColor = True
        Me.GBResultFG.AppearanceHeader.Options.UseTextOptions = True
        Me.GBResultFG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBResultFG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GBResultFG, "GBResultFG")
        Me.GBResultFG.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GBBILANREAJUSTE, Me.GBMOISPREC, Me.GBANNEEPREC, Me.GBBILANRESULT})
        Me.GBResultFG.VisibleIndex = 3
        '
        'GBBILANREAJUSTE
        '
        Me.GBBILANREAJUSTE.AppearanceHeader.Font = CType(resources.GetObject("GBBILANREAJUSTE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBBILANREAJUSTE.AppearanceHeader.Options.UseFont = True
        Me.GBBILANREAJUSTE.AppearanceHeader.Options.UseTextOptions = True
        Me.GBBILANREAJUSTE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GBBILANREAJUSTE.Columns.Add(Me.BGCSectAna)
        Me.GBBILANREAJUSTE.Columns.Add(Me.BGCOD)
        Me.GBBILANREAJUSTE.Columns.Add(Me.BGCENCOURS)
        Me.GBBILANREAJUSTE.Columns.Add(Me.BGCENCOURSMANU)
        Me.GBBILANREAJUSTE.Columns.Add(Me.BGCResultAjust)
        Me.GBBILANREAJUSTE.Columns.Add(Me.BGCPourcCA)
        resources.ApplyResources(Me.GBBILANREAJUSTE, "GBBILANREAJUSTE")
        Me.GBBILANREAJUSTE.VisibleIndex = 0
        '
        'BGCSectAna
        '
        Me.BGCSectAna.AppearanceHeader.Font = CType(resources.GetObject("BGCSectAna.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCSectAna.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCSectAna.AppearanceHeader.Options.UseFont = True
        Me.BGCSectAna.AppearanceHeader.Options.UseForeColor = True
        Me.BGCSectAna.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCSectAna.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCSectAna.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCSectAna.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCSectAna, "BGCSectAna")
        Me.BGCSectAna.DisplayFormat.FormatString = "### ### ### ##0"
        Me.BGCSectAna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGCSectAna.FieldName = "NSECANASYNCOMPTA"
        Me.BGCSectAna.Name = "BGCSectAna"
        Me.BGCSectAna.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGCSectAna.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGCSectAna.Summary1"), resources.GetString("BGCSectAna.Summary2"))})
        '
        'BGCOD
        '
        Me.BGCOD.AppearanceCell.Font = CType(resources.GetObject("BGCOD.AppearanceCell.Font"), System.Drawing.Font)
        Me.BGCOD.AppearanceCell.Options.UseFont = True
        Me.BGCOD.AppearanceHeader.Font = CType(resources.GetObject("BGCOD.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCOD.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCOD.AppearanceHeader.Options.UseFont = True
        Me.BGCOD.AppearanceHeader.Options.UseForeColor = True
        Me.BGCOD.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCOD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCOD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCOD.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCOD, "BGCOD")
        Me.BGCOD.DisplayFormat.FormatString = "### ### ### ##0"
        Me.BGCOD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGCOD.FieldName = "NOD"
        Me.BGCOD.Name = "BGCOD"
        Me.BGCOD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGCOD.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGCOD.Summary1"), resources.GetString("BGCOD.Summary2"))})
        '
        'BGCENCOURS
        '
        Me.BGCENCOURS.AppearanceCell.Font = CType(resources.GetObject("BGCENCOURS.AppearanceCell.Font"), System.Drawing.Font)
        Me.BGCENCOURS.AppearanceCell.Options.UseFont = True
        Me.BGCENCOURS.AppearanceHeader.Font = CType(resources.GetObject("BGCENCOURS.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCENCOURS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCENCOURS.AppearanceHeader.Options.UseFont = True
        Me.BGCENCOURS.AppearanceHeader.Options.UseForeColor = True
        Me.BGCENCOURS.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCENCOURS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCENCOURS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCENCOURS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCENCOURS, "BGCENCOURS")
        Me.BGCENCOURS.DisplayFormat.FormatString = "### ### ### ##0"
        Me.BGCENCOURS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGCENCOURS.FieldName = "NAJUSYNCOMPTA"
        Me.BGCENCOURS.Name = "BGCENCOURS"
        Me.BGCENCOURS.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGCENCOURS.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGCENCOURS.Summary1"), resources.GetString("BGCENCOURS.Summary2"))})
        '
        'BGCENCOURSMANU
        '
        Me.BGCENCOURSMANU.AppearanceCell.Font = CType(resources.GetObject("BGCENCOURSMANU.AppearanceCell.Font"), System.Drawing.Font)
        Me.BGCENCOURSMANU.AppearanceCell.Options.UseFont = True
        Me.BGCENCOURSMANU.AppearanceHeader.Font = CType(resources.GetObject("BGCENCOURSMANU.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCENCOURSMANU.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCENCOURSMANU.AppearanceHeader.Options.UseFont = True
        Me.BGCENCOURSMANU.AppearanceHeader.Options.UseForeColor = True
        Me.BGCENCOURSMANU.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCENCOURSMANU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCENCOURSMANU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCENCOURSMANU.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCENCOURSMANU, "BGCENCOURSMANU")
        Me.BGCENCOURSMANU.DisplayFormat.FormatString = "### ### ### ##0"
        Me.BGCENCOURSMANU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGCENCOURSMANU.FieldName = "ENCOURSMANU"
        Me.BGCENCOURSMANU.Name = "BGCENCOURSMANU"
        Me.BGCENCOURSMANU.OptionsColumn.AllowEdit = False
        Me.BGCENCOURSMANU.OptionsColumn.ReadOnly = True
        Me.BGCENCOURSMANU.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGCENCOURSMANU.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGCENCOURSMANU.Summary1"), resources.GetString("BGCENCOURSMANU.Summary2"))})
        '
        'BGCResultAjust
        '
        Me.BGCResultAjust.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BGCResultAjust.AppearanceCell.Font = CType(resources.GetObject("BGCResultAjust.AppearanceCell.Font"), System.Drawing.Font)
        Me.BGCResultAjust.AppearanceCell.Options.UseBackColor = True
        Me.BGCResultAjust.AppearanceCell.Options.UseFont = True
        Me.BGCResultAjust.AppearanceHeader.Font = CType(resources.GetObject("BGCResultAjust.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCResultAjust.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCResultAjust.AppearanceHeader.Options.UseFont = True
        Me.BGCResultAjust.AppearanceHeader.Options.UseForeColor = True
        Me.BGCResultAjust.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCResultAjust.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCResultAjust.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCResultAjust.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCResultAjust, "BGCResultAjust")
        Me.BGCResultAjust.DisplayFormat.FormatString = "### ### ### ##0"
        Me.BGCResultAjust.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGCResultAjust.FieldName = "RESULTAJUST"
        Me.BGCResultAjust.Name = "BGCResultAjust"
        Me.BGCResultAjust.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGCResultAjust.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGCResultAjust.Summary1"), resources.GetString("BGCResultAjust.Summary2"), resources.GetString("BGCResultAjust.Summary3"))})
        '
        'GBMOISPREC
        '
        Me.GBMOISPREC.AppearanceHeader.Font = CType(resources.GetObject("GBMOISPREC.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBMOISPREC.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GBMOISPREC.AppearanceHeader.Options.UseFont = True
        Me.GBMOISPREC.AppearanceHeader.Options.UseForeColor = True
        Me.GBMOISPREC.AppearanceHeader.Options.UseTextOptions = True
        Me.GBMOISPREC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBMOISPREC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GBMOISPREC, "GBMOISPREC")
        Me.GBMOISPREC.Columns.Add(Me.BGCPourcMoisPrec)
        Me.GBMOISPREC.Columns.Add(Me.BGCPourcRapportMoisPrec)
        Me.GBMOISPREC.VisibleIndex = 1
        '
        'BGCPourcMoisPrec
        '
        Me.BGCPourcMoisPrec.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BGCPourcMoisPrec.AppearanceCell.ForeColor = System.Drawing.Color.Blue
        Me.BGCPourcMoisPrec.AppearanceCell.Options.UseBackColor = True
        Me.BGCPourcMoisPrec.AppearanceCell.Options.UseForeColor = True
        Me.BGCPourcMoisPrec.AppearanceHeader.Font = CType(resources.GetObject("BGCPourcMoisPrec.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCPourcMoisPrec.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCPourcMoisPrec.AppearanceHeader.Options.UseFont = True
        Me.BGCPourcMoisPrec.AppearanceHeader.Options.UseForeColor = True
        Me.BGCPourcMoisPrec.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCPourcMoisPrec.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCPourcMoisPrec.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCPourcMoisPrec.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCPourcMoisPrec, "BGCPourcMoisPrec")
        Me.BGCPourcMoisPrec.DisplayFormat.FormatString = "p1"
        Me.BGCPourcMoisPrec.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGCPourcMoisPrec.FieldName = "POURCMOIS"
        Me.BGCPourcMoisPrec.Name = "BGCPourcMoisPrec"
        '
        'GBANNEEPREC
        '
        Me.GBANNEEPREC.AppearanceHeader.Font = CType(resources.GetObject("GBANNEEPREC.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBANNEEPREC.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GBANNEEPREC.AppearanceHeader.Options.UseFont = True
        Me.GBANNEEPREC.AppearanceHeader.Options.UseForeColor = True
        Me.GBANNEEPREC.AppearanceHeader.Options.UseTextOptions = True
        Me.GBANNEEPREC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBANNEEPREC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GBANNEEPREC, "GBANNEEPREC")
        Me.GBANNEEPREC.Columns.Add(Me.BGCPourcAnneePrec)
        Me.GBANNEEPREC.Columns.Add(Me.BGCRapportAnneePrec)
        Me.GBANNEEPREC.VisibleIndex = 2
        '
        'BGCPourcAnneePrec
        '
        Me.BGCPourcAnneePrec.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BGCPourcAnneePrec.AppearanceCell.ForeColor = System.Drawing.Color.Blue
        Me.BGCPourcAnneePrec.AppearanceCell.Options.UseBackColor = True
        Me.BGCPourcAnneePrec.AppearanceCell.Options.UseForeColor = True
        Me.BGCPourcAnneePrec.AppearanceHeader.Font = CType(resources.GetObject("BGCPourcAnneePrec.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCPourcAnneePrec.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCPourcAnneePrec.AppearanceHeader.Options.UseFont = True
        Me.BGCPourcAnneePrec.AppearanceHeader.Options.UseForeColor = True
        Me.BGCPourcAnneePrec.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCPourcAnneePrec.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCPourcAnneePrec.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCPourcAnneePrec.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCPourcAnneePrec, "BGCPourcAnneePrec")
        Me.BGCPourcAnneePrec.DisplayFormat.FormatString = "0.0 %"
        Me.BGCPourcAnneePrec.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.BGCPourcAnneePrec.FieldName = "POURCAN"
        Me.BGCPourcAnneePrec.Name = "BGCPourcAnneePrec"
        '
        'GBBILANRESULT
        '
        Me.GBBILANRESULT.AppearanceHeader.Font = CType(resources.GetObject("GBBILANRESULT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBBILANRESULT.AppearanceHeader.Options.UseFont = True
        Me.GBBILANRESULT.AppearanceHeader.Options.UseTextOptions = True
        Me.GBBILANRESULT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GBBILANRESULT.Columns.Add(Me.BGCPourcTotal)
        resources.ApplyResources(Me.GBBILANRESULT, "GBBILANRESULT")
        Me.GBBILANRESULT.VisibleIndex = 3
        '
        'BGCPourcTotal
        '
        Me.BGCPourcTotal.AppearanceHeader.Font = CType(resources.GetObject("BGCPourcTotal.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCPourcTotal.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCPourcTotal.AppearanceHeader.Options.UseFont = True
        Me.BGCPourcTotal.AppearanceHeader.Options.UseForeColor = True
        Me.BGCPourcTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCPourcTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCPourcTotal.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCPourcTotal.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCPourcTotal, "BGCPourcTotal")
        Me.BGCPourcTotal.DisplayFormat.FormatString = "0 %"
        Me.BGCPourcTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.BGCPourcTotal.FieldName = "NPOURCTOTAJUST"
        Me.BGCPourcTotal.Name = "BGCPourcTotal"
        Me.BGCPourcTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGCPourcTotal.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGCPourcTotal.Summary1"), resources.GetString("BGCPourcTotal.Summary2"))})
        '
        'GBPartFG
        '
        Me.GBPartFG.AppearanceHeader.Font = CType(resources.GetObject("GBPartFG.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBPartFG.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GBPartFG.AppearanceHeader.Options.UseFont = True
        Me.GBPartFG.AppearanceHeader.Options.UseForeColor = True
        Me.GBPartFG.AppearanceHeader.Options.UseTextOptions = True
        Me.GBPartFG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBPartFG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GBPartFG, "GBPartFG")
        Me.GBPartFG.Columns.Add(Me.BGCPartFGMtt)
        Me.GBPartFG.Columns.Add(Me.BGCPourcFG)
        Me.GBPartFG.VisibleIndex = 4
        '
        'BGCPartFGMtt
        '
        Me.BGCPartFGMtt.AppearanceHeader.Font = CType(resources.GetObject("BGCPartFGMtt.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCPartFGMtt.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCPartFGMtt.AppearanceHeader.Options.UseFont = True
        Me.BGCPartFGMtt.AppearanceHeader.Options.UseForeColor = True
        Me.BGCPartFGMtt.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCPartFGMtt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCPartFGMtt.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCPartFGMtt.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCPartFGMtt, "BGCPartFGMtt")
        Me.BGCPartFGMtt.DisplayFormat.FormatString = "### ### ### ##0"
        Me.BGCPartFGMtt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGCPartFGMtt.FieldName = "NMNTTFG"
        Me.BGCPartFGMtt.Name = "BGCPartFGMtt"
        Me.BGCPartFGMtt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGCPartFGMtt.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGCPartFGMtt.Summary1"), resources.GetString("BGCPartFGMtt.Summary2"))})
        '
        'BGCPourcFG
        '
        Me.BGCPourcFG.AppearanceHeader.Font = CType(resources.GetObject("BGCPourcFG.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCPourcFG.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCPourcFG.AppearanceHeader.Options.UseFont = True
        Me.BGCPourcFG.AppearanceHeader.Options.UseForeColor = True
        Me.BGCPourcFG.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCPourcFG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCPourcFG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCPourcFG.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCPourcFG, "BGCPourcFG")
        Me.BGCPourcFG.DisplayFormat.FormatString = "0 %"
        Me.BGCPourcFG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.BGCPourcFG.FieldName = "NPOURCFG"
        Me.BGCPourcFG.Name = "BGCPourcFG"
        Me.BGCPourcFG.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGCPourcFG.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGCPourcFG.Summary1"), resources.GetString("BGCPourcFG.Summary2"))})
        '
        'GBTxChargeStruct
        '
        Me.GBTxChargeStruct.Columns.Add(Me.BGCPourcChargeStruct)
        Me.GBTxChargeStruct.Columns.Add(Me.BGCPVRECEPT)
        Me.GBTxChargeStruct.Columns.Add(Me.BGCRESTDUTOT)
        Me.GBTxChargeStruct.Columns.Add(Me.BGCTXCONVERSEDCL)
        Me.GBTxChargeStruct.Columns.Add(Me.BGCAJUSTE_TX_HOR)
        resources.ApplyResources(Me.GBTxChargeStruct, "GBTxChargeStruct")
        Me.GBTxChargeStruct.VisibleIndex = 5
        '
        'BGCPourcChargeStruct
        '
        Me.BGCPourcChargeStruct.AppearanceHeader.Font = CType(resources.GetObject("BGCPourcChargeStruct.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCPourcChargeStruct.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCPourcChargeStruct.AppearanceHeader.Options.UseFont = True
        Me.BGCPourcChargeStruct.AppearanceHeader.Options.UseForeColor = True
        Me.BGCPourcChargeStruct.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCPourcChargeStruct.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCPourcChargeStruct.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCPourcChargeStruct.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCPourcChargeStruct, "BGCPourcChargeStruct")
        Me.BGCPourcChargeStruct.DisplayFormat.FormatString = "p0"
        Me.BGCPourcChargeStruct.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGCPourcChargeStruct.FieldName = "NPOURCHRSTRUCT"
        Me.BGCPourcChargeStruct.Name = "BGCPourcChargeStruct"
        Me.BGCPourcChargeStruct.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("BGCPourcChargeStruct.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("BGCPourcChargeStruct.Summary1"), resources.GetString("BGCPourcChargeStruct.Summary2"), resources.GetString("BGCPourcChargeStruct.Summary3"))})
        '
        'BGCPVRECEPT
        '
        Me.BGCPVRECEPT.AppearanceCell.Options.UseTextOptions = True
        Me.BGCPVRECEPT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCPVRECEPT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCPVRECEPT.AppearanceHeader.Font = CType(resources.GetObject("BGCPVRECEPT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCPVRECEPT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCPVRECEPT.AppearanceHeader.Options.UseFont = True
        Me.BGCPVRECEPT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.BGCPVRECEPT, "BGCPVRECEPT")
        Me.BGCPVRECEPT.FieldName = "DPVRECEPT"
        Me.BGCPVRECEPT.Name = "BGCPVRECEPT"
        '
        'BGCRESTDUTOT
        '
        Me.BGCRESTDUTOT.AppearanceHeader.Font = CType(resources.GetObject("BGCRESTDUTOT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCRESTDUTOT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCRESTDUTOT.AppearanceHeader.Options.UseFont = True
        Me.BGCRESTDUTOT.AppearanceHeader.Options.UseForeColor = True
        Me.BGCRESTDUTOT.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCRESTDUTOT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCRESTDUTOT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCRESTDUTOT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCRESTDUTOT, "BGCRESTDUTOT")
        Me.BGCRESTDUTOT.DisplayFormat.FormatString = "### ### ### ##0"
        Me.BGCRESTDUTOT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGCRESTDUTOT.FieldName = "RESTDUTOT"
        Me.BGCRESTDUTOT.Name = "BGCRESTDUTOT"
        '
        'BGCTXCONVERSEDCL
        '
        Me.BGCTXCONVERSEDCL.AppearanceHeader.Font = CType(resources.GetObject("BGCTXCONVERSEDCL.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCTXCONVERSEDCL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGCTXCONVERSEDCL.AppearanceHeader.Options.UseFont = True
        Me.BGCTXCONVERSEDCL.AppearanceHeader.Options.UseForeColor = True
        Me.BGCTXCONVERSEDCL.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCTXCONVERSEDCL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCTXCONVERSEDCL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCTXCONVERSEDCL.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCTXCONVERSEDCL, "BGCTXCONVERSEDCL")
        Me.BGCTXCONVERSEDCL.DisplayFormat.FormatString = "{0:p0}"
        Me.BGCTXCONVERSEDCL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGCTXCONVERSEDCL.FieldName = "TXCONVERSEDCL"
        Me.BGCTXCONVERSEDCL.Name = "BGCTXCONVERSEDCL"
        '
        'BGCAJUSTE_TX_HOR
        '
        resources.ApplyResources(Me.BGCAJUSTE_TX_HOR, "BGCAJUSTE_TX_HOR")
        Me.BGCAJUSTE_TX_HOR.FieldName = "AJUSTE_TX_HOR"
        Me.BGCAJUSTE_TX_HOR.Name = "BGCAJUSTE_TX_HOR"
        '
        'XTBCSynthCompta
        '
        resources.ApplyResources(Me.XTBCSynthCompta, "XTBCSynthCompta")
        Me.XTBCSynthCompta.AppearancePage.Header.Font = CType(resources.GetObject("XTBCSynthCompta.AppearancePage.Header.Font"), System.Drawing.Font)
        Me.XTBCSynthCompta.AppearancePage.Header.Options.UseFont = True
        Me.XTBCSynthCompta.Name = "XTBCSynthCompta"
        Me.XTBCSynthCompta.SelectedTabPage = Me.XTPBilanCpt
        Me.XTBCSynthCompta.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPBilanCpt, Me.XTPBalanceAna, Me.XTPREX})
        Me.XTBCSynthCompta.Tag = ""
        '
        'XTPREX
        '
        Me.XTPREX.Controls.Add(Me.GCAnaREX)
        Me.XTPREX.Name = "XTPREX"
        resources.ApplyResources(Me.XTPREX, "XTPREX")
        Me.XTPREX.Tag = "371"
        '
        'GCAnaREX
        '
        resources.ApplyResources(Me.GCAnaREX, "GCAnaREX")
        Me.GCAnaREX.MainView = Me.AdvBandedGVAnaREX
        Me.GCAnaREX.Name = "GCAnaREX"
        Me.GCAnaREX.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBandedGVAnaREX})
        '
        'AdvBandedGVAnaREX
        '
        Me.AdvBandedGVAnaREX.AppearancePrint.BandPanel.Font = CType(resources.GetObject("AdvBandedGVAnaREX.AppearancePrint.BandPanel.Font"), System.Drawing.Font)
        Me.AdvBandedGVAnaREX.AppearancePrint.BandPanel.Options.UseFont = True
        Me.AdvBandedGVAnaREX.AppearancePrint.BandPanel.Options.UseTextOptions = True
        Me.AdvBandedGVAnaREX.AppearancePrint.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AdvBandedGVAnaREX.AppearancePrint.BandPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.AdvBandedGVAnaREX.AppearancePrint.BandPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBandedGVAnaREX.AppearancePrint.FooterPanel.Font = CType(resources.GetObject("AdvBandedGVAnaREX.AppearancePrint.FooterPanel.Font"), System.Drawing.Font)
        Me.AdvBandedGVAnaREX.AppearancePrint.FooterPanel.Options.UseFont = True
        Me.AdvBandedGVAnaREX.AppearancePrint.HeaderPanel.Font = CType(resources.GetObject("AdvBandedGVAnaREX.AppearancePrint.HeaderPanel.Font"), System.Drawing.Font)
        Me.AdvBandedGVAnaREX.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.AdvBandedGVAnaREX.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.AdvBandedGVAnaREX.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AdvBandedGVAnaREX.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.AdvBandedGVAnaREX.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AdvBandedGVAnaREX.AppearancePrint.Row.Font = CType(resources.GetObject("AdvBandedGVAnaREX.AppearancePrint.Row.Font"), System.Drawing.Font)
        Me.AdvBandedGVAnaREX.AppearancePrint.Row.Options.UseFont = True
        Me.AdvBandedGVAnaREX.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GBREX, Me.GBREXMOIS, Me.GBREXAN})
        Me.AdvBandedGVAnaREX.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BGColNID, Me.BGColVINTITULE, Me.BGColNRESULT, Me.BGColNPOURCCA, Me.BGColNPOURCCALASTMOIS, Me.BGColNDIFFPOURCCALASTMOIS, Me.BGColNPOURCCALASTYEAR, Me.BGColNDIFFPOURCCALASTYEAR})
        StyleFormatCondition7.Appearance.Font = CType(resources.GetObject("resource.Font8"), System.Drawing.Font)
        StyleFormatCondition7.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition7.Appearance.Options.UseFont = True
        StyleFormatCondition7.Appearance.Options.UseForeColor = True
        StyleFormatCondition7.Column = Me.BGColNDIFFPOURCCALASTMOIS
        StyleFormatCondition7.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual
        StyleFormatCondition7.Value1 = "0"
        StyleFormatCondition8.Appearance.Font = CType(resources.GetObject("resource.Font9"), System.Drawing.Font)
        StyleFormatCondition8.Appearance.ForeColor = System.Drawing.Color.Lime
        StyleFormatCondition8.Appearance.Options.UseFont = True
        StyleFormatCondition8.Appearance.Options.UseForeColor = True
        StyleFormatCondition8.Column = Me.BGColNDIFFPOURCCALASTMOIS
        StyleFormatCondition8.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition8.Value1 = "0"
        StyleFormatCondition9.Appearance.Font = CType(resources.GetObject("resource.Font10"), System.Drawing.Font)
        StyleFormatCondition9.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition9.Appearance.Options.UseFont = True
        StyleFormatCondition9.Appearance.Options.UseForeColor = True
        StyleFormatCondition9.Column = Me.BGColNDIFFPOURCCALASTYEAR
        StyleFormatCondition9.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual
        StyleFormatCondition9.Value1 = "0"
        StyleFormatCondition10.Appearance.Font = CType(resources.GetObject("resource.Font11"), System.Drawing.Font)
        StyleFormatCondition10.Appearance.ForeColor = System.Drawing.Color.Lime
        StyleFormatCondition10.Appearance.Options.UseFont = True
        StyleFormatCondition10.Appearance.Options.UseForeColor = True
        StyleFormatCondition10.Column = Me.BGColNDIFFPOURCCALASTYEAR
        StyleFormatCondition10.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition10.Value1 = "0"
        Me.AdvBandedGVAnaREX.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition7, StyleFormatCondition8, StyleFormatCondition9, StyleFormatCondition10})
        Me.AdvBandedGVAnaREX.GridControl = Me.GCAnaREX
        Me.AdvBandedGVAnaREX.Name = "AdvBandedGVAnaREX"
        Me.AdvBandedGVAnaREX.OptionsBehavior.Editable = False
        Me.AdvBandedGVAnaREX.OptionsBehavior.ReadOnly = True
        Me.AdvBandedGVAnaREX.OptionsPrint.ExpandAllGroups = False
        Me.AdvBandedGVAnaREX.OptionsView.ShowGroupPanel = False
        '
        'GBREX
        '
        Me.GBREX.Columns.Add(Me.BGColNID)
        Me.GBREX.Columns.Add(Me.BGColVINTITULE)
        Me.GBREX.Columns.Add(Me.BGColNRESULT)
        Me.GBREX.Columns.Add(Me.BGColNPOURCCA)
        resources.ApplyResources(Me.GBREX, "GBREX")
        Me.GBREX.VisibleIndex = 0
        '
        'BGColNID
        '
        resources.ApplyResources(Me.BGColNID, "BGColNID")
        Me.BGColNID.FieldName = "NID"
        Me.BGColNID.Name = "BGColNID"
        '
        'BGColVINTITULE
        '
        Me.BGColVINTITULE.AppearanceHeader.Font = CType(resources.GetObject("BGColVINTITULE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColVINTITULE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColVINTITULE.AppearanceHeader.Options.UseFont = True
        Me.BGColVINTITULE.AppearanceHeader.Options.UseForeColor = True
        Me.BGColVINTITULE.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColVINTITULE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColVINTITULE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColVINTITULE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGColVINTITULE, "BGColVINTITULE")
        Me.BGColVINTITULE.FieldName = "VINTITULE"
        Me.BGColVINTITULE.Name = "BGColVINTITULE"
        '
        'BGColNRESULT
        '
        Me.BGColNRESULT.AppearanceHeader.Font = CType(resources.GetObject("BGColNRESULT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColNRESULT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColNRESULT.AppearanceHeader.Options.UseFont = True
        Me.BGColNRESULT.AppearanceHeader.Options.UseForeColor = True
        Me.BGColNRESULT.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColNRESULT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColNRESULT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColNRESULT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGColNRESULT, "BGColNRESULT")
        Me.BGColNRESULT.DisplayFormat.FormatString = "c0"
        Me.BGColNRESULT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGColNRESULT.FieldName = "NRESULT"
        Me.BGColNRESULT.Name = "BGColNRESULT"
        '
        'BGColNPOURCCA
        '
        Me.BGColNPOURCCA.AppearanceHeader.Font = CType(resources.GetObject("BGColNPOURCCA.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColNPOURCCA.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColNPOURCCA.AppearanceHeader.Options.UseFont = True
        Me.BGColNPOURCCA.AppearanceHeader.Options.UseForeColor = True
        Me.BGColNPOURCCA.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColNPOURCCA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColNPOURCCA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColNPOURCCA.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGColNPOURCCA, "BGColNPOURCCA")
        Me.BGColNPOURCCA.DisplayFormat.FormatString = "n2"
        Me.BGColNPOURCCA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGColNPOURCCA.FieldName = "NPOURCCA"
        Me.BGColNPOURCCA.Name = "BGColNPOURCCA"
        '
        'GBREXMOIS
        '
        Me.GBREXMOIS.AppearanceHeader.Font = CType(resources.GetObject("GBREXMOIS.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBREXMOIS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GBREXMOIS.AppearanceHeader.Options.UseFont = True
        Me.GBREXMOIS.AppearanceHeader.Options.UseForeColor = True
        Me.GBREXMOIS.AppearanceHeader.Options.UseTextOptions = True
        Me.GBREXMOIS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBREXMOIS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GBREXMOIS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GBREXMOIS, "GBREXMOIS")
        Me.GBREXMOIS.Columns.Add(Me.BGColNPOURCCALASTMOIS)
        Me.GBREXMOIS.Columns.Add(Me.BGColNDIFFPOURCCALASTMOIS)
        Me.GBREXMOIS.VisibleIndex = 1
        '
        'BGColNPOURCCALASTMOIS
        '
        Me.BGColNPOURCCALASTMOIS.AppearanceHeader.Font = CType(resources.GetObject("BGColNPOURCCALASTMOIS.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColNPOURCCALASTMOIS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColNPOURCCALASTMOIS.AppearanceHeader.Options.UseFont = True
        Me.BGColNPOURCCALASTMOIS.AppearanceHeader.Options.UseForeColor = True
        Me.BGColNPOURCCALASTMOIS.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColNPOURCCALASTMOIS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColNPOURCCALASTMOIS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColNPOURCCALASTMOIS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGColNPOURCCALASTMOIS, "BGColNPOURCCALASTMOIS")
        Me.BGColNPOURCCALASTMOIS.DisplayFormat.FormatString = "n2"
        Me.BGColNPOURCCALASTMOIS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGColNPOURCCALASTMOIS.FieldName = "NPOURCCALASTMOIS"
        Me.BGColNPOURCCALASTMOIS.Name = "BGColNPOURCCALASTMOIS"
        '
        'GBREXAN
        '
        Me.GBREXAN.AppearanceHeader.Font = CType(resources.GetObject("GBREXAN.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBREXAN.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GBREXAN.AppearanceHeader.Options.UseFont = True
        Me.GBREXAN.AppearanceHeader.Options.UseForeColor = True
        Me.GBREXAN.AppearanceHeader.Options.UseTextOptions = True
        Me.GBREXAN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBREXAN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GBREXAN.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GBREXAN, "GBREXAN")
        Me.GBREXAN.Columns.Add(Me.BGColNPOURCCALASTYEAR)
        Me.GBREXAN.Columns.Add(Me.BGColNDIFFPOURCCALASTYEAR)
        Me.GBREXAN.VisibleIndex = 2
        '
        'BGColNPOURCCALASTYEAR
        '
        Me.BGColNPOURCCALASTYEAR.AppearanceHeader.Font = CType(resources.GetObject("BGColNPOURCCALASTYEAR.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColNPOURCCALASTYEAR.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BGColNPOURCCALASTYEAR.AppearanceHeader.Options.UseFont = True
        Me.BGColNPOURCCALASTYEAR.AppearanceHeader.Options.UseForeColor = True
        Me.BGColNPOURCCALASTYEAR.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColNPOURCCALASTYEAR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColNPOURCCALASTYEAR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColNPOURCCALASTYEAR.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGColNPOURCCALASTYEAR, "BGColNPOURCCALASTYEAR")
        Me.BGColNPOURCCALASTYEAR.DisplayFormat.FormatString = "n2"
        Me.BGColNPOURCCALASTYEAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BGColNPOURCCALASTYEAR.FieldName = "NPOURCCALASTYEAR"
        Me.BGColNPOURCCALASTYEAR.Name = "BGColNPOURCCALASTYEAR"
        '
        'GrpPeriode
        '
        Me.GrpPeriode.Controls.Add(Me.BtnValid)
        Me.GrpPeriode.Controls.Add(Me.LblAnnee)
        Me.GrpPeriode.Controls.Add(Me.LblMois)
        Me.GrpPeriode.Controls.Add(Me.CboAnnee)
        Me.GrpPeriode.Controls.Add(Me.CboMois)
        resources.ApplyResources(Me.GrpPeriode, "GrpPeriode")
        Me.GrpPeriode.Name = "GrpPeriode"
        Me.GrpPeriode.TabStop = False
        '
        'BtnValid
        '
        resources.ApplyResources(Me.BtnValid, "BtnValid")
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'LblAnnee
        '
        resources.ApplyResources(Me.LblAnnee, "LblAnnee")
        Me.LblAnnee.Name = "LblAnnee"
        '
        'LblMois
        '
        resources.ApplyResources(Me.LblMois, "LblMois")
        Me.LblMois.Name = "LblMois"
        '
        'CboAnnee
        '
        Me.CboAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAnnee.FormattingEnabled = True
        resources.ApplyResources(Me.CboAnnee, "CboAnnee")
        Me.CboAnnee.Name = "CboAnnee"
        '
        'CboMois
        '
        Me.CboMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMois.FormattingEnabled = True
        resources.ApplyResources(Me.CboMois, "CboMois")
        Me.CboMois.Name = "CboMois"
        '
        'FrmSynthCompta
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnFermer
        Me.Controls.Add(Me.GrpPeriode)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.XTBCSynthCompta)
        Me.Name = "FrmSynthCompta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.XTPBalanceAna.ResumeLayout(False)
        CType(Me.GCBalanceAna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBGVBilanAnaSoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPBilanCpt.ResumeLayout(False)
        CType(Me.GCSynthCompta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBGVBilanAna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XTBCSynthCompta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTBCSynthCompta.ResumeLayout(False)
        Me.XTPREX.ResumeLayout(False)
        CType(Me.GCAnaREX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGVAnaREX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPeriode.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnExportPDF As System.Windows.Forms.Button
    Friend WithEvents BtnExportXLS As System.Windows.Forms.Button
    Friend WithEvents SFDSynCompta As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GrpPeriode As System.Windows.Forms.GroupBox
    Friend WithEvents LblMois As System.Windows.Forms.Label
    Friend WithEvents CboAnnee As System.Windows.Forms.ComboBox
    Friend WithEvents CboMois As System.Windows.Forms.ComboBox
    Friend WithEvents LblAnnee As System.Windows.Forms.Label
    Friend WithEvents BtnValid As System.Windows.Forms.Button
    Friend WithEvents BtnDepenseAna As System.Windows.Forms.Button
    Private WithEvents XTPBalanceAna As DevExpress.XtraTab.XtraTabPage
    Private WithEvents GCBalanceAna As DevExpress.XtraGrid.GridControl
    Private WithEvents AdvBGVBilanAnaSoc As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Private WithEvents BGColBalAnaNCANNUM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColBalAnaVCANLIB As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColBalAnaNDEPREEL As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColBalAnaNPOURCDEPREEL As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColBalAnaNSOLDE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColBalAnaOD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColBalAnaNAJUSTE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColBalAnaTOTREAJUST As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColBalAnaPOURCANNEE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColBalAnaDIFFPOURCANNEE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents XTPBilanCpt As DevExpress.XtraTab.XtraTabPage
    Private WithEvents GCSynthCompta As DevExpress.XtraGrid.GridControl
    Private WithEvents AdvBGVBilanAna As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Private WithEvents BGCNum As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCLibANA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCChaff As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCMttCA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCPourcProd As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCSectAna As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCOD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCENCOURS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCResultAjust As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCPourcCA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCPourcMoisPrec As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCPourcRapportMoisPrec As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCPourcAnneePrec As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCRapportAnneePrec As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCPourcTotal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCPartFGMtt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCPourcFG As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents XTBCSynthCompta As DevExpress.XtraTab.XtraTabControl
    Private WithEvents XTPREX As DevExpress.XtraTab.XtraTabPage
    Private WithEvents BGCENCOURSMANU As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents GCAnaREX As DevExpress.XtraGrid.GridControl
    Private WithEvents AdvBandedGVAnaREX As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Private WithEvents BGColNID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColVINTITULE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNRESULT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNPOURCCA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNPOURCCALASTMOIS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNDIFFPOURCCALASTMOIS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNPOURCCALASTYEAR As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColNDIFFPOURCCALASTYEAR As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents GBREX As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBREXMOIS As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBREXAN As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents BGColAnaNPOURCREAJUST As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents GBBALCOMPTE As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBBALDEP As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBBALTAB As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBBALREAJUSTE As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBBALANNEEPREC As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents BGCPourcChargeStruct As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCCTYPECTE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCCCTEANAACTIF As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCPVRECEPT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BGCCAMONTHLASTYEAR As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BGCRESTDUTOT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BGCTXCONVERSEDCL As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BGCAJUSTE_TX_HOR As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BGColBalAnaAJUSTE_TX_HOR As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BGVLIBGROUPE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GBCompte As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BGVNRFAPOURC As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GBChaff As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GBProd As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GBResultFG As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GBBILANREAJUSTE As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GBMOISPREC As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GBANNEEPREC As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GBBILANRESULT As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GBPartFG As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GBTxChargeStruct As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BGColBalAnaCCTEANAACTIF As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
