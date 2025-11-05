Imports System.Data.SqlClient
Imports MozartLib

Public Class frmStatMargeChaff

  Public mstrTypeStat As String
  Dim calendar_open As String

  Public Sub New(ByVal p_Param As Object)
    InitializeComponent()
    mstrTypeStat = p_Param
  End Sub

  Private Sub frmStatMargeChaff_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    If mstrTypeStat = "CAN" Then
      txtDtDebut.Text = Today.Date.AddMonths(-12)
      txtDtFin.Text = Today.Date
      LblTitre.Text = My.Resources.GestionMPT_frmStatMargeChaff_statistique_compte
      GVStat.Columns.ColumnByName("GridColumn1").Caption = "Cpt ana"
      GVStat.Columns.ColumnByName("GridColumn1").Width = 160
      GVStat.Columns.ColumnByName("GridColumn1").FieldName = "CPTANA"
      ChartControl1.Series(0).ArgumentDataMember = "CPTANA"

      LblPerimetre.Text = "Seulement les comptes analytiques > 30 000 € sur les 12 derniers mois glissants"

    ElseIf mstrTypeStat = "CLI" Then
      txtDtDebut.Text = Today.Date.AddMonths(-12)
      txtDtFin.Text = Today.Date
      LblTitre.Text = My.Resources.GestionMPT_frmStatMargeChaff_statistique_client
      GVStat.Columns.ColumnByName("GridColumn1").Caption = My.Resources.Global_CLient
      GVStat.Columns.ColumnByName("GridColumn1").Width = 120
      GVStat.Columns.ColumnByName("GridColumn1").FieldName = "VCLINOM"
      ChartControl1.Series(0).ArgumentDataMember = "VCLINOM"

      LblPerimetre.Text = "Seulement les clients avec un chiffre d'affaires > 50 000 € sur les 12 derniers mois glissants"

    Else ' "CHAFF"
      txtDtDebut.Text = "01/01/" & Today.Year
      txtDtFin.Text = Today.Date
      LblTitre.Text = My.Resources.GestionMPT_frmStatMargeChaff_statistique_chaff
      GVStat.Columns.ColumnByName("GridColumn1").Caption = "Chaff"
      GVStat.Columns.ColumnByName("GridColumn1").Width = 120
      GVStat.Columns.ColumnByName("GridColumn1").FieldName = "VPERNOM"
      ChartControl1.Series(0).ArgumentDataMember = "VPERNOM"
    End If

    ChargeListe()

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtValider_Click(sender As System.Object, e As System.EventArgs) Handles BtValider.Click
    ChargeListe()
  End Sub

  Private Sub ChargeListe()
    Try

      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_StatMargeChaff", MozartDatabase.cnxMozart)
      CmdSql.CommandType = CommandType.StoredProcedure
      CmdSql.Parameters.Add("@TypeStat", SqlDbType.VarChar).Value = mstrTypeStat
      CmdSql.Parameters.Add("@dateDebut", SqlDbType.DateTime).Value = txtDtDebut.Text
      CmdSql.Parameters.Add("@dateFin", SqlDbType.DateTime).Value = txtDtFin.Text

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
      Dim dtStat As New DataSet
      sqlAdpat.Fill(dtStat)

      GCStat.DataSource = dtStat.Tables(0)
      ChartControl1.DataSource = dtStat.Tables(0)

      CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show("Sub ChargeListe() frmStatMargeChaff : " + ex.Message, My.Resources.Global_Erreur)
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

  Private Sub GVStat_EndSorting(sender As Object, e As System.EventArgs) Handles GVStat.EndSorting
    GVStat.MoveFirst()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub
End Class