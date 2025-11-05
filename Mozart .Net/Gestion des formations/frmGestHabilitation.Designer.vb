<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestHabilitation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestHabilitation))
        Me.CboTech = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpCreateNewEquip = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PanelDate = New System.Windows.Forms.Panel()
        Me.DATEEMI = New System.Windows.Forms.DateTimePicker()
        Me.DATEVALID = New System.Windows.Forms.DateTimePicker()
        Me.DATEREV2 = New System.Windows.Forms.DateTimePicker()
        Me.DATEREV1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TAB23 = New System.Windows.Forms.TextBox()
        Me.TAB22 = New System.Windows.Forms.TextBox()
        Me.TAB20 = New System.Windows.Forms.TextBox()
        Me.TAB19 = New System.Windows.Forms.TextBox()
        Me.TAB17 = New System.Windows.Forms.TextBox()
        Me.TAB16 = New System.Windows.Forms.TextBox()
        Me.TAB14 = New System.Windows.Forms.TextBox()
        Me.TAB13 = New System.Windows.Forms.TextBox()
        Me.TAB11 = New System.Windows.Forms.TextBox()
        Me.TAB10 = New System.Windows.Forms.TextBox()
        Me.TAB8 = New System.Windows.Forms.TextBox()
        Me.TAB7 = New System.Windows.Forms.TextBox()
        Me.TAB5 = New System.Windows.Forms.TextBox()
        Me.TAB4 = New System.Windows.Forms.TextBox()
        Me.TAB2 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TAB1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GrpCreateNewEquip.SuspendLayout()
        Me.PanelDate.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CboTech
        '
        resources.ApplyResources(Me.CboTech, "CboTech")
        Me.CboTech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboTech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboTech.DisplayMember = "VPERNOM"
        Me.CboTech.FormattingEnabled = True
        Me.CboTech.Name = "CboTech"
        Me.CboTech.ValueMember = "NPERNUM"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'GrpCreateNewEquip
        '
        resources.ApplyResources(Me.GrpCreateNewEquip, "GrpCreateNewEquip")
        Me.GrpCreateNewEquip.Controls.Add(Me.Label19)
        Me.GrpCreateNewEquip.Controls.Add(Me.PanelDate)
        Me.GrpCreateNewEquip.Controls.Add(Me.Label5)
        Me.GrpCreateNewEquip.Controls.Add(Me.Label4)
        Me.GrpCreateNewEquip.Controls.Add(Me.Label2)
        Me.GrpCreateNewEquip.Controls.Add(Me.CboTech)
        Me.GrpCreateNewEquip.Controls.Add(Me.Label1)
        Me.GrpCreateNewEquip.Name = "GrpCreateNewEquip"
        Me.GrpCreateNewEquip.TabStop = False
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.Name = "Label19"
        '
        'PanelDate
        '
        resources.ApplyResources(Me.PanelDate, "PanelDate")
        Me.PanelDate.Controls.Add(Me.DATEEMI)
        Me.PanelDate.Controls.Add(Me.DATEVALID)
        Me.PanelDate.Controls.Add(Me.DATEREV2)
        Me.PanelDate.Controls.Add(Me.DATEREV1)
        Me.PanelDate.Name = "PanelDate"
        '
        'DATEEMI
        '
        resources.ApplyResources(Me.DATEEMI, "DATEEMI")
        Me.DATEEMI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DATEEMI.Name = "DATEEMI"
        Me.DATEEMI.ShowCheckBox = True
        '
        'DATEVALID
        '
        resources.ApplyResources(Me.DATEVALID, "DATEVALID")
        Me.DATEVALID.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DATEVALID.Name = "DATEVALID"
        Me.DATEVALID.ShowCheckBox = True
        '
        'DATEREV2
        '
        resources.ApplyResources(Me.DATEREV2, "DATEREV2")
        Me.DATEREV2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DATEREV2.Name = "DATEREV2"
        Me.DATEREV2.ShowCheckBox = True
        '
        'DATEREV1
        '
        resources.ApplyResources(Me.DATEREV1, "DATEREV1")
        Me.DATEREV1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DATEREV1.Name = "DATEREV1"
        Me.DATEREV1.ShowCheckBox = True
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
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
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackColor = System.Drawing.Color.Wheat
        Me.GroupBox1.Controls.Add(Me.TAB23)
        Me.GroupBox1.Controls.Add(Me.TAB22)
        Me.GroupBox1.Controls.Add(Me.TAB20)
        Me.GroupBox1.Controls.Add(Me.TAB19)
        Me.GroupBox1.Controls.Add(Me.TAB17)
        Me.GroupBox1.Controls.Add(Me.TAB16)
        Me.GroupBox1.Controls.Add(Me.TAB14)
        Me.GroupBox1.Controls.Add(Me.TAB13)
        Me.GroupBox1.Controls.Add(Me.TAB11)
        Me.GroupBox1.Controls.Add(Me.TAB10)
        Me.GroupBox1.Controls.Add(Me.TAB8)
        Me.GroupBox1.Controls.Add(Me.TAB7)
        Me.GroupBox1.Controls.Add(Me.TAB5)
        Me.GroupBox1.Controls.Add(Me.TAB4)
        Me.GroupBox1.Controls.Add(Me.TAB2)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TAB1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'TAB23
        '
        resources.ApplyResources(Me.TAB23, "TAB23")
        Me.TAB23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB23.Name = "TAB23"
        '
        'TAB22
        '
        resources.ApplyResources(Me.TAB22, "TAB22")
        Me.TAB22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB22.Name = "TAB22"
        '
        'TAB20
        '
        resources.ApplyResources(Me.TAB20, "TAB20")
        Me.TAB20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB20.Name = "TAB20"
        '
        'TAB19
        '
        resources.ApplyResources(Me.TAB19, "TAB19")
        Me.TAB19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB19.Name = "TAB19"
        '
        'TAB17
        '
        resources.ApplyResources(Me.TAB17, "TAB17")
        Me.TAB17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB17.Name = "TAB17"
        '
        'TAB16
        '
        resources.ApplyResources(Me.TAB16, "TAB16")
        Me.TAB16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB16.Name = "TAB16"
        '
        'TAB14
        '
        resources.ApplyResources(Me.TAB14, "TAB14")
        Me.TAB14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB14.Name = "TAB14"
        '
        'TAB13
        '
        resources.ApplyResources(Me.TAB13, "TAB13")
        Me.TAB13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB13.Name = "TAB13"
        '
        'TAB11
        '
        resources.ApplyResources(Me.TAB11, "TAB11")
        Me.TAB11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB11.Name = "TAB11"
        '
        'TAB10
        '
        resources.ApplyResources(Me.TAB10, "TAB10")
        Me.TAB10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB10.Name = "TAB10"
        '
        'TAB8
        '
        resources.ApplyResources(Me.TAB8, "TAB8")
        Me.TAB8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB8.Name = "TAB8"
        '
        'TAB7
        '
        resources.ApplyResources(Me.TAB7, "TAB7")
        Me.TAB7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB7.Name = "TAB7"
        '
        'TAB5
        '
        resources.ApplyResources(Me.TAB5, "TAB5")
        Me.TAB5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB5.Name = "TAB5"
        '
        'TAB4
        '
        resources.ApplyResources(Me.TAB4, "TAB4")
        Me.TAB4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB4.Name = "TAB4"
        '
        'TAB2
        '
        resources.ApplyResources(Me.TAB2, "TAB2")
        Me.TAB2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB2.Name = "TAB2"
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Name = "Label18"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Name = "Label17"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Name = "Label16"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Name = "Label8"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Name = "Label6"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Name = "Label3"
        '
        'TAB1
        '
        resources.ApplyResources(Me.TAB1, "TAB1")
        Me.TAB1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB1.Name = "TAB1"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Name = "Label15"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Name = "Label14"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.BackColor = System.Drawing.Color.Linen
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Name = "Label13"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Name = "Label11"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Name = "Label10"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.BackColor = System.Drawing.Color.Linen
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Name = "Label7"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Name = "Label9"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmGestHabilitation
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.GrpCreateNewEquip)
        Me.Name = "frmGestHabilitation"
        Me.GrpCreateNewEquip.ResumeLayout(False)
        Me.PanelDate.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CboTech As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpCreateNewEquip As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnCreate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TAB1 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents TAB23 As System.Windows.Forms.TextBox
    Friend WithEvents TAB22 As System.Windows.Forms.TextBox
  Friend WithEvents TAB20 As System.Windows.Forms.TextBox
    Friend WithEvents TAB19 As System.Windows.Forms.TextBox
  Friend WithEvents TAB17 As System.Windows.Forms.TextBox
    Friend WithEvents TAB16 As System.Windows.Forms.TextBox
  Friend WithEvents TAB14 As System.Windows.Forms.TextBox
    Friend WithEvents TAB13 As System.Windows.Forms.TextBox
  Friend WithEvents TAB11 As System.Windows.Forms.TextBox
    Friend WithEvents TAB10 As System.Windows.Forms.TextBox
  Friend WithEvents TAB8 As System.Windows.Forms.TextBox
    Friend WithEvents TAB7 As System.Windows.Forms.TextBox
  Friend WithEvents TAB5 As System.Windows.Forms.TextBox
    Friend WithEvents TAB4 As System.Windows.Forms.TextBox
  Friend WithEvents TAB2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PanelDate As System.Windows.Forms.Panel
    Friend WithEvents DATEVALID As System.Windows.Forms.DateTimePicker
    Friend WithEvents DATEREV2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DATEREV1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label19 As System.Windows.Forms.Label
  Friend WithEvents DATEEMI As System.Windows.Forms.DateTimePicker
End Class
