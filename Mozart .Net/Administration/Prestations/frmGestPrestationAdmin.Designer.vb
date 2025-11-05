<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestPrestationAdmin
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
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnListeArchives = New System.Windows.Forms.Button()
        Me.BtnArchiver = New System.Windows.Forms.Button()
        Me.BtnCopiePresta = New System.Windows.Forms.Button()
        Me.BtnGestSerieAndSousSeriePresta = New System.Windows.Forms.Button()
        Me.BtnRestaure = New System.Windows.Forms.Button()
        Me.BtnDetail = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnPrixClients = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GCListePrest = New DevExpress.XtraGrid.GridControl()
        Me.GVListePrest = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_NPRESTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NPRESTSERD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_List_NPREST_TYPE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLU_TREF_PREST_TYPE = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepItemGLU_View_TREF_PREST_TYPE = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_NPREST_TYPE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VPREST_TYPE_LIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NPRESTSERID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLU_TPRESTSER = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepItemGLU_View_TPRESTSER = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_Serie_NPRESTSERID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_Serie_VPRESTSER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NPREST_SS_SERIE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLU_TREF_PREST_SS_SERIE = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepItemGLU_View_TREF_PREST_SS_SERIE = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_SSSerie_NPREST_SS_SERIE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SSSerie_NPRESTSERID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SSSerie_VPREST_SS_SERIE_LIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VPRESTCODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VPRESTLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VPRESTUNITE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLU_TUNITE = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NPRESTQTEMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NPRESTFOHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_CREATEUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_DPRESTCRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_CLIENTS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_UTIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_FILIALES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_DERUTIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GrpBoxSearch = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GridLookUpSerie = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GV_Cbo_Serie = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChkModifiable = New System.Windows.Forms.CheckBox()
        Me.BtnFind = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCritClients = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCritCreateur = New System.Windows.Forms.TextBox()
        Me.TxtCritPresta = New System.Windows.Forms.TextBox()
        Me.TxtCritCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCListePrest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListePrest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLU_TREF_PREST_TYPE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLU_View_TREF_PREST_TYPE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLU_TPRESTSER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLU_View_TPRESTSER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLU_TREF_PREST_SS_SERIE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLU_View_TREF_PREST_SS_SERIE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLU_TUNITE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxSearch.SuspendLayout()
        CType(Me.GridLookUpSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Cbo_Serie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnSave)
        Me.GrpActions.Controls.Add(Me.BtnListeArchives)
        Me.GrpActions.Controls.Add(Me.BtnArchiver)
        Me.GrpActions.Controls.Add(Me.BtnCopiePresta)
        Me.GrpActions.Controls.Add(Me.BtnGestSerieAndSousSeriePresta)
        Me.GrpActions.Controls.Add(Me.BtnRestaure)
        Me.GrpActions.Controls.Add(Me.BtnDetail)
        Me.GrpActions.Controls.Add(Me.BtnAdd)
        Me.GrpActions.Controls.Add(Me.BtnPrixClients)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Location = New System.Drawing.Point(12, 9)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(141, 728)
        Me.GrpActions.TabIndex = 7
        Me.GrpActions.TabStop = False
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSave.Location = New System.Drawing.Point(6, 19)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(129, 41)
        Me.BtnSave.TabIndex = 11
        Me.BtnSave.Tag = "224"
        Me.BtnSave.Text = "Enregistrer"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnListeArchives
        '
        Me.BtnListeArchives.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnListeArchives.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnListeArchives.Location = New System.Drawing.Point(6, 630)
        Me.BtnListeArchives.Name = "BtnListeArchives"
        Me.BtnListeArchives.Size = New System.Drawing.Size(129, 41)
        Me.BtnListeArchives.TabIndex = 10
        Me.BtnListeArchives.Text = "Liste archives"
        Me.BtnListeArchives.UseVisualStyleBackColor = True
        '
        'BtnArchiver
        '
        Me.BtnArchiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnArchiver.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnArchiver.Location = New System.Drawing.Point(6, 583)
        Me.BtnArchiver.Name = "BtnArchiver"
        Me.BtnArchiver.Size = New System.Drawing.Size(129, 41)
        Me.BtnArchiver.TabIndex = 9
        Me.BtnArchiver.Tag = "225"
        Me.BtnArchiver.Text = "Archiver"
        Me.BtnArchiver.UseVisualStyleBackColor = True
        '
        'BtnCopiePresta
        '
        Me.BtnCopiePresta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnCopiePresta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCopiePresta.Location = New System.Drawing.Point(6, 536)
        Me.BtnCopiePresta.Name = "BtnCopiePresta"
        Me.BtnCopiePresta.Size = New System.Drawing.Size(129, 41)
        Me.BtnCopiePresta.TabIndex = 8
        Me.BtnCopiePresta.Tag = "271"
        Me.BtnCopiePresta.Text = "Copie prestation"
        Me.BtnCopiePresta.UseVisualStyleBackColor = True
        '
        'BtnGestSerieAndSousSeriePresta
        '
        Me.BtnGestSerieAndSousSeriePresta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnGestSerieAndSousSeriePresta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnGestSerieAndSousSeriePresta.Location = New System.Drawing.Point(6, 391)
        Me.BtnGestSerieAndSousSeriePresta.Name = "BtnGestSerieAndSousSeriePresta"
        Me.BtnGestSerieAndSousSeriePresta.Size = New System.Drawing.Size(129, 49)
        Me.BtnGestSerieAndSousSeriePresta.TabIndex = 7
        Me.BtnGestSerieAndSousSeriePresta.Tag = "226"
        Me.BtnGestSerieAndSousSeriePresta.Text = "Gestion des séries et sous séries de prestations"
        Me.BtnGestSerieAndSousSeriePresta.UseVisualStyleBackColor = True
        '
        'BtnRestaure
        '
        Me.BtnRestaure.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnRestaure.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnRestaure.Location = New System.Drawing.Point(6, 344)
        Me.BtnRestaure.Name = "BtnRestaure"
        Me.BtnRestaure.Size = New System.Drawing.Size(129, 41)
        Me.BtnRestaure.TabIndex = 6
        Me.BtnRestaure.Tag = "161"
        Me.BtnRestaure.Text = "Restaurer"
        Me.BtnRestaure.UseVisualStyleBackColor = True
        '
        'BtnDetail
        '
        Me.BtnDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnDetail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnDetail.Location = New System.Drawing.Point(6, 143)
        Me.BtnDetail.Name = "BtnDetail"
        Me.BtnDetail.Size = New System.Drawing.Size(129, 41)
        Me.BtnDetail.TabIndex = 5
        Me.BtnDetail.Text = "Détail"
        Me.BtnDetail.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnAdd.Location = New System.Drawing.Point(6, 96)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(129, 41)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Tag = "224"
        Me.BtnAdd.Text = "Ajouter"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnPrixClients
        '
        Me.BtnPrixClients.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnPrixClients.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPrixClients.Location = New System.Drawing.Point(6, 190)
        Me.BtnPrixClients.Name = "BtnPrixClients"
        Me.BtnPrixClients.Size = New System.Drawing.Size(129, 41)
        Me.BtnPrixClients.TabIndex = 3
        Me.BtnPrixClients.Text = "Prix clients"
        Me.BtnPrixClients.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(6, 681)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(129, 41)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GCListePrest
        '
        Me.GCListePrest.Location = New System.Drawing.Point(168, 140)
        Me.GCListePrest.MainView = Me.GVListePrest
        Me.GCListePrest.Name = "GCListePrest"
        Me.GCListePrest.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepItemGLU_TPRESTSER, Me.RepItemGLU_TREF_PREST_SS_SERIE, Me.RepItemGLU_TREF_PREST_TYPE, Me.RepItemGLU_TUNITE})
        Me.GCListePrest.Size = New System.Drawing.Size(1365, 597)
        Me.GCListePrest.TabIndex = 8
        Me.GCListePrest.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListePrest})
        '
        'GVListePrest
        '
        Me.GVListePrest.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrest.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrest.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GVListePrest.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVListePrest.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVListePrest.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVListePrest.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListePrest.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListePrest.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVListePrest.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVListePrest.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVListePrest.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVListePrest.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrest.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVListePrest.Appearance.Empty.Options.UseBackColor = True
        Me.GVListePrest.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrest.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrest.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVListePrest.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVListePrest.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVListePrest.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVListePrest.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrest.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrest.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GVListePrest.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVListePrest.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVListePrest.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVListePrest.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrest.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVListePrest.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListePrest.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVListePrest.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVListePrest.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GVListePrest.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVListePrest.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVListePrest.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVListePrest.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListePrest.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVListePrest.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GVListePrest.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GVListePrest.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVListePrest.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVListePrest.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVListePrest.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVListePrest.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrest.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrest.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListePrest.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVListePrest.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVListePrest.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVListePrest.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrest.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrest.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVListePrest.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVListePrest.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListePrest.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListePrest.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVListePrest.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVListePrest.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVListePrest.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVListePrest.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrest.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVListePrest.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListePrest.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVListePrest.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVListePrest.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListePrest.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListePrest.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVListePrest.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVListePrest.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVListePrest.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVListePrest.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListePrest.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVListePrest.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListePrest.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVListePrest.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVListePrest.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVListePrest.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListePrest.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVListePrest.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListePrest.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListePrest.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListePrest.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListePrest.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GVListePrest.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListePrest.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrest.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVListePrest.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVListePrest.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVListePrest.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrest.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVListePrest.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrest.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrest.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVListePrest.Appearance.OddRow.Options.UseBackColor = True
        Me.GVListePrest.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVListePrest.Appearance.OddRow.Options.UseForeColor = True
        Me.GVListePrest.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVListePrest.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListePrest.Appearance.Preview.Options.UseFont = True
        Me.GVListePrest.Appearance.Preview.Options.UseForeColor = True
        Me.GVListePrest.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrest.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVListePrest.Appearance.Row.Options.UseBackColor = True
        Me.GVListePrest.Appearance.Row.Options.UseForeColor = True
        Me.GVListePrest.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListePrest.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVListePrest.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVListePrest.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVListePrest.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVListePrest.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListePrest.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVListePrest.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVListePrest.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVListePrest.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVListePrest.Appearance.VertLine.Options.UseBackColor = True
        Me.GVListePrest.ColumnPanelRowHeight = 40
        Me.GVListePrest.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_NPRESTID, Me.GCol_NPRESTSERD, Me.GCol_List_NPREST_TYPE_ID, Me.GCol_NPRESTSERID, Me.GCol_NPREST_SS_SERIE_ID, Me.GCol_VPRESTCODE, Me.GCol_VPRESTLIB, Me.GCol_VPRESTUNITE, Me.GCol_NPRESTQTEMO, Me.GCol_NPRESTFOHT, Me.GCol_CREATEUR, Me.GCol_DPRESTCRE, Me.GCol_CLIENTS, Me.GCol_UTIL, Me.GCol_FILIALES, Me.GCol_DERUTIL, Me.GridColumn1})
        Me.GVListePrest.GridControl = Me.GCListePrest
        Me.GVListePrest.Name = "GVListePrest"
        Me.GVListePrest.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListePrest.OptionsView.EnableAppearanceOddRow = True
        Me.GVListePrest.OptionsView.RowAutoHeight = True
        Me.GVListePrest.OptionsView.ShowAutoFilterRow = True
        Me.GVListePrest.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVListePrest.OptionsView.ShowFooter = True
        Me.GVListePrest.OptionsView.ShowGroupPanel = False
        '
        'GCol_NPRESTID
        '
        Me.GCol_NPRESTID.Caption = "NPRESTID"
        Me.GCol_NPRESTID.FieldName = "NPRESTID"
        Me.GCol_NPRESTID.Name = "GCol_NPRESTID"
        '
        'GCol_NPRESTSERD
        '
        Me.GCol_NPRESTSERD.Caption = "NPRESTSERD"
        Me.GCol_NPRESTSERD.FieldName = "NPRESTSERD"
        Me.GCol_NPRESTSERD.Name = "GCol_NPRESTSERD"
        '
        'GCol_List_NPREST_TYPE_ID
        '
        Me.GCol_List_NPREST_TYPE_ID.Caption = "Type"
        Me.GCol_List_NPREST_TYPE_ID.ColumnEdit = Me.RepItemGLU_TREF_PREST_TYPE
        Me.GCol_List_NPREST_TYPE_ID.FieldName = "NPREST_TYPE_ID"
        Me.GCol_List_NPREST_TYPE_ID.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.GCol_List_NPREST_TYPE_ID.Name = "GCol_List_NPREST_TYPE_ID"
        Me.GCol_List_NPREST_TYPE_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_List_NPREST_TYPE_ID.Visible = True
        Me.GCol_List_NPREST_TYPE_ID.VisibleIndex = 0
        Me.GCol_List_NPREST_TYPE_ID.Width = 96
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
        'GCol_NPRESTSERID
        '
        Me.GCol_NPRESTSERID.Caption = "Série"
        Me.GCol_NPRESTSERID.ColumnEdit = Me.RepItemGLU_TPRESTSER
        Me.GCol_NPRESTSERID.FieldName = "NPRESTSERID"
        Me.GCol_NPRESTSERID.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.GCol_NPRESTSERID.Name = "GCol_NPRESTSERID"
        Me.GCol_NPRESTSERID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_NPRESTSERID.Visible = True
        Me.GCol_NPRESTSERID.VisibleIndex = 1
        Me.GCol_NPRESTSERID.Width = 200
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
        'GCol_NPREST_SS_SERIE_ID
        '
        Me.GCol_NPREST_SS_SERIE_ID.Caption = "Sous-série"
        Me.GCol_NPREST_SS_SERIE_ID.ColumnEdit = Me.RepItemGLU_TREF_PREST_SS_SERIE
        Me.GCol_NPREST_SS_SERIE_ID.FieldName = "NPREST_SS_SERIE_ID"
        Me.GCol_NPREST_SS_SERIE_ID.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.GCol_NPREST_SS_SERIE_ID.Name = "GCol_NPREST_SS_SERIE_ID"
        Me.GCol_NPREST_SS_SERIE_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_NPREST_SS_SERIE_ID.Visible = True
        Me.GCol_NPREST_SS_SERIE_ID.VisibleIndex = 2
        Me.GCol_NPREST_SS_SERIE_ID.Width = 86
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
        'GCol_VPRESTCODE
        '
        Me.GCol_VPRESTCODE.Caption = "Code"
        Me.GCol_VPRESTCODE.FieldName = "VPRESTCODE"
        Me.GCol_VPRESTCODE.Name = "GCol_VPRESTCODE"
        Me.GCol_VPRESTCODE.OptionsColumn.AllowEdit = False
        Me.GCol_VPRESTCODE.OptionsColumn.ReadOnly = True
        Me.GCol_VPRESTCODE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_VPRESTCODE.Visible = True
        Me.GCol_VPRESTCODE.VisibleIndex = 3
        Me.GCol_VPRESTCODE.Width = 86
        '
        'GCol_VPRESTLIB
        '
        Me.GCol_VPRESTLIB.Caption = "Prestation"
        Me.GCol_VPRESTLIB.FieldName = "VPRESTLIB"
        Me.GCol_VPRESTLIB.Name = "GCol_VPRESTLIB"
        Me.GCol_VPRESTLIB.OptionsColumn.AllowEdit = False
        Me.GCol_VPRESTLIB.OptionsColumn.ReadOnly = True
        Me.GCol_VPRESTLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_VPRESTLIB.Visible = True
        Me.GCol_VPRESTLIB.VisibleIndex = 4
        Me.GCol_VPRESTLIB.Width = 300
        '
        'GCol_VPRESTUNITE
        '
        Me.GCol_VPRESTUNITE.Caption = "Unité"
        Me.GCol_VPRESTUNITE.ColumnEdit = Me.RepItemGLU_TUNITE
        Me.GCol_VPRESTUNITE.FieldName = "VPRESTUNITE"
        Me.GCol_VPRESTUNITE.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.GCol_VPRESTUNITE.Name = "GCol_VPRESTUNITE"
        Me.GCol_VPRESTUNITE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_VPRESTUNITE.Visible = True
        Me.GCol_VPRESTUNITE.VisibleIndex = 5
        Me.GCol_VPRESTUNITE.Width = 62
        '
        'RepItemGLU_TUNITE
        '
        Me.RepItemGLU_TUNITE.AutoHeight = False
        Me.RepItemGLU_TUNITE.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepItemGLU_TUNITE.DisplayMember = "VUNITE"
        Me.RepItemGLU_TUNITE.Name = "RepItemGLU_TUNITE"
        Me.RepItemGLU_TUNITE.ValueMember = "VUNITE"
        Me.RepItemGLU_TUNITE.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Unité"
        Me.GridColumn4.FieldName = "VUNITE"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GCol_NPRESTQTEMO
        '
        Me.GCol_NPRESTQTEMO.Caption = "Main oeuvre (h)"
        Me.GCol_NPRESTQTEMO.FieldName = "NPRESTQTEMO"
        Me.GCol_NPRESTQTEMO.Name = "GCol_NPRESTQTEMO"
        Me.GCol_NPRESTQTEMO.OptionsColumn.AllowEdit = False
        Me.GCol_NPRESTQTEMO.OptionsColumn.ReadOnly = True
        Me.GCol_NPRESTQTEMO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_NPRESTQTEMO.Visible = True
        Me.GCol_NPRESTQTEMO.VisibleIndex = 6
        Me.GCol_NPRESTQTEMO.Width = 80
        '
        'GCol_NPRESTFOHT
        '
        Me.GCol_NPRESTFOHT.Caption = "Montant FO €"
        Me.GCol_NPRESTFOHT.FieldName = "NPRESTFOHT"
        Me.GCol_NPRESTFOHT.Name = "GCol_NPRESTFOHT"
        Me.GCol_NPRESTFOHT.OptionsColumn.AllowEdit = False
        Me.GCol_NPRESTFOHT.OptionsColumn.ReadOnly = True
        Me.GCol_NPRESTFOHT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_NPRESTFOHT.Visible = True
        Me.GCol_NPRESTFOHT.VisibleIndex = 7
        Me.GCol_NPRESTFOHT.Width = 59
        '
        'GCol_CREATEUR
        '
        Me.GCol_CREATEUR.Caption = "Créateur"
        Me.GCol_CREATEUR.FieldName = "CREATEUR"
        Me.GCol_CREATEUR.Name = "GCol_CREATEUR"
        Me.GCol_CREATEUR.OptionsColumn.AllowEdit = False
        Me.GCol_CREATEUR.OptionsColumn.ReadOnly = True
        Me.GCol_CREATEUR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_CREATEUR.Visible = True
        Me.GCol_CREATEUR.VisibleIndex = 8
        Me.GCol_CREATEUR.Width = 59
        '
        'GCol_DPRESTCRE
        '
        Me.GCol_DPRESTCRE.Caption = "Date création"
        Me.GCol_DPRESTCRE.FieldName = "DPRESTCRE"
        Me.GCol_DPRESTCRE.Name = "GCol_DPRESTCRE"
        Me.GCol_DPRESTCRE.OptionsColumn.AllowEdit = False
        Me.GCol_DPRESTCRE.OptionsColumn.ReadOnly = True
        Me.GCol_DPRESTCRE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_DPRESTCRE.Visible = True
        Me.GCol_DPRESTCRE.VisibleIndex = 9
        Me.GCol_DPRESTCRE.Width = 59
        '
        'GCol_CLIENTS
        '
        Me.GCol_CLIENTS.Caption = "Clients en PV"
        Me.GCol_CLIENTS.FieldName = "CLIENTS"
        Me.GCol_CLIENTS.Name = "GCol_CLIENTS"
        Me.GCol_CLIENTS.OptionsColumn.AllowEdit = False
        Me.GCol_CLIENTS.OptionsColumn.ReadOnly = True
        Me.GCol_CLIENTS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_CLIENTS.Visible = True
        Me.GCol_CLIENTS.VisibleIndex = 10
        Me.GCol_CLIENTS.Width = 59
        '
        'GCol_UTIL
        '
        Me.GCol_UTIL.Caption = "Clients en utilisations"
        Me.GCol_UTIL.FieldName = "UTIL"
        Me.GCol_UTIL.Name = "GCol_UTIL"
        Me.GCol_UTIL.OptionsColumn.AllowEdit = False
        Me.GCol_UTIL.OptionsColumn.ReadOnly = True
        Me.GCol_UTIL.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_UTIL.Visible = True
        Me.GCol_UTIL.VisibleIndex = 11
        Me.GCol_UTIL.Width = 80
        '
        'GCol_FILIALES
        '
        Me.GCol_FILIALES.Caption = "Filiales"
        Me.GCol_FILIALES.FieldName = "FILIALES"
        Me.GCol_FILIALES.Name = "GCol_FILIALES"
        Me.GCol_FILIALES.OptionsColumn.AllowEdit = False
        Me.GCol_FILIALES.OptionsColumn.ReadOnly = True
        Me.GCol_FILIALES.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_FILIALES.Visible = True
        Me.GCol_FILIALES.VisibleIndex = 12
        Me.GCol_FILIALES.Width = 50
        '
        'GCol_DERUTIL
        '
        Me.GCol_DERUTIL.Caption = "Dernière utilisation"
        Me.GCol_DERUTIL.FieldName = "DERUTIL"
        Me.GCol_DERUTIL.Name = "GCol_DERUTIL"
        Me.GCol_DERUTIL.OptionsColumn.AllowEdit = False
        Me.GCol_DERUTIL.OptionsColumn.ReadOnly = True
        Me.GCol_DERUTIL.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_DERUTIL.Visible = True
        Me.GCol_DERUTIL.VisibleIndex = 13
        Me.GCol_DERUTIL.Width = 71
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "PR"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelTitre.Location = New System.Drawing.Point(163, 9)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(378, 29)
        Me.LabelTitre.TabIndex = 30
        Me.LabelTitre.Text = "Gestion des prestations tarifées"
        '
        'GrpBoxSearch
        '
        Me.GrpBoxSearch.Controls.Add(Me.Label5)
        Me.GrpBoxSearch.Controls.Add(Me.GridLookUpSerie)
        Me.GrpBoxSearch.Controls.Add(Me.ChkModifiable)
        Me.GrpBoxSearch.Controls.Add(Me.BtnFind)
        Me.GrpBoxSearch.Controls.Add(Me.Label4)
        Me.GrpBoxSearch.Controls.Add(Me.TxtCritClients)
        Me.GrpBoxSearch.Controls.Add(Me.Label3)
        Me.GrpBoxSearch.Controls.Add(Me.Label2)
        Me.GrpBoxSearch.Controls.Add(Me.TxtCritCreateur)
        Me.GrpBoxSearch.Controls.Add(Me.TxtCritPresta)
        Me.GrpBoxSearch.Controls.Add(Me.TxtCritCode)
        Me.GrpBoxSearch.Controls.Add(Me.Label1)
        Me.GrpBoxSearch.Location = New System.Drawing.Point(168, 41)
        Me.GrpBoxSearch.Name = "GrpBoxSearch"
        Me.GrpBoxSearch.Size = New System.Drawing.Size(1557, 82)
        Me.GrpBoxSearch.TabIndex = 31
        Me.GrpBoxSearch.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Série"
        '
        'GridLookUpSerie
        '
        Me.GridLookUpSerie.EditValue = ""
        Me.GridLookUpSerie.Location = New System.Drawing.Point(66, 28)
        Me.GridLookUpSerie.Name = "GridLookUpSerie"
        Me.GridLookUpSerie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpSerie.Properties.DisplayMember = "VPRESTSER"
        Me.GridLookUpSerie.Properties.NullText = ""
        Me.GridLookUpSerie.Properties.ValueMember = "NPRESTSERID"
        Me.GridLookUpSerie.Properties.View = Me.GV_Cbo_Serie
        Me.GridLookUpSerie.Size = New System.Drawing.Size(204, 20)
        Me.GridLookUpSerie.TabIndex = 12
        '
        'GV_Cbo_Serie
        '
        Me.GV_Cbo_Serie.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3})
        Me.GV_Cbo_Serie.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GV_Cbo_Serie.Name = "GV_Cbo_Serie"
        Me.GV_Cbo_Serie.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GV_Cbo_Serie.OptionsView.ShowAutoFilterRow = True
        Me.GV_Cbo_Serie.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn2.Caption = "NPRESTSERID"
        Me.GridColumn2.FieldName = "NPRESTSERID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn3.Caption = "Série"
        Me.GridColumn3.FieldName = "VPRESTSER"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'ChkModifiable
        '
        Me.ChkModifiable.AutoSize = True
        Me.ChkModifiable.Checked = True
        Me.ChkModifiable.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.ChkModifiable.Location = New System.Drawing.Point(66, 59)
        Me.ChkModifiable.Name = "ChkModifiable"
        Me.ChkModifiable.Size = New System.Drawing.Size(171, 17)
        Me.ChkModifiable.TabIndex = 11
        Me.ChkModifiable.Text = "Modification Type, Série, Unité"
        Me.ChkModifiable.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.Location = New System.Drawing.Point(1458, 25)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(75, 23)
        Me.BtnFind.TabIndex = 10
        Me.BtnFind.Text = "Valider"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1147, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Clients"
        '
        'TxtCritClients
        '
        Me.TxtCritClients.Location = New System.Drawing.Point(1198, 28)
        Me.TxtCritClients.Name = "TxtCritClients"
        Me.TxtCritClients.Size = New System.Drawing.Size(241, 20)
        Me.TxtCritClients.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(870, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Créateur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(448, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Prestation"
        '
        'TxtCritCreateur
        '
        Me.TxtCritCreateur.Location = New System.Drawing.Point(931, 29)
        Me.TxtCritCreateur.Name = "TxtCritCreateur"
        Me.TxtCritCreateur.Size = New System.Drawing.Size(179, 20)
        Me.TxtCritCreateur.TabIndex = 5
        '
        'TxtCritPresta
        '
        Me.TxtCritPresta.Location = New System.Drawing.Point(522, 28)
        Me.TxtCritPresta.Name = "TxtCritPresta"
        Me.TxtCritPresta.Size = New System.Drawing.Size(309, 20)
        Me.TxtCritPresta.TabIndex = 3
        '
        'TxtCritCode
        '
        Me.TxtCritCode.Location = New System.Drawing.Point(318, 28)
        Me.TxtCritCode.Name = "TxtCritCode"
        Me.TxtCritCode.Size = New System.Drawing.Size(124, 20)
        Me.TxtCritCode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
        '
        'frmGestPrestationAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1982, 1020)
        Me.Controls.Add(Me.GrpBoxSearch)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GCListePrest)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmGestPrestationAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des prestations"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCListePrest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListePrest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLU_TREF_PREST_TYPE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLU_View_TREF_PREST_TYPE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLU_TPRESTSER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLU_View_TPRESTSER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLU_TREF_PREST_SS_SERIE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLU_View_TREF_PREST_SS_SERIE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLU_TUNITE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxSearch.ResumeLayout(False)
        Me.GrpBoxSearch.PerformLayout()
        CType(Me.GridLookUpSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Cbo_Serie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnDetail As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnPrixClients As Button
    Friend WithEvents BtnFermer As Button
    Private WithEvents GCListePrest As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListePrest As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents LabelTitre As Label
    Friend WithEvents GrpBoxSearch As GroupBox
    Friend WithEvents BtnArchiver As Button
    Friend WithEvents BtnCopiePresta As Button
    Friend WithEvents BtnGestSerieAndSousSeriePresta As Button
    Friend WithEvents BtnRestaure As Button
    Friend WithEvents BtnListeArchives As Button
    Friend WithEvents GCol_NPRESTID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NPRESTSERD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NPRESTSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VPRESTCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VPRESTLIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VPRESTUNITE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NPRESTQTEMO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NPRESTFOHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_CREATEUR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_DPRESTCRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_CLIENTS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_UTIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_FILIALES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_DERUTIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtCritCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCritCreateur As TextBox
    Friend WithEvents TxtCritPresta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCritClients As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnFind As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents GCol_NPREST_SS_SERIE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_List_NPREST_TYPE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemGLU_TPRESTSER As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepItemGLU_View_TPRESTSER As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCol_Serie_NPRESTSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_Serie_VPRESTSER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemGLU_TREF_PREST_SS_SERIE As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepItemGLU_View_TREF_PREST_SS_SERIE As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCol_SSSerie_NPREST_SS_SERIE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SSSerie_NPRESTSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SSSerie_VPREST_SS_SERIE_LIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemGLU_TREF_PREST_TYPE As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepItemGLU_View_TREF_PREST_TYPE As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCol_NPREST_TYPE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VPREST_TYPE_LIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChkModifiable As CheckBox
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As Label
    Private WithEvents GridLookUpSerie As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GV_Cbo_Serie As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemGLU_TUNITE As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
