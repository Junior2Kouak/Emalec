Imports System.Data.SqlClient
Imports MozartLib

Public Class frmListeArch

  Dim drMain As New SqlDataAdapter
  Dim ds As New DataSet
  Dim dtArchives As DataTable

  Private Sub frmListeArch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'Init        
    'Me.Text = "Liste des chiffrages seuls archivés"
    'LlblTitre.Text = "Liste des chiffrages seuls archivés"

    Me.Text = My.Resources.Admin_frmListeArch_liste_chiffrage
    LlblTitre.Text = My.Resources.Admin_frmListeArch_liste_chiffrage


    LoadData()
    ResizeMe()

  End Sub

  Private Sub LoadData()
    Try
      'on charge les données
      dtArchives = New DataTable

      Dim sqlcmd As New SqlCommand("api_sp_ChantierListeChiffrage", MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.StoredProcedure
      sqlcmd.Parameters.Add("@actif", SqlDbType.VarChar).Value = "N"
      sqlcmd.Parameters.Add("@soc", SqlDbType.VarChar).Value = MozartParams.NomSociete
      sqlcmd.Parameters.Add("@iall", SqlDbType.Int).Value = 0 '2

      dtArchives = New DataTable
      dtArchives.Load(sqlcmd.ExecuteReader)

      GrdListeArch.DataSource = dtArchives

    Catch Ex As Exception
      MessageBox.Show(My.Resources.Admin_frmListeArch_InitData & Ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub btnRestaurer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaurer.Click

    If GVListeChifArch.RowCount = 0 Then Exit Sub

    Try

      If GVListeChifArch.SelectedRowsCount = 0 Then Exit Try

      Dim oDataRowSelect As DataRow = GVListeChifArch.GetDataRow(GVListeChifArch.GetSelectedRows(0))

      If MessageBox.Show(String.Format(My.Resources.Admin_frmListeArch_Restaurer_chiffrage, oDataRowSelect.Item(GVListeChifArch.Columns.ColumnByFieldName("VLIBCHIF").AbsoluteIndex).ToString), "Confirmation - restauration chiffrage", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

        ' modification
        Dim cmd As New SqlCommand("", MozartDatabase.cnxMozart)
        cmd.CommandText = "UPDATE TCHANTIERCHIFFRAGE SET CCHIFACTIF = 'O' WHERE NIDCHIF = " & oDataRowSelect.Item(GVListeChifArch.Columns.ColumnByFieldName("NIDCHIF").AbsoluteIndex).ToString
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        LoadData()

      End If

    Catch Ex As Exception
      MessageBox.Show(My.Resources.Admin_frmListeArch_btnRestaurer & Ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub btnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFermer.Click
    Me.Close()
  End Sub

  Private Sub ResizeMe()

    Dim btnPos As New Point
    GrdListeArch.Height = Me.Height - GrdListeArch.Location.Y - 50
    GrdListeArch.Width = Me.Width - GrdListeArch.Location.X - 50
    btnPos.Y = GrdListeArch.Height - btnFermer.Height - 10
    btnPos.X = btnFermer.Location.X
    btnFermer.Location = btnPos
    GrpActions.Height = GrdListeArch.Height

  End Sub

End Class