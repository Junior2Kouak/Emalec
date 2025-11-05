<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChantierListeActionErreur_Heures
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
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue4 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.GCol_NREA_CHANTIERVAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NHRPLA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdActions = New DevExpress.XtraGrid.GridControl()
        Me.grdVAction = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_NDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NACTNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NDINNUM_NACTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GCol_NREA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.grdActions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdVAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCol_NREA_CHANTIERVAL
        '
        Me.GCol_NREA_CHANTIERVAL.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_NREA_CHANTIERVAL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GCol_NREA_CHANTIERVAL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_NREA_CHANTIERVAL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_NREA_CHANTIERVAL.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_NREA_CHANTIERVAL.Caption = "Nb Heures sur Fiche Chantier"
        Me.GCol_NREA_CHANTIERVAL.FieldName = "NREA_CHANTIERVAL"
        Me.GCol_NREA_CHANTIERVAL.Name = "GCol_NREA_CHANTIERVAL"
        Me.GCol_NREA_CHANTIERVAL.OptionsColumn.AllowEdit = False
        Me.GCol_NREA_CHANTIERVAL.OptionsColumn.ReadOnly = True
        Me.GCol_NREA_CHANTIERVAL.Visible = True
        Me.GCol_NREA_CHANTIERVAL.VisibleIndex = 2
        Me.GCol_NREA_CHANTIERVAL.Width = 100
        '
        'GCol_NHRPLA
        '
        Me.GCol_NHRPLA.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_NHRPLA.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_NHRPLA.Caption = "Nb Heures planifiées"
        Me.GCol_NHRPLA.FieldName = "NHRPLA"
        Me.GCol_NHRPLA.Name = "GCol_NHRPLA"
        Me.GCol_NHRPLA.OptionsColumn.AllowEdit = False
        Me.GCol_NHRPLA.OptionsColumn.ReadOnly = True
        Me.GCol_NHRPLA.Visible = True
        Me.GCol_NHRPLA.VisibleIndex = 3
        Me.GCol_NHRPLA.Width = 100
        '
        'grdActions
        '
        Me.grdActions.Location = New System.Drawing.Point(12, 52)
        Me.grdActions.MainView = Me.grdVAction
        Me.grdActions.Name = "grdActions"
        Me.grdActions.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1})
        Me.grdActions.Size = New System.Drawing.Size(483, 402)
        Me.grdActions.TabIndex = 59
        Me.grdActions.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdVAction, Me.GridView1, Me.GridView2})
        '
        'grdVAction
        '
        Me.grdVAction.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdVAction.Appearance.HeaderPanel.Options.UseFont = True
        Me.grdVAction.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grdVAction.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdVAction.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.grdVAction.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.grdVAction.ColumnPanelRowHeight = 40
        Me.grdVAction.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_NDINNUM, Me.GCol_NACTNUM, Me.GCol_NDINNUM_NACTID, Me.GCol_NREA, Me.GCol_NREA_CHANTIERVAL, Me.GCol_NHRPLA})
        GridFormatRule1.Column = Me.GCol_NREA_CHANTIERVAL
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.SpringGreen
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue1.Expression = "[NREA] = [NREA_CHANTIERVAL]"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.Column = Me.GCol_NREA_CHANTIERVAL
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.Red
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue2.Expression = "[NREA] <> [NREA_CHANTIERVAL]"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        GridFormatRule3.Column = Me.GCol_NHRPLA
        GridFormatRule3.Name = "Format2"
        FormatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.SpringGreen
        FormatConditionRuleValue3.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue3.Expression = "[NREA] = [NHRPLA]"
        GridFormatRule3.Rule = FormatConditionRuleValue3
        GridFormatRule4.Column = Me.GCol_NHRPLA
        GridFormatRule4.Name = "Format3"
        FormatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.Red
        FormatConditionRuleValue4.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue4.Expression = "[NREA] <> [NHRPLA]"
        GridFormatRule4.Rule = FormatConditionRuleValue4
        Me.grdVAction.FormatRules.Add(GridFormatRule1)
        Me.grdVAction.FormatRules.Add(GridFormatRule2)
        Me.grdVAction.FormatRules.Add(GridFormatRule3)
        Me.grdVAction.FormatRules.Add(GridFormatRule4)
        Me.grdVAction.GridControl = Me.grdActions
        Me.grdVAction.Name = "grdVAction"
        Me.grdVAction.OptionsBehavior.KeepGroupExpandedOnSorting = False
        Me.grdVAction.OptionsView.ColumnAutoWidth = False
        Me.grdVAction.OptionsView.ShowGroupPanel = False
        '
        'GCol_NDINNUM
        '
        Me.GCol_NDINNUM.Caption = "GridColumn5"
        Me.GCol_NDINNUM.FieldName = "NDINNUM"
        Me.GCol_NDINNUM.Name = "GCol_NDINNUM"
        '
        'GCol_NACTNUM
        '
        Me.GCol_NACTNUM.Caption = "GridColumn1"
        Me.GCol_NACTNUM.FieldName = "NACTNUM"
        Me.GCol_NACTNUM.Name = "GCol_NACTNUM"
        '
        'GCol_NDINNUM_NACTID
        '
        Me.GCol_NDINNUM_NACTID.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_NDINNUM_NACTID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_NDINNUM_NACTID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_NDINNUM_NACTID.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_NDINNUM_NACTID.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_NDINNUM_NACTID.Caption = "N° DI"
        Me.GCol_NDINNUM_NACTID.ColumnEdit = Me.RepositoryItemHyperLinkEdit1
        Me.GCol_NDINNUM_NACTID.FieldName = "NDINNUM_NACTID"
        Me.GCol_NDINNUM_NACTID.Name = "GCol_NDINNUM_NACTID"
        Me.GCol_NDINNUM_NACTID.OptionsColumn.ReadOnly = True
        Me.GCol_NDINNUM_NACTID.Visible = True
        Me.GCol_NDINNUM_NACTID.VisibleIndex = 0
        Me.GCol_NDINNUM_NACTID.Width = 150
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        Me.RepositoryItemHyperLinkEdit1.SingleClick = True
        '
        'GCol_NREA
        '
        Me.GCol_NREA.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_NREA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GCol_NREA.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_NREA.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_NREA.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_NREA.Caption = "Nb Heures sur action"
        Me.GCol_NREA.FieldName = "NREA"
        Me.GCol_NREA.Name = "GCol_NREA"
        Me.GCol_NREA.OptionsColumn.AllowEdit = False
        Me.GCol_NREA.OptionsColumn.ReadOnly = True
        Me.GCol_NREA.Visible = True
        Me.GCol_NREA.VisibleIndex = 1
        Me.GCol_NREA.Width = 100
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdActions
        Me.GridView1.Name = "GridView1"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grdActions
        Me.GridView2.Name = "GridView2"
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label39.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label39.Location = New System.Drawing.Point(9, 6)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(486, 43)
        Me.Label39.TabIndex = 60
        Me.Label39.Text = "Liste des actions en erreur : le nombre d'heures sur l'action ne correspond pas a" &
    "u nombre d'heures sur les fiches ou au nombre d'heures planifiées"
        '
        'btnFermer
        '
        Me.btnFermer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFermer.Location = New System.Drawing.Point(548, 417)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(97, 37)
        Me.btnFermer.TabIndex = 61
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SpringGreen
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(515, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 30)
        Me.Label1.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(515, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 30)
        Me.Label2.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(573, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 30)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Heures égales aux heures sur action"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(573, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 30)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Heures différentes aux heures sur action"
        '
        'frmChantierListeActionErreur_Heures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 466)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.grdActions)
        Me.Name = "frmChantierListeActionErreur_Heures"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Liste des actions en erreur sur le nombre d'heures réalisées"
        CType(Me.grdActions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdVAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdActions As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdVAction As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label39 As Label
    Friend WithEvents GCol_NACTNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NDINNUM_NACTID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NREA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NREA_CHANTIERVAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents btnFermer As Button
    Friend WithEvents GCol_NDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NHRPLA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
