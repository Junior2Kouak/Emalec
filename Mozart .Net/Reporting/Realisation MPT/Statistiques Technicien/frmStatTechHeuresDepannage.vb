Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class frmStatTechHeuresDepannage

  Private Sub frmStatTechHeuresDepannage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try

      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_StatTechHeuresDepannage", MozartDatabase.cnxMozart)
      CmdSql.CommandType = CommandType.StoredProcedure

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
      Dim dtStat As New DataSet
      sqlAdpat.Fill(dtStat)

      ChartControl0.DataSource = dtStat.Tables(0)
      CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmStatTechHeuresDepannage_sub + ex.Message, My.Resources.Global_Erreur)
        Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

  Private Sub ChartControl0_ObjectSelected(sender As Object, e As DevExpress.XtraCharts.HotTrackEventArgs) Handles ChartControl0.ObjectSelected

    Dim vToolTipHint, vArgument As String

    If e.HitInfo.InSeries Then
      Dim point As SeriesPoint = CType(e.AdditionalObject, SeriesPoint)
      If point IsNot Nothing Then
        vArgument = point.Argument
        vToolTipHint = point.ToolTipHint
        Dim oFrmDetailStat As New frmStatTechHeuresDepannageDetails(vArgument, vToolTipHint)
        oFrmDetailStat.ShowDialog()
      End If
    End If

  End Sub

End Class