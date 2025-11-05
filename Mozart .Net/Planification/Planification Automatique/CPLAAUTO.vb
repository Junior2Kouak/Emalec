Imports System.Data.SqlClient
Imports MozartLib

Public Class CPLAAUTO


  Friend NPLA_AUTO_ID As Int32
  Friend NCHOIXPERIODE As Int32
  Friend DPERIODE_DEBUT As DateTime?
  Friend DPERIODE_FIN As DateTime?
  Friend NPERIODE_TOLERANCE As Int32?
  Friend BJOUR_FORBIDEN As Boolean
  Friend VJOUR_FORBIDEN_LIST As String
  Friend BTECH_COMPET As Boolean
  Friend BTECH_UNIQUE As Boolean
  Friend NPERNUM_TECH_UNIQUE As Int32
  Friend BBLOC_PAVE As Boolean
  Friend DDATECREE As DateTime?
  Friend DDATEMOD As DateTime?
  Friend NQUICREE As Int32
  Friend NQUIMOD As Int32
  Friend DDATE_TRAITEMENT As DateTime?
  Friend VSOCIETE As String
  Friend VBLOCPAVE_LABEL As String
  Friend BLOCKTRAITE As Boolean
  Friend CPLA_AUTO_ETAT As String

  Friend DTPLA_AUTO_ACT As DataTable

  Public Sub New(ByVal c_NPLA_AUTO_ID As Int32)

    NPLA_AUTO_ID = c_NPLA_AUTO_ID

    LoadData()

  End Sub

  Private Sub LoadData()

    Dim sqlcmd As New SqlCommand("[api_sp_Planif_Auto_Detail]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
		sqlcmd.Parameters.Add("@P_NPLA_AUTO_ID", SqlDbType.Int).Value = NPLA_AUTO_ID

		Dim sqldr As SqlDataReader = sqlcmd.ExecuteReader()

		If sqldr.HasRows Then

			sqldr.Read()

			NPLA_AUTO_ID = sqldr("NPLA_AUTO_ID")
			NCHOIXPERIODE = sqldr("NCHOIXPERIODE")
			If sqldr.Item("DPERIODE_DEBUT") Is DBNull.Value Then
				DPERIODE_DEBUT = Nothing
			Else
				DPERIODE_DEBUT = sqldr.Item("DPERIODE_DEBUT")
			End If
			If sqldr.Item("DPERIODE_FIN") Is DBNull.Value Then
				DPERIODE_FIN = Nothing
			Else
				DPERIODE_FIN = sqldr.Item("DPERIODE_FIN")
			End If
			If sqldr.Item("NPERIODE_TOLERANCE") Is DBNull.Value Then
				NPERIODE_TOLERANCE = Nothing
			Else
				NPERIODE_TOLERANCE = sqldr.Item("NPERIODE_TOLERANCE")
			End If

			BJOUR_FORBIDEN = sqldr("BJOUR_FORBIDEN")
			VJOUR_FORBIDEN_LIST = sqldr("VJOUR_FORBIDEN_LIST")
			BTECH_COMPET = sqldr("BTECH_COMPET")
			BTECH_UNIQUE = sqldr("BTECH_UNIQUE")
			NPERNUM_TECH_UNIQUE = sqldr("NPERNUM_TECH_UNIQUE")
			BBLOC_PAVE = sqldr("BBLOC_PAVE")

			If sqldr.Item("DDATECREE") Is DBNull.Value Then
				DDATECREE = Nothing
			Else
				DDATECREE = sqldr.Item("DDATECREE")
			End If

			If sqldr.Item("DDATEMOD") Is DBNull.Value Then
				DDATEMOD = Nothing
			Else
				DDATEMOD = sqldr.Item("DDATEMOD")
			End If

			NQUICREE = sqldr("NQUICREE")
			NQUIMOD = sqldr("NQUIMOD")

			If sqldr.Item("DDATE_TRAITEMENT") Is DBNull.Value Then
				DDATE_TRAITEMENT = Nothing
			Else
				DDATE_TRAITEMENT = sqldr.Item("DDATE_TRAITEMENT")
			End If

			VSOCIETE = sqldr("VSOCIETE")
			VBLOCPAVE_LABEL = sqldr("VBLOCPAVE_LABEL")

			CPLA_AUTO_ETAT = sqldr("CPLA_AUTO_ETAT")

		End If
		sqldr.Close()

		'liste des actions
		DTPLA_AUTO_ACT = New DataTable

    sqlcmd = New SqlCommand("[api_sp_Planif_Auto_ListeActionsByNPLA_AUTO_ID]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
		sqlcmd.Parameters.Add("@P_NPLA_AUTO_ID", SqlDbType.Int).Value = NPLA_AUTO_ID
		DTPLA_AUTO_ACT.Load(sqlcmd.ExecuteReader())

	End Sub

	Public Sub SaveData()

    Dim sqlcmd As New SqlCommand("[api_sp_Planif_Auto_Save]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
		sqlcmd.Parameters.Add("@P_NPLA_AUTO_ID", SqlDbType.Int).Value = NPLA_AUTO_ID
		sqlcmd.Parameters("@P_NPLA_AUTO_ID").Direction = ParameterDirection.InputOutput
		sqlcmd.Parameters.Add("@P_NCHOIXPERIODE", SqlDbType.Int).Value = NCHOIXPERIODE
		sqlcmd.Parameters.Add("@P_DPERIODE_DEBUT", SqlDbType.DateTime).Value = If(DPERIODE_DEBUT Is Nothing, DBNull.Value, DPERIODE_DEBUT)
		sqlcmd.Parameters.Add("@P_DPERIODE_FIN", SqlDbType.DateTime).Value = If(DPERIODE_FIN Is Nothing, DBNull.Value, DPERIODE_FIN)
		sqlcmd.Parameters.Add("@P_NPERIODE_TOLERANCE", SqlDbType.Int).Value = NPERIODE_TOLERANCE
		sqlcmd.Parameters.Add("@P_BJOUR_FORBIDEN", SqlDbType.Bit).Value = BJOUR_FORBIDEN
		sqlcmd.Parameters.Add("@P_VJOUR_FORBIDEN_LIST", SqlDbType.VarChar).Value = VJOUR_FORBIDEN_LIST
		sqlcmd.Parameters.Add("@P_BTECH_COMPET", SqlDbType.Bit).Value = BTECH_COMPET
		sqlcmd.Parameters.Add("@P_BTECH_UNIQUE", SqlDbType.Bit).Value = BTECH_UNIQUE
		sqlcmd.Parameters.Add("@P_NPERNUM_TECH_UNIQUE", SqlDbType.Int).Value = NPERNUM_TECH_UNIQUE
		sqlcmd.Parameters.Add("@P_BBLOC_PAVE", SqlDbType.Bit).Value = BBLOC_PAVE
		sqlcmd.Parameters.Add("@P_BLOCKTRAITE", SqlDbType.Bit).Value = BLOCKTRAITE
		sqlcmd.Parameters.Add("@P_VBLOCPAVE_LABEL", SqlDbType.VarChar).Value = VBLOCPAVE_LABEL

		sqlcmd.ExecuteNonQuery()

		NPLA_AUTO_ID = sqlcmd.Parameters("@P_NPLA_AUTO_ID").Value




	End Sub

	Public Sub RefreshData()

		LoadData()

	End Sub

	Public Sub Delete()

    Dim sqlcmd As New SqlCommand("[api_sp_Planif_Auto_Delete]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
		sqlcmd.Parameters.Add("@P_NPLA_AUTO_ID", SqlDbType.Int).Value = NPLA_AUTO_ID

		sqlcmd.ExecuteNonQuery()

		NPLA_AUTO_ID = 0

	End Sub

	Public Sub SaveEtatToReadyToTraite()

    Dim sqlcmd As New SqlCommand("[api_sp_Planif_Auto_SaveEtat]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
		sqlcmd.Parameters.Add("@P_NPLA_AUTO_ID", SqlDbType.Int).Value = NPLA_AUTO_ID
		sqlcmd.Parameters.Add("@P_CPLA_AUTO_ETAT", SqlDbType.VarChar).Value = "RP"  'READY TO PREVIEW

		sqlcmd.ExecuteNonQuery()

		CPLA_AUTO_ETAT = "P"

	End Sub

	Public Sub SaveEtatToStandBy()

    Dim sqlcmd As New SqlCommand("[api_sp_Planif_Auto_SaveEtat]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
		sqlcmd.Parameters.Add("@P_NPLA_AUTO_ID", SqlDbType.Int).Value = NPLA_AUTO_ID
		sqlcmd.Parameters.Add("@P_CPLA_AUTO_ETAT", SqlDbType.VarChar).Value = "A"

		sqlcmd.ExecuteNonQuery()

		CPLA_AUTO_ETAT = "A"

	End Sub

	Public Sub AddActionInPlaAuto(ByVal P_NACTNUM As Int32)

    Dim sqlcmd As New SqlCommand("[api_sp_Planif_Auto_SaveAction]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
		sqlcmd.Parameters.Add("@P_NPLA_AUTO_ID", SqlDbType.Int).Value = NPLA_AUTO_ID
		sqlcmd.Parameters.Add("@P_NACTNUM", SqlDbType.Int).Value = P_NACTNUM

		sqlcmd.ExecuteNonQuery()

	End Sub

	Public Sub DeleteActionInPlaAuto(ByVal P_NACTNUM As Int32)

    Dim sqlcmd As New SqlCommand("[api_sp_Planif_Auto_DeleteAction]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
		sqlcmd.Parameters.Add("@P_NPLA_AUTO_ID", SqlDbType.Int).Value = NPLA_AUTO_ID
		sqlcmd.Parameters.Add("@P_NACTNUM", SqlDbType.Int).Value = P_NACTNUM

		sqlcmd.ExecuteNonQuery()

	End Sub

End Class
