Imports System.Data.SqlClient
Imports MozartLib

Public Class frmModifAnaFactureEtabli

  Dim oGestConnectSQL As New CGestionSQL

  Dim dtAnaFacEtabli As DataTable

  Private Sub frmModifAnaFactureEtabli_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

  Private Sub frmModifAnaFactureEtabli_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    ChangesDetected()

  End Sub

  Private Sub frmModifAnaFactureEtabli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'on ouvre la connexion
      If oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        LoadFacturesAEtablir()

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.TabSyntheseCompta_frmModifAnaFactueEtabli_sub + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click

    Me.Close()

  End Sub

  Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

    Try

      If Not dtAnaFacEtabli Is Nothing AndAlso Not dtAnaFacEtabli.GetChanges Is Nothing Then

        dtAnaFacEtabli.AcceptChanges()
        'sauvegarde des lignes inventaires
        If dtAnaFacEtabli.Rows.Count > 0 Then
          For Each oRowsCont As DataRow In dtAnaFacEtabli.Rows
            SaveLigneFactureAEtablirByCAN(oRowsCont)
          Next
        End If

      End If

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub LoadFacturesAEtablir()

    dtAnaFacEtabli = New DataTable
    dtAnaFacEtabli = ModDataGridView.LoadList("api_sp_ListeCAN_AnahistoFacEtabli", oGestConnectSQL.CnxSQLOpen)

    GCANAFACTETABLI.DataSource = dtAnaFacEtabli

  End Sub

  Private Sub SaveLigneFactureAEtablirByCAN(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sqlcmdCreateLigne As New SqlCommand("api_sp_CreationFactureAEtablirByCAN", oGestConnectSQL.CnxSQLOpen)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@P_NIDANAFACETABLI", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NIDANAFACETABLI").Value = oRowsSavTemp.Item("NIDANAFACETABLI")
      sqlcmdCreateLigne.Parameters.Add("@p_NCANNUM", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NCANNUM").Value = oRowsSavTemp.Item("NCANNUM")
      sqlcmdCreateLigne.Parameters.Add("@p_NANAFACTEABLITOT", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NANAFACTEABLITOT").Value = oRowsSavTemp.Item("NANAFACTEABLITOT")
      sqlcmdCreateLigne.Parameters.Add("@P_VANAFAC_COM", SqlDbType.VarChar).Value = oRowsSavTemp.Item("VANAFAC_COM")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Function ChangesDetected() As DialogResult

    'on teste si il y eu des modifs questions non enregistrer.
    If Not dtAnaFacEtabli Is Nothing AndAlso Not dtAnaFacEtabli.GetChanges Is Nothing Then

      If dtAnaFacEtabli.GetChanges.Rows.Count > 0 Then

        Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.TabSyntheseCompta_frmModifAnaFactueEtabli_mozart, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

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