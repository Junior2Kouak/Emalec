Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class CStat_CA_SOC

  Dim Dt_Stat_CA_SOC As DataTable

  Dim _sTitleForm As String
  Dim _sTitleLabel As String
  Dim _sSociete As String


  Public Sub New(ByVal SnomSoc As String)

    _sTitleForm = "Evolution du chiffre d'affaire"
    _sTitleLabel = "CA par mois"
    _sSociete = SnomSoc

    Dt_Stat_CA_SOC = Nothing

  End Sub

  Public ReadOnly Property Dt_Stat As DataTable
    Get
      Return Dt_Stat_CA_SOC
    End Get
  End Property

  Public ReadOnly Property sTitleForm As String
    Get
      Return _sTitleForm
    End Get
  End Property

  Public ReadOnly Property sTitleLabel As String
    Get
      Return _sTitleLabel
    End Get
  End Property

#Region "Config_ChartControl"

  Public ReadOnly Property FormatAxeY As NumericFormat
    Get
      Return NumericFormat.Currency
    End Get
  End Property

  Public ReadOnly Property TitleChart As ChartTitle
    Get

      Dim oTitleCHartTmp As New ChartTitle
      oTitleCHartTmp.Text = String.Format("Chiffre d'affaire sur 48 mois glissants")
      oTitleCHartTmp.Visibility = DevExpress.Utils.DefaultBoolean.True

      Return oTitleCHartTmp
    End Get
  End Property

  Public ReadOnly Property AxisX_Label_Angle As Int32
    Get
      Return 90
    End Get
  End Property

#End Region

  Public Sub LoadDataStat()
    Dim sSQL As String

    'Init
    sSQL = String.Format("exec api_sp_StatistiqueCA '{0}', {1}, {2}", _sSociete, 87, MozartParams.UID)

    Dt_Stat_CA_SOC = LoadList(sSQL, MozartDatabase.cnxMozart)
  End Sub

  Public Function NamingColumn(ByVal iCol As Int32) As GridColumn
    Dim oColumnDataTable As GridColumn

    If Dt_Stat_CA_SOC Is Nothing Then
      Return Nothing
    End If

    oColumnDataTable = New GridColumn

    With oColumnDataTable

      Select Case iCol
        Case 0
          .Caption = "Mois"
          .DisplayFormat.FormatType = DevExpress.Utils.FormatType.None
          .DisplayFormat.FormatString = ""
          .Visible = True
          .VisibleIndex = iCol
          .FieldName = "mois"
          .Name = "ColMois"

        Case 1
          .Caption = "Total € HT"
          .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
          .DisplayFormat.FormatString = "c0"
          .Visible = True
          .VisibleIndex = iCol
          .FieldName = "THT"
          .Name = "ColCA"
          .SummaryItem.FieldName = "THT"
          .SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
          .SummaryItem.DisplayFormat = "Total : {0:### ### ### ###} €"
      End Select

    End With

    Return oColumnDataTable
  End Function

  Public Function CreateSeries() As Series
    Dim oDtemp As DataTable = Dt_Stat_CA_SOC.Copy
    oDtemp.DefaultView.Sort = "periode"

    Dim oSeries As New Series("SeriesCAN", ViewType.Bar) With {
      .DataSource = oDtemp.DefaultView,
      .ArgumentScaleType = ScaleType.Qualitative,
      .ArgumentDataMember = "mois",
      .ValueScaleType = ScaleType.Numerical,
      .ShowInLegend = False,
      .LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
    }
    oSeries.ValueDataMembers.AddRange(New String() {"THT"})

    Return oSeries

  End Function

  Public Sub SetFilterSeries(ByVal p_oSeries As Series, ByVal p_strFilter As String)

    Dim oDtFilter As DataTable = Dt_Stat_CA_SOC.Copy
    If p_strFilter <> "" Then oDtFilter.DefaultView.RowFilter = p_strFilter

    p_oSeries.DataSource = DT_FilterTop(oDtFilter.DefaultView)

  End Sub

  Private Function DT_FilterTop(ByVal p_oDtFilter As DataView) As DataTable

    Dim oDT_FilterTop As New DataTable
    Dim sNomColIncrement As String = "AUTO"

    Dim ColIncrement As New DataColumn(sNomColIncrement, System.Type.GetType("System.Int64")) With {
      .AutoIncrement = True
    }

    oDT_FilterTop.Columns.Add(ColIncrement)

    Dim dtReader As New DataTableReader(p_oDtFilter.ToTable)
    oDT_FilterTop.Load(dtReader)

    Return oDT_FilterTop

  End Function

End Class
