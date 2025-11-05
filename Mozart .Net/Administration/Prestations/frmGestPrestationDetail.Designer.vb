<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestPrestationDetail
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
        Me.GrpBoxTypologie = New System.Windows.Forms.GroupBox()
        Me.GridLookUpSousSerie = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridLookUpSerie = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GV_Cbo_Serie = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GlookUpType = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GVCboTypePresta = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCCboTypePresta_NPREST_TYPE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCCboTypePresta_VPREST_TYPE_LIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpBoxDebourse = New System.Windows.Forms.GroupBox()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Txt_MontantTotHT = New DevExpress.XtraEditors.TextEdit()
        Me.Txt_MontantFO = New DevExpress.XtraEditors.TextEdit()
        Me.Txt_PrixMO = New DevExpress.XtraEditors.TextEdit()
        Me.Txt_QteMO = New DevExpress.XtraEditors.TextEdit()
        Me.GridLookUpEdit3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrpCodePresta = New System.Windows.Forms.GroupBox()
        Me.Txt_VPRESTCODE = New DevExpress.XtraEditors.TextEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GrpLibelle = New System.Windows.Forms.GroupBox()
        Me.Txt_VPRESTLIB = New System.Windows.Forms.TextBox()
        Me.GrpListeFo = New System.Windows.Forms.GroupBox()
        Me.BtnSupprimerFO = New System.Windows.Forms.Button()
        Me.BtnAddFO = New System.Windows.Forms.Button()
        Me.GCListePrestFou = New DevExpress.XtraGrid.GridControl()
        Me.GVListePrestFou = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_Fo_NumArticle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_CCODEG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_FO_Serie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_Fo_Article = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_FO_Marque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_FO_VFOUTYP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_FO_VFOUREF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_FO_NFOUNBLOT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_FO_Prix_U = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_FO_Quantite = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_FO_Prix_Total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepItemGLU_TPRESTSER = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepItemGLU_View_TPRESTSER = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_Serie_NPRESTSERID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_Serie_VPRESTSER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLU_TREF_PREST_SS_SERIE = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepItemGLU_View_TREF_PREST_SS_SERIE = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_SSSerie_NPREST_SS_SERIE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SSSerie_NPRESTSERID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SSSerie_VPREST_SS_SERIE_LIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLU_TREF_PREST_TYPE = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepItemGLU_View_TREF_PREST_TYPE = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_NPREST_TYPE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VPREST_TYPE_LIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_DPRESTMOD = New DevExpress.XtraEditors.TextEdit()
        Me.Txt_MODIF = New DevExpress.XtraEditors.TextEdit()
        Me.Txt_DateCreate = New DevExpress.XtraEditors.TextEdit()
        Me.Txt_Createur = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GrpPageInfo = New System.Windows.Forms.GroupBox()
        Me.Wb_Information = New System.Windows.Forms.WebBrowser()
        Me.GrpBoxTypologie.SuspendLayout()
        CType(Me.GridLookUpSousSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Cbo_Serie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GlookUpType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCboTypePresta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxDebourse.SuspendLayout()
        CType(Me.Txt_MontantTotHT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_MontantFO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_PrixMO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_QteMO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpCodePresta.SuspendLayout()
        CType(Me.Txt_VPRESTCODE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpLibelle.SuspendLayout()
        Me.GrpListeFo.SuspendLayout()
        CType(Me.GCListePrestFou, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListePrestFou, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLU_TPRESTSER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLU_View_TPRESTSER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLU_TREF_PREST_SS_SERIE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLU_View_TREF_PREST_SS_SERIE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLU_TREF_PREST_TYPE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLU_View_TREF_PREST_TYPE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Txt_DPRESTMOD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_MODIF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_DateCreate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_Createur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPageInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpBoxTypologie
        '
        Me.GrpBoxTypologie.Controls.Add(Me.GridLookUpSousSerie)
        Me.GrpBoxTypologie.Controls.Add(Me.GridLookUpSerie)
        Me.GrpBoxTypologie.Controls.Add(Me.GlookUpType)
        Me.GrpBoxTypologie.Controls.Add(Me.Label3)
        Me.GrpBoxTypologie.Controls.Add(Me.Label2)
        Me.GrpBoxTypologie.Controls.Add(Me.Label1)
        Me.GrpBoxTypologie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxTypologie.ForeColor = System.Drawing.Color.Firebrick
        Me.GrpBoxTypologie.Location = New System.Drawing.Point(124, 12)
        Me.GrpBoxTypologie.Name = "GrpBoxTypologie"
        Me.GrpBoxTypologie.Size = New System.Drawing.Size(405, 192)
        Me.GrpBoxTypologie.TabIndex = 0
        Me.GrpBoxTypologie.TabStop = False
        Me.GrpBoxTypologie.Text = "Typologie"
        '
        'GridLookUpSousSerie
        '
        Me.GridLookUpSousSerie.EditValue = ""
        Me.GridLookUpSousSerie.Location = New System.Drawing.Point(148, 112)
        Me.GridLookUpSousSerie.Name = "GridLookUpSousSerie"
        Me.GridLookUpSousSerie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpSousSerie.Properties.DisplayMember = "VPREST_SS_SERIE_LIB"
        Me.GridLookUpSousSerie.Properties.NullText = ""
        Me.GridLookUpSousSerie.Properties.ValueMember = "NPREST_SS_SERIE_ID"
        Me.GridLookUpSousSerie.Properties.View = Me.GridView2
        Me.GridLookUpSousSerie.Size = New System.Drawing.Size(241, 20)
        Me.GridLookUpSousSerie.TabIndex = 8
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn3.FieldName = "NPREST_SS_SERIE_ID"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn4.Caption = "Sous-série"
        Me.GridColumn4.FieldName = "VPREST_SS_SERIE_LIB"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridLookUpSerie
        '
        Me.GridLookUpSerie.EditValue = ""
        Me.GridLookUpSerie.Location = New System.Drawing.Point(148, 72)
        Me.GridLookUpSerie.Name = "GridLookUpSerie"
        Me.GridLookUpSerie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpSerie.Properties.DisplayMember = "VPRESTSER"
        Me.GridLookUpSerie.Properties.NullText = ""
        Me.GridLookUpSerie.Properties.ValueMember = "NPRESTSERID"
        Me.GridLookUpSerie.Properties.View = Me.GV_Cbo_Serie
        Me.GridLookUpSerie.Size = New System.Drawing.Size(241, 20)
        Me.GridLookUpSerie.TabIndex = 7
        '
        'GV_Cbo_Serie
        '
        Me.GV_Cbo_Serie.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GV_Cbo_Serie.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GV_Cbo_Serie.Name = "GV_Cbo_Serie"
        Me.GV_Cbo_Serie.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GV_Cbo_Serie.OptionsView.ShowAutoFilterRow = True
        Me.GV_Cbo_Serie.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn1.Caption = "NPRESTSERID"
        Me.GridColumn1.FieldName = "NPRESTSERID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn2.Caption = "Série"
        Me.GridColumn2.FieldName = "VPRESTSER"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GlookUpType
        '
        Me.GlookUpType.EditValue = ""
        Me.GlookUpType.Location = New System.Drawing.Point(148, 30)
        Me.GlookUpType.Name = "GlookUpType"
        Me.GlookUpType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GlookUpType.Properties.DisplayMember = "VPREST_TYPE_LIB"
        Me.GlookUpType.Properties.NullText = ""
        Me.GlookUpType.Properties.ValueMember = "NPREST_TYPE_ID"
        Me.GlookUpType.Properties.View = Me.GVCboTypePresta
        Me.GlookUpType.Size = New System.Drawing.Size(241, 20)
        Me.GlookUpType.TabIndex = 6
        '
        'GVCboTypePresta
        '
        Me.GVCboTypePresta.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCCboTypePresta_NPREST_TYPE_ID, Me.GCCboTypePresta_VPREST_TYPE_LIB})
        Me.GVCboTypePresta.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVCboTypePresta.Name = "GVCboTypePresta"
        Me.GVCboTypePresta.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVCboTypePresta.OptionsView.ShowAutoFilterRow = True
        Me.GVCboTypePresta.OptionsView.ShowGroupPanel = False
        '
        'GCCboTypePresta_NPREST_TYPE_ID
        '
        Me.GCCboTypePresta_NPREST_TYPE_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GCCboTypePresta_NPREST_TYPE_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCCboTypePresta_NPREST_TYPE_ID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCCboTypePresta_NPREST_TYPE_ID.FieldName = "NPREST_TYPE_ID"
        Me.GCCboTypePresta_NPREST_TYPE_ID.Name = "GCCboTypePresta_NPREST_TYPE_ID"
        Me.GCCboTypePresta_NPREST_TYPE_ID.OptionsColumn.AllowEdit = False
        Me.GCCboTypePresta_NPREST_TYPE_ID.OptionsColumn.ReadOnly = True
        '
        'GCCboTypePresta_VPREST_TYPE_LIB
        '
        Me.GCCboTypePresta_VPREST_TYPE_LIB.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GCCboTypePresta_VPREST_TYPE_LIB.AppearanceHeader.Options.UseFont = True
        Me.GCCboTypePresta_VPREST_TYPE_LIB.AppearanceHeader.Options.UseTextOptions = True
        Me.GCCboTypePresta_VPREST_TYPE_LIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCCboTypePresta_VPREST_TYPE_LIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCCboTypePresta_VPREST_TYPE_LIB.Caption = "Type"
        Me.GCCboTypePresta_VPREST_TYPE_LIB.FieldName = "VPREST_TYPE_LIB"
        Me.GCCboTypePresta_VPREST_TYPE_LIB.Name = "GCCboTypePresta_VPREST_TYPE_LIB"
        Me.GCCboTypePresta_VPREST_TYPE_LIB.OptionsColumn.AllowEdit = False
        Me.GCCboTypePresta_VPREST_TYPE_LIB.OptionsColumn.ReadOnly = True
        Me.GCCboTypePresta_VPREST_TYPE_LIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCCboTypePresta_VPREST_TYPE_LIB.Visible = True
        Me.GCCboTypePresta_VPREST_TYPE_LIB.VisibleIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sous série"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Série"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type de prestation"
        '
        'GrpBoxDebourse
        '
        Me.GrpBoxDebourse.Controls.Add(Me.BtnConvert)
        Me.GrpBoxDebourse.Controls.Add(Me.Label18)
        Me.GrpBoxDebourse.Controls.Add(Me.Label17)
        Me.GrpBoxDebourse.Controls.Add(Me.Label16)
        Me.GrpBoxDebourse.Controls.Add(Me.Label15)
        Me.GrpBoxDebourse.Controls.Add(Me.Label14)
        Me.GrpBoxDebourse.Controls.Add(Me.Txt_MontantTotHT)
        Me.GrpBoxDebourse.Controls.Add(Me.Txt_MontantFO)
        Me.GrpBoxDebourse.Controls.Add(Me.Txt_PrixMO)
        Me.GrpBoxDebourse.Controls.Add(Me.Txt_QteMO)
        Me.GrpBoxDebourse.Controls.Add(Me.GridLookUpEdit3)
        Me.GrpBoxDebourse.Controls.Add(Me.Label8)
        Me.GrpBoxDebourse.Controls.Add(Me.Label7)
        Me.GrpBoxDebourse.Controls.Add(Me.Label6)
        Me.GrpBoxDebourse.Controls.Add(Me.Label5)
        Me.GrpBoxDebourse.Controls.Add(Me.Label4)
        Me.GrpBoxDebourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxDebourse.ForeColor = System.Drawing.Color.Firebrick
        Me.GrpBoxDebourse.Location = New System.Drawing.Point(535, 12)
        Me.GrpBoxDebourse.Name = "GrpBoxDebourse"
        Me.GrpBoxDebourse.Size = New System.Drawing.Size(400, 192)
        Me.GrpBoxDebourse.TabIndex = 1
        Me.GrpBoxDebourse.TabStop = False
        Me.GrpBoxDebourse.Text = "Déboursé"
        '
        'BtnConvert
        '
        Me.BtnConvert.ForeColor = System.Drawing.Color.Black
        Me.BtnConvert.Location = New System.Drawing.Point(320, 54)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(74, 23)
        Me.BtnConvert.TabIndex = 17
        Me.BtnConvert.Text = "Convertir"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(276, 141)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "€"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(276, 115)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(14, 13)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "€"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(276, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(14, 13)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "€"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(276, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "H"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(276, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "(ML,U,M2...)"
        '
        'Txt_MontantTotHT
        '
        Me.Txt_MontantTotHT.Location = New System.Drawing.Point(168, 138)
        Me.Txt_MontantTotHT.Name = "Txt_MontantTotHT"
        Me.Txt_MontantTotHT.Properties.AllowFocused = False
        Me.Txt_MontantTotHT.Properties.Mask.EditMask = "n2"
        Me.Txt_MontantTotHT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Txt_MontantTotHT.Properties.ReadOnly = True
        Me.Txt_MontantTotHT.Size = New System.Drawing.Size(103, 20)
        Me.Txt_MontantTotHT.TabIndex = 11
        Me.Txt_MontantTotHT.TabStop = False
        '
        'Txt_MontantFO
        '
        Me.Txt_MontantFO.Location = New System.Drawing.Point(168, 112)
        Me.Txt_MontantFO.Name = "Txt_MontantFO"
        Me.Txt_MontantFO.Properties.AllowFocused = False
        Me.Txt_MontantFO.Properties.DisplayFormat.FormatString = "n2"
        Me.Txt_MontantFO.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Txt_MontantFO.Properties.Mask.EditMask = "n2"
        Me.Txt_MontantFO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Txt_MontantFO.Properties.ReadOnly = True
        Me.Txt_MontantFO.Size = New System.Drawing.Size(103, 20)
        Me.Txt_MontantFO.TabIndex = 10
        Me.Txt_MontantFO.TabStop = False
        '
        'Txt_PrixMO
        '
        Me.Txt_PrixMO.Location = New System.Drawing.Point(168, 86)
        Me.Txt_PrixMO.Name = "Txt_PrixMO"
        Me.Txt_PrixMO.Properties.AllowFocused = False
        Me.Txt_PrixMO.Properties.DisplayFormat.FormatString = "n2"
        Me.Txt_PrixMO.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Txt_PrixMO.Properties.EditFormat.FormatString = "n2"
        Me.Txt_PrixMO.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Txt_PrixMO.Properties.Mask.EditMask = "n2"
        Me.Txt_PrixMO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Txt_PrixMO.Properties.ReadOnly = True
        Me.Txt_PrixMO.Size = New System.Drawing.Size(103, 20)
        Me.Txt_PrixMO.TabIndex = 9
        Me.Txt_PrixMO.TabStop = False
        '
        'Txt_QteMO
        '
        Me.Txt_QteMO.Location = New System.Drawing.Point(168, 56)
        Me.Txt_QteMO.Name = "Txt_QteMO"
        Me.Txt_QteMO.Properties.Mask.EditMask = "n2"
        Me.Txt_QteMO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Txt_QteMO.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Txt_QteMO.Size = New System.Drawing.Size(103, 20)
        Me.Txt_QteMO.TabIndex = 8
        Me.Txt_QteMO.TabStop = False
        '
        'GridLookUpEdit3
        '
        Me.GridLookUpEdit3.EditValue = ""
        Me.GridLookUpEdit3.Location = New System.Drawing.Point(168, 30)
        Me.GridLookUpEdit3.Name = "GridLookUpEdit3"
        Me.GridLookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit3.Properties.DisplayMember = "VUNITE"
        Me.GridLookUpEdit3.Properties.NullText = ""
        Me.GridLookUpEdit3.Properties.ValueMember = "VUNITE"
        Me.GridLookUpEdit3.Properties.View = Me.GridView3
        Me.GridLookUpEdit3.Size = New System.Drawing.Size(103, 20)
        Me.GridLookUpEdit3.TabIndex = 7
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn6.Caption = "Unité"
        Me.GridColumn6.FieldName = "VUNITE"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(14, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Montant Total HT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(14, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Montant fournitures"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Prix de revient MO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Quantité main d'oeuvre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Unité"
        '
        'GrpCodePresta
        '
        Me.GrpCodePresta.Controls.Add(Me.Txt_VPRESTCODE)
        Me.GrpCodePresta.Controls.Add(Me.Label13)
        Me.GrpCodePresta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpCodePresta.ForeColor = System.Drawing.Color.Firebrick
        Me.GrpCodePresta.Location = New System.Drawing.Point(124, 210)
        Me.GrpCodePresta.Name = "GrpCodePresta"
        Me.GrpCodePresta.Size = New System.Drawing.Size(842, 51)
        Me.GrpCodePresta.TabIndex = 2
        Me.GrpCodePresta.TabStop = False
        Me.GrpCodePresta.Text = "Code"
        '
        'Txt_VPRESTCODE
        '
        Me.Txt_VPRESTCODE.Location = New System.Drawing.Point(129, 19)
        Me.Txt_VPRESTCODE.Name = "Txt_VPRESTCODE"
        Me.Txt_VPRESTCODE.Properties.AllowFocused = False
        Me.Txt_VPRESTCODE.Size = New System.Drawing.Size(333, 20)
        Me.Txt_VPRESTCODE.TabIndex = 4
        Me.Txt_VPRESTCODE.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(27, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Code prestation"
        '
        'GrpLibelle
        '
        Me.GrpLibelle.Controls.Add(Me.Txt_VPRESTLIB)
        Me.GrpLibelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpLibelle.ForeColor = System.Drawing.Color.Firebrick
        Me.GrpLibelle.Location = New System.Drawing.Point(124, 267)
        Me.GrpLibelle.Name = "GrpLibelle"
        Me.GrpLibelle.Size = New System.Drawing.Size(842, 289)
        Me.GrpLibelle.TabIndex = 3
        Me.GrpLibelle.TabStop = False
        Me.GrpLibelle.Text = "Libellé prestation"
        '
        'Txt_VPRESTLIB
        '
        Me.Txt_VPRESTLIB.Location = New System.Drawing.Point(6, 19)
        Me.Txt_VPRESTLIB.Multiline = True
        Me.Txt_VPRESTLIB.Name = "Txt_VPRESTLIB"
        Me.Txt_VPRESTLIB.Size = New System.Drawing.Size(830, 257)
        Me.Txt_VPRESTLIB.TabIndex = 1
        '
        'GrpListeFo
        '
        Me.GrpListeFo.Controls.Add(Me.BtnSupprimerFO)
        Me.GrpListeFo.Controls.Add(Me.BtnAddFO)
        Me.GrpListeFo.Controls.Add(Me.GCListePrestFou)
        Me.GrpListeFo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpListeFo.ForeColor = System.Drawing.Color.Firebrick
        Me.GrpListeFo.Location = New System.Drawing.Point(124, 562)
        Me.GrpListeFo.Name = "GrpListeFo"
        Me.GrpListeFo.Size = New System.Drawing.Size(842, 326)
        Me.GrpListeFo.TabIndex = 4
        Me.GrpListeFo.TabStop = False
        Me.GrpListeFo.Text = "Fourniture"
        '
        'BtnSupprimerFO
        '
        Me.BtnSupprimerFO.ForeColor = System.Drawing.Color.Black
        Me.BtnSupprimerFO.Location = New System.Drawing.Point(8, 128)
        Me.BtnSupprimerFO.Name = "BtnSupprimerFO"
        Me.BtnSupprimerFO.Size = New System.Drawing.Size(75, 23)
        Me.BtnSupprimerFO.TabIndex = 11
        Me.BtnSupprimerFO.Text = "Supprimer"
        Me.BtnSupprimerFO.UseVisualStyleBackColor = True
        '
        'BtnAddFO
        '
        Me.BtnAddFO.ForeColor = System.Drawing.Color.Black
        Me.BtnAddFO.Location = New System.Drawing.Point(8, 87)
        Me.BtnAddFO.Name = "BtnAddFO"
        Me.BtnAddFO.Size = New System.Drawing.Size(75, 23)
        Me.BtnAddFO.TabIndex = 10
        Me.BtnAddFO.Text = "Ajouter"
        Me.BtnAddFO.UseVisualStyleBackColor = True
        '
        'GCListePrestFou
        '
        Me.GCListePrestFou.Location = New System.Drawing.Point(101, 19)
        Me.GCListePrestFou.MainView = Me.GVListePrestFou
        Me.GCListePrestFou.Name = "GCListePrestFou"
        Me.GCListePrestFou.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepItemGLU_TPRESTSER, Me.RepItemGLU_TREF_PREST_SS_SERIE, Me.RepItemGLU_TREF_PREST_TYPE})
        Me.GCListePrestFou.Size = New System.Drawing.Size(735, 301)
        Me.GCListePrestFou.TabIndex = 9
        Me.GCListePrestFou.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListePrestFou})
        '
        'GVListePrestFou
        '
        Me.GVListePrestFou.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrestFou.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrestFou.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GVListePrestFou.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVListePrestFou.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVListePrestFou.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListePrestFou.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListePrestFou.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVListePrestFou.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVListePrestFou.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVListePrestFou.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrestFou.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVListePrestFou.Appearance.Empty.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrestFou.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrestFou.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVListePrestFou.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVListePrestFou.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVListePrestFou.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrestFou.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrestFou.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GVListePrestFou.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVListePrestFou.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVListePrestFou.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrestFou.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVListePrestFou.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListePrestFou.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVListePrestFou.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GVListePrestFou.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVListePrestFou.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVListePrestFou.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVListePrestFou.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GVListePrestFou.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GVListePrestFou.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVListePrestFou.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVListePrestFou.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVListePrestFou.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrestFou.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrestFou.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListePrestFou.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVListePrestFou.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVListePrestFou.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrestFou.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrestFou.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVListePrestFou.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListePrestFou.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListePrestFou.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVListePrestFou.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVListePrestFou.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVListePrestFou.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrestFou.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVListePrestFou.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListePrestFou.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVListePrestFou.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListePrestFou.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListePrestFou.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVListePrestFou.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVListePrestFou.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVListePrestFou.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListePrestFou.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListePrestFou.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListePrestFou.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListePrestFou.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVListePrestFou.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListePrestFou.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVListePrestFou.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListePrestFou.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListePrestFou.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListePrestFou.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListePrestFou.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GVListePrestFou.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListePrestFou.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrestFou.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVListePrestFou.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVListePrestFou.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrestFou.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrestFou.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrestFou.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVListePrestFou.Appearance.OddRow.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVListePrestFou.Appearance.OddRow.Options.UseForeColor = True
        Me.GVListePrestFou.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVListePrestFou.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListePrestFou.Appearance.Preview.Options.UseFont = True
        Me.GVListePrestFou.Appearance.Preview.Options.UseForeColor = True
        Me.GVListePrestFou.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrestFou.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVListePrestFou.Appearance.Row.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.Row.Options.UseForeColor = True
        Me.GVListePrestFou.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrestFou.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVListePrestFou.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListePrestFou.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVListePrestFou.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVListePrestFou.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVListePrestFou.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVListePrestFou.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrestFou.Appearance.VertLine.Options.UseBackColor = True
        Me.GVListePrestFou.ColumnPanelRowHeight = 40
        Me.GVListePrestFou.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_Fo_NumArticle, Me.GCol_CCODEG, Me.GCol_FO_Serie, Me.GCol_Fo_Article, Me.GCol_FO_Marque, Me.GCol_FO_VFOUTYP, Me.GCol_FO_VFOUREF, Me.GCol_FO_NFOUNBLOT, Me.GCol_FO_Prix_U, Me.GCol_FO_Quantite, Me.GCol_FO_Prix_Total})
        Me.GVListePrestFou.GridControl = Me.GCListePrestFou
        Me.GVListePrestFou.Name = "GVListePrestFou"
        Me.GVListePrestFou.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled
        Me.GVListePrestFou.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListePrestFou.OptionsView.EnableAppearanceOddRow = True
        Me.GVListePrestFou.OptionsView.RowAutoHeight = True
        Me.GVListePrestFou.OptionsView.ShowAutoFilterRow = True
        Me.GVListePrestFou.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVListePrestFou.OptionsView.ShowFooter = True
        Me.GVListePrestFou.OptionsView.ShowGroupPanel = False
        '
        'GCol_Fo_NumArticle
        '
        Me.GCol_Fo_NumArticle.Caption = "NumArticle"
        Me.GCol_Fo_NumArticle.FieldName = "NumArticle"
        Me.GCol_Fo_NumArticle.Name = "GCol_Fo_NumArticle"
        '
        'GCol_CCODEG
        '
        Me.GCol_CCODEG.Caption = "CCODEG"
        Me.GCol_CCODEG.FieldName = "CCODEG"
        Me.GCol_CCODEG.Name = "GCol_CCODEG"
        '
        'GCol_FO_Serie
        '
        Me.GCol_FO_Serie.Caption = "Série"
        Me.GCol_FO_Serie.FieldName = "Serie"
        Me.GCol_FO_Serie.Name = "GCol_FO_Serie"
        Me.GCol_FO_Serie.OptionsColumn.AllowEdit = False
        Me.GCol_FO_Serie.OptionsColumn.ReadOnly = True
        Me.GCol_FO_Serie.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_FO_Serie.Visible = True
        Me.GCol_FO_Serie.VisibleIndex = 0
        '
        'GCol_Fo_Article
        '
        Me.GCol_Fo_Article.Caption = "Article"
        Me.GCol_Fo_Article.FieldName = "Article"
        Me.GCol_Fo_Article.Name = "GCol_Fo_Article"
        Me.GCol_Fo_Article.OptionsColumn.AllowEdit = False
        Me.GCol_Fo_Article.OptionsColumn.ReadOnly = True
        Me.GCol_Fo_Article.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_Fo_Article.Visible = True
        Me.GCol_Fo_Article.VisibleIndex = 1
        '
        'GCol_FO_Marque
        '
        Me.GCol_FO_Marque.Caption = "Marque"
        Me.GCol_FO_Marque.FieldName = "Marque"
        Me.GCol_FO_Marque.Name = "GCol_FO_Marque"
        Me.GCol_FO_Marque.OptionsColumn.AllowEdit = False
        Me.GCol_FO_Marque.OptionsColumn.ReadOnly = True
        Me.GCol_FO_Marque.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_FO_Marque.Visible = True
        Me.GCol_FO_Marque.VisibleIndex = 2
        '
        'GCol_FO_VFOUTYP
        '
        Me.GCol_FO_VFOUTYP.Caption = "Type"
        Me.GCol_FO_VFOUTYP.FieldName = "VFOUTYP"
        Me.GCol_FO_VFOUTYP.Name = "GCol_FO_VFOUTYP"
        Me.GCol_FO_VFOUTYP.OptionsColumn.AllowEdit = False
        Me.GCol_FO_VFOUTYP.OptionsColumn.ReadOnly = True
        Me.GCol_FO_VFOUTYP.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_FO_VFOUTYP.Visible = True
        Me.GCol_FO_VFOUTYP.VisibleIndex = 3
        '
        'GCol_FO_VFOUREF
        '
        Me.GCol_FO_VFOUREF.Caption = "Référence"
        Me.GCol_FO_VFOUREF.FieldName = "VFOUREF"
        Me.GCol_FO_VFOUREF.Name = "GCol_FO_VFOUREF"
        Me.GCol_FO_VFOUREF.OptionsColumn.AllowFocus = False
        Me.GCol_FO_VFOUREF.OptionsColumn.ReadOnly = True
        Me.GCol_FO_VFOUREF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_FO_VFOUREF.Visible = True
        Me.GCol_FO_VFOUREF.VisibleIndex = 4
        '
        'GCol_FO_NFOUNBLOT
        '
        Me.GCol_FO_NFOUNBLOT.Caption = "PCB"
        Me.GCol_FO_NFOUNBLOT.FieldName = "NFOUNBLOT"
        Me.GCol_FO_NFOUNBLOT.Name = "GCol_FO_NFOUNBLOT"
        Me.GCol_FO_NFOUNBLOT.OptionsColumn.AllowEdit = False
        Me.GCol_FO_NFOUNBLOT.OptionsColumn.ReadOnly = True
        Me.GCol_FO_NFOUNBLOT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_FO_NFOUNBLOT.Visible = True
        Me.GCol_FO_NFOUNBLOT.VisibleIndex = 5
        '
        'GCol_FO_Prix_U
        '
        Me.GCol_FO_Prix_U.Caption = "Prix U"
        Me.GCol_FO_Prix_U.DisplayFormat.FormatString = "n3"
        Me.GCol_FO_Prix_U.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GCol_FO_Prix_U.FieldName = "Prix U"
        Me.GCol_FO_Prix_U.Name = "GCol_FO_Prix_U"
        Me.GCol_FO_Prix_U.OptionsColumn.AllowEdit = False
        Me.GCol_FO_Prix_U.OptionsColumn.ReadOnly = True
        Me.GCol_FO_Prix_U.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_FO_Prix_U.Visible = True
        Me.GCol_FO_Prix_U.VisibleIndex = 6
        '
        'GCol_FO_Quantite
        '
        Me.GCol_FO_Quantite.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.GCol_FO_Quantite.AppearanceCell.Options.UseBackColor = True
        Me.GCol_FO_Quantite.Caption = "Quantite"
        Me.GCol_FO_Quantite.DisplayFormat.FormatString = "n2"
        Me.GCol_FO_Quantite.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GCol_FO_Quantite.FieldName = "Quantite"
        Me.GCol_FO_Quantite.Name = "GCol_FO_Quantite"
        Me.GCol_FO_Quantite.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_FO_Quantite.Visible = True
        Me.GCol_FO_Quantite.VisibleIndex = 7
        '
        'GCol_FO_Prix_Total
        '
        Me.GCol_FO_Prix_Total.Caption = "Prix Tot"
        Me.GCol_FO_Prix_Total.DisplayFormat.FormatString = "n3"
        Me.GCol_FO_Prix_Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GCol_FO_Prix_Total.FieldName = "Prix Total"
        Me.GCol_FO_Prix_Total.Name = "GCol_FO_Prix_Total"
        Me.GCol_FO_Prix_Total.OptionsColumn.AllowEdit = False
        Me.GCol_FO_Prix_Total.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_FO_Prix_Total.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Prix Total", "TOTAL={0:n3}")})
        Me.GCol_FO_Prix_Total.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GCol_FO_Prix_Total.Visible = True
        Me.GCol_FO_Prix_Total.VisibleIndex = 8
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepItemGLU_TPRESTSER
        '
        Me.RepItemGLU_TPRESTSER.AutoHeight = False
        Me.RepItemGLU_TPRESTSER.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepItemGLU_TPRESTSER.DisplayMember = "VPRESTSER"
        Me.RepItemGLU_TPRESTSER.Name = "RepItemGLU_TPRESTSER"
        Me.RepItemGLU_TPRESTSER.NullText = ""
        Me.RepItemGLU_TPRESTSER.ValueMember = "NPRESTSERID"
        Me.RepItemGLU_TPRESTSER.View = Me.RepItemGLU_View_TPRESTSER
        '
        'RepItemGLU_View_TPRESTSER
        '
        Me.RepItemGLU_View_TPRESTSER.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_Serie_NPRESTSERID, Me.GCol_Serie_VPRESTSER})
        Me.RepItemGLU_View_TPRESTSER.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepItemGLU_View_TPRESTSER.Name = "RepItemGLU_View_TPRESTSER"
        Me.RepItemGLU_View_TPRESTSER.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepItemGLU_View_TPRESTSER.OptionsView.ShowGroupPanel = False
        '
        'GCol_Serie_NPRESTSERID
        '
        Me.GCol_Serie_NPRESTSERID.Caption = "NPRESTSERID"
        Me.GCol_Serie_NPRESTSERID.FieldName = "NPRESTSERID"
        Me.GCol_Serie_NPRESTSERID.Name = "GCol_Serie_NPRESTSERID"
        '
        'GCol_Serie_VPRESTSER
        '
        Me.GCol_Serie_VPRESTSER.AppearanceHeader.Options.UseTextOptions = True
        Me.GCol_Serie_VPRESTSER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_Serie_VPRESTSER.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_Serie_VPRESTSER.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GCol_Serie_VPRESTSER.Caption = "Série"
        Me.GCol_Serie_VPRESTSER.FieldName = "VPRESTSER"
        Me.GCol_Serie_VPRESTSER.Name = "GCol_Serie_VPRESTSER"
        Me.GCol_Serie_VPRESTSER.OptionsColumn.AllowEdit = False
        Me.GCol_Serie_VPRESTSER.OptionsColumn.ReadOnly = True
        Me.GCol_Serie_VPRESTSER.Visible = True
        Me.GCol_Serie_VPRESTSER.VisibleIndex = 0
        '
        'RepItemGLU_TREF_PREST_SS_SERIE
        '
        Me.RepItemGLU_TREF_PREST_SS_SERIE.AutoHeight = False
        Me.RepItemGLU_TREF_PREST_SS_SERIE.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepItemGLU_TREF_PREST_SS_SERIE.DisplayMember = "VPREST_SS_SERIE_LIB"
        Me.RepItemGLU_TREF_PREST_SS_SERIE.Name = "RepItemGLU_TREF_PREST_SS_SERIE"
        Me.RepItemGLU_TREF_PREST_SS_SERIE.NullText = ""
        Me.RepItemGLU_TREF_PREST_SS_SERIE.ValueMember = "NPREST_SS_SERIE_ID"
        Me.RepItemGLU_TREF_PREST_SS_SERIE.View = Me.RepItemGLU_View_TREF_PREST_SS_SERIE
        '
        'RepItemGLU_View_TREF_PREST_SS_SERIE
        '
        Me.RepItemGLU_View_TREF_PREST_SS_SERIE.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_SSSerie_NPREST_SS_SERIE_ID, Me.GCol_SSSerie_NPRESTSERID, Me.GCol_SSSerie_VPREST_SS_SERIE_LIB})
        Me.RepItemGLU_View_TREF_PREST_SS_SERIE.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepItemGLU_View_TREF_PREST_SS_SERIE.Name = "RepItemGLU_View_TREF_PREST_SS_SERIE"
        Me.RepItemGLU_View_TREF_PREST_SS_SERIE.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepItemGLU_View_TREF_PREST_SS_SERIE.OptionsView.ShowGroupPanel = False
        '
        'GCol_SSSerie_NPREST_SS_SERIE_ID
        '
        Me.GCol_SSSerie_NPREST_SS_SERIE_ID.Caption = "NPREST_SS_SERIE_ID"
        Me.GCol_SSSerie_NPREST_SS_SERIE_ID.FieldName = "NPREST_SS_SERIE_ID"
        Me.GCol_SSSerie_NPREST_SS_SERIE_ID.Name = "GCol_SSSerie_NPREST_SS_SERIE_ID"
        '
        'GCol_SSSerie_NPRESTSERID
        '
        Me.GCol_SSSerie_NPRESTSERID.FieldName = "NPRESTSERID"
        Me.GCol_SSSerie_NPRESTSERID.Name = "GCol_SSSerie_NPRESTSERID"
        Me.GCol_SSSerie_NPRESTSERID.Width = 20
        '
        'GCol_SSSerie_VPREST_SS_SERIE_LIB
        '
        Me.GCol_SSSerie_VPREST_SS_SERIE_LIB.AppearanceHeader.Options.UseTextOptions = True
        Me.GCol_SSSerie_VPREST_SS_SERIE_LIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_SSSerie_VPREST_SS_SERIE_LIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_SSSerie_VPREST_SS_SERIE_LIB.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GCol_SSSerie_VPREST_SS_SERIE_LIB.Caption = "Sous-série"
        Me.GCol_SSSerie_VPREST_SS_SERIE_LIB.FieldName = "VPREST_SS_SERIE_LIB"
        Me.GCol_SSSerie_VPREST_SS_SERIE_LIB.Name = "GCol_SSSerie_VPREST_SS_SERIE_LIB"
        Me.GCol_SSSerie_VPREST_SS_SERIE_LIB.Visible = True
        Me.GCol_SSSerie_VPREST_SS_SERIE_LIB.VisibleIndex = 0
        Me.GCol_SSSerie_VPREST_SS_SERIE_LIB.Width = 192
        '
        'RepItemGLU_TREF_PREST_TYPE
        '
        Me.RepItemGLU_TREF_PREST_TYPE.AutoHeight = False
        Me.RepItemGLU_TREF_PREST_TYPE.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepItemGLU_TREF_PREST_TYPE.DisplayMember = "VPREST_TYPE_LIB"
        Me.RepItemGLU_TREF_PREST_TYPE.Name = "RepItemGLU_TREF_PREST_TYPE"
        Me.RepItemGLU_TREF_PREST_TYPE.NullText = ""
        Me.RepItemGLU_TREF_PREST_TYPE.ValueMember = "NPREST_TYPE_ID"
        Me.RepItemGLU_TREF_PREST_TYPE.View = Me.RepItemGLU_View_TREF_PREST_TYPE
        '
        'RepItemGLU_View_TREF_PREST_TYPE
        '
        Me.RepItemGLU_View_TREF_PREST_TYPE.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_NPREST_TYPE_ID, Me.GCol_VPREST_TYPE_LIB})
        Me.RepItemGLU_View_TREF_PREST_TYPE.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepItemGLU_View_TREF_PREST_TYPE.Name = "RepItemGLU_View_TREF_PREST_TYPE"
        Me.RepItemGLU_View_TREF_PREST_TYPE.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepItemGLU_View_TREF_PREST_TYPE.OptionsView.ShowAutoFilterRow = True
        Me.RepItemGLU_View_TREF_PREST_TYPE.OptionsView.ShowGroupPanel = False
        '
        'GCol_NPREST_TYPE_ID
        '
        Me.GCol_NPREST_TYPE_ID.Caption = "NPREST_TYPE_ID"
        Me.GCol_NPREST_TYPE_ID.FieldName = "NPREST_TYPE_ID"
        Me.GCol_NPREST_TYPE_ID.Name = "GCol_NPREST_TYPE_ID"
        '
        'GCol_VPREST_TYPE_LIB
        '
        Me.GCol_VPREST_TYPE_LIB.AppearanceHeader.Options.UseTextOptions = True
        Me.GCol_VPREST_TYPE_LIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_VPREST_TYPE_LIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_VPREST_TYPE_LIB.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GCol_VPREST_TYPE_LIB.Caption = "Type"
        Me.GCol_VPREST_TYPE_LIB.FieldName = "VPREST_TYPE_LIB"
        Me.GCol_VPREST_TYPE_LIB.Name = "GCol_VPREST_TYPE_LIB"
        Me.GCol_VPREST_TYPE_LIB.OptionsColumn.AllowEdit = False
        Me.GCol_VPREST_TYPE_LIB.OptionsColumn.ReadOnly = True
        Me.GCol_VPREST_TYPE_LIB.Visible = True
        Me.GCol_VPREST_TYPE_LIB.VisibleIndex = 0
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnSave)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Location = New System.Drawing.Point(12, 12)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(106, 653)
        Me.GrpActions.TabIndex = 6
        Me.GrpActions.TabStop = False
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSave.Location = New System.Drawing.Point(6, 19)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(95, 41)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "Enregistrer"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(6, 606)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(95, 41)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_DPRESTMOD)
        Me.GroupBox1.Controls.Add(Me.Txt_MODIF)
        Me.GroupBox1.Controls.Add(Me.Txt_DateCreate)
        Me.GroupBox1.Controls.Add(Me.Txt_Createur)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox1.Location = New System.Drawing.Point(941, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 192)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Historique"
        '
        'Txt_DPRESTMOD
        '
        Me.Txt_DPRESTMOD.Location = New System.Drawing.Point(180, 112)
        Me.Txt_DPRESTMOD.Name = "Txt_DPRESTMOD"
        Me.Txt_DPRESTMOD.Properties.AllowFocused = False
        Me.Txt_DPRESTMOD.Properties.ReadOnly = True
        Me.Txt_DPRESTMOD.Size = New System.Drawing.Size(163, 20)
        Me.Txt_DPRESTMOD.TabIndex = 13
        Me.Txt_DPRESTMOD.TabStop = False
        '
        'Txt_MODIF
        '
        Me.Txt_MODIF.Location = New System.Drawing.Point(180, 86)
        Me.Txt_MODIF.Name = "Txt_MODIF"
        Me.Txt_MODIF.Properties.AllowFocused = False
        Me.Txt_MODIF.Properties.ReadOnly = True
        Me.Txt_MODIF.Size = New System.Drawing.Size(163, 20)
        Me.Txt_MODIF.TabIndex = 12
        Me.Txt_MODIF.TabStop = False
        '
        'Txt_DateCreate
        '
        Me.Txt_DateCreate.Location = New System.Drawing.Point(180, 56)
        Me.Txt_DateCreate.Name = "Txt_DateCreate"
        Me.Txt_DateCreate.Properties.AllowFocused = False
        Me.Txt_DateCreate.Properties.ReadOnly = True
        Me.Txt_DateCreate.Size = New System.Drawing.Size(163, 20)
        Me.Txt_DateCreate.TabIndex = 11
        Me.Txt_DateCreate.TabStop = False
        '
        'Txt_Createur
        '
        Me.Txt_Createur.Location = New System.Drawing.Point(180, 30)
        Me.Txt_Createur.Name = "Txt_Createur"
        Me.Txt_Createur.Properties.AllowFocused = False
        Me.Txt_Createur.Properties.ReadOnly = True
        Me.Txt_Createur.Size = New System.Drawing.Size(163, 20)
        Me.Txt_Createur.TabIndex = 10
        Me.Txt_Createur.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(17, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Date dernière modification"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(17, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Dernière modification"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(17, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Date de création"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(17, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Créateur"
        '
        'GrpPageInfo
        '
        Me.GrpPageInfo.Controls.Add(Me.Wb_Information)
        Me.GrpPageInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpPageInfo.ForeColor = System.Drawing.Color.Firebrick
        Me.GrpPageInfo.Location = New System.Drawing.Point(972, 210)
        Me.GrpPageInfo.Name = "GrpPageInfo"
        Me.GrpPageInfo.Size = New System.Drawing.Size(684, 621)
        Me.GrpPageInfo.TabIndex = 8
        Me.GrpPageInfo.TabStop = False
        Me.GrpPageInfo.Text = "Information importante lors de la création d'une prestation"
        '
        'Wb_Information
        '
        Me.Wb_Information.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Wb_Information.Location = New System.Drawing.Point(3, 16)
        Me.Wb_Information.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Wb_Information.Name = "Wb_Information"
        Me.Wb_Information.Size = New System.Drawing.Size(678, 602)
        Me.Wb_Information.TabIndex = 0
        '
        'frmGestPrestationDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1771, 934)
        Me.Controls.Add(Me.GrpPageInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GrpListeFo)
        Me.Controls.Add(Me.GrpLibelle)
        Me.Controls.Add(Me.GrpCodePresta)
        Me.Controls.Add(Me.GrpBoxDebourse)
        Me.Controls.Add(Me.GrpBoxTypologie)
        Me.Name = "frmGestPrestationDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Détails d'une prestation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpBoxTypologie.ResumeLayout(False)
        Me.GrpBoxTypologie.PerformLayout()
        CType(Me.GridLookUpSousSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Cbo_Serie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GlookUpType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCboTypePresta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxDebourse.ResumeLayout(False)
        Me.GrpBoxDebourse.PerformLayout()
        CType(Me.Txt_MontantTotHT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_MontantFO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_PrixMO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_QteMO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpCodePresta.ResumeLayout(False)
        Me.GrpCodePresta.PerformLayout()
        CType(Me.Txt_VPRESTCODE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpLibelle.ResumeLayout(False)
        Me.GrpLibelle.PerformLayout()
        Me.GrpListeFo.ResumeLayout(False)
        CType(Me.GCListePrestFou, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListePrestFou, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLU_TPRESTSER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLU_View_TPRESTSER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLU_TREF_PREST_SS_SERIE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLU_View_TREF_PREST_SS_SERIE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLU_TREF_PREST_TYPE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLU_View_TREF_PREST_TYPE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Txt_DPRESTMOD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_MODIF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_DateCreate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_Createur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPageInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpBoxTypologie As GroupBox
    Friend WithEvents GrpBoxDebourse As GroupBox
    Friend WithEvents GrpCodePresta As GroupBox
    Friend WithEvents GrpLibelle As GroupBox
    Friend WithEvents GrpListeFo As GroupBox
    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GrpPageInfo As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Private WithEvents GridLookUpSousSerie As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridLookUpSerie As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GV_Cbo_Serie As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GlookUpType As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GVCboTypePresta As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCCboTypePresta_NPREST_TYPE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCCboTypePresta_VPREST_TYPE_LIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridLookUpEdit3 As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Txt_MontantTotHT As DevExpress.XtraEditors.TextEdit
    Private WithEvents Txt_MontantFO As DevExpress.XtraEditors.TextEdit
    Private WithEvents Txt_PrixMO As DevExpress.XtraEditors.TextEdit
    Private WithEvents Txt_QteMO As DevExpress.XtraEditors.TextEdit
    Private WithEvents Txt_DPRESTMOD As DevExpress.XtraEditors.TextEdit
    Private WithEvents Txt_MODIF As DevExpress.XtraEditors.TextEdit
    Private WithEvents Txt_DateCreate As DevExpress.XtraEditors.TextEdit
    Private WithEvents Txt_Createur As DevExpress.XtraEditors.TextEdit
    Private WithEvents Txt_VPRESTCODE As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Private WithEvents GCListePrestFou As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListePrestFou As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCol_Fo_NumArticle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_CCODEG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_FO_Serie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemGLU_TREF_PREST_TYPE As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepItemGLU_View_TREF_PREST_TYPE As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCol_NPREST_TYPE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VPREST_TYPE_LIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_Fo_Article As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemGLU_TPRESTSER As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepItemGLU_View_TPRESTSER As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCol_Serie_NPRESTSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_Serie_VPRESTSER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_FO_Marque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemGLU_TREF_PREST_SS_SERIE As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepItemGLU_View_TREF_PREST_SS_SERIE As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCol_SSSerie_NPREST_SS_SERIE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SSSerie_NPRESTSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SSSerie_VPREST_SS_SERIE_LIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_FO_Prix_U As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_FO_Prix_Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_FO_Quantite As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_FO_VFOUTYP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_FO_NFOUNBLOT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Wb_Information As WebBrowser
    Friend WithEvents Txt_VPRESTLIB As TextBox
    Friend WithEvents BtnSupprimerFO As Button
    Friend WithEvents BtnAddFO As Button
    Friend WithEvents GCol_FO_VFOUREF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnConvert As Button
End Class
