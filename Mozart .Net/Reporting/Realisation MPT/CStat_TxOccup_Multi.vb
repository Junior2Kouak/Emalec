Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class CStat_TxOccup_Multi

  Dim oGestConnectSQLReplicate As CGestionSQL

  Dim sTypeStat As String
  Dim sLibelleService As String

  Dim Dt_Stat_Tx_Multi As DataTable

  Dim _sTitleForm As String
  Dim _sTitleLabel As String

  Dim iValueObj As Int32

  Dim _iNbSeries(0 To 1) As Int32
  Dim iNbDataGraph As Int32 = 0

  Dim LineTendancePOURC As RegressionLine
  Dim _LineObjectifPOURC As ConstantLine

  Public Sub New(ByVal c_Type As String)

    oGestConnectSQLReplicate = New CGestionSQL

    sTypeStat = c_Type

    Select Case sTypeStat.ToUpper

      Case "MULTI" : sLibelleService = "MULTITECHNIQUE"
      Case "EXT" : sLibelleService = "EI"
      Case "COUV" : sLibelleService = "COUVERTURE"
      Case "CLIM" : sLibelleService = "CLIMATISATION"

    End Select

    _sTitleForm = String.Format("Moyenne d'heures par mois pour les techniciens {0}", MozartParams.NomSociete)
    _sTitleLabel = String.Format("Taux de charge des techniciens {0} {1}", MozartParams.NomSociete, sLibelleService)

    'on definit les series a creer dynamiquement par chartcontrol
    _iNbSeries(0) = 2
    _iNbSeries(1) = 1

    If sTypeStat.ToUpper = "EXT" Then
      iValueObj = 70
      ConfigLineConstante(iValueObj.ToString)
    Else
      iValueObj = 95
      ConfigLineConstante(iValueObj.ToString)
    End If

  End Sub

  Public ReadOnly Property Dt_Stat As DataTable
    Get
      Return Dt_Stat_Tx_Multi
    End Get
  End Property

  Public ReadOnly Property ValueObj As Int32
    Get
      Return iValueObj
    End Get
  End Property

  Public ReadOnly Property sTitleForm As String
    Get
      Return _sTitleForm
    End Get
  End Property

  Public ReadOnly Property iNbSeries As Int32()
    Get
      Return _iNbSeries
    End Get
  End Property

  Public ReadOnly Property sTitleLabel As String
    Get
      Return _sTitleLabel
    End Get
  End Property

  Public ReadOnly Property IsLineConst As Boolean
    Get
      Return True
    End Get
  End Property

  Public ReadOnly Property LineObjectifPOURC As ConstantLine
    Get
      Return _LineObjectifPOURC
    End Get
  End Property

#Region "Config_ChartControl"

  Public ReadOnly Property FormatAxeY As NumericFormat
    Get
      Return NumericFormat.Number
    End Get
  End Property

  Public ReadOnly Property TitleChart As ChartTitle
    Get

      Dim oTitleCHartTmp As New ChartTitle
      oTitleCHartTmp.Text = String.Format("Taux de charges des techniciens {0} {1}", sLibelleService, MozartParams.NomSociete)
      oTitleCHartTmp.TextColor = System.Drawing.Color.Black
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
      sSQL = String.Format("exec api_sp_StatIndicaPlanning '{0}', '{1}', {2}", sDateDebut, sDateFin, sTypeStat)

      Dt_Stat_Tx_Multi = New DataTable
      Dt_Stat_Tx_Multi = ModDataGridView.LoadList(sSQL, oGestConnectSQLReplicate.CnxSQLOpen)

      oGestConnectSQLReplicate.CloseConnexionSQL()

    End If

  End Sub

  Public Function NamingColumn(ByVal iCol As Int32) As GridColumn

    Dim oColumnDataTable As GridColumn

    If Not Dt_Stat_Tx_Multi Is Nothing Then

      oColumnDataTable = New GridColumn

      With oColumnDataTable

        Select Case iCol

          Case 0
            .Caption = "Année"
            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .DisplayFormat.FormatString = "0"
            .Visible = True
            .VisibleIndex = iCol
            .FieldName = "annee"
            .Name = "Colannee"
            .Width = 50
          Case 1
            .Caption = "Mois"
            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .DisplayFormat.FormatString = "0"
            .Visible = True
            .VisibleIndex = iCol
            .FieldName = "mois"
            .Name = "ColMOIS"
            .Width = 50
          Case 2
            .Caption = "Heures Réf."
            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .DisplayFormat.FormatString = "0"
            .Visible = True
            .VisibleIndex = iCol
            .FieldName = "HR"
            .Name = "ColHR"
          Case 3
            .Caption = "Moy"
            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .DisplayFormat.FormatString = "d0"
            .Visible = True
            .VisibleIndex = iCol
            .FieldName = "moynbhrtot"
            .Name = "Colmoynbhrtot"
          Case 4
            .Caption = "En %"
            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .DisplayFormat.FormatString = "p1"
            .Visible = True
            .VisibleIndex = iCol
            .FieldName = "POURC"
            .Name = "ColPOURC"
          Case 4
            .Caption = "AXE_X"
            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.None
            .DisplayFormat.FormatString = ""
            .Visible = False
            .VisibleIndex = iCol
            .FieldName = "AXE_X"
            .Name = "ColAxeX"

        End Select

      End With

      Return oColumnDataTable

    Else

      Return Nothing

    End If

  End Function

  Public Function CreateSeries(ByVal p_iIDChart As Int32, ByVal p_iIDSeries As Int32) As Series

    Dim oSeries As New Series()

    Select Case p_iIDChart

      Case 0

        Select Case p_iIDSeries

          Case 0

            oSeries.Name = "SeriesHR"
            oSeries.ChangeView(ViewType.Bar)

            oSeries.DataSource = DT_FilterTop(Dt_Stat_Tx_Multi.DefaultView)

            'Specify data members to bind the series.
            oSeries.ArgumentScaleType = ScaleType.Qualitative
            oSeries.ArgumentDataMember = "AXE_X"
            oSeries.ValueScaleType = ScaleType.Numerical
            oSeries.ValueDataMembers.AddRange(New String() {"HR"})
            oSeries.ShowInLegend = False
            oSeries.LegendText = "Nb d'heures de référence par mois"
            oSeries.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
            oSeries.View.Color = Color.DodgerBlue

            CType(oSeries.View, SideBySideBarSeriesView).ColorEach = False

          Case 1

            oSeries.Name = "Seriesmoynbhrtot"
            oSeries.ChangeView(ViewType.Bar)
            oSeries.DataSource = DT_FilterTop(Dt_Stat_Tx_Multi.DefaultView)

            'Specify data members to bind the series.
            oSeries.ArgumentScaleType = ScaleType.Qualitative
            oSeries.ArgumentDataMember = "AXE_X"
            oSeries.ValueScaleType = ScaleType.Numerical
            oSeries.ValueDataMembers.AddRange(New String() {"moynbhrtot"})
            oSeries.ShowInLegend = False
            oSeries.LegendText = "Nb d'heures moyen d'un technicien"
            oSeries.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False

            CType(oSeries.View, SideBySideBarSeriesView).ColorEach = False

        End Select

      Case 1

        Select Case p_iIDSeries

          Case 0

            oSeries.Name = "SeriesPOURC"
            oSeries.ChangeView(ViewType.Bar)

            oSeries.DataSource = DT_FilterTop(Dt_Stat_Tx_Multi.DefaultView)

            'Specify data members to bind the series.
            oSeries.ArgumentScaleType = ScaleType.Qualitative
            oSeries.ArgumentDataMember = "AXE_X"
            oSeries.ValueScaleType = ScaleType.Numerical
            oSeries.ValueDataMembers.AddRange(New String() {"POURC"})
            oSeries.ShowInLegend = False
            oSeries.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
            oSeries.View.Color = Color.DodgerBlue


            CType(oSeries.View, SideBySideBarSeriesView).ColorEach = False

            'ligne de tendance
            LineTendancePOURC = New RegressionLine(ValueLevel.Value)
            LineTendancePOURC.Visible = True
            LineTendancePOURC.ShowInLegend = False
            LineTendancePOURC.LineStyle.Thickness = 2
            LineTendancePOURC.Name = "Courbe de tendance"

            LineTendancePOURC.Color = Color.Fuchsia

            'ajout de la ligne objectif mensuel
            CType(oSeries.View, SideBySideBarSeriesView).Indicators.Add(LineTendancePOURC)


        End Select


    End Select

    Return oSeries

  End Function

  'on creer la ligne droite
  Private Sub ConfigLineConstante(ByVal NB As String)

    'ajout de la ligne objectif
    _LineObjectifPOURC = New ConstantLine("QUALITE")
    _LineObjectifPOURC.AxisValue = Convert.ToDecimal(NB / 100) 'If(NB = 70, 0.59999999999999998, 0.94999999999999996)

    _LineObjectifPOURC.Visible = True
    _LineObjectifPOURC.ShowInLegend = False
    _LineObjectifPOURC.LegendText = "Objectif qualité : " & NB.ToString & " %"
    _LineObjectifPOURC.ShowBehind = False

    ' Customize the constant line's title.
    _LineObjectifPOURC.Title.Visible = True
    _LineObjectifPOURC.Title.Text = "Objectif"
    _LineObjectifPOURC.Title.TextColor = Color.LightGreen
    '_LineObjectifPOURC.Title.Antialiasing = False
    _LineObjectifPOURC.Title.Font = New Font("Tahoma", 8, FontStyle.Bold)
    '_LineObjectifPOURC.Title.ShowBelowLine = True
    '_LineObjectifPOURC.Title.Alignment = ConstantLineTitleAlignment.Far

    ' Customize the appearance of the constant line.
    _LineObjectifPOURC.Color = Color.Lime
    '_LineObjectifPOURC.LineStyle.DashStyle = DashStyle.Dash
    _LineObjectifPOURC.LineStyle.Thickness = 2

  End Sub

  Public Sub SetFilterSeries(ByVal p_oSeries As Series, ByVal p_strFilter As String)

    Dim oDtFilter As DataTable = Dt_Stat_Tx_Multi.Copy
    If p_strFilter <> "" Then oDtFilter.DefaultView.RowFilter = p_strFilter

    Select Case p_oSeries.Name

      Case "SeriesHR"
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

    If iNbDataGraph > 0 Then oDT_FilterTop.DefaultView.RowFilter = String.Format("{0} <= {1}", sNomColIncrement, iNbDataGraph)

    oDT_FilterTop.DefaultView.Sort = "ANNEE ASC, MOIS ASC"

    Return oDT_FilterTop

  End Function

End Class
