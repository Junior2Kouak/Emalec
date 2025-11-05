<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporting_Menu_GMTP_RMPT_Poste
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
        Me.BtnGMPTPoste = New System.Windows.Forms.Button()
        Me.BtnRMPTPoste = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 12)
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
        Me.LblTitre.Location = New System.Drawing.Point(114, 20)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(835, 30)
        Me.LblTitre.TabIndex = 71
        Me.LblTitre.Text = "Menu Indicateurs postés - GMPT - RMPT"
        '
        'BtnGMPTPoste
        '
        Me.BtnGMPTPoste.BackColor = System.Drawing.Color.LightGreen
        Me.BtnGMPTPoste.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGMPTPoste.Location = New System.Drawing.Point(144, 78)
        Me.BtnGMPTPoste.Name = "BtnGMPTPoste"
        Me.BtnGMPTPoste.Size = New System.Drawing.Size(106, 85)
        Me.BtnGMPTPoste.TabIndex = 70
        Me.BtnGMPTPoste.Tag = "0"
        Me.BtnGMPTPoste.Text = "GMPT Posté"
        Me.BtnGMPTPoste.UseVisualStyleBackColor = False
        '
        'BtnRMPTPoste
        '
        Me.BtnRMPTPoste.BackColor = System.Drawing.Color.LightGreen
        Me.BtnRMPTPoste.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRMPTPoste.Location = New System.Drawing.Point(325, 78)
        Me.BtnRMPTPoste.Name = "BtnRMPTPoste"
        Me.BtnRMPTPoste.Size = New System.Drawing.Size(106, 85)
        Me.BtnRMPTPoste.TabIndex = 73
        Me.BtnRMPTPoste.Tag = "0"
        Me.BtnRMPTPoste.Text = "RMPT Posté"
        Me.BtnRMPTPoste.UseVisualStyleBackColor = False
        '
        'frmReporting_Menu_GMTP_RMPT_Poste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1909, 1052)
        Me.Controls.Add(Me.BtnRMPTPoste)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.BtnGMPTPoste)
        Me.Name = "frmReporting_Menu_GMTP_RMPT_Poste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporting - Menu Indicateurs postés - GMPT - RMPT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents LblTitre As Label
    Friend WithEvents BtnGMPTPoste As Button
    Friend WithEvents BtnRMPTPoste As Button
End Class
