Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports MozartLib

Public Class frmListeLicences

  Private Sub frmListeLicences_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("select * from api_v_listeLicences", MozartDatabase.cnxMozart)

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GridControl1.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

        GridControl1.Focus()

      End If

    Catch ex As Exception
            MessageBox.Show(My.Resources.Admin_frmListeLicences_SubLoad + ex.Message, My.Resources.Global_Erreur)
        Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\LstLicencesInfo_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GridControl1.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))

  End Sub
End Class