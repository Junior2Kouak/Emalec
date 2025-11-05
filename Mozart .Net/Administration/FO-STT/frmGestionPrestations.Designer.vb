<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionPrestations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionPrestations))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnEnreg = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.LabelNomSTT = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCategorie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPrestation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEtudes = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CInstallation = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CMaintPrev = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CDepannage = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CAstreinte = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CCategorie2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnEnreg)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnEnreg
        '
        resources.ApplyResources(Me.BtnEnreg, "BtnEnreg")
        Me.BtnEnreg.Name = "BtnEnreg"
        Me.BtnEnreg.UseVisualStyleBackColor = True
        '
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'LabelNomSTT
        '
        resources.ApplyResources(Me.LabelNomSTT, "LabelNomSTT")
        Me.LabelNomSTT.Name = "LabelNomSTT"
        '
        'DataGridView1
        '
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cID, Me.CCategorie, Me.CPrestation, Me.CEtudes, Me.CInstallation, Me.CMaintPrev, Me.CDepannage, Me.CAstreinte, Me.CCategorie2})
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        '
        'cID
        '
        resources.ApplyResources(Me.cID, "cID")
        Me.cID.Name = "cID"
        '
        'CCategorie
        '
        Me.CCategorie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCategorie.DefaultCellStyle = DataGridViewCellStyle2
        Me.CCategorie.FillWeight = 200.0!
        resources.ApplyResources(Me.CCategorie, "CCategorie")
        Me.CCategorie.Name = "CCategorie"
        Me.CCategorie.ReadOnly = True
        Me.CCategorie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CPrestation
        '
        Me.CPrestation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPrestation.DefaultCellStyle = DataGridViewCellStyle3
        Me.CPrestation.FillWeight = 300.0!
        resources.ApplyResources(Me.CPrestation, "CPrestation")
        Me.CPrestation.Name = "CPrestation"
        Me.CPrestation.ReadOnly = True
        Me.CPrestation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CEtudes
        '
        Me.CEtudes.FalseValue = "0"
        resources.ApplyResources(Me.CEtudes, "CEtudes")
        Me.CEtudes.Name = "CEtudes"
        Me.CEtudes.TrueValue = "1"
        '
        'CInstallation
        '
        Me.CInstallation.FalseValue = "0"
        resources.ApplyResources(Me.CInstallation, "CInstallation")
        Me.CInstallation.Name = "CInstallation"
        Me.CInstallation.TrueValue = "1"
        '
        'CMaintPrev
        '
        Me.CMaintPrev.FalseValue = "0"
        resources.ApplyResources(Me.CMaintPrev, "CMaintPrev")
        Me.CMaintPrev.Name = "CMaintPrev"
        Me.CMaintPrev.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CMaintPrev.TrueValue = "1"
        '
        'CDepannage
        '
        Me.CDepannage.FalseValue = "0"
        resources.ApplyResources(Me.CDepannage, "CDepannage")
        Me.CDepannage.Name = "CDepannage"
        Me.CDepannage.TrueValue = "1"
        '
        'CAstreinte
        '
        Me.CAstreinte.FalseValue = "0"
        resources.ApplyResources(Me.CAstreinte, "CAstreinte")
        Me.CAstreinte.Name = "CAstreinte"
        Me.CAstreinte.TrueValue = "1"
        '
        'CCategorie2
        '
        resources.ApplyResources(Me.CCategorie2, "CCategorie2")
        Me.CCategorie2.Name = "CCategorie2"
        '
        'frmGestionPrestations
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LabelNomSTT)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "frmGestionPrestations"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents BtnEnreg As System.Windows.Forms.Button
  Friend WithEvents LabelTitre As System.Windows.Forms.Label
  Friend WithEvents LabelNomSTT As System.Windows.Forms.Label
  Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
  Friend WithEvents cID As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CCategorie As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CPrestation As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CEtudes As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents CInstallation As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents CMaintPrev As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents CDepannage As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents CAstreinte As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents CCategorie2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
