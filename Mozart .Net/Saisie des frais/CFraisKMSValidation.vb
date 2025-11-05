Imports System.Data.SqlClient
Imports MozartLib

Public Class CFraisKMSValidation

  Dim _dtSyntheseFraisJour As DataTable

  Dim _dtTypeRepas As DataTable

  Dim _bArchives As Boolean
  Dim _dDateDebut As Date
  Dim _dDateFin As Date
  Dim _npernum As Int32

#Region "Property"

  Public ReadOnly Property dtSyntheseFraisJour As DataTable

    Get
      dtSyntheseFraisJour = _dtSyntheseFraisJour
    End Get

  End Property

  Public ReadOnly Property dtTypeRepas As DataTable

    Get
      dtTypeRepas = _dtTypeRepas
    End Get

  End Property

  Public Property dDateDebut As Date
    Get
      dDateDebut = _dDateDebut
    End Get
    Set(value As Date)
      _dDateDebut = value
    End Set
  End Property

  Public Property dDateFin As Date
    Get
      dDateFin = _dDateFin
    End Get
    Set(value As Date)
      _dDateFin = value
    End Set
  End Property

  Public Property npernum As Int32
    Get
      npernum = _npernum
    End Get
    Set(value As Int32)
      _npernum = value
    End Set
  End Property

  Public Property bArchives As Boolean
    Get
      bArchives = _bArchives
    End Get
    Set(value As Boolean)
      _bArchives = value
    End Set
  End Property

#End Region

  Public Sub LoadFraisJourSynthSem()

    Try

      Dim sqlread As SqlCommand

      Select Case _bArchives
        Case True
          sqlread = New SqlCommand("api_sp_FraisJourListe_Archives", MozartDatabase.cnxMozart)
          sqlread.CommandType = CommandType.StoredProcedure
                    sqlread.Parameters.Add("@p_datedebut", SqlDbType.DateTime).Value = _dDateDebut
                    sqlread.Parameters.Add("@p_datefin", SqlDbType.DateTime).Value = _dDateFin
                    sqlread.Parameters.Add("@p_npernum", SqlDbType.Int).Value = _npernum

                Case Else
          sqlread = New SqlCommand("api_sp_FraisJourListe_A_Valider", MozartDatabase.cnxMozart)
          sqlread.CommandType = CommandType.StoredProcedure
                    sqlread.Parameters.Add("@p_npernum", SqlDbType.Int).Value = _npernum
            End Select

            _dtSyntheseFraisJour = New DataTable

            _dtSyntheseFraisJour.Load(sqlread.ExecuteReader())

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    '***************************************************************************************************************
    'Permet de verifer si le technicien a bien valider l'envoi de ses journées précédente
    '***************************************************************************************************************
    'Public Function Verif_ValidIsOk(ByVal p_DateFin As DateTime) As Boolean

    '    Try

    '        Dim bNFRAISNONVALID As Boolean = True
    '        Dim sqlread As New SqlCommand("api_sp_FraisJourValidIsOK", cnx)
    '        Dim drread As SqlDataReader
    '        sqlread.CommandType = CommandType.StoredProcedure
    '        sqlread.Parameters.Add("@P_DATEFIN", SqlDbType.DateTime).Value = p_DateFin
    '        sqlread.CommandType = CommandType.StoredProcedure

    '        drread = sqlread.ExecuteReader()

    '        drread.Read()
    '        If drread.Item("NFRAISVALID") > 0 Then bNFRAISNONVALID = False

    '        drread.Close()

    '        Return bNFRAISNONVALID

    '    Catch ex As Exception

    '        MessageBox.Show("Erreur Verif_ValidIsOk() dans CFraisJourSyntheseSem " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False

    '    End Try

    'End Function

    '***************************************************************************************************************
    'Permet de verifer si le technicien peut annuler le pret pour envoi  dune journée
    '***************************************************************************************************************
    'Public Function Verif_CancelValidIsOk(ByVal p_DateFin As DateTime) As Boolean

    '    Try

    '        Dim bNFRAISCANCELVALID As Boolean = True
    '        Dim sqlread As New SqlCommand("api_sp_FraisJourCancelValidIsOK", cnx)
    '        Dim drread As SqlDataReader
    '        sqlread.CommandType = CommandType.StoredProcedure
    '        sqlread.Parameters.Add("@P_DATEFIN", SqlDbType.DateTime).Value = p_DateFin
    '        sqlread.CommandType = CommandType.StoredProcedure

    '        drread = sqlread.ExecuteReader()

    '        drread.Read()
    '        If drread.Item("NFRAISCANCELVALID") > 0 Then bNFRAISCANCELVALID = False

    '        drread.Close()

    '        Return bNFRAISCANCELVALID

    '    Catch ex As Exception

    '        MessageBox.Show("Erreur Verif_CancelValidIsOk() dans CFraisJourSyntheseSem " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False

    '    End Try

    'End Function

End Class

