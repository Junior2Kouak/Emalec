Imports System.Data.SqlClient
Imports MozartLib

Public Class CGestDocDetail

  Dim _ID As Int32
  'Dim _NUMERO As String
  Dim _sType As String
  'Dim _VFORMAT As String
  Dim _TITRE As String
  Dim _VFICTECH As String
  Dim _DDATEPUB As Date
  Dim _CACTIF As String

  Public ReadOnly Property ID As Int32
    Get
      Return _ID
    End Get
  End Property

  Public ReadOnly Property sType As String
    Get
      Return _sType
    End Get
  End Property

  Public Property TITRE As String
    Get
      Return _TITRE
    End Get
    Set(ByVal value As String)
      _TITRE = value
    End Set
  End Property

  Public Property VFICTECH As String
    Get
      Return _VFICTECH
    End Get
    Set(ByVal value As String)
      _VFICTECH = value
    End Set
  End Property

  Public Property DDATEPUB As Date
    Get
      Return _DDATEPUB
    End Get
    Set(ByVal value As Date)
      _DDATEPUB = value
    End Set
  End Property

  Public Property CACTIF As String
    Get
      Return _CACTIF
    End Get
    Set(ByVal value As String)
      _CACTIF = value
    End Set
  End Property

  Public Sub New(ByVal c_sType As String, Optional ByVal c_NID As Int32 = 0)

    _ID = c_NID
    _sType = c_sType

    If _ID > 0 Then

      LoadData()

    Else

      _ID = 0
      _TITRE = ""
      _VFICTECH = ""
      _DDATEPUB = Nothing
      _CACTIF = "O"

    End If


  End Sub

  Private Sub LoadData()

    Try

      Dim sqlcmd As New SqlCommand("[api_sp_DetGestDocDetail]", MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.StoredProcedure
      sqlcmd.Parameters.Add("@P_ID", SqlDbType.Int).Value = _ID

      Dim sqldr As SqlDataReader = sqlcmd.ExecuteReader

      If sqldr.HasRows Then

        While sqldr.Read

          _TITRE = sqldr.Item("TITRE")
          _VFICTECH = sqldr.Item("VFICTECH")
          _DDATEPUB = sqldr.Item("DDATEPUB")
          _CACTIF = sqldr.Item("CACTIF")

        End While

      End If

      If sqldr.IsClosed = False Then sqldr.Close()

    Catch ex As Exception

      MessageBox.Show("LoadData dans CGestDocDetail : " + ex.Message)

    End Try

  End Sub

  Public Sub AddDocument(ByVal p_TITRE As String, ByVal p_VFICTECH As String, ByVal p_DDATEPUB As Date)

    Try

      Dim sqlcmd As New SqlCommand("[api_sp_creationFicheTech]", MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.StoredProcedure
      sqlcmd.Parameters.Add("@iNumFicheTech", SqlDbType.Int).Value = _ID
      sqlcmd.Parameters.Add("@vTitre", SqlDbType.VarChar).Value = p_TITRE
      sqlcmd.Parameters.Add("@vtype", SqlDbType.VarChar).Value = _sType
      sqlcmd.Parameters.Add("@vformat", SqlDbType.Char).Value = Path.GetExtension(p_VFICTECH).Replace(".", "")
      sqlcmd.Parameters.Add("@vFicTech", SqlDbType.VarChar).Value = If(_VFICTECH <> p_VFICTECH, "temp", p_VFICTECH)
      sqlcmd.Parameters.Add("@date", SqlDbType.DateTime).Value = p_DDATEPUB
      sqlcmd.Parameters.Add("@vserie", SqlDbType.VarChar).Value = ""

      If _ID = 0 Then
        _ID = Convert.ToInt32(sqlcmd.ExecuteScalar())
      Else
        sqlcmd.ExecuteScalar()
      End If

      'on copie le fichier si nouveau fichier
      If (_VFICTECH <> p_VFICTECH) Then

        File.Copy(p_VFICTECH, MozartParams.CheminFicheTech & _ID.ToString & "_" & FormatFileNameAuthorized(p_TITRE) & Path.GetExtension(p_VFICTECH), True)

        sqlcmd = New SqlCommand(String.Format("UPDATE TFICHETECH SET VFICTECH = '{0}' WHERE ID = {1}", _ID.ToString & "_" & FormatFileNameAuthorized(p_TITRE) & Path.GetExtension(p_VFICTECH), _ID), MozartDatabase.cnxMozart)
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.ExecuteNonQuery()

      End If

    Catch ex As Exception

      MessageBox.Show("AddDocument dans CGestionDocDetail : " + ex.Message)

    End Try

  End Sub

End Class
