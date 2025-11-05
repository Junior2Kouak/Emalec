Imports System.Data.SqlClient
Imports MozartLib

Public Class frmChargeTechsParCompetences

  Dim CnxAux As New CGestionSQL

  Private Sub frmChargeTechsParCompetences_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    LabelTitre.Text = LabelTitre.Text & My.Resources.Global_le & "  " & Date.Today & " , " & MozartParams.NomSociete

    Dim dtJ As Date = Date.Today.AddMonths(-12)

    ' Entêtes de colonnes :
    For i = 1 To 12
      GridView1.Columns.ColumnByName(My.Resources.Global_mois_min & i).Caption = Format(dtJ, "MM") & "/" & dtJ.Year.ToString.Substring(2, 2)
      dtJ = dtJ.AddMonths(1)
    Next i

    Try

      If CnxAux.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = False Then
        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

      Dim ds As New DataSet

      Dim cmdLoadList As New SqlCommand("api_sp_ChargeTechsParCompetences", CnxAux.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure
      cmdLoadList.Parameters.Add("@societe", SqlDbType.VarChar).Value = MozartParams.NomSociete

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(ds)

      GCRECEPTIONS.DataSource = ds.Tables(0)
      Chart1.DataSource = ds.Tables(1)

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmChargeTechsParComptetence_sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\ChargeTechsParCompetences_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCRECEPTIONS.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub
End Class