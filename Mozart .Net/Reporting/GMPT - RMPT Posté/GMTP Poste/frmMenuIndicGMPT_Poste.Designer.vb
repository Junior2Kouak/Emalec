<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuIndicGMPT_Poste
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.BtnTauxDevis = New System.Windows.Forms.Button()
        Me.BtnDelaisMoyen = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(87, 542)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(6, 488)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        Me.LblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(105, 20)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(835, 30)
        Me.LblTitre.TabIndex = 71
        Me.LblTitre.Text = "GMPT Posté"
        '
        'BtnTauxDevis
        '
        Me.BtnTauxDevis.BackColor = System.Drawing.Color.LightGreen
        Me.BtnTauxDevis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTauxDevis.Location = New System.Drawing.Point(135, 78)
        Me.BtnTauxDevis.Name = "BtnTauxDevis"
        Me.BtnTauxDevis.Size = New System.Drawing.Size(106, 85)
        Me.BtnTauxDevis.TabIndex = 70
        Me.BtnTauxDevis.Tag = ""
        Me.BtnTauxDevis.Text = "Taux de transformation des devis"
        Me.BtnTauxDevis.UseVisualStyleBackColor = False
        '
        'BtnDelaisMoyen
        '
        Me.BtnDelaisMoyen.BackColor = System.Drawing.Color.LightGreen
        Me.BtnDelaisMoyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelaisMoyen.Location = New System.Drawing.Point(304, 78)
        Me.BtnDelaisMoyen.Name = "BtnDelaisMoyen"
        Me.BtnDelaisMoyen.Size = New System.Drawing.Size(106, 85)
        Me.BtnDelaisMoyen.TabIndex = 73
        Me.BtnDelaisMoyen.Tag = ""
        Me.BtnDelaisMoyen.Text = "Délais moyen "
        Me.BtnDelaisMoyen.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGreen
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(476, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 85)
        Me.Button2.TabIndex = 74
        Me.Button2.Tag = ""
        Me.Button2.Text = "Taux des préventifs "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightGreen
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(659, 78)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 85)
        Me.Button3.TabIndex = 75
        Me.Button3.Tag = ""
        Me.Button3.Text = "Absentéisme"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightGreen
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(843, 78)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(106, 85)
        Me.Button4.TabIndex = 76
        Me.Button4.Tag = ""
        Me.Button4.Text = "Taux d’intervention des sous-traitants "
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightGreen
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(135, 211)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(106, 85)
        Me.Button5.TabIndex = 77
        Me.Button5.Tag = ""
        Me.Button5.Text = "Délai de 6 semaines de facturation"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightGreen
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(304, 211)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(106, 85)
        Me.Button6.TabIndex = 78
        Me.Button6.Tag = ""
        Me.Button6.Text = "Délai moyen devis "
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightGreen
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(476, 211)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(106, 85)
        Me.Button7.TabIndex = 79
        Me.Button7.Tag = ""
        Me.Button7.Text = "Nombre de mois entre réception et paiement d’une facture"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'frmMenuIndicGMPT_Poste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1989, 1011)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnDelaisMoyen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.BtnTauxDevis)
        Me.Name = "frmMenuIndicGMPT_Poste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporting - Menu Indicateurs postés - GMPT Posté"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents LblTitre As Label
    Friend WithEvents BtnTauxDevis As Button
    Friend WithEvents BtnDelaisMoyen As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
