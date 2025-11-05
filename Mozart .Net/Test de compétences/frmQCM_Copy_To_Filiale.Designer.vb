<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQCM_Copy_To_Filiale
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
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.CheckedListBoxControl1 = New DevExpress.XtraEditors.CheckedListBoxControl()
        CType(Me.CheckedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(12, 307)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(89, 37)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "Annuler"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnValid
        '
        Me.BtnValid.Location = New System.Drawing.Point(305, 307)
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.Size = New System.Drawing.Size(85, 37)
        Me.BtnValid.TabIndex = 2
        Me.BtnValid.Text = "Valider"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'CheckedListBoxControl1
        '
        Me.CheckedListBoxControl1.DisplayMember = "VSOCIETE_NOM_USUEL"
        Me.CheckedListBoxControl1.Location = New System.Drawing.Point(12, 12)
        Me.CheckedListBoxControl1.Name = "CheckedListBoxControl1"
        Me.CheckedListBoxControl1.Size = New System.Drawing.Size(378, 289)
        Me.CheckedListBoxControl1.TabIndex = 3
        Me.CheckedListBoxControl1.ValueMember = "VSOCIETENOM"
        '
        'frmQCM_Copy_To_Filiale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 356)
        Me.Controls.Add(Me.CheckedListBoxControl1)
        Me.Controls.Add(Me.BtnValid)
        Me.Controls.Add(Me.BtnCancel)
        Me.Name = "frmQCM_Copy_To_Filiale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Copie de QCM vers filiale"
        CType(Me.CheckedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnValid As Button
    Friend WithEvents CheckedListBoxControl1 As DevExpress.XtraEditors.CheckedListBoxControl
End Class
