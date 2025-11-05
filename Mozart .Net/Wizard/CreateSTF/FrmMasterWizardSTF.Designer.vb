<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMasterWizardSTF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMasterWizardSTF))
        Me.PanelMaster = New System.Windows.Forms.Panel()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.GrpBtn = New System.Windows.Forms.GroupBox()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnFinish = New System.Windows.Forms.Button()
        Me.PictSociete = New System.Windows.Forms.PictureBox()
        Me.GrpBtn.SuspendLayout()
        CType(Me.PictSociete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMaster
        '
        resources.ApplyResources(Me.PanelMaster, "PanelMaster")
        Me.PanelMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMaster.Name = "PanelMaster"
        '
        'BtnCancel
        '
        resources.ApplyResources(Me.BtnCancel, "BtnCancel")
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        resources.ApplyResources(Me.BtnLast, "BtnLast")
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'GrpBtn
        '
        resources.ApplyResources(Me.GrpBtn, "GrpBtn")
        Me.GrpBtn.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GrpBtn.Controls.Add(Me.BtnCancel)
        Me.GrpBtn.Controls.Add(Me.BtnLast)
        Me.GrpBtn.Controls.Add(Me.BtnNext)
        Me.GrpBtn.Controls.Add(Me.BtnFinish)
        Me.GrpBtn.Name = "GrpBtn"
        Me.GrpBtn.TabStop = False
        '
        'BtnNext
        '
        resources.ApplyResources(Me.BtnNext, "BtnNext")
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnFinish
        '
        resources.ApplyResources(Me.BtnFinish, "BtnFinish")
        Me.BtnFinish.Name = "BtnFinish"
        Me.BtnFinish.UseVisualStyleBackColor = True
        '
        'PictSociete
        '
        resources.ApplyResources(Me.PictSociete, "PictSociete")
        Me.PictSociete.Name = "PictSociete"
        Me.PictSociete.TabStop = False
        '
        'FrmMasterWizardSTF
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Controls.Add(Me.PanelMaster)
        Me.Controls.Add(Me.GrpBtn)
        Me.Controls.Add(Me.PictSociete)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmMasterWizardSTF"
        Me.GrpBtn.ResumeLayout(False)
        CType(Me.PictSociete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMaster As System.Windows.Forms.Panel
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents GrpBtn As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnFinish As System.Windows.Forms.Button
    Friend WithEvents PictSociete As System.Windows.Forms.PictureBox

End Class
