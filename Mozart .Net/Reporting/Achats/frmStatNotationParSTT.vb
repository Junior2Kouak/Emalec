Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports MozartLib

Public Class frmStatNotationParSTT

  Dim oSqlConn As New CGestionSQL
  Dim dtListe As DataTable


  Public Sub New()

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

  End Sub

  Private Sub frmStatNotationParSTT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    DTPFin.Value = Now.Date
    DTPDebut.Value = DTPFin.Value.AddMonths(-12)

    BtValider_Click(Nothing, Nothing)

  End Sub

  Private Sub BtValider_Click(sender As Object, e As EventArgs) Handles BtValider.Click
    Me.Cursor = Cursors.WaitCursor
    LoadListe()
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub LoadListe()

    Try

      dtListe = New DataTable
      '        dtListe = ModDataGridView.LoadList("api_sp_ListeEnqueteQual", oSqlConn.CnxSQLOpen)
      Dim sqlcmd As New SqlCommand("api_sp_StatNotationParSTT", MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.StoredProcedure
      sqlcmd.Parameters.Add("@DateDebut", SqlDbType.DateTime).Value = DTPDebut.Value
      sqlcmd.Parameters.Add("@DateFin", SqlDbType.DateTime).Value = DTPFin.Value

      dtListe.Load(sqlcmd.ExecuteReader)

      GCListe.DataSource = dtListe

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub BandedGridView1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs)

    If Strings.Left(e.Column.FieldName, 1) = "A" Then
      If IsDBNull(e.CellValue) Then
        e.Appearance.BackColor = Color.White
      Else
        e.Appearance.BackColor = Color.Green
        e.Appearance.ForeColor = Color.Green
      End If
    End If
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    GCListe.Print()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\" & Me.Name & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCListe.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub frmStatNotationParSTT_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    oSqlConn.CloseConnexionSQL()
  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub
End Class