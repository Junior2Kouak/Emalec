Imports System.Data.SqlClient
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports MozartLib

Public Class frmStatRHTempsTravail

  Dim CnxQCMListeDet As New CGestionSQL

  Dim ds As DataSet

  Dim dtAnnee As DataTable
  Dim dtSem As DataTable
  Dim oIDProcessus As Process

  Dim ensure As Boolean = False

  Private Sub frmStatRHTempsTravail_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    CnxQCMListeDet.CloseConnexionSQL()
  End Sub

  Private Sub frmStatRHTempsTravail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'timeout à 0 = illimité
      If CnxQCMListeDet.ConnexionSQLTimeOut(MozartParams.NomServeur, MozartParams.NomSociete, 60000) = True Then

        'init
        WebView21.EnsureCoreWebView2Async()

        'test si plusieurs ecrans.
        If Screen.AllScreens.Count > 1 Then

          Me.Left = Screen.PrimaryScreen.WorkingArea.Width

        End If

        Me.WindowState = FormWindowState.Maximized

        ' TB SAMSIC CITY SPEC
        If MozartParams.NomGroupe = "EMALEC" Then BtnEdition.Visible = ModuleMain.RechercheDroitMenu(419)

        Load_CboAnnee()

        CboAnnee.SelectedValue = Now.Year

        CboSem.SelectedValue = DatePart(DateInterval.WeekOfYear, Now)

      Else

        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_RH_FrmstatRHTempsTravail_sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Try

  End Sub

  '*************************************************************************************************************************************
  'Cette sub permet de charger les 3 tables de la proc, on les load dans un dataset ou l on definit les relations entre les tables
  ' et permettre l affichage groupe
  '*************************************************************************************************************************************
  Private Sub LoadDataGridView(ByVal p_iAnnee As Int16, ByVal p_iSem As Int16)

    Try

      Me.Cursor = Cursors.WaitCursor

      ds = New DataSet

      Dim cmdLoadList As New SqlCommand("api_sp_TempsTravailTech", CnxQCMListeDet.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure
      'sqlcmd
      cmdLoadList.Parameters.Add("@iAnnee", SqlDbType.Int)
      cmdLoadList.Parameters("@iAnnee").Value = p_iAnnee
      cmdLoadList.Parameters.Add("@iSemaine", SqlDbType.Int)
      cmdLoadList.Parameters("@iSemaine").Value = p_iSem

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(ds)

      GCMASTER.DataSource = ds.Tables(0)

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_RH_FrmstatRHTempsTravail_sub2 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    Finally

      Me.Cursor = Cursors.Default

    End Try

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub GVMASTER_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVMASTER.FocusedRowChanged

    If e.FocusedRowHandle < 0 Then Exit Sub

    Try

      Dim View As GridView = CType(sender, GridView)
      If Not View Is Nothing Then

        Try

          Dim DrSelected As DataRow = View.GetDataRow(e.FocusedRowHandle)

          If Not DrSelected Is Nothing Then

            LblTech.Text = DrSelected.Item("TECH")
            LblDureeTotal.Text = My.Resources.Global_duree_tot + DrSelected.Item("DUREE")

            GCPAVE.DataSource = Nothing
            GCACT.DataSource = Nothing

            GCDETAIL.DataSource = ds.Tables(1).AsEnumerable().Where(Function(drwhere) drwhere.Item("NPERNUM") = DrSelected.Item("NPERNUM")).AsDataView.ToTable

            GVDETAIL.FocusedRowHandle = GridControl.InvalidRowHandle

          End If

        Catch ex As Exception

          MessageBox.Show(My.Resources.Reporting_RH_FrmstatRHTempsTravail_sub3 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
          GCDETAIL.DataSource = Nothing
          GVDETAIL.FocusedRowHandle = GridControl.InvalidRowHandle
          GCPAVE.DataSource = Nothing
          GVPAVE.FocusedRowHandle = GridControl.InvalidRowHandle
          GCACT.DataSource = Nothing
          GVACT.FocusedRowHandle = GridControl.InvalidRowHandle
          LblTech.Text = ""
          LblDureeTotal.Text = My.Resources.Global_duree_tot

        End Try

      Else

        LblTech.Text = ""
        LblDureeTotal.Text = My.Resources.Global_duree_tot

      End If



    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RH_FrmstatRHTempsTravail_sub4 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      GCDETAIL.DataSource = Nothing
      GVDETAIL.FocusedRowHandle = GridControl.InvalidRowHandle
      GCPAVE.DataSource = Nothing
      GVPAVE.FocusedRowHandle = GridControl.InvalidRowHandle
      GCACT.DataSource = Nothing
      GVACT.FocusedRowHandle = GridControl.InvalidRowHandle
      LblTech.Text = ""
      LblDureeTotal.Text = My.Resources.Global_duree_tot
    End Try

  End Sub

  Private Sub ComboBySemaine(ByVal p_iAnnee As Int16)

    Dim iSem As Int16

    dtSem = New DataTable

    dtSem.Columns.Add("DISPLAY_SEM", Type.GetType("System.String"))
    dtSem.Columns.Add("NUM_SEM", Type.GetType("System.String"))

    For iSem = 1 To DatePart(DateInterval.WeekOfYear, CDate("31/12/" & p_iAnnee)) - 1

      Dim drNew As DataRow = dtSem.NewRow()
      drNew.Item("DISPLAY_SEM") = returnPeriode(p_iAnnee, iSem)
      drNew.Item("NUM_SEM") = iSem
      dtSem.Rows.Add(drNew)

    Next

    CboSem.DisplayMember = "DISPLAY_SEM"
    CboSem.ValueMember = "NUM_SEM"

    CboSem.DataSource = dtSem

  End Sub

  Private Function returnPeriode(ByVal p_iannee As Int16, ByVal p_iSem As Int16) As String

    Dim NumDay As Int16 = (p_iSem * 7) - (DatePart(DateInterval.Weekday, CDate("01/01/" & p_iannee), FirstDayOfWeek.Monday))

    Dim DateFinSem As DateTime = DateAdd(DateInterval.Day, NumDay, CDate("01/01/" & p_iannee))
    Dim DateDebuSem As DateTime = DateAdd(DateInterval.Day, -6, DateFinSem)

    Return "Sem N° " + p_iSem.ToString + My.Resources.Global_du + DateDebuSem.ToShortDateString & My.Resources.Global_au & DateFinSem.ToShortDateString

  End Function

  Private Sub Load_CboAnnee()

    dtAnnee = New DataTable

    dtAnnee.Columns.Add("IDANNEE", Type.GetType("System.Int16"))
    dtAnnee.Columns.Add("ANNEE", Type.GetType("System.Int16"))

    Dim iAnnee As Int16 = Year(Now)

    ' Exception pour fin décembre, pouvoir voir 2017
    If DatePart(DateInterval.Month, Now) = 12 And DatePart(DateInterval.Day, Now) >= 15 Then
      iAnnee = Year(Now) + 1
    End If

    While iAnnee > 2000

      Dim drNew As DataRow = dtAnnee.NewRow()
      drNew.Item("IDANNEE") = iAnnee
      drNew.Item("ANNEE") = iAnnee
      dtAnnee.Rows.Add(drNew)

      iAnnee = iAnnee - 1

    End While

    CboAnnee.DisplayMember = "ANNEE"
    CboAnnee.ValueMember = "IDANNEE"

    CboAnnee.DataSource = dtAnnee

  End Sub

  Private Sub CboAnnee_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboAnnee.SelectedValueChanged

    If Not CboAnnee.SelectedValue Is Nothing Then

      ComboBySemaine(Convert.ToInt16(CboAnnee.SelectedValue))

    End If

  End Sub

  Private Sub BtnValid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnValid.Click

    LoadDataGridView(Convert.ToInt16(CboAnnee.SelectedValue), Convert.ToInt16(CboSem.SelectedValue))

  End Sub

  Private Sub GVDETAIL_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVDETAIL.FocusedRowChanged

    Dim drGeoDetail As DataRow = GVDETAIL.GetDataRow(e.FocusedRowHandle)

    If Not drGeoDetail Is Nothing Then

      LoadTrajetJournee(LblTech.Text, Convert.ToDateTime(drGeoDetail.Item("DATCLASS")).ToShortDateString(), drGeoDetail.Item("NPERNUM"))

      GCPAVE.DataSource = LoadPaveJournee(drGeoDetail.Item("NPERNUM"), drGeoDetail.Item("DATCLASS"))

      'permet de simuler un chgt de row focus
      GVPAVE.FocusedRowHandle = GridControl.InvalidRowHandle

    Else

      GCPAVE.DataSource = Nothing

    End If

  End Sub

  Private Sub GVPAVE_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVPAVE.FocusedRowChanged

    Dim drGeoPave As DataRow = GVPAVE.GetDataRow(e.FocusedRowHandle)

    If Not drGeoPave Is Nothing Then

      GCACT.DataSource = LoadActionsPave(drGeoPave.Item("NIPLNUM"), drGeoPave.Item("DIPLDATJ"), drGeoPave.Item("CIPLMULT"))

      ' TB SAMSIC CITY SPEC
      If (IsDBNull(drGeoPave.Item("NCLINUM")) = False AndAlso drGeoPave.Item("NCLINUM") = "108") And MozartParams.NomGroupe = "EMALEC" Then
        ColACT_VISA.Visible = False
        ColACT_BTNIPLMULT.Visible = False
      Else
        'permet de cacher la colonne MULTIJOUR s'il n y a pas de multijour dans la semaine
        If IsDBNull(drGeoPave.Item("CIPLMULT")) = False Then

          If drGeoPave.Item("CIPLMULT") = "O" Then
            ColACT_BTNIPLMULT.Visible = True
          Else
            ColACT_BTNIPLMULT.Visible = False
          End If

        Else
          ColACT_BTNIPLMULT.Visible = False
        End If

        ColACT_VISA.Visible = Not ColACT_BTNIPLMULT.Visible

      End If





    Else
      GCACT.DataSource = Nothing
    End If

  End Sub

  Private Sub RepositoryItemButtonEditMOZART_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemButtonEditMOZART.Click

    Dim drGeoMOZART As DataRow = GVACT.GetDataRow(GVACT.GetSelectedRows(0))

    Dim sqlcmd As New SqlCommand("api_sp_UpdateVISA_ARR_EXE", CnxQCMListeDet.CnxSQLOpen)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@p_nactnum", SqlDbType.Int)
    sqlcmd.Parameters("@p_nactnum").Value = drGeoMOZART.Item("NACTNUM")

    sqlcmd.ExecuteNonQuery()

    Dim drGeoPave As DataRow = GVPAVE.GetDataRow(GVPAVE.GetSelectedRows(0))

    If Not drGeoPave Is Nothing Then

      GCACT.DataSource = LoadActionsPave(drGeoPave.Item("NIPLNUM"), drGeoPave.Item("DIPLDATJ"), drGeoPave.Item("CIPLMULT"))

    Else
      GCACT.DataSource = Nothing
    End If



  End Sub

  Private Function TestClientSociete() As Boolean

    If GVPAVE.SelectedRowsCount > 0 Then

      Dim DrSoc As DataRow = GVPAVE.GetDataRow(GVPAVE.GetSelectedRows(0))

      If DrSoc.Item("NCLINUM") = GetNCLINUM_On_VSOCIETE(MozartParams.NomSociete) Then
        Return True
      Else
        Return False
      End If

    Else

      Return False

    End If

  End Function

  Private Sub LoadTrajetJournee(ByVal NomTech As String, ByVal DateJournee As String, ByVal P_NPERNUM As Int32)

    Me.Cursor = Cursors.WaitCursor

    ' TB SAMSIC CITY SPEC
    If MozartParams.NomGroupe = "EMALEC" Or MozartParams.NomGroupe Is Nothing Then
      'WBTrajet.Navigate("https://maps.emalec.com/TrajetTechnicienJourDepArrTempsTravail.asp?BASE=MULTI&APP=" & MozartParams.NomSociete & "&TYPE=GEOLOC&INDEX=0&NOM=" & NomTech.Replace("'", "''") & "&JOUR=" & DateJournee)
      WebView21.Source = New Uri("https://maps.emalec.com/TrajetTechnicienJourDepArrTempsTravail.asp?BASE=MULTI&APP=" & MozartParams.NomSociete & "&TYPE=GEOLOC&INDEX=0&NPERNUM=" & P_NPERNUM.ToString() & "&JOUR=" & DateJournee)

    End If ' TODO_TB SAMSIC CITY -> else pour samsic

    GrpGeoloc.Text = My.Resources.Reporting_RH_FrmstatRHTempsTravail_trajet & DateJournee

    Me.Cursor = Cursors.Default

  End Sub

  Private Function LoadPaveJournee(ByVal p_NPERNUM As Int32, ByVal p_DateJournee As String) As DataTable

    Dim dt_tmp As New DataTable

    Me.Cursor = Cursors.WaitCursor

    Try

      Dim cmdLoadList As New SqlCommand("api_sp_DetailPaveJour", CnxQCMListeDet.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure
      'sqlcmd
      cmdLoadList.Parameters.Add("@P_DACTPLA", SqlDbType.DateTime)
      cmdLoadList.Parameters("@P_DACTPLA").Value = p_DateJournee
      cmdLoadList.Parameters.Add("@P_NPERNUM", SqlDbType.Int)
      cmdLoadList.Parameters("@P_NPERNUM").Value = p_NPERNUM

      dt_tmp.Load(cmdLoadList.ExecuteReader)

      Return dt_tmp

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_RH_FrmstatRHTempsTravail_sub5 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return Nothing

    Finally

      Me.Cursor = Cursors.Default

    End Try

  End Function

  Private Function LoadActionsPave(ByVal p_NIPLNUM As Int32, ByVal p_DateJournee As String, ByVal p_Multi As String) As DataTable

    Dim dt_tmp As New DataTable

    Me.Cursor = Cursors.WaitCursor

    Try

      Dim cmdLoadList As New SqlCommand("api_sp_DetailActionPave", CnxQCMListeDet.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure
      'sqlcmd
      cmdLoadList.Parameters.Add("@P_NIPLNUM", SqlDbType.Int)
      cmdLoadList.Parameters("@P_NIPLNUM").Value = p_NIPLNUM
      cmdLoadList.Parameters.Add("@DDATJ", SqlDbType.DateTime)
      cmdLoadList.Parameters("@DDATJ").Value = p_DateJournee
      cmdLoadList.Parameters.Add("@MULTI", SqlDbType.VarChar)
      cmdLoadList.Parameters("@MULTI").Value = p_Multi

      dt_tmp.Load(cmdLoadList.ExecuteReader)

      Return dt_tmp

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_RH_FrmstatRHTempsTravail_sub6 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return Nothing

    Finally

      Me.Cursor = Cursors.Default

    End Try

  End Function

  Private Function Test_MOZART_Loaded(ByRef oIDProcessus As Process) As Boolean

    'on recherche le process s'il existe toujours
    If oIDProcessus.Id > 0 Then

      'liste des process en cours
      Dim listRunProc() As Process = Process.GetProcesses

      For Each ProcRunning As Process In listRunProc

        If ProcRunning.Id = oIDProcessus.Id Then
          Return True
        End If

      Next

      oIDProcessus = Nothing
      Return False

    Else
      oIDProcessus = Nothing
      Return False

    End If

  End Function

  Private Sub GVACT_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVACT.CustomDrawCell

    'on charge la datarow
    Dim DrPaint As DataRow = GVACT.GetDataRow(e.RowHandle)

    If Not DrPaint Is Nothing Then

      Select Case e.Column.FieldName

        Case "DACTARR"

          If IsDBNull(DrPaint.Item("DVISAARR")) = True Then
            e.Appearance.BackColor = Color.Salmon
          Else
            e.Appearance.BackColor = Color.LightGreen
          End If

          ' TB SAMSIC CITY SPEC
          If DrPaint.Item("NCLINUM") = "108" And MozartParams.NomGroupe = "EMALEC" Then e.Appearance.BackColor = Color.LightGreen

        Case "DACTDEX"

          If IsDBNull(DrPaint.Item("DVISAEXEC")) = True Then
            e.Appearance.BackColor = Color.Salmon
          Else
            e.Appearance.BackColor = Color.LightGreen
          End If

          ' TB SAMSIC CITY SPEC
          If DrPaint.Item("NCLINUM") = "108" And MozartParams.NomGroupe = "EMALEC" Then e.Appearance.BackColor = Color.LightGreen

      End Select

      If e.Column.Name = "ColACT_BTNIPLMULT" Then

        Dim cellInfo As GridCellInfo = CType(e.Cell, GridCellInfo)

        Dim buttonEditViewInfo As ButtonEditViewInfo = CType(cellInfo.ViewInfo, ButtonEditViewInfo)
        Dim drGeoAct As DataRow = GVACT.GetDataRow(GVACT.GetSelectedRows(0))

        If Not drGeoAct Is Nothing AndAlso buttonEditViewInfo.RightButtons.Count > 0 Then

          If IsDBNull(drGeoAct.Item("CIPLMULT")) = False Then

            If drGeoAct.Item("CIPLMULT") = "O" Then
              buttonEditViewInfo.RightButtons(0).State = ObjectState.Normal
            Else
              buttonEditViewInfo.RightButtons(0).State = ObjectState.Disabled
            End If

          Else
            buttonEditViewInfo.RightButtons(0).State = ObjectState.Disabled
          End If

        End If

      End If

    End If

  End Sub

  Private Sub GVACT_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVACT.GotFocus
    'reload des donnees
    If GVPAVE.SelectedRowsCount > 0 Then

      Dim drPave As DataRow = GVPAVE.GetDataRow(GVPAVE.GetSelectedRows(0))

      GCACT.DataSource = LoadActionsPave(drPave.Item("NIPLNUM"), drPave.Item("DIPLDATJ"), drPave.Item("CIPLMULT"))

    End If
  End Sub

  Private Sub GVACT_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVACT.RowClick

    If GVACT.SelectedRowsCount > 0 Then

      Dim drGeoMOZART As DataRow = GVACT.GetDataRow(GVACT.GetSelectedRows(0))
      Dim sParamMOZART As String

      If Not drGeoMOZART Is Nothing Then

        sParamMOZART = String.Format("{0};{1};{2};{3};{4};{5}", MozartParams.NomServeur, MozartParams.NomSociete, drGeoMOZART.Item("NDINNUM"), drGeoMOZART.Item("NACTNUM"), "ACT", 0)

        'If drGeoMOZART.Item("CIPLMULT") = "O" Then Exit Sub

        'Lancement de MOZART
        If Not oIDProcessus Is Nothing AndAlso Test_MOZART_Loaded(oIDProcessus) = True Then

          MessageBox.Show(My.Resources.Reporting_RH_FrmstatRHTempsTravail_mozart, "Mozart", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
          'on redonne le focus sur l applciation
          If Test_MOZART_Loaded(oIDProcessus) = True Then AppActivate(oIDProcessus.Id)

        Else

          'pour ne lance pas mozart si actions sur client EMALEC
          If TestClientSociete() = False Then

            Dim Startcmd As New ProcessStartInfo(MozartParams.CheminProgrammeMozart & "MOZARTCS.exe", sParamMOZART)
            oIDProcessus = New Process
            oIDProcessus = Process.Start(Startcmd)

            GVACT.FocusedRowHandle = GridControl.InvalidRowHandle

          End If

        End If

      End If

    End If

  End Sub

  Private Sub BtnEdition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdition.Click

    If GVMASTER.RowCount > 0 Then

      Dim sProc As String = String.Format("api_sp_TempsTravailTech {0}, {1}, 'P'", Convert.ToInt16(CboAnnee.SelectedValue), Convert.ToInt16(CboSem.SelectedValue))

      Me.Cursor = Cursors.WaitCursor

      Dim oDoc As New CGenDoc("Edition_Temps_Travail", sProc)
      Me.Cursor = Cursors.Default

      If oDoc.p_ERROR = "" Then
        Dim ofrmVisuFic As New frmVisuDoc(oDoc.p_PathFileName)
        ofrmVisuFic.ShowDialog()
      End If

    Else

      MessageBox.Show(My.Resources.Reporting_RH_FrmstatRHTempsTravail_select_period, My.Resources.Global_Information, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End If

  End Sub

  Private Sub RepositoryItemButtonEditMulti_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemButtonEditMulti.Click

    Dim drPaveMulti As DataRow = GVPAVE.GetDataRow(GVPAVE.GetSelectedRows(0))
    Dim drActMulti As DataRow = GVACT.GetDataRow(GVACT.GetSelectedRows(0))

    If IsDBNull(drPaveMulti.Item("CIPLMULT")) = False AndAlso drPaveMulti.Item("CIPLMULT") = "O" Then

      Dim oFrmMultiJour As New frmModalStatRHTpsTravMultiJour(drPaveMulti.Item("NIPLNUM"), drActMulti("NACTNUM"), drPaveMulti.Item("DIPLDATJ"))
      oFrmMultiJour.ShowDialog()

    End If

    GVPAVE.FocusedRowHandle = GridControl.InvalidRowHandle


  End Sub

  Private Sub WebView21_CoreWebView2InitializationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs) Handles WebView21.CoreWebView2InitializationCompleted

    ensure = True

  End Sub

End Class