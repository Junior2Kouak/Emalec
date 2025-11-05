Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class frmStatChefGroupe

  '0 = mode process
  '1 = mode financier
  Dim _Mode As Int32

  Dim DtListeGroupe As DataTable

  Dim Ds1 As DataSet
  Dim Ds2 As DataSet
  Dim Ds3 As DataSet
  Dim Ds4 As DataSet

  Public Sub New(ByVal c_Mode As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _Mode = c_Mode

  End Sub

  Private Sub frmStatChefGroupe_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    'Init
    DTPFin.Value = Now.Date.AddDays(Now.Date.Day * (-1))
    DTPDebut.Value = CDate("01/01/" & CDate(DTPFin.Value).Year.ToString)

    DtListeGroupe = New DataTable
    Dim sqlcmdloader As New SqlCommand("select tref_groupe.IDGROUPE, LIBGROUPE, TPER.VPERNOM  from tref_groupe inner join TPER on TPER.NPERNUM = TREF_GROUPE.NPERNUM where tref_groupe.NPERNUM <> 0 AND TREF_groupe.VSOCIETE  = '" & MozartParams.NomSociete & "' ", MozartDatabase.cnxMozart)
    sqlcmdloader.CommandType = CommandType.Text
    DtListeGroupe.Load(sqlcmdloader.ExecuteReader)

    GLP_ListeGroupe.Properties.DataSource = DtListeGroupe

    GLP_ListeGroupe.Visible = RechercheDroitMenu(GLP_ListeGroupe.Tag)

    GestionAffichage()

    'range color
    '    ChartControlMttFact.Series(0).Colorizer = CreateColorizer(0, New Double() {0, 500000, 1500000})
    ChartControlMttFact.Series(0).View.Colorizer = CreateColorizer(0, New Double() {0, 500000, 1500000})
    ChartControlMttFact.Series(0).ColorDataMember = "val_color"

    'ChartControlNbDevis.Series(0).Colorizer = CreateColorizer(1, New Double() {0, 50, 150})
    ChartControlNbDevis.Series(0).View.Colorizer = CreateColorizer(1, New Double() {0, 50, 150})
    ChartControlNbDevis.Series(0).ColorDataMember = "NB"

    'ChartControlMarge.Series(0).Colorizer = CreateColorizer(0, New Double() {0, 10, 20})
    ChartControlMarge.Series(0).View.Colorizer = CreateColorizer(0, New Double() {0, 10, 20})
    ChartControlMarge.Series(0).ColorDataMember = "VAl_COLOR"

    'ChartControlMttDevis.Series(0).Colorizer = CreateColorizer(1, New Double() {0, 500000, 1500000})
    ChartControlMttDevis.Series(0).View.Colorizer = CreateColorizer(1, New Double() {0, 500000, 1500000})
    ChartControlMttDevis.Series(0).ColorDataMember = "val_color"

    'ChartControl1.Series(0).Colorizer = CreateColorizer(0, New Double() {0, 200000, 400000})
    ChartControl1.Series(0).View.Colorizer = CreateColorizer(0, New Double() {0, 200000, 400000})
    ChartControl1.Series(0).ColorDataMember = "val_color"

  End Sub

  Private Sub GestionAffichage()

    Dim oLocInit As New Point(115, 83)

    Select Case _Mode
      Case 0
        'nombre de devis
        GrpPer.Visible = True
        Panel1.Visible = True

        GrpPer.Location = oLocInit
        Panel1.Location = New Point(GrpPer.Location.X + GrpPer.Width + 5, GrpPer.Location.Y)

        'montant des devis
        GroupBox1.Visible = True
        Panel2.Visible = True

        GroupBox1.Location = New Point(GrpPer.Location.X, GrpPer.Location.Y + GrpPer.Height + 10)
        Panel2.Location = New Point(GroupBox1.Location.X + GroupBox1.Width + 5, GroupBox1.Location.Y)

        'Montant des facturations
        GroupBox2.Visible = False
        Panel3.Visible = False

        'Marge
        GroupBox3.Visible = False
        Panel6.Visible = False

        'CA des actiosn en cours
        GroupBox4.Visible = False
        Panel4.Visible = False

        'En cours comptables
        GroupBox5.Visible = False
        Panel5.Visible = False

        'impayes client
        GroupBox6.Visible = False
        Panel7.Visible = False

      Case 1

        'nombre de devis
        GrpPer.Visible = False
        Panel1.Visible = False

        'montant des devis
        GroupBox1.Visible = False
        Panel2.Visible = False

        'Montant des facturations
        GroupBox2.Visible = True
        Panel3.Visible = True

        GroupBox2.Location = oLocInit
        Panel3.Location = New Point(GroupBox2.Location.X + GroupBox2.Width + 5, GroupBox2.Location.Y)

        'Marge
        GroupBox3.Visible = True
        Panel6.Visible = True

        GroupBox3.Location = New Point(GroupBox2.Location.X, GroupBox2.Location.Y + GroupBox2.Height + 10)
        Panel6.Location = New Point(GroupBox3.Location.X + GroupBox3.Width + 5, GroupBox3.Location.Y)

        'CA des actiosn en cours
        GroupBox4.Visible = True
        Panel4.Visible = True

        GroupBox4.Location = New Point(GroupBox3.Location.X, GroupBox3.Location.Y + GroupBox3.Height + 10)
        Panel4.Location = New Point(GroupBox4.Location.X + GroupBox4.Width + 5, GroupBox4.Location.Y)

        'En cours comptables
        GroupBox5.Visible = True
        Panel5.Visible = True

        GroupBox5.Location = New Point(Panel3.Location.X + Panel3.Width + 5, GroupBox2.Location.Y)
        Panel5.Location = New Point(GroupBox5.Location.X + GroupBox5.Width + 5, GroupBox5.Location.Y)

        'impayes client
        GroupBox6.Visible = True
        Panel7.Visible = True

        GroupBox6.Location = New Point(GroupBox5.Location.X, GroupBox5.Location.Y + GroupBox5.Height + 10)
        Panel7.Location = New Point(GroupBox6.Location.X + GroupBox6.Width + 5, GroupBox6.Location.Y)

      Case Else

        'nombre de devis
        GrpPer.Visible = False
        Panel1.Visible = False

        'montant des devis
        GroupBox1.Visible = False
        Panel2.Visible = False

        'Montant des facturations
        GroupBox2.Visible = False
        Panel3.Visible = False

        'Marge
        GroupBox3.Visible = False
        Panel6.Visible = False

        'CA des actiosn en cours
        GroupBox4.Visible = False
        Panel4.Visible = False

        'En cours comptables
        GroupBox5.Visible = False
        Panel5.Visible = False

        'impayes client
        GroupBox6.Visible = False
        Panel7.Visible = False

    End Select

  End Sub

  Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click
    Timer1.Enabled = True
  End Sub

  'Private Shared Function CalculMoyenne(ByVal dt As DataSet, ByVal i As Integer) As Decimal

  '  Dim somme As Integer = 0

  '  For cpt = 0 To dt.Tables(i).Rows.Count - 1
  '    ' !!! La 1ère colonne du DataSet doit être le nombre de réceptions ou de colis!!!
  '    Dim nb As String = dt.Tables(i).Rows(cpt).ItemArray.GetValue(0).ToString  ' On récupère les valeurs à ajouter

  '          somme = somme + Integer.Parse(nb)

  '  Next cpt

  '  Return somme / 48
  'End Function

  Private Sub BtnFermer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFermer.Click
    Close()
  End Sub

  Private Sub BtnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

  Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick

    Timer1.Enabled = False

    Try

      Cursor = Cursors.WaitCursor

      Select Case _Mode
        Case 0
          Dim CmdSql As New SqlCommand("[api_sp_StatChefGroupe]", MozartDatabase.cnxMozart) With {.CommandTimeout = 0, .CommandType = CommandType.StoredProcedure}
          CmdSql.Parameters.Add("@p_datedebut", SqlDbType.DateTime).Value = DTPDebut.Value
          CmdSql.Parameters.Add("@p_datefin", SqlDbType.DateTime).Value = DTPFin.Value
          CmdSql.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = MozartParams.NomSociete
          If GLP_ListeGroupe.Visible = True And GLP_ListeGroupe.Text <> "" Then CmdSql.Parameters.Add("@p_idgroupe", SqlDbType.Int).Value = GLP_ListeGroupe.EditValue

          Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
          Ds1 = New DataSet
          sqlAdpat.Fill(Ds1)

          ChartControlNbDevis.DataSource = Ds1.Tables(0)
          ChartControlNbDevis.Refresh()
          ChartControlMttDevis.DataSource = Ds1.Tables(1)

          CmdSql.Dispose()
        Case 1

          Dim CmdSql As New SqlCommand("[api_sp_StatChefGroupe_Step2]", MozartDatabase.cnxMozart) With {.CommandTimeout = 0, .CommandType = CommandType.StoredProcedure}   ' Suite de la première proc stock
          CmdSql.Parameters.Add("@p_datedebut", SqlDbType.DateTime).Value = DTPDebut.Value
          CmdSql.Parameters.Add("@p_datefin", SqlDbType.DateTime).Value = DTPFin.Value
          CmdSql.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = MozartParams.NomSociete
          If GLP_ListeGroupe.Visible = True And GLP_ListeGroupe.Text <> "" Then CmdSql.Parameters.Add("@p_idgroupe", SqlDbType.Int).Value = GLP_ListeGroupe.EditValue

          Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
          Ds2 = New DataSet
          sqlAdpat.Fill(Ds2)

          ChartControlMttFact.DataSource = Ds2.Tables(0)
          ChartControlMarge.DataSource = Ds2.Tables(1)
          ChartControl1.DataSource = Ds2.Tables(2)

          'chart des en cours compta
          CmdSql = New SqlCommand("[api_sp_StatChefGroupe_Step3]", MozartDatabase.cnxMozart) With {.CommandTimeout = 0, .CommandType = CommandType.StoredProcedure}   ' Suite de la première proc stock
          CmdSql.Parameters.Add("@p_date_fin", SqlDbType.DateTime).Value = DTPFin.Value
          CmdSql.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = MozartParams.NomSociete
          If GLP_ListeGroupe.Visible = True And GLP_ListeGroupe.Text <> "" Then CmdSql.Parameters.Add("@p_idgroupe", SqlDbType.Int).Value = GLP_ListeGroupe.EditValue

          sqlAdpat = New SqlDataAdapter(CmdSql)
          Ds3 = New DataSet
          sqlAdpat.Fill(Ds3)

          ChartControlEnCoursCompta.DataSource = Ds3.Tables(1)

          CmdSql.Dispose()

          'chart des impayes clients
          CmdSql = New SqlCommand("[api_sp_StatChefGroupe_Step4]", MozartDatabase.cnxMozart) With {.CommandTimeout = 0, .CommandType = CommandType.StoredProcedure}   ' Suite de la première proc stock
          CmdSql.Parameters.Add("@p_date_fin", SqlDbType.DateTime).Value = DTPFin.Value
          CmdSql.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = MozartParams.NomSociete
          If GLP_ListeGroupe.Visible = True And GLP_ListeGroupe.Text <> "" Then CmdSql.Parameters.Add("@p_idgroupe", SqlDbType.Int).Value = GLP_ListeGroupe.EditValue

          sqlAdpat = New SqlDataAdapter(CmdSql)
          Ds4 = New DataSet
          sqlAdpat.Fill(Ds4)

          ChartControlImpayesClient.DataSource = Ds4.Tables(1)

          CmdSql.Dispose()

      End Select

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmStatChefGroupeDetails_sub + ex.Message, My.Resources.Global_Erreur)
    Finally
      Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub ChartControl0_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles ChartControlNbDevis.ObjectSelected

    ' Détails
    Dim hitInfo As ChartHitInfo = e.HitInfo
    If hitInfo.SeriesPoint IsNot Nothing Then
      Using oFrmDetailStat As New frmStatChefGroupeDetails(hitInfo.SeriesPoint.Tag.Row.ItemArray, 1, DTPDebut.Value, DTPFin.Value)
        oFrmDetailStat.ShowDialog()
      End Using
    End If

  End Sub

  Private Sub ChartControl1_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles ChartControlMttDevis.ObjectSelected
    ' Détails
    Dim hitInfo As ChartHitInfo = e.HitInfo
    If hitInfo.SeriesPoint IsNot Nothing Then
      Using oFrmDetailStat As New frmStatChefGroupeDetails(hitInfo.SeriesPoint.Tag.Row.ItemArray, 2, DTPDebut.Value, DTPFin.Value)
        oFrmDetailStat.ShowDialog()
      End Using
    End If
  End Sub

  Private Sub ChartControl2_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles ChartControlMttFact.ObjectSelected

    ' Détails
    Dim hitInfo As ChartHitInfo = e.HitInfo
    If hitInfo.SeriesPoint IsNot Nothing Then
      Using oFrmDetailStat As New frmStatChefGroupeDetails(hitInfo.SeriesPoint.Tag.Row.ItemArray, 3, DTPDebut.Value.Date.ToString, DTPFin.Value.Date.ToString)
        oFrmDetailStat.ShowDialog()
      End Using
    End If

  End Sub

  Private Sub ChartControl3_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles ChartControlMarge.ObjectSelected

    ' Détails
    Dim hitInfo As ChartHitInfo = e.HitInfo
    If hitInfo.SeriesPoint IsNot Nothing Then
      Using oFrmDetailStat As New frmStatChefGroupeDetails(hitInfo.SeriesPoint.Tag.Row.ItemArray, 4, DTPDebut.Value.Date.ToString, DTPFin.Value.Date.ToString)
        oFrmDetailStat.ShowDialog()
      End Using
    End If

  End Sub

  Private Sub ChartControl4_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles ChartControl1.ObjectSelected

    ' Détails
    Dim hitInfo As ChartHitInfo = e.HitInfo
    If hitInfo.SeriesPoint IsNot Nothing Then
      Dim oFrmDetailStat As New frmStatChefGroupeDetails(hitInfo.SeriesPoint.Tag.Row.ItemArray, 5, DTPDebut.Value.Date.ToString, DTPFin.Value.Date.ToString)
      oFrmDetailStat.ShowDialog()
      oFrmDetailStat.Dispose()
    End If

  End Sub

  Private Sub ChartControl5_ObjectSelected(sender As Object, e As HotTrackEventArgs) Handles ChartControlEnCoursCompta.ObjectSelected

    ' Détails
    Dim hitInfo As ChartHitInfo = e.HitInfo
    If hitInfo.SeriesPoint IsNot Nothing Then
      'MessageBox.Show(hitInfo.SeriesPoint.Tag.Row.ItemArray(1))
      Dim oFrmDetailStat As New frmStatChefGroupeDetails(hitInfo.SeriesPoint.Tag.Row.ItemArray, 7, DTPDebut.Value.Date.ToString, DTPFin.Value.Date.ToString)
      oFrmDetailStat.DtEncours = Ds3.Tables(0).Select("[CHAFF] = '" & hitInfo.SeriesPoint.Tag.Row.ItemArray(0) & "'").CopyToDataTable
      oFrmDetailStat.ShowDialog()
      oFrmDetailStat.Dispose()
    End If

  End Sub

  Private Sub ChartControlImpayesClient_ObjectSelected(sender As Object, e As HotTrackEventArgs) Handles ChartControlImpayesClient.ObjectSelected


    ' Détails
    Dim hitInfo As ChartHitInfo = e.HitInfo
    If hitInfo.SeriesPoint IsNot Nothing Then
      'MessageBox.Show(hitInfo.SeriesPoint.Tag.Row.ItemArray(1))
      Dim oFrmDetailStat As New frmStatChefGroupeDetails(hitInfo.SeriesPoint.Tag.Row.ItemArray, 8, DTPDebut.Value.Date.ToString, DTPFin.Value.Date.ToString)
      oFrmDetailStat.DtEncours = Ds4.Tables(0).Select("[VPERNOM] = '" & hitInfo.SeriesPoint.Tag.Row.ItemArray(0) & "'").CopyToDataTable
      oFrmDetailStat.ShowDialog()
      oFrmDetailStat.Dispose()
    End If

  End Sub

  Private Sub ChartControl0_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs) Handles ChartControlNbDevis.CustomDrawSeriesPoint

    'If e.SeriesPoint.Values(0) <= 50 Then e.SeriesPoint.Color = Color.Red
    'If e.SeriesPoint.Values(0) > 50 And e.SeriesPoint.Values(0) <= 150 Then e.SeriesPoint.Color = Color.Green
    'If e.SeriesPoint.Values(0) > 150 Then e.SeriesPoint.Color = Color.Orange

  End Sub

  Private Sub ChartControl3_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs) Handles ChartControlMarge.CustomDrawSeriesPoint

    'If e.SeriesPoint.Values(0) <= 10 Then e.SeriesPoint.Color = Color.Red
    'If e.SeriesPoint.Values(0) > 10 And e.SeriesPoint.Values(0) <= 20 Then e.SeriesPoint.Color = Color.Orange
    'If e.SeriesPoint.Values(0) > 20 Then e.SeriesPoint.Color = Color.Green

  End Sub

  Private Sub ChartControl1_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs) Handles ChartControlMttDevis.CustomDrawSeriesPoint

    'If e.SeriesPoint.Values(0) <= 500000 Then e.SeriesPoint.Color = Color.Red
    'If e.SeriesPoint.Values(0) > 500000 And e.SeriesPoint.Values(0) <= 1500000 Then e.SeriesPoint.Color = Color.Green
    'If e.SeriesPoint.Values(0) > 1500000 Then e.SeriesPoint.Color = Color.Orange

  End Sub

  Private Sub ChartControl4_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)

    'If e.SeriesPoint.Values(0) <= 200000 Then e.SeriesPoint.Color = Color.Red
    'If e.SeriesPoint.Values(0) > 200000 And e.SeriesPoint.Values(0) <= 400000 Then e.SeriesPoint.Color = Color.Orange
    'If e.SeriesPoint.Values(0) > 400000 Then e.SeriesPoint.Color = Color.Green

  End Sub

  Private Sub ChartControl2_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs) Handles ChartControlMttFact.CustomDrawSeriesPoint

    'If e.SeriesPoint.Values(0) <= 500000 Then e.SeriesPoint.Color = Color.Red
    'If e.SeriesPoint.Values(0) > 500000 And e.SeriesPoint.Values(0) <= 1500000 Then e.SeriesPoint.Color = Color.Orange
    'If e.SeriesPoint.Values(0) > 1500000 Then e.SeriesPoint.Color = Color.Green

  End Sub


#Region "#RangeColorizer"
  ' Creates a range colorizer.
  Private Function CreateColorizer(ByVal p_ModePalette As Int32, ByVal p_RangeValue As Double()) As ChartColorizerBase
    Dim palette As Palette
    Select Case p_ModePalette
      Case 0
        palette = New Palette("Custom" & p_ModePalette.ToString)
        palette.Add(Color.FromArgb(255, 255, 0, 0), Color.FromArgb(255, 255, 0, 0)) 'red
        palette.Add(Color.FromArgb(255, 255, 153, 51), Color.FromArgb(255, 255, 153, 51)) 'orange
        palette.Add(Color.FromArgb(255, 0, 255, 0), Color.FromArgb(255, 0, 255, 0)) 'green
      Case 1
        palette = New Palette("Custom" & p_ModePalette.ToString)
        palette.Add(Color.FromArgb(255, 255, 0, 0), Color.FromArgb(255, 255, 0, 0)) 'red
        palette.Add(Color.FromArgb(255, 0, 255, 0), Color.FromArgb(255, 0, 255, 0)) 'green
        palette.Add(Color.FromArgb(255, 255, 153, 51), Color.FromArgb(255, 255, 153, 51)) 'orange

      Case Else
        palette = New Palette("Custom" & p_ModePalette.ToString)
        palette.Add(Color.FromArgb(255, 255, 0, 0), Color.FromArgb(255, 255, 0, 0)) 'red
        palette.Add(Color.FromArgb(255, 255, 153, 51), Color.FromArgb(255, 255, 153, 51)) 'orange
        palette.Add(Color.FromArgb(255, 0, 255, 0), Color.FromArgb(255, 0, 255, 0)) 'green
    End Select

    If palette Is Nothing Then Return Nothing

    Dim colorizer As New RangeColorizer() With {.LegendItemPattern = "", .Palette = palette}
    colorizer.RangeStops.AddRange(p_RangeValue)
    Return colorizer
  End Function
#End Region ' #RangeColorizer

End Class