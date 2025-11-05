<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCRapportFM_ImagePG
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureEdit_PG = New DevExpress.XtraEditors.PictureEdit()
        Me.BtnLoadIMG = New System.Windows.Forms.Button()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.BtnSuppImg = New System.Windows.Forms.Button()
        CType(Me.PictureEdit_PG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 40)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Choix de l'image sur la page de garde du rapport FM"
        '
        'PictureEdit_PG
        '
        Me.PictureEdit_PG.Location = New System.Drawing.Point(125, 159)
        Me.PictureEdit_PG.Name = "PictureEdit_PG"
        Me.PictureEdit_PG.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit_PG.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit_PG.Size = New System.Drawing.Size(906, 342)
        Me.PictureEdit_PG.TabIndex = 9
        '
        'BtnLoadIMG
        '
        Me.BtnLoadIMG.Location = New System.Drawing.Point(125, 507)
        Me.BtnLoadIMG.Name = "BtnLoadIMG"
        Me.BtnLoadIMG.Size = New System.Drawing.Size(906, 44)
        Me.BtnLoadIMG.TabIndex = 10
        Me.BtnLoadIMG.Text = "Modifier image"
        Me.BtnLoadIMG.UseVisualStyleBackColor = True
        '
        'BtnSuppImg
        '
        Me.BtnSuppImg.Location = New System.Drawing.Point(125, 571)
        Me.BtnSuppImg.Name = "BtnSuppImg"
        Me.BtnSuppImg.Size = New System.Drawing.Size(906, 44)
        Me.BtnSuppImg.TabIndex = 11
        Me.BtnSuppImg.Text = "Supprimer image"
        Me.BtnSuppImg.UseVisualStyleBackColor = True
        '
        'UCRapportFM_ImagePG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.BtnSuppImg)
        Me.Controls.Add(Me.BtnLoadIMG)
        Me.Controls.Add(Me.PictureEdit_PG)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UCRapportFM_ImagePG"
        Me.Size = New System.Drawing.Size(1161, 767)
        CType(Me.PictureEdit_PG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureEdit_PG As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents BtnLoadIMG As Button
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents BtnSuppImg As Button
End Class
