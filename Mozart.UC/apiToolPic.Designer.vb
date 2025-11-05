<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class apiToolPic
  Inherits System.Windows.Forms.UserControl

  'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.pic0 = New System.Windows.Forms.PictureBox()
    Me.pic1 = New System.Windows.Forms.PictureBox()
    Me.pic2 = New System.Windows.Forms.PictureBox()
    Me.pic3 = New System.Windows.Forms.PictureBox()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.pic0, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'PictureBox1
    '
    Me.PictureBox1.BackColor = System.Drawing.Color.MediumBlue
    Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PictureBox1.Location = New System.Drawing.Point(1, 3)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(296, 26)
    Me.PictureBox1.TabIndex = 4
    Me.PictureBox1.TabStop = False
    Me.PictureBox1.Tag = "0"
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.pic3, 0, 3)
    Me.TableLayoutPanel1.Controls.Add(Me.pic0, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.pic1, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.pic2, 0, 2)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 26)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 4
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(299, 401)
    Me.TableLayoutPanel1.TabIndex = 5
    '
    'pic0
    '
    Me.pic0.BackColor = System.Drawing.SystemColors.Control
    Me.pic0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.pic0.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pic0.Location = New System.Drawing.Point(3, 3)
    Me.pic0.Name = "pic0"
    Me.pic0.Size = New System.Drawing.Size(293, 94)
    Me.pic0.TabIndex = 1
    Me.pic0.TabStop = False
    '
    'pic1
    '
    Me.pic1.BackColor = System.Drawing.SystemColors.Control
    Me.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.pic1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pic1.Location = New System.Drawing.Point(3, 103)
    Me.pic1.Name = "pic1"
    Me.pic1.Size = New System.Drawing.Size(293, 94)
    Me.pic1.TabIndex = 2
    Me.pic1.TabStop = False
    '
    'pic2
    '
    Me.pic2.BackColor = System.Drawing.SystemColors.Control
    Me.pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.pic2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pic2.Location = New System.Drawing.Point(3, 203)
    Me.pic2.Name = "pic2"
    Me.pic2.Size = New System.Drawing.Size(293, 94)
    Me.pic2.TabIndex = 3
    Me.pic2.TabStop = False
    '
    'pic3
    '
    Me.pic3.BackColor = System.Drawing.SystemColors.Control
    Me.pic3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.pic3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pic3.Location = New System.Drawing.Point(3, 303)
    Me.pic3.Name = "pic3"
    Me.pic3.Size = New System.Drawing.Size(293, 95)
    Me.pic3.TabIndex = 4
    Me.pic3.TabStop = False
    '
    'apiToolPic
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.PictureBox1)
    Me.Name = "apiToolPic"
    Me.Size = New System.Drawing.Size(299, 429)
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel1.ResumeLayout(False)
    CType(Me.pic0, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
  Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
  Friend WithEvents pic3 As Windows.Forms.PictureBox
  Friend WithEvents pic0 As Windows.Forms.PictureBox
  Friend WithEvents pic1 As Windows.Forms.PictureBox
  Friend WithEvents pic2 As Windows.Forms.PictureBox
End Class
