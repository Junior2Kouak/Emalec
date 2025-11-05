<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGTPSelectionClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGTPSelectionClient))
        Me.GrpClient = New System.Windows.Forms.GroupBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboClient = New System.Windows.Forms.ComboBox()
        Me.GrpClient.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpClient
        '
        resources.ApplyResources(Me.GrpClient, "GrpClient")
        Me.GrpClient.Controls.Add(Me.BtnCancel)
        Me.GrpClient.Controls.Add(Me.BtnOk)
        Me.GrpClient.Controls.Add(Me.Label1)
        Me.GrpClient.Controls.Add(Me.CboClient)
        Me.GrpClient.Name = "GrpClient"
        Me.GrpClient.TabStop = False
        '
        'BtnCancel
        '
        resources.ApplyResources(Me.BtnCancel, "BtnCancel")
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOk
        '
        resources.ApplyResources(Me.BtnOk, "BtnOk")
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'CboClient
        '
        resources.ApplyResources(Me.CboClient, "CboClient")
        Me.CboClient.DisplayMember = "VCLINOM"
        Me.CboClient.FormattingEnabled = True
        Me.CboClient.Name = "CboClient"
        Me.CboClient.ValueMember = "NCLINUM"
        '
        'frmGTPSelectionClient
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpClient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmGTPSelectionClient"
        Me.GrpClient.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpClient As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboClient As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOk As System.Windows.Forms.Button
End Class
