Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Columns
Imports MozartLib

Public Class frmStatEMALEC

  Private Sub frmStatEMALEC_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    Initboutons(Me)

    ' TB SAMSIC CITY RES
    Text += MozartParams.NomGroupe
    LabelTitre.Text = LabelTitre.Text.Replace("#gstrNomGroupe#", MozartParams.NomGroupe)

    initSociete()

    ChargeListe()

  End Sub

  Private Sub ChargeListe()
    Try

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_StatistiqueEMALEC", MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.Parameters.Add("@SOCIETE", SqlDbType.VarChar).Value = cboSociete.Text

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GridControl1.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

        LabelTitre.Text = My.Resources.Reporting_EMALEC_stat & " " & cboSociete.Text & My.Resources.Global_le & " " & Date.Now.ToString("dd/MM/yyyy")

        Dim colonne As GridColumn = GridView1.Columns.Cast(Of GridColumn)().FirstOrDefault(Function(c) c.Caption = My.Resources.Global_valeur)
        colonne.Caption = My.Resources.Global_valeur_au & " " & Date.Now.ToString("dd/MM/yyyy")

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_EMALEC_sub + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub


  Private Sub initSociete()
    'initialisation de le combobox "Société"
    Dim i As Integer = 0

    If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

      Dim CmdSql As New SqlCommand("SELECT DISTINCT VSOCIETE FROM TDROIT WHERE NPERNUM = " & MozartParams.UID & " AND NMENUNUM = " & cboSociete.Tag & " AND CDROITVAL = 'O' ORDER BY VSOCIETE", MozartDatabase.cnxMozart)
      Dim dr As SqlDataReader = CmdSql.ExecuteReader
      While dr.Read() 'While données présentes, stocker les éléments en combobox
        cboSociete.Items.Add(dr("VSOCIETE"))
        i = i + 1
      End While

      If i > 1 Then
        ' Plusieurs société : on peut gérer le "groupe"
        cboSociete.Items.Add("GROUPE")
        cboSociete.SelectedItem = MozartParams.NomSociete
        Label2.Visible = True
        cboSociete.Visible = True
      Else
        cboSociete.SelectedIndex = 0
      End If

      dr.Close()
      CmdSql.Dispose()
      dr = Nothing

    End If
  End Sub

  Private Sub BtnFermer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnPrint.Click
    GridControl1.Print()
  End Sub

  Private Sub ButtonExporter_Click(sender As Object, e As EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\StatsEMALEC_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GridControl1.ExportToXls(fileName)
    Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))

  End Sub

  Private Sub BtValider_Click(sender As Object, e As EventArgs) Handles BtValider.Click
    ChargeListe()
  End Sub
End Class