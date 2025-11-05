Imports System.Data.SqlClient
Imports System.Text
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class frmGestionServicesTechniques

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub FrmGestionServicesTechniques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Initboutons(Me)

    load_Data_in_the_Grid()

  End Sub

  Private Sub load_Data_in_the_Grid()
    Try

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("SELECT * FROM api_v_ListeServTech ORDER BY VSERVTECHNOM", MozartDatabase.cnxMozart)

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GridControl1.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

        GridControl1.Focus()
      End If

    Catch ex As Exception
            MessageBox.Show(My.Resources.Admin_frmGestionServicesTechniques_Sub + ex.Message, My.Resources.Global_Erreur)
        Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub ButtonDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDetails.Click
    Try
      ' On récupère le n° unique NSERVTECHNUM sélectionné dans la liste
      Dim ligne_selectionnee As Integer() = GridView1.GetSelectedRows()
      Dim nservtechnum As String = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NSERVTECHNUM").ToString

      Dim oForm As New frmGestionServiceTechniqueDetails
      oForm.LabelNservtechnum.Text = nservtechnum
      oForm.ShowDialog()

      ' Nettoyage
      oForm = Nothing

      ' Raffraichir la liste
      load_Data_in_the_Grid()

    Catch ex As Exception
            MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
        End Try
    


  End Sub

  Private Sub ButtonAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAjouter.Click

    Dim oForm As New frmGestionServiceTechniqueDetails
    oForm.ShowDialog()

    ' Nettoyage
    oForm = Nothing

    ' Raffraichir la liste
    load_Data_in_the_Grid()

  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\LstSvceTech_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GridControl1.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub GridView1_EndSorting(sender As Object, e As System.EventArgs) Handles GridView1.EndSorting
    GridView1.MoveFirst()
  End Sub
End Class