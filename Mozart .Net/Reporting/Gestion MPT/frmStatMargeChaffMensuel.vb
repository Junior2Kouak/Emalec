Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports MozartLib

Public Class frmStatMargeChaffMensuel

  Dim calendar_open As String
  Private highlightedColumn As GridColumn
  Private highlightedRowHandle As Integer = -1
  Private prevHighlightedRowHandle As Integer = -1
  Dim oGestConnectSQL As New CGestionSQL


  Private Sub frmStatMargeChaffMensuel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try

      Dim DateMaxANAHISTO As Nullable(Of DateTime)

      'init boutons
      Initboutons(Me)

      'on ouvre la connexion  
      If oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        'on rempli les combo mois et année
        CboMois.DisplayMember = "VALUE"
        CboMois.ValueMember = "ID"
        CboMois.DataSource = ModDataGridView.LoadList("SELECT 1 AS VALUE,1 AS ID UNION SELECT 2,2 UNION SELECT 3,3 UNION SELECT 4,4 UNION SELECT 5,5 UNION SELECT 6,6 UNION SELECT 7,7 UNION SELECT 8,8 UNION SELECT 9,9 UNION SELECT 10,10 UNION SELECT 11,11 UNION SELECT 12,12", oGestConnectSQL.CnxSQLOpen)

        CboAnnee.ValueMember = "ID"
        CboAnnee.DisplayMember = "VALUE"
        CboAnnee.DataSource = ModDataGridView.LoadList("SELECT 2016 AS ID, 2016 AS VALUE UNION SELECT 2017,2017 UNION SELECT 2018, 2018 UNION SELECT 2019, 2019 UNION SELECT 2020, 2020", oGestConnectSQL.CnxSQLOpen)

        'sélection automatique de la date max
        Dim sqlcmdauto As New SqlCommand("select MAX(DDATCRE) AS DDATEMAX FROM TANAHISTO WHERE VSOCIETE = '" + MozartParams.NomSociete + "'", oGestConnectSQL.CnxSQLOpen)
        Dim drauto As SqlDataReader = sqlcmdauto.ExecuteReader
        If drauto.HasRows Then
          drauto.Read()
          DateMaxANAHISTO = Convert.ToDateTime(drauto("DDATEMAX"))
        End If
        drauto.Close()

        If IsDBNull(DateMaxANAHISTO) = False Then
          CboMois.SelectedValue = DatePart(DateInterval.Month, CType(DateMaxANAHISTO, DateTime))
          CboAnnee.SelectedValue = DatePart(DateInterval.Year, CType(DateMaxANAHISTO, DateTime))
          'affichage auto du max date
          ChargeListe(CboMois.SelectedValue, CboAnnee.SelectedValue, MozartParams.NomSociete)
        End If
      End If

    Catch ex As Exception
      MessageBox.Show("Sub Load() frmStatMargeChaffMensuel : " + ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As EventArgs) Handles BtnFermer.Click
    Close()
  End Sub

  Private Sub BtValider_Click(sender As System.Object, e As EventArgs) Handles BtValider.Click
    ChargeListe(CboMois.SelectedValue, CboAnnee.SelectedValue, MozartParams.NomSociete)
  End Sub

  Private Sub ChargeListe(ByVal iNumMois As Integer, ByVal iNumAnnee As Integer, ByVal sNomSociete As String)
    Try

      Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_StatMargeGlobaleParChaffEtPeriode", MozartDatabase.cnxMozart)
      CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.Parameters.Add("@p_moisnum", SqlDbType.Int).Value = iNumMois
        CmdSql.Parameters.Add("@p_anneenum", SqlDbType.Int).Value = iNumAnnee
        CmdSql.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = MozartParams.NomSociete

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GCStat.DataSource = dtStat.Tables(0)
        ChartControl1.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show("Sub ChargeListe() frmStatMargeChaffMensuel : " + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub GVStat_EndSorting(sender As Object, e As EventArgs) Handles GVStat.EndSorting
    GVStat.MoveFirst()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

  ' Gère la forme du curseur et la couleur des cellules au passage de la souris sur les cellules cliquables.
  Private Sub GVStat_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles GVStat.MouseMove

    Dim hInfo As GridHitInfo = GVStat.CalcHitInfo(e.Location)

    If hInfo.InRowCell = True And (hInfo.Column Is GVStat.Columns.ColumnByName("VCHAFF")) Then
      GCStat.Cursor = Cursors.Hand
      prevHighlightedRowHandle = highlightedRowHandle
      highlightedColumn = hInfo.Column
      highlightedRowHandle = hInfo.RowHandle
      GVStat.RefreshRow(highlightedRowHandle)
      GVStat.RefreshRow(prevHighlightedRowHandle)

    Else
      GCStat.Cursor = Cursors.Default
      highlightedColumn = Nothing
      GVStat.RefreshRow(highlightedRowHandle)
      GVStat.RefreshRow(prevHighlightedRowHandle)
    End If

  End Sub

  Private Sub GVStat_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GVStat.RowCellStyle
    If ((e.Column Is highlightedColumn) AndAlso (e.RowHandle = highlightedRowHandle)) Then
      e.Appearance.BackColor = Color.LightBlue
    End If
  End Sub
End Class