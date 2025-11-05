Imports System.Data.SqlClient
Imports MozartLib

Public Class FrmGestionProfilGroup_Liste_Person

  Dim _bCancel As Boolean = False
  Dim _NPERNUM As Int32
  Dim _VPERNOM As String
  Dim _DtListePerson As DataTable

  Public ReadOnly Property Cancel As Boolean
    Get
      Cancel = _bCancel
    End Get
  End Property

  Public Sub New(ByVal c_DTSrc As DataTable, ByVal C_VPERNOM As String, ByVal C_NPERNUM As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _DtListePerson = c_DTSrc
    _NPERNUM = C_NPERNUM
    _VPERNOM = C_VPERNOM
    LblTitre.Text = $"Copier le profil de {_VPERNOM} vers les personnes sélectionnées ci-dessous :"

  End Sub

  Private Sub FrmGestionProfilGroup_Liste_Person_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    _bCancel = True

    GCPers.DataSource = _DtListePerson

  End Sub

  Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
    _bCancel = True
    Me.Close()
  End Sub

  Private Sub BtnValid_Click(sender As Object, e As EventArgs) Handles BtnValid.Click

    If GVPers.SelectedRowsCount > 0 Then

      If MessageBox.Show($"Voulez-vous vraiment copier le profil de {_VPERNOM} vers le(s) personne(s) sélectionnée(s) ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

        For Each HdlRow As Int32 In GVPers.GetSelectedRows()

          Dim sqlcmdexe As New SqlCommand("[api_sp_CopyDroitSerieFOMOZART]", MozartDatabase.cnxMozart)
          sqlcmdexe.CommandType = CommandType.StoredProcedure
          sqlcmdexe.Parameters.Add("@P_NPERNUM_SRC", SqlDbType.Int).Value = _NPERNUM
          sqlcmdexe.Parameters.Add("@P_NPERNUM_DEST", SqlDbType.Int).Value = GVPers.GetRowCellValue(HdlRow, GCol_NPERNUM)

          sqlcmdexe.ExecuteNonQuery()

        Next

        _bCancel = False

        MessageBox.Show($"La copie des droits de fournitures du profil de {_VPERNOM} vers le(s) personne(s) sélectionnée(s) a été réalisée avec succès", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

      End If

    End If

    Me.Close()
  End Sub
End Class