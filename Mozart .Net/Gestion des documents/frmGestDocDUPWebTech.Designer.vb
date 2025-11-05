<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestDocDUPWebTech
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestDocDUPWebTech))
    Me.GrpboxActions = New System.Windows.Forms.GroupBox()
    Me.BtnClose = New System.Windows.Forms.Button()
    Me.BtnNew = New System.Windows.Forms.Button()
    Me.WBApercu = New System.Windows.Forms.WebBrowser()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.ODF = New System.Windows.Forms.OpenFileDialog()
        Me.GrpboxActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpboxActions
        '
        Me.GrpboxActions.Controls.Add(Me.BtnClose)
        Me.GrpboxActions.Controls.Add(Me.BtnNew)
        resources.ApplyResources(Me.GrpboxActions, "GrpboxActions")
        Me.GrpboxActions.Name = "GrpboxActions"
        Me.GrpboxActions.TabStop = False
        '
        'BtnClose
        '
        resources.ApplyResources(Me.BtnClose, "BtnClose")
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        resources.ApplyResources(Me.BtnNew, "BtnNew")
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'WBApercu
        '
        resources.ApplyResources(Me.WBApercu, "WBApercu")
        Me.WBApercu.Name = "WBApercu"
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'ODF
        '
        resources.ApplyResources(Me.ODF, "ODF")
        '
        'frmGestDocDUPWebTech
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.WBApercu)
        Me.Controls.Add(Me.GrpboxActions)
        Me.Name = "frmGestDocDUPWebTech"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpboxActions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpboxActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents WBApercu As System.Windows.Forms.WebBrowser
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents ODF As System.Windows.Forms.OpenFileDialog
End Class
