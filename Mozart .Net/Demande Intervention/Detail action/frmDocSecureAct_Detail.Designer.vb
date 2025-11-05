<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocSecureAct_Detail
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
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GrpInfo = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblFileName = New System.Windows.Forms.Label()
        Me.CmdOpen = New System.Windows.Forms.Button()
        Me.TxtVFILE = New System.Windows.Forms.TextBox()
        Me.TxtVFILEDESCRIPT = New System.Windows.Forms.TextBox()
        Me.TxtVFILENAME = New System.Windows.Forms.TextBox()
        Me.GrpApercu = New System.Windows.Forms.GroupBox()
        Me.WebBrowserApercu = New System.Windows.Forms.WebBrowser()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GrpInfo.SuspendLayout()
        Me.GrpApercu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(102, 839)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(5, 785)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(91, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSave.Location = New System.Drawing.Point(5, 23)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(91, 48)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "Enregistrer"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'GrpInfo
        '
        Me.GrpInfo.Controls.Add(Me.Label2)
        Me.GrpInfo.Controls.Add(Me.Label1)
        Me.GrpInfo.Controls.Add(Me.LblFileName)
        Me.GrpInfo.Controls.Add(Me.CmdOpen)
        Me.GrpInfo.Controls.Add(Me.TxtVFILE)
        Me.GrpInfo.Controls.Add(Me.TxtVFILEDESCRIPT)
        Me.GrpInfo.Controls.Add(Me.TxtVFILENAME)
        Me.GrpInfo.Location = New System.Drawing.Point(120, 12)
        Me.GrpInfo.Name = "GrpInfo"
        Me.GrpInfo.Size = New System.Drawing.Size(1269, 225)
        Me.GrpInfo.TabIndex = 48
        Me.GrpInfo.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Chemin du fichier :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 34)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Description du fichier :"
        '
        'LblFileName
        '
        Me.LblFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFileName.Location = New System.Drawing.Point(54, 41)
        Me.LblFileName.Name = "LblFileName"
        Me.LblFileName.Size = New System.Drawing.Size(107, 23)
        Me.LblFileName.TabIndex = 4
        Me.LblFileName.Text = "Nom du fichier :"
        '
        'CmdOpen
        '
        Me.CmdOpen.Location = New System.Drawing.Point(570, 162)
        Me.CmdOpen.Name = "CmdOpen"
        Me.CmdOpen.Size = New System.Drawing.Size(91, 37)
        Me.CmdOpen.TabIndex = 3
        Me.CmdOpen.Text = "Parcourir"
        Me.CmdOpen.UseVisualStyleBackColor = True
        '
        'TxtVFILE
        '
        Me.TxtVFILE.Location = New System.Drawing.Point(168, 171)
        Me.TxtVFILE.Name = "TxtVFILE"
        Me.TxtVFILE.ReadOnly = True
        Me.TxtVFILE.Size = New System.Drawing.Size(396, 20)
        Me.TxtVFILE.TabIndex = 2
        '
        'TxtVFILEDESCRIPT
        '
        Me.TxtVFILEDESCRIPT.AcceptsReturn = True
        Me.TxtVFILEDESCRIPT.Location = New System.Drawing.Point(167, 75)
        Me.TxtVFILEDESCRIPT.Multiline = True
        Me.TxtVFILEDESCRIPT.Name = "TxtVFILEDESCRIPT"
        Me.TxtVFILEDESCRIPT.Size = New System.Drawing.Size(722, 70)
        Me.TxtVFILEDESCRIPT.TabIndex = 1
        '
        'TxtVFILENAME
        '
        Me.TxtVFILENAME.Location = New System.Drawing.Point(167, 41)
        Me.TxtVFILENAME.Name = "TxtVFILENAME"
        Me.TxtVFILENAME.Size = New System.Drawing.Size(396, 20)
        Me.TxtVFILENAME.TabIndex = 0
        '
        'GrpApercu
        '
        Me.GrpApercu.Controls.Add(Me.WebBrowserApercu)
        Me.GrpApercu.Location = New System.Drawing.Point(120, 243)
        Me.GrpApercu.Name = "GrpApercu"
        Me.GrpApercu.Size = New System.Drawing.Size(1269, 678)
        Me.GrpApercu.TabIndex = 49
        Me.GrpApercu.TabStop = False
        Me.GrpApercu.Text = "Aperçu"
        '
        'WebBrowserApercu
        '
        Me.WebBrowserApercu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowserApercu.Location = New System.Drawing.Point(3, 16)
        Me.WebBrowserApercu.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserApercu.Name = "WebBrowserApercu"
        Me.WebBrowserApercu.Size = New System.Drawing.Size(1263, 659)
        Me.WebBrowserApercu.TabIndex = 0
        '
        'OFD
        '
        Me.OFD.Filter = "Fichiers PDF (*.PDF)|*.PDF"
        '
        'frmDocSecureAct_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1727, 959)
        Me.Controls.Add(Me.GrpApercu)
        Me.Controls.Add(Me.GrpInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDocSecureAct_Detail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Document confidentiel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GrpInfo.ResumeLayout(False)
        Me.GrpInfo.PerformLayout()
        Me.GrpApercu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents GrpInfo As GroupBox
    Friend WithEvents GrpApercu As GroupBox
    Friend WithEvents WebBrowserApercu As WebBrowser
    Friend WithEvents TxtVFILEDESCRIPT As TextBox
    Friend WithEvents TxtVFILENAME As TextBox
    Friend WithEvents CmdOpen As Button
    Friend WithEvents TxtVFILE As TextBox
    Friend WithEvents LblFileName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OFD As OpenFileDialog
End Class
