Imports System.Data.SqlClient
Imports MozartLib

Public Class frmDevisNombreParCreateur

  Dim calendar_open As String = ""

  Private Sub frmDevisNombreParCreateur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    txtDtCreaDu.Text = Date.Today.AddYears(-1)
    txtDtCreaAu.Text = Date.Today

    lblDateDu.Text = Date.Today.AddYears(-1)
    lblDateAu.Text = Date.Today

    initSociete()
    ChargeListe()

  End Sub

  Private Sub initSociete()
    'initialisation de le combobox "Société"
    Dim i As Integer = 0

    If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

      Dim CmdSql As New SqlCommand(String.Format("SELECT DISTINCT VSOCIETE FROM TDROIT WHERE NPERNUM = {0} AND NMENUNUM = {1} AND CDROITVAL = 'O' ORDER BY VSOCIETE", MozartParams.UID, cboSociete.Tag), MozartDatabase.cnxMozart)
      Dim dr As SqlDataReader = CmdSql.ExecuteReader
      While dr.Read() 'While données présentes, stocker les éléments en combobox
        cboSociete.Items.Add(dr("VSOCIETE"))
        i = i + 1
      End While

      If i > 1 Then
        ' Plusieurs société : on peut gérer le "groupe"
        cboSociete.Items.Add("GROUPE")
        cboSociete.SelectedItem = MozartParams.NomSociete
        Label2.Visible = True
        cboSociete.Visible = True
      Else
        cboSociete.SelectedIndex = 0
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

        Dim CmdSql As New SqlCommand("api_sp_DevisNombreParCreateur", MozartDatabase.cnxMozart) With {.CommandType = CommandType.StoredProcedure}
        CmdSql.Parameters.Add("@DateDeb", SqlDbType.DateTime).Value = txtDtCreaDu.Text
        CmdSql.Parameters.Add("@DateFin", SqlDbType.DateTime).Value = txtDtCreaAu.Text
        CmdSql.Parameters.Add("@Societe", SqlDbType.VarChar).Value = cboSociete.Text
        CmdSql.Parameters.Add("@NumMenu", SqlDbType.Int).Value = cboSociete.Tag

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GCStat.DataSource = dtStat.Tables(0)
        ChartControl1.DataSource = dtStat.Tables(0)


        CmdSql.Dispose()

      End If

    Catch ex As Exception
      MessageBox.Show("Sub frmDevisNombreParCreateur.ChargeListe() frmDevisNombreParCreateur : " + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub BtnCalendar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalendar1.Click

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

  Private Sub BtnCalendar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalendar2.Click

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


  Private Sub MonthCalendar1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
    Select Case calendar_open

      Case "txtDtCreaDu"
        txtDtCreaDu.Text = MonthCalendar1.SelectionStart.Date
        lblDateDu.Text = MonthCalendar1.SelectionStart.Date
      Case "txtDtCreaAu"
        txtDtCreaAu.Text = MonthCalendar1.SelectionStart.Date
        lblDateAu.Text = MonthCalendar1.SelectionStart.Date
      Case Else
        Exit Select
    End Select

    MonthCalendar1.Visible = False
  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub BtValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtValider.Click

    ChargeListe()

  End Sub

End Class