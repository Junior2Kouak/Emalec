Imports System.Data.SqlClient
Imports MozartLib

Public Class frmNbTransfDevis

  Dim calendar_open As String

  Private Sub frmNbTransfDevis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'txtDtCreaDu.Text = Date.Today.AddYears(-1).AddDays((Today.Day - 1) * -1)
    txtDtCreaDu.Text = Date.Today.AddMonths(-1).AddDays((Today.Day - 1) * -1)
    txtDtCreaAu.Text = Date.Today.AddDays(Today.Day * -1)
    txtDtExecDu.Text = Date.Today.AddMonths(-1).AddDays((Today.Day - 1) * -1)
    txtDtExecAu.Text = Date.Today.AddDays(Today.Day * -1)

    lblDateJour.Text = ", le " & Date.Today

    'RemplirCombo cboChaff, "" & gstrNomSociete & "' ORDER BY  VPERNOM, VPERPRE", False
    Dim sqlcmdCbo As SqlCommand
    Dim dtChaff As New DataTable
    sqlcmdCbo = New SqlCommand("select NPERNUM, VPERNOM + ' ' + VPERPRE as chaff from TPER where CPERACTIF = 'O' AND CPERTYP='CA' AND VSOCIETE = '" & MozartParams.NomSociete & "' union select 0, ' TOUS CHAFFS' as chaff ORDER BY chaff", MozartDatabase.cnxMozart)
    sqlcmdCbo.CommandType = CommandType.Text
    dtChaff.Load(sqlcmdCbo.ExecuteReader())
    ComboBox1.DataSource = dtChaff
  End Sub

  Private Sub ChargeListe()
    Try

      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_StatNbDevisExecutes", MozartDatabase.cnxMozart)
      CmdSql.CommandType = CommandType.StoredProcedure
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
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
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

  Private Sub BtnDate2_Click(sender As System.Object, e As System.EventArgs) Handles BtnDate2.Click
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

  Private Sub BtnDate4_Click(sender As System.Object, e As System.EventArgs) Handles BtnDate4.Click
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

  Private Sub MonthCalendar1_DateSelected(sender As Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
    Select Case calendar_open

      Case "txtDtCreaDu"
        txtDtCreaDu.Text = MonthCalendar1.SelectionStart.Date
      Case "txtDtCreaAu"
        txtDtCreaAu.Text = MonthCalendar1.SelectionStart.Date
      Case "txtDtExecDu"
        txtDtExecDu.Text = MonthCalendar1.SelectionStart.Date
      Case "txtDtExecAu"
        txtDtExecAu.Text = MonthCalendar1.SelectionStart.Date

    End Select

    MonthCalendar1.Visible = False
  End Sub

  Private Sub BtValider_Click(sender As System.Object, e As System.EventArgs) Handles BtValider.Click
    MonthCalendar1.Visible = False
    If Date.Parse(txtDtCreaAu.Text) >= Date.Parse(txtDtCreaDu.Text) And Date.Parse(txtDtExecAu.Text) >= Date.Parse(txtDtExecAu.Text) Then
      ChargeListe()
    Else
      MsgBox(My.Resources.GestionMPT_frmNBTransfDevis_date_incorrectes, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, My.Resources.Global_Erreur_maj)
    End If
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\ExportNBDevisExec_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCStat.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub
End Class