<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListeSortiesStockToutesAvecDetFou
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeSortiesStockToutesAvecDetFou))
        Dim GridFormatRule5 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue4 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule6 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue5 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule7 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue6 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule8 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression2 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Me.GColListe_SS_NLARTQTEOUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColListe_SS_SOLDE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit_SOLDE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GColListe_SS_NFOUQTESTOCK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpBoxActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GCLISTE_SS = New DevExpress.XtraGrid.GridControl()
        Me.GVLISTE_SS = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColListe_SS_NDDENUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColListe_SS_VFOUSER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColListe_SS_VFOUMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColListe_SS_VFOUEMPLACEMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColListe_SS_VFOUMAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColListe_SS_VFOUTYP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColListe_SS_VFOUREF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColListe_SS_NLARTQTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColListe_SS_NFOUQTECDE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColListe_SS_NLARTQTEBL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColListe_SS_QTEDDE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColListe_SS_QTECMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.RepositoryItemCheckEdit_SOLDE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxActions.SuspendLayout()
        CType(Me.GCLISTE_SS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVLISTE_SS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GColListe_SS_NLARTQTEOUT
        '
        Me.GColListe_SS_NLARTQTEOUT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColListe_SS_NLARTQTEOUT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColListe_SS_NLARTQTEOUT, "GColListe_SS_NLARTQTEOUT")
        Me.GColListe_SS_NLARTQTEOUT.FieldName = "NLARTQTEOUT"
        Me.GColListe_SS_NLARTQTEOUT.Name = "GColListe_SS_NLARTQTEOUT"
        Me.GColListe_SS_NLARTQTEOUT.OptionsColumn.AllowEdit = False
        Me.GColListe_SS_NLARTQTEOUT.OptionsColumn.ReadOnly = True
        '
        'GColListe_SS_SOLDE
        '
        Me.GColListe_SS_SOLDE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColListe_SS_SOLDE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColListe_SS_SOLDE, "GColListe_SS_SOLDE")
        Me.GColListe_SS_SOLDE.ColumnEdit = Me.RepositoryItemCheckEdit_SOLDE
        Me.GColListe_SS_SOLDE.FieldName = "SOLDE"
        Me.GColListe_SS_SOLDE.Name = "GColListe_SS_SOLDE"
        '
        'RepositoryItemCheckEdit_SOLDE
        '
        resources.ApplyResources(Me.RepositoryItemCheckEdit_SOLDE, "RepositoryItemCheckEdit_SOLDE")
        Me.RepositoryItemCheckEdit_SOLDE.Name = "RepositoryItemCheckEdit_SOLDE"
        Me.RepositoryItemCheckEdit_SOLDE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit_SOLDE.ReadOnly = True
        Me.RepositoryItemCheckEdit_SOLDE.ValueChecked = 1
        Me.RepositoryItemCheckEdit_SOLDE.ValueUnchecked = 0
        '
        'GColListe_SS_NFOUQTESTOCK
        '
        Me.GColListe_SS_NFOUQTESTOCK.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColListe_SS_NFOUQTESTOCK.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColListe_SS_NFOUQTESTOCK, "GColListe_SS_NFOUQTESTOCK")
        Me.GColListe_SS_NFOUQTESTOCK.FieldName = "NFOUQTESTOCK"
        Me.GColListe_SS_NFOUQTESTOCK.Name = "GColListe_SS_NFOUQTESTOCK"
        Me.GColListe_SS_NFOUQTESTOCK.OptionsColumn.AllowEdit = False
        Me.GColListe_SS_NFOUQTESTOCK.OptionsColumn.ReadOnly = True
        '
        'GrpBoxActions
        '
        Me.GrpBoxActions.Controls.Add(Me.Button1)
        Me.GrpBoxActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpBoxActions, "GrpBoxActions")
        Me.GrpBoxActions.Name = "GrpBoxActions"
        Me.GrpBoxActions.TabStop = False
        '
        'BtnFermer
        '
        Me.BtnFermer.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = False
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GCLISTE_SS
        '
        resources.ApplyResources(Me.GCLISTE_SS, "GCLISTE_SS")
        Me.GCLISTE_SS.MainView = Me.GVLISTE_SS
        Me.GCLISTE_SS.Name = "GCLISTE_SS"
        Me.GCLISTE_SS.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit_SOLDE})
        Me.GCLISTE_SS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVLISTE_SS})
        '
        'GVLISTE_SS
        '
        Me.GVLISTE_SS.Appearance.FocusedCell.BackColor = System.Drawing.Color.Gainsboro
        Me.GVLISTE_SS.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVLISTE_SS.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gainsboro
        Me.GVLISTE_SS.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVLISTE_SS.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVLISTE_SS.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVLISTE_SS.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVLISTE_SS.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVLISTE_SS.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVLISTE_SS.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVLISTE_SS.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVLISTE_SS.ColumnPanelRowHeight = 80
        Me.GVLISTE_SS.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColListe_SS_SOLDE, Me.GColListe_SS_NDDENUM, Me.GColListe_SS_VFOUSER, Me.GColListe_SS_VFOUMAT, Me.GColListe_SS_VFOUEMPLACEMENT, Me.GColListe_SS_VFOUMAR, Me.GColListe_SS_VFOUTYP, Me.GColListe_SS_VFOUREF, Me.GColListe_SS_NLARTQTE, Me.GColListe_SS_NLARTQTEOUT, Me.GColListe_SS_NFOUQTECDE, Me.GColListe_SS_NLARTQTEBL, Me.GColListe_SS_NFOUQTESTOCK, Me.GColListe_SS_QTEDDE, Me.GColListe_SS_QTECMD})
        GridFormatRule5.Column = Me.GColListe_SS_NLARTQTEOUT
        GridFormatRule5.Name = "Format_NLARTQTEOUT"
        FormatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.White
        FormatConditionRuleValue4.Appearance.ForeColor = System.Drawing.Color.Red
        FormatConditionRuleValue4.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue4.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue4.Value1 = "0"
        GridFormatRule5.Rule = FormatConditionRuleValue4
        GridFormatRule6.Column = Me.GColListe_SS_SOLDE
        GridFormatRule6.Name = "Format_SOLDE"
        FormatConditionRuleValue5.Appearance.BackColor = System.Drawing.Color.White
        FormatConditionRuleValue5.Appearance.ForeColor = System.Drawing.Color.Red
        FormatConditionRuleValue5.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue5.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue5.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue5.Value1 = "0"
        GridFormatRule6.Rule = FormatConditionRuleValue5
        GridFormatRule7.Column = Me.GColListe_SS_NFOUQTESTOCK
        GridFormatRule7.Name = "Format_NFOUQTESTOCK"
        FormatConditionRuleValue6.Appearance.BackColor = System.Drawing.Color.White
        FormatConditionRuleValue6.Appearance.ForeColor = System.Drawing.Color.Red
        FormatConditionRuleValue6.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue6.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue6.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue6.Value1 = "0"
        GridFormatRule7.Rule = FormatConditionRuleValue6
        GridFormatRule8.ApplyToRow = True
        GridFormatRule8.Name = "Format_RedStockLine"
        FormatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.Red
        FormatConditionRuleExpression2.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression2.Expression = "[QTECMD] > [NFOUQTESTOCK]"
        GridFormatRule8.Rule = FormatConditionRuleExpression2
        Me.GVLISTE_SS.FormatRules.Add(GridFormatRule5)
        Me.GVLISTE_SS.FormatRules.Add(GridFormatRule6)
        Me.GVLISTE_SS.FormatRules.Add(GridFormatRule7)
        Me.GVLISTE_SS.FormatRules.Add(GridFormatRule8)
        Me.GVLISTE_SS.GridControl = Me.GCLISTE_SS
        Me.GVLISTE_SS.Name = "GVLISTE_SS"
        Me.GVLISTE_SS.OptionsView.ShowAutoFilterRow = True
        Me.GVLISTE_SS.OptionsView.ShowFooter = True
        Me.GVLISTE_SS.OptionsView.ShowGroupPanel = False
        '
        'GColListe_SS_NDDENUM
        '
        Me.GColListe_SS_NDDENUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColListe_SS_NDDENUM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColListe_SS_NDDENUM, "GColListe_SS_NDDENUM")
        Me.GColListe_SS_NDDENUM.FieldName = "NDDENUM"
        Me.GColListe_SS_NDDENUM.Name = "GColListe_SS_NDDENUM"
        Me.GColListe_SS_NDDENUM.OptionsColumn.AllowEdit = False
        Me.GColListe_SS_NDDENUM.OptionsColumn.ReadOnly = True
        '
        'GColListe_SS_VFOUSER
        '
        Me.GColListe_SS_VFOUSER.AppearanceHeader.Font = CType(resources.GetObject("GColListe_SS_VFOUSER.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColListe_SS_VFOUSER.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColListe_SS_VFOUSER.AppearanceHeader.Options.UseFont = True
        Me.GColListe_SS_VFOUSER.AppearanceHeader.Options.UseForeColor = True
        Me.GColListe_SS_VFOUSER.AppearanceHeader.Options.UseTextOptions = True
        Me.GColListe_SS_VFOUSER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColListe_SS_VFOUSER.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColListe_SS_VFOUSER.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColListe_SS_VFOUSER, "GColListe_SS_VFOUSER")
        Me.GColListe_SS_VFOUSER.FieldName = "VFOUSER"
        Me.GColListe_SS_VFOUSER.Name = "GColListe_SS_VFOUSER"
        Me.GColListe_SS_VFOUSER.OptionsColumn.AllowEdit = False
        Me.GColListe_SS_VFOUSER.OptionsColumn.ReadOnly = True
        '
        'GColListe_SS_VFOUMAT
        '
        Me.GColListe_SS_VFOUMAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColListe_SS_VFOUMAT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColListe_SS_VFOUMAT, "GColListe_SS_VFOUMAT")
        Me.GColListe_SS_VFOUMAT.FieldName = "VFOUMAT"
        Me.GColListe_SS_VFOUMAT.Name = "GColListe_SS_VFOUMAT"
        Me.GColListe_SS_VFOUMAT.OptionsColumn.AllowEdit = False
        Me.GColListe_SS_VFOUMAT.OptionsColumn.ReadOnly = True
        '
        'GColListe_SS_VFOUEMPLACEMENT
        '
        Me.GColListe_SS_VFOUEMPLACEMENT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColListe_SS_VFOUEMPLACEMENT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColListe_SS_VFOUEMPLACEMENT, "GColListe_SS_VFOUEMPLACEMENT")
        Me.GColListe_SS_VFOUEMPLACEMENT.FieldName = "VFOUEMPLACEMENT"
        Me.GColListe_SS_VFOUEMPLACEMENT.Name = "GColListe_SS_VFOUEMPLACEMENT"
        Me.GColListe_SS_VFOUEMPLACEMENT.OptionsColumn.AllowEdit = False
        Me.GColListe_SS_VFOUEMPLACEMENT.OptionsColumn.ReadOnly = True
        '
        'GColListe_SS_VFOUMAR
        '
        Me.GColListe_SS_VFOUMAR.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColListe_SS_VFOUMAR.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColListe_SS_VFOUMAR, "GColListe_SS_VFOUMAR")
        Me.GColListe_SS_VFOUMAR.FieldName = "VFOUMAR"
        Me.GColListe_SS_VFOUMAR.Name = "GColListe_SS_VFOUMAR"
        Me.GColListe_SS_VFOUMAR.OptionsColumn.AllowEdit = False
        Me.GColListe_SS_VFOUMAR.OptionsColumn.ReadOnly = True
        '
        'GColListe_SS_VFOUTYP
        '
        Me.GColListe_SS_VFOUTYP.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColListe_SS_VFOUTYP.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColListe_SS_VFOUTYP, "GColListe_SS_VFOUTYP")
        Me.GColListe_SS_VFOUTYP.FieldName = "VFOUTYP"
        Me.GColListe_SS_VFOUTYP.Name = "GColListe_SS_VFOUTYP"
        Me.GColListe_SS_VFOUTYP.OptionsColumn.AllowEdit = False
        Me.GColListe_SS_VFOUTYP.OptionsColumn.ReadOnly = True
        '
        'GColListe_SS_VFOUREF
        '
        Me.GColListe_SS_VFOUREF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColListe_SS_VFOUREF.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColListe_SS_VFOUREF, "GColListe_SS_VFOUREF")
        Me.GColListe_SS_VFOUREF.FieldName = "VFOUREF"
        Me.GColListe_SS_VFOUREF.Name = "GColListe_SS_VFOUREF"
        Me.GColListe_SS_VFOUREF.OptionsColumn.AllowEdit = False
        Me.GColListe_SS_VFOUREF.OptionsColumn.ReadOnly = True
        '
        'GColListe_SS_NLARTQTE
        '
        Me.GColListe_SS_NLARTQTE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColListe_SS_NLARTQTE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColListe_SS_NLARTQTE, "GColListe_SS_NLARTQTE")
        Me.GColListe_SS_NLARTQTE.FieldName = "NLARTQTE"
        Me.GColListe_SS_NLARTQTE.Name = "GColListe_SS_NLARTQTE"
        Me.GColListe_SS_NLARTQTE.OptionsColumn.AllowEdit = False
        Me.GColListe_SS_NLARTQTE.OptionsColumn.ReadOnly = True
        '
        'GColListe_SS_NFOUQTECDE
        '
        Me.GColListe_SS_NFOUQTECDE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColListe_SS_NFOUQTECDE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColListe_SS_NFOUQTECDE, "GColListe_SS_NFOUQTECDE")
        Me.GColListe_SS_NFOUQTECDE.FieldName = "NFOUQTECDE"
        Me.GColListe_SS_NFOUQTECDE.Name = "GColListe_SS_NFOUQTECDE"
        Me.GColListe_SS_NFOUQTECDE.OptionsColumn.AllowEdit = False
        Me.GColListe_SS_NFOUQTECDE.OptionsColumn.ReadOnly = True
        '
        'GColListe_SS_NLARTQTEBL
        '
        resources.ApplyResources(Me.GColListe_SS_NLARTQTEBL, "GColListe_SS_NLARTQTEBL")
        Me.GColListe_SS_NLARTQTEBL.FieldName = "NLARTQTEBL"
        Me.GColListe_SS_NLARTQTEBL.Name = "GColListe_SS_NLARTQTEBL"
        Me.GColListe_SS_NLARTQTEBL.OptionsColumn.AllowEdit = False
        Me.GColListe_SS_NLARTQTEBL.OptionsColumn.ReadOnly = True
        '
        'GColListe_SS_QTEDDE
        '
        Me.GColListe_SS_QTEDDE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColListe_SS_QTEDDE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColListe_SS_QTEDDE, "GColListe_SS_QTEDDE")
        Me.GColListe_SS_QTEDDE.FieldName = "QTEDDE"
        Me.GColListe_SS_QTEDDE.Name = "GColListe_SS_QTEDDE"
        Me.GColListe_SS_QTEDDE.OptionsColumn.AllowEdit = False
        Me.GColListe_SS_QTEDDE.OptionsColumn.ReadOnly = True
        '
        'GColListe_SS_QTECMD
        '
        resources.ApplyResources(Me.GColListe_SS_QTECMD, "GColListe_SS_QTECMD")
        Me.GColListe_SS_QTECMD.FieldName = "QTECMD"
        Me.GColListe_SS_QTECMD.Name = "GColListe_SS_QTECMD"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmListeSortiesStockToutesAvecDetFou
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GrpBoxActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GCLISTE_SS)
        Me.Name = "frmListeSortiesStockToutesAvecDetFou"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RepositoryItemCheckEdit_SOLDE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxActions.ResumeLayout(False)
        CType(Me.GCLISTE_SS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVLISTE_SS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpBoxActions As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents LblTitre As Label
    Private WithEvents GCLISTE_SS As DevExpress.XtraGrid.GridControl
    Private WithEvents GVLISTE_SS As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColListe_SS_VFOUSER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColListe_SS_VFOUMAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColListe_SS_VFOUEMPLACEMENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColListe_SS_VFOUMAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColListe_SS_VFOUTYP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColListe_SS_VFOUREF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColListe_SS_NLARTQTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColListe_SS_NLARTQTEOUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColListe_SS_NFOUQTECDE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColListe_SS_NLARTQTEBL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColListe_SS_NFOUQTESTOCK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColListe_SS_QTEDDE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColListe_SS_NDDENUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColListe_SS_SOLDE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit_SOLDE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GColListe_SS_QTECMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SFD As SaveFileDialog
    Friend WithEvents Button1 As Button
End Class
