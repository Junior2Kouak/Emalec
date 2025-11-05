<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestSiteLie
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
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.cmdFermer = New MozartUC.apiButton()
        Me.cmdAjoutLiaison = New MozartUC.apiButton()
        Me.apiGrid = New MozartUC.apiTGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCacherPanel = New MozartUC.apiButton()
        Me.cmdCopierSite = New MozartUC.apiButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboSociete = New System.Windows.Forms.ComboBox()
        Me.CmdRechercherSite = New MozartUC.apiButton()
        Me.PanelSite = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdLierSite = New MozartUC.apiButton()
        Me.cmdFermerPanelSite = New MozartUC.apiButton()
        Me.ApiGridSite = New MozartUC.apiTGrid()
        Me.cmdSupprimer = New MozartUC.apiButton()
        Me.Panel1.SuspendLayout()
        Me.PanelSite.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        Me.LblTitre.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(12, 9)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(701, 29)
        Me.LblTitre.TabIndex = 34
        Me.LblTitre.Text = "Gestion des liaisons du site : "
        '
        'cmdFermer
        '
        Me.cmdFermer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdFermer.HelpContextID = 0
        Me.cmdFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFermer.Location = New System.Drawing.Point(12, 452)
        Me.cmdFermer.Name = "cmdFermer"
        Me.cmdFermer.Size = New System.Drawing.Size(73, 57)
        Me.cmdFermer.TabIndex = 33
        Me.cmdFermer.Tag = "15"
        Me.cmdFermer.Text = "Fermer"
        Me.cmdFermer.UseVisualStyleBackColor = True
        '
        'cmdAjoutLiaison
        '
        Me.cmdAjoutLiaison.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdAjoutLiaison.HelpContextID = 0
        Me.cmdAjoutLiaison.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAjoutLiaison.Location = New System.Drawing.Point(12, 41)
        Me.cmdAjoutLiaison.Name = "cmdAjoutLiaison"
        Me.cmdAjoutLiaison.Size = New System.Drawing.Size(73, 49)
        Me.cmdAjoutLiaison.TabIndex = 32
        Me.cmdAjoutLiaison.Tag = "2"
        Me.cmdAjoutLiaison.Text = "Ajouter"
        Me.cmdAjoutLiaison.UseVisualStyleBackColor = True
        '
        'apiGrid
        '
        Me.apiGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.apiGrid.FilterBar = True
        Me.apiGrid.FooterBar = True
        Me.apiGrid.Location = New System.Drawing.Point(101, 41)
        Me.apiGrid.Name = "apiGrid"
        Me.apiGrid.Size = New System.Drawing.Size(592, 468)
        Me.apiGrid.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdCacherPanel)
        Me.Panel1.Controls.Add(Me.cmdCopierSite)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CboSociete)
        Me.Panel1.Controls.Add(Me.CmdRechercherSite)
        Me.Panel1.Location = New System.Drawing.Point(149, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(293, 311)
        Me.Panel1.TabIndex = 35
        Me.Panel1.Visible = False
        '
        'cmdCacherPanel
        '
        Me.cmdCacherPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdCacherPanel.HelpContextID = 0
        Me.cmdCacherPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCacherPanel.Location = New System.Drawing.Point(147, 247)
        Me.cmdCacherPanel.Name = "cmdCacherPanel"
        Me.cmdCacherPanel.Size = New System.Drawing.Size(89, 34)
        Me.cmdCacherPanel.TabIndex = 34
        Me.cmdCacherPanel.Tag = "2"
        Me.cmdCacherPanel.Text = "Fermer"
        Me.cmdCacherPanel.UseVisualStyleBackColor = True
        '
        'cmdCopierSite
        '
        Me.cmdCopierSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdCopierSite.HelpContextID = 0
        Me.cmdCopierSite.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCopierSite.Location = New System.Drawing.Point(19, 159)
        Me.cmdCopierSite.Name = "cmdCopierSite"
        Me.cmdCopierSite.Size = New System.Drawing.Size(217, 57)
        Me.cmdCopierSite.TabIndex = 33
        Me.cmdCopierSite.Tag = "2"
        Me.cmdCopierSite.Text = "Copier ce site sur le client lié dans la filiale"
        Me.cmdCopierSite.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 21)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Filiale"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CboSociete
        '
        Me.CboSociete.DisplayMember = "VSOCIETENOM"
        Me.CboSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSociete.FormattingEnabled = True
        Me.CboSociete.Location = New System.Drawing.Point(19, 40)
        Me.CboSociete.Name = "CboSociete"
        Me.CboSociete.Size = New System.Drawing.Size(245, 21)
        Me.CboSociete.TabIndex = 31
        Me.CboSociete.ValueMember = "NSOCIETEID"
        '
        'CmdRechercherSite
        '
        Me.CmdRechercherSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CmdRechercherSite.HelpContextID = 0
        Me.CmdRechercherSite.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmdRechercherSite.Location = New System.Drawing.Point(19, 86)
        Me.CmdRechercherSite.Name = "CmdRechercherSite"
        Me.CmdRechercherSite.Size = New System.Drawing.Size(217, 57)
        Me.CmdRechercherSite.TabIndex = 30
        Me.CmdRechercherSite.Tag = "2"
        Me.CmdRechercherSite.Text = "Rechercher un site sur le client lié dans la filiale"
        Me.CmdRechercherSite.UseVisualStyleBackColor = True
        '
        'PanelSite
        '
        Me.PanelSite.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelSite.Controls.Add(Me.Label2)
        Me.PanelSite.Controls.Add(Me.cmdLierSite)
        Me.PanelSite.Controls.Add(Me.cmdFermerPanelSite)
        Me.PanelSite.Controls.Add(Me.ApiGridSite)
        Me.PanelSite.Location = New System.Drawing.Point(475, 25)
        Me.PanelSite.Name = "PanelSite"
        Me.PanelSite.Size = New System.Drawing.Size(944, 516)
        Me.PanelSite.TabIndex = 36
        Me.PanelSite.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(3, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(701, 29)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Liste des sites du client lié dans la filiale"
        '
        'cmdLierSite
        '
        Me.cmdLierSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdLierSite.HelpContextID = 0
        Me.cmdLierSite.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLierSite.Location = New System.Drawing.Point(7, 94)
        Me.cmdLierSite.Name = "cmdLierSite"
        Me.cmdLierSite.Size = New System.Drawing.Size(69, 51)
        Me.cmdLierSite.TabIndex = 36
        Me.cmdLierSite.Tag = "2"
        Me.cmdLierSite.Text = "Lier le site"
        Me.cmdLierSite.UseVisualStyleBackColor = True
        '
        'cmdFermerPanelSite
        '
        Me.cmdFermerPanelSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdFermerPanelSite.HelpContextID = 0
        Me.cmdFermerPanelSite.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFermerPanelSite.Location = New System.Drawing.Point(7, 456)
        Me.cmdFermerPanelSite.Name = "cmdFermerPanelSite"
        Me.cmdFermerPanelSite.Size = New System.Drawing.Size(69, 45)
        Me.cmdFermerPanelSite.TabIndex = 35
        Me.cmdFermerPanelSite.Tag = "2"
        Me.cmdFermerPanelSite.Text = "Fermer"
        Me.cmdFermerPanelSite.UseVisualStyleBackColor = True
        '
        'ApiGridSite
        '
        Me.ApiGridSite.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApiGridSite.FilterBar = True
        Me.ApiGridSite.FooterBar = True
        Me.ApiGridSite.Location = New System.Drawing.Point(79, 46)
        Me.ApiGridSite.Name = "ApiGridSite"
        Me.ApiGridSite.Size = New System.Drawing.Size(850, 455)
        Me.ApiGridSite.TabIndex = 32
        '
        'cmdSupprimer
        '
        Me.cmdSupprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdSupprimer.HelpContextID = 0
        Me.cmdSupprimer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSupprimer.Location = New System.Drawing.Point(12, 96)
        Me.cmdSupprimer.Name = "cmdSupprimer"
        Me.cmdSupprimer.Size = New System.Drawing.Size(73, 49)
        Me.cmdSupprimer.TabIndex = 37
        Me.cmdSupprimer.Tag = "2"
        Me.cmdSupprimer.Text = "Supprimer"
        Me.cmdSupprimer.UseVisualStyleBackColor = True
        '
        'frmGestSiteLie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1080, 600)
        Me.Controls.Add(Me.PanelSite)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.cmdFermer)
        Me.Controls.Add(Me.apiGrid)
        Me.Controls.Add(Me.cmdAjoutLiaison)
        Me.Controls.Add(Me.cmdSupprimer)
        Me.Name = "frmGestSiteLie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion des liaisons du site"
        Me.Panel1.ResumeLayout(False)
        Me.PanelSite.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblTitre As Label
    Private WithEvents cmdFermer As MozartUC.apiButton
    Private WithEvents cmdAjoutLiaison As MozartUC.apiButton
    Friend WithEvents apiGrid As MozartUC.apiTGrid
    Friend WithEvents Panel1 As Panel
    Private WithEvents cmdCopierSite As MozartUC.apiButton
    Friend WithEvents Label1 As Label
    Friend WithEvents CboSociete As ComboBox
    Private WithEvents CmdRechercherSite As MozartUC.apiButton
    Private WithEvents cmdCacherPanel As MozartUC.apiButton
    Friend WithEvents PanelSite As Panel
    Friend WithEvents ApiGridSite As MozartUC.apiTGrid
    Friend WithEvents Label2 As Label
    Private WithEvents cmdLierSite As MozartUC.apiButton
    Private WithEvents cmdFermerPanelSite As MozartUC.apiButton
    Private WithEvents cmdSupprimer As MozartUC.apiButton
End Class
