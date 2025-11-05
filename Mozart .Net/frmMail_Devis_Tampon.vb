Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MozartLib

Public Class frmMail_Devis_Tampon

  ' TB SAMSIC CITY PATH
  ' Dim sFileTampon As String = "\\srv-web01\Mozart\Modeles\Tampon-Reception-XEROX-Vectoriel.png"
  Dim sFileTampon As String = RechercheParamByLib("MOZART_RESSOURCES") & "Modeles\Tampon-Reception-XEROX-Vectoriel.png"

  Dim _FileIn As String
  Dim _FileOut As String
  Dim _FileOut_Tamponne As String

  Public Sub New(ByVal c_FileIn As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _FileIn = c_FileIn.ToString
    _FileOut = MozartParams.CheminUtilisateurMozart & "PDF\" & Path.GetFileNameWithoutExtension(_FileIn).Replace(" ", "_") & "_Out" & Path.GetExtension(_FileIn)
    _FileOut_Tamponne = MozartParams.CheminUtilisateurMozart & "PDF\" & Path.GetFileNameWithoutExtension(_FileIn).Replace(" ", "_") & "_Out_Tampon" & Path.GetExtension(_FileIn)

  End Sub

  Private Sub frmMail_Devis_Tampon_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Me.Hide()
    Me.Opacity = 0

    If File.Exists(sFileTampon) = False Then MessageBox.Show(String.Format(My.Resources.Global_fichier_existe_pas, sFileTampon), My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub

    If File.Exists(_FileIn) = False Then MessageBox.Show(String.Format(My.Resources.Global_fichier_existe_pas, _FileIn), My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub

    If File.Exists(_FileOut) = True Then File.Delete(_FileOut)
    If File.Exists(_FileOut_Tamponne) = True Then File.Delete(_FileOut_Tamponne)

    'on tamponne la^premiere page
    Using PdfReaderSignature As PdfReader = New PdfReader(_FileIn)

      'on genere la premiere page avec la signature et la date
      'Ajout de la date
      Using stamper As PdfStamper = New PdfStamper(PdfReaderSignature, New FileStream(_FileOut_Tamponne, FileMode.Create))

        PdfReaderSignature.SelectPages(1)

        Dim pagesize = PdfReaderSignature.GetPageSize(1)

        Dim pbover As PdfContentByte = stamper.GetOverContent(1)

        'signature
        Using InputImageStream As FileStream = New FileStream(sFileTampon, FileMode.Open, FileAccess.Read)

          Dim pic As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(InputImageStream)

          Dim x1 As Int32
          Dim y1 As Int32

          pic.ScaleAbsoluteHeight(75)
          pic.ScaleAbsoluteWidth(145)

          'mode landscape
          If pagesize.Width > pagesize.Height Then
            x1 = pagesize.Height - 230
            y1 = pagesize.Width - 180
          Else
            x1 = pagesize.Width - 180
            y1 = pagesize.Height - 230
          End If

          pic.SetAbsolutePosition(x1, y1)
          pic.Rotation = 0.05
          pbover.AddImage(pic)

          InputImageStream.Close()

        End Using

        stamper.Close()

      End Using

      PdfReaderSignature.Close()

    End Using

    Dim oDoc As Document = New Document
    Dim writerpdf As PdfCopy = New PdfCopy(oDoc, New FileStream(_FileOut, FileMode.Create))

    oDoc.Open()

    Using readerpdf As PdfReader = New PdfReader(_FileIn)

      For i = 1 To readerpdf.NumberOfPages Step 1

        If i = 1 Then

          Dim pdfreadersign As PdfReader = New PdfReader(_FileOut_Tamponne)
          Dim pdfpageimported As PdfImportedPage = writerpdf.GetImportedPage(pdfreadersign, 1)
          writerpdf.AddPage(pdfpageimported)


        Else

          Dim pdfpageimported As PdfImportedPage = writerpdf.GetImportedPage(readerpdf, i)
          writerpdf.AddPage(pdfpageimported)

        End If

      Next

    End Using

    writerpdf.Close()
    oDoc.Close()

    'on remplace le fichier filein par le fileout
    File.Copy(_FileOut, _FileIn, True)

    Me.Close()

  End Sub

  Private Sub frmMail_Devis_Tampon_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

    Me.Visible = False

  End Sub
End Class