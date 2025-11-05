Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class frmDevisAttenteChaff

  Private Sub frmDevisAttenteChaff_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_StatDevisAttenteChaff", MozartDatabase.cnxMozart)
        CmdSql.CommandTimeout = 0
        CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.Parameters.Add("@npernum", SqlDbType.Int).Value = "0"

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        ChartControl0.DataSource = dtStat.Tables(0)
        ChartControl1.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

      End If

    Catch ex As Exception
            MessageBox.Show(My.Resources.Reporting_Devis_frmDevisAttenteChaff_SubDevisLoad + ex.Message, My.Resources.Global_Erreur)
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
        Dim oFrmDetailStat As New frmDevisAttenteChaffDetails(vArgument, vToolTipHint)
        oFrmDetailStat.ShowDialog()
      End If
    End If
  End Sub

  Private Sub ChartControl1_ObjectSelected(sender As Object, e As DevExpress.XtraCharts.HotTrackEventArgs) Handles ChartControl1.ObjectSelected
    Dim vToolTipHint, vArgument As String

    If e.HitInfo.InSeries Then
      Dim point As SeriesPoint = CType(e.AdditionalObject, SeriesPoint)
      If point IsNot Nothing Then
        vArgument = point.Argument
        vToolTipHint = point.ToolTipHint
        Dim oFrmDetailStat As New frmDevisAttenteChaffDetails(vArgument, vToolTipHint)
        oFrmDetailStat.ShowDialog()
      End If
    End If
  End Sub
End Class