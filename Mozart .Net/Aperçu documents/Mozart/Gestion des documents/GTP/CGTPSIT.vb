Imports System.Data.SqlClient
Imports MozartLib

Public Class CGTPSIT

  Dim dtGTPSite As DataTable
  Dim NSITNUM As Int32

  Dim oGestConnectSQL As New CGestionSQL

  Public Sub New()

    Try

      'on ouvre la connexion
      oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete)

    Catch ex As Exception

      MessageBox.Show("Sub new dans CGTPSIT : " + ex.Message, "Erreur")

    End Try

  End Sub

  Private Sub Dispose()

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

  ReadOnly Property p_dtGTPSite As DataTable
    Get
      Return dtGTPSite
    End Get
  End Property

  Property p_NSITNUM As Int32
    Get
      Return NSITNUM
    End Get
    Set(ByVal value As Int32)
      NSITNUM = value
    End Set
  End Property

  '*******************************************************************************
  'Charge dans une table la liste des equipemetn par site:  GTP
  '*******************************************************************************
  Public Function ListeGTPSite() As DataTable

    Try

      dtGTPSite = New DataTable

      Dim sqlcmdGTPClientLst As New SqlCommand("api_sp_GTPListeSite", oGestConnectSQL.CnxSQLOpen)
      sqlcmdGTPClientLst.CommandType = CommandType.StoredProcedure
      sqlcmdGTPClientLst.Parameters.Add("@p_nsitnum", SqlDbType.Int)
      sqlcmdGTPClientLst.Parameters("@p_nsitnum").Value = NSITNUM

      'akout colone pour id tmp
      Dim ColAutoInc As DataColumn = New DataColumn
      ColAutoInc.DataType = System.Type.GetType("System.Int32")
      ColAutoInc.ColumnName = "IDTMP"
      With ColAutoInc
        .AutoIncrement = True
        .AutoIncrementSeed = 0
        .AutoIncrementStep = 1
      End With

      dtGTPSite.Columns.Add(ColAutoInc)

      dtGTPSite.Load(sqlcmdGTPClientLst.ExecuteReader)

      Return dtGTPSite

    Catch ex As Exception

      MessageBox.Show("CGTPSIT dans ListeGTPSite : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Public Sub AddNewLineGTPSite(ByVal p_oDataRowInsert As DataRow)

    Try

      Dim NewLineDataRow As DataRow = dtGTPSite.NewRow

      NewLineDataRow("NGTPSITID") = 0
      NewLineDataRow("NSITNUM") = NSITNUM
      NewLineDataRow("NGTPMAINID") = p_oDataRowInsert("NGTPMAINID")
      NewLineDataRow("VGTPLOTNOM") = p_oDataRowInsert("VGTPLOTNOM")
      NewLineDataRow("VGTPEQUIP") = p_oDataRowInsert("VGTPEQUIP")
      NewLineDataRow("VGTPPRECIS") = p_oDataRowInsert("VGTPPRECIS")
      NewLineDataRow("VGTPUNITENOM") = p_oDataRowInsert("VGTPUNITENOM")
      NewLineDataRow("NGTPZONEID") = 0

      dtGTPSite.Rows.Add(NewLineDataRow)

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Sub SuppLineGTPSite(ByVal p_NIDTMP As Int32)

    dtGTPSite.Select("IDTMP=" + p_NIDTMP.ToString)(0).Delete()

  End Sub

  Public Sub SaveGTPSite()

    Try

      Dim ODtSupprLine As DataTable = dtGTPSite.GetChanges(DataRowState.Deleted)
      If Not ODtSupprLine Is Nothing Then
        ODtSupprLine.RejectChanges()
        'suppression des lignes supprimer dans la datable
        If ODtSupprLine.Rows.Count > 0 Then
          For Each oRowsInvSupp As DataRow In ODtSupprLine.Rows
            SupprLigneGTPSite(oRowsInvSupp)
          Next
        End If
      End If

      dtGTPSite.AcceptChanges()
      'sauvegarde des lignes
      If dtGTPSite.Rows.Count > 0 Then
        For Each oRowsInv As DataRow In dtGTPSite.Rows
          SaveLigneGTPSite(oRowsInv)
        Next
      End If

      'Création ou mise à jour du dernier AUDIT
      Dim sqlcmdGTPAudit As New SqlCommand("api_sp_GTPAuditCreate", oGestConnectSQL.CnxSQLOpen)
      sqlcmdGTPAudit.CommandType = CommandType.StoredProcedure
      sqlcmdGTPAudit.Parameters.Add("@p_NSITNUM", SqlDbType.Int)
      sqlcmdGTPAudit.Parameters("@p_NSITNUM").Value = NSITNUM
      sqlcmdGTPAudit.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SaveLigneGTPSite(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sqlcmdCreateLigne As New SqlCommand("api_sp_GTPSiteCreateLigne", oGestConnectSQL.CnxSQLOpen)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@p_NGTPSITID", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NGTPSITID").Value = oRowsSavTemp.Item("NGTPSITID")
      sqlcmdCreateLigne.Parameters.Add("@p_NGTPMAINID", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NGTPMAINID").Value = oRowsSavTemp.Item("NGTPMAINID")
      sqlcmdCreateLigne.Parameters.Add("@p_NSITNUM", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NSITNUM").Value = oRowsSavTemp.Item("NSITNUM")
      sqlcmdCreateLigne.Parameters.Add("@p_NGTPZONEID", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NGTPZONEID").Value = oRowsSavTemp.Item("NGTPZONEID")
      sqlcmdCreateLigne.Parameters.Add("@p_NGTPSITINSTANNEE", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NGTPSITINSTANNEE").Value = oRowsSavTemp.Item("NGTPSITINSTANNEE")
      sqlcmdCreateLigne.Parameters.Add("@p_NGTPSITQTE", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_NGTPSITQTE").Value = oRowsSavTemp.Item("NGTPSITQTE")
      sqlcmdCreateLigne.Parameters.Add("@p_VGTPSITOBS", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@p_VGTPSITOBS").Value = oRowsSavTemp.Item("VGTPSITOBS")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SupprLigneGTPSite(ByVal oRowsSupprTemp As DataRow)

    Try

      If oRowsSupprTemp.Item("NGTPSITID") > 0 Then

        Dim sqlcmdSupprLigne As New SqlCommand("api_sp_GTPSiteSupprLigne", oGestConnectSQL.CnxSQLOpen)
        sqlcmdSupprLigne.CommandType = CommandType.StoredProcedure
        sqlcmdSupprLigne.Parameters.Add("@P_NGTPSITID", SqlDbType.Int)
        sqlcmdSupprLigne.Parameters("@P_NGTPSITID").Value = oRowsSupprTemp.Item("NGTPSITID")

        sqlcmdSupprLigne.ExecuteNonQuery()

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Function ListeClientCbo() As DataTable

    Try

      Dim dtLstClient As New DataTable

      Dim sqlcmdGTPClientLst As New SqlCommand("SELECT NCLINUM, VCLINOM FROM TCLI WHERE VSOCIETE = APP_NAME() AND CCLIACTIF = 'O' ORDER BY VCLINOM", oGestConnectSQL.CnxSQLOpen)

      dtLstClient.Load(sqlcmdGTPClientLst.ExecuteReader)

      Return dtLstClient

    Catch ex As Exception

      MessageBox.Show("CGTPSITE dans ListeClientCbo : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Public Function ListeSiteCbo(ByVal p_NCLINUM As Int32) As DataTable

    Try

      Dim dtLstSite As New DataTable

      Dim sqlcmdGTPSiteLst As New SqlCommand("SELECT NSITNUM, VSITNOM FROM TSIT WHERE TSIT.NCLINUM = " + p_NCLINUM.ToString + "  AND CSITACTIF = 'O' ORDER BY VSITNOM", oGestConnectSQL.CnxSQLOpen)

      dtLstSite.Load(sqlcmdGTPSiteLst.ExecuteReader)

      Return dtLstSite

    Catch ex As Exception

      MessageBox.Show("CGTPSITE dans ListeSiteCbo : " + ex.Message)
      Return Nothing

    End Try

  End Function

  '*******************************************************************************
  'Charge dans une table la liste des equipement par client GTP
  '*******************************************************************************
  Public Function ListeGTPMainByClient(ByRef p_NCLINUM As Int32) As DataTable

    Try

      Dim dtGTPMainByClient As New DataTable

      Dim sqlcmdGTPMainByClient As New SqlCommand("api_sp_GTPListeMainByClient", oGestConnectSQL.CnxSQLOpen)
      sqlcmdGTPMainByClient.CommandType = CommandType.StoredProcedure
      sqlcmdGTPMainByClient.Parameters.Add("@p_NCLINUM", SqlDbType.Int)
      sqlcmdGTPMainByClient.Parameters("@p_NCLINUM").Value = p_NCLINUM

      dtGTPMainByClient.Load(sqlcmdGTPMainByClient.ExecuteReader)

      Return dtGTPMainByClient

    Catch ex As Exception

      MessageBox.Show("CGTPSIT dans ListeGTPMainByClient : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Public Function ListeZonesCbo() As DataTable

    Try

      Dim dtLstZones As New DataTable

      Dim sqlcmdGTPZonesLst As New SqlCommand("api_sp_GTPListeZoneBySite", oGestConnectSQL.CnxSQLOpen)
      sqlcmdGTPZonesLst.CommandType = CommandType.StoredProcedure
      sqlcmdGTPZonesLst.Parameters.Add("@P_NSITNUM", SqlDbType.Int)
      sqlcmdGTPZonesLst.Parameters("@P_NSITNUM").Value = NSITNUM

      dtLstZones.Load(sqlcmdGTPZonesLst.ExecuteReader)

      Return dtLstZones

    Catch ex As Exception

      MessageBox.Show("CGTPSITE dans ListeZonesCbo : " + ex.Message)
      Return Nothing

    End Try

  End Function

End Class
