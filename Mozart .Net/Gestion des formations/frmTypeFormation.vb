Imports System.Data.SqlClient
Imports MozartLib

Public Class frmTypeFormation

  Dim oGestConnectSQL As New CGestionSQL
  Dim dt As DataTable


  Private Sub frmOrganisme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'on ouvre la connexion
    oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete)

    GCTYPEFORMATION.DataSource = ListeFormation()

  End Sub

  '*******************************************************************************
  'Charge dans une table la liste des formations
  '*******************************************************************************
  Public Function ListeFormation() As DataTable

    Try

      dt = New DataTable

      Dim sqlcmd As New SqlCommand("api_sp_ListeTypeFormation", oGestConnectSQL.CnxSQLOpen)
      sqlcmd.CommandType = CommandType.StoredProcedure
      sqlcmd.Parameters.Add("@p_NFORNUM", SqlDbType.Int)
      sqlcmd.Parameters("@p_NFORNUM").Value = 0

      dt.Load(sqlcmd.ExecuteReader)

      Return dt

    Catch ex As Exception

      MessageBox.Show(My.Resources.GestionDesFormation_frmTypeFormation_liste + ex.Message)
      Return Nothing

    End Try

  End Function

  Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click

    oGestConnectSQL.CloseConnexionSQL()
    Me.Close()

  End Sub

  Private Sub BtnAddLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddLine.Click
    Try

      Dim oFrmNewForm As New frmNewTypeFormation(0)
      oFrmNewForm.ShowDialog()

      ' rafraichir la Liste
      GCTYPEFORMATION.DataSource = ListeFormation()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub BtnModLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModLine.Click
    Try

      Dim oFrmNewForm As New frmNewTypeFormation(GVTYPEFORMATION.GetDataRow(GVTYPEFORMATION.GetSelectedRows(0)).Item("NFORNUM"))
      oFrmNewForm.ShowDialog()

      ' rafraichir la Liste
      GCTYPEFORMATION.DataSource = ListeFormation()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub BtnSupprLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupprLine.Click

    Try

      If GVTYPEFORMATION.SelectedRowsCount > 0 Then
        'si handle row est inférieur à 0 alors elle ne fait pas partir de la datatable
        If GVTYPEFORMATION.GetSelectedRows(0) < 0 Then
          MessageBox.Show(My.Resources.Global_selectionner_une_ligne, My.Resources.Global_suppression_formation, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
          Return
        End If
      Else
        MessageBox.Show(My.Resources.Global_selectionner_une_ligne, My.Resources.Global_suppression_formation, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return
      End If

      'mise à jour de la datatable
      If MessageBox.Show(My.Resources.Global_supprimer_formation_message, My.Resources.Global_confirmation_suppression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then


        Dim sqlcmdSupprLigne As New SqlCommand("DELETE FROM TFORLISTE WHERE NFORNUM=" + GVTYPEFORMATION.GetDataRow(GVTYPEFORMATION.GetSelectedRows(0)).Item("NFORNUM").ToString, oGestConnectSQL.CnxSQLOpen)
        sqlcmdSupprLigne.CommandType = CommandType.Text
        sqlcmdSupprLigne.ExecuteNonQuery()

        ' rafraichir la Liste
        GCTYPEFORMATION.DataSource = ListeFormation()

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

End Class