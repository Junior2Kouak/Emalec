<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCVillesCibles
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCVillesCibles))
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GCVILLESCIBLES = New DevExpress.XtraGrid.GridControl()
        Me.GVVILLESCIBLES = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColVillesCiblesCOLORREG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVillesCiblesID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVillesCiblesREGION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVillesCiblesVILLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVillesCiblesCOCHE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkCOCHE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        CType(Me.GCVILLESCIBLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVVILLESCIBLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkCOCHE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.ForeColor = System.Drawing.Color.IndianRed
        Me.LblTitre.Name = "LblTitre"
        '
        'GCVILLESCIBLES
        '
        resources.ApplyResources(Me.GCVILLESCIBLES, "GCVILLESCIBLES")
        Me.GCVILLESCIBLES.MainView = Me.GVVILLESCIBLES
        Me.GCVILLESCIBLES.Name = "GCVILLESCIBLES"
        Me.GCVILLESCIBLES.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChkCOCHE})
        Me.GCVILLESCIBLES.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVVILLESCIBLES})
        '
        'GVVILLESCIBLES
        '
        Me.GVVILLESCIBLES.ColumnPanelRowHeight = 40
        Me.GVVILLESCIBLES.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColVillesCiblesCOLORREG, Me.GColVillesCiblesID, Me.GColVillesCiblesREGION, Me.GColVillesCiblesVILLE, Me.GColVillesCiblesCOCHE})
        Me.GVVILLESCIBLES.GridControl = Me.GCVILLESCIBLES
        Me.GVVILLESCIBLES.Name = "GVVILLESCIBLES"
        Me.GVVILLESCIBLES.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVVILLESCIBLES.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GVVILLESCIBLES.OptionsSelection.EnableAppearanceHideSelection = False
        Me.GVVILLESCIBLES.OptionsView.ShowAutoFilterRow = True
        Me.GVVILLESCIBLES.OptionsView.ShowGroupPanel = False
        '
        'GColVillesCiblesCOLORREG
        '
        resources.ApplyResources(Me.GColVillesCiblesCOLORREG, "GColVillesCiblesCOLORREG")
        Me.GColVillesCiblesCOLORREG.FieldName = "COLORREG"
        Me.GColVillesCiblesCOLORREG.Name = "GColVillesCiblesCOLORREG"
        '
        'GColVillesCiblesID
        '
        resources.ApplyResources(Me.GColVillesCiblesID, "GColVillesCiblesID")
        Me.GColVillesCiblesID.Name = "GColVillesCiblesID"
        '
        'GColVillesCiblesREGION
        '
        Me.GColVillesCiblesREGION.AppearanceCell.Font = CType(resources.GetObject("GColVillesCiblesREGION.AppearanceCell.Font"), System.Drawing.Font)
        Me.GColVillesCiblesREGION.AppearanceCell.Options.UseFont = True
        Me.GColVillesCiblesREGION.AppearanceCell.Options.UseTextOptions = True
        Me.GColVillesCiblesREGION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVillesCiblesREGION.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVillesCiblesREGION.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColVillesCiblesREGION.AppearanceHeader.Font = CType(resources.GetObject("GColVillesCiblesREGION.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVillesCiblesREGION.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVillesCiblesREGION.AppearanceHeader.Options.UseFont = True
        Me.GColVillesCiblesREGION.AppearanceHeader.Options.UseForeColor = True
        Me.GColVillesCiblesREGION.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVillesCiblesREGION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVillesCiblesREGION.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVillesCiblesREGION.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVillesCiblesREGION, "GColVillesCiblesREGION")
        Me.GColVillesCiblesREGION.FieldName = "REGION"
        Me.GColVillesCiblesREGION.Name = "GColVillesCiblesREGION"
        Me.GColVillesCiblesREGION.OptionsColumn.AllowEdit = False
        Me.GColVillesCiblesREGION.OptionsColumn.ReadOnly = True
        Me.GColVillesCiblesREGION.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVillesCiblesVILLE
        '
        Me.GColVillesCiblesVILLE.AppearanceCell.Font = CType(resources.GetObject("GColVillesCiblesVILLE.AppearanceCell.Font"), System.Drawing.Font)
        Me.GColVillesCiblesVILLE.AppearanceCell.Options.UseFont = True
        Me.GColVillesCiblesVILLE.AppearanceCell.Options.UseTextOptions = True
        Me.GColVillesCiblesVILLE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVillesCiblesVILLE.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColVillesCiblesVILLE.AppearanceHeader.Font = CType(resources.GetObject("GColVillesCiblesVILLE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVillesCiblesVILLE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVillesCiblesVILLE.AppearanceHeader.Options.UseFont = True
        Me.GColVillesCiblesVILLE.AppearanceHeader.Options.UseForeColor = True
        Me.GColVillesCiblesVILLE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVillesCiblesVILLE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVillesCiblesVILLE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVillesCiblesVILLE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        resources.ApplyResources(Me.GColVillesCiblesVILLE, "GColVillesCiblesVILLE")
        Me.GColVillesCiblesVILLE.FieldName = "VILLE"
        Me.GColVillesCiblesVILLE.Name = "GColVillesCiblesVILLE"
        Me.GColVillesCiblesVILLE.OptionsColumn.AllowEdit = False
        Me.GColVillesCiblesVILLE.OptionsColumn.ReadOnly = True
        Me.GColVillesCiblesVILLE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVillesCiblesCOCHE
        '
        Me.GColVillesCiblesCOCHE.AppearanceHeader.Font = CType(resources.GetObject("GColVillesCiblesCOCHE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVillesCiblesCOCHE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVillesCiblesCOCHE.AppearanceHeader.Options.UseFont = True
        Me.GColVillesCiblesCOCHE.AppearanceHeader.Options.UseForeColor = True
        Me.GColVillesCiblesCOCHE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVillesCiblesCOCHE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVillesCiblesCOCHE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVillesCiblesCOCHE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVillesCiblesCOCHE, "GColVillesCiblesCOCHE")
        Me.GColVillesCiblesCOCHE.ColumnEdit = Me.RepItemChkCOCHE
        Me.GColVillesCiblesCOCHE.FieldName = "COCHE"
        Me.GColVillesCiblesCOCHE.Name = "GColVillesCiblesCOCHE"
        '
        'RepItemChkCOCHE
        '
        resources.ApplyResources(Me.RepItemChkCOCHE, "RepItemChkCOCHE")
        Me.RepItemChkCOCHE.Name = "RepItemChkCOCHE"
        Me.RepItemChkCOCHE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChkCOCHE.ValueChecked = 1
        Me.RepItemChkCOCHE.ValueUnchecked = 0
        '
        'UCVillesCibles
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Controls.Add(Me.GCVILLESCIBLES)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "UCVillesCibles"
        CType(Me.GCVILLESCIBLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVVILLESCIBLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkCOCHE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GCVILLESCIBLES As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVVILLESCIBLES As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GColVillesCiblesID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVillesCiblesREGION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVillesCiblesVILLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVillesCiblesCOCHE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemChkCOCHE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GColVillesCiblesCOLORREG As DevExpress.XtraGrid.Columns.GridColumn

End Class
