<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApiRecherche
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
        Me.cmdVal = New MozartUC.apiButton()
        Me.cmdEsc = New MozartUC.apiButton()
        Me.Grid = New MozartUC.apiTGrid()
        Me.SuspendLayout()
        '
        'cmdVal
        '
        Me.cmdVal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdVal.HelpContextID = 0
        Me.cmdVal.Image = Global.MozartUC.My.Resources.Resources.ok_32
        Me.cmdVal.Location = New System.Drawing.Point(62, 381)
        Me.cmdVal.Name = "cmdVal"
        Me.cmdVal.Size = New System.Drawing.Size(47, 33)
        Me.cmdVal.TabIndex = 5
        Me.cmdVal.UseVisualStyleBackColor = True
        '
        'cmdEsc
        '
        Me.cmdEsc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEsc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdEsc.HelpContextID = 0
        Me.cmdEsc.Image = Global.MozartUC.My.Resources.Resources.delete
        Me.cmdEsc.Location = New System.Drawing.Point(8, 381)
        Me.cmdEsc.Name = "cmdEsc"
        Me.cmdEsc.Size = New System.Drawing.Size(47, 33)
        Me.cmdEsc.TabIndex = 4
        Me.cmdEsc.UseVisualStyleBackColor = True
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.FilterBar = True
        Me.Grid.FooterBar = True
        Me.Grid.Location = New System.Drawing.Point(-1, -2)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(553, 379)
        Me.Grid.TabIndex = 3
        '
        'frmApiRecherche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 416)
        Me.Controls.Add(Me.cmdVal)
        Me.Controls.Add(Me.cmdEsc)
        Me.Controls.Add(Me.Grid)
        Me.Name = "frmApiRecherche"
        Me.Text = "frmApiRecherche"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Grid As apiTGrid
    Private WithEvents cmdVal As apiButton
    Private WithEvents cmdEsc As apiButton
End Class
