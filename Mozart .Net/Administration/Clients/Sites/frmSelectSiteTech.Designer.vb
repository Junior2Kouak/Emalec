<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectSiteTech
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
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GCSitTech = New DevExpress.XtraGrid.GridControl()
        Me.GVSitTech = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNSITNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColAffecte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChk_BAFFECTE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GColVSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDecoche = New System.Windows.Forms.Button()
        Me.BtnCoche = New System.Windows.Forms.Button()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCSitTech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSitTech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChk_BAFFECTE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Controls.Add(Me.BtnSave)
        Me.GrpActions.Location = New System.Drawing.Point(12, 12)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(120, 704)
        Me.GrpActions.TabIndex = 17
        Me.GrpActions.TabStop = False
        '
        'BtnQuit
        '
        Me.BtnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnQuit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnQuit.Location = New System.Drawing.Point(6, 653)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(108, 45)
        Me.BtnQuit.TabIndex = 6
        Me.BtnQuit.Text = "Fermer"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSave.Location = New System.Drawing.Point(6, 15)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(108, 44)
        Me.BtnSave.TabIndex = 5
        Me.BtnSave.Text = "Enregistrer"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(138, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(766, 39)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Sélection des sites clients pour le technicien"
        '
        'GCSitTech
        '
        Me.GCSitTech.Location = New System.Drawing.Point(142, 54)
        Me.GCSitTech.MainView = Me.GVSitTech
        Me.GCSitTech.Name = "GCSitTech"
        Me.GCSitTech.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChk_BAFFECTE})
        Me.GCSitTech.Size = New System.Drawing.Size(762, 671)
        Me.GCSitTech.TabIndex = 16
        Me.GCSitTech.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSitTech})
        '
        'GVSitTech
        '
        Me.GVSitTech.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSitTech.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSitTech.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVSitTech.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSitTech.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSitTech.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSitTech.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSitTech.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSitTech.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVSitTech.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSitTech.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSitTech.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSitTech.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSitTech.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSitTech.Appearance.Empty.Options.UseBackColor = True
        Me.GVSitTech.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVSitTech.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVSitTech.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSitTech.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSitTech.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVSitTech.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSitTech.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSitTech.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSitTech.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVSitTech.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSitTech.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSitTech.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSitTech.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSitTech.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSitTech.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSitTech.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSitTech.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSitTech.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSitTech.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSitTech.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVSitTech.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSitTech.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSitTech.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSitTech.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GVSitTech.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVSitTech.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSitTech.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSitTech.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSitTech.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSitTech.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSitTech.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSitTech.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSitTech.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSitTech.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSitTech.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSitTech.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSitTech.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSitTech.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSitTech.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSitTech.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVSitTech.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSitTech.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSitTech.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSitTech.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSitTech.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSitTech.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSitTech.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSitTech.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSitTech.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSitTech.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSitTech.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVSitTech.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSitTech.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSitTech.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSitTech.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSitTech.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSitTech.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSitTech.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSitTech.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSitTech.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSitTech.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVSitTech.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVSitTech.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVSitTech.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVSitTech.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSitTech.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSitTech.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSitTech.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSitTech.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSitTech.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSitTech.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVSitTech.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSitTech.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSitTech.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSitTech.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSitTech.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVSitTech.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSitTech.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSitTech.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSitTech.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSitTech.Appearance.Preview.Options.UseBackColor = True
        Me.GVSitTech.Appearance.Preview.Options.UseFont = True
        Me.GVSitTech.Appearance.Preview.Options.UseForeColor = True
        Me.GVSitTech.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSitTech.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSitTech.Appearance.Row.Options.UseBackColor = True
        Me.GVSitTech.Appearance.Row.Options.UseForeColor = True
        Me.GVSitTech.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSitTech.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSitTech.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSitTech.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVSitTech.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSitTech.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSitTech.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSitTech.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSitTech.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSitTech.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSitTech.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSitTech.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSitTech.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVSitTech.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNSITNUM, Me.GColAffecte, Me.GColVSITNOM})
        Me.GVSitTech.GridControl = Me.GCSitTech
        Me.GVSitTech.Name = "GVSitTech"
        Me.GVSitTech.OptionsNavigation.AutoFocusNewRow = True
        Me.GVSitTech.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSitTech.OptionsView.EnableAppearanceOddRow = True
        Me.GVSitTech.OptionsView.ShowAutoFilterRow = True
        Me.GVSitTech.OptionsView.ShowGroupPanel = False
        '
        'GColNSITNUM
        '
        Me.GColNSITNUM.Caption = "NSITNUM"
        Me.GColNSITNUM.FieldName = "NSITNUM"
        Me.GColNSITNUM.Name = "GColNSITNUM"
        '
        'GColAffecte
        '
        Me.GColAffecte.Caption = "Affecte"
        Me.GColAffecte.ColumnEdit = Me.RepItemChk_BAFFECTE
        Me.GColAffecte.FieldName = "BAFFECTE"
        Me.GColAffecte.Name = "GColAffecte"
        Me.GColAffecte.Visible = True
        Me.GColAffecte.VisibleIndex = 0
        Me.GColAffecte.Width = 70
        '
        'RepItemChk_BAFFECTE
        '
        Me.RepItemChk_BAFFECTE.AutoHeight = False
        Me.RepItemChk_BAFFECTE.Name = "RepItemChk_BAFFECTE"
        Me.RepItemChk_BAFFECTE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChk_BAFFECTE.ValueChecked = 1
        Me.RepItemChk_BAFFECTE.ValueUnchecked = 0
        '
        'GColVSITNOM
        '
        Me.GColVSITNOM.Caption = "Nom du site"
        Me.GColVSITNOM.FieldName = "VSITNOM"
        Me.GColVSITNOM.Name = "GColVSITNOM"
        Me.GColVSITNOM.OptionsColumn.AllowEdit = False
        Me.GColVSITNOM.OptionsColumn.ReadOnly = True
        Me.GColVSITNOM.Visible = True
        Me.GColVSITNOM.VisibleIndex = 1
        Me.GColVSITNOM.Width = 404
        '
        'BtnDecoche
        '
        Me.BtnDecoche.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnDecoche.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnDecoche.Location = New System.Drawing.Point(253, 731)
        Me.BtnDecoche.Name = "BtnDecoche"
        Me.BtnDecoche.Size = New System.Drawing.Size(108, 30)
        Me.BtnDecoche.TabIndex = 22
        Me.BtnDecoche.Text = "Décocher Tous"
        Me.BtnDecoche.UseVisualStyleBackColor = True
        '
        'BtnCoche
        '
        Me.BtnCoche.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnCoche.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCoche.Location = New System.Drawing.Point(139, 731)
        Me.BtnCoche.Name = "BtnCoche"
        Me.BtnCoche.Size = New System.Drawing.Size(108, 30)
        Me.BtnCoche.TabIndex = 21
        Me.BtnCoche.Text = "Cocher Tous"
        Me.BtnCoche.UseVisualStyleBackColor = True
        '
        'frmSelectSiteTech
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(956, 782)
        Me.Controls.Add(Me.BtnDecoche)
        Me.Controls.Add(Me.BtnCoche)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GCSitTech)
        Me.Name = "frmSelectSiteTech"
        Me.Text = "Sélection des sites clients pour les techniciens"
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCSitTech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSitTech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChk_BAFFECTE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnQuit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label1 As Label
    Private WithEvents GCSitTech As DevExpress.XtraGrid.GridControl
    Private WithEvents GVSitTech As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNSITNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColAffecte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemChk_BAFFECTE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BtnDecoche As Button
    Friend WithEvents BtnCoche As Button
End Class
