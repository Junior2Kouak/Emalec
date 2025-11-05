Imports System.Data.SqlClient
Imports MozartLib

Public Class CSITDOCINT

  Dim iNSITNUM As Int32
  'Dim oSqlConnect As New CGestionSQL 
  Dim dtSiteDocInterne As DataTable

  Dim sSiteNom As String

  Public Sub New(ByVal c_iNSITNUM As Int32)

    Try

      iNSITNUM = c_iNSITNUM

      sSiteNom = NomSite()

    Catch ex As Exception

      MessageBox.Show("Sub new dans CSITDOCINT : " + ex.Message, "Erreur")

    End Try

  End Sub

  ReadOnly Property p_sSiteNom As String
    Get
      Return sSiteNom
    End Get
  End Property

  ReadOnly Property p_dtSiteDocInterne As DataTable
    Get
      Return dtSiteDocInterne
    End Get
  End Property

  Private Function NomSite() As String

    Try
      Dim sNomSite As String

      Dim sqlcmdRecup As New SqlCommand("SELECT VSITNOM FROM TSIT WHERE NSITNUM = " & iNSITNUM, MozartDatabase.cnxMozart)

      sqlcmdRecup.CommandType = CommandType.Text

      Dim oDrRecup As SqlDataReader = sqlcmdRecup.ExecuteReader

      If oDrRecup.HasRows Then

        oDrRecup.Read()
        sNomSite = oDrRecup.Item("VSITNOM").ToString

      Else

        sNomSite = ""

      End If

      oDrRecup.Close()

      Return sNomSite

    Catch ex As Exception

      MessageBox.Show("CSITDOCINT dans NomSite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return ""

    End Try

  End Function

  Public Function ListeDocInterneSite() As DataTable

    Try

      dtSiteDocInterne = New DataTable

      Dim sqlcmdProspDocIntLst As New SqlCommand("api_sp_SiteDocInterneListe", MozartDatabase.cnxMozart)
      sqlcmdProspDocIntLst.CommandType = CommandType.StoredProcedure
      sqlcmdProspDocIntLst.Parameters.Add("@p_nsitnum", SqlDbType.Int)
      sqlcmdProspDocIntLst.Parameters("@p_nsitnum").Value = iNSITNUM

      'akout colone pour id tmp
      Dim ColAutoInc As DataColumn = New DataColumn
      ColAutoInc.DataType = System.Type.GetType("System.Int32")
      ColAutoInc.ColumnName = "IDTMP"
      With ColAutoInc
        .AutoIncrement = True
        .AutoIncrementSeed = 0
        .AutoIncrementStep = 1
      End With

      dtSiteDocInterne.Columns.Add(ColAutoInc)

      dtSiteDocInterne.Load(sqlcmdProspDocIntLst.ExecuteReader)

      Return dtSiteDocInterne

    Catch ex As Exception

      MessageBox.Show("CSITDOCINT dans ListeDocInterneSite : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Public Sub CreateDocInterne()

    Try

      Dim oNewRowDocInt As DataRow = dtSiteDocInterne.NewRow
      oNewRowDocInt.Item("NSITDOCID") = 0
      oNewRowDocInt.Item("NSITNUM") = iNSITNUM
      Dim oFrmSiteAjoutDocInt As New frmSiteAjoutDocInterne(oNewRowDocInt, dtSiteDocInterne)
      oFrmSiteAjoutDocInt.ShowDialog()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Sub ModifDocInterne(ByVal oDRProspDocIntModif As DataRow)

    Try

      Dim oFrmSiteAjoutDocInt As New frmSiteAjoutDocInterne(oDRProspDocIntModif)
      oFrmSiteAjoutDocInt.ShowDialog()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Sub SuppLineSiteDocInt(ByVal p_NIDTMP As Int32)

    dtSiteDocInterne.Select("IDTMP=" + p_NIDTMP.ToString)(0).Delete()

  End Sub

  Public Sub SaveDocInterne()

    Try

      Dim ODtSupprLine As DataTable = dtSiteDocInterne.GetChanges(DataRowState.Deleted)
      If Not ODtSupprLine Is Nothing Then
        ODtSupprLine.RejectChanges()
        'suppression des lignes supprimer dans la datable
        If ODtSupprLine.Rows.Count > 0 Then
          For Each oRowsInvSupp As DataRow In ODtSupprLine.Rows
            DeleteLigneSiteDocInterne(oRowsInvSupp)
          Next
        End If
      End If

      dtSiteDocInterne.AcceptChanges()
      'sauvegarde des lignes inventaires
      If dtSiteDocInterne.Rows.Count > 0 Then
        For Each oRowsprospDocInt As DataRow In dtSiteDocInterne.Rows
          SaveLigneSiteDocInterne(oRowsprospDocInt)
        Next
      End If

      ListeDocInterneSite()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SaveLigneSiteDocInterne(ByVal oRowsSavTemp As DataRow)

    Try

      Dim ret_NSITEDOCID As Int32
      Dim sFileLastUpdate As String = ""

      'avant d'enregistrer le fichier on recupére le filename avant modification
      If oRowsSavTemp.Item("NSITDOCID") <> 0 Then

        sFileLastUpdate = NewFileNameSRC(oRowsSavTemp.Item("NSITDOCID"))

      End If

      Dim sqlcmdCreateLigne As New SqlCommand("api_sp_SiteDocInterneCreation", MozartDatabase.cnxMozart)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@P_NSITDOCID", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NSITDOCID").Value = oRowsSavTemp.Item("NSITDOCID")
      sqlcmdCreateLigne.Parameters.Add("@P_NSITNUM", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NSITNUM").Value = iNSITNUM
      sqlcmdCreateLigne.Parameters.Add("@P_VLIBDOC", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@P_VLIBDOC").Value = oRowsSavTemp.Item("VLIBDOC")
      sqlcmdCreateLigne.Parameters.Add("@P_VPATHANDFILESRC", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@P_VPATHANDFILESRC").Value = oRowsSavTemp.Item("VFILENAME")
      sqlcmdCreateLigne.Parameters.Add("@P_VFILENAMESRC", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@P_VFILENAMESRC").Value = Path.GetFileName(oRowsSavTemp.Item("VFILENAME"))

      ret_NSITEDOCID = sqlcmdCreateLigne.ExecuteScalar

      Dim sNewFileNameSRC As String = NewFileNameSRC(ret_NSITEDOCID)

      If (sFileLastUpdate <> sNewFileNameSRC And sFileLastUpdate <> oRowsSavTemp.Item("VFILENAME").ToString And oRowsSavTemp.Item("VFILENAME").ToString <> "") AndAlso oRowsSavTemp.Item("VFILENAME") <> sNewFileNameSRC Then
        CopyFileIsFinish(oRowsSavTemp.Item("VFILENAME"), sNewFileNameSRC)
        'si c'est une mise à jour cad que sFileLastUpdate <> "" alors on supprime l'ancien fichier
        If sFileLastUpdate <> "" AndAlso File.Exists(sFileLastUpdate) Then File.Delete(sFileLastUpdate)

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Sub SuppLineSiteDocInterne(ByVal p_NIDTMP As Int32)

    dtSiteDocInterne.Select("IDTMP=" + p_NIDTMP.ToString)(0).Delete()

  End Sub

  Private Sub DeleteLigneSiteDocInterne(ByVal oRowsSupprTemp As DataRow)

    Try

      If oRowsSupprTemp.Item("NSITDOCID") > 0 Then

        Dim sqlcmdSupprLigne As New SqlCommand("api_sp_SiteDocInterneSuppression", MozartDatabase.cnxMozart)
        sqlcmdSupprLigne.CommandType = CommandType.StoredProcedure
        sqlcmdSupprLigne.Parameters.Add("@P_NSITDOCID", SqlDbType.Int)
        sqlcmdSupprLigne.Parameters("@P_NSITDOCID").Value = oRowsSupprTemp.Item("NSITDOCID")

        sqlcmdSupprLigne.ExecuteNonQuery()

        'suppression du fichier
        If File.Exists(oRowsSupprTemp.Item("VFILENAME").ToString) Then File.Delete(oRowsSupprTemp.Item("VFILENAME").ToString)

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Function NewFileNameSRC(ByVal P_NSITDOCID As Int32) As String

    Try
      Dim sNewFileNameSRC As String

      Dim sqlcmdRecup As New SqlCommand("api_sp_SiteDocInterneRecupNomFichierSRC", MozartDatabase.cnxMozart)

      sqlcmdRecup.CommandType = CommandType.StoredProcedure
      sqlcmdRecup.Parameters.Add("@P_NSITDOCID", SqlDbType.Int)
      sqlcmdRecup.Parameters("@P_NSITDOCID").Value = P_NSITDOCID

      Dim oDrRecup As SqlDataReader = sqlcmdRecup.ExecuteReader

      If oDrRecup.HasRows Then

        oDrRecup.Read()
        sNewFileNameSRC = oDrRecup.Item("VFILENAME").ToString

      Else

        sNewFileNameSRC = ""

      End If

      oDrRecup.Close()

      Return sNewFileNameSRC

    Catch ex As Exception

      MessageBox.Show("CSITDOCINT dans NewFileNameSRC : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return ""

    End Try

  End Function

  Public Sub CopyFileIsFinish(ByVal sFileSrc As String, ByVal sFileDest As String)

    Try

      Dim bOK As Boolean = False

      If File.Exists(sFileSrc) = True Then

        File.Copy(sFileSrc, sFileDest, True)

      Else

        MessageBox.Show("Le fichier source n'existe pas !", "Erreur - Fichier introuvable", MessageBoxButtons.OK, MessageBoxIcon.Error)

      End If

    Catch ex As Exception

      MessageBox.Show("CSITDOCINT dans CopyFileIsFinish : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Try


  End Sub

End Class
