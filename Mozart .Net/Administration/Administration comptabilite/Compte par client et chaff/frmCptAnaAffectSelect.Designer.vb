<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCptAnaAffectSelect
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCptAnaAffectSelect))
    Me.BtnCancel = New System.Windows.Forms.Button()
    Me.BtnValidate = New System.Windows.Forms.Button()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.CboAffect = New System.Windows.Forms.ComboBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.lblOld = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'BtnCancel
    '
    resources.ApplyResources(Me.BtnCancel, "BtnCancel")
    Me.BtnCancel.BackgroundImage = Global.MozartNet.My.Resources.Resources._stop
    Me.BtnCancel.Name = "BtnCancel"
    Me.BtnCancel.UseVisualStyleBackColor = True
    '
    'BtnValidate
    '
    resources.ApplyResources(Me.BtnValidate, "BtnValidate")
    Me.BtnValidate.BackgroundImage = Global.MozartNet.My.Resources.Resources.clean
    Me.BtnValidate.Name = "BtnValidate"
    Me.BtnValidate.UseVisualStyleBackColor = True
    '
    'LblTitre
    '
    resources.ApplyResources(Me.LblTitre, "LblTitre")
    Me.LblTitre.Name = "LblTitre"
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.ForeColor = System.Drawing.Color.Red
    Me.Label1.Name = "Label1"
    '
    'CboAffect
    '
    resources.ApplyResources(Me.CboAffect, "CboAffect")
    Me.CboAffect.DisplayMember = "NOM"
    Me.CboAffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CboAffect.FormattingEnabled = True
    Me.CboAffect.Name = "CboAffect"
    Me.CboAffect.ValueMember = "NPERNUM"
    '
    'Label3
    '
    resources.ApplyResources(Me.Label3, "Label3")
    Me.Label3.Name = "Label3"
    '
    'lblOld
    '
    resources.ApplyResources(Me.lblOld, "lblOld")
    Me.lblOld.Name = "lblOld"
    '
    'frmCptAnaAffectSelect
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.Controls.Add(Me.lblOld)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.CboAffect)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.LblTitre)
    Me.Controls.Add(Me.BtnCancel)
    Me.Controls.Add(Me.BtnValidate)
    Me.Name = "frmCptAnaAffectSelect"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents BtnValidate As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents CboAffect As System.Windows.Forms.ComboBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents lblOld As System.Windows.Forms.Label
End Class
