Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports DevExpress.Pdf
Imports DevExpress.XtraPdfViewer
Imports MozartLib

Public Class FrmEditionAttachementByFacture

  Dim NFACNUM As Int32

  Dim dtListeAttachement As DataTable

  Public Sub New(ByVal c_NFACNUM As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    NFACNUM = c_NFACNUM

  End Sub

  Private Sub ListeAttachmentByFacture()

    dtListeAttachement = New DataTable

    Dim sqlCmdListe As New SqlCommand("api_sp_ListeAttachementByFacture", MozartDatabase.cnxMozart)
    sqlCmdListe.CommandType = CommandType.StoredProcedure
        sqlCmdListe.Parameters.Add("@p_nfacnum", SqlDbType.Int).Value = NFACNUM
        dtListeAttachement.Load(sqlCmdListe.ExecuteReader())

    End Sub

    Private Sub PrintAttachementByFacture(ByVal p_File As String)

        Try

            Dim pdf_file As New PdfViewer
            pdf_file.LoadDocument(p_File)
            pdf_file.ShowPrintStatusDialog = False
            Dim oPrintDefault As New PrinterSettings
            oPrintDefault.PrintFileName = p_File
            Dim pdfPrinterSettings As New PdfPrinterSettings(oPrintDefault)

            ' Specify the PDF printer settings.
            pdfPrinterSettings.PageOrientation = PdfPrintPageOrientation.Auto
            pdfPrinterSettings.PrintingDpi = 300
            pdf_file.Print(pdfPrinterSettings)

            pdf_file.CloseDocument()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub FrmEditionAttachementByFacture_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor

        ListeAttachmentByFacture()

        PBPrint.Minimum = 0
        PBPrint.Maximum = 100

        If MessageBox.Show(String.Format(My.Resources.Facturation_FrmEditionAttachementByFacture_print, dtListeAttachement.Rows.Count, NFACNUM), My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            BGW_PB.RunWorkerAsync()

            For Each drattach As DataRow In dtListeAttachement.Rows

                If File.Exists(drattach.Item("VFILEATTACH")) Then

                    If Path.GetExtension(drattach.Item("VFILEATTACH")).ToUpper = ".PDF" Then

                        PrintAttachementByFacture(drattach.Item("VFILEATTACH"))

                    End If

                Else

                    Me.Cursor = Cursors.Default
                    MessageBox.Show(String.Format(My.Resources.Facturation_FrmEditionAttachementByFacture_attach_inexi, drattach.Item("VFILEATTACH")))

                End If

            Next

        End If

        BGW_PB.CancelAsync()

        Me.Cursor = Cursors.Default

        Me.Close()

    End Sub

    Private Sub BGW_PB_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGW_PB.DoWork


        Dim i As Int32

        For i = 0 To 100 Step 1

            BGW_PB.ReportProgress(i)
            ' Simulate long task
            System.Threading.Thread.Sleep(500)

        Next


    End Sub

    Private Sub bgwDesign_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs) Handles BGW_PB.ProgressChanged

        PBPrint.Value = e.ProgressPercentage

    End Sub

End Class