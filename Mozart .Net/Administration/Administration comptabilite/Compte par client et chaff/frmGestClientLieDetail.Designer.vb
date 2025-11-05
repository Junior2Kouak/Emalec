<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestClientLieDetail
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestClientLieDetail))
    Me.Label3 = New System.Windows.Forms.Label()
    Me.CboSociete = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.ApiComboClient = New MozartUC.apiCombo()
    Me.cmdNouvelle = New MozartUC.apiButton()
    Me.cmdFermer = New MozartUC.apiButton()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.txtCompte = New MozartUC.apiTextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'Label3
    '
    resources.ApplyResources(Me.Label3, "Label3")
    Me.Label3.Name = "Label3"
    '
    'CboSociete
    '
    resources.ApplyResources(Me.CboSociete, "CboSociete")
    Me.CboSociete.DisplayMember = "VSOCIETENOM"
    Me.CboSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CboSociete.FormattingEnabled = True
    Me.CboSociete.Name = "CboSociete"
    Me.CboSociete.ValueMember = "NSOCIETEID"
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.Name = "Label1"
    '
    'ApiComboClient
    '
    resources.ApplyResources(Me.ApiComboClient, "ApiComboClient")
    Me.ApiComboClient.Name = "ApiComboClient"
    '
    'cmdNouvelle
    '
    resources.ApplyResources(Me.cmdNouvelle, "cmdNouvelle")
    Me.cmdNouvelle.HelpContextID = 0
    Me.cmdNouvelle.Name = "cmdNouvelle"
    Me.cmdNouvelle.Tag = "2"
    Me.cmdNouvelle.UseVisualStyleBackColor = True
    '
    'cmdFermer
    '
    resources.ApplyResources(Me.cmdFermer, "cmdFermer")
    Me.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.cmdFermer.HelpContextID = 0
    Me.cmdFermer.Name = "cmdFermer"
    Me.cmdFermer.Tag = "15"
    Me.cmdFermer.UseVisualStyleBackColor = True
    '
    'LblTitre
    '
    resources.ApplyResources(Me.LblTitre, "LblTitre")
    Me.LblTitre.Name = "LblTitre"
    '
    'txtCompte
    '
    resources.ApplyResources(Me.txtCompte, "txtCompte")
    Me.txtCompte.HelpContextID = 0
    Me.txtCompte.Name = "txtCompte"
    '
    'Label2
    '
    resources.ApplyResources(Me.Label2, "Label2")
    Me.Label2.Name = "Label2"
    '
    'frmGestClientLieDetail
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtCompte)
    Me.Controls.Add(Me.LblTitre)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.CboSociete)
    Me.Controls.Add(Me.ApiComboClient)
    Me.Controls.Add(Me.cmdNouvelle)
    Me.Controls.Add(Me.cmdFermer)
    Me.Name = "frmGestClientLieDetail"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Private WithEvents cmdFermer As MozartUC.apiButton
    Private WithEvents cmdNouvelle As MozartUC.apiButton
    Friend WithEvents ApiComboClient As MozartUC.apiCombo
    Friend WithEvents Label3 As Label
    Friend WithEvents CboSociete As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblTitre As Label
    Friend WithEvents txtCompte As MozartUC.apiTextBox
    Friend WithEvents Label2 As Label
End Class
