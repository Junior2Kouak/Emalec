Imports System.Data.SqlClient
Imports MozartLib

Public Class frmStatEIReappro

  Private Sub frmStatEIReappro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try

      Me.Cursor = Cursors.WaitCursor

      LoadTableauStat()

      lblDateJour.Text = ", le " & Date.Today

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmStatEIReappro_sub + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub LoadTableauStat()

    Dim dsMain As New DataSet
    Dim dtMain As New DataTable

    'INIT
    dtMain = New DataTable("TMAIN")

    Dim cmd As New SqlCommand("api_sp_StatEI_Reappro", MozartDatabase.cnxMozart)
    cmd.CommandType = CommandType.StoredProcedure
        dtMain.Load(cmd.ExecuteReader)


        '--remplissage grille
        'VDDEQUICRE --VPERNOM  DDDEDATE  DDDELIVR   VLART    NDDENUM

        'VDDEQUICRE = RowSum.Field(Of String)("VDDEQUICRE"), _
        '                             VPERNOM = RowSum.Field(Of String)("VPERNOM"), DDDEDATE = RowSum.Field(Of String)("DDDEDATE"), _
        '                             DDDELIVR = RowSum.Field(Of String)("DDDELIVR"), NDDENUM = RowSum.Field(Of Int32)("NDDENUM")


        Dim reqList = From RowMain In dtMain.AsEnumerable
                      Group By NDINNUM = RowMain.Field(Of String)("NDINNUM"), VDDEQUICRE = RowMain.Field(Of String)("VDDEQUICRE"),
                                 VPERNOM = RowMain.Field(Of String)("VPERNOM"), DDDEDATE = RowMain.Field(Of String)("DDDEDATE"),
                                 DDDELIVR = RowMain.Field(Of String)("DDDELIVR"), NDDENUM = RowMain.Field(Of Int32)("NDDENUM") Into TotVart = Count()
                      Order By NDINNUM Descending


        '--1 ERE TABLE : MAIN
        Dim drStockDDE As New DataTable
        drStockDDE.TableName = "TSTOCKDDE_TMP"
        drStockDDE.Columns.Add("NDINNUM", Type.GetType("System.String"))
        drStockDDE.Columns.Add("VDDEQUICRE", Type.GetType("System.String"))
        drStockDDE.Columns.Add("VPERNOM", Type.GetType("System.String"))
        drStockDDE.Columns.Add("DDDEDATE", Type.GetType("System.DateTime"))
        drStockDDE.Columns.Add("DDDELIVR", Type.GetType("System.DateTime"))
        drStockDDE.Columns.Add("NDDENUM", Type.GetType("System.Int32"))

        For Each row In reqList

            Dim rownew As DataRow = drStockDDE.NewRow

            rownew.Item("NDINNUM") = row.NDINNUM
            rownew.Item("VDDEQUICRE") = row.VDDEQUICRE
            rownew.Item("VPERNOM") = row.VPERNOM
            rownew.Item("DDDEDATE") = row.DDDEDATE
            rownew.Item("DDDELIVR") = row.DDDELIVR
            rownew.Item("NDDENUM") = row.NDDENUM

            drStockDDE.Rows.Add(rownew)

        Next

        dsMain = New DataSet

        dsMain.Tables.Add(drStockDDE)
        dsMain.Tables.Add(dtMain)

        dsMain.Relations.Add("NDDENUM", dsMain.Tables("TSTOCKDDE_TMP").Columns("NDDENUM"), dsMain.Tables("TMAIN").Columns("NDDENUM"))

        'relation entre les  grid
        GCListeEIReappro.LevelTree.Nodes(0).RelationName = "NDDENUM"


        GCListeEIReappro.DataSource = dsMain.Tables(0)

        GCListeEIReappro.MainView = GVListeEIReappro
        GCListeEIReappro.LevelTree.Nodes(0).LevelTemplate = GVListeEIReapproDetail


    End Sub

    Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
        GCListeEIReappro.Print()
    End Sub

    Private Sub GVListeEIReappro_MasterRowExpanding(sender As Object, e As DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs) Handles GVListeEIReappro.MasterRowExpanding

        If e.RowHandle < -1 Then Exit Sub
        If GVListeEIReappro.SelectedRowsCount = 0 Then Exit Sub

        Dim dataRowMainSelect As DataRow = GVListeEIReappro.GetDataRow(e.RowHandle)

        GVListeEIReapproDetail.ViewCaption = String.Format(My.Resources.Reporting_RealisationMPT_frmStatEIReappro_numstock, dataRowMainSelect.Item("NDDENUM"))
    End Sub
End Class