<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatComptaStructureDetail
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
        Me.GCStatDetail = New DevExpress.XtraGrid.GridControl()
        Me.GVStatDetail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColANNEE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailVPERPRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailVSOCIETE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailDPERENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailDPERSOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVDetailPers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GDetailPersColANNEE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetailPersColVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetailPersColVPERPRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetailPersColVSOCIETE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetailPersColDPERENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetailPersColDPERSOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        CType(Me.GCStatDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStatDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDetailPers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCStatDetail
        '
        Me.GCStatDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GCStatDetail.Location = New System.Drawing.Point(105, 45)
        Me.GCStatDetail.MainView = Me.GVStatDetail
        Me.GCStatDetail.Name = "GCStatDetail"
        Me.GCStatDetail.Size = New System.Drawing.Size(730, 348)
        Me.GCStatDetail.TabIndex = 37
        Me.GCStatDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStatDetail, Me.GVDetailPers})
        '
        'GVStatDetail
        '
        Me.GVStatDetail.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GVStatDetail.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVStatDetail.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVStatDetail.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStatDetail.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStatDetail.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVStatDetail.ColumnPanelRowHeight = 50
        Me.GVStatDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColANNEE, Me.GColDetailVPERNOM, Me.GColDetailVPERPRE, Me.GColDetailVSOCIETE, Me.GColDetailDPERENT, Me.GColDetailDPERSOR})
        Me.GVStatDetail.GridControl = Me.GCStatDetail
        Me.GVStatDetail.Name = "GVStatDetail"
        Me.GVStatDetail.OptionsBehavior.ReadOnly = True
        Me.GVStatDetail.OptionsCustomization.AllowGroup = False
        Me.GVStatDetail.OptionsPrint.PrintFilterInfo = True
        Me.GVStatDetail.OptionsView.ShowFooter = True
        Me.GVStatDetail.OptionsView.ShowGroupPanel = False
        '
        'GColANNEE
        '
        Me.GColANNEE.AppearanceCell.Options.UseTextOptions = True
        Me.GColANNEE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColANNEE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColANNEE.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColANNEE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColANNEE.AppearanceHeader.Options.UseForeColor = True
        Me.GColANNEE.Caption = "Année"
        Me.GColANNEE.FieldName = "ANNEE"
        Me.GColANNEE.MinWidth = 10
        Me.GColANNEE.Name = "GColANNEE"
        Me.GColANNEE.OptionsColumn.AllowEdit = False
        Me.GColANNEE.OptionsColumn.ReadOnly = True
        Me.GColANNEE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ANNEE", "Nb : {0}")})
        Me.GColANNEE.Visible = True
        Me.GColANNEE.VisibleIndex = 0
        Me.GColANNEE.Width = 100
        '
        'GColDetailVPERNOM
        '
        Me.GColDetailVPERNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDetailVPERNOM.AppearanceHeader.Options.UseForeColor = True
        Me.GColDetailVPERNOM.Caption = "Nom"
        Me.GColDetailVPERNOM.FieldName = "VPERNOM"
        Me.GColDetailVPERNOM.MinWidth = 100
        Me.GColDetailVPERNOM.Name = "GColDetailVPERNOM"
        Me.GColDetailVPERNOM.OptionsColumn.AllowEdit = False
        Me.GColDetailVPERNOM.OptionsColumn.ReadOnly = True
        Me.GColDetailVPERNOM.Visible = True
        Me.GColDetailVPERNOM.VisibleIndex = 1
        Me.GColDetailVPERNOM.Width = 150
        '
        'GColDetailVPERPRE
        '
        Me.GColDetailVPERPRE.AppearanceCell.Options.UseTextOptions = True
        Me.GColDetailVPERPRE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailVPERPRE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDetailVPERPRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDetailVPERPRE.AppearanceHeader.Options.UseForeColor = True
        Me.GColDetailVPERPRE.Caption = "Prénom"
        Me.GColDetailVPERPRE.FieldName = "VPERPRE"
        Me.GColDetailVPERPRE.Name = "GColDetailVPERPRE"
        Me.GColDetailVPERPRE.OptionsColumn.AllowEdit = False
        Me.GColDetailVPERPRE.OptionsColumn.ReadOnly = True
        Me.GColDetailVPERPRE.Visible = True
        Me.GColDetailVPERPRE.VisibleIndex = 2
        Me.GColDetailVPERPRE.Width = 161
        '
        'GColDetailVSOCIETE
        '
        Me.GColDetailVSOCIETE.AppearanceCell.Options.UseTextOptions = True
        Me.GColDetailVSOCIETE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailVSOCIETE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDetailVSOCIETE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDetailVSOCIETE.AppearanceHeader.Options.UseForeColor = True
        Me.GColDetailVSOCIETE.Caption = "Société"
        Me.GColDetailVSOCIETE.FieldName = "VSOCIETE"
        Me.GColDetailVSOCIETE.Name = "GColDetailVSOCIETE"
        Me.GColDetailVSOCIETE.OptionsColumn.AllowEdit = False
        Me.GColDetailVSOCIETE.OptionsColumn.ReadOnly = True
        Me.GColDetailVSOCIETE.Visible = True
        Me.GColDetailVSOCIETE.VisibleIndex = 3
        Me.GColDetailVSOCIETE.Width = 167
        '
        'GColDetailDPERENT
        '
        Me.GColDetailDPERENT.AppearanceCell.Options.UseTextOptions = True
        Me.GColDetailDPERENT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailDPERENT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDetailDPERENT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDetailDPERENT.AppearanceHeader.Options.UseForeColor = True
        Me.GColDetailDPERENT.Caption = "Date entrée"
        Me.GColDetailDPERENT.FieldName = "DPERENT"
        Me.GColDetailDPERENT.Name = "GColDetailDPERENT"
        Me.GColDetailDPERENT.OptionsColumn.AllowEdit = False
        Me.GColDetailDPERENT.OptionsColumn.ReadOnly = True
        Me.GColDetailDPERENT.Visible = True
        Me.GColDetailDPERENT.VisibleIndex = 4
        '
        'GColDetailDPERSOR
        '
        Me.GColDetailDPERSOR.AppearanceCell.Options.UseTextOptions = True
        Me.GColDetailDPERSOR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailDPERSOR.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDetailDPERSOR.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDetailDPERSOR.AppearanceHeader.Options.UseForeColor = True
        Me.GColDetailDPERSOR.Caption = "Date Sortie"
        Me.GColDetailDPERSOR.FieldName = "DPERSOR"
        Me.GColDetailDPERSOR.Name = "GColDetailDPERSOR"
        Me.GColDetailDPERSOR.OptionsColumn.AllowEdit = False
        Me.GColDetailDPERSOR.OptionsColumn.ReadOnly = True
        Me.GColDetailDPERSOR.Visible = True
        Me.GColDetailDPERSOR.VisibleIndex = 5
        '
        'GVDetailPers
        '
        Me.GVDetailPers.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVDetailPers.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVDetailPers.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVDetailPers.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVDetailPers.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVDetailPers.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVDetailPers.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GDetailPersColANNEE, Me.GDetailPersColVPERNOM, Me.GDetailPersColVPERPRE, Me.GDetailPersColVSOCIETE, Me.GDetailPersColDPERENT, Me.GDetailPersColDPERSOR})
        Me.GVDetailPers.GridControl = Me.GCStatDetail
        Me.GVDetailPers.Name = "GVDetailPers"
        Me.GVDetailPers.OptionsView.ShowGroupPanel = False
        '
        'GDetailPersColANNEE
        '
        Me.GDetailPersColANNEE.Caption = "ANNEE"
        Me.GDetailPersColANNEE.FieldName = "ANNEE"
        Me.GDetailPersColANNEE.Name = "GDetailPersColANNEE"
        Me.GDetailPersColANNEE.OptionsColumn.AllowEdit = False
        Me.GDetailPersColANNEE.OptionsColumn.ReadOnly = True
        '
        'GDetailPersColVPERNOM
        '
        Me.GDetailPersColVPERNOM.AppearanceCell.Options.UseTextOptions = True
        Me.GDetailPersColVPERNOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GDetailPersColVPERNOM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GDetailPersColVPERNOM.Caption = "Nom"
        Me.GDetailPersColVPERNOM.FieldName = "VPERNOM"
        Me.GDetailPersColVPERNOM.Name = "GDetailPersColVPERNOM"
        Me.GDetailPersColVPERNOM.OptionsColumn.AllowEdit = False
        Me.GDetailPersColVPERNOM.OptionsColumn.ReadOnly = True
        Me.GDetailPersColVPERNOM.Visible = True
        Me.GDetailPersColVPERNOM.VisibleIndex = 0
        '
        'GDetailPersColVPERPRE
        '
        Me.GDetailPersColVPERPRE.AppearanceCell.Options.UseTextOptions = True
        Me.GDetailPersColVPERPRE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GDetailPersColVPERPRE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GDetailPersColVPERPRE.Caption = "Prénom"
        Me.GDetailPersColVPERPRE.FieldName = "VPERPRE"
        Me.GDetailPersColVPERPRE.Name = "GDetailPersColVPERPRE"
        Me.GDetailPersColVPERPRE.OptionsColumn.AllowEdit = False
        Me.GDetailPersColVPERPRE.OptionsColumn.ReadOnly = True
        Me.GDetailPersColVPERPRE.Visible = True
        Me.GDetailPersColVPERPRE.VisibleIndex = 1
        '
        'GDetailPersColVSOCIETE
        '
        Me.GDetailPersColVSOCIETE.AppearanceCell.Options.UseTextOptions = True
        Me.GDetailPersColVSOCIETE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GDetailPersColVSOCIETE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GDetailPersColVSOCIETE.Caption = "Société"
        Me.GDetailPersColVSOCIETE.FieldName = "VSOCIETE"
        Me.GDetailPersColVSOCIETE.Name = "GDetailPersColVSOCIETE"
        Me.GDetailPersColVSOCIETE.OptionsColumn.AllowEdit = False
        Me.GDetailPersColVSOCIETE.OptionsColumn.ReadOnly = True
        Me.GDetailPersColVSOCIETE.Visible = True
        Me.GDetailPersColVSOCIETE.VisibleIndex = 2
        '
        'GDetailPersColDPERENT
        '
        Me.GDetailPersColDPERENT.AppearanceCell.Options.UseTextOptions = True
        Me.GDetailPersColDPERENT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GDetailPersColDPERENT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GDetailPersColDPERENT.Caption = "Date entrée"
        Me.GDetailPersColDPERENT.FieldName = "DPERENT"
        Me.GDetailPersColDPERENT.Name = "GDetailPersColDPERENT"
        Me.GDetailPersColDPERENT.OptionsColumn.AllowEdit = False
        Me.GDetailPersColDPERENT.OptionsColumn.ReadOnly = True
        Me.GDetailPersColDPERENT.Visible = True
        Me.GDetailPersColDPERENT.VisibleIndex = 3
        '
        'GDetailPersColDPERSOR
        '
        Me.GDetailPersColDPERSOR.AppearanceCell.Options.UseTextOptions = True
        Me.GDetailPersColDPERSOR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GDetailPersColDPERSOR.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GDetailPersColDPERSOR.Caption = "Date sortie"
        Me.GDetailPersColDPERSOR.FieldName = "DPERSOR"
        Me.GDetailPersColDPERSOR.Name = "GDetailPersColDPERSOR"
        Me.GDetailPersColDPERSOR.OptionsColumn.AllowEdit = False
        Me.GDetailPersColDPERSOR.OptionsColumn.ReadOnly = True
        Me.GDetailPersColDPERSOR.Visible = True
        Me.GDetailPersColDPERSOR.VisibleIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(87, 381)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(6, 314)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelTitre.Location = New System.Drawing.Point(105, 12)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(387, 19)
        Me.LabelTitre.TabIndex = 35
        Me.LabelTitre.Text = "Statistique : Comptabilité Structure Toutes filiales "
        '
        'frmStatComptaStructureDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(847, 401)
        Me.Controls.Add(Me.GCStatDetail)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "frmStatComptaStructureDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Statistique Comptabilité Structure - Détail"
        CType(Me.GCStatDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStatDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDetailPers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents GCStatDetail As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStatDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColANNEE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColDetailVPERPRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColDetailVSOCIETE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVDetailPers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GDetailPersColANNEE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GDetailPersColVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GDetailPersColVPERPRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GDetailPersColVSOCIETE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GDetailPersColDPERENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GDetailPersColDPERSOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents GColDetailDPERENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColDetailDPERSOR As DevExpress.XtraGrid.Columns.GridColumn
End Class
