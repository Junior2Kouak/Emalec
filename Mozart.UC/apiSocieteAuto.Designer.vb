<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class apiSocieteAuto
  Inherits System.Windows.Forms.UserControl

  'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(apiSocieteAuto))
    Me.Combo1 = New System.Windows.Forms.ComboBox()
    Me.LblSociete = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Combo1
        '
        Me.Combo1.FormattingEnabled = True
        resources.ApplyResources(Me.Combo1, "Combo1")
        Me.Combo1.Name = "Combo1"
        '
        'LblSociete
        '
        resources.ApplyResources(Me.LblSociete, "LblSociete")
        Me.LblSociete.Name = "LblSociete"
        '
        'apiSocieteAuto
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LblSociete)
        Me.Controls.Add(Me.Combo1)
        Me.Name = "apiSocieteAuto"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Combo1 As Windows.Forms.ComboBox
  Friend WithEvents LblSociete As Windows.Forms.Label
End Class
