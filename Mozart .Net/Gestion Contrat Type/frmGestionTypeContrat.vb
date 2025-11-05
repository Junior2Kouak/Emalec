Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports MozartLib

Public Class frmGestionTypeContrat

  Dim sqlConnectGestCont As CGestionSQL

  Dim dtLstGestCont As DataTable

  Private Sub frmGestionTypeContrat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    sqlConnectGestCont.CloseConnexionSQL()

  End Sub

  Private Sub frmGestionTypeContrat_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    'on teste si il y eu des modifs questions non enregistrer.
    If Not dtLstGestCont.GetChanges Is Nothing Then

      If dtLstGestCont.GetChanges.Rows.Count > 0 Then

        Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.GestionContrat_type_frmGestionTypeContrat_mozart, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

          Case vbYes
            BtnSave.PerformClick()
            Me.Close()
          Case vbCancel
            e.Cancel = True
          Case Else
            e.Cancel = False

        End Select

      End If

    End If

  End Sub

  Private Sub frmGestionTypeContrat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      sqlConnectGestCont = New CGestionSQL
      If sqlConnectGestCont.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        LoadListeGestContrat()

        RepGLUpEditDom.DataSource = LoadListeDomaineCombo()

      End If

      ResizeComponents()

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click

    Me.Close()

  End Sub

  Private Sub LoadListeGestContrat()

    dtLstGestCont = New DataTable
    dtLstGestCont = ModDataGridView.LoadListWithIncrementAuto("api_sp_ListeGestionTypeContrat", sqlConnectGestCont.CnxSQLOpen)

    dtLstGestCont.Columns("NEDITRECRU").ReadOnly = False

    Dim keys(1) As DataColumn

    keys(0) = dtLstGestCont.Columns("IDTMP")

    dtLstGestCont.PrimaryKey = keys

    GCContrat.DataSource = dtLstGestCont

  End Sub

  '*************************************************************************************************
  'On charge la table des domaines dans une combo
  '*************************************************************************************************
  Public Function LoadListeDomaineCombo() As DataTable

    Try

      Dim dtExtLstDomaineCbo As New DataTable

      Dim sqlcmdCboDom As New SqlCommand("api_sp_ListeDomaineTypeContrat", sqlConnectGestCont.CnxSQLOpen)
      sqlcmdCboDom.CommandType = CommandType.StoredProcedure
      dtExtLstDomaineCbo.Load(sqlcmdCboDom.ExecuteReader)

      Return dtExtLstDomaineCbo

    Catch ex As Exception

      MessageBox.Show("frmGestionTypeContrat dans LoadListeDomaineCombo : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Private Sub RepGLUpEditDom_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles RepGLUpEditDom.QueryPopUp
    Dim editor As GridLookUpEdit = CType(sender, GridLookUpEdit)
    Dim Pos As Point = Control.MousePosition
    Dim properties As RepositoryItemGridLookUpEdit = editor.Properties

    properties.PopupFormSize = New Size(editor.Width, GCContrat.Height)
  End Sub

  Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

    Try

      dtLstGestCont.AcceptChanges()
      'sauvegarde des lignes inventaires
      If dtLstGestCont.Rows.Count > 0 Then
        For Each oRowsCont As DataRow In dtLstGestCont.Rows
          SaveLigneContrat(oRowsCont)
        Next
      End If

      LoadListeGestContrat()

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub SaveLigneContrat(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sqlcmdCreateLigne As New SqlCommand("api_sp_CreationGestContrat", sqlConnectGestCont.CnxSQLOpen)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@p_ncontgestnum", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_ncontgestnum").Value = oRowsSavTemp.Item("NCONTGESTNUM")
      sqlcmdCreateLigne.Parameters.Add("@p_ntypecontrat", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_ntypecontrat").Value = oRowsSavTemp.Item("NTYPECONTRAT")
      sqlcmdCreateLigne.Parameters.Add("@p_ncontdomnum", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_ncontdomnum").Value = oRowsSavTemp.Item("NCONTDOMNUM")
      sqlcmdCreateLigne.Parameters.Add("@p_neditrecru", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_neditrecru").Value = oRowsSavTemp.Item("NEDITRECRU")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub frmGestionTypeContrat_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd

    ResizeComponents()

  End Sub

  Private Sub ResizeComponents()

    GCContrat.Width = Me.Width - GCContrat.Left - 15
    GCContrat.Height = Me.Height - GCContrat.Top - 40

  End Sub

  Private Sub frmGestionTypeContrat_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    ResizeComponents()
  End Sub

End Class
