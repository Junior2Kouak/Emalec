Imports DevExpress.XtraReports.UI

Public Class FrmStatKmsByTech

    Dim fReport As XtraReport

    Private Sub FrmStatKmsByTech_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load

        Dim fileName As string

        'PrintControl1.
        fileName = GetReportPath(fReport, "repx")
        'printControl.PrintingSystem = fReport.PrintingSystem
        'fReport.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ClosePreview, DevExpress.XtraPrinting.CommandVisibility.None)
        fReport.CreateDocument(True) 
        
    End Sub

    Shared Function GetReportPath(ByVal fReport As DevExpress.XtraReports.UI.XtraReport, ByVal ext As String) As String
            Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim repName As String = fReport.Name
            If repName.Length = 0 Then
                repName = fReport.GetType().Name
            End If
            Dim dirName As String = Path.GetDirectoryName(asm.Location)
            Return Path.Combine(dirName, repName & "." & ext)
        End Function

End Class