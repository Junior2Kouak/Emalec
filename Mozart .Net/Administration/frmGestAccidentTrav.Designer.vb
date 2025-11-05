<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestAccidentTrav
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
        Me.GCListeAccident = New DevExpress.XtraGrid.GridControl()
        Me.GVListeAccident = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NACCIDENTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DDATCRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VSOCIETE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BARRET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSupp = New System.Windows.Forms.Button()
        Me.BtnDetails = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        CType(Me.GCListeAccident, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeAccident, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCListeAccident
        '
        Me.GCListeAccident.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GCListeAccident.Location = New System.Drawing.Point(114, 47)
        Me.GCListeAccident.MainView = Me.GVListeAccident
        Me.GCListeAccident.Name = "GCListeAccident"
        Me.GCListeAccident.Size = New System.Drawing.Size(740, 567)
        Me.GCListeAccident.TabIndex = 48
        Me.GCListeAccident.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeAccident})
        '
        'GVListeAccident
        '
        Me.GVListeAccident.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
        Me.GVListeAccident.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVListeAccident.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Silver
        Me.GVListeAccident.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVListeAccident.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.White
        Me.GVListeAccident.Appearance.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GVListeAccident.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVListeAccident.Appearance.FixedLine.BackColor = System.Drawing.Color.Silver
        Me.GVListeAccident.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVListeAccident.Appearance.FocusedCell.BackColor = System.Drawing.Color.Silver
        Me.GVListeAccident.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GVListeAccident.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListeAccident.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVListeAccident.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Red
        Me.GVListeAccident.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVListeAccident.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListeAccident.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeAccident.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeAccident.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeAccident.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeAccident.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeAccident.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVListeAccident.Appearance.OddRow.Options.UseBackColor = True
        Me.GVListeAccident.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVListeAccident.Appearance.OddRow.Options.UseForeColor = True
        Me.GVListeAccident.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.GVListeAccident.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.White
        Me.GVListeAccident.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVListeAccident.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListeAccident.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVListeAccident.AppearancePrint.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GVListeAccident.AppearancePrint.FilterPanel.Options.UseBackColor = True
        Me.GVListeAccident.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NACCIDENTID, Me.DDATCRE, Me.VSOCIETE, Me.VPERNOM, Me.BARRET, Me.GridColumn1})
        Me.GVListeAccident.GridControl = Me.GCListeAccident
        Me.GVListeAccident.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVListeAccident.Name = "GVListeAccident"
        Me.GVListeAccident.OptionsBehavior.Editable = False
        Me.GVListeAccident.OptionsBehavior.ReadOnly = True
        Me.GVListeAccident.OptionsCustomization.AllowGroup = False
        Me.GVListeAccident.OptionsPrint.PrintPreview = True
        Me.GVListeAccident.OptionsView.ColumnAutoWidth = False
        Me.GVListeAccident.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListeAccident.OptionsView.EnableAppearanceOddRow = True
        Me.GVListeAccident.OptionsView.ShowAutoFilterRow = True
        Me.GVListeAccident.OptionsView.ShowFooter = True
        Me.GVListeAccident.OptionsView.ShowGroupPanel = False
        '
        'NACCIDENTID
        '
        Me.NACCIDENTID.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NACCIDENTID.AppearanceHeader.Options.UseForeColor = True
        Me.NACCIDENTID.Caption = "N°"
        Me.NACCIDENTID.FieldName = "NACCIDENTID"
        Me.NACCIDENTID.Name = "NACCIDENTID"
        Me.NACCIDENTID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.NACCIDENTID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.NACCIDENTID.Visible = True
        Me.NACCIDENTID.VisibleIndex = 0
        Me.NACCIDENTID.Width = 50
        '
        'DDATCRE
        '
        Me.DDATCRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DDATCRE.AppearanceHeader.Options.UseForeColor = True
        Me.DDATCRE.Caption = "Date Accident"
        Me.DDATCRE.FieldName = "DDATCRE"
        Me.DDATCRE.Name = "DDATCRE"
        Me.DDATCRE.Visible = True
        Me.DDATCRE.VisibleIndex = 1
        Me.DDATCRE.Width = 150
        '
        'VSOCIETE
        '
        Me.VSOCIETE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VSOCIETE.AppearanceHeader.Options.UseForeColor = True
        Me.VSOCIETE.Caption = "Société"
        Me.VSOCIETE.FieldName = "VSOCIETE"
        Me.VSOCIETE.Name = "VSOCIETE"
        Me.VSOCIETE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.VSOCIETE.Visible = True
        Me.VSOCIETE.VisibleIndex = 2
        Me.VSOCIETE.Width = 200
        '
        'VPERNOM
        '
        Me.VPERNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VPERNOM.AppearanceHeader.Options.UseForeColor = True
        Me.VPERNOM.Caption = "Collaborateur"
        Me.VPERNOM.FieldName = "VPERNOM"
        Me.VPERNOM.Name = "VPERNOM"
        Me.VPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.VPERNOM.Visible = True
        Me.VPERNOM.VisibleIndex = 3
        Me.VPERNOM.Width = 200
        '
        'BARRET
        '
        Me.BARRET.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BARRET.AppearanceHeader.Options.UseForeColor = True
        Me.BARRET.Caption = "Arret"
        Me.BARRET.FieldName = "BARRET"
        Me.BARRET.Name = "BARRET"
        Me.BARRET.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.BARRET.Visible = True
        Me.BARRET.VisibleIndex = 4
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "NPERNUM"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelTitre.Location = New System.Drawing.Point(109, 7)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(506, 29)
        Me.LabelTitre.TabIndex = 47
        Me.LabelTitre.Text = "Gestion des accidents de travail du groupe"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSupp)
        Me.GroupBox1.Controls.Add(Me.BtnDetails)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(96, 592)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
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
        'frmGestAccidentTrav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1206, 668)
        Me.Controls.Add(Me.GCListeAccident)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmGestAccidentTrav"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion des accidents de travail du groupe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCListeAccident, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeAccident, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents GCListeAccident As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeAccident As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents NACCIDENTID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DDATCRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VSOCIETE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents BARRET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelTitre As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSupp As Button
    Friend WithEvents BtnDetails As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
