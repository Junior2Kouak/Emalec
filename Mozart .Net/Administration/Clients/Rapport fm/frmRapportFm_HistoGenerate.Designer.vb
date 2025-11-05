<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRapportFm_HistoGenerate
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
        Me.GCListeRapportFM = New DevExpress.XtraGrid.GridControl()
        Me.GVListeRapportFM = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_DATCREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_DATSEND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VMAILDEST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GCListeRapportFM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeRapportFM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCListeRapportFM
        '
        Me.GCListeRapportFM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCListeRapportFM.Location = New System.Drawing.Point(0, 0)
        Me.GCListeRapportFM.MainView = Me.GVListeRapportFM
        Me.GCListeRapportFM.Name = "GCListeRapportFM"
        Me.GCListeRapportFM.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1})
        Me.GCListeRapportFM.Size = New System.Drawing.Size(730, 562)
        Me.GCListeRapportFM.TabIndex = 14
        Me.GCListeRapportFM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeRapportFM})
        '
        'GVListeRapportFM
        '
        Me.GVListeRapportFM.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListeRapportFM.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeRapportFM.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeRapportFM.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeRapportFM.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeRapportFM.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListeRapportFM.ColumnPanelRowHeight = 60
        Me.GVListeRapportFM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_DATCREE, Me.GCol_DATSEND, Me.GCol_VMAILDEST, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.GVListeRapportFM.GridControl = Me.GCListeRapportFM
        Me.GVListeRapportFM.Name = "GVListeRapportFM"
        Me.GVListeRapportFM.OptionsBehavior.ReadOnly = True
        Me.GVListeRapportFM.OptionsView.ShowAutoFilterRow = True
        Me.GVListeRapportFM.OptionsView.ShowGroupPanel = False
        '
        'GCol_DATCREE
        '
        Me.GCol_DATCREE.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_DATCREE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_DATCREE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_DATCREE.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GCol_DATCREE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_DATCREE.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_DATCREE.Caption = "Date génération"
        Me.GCol_DATCREE.FieldName = "DATCREE"
        Me.GCol_DATCREE.Name = "GCol_DATCREE"
        Me.GCol_DATCREE.OptionsColumn.AllowEdit = False
        Me.GCol_DATCREE.OptionsColumn.ReadOnly = True
        Me.GCol_DATCREE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_DATCREE.Visible = True
        Me.GCol_DATCREE.VisibleIndex = 0
        Me.GCol_DATCREE.Width = 130
        '
        'GCol_DATSEND
        '
        Me.GCol_DATSEND.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_DATSEND.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_DATSEND.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_DATSEND.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GCol_DATSEND.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_DATSEND.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_DATSEND.Caption = "Date envoi"
        Me.GCol_DATSEND.FieldName = "DATSEND"
        Me.GCol_DATSEND.Name = "GCol_DATSEND"
        Me.GCol_DATSEND.OptionsColumn.AllowEdit = False
        Me.GCol_DATSEND.OptionsColumn.ReadOnly = True
        Me.GCol_DATSEND.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_DATSEND.Visible = True
        Me.GCol_DATSEND.VisibleIndex = 2
        Me.GCol_DATSEND.Width = 118
        '
        'GCol_VMAILDEST
        '
        Me.GCol_VMAILDEST.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VMAILDEST.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VMAILDEST.Caption = "Destinataire(s)"
        Me.GCol_VMAILDEST.FieldName = "VMAILDEST"
        Me.GCol_VMAILDEST.Name = "GCol_VMAILDEST"
        Me.GCol_VMAILDEST.Visible = True
        Me.GCol_VMAILDEST.VisibleIndex = 1
        Me.GCol_VMAILDEST.Width = 157
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn1.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn1.Caption = "Type"
        Me.GridColumn1.FieldName = "CTYPE"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        Me.GridColumn1.Width = 98
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn2.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn2.Caption = "Etat"
        Me.GridColumn2.FieldName = "VETAT"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        Me.GridColumn2.Width = 98
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn3.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn3.Caption = "Erreur"
        Me.GridColumn3.FieldName = "BERROR"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 5
        Me.GridColumn3.Width = 104
        '
        'frmRapportFm_HistoGenerate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 562)
        Me.Controls.Add(Me.GCListeRapportFM)
        Me.Name = "frmRapportFm_HistoGenerate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmRapportFm_HistoGenerate"
        CType(Me.GCListeRapportFM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeRapportFM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents GCListeRapportFM As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeRapportFM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCol_DATCREE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_DATSEND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VMAILDEST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
End Class
