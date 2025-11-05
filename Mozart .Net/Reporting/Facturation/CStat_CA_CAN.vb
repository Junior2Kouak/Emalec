Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class CStat_CA_CAN

  Dim oGestConnectSQLReplicate As CGestionSQL

  Dim Dt_Stat_CA_CAN As DataTable

  Dim _sTitleForm As String
  Dim _sTitleLabel As String

  Dim iNbDataGraph As Int32 = 30

  Public Sub New()

    oGestConnectSQLReplicate = New CGestionSQL

    _sTitleForm = "Statistiques par compte analytique sur une période"
    _sTitleLabel = "CA par compte analytique"

  End Sub

  Public ReadOnly Property Dt_Stat As DataTable
    Get
      Return Dt_Stat_CA_CAN
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
      oTitleCHartTmp.Text = String.Format("Statistiques des {0} premiers comptes analytiques sur une période", iNbDataGraph)
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
      sSQL = String.Format("exec api_sp_StatistiqueCAN '{0}', '{1}', {2}, {3}", sDateDebut, sDateFin, MozartParams.NomSociete, 119)

      Dt_Stat_CA_CAN = New DataTable
      Dt_Stat_CA_CAN = ModDataGridView.LoadList(sSQL, oGestConnectSQLReplicate.CnxSQLOpen)

      oGestConnectSQLReplicate.CloseConnexionSQL()

    End If

  End Sub

  Public Function NamingColumn(ByVal iCol As Int32) As GridColumn

    Dim oColumnDataTable As GridColumn

    If Not Dt_Stat_CA_CAN Is Nothing Then

      oColumnDataTable = New GridColumn

      With oColumnDataTable

        Select Case iCol

          Case 0
            .Caption = "Cpt analytique"
            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.None
            .DisplayFormat.FormatString = ""
            .Visible = True
            .VisibleIndex = iCol
            .FieldName = "NCANNUM"
            .Name = "ColNCANNUM"
            .AppearanceCell.Options.UseTextOptions = True
            .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
          Case 1
            .Caption = "Titre"
            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.None
            .DisplayFormat.FormatString = ""
            .Visible = True
            .VisibleIndex = iCol
            .FieldName = "VCANLIB"
            .Name = "ColVCANLIB"
          Case 2
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

    Dim oSeries As New Series("SeriesCAN", ViewType.Bar)

    oSeries.DataSource = DT_FilterTop(Dt_Stat_CA_CAN.DefaultView)

    'Specify data members to bind the series.
    oSeries.ArgumentScaleType = ScaleType.Qualitative
    oSeries.ArgumentDataMember = "NCANNUM"
    oSeries.ValueScaleType = ScaleType.Numerical
    oSeries.ValueDataMembers.AddRange(New String() {"CA"})
    oSeries.ShowInLegend = False
    oSeries.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False

    CType(oSeries.View, SideBySideBarSeriesView).ColorEach = True

    Return oSeries

  End Function

  Public Sub SetFilterSeries(ByVal p_oSeries As Series, ByVal p_strFilter As String)

    Dim oDtFilter As DataTable = Dt_Stat_CA_CAN.Copy
    If p_strFilter <> "" Then oDtFilter.DefaultView.RowFilter = p_strFilter

    Select Case p_oSeries.Name

      Case "SeriesCAN"
        p_oSeries.DataSource = DT_FilterTop(oDtFilter.DefaultView)

    End Select

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

    oDT_FilterTop.DefaultView.RowFilter = String.Format("{0} <= {1}", sNomColIncrement, iNbDataGraph)
    Return oDT_FilterTop

  End Function

End Class
