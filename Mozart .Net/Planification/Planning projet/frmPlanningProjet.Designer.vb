<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPlanningProjet
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.cmdPrev = New System.Windows.Forms.Button()
        Me.cmdSuiv = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.btnLegende = New MozartUC.apiButton()
        Me.frame1 = New MozartUC.apiGroupBox()
        Me.GCLegende = New DevExpress.XtraGrid.GridControl()
        Me.GVLegende = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_Legende_NCANNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_Legende_Color = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemColorEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit()
        Me.btnLegendeFermer = New MozartUC.apiButton()
        Me.chkPersBureau = New System.Windows.Forms.CheckBox()
        Me.chkPersTerrain = New System.Windows.Forms.CheckBox()
        Me.gridPlanning = New DevExpress.XtraGrid.GridControl()
        Me.bandedGridView = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.RepCboTeam = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.toolTipCtrl = New DevExpress.Utils.ToolTipController(Me.components)
        Me.BtnRefresh = New MozartUC.apiButton()
        Me.frame1.SuspendLayout()
        CType(Me.GCLegende, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVLegende, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPlanning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bandedGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepCboTeam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnFermer
        '
        Me.BtnFermer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(1082, 12)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(114, 39)
        Me.BtnFermer.TabIndex = 2
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'cmdPrev
        '
        Me.cmdPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdPrev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPrev.Location = New System.Drawing.Point(746, 12)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.Size = New System.Drawing.Size(65, 39)
        Me.cmdPrev.TabIndex = 4
        Me.cmdPrev.Text = "<=="
        Me.cmdPrev.UseVisualStyleBackColor = True
        '
        'cmdSuiv
        '
        Me.cmdSuiv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSuiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdSuiv.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSuiv.Location = New System.Drawing.Point(817, 12)
        Me.cmdSuiv.Name = "cmdSuiv"
        Me.cmdSuiv.Size = New System.Drawing.Size(65, 39)
        Me.cmdSuiv.TabIndex = 5
        Me.cmdSuiv.Text = "==>"
        Me.cmdSuiv.UseVisualStyleBackColor = True
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.Blue
        Me.lblTitre.Location = New System.Drawing.Point(12, 25)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(143, 20)
        Me.lblTitre.TabIndex = 6
        Me.lblTitre.Text = "Titre du planning"
        '
        'btnLegende
        '
        Me.btnLegende.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLegende.HelpContextID = 0
        Me.btnLegende.Location = New System.Drawing.Point(920, 12)
        Me.btnLegende.Name = "btnLegende"
        Me.btnLegende.Size = New System.Drawing.Size(129, 39)
        Me.btnLegende.TabIndex = 7
        Me.btnLegende.Text = "Légende"
        Me.btnLegende.UseVisualStyleBackColor = True
        '
        'frame1
        '
        Me.frame1.Controls.Add(Me.GCLegende)
        Me.frame1.Controls.Add(Me.btnLegendeFermer)
        Me.frame1.FrameColor = System.Drawing.Color.Empty
        Me.frame1.HelpContextID = 0
        Me.frame1.Location = New System.Drawing.Point(320, 138)
        Me.frame1.Name = "frame1"
        Me.frame1.Size = New System.Drawing.Size(473, 339)
        Me.frame1.TabIndex = 8
        Me.frame1.TabStop = False
        Me.frame1.Text = "Légende"
        Me.frame1.Visible = False
        '
        'GCLegende
        '
        Me.GCLegende.Location = New System.Drawing.Point(22, 28)
        Me.GCLegende.MainView = Me.GVLegende
        Me.GCLegende.Name = "GCLegende"
        Me.GCLegende.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemColorEdit1})
        Me.GCLegende.Size = New System.Drawing.Size(434, 248)
        Me.GCLegende.TabIndex = 1
        Me.GCLegende.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVLegende})
        '
        'GVLegende
        '
        Me.GVLegende.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_Legende_NCANNUM, Me.GCol_Legende_Color})
        Me.GVLegende.GridControl = Me.GCLegende
        Me.GVLegende.Name = "GVLegende"
        Me.GVLegende.OptionsView.ShowGroupPanel = False
        '
        'GCol_Legende_NCANNUM
        '
        Me.GCol_Legende_NCANNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_Legende_NCANNUM.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_Legende_NCANNUM.Caption = "Compte"
        Me.GCol_Legende_NCANNUM.FieldName = "NCANNUM"
        Me.GCol_Legende_NCANNUM.Name = "GCol_Legende_NCANNUM"
        Me.GCol_Legende_NCANNUM.OptionsColumn.AllowEdit = False
        Me.GCol_Legende_NCANNUM.OptionsColumn.ReadOnly = True
        Me.GCol_Legende_NCANNUM.Visible = True
        Me.GCol_Legende_NCANNUM.VisibleIndex = 0
        Me.GCol_Legende_NCANNUM.Width = 300
        '
        'GCol_Legende_Color
        '
        Me.GCol_Legende_Color.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_Legende_Color.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_Legende_Color.Caption = "Couleur"
        Me.GCol_Legende_Color.ColumnEdit = Me.RepositoryItemColorEdit1
        Me.GCol_Legende_Color.FieldName = "BackColor"
        Me.GCol_Legende_Color.Name = "GCol_Legende_Color"
        Me.GCol_Legende_Color.OptionsColumn.AllowEdit = False
        Me.GCol_Legende_Color.OptionsColumn.ReadOnly = True
        Me.GCol_Legende_Color.Visible = True
        Me.GCol_Legende_Color.VisibleIndex = 1
        Me.GCol_Legende_Color.Width = 116
        '
        'RepositoryItemColorEdit1
        '
        Me.RepositoryItemColorEdit1.AutoHeight = False
        Me.RepositoryItemColorEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemColorEdit1.Name = "RepositoryItemColorEdit1"
        '
        'btnLegendeFermer
        '
        Me.btnLegendeFermer.HelpContextID = 0
        Me.btnLegendeFermer.Location = New System.Drawing.Point(210, 298)
        Me.btnLegendeFermer.Name = "btnLegendeFermer"
        Me.btnLegendeFermer.Size = New System.Drawing.Size(78, 35)
        Me.btnLegendeFermer.TabIndex = 0
        Me.btnLegendeFermer.Text = "Fermer"
        Me.btnLegendeFermer.UseVisualStyleBackColor = True
        '
        'chkPersBureau
        '
        Me.chkPersBureau.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPersBureau.AutoSize = True
        Me.chkPersBureau.Checked = True
        Me.chkPersBureau.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPersBureau.Location = New System.Drawing.Point(462, 12)
        Me.chkPersBureau.Name = "chkPersBureau"
        Me.chkPersBureau.Size = New System.Drawing.Size(173, 17)
        Me.chkPersBureau.TabIndex = 9
        Me.chkPersBureau.Text = "Afficher le personnel de bureau"
        Me.chkPersBureau.UseVisualStyleBackColor = True
        '
        'chkPersTerrain
        '
        Me.chkPersTerrain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPersTerrain.AutoSize = True
        Me.chkPersTerrain.Checked = True
        Me.chkPersTerrain.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPersTerrain.Location = New System.Drawing.Point(462, 34)
        Me.chkPersTerrain.Name = "chkPersTerrain"
        Me.chkPersTerrain.Size = New System.Drawing.Size(169, 17)
        Me.chkPersTerrain.TabIndex = 10
        Me.chkPersTerrain.Text = "Afficher le personnel de terrain"
        Me.chkPersTerrain.UseVisualStyleBackColor = True
        '
        'gridPlanning
        '
        Me.gridPlanning.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridPlanning.Location = New System.Drawing.Point(1, 58)
        Me.gridPlanning.MainView = Me.bandedGridView
        Me.gridPlanning.Name = "gridPlanning"
        Me.gridPlanning.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepCboTeam})
        Me.gridPlanning.Size = New System.Drawing.Size(1204, 650)
        Me.gridPlanning.TabIndex = 11
        Me.gridPlanning.ToolTipController = Me.toolTipCtrl
        Me.gridPlanning.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.bandedGridView})
        '
        'bandedGridView
        '
        Me.bandedGridView.GridControl = Me.gridPlanning
        Me.bandedGridView.Name = "bandedGridView"
        Me.bandedGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.bandedGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.bandedGridView.OptionsCustomization.AllowBandMoving = False
        Me.bandedGridView.OptionsCustomization.AllowBandResizing = False
        Me.bandedGridView.OptionsCustomization.AllowColumnMoving = False
        Me.bandedGridView.OptionsCustomization.AllowColumnResizing = False
        Me.bandedGridView.OptionsPrint.AutoWidth = False
        Me.bandedGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.bandedGridView.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.bandedGridView.OptionsView.ColumnAutoWidth = False
        Me.bandedGridView.OptionsView.ShowGroupPanel = False
        Me.bandedGridView.OptionsView.ShowIndicator = False
        Me.bandedGridView.PaintStyleName = "MixedXP"
        '
        'RepCboTeam
        '
        Me.RepCboTeam.AutoHeight = False
        Me.RepCboTeam.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepCboTeam.Items.AddRange(New Object() {"", "A", "B", "C", "D", "E", "F", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.RepCboTeam.Name = "RepCboTeam"
        '
        'toolTipCtrl
        '
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRefresh.HelpContextID = 0
        Me.BtnRefresh.Location = New System.Drawing.Point(266, 12)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(129, 39)
        Me.BtnRefresh.TabIndex = 12
        Me.BtnRefresh.Text = "Rafraichir"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'frmPlanningProjet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnFermer
        Me.ClientSize = New System.Drawing.Size(1208, 709)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.frame1)
        Me.Controls.Add(Me.gridPlanning)
        Me.Controls.Add(Me.chkPersTerrain)
        Me.Controls.Add(Me.chkPersBureau)
        Me.Controls.Add(Me.btnLegende)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.cmdSuiv)
        Me.Controls.Add(Me.cmdPrev)
        Me.Controls.Add(Me.BtnFermer)
        Me.Name = "frmPlanningProjet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planning projet"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.frame1.ResumeLayout(False)
        CType(Me.GCLegende, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVLegende, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPlanning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bandedGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepCboTeam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnFermer As Button
    Friend WithEvents cmdPrev As Button
    Friend WithEvents cmdSuiv As Button
  Friend WithEvents lblTitre As Label
  Friend WithEvents btnLegende As MozartUC.apiButton
  Friend WithEvents frame1 As MozartUC.apiGroupBox
  Friend WithEvents btnLegendeFermer As MozartUC.apiButton
    Friend WithEvents chkPersBureau As CheckBox
    Friend WithEvents chkPersTerrain As CheckBox
  Friend WithEvents gridPlanning As DevExpress.XtraGrid.GridControl
  Friend WithEvents bandedGridView As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents toolTipCtrl As DevExpress.Utils.ToolTipController
    Friend WithEvents RepCboTeam As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GCLegende As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVLegende As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCol_Legende_NCANNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_Legende_Color As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemColorEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
    Friend WithEvents BtnRefresh As MozartUC.apiButton
End Class
