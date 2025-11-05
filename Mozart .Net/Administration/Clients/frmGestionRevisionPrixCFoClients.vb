Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports MozartLib

Public Class frmGestionRevisionPrixCFoClients

  Dim DtListeFo As DataTable

  Private Sub frmGestionRevisionPrixCFoClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadData()


  End Sub

  Private Sub LoadData()

    DtListeFo = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListePrixClientArticle]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        DtListeFo.Load(sqlcmd.ExecuteReader)

        DtListeFo.Columns("NPUHTCLI").ReadOnly = False

        GCGestCliFOPrix.DataSource = DtListeFo

    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click

        Me.Close()

    End Sub

    Private Sub GVGestCliFOPrix_CustomDrawFooter(sender As Object, e As RowObjectCustomDrawEventArgs) Handles GVGestCliFOPrix.CustomDrawFooter

        Dim oPos As Rectangle = e.Bounds
        Dim oFormat As New StringFormat
        oPos.Location = New Point(oPos.Left + 1, oPos.Top + 1)
        oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)
        oFormat.Alignment = StringAlignment.Center
        e.Appearance.DrawString(e.Cache, String.Format(My.Resources.Global_Selection_0_1, GVGestCliFOPrix.RowCount, GCGestCliFOPrix.DataSource.Rows.Count), oPos, oFormat)
        e.Handled = True

    End Sub

    Private Sub BtnRevisePrix_Click(sender As Object, e As EventArgs) Handles BtnRevisePrix.Click

        Dim dtFiltered As New DataTable
        dtFiltered = DtListeFo.Select(DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(GVGestCliFOPrix.ActiveFilterCriteria)).CopyToDataTable

        Dim iCoef As Decimal = 1
        Dim ofrmSaisieCoef As New frmSaisieCoefPrix(dtFiltered.Rows.Count)
        ofrmSaisieCoef.ShowDialog()

        If ofrmSaisieCoef.ValidCoef = True Then

            iCoef = ofrmSaisieCoef.dCoeff

            Me.Cursor = Cursors.WaitCursor

            For Each drFilter As DataRow In dtFiltered.Rows

        Dim sqlupdate As New SqlCommand("[api_sp_UpdatePrixClientArticle]", MozartDatabase.cnxMozart)
        sqlupdate.CommandType = CommandType.StoredProcedure
                sqlupdate.Parameters.Add("@NFOUNUM", SqlDbType.Int).Value = drFilter.Item("NFOUNUM")
                sqlupdate.Parameters.Add("@NCLINUM", SqlDbType.Int).Value = drFilter("NCLINUM")
                sqlupdate.Parameters.Add("@COEFF", SqlDbType.Decimal).Value = iCoef

                sqlupdate.ExecuteNonQuery()

            Next

            LoadData()

            Me.Cursor = Cursors.Default

            MessageBox.Show("Mis à jour des coefficients terminée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub BtnDelFO_Click(sender As Object, e As EventArgs) Handles BtnDelFO.Click

        If GVGestCliFOPrix.FocusedRowHandle < 0 Then
            MessageBox.Show(My.Resources.Global_selectionner_une_ligne, My.Resources.Global_suppresion_message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim DrDel As DataRow = GVGestCliFOPrix.GetDataRow(GVGestCliFOPrix.FocusedRowHandle)

        If MessageBox.Show(String.Format("Vous-vous supprimer cet article des prix clients du client {0} ?", DrDel.Item("VCLINOM")), "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      Dim sqlupdate As New SqlCommand("[api_sp_DeletePrixClientArticle]", MozartDatabase.cnxMozart)
      sqlupdate.CommandType = CommandType.StoredProcedure
            sqlupdate.Parameters.Add("@NFOUNUM", SqlDbType.Int).Value = DrDel.Item("NFOUNUM")
            sqlupdate.Parameters.Add("@NCLINUM", SqlDbType.Int).Value = DrDel.Item("NCLINUM")

            sqlupdate.ExecuteNonQuery()

        End If

        LoadData()

    End Sub

  Private Sub BtnExportXLS_Click(sender As Object, e As EventArgs) Handles BtnExportXLS.Click
    SFD.Filter = "Fichiers XLSX |*.XLSX"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then
      GCGestCliFOPrix.ExportToXlsx(SFD.FileName)
    End If
  End Sub
End Class