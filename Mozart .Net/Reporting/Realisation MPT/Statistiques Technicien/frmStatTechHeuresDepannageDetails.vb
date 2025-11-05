Imports System.Data.SqlClient
Imports MozartLib

Public Class frmStatTechHeuresDepannageDetails

  Dim strName, strNPERNUM As String
  Dim CnxAux As New CGestionSQL

  Public Sub New(ByVal name As String, npernum As String)

    InitializeComponent()
    strName = name
    strNPERNUM = npernum

  End Sub

  Private Sub frmStatTechHeuresDepannageDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Dim ds As DataSet

    Me.Cursor = Cursors.WaitCursor
    LabelTech.Text = strName

    Try

      If CnxAux.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = False Then
        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

      ds = New DataSet

      Dim cmdLoadList As New SqlCommand("api_sp_StatTechHeuresDepannageDetails", CnxAux.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure
      cmdLoadList.Parameters.Add("@npernum", SqlDbType.Int).Value = strNPERNUM

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(ds)

      GCRECEPTIONS.DataSource = ds.Tables(0)

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmStatTechHeuresDepannageDetails_sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    GCRECEPTIONS.Print()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\StatsTechHeuresDepannageDetails_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCRECEPTIONS.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub GridView1_EndSorting(sender As Object, e As System.EventArgs) Handles GridView1.EndSorting
    GridView1.MoveFirst()
  End Sub

End Class