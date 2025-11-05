<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStatKmsByTech
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
        Me.PrintControl1 = New DevExpress.XtraPrinting.Control.PrintControl()
        Me.SuspendLayout()
        '
        'PrintControl1
        '
        Me.PrintControl1.BackColor = System.Drawing.Color.Empty
        Me.PrintControl1.ForeColor = System.Drawing.Color.Empty
        Me.PrintControl1.IsMetric = True
        Me.PrintControl1.Location = New System.Drawing.Point(2, 2)
        Me.PrintControl1.Name = "PrintControl1"
        Me.PrintControl1.Size = New System.Drawing.Size(1063, 538)
        Me.PrintControl1.TabIndex = 9
        Me.PrintControl1.TooltipFont = New System.Drawing.Font("Tahoma", 8.25!)
        '
        'FrmStatKmsByTech
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1193, 541)
        Me.Controls.Add(Me.PrintControl1)
        Me.Name = "FrmStatKmsByTech"
        Me.Text = "FrmStatKmsByTech"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintControl1 As DevExpress.XtraPrinting.Control.PrintControl
End Class
