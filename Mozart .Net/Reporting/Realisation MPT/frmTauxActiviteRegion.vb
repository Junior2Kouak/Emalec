Imports System.Data.SqlClient
Imports MozartLib

Public Class frmTauxActiviteRegion


  Dim CnxAux As New CGestionSQL

  Private Sub frmReportingGeographique_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Dim dt2 As DataTable

    'Label1.Text = My.Resources.Reporting_RealisationMPT_frmReportingGeographique_Reporting & "  " & gstrNomSociete & My.Resources.Global_le & Date.Today

    Me.Cursor = Cursors.WaitCursor

    Try

      If CnxAux.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = False Then
        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

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

  Private Function alimentePourcentages(region As String, CATotal As Double, lstRegions As List(Of String), lstCA As List(Of Double)) As String

    Dim pourc As Double = 0

    For i = 0 To lstRegions.Count - 1
      If lstRegions(i).ToUpper().Contains(region.ToUpper()) Then
        pourc = lstCA(i)
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

      Dim cmdLoadList As New SqlCommand("api_sp_Reporting_Activite_Region", CnxAux.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure
      cmdLoadList.Parameters.Add("@CTECCOD", SqlDbType.Char).Value = ComboBoxTech.SelectedValue

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(ds)

      ' Données par région
      GCRECEPTIONS.DataSource = ds.Tables(0)

      ' Données par région
      Dim dtr As DataRow
      Dim lstRegions As New List(Of String)
      Dim lstCTR As New List(Of Double)
      Dim lstH As New List(Of Double)

      For Each dtr In ds.Tables(0).Rows
        lstRegions.Add(dtr("REGION").ToString)
        lstCTR.Add(dtr("NBCONTRATS"))
        lstH.Add(dtr("NBHEURES"))
      Next

      ' Contrat total
      dtr = ds.Tables(1).Rows(0)
      Dim CTR_total As Double = dtr("NBCONTRATSTOT")

      ' étiquettes du graphique pour les contrats
      lblPourcAlsace.Text = alimentePourcentages(My.Resources.Global_alsace, CTR_total, lstRegions, lstCTR)
      lblPourcAquitaine.Text = alimentePourcentages(My.Resources.Global_aquitaine, CTR_total, lstRegions, lstCTR)
      lblPourcAuvergne.Text = alimentePourcentages(My.Resources.Global_auvergne, CTR_total, lstRegions, lstCTR)
      lblPourcBourgogne.Text = alimentePourcentages(My.Resources.Global_bourgogne, CTR_total, lstRegions, lstCTR)
      lblPourcBretagne.Text = alimentePourcentages(My.Resources.Global_bretagne, CTR_total, lstRegions, lstCTR)
      lblPourcCentre.Text = alimentePourcentages(My.Resources.Global_centre, CTR_total, lstRegions, lstCTR)
      lblPourcIDF.Text = alimentePourcentages(My.Resources.Global_france, CTR_total, lstRegions, lstCTR)
      lblPourcLanguedoc.Text = alimentePourcentages(My.Resources.Global_languedoc, CTR_total, lstRegions, lstCTR)
      lblPourcNord.Text = alimentePourcentages(My.Resources.Global_nord, CTR_total, lstRegions, lstCTR)
      lblPourcNormandie.Text = alimentePourcentages(My.Resources.Global_normandie, CTR_total, lstRegions, lstCTR)
      lblPourcPaysLoire.Text = alimentePourcentages(My.Resources.Global_pays, CTR_total, lstRegions, lstCTR)
      lblPourcProvence.Text = alimentePourcentages(My.Resources.Global_provence, CTR_total, lstRegions, lstCTR)

      ' Heure  total
      Dim H_total As Double = dtr("NBHEURESTOT")

      ' etiquettes du graphique pour les heures
      lblPourcAlsaceH.Text = alimentePourcentages(My.Resources.Global_alsace, H_total, lstRegions, lstH)
      lblPourcAquitaineH.Text = alimentePourcentages(My.Resources.Global_aquitaine, H_total, lstRegions, lstH)
      lblPourcAuvergneH.Text = alimentePourcentages(My.Resources.Global_auvergne, H_total, lstRegions, lstH)
      lblPourcBourgogneH.Text = alimentePourcentages(My.Resources.Global_bourgogne, H_total, lstRegions, lstH)
      lblPourcBretagneH.Text = alimentePourcentages(My.Resources.Global_bretagne, H_total, lstRegions, lstH)
      lblPourcCentreH.Text = alimentePourcentages(My.Resources.Global_centre, H_total, lstRegions, lstH)
      lblPourcIDFH.Text = alimentePourcentages(My.Resources.Global_france, H_total, lstRegions, lstH)
      lblPourcLanguedocH.Text = alimentePourcentages(My.Resources.Global_languedoc, H_total, lstRegions, lstH)
      lblPourcNordH.Text = alimentePourcentages(My.Resources.Global_nord, H_total, lstRegions, lstH)
      lblPourcNormandieH.Text = alimentePourcentages(My.Resources.Global_normandie, H_total, lstRegions, lstH)
      lblPourcPaysLoireH.Text = alimentePourcentages(My.Resources.Global_pays, H_total, lstRegions, lstH)
      lblPourcProvenceH.Text = alimentePourcentages(My.Resources.Global_provence, H_total, lstRegions, lstH)

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmReportingGeographique_Sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick

    ' On teste la colonne double-cliquée
    Dim ligne_selectionnee As Integer() = GridView1.GetSelectedRows()
    Dim colonne As DevExpress.XtraGrid.Columns.GridColumn = GridView1.FocusedColumn()

    Dim NomRegion As String
    Dim TypeStat As String = ""

    If Not ligne_selectionnee Is Nothing Then
      NomRegion = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "REGION").ToString
    Else
      Exit Sub
    End If


    Try
      GridControlDetails.Visible = False

      ' type de liste en fonction de la colonne cliquée
      If colonne.AbsoluteIndex = 1 Then TypeStat = "NBHEURE"
      If colonne.AbsoluteIndex = 2 Then TypeStat = "NBCONTRAT"

      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_DetailActionTauxActiviteRegion", MozartDatabase.cnxMozart)
      CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.Parameters.Add("@typeDet", SqlDbType.VarChar).Value = TypeStat
        CmdSql.Parameters.Add("@region", SqlDbType.VarChar).Value = NomRegion
        CmdSql.Parameters.Add("@technique", SqlDbType.Char).Value = ComboBoxTech.SelectedValue

        Dim sqlAdpat2 As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat2 As New DataSet
        sqlAdpat2.Fill(dtStat2)

        GridControlDetails.DataSource = dtStat2.Tables(0)

        CmdSql.Dispose()
        GridControlDetails.Visible = True

    Catch ex As Exception
      MessageBox.Show("Sub GridControl1_DoubleClick 1 frmTauxActiviteRegion : " + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub
End Class