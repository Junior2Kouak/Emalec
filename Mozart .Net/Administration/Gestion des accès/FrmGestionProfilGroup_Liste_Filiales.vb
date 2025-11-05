Imports System.Data.SqlClient
Imports MozartLib

Public Class FrmGestionProfilGroup_Liste_Filiales

  Dim _bCancel As Boolean = False
  Dim _NIDPROFIL As Int32
  Dim _VSOC_SRC As String
  Dim _VTYPEPERDETAIL As String

  Dim _Mode As Int32  '0: non configuré pour le moment

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

  Public Sub New(ByVal c_NIDPROFIL As Int32, ByVal c_VTYPEPERDETAIL As String, ByVal c_VSOC_SRC As String, ByVal c_Mode As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NIDPROFIL = c_NIDPROFIL
    _VSOC_SRC = c_VSOC_SRC
    _VTYPEPERDETAIL = c_VTYPEPERDETAIL
    _Mode = c_Mode

  End Sub

  Private Sub FrmGestionProfilGroup_Liste_Filiales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Select Case _Mode
      Case 0
        LblTitre.Text = String.Format("Copier le profil de {0} vers les filiales sélectionnées ci-dessous :", _VTYPEPERDETAIL + " - " + _VSOC_SRC)
    End Select

    LoadData()

  End Sub

  Private Sub LoadData()

    Dim sqlcmd As SqlCommand

    _DtListeFiliales = New DataTable

    Select Case _Mode
      Case 0

        sqlcmd = New SqlCommand("[api_sp_ProfilTypeCopy_ListeFiliales]", MozartDatabase.cnxMozart)
        sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.Add("@P_NIDPROFIL", SqlDbType.Int).Value = _NIDPROFIL
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
        Me.Close()
    End Sub
End Class