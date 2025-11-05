Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class CStat_CA_SOC_AN

  Dim oGestConnectSQL As CGestionSQL

  Dim Dt_Stat_CA_SOC_AN As DataTable

  Dim _sTitleForm As String
  Dim _sTitleLabel As String
  Dim _sSociete As String


  Public Sub New(sSocciete As String)

    oGestConnectSQL = New CGestionSQL

    _sTitleForm = "Evolution du chiffre d'affaire"
    _sTitleLabel = "CA par An"
    _sSociete = sSocciete

  End Sub

  Public ReadOnly Property Dt_Stat As DataTable
    Get
      Return Dt_Stat_CA_SOC_AN
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
      oTitleCHartTmp.Text = String.Format("Evolution du chiffre d'affaire annuel")
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

    If oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) Then

      'Init
      sSQL = String.Format("exec api_sp_StatistiqueCAanne '{0}', {1}, {2}", _sSociete, 87, MozartParams.UID)

      Dt_Stat_CA_SOC_AN = New DataTable
      Dt_Stat_CA_SOC_AN = ModDataGridView.LoadList(sSQL, oGestConnectSQL.CnxSQLOpen)

      oGestConnectSQL.CloseConnexionSQL()

    End If

  End Sub

  Public Function NamingColumn(ByVal iCol As Int32) As GridColumn

    Dim oColumnDataTable As GridColumn

    If Not Dt_Stat_CA_SOC_AN Is Nothing Then

      oColumnDataTable = New GridColumn

      With oColumnDataTable

        Select Case iCol

          Case 0
            .Caption = "Année"
            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.None
            .DisplayFormat.FormatString = ""
            .Visible = True
            .VisibleIndex = iCol
            .FieldName = "AN"
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

    Else

      Return Nothing

    End If

  End Function

  Public Function CreateSeries() As Series

    Dim oSeries As New Series("SeriesCAN", ViewType.Bar)

    oSeries.DataSource = Dt_Stat_CA_SOC_AN.DefaultView

    'Specify data members to bind the series.
    oSeries.ArgumentScaleType = ScaleType.Qualitative
    oSeries.ArgumentDataMember = "AN"
    oSeries.ValueScaleType = ScaleType.Numerical
    oSeries.ValueDataMembers.AddRange(New String() {"THT"})
    oSeries.ShowInLegend = False
    oSeries.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False

    'CType(oSeries.View, SideBySideBarSeriesView).ColorEach = True

    Return oSeries

  End Function


  Public Sub SetFilterSeries(ByVal p_oSeries As Series, ByVal p_strFilter As String)

    Dim oDtFilter As DataTable = Dt_Stat_CA_SOC_AN.Copy
    If p_strFilter <> "" Then oDtFilter.DefaultView.RowFilter = p_strFilter

    p_oSeries.DataSource = DT_FilterTop(oDtFilter.DefaultView)

  End Sub

  Private Function DT_FilterTop(ByVal p_oDtFilter As DataView) As DataTable

    Dim oDT_FilterTop As New DataTable
    Dim sNomColIncrement As String = "AUTO"

    Dim ColIncrement As New DataColumn(sNomColIncrement, System.Type.GetType("System.Int64"))
    With ColIncrement
      .AutoIncrement = True
    End With
    oDT_FilterTop.Columns.Add(ColIncrement)

    Dim dtReader As DataTableReader = New DataTableReader(p_oDtFilter.ToTable)
    oDT_FilterTop.Load(dtReader)

    '     oDT_FilterTop.DefaultView.RowFilter = String.Format("{0} <= {1}", sNomColIncrement, 37)
    Return oDT_FilterTop

  End Function

End Class
