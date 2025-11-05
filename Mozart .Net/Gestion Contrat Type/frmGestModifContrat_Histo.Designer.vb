<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestModifContrat_Histo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestModifContrat_Histo))
        Me.GCHisto_Modif = New DevExpress.XtraGrid.GridControl()
        Me.GVHisto_Modif = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNIDPERTYPECONTHISTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDDATEMODIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVTECHNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCONTDOMLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVTYPEOPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVPERNOMMODIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemCboOrder = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.GrpboxActions = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        CType(Me.GCHisto_Modif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVHisto_Modif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemCboOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpboxActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCHisto_Modif
        '
        resources.ApplyResources(Me.GCHisto_Modif, "GCHisto_Modif")
        Me.GCHisto_Modif.MainView = Me.GVHisto_Modif
        Me.GCHisto_Modif.Name = "GCHisto_Modif"
        Me.GCHisto_Modif.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemCboOrder})
        Me.GCHisto_Modif.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVHisto_Modif})
        '
        'GVHisto_Modif
        '
        Me.GVHisto_Modif.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVHisto_Modif.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVHisto_Modif.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVHisto_Modif.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVHisto_Modif.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVHisto_Modif.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVHisto_Modif.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVHisto_Modif.Appearance.Row.BackColor = System.Drawing.Color.LightCyan
        Me.GVHisto_Modif.Appearance.Row.Options.UseBackColor = True
        Me.GVHisto_Modif.Appearance.SelectedRow.BackColor = System.Drawing.Color.Gainsboro
        Me.GVHisto_Modif.Appearance.SelectedRow.Font = CType(resources.GetObject("GVHisto_Modif.Appearance.SelectedRow.Font"), System.Drawing.Font)
        Me.GVHisto_Modif.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVHisto_Modif.Appearance.SelectedRow.Options.UseFont = True
        Me.GVHisto_Modif.ColumnPanelRowHeight = 30
        Me.GVHisto_Modif.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNIDPERTYPECONTHISTO, Me.GColDDATEMODIF, Me.GColVTECHNOM, Me.GColVCONTDOMLIB, Me.GColVTYPECONTRAT, Me.GColVTYPEOPE, Me.GColVPERNOMMODIF})
        Me.GVHisto_Modif.GridControl = Me.GCHisto_Modif
        Me.GVHisto_Modif.Name = "GVHisto_Modif"
        Me.GVHisto_Modif.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVHisto_Modif.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVHisto_Modif.OptionsBehavior.Editable = False
        Me.GVHisto_Modif.OptionsBehavior.ReadOnly = True
        Me.GVHisto_Modif.OptionsCustomization.AllowSort = False
        Me.GVHisto_Modif.OptionsView.ShowAutoFilterRow = True
        Me.GVHisto_Modif.OptionsView.ShowGroupPanel = False
        '
        'GColNIDPERTYPECONTHISTO
        '
        resources.ApplyResources(Me.GColNIDPERTYPECONTHISTO, "GColNIDPERTYPECONTHISTO")
        Me.GColNIDPERTYPECONTHISTO.FieldName = "NIDPERTYPECONTHISTO"
        Me.GColNIDPERTYPECONTHISTO.Name = "GColNIDPERTYPECONTHISTO"
        '
        'GColDDATEMODIF
        '
        Me.GColDDATEMODIF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDDATEMODIF.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColDDATEMODIF, "GColDDATEMODIF")
        Me.GColDDATEMODIF.FieldName = "DDATEMODIF"
        Me.GColDDATEMODIF.Name = "GColDDATEMODIF"
        '
        'GColVTECHNOM
        '
        Me.GColVTECHNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVTECHNOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVTECHNOM, "GColVTECHNOM")
        Me.GColVTECHNOM.FieldName = "VTECHNOM"
        Me.GColVTECHNOM.Name = "GColVTECHNOM"
        '
        'GColVCONTDOMLIB
        '
        Me.GColVCONTDOMLIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVCONTDOMLIB.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVCONTDOMLIB, "GColVCONTDOMLIB")
        Me.GColVCONTDOMLIB.FieldName = "VCONTDOMLIB"
        Me.GColVCONTDOMLIB.Name = "GColVCONTDOMLIB"
        '
        'GColVTYPECONTRAT
        '
        Me.GColVTYPECONTRAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVTYPECONTRAT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVTYPECONTRAT, "GColVTYPECONTRAT")
        Me.GColVTYPECONTRAT.FieldName = "VTYPECONTRAT"
        Me.GColVTYPECONTRAT.Name = "GColVTYPECONTRAT"
        '
        'GColVTYPEOPE
        '
        Me.GColVTYPEOPE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVTYPEOPE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVTYPEOPE, "GColVTYPEOPE")
        Me.GColVTYPEOPE.FieldName = "VTYPEOPE"
        Me.GColVTYPEOPE.Name = "GColVTYPEOPE"
        '
        'GColVPERNOMMODIF
        '
        Me.GColVPERNOMMODIF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVPERNOMMODIF.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVPERNOMMODIF, "GColVPERNOMMODIF")
        Me.GColVPERNOMMODIF.FieldName = "VPERNOMMODIF"
        Me.GColVPERNOMMODIF.Name = "GColVPERNOMMODIF"
        '
        'RepItemCboOrder
        '
        Me.RepItemCboOrder.Appearance.Font = CType(resources.GetObject("RepItemCboOrder.Appearance.Font"), System.Drawing.Font)
        Me.RepItemCboOrder.Appearance.Options.UseFont = True
        Me.RepItemCboOrder.Appearance.Options.UseTextOptions = True
        Me.RepItemCboOrder.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepItemCboOrder.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.RepItemCboOrder.AppearanceDropDown.BackColor = System.Drawing.Color.PaleGreen
        Me.RepItemCboOrder.AppearanceDropDown.Font = CType(resources.GetObject("RepItemCboOrder.AppearanceDropDown.Font"), System.Drawing.Font)
        Me.RepItemCboOrder.AppearanceDropDown.Options.UseBackColor = True
        Me.RepItemCboOrder.AppearanceDropDown.Options.UseFont = True
        Me.RepItemCboOrder.AppearanceDropDown.Options.UseTextOptions = True
        Me.RepItemCboOrder.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.RepItemCboOrder, "RepItemCboOrder")
        Me.RepItemCboOrder.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemCboOrder.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepItemCboOrder.Name = "RepItemCboOrder"
        '
        'GrpboxActions
        '
        Me.GrpboxActions.Controls.Add(Me.BtnClose)
        resources.ApplyResources(Me.GrpboxActions, "GrpboxActions")
        Me.GrpboxActions.Name = "GrpboxActions"
        Me.GrpboxActions.TabStop = False
        '
        'BtnClose
        '
        resources.ApplyResources(Me.BtnClose, "BtnClose")
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'frmGestModifContrat_Histo
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GCHisto_Modif)
        Me.Controls.Add(Me.GrpboxActions)
        Me.Name = "frmGestModifContrat_Histo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCHisto_Modif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVHisto_Modif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemCboOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpboxActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpboxActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Private WithEvents GCHisto_Modif As DevExpress.XtraGrid.GridControl
    Private WithEvents GVHisto_Modif As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents RepItemCboOrder As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Private WithEvents GColNIDPERTYPECONTHISTO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDDATEMODIF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVTECHNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCONTDOMLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVTYPEOPE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVPERNOMMODIF As DevExpress.XtraGrid.Columns.GridColumn
End Class
