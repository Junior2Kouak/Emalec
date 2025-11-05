

Imports System.Data.SqlClient
Imports MozartLib

Public Class frmStatNotationParPersonne

  Dim oSqlConn As New CGestionSQL
  Dim dtListe As DataTable


  Public Sub New()

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

  End Sub

  Private Sub frmStatNotationParPersonne_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
      Dim sqlcmd As New SqlCommand("api_sp_StatNotationParPersonne", MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.StoredProcedure
      sqlcmd.Parameters.Add("@DateDebut", SqlDbType.DateTime).Value = DTPDebut.Value
      sqlcmd.Parameters.Add("@DateFin", SqlDbType.DateTime).Value = DTPFin.Value

      dtListe.Load(sqlcmd.ExecuteReader)

      GCListe.DataSource = dtListe

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub frmStatNotationParPersonne_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    oSqlConn.CloseConnexionSQL()
  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    GCListe.Print()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\" & Me.Name & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCListe.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

End Class