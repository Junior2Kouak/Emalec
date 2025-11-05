<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignaturePersonnel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignaturePersonnel))
        Me.PictSignature = New System.Windows.Forms.PictureBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnLoadImage = New System.Windows.Forms.Button()
        Me.BtmClear = New System.Windows.Forms.Button()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictSignature
        '
        resources.ApplyResources(Me.PictSignature, "PictSignature")
        Me.PictSignature.BackColor = System.Drawing.Color.White
        Me.PictSignature.Name = "PictSignature"
        Me.PictSignature.TabStop = False
        '
        'BtnSave
        '
        resources.ApplyResources(Me.BtnSave, "BtnSave")
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnLoadImage
        '
        resources.ApplyResources(Me.BtnLoadImage, "BtnLoadImage")
        Me.BtnLoadImage.Name = "BtnLoadImage"
        Me.BtnLoadImage.UseVisualStyleBackColor = True
        '
        'BtmClear
        '
        resources.ApplyResources(Me.BtmClear, "BtmClear")
        Me.BtmClear.Name = "BtmClear"
        Me.BtmClear.UseVisualStyleBackColor = True
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        resources.ApplyResources(Me.OFD, "OFD")
        '
        'frmSignaturePersonnel
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.BtmClear)
        Me.Controls.Add(Me.BtnLoadImage)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.PictSignature)
        Me.Name = "frmSignaturePersonnel"
        CType(Me.PictSignature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictSignature As PictureBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnLoadImage As Button
    Friend WithEvents BtmClear As Button
    Friend WithEvents OFD As OpenFileDialog
End Class
