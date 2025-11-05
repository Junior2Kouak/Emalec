Imports System.Data.SqlClient
Imports MozartLib

Public Class frmReportingAchatsFourniture

  Dim calendar_open As String

  Private Sub frmReportingAchatsFourniture_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    initSociete()

    ComboBox1.SelectedIndex = 0

    txtDtCreaDu.Text = Date.Today.AddMonths(-2).AddDays((Today.Day - 1) * -1)
    txtDtCreaAu.Text = Date.Today.AddDays(Today.Day * -1)

    lblDateJour.Text = My.Resources.Global_le & Date.Today

    ' TB SAMSIC CITY RES
    'lblGroupeEMALEC.Text += gstrNomGroupe

    ChargeListe()

  End Sub

  Private Sub initSociete()
    'initialisation de le combobox "Société"
    Dim i As Integer = 0

    If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

      Dim CmdSql As New SqlCommand("SELECT DISTINCT VSOCIETE FROM TDROIT WHERE NPERNUM = " & MozartParams.UID & " AND NMENUNUM = " & ComboBox1.Tag & " AND CDROITVAL = 'O' ORDER BY VSOCIETE", MozartDatabase.cnxMozart)
      Dim dr As SqlDataReader = CmdSql.ExecuteReader
      While dr.Read() 'While données présentes, stocker les éléments en combobox
        ComboBox1.Items.Add(dr("VSOCIETE"))
        i = i + 1
      End While

      If i > 1 Then
        ' Plusieurs société : on peut gérer le "groupe"
        ComboBox1.Items.Insert(0, My.Resources.Reporting_Facturation_frmStatFacturationCa_toutesociété)
        ComboBox1.SelectedItem = MozartParams.NomSociete
        ComboBox1.Visible = True
      End If

      dr.Close()
      CmdSql.Dispose()
      dr = Nothing

    End If

  End Sub

  Private Sub ChargeListe()
    Try

      Me.Cursor = Cursors.WaitCursor

      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_ReportingAchatFourniture", MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.Parameters.Add("@dtDebut", SqlDbType.DateTime).Value = txtDtCreaDu.Text
        CmdSql.Parameters.Add("@dtFin", SqlDbType.DateTime).Value = txtDtCreaAu.Text
        CmdSql.Parameters.Add("@numMenu", SqlDbType.Int).Value = ComboBox1.Tag
        CmdSql.Parameters.Add("@Societe", SqlDbType.VarChar).Value = ComboBox1.Text

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        lblGroupeEMALEC.Text = ComboBox1.Text

        GCStat.DataSource = dtStat.Tables(0)

        ' cas particulier Adjout pas voir colonne 3 et 4 
        '2473
        If (MozartParams.strUID = "ADJOUT" Or MozartParams.strUID = "DUPERDU") Then
          GVStat.Columns(3).Visible = False
          GVStat.Columns(4).Visible = False
        End If

        CmdSql.Dispose()

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_achat_frmReportingAchatsFourniture_sub + ex.Message, My.Resources.Global_Erreur)
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
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\ExportReportingAchatsFournitures_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCStat.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub GVStat_EndSorting(sender As Object, e As System.EventArgs) Handles GVStat.EndSorting
    GVStat.MoveFirst()
  End Sub

  Private Sub BtValider_Click(sender As System.Object, e As System.EventArgs) Handles BtValider.Click
    ChargeListe()
  End Sub
End Class