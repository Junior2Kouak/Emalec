<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestPrestationPrixClient
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
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnPrixClientDel = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrixClientAdd = New System.Windows.Forms.Button()
        Me.GCListePrestaPrixClient = New DevExpress.XtraGrid.GridControl()
        Me.GVListePrestaPrixClient = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNCFOCOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Txt_NPRIXCLINUIT = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GlookUpClient = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GVCbo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCCbo_NCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCCboVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtPrixRevient = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_NPRIXCLIENT = New DevExpress.XtraEditors.TextEdit()
        Me.BtnSavePrixClient = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GCListePrestaPrixClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListePrestaPrixClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Txt_NPRIXCLINUIT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GlookUpClient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCbo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrixRevient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_NPRIXCLIENT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn3.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn3.Caption = "Coef vente"
        Me.GridColumn3.FieldName = "COEF"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn6.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn6.Caption = "Coef vente nuit"
        Me.GridColumn6.FieldName = "COEF_NUIT"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.GCListePrestaPrixClient)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1008, 551)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnPrixClientDel)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnPrixClientAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(87, 452)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'BtnPrixClientDel
        '
        Me.BtnPrixClientDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnPrixClientDel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPrixClientDel.Location = New System.Drawing.Point(6, 181)
        Me.BtnPrixClientDel.Name = "BtnPrixClientDel"
        Me.BtnPrixClientDel.Size = New System.Drawing.Size(75, 37)
        Me.BtnPrixClientDel.TabIndex = 38
        Me.BtnPrixClientDel.Text = "Supprimer"
        Me.BtnPrixClientDel.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(4, 384)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnPrixClientAdd
        '
        Me.BtnPrixClientAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnPrixClientAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPrixClientAdd.Location = New System.Drawing.Point(5, 134)
        Me.BtnPrixClientAdd.Name = "BtnPrixClientAdd"
        Me.BtnPrixClientAdd.Size = New System.Drawing.Size(74, 41)
        Me.BtnPrixClientAdd.TabIndex = 0
        Me.BtnPrixClientAdd.Text = "Ajouter"
        Me.BtnPrixClientAdd.UseVisualStyleBackColor = True
        '
        'GCListePrestaPrixClient
        '
        Me.GCListePrestaPrixClient.Location = New System.Drawing.Point(99, 190)
        Me.GCListePrestaPrixClient.MainView = Me.GVListePrestaPrixClient
        Me.GCListePrestaPrixClient.Name = "GCListePrestaPrixClient"
        Me.GCListePrestaPrixClient.Size = New System.Drawing.Size(884, 355)
        Me.GCListePrestaPrixClient.TabIndex = 52
        Me.GCListePrestaPrixClient.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListePrestaPrixClient})
        '
        'GVListePrestaPrixClient
        '
        Me.GVListePrestaPrixClient.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListePrestaPrixClient.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListePrestaPrixClient.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListePrestaPrixClient.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListePrestaPrixClient.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListePrestaPrixClient.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListePrestaPrixClient.ColumnPanelRowHeight = 40
        Me.GVListePrestaPrixClient.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNCFOCOD, Me.GColVCLINOM, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        GridFormatRule1.Column = Me.GridColumn3
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Red
        FormatConditionRuleValue1.Appearance.Options.UseFont = True
        FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue1.Expression = "[COEF] < 1.2"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.Column = Me.GridColumn3
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue2.Expression = "[COEF] >= 1.2"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        GridFormatRule3.Column = Me.GridColumn6
        GridFormatRule3.Name = "Format2"
        FormatConditionRuleValue3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue3.Appearance.ForeColor = System.Drawing.Color.Red
        FormatConditionRuleValue3.Appearance.Options.UseFont = True
        FormatConditionRuleValue3.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue3.Expression = "[COEF_NUIT] < 1.2"
        GridFormatRule3.Rule = FormatConditionRuleValue3
        GridFormatRule4.Column = Me.GridColumn6
        GridFormatRule4.Name = "Format3"
        FormatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue4.Expression = "[COEF_NUIT] >= 1.2"
        GridFormatRule4.Rule = FormatConditionRuleValue4
        Me.GVListePrestaPrixClient.FormatRules.Add(GridFormatRule1)
        Me.GVListePrestaPrixClient.FormatRules.Add(GridFormatRule2)
        Me.GVListePrestaPrixClient.FormatRules.Add(GridFormatRule3)
        Me.GVListePrestaPrixClient.FormatRules.Add(GridFormatRule4)
        Me.GVListePrestaPrixClient.GridControl = Me.GCListePrestaPrixClient
        Me.GVListePrestaPrixClient.Name = "GVListePrestaPrixClient"
        Me.GVListePrestaPrixClient.OptionsBehavior.Editable = False
        Me.GVListePrestaPrixClient.OptionsBehavior.ReadOnly = True
        Me.GVListePrestaPrixClient.OptionsView.ShowAutoFilterRow = True
        Me.GVListePrestaPrixClient.OptionsView.ShowFooter = True
        Me.GVListePrestaPrixClient.OptionsView.ShowGroupPanel = False
        '
        'GColNCFOCOD
        '
        Me.GColNCFOCOD.Name = "GColNCFOCOD"
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
        Me.GColVCLINOM.VisibleIndex = 0
        Me.GColVCLINOM.Width = 300
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn1.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn1.Caption = "Base"
        Me.GridColumn1.FieldName = "BASE"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn2.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn2.Caption = "Prix de vente de jour"
        Me.GridColumn2.DisplayFormat.FormatString = "c2"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "NPRIXCLI"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "NCLINUM"
        Me.GridColumn4.FieldName = "NCLINUM"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn5.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn5.Caption = "Prix client de nuit"
        Me.GridColumn5.DisplayFormat.FormatString = "c2"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "NPRIXCLINUIT"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Txt_NPRIXCLINUIT)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.GlookUpClient)
        Me.GroupBox3.Controls.Add(Me.TxtPrixRevient)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Txt_NPRIXCLIENT)
        Me.GroupBox3.Controls.Add(Me.BtnSavePrixClient)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox3.Location = New System.Drawing.Point(99, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(523, 165)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Détail"
        '
        'Txt_NPRIXCLINUIT
        '
        Me.Txt_NPRIXCLINUIT.Location = New System.Drawing.Point(184, 131)
        Me.Txt_NPRIXCLINUIT.Name = "Txt_NPRIXCLINUIT"
        Me.Txt_NPRIXCLINUIT.Properties.EditFormat.FormatString = "n2"
        Me.Txt_NPRIXCLINUIT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Txt_NPRIXCLINUIT.Properties.Mask.EditMask = "n2"
        Me.Txt_NPRIXCLINUIT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Txt_NPRIXCLINUIT.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Txt_NPRIXCLINUIT.Size = New System.Drawing.Size(103, 20)
        Me.Txt_NPRIXCLINUIT.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(293, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "€"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(21, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Prix de vente HT de nuit"
        '
        'GlookUpClient
        '
        Me.GlookUpClient.EditValue = ""
        Me.GlookUpClient.Location = New System.Drawing.Point(184, 30)
        Me.GlookUpClient.Name = "GlookUpClient"
        Me.GlookUpClient.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GlookUpClient.Properties.DisplayMember = "VCLINOM"
        Me.GlookUpClient.Properties.NullText = ""
        Me.GlookUpClient.Properties.PopupView = Me.GVCbo
        Me.GlookUpClient.Properties.ValueMember = "NCLINUM"
        Me.GlookUpClient.Size = New System.Drawing.Size(301, 20)
        Me.GlookUpClient.TabIndex = 10
        '
        'GVCbo
        '
        Me.GVCbo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCCbo_NCLINUM, Me.GCCboVCLINOM})
        Me.GVCbo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVCbo.Name = "GVCbo"
        Me.GVCbo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVCbo.OptionsView.ShowAutoFilterRow = True
        Me.GVCbo.OptionsView.ShowGroupPanel = False
        '
        'GCCbo_NCLINUM
        '
        Me.GCCbo_NCLINUM.AppearanceHeader.Options.UseTextOptions = True
        Me.GCCbo_NCLINUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCCbo_NCLINUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCCbo_NCLINUM.FieldName = "NCLINUM"
        Me.GCCbo_NCLINUM.Name = "GCCbo_NCLINUM"
        Me.GCCbo_NCLINUM.OptionsColumn.AllowEdit = False
        Me.GCCbo_NCLINUM.OptionsColumn.ReadOnly = True
        Me.GCCbo_NCLINUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GCCboVCLINOM
        '
        Me.GCCboVCLINOM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GCCboVCLINOM.AppearanceHeader.Options.UseFont = True
        Me.GCCboVCLINOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GCCboVCLINOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCCboVCLINOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCCboVCLINOM.Caption = "Client"
        Me.GCCboVCLINOM.FieldName = "VCLINOM"
        Me.GCCboVCLINOM.Name = "GCCboVCLINOM"
        Me.GCCboVCLINOM.OptionsColumn.AllowEdit = False
        Me.GCCboVCLINOM.OptionsColumn.ReadOnly = True
        Me.GCCboVCLINOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCCboVCLINOM.Visible = True
        Me.GCCboVCLINOM.VisibleIndex = 0
        '
        'TxtPrixRevient
        '
        Me.TxtPrixRevient.Location = New System.Drawing.Point(184, 101)
        Me.TxtPrixRevient.Name = "TxtPrixRevient"
        Me.TxtPrixRevient.Properties.AllowFocused = False
        Me.TxtPrixRevient.Properties.EditFormat.FormatString = "n2"
        Me.TxtPrixRevient.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrixRevient.Properties.Mask.EditMask = "n2"
        Me.TxtPrixRevient.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtPrixRevient.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TxtPrixRevient.Properties.ReadOnly = True
        Me.TxtPrixRevient.Size = New System.Drawing.Size(103, 20)
        Me.TxtPrixRevient.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(293, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "€"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Firebrick
        Me.Label5.Location = New System.Drawing.Point(21, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Prix de revient HT"
        '
        'Txt_NPRIXCLIENT
        '
        Me.Txt_NPRIXCLIENT.Location = New System.Drawing.Point(184, 66)
        Me.Txt_NPRIXCLIENT.Name = "Txt_NPRIXCLIENT"
        Me.Txt_NPRIXCLIENT.Properties.EditFormat.FormatString = "n2"
        Me.Txt_NPRIXCLIENT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Txt_NPRIXCLIENT.Properties.Mask.EditMask = "n2"
        Me.Txt_NPRIXCLIENT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Txt_NPRIXCLIENT.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Txt_NPRIXCLIENT.Size = New System.Drawing.Size(103, 20)
        Me.Txt_NPRIXCLIENT.TabIndex = 6
        '
        'BtnSavePrixClient
        '
        Me.BtnSavePrixClient.ForeColor = System.Drawing.Color.Black
        Me.BtnSavePrixClient.Location = New System.Drawing.Point(410, 93)
        Me.BtnSavePrixClient.Name = "BtnSavePrixClient"
        Me.BtnSavePrixClient.Size = New System.Drawing.Size(75, 23)
        Me.BtnSavePrixClient.TabIndex = 5
        Me.BtnSavePrixClient.Text = "Valider"
        Me.BtnSavePrixClient.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(293, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "€"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prix de vente HT de jour"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client"
        '
        'frmGestPrestationPrixClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1133, 575)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmGestPrestationPrixClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des prix clients de prestation"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GCListePrestaPrixClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListePrestaPrixClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Txt_NPRIXCLINUIT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GlookUpClient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCbo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrixRevient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_NPRIXCLIENT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnPrixClientDel As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnPrixClientAdd As Button
    Friend WithEvents GCListePrestaPrixClient As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVListePrestaPrixClient As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GColNCFOCOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox3 As GroupBox
    Private WithEvents Txt_NPRIXCLIENT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnSavePrixClient As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Private WithEvents TxtPrixRevient As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Private WithEvents GlookUpClient As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GVCbo As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCCbo_NCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCCboVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Txt_NPRIXCLINUIT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
