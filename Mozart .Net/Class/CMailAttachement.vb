Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports MozartLib

'************************************
'parametres pour test
'srv-sql05 EMALEC FrmSendFactureMail "adelaye@emalec.com|Facturation H&M du 30/05/2014 - EMALEC|Bonjour,
'Veuillez trouver en pièce jointe la (ou les) facture(s)§ F00202706 du mois30/05/2014,
'le fichier contenant les attachements de la facture sous format PDF.
'Ce mail est à envoyer à l'adresse mail suivante : adelaye@emalec.com
'EMALEC|C:\Temp\TFactureClientH&M202706.pdf|202706"
'**********************************

Public Class CMailAttachement

  Dim _sOutResult As String
  Dim _sFileResult As String
  Dim _sError As String
  Dim _bError As Boolean

  ReadOnly Property sOutResult As String
    Get
      Return _sOutResult
    End Get
  End Property

  ReadOnly Property sFileResult As String
    Get
      Return Path.GetFileName(_sOutResult)
    End Get
  End Property

  ReadOnly Property sError As String
    Get
      Return _sError
    End Get
  End Property

  ReadOnly Property bError As Boolean
    Get
      Return _bError
    End Get
  End Property

  Public Sub GeneratePDF(ByVal p_vserveur As String, ByVal p_vsociete As String, ByVal p_NFACNUM As Int32, ByVal sFileNameOut As String, ByVal bAjouteDocCLient As Boolean, ByVal useCloudOnly As String, Optional ByVal sPJConcat As String = "")

    'Init
    _sOutResult = ""
    _bError = False
    _sError = ""
    Dim dtAttachements As New DataTable

    ' Ajout NL le 21/01/2016
    Dim lstFichiersASupprimerApresConcat As New List(Of String)  ' Liste contenant les fichiers que l'on pourra supprimer en fin de traitement

    Dim PathDest As String = PathDestFloderTemporaire(p_NFACNUM)

    Try

      Dim sqlcmd As New SqlCommand("api_sp_Liste_Attachement_By_NFACNUM", MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.StoredProcedure
      sqlcmd.Parameters.Add("@p_nfacnum", SqlDbType.Int)
      sqlcmd.Parameters("@p_nfacnum").Value = p_NFACNUM

      dtAttachements.Load(sqlcmd.ExecuteReader)

      'on copie la pièces jointes à fusionner
      If sPJConcat <> "" AndAlso Path.GetExtension(sPJConcat).ToUpper = ".PDF" And File.Exists(sPJConcat) Then File.Copy(sPJConcat, PathDest & "\0_" & Path.GetFileName(sPJConcat), True)

      For Each DrAttachement As DataRow In dtAttachements.Rows

        'DrAttachement.Item("PATHFILE")
        If File.Exists(DrAttachement.Item("PATHFILE")) = True Then

          File.Copy(DrAttachement.Item("PATHFILE"), PathDest & "\" & DrAttachement.Item("VFILE"), True)
          lstFichiersASupprimerApresConcat.Add(PathDest & "\" & DrAttachement.Item("VFILE"))
        Else

          'on teste si le fichier attachment n'est pas aussi présent dans photosact (cela est déjà arrivé)
          If File.Exists(DrAttachement.Item("PATHFILE").replace("AttachementsGammes", "PhotosAction")) = True Then

            'DrAttachement.Item("PATHFILE") = DrAttachement.Item("PATHFILE").replace("AttGamPdf", "PhotosAct")
            File.Copy(DrAttachement.Item("PATHFILE").replace("AttachementsGammes", "PhotosAction"), PathDest & "\" & DrAttachement.Item("VFILE"), True)
            lstFichiersASupprimerApresConcat.Add(PathDest & "\" & DrAttachement.Item("VFILE"))

          End If
        End If

      Next

      ' Modif NL le 19/10/2016, rendre l'ajout de docs client optionnel
      If bAjouteDocCLient = True Then
        'copy des commande clients
        sqlcmd = New SqlCommand("api_sp_Liste_DocClient_By_NFACNUM", MozartDatabase.cnxMozart)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@p_nfacnum", SqlDbType.Int)
        sqlcmd.Parameters("@p_nfacnum").Value = p_NFACNUM
        sqlcmd.Parameters.Add("@p_ntypedoc", SqlDbType.Int)
        sqlcmd.Parameters("@p_ntypedoc").Value = 4 'commande client

        dtAttachements.Load(sqlcmd.ExecuteReader)

        For Each DrAttachement As DataRow In dtAttachements.Rows

          'DrAttachement.Item("PATHFILE")
          If File.Exists(DrAttachement.Item("PATHFILE")) = True Then

            File.Copy(DrAttachement.Item("PATHFILE"), PathDest & "\" & NamingForPDFTK(DrAttachement.Item("VFILE")), True)
            lstFichiersASupprimerApresConcat.Add(PathDest & "\" & NamingForPDFTK(DrAttachement.Item("VFILE")))

          End If

        Next
      End If

    Catch ex As Exception
      _sOutResult = ""
      _sError = "GeneratePDF" & ex.Message
      _bError = True
    Finally


    End Try

    'on lance le pdftk pour assembler tous les pdf du dossier
    Dim lPdfTKExe As String = Path.Combine(MozartParams.CheminMozart, "pdftk.exe")

    Dim oIDProcessus As New Process

    Dim Startcmd As New ProcessStartInfo()
    Startcmd.UseShellExecute = False
    Startcmd.FileName = lPdfTKExe
    Startcmd.WorkingDirectory = PathDest + "\"
    Startcmd.Arguments = String.Format("*.pdf cat output {0}", sFileNameOut)
    'Startcmd.RedirectStandardOutput = True
    'Startcmd.RedirectStandardError = true
    Startcmd.CreateNoWindow = True
    Startcmd.WindowStyle = ProcessWindowStyle.Hidden

    Try

      oIDProcessus.StartInfo = Startcmd
      oIDProcessus.Start()
      oIDProcessus.WaitForExit()

      If File.Exists(PathDest + "\" + sFileNameOut) = False Then

        _sOutResult = ""
        _sError = "Le fichier suivant n'existe pas (voir pdftk) : " & PathDest & "\" & sFileNameOut
        _bError = True
        Exit Try

      End If

      ' NL le 21/01/2016
      ' On supprime les fichiers qui ont été groupés en un seul PDF
      For cpt = 0 To lstFichiersASupprimerApresConcat.Count - 1
        Dim fileSuppr As String = lstFichiersASupprimerApresConcat.ElementAt(cpt)
        Try
          File.Delete(fileSuppr)
        Catch ex As Exception
          ' Echec de la suppression...
          ' Pas grave, au final.
        End Try

      Next cpt

      If useCloudOnly = "1" Then
        ' Pas de mail, dépot sur Cloud dédié
        MsgBox("Le fichier PDF a été généré et est prêt à être envoyé au client. Déposez-le sur le cloud dédié aux clients" & vbCrLf & "Le fichier est dans le répertoire suivant : " & PathDest & "\" & sFileNameOut, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Fichier à envoyer par Cloud")
        System.Diagnostics.Process.Start(PathDest)
      Else

        If FileIO.FileSystem.GetFileInfo(PathDest + "\" + sFileNameOut).Length > 7000000 Then
          _sOutResult = ""
          _sError = "La taille du fichier pdf avec tous les attachements est supérieure à 10 Mo (Taille maximum autorisée) !" & vbCrLf &
                      "Vous pouvez envoyer le fichier via un site internet de transfert de fichier volumineux." & vbCrLf &
                      "Le fichier est dans le répertoire suivant : " & PathDest & "\" & sFileNameOut

          _bError = True
        Else
          _sOutResult = PathDest + "\" + sFileNameOut
          _sError = ""
          _bError = False
        End If

      End If

    Catch ex As Exception

      _sOutResult = ""
      _sError = ex.Message
      _bError = True

    End Try

  End Sub

  Public Sub NettoyageFile(ByVal p_NFACNUM As Int32)
    Dim PathDel As String = PathDestFloderTemporaire(p_NFACNUM)

    If Directory.Exists(PathDel) = True Then Directory.Delete(PathDel, True)
  End Sub

  Private Function PathDestFloderTemporaire(ByVal p_NFACNUM As Int32) As String
    Dim sReturnedPath = "C:\Temp\" + p_NFACNUM.ToString

    If Directory.Exists(sReturnedPath) Then
      Directory.Delete(sReturnedPath, True)
    End If
    Directory.CreateDirectory(sReturnedPath)

    Return sReturnedPath
  End Function

  Private Function NamingForPDFTK(ByVal p_srcFileName As String) As String

    Dim sOutPut As String = ""

    Try
      'Modèle d'expression régulière qui remplace les accent par un rien.
      Dim CaraSearch As String = "[áàâäãåçéèêëíìîïñóòôöõúùûüýÿæœÁÀÂÄÃÅÇÉÈÊËÍÌÎÏÑÓÒÔÖÕÚÙÛÜÝŸÆŒ]"

      sOutPut = Regex.Replace(Path.GetFileNameWithoutExtension(p_srcFileName), CaraSearch, String.Empty)

      If sOutPut = "" Then sOutPut = "NoName"
      sOutPut = sOutPut & Path.GetExtension(p_srcFileName)

      Return sOutPut

    Catch ex As Exception

      Return ""
      _sError = "Dans NamingForPDFTK : " & ex.Message
      _bError = True

    End Try

  End Function

End Class
