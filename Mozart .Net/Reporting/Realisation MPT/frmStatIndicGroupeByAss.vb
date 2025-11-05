Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class frmStatIndicGroupeByAss

  Dim DtListeGroupe As DataTable

  Private Sub frmStatIndicGroupeByAss_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'Init
    DTPFin.Value = Now.Date.AddDays(Now.Date.Day * (-1))
    DTPDebut.Value = Now.Date.AddDays(Now.Date.Day * (-1) + 1).AddMonths(-1)

    DtListeGroupe = New DataTable
    Dim sqlcmdloader As New SqlCommand("select tref_groupe.IDGROUPE, LIBGROUPE, TPER.VPERNOM  from tref_groupe inner join TPER on TPER.NPERNUM = TREF_GROUPE.NPERNUM where tref_groupe.NPERNUM <> 0 AND TREF_groupe.VSOCIETE  = '" & MozartParams.NomSociete & "' ", MozartDatabase.cnxMozart)
    sqlcmdloader.CommandType = CommandType.Text
    DtListeGroupe.Load(sqlcmdloader.ExecuteReader)

    GLP_ListeGroupe.Properties.DataSource = DtListeGroupe

    GLP_ListeGroupe.Visible = ModuleMain.RechercheDroitMenu(GLP_ListeGroupe.Tag)

  End Sub

  Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click
    LoadData()
  End Sub

  Private Sub LoadData()

    Try

      Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("[api_sp_StatIndicGroupeByAss]", MozartDatabase.cnxMozart) With {.CommandTimeout = 0, .CommandType = CommandType.StoredProcedure}
      CmdSql.Parameters.Add("@p_datedebut", SqlDbType.DateTime).Value = DTPDebut.Value
        CmdSql.Parameters.Add("@p_datefin", SqlDbType.DateTime).Value = DTPFin.Value
        CmdSql.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = MozartParams.NomSociete
        If GLP_ListeGroupe.Visible = True And GLP_ListeGroupe.Text <> "" Then CmdSql.Parameters.Add("@p_idgroupe", SqlDbType.Int).Value = GLP_ListeGroupe.EditValue

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        ChartControl0.DataSource = dtStat.Tables(0)
        ChartControl0.Refresh()
        ChartControl1.DataSource = dtStat.Tables(1)
        ChartControl2.DataSource = dtStat.Tables(2)
        ChartControl3.DataSource = dtStat.Tables(3)
        ChartControl4.DataSource = dtStat.Tables(4)
        ChartControl5.DataSource = dtStat.Tables(5)

        CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmStatIndicGroupeByAss_sub + ex.Message, My.Resources.Global_Erreur)
    Finally
      Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

  Private Sub ChartControl0_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles ChartControl0.ObjectSelected, ChartControl1.ObjectSelected, ChartControl2.ObjectSelected, ChartControl3.ObjectSelected, ChartControl4.ObjectSelected, ChartControl5.ObjectSelected

    ' Détails
    Dim hitInfo As ChartHitInfo = e.HitInfo
    If hitInfo.SeriesPoint IsNot Nothing Then

      Dim iTypeStat As Int32 = 0

      Select Case sender.name
        Case "ChartControl0" : iTypeStat = 1
        Case "ChartControl1" : iTypeStat = 2
        Case "ChartControl2" : iTypeStat = 3
        Case "ChartControl3" : iTypeStat = 4
        Case "ChartControl4" : iTypeStat = 5
        Case "ChartControl5" : iTypeStat = 6

      End Select

      Using oFrmDetailStat As New frmStatIndicGroupeByAss_Details(hitInfo.SeriesPoint.Tag.Row.ItemArray, iTypeStat, DTPDebut.Value, DTPFin.Value)
        oFrmDetailStat.ShowDialog()
      End Using
    End If

  End Sub

End Class