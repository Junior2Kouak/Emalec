Imports System.Data.SqlClient
Imports MozartLib

Public Class frmQCMAnalyseResult_ListeTechByQREP

  Dim _NIDQUESTION As Int32
  Dim _sTypeReponse As Int32 '0: réponse ok ; 1: réponse incorrecte ; 2 : sans réponse

  Dim DsGridMaster As DataSet
  Dim dtMaster As DataTable
  Dim DtDetailRepByTech As DataTable

  Public Sub New(ByVal c_sTypeReponse As Int32, ByVal c_NIDQUESTION As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NIDQUESTION = c_NIDQUESTION
    _sTypeReponse = c_sTypeReponse

  End Sub

  Private Sub frmQCMAnalyseResult_ListeTechByQREP_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    'init
    Select Case _sTypeReponse
      Case 0 : Me.Text = "Détail des personnes ayant répondues correctement"
      Case 1
        Me.Text = "Détail des personnes avec des réponses incorrectes"

      Case 2 : Me.Text = "Détail des personnes n'ayant pas répondues à cette question"
    End Select
    LblTitre.Text = Me.Text
    LoadData()

  End Sub

  Private Sub LoadData()

    DsGridMaster = New DataSet

    Dim sqlcmdLoader As SqlCommand

    Select Case _sTypeReponse
      Case 0

        'MASTER
        sqlcmdLoader = New SqlCommand("[api_sp_QCM_AnalyseResult_DetailListeTechQ_OK]", MozartDatabase.cnxMozart)
        sqlcmdLoader.CommandType = CommandType.StoredProcedure
                sqlcmdLoader.Parameters.Add("@P_NIDQUESTION", SqlDbType.Int).Value = _NIDQUESTION
                dtMaster = New DataTable

                dtMaster.Load(sqlcmdLoader.ExecuteReader)

                dtMaster.TableName = "TGRIDPER"

                'DETAIL
                DtDetailRepByTech = New DataTable

        sqlcmdLoader = New SqlCommand("[api_sp_QCM_AnalyseResult_DetailListeReponse_OK_TechQ]", MozartDatabase.cnxMozart)
        sqlcmdLoader.CommandType = CommandType.StoredProcedure
                sqlcmdLoader.Parameters.Add("@P_NIDQUESTION", SqlDbType.Int).Value = _NIDQUESTION

                DtDetailRepByTech.Load(sqlcmdLoader.ExecuteReader)

            Case 1

        'MASTER
        sqlcmdLoader = New SqlCommand("[api_sp_QCM_AnalyseResult_DetailListeTechQ_Err]", MozartDatabase.cnxMozart)
        sqlcmdLoader.CommandType = CommandType.StoredProcedure
                sqlcmdLoader.Parameters.Add("@P_NIDQUESTION", SqlDbType.Int).Value = _NIDQUESTION
                dtMaster = New DataTable

                dtMaster.Load(sqlcmdLoader.ExecuteReader)

                dtMaster.TableName = "TGRIDPER"

                'DETAIL
                DtDetailRepByTech = New DataTable

        sqlcmdLoader = New SqlCommand("[api_sp_QCM_AnalyseResult_DetailListeReponse_Err_TechQ]", MozartDatabase.cnxMozart)
        sqlcmdLoader.CommandType = CommandType.StoredProcedure
                sqlcmdLoader.Parameters.Add("@P_NIDQUESTION", SqlDbType.Int).Value = _NIDQUESTION

                DtDetailRepByTech.Load(sqlcmdLoader.ExecuteReader)

            Case 2

        'MASTER
        sqlcmdLoader = New SqlCommand("[api_sp_QCM_AnalyseResult_DetailListeTechQ_NoRep]", MozartDatabase.cnxMozart)
        sqlcmdLoader.CommandType = CommandType.StoredProcedure
                sqlcmdLoader.Parameters.Add("@P_NIDQUESTION", SqlDbType.Int).Value = _NIDQUESTION
                dtMaster = New DataTable

                dtMaster.Load(sqlcmdLoader.ExecuteReader)

                dtMaster.TableName = "TGRIDPER"

                'DETAIL
                DtDetailRepByTech = New DataTable

        sqlcmdLoader = New SqlCommand("[api_sp_QCM_AnalyseResult_DetailListeReponse_NoRep_TechQ]", MozartDatabase.cnxMozart)
        sqlcmdLoader.CommandType = CommandType.StoredProcedure
                sqlcmdLoader.Parameters.Add("@P_NIDQUESTION", SqlDbType.Int).Value = _NIDQUESTION

                DtDetailRepByTech.Load(sqlcmdLoader.ExecuteReader)

        End Select

        DtDetailRepByTech.TableName = "TGRIDREP"

        DsGridMaster.Tables.Add(dtMaster)
        DsGridMaster.Tables.Add(DtDetailRepByTech)


        'crete relation
        Dim parentColumns(0) As DataColumn
        Dim childColumns(0) As DataColumn

        parentColumns(0) = DsGridMaster.Tables("TGRIDPER").Columns("NIDFICQCM")
        childColumns(0) = DsGridMaster.Tables("TGRIDREP").Columns("NIDFICQCM")

        ' Create DataRelation.
        Dim CustOrderRel As DataRelation = New DataRelation("DR_NIDFICQCM", parentColumns, childColumns)

        ' Add the relation to the DataSet.
        DsGridMaster.Relations.Add(CustOrderRel)

        GCListeTechByQuest.DataSource = DsGridMaster.Tables("TGRIDPER")

        'relation entre les  grid
        GCListeTechByQuest.LevelTree.Nodes(0).RelationName = "DR_NIDFICQCM"

        GCListeTechByQuest.MainView = GVListeTechByQuest
        GCListeTechByQuest.LevelTree.Nodes(0).LevelTemplate = GVListeRepByTechQ
        GCListeTechByQuest.ForceInitialize()

        'init de gvdetail
        Select Case _sTypeReponse
            Case 0 : GVListeRepByTechQ.ViewCaption = "Réponses correctes"
            Case 1 : GVListeRepByTechQ.ViewCaption = "Réponses incorrectes"
            Case 2 : GVListeRepByTechQ.ViewCaption = "Sans réponses"


        End Select


    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub
End Class