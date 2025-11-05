Imports DevExpress.XtraCharts
Imports MozartLib

Public Class frmStatNotationSTTMoyenne

  ReadOnly oGestConnectSQL As New CGestionSQL()
  Dim dtStat As DataTable


  Public Sub New()
    InitializeComponent()
  End Sub

  Private Sub frmStatNotationSTTMoyenne_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    Try
      'on ouvre la connexion
      If oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        dtStat = New DataTable
        dtStat = ModDataGridView.LoadList("api_sp_StatQualNoteSTT", oGestConnectSQL.CnxSQLOpen)
        With CType(ChartBas.Diagram, XYDiagram)
          .AxisY.WholeRange.Auto = True
          .AxisY.WholeRange.SideMarginsValue = 2
          '.AxisY.WholeRange.SetMinMaxValues(0, 70)
          .AxisY.Label.TextPattern = "{V:N0}"
        End With

        ' taux de note > 50 (calculé dans la proc)
        Dim dr As DataRow = dtStat.Rows(0)
        lblmoyenne.Text = String.Format("{0} %", FormatNumber(dr(2), 1))

        'Dim ConstHaut As XYDiagram = ChartBas.Diagram
        'ConstHaut.AxisY.ConstantLines(0).AxisValue = 2
        'ConstHaut.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_objectif

        GCStat.DataSource = dtStat
        ChartBas.DataSource = dtStat
      End If

    Catch ex As Exception
      MessageBox.Show(Me.Text + ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub BtnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

  Private Sub ChartBas_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles ChartBas.ObjectSelected

    MsgBox("En cours...")
    Exit Sub

    Dim hitInfo As ChartHitInfo = e.HitInfo
    If hitInfo.SeriesPoint IsNot Nothing Then
      Dim oFrmDetailStat As New frmStatTauxConformiteDetails(hitInfo.SeriesPoint.Tag.Row.ItemArray, My.Resources.Reporting_RH_frmTauxConformite_tauxRMPT, "R")
      oFrmDetailStat.ShowDialog()
      oFrmDetailStat.Dispose()
    End If

  End Sub

  Private Sub frmTauxConformite_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
    oGestConnectSQL.CloseConnexionSQL()
  End Sub

  Private Sub BtnFermer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFermer.Click
    Close()
  End Sub

End Class
