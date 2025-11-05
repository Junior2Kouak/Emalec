Public Class CGenAttachPhoto

  Dim _sFileIn As String
  Dim _sFileOut As String
  Dim _vcomment As String

  Public ReadOnly Property sFileIn As String
    Get
      Return _sFileIn
    End Get
  End Property

  Public ReadOnly Property sFileOut As String
    Get
      Return _sFileOut
    End Get
  End Property
  Public ReadOnly Property vcomment As String
    Get
      Return _vcomment
    End Get
  End Property
  Public Sub New(ByVal c_sFileIn As String, ByVal c_sFileOut As String, ByVal c_vcomment As String)

    _sFileIn = c_sFileIn
    _sFileOut = c_sFileOut
    _vcomment = c_vcomment

    CreateImageOut()

  End Sub

  Private Sub CreateImageOut()

    'on rajoute l'exentsion
    _sFileOut = _sFileOut & ".jpeg"

    'resize
    Dim myBitmapIn As New Bitmap(_sFileIn)
    Dim iRapportXY As Decimal = 1
    Dim oSizeOUt As New Size(516, 308) 'par défaut  taille défini en pts dans le fichier source (à convertir en pixel)

    'landscape
    If myBitmapIn.Width > myBitmapIn.Height Then

      iRapportXY = If(myBitmapIn.Width = 0, 0, myBitmapIn.Height / myBitmapIn.Width)
      oSizeOUt = New Size(516, 516 * iRapportXY)
    Else

      iRapportXY = If(myBitmapIn.Height = 0, 0, myBitmapIn.Width / myBitmapIn.Height)
      oSizeOUt = New Size(308 * iRapportXY, 308)

    End If

    Dim myBitmapOut As New Bitmap(myBitmapIn, oSizeOUt)
    myBitmapOut.Save(_sFileOut, ImageFormat.Jpeg)

    myBitmapIn.Dispose()
    myBitmapOut.Dispose()

  End Sub

End Class
