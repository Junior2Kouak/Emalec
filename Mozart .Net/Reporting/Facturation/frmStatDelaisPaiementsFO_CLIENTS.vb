Imports System.Data.SqlClient
Imports MozartLib

Public Class frmStatDelaisPaiementsFO_CLIENTS

  Private Sub frmStatDelaisPaiementsFO_CLIENTS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    txtDateDebut.Text = "01/" & Format(Today.Month, "00") & "/" & Today.Year - 1
    txtDateFin.Text = DateAdd(DateInterval.Day, -1, DateValue("01/" & Format(Today.Month, "00") & "/" & Today.Year))

    apiSocieteAuto1.Init(MozartDatabase.cnxMozart, MozartParams.NomSociete)
  End Sub

  Private Sub ChargeListe(typeRequete As String)
    Try
      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_StatDelaisPaiements", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure,
        .CommandTimeout = 0
      }
      CmdSql.Parameters.Add("@typeRequete", SqlDbType.Char).Value = typeRequete
      CmdSql.Parameters.Add("@DtDeb", SqlDbType.DateTime).Value = txtDateDebut.Text
      CmdSql.Parameters.Add("@DtFin", SqlDbType.DateTime).Value = txtDateFin.Text
      CmdSql.Parameters.Add("@societe", SqlDbType.VarChar).Value = apiSocieteAuto1.Text

      Dim sqlAdpat As New SqlDataAdapter(CmdSql)
      Dim dtStat As New DataSet

      sqlAdpat.Fill(dtStat)

      ' Possibilité d'exécuter unitairement, à voir plus tard si nécessaire...
      'Select Case typeRequete
      '  Case "F"
      '    ' Fournisseur ST
      '    GCStat.DataSource = dtStat.Tables(0)
      '    Chart1.DataSource = dtStat.Tables(1)
      '  Case "C"
      '    ' Client
      '    GridControl1.DataSource = dtStat.Tables(0)
      '    Chart2.DataSource = dtStat.Tables(1)
      '  Case "T"
      ' Tout
      GridControl1.DataSource = dtStat.Tables(0)
      Chart2.DataSource = dtStat.Tables(1)

      GCStat.DataSource = dtStat.Tables(2)
      Chart1.DataSource = dtStat.Tables(3)
      '  Case Else
      '    '
      'End Select

      CmdSql.Dispose()

      LblTitre.Text = My.Resources.Reporting_Facturation_frmStatDelaisPaiementsFo_Clients_Delai1 & " " & apiSocieteAuto1.Text & My.Resources.Global_le & " " & DateTime.Now.ToString("dd/MM/yyyy")
      lblTitre2.Text = My.Resources.Reporting_Facturation_frmStatDelaisPaiementsFo_Clients_Delai2 & " " & apiSocieteAuto1.Text & My.Resources.Global_le & " " & DateTime.Now.ToString("dd/MM/yyyy")
    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatDelaisPaiementsFo_Clients_sub + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)

    oScreenShot.Print_Form()
  End Sub

  Private Sub BtValider_Click(sender As System.Object, e As System.EventArgs) Handles BtValider.Click
    If apiSocieteAuto1.Text = "" Then Exit Sub

    ChargeListe("T")
  End Sub

  Private Sub GVStat_EndSorting(sender As Object, e As System.EventArgs) Handles GVStat.EndSorting
    GVStat.MoveFirst()
  End Sub

End Class
