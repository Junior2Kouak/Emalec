<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewTypeFormation
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewTypeFormation))
    Me.CboType = New System.Windows.Forms.ComboBox()
    Me.GrpCreateNewEquip = New System.Windows.Forms.GroupBox()
    Me.cboPer = New System.Windows.Forms.ComboBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtObs = New System.Windows.Forms.TextBox()
    Me.txtNom = New System.Windows.Forms.TextBox()
    Me.CboInter = New System.Windows.Forms.ComboBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.BtnCancel = New System.Windows.Forms.Button()
    Me.BtnCreate = New System.Windows.Forms.Button()
    Me.GrpCreateNewEquip.SuspendLayout()
    Me.SuspendLayout()
    '
    'CboType
    '
    Me.CboType.FormattingEnabled = True
    Me.CboType.Items.AddRange(New Object() {resources.GetString("CboType.Items"), resources.GetString("CboType.Items1")})
    resources.ApplyResources(Me.CboType, "CboType")
    Me.CboType.Name = "CboType"
    '
    'GrpCreateNewEquip
    '
    Me.GrpCreateNewEquip.Controls.Add(Me.cboPer)
    Me.GrpCreateNewEquip.Controls.Add(Me.CboType)
    Me.GrpCreateNewEquip.Controls.Add(Me.Label6)
    Me.GrpCreateNewEquip.Controls.Add(Me.txtObs)
    Me.GrpCreateNewEquip.Controls.Add(Me.txtNom)
    Me.GrpCreateNewEquip.Controls.Add(Me.CboInter)
    Me.GrpCreateNewEquip.Controls.Add(Me.Label3)
    Me.GrpCreateNewEquip.Controls.Add(Me.Label2)
    Me.GrpCreateNewEquip.Controls.Add(Me.Label1)
    Me.GrpCreateNewEquip.Controls.Add(Me.BtnCancel)
    Me.GrpCreateNewEquip.Controls.Add(Me.BtnCreate)
    resources.ApplyResources(Me.GrpCreateNewEquip, "GrpCreateNewEquip")
    Me.GrpCreateNewEquip.Name = "GrpCreateNewEquip"
    Me.GrpCreateNewEquip.TabStop = False
    '
    'cboPer
    '
    Me.cboPer.DisplayMember = "VINTNOM"
    Me.cboPer.FormattingEnabled = True
    resources.ApplyResources(Me.cboPer, "cboPer")
    Me.cboPer.Name = "cboPer"
    Me.cboPer.ValueMember = "NINTNUM"
    '
    'Label6
    '
    resources.ApplyResources(Me.Label6, "Label6")
    Me.Label6.Name = "Label6"
    '
    'txtObs
    '
    resources.ApplyResources(Me.txtObs, "txtObs")
    Me.txtObs.Name = "txtObs"
    '
    'txtNom
    '
    resources.ApplyResources(Me.txtNom, "txtNom")
    Me.txtNom.Name = "txtNom"
    '
    'CboInter
    '
    Me.CboInter.DisplayMember = "VINTNOM"
    Me.CboInter.FormattingEnabled = True
    resources.ApplyResources(Me.CboInter, "CboInter")
    Me.CboInter.Name = "CboInter"
    Me.CboInter.ValueMember = "NINTNUM"
    '
    'Label3
    '
    resources.ApplyResources(Me.Label3, "Label3")
    Me.Label3.Name = "Label3"
    '
    'Label2
    '
    resources.ApplyResources(Me.Label2, "Label2")
    Me.Label2.Name = "Label2"
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.Name = "Label1"
    '
    'BtnCancel
    '
    resources.ApplyResources(Me.BtnCancel, "BtnCancel")
    Me.BtnCancel.Name = "BtnCancel"
    Me.BtnCancel.UseVisualStyleBackColor = True
    '
    'BtnCreate
    '
    resources.ApplyResources(Me.BtnCreate, "BtnCreate")
    Me.BtnCreate.Name = "BtnCreate"
    Me.BtnCreate.UseVisualStyleBackColor = True
    '
    'frmNewTypeFormation
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.Controls.Add(Me.GrpCreateNewEquip)
    Me.Name = "frmNewTypeFormation"
    Me.GrpCreateNewEquip.ResumeLayout(False)
    Me.GrpCreateNewEquip.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents CboType As System.Windows.Forms.ComboBox
  Friend WithEvents GrpCreateNewEquip As System.Windows.Forms.GroupBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents txtObs As System.Windows.Forms.TextBox
  Friend WithEvents txtNom As System.Windows.Forms.TextBox
  Friend WithEvents CboInter As System.Windows.Forms.ComboBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents BtnCancel As System.Windows.Forms.Button
  Friend WithEvents BtnCreate As System.Windows.Forms.Button
  Friend WithEvents cboPer As System.Windows.Forms.ComboBox
End Class
