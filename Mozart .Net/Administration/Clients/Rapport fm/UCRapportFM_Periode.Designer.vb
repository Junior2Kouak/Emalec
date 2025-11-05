<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCRapportFM_Periode
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.GColCSITACTIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCCTEANAACTIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LblPeriode2 = New System.Windows.Forms.Label()
        Me.DTP_Fin = New System.Windows.Forms.DateTimePicker()
        Me.DTP_Debut = New System.Windows.Forms.DateTimePicker()
        Me.LblPeriode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboLangue = New System.Windows.Forms.ComboBox()
        Me.GCSITES = New DevExpress.XtraGrid.GridControl()
        Me.GVSITES = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNSITNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GcolNCHECK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GColVSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNSITNUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSITENSEIGNE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSITCP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSITVIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSITPAYS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSITREG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnDecoche = New System.Windows.Forms.Button()
        Me.BtnCoche = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtRapportFM_Titre = New System.Windows.Forms.TextBox()
        Me.ChkAfficheListeSite = New System.Windows.Forms.CheckBox()
        Me.BtnUnCheckAllCAN = New System.Windows.Forms.Button()
        Me.BtnCheckAllCAN = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GCCAN = New DevExpress.XtraGrid.GridControl()
        Me.GVCAN = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_CAN_NCHECK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GColNCANNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCANLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnUnCheckAllContrat = New System.Windows.Forms.Button()
        Me.BtnCheckAllContrat = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GCContrat = New DevExpress.XtraGrid.GridControl()
        Me.GVContrat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GCSITES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSITES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCCAN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCAN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCContrat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVContrat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GColCSITACTIF
        '
        Me.GColCSITACTIF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColCSITACTIF.AppearanceHeader.Options.UseForeColor = True
        Me.GColCSITACTIF.Caption = "Actif"
        Me.GColCSITACTIF.FieldName = "CSITACTIF"
        Me.GColCSITACTIF.Name = "GColCSITACTIF"
        Me.GColCSITACTIF.OptionsColumn.AllowEdit = False
        Me.GColCSITACTIF.OptionsColumn.ReadOnly = True
        Me.GColCSITACTIF.Visible = True
        Me.GColCSITACTIF.VisibleIndex = 7
        '
        'GColCCTEANAACTIF
        '
        Me.GColCCTEANAACTIF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColCCTEANAACTIF.AppearanceHeader.Options.UseForeColor = True
        Me.GColCCTEANAACTIF.Caption = "Actif"
        Me.GColCCTEANAACTIF.FieldName = "CCTEANAACTIF"
        Me.GColCCTEANAACTIF.Name = "GColCCTEANAACTIF"
        Me.GColCCTEANAACTIF.Visible = True
        Me.GColCCTEANAACTIF.VisibleIndex = 3
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn4.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn4.Caption = "Actif"
        Me.GridColumn4.FieldName = "CCTEANAACTIF"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 70
        '
        'LblPeriode2
        '
        Me.LblPeriode2.AutoSize = True
        Me.LblPeriode2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPeriode2.Location = New System.Drawing.Point(476, 71)
        Me.LblPeriode2.Name = "LblPeriode2"
        Me.LblPeriode2.Size = New System.Drawing.Size(25, 16)
        Me.LblPeriode2.TabIndex = 7
        Me.LblPeriode2.Text = "au"
        '
        'DTP_Fin
        '
        Me.DTP_Fin.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_Fin.Location = New System.Drawing.Point(522, 68)
        Me.DTP_Fin.Name = "DTP_Fin"
        Me.DTP_Fin.Size = New System.Drawing.Size(255, 21)
        Me.DTP_Fin.TabIndex = 6
        '
        'DTP_Debut
        '
        Me.DTP_Debut.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_Debut.Location = New System.Drawing.Point(205, 68)
        Me.DTP_Debut.Name = "DTP_Debut"
        Me.DTP_Debut.Size = New System.Drawing.Size(245, 21)
        Me.DTP_Debut.TabIndex = 5
        '
        'LblPeriode
        '
        Me.LblPeriode.AutoSize = True
        Me.LblPeriode.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPeriode.Location = New System.Drawing.Point(38, 71)
        Me.LblPeriode.Name = "LblPeriode"
        Me.LblPeriode.Size = New System.Drawing.Size(78, 16)
        Me.LblPeriode.TabIndex = 4
        Me.LblPeriode.Text = "Période du"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(701, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Choix de la période du rapport FM"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Choix de la langue"
        '
        'CboLangue
        '
        Me.CboLangue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLangue.FormattingEnabled = True
        Me.CboLangue.Location = New System.Drawing.Point(205, 102)
        Me.CboLangue.Name = "CboLangue"
        Me.CboLangue.Size = New System.Drawing.Size(158, 21)
        Me.CboLangue.TabIndex = 10
        '
        'GCSITES
        '
        Me.GCSITES.Location = New System.Drawing.Point(34, 426)
        Me.GCSITES.MainView = Me.GVSITES
        Me.GCSITES.Name = "GCSITES"
        Me.GCSITES.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GCSITES.Size = New System.Drawing.Size(1076, 323)
        Me.GCSITES.TabIndex = 11
        Me.GCSITES.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSITES})
        '
        'GVSITES
        '
        Me.GVSITES.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVSITES.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVSITES.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVSITES.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVSITES.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVSITES.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVSITES.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNSITNUM, Me.GcolNCHECK, Me.GColVSITNOM, Me.GColNSITNUE, Me.GColVSITENSEIGNE, Me.GColVSITCP, Me.GColVSITVIL, Me.GColVSITPAYS, Me.GColCSITACTIF, Me.GColVSITREG})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.GColCSITACTIF
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.Orange
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue1.Expression = "[CSITACTIF] = 'N'"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        Me.GVSITES.FormatRules.Add(GridFormatRule1)
        Me.GVSITES.GridControl = Me.GCSITES
        Me.GVSITES.Name = "GVSITES"
        Me.GVSITES.OptionsView.ShowAutoFilterRow = True
        Me.GVSITES.OptionsView.ShowGroupPanel = False
        '
        'GColNSITNUM
        '
        Me.GColNSITNUM.Caption = "NSITNUM"
        Me.GColNSITNUM.FieldName = "NSITNUM"
        Me.GColNSITNUM.Name = "GColNSITNUM"
        '
        'GcolNCHECK
        '
        Me.GcolNCHECK.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GcolNCHECK.AppearanceHeader.Options.UseForeColor = True
        Me.GcolNCHECK.Caption = "Sélectionner"
        Me.GcolNCHECK.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GcolNCHECK.FieldName = "NCHECK"
        Me.GcolNCHECK.Name = "GcolNCHECK"
        Me.GcolNCHECK.Visible = True
        Me.GcolNCHECK.VisibleIndex = 0
        Me.GcolNCHECK.Width = 80
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit1.ValueChecked = 1
        Me.RepositoryItemCheckEdit1.ValueUnchecked = 0
        '
        'GColVSITNOM
        '
        Me.GColVSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVSITNOM.AppearanceHeader.Options.UseForeColor = True
        Me.GColVSITNOM.Caption = "Nom du Site"
        Me.GColVSITNOM.FieldName = "VSITNOM"
        Me.GColVSITNOM.Name = "GColVSITNOM"
        Me.GColVSITNOM.OptionsColumn.AllowEdit = False
        Me.GColVSITNOM.OptionsColumn.ReadOnly = True
        Me.GColVSITNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVSITNOM.Visible = True
        Me.GColVSITNOM.VisibleIndex = 1
        Me.GColVSITNOM.Width = 220
        '
        'GColNSITNUE
        '
        Me.GColNSITNUE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNSITNUE.AppearanceHeader.Options.UseForeColor = True
        Me.GColNSITNUE.Caption = "N° Site"
        Me.GColNSITNUE.FieldName = "NSITNUE"
        Me.GColNSITNUE.Name = "GColNSITNUE"
        Me.GColNSITNUE.OptionsColumn.AllowEdit = False
        Me.GColNSITNUE.OptionsColumn.ReadOnly = True
        Me.GColNSITNUE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColNSITNUE.Visible = True
        Me.GColNSITNUE.VisibleIndex = 2
        Me.GColNSITNUE.Width = 100
        '
        'GColVSITENSEIGNE
        '
        Me.GColVSITENSEIGNE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVSITENSEIGNE.AppearanceHeader.Options.UseForeColor = True
        Me.GColVSITENSEIGNE.Caption = "Enseigne"
        Me.GColVSITENSEIGNE.FieldName = "VSITENSEIGNE"
        Me.GColVSITENSEIGNE.Name = "GColVSITENSEIGNE"
        Me.GColVSITENSEIGNE.OptionsColumn.AllowEdit = False
        Me.GColVSITENSEIGNE.OptionsColumn.ReadOnly = True
        Me.GColVSITENSEIGNE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVSITENSEIGNE.Visible = True
        Me.GColVSITENSEIGNE.VisibleIndex = 3
        Me.GColVSITENSEIGNE.Width = 162
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
        Me.GColVSITCP.VisibleIndex = 4
        Me.GColVSITCP.Width = 80
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
        Me.GColVSITVIL.VisibleIndex = 5
        Me.GColVSITVIL.Width = 201
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
        Me.GColVSITPAYS.VisibleIndex = 6
        Me.GColVSITPAYS.Width = 215
        '
        'GColVSITREG
        '
        Me.GColVSITREG.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVSITREG.AppearanceHeader.Options.UseForeColor = True
        Me.GColVSITREG.Caption = "Région"
        Me.GColVSITREG.FieldName = "VSITREG"
        Me.GColVSITREG.Name = "GColVSITREG"
        Me.GColVSITREG.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVSITREG.Visible = True
        Me.GColVSITREG.VisibleIndex = 8
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Sélectionner les sites :"
        '
        'BtnDecoche
        '
        Me.BtnDecoche.Location = New System.Drawing.Point(152, 397)
        Me.BtnDecoche.Name = "BtnDecoche"
        Me.BtnDecoche.Size = New System.Drawing.Size(95, 23)
        Me.BtnDecoche.TabIndex = 16
        Me.BtnDecoche.Text = "Décocher tous"
        Me.BtnDecoche.UseVisualStyleBackColor = True
        '
        'BtnCoche
        '
        Me.BtnCoche.Location = New System.Drawing.Point(42, 397)
        Me.BtnCoche.Name = "BtnCoche"
        Me.BtnCoche.Size = New System.Drawing.Size(104, 23)
        Me.BtnCoche.TabIndex = 15
        Me.BtnCoche.Text = "Cocher tous"
        Me.BtnCoche.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 21)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Titre du rapport :"
        '
        'TxtRapportFM_Titre
        '
        Me.TxtRapportFM_Titre.Location = New System.Drawing.Point(205, 138)
        Me.TxtRapportFM_Titre.Name = "TxtRapportFM_Titre"
        Me.TxtRapportFM_Titre.Size = New System.Drawing.Size(591, 20)
        Me.TxtRapportFM_Titre.TabIndex = 18
        '
        'ChkAfficheListeSite
        '
        Me.ChkAfficheListeSite.AutoSize = True
        Me.ChkAfficheListeSite.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ChkAfficheListeSite.Location = New System.Drawing.Point(238, 371)
        Me.ChkAfficheListeSite.Name = "ChkAfficheListeSite"
        Me.ChkAfficheListeSite.Size = New System.Drawing.Size(395, 20)
        Me.ChkAfficheListeSite.TabIndex = 19
        Me.ChkAfficheListeSite.Text = "Afficher la liste des sites sélectionnés dans le rapport FM"
        Me.ChkAfficheListeSite.UseVisualStyleBackColor = True
        '
        'BtnUnCheckAllCAN
        '
        Me.BtnUnCheckAllCAN.Location = New System.Drawing.Point(152, 203)
        Me.BtnUnCheckAllCAN.Name = "BtnUnCheckAllCAN"
        Me.BtnUnCheckAllCAN.Size = New System.Drawing.Size(95, 23)
        Me.BtnUnCheckAllCAN.TabIndex = 23
        Me.BtnUnCheckAllCAN.Text = "Décocher tous"
        Me.BtnUnCheckAllCAN.UseVisualStyleBackColor = True
        '
        'BtnCheckAllCAN
        '
        Me.BtnCheckAllCAN.Location = New System.Drawing.Point(42, 203)
        Me.BtnCheckAllCAN.Name = "BtnCheckAllCAN"
        Me.BtnCheckAllCAN.Size = New System.Drawing.Size(104, 23)
        Me.BtnCheckAllCAN.TabIndex = 22
        Me.BtnCheckAllCAN.Text = "Cocher tous"
        Me.BtnCheckAllCAN.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(448, 21)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Sélectionner les comptes analytiques :"
        '
        'GCCAN
        '
        Me.GCCAN.Location = New System.Drawing.Point(39, 232)
        Me.GCCAN.MainView = Me.GVCAN
        Me.GCCAN.Name = "GCCAN"
        Me.GCCAN.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2})
        Me.GCCAN.Size = New System.Drawing.Size(582, 133)
        Me.GCCAN.TabIndex = 20
        Me.GCCAN.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVCAN})
        '
        'GVCAN
        '
        Me.GVCAN.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVCAN.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVCAN.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVCAN.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVCAN.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVCAN.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVCAN.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_CAN_NCHECK, Me.GColNCANNUM, Me.GColVCANLIB, Me.GColCCTEANAACTIF})
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Column = Me.GColCCTEANAACTIF
        GridFormatRule2.Name = "Format0"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.Orange
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue2.Expression = "[CCTEANAACTIF] = 'N'"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        Me.GVCAN.FormatRules.Add(GridFormatRule2)
        Me.GVCAN.GridControl = Me.GCCAN
        Me.GVCAN.Name = "GVCAN"
        Me.GVCAN.OptionsView.ShowGroupPanel = False
        '
        'GCol_CAN_NCHECK
        '
        Me.GCol_CAN_NCHECK.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_CAN_NCHECK.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_CAN_NCHECK.Caption = "Sélectionner"
        Me.GCol_CAN_NCHECK.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.GCol_CAN_NCHECK.FieldName = "NCHECK"
        Me.GCol_CAN_NCHECK.Name = "GCol_CAN_NCHECK"
        Me.GCol_CAN_NCHECK.Visible = True
        Me.GCol_CAN_NCHECK.VisibleIndex = 0
        Me.GCol_CAN_NCHECK.Width = 80
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit2.ValueChecked = 1
        Me.RepositoryItemCheckEdit2.ValueUnchecked = 0
        '
        'GColNCANNUM
        '
        Me.GColNCANNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNCANNUM.AppearanceHeader.Options.UseForeColor = True
        Me.GColNCANNUM.Caption = "N° Compte"
        Me.GColNCANNUM.FieldName = "NCANNUM"
        Me.GColNCANNUM.Name = "GColNCANNUM"
        Me.GColNCANNUM.OptionsColumn.AllowEdit = False
        Me.GColNCANNUM.OptionsColumn.ReadOnly = True
        Me.GColNCANNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColNCANNUM.Visible = True
        Me.GColNCANNUM.VisibleIndex = 1
        '
        'GColVCANLIB
        '
        Me.GColVCANLIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVCANLIB.AppearanceHeader.Options.UseForeColor = True
        Me.GColVCANLIB.Caption = "Libellé du compte"
        Me.GColVCANLIB.FieldName = "VCANLIB"
        Me.GColVCANLIB.Name = "GColVCANLIB"
        Me.GColVCANLIB.OptionsColumn.AllowEdit = False
        Me.GColVCANLIB.OptionsColumn.ReadOnly = True
        Me.GColVCANLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVCANLIB.Visible = True
        Me.GColVCANLIB.VisibleIndex = 2
        Me.GColVCANLIB.Width = 220
        '
        'BtnUnCheckAllContrat
        '
        Me.BtnUnCheckAllContrat.Location = New System.Drawing.Point(770, 203)
        Me.BtnUnCheckAllContrat.Name = "BtnUnCheckAllContrat"
        Me.BtnUnCheckAllContrat.Size = New System.Drawing.Size(100, 23)
        Me.BtnUnCheckAllContrat.TabIndex = 27
        Me.BtnUnCheckAllContrat.Text = "Décocher tous"
        Me.BtnUnCheckAllContrat.UseVisualStyleBackColor = True
        '
        'BtnCheckAllContrat
        '
        Me.BtnCheckAllContrat.Location = New System.Drawing.Point(669, 203)
        Me.BtnCheckAllContrat.Name = "BtnCheckAllContrat"
        Me.BtnCheckAllContrat.Size = New System.Drawing.Size(95, 23)
        Me.BtnCheckAllContrat.TabIndex = 26
        Me.BtnCheckAllContrat.Text = "Cocher tous"
        Me.BtnCheckAllContrat.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(662, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(334, 21)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Sélectionner les contrats :"
        '
        'GCContrat
        '
        Me.GCContrat.Location = New System.Drawing.Point(666, 232)
        Me.GCContrat.MainView = Me.GVContrat
        Me.GCContrat.Name = "GCContrat"
        Me.GCContrat.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit3})
        Me.GCContrat.Size = New System.Drawing.Size(468, 133)
        Me.GCContrat.TabIndex = 24
        Me.GCContrat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVContrat})
        '
        'GVContrat
        '
        Me.GVContrat.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVContrat.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVContrat.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVContrat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVContrat.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVContrat.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVContrat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn4, Me.GridColumn3})
        GridFormatRule3.ApplyToRow = True
        GridFormatRule3.Column = Me.GridColumn4
        GridFormatRule3.Name = "Format0"
        FormatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.Orange
        FormatConditionRuleValue3.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue3.Expression = "[CCTEANAACTIF] = 'N'"
        GridFormatRule3.Rule = FormatConditionRuleValue3
        Me.GVContrat.FormatRules.Add(GridFormatRule3)
        Me.GVContrat.GridControl = Me.GCContrat
        Me.GVContrat.Name = "GVContrat"
        Me.GVContrat.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn1.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn1.Caption = "Sélectionner"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemCheckEdit3
        Me.GridColumn1.FieldName = "NCHECK"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 80
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        Me.RepositoryItemCheckEdit3.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit3.ValueChecked = 1
        Me.RepositoryItemCheckEdit3.ValueUnchecked = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn2.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn2.Caption = "Contrat"
        Me.GridColumn2.FieldName = "VTYPECONTRAT"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 300
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "NTYPECONTRAT"
        Me.GridColumn3.FieldName = "NTYPECONTRAT"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Width = 220
        '
        'UCRapportFM_Periode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.BtnUnCheckAllContrat)
        Me.Controls.Add(Me.BtnCheckAllContrat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GCContrat)
        Me.Controls.Add(Me.BtnUnCheckAllCAN)
        Me.Controls.Add(Me.BtnCheckAllCAN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GCCAN)
        Me.Controls.Add(Me.ChkAfficheListeSite)
        Me.Controls.Add(Me.TxtRapportFM_Titre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnDecoche)
        Me.Controls.Add(Me.BtnCoche)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GCSITES)
        Me.Controls.Add(Me.CboLangue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblPeriode2)
        Me.Controls.Add(Me.DTP_Fin)
        Me.Controls.Add(Me.DTP_Debut)
        Me.Controls.Add(Me.LblPeriode)
        Me.Name = "UCRapportFM_Periode"
        Me.Size = New System.Drawing.Size(1161, 767)
        CType(Me.GCSITES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSITES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCCAN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCAN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCContrat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVContrat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblPeriode2 As Label
    Friend WithEvents DTP_Fin As DateTimePicker
    Friend WithEvents DTP_Debut As DateTimePicker
    Friend WithEvents LblPeriode As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CboLangue As ComboBox
    Friend WithEvents GCSITES As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSITES As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label3 As Label
    Friend WithEvents GColNSITNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNSITNUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVSITENSEIGNE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVSITCP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVSITVIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVSITPAYS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GcolNCHECK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BtnDecoche As Button
    Friend WithEvents BtnCoche As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtRapportFM_Titre As TextBox
    Friend WithEvents ChkAfficheListeSite As CheckBox
    Friend WithEvents BtnUnCheckAllCAN As Button
    Friend WithEvents BtnCheckAllCAN As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GCCAN As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVCAN As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GColNCANNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_CAN_NCHECK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GColVCANLIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColCSITACTIF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColCCTEANAACTIF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVSITREG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnUnCheckAllContrat As Button
    Friend WithEvents BtnCheckAllContrat As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents GCContrat As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVContrat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
