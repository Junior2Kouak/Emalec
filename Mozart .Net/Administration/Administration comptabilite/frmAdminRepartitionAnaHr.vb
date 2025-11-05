Imports System.Data.SqlClient
Imports MozartLib

Public Class frmAdminRepartitionAnaHr

  Dim dt As DataTable

  Private Sub frmAdminRepartitionAnaHr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Initboutons(Me)

    LoadData()

  End Sub
  Private Sub LoadData()

    Try

      dt = New DataTable
      dt = ModDataGridView.LoadList("[api_sp_RepartAnaHr_Liste]", MozartDatabase.cnxMozart)
      GCListeHrAna.DataSource = dt

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub


  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

    Dim ofrmRepartAna_Pers_Detail As New frmAdminRepartitionAnaHrDetail(0)
    ofrmRepartAna_Pers_Detail.ShowDialog()

    LoadData()

  End Sub

  Private Sub BtnDetails_Click(sender As Object, e As EventArgs) Handles BtnDetails.Click

    If (dt.Rows.Count = 0) Then Exit Sub

    Dim row As DataRow = GVListeHrAna.GetFocusedDataRow()
    If row Is Nothing Then Exit Sub

    Dim ofrmRepartAna_Pers_Detail As New frmAdminRepartitionAnaHrDetail(row.Item("NPERNUM"))
    ofrmRepartAna_Pers_Detail.ShowDialog()

    LoadData()

  End Sub

  Private Sub BtnSupp_Click(sender As Object, e As EventArgs) Handles BtnSupp.Click
    If (dt.Rows.Count = 0) Then Exit Sub

    Dim row As DataRow = GVListeHrAna.GetFocusedDataRow()
    If row Is Nothing Then Exit Sub

    If MessageBox.Show("Voulez-vous supprimer la répartition de cette personne ?", My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

      Dim sqlcmd_save As New SqlCommand("[api_sp_RepartAnaHr_Delete]", MozartDatabase.cnxMozart)
      sqlcmd_save.CommandType = CommandType.StoredProcedure
      sqlcmd_save.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = row.Item("NPERNUM")

      sqlcmd_save.ExecuteNonQuery()

      LoadData()

    End If

  End Sub

  Private Sub BtnSave_Click(sender As Object, e As EventArgs)

    'verif si toutes les repartition sont = à 100 % pour chaque personne.
    'si pas le cas alors save impossible




  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    SFD.Filter = "Fichiers XLSX |*.XLSX"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then
      GCListeHrAna.ExportToXlsx(SFD.FileName)
    End If
  End Sub
End Class