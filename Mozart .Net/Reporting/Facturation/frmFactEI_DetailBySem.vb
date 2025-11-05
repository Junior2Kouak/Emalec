Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmFactEI_DetailBySem

    Dim oGestCnx As CGestionSQL
    Dim NPERNUM As Int32
    Dim NumSem As Int32
    Dim NumANNEE As Int32
    Dim sNomTech As String

    Dim PosX As Int32
    Dim PosY As Int32

    Public Sub New(ByVal c_oCNX As CGestionSQL, ByVal c_NPERNUM As Int32, ByVal c_NumSem As Int32, ByVal c_NumANNEE As Int32, ByVal c_sNomTech As String, ByVal c_PosX As Int32, ByVal c_PosY As Int32)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        oGestCnx = c_oCNX
        NPERNUM = c_NPERNUM
        NumSem = c_NumSem
        NumANNEE = c_NumANNEE
        sNomTech = c_sNomTech
        PosX = c_PosX
        PosY = c_PosY

    End Sub

    Private Sub frmFactEI_DetailBySem_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'init form
    Me.Location = New Point(PosX, PosY)
        Me.Text = String.Format(My.Resources.Reporting_Facturation_frmFactEl_DetailBySem_Detail, NumSem, NumANNEE, sNomTech)

        Dim dtDetail As New DataTable

    ' NL : Correction le 27/01/2016 suite constatation écarts entre détails et récap

    'Dim sqlcmd As New SqlCommand("api_sp_Detail_Fac_By_Sem", oGestCnx.CnxSQLOpen)
    'sqlcmd.CommandType = CommandType.StoredProcedure

    '    sqlcmd.Parameters.Add("@p_numsem", SqlDbType.Int)
    '   sqlcmd.Parameters("@p_numsem").Value = NumSem

    '    sqlcmd.Parameters.Add("@p_annee", SqlDbType.Int)
    '   sqlcmd.Parameters("@p_annee").Value = NumANNEE

    '    sqlcmd.Parameters.Add("@p_npernum", SqlDbType.Int)
    '   sqlcmd.Parameters("@p_npernum").Value = NPERNUM

    '    sqlcmd.Parameters.Add("@vsociete", SqlDbType.VarChar)
    '   sqlcmd.Parameters("@vsociete").Value = gstrNomSociete

    Me.Cursor = Cursors.WaitCursor
    Dim sqlcmd As New SqlCommand("api_sp_StatistiqueFacturationEISemaine", oGestCnx.CnxSQLOpen)
    sqlcmd.CommandType = CommandType.StoredProcedure

    sqlcmd.Parameters.Add("@ANNEE_Filtre", SqlDbType.Int)
    sqlcmd.Parameters("@ANNEE_Filtre").Value = NumANNEE

    sqlcmd.Parameters.Add("@SEMAINE_Filtre", SqlDbType.Int)
    sqlcmd.Parameters("@SEMAINE_Filtre").Value = NumSem

    sqlcmd.Parameters.Add("@TECHNICIEN_Filtre", SqlDbType.VarChar)
    sqlcmd.Parameters("@TECHNICIEN_Filtre").Value = sNomTech

    dtDetail.Load(sqlcmd.ExecuteReader)

    GCDetailFact.DataSource = dtDetail

    Me.Cursor = Cursors.Default

    End Sub

    Private Sub GVDetailFact_CustomDrawGroupRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GVDetailFact.CustomDrawGroupRow

        Dim View As GridView = TryCast(sender, GridView)
        If View Is Nothing Then Exit Sub

        Dim info As GridGroupRowInfo = TryCast(e.Info, GridGroupRowInfo)

        If info.Column.FieldName = "NFACNUM" Then

            info.GroupText = info.Column.Caption + " : " + info.GroupValueText
            info.GroupText += My.Resources.Reporting_Facturation_frmFactEl_DetailBySem_total + View.GetGroupSummaryText(info.RowHandle) + ")"

        End If

    End Sub

End Class