Imports System.Data.SqlClient
Imports DevExpress.Data
Imports DevExpress.Mvvm.Native
Imports DevExpress.Xpf.Utils.Themes
Imports DevExpress.Xpo.Helpers
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports MozartLib

Public Class frmQCMAnalyseResultat


  Dim DTAnalyse As DataTable
  Dim _NIDQCMNUM As Int32
  Dim _sLibQCM As String
  Dim _NQCMTYPEID As Int32

  Dim SomNBREPOK As Int32
  Dim SomNBREPNOK As Int32
  Dim SomNBREPNO As Int32
  Dim SomNBREPTOTAL As Int32

  Public Sub New(ByVal c_NIDQCMNUM As Int32, ByVal c_sLibQCM As String, ByVal c_NQCMTYPEID As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NIDQCMNUM = c_NIDQCMNUM
    _sLibQCM = c_sLibQCM
    _NQCMTYPEID = c_NQCMTYPEID
    LblTitre.Text = "Analyse QCM : " & _sLibQCM
  End Sub

  Private Sub frmQCMAnalyseResultat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'INIT
    LoadData()

    ' Cast the chart's diagram to the XYDiagram type, to access its axes.
    Dim diagram As XYDiagram = TryCast(ChartAna.Diagram, XYDiagram)
    If diagram Is Nothing Then
      Return
    End If
    Dim axisX As AxisX = diagram.AxisX

    If DTAnalyse Is Nothing Then Return
    Dim sLibAxis As String

    For Each dr As DataRow In DTAnalyse.Rows

      sLibAxis = "Q" + dr.Item("NQCMQUESTIONORDER").ToString + ":" + dr.Item("VQUESTIONLIB").ToString   '+ ":" + dr.Item("VQUESTIONLIB")

      If sLibAxis.Length > 47 Then
        sLibAxis = sLibAxis.Substring(0, 47)
      End If

      diagram.AxisX.CustomLabels.Add(New CustomAxisLabel(name:=sLibAxis, value:=dr.Item("NIDQUESTION")) With {
                    .TextColor = Color.FromArgb(255, 74, 74, 74),
                    .BackColor = Color.FromArgb(255, 225, 225, 225)
                })

    Next

  End Sub

  Private Sub LoadData()

    DTAnalyse = New DataTable
    Dim sqlcmd As New SqlCommand("[api_sp_QCM_AnalyseResultByQCM]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_NIDQCMNUM", SqlDbType.Int).Value = _NIDQCMNUM

        DTAnalyse.Load(sqlcmd.ExecuteReader)

        GCListeQuest.DataSource = DTAnalyse

    sqlcmd = New SqlCommand("[api_sp_QCM_AnalyseResultGeneralByQCM]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_NIDQCMNUM", SqlDbType.Int).Value = _NIDQCMNUM

        Dim sqlDR As SqlDataReader = sqlcmd.ExecuteReader

        If sqlDR.HasRows Then

            sqlDR.Read()

            LblQCMAffect.Text = sqlDR.Item("NB_QCM_AFFECT")
            LblQCMRenseign.Text = sqlDR.Item("NB_QCM_TERMINE")
            LblQCMTXRep.Text = String.Format("{0:p2}", sqlDR.Item("PC_QCM_TERMINE"))


        End If
        sqlDR.Close()

        ChartAna.DataSource = DTAnalyse

    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub GVListeQuest_CustomSummaryCalculate(sender As Object, e As CustomSummaryEventArgs) Handles GVListeQuest.CustomSummaryCalculate

        Dim view As GridView = TryCast(sender, GridView)
        If e.IsTotalSummary AndAlso (TryCast(e.Item, GridSummaryItem)).FieldName = "PC_REP_OK" Or (TryCast(e.Item, GridSummaryItem)).FieldName = "PC_REP_NOK" Or (TryCast(e.Item, GridSummaryItem)).FieldName = "PC_NO" Then

            Dim item As GridSummaryItem = TryCast(e.Item, GridSummaryItem)
            If item.FieldName = "PC_REP_OK" Then
                Select Case e.SummaryProcess
                    Case CustomSummaryProcess.Start
                        SomNBREPOK = 0
                        SomNBREPNOK = 0
                        SomNBREPNO = 0
                    Case CustomSummaryProcess.Calculate
                        SomNBREPOK += CInt(If(view.GetRowCellValue(e.RowHandle, "NB_REP_OK") Is DBNull.Value, 0, view.GetRowCellValue(e.RowHandle, "NB_REP_OK"))) 'CInt(view.GetRowCellValue(e.RowHandle, "NB_REP_OK"))
                        SomNBREPNOK += CInt(If(view.GetRowCellValue(e.RowHandle, "NB_REP_NOK") Is DBNull.Value, 0, view.GetRowCellValue(e.RowHandle, "NB_REP_NOK")))
                        SomNBREPNO += CInt(If(view.GetRowCellValue(e.RowHandle, "NB_REP_NO") Is DBNull.Value, 0, view.GetRowCellValue(e.RowHandle, "NB_REP_NO"))) 'CInt(view.GetRowCellValue(e.RowHandle, "NB_REP_NO"))
                    Case CustomSummaryProcess.Finalize
                        e.TotalValue = If(SomNBREPOK + SomNBREPNOK + SomNBREPNO = 0, 0, SomNBREPOK / (SomNBREPOK + SomNBREPNOK + SomNBREPNO))
                End Select
            ElseIf item.FieldName = "PC_REP_NOK" Then
                Select Case e.SummaryProcess
                    Case CustomSummaryProcess.Start
                        SomNBREPOK = 0
                        SomNBREPNOK = 0
                        SomNBREPNO = 0
                    Case CustomSummaryProcess.Calculate
                        SomNBREPOK += CInt(If(view.GetRowCellValue(e.RowHandle, "NB_REP_OK") Is DBNull.Value, 0, view.GetRowCellValue(e.RowHandle, "NB_REP_OK"))) 'CInt(view.GetRowCellValue(e.RowHandle, "NB_REP_OK"))
                        SomNBREPNOK += CInt(If(view.GetRowCellValue(e.RowHandle, "NB_REP_NOK") Is DBNull.Value, 0, view.GetRowCellValue(e.RowHandle, "NB_REP_NOK")))
                        SomNBREPNO += CInt(If(view.GetRowCellValue(e.RowHandle, "NB_REP_NO") Is DBNull.Value, 0, view.GetRowCellValue(e.RowHandle, "NB_REP_NO"))) 'CInt(view.GetRowCellValue(e.RowHandle, "NB_REP_NO"))
                    Case CustomSummaryProcess.Finalize
                        e.TotalValue = If(SomNBREPOK + SomNBREPNOK + SomNBREPNO = 0, 0, SomNBREPNOK / (SomNBREPOK + SomNBREPNOK + SomNBREPNO))
                End Select
            ElseIf item.FieldName = "PC_NO" Then
                Select Case e.SummaryProcess
                    Case CustomSummaryProcess.Start
                        SomNBREPOK = 0
                        SomNBREPNOK = 0
                        SomNBREPNO = 0
                    Case CustomSummaryProcess.Calculate
                        SomNBREPOK += CInt(If(view.GetRowCellValue(e.RowHandle, "NB_REP_OK") Is DBNull.Value, 0, view.GetRowCellValue(e.RowHandle, "NB_REP_OK"))) 'CInt(view.GetRowCellValue(e.RowHandle, "NB_REP_OK"))
                        SomNBREPNOK += CInt(If(view.GetRowCellValue(e.RowHandle, "NB_REP_NOK") Is DBNull.Value, 0, view.GetRowCellValue(e.RowHandle, "NB_REP_NOK")))
                        SomNBREPNO += CInt(If(view.GetRowCellValue(e.RowHandle, "NB_REP_NO") Is DBNull.Value, 0, view.GetRowCellValue(e.RowHandle, "NB_REP_NO"))) 'CInt(view.GetRowCellValue(e.RowHandle, "NB_REP_NO"))
                    Case CustomSummaryProcess.Finalize
                        e.TotalValue = If(SomNBREPOK + SomNBREPNOK + SomNBREPNO = 0, 0, SomNBREPNO / (SomNBREPOK + SomNBREPNOK + SomNBREPNO))
                End Select

            End If
        End If

    End Sub

    Private Sub BtnExportXLSX_Click(sender As Object, e As EventArgs) Handles BtnExportXLSX.Click

        SDF.FileName = ""
        SDF.Filter = "Fichiers EXCEL (*.xlsx)|*.xlsx"
        SDF.ShowDialog()

        If SDF.FileName <> "" Then

            GVListeQuest.OptionsPrint.ExpandAllDetails = True
            GVListeQuest.OptionsPrint.PrintDetails = True
            Dim opt As XlsxExportOptionsEx = New XlsxExportOptionsEx()
            opt.ExportType = DevExpress.Export.ExportType.WYSIWYG
            GVListeQuest.ExportToXlsx(SDF.FileName, opt)

        End If

    End Sub

    Private Sub BtnResultatsByQCM_Click(sender As Object, e As EventArgs) Handles BtnResultatsByQCM.Click

        Select Case _NQCMTYPEID

            Case 1

                Dim ofrmQCMResultatsByQCM As New frmQCMListeResultByQCM(_NIDQCMNUM, _sLibQCM, _NQCMTYPEID)
                ofrmQCMResultatsByQCM.ShowDialog()
                ofrmQCMResultatsByQCM.Dispose()

            Case 2

                Dim ofrmCauserieResultatsByQCM As New frmCauserieListeResultByQCM(_NIDQCMNUM, _sLibQCM, _NQCMTYPEID)
                ofrmCauserieResultatsByQCM.ShowDialog()
                ofrmCauserieResultatsByQCM.Dispose()

            Case Else

                MessageBox.Show(My.Resources.Global_type_nonreconnu, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Select

    End Sub

    Private Sub RepositoryItemHyperLinkEdit1_OpenLink(sender As Object, e As OpenLinkEventArgs) Handles RepositoryItemHyperLinkEdit1.OpenLink

        If GVListeQuest.FocusedRowHandle > -1 Then

            Dim drSelect As DataRow = GVListeQuest.GetDataRow(GVListeQuest.FocusedRowHandle)

            If drSelect IsNot Nothing Then

                If drSelect.Item("NB_REP_NOK") = 0 Then Exit Sub

                Dim ofrmQCMAnalyseResult_ListeTechByQREP As New frmQCMAnalyseResult_ListeTechByQREP(1, drSelect.Item("NIDQUESTION"))
                ofrmQCMAnalyseResult_ListeTechByQREP.ShowDialog()

            End If

            '_NIDQCMNUM
            'NIDQUESTION



        End If

    End Sub

    Private Sub RepositoryItemHyperLinkEdit2_OpenLink(sender As Object, e As OpenLinkEventArgs) Handles RepositoryItemHyperLinkEdit2.OpenLink

        If GVListeQuest.FocusedRowHandle > -1 Then

            Dim drSelect As DataRow = GVListeQuest.GetDataRow(GVListeQuest.FocusedRowHandle)

            If drSelect IsNot Nothing Then

                If drSelect.Item("NB_REP_OK") = 0 Then Exit Sub

                Dim ofrmQCMAnalyseResult_ListeTechByQREP_OK As New frmQCMAnalyseResult_ListeTechByQREP(0, drSelect.Item("NIDQUESTION"))
                ofrmQCMAnalyseResult_ListeTechByQREP_OK.ShowDialog()

            End If

            '_NIDQCMNUM
            'NIDQUESTION



        End If

    End Sub

    Private Sub RepositoryItemHyperLinkEdit3_OpenLink(sender As Object, e As OpenLinkEventArgs) Handles RepositoryItemHyperLinkEdit3.OpenLink

        If GVListeQuest.FocusedRowHandle > -1 Then

            Dim drSelect As DataRow = GVListeQuest.GetDataRow(GVListeQuest.FocusedRowHandle)

            If drSelect IsNot Nothing Then

                If drSelect.Item("NB_REP_NO") = 0 Then Exit Sub

                Dim ofrmQCMAnalyseResult_ListeTechByQREP_NOREP As New frmQCMAnalyseResult_ListeTechByQREP(2, drSelect.Item("NIDQUESTION"))
                ofrmQCMAnalyseResult_ListeTechByQREP_NOREP.ShowDialog()

            End If

            '_NIDQCMNUM
            'NIDQUESTION



        End If

    End Sub
End Class