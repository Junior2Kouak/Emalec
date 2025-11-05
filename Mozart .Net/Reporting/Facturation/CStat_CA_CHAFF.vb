Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class CStat_CA_CHAFF

  Dim oGestConnectSQLReplicate As CGestionSQL

  Dim Dt_Stat_CA_CHAFF As DataTable

  Dim _sTitleForm As String
  Dim _sTitleLabel As String

  Public Sub New()

    oGestConnectSQLReplicate = New CGestionSQL

    _sTitleForm = "Statistiques par chargé d'affaires sur une période"
    _sTitleLabel = "CA par Chargé d'affaires"

  End Sub

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

  Public ReadOnly Property Dt_Stat As DataTable
    Get
      Return Dt_Stat_CA_CHAFF
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
      oTitleCHartTmp.Text = "Statistiques par chargé d'affaires sur une période"
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

  Public Sub LoadDataStat(ByVal sDateDebut As String, sDateFin As String)

    Dim sSQL As String

    If oGestConnectSQLReplicate.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) Then

      'Init
      sSQL = String.Format("exec api_sp_StatistiqueCAFF '{0}', '{1}', {2}, {3}", sDateDebut, sDateFin, MozartParams.NomSociete, 119)

      Dt_Stat_CA_CHAFF = New DataTable
      Dt_Stat_CA_CHAFF = ModDataGridView.LoadList(sSQL, oGestConnectSQLReplicate.CnxSQLOpen)

      oGestConnectSQLReplicate.CloseConnexionSQL()

    End If

  End Sub

  Public Function NamingColumn(ByVal iCol As Int32) As GridColumn

    Dim oColumnDataTable As GridColumn

    If Not Dt_Stat_CA_CHAFF Is Nothing Then

      oColumnDataTable = New GridColumn

      With oColumnDataTable

        Select Case iCol

          Case 0
            .Caption = "Chargé d'affaires"
            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.None
            .DisplayFormat.FormatString = ""
            .Visible = True
            .VisibleIndex = iCol
            .FieldName = "VPERNOM"
            .Name = "ColVPERNOM"
          Case 1
            .Caption = "Montant Total € HT"
            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .DisplayFormat.FormatString = "c0"
            .Visible = True
            .VisibleIndex = iCol
            .FieldName = "CA"
            .Name = "ColCA"
            .SummaryItem.FieldName = "CA"
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

    Dim oSeries As New Series("SeriesCHAFF", ViewType.Bar)

    oSeries.DataSource = Dt_Stat_CA_CHAFF

    'Specify data members to bind the series.
    oSeries.ArgumentScaleType = ScaleType.Qualitative
    oSeries.ArgumentDataMember = "VPERNOM"
    oSeries.ValueScaleType = ScaleType.Numerical
    oSeries.ValueDataMembers.AddRange(New String() {"CA"})
    oSeries.ShowInLegend = False
    oSeries.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False

    CType(oSeries.View, SideBySideBarSeriesView).ColorEach = True

    Return oSeries

  End Function

  Public Sub SetFilterSeries(ByVal p_oSeries As Series, ByVal p_strFilter As String)

    Dim oDtFilter As DataTable = Dt_Stat_CA_CHAFF.Copy
    If p_strFilter <> "" Then oDtFilter.DefaultView.RowFilter = p_strFilter

    Select Case p_oSeries.Name

      Case "SeriesCHAFF"
        p_oSeries.DataSource = oDtFilter

    End Select

  End Sub

End Class
