<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestClientLie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestClientLie))
        Me.cmdFermer = New MozartUC.apiButton()
        Me.cmdNouvelle = New MozartUC.apiButton()
        Me.apiGrid = New MozartUC.apiTGrid()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.cmdGammes = New MozartUC.apiButton()
        Me.SuspendLayout()
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
        'cmdNouvelle
        '
        resources.ApplyResources(Me.cmdNouvelle, "cmdNouvelle")
        Me.cmdNouvelle.HelpContextID = 0
        Me.cmdNouvelle.Name = "cmdNouvelle"
        Me.cmdNouvelle.Tag = "2"
        Me.cmdNouvelle.UseVisualStyleBackColor = True
        '
        'apiGrid
        '
        resources.ApplyResources(Me.apiGrid, "apiGrid")
        Me.apiGrid.FilterBar = True
        Me.apiGrid.FooterBar = True
        Me.apiGrid.Name = "apiGrid"
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'cmdGammes
        '
        resources.ApplyResources(Me.cmdGammes, "cmdGammes")
        Me.cmdGammes.HelpContextID = 0
        Me.cmdGammes.Name = "cmdGammes"
        Me.cmdGammes.Tag = ""
        Me.cmdGammes.UseVisualStyleBackColor = True
        '
        'frmGestClientLie
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.cmdGammes)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.cmdFermer)
        Me.Controls.Add(Me.cmdNouvelle)
        Me.Controls.Add(Me.apiGrid)
        Me.Name = "frmGestClientLie"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents apiGrid As MozartUC.apiTGrid
    Private WithEvents cmdNouvelle As MozartUC.apiButton
    Private WithEvents cmdFermer As MozartUC.apiButton
    Friend WithEvents LblTitre As Label
    Private WithEvents cmdGammes As MozartUC.apiButton
End Class
