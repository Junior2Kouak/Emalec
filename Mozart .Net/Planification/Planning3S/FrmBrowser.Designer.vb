<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBrowser
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBrowser))
    Me.btnClose = New System.Windows.Forms.Button()
    Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
    Me.webView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
    CType(Me.webView21, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnClose
    '
    Me.btnClose.BackColor = System.Drawing.Color.SandyBrown
    Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
    resources.ApplyResources(Me.btnClose, "btnClose")
    Me.btnClose.Name = "btnClose"
    Me.btnClose.UseVisualStyleBackColor = False
    '
    'PrintDialog1
    '
    Me.PrintDialog1.UseEXDialog = True
    '
    'webView21
    '
    Me.webView21.AllowExternalDrop = True
    Me.webView21.BackColor = System.Drawing.Color.White
    Me.webView21.CreationProperties = Nothing
    Me.webView21.DefaultBackgroundColor = System.Drawing.Color.White
    resources.ApplyResources(Me.webView21, "webView21")
    Me.webView21.Name = "webView21"
    Me.webView21.ZoomFactor = 1.0R
    '
    'FrmBrowser
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.btnClose)
    Me.Controls.Add(Me.webView21)
    Me.Name = "FrmBrowser"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    CType(Me.webView21, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnClose As System.Windows.Forms.Button
  Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
  Private WithEvents webView21 As Microsoft.Web.WebView2.WinForms.WebView2
End Class
