Imports System.Data.SqlClient
Imports MozartLib

Public Class frmStatFacturationParPersonne

  Private typeStat As String

  Public Sub New(sparam As String)
    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    typeStat = sparam
  End Sub

  Private Sub frmStatFacturationParPersonne_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    apiSocieteAuto1.Init(MozartDatabase.cnxMozart, MozartParams.NomSociete)

    txtDateDebut.Text = "01/" & Format(Today.Month, "00") & "/" & Today.Year - 1
    txtDateFin.Text = DateAdd(DateInterval.Day, -1, DateValue("01/" & Format(Today.Month, "00") & "/" & Today.Year))

    If typeStat = "Nombre" Then
      lblPerim.Text = My.Resources.Reporting_Facturation_frmStatFacturationParPersonne_stat & vbCrLf _
                  & My.Resources.Reporting_Facturation_frmStatFacturationParPersonne_Ex & vbCrLf _
                  & My.Resources.Reporting_Facturation_frmStatFacturationParPersonne_CompteDi
      Me.Text = My.Resources.Reporting_Facturation_frmStatFacturationParPersonne_nbr_Factu
    Else
      lblPerim.Text = My.Resources.Reporting_Facturation_frmStatFacturationParPersonne_nbr_select & vbCrLf _
                  & My.Resources.Reporting_Facturation_frmStatFacturationParPersonne_CompteDi
      Me.Text = My.Resources.Reporting_Facturation_frmStatFacturationParPersonne_montant_factu
    End If

    ChargeListe()
  End Sub

  Private Sub ChargeListe()
    Try
      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_StatistiqueFactureV2", MozartDatabase.cnxMozart) With {
          .CommandType = CommandType.StoredProcedure
        }
        CmdSql.Parameters.Add("@dateDebut", SqlDbType.DateTime).Value = txtDateDebut.Text
        CmdSql.Parameters.Add("@dateFin", SqlDbType.DateTime).Value = txtDateFin.Text
        CmdSql.Parameters.Add("@societe", SqlDbType.VarChar).Value = apiSocieteAuto1.Text
        CmdSql.Parameters.Add("@typeStat", SqlDbType.VarChar).Value = typeStat

        Dim sqlAdpat As New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        ChartControl1.DataSource = dtStat.Tables(0)

        If typeStat = "Nombre" Then
          LblTitre.Text = My.Resources.Reporting_Facturation_frmStatFacturationParPersonne_nbr_factu_perso & " " & txtDateDebut.Text & " " &
                  My.Resources.Global_au & " " & txtDateFin.Text & " " & My.Resources.Global_pour_société & " " & apiSocieteAuto1.Text & " " & My.Resources.Global_le & " " & Today.Date
        Else
          LblTitre.Text = My.Resources.Reporting_Facturation_frmStatFacturationParPersonne_montant_factu_du & " " & txtDateDebut.Text & " " &
                  My.Resources.Global_au & " " & txtDateFin.Text & " " & My.Resources.Global_pour_société & " " & apiSocieteAuto1.Text & " " & My.Resources.Global_le & " " & Today.Date
        End If

        CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatFacturationParPersonne_sub + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

  Private Sub BtValider_Click(sender As System.Object, e As System.EventArgs) Handles BtValider.Click
    ChargeListe()
  End Sub
End Class