Imports System.Data.SqlClient
Imports MozartLib

Public Class CDocSTFCondCom

  Dim iNSTFGRPNUM As Int32
  'Dim oSqlConnect As New CGestionSQL 
  Dim dtSTFGRPDocCondCom As DataTable

  Dim sSTFGRPNom As String

  Public Sub New(ByVal c_iNSTFGRPNUM As Int32)

    Try

      iNSTFGRPNUM = c_iNSTFGRPNUM

      sSTFGRPNom = NomSTFGRP()

    Catch ex As Exception

      MessageBox.Show("Sub new dans CDocSTFCondCom : " + ex.Message, "Erreur")

    End Try

  End Sub

  ReadOnly Property p_sSTFGRPNom As String
    Get
      Return sSTFGRPNom
    End Get
  End Property

  ReadOnly Property p_dtSTFGRPDocCondCom As DataTable
    Get
      Return dtSTFGRPDocCondCom
    End Get
  End Property

  Private Function NomSTFGRP() As String

    Try

      Dim sSTFGRPNom As String

      Dim sqlcmdRecup As New SqlCommand("SELECT VSTFGRPNOM FROM TSTFGRP WITH (NOLOCK) WHERE NSTFGRPNUM = " & iNSTFGRPNUM.ToString, MozartDatabase.cnxMozart)

      sqlcmdRecup.CommandType = CommandType.Text

      Dim oDrRecup As SqlDataReader = sqlcmdRecup.ExecuteReader

      If oDrRecup.HasRows Then

        oDrRecup.Read()
        sSTFGRPNom = oDrRecup.Item("VSTFGRPNOM").ToString

      Else

        sSTFGRPNom = ""

      End If

      oDrRecup.Close()

      Return sSTFGRPNom

    Catch ex As Exception

      MessageBox.Show("NomSTFGRP dans CDocSTFCondCom : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return ""

    End Try

  End Function

  Public Function ListeDocSTFCondCom() As DataTable

    Try

      dtSTFGRPDocCondCom = New DataTable

      Dim sqlcmdProspDocSTFCondComLst As New SqlCommand("api_sp_ListeDocSTFConditionsCommerciales", MozartDatabase.cnxMozart)
      sqlcmdProspDocSTFCondComLst.CommandType = CommandType.StoredProcedure
      sqlcmdProspDocSTFCondComLst.Parameters.Add("@P_NSTFGRPNUM", SqlDbType.Int)
      sqlcmdProspDocSTFCondComLst.Parameters("@P_NSTFGRPNUM").Value = iNSTFGRPNUM

      dtSTFGRPDocCondCom.Load(sqlcmdProspDocSTFCondComLst.ExecuteReader)

      Return dtSTFGRPDocCondCom

    Catch ex As Exception

      MessageBox.Show("CDocSTFCondCom dans ListeDocSTFCondCom : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Public Sub CreateDocSTFCondCom()

    Try

      Dim oNewRowDocInt As DataRow = dtSTFGRPDocCondCom.NewRow
      oNewRowDocInt.Item("NIDDOCSTFCONDCOM") = 0
      oNewRowDocInt.Item("NSTFGRPNUM") = iNSTFGRPNUM
      Dim oFrmDocSTFCondCom As New frmAjoutDocSTFCondCom(oNewRowDocInt)
      oFrmDocSTFCondCom.ShowDialog()

      If Not oFrmDocSTFCondCom.p_oDRTmpNew Is Nothing AndAlso oFrmDocSTFCondCom.p_Save = True Then

        SaveLigneDocSTFCondCom(oFrmDocSTFCondCom.p_oDRTmpNew)
        dtSTFGRPDocCondCom.Rows.Add(oFrmDocSTFCondCom.p_oDRTmpNew)

      End If
      oFrmDocSTFCondCom.Dispose()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Sub ModifDocSTFCondCom(ByVal oDRProspDocSTFCondComModif As DataRow)

    Try

      Dim oFrmDocSTFCondComModif As New frmAjoutDocSTFCondCom(oDRProspDocSTFCondComModif)
      oFrmDocSTFCondComModif.ShowDialog()

      If Not oFrmDocSTFCondComModif.p_oDRTmpNew Is Nothing AndAlso oFrmDocSTFCondComModif.p_Save = True Then
        SaveLigneDocSTFCondCom(oFrmDocSTFCondComModif.p_oDRTmpNew)
      End If
      oFrmDocSTFCondComModif.Dispose()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  'Public Sub SaveDocSTFCondCom()

  '    Try

  '        Dim ODtSupprLine As DataTable = dtSTFGRPDocCondCom.GetChanges(DataRowState.Deleted)
  '        If Not ODtSupprLine Is Nothing Then
  '            ODtSupprLine.RejectChanges()
  '            'suppression des lignes supprimer dans la datable
  '            If ODtSupprLine.Rows.Count > 0 Then
  '                For Each oRowsInvSupp As DataRow In ODtSupprLine.Rows

  '                Next
  '            End If
  '        End If

  '        dtSTFGRPDocCondCom.AcceptChanges()
  '        'sauvegarde des lignes inventaires
  '        If dtSTFGRPDocCondCom.Rows.Count > 0 Then
  '            For Each oRowsprospDocInt As DataRow In dtSTFGRPDocCondCom.Rows
  '                SaveLigneDocSTFCondCom(oRowsprospDocInt)
  '            Next
  '        End If

  '        ListeDocSTFCondCom()

  '    Catch ex As Exception
  '        MessageBox.Show(ex.Message)
  '    End Try

  'End Sub

  Private Sub SaveLigneDocSTFCondCom(ByVal oRowsSavTemp As DataRow)

    Try

      Dim ret_NIDDOCSTFCONDCOM As Int32
      Dim sFileLastUpdate As String = ""

      'avant d'enregistrer le fichier on recupére le filename avant modification
      If oRowsSavTemp.Item("NIDDOCSTFCONDCOM") <> 0 Then

        sFileLastUpdate = NewFileNameSRC(oRowsSavTemp.Item("NIDDOCSTFCONDCOM"))

      End If

      Dim sqlcmdCreateLigne As New SqlCommand("api_sp_CreationDocSTFCondCom", MozartDatabase.cnxMozart)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@P_NIDDOCSTFCONDCOM", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NIDDOCSTFCONDCOM").Value = oRowsSavTemp.Item("NIDDOCSTFCONDCOM")
      sqlcmdCreateLigne.Parameters.Add("@P_NSTFGRPNUM", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NSTFGRPNUM").Value = iNSTFGRPNUM
      sqlcmdCreateLigne.Parameters.Add("@P_VTITLE", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@P_VTITLE").Value = oRowsSavTemp.Item("VTITLE")
      sqlcmdCreateLigne.Parameters.Add("@P_VFILENAMESRC", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@P_VFILENAMESRC").Value = Path.GetFileName(oRowsSavTemp.Item("VFILE"))

      ret_NIDDOCSTFCONDCOM = sqlcmdCreateLigne.ExecuteScalar

      Dim sNewFileNameSRC As String = NewFileNameSRC(ret_NIDDOCSTFCONDCOM)

      If (gstrCheminDocSTFCondCom + sFileLastUpdate <> gstrCheminDocSTFCondCom + sNewFileNameSRC And gstrCheminDocSTFCondCom + sFileLastUpdate <> oRowsSavTemp.Item("VFILE").ToString And oRowsSavTemp.Item("VFILE").ToString <> "") AndAlso oRowsSavTemp.Item("VFILE") <> gstrCheminDocSTFCondCom + sNewFileNameSRC Then
        CopyFileIsFinish(oRowsSavTemp.Item("VFILE"), gstrCheminDocSTFCondCom + sNewFileNameSRC)
        'si c'est une mise à jour cad que sFileLastUpdate <> "" alors on supprime l'ancien fichier
        If sFileLastUpdate <> "" AndAlso File.Exists(gstrCheminDocSTFCondCom + sFileLastUpdate) Then File.Delete(gstrCheminDocSTFCondCom + sFileLastUpdate)

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Sub DeleteLigneDocSTFCondCom(ByVal oRowsSupprTemp As DataRow)

    Try

      If oRowsSupprTemp.Item("NIDDOCSTFCONDCOM") > 0 Then

        Dim sqlcmdSupprLigne As New SqlCommand("api_sp_SuppressionDocSTFCondCom", MozartDatabase.cnxMozart)
        sqlcmdSupprLigne.CommandType = CommandType.StoredProcedure
        sqlcmdSupprLigne.Parameters.Add("@P_NIDDOCSTFCONDCOM", SqlDbType.Int)
        sqlcmdSupprLigne.Parameters("@P_NIDDOCSTFCONDCOM").Value = oRowsSupprTemp.Item("NIDDOCSTFCONDCOM")

        sqlcmdSupprLigne.ExecuteNonQuery()

        'suppression du fichier
        If File.Exists(oRowsSupprTemp.Item("VPATHFILE").ToString) Then File.Delete(oRowsSupprTemp.Item("VPATHFILE").ToString)

        oRowsSupprTemp.Delete()

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Function NewFileNameSRC(ByVal P_NIDDOCSTFCONDCOM As Int32) As String

    Try
      Dim sNewFileNameSRC As String

      Dim sqlcmdRecup As New SqlCommand("api_sp_DocSTFCondComRecupNomFichierSRC", MozartDatabase.cnxMozart)

      sqlcmdRecup.CommandType = CommandType.StoredProcedure
      sqlcmdRecup.Parameters.Add("@P_NIDDOCSTFCONDCOM", SqlDbType.Int)
      sqlcmdRecup.Parameters("@P_NIDDOCSTFCONDCOM").Value = P_NIDDOCSTFCONDCOM

      Dim oDrRecup As SqlDataReader = sqlcmdRecup.ExecuteReader

      If oDrRecup.HasRows Then

        oDrRecup.Read()
        sNewFileNameSRC = oDrRecup.Item("VFILE").ToString

      Else

        sNewFileNameSRC = ""

      End If

      oDrRecup.Close()

      Return sNewFileNameSRC

    Catch ex As Exception

      MessageBox.Show("CDocSTFCondCom dans NewFileNameSRC : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

      MessageBox.Show("CDocSTFCondCom dans CopyFileIsFinish : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Try


  End Sub

End Class
