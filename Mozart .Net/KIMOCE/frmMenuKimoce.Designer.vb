<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuKimoce
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
        Me.cmdGetDiKimoce = New MozartUC.apiButton()
        Me.cmdFermer = New System.Windows.Forms.Button()
        Me.cmdSendDateInter = New System.Windows.Forms.Button()
        Me.cmdSendDatePlanif = New System.Windows.Forms.Button()
        Me.cmdSendPEC = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumDI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumAction = New System.Windows.Forms.TextBox()
        Me.txtNumKimoce = New System.Windows.Forms.TextBox()
        Me.lblStatutKimoce = New System.Windows.Forms.Label()
        Me.lblDI = New System.Windows.Forms.Label()
        Me.txtDiDesc = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmdSendCloture = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdGetDiKimoce
        '
        Me.cmdGetDiKimoce.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmdGetDiKimoce.HelpContextID = 394
        Me.cmdGetDiKimoce.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGetDiKimoce.Location = New System.Drawing.Point(13, 13)
        Me.cmdGetDiKimoce.Name = "cmdGetDiKimoce"
        Me.cmdGetDiKimoce.Size = New System.Drawing.Size(88, 45)
        Me.cmdGetDiKimoce.TabIndex = 45
        Me.cmdGetDiKimoce.Tag = "2"
        Me.cmdGetDiKimoce.Text = "Interroger Kimoce"
        Me.cmdGetDiKimoce.UseVisualStyleBackColor = True
        Me.cmdGetDiKimoce.Visible = False
        '
        'cmdFermer
        '
        Me.cmdFermer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFermer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFermer.Location = New System.Drawing.Point(834, 20)
        Me.cmdFermer.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdFermer.Name = "cmdFermer"
        Me.cmdFermer.Size = New System.Drawing.Size(74, 44)
        Me.cmdFermer.TabIndex = 49
        Me.cmdFermer.Text = "Fermer"
        Me.cmdFermer.UseCompatibleTextRendering = True
        Me.cmdFermer.UseMnemonic = False
        Me.cmdFermer.UseVisualStyleBackColor = False
        '
        'cmdSendDateInter
        '
        Me.cmdSendDateInter.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdSendDateInter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSendDateInter.Location = New System.Drawing.Point(347, 13)
        Me.cmdSendDateInter.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSendDateInter.Name = "cmdSendDateInter"
        Me.cmdSendDateInter.Size = New System.Drawing.Size(110, 45)
        Me.cmdSendDateInter.TabIndex = 48
        Me.cmdSendDateInter.Text = "Envoi " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date exec"
        Me.cmdSendDateInter.UseCompatibleTextRendering = True
        Me.cmdSendDateInter.UseMnemonic = False
        Me.cmdSendDateInter.UseVisualStyleBackColor = False
        '
        'cmdSendDatePlanif
        '
        Me.cmdSendDatePlanif.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdSendDatePlanif.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSendDatePlanif.Location = New System.Drawing.Point(236, 13)
        Me.cmdSendDatePlanif.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSendDatePlanif.Name = "cmdSendDatePlanif"
        Me.cmdSendDatePlanif.Size = New System.Drawing.Size(110, 45)
        Me.cmdSendDatePlanif.TabIndex = 47
        Me.cmdSendDatePlanif.Text = "Envoi " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date planif"
        Me.cmdSendDatePlanif.UseCompatibleTextRendering = True
        Me.cmdSendDatePlanif.UseMnemonic = False
        Me.cmdSendDatePlanif.UseVisualStyleBackColor = False
        '
        'cmdSendPEC
        '
        Me.cmdSendPEC.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdSendPEC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSendPEC.Location = New System.Drawing.Point(125, 13)
        Me.cmdSendPEC.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSendPEC.Name = "cmdSendPEC"
        Me.cmdSendPEC.Size = New System.Drawing.Size(110, 45)
        Me.cmdSendPEC.TabIndex = 46
        Me.cmdSendPEC.Text = "Envoi " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Prise en charge"
        Me.cmdSendPEC.UseCompatibleTextRendering = True
        Me.cmdSendPEC.UseMnemonic = False
        Me.cmdSendPEC.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(598, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "N° DI"
        '
        'txtNumDI
        '
        Me.txtNumDI.Enabled = False
        Me.txtNumDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumDI.Location = New System.Drawing.Point(601, 36)
        Me.txtNumDI.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumDI.Name = "txtNumDI"
        Me.txtNumDI.Size = New System.Drawing.Size(94, 22)
        Me.txtNumDI.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(700, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "N° action"
        '
        'txtNumAction
        '
        Me.txtNumAction.Enabled = False
        Me.txtNumAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumAction.Location = New System.Drawing.Point(703, 36)
        Me.txtNumAction.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumAction.Name = "txtNumAction"
        Me.txtNumAction.Size = New System.Drawing.Size(94, 22)
        Me.txtNumAction.TabIndex = 54
        '
        'txtNumKimoce
        '
        Me.txtNumKimoce.Enabled = False
        Me.txtNumKimoce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumKimoce.Location = New System.Drawing.Point(601, 80)
        Me.txtNumKimoce.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumKimoce.Name = "txtNumKimoce"
        Me.txtNumKimoce.Size = New System.Drawing.Size(94, 22)
        Me.txtNumKimoce.TabIndex = 58
        '
        'lblStatutKimoce
        '
        Me.lblStatutKimoce.AutoSize = True
        Me.lblStatutKimoce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatutKimoce.Location = New System.Drawing.Point(12, 108)
        Me.lblStatutKimoce.Name = "lblStatutKimoce"
        Me.lblStatutKimoce.Size = New System.Drawing.Size(257, 15)
        Me.lblStatutKimoce.TabIndex = 62
        Me.lblStatutKimoce.Text = "Statut de la DI dans le système Kimoce"
        Me.lblStatutKimoce.Visible = False
        '
        'lblDI
        '
        Me.lblDI.AutoSize = True
        Me.lblDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDI.Location = New System.Drawing.Point(12, 177)
        Me.lblDI.Name = "lblDI"
        Me.lblDI.Size = New System.Drawing.Size(138, 15)
        Me.lblDI.TabIndex = 61
        Me.lblDI.Text = "Description de la DI "
        '
        'txtDiDesc
        '
        Me.txtDiDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiDesc.Location = New System.Drawing.Point(12, 194)
        Me.txtDiDesc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiDesc.Multiline = True
        Me.txtDiDesc.Name = "txtDiDesc"
        Me.txtDiDesc.Size = New System.Drawing.Size(900, 193)
        Me.txtDiDesc.TabIndex = 60
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.AutoEllipsis = True
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(12, 125)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(860, 40)
        Me.lblStatus.TabIndex = 59
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdSendCloture
        '
        Me.cmdSendCloture.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdSendCloture.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSendCloture.Location = New System.Drawing.Point(462, 13)
        Me.cmdSendCloture.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSendCloture.Name = "cmdSendCloture"
        Me.cmdSendCloture.Size = New System.Drawing.Size(110, 45)
        Me.cmdSendCloture.TabIndex = 63
        Me.cmdSendCloture.Text = "Envoi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cloture Inter"
        Me.cmdSendCloture.UseCompatibleTextRendering = True
        Me.cmdSendCloture.UseMnemonic = False
        Me.cmdSendCloture.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(598, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "N° Kimoce"
        '
        'frmMenuKimoce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(919, 524)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSendCloture)
        Me.Controls.Add(Me.lblStatutKimoce)
        Me.Controls.Add(Me.lblDI)
        Me.Controls.Add(Me.txtDiDesc)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtNumKimoce)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumDI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumAction)
        Me.Controls.Add(Me.cmdFermer)
        Me.Controls.Add(Me.cmdSendDateInter)
        Me.Controls.Add(Me.cmdSendDatePlanif)
        Me.Controls.Add(Me.cmdSendPEC)
        Me.Controls.Add(Me.cmdGetDiKimoce)
        Me.Name = "frmMenuKimoce"
        Me.Text = "Menu KIMOCE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cmdGetDiKimoce As MozartUC.apiButton
    Private WithEvents cmdFermer As Button
    Private WithEvents cmdSendDateInter As Button
    Private WithEvents cmdSendDatePlanif As Button
    Private WithEvents cmdSendPEC As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumDI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumAction As TextBox
    Friend WithEvents txtNumKimoce As TextBox
    Friend WithEvents lblStatutKimoce As Label
    Friend WithEvents lblDI As Label
    Friend WithEvents txtDiDesc As TextBox
    Friend WithEvents lblStatus As Label
    Private WithEvents cmdSendCloture As Button
    Friend WithEvents Label1 As Label
End Class
