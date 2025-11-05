Imports System.Data.SqlClient
Imports MozartLib
Public Class CCertFluidBottle

  Dim _KEY_BOTTLE_UNIQUE As String
  Dim _NPERNUM As Int32
  Dim _NBOTTLE_TYPE As Int32
  Dim _NBOTTLE_CONTENANT As Decimal
  Dim _NIDTYPEFLUIDE As Int32
  Dim _VTYPEFLUIDE As String
  Dim _VBOTTLE_REF As String
  Dim _DBOTTLE_CREE As DateTime?
  Dim _NQUI_CREE As Int32
  Dim _DBOTTLE_MODIF As DateTime?
  Dim _NQUI_MODIF As Int32
  Dim _BBOTTLE_ACTIF As Boolean
  Dim _DBOTTLE_RESTI As DateTime?
  Dim _VBOTTLE_OBS As String
  Dim _CBOTTLE_ETAT_SYNC As String   'S:etat pour signaler que le techncien a bien téléachregr cette bottle,   'A': etat pour signaler une modification depuis MOZART
  Dim _NBOTTLEQTEUTIL As Decimal
  Dim _NCOMNUM As Int32
  Dim _NFOUNUM As Int32

  Public ReadOnly Property KEY_BOTTLE_UNIQUE As String
    Get
      Return _KEY_BOTTLE_UNIQUE
    End Get
  End Property

  Public Property NPERNUM As Int32
    Get
      Return _NPERNUM
    End Get
    Set(ByVal value As Int32)
      _NPERNUM = value
    End Set
  End Property

  Public Property NBOTTLE_TYPE As Int32
    Get
      Return _NBOTTLE_TYPE
    End Get
    Set(ByVal value As Int32)
      _NBOTTLE_TYPE = value
    End Set
  End Property

  Public Property NBOTTLE_CONTENANT As Decimal
    Get
      Return _NBOTTLE_CONTENANT
    End Get
    Set(ByVal value As Decimal)
      _NBOTTLE_CONTENANT = value
    End Set
  End Property

  Public Property NIDTYPEFLUIDE As Int32
    Get
      Return _NIDTYPEFLUIDE
    End Get
    Set(ByVal value As Int32)
      _NIDTYPEFLUIDE = value
    End Set
  End Property

  Public Property VTYPEFLUIDE As String
    Get
      Return _VTYPEFLUIDE
    End Get
    Set(ByVal value As String)
      _VTYPEFLUIDE = value
    End Set
  End Property

  Public Property VBOTTLE_REF As String
    Get
      Return _VBOTTLE_REF
    End Get
    Set(ByVal value As String)
      _VBOTTLE_REF = value
    End Set
  End Property

  Public Property DBOTTLE_CREE As DateTime?
    Get
      Return _DBOTTLE_CREE
    End Get
    Set(ByVal value As DateTime?)
      _DBOTTLE_CREE = value
    End Set
  End Property

  Public Property NQUI_CREE As Int32
    Get
      Return _NQUI_CREE
    End Get
    Set(ByVal value As Int32)
      _NQUI_CREE = value
    End Set
  End Property

  Public Property DBOTTLE_MODIF As DateTime?
    Get
      Return _DBOTTLE_MODIF
    End Get
    Set(ByVal value As DateTime?)
      _DBOTTLE_MODIF = value
    End Set
  End Property

  Public Property NQUI_MODIF As Int32
    Get
      Return _NQUI_MODIF
    End Get
    Set(ByVal value As Int32)
      _NQUI_MODIF = value
    End Set
  End Property
  Public Property BBOTTLE_ACTIF As Boolean
    Get
      Return _BBOTTLE_ACTIF
    End Get
    Set(ByVal value As Boolean)
      _BBOTTLE_ACTIF = value
    End Set
  End Property
  Public Property DBOTTLE_RESTI As DateTime?
    Get
      Return _DBOTTLE_RESTI
    End Get
    Set(ByVal value As DateTime?)
      _DBOTTLE_RESTI = value
    End Set
  End Property
  Public Property VBOTTLE_OBS As String
    Get
      Return _VBOTTLE_OBS
    End Get
    Set(ByVal value As String)
      _VBOTTLE_OBS = value
    End Set
  End Property

  Public ReadOnly Property CBOTTLE_ETAT_SYNC As String
    Get
      Return _CBOTTLE_ETAT_SYNC
    End Get
  End Property

  Public Property NBOTTLEQTEUTIL As Decimal
    Get
      Return _NBOTTLEQTEUTIL
    End Get
    Set(ByVal value As Decimal)
      _NBOTTLEQTEUTIL = value
    End Set
  End Property

  Public Property NCOMNUM As Int32
    Get
      Return _NCOMNUM
    End Get
    Set(ByVal value As Int32)
      _NCOMNUM = value
    End Set
  End Property

  Public Property NFOUNUM As Int32
    Get
      Return _NFOUNUM
    End Get
    Set(ByVal value As Int32)
      _NFOUNUM = value
    End Set
  End Property

  Public Sub New(ByVal c_KEY_BOTTLE_UNIQUE As String)

    _KEY_BOTTLE_UNIQUE = c_KEY_BOTTLE_UNIQUE
    LoadData()

  End Sub

  Public Sub LoadData()

    Dim osqlcmdRead As New SqlCommand("[api_sp_CertFluid_Bottle_Detail]", MozartDatabase.cnxMozart)

    osqlcmdRead.CommandType = CommandType.StoredProcedure
        osqlcmdRead.Parameters.Add("@p_KEY_BOTTLE_UNIQUE", SqlDbType.NVarChar).Value = _KEY_BOTTLE_UNIQUE

        Dim osqldr As SqlDataReader = osqlcmdRead.ExecuteReader

        If osqldr.HasRows Then

            osqldr.Read()
            _KEY_BOTTLE_UNIQUE = osqldr.Item("KEY_BOTTLE_UNIQUE")
            _NPERNUM = osqldr.Item("NPERNUM")
            _NBOTTLE_TYPE = osqldr.Item("NBOTTLE_TYPE")
            _NBOTTLE_CONTENANT = osqldr.Item("NBOTTLE_CONTENANT")
            _NIDTYPEFLUIDE = osqldr.Item("NIDTYPEFLUIDE")
            _VTYPEFLUIDE = osqldr.Item("VTYPEFLUIDE")
            _VBOTTLE_REF = osqldr.Item("VBOTTLE_REF")
            If osqldr.Item("DBOTTLE_CREE") Is DBNull.Value Then
                _DBOTTLE_CREE = Nothing
            Else
                _DBOTTLE_CREE = osqldr.Item("DBOTTLE_CREE")
            End If
            _NQUI_CREE = osqldr.Item("NQUICREE")
            If osqldr.Item("DBOTTLE_MODIF") Is DBNull.Value Then
                _DBOTTLE_MODIF = Nothing
            Else
                _DBOTTLE_MODIF = osqldr.Item("DBOTTLE_MODIF")
            End If
            _NQUI_MODIF = osqldr.Item("NQUIMODIF")
            _BBOTTLE_ACTIF = osqldr.Item("BBOTTLE_ACTIF")
            If osqldr.Item("DBOTTLE_RESTI") Is DBNull.Value Then
                _DBOTTLE_RESTI = Nothing
            Else
                _DBOTTLE_RESTI = osqldr.Item("DBOTTLE_RESTI")
            End If
            _VBOTTLE_OBS = osqldr.Item("VBOTTLE_OBS")
            _CBOTTLE_ETAT_SYNC = osqldr.Item("CBOTTLE_ETAT_SYNC")
      _NBOTTLEQTEUTIL = osqldr.Item("NBOTTLEQTEUTIL")
      _NCOMNUM = osqldr.Item("NCOMNUM")
      _NFOUNUM = osqldr.Item("NFOUNUM")

    Else

            'nouveau
            _VTYPEFLUIDE = ""
            _NIDTYPEFLUIDE = 0
            _VBOTTLE_REF = ""
            _VBOTTLE_OBS = ""
            _BBOTTLE_ACTIF = True
            _CBOTTLE_ETAT_SYNC = "A"
      _NBOTTLEQTEUTIL = 0
      _NCOMNUM = 0
      _NFOUNUM = 0

    End If

        If osqldr.IsClosed = False Then osqldr.Close()


    End Sub

    Public Sub SaveCertFluidBottle()

    Dim osqlcmdSave As New SqlCommand("[api_sp_CertFluid_Bottle_Save]", MozartDatabase.cnxMozart)

    osqlcmdSave.CommandType = CommandType.StoredProcedure
        If _KEY_BOTTLE_UNIQUE = "" Then
            osqlcmdSave.Parameters.Add("@p_KEY_BOTTLE_UNIQUE", SqlDbType.NVarChar, 40).Value = DBNull.Value
        Else
            osqlcmdSave.Parameters.Add("@p_KEY_BOTTLE_UNIQUE", SqlDbType.NVarChar, 40).Value = _KEY_BOTTLE_UNIQUE
        End If
        osqlcmdSave.Parameters("@p_KEY_BOTTLE_UNIQUE").Direction = ParameterDirection.InputOutput
        osqlcmdSave.Parameters.Add("@p_NPERNUM", SqlDbType.Int).Value = _NPERNUM
        osqlcmdSave.Parameters.Add("@p_NBOTTLE_TYPE", SqlDbType.Int).Value = _NBOTTLE_TYPE
    osqlcmdSave.Parameters.Add("@p_NBOTTLE_CONTENANT", SqlDbType.Decimal).Value = _NBOTTLE_CONTENANT
    osqlcmdSave.Parameters.Add("@p_NIDTYPEFLUIDE", SqlDbType.Int).Value = _NIDTYPEFLUIDE
        osqlcmdSave.Parameters.Add("@p_VTYPEFLUIDE", SqlDbType.VarChar).Value = _VTYPEFLUIDE
        osqlcmdSave.Parameters.Add("@p_VBOTTLE_REF", SqlDbType.VarChar).Value = _VBOTTLE_REF
        osqlcmdSave.Parameters.Add("@p_BBOTTLE_ACTIF", SqlDbType.Bit).Value = _BBOTTLE_ACTIF
        If Not _DBOTTLE_RESTI Is Nothing Then
            osqlcmdSave.Parameters.Add("@p_DBOTTLE_RESTI", SqlDbType.DateTime).Value = _DBOTTLE_RESTI
        Else
            osqlcmdSave.Parameters.Add("@p_DBOTTLE_RESTI", SqlDbType.DateTime).Value = DBNull.Value
        End If
        osqlcmdSave.Parameters.Add("@p_VBOTTLE_OBS", SqlDbType.VarChar).Value = _VBOTTLE_OBS

    osqlcmdSave.Parameters.Add("@P_NCOMNUM", SqlDbType.Int).Value = _NCOMNUM
    osqlcmdSave.Parameters.Add("@P_NFOUNUM", SqlDbType.Int).Value = _NFOUNUM

    osqlcmdSave.ExecuteNonQuery()

        _KEY_BOTTLE_UNIQUE = osqlcmdSave.Parameters("@p_KEY_BOTTLE_UNIQUE").Value

    End Sub

    Public Sub Archive()

        If _KEY_BOTTLE_UNIQUE = "" Then Exit Sub

        _BBOTTLE_ACTIF = False

    Dim osqlcmdArch As New SqlCommand("[api_sp_CertFluid_Bottle_Archive_Or_Restore]", MozartDatabase.cnxMozart)
    osqlcmdArch.CommandType = CommandType.StoredProcedure
        osqlcmdArch.Parameters.Add("@p_KEY_BOTTLE_UNIQUE", SqlDbType.NVarChar, 40).Value = _KEY_BOTTLE_UNIQUE
        osqlcmdArch.Parameters.Add("@p_BBOTTLE_ACTIF", SqlDbType.Bit).Value = _BBOTTLE_ACTIF

        osqlcmdArch.ExecuteNonQuery()

    End Sub

    Public Sub Restaure()

        If _KEY_BOTTLE_UNIQUE = "" Then Exit Sub

        _BBOTTLE_ACTIF = True

    Dim osqlcmdRestore As New SqlCommand("[api_sp_CertFluid_Bottle_Archive_Or_Restore]", MozartDatabase.cnxMozart)
    osqlcmdRestore.CommandType = CommandType.StoredProcedure
        osqlcmdRestore.Parameters.Add("@p_KEY_BOTTLE_UNIQUE", SqlDbType.NVarChar, 40).Value = _KEY_BOTTLE_UNIQUE
        osqlcmdRestore.Parameters.Add("@p_BBOTTLE_ACTIF", SqlDbType.Bit).Value = _BBOTTLE_ACTIF

        osqlcmdRestore.ExecuteNonQuery()

    End Sub


End Class
