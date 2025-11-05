Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class frmStatTechEvolIndic_Detail

  Dim Dt_Data As DataTable
  Dim _DateDebut As Date
  Dim _DateFin As Date
  Dim _npernum As Int32
  Dim _vnomstat As String

  Public Sub New(ByVal c_sNomtech As String, ByVal c_DateDebut As Date, ByVal c_DateFin As Date, ByVal c_npernum As Int32, ByVal c_vnomstat As String)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    Me.Text = String.Format(Me.Text, c_sNomtech & " - " & c_vnomstat)
    ChartGraphTech.Titles(0).Text = Me.Text

    _DateDebut = c_DateDebut
    _DateFin = c_DateFin
    _npernum = c_npernum
    _vnomstat = c_vnomstat

  End Sub

  Private Sub frmStatTechEvolIndic_Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadData()

    ChartGraphTech.DataSource = Dt_Data


    Dim LineTendanceMTT As New RegressionLine(ValueLevel.Value)
    LineTendanceMTT.Visible = True
    LineTendanceMTT.ShowInLegend = False
    LineTendanceMTT.LineStyle.Thickness = 2
    LineTendanceMTT.Color = Color.Fuchsia
    LineTendanceMTT.Name = "Courbe tendance"

    CType(ChartGraphTech.Series(0).View, LineSeriesView).Indicators.Add(LineTendanceMTT)


  End Sub

  Private Sub LoadData()

    Dt_Data = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_StatistiqueTechEvolIndic_Detail]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@Date_Debut", SqlDbType.VarChar).Value = _DateFin.Date.AddYears(-5)
        sqlcmd.Parameters.Add("@Date_Fin", SqlDbType.VarChar).Value = _DateFin.Date.AddMonths(-1)
        sqlcmd.Parameters.Add("@npernum", SqlDbType.Int).Value = _npernum
        sqlcmd.Parameters.Add("@vnomstat", SqlDbType.VarChar).Value = _vnomstat
        Dt_Data.Load(sqlcmd.ExecuteReader)


    End Sub

    Private Sub BtnImprimer_Click(sender As Object, e As EventArgs) Handles BtnImprimer.Click

        Dim oScreenShot As New CSreenShot(Me, True)
        oScreenShot.Print_Form()

    End Sub
End Class