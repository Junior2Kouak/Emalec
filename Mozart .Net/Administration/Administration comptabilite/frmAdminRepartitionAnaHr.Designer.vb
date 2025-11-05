<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminRepartitionAnaHr
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
        Me.GCListeHrAna = New DevExpress.XtraGrid.GridControl()
        Me.GVListeHrAna = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NIDPER_REPART_ANA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CPERCIV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VTYPEDETAILLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VSERLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.G_Col_VCAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VMODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NCANNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NVAL_REPART_ANA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BMODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnSupp = New System.Windows.Forms.Button()
        Me.BtnDetails = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        CType(Me.GCListeHrAna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeHrAna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCListeHrAna
        '
        Me.GCListeHrAna.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GCListeHrAna.Location = New System.Drawing.Point(114, 48)
        Me.GCListeHrAna.MainView = Me.GVListeHrAna
        Me.GCListeHrAna.Name = "GCListeHrAna"
        Me.GCListeHrAna.Size = New System.Drawing.Size(1063, 567)
        Me.GCListeHrAna.TabIndex = 51
        Me.GCListeHrAna.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeHrAna})
        '
        'GVListeHrAna
        '
        Me.GVListeHrAna.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
        Me.GVListeHrAna.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVListeHrAna.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Silver
        Me.GVListeHrAna.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVListeHrAna.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.White
        Me.GVListeHrAna.Appearance.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GVListeHrAna.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVListeHrAna.Appearance.FixedLine.BackColor = System.Drawing.Color.Silver
        Me.GVListeHrAna.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVListeHrAna.Appearance.FocusedCell.BackColor = System.Drawing.Color.Silver
        Me.GVListeHrAna.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GVListeHrAna.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListeHrAna.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVListeHrAna.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Red
        Me.GVListeHrAna.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVListeHrAna.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListeHrAna.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeHrAna.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeHrAna.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeHrAna.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeHrAna.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeHrAna.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVListeHrAna.Appearance.OddRow.Options.UseBackColor = True
        Me.GVListeHrAna.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVListeHrAna.Appearance.OddRow.Options.UseForeColor = True
        Me.GVListeHrAna.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.GVListeHrAna.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.White
        Me.GVListeHrAna.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVListeHrAna.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListeHrAna.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVListeHrAna.AppearancePrint.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GVListeHrAna.AppearancePrint.FilterPanel.Options.UseBackColor = True
        Me.GVListeHrAna.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NIDPER_REPART_ANA, Me.CPERCIV, Me.VPERNOM, Me.VTYPEDETAILLIB, Me.VSERLIB, Me.G_Col_VCAT, Me.VMODE, Me.NCANNUM, Me.NVAL_REPART_ANA, Me.NPERNUM, Me.BMODE})
        Me.GVListeHrAna.GridControl = Me.GCListeHrAna
        Me.GVListeHrAna.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVListeHrAna.Name = "GVListeHrAna"
        Me.GVListeHrAna.OptionsBehavior.Editable = False
        Me.GVListeHrAna.OptionsBehavior.ReadOnly = True
        Me.GVListeHrAna.OptionsCustomization.AllowGroup = False
        Me.GVListeHrAna.OptionsPrint.PrintPreview = True
        Me.GVListeHrAna.OptionsView.ColumnAutoWidth = False
        Me.GVListeHrAna.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListeHrAna.OptionsView.EnableAppearanceOddRow = True
        Me.GVListeHrAna.OptionsView.ShowAutoFilterRow = True
        Me.GVListeHrAna.OptionsView.ShowFooter = True
        Me.GVListeHrAna.OptionsView.ShowGroupPanel = False
        '
        'NIDPER_REPART_ANA
        '
        Me.NIDPER_REPART_ANA.Caption = "N°"
        Me.NIDPER_REPART_ANA.FieldName = "NIDPER_REPART_ANA"
        Me.NIDPER_REPART_ANA.Name = "NIDPER_REPART_ANA"
        Me.NIDPER_REPART_ANA.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.NIDPER_REPART_ANA.Width = 50
        '
        'CPERCIV
        '
        Me.CPERCIV.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.CPERCIV.AppearanceHeader.Options.UseForeColor = True
        Me.CPERCIV.Caption = "Civ"
        Me.CPERCIV.FieldName = "CPERCIV"
        Me.CPERCIV.Name = "CPERCIV"
        Me.CPERCIV.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.CPERCIV.Visible = True
        Me.CPERCIV.VisibleIndex = 0
        '
        'VPERNOM
        '
        Me.VPERNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VPERNOM.AppearanceHeader.Options.UseForeColor = True
        Me.VPERNOM.Caption = "Personne"
        Me.VPERNOM.FieldName = "VPERNOM"
        Me.VPERNOM.Name = "VPERNOM"
        Me.VPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.VPERNOM.Visible = True
        Me.VPERNOM.VisibleIndex = 1
        Me.VPERNOM.Width = 150
        '
        'VTYPEDETAILLIB
        '
        Me.VTYPEDETAILLIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VTYPEDETAILLIB.AppearanceHeader.Options.UseForeColor = True
        Me.VTYPEDETAILLIB.Caption = "Type"
        Me.VTYPEDETAILLIB.FieldName = "VTYPEDETAILLIB"
        Me.VTYPEDETAILLIB.Name = "VTYPEDETAILLIB"
        Me.VTYPEDETAILLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.VTYPEDETAILLIB.Visible = True
        Me.VTYPEDETAILLIB.VisibleIndex = 2
        Me.VTYPEDETAILLIB.Width = 150
        '
        'VSERLIB
        '
        Me.VSERLIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VSERLIB.AppearanceHeader.Options.UseForeColor = True
        Me.VSERLIB.Caption = "Service"
        Me.VSERLIB.FieldName = "VSERLIB"
        Me.VSERLIB.Name = "VSERLIB"
        Me.VSERLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.VSERLIB.Visible = True
        Me.VSERLIB.VisibleIndex = 3
        Me.VSERLIB.Width = 120
        '
        'G_Col_VCAT
        '
        Me.G_Col_VCAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.G_Col_VCAT.AppearanceHeader.Options.UseForeColor = True
        Me.G_Col_VCAT.Caption = "Catégorie"
        Me.G_Col_VCAT.FieldName = "VCAT"
        Me.G_Col_VCAT.Name = "G_Col_VCAT"
        Me.G_Col_VCAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.G_Col_VCAT.Visible = True
        Me.G_Col_VCAT.VisibleIndex = 4
        Me.G_Col_VCAT.Width = 120
        '
        'VMODE
        '
        Me.VMODE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VMODE.AppearanceHeader.Options.UseForeColor = True
        Me.VMODE.Caption = "Mode répartition"
        Me.VMODE.FieldName = "VMODE"
        Me.VMODE.Name = "VMODE"
        Me.VMODE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.VMODE.Visible = True
        Me.VMODE.VisibleIndex = 5
        Me.VMODE.Width = 120
        '
        'NCANNUM
        '
        Me.NCANNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NCANNUM.AppearanceHeader.Options.UseForeColor = True
        Me.NCANNUM.Caption = "Compte Analytique"
        Me.NCANNUM.FieldName = "NCANNUM"
        Me.NCANNUM.Name = "NCANNUM"
        Me.NCANNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.NCANNUM.Visible = True
        Me.NCANNUM.VisibleIndex = 6
        Me.NCANNUM.Width = 136
        '
        'NVAL_REPART_ANA
        '
        Me.NVAL_REPART_ANA.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NVAL_REPART_ANA.AppearanceHeader.Options.UseForeColor = True
        Me.NVAL_REPART_ANA.Caption = "Répartition"
        Me.NVAL_REPART_ANA.DisplayFormat.FormatString = "{0:n0} %"
        Me.NVAL_REPART_ANA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NVAL_REPART_ANA.FieldName = "NVAL_REPART_ANA"
        Me.NVAL_REPART_ANA.Name = "NVAL_REPART_ANA"
        Me.NVAL_REPART_ANA.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.NVAL_REPART_ANA.Visible = True
        Me.NVAL_REPART_ANA.VisibleIndex = 7
        Me.NVAL_REPART_ANA.Width = 121
        '
        'NPERNUM
        '
        Me.NPERNUM.Caption = "NPERNUM"
        Me.NPERNUM.FieldName = "NPERNUM"
        Me.NPERNUM.Name = "NPERNUM"
        Me.NPERNUM.Width = 150
        '
        'BMODE
        '
        Me.BMODE.Caption = "BMODE"
        Me.BMODE.FieldName = "BMODE"
        Me.BMODE.Name = "BMODE"
        Me.BMODE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelTitre.Location = New System.Drawing.Point(109, 8)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(399, 29)
        Me.LabelTitre.TabIndex = 50
        Me.LabelTitre.Text = "Répartition analytique des heures"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnSupp)
        Me.GroupBox1.Controls.Add(Me.BtnDetails)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(96, 592)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(6, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 48)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Export EXCEL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnSupp
        '
        Me.BtnSupp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSupp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSupp.Location = New System.Drawing.Point(5, 133)
        Me.BtnSupp.Name = "BtnSupp"
        Me.BtnSupp.Size = New System.Drawing.Size(85, 48)
        Me.BtnSupp.TabIndex = 38
        Me.BtnSupp.Text = "Supprimer"
        Me.BtnSupp.UseVisualStyleBackColor = True
        '
        'BtnDetails
        '
        Me.BtnDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnDetails.Location = New System.Drawing.Point(4, 79)
        Me.BtnDetails.Name = "BtnDetails"
        Me.BtnDetails.Size = New System.Drawing.Size(86, 48)
        Me.BtnDetails.TabIndex = 37
        Me.BtnDetails.Text = "Détails"
        Me.BtnDetails.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(6, 519)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(84, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnAdd.Location = New System.Drawing.Point(6, 25)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(84, 48)
        Me.BtnAdd.TabIndex = 0
        Me.BtnAdd.Text = "Ajouter"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'frmAdminRepartitionAnaHr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1258, 640)
        Me.Controls.Add(Me.GCListeHrAna)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAdminRepartitionAnaHr"
        Me.Text = "Répartition analytique des heures"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCListeHrAna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeHrAna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents GCListeHrAna As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeHrAna As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents NIDPER_REPART_ANA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NCANNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents BMODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NVAL_REPART_ANA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelTitre As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSupp As Button
    Friend WithEvents BtnDetails As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents VMODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents G_Col_VCAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents SFD As SaveFileDialog
    Friend WithEvents CPERCIV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VTYPEDETAILLIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VSERLIB As DevExpress.XtraGrid.Columns.GridColumn
End Class
