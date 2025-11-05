Imports System.Drawing
Imports System.Windows.Forms

Public Class apiGroupBox
  Inherits Windows.Forms.GroupBox

  Private _HelpContextID As Integer
  Private _FrameColor As Color

  Property HelpContextID As Integer
    Get
      HelpContextID = _HelpContextID
    End Get
    Set(value As Integer)
      _HelpContextID = value
    End Set
  End Property

  Property FrameColor As Color
    Get
      FrameColor = _FrameColor
    End Get
    Set(value As Color)
      _FrameColor = value
    End Set
  End Property

  Private Sub InitializeComponent()
    Me.SuspendLayout()
    '
    'apiGroupBox
    '
    Me.ResumeLayout(False)

  End Sub

  Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
    MyBase.OnPaint(e)

    Dim tSize As Size = TextRenderer.MeasureText(Me.Text, Me.Font)

    Dim borderRect As Rectangle = e.ClipRectangle
    borderRect.Y += (tSize.Height / 2)
    borderRect.Height -= (tSize.Height / 2)

    Dim textRect As Rectangle = e.ClipRectangle
    textRect.X += 8
    textRect.Width = tSize.Width
    textRect.Height = tSize.Height

    Dim lColor As Pen = New Pen(Me._FrameColor)
    ' Left
    e.Graphics.DrawLine(lColor, 1, borderRect.Top, 1, Height - 1)
    e.Graphics.DrawLine(lColor, 0, borderRect.Top, 0, Height - 2)
    ' Bottom
    e.Graphics.DrawLine(lColor, 0, Height - 1, Width, Height - 1)
    e.Graphics.DrawLine(lColor, 0, Height - 2, Width - 1, Height - 2)
    ' Top left
    e.Graphics.DrawLine(lColor, 0, borderRect.Top - 1, textRect.Left, borderRect.Top - 1)
    e.Graphics.DrawLine(lColor, 1, borderRect.Top, textRect.Left, borderRect.Top)
    ' Top right
    e.Graphics.DrawLine(lColor, textRect.Right, borderRect.Top - 1, Width - 2, borderRect.Top - 1)
    e.Graphics.DrawLine(lColor, textRect.Right, borderRect.Top, Width - 1, borderRect.Top)
    ' Right
    e.Graphics.DrawLine(lColor, Width - 1, borderRect.Top - 1, Width - 1, Height - 2)
    e.Graphics.DrawLine(lColor, Width - 2, borderRect.Top, Width - 2, Height - 2)
  End Sub
End Class
