Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class frmTauxDeplacementPlanifs

  Dim oGestConnectSQL As New CGestionSQL
  Dim dtStat As DataSet

  Private Sub frmTauxDeplacementPlanifs_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    oGestConnectSQL.CloseConnexionSQL()
  End Sub

  Private Sub frmTauxDeplacementPlanifs_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    ' TB SAMSIC CITY RES
    LabelTitre.Text += MozartParams.NomGroupe
    lblDateJour.Text = My.Resources.Global_le & Date.Today
    GridView1.ColumnPanelRowHeight = 40
    Timer1.Enabled = True

  End Sub


  Private Sub chargeListe()
    Try

      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_TauxDeplacementPlanifs", MozartDatabase.cnxMozart)
      CmdSql.CommandTimeout = 0
        CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.Parameters.Add("@anneeEnCours", SqlDbType.VarChar).Value = Today().Year

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GridControl1.DataSource = dtStat.Tables(0)


        CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show("Sub frmTauxDeplacementPlanifs_Load (chargeListe) frmTauxDeplacementPlanifs : " + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub


  Private Sub LoadStat()

    Try
      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete)

      Dim CmdSql As New SqlCommand("api_sp_TauxDeplacementPlanifsGraph", oGestConnectSQL.CnxSQLOpen)
      CmdSql.CommandTimeout = 0
      CmdSql.CommandType = CommandType.StoredProcedure
      Dim dr As SqlDataAdapter = New SqlDataAdapter(CmdSql)
      dtStat = New DataSet

      dr.Fill(dtStat)

      ChartCtrlPer.DataSource = dtStat.Tables(0)

      Dim oAxis As XYDiagram = ChartCtrlPer.Diagram
      oAxis.AxisY.Title.Text = My.Resources.Reporting_RealisationMPT_frmTauxDeplacementPlanifs_taux
      oAxis.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True

      oAxis.AxisY.ConstantLines(0).AxisValue = 10
      oAxis.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_objectif

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmTauxDeplacementPlanifs_sub + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
    Timer1.Enabled = False

    chargeListe()

    Timer2.Enabled = True
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\ExportTauxDeplacementPlanifs_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GridControl1.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
    Timer2.Enabled = False

    LoadStat()
  End Sub

  Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick

    ' On teste la colonne double-cliquée
    Dim ligne_selectionnee As Integer() = GridView1.GetSelectedRows()
    Dim colonne As DevExpress.XtraGrid.Columns.GridColumn = GridView1.FocusedColumn()

    Dim numSemaine As String
    Dim valeur_cellule As String

    If Not ligne_selectionnee Is Nothing Then
      numSemaine = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "numSemaine").ToString
      valeur_cellule = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), colonne).ToString
    Else
      Exit Sub
    End If
    GridControlDetails.Visible = False
    btnExportDetails.Visible = False
    LabelDetails.Visible = False

    If colonne.AbsoluteIndex = 2 Then
      ' Obtenir les détails pour la colonne 3 : Nb de nouvelles planifs en cours de semaine
      Try
        Me.Cursor = Cursors.WaitCursor

        Dim CmdSql As New SqlCommand("api_sp_TauxDeplacementPlanifsDetails", MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.StoredProcedure
          CmdSql.Parameters.Add("@type_detail", SqlDbType.VarChar).Value = "NbNvPlanifsSemaine"
          CmdSql.Parameters.Add("@anneeEnCours", SqlDbType.VarChar).Value = Today().Year
          CmdSql.Parameters.Add("@numSemaine", SqlDbType.Int).Value = Integer.Parse(numSemaine)
          CmdSql.Parameters.Add("@complementInfo", SqlDbType.Int).Value = 0

          Dim sqlAdpat2 As SqlDataAdapter = New SqlDataAdapter(CmdSql)
          Dim dtStat2 As New DataSet
          sqlAdpat2.Fill(dtStat2)

          GridControlDetails.DataSource = dtStat2.Tables(0)

          CmdSql.Dispose()
          GridControlDetails.Visible = True
          btnExportDetails.Visible = True
          LabelDetails.Text = My.Resources.Reporting_RealisationMPT_frmTauxDeplacementPlanifs_details & numSemaine & vbCrLf & GridView1.Columns.ColumnByName("nbNvPlanif").Caption
          LabelDetails.Visible = True

      Catch ex As Exception
        MessageBox.Show("Sub GridControl1_DoubleClick 1 frmTauxDeplacementPlanifs : " + ex.Message, My.Resources.Global_Erreur)
      Finally
        Me.Cursor = Cursors.Default
      End Try

    ElseIf colonne.AbsoluteIndex = 5 Then
      ' Obtenir les détails pour la colonne 6 : Nb de modifications de planifs de l'action la + déplacée
      Try
        Me.Cursor = Cursors.WaitCursor

        Dim CmdSql As New SqlCommand("api_sp_TauxDeplacementPlanifsDetails", MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.Parameters.Add("@type_detail", SqlDbType.VarChar).Value = "NbModifsPlanifsMax"
        CmdSql.Parameters.Add("@anneeEnCours", SqlDbType.VarChar).Value = Today().Year
        CmdSql.Parameters.Add("@numSemaine", SqlDbType.Int).Value = Integer.Parse(numSemaine)
        CmdSql.Parameters.Add("@complementInfo", SqlDbType.Int).Value = Integer.Parse(valeur_cellule)

        Dim sqlAdpat2 As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat2 As New DataSet
        sqlAdpat2.Fill(dtStat2)

        GridControlDetails.DataSource = dtStat2.Tables(0)

        CmdSql.Dispose()
        GridControlDetails.Visible = True
        btnExportDetails.Visible = True
        LabelDetails.Text = My.Resources.Reporting_RealisationMPT_frmTauxDeplacementPlanifs_details & numSemaine & vbCrLf & GridView1.Columns.ColumnByName("nbMaxDeplace").Caption
        LabelDetails.Visible = True

      Catch ex As Exception
        MessageBox.Show("Sub GridControl1_DoubleClick 2 frmTauxDeplacementPlanifs : " + ex.Message, My.Resources.Global_Erreur)
      Finally
        Me.Cursor = Cursors.Default
      End Try

    ElseIf colonne.AbsoluteIndex = 6 Then
      ' Obtenir les détails pour la colonne 7 : Nb d'actions déplacées plus de 3 fois dans les 3 semaines à venir, y compris celle en cours
      Try
        Me.Cursor = Cursors.WaitCursor

        Dim CmdSql As New SqlCommand("api_sp_TauxDeplacementPlanifsDetails", MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.Parameters.Add("@type_detail", SqlDbType.VarChar).Value = "NbActDeplPlus3Fois"
        CmdSql.Parameters.Add("@anneeEnCours", SqlDbType.VarChar).Value = Today().Year
        CmdSql.Parameters.Add("@numSemaine", SqlDbType.Int).Value = Integer.Parse(numSemaine)
        CmdSql.Parameters.Add("@complementInfo", SqlDbType.Int).Value = 0

        Dim sqlAdpat2 As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat2 As New DataSet
        sqlAdpat2.Fill(dtStat2)

        GridControlDetails.DataSource = dtStat2.Tables(0)

        CmdSql.Dispose()
        GridControlDetails.Visible = True
        btnExportDetails.Visible = True
        LabelDetails.Text = My.Resources.Reporting_RealisationMPT_frmTauxDeplacementPlanifs_details & numSemaine & vbCrLf & GridView1.Columns.ColumnByName("nbActPlus3fois3S").Caption
        LabelDetails.Visible = True

      Catch ex As Exception
        MessageBox.Show("Sub GridControl1_DoubleClick 3 frmTauxDeplacementPlanifs : " + ex.Message, My.Resources.Global_Erreur)
      Finally
        Me.Cursor = Cursors.Default
      End Try

    End If

  End Sub

  Private Sub btnExportDetails_Click(sender As System.Object, e As System.EventArgs) Handles btnExportDetails.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\ExportTauxDeplacementPlanifs_Details_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GridControlDetails.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

End Class