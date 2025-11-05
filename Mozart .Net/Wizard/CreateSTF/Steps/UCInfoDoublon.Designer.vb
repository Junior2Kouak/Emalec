<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCInfoDoublon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCInfoDoublon))
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.LstDoublon = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.ForeColor = System.Drawing.Color.DarkGreen
        Me.LblTitre.Name = "LblTitre"
        '
        'LstDoublon
        '
        resources.ApplyResources(Me.LstDoublon, "LstDoublon")
        Me.LstDoublon.BackColor = System.Drawing.Color.PaleGreen
        Me.LstDoublon.FormattingEnabled = True
        Me.LstDoublon.Name = "LstDoublon"
        '
        'UCInfoDoublon
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Controls.Add(Me.LstDoublon)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "UCInfoDoublon"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents LstDoublon As System.Windows.Forms.ListBox

End Class
