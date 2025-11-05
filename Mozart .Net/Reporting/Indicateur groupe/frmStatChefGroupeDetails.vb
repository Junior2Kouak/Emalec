Imports DevExpress.XtraGrid.Columns
Imports MozartLib
Imports System.Data.SqlClient

Public Class frmStatChefGroupeDetails

  Dim strName, strNPERNUM As String
  Dim iTypeDetail As Int32
  Dim CnxAux As New CGestionSQL

  Dim _DateDebut As String
  Dim _DateFin As String

  Dim _DtEncours As DataTable

  Public Property DtEncours As DataTable
    Get
      DtEncours = _DtEncours
    End Get
    Set(value As DataTable)
      _DtEncours = value
    End Set
  End Property

  Public Sub New(ByVal p_Param As Object, ByVal typeDetail As Int32, ByVal c_DateDebut As String, ByVal c_DateFin As String)

    InitializeComponent()

    If typeDetail = 7 Or typeDetail = 8 Then
      strName = p_Param(0)
      iTypeDetail = typeDetail
    Else
      strName = p_Param(1)
      strNPERNUM = p_Param(2)
      _DateDebut = c_DateDebut
      _DateFin = c_DateFin
      iTypeDetail = typeDetail
    End If



  End Sub

  Private Sub frmStatChefGroupeDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Dim ds As DataSet

    Me.Cursor = Cursors.WaitCursor

    Select Case iTypeDetail
      Case 1 : LabelType.Text = My.Resources.Reporting_RealisationMPT_frmStatConducteursTravaux_nbr_devis
      Case 2 : LabelType.Text = My.Resources.Reporting_RealisationMPT_frmStatConducteursTravaux_montant_devis
      Case 3 : LabelType.Text = My.Resources.Reporting_RealisationMPT_frmStatConducteursTravaux_montant_fact
      Case 4 : LabelType.Text = My.Resources.Reporting_RealisationMPT_frmStatConducteursTravaux_montant_marge
      Case 5 : LabelType.Text = My.Resources.Reporting_RealisationMPT_frmStatConducteursTravaux_CA_actions_en_cours
      Case 6 : LabelType.Text = My.Resources.Reporting_RealisationMPT_frmStatConducteursTravaux_nbr_devis
      Case 7 : LabelType.Text = "En cours compta du chaff " : LabelDetail.Text = strName 'My.Resources.Reporting_RealisationMPT_frmStatConducteursTravaux_nbr_devis
      Case 8 : LabelType.Text = "Impayés client du chaff " : LabelDetail.Text = strName 'My.Resources.Reporting_RealisationMPT_frmStatConducteursTravaux_nbr_devis

    End Select

    '1 = My.Resources.Reporting_RealisationMPT_frmStatConducteursTravaux_nbr_devis
    '2 = My.Resources.Reporting_RealisationMPT_frmStatConducteursTravaux_montant_devis
    '3 = My.Resources.Reporting_RealisationMPT_frmStatConducteursTravaux_montant_fact
    '4 = My.Resources.Reporting_RealisationMPT_frmStatConducteursTravaux_montant_marge
    '5 = My.Resources.Reporting_RealisationMPT_frmStatConducteursTravaux_CA_actions_en_cours
    '6 = My.Resources.Reporting_RealisationMPT_frmStatConducteursTravaux_nbr_devis
    '7 = en cours comtpa

    If iTypeDetail = 1 Then
      GCRECEPTIONS.Width = 970
      GridView1.Columns.ColumnByName("col1").Caption = "N° DI"
      GridView1.Columns.ColumnByName("col1").Width = 80
      GridView1.Columns.ColumnByName("col1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col2").Caption = My.Resources.Global_desc_action
      GridView1.Columns.ColumnByName("col2").Width = 400
      GridView1.Columns.ColumnByName("col3").Caption = My.Resources.Global_date_action
      GridView1.Columns.ColumnByName("col3").Width = 90
      GridView1.Columns.ColumnByName("col3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col4").Caption = My.Resources.Global_CLient
      GridView1.Columns.ColumnByName("col4").Width = 200
      GridView1.Columns.ColumnByName("col5").Caption = My.Resources.Global_site
      GridView1.Columns.ColumnByName("col5").Width = 200
      GridView1.Columns.ColumnByName("col6").Caption = ""
      GridView1.Columns.ColumnByName("col6").Visible = False

    ElseIf iTypeDetail = 2 Then
      GCRECEPTIONS.Width = 1070
      GridView1.Columns.ColumnByName("col1").Caption = "N° DI"
      GridView1.Columns.ColumnByName("col1").Width = 80
      GridView1.Columns.ColumnByName("col1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col2").Caption = My.Resources.Global_desc_action
      GridView1.Columns.ColumnByName("col2").Width = 400
      GridView1.Columns.ColumnByName("col3").Caption = My.Resources.Global_date_action
      GridView1.Columns.ColumnByName("col3").Width = 90
      GridView1.Columns.ColumnByName("col3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col4").Caption = My.Resources.Global_CLient
      GridView1.Columns.ColumnByName("col4").Width = 200
      GridView1.Columns.ColumnByName("col5").Caption = My.Resources.Global_site
      GridView1.Columns.ColumnByName("col5").Width = 200
      GridView1.Columns.ColumnByName("col6").Caption = My.Resources.Global_montant
      GridView1.Columns.ColumnByName("col6").Width = 100

    ElseIf iTypeDetail = 3 Then
      GCRECEPTIONS.Width = 870
      GridView1.Columns.ColumnByName("col1").Caption = "N° DI"
      GridView1.Columns.ColumnByName("col1").Width = 80
      GridView1.Columns.ColumnByName("col1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col2").Caption = My.Resources.Global_desc_action
      GridView1.Columns.ColumnByName("col2").Width = 400
      GridView1.Columns.ColumnByName("col3").Caption = My.Resources.Global_date_di
      GridView1.Columns.ColumnByName("col3").Width = 90
      GridView1.Columns.ColumnByName("col3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col4").Caption = My.Resources.Global_CLient
      GridView1.Columns.ColumnByName("col4").Width = 200
      GridView1.Columns.ColumnByName("col5").Caption = My.Resources.Global_site
      GridView1.Columns.ColumnByName("col5").Width = 200
      GridView1.Columns.ColumnByName("col6").Caption = My.Resources.Global_montant
      GridView1.Columns.ColumnByName("col6").Width = 100

    ElseIf iTypeDetail = 4 Then
      GCRECEPTIONS.Width = 770
      GridView1.Columns.ColumnByName("col1").Caption = "N° DI"
      GridView1.Columns.ColumnByName("col1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col1").Width = 80
      GridView1.Columns.ColumnByName("col2").Caption = My.Resources.Global_date_di
      GridView1.Columns.ColumnByName("col2").Width = 90
      GridView1.Columns.ColumnByName("col2").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col3").Caption = My.Resources.Global_CLient
      GridView1.Columns.ColumnByName("col3").Width = 200
      GridView1.Columns.ColumnByName("col4").Caption = My.Resources.Global_site
      GridView1.Columns.ColumnByName("col4").Width = 200
      GridView1.Columns.ColumnByName("col5").Caption = My.Resources.Global_coeff
      GridView1.Columns.ColumnByName("col5").Width = 50
      GridView1.Columns.ColumnByName("col6").Caption = My.Resources.Reporting_RealisationMPT_frmStatChefGroupeDetails_marge
      GridView1.Columns.ColumnByName("col6").Width = 150
      GridView1.Columns.ColumnByName("col6").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.None

    ElseIf iTypeDetail = 5 Then
      GCRECEPTIONS.Width = 770
      GridView1.Columns.ColumnByName("col1").Caption = "N° DI"
      GridView1.Columns.ColumnByName("col1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col1").Width = 80
      GridView1.Columns.ColumnByName("col2").Caption = My.Resources.Reporting_RealisationMPT_frmStatChefGroupeDetails_num_action
      GridView1.Columns.ColumnByName("col2").Width = 90
      GridView1.Columns.ColumnByName("col2").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col3").Caption = My.Resources.Global_CLient
      GridView1.Columns.ColumnByName("col3").Width = 200
      GridView1.Columns.ColumnByName("col4").Caption = My.Resources.Reporting_RealisationMPT_frmStatChefGroupeDetails_date_action
      GridView1.Columns.ColumnByName("col4").Width = 200
      GridView1.Columns.ColumnByName("col5").Caption = ""
      GridView1.Columns.ColumnByName("col5").Visible = False
      GridView1.Columns.ColumnByName("col5").Width = 0
      GridView1.Columns.ColumnByName("col6").Caption = My.Resources.Reporting_RealisationMPT_frmStatChefGroupeDetails_montant_devis_ht
      GridView1.Columns.ColumnByName("col6").Width = 200

    ElseIf iTypeDetail = 6 Then
      GCRECEPTIONS.Width = 770
      GridView1.Columns.ColumnByName("col1").Caption = "N° DI"
      GridView1.Columns.ColumnByName("col1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col1").Width = 80
      GridView1.Columns.ColumnByName("col2").Caption = My.Resources.Reporting_RealisationMPT_frmStatChefGroupeDetails_num_action
      GridView1.Columns.ColumnByName("col2").Width = 90
      GridView1.Columns.ColumnByName("col2").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col3").Caption = My.Resources.Global_CLient
      GridView1.Columns.ColumnByName("col3").Width = 200
      GridView1.Columns.ColumnByName("col4").Caption = My.Resources.Reporting_RealisationMPT_frmStatChefGroupeDetails_date_action
      GridView1.Columns.ColumnByName("col4").Width = 200
      GridView1.Columns.ColumnByName("col5").Caption = ""
      GridView1.Columns.ColumnByName("col5").Visible = False
      GridView1.Columns.ColumnByName("col5").Width = 0
      GridView1.Columns.ColumnByName("col6").Caption = My.Resources.Reporting_RealisationMPT_frmStatChefGroupeDetails_montant_devis_ht
      GridView1.Columns.ColumnByName("col6").Width = 200

    ElseIf iTypeDetail = 7 Then

      ', , , CHAFF, , , NACTNUM, VSITPAYS, SCODE

      GCRECEPTIONS.Width = 1040
      GridView1.Columns.ColumnByName("col1").Caption = "N° DI"
      GridView1.Columns.ColumnByName("col1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col1").Width = 80
      GridView1.Columns.ColumnByName("col1").FieldName = "NDINNUM"

      GridView1.Columns.ColumnByName("col2").Caption = My.Resources.Global_CLient 'My.Resources.Reporting_RealisationMPT_frmStatChefGroupeDetails_num_action
      GridView1.Columns.ColumnByName("col2").Width = 180
      GridView1.Columns.ColumnByName("col2").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col2").FieldName = "VCLINOM"

      GridView1.Columns.ColumnByName("col3").Caption = "Action" 'My.Resources.reporting_realisationmpt_frmstatche
      GridView1.Columns.ColumnByName("col3").Width = 200
      GridView1.Columns.ColumnByName("col3").FieldName = "VACTDES"

      GridView1.Columns.ColumnByName("col4").Caption = "Compte" 'My.Resources.Reporting_RealisationMPT_frmStatChefGroupeDetails_date_action
      GridView1.Columns.ColumnByName("col4").Width = 80
      GridView1.Columns.ColumnByName("col4").FieldName = "NDINCTE"

      GridView1.Columns.ColumnByName("col5").Caption = "Date Exe"
      GridView1.Columns.ColumnByName("col5").Visible = False
      GridView1.Columns.ColumnByName("col5").Width = 80
      GridView1.Columns.ColumnByName("col5").FieldName = "DACTDEX"

      GridView1.Columns.ColumnByName("col6").Caption = "Montant HT" 'My.Resources.Reporting_RealisationMPT_frmStatChefGroupeDetails_montant_devis_ht
      GridView1.Columns.ColumnByName("col6").Width = 200
      GridView1.Columns.ColumnByName("col6").FieldName = "NACTVAL"

      Dim ColNACTNUM As GridColumn = GridView1.Columns.AddField("NACTNUM")
      Dim ColVSITPAYS As GridColumn = GridView1.Columns.AddVisible("VSITPAYS", "Pays du site")
      Dim ColSCODE As GridColumn = GridView1.Columns.AddVisible("SCODE", "Code")

      GridView1.Columns("VSITPAYS").VisibleIndex = 5
      GridView1.Columns("SCODE").VisibleIndex = 4

    ElseIf iTypeDetail = 8 Then

      'col1 et col6 avec summary
      GCRECEPTIONS.Width = 1040

      GridView1.Columns.ColumnByName("col1").Caption = "N° Facture"
      GridView1.Columns.ColumnByName("col1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col1").Width = 80
      GridView1.Columns.ColumnByName("col1").FieldName = "NFACNUM"
      GridView1.Columns.ColumnByName("col1").VisibleIndex = 0

      GridView1.Columns.ColumnByName("col2").Caption = "Client" 'My.Resources.Reporting_RealisationMPT_frmStatChefGroupeDetails_num_action
      GridView1.Columns.ColumnByName("col2").Width = 180
      GridView1.Columns.ColumnByName("col2").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col2").FieldName = "VCLINOM"
      GridView1.Columns.ColumnByName("col2").VisibleIndex = 1

      GridView1.Columns.ColumnByName("col3").Caption = "Date facture" 'My.Resources.reporting_realisationmpt_frmstatche
      GridView1.Columns.ColumnByName("col3").Width = 120
      GridView1.Columns.ColumnByName("col3").FieldName = "DFACDAT"
      GridView1.Columns.ColumnByName("col3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col3").VisibleIndex = 2

      GridView1.Columns.ColumnByName("col4").Caption = "Date echéance" 'My.Resources.Reporting_RealisationMPT_frmStatChefGroupeDetails_date_action
      GridView1.Columns.ColumnByName("col4").Width = 120
      GridView1.Columns.ColumnByName("col4").FieldName = "DDATEECH"
      GridView1.Columns.ColumnByName("col4").VisibleIndex = 3
      GridView1.Columns.ColumnByName("col4").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

      GridView1.Columns.ColumnByName("col6").Caption = "Restant dû"
      GridView1.Columns.ColumnByName("col6").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col6").Width = 80
      GridView1.Columns.ColumnByName("col6").FieldName = "NRESTEDU"
      GridView1.Columns.ColumnByName("col6").VisibleIndex = 4

      GridView1.Columns.ColumnByName("col5").Caption = "Montant TTC" 'My.Resources.Reporting_RealisationMPT_frmStatChefGroupeDetails_montant_devis_ht
      GridView1.Columns.ColumnByName("col5").Width = 80
      GridView1.Columns.ColumnByName("col5").FieldName = "NELFTTC"
      GridView1.Columns.ColumnByName("col5").VisibleIndex = 5

      Dim ColDFACNBJ As GridColumn = GridView1.Columns.AddVisible("DFACNBJ", "Nb J")
      ColDFACNBJ.Width = 60
      GridView1.Columns("DFACNBJ").VisibleIndex = 6
      GridView1.Columns("DFACNBJ").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

      Dim ColVOBS_TEXT As GridColumn = GridView1.Columns.AddVisible("VOBS_TEXT", "Remarques")
      ColVOBS_TEXT.Width = 180
      GridView1.Columns("VOBS_TEXT").VisibleIndex = 7
      GridView1.Columns("VOBS_TEXT").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

    End If

    Try

      If iTypeDetail = 7 Or iTypeDetail = 8 Then

        GCRECEPTIONS.DataSource = DtEncours

      Else

        If CnxAux.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = False Then
          MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ds = New DataSet

        LabelDetail.Text = strName
        Dim cmdLoadList As New SqlCommand("[api_sp_StatChefGroupeDetails]", CnxAux.CnxSQLOpen)
        cmdLoadList.CommandType = CommandType.StoredProcedure
        cmdLoadList.Parameters.Add("@npernum", SqlDbType.Int).Value = strNPERNUM
        cmdLoadList.Parameters.Add("@typeDetail", SqlDbType.Int).Value = iTypeDetail
        cmdLoadList.Parameters.Add("@p_datedebut", SqlDbType.DateTime).Value = _DateDebut
        cmdLoadList.Parameters.Add("@p_datefin", SqlDbType.DateTime).Value = _DateFin


        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
        sqlAdpat.Fill(ds)

        GCRECEPTIONS.DataSource = ds.Tables(0)

      End If



    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmStatChefGroupeDetails_sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    GCRECEPTIONS.Print()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\StatsChefGroupe_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xlsx"
    GCRECEPTIONS.ExportToXlsx(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub
End Class