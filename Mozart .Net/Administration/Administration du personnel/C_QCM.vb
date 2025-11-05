Imports System.Data.SqlClient
Imports MozartLib

Public Class C_QCM

  Dim dtListQCM As DataTable
  Dim dtListPersByPer As DataTable

  ReadOnly Property p_dtListPersByPer As DataTable
    Get
      Return dtListPersByPer
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

      MessageBox.Show("C_QCM dans ListeQCM : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Public Function ListePersByQCM(ByVal p_IDQCMNUM As Int32) As DataTable

    Try

      dtListPersByPer = New DataTable

      Dim sqlcmdLstPerbyQCM As New SqlCommand("api_sp_ListePersonnelQCM", MozartDatabase.cnxMozart)
      sqlcmdLstPerbyQCM.CommandType = CommandType.StoredProcedure

      sqlcmdLstPerbyQCM.Parameters.Add("@P_NIDQCMNUM", SqlDbType.Int)
      sqlcmdLstPerbyQCM.Parameters("@P_NIDQCMNUM").Value = p_IDQCMNUM

      dtListPersByPer.Load(sqlcmdLstPerbyQCM.ExecuteReader)

      dtListPersByPer.Columns("CHECK").ReadOnly = False

      Return dtListPersByPer

    Catch ex As Exception

      MessageBox.Show("C_QCM dans ListeQCM : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Public Function QCMEnCours(ByVal P_NPERNUM As Int32, ByVal p_NIDQCMNUM As Int32) As Boolean

    Try

      Dim bReturn As Boolean = False

      Dim sqlcmdVerif As New SqlCommand("api_sp_QCMVerifEncours", MozartDatabase.cnxMozart)
      sqlcmdVerif.CommandType = CommandType.StoredProcedure

      sqlcmdVerif.Parameters.Add("@P_NPERNUM", SqlDbType.Int)
      sqlcmdVerif.Parameters("@P_NPERNUM").Value = P_NPERNUM

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

      MessageBox.Show("C_QCM dans QCMEnCours : " + ex.Message)
      Return False

    End Try

  End Function

  Public Sub SaveListPersByQCM(ByVal p_IDQCMNUM As Int32)

    Try

      If Not dtListPersByPer Is Nothing AndAlso Not dtListPersByPer.GetChanges(DataRowState.Modified) Is Nothing Then

        For Each oDtrSave As DataRow In dtListPersByPer.GetChanges(DataRowState.Modified).Rows

          Dim dtQCMInit As DataTable = ListePersByQCM(p_IDQCMNUM)


          If oDtrSave.Item("CHECK") = 1 And oDtrSave.Item("CHECK") <> dtQCMInit.Select(String.Format("NPERNUM = {0}", oDtrSave.Item("NPERNUM")))(0).Item("CHECK") Then

            AffecterQCM(oDtrSave.Item("NPERNUM"), p_IDQCMNUM)

          ElseIf oDtrSave.Item("CHECK") = 0 And oDtrSave.Item("CHECK") <> dtQCMInit.Select(String.Format("NPERNUM = {0}", oDtrSave.Item("NPERNUM")))(0).Item("CHECK") Then

            NotAffecterQCM(oDtrSave.Item("NPERNUM"), p_IDQCMNUM)

          End If

        Next

      End If

    Catch ex As Exception

      MessageBox.Show("C_QCM dans SaveListPersByQCM : " + ex.Message)

    End Try

  End Sub

  Private Sub AffecterQCM(ByVal P_NPERNUM As Int32, ByVal P_NIDQCMNUM As Int32)

    Try

      Dim sqlcmdAffectQCM As New SqlCommand("api_sp_QCMAffectPers", MozartDatabase.cnxMozart)
      sqlcmdAffectQCM.CommandType = CommandType.StoredProcedure

      sqlcmdAffectQCM.Parameters.Add("@P_NPERNUM", SqlDbType.Int)
      sqlcmdAffectQCM.Parameters("@P_NPERNUM").Value = P_NPERNUM

      sqlcmdAffectQCM.Parameters.Add("@P_NIDQCMNUM", SqlDbType.Int)
      sqlcmdAffectQCM.Parameters("@P_NIDQCMNUM").Value = P_NIDQCMNUM

      sqlcmdAffectQCM.ExecuteNonQuery()

    Catch ex As Exception

      MessageBox.Show("C_QCM dans AffecterQCM : " + ex.Message)

    End Try

  End Sub

  Private Sub NotAffecterQCM(ByVal P_NPERNUM As Int32, ByVal P_NIDQCMNUM As Int32)

    Try

      Dim sqlcmdAffectQCM As New SqlCommand("api_sp_QCMRefreshPers", MozartDatabase.cnxMozart)
      sqlcmdAffectQCM.CommandType = CommandType.StoredProcedure

      sqlcmdAffectQCM.Parameters.Add("@P_NPERNUM", SqlDbType.Int)
      sqlcmdAffectQCM.Parameters("@P_NPERNUM").Value = P_NPERNUM

      sqlcmdAffectQCM.Parameters.Add("@P_NIDQCMNUM", SqlDbType.Int)
      sqlcmdAffectQCM.Parameters("@P_NIDQCMNUM").Value = P_NIDQCMNUM

      sqlcmdAffectQCM.ExecuteNonQuery()

    Catch ex As Exception

      MessageBox.Show("C_QCM dans NotAffecterQCM : " + ex.Message)

    End Try

  End Sub

End Class
