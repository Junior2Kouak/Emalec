Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class frmPyramideAges

  Private Sub frmPyramideAges_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    lblDateJour.Text = My.Resources.Global_le & " " & Date.Today

    apiSocieteAuto1.Init(MozartDatabase.cnxMozart, MozartParams.NomSociete)

    ChargeListe()
  End Sub

  Private Sub ChargeListe()
    Try
      Dim CmdSql As New SqlCommand("api_sp_StatQualAge", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      CmdSql.Parameters.Add("@SOCIETE", SqlDbType.VarChar).Value = apiSocieteAuto1.Text

      Dim sqlAdapt As New SqlDataAdapter(CmdSql)
      Dim dtStat As New DataSet
      sqlAdapt.Fill(dtStat)

      Chart1.DataSource = dtStat.Tables(0)
      Chart2.DataSource = dtStat.Tables(1)
      Chart3.DataSource = dtStat.Tables(2)
      Chart4.DataSource = dtStat.Tables(3)
      Chart5.DataSource = dtStat.Tables(4)

      Dim nbSal As String = dtStat.Tables(5).Columns(0).Table(0).Item(0).ToString
      lblPerim.Text = My.Resources.Reporting_RH_frmModalStatRHTpsTravMultiJour_nbr_salarié & nbSal

      Dim maxValue As Integer

      With CType(Chart1.Diagram, XYDiagram)
        .AxisY.WholeRange.Auto = True
        maxValue = .AxisY.WholeRange.MaxValue  ' On récupère la valeur max avant d'enlever l'échelle automatique, pour avoir les 5 graphs à la même échelle
        .AxisY.WholeRange.Auto = False
        .AxisY.WholeRange.SideMarginsValue = 0
        .AxisY.WholeRange.SetMinMaxValues(0, maxValue + 5)
      End With
      With CType(Chart2.Diagram, XYDiagram)
        .AxisY.WholeRange.Auto = False
        .AxisY.WholeRange.SideMarginsValue = 0
        .AxisY.WholeRange.SetMinMaxValues(0, maxValue + 5)

      End With
      With CType(Chart3.Diagram, XYDiagram)
        .AxisY.WholeRange.Auto = False
        .AxisY.WholeRange.SideMarginsValue = 0
        .AxisY.WholeRange.SetMinMaxValues(0, maxValue + 5)
      End With
      With CType(Chart4.Diagram, XYDiagram)
        .AxisY.WholeRange.Auto = False
        .AxisY.WholeRange.SideMarginsValue = 0
        .AxisY.WholeRange.SetMinMaxValues(0, maxValue + 5)
      End With
      With CType(Chart5.Diagram, XYDiagram)
        .AxisY.WholeRange.Auto = False
        .AxisY.WholeRange.SideMarginsValue = 0
        .AxisY.WholeRange.SetMinMaxValues(0, maxValue + 5)
      End With

      CmdSql.Dispose()
    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RH_frmModalStatRHTpsTravMultiJour_nbr_sub + ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

  Private Sub BtValider_Click(sender As System.Object, e As System.EventArgs) Handles BtValider.Click
    ChargeListe()
  End Sub
End Class
