<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisuDoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisuDoc))
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser
        '
        Me.WebBrowser.AllowWebBrowserDrop = False
        resources.ApplyResources(Me.WebBrowser, "WebBrowser")
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.ScriptErrorsSuppressed = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        resources.ApplyResources(Me.btnPrint, "btnPrint")
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'BtnSend
        '
        resources.ApplyResources(Me.BtnSend, "BtnSend")
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.UseVisualStyleBackColor = True
        '
        'frmVisuDoc
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.BtnSend)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.WebBrowser)
        Me.Controls.Add(Me.BtnFermer)
        Me.Name = "frmVisuDoc"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Public WithEvents WebBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents BtnSend As Button
End Class
