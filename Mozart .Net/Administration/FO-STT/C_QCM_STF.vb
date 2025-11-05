Imports System.Data.SqlClient
Imports MozartLib

Public Class C_QCM_STF

  Dim dtListQCM As DataTable
  Dim dtListSTFBySTF As DataTable

  ReadOnly Property p_dtListSTFBySTF As DataTable
    Get
      Return dtListSTFBySTF
    End Get
  End Property

  Public Function ListeQCM() As DataTable

    Try

      dtListQCM = New DataTable

      Dim sqlcmdLstQCM As New SqlCommand("SELECT NIDQCMNUM, VQCMTITRE, DQCMCREE, VQCMTYPELIB, NQCMTYPEID FROM api_v_ListeQCMActif", MozartDatabase.cnxMozart)
      sqlcmdLstQCM.CommandType = CommandType.Text

      dtListQCM.Load(sqlcmdLstQCM.ExecuteReader)

      Return dtListQCM

    Catch ex As Exception

      MessageBox.Show("C_QCM_STF dans ListeQCM : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Public Function ListeSTFByQCM(ByVal p_IDQCMNUM As Int32) As DataTable

    Try

      dtListSTFBySTF = New DataTable

      Dim sqlcmdLstPerbyQCM As New SqlCommand("api_sp_ListeSTFQCM", MozartDatabase.cnxMozart)
      sqlcmdLstPerbyQCM.CommandType = CommandType.StoredProcedure

      sqlcmdLstPerbyQCM.Parameters.Add("@P_NIDQCMNUM", SqlDbType.Int)
      sqlcmdLstPerbyQCM.Parameters("@P_NIDQCMNUM").Value = p_IDQCMNUM

      dtListSTFBySTF.Load(sqlcmdLstPerbyQCM.ExecuteReader)

      dtListSTFBySTF.Columns("CHECK").ReadOnly = False

      Return dtListSTFBySTF

    Catch ex As Exception

      MessageBox.Show("C_QCM_STF dans ListeSTFByQCM : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Public Function QCMEnCours(ByVal P_NACCNUM As Int32, ByVal p_NIDQCMNUM As Int32) As Boolean

    Try

      Dim bReturn As Boolean = False

      Dim sqlcmdVerif As New SqlCommand("[api_sp_QCMVerifEncoursSTF]", MozartDatabase.cnxMozart)
      sqlcmdVerif.CommandType = CommandType.StoredProcedure

      sqlcmdVerif.Parameters.Add("@P_NACCNUM", SqlDbType.Int)
      sqlcmdVerif.Parameters("@P_NACCNUM").Value = P_NACCNUM

      sqlcmdVerif.Parameters.Add("@P_NIDQCMNUM", SqlDbType.Int)
      sqlcmdVerif.Parameters("@P_NIDQCMNUM").Value = p_NIDQCMNUM

      Dim DRVerif As SqlDataReader = sqlcmdVerif.ExecuteReader

      If DRVerif.HasRows Then

        DRVerif.Read()

        If DRVerif.Item("NB") > 0 Then

          bReturn = True

        End If

      End If
      DRVerif.Close()

      Return bReturn

    Catch ex As Exception

      MessageBox.Show("C_QCM_STF dans QCMEnCours : " + ex.Message)
      Return False

    End Try

  End Function

  Public Sub SaveListSTFByQCM(ByVal p_IDQCMNUM As Int32)

    Try

      If Not dtListSTFBySTF Is Nothing AndAlso Not dtListSTFBySTF.GetChanges(DataRowState.Modified) Is Nothing Then

        For Each oDtrSave As DataRow In dtListSTFBySTF.GetChanges(DataRowState.Modified).Rows

          Dim dtQCMInit As DataTable = ListeSTFByQCM(p_IDQCMNUM)


          If oDtrSave.Item("CHECK") = 1 And oDtrSave.Item("CHECK") <> dtQCMInit.Select(String.Format("NACCNUM = {0}", oDtrSave.Item("NACCNUM")))(0).Item("CHECK") Then

            AffecterQCM(oDtrSave.Item("NACCNUM"), p_IDQCMNUM)

          ElseIf oDtrSave.Item("CHECK") = 0 And oDtrSave.Item("CHECK") <> dtQCMInit.Select(String.Format("NACCNUM = {0}", oDtrSave.Item("NACCNUM")))(0).Item("CHECK") Then

            NotAffecterQCM(oDtrSave.Item("NACCNUM"), p_IDQCMNUM)

          End If

        Next

      End If

    Catch ex As Exception

      MessageBox.Show("C_QCM_STF dans SaveListSTFByQCM : " + ex.Message)

    End Try

  End Sub

  Private Sub AffecterQCM(ByVal P_NACCNUM As Int32, ByVal P_NIDQCMNUM As Int32)

    Try

      Dim sqlcmdAffectQCM As New SqlCommand("api_sp_QCMAffectSTF", MozartDatabase.cnxMozart)
      sqlcmdAffectQCM.CommandType = CommandType.StoredProcedure

      sqlcmdAffectQCM.Parameters.Add("@P_NACCNUM", SqlDbType.Int)
      sqlcmdAffectQCM.Parameters("@P_NACCNUM").Value = P_NACCNUM

      sqlcmdAffectQCM.Parameters.Add("@P_NIDQCMNUM", SqlDbType.Int)
      sqlcmdAffectQCM.Parameters("@P_NIDQCMNUM").Value = P_NIDQCMNUM

      sqlcmdAffectQCM.ExecuteNonQuery()

    Catch ex As Exception

      MessageBox.Show("C_QCM_STF dans AffecterQCM : " + ex.Message)

    End Try

  End Sub

  Private Sub NotAffecterQCM(ByVal P_NACCNUM As Int32, ByVal P_NIDQCMNUM As Int32)

    Try

      Dim sqlcmdAffectQCM As New SqlCommand("[api_sp_QCMRefreshSTF]", MozartDatabase.cnxMozart)
      sqlcmdAffectQCM.CommandType = CommandType.StoredProcedure

      sqlcmdAffectQCM.Parameters.Add("@P_NACCNUM", SqlDbType.Int)
      sqlcmdAffectQCM.Parameters("@P_NACCNUM").Value = P_NACCNUM

      sqlcmdAffectQCM.Parameters.Add("@P_NIDQCMNUM", SqlDbType.Int)
      sqlcmdAffectQCM.Parameters("@P_NIDQCMNUM").Value = P_NIDQCMNUM

      sqlcmdAffectQCM.ExecuteNonQuery()

    Catch ex As Exception

      MessageBox.Show("C_QCM_STF dans NotAffecterQCM : " + ex.Message)

    End Try

  End Sub

End Class
