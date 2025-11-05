<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectDIByTech
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
        Me.GCListeActTech24M = New DevExpress.XtraGrid.GridControl()
        Me.GVListeActTech24M = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColVDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVACTDES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDACTPLA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNACTNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVListeEIReapproDetail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColDetailVLART = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailNLARTQTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpBoxActions = New System.Windows.Forms.GroupBox()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        CType(Me.GCListeActTech24M, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeActTech24M, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeEIReapproDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCListeActTech24M
        '
        Me.GCListeActTech24M.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GCListeActTech24M.Location = New System.Drawing.Point(110, 43)
        Me.GCListeActTech24M.MainView = Me.GVListeActTech24M
        Me.GCListeActTech24M.Name = "GCListeActTech24M"
        Me.GCListeActTech24M.Size = New System.Drawing.Size(1110, 352)
        Me.GCListeActTech24M.TabIndex = 44
        Me.GCListeActTech24M.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeActTech24M, Me.GVListeEIReapproDetail})
        '
        'GVListeActTech24M
        '
        Me.GVListeActTech24M.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListeActTech24M.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeActTech24M.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeActTech24M.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeActTech24M.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeActTech24M.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListeActTech24M.ColumnPanelRowHeight = 50
        Me.GVListeActTech24M.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColVDINNUM, Me.GColVCLINOM, Me.GColVSITNOM, Me.GColVACTDES, Me.GColDACTPLA, Me.GColNACTNUM, Me.GColNDINNUM})
        Me.GVListeActTech24M.GridControl = Me.GCListeActTech24M
        Me.GVListeActTech24M.Name = "GVListeActTech24M"
        Me.GVListeActTech24M.OptionsBehavior.ReadOnly = True
        Me.GVListeActTech24M.OptionsCustomization.AllowGroup = False
        Me.GVListeActTech24M.OptionsDetail.ShowDetailTabs = False
        Me.GVListeActTech24M.OptionsPrint.PrintFilterInfo = True
        Me.GVListeActTech24M.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListeActTech24M.OptionsView.EnableAppearanceOddRow = True
        Me.GVListeActTech24M.OptionsView.ShowAutoFilterRow = True
        Me.GVListeActTech24M.OptionsView.ShowFooter = True
        Me.GVListeActTech24M.OptionsView.ShowGroupPanel = False
        '
        'GColVDINNUM
        '
        Me.GColVDINNUM.AppearanceCell.Options.UseFont = True
        Me.GColVDINNUM.AppearanceCell.Options.UseTextOptions = True
        Me.GColVDINNUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVDINNUM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVDINNUM.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColVDINNUM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GColVDINNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVDINNUM.AppearanceHeader.Options.UseForeColor = True
        Me.GColVDINNUM.Caption = "N° DI"
        Me.GColVDINNUM.FieldName = "VDINNUM"
        Me.GColVDINNUM.MinWidth = 10
        Me.GColVDINNUM.Name = "GColVDINNUM"
        Me.GColVDINNUM.OptionsColumn.AllowEdit = False
        Me.GColVDINNUM.OptionsColumn.ReadOnly = True
        Me.GColVDINNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVDINNUM.Visible = True
        Me.GColVDINNUM.VisibleIndex = 0
        Me.GColVDINNUM.Width = 99
        '
        'GColVCLINOM
        '
        Me.GColVCLINOM.AppearanceCell.Options.UseTextOptions = True
        Me.GColVCLINOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVCLINOM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVCLINOM.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColVCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVCLINOM.AppearanceHeader.Options.UseForeColor = True
        Me.GColVCLINOM.Caption = "Client"
        Me.GColVCLINOM.FieldName = "VCLINOM"
        Me.GColVCLINOM.Name = "GColVCLINOM"
        Me.GColVCLINOM.OptionsColumn.AllowEdit = False
        Me.GColVCLINOM.OptionsColumn.ReadOnly = True
        Me.GColVCLINOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVCLINOM.Visible = True
        Me.GColVCLINOM.VisibleIndex = 1
        Me.GColVCLINOM.Width = 159
        '
        'GColVSITNOM
        '
        Me.GColVSITNOM.AppearanceCell.Options.UseTextOptions = True
        Me.GColVSITNOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVSITNOM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVSITNOM.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColVSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVSITNOM.AppearanceHeader.Options.UseForeColor = True
        Me.GColVSITNOM.Caption = "Site"
        Me.GColVSITNOM.FieldName = "VSITNOM"
        Me.GColVSITNOM.Name = "GColVSITNOM"
        Me.GColVSITNOM.OptionsColumn.AllowEdit = False
        Me.GColVSITNOM.OptionsColumn.ReadOnly = True
        Me.GColVSITNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVSITNOM.Visible = True
        Me.GColVSITNOM.VisibleIndex = 2
        Me.GColVSITNOM.Width = 159
        '
        'GColVACTDES
        '
        Me.GColVACTDES.AppearanceCell.Options.UseTextOptions = True
        Me.GColVACTDES.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVACTDES.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColVACTDES.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVACTDES.AppearanceHeader.Options.UseForeColor = True
        Me.GColVACTDES.Caption = "Description action"
        Me.GColVACTDES.FieldName = "VACTDES"
        Me.GColVACTDES.Name = "GColVACTDES"
        Me.GColVACTDES.OptionsColumn.AllowEdit = False
        Me.GColVACTDES.OptionsColumn.ReadOnly = True
        Me.GColVACTDES.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVACTDES.Visible = True
        Me.GColVACTDES.VisibleIndex = 3
        Me.GColVACTDES.Width = 108
        '
        'GColDACTPLA
        '
        Me.GColDACTPLA.AppearanceCell.Options.UseTextOptions = True
        Me.GColDACTPLA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDACTPLA.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDACTPLA.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColDACTPLA.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDACTPLA.AppearanceHeader.Options.UseForeColor = True
        Me.GColDACTPLA.Caption = "Date planification"
        Me.GColDACTPLA.FieldName = "DACTPLA"
        Me.GColDACTPLA.Name = "GColDACTPLA"
        Me.GColDACTPLA.OptionsColumn.AllowEdit = False
        Me.GColDACTPLA.OptionsColumn.ReadOnly = True
        Me.GColDACTPLA.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColDACTPLA.Visible = True
        Me.GColDACTPLA.VisibleIndex = 4
        Me.GColDACTPLA.Width = 121
        '
        'GColNACTNUM
        '
        Me.GColNACTNUM.Caption = "NACTNUM"
        Me.GColNACTNUM.FieldName = "NACTNUM"
        Me.GColNACTNUM.Name = "GColNACTNUM"
        '
        'GColNDINNUM
        '
        Me.GColNDINNUM.Caption = "NDINNUM"
        Me.GColNDINNUM.FieldName = "NDINNUM"
        Me.GColNDINNUM.Name = "GColNDINNUM"
        '
        'GVListeEIReapproDetail
        '
        Me.GVListeEIReapproDetail.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListeEIReapproDetail.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeEIReapproDetail.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeEIReapproDetail.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeEIReapproDetail.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeEIReapproDetail.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.Options.UseBackColor = True
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.Options.UseFont = True
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListeEIReapproDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColDetailVLART, Me.GColDetailNLARTQTE})
        Me.GVListeEIReapproDetail.GridControl = Me.GCListeActTech24M
        Me.GVListeEIReapproDetail.Name = "GVListeEIReapproDetail"
        Me.GVListeEIReapproDetail.OptionsDetail.ShowDetailTabs = False
        Me.GVListeEIReapproDetail.OptionsView.ShowAutoFilterRow = True
        Me.GVListeEIReapproDetail.OptionsView.ShowGroupPanel = False
        Me.GVListeEIReapproDetail.OptionsView.ShowViewCaption = True
        Me.GVListeEIReapproDetail.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'GColDetailVLART
        '
        Me.GColDetailVLART.Caption = "Fournitures livrées"
        Me.GColDetailVLART.FieldName = "VLART"
        Me.GColDetailVLART.Name = "GColDetailVLART"
        Me.GColDetailVLART.Visible = True
        Me.GColDetailVLART.VisibleIndex = 0
        Me.GColDetailVLART.Width = 500
        '
        'GColDetailNLARTQTE
        '
        Me.GColDetailNLARTQTE.Caption = "Quantité"
        Me.GColDetailNLARTQTE.FieldName = "NLARTQTE"
        Me.GColDetailNLARTQTE.Name = "GColDetailNLARTQTE"
        Me.GColDetailNLARTQTE.Visible = True
        Me.GColDetailNLARTQTE.VisibleIndex = 1
        '
        'GrpBoxActions
        '
        Me.GrpBoxActions.Controls.Add(Me.BtnValid)
        Me.GrpBoxActions.Controls.Add(Me.BtnFermer)
        Me.GrpBoxActions.Location = New System.Drawing.Point(12, 35)
        Me.GrpBoxActions.Name = "GrpBoxActions"
        Me.GrpBoxActions.Size = New System.Drawing.Size(92, 360)
        Me.GrpBoxActions.TabIndex = 43
        Me.GrpBoxActions.TabStop = False
        '
        'BtnValid
        '
        Me.BtnValid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnValid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnValid.Location = New System.Drawing.Point(8, 19)
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.Size = New System.Drawing.Size(75, 53)
        Me.BtnValid.TabIndex = 4
        Me.BtnValid.Text = "Valider"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(8, 297)
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
        Me.LabelTitre.Location = New System.Drawing.Point(106, 9)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(465, 19)
        Me.LabelTitre.TabIndex = 42
        Me.LabelTitre.Text = "Liste des interventions du technicien sur les 24 dernier mois"
        '
        'frmSelectDIByTech
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1232, 408)
        Me.Controls.Add(Me.GCListeActTech24M)
        Me.Controls.Add(Me.GrpBoxActions)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "frmSelectDIByTech"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des interventions du technicien sur les 24 dernier mois"
        CType(Me.GCListeActTech24M, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeActTech24M, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeEIReapproDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxActions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents GCListeActTech24M As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeActTech24M As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColVDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVACTDES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColDACTPLA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNACTNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVListeEIReapproDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColDetailVLART As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailNLARTQTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrpBoxActions As GroupBox
    Friend WithEvents BtnValid As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents LabelTitre As Label
    Friend WithEvents GColNDINNUM As DevExpress.XtraGrid.Columns.GridColumn
End Class
