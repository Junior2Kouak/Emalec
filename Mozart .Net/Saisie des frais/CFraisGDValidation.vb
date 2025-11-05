Imports System.Data.SqlClient
Imports MozartLib

Public Class CFraisGDValidation

  Dim _dtSyntheseFraisJourGD As DataTable

  Dim _dtTypeRepas As DataTable

  Dim _bArchives As Boolean
  Dim _dDateDebut As Date
  Dim _dDateFin As Date
  Dim _npernum As Int32

#Region "Property"

  Public ReadOnly Property dtSyntheseFraisJourGD As DataTable

    Get
      dtSyntheseFraisJourGD = _dtSyntheseFraisJourGD
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

  Public Sub LoadFraisJourSynthGD()

    Try

      Dim sqlread As SqlCommand

      Select Case _bArchives
        Case True
          sqlread = New SqlCommand("api_sp_FraisJourListeGD_Archives", MozartDatabase.cnxMozart)
          sqlread.CommandType = CommandType.StoredProcedure
                    sqlread.Parameters.Add("@p_datedebut", SqlDbType.DateTime).Value = _dDateDebut
                    sqlread.Parameters.Add("@p_datefin", SqlDbType.DateTime).Value = _dDateFin
                    sqlread.Parameters.Add("@p_npernum", SqlDbType.Int).Value = _npernum

                Case Else
          sqlread = New SqlCommand("api_sp_FraisJourListeGD_A_Valider", MozartDatabase.cnxMozart)
          sqlread.CommandType = CommandType.StoredProcedure
                    sqlread.Parameters.Add("@p_npernum", SqlDbType.Int).Value = _npernum
            End Select

            _dtSyntheseFraisJourGD = New DataTable

            _dtSyntheseFraisJourGD.Load(sqlread.ExecuteReader())

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class

