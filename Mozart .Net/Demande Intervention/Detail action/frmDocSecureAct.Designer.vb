<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocSecureAct
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
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.GCListeDocSecure = New DevExpress.XtraGrid.GridControl()
        Me.GVListeDocSecure = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_NIDACTDOCSECURE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NACTNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VFILE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NQUICREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VFILENAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VFILEDESCRIPT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_DQUICREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VPRENOM_CREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NQUIMODIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_DQUIMODIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VPRENOM_MOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_PATH_ACT_DOC_SECURE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonSupp = New System.Windows.Forms.Button()
        Me.ButtonDetails = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        CType(Me.GCListeDocSecure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeDocSecure, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser
        '
        Me.WebBrowser.AllowWebBrowserDrop = False
        Me.WebBrowser.Location = New System.Drawing.Point(116, 357)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.ScriptErrorsSuppressed = True
        Me.WebBrowser.Size = New System.Drawing.Size(1217, 520)
        Me.WebBrowser.TabIndex = 9
        '
        'GCListeDocSecure
        '
        Me.GCListeDocSecure.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GCListeDocSecure.Location = New System.Drawing.Point(116, 62)
        Me.GCListeDocSecure.MainView = Me.GVListeDocSecure
        Me.GCListeDocSecure.Name = "GCListeDocSecure"
        Me.GCListeDocSecure.Size = New System.Drawing.Size(1217, 277)
        Me.GCListeDocSecure.TabIndex = 48
        Me.GCListeDocSecure.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeDocSecure})
        '
        'GVListeDocSecure
        '
        Me.GVListeDocSecure.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
        Me.GVListeDocSecure.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVListeDocSecure.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Silver
        Me.GVListeDocSecure.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVListeDocSecure.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.White
        Me.GVListeDocSecure.Appearance.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GVListeDocSecure.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVListeDocSecure.Appearance.FixedLine.BackColor = System.Drawing.Color.Silver
        Me.GVListeDocSecure.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVListeDocSecure.Appearance.FocusedCell.BackColor = System.Drawing.Color.Silver
        Me.GVListeDocSecure.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GVListeDocSecure.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListeDocSecure.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVListeDocSecure.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Red
        Me.GVListeDocSecure.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVListeDocSecure.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListeDocSecure.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeDocSecure.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeDocSecure.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeDocSecure.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeDocSecure.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVListeDocSecure.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVListeDocSecure.Appearance.OddRow.Options.UseBackColor = True
        Me.GVListeDocSecure.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVListeDocSecure.Appearance.OddRow.Options.UseForeColor = True
        Me.GVListeDocSecure.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.GVListeDocSecure.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.White
        Me.GVListeDocSecure.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVListeDocSecure.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListeDocSecure.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVListeDocSecure.AppearancePrint.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GVListeDocSecure.AppearancePrint.FilterPanel.Options.UseBackColor = True
        Me.GVListeDocSecure.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_NIDACTDOCSECURE, Me.GCol_NACTNUM, Me.GCol_VFILE, Me.GCol_NQUICREE, Me.GCol_VFILENAME, Me.GCol_VFILEDESCRIPT, Me.GCol_DQUICREE, Me.GCol_VPRENOM_CREE, Me.GCol_NQUIMODIF, Me.GCol_DQUIMODIF, Me.GCol_VPRENOM_MOD, Me.GCol_PATH_ACT_DOC_SECURE})
        Me.GVListeDocSecure.GridControl = Me.GCListeDocSecure
        Me.GVListeDocSecure.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVListeDocSecure.Name = "GVListeDocSecure"
        Me.GVListeDocSecure.OptionsBehavior.Editable = False
        Me.GVListeDocSecure.OptionsBehavior.ReadOnly = True
        Me.GVListeDocSecure.OptionsCustomization.AllowGroup = False
        Me.GVListeDocSecure.OptionsPrint.PrintPreview = True
        Me.GVListeDocSecure.OptionsView.ColumnAutoWidth = False
        Me.GVListeDocSecure.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListeDocSecure.OptionsView.EnableAppearanceOddRow = True
        Me.GVListeDocSecure.OptionsView.ShowAutoFilterRow = True
        Me.GVListeDocSecure.OptionsView.ShowFooter = True
        Me.GVListeDocSecure.OptionsView.ShowGroupPanel = False
        '
        'GCol_NIDACTDOCSECURE
        '
        Me.GCol_NIDACTDOCSECURE.Caption = "NIDACTDOCSECURE"
        Me.GCol_NIDACTDOCSECURE.FieldName = "NIDACTDOCSECURE"
        Me.GCol_NIDACTDOCSECURE.Name = "GCol_NIDACTDOCSECURE"
        Me.GCol_NIDACTDOCSECURE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_NIDACTDOCSECURE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.GCol_NIDACTDOCSECURE.Width = 50
        '
        'GCol_NACTNUM
        '
        Me.GCol_NACTNUM.Caption = "NACTNUM"
        Me.GCol_NACTNUM.FieldName = "NACTNUM"
        Me.GCol_NACTNUM.Name = "GCol_NACTNUM"
        Me.GCol_NACTNUM.Width = 69
        '
        'GCol_VFILE
        '
        Me.GCol_VFILE.Caption = "VFILE"
        Me.GCol_VFILE.FieldName = "VFILE"
        Me.GCol_VFILE.Name = "GCol_VFILE"
        Me.GCol_VFILE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_VFILE.Width = 110
        '
        'GCol_NQUICREE
        '
        Me.GCol_NQUICREE.Caption = "NQUICREE"
        Me.GCol_NQUICREE.FieldName = "NQUICREE"
        Me.GCol_NQUICREE.Name = "GCol_NQUICREE"
        Me.GCol_NQUICREE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GCol_VFILENAME
        '
        Me.GCol_VFILENAME.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VFILENAME.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VFILENAME.Caption = "Nom du fichier"
        Me.GCol_VFILENAME.FieldName = "VFILENAME"
        Me.GCol_VFILENAME.Name = "GCol_VFILENAME"
        Me.GCol_VFILENAME.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_VFILENAME.Visible = True
        Me.GCol_VFILENAME.VisibleIndex = 0
        Me.GCol_VFILENAME.Width = 250
        '
        'GCol_VFILEDESCRIPT
        '
        Me.GCol_VFILEDESCRIPT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VFILEDESCRIPT.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VFILEDESCRIPT.Caption = "Description"
        Me.GCol_VFILEDESCRIPT.FieldName = "VFILEDESCRIPT"
        Me.GCol_VFILEDESCRIPT.Name = "GCol_VFILEDESCRIPT"
        Me.GCol_VFILEDESCRIPT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_VFILEDESCRIPT.Visible = True
        Me.GCol_VFILEDESCRIPT.VisibleIndex = 1
        Me.GCol_VFILEDESCRIPT.Width = 250
        '
        'GCol_DQUICREE
        '
        Me.GCol_DQUICREE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_DQUICREE.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_DQUICREE.Caption = "Date création"
        Me.GCol_DQUICREE.FieldName = "DQUICREE"
        Me.GCol_DQUICREE.Name = "GCol_DQUICREE"
        Me.GCol_DQUICREE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_DQUICREE.Visible = True
        Me.GCol_DQUICREE.VisibleIndex = 2
        Me.GCol_DQUICREE.Width = 154
        '
        'GCol_VPRENOM_CREE
        '
        Me.GCol_VPRENOM_CREE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VPRENOM_CREE.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VPRENOM_CREE.Caption = "Qui créé"
        Me.GCol_VPRENOM_CREE.FieldName = "VPRENOM_CREE"
        Me.GCol_VPRENOM_CREE.Name = "GCol_VPRENOM_CREE"
        Me.GCol_VPRENOM_CREE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_VPRENOM_CREE.Visible = True
        Me.GCol_VPRENOM_CREE.VisibleIndex = 3
        Me.GCol_VPRENOM_CREE.Width = 150
        '
        'GCol_NQUIMODIF
        '
        Me.GCol_NQUIMODIF.Caption = "NQUIMODIF"
        Me.GCol_NQUIMODIF.FieldName = "NQUIMODIF"
        Me.GCol_NQUIMODIF.Name = "GCol_NQUIMODIF"
        Me.GCol_NQUIMODIF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GCol_DQUIMODIF
        '
        Me.GCol_DQUIMODIF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_DQUIMODIF.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_DQUIMODIF.Caption = "Date dernière modif"
        Me.GCol_DQUIMODIF.FieldName = "DQUIMODIF"
        Me.GCol_DQUIMODIF.Name = "GCol_DQUIMODIF"
        Me.GCol_DQUIMODIF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_DQUIMODIF.Visible = True
        Me.GCol_DQUIMODIF.VisibleIndex = 4
        Me.GCol_DQUIMODIF.Width = 150
        '
        'GCol_VPRENOM_MOD
        '
        Me.GCol_VPRENOM_MOD.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VPRENOM_MOD.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VPRENOM_MOD.Caption = "Qui modif"
        Me.GCol_VPRENOM_MOD.FieldName = "VPRENOM_MOD"
        Me.GCol_VPRENOM_MOD.Name = "GCol_VPRENOM_MOD"
        Me.GCol_VPRENOM_MOD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_VPRENOM_MOD.Visible = True
        Me.GCol_VPRENOM_MOD.VisibleIndex = 5
        Me.GCol_VPRENOM_MOD.Width = 150
        '
        'GCol_PATH_ACT_DOC_SECURE
        '
        Me.GCol_PATH_ACT_DOC_SECURE.Caption = "PATH_ACT_DOC_SECURE"
        Me.GCol_PATH_ACT_DOC_SECURE.FieldName = "PATH_ACT_DOC_SECURE"
        Me.GCol_PATH_ACT_DOC_SECURE.Name = "GCol_PATH_ACT_DOC_SECURE"
        Me.GCol_PATH_ACT_DOC_SECURE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_PATH_ACT_DOC_SECURE.Width = 213
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelTitre.Location = New System.Drawing.Point(111, 21)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(408, 29)
        Me.LabelTitre.TabIndex = 47
        Me.LabelTitre.Text = "Liste des documents confidentiels"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonSupp)
        Me.GroupBox1.Controls.Add(Me.ButtonDetails)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnAjouter)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(87, 865)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'ButtonSupp
        '
        Me.ButtonSupp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonSupp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonSupp.Location = New System.Drawing.Point(6, 191)
        Me.ButtonSupp.Name = "ButtonSupp"
        Me.ButtonSupp.Size = New System.Drawing.Size(75, 48)
        Me.ButtonSupp.TabIndex = 38
        Me.ButtonSupp.Text = "Supprimer"
        Me.ButtonSupp.UseVisualStyleBackColor = True
        '
        'ButtonDetails
        '
        Me.ButtonDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonDetails.Location = New System.Drawing.Point(7, 120)
        Me.ButtonDetails.Name = "ButtonDetails"
        Me.ButtonDetails.Size = New System.Drawing.Size(75, 48)
        Me.ButtonDetails.TabIndex = 37
        Me.ButtonDetails.Text = "Détails"
        Me.ButtonDetails.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(5, 761)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnAjouter
        '
        Me.BtnAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAjouter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnAjouter.Location = New System.Drawing.Point(7, 50)
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.Size = New System.Drawing.Size(74, 48)
        Me.BtnAjouter.TabIndex = 0
        Me.BtnAjouter.Text = "Ajouter"
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'frmDocSecureAct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1678, 964)
        Me.Controls.Add(Me.GCListeDocSecure)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.WebBrowser)
        Me.Name = "frmDocSecureAct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Liste des documents confidentiels"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCListeDocSecure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeDocSecure, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents WebBrowser As WebBrowser
    Private WithEvents GCListeDocSecure As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeDocSecure As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCol_NIDACTDOCSECURE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCol_NACTNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCol_VFILE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCol_NQUICREE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCol_VPRENOM_CREE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCol_DQUICREE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCol_VFILEDESCRIPT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCol_VFILENAME As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCol_NQUIMODIF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCol_VPRENOM_MOD As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCol_DQUIMODIF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCol_PATH_ACT_DOC_SECURE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelTitre As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonSupp As Button
    Friend WithEvents ButtonDetails As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnAjouter As Button
End Class
