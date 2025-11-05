<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQCMImages
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.GrpVisu = New System.Windows.Forms.GroupBox()
        Me.BtnDelImg4 = New System.Windows.Forms.Button()
        Me.BtnAddImg4 = New System.Windows.Forms.Button()
        Me.Image4 = New System.Windows.Forms.PictureBox()
        Me.BtnDelImg3 = New System.Windows.Forms.Button()
        Me.BtnAddImg3 = New System.Windows.Forms.Button()
        Me.Image3 = New System.Windows.Forms.PictureBox()
        Me.BtnDelImg2 = New System.Windows.Forms.Button()
        Me.BtnAddImg2 = New System.Windows.Forms.Button()
        Me.Image2 = New System.Windows.Forms.PictureBox()
        Me.BtnDelImg1 = New System.Windows.Forms.Button()
        Me.BtnAddImg1 = New System.Windows.Forms.Button()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.BtnRotateP90 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtImg1 = New System.Windows.Forms.TextBox()
        Me.txtImg2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtImg4 = New System.Windows.Forms.TextBox()
        Me.txtImg3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpVisu.SuspendLayout()
        CType(Me.Image4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(99, 653)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSave.Location = New System.Drawing.Point(7, 12)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(87, 55)
        Me.BtnSave.TabIndex = 10
        Me.BtnSave.Text = "Enregistrer"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(7, 590)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'Image1
        '
        Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Image1.Location = New System.Drawing.Point(134, 40)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(421, 297)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image1.TabIndex = 1
        Me.Image1.TabStop = False
        '
        'GrpVisu
        '
        Me.GrpVisu.Controls.Add(Me.Label4)
        Me.GrpVisu.Controls.Add(Me.Label3)
        Me.GrpVisu.Controls.Add(Me.txtImg4)
        Me.GrpVisu.Controls.Add(Me.txtImg3)
        Me.GrpVisu.Controls.Add(Me.Label2)
        Me.GrpVisu.Controls.Add(Me.Label1)
        Me.GrpVisu.Controls.Add(Me.txtImg2)
        Me.GrpVisu.Controls.Add(Me.txtImg1)
        Me.GrpVisu.Controls.Add(Me.Button3)
        Me.GrpVisu.Controls.Add(Me.Button2)
        Me.GrpVisu.Controls.Add(Me.Button1)
        Me.GrpVisu.Controls.Add(Me.BtnRotateP90)
        Me.GrpVisu.Controls.Add(Me.BtnDelImg4)
        Me.GrpVisu.Controls.Add(Me.BtnAddImg4)
        Me.GrpVisu.Controls.Add(Me.Image4)
        Me.GrpVisu.Controls.Add(Me.BtnDelImg3)
        Me.GrpVisu.Controls.Add(Me.BtnAddImg3)
        Me.GrpVisu.Controls.Add(Me.Image3)
        Me.GrpVisu.Controls.Add(Me.BtnDelImg2)
        Me.GrpVisu.Controls.Add(Me.BtnAddImg2)
        Me.GrpVisu.Controls.Add(Me.Image2)
        Me.GrpVisu.Controls.Add(Me.BtnDelImg1)
        Me.GrpVisu.Controls.Add(Me.BtnAddImg1)
        Me.GrpVisu.Controls.Add(Me.Image1)
        Me.GrpVisu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpVisu.Location = New System.Drawing.Point(128, 28)
        Me.GrpVisu.Name = "GrpVisu"
        Me.GrpVisu.Size = New System.Drawing.Size(1270, 761)
        Me.GrpVisu.TabIndex = 61
        Me.GrpVisu.TabStop = False
        Me.GrpVisu.Text = "Visualisation"
        '
        'BtnDelImg4
        '
        Me.BtnDelImg4.Location = New System.Drawing.Point(1014, 456)
        Me.BtnDelImg4.Name = "BtnDelImg4"
        Me.BtnDelImg4.Size = New System.Drawing.Size(122, 30)
        Me.BtnDelImg4.TabIndex = 12
        Me.BtnDelImg4.Text = "Supprimer"
        Me.BtnDelImg4.UseVisualStyleBackColor = True
        '
        'BtnAddImg4
        '
        Me.BtnAddImg4.Location = New System.Drawing.Point(1014, 420)
        Me.BtnAddImg4.Name = "BtnAddImg4"
        Me.BtnAddImg4.Size = New System.Drawing.Size(122, 30)
        Me.BtnAddImg4.TabIndex = 11
        Me.BtnAddImg4.Text = "Ajouter"
        Me.BtnAddImg4.UseVisualStyleBackColor = True
        '
        'Image4
        '
        Me.Image4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Image4.Location = New System.Drawing.Point(587, 420)
        Me.Image4.Name = "Image4"
        Me.Image4.Size = New System.Drawing.Size(421, 297)
        Me.Image4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image4.TabIndex = 10
        Me.Image4.TabStop = False
        '
        'BtnDelImg3
        '
        Me.BtnDelImg3.Location = New System.Drawing.Point(6, 456)
        Me.BtnDelImg3.Name = "BtnDelImg3"
        Me.BtnDelImg3.Size = New System.Drawing.Size(122, 30)
        Me.BtnDelImg3.TabIndex = 9
        Me.BtnDelImg3.Text = "Supprimer"
        Me.BtnDelImg3.UseVisualStyleBackColor = True
        '
        'BtnAddImg3
        '
        Me.BtnAddImg3.Location = New System.Drawing.Point(6, 420)
        Me.BtnAddImg3.Name = "BtnAddImg3"
        Me.BtnAddImg3.Size = New System.Drawing.Size(122, 30)
        Me.BtnAddImg3.TabIndex = 8
        Me.BtnAddImg3.Text = "Ajouter"
        Me.BtnAddImg3.UseVisualStyleBackColor = True
        '
        'Image3
        '
        Me.Image3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Image3.Location = New System.Drawing.Point(134, 420)
        Me.Image3.Name = "Image3"
        Me.Image3.Size = New System.Drawing.Size(421, 297)
        Me.Image3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image3.TabIndex = 7
        Me.Image3.TabStop = False
        '
        'BtnDelImg2
        '
        Me.BtnDelImg2.Location = New System.Drawing.Point(1014, 76)
        Me.BtnDelImg2.Name = "BtnDelImg2"
        Me.BtnDelImg2.Size = New System.Drawing.Size(122, 30)
        Me.BtnDelImg2.TabIndex = 6
        Me.BtnDelImg2.Text = "Supprimer"
        Me.BtnDelImg2.UseVisualStyleBackColor = True
        '
        'BtnAddImg2
        '
        Me.BtnAddImg2.Location = New System.Drawing.Point(1014, 40)
        Me.BtnAddImg2.Name = "BtnAddImg2"
        Me.BtnAddImg2.Size = New System.Drawing.Size(122, 30)
        Me.BtnAddImg2.TabIndex = 5
        Me.BtnAddImg2.Text = "Ajouter"
        Me.BtnAddImg2.UseVisualStyleBackColor = True
        '
        'Image2
        '
        Me.Image2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Image2.Location = New System.Drawing.Point(587, 40)
        Me.Image2.Name = "Image2"
        Me.Image2.Size = New System.Drawing.Size(421, 297)
        Me.Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image2.TabIndex = 4
        Me.Image2.TabStop = False
        '
        'BtnDelImg1
        '
        Me.BtnDelImg1.Location = New System.Drawing.Point(6, 76)
        Me.BtnDelImg1.Name = "BtnDelImg1"
        Me.BtnDelImg1.Size = New System.Drawing.Size(122, 30)
        Me.BtnDelImg1.TabIndex = 3
        Me.BtnDelImg1.Text = "Supprimer"
        Me.BtnDelImg1.UseVisualStyleBackColor = True
        '
        'BtnAddImg1
        '
        Me.BtnAddImg1.Location = New System.Drawing.Point(6, 40)
        Me.BtnAddImg1.Name = "BtnAddImg1"
        Me.BtnAddImg1.Size = New System.Drawing.Size(122, 30)
        Me.BtnAddImg1.TabIndex = 2
        Me.BtnAddImg1.Text = "Ajouter"
        Me.BtnAddImg1.UseVisualStyleBackColor = True
        '
        'BtnRotateP90
        '
        Me.BtnRotateP90.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRotateP90.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnRotateP90.Location = New System.Drawing.Point(6, 162)
        Me.BtnRotateP90.Name = "BtnRotateP90"
        Me.BtnRotateP90.Size = New System.Drawing.Size(122, 46)
        Me.BtnRotateP90.TabIndex = 21
        Me.BtnRotateP90.Text = "Pivoter sur 90 °"
        Me.BtnRotateP90.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(1014, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 46)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Pivoter sur 90 °"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(1014, 546)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 46)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Pivoter sur 90 °"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(6, 546)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 46)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Pivoter sur 90 °"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtImg1
        '
        Me.txtImg1.Location = New System.Drawing.Point(268, 343)
        Me.txtImg1.Name = "txtImg1"
        Me.txtImg1.Size = New System.Drawing.Size(287, 20)
        Me.txtImg1.TabIndex = 25
        '
        'txtImg2
        '
        Me.txtImg2.Location = New System.Drawing.Point(721, 343)
        Me.txtImg2.Name = "txtImg2"
        Me.txtImg2.Size = New System.Drawing.Size(287, 20)
        Me.txtImg2.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(131, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Libellé de l' image : "
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(584, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Libellé de l' image : "
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(131, 723)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Libellé de l' image : "
        '
        'txtImg4
        '
        Me.txtImg4.Location = New System.Drawing.Point(721, 723)
        Me.txtImg4.Name = "txtImg4"
        Me.txtImg4.Size = New System.Drawing.Size(287, 20)
        Me.txtImg4.TabIndex = 30
        '
        'txtImg3
        '
        Me.txtImg3.Location = New System.Drawing.Point(268, 723)
        Me.txtImg3.Name = "txtImg3"
        Me.txtImg3.Size = New System.Drawing.Size(287, 20)
        Me.txtImg3.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(584, 726)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Libellé de l' image : "
        '
        'frmQCMImages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1991, 1151)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpVisu)
        Me.Name = "frmQCMImages"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ajouter des images à une question"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpVisu.ResumeLayout(False)
        Me.GrpVisu.PerformLayout()
        CType(Me.Image4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents Image1 As PictureBox
    Friend WithEvents GrpVisu As GroupBox
    Friend WithEvents BtnDelImg1 As Button
    Friend WithEvents BtnAddImg1 As Button
    Friend WithEvents BtnDelImg4 As Button
    Friend WithEvents BtnAddImg4 As Button
    Friend WithEvents Image4 As PictureBox
    Friend WithEvents BtnDelImg3 As Button
    Friend WithEvents BtnAddImg3 As Button
    Friend WithEvents Image3 As PictureBox
    Friend WithEvents BtnDelImg2 As Button
    Friend WithEvents BtnAddImg2 As Button
    Friend WithEvents Image2 As PictureBox
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents BtnRotateP90 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtImg2 As TextBox
    Friend WithEvents txtImg1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtImg4 As TextBox
    Friend WithEvents txtImg3 As TextBox
    Friend WithEvents Label2 As Label
End Class
