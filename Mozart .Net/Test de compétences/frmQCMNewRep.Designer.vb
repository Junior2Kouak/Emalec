<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQCMNewRep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQCMNewRep))
        Me.GrpBxNewRep = New System.Windows.Forms.GroupBox()
        Me.BtnEnregistrer = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.LblLeg2 = New System.Windows.Forms.Label()
        Me.LblLeg1 = New System.Windows.Forms.Label()
        Me.CboRepOblig = New System.Windows.Forms.ComboBox()
        Me.TxtNewReponse = New System.Windows.Forms.TextBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtObsCorrection = New System.Windows.Forms.TextBox()
        Me.GrpBxNewRep.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpBxNewRep
        '
        Me.GrpBxNewRep.Controls.Add(Me.Label1)
        Me.GrpBxNewRep.Controls.Add(Me.TxtObsCorrection)
        Me.GrpBxNewRep.Controls.Add(Me.BtnEnregistrer)
        Me.GrpBxNewRep.Controls.Add(Me.BtnCancel)
        Me.GrpBxNewRep.Controls.Add(Me.LblLeg2)
        Me.GrpBxNewRep.Controls.Add(Me.LblLeg1)
        Me.GrpBxNewRep.Controls.Add(Me.CboRepOblig)
        Me.GrpBxNewRep.Controls.Add(Me.TxtNewReponse)
        Me.GrpBxNewRep.Controls.Add(Me.lblQuestion)
        resources.ApplyResources(Me.GrpBxNewRep, "GrpBxNewRep")
        Me.GrpBxNewRep.Name = "GrpBxNewRep"
        Me.GrpBxNewRep.TabStop = False
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
        'LblLeg2
        '
        resources.ApplyResources(Me.LblLeg2, "LblLeg2")
        Me.LblLeg2.Name = "LblLeg2"
        '
        'LblLeg1
        '
        resources.ApplyResources(Me.LblLeg1, "LblLeg1")
        Me.LblLeg1.Name = "LblLeg1"
        '
        'CboRepOblig
        '
        Me.CboRepOblig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.CboRepOblig, "CboRepOblig")
        Me.CboRepOblig.FormattingEnabled = True
        Me.CboRepOblig.Name = "CboRepOblig"
        '
        'TxtNewReponse
        '
        resources.ApplyResources(Me.TxtNewReponse, "TxtNewReponse")
        Me.TxtNewReponse.Name = "TxtNewReponse"
        '
        'lblQuestion
        '
        resources.ApplyResources(Me.lblQuestion, "lblQuestion")
        Me.lblQuestion.Name = "lblQuestion"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'TxtObsCorrection
        '
        resources.ApplyResources(Me.TxtObsCorrection, "TxtObsCorrection")
        Me.TxtObsCorrection.Name = "TxtObsCorrection"
        '
        'frmQCMNewRep
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpBxNewRep)
        Me.Name = "frmQCMNewRep"
        Me.GrpBxNewRep.ResumeLayout(False)
        Me.GrpBxNewRep.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpBxNewRep As System.Windows.Forms.GroupBox
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents CboRepOblig As System.Windows.Forms.ComboBox
    Friend WithEvents TxtNewReponse As System.Windows.Forms.TextBox
    Friend WithEvents LblLeg1 As System.Windows.Forms.Label
    Friend WithEvents LblLeg2 As System.Windows.Forms.Label
    Friend WithEvents BtnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtObsCorrection As TextBox
End Class
