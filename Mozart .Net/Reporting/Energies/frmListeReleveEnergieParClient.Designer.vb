<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListeReleveEnergieParClient
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.cmdModifier = New MozartUC.apiButton()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.cmdFermer = New MozartUC.apiButton()
        Me.apiGridSite = New MozartUC.apiTGrid()
        Me.cmdAjout = New MozartUC.apiButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.apicboClient = New MozartUC.apiCombo()
        Me.SuspendLayout()
        '
        'cmdModifier
        '
        Me.cmdModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdModifier.HelpContextID = 0
        Me.cmdModifier.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdModifier.Location = New System.Drawing.Point(12, 112)
        Me.cmdModifier.Name = "cmdModifier"
        Me.cmdModifier.Size = New System.Drawing.Size(73, 49)
        Me.cmdModifier.TabIndex = 49
        Me.cmdModifier.Tag = "2"
        Me.cmdModifier.Text = "Détails"
        Me.cmdModifier.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        Me.LblTitre.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(97, 9)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(701, 29)
        Me.LblTitre.TabIndex = 47
        Me.LblTitre.Text = "Relevés de compteurs :"
        '
        'cmdFermer
        '
        Me.cmdFermer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdFermer.HelpContextID = 0
        Me.cmdFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFermer.Location = New System.Drawing.Point(12, 931)
        Me.cmdFermer.Name = "cmdFermer"
        Me.cmdFermer.Size = New System.Drawing.Size(73, 57)
        Me.cmdFermer.TabIndex = 46
        Me.cmdFermer.Tag = "15"
        Me.cmdFermer.Text = "Fermer"
        Me.cmdFermer.UseVisualStyleBackColor = True
        '
        'apiGridSite
        '
        Me.apiGridSite.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.apiGridSite.FilterBar = True
        Me.apiGridSite.FooterBar = True
        Me.apiGridSite.Location = New System.Drawing.Point(101, 90)
        Me.apiGridSite.Name = "apiGridSite"
        Me.apiGridSite.Size = New System.Drawing.Size(1565, 898)
        Me.apiGridSite.TabIndex = 44
        '
        'cmdAjout
        '
        Me.cmdAjout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdAjout.HelpContextID = 0
        Me.cmdAjout.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAjout.Location = New System.Drawing.Point(624, 41)
        Me.cmdAjout.Name = "cmdAjout"
        Me.cmdAjout.Size = New System.Drawing.Size(73, 36)
        Me.cmdAjout.TabIndex = 45
        Me.cmdAjout.Tag = ""
        Me.cmdAjout.Text = "Valider"
        Me.cmdAjout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(98, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 29)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Choix du client : "
        '
        'apicboClient
        '
        Me.apicboClient.Location = New System.Drawing.Point(230, 48)
        Me.apicboClient.Margin = New System.Windows.Forms.Padding(4)
        Me.apicboClient.Name = "apicboClient"
        Me.apicboClient.Size = New System.Drawing.Size(387, 21)
        Me.apicboClient.TabIndex = 51
        '
        'frmListeReleveEnergieParClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1886, 1000)
        Me.Controls.Add(Me.apicboClient)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdModifier)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.cmdFermer)
        Me.Controls.Add(Me.apiGridSite)
        Me.Controls.Add(Me.cmdAjout)
        Me.Name = "frmListeReleveEnergieParClient"
        Me.Text = "Relevés de compteurs"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents cmdModifier As MozartUC.apiButton
    Friend WithEvents LblTitre As Label
    Private WithEvents cmdFermer As MozartUC.apiButton
    Friend WithEvents apiGridSite As MozartUC.apiTGrid
    Private WithEvents cmdAjout As MozartUC.apiButton
    Friend WithEvents Label1 As Label
    Private WithEvents apicboClient As MozartUC.apiCombo
End Class
