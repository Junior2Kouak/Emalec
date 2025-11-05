Imports System.Data.SqlClient
Imports MozartLib

Public Class frmDevisAttenteChaffDetails

  ReadOnly strName, strNPERNUM As String
  ReadOnly CnxAux As New CGestionSQL()

  Public Sub New(name As String, npernum As String)

    InitializeComponent()
    strName = name
    strNPERNUM = npernum

  End Sub

  Private Sub frmDevisAttenteChaffDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Dim ds As DataSet

    Me.Cursor = Cursors.WaitCursor

    Try

      If CnxAux.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = False Then
        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

      ds = New DataSet

      LabelDetail.Text = strName
      Dim cmdLoadList As New SqlCommand("api_sp_StatDevisAttenteChaff", CnxAux.CnxSQLOpen) With {.CommandType = CommandType.StoredProcedure}
      cmdLoadList.Parameters.Add("@npernum", SqlDbType.Int).Value = strNPERNUM

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(ds)

      GCRECEPTIONS.DataSource = ds.Tables(0)

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Devis_frmDevisAttenteChaffDetail_SubDevisLoad + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Dim fileName As String = String.Format("{0}\StatsDevisAttenteChaff_{1}_{2}{3}{4}_{5}{6}.xls", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), LabelDetail.Text, Today.Year, Today.Month, Today.Day, TimeOfDay.Hour, TimeOfDay.Minute)
    GCRECEPTIONS.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub
End Class