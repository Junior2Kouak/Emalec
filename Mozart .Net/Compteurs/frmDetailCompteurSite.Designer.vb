<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailCompteurSite
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
        Me.Frame1 = New MozartUC.apiGroupBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtRemarque = New MozartUC.apiTextBox()
        Me.ApiLabel5 = New MozartUC.apiLabel()
        Me.txtIDliaison = New MozartUC.apiTextBox()
        Me.ApiLabel4 = New MozartUC.apiLabel()
        Me.txtEmplacement = New MozartUC.apiTextBox()
        Me.ApiLabel3 = New MozartUC.apiLabel()
        Me.txtNumero = New MozartUC.apiTextBox()
        Me.ApiLabel2 = New MozartUC.apiLabel()
        Me.ApiLabel1 = New MozartUC.apiLabel()
        Me.txtDate = New MozartUC.apiTextBox()
        Me.txtNom = New MozartUC.apiTextBox()
        Me.lblLabels0 = New MozartUC.apiLabel()
        Me.lblLabels12 = New MozartUC.apiLabel()
        Me.cmdFermer = New MozartUC.apiButton()
        Me.cmdValider = New MozartUC.apiButton()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.ChkCO2 = New System.Windows.Forms.CheckBox()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Frame1.Controls.Add(Me.ChkCO2)
        Me.Frame1.Controls.Add(Me.cboType)
        Me.Frame1.Controls.Add(Me.txtRemarque)
        Me.Frame1.Controls.Add(Me.ApiLabel5)
        Me.Frame1.Controls.Add(Me.txtIDliaison)
        Me.Frame1.Controls.Add(Me.ApiLabel4)
        Me.Frame1.Controls.Add(Me.txtEmplacement)
        Me.Frame1.Controls.Add(Me.ApiLabel3)
        Me.Frame1.Controls.Add(Me.txtNumero)
        Me.Frame1.Controls.Add(Me.ApiLabel2)
        Me.Frame1.Controls.Add(Me.ApiLabel1)
        Me.Frame1.Controls.Add(Me.txtDate)
        Me.Frame1.Controls.Add(Me.txtNom)
        Me.Frame1.Controls.Add(Me.lblLabels0)
        Me.Frame1.Controls.Add(Me.lblLabels12)
        Me.Frame1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Frame1.FrameColor = System.Drawing.Color.Empty
        Me.Frame1.HelpContextID = 0
        Me.Frame1.Location = New System.Drawing.Point(121, 66)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(679, 499)
        Me.Frame1.TabIndex = 6
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Informations  du compteur"
        '
        'cboType
        '
        Me.cboType.DisplayMember = "VINFOLIB"
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cboType.Location = New System.Drawing.Point(193, 89)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(405, 24)
        Me.cboType.TabIndex = 27
        Me.cboType.ValueMember = "NINFONUM"
        '
        'txtRemarque
        '
        Me.txtRemarque.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRemarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtRemarque.HelpContextID = 0
        Me.txtRemarque.Location = New System.Drawing.Point(193, 328)
        Me.txtRemarque.Multiline = True
        Me.txtRemarque.Name = "txtRemarque"
        Me.txtRemarque.Size = New System.Drawing.Size(405, 104)
        Me.txtRemarque.TabIndex = 21
        '
        'ApiLabel5
        '
        Me.ApiLabel5.AutoSize = True
        Me.ApiLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ApiLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ApiLabel5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ApiLabel5.HelpContextID = 0
        Me.ApiLabel5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ApiLabel5.Location = New System.Drawing.Point(18, 328)
        Me.ApiLabel5.Name = "ApiLabel5"
        Me.ApiLabel5.Size = New System.Drawing.Size(95, 18)
        Me.ApiLabel5.TabIndex = 22
        Me.ApiLabel5.Text = "Remarque :"
        Me.ApiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIDliaison
        '
        Me.txtIDliaison.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIDliaison.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtIDliaison.HelpContextID = 0
        Me.txtIDliaison.Location = New System.Drawing.Point(193, 233)
        Me.txtIDliaison.Name = "txtIDliaison"
        Me.txtIDliaison.Size = New System.Drawing.Size(163, 26)
        Me.txtIDliaison.TabIndex = 19
        '
        'ApiLabel4
        '
        Me.ApiLabel4.AutoSize = True
        Me.ApiLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ApiLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ApiLabel4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ApiLabel4.HelpContextID = 0
        Me.ApiLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ApiLabel4.Location = New System.Drawing.Point(18, 233)
        Me.ApiLabel4.Name = "ApiLabel4"
        Me.ApiLabel4.Size = New System.Drawing.Size(102, 18)
        Me.ApiLabel4.TabIndex = 20
        Me.ApiLabel4.Text = "ID Adaptive :"
        Me.ApiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmplacement
        '
        Me.txtEmplacement.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmplacement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtEmplacement.HelpContextID = 0
        Me.txtEmplacement.Location = New System.Drawing.Point(193, 185)
        Me.txtEmplacement.Name = "txtEmplacement"
        Me.txtEmplacement.Size = New System.Drawing.Size(281, 26)
        Me.txtEmplacement.TabIndex = 17
        '
        'ApiLabel3
        '
        Me.ApiLabel3.AutoSize = True
        Me.ApiLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ApiLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ApiLabel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ApiLabel3.HelpContextID = 0
        Me.ApiLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ApiLabel3.Location = New System.Drawing.Point(18, 185)
        Me.ApiLabel3.Name = "ApiLabel3"
        Me.ApiLabel3.Size = New System.Drawing.Size(120, 18)
        Me.ApiLabel3.TabIndex = 18
        Me.ApiLabel3.Text = "Emplacement :"
        Me.ApiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtNumero.HelpContextID = 0
        Me.txtNumero.Location = New System.Drawing.Point(193, 137)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(281, 26)
        Me.txtNumero.TabIndex = 15
        '
        'ApiLabel2
        '
        Me.ApiLabel2.AutoSize = True
        Me.ApiLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ApiLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ApiLabel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ApiLabel2.HelpContextID = 0
        Me.ApiLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ApiLabel2.Location = New System.Drawing.Point(18, 137)
        Me.ApiLabel2.Name = "ApiLabel2"
        Me.ApiLabel2.Size = New System.Drawing.Size(78, 18)
        Me.ApiLabel2.TabIndex = 16
        Me.ApiLabel2.Text = "Numéro :"
        Me.ApiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ApiLabel1
        '
        Me.ApiLabel1.AutoSize = True
        Me.ApiLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ApiLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ApiLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ApiLabel1.HelpContextID = 0
        Me.ApiLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ApiLabel1.Location = New System.Drawing.Point(18, 89)
        Me.ApiLabel1.Name = "ApiLabel1"
        Me.ApiLabel1.Size = New System.Drawing.Size(54, 18)
        Me.ApiLabel1.TabIndex = 14
        Me.ApiLabel1.Text = "Type :"
        Me.ApiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDate.Enabled = False
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtDate.HelpContextID = 0
        Me.txtDate.Location = New System.Drawing.Point(194, 281)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(162, 26)
        Me.txtDate.TabIndex = 11
        '
        'txtNom
        '
        Me.txtNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtNom.HelpContextID = 0
        Me.txtNom.Location = New System.Drawing.Point(193, 42)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(405, 26)
        Me.txtNom.TabIndex = 7
        '
        'lblLabels0
        '
        Me.lblLabels0.AutoSize = True
        Me.lblLabels0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLabels0.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabels0.HelpContextID = 0
        Me.lblLabels0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabels0.Location = New System.Drawing.Point(18, 281)
        Me.lblLabels0.Name = "lblLabels0"
        Me.lblLabels0.Size = New System.Drawing.Size(142, 18)
        Me.lblLabels0.TabIndex = 12
        Me.lblLabels0.Text = "Date de création :"
        Me.lblLabels0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLabels12
        '
        Me.lblLabels12.AutoSize = True
        Me.lblLabels12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLabels12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabels12.HelpContextID = 0
        Me.lblLabels12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabels12.Location = New System.Drawing.Point(18, 41)
        Me.lblLabels12.Name = "lblLabels12"
        Me.lblLabels12.Size = New System.Drawing.Size(59, 18)
        Me.lblLabels12.TabIndex = 8
        Me.lblLabels12.Text = "Nom  :"
        Me.lblLabels12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdFermer
        '
        Me.cmdFermer.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdFermer.HelpContextID = 0
        Me.cmdFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFermer.Location = New System.Drawing.Point(8, 518)
        Me.cmdFermer.Name = "cmdFermer"
        Me.cmdFermer.Size = New System.Drawing.Size(77, 47)
        Me.cmdFermer.TabIndex = 41
        Me.cmdFermer.Tag = "15"
        Me.cmdFermer.Text = "Fermer"
        Me.cmdFermer.UseVisualStyleBackColor = True
        '
        'cmdValider
        '
        Me.cmdValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdValider.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdValider.HelpContextID = 0
        Me.cmdValider.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdValider.Location = New System.Drawing.Point(8, 66)
        Me.cmdValider.Name = "cmdValider"
        Me.cmdValider.Size = New System.Drawing.Size(77, 49)
        Me.cmdValider.TabIndex = 42
        Me.cmdValider.Tag = "66"
        Me.cmdValider.Text = "Enregistrer"
        Me.cmdValider.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        Me.LblTitre.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(117, 19)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(701, 29)
        Me.LblTitre.TabIndex = 43
        Me.LblTitre.Text = "Site :"
        '
        'ChkCO2
        '
        Me.ChkCO2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ChkCO2.ForeColor = System.Drawing.Color.Black
        Me.ChkCO2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ChkCO2.Location = New System.Drawing.Point(21, 455)
        Me.ChkCO2.Name = "ChkCO2"
        Me.ChkCO2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkCO2.Size = New System.Drawing.Size(186, 34)
        Me.ChkCO2.TabIndex = 28
        Me.ChkCO2.Text = ": Impact CO2"
        Me.ChkCO2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkCO2.UseVisualStyleBackColor = True
        '
        'frmDetailCompteurSite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(825, 583)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.cmdValider)
        Me.Controls.Add(Me.cmdFermer)
        Me.Controls.Add(Me.Frame1)
        Me.Name = "frmDetailCompteurSite"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmDetailCompteurSite"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Frame1 As MozartUC.apiGroupBox
    Private WithEvents txtDate As MozartUC.apiTextBox
    Private WithEvents txtNom As MozartUC.apiTextBox
    Private WithEvents lblLabels0 As MozartUC.apiLabel
    Private WithEvents lblLabels12 As MozartUC.apiLabel
    Private WithEvents cmdFermer As MozartUC.apiButton
    Private WithEvents cmdValider As MozartUC.apiButton
    Friend WithEvents LblTitre As Label
    Private WithEvents txtRemarque As MozartUC.apiTextBox
    Private WithEvents ApiLabel5 As MozartUC.apiLabel
    Private WithEvents txtIDliaison As MozartUC.apiTextBox
    Private WithEvents ApiLabel4 As MozartUC.apiLabel
    Private WithEvents txtEmplacement As MozartUC.apiTextBox
    Private WithEvents ApiLabel3 As MozartUC.apiLabel
    Private WithEvents txtNumero As MozartUC.apiTextBox
    Private WithEvents ApiLabel2 As MozartUC.apiLabel
    Private WithEvents ApiLabel1 As MozartUC.apiLabel
    Private WithEvents cboType As ComboBox
    Friend WithEvents ChkCO2 As CheckBox
End Class
