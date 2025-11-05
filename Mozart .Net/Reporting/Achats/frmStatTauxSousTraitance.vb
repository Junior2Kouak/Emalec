Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class frmStatTauxSousTraitance

  Dim dtStat As DataTable

  Dim iTypeAff As Int32  '0 = nb et 1 = montant
  Dim iZone As Int32  '0 = tous et 1 = fr et 2 = hors france

  Private Sub frmStatTauxSousTraitance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    ComboBox1.DataSource = New CListes().GetListeFilialeWithAllInOutDroit

    ComboBox1.Text = MozartParams.NomSociete

    DTPFin.Value = Now.Date
    DTPDebut.Value = DTPFin.Value.AddMonths(-36)

  End Sub

  Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()

  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Function CalculMoyenne12() As Decimal

    CalculMoyenne12 = 0

    Dim dtCopy As DataTable = dtStat.Copy

    For Each drCopy As DataRow In dtCopy.Rows

      CalculMoyenne12 += drCopy.Item(0)

    Next

    Return If(dtCopy.Rows.Count = 0, 0, CalculMoyenne12 / dtCopy.Rows.Count)
  End Function

  Private Sub BtValider_Click(sender As Object, e As EventArgs) Handles BtValider.Click

    'test
    If ChkNB.Checked = False And ChkMTT.Checked = False Then MessageBox.Show("Il faut sélectionner un type d'affichage", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

    If ComboBox1.Text = "EMALEC" And ChkTous.Checked = False And ChkFR.Checked = False And ChkOutFrance.Checked = False Then MessageBox.Show("Il faut sélectionner une zone", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

    Me.Cursor = Cursors.WaitCursor

    dtStat = New DataTable

    Dim sqlcmd As New SqlCommand("api_sp_StatQualTauxSTT_V2", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = ComboBox1.Text
    sqlcmd.Parameters.Add("@DateDebut", SqlDbType.DateTime).Value = DTPDebut.Value
    sqlcmd.Parameters.Add("@DateFin", SqlDbType.DateTime).Value = DTPFin.Value
    sqlcmd.Parameters.Add("@TypeAff", SqlDbType.Int).Value = iTypeAff
        sqlcmd.Parameters.Add("@TypeZone", SqlDbType.Int).Value = iZone
        sqlcmd.Parameters.Add("@b_hors_prev", SqlDbType.Bit).Value = ChkHorsPrev.Checked

        dtStat.Load(sqlcmd.ExecuteReader)

    LblTitre.Text = My.Resources.Reporting_RH_frmTauxConformite_Taux_ss_trait

    'ChartBas.Titles(0).Text = "TAUX Sous-traitance"

    With CType(ChartBas.Diagram, XYDiagram)
      .AxisY.VisualRange.Auto = True
      .AxisY.WholeRange.Auto = False
      .AxisY.WholeRange.SideMarginsValue = 0
      .AxisY.WholeRange.SetMinMaxValues(0, 100)
      .AxisY.Title.Text = ""
    End With

    ' moyenne sur les 12 derniers mois
    'lblMoy12.Text = lblMoy12.Text & vbCrLf & FormatNumber(CalculMoyenne12(), 0)

    ' ajout d'une line objectif
    Dim LineObj = New ConstantLine(My.Resources.Reporting_achat_frmStatAchat_objectif, 30)
    LineObj.Color = Color.Lime
    LineObj.Title.TextColor = Color.Lime
    LineObj.Title.Text = My.Resources.Reporting_achat_frmStatAchat_objectif
    LineObj.ShowInLegend = False

    ChartBas.DataSource = dtStat

    'ajout des courbes de tendances sur le total (series 3)
    For Each oSeries As Series In ChartBas.Series
      CType(oSeries.View, BarSeriesView).AxisY.ConstantLines.Add(LineObj)
    Next

    Me.Cursor = Cursors.Default

  End Sub

  Private Sub ChkNB_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNB.CheckedChanged

    If ChkNB.Checked = True Then
      ChkMTT.Checked = False
      iTypeAff = 0
    End If

  End Sub

  Private Sub ChkMTT_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMTT.CheckedChanged

    If ChkMTT.Checked = True Then
      ChkNB.Checked = False
      iTypeAff = 1
    End If

  End Sub

  Private Sub ChkTous_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTous.CheckedChanged
    If ChkTous.Checked = True Then
      ChkFR.Checked = False
      ChkOutFrance.Checked = False
      iZone = 0
    End If
  End Sub

  Private Sub ChkFR_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFR.CheckedChanged
    If ChkFR.Checked = True Then
      ChkTous.Checked = False
      ChkOutFrance.Checked = False
      iZone = 1
    End If
  End Sub

  Private Sub ChkOutFrance_CheckedChanged(sender As Object, e As EventArgs) Handles ChkOutFrance.CheckedChanged
    If ChkOutFrance.Checked = True Then
      ChkFR.Checked = False
      ChkTous.Checked = False
      iZone = 2
    End If
  End Sub

  Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged


    If ComboBox1.Text = "EMALEC" Then

      ChkTous.Checked = False

      ChkTous.Visible = True
      ChkFR.Visible = True
      ChkOutFrance.Visible = True
      Label3.Visible = True

    Else

      ChkTous.Visible = False

      ChkTous.Checked = True

      ChkFR.Visible = False
      ChkOutFrance.Visible = False
      Label3.Visible = False

    End If

  End Sub


End Class