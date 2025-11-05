<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChoixFiche
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChoixFiche))
        Me.btnHeures = New System.Windows.Forms.Button()
        Me.btnFO = New System.Windows.Forms.Button()
        Me.btnStt = New System.Windows.Forms.Button()
        Me.btnHeuresTechMeca = New System.Windows.Forms.Button()
        Me.btnHeuresTechCabl = New System.Windows.Forms.Button()
        Me.btnHeuresTechAideTec = New System.Windows.Forms.Button()
        Me.btnHeuresBE = New System.Windows.Forms.Button()
        Me.btnHeuresBE_Auto = New System.Windows.Forms.Button()
        Me.btnHeuresBE_Elec = New System.Windows.Forms.Button()
        Me.btnHeuresBE_Meca = New System.Windows.Forms.Button()
        Me.btnHeuresChaff = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHeures
        '
        resources.ApplyResources(Me.btnHeures, "btnHeures")
        Me.btnHeures.Name = "btnHeures"
        Me.btnHeures.UseVisualStyleBackColor = True
        '
        'btnFO
        '
        resources.ApplyResources(Me.btnFO, "btnFO")
        Me.btnFO.Name = "btnFO"
        Me.btnFO.UseVisualStyleBackColor = True
        '
        'btnStt
        '
        resources.ApplyResources(Me.btnStt, "btnStt")
        Me.btnStt.Name = "btnStt"
        Me.btnStt.UseVisualStyleBackColor = True
        '
        'btnHeuresTechMeca
        '
        resources.ApplyResources(Me.btnHeuresTechMeca, "btnHeuresTechMeca")
        Me.btnHeuresTechMeca.Name = "btnHeuresTechMeca"
        Me.btnHeuresTechMeca.UseVisualStyleBackColor = True
        '
        'btnHeuresTechCabl
        '
        resources.ApplyResources(Me.btnHeuresTechCabl, "btnHeuresTechCabl")
        Me.btnHeuresTechCabl.Name = "btnHeuresTechCabl"
        Me.btnHeuresTechCabl.UseVisualStyleBackColor = True
        '
        'btnHeuresTechAideTec
        '
        resources.ApplyResources(Me.btnHeuresTechAideTec, "btnHeuresTechAideTec")
        Me.btnHeuresTechAideTec.Name = "btnHeuresTechAideTec"
        Me.btnHeuresTechAideTec.UseVisualStyleBackColor = True
        '
        'btnHeuresBE
        '
        resources.ApplyResources(Me.btnHeuresBE, "btnHeuresBE")
        Me.btnHeuresBE.Name = "btnHeuresBE"
        Me.btnHeuresBE.UseVisualStyleBackColor = True
        '
        'btnHeuresBE_Auto
        '
        resources.ApplyResources(Me.btnHeuresBE_Auto, "btnHeuresBE_Auto")
        Me.btnHeuresBE_Auto.Name = "btnHeuresBE_Auto"
        Me.btnHeuresBE_Auto.UseVisualStyleBackColor = True
        '
        'btnHeuresBE_Elec
        '
        resources.ApplyResources(Me.btnHeuresBE_Elec, "btnHeuresBE_Elec")
        Me.btnHeuresBE_Elec.Name = "btnHeuresBE_Elec"
        Me.btnHeuresBE_Elec.UseVisualStyleBackColor = True
        '
        'btnHeuresBE_Meca
        '
        resources.ApplyResources(Me.btnHeuresBE_Meca, "btnHeuresBE_Meca")
        Me.btnHeuresBE_Meca.Name = "btnHeuresBE_Meca"
        Me.btnHeuresBE_Meca.UseVisualStyleBackColor = True
        '
        'btnHeuresChaff
        '
        resources.ApplyResources(Me.btnHeuresChaff, "btnHeuresChaff")
        Me.btnHeuresChaff.Name = "btnHeuresChaff"
        Me.btnHeuresChaff.UseVisualStyleBackColor = True
        '
        'frmChoixFiche
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnHeuresChaff)
        Me.Controls.Add(Me.btnHeuresBE_Meca)
        Me.Controls.Add(Me.btnHeuresBE_Elec)
        Me.Controls.Add(Me.btnHeuresBE_Auto)
        Me.Controls.Add(Me.btnHeuresBE)
        Me.Controls.Add(Me.btnHeuresTechAideTec)
        Me.Controls.Add(Me.btnHeuresTechCabl)
        Me.Controls.Add(Me.btnHeuresTechMeca)
        Me.Controls.Add(Me.btnStt)
        Me.Controls.Add(Me.btnFO)
        Me.Controls.Add(Me.btnHeures)
        Me.Name = "frmChoixFiche"
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHeures As System.Windows.Forms.Button
    Friend WithEvents btnFO As System.Windows.Forms.Button
    Friend WithEvents btnStt As System.Windows.Forms.Button
    Friend WithEvents btnHeuresTechMeca As Button
    Friend WithEvents btnHeuresTechCabl As Button
    Friend WithEvents btnHeuresTechAideTec As Button
    Friend WithEvents btnHeuresBE As Button
    Friend WithEvents btnHeuresBE_Auto As Button
    Friend WithEvents btnHeuresBE_Elec As Button
    Friend WithEvents btnHeuresBE_Meca As Button
    Friend WithEvents btnHeuresChaff As Button
End Class
