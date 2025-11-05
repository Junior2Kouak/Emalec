Imports System.Data.SqlClient
Imports MozartLib

Public Class CGenerateVisuDoc

  Public Function QueryForImpAttachementCorrect(ByVal oDataRowAttach As DataRow, ByVal sNomProc As String) As String

    Dim ProcStockStruct As New SqlCommand(sNomProc + " @VATTACHCHAP1, @VATTACHCHAP2, @VATTACHCHAP3, @VATTACHCHAP4, @VATTACHCHAP5, " _
                                                                    & "@VATTACHCHAP6, @NATTACHSATISF, @VCONTACTCLI, @VPERNOM, @VATTACHHR, @VATTACHDEPL, " _
                                                                    & "@IMGSIGNCLI, @IMGSIGNTECH, @VPREPA, @NACTNUM, @VACTDES")

    ProcStockStruct.CommandType = CommandType.StoredProcedure
    ProcStockStruct.Parameters.Add("@VATTACHCHAP1", SqlDbType.VarChar).Value = oDataRowAttach.Item("VATTACHCHAP1").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@VATTACHCHAP2", SqlDbType.VarChar).Value = oDataRowAttach.Item("VATTACHCHAP2").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@VATTACHCHAP3", SqlDbType.VarChar).Value = oDataRowAttach.Item("VATTACHCHAP3").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@VATTACHCHAP4", SqlDbType.VarChar).Value = oDataRowAttach.Item("VATTACHCHAP4").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@VATTACHCHAP5", SqlDbType.VarChar).Value = oDataRowAttach.Item("VATTACHCHAP5").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@VATTACHCHAP6", SqlDbType.VarChar).Value = oDataRowAttach.Item("VATTACHCHAP6").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@NATTACHSATISF", SqlDbType.Int).Value = oDataRowAttach.Item("NATTACHSATISF")
    ProcStockStruct.Parameters.Add("@VCONTACTCLI", SqlDbType.VarChar).Value = oDataRowAttach.Item("VCONTACTCLI").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@VPERNOM", SqlDbType.VarChar).Value = oDataRowAttach.Item("VPERNOM").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@VATTACHHR", SqlDbType.VarChar).Value = oDataRowAttach.Item("VATTACHHR").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@VATTACHDEPL", SqlDbType.VarChar).Value = oDataRowAttach.Item("VATTACHDEPL").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@IMGSIGNCLI", SqlDbType.VarChar).Value = CreateSignForVisu(oDataRowAttach.Item("IATTACHCLI"), 250, 100, "CLI").ToString
    ProcStockStruct.Parameters.Add("@IMGSIGNTECH", SqlDbType.VarChar).Value = CreateSignForVisu(oDataRowAttach.Item("IATTACHTECH"), 200, 70, "TECH").ToString
    ProcStockStruct.Parameters.Add("@VPREPA", SqlDbType.VarChar).Value = oDataRowAttach.Item("VATTACHHRPREPA").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@NACTNUM", SqlDbType.Int).Value = oDataRowAttach.Item("NACTNUM")
    ProcStockStruct.Parameters.Add("@VACTDES", SqlDbType.VarChar).Value = oDataRowAttach.Item("VACTDES").ToString.Replace("'", "''")

    Dim QueryProc As String = ProcStockStruct.CommandText

    For Each prm As SqlParameter In ProcStockStruct.Parameters

      Select Case prm.SqlDbType
        Case SqlDbType.DateTime, SqlDbType.Char, SqlDbType.VarChar, SqlDbType.NVarChar, SqlDbType.NText
          QueryProc = QueryProc.Replace(prm.ParameterName, "'" & prm.Value & "'")
        Case Else
          QueryProc = QueryProc.Replace(prm.ParameterName, prm.Value)
      End Select
    Next

    Return QueryProc

  End Function
  '*******************************************************************************************************************************
  'Expression régulieres permettant de rechercher exactement un mot entier et non pas un epxression commanceant pas ... pb avec els 2 champs  @VATTACHHR et @VATTACHHRPREPA
  '*******************************************************************************************************************************
  Private Function ReplaceRegex(ByVal sChaine As String, ByVal sOldExpression As String, ByVal sNewExpression As String) As String

    Dim myRegex As New Regex(sOldExpression + "\b")

    Return myRegex.Replace(sChaine, sNewExpression)

  End Function

  '*******************************************************************************************
  'Permet de creer une image temporaire pour la visu de la signature
  '*******************************************************************************************
  Private Function CreateSignForVisu(ByVal oImgSignature As Object, ByVal iImgWidth As Integer, ByVal iImgHeight As Integer, ByVal vtype As String) As String

    Try

      Dim strnomfic As String
      Dim strnomficOK As String
      Dim sPathTempSign As String = MozartParams.CheminUtilisateurMozart & "PDF\"

      'on test si le dossier temp existe
      If Directory.Exists(sPathTempSign) = False Then Directory.CreateDirectory(sPathTempSign)

      Select Case vtype
        Case "CLI"
          strnomfic = sPathTempSign + "signCliTemp"
          strnomficOK = sPathTempSign + "signCli"
        Case Else
          strnomfic = sPathTempSign + "signTechTemp"
          strnomficOK = sPathTempSign + "signTech"
      End Select

      Dim tab1() As Byte = oImgSignature
      Dim fs As New FileStream(strnomfic, FileMode.Create, FileAccess.Write, FileShare.Write)
      fs.Write(tab1, 0, tab1.Length)
      fs.Flush()
      fs.Close()

      Dim myBitmap As New Bitmap(strnomfic)
      Dim myBitmap2 As New Bitmap(myBitmap, New Size(iImgWidth, iImgHeight))
      myBitmap2.Save(strnomficOK, ImageFormat.Jpeg)

      Return strnomficOK

    Catch ex As Exception

      MessageBox.Show("Erreur dans - CreateSignForVisu : " + ex.Message)
      Return ""

    End Try

  End Function

End Class
