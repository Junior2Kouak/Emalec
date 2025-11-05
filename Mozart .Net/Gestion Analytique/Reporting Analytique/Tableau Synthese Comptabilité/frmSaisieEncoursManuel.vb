Imports System.Data.SqlClient
Imports MozartLib

Public Class frmSaisieEncoursManuel

  Dim oGestConnectSQL As New CGestionSQL

  Dim dtEncours As DataTable

  Private Sub frmSaisieEncoursManuel_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

  Private Sub frmSaisieEncoursManuel_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    ChangesDetected()

  End Sub

  Private Sub frmSaisieEncoursManuel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'on ouvre la connexion
      If oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        dtEncours = New DataTable
        dtEncours = ModDataGridView.LoadList("api_sp_ListeCANEnCoursManuel", oGestConnectSQL.CnxSQLOpen)

        GCEncoursManuel.DataSource = dtEncours

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.TabSyntheseCompta_frmSaisieEncoursManuel_sub + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click

    Me.Close()

  End Sub

  Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

    Try

      If Not dtEncours Is Nothing AndAlso Not dtEncours.GetChanges Is Nothing Then

        dtEncours.AcceptChanges()
        'sauvegarde des lignes inventaires
        If dtEncours.Rows.Count > 0 Then
          For Each oRowsCont As DataRow In dtEncours.Rows
            SaveLigneEnCoursManuelByCAN(oRowsCont)
          Next
        End If

        LoadEncoursManuel()

      End If

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub LoadEncoursManuel()

    dtEncours = New DataTable
    dtEncours = LoadList("api_sp_ListeCANEnCoursManuel", oGestConnectSQL.CnxSQLOpen)

    GCEncoursManuel.DataSource = dtEncours

  End Sub

  Private Sub SaveLigneEnCoursManuelByCAN(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sqlcmdCreateLigne As New SqlCommand("api_sp_CreationEnCoursManuelByCAN", oGestConnectSQL.CnxSQLOpen)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@p_NCANNUM", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NCANNUM").Value = oRowsSavTemp.Item("NCANNUM")
      sqlcmdCreateLigne.Parameters.Add("@p_NMONTANT", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NMONTANT").Value = oRowsSavTemp.Item("NMONTANT")
      sqlcmdCreateLigne.Parameters.Add("@p_VCOMMENTAIRE", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@p_VCOMMENTAIRE").Value = oRowsSavTemp.Item("VCOMMENTAIRE")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Function ChangesDetected() As DialogResult

    'on teste si il y eu des modifs questions non enregistrer.
    If Not dtEncours Is Nothing AndAlso Not dtEncours.GetChanges Is Nothing Then

      If dtEncours.GetChanges.Rows.Count > 0 Then

        Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.TabSyntheseCompta_frmSaisieEncoursManuel_mozart, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

          Case DialogResult.Yes
            BtnSave.PerformClick()
            Return DialogResult.Yes
          Case DialogResult.Cancel
            Return DialogResult.Cancel
          Case Else
            Return DialogResult.No
        End Select

      Else

        Return DialogResult.No

      End If

    Else

      Return DialogResult.No

    End If

  End Function

End Class