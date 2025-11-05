<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatRHChargeStruct_Details_Pers
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatRHChargeStruct_Details_Pers))
    Me.GCStatTech = New DevExpress.XtraGrid.GridControl()
    Me.GVStatTech = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GColTechVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColTechVPERPRE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.BtnPrint = New System.Windows.Forms.Button()
    Me.LblTitreTech = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.GCStatPerOpe = New DevExpress.XtraGrid.GridControl()
    Me.GVStatPerOpe = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GColPerOpeVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColPerOpeVPERPRE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCStatPerFonc = New DevExpress.XtraGrid.GridControl()
    Me.GVStatPerFonc = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GColPerFoncVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColPerFoncVPERPRE = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GCStatTech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStatTech, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCStatPerOpe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStatPerOpe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCStatPerFonc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStatPerFonc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCStatTech
        '
        resources.ApplyResources(Me.GCStatTech, "GCStatTech")
        Me.GCStatTech.MainView = Me.GVStatTech
        Me.GCStatTech.Name = "GCStatTech"
        Me.GCStatTech.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStatTech})
        '
        'GVStatTech
        '
        Me.GVStatTech.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVStatTech.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVStatTech.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVStatTech.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVStatTech.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStatTech.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStatTech.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColTechVPERNOM, Me.GColTechVPERPRE})
        Me.GVStatTech.GridControl = Me.GCStatTech
        Me.GVStatTech.Name = "GVStatTech"
        Me.GVStatTech.OptionsBehavior.Editable = False
        Me.GVStatTech.OptionsBehavior.ReadOnly = True
        Me.GVStatTech.OptionsView.ShowAutoFilterRow = True
        Me.GVStatTech.OptionsView.ShowFooter = True
        Me.GVStatTech.OptionsView.ShowGroupPanel = False
        '
        'GColTechVPERNOM
        '
        Me.GColTechVPERNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColTechVPERNOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColTechVPERNOM, "GColTechVPERNOM")
        Me.GColTechVPERNOM.FieldName = "VPERNOM"
        Me.GColTechVPERNOM.Name = "GColTechVPERNOM"
        Me.GColTechVPERNOM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GColTechVPERNOM.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("GColTechVPERNOM.Summary1"), resources.GetString("GColTechVPERNOM.Summary2"))})
        '
        'GColTechVPERPRE
        '
        Me.GColTechVPERPRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColTechVPERPRE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColTechVPERPRE, "GColTechVPERPRE")
        Me.GColTechVPERPRE.FieldName = "VPERPRE"
        Me.GColTechVPERPRE.Name = "GColTechVPERPRE"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
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
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'LblTitreTech
        '
        resources.ApplyResources(Me.LblTitreTech, "LblTitreTech")
        Me.LblTitreTech.Name = "LblTitreTech"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GCStatPerOpe
        '
        resources.ApplyResources(Me.GCStatPerOpe, "GCStatPerOpe")
        Me.GCStatPerOpe.MainView = Me.GVStatPerOpe
        Me.GCStatPerOpe.Name = "GCStatPerOpe"
        Me.GCStatPerOpe.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStatPerOpe})
        '
        'GVStatPerOpe
        '
        Me.GVStatPerOpe.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVStatPerOpe.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVStatPerOpe.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVStatPerOpe.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVStatPerOpe.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStatPerOpe.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStatPerOpe.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColPerOpeVPERNOM, Me.GColPerOpeVPERPRE})
        Me.GVStatPerOpe.GridControl = Me.GCStatPerOpe
        Me.GVStatPerOpe.Name = "GVStatPerOpe"
        Me.GVStatPerOpe.OptionsBehavior.Editable = False
        Me.GVStatPerOpe.OptionsBehavior.ReadOnly = True
        Me.GVStatPerOpe.OptionsView.ShowAutoFilterRow = True
        Me.GVStatPerOpe.OptionsView.ShowFooter = True
        Me.GVStatPerOpe.OptionsView.ShowGroupPanel = False
        '
        'GColPerOpeVPERNOM
        '
        Me.GColPerOpeVPERNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColPerOpeVPERNOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColPerOpeVPERNOM, "GColPerOpeVPERNOM")
        Me.GColPerOpeVPERNOM.FieldName = "VPERNOM"
        Me.GColPerOpeVPERNOM.Name = "GColPerOpeVPERNOM"
        Me.GColPerOpeVPERNOM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GColPerOpeVPERNOM.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("GColPerOpeVPERNOM.Summary1"), resources.GetString("GColPerOpeVPERNOM.Summary2"))})
        '
        'GColPerOpeVPERPRE
        '
        Me.GColPerOpeVPERPRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColPerOpeVPERPRE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColPerOpeVPERPRE, "GColPerOpeVPERPRE")
        Me.GColPerOpeVPERPRE.FieldName = "VPERPRE"
        Me.GColPerOpeVPERPRE.Name = "GColPerOpeVPERPRE"
        '
        'GCStatPerFonc
        '
        resources.ApplyResources(Me.GCStatPerFonc, "GCStatPerFonc")
        Me.GCStatPerFonc.MainView = Me.GVStatPerFonc
        Me.GCStatPerFonc.Name = "GCStatPerFonc"
        Me.GCStatPerFonc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStatPerFonc})
        '
        'GVStatPerFonc
        '
        Me.GVStatPerFonc.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVStatPerFonc.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVStatPerFonc.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVStatPerFonc.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVStatPerFonc.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStatPerFonc.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStatPerFonc.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColPerFoncVPERNOM, Me.GColPerFoncVPERPRE})
        Me.GVStatPerFonc.GridControl = Me.GCStatPerFonc
        Me.GVStatPerFonc.Name = "GVStatPerFonc"
        Me.GVStatPerFonc.OptionsBehavior.Editable = False
        Me.GVStatPerFonc.OptionsBehavior.ReadOnly = True
        Me.GVStatPerFonc.OptionsView.ShowAutoFilterRow = True
        Me.GVStatPerFonc.OptionsView.ShowFooter = True
        Me.GVStatPerFonc.OptionsView.ShowGroupPanel = False
        '
        'GColPerFoncVPERNOM
        '
        Me.GColPerFoncVPERNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColPerFoncVPERNOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColPerFoncVPERNOM, "GColPerFoncVPERNOM")
        Me.GColPerFoncVPERNOM.FieldName = "VPERNOM"
        Me.GColPerFoncVPERNOM.Name = "GColPerFoncVPERNOM"
        Me.GColPerFoncVPERNOM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GColPerFoncVPERNOM.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("GColPerFoncVPERNOM.Summary1"), resources.GetString("GColPerFoncVPERNOM.Summary2"))})
        '
        'GColPerFoncVPERPRE
        '
        Me.GColPerFoncVPERPRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColPerFoncVPERPRE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColPerFoncVPERPRE, "GColPerFoncVPERPRE")
        Me.GColPerFoncVPERPRE.FieldName = "VPERPRE"
        Me.GColPerFoncVPERPRE.Name = "GColPerFoncVPERPRE"
        '
        'frmStatRHChargeStruct_Details_Pers
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GCStatPerFonc)
        Me.Controls.Add(Me.GCStatPerOpe)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GCStatTech)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitreTech)
        Me.Name = "frmStatRHChargeStruct_Details_Pers"
        CType(Me.GCStatTech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStatTech, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCStatPerOpe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStatPerOpe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCStatPerFonc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStatPerFonc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents GCStatTech As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStatTech As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColTechVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColTechVPERPRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents LblTitreTech As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblTitre As Label
    Private WithEvents GCStatPerOpe As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStatPerOpe As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColPerOpeVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColPerOpeVPERPRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCStatPerFonc As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStatPerFonc As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColPerFoncVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColPerFoncVPERPRE As DevExpress.XtraGrid.Columns.GridColumn
End Class
