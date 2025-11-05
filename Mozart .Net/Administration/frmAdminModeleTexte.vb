Imports MozartLib

Public Class frmAdminModeleTexte

  Private dtListe As DataTable
  Private sRequete As String


  Public Sub New()

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

  End Sub

  Private Sub frmAdminModeleTexte_Load(sender As Object, e As EventArgs) Handles Me.Load

    sRequete = $"exec api_sp_ModeleTexteListe {MozartParams.NomSociete}"
    LoadListe()

  End Sub

  Private Sub LoadListe()
    Try
      dtListe = MozartDatabase.GetDataTable(sRequete)
      GCListeModelText.DataSource = dtListe

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub BtnSupprimer_Click(sender As System.Object, e As EventArgs) Handles BtnSupprimer.Click
    Try

      If dtListe.Rows.Count = 0 Then
        Return
      End If

      If GVListeModelText.SelectedRowsCount < 0 Then
        MessageBox.Show(My.Resources.Global_selectionner_une_ligne, My.Resources.Global_suppresion_message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return
      End If

      ''mise à jour de la datatable
      If MessageBox.Show(My.Resources.Global_supression_ligne, My.Resources.Global_confirmation_suppression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
        ' suppression dans le tableau
        Dim IDligne As Int32 = GVListeModelText.GetDataRow(GVListeModelText.GetSelectedRows(0)).Item("NIDMODELTEXT")
        dtListe.Select("NIDMODELTEXT=" + IDligne.ToString)(0).Delete()
        ' suppression dans la base
        MozartDatabase.ExecuteNonQuery("delete from TMODELTEXT where NIDMODELTEXT = " & IDligne)

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub BtnDetail_Click(sender As System.Object, e As EventArgs) Handles BtnDetail.Click

    If dtListe.Rows.Count = 0 Then
      Return
    End If

    If GVListeModelText.SelectedRowsCount < 0 Then
      MessageBox.Show(My.Resources.Global_selectionner_une_ligne, My.Resources.Global_suppresion_message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return
    End If

    Dim datarow As DataRow = GVListeModelText.GetDataRow(GVListeModelText.GetSelectedRows(0))

    Dim oModeltextDetail As New frmDetailModeleTexte(Convert.ToInt32(datarow.Item("NIDMODELTEXT")))
    oModeltextDetail.ShowDialog()

    LoadListe()

  End Sub

  Private Sub BtnNew_Click(sender As System.Object, e As EventArgs) Handles BtnNew.Click

    Dim oModeltextDetail As New frmDetailModeleTexte(0)
    oModeltextDetail.ShowDialog()

    LoadListe()

  End Sub

End Class
