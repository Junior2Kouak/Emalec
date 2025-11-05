Imports System.Drawing
Imports System.Windows.Forms

Public Class apifrmToolPic

  Public Event PicMouseUp(sender As Object, e As MouseEventArgs)

  Public dicText As New Dictionary(Of Int32, String)

  Private mSelectedPicture As Integer
  Private dicTag As New Dictionary(Of Int32, String)

  Private Sub apifrmToolPic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    dicText.Add(0, "")
    dicText.Add(1, "")
    dicText.Add(2, "")
    dicText.Add(3, "")
    dicText.Add(4, "")
    dicText.Add(5, "")
    dicText.Add(6, "")
    dicText.Add(7, "")

    mSelectedPicture = 0
  End Sub

  Public Sub SetTag(i As Integer, tag As String)
    dicTag.Add(i, tag)
  End Sub

  Public Function GetTag() As String
    Return dicTag(mSelectedPicture)
  End Function

  Public Sub Ecrire(i As Integer, text As String)

    dicText(i) = text

    Select Case i
      Case 0
        pic0.Invalidate()
      Case 1
        pic1.Invalidate()
      Case 2
        pic2.Invalidate()
      Case 3
        pic3.Invalidate()
      Case 4
        pic4.Invalidate()
      Case 5
        pic5.Invalidate()
      Case 6
        pic6.Invalidate()
      Case 7
        pic7.Invalidate()
    End Select
  End Sub

  Private Sub picbox_Paint(sender As Object, e As PaintEventArgs) Handles pic0.Paint, pic1.Paint, pic2.Paint, pic3.Paint, pic4.Paint, pic5.Paint, pic6.Paint, pic7.Paint
    Dim picNumber As Integer = CType(sender, PictureBox).Tag
    Dim t As String = dicText(picNumber)
    Dim myFont As Font = New Font("Tahoma", 8)
    e.Graphics.DrawString(dicText(picNumber), myFont, Brushes.Black, New Point(2, 2))
  End Sub


  Public Sub mBackColor(i As Integer, color As Color)
    Select Case i
      Case 0
        pic0.BackColor = color
      Case 1
        pic1.BackColor = color
      Case 2
        pic2.BackColor = color
      Case 3
        pic3.BackColor = color
      Case 4
        pic4.BackColor = color
      Case 5
        pic5.BackColor = color
      Case 6
        pic6.BackColor = color
      Case 7
        pic7.BackColor = color
    End Select
  End Sub

  Public Function GetBackColor(i As Integer) As Color

    Dim color As Color
    Select Case i
      Case 0
        color = pic0.BackColor
      Case 1
        color = pic1.BackColor
      Case 2
        color = pic2.BackColor
      Case 3
        color = pic3.BackColor
      Case 4
        color = pic4.BackColor
      Case 5
        color = pic5.BackColor
      Case 6
        color = pic6.BackColor
      Case 7
        color = pic7.BackColor
    End Select
    Return color
  End Function

  Private Sub pic_Click(sender As Object, e As EventArgs) Handles pic0.Click, pic1.Click, pic2.Click, pic3.Click, pic4.Click, pic5.Click, pic6.Click, pic7.Click
    mSelectedPicture = CType(sender, PictureBox).Tag
  End Sub

  Private Sub pic_MouseUp(sender As Object, e As EventArgs) Handles pic0.MouseUp, pic1.MouseUp, pic2.MouseUp, pic3.MouseUp, pic4.MouseUp, pic5.MouseUp, pic6.MouseUp, pic7.MouseUp
    RaiseEvent PicMouseUp(sender, e)
  End Sub

  Private Sub pic_MouseUp(sender As Object, e As MouseEventArgs) Handles pic3.MouseUp, pic2.MouseUp, pic1.MouseUp, pic0.MouseUp, pic4.MouseUp, pic5.MouseUp, pic6.MouseUp, pic7.MouseUp

  End Sub
End Class