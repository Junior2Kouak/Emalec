Imports System.Data.SqlClient
Imports MozartLib

Public Class frmNotationFO

  Private Sub frmNotationFO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    lblDateJour.Text = My.Resources.Global_le & Date.Today

    ChargeListe()

  End Sub

  Private Sub ChargeListe()
    Try

      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_ReportingNotationFO", MozartDatabase.cnxMozart)
      CmdSql.CommandType = CommandType.StoredProcedure

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
      Dim dtStat As New DataSet
      sqlAdpat.Fill(dtStat)

      GCStat.DataSource = dtStat.Tables(0)

      CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show("Sub frmNotationFO.ChargeListe() frmNotationFO :" + ex.Message, My.Resources.Global_Erreur)
        Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\ExportReportingNotation FO_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCStat.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub GVStat_EndSorting(sender As Object, e As System.EventArgs) Handles GVStat.EndSorting
    GVStat.MoveFirst()
  End Sub

End Class