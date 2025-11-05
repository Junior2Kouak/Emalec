<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQCMDetail
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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQCMDetail))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuQCM = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ItemNewQuestionQCM = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuDébutDuQuestionnaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALaFinDuQuestionnaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemAfficheQuestArchi = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItemAnnuleQCM = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuQuestion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ItemAjoutQuestion = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuDébutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÀLaLigneDuDessusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÀLaLigneEnDessousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÀLaFinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemUpQuestion = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemDownQuestion = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItemArchiveQuestion = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemRestaureQuestion = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItemAnnuleQuestion = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrpBxReponses = New System.Windows.Forms.GroupBox()
        Me.GrpReponseLibre = New System.Windows.Forms.GroupBox()
        Me.ChkRemarque = New System.Windows.Forms.CheckBox()
        Me.BtnModif = New System.Windows.Forms.Button()
        Me.BtnSaveRep = New System.Windows.Forms.Button()
        Me.btnRestoreRep = New System.Windows.Forms.Button()
        Me.BtnArchRep = New System.Windows.Forms.Button()
        Me.BtnAjoutRep = New System.Windows.Forms.Button()
        Me.DGVReponse = New System.Windows.Forms.DataGridView()
        Me.ColIDRep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIDQCMREPONSE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NQCMREPONSEORDER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VQCMREPONSELIB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BQCMREPONSEVALID = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BQCMREPONSEACTIF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VQCMREPONSEOBSCORRECT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChkListRepArchives = New System.Windows.Forms.CheckBox()
        Me.GrpBoxQuestion = New System.Windows.Forms.GroupBox()
        Me.BtnAddImage = New System.Windows.Forms.Button()
        Me.BtnVideo = New System.Windows.Forms.Button()
        Me.BtnConsigne = New System.Windows.Forms.Button()
        Me.ChkQCMCorrectAuto = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboTypeQCM = New System.Windows.Forms.ComboBox()
        Me.GrpDetailQCM = New System.Windows.Forms.GroupBox()
        Me.ChkBoxQCMRecru = New System.Windows.Forms.CheckBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblNomQCM = New System.Windows.Forms.Label()
        Me.BtnSaveQuestion = New System.Windows.Forms.Button()
        Me.ChkListQuestArchives = New System.Windows.Forms.CheckBox()
        Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
        Me.TLColQCM = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TLColNIDCQMQUESTION = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TLColNQCMQUESTIONORDER = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TLColVQUESTIONLIB = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TLCol_NBIMG = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TLColActif = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TLColID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TLColBQCMQUESTIONREM = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.BtnArchiveQuestion = New System.Windows.Forms.Button()
        Me.BtnRestaureQuestion = New System.Windows.Forms.Button()
        Me.BtnNewQuestion = New System.Windows.Forms.Button()
        Me.ToolTipTreeList = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuQCM.SuspendLayout()
        Me.MenuQuestion.SuspendLayout()
        Me.GrpBxReponses.SuspendLayout()
        Me.GrpReponseLibre.SuspendLayout()
        CType(Me.DGVReponse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxQuestion.SuspendLayout()
        Me.GrpDetailQCM.SuspendLayout()
        CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "ico-qcm.png")
        Me.ImageList1.Images.SetKeyName(1, "ico-question.png")
        '
        'MenuQCM
        '
        Me.MenuQCM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemNewQuestionQCM, Me.ItemAfficheQuestArchi, Me.ToolStripSeparator1, Me.ItemAnnuleQCM})
        Me.MenuQCM.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.MenuQCM, "MenuQCM")
        '
        'ItemNewQuestionQCM
        '
        Me.ItemNewQuestionQCM.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AuDébutDuQuestionnaireToolStripMenuItem, Me.ALaFinDuQuestionnaireToolStripMenuItem})
        Me.ItemNewQuestionQCM.Name = "ItemNewQuestionQCM"
        resources.ApplyResources(Me.ItemNewQuestionQCM, "ItemNewQuestionQCM")
        '
        'AuDébutDuQuestionnaireToolStripMenuItem
        '
        Me.AuDébutDuQuestionnaireToolStripMenuItem.Name = "AuDébutDuQuestionnaireToolStripMenuItem"
        resources.ApplyResources(Me.AuDébutDuQuestionnaireToolStripMenuItem, "AuDébutDuQuestionnaireToolStripMenuItem")
        '
        'ALaFinDuQuestionnaireToolStripMenuItem
        '
        Me.ALaFinDuQuestionnaireToolStripMenuItem.Name = "ALaFinDuQuestionnaireToolStripMenuItem"
        resources.ApplyResources(Me.ALaFinDuQuestionnaireToolStripMenuItem, "ALaFinDuQuestionnaireToolStripMenuItem")
        '
        'ItemAfficheQuestArchi
        '
        Me.ItemAfficheQuestArchi.CheckOnClick = True
        Me.ItemAfficheQuestArchi.Name = "ItemAfficheQuestArchi"
        resources.ApplyResources(Me.ItemAfficheQuestArchi, "ItemAfficheQuestArchi")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'ItemAnnuleQCM
        '
        Me.ItemAnnuleQCM.Name = "ItemAnnuleQCM"
        resources.ApplyResources(Me.ItemAnnuleQCM, "ItemAnnuleQCM")
        '
        'MenuQuestion
        '
        Me.MenuQuestion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemAjoutQuestion, Me.ItemUpQuestion, Me.ItemDownQuestion, Me.ToolStripSeparator3, Me.ItemArchiveQuestion, Me.ItemRestaureQuestion, Me.ToolStripSeparator2, Me.ItemAnnuleQuestion})
        Me.MenuQuestion.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.MenuQuestion, "MenuQuestion")
        '
        'ItemAjoutQuestion
        '
        Me.ItemAjoutQuestion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AuDébutToolStripMenuItem, Me.ÀLaLigneDuDessusToolStripMenuItem, Me.ÀLaLigneEnDessousToolStripMenuItem, Me.ÀLaFinToolStripMenuItem})
        Me.ItemAjoutQuestion.Name = "ItemAjoutQuestion"
        resources.ApplyResources(Me.ItemAjoutQuestion, "ItemAjoutQuestion")
        '
        'AuDébutToolStripMenuItem
        '
        Me.AuDébutToolStripMenuItem.Name = "AuDébutToolStripMenuItem"
        resources.ApplyResources(Me.AuDébutToolStripMenuItem, "AuDébutToolStripMenuItem")
        '
        'ÀLaLigneDuDessusToolStripMenuItem
        '
        Me.ÀLaLigneDuDessusToolStripMenuItem.Name = "ÀLaLigneDuDessusToolStripMenuItem"
        resources.ApplyResources(Me.ÀLaLigneDuDessusToolStripMenuItem, "ÀLaLigneDuDessusToolStripMenuItem")
        '
        'ÀLaLigneEnDessousToolStripMenuItem
        '
        Me.ÀLaLigneEnDessousToolStripMenuItem.Name = "ÀLaLigneEnDessousToolStripMenuItem"
        resources.ApplyResources(Me.ÀLaLigneEnDessousToolStripMenuItem, "ÀLaLigneEnDessousToolStripMenuItem")
        '
        'ÀLaFinToolStripMenuItem
        '
        Me.ÀLaFinToolStripMenuItem.Name = "ÀLaFinToolStripMenuItem"
        resources.ApplyResources(Me.ÀLaFinToolStripMenuItem, "ÀLaFinToolStripMenuItem")
        '
        'ItemUpQuestion
        '
        Me.ItemUpQuestion.Name = "ItemUpQuestion"
        resources.ApplyResources(Me.ItemUpQuestion, "ItemUpQuestion")
        '
        'ItemDownQuestion
        '
        Me.ItemDownQuestion.Name = "ItemDownQuestion"
        resources.ApplyResources(Me.ItemDownQuestion, "ItemDownQuestion")
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'ItemArchiveQuestion
        '
        Me.ItemArchiveQuestion.Name = "ItemArchiveQuestion"
        resources.ApplyResources(Me.ItemArchiveQuestion, "ItemArchiveQuestion")
        '
        'ItemRestaureQuestion
        '
        Me.ItemRestaureQuestion.Name = "ItemRestaureQuestion"
        resources.ApplyResources(Me.ItemRestaureQuestion, "ItemRestaureQuestion")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'ItemAnnuleQuestion
        '
        Me.ItemAnnuleQuestion.Name = "ItemAnnuleQuestion"
        resources.ApplyResources(Me.ItemAnnuleQuestion, "ItemAnnuleQuestion")
        '
        'GrpBxReponses
        '
        Me.GrpBxReponses.Controls.Add(Me.GrpReponseLibre)
        Me.GrpBxReponses.Controls.Add(Me.BtnModif)
        Me.GrpBxReponses.Controls.Add(Me.BtnSaveRep)
        Me.GrpBxReponses.Controls.Add(Me.btnRestoreRep)
        Me.GrpBxReponses.Controls.Add(Me.BtnArchRep)
        Me.GrpBxReponses.Controls.Add(Me.BtnAjoutRep)
        Me.GrpBxReponses.Controls.Add(Me.DGVReponse)
        Me.GrpBxReponses.Controls.Add(Me.ChkListRepArchives)
        resources.ApplyResources(Me.GrpBxReponses, "GrpBxReponses")
        Me.GrpBxReponses.Name = "GrpBxReponses"
        Me.GrpBxReponses.TabStop = False
        '
        'GrpReponseLibre
        '
        Me.GrpReponseLibre.Controls.Add(Me.ChkRemarque)
        resources.ApplyResources(Me.GrpReponseLibre, "GrpReponseLibre")
        Me.GrpReponseLibre.Name = "GrpReponseLibre"
        Me.GrpReponseLibre.TabStop = False
        '
        'ChkRemarque
        '
        resources.ApplyResources(Me.ChkRemarque, "ChkRemarque")
        Me.ChkRemarque.Name = "ChkRemarque"
        Me.ChkRemarque.UseVisualStyleBackColor = True
        '
        'BtnModif
        '
        resources.ApplyResources(Me.BtnModif, "BtnModif")
        Me.BtnModif.Name = "BtnModif"
        Me.BtnModif.UseVisualStyleBackColor = True
        '
        'BtnSaveRep
        '
        resources.ApplyResources(Me.BtnSaveRep, "BtnSaveRep")
        Me.BtnSaveRep.Name = "BtnSaveRep"
        Me.BtnSaveRep.UseVisualStyleBackColor = True
        '
        'btnRestoreRep
        '
        resources.ApplyResources(Me.btnRestoreRep, "btnRestoreRep")
        Me.btnRestoreRep.Name = "btnRestoreRep"
        Me.btnRestoreRep.UseVisualStyleBackColor = True
        '
        'BtnArchRep
        '
        resources.ApplyResources(Me.BtnArchRep, "BtnArchRep")
        Me.BtnArchRep.Name = "BtnArchRep"
        Me.BtnArchRep.UseVisualStyleBackColor = True
        '
        'BtnAjoutRep
        '
        resources.ApplyResources(Me.BtnAjoutRep, "BtnAjoutRep")
        Me.BtnAjoutRep.Name = "BtnAjoutRep"
        Me.BtnAjoutRep.UseVisualStyleBackColor = True
        '
        'DGVReponse
        '
        Me.DGVReponse.AllowUserToAddRows = False
        Me.DGVReponse.AllowUserToDeleteRows = False
        Me.DGVReponse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVReponse.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColIDRep, Me.NIDQCMREPONSE, Me.NQCMREPONSEORDER, Me.VQCMREPONSELIB, Me.BQCMREPONSEVALID, Me.BQCMREPONSEACTIF, Me.VQCMREPONSEOBSCORRECT})
        Me.DGVReponse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        resources.ApplyResources(Me.DGVReponse, "DGVReponse")
        Me.DGVReponse.MultiSelect = False
        Me.DGVReponse.Name = "DGVReponse"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVReponse.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVReponse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'ColIDRep
        '
        Me.ColIDRep.DataPropertyName = "ID"
        resources.ApplyResources(Me.ColIDRep, "ColIDRep")
        Me.ColIDRep.Name = "ColIDRep"
        '
        'NIDQCMREPONSE
        '
        Me.NIDQCMREPONSE.DataPropertyName = "NIDQCMREPONSE"
        resources.ApplyResources(Me.NIDQCMREPONSE, "NIDQCMREPONSE")
        Me.NIDQCMREPONSE.Name = "NIDQCMREPONSE"
        '
        'NQCMREPONSEORDER
        '
        Me.NQCMREPONSEORDER.DataPropertyName = "NQCMREPONSEORDER"
        resources.ApplyResources(Me.NQCMREPONSEORDER, "NQCMREPONSEORDER")
        Me.NQCMREPONSEORDER.Name = "NQCMREPONSEORDER"
        '
        'VQCMREPONSELIB
        '
        Me.VQCMREPONSELIB.DataPropertyName = "VQCMREPONSELIB"
        resources.ApplyResources(Me.VQCMREPONSELIB, "VQCMREPONSELIB")
        Me.VQCMREPONSELIB.Name = "VQCMREPONSELIB"
        '
        'BQCMREPONSEVALID
        '
        Me.BQCMREPONSEVALID.DataPropertyName = "BQCMREPONSEVALID"
        resources.ApplyResources(Me.BQCMREPONSEVALID, "BQCMREPONSEVALID")
        Me.BQCMREPONSEVALID.Name = "BQCMREPONSEVALID"
        Me.BQCMREPONSEVALID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BQCMREPONSEVALID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'BQCMREPONSEACTIF
        '
        Me.BQCMREPONSEACTIF.DataPropertyName = "BQCMREPONSEACTIF"
        resources.ApplyResources(Me.BQCMREPONSEACTIF, "BQCMREPONSEACTIF")
        Me.BQCMREPONSEACTIF.Name = "BQCMREPONSEACTIF"
        '
        'VQCMREPONSEOBSCORRECT
        '
        Me.VQCMREPONSEOBSCORRECT.DataPropertyName = "VQCMREPONSEOBSCORRECT"
        resources.ApplyResources(Me.VQCMREPONSEOBSCORRECT, "VQCMREPONSEOBSCORRECT")
        Me.VQCMREPONSEOBSCORRECT.Name = "VQCMREPONSEOBSCORRECT"
        '
        'ChkListRepArchives
        '
        Me.ChkListRepArchives.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.ChkListRepArchives, "ChkListRepArchives")
        Me.ChkListRepArchives.Name = "ChkListRepArchives"
        Me.ChkListRepArchives.UseVisualStyleBackColor = False
        '
        'GrpBoxQuestion
        '
        Me.GrpBoxQuestion.Controls.Add(Me.BtnAddImage)
        Me.GrpBoxQuestion.Controls.Add(Me.BtnVideo)
        Me.GrpBoxQuestion.Controls.Add(Me.BtnConsigne)
        Me.GrpBoxQuestion.Controls.Add(Me.ChkQCMCorrectAuto)
        Me.GrpBoxQuestion.Controls.Add(Me.Label1)
        Me.GrpBoxQuestion.Controls.Add(Me.CboTypeQCM)
        Me.GrpBoxQuestion.Controls.Add(Me.GrpDetailQCM)
        Me.GrpBoxQuestion.Controls.Add(Me.BtnFermer)
        Me.GrpBoxQuestion.Controls.Add(Me.LblNomQCM)
        Me.GrpBoxQuestion.Controls.Add(Me.BtnSaveQuestion)
        Me.GrpBoxQuestion.Controls.Add(Me.ChkListQuestArchives)
        Me.GrpBoxQuestion.Controls.Add(Me.treeList1)
        Me.GrpBoxQuestion.Controls.Add(Me.BtnArchiveQuestion)
        Me.GrpBoxQuestion.Controls.Add(Me.BtnRestaureQuestion)
        Me.GrpBoxQuestion.Controls.Add(Me.BtnNewQuestion)
        resources.ApplyResources(Me.GrpBoxQuestion, "GrpBoxQuestion")
        Me.GrpBoxQuestion.Name = "GrpBoxQuestion"
        Me.GrpBoxQuestion.TabStop = False
        '
        'BtnAddImage
        '
        resources.ApplyResources(Me.BtnAddImage, "BtnAddImage")
        Me.BtnAddImage.Name = "BtnAddImage"
        Me.BtnAddImage.UseVisualStyleBackColor = True
        '
        'BtnVideo
        '
        resources.ApplyResources(Me.BtnVideo, "BtnVideo")
        Me.BtnVideo.Name = "BtnVideo"
        Me.BtnVideo.UseVisualStyleBackColor = True
        '
        'BtnConsigne
        '
        resources.ApplyResources(Me.BtnConsigne, "BtnConsigne")
        Me.BtnConsigne.Name = "BtnConsigne"
        Me.BtnConsigne.UseVisualStyleBackColor = True
        '
        'ChkQCMCorrectAuto
        '
        Me.ChkQCMCorrectAuto.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.ChkQCMCorrectAuto, "ChkQCMCorrectAuto")
        Me.ChkQCMCorrectAuto.Name = "ChkQCMCorrectAuto"
        Me.ChkQCMCorrectAuto.UseVisualStyleBackColor = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'CboTypeQCM
        '
        Me.CboTypeQCM.DisplayMember = "VQCMTYPELIB"
        Me.CboTypeQCM.FormattingEnabled = True
        resources.ApplyResources(Me.CboTypeQCM, "CboTypeQCM")
        Me.CboTypeQCM.Name = "CboTypeQCM"
        Me.CboTypeQCM.ValueMember = "NQCMTYPEID"
        '
        'GrpDetailQCM
        '
        Me.GrpDetailQCM.Controls.Add(Me.ChkBoxQCMRecru)
        resources.ApplyResources(Me.GrpDetailQCM, "GrpDetailQCM")
        Me.GrpDetailQCM.Name = "GrpDetailQCM"
        Me.GrpDetailQCM.TabStop = False
        '
        'ChkBoxQCMRecru
        '
        resources.ApplyResources(Me.ChkBoxQCMRecru, "ChkBoxQCMRecru")
        Me.ChkBoxQCMRecru.Name = "ChkBoxQCMRecru"
        Me.ChkBoxQCMRecru.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.ToolTipTreeList.SetToolTip(Me.BtnFermer, resources.GetString("BtnFermer.ToolTip"))
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'LblNomQCM
        '
        resources.ApplyResources(Me.LblNomQCM, "LblNomQCM")
        Me.LblNomQCM.Name = "LblNomQCM"
        '
        'BtnSaveQuestion
        '
        resources.ApplyResources(Me.BtnSaveQuestion, "BtnSaveQuestion")
        Me.BtnSaveQuestion.Name = "BtnSaveQuestion"
        Me.BtnSaveQuestion.UseVisualStyleBackColor = True
        '
        'ChkListQuestArchives
        '
        Me.ChkListQuestArchives.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.ChkListQuestArchives, "ChkListQuestArchives")
        Me.ChkListQuestArchives.Name = "ChkListQuestArchives"
        Me.ChkListQuestArchives.UseVisualStyleBackColor = False
        '
        'treeList1
        '
        Me.treeList1.AllowDrop = True
        Me.treeList1.Appearance.Empty.BackColor = System.Drawing.Color.Ivory
        Me.treeList1.Appearance.Empty.ForeColor = System.Drawing.Color.White
        Me.treeList1.Appearance.Empty.Options.UseBackColor = True
        Me.treeList1.Appearance.Empty.Options.UseForeColor = True
        Me.treeList1.Appearance.EvenRow.BackColor = System.Drawing.Color.OldLace
        Me.treeList1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.treeList1.Appearance.EvenRow.Options.UseBackColor = True
        Me.treeList1.Appearance.EvenRow.Options.UseForeColor = True
        Me.treeList1.Appearance.FocusedRow.Font = CType(resources.GetObject("treeList1.Appearance.FocusedRow.Font"), System.Drawing.Font)
        Me.treeList1.Appearance.FocusedRow.Options.UseFont = True
        Me.treeList1.Appearance.FooterPanel.BackColor = System.Drawing.Color.NavajoWhite
        Me.treeList1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.NavajoWhite
        Me.treeList1.Appearance.FooterPanel.Font = CType(resources.GetObject("treeList1.Appearance.FooterPanel.Font"), System.Drawing.Font)
        Me.treeList1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.treeList1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.treeList1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.treeList1.Appearance.FooterPanel.Options.UseFont = True
        Me.treeList1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.treeList1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.treeList1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.treeList1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.treeList1.Appearance.GroupButton.Options.UseBackColor = True
        Me.treeList1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.treeList1.Appearance.GroupButton.Options.UseForeColor = True
        Me.treeList1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.treeList1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.treeList1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.treeList1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.treeList1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.treeList1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.treeList1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.BurlyWood
        Me.treeList1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.BurlyWood
        Me.treeList1.Appearance.HeaderPanel.Font = CType(resources.GetObject("treeList1.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.treeList1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.treeList1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.treeList1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.treeList1.Appearance.HeaderPanel.Options.UseFont = True
        Me.treeList1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.treeList1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.treeList1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.treeList1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.treeList1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.treeList1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.treeList1.Appearance.HorzLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.treeList1.Appearance.HorzLine.Options.UseBackColor = True
        Me.treeList1.Appearance.HorzLine.Options.UseForeColor = True
        Me.treeList1.Appearance.OddRow.BackColor = System.Drawing.Color.Bisque
        Me.treeList1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.treeList1.Appearance.OddRow.Options.UseBackColor = True
        Me.treeList1.Appearance.OddRow.Options.UseForeColor = True
        Me.treeList1.Appearance.Preview.BackColor = System.Drawing.Color.Cornsilk
        Me.treeList1.Appearance.Preview.ForeColor = System.Drawing.Color.Blue
        Me.treeList1.Appearance.Preview.Options.UseBackColor = True
        Me.treeList1.Appearance.Preview.Options.UseForeColor = True
        Me.treeList1.Appearance.Preview.Options.UseTextOptions = True
        Me.treeList1.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.treeList1.Appearance.Row.BackColor = System.Drawing.Color.Ivory
        Me.treeList1.Appearance.Row.ForeColor = System.Drawing.Color.MidnightBlue
        Me.treeList1.Appearance.Row.Options.UseBackColor = True
        Me.treeList1.Appearance.Row.Options.UseForeColor = True
        Me.treeList1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.treeList1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.treeList1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.treeList1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.treeList1.Appearance.TreeLine.ForeColor = System.Drawing.Color.Gray
        Me.treeList1.Appearance.TreeLine.Options.UseForeColor = True
        Me.treeList1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.treeList1.Appearance.VertLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.treeList1.Appearance.VertLine.Options.UseBackColor = True
        Me.treeList1.Appearance.VertLine.Options.UseForeColor = True
        Me.treeList1.Appearance.VertLine.Options.UseTextOptions = True
        Me.treeList1.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TLColQCM, Me.TLColNIDCQMQUESTION, Me.TLColNQCMQUESTIONORDER, Me.TLColVQUESTIONLIB, Me.TLCol_NBIMG, Me.TLColActif, Me.TLColID, Me.TLColBQCMQUESTIONREM})
        Me.treeList1.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.treeList1, "treeList1")
        Me.treeList1.Name = "treeList1"
        Me.treeList1.OptionsBehavior.AutoChangeParent = False
        Me.treeList1.OptionsBehavior.AutoNodeHeight = False
        Me.treeList1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.treeList1.OptionsBehavior.CloseEditorOnLostFocus = False
        Me.treeList1.OptionsBehavior.Editable = False
        Me.treeList1.OptionsBehavior.ResizeNodes = False
        Me.treeList1.OptionsBehavior.SmartMouseHover = False
        Me.treeList1.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.[Single]
        Me.treeList1.OptionsMenu.EnableFooterMenu = False
        Me.treeList1.OptionsPrint.PrintHorzLines = False
        Me.treeList1.OptionsPrint.PrintVertLines = False
        Me.treeList1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.treeList1.OptionsSelection.KeepSelectedOnClick = False
        Me.treeList1.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None
        Me.treeList1.OptionsView.ShowHorzLines = False
        Me.treeList1.OptionsView.ShowIndicator = False
        Me.treeList1.OptionsView.ShowVertLines = False
        Me.treeList1.SelectImageList = Me.ImageList1
        '
        'TLColQCM
        '
        Me.TLColQCM.AppearanceCell.Options.UseTextOptions = True
        Me.TLColQCM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        resources.ApplyResources(Me.TLColQCM, "TLColQCM")
        Me.TLColQCM.FieldName = "VQCMTITRE"
        Me.TLColQCM.ImageOptions.Alignment = CType(resources.GetObject("TLColQCM.ImageOptions.Alignment"), System.Drawing.StringAlignment)
        Me.TLColQCM.Name = "TLColQCM"
        Me.TLColQCM.OptionsColumn.FixedWidth = True
        Me.TLColQCM.OptionsColumn.ReadOnly = True
        '
        'TLColNIDCQMQUESTION
        '
        resources.ApplyResources(Me.TLColNIDCQMQUESTION, "TLColNIDCQMQUESTION")
        Me.TLColNIDCQMQUESTION.FieldName = "NIDQCMQUESTION"
        Me.TLColNIDCQMQUESTION.Name = "TLColNIDCQMQUESTION"
        '
        'TLColNQCMQUESTIONORDER
        '
        Me.TLColNQCMQUESTIONORDER.AppearanceCell.Options.UseTextOptions = True
        Me.TLColNQCMQUESTIONORDER.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        resources.ApplyResources(Me.TLColNQCMQUESTIONORDER, "TLColNQCMQUESTIONORDER")
        Me.TLColNQCMQUESTIONORDER.FieldName = "NQCMQUESTIONORDER"
        Me.TLColNQCMQUESTIONORDER.Name = "TLColNQCMQUESTIONORDER"
        Me.TLColNQCMQUESTIONORDER.OptionsColumn.FixedWidth = True
        '
        'TLColVQUESTIONLIB
        '
        Me.TLColVQUESTIONLIB.AppearanceCell.Options.UseTextOptions = True
        Me.TLColVQUESTIONLIB.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.TLColVQUESTIONLIB, "TLColVQUESTIONLIB")
        Me.TLColVQUESTIONLIB.FieldName = "VQCMQUESTIONLIB"
        Me.TLColVQUESTIONLIB.Name = "TLColVQUESTIONLIB"
        Me.TLColVQUESTIONLIB.OptionsColumn.FixedWidth = True
        '
        'TLCol_NBIMG
        '
        resources.ApplyResources(Me.TLCol_NBIMG, "TLCol_NBIMG")
        Me.TLCol_NBIMG.FieldName = "NIMG_NB"
        Me.TLCol_NBIMG.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TLCol_NBIMG.Name = "TLCol_NBIMG"
        Me.TLCol_NBIMG.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.[Integer]
        '
        'TLColActif
        '
        resources.ApplyResources(Me.TLColActif, "TLColActif")
        Me.TLColActif.FieldName = "BQCMQUESTIONACTIF"
        Me.TLColActif.Name = "TLColActif"
        '
        'TLColID
        '
        resources.ApplyResources(Me.TLColID, "TLColID")
        Me.TLColID.FieldName = "ID"
        Me.TLColID.Name = "TLColID"
        Me.TLColID.OptionsColumn.AllowEdit = False
        '
        'TLColBQCMQUESTIONREM
        '
        resources.ApplyResources(Me.TLColBQCMQUESTIONREM, "TLColBQCMQUESTIONREM")
        Me.TLColBQCMQUESTIONREM.FieldName = "BQCMQUESTIONREM"
        Me.TLColBQCMQUESTIONREM.Name = "TLColBQCMQUESTIONREM"
        '
        'BtnArchiveQuestion
        '
        resources.ApplyResources(Me.BtnArchiveQuestion, "BtnArchiveQuestion")
        Me.BtnArchiveQuestion.Name = "BtnArchiveQuestion"
        Me.BtnArchiveQuestion.UseVisualStyleBackColor = True
        '
        'BtnRestaureQuestion
        '
        resources.ApplyResources(Me.BtnRestaureQuestion, "BtnRestaureQuestion")
        Me.BtnRestaureQuestion.Name = "BtnRestaureQuestion"
        Me.BtnRestaureQuestion.UseVisualStyleBackColor = True
        '
        'BtnNewQuestion
        '
        resources.ApplyResources(Me.BtnNewQuestion, "BtnNewQuestion")
        Me.BtnNewQuestion.Name = "BtnNewQuestion"
        Me.BtnNewQuestion.UseVisualStyleBackColor = True
        '
        'ToolTipTreeList
        '
        Me.ToolTipTreeList.AutoPopDelay = 2000
        Me.ToolTipTreeList.InitialDelay = 1000
        Me.ToolTipTreeList.ReshowDelay = 1000
        '
        'frmQCMDetail
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpBoxQuestion)
        Me.Controls.Add(Me.GrpBxReponses)
        Me.Name = "frmQCMDetail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuQCM.ResumeLayout(False)
        Me.MenuQuestion.ResumeLayout(False)
        Me.GrpBxReponses.ResumeLayout(False)
        Me.GrpReponseLibre.ResumeLayout(False)
        CType(Me.DGVReponse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxQuestion.ResumeLayout(False)
        Me.GrpDetailQCM.ResumeLayout(False)
        CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
  Friend WithEvents MenuQCM As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents ItemNewQuestionQCM As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ItemAnnuleQCM As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuQuestion As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents ItemUpQuestion As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ItemDownQuestion As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ItemAnnuleQuestion As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ItemAjoutQuestion As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ItemArchiveQuestion As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ItemAfficheQuestArchi As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ALaFinDuQuestionnaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AuDébutDuQuestionnaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AuDébutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ÀLaLigneDuDessusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ÀLaLigneEnDessousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ÀLaFinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ItemRestaureQuestion As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents GrpBxReponses As System.Windows.Forms.GroupBox
  Friend WithEvents DGVReponse As System.Windows.Forms.DataGridView
  Friend WithEvents BtnArchRep As System.Windows.Forms.Button
  Friend WithEvents BtnAjoutRep As System.Windows.Forms.Button
  Friend WithEvents ChkListRepArchives As System.Windows.Forms.CheckBox
  Friend WithEvents btnRestoreRep As System.Windows.Forms.Button
  Friend WithEvents BtnSaveRep As System.Windows.Forms.Button
  Friend WithEvents BtnModif As System.Windows.Forms.Button
  Friend WithEvents GrpBoxQuestion As System.Windows.Forms.GroupBox
  Friend WithEvents BtnSaveQuestion As System.Windows.Forms.Button
  Friend WithEvents ChkListQuestArchives As System.Windows.Forms.CheckBox
  Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
  Friend WithEvents BtnArchiveQuestion As System.Windows.Forms.Button
  Friend WithEvents BtnRestaureQuestion As System.Windows.Forms.Button
  Friend WithEvents BtnNewQuestion As System.Windows.Forms.Button
  Friend WithEvents LblNomQCM As System.Windows.Forms.Label
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents ToolTipTreeList As System.Windows.Forms.ToolTip
  Friend WithEvents GrpReponseLibre As System.Windows.Forms.GroupBox
  Friend WithEvents ChkRemarque As System.Windows.Forms.CheckBox
  Friend WithEvents GrpDetailQCM As System.Windows.Forms.GroupBox
  Friend WithEvents ChkBoxQCMRecru As System.Windows.Forms.CheckBox
  Private WithEvents TLColQCM As DevExpress.XtraTreeList.Columns.TreeListColumn
  Private WithEvents TLColNIDCQMQUESTION As DevExpress.XtraTreeList.Columns.TreeListColumn
  Private WithEvents TLColNQCMQUESTIONORDER As DevExpress.XtraTreeList.Columns.TreeListColumn
  Private WithEvents TLColVQUESTIONLIB As DevExpress.XtraTreeList.Columns.TreeListColumn
  Private WithEvents TLColActif As DevExpress.XtraTreeList.Columns.TreeListColumn
  Private WithEvents TLColID As DevExpress.XtraTreeList.Columns.TreeListColumn
  Private WithEvents TLColBQCMQUESTIONREM As DevExpress.XtraTreeList.Columns.TreeListColumn
  Friend WithEvents Label1 As Label
  Friend WithEvents CboTypeQCM As ComboBox
  Friend WithEvents ColIDRep As DataGridViewTextBoxColumn
  Friend WithEvents NIDQCMREPONSE As DataGridViewTextBoxColumn
  Friend WithEvents NQCMREPONSEORDER As DataGridViewTextBoxColumn
  Friend WithEvents VQCMREPONSELIB As DataGridViewTextBoxColumn
  Friend WithEvents BQCMREPONSEVALID As DataGridViewCheckBoxColumn
  Friend WithEvents BQCMREPONSEACTIF As DataGridViewTextBoxColumn
  Friend WithEvents VQCMREPONSEOBSCORRECT As DataGridViewTextBoxColumn
  Friend WithEvents ChkQCMCorrectAuto As CheckBox
  Friend WithEvents BtnConsigne As Button
  Friend WithEvents BtnVideo As Button
    Friend WithEvents BtnAddImage As Button
    Friend WithEvents TLCol_NBIMG As DevExpress.XtraTreeList.Columns.TreeListColumn
End Class
