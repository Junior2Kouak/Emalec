Imports System.Data.SqlClient
Imports MozartLib

Public Class frmStatMagasin2Details

  Dim strParam As String
  Dim strTypeDetail As String
  Dim CnxAux As New CGestionSQL

  Public Sub New(ByVal p_Param As Object, ByVal typeDetail As String)

    InitializeComponent()
    strParam = p_Param
    strTypeDetail = typeDetail

  End Sub

  Private Sub frmStatMagasin2Details_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Dim ds As DataSet

    Me.Cursor = Cursors.WaitCursor

    LabelType.Text = strTypeDetail
    LabelDate.Text = strParam

    If strTypeDetail = "Receptions" Then
      GridView1.Columns.ColumnByName("col1").Caption = My.Resources.Global_numCommande
      GridView1.Columns.ColumnByName("col1").Width = 100
      GridView1.Columns.ColumnByName("col2").Caption = My.Resources.Global_nomSTF
      GridView1.Columns.ColumnByName("col2").Width = 200
      GridView1.Columns.ColumnByName("col3").Caption = ""
      GridView1.Columns.ColumnByName("col3").Visible = False
      GridView1.Columns.ColumnByName("col4").Caption = ""
      GridView1.Columns.ColumnByName("col4").Visible = False
    ElseIf strTypeDetail = "Fournitures par colis" Then
      GridView1.Columns.ColumnByName("col1").Caption = My.Resources.Global_article
      GridView1.Columns.ColumnByName("col1").Width = 300
      GridView1.Columns.ColumnByName("col2").Caption = My.Resources.Global_Qte
      GridView1.Columns.ColumnByName("col2").Width = 100
      GridView1.Columns.ColumnByName("col3").Caption = ""
      GridView1.Columns.ColumnByName("col3").Visible = False
      GridView1.Columns.ColumnByName("col4").Caption = ""
      GridView1.Columns.ColumnByName("col4").Visible = False
    ElseIf strTypeDetail = "Equipement techniciens" Then
      GridView1.Columns.ColumnByName("col1").Caption = My.Resources.Global_Tech
      GridView1.Columns.ColumnByName("col2").Caption = "E/S"
      GridView1.Columns.ColumnByName("col3").Caption = My.Resources.Global_date_entrée
      GridView1.Columns.ColumnByName("col4").Caption = My.Resources.Global_date_sortie
    End If

    Try

      If CnxAux.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = False Then
        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

      ds = New DataSet

      Dim Param = Split(strParam, "/")
      Dim cmdLoadList As New SqlCommand("api_sp_StatMagasinReceptionDetails", CnxAux.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure
      cmdLoadList.Parameters.Add("@annee", SqlDbType.Int).Value = "20" & Param(1)
      cmdLoadList.Parameters.Add("@mois", SqlDbType.Int).Value = Param(0)
      cmdLoadList.Parameters.Add("@typeDetail", SqlDbType.VarChar).Value = strTypeDetail

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(ds)

      GCRECEPTIONS.DataSource = ds.Tables(0)

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Magasin_frmStatMagasin2Details_Receptions + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\StatsMagasin_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCRECEPTIONS.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub
End Class