Imports System.Data.SqlClient
Imports MozartLib


Public Class CExtInvEquip

  Dim iNACTNUM As Int32
  Dim iNEXTINVID As Int32
  Dim sReadOnly As String

  Dim dtExtInv As DataTable

  Public Sub New(c_NACTNUM As Int32)

    iNACTNUM = c_NACTNUM

    ReturnIDInv()

    LoadListeInv()

  End Sub

  Property p_dtExtInv As DataTable
    Get
      Return dtExtInv
    End Get
    Set(ByVal value As DataTable)
      dtExtInv = value
    End Set
  End Property

  Property p_iNEXTINVID As Int32
    Get
      Return iNEXTINVID
    End Get
    Set(ByVal value As Int32)
      iNEXTINVID = value
    End Set
  End Property

  Public Function LoadListeFournituresExtinctCombo() As DataTable

    Try

      Dim dtExtLstFouCbo As New DataTable

      Dim sqlcmdCboFou As New SqlCommand("[api_sp_CorrectionCRVP_ExtListeComboFou]", MozartDatabase.cnxMozart)
      sqlcmdCboFou.CommandType = CommandType.StoredProcedure
      dtExtLstFouCbo.Load(sqlcmdCboFou.ExecuteReader)

      Return dtExtLstFouCbo

    Catch ex As Exception

      MessageBox.Show("CExtInvEquip - LoadListeFrounituresExtinctCombo : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Public Function LoadListeMarqueExtinctCombo() As DataTable

    Try

      Dim dtExtLstMarqueCbo As New DataTable

      Dim sqlcmdCbomarque As New SqlCommand("[api_sp_CorrectionCRVP_ExtListeComboMarque]", MozartDatabase.cnxMozart)
      sqlcmdCbomarque.CommandType = CommandType.StoredProcedure
      sqlcmdCbomarque.Parameters.Add("@p_NACTNUM", SqlDbType.Int)
      sqlcmdCbomarque.Parameters("@p_NACTNUM").Value = iNACTNUM
      dtExtLstMarqueCbo.Load(sqlcmdCbomarque.ExecuteReader)

      Return dtExtLstMarqueCbo

    Catch ex As Exception

      MessageBox.Show("CExtInvEquip - LoadListeMarqueExtinctCombo : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Public Function LoadListeAnneeExtinctCombo() As DataTable

    Try

      Dim dtExtLstAnneeCbo As New DataTable

      Dim sqlcmdCboAnnee As New SqlCommand("[api_sp_CorrectionCRVP_ExtListeComboAnnee]", MozartDatabase.cnxMozart)
      sqlcmdCboAnnee.CommandType = CommandType.StoredProcedure
      dtExtLstAnneeCbo.Load(sqlcmdCboAnnee.ExecuteReader)

      Return dtExtLstAnneeCbo

    Catch ex As Exception

      MessageBox.Show("CExtInvEquip - LoadListeAnneeExtinctCombo : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Public Function LoadListeActionsExtinctCombo() As DataTable

    Try

      Dim dtExtLstActionsCbo As New DataTable

      Dim sqlcmdCboActions As New SqlCommand("[api_sp_CorrectionCRVP_ExtListeComboActions]", MozartDatabase.cnxMozart)
      sqlcmdCboActions.CommandType = CommandType.StoredProcedure
      dtExtLstActionsCbo.Load(sqlcmdCboActions.ExecuteReader)

      Return dtExtLstActionsCbo

    Catch ex As Exception

      MessageBox.Show("CExtInvEquip - LoadListeActionsExtinctCombo : " + ex.Message)
      Return Nothing

    End Try

  End Function
    Private Sub ReturnIDInv()

        Try

      Dim sqlCmdReturnID As New SqlCommand("[api_sp_CorrectionCRVP_ExtReturnIDInv]", MozartDatabase.cnxMozart)
      sqlCmdReturnID.CommandType = CommandType.StoredProcedure
            sqlCmdReturnID.Parameters.Add("@p_NACTNUM", SqlDbType.Int)
            sqlCmdReturnID.Parameters("@p_NACTNUM").Value = iNACTNUM
            Dim drinfo As SqlDataReader = sqlCmdReturnID.ExecuteReader
            If drinfo.HasRows Then
                drinfo.Read()
                iNEXTINVID = drinfo("NEXTINVID")
            Else
                iNEXTINVID = 0

            End If
            drinfo.Close()
        Catch ex As Exception
            MessageBox.Show("CExtInvEquip - ReturnIDInv : " + ex.Message)
        End Try

    End Sub

    Public Sub LoadListeInv()

    Try

      dtExtInv = New DataTable
      Dim sqlcmdInv As New SqlCommand("[api_sp_CorrectionCRVP_ExtListeInv]", MozartDatabase.cnxMozart)
      sqlcmdInv.CommandType = CommandType.StoredProcedure
            sqlcmdInv.Parameters.Add("@p_NEXTINVID", SqlDbType.Int)
            sqlcmdInv.Parameters("@p_NEXTINVID").Value = iNEXTINVID

            Dim ColAutoInc As DataColumn = New DataColumn
      ColAutoInc.DataType = System.Type.GetType("System.Int64")
      ColAutoInc.ColumnName = "IDTMP"
      With ColAutoInc
        .AutoIncrement = True
        .AutoIncrementSeed = 0
        .AutoIncrementStep = 1
      End With

            dtExtInv.Columns.Add(ColAutoInc)



            dtExtInv.Load(sqlcmdInv.ExecuteReader)
            dtExtInv.Columns("VEXTINVEMPL").ReadOnly = False
            dtExtInv.Columns("VEXTINVLNUMERO").ReadOnly = False
        Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

    Public Sub SaveExtInvEquip()

    Try
            dtExtInv.AcceptChanges()

            If (iNEXTINVID > 0) Then

        'sauvegarde inventaire
        Dim sqlcmdCreateInv As New SqlCommand("[api_sp_CorrectionCRVP_ExtInvCreate]", MozartDatabase.cnxMozart)
        sqlcmdCreateInv.CommandType = CommandType.StoredProcedure
                sqlcmdCreateInv.Parameters.Add("@P_NEXTINVID", SqlDbType.Int)
                sqlcmdCreateInv.Parameters("@P_NEXTINVID").Value = iNEXTINVID
                sqlcmdCreateInv.Parameters.Add("@P_NACTNUM", SqlDbType.Int)
                sqlcmdCreateInv.Parameters("@P_NACTNUM").Value = iNACTNUM

                sqlcmdCreateInv.ExecuteNonQuery()

                'sauvegarde des lignes inventaires
                If dtExtInv.Rows.Count > 0 Then
                    For Each oRowsInv As DataRow In dtExtInv.Rows
                        SaveLigneInventaireExt(oRowsInv)
                    Next
                End If

            End If

            'LoadListeInv()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub AddNewLineExtInvEquip()

        Try

            Dim NewLineDataRow As DataRow = dtExtInv.NewRow

            NewLineDataRow("NEXTINVLID") = 0
            NewLineDataRow("NEXTINVID") = iNEXTINVID
            NewLineDataRow("NACTNUM") = iNACTNUM
            NewLineDataRow("NFOUNUM") = 0
            'NewLineDataRow("VEXTEMPL") = ""
            'NewLineDataRow("VEXTNUMERO") = ""

            dtExtInv.Rows.Add(NewLineDataRow)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub SuppLineExtInvEquip(ByVal p_NIDTMP As Int32)

        dtExtInv.Select("IDTMP=" + p_NIDTMP.ToString)(0).Delete()

    End Sub

    Private Sub SupprLigneInventaireExt(ByVal oRowsSupprTemp As DataRow)

        'Try

        '    If oRowsSupprTemp.Item("NEXTINVIDL") > 0 Then

        '        Dim sqlcmdSupprLigne As New SqlCommand("api_sp_ExtInvSupprLigne", cnx)
        '        sqlcmdSupprLigne.CommandType = CommandType.StoredProcedure
        '        sqlcmdSupprLigne.Parameters.Add("@P_NEXTINVIDL", SqlDbType.Int)
        '        sqlcmdSupprLigne.Parameters("@P_NEXTINVIDL").Value = oRowsSupprTemp.Item("NEXTINVIDL")

        '        sqlcmdSupprLigne.ExecuteNonQuery()

        '    End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub SaveLigneInventaireExt(ByVal oRowsSavTemp As DataRow)

        Try

      Dim sqlcmdCreateLigne As New SqlCommand("[api_sp_CorrectionCRVP_ExtInvCreateLigne]", MozartDatabase.cnxMozart)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@P_NEXTINVIDL", SqlDbType.Int)
            sqlcmdCreateLigne.Parameters("@P_NEXTINVIDL").Value = oRowsSavTemp.Item("NEXTINVLID")
            sqlcmdCreateLigne.Parameters.Add("@P_NEXTINVID", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NEXTINVID").Value = iNEXTINVID
      sqlcmdCreateLigne.Parameters.Add("@P_NACTNUM", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NACTNUM").Value = iNACTNUM
      sqlcmdCreateLigne.Parameters.Add("@P_NFOUNUM", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NFOUNUM").Value = oRowsSavTemp.Item("NFOUNUM")
      sqlcmdCreateLigne.Parameters.Add("@P_VEXTEMPL", SqlDbType.VarChar)
            sqlcmdCreateLigne.Parameters("@P_VEXTEMPL").Value = oRowsSavTemp.Item("VEXTINVEMPL")
            sqlcmdCreateLigne.Parameters.Add("@P_VEXTNUMERO", SqlDbType.VarChar)
            sqlcmdCreateLigne.Parameters("@P_VEXTNUMERO").Value = oRowsSavTemp.Item("VEXTINVLNUMERO")
            sqlcmdCreateLigne.Parameters.Add("@P_NEXTINVLANNEE", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NEXTINVLANNEE").Value = oRowsSavTemp.Item("NEXTINVLANNEE")
      sqlcmdCreateLigne.Parameters.Add("@P_VEXTINVLMARQ", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@P_VEXTINVLMARQ").Value = oRowsSavTemp.Item("VEXTINVLMARQ")
      sqlcmdCreateLigne.Parameters.Add("@P_VEXTINVACTION", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@P_VEXTINVACTION").Value = oRowsSavTemp.Item("VEXTINVACTION")
      sqlcmdCreateLigne.Parameters.Add("@P_VEXTINVOBS", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@P_VEXTINVOBS").Value = oRowsSavTemp.Item("VEXTINVOBS")
      sqlcmdCreateLigne.Parameters.Add("@P_BEXTVERIFOUI", SqlDbType.Bit)
      sqlcmdCreateLigne.Parameters("@P_BEXTVERIFOUI").Value = oRowsSavTemp.Item("BEXTVERIFOUI")
      sqlcmdCreateLigne.Parameters.Add("@P_BEXTVERIFNON", SqlDbType.Bit)
      sqlcmdCreateLigne.Parameters("@P_BEXTVERIFNON").Value = oRowsSavTemp.Item("BEXTVERIFNON")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

End Class