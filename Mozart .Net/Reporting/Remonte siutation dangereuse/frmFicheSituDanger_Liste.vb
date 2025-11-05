Imports System.Data.SqlClient
Imports MozartLib

Public Class frmFicheSituDanger_Liste
  Dim dtListeFicSituDanger As DataTable
  Dim _bArchives As Boolean

    Dim nsitnum As Int32
    Public Sub New(Optional ByVal c_nsitnum As Int32 = 0)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        nsitnum = c_nsitnum
    End Sub
    Private Sub frmFicheSituDanger_Liste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'init
    Initboutons(Me)
    _bArchives = False

    initApiTGrid()

    Loaddata()
  End Sub

  Private Sub initApiTGrid()
    With grdFicDang
      .AddColumn("N° DI", "NDINNUM", 500)
      .AddColumn("Date création fiche", "DFICSITUDANG_DATCREE", 1000, "dd/MM/yy", 2)
      .AddColumn("RRET", "VRRETNOM", 1000,)
      .AddColumn("Nom technicien", "VNOMTECH", 1000)
      .AddColumn("Chef de groupe", "VGRPNOM", 1000)
      .AddColumn("Chaff", "VCHAFF", 1000)
      .AddColumn("Client", "VCLINOM", 1000)
      .AddColumn("Site", "VSITNOM", 1200)
      .AddColumn("Situation dangereuse", "SITU_DANG", 500)
      .AddColumn("Presqu'accident", "PRESK_ACCI", 500)
      .AddColumn("Incident environnemental", "INCI_ENVIRON", 500)
      .AddColumn("Employé", "SAL_EMALEC", 500)
      .AddColumn("Environnement", "VICT_ENVIRON", 500)
      .AddColumn("Humaine", "BCHKHUMA", 500)
      .AddColumn("Consigne", "BCHKCONS", 500)
      .AddColumn("Organisation", "BCHKORGA", 500)
      .AddColumn("Formation", "BCHKFORM", 500)
      .AddColumn("Matériel", "BCHKMATE", 500)
      .AddColumn("Milieu", "BCHKMILI", 500)
      .AddColumn("Autre", "BCHKAUTRES", 500)
      .AddColumn("Non employé", "SAL_NON_EMALEC", 500)
      .AddColumn("Risque détecté ou potentiel", "VLIBRISQUE", 1200)
      .AddColumn("Risque cotation", "NCOTATION", 500)
      .AddColumn("Traitement par service QHSE", "BFICSITUDANG_REP_EXIST", 500)
      .AddColumn("Prise en compte de l'analyse par le technicien", "VTECH_LU", 500)
      .AddColumn("Suivi des actions", "VSUIVIACT_ETAT", 500)
      .AddColumn("Détail", "VFAITS_INFO", 2000)
      .AddColumn("NIDFICSITUDANG_SERVER", "NIDFICSITUDANG_SERVER", 0)
      .AddColumn("NACTNUM", "NACTNUM", 0)
      .AddColumn("NPERNUM", "NPERNUM", 0)
      .AddColumn("NIDFICSITUDANG_REP", "NIDFICSITUDANG_REP", 0)
      .AddColumn("NIDFICSITUDANG_SUIVIACT", "NIDFICSITUDANG_SUIVIACT", 0)

      .InitColumnList()
    End With
  End Sub

  Private Sub Loaddata()
    dtListeFicSituDanger = New DataTable

        Dim sqlcmd As New SqlCommand("api_sp_FicSituDanger_Liste", MozartDatabase.cnxMozart) With {
             .CommandType = CommandType.StoredProcedure
            }
        sqlcmd.Parameters.AddWithValue("@p_nsitnum", nsitnum)
        dtListeFicSituDanger.Load(sqlcmd.ExecuteReader())

    Dim dtData As New DataView(dtListeFicSituDanger)

    If _bArchives = True Then
      dtData.RowFilter = "ISNULL(BFICSITUDANG_ACTIF, 1) = 0"
    Else
      dtData.RowFilter = "ISNULL(BFICSITUDANG_ACTIF, 1) = 1"
    End If

    grdFicDang.GridControl.DataSource = dtData
  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Close()
  End Sub

  Private Sub BtnArchives_Click(sender As Object, e As EventArgs) Handles BtnArchives.Click
    If _bArchives = False Then
      _bArchives = True
      LabelTitre.Text = "Liste des fiches de situations dangereuses traitées"
      Me.Text = "Liste des fiches de situations dangereuses traitées"
      BtnArchives.Text = "En attente"
      BtnArchiver.Visible = False
    Else
      _bArchives = False
      LabelTitre.Text = "Liste des fiches de situations dangereuses"
      Me.Text = "Liste des fiches de situations dangereuses"
      BtnArchives.Text = "Archives"
      BtnArchiver.Visible = True
    End If

    Loaddata()
  End Sub

  Private Sub BtnArchiver_Click(sender As Object, e As EventArgs) Handles BtnArchiver.Click
    Dim oDataRowSelect As DataRow = grdFicDang.GetFocusedDataRow()
    If (oDataRowSelect Is Nothing) Then Exit Sub

    If MessageBox.Show("Voulez-vous vraiment archiver cette fiche de situation dangereuse ?", "Archiver", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
      Dim oFicheSituDanger As New CFICSITUDANG(oDataRowSelect.Item("NIDFICSITUDANG_SERVER"), oDataRowSelect.Item("NACTNUM"), oDataRowSelect.Item("NPERNUM"))
      oFicheSituDanger.ArchiverFicheSituDang()
    End If

    Loaddata()
  End Sub

  Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click
    Dim ofrmFicSituDanger_Detail As New frmFicSituDanger_Detail(0, 0, 0, 0, 0)
    ofrmFicSituDanger_Detail.ShowDialog()

    Loaddata()
  End Sub

  Private Sub BtnModif_Click(sender As Object, e As EventArgs) Handles BtnModif.Click, BtnReponse.Click
    Dim oDataRowSelect As DataRow = grdFicDang.GetFocusedDataRow()
    If (oDataRowSelect Is Nothing) Then Exit Sub

    Dim ofrmFicSituDanger_Detail As New frmFicSituDanger_Detail(oDataRowSelect.Item("NIDFICSITUDANG_SERVER"), oDataRowSelect.Item("NACTNUM"),
                                                                oDataRowSelect.Item("NPERNUM"), oDataRowSelect.Item("NIDFICSITUDANG_REP"),
                                                                oDataRowSelect.Item("NIDFICSITUDANG_SUIVIACT"))
    ofrmFicSituDanger_Detail.ShowDialog()

    Loaddata()
  End Sub

End Class