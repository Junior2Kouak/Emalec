Imports System.Data.SqlClient
Imports MozartLib

Public Class frmReportingFacturation

  Dim calendar_open As String

  Private Sub frmReportingFacturation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try
      txtDtDebut.Text = "01/" & Format(Today.Month, "00") & "/" & Today.Year - 1
      txtDtFin.Text = DateAdd(DateInterval.Day, -1, DateValue("01/" & Format(Today.Month, "00") & "/" & Today.Year))

      Me.Cursor = Cursors.WaitCursor

      initSociete()

      ComboSociete.SelectedIndex = 0

      'cboClient.DataSource = ListeClientCbo()

      ChargeListe()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Facturation_Reportingfacturation_Sub1 + ex.Message, My.Resources.Global_Erreur)
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

  Private Sub initSociete()
    'initialisation de le combobox "Société"
    Dim i As Integer = 0

    If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

      Dim CmdSql As New SqlCommand("SELECT DISTINCT VSOCIETE FROM TDROIT WHERE NPERNUM = " & MozartParams.UID & " AND NMENUNUM = " & ComboSociete.Tag & " AND CDROITVAL = 'O' ORDER BY VSOCIETE", MozartDatabase.cnxMozart)
      Dim dr As SqlDataReader = CmdSql.ExecuteReader
      While dr.Read() 'While données présentes, stocker les éléments en combobox
        ComboSociete.Items.Add(dr("VSOCIETE"))
        i = i + 1
      End While

      If i > 1 Then
        ' Plusieurs société : on peut gérer le "groupe"
        ComboSociete.Items.Insert(0, My.Resources.Reporting_Facturation_Reportingfacturation_toute_societes)
        ComboSociete.Visible = True
      End If

      dr.Close()
      CmdSql.Dispose()
      dr = Nothing

    End If

  End Sub

  Private Sub BtValider_Click(sender As System.Object, e As System.EventArgs) Handles BtValider.Click

    ChargeListe()

  End Sub

  Public Function ListeClientCbo(ByVal p_NomSociete As String) As DataTable

    Try

      Dim dtLstClient As New DataTable

      Dim sSQL As String
      If p_NomSociete = My.Resources.Reporting_Facturation_Reportingfacturation_toute_societes Then
        sSQL = "SELECT NCLINUM, VCLINOM + ' (' + VSOCIETE + ')' AS VCLINOM FROM TCLI WHERE CCLIACTIF = 'O' UNION SELECT 0, ' TOUS CLIENTS' ORDER BY VCLINOM"
      Else
        sSQL = String.Format("SELECT NCLINUM, VCLINOM FROM TCLI WHERE VSOCIETE = '{0}' AND CCLIACTIF = 'O' UNION SELECT 0, ' TOUS CLIENTS' ORDER BY VCLINOM", p_NomSociete)
      End If


      Dim sqlcmdGTPClientLst As New SqlCommand(sSQL, MozartDatabase.cnxMozart)

      dtLstClient.Load(sqlcmdGTPClientLst.ExecuteReader)

      Return dtLstClient

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_Facturation_Reportingfacturation_Sub2 + ex.Message)
      Return Nothing

    End Try

  End Function

  Sub ChargeListe()

    Try

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_ReportingFacturation", MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.CommandTimeout = 0
        CmdSql.Parameters.Add("@DtDebut", SqlDbType.DateTime).Value = txtDtDebut.Text
        CmdSql.Parameters.Add("@DtFin", SqlDbType.DateTime).Value = txtDtFin.Text
        CmdSql.Parameters.Add("@nclient", SqlDbType.Int).Value = cboClient.SelectedValue

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GCStat.DataSource = dtStat.Tables(0)
        ChartControl1.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Facturation_Reportingfacturation_Sub3 + ex.Message, My.Resources.Global_Erreur)
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

  Private Sub ComboSociete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboSociete.SelectedIndexChanged

    If ComboSociete.SelectedItem.ToString <> "" Then cboClient.DataSource = ListeClientCbo(ComboSociete.SelectedItem.ToString)

  End Sub
End Class