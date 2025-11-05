Imports System.Drawing.Printing
Imports System.Reflection
Imports System.Runtime.CompilerServices

Public Module Extensions
  <Extension()>
  Sub DoubleBuffered(ByVal dgv As DataGridView, ByVal setting As Boolean)
    Dim dgvType As Type = dgv.[GetType]()
    Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
    pi.SetValue(dgv, setting, Nothing)
  End Sub

  Private WithEvents printDocument1 As New PrintDocument
  Dim memoryImage As Bitmap

  <Extension()>
  Public Sub ImprimerDansWord(ByVal f As Form)

    Dim myGraphics As Graphics = f.CreateGraphics()
    Dim s As Size = f.Size
    memoryImage = New Bitmap(s.Width, s.Height, myGraphics)
    Dim memoryGraphics As Graphics = Graphics.FromImage(memoryImage)
    memoryGraphics.CopyFromScreen(f.Location.X, f.Location.Y, 0, 0, s)
    printDocument1.Print()

  End Sub

  Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles printDocument1.PrintPage
    e.Graphics.DrawImage(memoryImage, 0, 0)
  End Sub
End Module
