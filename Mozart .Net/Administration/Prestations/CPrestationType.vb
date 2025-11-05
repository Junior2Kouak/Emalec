Imports System.Data.SqlClient
Imports MozartLib

Public Class CPrestationType

  Dim _DtListeType As DataTable

  Public ReadOnly Property DtListeType As DataTable
    Get
      Return _DtListeType
    End Get

  End Property

  Public Sub New()

    LoadData()

  End Sub

  Private Sub LoadData()

    _DtListeType = New DataTable

    Dim sqlcmd As New SqlCommand("SELECT NPREST_TYPE_ID, VPREST_TYPE_LIB FROM TREF_PREST_TYPE WITH (NOLOCK) WHERE BPREST_ACTIF = 1 ORDER BY VPREST_TYPE_LIB", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
        _DtListeType.Load(sqlcmd.ExecuteReader())

    End Sub

End Class
