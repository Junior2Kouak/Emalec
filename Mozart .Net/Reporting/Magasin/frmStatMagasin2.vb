Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class frmStatMagasin2

  Private Sub frmStatMagasin2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try

      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_StatMagasinReception", MozartDatabase.cnxMozart)
      CmdSql.CommandType = CommandType.StoredProcedure

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
      Dim dtStat As New DataSet
      sqlAdpat.Fill(dtStat)

      ChartReceptions.DataSource = dtStat.Tables(0)

      ChartColis.DataSource = dtStat.Tables(1)

      CmdSql.Dispose()

      ' moyenne sur les 48 derniers mois
      Dim Moy48 As Integer = CalculMoyenne(dtStat, 0)
      lblMoy.Text = lblMoy.Text & vbCrLf & FormatNumber(Moy48, 0)
      Dim Constbas As XYDiagram = ChartReceptions.Diagram
      Constbas.AxisY.ConstantLines(1).AxisValue = Moy48

      Dim Moy48_2 As Integer = CalculMoyenne(dtStat, 1)
      lblMoy2.Text = lblMoy2.Text & vbCrLf & FormatNumber(Moy48_2, 0)
      Dim Constbas2 As XYDiagram = ChartColis.Diagram
      Constbas2.AxisY.ConstantLines(1).AxisValue = Moy48_2

      ' ----------------------------------------------------------------
      CmdSql = New SqlCommand("api_sp_StatEntreesSortiesTech", MozartDatabase.cnxMozart)
      CmdSql.CommandType = CommandType.StoredProcedure

        Dim sqlAdpat2 As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat2 As New DataSet
        sqlAdpat2.Fill(dtStat2)

        ChartTechs.DataSource = dtStat2.Tables(0)

        CmdSql.Dispose()

        ' moyenne sur les 48 derniers mois
        Dim Moy48_3 As Integer = CalculMoyenne2(dtStat2, 0)
        lblMoy3.Text = lblMoy3.Text & vbCrLf & FormatNumber(Moy48_3, 0)
        Dim Constbas3 As XYDiagram = ChartTechs.Diagram
        Constbas3.AxisY.ConstantLines(1).AxisValue = Moy48_3

    Catch ex As Exception
            MessageBox.Show(My.Resources.Reporting_Magasin_frmStatMagasin2_sub + ex.Message, My.Resources.Global_Erreur)
        Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Function CalculMoyenne(dt As DataSet, i As Integer) As Decimal

    Dim somme As Integer = 0

    For cpt = 0 To dt.Tables(i).Rows.Count - 1
      ' !!! La 1ère colonne du DataSet doit être le nombre de réceptions ou de colis!!!
      Dim nb As String = dt.Tables(i).Rows(cpt).ItemArray.GetValue(0).ToString  ' On récupère les valeurs à ajouter

      somme = somme + Integer.Parse(nb)
    Next cpt

    Return somme / 48
  End Function

  Private Function CalculMoyenne2(dt As DataSet, i As Integer) As Decimal

    Dim somme As Integer = 0

    For cpt = 0 To dt.Tables(i).Rows.Count - 1
      ' !!! La 1ère colonne du DataSet doit être le nombre de réceptions ou de colis!!!
      Dim nb As String = dt.Tables(i).Rows(cpt).ItemArray.GetValue(0).ToString  ' On récupère les valeurs à ajouter
      Dim nb2 As String = dt.Tables(i).Rows(cpt).ItemArray.GetValue(1).ToString  ' On récupère les valeurs à ajouter

      somme = somme + Integer.Parse(nb) + +Integer.Parse(nb2)
    Next cpt

    Return somme / 48
  End Function

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

    Private Sub ChartColis_ObjectSelected(sender As Object, e As DevExpress.XtraCharts.HotTrackEventArgs) Handles ChartColis.ObjectSelected
        ' Détails
        Dim hitInfo As ChartHitInfo = e.HitInfo
        If hitInfo.SeriesPoint IsNot Nothing Then
            Dim oFrmDetailStat As New frmStatMagasin2Details(hitInfo.SeriesPoint.Argument, My.Resources.Reporting_Magasin_frmStatMagasin2_fourniture)
            oFrmDetailStat.ShowDialog()
        End If

    End Sub

    Private Sub ChartTechs_ObjectSelected(sender As Object, e As DevExpress.XtraCharts.HotTrackEventArgs) Handles ChartTechs.ObjectSelected
        ' Détails
        Dim hitInfo As ChartHitInfo = e.HitInfo
        If hitInfo.SeriesPoint IsNot Nothing Then
            Dim oFrmDetailStat As New frmStatMagasin2Details(hitInfo.SeriesPoint.Argument, My.Resources.Reporting_Magasin_frmStatMagasin2_equipement)
            oFrmDetailStat.ShowDialog()
        End If

    End Sub

    Private Sub ChartReceptions_ObjectSelected(sender As Object, e As DevExpress.XtraCharts.HotTrackEventArgs) Handles ChartReceptions.ObjectSelected
        ' Détails
        Dim hitInfo As ChartHitInfo = e.HitInfo
        If hitInfo.SeriesPoint IsNot Nothing Then
            Dim oFrmDetailStat As New frmStatMagasin2Details(hitInfo.SeriesPoint.Argument, My.Resources.Reporting_Magasin_frmStatMagasin2_Receptions)
            oFrmDetailStat.ShowDialog()
        End If
    End Sub
End Class