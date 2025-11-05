<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvertTimeToCentieme
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
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimeEdit1 = New DevExpress.XtraEditors.TimeEdit()
        Me.Txt_Qte = New DevExpress.XtraEditors.TextEdit()
        Me.BtnValid = New System.Windows.Forms.Button()
        CType(Me.TimeEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_Qte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnQuit
        '
        Me.BtnQuit.Location = New System.Drawing.Point(341, 155)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(75, 23)
        Me.BtnQuit.TabIndex = 0
        Me.BtnQuit.Text = "Annuler"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Temps (HH:mm) :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quantité :"
        '
        'TimeEdit1
        '
        Me.TimeEdit1.EditValue = New Date(2020, 1, 13, 0, 0, 0, 0)
        Me.TimeEdit1.Location = New System.Drawing.Point(161, 42)
        Me.TimeEdit1.Name = "TimeEdit1"
        Me.TimeEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TimeEdit1.Properties.Mask.EditMask = "t"
        Me.TimeEdit1.Size = New System.Drawing.Size(162, 20)
        Me.TimeEdit1.TabIndex = 5
        '
        'Txt_Qte
        '
        Me.Txt_Qte.Location = New System.Drawing.Point(161, 107)
        Me.Txt_Qte.Name = "Txt_Qte"
        Me.Txt_Qte.Properties.Mask.EditMask = "n2"
        Me.Txt_Qte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Txt_Qte.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Txt_Qte.Size = New System.Drawing.Size(162, 20)
        Me.Txt_Qte.TabIndex = 9
        Me.Txt_Qte.TabStop = False
        '
        'BtnValid
        '
        Me.BtnValid.Location = New System.Drawing.Point(248, 155)
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.Size = New System.Drawing.Size(75, 23)
        Me.BtnValid.TabIndex = 10
        Me.BtnValid.Text = "Valider"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'frmConvertTimeToCentieme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(426, 191)
        Me.Controls.Add(Me.BtnValid)
        Me.Controls.Add(Me.Txt_Qte)
        Me.Controls.Add(Me.TimeEdit1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnQuit)
        Me.Name = "frmConvertTimeToCentieme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Calculette de conversion Heures en Centièmes"
        CType(Me.TimeEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_Qte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnQuit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TimeEdit1 As DevExpress.XtraEditors.TimeEdit
    Private WithEvents Txt_Qte As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnValid As Button
End Class
