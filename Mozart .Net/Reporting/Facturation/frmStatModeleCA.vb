Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPrinting
Imports ADODB
Imports DevExpress.Data.Filtering

Public Class frmStatModeleCA

    Dim oStat As Object

  Public Sub New(ByVal c_iType As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    Select Case Convert.ToInt32(c_iType)

      Case 0
        oStat = New CStat_CA_CHAFF

      Case 1
        oStat = New CStat_CA_CAN

    End Select

  End Sub

    Private Sub frmStatModeleCA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            If oStat Is Nothing Then MessageBox.Show(My.Resources.Global_aucune_stat, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

            'Init
            DTPDebut.Value = "01/01/" & Now.Year
            DTPFin.Value = Now.Date

            Me.Text = oStat.sTitleForm
            LblTitre.Text = oStat.sTitleLabel

            Me.Cursor = Cursors.WaitCursor

            oStat.LoadDataStat(DTPDebut.Value, DTPFin.Value)

            InitGridView()

            GCStat.DataSource = oStat.Dt_Stat

            ChartGraph.Series.Add(oStat.CreateSeries)

            With CType(ChartGraph.Diagram, XYDiagram)

                .AxisX.Label.Angle = oStat.AxisX_Label_Angle
                '.AxisY.NumericOptions.Format = oStat.FormatAxeY
                .AxisY.Label.TextPattern = "{V:N0}"

            End With

            If ChartGraph.Titles.Count = 0 Then ChartGraph.Titles.Add(oStat.TitleChart)

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(My.Resources.Reporting_Facturation_frmStatFacturationParPersonne_sub2 + ex.Message, My.Resources.Global_Erreur)

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

    Private Sub frmStatModeleCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click

        Me.Close()

    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

        If MessageBox.Show(My.Resources.Global_print_graphe, My.Resources.Global_impression_graphique, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

            Dim link As New PrintableComponentLink(New PrintingSystem())

            link.Component = ChartGraph
            link.Landscape = True
            link.Margins.Left = 7
            link.Margins.Right = 7
            link.Margins.Top = 7
            link.Margins.Bottom = 7

            link.CreateDocument()

            link.PrintingSystem.Document.AutoFitToPagesWidth = 1

            link.PrintDlg()

        End If

    End Sub

    Private Sub BtnValid_Click(sender As System.Object, e As System.EventArgs) Handles BtnValid.Click

    Try
      Me.Cursor = Cursors.WaitCursor

      'init du filter
      GVStat.ActiveFilterString = ""

      oStat.LoadDataStat(DTPDebut.Value, DTPFin.Value)

      GCStat.DataSource = oStat.Dt_Stat

      ChartGraph.Series.Remove(ChartGraph.Series(0))
      ChartGraph.Series.Add(oStat.CreateSeries)


    Catch ex As Exception
      Me.Cursor = Cursors.Default
            MessageBox.Show(My.Resources.Reporting_Facturation_frmStatFacturationParPersonne_btn + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
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

End Class
