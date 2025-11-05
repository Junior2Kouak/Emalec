Imports System.Data.SqlClient
Imports MozartLib

Public Class frmTableauLanguePer

  Dim DtData As DataTable

  Private Sub frmTableauLanguePer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    DtData = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListePersByCompetenceLangue]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = MozartParams.NomSociete
    DtData.Load(sqlcmd.ExecuteReader)

    PvtGridCompetence.DataSource = DtData


  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

End Class