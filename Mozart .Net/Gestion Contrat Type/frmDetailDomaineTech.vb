Imports System.Data.SqlClient
Imports MozartLib

Public Class frmDetailDomaineTech

  Dim iNCONTDOMNUM As Int32
  Dim sLangue As String

  Public Sub New(ByVal o_NCONTDOMNUM As Int32, ByVal o_VCONTDOMLIB As String, ByVal o_Langue As String)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNCONTDOMNUM = o_NCONTDOMNUM
    sLangue = o_Langue
    TxtLibelleDomaine.Text = o_VCONTDOMLIB

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub BtnEnregistrer_Click(sender As System.Object, e As System.EventArgs) Handles BtnEnregistrer.Click

    If TxtLibelleDomaine.Text = "" Then

      MessageBox.Show(My.Resources.GestionContrat_type_frmDetailDomaineTech_nomDomaine, My.Resources.GestionContrat_type_frmDetailDomaineTech_nomDomaine_erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub

    End If

    Dim sqlcmdSave As SqlCommand

    If iNCONTDOMNUM = 0 Then

      sqlcmdSave = New SqlCommand("api_sp_CreationGestDomaine", MozartDatabase.cnxMozart)
      sqlcmdSave.CommandType = CommandType.StoredProcedure
            sqlcmdSave.Parameters.Add("@P_VCONTDOMLIB", SqlDbType.VarChar).Value = TxtLibelleDomaine.Text

            sqlcmdSave.ExecuteNonQuery()

        Else

      sqlcmdSave = New SqlCommand("api_sp_GestionDomaineSaveLibelle", MozartDatabase.cnxMozart)
      sqlcmdSave.CommandType = CommandType.StoredProcedure
            sqlcmdSave.Parameters.Add("@P_NCONTDOMNUM", SqlDbType.Int).Value = iNCONTDOMNUM
            sqlcmdSave.Parameters.Add("@P_VCONTDOMLIB", SqlDbType.VarChar).Value = TxtLibelleDomaine.Text
            sqlcmdSave.Parameters.Add("@P_LANGUE", SqlDbType.Char).Value = sLangue

            sqlcmdSave.ExecuteNonQuery()

        End If

        Me.Close()

    End Sub

End Class