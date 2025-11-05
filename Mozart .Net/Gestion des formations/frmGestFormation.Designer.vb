<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestFormation
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestFormation))
    Me.CboForm = New System.Windows.Forms.ComboBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtObs = New System.Windows.Forms.TextBox()
    Me.CboTech = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.GrpCreateNewEquip = New System.Windows.Forms.GroupBox()
    Me.BtnSupp = New System.Windows.Forms.Button()
    Me.BtnOpen = New System.Windows.Forms.Button()
    Me.TxtVFICHIER = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.DtRecycle = New System.Windows.Forms.DateTimePicker()
    Me.DtForm = New System.Windows.Forms.DateTimePicker()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.BtnCancel = New System.Windows.Forms.Button()
    Me.BtnCreate = New System.Windows.Forms.Button()
    Me.OFD = New System.Windows.Forms.OpenFileDialog()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.chkCarte = New System.Windows.Forms.CheckBox()
    Me.GrpCreateNewEquip.SuspendLayout()
    Me.SuspendLayout()
    '
    'CboForm
    '
    Me.CboForm.DisplayMember = "VINTNOM"
    Me.CboForm.FormattingEnabled = True
    resources.ApplyResources(Me.CboForm, "CboForm")
    Me.CboForm.Name = "CboForm"
    Me.CboForm.ValueMember = "NINTNUM"
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
    'CboTech
    '
    Me.CboTech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
    Me.CboTech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.CboTech.DisplayMember = "VINTNOM"
    Me.CboTech.FormattingEnabled = True
    resources.ApplyResources(Me.CboTech, "CboTech")
    Me.CboTech.Name = "CboTech"
    Me.CboTech.ValueMember = "NINTNUM"
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.Name = "Label1"
    '
    'GrpCreateNewEquip
    '
    Me.GrpCreateNewEquip.Controls.Add(Me.Label7)
    Me.GrpCreateNewEquip.Controls.Add(Me.chkCarte)
    Me.GrpCreateNewEquip.Controls.Add(Me.BtnSupp)
    Me.GrpCreateNewEquip.Controls.Add(Me.BtnOpen)
    Me.GrpCreateNewEquip.Controls.Add(Me.TxtVFICHIER)
    Me.GrpCreateNewEquip.Controls.Add(Me.Label5)
    Me.GrpCreateNewEquip.Controls.Add(Me.DtRecycle)
    Me.GrpCreateNewEquip.Controls.Add(Me.DtForm)
    Me.GrpCreateNewEquip.Controls.Add(Me.Label4)
    Me.GrpCreateNewEquip.Controls.Add(Me.CboForm)
    Me.GrpCreateNewEquip.Controls.Add(Me.Label6)
    Me.GrpCreateNewEquip.Controls.Add(Me.txtObs)
    Me.GrpCreateNewEquip.Controls.Add(Me.CboTech)
    Me.GrpCreateNewEquip.Controls.Add(Me.Label3)
    Me.GrpCreateNewEquip.Controls.Add(Me.Label2)
    Me.GrpCreateNewEquip.Controls.Add(Me.Label1)
    Me.GrpCreateNewEquip.Controls.Add(Me.BtnCancel)
    Me.GrpCreateNewEquip.Controls.Add(Me.BtnCreate)
    resources.ApplyResources(Me.GrpCreateNewEquip, "GrpCreateNewEquip")
    Me.GrpCreateNewEquip.Name = "GrpCreateNewEquip"
    Me.GrpCreateNewEquip.TabStop = False
    '
    'BtnSupp
    '
    resources.ApplyResources(Me.BtnSupp, "BtnSupp")
    Me.BtnSupp.Name = "BtnSupp"
    Me.BtnSupp.Tag = "647"
    Me.BtnSupp.UseVisualStyleBackColor = True
    '
    'BtnOpen
    '
    resources.ApplyResources(Me.BtnOpen, "BtnOpen")
    Me.BtnOpen.Name = "BtnOpen"
    Me.BtnOpen.Tag = "647"
    Me.BtnOpen.UseVisualStyleBackColor = True
    '
    'TxtVFICHIER
    '
    resources.ApplyResources(Me.TxtVFICHIER, "TxtVFICHIER")
    Me.TxtVFICHIER.Name = "TxtVFICHIER"
    Me.TxtVFICHIER.ReadOnly = True
    Me.TxtVFICHIER.Tag = ""
    '
    'Label5
    '
    resources.ApplyResources(Me.Label5, "Label5")
    Me.Label5.Name = "Label5"
    Me.Label5.Tag = ""
    '
    'DtRecycle
    '
    resources.ApplyResources(Me.DtRecycle, "DtRecycle")
    Me.DtRecycle.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.DtRecycle.Name = "DtRecycle"
    Me.DtRecycle.ShowCheckBox = True
    '
    'DtForm
    '
    Me.DtForm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    resources.ApplyResources(Me.DtForm, "DtForm")
    Me.DtForm.Name = "DtForm"
    '
    'Label4
    '
    resources.ApplyResources(Me.Label4, "Label4")
    Me.Label4.Name = "Label4"
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
    'OFD
    '
    resources.ApplyResources(Me.OFD, "OFD")
    '
    'Label7
    '
    resources.ApplyResources(Me.Label7, "Label7")
    Me.Label7.Name = "Label7"
    '
    'chkCarte
    '
    resources.ApplyResources(Me.chkCarte, "chkCarte")
    Me.chkCarte.Name = "chkCarte"
    Me.chkCarte.UseVisualStyleBackColor = True
    '
    'frmGestFormation
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.Controls.Add(Me.GrpCreateNewEquip)
    Me.Name = "frmGestFormation"
    Me.GrpCreateNewEquip.ResumeLayout(False)
    Me.GrpCreateNewEquip.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents CboForm As System.Windows.Forms.ComboBox
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents txtObs As System.Windows.Forms.TextBox
	Friend WithEvents CboTech As System.Windows.Forms.ComboBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents GrpCreateNewEquip As System.Windows.Forms.GroupBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents BtnCancel As System.Windows.Forms.Button
	Friend WithEvents BtnCreate As System.Windows.Forms.Button
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents DtForm As System.Windows.Forms.DateTimePicker
	Friend WithEvents DtRecycle As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnOpen As Button
    Friend WithEvents TxtVFICHIER As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents BtnSupp As Button
  Friend WithEvents Label7 As Label
  Friend WithEvents chkCarte As CheckBox
End Class
