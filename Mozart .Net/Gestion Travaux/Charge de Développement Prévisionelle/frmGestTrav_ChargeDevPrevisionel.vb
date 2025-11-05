Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports MozartLib

Public Class frmGestTrav_ChargeDevPrevisionel

  Dim DtTabCharge As DataTable
  Dim DtTabChargeGraph As DataTable

  Private Sub frmGestTrav_ChargeDevPrevisionel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'init
    DTPFin.Value = CDate("01/" & CDate(Now.Date.AddMonths(4)).Month.ToString & "/" & CDate(Now.Date.AddMonths(4)).Year.ToString)
    DTPDebut.Value = Now.Date

    LoadData()
    LoadDataGraph()

  End Sub

  Private Sub LoadData()

    DtTabCharge = New DataTable

    Dim sqlcmdload As New SqlCommand("[api_sp_StatTCE_ChargePrevisionnel]", MozartDatabase.cnxMozart)
    sqlcmdload.CommandType = CommandType.StoredProcedure
    DtTabCharge.Load(sqlcmdload.ExecuteReader())

    GCCHARGEDEV.DataSource = DtTabCharge



  End Sub


  Private Sub LoadDataGraph()

    'DtTabChargeGraph = New DataTable
    'Dim sqlcmdload As New SqlCommand("[api_sp_StatTCE_ChargePrevisionnel_Graph]", cnx)
    'sqlcmdload.CommandType = CommandType.StoredProcedure
    'sqlcmdload.Parameters.Add("@P_DATEDEBUT", SqlDbType.VarChar).Value = DTPDebut.Value
    'sqlcmdload.Parameters.Add("@P_DATEFIN", SqlDbType.VarChar).Value = DTPFin.Value
    'DtTabChargeGraph.Load(sqlcmdload.ExecuteReader())

    If DtTabCharge IsNot Nothing Then

      Dim sFilter As String = String.Format("[DACTDAT] >= '{0}' ", DTPDebut.Value.ToShortDateString) ', DTPFin.Value.ToShortDateString)  'and [DACTDAT] <='{1}'

      If GVCHARGEDEV.ActiveFilterString <> "" Then

        sFilter = sFilter & " AND " & DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(GVCHARGEDEV.ActiveFilterCriteria)

      End If

      If DtTabCharge.Select(sFilter).Count() = 0 Then
        ChartChargeDevPrev.DataSource = Nothing
        Return
      End If

      Dim DtSelected As DataTable = DtTabCharge.Select(sFilter).CopyToDataTable

      Dim req = From dtgrap In DtSelected.AsEnumerable
                Group dtgrap By key = New With {.MOIS = dtgrap.Field(Of DateTime)("DACTDAT").Month,
                        .ANNEE = dtgrap.Field(Of DateTime)("DACTDAT").Year,
                        .AXE_X = MonthName(dtgrap.Field(Of DateTime)("DACTDAT").Month) + " " + dtgrap.Field(Of DateTime)("DACTDAT").Year.ToString} Into Group
                Select New With {.ANNEE = key.ANNEE, .MOIS = key.MOIS, .AXE_X = key.AXE_X, .TOTAL_NDCLHT = Group.Sum(Function(v) v.Field(Of Decimal)("NDCLHT"))}

      ChartChargeDevPrev.DataSource = req

    End If


    'ChartChargeDevPrev.DataSource = DtTabChargeGraph.Select(GVCHARGEDEV.ActiveFilterString).CopyToDataTable

  End Sub


  Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
    Me.Close()
  End Sub

  Private Sub frmGestTrav_ChargeDevPrevisionel_Resize(sender As Object, e As EventArgs) Handles Me.Resize

    GCCHARGEDEV.Size = New Size(GCCHARGEDEV.Width, Me.Height - GCCHARGEDEV.Top - 100)

  End Sub

  Private Sub GVCHARGEDEV_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GVCHARGEDEV.RowCellClick

    If e.Column.FieldName = "VDINACTID" And GVCHARGEDEV.FocusedRowHandle > -1 Then

      Dim oDRSelect As DataRow = GVCHARGEDEV.GetDataRow(GVCHARGEDEV.FocusedRowHandle)

      If oDRSelect Is Nothing Then Exit Sub

      If (oDRSelect.Item("NDINNUM").ToString <> "" And oDRSelect.Item("NACTNUM").ToString <> "") Then
        Shell(MozartParams.CheminProgrammeMozart & "SynchroMozart.exe " & MozartParams.NomServeur & ";" & MozartParams.NomSociete & ";" & oDRSelect.Item("NDINNUM") & ";" & oDRSelect.Item("NACTNUM"), vbMaximizedFocus)
      End If


    End If

  End Sub

  Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click
    LoadDataGraph()
  End Sub

  Private Sub GVCHARGEDEV_ColumnFilterChanged(sender As Object, e As EventArgs) Handles GVCHARGEDEV.ColumnFilterChanged

    LoadDataGraph()

  End Sub
End Class