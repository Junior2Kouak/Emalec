<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeArch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeArch))
        Me.GrdListeArch = New DevExpress.XtraGrid.GridControl()
        Me.GVListeChifArch = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColArchNIDCHIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColArchVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColArchVLIBCHIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColArchDDAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColArchNPVHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColArchVCANLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColArchDDATCRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColArchCHAF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColArchNPAVTH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColArchNIDCHANTIER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColArchVGROUPLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColArchRES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColArchNBDOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.btnRestaurer = New System.Windows.Forms.Button()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.LlblTitre = New System.Windows.Forms.Label()
        CType(Me.GrdListeArch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeChifArch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdListeArch
        '
        resources.ApplyResources(Me.GrdListeArch, "GrdListeArch")
        Me.GrdListeArch.MainView = Me.GVListeChifArch
        Me.GrdListeArch.Name = "GrdListeArch"
        Me.GrdListeArch.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeChifArch})
        '
        'GVListeChifArch
        '
        Me.GVListeChifArch.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVListeChifArch.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListeChifArch.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVListeChifArch.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVListeChifArch.Appearance.FooterPanel.Font = CType(resources.GetObject("GVListeChifArch.Appearance.FooterPanel.Font"), System.Drawing.Font)
        Me.GVListeChifArch.Appearance.FooterPanel.Options.UseFont = True
        Me.GVListeChifArch.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GVListeChifArch.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red
        Me.GVListeChifArch.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVListeChifArch.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVListeChifArch.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVListeChifArch.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVListeChifArch.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeChifArch.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeChifArch.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeChifArch.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeChifArch.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVListeChifArch.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVListeChifArch.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVListeChifArch.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListeChifArch.AppearancePrint.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GVListeChifArch.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColArchNIDCHIF, Me.GColArchVCLINOM, Me.GColArchVLIBCHIF, Me.GColArchDDAT, Me.GColArchNPVHT, Me.GColArchVCANLIB, Me.GColArchDDATCRE, Me.GColArchCHAF, Me.GColArchNPAVTH, Me.GColArchNIDCHANTIER, Me.GColArchVGROUPLIB, Me.GColArchRES, Me.GColArchNBDOC})
        Me.GVListeChifArch.GridControl = Me.GrdListeArch
        Me.GVListeChifArch.GroupCount = 1
        resources.ApplyResources(Me.GVListeChifArch, "GVListeChifArch")
        Me.GVListeChifArch.Name = "GVListeChifArch"
        Me.GVListeChifArch.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVListeChifArch.OptionsBehavior.Editable = False
        Me.GVListeChifArch.OptionsBehavior.ReadOnly = True
        Me.GVListeChifArch.OptionsDetail.EnableDetailToolTip = True
        Me.GVListeChifArch.OptionsDetail.ShowDetailTabs = False
        Me.GVListeChifArch.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.GVListeChifArch.OptionsPrint.PrintGroupFooter = False
        Me.GVListeChifArch.OptionsPrint.PrintHorzLines = False
        Me.GVListeChifArch.OptionsView.ShowAutoFilterRow = True
        Me.GVListeChifArch.OptionsView.ShowFooter = True
        Me.GVListeChifArch.OptionsView.ShowGroupPanel = False
        Me.GVListeChifArch.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GColArchVGROUPLIB, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GColArchNIDCHIF
        '
        resources.ApplyResources(Me.GColArchNIDCHIF, "GColArchNIDCHIF")
        Me.GColArchNIDCHIF.FieldName = "NIDCHIF"
        Me.GColArchNIDCHIF.Name = "GColArchNIDCHIF"
        '
        'GColArchVCLINOM
        '
        Me.GColArchVCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColArchVCLINOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColArchVCLINOM, "GColArchVCLINOM")
        Me.GColArchVCLINOM.FieldName = "VCLINOM"
        Me.GColArchVCLINOM.Name = "GColArchVCLINOM"
        Me.GColArchVCLINOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColArchVLIBCHIF
        '
        Me.GColArchVLIBCHIF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColArchVLIBCHIF.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColArchVLIBCHIF, "GColArchVLIBCHIF")
        Me.GColArchVLIBCHIF.FieldName = "VLIBCHIF"
        Me.GColArchVLIBCHIF.Name = "GColArchVLIBCHIF"
        Me.GColArchVLIBCHIF.OptionsColumn.AllowSize = False
        Me.GColArchVLIBCHIF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColArchVLIBCHIF.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GColArchVLIBCHIF.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("GColArchVLIBCHIF.Summary1"), resources.GetString("GColArchVLIBCHIF.Summary2"))})
        '
        'GColArchDDAT
        '
        Me.GColArchDDAT.AppearanceCell.Options.UseTextOptions = True
        Me.GColArchDDAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColArchDDAT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColArchDDAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColArchDDAT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColArchDDAT, "GColArchDDAT")
        Me.GColArchDDAT.DisplayFormat.FormatString = "d"
        Me.GColArchDDAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GColArchDDAT.FieldName = "DDAT"
        Me.GColArchDDAT.Name = "GColArchDDAT"
        Me.GColArchDDAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColArchNPVHT
        '
        Me.GColArchNPVHT.AppearanceCell.Options.UseTextOptions = True
        Me.GColArchNPVHT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GColArchNPVHT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColArchNPVHT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColArchNPVHT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColArchNPVHT, "GColArchNPVHT")
        Me.GColArchNPVHT.DisplayFormat.FormatString = "### ### ###"
        Me.GColArchNPVHT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GColArchNPVHT.FieldName = "NPVHT"
        Me.GColArchNPVHT.Name = "GColArchNPVHT"
        Me.GColArchNPVHT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColArchNPVHT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GColArchNPVHT.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("GColArchNPVHT.Summary1"), resources.GetString("GColArchNPVHT.Summary2"))})
        '
        'GColArchVCANLIB
        '
        resources.ApplyResources(Me.GColArchVCANLIB, "GColArchVCANLIB")
        Me.GColArchVCANLIB.FieldName = "VCANLIB"
        Me.GColArchVCANLIB.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DisplayText
        Me.GColArchVCANLIB.Name = "GColArchVCANLIB"
        '
        'GColArchDDATCRE
        '
        Me.GColArchDDATCRE.AppearanceCell.Options.UseTextOptions = True
        Me.GColArchDDATCRE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColArchDDATCRE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColArchDDATCRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColArchDDATCRE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColArchDDATCRE, "GColArchDDATCRE")
        Me.GColArchDDATCRE.FieldName = "DDATCRE"
        Me.GColArchDDATCRE.Name = "GColArchDDATCRE"
        Me.GColArchDDATCRE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColArchCHAF
        '
        Me.GColArchCHAF.AppearanceCell.Options.UseTextOptions = True
        Me.GColArchCHAF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColArchCHAF.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColArchCHAF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColArchCHAF.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColArchCHAF, "GColArchCHAF")
        Me.GColArchCHAF.FieldName = "CHAF"
        Me.GColArchCHAF.Name = "GColArchCHAF"
        Me.GColArchCHAF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColArchNPAVTH
        '
        Me.GColArchNPAVTH.AppearanceCell.Options.UseTextOptions = True
        Me.GColArchNPAVTH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColArchNPAVTH.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColArchNPAVTH.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColArchNPAVTH.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColArchNPAVTH, "GColArchNPAVTH")
        Me.GColArchNPAVTH.FieldName = "NPAVTH"
        Me.GColArchNPAVTH.Name = "GColArchNPAVTH"
        Me.GColArchNPAVTH.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColArchNIDCHANTIER
        '
        resources.ApplyResources(Me.GColArchNIDCHANTIER, "GColArchNIDCHANTIER")
        Me.GColArchNIDCHANTIER.FieldName = "NIDCHANTIER"
        Me.GColArchNIDCHANTIER.Name = "GColArchNIDCHANTIER"
        '
        'GColArchVGROUPLIB
        '
        resources.ApplyResources(Me.GColArchVGROUPLIB, "GColArchVGROUPLIB")
        Me.GColArchVGROUPLIB.FieldName = "VGROUPLIB"
        Me.GColArchVGROUPLIB.Name = "GColArchVGROUPLIB"
        '
        'GColArchRES
        '
        resources.ApplyResources(Me.GColArchRES, "GColArchRES")
        Me.GColArchRES.FieldName = "RES"
        Me.GColArchRES.Name = "GColArchRES"
        '
        'GColArchNBDOC
        '
        resources.ApplyResources(Me.GColArchNBDOC, "GColArchNBDOC")
        Me.GColArchNBDOC.FieldName = "NBDOC"
        Me.GColArchNBDOC.Name = "GColArchNBDOC"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.btnRestaurer)
        Me.GrpActions.Controls.Add(Me.btnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'btnRestaurer
        '
        resources.ApplyResources(Me.btnRestaurer, "btnRestaurer")
        Me.btnRestaurer.Name = "btnRestaurer"
        Me.btnRestaurer.UseVisualStyleBackColor = True
        '
        'btnFermer
        '
        resources.ApplyResources(Me.btnFermer, "btnFermer")
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'LlblTitre
        '
        resources.ApplyResources(Me.LlblTitre, "LlblTitre")
        Me.LlblTitre.Name = "LlblTitre"
        '
        'frmListeArch
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LlblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GrdListeArch)
        Me.Name = "frmListeArch"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GrdListeArch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeChifArch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents btnRestaurer As System.Windows.Forms.Button
    Friend WithEvents btnFermer As System.Windows.Forms.Button
    Friend WithEvents LlblTitre As System.Windows.Forms.Label
    Private WithEvents GrdListeArch As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeChifArch As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColArchNIDCHIF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColArchVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColArchVLIBCHIF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColArchDDAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColArchNPVHT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColArchVCANLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColArchDDATCRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColArchCHAF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColArchNPAVTH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColArchNIDCHANTIER As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColArchVGROUPLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColArchRES As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColArchNBDOC As DevExpress.XtraGrid.Columns.GridColumn
End Class
