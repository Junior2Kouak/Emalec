Imports System.Data.SqlClient
Imports DevExpress.Data.Filtering
Imports MozartLib

Public Class frmSitesActifsTousClients

  Private Sub frmSitesActifsTousClients_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    ChargeListe(1)

  End Sub

  Private Sub ChargeListe(ByVal limite12Mois As Int16)

    Try

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_GetSitesActifsTousClients", MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.CommandTimeout = 0
        CmdSql.Parameters.Add("@LimiteDI12Mois", SqlDbType.Bit).Value = limite12Mois

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        For cpt = 0 To dtStat.Tables(0).Rows.Count - 1

          Dim sRegion As String = dtStat.Tables(0).Rows(cpt).ItemArray.GetValue(7).ToString  ' On récupère la liste des régions
          If Not CheckedListBox1.Items.Contains(sRegion) Then
            CheckedListBox1.Items.Add(sRegion)
          End If
        Next cpt

        GridControl1.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

        GridControl1.Focus()

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmSitesActifsTousClients_Load + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub ButtonCarte_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCarte.Click

    Dim NSITNUM, VSITNOM, VCLINOM As String

    ' If GridView1.RowCount < 1 Or GridView1.RowCount > 5000 Then   '  NL : Jean veut tout sur la carte...
    'MsgBox("Le nombre de lignes sélectionnées doit être compris entre 1 et 5000.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Visualisation carte")
    'Exit Sub
    'End If

    Try

      Me.Cursor = Cursors.WaitCursor

      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_Initialiser_TTMP_SitesActifsTousClients", MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.Parameters.Add("@NPERNUM", SqlDbType.Int).Value = MozartParams.UID

        ' 1 Récupérer la liste des sites sélectionnés
        For cpt = 0 To GridView1.RowCount - 1
          NSITNUM = GridView1.GetRowCellValue(cpt, "NSITNUM").ToString
          VSITNOM = GridView1.GetRowCellValue(cpt, "VSITNOM").ToString
          VCLINOM = GridView1.GetRowCellValue(cpt, "VCLINOM").ToString
          If cpt = 0 Then
            CmdSql.Parameters.Add("@NSITNUM", SqlDbType.Int).Value = NSITNUM
            CmdSql.Parameters.Add("@VCLINOM", SqlDbType.VarChar).Value = Replace(VCLINOM, "'", "''")
            CmdSql.Parameters.Add("@VSITNOM", SqlDbType.VarChar).Value = Replace(VSITNOM, "'", "''")
            CmdSql.Parameters.Add("@BDELETE", SqlDbType.Int).Value = 1
          Else
            CmdSql.Parameters.Item("@NSITNUM").Value = NSITNUM
            CmdSql.Parameters.Item("@VCLINOM").Value = Replace(VCLINOM, "'", "''")
            CmdSql.Parameters.Item("@VSITNOM").Value = Replace(VSITNOM, "'", "''")
            CmdSql.Parameters.Item("@BDELETE").Value = 0
          End If

          ' 2 La stocker dans la table temporaire TTMP_SitesActifsTousClients
          CmdSql.ExecuteNonQuery()

        Next

        CmdSql.Dispose()
        CmdSql = Nothing

        ' 3 Appeler la map qui récupèrera ces infos
        ' TB SAMSIC CITY SPEC
        If MozartParams.NomGroupe = "EMALEC" Then
          FrmBrowser.StartingAddress = "https://maps.emalec.com/SitesTousClients.asp?base=MULTI&NPERNUM=" & MozartParams.UID & "&APP=" & MozartParams.NomSociete
        End If ' TODO_TB SAMSIC CITY -> else pour samsic
        FrmBrowser.ShowDialog()
      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmSitesActifsTousClients_SubClick + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\LstSitesActifsTsClients_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GridControl1.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    Dim expr As CriteriaOperatorCollection = New CriteriaOperatorCollection

    For i = 0 To CheckedListBox1.CheckedItems.Count - 1
      Dim expr0 As CriteriaOperator = New BinaryOperator("nregcod", CheckedListBox1.CheckedItems(i))
      expr.Add(expr0)
    Next i

    If expr.Count > 0 Then
      GridView1.ActiveFilterCriteria = GroupOperator.Combine(GroupOperatorType.Or, expr)
      Button2.Visible = True
    End If

  End Sub

  Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
    GridView1.ActiveFilter.Clear()
    For i = 0 To CheckedListBox1.Items.Count - 1
      CheckedListBox1.SetItemChecked(i, False)
    Next (i)

    Button2.Visible = False
  End Sub

  Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
    GridView1.Columns(0).Visible = False
    GridView1.Columns(2).Visible = False
    GridView1.Columns(3).Visible = False
    GridView1.Columns(4).Visible = False
    GridView1.Columns(6).Visible = False
    GridView1.Columns("nregcod").VisibleIndex = 0
    Label1.Visible = False
    CheckedListBox1.Visible = False
    Button1.Visible = False
    Button2.Visible = False
    Button3.Visible = False
    Button4.Visible = True
    GridControl1.Width = 700
  End Sub

  Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
    GridView1.Columns(0).Visible = True
    GridView1.Columns(1).Visible = True
    GridView1.Columns(2).Visible = True
    GridView1.Columns(3).Visible = True
    GridView1.Columns(4).Visible = True
    GridView1.Columns(5).Visible = True
    GridView1.Columns(6).Visible = True
    GridView1.Columns(7).Visible = True
    GridView1.Columns("NCLINUM").VisibleIndex = 0
    GridView1.Columns("VCLINOM").VisibleIndex = 1
    GridView1.Columns("NSITNUM").VisibleIndex = 2
    GridView1.Columns("VSITNOM").VisibleIndex = 3
    GridView1.Columns("VSITPAYS").VisibleIndex = 4
    GridView1.Columns("VSITVIL").VisibleIndex = 5
    GridView1.Columns("VSITCP").VisibleIndex = 6
    GridView1.Columns("nregcod").VisibleIndex = 7
    Label1.Visible = True
    CheckedListBox1.Visible = True
    Button1.Visible = True
    Button2.Visible = True
    Button3.Visible = True
    Button4.Visible = False
    GridControl1.Width = 1020
  End Sub
End Class