Imports System.Data.SqlClient

Public Class frmStatGraphTech

    Dim oGestCnx As CGestionSQL

    Dim NPERNUM As Int32
    Dim VPERNOM As String
    Dim DateDebut As Date
    Dim DateFin As Date
    Dim sType As String

    Public Sub New(ByVal c_oGestCNX As CGestionSQL, ByVal c_NPERNUM As Int32, ByVal c_VPERNOM As String, ByVal c_DateDebut As Date, ByVal c_DateFin As Date, ByVal c_sType As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        oGestCnx = c_oGestCNX
        NPERNUM = c_NPERNUM
        VPERNOM = c_VPERNOM
        DateDebut = c_DateDebut
        DateFin = c_DateFin
        sType = c_sType

    End Sub

    Private Sub frmStatGraphTech_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ChartGraphTech.Titles(0).Text = String.Format(My.Resources.Reporting_RealisationMPT_frmStatGraphTech_repartitions, VPERNOM, DateDebut.ToShortDateString, DateFin.ToShortDateString)

        ChartGraphTech.DataSource = LoadList(String.Format("exec api_sp_StatCumulHeureJourTech {0}, '{1}', '{2}', '{3}'", NPERNUM, DateDebut, DateFin, sType), oGestCnx.CnxSQLOpen)

    End Sub

    Private Sub BtnImprimer_Click(sender As System.Object, e As System.EventArgs) Handles BtnImprimer.Click
        Dim oScreenShot As New CSreenShot(Me, True)
        oScreenShot.Print_Form()
    End Sub

    Private Sub frmStatGraphTech_ResizeEnd(sender As Object, e As System.EventArgs) Handles Me.ResizeEnd, Me.SizeChanged

        BtnImprimer.Location = New Point(ChartGraphTech.Size.Width - BtnImprimer.Size.Width - 10, 12)

    End Sub

End Class