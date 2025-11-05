<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestionAccessGroup
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
    Me.GCPersGroupe = New DevExpress.XtraGrid.GridControl()
    Me.GVPersGroupe = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GCol_NPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_VPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_FONC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SERVICE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VSOCIETE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VPERADSI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnMenuSensible = New System.Windows.Forms.Button()
        Me.BtnDelUser = New System.Windows.Forms.Button()
        Me.BtnGestionProfilType = New System.Windows.Forms.Button()
        Me.BtnDroitsParMenu = New System.Windows.Forms.Button()
        Me.BtnCreateProfilOnFiliale = New System.Windows.Forms.Button()
        Me.BtnCopyProfil = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TreeList_Menu = New DevExpress.XtraTreeList.TreeList()
        Me.TreeCol_VMENULIB = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_NPERNUM_EMALEC = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_CDROIT_EMALEC = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.RepItemChk_CDROIT = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.TreeCol_NPERNUM_EMALECBELGIQUE = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_CDROIT_BELGIQUE = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_NPERNUM_EMALECIDF = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_CDROIT_IDF = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_NPERNUM_EQUIPAGE = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_CDROIT_EQUIPAGE = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_NPERNUM_MAGESTIME = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_CDROIT_MAGESTIME = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_NPERNUM_EMALECESPAGNE = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_CDROIT_EMALECESPAGNE = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_NPERNUM_SCS = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_CDROIT_SCS = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_NPERNUM_EMALECLUXEMBOURG = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_CDROIT_EMALECLUXEMBOURG = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_NPERNUM_EMALECFACILITEAM = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_CDROIT_EMALECFACILITEAM = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_NPERNUM_EMALECSUISSE = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_CDROIT_EMALECSUISSE = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_NPERNUM_EMALECMPM = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_CDROIT_EMALECMPM = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_NPERNUM_ALC = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_CDROIT_ALC = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_NPERNUM_EMAFI = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_CDROIT_EMAFI = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_NPERNUM_DEV = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeCol_CDROIT_DEV = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.BtnCheckedAll = New System.Windows.Forms.Button()
        Me.BtnUnCheckedAll = New System.Windows.Forms.Button()
        Me.BtnExportXLS = New System.Windows.Forms.Button()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        CType(Me.GCPersGroupe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPersGroupe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TreeList_Menu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChk_CDROIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCPersGroupe
        '
        Me.GCPersGroupe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GCPersGroupe.Location = New System.Drawing.Point(147, 53)
        Me.GCPersGroupe.MainView = Me.GVPersGroupe
        Me.GCPersGroupe.Name = "GCPersGroupe"
        Me.GCPersGroupe.Size = New System.Drawing.Size(461, 887)
        Me.GCPersGroupe.TabIndex = 50
        Me.GCPersGroupe.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPersGroupe})
        '
        'GVPersGroupe
        '
        Me.GVPersGroupe.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVPersGroupe.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVPersGroupe.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVPersGroupe.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVPersGroupe.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_NPERNUM, Me.GCol_VPERNOM, Me.GCol_FONC, Me.GCol_SERVICE, Me.GCol_VSOCIETE, Me.GCol_VPERADSI})
        Me.GVPersGroupe.GridControl = Me.GCPersGroupe
        Me.GVPersGroupe.Name = "GVPersGroupe"
        Me.GVPersGroupe.OptionsBehavior.Editable = False
        Me.GVPersGroupe.OptionsBehavior.ReadOnly = True
        Me.GVPersGroupe.OptionsCustomization.AllowGroup = False
        Me.GVPersGroupe.OptionsPrint.PrintPreview = True
        Me.GVPersGroupe.OptionsView.ShowAutoFilterRow = True
        Me.GVPersGroupe.OptionsView.ShowFooter = True
        Me.GVPersGroupe.OptionsView.ShowGroupPanel = False
        '
        'GCol_NPERNUM
        '
        Me.GCol_NPERNUM.FieldName = "NPERNUM"
        Me.GCol_NPERNUM.Name = "GCol_NPERNUM"
        Me.GCol_NPERNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_NPERNUM.Width = 130
        '
        'GCol_VPERNOM
        '
        Me.GCol_VPERNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VPERNOM.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VPERNOM.Caption = "Nom"
        Me.GCol_VPERNOM.FieldName = "VPERNOM"
        Me.GCol_VPERNOM.Name = "GCol_VPERNOM"
        Me.GCol_VPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_VPERNOM.Visible = True
        Me.GCol_VPERNOM.VisibleIndex = 0
        Me.GCol_VPERNOM.Width = 141
        '
        'GCol_FONC
        '
        Me.GCol_FONC.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_FONC.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_FONC.Caption = "Fonction"
        Me.GCol_FONC.FieldName = "FONC"
        Me.GCol_FONC.Name = "GCol_FONC"
        Me.GCol_FONC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_FONC.Visible = True
        Me.GCol_FONC.VisibleIndex = 1
        Me.GCol_FONC.Width = 97
        '
        'GCol_SERVICE
        '
        Me.GCol_SERVICE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_SERVICE.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_SERVICE.Caption = "Service"
        Me.GCol_SERVICE.FieldName = "VSERLIB"
        Me.GCol_SERVICE.Name = "GCol_SERVICE"
        Me.GCol_SERVICE.Visible = True
        Me.GCol_SERVICE.VisibleIndex = 2
        Me.GCol_SERVICE.Width = 105
        '
        'GCol_VSOCIETE
        '
        Me.GCol_VSOCIETE.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_VSOCIETE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_VSOCIETE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_VSOCIETE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VSOCIETE.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VSOCIETE.Caption = "Société"
        Me.GCol_VSOCIETE.FieldName = "VSOCIETE"
        Me.GCol_VSOCIETE.Name = "GCol_VSOCIETE"
        Me.GCol_VSOCIETE.Visible = True
        Me.GCol_VSOCIETE.VisibleIndex = 3
        Me.GCol_VSOCIETE.Width = 93
        '
        'GCol_VPERADSI
        '
        Me.GCol_VPERADSI.Caption = "VPERADSI"
        Me.GCol_VPERADSI.FieldName = "VPERADSI"
        Me.GCol_VPERADSI.Name = "GCol_VPERADSI"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnMenuSensible)
        Me.GroupBox1.Controls.Add(Me.BtnDelUser)
        Me.GroupBox1.Controls.Add(Me.BtnGestionProfilType)
        Me.GroupBox1.Controls.Add(Me.BtnDroitsParMenu)
        Me.GroupBox1.Controls.Add(Me.BtnCreateProfilOnFiliale)
        Me.GroupBox1.Controls.Add(Me.BtnCopyProfil)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(129, 857)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        '
        'btnMenuSensible
        '
        Me.btnMenuSensible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnMenuSensible.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnMenuSensible.Location = New System.Drawing.Point(9, 610)
        Me.btnMenuSensible.Name = "btnMenuSensible"
        Me.btnMenuSensible.Size = New System.Drawing.Size(110, 52)
        Me.btnMenuSensible.TabIndex = 7
        Me.btnMenuSensible.Text = "Gestion des menus sensibles"
        Me.btnMenuSensible.UseVisualStyleBackColor = True
        '
        'BtnDelUser
        '
        Me.BtnDelUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnDelUser.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnDelUser.Location = New System.Drawing.Point(6, 199)
        Me.BtnDelUser.Name = "BtnDelUser"
        Me.BtnDelUser.Size = New System.Drawing.Size(110, 52)
        Me.BtnDelUser.TabIndex = 6
        Me.BtnDelUser.Text = "Supprimer un utilisateur sur filiale"
        Me.BtnDelUser.UseVisualStyleBackColor = True
        '
        'BtnGestionProfilType
        '
        Me.BtnGestionProfilType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnGestionProfilType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnGestionProfilType.Location = New System.Drawing.Point(9, 512)
        Me.BtnGestionProfilType.Name = "BtnGestionProfilType"
        Me.BtnGestionProfilType.Size = New System.Drawing.Size(110, 52)
        Me.BtnGestionProfilType.TabIndex = 5
        Me.BtnGestionProfilType.Text = "Gestion Droits par profil type"
        Me.BtnGestionProfilType.UseVisualStyleBackColor = True
        '
        'BtnDroitsParMenu
        '
        Me.BtnDroitsParMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnDroitsParMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnDroitsParMenu.Location = New System.Drawing.Point(9, 402)
        Me.BtnDroitsParMenu.Name = "BtnDroitsParMenu"
        Me.BtnDroitsParMenu.Size = New System.Drawing.Size(110, 52)
        Me.BtnDroitsParMenu.TabIndex = 4
        Me.BtnDroitsParMenu.Text = "Gestion Droits par Menu"
        Me.BtnDroitsParMenu.UseVisualStyleBackColor = True
        '
        'BtnCreateProfilOnFiliale
        '
        Me.BtnCreateProfilOnFiliale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnCreateProfilOnFiliale.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCreateProfilOnFiliale.Location = New System.Drawing.Point(6, 107)
        Me.BtnCreateProfilOnFiliale.Name = "BtnCreateProfilOnFiliale"
        Me.BtnCreateProfilOnFiliale.Size = New System.Drawing.Size(110, 52)
        Me.BtnCreateProfilOnFiliale.TabIndex = 3
        Me.BtnCreateProfilOnFiliale.Text = "Créer un utilisateur sur filiale"
        Me.BtnCreateProfilOnFiliale.UseVisualStyleBackColor = True
        '
        'BtnCopyProfil
        '
        Me.BtnCopyProfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnCopyProfil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCopyProfil.Location = New System.Drawing.Point(7, 41)
        Me.BtnCopyProfil.Name = "BtnCopyProfil"
        Me.BtnCopyProfil.Size = New System.Drawing.Size(110, 51)
        Me.BtnCopyProfil.TabIndex = 2
        Me.BtnCopyProfil.Text = "Copier Profil vers autre profil"
        Me.BtnCopyProfil.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(7, 803)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(109, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelTitre.Location = New System.Drawing.Point(157, 12)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(317, 29)
        Me.LabelTitre.TabIndex = 48
        Me.LabelTitre.Text = "Liste du personnel groupe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(609, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 29)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Liste des menus"
        '
        'TreeList_Menu
        '
        Me.TreeList_Menu.Appearance.FocusedCell.BackColor = System.Drawing.Color.SkyBlue
        Me.TreeList_Menu.Appearance.FocusedCell.Options.UseBackColor = True
        Me.TreeList_Menu.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue
        Me.TreeList_Menu.Appearance.FocusedRow.Options.UseBackColor = True
        Me.TreeList_Menu.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TreeList_Menu.Appearance.HeaderPanel.Options.UseFont = True
        Me.TreeList_Menu.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.TreeList_Menu.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TreeList_Menu.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TreeList_Menu.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TreeList_Menu.Appearance.SelectedRow.BackColor = System.Drawing.Color.SkyBlue
        Me.TreeList_Menu.Appearance.SelectedRow.Options.UseBackColor = True
        Me.TreeList_Menu.ColumnPanelRowHeight = 50
        Me.TreeList_Menu.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeCol_VMENULIB, Me.TreeCol_NPERNUM_EMALEC, Me.TreeCol_CDROIT_EMALEC, Me.TreeCol_NPERNUM_EMALECBELGIQUE, Me.TreeCol_CDROIT_BELGIQUE, Me.TreeCol_NPERNUM_EMALECIDF, Me.TreeCol_CDROIT_IDF, Me.TreeCol_NPERNUM_EQUIPAGE, Me.TreeCol_CDROIT_EQUIPAGE, Me.TreeCol_NPERNUM_MAGESTIME, Me.TreeCol_CDROIT_MAGESTIME, Me.TreeCol_NPERNUM_EMALECESPAGNE, Me.TreeCol_CDROIT_EMALECESPAGNE, Me.TreeCol_NPERNUM_SCS, Me.TreeCol_CDROIT_SCS, Me.TreeCol_NPERNUM_EMALECLUXEMBOURG, Me.TreeCol_CDROIT_EMALECLUXEMBOURG, Me.TreeCol_NPERNUM_EMALECFACILITEAM, Me.TreeCol_CDROIT_EMALECFACILITEAM, Me.TreeCol_NPERNUM_EMALECSUISSE, Me.TreeCol_CDROIT_EMALECSUISSE, Me.TreeCol_NPERNUM_EMALECMPM, Me.TreeCol_CDROIT_EMALECMPM, Me.TreeCol_NPERNUM_ALC, Me.TreeCol_CDROIT_ALC, Me.TreeCol_NPERNUM_EMAFI, Me.TreeCol_CDROIT_EMAFI, Me.TreeCol_NPERNUM_DEV, Me.TreeCol_CDROIT_DEV})
        Me.TreeList_Menu.Cursor = System.Windows.Forms.Cursors.Default
        Me.TreeList_Menu.CustomizationFormBounds = New System.Drawing.Rectangle(1551, 774, 250, 200)
        Me.TreeList_Menu.FooterPanelHeight = 10
        Me.TreeList_Menu.KeyFieldName = "NMENUNUM"
        Me.TreeList_Menu.Location = New System.Drawing.Point(614, 53)
        Me.TreeList_Menu.Name = "TreeList_Menu"
        Me.TreeList_Menu.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.MouseUp
        Me.TreeList_Menu.OptionsBehavior.PopulateServiceColumns = True
        Me.TreeList_Menu.OptionsView.ShowSummaryFooter = True
        Me.TreeList_Menu.ParentFieldName = "NMENUPARENT"
        Me.TreeList_Menu.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChk_CDROIT})
        Me.TreeList_Menu.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowOnlyInEditor
        Me.TreeList_Menu.Size = New System.Drawing.Size(1247, 887)
        Me.TreeList_Menu.TabIndex = 53
        '
        'TreeCol_VMENULIB
        '
        Me.TreeCol_VMENULIB.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TreeCol_VMENULIB.AppearanceCell.Options.UseFont = True
        Me.TreeCol_VMENULIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TreeCol_VMENULIB.AppearanceHeader.Options.UseForeColor = True
        Me.TreeCol_VMENULIB.Caption = "Menu"
        Me.TreeCol_VMENULIB.FieldName = "VMENULIB"
        Me.TreeCol_VMENULIB.Name = "TreeCol_VMENULIB"
        Me.TreeCol_VMENULIB.OptionsColumn.AllowEdit = False
        Me.TreeCol_VMENULIB.OptionsColumn.AllowMove = False
        Me.TreeCol_VMENULIB.OptionsColumn.AllowSort = False
        Me.TreeCol_VMENULIB.OptionsColumn.ReadOnly = True
        Me.TreeCol_VMENULIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraTreeList.Columns.AutoFilterCondition.Contains
        Me.TreeCol_VMENULIB.Visible = True
        Me.TreeCol_VMENULIB.VisibleIndex = 0
        Me.TreeCol_VMENULIB.Width = 180
        '
        'TreeCol_NPERNUM_EMALEC
        '
        Me.TreeCol_NPERNUM_EMALEC.Caption = "NPERNUM_EMALEC"
        Me.TreeCol_NPERNUM_EMALEC.FieldName = "NPERNUM_EMALEC"
        Me.TreeCol_NPERNUM_EMALEC.Name = "TreeCol_NPERNUM_EMALEC"
        '
        'TreeCol_CDROIT_EMALEC
        '
        Me.TreeCol_CDROIT_EMALEC.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TreeCol_CDROIT_EMALEC.AppearanceHeader.Options.UseForeColor = True
        Me.TreeCol_CDROIT_EMALEC.Caption = "EMALEC"
        Me.TreeCol_CDROIT_EMALEC.ColumnEdit = Me.RepItemChk_CDROIT
        Me.TreeCol_CDROIT_EMALEC.FieldName = "CDROIT_EMALEC"
        Me.TreeCol_CDROIT_EMALEC.Name = "TreeCol_CDROIT_EMALEC"
        Me.TreeCol_CDROIT_EMALEC.OptionsColumn.AllowMove = False
        Me.TreeCol_CDROIT_EMALEC.OptionsColumn.AllowSort = False
        Me.TreeCol_CDROIT_EMALEC.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom
        Me.TreeCol_CDROIT_EMALEC.Visible = True
        Me.TreeCol_CDROIT_EMALEC.VisibleIndex = 1
        '
        'RepItemChk_CDROIT
        '
        Me.RepItemChk_CDROIT.AutoHeight = False
        Me.RepItemChk_CDROIT.Name = "RepItemChk_CDROIT"
        Me.RepItemChk_CDROIT.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChk_CDROIT.ValueChecked = "O"
        Me.RepItemChk_CDROIT.ValueUnchecked = "N"
        '
        'TreeCol_NPERNUM_EMALECBELGIQUE
        '
        Me.TreeCol_NPERNUM_EMALECBELGIQUE.Caption = "NPERNUM_EMALECBELGIQUE"
        Me.TreeCol_NPERNUM_EMALECBELGIQUE.FieldName = "NPERNUM_EMALECBELGIQUE"
        Me.TreeCol_NPERNUM_EMALECBELGIQUE.Name = "TreeCol_NPERNUM_EMALECBELGIQUE"
        '
        'TreeCol_CDROIT_BELGIQUE
        '
        Me.TreeCol_CDROIT_BELGIQUE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TreeCol_CDROIT_BELGIQUE.AppearanceHeader.Options.UseForeColor = True
        Me.TreeCol_CDROIT_BELGIQUE.Caption = "EMALEC BELGIQUE"
        Me.TreeCol_CDROIT_BELGIQUE.ColumnEdit = Me.RepItemChk_CDROIT
        Me.TreeCol_CDROIT_BELGIQUE.FieldName = "CDROIT_BELGIQUE"
        Me.TreeCol_CDROIT_BELGIQUE.Name = "TreeCol_CDROIT_BELGIQUE"
        Me.TreeCol_CDROIT_BELGIQUE.OptionsColumn.AllowMove = False
        Me.TreeCol_CDROIT_BELGIQUE.OptionsColumn.AllowSort = False
        Me.TreeCol_CDROIT_BELGIQUE.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom
        Me.TreeCol_CDROIT_BELGIQUE.Visible = True
        Me.TreeCol_CDROIT_BELGIQUE.VisibleIndex = 2
        '
        'TreeCol_NPERNUM_EMALECIDF
        '
        Me.TreeCol_NPERNUM_EMALECIDF.Caption = "NPERNUM_EMALECIDF"
        Me.TreeCol_NPERNUM_EMALECIDF.FieldName = "NPERNUM_EMALECIDF"
        Me.TreeCol_NPERNUM_EMALECIDF.Name = "TreeCol_NPERNUM_EMALECIDF"
        '
        'TreeCol_CDROIT_IDF
        '
        Me.TreeCol_CDROIT_IDF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TreeCol_CDROIT_IDF.AppearanceHeader.Options.UseForeColor = True
        Me.TreeCol_CDROIT_IDF.Caption = "EMALEC IDF"
        Me.TreeCol_CDROIT_IDF.ColumnEdit = Me.RepItemChk_CDROIT
        Me.TreeCol_CDROIT_IDF.FieldName = "CDROIT_IDF"
        Me.TreeCol_CDROIT_IDF.Name = "TreeCol_CDROIT_IDF"
        Me.TreeCol_CDROIT_IDF.OptionsColumn.AllowMove = False
        Me.TreeCol_CDROIT_IDF.OptionsColumn.AllowSort = False
        Me.TreeCol_CDROIT_IDF.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom
        Me.TreeCol_CDROIT_IDF.Visible = True
        Me.TreeCol_CDROIT_IDF.VisibleIndex = 3
        '
        'TreeCol_NPERNUM_EQUIPAGE
        '
        Me.TreeCol_NPERNUM_EQUIPAGE.Caption = "NPERNUM_EQUIPAGE"
        Me.TreeCol_NPERNUM_EQUIPAGE.FieldName = "NPERNUM_EQUIPAGE"
        Me.TreeCol_NPERNUM_EQUIPAGE.Name = "TreeCol_NPERNUM_EQUIPAGE"
        '
        'TreeCol_CDROIT_EQUIPAGE
        '
        Me.TreeCol_CDROIT_EQUIPAGE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TreeCol_CDROIT_EQUIPAGE.AppearanceHeader.Options.UseForeColor = True
        Me.TreeCol_CDROIT_EQUIPAGE.Caption = "EQUIPAGE"
        Me.TreeCol_CDROIT_EQUIPAGE.ColumnEdit = Me.RepItemChk_CDROIT
        Me.TreeCol_CDROIT_EQUIPAGE.FieldName = "CDROIT_EQUIPAGE"
        Me.TreeCol_CDROIT_EQUIPAGE.Name = "TreeCol_CDROIT_EQUIPAGE"
        Me.TreeCol_CDROIT_EQUIPAGE.OptionsColumn.AllowMove = False
        Me.TreeCol_CDROIT_EQUIPAGE.OptionsColumn.AllowSort = False
        Me.TreeCol_CDROIT_EQUIPAGE.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom
        Me.TreeCol_CDROIT_EQUIPAGE.Visible = True
        Me.TreeCol_CDROIT_EQUIPAGE.VisibleIndex = 4
        '
        'TreeCol_NPERNUM_MAGESTIME
        '
        Me.TreeCol_NPERNUM_MAGESTIME.Caption = "NPERNUM_MAGESTIME"
        Me.TreeCol_NPERNUM_MAGESTIME.FieldName = "NPERNUM_MAGESTIME"
        Me.TreeCol_NPERNUM_MAGESTIME.Name = "TreeCol_NPERNUM_MAGESTIME"
        '
        'TreeCol_CDROIT_MAGESTIME
        '
        Me.TreeCol_CDROIT_MAGESTIME.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TreeCol_CDROIT_MAGESTIME.AppearanceHeader.Options.UseForeColor = True
        Me.TreeCol_CDROIT_MAGESTIME.Caption = "MAGESTIME"
        Me.TreeCol_CDROIT_MAGESTIME.ColumnEdit = Me.RepItemChk_CDROIT
        Me.TreeCol_CDROIT_MAGESTIME.FieldName = "CDROIT_MAGESTIME"
        Me.TreeCol_CDROIT_MAGESTIME.Name = "TreeCol_CDROIT_MAGESTIME"
        Me.TreeCol_CDROIT_MAGESTIME.OptionsColumn.AllowMove = False
        Me.TreeCol_CDROIT_MAGESTIME.OptionsColumn.AllowSort = False
        Me.TreeCol_CDROIT_MAGESTIME.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom
        Me.TreeCol_CDROIT_MAGESTIME.Visible = True
        Me.TreeCol_CDROIT_MAGESTIME.VisibleIndex = 5
        '
        'TreeCol_NPERNUM_EMALECESPAGNE
        '
        Me.TreeCol_NPERNUM_EMALECESPAGNE.Caption = "NPERNUM_EMALECESPAGNE"
        Me.TreeCol_NPERNUM_EMALECESPAGNE.FieldName = "NPERNUM_EMALECESPAGNE"
        Me.TreeCol_NPERNUM_EMALECESPAGNE.Name = "TreeCol_NPERNUM_EMALECESPAGNE"
        '
        'TreeCol_CDROIT_EMALECESPAGNE
        '
        Me.TreeCol_CDROIT_EMALECESPAGNE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TreeCol_CDROIT_EMALECESPAGNE.AppearanceHeader.Options.UseForeColor = True
        Me.TreeCol_CDROIT_EMALECESPAGNE.Caption = "EMALEC ESPAGNE"
        Me.TreeCol_CDROIT_EMALECESPAGNE.ColumnEdit = Me.RepItemChk_CDROIT
        Me.TreeCol_CDROIT_EMALECESPAGNE.FieldName = "CDROIT_EMALECESPAGNE"
        Me.TreeCol_CDROIT_EMALECESPAGNE.Name = "TreeCol_CDROIT_EMALECESPAGNE"
        Me.TreeCol_CDROIT_EMALECESPAGNE.OptionsColumn.AllowMove = False
        Me.TreeCol_CDROIT_EMALECESPAGNE.OptionsColumn.AllowSort = False
        Me.TreeCol_CDROIT_EMALECESPAGNE.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom
        Me.TreeCol_CDROIT_EMALECESPAGNE.Visible = True
        Me.TreeCol_CDROIT_EMALECESPAGNE.VisibleIndex = 6
        '
        'TreeCol_NPERNUM_SCS
        '
        Me.TreeCol_NPERNUM_SCS.Caption = "NPERNUM_SCS"
        Me.TreeCol_NPERNUM_SCS.FieldName = "NPERNUM_SCS"
        Me.TreeCol_NPERNUM_SCS.Name = "TreeCol_NPERNUM_SCS"
        '
        'TreeCol_CDROIT_SCS
        '
        Me.TreeCol_CDROIT_SCS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TreeCol_CDROIT_SCS.AppearanceHeader.Options.UseForeColor = True
        Me.TreeCol_CDROIT_SCS.Caption = "SCS"
        Me.TreeCol_CDROIT_SCS.ColumnEdit = Me.RepItemChk_CDROIT
        Me.TreeCol_CDROIT_SCS.FieldName = "CDROIT_SCS"
        Me.TreeCol_CDROIT_SCS.Name = "TreeCol_CDROIT_SCS"
        Me.TreeCol_CDROIT_SCS.OptionsColumn.AllowMove = False
        Me.TreeCol_CDROIT_SCS.OptionsColumn.AllowSort = False
        Me.TreeCol_CDROIT_SCS.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom
        Me.TreeCol_CDROIT_SCS.Visible = True
        Me.TreeCol_CDROIT_SCS.VisibleIndex = 7
        '
        'TreeCol_NPERNUM_EMALECLUXEMBOURG
        '
        Me.TreeCol_NPERNUM_EMALECLUXEMBOURG.Caption = "NPERNUM_EMALECLUXEMBOURG"
        Me.TreeCol_NPERNUM_EMALECLUXEMBOURG.FieldName = "NPERNUM_EMALECLUXEMBOURG"
        Me.TreeCol_NPERNUM_EMALECLUXEMBOURG.Name = "TreeCol_NPERNUM_EMALECLUXEMBOURG"
        '
        'TreeCol_CDROIT_EMALECLUXEMBOURG
        '
        Me.TreeCol_CDROIT_EMALECLUXEMBOURG.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TreeCol_CDROIT_EMALECLUXEMBOURG.AppearanceHeader.Options.UseForeColor = True
        Me.TreeCol_CDROIT_EMALECLUXEMBOURG.Caption = "EMALEC LUXEMBOURG"
        Me.TreeCol_CDROIT_EMALECLUXEMBOURG.ColumnEdit = Me.RepItemChk_CDROIT
        Me.TreeCol_CDROIT_EMALECLUXEMBOURG.FieldName = "CDROIT_EMALECLUXEMBOURG"
        Me.TreeCol_CDROIT_EMALECLUXEMBOURG.Name = "TreeCol_CDROIT_EMALECLUXEMBOURG"
        Me.TreeCol_CDROIT_EMALECLUXEMBOURG.OptionsColumn.AllowMove = False
        Me.TreeCol_CDROIT_EMALECLUXEMBOURG.OptionsColumn.AllowSort = False
        Me.TreeCol_CDROIT_EMALECLUXEMBOURG.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom
        Me.TreeCol_CDROIT_EMALECLUXEMBOURG.Visible = True
        Me.TreeCol_CDROIT_EMALECLUXEMBOURG.VisibleIndex = 8
        '
        'TreeCol_NPERNUM_EMALECFACILITEAM
        '
        Me.TreeCol_NPERNUM_EMALECFACILITEAM.Caption = "NPERNUM_EMALECFACILITEAM"
        Me.TreeCol_NPERNUM_EMALECFACILITEAM.FieldName = "NPERNUM_EMALECFACILITEAM"
        Me.TreeCol_NPERNUM_EMALECFACILITEAM.Name = "TreeCol_NPERNUM_EMALECFACILITEAM"
        '
        'TreeCol_CDROIT_EMALECFACILITEAM
        '
        Me.TreeCol_CDROIT_EMALECFACILITEAM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TreeCol_CDROIT_EMALECFACILITEAM.AppearanceHeader.Options.UseForeColor = True
        Me.TreeCol_CDROIT_EMALECFACILITEAM.Caption = "EMALEC FACILITEAM"
        Me.TreeCol_CDROIT_EMALECFACILITEAM.ColumnEdit = Me.RepItemChk_CDROIT
        Me.TreeCol_CDROIT_EMALECFACILITEAM.FieldName = "CDROIT_EMALECFACILITEAM"
        Me.TreeCol_CDROIT_EMALECFACILITEAM.Name = "TreeCol_CDROIT_EMALECFACILITEAM"
        Me.TreeCol_CDROIT_EMALECFACILITEAM.OptionsColumn.AllowMove = False
        Me.TreeCol_CDROIT_EMALECFACILITEAM.OptionsColumn.AllowSort = False
        Me.TreeCol_CDROIT_EMALECFACILITEAM.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom
        Me.TreeCol_CDROIT_EMALECFACILITEAM.Visible = True
        Me.TreeCol_CDROIT_EMALECFACILITEAM.VisibleIndex = 9
        '
        'TreeCol_NPERNUM_EMALECSUISSE
        '
        Me.TreeCol_NPERNUM_EMALECSUISSE.Caption = "NPERNUM_EMALECSUISSE"
        Me.TreeCol_NPERNUM_EMALECSUISSE.FieldName = "NPERNUM_EMALECSUISSE"
        Me.TreeCol_NPERNUM_EMALECSUISSE.Name = "TreeCol_NPERNUM_EMALECSUISSE"
        '
        'TreeCol_CDROIT_EMALECSUISSE
        '
        Me.TreeCol_CDROIT_EMALECSUISSE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TreeCol_CDROIT_EMALECSUISSE.AppearanceHeader.Options.UseForeColor = True
        Me.TreeCol_CDROIT_EMALECSUISSE.Caption = "EMALEC SUISSE"
        Me.TreeCol_CDROIT_EMALECSUISSE.ColumnEdit = Me.RepItemChk_CDROIT
        Me.TreeCol_CDROIT_EMALECSUISSE.FieldName = "CDROIT_EMALECSUISSE"
        Me.TreeCol_CDROIT_EMALECSUISSE.Name = "TreeCol_CDROIT_EMALECSUISSE"
        Me.TreeCol_CDROIT_EMALECSUISSE.OptionsColumn.AllowMove = False
        Me.TreeCol_CDROIT_EMALECSUISSE.OptionsColumn.AllowSort = False
        Me.TreeCol_CDROIT_EMALECSUISSE.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom
        Me.TreeCol_CDROIT_EMALECSUISSE.Visible = True
        Me.TreeCol_CDROIT_EMALECSUISSE.VisibleIndex = 10
        '
        'TreeCol_NPERNUM_EMALECMPM
        '
        Me.TreeCol_NPERNUM_EMALECMPM.Caption = "NPERNUM_EMALECMPM"
        Me.TreeCol_NPERNUM_EMALECMPM.FieldName = "NPERNUM_EMALECMPM"
        Me.TreeCol_NPERNUM_EMALECMPM.Name = "TreeCol_NPERNUM_EMALECMPM"
        '
        'TreeCol_CDROIT_EMALECMPM
        '
        Me.TreeCol_CDROIT_EMALECMPM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TreeCol_CDROIT_EMALECMPM.AppearanceHeader.Options.UseForeColor = True
        Me.TreeCol_CDROIT_EMALECMPM.Caption = "EMALEC MPM"
        Me.TreeCol_CDROIT_EMALECMPM.ColumnEdit = Me.RepItemChk_CDROIT
        Me.TreeCol_CDROIT_EMALECMPM.FieldName = "CDROIT_EMALECMPM"
        Me.TreeCol_CDROIT_EMALECMPM.Name = "TreeCol_CDROIT_EMALECMPM"
        Me.TreeCol_CDROIT_EMALECMPM.Visible = True
        Me.TreeCol_CDROIT_EMALECMPM.VisibleIndex = 11
        '
        'TreeCol_NPERNUM_ALC
        '
        Me.TreeCol_NPERNUM_ALC.Caption = "NPERNUM_ALC"
        Me.TreeCol_NPERNUM_ALC.FieldName = "NPERNUM_ALC"
        Me.TreeCol_NPERNUM_ALC.Name = "TreeCol_NPERNUM_ALC"
        '
        'TreeCol_CDROIT_ALC
        '
        Me.TreeCol_CDROIT_ALC.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TreeCol_CDROIT_ALC.AppearanceHeader.Options.UseForeColor = True
        Me.TreeCol_CDROIT_ALC.Caption = "ALC"
        Me.TreeCol_CDROIT_ALC.ColumnEdit = Me.RepItemChk_CDROIT
        Me.TreeCol_CDROIT_ALC.FieldName = "CDROIT_ALC"
        Me.TreeCol_CDROIT_ALC.Name = "TreeCol_CDROIT_ALC"
        Me.TreeCol_CDROIT_ALC.Visible = True
        Me.TreeCol_CDROIT_ALC.VisibleIndex = 12
        '
        'TreeCol_NPERNUM_EMAFI
        '
        Me.TreeCol_NPERNUM_EMAFI.Caption = "NPERNUM_EMAFI"
        Me.TreeCol_NPERNUM_EMAFI.FieldName = "NPERNUM_EMAFI"
        Me.TreeCol_NPERNUM_EMAFI.Name = "TreeCol_NPERNUM_EMAFI"
        '
        'TreeCol_CDROIT_EMAFI
        '
        Me.TreeCol_CDROIT_EMAFI.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TreeCol_CDROIT_EMAFI.AppearanceHeader.Options.UseForeColor = True
        Me.TreeCol_CDROIT_EMAFI.Caption = "EMAFI"
        Me.TreeCol_CDROIT_EMAFI.ColumnEdit = Me.RepItemChk_CDROIT
        Me.TreeCol_CDROIT_EMAFI.FieldName = "CDROIT_EMAFI"
        Me.TreeCol_CDROIT_EMAFI.Name = "TreeCol_CDROIT_EMAFI"
        Me.TreeCol_CDROIT_EMAFI.Visible = True
        Me.TreeCol_CDROIT_EMAFI.VisibleIndex = 13
        '
        'TreeCol_NPERNUM_DEV
        '
        Me.TreeCol_NPERNUM_DEV.FieldName = "NPERNUM_DEV"
        Me.TreeCol_NPERNUM_DEV.Name = "TreeCol_NPERNUM_DEV"
        '
        'TreeCol_CDROIT_DEV
        '
        Me.TreeCol_CDROIT_DEV.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TreeCol_CDROIT_DEV.AppearanceHeader.Options.UseForeColor = True
        Me.TreeCol_CDROIT_DEV.Caption = "EMALEC DEV"
        Me.TreeCol_CDROIT_DEV.ColumnEdit = Me.RepItemChk_CDROIT
        Me.TreeCol_CDROIT_DEV.FieldName = "CDROIT_EMALECDEV"
        Me.TreeCol_CDROIT_DEV.Name = "TreeCol_CDROIT_DEV"
        Me.TreeCol_CDROIT_DEV.Visible = True
        Me.TreeCol_CDROIT_DEV.VisibleIndex = 14
        '
        'BtnCheckedAll
        '
        Me.BtnCheckedAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnCheckedAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCheckedAll.Location = New System.Drawing.Point(930, 12)
        Me.BtnCheckedAll.Name = "BtnCheckedAll"
        Me.BtnCheckedAll.Size = New System.Drawing.Size(157, 30)
        Me.BtnCheckedAll.TabIndex = 54
        Me.BtnCheckedAll.Text = "Cocher tous  (Groupe)"
        Me.BtnCheckedAll.UseVisualStyleBackColor = True
        '
        'BtnUnCheckedAll
        '
        Me.BtnUnCheckedAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnUnCheckedAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnUnCheckedAll.Location = New System.Drawing.Point(1093, 11)
        Me.BtnUnCheckedAll.Name = "BtnUnCheckedAll"
        Me.BtnUnCheckedAll.Size = New System.Drawing.Size(157, 30)
        Me.BtnUnCheckedAll.TabIndex = 55
        Me.BtnUnCheckedAll.Text = "Décocher Tous (Groupe)"
        Me.BtnUnCheckedAll.UseVisualStyleBackColor = True
        '
        'BtnExportXLS
        '
        Me.BtnExportXLS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnExportXLS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnExportXLS.Location = New System.Drawing.Point(1273, 11)
        Me.BtnExportXLS.Name = "BtnExportXLS"
        Me.BtnExportXLS.Size = New System.Drawing.Size(157, 30)
        Me.BtnExportXLS.TabIndex = 56
        Me.BtnExportXLS.Text = "EXPORT XLS"
        Me.BtnExportXLS.UseVisualStyleBackColor = True
        '
        'SFD
        '
        Me.SFD.Filter = "Fichier EXCEL (*.xlsx) |*.xlsx"
        '
        'FrmGestionAccessGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1887, 969)
        Me.Controls.Add(Me.BtnExportXLS)
        Me.Controls.Add(Me.BtnUnCheckedAll)
        Me.Controls.Add(Me.BtnCheckedAll)
        Me.Controls.Add(Me.TreeList_Menu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GCPersGroupe)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "FrmGestionAccessGroup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des accès groupe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCPersGroupe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPersGroupe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.TreeList_Menu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChk_CDROIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents GCPersGroupe As DevExpress.XtraGrid.GridControl
    Private WithEvents GVPersGroupe As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCol_NPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCol_VPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCol_FONC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents LabelTitre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GCol_VSOCIETE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VPERADSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TreeList_Menu As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeCol_VMENULIB As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_CDROIT_EMALEC As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents RepItemChk_CDROIT As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents TreeCol_NPERNUM_EMALEC As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_NPERNUM_EMALECBELGIQUE As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_CDROIT_BELGIQUE As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_NPERNUM_EMALECIDF As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_CDROIT_IDF As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_NPERNUM_EQUIPAGE As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_CDROIT_EQUIPAGE As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_NPERNUM_MAGESTIME As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_CDROIT_MAGESTIME As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_NPERNUM_EMALECESPAGNE As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_CDROIT_EMALECESPAGNE As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_NPERNUM_SCS As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_CDROIT_SCS As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_NPERNUM_EMALECLUXEMBOURG As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_CDROIT_EMALECLUXEMBOURG As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_NPERNUM_EMALECFACILITEAM As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_CDROIT_EMALECFACILITEAM As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_NPERNUM_EMALECSUISSE As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_CDROIT_EMALECSUISSE As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents BtnCopyProfil As Button
    Friend WithEvents BtnCreateProfilOnFiliale As Button
    Friend WithEvents TreeCol_CDROIT_EMALECMPM As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_NPERNUM_EMALECMPM As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_NPERNUM_ALC As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_CDROIT_ALC As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_NPERNUM_EMAFI As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_CDROIT_EMAFI As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_NPERNUM_DEV As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_CDROIT_DEV As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents BtnDroitsParMenu As Button
    Friend WithEvents BtnGestionProfilType As Button
    Friend WithEvents BtnCheckedAll As Button
    Friend WithEvents BtnUnCheckedAll As Button
    Friend WithEvents BtnDelUser As Button
    Friend WithEvents BtnExportXLS As Button
    Friend WithEvents SFD As SaveFileDialog
    Friend WithEvents btnMenuSensible As Button
    Friend WithEvents GCol_SERVICE As DevExpress.XtraGrid.Columns.GridColumn
End Class
