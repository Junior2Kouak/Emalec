Imports System.Data.SqlClient
Imports MozartLib

Public Class CCLI_TECH

  Dim _DTCLI_TECH As DataTable
  Dim _NID As Int32
  Dim _Type As String

  Dim _sNomForm As String

  Public ReadOnly Property sNomForm As String
    Get
      Return _sNomForm
    End Get
  End Property

  Public Property DTCLI_TECH As DataTable
    Get
      Return _DTCLI_TECH
    End Get
    Set(value As DataTable)
      _DTCLI_TECH = value
    End Set
  End Property

  Public Sub New(ByVal c_Type As String, ByVal c_NID As Int32)

    _NID = c_NID
    _Type = c_Type

    'on charge le dernier contrat du client
    LoadData()

  End Sub

  Public Sub LoadData()

    _DTCLI_TECH = New DataTable

    'on récuper le nom
    Dim osqlcmdRead As New SqlCommand("")
    Select Case _Type

      Case "C"
        osqlcmdRead = New SqlCommand(String.Format("SELECT VCLINOM FROM TCLI WITH (NOLOCK) WHERE TCLI.NCLINUM = {0}", _NID), MozartDatabase.cnxMozart)
        osqlcmdRead.CommandType = CommandType.Text
            Case "T"
        osqlcmdRead = New SqlCommand(String.Format("SELECT VPERNOM + ' ' + TPER.VPERPRE AS VPERNOM FROM TPER WITH (NOLOCK) WHERE TPER.NPERNUM = {0}", _NID), MozartDatabase.cnxMozart)
        osqlcmdRead.CommandType = CommandType.Text

        End Select

        _sNomForm = osqlcmdRead.ExecuteScalar()


        Select Case _Type

            Case "C"
        osqlcmdRead = New SqlCommand("[api_sp_ListeTechnicienByClient]", MozartDatabase.cnxMozart)
        osqlcmdRead.CommandType = CommandType.StoredProcedure
                osqlcmdRead.Parameters.Add("@p_NCLINUM", SqlDbType.Int).Value = _NID
            Case "T"
        osqlcmdRead = New SqlCommand("[api_sp_ListeClientByTehnicien]", MozartDatabase.cnxMozart)
        osqlcmdRead.CommandType = CommandType.StoredProcedure
                osqlcmdRead.Parameters.Add("@p_NPERNUM", SqlDbType.Int).Value = _NID
        End Select

        _DTCLI_TECH.Load(osqlcmdRead.ExecuteReader)

        _DTCLI_TECH.Columns("BCLITECHCOCHE").ReadOnly = False

    End Sub

    Public Sub SaveTechnicien()

        Try

            If Not _DTCLI_TECH Is Nothing AndAlso Not _DTCLI_TECH.GetChanges(DataRowState.Modified) Is Nothing Then

                For Each oDtrSave As DataRow In _DTCLI_TECH.GetChanges(DataRowState.Modified).Rows

                    AffecterTechnicien(oDtrSave.Item("NPERNUM"), oDtrSave.Item("NCLINUM"), oDtrSave.Item("BCLITECHCOCHE"))

                Next

            End If

            _DTCLI_TECH.AcceptChanges()

        Catch ex As Exception

            MessageBox.Show("CCLI_TECH dans SaveTechnicien : " + ex.Message)

        End Try

    End Sub

    Private Sub AffecterTechnicien(ByVal P_NPERNUM As Int32, ByVal P_NCLINUM As Int32, ByVal P_BAFFECTE As Int32)

        Try

      Dim sqlcmdAffectTech As New SqlCommand("[api_sp_CreateTechnicienClient]", MozartDatabase.cnxMozart)
      sqlcmdAffectTech.CommandType = CommandType.StoredProcedure

            sqlcmdAffectTech.Parameters.Add("@P_NPERNUM", SqlDbType.Int)
            sqlcmdAffectTech.Parameters("@P_NPERNUM").Value = P_NPERNUM

            sqlcmdAffectTech.Parameters.Add("@P_NCLINUM", SqlDbType.Int)
            sqlcmdAffectTech.Parameters("@P_NCLINUM").Value = P_NCLINUM

            sqlcmdAffectTech.Parameters.Add("@p_BAFFECTE", SqlDbType.Int)
            sqlcmdAffectTech.Parameters("@p_BAFFECTE").Value = P_BAFFECTE

            sqlcmdAffectTech.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show("CCLI_TECH dans AffecterTechnicien : " + ex.Message)

        End Try

    End Sub

End Class
