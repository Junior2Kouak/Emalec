Imports System.Data.SqlClient
Imports MozartLib

Public Class FrmCopyProfilType

  Dim dtSrc As DataTable
  Dim dtDest As DataTable

  Dim _NIDPROFIL_SRC As Int32
  Dim _VSOCIETE As String

  Public Sub New(ByVal c_VSOCIETE As String, Optional ByVal c_NIDPROFIL_SRC As Int32 = 0)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NIDPROFIL_SRC = c_NIDPROFIL_SRC
    _VSOCIETE = c_VSOCIETE

  End Sub

  Private Sub FrmCopyProfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadData()

    GLU_Src.Properties.DataSource = dtSrc
    GLU_DEST.Properties.DataSource = dtSrc

    If _NIDPROFIL_SRC > 0 Then GLU_Src.EditValue = _NIDPROFIL_SRC

  End Sub

  Private Sub LoadData()

    dtSrc = New DataTable
    dtDest = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ProfilTypeListe]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        dtSrc.Load(sqlcmd.ExecuteReader)
        dtDest = dtSrc

    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click

        If GLU_Src.EditValue = Nothing Then
            MessageBox.Show("Il faut sélectionné le profil source", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If GLU_DEST.EditValue = Nothing Then
            MessageBox.Show("Il faut sélectionné le profil destinataire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If GLU_Src.EditValue = GLU_DEST.EditValue Then
            MessageBox.Show("Copie Impossible " & vbCrLf & "Les profils sélectionnés sont identiques", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show(String.Format("Voulez-vous copier le profil de {0} vers le profil de  {1} ?", GLU_Src.Text, GLU_DEST.Text), "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      Dim sqlcmdcopy As New SqlCommand("[api_sp_CopyProfilTypeDroit]", MozartDatabase.cnxMozart)
      sqlcmdcopy.CommandType = CommandType.StoredProcedure
            sqlcmdcopy.Parameters.Add("@P_NID_REF_TYPEPERDETAIL_SRC", SqlDbType.Int).Value = GLU_Src.EditValue
            sqlcmdcopy.Parameters.Add("@P_NID_REF_TYPEPERDETAIL_DEST", SqlDbType.Int).Value = GLU_DEST.EditValue
            sqlcmdcopy.ExecuteNonQuery()

            MessageBox.Show("le profil a été copié avec succès", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        End If

    End Sub

End Class