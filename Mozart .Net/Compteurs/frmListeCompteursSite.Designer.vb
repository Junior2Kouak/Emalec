<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeCompteursSite
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeCompteursSite))
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.cmdFermer = New MozartUC.apiButton()
        Me.apiGridSite = New MozartUC.apiTGrid()
        Me.cmdAjout = New MozartUC.apiButton()
        Me.cmdSupprimer = New MozartUC.apiButton()
        Me.cmdModifier = New MozartUC.apiButton()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'cmdFermer
        '
        resources.ApplyResources(Me.cmdFermer, "cmdFermer")
        Me.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFermer.HelpContextID = 0
        Me.cmdFermer.Name = "cmdFermer"
        Me.cmdFermer.Tag = "15"
        Me.cmdFermer.UseVisualStyleBackColor = True
        '
        'apiGridSite
        '
        resources.ApplyResources(Me.apiGridSite, "apiGridSite")
        Me.apiGridSite.FilterBar = True
        Me.apiGridSite.FooterBar = True
        Me.apiGridSite.Name = "apiGridSite"
        '
        'cmdAjout
        '
        resources.ApplyResources(Me.cmdAjout, "cmdAjout")
        Me.cmdAjout.HelpContextID = 0
        Me.cmdAjout.Name = "cmdAjout"
        Me.cmdAjout.Tag = "2"
        Me.cmdAjout.UseVisualStyleBackColor = True
        '
        'cmdSupprimer
        '
        resources.ApplyResources(Me.cmdSupprimer, "cmdSupprimer")
        Me.cmdSupprimer.HelpContextID = 0
        Me.cmdSupprimer.Name = "cmdSupprimer"
        Me.cmdSupprimer.Tag = "2"
        Me.cmdSupprimer.UseVisualStyleBackColor = True
        '
        'cmdModifier
        '
        resources.ApplyResources(Me.cmdModifier, "cmdModifier")
        Me.cmdModifier.HelpContextID = 0
        Me.cmdModifier.Name = "cmdModifier"
        Me.cmdModifier.Tag = "2"
        Me.cmdModifier.UseVisualStyleBackColor = True
        '
        'frmListeCompteursSite
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.cmdModifier)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.cmdFermer)
        Me.Controls.Add(Me.apiGridSite)
        Me.Controls.Add(Me.cmdAjout)
        Me.Controls.Add(Me.cmdSupprimer)
        Me.Name = "frmListeCompteursSite"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblTitre As Label
    Private WithEvents cmdFermer As MozartUC.apiButton
    Friend WithEvents apiGridSite As MozartUC.apiTGrid
    Private WithEvents cmdAjout As MozartUC.apiButton
    Private WithEvents cmdSupprimer As MozartUC.apiButton
    Private WithEvents cmdModifier As MozartUC.apiButton
End Class
