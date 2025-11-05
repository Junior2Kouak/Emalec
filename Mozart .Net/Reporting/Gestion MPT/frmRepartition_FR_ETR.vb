Imports System.Data.SqlClient
Imports MozartLib

Public Class frmRepartition_FR_ETR

  Dim calendar_open As String

  Private Sub frmRepartition_FR_ETR_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try
      txtDtDebut.Text = "01/" & Format(Today.Month, "00") & "/" & Today.Year - 1
      txtDtFin.Text = DateAdd(DateInterval.Day, -1, DateValue("01/" & Format(Today.Month, "00") & "/" & Today.Year))

      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("select npernum, vpernom + ' ' + vperpre as NOM from tper where cpertyp = 'CA' and cperactif = 'O' and vsociete = '" & MozartParams.NomSociete & "' union select 0, ' TOUS CHAFF' as NOM order by NOM", MozartDatabase.cnxMozart)
      Dim dtCbo As New DataTable
        dtCbo.Load(CmdSql.ExecuteReader)
        cboCHAFF.DataSource = dtCbo
        CmdSql.Dispose()
        cboCHAFF.SelectedValue = 622 ' BONNARD David par défaut...

        ChargeListe()

    Catch ex As Exception
      MessageBox.Show(My.Resources.GestionMPT_frmRepartitionFR_sub1 + ex.Message, My.Resources.Global_Erreur)
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

  Private Sub BtValider_Click(sender As System.Object, e As System.EventArgs) Handles BtValider.Click

    ChargeListe()

  End Sub

  Sub ChargeListe()

    Try

      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_CA_France_International", MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.CommandTimeout = 0
        CmdSql.Parameters.Add("@NPERNUM", SqlDbType.Int).Value = cboCHAFF.SelectedValue
        CmdSql.Parameters.Add("@DtDebut", SqlDbType.DateTime).Value = txtDtDebut.Text
        CmdSql.Parameters.Add("@DtFin", SqlDbType.DateTime).Value = txtDtFin.Text

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GCStat.DataSource = dtStat.Tables(0)
        ChartControl1.DataSource = dtStat.Tables(1)
        ChartControl1.Titles(0).Text = My.Resources.GestionMPT_frmRepartitionFR_repartition & cboCHAFF.Text

        CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show("Sub ChargeListe() frmRepartition_FR_ETR :" + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub GVStat_EndSorting(sender As Object, e As System.EventArgs) Handles GVStat.EndSorting
    GVStat.MoveFirst()
  End Sub

  Private Sub GCStat_DoubleClick(sender As Object, e As System.EventArgs) Handles GCStat.DoubleClick

    ' Graph par détail client
    Dim nclinum As String
    Dim vclinom As String

    Try
      ' On récupère le n° unique NCLINUM sélectionné dans la liste
      Dim ligne_selectionnee As Integer() = GVStat.GetSelectedRows()
      nclinum = GVStat.GetRowCellValue(ligne_selectionnee.ElementAt(0), "nclinum").ToString
      vclinom = GVStat.GetRowCellValue(ligne_selectionnee.ElementAt(0), "vclinom").ToString
    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.GestionMPT_frmRepartitionFR_graph, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End Try

    Try
      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_CA_France_InternationalDetail", MozartDatabase.cnxMozart)
      CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.Parameters.Add("@NPERNUM", SqlDbType.VarChar).Value = cboCHAFF.SelectedValue
        CmdSql.Parameters.Add("@NCLINUM", SqlDbType.VarChar).Value = nclinum
        CmdSql.Parameters.Add("@DtDebut", SqlDbType.DateTime).Value = txtDtDebut.Text
        CmdSql.Parameters.Add("@DtFin", SqlDbType.DateTime).Value = txtDtFin.Text

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        ChartControl1.DataSource = dtStat.Tables(0)
        ChartControl1.Titles(0).Text = My.Resources.GestionMPT_frmRepartitionFR_repartition & vclinom

        CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show("Sub GCStat_Click() frmRepartition_FR_ETR : " + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    GCStat_DoubleClick(sender, e)
  End Sub
End Class