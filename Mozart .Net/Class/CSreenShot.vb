'*************************************************************************************************************************************************************
'Date creation : 12/11/2013
'Date dernière modification :
'Version : 1.0
'Auteur : MC
'Description :
'Permet de faire un screen shot d'une form et de lancer l 'impression
'passer en parametres dans le constructeur de la classe un objet FORM
'*************************************************************************************************************************************************************
Imports System.Drawing.Printing

Public Class CSreenShot

    Private Declare Function BitBlt Lib "gdi32.dll" Alias "BitBlt" (ByVal _
    hdcDest As IntPtr, ByVal nXDest As Integer, ByVal nYDest As _
    Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal _
    hdcSrc As IntPtr, ByVal nXSrc As Integer, ByVal nYSrc As Integer, _
    ByVal dwRop As System.Int32) As Long

    Dim memoryImage As Bitmap
    Dim oFormObj As Form
    Dim PrintDocObj As PrintDocument

    Dim oOrientation As Boolean

    Dim oPageSettings As PageSettings 

    Public Sub New(ByVal c_FormObject As Form, Optional ByVal c_bLanscape As Boolean = false, Optional ByVal c_iMargeX As int32 = 10, Optional ByVal c_iMargeY As int32 = 10)

        'INIT
        oFormObj = c_FormObject

        PrintDocObj =  New PrintDocument
        oPageSettings = New PageSettings
                
        oOrientation = c_bLanscape
        'page settings
        oPageSettings.Landscape = c_bLanscape   
        oPageSettings.Margins.Left = c_iMargeX
        oPageSettings.Margins.Right = c_iMargeX
        oPageSettings.Margins.Top = c_iMargeY
        oPageSettings.Margins.Bottom = c_iMargeY

        PrintDocObj.DefaultPageSettings = oPageSettings

        AddHandler PrintDocObj.PrintPage, AddressOf PrintDocumentObj_PrintPage
        
    End Sub

    Public ReadOnly Property Orientation As Boolean 
        Get
            Return oOrientation
        End Get
    End Property 

    Private Sub CaptureScreen()

        Dim mygraphics As Graphics = oFormObj.CreateGraphics()
        Dim s As Size = oFormObj.Size
        memoryImage = New Bitmap(s.Width, s.Height, mygraphics)
        Dim memoryGraphics As Graphics = Graphics.FromImage(memoryImage)
        Dim dc1 As IntPtr = mygraphics.GetHdc
        Dim dc2 As IntPtr = memoryGraphics.GetHdc
        BitBlt(dc2, 0, 0, oFormObj.ClientRectangle.Width, _
           oFormObj.ClientRectangle.Height, dc1, 0, 0, 13369376)
        mygraphics.ReleaseHdc(dc1)
        memoryGraphics.ReleaseHdc(dc2)
    End Sub

    Private Sub PrintDocumentObj_PrintPage(ByVal sender As System.Object, _
       ByVal e As System.Drawing.Printing.PrintPageEventArgs) 
        
        Dim RatioImgSrc As Decimal 
        Dim height_dest As Int32 
        Dim width_dest As Int32 

        If oPageSettings.Landscape = false Then
            
            If Not memoryImage is nothing Then RatioImgSrc = memoryImage.Height  / memoryImage.Width

            e.Graphics.DrawImage(memoryImage, _
                                  oPageSettings.PrintableArea.Left + oPageSettings.Margins.left, _
                                  oPageSettings.PrintableArea.Top + oPageSettings.Margins.top, _
                                  oPageSettings.PrintableArea.Width - (oPageSettings.Margins.right + oPageSettings.Margins.left), _ 
                                  RatioImgSrc * (oPageSettings.PrintableArea.Width - (oPageSettings.Margins.right + oPageSettings.Margins.left)))

        Else
            
            If Not memoryImage is nothing Then 



                    'on redimensionne
                    height_dest = oPageSettings.PrintableArea.Width - (oPageSettings.Margins.right + oPageSettings.Margins.left)
                    width_dest = oPageSettings.PrintableArea.Height - (oPageSettings.Margins.top + oPageSettings.Margins.Bottom)

                    e.Graphics.DrawImage (memoryImage, new Rectangle(oPageSettings.Margins.left, oPageSettings.Margins.top, width_dest, height_dest), new Rectangle (0, 0, memoryImage.Width, memoryImage.Height), GraphicsUnit.Pixel)
            
            end if


            

            'memoryImage.RotateFlip(RotateFlipType.Rotate90FlipNone ) 

            'e.Graphics.DrawImage (memoryImage, new Rectangle(0, 0, oPageSettings.PrintableArea.Height, oPageSettings.PrintableArea.Width), new Rectangle (0, 0, memoryImage.Width, memoryImage.Height), GraphicsUnit.Pixel)

            


            'If (RatioImgSrc * (oPageSettings.PrintableArea.Width - (oPageSettings.Margins.right + oPageSettings.Margins.left))) > oPageSettings.PrintableArea.Width Then
                
            '    height_dest = oPageSettings.PrintableArea.Height - (oPageSettings.Margins.top + oPageSettings.Margins.Bottom)
            '    RatioImgSrc = memoryImage.Height  / memoryImage.Width
            '    width_dest = RatioImgSrc * (oPageSettings.PrintableArea.Height - (oPageSettings.Margins.top + oPageSettings.Margins.Bottom))

            'Else

            '    height_dest = RatioImgSrc * (oPageSettings.PrintableArea.Width - (oPageSettings.Margins.right + oPageSettings.Margins.left))
            '    width_dest = oPageSettings.PrintableArea.Width - (oPageSettings.Margins.right + oPageSettings.Margins.left)
                
            'End If

            'e.Graphics.DrawImage(memoryImage, _
            '                      oPageSettings.PrintableArea.Top + oPageSettings.Margins.top, _
            '                      oPageSettings.PrintableArea.Left + oPageSettings.Margins.left, _
            '                      height_dest, _ 
            '                      width_dest)

        End If
       
    End Sub

    Public Sub Print_Form()

        If Not oFormObj Is Nothing Then

            CaptureScreen()
            PrintDocObj.Print 

        End If

    End Sub

End Class
