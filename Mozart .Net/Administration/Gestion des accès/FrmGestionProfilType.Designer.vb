<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionProfilType
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.BtnCopyProfil = New System.Windows.Forms.Button()
    Me.GCol_CDROITVAL_SCS = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_MAGESTIME = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_EMALECDEV = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_EMALECESPAGNE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_EMALECIDF = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_EMALECFACILITEAM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_EMALECSUISSE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_EMALECMPM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_SAMSICROMANIA = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCTypeProfilGroupe = New DevExpress.XtraGrid.GridControl()
    Me.GVTypeProfilGroupe = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GCol_NID_REF_TYPEPER = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_VTYPELIB = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_NSERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_VTYPEDETAILLIB = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.TreeList_Menu = New DevExpress.XtraTreeList.TreeList()
    Me.TreeCol_VMENULIB = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_NIDPROFIL_EMALEC = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_CDROIT_EMALEC = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.RepItemChk_CDROIT = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.TreeCol_NIDPROFIL_EMALECBELGIQUE = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_CDROIT_BELGIQUE = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_NIDPROFIL_EMALECIDF = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_CDROIT_IDF = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_NIDPROFIL_EQUIPAGE = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_CDROIT_EQUIPAGE = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_NIDPROFIL_MAGESTIME = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_CDROIT_MAGESTIME = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_NIDPROFIL_EMALECESPAGNE = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_CDROIT_EMALECESPAGNE = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_NIDPROFIL_SCS = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_CDROIT_SCS = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_NIDPROFIL_EMALECLUXEMBOURG = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_CDROIT_EMALECLUXEMBOURG = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_NIDPROFIL_EMALECFACILITEAM = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_CDROIT_EMALECFACILITEAM = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_NIDPROFIL_EMALECSUISSE = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_CDROIT_EMALECSUISSE = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_NIDPROFIL_EMALECMPM = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_CDROIT_EMALECMPM = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_NIDPROFIL_ALC = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_CDROIT_ALC = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_NIDPROFIL_EMAFI = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_CDROIT_EMAFI = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_NIDPROFIL_EMALECDEV = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeCol_CDROIT_DEV = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.GroupBox1.SuspendLayout()
    CType(Me.GCTypeProfilGroupe, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GVTypeProfilGroupe, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TreeList_Menu, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepItemChk_CDROIT, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
    Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.Label1.Location = New System.Drawing.Point(152, 11)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(254, 29)
    Me.Label1.TabIndex = 62
    Me.Label1.Text = "Liste des profils type"
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
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.BtnCopyProfil)
    Me.GroupBox1.Controls.Add(Me.BtnFermer)
    Me.GroupBox1.Location = New System.Drawing.Point(9, 9)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(129, 857)
    Me.GroupBox1.TabIndex = 61
    Me.GroupBox1.TabStop = False
    '
    'BtnCopyProfil
    '
    Me.BtnCopyProfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.BtnCopyProfil.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.BtnCopyProfil.Location = New System.Drawing.Point(7, 44)
    Me.BtnCopyProfil.Name = "BtnCopyProfil"
    Me.BtnCopyProfil.Size = New System.Drawing.Size(109, 48)
    Me.BtnCopyProfil.TabIndex = 2
    Me.BtnCopyProfil.Text = "Copier Profil"
    Me.BtnCopyProfil.UseVisualStyleBackColor = True
    '
    'GCol_CDROITVAL_SCS
    '
    Me.GCol_CDROITVAL_SCS.Caption = "MOZART SCS"
    Me.GCol_CDROITVAL_SCS.FieldName = "CDROITVAL_SCS"
    Me.GCol_CDROITVAL_SCS.Name = "GCol_CDROITVAL_SCS"
    Me.GCol_CDROITVAL_SCS.Visible = True
    Me.GCol_CDROITVAL_SCS.VisibleIndex = 5
    '
    'GCol_CDROITVAL_MAGESTIME
    '
    Me.GCol_CDROITVAL_MAGESTIME.Caption = "MOZART MAGESTIME"
    Me.GCol_CDROITVAL_MAGESTIME.FieldName = "CDROITVAL_MAGESTIME"
    Me.GCol_CDROITVAL_MAGESTIME.Name = "GCol_CDROITVAL_MAGESTIME"
    Me.GCol_CDROITVAL_MAGESTIME.Visible = True
    Me.GCol_CDROITVAL_MAGESTIME.VisibleIndex = 6
    '
    'GCol_CDROITVAL_EMALECDEV
    '
    Me.GCol_CDROITVAL_EMALECDEV.Caption = "MOZART EMALEC DEV"
    Me.GCol_CDROITVAL_EMALECDEV.FieldName = "CDROITVAL_EMALECDEV"
    Me.GCol_CDROITVAL_EMALECDEV.Name = "GCol_CDROITVAL_EMALECDEV"
    Me.GCol_CDROITVAL_EMALECDEV.Visible = True
    Me.GCol_CDROITVAL_EMALECDEV.VisibleIndex = 7
    '
    'GCol_CDROITVAL_EMALECESPAGNE
    '
    Me.GCol_CDROITVAL_EMALECESPAGNE.Caption = "MOZART EMALEC ESPAGNE"
    Me.GCol_CDROITVAL_EMALECESPAGNE.FieldName = "CDROITVAL_EMALECESPAGNE"
    Me.GCol_CDROITVAL_EMALECESPAGNE.Name = "GCol_CDROITVAL_EMALECESPAGNE"
    Me.GCol_CDROITVAL_EMALECESPAGNE.Visible = True
    Me.GCol_CDROITVAL_EMALECESPAGNE.VisibleIndex = 8
    '
    'GCol_CDROITVAL_EMALECIDF
    '
    Me.GCol_CDROITVAL_EMALECIDF.Caption = "MOZART EMALEC IDF"
    Me.GCol_CDROITVAL_EMALECIDF.FieldName = "CDROITVAL_EMALECIDF"
    Me.GCol_CDROITVAL_EMALECIDF.Name = "GCol_CDROITVAL_EMALECIDF"
    Me.GCol_CDROITVAL_EMALECIDF.Visible = True
    Me.GCol_CDROITVAL_EMALECIDF.VisibleIndex = 9
    '
    'GCol_CDROITVAL_EMALECFACILITEAM
    '
    Me.GCol_CDROITVAL_EMALECFACILITEAM.Caption = "MOZART EMALEC FACILITEAM"
    Me.GCol_CDROITVAL_EMALECFACILITEAM.FieldName = "CDROITVAL_EMALECFACILITEAM"
    Me.GCol_CDROITVAL_EMALECFACILITEAM.Name = "GCol_CDROITVAL_EMALECFACILITEAM"
    Me.GCol_CDROITVAL_EMALECFACILITEAM.Visible = True
    Me.GCol_CDROITVAL_EMALECFACILITEAM.VisibleIndex = 11
    '
    'GCol_CDROITVAL_EMALECSUISSE
    '
    Me.GCol_CDROITVAL_EMALECSUISSE.Caption = "MOZART EMALEC SUISSE"
    Me.GCol_CDROITVAL_EMALECSUISSE.FieldName = "CDROITVAL_EMALECSUISSE"
    Me.GCol_CDROITVAL_EMALECSUISSE.Name = "GCol_CDROITVAL_EMALECSUISSE"
    Me.GCol_CDROITVAL_EMALECSUISSE.Visible = True
    Me.GCol_CDROITVAL_EMALECSUISSE.VisibleIndex = 12
    '
    'GCol_CDROITVAL_EMALECMPM
    '
    Me.GCol_CDROITVAL_EMALECMPM.Caption = "MOZART EMALEC MPM"
    Me.GCol_CDROITVAL_EMALECMPM.FieldName = "CDROITVAL_EMALECMPM"
    Me.GCol_CDROITVAL_EMALECMPM.Name = "GCol_CDROITVAL_EMALECMPM"
    Me.GCol_CDROITVAL_EMALECMPM.Visible = True
    Me.GCol_CDROITVAL_EMALECMPM.VisibleIndex = 13
    '
    'GCol_CDROITVAL_SAMSICROMANIA
    '
    Me.GCol_CDROITVAL_SAMSICROMANIA.Caption = "MOZART SAMSIC ROMANIA"
    Me.GCol_CDROITVAL_SAMSICROMANIA.FieldName = "CDROITVAL_SAMSICROMANIA"
    Me.GCol_CDROITVAL_SAMSICROMANIA.Name = "GCol_CDROITVAL_SAMSICROMANIA"
    Me.GCol_CDROITVAL_SAMSICROMANIA.Visible = True
    Me.GCol_CDROITVAL_SAMSICROMANIA.VisibleIndex = 14
    '
    'GCTypeProfilGroupe
    '
    Me.GCTypeProfilGroupe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
    Me.GCTypeProfilGroupe.Location = New System.Drawing.Point(157, 53)
    Me.GCTypeProfilGroupe.MainView = Me.GVTypeProfilGroupe
    Me.GCTypeProfilGroupe.Name = "GCTypeProfilGroupe"
    Me.GCTypeProfilGroupe.Size = New System.Drawing.Size(322, 677)
    Me.GCTypeProfilGroupe.TabIndex = 63
    Me.GCTypeProfilGroupe.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVTypeProfilGroupe})
    '
    'GVTypeProfilGroupe
    '
    Me.GVTypeProfilGroupe.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
    Me.GVTypeProfilGroupe.Appearance.HeaderPanel.Options.UseFont = True
    Me.GVTypeProfilGroupe.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.GVTypeProfilGroupe.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GVTypeProfilGroupe.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_NID_REF_TYPEPER, Me.GCol_VTYPELIB, Me.GCol_NSERNUM, Me.GCol_VTYPEDETAILLIB})
    Me.GVTypeProfilGroupe.GridControl = Me.GCTypeProfilGroupe
    Me.GVTypeProfilGroupe.Name = "GVTypeProfilGroupe"
    Me.GVTypeProfilGroupe.OptionsBehavior.Editable = False
    Me.GVTypeProfilGroupe.OptionsBehavior.ReadOnly = True
    Me.GVTypeProfilGroupe.OptionsCustomization.AllowGroup = False
    Me.GVTypeProfilGroupe.OptionsPrint.PrintPreview = True
    Me.GVTypeProfilGroupe.OptionsView.ShowAutoFilterRow = True
    Me.GVTypeProfilGroupe.OptionsView.ShowFooter = True
    Me.GVTypeProfilGroupe.OptionsView.ShowGroupPanel = False
    '
    'GCol_NID_REF_TYPEPER
    '
    Me.GCol_NID_REF_TYPEPER.FieldName = "ID"
    Me.GCol_NID_REF_TYPEPER.Name = "GCol_NID_REF_TYPEPER"
    Me.GCol_NID_REF_TYPEPER.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    Me.GCol_NID_REF_TYPEPER.Width = 130
    '
    'GCol_VTYPELIB
    '
    Me.GCol_VTYPELIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.GCol_VTYPELIB.AppearanceHeader.Options.UseForeColor = True
    Me.GCol_VTYPELIB.Caption = "Type profil"
    Me.GCol_VTYPELIB.FieldName = "VTYPELIB"
    Me.GCol_VTYPELIB.Name = "GCol_VTYPELIB"
    Me.GCol_VTYPELIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    Me.GCol_VTYPELIB.Visible = True
    Me.GCol_VTYPELIB.VisibleIndex = 0
    Me.GCol_VTYPELIB.Width = 110
    '
    'GCol_NSERNUM
    '
    Me.GCol_NSERNUM.Caption = "NSERNUM"
    Me.GCol_NSERNUM.FieldName = "NSERNUM"
    Me.GCol_NSERNUM.Name = "GCol_NSERNUM"
    '
    'GCol_VTYPEDETAILLIB
    '
    Me.GCol_VTYPEDETAILLIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.GCol_VTYPEDETAILLIB.AppearanceHeader.Options.UseForeColor = True
    Me.GCol_VTYPEDETAILLIB.Caption = "Poste"
    Me.GCol_VTYPEDETAILLIB.FieldName = "VTYPEDETAILLIB"
    Me.GCol_VTYPEDETAILLIB.Name = "GCol_VTYPEDETAILLIB"
    Me.GCol_VTYPEDETAILLIB.Visible = True
    Me.GCol_VTYPEDETAILLIB.VisibleIndex = 1
    Me.GCol_VTYPEDETAILLIB.Width = 194
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
    Me.TreeList_Menu.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeCol_VMENULIB, Me.TreeCol_NIDPROFIL_EMALEC, Me.TreeCol_CDROIT_EMALEC, Me.TreeCol_NIDPROFIL_EMALECBELGIQUE, Me.TreeCol_CDROIT_BELGIQUE, Me.TreeCol_NIDPROFIL_EMALECIDF, Me.TreeCol_CDROIT_IDF, Me.TreeCol_NIDPROFIL_EQUIPAGE, Me.TreeCol_CDROIT_EQUIPAGE, Me.TreeCol_NIDPROFIL_MAGESTIME, Me.TreeCol_CDROIT_MAGESTIME, Me.TreeCol_NIDPROFIL_EMALECESPAGNE, Me.TreeCol_CDROIT_EMALECESPAGNE, Me.TreeCol_NIDPROFIL_SCS, Me.TreeCol_CDROIT_SCS, Me.TreeCol_NIDPROFIL_EMALECLUXEMBOURG, Me.TreeCol_CDROIT_EMALECLUXEMBOURG, Me.TreeCol_NIDPROFIL_EMALECFACILITEAM, Me.TreeCol_CDROIT_EMALECFACILITEAM, Me.TreeCol_NIDPROFIL_EMALECSUISSE, Me.TreeCol_CDROIT_EMALECSUISSE, Me.TreeCol_NIDPROFIL_EMALECMPM, Me.TreeCol_CDROIT_EMALECMPM, Me.TreeCol_NIDPROFIL_ALC, Me.TreeCol_CDROIT_ALC, Me.TreeCol_NIDPROFIL_EMAFI, Me.TreeCol_CDROIT_EMAFI, Me.TreeCol_NIDPROFIL_EMALECDEV, Me.TreeCol_CDROIT_DEV})
    Me.TreeList_Menu.Cursor = System.Windows.Forms.Cursors.Default
    Me.TreeList_Menu.CustomizationFormBounds = New System.Drawing.Rectangle(1551, 774, 250, 200)
    Me.TreeList_Menu.FooterPanelHeight = 10
    Me.TreeList_Menu.KeyFieldName = "NMENUNUM"
    Me.TreeList_Menu.Location = New System.Drawing.Point(496, 52)
    Me.TreeList_Menu.Name = "TreeList_Menu"
    Me.TreeList_Menu.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.MouseUp
    Me.TreeList_Menu.OptionsBehavior.PopulateServiceColumns = True
    Me.TreeList_Menu.OptionsView.ShowSummaryFooter = True
    Me.TreeList_Menu.ParentFieldName = "NMENUPARENT"
    Me.TreeList_Menu.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChk_CDROIT})
    Me.TreeList_Menu.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowOnlyInEditor
    Me.TreeList_Menu.Size = New System.Drawing.Size(1247, 887)
    Me.TreeList_Menu.TabIndex = 65
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
    'TreeCol_NIDPROFIL_EMALEC
    '
    Me.TreeCol_NIDPROFIL_EMALEC.Caption = "NIDPROFIL_EMALEC"
    Me.TreeCol_NIDPROFIL_EMALEC.FieldName = "NIDPROFIL_EMALEC"
    Me.TreeCol_NIDPROFIL_EMALEC.Name = "TreeCol_NIDPROFIL_EMALEC"
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
    'TreeCol_NIDPROFIL_EMALECBELGIQUE
    '
    Me.TreeCol_NIDPROFIL_EMALECBELGIQUE.Caption = "NIDPROFIL_EMALECBELGIQUE"
    Me.TreeCol_NIDPROFIL_EMALECBELGIQUE.FieldName = "NIDPROFIL_EMALECBELGIQUE"
    Me.TreeCol_NIDPROFIL_EMALECBELGIQUE.Name = "TreeCol_NIDPROFIL_EMALECBELGIQUE"
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
    'TreeCol_NIDPROFIL_EMALECIDF
    '
    Me.TreeCol_NIDPROFIL_EMALECIDF.Caption = "NIDPROFIL_EMALECIDF"
    Me.TreeCol_NIDPROFIL_EMALECIDF.FieldName = "NIDPROFIL_EMALECIDF"
    Me.TreeCol_NIDPROFIL_EMALECIDF.Name = "TreeCol_NIDPROFIL_EMALECIDF"
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
    'TreeCol_NIDPROFIL_EQUIPAGE
    '
    Me.TreeCol_NIDPROFIL_EQUIPAGE.Caption = "NIDPROFIL_EQUIPAGE"
    Me.TreeCol_NIDPROFIL_EQUIPAGE.FieldName = "NIDPROFIL_EQUIPAGE"
    Me.TreeCol_NIDPROFIL_EQUIPAGE.Name = "TreeCol_NIDPROFIL_EQUIPAGE"
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
    'TreeCol_NIDPROFIL_MAGESTIME
    '
    Me.TreeCol_NIDPROFIL_MAGESTIME.Caption = "NIDPROFIL_MAGESTIME"
    Me.TreeCol_NIDPROFIL_MAGESTIME.FieldName = "NIDPROFIL_MAGESTIME"
    Me.TreeCol_NIDPROFIL_MAGESTIME.Name = "TreeCol_NIDPROFIL_MAGESTIME"
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
    'TreeCol_NIDPROFIL_EMALECESPAGNE
    '
    Me.TreeCol_NIDPROFIL_EMALECESPAGNE.Caption = "NIDPROFIL_EMALECESPAGNE"
    Me.TreeCol_NIDPROFIL_EMALECESPAGNE.FieldName = "NIDPROFIL_EMALECESPAGNE"
    Me.TreeCol_NIDPROFIL_EMALECESPAGNE.Name = "TreeCol_NIDPROFIL_EMALECESPAGNE"
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
    'TreeCol_NIDPROFIL_SCS
    '
    Me.TreeCol_NIDPROFIL_SCS.Caption = "NIDPROFIL_SCS"
    Me.TreeCol_NIDPROFIL_SCS.FieldName = "NIDPROFIL_SCS"
    Me.TreeCol_NIDPROFIL_SCS.Name = "TreeCol_NIDPROFIL_SCS"
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
    'TreeCol_NIDPROFIL_EMALECLUXEMBOURG
    '
    Me.TreeCol_NIDPROFIL_EMALECLUXEMBOURG.Caption = "NIDPROFIL_EMALECLUXEMBOURG"
    Me.TreeCol_NIDPROFIL_EMALECLUXEMBOURG.FieldName = "NIDPROFIL_EMALECLUXEMBOURG"
    Me.TreeCol_NIDPROFIL_EMALECLUXEMBOURG.Name = "TreeCol_NIDPROFIL_EMALECLUXEMBOURG"
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
    'TreeCol_NIDPROFIL_EMALECFACILITEAM
    '
    Me.TreeCol_NIDPROFIL_EMALECFACILITEAM.Caption = "NIDPROFIL_EMALECFACILITEAM"
    Me.TreeCol_NIDPROFIL_EMALECFACILITEAM.FieldName = "NIDPROFIL_EMALECFACILITEAM"
    Me.TreeCol_NIDPROFIL_EMALECFACILITEAM.Name = "TreeCol_NIDPROFIL_EMALECFACILITEAM"
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
    'TreeCol_NIDPROFIL_EMALECSUISSE
    '
    Me.TreeCol_NIDPROFIL_EMALECSUISSE.Caption = "NIDPROFIL_EMALECSUISSE"
    Me.TreeCol_NIDPROFIL_EMALECSUISSE.FieldName = "NIDPROFIL_EMALECSUISSE"
    Me.TreeCol_NIDPROFIL_EMALECSUISSE.Name = "TreeCol_NIDPROFIL_EMALECSUISSE"
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
    'TreeCol_NIDPROFIL_EMALECMPM
    '
    Me.TreeCol_NIDPROFIL_EMALECMPM.Caption = "NIDPROFIL_EMALECMPM"
    Me.TreeCol_NIDPROFIL_EMALECMPM.FieldName = "NIDPROFIL_EMALECMPM"
    Me.TreeCol_NIDPROFIL_EMALECMPM.Name = "TreeCol_NIDPROFIL_EMALECMPM"
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
    'TreeCol_NIDPROFIL_ALC
    '
    Me.TreeCol_NIDPROFIL_ALC.Caption = "NIDPROFIL_ALC"
    Me.TreeCol_NIDPROFIL_ALC.FieldName = "NIDPROFIL_ALC"
    Me.TreeCol_NIDPROFIL_ALC.Name = "TreeCol_NIDPROFIL_ALC"
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
    'TreeCol_NIDPROFIL_EMAFI
    '
    Me.TreeCol_NIDPROFIL_EMAFI.Caption = "NIDPROFIL_EMAFI"
    Me.TreeCol_NIDPROFIL_EMAFI.FieldName = "NIDPROFIL_EMAFI"
    Me.TreeCol_NIDPROFIL_EMAFI.Name = "TreeCol_NIDPROFIL_EMAFI"
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
    'TreeCol_NIDPROFIL_EMALECDEV
    '
    Me.TreeCol_NIDPROFIL_EMALECDEV.Caption = "NIDPROFIL_EMALECDEV"
    Me.TreeCol_NIDPROFIL_EMALECDEV.FieldName = "NIDPROFIL_EMALECDEV"
    Me.TreeCol_NIDPROFIL_EMALECDEV.Name = "TreeCol_NIDPROFIL_EMALECDEV"
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
    'Label2
    '
    Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
    Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.Label2.Location = New System.Drawing.Point(491, 11)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(933, 29)
    Me.Label2.TabIndex = 64
    Me.Label2.Text = "Liste des menus"
    '
    'FrmGestionProfilType
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.ClientSize = New System.Drawing.Size(1853, 1061)
    Me.Controls.Add(Me.TreeList_Menu)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.GCTypeProfilGroupe)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.GroupBox1)
    Me.Name = "FrmGestionProfilType"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestion des profils type"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.GroupBox1.ResumeLayout(False)
    CType(Me.GCTypeProfilGroupe, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GVTypeProfilGroupe, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TreeList_Menu, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepItemChk_CDROIT, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As Label
  Friend WithEvents BtnFermer As Button
  Friend WithEvents GroupBox1 As GroupBox
  Friend WithEvents GCol_CDROITVAL_SCS As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_CDROITVAL_MAGESTIME As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_CDROITVAL_EMALECDEV As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_CDROITVAL_EMALECESPAGNE As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_CDROITVAL_EMALECIDF As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_CDROITVAL_EMALECFACILITEAM As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_CDROITVAL_EMALECSUISSE As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_CDROITVAL_EMALECMPM As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_CDROITVAL_SAMSICROMANIA As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GCTypeProfilGroupe As DevExpress.XtraGrid.GridControl
  Private WithEvents GVTypeProfilGroupe As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents GCol_NID_REF_TYPEPER As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GCol_VTYPELIB As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents TreeList_Menu As DevExpress.XtraTreeList.TreeList
  Friend WithEvents TreeCol_VMENULIB As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_NIDPROFIL_EMALEC As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_CDROIT_EMALEC As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents RepItemChk_CDROIT As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents TreeCol_NIDPROFIL_EMALECBELGIQUE As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_CDROIT_BELGIQUE As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_NIDPROFIL_EMALECIDF As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_CDROIT_IDF As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_NIDPROFIL_EQUIPAGE As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_CDROIT_EQUIPAGE As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_NIDPROFIL_MAGESTIME As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_CDROIT_MAGESTIME As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_NIDPROFIL_EMALECESPAGNE As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_CDROIT_EMALECESPAGNE As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_NIDPROFIL_SCS As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_CDROIT_SCS As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_NIDPROFIL_EMALECLUXEMBOURG As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_CDROIT_EMALECLUXEMBOURG As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_NIDPROFIL_EMALECFACILITEAM As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_CDROIT_EMALECFACILITEAM As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_NIDPROFIL_EMALECSUISSE As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_CDROIT_EMALECSUISSE As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_NIDPROFIL_EMALECMPM As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_CDROIT_EMALECMPM As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_NIDPROFIL_ALC As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_CDROIT_ALC As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_NIDPROFIL_EMAFI As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_CDROIT_EMAFI As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents TreeCol_NIDPROFIL_EMALECDEV As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeCol_CDROIT_DEV As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents GCol_NSERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VTYPEDETAILLIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnCopyProfil As Button
End Class
