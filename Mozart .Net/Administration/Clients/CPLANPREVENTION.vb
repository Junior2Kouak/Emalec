Imports System.Data.SqlClient
Imports System.Reflection.MethodBase
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class CPLANPREVENTION

  Dim cnxNetPlanPrev As SqlConnection
  Dim NomSociete As String

  Dim _DtListePLanPrev As DataTable

  Dim FileNameTMPSignatureIn As String
  Dim FileNameTMPSignatureOut As String

  'fichier de sortie final avec signature et date
  Dim _FileOut As String
  'fichier concat avec siganture et date
  Dim FilePDF_Part_Sign As String

  Public Sub New(ByVal c_cnxNet As SqlConnection, ByVal c_Nomsociete As String)

    NomSociete = c_Nomsociete
    cnxNetPlanPrev = c_cnxNet

    FileNameTMPSignatureIn = String.Format("{0}\PlanPrev\TmpSignIn.png", My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Mozart\PDF")
    FileNameTMPSignatureOut = String.Format("{0}\PlanPrev\TmpSignOut.png", My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Mozart\PDF")

    _FileOut = String.Format("{0}\PlanPrev\FileOutFinal.pdf", My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Mozart\PDF")
    FilePDF_Part_Sign = String.Format("{0}\PlanPrev\PartSign.pdf", My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Mozart\PDF")

  End Sub

  Public ReadOnly Property FileOut As String
    Get
      Return _FileOut
    End Get
  End Property

  Public ReadOnly Property DtListePLanPrev As DataTable
    Get
      Return _DtListePLanPrev
    End Get
  End Property

  Public Sub LoadData(ByVal P_DateDebut As String, ByVal P_DateFin As String)

    Try

      _DtListePLanPrev = New DataTable

      Dim sqlcmd As New SqlCommand("[api_sp_ListePlanPrevTechApprob]", cnxNetPlanPrev)
      sqlcmd.CommandType = CommandType.StoredProcedure
      sqlcmd.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = NomSociete
      sqlcmd.Parameters.Add("@P_DATE_DEBUT", SqlDbType.DateTime).Value = P_DateDebut
      sqlcmd.Parameters.Add("@P_DATE_FIN", SqlDbType.DateTime).Value = P_DateFin
      _DtListePLanPrev.Load(sqlcmd.ExecuteReader)

    Catch ex As Exception

      MessageBox.Show(String.Format("ERREUR : Description Class {0} - procedure {1} - Erreur : {2}", Me.GetType.Name, GetCurrentMethod().Name, ex.Message))

    End Try

  End Sub
  '******************************************************************
  'Cette fonction permet de copier les dll necessaire au modificaiton du pdf a la srouce de l'EXE
  '******************************************************************
  Public Function DllsNeeded() As String

    Dim TabFileDLLs() As String = {"itextsharp.dll", "itextsharp.pdfa.dll", "itextsharp.xtra.dll"}

    For Each sFileNameDLL As String In TabFileDLLs

      If File.Exists(Application.StartupPath & "\" & sFileNameDLL) = False Then

        ' TB SAMSIC CITY PATH
        ' If File.Exists("\\SRV-WEB01\Mozart\Bin\" & sFileNameDLL) Then
        '   File.Copy("\\SRV-WEB01\Mozart\Bin\" & sFileNameDLL, Application.StartupPath & "\" & sFileNameDLL)
        ' Else
        '  Return String.Format("Le fichier {0} n'existe pas.", "\\SRV-WEB01\Mozart\Bin\" & sFileNameDLL)
        ' End If
        If File.Exists(RechercheParamByLib("MOZART_RESSOURCES") & "Bin\" & sFileNameDLL) Then
          File.Copy(RechercheParamByLib("MOZART_RESSOURCES") & "Bin\" & sFileNameDLL, Application.StartupPath & "\" & sFileNameDLL)
        Else
          Return String.Format("Le fichier {0} n'existe pas.", RechercheParamByLib("MOZART_RESSOURCES") & "Bin\" & sFileNameDLL)
        End If

      End If

    Next

    Return ""

  End Function

  Public Function GeneratePlanPrevSigne(ByVal p_DatarowSelected As DataRow) As String

    Dim sRetLog As String = ""

    If p_DatarowSelected Is Nothing Then Return "Erreur : Pas de ligne sélectionnée"

    '------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'si pas de signature alors on affiche le document non signé
    If IsDBNull(p_DatarowSelected.Item("IPROCTECHAPPROBSIGN")) Then

      _FileOut = p_DatarowSelected.Item("VFICHIER")
      Return ""

    End If
    '------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'init
    If Directory.Exists((Path.GetDirectoryName(FileNameTMPSignatureIn))) = True Then
      If File.Exists(FileNameTMPSignatureIn) Then File.Delete(FileNameTMPSignatureIn)
      If File.Exists(FileNameTMPSignatureOut) Then File.Delete(FileNameTMPSignatureOut)
    Else
      Directory.CreateDirectory(Path.GetDirectoryName(FileNameTMPSignatureIn))
    End If

    'gestion de du fichier PDF
    If IsDBNull(p_DatarowSelected.Item("VFICHIER")) Then Return String.Format("Erreur : Le fichier {0} n'existe pas", p_DatarowSelected.Item("VFICHIER"))
    If File.Exists(p_DatarowSelected.Item("VFICHIER")) = False Then Return String.Format("Erreur : Le fichier {0} n'existe pas", p_DatarowSelected.Item("VFICHIER"))

    'on crée la signature
    sRetLog = GenererImage(p_DatarowSelected.Item("IPROCTECHAPPROBSIGN"), New Size(100, 35), FileNameTMPSignatureIn, FileNameTMPSignatureOut)
    If sRetLog <> "" Then Return String.Format("ERREUR : Description Class {0} - procedure {1} - Erreur : {2}", Me.GetType.Name, GetCurrentMethod().Name, sRetLog)

    If File.Exists(FileOut) = True Then File.Delete(FileOut)
    If File.Exists(FilePDF_Part_Sign) = True Then File.Delete(FilePDF_Part_Sign)

    'generation du pdf
    Try

      'Fihicer PDF Source
      Dim oPDFReaderSrc As PdfReader = New PdfReader(p_DatarowSelected.Item("VFICHIER").ToString)
      Dim oPDFStamper As PdfStamper = New PdfStamper(oPDFReaderSrc, New FileStream(_FileOut, FileMode.Create))
      Dim x_text As Int32 = 80
      Dim y_text As Int32 = 770
      Dim x_img_sign As Int32
      Dim y_img_sign As Int32
      Dim pic As iTextSharp.text.Image

      'Init
      Dim font As Font = New Font
      font.Size = 6

      Dim NbPages As Int32 = oPDFReaderSrc.NumberOfPages
      Dim background As PdfContentByte
      Dim pagesize As Rectangle

      For i = 1 To NbPages Step 1

        pagesize = oPDFReaderSrc.GetPageSize(i)
        background = oPDFStamper.GetOverContent(i)

        Using InputImageStream As FileStream = New FileStream(FileNameTMPSignatureOut, FileMode.Open, FileAccess.Read)

          pic = iTextSharp.text.Image.GetInstance(InputImageStream)

          x_img_sign = pagesize.Width - pic.Width - 10
          y_img_sign = 25

          pic.SetAbsolutePosition(x_img_sign, y_img_sign)
          background.AddImage(pic)

        End Using

        'date signature               
        x_text = 80
        y_text = 770

        x_text = Convert.ToInt32(pagesize.Width - x_text)
        y_text = Convert.ToInt32(pagesize.Height - y_text)

        ColumnText.ShowTextAligned(background, Element.ALIGN_LEFT, New Phrase(p_DatarowSelected.Item("DPROCTECHAPPROBSIGN").ToString, font), x_text, y_text + 10, 0)
        ColumnText.ShowTextAligned(background, Element.ALIGN_LEFT, New Phrase(p_DatarowSelected.Item("VPERNOM").ToString, font), x_text, y_text, 0)


      Next
      oPDFStamper.Close()
      oPDFReaderSrc.Close()

    Catch ex As Exception
      Return String.Format("ERREUR : Description Class {0} - procedure {1} - Erreur : {2}", Me.GetType.Name, GetCurrentMethod().Name, ex.Message)
    End Try

    Return ""

    'Using PdfReaderSignature As PdfReader = New PdfReader(p_DatarowSelected.Item("VFICHIER").ToString)

    '    'Nombre de pages du PDF
    '    Dim NbPagesPDF As Int32 = PdfReaderSignature.NumberOfPages

    '    'on genere la derneire page avec la signature et la date
    '    'Ajout de la date
    '    Using stamper As PdfStamper = New PdfStamper(PdfReaderSignature, New FileStream(FilePDF_Part_Sign, FileMode.Create))

    '        PdfReaderSignature.SelectPages(NbPagesPDF)

    '        Dim pagesize = PdfReaderSignature.GetPageSize(1)
    '        Dim pbover As PdfContentByte = stamper.GetOverContent(1)

    '        'signature
    '        Using InputImageStream As FileStream = New FileStream(FileNameTMPSignatureOut, FileMode.Open, FileAccess.Read)

    '            Dim pic As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(InputImageStream)

    '            Dim x1 As Int32
    '            Dim y1 As Int32

    '            x1 = pagesize.Width - pic.Width - 10
    '            y1 = 25

    '            pic.SetAbsolutePosition(x1, y1)
    '            pbover.AddImage(pic)

    '        End Using

    '        'date signature
    '        Dim font As Font = New Font
    '        font.Size = 6
    '        Dim x As Int32 = 80
    '        Dim y As Int32 = 770

    '        x = Convert.ToInt32(pagesize.Width - x)
    '        y = Convert.ToInt32(pagesize.Height - y)

    '        ColumnText.ShowTextAligned(pbover, Element.ALIGN_LEFT, New Phrase(p_DatarowSelected.Item("DPROCTECHAPPROBSIGN").ToString, font), x, y + 10, 0)
    '        ColumnText.ShowTextAligned(pbover, Element.ALIGN_LEFT, New Phrase(p_DatarowSelected.Item("VPERNOM").ToString, font), x, y, 0)

    '    End Using

    'End Using

    'generation du doc pdf total
    'Dim oDoc As Document = New Document
    ''Dim writerpdf As PdfCopy = New PdfCopy(oDoc, New FileStream(FileOut, FileMode.Create))

    'oDoc.Open()

    'Using readerpdf As PdfReader = New PdfReader(p_DatarowSelected.Item("VFICHIER").ToString)

    '    For i = 1 To readerpdf.NumberOfPages Step 1

    '        'If i = readerpdf.NumberOfPages Then

    '        'Dim pdfreadersign As PdfReader = New PdfReader(FilePDF_Part_Sign)

    '        Using stamper As PdfStamper = New PdfStamper(readerpdf, New FileStream(FileOut, FileMode.Create))

    '            Dim pagesize = readerpdf.GetPageSize(i)
    '            Dim pbover As PdfContentByte = stamper.GetOverContent(i)

    '            'signature
    '            Using InputImageStream As FileStream = New FileStream(FileNameTMPSignatureOut, FileMode.Open, FileAccess.Read)

    '                Dim pic As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(InputImageStream)

    '                Dim x1 As Int32
    '                Dim y1 As Int32

    '                x1 = pagesize.Width - pic.Width - 10
    '                y1 = 25

    '                pic.SetAbsolutePosition(x1, y1)
    '                pbover.AddImage(pic)

    '            End Using


    '        End Using


    '        'pdfpageimported.AddImage()

    '        'pdfpageimported.ShowTextAligned()


    '        'writerpdf.AddPage(pdfpageimported)
    '        'pdfreadersign.Close()

    '        'Else

    '        'Dim pdfpageimported As PdfImportedPage = writerpdf.GetImportedPage(readerpdf, i)
    '        'writerpdf.AddPage(pdfpageimported)

    '        'End If

    '    Next

    'End Using

    ''writerpdf.Close()
    'oDoc.Close()

  End Function

  Private Function GenererImage(ByVal p_tabImage() As Byte, ByVal p_oSize As Size, ByVal p_sFileIn As String, p_sfileOut As String) As String

    Try

      Dim tabImg() As Byte = p_tabImage
      Dim fsImage As New FileStream(p_sFileIn, FileMode.Create, FileAccess.Write, FileShare.Write)
      fsImage.Write(tabImg, 0, tabImg.Length)
      fsImage.Flush()
      fsImage.Close()

      'resize
      Dim myBitmapIn As New Bitmap(p_sFileIn)
      Dim myBitmapOut As New Bitmap(myBitmapIn, New Size(p_oSize.Width, p_oSize.Height))

      'créer la transparence en remplaant la couleur blanche par transparent
      Dim TabColorWhiteNuance() As String = {"#FAFAFA", "#FBFBFB", "#FCFCFC", "#FDFDFD", "#FEFEFE"}

      myBitmapOut.MakeTransparent(Color.White)
      myBitmapOut.MakeTransparent(Color.WhiteSmoke)
      myBitmapOut.MakeTransparent(Color.Gray)

      For Each oColWhite As String In TabColorWhiteNuance

        myBitmapOut.MakeTransparent(ColorTranslator.FromHtml(oColWhite))

      Next

      myBitmapOut.Save(p_sfileOut, ImageFormat.Png)

      myBitmapIn.Dispose()

      Return ""

    Catch ex As Exception

      Return String.Format("GenererImage dans CPLANPREVENTION - Erreur fichier {0} : {1}", p_sfileOut, ex.Message)

    End Try

  End Function

  Public Function ClearFiles() As String

    Try

      If File.Exists(FileNameTMPSignatureIn) Then File.Delete(FileNameTMPSignatureIn)
      If File.Exists(FileNameTMPSignatureOut) Then File.Delete(FileNameTMPSignatureOut)

      If File.Exists(_FileOut) Then File.Delete(_FileOut)
      If File.Exists(FilePDF_Part_Sign) Then File.Delete(FilePDF_Part_Sign)

      Return ""

    Catch ex As Exception
      Return String.Format("ERREUR : Description Class {0} - procedure {1} - Erreur : {2}", Me.GetType.Name, GetCurrentMethod().Name, ex.Message)

    End Try

  End Function

End Class
