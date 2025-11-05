Imports System.Data.SqlClient
Imports MozartLib

Public Class CPROSPDOCINT

  Dim iNPROSNUM As Int32
  'Dim oSqlConnect As New CGestionSQL 
  Dim dtProspDocInterne As DataTable

  Dim sProspectNom As String

  Public Sub New(ByVal c_iNPROSNUM As Int32)

    Try

      iNPROSNUM = c_iNPROSNUM

      sProspectNom = NomProspect()

    Catch ex As Exception

      MessageBox.Show("Sub new dans CPROSPDOCINT : " + ex.Message, "Erreur")

    End Try

  End Sub

  ReadOnly Property p_sProspectNom As String
    Get
      Return sProspectNom
    End Get
  End Property

  ReadOnly Property p_dtProspDocInterne As DataTable
    Get
      Return dtProspDocInterne
    End Get
  End Property

  Private Function NomProspect() As String

    Try
      Dim sNomProspect As String

      Dim sqlcmdRecup As New SqlCommand("SELECT VPROSNOM FROM TPROSP WHERE NPROSNUM = " & iNPROSNUM, MozartDatabase.cnxMozart)

      sqlcmdRecup.CommandType = CommandType.Text

      Dim oDrRecup As SqlDataReader = sqlcmdRecup.ExecuteReader

      If oDrRecup.HasRows Then

        oDrRecup.Read()
        sNomProspect = oDrRecup.Item("VPROSNOM").ToString

      Else

        sNomProspect = ""

      End If

      oDrRecup.Close()

      Return sNomProspect

    Catch ex As Exception

      MessageBox.Show("CPROSPDOCINT dans NomProspect : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return ""

    End Try

  End Function

  Public Function ListeDocInterneProsp() As DataTable

    Try

      dtProspDocInterne = New DataTable

      Dim sqlcmdProspDocIntLst As New SqlCommand("api_sp_ProspDocInterneListe", MozartDatabase.cnxMozart)
      sqlcmdProspDocIntLst.CommandType = CommandType.StoredProcedure
      sqlcmdProspDocIntLst.Parameters.Add("@p_nprosnum", SqlDbType.Int)
      sqlcmdProspDocIntLst.Parameters("@p_nprosnum").Value = iNPROSNUM

      'akout colone pour id tmp
      Dim ColAutoInc As DataColumn = New DataColumn
      ColAutoInc.DataType = System.Type.GetType("System.Int32")
      ColAutoInc.ColumnName = "IDTMP"
      With ColAutoInc
        .AutoIncrement = True
        .AutoIncrementSeed = 0
        .AutoIncrementStep = 1
      End With

      dtProspDocInterne.Columns.Add(ColAutoInc)

      dtProspDocInterne.Load(sqlcmdProspDocIntLst.ExecuteReader)

      Return dtProspDocInterne

    Catch ex As Exception

      MessageBox.Show("CPROSPDOCINT dans LoadListeDocInterneProsp : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Public Sub CreateDocInterne()

    Try

      Dim oNewRowDocInt As DataRow = dtProspDocInterne.NewRow
      oNewRowDocInt.Item("NPROSDOCID") = 0
      oNewRowDocInt.Item("NPROSNUM") = iNPROSNUM
      Dim oFrmProspAjoutDocInt As New frmProspectAjoutDocInterne(oNewRowDocInt, dtProspDocInterne)
      oFrmProspAjoutDocInt.ShowDialog()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Sub ModifDocInterne(ByVal oDRProspDocIntModif As DataRow)

    Try

      Dim oFrmProspAjoutDocInt As New frmProspectAjoutDocInterne(oDRProspDocIntModif)
      oFrmProspAjoutDocInt.ShowDialog()

    Catch ex As Exception
      MessageBox.Show("CPROSPDOCINT dans ModifDocInterne : " + ex.Message)
    End Try

  End Sub

  Public Sub SuppLineprospDocInt(ByVal p_NIDTMP As Int32)

    dtProspDocInterne.Select("IDTMP=" + p_NIDTMP.ToString)(0).Delete()

  End Sub

  Public Sub SaveDocInterne()

    Try

      Dim ODtSupprLine As DataTable = dtProspDocInterne.GetChanges(DataRowState.Deleted)
      If Not ODtSupprLine Is Nothing Then
        ODtSupprLine.RejectChanges()
        'suppression des lignes supprimer dans la datable
        If ODtSupprLine.Rows.Count > 0 Then
          For Each oRowsInvSupp As DataRow In ODtSupprLine.Rows
            DeleteLigneProspDocInterne(oRowsInvSupp)
          Next
        End If
      End If

      dtProspDocInterne.AcceptChanges()
      'sauvegarde des lignes inventaires
      If dtProspDocInterne.Rows.Count > 0 Then
        For Each oRowsprospDocInt As DataRow In dtProspDocInterne.Rows
          SaveLigneProspDocInterne(oRowsprospDocInt)
        Next
      End If

      ListeDocInterneProsp()

    Catch ex As Exception
      MessageBox.Show("CPROSPDOCINT dans SaveDocInterne : " + ex.Message)
    End Try

  End Sub

  Private Sub SaveLigneProspDocInterne(ByVal oRowsSavTemp As DataRow)

    Try

      Dim ret_NPROSDOCID As Int32
      Dim sFileLastUpdate As String = ""

      'avant d'enregistrer le fichier on recupére le filename avant modification
      If oRowsSavTemp.Item("NPROSDOCID") <> 0 Then

        sFileLastUpdate = NewFileNameSRC(oRowsSavTemp.Item("NPROSDOCID"))

      End If

      Dim sqlcmdCreateLigne As New SqlCommand("api_sp_ProspDocInterneCreation", MozartDatabase.cnxMozart)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@P_NPROSDOCID", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NPROSDOCID").Value = oRowsSavTemp.Item("NPROSDOCID")
      sqlcmdCreateLigne.Parameters.Add("@P_NPROSNUM", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NPROSNUM").Value = iNPROSNUM
      sqlcmdCreateLigne.Parameters.Add("@P_VLIBDOC", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@P_VLIBDOC").Value = oRowsSavTemp.Item("VLIBDOC")
      sqlcmdCreateLigne.Parameters.Add("@P_VPATHANDFILESRC", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@P_VPATHANDFILESRC").Value = oRowsSavTemp.Item("VFILENAME")
      sqlcmdCreateLigne.Parameters.Add("@P_VFILENAMESRC", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@P_VFILENAMESRC").Value = Path.GetFileName(oRowsSavTemp.Item("VFILENAME"))

      ret_NPROSDOCID = sqlcmdCreateLigne.ExecuteScalar

      Dim sNewFileNameSRC As String = NewFileNameSRC(ret_NPROSDOCID)

      If (sFileLastUpdate <> sNewFileNameSRC And sFileLastUpdate <> oRowsSavTemp.Item("VFILENAME").ToString And oRowsSavTemp.Item("VFILENAME").ToString <> "") AndAlso oRowsSavTemp.Item("VFILENAME") <> sNewFileNameSRC Then
        CopyFileIsFinish(oRowsSavTemp.Item("VFILENAME"), sNewFileNameSRC)
        'si c'est une mise à jour cad que sFileLastUpdate <> "" alors on supprime l'ancien fichier
        If sFileLastUpdate <> "" AndAlso File.Exists(sFileLastUpdate) Then File.Delete(sFileLastUpdate)

      End If

    Catch ex As Exception
      MessageBox.Show("CPROSPDOCINT dans SaveLigneProspDocInterne : " + ex.Message)
    End Try

  End Sub

  Public Sub SuppLineProspDocInterne(ByVal p_NIDTMP As Int32)

    dtProspDocInterne.Select("IDTMP=" + p_NIDTMP.ToString)(0).Delete()

  End Sub

  Private Sub DeleteLigneProspDocInterne(ByVal oRowsSupprTemp As DataRow)

    Try

      If oRowsSupprTemp.Item("NPROSDOCID") > 0 Then

        Dim sqlcmdSupprLigne As New SqlCommand("api_sp_ProspDocInterneSuppression", MozartDatabase.cnxMozart)
        sqlcmdSupprLigne.CommandType = CommandType.StoredProcedure
        sqlcmdSupprLigne.Parameters.Add("@P_NPROSDOCID", SqlDbType.Int)
        sqlcmdSupprLigne.Parameters("@P_NPROSDOCID").Value = oRowsSupprTemp.Item("NPROSDOCID")

        sqlcmdSupprLigne.ExecuteNonQuery()

        'suppression du fichier
        If File.Exists(oRowsSupprTemp.Item("VFILENAME").ToString) Then File.Delete(oRowsSupprTemp.Item("VFILENAME").ToString)

      End If

    Catch ex As Exception
      MessageBox.Show("CPROSPDOCINT dans DeleteLigneProspDocInterne : " + ex.Message)
    End Try

  End Sub

  Private Function NewFileNameSRC(ByVal P_NPROSDOCID As Int32) As String

    Try
      Dim sNewFileNameSRC As String

      Dim sqlcmdRecup As New SqlCommand("api_sp_ProspDocInterneRecupNomFichierSRC", MozartDatabase.cnxMozart)

      sqlcmdRecup.CommandType = CommandType.StoredProcedure
      sqlcmdRecup.Parameters.Add("@P_NPROSDOCID", SqlDbType.Int)
      sqlcmdRecup.Parameters("@P_NPROSDOCID").Value = P_NPROSDOCID

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

      MessageBox.Show("CPROSPDOCINT dans NewFileNameSRC : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

      MessageBox.Show("CPROSPDOCINT dans CopyFileIsFinish : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Try


  End Sub

End Class
