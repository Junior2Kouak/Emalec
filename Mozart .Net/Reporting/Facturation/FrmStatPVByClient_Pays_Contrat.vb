Imports System.Data.SqlClient
Imports MozartLib

Public Class FrmStatPVByClient_Pays_Contrat

  Dim Dt_Data As DataTable

  Private Sub FrmStatPVByClient_Pays_Contrat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadData()

  End Sub

  Private Sub LoadData()

    Dt_Data = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListePrixCliTypCont_All]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        Dt_Data.Load(sqlcmd.ExecuteReader())

        GCStat.DataSource = Dt_Data


    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click

        Me.Close()

    End Sub
End Class