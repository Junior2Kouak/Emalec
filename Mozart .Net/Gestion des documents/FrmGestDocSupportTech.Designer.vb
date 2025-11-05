<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestDocSupportTech
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
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnListeArchives = New System.Windows.Forms.Button()
        Me.BtnArchiver = New System.Windows.Forms.Button()
        Me.BtnVisualiser = New System.Windows.Forms.Button()
        Me.BtnMod = New System.Windows.Forms.Button()
        Me.BtnAddLine = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.ColUNITEVGTPUNITENOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLOTIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLUpEditViewUnite = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColUNITEIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUNITENGTPUNITEID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepIGLUpEditViewLot = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColLOTNGTPLOTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLOTVGTPLOTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLUpEditGTPLot = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GVGESTDOC = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColTITRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDDATEPUB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCGESTDOC = New DevExpress.XtraGrid.GridControl()
        Me.RepItemGLUpEditUnite = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVGESTDOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCGESTDOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnListeArchives)
        Me.GrpActions.Controls.Add(Me.BtnArchiver)
        Me.GrpActions.Controls.Add(Me.BtnVisualiser)
        Me.GrpActions.Controls.Add(Me.BtnMod)
        Me.GrpActions.Controls.Add(Me.BtnAddLine)
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Location = New System.Drawing.Point(3, 9)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(123, 744)
        Me.GrpActions.TabIndex = 9
        Me.GrpActions.TabStop = False
        '
        'BtnListeArchives
        '
        Me.BtnListeArchives.BackColor = System.Drawing.Color.LightGreen
        Me.BtnListeArchives.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnListeArchives.Location = New System.Drawing.Point(6, 310)
        Me.BtnListeArchives.Name = "BtnListeArchives"
        Me.BtnListeArchives.Size = New System.Drawing.Size(108, 44)
        Me.BtnListeArchives.TabIndex = 9
        Me.BtnListeArchives.Text = "Liste des archives"
        Me.BtnListeArchives.UseVisualStyleBackColor = False
        '
        'BtnArchiver
        '
        Me.BtnArchiver.BackColor = System.Drawing.Color.LightGreen
        Me.BtnArchiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArchiver.Location = New System.Drawing.Point(6, 183)
        Me.BtnArchiver.Name = "BtnArchiver"
        Me.BtnArchiver.Size = New System.Drawing.Size(108, 44)
        Me.BtnArchiver.TabIndex = 8
        Me.BtnArchiver.Text = "Archiver"
        Me.BtnArchiver.UseVisualStyleBackColor = False
        '
        'BtnVisualiser
        '
        Me.BtnVisualiser.BackColor = System.Drawing.Color.LightGreen
        Me.BtnVisualiser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVisualiser.Location = New System.Drawing.Point(6, 133)
        Me.BtnVisualiser.Name = "BtnVisualiser"
        Me.BtnVisualiser.Size = New System.Drawing.Size(108, 44)
        Me.BtnVisualiser.TabIndex = 7
        Me.BtnVisualiser.Text = "Visualiser"
        Me.BtnVisualiser.UseVisualStyleBackColor = False
        '
        'BtnMod
        '
        Me.BtnMod.BackColor = System.Drawing.Color.LightGreen
        Me.BtnMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMod.Location = New System.Drawing.Point(6, 83)
        Me.BtnMod.Name = "BtnMod"
        Me.BtnMod.Size = New System.Drawing.Size(108, 44)
        Me.BtnMod.TabIndex = 6
        Me.BtnMod.Text = "Modifier"
        Me.BtnMod.UseVisualStyleBackColor = False
        '
        'BtnAddLine
        '
        Me.BtnAddLine.BackColor = System.Drawing.Color.LightGreen
        Me.BtnAddLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddLine.Location = New System.Drawing.Point(6, 33)
        Me.BtnAddLine.Name = "BtnAddLine"
        Me.BtnAddLine.Size = New System.Drawing.Size(108, 44)
        Me.BtnAddLine.TabIndex = 2
        Me.BtnAddLine.Text = "Ajouter"
        Me.BtnAddLine.UseVisualStyleBackColor = False
        '
        'BtnQuit
        '
        Me.BtnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuit.Location = New System.Drawing.Point(6, 682)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(108, 45)
        Me.BtnQuit.TabIndex = 1
        Me.BtnQuit.Text = "Fermer"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'ColUNITEVGTPUNITENOM
        '
        Me.ColUNITEVGTPUNITENOM.Caption = "Unité de mesure"
        Me.ColUNITEVGTPUNITENOM.FieldName = "VGTPUNITENOM"
        Me.ColUNITEVGTPUNITENOM.Name = "ColUNITEVGTPUNITENOM"
        Me.ColUNITEVGTPUNITENOM.Visible = True
        Me.ColUNITEVGTPUNITENOM.VisibleIndex = 0
        '
        'ColLOTIDTMP
        '
        Me.ColLOTIDTMP.Caption = "IDTMP"
        Me.ColLOTIDTMP.FieldName = "IDTMP"
        Me.ColLOTIDTMP.Name = "ColLOTIDTMP"
        '
        'RepItemGLUpEditViewUnite
        '
        Me.RepItemGLUpEditViewUnite.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColUNITEIDTMP, Me.ColUNITENGTPUNITEID, Me.ColUNITEVGTPUNITENOM})
        Me.RepItemGLUpEditViewUnite.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepItemGLUpEditViewUnite.Name = "RepItemGLUpEditViewUnite"
        Me.RepItemGLUpEditViewUnite.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepItemGLUpEditViewUnite.OptionsView.ShowGroupPanel = False
        '
        'ColUNITEIDTMP
        '
        Me.ColUNITEIDTMP.Caption = "IDTMP"
        Me.ColUNITEIDTMP.FieldName = "IDTMP"
        Me.ColUNITEIDTMP.Name = "ColUNITEIDTMP"
        '
        'ColUNITENGTPUNITEID
        '
        Me.ColUNITENGTPUNITEID.Caption = "NGTPUNITEID"
        Me.ColUNITENGTPUNITEID.FieldName = "NGTPUNITEID"
        Me.ColUNITENGTPUNITEID.Name = "ColUNITENGTPUNITEID"
        '
        'RepIGLUpEditViewLot
        '
        Me.RepIGLUpEditViewLot.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColLOTIDTMP, Me.ColLOTNGTPLOTID, Me.ColLOTVGTPLOTNOM})
        Me.RepIGLUpEditViewLot.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepIGLUpEditViewLot.Name = "RepIGLUpEditViewLot"
        Me.RepIGLUpEditViewLot.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepIGLUpEditViewLot.OptionsView.ShowGroupPanel = False
        '
        'ColLOTNGTPLOTID
        '
        Me.ColLOTNGTPLOTID.Caption = "NGTPLOTID"
        Me.ColLOTNGTPLOTID.FieldName = "NGTPLOTID"
        Me.ColLOTNGTPLOTID.Name = "ColLOTNGTPLOTID"
        '
        'ColLOTVGTPLOTNOM
        '
        Me.ColLOTVGTPLOTNOM.Caption = "Nom du Lot"
        Me.ColLOTVGTPLOTNOM.FieldName = "VGTPLOTNOM"
        Me.ColLOTVGTPLOTNOM.Name = "ColLOTVGTPLOTNOM"
        Me.ColLOTVGTPLOTNOM.Visible = True
        Me.ColLOTVGTPLOTNOM.VisibleIndex = 0
        '
        'RepItemGLUpEditGTPLot
        '
        Me.RepItemGLUpEditGTPLot.AutoHeight = False
        Me.RepItemGLUpEditGTPLot.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepItemGLUpEditGTPLot.DisplayMember = "VGTPLOTNOM"
        Me.RepItemGLUpEditGTPLot.Name = "RepItemGLUpEditGTPLot"
        Me.RepItemGLUpEditGTPLot.NullText = ""
        Me.RepItemGLUpEditGTPLot.ValueMember = "NGTPLOTID"
        Me.RepItemGLUpEditGTPLot.View = Me.RepIGLUpEditViewLot
        '
        'GVGESTDOC
        '
        Me.GVGESTDOC.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVGESTDOC.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVGESTDOC.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVGESTDOC.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVGESTDOC.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVGESTDOC.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVGESTDOC.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVGESTDOC.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVGESTDOC.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVGESTDOC.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVGESTDOC.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVGESTDOC.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVGESTDOC.Appearance.Empty.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVGESTDOC.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVGESTDOC.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVGESTDOC.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVGESTDOC.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVGESTDOC.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVGESTDOC.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVGESTDOC.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVGESTDOC.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVGESTDOC.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVGESTDOC.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVGESTDOC.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVGESTDOC.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVGESTDOC.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVGESTDOC.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GVGESTDOC.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVGESTDOC.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVGESTDOC.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVGESTDOC.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.GVGESTDOC.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVGESTDOC.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVGESTDOC.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVGESTDOC.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVGESTDOC.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVGESTDOC.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVGESTDOC.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVGESTDOC.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVGESTDOC.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVGESTDOC.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVGESTDOC.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVGESTDOC.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVGESTDOC.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVGESTDOC.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVGESTDOC.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVGESTDOC.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVGESTDOC.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVGESTDOC.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.GVGESTDOC.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVGESTDOC.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVGESTDOC.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVGESTDOC.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVGESTDOC.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVGESTDOC.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVGESTDOC.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVGESTDOC.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVGESTDOC.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVGESTDOC.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVGESTDOC.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GVGESTDOC.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVGESTDOC.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVGESTDOC.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVGESTDOC.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVGESTDOC.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVGESTDOC.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVGESTDOC.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVGESTDOC.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVGESTDOC.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVGESTDOC.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVGESTDOC.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVGESTDOC.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVGESTDOC.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVGESTDOC.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVGESTDOC.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVGESTDOC.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVGESTDOC.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVGESTDOC.Appearance.OddRow.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVGESTDOC.Appearance.OddRow.Options.UseForeColor = True
        Me.GVGESTDOC.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVGESTDOC.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVGESTDOC.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GVGESTDOC.Appearance.Preview.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.Preview.Options.UseFont = True
        Me.GVGESTDOC.Appearance.Preview.Options.UseForeColor = True
        Me.GVGESTDOC.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVGESTDOC.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVGESTDOC.Appearance.Row.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.Row.Options.UseForeColor = True
        Me.GVGESTDOC.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVGESTDOC.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVGESTDOC.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVGESTDOC.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVGESTDOC.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVGESTDOC.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GVGESTDOC.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVGESTDOC.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVGESTDOC.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVGESTDOC.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVGESTDOC.Appearance.VertLine.Options.UseBackColor = True
        Me.GVGESTDOC.ColumnPanelRowHeight = 50
        Me.GVGESTDOC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColID, Me.GColTITRE, Me.GColDDATEPUB})
        Me.GVGESTDOC.GridControl = Me.GCGESTDOC
        Me.GVGESTDOC.Name = "GVGESTDOC"
        Me.GVGESTDOC.OptionsBehavior.Editable = False
        Me.GVGESTDOC.OptionsBehavior.ReadOnly = True
        Me.GVGESTDOC.OptionsNavigation.AutoFocusNewRow = True
        Me.GVGESTDOC.OptionsView.EnableAppearanceOddRow = True
        Me.GVGESTDOC.OptionsView.ShowAutoFilterRow = True
        Me.GVGESTDOC.OptionsView.ShowFooter = True
        Me.GVGESTDOC.OptionsView.ShowGroupPanel = False
        Me.GVGESTDOC.RowHeight = 20
        '
        'GColID
        '
        Me.GColID.Caption = "ID"
        Me.GColID.FieldName = "ID"
        Me.GColID.Name = "GColID"
        '
        'GColTITRE
        '
        Me.GColTITRE.Caption = "Titre"
        Me.GColTITRE.FieldName = "TITRE"
        Me.GColTITRE.Name = "GColTITRE"
        Me.GColTITRE.Visible = True
        Me.GColTITRE.VisibleIndex = 0
        Me.GColTITRE.Width = 750
        '
        'GColDDATEPUB
        '
        Me.GColDDATEPUB.AppearanceCell.Options.UseTextOptions = True
        Me.GColDDATEPUB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDDATEPUB.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDDATEPUB.Caption = "Date publication"
        Me.GColDDATEPUB.FieldName = "DDATEPUB"
        Me.GColDDATEPUB.Name = "GColDDATEPUB"
        Me.GColDDATEPUB.Visible = True
        Me.GColDDATEPUB.VisibleIndex = 1
        Me.GColDDATEPUB.Width = 425
        '
        'GCGESTDOC
        '
        Me.GCGESTDOC.Location = New System.Drawing.Point(132, 42)
        Me.GCGESTDOC.MainView = Me.GVGESTDOC
        Me.GCGESTDOC.Name = "GCGESTDOC"
        Me.GCGESTDOC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemGLUpEditGTPLot, Me.RepItemGLUpEditUnite})
        Me.GCGESTDOC.Size = New System.Drawing.Size(1193, 711)
        Me.GCGESTDOC.TabIndex = 8
        Me.GCGESTDOC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVGESTDOC})
        '
        'RepItemGLUpEditUnite
        '
        Me.RepItemGLUpEditUnite.AutoHeight = False
        Me.RepItemGLUpEditUnite.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepItemGLUpEditUnite.DisplayMember = "VGTPUNITENOM"
        Me.RepItemGLUpEditUnite.Name = "RepItemGLUpEditUnite"
        Me.RepItemGLUpEditUnite.NullText = ""
        Me.RepItemGLUpEditUnite.ValueMember = "NGTPUNITEID"
        Me.RepItemGLUpEditUnite.View = Me.RepItemGLUpEditViewUnite
        '
        'LblTitre
        '
        Me.LblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitre.Location = New System.Drawing.Point(132, 9)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(993, 30)
        Me.LblTitre.TabIndex = 10
        Me.LblTitre.Text = "Support Formation (Web technicien) "
        '
        'FrmGestDocSupportTech
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1516, 906)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GCGESTDOC)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "FrmGestDocSupportTech"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Support Formation (Web technicien) "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVGESTDOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCGESTDOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnMod As System.Windows.Forms.Button
    Friend WithEvents BtnAddLine As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents ColUNITEVGTPUNITENOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLOTIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemGLUpEditViewUnite As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColUNITEIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUNITENGTPUNITEID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepIGLUpEditViewLot As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColLOTNGTPLOTID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLOTVGTPLOTNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemGLUpEditGTPLot As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GVGESTDOC As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCGESTDOC As DevExpress.XtraGrid.GridControl
    Friend WithEvents RepItemGLUpEditUnite As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents BtnListeArchives As System.Windows.Forms.Button
    Friend WithEvents BtnArchiver As System.Windows.Forms.Button
    Friend WithEvents BtnVisualiser As System.Windows.Forms.Button
    Friend WithEvents GColID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColTITRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColDDATEPUB As DevExpress.XtraGrid.Columns.GridColumn
End Class
