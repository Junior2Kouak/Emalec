Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports MozartLib

Public Class UCRapportFM_Periode

  Dim _oRapportFM As CRapportFM
  Dim DT_Langue As DataTable

  Dim _DT_Sites As DataTable
  Dim _DT_CAN As DataTable
  Dim _DT_Contrat As DataTable

  Public ReadOnly Property DT_Sites As DataTable
    Get
      Return _DT_Sites
    End Get
  End Property

  Public ReadOnly Property DT_CAN As DataTable
    Get
      Return _DT_CAN
    End Get
  End Property

  Public ReadOnly Property DT_Contrat As DataTable
    Get
      Return _DT_Contrat
    End Get
  End Property

  Public Sub New(ByVal c_oRapportFM As CRapportFM)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _oRapportFM = c_oRapportFM

  End Sub

  Private Sub UCRapportFM_Periode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    DTP_Debut.Value = _oRapportFM.sDateDebut_This
    DTP_Fin.Value = _oRapportFM.sDateFin_This

    TxtRapportFM_Titre.Text = _oRapportFM.VRAPPORT_FM_TITLE

    LoadLangue()
    LoadSites()
    LoadCAN()
    LoadContrat()

    CboLangue.DataSource = DT_Langue
    CboLangue.ValueMember = "VLANGUE"
    CboLangue.DisplayMember = "VLANGUE"

    CboLangue.SelectedValue = _oRapportFM.sLangue
    ChkAfficheListeSite.Checked = _oRapportFM.bAfficheSite

  End Sub

  Private Sub LoadLangue()

    DT_Langue = New DataTable

    DT_Langue.Columns.Add("VLANGUE", GetType(String))

    DT_Langue.Rows.Add("DE")
    DT_Langue.Rows.Add("DK")
    DT_Langue.Rows.Add("FR")
    DT_Langue.Rows.Add("EN")
    DT_Langue.Rows.Add("ES")
    DT_Langue.Rows.Add("IT")
    DT_Langue.Rows.Add("NL")
    DT_Langue.Rows.Add("PT")
    DT_Langue.Rows.Add("SE")

  End Sub

  Private Sub LoadSites()

    _DT_Sites = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListeSitesByClientForRapportFM]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@NIDRAPPORT_FM_CLI", SqlDbType.Int).Value = _oRapportFM.NIDRAPPORT_FM_CLI
        sqlcmd.Parameters.Add("@iClient", SqlDbType.Int).Value = _oRapportFM.NCLINUM

        _DT_Sites.Load(sqlcmd.ExecuteReader)

        _DT_Sites.Columns("NCHECK").ReadOnly = False

        GCSITES.DataSource = _DT_Sites

    End Sub

    Private Sub LoadCAN()

        _DT_CAN = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListeCANByClientForRapportFM]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@NIDRAPPORT_FM_CLI", SqlDbType.Int).Value = _oRapportFM.NIDRAPPORT_FM_CLI
        sqlcmd.Parameters.Add("@iClient", SqlDbType.Int).Value = _oRapportFM.NCLINUM

        _DT_CAN.Load(sqlcmd.ExecuteReader)

        _DT_CAN.Columns("NCHECK").ReadOnly = False

        GCCAN.DataSource = _DT_CAN

    End Sub
  Private Sub LoadContrat()

    _DT_Contrat = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListeContratByClientForRapportFM]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@NIDRAPPORT_FM_CLI", SqlDbType.Int).Value = _oRapportFM.NIDRAPPORT_FM_CLI
    sqlcmd.Parameters.Add("@iClient", SqlDbType.Int).Value = _oRapportFM.NCLINUM

    _DT_Contrat.Load(sqlcmd.ExecuteReader)

    _DT_Contrat.Columns("NCHECK").ReadOnly = False

    GCContrat.DataSource = _DT_Contrat

  End Sub


  Private Sub GVSITES_CustomDrawFooter(sender As Object, e As RowObjectCustomDrawEventArgs) Handles GVSITES.CustomDrawFooter
        Dim oPos As Rectangle = e.Bounds
        Dim oFormat As New StringFormat
        Dim iNbSelected As Int32 = 0

        oPos.Location = New Point(oPos.Left + 1, oPos.Top + 1)
        oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)

        oFormat.Alignment = StringAlignment.Center

        Dim dttemp As DataTable = GCSITES.DataSource

        For Each odrtemp As DataRow In dttemp.Rows

            If odrtemp.Item("NCHECK") = 1 Then
                iNbSelected = iNbSelected + 1
            End If

        Next

        e.Appearance.DrawString(e.Cache, String.Format("Nb de sites sélectionnés", iNbSelected, _DT_Sites.Rows.Count), oPos, oFormat)
        e.Handled = True
    End Sub

    Private Sub BtnCoche_Click(sender As System.Object, e As System.EventArgs) Handles BtnCoche.Click
        CocherAllFilterTous_Or_DecocheAllFilter(_DT_Sites, "NCHECK", GVSITES.ActiveFilterCriteria, True)
        GCSITES.Refresh()
    End Sub

    Private Sub BtnDecoche_Click(sender As System.Object, e As System.EventArgs) Handles BtnDecoche.Click
        CocherAllFilterTous_Or_DecocheAllFilter(_DT_Sites, "NCHECK", GVSITES.ActiveFilterCriteria, False)
        GCSITES.Refresh()
    End Sub

    Private Sub GVListeReqByCliRapportFM_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GVSITES.CellValueChanging

        If e.Column.FieldName = "NCHECK" Then

            Dim DrUpdateOrder As DataRow = GVSITES.GetDataRow(e.RowHandle)

            If e.Value = 1 Then

                DrUpdateOrder.Item("NCHECK") = 1

            Else

                DrUpdateOrder.Item("NCHECK") = 0


            End If
            GVSITES.RefreshRow(e.RowHandle)
        End If

    End Sub

    Private Sub BtnCheckAllCAN_Click(sender As Object, e As EventArgs) Handles BtnCheckAllCAN.Click
        CocherAllFilterTous_Or_DecocheAllFilter(_DT_CAN, "NCHECK", GVCAN.ActiveFilterCriteria, True)
        GCCAN.Refresh()
    End Sub

    Private Sub BtnUnCheckAllCAN_Click(sender As Object, e As EventArgs) Handles BtnUnCheckAllCAN.Click
        CocherAllFilterTous_Or_DecocheAllFilter(_DT_CAN, "NCHECK", GVCAN.ActiveFilterCriteria, False)
        GCCAN.Refresh()
    End Sub

  Private Sub BtnCheckAllContrat_Click(sender As Object, e As EventArgs) Handles BtnCheckAllContrat.Click
    CocherAllFilterTous_Or_DecocheAllFilter(_DT_Contrat, "NCHECK", GVContrat.ActiveFilterCriteria, True)
    GCContrat.Refresh()
  End Sub

  Private Sub BtnUnCheckAllContrat_Click(sender As Object, e As EventArgs) Handles BtnUnCheckAllContrat.Click
    CocherAllFilterTous_Or_DecocheAllFilter(_DT_Contrat, "NCHECK", GVContrat.ActiveFilterCriteria, False)
    GCContrat.Refresh()
  End Sub

End Class
