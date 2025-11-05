Imports System.Data.SqlClient
Imports MozartLib

Public Class CACT_FO_ENT_VEH

  Dim dtListeFoAllActions As DataTable
  Dim _bError As Boolean

  Public Sub New()

    'INIT
    _bError = False

  End Sub

  Public Property bError As Boolean
    Get
      bError = _bError
    End Get
    Set(value As Boolean)
      _bError = value
    End Set
  End Property

  ReadOnly Property p_dtListeFoAllActions As DataTable
    Get
      Return dtListeFoAllActions
    End Get
  End Property

  Public Function ListeFoAllActions(ByVal p_NDINNUM As Int32) As DataTable

    Try

      dtListeFoAllActions = New DataTable

      Dim sqlcmdLstQCM As New SqlCommand("api_sp_ChiffrageListeFOEntreeVehTech", MozartDatabase.cnxMozart)
      sqlcmdLstQCM.CommandType = CommandType.StoredProcedure
      sqlcmdLstQCM.Parameters.Add("@p_NDINNUM", SqlDbType.Int).Value = p_NDINNUM

      dtListeFoAllActions.Load(sqlcmdLstQCM.ExecuteReader)

      dtListeFoAllActions.Columns("NCOCHE").ReadOnly = False
      dtListeFoAllActions.Columns("NFOUVEH_IN").ReadOnly = False

      Return dtListeFoAllActions

    Catch ex As Exception

      MessageBox.Show("CACT_FO_ENT_VEH dans ListeFoAllActions : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
      _bError = True
      Return Nothing

    End Try

  End Function

  Public Sub CreateLigneRetourChantier(ByVal p_NRETNUM As Int32, ByVal p_dtrow As DataRow)

    Try

      'si nretnumnew = 0 alors erreur
      If p_NRETNUM = 0 Then MessageBox.Show("CACT_FO_ENT_VEH dans CreateLigneRetourChantier : le NRETNUM est égal à 0. Creation du retour chantier impossible.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : _bError = True : Exit Sub

      'creation des mouvements de stock et remplissage du retour chantier
      Dim oSql As New SqlCommand("api_sp_CreationRetourChantier", MozartDatabase.cnxMozart)
      oSql.CommandType = CommandType.StoredProcedure

      oSql.Parameters.Add("@nRetNum", SqlDbType.Int).Value = p_NRETNUM
      oSql.Parameters.Add("@nFouNum", SqlDbType.Int).Value = p_dtrow.Item("NFOUNUM")
      oSql.Parameters.Add("@iQte", SqlDbType.Int).Value = p_dtrow.Item("NFOUVEH_IN")
      oSql.Parameters.Add("@dRetour", SqlDbType.DateTime).Value = Now
      oSql.Parameters.Add("@vObjet", SqlDbType.VarChar).Value = "Retour chantier pour reappro vehicule tech"
      oSql.Parameters.Add("@nChaff", SqlDbType.Int).Value = p_dtrow.Item("NPERNUM_CHAFF")
      oSql.Parameters.Add("@nClient", SqlDbType.Int).Value = p_dtrow.Item("NCLINUM")
      oSql.Parameters.Add("@nActNum", SqlDbType.Int).Value = p_dtrow.Item("NACTNUM")

      oSql.ExecuteNonQuery()

    Catch ex As Exception

      MessageBox.Show("CACT_FO_ENT_VEH dans CreateLigneRetourChantier : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
      _bError = True

    End Try

  End Sub

  Public Function CreateRetourChantier() As Int32

    Try

      Dim iNRETNUM As Int32 = 0

      'on recupere le numero du retour chantier
      Dim oSql As New SqlCommand("SELECT COALESCE(MAX(NRETNUM),0) + 1 AS NRETNUMNEW FROM TSTOCKRETOUR", MozartDatabase.cnxMozart)
      oSql.CommandType = CommandType.Text
      Dim sqlreader As SqlDataReader = oSql.ExecuteReader

      Try
        If sqlreader.HasRows Then

          sqlreader.Read()
          iNRETNUM = sqlreader.Item("NRETNUMNEW")

        End If
      Catch ex As Exception
        MessageBox.Show("CACT_FO_ENT_VEH dans CreateRetourChantier : " + ex.Message)
        _bError = True
        Return 0
      Finally

        If sqlreader.IsClosed = False Then sqlreader.Close()

      End Try

      Return iNRETNUM

    Catch ex As Exception

      MessageBox.Show("CACT_FO_ENT_VEH dans CreateRetourChantier : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
      _bError = True
      Return 0

    End Try

  End Function

  Public Sub CreateSuiviEntreeStockVehTech(ByVal p_NRETNUM As Int32, ByVal p_NDDENUM As Int32, ByVal p_NACTNUM As Int32)

    Try

      'on enregistre dans TELF_FO_RET
      Dim oSql As New SqlCommand("api_sp_CreationRetourChantierToVehTech", MozartDatabase.cnxMozart)
      oSql.CommandType = CommandType.StoredProcedure

      oSql.Parameters.Add("@p_NACTNUM", SqlDbType.Int).Value = p_NACTNUM
      oSql.Parameters.Add("@p_NDDENUM_REAPPRO", SqlDbType.Int).Value = p_NDDENUM
      oSql.Parameters.Add("@p_NRETNUM", SqlDbType.Int).Value = p_NRETNUM

      oSql.ExecuteNonQuery()

    Catch ex As Exception

      MessageBox.Show("CACT_FO_ENT_VEH dans CreateSuiviEntreeStockVehTech : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
      _bError = True

    End Try

  End Sub

  Public Function CreateDIReapproTech(ByVal p_NPERNUM As Int32) As Int32

    Try

      Dim iSite As Int32 = 0
      Dim NACTNUM As Int32 = 0

      'on recherche le N° du Site Magasin
      If MozartParams.NomSociete = "EMALEC" Then
        iSite = 8974
      ElseIf MozartParams.NomSociete = "FITELEC" Then
        iSite = 81240
      ElseIf MozartParams.NomSociete = "ALC" Then
        iSite = 210306
      ElseIf MozartParams.NomSociete = "SCS" Then
        iSite = 209724
      ElseIf MozartParams.NomSociete = "EQUIPAGE" Then
        iSite = 100149
      Else
        Return 0
      End If

      'creation de la di et de l'action de la reappro
      Dim oSql As New SqlCommand("[Api_sp_CreationDIActionReapproTech]", MozartDatabase.cnxMozart)
      oSql.CommandType = CommandType.StoredProcedure

      oSql.Parameters.Add("@iTech", SqlDbType.Int).Value = p_NPERNUM
      oSql.Parameters.Add("@iSite", SqlDbType.Int).Value = iSite
      oSql.Parameters.Add("@demandeur", SqlDbType.VarChar).Value = MozartParams.NomSociete
      oSql.Parameters.Add("@vRefClient", SqlDbType.VarChar).Value = "Dde réappro MOZART"

      NACTNUM = oSql.ExecuteScalar()

      Return NACTNUM

    Catch ex As Exception

      MessageBox.Show("CACT_FO_ENT_VEH dans CreateDIReapproTech : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
      _bError = True
      Return 0

    End Try

  End Function

  Public Function CreateDemandeSortieStockReapproTech(ByVal p_NACTNUM As Int32) As Int32

    Try

      Dim NDDENUM As Int32 = 0

      'creation de la di et de l'action de la reappro
      Dim oSql As New SqlCommand("[api_sp_CreationDdeSortieStock]", MozartDatabase.cnxMozart)
      oSql.CommandType = CommandType.StoredProcedure

      oSql.Parameters.Add("@iDdeNum", SqlDbType.Int).Value = 0
      oSql.Parameters.Add("@iAction", SqlDbType.Int).Value = p_NACTNUM
      oSql.Parameters.Add("@TypeDest", SqlDbType.VarChar).Value = "Personnel"
      oSql.Parameters.Add("@vObjet", SqlDbType.VarChar).Value = "Demande de réappro technicien"
      oSql.Parameters.Add("@dLivr", SqlDbType.DateTime).Value = DateAdd(DateInterval.Day, 7, Now)
      oSql.Parameters.Add("@TypeDde", SqlDbType.VarChar).Value = "REAPPRO"
      oSql.Parameters.Add("@PrixHT", SqlDbType.Decimal).Value = 0
      oSql.Parameters.Add("@LieuLivr", SqlDbType.VarChar).Value = "Domicile"

      NDDENUM = oSql.ExecuteScalar

      Return NDDENUM

    Catch ex As Exception

      MessageBox.Show("CACT_FO_ENT_VEH dans CreateDemandeSortieStockReapproTech : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
      _bError = True
      Return 0

    End Try

  End Function

  Public Sub CreateLigneDemandeSortieStock(ByVal p_NDDENUM As Int32, ByVal p_NACTNUM As Int32, ByVal p_dtrow As DataRow)

    Try

      'si NDDENUM = 0 alors erreur
      If p_NDDENUM = 0 Then MessageBox.Show("CACT_FO_ENT_VEH dans CreateLigneDemandeSortieStock : le NDDENUM est égal à 0. Creation du retour de la ligne demande de sortie stock impossible.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : _bError = True : Exit Sub

      'creation des mouvements de stock et remplissage du retour chantier
      Dim oSql As New SqlCommand("api_sp_CreationLigneDemandeSortieStockAutomatique", MozartDatabase.cnxMozart)
      oSql.CommandType = CommandType.StoredProcedure

      oSql.Parameters.Add("@p_NACTNUM", SqlDbType.Int).Value = p_NACTNUM
      oSql.Parameters.Add("@P_VLART", SqlDbType.VarChar).Value = p_dtrow.Item("VFOUMAT")
      oSql.Parameters.Add("@p_NLARTQTE", SqlDbType.Int).Value = p_dtrow.Item("NFOUVEH_IN")
      oSql.Parameters.Add("@p_NFOUNUM", SqlDbType.Int).Value = p_dtrow.Item("NFOUNUM")
      oSql.Parameters.Add("@p_NDDENUM", SqlDbType.Int).Value = p_NDDENUM

      oSql.ExecuteNonQuery()

      'creation du bl an automatique 
      oSql = New SqlCommand("[api_sp_MajDdeStock]", MozartDatabase.cnxMozart)
      oSql.CommandType = CommandType.StoredProcedure
      oSql.Parameters.Add("@DdeNum", SqlDbType.Int).Value = p_NDDENUM
      oSql.Parameters.Add("@ActNum", SqlDbType.Int).Value = p_NACTNUM
      oSql.Parameters.Add("@TypeDde", SqlDbType.VarChar).Value = "REAPPRO"
      oSql.Parameters.Add("@Createur", SqlDbType.VarChar).Value = MozartParams.NomGroupe

      oSql.ExecuteNonQuery()

    Catch ex As Exception

      MessageBox.Show("CACT_FO_ENT_VEH dans CreateLigneDemandeSortieStock : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
      _bError = True

    End Try

  End Sub

End Class
