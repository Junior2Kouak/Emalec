<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatEMALEC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatEMALEC))
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonExporter = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Libellé = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Valeur = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtValider = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSociete = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonExporter)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnPrint)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'ButtonExporter
        '
        resources.ApplyResources(Me.ButtonExporter, "ButtonExporter")
        Me.ButtonExporter.Name = "ButtonExporter"
        Me.ButtonExporter.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'GridControl1
        '
        resources.ApplyResources(Me.GridControl1, "GridControl1")
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Libellé, Me.Valeur})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsPrint.PrintFilterInfo = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Libellé
        '
        Me.Libellé.AppearanceCell.Font = CType(resources.GetObject("Libellé.AppearanceCell.Font"), System.Drawing.Font)
        Me.Libellé.AppearanceCell.Options.UseFont = True
        Me.Libellé.AppearanceHeader.Font = CType(resources.GetObject("Libellé.AppearanceHeader.Font"), System.Drawing.Font)
        Me.Libellé.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Libellé.AppearanceHeader.Options.UseFont = True
        Me.Libellé.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Libellé, "Libellé")
        Me.Libellé.FieldName = "LIBELLE"
        Me.Libellé.MinWidth = 200
        Me.Libellé.Name = "Libellé"
        Me.Libellé.OptionsColumn.AllowEdit = False
        Me.Libellé.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("Libellé.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'Valeur
        '
        Me.Valeur.AppearanceCell.Font = CType(resources.GetObject("Valeur.AppearanceCell.Font"), System.Drawing.Font)
        Me.Valeur.AppearanceCell.Options.UseFont = True
        Me.Valeur.AppearanceHeader.Font = CType(resources.GetObject("Valeur.AppearanceHeader.Font"), System.Drawing.Font)
        Me.Valeur.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Valeur.AppearanceHeader.Options.UseFont = True
        Me.Valeur.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Valeur, "Valeur")
        Me.Valeur.DisplayFormat.FormatString = "n0"
        Me.Valeur.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Valeur.FieldName = "VALEUR"
        Me.Valeur.MinWidth = 100
        Me.Valeur.Name = "Valeur"
        Me.Valeur.OptionsColumn.AllowEdit = False
        '
        'lblClient
        '
        Me.lblClient.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblClient, "lblClient")
        Me.lblClient.ForeColor = System.Drawing.Color.Black
        Me.lblClient.Name = "lblClient"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'BtValider
        '
        resources.ApplyResources(Me.BtValider, "BtValider")
        Me.BtValider.Name = "BtValider"
        Me.BtValider.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'cboSociete
        '
        Me.cboSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboSociete, "cboSociete")
        Me.cboSociete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboSociete.FormattingEnabled = True
        Me.cboSociete.Name = "cboSociete"
        Me.cboSociete.Tag = "45"
        '
        'frmStatEMALEC
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.cboSociete)
        Me.Controls.Add(Me.BtValider)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblClient)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "frmStatEMALEC"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents BtnPrint As System.Windows.Forms.Button
  Friend WithEvents ButtonExporter As System.Windows.Forms.Button
  Friend WithEvents lblClient As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents BtValider As System.Windows.Forms.Button
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Private WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents Libellé As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents Valeur As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents cboSociete As System.Windows.Forms.ComboBox
End Class
