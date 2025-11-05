Imports System.Data.SqlClient
Imports MozartLib

Public Class FrmStatComptaStructure

  Dim dsstat As DataSet

  Private Sub FrmStatComptaStructure_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    ChargeListe()

  End Sub


  Private Sub ChargeListe()

    Dim CmdSql As New SqlCommand("[api_sp_StatComptaStructure]", MozartDatabase.cnxMozart)
    CmdSql.CommandType = CommandType.StoredProcedure
        Dim sqlreader As SqlDataReader = CmdSql.ExecuteReader

        Dim dtLevel1 As New DataTable
        dtLevel1.Columns.Add("ANNEE", Type.GetType("System.Int32"))
        dtLevel1.Columns.Add("TOT_CA", Type.GetType("System.Int32"))
        dtLevel1.Columns.Add("NBPER", Type.GetType("System.Int32"))
        dtLevel1.Columns.Add("RATIO", Type.GetType("System.Decimal"))

        While sqlreader.Read()
            dtLevel1.Rows.Add(sqlreader.Item("ANNEE"), sqlreader.Item("TOT_CA"), sqlreader.Item("NBPER"), sqlreader.Item("RATIO"))
        End While
        sqlreader.NextResult()

        Dim dtLevel2 As New DataTable
        dtLevel2.Columns.Add("ANNEE", Type.GetType("System.Int32"))
        dtLevel2.Columns.Add("VPERNOM", Type.GetType("System.String"))
        dtLevel2.Columns.Add("VPERPRE", Type.GetType("System.String"))
        dtLevel2.Columns.Add("VSOCIETE", Type.GetType("System.String"))
        dtLevel2.Columns.Add("DPERENT", Type.GetType("System.String"))
        dtLevel2.Columns.Add("DPERSOR", Type.GetType("System.String"))

        While sqlreader.Read()
            dtLevel2.Rows.Add(sqlreader.Item("ANNEE"), sqlreader.Item("VPERNOM"), sqlreader.Item("VPERPRE"), sqlreader.Item("VSOCIETE"), sqlreader.Item("DPERENT"), sqlreader.Item("DPERSOR"))
        End While

        dsstat = New DataSet

        dsstat.Tables.Add(dtLevel1)
        dsstat.Tables.Add(dtLevel2)

        GCStat.DataSource = dsstat.Tables(0)

        ChartCtrlCA.DataSource = GCStat.DataSource

    End Sub

    Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click

        Me.Close()

    End Sub

    Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
        Dim oScreenShot As New CSreenShot(Me, True)
        oScreenShot.Print_Form()
    End Sub

    Private Sub GVStat_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GVStat.RowCellClick

        If e.Button = MouseButtons.Left And e.RowHandle <> -1 Then

            Dim sMsg As String = ""

            Dim drDetail As DataRow = GVStat.GetDataRow(e.RowHandle)

            If Not drDetail Is Nothing Then

                Select Case e.Column.FieldName

                    Case "NBPER"

                        'MsgBox(drDetail.Item("NBPER"))
                        'dsstat.Tables(1).Select("[ANNEE] = " & drDetail.Item("ANNEE")).CopyToDataTable()

                        Dim ofrmStatComptaStructureDetail As New frmStatComptaStructureDetail(dsstat.Tables(1).Select("[ANNEE] = " & drDetail.Item("ANNEE")).CopyToDataTable())
                        ofrmStatComptaStructureDetail.ShowDialog()


                End Select

            End If

        End If

    End Sub

End Class