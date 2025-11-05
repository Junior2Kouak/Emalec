Imports System.Data.SqlClient
Imports MozartLib

Public Class frmStatIndicGroupeFactByClient

  Dim DtListeGroupe As DataTable

  Private Sub frmStatIndicGroupeFactByClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Init
    DTPFin.Value = Now.Date.AddDays(Now.Date.Day * (-1))
    DTPDebut.Value = CDate("01/01/" & CDate(DTPFin.Value).Year.ToString)

    DtListeGroupe = New DataTable
    Dim sqlcmdloader As New SqlCommand("select tref_groupe.IDGROUPE, LIBGROUPE, TPER.VPERNOM  from tref_groupe inner join TPER on TPER.NPERNUM = TREF_GROUPE.NPERNUM where tref_groupe.NPERNUM <> 0 AND TREF_groupe.VSOCIETE  = '" & MozartParams.NomSociete & "' ", MozartDatabase.cnxMozart)
    sqlcmdloader.CommandType = CommandType.Text
    DtListeGroupe.Load(sqlcmdloader.ExecuteReader)

    GLP_ListeGroupe.Properties.DataSource = DtListeGroupe

    GLP_ListeGroupe.Visible = RechercheDroitMenu(GLP_ListeGroupe.Tag)

  End Sub

  Private Sub LoadData()

    Try

      Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("[api_sp_StatIndicGroupe_FactByClient]", MozartDatabase.cnxMozart) With {.CommandTimeout = 0, .CommandType = CommandType.StoredProcedure}
      CmdSql.Parameters.Add("@p_datedebut", SqlDbType.DateTime).Value = DTPDebut.Value
        CmdSql.Parameters.Add("@p_datefin", SqlDbType.DateTime).Value = DTPFin.Value
        CmdSql.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = MozartParams.NomSociete
        If GLP_ListeGroupe.Visible = True And GLP_ListeGroupe.Text <> "" Then CmdSql.Parameters.Add("@p_idgroupe", SqlDbType.Int).Value = GLP_ListeGroupe.EditValue

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GCIndicGroupFactCli.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmStatIndicGroupeFactByClient_sub + ex.Message, My.Resources.Global_Erreur)
    Finally
      Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
    GCIndicGroupFactCli.Print()
  End Sub

  Private Sub ButtonExporter_Click(sender As Object, e As EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\StatsIndicGrpFactClient_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xlsx"
    GCIndicGroupFactCli.ExportToXlsx(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub
  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click

    LoadData()

  End Sub
End Class