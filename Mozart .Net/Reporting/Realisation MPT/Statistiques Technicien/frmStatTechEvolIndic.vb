Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPivotGrid
Imports MozartLib

Public Class frmStatTechEvolIndic

  Dim dtData As DataTable

  Public sDateDebut As Date
  Public sDateFin As Date

  Private Sub frmStatTechEvolIndic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'sDateFin = DateAdd(DateInterval.Day, -Now.Date.Day, Now.Date)
    'sDateDebut = DateAdd(DateInterval.Month, -12, sDateFin)

    LblPeriode.Text = "Période du " & sDateDebut.ToShortDateString & " au " & sDateFin.ToShortDateString

    SetNameCol()

    loaddata()

    GCStatEvolTech.DataSource = dtData

  End Sub

  Private Sub loaddata()

    dtData = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_StatistiqueTechEvolIndic]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@Date_Debut", SqlDbType.VarChar).Value = sDateDebut
        sqlcmd.Parameters.Add("@Date_Fin", SqlDbType.VarChar).Value = sDateFin
        dtData.Load(sqlcmd.ExecuteReader)

    End Sub

    Private Sub SetNameCol()

        Dim i As Int32 = 1
        Dim sDateActu As Date = sDateDebut
        Dim sCol As String


        While sDateActu < sDateFin

            sCol = DatePart(DateInterval.Month, sDateActu.AddMonths(1)).ToString("00") & "-" & DatePart(DateInterval.Year, sDateActu.AddMonths(1)).ToString()

            Select Case i
                Case 1 : GCol_COL_1.Caption = sCol
                Case 2 : GCol_COL_2.Caption = sCol
                Case 3 : GCol_COL_3.Caption = sCol
                Case 4 : GCol_COL_4.Caption = sCol
                Case 5 : GCol_COL_5.Caption = sCol
                Case 6 : GCol_COL_6.Caption = sCol
                Case 7 : GCol_COL_7.Caption = sCol
                Case 8 : GCol_COL_8.Caption = sCol
                Case 9 : GCol_COL_9.Caption = sCol
                Case 10 : GCol_COL_10.Caption = sCol
                Case 11 : GCol_COL_11.Caption = sCol
                Case 12 : GCol_COL_12.Caption = sCol
            End Select
            i = i + 1
            sDateActu = DateAdd(DateInterval.Month, 1, sDateActu)

        End While

    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Dim oScreenShot As New CSreenShot(Me, True)
        oScreenShot.Print_Form()
    End Sub

  Private Sub GVStatEvolTech_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GVStatEvolTech.RowCellClick

    If e.RowHandle > -1 Then

      Dim dr As DataRow = GVStatEvolTech.GetDataRow(e.RowHandle)

      Dim oFrmGraphDetail As New frmStatTechEvolIndic_Detail(dr.Item("VPERNOM"), sDateDebut, sDateFin, dr.Item("NPERNUM"), dr.Item("VNOMSTAT"))
      oFrmGraphDetail.ShowDialog()

    End If

  End Sub

  Private Sub BtnExportXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click


    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\StatsEMALEC_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GVStatEvolTech.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))

    '    SFDSynCompta.Filter = "Fichiers EXCEL (*.xls)|*.xls"
    '   SFDSynCompta.ShowDialog()

    'If SFDSynCompta.FileName <> "" Then

    'GVStatEvolTech.OptionsPrint.AutoWidth = False
    'GVStatEvolTech.ExportToXls(SFDSynCompta.FileName)

    'End If



    'MessageBox.Show("Exportation impossible !", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)



  End Sub
End Class