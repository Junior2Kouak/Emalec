<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCopyPrevOnPeriod
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
        Me.DTP_Debut = New System.Windows.Forms.DateTimePicker()
        Me.DTP_Fin = New System.Windows.Forms.DateTimePicker()
        Me.BtnValider = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DTP_Debut
        '
        Me.DTP_Debut.Location = New System.Drawing.Point(61, 69)
        Me.DTP_Debut.Name = "DTP_Debut"
        Me.DTP_Debut.Size = New System.Drawing.Size(200, 20)
        Me.DTP_Debut.TabIndex = 0
        '
        'DTP_Fin
        '
        Me.DTP_Fin.Location = New System.Drawing.Point(298, 69)
        Me.DTP_Fin.Name = "DTP_Fin"
        Me.DTP_Fin.Size = New System.Drawing.Size(214, 20)
        Me.DTP_Fin.TabIndex = 1
        '
        'BtnValider
        '
        Me.BtnValider.Location = New System.Drawing.Point(342, 115)
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.Size = New System.Drawing.Size(83, 32)
        Me.BtnValider.TabIndex = 2
        Me.BtnValider.Text = "Valider"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Location = New System.Drawing.Point(431, 115)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(81, 32)
        Me.BtnFermer.TabIndex = 3
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        Me.LblTitre.AutoSize = True
        Me.LblTitre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitre.Location = New System.Drawing.Point(31, 23)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(398, 16)
        Me.LblTitre.TabIndex = 4
        Me.LblTitre.Text = "Copie des préventives sélectionnées dans la période à N +1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Du"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(267, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "au"
        '
        'frmCopyPrevOnPeriod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(535, 166)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.BtnValider)
        Me.Controls.Add(Me.DTP_Fin)
        Me.Controls.Add(Me.DTP_Debut)
        Me.Name = "frmCopyPrevOnPeriod"
        Me.Text = "Sélection période"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DTP_Debut As DateTimePicker
    Friend WithEvents DTP_Fin As DateTimePicker
    Friend WithEvents BtnValider As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents LblTitre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
