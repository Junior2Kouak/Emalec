<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestionDroitFournituresBySerie
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
    Me.LabelTitre = New System.Windows.Forms.Label()
    Me.GCPersGroupe = New DevExpress.XtraGrid.GridControl()
    Me.GVPersGroupe = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GCol_NPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_VPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_VPERADSI = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_FONC = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_VSOCIETE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_EMALEC = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_EQUIPAGE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_SCS = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_MAGESTIME = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_EMALECDEV = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_EMALECESPAGNE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_EMALECIDF = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_EMALECLUXEMBOURG = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_EMALECFACILITEAM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_EMALECSUISSE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_EMALECMPM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_SAMSICROMANIA = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_CDROITVAL_EMAFI = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemCheckEditEMALEC = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.RepositoryItemCheckEditEQUIPAGE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.RepositoryItemCheckEditSCS = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.RepositoryItemCheckEditMAGESTIME = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.RepositoryItemCheckEditEMALECDEV = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.RepositoryItemCheckEditEMALECESPAGNE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.RepositoryItemCheckEditEMALECIDF = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.RepositoryItemCheckEditEMALECLUXEMBOURG = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.RepositoryItemCheckEditEMALECFACILITEAM = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.RepositoryItemCheckEditEMALECSUISSE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.RepositoryItemCheckEditEMALECMPM = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.RepositoryItemCheckEditSAMSICROMANIA = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.RepositoryItemCheckEditSAMSICITALIA = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.GCSERIEFO = New DevExpress.XtraGrid.GridControl()
    Me.GVSERIEFO = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ChkBoxArchives = New System.Windows.Forms.CheckBox()
    Me.BtnFermer = New System.Windows.Forms.Button()
    CType(Me.GCPersGroupe, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GVPersGroupe, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEditEMALEC, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEditEQUIPAGE, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEditSCS, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEditMAGESTIME, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEditEMALECDEV, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEditEMALECESPAGNE, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEditEMALECIDF, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEditEMALECLUXEMBOURG, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEditEMALECFACILITEAM, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEditEMALECSUISSE, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEditEMALECMPM, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEditSAMSICROMANIA, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEditSAMSICITALIA, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GCSERIEFO, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GVSERIEFO, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
    Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.Label1.Location = New System.Drawing.Point(136, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(361, 29)
    Me.Label1.TabIndex = 57
    Me.Label1.Text = "Liste des séries de fournitures"
    '
    'LabelTitre
    '
    Me.LabelTitre.AutoSize = True
    Me.LabelTitre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
    Me.LabelTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.LabelTitre.Location = New System.Drawing.Point(515, 9)
    Me.LabelTitre.Name = "LabelTitre"
    Me.LabelTitre.Size = New System.Drawing.Size(228, 29)
    Me.LabelTitre.TabIndex = 54
    Me.LabelTitre.Text = "Liste du personnel"
    '
    'GCPersGroupe
    '
    Me.GCPersGroupe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GCPersGroupe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
    Me.GCPersGroupe.Location = New System.Drawing.Point(520, 46)
    Me.GCPersGroupe.MainView = Me.GVPersGroupe
    Me.GCPersGroupe.Name = "GCPersGroupe"
    Me.GCPersGroupe.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEditEMALEC, Me.RepositoryItemCheckEditEQUIPAGE, Me.RepositoryItemCheckEditSCS, Me.RepositoryItemCheckEditMAGESTIME, Me.RepositoryItemCheckEditEMALECDEV, Me.RepositoryItemCheckEditEMALECESPAGNE, Me.RepositoryItemCheckEditEMALECIDF, Me.RepositoryItemCheckEditEMALECLUXEMBOURG, Me.RepositoryItemCheckEditEMALECFACILITEAM, Me.RepositoryItemCheckEditEMALECSUISSE, Me.RepositoryItemCheckEditEMALECMPM, Me.RepositoryItemCheckEditSAMSICROMANIA, Me.RepositoryItemCheckEditSAMSICITALIA})
    Me.GCPersGroupe.Size = New System.Drawing.Size(800, 659)
    Me.GCPersGroupe.TabIndex = 59
    Me.GCPersGroupe.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPersGroupe})
    '
    'GVPersGroupe
    '
    Me.GVPersGroupe.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
    Me.GVPersGroupe.Appearance.HeaderPanel.Options.UseFont = True
    Me.GVPersGroupe.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.GVPersGroupe.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GVPersGroupe.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.GVPersGroupe.ColumnPanelRowHeight = 70
    Me.GVPersGroupe.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_NPERNUM, Me.GCol_VPERNOM, Me.GCol_VPERADSI, Me.GCol_FONC, Me.GCol_VSOCIETE, Me.GCol_CDROITVAL_EMALEC, Me.GCol_CDROITVAL_EQUIPAGE, Me.GCol_CDROITVAL_SCS, Me.GCol_CDROITVAL_MAGESTIME, Me.GCol_CDROITVAL_EMALECDEV, Me.GCol_CDROITVAL_EMALECESPAGNE, Me.GCol_CDROITVAL_EMALECIDF, Me.GCol_CDROITVAL_EMALECLUXEMBOURG, Me.GCol_CDROITVAL_EMALECFACILITEAM, Me.GCol_CDROITVAL_EMALECSUISSE, Me.GCol_CDROITVAL_EMALECMPM, Me.GCol_CDROITVAL_SAMSICROMANIA, Me.GCol_CDROITVAL_EMAFI})
    Me.GVPersGroupe.GridControl = Me.GCPersGroupe
    Me.GVPersGroupe.Name = "GVPersGroupe"
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
    Me.GCol_VPERNOM.OptionsColumn.AllowEdit = False
    Me.GCol_VPERNOM.OptionsColumn.ReadOnly = True
    Me.GCol_VPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    Me.GCol_VPERNOM.Visible = True
    Me.GCol_VPERNOM.VisibleIndex = 0
    Me.GCol_VPERNOM.Width = 116
    '
    'GCol_VPERADSI
    '
    Me.GCol_VPERADSI.Caption = "VPERADSI"
    Me.GCol_VPERADSI.FieldName = "VPERADSI"
    Me.GCol_VPERADSI.Name = "GCol_VPERADSI"
    '
    'GCol_FONC
    '
    Me.GCol_FONC.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.GCol_FONC.AppearanceHeader.Options.UseForeColor = True
    Me.GCol_FONC.Caption = "Fonction"
    Me.GCol_FONC.FieldName = "FONC"
    Me.GCol_FONC.Name = "GCol_FONC"
    Me.GCol_FONC.OptionsColumn.AllowEdit = False
    Me.GCol_FONC.OptionsColumn.ReadOnly = True
    Me.GCol_FONC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    Me.GCol_FONC.Visible = True
    Me.GCol_FONC.VisibleIndex = 1
    Me.GCol_FONC.Width = 80
    '
    'GCol_VSOCIETE
    '
    Me.GCol_VSOCIETE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.GCol_VSOCIETE.AppearanceHeader.Options.UseForeColor = True
    Me.GCol_VSOCIETE.Caption = "Société"
    Me.GCol_VSOCIETE.FieldName = "VSOCIETE"
    Me.GCol_VSOCIETE.Name = "GCol_VSOCIETE"
    Me.GCol_VSOCIETE.OptionsColumn.AllowEdit = False
    Me.GCol_VSOCIETE.OptionsColumn.ReadOnly = True
    Me.GCol_VSOCIETE.Visible = True
    Me.GCol_VSOCIETE.VisibleIndex = 2
    Me.GCol_VSOCIETE.Width = 86
    '
    'GCol_CDROITVAL_EMALEC
    '
    Me.GCol_CDROITVAL_EMALEC.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.GCol_CDROITVAL_EMALEC.AppearanceHeader.Options.UseForeColor = True
    Me.GCol_CDROITVAL_EMALEC.Caption = "MOZART EMALEC"
    Me.GCol_CDROITVAL_EMALEC.FieldName = "CDROITVAL_EMALEC"
    Me.GCol_CDROITVAL_EMALEC.Name = "GCol_CDROITVAL_EMALEC"
    Me.GCol_CDROITVAL_EMALEC.Visible = True
    Me.GCol_CDROITVAL_EMALEC.VisibleIndex = 3
    '
    'GCol_CDROITVAL_EQUIPAGE
    '
    Me.GCol_CDROITVAL_EQUIPAGE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.GCol_CDROITVAL_EQUIPAGE.AppearanceHeader.Options.UseForeColor = True
    Me.GCol_CDROITVAL_EQUIPAGE.Caption = "MOZART BRETAGNE"
    Me.GCol_CDROITVAL_EQUIPAGE.FieldName = "CDROITVAL_EQUIPAGE"
    Me.GCol_CDROITVAL_EQUIPAGE.Name = "GCol_CDROITVAL_EQUIPAGE"
    Me.GCol_CDROITVAL_EQUIPAGE.Visible = True
    Me.GCol_CDROITVAL_EQUIPAGE.VisibleIndex = 4
    '
    'GCol_CDROITVAL_SCS
    '
    Me.GCol_CDROITVAL_SCS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.GCol_CDROITVAL_SCS.AppearanceHeader.Options.UseForeColor = True
    Me.GCol_CDROITVAL_SCS.Caption = "MOZART SCS"
    Me.GCol_CDROITVAL_SCS.FieldName = "CDROITVAL_SCS"
    Me.GCol_CDROITVAL_SCS.Name = "GCol_CDROITVAL_SCS"
    Me.GCol_CDROITVAL_SCS.Visible = True
    Me.GCol_CDROITVAL_SCS.VisibleIndex = 5
    '
    'GCol_CDROITVAL_MAGESTIME
    '
    Me.GCol_CDROITVAL_MAGESTIME.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.GCol_CDROITVAL_MAGESTIME.AppearanceHeader.Options.UseForeColor = True
    Me.GCol_CDROITVAL_MAGESTIME.Caption = "MOZART MAGESTIME"
    Me.GCol_CDROITVAL_MAGESTIME.FieldName = "CDROITVAL_MAGESTIME"
    Me.GCol_CDROITVAL_MAGESTIME.Name = "GCol_CDROITVAL_MAGESTIME"
    Me.GCol_CDROITVAL_MAGESTIME.Visible = True
    Me.GCol_CDROITVAL_MAGESTIME.VisibleIndex = 6
    '
    'GCol_CDROITVAL_EMALECDEV
    '
    Me.GCol_CDROITVAL_EMALECDEV.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.GCol_CDROITVAL_EMALECDEV.AppearanceHeader.Options.UseForeColor = True
    Me.GCol_CDROITVAL_EMALECDEV.Caption = "MOZART EMALEC DEV"
    Me.GCol_CDROITVAL_EMALECDEV.FieldName = "CDROITVAL_EMALECDEV"
    Me.GCol_CDROITVAL_EMALECDEV.Name = "GCol_CDROITVAL_EMALECDEV"
    Me.GCol_CDROITVAL_EMALECDEV.Visible = True
    Me.GCol_CDROITVAL_EMALECDEV.VisibleIndex = 7
    '
    'GCol_CDROITVAL_EMALECESPAGNE
    '
    Me.GCol_CDROITVAL_EMALECESPAGNE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.GCol_CDROITVAL_EMALECESPAGNE.AppearanceHeader.Options.UseForeColor = True
    Me.GCol_CDROITVAL_EMALECESPAGNE.Caption = "MOZART EMALEC ESPAGNE"
    Me.GCol_CDROITVAL_EMALECESPAGNE.FieldName = "CDROITVAL_EMALECESPAGNE"
    Me.GCol_CDROITVAL_EMALECESPAGNE.Name = "GCol_CDROITVAL_EMALECESPAGNE"
    Me.GCol_CDROITVAL_EMALECESPAGNE.Visible = True
    Me.GCol_CDROITVAL_EMALECESPAGNE.VisibleIndex = 8
    '
    'GCol_CDROITVAL_EMALECIDF
    '
    Me.GCol_CDROITVAL_EMALECIDF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.GCol_CDROITVAL_EMALECIDF.AppearanceHeader.Options.UseForeColor = True
    Me.GCol_CDROITVAL_EMALECIDF.Caption = "MOZART EMALEC IDF"
    Me.GCol_CDROITVAL_EMALECIDF.FieldName = "CDROITVAL_EMALECIDF"
    Me.GCol_CDROITVAL_EMALECIDF.Name = "GCol_CDROITVAL_EMALECIDF"
    Me.GCol_CDROITVAL_EMALECIDF.Visible = True
    Me.GCol_CDROITVAL_EMALECIDF.VisibleIndex = 9
    '
    'GCol_CDROITVAL_EMALECLUXEMBOURG
    '
    Me.GCol_CDROITVAL_EMALECLUXEMBOURG.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.GCol_CDROITVAL_EMALECLUXEMBOURG.AppearanceHeader.Options.UseForeColor = True
    Me.GCol_CDROITVAL_EMALECLUXEMBOURG.Caption = "EMALEC LUXEMBOURG"
    Me.GCol_CDROITVAL_EMALECLUXEMBOURG.FieldName = "CDROITVAL_EMALECLUXEMBOURG"
    Me.GCol_CDROITVAL_EMALECLUXEMBOURG.Name = "GCol_CDROITVAL_EMALECLUXEMBOURG"
    Me.GCol_CDROITVAL_EMALECLUXEMBOURG.Visible = True
    Me.GCol_CDROITVAL_EMALECLUXEMBOURG.VisibleIndex = 10
    '
    'GCol_CDROITVAL_EMALECFACILITEAM
    '
    Me.GCol_CDROITVAL_EMALECFACILITEAM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.GCol_CDROITVAL_EMALECFACILITEAM.AppearanceHeader.Options.UseForeColor = True
    Me.GCol_CDROITVAL_EMALECFACILITEAM.Caption = "MOZART EMALEC FACILITEAM"
    Me.GCol_CDROITVAL_EMALECFACILITEAM.FieldName = "CDROITVAL_EMALECFACILITEAM"
    Me.GCol_CDROITVAL_EMALECFACILITEAM.Name = "GCol_CDROITVAL_EMALECFACILITEAM"
    Me.GCol_CDROITVAL_EMALECFACILITEAM.Visible = True
    Me.GCol_CDROITVAL_EMALECFACILITEAM.VisibleIndex = 11
    '
    'GCol_CDROITVAL_EMALECSUISSE
    '
    Me.GCol_CDROITVAL_EMALECSUISSE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.GCol_CDROITVAL_EMALECSUISSE.AppearanceHeader.Options.UseForeColor = True
    Me.GCol_CDROITVAL_EMALECSUISSE.Caption = "MOZART EMALEC SUISSE"
    Me.GCol_CDROITVAL_EMALECSUISSE.FieldName = "CDROITVAL_EMALECSUISSE"
    Me.GCol_CDROITVAL_EMALECSUISSE.Name = "GCol_CDROITVAL_EMALECSUISSE"
    Me.GCol_CDROITVAL_EMALECSUISSE.Visible = True
    Me.GCol_CDROITVAL_EMALECSUISSE.VisibleIndex = 12
    '
    'GCol_CDROITVAL_EMALECMPM
    '
    Me.GCol_CDROITVAL_EMALECMPM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.GCol_CDROITVAL_EMALECMPM.AppearanceHeader.Options.UseForeColor = True
    Me.GCol_CDROITVAL_EMALECMPM.Caption = "MOZART EMALEC MPM"
    Me.GCol_CDROITVAL_EMALECMPM.FieldName = "CDROITVAL_EMALECMPM"
    Me.GCol_CDROITVAL_EMALECMPM.Name = "GCol_CDROITVAL_EMALECMPM"
    Me.GCol_CDROITVAL_EMALECMPM.Visible = True
    Me.GCol_CDROITVAL_EMALECMPM.VisibleIndex = 13
    '
    'GCol_CDROITVAL_SAMSICROMANIA
    '
    Me.GCol_CDROITVAL_SAMSICROMANIA.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.GCol_CDROITVAL_SAMSICROMANIA.AppearanceHeader.Options.UseForeColor = True
    Me.GCol_CDROITVAL_SAMSICROMANIA.Caption = "MOZART SAMSIC ROMANIA"
    Me.GCol_CDROITVAL_SAMSICROMANIA.FieldName = "CDROITVAL_SAMSICROMANIA"
    Me.GCol_CDROITVAL_SAMSICROMANIA.Name = "GCol_CDROITVAL_SAMSICROMANIA"
    Me.GCol_CDROITVAL_SAMSICROMANIA.Visible = True
    Me.GCol_CDROITVAL_SAMSICROMANIA.VisibleIndex = 14
    '
    'GCol_CDROITVAL_EMAFI
    '
    Me.GCol_CDROITVAL_EMAFI.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.GCol_CDROITVAL_EMAFI.AppearanceHeader.Options.UseForeColor = True
    Me.GCol_CDROITVAL_EMAFI.Caption = "MOZART EMAFI"
    Me.GCol_CDROITVAL_EMAFI.FieldName = "CDROITVAL_EMAFI"
    Me.GCol_CDROITVAL_EMAFI.Name = "GCol_CDROITVAL_EMAFI"
    Me.GCol_CDROITVAL_EMAFI.Visible = True
    Me.GCol_CDROITVAL_EMAFI.VisibleIndex = 15
    '
    'RepositoryItemCheckEditEMALEC
    '
    Me.RepositoryItemCheckEditEMALEC.AutoHeight = False
    Me.RepositoryItemCheckEditEMALEC.Name = "RepositoryItemCheckEditEMALEC"
    Me.RepositoryItemCheckEditEMALEC.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
    Me.RepositoryItemCheckEditEMALEC.ValueChecked = "O"
    Me.RepositoryItemCheckEditEMALEC.ValueUnchecked = "N"
    '
    'RepositoryItemCheckEditEQUIPAGE
    '
    Me.RepositoryItemCheckEditEQUIPAGE.AutoHeight = False
    Me.RepositoryItemCheckEditEQUIPAGE.Name = "RepositoryItemCheckEditEQUIPAGE"
    Me.RepositoryItemCheckEditEQUIPAGE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
    Me.RepositoryItemCheckEditEQUIPAGE.ValueChecked = "O"
    Me.RepositoryItemCheckEditEQUIPAGE.ValueUnchecked = "N"
    '
    'RepositoryItemCheckEditSCS
    '
    Me.RepositoryItemCheckEditSCS.AutoHeight = False
    Me.RepositoryItemCheckEditSCS.Name = "RepositoryItemCheckEditSCS"
    Me.RepositoryItemCheckEditSCS.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
    Me.RepositoryItemCheckEditSCS.ValueChecked = "O"
    Me.RepositoryItemCheckEditSCS.ValueUnchecked = "N"
    '
    'RepositoryItemCheckEditMAGESTIME
    '
    Me.RepositoryItemCheckEditMAGESTIME.AutoHeight = False
    Me.RepositoryItemCheckEditMAGESTIME.Name = "RepositoryItemCheckEditMAGESTIME"
    Me.RepositoryItemCheckEditMAGESTIME.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
    Me.RepositoryItemCheckEditMAGESTIME.ValueChecked = "O"
    Me.RepositoryItemCheckEditMAGESTIME.ValueUnchecked = "N"
    '
    'RepositoryItemCheckEditEMALECDEV
    '
    Me.RepositoryItemCheckEditEMALECDEV.AutoHeight = False
    Me.RepositoryItemCheckEditEMALECDEV.Name = "RepositoryItemCheckEditEMALECDEV"
    Me.RepositoryItemCheckEditEMALECDEV.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
    Me.RepositoryItemCheckEditEMALECDEV.ValueChecked = "O"
    Me.RepositoryItemCheckEditEMALECDEV.ValueUnchecked = "N"
    '
    'RepositoryItemCheckEditEMALECESPAGNE
    '
    Me.RepositoryItemCheckEditEMALECESPAGNE.AutoHeight = False
    Me.RepositoryItemCheckEditEMALECESPAGNE.Name = "RepositoryItemCheckEditEMALECESPAGNE"
    Me.RepositoryItemCheckEditEMALECESPAGNE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
    Me.RepositoryItemCheckEditEMALECESPAGNE.ValueChecked = "O"
    Me.RepositoryItemCheckEditEMALECESPAGNE.ValueUnchecked = "N"
    '
    'RepositoryItemCheckEditEMALECIDF
    '
    Me.RepositoryItemCheckEditEMALECIDF.AutoHeight = False
    Me.RepositoryItemCheckEditEMALECIDF.Name = "RepositoryItemCheckEditEMALECIDF"
    Me.RepositoryItemCheckEditEMALECIDF.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
    Me.RepositoryItemCheckEditEMALECIDF.ValueChecked = "O"
    Me.RepositoryItemCheckEditEMALECIDF.ValueUnchecked = "N"
    '
    'RepositoryItemCheckEditEMALECLUXEMBOURG
    '
    Me.RepositoryItemCheckEditEMALECLUXEMBOURG.AutoHeight = False
    Me.RepositoryItemCheckEditEMALECLUXEMBOURG.Name = "RepositoryItemCheckEditEMALECLUXEMBOURG"
    Me.RepositoryItemCheckEditEMALECLUXEMBOURG.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
    Me.RepositoryItemCheckEditEMALECLUXEMBOURG.ValueChecked = "O"
    Me.RepositoryItemCheckEditEMALECLUXEMBOURG.ValueUnchecked = "N"
    '
    'RepositoryItemCheckEditEMALECFACILITEAM
    '
    Me.RepositoryItemCheckEditEMALECFACILITEAM.AutoHeight = False
    Me.RepositoryItemCheckEditEMALECFACILITEAM.Name = "RepositoryItemCheckEditEMALECFACILITEAM"
    Me.RepositoryItemCheckEditEMALECFACILITEAM.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
    Me.RepositoryItemCheckEditEMALECFACILITEAM.ValueChecked = "O"
    Me.RepositoryItemCheckEditEMALECFACILITEAM.ValueUnchecked = "N"
    '
    'RepositoryItemCheckEditEMALECSUISSE
    '
    Me.RepositoryItemCheckEditEMALECSUISSE.AutoHeight = False
    Me.RepositoryItemCheckEditEMALECSUISSE.Name = "RepositoryItemCheckEditEMALECSUISSE"
    Me.RepositoryItemCheckEditEMALECSUISSE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
    Me.RepositoryItemCheckEditEMALECSUISSE.ValueChecked = "O"
    Me.RepositoryItemCheckEditEMALECSUISSE.ValueUnchecked = "N"
    '
    'RepositoryItemCheckEditEMALECMPM
    '
    Me.RepositoryItemCheckEditEMALECMPM.AutoHeight = False
    Me.RepositoryItemCheckEditEMALECMPM.Name = "RepositoryItemCheckEditEMALECMPM"
    Me.RepositoryItemCheckEditEMALECMPM.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
    Me.RepositoryItemCheckEditEMALECMPM.ValueChecked = "O"
    Me.RepositoryItemCheckEditEMALECMPM.ValueUnchecked = "N"
    '
    'RepositoryItemCheckEditSAMSICROMANIA
    '
    Me.RepositoryItemCheckEditSAMSICROMANIA.AutoHeight = False
    Me.RepositoryItemCheckEditSAMSICROMANIA.Name = "RepositoryItemCheckEditSAMSICROMANIA"
    Me.RepositoryItemCheckEditSAMSICROMANIA.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
    Me.RepositoryItemCheckEditSAMSICROMANIA.ValueChecked = "O"
    Me.RepositoryItemCheckEditSAMSICROMANIA.ValueUnchecked = "N"
    '
    'RepositoryItemCheckEditSAMSICITALIA
    '
    Me.RepositoryItemCheckEditSAMSICITALIA.AutoHeight = False
    Me.RepositoryItemCheckEditSAMSICITALIA.Name = "RepositoryItemCheckEditSAMSICITALIA"
    Me.RepositoryItemCheckEditSAMSICITALIA.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
    Me.RepositoryItemCheckEditSAMSICITALIA.ValueChecked = "O"
    Me.RepositoryItemCheckEditSAMSICITALIA.ValueUnchecked = "N"
    '
    'GCSERIEFO
    '
    Me.GCSERIEFO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.GCSERIEFO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
    Me.GCSERIEFO.Location = New System.Drawing.Point(141, 46)
    Me.GCSERIEFO.MainView = Me.GVSERIEFO
    Me.GCSERIEFO.Name = "GCSERIEFO"
    Me.GCSERIEFO.Size = New System.Drawing.Size(356, 659)
    Me.GCSERIEFO.TabIndex = 60
    Me.GCSERIEFO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSERIEFO})
    '
    'GVSERIEFO
    '
    Me.GVSERIEFO.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
    Me.GVSERIEFO.Appearance.HeaderPanel.Options.UseFont = True
    Me.GVSERIEFO.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.GVSERIEFO.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GVSERIEFO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
    Me.GVSERIEFO.GridControl = Me.GCSERIEFO
    Me.GVSERIEFO.Name = "GVSERIEFO"
    Me.GVSERIEFO.OptionsBehavior.Editable = False
    Me.GVSERIEFO.OptionsBehavior.ReadOnly = True
    Me.GVSERIEFO.OptionsCustomization.AllowGroup = False
    Me.GVSERIEFO.OptionsPrint.PrintPreview = True
    Me.GVSERIEFO.OptionsView.ShowAutoFilterRow = True
    Me.GVSERIEFO.OptionsView.ShowFooter = True
    Me.GVSERIEFO.OptionsView.ShowGroupPanel = False
    '
    'GridColumn1
    '
    Me.GridColumn1.FieldName = "NCFOCOD"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    Me.GridColumn1.Width = 130
    '
    'GridColumn2
    '
    Me.GridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
    Me.GridColumn2.AppearanceHeader.Options.UseForeColor = True
    Me.GridColumn2.Caption = "Série de fournitures"
    Me.GridColumn2.FieldName = "CCFOCOD"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 0
    Me.GridColumn2.Width = 116
    '
    'ChkBoxArchives
    '
    Me.ChkBoxArchives.Location = New System.Drawing.Point(12, 46)
    Me.ChkBoxArchives.Name = "ChkBoxArchives"
    Me.ChkBoxArchives.Size = New System.Drawing.Size(109, 43)
    Me.ChkBoxArchives.TabIndex = 61
    Me.ChkBoxArchives.Text = "Voir les séries archivées"
    Me.ChkBoxArchives.UseVisualStyleBackColor = True
    '
    'BtnFermer
    '
    Me.BtnFermer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.BtnFermer.Location = New System.Drawing.Point(12, 657)
    Me.BtnFermer.Name = "BtnFermer"
    Me.BtnFermer.Size = New System.Drawing.Size(109, 48)
    Me.BtnFermer.TabIndex = 62
    Me.BtnFermer.Text = "Fermer"
    Me.BtnFermer.UseVisualStyleBackColor = True
    '
    'frmGestionDroitFournituresBySerie
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.ClientSize = New System.Drawing.Size(1332, 717)
    Me.Controls.Add(Me.BtnFermer)
    Me.Controls.Add(Me.ChkBoxArchives)
    Me.Controls.Add(Me.GCSERIEFO)
    Me.Controls.Add(Me.GCPersGroupe)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.LabelTitre)
    Me.Name = "frmGestionDroitFournituresBySerie"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Gestion des droits par série de fournitures"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    CType(Me.GCPersGroupe, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GVPersGroupe, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEditEMALEC, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEditEQUIPAGE, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEditSCS, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEditMAGESTIME, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEditEMALECDEV, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEditEMALECESPAGNE, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEditEMALECIDF, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEditEMALECLUXEMBOURG, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEditEMALECFACILITEAM, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEditEMALECSUISSE, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEditEMALECMPM, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEditSAMSICROMANIA, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEditSAMSICITALIA, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GCSERIEFO, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GVSERIEFO, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As Label
  Friend WithEvents LabelTitre As Label
  Private WithEvents GCPersGroupe As DevExpress.XtraGrid.GridControl
  Private WithEvents GVPersGroupe As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents GCol_NPERNUM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GCol_VPERNOM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GCol_FONC As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_VSOCIETE As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_CDROITVAL_EMALEC As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemCheckEditEMALEC As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents GCol_CDROITVAL_EQUIPAGE As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_CDROITVAL_SCS As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_CDROITVAL_MAGESTIME As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_CDROITVAL_EMALECDEV As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_CDROITVAL_EMALECESPAGNE As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_CDROITVAL_EMALECIDF As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_CDROITVAL_EMALECLUXEMBOURG As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GCol_CDROITVAL_EMALECFACILITEAM As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemCheckEditEQUIPAGE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents RepositoryItemCheckEditSCS As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents RepositoryItemCheckEditMAGESTIME As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents RepositoryItemCheckEditEMALECDEV As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents RepositoryItemCheckEditEMALECESPAGNE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents RepositoryItemCheckEditEMALECIDF As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents RepositoryItemCheckEditEMALECLUXEMBOURG As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents RepositoryItemCheckEditEMALECFACILITEAM As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents GCol_CDROITVAL_EMALECSUISSE As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemCheckEditEMALECSUISSE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents GCol_CDROITVAL_EMALECMPM As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemCheckEditEMALECMPM As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents GCol_CDROITVAL_SAMSICROMANIA As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemCheckEditSAMSICROMANIA As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents GCol_VPERADSI As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GCSERIEFO As DevExpress.XtraGrid.GridControl
  Private WithEvents GVSERIEFO As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemCheckEditSAMSICITALIA As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents GCol_CDROITVAL_EMAFI As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents ChkBoxArchives As CheckBox
    Friend WithEvents BtnFermer As Button
End Class
