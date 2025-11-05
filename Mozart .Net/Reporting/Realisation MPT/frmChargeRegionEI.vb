Imports System.Data.SqlClient
Imports MozartLib

Public Class frmChargeRegionEI

  Dim CnxAux As New CGestionSQL

  Private Sub frmChargeRegionEI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Dim annee As Integer = Today.Year
    For i = 0 To 5
      ComboBoxAnnees.Items.Add(annee)
      annee = annee - 1
    Next i
    ComboBoxAnnees.SelectedIndex = 1   ' Année N - 1, par défaut

    If CnxAux.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = False Then
      MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

    chargeDonnees()

  End Sub

  Private Sub chargeDonnees()

    Dim ds As DataSet

    Me.Cursor = Cursors.WaitCursor

    Try

      ds = New DataSet

      Dim cmdLoadList As New SqlCommand("api_sp_CA_EI_Region2", CnxAux.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure
      cmdLoadList.CommandTimeout = 0
      cmdLoadList.Parameters.Add("@annee", SqlDbType.Int).Value = ComboBoxAnnees.SelectedItem

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(ds)

      ' Données par client et région
      GCRECEPTIONS.DataSource = ds.Tables(0)

      ' Données par région
      Dim dtr As DataRow
      Dim lstRegions As New List(Of String)
      Dim lstCA As New List(Of Double)

      For Each dtr In ds.Tables(1).Rows
        lstRegions.Add(dtr("REGION").ToString)
        lstCA.Add(dtr("CA"))
      Next

      ' CA total
      dtr = ds.Tables(2).Rows(0)
      Dim CA_total As Double = dtr("CA")

      lblPourcAlsace.Text = alimentePourcentages(My.Resources.Global_alsace, CA_total, lstRegions, lstCA) & "%"
      lblPourcAquitaine.Text = alimentePourcentages(My.Resources.Global_aquitaine, CA_total, lstRegions, lstCA) & "%"
      lblPourcAuvergne.Text = alimentePourcentages(My.Resources.Global_auvergne, CA_total, lstRegions, lstCA) & "%"
      lblPourcBourgogne.Text = alimentePourcentages(My.Resources.Global_bourgogne, CA_total, lstRegions, lstCA) & "%"
      lblPourcBretagne.Text = alimentePourcentages(My.Resources.Global_bretagne, CA_total, lstRegions, lstCA) & "%"
      lblPourcCentre.Text = alimentePourcentages(My.Resources.Global_centre, CA_total, lstRegions, lstCA) & "%"
      lblPourcCorse.Text = alimentePourcentages(My.Resources.Global_corse, CA_total, lstRegions, lstCA) & "%"
      lblPourcIDF.Text = alimentePourcentages(My.Resources.Global_france, CA_total, lstRegions, lstCA) & "%"
      lblPourcLanguedoc.Text = alimentePourcentages(My.Resources.Global_languedoc, CA_total, lstRegions, lstCA) & "%"
      lblPourcNord.Text = alimentePourcentages(My.Resources.Global_nord, CA_total, lstRegions, lstCA) & "%"
      lblPourcNormandie.Text = alimentePourcentages(My.Resources.Global_normandie, CA_total, lstRegions, lstCA) & "%"
      lblPourcPaysLoire.Text = alimentePourcentages(My.Resources.Global_pays, CA_total, lstRegions, lstCA) & "%"
      lblPourcProvence.Text = alimentePourcentages(My.Resources.Global_provence, CA_total, lstRegions, lstCA) & "%"

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmChargeRegionEI_Sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Function alimentePourcentages(region As String, CATotal As Double, lstRegions As List(Of String), lstCA As List(Of Double)) As Double

    Dim pourc As Double = 0

    For i = 0 To lstRegions.Count - 1
      If lstRegions(i).ToUpper().Contains(region.ToUpper()) Then
        pourc = Math.Round(lstCA(i) / CATotal * 100, 2)
        Exit For
      End If
    Next i

    Return pourc

  End Function

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    GCRECEPTIONS.Print()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\EI_ChargeRegionFrance_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCRECEPTIONS.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    chargeDonnees()
  End Sub

  Private Sub GridView1_EndSorting(sender As Object, e As System.EventArgs) Handles GridView1.EndSorting
    GridView1.MoveFirst()
  End Sub
End Class