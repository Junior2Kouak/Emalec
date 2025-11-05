Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Imports System.Reflection.MethodBase
Imports DevExpress.XtraRichEdit

Public Class CGenDocument

  Dim cnxADODB As ADODB.Connection

  Dim _cnxDocGen As SqlConnection
  Dim _sPathAllFilesOut As String

  ' TB SAMSIC CITY PATH
  ' Dim _sPathModeles As String = "\\srv-web01\Mozart\Modeles\{0}\{1}\"
  Dim _sPathModeles As String = RechercheParamByLib("MOZART_RESSOURCES") & "Modeles\{0}\{1}\"

  Public Sub New(ByVal c_cnxDocGen As SqlConnection, ByVal c_server As String, ByVal c_Base As String)

    _cnxDocGen = c_cnxDocGen

    'ouvert du adodb pour creation rtf
    cnxADODB = New ADODB.Connection
    cnxADODB.ConnectionString = String.Format("Provider=SQLOLEDB.1;Data Source={0};Initial Catalog={1};trusted_connection=yes;", c_server, c_Base)
    cnxADODB.CursorLocation = ADODB.CursorLocationEnum.adUseClientBatch
    cnxADODB.Open()

  End Sub

  Public Sub CloseCnxADODB()

    If cnxADODB.State = 1 Then cnxADODB.Close()

  End Sub

  Public Function LoadPathModeles(ByVal p_vsociete As String, Optional ByVal p_sLangue As String = "FR") As String

    Return String.Format(_sPathModeles, p_vsociete, p_sLangue)

  End Function

  Public Function GenererImage(ByVal p_tabImage() As Byte, ByVal p_oSize As Size, ByVal p_sFileIn As String, p_sfileOut As String) As String

    Try

      Dim tabImg() As Byte = p_tabImage
      Dim fsImage As New FileStream(p_sFileIn, FileMode.Create, FileAccess.Write, FileShare.Write)
      fsImage.Write(tabImg, 0, tabImg.Length)
      fsImage.Flush()
      fsImage.Close()

      'resize
      Dim myBitmapIn As New Bitmap(p_sFileIn)
      Dim myBitmapOut As New Bitmap(myBitmapIn, New Size(p_oSize.Width, p_oSize.Height))
      myBitmapOut.Save(p_sfileOut, ImageFormat.Jpeg)

      'on vide la bitmap temp
      myBitmapIn.Dispose()

      Return ""

    Catch ex As Exception

      Return String.Format("GenererImage dans CGenDocument - Erreur fichier {0} : {1}", p_sfileOut, ex.Message)

    End Try

  End Function

  Public Function GenererRTF(ByVal p_sFileIn As String, ByVal p_sFileOut As String, ByVal p_ReqSQL As String) As String

    Dim oGenEtatRTF As New GenEtat
    Dim Tdb(,) As String = {{"Now", Now.ToString()}}

    Try

      Dim ret_err As Long = oGenEtatRTF.MkRTF(p_sFileIn, p_sFileOut, p_ReqSQL, cnxADODB, Tdb)

      If ret_err <> 0 Then Return String.Format("Erreur : GenererRTF dans CGenDocument - Modele: {0} - Document : {1} - Requete - {2} - N° erreur : {3}", p_sFileIn, p_sFileOut, p_ReqSQL, ret_err & " - " & oGenEtatRTF.LastError)

      Return ""

    Catch ex As Exception

      Return String.Format("Erreur : GenererRTF dans CGenDocument - Modele: {0} - Document : {1} - Requete - {2} - Erreur : {3}", p_sFileIn, p_sFileOut, p_ReqSQL, ex.Message)

    End Try

  End Function

  Public Function SaveAsPDF(ByVal p_sFileIn As String, ByVal p_sFileOut As String) As String

    Dim oWord As New Word.Application()
    Dim oDoc As Word.Document

    Try
      oWord.Visible = False
      oWord.WindowState = WdWindowState.wdWindowStateMinimize
      oDoc = oWord.Documents.Open(p_sFileIn)

      Dim ExportFilePath As String = p_sFileOut
      Dim ExportFormat As WdExportFormat = WdExportFormat.wdExportFormatPDF
      Dim OpenAfterExport As Boolean = False
      Dim ExportOptimizeFor As WdExportOptimizeFor = WdExportOptimizeFor.wdExportOptimizeForPrint
      Dim ExportRange As WdExportRange = WdExportRange.wdExportAllDocument
      Dim StartPage As Int32 = 0
      Dim EndPage As Int32 = 0
      Dim ExportItem As WdExportItem = WdExportItem.wdExportDocumentContent
      Dim IncludeDocProps As Boolean = True
      Dim KeepIRM As Boolean = True
      Dim CreateBookmarks As WdExportCreateBookmarks = WdExportCreateBookmarks.wdExportCreateNoBookmarks
      Dim DocStructureTags As Boolean = True
      Dim BitmapMissingFonts As Boolean = True
      Dim UseISO19005_1 As Boolean = False

      oDoc.ExportAsFixedFormat(ExportFilePath, ExportFormat, OpenAfterExport, ExportOptimizeFor, ExportRange, StartPage, EndPage, ExportItem, IncludeDocProps,
       KeepIRM, CreateBookmarks, DocStructureTags, BitmapMissingFonts, UseISO19005_1)

      oDoc.Close(WdSaveOptions.wdDoNotSaveChanges)

      Return ""

    Catch ex As Exception
      Return String.Format("Erreur : SaveAsPDF dans CGenDocument - Fichier RTF: {0} - Fichier PDF : {1} - erreur : {2}", p_sFileIn, p_sFileOut, ex.Message)
    Finally
      oWord.Quit(WdSaveOptions.wdDoNotSaveChanges)
      oWord = Nothing
    End Try

  End Function

  Public Function GenerateFilePhoto(ByVal ttablphoto() As Byte, ByVal sNomFileSortie As String, ByVal sPath As String) As String

    Try

      Dim fs As New FileStream(sPath + sNomFileSortie, FileMode.Create, FileAccess.Write, FileShare.Write)
      fs.Write(ttablphoto, 0, ttablphoto.Length)
      fs.Flush()
      fs.Close()

      Return ""

    Catch ex As Exception

      Return String.Format("Erreur : GenerateFilePhoto dans CGenDocument - Chemin accès: {0} - Fichier photo : {1} - erreur : {2}", sPath, sNomFileSortie, ex.Message)

    End Try

  End Function

End Class
