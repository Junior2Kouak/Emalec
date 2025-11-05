Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraPivotGrid
Imports MozartLib

Public Class frmTableAnalytiqueH

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub frmTableAnalytiqueH_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Initboutons(Me)

    RemplirCombo()

    'select par defaut
    CboMois.EditValue = DateAdd(DateInterval.Month, -1, Now).Month
    CboAnnee.EditValue = DateAdd(DateInterval.Month, -1, Now).Year

    'LoadData()

  End Sub
  Private Sub RemplirCombo()

    Dim i As Integer

    Dim dtMois As New DataTable
    Dim dtAnnee As New DataTable

    dtMois.Columns.Add("NIDMOIS", Type.GetType("System.Int32"))
    dtMois.Columns.Add("SMOISNAME", Type.GetType("System.String"))

    dtAnnee.Columns.Add("NIDANNEE", Type.GetType("System.Int32"))

    i = 0
    For i = 0 To 11

      'CboMois.Properties.Items.Add(New CDateMonth(i + 1, MonthName(i + 1)))
      Dim drnew As DataRow = dtMois.NewRow
      drnew.Item("NIDMOIS") = i + 1
      drnew.Item("SMOISNAME") = MonthName(i + 1)

      dtMois.Rows.Add(drnew)

    Next

    CboMois.Properties.DataSource = dtMois

    For i = 0 To 5

      Dim drnew As DataRow = dtAnnee.NewRow
      drnew.Item("NIDANNEE") = Year(DateAdd("yyyy", -i, Now))
      dtAnnee.Rows.Add(drnew)

    Next

    CboAnnee.Properties.DataSource = dtAnnee

  End Sub

  Private Sub LoadData()

    Me.Cursor = Cursors.WaitCursor

    Try

      PGCHeures.DataSource = ModDataGridView.LoadList(String.Format("exec [api_sp_CalculHeureTechNET] {0}, {1}", CboMois.EditValue, CboAnnee.EditValue), MozartDatabase.cnxMozart)

      Me.Text = My.Resources.Global_tableauAnalytique & CboMois.Text & " " & CboAnnee.Text
            LblTitre.Text = My.Resources.Global_tableauAnalytique & CboMois.Text & " " & CboAnnee.Text
            LblRef.Text = "§Heures réf : §" & RechercheHeureRef(CboMois.EditValue, CboAnnee.EditValue)

        Catch ex As Exception
            MessageBox.Show(My.Resources.Global_AnalytiqueH_LoadData + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub PGCHeures_CellClick(sender As Object, e As DevExpress.XtraPivotGrid.PivotCellEventArgs) Handles PGCHeures.CellClick

        If e.RowValueType = PivotGridValueType.GrandTotal Then Exit Sub
        If e.ColumnValueType = PivotGridValueType.GrandTotal Then Exit Sub

        If Not e.ColumnField Is Nothing AndAlso e.ColumnField.FieldName = "NCANNUM" Then

            Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()

            If e.DisplayText <> "" Then
                'If ds.Item(0)("NCANNUM") = 999 Then

                '    Dim oFrmTableDetailH99 As New frmTableCte99(ds.Item(0)("NCANNUM"), ds.Item(0)("VPERNOM"), ds.Item(0)("NPERNUM"), CboMois.EditValue, CboAnnee.EditValue, "HEURE")
                '    oFrmTableDetailH99.Show()

                'Else

                If ds.Item(0)("CPERTYP").ToString.ToUpper = "TE" Then

                    Dim oFrmTableDetailH As New frmTableHDetail(ds.Item(0)("NCANNUM"), ds.Item(0)("VPERNOM"), ds.Item(0)("NPERNUM"), CboMois.EditValue, CboAnnee.EditValue, "HEURE")
                    oFrmTableDetailH.Show()

                End If

            End If

        End If

    End Sub

    Private Sub PGCHeures_CustomCellValue(sender As Object, e As DevExpress.XtraPivotGrid.PivotCellValueEventArgs) Handles PGCHeures.CustomCellValue

        If e.DataField.FieldName = "TOTALHR" AndAlso e.Value = 0 Then e.Value = ""

    End Sub

    Private Sub frmTableAnalytiqueH_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged

        PGCHeures.Size = New Size(Me.Size.Width - PGCHeures.Location.X - 30, Me.Size.Height - PGCHeures.Location.Y - 80)

    End Sub

    Private Sub CboMois_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles CboMois.EditValueChanged

        If Not CboAnnee.EditValue Is Nothing AndAlso CboAnnee.EditValue.ToString <> "" Then

            LoadData()

        End If

    End Sub

    Private Sub CboAnnee_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles CboAnnee.EditValueChanged

        If Not CboMois.EditValue Is Nothing AndAlso CboAnnee.EditValue.ToString <> "" Then

            LoadData()

        End If

    End Sub

    Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click

        PGCHeures.ShowPrintPreview()

    End Sub

  Private Sub BtnExportXLS_Click(sender As Object, e As EventArgs) Handles BtnExportXLS.Click
    SFD.Filter = "Fichiers XLSX |*.XLSX"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then
      PGCHeures.ExportToXlsx(SFD.FileName)
    End If
  End Sub
End Class



