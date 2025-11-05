
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports MozartLib

Public Class frmStatCAClientParAN

  Private NCLINUM As Int32
  Private dtDetail As New DataTable

  Public Sub New(iClient As Object)
    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    NCLINUM = iClient
  End Sub

  Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      Me.Cursor = Cursors.WaitCursor

      dtDetail = ModDataGridView.LoadList(String.Format("exec api_sp_StatistiqueCAClientParAN {0}", NCLINUM), MozartDatabase.cnxMozart)

      lblSociete.Text = dtDetail.DefaultView.Item(0)(0)

      ChartGraph.Series.Add(CreateSeries)

      With CType(ChartGraph.Diagram, XYDiagram)
        .AxisX.Label.Angle = 90
        .AxisY.Label.TextPattern = "{V:C0}"
      End With
    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatCaparAn_Sub1 + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Public Function CreateSeries() As Series
    'Specify data members to bind the series.
    Dim oSeries As New Series("SeriesCAN", ViewType.Bar) With {
      .DataSource = dtDetail.DefaultView,
      .ArgumentScaleType = ScaleType.Qualitative,
      .ArgumentDataMember = "ANNEE",
      .ValueScaleType = ScaleType.Numerical,
      .ShowInLegend = False,
      .LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
    }
    oSeries.ValueDataMembers.AddRange(New String() {"THT"})

    Return oSeries
  End Function

  Private Function CreateLineTendance(ByVal sNameSerie As String) As RegressionLine
    Try
      Dim LineTendanceMTT As New RegressionLine(ValueLevel.Value) With {
        .Visible = True,
        .ShowInLegend = False,
        .Color = Color.Fuchsia,
        .Name = String.Format(My.Resources.Global_Courbe, sNameSerie)
      }
      LineTendanceMTT.LineStyle.Thickness = 2

      Return LineTendanceMTT
    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatCaparAn_Sub2 + ex.Message, My.Resources.Global_Erreur)
      Return Nothing
    End Try
  End Function

  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
    If MessageBox.Show(My.Resources.Global_impression_graphique, My.Resources.Global_Impression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then
      Dim AllPageLink As New CompositeLink(New PrintingSystem())

      Dim pcLinkGraph As New PrintableComponentLink With {
        .Component = ChartGraph
      }

      AllPageLink.Links.Add(pcLinkGraph)

      AllPageLink.Links(0).Margins.Left = 2
      AllPageLink.Links(0).Margins.Right = 2
      AllPageLink.Links(0).Margins.Top = 2
      AllPageLink.Links(0).Margins.Bottom = 2
      AllPageLink.Links(0).Landscape = True

      AllPageLink.CreatePageForEachLink()

      AllPageLink.PrintDlg()
    End If
  End Sub
End Class
