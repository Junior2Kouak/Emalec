<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaisieMontantGD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaisieMontantGD))
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.CboMontantGD = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtnValid
        '
        resources.ApplyResources(Me.BtnValid, "BtnValid")
        Me.BtnValid.BackgroundImage = Global.MozartNet.My.Resources.Resources.clean
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        resources.ApplyResources(Me.BtnCancel, "BtnCancel")
        Me.BtnCancel.BackgroundImage = Global.MozartNet.My.Resources.Resources._stop
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'CboMontantGD
        '
        resources.ApplyResources(Me.CboMontantGD, "CboMontantGD")
        Me.CboMontantGD.DisplayMember = "NMONTANTGD"
        Me.CboMontantGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMontantGD.FormattingEnabled = True
        Me.CboMontantGD.Name = "CboMontantGD"
        Me.CboMontantGD.ValueMember = "NID"
        '
        'frmSaisieMontantGD
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CboMontantGD)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnValid)
        Me.Name = "frmSaisieMontantGD"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnValid As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents CboMontantGD As System.Windows.Forms.ComboBox
End Class
