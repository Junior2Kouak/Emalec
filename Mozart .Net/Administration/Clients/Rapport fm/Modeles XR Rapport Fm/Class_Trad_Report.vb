Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports DevExpress.XtraReports.UI
Imports MozartLib
Public Class Class_Trad_Report

  Dim _Dt_Tradutction As New DataTable
  Dim _sNomReport As String

  Public Sub New(ByRef c_sNomReport As String)

    _sNomReport = c_sNomReport

    GetDataTableOnReport(_sNomReport)

  End Sub

  Private Sub GetDataTableOnReport(ByRef p_sNomReport As String)

    _Dt_Tradutction = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_GetDataTableTraductionByFile]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@p_fichier", SqlDbType.VarChar).Value = p_sNomReport
        _Dt_Tradutction.Load(sqlcmd.ExecuteReader)

    End Sub

    Public Function GetExpression(ByRef p_sExpression As String, ByRef p_sLangue As String)

        If Not _Dt_Tradutction Is Nothing Then

            Dim Dr_Find As DataRow() = _Dt_Tradutction.Select("[CHAINE] = '" & p_sExpression.Replace("'", "''") & "'")

            If Dr_Find.Count = 0 Then Return p_sExpression

            Select Case p_sLangue
                Case "FR" : Return Dr_Find(0).Item("CHAINEFR").ToString()
                Case "ES" : Return Dr_Find(0).Item("CHAINEES").ToString()
                Case "IT" : Return Dr_Find(0).Item("CHAINEIT").ToString()
                Case "EN" : Return Dr_Find(0).Item("CHAINEEN").ToString()
                Case "PT" : Return Dr_Find(0).Item("CHAINEPT").ToString()
                Case "NL" : Return Dr_Find(0).Item("CHAINENL").ToString()
                Case "DE" : Return Dr_Find(0).Item("CHAINEDE").ToString()
                Case "BE" : Return Dr_Find(0).Item("CHAINEBE").ToString()
                Case "CH" : Return Dr_Find(0).Item("CHAINEFR").ToString()
                Case "PL" : Return Dr_Find(0).Item("CHAINEEN").ToString()
                Case "CZ" : Return Dr_Find(0).Item("CHAINEEN").ToString()
                Case "BL" : Return Dr_Find(0).Item("CHAINENL").ToString()
                Case "DK" : Return Dr_Find(0).Item("CHAINEEN").ToString()
                Case "SE" : Return Dr_Find(0).Item("CHAINEEN").ToString()
                Case "SL" : Return Dr_Find(0).Item("CHAINEEN").ToString()
                Case Else : Return p_sExpression
            End Select

        Else
            Return p_sExpression
        End If

    End Function

    Public Function GetMonthNameByLangue(ByRef p_sDate As Date, ByRef p_sLangue As String) As String

        Dim sNomMois As String = ""

    Dim sqlcmd As New SqlCommand("[api_sp_GetMonthNameByLangue]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_DATE", SqlDbType.DateTime).Value = p_sDate
        sqlcmd.Parameters.Add("@p_VLANGUE", SqlDbType.VarChar).Value = p_sLangue
        Dim sqldr As SqlDataReader = sqlcmd.ExecuteReader

        If sqldr.HasRows = True Then

            sqldr.Read()
            sNomMois = sqldr.Item("MONTH_NAME")

        End If

        sqldr.Close()

        Return sNomMois

    End Function


    Public Sub SetTraductionOnReport(ByVal p_Report As XtraReport, ByRef p_sLangue As String)

        'recherche de tous les labels
        For Each oXrLblRapport As XRLabel In p_Report.AllControls(Of XRLabel)

            If oXrLblRapport.Name <> oXrLblRapport.Text Then

                oXrLblRapport.Text = GetExpression(oXrLblRapport.Text, p_sLangue)


            End If

        Next

        'recherche de tous les title des charts
        For Each oXrChartTitleRapport As XRChart In p_Report.AllControls(Of XRChart)

            For Each oTitle As ChartTitle In oXrChartTitleRapport.Titles
                oTitle.Text = GetExpression(oTitle.Text, p_sLangue)
            Next

            Dim oDiagram As XYDiagram = TryCast(oXrChartTitleRapport.Diagram, XYDiagram)
            If Not oDiagram Is Nothing Then

                    Dim oLlblAxeX As AxisTitle = oDiagram.AxisX.Title
                    If Not oLlblAxeX Is Nothing Then oLlblAxeX.Text = GetExpression(oLlblAxeX.Text, p_sLangue)

                    Dim oLlblAxeY As AxisTitle = oDiagram.AxisY.Title
                    If Not oLlblAxeY Is Nothing Then oLlblAxeY.Text = GetExpression(oLlblAxeY.Text, p_sLangue)

                End If


            'recherche de tous les title des charts
            For Each oXrCellRapport As XRTableCell In p_Report.AllControls(Of XRTableCell)

                If oXrCellRapport.Name <> oXrCellRapport.Text And oXrCellRapport.Text <> "" Then
                    oXrCellRapport.Text = GetExpression(oXrCellRapport.Text, p_sLangue)
                End If

            Next

        Next


    End Sub

End Class
