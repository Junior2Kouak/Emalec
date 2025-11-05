Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports MozartLib

Public Class frmTransRetourDevis

  Dim calendar_open As String
  Private highlightedColumn As GridColumn
  Private highlightedRowHandle As Integer = -1
  Private prevHighlightedRowHandle As Integer = -1

  Private Sub frmNbTransfDevis_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    'txtDtCreaDu.Text = Date.Today.AddYears(-1).AddDays((Today.Day - 1) * -1)
    txtDtCreaDu.Text = Date.Today.AddMonths(-1).AddDays((Today.Day - 1) * -1)
    txtDtCreaAu.Text = Date.Today.AddDays(Today.Day * -1)
    txtDtExecDu.Text = Date.Today.AddMonths(-1).AddDays((Today.Day - 1) * -1)
    txtDtExecAu.Text = Date.Today.AddDays(Today.Day * -1)

    lblNomClient.Text = ", le " & Date.Today

    'RemplirCombo cboChaff, "" & gstrNomSociete & "' ORDER BY  VPERNOM, VPERPRE", False
    Dim sqlcmdCbo As SqlCommand
    Dim dtChaff As New DataTable
    sqlcmdCbo = New SqlCommand(String.Format("select NPERNUM, VPERNOM + ' ' + VPERPRE as chaff from TPER where CPERACTIF = 'O' AND CPERTYP='CA' AND VSOCIETE = '{0}' union select 0, ' TOUS CHAFFS' as chaff ORDER BY chaff", MozartParams.NomSociete), MozartDatabase.cnxMozart) With {.CommandType = CommandType.Text}
    dtChaff.Load(sqlcmdCbo.ExecuteReader())
    ComboBox1.DataSource = dtChaff
    If MozartParams.Langue = "ES" Then
      GVStat.Columns("VCLINOM").SummaryItem.DisplayFormat = "Totale : {0:n0} Cliente(s)"
      GVStat.Columns("NBDevisCrees").SummaryItem.DisplayFormat = "{0:n0} Presupuestos"
      GVStat.Columns("NBDevisExec").SummaryItem.DisplayFormat = "{0:n0} Presupuestos"
      GVStat.Columns("NbDevisRefuses").SummaryItem.DisplayFormat = "{0:n0} Presupuestos"
      'GVStat.Columns("HeuresTravail").SummaryItem.DisplayFormat = "{0:n0} Horas"
    End If

  End Sub

  Private Sub ChargeListe()
    Try

      Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_StatTauxRetourDevis", MozartDatabase.cnxMozart) With {.CommandType = CommandType.StoredProcedure}
      CmdSql.Parameters.Add("@dateDebDevisCrees", SqlDbType.DateTime).Value = txtDtCreaDu.Text
        CmdSql.Parameters.Add("@dateFinDevisCrees", SqlDbType.DateTime).Value = txtDtCreaAu.Text
        CmdSql.Parameters.Add("@dateDebDevisExec", SqlDbType.DateTime).Value = txtDtExecDu.Text
        CmdSql.Parameters.Add("@dateFinDevisExec", SqlDbType.DateTime).Value = txtDtExecAu.Text
        CmdSql.Parameters.Add("@chaff", SqlDbType.Int).Value = ComboBox1.SelectedValue

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GCStat.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show("Sub frmNbTransfDevis.ChargeListe() frmNbTransfDevis :" + ex.Message, My.Resources.Global_Erreur)
    Finally
      Cursor = Cursors.Default
    End Try
  End Sub


  Private Sub BtnFermer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFermer.Click
    Close()
  End Sub

  Private Sub BtnDate1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDate1.Click
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

  Private Sub BtnDate2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDate2.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "txtDtExecDu"
      MonthCalendar1.Visible = True
    End If
    If txtDtExecDu.Text <> "" Then
      MonthCalendar1.SetDate(txtDtExecDu.Text)
    End If
  End Sub

  Private Sub BtnDate3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDate3.Click
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

  Private Sub BtnDate4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDate4.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "txtDtExecAu"
      MonthCalendar1.Visible = True
    End If
    If txtDtExecAu.Text <> "" Then
      MonthCalendar1.SetDate(txtDtExecAu.Text)
    End If
  End Sub

  Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
    Select Case calendar_open

      Case "txtDtCreaDu"
        txtDtCreaDu.Text = MonthCalendar1.SelectionStart.Date
      Case "txtDtCreaAu"
        txtDtCreaAu.Text = MonthCalendar1.SelectionStart.Date
      Case "txtDtExecDu"
        txtDtExecDu.Text = MonthCalendar1.SelectionStart.Date
      Case "txtDtExecAu"
        txtDtExecAu.Text = MonthCalendar1.SelectionStart.Date
      Case Else
        Exit Select

    End Select

    MonthCalendar1.Visible = False
  End Sub

  Private Sub BtValider_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtValider.Click
    MonthCalendar1.Visible = False
    If Date.Parse(txtDtCreaAu.Text) >= Date.Parse(txtDtCreaDu.Text) And Date.Parse(txtDtExecAu.Text) >= Date.Parse(txtDtExecAu.Text) Then
      ChargeListe()
    Else
      MsgBox(My.Resources.GestionMPT_frmNBTransfDevis_date_incorrectes, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, My.Resources.Global_Erreur_maj)
    End If
  End Sub

  Private Sub ButtonExporter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = String.Format("{0}\ExportNBDevisExec_{1}{2}{3}_{4}{5}.xls", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), Today.Year, Today.Month, Today.Day, TimeOfDay.Hour, TimeOfDay.Minute)
    GCStat.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  'Customise l'affichage du footer et de ses données.
  Private Shared Sub GVStat_CustomDrawFooterCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs) Handles GVStat.CustomDrawFooterCell
    e.Handled = True
    e.Appearance.BackColor = Color.Gray
    e.Appearance.ForeColor = Color.White
    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    e.Appearance.DrawBackground(e.Cache, e.Bounds)
    e.Appearance.DrawString(e.Cache, e.Info.DisplayText, e.Bounds)

  End Sub

  Private Sub GVStat_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GVStat.RowCellClick

    If e.Column.Name = "VCLINOM" And GVStat.GetRowCellValue(e.RowHandle, VCLINOM) <> "" Then

      Dim CmdSql As New SqlCommand("api_sp_StatTauxRetourDevisGraphique", MozartDatabase.cnxMozart) With {.CommandType = CommandType.StoredProcedure}

      CmdSql.Parameters.Add("@chaff", SqlDbType.Int).Value = GVStat.GetRowCellValue(e.RowHandle, NPERNUM)
        CmdSql.Parameters.Add("@cli", SqlDbType.Int).Value = GVStat.GetRowCellValue(e.RowHandle, NCLINUM)

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        ChartCtrlStatRetourDevis.DataSource = dtStat.Tables(0)
        PnlChart.Visible = True
        BtnClose.Visible = True
        GCStat.Visible = False

        LblTitre.Visible = True
        lblNomClient.Visible = True
        lblNomClient.Text = GVStat.GetRowCellValue(e.RowHandle, VCLINOM)

        CmdSql.Dispose()

    End If

  End Sub

  Private Sub BtnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClose.Click

    PnlChart.Visible = False
    BtnClose.Visible = False
    GCStat.Visible = True
    LblTitre.Visible = False
    lblNomClient.Visible = False

  End Sub

  ' Gère la forme du curseur au passage de la  souris sur les cellules cliquables.
  Private Sub GVStat_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles GVStat.MouseMove

    Dim hInfo As GridHitInfo = GVStat.CalcHitInfo(e.Location)



    If hInfo.InRowCell = True And (hInfo.Column Is GVStat.Columns.ColumnByName("VCLINOM")) Then
      GCStat.Cursor = Cursors.Hand
      prevHighlightedRowHandle = highlightedRowHandle
      highlightedColumn = hInfo.Column
      highlightedRowHandle = hInfo.RowHandle
      GVStat.RefreshRow(highlightedRowHandle)
      GVStat.RefreshRow(prevHighlightedRowHandle)

    Else
      GCStat.Cursor = Cursors.Default
      highlightedColumn = Nothing
      GVStat.RefreshRow(highlightedRowHandle)
      GVStat.RefreshRow(prevHighlightedRowHandle)
    End If

  End Sub

  Private Sub GVStat_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GVStat.RowCellStyle

    If ((e.Column Is highlightedColumn) AndAlso (e.RowHandle = highlightedRowHandle)) Then
      e.Appearance.BackColor = Color.LightBlue
    End If

  End Sub

End Class