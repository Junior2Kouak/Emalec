Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class frmDevisAFaire

  Dim oGestConnectSQL As New CGestionSQL
  Dim dtStatMag2 As DataTable

  Private Sub frmDevisAFaire_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_StatDevisAFaire", MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.StoredProcedure

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        ChartControl1.DataSource = dtStat.Tables(0)
        ChartBas.DataSource = dtStat.Tables(1)

        CmdSql.Dispose()

      End If

    Catch ex As Exception
            MessageBox.Show(My.Resources.Reporting_Devis_frmDevisAFaire_SubLoad + ex.Message, My.Resources.Global_Erreur)
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

  Private Sub ChartControl1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ChartControl1.MouseClick
    ' Détails chaff
    Dim hitInfo As ChartHitInfo = ChartControl1.CalcHitInfo(e.Location)
    If hitInfo.SeriesPoint IsNot Nothing Then
      Dim oFrmDetailStat As New frmDevisAFaireDetails(hitInfo.SeriesPoint.Tag.Row.ItemArray, "CHAFF")
      oFrmDetailStat.ShowDialog()
    End If
  End Sub

  Private Sub ChartBas_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ChartBas.MouseClick
    ' Détails clients
    Dim hitInfo As ChartHitInfo = ChartBas.CalcHitInfo(e.Location)
    If hitInfo.SeriesPoint IsNot Nothing Then
      Dim oFrmDetailStat As New frmDevisAFaireDetails(hitInfo.SeriesPoint.Tag.Row.ItemArray, "CLIENT")
      oFrmDetailStat.ShowDialog()
    End If
  End Sub
End Class