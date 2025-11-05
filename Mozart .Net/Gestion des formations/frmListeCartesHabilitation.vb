
Imports System.Data.SqlClient
Imports MozartLib

Public Class frmListeCartesHabilitation

  Private Sub frmStatProductionAssistants_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    ChargeListe()

  End Sub

  Private Sub ChargeListe()
    Try

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_ListeCarteHabilitation", MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.StoredProcedure

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GCStat.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

      End If

    Catch ex As Exception
      MessageBox.Show("Sub frmListeCartesHabilitation.ChargeListe() frmListeCartesHabilitation : " + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub


  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\ExportCarteHabilitation_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCStat.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub GVStat_EndSorting(sender As Object, e As System.EventArgs)
    GVSTAT.MoveFirst()
  End Sub

  Private Sub GVStat_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GVSTAT.RowCellClick

    ' On teste la ligne
    Dim ligne_selectionnee As Integer() = GVSTAT.GetSelectedRows()
    Dim colonne As DevExpress.XtraGrid.Columns.GridColumn = GVSTAT.FocusedColumn()

    Dim NPERNUM As String

    If Not ligne_selectionnee Is Nothing And colonne.Caption <> "Employé" Then
      NPERNUM = GVSTAT.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NPERNUM").ToString
    Else
      Exit Sub
    End If

    ' renvoi vers le formulaire de modification de la carte d'habilitation
    Dim oFrmDetail As New frmGestHabilitation(NPERNUM)
    oFrmDetail.ShowDialog()

    ' rafraichir la liste si modifications
    'GCStat.
  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    ' On teste la ligne
    Dim ligne_selectionnee As Integer() = GVStat.GetSelectedRows()

    Dim NPERNUM As String

    If Not ligne_selectionnee Is Nothing Then
      NPERNUM = GVStat.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NPERNUM").ToString
    Else
      Exit Sub
    End If

    ' renvoi vers le formulaire de modification de la carte d'habilitation
    Dim oFrmDetail As New frmGestHabilitation(NPERNUM)
    oFrmDetail.ShowDialog()

  End Sub
End Class
