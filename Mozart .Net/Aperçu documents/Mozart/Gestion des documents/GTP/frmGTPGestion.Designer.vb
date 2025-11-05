<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGTPGestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGTPGestion))
        Me.BtnGTPEMALEC = New System.Windows.Forms.Button()
        Me.BtnGTPClient = New System.Windows.Forms.Button()
        Me.BtnGTPSite = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnGTPEMALEC
        '
        resources.ApplyResources(Me.BtnGTPEMALEC, "BtnGTPEMALEC")
        Me.BtnGTPEMALEC.Name = "BtnGTPEMALEC"
        Me.BtnGTPEMALEC.UseVisualStyleBackColor = True
        '
        'BtnGTPClient
        '
        resources.ApplyResources(Me.BtnGTPClient, "BtnGTPClient")
        Me.BtnGTPClient.Name = "BtnGTPClient"
        Me.BtnGTPClient.UseVisualStyleBackColor = True
        '
        'BtnGTPSite
        '
        resources.ApplyResources(Me.BtnGTPSite, "BtnGTPSite")
        Me.BtnGTPSite.Name = "BtnGTPSite"
        Me.BtnGTPSite.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'frmGTPGestion
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.BtnGTPSite)
        Me.Controls.Add(Me.BtnGTPClient)
        Me.Controls.Add(Me.BtnGTPEMALEC)
        Me.Name = "frmGTPGestion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnGTPEMALEC As System.Windows.Forms.Button
    Friend WithEvents BtnGTPClient As System.Windows.Forms.Button
    Friend WithEvents BtnGTPSite As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
End Class
