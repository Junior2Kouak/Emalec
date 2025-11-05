<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailsCase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetailsCase))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grdMain = New System.Windows.Forms.DataGridView()
        Me.Libellé = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valeur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdMain
        '
        resources.ApplyResources(Me.grdMain, "grdMain")
        Me.grdMain.AllowUserToAddRows = False
        Me.grdMain.AllowUserToDeleteRows = False
        Me.grdMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.grdMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Libellé, Me.Valeur})
        Me.grdMain.Name = "grdMain"
        '
        'Libellé
        '
        Me.Libellé.DataPropertyName = "VLIB"
        resources.ApplyResources(Me.Libellé, "Libellé")
        Me.Libellé.Name = "Libellé"
        '
        'Valeur
        '
        Me.Valeur.DataPropertyName = "NVAL"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Valeur.DefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.Valeur, "Valeur")
        Me.Valeur.Name = "Valeur"
        '
        'frmDetailsCase
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grdMain)
        Me.Name = "frmDetailsCase"
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdMain As System.Windows.Forms.DataGridView
    Friend WithEvents Libellé As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valeur As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
