Imports System.Data.SqlClient
Imports MozartLib

Public Class CQCMDetail

  Dim oSqlConnect As CGestionSQL

  Dim _sTableau_XML As String = ""
  Dim _sAuteur As String = ""
  Dim _sTitreQCM As String = ""
  Dim _sDateEffectue As String = ""
  Dim _sRetourCorrect As String = ""
  Dim _imgIRETCORRECTSIGNTECH As String = ""
  Dim _sDFICQCMVISACORRECT As String = ""
  ReadOnly Property sTableau_XML As String
    Get
      Return _sTableau_XML
    End Get
  End Property

  ReadOnly Property sAuteur As String
    Get
      Return _sAuteur
    End Get
  End Property

  ReadOnly Property sTitreQCM As String
    Get
      Return _sTitreQCM
    End Get
  End Property

  ReadOnly Property sDateEffectue As String
    Get
      Return _sDateEffectue
    End Get
  End Property

  ReadOnly Property sRetourCorrect As String
    Get
      Return _sRetourCorrect
    End Get
  End Property

  ReadOnly Property imgIRETCORRECTSIGNTECH As String
    Get
      Return _imgIRETCORRECTSIGNTECH
    End Get
  End Property

  ReadOnly Property sDFICQCMVISACORRECT As String
    Get
      Return _sDFICQCMVISACORRECT
    End Get
  End Property

  Public Sub New(ByVal c_iNIDIFCQCM As Int32)

    Try

      oSqlConnect = New CGestionSQL

      Dim sFileImgSignature As String = Path.GetTempFileName
      If File.Exists(sFileImgSignature) Then File.Delete(sFileImgSignature)

      oSqlConnect.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete)

      Dim sqlcmd As New SqlCommand("api_sp_Imp_Causerie_QCM_RepGEN", oSqlConnect.CnxSQLOpen)
      sqlcmd.CommandType = CommandType.StoredProcedure
      sqlcmd.Parameters.Add("@p_NIDFICQCM", SqlDbType.Int)
      sqlcmd.Parameters("@p_NIDFICQCM").Value = c_iNIDIFCQCM
      sqlcmd.Parameters.Add("@P_PATHSIGN", SqlDbType.VarChar)
      sqlcmd.Parameters("@P_PATHSIGN").Value = sFileImgSignature

      Dim DRTab As SqlDataReader = sqlcmd.ExecuteReader
      DRTab.Read()
      _sAuteur = DRTab.Item("VAUTEUR").ToString
      _sTitreQCM = DRTab.Item("VQCMTITRE").ToString
      _sDateEffectue = DRTab.Item("DATETERM").ToString
      _sTableau_XML = DRTab.Item("TABLE_XML").ToString
      _sRetourCorrect = DRTab.Item("DRETCORRECTSIGNTECH").ToString
      'generation de la signature = 'GenererSignature'
      'Dim b As Byte() = DRTab.Item("IRETCORRECTSIGNTECH")
      'Dim encode As Encoding = Encoding.UTF8
      If Not DRTab.Item("IRETCORRECTSIGNTECH") Is DBNull.Value Then
        _imgIRETCORRECTSIGNTECH = GenererSignature(DRTab.Item("IRETCORRECTSIGNTECH"), sFileImgSignature)
      Else
        _imgIRETCORRECTSIGNTECH = ""
      End If

      DRTab.Close()
      oSqlConnect.CloseConnexionSQL()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Function GenererSignature(ByVal p_signaturebyte As Byte(), ByVal p_sfilename As String) As String

    Try

      If File.Exists(p_sfilename) Then File.Delete(p_sfilename)

      Dim tab1() As Byte = p_signaturebyte
      Dim fs As New FileStream(p_sfilename, FileMode.Create, FileAccess.Write, FileShare.Write)
      fs.Write(tab1, 0, tab1.Length)
      fs.Flush()
      fs.Close()

      Return p_sfilename

    Catch ex As Exception
      MessageBox.Show("Erreur dans GenererImage dans CQCMDetail : " & ex.Message)
      Return ""
    End Try

  End Function

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub
End Class