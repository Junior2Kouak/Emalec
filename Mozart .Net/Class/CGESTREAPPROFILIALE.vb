Imports System.Data.SqlClient
Imports MozartLib

Public Class CGESTREAPPROFILIALE

  Private cnx_class As SqlConnection
  Private strNomSociete As String

  Private g_numaction_cmd_filiale As Int32
  Private g_numaction_cmd_EMALEC As Int32
  Private g_numDI_EMALEC As Int32
  Private g_numCom_Filiale As Int32
  Private g_numSTF_Fournisseur As Int32
  Private g_numSS_EMALEC As Int32
  Private g_numBL_EMALEC As Int32
  Private g_numSS_Filiale As Int32
  Private g_numBL_Filiale As Int32
  Private g_NPERNUM_TECH_FILIALE As Int32
  Private g_TotalHT As Decimal
  Private g_Date_Livr As String

  Private g_bError As Boolean

  Public WriteOnly Property NPERNUM_TECH_FILIALE As Int32

    Set(p_newvalue As Int32)
      g_NPERNUM_TECH_FILIALE = p_newvalue
    End Set

  End Property

  Public WriteOnly Property TotalHT As Decimal

    Set(p_newvalue As Decimal)
      g_TotalHT = p_newvalue
    End Set

  End Property

  Public WriteOnly Property Date_Livr As String

    Set(p_newvalue As String)
      g_Date_Livr = p_newvalue
    End Set

  End Property

  Public WriteOnly Property numBL_EMALEC As String

    Set(p_newvalue As String)
      g_numBL_EMALEC = p_newvalue
    End Set

  End Property

  Public Sub New(ByVal p_cnx As SqlConnection, ByVal p_strNomSociete As String)

    cnx_class = p_cnx
    strNomSociete = p_strNomSociete

  End Sub

  '-----------------------------------------------------------------------------------------------------------------

  Public Sub Init()

    g_numaction_cmd_filiale = 0
    g_numaction_cmd_EMALEC = 0
    g_numDI_EMALEC = 0
    g_numCom_Filiale = 0
    g_numSTF_Fournisseur = 0
    g_numSS_EMALEC = 0
    g_numBL_EMALEC = 0
    g_numSS_Filiale = 0
    g_numBL_Filiale = 0
    g_NPERNUM_TECH_FILIALE = 0
    g_TotalHT = 0
    g_Date_Livr = ""

    g_bError = False

  End Sub

  '**********************************************************************************************
  '
  '**********************************************************************************************
  Public Sub CreateReapproTechFilialeFromEMALECTo_ATHOME(ByVal p_cmdwebtech As Int32)

    Dim dtFO_CmdWebTEchFiliale As New DataTable

    Try

      'init
      g_bError = False

      'on teste les variables obligatoires
      If g_NPERNUM_TECH_FILIALE = 0 Then Exit Sub
      If g_Date_Livr = "" Then Exit Sub
      If g_numaction_cmd_filiale <> 0 Then Exit Sub

      'Fournisseur EMALEC
      g_numSTF_Fournisseur = 937

      'on charge la datatable des fo de la commande web tech
      Dim sqlcmdLoadFOWebCmd As New SqlCommand("[api_sp_ListeCmdWebTechFiliale]", cnx_class)
      sqlcmdLoadFOWebCmd.CommandType = CommandType.StoredProcedure
      sqlcmdLoadFOWebCmd.Parameters.Add("@P_NCMDWEBNUM", SqlDbType.Int).Value = p_cmdwebtech

      dtFO_CmdWebTEchFiliale.Load(sqlcmdLoadFOWebCmd.ExecuteReader)

      If dtFO_CmdWebTEchFiliale.Rows.Count = 0 Then MsgBox("§Pas d'article(s) dans la liste des articles en préparation de commande§") : Exit Sub

      'on créer la commande sur mozart Filiale
      For Each dtrowFOWebcmd As DataRow In dtFO_CmdWebTEchFiliale.Rows

        CreateCmdOnFiliale(dtrowFOWebcmd, g_numSTF_Fournisseur)  ' fournisseur Emalec

      Next

      'on enregistre le n° de l action avec le N° de la commande web tech
      UpdateNACTNUM_On_DdeReapproWeb(g_numaction_cmd_filiale, p_cmdwebtech)

      'on créait une di + action + ss sur mozart EMALEC pour le technicien filiale
      CreateDIActionForSS_EMALEC_To_Tech_Filiale()

      'on enregistre la commande et la ss emalec pour etablir une liaison
      CreateLiaisonCmd_Filiale_And_EMALEC()

    Catch ex As Exception



    End Try

  End Sub

  Public Sub CreateReapproTechFilialeFromEMALECTo_SiegeFiliale(ByVal p_cmdwebtech As Int32)

    Dim dtFO_CmdWebTEchFiliale As New DataTable

    Try

      'init
      g_bError = False

      'on teste les variables obligatoires
      If g_NPERNUM_TECH_FILIALE = 0 Then Exit Sub
      If g_Date_Livr = "" Then Exit Sub
      If g_numaction_cmd_filiale <> 0 Then Exit Sub

      'Fournisseur EMALEC
      g_numSTF_Fournisseur = 937

      'on charge la datatable des fo de la commande web tech
      Dim sqlcmdLoadFOWebCmd As New SqlCommand("[api_sp_ListeCmdWebTechFiliale]", cnx_class)
      sqlcmdLoadFOWebCmd.CommandType = CommandType.StoredProcedure
      sqlcmdLoadFOWebCmd.Parameters.Add("@P_NCMDWEBNUM", SqlDbType.Int).Value = p_cmdwebtech

      dtFO_CmdWebTEchFiliale.Load(sqlcmdLoadFOWebCmd.ExecuteReader)

      If dtFO_CmdWebTEchFiliale.Rows.Count = 0 Then MsgBox("§Pas d'article(s) dans la liste des articles en préparation de commande§") : Exit Sub

      'on créer la commande sur mozart Filiale
      For Each dtrowFOWebcmd As DataRow In dtFO_CmdWebTEchFiliale.Rows

        CreateCmdOnFiliale(dtrowFOWebcmd, g_numSTF_Fournisseur)  ' fournisseur Emalec

      Next

      'on enregistre le n° de l action avec le N° de la commande web tech
      UpdateNACTNUM_On_DdeReapproWeb(g_numaction_cmd_filiale, p_cmdwebtech)

      'on créait une di + action + ss sur mozart EMALEC pour le technicien filiale
      CreateDIActionForSS_EMALEC_To_Siege_Filiale()

      'on enregistre la commande et la ss emalec pour etablir une liaison
      CreateLiaisonCmd_Filiale_And_EMALEC()

    Catch ex As Exception



    End Try

  End Sub

  Private Sub UpdateNACTNUM_On_DdeReapproWeb(ByVal p_numaction_cmd_filiale As Int32, ByVal p_cmdwebtech As Int32)

    '********************************************************************************************
    ' Mise a jour du numero d'action sur la commande web
    Dim sqlcmd As New SqlCommand("UPDATE TCMDWEBTECH SET NACTNUM = " & p_numaction_cmd_filiale & " WHERE NCMDWEBNUM= " & p_cmdwebtech, MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
        sqlcmd.ExecuteNonQuery()

    End Sub


    '**********************************************************************************************
    '
    '**********************************************************************************************
    Private Sub CreateCmdOnFiliale(ByVal p_dtrowFOWebcmd As DataRow, ByVal numstf As Int32)

        Dim sql_cmd As SqlCommand
        Dim sql_cmd_Societe As SqlCommand
        Dim sql_dt_Societe As DataTable

        Try

        Catch ex As Exception

        End Try

        ' creation d'une DI et d'une action pour chaque commande
        If g_numCom_Filiale = 0 Then
            'c'est une nouvelle commande, donc il faut une nouvelle action
            g_numaction_cmd_filiale = CreationDIcmd_ReapproTechFiliale(995)
        End If

        ' on recherche les donnees de la societe correspondant au nom de la base utilisée
        sql_cmd_Societe = New SqlCommand("api_sp_GetInfosSociete", cnx_class)
        sql_cmd_Societe.CommandType = CommandType.StoredProcedure
        sql_cmd_Societe.Parameters.Add("@iAction", SqlDbType.Int).Value = g_numaction_cmd_filiale
        sql_dt_Societe = New DataTable
        sql_dt_Societe.Load(sql_cmd_Societe.ExecuteReader())

        If sql_dt_Societe.Rows.Count = 0 Then
            'MsgBox("§Les coordonnées du demandeur (§" & gstrNomSociete & "§) n'ont pas pu être remontées!§")
            Exit Sub
        End If

        ' création d'une commande
        sql_cmd = New SqlCommand("api_sp_CreationCommande", cnx_class)
        sql_cmd.CommandType = CommandType.StoredProcedure

        ' liste des paramètres
        sql_cmd.Parameters.Add("@iNumCommande", SqlDbType.Int).Value = g_numCom_Filiale
        sql_cmd.Parameters.Add("@iNumFour", SqlDbType.Int).Value = numstf
        sql_cmd.Parameters.Add("@iAction", SqlDbType.Int).Value = g_numaction_cmd_filiale
        sql_cmd.Parameters.Add("@nPrixHT", SqlDbType.Decimal).Value = 0  'ce champ est devenu obsolete
        sql_cmd.Parameters.Add("@nPrixTVA", SqlDbType.Decimal).Value = 20                        'txtTVA  ' n'est pas utilisée dans la proc stock
        sql_cmd.Parameters.Add("@dDateLiv", SqlDbType.DateTime).Value = DateAdd("d", 5, Now)       'txtDateLiv
        sql_cmd.Parameters.Add("@typeL", SqlDbType.Char).Value = "E"                            'Chr(cboType.ItemData(cboType.ListIndex))


        sql_cmd.Parameters.Add("@adresse1", SqlDbType.VarChar).Value = Left(sql_dt_Societe.Rows(0).Item("VSITAD1"), 50)        'Left(txtFields(0), 50)
        sql_cmd.Parameters.Add("@adresse2", SqlDbType.VarChar).Value = Left(sql_dt_Societe.Rows(0).Item("VSITAD2"), 50)         'Left(txtFields(1), 50)
        sql_cmd.Parameters.Add("@cp", SqlDbType.VarChar).Value = sql_dt_Societe.Rows(0).Item("VSITCP")                'txtFields(2)
        sql_cmd.Parameters.Add("@ville", SqlDbType.VarChar).Value = sql_dt_Societe.Rows(0).Item("VSITVIL")            'txtFields(3)
        sql_cmd.Parameters.Add("@aattention", SqlDbType.VarChar).Value = sql_dt_Societe.Rows(0).Item("VRESPSTOCK")                     'GetDestCommandeSociete(numstf)
        sql_cmd.Parameters.Add("@lieulivr", SqlDbType.VarChar).Value = strNomSociete 'gstrNomSociete                       'txtLivr

        sql_cmd.Parameters.Add("@numArticle", SqlDbType.Int).Value = p_dtrowFOWebcmd.Item("NFOUNUM")
        sql_cmd.Parameters.Add("@qte", SqlDbType.Int).Value = p_dtrowFOWebcmd.Item("NCMDQTE")
        sql_cmd.Parameters.Add("@pu", SqlDbType.Decimal).Value = If(numstf = 0, p_dtrowFOWebcmd.Item("FPUHT"), 1.05 * p_dtrowFOWebcmd.Item("FPUHT")) ' coeff 1.05 pour les copmmandes a Emalec
        sql_cmd.Parameters.Add("@pt", SqlDbType.Decimal).Value = If(numstf = 0, p_dtrowFOWebcmd.Item("FPUHT") * p_dtrowFOWebcmd.Item("NCMDQTE"), 1.05 * p_dtrowFOWebcmd.Item("FPUHT") * p_dtrowFOWebcmd.Item("NCMDQTE"))
        sql_cmd.Parameters.Add("@dDatePlanif", SqlDbType.DateTime).Value = Nothing

        Dim ValRet As New SqlParameter("@iNumCommande", SqlDbType.Int)
        ValRet.Direction = ParameterDirection.ReturnValue
        sql_cmd.Parameters.Add(ValRet)

        ' récupération du numéro crée
        sql_cmd.ExecuteNonQuery()

        g_numCom_Filiale = ValRet.Value

        ' libération de la commande
        sql_cmd = Nothing

    End Sub

    '**********************************************************************************************
    '
    '**********************************************************************************************
    Private Function CreationDIcmd_ReapproTechFiliale(ByVal p_cte As Int32) As Int32

        Dim sql_cmd As New SqlCommand("Api_sp_CreationDIActionReapproTechnicien", cnx_class)
        Dim iSite As Int32

        CreationDIcmd_ReapproTechFiliale = 0

        '********************************************************************************************
        sql_cmd.CommandType = CommandType.StoredProcedure

        ' liste des paramètres
        ' Changer les compteurs et traiter le cas des autres sociétés
        Select Case strNomSociete.ToUpper()
            Case "EMALEC"
                iSite = 8974
            Case "FITELEC"
                iSite = 81240
            Case "SCS"
                iSite = 209724
            Case "ALC"
                iSite = 210306
            Case "EQUIPAGE"
                iSite = 100149
            Case "EMALECIDF"
                iSite = 336616  'siège emalec idf
            Case "EMALECFACILITEAM"
                iSite = 381989
            Case "EMALECLUXEMBOURG"
                iSite = 381990
            Case Else
                CreationDIcmd_ReapproTechFiliale = 0
                Exit Function
        End Select

        sql_cmd.Parameters.Add("@iSite", SqlDbType.Int).Value = iSite ' magasin filiale

        sql_cmd.Parameters.Add("@Demandeur", SqlDbType.VarChar).Value = strNomSociete
        sql_cmd.Parameters.Add("@vRefClient", SqlDbType.VarChar).Value = "Réappro Fournisseur EMALEC directement au Technicien " & strNomSociete
        sql_cmd.Parameters.Add("@vCte", SqlDbType.Int).Value = p_cte ' 995 ou 993
        sql_cmd.Parameters.Add("@npernum_tech_filiale", SqlDbType.Int).Value = g_NPERNUM_TECH_FILIALE

        Dim ValRet As New SqlParameter("@return_status", SqlDbType.Int)
        ValRet.Direction = ParameterDirection.ReturnValue

        sql_cmd.Parameters.Add(ValRet)

        ' récupération du numéro crée et execution
        sql_cmd.ExecuteNonQuery()

        ' libération de la commande
        sql_cmd = Nothing

        Return ValRet.Value

    End Function

    Public Function GetDestCommandeSociete(ByVal p_inumstf As Int32) As String

        Select Case p_inumstf

            Case 937 'A EMALEC

                Return "Benjamin THET"

            Case 9137 'A SCS

                Return "Thomas BAUX"

            Case 252 'A EQUIPAGE

                Return "Stéphane LESCOP"

            Case 35576 'A EMALEC BELGIQUE

                Return "Julien SAUER"

            Case 12029 'A MAGESTIME

                Return "Benjamin THET"

            Case Else

                Return "Benjamin THET"

        End Select

    End Function

    Private Sub CreateDIActionForSS_EMALEC_To_Tech_Filiale()

        'Api_sp_CreationDIActionCmdEmalec
        Dim sql_cmd As New SqlCommand("Api_sp_CreationDIActionCmdEmalecToTech", cnx_class)

        '********************************************************************************************
        ' création d'une DI est d'une action de fournitures web
        sql_cmd.CommandType = CommandType.StoredProcedure

        sql_cmd.Parameters.Add("@iNumCom", SqlDbType.Int).Value = g_numCom_Filiale
        sql_cmd.Parameters.Add("@npernum_tech", SqlDbType.Int).Value = g_NPERNUM_TECH_FILIALE

        ' exécuter la commande.
        g_numSS_EMALEC = Convert.ToInt32(sql_cmd.ExecuteScalar())

        ' libération de la commande
        sql_cmd = Nothing

    End Sub

    Private Sub CreateDIActionForSS_EMALEC_To_Siege_Filiale()

        'Api_sp_CreationDIActionCmdEmalec
        Dim sql_cmd As New SqlCommand("Api_sp_CreationDIActionCmdEmalec", cnx_class)

        '********************************************************************************************
        ' création d'une DI est d'une action de fournitures web
        sql_cmd.CommandType = CommandType.StoredProcedure

        sql_cmd.Parameters.Add("@iNumCom", SqlDbType.Int).Value = g_numCom_Filiale
        'sql_cmd.Parameters.Add("@bCmdToSiteClient", SqlDbType.Bit).Value = 0

        ' exécuter la commande.
        g_numSS_EMALEC = Convert.ToInt32(sql_cmd.ExecuteScalar())

        ' libération de la commande
        sql_cmd = Nothing

    End Sub

    Private Sub CreateLiaisonCmd_Filiale_And_EMALEC()

        Dim sqlcmd As New SqlCommand("api_sp_CreateLiaisonFilialeToEMALEC", cnx_class)
        sqlcmd.CommandType = CommandType.StoredProcedure

        sqlcmd.Parameters.Add("@p_nconum_filiale", SqlDbType.Int).Value = g_numCom_Filiale
        sqlcmd.Parameters.Add("@p_nddenum_emalec", SqlDbType.Int).Value = g_numSS_EMALEC

        ' exécuter la commande.
        sqlcmd.ExecuteNonQuery()

        ' libération de la commande
        sqlcmd = Nothing

    End Sub

End Class
