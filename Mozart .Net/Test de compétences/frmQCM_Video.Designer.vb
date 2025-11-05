<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQCM_Video
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
        Me.GrpVideo = New System.Windows.Forms.GroupBox()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTitre = New System.Windows.Forms.TextBox()
        Me.TxtLienVideo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLoadVideo = New System.Windows.Forms.Button()
        Me.GrpVisu = New System.Windows.Forms.GroupBox()
        Me.WVVisu = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.BtnDelVideo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GrpVideo.SuspendLayout()
        Me.GrpVisu.SuspendLayout()
        CType(Me.WVVisu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnDelVideo)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(99, 653)
        Me.GroupBox1.TabIndex = 55
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
        'GrpVideo
        '
        Me.GrpVideo.Controls.Add(Me.TxtNotes)
        Me.GrpVideo.Controls.Add(Me.Label3)
        Me.GrpVideo.Controls.Add(Me.Label2)
        Me.GrpVideo.Controls.Add(Me.TxtTitre)
        Me.GrpVideo.Controls.Add(Me.TxtLienVideo)
        Me.GrpVideo.Controls.Add(Me.Label1)
        Me.GrpVideo.Controls.Add(Me.BtnLoadVideo)
        Me.GrpVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpVideo.Location = New System.Drawing.Point(122, 12)
        Me.GrpVideo.Name = "GrpVideo"
        Me.GrpVideo.Size = New System.Drawing.Size(1388, 238)
        Me.GrpVideo.TabIndex = 57
        Me.GrpVideo.TabStop = False
        Me.GrpVideo.Text = "Info Video"
        '
        'TxtNotes
        '
        Me.TxtNotes.Location = New System.Drawing.Point(195, 118)
        Me.TxtNotes.Multiline = True
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(681, 104)
        Me.TxtNotes.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(46, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 29)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Notes"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(46, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 29)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Titre vidéo"
        '
        'TxtTitre
        '
        Me.TxtTitre.Location = New System.Drawing.Point(195, 30)
        Me.TxtTitre.Name = "TxtTitre"
        Me.TxtTitre.Size = New System.Drawing.Size(681, 20)
        Me.TxtTitre.TabIndex = 60
        '
        'TxtLienVideo
        '
        Me.TxtLienVideo.Location = New System.Drawing.Point(195, 78)
        Me.TxtLienVideo.Name = "TxtLienVideo"
        Me.TxtLienVideo.Size = New System.Drawing.Size(681, 20)
        Me.TxtLienVideo.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(46, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 29)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "URL"
        '
        'BtnLoadVideo
        '
        Me.BtnLoadVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnLoadVideo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnLoadVideo.Location = New System.Drawing.Point(882, 68)
        Me.BtnLoadVideo.Name = "BtnLoadVideo"
        Me.BtnLoadVideo.Size = New System.Drawing.Size(103, 38)
        Me.BtnLoadVideo.TabIndex = 11
        Me.BtnLoadVideo.Text = "Visualiser la vidéo"
        Me.BtnLoadVideo.UseVisualStyleBackColor = True
        '
        'GrpVisu
        '
        Me.GrpVisu.Controls.Add(Me.WVVisu)
        Me.GrpVisu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpVisu.Location = New System.Drawing.Point(122, 256)
        Me.GrpVisu.Name = "GrpVisu"
        Me.GrpVisu.Size = New System.Drawing.Size(1394, 672)
        Me.GrpVisu.TabIndex = 58
        Me.GrpVisu.TabStop = False
        Me.GrpVisu.Text = "Visualisation"
        '
        'WVVisu
        '
        Me.WVVisu.AllowExternalDrop = True
        Me.WVVisu.CreationProperties = Nothing
        Me.WVVisu.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WVVisu.Location = New System.Drawing.Point(6, 19)
        Me.WVVisu.Name = "WVVisu"
        Me.WVVisu.Size = New System.Drawing.Size(1382, 713)
        Me.WVVisu.TabIndex = 0
        Me.WVVisu.ZoomFactor = 1.0R
        '
        'BtnDelVideo
        '
        Me.BtnDelVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnDelVideo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnDelVideo.Location = New System.Drawing.Point(7, 89)
        Me.BtnDelVideo.Name = "BtnDelVideo"
        Me.BtnDelVideo.Size = New System.Drawing.Size(82, 58)
        Me.BtnDelVideo.TabIndex = 60
        Me.BtnDelVideo.Text = "Supprimer la vidéo"
        Me.BtnDelVideo.UseVisualStyleBackColor = True
        '
        'frmQCM_Video
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1554, 950)
        Me.Controls.Add(Me.GrpVisu)
        Me.Controls.Add(Me.GrpVideo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmQCM_Video"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ajout d'une vidéo dans un QCM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GrpVideo.ResumeLayout(False)
        Me.GrpVideo.PerformLayout()
        Me.GrpVisu.ResumeLayout(False)
        CType(Me.WVVisu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents GrpVideo As GroupBox
    Friend WithEvents GrpVisu As GroupBox
    Friend WithEvents WVVisu As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents BtnLoadVideo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtLienVideo As TextBox
    Friend WithEvents TxtTitre As TextBox
    Friend WithEvents TxtNotes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnDelVideo As Button
End Class
