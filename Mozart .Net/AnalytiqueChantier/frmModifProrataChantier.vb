Imports System.Data.SqlClient
Imports MozartLib

Public Class frmModifProrataChantier

  Dim NIDCHANTIER As Int32
  Dim NPCPRORATA As Decimal

  Public Sub New(ByVal C_NIDCHANTIER As Int32, ByVal C_NPCPRORATA As Decimal)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    NIDCHANTIER = C_NIDCHANTIER
    NPCPRORATA = C_NPCPRORATA

  End Sub

  Private Sub frmModifProrataChantier_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    SpinPRPRORATA.Value = NPCPRORATA

  End Sub

  Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click

    Me.Close()

  End Sub

  Private Sub BtnOK_Click(sender As System.Object, e As System.EventArgs) Handles BtnOK.Click

    Try

      Dim sqlcmdUpdate As New SqlCommand("api_sp_ChantierMiseAjourProrata", MozartDatabase.cnxMozart)
      sqlcmdUpdate.CommandType = CommandType.StoredProcedure
            sqlcmdUpdate.Parameters.Add("@P_NIDCHANTIER", SqlDbType.Int).Value = NIDCHANTIER
            sqlcmdUpdate.Parameters.Add("@P_NPCPRORATA", SqlDbType.Decimal).Value = SpinPRPRORATA.Value
            sqlcmdUpdate.ExecuteNonQuery()
            sqlcmdUpdate.Dispose()

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(My.Resources.Admin_frmModifProrataChantier_BtnOk & ex.Message, My.Resources.Global_Erreur)

        End Try

    End Sub

    Private Sub LblTitre_Click(sender As Object, e As EventArgs) Handles LblTitre.Click

    End Sub
End Class