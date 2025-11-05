<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatEnergie
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
        Me.cmdFermer = New System.Windows.Forms.Button()
        Me.cmdGestDomTech = New MozartUC.apiButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdFermer
        '
        Me.cmdFermer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdFermer.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFermer.Location = New System.Drawing.Point(12, 674)
        Me.cmdFermer.Name = "cmdFermer"
        Me.cmdFermer.Size = New System.Drawing.Size(84, 57)
        Me.cmdFermer.TabIndex = 7
        Me.cmdFermer.Text = "Fermer"
        Me.cmdFermer.UseVisualStyleBackColor = False
        '
        'cmdGestDomTech
        '
        Me.cmdGestDomTech.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdGestDomTech.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdGestDomTech.HelpContextID = 682
        Me.cmdGestDomTech.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGestDomTech.Location = New System.Drawing.Point(124, 114)
        Me.cmdGestDomTech.Name = "cmdGestDomTech"
        Me.cmdGestDomTech.Size = New System.Drawing.Size(116, 73)
        Me.cmdGestDomTech.TabIndex = 5
        Me.cmdGestDomTech.Text = "Relevés de compteur par client"
        Me.cmdGestDomTech.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(119, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Statistiques sur les énergies"
        '
        'frmStatEnergie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1524, 855)
        Me.Controls.Add(Me.cmdFermer)
        Me.Controls.Add(Me.cmdGestDomTech)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStatEnergie"
        Me.Text = "Statistiques Energies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cmdFermer As Button
    Private WithEvents cmdGestDomTech As MozartUC.apiButton
    Private WithEvents Label1 As Label
End Class
