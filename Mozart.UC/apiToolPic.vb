Imports System.Drawing
Imports System.Windows.Forms

Public Class apiToolPic

  Public dicText As New Dictionary(Of Int32, String)

  Private _Titre As String
  Public Property Titre() As String
    Get
      Return _Titre
    End Get
    Set(ByVal value As String)
      _Titre = value
    End Set
  End Property


  Private Sub apiToolPic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    dicText.Add(0, "")
    dicText.Add(1, "")
    dicText.Add(2, "")
    dicText.Add(3, "")
  End Sub

  Public Sub SetTag(i As Integer, tag As String)
  End Sub

  Public Sub Ecrire(i As Integer, text As String)

  End Sub

  Public Sub mBackColor(i As Integer, color As Color)
    Me.BackColor = color
  End Sub

  Private Sub pic0_Paint(sender As Object, e As PaintEventArgs)
    Dim myFont As Font = New Font("Arial", 10)
    e.Graphics.DrawString("Hello .NET Guide!", myFont, Brushes.Green, New Point(2, 2))
  End Sub

  Public Function GetBackColor(i As Integer) As Color
    Return Color.White
  End Function
End Class
