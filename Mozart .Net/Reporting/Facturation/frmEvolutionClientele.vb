Imports System.Data.SqlClient
Imports MozartLib

Public Class frmEvolutionClientele

  Private Sub frmEvolutionClientele_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    apiSocieteAuto1.Init(MozartDatabase.cnxMozart, MozartParams.NomSociete)

    For year As Integer = Date.Today.Year - 8 To Date.Today.Year
      ComboBoxDe.Items.Add(year.ToString)
      ComboBoxA.Items.Add(year.ToString)
    Next year

    ComboBoxDe.SelectedIndex = 5
    ComboBoxA.SelectedIndex = 7

    ChargeListe()
  End Sub

  Private Sub ChargeListe()
    ' Chargement des données
    Try
      LblTitre.Text = My.Resources.Reporting_Facturation_frmEvolutionClientele_evo_client & " " & apiSocieteAuto1.Text & " " & My.Resources.Reporting_Facturation_frmEvolutionClientele_periode & " " & ComboBoxDe.Text & " " & My.Resources.Global_à & " " & ComboBoxA.Text & My.Resources.Global_le & " " & Date.Today
      lblTitre2.Text = My.Resources.Reporting_Facturation_frmEvolutionClientele_evo_client & " " & apiSocieteAuto1.Text & " " & My.Resources.Reporting_Facturation_frmEvolutionClientele_periode & " " & ComboBoxDe.Text & " " & My.Resources.Global_à & " " & ComboBoxA.Text & My.Resources.Global_le & " " & Date.Today
      lblTitre3.Text = My.Resources.Reporting_Facturation_frmEvolutionClientele_evo_facture

      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_StatEvolCli", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      CmdSql.Parameters.Add("@societe", SqlDbType.VarChar).Value = apiSocieteAuto1.Text
      CmdSql.Parameters.Add("@anneeMin", SqlDbType.Int).Value = ComboBoxDe.Text
      CmdSql.Parameters.Add("@anneeMax", SqlDbType.Int).Value = ComboBoxA.Text
      CmdSql.Parameters.Add("@numMenu", SqlDbType.Int).Value = apiSocieteAuto1.IdMenuParent

      Dim sqlAdpat As New SqlDataAdapter(CmdSql)
      Dim dtStat As New DataSet

      sqlAdpat.Fill(dtStat)

      GridControl2.DataSource = dtStat.Tables(0)

      GCStat.DataSource = dtStat.Tables(1)
    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Facturation_frmEvolutionClientele_sub + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    GCStat.Print()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\EvolutionClientele_" & Today.ToString("yyyyMMdd_") & TimeOfDay.ToString("HHmm") & ".xls"

    GCStat.ExportToXls(fileName)
    Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub BtValider_Click(sender As System.Object, e As System.EventArgs) Handles BtValider.Click
    ChargeListe()
  End Sub
End Class
