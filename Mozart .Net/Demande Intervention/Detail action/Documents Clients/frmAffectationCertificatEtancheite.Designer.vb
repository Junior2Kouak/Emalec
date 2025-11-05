<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAffectationCertificatEtancheite
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
        Me.GCListeCertifEtanch = New DevExpress.XtraGrid.GridControl()
        Me.GVListeCertifEtanch = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_NCOCHE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkNCOCHE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GCol_NIMAGE_BSD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NIDCERTFLUIDSERVER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NCERTNUMFICHE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_DCERTFLUIDCREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VIDENT_EQUIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VNATUREFLUID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NCHARGETOT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NIMAGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VFICHIER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        CType(Me.GCListeCertifEtanch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeCertifEtanch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkNCOCHE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCListeCertifEtanch
        '
        Me.GCListeCertifEtanch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GCListeCertifEtanch.Location = New System.Drawing.Point(110, 52)
        Me.GCListeCertifEtanch.MainView = Me.GVListeCertifEtanch
        Me.GCListeCertifEtanch.Name = "GCListeCertifEtanch"
        Me.GCListeCertifEtanch.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChkNCOCHE})
        Me.GCListeCertifEtanch.Size = New System.Drawing.Size(885, 514)
        Me.GCListeCertifEtanch.TabIndex = 51
        Me.GCListeCertifEtanch.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeCertifEtanch})
        '
        'GVListeCertifEtanch
        '
        Me.GVListeCertifEtanch.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
        Me.GVListeCertifEtanch.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVListeCertifEtanch.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Silver
        Me.GVListeCertifEtanch.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVListeCertifEtanch.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.White
        Me.GVListeCertifEtanch.Appearance.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GVListeCertifEtanch.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVListeCertifEtanch.Appearance.FixedLine.BackColor = System.Drawing.Color.Silver
        Me.GVListeCertifEtanch.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVListeCertifEtanch.Appearance.FocusedCell.BackColor = System.Drawing.Color.Silver
        Me.GVListeCertifEtanch.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GVListeCertifEtanch.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListeCertifEtanch.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVListeCertifEtanch.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Red
        Me.GVListeCertifEtanch.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVListeCertifEtanch.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListeCertifEtanch.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeCertifEtanch.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeCertifEtanch.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeCertifEtanch.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeCertifEtanch.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListeCertifEtanch.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeCertifEtanch.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeCertifEtanch.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVListeCertifEtanch.Appearance.OddRow.Options.UseBackColor = True
        Me.GVListeCertifEtanch.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVListeCertifEtanch.Appearance.OddRow.Options.UseForeColor = True
        Me.GVListeCertifEtanch.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.GVListeCertifEtanch.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.White
        Me.GVListeCertifEtanch.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVListeCertifEtanch.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListeCertifEtanch.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVListeCertifEtanch.AppearancePrint.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GVListeCertifEtanch.AppearancePrint.FilterPanel.Options.UseBackColor = True
        Me.GVListeCertifEtanch.ColumnPanelRowHeight = 50
        Me.GVListeCertifEtanch.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_NCOCHE, Me.GCol_NIMAGE_BSD, Me.GCol_NIDCERTFLUIDSERVER, Me.GCol_NCERTNUMFICHE, Me.GCol_DCERTFLUIDCREE, Me.GCol_VIDENT_EQUIP, Me.GCol_VNATUREFLUID, Me.GCol_NCHARGETOT, Me.GCol_NIMAGE, Me.GCol_VFICHIER})
        Me.GVListeCertifEtanch.GridControl = Me.GCListeCertifEtanch
        Me.GVListeCertifEtanch.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVListeCertifEtanch.Name = "GVListeCertifEtanch"
        Me.GVListeCertifEtanch.OptionsCustomization.AllowGroup = False
        Me.GVListeCertifEtanch.OptionsPrint.PrintPreview = True
        Me.GVListeCertifEtanch.OptionsView.ColumnAutoWidth = False
        Me.GVListeCertifEtanch.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListeCertifEtanch.OptionsView.EnableAppearanceOddRow = True
        Me.GVListeCertifEtanch.OptionsView.ShowAutoFilterRow = True
        Me.GVListeCertifEtanch.OptionsView.ShowFooter = True
        Me.GVListeCertifEtanch.OptionsView.ShowGroupPanel = False
        '
        'GCol_NCOCHE
        '
        Me.GCol_NCOCHE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_NCOCHE.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_NCOCHE.Caption = "Affecté"
        Me.GCol_NCOCHE.ColumnEdit = Me.RepItemChkNCOCHE
        Me.GCol_NCOCHE.FieldName = "NCOCHE"
        Me.GCol_NCOCHE.Name = "GCol_NCOCHE"
        Me.GCol_NCOCHE.Visible = True
        Me.GCol_NCOCHE.VisibleIndex = 0
        '
        'RepItemChkNCOCHE
        '
        Me.RepItemChkNCOCHE.AutoHeight = False
        Me.RepItemChkNCOCHE.Name = "RepItemChkNCOCHE"
        Me.RepItemChkNCOCHE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChkNCOCHE.ValueChecked = 1
        Me.RepItemChkNCOCHE.ValueUnchecked = 0
        '
        'GCol_NIMAGE_BSD
        '
        Me.GCol_NIMAGE_BSD.Caption = "NIMAGE_BSD"
        Me.GCol_NIMAGE_BSD.FieldName = "NIMAGE_BSD"
        Me.GCol_NIMAGE_BSD.Name = "GCol_NIMAGE_BSD"
        '
        'GCol_NIDCERTFLUIDSERVER
        '
        Me.GCol_NIDCERTFLUIDSERVER.Caption = "NIDCERTFLUIDSERVER"
        Me.GCol_NIDCERTFLUIDSERVER.FieldName = "NIDCERTFLUIDSERVER"
        Me.GCol_NIDCERTFLUIDSERVER.Name = "GCol_NIDCERTFLUIDSERVER"
        '
        'GCol_NCERTNUMFICHE
        '
        Me.GCol_NCERTNUMFICHE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_NCERTNUMFICHE.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_NCERTNUMFICHE.Caption = "N° Fiche"
        Me.GCol_NCERTNUMFICHE.FieldName = "NCERTNUMFICHE"
        Me.GCol_NCERTNUMFICHE.Name = "GCol_NCERTNUMFICHE"
        Me.GCol_NCERTNUMFICHE.OptionsColumn.AllowEdit = False
        Me.GCol_NCERTNUMFICHE.OptionsColumn.ReadOnly = True
        Me.GCol_NCERTNUMFICHE.Visible = True
        Me.GCol_NCERTNUMFICHE.VisibleIndex = 1
        Me.GCol_NCERTNUMFICHE.Width = 150
        '
        'GCol_DCERTFLUIDCREE
        '
        Me.GCol_DCERTFLUIDCREE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_DCERTFLUIDCREE.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_DCERTFLUIDCREE.Caption = "Date création certificat"
        Me.GCol_DCERTFLUIDCREE.FieldName = "DCERTFLUIDCREE"
        Me.GCol_DCERTFLUIDCREE.Name = "GCol_DCERTFLUIDCREE"
        Me.GCol_DCERTFLUIDCREE.OptionsColumn.AllowEdit = False
        Me.GCol_DCERTFLUIDCREE.OptionsColumn.ReadOnly = True
        Me.GCol_DCERTFLUIDCREE.Visible = True
        Me.GCol_DCERTFLUIDCREE.VisibleIndex = 2
        Me.GCol_DCERTFLUIDCREE.Width = 100
        '
        'GCol_VIDENT_EQUIP
        '
        Me.GCol_VIDENT_EQUIP.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VIDENT_EQUIP.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VIDENT_EQUIP.Caption = "Identification équipement"
        Me.GCol_VIDENT_EQUIP.FieldName = "VIDENT_EQUIP"
        Me.GCol_VIDENT_EQUIP.Name = "GCol_VIDENT_EQUIP"
        Me.GCol_VIDENT_EQUIP.OptionsColumn.AllowEdit = False
        Me.GCol_VIDENT_EQUIP.OptionsColumn.ReadOnly = True
        Me.GCol_VIDENT_EQUIP.Visible = True
        Me.GCol_VIDENT_EQUIP.VisibleIndex = 3
        Me.GCol_VIDENT_EQUIP.Width = 200
        '
        'GCol_VNATUREFLUID
        '
        Me.GCol_VNATUREFLUID.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VNATUREFLUID.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VNATUREFLUID.Caption = "Nature du fluide"
        Me.GCol_VNATUREFLUID.FieldName = "VNATUREFLUID"
        Me.GCol_VNATUREFLUID.Name = "GCol_VNATUREFLUID"
        Me.GCol_VNATUREFLUID.OptionsColumn.AllowEdit = False
        Me.GCol_VNATUREFLUID.OptionsColumn.ReadOnly = True
        Me.GCol_VNATUREFLUID.Visible = True
        Me.GCol_VNATUREFLUID.VisibleIndex = 4
        '
        'GCol_NCHARGETOT
        '
        Me.GCol_NCHARGETOT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_NCHARGETOT.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_NCHARGETOT.Caption = "Charge totale"
        Me.GCol_NCHARGETOT.FieldName = "NCHARGETOT"
        Me.GCol_NCHARGETOT.Name = "GCol_NCHARGETOT"
        Me.GCol_NCHARGETOT.OptionsColumn.AllowEdit = False
        Me.GCol_NCHARGETOT.OptionsColumn.ReadOnly = True
        Me.GCol_NCHARGETOT.Visible = True
        Me.GCol_NCHARGETOT.VisibleIndex = 5
        '
        'GCol_NIMAGE
        '
        Me.GCol_NIMAGE.Caption = "NIMAGE"
        Me.GCol_NIMAGE.FieldName = "NIMAGE"
        Me.GCol_NIMAGE.Name = "GCol_NIMAGE"
        '
        'GCol_VFICHIER
        '
        Me.GCol_VFICHIER.Caption = "VFICHIER"
        Me.GCol_VFICHIER.FieldName = "VFICHIER"
        Me.GCol_VFICHIER.Name = "GCol_VFICHIER"
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelTitre.Location = New System.Drawing.Point(105, 11)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(644, 29)
        Me.LabelTitre.TabIndex = 50
        Me.LabelTitre.Text = "Affectation des certificats étanchéité au document BSD"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(87, 564)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(4, 340)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSave.Location = New System.Drawing.Point(4, 50)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(80, 48)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "Enregistrer"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'frmAffectationCertificatEtancheite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1309, 580)
        Me.Controls.Add(Me.GCListeCertifEtanch)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAffectationCertificatEtancheite"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Affectation des certificats étanchéité au document"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCListeCertifEtanch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeCertifEtanch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkNCOCHE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents GCListeCertifEtanch As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeCertifEtanch As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelTitre As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents GCol_NCOCHE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NIMAGE_BSD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NIDCERTFLUIDSERVER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NCERTNUMFICHE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_DCERTFLUIDCREE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VIDENT_EQUIP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VNATUREFLUID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NCHARGETOT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NIMAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VFICHIER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemChkNCOCHE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
