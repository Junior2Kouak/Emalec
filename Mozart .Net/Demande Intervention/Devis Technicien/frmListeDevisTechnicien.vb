Imports System.Data.SqlClient
Imports MozartLib

Public Class frmListeDevisTechnicien

  Dim dtListeDevisTech As DataTable

  Private Sub frmListeDevisTechnicien_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try

      LoadData()


    Catch ex As SqlException
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub LoadData()

    dtListeDevisTech = New DataTable

    Dim cmd As New SqlCommand("[api_sp_DevisTech_Liste]", MozartDatabase.cnxMozart)
    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.Add("@p_NPERNUM", SqlDbType.Int).Value = MozartParams.UID
    dtListeDevisTech.Load(cmd.ExecuteReader)

    GCDevisTechListe.DataSource = dtListeDevisTech

  End Sub

  Private Sub BtnQuit_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuit.Click
    Me.Close()
  End Sub

  Private Sub btnAjouter_Click(sender As System.Object, e As System.EventArgs) Handles btnAjouter.Click

    Dim frmDevisTech As New frmDevisTechnicien(New CDEVISTECH(0, MozartParams.UID))
    frmDevisTech.ShowDialog()

    'refresh
    LoadData()


  End Sub

  Private Sub BtnModifier_Click(sender As System.Object, e As System.EventArgs) Handles BtnModifier.Click

    If GVDevisTechListe.FocusedRowHandle > -1 Then

      Dim frmDevisTech As New frmDevisTechnicien(New CDEVISTECH(GVDevisTechListe.GetDataRow(GVDevisTechListe.FocusedRowHandle).Item("NDEVISTECHNUM"), MozartParams.UID))
      frmDevisTech.ShowDialog()

      'refresh
      LoadData()

    Else
      MessageBox.Show("Il faut sélectionner un devis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If

  End Sub

  Private Sub BtnDeleteDevis_Click(sender As System.Object, e As System.EventArgs) Handles BtnDeleteDevis.Click

    If GVDevisTechListe.FocusedRowHandle > -1 Then

      If MessageBox.Show("Voulez-vous supprimer le devis technicien", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

        Dim oDevisTechForDel As New CDEVISTECH(GVDevisTechListe.GetDataRow(GVDevisTechListe.FocusedRowHandle).Item("NDEVISTECHNUM"), MozartParams.UID)
        oDevisTechForDel.DeleteDevisTech()

        'refresh
        LoadData()

      End If

      'refresh
      LoadData()

    Else
      MessageBox.Show("Il faut sélectionner un devis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If

  End Sub

  Private Sub BtnValid_Click(sender As System.Object, e As System.EventArgs) Handles BtnValid.Click
    If GVDevisTechListe.FocusedRowHandle > -1 Then

      If MessageBox.Show("Voulez-vous envoyer le devis technicien", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

        Dim oDevisTechForDel As New CDEVISTECH(GVDevisTechListe.GetDataRow(GVDevisTechListe.FocusedRowHandle).Item("NDEVISTECHNUM"), MozartParams.UID)
        oDevisTechForDel.SendDevisTech()

        'refresh
        LoadData()

      End If

    Else
      MessageBox.Show("Il faut sélectionner un devis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub
End Class