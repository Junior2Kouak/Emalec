Imports System.Data.SqlClient
Imports MozartLib

Public Class frmListeClientsEI

  Dim dtstat As DataTable

  Private Sub frmListeClientsEI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try

      Me.Cursor = Cursors.WaitCursor
      LoadData()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmListesClientsEI_Sub + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub LoadData()

    Dim CmdSql As New SqlCommand("api_sp_ListeClientsEI", MozartDatabase.cnxMozart)
    CmdSql.CommandType = CommandType.StoredProcedure

    dtstat = New DataTable
    dtstat.Load(CmdSql.ExecuteReader)

    GCListeClientsEI.DataSource = dtstat

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
    'GCListeClientsEI.Print()

    If MessageBox.Show(My.Resources.Global_imprimer_tab, My.Resources.Global_ConfirmationI, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

      GVListeClientsEI.OptionsPrint.AutoWidth = True

      Dim ps As New DevExpress.XtraPrinting.PrintingSystemBase()
      Dim link As DevExpress.XtraPrintingLinks.PrintableComponentLinkBase = New DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(ps)
      link.Component = GCListeClientsEI
      link.Landscape = True
      link.Margins.Left = 1
      link.Margins.Right = 1
      link.Margins.Top = 1
      link.Margins.Bottom = 1
      link.CreateDocument()

      Dim tReportPrintTool As New DevExpress.XtraPrinting.PrintTool(link.PrintingSystemBase)
      tReportPrintTool.ShowPreviewDialog()
      'link.PrintingSystemBase.ExportToPdf(SFDSynCompta.FileName)

    End If

  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\StatsEMALEC_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCListeClientsEI.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub GVListeClientsEI_CustomDrawFooter(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GVListeClientsEI.CustomDrawFooter

    Dim oPos As Rectangle = e.Bounds
    Dim oFormat As New StringFormat
    oPos.Location = New Point(oPos.Left + 1, oPos.Top + 5)
    oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)
    oFormat.Alignment = StringAlignment.Center
    e.Appearance.DrawString(e.Cache, String.Format(My.Resources.Global_Selection_0_1, GVListeClientsEI.RowCount, GCListeClientsEI.DataSource.Rows.Count), oPos, oFormat)
    e.Handled = True

  End Sub

  Private Sub GVListeClientsEI_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVListeClientsEI.FocusedRowChanged

    WBApercu.Navigate("about:blank")

    If e.FocusedRowHandle < 0 Then Exit Sub

    Dim drSelected As DataRow = GVListeClientsEI.GetDataRow(e.FocusedRowHandle)

    If File.Exists(gstrCheminDocClientWeb & drSelected.Item("VFICHIER")) Then

      WBApercu.Navigate(gstrCheminDocClientWeb & drSelected.Item("VFICHIER"))

    End If


  End Sub

  Private Sub btnCreerContratEI_Click(sender As System.Object, e As System.EventArgs) Handles btnCreerContratEI.Click

    Try
      ' On récupère le n° unique NTELNUM sélectionné dans la liste
      Me.Cursor = Cursors.WaitCursor
      Dim ligne_selectionnee As Integer() = GVListeClientsEI.GetSelectedRows()
      Dim miNumClient As String = GVListeClientsEI.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NCLINUM").ToString
      Dim NIDPROC As Int32 = GVListeClientsEI.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NIDPROC")

      Dim ofrmStarterContratEI As New frmStarterContratEI(miNumClient, NIDPROC, "C")
      ofrmStarterContratEI.ShowDialog()

      LoadData()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    Finally
      Me.Cursor = Cursors.Default
    End Try


  End Sub

  Private Sub BtnModifContratEI_Click(sender As System.Object, e As System.EventArgs) Handles BtnModifContratEI.Click

    Try

      ' On récupère le n° unique NTELNUM sélectionné dans la liste
      Me.Cursor = Cursors.WaitCursor
      Dim ligne_selectionnee As Integer() = GVListeClientsEI.GetSelectedRows()
      Dim miNumClient As String = GVListeClientsEI.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NCLINUM").ToString
      Dim NIDPROC As Int32 = GVListeClientsEI.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NIDPROC")

      'si pas de présence contrat alors on interdit la modif il faut passer apr la création
      If GVListeClientsEI.GetRowCellValue(ligne_selectionnee.ElementAt(0), "VCONTEI") = "NON" Then MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmListesClientsEI_modif_impo, My.Resources.Global_Information, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

      'on interdit la modif si le contrat a été signé
      If GVListeClientsEI.GetRowCellValue(ligne_selectionnee.ElementAt(0), "VCONTEISIGN") = "OUI" Then MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmListesClientsEI_modif_impo_signé, My.Resources.Global_Information, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

      WBApercu.Navigate("about:blank")

      Dim ofrmStarterContratEI As New frmStarterContratEI(miNumClient, NIDPROC, "M")
      ofrmStarterContratEI.ShowDialog()

      LoadData()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnRelanceCont_Click(sender As System.Object, e As System.EventArgs) Handles BtnRelanceCont.Click



    Dim RowHdl As Int32 = GVListeClientsEI.FocusedRowHandle

    If RowHdl < 0 Then Exit Sub

    Try
      ' On récupère le n° unique NTELNUM sélectionné dans la liste
      Me.Cursor = Cursors.WaitCursor
      Dim ligne_selectionnee As Integer() = GVListeClientsEI.GetSelectedRows()
      Dim miNumClient As String = GVListeClientsEI.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NCLINUM").ToString
      Dim NIDPROC As Int32 = GVListeClientsEI.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NIDPROC")

      'si pas de présence contrat alors on interdit la modif il faut passer apr la création
      If GVListeClientsEI.GetRowCellValue(ligne_selectionnee.ElementAt(0), "VCONTEI") = "NON" Then MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmListesClientsEI_modif_impo, My.Resources.Global_Information, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

      'on interdit la modif si le contrat a été signé
      If GVListeClientsEI.GetRowCellValue(ligne_selectionnee.ElementAt(0), "VCONTEISIGN") = "OUI" Then MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmListesClientsEI_modif_impo_signé, My.Resources.Global_Information, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

      WBApercu.Navigate("about:blank")

      Dim ofrmStarterContratEI As New frmStarterContratEI(miNumClient, NIDPROC, "R")
      ofrmStarterContratEI.ShowDialog()

      LoadData()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    Finally
      Me.Cursor = Cursors.Default
    End Try

    Dim drSelected As DataRow = GVListeClientsEI.GetDataRow(RowHdl)

    If File.Exists(gstrCheminDocClientWeb & drSelected.Item("VFICHIER")) Then

      WBApercu.Navigate(gstrCheminDocClientWeb & drSelected.Item("VFICHIER"))

    End If

  End Sub

  Private Sub BtnArchiverContEI_Click(sender As System.Object, e As System.EventArgs) Handles BtnArchiverContEI.Click

    If GVListeClientsEI.FocusedRowHandle < 0 Then Exit Sub

    Dim drSelected As DataRow = GVListeClientsEI.GetDataRow(GVListeClientsEI.FocusedRowHandle)

    If drSelected.Item("NIDPROC") > 0 Then

      Try

        If MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmListesClientsEI__archiver, My.Resources.Global_ConfirmerA, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

          Dim sqlDel As New SqlCommand("api_sp_ProcedureArchiver", MozartDatabase.cnxMozart)
          sqlDel.CommandType = CommandType.StoredProcedure
          sqlDel.Parameters.Add("@P_NIDPROC", SqlDbType.Int).Value = drSelected.Item("NIDPROC")
          sqlDel.ExecuteNonQuery()

        End If

      Catch ex As Exception
        MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmListesClientsEI_erreur & ex.Message)
      End Try

      LoadData()

    End If

  End Sub
End Class