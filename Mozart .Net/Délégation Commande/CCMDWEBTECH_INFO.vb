Imports System.Data.SqlClient
Imports MozartLib
Public Class CCMDWEBTECH_INFO

  Dim _NCMDWEBNUM As Int32
  Dim _DCMDWEBTECH_INFO_CREE As DateTime?
  Dim _VTECHNOM As String
  Dim _VMESSAGE As String
  Dim _CLIEU_LIVR As String
  Dim _DDATELIVR As DateTime?
  Dim _BMESSAGEVU As Boolean
  Dim _NQUIVALID As Int32
  Dim _DQUIVALID As DateTime?
  Dim _NPERNUM_DEMAND As Int32
  Dim _CCMDWEB_INFO_ETAT As String
  Dim _VSOCIETE As String

  Public ReadOnly Property NCMDWEBNUM As Int32
    Get
      NCMDWEBNUM = _NCMDWEBNUM
    End Get
  End Property

  Public Property NQUIVALID As Int32
    Get
      NQUIVALID = _NQUIVALID
    End Get
    Set(value As Int32)
      _NQUIVALID = value
    End Set
  End Property

  Public Property DQUIVALID As DateTime?
    Get
      DQUIVALID = _DQUIVALID
    End Get
    Set(value As DateTime?)
      _DQUIVALID = value
    End Set
  End Property
  Public Property VMESSAGE As String
    Get
      VMESSAGE = _VMESSAGE
    End Get
    Set(value As String)
      _VMESSAGE = value
    End Set
  End Property
  Public Property CLIEU_LIVR As String
    Get
      CLIEU_LIVR = _CLIEU_LIVR
    End Get
    Set(value As String)
      _CLIEU_LIVR = value
    End Set
  End Property
  Public Property DDATELIVR As DateTime?
    Get
      DDATELIVR = _DDATELIVR
    End Get
    Set(value As DateTime?)
      _DDATELIVR = value
    End Set
  End Property
  Public Property BMESSAGEVU As Boolean
    Get
      BMESSAGEVU = _BMESSAGEVU
    End Get
    Set(value As Boolean)
      _BMESSAGEVU = value
    End Set
  End Property
  Public Property DCMDWEBTECH_INFO_CREE As DateTime?
    Get
      DCMDWEBTECH_INFO_CREE = _DCMDWEBTECH_INFO_CREE
    End Get
    Set(value As DateTime?)
      _DCMDWEBTECH_INFO_CREE = value
    End Set
  End Property
  Public Property NPERNUM_DEMAND As Int32
    Get
      NPERNUM_DEMAND = _NPERNUM_DEMAND
    End Get
    Set(value As Int32)
      _NPERNUM_DEMAND = value
    End Set
  End Property
  Public Property CCMDWEB_INFO_ETAT As String
    Get
      CCMDWEB_INFO_ETAT = _CCMDWEB_INFO_ETAT
    End Get
    Set(value As String)
      _CCMDWEB_INFO_ETAT = value
    End Set
  End Property
  Public Property VSOCIETE As String
    Get
      VSOCIETE = _VSOCIETE
    End Get
    Set(value As String)
      _VSOCIETE = value
    End Set
  End Property
  Public Property VTECHNOM As String
    Get
      VTECHNOM = _VTECHNOM
    End Get
    Set(value As String)
      _VTECHNOM = value
    End Set
  End Property

  Public Sub New(ByVal c_NCMDWEBNUM As Int32)

    _NCMDWEBNUM = c_NCMDWEBNUM

    'INIT
    _NQUIVALID = 0
    _DQUIVALID = Nothing
    _VMESSAGE = ""
    _CLIEU_LIVR = ""
    _DDATELIVR = Nothing
    _BMESSAGEVU = False
    _DCMDWEBTECH_INFO_CREE = Nothing
    _NPERNUM_DEMAND = 0
    _CCMDWEB_INFO_ETAT = ""
    _VTECHNOM = ""
    _VSOCIETE = ""

    LoadData()

  End Sub

  Private Sub LoadData()

    Dim sqlcmd As New SqlCommand("[api_sp_CommandeReapproTechDetail_Info]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_NCMDWEBTECH", SqlDbType.Int).Value = _NCMDWEBNUM

        Dim sqldr As SqlDataReader = sqlcmd.ExecuteReader
        If sqldr.HasRows Then

            While sqldr.Read()

                _NCMDWEBNUM = sqldr.Item("NCMDWEBNUM")
                _NQUIVALID = sqldr.Item("NQUIVALID")
                _DQUIVALID = If(sqldr.Item("DQUIVALID") Is DBNull.Value, Nothing, CDate(sqldr.Item("DQUIVALID")))
                _VMESSAGE = sqldr.Item("VMESSAGE")
                _CLIEU_LIVR = sqldr.Item("CLIEU_LIVR")
                _DDATELIVR = sqldr.Item("DDATELIVR")
                _BMESSAGEVU = sqldr.Item("BMESSAGEVU")
                _DCMDWEBTECH_INFO_CREE = sqldr.Item("DCMDWEBTECH_INFO_CREE")
                _NPERNUM_DEMAND = sqldr.Item("NPERNUM_DEMAND")
                _CCMDWEB_INFO_ETAT = sqldr.Item("CCMDWEB_INFO_ETAT")
                _VTECHNOM = sqldr.Item("VTECHNOM")
                _VSOCIETE = sqldr.Item("VSOCIETE")

            End While

        End If
        sqldr.Close()

        'modification date livraison so date livraison < à J+4
        If _DDATELIVR < Now.Date.AddDays(4) Then _DDATELIVR = Now.Date.AddDays(4)

    End Sub

End Class
