<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuCertificatEtancheite
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuCertificatEtancheite))
    Me.BtnListeCtrlEtanch = New System.Windows.Forms.Button()
    Me.BtnPlanningCtrlEtanch = New System.Windows.Forms.Button()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'BtnListeCtrlEtanch
    '
    resources.ApplyResources(Me.BtnListeCtrlEtanch, "BtnListeCtrlEtanch")
    Me.BtnListeCtrlEtanch.Name = "BtnListeCtrlEtanch"
    Me.BtnListeCtrlEtanch.UseVisualStyleBackColor = True
    '
    'BtnPlanningCtrlEtanch
    '
    resources.ApplyResources(Me.BtnPlanningCtrlEtanch, "BtnPlanningCtrlEtanch")
    Me.BtnPlanningCtrlEtanch.Name = "BtnPlanningCtrlEtanch"
    Me.BtnPlanningCtrlEtanch.UseVisualStyleBackColor = True
    '
    'GroupBox1
    '
    resources.ApplyResources(Me.GroupBox1, "GroupBox1")
    Me.GroupBox1.Controls.Add(Me.BtnFermer)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.TabStop = False
    '
    'BtnFermer
    '
    resources.ApplyResources(Me.BtnFermer, "BtnFermer")
    Me.BtnFermer.Name = "BtnFermer"
    Me.BtnFermer.UseVisualStyleBackColor = True
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.Name = "Label1"
    '
    'frmMenuCertificatEtancheite
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.BtnPlanningCtrlEtanch)
    Me.Controls.Add(Me.BtnListeCtrlEtanch)
    Me.Name = "frmMenuCertificatEtancheite"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.GroupBox1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents BtnListeCtrlEtanch As Button
    Friend WithEvents BtnPlanningCtrlEtanch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents Label1 As Label
End Class
