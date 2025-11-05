Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports MozartLib

Public Class frmListeEnquetesQualites

  Private dtListe As DataTable

  Public Sub New()
    ' Cet appel est requis par le concepteur.
    InitializeComponent()
  End Sub

  Private Sub frmListeEnquetesQualites_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    DTPFin.Value = Now.Date
    DTPDebut.Value = DTPFin.Value.AddMonths(-12)

    BtValider_Click(Nothing, Nothing)
  End Sub

  Private Sub LoadListe()
    Try
      dtListe = New DataTable
      Dim sqlcmd As New SqlCommand("api_sp_ListeEnqueteQual", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      sqlcmd.Parameters.Add("@DateDebut", SqlDbType.DateTime).Value = DTPDebut.Value
      sqlcmd.Parameters.Add("@DateFin", SqlDbType.DateTime).Value = DTPFin.Value

      dtListe.Load(sqlcmd.ExecuteReader)

      GCListeFouEI.DataSource = dtListe

      lblNb.Text = dtListe.Rows.Count

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub BandedGridView1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles BandedGridView1.RowCellStyle
    If Strings.Left(e.Column.FieldName, 1) = "A" Then
      If IsDBNull(e.CellValue) Then
        e.Appearance.BackColor = Color.White
      Else
        e.Appearance.BackColor = Color.Green
        e.Appearance.ForeColor = Color.Green
      End If
    End If

    If Strings.Left(e.Column.FieldName, 1) = "B" Then
      If IsDBNull(e.CellValue) Then
        e.Appearance.BackColor = Color.White
      Else
        e.Appearance.BackColor = Color.Orange
        e.Appearance.ForeColor = Color.Orange
      End If
    End If

    If Strings.Left(e.Column.FieldName, 1) = "C" Then
      If IsDBNull(e.CellValue) Then
        e.Appearance.BackColor = Color.White
      Else
        e.Appearance.BackColor = Color.Red
        e.Appearance.ForeColor = Color.Red
      End If
    End If
  End Sub

  Private Sub BtnPrint_Click(sender As Object, e As System.EventArgs) Handles BtnPrint.Click
    GCListeFouEI.Print()
  End Sub

  Private Sub ButtonExporter_Click(sender As Object, e As EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\" & Name & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCListeFouEI.ExportToXls(fileName)
    Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub btnSynthese_Click(sender As Object, e As EventArgs) Handles btnSynthese.Click
    Dim frmSyntheseEnquetesQualite As New frmSyntheseEnquetesQual()
    frmSyntheseEnquetesQualite.ShowDialog()
  End Sub

  Private Sub BtValider_Click(sender As Object, e As EventArgs) Handles BtValider.Click
    Cursor = Cursors.WaitCursor
    LoadListe()
    Cursor = Cursors.Default
  End Sub
End Class
