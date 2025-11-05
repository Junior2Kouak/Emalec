Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls

Public Class FrmGestTrav_ChargeDevPrev

    Dim DtTabCharge As DataTable
    Dim DtTabChargeGraph As DataTable

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Me.Close()
    End Sub

    Private Sub FrmGestTrav_ChargeDevPrev_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadData()

    End Sub

    Private Sub LoadData()

        DtTabCharge = New DataTable

        Dim sqlcmdload As New SqlCommand("[api_sp_StatTCE_ChargePrevisionnel]", cnx)
        sqlcmdload.CommandType = CommandType.StoredProcedure
        DtTabCharge.Load(sqlcmdload.ExecuteReader())

        GCCHARGEDEVTCE.DataSource = DtTabCharge

        DtTabChargeGraph = New DataTable
        sqlcmdload = New SqlCommand("[api_sp_StatTCE_ChargePrevisionnel_Graph]", cnx)
        sqlcmdload.CommandType = CommandType.StoredProcedure
        DtTabChargeGraph.Load(sqlcmdload.ExecuteReader())

        'ChartChargeDevPrev.DataSource = DtTabChargeGraph

    End Sub

    Private Sub FrmGestTrav_ChargeDevPrev_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        GCCHARGEDEVTCE.Size = New Size(GCCHARGEDEVTCE.Width, Me.Height - GCCHARGEDEVTCE.Top - 100)

    End Sub

End Class