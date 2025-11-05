<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQCMListeCandidat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQCMListeCandidat))
        Me.DGVTestConnaissances = New System.Windows.Forms.DataGridView()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpBoxActions = New System.Windows.Forms.GroupBox()
        Me.BtnResultatsByQCMCandidat = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        CType(Me.DGVTestConnaissances, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVTestConnaissances
        '
        resources.ApplyResources(Me.DGVTestConnaissances, "DGVTestConnaissances")
        Me.DGVTestConnaissances.AllowUserToAddRows = False
        Me.DGVTestConnaissances.AllowUserToDeleteRows = False
        Me.DGVTestConnaissances.AllowUserToOrderColumns = True
        Me.DGVTestConnaissances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVTestConnaissances.MultiSelect = False
        Me.DGVTestConnaissances.Name = "DGVTestConnaissances"
        Me.DGVTestConnaissances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GrpBoxActions
        '
        resources.ApplyResources(Me.GrpBoxActions, "GrpBoxActions")
        Me.GrpBoxActions.Controls.Add(Me.BtnResultatsByQCMCandidat)
        Me.GrpBoxActions.Controls.Add(Me.BtnFermer)
        Me.GrpBoxActions.Name = "GrpBoxActions"
        Me.GrpBoxActions.TabStop = False
        '
        'BtnResultatsByQCMCandidat
        '
        resources.ApplyResources(Me.BtnResultatsByQCMCandidat, "BtnResultatsByQCMCandidat")
        Me.BtnResultatsByQCMCandidat.Name = "BtnResultatsByQCMCandidat"
        Me.BtnResultatsByQCMCandidat.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'frmQCMListeCandidat
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpBoxActions)
        Me.Controls.Add(Me.DGVTestConnaissances)
        Me.Name = "frmQCMListeCandidat"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVTestConnaissances, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVTestConnaissances As System.Windows.Forms.DataGridView
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GrpBoxActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnResultatsByQCMCandidat As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button

End Class
