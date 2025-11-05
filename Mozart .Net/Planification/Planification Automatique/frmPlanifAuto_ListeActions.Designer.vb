<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanifAuto_ListeActions
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.GCol_CETACOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCListeActions = New DevExpress.XtraGrid.GridControl()
        Me.GVListeActions = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNCOCHE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEditCHECK = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GColNACTNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDACTDATCRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVDINCHAFF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNACTDUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSITCP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSITVIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSITREG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSITPAYS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVACTDES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDACTDAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VETALIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnCocheTS = New System.Windows.Forms.Button()
        Me.BtnDecocheTS = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.GCListeActions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeActions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEditCHECK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCol_CETACOD
        '
        Me.GCol_CETACOD.Caption = "CETACOD"
        Me.GCol_CETACOD.FieldName = "CETACOD"
        Me.GCol_CETACOD.Name = "GCol_CETACOD"
        '
        'GCListeActions
        '
        Me.GCListeActions.Location = New System.Drawing.Point(40, 66)
        Me.GCListeActions.MainView = Me.GVListeActions
        Me.GCListeActions.Name = "GCListeActions"
        Me.GCListeActions.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEditCHECK})
        Me.GCListeActions.Size = New System.Drawing.Size(1059, 498)
        Me.GCListeActions.TabIndex = 0
        Me.GCListeActions.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeActions})
        '
        'GVListeActions
        '
        Me.GVListeActions.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNCOCHE, Me.GColNACTNUM, Me.GColNDINNUM, Me.GColDACTDATCRE, Me.GColVCLINOM, Me.GColVSITNOM, Me.GColVDINCHAFF, Me.GColNACTDUR, Me.GColVSITCP, Me.GColVSITVIL, Me.GColVSITREG, Me.GColVSITPAYS, Me.GColVACTDES, Me.GColDACTDAT, Me.GCol_CETACOD, Me.GCol_VETALIB})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.GCol_CETACOD
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.Red
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue1.Expression = "[CETACOD] <> 'O'"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.GVListeActions.FormatRules.Add(GridFormatRule1)
        Me.GVListeActions.GridControl = Me.GCListeActions
        Me.GVListeActions.Name = "GVListeActions"
        Me.GVListeActions.OptionsView.ShowAutoFilterRow = True
        Me.GVListeActions.OptionsView.ShowFooter = True
        Me.GVListeActions.OptionsView.ShowGroupPanel = False
        '
        'GColNCOCHE
        '
        Me.GColNCOCHE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNCOCHE.AppearanceHeader.Options.UseForeColor = True
        Me.GColNCOCHE.Caption = "Sélectionner"
        Me.GColNCOCHE.ColumnEdit = Me.RepositoryItemCheckEditCHECK
        Me.GColNCOCHE.FieldName = "NCOCHE"
        Me.GColNCOCHE.Name = "GColNCOCHE"
        Me.GColNCOCHE.Visible = True
        Me.GColNCOCHE.VisibleIndex = 0
        '
        'RepositoryItemCheckEditCHECK
        '
        Me.RepositoryItemCheckEditCHECK.AutoHeight = False
        Me.RepositoryItemCheckEditCHECK.Name = "RepositoryItemCheckEditCHECK"
        Me.RepositoryItemCheckEditCHECK.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEditCHECK.ValueChecked = 1
        Me.RepositoryItemCheckEditCHECK.ValueUnchecked = 0
        '
        'GColNACTNUM
        '
        Me.GColNACTNUM.Caption = "NACTNUM"
        Me.GColNACTNUM.FieldName = "NACTNUM"
        Me.GColNACTNUM.Name = "GColNACTNUM"
        '
        'GColNDINNUM
        '
        Me.GColNDINNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNDINNUM.AppearanceHeader.Options.UseForeColor = True
        Me.GColNDINNUM.Caption = "N° DI"
        Me.GColNDINNUM.FieldName = "NDINNUM"
        Me.GColNDINNUM.Name = "GColNDINNUM"
        Me.GColNDINNUM.OptionsColumn.AllowEdit = False
        Me.GColNDINNUM.OptionsColumn.ReadOnly = True
        Me.GColNDINNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColNDINNUM.Visible = True
        Me.GColNDINNUM.VisibleIndex = 1
        '
        'GColDACTDATCRE
        '
        Me.GColDACTDATCRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDACTDATCRE.AppearanceHeader.Options.UseForeColor = True
        Me.GColDACTDATCRE.Caption = "Date création"
        Me.GColDACTDATCRE.FieldName = "DACTDATCRE"
        Me.GColDACTDATCRE.Name = "GColDACTDATCRE"
        Me.GColDACTDATCRE.OptionsColumn.AllowEdit = False
        Me.GColDACTDATCRE.OptionsColumn.ReadOnly = True
        Me.GColDACTDATCRE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColDACTDATCRE.Visible = True
        Me.GColDACTDATCRE.VisibleIndex = 2
        '
        'GColVCLINOM
        '
        Me.GColVCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVCLINOM.AppearanceHeader.Options.UseForeColor = True
        Me.GColVCLINOM.Caption = "Client"
        Me.GColVCLINOM.FieldName = "VCLINOM"
        Me.GColVCLINOM.Name = "GColVCLINOM"
        Me.GColVCLINOM.OptionsColumn.AllowEdit = False
        Me.GColVCLINOM.OptionsColumn.ReadOnly = True
        Me.GColVCLINOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVCLINOM.Visible = True
        Me.GColVCLINOM.VisibleIndex = 3
        '
        'GColVSITNOM
        '
        Me.GColVSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVSITNOM.AppearanceHeader.Options.UseForeColor = True
        Me.GColVSITNOM.Caption = "Site"
        Me.GColVSITNOM.FieldName = "VSITNOM"
        Me.GColVSITNOM.Name = "GColVSITNOM"
        Me.GColVSITNOM.OptionsColumn.AllowEdit = False
        Me.GColVSITNOM.OptionsColumn.ReadOnly = True
        Me.GColVSITNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVSITNOM.Visible = True
        Me.GColVSITNOM.VisibleIndex = 4
        '
        'GColVDINCHAFF
        '
        Me.GColVDINCHAFF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVDINCHAFF.AppearanceHeader.Options.UseForeColor = True
        Me.GColVDINCHAFF.Caption = "Chargé d'affaires"
        Me.GColVDINCHAFF.FieldName = "VDINCHAFF"
        Me.GColVDINCHAFF.Name = "GColVDINCHAFF"
        Me.GColVDINCHAFF.OptionsColumn.AllowEdit = False
        Me.GColVDINCHAFF.OptionsColumn.ReadOnly = True
        Me.GColVDINCHAFF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVDINCHAFF.Visible = True
        Me.GColVDINCHAFF.VisibleIndex = 5
        '
        'GColNACTDUR
        '
        Me.GColNACTDUR.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNACTDUR.AppearanceHeader.Options.UseForeColor = True
        Me.GColNACTDUR.Caption = "Durée"
        Me.GColNACTDUR.FieldName = "NACTDUR"
        Me.GColNACTDUR.Name = "GColNACTDUR"
        Me.GColNACTDUR.OptionsColumn.AllowEdit = False
        Me.GColNACTDUR.OptionsColumn.ReadOnly = True
        Me.GColNACTDUR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColNACTDUR.Visible = True
        Me.GColNACTDUR.VisibleIndex = 6
        '
        'GColVSITCP
        '
        Me.GColVSITCP.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVSITCP.AppearanceHeader.Options.UseForeColor = True
        Me.GColVSITCP.Caption = "CP"
        Me.GColVSITCP.FieldName = "VSITCP"
        Me.GColVSITCP.Name = "GColVSITCP"
        Me.GColVSITCP.OptionsColumn.AllowEdit = False
        Me.GColVSITCP.OptionsColumn.ReadOnly = True
        Me.GColVSITCP.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVSITCP.Visible = True
        Me.GColVSITCP.VisibleIndex = 7
        '
        'GColVSITVIL
        '
        Me.GColVSITVIL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVSITVIL.AppearanceHeader.Options.UseForeColor = True
        Me.GColVSITVIL.Caption = "Ville"
        Me.GColVSITVIL.FieldName = "VSITVIL"
        Me.GColVSITVIL.Name = "GColVSITVIL"
        Me.GColVSITVIL.OptionsColumn.AllowEdit = False
        Me.GColVSITVIL.OptionsColumn.ReadOnly = True
        Me.GColVSITVIL.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVSITVIL.Visible = True
        Me.GColVSITVIL.VisibleIndex = 8
        '
        'GColVSITREG
        '
        Me.GColVSITREG.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVSITREG.AppearanceHeader.Options.UseForeColor = True
        Me.GColVSITREG.Caption = "Région"
        Me.GColVSITREG.FieldName = "VSITREG"
        Me.GColVSITREG.Name = "GColVSITREG"
        Me.GColVSITREG.OptionsColumn.AllowEdit = False
        Me.GColVSITREG.OptionsColumn.ReadOnly = True
        Me.GColVSITREG.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVSITREG.Visible = True
        Me.GColVSITREG.VisibleIndex = 9
        '
        'GColVSITPAYS
        '
        Me.GColVSITPAYS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVSITPAYS.AppearanceHeader.Options.UseForeColor = True
        Me.GColVSITPAYS.Caption = "Pays"
        Me.GColVSITPAYS.FieldName = "VSITPAYS"
        Me.GColVSITPAYS.Name = "GColVSITPAYS"
        Me.GColVSITPAYS.OptionsColumn.AllowEdit = False
        Me.GColVSITPAYS.OptionsColumn.ReadOnly = True
        Me.GColVSITPAYS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVSITPAYS.Visible = True
        Me.GColVSITPAYS.VisibleIndex = 10
        '
        'GColVACTDES
        '
        Me.GColVACTDES.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVACTDES.AppearanceHeader.Options.UseForeColor = True
        Me.GColVACTDES.Caption = "Action"
        Me.GColVACTDES.FieldName = "VACTDES"
        Me.GColVACTDES.Name = "GColVACTDES"
        Me.GColVACTDES.OptionsColumn.AllowEdit = False
        Me.GColVACTDES.OptionsColumn.ReadOnly = True
        Me.GColVACTDES.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVACTDES.Visible = True
        Me.GColVACTDES.VisibleIndex = 11
        '
        'GColDACTDAT
        '
        Me.GColDACTDAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDACTDAT.AppearanceHeader.Options.UseForeColor = True
        Me.GColDACTDAT.Caption = "Date souhaitée"
        Me.GColDACTDAT.FieldName = "DACTDAT"
        Me.GColDACTDAT.Name = "GColDACTDAT"
        Me.GColDACTDAT.OptionsColumn.AllowEdit = False
        Me.GColDACTDAT.OptionsColumn.ReadOnly = True
        Me.GColDACTDAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColDACTDAT.Visible = True
        Me.GColDACTDAT.VisibleIndex = 12
        '
        'GCol_VETALIB
        '
        Me.GCol_VETALIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VETALIB.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VETALIB.Caption = "Etat action"
        Me.GCol_VETALIB.FieldName = "VETALIB"
        Me.GCol_VETALIB.Name = "GCol_VETALIB"
        Me.GCol_VETALIB.OptionsColumn.AllowEdit = False
        Me.GCol_VETALIB.OptionsColumn.ReadOnly = True
        Me.GCol_VETALIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_VETALIB.Visible = True
        Me.GCol_VETALIB.VisibleIndex = 13
        '
        'BtnValid
        '
        Me.BtnValid.Location = New System.Drawing.Point(602, 602)
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.Size = New System.Drawing.Size(86, 40)
        Me.BtnValid.TabIndex = 1
        Me.BtnValid.Text = "Suivant"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Location = New System.Drawing.Point(447, 602)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(86, 40)
        Me.BtnFermer.TabIndex = 2
        Me.BtnFermer.Text = "Annuler"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnCocheTS
        '
        Me.BtnCocheTS.Location = New System.Drawing.Point(40, 570)
        Me.BtnCocheTS.Name = "BtnCocheTS"
        Me.BtnCocheTS.Size = New System.Drawing.Size(75, 23)
        Me.BtnCocheTS.TabIndex = 3
        Me.BtnCocheTS.Text = "Cocher tous"
        Me.BtnCocheTS.UseVisualStyleBackColor = True
        '
        'BtnDecocheTS
        '
        Me.BtnDecocheTS.Location = New System.Drawing.Point(121, 570)
        Me.BtnDecocheTS.Name = "BtnDecocheTS"
        Me.BtnDecocheTS.Size = New System.Drawing.Size(91, 23)
        Me.BtnDecocheTS.TabIndex = 4
        Me.BtnDecocheTS.Text = "Décocher tous"
        Me.BtnDecocheTS.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(672, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Planification automatique : Liste des actions préventives à planifier avec techni" &
    "cien"
        '
        'frmPlanifAuto_ListeActions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 667)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnDecocheTS)
        Me.Controls.Add(Me.BtnCocheTS)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.BtnValid)
        Me.Controls.Add(Me.GCListeActions)
        Me.Name = "frmPlanifAuto_ListeActions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Planification automatique : Liste des actions préventives à planifier avec techni" &
    "cien"
        CType(Me.GCListeActions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeActions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEditCHECK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GCListeActions As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVListeActions As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GColNCOCHE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNACTNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColDACTDATCRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVDINCHAFF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNACTDUR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVSITCP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVSITVIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVSITREG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVSITPAYS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVACTDES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColDACTDAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEditCHECK As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BtnValid As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnCocheTS As Button
    Friend WithEvents BtnDecocheTS As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GCol_CETACOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VETALIB As DevExpress.XtraGrid.Columns.GridColumn
End Class
