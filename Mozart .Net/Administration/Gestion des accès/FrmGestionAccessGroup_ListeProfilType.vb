Imports System.Data.SqlClient
Imports MozartLib

Public Class FrmGestionAccessGroup_ListeProfilType

  Dim _bCancel As Boolean = True
  Dim _DtListeProfil As DataTable

  Public ReadOnly Property Cancel As Boolean
    Get
      Cancel = _bCancel
    End Get
  End Property

  Public ReadOnly Property DtListeProfil As DataTable
    Get
      DtListeProfil = _DtListeProfil
    End Get
  End Property

  Public Sub New(ByVal c_VNOMPERS As String)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    LblTitre.Text = String.Format("Appliquer les  profils suivant à {0} :", c_VNOMPERS)

  End Sub

  Private Sub FrmGestionAccessGroup_Liste_Filiales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadData()

  End Sub

  Private Sub LoadData()

    Dim sqlcmd As SqlCommand

    _DtListeProfil = New DataTable

    sqlcmd = New SqlCommand("[api_sp_ListeProfilTypeForApply]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        _DtListeProfil.Load(sqlcmd.ExecuteReader)
        _DtListeProfil.Columns("NCOCHE").ReadOnly = False

        GCProfils.DataSource = _DtListeProfil

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