<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevisTechnicienPhotos
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImgListPhotosDevis = New System.Windows.Forms.ImageList(Me.components)
        Me.btnRotateM90 = New System.Windows.Forms.Button()
        Me.ODF = New System.Windows.Forms.OpenFileDialog()
        Me.BtnRotateP90 = New System.Windows.Forms.Button()
        Me.GrpBoxPictApercu = New System.Windows.Forms.GroupBox()
        Me.PictureBoxApercu = New System.Windows.Forms.PictureBox()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.LstVPhotos = New System.Windows.Forms.ListView()
        Me.DGVPhotosDevis = New System.Windows.Forms.DataGridView()
        Me.GrpBoxPictApercu.SuspendLayout()
        CType(Me.PictureBoxApercu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVPhotosDevis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(783, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 45)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Double clic sur la photo pour la renommer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImgListPhotosDevis
        '
        Me.ImgListPhotosDevis.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImgListPhotosDevis.ImageSize = New System.Drawing.Size(120, 120)
        Me.ImgListPhotosDevis.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnRotateM90
        '
        Me.btnRotateM90.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRotateM90.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRotateM90.Location = New System.Drawing.Point(1193, 243)
        Me.btnRotateM90.Name = "btnRotateM90"
        Me.btnRotateM90.Size = New System.Drawing.Size(51, 46)
        Me.btnRotateM90.TabIndex = 33
        Me.btnRotateM90.UseVisualStyleBackColor = True
        '
        'ODF
        '
        Me.ODF.FileName = "OpenFileDialog1"
        '
        'BtnRotateP90
        '
        Me.BtnRotateP90.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRotateP90.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnRotateP90.Location = New System.Drawing.Point(1137, 243)
        Me.BtnRotateP90.Name = "BtnRotateP90"
        Me.BtnRotateP90.Size = New System.Drawing.Size(50, 46)
        Me.BtnRotateP90.TabIndex = 32
        Me.BtnRotateP90.UseVisualStyleBackColor = True
        '
        'GrpBoxPictApercu
        '
        Me.GrpBoxPictApercu.Controls.Add(Me.PictureBoxApercu)
        Me.GrpBoxPictApercu.Location = New System.Drawing.Point(664, 295)
        Me.GrpBoxPictApercu.Name = "GrpBoxPictApercu"
        Me.GrpBoxPictApercu.Size = New System.Drawing.Size(580, 433)
        Me.GrpBoxPictApercu.TabIndex = 28
        Me.GrpBoxPictApercu.TabStop = False
        Me.GrpBoxPictApercu.Text = "Aperçu (Cliquer sur l'image pour l'agrandir)"
        '
        'PictureBoxApercu
        '
        Me.PictureBoxApercu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxApercu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBoxApercu.Location = New System.Drawing.Point(3, 16)
        Me.PictureBoxApercu.Name = "PictureBoxApercu"
        Me.PictureBoxApercu.Size = New System.Drawing.Size(574, 414)
        Me.PictureBoxApercu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxApercu.TabIndex = 6
        Me.PictureBoxApercu.TabStop = False
        '
        'BtnQuit
        '
        Me.BtnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnQuit.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BtnQuit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnQuit.Location = New System.Drawing.Point(1250, 678)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(110, 50)
        Me.BtnQuit.TabIndex = 31
        Me.BtnQuit.Text = "Fermer"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDelete.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BtnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnDelete.Location = New System.Drawing.Point(667, 84)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(110, 58)
        Me.BtnDelete.TabIndex = 30
        Me.BtnDelete.Text = "Supprimer"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'btnAjouter
        '
        Me.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAjouter.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnAjouter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAjouter.Location = New System.Drawing.Point(667, 18)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(110, 60)
        Me.btnAjouter.TabIndex = 29
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'LstVPhotos
        '
        Me.LstVPhotos.HideSelection = False
        Me.LstVPhotos.Location = New System.Drawing.Point(26, 18)
        Me.LstVPhotos.Name = "LstVPhotos"
        Me.LstVPhotos.Size = New System.Drawing.Size(630, 707)
        Me.LstVPhotos.TabIndex = 27
        Me.LstVPhotos.UseCompatibleStateImageBehavior = False
        '
        'DGVPhotosDevis
        '
        Me.DGVPhotosDevis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPhotosDevis.Location = New System.Drawing.Point(1298, 18)
        Me.DGVPhotosDevis.Name = "DGVPhotosDevis"
        Me.DGVPhotosDevis.Size = New System.Drawing.Size(65, 45)
        Me.DGVPhotosDevis.TabIndex = 26
        Me.DGVPhotosDevis.Visible = False
        '
        'frmDevisTechnicienPhotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1389, 746)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRotateM90)
        Me.Controls.Add(Me.BtnRotateP90)
        Me.Controls.Add(Me.GrpBoxPictApercu)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.LstVPhotos)
        Me.Controls.Add(Me.DGVPhotosDevis)
        Me.Name = "frmDevisTechnicienPhotos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Liste des photos devis client (5 photos maximum par devis)"
        Me.GrpBoxPictApercu.ResumeLayout(False)
        CType(Me.PictureBoxApercu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVPhotosDevis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImgListPhotosDevis As System.Windows.Forms.ImageList
    Friend WithEvents btnRotateM90 As System.Windows.Forms.Button
    Friend WithEvents ODF As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnRotateP90 As System.Windows.Forms.Button
    Friend WithEvents GrpBoxPictApercu As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBoxApercu As System.Windows.Forms.PictureBox
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents LstVPhotos As System.Windows.Forms.ListView
    Friend WithEvents DGVPhotosDevis As System.Windows.Forms.DataGridView
End Class
