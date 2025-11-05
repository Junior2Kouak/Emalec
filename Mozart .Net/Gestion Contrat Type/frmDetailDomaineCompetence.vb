Imports System.Data.SqlClient
Imports MozartLib

Public Class frmDetailDomaineCompetence

  Dim NIDDOM_COMPET As Int32
  Dim bActif As Boolean

  Public Sub New(ByVal o_NIDDOM_COMPET As Int32, ByVal o_VLIBDOM_COMPET As String, ByVal o_bActif As Boolean)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    NIDDOM_COMPET = o_NIDDOM_COMPET
    TxtLibelleDomaine.Text = o_VLIBDOM_COMPET
    bActif = o_bActif

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub BtnEnregistrer_Click(sender As System.Object, e As System.EventArgs) Handles BtnEnregistrer.Click

    If TxtLibelleDomaine.Text = "" Then

      MessageBox.Show(My.Resources.GestionContrat_type_frmDetailDomaineTech_nomDomaine, My.Resources.GestionContrat_type_frmDetailDomaineTech_nomDomaine_erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub

    End If

    Dim sqlcmdSave As New SqlCommand("[api_sp_GestDomaineCompetence_Save]", MozartDatabase.cnxMozart)
    sqlcmdSave.CommandType = CommandType.StoredProcedure
    sqlcmdSave.Parameters.Add("@P_NIDDOM_COMPET", SqlDbType.Int).Value = NIDDOM_COMPET
    sqlcmdSave.Parameters.Add("@P_VLIBDOM_COMPET", SqlDbType.VarChar).Value = TxtLibelleDomaine.Text
    sqlcmdSave.Parameters.Add("@P_ACTIF", SqlDbType.Bit).Value = bActif
    sqlcmdSave.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = MozartParams.NomSociete

    sqlcmdSave.ExecuteNonQuery()

    Me.Close()

  End Sub

End Class