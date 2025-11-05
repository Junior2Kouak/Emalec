Imports System.Data.SqlClient
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class frmStatFacturationEISemaine
  Dim CnxEISemaine As New CGestionSQL
  Dim dtAnnee As DataTable
  Dim ds As DataSet

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub frmStatFacturationEISemaine_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    CnxEISemaine.CloseConnexionSQL()
  End Sub

  Private Sub frmStatFacturationEISemaine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      If CnxEISemaine.ConnexionSQLTimeOut(MozartParams.NomServeur, MozartParams.NomSociete, 60000) = True Then
        'test si plusieurs ecrans.
        If Screen.AllScreens.Count > 1 Then
          Me.Left = Screen.PrimaryScreen.WorkingArea.Width
        End If

        Me.WindowState = FormWindowState.Maximized
        LoadDataGridView()
        'position de la scrollbar au max
        PGrid.LeftTopCoord = New Point(50, 5)

      Else
        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatFacturationEISemaine_Sub1 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub LoadDataGridView()
    Dim i As Integer
    Dim GVCol As New DevExpress.XtraGrid.Columns.GridColumn
    Try
      i = 0
      Me.Cursor = Cursors.WaitCursor

      ds = New DataSet

      Dim cmdLoadList As New SqlCommand("api_sp_StatistiqueFacturationEISemaine", CnxEISemaine.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(ds)

      PGrid.DataSource = ds.Tables(0)

      '*********************************************************** MODELISATION DE LA CHART
      ChartStatEI.DataSource = PGrid

      'TITRE DE LA CHARt
      Dim oChartTitle As New ChartTitle
      oChartTitle.Alignment = StringAlignment.Center
      oChartTitle.Visibility = DevExpress.Utils.DefaultBoolean.True
      oChartTitle.Text = LblTitre.Text
	  oChartTitle.TextColor = System.Drawing.Color.Black
      ChartStatEI.Titles.Add(oChartTitle)

      For Each oSerieTmp As Series In ChartStatEI.Series

        If oSerieTmp.Name = "TOTAL" Then

          'oSerieTmp.Label.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
          'oSerieTmp.Label.PointOptions.ValueNumericOptions.Precision = 0
          oSerieTmp.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

          oSerieTmp.Label.TextPattern = "{V:C0}"
          oSerieTmp.CrosshairLabelVisibility = DevExpress.Utils.DefaultBoolean.False
          oSerieTmp.Visible = True
          oSerieTmp.ShowInLegend = True
          oSerieTmp.ChangeView(ViewType.Bar)

          'courbe de tendance
          CType(oSerieTmp.View, SideBySideBarSeriesView).Indicators.Add(CreateLineTendance(oSerieTmp.Name))
          CType(ChartStatEI.Diagram, XYDiagram).AxisY.ConstantLines.Add(CreateLineConstante(oSerieTmp.Name))

        Else

          oSerieTmp.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
          oSerieTmp.ShowInLegend = False
          oSerieTmp.Visible = False

        End If

      Next

      ChartStatEI.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Left
      ChartStatEI.Legend.AlignmentVertical = LegendAlignmentVertical.BottomOutside

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatFacturationEISemaine_Sub2 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub PGrid_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomDrawCellEventArgs) Handles PGrid.CustomDrawCell

    Dim test As XYDiagram = ChartStatEI.Diagram
    If e.ColumnIndex = 0 Then

      test.Margins.Left = e.Bounds.Left

      'dernière column           
    ElseIf e.ColumnIndex = 52 Then

      test.Margins.Right = (ChartStatEI.Size.Width - e.Bounds.Right)
      Console.Write(e.Bounds.Right.ToString)

    End If

  End Sub

  Private Sub PGrid_FieldWidthChanged(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldEventArgs) Handles PGrid.FieldWidthChanged

    'If e.Field.Area = PivotArea.ColumnArea Then

    '    For Each oSerieTmp As Series in ChartStatEI.Series 

    '        If oSerieTmp.Name = "TOTAL" Then

    '            CType(oSerieTmp.View, SideBySideBarSeriesView).BarWidth = e.Field.Width  

    '        End If

    '    Next


    'End If

  End Sub

  Private Sub PGrid_FieldValueDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs) Handles PGrid.FieldValueDisplayText
    If e.ValueType = DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal Then
      e.DisplayText = "TOTAL"
    End If
  End Sub

  Private Sub ChartStatEI_CustomDrawAxisLabel(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs)

    Dim oAxis As AxisBase = e.Item.Axis

    If (TypeOf oAxis Is AxisY Or TypeOf oAxis Is AxisY3D Or TypeOf oAxis Is RadarAxisY) Then

      e.Item.Text = String.Format("{0:c0}", Convert.ToInt32(e.Item.Text))
      Dim oAxisTitle As Object = Convert.ChangeType(oAxis, oAxis.GetType)
      oAxisTitle.Title.Text = My.Resources.Global_montant
      oAxisTitle.Title.Visible = True

    ElseIf (TypeOf oAxis Is AxisX Or TypeOf oAxis Is AxisX3D Or TypeOf oAxis Is RadarAxisX) Then

      Dim oAxisTitle As Object = Convert.ChangeType(oAxis, oAxis.GetType)
      oAxisTitle.Title.Text = My.Resources.Global_par_semaine
      oAxisTitle.Title.Visible = True

    End If

  End Sub

  Private Function CreateLineTendance(ByVal sNameSerie As String) As RegressionLine

    Try

      Dim LineTendanceMTT As New RegressionLine(ValueLevel.Value)
      LineTendanceMTT.Visible = True
      LineTendanceMTT.ShowInLegend = True
      LineTendanceMTT.LineStyle.Thickness = 2
      LineTendanceMTT.Color = Color.Fuchsia
      LineTendanceMTT.Name = String.Format(My.Resources.Global_Courbe, sNameSerie)

      Return LineTendanceMTT

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatFacturationEISemaine_Sub3 + ex.Message, My.Resources.Global_Erreur)
      Return Nothing

    End Try

  End Function

  Private Function CreateLineConstante(ByVal sNameSerie As String) As ConstantLine

    'ajout de la ligne objectif
    Dim LineObjectif = New ConstantLine(My.Resources.Global_objectif_maj)
    LineObjectif.AxisValue = 20000.0
    LineObjectif.Visible = True
    LineObjectif.ShowInLegend = False
    LineObjectif.LegendText = My.Resources.Reporting_Facturation_frmStatFacturationEISemaine_objectif
    LineObjectif.ShowBehind = False

    ' Customize the constant line's title.
    LineObjectif.Title.Visible = True
    LineObjectif.Title.Text = My.Resources.Global_objectif
    LineObjectif.Title.TextColor = Color.LightGreen
    LineObjectif.Title.Font = New Font("Tahoma", 8, FontStyle.Bold)

    ' Customize the appearance of the constant line.
    LineObjectif.Color = Color.Lime
    LineObjectif.LineStyle.Thickness = 2

    Return LineObjectif

  End Function

  Private Sub PGrid_CellClick(sender As Object, e As DevExpress.XtraPivotGrid.PivotCellEventArgs) Handles PGrid.CellClick

    'e.GetRowFields()
    Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource

    Dim sValueCol() As String = e.GetFieldValue(e.GetColumnFields(0)).ToString.Split("-")
    Dim numSem As Int32 = sValueCol(1)
    Dim numAnnee As Int32 = sValueCol(0)

    If Not ds Is Nothing And Not e.RowField Is Nothing Then
      If Not ds(0) Is Nothing And numSem > 0 Then

        Dim oFrmDetail As New frmFactEI_DetailBySem(CnxEISemaine, ds(0)("NPERNUM"), numSem, numAnnee, ds(0)("TECHNICIEN"), (PGrid.Location.X + e.Bounds.Left), (PGrid.Location.Y + e.Bounds.Top))
        oFrmDetail.ShowDialog()

      End If
    End If
  End Sub

End Class