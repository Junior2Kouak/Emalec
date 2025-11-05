Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports MozartLib

Public Class UCVillesCibles

  Dim _dsVillesCibles As DataSet

  Dim StyleGrouping(0 To 1) As Color

  Public ReadOnly Property dsVillesCibles As DataSet
    Get
      Return _dsVillesCibles
    End Get
  End Property

  Private Sub UCVillesCibles_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'INIT
    StyleGrouping(0) = Color.LightCyan
    StyleGrouping(1) = Color.LightGray

  End Sub

  Public Sub LoadData(ByVal p_vPays As String)

    If p_vPays = "" Then

      MessageBox.Show(My.Resources.WizardSTF_UCVillesCibles_Expr1, My.Resources.WizardClient_Global_Msg1, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub

    End If

    'init 
    _dsVillesCibles = New DataSet

    Dim dtVillesCibles As New DataTable("TMPVILLESCIBLES")
    Dim CmdSql As New SqlCommand("api_sp_CreationWizardSTFVillesCibles", MozartDatabase.cnxMozart)
    CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.Parameters.Add("@vpays", SqlDbType.VarChar).Value = p_vPays

        dtVillesCibles.Load(CmdSql.ExecuteReader)
        dtVillesCibles.Columns("COCHE").ReadOnly = False
        _dsVillesCibles.Tables.Add(dtVillesCibles)

        GCVILLESCIBLES.ShowOnlyPredefinedDetails = True

        GCVILLESCIBLES.DataSource = _dsVillesCibles.Tables("TMPVILLESCIBLES")

    End Sub

    Private Sub GVVILLESCIBLES_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GVVILLESCIBLES.RowStyle

        If e.RowHandle < 0 Then Exit Sub

        Dim View As GridView = sender

        e.Appearance.BackColor = StyleGrouping(View.GetRowCellDisplayText(e.RowHandle, View.Columns("COLORREG")))

    End Sub
End Class
