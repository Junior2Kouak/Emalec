

Imports System.Data.SqlClient
Imports MozartLib

Public Class frmSyntheseEnquetesQual

  Dim oSqlConn As New CGestionSQL
  Dim dtListe As DataTable
  Dim calendar_open As String


  Public Sub New()

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

  End Sub

  Private Sub frmSyntheseEnqueteQualite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    DTPFin.Value = Now.Date
    DTPDebut.Value = DTPFin.Value.AddMonths(-12)

    Me.Cursor = Cursors.WaitCursor

    cboClient.DataSource = ListeClientCbo()

    LoadListe()

  End Sub

  Private Sub LoadListe()

    Try


      Dim CmdSql As New SqlCommand("api_sp_SyntheseEnqueteQual", MozartDatabase.cnxMozart)
      CmdSql.CommandType = CommandType.StoredProcedure
      CmdSql.CommandTimeout = 0
      CmdSql.Parameters.Add("@DtDebut", SqlDbType.DateTime).Value = DTPDebut.Value
      CmdSql.Parameters.Add("@DtFin", SqlDbType.DateTime).Value = DTPFin.Value
      CmdSql.Parameters.Add("@nclient", SqlDbType.Int).Value = cboClient.SelectedValue

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
      dtListe = New DataTable
      sqlAdpat.Fill(dtListe)

      GCListeFouEI.DataSource = dtListe

      CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show(ex.Message)

    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtValider_Click(sender As System.Object, e As System.EventArgs) Handles BtValider.Click

    LoadListe()

  End Sub
  Public Function ListeClientCbo() As DataTable

    Try

      Dim dtLstClient As New DataTable

      Dim sSQL As String
      sSQL = String.Format("Exec api_sp_ListeClientParDroitGroupe")

      Dim sqlcmdGTPClientLst As New SqlCommand(sSQL, MozartDatabase.cnxMozart)

      dtLstClient.Load(sqlcmdGTPClientLst.ExecuteReader)

      Return dtLstClient

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_Facturation_Reportingfacturation_Sub2 + ex.Message)
      Return Nothing

    End Try

  End Function

  Private Sub frmSyntheseEnqueteQualite_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    oSqlConn.CloseConnexionSQL()
  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFermer.Click
    Me.Close()
  End Sub


  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
    GCListeFouEI.Print()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles btnExport.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\" & Me.Name & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCListeFouEI.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

End Class