Imports System.Data.SqlClient
Imports DevExpress.XtraPrinting
Imports MozartLib

Public Class frmTableauBordEI
  Dim CnxEI As New CGestionSQL
  Dim dtAnnee As DataTable
  Dim ds As DataSet

  Private Sub frmTableauBordEI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    Try
      If CnxEI.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then
        'test si plusieurs ecrans.
        If Screen.AllScreens.Count > 1 Then
          Me.Left = Screen.PrimaryScreen.WorkingArea.Width
        End If

        lblDateJour.Text = ", le " & Date.Today

        Me.WindowState = FormWindowState.Maximized

        Load_CboAnnee()

      Else
        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmTableauBordEI_sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Load_CboAnnee()

    dtAnnee = New DataTable

    dtAnnee.Columns.Add("IDANNEE", Type.GetType("System.Int16"))
    dtAnnee.Columns.Add("ANNEE", Type.GetType("System.Int16"))

    Dim iAnnee As Int16 = Year(Now)

    While iAnnee > 2010

      Dim drNew As DataRow = dtAnnee.NewRow()
      drNew.Item("IDANNEE") = iAnnee
      drNew.Item("ANNEE") = iAnnee
      dtAnnee.Rows.Add(drNew)

      iAnnee = iAnnee - 1

    End While

    cboAnnee.DisplayMember = "ANNEE"
    cboAnnee.ValueMember = "IDANNEE"

    cboAnnee.DataSource = dtAnnee
  End Sub

  Private Sub LoadDataGridView(ByVal p_iAnnee As Int16)

    Try

      Me.Cursor = Cursors.WaitCursor

      ds = New DataSet

      Dim cmdLoadList As New SqlCommand("api_sp_TableauBordEI", CnxEI.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure
      'sqlcmd
      cmdLoadList.Parameters.Add("@iAnnee", SqlDbType.Int)
      cmdLoadList.Parameters("@iAnnee").Value = p_iAnnee

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(ds)

      GCStat.DataSource = ds.Tables(0)

      'CLIENT.GroupIndex = 0

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmTableauBordEI_sub2 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    Finally

      Me.Cursor = Cursors.Default

    End Try

  End Sub

  Private Sub btnValid_Click(sender As System.Object, e As System.EventArgs) Handles btnValid.Click
    LoadDataGridView(Convert.ToInt16(cboAnnee.SelectedValue))
    LblTitre.Text = My.Resources.Reporting_RealisationMPT_frmTableauBordEI_tab & cboAnnee.SelectedValue
  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()

  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    If GVStat.RowCount = 0 Then Exit Sub
    'GCStat.Print()

    Dim HeaderFooter As New PageHeaderFooter()

    HeaderFooter = PrintComponentLink.PageHeaderFooter
    HeaderFooter.Header.Content.Item(1) = HeaderFooter.Header.Content.Item(1) & " - " & cboAnnee.SelectedValue

    PrintComponentLink.PageHeaderFooter = HeaderFooter
    PrintComponentLink.CreateDocument()
    PrintComponentLink.PrintDlg()

  End Sub

  Private Sub BtnExportPdf_Click(sender As System.Object, e As System.EventArgs) Handles BtnExportPdf.Click

    If GVStat.RowCount = 0 Then Exit Sub

    Try

      SFD.FileName = ""
      SFD.Filter = "Fichiers PDF (*.pdf)|*.pdf"
      SFD.ShowDialog()

      If SFD.FileName <> "" Then


        Dim HeaderFooter As New PageHeaderFooter()

        HeaderFooter = PrintComponentLink.PageHeaderFooter
        HeaderFooter.Header.Content.Item(1) = HeaderFooter.Header.Content.Item(1) & " - " & cboAnnee.SelectedValue

        PrintComponentLink.PageHeaderFooter = HeaderFooter
        PrintComponentLink.CreateDocument()
        PrintComponentLink.ExportToPdf(SFD.FileName)

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmTableauBordEI_sub3 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub GVStat_EndSorting(sender As Object, e As System.EventArgs) Handles GVStat.EndSorting

    GVStat.TopRowIndex = 0
    GVStat.FocusedRowHandle = 0

  End Sub

  Private Sub GVStat_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GVStat.RowCellClick

    If e.Column.FieldName = "N4" Then

      If e.RowHandle < 0 Then Exit Sub

      Dim dtrow As DataRow = GVStat.GetDataRow(e.RowHandle)

      If dtrow.Item("N4").ToString <> "" Then

        GRPApercu.Visible = True
        WBApercu.Navigate("about:blank")
        GCN4.DataSource = PathFileCertificatN4(dtrow.Item("NSITNUM"), cboAnnee.SelectedValue)


      Else

        GRPApercu.Visible = False
        WBApercu.Navigate("about:blank")
        GCN4.DataSource = Nothing

      End If

    Else

      GRPApercu.Visible = False
      WBApercu.Navigate("about:blank")
      GCN4.DataSource = Nothing

    End If

  End Sub

  Private Function PathFileCertificatN4(ByVal p_iNSITNUM As Int32, ByVal p_YEAR As Int32) As DataTable

    Try

      Dim dtTmp As New DataTable

      Dim sqlcmd As New SqlCommand("[api_sp_RetourInfoFileCRVPN4]", CnxEI.CnxSQLOpen)
      sqlcmd.CommandType = CommandType.StoredProcedure
      sqlcmd.Parameters.Add("@p_NSITNUM", SqlDbType.Int).Value = p_iNSITNUM
      sqlcmd.Parameters.Add("@p_YEAR", SqlDbType.Int).Value = p_YEAR

      dtTmp.Load(sqlcmd.ExecuteReader)

      Return dtTmp

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmTableauBordEI_dans + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Return Nothing

    End Try

  End Function

  Private Sub GVN4_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GVN4.RowCellClick

    Dim dtrow As DataRow = GVN4.GetDataRow(e.RowHandle)

    WBApercu.Navigate(dtrow.Item("VPATHFICHIER"))

  End Sub

  Private Sub BtnExportXLS_Click(sender As Object, e As EventArgs) Handles BtnExportXLS.Click

    If GVStat.RowCount = 0 Then Exit Sub

    Try

      SFD.FileName = ""
      SFD.Filter = "Fichiers EXCEL (*.xlsx)|*.xlsx"
      SFD.ShowDialog()

      If SFD.FileName <> "" Then


        PrintComponentLink.CreateDocument()
        PrintComponentLink.ExportToXlsx(SFD.FileName)

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmTableauBordEI_sub3 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub
End Class