Imports System.Data.SqlClient
Imports System.Reflection.MethodBase
Imports MozartLib

Public Class CGenAttachement

  Dim _dtListeAttachement As DataTable
  Dim cnxNetAttach As SqlConnection

  Dim _oGenDoc As CGenDocument

  Dim _PathDestFileOut As String
  Dim _sFileImgSignatureTechIn As String
  Dim _sFileImgSignatureTechOut As String
  Dim _sFileImgSignatureCliIn As String
  Dim _sFileImgSignatureCliOut As String

  Dim FileIn As String
  Dim sFileOut As String
  Dim sFileOutPDF As String
  Dim sReqSQL As String

  Dim _GenAttachementOK As Boolean
  Dim _bError As Boolean

  Public ReadOnly Property dtListeAttachement As DataTable
    Get
      Return _dtListeAttachement
    End Get
  End Property

  Public ReadOnly Property Attachement_File_PDF As String
    Get
      Return sFileOutPDF
    End Get
  End Property

  Public ReadOnly Property GenAttachementOK As Boolean
    Get
      Return _GenAttachementOK
    End Get
  End Property

  Public Property bError As Boolean
    Get
      Return _bError
    End Get
    Set(value As Boolean)
      _bError = value
    End Set
  End Property

  Public Sub New(ByVal c_cnxNet As SqlConnection, ByVal c_PathDestFileOut As String)

    'init
    cnxNetAttach = c_cnxNet
    _PathDestFileOut = c_PathDestFileOut
    _oGenDoc = New CGenDocument(c_cnxNet, MozartParams.NomServeur, "MULTI")
    _GenAttachementOK = False
    _bError = False

  End Sub

  Public Sub LoadDataTableAttach(ByVal P_NACTNUM As Int32)

    _dtListeAttachement = New DataTable

    Try

      Dim sqlcmdloader As New SqlCommand("[api_sp_GetInfoForGenerateAttachCorrect]", cnxNetAttach)
      sqlcmdloader.CommandType = CommandType.StoredProcedure
      sqlcmdloader.Parameters.Add("@P_NACTNUM", SqlDbType.Int).Value = P_NACTNUM
      _dtListeAttachement.Load(sqlcmdloader.ExecuteReader)

    Catch ex As Exception

      _bError = True
    End Try

  End Sub

  Public Sub GenerateAttachementModified(ByVal p_datarow As DataRow, ByVal P_NACTNUM As Int32, ByVal P_VSOCIETE As String, ByVal P_VCLIPAYS As String, ByVal P_VFILEPDFOUT As String)

    'init
    FileIn = ""
    sFileOut = ""
    sFileOutPDF = ""
    sReqSQL = ""
    _GenAttachementOK = False

    'variable de log de retour des functions utilisées 
    Dim sLogGenDoc As String = ""

    'fichier modele, fichier sortie et requete sql
    FileIn = String.Format("{0}TTabletAttach.rtf", _oGenDoc.LoadPathModeles(P_VSOCIETE, P_VCLIPAYS))
    sFileOut = String.Format("{0}AttachOut.rtf", _PathDestFileOut)

    'gestion du fihciher de sortie en pdf -> REP_ATTGAM
    Dim lPathDestDoc As String = RechercheParam("REP_ATTGAM", P_VSOCIETE)
    sFileOutPDF = String.Format("{0}{1}", lPathDestDoc, P_VFILEPDFOUT)

    'requete sql d impression
    Dim oVisuDocTemp As New CGenerateVisuDoc
    sReqSQL = oVisuDocTemp.QueryForImpAttachementCorrect(p_datarow, "api_sp_TabletimpAttachementCorrection")

    'on test si le modele existe    sele
    Try
      If File.Exists(FileIn) = False Then
        MessageBox.Show(String.Format("Le modèle n'existe pas {0}", FileIn))
        _bError = True
        Exit Sub
      End If
    Catch ex As Exception
      MessageBox.Show(String.Format("ERREUR : Le modèle n'existe pas {0}" & vbCrLf & "Description Class {1} - procedure {2} - Erreur : {3}", FileIn, Me.GetType.Name, GetCurrentMethod().Name, ex.Message))
      _bError = True
      Exit Sub
    End Try

    ' on teste si fichier de sortie existe rtf
    Try

      If File.Exists(sFileOut) = True Then
        File.Delete(sFileOut)
      End If

    Catch ex As Exception
      MessageBox.Show(String.Format("ERREUR : Suppression du fichier de sortie {0}" & vbCrLf & "Description Class {1} - procedure {2} - NACTNUM : {3} - Erreur : {4}", sFileOut, Me.GetType.Name, GetCurrentMethod().Name, P_NACTNUM, ex.Message))
      _bError = True
      Exit Sub
    End Try

    ' on teste si fichier de sortie existe pdf
    Try

      If File.Exists(sFileOutPDF) = True Then
        File.Delete(sFileOutPDF)
      End If

    Catch ex As Exception
      MessageBox.Show(String.Format("ERREUR : Suppression du fichier PDF de sortie {0}" & vbCrLf & "Description Class {1} - procedure {2} - NACTNUM : {3} - Erreur : {4}", sFileOutPDF, Me.GetType.Name, GetCurrentMethod().Name, P_NACTNUM, ex.Message))
      _bError = True
      Exit Sub
    End Try

    sLogGenDoc = _oGenDoc.GenererRTF(FileIn, sFileOut, sReqSQL)
    If sLogGenDoc <> "" Then MessageBox.Show(sLogGenDoc) : _bError = True : Exit Sub

    'a noter, le save PDF ce fait directement sur le dossier ATTGAM
    sLogGenDoc = _oGenDoc.SaveAsPDF(sFileOut, sFileOutPDF)
    If sLogGenDoc <> "" Then MessageBox.Show(sLogGenDoc) : _bError = True : Exit Sub

    _oGenDoc.CloseCnxADODB()

    'clear des signature et du fichie doc
    ClearAllFilesAttachement()

    'messgae de creation OK
    MessageBox.Show("Attachement créé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)

    _GenAttachementOK = True

  End Sub

  Public Sub ClearAllFilesAttachement()

    Try

      If File.Exists(sFileOut) = True Then File.Delete(sFileOut)

      If File.Exists(_sFileImgSignatureTechIn) = True Then File.Delete(_sFileImgSignatureTechIn)
      If File.Exists(_sFileImgSignatureTechOut) = True Then File.Delete(_sFileImgSignatureTechOut)
      If File.Exists(_sFileImgSignatureCliIn) = True Then File.Delete(_sFileImgSignatureCliIn)
      If File.Exists(_sFileImgSignatureCliOut) = True Then File.Delete(_sFileImgSignatureCliOut)

      FileIn = ""
      sFileOut = ""
      sFileOutPDF = ""
      sReqSQL = ""

    Catch ex As Exception

      MessageBox.Show(String.Format("ERREUR : Nettoyage des fichiers attachement." & vbCrLf & "Description Class {0} - procedure {1} - Erreur : {2}", Me.GetType.Name, GetCurrentMethod().Name, ex.Message))
      _bError = True

    End Try

  End Sub

  Private Function GenerateSignatures(ByVal p_NACTNUM As Int32) As String

    Dim sFileImg_Del As String = ""
    Dim sRetLogGenImage As String = ""

    Try
      'test si fichier image signature existe
      sFileImg_Del = _sFileImgSignatureTechIn
      If File.Exists(sFileImg_Del) Then File.Delete(sFileImg_Del)
      sFileImg_Del = _sFileImgSignatureTechOut
      If File.Exists(sFileImg_Del) Then File.Delete(sFileImg_Del)
      sFileImg_Del = _sFileImgSignatureCliIn
      If File.Exists(sFileImg_Del) Then File.Delete(sFileImg_Del)
      sFileImg_Del = _sFileImgSignatureCliOut
      If File.Exists(sFileImg_Del) Then File.Delete(sFileImg_Del)
    Catch ex As Exception
      _bError = True
      Return (String.Format("ERREUR : Suppression du fichier de sortie {0}" & vbCrLf & "Description Class {1} - procedure {2} - Erreur : {3}", sFileImg_Del, Me.GetType.Name, GetCurrentMethod().Name, ex.Message))
      Exit Function
    End Try

    Try

      Dim sqlcmdImgSign As New SqlCommand(String.Format("SELECT IATTACHTECH AS ITECH, IATTACHCLI AS ICLI FROM TSYNCHROATTACH WITH (NOLOCK) WHERE NACTNUM = {0}", p_NACTNUM), cnxNetAttach)
      sqlcmdImgSign.CommandType = CommandType.Text
      Dim drImg As SqlDataReader = sqlcmdImgSign.ExecuteReader

      If drImg.HasRows Then

        drImg.Read()

        sRetLogGenImage = _oGenDoc.GenererImage(drImg("ITECH"), New Size(200, 70), _sFileImgSignatureTechIn, _sFileImgSignatureTechOut)

        'si ok, on continue
        If sRetLogGenImage = "" Then
          sRetLogGenImage = _oGenDoc.GenererImage(drImg("ICLI"), New Size(250, 100), _sFileImgSignatureCliIn, _sFileImgSignatureCliOut)
        End If
      Else
        MessageBox.Show(String.Format("Pas de signature : {0}", _sFileImgSignatureCliOut))
      End If

      drImg.Close()

      'si retour = "" alors ok
      Return sRetLogGenImage

    Catch ex As Exception

      _bError = True
      Return (String.Format("ERREUR : Generation signature {0}" & vbCrLf & "Description Class {1} - procedure {2} - Erreur : {3}", sRetLogGenImage, Me.GetType.Name, GetCurrentMethod().Name, ex.Message))
      Exit Function

    End Try

  End Function

  Private Function AjoutDocAction(ByVal p_NACTNUM As Int32, ByVal p_sFileOutPDF As String) As String

    Try

      Dim sqlcmdDoc As New SqlCommand("api_sp_EnregImgAct", cnxNetAttach)
      sqlcmdDoc.CommandType = CommandType.StoredProcedure
      sqlcmdDoc.Parameters.Add("@iNIMAGE", SqlDbType.Int).Value = 0
      sqlcmdDoc.Parameters.Add("@iNACTNUM", SqlDbType.Int).Value = p_NACTNUM
      sqlcmdDoc.Parameters.Add("@vVIMAGE", SqlDbType.NVarChar).Value = "Attachement"
      sqlcmdDoc.Parameters.Add("@vVFICHIER", SqlDbType.NVarChar).Value = Path.GetFileName(p_sFileOutPDF)
      sqlcmdDoc.Parameters.Add("@cCFORMAT", SqlDbType.VarChar).Value = "PDF"
      sqlcmdDoc.Parameters.Add("@vVCOMMENT", SqlDbType.NVarChar).Value = ""
      sqlcmdDoc.Parameters.Add("@vVTYPE", SqlDbType.VarChar).Value = "ATTACH"
      sqlcmdDoc.Parameters.Add("@vWEB", SqlDbType.Char).Value = "N"
      sqlcmdDoc.Parameters.Add("@vTypeDest", SqlDbType.Char).Value = "I"
      sqlcmdDoc.Parameters.Add("@nTypeDoc", SqlDbType.Int).Value = 29

      sqlcmdDoc.ExecuteNonQuery()

      Return ""

    Catch ex As Exception

      _bError = True
      Return String.Format("ERREUR : Description Class {0} - procedure {1} - NACTNUM : {2} - Erreur : {3}", Me.GetType.Name, GetCurrentMethod().Name, p_NACTNUM, ex.Message)

    End Try

  End Function

  '*********************************************************************************************************
  'Cette fonction archive les attachement dont l'action a été supprimé dans MOZART
  '*********************************************************************************************************
  Public Function Attachement_Archivage_ActionDeleted() As String

    Try

      Dim sqlcmdDelTampon As New SqlCommand("[api_sp_GenDocTablet_AttachementClearTableTampon_ActDeleted]", cnxNetAttach)
      sqlcmdDelTampon.CommandType = CommandType.StoredProcedure
      sqlcmdDelTampon.ExecuteNonQuery()

      Return ""

    Catch ex As Exception

      _bError = True
      Return String.Format("ERREUR : Description Class {0} - procedure {1} - Erreur : {2}", Me.GetType.Name, GetCurrentMethod().Name, ex.Message)

    End Try

  End Function

End Class
