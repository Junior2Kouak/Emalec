Imports System.Data.SqlClient
Imports MozartLib

Public Class frmReportingGeographique

  Dim CnxAux As New CGestionSQL

  Private Sub frmReportingGeographique_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Dim dt, dt2 As DataTable

    Label1.Text = My.Resources.Reporting_RealisationMPT_frmReportingGeographique_Reporting & MozartParams.NomSociete & My.Resources.Global_le & Date.Today

    Me.Cursor = Cursors.WaitCursor

    Try

      If CnxAux.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = False Then
        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

      dt = New DataTable
      Dim cmdLoadList As New SqlCommand("SELECT CPRECOD, VPRELIB FROM TREF_PRE where langue = 'FR' union SELECT '', ' TOUTES' order by VPRELIB", CnxAux.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.Text
      dt.Load(cmdLoadList.ExecuteReader)
      ComboBoxPrest.DataSource = dt

      dt2 = New DataTable
      Dim cmdLoadList2 As New SqlCommand("SELECT CTECCOD, VTECLIB FROM TREF_TEC where langue = 'FR' union SELECT '', ' TOUTES' order by VTECLIB", CnxAux.CnxSQLOpen)
      cmdLoadList2.CommandType = CommandType.Text
      dt2.Load(cmdLoadList2.ExecuteReader)
      ComboBoxTech.DataSource = dt2

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmReportingGeographique_Sub2 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
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

  Private Sub GridView1_EndSorting(sender As Object, e As System.EventArgs) Handles GridView1.EndSorting
    GridView1.MoveFirst()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    GCRECEPTIONS.Print()
  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\ReportingGeographiqueFrance_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCRECEPTIONS.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

    ' Remplir le tableau + initialiser les données sur la carte
    Dim ds As DataSet

    Me.Cursor = Cursors.WaitCursor

    Try

      ds = New DataSet

      Dim cmdLoadList As New SqlCommand("api_sp_Reporting_Geographique_Region", CnxAux.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure
      cmdLoadList.Parameters.Add("@CPRECOD", SqlDbType.Char).Value = ComboBoxPrest.SelectedValue
      cmdLoadList.Parameters.Add("@CTECCOD", SqlDbType.Char).Value = ComboBoxTech.SelectedValue

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
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmReportingGeographique_Sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

End Class