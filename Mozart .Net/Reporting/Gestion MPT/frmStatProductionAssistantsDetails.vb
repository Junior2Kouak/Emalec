Imports System.Data.SqlClient
Imports MozartLib

Public Class frmStatProductionAssistantsDetails

  Dim NPERNUM As Integer
  Dim CODE As String
  Dim DATEDEB As String
  Dim DATEFIN As String

  Public Sub New(_NPERNUM As String, _DateDu As String, _DateAu As String, _colonne As String)

    InitializeComponent()
    NPERNUM = _NPERNUM
    CODE = _colonne
    DATEDEB = _DateDu
    DATEFIN = _DateAu
  End Sub

  Private Sub frmStatProductionAssistantsDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    lblDateJour.Text = My.Resources.Global_le & Date.Today

    Try

      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_StatistiqueProduction_Details", MozartDatabase.cnxMozart)
      CmdSql.CommandType = CommandType.StoredProcedure
      CmdSql.Parameters.Add("@NPERNUM", SqlDbType.Int).Value = NPERNUM
      CmdSql.Parameters.Add("@DateDeb", SqlDbType.DateTime).Value = DATEDEB
      CmdSql.Parameters.Add("@DateFin", SqlDbType.DateTime).Value = DATEFIN
      CmdSql.Parameters.Add("@Code", SqlDbType.VarChar).Value = CODE

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
      Dim dtStat As New DataSet
      sqlAdpat.Fill(dtStat)

      GCStat.DataSource = dtStat.Tables(0)

      CmdSql.Dispose()

      Dim Titre As String = ""
      If CODE = "3" Then
        Titre = My.Resources.Gestion_MPT_frmStatProductionAssistantsDetails_CreationDI
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = "N° DI"
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = My.Resources.Global_desc_action
        GVStat.Columns.ColumnByName("val2").Width = 400
        GVStat.Columns.ColumnByName("val3").Caption = My.Resources.Global_date_action
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = My.Resources.Global_CLient
        GVStat.Columns.ColumnByName("val4").Width = 200
        GVStat.Columns.ColumnByName("val5").Caption = ""
        GVStat.Columns.ColumnByName("val5").Width = 0
        GVStat.Columns.ColumnByName("val5").Visible = False
        GVStat.Columns.ColumnByName("val6").Caption = ""
        GVStat.Columns.ColumnByName("val6").Width = 0
        GVStat.Columns.ColumnByName("val6").Visible = False
      End If

      If CODE = "4" Then
        Titre = My.Resources.Gestion_MPT_frmStatProductionAssistantsDetails_Creationcommande
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = My.Resources.Global_numCommande
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = My.Resources.Global_date_commande
        GVStat.Columns.ColumnByName("val2").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Width = 90
        GVStat.Columns.ColumnByName("val3").Caption = My.Resources.Global_sousTraitant
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = My.Resources.Global_montant
        GVStat.Columns.ColumnByName("val4").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GVStat.Columns.ColumnByName("val4").Width = 200
        GVStat.Columns.ColumnByName("val5").Caption = My.Resources.Global_CLient
        GVStat.Columns.ColumnByName("val5").Width = 200
        GVStat.Columns.ColumnByName("val5").Visible = True
        GVStat.Columns.ColumnByName("val6").Caption = ""
        GVStat.Columns.ColumnByName("val6").Width = 0
        GVStat.Columns.ColumnByName("val6").Visible = False
      End If

      If CODE = "5" Then
        Titre = My.Resources.Gestion_MPT_frmStatProductionAssistantsDetails_Creationdemande
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = My.Resources.Global_num_devis
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = My.Resources.Global_desc_Devis
        GVStat.Columns.ColumnByName("val2").Width = 400
        GVStat.Columns.ColumnByName("val3").Caption = My.Resources.Global_date_Devis
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = My.Resources.Global_CLient
        GVStat.Columns.ColumnByName("val4").Width = 200
        GVStat.Columns.ColumnByName("val4").Visible = True
        GVStat.Columns.ColumnByName("val5").Caption = ""
        GVStat.Columns.ColumnByName("val5").Width = 0
        GVStat.Columns.ColumnByName("val5").Visible = False
        GVStat.Columns.ColumnByName("val6").Caption = ""
        GVStat.Columns.ColumnByName("val6").Width = 0
        GVStat.Columns.ColumnByName("val6").Visible = False
      End If

      If CODE = "6" Then
        Titre = My.Resources.Gestion_MPT_frmStatProductionAssistantsDetails_CreationSTT
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = My.Resources.Global_num_contrat
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = My.Resources.Global_desc_contrat
        GVStat.Columns.ColumnByName("val2").Width = 400
        GVStat.Columns.ColumnByName("val3").Caption = My.Resources.Global_date_contrat
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = My.Resources.Global_CLient
        GVStat.Columns.ColumnByName("val4").Width = 200
        GVStat.Columns.ColumnByName("val4").Visible = True
        GVStat.Columns.ColumnByName("val5").Caption = ""
        GVStat.Columns.ColumnByName("val5").Width = 0
        GVStat.Columns.ColumnByName("val5").Visible = False
        GVStat.Columns.ColumnByName("val6").Caption = ""
        GVStat.Columns.ColumnByName("val6").Width = 0
        GVStat.Columns.ColumnByName("val6").Visible = False
      End If

      If CODE = "7" Then
        Titre = "Réception des attachements"
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = "N° DI"
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = My.Resources.Global_desc_action
        GVStat.Columns.ColumnByName("val2").Width = 400
        GVStat.Columns.ColumnByName("val3").Caption = My.Resources.Global_date_exécution
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = My.Resources.Global_CLient
        GVStat.Columns.ColumnByName("val4").Width = 200
        GVStat.Columns.ColumnByName("val5").Caption = ""
        GVStat.Columns.ColumnByName("val5").Width = 0
        GVStat.Columns.ColumnByName("val5").Visible = False
        GVStat.Columns.ColumnByName("val6").Caption = ""
        GVStat.Columns.ColumnByName("val6").Width = 0
        GVStat.Columns.ColumnByName("val6").Visible = False
      End If

      If CODE = "8" Then
        Titre = My.Resources.Gestion_MPT_frmStatProductionAssistantsDetails_CreationSTTdevis
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = My.Resources.Global_N_Devis
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = My.Resources.Global_desc_Devis
        GVStat.Columns.ColumnByName("val2").Width = 400
        GVStat.Columns.ColumnByName("val3").Caption = My.Resources.Global_date_Devis
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = My.Resources.Global_montant_devis
        GVStat.Columns.ColumnByName("val4").Width = 90
        GVStat.Columns.ColumnByName("val4").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GVStat.Columns.ColumnByName("val5").Caption = "N° DI"
        GVStat.Columns.ColumnByName("val5").Width = 80
        GVStat.Columns.ColumnByName("val5").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val6").Caption = My.Resources.Global_CLient
        GVStat.Columns.ColumnByName("val6").Width = 200
        GVStat.Columns.ColumnByName("val6").Visible = True
      End If

      If CODE = "9" Then
        Titre = My.Resources.Gestion_MPT_frmStatProductionAssistantsDetails_Creation_devis_with_STT
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = My.Resources.Global_N_Devis
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = My.Resources.Global_desc_Devis
        GVStat.Columns.ColumnByName("val2").Width = 400
        GVStat.Columns.ColumnByName("val3").Caption = My.Resources.Global_date_Devis
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = My.Resources.Global_montant_devis
        GVStat.Columns.ColumnByName("val4").Width = 90
        GVStat.Columns.ColumnByName("val4").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GVStat.Columns.ColumnByName("val5").Caption = "N° DI"
        GVStat.Columns.ColumnByName("val5").Width = 80
        GVStat.Columns.ColumnByName("val5").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val6").Caption = My.Resources.Global_CLient
        GVStat.Columns.ColumnByName("val6").Width = 200
        GVStat.Columns.ColumnByName("val6").Visible = True
      End If

      If CODE = "10" Then
        Titre = My.Resources.Gestion_MPT_frmStatProductionAssistantsDetails_Creation_devis_complexe_STT
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = My.Resources.Global_N_Devis
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = My.Resources.Global_desc_Devis
        GVStat.Columns.ColumnByName("val2").Width = 400
        GVStat.Columns.ColumnByName("val3").Caption = My.Resources.Global_date_Devis
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = My.Resources.Global_montant_devis
        GVStat.Columns.ColumnByName("val4").Width = 90
        GVStat.Columns.ColumnByName("val4").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GVStat.Columns.ColumnByName("val5").Caption = "N° DI"
        GVStat.Columns.ColumnByName("val5").Width = 80
        GVStat.Columns.ColumnByName("val5").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val6").Caption = My.Resources.Global_CLient
        GVStat.Columns.ColumnByName("val6").Width = 200
        GVStat.Columns.ColumnByName("val6").Visible = True
      End If

      If CODE = "11" Then
        Titre = My.Resources.Gestion_MPT_frmStatProductionAssistantsDetails_Creation_devis_complexe_with_STT
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = My.Resources.Global_N_Devis
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = My.Resources.Global_desc_Devis
        GVStat.Columns.ColumnByName("val2").Width = 400
        GVStat.Columns.ColumnByName("val3").Caption = My.Resources.Global_date_Devis
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = My.Resources.Global_montant_devis
        GVStat.Columns.ColumnByName("val4").Width = 90
        GVStat.Columns.ColumnByName("val4").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GVStat.Columns.ColumnByName("val5").Caption = "N° DI"
        GVStat.Columns.ColumnByName("val5").Width = 80
        GVStat.Columns.ColumnByName("val5").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val6").Caption = My.Resources.Global_CLient
        GVStat.Columns.ColumnByName("val6").Width = 200
        GVStat.Columns.ColumnByName("val6").Visible = True
      End If

      If CODE = "12" Then
        Titre = My.Resources.Gestion_MPT_frmStatProductionAssistantsDetails_nbr_sortie
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = "N° DI"
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = My.Resources.Global_desc_article
        GVStat.Columns.ColumnByName("val2").Width = 400
        GVStat.Columns.ColumnByName("val3").Caption = My.Resources.Global_date_action
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = My.Resources.Global_quantite
        GVStat.Columns.ColumnByName("val4").Width = 90
        GVStat.Columns.ColumnByName("val5").Caption = My.Resources.Global_CLient
        GVStat.Columns.ColumnByName("val5").Width = 200
        GVStat.Columns.ColumnByName("val5").Visible = True
        GVStat.Columns.ColumnByName("val6").Caption = ""
        GVStat.Columns.ColumnByName("val6").Width = 0
        GVStat.Columns.ColumnByName("val6").Visible = False
      End If

      If CODE = "13" Then
        Titre = My.Resources.Gestion_MPT_frmStatProductionAssistantsDetails_nbr_info
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = "N° DI"
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = My.Resources.Global_desc_action
        GVStat.Columns.ColumnByName("val2").Width = 400
        GVStat.Columns.ColumnByName("val3").Caption = My.Resources.Global_info_sites
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = My.Resources.Global_CLient
        GVStat.Columns.ColumnByName("val4").Width = 90
        GVStat.Columns.ColumnByName("val5").Caption = ""
        GVStat.Columns.ColumnByName("val5").Width = 0
        GVStat.Columns.ColumnByName("val5").Visible = False
        GVStat.Columns.ColumnByName("val6").Caption = ""
        GVStat.Columns.ColumnByName("val6").Width = 0
        GVStat.Columns.ColumnByName("val6").Visible = False
      End If

      If CODE = "14" Then
        Titre = My.Resources.Gestion_MPT_frmStatProductionAssistantsDetails_nbr_new_STT
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = My.Resources.Global_Num_STT
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = My.Resources.Global_Nom_STT
        GVStat.Columns.ColumnByName("val2").Width = 400
        GVStat.Columns.ColumnByName("val3").Caption = My.Resources.Global_date_STT
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = My.Resources.Global_Pays_STT
        GVStat.Columns.ColumnByName("val4").Width = 90
        GVStat.Columns.ColumnByName("val5").Caption = ""
        GVStat.Columns.ColumnByName("val5").Width = 0
        GVStat.Columns.ColumnByName("val5").Visible = False
        GVStat.Columns.ColumnByName("val6").Caption = ""
        GVStat.Columns.ColumnByName("val6").Width = 0
        GVStat.Columns.ColumnByName("val6").Visible = False
      End If

      If CODE = "15" Then
        Titre = My.Resources.Gestion_MPT_frmStatProductionAssistantsDetails_nbr_planif
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = My.Resources.Global_NAction
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = "N° DI"
        GVStat.Columns.ColumnByName("val2").Width = 80
        GVStat.Columns.ColumnByName("val2").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val3").Caption = My.Resources.Global_date_planification
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = My.Resources.Global_CLient
        GVStat.Columns.ColumnByName("val4").Width = 200
        GVStat.Columns.ColumnByName("val4").Visible = True
        GVStat.Columns.ColumnByName("val5").Caption = ""
        GVStat.Columns.ColumnByName("val5").Width = 0
        GVStat.Columns.ColumnByName("val5").Visible = False
        GVStat.Columns.ColumnByName("val6").Caption = ""
        GVStat.Columns.ColumnByName("val6").Width = 0
        GVStat.Columns.ColumnByName("val6").Visible = False
      End If

      If CODE = "16" Then
        Titre = My.Resources.Gestion_MPT_frmStatProductionAssistantsDetails_nbr_validation
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = My.Resources.Global_NAction
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = "N° DI"
        GVStat.Columns.ColumnByName("val2").Width = 80
        GVStat.Columns.ColumnByName("val3").Caption = My.Resources.Global_date_exécution
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = My.Resources.Global_CLient
        GVStat.Columns.ColumnByName("val4").Width = 200
        GVStat.Columns.ColumnByName("val4").Visible = True
        GVStat.Columns.ColumnByName("val5").Caption = ""
        GVStat.Columns.ColumnByName("val5").Width = 0
        GVStat.Columns.ColumnByName("val5").Visible = False
        GVStat.Columns.ColumnByName("val6").Caption = ""
        GVStat.Columns.ColumnByName("val6").Width = 0
        GVStat.Columns.ColumnByName("val6").Visible = False
      End If

      If CODE = "17" Then
        Titre = My.Resources.Gestion_MPT_frmStatProductionAssistantsDetails_nbr_retours
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = My.Resources.Global_NAction
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = "N° DI"
        GVStat.Columns.ColumnByName("val2").Width = 80
        GVStat.Columns.ColumnByName("val2").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val3").Caption = My.Resources.Global_date_arrivée
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = My.Resources.Global_date_exécution
        GVStat.Columns.ColumnByName("val4").Width = 90
        GVStat.Columns.ColumnByName("val4").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val5").Caption = My.Resources.Global_date_reception
        GVStat.Columns.ColumnByName("val5").Width = 90
        GVStat.Columns.ColumnByName("val5").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val6").Caption = My.Resources.Global_CLient
        GVStat.Columns.ColumnByName("val6").Width = 200
        GVStat.Columns.ColumnByName("val6").Visible = True
      End If

      If CODE = "18" Then
        Titre = My.Resources.Gestion_MPT_frmStatProductionAssistantsDetails_nbr_ordre_mission
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = "N° OM"
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = "N° DI"
        GVStat.Columns.ColumnByName("val2").Width = 80
        GVStat.Columns.ColumnByName("val2").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val3").Caption = My.Resources.Global_desc_action
        GVStat.Columns.ColumnByName("val3").Width = 400
        GVStat.Columns.ColumnByName("val4").Caption = My.Resources.Global_date_creation
        GVStat.Columns.ColumnByName("val4").Width = 90
        GVStat.Columns.ColumnByName("val4").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val5").Caption = My.Resources.Global_CLient
        GVStat.Columns.ColumnByName("val5").Width = 90
        GVStat.Columns.ColumnByName("val5").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val6").Caption = ""
        GVStat.Columns.ColumnByName("val6").Width = 0
        GVStat.Columns.ColumnByName("val6").Visible = False
      End If

      If CODE = "19" Then
        Titre = My.Resources.Gestion_MPT_frmStatProductionAssistantsDetails_nbr_arrivés
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = "N° DI"
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = My.Resources.Global_desc_action
        GVStat.Columns.ColumnByName("val2").Width = 400
        GVStat.Columns.ColumnByName("val3").Caption = My.Resources.Global_date_arrivée
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = My.Resources.Global_CLient
        GVStat.Columns.ColumnByName("val4").Width = 200
        GVStat.Columns.ColumnByName("val4").Visible = True
        GVStat.Columns.ColumnByName("val4").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val5").Caption = ""
        GVStat.Columns.ColumnByName("val5").Width = 0
        GVStat.Columns.ColumnByName("val5").Visible = False
        GVStat.Columns.ColumnByName("val5").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val6").Caption = ""
        GVStat.Columns.ColumnByName("val6").Width = 0
        GVStat.Columns.ColumnByName("val6").Visible = False
      End If

      If CODE = "20" Then
        Titre = "Liste des factures"
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = "N° Facture"
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = "Client"
        GVStat.Columns.ColumnByName("val2").Width = 200
        GVStat.Columns.ColumnByName("val3").Caption = "Date Facture"
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = "Montant HT"
        GVStat.Columns.ColumnByName("val4").Width = 200
        GVStat.Columns.ColumnByName("val4").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GVStat.Columns.ColumnByName("val5").Caption = ""
        GVStat.Columns.ColumnByName("val5").Width = 0
        GVStat.Columns.ColumnByName("val5").Visible = False
        GVStat.Columns.ColumnByName("val5").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val6").Caption = ""
        GVStat.Columns.ColumnByName("val6").Width = 0
        GVStat.Columns.ColumnByName("val6").Visible = False
      End If

      If CODE = "21" Then
        Titre = "Liste des chiffrages"
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = "N° chiffrage"
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = "Client"
        GVStat.Columns.ColumnByName("val2").Width = 200
        GVStat.Columns.ColumnByName("val3").Caption = "Date Chiffrage"
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = "Montant HT"
        GVStat.Columns.ColumnByName("val4").Width = 200
        GVStat.Columns.ColumnByName("val4").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GVStat.Columns.ColumnByName("val5").Caption = ""
        GVStat.Columns.ColumnByName("val5").Width = 0
        GVStat.Columns.ColumnByName("val5").Visible = False
        GVStat.Columns.ColumnByName("val5").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val6").Caption = ""
        GVStat.Columns.ColumnByName("val6").Width = 0
        GVStat.Columns.ColumnByName("val6").Visible = False
      End If

      If CODE = "22" Then
        Titre = "Liste des enquêtes qualités"
        GCStat.Width = 970
        GVStat.Columns.ColumnByName("val1").Caption = "N° DI"
        GVStat.Columns.ColumnByName("val1").Width = 80
        GVStat.Columns.ColumnByName("val1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val2").Caption = "Client"
        GVStat.Columns.ColumnByName("val2").Width = 200
        GVStat.Columns.ColumnByName("val3").Caption = "Site"
        GVStat.Columns.ColumnByName("val3").Width = 90
        GVStat.Columns.ColumnByName("val3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val4").Caption = "Date exécution"
        GVStat.Columns.ColumnByName("val4").Width = 200
        GVStat.Columns.ColumnByName("val4").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GVStat.Columns.ColumnByName("val5").Caption = "Date saisie"
        GVStat.Columns.ColumnByName("val5").Width = 200
        GVStat.Columns.ColumnByName("val5").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GVStat.Columns.ColumnByName("val6").Caption = "Remarques"
        GVStat.Columns.ColumnByName("val6").Width = 200
      End If

      LabelTitre.Text = Titre

    Catch ex As Exception
      MessageBox.Show("Sub frmStatProductionAssistantsDetails.Load() frmStatProductionAssistantsDetails : " + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\ExportProductionAssistantDetails_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCStat.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub GVStat_EndSorting(sender As Object, e As System.EventArgs) Handles GVStat.EndSorting
    GVStat.MoveFirst()
  End Sub
End Class