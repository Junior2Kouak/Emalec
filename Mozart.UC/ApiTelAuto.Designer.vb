
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ApiTelAuto
  Inherits System.Windows.Forms.UserControl

  'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ApiTelAuto))
    Me.imgTel = New System.Windows.Forms.PictureBox()
    CType(Me.imgTel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'imgTel
    '
    Me.imgTel.Image = CType(resources.GetObject("imgTel.Image"), System.Drawing.Image)
    Me.imgTel.Location = New System.Drawing.Point(0, 0)
    Me.imgTel.Name = "imgTel"
    Me.imgTel.Size = New System.Drawing.Size(16, 16)
    Me.imgTel.TabIndex = 0
    Me.imgTel.TabStop = False
    '
    'ApiTelAuto
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.imgTel)
    Me.Name = "ApiTelAuto"
    Me.Size = New System.Drawing.Size(21, 19)
    CType(Me.imgTel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents imgTel As Windows.Forms.PictureBox
End Class
