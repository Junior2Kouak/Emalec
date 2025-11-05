Imports System.Data.SqlClient
Imports DevExpress.XtraPivotGrid
Imports MozartLib

Public Class frmSyntheseREXGroupe

  Dim dtANAGRP As DataTable
  Dim TotalByRubrique As ArrayList

  Private Sub frmSyntheseREXGroupe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Dim DateMaxANAHISTO As Nullable(Of DateTime)

    'on rempli les combo mois et année
    CboMois.DisplayMember = "VALUE"
    CboMois.ValueMember = "ID"
    CboMois.DataSource = ModDataGridView.LoadList("SELECT MONTH(DDATCRE) AS ID, MONTH(DDATCRE) AS VALUE FROM TANAHISTO WHERE YEAR(DDATCRE) > 2012 AND VSOCIETE = '" + MozartParams.NomSociete + "' GROUP BY MONTH(DDATCRE) ORDER BY MONTH(DDATCRE)", MozartDatabase.cnxMozart)

    CboAnnee.ValueMember = "ID"
    CboAnnee.DisplayMember = "VALUE"
    CboAnnee.DataSource = ModDataGridView.LoadList("SELECT YEAR(DDATCRE) AS ID, YEAR(DDATCRE) AS VALUE FROM TANAHISTO WHERE YEAR(DDATCRE) > 2012 AND VSOCIETE = '" + MozartParams.NomSociete + "' GROUP BY YEAR(DDATCRE) ORDER BY YEAR(DDATCRE) DESC", MozartDatabase.cnxMozart)

    'sélection automatique de la date max
    Dim sqlcmdauto As New SqlCommand("select MAX(DDATCRE) AS DDATEMAX FROM TANAHISTO WHERE VSOCIETE = '" + MozartParams.NomSociete + "'", MozartDatabase.cnxMozart)
    Dim drauto As SqlDataReader = sqlcmdauto.ExecuteReader
    If drauto.HasRows Then
      drauto.Read()
      DateMaxANAHISTO = Convert.ToDateTime(drauto("DDATEMAX"))
    End If
    drauto.Close()

    If IsDBNull(DateMaxANAHISTO) = False Then

      CboMois.SelectedValue = DatePart(DateInterval.Month, CType(DateMaxANAHISTO, DateTime))
      CboAnnee.SelectedValue = DatePart(DateInterval.Year, CType(DateMaxANAHISTO, DateTime))
      'affichage auto du max date
      LoadData(CboMois.SelectedValue, CboAnnee.SelectedValue)

    End If

  End Sub

  Private Sub LoadData(ByVal iNumMois As Int32, ByVal iNumAnnee As Int32)

    Me.Cursor = Cursors.WaitCursor

    dtANAGRP = New DataTable
    TotalByRubrique = New ArrayList

    Dim sqlcmd As New SqlCommand("api_sp_TableauSynthComptaREXGroupe", MozartDatabase.cnxMozart)

    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_NUMMOIS_SELECT", SqlDbType.Int).Value = iNumMois
    sqlcmd.Parameters.Add("@P_NUMANNEE_SELECT", SqlDbType.Int).Value = iNumAnnee
    sqlcmd.CommandTimeout = 80

    dtANAGRP.Load(sqlcmd.ExecuteReader)

    PGCANAGRP.DataSource = dtANAGRP

    Me.Cursor = Cursors.Default

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub PGCANAGRP_CustomAppearance(sender As Object, e As DevExpress.XtraPivotGrid.PivotCustomAppearanceEventArgs) Handles PGCANAGRP.CustomAppearance

    If e.ColumnFieldIndex = 0 Then e.Appearance.BackColor = Color.LightGoldenrodYellow
    If e.ColumnFieldIndex = 1 Then e.Appearance.BackColor = Color.Cornsilk
    If e.ColumnFieldIndex = 2 Then e.Appearance.BackColor = Color.Linen

  End Sub

  Private Sub PGCANAGRP_FieldValueDisplayText(sender As Object, e As DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs) Handles PGCANAGRP.FieldValueDisplayText

    If e.ValueType = PivotGridValueType.CustomTotal Then

      e.DisplayText = My.Resources.Global_Tot

    End If

  End Sub

  Private Sub PGCANAGRP_CustomFieldSort(sender As Object, e As DevExpress.XtraPivotGrid.PivotGridCustomFieldSortEventArgs) Handles PGCANAGRP.CustomFieldSort

    If e.Field.FieldName = "VINTITULE" Then

      Dim orderValue1 As Object = e.GetListSourceColumnValue(e.ListSourceRowIndex1, "NORDERINTITULE"), orderValue2 As Object = e.GetListSourceColumnValue(e.ListSourceRowIndex2, "NORDERINTITULE")
      e.Result = Comparer.Default.Compare(orderValue1, orderValue2)
      e.Handled = True

    ElseIf e.Field.FieldName = "MOISANNEE" Then

      Dim orderValue1 As Object = e.GetListSourceColumnValue(e.ListSourceRowIndex1, "NORDERMOISANNEE"), orderValue2 As Object = e.GetListSourceColumnValue(e.ListSourceRowIndex2, "NORDERMOISANNEE")
      e.Result = Comparer.Default.Compare(orderValue1, orderValue2)
      e.Handled = True

    End If

  End Sub

  Private Sub PGCANAGRP_CustomCellDisplayText(sender As Object, e As DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs) Handles PGCANAGRP.CustomCellDisplayText

    If e.DataField.FieldName = "NVALUE" Then e.DisplayText = String.Format("{0:C0}", e.Value)

    If e.DataField.FieldName = "NPOURC" Then

      If e.GetFieldValue(PGFVINTITULE) = "PRODUCTION" Or e.GetFieldValue(PGFVINTITULE) = "RESULTAT FINANCIER" Or e.GetFieldValue(PGFVINTITULE) = "RESULTAT EXCEPTIONNEL" Or
          e.GetFieldValue(PGFVINTITULE) = "PARTICIPATION" Or e.GetFieldValue(PGFVINTITULE) = "IS" Then

        e.DisplayText = ""

      Else

        e.DisplayText = String.Format("{0:f2}", e.Value) & " %"

      End If

    End If

  End Sub

  Private Sub PGCANAGRP_CustomCellValue(sender As Object, e As DevExpress.XtraPivotGrid.PivotCellValueEventArgs) Handles PGCANAGRP.CustomCellValue

    ' Exits if the processed cell does not belong to a Custom Total.
    If e.ColumnCustomTotal Is Nothing AndAlso e.RowCustomTotal Is Nothing Then
      Return
    End If

    Dim summaryValues As ArrayList = GetSummaryValues(e)

    If e.DataField.FieldName = "NPOURC" Then e.Value = GetCustomTotalValue(summaryValues, e.GetFieldValue(PGFVINTITULE), e.ColumnFieldIndex, "%")
    If e.DataField.FieldName = "NVALUE" Then e.Value = GetCustomTotalValue(summaryValues, e.GetFieldValue(PGFVINTITULE), e.ColumnFieldIndex)

  End Sub

  ' Returns a list of summary values against which
  ' a Custom Total will be calculated.
  Private Function GetSummaryValues(ByVal e As PivotCellValueEventArgs) As ArrayList
    Dim values As New ArrayList()

    ' Creates a summary data source.
    Dim sds As PivotSummaryDataSource = e.CreateSummaryDataSource()

    ' Iterates through summary data source records
    ' and copies summary values to an array.
    For i As Integer = 0 To sds.RowCount - 1
      Dim value As Object = sds.GetValue(i, e.DataField)
      If value Is Nothing Then
        Continue For
      End If
      values.Add(value)
    Next i

    ' Sorts summary values.
    values.Sort()

    ' Returns the summary values array.
    Return values
  End Function

  ' Returns the Custom Total value by an array of summary values.
  Private Function GetCustomTotalValue(ByVal values As ArrayList,
                                       ByVal customTotalName As String, ByVal IndexColumnDate As Int32, Optional ByVal sTypeCustomTotal As String = "") As Object

    Dim RubriqueTot As New CRubriqueAna
    RubriqueTot.NameRubrique = customTotalName
    RubriqueTot.TotalRubrique = GetSum(values)
    RubriqueTot.IndexColumnDate = IndexColumnDate
    TotalByRubrique.Add(RubriqueTot)

    ' Returns a null value if the provided array is empty.
    If values.Count = 0 Then
      Return Nothing
    End If

    ' If the Median Custom Total should be calculated,
    ' calls the GetMedian method.
    If customTotalName = "PRODUCTION" Or customTotalName = "RESULTAT FINANCIER" Or customTotalName = "RESULTAT EXCEPTIONNEL" Or customTotalName = "PARTICIPATION" _
            Or customTotalName = "IS" Then

      Return GetSum(values)

    End If

    ' If the Quartiles Custom Total should be calculated,
    ' calls the GetQuartiles method.
    If customTotalName = "MARGE ANALYTIQUE" Or customTotalName = "EBITDA" Or customTotalName = "REX" Or customTotalName = "RESULTAT NET" Then

      If sTypeCustomTotal = "%" Then

        If GetTotalByRubrique(TotalByRubrique, "PRODUCTION", IndexColumnDate) = 0 Then Return 0
        Return (GetTotalByRubrique(TotalByRubrique, customTotalName, IndexColumnDate) / GetTotalByRubrique(TotalByRubrique, "PRODUCTION", IndexColumnDate) * 100)

      Else

        Return GetSum(values)
      End If

    End If



    ' Otherwise, returns a null value.
    Return Nothing

  End Function

  Private Function GetTotalByRubrique(ByVal totvalues As ArrayList, ByVal Customname As String, ByVal IndexColDate As Int32) As Decimal

    If totvalues.Count > 0 Then
      For Each ValTotSum As CRubriqueAna In totvalues

        If ValTotSum.NameRubrique = Customname And ValTotSum.IndexColumnDate = IndexColDate Then

          Return ValTotSum.TotalRubrique

        End If

      Next

    End If
    Return 0

  End Function

  ' Calculates a sum for the specified sorted sample.
  Private Function GetSum(ByVal values As ArrayList) As Decimal
    Dim Total As Int32
    If values.Count > 0 Then
      For Each ValSum In values
        Total += ValSum
      Next
      Return Total
    End If
    Return 0
  End Function

  ' Calculates a average for the specified sorted sample.
  Private Function GetAverage(ByVal values As ArrayList) As Decimal
    Dim Total As Decimal
    If values.Count > 0 Then
      For Each ValSum In values
        Total += ValSum
      Next
      Return Total / values.Count
    End If
    Return 0
  End Function

  Private Sub BtnValid_Click(sender As System.Object, e As System.EventArgs) Handles BtnValid.Click

    If CboMois.SelectedValue Is Nothing Or CboAnnee.SelectedValue Is Nothing Then Return

    LoadData(CboMois.SelectedValue, CboAnnee.SelectedValue)

  End Sub

  Private Sub frmSyntheseREXGroupe_ResizeEnd(sender As Object, e As System.EventArgs) Handles Me.ResizeEnd, Me.SizeChanged
    PGCANAGRP.Size = New Size(PGCANAGRP.Size.Width, Me.Size.Height - PGCANAGRP.Location.Y - 50)
  End Sub

  Private Sub BtnExportPDF_Click(sender As System.Object, e As System.EventArgs) Handles BtnExportPDF.Click

    If CboMois.SelectedValue Is Nothing Or CboAnnee.SelectedValue Is Nothing Then Return

    SFDSynCompta.FileName = ""

    SFDSynCompta.Filter = "Fichiers PDF (*.pdf)|*.pdf"
    SFDSynCompta.ShowDialog()

    If SFDSynCompta.FileName <> "" Then

      Dim ps As New DevExpress.XtraPrinting.PrintingSystemBase()
      Dim link As DevExpress.XtraPrintingLinks.PrintableComponentLinkBase = New DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(ps)
      link.Component = PGCANAGRP
      link.Landscape = False
      link.Margins.Left = 1
      link.Margins.Right = 1
      link.Margins.Top = 1
      link.Margins.Bottom = 1
      link.CreateDocument()
      link.PrintingSystemBase.Document.ScaleFactor = 0.78



      link.PrintingSystemBase.ExportToPdf(SFDSynCompta.FileName)

    End If

  End Sub

  Private Sub BtnExportXLS_Click(sender As System.Object, e As System.EventArgs) Handles BtnExportXLS.Click

    If CboMois.SelectedValue Is Nothing Or CboAnnee.SelectedValue Is Nothing Then Return

    SFDSynCompta.FileName = ""

    SFDSynCompta.Filter = "Fichiers EXCEL (*.xls)|*.xls"
    SFDSynCompta.ShowDialog()

    If SFDSynCompta.FileName <> "" Then

      PGCANAGRP.OptionsPrint.UsePrintAppearance = False
      PGCANAGRP.ExportToXls(SFDSynCompta.FileName, textExportMode:=DevExpress.XtraPrinting.TextExportMode.Text)

    End If

  End Sub

End Class

'***********************************************************************************************************************************************************
Public Class CRubriqueAna
  Public NameRubrique As String
  Public TotalRubrique As Decimal
  Public IndexColumnDate As Int32
End Class
