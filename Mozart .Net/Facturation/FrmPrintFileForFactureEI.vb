Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports DevExpress.Pdf
Imports DevExpress.XtraPdfViewer
Imports MozartLib

Public Class FrmPrintFileForFactureEI

  Dim _NFACNUM As Int32

  Public Sub New(ByVal c_NFACNUM As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NFACNUM = Convert.ToInt32(c_NFACNUM)

  End Sub

  Private Sub FrmPrintFileForFactureEI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    ' If required, declare and specify the system printer settings.
    Dim printerSettingsPDF As New PrinterSettings()

    ' Declare the PDF printer settings.
    ' If required, pass the system settings to the PDF printer settings constructor.
    Dim pdfPrinterSettings As New PdfPrinterSettings(printerSettingsPDF)
    ' Specify the PDF printer settings.
    pdfPrinterSettings.PageOrientation = PdfPrintPageOrientation.Auto
    pdfPrinterSettings.ScaleMode = PdfPrintScaleMode.CustomScale

    Dim sqlcmdListDoc As New SqlCommand("[api_sp_ListeGammeAndCRVPByFac]", MozartDatabase.cnxMozart)
    sqlcmdListDoc.CommandType = CommandType.StoredProcedure
    sqlcmdListDoc.Parameters.Add("@P_NFACNUM", SqlDbType.Int).Value = _NFACNUM
    sqlcmdListDoc.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = MozartParams.NomSociete
    Dim oSqldr As SqlDataReader = sqlcmdListDoc.ExecuteReader

    Dim PdfViewer As New PdfViewer()

    If oSqldr.HasRows Then

      While oSqldr.Read

        If File.Exists(oSqldr.Item("VFICHIER")) Then

          PdfViewer.LoadDocument(oSqldr.Item("VFICHIER"))
          PdfViewer.ShowPrintStatusDialog = False
          PdfViewer.Print(pdfPrinterSettings)

        End If

      End While

    End If
    oSqldr.Close()

    Me.Close()

  End Sub

End Class