Imports System.Data.SqlClient
Imports MozartLib

Public Class CGTPAUDITL

  Dim oGestConnectSQL As New CGestionSQL

  Dim NGTPAUDITLID As Int32

  Dim dtBudgetEquip As DataTable

  Public Sub New(ByVal c_NGTPAUDITLID As Int32)

    Try

      'on ouvre la connexion
      oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete)

      NGTPAUDITLID = c_NGTPAUDITLID

    Catch ex As Exception

      MessageBox.Show("Sub new dans CGTPAUDIT : " + ex.Message, "Erreur")

    End Try

  End Sub

  Private Sub Dispose()

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

  '*******************************************************************************
  'Charge dans une table les données d'un equipement GTP
  '*******************************************************************************
  Public Function GTPAuditEquipementDetail() As DataTable

    Try

      Dim dtGTPAuditEquipDet As New DataTable

      Dim sqlcmdGTPAuditEquipDetail As New SqlCommand("api_sp_GTPSiteEquipDetail", oGestConnectSQL.CnxSQLOpen)
      sqlcmdGTPAuditEquipDetail.CommandType = CommandType.StoredProcedure
      sqlcmdGTPAuditEquipDetail.Parameters.Add("@p_NGTPAUDITLID", SqlDbType.Int)
      sqlcmdGTPAuditEquipDetail.Parameters("@p_NGTPAUDITLID").Value = NGTPAUDITLID

      dtGTPAuditEquipDet.Load(sqlcmdGTPAuditEquipDetail.ExecuteReader)

      Return dtGTPAuditEquipDet

    Catch ex As Exception

      MessageBox.Show("CGTPAUDITL dans GTPAuditEquipementDetail : " + ex.Message)
      Return Nothing

    End Try

  End Function

  '*******************************************************************************
  'Charge dans une table le budget de l'équipement
  '*******************************************************************************
  Public Function GTPAuditEquipementBudget() As DataTable

    Try

      dtBudgetEquip = New DataTable

      Dim sqlcmdGTPAuditEquipBugdet As New SqlCommand("api_sp_GTPAuditSiteBudget", oGestConnectSQL.CnxSQLOpen)
      sqlcmdGTPAuditEquipBugdet.CommandType = CommandType.StoredProcedure
      sqlcmdGTPAuditEquipBugdet.Parameters.Add("@p_NGTPAUDITLID", SqlDbType.Int)
      sqlcmdGTPAuditEquipBugdet.Parameters("@p_NGTPAUDITLID").Value = NGTPAUDITLID

      dtBudgetEquip.Load(sqlcmdGTPAuditEquipBugdet.ExecuteReader)

      Return dtBudgetEquip

    Catch ex As Exception

      MessageBox.Show("CGTPAUDITL dans GTPAuditEquipementBudget : " + ex.Message)
      Return Nothing

    End Try

  End Function

  '*******************************************************************************
  'Charge dans une table de référence des etats de budget
  '*******************************************************************************
  Public Function GTPAuditCboEtatGestBudg() As DataTable

    Try

      Dim dtEtatGestBud As New DataTable

      Dim sqlcmdGTPAuditEtatGestBudg As New SqlCommand("api_sp_GTPAuditListeEtatGestBudg", oGestConnectSQL.CnxSQLOpen)
      sqlcmdGTPAuditEtatGestBudg.CommandType = CommandType.StoredProcedure

      dtEtatGestBud.Load(sqlcmdGTPAuditEtatGestBudg.ExecuteReader)

      Return dtEtatGestBud

    Catch ex As Exception

      MessageBox.Show("CGTPAUDITL dans GTPAuditCboEtatGestBudg : " + ex.Message)
      Return Nothing

    End Try

  End Function

  '*******************************************************************************
  'Charge dans une table de référence des etats de budget
  '*******************************************************************************
  Public Function GTPAuditCboTypeDepense() As DataTable

    Try

      Dim dtTypeDepenses As New DataTable

      Dim sqlcmdGTPAuditTypeDepenses As New SqlCommand("api_sp_GTPAuditListeTypeDepense", oGestConnectSQL.CnxSQLOpen)
      sqlcmdGTPAuditTypeDepenses.CommandType = CommandType.StoredProcedure

      dtTypeDepenses.Load(sqlcmdGTPAuditTypeDepenses.ExecuteReader)

      Return dtTypeDepenses

    Catch ex As Exception

      MessageBox.Show("CGTPAUDITL dans GTPAuditCboTypeDepense : " + ex.Message)
      Return Nothing

    End Try

  End Function
  'a modeler
  Private Sub SaveLigneGTPAudit(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sqlcmdCreateLigne As New SqlCommand("api_sp_GTPClientCreateLigne", oGestConnectSQL.CnxSQLOpen)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@p_NGTPCLIID", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NGTPCLIID").Value = oRowsSavTemp.Item("NGTPCLIID")
      sqlcmdCreateLigne.Parameters.Add("@p_NCLINUM", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NCLINUM").Value = oRowsSavTemp.Item("NCLINUM")
      sqlcmdCreateLigne.Parameters.Add("@p_NGTPMAINID", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NGTPMAINID").Value = oRowsSavTemp.Item("NGTPMAINID")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

End Class
