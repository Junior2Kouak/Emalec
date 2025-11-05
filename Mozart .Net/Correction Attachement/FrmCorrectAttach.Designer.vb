<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCorrectAttach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCorrectAttach))
        Me.TabCtrlChapitres = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GrpAffichageHeure = New System.Windows.Forms.GroupBox()
        Me.ChkMaskHREXE = New System.Windows.Forms.CheckBox()
        Me.ChkMaskHRArr = New System.Windows.Forms.CheckBox()
        Me.TxtNbHrPrepa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNbHrExe = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNbDep = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPageChap1 = New System.Windows.Forms.TabPage()
        Me.TxtBoxChap1 = New System.Windows.Forms.TextBox()
        Me.TabPageChap2 = New System.Windows.Forms.TabPage()
        Me.TxtBoxChap2 = New System.Windows.Forms.TextBox()
        Me.TabPageChap3 = New System.Windows.Forms.TabPage()
        Me.TxtBoxChap3 = New System.Windows.Forms.TextBox()
        Me.TabPageChap4 = New System.Windows.Forms.TabPage()
        Me.TxtBoxChap4 = New System.Windows.Forms.TextBox()
        Me.TabPageChap5 = New System.Windows.Forms.TabPage()
        Me.TxtBoxChap5 = New System.Windows.Forms.TextBox()
        Me.TabPageChap6 = New System.Windows.Forms.TabPage()
        Me.TxtBoxChap6 = New System.Windows.Forms.TextBox()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnVisu = New System.Windows.Forms.Button()
        Me.BtnEnregistrer = New System.Windows.Forms.Button()
        Me.TabCtrlChapitres.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GrpAffichageHeure.SuspendLayout()
        Me.TabPageChap1.SuspendLayout()
        Me.TabPageChap2.SuspendLayout()
        Me.TabPageChap3.SuspendLayout()
        Me.TabPageChap4.SuspendLayout()
        Me.TabPageChap5.SuspendLayout()
        Me.TabPageChap6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabCtrlChapitres
        '
        Me.TabCtrlChapitres.Controls.Add(Me.TabPage1)
        Me.TabCtrlChapitres.Controls.Add(Me.TabPageChap1)
        Me.TabCtrlChapitres.Controls.Add(Me.TabPageChap2)
        Me.TabCtrlChapitres.Controls.Add(Me.TabPageChap3)
        Me.TabCtrlChapitres.Controls.Add(Me.TabPageChap4)
        Me.TabCtrlChapitres.Controls.Add(Me.TabPageChap5)
        Me.TabCtrlChapitres.Controls.Add(Me.TabPageChap6)
        resources.ApplyResources(Me.TabCtrlChapitres, "TabCtrlChapitres")
        Me.TabCtrlChapitres.Multiline = True
        Me.TabCtrlChapitres.Name = "TabCtrlChapitres"
        Me.TabCtrlChapitres.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GrpAffichageHeure)
        Me.TabPage1.Controls.Add(Me.TxtNbHrPrepa)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TxtNbHrExe)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TxtNbDep)
        Me.TabPage1.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GrpAffichageHeure
        '
        Me.GrpAffichageHeure.Controls.Add(Me.ChkMaskHREXE)
        Me.GrpAffichageHeure.Controls.Add(Me.ChkMaskHRArr)
        resources.ApplyResources(Me.GrpAffichageHeure, "GrpAffichageHeure")
        Me.GrpAffichageHeure.Name = "GrpAffichageHeure"
        Me.GrpAffichageHeure.TabStop = False
        '
        'ChkMaskHREXE
        '
        resources.ApplyResources(Me.ChkMaskHREXE, "ChkMaskHREXE")
        Me.ChkMaskHREXE.Name = "ChkMaskHREXE"
        Me.ChkMaskHREXE.UseVisualStyleBackColor = True
        '
        'ChkMaskHRArr
        '
        resources.ApplyResources(Me.ChkMaskHRArr, "ChkMaskHRArr")
        Me.ChkMaskHRArr.Name = "ChkMaskHRArr"
        Me.ChkMaskHRArr.UseVisualStyleBackColor = True
        '
        'TxtNbHrPrepa
        '
        resources.ApplyResources(Me.TxtNbHrPrepa, "TxtNbHrPrepa")
        Me.TxtNbHrPrepa.Name = "TxtNbHrPrepa"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'TxtNbHrExe
        '
        resources.ApplyResources(Me.TxtNbHrExe, "TxtNbHrExe")
        Me.TxtNbHrExe.Name = "TxtNbHrExe"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'TxtNbDep
        '
        resources.ApplyResources(Me.TxtNbDep, "TxtNbDep")
        Me.TxtNbDep.Name = "TxtNbDep"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'TabPageChap1
        '
        Me.TabPageChap1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPageChap1.Controls.Add(Me.TxtBoxChap1)
        Me.TabPageChap1.Cursor = System.Windows.Forms.Cursors.Arrow
        resources.ApplyResources(Me.TabPageChap1, "TabPageChap1")
        Me.TabPageChap1.Name = "TabPageChap1"
        Me.TabPageChap1.UseVisualStyleBackColor = True
        '
        'TxtBoxChap1
        '
        Me.TxtBoxChap1.AcceptsReturn = True
        Me.TxtBoxChap1.AcceptsTab = True
        Me.TxtBoxChap1.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.TxtBoxChap1, "TxtBoxChap1")
        Me.TxtBoxChap1.Name = "TxtBoxChap1"
        '
        'TabPageChap2
        '
        Me.TabPageChap2.Controls.Add(Me.TxtBoxChap2)
        resources.ApplyResources(Me.TabPageChap2, "TabPageChap2")
        Me.TabPageChap2.Name = "TabPageChap2"
        Me.TabPageChap2.UseVisualStyleBackColor = True
        '
        'TxtBoxChap2
        '
        Me.TxtBoxChap2.AcceptsReturn = True
        Me.TxtBoxChap2.AcceptsTab = True
        Me.TxtBoxChap2.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.TxtBoxChap2, "TxtBoxChap2")
        Me.TxtBoxChap2.Name = "TxtBoxChap2"
        '
        'TabPageChap3
        '
        Me.TabPageChap3.Controls.Add(Me.TxtBoxChap3)
        resources.ApplyResources(Me.TabPageChap3, "TabPageChap3")
        Me.TabPageChap3.Name = "TabPageChap3"
        Me.TabPageChap3.UseVisualStyleBackColor = True
        '
        'TxtBoxChap3
        '
        Me.TxtBoxChap3.AcceptsReturn = True
        Me.TxtBoxChap3.AcceptsTab = True
        Me.TxtBoxChap3.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.TxtBoxChap3, "TxtBoxChap3")
        Me.TxtBoxChap3.Name = "TxtBoxChap3"
        '
        'TabPageChap4
        '
        Me.TabPageChap4.Controls.Add(Me.TxtBoxChap4)
        resources.ApplyResources(Me.TabPageChap4, "TabPageChap4")
        Me.TabPageChap4.Name = "TabPageChap4"
        Me.TabPageChap4.UseVisualStyleBackColor = True
        '
        'TxtBoxChap4
        '
        Me.TxtBoxChap4.AcceptsReturn = True
        Me.TxtBoxChap4.AcceptsTab = True
        Me.TxtBoxChap4.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.TxtBoxChap4, "TxtBoxChap4")
        Me.TxtBoxChap4.Name = "TxtBoxChap4"
        '
        'TabPageChap5
        '
        Me.TabPageChap5.Controls.Add(Me.TxtBoxChap5)
        resources.ApplyResources(Me.TabPageChap5, "TabPageChap5")
        Me.TabPageChap5.Name = "TabPageChap5"
        Me.TabPageChap5.UseVisualStyleBackColor = True
        '
        'TxtBoxChap5
        '
        Me.TxtBoxChap5.AcceptsReturn = True
        Me.TxtBoxChap5.AcceptsTab = True
        Me.TxtBoxChap5.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.TxtBoxChap5, "TxtBoxChap5")
        Me.TxtBoxChap5.Name = "TxtBoxChap5"
        '
        'TabPageChap6
        '
        Me.TabPageChap6.Controls.Add(Me.TxtBoxChap6)
        resources.ApplyResources(Me.TabPageChap6, "TabPageChap6")
        Me.TabPageChap6.Name = "TabPageChap6"
        Me.TabPageChap6.UseVisualStyleBackColor = True
        '
        'TxtBoxChap6
        '
        Me.TxtBoxChap6.AcceptsReturn = True
        Me.TxtBoxChap6.AcceptsTab = True
        Me.TxtBoxChap6.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.TxtBoxChap6, "TxtBoxChap6")
        Me.TxtBoxChap6.Name = "TxtBoxChap6"
        '
        'BtnQuit
        '
        resources.ApplyResources(Me.BtnQuit, "BtnQuit")
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'BtnVisu
        '
        Me.BtnVisu.BackgroundImage = Global.MozartNet.My.Resources.Resources.Visu
        resources.ApplyResources(Me.BtnVisu, "BtnVisu")
        Me.BtnVisu.Name = "BtnVisu"
        Me.BtnVisu.UseVisualStyleBackColor = True
        '
        'BtnEnregistrer
        '
        Me.BtnEnregistrer.BackgroundImage = Global.MozartNet.My.Resources.Resources.Save
        resources.ApplyResources(Me.BtnEnregistrer, "BtnEnregistrer")
        Me.BtnEnregistrer.Name = "BtnEnregistrer"
        Me.BtnEnregistrer.UseVisualStyleBackColor = True
        '
        'FrmCorrectAttach
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnVisu)
        Me.Controls.Add(Me.BtnEnregistrer)
        Me.Controls.Add(Me.TabCtrlChapitres)
        Me.Name = "FrmCorrectAttach"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabCtrlChapitres.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GrpAffichageHeure.ResumeLayout(False)
        Me.GrpAffichageHeure.PerformLayout()
        Me.TabPageChap1.ResumeLayout(False)
        Me.TabPageChap1.PerformLayout()
        Me.TabPageChap2.ResumeLayout(False)
        Me.TabPageChap2.PerformLayout()
        Me.TabPageChap3.ResumeLayout(False)
        Me.TabPageChap3.PerformLayout()
        Me.TabPageChap4.ResumeLayout(False)
        Me.TabPageChap4.PerformLayout()
        Me.TabPageChap5.ResumeLayout(False)
        Me.TabPageChap5.PerformLayout()
        Me.TabPageChap6.ResumeLayout(False)
        Me.TabPageChap6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabCtrlChapitres As System.Windows.Forms.TabControl
    Friend WithEvents TabPageChap1 As System.Windows.Forms.TabPage
    Friend WithEvents TxtBoxChap1 As System.Windows.Forms.TextBox
    Friend WithEvents TabPageChap2 As System.Windows.Forms.TabPage
    Friend WithEvents TxtBoxChap2 As System.Windows.Forms.TextBox
    Friend WithEvents TabPageChap3 As System.Windows.Forms.TabPage
    Friend WithEvents TxtBoxChap3 As System.Windows.Forms.TextBox
    Friend WithEvents TabPageChap4 As System.Windows.Forms.TabPage
    Friend WithEvents TxtBoxChap4 As System.Windows.Forms.TextBox
    Friend WithEvents TabPageChap5 As System.Windows.Forms.TabPage
    Friend WithEvents TxtBoxChap5 As System.Windows.Forms.TextBox
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnVisu As System.Windows.Forms.Button
	Friend WithEvents BtnEnregistrer As System.Windows.Forms.Button
	Friend WithEvents TabPageChap6 As System.Windows.Forms.TabPage
	Friend WithEvents TxtBoxChap6 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TxtNbHrPrepa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNbHrExe As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNbDep As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GrpAffichageHeure As GroupBox
    Friend WithEvents ChkMaskHREXE As CheckBox
    Friend WithEvents ChkMaskHRArr As CheckBox
End Class
