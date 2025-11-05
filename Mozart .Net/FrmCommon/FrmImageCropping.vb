Imports System.Windows.Media.Imaging

Public Class FrmImageCropping

    Dim _cropBitmapSrc As Bitmap
    Dim _cropBitmapOut As Bitmap

    Dim cropX As Integer
    Dim cropY As Integer
    Dim cropWidth As Integer
    Dim cropHeight As Integer

    Dim cropPen As Pen
    Dim cropPenSize As Integer = 3
    Dim cropDashStyle As Drawing2D.DashStyle = Drawing2D.DashStyle.Solid
    Dim cropPenColor As Color = Color.Black

    Dim _Cancel As Boolean

    Public ReadOnly Property cropBitmapOut As Bitmap
        Get
            Return _cropBitmapOut
        End Get
    End Property

    Public ReadOnly Property Cancel As Boolean
        Get
            Return _Cancel
        End Get
    End Property

    Public Sub New(ByVal C_cropBitmapSrc As Object)

        'ByVal C_cropBitmapSrc As Object

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

        _cropBitmapSrc = C_cropBitmapSrc
        _Cancel = False

    End Sub

    Private Sub FrmImageCropping_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveCropImage()
    End Sub

    Private Sub FrmImageCropping_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = Chr(Keys.Escape) Then

            _Cancel = True
            Me.Close()

        End If

    End Sub

    Private Sub FrmImageCropping_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim coef_width As Decimal = (Screen.PrimaryScreen.WorkingArea.Size.Width / _cropBitmapSrc.Size.Width)
        Dim coef_height As Decimal = (Screen.PrimaryScreen.WorkingArea.Size.Height / _cropBitmapSrc.Size.Height)

        If _cropBitmapSrc.Size.Height > Screen.PrimaryScreen.WorkingArea.Size.Height Or _cropBitmapSrc.Size.Width > Screen.PrimaryScreen.WorkingArea.Size.Width Then

            If _cropBitmapSrc.Size.Height >= _cropBitmapSrc.Size.Width Then

                Me.Height = Screen.PrimaryScreen.WorkingArea.Size.Height
                Me.Width = _cropBitmapSrc.Size.Width * coef_height
                Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Size.Width / 2) - (Me.Width / 2), 0)

            Else

                Me.Height = _cropBitmapSrc.Size.Height * coef_width
                Me.Width = Screen.PrimaryScreen.WorkingArea.Size.Width

                Me.Location = New Point(0, (Screen.PrimaryScreen.WorkingArea.Size.Height / 2) - (Me.Height / 2))

            End If
        Else

            'mode normal
            Me.Height = _cropBitmapSrc.Size.Height
            Me.Width = _cropBitmapSrc.Size.Width

            Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Size.Width / 2) - (_cropBitmapSrc.Size.Width / 2), (Screen.PrimaryScreen.WorkingArea.Size.Height / 2) - (_cropBitmapSrc.Size.Height / 2))

        End If

        PictSrc.Image = _cropBitmapSrc

    End Sub

    Private Sub PictSrc_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictSrc.MouseDown

        Try
            If e.Button = MouseButtons.Left Then
                cropX = e.X
                cropY = e.Y
                cropPen = New Pen(cropPenColor, cropPenSize)
                cropPen.DashStyle = cropDashStyle
            End If
            PictSrc.Refresh()
        Catch exc As Exception

            MessageBox.Show(exc.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub PictSrc_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictSrc.MouseMove

        Try

            If PictSrc.Image Is Nothing Then Exit Sub

            If e.Button = MouseButtons.Left Then
                PictSrc.Refresh()
                cropWidth = e.X - cropX
                cropHeight = e.Y - cropY
                Dim rectDest As New Rectangle(Math.Min(cropX, e.X), Math.Min(cropY, e.Y), Math.Abs(cropWidth), Math.Abs(cropHeight))
                PictSrc.CreateGraphics.DrawRectangle(cropPen, rectDest)

            End If
            GC.Collect()

        Catch exc As Exception
            If Err.Number = 5 Then Exit Sub
            MessageBox.Show(exc.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub PictSrc_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictSrc.MouseUp
        Try
        Catch exc As Exception
            MessageBox.Show(exc.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveCropImage()

        Try
            If cropWidth < 1 Then Exit Sub

            Dim rect As Rectangle = New Rectangle(cropX, cropY, cropWidth, cropHeight)
            Dim bit As Bitmap = New Bitmap(PictSrc.Image, PictSrc.Width, PictSrc.Height)

            _cropBitmapOut = New Bitmap(cropWidth, cropHeight)
            Dim g As Graphics = Graphics.FromImage(_cropBitmapOut)
            g.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel)

        Catch exc As Exception
            MessageBox.Show(exc.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class