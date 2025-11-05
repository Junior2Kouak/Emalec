<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminDAF_TauxAna
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
        Me.GrpListe = New System.Windows.Forms.GroupBox()
        Me.PGC_Taux_ANA = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.BtmExportPDF = New System.Windows.Forms.Button()
        Me.BtnExportXLS = New System.Windows.Forms.Button()
        Me.BtnExp = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.GrpPeriode = New System.Windows.Forms.GroupBox()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.LblAnnee = New System.Windows.Forms.Label()
        Me.CboAnnee = New System.Windows.Forms.ComboBox()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.GrpListe.SuspendLayout()
        CType(Me.PGC_Taux_ANA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.GrpPeriode.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpListe
        '
        Me.GrpListe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpListe.Controls.Add(Me.PGC_Taux_ANA)
        Me.GrpListe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GrpListe.Location = New System.Drawing.Point(127, 88)
        Me.GrpListe.Name = "GrpListe"
        Me.GrpListe.Size = New System.Drawing.Size(1305, 830)
        Me.GrpListe.TabIndex = 25
        Me.GrpListe.TabStop = False
        '
        'PGC_Taux_ANA
        '
        Me.PGC_Taux_ANA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PGC_Taux_ANA.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField6, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5})
        Me.PGC_Taux_ANA.Location = New System.Drawing.Point(11, 21)
        Me.PGC_Taux_ANA.Name = "PGC_Taux_ANA"
        Me.PGC_Taux_ANA.OptionsView.ShowColumnGrandTotalHeader = False
        Me.PGC_Taux_ANA.OptionsView.ShowColumnGrandTotals = False
        Me.PGC_Taux_ANA.OptionsView.ShowColumnHeaders = False
        Me.PGC_Taux_ANA.OptionsView.ShowColumnTotals = False
        Me.PGC_Taux_ANA.OptionsView.ShowDataHeaders = False
        Me.PGC_Taux_ANA.OptionsView.ShowFilterHeaders = False
        Me.PGC_Taux_ANA.OptionsView.ShowRowGrandTotalHeader = False
        Me.PGC_Taux_ANA.OptionsView.ShowRowGrandTotals = False
        Me.PGC_Taux_ANA.OptionsView.ShowRowHeaders = False
        Me.PGC_Taux_ANA.OptionsView.ShowRowTotals = False
        Me.PGC_Taux_ANA.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.PGC_Taux_ANA.Size = New System.Drawing.Size(1279, 803)
        Me.PGC_Taux_ANA.TabIndex = 0
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PivotGridField1.Appearance.Cell.Options.UseFont = True
        Me.PivotGridField1.Appearance.Cell.Options.UseTextOptions = True
        Me.PivotGridField1.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PivotGridField1.Appearance.Cell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PivotGridField1.Appearance.Cell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotGridField1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PivotGridField1.Appearance.Header.Options.UseFont = True
        Me.PivotGridField1.Appearance.Header.Options.UseTextOptions = True
        Me.PivotGridField1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PivotGridField1.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PivotGridField1.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotGridField1.Appearance.Value.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PivotGridField1.Appearance.Value.Options.UseFont = True
        Me.PivotGridField1.Appearance.Value.Options.UseTextOptions = True
        Me.PivotGridField1.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PivotGridField1.Appearance.Value.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PivotGridField1.Appearance.Value.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.ColumnValueLineCount = 3
        Me.PivotGridField1.FieldName = "VSOCIETE"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField6
        '
        Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField6.AreaIndex = 0
        Me.PivotGridField6.FieldName = "GRP"
        Me.PivotGridField6.Name = "PivotGridField6"
        Me.PivotGridField6.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Value
        Me.PivotGridField6.Visible = False
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Appearance.Value.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PivotGridField2.Appearance.Value.Options.UseFont = True
        Me.PivotGridField2.Appearance.Value.Options.UseTextOptions = True
        Me.PivotGridField2.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.PivotGridField2.Appearance.Value.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField2.AreaIndex = 0
        Me.PivotGridField2.FieldName = "VTAUX_ANA_LIB"
        Me.PivotGridField2.Name = "PivotGridField2"
        Me.PivotGridField2.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.PivotGridField2.SortBySummaryInfo.Field = Me.PivotGridField6
        Me.PivotGridField2.SortBySummaryInfo.FieldName = "GRP"
        Me.PivotGridField2.Width = 300
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Appearance.Value.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PivotGridField3.Appearance.Value.Options.UseFont = True
        Me.PivotGridField3.Appearance.Value.Options.UseTextOptions = True
        Me.PivotGridField3.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PivotGridField3.Appearance.Value.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PivotGridField3.Appearance.Value.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField3.AreaIndex = 1
        Me.PivotGridField3.FieldName = "VTAUX_ANA_UNITE"
        Me.PivotGridField3.Name = "PivotGridField3"
        Me.PivotGridField3.Width = 75
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Appearance.Value.Options.UseTextOptions = True
        Me.PivotGridField4.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PivotGridField4.Appearance.Value.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PivotGridField4.Appearance.Value.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField4.AreaIndex = 0
        Me.PivotGridField4.CellFormat.FormatString = "n2"
        Me.PivotGridField4.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField4.FieldEdit = Me.RepositoryItemTextEdit1
        Me.PivotGridField4.FieldName = "NTAUX_ANA_VAL"
        Me.PivotGridField4.Name = "PivotGridField4"
        Me.PivotGridField4.Options.ShowCustomTotals = False
        Me.PivotGridField4.Options.ShowGrandTotal = False
        Me.PivotGridField4.Options.ShowTotals = False
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatString = "n2"
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField5.AreaIndex = 1
        Me.PivotGridField5.FieldName = "NTAUX_ANA_ID"
        Me.PivotGridField5.Name = "PivotGridField5"
        Me.PivotGridField5.Visible = False
        '
        'BtmExportPDF
        '
        Me.BtmExportPDF.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.BtmExportPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtmExportPDF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtmExportPDF.Location = New System.Drawing.Point(6, 144)
        Me.BtmExportPDF.Name = "BtmExportPDF"
        Me.BtmExportPDF.Size = New System.Drawing.Size(100, 41)
        Me.BtmExportPDF.TabIndex = 5
        Me.BtmExportPDF.Tag = ""
        Me.BtmExportPDF.Text = "Exporter en PDF"
        Me.BtmExportPDF.UseVisualStyleBackColor = False
        '
        'BtnExportXLS
        '
        Me.BtnExportXLS.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.BtnExportXLS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnExportXLS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnExportXLS.Location = New System.Drawing.Point(6, 97)
        Me.BtnExportXLS.Name = "BtnExportXLS"
        Me.BtnExportXLS.Size = New System.Drawing.Size(100, 41)
        Me.BtnExportXLS.TabIndex = 3
        Me.BtnExportXLS.Tag = ""
        Me.BtnExportXLS.Text = "Exporter en EXCEL"
        Me.BtnExportXLS.UseVisualStyleBackColor = False
        '
        'BtnExp
        '
        Me.BtnExp.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.BtnExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnExp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnExp.Location = New System.Drawing.Point(6, 50)
        Me.BtnExp.Name = "BtnExp"
        Me.BtnExp.Size = New System.Drawing.Size(100, 41)
        Me.BtnExp.TabIndex = 2
        Me.BtnExp.Tag = ""
        Me.BtnExp.Text = "Enregistrer"
        Me.BtnExp.UseVisualStyleBackColor = False
        '
        'BtnFermer
        '
        Me.BtnFermer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnFermer.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(9, 872)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(100, 41)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = False
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtmExportPDF)
        Me.GrpActions.Controls.Add(Me.BtnExportXLS)
        Me.GrpActions.Controls.Add(Me.BtnExp)
        Me.GrpActions.Location = New System.Drawing.Point(9, 9)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(112, 653)
        Me.GrpActions.TabIndex = 24
        Me.GrpActions.TabStop = False
        '
        'GrpPeriode
        '
        Me.GrpPeriode.Controls.Add(Me.BtnValid)
        Me.GrpPeriode.Controls.Add(Me.LblAnnee)
        Me.GrpPeriode.Controls.Add(Me.CboAnnee)
        Me.GrpPeriode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GrpPeriode.Location = New System.Drawing.Point(130, 12)
        Me.GrpPeriode.Name = "GrpPeriode"
        Me.GrpPeriode.Size = New System.Drawing.Size(506, 70)
        Me.GrpPeriode.TabIndex = 26
        Me.GrpPeriode.TabStop = False
        Me.GrpPeriode.Text = "Période"
        '
        'BtnValid
        '
        Me.BtnValid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnValid.Location = New System.Drawing.Point(324, 15)
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.Size = New System.Drawing.Size(84, 35)
        Me.BtnValid.TabIndex = 4
        Me.BtnValid.Text = "Valider"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'LblAnnee
        '
        Me.LblAnnee.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblAnnee.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblAnnee.Location = New System.Drawing.Point(26, 24)
        Me.LblAnnee.Name = "LblAnnee"
        Me.LblAnnee.Size = New System.Drawing.Size(70, 18)
        Me.LblAnnee.TabIndex = 3
        Me.LblAnnee.Text = "Année"
        '
        'CboAnnee
        '
        Me.CboAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAnnee.FormattingEnabled = True
        Me.CboAnnee.Location = New System.Drawing.Point(102, 21)
        Me.CboAnnee.Name = "CboAnnee"
        Me.CboAnnee.Size = New System.Drawing.Size(172, 24)
        Me.CboAnnee.TabIndex = 1
        '
        'frmAdminDAF_TauxAna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnFermer
        Me.ClientSize = New System.Drawing.Size(1443, 925)
        Me.Controls.Add(Me.GrpPeriode)
        Me.Controls.Add(Me.GrpListe)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.BtnFermer)
        Me.Name = "frmAdminDAF_TauxAna"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Administration DAF"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpListe.ResumeLayout(False)
        CType(Me.PGC_Taux_ANA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.GrpPeriode.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpListe As GroupBox
    Friend WithEvents BtmExportPDF As Button
    Friend WithEvents BtnExportXLS As Button
    Friend WithEvents BtnExp As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents GrpPeriode As GroupBox
    Friend WithEvents BtnValid As Button
    Friend WithEvents LblAnnee As Label
    Friend WithEvents CboAnnee As ComboBox
    Friend WithEvents PGC_Taux_ANA As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents SFD As SaveFileDialog
    Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
End Class
