Imports DevExpress.XtraGrid.Views.Base

Public Class UCRapportFM_ChoixReq

    Dim _oRapportFM As CRapportFM

    Public Sub New(ByVal c_oRapportFM As CRapportFM)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _oRapportFM = c_oRapportFM

    End Sub

    Private Sub UCRapportFM_ChoixReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _oRapportFM.NIDRAPPORT_FM_CLI = 0 Then
            LblInfo.Text = "Les cases ont été cochées selon le dernier rapport FM"
        End If

        GCListeReqByCliRapportFM.DataSource = _oRapportFM.DtRapport_FM_All_Requetes_Coche

        'GVListeReqByCliRapportFM.Columns("NORDER").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

    End Sub

    Private Sub GVListeReqByCliRapportFM_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GVListeReqByCliRapportFM.CellValueChanging

        If e.Column.FieldName = "NCOCHE" Then

            Dim DrUpdateOrder As DataRow = GVListeReqByCliRapportFM.GetDataRow(e.RowHandle)

            If e.Value = 1 Then

                DrUpdateOrder.Item("NORDER") = GetOrderMax()
                DrUpdateOrder.Item("NCOCHE") = 1

            Else

                BelowOrder(DrUpdateOrder.Item("NORDER"))
                DrUpdateOrder.Item("NORDER") = DBNull.Value
                DrUpdateOrder.Item("NCOCHE") = 0
                GVListeReqByCliRapportFM.RefreshRow(e.RowHandle)

            End If

        End If

    End Sub

    Private Function GetOrderMax() As Int32

        Dim maximumOrdersByCountry = (From Req In _oRapportFM.DtRapport_FM_All_Requetes_Coche
                                      Where Not Req("NORDER") Is DBNull.Value AndAlso Req("NORDER") > 0
                                      Select Req("NORDER")).Max

        'gestion du chapitre Généralités tjrs en 1
        If maximumOrdersByCountry = 0 Then maximumOrdersByCountry = 1

        Return maximumOrdersByCountry + 1

    End Function

    Public Sub BelowOrder(ByVal p_NORDER As Int32)

        Dim DrUpdateOrder As DataRow() = _oRapportFM.DtRapport_FM_All_Requetes_Coche.Select("NORDER > 1 AND NORDER > " & p_NORDER.ToString, "NORDER ASC")

        For i = 0 To DrUpdateOrder.Count - 1

            DrUpdateOrder(i).Item("NORDER") = DrUpdateOrder(i).Item("NORDER") - 1

        Next

    End Sub

    Private Sub BtnUp_Click(sender As Object, e As EventArgs) Handles BtnUp.Click

        Dim iPos As Int32 = GVListeReqByCliRapportFM.FocusedRowHandle

        Dim DrUpdateOrder As DataRow = GVListeReqByCliRapportFM.GetDataRow(GVListeReqByCliRapportFM.FocusedRowHandle)

        If IsDBNull(DrUpdateOrder.Item("NORDER")) Then Exit Sub

        Dim Norder As Int32 = DrUpdateOrder.Item("NORDER")

        Dim dr As DataRow() = _oRapportFM.DtRapport_FM_All_Requetes_Coche.Select("NORDER = " & (Norder - 1).ToString, "NORDER ASC")

        If dr.Count > 0 Then

            'on exlue le chapitre Genaralités toujours en 1
            If dr(0)("NORDER") = 1 Then Exit Sub

            dr(0)("NORDER") = Norder
            DrUpdateOrder.Item("NORDER") = Norder - 1

            GVListeReqByCliRapportFM.FocusedRowHandle = (iPos - 1)

        End If



    End Sub

    Private Sub BtnDown_Click(sender As Object, e As EventArgs) Handles BtnDown.Click

        Dim iPos As Int32 = GVListeReqByCliRapportFM.FocusedRowHandle
        Dim DrUpdateOrder As DataRow = GVListeReqByCliRapportFM.GetDataRow(GVListeReqByCliRapportFM.FocusedRowHandle)

        If IsDBNull(DrUpdateOrder.Item("NORDER")) Then Exit Sub

        Dim Norder As Int32 = DrUpdateOrder.Item("NORDER")

        Dim dr As DataRow() = _oRapportFM.DtRapport_FM_All_Requetes_Coche.Select("NORDER = " & (Norder + 1).ToString, "NORDER ASC")
        If dr.Count > 0 Then

            dr(0)("NORDER") = Norder
            DrUpdateOrder.Item("NORDER") = Norder + 1

            GVListeReqByCliRapportFM.FocusedRowHandle = (iPos + 1)

        End If

    End Sub
End Class
