<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQCMNewQuestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQCMNewQuestion))
        Me.GrpBxNewQuestion = New System.Windows.Forms.GroupBox()
        Me.BtnEnregistrer = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.LblLeg1 = New System.Windows.Forms.Label()
        Me.TxtNewQuestion = New System.Windows.Forms.TextBox()
        Me.GrpBxNewQuestion.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpBxNewQuestion
        '
        resources.ApplyResources(Me.GrpBxNewQuestion, "GrpBxNewQuestion")
        Me.GrpBxNewQuestion.Controls.Add(Me.BtnEnregistrer)
        Me.GrpBxNewQuestion.Controls.Add(Me.BtnCancel)
        Me.GrpBxNewQuestion.Controls.Add(Me.LblLeg1)
        Me.GrpBxNewQuestion.Controls.Add(Me.TxtNewQuestion)
        Me.GrpBxNewQuestion.Name = "GrpBxNewQuestion"
        Me.GrpBxNewQuestion.TabStop = False
        '
        'BtnEnregistrer
        '
        resources.ApplyResources(Me.BtnEnregistrer, "BtnEnregistrer")
        Me.BtnEnregistrer.Name = "BtnEnregistrer"
        Me.BtnEnregistrer.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        resources.ApplyResources(Me.BtnCancel, "BtnCancel")
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LblLeg1
        '
        resources.ApplyResources(Me.LblLeg1, "LblLeg1")
        Me.LblLeg1.Name = "LblLeg1"
        '
        'TxtNewQuestion
        '
        resources.ApplyResources(Me.TxtNewQuestion, "TxtNewQuestion")
        Me.TxtNewQuestion.Name = "TxtNewQuestion"
        '
        'frmQCMNewQuestion
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpBxNewQuestion)
        Me.Name = "frmQCMNewQuestion"
        Me.GrpBxNewQuestion.ResumeLayout(False)
        Me.GrpBxNewQuestion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpBxNewQuestion As System.Windows.Forms.GroupBox
    Friend WithEvents BtnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblLeg1 As System.Windows.Forms.Label
    Friend WithEvents TxtNewQuestion As System.Windows.Forms.TextBox
End Class
