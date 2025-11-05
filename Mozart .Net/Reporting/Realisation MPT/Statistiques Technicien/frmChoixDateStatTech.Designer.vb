<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChoixDateStatTech
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChoixDateStatTech))
        Me.GrpPeriode = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblDateDeb = New System.Windows.Forms.Label()
        Me.DTPFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPDebut = New System.Windows.Forms.DateTimePicker()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBEVOLTECH = New System.Windows.Forms.RadioButton()
        Me.RBSYNTHTECH = New System.Windows.Forms.RadioButton()
        Me.RBFACTECH = New System.Windows.Forms.RadioButton()
        Me.RBDEVTECH = New System.Windows.Forms.RadioButton()
        Me.RBKMPER = New System.Windows.Forms.RadioButton()
        Me.RBFOFAC = New System.Windows.Forms.RadioButton()
        Me.RBHREXE = New System.Windows.Forms.RadioButton()
        Me.cmdfermer = New System.Windows.Forms.Button()
        Me.GrpPeriode.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpPeriode
        '
        Me.GrpPeriode.Controls.Add(Me.Label1)
        Me.GrpPeriode.Controls.Add(Me.LblDateDeb)
        Me.GrpPeriode.Controls.Add(Me.DTPFin)
        Me.GrpPeriode.Controls.Add(Me.DTPDebut)
        resources.ApplyResources(Me.GrpPeriode, "GrpPeriode")
        Me.GrpPeriode.ForeColor = System.Drawing.Color.DarkRed
        Me.GrpPeriode.Name = "GrpPeriode"
        Me.GrpPeriode.TabStop = False
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'LblDateDeb
        '
        Me.LblDateDeb.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.LblDateDeb, "LblDateDeb")
        Me.LblDateDeb.Name = "LblDateDeb"
        '
        'DTPFin
        '
        resources.ApplyResources(Me.DTPFin, "DTPFin")
        Me.DTPFin.Name = "DTPFin"
        '
        'DTPDebut
        '
        resources.ApplyResources(Me.DTPDebut, "DTPDebut")
        Me.DTPDebut.Name = "DTPDebut"
        '
        'BtnValid
        '
        resources.ApplyResources(Me.BtnValid, "BtnValid")
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBEVOLTECH)
        Me.GroupBox1.Controls.Add(Me.RBSYNTHTECH)
        Me.GroupBox1.Controls.Add(Me.RBFACTECH)
        Me.GroupBox1.Controls.Add(Me.RBDEVTECH)
        Me.GroupBox1.Controls.Add(Me.RBKMPER)
        Me.GroupBox1.Controls.Add(Me.RBFOFAC)
        Me.GroupBox1.Controls.Add(Me.RBHREXE)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'RBEVOLTECH
        '
        resources.ApplyResources(Me.RBEVOLTECH, "RBEVOLTECH")
        Me.RBEVOLTECH.ForeColor = System.Drawing.Color.Black
        Me.RBEVOLTECH.Name = "RBEVOLTECH"
        Me.RBEVOLTECH.TabStop = True
        Me.RBEVOLTECH.UseVisualStyleBackColor = True
        '
        'RBSYNTHTECH
        '
        resources.ApplyResources(Me.RBSYNTHTECH, "RBSYNTHTECH")
        Me.RBSYNTHTECH.ForeColor = System.Drawing.Color.Blue
        Me.RBSYNTHTECH.Name = "RBSYNTHTECH"
        Me.RBSYNTHTECH.TabStop = True
        Me.RBSYNTHTECH.UseVisualStyleBackColor = True
        '
        'RBFACTECH
        '
        resources.ApplyResources(Me.RBFACTECH, "RBFACTECH")
        Me.RBFACTECH.ForeColor = System.Drawing.Color.Black
        Me.RBFACTECH.Name = "RBFACTECH"
        Me.RBFACTECH.TabStop = True
        Me.RBFACTECH.UseVisualStyleBackColor = True
        '
        'RBDEVTECH
        '
        resources.ApplyResources(Me.RBDEVTECH, "RBDEVTECH")
        Me.RBDEVTECH.ForeColor = System.Drawing.Color.Black
        Me.RBDEVTECH.Name = "RBDEVTECH"
        Me.RBDEVTECH.TabStop = True
        Me.RBDEVTECH.UseVisualStyleBackColor = True
        '
        'RBKMPER
        '
        resources.ApplyResources(Me.RBKMPER, "RBKMPER")
        Me.RBKMPER.ForeColor = System.Drawing.Color.Black
        Me.RBKMPER.Name = "RBKMPER"
        Me.RBKMPER.TabStop = True
        Me.RBKMPER.UseVisualStyleBackColor = True
        '
        'RBFOFAC
        '
        resources.ApplyResources(Me.RBFOFAC, "RBFOFAC")
        Me.RBFOFAC.ForeColor = System.Drawing.Color.Black
        Me.RBFOFAC.Name = "RBFOFAC"
        Me.RBFOFAC.TabStop = True
        Me.RBFOFAC.UseVisualStyleBackColor = True
        '
        'RBHREXE
        '
        resources.ApplyResources(Me.RBHREXE, "RBHREXE")
        Me.RBHREXE.Checked = True
        Me.RBHREXE.ForeColor = System.Drawing.Color.Black
        Me.RBHREXE.Name = "RBHREXE"
        Me.RBHREXE.TabStop = True
        Me.RBHREXE.UseVisualStyleBackColor = True
        '
        'cmdfermer
        '
        resources.ApplyResources(Me.cmdfermer, "cmdfermer")
        Me.cmdfermer.Name = "cmdfermer"
        Me.cmdfermer.UseVisualStyleBackColor = True
        '
        'frmChoixDateStatTech
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.cmdfermer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpPeriode)
        Me.Controls.Add(Me.BtnValid)
        Me.Name = "frmChoixDateStatTech"
        Me.GrpPeriode.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpPeriode As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblDateDeb As System.Windows.Forms.Label
    Friend WithEvents BtnValid As System.Windows.Forms.Button
    Friend WithEvents DTPFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPDebut As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBHREXE As System.Windows.Forms.RadioButton
    Friend WithEvents RBFACTECH As System.Windows.Forms.RadioButton
    Friend WithEvents RBDEVTECH As System.Windows.Forms.RadioButton
    Friend WithEvents RBKMPER As System.Windows.Forms.RadioButton
    Friend WithEvents RBFOFAC As System.Windows.Forms.RadioButton
    Friend WithEvents RBSYNTHTECH As System.Windows.Forms.RadioButton
    Friend WithEvents cmdfermer As System.Windows.Forms.Button
    Friend WithEvents RBEVOLTECH As RadioButton
End Class
