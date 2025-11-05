Imports System.Globalization
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPrinting
Imports MozartLib

Public Class frmStatFacturation

  ReadOnly oGestConnectSQL As New CGestionSQL()

  Dim dtStatFacturation As DataTable
  Dim oSeriesMoy As Series
  Dim oAxeSecondaryY As SecondaryAxisY
  Dim LineTendanceNB = New RegressionLine(ValueLevel.Value) With {.Visible = False, .ShowInLegend = False}
  Dim LineTendanceMTT = New RegressionLine(ValueLevel.Value) With {.Visible = False, .ShowInLegend = False}

  Private Sub frmStatFacturation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'Init            
      DTPFin.Value = Now
      DTPDebut.Value = DTPFin.Value.AddMonths(-12)

      'LineTendanceNB = New RegressionLine(ValueLevel.Value) With {.Visible = True, .ShowInLegend = False}
      LineTendanceNB.LineStyle.Thickness = 2
      LineTendanceNB.Name = My.Resources.Global_courbe_Tendance

      'LineTendanceMTT = New RegressionLine(ValueLevel.Value) With {.Visible = False, .ShowInLegend = False}
      LineTendanceMTT.LineStyle.Thickness = 2
      LineTendanceMTT.Name = My.Resources.Global_courbe_Tendance

      'on ouvre la connexion
      If oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        LoadStat()

      End If

      CboMoisHsFact.Items.Clear()
      Dim lstDateHsFact As List(Of Date) = New List(Of Date)

      Dim oDateSelect As Date = DTPDebut.Value

      While oDateSelect <= DTPFin.Value

        lstDateHsFact.Add(oDateSelect.Date)
        oDateSelect = oDateSelect.Date.AddMonths(1)

      End While

      Dim distinctMois As List(Of Date) = lstDateHsFact.Distinct().ToList()

      For Each mois As Date In distinctMois
        Dim ms = mois.Month
        Dim an = mois.Year
        CboMoisHsFact.Items.Add(String.Format("{0} {1}", MonthName(ms, False), an))
      Next
      CboMoisHsFact.SelectedIndex = 0


      If dtStatFacturation.Rows.Count = 0 Then Exit Sub

      'element cocher par défaut
      ChkByNB.Checked = True
      PGFNB.Visible = True
      ChkBoxByFact.Checked = False
      PGFVELFCRE.Visible = False
      ChkByMTT.Checked = False
      PGFMTT.Visible = False
      ChkBoxMOY.Checked = False
      oSeriesMoy.Visible = False


      'ajout d'un deuxieme axe Y
      oAxeSecondaryY = New SecondaryAxisY(My.Resources.Global_montant) With {.Alignment = AxisAlignment.Far}
      oAxeSecondaryY.Title.Text = My.Resources.Global_Montant_chiffrage
      oAxeSecondaryY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
      oAxeSecondaryY.Visibility = DevExpress.Utils.DefaultBoolean.False

      CType(ChartCtrlStatFacChiff.Diagram, XYDiagram).SecondaryAxesY.Add(oAxeSecondaryY)

      'ajuot des courbes de tendances
      CType(ChartCtrlStatFacChiff.Series(0).View, LineSeriesView).Indicators.Add(LineTendanceMTT)
      CType(ChartCtrlStatFacChiff.Series(0).View, LineSeriesView).Indicators.Add(LineTendanceNB)

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatFacturation_Sub1 + ex.Message, My.Resources.Global_Erreur)

    End Try
  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub PGCStatFacChiffrage_FieldValueDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs) Handles PGCStatFacChiffrage.FieldValueDisplayText

    Try

      If Not e.Field Is Nothing AndAlso e.Field.FieldName = "YYMM" Then

        Dim year As String = e.Value.ToString.Substring(0, 4)

        Dim month As String = MonthName(e.Value.ToString.Substring(4, 2), True)

        e.DisplayText = String.Format("{0} {1}", month, year)

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatFacturation_Sub2 + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub LoadStat()

    Try

      dtStatFacturation = New DataTable
      dtStatFacturation = ModDataGridView.LoadList(String.Format("api_sp_StatFacturationChiffrage '{0}', '{1}'", DTPDebut.Value.ToShortDateString, DTPFin.Value.ToShortDateString), oGestConnectSQL.CnxSQLOpen)

      ' Effcte les données du Contrôle PivotGrid au ChartControl
      PGCStatFacChiffrage.DataSource = dtStatFacturation

      ChartCtrlStatFacChiff.DataSource = PGCStatFacChiffrage

      'creation de la serie moy
      CreateIndicatorBySeries()

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatFacturation_Sub3 + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub


  Private Sub BtnValid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnValid.Click

    LoadStat()
    ' If dtStatFacturation.Rows.Count <> 0 Then
    ' Remplit la combobox permettant l'affichage mensuel hors facturières avec les mois situés dans l'intervalle des deux 
    ' zones de texte dédiées à leur paramétrage.
    CboMoisHsFact.Items.Clear()
    Dim lstDateHsFact As List(Of Date) = New List(Of Date)

    Dim oDateSelect As Date = DTPDebut.Value

    While oDateSelect <= DTPFin.Value

      lstDateHsFact.Add(oDateSelect.Date)
      oDateSelect = oDateSelect.Date.AddMonths(1)

    End While

    'For x As Integer = 0 To dtStatFacturation.Rows.Count - 1
    '    lstDateHsFact.Add(dtStatFacturation.Rows(x).Item("YYMM"))
    '  Next
    Dim distinctMois As List(Of Date) = lstDateHsFact.Distinct().ToList()

    For Each mois As Date In distinctMois
      Dim ms = mois.Month
      Dim an = mois.Year
      CboMoisHsFact.Items.Add(String.Format("{0} {1}", MonthName(ms, False), an))
    Next
    CboMoisHsFact.SelectedIndex = 0
    ' End If

  End Sub

  Private Sub ChkByNB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkByNB.CheckedChanged

    If ChkLabelGraph.Checked Then
      ShowLabelInGraph(ChkLabelGraph.Checked)
    End If

    If ChkByNB.Checked = True Then

      PGFNB.Visible = True

      Dim oXYDiag As XYDiagram = ChartCtrlStatFacChiff.Diagram
      oXYDiag.AxisY.Title.Text = My.Resources.Reporting_Facturation_frmStatFacturation_nbr_Chiffrage_cree
      oXYDiag.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True

      LineTendanceNB.Visible = True

    Else

      PGFNB.Visible = False
      LineTendanceNB.Visible = False

    End If

    ChkByMTT.Checked = Not ChkByNB.Checked

    ' gestion d'une erreur à l'ouverture le la form sur le type de la série qui n'est pas encore chargé
    Try
      If ChkBoxByFact.Checked = False Then
        LineTendanceNB.ShowInLegend = LineTendanceNB.Visible
        CType(ChartCtrlStatFacChiff.Series(0).View, BarSeriesView).Indicators.Add(LineTendanceNB)
      End If

    Catch ex As Exception
      ' rien
    End Try

  End Sub

  Private Sub ChkByMTT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkByMTT.CheckedChanged

    If ChkLabelGraph.Checked Then
      ShowLabelInGraph(ChkLabelGraph.Checked)
    End If

    If ChkByMTT.Checked = True Then

      PGFMTT.Visible = True

      Dim oXYDiag As XYDiagram = ChartCtrlStatFacChiff.Diagram
      oXYDiag.AxisY.Title.Text = My.Resources.Reporting_Facturation_frmStatFacturation_montant_Chiffrage_cree
      oXYDiag.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True

      LineTendanceMTT.Visible = True
      If ChkLabelGraph.Checked Then
        ShowLabelInGraph(ChkLabelGraph.Checked)
      End If


    Else

      PGFMTT.Visible = False
      LineTendanceMTT.Visible = False
      If ChkLabelGraph.Checked Then
        ShowLabelInGraph(ChkLabelGraph.Checked)
      End If

    End If

    ChkByNB.Checked = Not ChkByMTT.Checked

    If ChkBoxByFact.Checked = False Then
      LineTendanceMTT.ShowInLegend = LineTendanceMTT.Visible
      CType(ChartCtrlStatFacChiff.Series(0).View, BarSeriesView).Indicators.Add(LineTendanceMTT)
    End If

  End Sub

  Private Sub ChkBoxByFact_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBoxByFact.CheckedChanged

    If ChkLabelGraph.Checked Then
      ShowLabelInGraph(ChkLabelGraph.Checked)
    End If

    If ChkBoxByFact.Checked = True Then
      ChkHsFact.Checked = False
      PGFVELFCRE.Visible = True

    Else
      LoadStat()
      PGFVELFCRE.Visible = False

      If ChkByMTT.Checked = True Then
        LineTendanceMTT.Visible = True
        LineTendanceMTT.ShowInLegend = LineTendanceMTT.Visible
        CType(ChartCtrlStatFacChiff.Series(0).View, BarSeriesView).Indicators.Add(LineTendanceMTT)
      ElseIf ChkByNB.Checked = True Then
        LineTendanceNB.Visible = True
        LineTendanceNB.ShowInLegend = LineTendanceNB.Visible
        CType(ChartCtrlStatFacChiff.Series(0).View, BarSeriesView).Indicators.Add(LineTendanceNB)
      End If

    End If

  End Sub



  Private Sub ChkBoxMOY_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ChkBoxMOY.CheckedChanged

    LoadStat()

    If dtStatFacturation.Rows.Count = 0 Then Exit Sub

    If ChkLabelGraph.Checked Then
      ShowLabelInGraph(ChkLabelGraph.Checked)
    End If

    If Not ChkBoxByFact.Checked And Not ChkHsFact.Checked Then
      If ChkByMTT.Checked Then
        LineTendanceMTT.Visible = True
        LineTendanceMTT.ShowInLegend = LineTendanceMTT.Visible
        CType(ChartCtrlStatFacChiff.Series(0).View, BarSeriesView).Indicators.Add(LineTendanceMTT)
      ElseIf ChkByNB.Checked Then
        LineTendanceNB.Visible = True
        LineTendanceNB.ShowInLegend = LineTendanceNB.Visible
        CType(ChartCtrlStatFacChiff.Series(0).View, BarSeriesView).Indicators.Add(LineTendanceNB)
      End If
    End If

    If ChkBoxMOY.Checked = True Then

      If ChkHsFact.Checked Then ChkHsFact.Checked = False
      oSeriesMoy.Visible = True

      Dim oDiagramSerie As XYDiagramSeriesViewBase = oSeriesMoy.View
      oDiagramSerie.AxisY = oAxeSecondaryY
      oAxeSecondaryY.Visibility = DevExpress.Utils.DefaultBoolean.True

    Else
      oSeriesMoy.Visible = False
      oAxeSecondaryY.Visibility = DevExpress.Utils.DefaultBoolean.False
    End If

  End Sub

  Private Sub CreateIndicatorBySeries()

    Try

      Dim SerieMoyExist As Boolean = False

      If dtStatFacturation Is Nothing Then Exit Try

      Dim reqMoy = From RowMois In dtStatFacturation
                   Group RowMois By MoisKey = RowMois.Field(Of String)("YYMM"), Mois = String.Format("{0} {1}", MonthName(RowMois.Field(Of String)("YYMM").Substring(4, 2), True), RowMois.Field(Of String)("YYMM").Substring(0, 4)) Into TotalNb = Sum(RowMois.Field(Of Int32)("NB")), TotalMTT = Sum(RowMois.Field(Of Decimal)("MTT"))
                   Order By MoisKey
                   Select New With {
                                   Key Mois,
                                   .MOY = (TotalMTT / TotalNb)
                                   }

      If reqMoy.Count = 0 Then Exit Try

      oSeriesMoy = New Series(My.Resources.Reporting_Facturation_frmStatFacturation_montant_moy, ViewType.Line) With {.ArgumentDataMember = "Mois", .DataSource = reqMoy}
      oSeriesMoy.ValueDataMembers.Item(0) = "MOY"
      oSeriesMoy.ValueScaleType = ScaleType.Numerical


      oSeriesMoy.Label.TextPattern = "{V:N0}"

      oSeriesMoy.Visible = ChkBoxMOY.Checked

      For Each oSerieTmp As Series In ChartCtrlStatFacChiff.Series

        If oSerieTmp.Name = My.Resources.Reporting_Facturation_frmStatFacturation_montant_moy Then

          ChartCtrlStatFacChiff.Series.Remove(oSerieTmp)
          Exit For

        End If

      Next

      ChartCtrlStatFacChiff.Series.Add(oSeriesMoy)

      If Not oAxeSecondaryY Is Nothing Then

        Dim oDiagramSerie As XYDiagramSeriesViewBase = oSeriesMoy.View
        oDiagramSerie.AxisY = oAxeSecondaryY

        oAxeSecondaryY.Visibility = ChkBoxMOY.Checked

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatFacturation_Sub4 + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub


  Private Sub ChartCtrlStatFacChiff_CustomDrawSeries(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.CustomDrawSeriesEventArgs) Handles ChartCtrlStatFacChiff.CustomDrawSeries

    If ChkByNB.Checked = True Then

      'e.Series.Label.PointOptions.ValueNumericOptions.Format = NumericFormat.Number 
      'e.Series.Label.PointOptions.ValueNumericOptions.Precision = 0                 

      e.Series.Label.TextPattern = "{V:N0}"

    ElseIf ChkByMTT.Checked = True Then

      'e.Series.Label.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency 
      'e.Series.Label.PointOptions.ValueNumericOptions.Precision = 0

      e.Series.Label.TextPattern = "{V:C0}"

    End If

  End Sub

  Private Sub ChkLabelGraph_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkLabelGraph.CheckedChanged

    ShowLabelInGraph(ChkLabelGraph.Checked)

  End Sub

  Private Sub ShowLabelInGraph(ByRef bValue As Boolean)

    For Each oSerieTmp As Series In ChartCtrlStatFacChiff.Series

      oSerieTmp.LabelsVisibility = If(bValue = True, 0, 1)

    Next

  End Sub

  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

    Try

      If MessageBox.Show(My.Resources.Global_print_graphe, My.Resources.Global_impression_graphique, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

        Using link As New PrintableComponentLink(New PrintingSystem())
          Dim oChart As ChartControl = ChartCtrlStatFacChiff
          link.Component = oChart
          link.Landscape = True
          link.Margins.Left = 7
          link.Margins.Right = 7
          link.Margins.Top = 7
          link.Margins.Bottom = 7
          link.CreateDocument()
          link.PrintingSystem.Document.AutoFitToPagesWidth = 1
          link.PrintDlg()
        End Using

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatFacturation_Sub5 + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub


  Private Sub ChkHsFact_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkHsFact.CheckedChanged

    If ChkLabelGraph.Checked Then
      ShowLabelInGraph(ChkLabelGraph.Checked)
    End If

    If ChkHsFact.Checked Then

      ChkBoxMOY.Checked = False
      ChkBoxByFact.Checked = False

      ' Récupère le mois sélectionné dans la liste déroulante et formate la date de début du mois et celle du mois suivant
      ' pour passer en paramètres dans la procédure stockée
      If CboMoisHsFact.SelectedItem Is Nothing Then Exit Sub

      Dim datedebut = CboMoisHsFact.SelectedItem.ToString()
      Dim annee = datedebut.Substring(datedebut.Length - 4, 4)
      Dim monthNumber = DateTime.ParseExact(datedebut.Substring(0, datedebut.Length - 5), "MMMM", CultureInfo.CurrentCulture).Month
      Dim strdatedeb = String.Format("01/{0}/{1}", Format(monthNumber, "00"), annee)
      Dim datefin = CDate(strdatedeb).AddMonths(1)
      Dim strdatefin = String.Format("{0}/{1}/{2}", Format(datefin.Day, "00"), Format(datefin.Month(), "00"), datefin.Year)

      dtStatFacturation = ModDataGridView.LoadList(String.Format("api_sp_StatFacturationChiffrageHorsFact '{0}', '{1}'", strdatedeb, strdatefin), oGestConnectSQL.CnxSQLOpen)

      PGCStatFacChiffrage.DataSource = dtStatFacturation
      ChartCtrlStatFacChiff.DataSource = PGCStatFacChiffrage
      PGFVELFCRE.Visible = True
      If Not oAxeSecondaryY Is Nothing Then oAxeSecondaryY.Visibility = DevExpress.Utils.DefaultBoolean.False
      If ChkLabelGraph.Checked Then
        ShowLabelInGraph(ChkLabelGraph.Checked)
      End If


    Else : LoadStat()
      PGFVELFCRE.Visible = False
      If ChkByMTT.Checked = True Then
        LineTendanceMTT.Visible = True
        LineTendanceMTT.ShowInLegend = LineTendanceMTT.Visible
        CType(ChartCtrlStatFacChiff.Series(0).View, BarSeriesView).Indicators.Add(LineTendanceMTT)
      ElseIf ChkByNB.Checked = True Then
        LineTendanceNB.Visible = True
        LineTendanceNB.ShowInLegend = LineTendanceNB.Visible
        CType(ChartCtrlStatFacChiff.Series(0).View, BarSeriesView).Indicators.Add(LineTendanceNB)
      End If

    End If

  End Sub

  Private Sub CboMoisHsFact_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboMoisHsFact.SelectedIndexChanged

    If ChkHsFact.Checked Then

      If ChkLabelGraph.Checked Then
        ShowLabelInGraph(ChkLabelGraph.Checked)
      End If

      ChkBoxMOY.Checked = False

      ' Récupère le mois sélectionné dans la liste déroulante et formate la date de début du mois et celle du mois suivant
      ' pour passer en paramètres dans la procédure stockée

      Dim datedebut = CboMoisHsFact.SelectedItem.ToString()
      Dim annee = datedebut.Substring(datedebut.Length - 4, 4)
      Dim monthNumber = DateTime.ParseExact(datedebut.Substring(0, datedebut.Length - 5), "MMMM", CultureInfo.CurrentCulture).Month
      Dim strdatedeb = String.Format("01/{0}/{1}", Format(monthNumber, "00"), annee)
      Dim datefin = CDate(strdatedeb).AddMonths(1)
      Dim strdatefin = String.Format("{0}/{1}/{2}", Format(datefin.Day, "00"), Format(datefin.Month(), "00"), datefin.Year)

      dtStatFacturation = ModDataGridView.LoadList(String.Format("api_sp_StatFacturationChiffrageHorsFact '{0}', '{1}'", strdatedeb, strdatefin), oGestConnectSQL.CnxSQLOpen)

      PGCStatFacChiffrage.DataSource = dtStatFacturation
      ChartCtrlStatFacChiff.DataSource = PGCStatFacChiffrage
      PGFVELFCRE.Visible = True

    End If
  End Sub

  Private Sub frmStatFacturation_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

End Class