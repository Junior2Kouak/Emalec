<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailModeleTexte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetailModeleTexte))
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpBoxActions = New System.Windows.Forms.GroupBox()
        Me.BtnSaveCorrect = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GrpDetail = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtModelText = New System.Windows.Forms.TextBox()
        Me.TxtSSChapitre = New System.Windows.Forms.TextBox()
        Me.TxtChapitre = New System.Windows.Forms.TextBox()
        Me.LblLegende1 = New System.Windows.Forms.Label()
        Me.GrpBoxActions.SuspendLayout()
        Me.GrpDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GrpBoxActions
        '
        resources.ApplyResources(Me.GrpBoxActions, "GrpBoxActions")
        Me.GrpBoxActions.Controls.Add(Me.BtnSaveCorrect)
        Me.GrpBoxActions.Controls.Add(Me.BtnFermer)
        Me.GrpBoxActions.Name = "GrpBoxActions"
        Me.GrpBoxActions.TabStop = False
        '
        'BtnSaveCorrect
        '
        Me.BtnSaveCorrect.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.BtnSaveCorrect, "BtnSaveCorrect")
        Me.BtnSaveCorrect.Name = "BtnSaveCorrect"
        Me.BtnSaveCorrect.UseVisualStyleBackColor = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = False
        '
        'GrpDetail
        '
        resources.ApplyResources(Me.GrpDetail, "GrpDetail")
        Me.GrpDetail.Controls.Add(Me.Label2)
        Me.GrpDetail.Controls.Add(Me.Label1)
        Me.GrpDetail.Controls.Add(Me.TxtModelText)
        Me.GrpDetail.Controls.Add(Me.TxtSSChapitre)
        Me.GrpDetail.Controls.Add(Me.TxtChapitre)
        Me.GrpDetail.Controls.Add(Me.LblLegende1)
        Me.GrpDetail.Name = "GrpDetail"
        Me.GrpDetail.TabStop = False
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
        'TxtModelText
        '
        resources.ApplyResources(Me.TxtModelText, "TxtModelText")
        Me.TxtModelText.Name = "TxtModelText"
        '
        'TxtSSChapitre
        '
        resources.ApplyResources(Me.TxtSSChapitre, "TxtSSChapitre")
        Me.TxtSSChapitre.Name = "TxtSSChapitre"
        '
        'TxtChapitre
        '
        resources.ApplyResources(Me.TxtChapitre, "TxtChapitre")
        Me.TxtChapitre.Name = "TxtChapitre"
        '
        'LblLegende1
        '
        resources.ApplyResources(Me.LblLegende1, "LblLegende1")
        Me.LblLegende1.Name = "LblLegende1"
        '
        'frmDetailModeleTexte
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnFermer
        Me.Controls.Add(Me.GrpDetail)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpBoxActions)
        Me.Name = "frmDetailModeleTexte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpBoxActions.ResumeLayout(False)
        Me.GrpDetail.ResumeLayout(False)
        Me.GrpDetail.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GrpBoxActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSaveCorrect As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents GrpDetail As System.Windows.Forms.GroupBox
    Friend WithEvents TxtModelText As System.Windows.Forms.TextBox
    Friend WithEvents TxtSSChapitre As System.Windows.Forms.TextBox
    Friend WithEvents TxtChapitre As System.Windows.Forms.TextBox
    Friend WithEvents LblLegende1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
