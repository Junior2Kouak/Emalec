Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPrinting
Imports ADODB
Imports DevExpress.Data.Filtering

Public Class frmStatModeleTXCharge

  Dim oStat As CStat_TxOccup_Multi 'Object
  Dim stypeStat As String


  Public Sub New(ByVal c_iType As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    stypeStat = c_iType.ToString
    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    oStat = New CStat_TxOccup_Multi(c_iType.ToString)

  End Sub

  Private Sub frmStatModeleTXCharge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Dim iIDSeries As Int32
    Dim i As Int32

    Try

      If oStat Is Nothing Then MessageBox.Show(My.Resources.Global_aucune_stat, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub


      DTPFin.Value = "01/" + Now.Month.ToString + "/" + Now.Year.ToString
      DTPDebut.Value = DTPFin.Value.AddMonths(-36)
      DTPFin.Value = DTPFin.Value.AddDays(-1)

      Me.Text = oStat.sTitleForm
      LblTitre.Text = oStat.sTitleLabel

      Me.Cursor = Cursors.WaitCursor

      oStat.LoadDataStat(DTPDebut.Value, DTPFin.Value)

      InitGridView()

      GCStat.DataSource = oStat.Dt_Stat

      For iIDSeries = 0 To oStat.iNbSeries.Count - 1
        Select Case iIDSeries
          Case 0
            For i = 0 To oStat.iNbSeries(iIDSeries)
              ChartGraph.Series.Add(oStat.CreateSeries(iIDSeries, i))
            Next
          Case 1
            For i = 0 To oStat.iNbSeries(iIDSeries)
              ChartPourc.Series.Add(oStat.CreateSeries(iIDSeries, i))
            Next
        End Select
      Next

      With CType(ChartGraph.Diagram, XYDiagram)
        .AxisX.Label.Angle = oStat.AxisX_Label_Angle
        .AxisY.Label.TextPattern = "{V:N0}"
      End With

      '2 eme chart pour les pourcentage
      With CType(ChartPourc.Diagram, XYDiagram)

        .AxisX.Label.Angle = oStat.AxisX_Label_Angle
        .AxisY.Label.TextPattern = "{V:P1}"

        If oStat.IsLineConst Then .AxisY.ConstantLines.Add(oStat.LineObjectifPOURC)

        .AxisY.VisualRange.Auto = False
        .AxisY.VisualRange.MinValue = 0
        .AxisY.VisualRange.MaxValue = 1

      End With

      If ChartPourc.Titles.Count = 0 Then
        ChartPourc.Titles.Add(oStat.TitleChart)
        ChartPourc.Titles(0).Font = New Font("Tahoma", 12, FontStyle.Bold)
      End If

      lblPerimHaut.Text = My.Resources.Reporting_RealisationMPT_frmStatModeleTXCharge_compare
      lblPerim.Text = My.Resources.Reporting_RealisationMPT_frmStatModeleTXCharge_rapport
      lblMoy12.Text = lblMoy12.Text & vbCrLf & FormatNumber(CalculMoyenne(oStat.Dt_Stat), 1) & " %"

      lblObj.Text = String.Format(My.Resources.Reporting_RealisationMPT_frmStatModeleTXCharge_objectif, oStat.ValueObj)

    Catch ex As Exception
      Me.Cursor = Cursors.Default
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmStatModeleTXCharge_sub + ex.Message, My.Resources.Global_Erreur)

    Finally
      Me.Cursor = Cursors.Default

    End Try

  End Sub

  Private Sub InitGridView()

    Dim i As Int32

    'Init
    GVStat.Columns.Clear()

    For i = 0 To (oStat.Dt_Stat.Columns.Count - 1)

      GVStat.Columns.Add(oStat.NamingColumn(i))

    Next

  End Sub

  Private Sub frmStatModeleTXCharge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

    If MessageBox.Show(My.Resources.Global_print_graphe, My.Resources.Global_impression_graphique, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

      Dim oScreenShot As New CSreenShot(Me, True)

      oScreenShot.Print_Form()

    End If

  End Sub

  Private Sub BtnValid_Click(sender As System.Object, e As System.EventArgs) Handles BtnValid.Click

    Try
      Me.Cursor = Cursors.WaitCursor

      'init du filter
      GVStat.ActiveFilterString = ""

      oStat.LoadDataStat(DTPDebut.Value, DTPFin.Value)

      GCStat.DataSource = oStat.Dt_Stat

    Catch ex As Exception
      Me.Cursor = Cursors.Default
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmStatModeleTXCharge_btnclick + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally

      Me.Cursor = Cursors.Default

    End Try

  End Sub

  Private Sub GVStat_ColumnFilterChanged(sender As Object, e As System.EventArgs) Handles GVStat.ColumnFilterChanged

    For Each oSeriesTmp As Series In ChartGraph.Series

      Dim op As CriteriaOperator = GVStat.ActiveFilterCriteria 'filterControl1.FilterCriteria

      Dim filterString As String = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(op)

      oStat.SetFilterSeries(oSeriesTmp, filterString)

    Next

  End Sub

  Private Function CalculMoyenne(dt As DataTable) As Decimal

    Dim j As Integer
    CalculMoyenne = 0

    ' si on a pas 12 ligne, on ne calcule pas de moyenne
    If dt.Rows.Count < 12 Then
      Return CalculMoyenne
    Else
      For j = 0 To 11
        CalculMoyenne += 100 * dt.Rows(j).Item(5)
      Next
    End If
    Return CalculMoyenne / 12
  End Function

  Private Sub BtnExportXLS_Click(sender As Object, e As EventArgs) Handles BtnExportXLS.Click

    If GVStat.RowCount = 0 Then Exit Sub

    Try

      SFD.FileName = ""
      SFD.Filter = "Fichiers EXCEL (*.xlsx)|*.xlsx"
      SFD.ShowDialog()

      If SFD.FileName <> "" Then
        GVStat.ExportToXlsx(SFD.FileName)
      End If

    Catch ex As Exception

      MessageBox.Show("BtnExportXLS_Click" + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub
End Class
