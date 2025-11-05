<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTableauBordEI
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTableauBordEI))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnExportXLS = New System.Windows.Forms.Button()
        Me.BtnExportPdf = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.cboAnnee = New System.Windows.Forms.ComboBox()
        Me.btnValid = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GCStat = New DevExpress.XtraGrid.GridControl()
        Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ENSEIGNE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NBSITE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EXTINV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EXTINST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.N4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNREGCOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.INSTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VERIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Q4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintObject = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintComponentLink = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.GRPApercu = New System.Windows.Forms.GroupBox()
        Me.GCN4 = New DevExpress.XtraGrid.GridControl()
        Me.GVN4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColDateCre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColPathFile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVIMAGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WBApercu = New System.Windows.Forms.WebBrowser()
        Me.lblDateJour = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintObject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRPApercu.SuspendLayout()
        CType(Me.GCN4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVN4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnExportXLS)
        Me.GrpActions.Controls.Add(Me.BtnExportPdf)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
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
        'BtnExportPdf
        '
        resources.ApplyResources(Me.BtnExportPdf, "BtnExportPdf")
        Me.BtnExportPdf.Name = "BtnExportPdf"
        Me.BtnExportPdf.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'cboAnnee
        '
        resources.ApplyResources(Me.cboAnnee, "cboAnnee")
        Me.cboAnnee.FormattingEnabled = True
        Me.cboAnnee.Name = "cboAnnee"
        '
        'btnValid
        '
        resources.ApplyResources(Me.btnValid, "btnValid")
        Me.btnValid.Name = "btnValid"
        Me.btnValid.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GCStat
        '
        resources.ApplyResources(Me.GCStat, "GCStat")
        Me.GCStat.MainView = Me.GVStat
        Me.GCStat.Name = "GCStat"
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
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NCLINUM, Me.CLIENT, Me.ENSEIGNE, Me.NBSITE, Me.EXTINV, Me.EXTINST, Me.N4, Me.CA, Me.VSITNOM, Me.GColNREGCOD, Me.CLI, Me.INSTAL, Me.VERIF, Me.Q4})
        Me.GVStat.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsCustomization.AllowGroup = False
        Me.GVStat.OptionsPrint.ExpandAllDetails = True
        Me.GVStat.OptionsPrint.PrintPreview = True
        Me.GVStat.OptionsView.ShowAutoFilterRow = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'NCLINUM
        '
        resources.ApplyResources(Me.NCLINUM, "NCLINUM")
        Me.NCLINUM.FieldName = "NCLINUM"
        Me.NCLINUM.Name = "NCLINUM"
        '
        'CLIENT
        '
        Me.CLIENT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.CLIENT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.CLIENT, "CLIENT")
        Me.CLIENT.FieldName = "VCLINOM"
        Me.CLIENT.Name = "CLIENT"
        '
        'ENSEIGNE
        '
        Me.ENSEIGNE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ENSEIGNE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.ENSEIGNE, "ENSEIGNE")
        Me.ENSEIGNE.FieldName = "VSITENSEIGNE"
        Me.ENSEIGNE.Name = "ENSEIGNE"
        '
        'NBSITE
        '
        Me.NBSITE.AppearanceCell.Options.UseTextOptions = True
        Me.NBSITE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NBSITE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.NBSITE, "NBSITE")
        Me.NBSITE.FieldName = "SIT"
        Me.NBSITE.Name = "NBSITE"
        '
        'EXTINV
        '
        Me.EXTINV.AppearanceCell.Options.UseTextOptions = True
        Me.EXTINV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EXTINV.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EXTINV.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.EXTINV.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.EXTINV, "EXTINV")
        Me.EXTINV.FieldName = "EXTINV"
        Me.EXTINV.Name = "EXTINV"
        Me.EXTINV.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("EXTINV.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'EXTINST
        '
        Me.EXTINST.AppearanceCell.Options.UseTextOptions = True
        Me.EXTINST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EXTINST.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EXTINST.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.EXTINST.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.EXTINST, "EXTINST")
        Me.EXTINST.FieldName = "EXTINST"
        Me.EXTINST.Name = "EXTINST"
        Me.EXTINST.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("EXTINST.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'N4
        '
        Me.N4.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.N4.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.N4, "N4")
        Me.N4.FieldName = "N4"
        Me.N4.Name = "N4"
        Me.N4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("N4.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'CA
        '
        Me.CA.AppearanceCell.Options.UseTextOptions = True
        Me.CA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CA.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.CA.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.CA.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.CA, "CA")
        Me.CA.DisplayFormat.FormatString = "### ### ###"
        Me.CA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.CA.FieldName = "CA"
        Me.CA.Name = "CA"
        Me.CA.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom
        Me.CA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("CA.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'VSITNOM
        '
        Me.VSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VSITNOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VSITNOM, "VSITNOM")
        Me.VSITNOM.FieldName = "VSITNOM"
        Me.VSITNOM.Name = "VSITNOM"
        '
        'GColNREGCOD
        '
        Me.GColNREGCOD.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNREGCOD.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColNREGCOD, "GColNREGCOD")
        Me.GColNREGCOD.FieldName = "NREGCOD"
        Me.GColNREGCOD.Name = "GColNREGCOD"
        Me.GColNREGCOD.OptionsColumn.AllowEdit = False
        Me.GColNREGCOD.OptionsColumn.ReadOnly = True
        Me.GColNREGCOD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'CLI
        '
        resources.ApplyResources(Me.CLI, "CLI")
        Me.CLI.FieldName = "VCLINOM"
        Me.CLI.Name = "CLI"
        '
        'INSTAL
        '
        Me.INSTAL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.INSTAL.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.INSTAL, "INSTAL")
        Me.INSTAL.FieldName = "INSTAL"
        Me.INSTAL.Name = "INSTAL"
        Me.INSTAL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("INSTAL.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'VERIF
        '
        Me.VERIF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VERIF.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VERIF, "VERIF")
        Me.VERIF.FieldName = "VERIF"
        Me.VERIF.Name = "VERIF"
        Me.VERIF.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("VERIF.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'Q4
        '
        Me.Q4.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Q4.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Q4, "Q4")
        Me.Q4.FieldName = "Q4"
        Me.Q4.Name = "Q4"
        Me.Q4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("Q4.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'PrintObject
        '
        Me.PrintObject.Links.AddRange(New Object() {Me.PrintComponentLink})
        Me.PrintObject.Watermark.Font = New DevExpress.Drawing.DXFont("Verdana", 10.0!)
        Me.PrintObject.Watermark.ForeColor = System.Drawing.Color.Black
        Me.PrintObject.Watermark.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PrintObject.Watermark.TextDirection = DevExpress.XtraPrinting.Drawing.DirectionMode.Horizontal
        '
        'PrintComponentLink
        '
        Me.PrintComponentLink.Component = Me.GCStat
        Me.PrintComponentLink.Margins = New DevExpress.Drawing.DXMargins(20.0!, 20.0!, 40.0!, 40.0!)
        Me.PrintComponentLink.MinMargins = New DevExpress.Drawing.DXMargins(4.0!, 4.0!, 4.0!, 4.0!)
        Me.PrintComponentLink.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintComponentLink.PrintingSystemBase = Me.PrintObject
        '
        'GRPApercu
        '
        Me.GRPApercu.Controls.Add(Me.GCN4)
        Me.GRPApercu.Controls.Add(Me.WBApercu)
        resources.ApplyResources(Me.GRPApercu, "GRPApercu")
        Me.GRPApercu.Name = "GRPApercu"
        Me.GRPApercu.TabStop = False
        '
        'GCN4
        '
        resources.ApplyResources(Me.GCN4, "GCN4")
        Me.GCN4.MainView = Me.GVN4
        Me.GCN4.Name = "GCN4"
        Me.GCN4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVN4})
        '
        'GVN4
        '
        Me.GVN4.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVN4.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVN4.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVN4.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVN4.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVN4.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVN4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColDateCre, Me.GColPathFile, Me.GColVIMAGE})
        Me.GVN4.GridControl = Me.GCN4
        Me.GVN4.Name = "GVN4"
        Me.GVN4.OptionsBehavior.Editable = False
        Me.GVN4.OptionsBehavior.ReadOnly = True
        Me.GVN4.OptionsView.ShowGroupPanel = False
        '
        'GColDateCre
        '
        Me.GColDateCre.AppearanceCell.Options.UseTextOptions = True
        Me.GColDateCre.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDateCre.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDateCre.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDateCre.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColDateCre, "GColDateCre")
        Me.GColDateCre.FieldName = "DDATECRE"
        Me.GColDateCre.Name = "GColDateCre"
        '
        'GColPathFile
        '
        Me.GColPathFile.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColPathFile.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColPathFile, "GColPathFile")
        Me.GColPathFile.FieldName = "VPATHFICHIER"
        Me.GColPathFile.Name = "GColPathFile"
        '
        'GColVIMAGE
        '
        Me.GColVIMAGE.AppearanceCell.Options.UseTextOptions = True
        Me.GColVIMAGE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVIMAGE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVIMAGE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVIMAGE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVIMAGE, "GColVIMAGE")
        Me.GColVIMAGE.FieldName = "VIMAGE"
        Me.GColVIMAGE.Name = "GColVIMAGE"
        '
        'WBApercu
        '
        resources.ApplyResources(Me.WBApercu, "WBApercu")
        Me.WBApercu.Name = "WBApercu"
        '
        'lblDateJour
        '
        resources.ApplyResources(Me.lblDateJour, "lblDateJour")
        Me.lblDateJour.Name = "lblDateJour"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'frmTableauBordEI
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.btnValid)
        Me.Controls.Add(Me.cboAnnee)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDateJour)
        Me.Controls.Add(Me.GRPApercu)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmTableauBordEI"
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintObject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRPApercu.ResumeLayout(False)
        CType(Me.GCN4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVN4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents btnValid As System.Windows.Forms.Button
    Friend WithEvents cboAnnee As System.Windows.Forms.ComboBox
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnExportPdf As System.Windows.Forms.Button
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GRPApercu As System.Windows.Forms.GroupBox
    Friend WithEvents WBApercu As System.Windows.Forms.WebBrowser
    Friend WithEvents lblDateJour As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents NCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents CLIENT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NBSITE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents EXTINV As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents EXTINST As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents CA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents N4 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents CLI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents PrintObject As DevExpress.XtraPrinting.PrintingSystem
    Private WithEvents PrintComponentLink As DevExpress.XtraPrinting.PrintableComponentLink
    Private WithEvents GCN4 As DevExpress.XtraGrid.GridControl
    Private WithEvents GVN4 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColDateCre As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColPathFile As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVIMAGE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ENSEIGNE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents INSTAL As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VERIF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Q4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnExportXLS As Button
    Friend WithEvents GColNREGCOD As DevExpress.XtraGrid.Columns.GridColumn
End Class
