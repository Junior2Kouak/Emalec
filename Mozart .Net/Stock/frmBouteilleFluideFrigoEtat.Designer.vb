<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBouteilleFluideFrigoEtat
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
        Me.PGC_BottleEtat = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PGF_Row_VTYPEFLUIDELIB = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGF_Col_VTECHNOM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGF_Row_VTYPEBOTTLE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGF_Data_RESTANT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PGF_Data_TOT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGF_Data_TOT_CONTENANT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGF_Data_POURCRESTANT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonExporter = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PGC_BottleEtat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PGC_BottleEtat
        '
        Me.PGC_BottleEtat.Appearance.DataHeaderArea.Options.UseTextOptions = True
        Me.PGC_BottleEtat.Appearance.DataHeaderArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGC_BottleEtat.Appearance.DataHeaderArea.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGC_BottleEtat.Appearance.DataHeaderArea.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PGC_BottleEtat.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PGF_Row_VTYPEFLUIDELIB, Me.PGF_Col_VTECHNOM, Me.PGF_Row_VTYPEBOTTLE, Me.PGF_Data_RESTANT, Me.PGF_Data_TOT, Me.PGF_Data_TOT_CONTENANT, Me.PGF_Data_POURCRESTANT})
        Me.PGC_BottleEtat.Location = New System.Drawing.Point(105, 53)
        Me.PGC_BottleEtat.Name = "PGC_BottleEtat"
        Me.PGC_BottleEtat.OptionsDataField.ColumnValueLineCount = 2
        Me.PGC_BottleEtat.OptionsView.ShowColumnGrandTotalHeader = False
        Me.PGC_BottleEtat.OptionsView.ShowColumnGrandTotals = False
        Me.PGC_BottleEtat.OptionsView.ShowColumnTotals = False
        Me.PGC_BottleEtat.OptionsView.ShowDataHeaders = False
        Me.PGC_BottleEtat.OptionsView.ShowFilterHeaders = False
        Me.PGC_BottleEtat.OptionsView.ShowRowGrandTotalHeader = False
        Me.PGC_BottleEtat.OptionsView.ShowRowGrandTotals = False
        Me.PGC_BottleEtat.OptionsView.ShowRowTotals = False
        Me.PGC_BottleEtat.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar1, Me.RepositoryItemTextEdit1})
        Me.PGC_BottleEtat.Size = New System.Drawing.Size(1119, 597)
        Me.PGC_BottleEtat.TabIndex = 6
        '
        'PGF_Row_VTYPEFLUIDELIB
        '
        Me.PGF_Row_VTYPEFLUIDELIB.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PGF_Row_VTYPEFLUIDELIB.AreaIndex = 0
        Me.PGF_Row_VTYPEFLUIDELIB.Caption = "Type de fluides"
        Me.PGF_Row_VTYPEFLUIDELIB.FieldName = "VTYPEFLUIDELIB"
        Me.PGF_Row_VTYPEFLUIDELIB.Name = "PGF_Row_VTYPEFLUIDELIB"
        Me.PGF_Row_VTYPEFLUIDELIB.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.PGF_Row_VTYPEFLUIDELIB.Width = 75
        '
        'PGF_Col_VTECHNOM
        '
        Me.PGF_Col_VTECHNOM.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PGF_Col_VTECHNOM.AreaIndex = 0
        Me.PGF_Col_VTECHNOM.Caption = "Technicien"
        Me.PGF_Col_VTECHNOM.FieldName = "VTECHNOM"
        Me.PGF_Col_VTECHNOM.Name = "PGF_Col_VTECHNOM"
        '
        'PGF_Row_VTYPEBOTTLE
        '
        Me.PGF_Row_VTYPEBOTTLE.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PGF_Row_VTYPEBOTTLE.AreaIndex = 1
        Me.PGF_Row_VTYPEBOTTLE.Caption = "Type bouteille"
        Me.PGF_Row_VTYPEBOTTLE.FieldName = "VTYPEBOTTLE"
        Me.PGF_Row_VTYPEBOTTLE.Name = "PGF_Row_VTYPEBOTTLE"
        Me.PGF_Row_VTYPEBOTTLE.Width = 150
        '
        'PGF_Data_RESTANT
        '
        Me.PGF_Data_RESTANT.Appearance.Header.Options.UseTextOptions = True
        Me.PGF_Data_RESTANT.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGF_Data_RESTANT.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGF_Data_RESTANT.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PGF_Data_RESTANT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PGF_Data_RESTANT.AreaIndex = 0
        Me.PGF_Data_RESTANT.Caption = "Quantité restante (en L)"
        Me.PGF_Data_RESTANT.CellFormat.FormatString = "n3"
        Me.PGF_Data_RESTANT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PGF_Data_RESTANT.ColumnValueLineCount = 2
        Me.PGF_Data_RESTANT.FieldEdit = Me.RepositoryItemTextEdit1
        Me.PGF_Data_RESTANT.FieldName = "RESTANT"
        Me.PGF_Data_RESTANT.Name = "PGF_Data_RESTANT"
        Me.PGF_Data_RESTANT.Options.AllowEdit = False
        Me.PGF_Data_RESTANT.Options.ReadOnly = True
        Me.PGF_Data_RESTANT.Width = 130
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AllowFocused = False
        Me.RepositoryItemTextEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.ReadOnly = True
        '
        'PGF_Data_TOT
        '
        Me.PGF_Data_TOT.Appearance.Header.Options.UseTextOptions = True
        Me.PGF_Data_TOT.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGF_Data_TOT.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGF_Data_TOT.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PGF_Data_TOT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PGF_Data_TOT.AreaIndex = 1
        Me.PGF_Data_TOT.Caption = "Quantité utilisée"
        Me.PGF_Data_TOT.CellFormat.FormatString = "n3"
        Me.PGF_Data_TOT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PGF_Data_TOT.ColumnValueLineCount = 2
        Me.PGF_Data_TOT.FieldName = "TOT"
        Me.PGF_Data_TOT.Name = "PGF_Data_TOT"
        Me.PGF_Data_TOT.Visible = False
        '
        'PGF_Data_TOT_CONTENANT
        '
        Me.PGF_Data_TOT_CONTENANT.Appearance.CellTotal.Options.UseTextOptions = True
        Me.PGF_Data_TOT_CONTENANT.Appearance.CellTotal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PGF_Data_TOT_CONTENANT.Appearance.Header.Options.UseTextOptions = True
        Me.PGF_Data_TOT_CONTENANT.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PGF_Data_TOT_CONTENANT.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PGF_Data_TOT_CONTENANT.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PGF_Data_TOT_CONTENANT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PGF_Data_TOT_CONTENANT.AreaIndex = 1
        Me.PGF_Data_TOT_CONTENANT.Caption = "Quantité total bouteille"
        Me.PGF_Data_TOT_CONTENANT.CellFormat.FormatString = "n3"
        Me.PGF_Data_TOT_CONTENANT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PGF_Data_TOT_CONTENANT.ColumnValueLineCount = 2
        Me.PGF_Data_TOT_CONTENANT.FieldName = "TOT_CONTENANT"
        Me.PGF_Data_TOT_CONTENANT.Name = "PGF_Data_TOT_CONTENANT"
        Me.PGF_Data_TOT_CONTENANT.Visible = False
        '
        'PGF_Data_POURCRESTANT
        '
        Me.PGF_Data_POURCRESTANT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PGF_Data_POURCRESTANT.AreaIndex = 1
        Me.PGF_Data_POURCRESTANT.Caption = "% restant"
        Me.PGF_Data_POURCRESTANT.CellFormat.FormatString = "n2"
        Me.PGF_Data_POURCRESTANT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PGF_Data_POURCRESTANT.ColumnValueLineCount = 2
        Me.PGF_Data_POURCRESTANT.FieldEdit = Me.RepositoryItemProgressBar1
        Me.PGF_Data_POURCRESTANT.FieldName = "POURC_RESTANT"
        Me.PGF_Data_POURCRESTANT.Name = "PGF_Data_POURCRESTANT"
        Me.PGF_Data_POURCRESTANT.Options.AllowEdit = False
        Me.PGF_Data_POURCRESTANT.Options.ReadOnly = True
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.AllowFocused = False
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        Me.RepositoryItemProgressBar1.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
        Me.RepositoryItemProgressBar1.ReadOnly = True
        Me.RepositoryItemProgressBar1.ShowTitle = True
        Me.RepositoryItemProgressBar1.Step = 1
        '
        'LblTitre
        '
        Me.LblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(105, 20)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(835, 30)
        Me.LblTitre.TabIndex = 66
        Me.LblTitre.Text = "Tableau de suivi des bouteilles de fluides frigorigènes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonExporter)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnPrint)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(87, 857)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        '
        'ButtonExporter
        '
        Me.ButtonExporter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonExporter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonExporter.Location = New System.Drawing.Point(7, 90)
        Me.ButtonExporter.Name = "ButtonExporter"
        Me.ButtonExporter.Size = New System.Drawing.Size(75, 48)
        Me.ButtonExporter.TabIndex = 43
        Me.ButtonExporter.Text = "Exporter liste (xlsx)"
        Me.ButtonExporter.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(7, 803)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPrint.Location = New System.Drawing.Point(7, 20)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(74, 48)
        Me.BtnPrint.TabIndex = 0
        Me.BtnPrint.Text = "Imprimer"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'frmBouteilleFluideFrigoEtat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1236, 910)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.PGC_BottleEtat)
        Me.Name = "frmBouteilleFluideFrigoEtat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tableau de suivi des bouteilles de fluides frigorigènes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PGC_BottleEtat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PGC_BottleEtat As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents LblTitre As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonExporter As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents PGF_Row_VTYPEFLUIDELIB As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PGF_Col_VTECHNOM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PGF_Row_VTYPEBOTTLE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PGF_Data_RESTANT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PGF_Data_TOT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PGF_Data_TOT_CONTENANT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PGF_Data_POURCRESTANT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents SFD As SaveFileDialog
End Class
