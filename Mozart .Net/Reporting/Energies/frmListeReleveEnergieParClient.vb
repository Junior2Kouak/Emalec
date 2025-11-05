Imports MozartLib

Public Class frmListeReleveEnergieParClient

  Private dtL As DataTable = New DataTable()


  Public Sub New()

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

  End Sub

  Private Sub frmListeReleveEnergieParClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    ModuleMain.Initboutons(Me)

    Dim sSQL As String = $"select distinct C.NCLINUM, VCLINOM from TCLI C INNER JOIN TSIT S ON C.NCLINUM=S.NCLINUM INNER JOIN TCOMPTEURSITE O ON O.NSITNUM=S.NSITNUM WHERE VSOCIETE = '{MozartParams.NomSociete}' order by VCLINOM"
    apicboClient.Init(MozartDatabase.cnxMozart, sSQL, "NCLINUM", "VCLINOM", New List(Of String)() From {"N°", "Client"}, 500, 500)

    'ChargerListe()
    InitApigridSite()

  End Sub

  Private Sub InitApigridSite()

    apiGridSite.AddColumn("Site", "VSITNOM", 2500)
    apiGridSite.AddColumn("Type", "VINFOLIB", 2500)
    apiGridSite.AddColumn("Nom compteur", "VCOMPTNOM", 2500)
    apiGridSite.AddColumn("Numéro", "VCOMPTNUM", 1000)
    apiGridSite.AddColumn("Date Relevé", "DINFODATE", 1200)
    apiGridSite.AddColumn("Relevé", "NINFODATA", 1500, "# ### ###")

    apiGridSite.InitColumnList()

  End Sub

  Private Sub ChargerListe()

    If (apicboClient.GetText() = "") Then
      MessageBox.Show("Il faut sélectionner un client")
      apicboClient.Focus()
      Exit Sub
    End If

    ' Liste des relevés de compteurs des sites du client
    Dim sSQL As String = $"exec api_sp_ListeReleveCompteursParClient  {apicboClient.GetItemData()} , {MozartParams.Langue}"
    apiGridSite.LoadData(dtL, MozartDatabase.cnxMozart, sSQL)
    apiGridSite.GridControl.DataSource = dtL

  End Sub

  Private Sub cmdModifier_Click(sender As Object, e As EventArgs) Handles cmdModifier.Click

    Dim row As DataRow = apiGridSite.GetFocusedDataRow()
    If row Is Nothing Then Exit Sub

    Dim oFrmDetailReleveCompteur As New frmDetailReleveCompteur(row("NSITNUM"), row("NCOMPTID"))
    oFrmDetailReleveCompteur.ShowDialog()

  End Sub

  Private Sub cmdAjout_Click(sender As Object, e As EventArgs) Handles cmdAjout.Click

    ChargerListe()

  End Sub

  Private Sub cmdFermer_Click(sender As Object, e As EventArgs) Handles cmdFermer.Click
    Me.Close()
  End Sub

End Class