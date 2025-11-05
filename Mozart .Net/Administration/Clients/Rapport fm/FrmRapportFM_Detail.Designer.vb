<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRapportFM_Detail
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
        Me.PanelMaster = New System.Windows.Forms.Panel()
        Me.GrpBtn = New System.Windows.Forms.GroupBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnFinish = New System.Windows.Forms.Button()
        Me.GrpBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMaster
        '
        Me.PanelMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMaster.Location = New System.Drawing.Point(12, 12)
        Me.PanelMaster.Name = "PanelMaster"
        Me.PanelMaster.Size = New System.Drawing.Size(1161, 767)
        Me.PanelMaster.TabIndex = 1
        '
        'GrpBtn
        '
        Me.GrpBtn.BackColor = System.Drawing.Color.Wheat
        Me.GrpBtn.Controls.Add(Me.BtnCancel)
        Me.GrpBtn.Controls.Add(Me.BtnLast)
        Me.GrpBtn.Controls.Add(Me.BtnNext)
        Me.GrpBtn.Controls.Add(Me.BtnFinish)
        Me.GrpBtn.Location = New System.Drawing.Point(715, 785)
        Me.GrpBtn.Name = "GrpBtn"
        Me.GrpBtn.Size = New System.Drawing.Size(458, 54)
        Me.GrpBtn.TabIndex = 3
        Me.GrpBtn.TabStop = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(6, 16)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(92, 27)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Annuler"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        Me.BtnLast.Location = New System.Drawing.Point(134, 16)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(92, 27)
        Me.BtnLast.TabIndex = 1
        Me.BtnLast.Text = "< Précédent"
        Me.BtnLast.UseVisualStyleBackColor = True
        Me.BtnLast.Visible = False
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(232, 16)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(92, 27)
        Me.BtnNext.TabIndex = 0
        Me.BtnNext.Text = "Suivant >"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnFinish
        '
        Me.BtnFinish.Location = New System.Drawing.Point(356, 16)
        Me.BtnFinish.Name = "BtnFinish"
        Me.BtnFinish.Size = New System.Drawing.Size(92, 27)
        Me.BtnFinish.TabIndex = 3
        Me.BtnFinish.Text = "Terminer"
        Me.BtnFinish.UseVisualStyleBackColor = True
        Me.BtnFinish.Visible = False
        '
        'FrmRapportFM_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1185, 851)
        Me.Controls.Add(Me.GrpBtn)
        Me.Controls.Add(Me.PanelMaster)
        Me.Name = "FrmRapportFM_Detail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Rapport FM"
        Me.GrpBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMaster As Panel
    Friend WithEvents GrpBtn As GroupBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnLast As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnFinish As Button
End Class
