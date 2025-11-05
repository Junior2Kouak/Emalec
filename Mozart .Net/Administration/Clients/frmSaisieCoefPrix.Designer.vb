<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaisieCoefPrix
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
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCoef = New DevExpress.XtraEditors.TextEdit()
        CType(Me.TxtCoef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnFermer
        '
        Me.BtnFermer.Location = New System.Drawing.Point(12, 53)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(60, 43)
        Me.BtnFermer.TabIndex = 0
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnValid
        '
        Me.BtnValid.Location = New System.Drawing.Point(440, 58)
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.Size = New System.Drawing.Size(85, 33)
        Me.BtnValid.TabIndex = 1
        Me.BtnValid.Text = "Valider"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Vous allez appliquer un coefficient à tous les prix de ventes du client :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "(Arrondi à 4 décimales)"
        '
        'TxtCoef
        '
        Me.TxtCoef.EditValue = New Decimal(New Integer() {10000, 0, 0, 262144})
        Me.TxtCoef.Location = New System.Drawing.Point(267, 65)
        Me.TxtCoef.Name = "TxtCoef"
        Me.TxtCoef.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtCoef.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TxtCoef.Properties.DisplayFormat.FormatString = "n4"
        Me.TxtCoef.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCoef.Properties.EditFormat.FormatString = "n4"
        Me.TxtCoef.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCoef.Properties.Mask.EditMask = "n4"
        Me.TxtCoef.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtCoef.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TxtCoef.Size = New System.Drawing.Size(167, 20)
        Me.TxtCoef.TabIndex = 4
        '
        'frmSaisieCoefPrix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(564, 130)
        Me.Controls.Add(Me.TxtCoef)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnValid)
        Me.Controls.Add(Me.BtnFermer)
        Me.Name = "frmSaisieCoefPrix"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Coefficient prix de vente"
        CType(Me.TxtCoef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnValid As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCoef As DevExpress.XtraEditors.TextEdit
End Class
