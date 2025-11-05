Imports System.Data.SqlClient
Imports MozartLib

Public Class frmStatTurnOver

  Private Sub frmStatTurnOver_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    apiSocieteAuto1.Init(MozartDatabase.cnxMozart, MozartParams.NomSociete)

    lblDateJour.Text = My.Resources.Global_le & " " & Date.Today

    lblPerim.Text = My.Resources.Reporting_RH_frmStatTurnOver_objectif & vbCrLf & My.Resources.Reporting_RH_frmStatTurnOver_calcul & vbCrLf & My.Resources.Reporting_RH_frmStatTurnOver_note

    ChargeListe()
  End Sub

  Private Sub ChargeListe()
    Try
      Dim CmdSql As New SqlCommand("api_sp_StatQualTurnOver", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      CmdSql.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = apiSocieteAuto1.Text

      Dim sqlAdapt As SqlDataAdapter = New SqlDataAdapter(CmdSql)
      Dim dtStat As New DataSet
      sqlAdapt.Fill(dtStat)

      Chart1.DataSource = dtStat.Tables(0)

      Dim nbSal As String = dtStat.Tables(1).Columns(0).Table(0).Item(0).ToString
      lblNbSalaries.Text = My.Resources.Reporting_RH_frmStatTurnOver_nbr_tot & nbSal

      CmdSql.Dispose()
    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RH_frmStatTurnOver_sub + ex.Message, My.Resources.Global_Erreur)
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
