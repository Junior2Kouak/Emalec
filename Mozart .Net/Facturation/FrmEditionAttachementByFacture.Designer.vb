<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditionAttachementByFacture
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditionAttachementByFacture))
        Me.PBPrint = New System.Windows.Forms.ProgressBar()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.BGW_PB = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'PBPrint
        '
        resources.ApplyResources(Me.PBPrint, "PBPrint")
        Me.PBPrint.Name = "PBPrint"
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'BGW_PB
        '
        Me.BGW_PB.WorkerReportsProgress = True
        Me.BGW_PB.WorkerSupportsCancellation = True
        '
        'FrmEditionAttachementByFacture
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.PBPrint)
        Me.Name = "FrmEditionAttachementByFacture"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PBPrint As System.Windows.Forms.ProgressBar
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents BGW_PB As System.ComponentModel.BackgroundWorker
End Class
