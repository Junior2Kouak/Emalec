Imports System.Data.SqlClient
Imports MozartLib

Public Class CExtBordereau

  Dim iNACTNUM As Int32
  Dim iNEXTBORDID As Int32

  Dim iNDCLNUM As Int32
  Dim iNBLINEDCL As Int32

  Dim dtExtBord As DataTable

  Public Sub New(p_iNACTNUM As Int32)

    iNACTNUM = p_iNACTNUM

    ' on charge l'id du bordereau
    ReturnIDInv()
    'on charge les fournitures du bordereau
    LoadListeBordereau()
    'on charge les donnees sil y a un devis ei
    LoadDataDevisEINDCLNUM()

  End Sub

  Property p_dtExtBord As DataTable
    Get
      Return dtExtBord
    End Get
    Set(ByVal value As DataTable)
      dtExtBord = value
    End Set
  End Property

  Property p_iNEXTBORDID As Int32
    Get
      Return iNEXTBORDID
    End Get
    Set(ByVal value As Int32)
      iNEXTBORDID = value
    End Set
  End Property

  Public ReadOnly Property p_iNDCLNUM As Int32
    Get
      Return iNDCLNUM
    End Get
  End Property

  Public ReadOnly Property p_iNBLINEDCL As Int32
    Get
      Return iNBLINEDCL
    End Get
  End Property

  Public Function LoadListeFournituresExtinctBordCombo() As DataTable

    Try

      Dim dtExtLstFouCbo As New DataTable

      Dim sqlcmdCboFou As New SqlCommand("[api_sp_CorrectionCRVP_ExtListeComboFouBord]", MozartDatabase.cnxMozart)
      sqlcmdCboFou.CommandType = CommandType.StoredProcedure
      sqlcmdCboFou.Parameters.Add("@p_NACTNUM", SqlDbType.Int)
      sqlcmdCboFou.Parameters("@p_NACTNUM").Value = iNACTNUM

      dtExtLstFouCbo.Load(sqlcmdCboFou.ExecuteReader)

      Return dtExtLstFouCbo

    Catch ex As Exception

      MessageBox.Show("CExtBordereau - LoadListeFournituresExtinctBordCombo : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Private Sub ReturnIDInv()

    Try

      Dim sqlCmdReturnID As New SqlCommand("[api_sp_CorrectionCRVP_ExtReturnIDBord]", MozartDatabase.cnxMozart)
      sqlCmdReturnID.CommandType = CommandType.StoredProcedure
      sqlCmdReturnID.Parameters.Add("@p_NACTNUM", SqlDbType.Int)
      sqlCmdReturnID.Parameters("@p_NACTNUM").Value = iNACTNUM
      Dim drinfo As SqlDataReader = sqlCmdReturnID.ExecuteReader
      If drinfo.HasRows Then
        drinfo.Read()
        iNEXTBORDID = drinfo("NEXTBORDID")
      Else
        iNEXTBORDID = 0
      End If
      drinfo.Close()
    Catch ex As Exception
      MessageBox.Show("CExtBordereau - ReturnIDInv : " + ex.Message)
    End Try

  End Sub

  Public Sub LoadListeBordereau()

    Try

      dtExtBord = New DataTable
      Dim sqlcmdBord As New SqlCommand("[api_sp_CorrectionCRVP_ExtListeBordereau]", MozartDatabase.cnxMozart)
      sqlcmdBord.CommandType = CommandType.StoredProcedure
      sqlcmdBord.Parameters.Add("@p_NACTNUM", SqlDbType.Int)
      sqlcmdBord.Parameters("@p_NACTNUM").Value = iNACTNUM

      Dim ColAutoInc As DataColumn = New DataColumn
      ColAutoInc.DataType = System.Type.GetType("System.Int64")
      ColAutoInc.ColumnName = "IDTMP"
      With ColAutoInc
        .AutoIncrement = True
        .AutoIncrementSeed = 0
        .AutoIncrementStep = 1
      End With

      dtExtBord.Columns.Add(ColAutoInc)
      dtExtBord.Load(sqlcmdBord.ExecuteReader)

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Sub SaveExtBordereau()

    Try

      dtExtBord.AcceptChanges()
      If (iNEXTBORDID > 0) Then

        Dim sqlcmdCreate As New SqlCommand("[api_sp_CorrectionCRVP_ExtBordCreate]", MozartDatabase.cnxMozart)
        sqlcmdCreate.CommandType = CommandType.StoredProcedure
        sqlcmdCreate.Parameters.Add("@P_NEXTBORDID", SqlDbType.Int)
        sqlcmdCreate.Parameters("@P_NEXTBORDID").Value = iNEXTBORDID
        sqlcmdCreate.Parameters.Add("@p_NACTNUM", SqlDbType.Int)
        sqlcmdCreate.Parameters("@p_NACTNUM").Value = iNACTNUM

        sqlcmdCreate.ExecuteScalar()

        'sauvegarde des lignes inventaires
        If dtExtBord.Rows.Count > 0 Then
          For Each oRowsInv As DataRow In dtExtBord.Rows
            SaveLigneBordereauExt(oRowsInv)
          Next
        End If

      End If

      'LoadListeBordereau()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SupprLigneBordereauExt(ByVal oRowsSupprTemp As DataRow)

    Try

      If oRowsSupprTemp.Item("NEXTBORDIDL") > 0 Then

        Dim sqlcmdSupprLigne As New SqlCommand("api_sp_ExtBordSupprLigne", MozartDatabase.cnxMozart)
        sqlcmdSupprLigne.CommandType = CommandType.StoredProcedure
        sqlcmdSupprLigne.Parameters.Add("@P_NEXTBORDIDL", SqlDbType.Int)
        sqlcmdSupprLigne.Parameters("@P_NEXTBORDIDL").Value = oRowsSupprTemp.Item("NEXTBORDIDL")

        sqlcmdSupprLigne.ExecuteNonQuery()

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Sub AddNewLineExtBordereau()

    Try

      Dim NewLineDataRow As DataRow = dtExtBord.NewRow

      NewLineDataRow("NEXTBORDIDL") = 0
      NewLineDataRow("NEXTBORDID") = iNEXTBORDID
      NewLineDataRow("NACTNUM") = iNACTNUM
      'NewLineDataRow("NFOUNUM") = 0
      'NewLineDataRow("VEXTEMPL") = ""
      'NewLineDataRow("VEXTNUMERO") = ""

      dtExtBord.Rows.Add(NewLineDataRow)

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Sub AddNewLineExtBordereauForDCL(ByVal p_NFOUNUM As Int32, ByVal p_NEXTBORDQTEUSE As Int32)

    Try

      Dim NewLineDataRow As DataRow = dtExtBord.NewRow

      NewLineDataRow("NEXTBORDIDL") = 0
      NewLineDataRow("NEXTBORDID") = iNEXTBORDID
      NewLineDataRow("NACTNUM") = iNACTNUM
      NewLineDataRow("NFOUNUM") = p_NFOUNUM
      NewLineDataRow("NEXTBORDQTEUSE") = p_NEXTBORDQTEUSE
      NewLineDataRow("NEXTBORDQTEREPL") = 0

      dtExtBord.Rows.Add(NewLineDataRow)

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Public Sub SuppLineExtBordereau(ByVal p_NIDTMP As Int32)

    dtExtBord.Select("IDTMP=" + p_NIDTMP.ToString)(0).Delete()

  End Sub

  Private Sub SaveLigneBordereauExt(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sqlcmdCreateLigne As New SqlCommand("[api_sp_CorrectionCRVP_ExtBordCreateLigne]", MozartDatabase.cnxMozart)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@P_NEXTBORDIDL", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NEXTBORDIDL").Value = oRowsSavTemp.Item("NEXTBORDIDL")
      sqlcmdCreateLigne.Parameters.Add("@P_NEXTBORDID", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NEXTBORDID").Value = iNEXTBORDID
      sqlcmdCreateLigne.Parameters.Add("@P_NACTNUM", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NACTNUM").Value = iNACTNUM
      sqlcmdCreateLigne.Parameters.Add("@P_NFOUNUM", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NFOUNUM").Value = oRowsSavTemp.Item("NFOUNUM")
      sqlcmdCreateLigne.Parameters.Add("@P_NEXTBORDQTEUSE", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@P_NEXTBORDQTEUSE").Value = oRowsSavTemp.Item("NEXTBORDQTEUSE")
      sqlcmdCreateLigne.Parameters.Add("@P_NEXTBORDQTEREPL", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@P_NEXTBORDQTEREPL").Value = oRowsSavTemp.Item("NEXTBORDQTEREPL")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub
  '**********************************************************************************************************************
  'cette fonction permet d importer les fournitures definis dans un devis pour EI
  '**********************************************************************************************************************
  Public Sub ImportFouDCL()

    'on charge les fournitures dans la table TLCLDEI
    Try

      Dim dtFouDCL As New DataTable

      Dim sqlcmdFouDCL As New SqlCommand("api_sp_ExtListeFournituresInDCL", MozartDatabase.cnxMozart)
      sqlcmdFouDCL.CommandType = CommandType.StoredProcedure
      sqlcmdFouDCL.Parameters.Add("@p_NACTNUM", SqlDbType.Int)
      sqlcmdFouDCL.Parameters("@p_NACTNUM").Value = iNACTNUM

      dtFouDCL.Load(sqlcmdFouDCL.ExecuteReader)

      For Each oRowsDCL As DataRow In dtFouDCL.Rows

        AddNewLineExtBordereauForDCL(oRowsDCL.Item("NFOUNUM"), oRowsDCL.Item("NLDCLQTE"))

      Next

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub


  '**********************************************************************************************************************
  'cette fonction permet de supprimer les founritures du bordreau avant de retransferer les fournitures depuis un devis
  '**********************************************************************************************************************
  Public Sub DeleteFouEIInBord()

    Try

      Dim sqlcmdFouDCL As New SqlCommand("api_sp_ExtDeleteFournituresInBord", MozartDatabase.cnxMozart)
      sqlcmdFouDCL.CommandType = CommandType.StoredProcedure
      sqlcmdFouDCL.Parameters.Add("@p_NACTNUM", SqlDbType.Int)
      sqlcmdFouDCL.Parameters("@p_NACTNUM").Value = iNACTNUM

      sqlcmdFouDCL.ExecuteNonQuery()

      dtExtBord.Clear()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub LoadDataDevisEINDCLNUM()

    Try

      Dim oSqlcmd As New SqlCommand("[api_sp_CorrectionCRVP_RetourInfoDevisExist]", MozartDatabase.cnxMozart)
      oSqlcmd.CommandType = CommandType.StoredProcedure
      oSqlcmd.Parameters.Add("@p_nactnum", SqlDbType.Int)
      oSqlcmd.Parameters("@p_nactnum").Value = iNACTNUM

      Dim oDR As SqlDataReader = oSqlcmd.ExecuteReader

      oDR.Read()
      If oDR.HasRows = True AndAlso oDR.Item(0) > 0 Then

        iNDCLNUM = oDR.Item("NDCLNUM")
        iNBLINEDCL = oDR.Item("NBLINEDCL")
      Else
        iNDCLNUM = 0
        iNBLINEDCL = 0
      End If

      oDR.Close()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
      iNDCLNUM = 0
      iNBLINEDCL = 0
    End Try

  End Sub

End Class
