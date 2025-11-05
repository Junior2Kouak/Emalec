Imports System.Data.SqlClient
Imports MozartLib

Module ModMessWeb

  Public Function Authorized(ByVal sTypeMessWeb As String) As Boolean

    Dim bRetour As Boolean = False

    Try

      Dim sqlcmd As New SqlCommand("api_sp_VerifDroitMessageWebWPF", MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.Add("@p_sTypeMessWeb", SqlDbType.Char)
            sqlcmd.Parameters("@p_sTypeMessWeb").Value = sTypeMessWeb

            Dim dr As SqlDataReader = sqlcmd.ExecuteReader

            If dr.HasRows Then

                dr.Read()
                If dr.Item("NBLINE") > 0 Then
                    bRetour = True
                End If

            End If

            dr.Close()

            Return bRetour

        Catch ex As Exception

            MessageBox.Show("Erreur dans la function Authorized : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return bRetour

        End Try

    End Function

End Module
