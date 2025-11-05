<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFicheSituDanger_Liste
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFicheSituDanger_Liste))
        Me.GrpBoxActions = New System.Windows.Forms.GroupBox()
        Me.BtnModif = New System.Windows.Forms.Button()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.BtnArchiver = New System.Windows.Forms.Button()
        Me.BtnArchives = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnReponse = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.grdFicDang = New MozartUC.apiTGrid()
        Me.GrpBoxActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpBoxActions
        '
        Me.GrpBoxActions.Controls.Add(Me.BtnModif)
        Me.GrpBoxActions.Controls.Add(Me.BtnAjouter)
        Me.GrpBoxActions.Controls.Add(Me.BtnArchiver)
        Me.GrpBoxActions.Controls.Add(Me.BtnArchives)
        Me.GrpBoxActions.Controls.Add(Me.BtnFermer)
        Me.GrpBoxActions.Controls.Add(Me.BtnReponse)
        resources.ApplyResources(Me.GrpBoxActions, "GrpBoxActions")
        Me.GrpBoxActions.Name = "GrpBoxActions"
        Me.GrpBoxActions.TabStop = False
        '
        'BtnModif
        '
        resources.ApplyResources(Me.BtnModif, "BtnModif")
        Me.BtnModif.Name = "BtnModif"
        Me.BtnModif.Tag = "672"
        Me.BtnModif.UseVisualStyleBackColor = True
        '
        'BtnAjouter
        '
        resources.ApplyResources(Me.BtnAjouter, "BtnAjouter")
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.Tag = "672"
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'BtnArchiver
        '
        resources.ApplyResources(Me.BtnArchiver, "BtnArchiver")
        Me.BtnArchiver.Name = "BtnArchiver"
        Me.BtnArchiver.Tag = "672"
        Me.BtnArchiver.UseVisualStyleBackColor = True
        '
        'BtnArchives
        '
        resources.ApplyResources(Me.BtnArchives, "BtnArchives")
        Me.BtnArchives.Name = "BtnArchives"
        Me.BtnArchives.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnReponse
        '
        resources.ApplyResources(Me.BtnReponse, "BtnReponse")
        Me.BtnReponse.Name = "BtnReponse"
        Me.BtnReponse.UseVisualStyleBackColor = True
        '
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'grdFicDang
        '
        resources.ApplyResources(Me.grdFicDang, "grdFicDang")
        Me.grdFicDang.FilterBar = True
        Me.grdFicDang.FooterBar = True
        Me.grdFicDang.Name = "grdFicDang"
        '
        'frmFicheSituDanger_Liste
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.grdFicDang)
        Me.Controls.Add(Me.GrpBoxActions)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "frmFicheSituDanger_Liste"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpBoxActions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpBoxActions As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnReponse As Button
    Friend WithEvents LabelTitre As Label
    Friend WithEvents BtnArchives As Button
    Friend WithEvents BtnArchiver As Button
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents BtnModif As Button
    Friend WithEvents grdFicDang As MozartUC.apiTGrid
End Class
