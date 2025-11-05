<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class apiTooltip
  Inherits System.Windows.Forms.UserControl

  'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(apiTooltip))
    Me.cmdClose = New System.Windows.Forms.Button()
    Me.cmdInfo = New System.Windows.Forms.Button()
    Me.lblTitre = New System.Windows.Forms.Label()
    Me.txtTexte = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'cmdClose
    '
    resources.ApplyResources(Me.cmdClose, "cmdClose")
    Me.cmdClose.BackColor = System.Drawing.Color.Red
    Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Red
    Me.cmdClose.FlatAppearance.BorderSize = 0
    Me.cmdClose.ForeColor = System.Drawing.Color.White
    Me.cmdClose.Name = "cmdClose"
    Me.cmdClose.UseCompatibleTextRendering = True
    Me.cmdClose.UseVisualStyleBackColor = False
    '
    'cmdInfo
    '
    resources.ApplyResources(Me.cmdInfo, "cmdInfo")
    Me.cmdInfo.BackColor = System.Drawing.Color.DarkBlue
    Me.cmdInfo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
    Me.cmdInfo.ForeColor = System.Drawing.Color.White
    Me.cmdInfo.Name = "cmdInfo"
    Me.cmdInfo.UseVisualStyleBackColor = False
    '
    'lblTitre
    '
    resources.ApplyResources(Me.lblTitre, "lblTitre")
    Me.lblTitre.BackColor = System.Drawing.Color.SteelBlue
    Me.lblTitre.Name = "lblTitre"
    '
    'txtTexte
    '
    resources.ApplyResources(Me.txtTexte, "txtTexte")
    Me.txtTexte.BackColor = System.Drawing.Color.LightGoldenrodYellow
    Me.txtTexte.Name = "txtTexte"
    '
    'apiTooltip
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.SteelBlue
    Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Controls.Add(Me.cmdClose)
    Me.Controls.Add(Me.cmdInfo)
    Me.Controls.Add(Me.txtTexte)
    Me.Controls.Add(Me.lblTitre)
    Me.Name = "apiTooltip"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents cmdClose As Windows.Forms.Button
  Public WithEvents cmdInfo As Windows.Forms.Button
  Friend WithEvents lblTitre As Windows.Forms.Label
  Friend WithEvents txtTexte As Windows.Forms.TextBox
End Class
