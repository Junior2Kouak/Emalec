<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommandeReapproMessageAdd
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
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.TxtMessage = New System.Windows.Forms.TextBox()
        Me.BtnMessageAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(5, 121)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(119, 79)
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "Annuler"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'TxtMessage
        '
        Me.TxtMessage.Location = New System.Drawing.Point(130, 12)
        Me.TxtMessage.Multiline = True
        Me.TxtMessage.Name = "TxtMessage"
        Me.TxtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtMessage.Size = New System.Drawing.Size(727, 188)
        Me.TxtMessage.TabIndex = 4
        '
        'BtnMessageAdd
        '
        Me.BtnMessageAdd.Location = New System.Drawing.Point(5, 12)
        Me.BtnMessageAdd.Name = "BtnMessageAdd"
        Me.BtnMessageAdd.Size = New System.Drawing.Size(119, 79)
        Me.BtnMessageAdd.TabIndex = 3
        Me.BtnMessageAdd.Text = "Valider"
        Me.BtnMessageAdd.UseVisualStyleBackColor = True
        '
        'frmCommandeReapproMessageAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(865, 212)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.TxtMessage)
        Me.Controls.Add(Me.BtnMessageAdd)
        Me.Name = "frmCommandeReapproMessageAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Envoi Message au technicien sur la demande de réappro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancel As Button
    Friend WithEvents TxtMessage As TextBox
    Friend WithEvents BtnMessageAdd As Button
End Class
