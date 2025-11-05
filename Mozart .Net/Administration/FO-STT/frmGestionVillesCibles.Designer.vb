<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionVillesCibles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionVillesCibles))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnEnreg = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRegion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CVille = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIntervention = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LabelNomSTT = New System.Windows.Forms.Label()
        Me.LabelPays = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.webView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.webView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnEnreg)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cID, Me.CRegion, Me.CVille, Me.CIntervention})
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        '
        'cID
        '
        resources.ApplyResources(Me.cID, "cID")
        Me.cID.Name = "cID"
        '
        'CRegion
        '
        Me.CRegion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRegion.DefaultCellStyle = DataGridViewCellStyle8
        Me.CRegion.FillWeight = 180.0!
        resources.ApplyResources(Me.CRegion, "CRegion")
        Me.CRegion.Name = "CRegion"
        Me.CRegion.ReadOnly = True
        Me.CRegion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CVille
        '
        Me.CVille.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CVille.DefaultCellStyle = DataGridViewCellStyle9
        Me.CVille.FillWeight = 200.0!
        resources.ApplyResources(Me.CVille, "CVille")
        Me.CVille.Name = "CVille"
        Me.CVille.ReadOnly = True
        Me.CVille.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CIntervention
        '
        Me.CIntervention.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CIntervention.FalseValue = "0"
        Me.CIntervention.FillWeight = 180.0!
        resources.ApplyResources(Me.CIntervention, "CIntervention")
        Me.CIntervention.Name = "CIntervention"
        Me.CIntervention.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CIntervention.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CIntervention.TrueValue = "1"
        '
        'LabelNomSTT
        '
        resources.ApplyResources(Me.LabelNomSTT, "LabelNomSTT")
        Me.LabelNomSTT.Name = "LabelNomSTT"
        '
        'LabelPays
        '
        resources.ApplyResources(Me.LabelPays, "LabelPays")
        Me.LabelPays.ForeColor = System.Drawing.Color.Blue
        Me.LabelPays.Name = "LabelPays"
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'TextBox2
        '
        resources.ApplyResources(Me.TextBox2, "TextBox2")
        Me.TextBox2.Name = "TextBox2"
        '
        'webView21
        '
        Me.webView21.AllowExternalDrop = True
        resources.ApplyResources(Me.webView21, "webView21")
        Me.webView21.BackColor = System.Drawing.Color.White
        Me.webView21.CreationProperties = Nothing
        Me.webView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.webView21.Name = "webView21"
        Me.webView21.ZoomFactor = 1.0R
        '
        'frmGestionVillesCibles
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.webView21)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelPays)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LabelNomSTT)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "frmGestionVillesCibles"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.webView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents BtnEnreg As System.Windows.Forms.Button
  Friend WithEvents LabelTitre As System.Windows.Forms.Label
  Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
  Friend WithEvents LabelNomSTT As System.Windows.Forms.Label
  Friend WithEvents LabelPays As System.Windows.Forms.Label
  Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
  Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents cID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CRegion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CVille As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CIntervention As System.Windows.Forms.DataGridViewCheckBoxColumn
    Private WithEvents webView21 As Microsoft.Web.WebView2.WinForms.WebView2
End Class
