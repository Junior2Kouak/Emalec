Imports System.Data.SqlClient
Imports MozartLib



Public Class frmGestAccidentTrav


  Dim dt As DataTable

  Private Sub frmGestAccidentTrav_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Initboutons(Me)

    LoadData()

  End Sub

  Private Sub LoadData()

    Try

      dt = New DataTable
      dt = ModDataGridView.LoadList("[api_sp_AccidentTrav_Liste]", MozartDatabase.cnxMozart)
      GCListeAccident.DataSource = dt

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

    Dim oAccidentTrav As New CACCIDENT_TRAV(0)

    Dim ofrmAccidentTrav_Detail As New frmAccidentTrav_Detail(oAccidentTrav)
    ofrmAccidentTrav_Detail.ShowDialog()

    LoadData()

  End Sub

  Private Sub BtnDetails_Click(sender As Object, e As EventArgs) Handles BtnDetails.Click

    If (dt.Rows.Count = 0) Then Exit Sub

    Dim row As DataRow = GVListeAccident.GetFocusedDataRow()
    If row Is Nothing Then Exit Sub

    Dim oAccidentTrav As New CACCIDENT_TRAV(row.Item("NACCIDENTID"))

    Dim ofrmAccidentTrav_Detail As New frmAccidentTrav_Detail(oAccidentTrav)
    ofrmAccidentTrav_Detail.ShowDialog()

    LoadData()

  End Sub

  Private Sub BtnSupp_Click(sender As Object, e As EventArgs) Handles BtnSupp.Click
    If (dt.Rows.Count = 0) Then Exit Sub

    Dim row As DataRow = GVListeAccident.GetFocusedDataRow()
    If row Is Nothing Then Exit Sub

    If MessageBox.Show("Voulez-vous supprimer cette ligne ?", My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

      Dim oAccidentTrav As New CACCIDENT_TRAV(row.Item("NACCIDENTID"))
      oAccidentTrav.Delete()

      LoadData()

    End If

  End Sub

End Class