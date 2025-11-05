Imports System.Data.SqlClient
Imports MozartLib

Public Class FrmGestionAccessGroup_Liste_Filiales

  Dim _bCancel As Boolean = True
  Dim _VPERADSI As String
  Dim _VSOC_SRC As String

  Dim _NPERNUM As Int32
  Dim _NMENUNUM As Int32

  Dim _Mode As Int32  '0: liste des filiales ou la personne existe ; 1 : liste des filiales ou la personne n'existe pas, 2 : liste des filiales sur la meme société

  Dim _DtListeFiliales As DataTable

  Public ReadOnly Property Cancel As Boolean
    Get
      Cancel = _bCancel
    End Get
  End Property

  Public ReadOnly Property DtListeFiliales As DataTable
    Get
      DtListeFiliales = _DtListeFiliales
    End Get
  End Property

  Public Sub New(ByVal c_NPERNUM As Int32, ByVal c_VPERADSI As String, ByVal c_VSOC_SRC As String, ByVal c_Mode As Int32, Optional ByVal c_NMENUNUM As Int32 = 0)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NPERNUM = c_NPERNUM
    _VPERADSI = c_VPERADSI
    _VSOC_SRC = c_VSOC_SRC
    _Mode = c_Mode
    _NMENUNUM = c_NMENUNUM

  End Sub

  Private Sub FrmGestionAccessGroup_Liste_Filiales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Select Case _Mode
      Case 0
        LblTitre.Text = String.Format("Copier le profil de {0} vers les filiales sélectionnées ci-dessous :", _VPERADSI + " - " + _VSOC_SRC)
      Case 1
        LblTitre.Text = String.Format("Créer le profil de {0} vers les filiales sélectionnées ci-dessous :", _VPERADSI + " - " + _VSOC_SRC)
      Case 2
        LblTitre.Text = String.Format("Sélectionner les filiales pour le droit multi-sociétés : {0}", _VPERADSI + " - " + _VSOC_SRC)
      Case 3
        LblTitre.Text = String.Format("Sélectionner les filiales pour le droit multi-sociétés : {0}", _VPERADSI + " - " + _VSOC_SRC)
      Case 4
        LblTitre.Text = String.Format("Sélectionner les filiales dans laquelle le profil est à supprimer : {0}", _VPERADSI + " - " + _VSOC_SRC)
    End Select

    LoadData()

  End Sub

  Private Sub LoadData()

    Dim sqlcmd As SqlCommand

    _DtListeFiliales = New DataTable

    Select Case _Mode
      Case 0

        sqlcmd = New SqlCommand("[api_sp_DuplicateProfilMozart_ListeFiliales]", MozartDatabase.cnxMozart)
        sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.Add("@P_VPERADSI", SqlDbType.VarChar).Value = _VPERADSI
                sqlcmd.Parameters.Add("@P_VSOCIETE_SRC", SqlDbType.VarChar).Value = _VSOC_SRC
                _DtListeFiliales.Load(sqlcmd.ExecuteReader)

                _DtListeFiliales.Columns("NCOCHE").ReadOnly = False

            Case 1

        sqlcmd = New SqlCommand("[api_sp_CreateUserFiliale_ListeFiliales]", MozartDatabase.cnxMozart)
        sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.Add("@P_VPERADSI", SqlDbType.VarChar).Value = _VPERADSI
                _DtListeFiliales.Load(sqlcmd.ExecuteReader)

                _DtListeFiliales.Columns("NCOCHE").ReadOnly = False

            Case 2

        sqlcmd = New SqlCommand("[api_sp_GetDroitByProfilMozart_ListeFiliales]", MozartDatabase.cnxMozart)
        sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = _NPERNUM
                sqlcmd.Parameters.Add("@P_NMENUNUM", SqlDbType.Int).Value = _NMENUNUM
                sqlcmd.Parameters.Add("@P_VPERADSI", SqlDbType.VarChar).Value = _VPERADSI
                sqlcmd.Parameters.Add("@P_VSOCIETE_SRC", SqlDbType.VarChar).Value = _VSOC_SRC
                _DtListeFiliales.Load(sqlcmd.ExecuteReader)

                _DtListeFiliales.Columns("NCOCHE").ReadOnly = False

            Case 3

        sqlcmd = New SqlCommand("[api_sp_GetDroitSerieFOByProfilMozart_ListeFiliales]", MozartDatabase.cnxMozart)
        sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = _NPERNUM
                sqlcmd.Parameters.Add("@P_NMENUNUM", SqlDbType.Int).Value = _NMENUNUM
                sqlcmd.Parameters.Add("@P_VPERADSI", SqlDbType.VarChar).Value = _VPERADSI
                sqlcmd.Parameters.Add("@P_VSOCIETE_SRC", SqlDbType.VarChar).Value = _VSOC_SRC
                _DtListeFiliales.Load(sqlcmd.ExecuteReader)

                _DtListeFiliales.Columns("NCOCHE").ReadOnly = False

            Case 4

        sqlcmd = New SqlCommand("[api_sp_GetUserFilialeToDel_ListeFiliales]", MozartDatabase.cnxMozart)
        sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.Add("@P_VPERADSI", SqlDbType.VarChar).Value = _VPERADSI
                _DtListeFiliales.Load(sqlcmd.ExecuteReader)

                _DtListeFiliales.Columns("NCOCHE").ReadOnly = False

        End Select

        GCFiliales.DataSource = _DtListeFiliales

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        _bCancel = True
        Me.Close()
    End Sub

    Private Sub BtnValid_Click(sender As Object, e As EventArgs) Handles BtnValid.Click
        _bCancel = False
        Me.Close()
    End Sub
End Class