<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCQSE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCQSE))
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkN2 = New System.Windows.Forms.CheckBox()
        Me.chkN1 = New System.Windows.Forms.CheckBox()
        Me.chkO2 = New System.Windows.Forms.CheckBox()
        Me.chkO1 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkN3 = New System.Windows.Forms.CheckBox()
        Me.chkO3 = New System.Windows.Forms.CheckBox()
        Me.chkFO = New System.Windows.Forms.CheckBox()
        Me.GBON = New System.Windows.Forms.GroupBox()
        Me.GBON.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.ForeColor = System.Drawing.Color.IndianRed
        Me.LblTitre.Name = "LblTitre"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Name = "Label6"
        '
        'chkN2
        '
        resources.ApplyResources(Me.chkN2, "chkN2")
        Me.chkN2.ForeColor = System.Drawing.Color.Teal
        Me.chkN2.Name = "chkN2"
        Me.chkN2.UseVisualStyleBackColor = True
        '
        'chkN1
        '
        resources.ApplyResources(Me.chkN1, "chkN1")
        Me.chkN1.ForeColor = System.Drawing.Color.Teal
        Me.chkN1.Name = "chkN1"
        Me.chkN1.UseVisualStyleBackColor = True
        '
        'chkO2
        '
        resources.ApplyResources(Me.chkO2, "chkO2")
        Me.chkO2.ForeColor = System.Drawing.Color.Teal
        Me.chkO2.Name = "chkO2"
        Me.chkO2.UseVisualStyleBackColor = True
        '
        'chkO1
        '
        resources.ApplyResources(Me.chkO1, "chkO1")
        Me.chkO1.ForeColor = System.Drawing.Color.Teal
        Me.chkO1.Name = "chkO1"
        Me.chkO1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Name = "Label7"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Name = "Label8"
        '
        'chkN3
        '
        resources.ApplyResources(Me.chkN3, "chkN3")
        Me.chkN3.ForeColor = System.Drawing.Color.Teal
        Me.chkN3.Name = "chkN3"
        Me.chkN3.UseVisualStyleBackColor = True
        '
        'chkO3
        '
        resources.ApplyResources(Me.chkO3, "chkO3")
        Me.chkO3.ForeColor = System.Drawing.Color.Teal
        Me.chkO3.Name = "chkO3"
        Me.chkO3.UseVisualStyleBackColor = True
        '
        'chkFO
        '
        resources.ApplyResources(Me.chkFO, "chkFO")
        Me.chkFO.ForeColor = System.Drawing.Color.Teal
        Me.chkFO.Name = "chkFO"
        Me.chkFO.UseVisualStyleBackColor = True
        '
        'GBON
        '
        Me.GBON.Controls.Add(Me.chkO1)
        Me.GBON.Controls.Add(Me.chkO2)
        Me.GBON.Controls.Add(Me.Label6)
        Me.GBON.Controls.Add(Me.Label8)
        Me.GBON.Controls.Add(Me.Label5)
        Me.GBON.Controls.Add(Me.Label4)
        Me.GBON.Controls.Add(Me.chkO3)
        Me.GBON.Controls.Add(Me.Label7)
        Me.GBON.Controls.Add(Me.chkN1)
        Me.GBON.Controls.Add(Me.chkN3)
        Me.GBON.Controls.Add(Me.chkN2)
        resources.ApplyResources(Me.GBON, "GBON")
        Me.GBON.Name = "GBON"
        Me.GBON.TabStop = False
        '
        'UCQSE
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Controls.Add(Me.GBON)
        Me.Controls.Add(Me.chkFO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "UCQSE"
        Me.GBON.ResumeLayout(False)
        Me.GBON.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chkN2 As CheckBox
    Friend WithEvents chkN1 As CheckBox
    Friend WithEvents chkO2 As CheckBox
    Friend WithEvents chkO1 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents chkN3 As CheckBox
    Friend WithEvents chkO3 As CheckBox
    Friend WithEvents chkFO As CheckBox
    Friend WithEvents GBON As GroupBox
End Class
