<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeChiffrages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeChiffrages))
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
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GrpBtns = New System.Windows.Forms.GroupBox()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.btnImprimer = New System.Windows.Forms.Button()
        Me.btnListeArchive = New System.Windows.Forms.Button()
        Me.btnSup = New System.Windows.Forms.Button()
        Me.btnValidation = New System.Windows.Forms.Button()
        Me.btnAjout = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.GCListe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeChantier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBtns.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCListe
        '
        resources.ApplyResources(Me.GCListe, "GCListe")
        Me.GCListe.MainView = Me.GVListeChantier
        Me.GCListe.Name = "GCListe"
        Me.GCListe.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeChantier, Me.GridView2})
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
        Me.GVListeChantier.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVListeChantier.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVListeChantier.Appearance.HeaderPanel.Options.UseFont = True
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
        Me.VCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
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
        Me.VLIBCHIF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VLIBCHIF.AppearanceHeader.Options.UseForeColor = True
        Me.VLIBCHIF.AppearanceHeader.Options.UseTextOptions = True
        Me.VLIBCHIF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.VLIBCHIF.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.VLIBCHIF, "VLIBCHIF")
        Me.VLIBCHIF.FieldName = "VLIBCHIF"
        Me.VLIBCHIF.Name = "VLIBCHIF"
        Me.VLIBCHIF.OptionsColumn.AllowSize = False
        Me.VLIBCHIF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'DDAT
        '
        Me.DDAT.AppearanceCell.Options.UseTextOptions = True
        Me.DDAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DDAT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DDAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
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
        Me.NPVHT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
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
        Me.DDATCRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
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
        Me.CHAF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
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
        Me.NPAVTH.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NPAVTH.AppearanceHeader.Options.UseForeColor = True
        Me.NPAVTH.AppearanceHeader.Options.UseTextOptions = True
        Me.NPAVTH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NPAVTH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.NPAVTH, "NPAVTH")
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
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCListe
        Me.GridView2.Name = "GridView2"
        '
        'GrpBtns
        '
        Me.GrpBtns.Controls.Add(Me.btnFermer)
        Me.GrpBtns.Controls.Add(Me.btnImprimer)
        Me.GrpBtns.Controls.Add(Me.btnListeArchive)
        Me.GrpBtns.Controls.Add(Me.btnSup)
        Me.GrpBtns.Controls.Add(Me.btnValidation)
        Me.GrpBtns.Controls.Add(Me.btnAjout)
        Me.GrpBtns.Controls.Add(Me.btnModif)
        resources.ApplyResources(Me.GrpBtns, "GrpBtns")
        Me.GrpBtns.Name = "GrpBtns"
        Me.GrpBtns.TabStop = False
        '
        'btnFermer
        '
        resources.ApplyResources(Me.btnFermer, "btnFermer")
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
        'btnValidation
        '
        resources.ApplyResources(Me.btnValidation, "btnValidation")
        Me.btnValidation.Name = "btnValidation"
        Me.btnValidation.Tag = "0"
        Me.btnValidation.UseVisualStyleBackColor = True
        '
        'btnAjout
        '
        resources.ApplyResources(Me.btnAjout, "btnAjout")
        Me.btnAjout.Name = "btnAjout"
        Me.btnAjout.UseVisualStyleBackColor = True
        '
        'btnModif
        '
        resources.ApplyResources(Me.btnModif, "btnModif")
        Me.btnModif.Name = "btnModif"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'frmListeChiffrages
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GrpBtns)
        Me.Controls.Add(Me.GCListe)
        Me.Name = "frmListeChiffrages"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCListe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeChantier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBtns.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpBtns As System.Windows.Forms.GroupBox
    Friend WithEvents btnFermer As System.Windows.Forms.Button
    Friend WithEvents btnImprimer As System.Windows.Forms.Button
    Friend WithEvents btnListeArchive As System.Windows.Forms.Button
    Friend WithEvents btnSup As System.Windows.Forms.Button
    Friend WithEvents btnValidation As System.Windows.Forms.Button
    Friend WithEvents btnAjout As System.Windows.Forms.Button
    Friend WithEvents btnModif As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents GCListe As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeChantier As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents NIDCHIF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VLIBCHIF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DDAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NPVHT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VCANLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DDATCRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents CHAF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NPAVTH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NIDCHANTIER As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VGROUPLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RES As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NBDOC As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
