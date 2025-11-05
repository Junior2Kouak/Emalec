Imports System.Data.SqlClient
Imports MozartLib

Public Class frmListeChantierArch

  Private dtArchives As DataTable
  Private nTypeAffichage As Int32

  Private iPos As Int32

  Private Sub frmListChantierArch_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    rbAll.Checked = True

  End Sub

  Private Sub LoadData()
    Try
      'on charge les données
      dtArchives = New DataTable

      Dim sqlcmd As New SqlCommand("api_sp_ChantierListeChiffrage", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      sqlcmd.Parameters.Add("@actif", SqlDbType.VarChar).Value = "N"
      sqlcmd.Parameters.Add("@soc", SqlDbType.VarChar).Value = MozartParams.NomSociete
      sqlcmd.Parameters.Add("@iall", SqlDbType.Int).Value = nTypeAffichage

      dtArchives = New DataTable
      dtArchives.Load(sqlcmd.ExecuteReader)

      GrdListeArch.DataSource = dtArchives

    Catch Ex As Exception
      MessageBox.Show(My.Resources.Admin_frmListeArch_InitData & Ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub btnAnalyse_Click(sender As System.Object, e As System.EventArgs) Handles btnAnalyse.Click

    If GVListeChantierArch.FocusedRowHandle < 0 Then Exit Sub
    If GVListeChantierArch.RowCount = 0 Then Exit Sub

    If GVListeChantierArch.SelectedRowsCount > 0 Then

      Dim dt As DataRow = GVListeChantierArch.GetDataRow(GVListeChantierArch.FocusedRowHandle)

      If IsDBNull(dt.Item("NIDCHANTIER")) = False AndAlso dt.Item("NIDCHANTIER") > 0 Then

        Me.Cursor = Cursors.WaitCursor

        Dim oFrmRealisation As New frmRealisation(dt("NIDCHANTIER"), True)
        oFrmRealisation.ShowDialog()

        Me.Cursor = Cursors.Default

      Else
        MessageBox.Show(My.Resources.Global_sélectionner_Chantier, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If

    End If

  End Sub

  Private Sub chkExpand_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkExpand.CheckedChanged
    If chkExpand.Checked Then
      GVListeChantierArch.CollapseAllGroups()
    Else
      GVListeChantierArch.ExpandAllGroups()
    End If
  End Sub

  Private Sub rbChantier_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbChantier.CheckedChanged
    If rbChantier.Checked Then

      nTypeAffichage = 1
      LoadData()
      chkExpand.Checked = False

    End If
  End Sub

  Private Sub rbChiffrage_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbChiffrage.CheckedChanged
    If rbChiffrage.Checked Then

      nTypeAffichage = 2
      LoadData()
      chkExpand.Checked = False

    End If
  End Sub

  Private Sub rbAll_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbAll.CheckedChanged
    If rbAll.Checked Then

      nTypeAffichage = 0
      LoadData()
      chkExpand.Checked = False

    End If
  End Sub

  Private Sub GVListeChantierArch_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVListeChantierArch.FocusedRowChanged

    If e.FocusedRowHandle > 0 Then

      Dim drSelect As DataRow = GVListeChantierArch.GetDataRow(e.FocusedRowHandle)

      'gestion du bouton affection chiffrage
      'non affecter a un chantier
      If IsDBNull(drSelect.Item("NIDCHANTIER")) OrElse drSelect.Item("NIDCHANTIER") = 0 Then

        btnRestaurer.Visible = True
        btnAnalyse.Visible = True

      Else 'affecter a un chantier

        btnRestaurer.Visible = True
        btnAnalyse.Visible = True

      End If
    Else

      'par défaut
      btnRestaurer.Visible = True
      btnAnalyse.Visible = True

    End If

  End Sub

  Private Sub btnRestaurer_Click(sender As System.Object, e As System.EventArgs) Handles btnRestaurer.Click

    If GVListeChantierArch.FocusedRowHandle < 0 Then Exit Sub
    If GVListeChantierArch.RowCount = 0 Then Exit Sub

    Try

      If GVListeChantierArch.SelectedRowsCount = 0 Then Exit Try

      Dim oDataRowSelect As DataRow = GVListeChantierArch.GetDataRow(GVListeChantierArch.GetSelectedRows(0))

      If MessageBox.Show(String.Format(My.Resources.Admin_frmListeArch_Restaurer_chiffrage, oDataRowSelect.Item(GVListeChantierArch.Columns.ColumnByFieldName("VLIBCHIF").AbsoluteIndex).ToString), My.Resources.Admin_frmListeChantierArch_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

        ' modification
        Dim cmd As New SqlCommand("", MozartDatabase.cnxMozart) With {
          .CommandText = "UPDATE TCHANTIERCHIFFRAGE SET CCHIFACTIF = 'O' WHERE NIDCHIF = " & oDataRowSelect.Item(GVListeChantierArch.Columns.ColumnByFieldName("NIDCHIF").AbsoluteIndex).ToString
        }
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        LoadData()

      End If

    Catch Ex As Exception
      MessageBox.Show(My.Resources.Admin_frmListeArch_btnRestaurer & Ex.Message, My.Resources.Global_Erreur)
    End Try

  End Sub

  Private Sub BtnPlanningChantier_Click(sender As System.Object, e As System.EventArgs) Handles BtnPlanningChantier.Click

    If GVListeChantierArch.FocusedRowHandle < 0 Then Exit Sub
    If GVListeChantierArch.RowCount = 0 Then Exit Sub

    Dim oDataRowSelect As DataRow = GVListeChantierArch.GetDataRow(GVListeChantierArch.FocusedRowHandle)

    If IsDBNull(oDataRowSelect.Item("NIDCHIF")) = False AndAlso oDataRowSelect.Item("NIDCHIF") > 0 Then

      iPos = GVListeChantierArch.FocusedRowHandle

      Dim oChifPlanningXLS As New CGestionPlanningXLS(oDataRowSelect.Item("NIDCHIF"))
      If oChifPlanningXLS.ExistPlanningXLS = False Then oChifPlanningXLS.CreateFichierPlanningXLS(oDataRowSelect.Item("VCLINOM"), MozartParams.NomSociete)
      oChifPlanningXLS.OpenPLanningXLS()

      GVListeChantierArch.FocusedRowHandle = iPos

    Else

      MessageBox.Show(My.Resources.Admin_frmListeChantierArch_SélectionnerChiffrage, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End If

  End Sub

  Private Sub BtnChantierDoc_Click(sender As System.Object, e As System.EventArgs) Handles BtnChantierDoc.Click

    If GVListeChantierArch.FocusedRowHandle < 0 Then Exit Sub
    Dim oDataRowSelect As DataRow = GVListeChantierArch.GetDataRow(GVListeChantierArch.GetSelectedRows(0))

    If IsDBNull(oDataRowSelect.Item("NIDCHANTIER")) = False AndAlso oDataRowSelect.Item("NIDCHANTIER") > 0 Then

      iPos = GVListeChantierArch.FocusedRowHandle

      Dim oChantierDoc As New frmGestionDocChantier(oDataRowSelect.Item("NIDCHANTIER"), oDataRowSelect.Item("VCANLIB"), True)
      oChantierDoc.ShowDialog()

      GVListeChantierArch.FocusedRowHandle = iPos

    Else

      MessageBox.Show(My.Resources.Admin_frmListeChantierArch_SélectionnerChiffrage, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End If

  End Sub

End Class
