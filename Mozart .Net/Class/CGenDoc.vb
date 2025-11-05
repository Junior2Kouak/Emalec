Imports MozartLib

Public Class CGenDoc

  ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
  Dim oDoc As New GenEtat
  Dim Tdb(,) As String = {{"Now", Now.ToString()}}
  Dim cnxVisu As New ADODB.Connection
  Dim sERROR As String

  Dim sTypeDoc As String
  Dim sProcNameWithParam As String

  Dim sPathFileName As String

  Public Property p_PathFileName As String
    Get
      Return sPathFileName
    End Get
    Set(ByVal value As String)
      If sPathFileName = value Then
        Return
      End If
      sPathFileName = value
    End Set
  End Property

  Public Property p_ERROR As String
    Get
      Return sERROR
    End Get
    Set(ByVal value As String)
      If sERROR = value Then
        Return
      End If
      sERROR = value
    End Set
  End Property

  Public Sub New(ByVal sTypeDoc As String, Optional ByVal sProcNameWithParam As String = "", Optional ByVal nID As Int16 = 0)

    cnxVisu.ConnectionString = "Provider=SQLOLEDB.1;Data Source=" & MozartParams.NomServeur & ";Initial Catalog=MULTI;trusted_connection=yes;APP= " & MozartParams.NomSociete
    cnxVisu.CursorLocation = ADODB.CursorLocationEnum.adUseClientBatch
    cnxVisu.Open()

    'sTypeDoc
    Select Case sTypeDoc
      Case "AnaChaFicH" '"exec api_sp_ChantierImpFicheHeure " & iValeur.ToString
        Dim ret As Long = oDoc.MkRTF(MozartParams.CheminModeles & "FR\TChantierFicheHeure.rtf", MozartParams.CheminUtilisateurMozart & "FicheHeure.rtf", sProcNameWithParam, cnxVisu, Tdb)
        If ret <> 0 Then MsgBox("ERREUR") : sERROR = "ERROR"
        sPathFileName = MozartParams.CheminUtilisateurMozart & "FicheHeure.rtf"
      Case "AnaChaFicF"  '"exec api_sp_ChantierImpFicheFOU " & iValeur.ToString
        Dim ret As Long = oDoc.MkRTF(MozartParams.CheminModeles & "FR\TChantierFicheFournitures.rtf", MozartParams.CheminUtilisateurMozart & "FicheFournitures.rtf", sProcNameWithParam, cnxVisu, Tdb)
        If ret <> 0 Then MsgBox("ERREUR") : sERROR = "ERROR"
        sPathFileName = MozartParams.CheminUtilisateurMozart & "FicheFournitures.rtf"
      Case "AnaChaFicS"
        sPathFileName = MozartParams.CheminUtilisateurMozart & "PDF\ChantierExport.pdf"
      Case "CorrectAttach"
        Dim ret As Long = oDoc.MkRTF(MozartParams.CheminModeles & "FR\TTabletAttach.rtf", MozartParams.CheminUtilisateurMozart & "TTabletAttachCorrectOut.rtf", sProcNameWithParam, cnxVisu, Tdb)
        If ret <> 0 Then MsgBox("ERREUR") : sERROR = "ERROR"
        sPathFileName = MozartParams.CheminUtilisateurMozart & "TTabletAttachCorrectOut.rtf"
      Case "TransfertAttachEMALECTOEMASOLAR" : sERROR = "ERROR"
        Dim ret As Long = oDoc.MkRTF(MozartParams.CheminModeles.Replace("\Emalec\", "\EMASOLAR\") & "FR\TTabletAttach.rtf", MozartParams.CheminUtilisateurMozart & "TTabletAttachTransOut.rtf", sProcNameWithParam, cnxVisu, Tdb)
        If ret <> 0 Then MsgBox("ERREUR") : sERROR = "ERROR"
        sPathFileName = MozartParams.CheminUtilisateurMozart & "TTabletAttachTransOut.rtf"
      Case "ChantierExport"
        sPathFileName = sProcNameWithParam
      Case "QCM_Fiche_Edition"
        Dim ret As Long = oDoc.MkRTF(MozartParams.CheminModeles & "FR\TQCMEdition.rtf", MozartParams.CheminUtilisateurMozart & "TQCMEditionOut.rtf", sProcNameWithParam, cnxVisu, Tdb)
        If ret <> 0 Then MsgBox("ERREUR") : sERROR = "ERROR"
        sPathFileName = MozartParams.CheminUtilisateurMozart & "TQCMEditionOut.rtf"

      Case "QCM_Fiche_Edition_Result"
        Dim OQCMDetail As New CQCMDetail(sProcNameWithParam)

        Try

          sPathFileName = MozartParams.CheminUtilisateurMozart & "TQCMEditionRepOut.xml"
          Dim monStreamReader As StreamReader = New StreamReader(MozartParams.CheminModeles & "FR\TQCMEditionRep.xml")
          'ecriture
          Dim monStreamWriter As StreamWriter = New StreamWriter(sPathFileName)
          Dim ligne As String
          Do
            ligne = monStreamReader.ReadLine()
            If Not ligne Is Nothing Then
              ligne = ligne.Replace("#TABLEAU_QCM#", OQCMDetail.sTableau_XML)
              ligne = ligne.Replace("#TITRE#", OQCMDetail.sTitreQCM)
              ligne = ligne.Replace("#AUTEUR#", OQCMDetail.sAuteur)
              ligne = ligne.Replace("#DATE#", OQCMDetail.sDateEffectue)
              monStreamWriter.WriteLine(ligne)
            End If
          Loop Until ligne Is Nothing

          'Fermeture du StreamReader (attention très important)
          monStreamReader.Close()
          monStreamWriter.Close()

        Catch ex As Exception
          MessageBox.Show(ex.Message)
          sERROR = ex.Message
          sPathFileName = ""
        End Try

      Case "QCM_Fiche_Edition_Result_Signature"

        Dim OQCMDetail As New CQCMDetail(sProcNameWithParam)

        Try

          sPathFileName = MozartParams.CheminUtilisateurMozart & "TQCMEditionSignatureOut.xml"
          Dim monStreamReader As StreamReader = New StreamReader(MozartParams.CheminModeles & "FR\TQCMEditionSignature.xml")
          'ecriture
          Dim monStreamWriter As StreamWriter = New StreamWriter(sPathFileName)
          Dim ligne As String
          Do
            ligne = monStreamReader.ReadLine()
            If Not ligne Is Nothing Then
              ligne = ligne.Replace("#TABLEAU_QCM#", OQCMDetail.sTableau_XML)
              ligne = ligne.Replace("#TITRE#", OQCMDetail.sTitreQCM)
              ligne = ligne.Replace("#AUTEUR#", OQCMDetail.sAuteur)
              ligne = ligne.Replace("#DATE#", OQCMDetail.sDateEffectue)
              ligne = ligne.Replace("#DRETCORRECTSIGNTECH#", OQCMDetail.sRetourCorrect)
              ligne = ligne.Replace("#IMGSIGNTECH.JPG#", OQCMDetail.imgIRETCORRECTSIGNTECH)
              monStreamWriter.WriteLine(ligne)
            End If
          Loop Until ligne Is Nothing

          'Fermeture du StreamReader (attention très important)
          monStreamReader.Close()
          monStreamWriter.Close()

        Catch ex As Exception
          MessageBox.Show(ex.Message)
          sERROR = ex.Message
          sPathFileName = ""
        End Try

      Case "Causerie_Fiche_Edition_Result_Signature"

        Dim OQCMDetail As New CQCMDetail(sProcNameWithParam)

        Try

          sPathFileName = MozartParams.CheminUtilisateurMozart & "TCauserieEditionSignatureOut.xml"
          Dim monStreamReader As StreamReader = New StreamReader(MozartParams.CheminModeles & "FR\TCauserieEditionSignature.xml")
          'ecriture
          Dim monStreamWriter As StreamWriter = New StreamWriter(sPathFileName)
          Dim ligne As String
          Do
            ligne = monStreamReader.ReadLine()
            If Not ligne Is Nothing Then
              ligne = ligne.Replace("#TABLEAU_QCM#", OQCMDetail.sTableau_XML)
              ligne = ligne.Replace("#TITRE#", OQCMDetail.sTitreQCM)
              ligne = ligne.Replace("#AUTEUR#", OQCMDetail.sAuteur)
              ligne = ligne.Replace("#DATE#", OQCMDetail.sDateEffectue)
              ligne = ligne.Replace("#DRETCORRECTSIGNTECH#", OQCMDetail.sRetourCorrect)
              ligne = ligne.Replace("#IMGSIGNTECH.JPG#", OQCMDetail.imgIRETCORRECTSIGNTECH)
              monStreamWriter.WriteLine(ligne)
            End If
          Loop Until ligne Is Nothing

          'Fermeture du StreamReader (attention très important)
          monStreamReader.Close()
          monStreamWriter.Close()

          'Dim oWord As Word.Application
          'Dim oDoc As Word.Document
          'oWord = CreateObject("Word.Application")
          'oWord.Visible = False
          'oDoc = oWord.Documents.Add(sPathFileName)
          'oDoc.SaveAs2(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Mozart\TCauserieEditionSignatureOut.docx")
          'sPathFileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Mozart\TCauserieEditionSignatureOut.docx"

        Catch ex As Exception
          MessageBox.Show(ex.Message)
          sERROR = ex.Message
          sPathFileName = ""
        End Try

      Case "Causerie_Fiche_Edition_Result"

        Dim OQCMDetail As New CQCMDetail(sProcNameWithParam)

        Try

          sPathFileName = MozartParams.CheminUtilisateurMozart & "TCauserieEditionOut.xml"
          Dim monStreamReader As StreamReader = New StreamReader(MozartParams.CheminModeles & "FR\TCauserieEdition.xml")
          'ecriture
          Dim monStreamWriter As StreamWriter = New StreamWriter(sPathFileName)
          Dim ligne As String
          Do
            ligne = monStreamReader.ReadLine()
            If Not ligne Is Nothing Then
              ligne = ligne.Replace("#TABLEAU_QCM#", OQCMDetail.sTableau_XML)
              ligne = ligne.Replace("#TITRE#", OQCMDetail.sTitreQCM)
              ligne = ligne.Replace("#AUTEUR#", OQCMDetail.sAuteur)
              ligne = ligne.Replace("#DATE#", OQCMDetail.sDateEffectue)
              monStreamWriter.WriteLine(ligne)
            End If
          Loop Until ligne Is Nothing

          'Fermeture du StreamReader (attention très important)
          monStreamReader.Close()
          monStreamWriter.Close()

        Catch ex As Exception
          MessageBox.Show(ex.Message)
          sERROR = ex.Message
          sPathFileName = ""
        End Try

      Case "Edition_Temps_Travail"
        Dim ret As Long = oDoc.MkRTF(MozartParams.CheminModeles & "FR\TTps_Travail_Edition_ Edition.rtf", MozartParams.CheminUtilisateurMozart & "TTps_Travail_Edition_Out.rtf", sProcNameWithParam, cnxVisu, Tdb)
        If ret <> 0 Then MsgBox("ERREUR") : sERROR = "ERROR"
        sPathFileName = MozartParams.CheminUtilisateurMozart & "TTps_Travail_Edition_Out.rtf"

      Case "Carte_Habilitation"
        Dim ret As Long = oDoc.MkRTF(MozartParams.CheminModeles & "FR\TCarteHabilitation.rtf", MozartParams.CheminUtilisateurMozart & "TCarteHabilitationOut.rtf", sProcNameWithParam, cnxVisu, Tdb)
        If ret <> 0 Then MsgBox("ERREUR") : sERROR = "ERROR"
        sPathFileName = MozartParams.CheminUtilisateurMozart & "TCarteHabilitationOut.rtf"


      Case Else
        sPathFileName = "about:blank"
    End Select

  End Sub

  Protected Overrides Sub Finalize()
    cnxVisu.Close()
  End Sub

End Class
