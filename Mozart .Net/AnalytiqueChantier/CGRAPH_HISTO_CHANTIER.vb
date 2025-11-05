Imports DevExpress.XtraCharts
Imports DevExpress.XtraGrid.Columns
Imports MozartLib


Public Class CGRAPH_HISTO_CHANTIER

  Dim Dt_ANA_MARGE As DataTable
  Dim iNIDCHANTIER As Int32

  Dim _sTitleForm As String
  Dim _sTitleLabel As String


  Public Sub New(ByVal c_iNIDCHANTIER As Int32)

    _sTitleForm = "Maîtrise de la marge"
    _sTitleLabel = "Marge en €"
    iNIDCHANTIER = c_iNIDCHANTIER

  End Sub

  Public ReadOnly Property Dt_Stat As DataTable
    Get
      Return Dt_ANA_MARGE
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
      oTitleCHartTmp.Text = String.Format("Maîtrise de la marge")
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
    sSQL = String.Format("exec [api_sp_ChantierListeHistoRea] {0}, 'ASC'", iNIDCHANTIER)

    Dt_ANA_MARGE = New DataTable
    Dt_ANA_MARGE = ModDataGridView.LoadList(sSQL, MozartDatabase.cnxMozart)

  End Sub

    Public Function CreateSeries() As Series

        Dim oSeries As New Series("SeriesMarge", ViewType.Line)

        oSeries.DataSource = Dt_ANA_MARGE.DefaultView

        'Specify data members to bind the series.
        oSeries.ArgumentScaleType = ScaleType.Qualitative
        oSeries.ArgumentDataMember = "DDATEHISTO"
        oSeries.ValueScaleType = ScaleType.Numerical
        oSeries.ValueDataMembers.AddRange(New String() {"NTOTMARGE"})
        oSeries.ShowInLegend = False
        oSeries.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False

        'CType(oSeries.View, SideBySideBarSeriesView).ColorEach = True

        Return oSeries

    End Function


    Public Sub SetFilterSeries(ByVal p_oSeries As Series, ByVal p_strFilter As String)

        Dim oDtFilter As DataTable = Dt_ANA_MARGE.Copy
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
