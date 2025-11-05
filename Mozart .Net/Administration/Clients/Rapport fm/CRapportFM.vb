Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Linq
Imports System.Reflection.MethodBase
Imports MozartLib

Public Class CRapportFM

  Dim _NCLINUM As Int32
  Dim _NIDRAPPORT_FM_CLI As Int32

  Dim _VCLINOM As String
  Dim _sLangue As String

  Dim _VRAPPORT_FM_TITLE As String
  Dim _VPERIODE As String
  Dim _iLogoSociete As Image
  Dim _iLogoClient As Image
  Dim _iLogoGroup As Image
  Dim _iBandeauClient As Image

  Dim _bAfficheSite As Boolean

  Dim _sDateDebut_This As Date
  Dim _sDateFin_This As Date

  Dim _sDateDebut_Annee As Date

  Dim _sDateDebut_12M As Date
  Dim _sDateFin_12M As Date

  Dim _VCHAP_MSG As String

  Dim _DtRapport_FM_Requetes As DataTable
  Dim _DtRapport_FM_All_Requetes_Coche As DataTable
  Dim _DtRapport_FM_DelaiByUrg As DataTable

  Dim _DtCboOrder As DataTable
  Dim _DtCboRapport_FM_Requetes As DataTable
  Dim _DtCboContrat As DataTable

  Public Sub New(ByVal c_NCLINUM As Int32, ByVal c_NIDRAPPORT_FM_CLI As Int32)

    _NCLINUM = c_NCLINUM
    _NIDRAPPORT_FM_CLI = c_NIDRAPPORT_FM_CLI

    Loaddata()

  End Sub
  Public ReadOnly Property NIDRAPPORT_FM_CLI As Int32
    Get
      Return _NIDRAPPORT_FM_CLI
    End Get
  End Property

  Public ReadOnly Property NCLINUM As Int32
    Get
      Return _NCLINUM
    End Get
  End Property

  Public ReadOnly Property VCLINOM As String
    Get
      Return _VCLINOM
    End Get
  End Property

  Public Property sDateDebut_This As Date
    Get
      Return _sDateDebut_This
    End Get
    Set(value As Date)
      _sDateDebut_This = value
    End Set
  End Property

  Public Property sDateFin_This As Date
    Get
      Return _sDateFin_This
    End Get
    Set(value As Date)
      _sDateFin_This = value
    End Set
  End Property

  Public Property sDateDebut_Annee As Date
    Get
      Return _sDateDebut_Annee
    End Get
    Set(value As Date)
      _sDateDebut_Annee = value
    End Set
  End Property

  Public Property VCHAP_MSG As String
    Get
      Return _VCHAP_MSG
    End Get
    Set(value As String)
      _VCHAP_MSG = value
    End Set
  End Property

  Public Property bAfficheSite As Boolean
    Get
      Return _bAfficheSite
    End Get
    Set(value As Boolean)
      _bAfficheSite = value
    End Set
  End Property
  Public Property DtRapport_FM_All_Requetes_Coche As DataTable
    Get
      DtRapport_FM_All_Requetes_Coche = _DtRapport_FM_All_Requetes_Coche
    End Get
    Set(value As DataTable)
      _DtRapport_FM_All_Requetes_Coche = value
    End Set
  End Property

  Public Property DtRapport_FM_Requetes As DataTable
    Get
      DtRapport_FM_Requetes = _DtRapport_FM_Requetes
    End Get
    Set(value As DataTable)
      _DtRapport_FM_Requetes = value
    End Set
  End Property

  Public ReadOnly Property DtCboOrder As DataTable
    Get
      DtCboOrder = _DtCboOrder
    End Get
  End Property

  Public ReadOnly Property DtCboContrat As DataTable
    Get
      DtCboContrat = _DtCboContrat
    End Get
  End Property

  Public ReadOnly Property DtCboRapport_FM_Requetes As DataTable
    Get
      DtCboRapport_FM_Requetes = _DtCboRapport_FM_Requetes
    End Get
  End Property

  Public Property VRAPPORT_FM_TITLE As String
    Get
      Return _VRAPPORT_FM_TITLE
    End Get
    Set(value As String)
      _VRAPPORT_FM_TITLE = value
    End Set
  End Property

  Public ReadOnly Property VPERIODE As String
    Get
      Return _VPERIODE
    End Get
  End Property

  Public ReadOnly Property iLogoSociete As Image
    Get
      Return _iLogoSociete
    End Get
  End Property

  Public ReadOnly Property iLogoClient As Image
    Get
      Return _iLogoClient
    End Get
  End Property

  Public ReadOnly Property iLogoGroup As Image
    Get
      Return _iLogoGroup
    End Get
  End Property

  Public Property iBandeauClient As Image
    Get
      Return _iBandeauClient
    End Get
    Set(value As Image)
      _iBandeauClient = value
    End Set
  End Property

  Public Property DtRapport_FM_DelaiByUrg As DataTable
    Get
      DtRapport_FM_DelaiByUrg = _DtRapport_FM_DelaiByUrg
    End Get
    Set(value As DataTable)
      _DtRapport_FM_DelaiByUrg = value
    End Set
  End Property
  Public Property sLangue As String
    Get
      Return _sLangue
    End Get
    Set(value As String)
      _sLangue = value
    End Set
  End Property

  Public Sub Loaddata()

    'recherche des delai par urgence
    _DtRapport_FM_DelaiByUrg = New DataTable
    Dim sqlcmdLoader As New SqlCommand("[api_sp_Rapport_FM_Impression_GetUrgence_By_Client]", MozartDatabase.cnxMozart)
    sqlcmdLoader.CommandType = CommandType.StoredProcedure
        sqlcmdLoader.Parameters.Add("@P_NCLINUM", SqlDbType.Int).Value = _NCLINUM
        _DtRapport_FM_DelaiByUrg.Load(sqlcmdLoader.ExecuteReader)

        Dim dtLoadRapportFM As New DataTable

    sqlcmdLoader = New SqlCommand("[api_sp_Rapport_FM_Detail_V2]", MozartDatabase.cnxMozart)
    sqlcmdLoader.CommandType = CommandType.StoredProcedure
        sqlcmdLoader.Parameters.Add("@P_NIDRAPPORT_FM_CLI", SqlDbType.Int).Value = _NIDRAPPORT_FM_CLI
        sqlcmdLoader.Parameters.Add("@P_NCLINUM", SqlDbType.Int).Value = _NCLINUM
        dtLoadRapportFM.Load(sqlcmdLoader.ExecuteReader)

        For Each drRapportFm As DataRow In dtLoadRapportFM.Rows

            _NIDRAPPORT_FM_CLI = drRapportFm.Item("NIDRAPPORT_FM_CLI")
            _VRAPPORT_FM_TITLE = drRapportFm.Item("VRAPPORT_FM_TITRE")
            _sDateDebut_This = drRapportFm.Item("DDATEDEB")
            _sDateFin_This = drRapportFm.Item("DDATEFIN")
            _sDateDebut_Annee = drRapportFm.Item("DATE_DEBUT_ANNEE")

            _VCHAP_MSG = drRapportFm.Item("VCHAP_GENERALITES")
            _VCLINOM = drRapportFm.Item("VCLINOM")
            _sLangue = drRapportFm.Item("VLANGUE")

            _iBandeauClient = If(IsDBNull(drRapportFm.Item("IMG_GARDE")), Nothing, byteArrayToImage(drRapportFm.Item("IMG_GARDE")))

            _bAfficheSite = drRapportFm.Item("BAFFICHELSTSIT")

        Next

        _DtRapport_FM_Requetes = New DataTable
    sqlcmdLoader = New SqlCommand("[api_sp_Rapport_FM_Detail_Order]", MozartDatabase.cnxMozart)
    sqlcmdLoader.CommandType = CommandType.StoredProcedure
        sqlcmdLoader.Parameters.Add("@P_NIDRAPPORT_FM_CLI", SqlDbType.Int).Value = _NIDRAPPORT_FM_CLI

        'akout colone pour id tmp
        Dim ColAutoInc As DataColumn = New DataColumn
        ColAutoInc.DataType = System.Type.GetType("System.Int32")
        ColAutoInc.ColumnName = "IDTMP"
        With ColAutoInc
            .AutoIncrement = True
            .AutoIncrementSeed = 0
            .AutoIncrementStep = 1
        End With
        _DtRapport_FM_Requetes.Columns.Add(ColAutoInc)
        _DtRapport_FM_Requetes.Load(sqlcmdLoader.ExecuteReader)

        'si table vide alors on ajoute en auto Généralités
        If Not _DtRapport_FM_Requetes Is Nothing AndAlso _DtRapport_FM_Requetes.Rows.Count = 0 Then

      'on recupère les infos du chapitres Généralités
      Dim sqlcmdInfosGen As New SqlCommand("[api_sp_Rapport_FM_Detail_GetChapGeneralites]", MozartDatabase.cnxMozart)
      sqlcmdInfosGen.CommandType = CommandType.StoredProcedure
            Dim DtGen As New DataTable
            DtGen.Load(sqlcmdInfosGen.ExecuteReader)

            Dim DrGeneralitesAdd As DataRow = _DtRapport_FM_Requetes.NewRow

            DrGeneralitesAdd.Item("NIDRAPPORT_FM_CLI_ORDER") = 0
            DrGeneralitesAdd.Item("NIDRAPPORT_FM_CLI") = _NIDRAPPORT_FM_CLI
            DrGeneralitesAdd.Item("NORDER") = _DtRapport_FM_Requetes.Rows.Count + 1
            DrGeneralitesAdd.Item("NIDREQ_RAPPORT_FM") = DtGen.Rows(0).Item("NIDREQ_RAPPORT_FM")
            DrGeneralitesAdd.Item("VLIBCHAPITRE") = DtGen.Rows(0).Item("VLIBCHAPITRE")
            DrGeneralitesAdd.Item("VLIBDESCRIPT") = DtGen.Rows(0).Item("VLIBDESCRIPT")

            _DtRapport_FM_Requetes.Rows.Add(DrGeneralitesAdd)

        End If

        'combo order
        _DtCboOrder = New DataTable
        _DtCboOrder.Columns.Add("NORDER", Type.GetType("System.Int32"))

        Dim i As Int32

        For i = 0 To 30

            Dim DrNewOrder As DataRow = _DtCboOrder.NewRow
            DrNewOrder.Item("NORDER") = _DtCboOrder.Rows.Count + 1

            _DtCboOrder.Rows.Add(DrNewOrder)

        Next

        'combo liste des requetes
        _DtCboRapport_FM_Requetes = New DataTable

    sqlcmdLoader = New SqlCommand("[api_sp_Rapport_FM_Detail_Liste_Requetes]", MozartDatabase.cnxMozart)
    sqlcmdLoader.CommandType = CommandType.StoredProcedure
        _DtCboRapport_FM_Requetes.Load(sqlcmdLoader.ExecuteReader)

        'combo contrat
        _DtCboContrat = New DataTable

    sqlcmdLoader = New SqlCommand("[api_sp_Rapport_FM_Detail_ListeContrat]", MozartDatabase.cnxMozart)
    sqlcmdLoader.CommandType = CommandType.StoredProcedure
        sqlcmdLoader.Parameters.Add("@P_NCLINUM", SqlDbType.Int).Value = _NCLINUM
        _DtCboContrat.Load(sqlcmdLoader.ExecuteReader)

        'Champ général
        _DtRapport_FM_All_Requetes_Coche = New DataTable
    sqlcmdLoader = New SqlCommand("[api_sp_Rapport_FM_Detail_Liste_Requetes_V2]", MozartDatabase.cnxMozart)
    sqlcmdLoader.Parameters.Add("@P_NIDRAPPORT_FM_CLI", SqlDbType.Int).Value = _NIDRAPPORT_FM_CLI
        sqlcmdLoader.Parameters.Add("@P_NCLINUM", SqlDbType.Int).Value = _NCLINUM
        sqlcmdLoader.CommandType = CommandType.StoredProcedure
        _DtRapport_FM_All_Requetes_Coche.Load(sqlcmdLoader.ExecuteReader)

        _DtRapport_FM_All_Requetes_Coche.Columns("NCOCHE").ReadOnly = False
        _DtRapport_FM_All_Requetes_Coche.Columns("NORDER").ReadOnly = False
        _DtRapport_FM_All_Requetes_Coche.Columns("NORDER").AllowDBNull = True

        'load logo
        LoadLogos()

    End Sub

    Public Sub Refresh_Requetes()

        _DtRapport_FM_Requetes = _DtRapport_FM_All_Requetes_Coche.Select("[NCOCHE] = 1").CopyToDataTable

        'Dim sqlcmdLoader As SqlCommand

        '_DtRapport_FM_Requetes = New DataTable
        'sqlcmdLoader = New SqlCommand("[api_sp_Rapport_FM_Detail_Order]", cnx)
        'sqlcmdLoader.CommandType = CommandType.StoredProcedure
        'sqlcmdLoader.Parameters.Add("@P_NIDRAPPORT_FM_CLI", SqlDbType.Int).Value = _NIDRAPPORT_FM_CLI

        ''akout colone pour id tmp
        'Dim ColAutoInc As DataColumn = New DataColumn
        'ColAutoInc.DataType = System.Type.GetType("System.Int32")
        'ColAutoInc.ColumnName = "IDTMP"
        'With ColAutoInc
        '    .AutoIncrement = True
        '    .AutoIncrementSeed = 0
        '    .AutoIncrementStep = 1
        'End With
        '_DtRapport_FM_Requetes.Columns.Add(ColAutoInc)
        '_DtRapport_FM_Requetes.Load(sqlcmdLoader.ExecuteReader)

        ''si table vide alors on ajoute en auto Généralités
        'If Not _DtRapport_FM_Requetes Is Nothing AndAlso _DtRapport_FM_Requetes.Rows.Count = 0 Then

        '    'on recupère les infos du chapitres Généralités
        '    Dim sqlcmdInfosGen As New SqlCommand("[api_sp_Rapport_FM_Detail_GetChapGeneralites]", cnx)
        '    sqlcmdInfosGen.CommandType = CommandType.StoredProcedure
        '    Dim DtGen As New DataTable
        '    DtGen.Load(sqlcmdInfosGen.ExecuteReader)

        '    Dim DrGeneralitesAdd As DataRow = _DtRapport_FM_Requetes.NewRow

        '    DrGeneralitesAdd.Item("NIDRAPPORT_FM_CLI_ORDER") = 0
        '    DrGeneralitesAdd.Item("NIDRAPPORT_FM_CLI") = _NIDRAPPORT_FM_CLI
        '    DrGeneralitesAdd.Item("NORDER") = _DtRapport_FM_Requetes.Rows.Count + 1
        '    DrGeneralitesAdd.Item("NIDREQ_RAPPORT_FM") = DtGen.Rows(0).Item("NIDREQ_RAPPORT_FM")
        '    DrGeneralitesAdd.Item("VLIBCHAPITRE") = DtGen.Rows(0).Item("VLIBCHAPITRE")
        '    DrGeneralitesAdd.Item("VLIBDESCRIPT") = DtGen.Rows(0).Item("VLIBDESCRIPT")

        '    _DtRapport_FM_Requetes.Rows.Add(DrGeneralitesAdd)

        'End If

    End Sub


    Private Sub LoadLogos()

    Dim sqlcmdLogo As New SqlCommand("[api_sp_Rapport_FM_GetLogos]", MozartDatabase.cnxMozart)
    sqlcmdLogo.CommandType = CommandType.StoredProcedure
        sqlcmdLogo.Parameters.Add("@p_nclinum", SqlDbType.Int).Value = _NCLINUM
        'sqlcmdLogo.Parameters.Add("@p_venseigne", SqlDbType.VarChar).Value = 0

        Dim osqldr As SqlDataReader

        osqldr = sqlcmdLogo.ExecuteReader

        If osqldr.HasRows Then

            While osqldr.Read

                _iLogoSociete = If(File.Exists(osqldr.Item("IMG_LOGO_SOCIETE")), Image.FromFile(osqldr.Item("IMG_LOGO_SOCIETE")), Nothing)
                _iLogoClient = If(File.Exists(osqldr.Item("IMG_LOGO_CLIENT")), Image.FromFile(osqldr.Item("IMG_LOGO_CLIENT")), Nothing)
                _iLogoGroup = If(File.Exists(osqldr.Item("IMG_LOGO_GROUP")), Image.FromFile(osqldr.Item("IMG_LOGO_GROUP")), Nothing)

            End While

        End If

        osqldr.Close()

    End Sub

    Public Sub SaveRapportFM()

    Dim sqlcmdsave As New SqlCommand("[api_sp_Rapport_FM_Detail_Save_V2]", MozartDatabase.cnxMozart)
    sqlcmdsave.CommandType = CommandType.StoredProcedure
        sqlcmdsave.Parameters.Add("@P_NIDRAPPORT_FM_CLI", SqlDbType.Int).Value = _NIDRAPPORT_FM_CLI
        sqlcmdsave.Parameters("@P_NIDRAPPORT_FM_CLI").Direction = ParameterDirection.InputOutput
        sqlcmdsave.Parameters.Add("@P_NCLINUM", SqlDbType.Int).Value = _NCLINUM
        sqlcmdsave.Parameters.Add("@P_DDATEDEB", SqlDbType.DateTime).Value = _sDateDebut_This
        sqlcmdsave.Parameters.Add("@P_DDATEFIN", SqlDbType.DateTime).Value = _sDateFin_This
        sqlcmdsave.Parameters.Add("@P_VCHAP_GENERALITES", SqlDbType.VarChar).Value = _VCHAP_MSG
        sqlcmdsave.Parameters.Add("@P_LANGUE", SqlDbType.VarChar).Value = _sLangue
        sqlcmdsave.Parameters.Add("@P_IMGGARDE", SqlDbType.VarBinary).Value = If(_iBandeauClient Is Nothing, Nothing, ImageToByeArray(_iBandeauClient))
        sqlcmdsave.Parameters.Add("@P_VRAPPORT_FM_TITRE", SqlDbType.VarChar).Value = _VRAPPORT_FM_TITLE
        sqlcmdsave.Parameters.Add("@P_BAFFICHELSTSIT", SqlDbType.Bit).Value = _bAfficheSite

        sqlcmdsave.ExecuteNonQuery()

        _NIDRAPPORT_FM_CLI = sqlcmdsave.Parameters("@P_NIDRAPPORT_FM_CLI").Value

    End Sub

    Public Sub AddRequete(ByVal p_NIDREQ_RAPPORT_FM As Int32, ByVal p_VLIBCHAPITRE As String)

        Dim drNew As DataRow = _DtRapport_FM_Requetes.NewRow()

        drNew.Item("NIDRAPPORT_FM_CLI_ORDER") = 0
        drNew.Item("NIDRAPPORT_FM_CLI") = _NIDRAPPORT_FM_CLI
        drNew.Item("NORDER") = _DtRapport_FM_Requetes.Compute("MAX([NORDER])", "") + 1  '_DtRapport_FM_Requetes.Rows.Count + 1
        drNew.Item("NIDREQ_RAPPORT_FM") = p_NIDREQ_RAPPORT_FM
        drNew.Item("VLIBCHAPITRE") = p_VLIBCHAPITRE

        _DtRapport_FM_Requetes.Rows.Add(drNew)

    End Sub

    Public Sub DeleteRequete(ByVal P_IDTMP As Int32)

        _DtRapport_FM_Requetes.Select("IDTMP=" + P_IDTMP.ToString)(0).Delete()

    End Sub

    Public Sub SaveRapportFM_Requete(ByVal p_DrSave As DataRow)

    Dim sqlcmdsave As New SqlCommand("[api_sp_Rapport_FM_Detail_Order_Save]", MozartDatabase.cnxMozart)
    sqlcmdsave.CommandType = CommandType.StoredProcedure
        sqlcmdsave.Parameters.Add("@P_NIDRAPPORT_FM_CLI_ORDER", SqlDbType.Int).Value = p_DrSave.Item("NIDRAPPORT_FM_CLI_ORDER")
        sqlcmdsave.Parameters.Add("@P_NIDRAPPORT_FM_CLI", SqlDbType.Int).Value = _NIDRAPPORT_FM_CLI
        sqlcmdsave.Parameters.Add("@P_NORDER", SqlDbType.Int).Value = p_DrSave.Item("NORDER")
        sqlcmdsave.Parameters.Add("@P_NIDREQ_RAPPORT_FM", SqlDbType.Int).Value = p_DrSave.Item("NIDREQ_RAPPORT_FM")

        sqlcmdsave.ExecuteNonQuery()

    End Sub

    Public Sub DeleteRapportFM_Requete(ByVal p_DrDel As DataRow)

    Dim sqlcmdDel As New SqlCommand("[api_sp_Rapport_FM_Detail_Order_Delete]", MozartDatabase.cnxMozart)
    sqlcmdDel.CommandType = CommandType.StoredProcedure
        sqlcmdDel.Parameters.Add("@P_NIDRAPPORT_FM_CLI_ORDER", SqlDbType.Int).Value = p_DrDel.Item("NIDRAPPORT_FM_CLI_ORDER")

        sqlcmdDel.ExecuteNonQuery()

    End Sub

    Public Sub SaveRapportFM_Requetes()

        For Each DrSave As DataRow In DtRapport_FM_All_Requetes_Coche.Rows

      Dim sqlcmdSave As New SqlCommand("api_sp_Rapport_FM_Detail_Order_Save_V2", MozartDatabase.cnxMozart)
      sqlcmdSave.CommandType = CommandType.StoredProcedure
            sqlcmdSave.Parameters.Add("@P_NIDRAPPORT_FM_CLI_ORDER", SqlDbType.Int).Value = DrSave.Item("NIDRAPPORT_FM_CLI_ORDER")
            sqlcmdSave.Parameters.Add("@P_NIDRAPPORT_FM_CLI", SqlDbType.Int).Value = _NIDRAPPORT_FM_CLI ' DrSave.Item("NIDRAPPORT_FM_CLI")
            sqlcmdSave.Parameters.Add("@P_NORDER", SqlDbType.Int).Value = DrSave.Item("NORDER")
            sqlcmdSave.Parameters.Add("@P_NIDREQ_RAPPORT_FM", SqlDbType.Int).Value = DrSave.Item("NIDREQ_RAPPORT_FM")
            sqlcmdSave.Parameters.Add("@P_NCOCHE", SqlDbType.Int).Value = DrSave.Item("NCOCHE")

            sqlcmdSave.ExecuteNonQuery()

        Next

        ''Supprimer
        'Dim DtForDel As DataTable = _DtRapport_FM_Requetes.GetChanges(DataRowState.Deleted)

        'If Not DtForDel Is Nothing Then
        '    DtForDel.RejectChanges()

        '    For Each drDel As DataRow In DtForDel.Rows

        '        DeleteRapportFM_Requete(drDel)

        '    Next

        'End If

        ''nouveau, modifié
        'Dim DtForSave As DataTable = _DtRapport_FM_Requetes.GetChanges(DataRowState.Modified Or DataRowState.Added)

        'If Not DtForSave Is Nothing Then

        '    For Each drSave As DataRow In DtForSave.Rows

        '        SaveRapportFM_Requete(drSave)

        '    Next

        'End If

        '_DtRapport_FM_Requetes.AcceptChanges()

    End Sub

    Public Sub SaveRapportFM_SitesSelected(ByVal p_DT_Sites As DataTable)

        For Each DrSave As DataRow In p_DT_Sites.Rows

      Dim sqlcmdSave As New SqlCommand("[api_sp_Rapport_FM_Detail_Save_SiteSelected]", MozartDatabase.cnxMozart)
      sqlcmdSave.CommandType = CommandType.StoredProcedure
            sqlcmdSave.Parameters.Add("@P_NIDRAPPORT_FM_CLI", SqlDbType.Int).Value = _NIDRAPPORT_FM_CLI
            sqlcmdSave.Parameters.Add("@P_NSITNUM", SqlDbType.Int).Value = DrSave.Item("NSITNUM")
            sqlcmdSave.Parameters.Add("@P_NCOCHE", SqlDbType.Int).Value = DrSave.Item("NCHECK")

            sqlcmdSave.ExecuteNonQuery()

        Next

    End Sub

    Public Sub SaveRapportFM_CompteSelected(ByVal p_DT_Sites As DataTable)

        For Each DrSave As DataRow In p_DT_Sites.Rows

      Dim sqlcmdSave As New SqlCommand("[api_sp_Rapport_FM_Detail_Save_CompteSelected]", MozartDatabase.cnxMozart)
      sqlcmdSave.CommandType = CommandType.StoredProcedure
            sqlcmdSave.Parameters.Add("@P_NIDRAPPORT_FM_CLI", SqlDbType.Int).Value = _NIDRAPPORT_FM_CLI
            sqlcmdSave.Parameters.Add("@P_NCANNUM", SqlDbType.Int).Value = DrSave.Item("NCANNUM")
            sqlcmdSave.Parameters.Add("@P_NCOCHE", SqlDbType.Int).Value = DrSave.Item("NCHECK")

            sqlcmdSave.ExecuteNonQuery()

        Next

    End Sub

  Public Sub SaveRapportFM_ContratSelected(ByVal p_DT_Sites As DataTable)

    For Each DrSave As DataRow In p_DT_Sites.Rows

      Dim sqlcmdSave As New SqlCommand("api_sp_Rapport_FM_Detail_Save_ContratSelected", MozartDatabase.cnxMozart)
      sqlcmdSave.CommandType = CommandType.StoredProcedure
      sqlcmdSave.Parameters.Add("@P_NIDRAPPORT_FM_CLI", SqlDbType.Int).Value = _NIDRAPPORT_FM_CLI
      sqlcmdSave.Parameters.Add("@P_NTYPECONTRAT", SqlDbType.Int).Value = DrSave.Item("NTYPECONTRAT")
      sqlcmdSave.Parameters.Add("@P_NCOCHE", SqlDbType.Int).Value = DrSave.Item("NCHECK")

      sqlcmdSave.ExecuteNonQuery()

    Next

  End Sub

  Public Sub Refresh()

        If Not _DtRapport_FM_Requetes Is Nothing Then

            For Each dr As DataRow In _DtRapport_FM_Requetes.Rows

                If _DtCboRapport_FM_Requetes.Select("[NIDREQ_RAPPORT_FM] = " & dr.Item("NIDREQ_RAPPORT_FM")).Count > 0 Then dr.Item("VLIBDESCRIPT") = _DtCboRapport_FM_Requetes.Select("[NIDREQ_RAPPORT_FM] = " & dr.Item("NIDREQ_RAPPORT_FM"))(0).Item("VLIBDESCRIPT")

            Next

        End If

    End Sub

    Public Function ContainsDoublonOrder() As Boolean

        If Not _DtRapport_FM_Requetes Is Nothing Then


            Dim customersByCountry = From NbDoublon In _DtRapport_FM_Requetes.AsEnumerable
                                     Group NbDoublon By NORDER = NbDoublon.Field(Of Int32)("NORDER")
                                     Into Group Where Group.Count() > 1 Select NORDER = NORDER


            If customersByCountry.Count > 0 Then
                Return True
            Else
                Return False
            End If

        End If

        Return False

    End Function

    Public Function SqlCmdUpdateSend() As SqlCommand

    Dim sqlcommand As New SqlCommand("[api_sp_Rapport_FM_UpdateSend]", MozartDatabase.cnxMozart)
    sqlcommand.CommandType = CommandType.StoredProcedure
        sqlcommand.Parameters.Add("@P_NIDRAPPORT_FM_CLI", SqlDbType.Int).Value = _NIDRAPPORT_FM_CLI

        Return sqlcommand

    End Function
    Private Function byteArrayToImage(byteArrayIn As Byte()) As Image
        Dim ms As New MemoryStream(byteArrayIn)
        Dim returnImage As Image = Image.FromStream(ms)
        Return returnImage
    End Function

    Private Function ImageToByeArray(ImageSrc As Image) As Byte()
        Dim ms As New MemoryStream()
        ImageSrc.Save(ms, Drawing.Imaging.ImageFormat.Png)
        Return ms.ToArray
    End Function

End Class
