<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestGammeLie
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
    Me.cmdCopierGamme = New MozartUC.apiButton()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.CboGamClientOrigine = New System.Windows.Forms.ComboBox()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.cmdFermer = New MozartUC.apiButton()
    Me.cmdSupprimer = New MozartUC.apiButton()
    Me.cmdLierGamme = New MozartUC.apiButton()
    Me.apiGrid = New MozartUC.apiTGrid()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.cboGamClientDest = New System.Windows.Forms.ComboBox()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.SuspendLayout()
    '
    'cmdCopierGamme
    '
    Me.cmdCopierGamme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.cmdCopierGamme.ForeColor = System.Drawing.Color.Black
    Me.cmdCopierGamme.HelpContextID = 0
    Me.cmdCopierGamme.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.cmdCopierGamme.Location = New System.Drawing.Point(15, 99)
    Me.cmdCopierGamme.Name = "cmdCopierGamme"
    Me.cmdCopierGamme.Size = New System.Drawing.Size(128, 48)
    Me.cmdCopierGamme.TabIndex = 33
    Me.cmdCopierGamme.Tag = "2"
    Me.cmdCopierGamme.Text = "Copier la gamme sur le client lié "
    Me.cmdCopierGamme.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
    Me.Label1.ForeColor = System.Drawing.Color.Black
    Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.Label1.Location = New System.Drawing.Point(11, 38)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(249, 21)
    Me.Label1.TabIndex = 32
    Me.Label1.Text = "Gammes du client d'origine"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'CboGamClientOrigine
    '
    Me.CboGamClientOrigine.DisplayMember = "VGAMTYPE"
    Me.CboGamClientOrigine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CboGamClientOrigine.FormattingEnabled = True
    Me.CboGamClientOrigine.Location = New System.Drawing.Point(15, 62)
    Me.CboGamClientOrigine.Name = "CboGamClientOrigine"
    Me.CboGamClientOrigine.Size = New System.Drawing.Size(313, 23)
    Me.CboGamClientOrigine.TabIndex = 31
    Me.CboGamClientOrigine.ValueMember = "NTRACLINUM"
    '
    'LblTitre
    '
    Me.LblTitre.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.LblTitre.Location = New System.Drawing.Point(92, 9)
    Me.LblTitre.Name = "LblTitre"
    Me.LblTitre.Size = New System.Drawing.Size(701, 29)
    Me.LblTitre.TabIndex = 41
    Me.LblTitre.Text = "Gestion des liaisons des gammes des clients liés "
    '
    'cmdFermer
    '
    Me.cmdFermer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.cmdFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.cmdFermer.HelpContextID = 0
    Me.cmdFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.cmdFermer.Location = New System.Drawing.Point(8, 442)
    Me.cmdFermer.Name = "cmdFermer"
    Me.cmdFermer.Size = New System.Drawing.Size(82, 52)
    Me.cmdFermer.TabIndex = 40
    Me.cmdFermer.Tag = "15"
    Me.cmdFermer.Text = "Fermer"
    Me.cmdFermer.UseVisualStyleBackColor = True
    '
    'cmdSupprimer
    '
    Me.cmdSupprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.cmdSupprimer.HelpContextID = 0
    Me.cmdSupprimer.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.cmdSupprimer.Location = New System.Drawing.Point(8, 88)
    Me.cmdSupprimer.Name = "cmdSupprimer"
    Me.cmdSupprimer.Size = New System.Drawing.Size(82, 54)
    Me.cmdSupprimer.TabIndex = 44
    Me.cmdSupprimer.Tag = ""
    Me.cmdSupprimer.Text = "Supprimer le lien sélectionné"
    Me.cmdSupprimer.UseVisualStyleBackColor = True
    '
    'cmdLierGamme
    '
    Me.cmdLierGamme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.cmdLierGamme.ForeColor = System.Drawing.Color.Black
    Me.cmdLierGamme.HelpContextID = 0
    Me.cmdLierGamme.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.cmdLierGamme.Location = New System.Drawing.Point(349, 47)
    Me.cmdLierGamme.Name = "cmdLierGamme"
    Me.cmdLierGamme.Size = New System.Drawing.Size(107, 48)
    Me.cmdLierGamme.TabIndex = 45
    Me.cmdLierGamme.Tag = "2"
    Me.cmdLierGamme.Text = "Lier les gammes"
    Me.cmdLierGamme.UseVisualStyleBackColor = True
    '
    'apiGrid
    '
    Me.apiGrid.FilterBar = True
    Me.apiGrid.FooterBar = True
    Me.apiGrid.ForeColor = System.Drawing.Color.Black
    Me.apiGrid.Location = New System.Drawing.Point(7, 20)
    Me.apiGrid.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.apiGrid.Name = "apiGrid"
    Me.apiGrid.Size = New System.Drawing.Size(805, 257)
    Me.apiGrid.TabIndex = 38
    '
    'Label2
    '
    Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
    Me.Label2.ForeColor = System.Drawing.Color.Black
    Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.Label2.Location = New System.Drawing.Point(475, 38)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(270, 21)
    Me.Label2.TabIndex = 47
    Me.Label2.Text = "Gammes du client de destination"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'cboGamClientDest
    '
    Me.cboGamClientDest.DisplayMember = "VGAMTYPE"
    Me.cboGamClientDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboGamClientDest.FormattingEnabled = True
    Me.cboGamClientDest.Location = New System.Drawing.Point(479, 62)
    Me.cboGamClientDest.Name = "cboGamClientDest"
    Me.cboGamClientDest.Size = New System.Drawing.Size(313, 23)
    Me.cboGamClientDest.TabIndex = 46
    Me.cboGamClientDest.ValueMember = "NTRACLINUM"
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.Color.PapayaWhip
    Me.GroupBox1.Controls.Add(Me.cmdCopierGamme)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Controls.Add(Me.CboGamClientOrigine)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Controls.Add(Me.cmdLierGamme)
    Me.GroupBox1.Controls.Add(Me.cboGamClientDest)
    Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.GroupBox1.Location = New System.Drawing.Point(96, 341)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(819, 153)
    Me.GroupBox1.TabIndex = 48
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Ajout des  liaisons entre gammes"
    '
    'GroupBox2
    '
    Me.GroupBox2.BackColor = System.Drawing.Color.PapayaWhip
    Me.GroupBox2.Controls.Add(Me.apiGrid)
    Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.GroupBox2.Location = New System.Drawing.Point(96, 41)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(819, 285)
    Me.GroupBox2.TabIndex = 49
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Liste des gammes liées entre les deux clients"
    '
    'frmGestGammeLie
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.ClientSize = New System.Drawing.Size(945, 518)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.LblTitre)
    Me.Controls.Add(Me.cmdFermer)
    Me.Controls.Add(Me.cmdSupprimer)
    Me.Name = "frmGestGammeLie"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Gestion des liaisons des gammes des clients liés "
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Private WithEvents cmdCopierGamme As MozartUC.apiButton
  Friend WithEvents Label1 As Label
    Friend WithEvents CboGamClientOrigine As ComboBox
    Private WithEvents CmdRechercherSite As MozartUC.apiButton
    Friend WithEvents LblTitre As Label
    Private WithEvents cmdFermer As MozartUC.apiButton
    Private WithEvents cmdSupprimer As MozartUC.apiButton
    Private WithEvents cmdLierGamme As MozartUC.apiButton
    Friend WithEvents apiGrid As MozartUC.apiTGrid
    Friend WithEvents Label2 As Label
    Friend WithEvents cboGamClientDest As ComboBox
  Friend WithEvents GroupBox1 As GroupBox
  Friend WithEvents GroupBox2 As GroupBox
End Class
