Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports MozartLib

Public Class UCPrestations

  Dim _dsPresta As DataSet

  Dim StyleGrouping(0 To 1) As Color

  Public ReadOnly Property dsPresta As DataSet
    Get
      Return _dsPresta
    End Get
  End Property

  Private Sub UCPrestations_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'INIT
    StyleGrouping(0) = Color.LightCyan
    StyleGrouping(1) = Color.LightGray

    LoadData()

  End Sub

  Private Sub LoadData()

    'init 
    _dsPresta = New DataSet

    Dim dtPresta As New DataTable("TMPPRESTA")
    Dim CmdSql As New SqlCommand("api_sp_CreationWizardSTFPrestations", MozartDatabase.cnxMozart)
    CmdSql.CommandType = CommandType.StoredProcedure

        dtPresta.Load(CmdSql.ExecuteReader)
        dtPresta.Columns("COCHEETUDE").ReadOnly = False
        dtPresta.Columns("COCHEINSTALL").ReadOnly = False
        dtPresta.Columns("COCHEPREV").ReadOnly = False
        dtPresta.Columns("COCHEDEP").ReadOnly = False
        dtPresta.Columns("COCHEASTR").ReadOnly = False
        _dsPresta.Tables.Add(dtPresta)

        GCPRESTA.ShowOnlyPredefinedDetails = True

        GCPRESTA.DataSource = _dsPresta.Tables("TMPPRESTA")

    End Sub

    Private Sub GVPRESTA_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GVPRESTA.RowStyle
        If e.RowHandle < 0 Then Exit Sub

        Dim View As GridView = sender

        e.Appearance.BackColor = StyleGrouping(View.GetRowCellDisplayText(e.RowHandle, View.Columns("COLORCAT")))
    End Sub

End Class
