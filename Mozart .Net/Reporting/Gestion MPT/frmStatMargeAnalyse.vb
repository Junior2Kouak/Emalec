Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class frmStatMargeAnalyse

  Dim calendar_open As String

  Private Sub frmStatMargeAnalyse_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try
      Dim lDate As Date = DateAdd(DateInterval.Month, -1, Today)
      lDate = lDate.AddDays((-1 * Today.Day) + 1)
      txtDtDebut.Text = lDate
      lDate = lDate.AddMonths(1)
      lDate = lDate.AddDays(-1)
      txtDtFin.Text = lDate

      ChargeListe()

    Catch ex As Exception
      MessageBox.Show(My.Resources.GestionMPT_frmStatMargeAnalyse_sub + ex.Message, My.Resources.Global_Erreur)
    Finally
      Cursor = Cursors.Default
    End Try

  End Sub

  Sub ChargeListe()

    Try

      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_StatAnalyseMarge", MozartDatabase.cnxMozart)
      CmdSql.CommandType = CommandType.StoredProcedure
        'CmdSql.CommandTimeout = 0
        CmdSql.Parameters.Add("@DtDebut", SqlDbType.DateTime).Value = "01" & txtDtDebut.Text.Substring(2)  ' On se place au 1er jour du mois sélectionné, sinon stat fausse
        Dim dtTemp As Date = "01" & txtDtFin.Text.Substring(2)
        dtTemp = dtTemp.AddMonths(1)
        dtTemp = dtTemp.AddDays(-1) ' On se place obligatoirement au dernier jour du mois sélectionné...
        CmdSql.Parameters.Add("@DtFin", SqlDbType.DateTime).Value = dtTemp.ToString

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GCStat.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

        Chart1.DataSource = DBNull.Value
        Chart2.DataSource = DBNull.Value
        Chart3.DataSource = DBNull.Value
        Grp1.Visible = False
        Grp2.Visible = False
        Grp3.Visible = False

    Catch ex As Exception
            MessageBox.Show("Sub ChargeListe() frmStatMargeAnalyse : " + ex.Message, My.Resources.Global_Erreur)
        Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnDate1_Click(sender As System.Object, e As System.EventArgs) Handles BtnDate1.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "txtDtDebut"
      MonthCalendar1.Visible = True
    End If
    If txtDtDebut.Text <> "" Then
      MonthCalendar1.SetDate(txtDtDebut.Text)
    End If
  End Sub

  Private Sub BtnDate2_Click(sender As System.Object, e As System.EventArgs) Handles BtnDate2.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "txtDtFin"
      MonthCalendar1.Visible = True
    End If
    If txtDtFin.Text <> "" Then
      MonthCalendar1.SetDate(txtDtFin.Text)
    End If
  End Sub

  Private Sub MonthCalendar1_DateSelected(sender As Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
    Select Case calendar_open

      Case "txtDtDebut"
        txtDtDebut.Text = MonthCalendar1.SelectionStart.Date
      Case "txtDtFin"
        txtDtFin.Text = MonthCalendar1.SelectionStart.Date

    End Select

    MonthCalendar1.Visible = False
  End Sub

  Private Sub BtnExport_Click(sender As System.Object, e As System.EventArgs) Handles BtnExport.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\MargeAnalyse_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCStat.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub GVStat_EndSorting(sender As Object, e As System.EventArgs) Handles GVStat.EndSorting
    GVStat.MoveFirst()
  End Sub

  Private Sub BtValider_Click(sender As System.Object, e As System.EventArgs) Handles BtValider.Click
    ChargeListe()
  End Sub

  Private Sub GCStat_Click(sender As Object, e As System.EventArgs) Handles GCStat.Click
    Try
      ' On récupère le n° unique NCLINUM sélectionné dans la liste
      Dim ligne_selectionnee As Integer() = GVStat.GetSelectedRows()
      Dim nclinum As String = GVStat.GetRowCellValue(ligne_selectionnee.ElementAt(0), "nclinum").ToString
      Dim npernum As String = GVStat.GetRowCellValue(ligne_selectionnee.ElementAt(0), "npernum").ToString
      Dim ncannum As String = GVStat.GetRowCellValue(ligne_selectionnee.ElementAt(0), "ncannum").ToString

      Try

        Me.Cursor = Cursors.WaitCursor

        Dim CmdSql As New SqlCommand("api_sp_StatAnalyseMarge_48Mois", MozartDatabase.cnxMozart)
        CmdSql.CommandTimeout = 0
        CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.Parameters.Add("@nclinum", SqlDbType.Int).Value = nclinum
        CmdSql.Parameters.Add("@ncannum", SqlDbType.Int).Value = ncannum

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        Chart1.DataSource = dtStat.Tables(0)

        Chart2.DataSource = dtStat.Tables(1)

        CmdSql.Dispose()

        CmdSql = New SqlCommand("api_sp_StatAnalyseMarge_48Mois_Suite", MozartDatabase.cnxMozart)
        CmdSql.CommandTimeout = 0
        CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.Parameters.Add("@npernum", SqlDbType.Int).Value = npernum

        sqlAdpat = New SqlDataAdapter(CmdSql)
        Dim dtStat2 As New DataSet
        sqlAdpat.Fill(dtStat2)

        Chart3.DataSource = dtStat2.Tables(0)

        Grp1.Visible = True
        Grp2.Visible = True
        Grp3.Visible = True

        CmdSql.Dispose()

      Catch ex As Exception
        MessageBox.Show("Sub GCStat_Click() frmStatMargeAnalyse : " + ex.Message, My.Resources.Global_Erreur)
            Finally
        Me.Cursor = Cursors.Default
      End Try


    Catch ex As Exception
      '
    End Try
  End Sub
End Class