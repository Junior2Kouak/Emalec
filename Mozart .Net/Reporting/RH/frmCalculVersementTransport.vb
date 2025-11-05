Imports System.Data.SqlClient
Imports MozartLib

Public Class frmCalculVersementTransport

  Private Sub frmCalculVersementTransport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    RemplirCombo()

    CboMois.EditValue = Today.Month
    CboAnnee.EditValue = Today.Year

    chargeListe()

    GridControl1.Focus()

  End Sub

  Private Sub chargeListe()
    Try

      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_StatVersementTransport", MozartDatabase.cnxMozart)
      CmdSql.CommandType = CommandType.StoredProcedure
      CmdSql.Parameters.Add("@mois", SqlDbType.VarChar).Value = CboMois.EditValue
      CmdSql.Parameters.Add("@annee", SqlDbType.Int).Value = CboAnnee.EditValue

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
      Dim dtStat As New DataSet
      sqlAdpat.Fill(dtStat)

      GridControl1.DataSource = dtStat.Tables(0)

      Dim lstAnalyseTech As New List(Of String)
      Dim lstAnalyseRegion As New List(Of String)
      Dim lstAnalyseCompteur As New List(Of Integer)

      'Analyse du DataSet
      For Each Ligne As DataRow In dtStat.Tables(0).Rows()
        If Not lstAnalyseRegion.Contains(Ligne("REGION").ToString) Then
          lstAnalyseRegion.Add(Ligne("REGION").ToString)
          lstAnalyseCompteur.Add(0)
        End If

        If Ligne("POURCENTAGEREGION").ToString <> "" Then
          If Double.Parse(Ligne("POURCENTAGEREGION").ToString) > 50 Then

            ' Donnée comptabilisée
            If Not lstAnalyseTech.Contains(Ligne("NOM").ToString) Then
              lstAnalyseTech.Add(Ligne("NOM").ToString)
              Dim index As Integer = lstAnalyseRegion.IndexOf(Ligne("REGION").ToString)
              lstAnalyseCompteur.Item(index) = lstAnalyseCompteur.ElementAt(index) + 1
            End If

          End If
        End If
      Next

      LabelInfo1.Text = My.Resources.Reporting_RH_frmCalculVersementTransport_analyse & CboMois.Text & " " & CboAnnee.Text & " :"
      txtAnalyse.Text = ""
      For cpt = 0 To lstAnalyseCompteur.Count - 1
        txtAnalyse.Text = txtAnalyse.Text & My.Resources.Reporting_RH_frmCalculVersementTransport_region & lstAnalyseRegion.ElementAt(cpt) & " :  E = " & lstAnalyseCompteur.ElementAt(cpt) & vbCrLf & vbCrLf
      Next



      CmdSql.Dispose()

      GridView1.Columns.ColumnByName(My.Resources.Global_pourcentage).Caption = My.Resources.Reporting_RH_frmCalculVersementTransport_pourcentage_zone & CboMois.Text & " " & CboAnnee.Text.ToString.Substring(2, 2)
      GridView1.Columns.ColumnByName(My.Resources.Reporting_RH_frmCalculVersementTransport_pourcentage_region).Caption = My.Resources.Reporting_RH_frmCalculVersementTransport_pourc_region & CboMois.Text & " " & CboAnnee.Text.ToString.Substring(2, 2)

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RH_frmCalculVersementTransport_sub + ex.Message, My.Resources.Global_Erreur)
        Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub
  Private Sub RemplirCombo()

    Dim i As Integer

    Dim dtMois As New DataTable
    Dim dtAnnee As New DataTable

    dtMois.Columns.Add("NIDMOIS", Type.GetType("System.Int32"))
    dtMois.Columns.Add("SMOISNAME", Type.GetType("System.String"))

    dtAnnee.Columns.Add("NIDANNEE", Type.GetType("System.Int32"))

    i = 0
    For i = 0 To 11

      'CboMois.Properties.Items.Add(New CDateMonth(i + 1, MonthName(i + 1)))
      Dim drnew As DataRow = dtMois.NewRow
      drnew.Item("NIDMOIS") = i + 1
      drnew.Item("SMOISNAME") = MonthName(i + 1)

      dtMois.Rows.Add(drnew)

    Next

    CboMois.Properties.DataSource = dtMois

    For i = 0 To 5

      Dim drnew As DataRow = dtAnnee.NewRow
      drnew.Item("NIDANNEE") = Year(DateAdd("yyyy", -i, Now))
      dtAnnee.Rows.Add(drnew)

    Next

    CboAnnee.Properties.DataSource = dtAnnee

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnValider_Click(sender As System.Object, e As System.EventArgs) Handles BtnValider.Click
    If CboMois.EditValue.ToString <> "" And CboAnnee.EditValue.ToString <> "" Then
      chargeListe()
    End If
  End Sub

  Private Sub GridView1_EndSorting(sender As Object, e As System.EventArgs) Handles GridView1.EndSorting
    GridView1.MoveFirst()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\ExportVersementTransport_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GridControl1.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub
End Class