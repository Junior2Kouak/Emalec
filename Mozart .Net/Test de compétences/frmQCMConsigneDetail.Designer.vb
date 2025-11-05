<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQCMConsigneDetail
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
        Me.BtnValider = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.RichEditCtrlConsigne = New DevExpress.XtraRichEdit.RichEditControl()
        Me.SuspendLayout()
        '
        'BtnValider
        '
        Me.BtnValider.Location = New System.Drawing.Point(23, 21)
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.Size = New System.Drawing.Size(75, 47)
        Me.BtnValider.TabIndex = 0
        Me.BtnValider.Text = "Valider"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Location = New System.Drawing.Point(23, 218)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 44)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'RichEditCtrlConsigne
        '
        Me.RichEditCtrlConsigne.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
        Me.RichEditCtrlConsigne.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel
        Me.RichEditCtrlConsigne.Location = New System.Drawing.Point(124, 12)
        Me.RichEditCtrlConsigne.Name = "RichEditCtrlConsigne"
        Me.RichEditCtrlConsigne.Size = New System.Drawing.Size(664, 261)
        Me.RichEditCtrlConsigne.TabIndex = 2
        '
        'frmQCMConsigneDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(800, 286)
        Me.Controls.Add(Me.RichEditCtrlConsigne)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.BtnValider)
        Me.Name = "frmQCMConsigneDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consigne pour QCM"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnValider As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents RichEditCtrlConsigne As DevExpress.XtraRichEdit.RichEditControl
End Class
