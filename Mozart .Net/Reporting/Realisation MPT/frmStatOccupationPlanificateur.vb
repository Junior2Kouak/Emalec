Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class frmStatOccupationPlanificateur

  Dim CnxAux As New CGestionSQL

  Private Sub frmStatOccupationPlanificateur_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Me.Cursor = Cursors.WaitCursor

    Try

      If CnxAux.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = False Then
        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

      lblDateJour.Text = My.Resources.Global_le & Date.Today

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmStatOccupatiobPlanificateur_sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try

    ChargeListe()

  End Sub

  Private Sub ChargeListe()

    Me.Cursor = Cursors.WaitCursor

    Try

      Dim CmdSql As New SqlCommand("api_sp_StatOccupationPlanificateur", MozartDatabase.cnxMozart)
      CmdSql.CommandType = CommandType.StoredProcedure
      CmdSql.Parameters.Add("@vsociete", SqlDbType.Char).Value = MozartParams.NomSociete

      Dim sqlAdapt As SqlDataAdapter = New SqlDataAdapter(CmdSql)
      Dim dtStat As New DataSet
      sqlAdapt.Fill(dtStat)

      Chart1.DataSource = dtStat.Tables(0)
      Chart2.DataSource = dtStat.Tables(1)
      Chart4.DataSource = dtStat.Tables(2)
      Chart3.DataSource = dtStat.Tables(3)

      Chart5.DataSource = dtStat.Tables(10)

      'magnali
      ChartControl1.DataSource = dtStat.Tables(4)


      Dim oAxis As XYDiagram
      ' LE DIOT L.
      If dtStat.Tables(5).Rows.Count > 0 And dtStat.Tables(0).Rows.Count > 0 Then
        oAxis = Chart1.Diagram
        oAxis.AxisY.ConstantLines(0).AxisValue = dtStat.Tables(5).Rows(0).Item(0)
        oAxis.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_moyenne
        Chart1.Titles(0).Text = dtStat.Tables(0).Rows(0).Item(0)
      End If

      ' Sylvie GONCALVES
      If dtStat.Tables(6).Rows.Count > 0 And dtStat.Tables(1).Rows.Count > 0 Then
        oAxis = Chart2.Diagram
        oAxis.AxisY.ConstantLines(0).AxisValue = dtStat.Tables(6).Rows(0).Item(0)
        oAxis.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_moyenne
        Chart2.Titles(0).Text = dtStat.Tables(1).Rows(0).Item(0)
      End If


      ' POURCENOUX E.
      If dtStat.Tables(7).Rows.Count > 0 And dtStat.Tables(2).Rows.Count > 0 Then
        oAxis = Chart4.Diagram
        oAxis.AxisY.ConstantLines(0).AxisValue = dtStat.Tables(7).Rows(0).Item(0)
        oAxis.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_moyenne
        Chart4.Titles(0).Text = dtStat.Tables(2).Rows(0).Item(0)
      End If

      ' YOSBERGUE*
      If dtStat.Tables(8).Rows.Count > 0 And dtStat.Tables(3).Rows.Count > 0 Then
        oAxis = Chart3.Diagram
        oAxis.AxisY.ConstantLines(0).AxisValue = dtStat.Tables(8).Rows(0).Item(0)
        oAxis.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_moyenne
        Chart3.Titles(0).Text = dtStat.Tables(3).Rows(0).Item(0)
      End If


      ' YOSBERGUE
      If dtStat.Tables(9).Rows.Count > 0 And dtStat.Tables(4).Rows.Count > 0 Then
        oAxis = ChartControl1.Diagram
        oAxis.AxisY.ConstantLines(0).AxisValue = dtStat.Tables(9).Rows(0).Item(0)
        oAxis.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_moyenne
        ChartControl1.Titles(0).Text = dtStat.Tables(4).Rows(0).Item(0)
      End If

      CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmStatOccupatiobPlanificateur_sub2 + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtValider_Click(sender As System.Object, e As System.EventArgs)
    ChargeListe()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub
End Class