Imports System.Data.SqlClient
Imports DevExpress.Data.Filtering
Imports MozartLib

Public Class frmListeInfoTablet

  Dim dtData As DataTable
  Private Sub frmListeInformatique_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    LoadData()

  End Sub

  Private Sub LoadData()

    Try

      Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("[api_sp_ListeTabletInfo]", MozartDatabase.cnxMozart) With {.CommandType = CommandType.StoredProcedure}
        dtData = New DataTable

        dtData.Load(CmdSql.ExecuteReader)
        GCListeTablet.DataSource = dtData

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmListeInformatique_SubLoad + ex.Message, My.Resources.Global_Erreur)
    Finally
      Cursor = Cursors.Default
    End Try

  End Sub
  Private Sub BtnFermer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnInfoTablet_Click(sender As Object, e As EventArgs) Handles BtnInfoTablet.Click

    If MessageBox.Show("Voulez-vous recharger les informations des tablettes affichées dans la liste ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      If dtData IsNot Nothing Then

        Dim LstFIltered As List(Of DataRow) = dtData.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(GVListeTablet.ActiveFilterCriteria)).ToList()

        If LstFIltered.Count > 0 Then

          For Each dr As DataRow In LstFIltered

            Dim CmdSql As New SqlCommand("update TTABLET_INFO set BRELOAD  = 1 where NTABLETNUM = " & dr.Item("NTABLETNUM") & " AND NPERNUM = " & dr.Item("NPERNUM"), MozartDatabase.cnxMozart)
            CmdSql.ExecuteNonQuery()

          Next
        End If

      Else
        MessageBox.Show("Il faut obligatoirement sélectionner une tablette !", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
    End If

  End Sub

  Private Sub ButtonImprimer_Click(sender As Object, e As EventArgs) Handles ButtonImprimer.Click

    SFD.FileName = "ListeTabletInfo" & Today.Year & Today.Month & Today.Day & ".xlsx"
    SFD.Filter = "Fichers EXCEL (*.xlsx) |*.xlsx"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then
      GCListeTablet.ExportToXlsx(SFD.FileName)
    End If

  End Sub
End Class