Imports System.Data.SqlClient
Imports MozartLib

Public Class frmModifODBilanAnnuel

  Dim oGestConnectSQL As New CGestionSQL

  Dim dtODBilan As DataTable

  Private Sub frmModifODBilanAnnuel_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

  Private Sub frmModifODBilanAnnuel_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    ChangesDetected()

  End Sub

  Private Sub frmModifODBilanAnnuel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'on ouvre la connexion
      If oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        CboAnnee.DisplayMember = "VALUE"
        CboAnnee.ValueMember = "VALUE"
        CboAnnee.DataSource = ModDataGridView.LoadList("api_sp_ListeComboODBilanAnnuel", oGestConnectSQL.CnxSQLOpen)

        'sélection auto de l'année en cours
        If CboAnnee.Items.Count > 0 Then CboAnnee.SelectedIndex = CboAnnee.Items.Count - 1

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.TabSyntheseCompta_frmModifODBilanAnnuel_sub + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click

    Me.Close()

  End Sub

  Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

    Try

      If Not dtODBilan Is Nothing AndAlso Not dtODBilan.GetChanges Is Nothing Then

        dtODBilan.AcceptChanges()
        'sauvegarde des lignes inventaires
        If dtODBilan.Rows.Count > 0 Then
          For Each oRowsCont As DataRow In dtODBilan.Rows
            SaveLigneODBilanAnnuelByCAN(oRowsCont)
          Next
        End If

        LoadODBilanAnnuel(CboAnnee.SelectedValue.ToString)

      End If

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub LoadODBilanAnnuel(ByVal sAnnee As String)

    dtODBilan = New DataTable
    dtODBilan = ModDataGridView.LoadList("api_sp_ListeODBilanAnnuel " + sAnnee, oGestConnectSQL.CnxSQLOpen)

    GCODBilanAnnuel.DataSource = dtODBilan

  End Sub

  Private Sub SaveLigneODBilanAnnuelByCAN(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sqlcmdCreateLigne As New SqlCommand("api_sp_CreationODBilanAnnuelByCAN", oGestConnectSQL.CnxSQLOpen)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@P_NIDODBILAN", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NIDODBILAN").Value = oRowsSavTemp.Item("NIDODBILAN")
      sqlcmdCreateLigne.Parameters.Add("@p_NCANNUM", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NCANNUM").Value = oRowsSavTemp.Item("NCANNUM")
      sqlcmdCreateLigne.Parameters.Add("@p_NMONTANT", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NMONTANT").Value = oRowsSavTemp.Item("NMONTANT")
      sqlcmdCreateLigne.Parameters.Add("@P_VODBILAN_COM", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@P_VODBILAN_COM").Value = oRowsSavTemp.Item("VODBILAN_COM")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Function ChangesDetected() As DialogResult

    'on teste si il y eu des modifs questions non enregistrer.
    If Not dtODBilan Is Nothing AndAlso Not dtODBilan.GetChanges Is Nothing Then

      If dtODBilan.GetChanges.Rows.Count > 0 Then

        Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.TabSyntheseCompta_frmModifODBilanAnnuel_mozart, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

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

  Private Sub CboAnnee_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboAnnee.SelectedIndexChanged

    If CboAnnee.SelectedValue.ToString <> "" Then

      LoadODBilanAnnuel(CboAnnee.SelectedValue.ToString)

    End If

  End Sub

End Class