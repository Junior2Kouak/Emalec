Imports System.Data.SqlClient
Imports MozartLib

Public Class frmStatProductionAssistants

  Dim calendar_open As String

  Private Sub frmStatProductionAssistants_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    txtDtCreaDu.Text = Date.Today.AddDays(-30)
    txtDtCreaAu.Text = Date.Today

    lblDateJour.Text = ", le " & Date.Today

    ' gestion d'une combo des fonctions pour filtre
    Dim sqlcmdCbo As SqlCommand
    Dim dtChaff As New DataTable
    sqlcmdCbo = New SqlCommand($"SELECT DISTINCT R.ID, VTYPEDETAILLIB From TREF_TYPEPERDETAIL R INNER Join TPER P ON R.CPERTYP = P.CPERTYP 
                              And R.CPERTYPDETAIL = P.CPERTYPDETAIL Where P.CPERTYP <> 'TE' AND VSOCIETE = '{MozartParams.NomSociete}' AND CPERACTIF = 'O'
                              union select 0, '' ORDER BY VTYPEDETAILLIB", MozartDatabase.cnxMozart) With {.CommandType = CommandType.Text}
    dtChaff.Load(sqlcmdCbo.ExecuteReader())
    ComboBox1.DataSource = dtChaff


    ' FGA on ouvre la page vide afin de gagner du temps
    'ChargeListe()

  End Sub

  Private Sub ChargeListe()
    Try

      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_StatistiqueProduction", MozartDatabase.cnxMozart)
      CmdSql.CommandType = CommandType.StoredProcedure
      CmdSql.CommandTimeout = 150
      CmdSql.Parameters.Add("@DateDeb", SqlDbType.DateTime).Value = txtDtCreaDu.Text
      CmdSql.Parameters.Add("@DateFin", SqlDbType.DateTime).Value = txtDtCreaAu.Text
      CmdSql.Parameters.Add("@ID_fonction", SqlDbType.Int).Value = ComboBox1.SelectedValue

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
      Dim dtStat As New DataSet
      sqlAdpat.Fill(dtStat)

      GCStat.DataSource = dtStat.Tables(0)
      ChartControl1.DataSource = dtStat.Tables(1)


      CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show("Sub frmStatProductionAssistants.ChargeListe() frmStatProductionAssistants : " + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub BtnDate1_Click(sender As System.Object, e As System.EventArgs) Handles BtnDate1.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "txtDtCreaDu"
      MonthCalendar1.Visible = True
    End If
    If txtDtCreaDu.Text <> "" Then
      MonthCalendar1.SetDate(txtDtCreaDu.Text)
    End If
  End Sub

  Private Sub BtnDate3_Click(sender As System.Object, e As System.EventArgs) Handles BtnDate3.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "txtDtCreaAu"
      MonthCalendar1.Visible = True
    End If
    If txtDtCreaAu.Text <> "" Then
      MonthCalendar1.SetDate(txtDtCreaAu.Text)
    End If
  End Sub

  Private Sub MonthCalendar1_DateSelected(sender As Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
    Select Case calendar_open

      Case "txtDtCreaDu"
        txtDtCreaDu.Text = MonthCalendar1.SelectionStart.Date

      Case "txtDtCreaAu"
        txtDtCreaAu.Text = MonthCalendar1.SelectionStart.Date

    End Select

    MonthCalendar1.Visible = False
  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\ExportProductionAssistant_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCStat.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub GVStat_EndSorting(sender As Object, e As System.EventArgs) Handles GVStat.EndSorting
    GVStat.MoveFirst()
  End Sub

  Private Sub GVStat_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GVStat.RowCellClick

    ' On teste la colonne double-cliquée
    Dim ligne_selectionnee As Integer() = GVStat.GetSelectedRows()
    Dim colonne As DevExpress.XtraGrid.Columns.GridColumn = GVStat.FocusedColumn()

    Dim NPERNUM As String
    Dim valeur_cellule As String

    If Not ligne_selectionnee Is Nothing Then
      NPERNUM = GVStat.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NPERNUM").ToString
      valeur_cellule = GVStat.GetRowCellValue(ligne_selectionnee.ElementAt(0), colonne).ToString
    Else
      Exit Sub
    End If

    If colonne.AbsoluteIndex >= 4 Then

      Dim oFrmDetailStat As New frmStatProductionAssistantsDetails(NPERNUM, txtDtCreaDu.Text, txtDtCreaAu.Text, colonne.AbsoluteIndex - 1)
      oFrmDetailStat.ShowDialog()

    End If
  End Sub

  Private Sub BtValider_Click(sender As System.Object, e As System.EventArgs) Handles BtValider.Click
    ChargeListe()
  End Sub


End Class