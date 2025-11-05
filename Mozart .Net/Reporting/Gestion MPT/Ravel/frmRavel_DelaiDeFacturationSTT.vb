Imports System.Data.SqlClient
Imports MozartLib

Public Class frmRavel_DelaiDeFacturationSTT

  Dim CnxAux As New CGestionSQL

  Private Sub frmRavel_DelaiDeFacturationSTT_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Dim ds As DataSet

    Me.Cursor = Cursors.WaitCursor

    Try

      If CnxAux.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = False Then
        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

      ds = New DataSet

      Dim cmdLoadList As New SqlCommand("api_sp_StatRavelDelaisFactSTT", CnxAux.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(ds)

      GCRECEPTIONS.DataSource = ds.Tables(0)

      GCRECEPTIONS_Click(sender, e)

    Catch ex As Exception
      MessageBox.Show(My.Resources.GestionMPT_frmRavel_DelaiDeFacturationSTT_sub1 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    GCRECEPTIONS.Print()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\StatsRavelDelaiDeFacturation_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCRECEPTIONS.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub GridView1_EndSorting(sender As Object, e As System.EventArgs) Handles GridView1.EndSorting
    GridView1.MoveFirst()
  End Sub

  Private Sub GCRECEPTIONS_Click(sender As System.Object, e As System.EventArgs) Handles GCRECEPTIONS.Click
    Try
      ' On récupère le n° unique NSTFNUM sélectionné dans la liste
      Dim ligne_selectionnee As Integer() = GridView1.GetSelectedRows()
      Dim NSTFNUM As String = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "nstfnum").ToString

      chargeDetails(NSTFNUM)

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    End Try
  End Sub

  Private Sub chargeDetails(NSTFNUM As String)

    Dim CnxAuxDetails As New CGestionSQL
    Dim ds2 As DataSet

    Me.Cursor = Cursors.WaitCursor

    Try

      If CnxAuxDetails.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = False Then
        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

      ds2 = New DataSet

      Dim cmdLoadList As New SqlCommand("api_sp_StatRavelDelaisFactSTTDetails", CnxAuxDetails.CnxSQLOpen)
      cmdLoadList.Parameters.Add("@nstfnum", SqlDbType.Int).Value = NSTFNUM
      cmdLoadList.CommandType = CommandType.StoredProcedure

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(ds2)

      GridControl1.DataSource = ds2.Tables(0)

    Catch ex As Exception
      MessageBox.Show(My.Resources.GestionMPT_frmRavel_DelaiDeFacturationSTT_sub2 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

End Class