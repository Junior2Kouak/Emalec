<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommandeReapproMessageHisto
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommandeReapproMessageHisto))
    Me.BtnMessageAdd = New System.Windows.Forms.Button()
    Me.TxtMessages = New System.Windows.Forms.TextBox()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'BtnMessageAdd
    '
    resources.ApplyResources(Me.BtnMessageAdd, "BtnMessageAdd")
    Me.BtnMessageAdd.Name = "BtnMessageAdd"
    Me.BtnMessageAdd.UseVisualStyleBackColor = True
    '
    'TxtMessages
    '
    resources.ApplyResources(Me.TxtMessages, "TxtMessages")
    Me.TxtMessages.BackColor = System.Drawing.Color.White
    Me.TxtMessages.Name = "TxtMessages"
    Me.TxtMessages.ReadOnly = True
    '
    'BtnFermer
    '
    resources.ApplyResources(Me.BtnFermer, "BtnFermer")
    Me.BtnFermer.Name = "BtnFermer"
    Me.BtnFermer.UseVisualStyleBackColor = True
    '
    'frmCommandeReapproMessageHisto
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.Controls.Add(Me.BtnFermer)
    Me.Controls.Add(Me.TxtMessages)
    Me.Controls.Add(Me.BtnMessageAdd)
    Me.Name = "frmCommandeReapproMessageHisto"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents BtnMessageAdd As Button
    Friend WithEvents TxtMessages As TextBox
    Friend WithEvents BtnFermer As Button
End Class
