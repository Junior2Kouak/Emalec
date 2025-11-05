Imports System.Data.SqlClient
Imports MozartLib

Public Class CExtActCR

  Dim iNACTNUM As Int32
  Dim sReadOnly As String

  Dim oDataRowEXTACTCR As DataRow

  Public Sub New(p_iNACTNUM As Int32)

    iNACTNUM = p_iNACTNUM

    oDataRowEXTACTCR = LoadDataRowEXTACTCR()

  End Sub

  Property p_oDataRowEXTACTCR As DataRow
    Get
      Return oDataRowEXTACTCR
    End Get
    Set(ByVal value As DataRow)
      oDataRowEXTACTCR = value
    End Set
  End Property

  Public Sub Refresh()

    oDataRowEXTACTCR = LoadDataRowEXTACTCR()

  End Sub

  Private Function LoadDataRowEXTACTCR() As DataRow

    Try

      Dim drExtACTCR As New DataTable

      Dim sqlcmdEXTACTCR As New SqlCommand("[api_sp_CorrectionCRVP_ExtActCRInfo]", MozartDatabase.cnxMozart)
      sqlcmdEXTACTCR.CommandType = CommandType.StoredProcedure
      sqlcmdEXTACTCR.Parameters.Add("@p_NACTNUM", SqlDbType.Int)
      sqlcmdEXTACTCR.Parameters("@p_NACTNUM").Value = iNACTNUM
      drExtACTCR.Load(sqlcmdEXTACTCR.ExecuteReader)

      If drExtACTCR.Rows.Count > 0 Then
        Return drExtACTCR.Rows(0)
      Else
        Dim ODAtaRowTemp As DataRow = drExtACTCR.NewRow
        'ODAtaRowTemp.Item("NACTNUM") = iNACTNUM
        'ODAtaRowTemp.Item("VEXTACTNOMSIGNTECH") = gstrNomLogin + " " + sPersTechPrenom
        'ODAtaRowTemp.Item("NEXTACT_TYPE_FIN_INTER") = 0
        'ODAtaRowTemp.Item("NEXTACT_NIDPROCESS") = 0
        'ODAtaRowTemp.Item("NEXTACT_NIDCAUSERACINE") = 0
        Return ODAtaRowTemp
      End If

    Catch ex As Exception
      MessageBox.Show("CExtActCR - LoadDataRowEXTACTCR : " + ex.Message)
      Return Nothing
    End Try

  End Function

  Public Sub SaveInfoEXTACTCR(ByVal p_VEXTACTCR As String, ByVal p_VEXTACTOBS As String)

    Try

      Dim sqlcmdEXTACTCR As New SqlCommand("[api_sp_CorrectionCRVP_ExtActCreate]", MozartDatabase.cnxMozart)

      sqlcmdEXTACTCR.CommandType = CommandType.StoredProcedure
      sqlcmdEXTACTCR.Parameters.Add("@p_NEXTACTID", SqlDbType.Int)
      sqlcmdEXTACTCR.Parameters("@p_NEXTACTID").Value = oDataRowEXTACTCR.Item("NEXTACTID")

      sqlcmdEXTACTCR.Parameters.Add("@p_NACTNUM", SqlDbType.Int)
      sqlcmdEXTACTCR.Parameters("@p_NACTNUM").Value = oDataRowEXTACTCR.Item("NACTNUM")

      sqlcmdEXTACTCR.Parameters.Add("@p_VEXTACTCR", SqlDbType.VarChar)
      sqlcmdEXTACTCR.Parameters("@p_VEXTACTCR").Value = p_VEXTACTCR

      sqlcmdEXTACTCR.Parameters.Add("@p_VEXTACTOBS", SqlDbType.VarChar)
      sqlcmdEXTACTCR.Parameters("@p_VEXTACTOBS").Value = p_VEXTACTOBS

      sqlcmdEXTACTCR.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show("CExtActEvent - LoadDataRowEXTACTEVENT : " + ex.Message)
    End Try

  End Sub


End Class
