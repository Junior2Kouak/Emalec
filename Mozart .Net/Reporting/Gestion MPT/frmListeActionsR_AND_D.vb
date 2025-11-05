Imports System.Data.SqlClient
Imports MozartLib

Public Class frmListeActionsR_AND_D

  Dim DtData As DataTable

  Private Sub frmListeActionsR_AND_D_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Label4.Text = "Filiales : " & MozartParams.NomSociete

    DTP_Debut.Value = "01/01/" & Now.Year.ToString
    DTP_Fin.Value = Now

  End Sub

  Private Sub LoadData()

    DtData = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListeActionsR_And_D]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = MozartParams.NomSociete
    sqlcmd.Parameters.Add("@date_debut", SqlDbType.VarChar).Value = DTP_Debut.Value
    sqlcmd.Parameters.Add("@date_fin", SqlDbType.VarChar).Value = DTP_Fin.Value
    DtData.Load(sqlcmd.ExecuteReader)

    GCListeAct.DataSource = DtData

  End Sub

  Private Sub BtValider_Click(sender As Object, e As EventArgs) Handles BtValider.Click

    If DTP_Debut.Text = "" Or DTP_Fin.Text = "" Then
      MessageBox.Show("Il faut sélectionner une période", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If

    LoadData()

  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

End Class