<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXListeWithChiffrage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXListeWithChiffrage))
        Me.GCListe = New DevExpress.XtraGrid.GridControl()
        Me.GVListeChantier = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NIDCHIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VLIBCHIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DDAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NPVHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VCANLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DDATCRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CHAF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NPAVTH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NIDCHANTIER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VGROUPLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NBDOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpBtn = New System.Windows.Forms.GroupBox()
        Me.cmdPlanDeCharge = New MozartUC.apiButton()
        Me.BtnModifProrata = New System.Windows.Forms.Button()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.btnImprimer = New System.Windows.Forms.Button()
        Me.btnListeArchive = New System.Windows.Forms.Button()
        Me.btnSup = New System.Windows.Forms.Button()
        Me.BtnPlanningChantier = New System.Windows.Forms.Button()
        Me.BtnChantierDoc = New System.Windows.Forms.Button()
        Me.btnAnalyse = New System.Windows.Forms.Button()
        Me.btnCreationFiches = New System.Windows.Forms.Button()
        Me.btnValidation = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnAjout = New System.Windows.Forms.Button()
        Me.GrpTypeAffichage = New System.Windows.Forms.GroupBox()
        Me.chkExpand = New System.Windows.Forms.CheckBox()
        Me.rbAll = New System.Windows.Forms.RadioButton()
        Me.rbChiffrage = New System.Windows.Forms.RadioButton()
        Me.rbChantier = New System.Windows.Forms.RadioButton()
        CType(Me.GCListe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeChantier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBtn.SuspendLayout()
        Me.GrpTypeAffichage.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCListe
        '
        resources.ApplyResources(Me.GCListe, "GCListe")
        Me.GCListe.MainView = Me.GVListeChantier
        Me.GCListe.Name = "GCListe"
        Me.GCListe.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeChantier})
        '
        'GVListeChantier
        '
        Me.GVListeChantier.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVListeChantier.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListeChantier.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVListeChantier.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVListeChantier.Appearance.FooterPanel.Font = CType(resources.GetObject("GVListeChantier.Appearance.FooterPanel.Font"), System.Drawing.Font)
        Me.GVListeChantier.Appearance.FooterPanel.Options.UseFont = True
        Me.GVListeChantier.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GVListeChantier.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red
        Me.GVListeChantier.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVListeChantier.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVListeChantier.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVListeChantier.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVListeChantier.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVListeChantier.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListeChantier.AppearancePrint.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GVListeChantier.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NIDCHIF, Me.VCLINOM, Me.VLIBCHIF, Me.DDAT, Me.NPVHT, Me.VCANLIB, Me.DDATCRE, Me.CHAF, Me.NPAVTH, Me.NIDCHANTIER, Me.VGROUPLIB, Me.RES, Me.NBDOC})
        Me.GVListeChantier.GridControl = Me.GCListe
        Me.GVListeChantier.GroupCount = 1
        resources.ApplyResources(Me.GVListeChantier, "GVListeChantier")
        Me.GVListeChantier.Name = "GVListeChantier"
        Me.GVListeChantier.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVListeChantier.OptionsBehavior.Editable = False
        Me.GVListeChantier.OptionsBehavior.ReadOnly = True
        Me.GVListeChantier.OptionsDetail.EnableDetailToolTip = True
        Me.GVListeChantier.OptionsDetail.ShowDetailTabs = False
        Me.GVListeChantier.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.GVListeChantier.OptionsPrint.PrintGroupFooter = False
        Me.GVListeChantier.OptionsPrint.PrintHorzLines = False
        Me.GVListeChantier.OptionsView.ShowAutoFilterRow = True
        Me.GVListeChantier.OptionsView.ShowFooter = True
        Me.GVListeChantier.OptionsView.ShowGroupPanel = False
        Me.GVListeChantier.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.VGROUPLIB, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'NIDCHIF
        '
        resources.ApplyResources(Me.NIDCHIF, "NIDCHIF")
        Me.NIDCHIF.FieldName = "NIDCHIF"
        Me.NIDCHIF.Name = "NIDCHIF"
        '
        'VCLINOM
        '
        Me.VCLINOM.AppearanceHeader.Font = CType(resources.GetObject("VCLINOM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.VCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VCLINOM.AppearanceHeader.Options.UseFont = True
        Me.VCLINOM.AppearanceHeader.Options.UseForeColor = True
        Me.VCLINOM.AppearanceHeader.Options.UseTextOptions = True
        Me.VCLINOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.VCLINOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.VCLINOM, "VCLINOM")
        Me.VCLINOM.FieldName = "VCLINOM"
        Me.VCLINOM.Name = "VCLINOM"
        Me.VCLINOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VLIBCHIF
        '
        Me.VLIBCHIF.AppearanceHeader.Font = CType(resources.GetObject("VLIBCHIF.AppearanceHeader.Font"), System.Drawing.Font)
        Me.VLIBCHIF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VLIBCHIF.AppearanceHeader.Options.UseFont = True
        Me.VLIBCHIF.AppearanceHeader.Options.UseForeColor = True
        Me.VLIBCHIF.AppearanceHeader.Options.UseTextOptions = True
        Me.VLIBCHIF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.VLIBCHIF.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.VLIBCHIF, "VLIBCHIF")
        Me.VLIBCHIF.FieldName = "VLIBCHIF"
        Me.VLIBCHIF.Name = "VLIBCHIF"
        Me.VLIBCHIF.OptionsColumn.AllowSize = False
        Me.VLIBCHIF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.VLIBCHIF.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("VLIBCHIF.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("VLIBCHIF.Summary1"), resources.GetString("VLIBCHIF.Summary2"))})
        '
        'DDAT
        '
        Me.DDAT.AppearanceCell.Options.UseTextOptions = True
        Me.DDAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DDAT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DDAT.AppearanceHeader.Font = CType(resources.GetObject("DDAT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.DDAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DDAT.AppearanceHeader.Options.UseFont = True
        Me.DDAT.AppearanceHeader.Options.UseForeColor = True
        Me.DDAT.AppearanceHeader.Options.UseTextOptions = True
        Me.DDAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DDAT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.DDAT, "DDAT")
        Me.DDAT.DisplayFormat.FormatString = "d"
        Me.DDAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DDAT.FieldName = "DDAT"
        Me.DDAT.Name = "DDAT"
        Me.DDAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'NPVHT
        '
        Me.NPVHT.AppearanceCell.Options.UseTextOptions = True
        Me.NPVHT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.NPVHT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.NPVHT.AppearanceHeader.Font = CType(resources.GetObject("NPVHT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.NPVHT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NPVHT.AppearanceHeader.Options.UseFont = True
        Me.NPVHT.AppearanceHeader.Options.UseForeColor = True
        Me.NPVHT.AppearanceHeader.Options.UseTextOptions = True
        Me.NPVHT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NPVHT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.NPVHT, "NPVHT")
        Me.NPVHT.DisplayFormat.FormatString = "### ### ###"
        Me.NPVHT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.NPVHT.FieldName = "NPVHT"
        Me.NPVHT.Name = "NPVHT"
        Me.NPVHT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.NPVHT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("NPVHT.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("NPVHT.Summary1"), resources.GetString("NPVHT.Summary2"))})
        '
        'VCANLIB
        '
        Me.VCANLIB.AppearanceHeader.Options.UseTextOptions = True
        Me.VCANLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.VCANLIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.VCANLIB, "VCANLIB")
        Me.VCANLIB.FieldName = "VCANLIB"
        Me.VCANLIB.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DisplayText
        Me.VCANLIB.Name = "VCANLIB"
        '
        'DDATCRE
        '
        Me.DDATCRE.AppearanceCell.Options.UseTextOptions = True
        Me.DDATCRE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DDATCRE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DDATCRE.AppearanceHeader.Font = CType(resources.GetObject("DDATCRE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.DDATCRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DDATCRE.AppearanceHeader.Options.UseFont = True
        Me.DDATCRE.AppearanceHeader.Options.UseForeColor = True
        Me.DDATCRE.AppearanceHeader.Options.UseTextOptions = True
        Me.DDATCRE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DDATCRE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.DDATCRE, "DDATCRE")
        Me.DDATCRE.FieldName = "DDATCRE"
        Me.DDATCRE.Name = "DDATCRE"
        Me.DDATCRE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'CHAF
        '
        Me.CHAF.AppearanceCell.Options.UseTextOptions = True
        Me.CHAF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CHAF.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.CHAF.AppearanceHeader.Font = CType(resources.GetObject("CHAF.AppearanceHeader.Font"), System.Drawing.Font)
        Me.CHAF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.CHAF.AppearanceHeader.Options.UseFont = True
        Me.CHAF.AppearanceHeader.Options.UseForeColor = True
        Me.CHAF.AppearanceHeader.Options.UseTextOptions = True
        Me.CHAF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CHAF.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.CHAF, "CHAF")
        Me.CHAF.FieldName = "CHAF"
        Me.CHAF.Name = "CHAF"
        Me.CHAF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'NPAVTH
        '
        Me.NPAVTH.AppearanceCell.Options.UseTextOptions = True
        Me.NPAVTH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NPAVTH.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.NPAVTH.AppearanceHeader.Font = CType(resources.GetObject("NPAVTH.AppearanceHeader.Font"), System.Drawing.Font)
        Me.NPAVTH.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NPAVTH.AppearanceHeader.Options.UseFont = True
        Me.NPAVTH.AppearanceHeader.Options.UseForeColor = True
        Me.NPAVTH.AppearanceHeader.Options.UseTextOptions = True
        Me.NPAVTH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NPAVTH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.NPAVTH, "NPAVTH")
        Me.NPAVTH.DisplayFormat.FormatString = "N1"
        Me.NPAVTH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NPAVTH.FieldName = "NPAVTH"
        Me.NPAVTH.Name = "NPAVTH"
        Me.NPAVTH.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'NIDCHANTIER
        '
        resources.ApplyResources(Me.NIDCHANTIER, "NIDCHANTIER")
        Me.NIDCHANTIER.FieldName = "NIDCHANTIER"
        Me.NIDCHANTIER.Name = "NIDCHANTIER"
        '
        'VGROUPLIB
        '
        resources.ApplyResources(Me.VGROUPLIB, "VGROUPLIB")
        Me.VGROUPLIB.FieldName = "VGROUPLIB"
        Me.VGROUPLIB.Name = "VGROUPLIB"
        '
        'RES
        '
        resources.ApplyResources(Me.RES, "RES")
        Me.RES.FieldName = "RES"
        Me.RES.Name = "RES"
        '
        'NBDOC
        '
        resources.ApplyResources(Me.NBDOC, "NBDOC")
        Me.NBDOC.FieldName = "NBDOC"
        Me.NBDOC.Name = "NBDOC"
        '
        'GrpBtn
        '
        resources.ApplyResources(Me.GrpBtn, "GrpBtn")
        Me.GrpBtn.Controls.Add(Me.cmdPlanDeCharge)
        Me.GrpBtn.Controls.Add(Me.BtnModifProrata)
        Me.GrpBtn.Controls.Add(Me.btnFermer)
        Me.GrpBtn.Controls.Add(Me.btnImprimer)
        Me.GrpBtn.Controls.Add(Me.btnListeArchive)
        Me.GrpBtn.Controls.Add(Me.btnSup)
        Me.GrpBtn.Controls.Add(Me.BtnPlanningChantier)
        Me.GrpBtn.Controls.Add(Me.BtnChantierDoc)
        Me.GrpBtn.Controls.Add(Me.btnAnalyse)
        Me.GrpBtn.Controls.Add(Me.btnCreationFiches)
        Me.GrpBtn.Controls.Add(Me.btnValidation)
        Me.GrpBtn.Controls.Add(Me.btnModif)
        Me.GrpBtn.Controls.Add(Me.btnAjout)
        Me.GrpBtn.Name = "GrpBtn"
        Me.GrpBtn.TabStop = False
        '
        'cmdPlanDeCharge
        '
        resources.ApplyResources(Me.cmdPlanDeCharge, "cmdPlanDeCharge")
        Me.cmdPlanDeCharge.HelpContextID = 0
        Me.cmdPlanDeCharge.Name = "cmdPlanDeCharge"
        Me.cmdPlanDeCharge.UseVisualStyleBackColor = True
        '
        'BtnModifProrata
        '
        resources.ApplyResources(Me.BtnModifProrata, "BtnModifProrata")
        Me.BtnModifProrata.Name = "BtnModifProrata"
        Me.BtnModifProrata.Tag = "0"
        Me.BtnModifProrata.UseVisualStyleBackColor = True
        '
        'btnFermer
        '
        resources.ApplyResources(Me.btnFermer, "btnFermer")
        Me.btnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'btnImprimer
        '
        resources.ApplyResources(Me.btnImprimer, "btnImprimer")
        Me.btnImprimer.Name = "btnImprimer"
        Me.btnImprimer.UseVisualStyleBackColor = True
        '
        'btnListeArchive
        '
        resources.ApplyResources(Me.btnListeArchive, "btnListeArchive")
        Me.btnListeArchive.Name = "btnListeArchive"
        Me.btnListeArchive.UseVisualStyleBackColor = True
        '
        'btnSup
        '
        resources.ApplyResources(Me.btnSup, "btnSup")
        Me.btnSup.Name = "btnSup"
        Me.btnSup.UseVisualStyleBackColor = True
        '
        'BtnPlanningChantier
        '
        Me.BtnPlanningChantier.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.BtnPlanningChantier, "BtnPlanningChantier")
        Me.BtnPlanningChantier.Name = "BtnPlanningChantier"
        Me.BtnPlanningChantier.Tag = "0"
        Me.BtnPlanningChantier.UseVisualStyleBackColor = False
        '
        'BtnChantierDoc
        '
        Me.BtnChantierDoc.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.BtnChantierDoc, "BtnChantierDoc")
        Me.BtnChantierDoc.Name = "BtnChantierDoc"
        Me.BtnChantierDoc.Tag = "0"
        Me.BtnChantierDoc.UseVisualStyleBackColor = False
        '
        'btnAnalyse
        '
        resources.ApplyResources(Me.btnAnalyse, "btnAnalyse")
        Me.btnAnalyse.Name = "btnAnalyse"
        Me.btnAnalyse.Tag = "0"
        Me.btnAnalyse.UseVisualStyleBackColor = True
        '
        'btnCreationFiches
        '
        resources.ApplyResources(Me.btnCreationFiches, "btnCreationFiches")
        Me.btnCreationFiches.Name = "btnCreationFiches"
        Me.btnCreationFiches.Tag = "0"
        Me.btnCreationFiches.UseVisualStyleBackColor = True
        '
        'btnValidation
        '
        resources.ApplyResources(Me.btnValidation, "btnValidation")
        Me.btnValidation.Name = "btnValidation"
        Me.btnValidation.Tag = "0"
        Me.btnValidation.UseVisualStyleBackColor = True
        '
        'btnModif
        '
        resources.ApplyResources(Me.btnModif, "btnModif")
        Me.btnModif.Name = "btnModif"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'btnAjout
        '
        resources.ApplyResources(Me.btnAjout, "btnAjout")
        Me.btnAjout.Name = "btnAjout"
        Me.btnAjout.UseVisualStyleBackColor = True
        '
        'GrpTypeAffichage
        '
        Me.GrpTypeAffichage.Controls.Add(Me.chkExpand)
        Me.GrpTypeAffichage.Controls.Add(Me.rbAll)
        Me.GrpTypeAffichage.Controls.Add(Me.rbChiffrage)
        Me.GrpTypeAffichage.Controls.Add(Me.rbChantier)
        resources.ApplyResources(Me.GrpTypeAffichage, "GrpTypeAffichage")
        Me.GrpTypeAffichage.Name = "GrpTypeAffichage"
        Me.GrpTypeAffichage.TabStop = False
        '
        'chkExpand
        '
        resources.ApplyResources(Me.chkExpand, "chkExpand")
        Me.chkExpand.Name = "chkExpand"
        Me.chkExpand.UseVisualStyleBackColor = True
        '
        'rbAll
        '
        resources.ApplyResources(Me.rbAll, "rbAll")
        Me.rbAll.Name = "rbAll"
        Me.rbAll.TabStop = True
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'rbChiffrage
        '
        resources.ApplyResources(Me.rbChiffrage, "rbChiffrage")
        Me.rbChiffrage.Name = "rbChiffrage"
        Me.rbChiffrage.TabStop = True
        Me.rbChiffrage.UseVisualStyleBackColor = True
        '
        'rbChantier
        '
        resources.ApplyResources(Me.rbChantier, "rbChantier")
        Me.rbChantier.Name = "rbChantier"
        Me.rbChantier.TabStop = True
        Me.rbChantier.UseVisualStyleBackColor = True
        '
        'frmXListeWithChiffrage
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnFermer
        Me.Controls.Add(Me.GrpTypeAffichage)
        Me.Controls.Add(Me.GrpBtn)
        Me.Controls.Add(Me.GCListe)
        Me.Name = "frmXListeWithChiffrage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCListe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeChantier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBtn.ResumeLayout(False)
        Me.GrpTypeAffichage.ResumeLayout(False)
        Me.GrpTypeAffichage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpBtn As System.Windows.Forms.GroupBox
    Friend WithEvents btnAjout As System.Windows.Forms.Button
    Friend WithEvents btnModif As System.Windows.Forms.Button
    Friend WithEvents btnValidation As System.Windows.Forms.Button
    Friend WithEvents btnCreationFiches As System.Windows.Forms.Button
    Friend WithEvents GrpTypeAffichage As System.Windows.Forms.GroupBox
    Friend WithEvents btnAnalyse As System.Windows.Forms.Button
    Friend WithEvents BtnChantierDoc As System.Windows.Forms.Button
    Friend WithEvents BtnPlanningChantier As System.Windows.Forms.Button
    Friend WithEvents btnSup As System.Windows.Forms.Button
    Friend WithEvents btnListeArchive As System.Windows.Forms.Button
    Friend WithEvents btnImprimer As System.Windows.Forms.Button
    Friend WithEvents btnFermer As System.Windows.Forms.Button
    Friend WithEvents rbChantier As System.Windows.Forms.RadioButton
    Friend WithEvents rbChiffrage As System.Windows.Forms.RadioButton
    Friend WithEvents rbAll As System.Windows.Forms.RadioButton
    Friend WithEvents chkExpand As System.Windows.Forms.CheckBox
    Friend WithEvents BtnModifProrata As System.Windows.Forms.Button
    Private WithEvents GCListe As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeChantier As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents VLIBCHIF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NPVHT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DDAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DDATCRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NIDCHANTIER As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NIDCHIF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VCANLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents CHAF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NPAVTH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VGROUPLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RES As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NBDOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdPlanDeCharge As MozartUC.apiButton
End Class
