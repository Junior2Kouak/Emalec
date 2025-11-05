Imports System.Data.SqlClient
Imports MozartLib

Public Class frmStatMagasinDelaisEtalonnage

  Dim DtStatEtalonnage As DataTable

  Private Sub frmStatMagasinDelaisEtalonnage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Initboutons(Me)


    DtStatEtalonnage = New DataTable

    Dim CmdSql As New SqlCommand("[api_sp_StatDelaisEtalonnage]", MozartDatabase.cnxMozart)
    CmdSql.CommandType = CommandType.StoredProcedure
    CmdSql.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = MozartParams.NomSociete
    DtStatEtalonnage.Load(CmdSql.ExecuteReader)

    ChartDelaiEtalonnage.DataSource = DtStatEtalonnage

    CmdSql.Dispose()

  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub
End Class