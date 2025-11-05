

Imports MozartLib

Public Class frmGestClientLie

  Private dt As DataTable = New DataTable()
  Dim iNCLINUM As Int32
  Dim sNomClient As String


  Public Sub New(ByVal c_iNCLINUM As Object, ByVal c_sNomClient As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNCLINUM = Convert.ToInt32(c_iNCLINUM)
    sNomClient = c_sNomClient.ToString

  End Sub

  Private Sub frmGestClientLie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LblTitre.Text = LblTitre.Text & sNomClient

    ModuleMain.Initboutons(Me)

    ChargerListe()
    InitApigrid()

  End Sub

  Private Sub InitApigrid()

    apiGrid.AddColumn(My.Resources.col_Societe, "VSOCIETE", 2000)
    apiGrid.AddColumn(My.Resources.col_Client, "VCLINOM", 2500)
    apiGrid.AddColumn(My.Resources.col_Compte, "NCANNUMDEST", 1500)

    apiGrid.InitColumnList()

  End Sub

  Private Sub cmdNouvelle_Click(sender As Object, e As EventArgs) Handles cmdNouvelle.Click
    Dim oFrmGestClientLieDetail As New frmGestClientLieDetail(iNCLINUM, sNomClient)
    oFrmGestClientLieDetail.ShowDialog()

    ' rafraichissement de la liste lorsque ajout
    ChargerListe()

  End Sub

  Private Sub ChargerListe()

    ' rafraichissement de la liste lorsque ajout
    Dim sSQL As String = "exec api_sp_ListeLiaisonClient " & iNCLINUM
    apiGrid.LoadData(dt, MozartDatabase.cnxMozart, sSQL)
    apiGrid.GridControl.DataSource = dt

  End Sub

  Private Sub cmdGammes_Click(sender As Object, e As EventArgs) Handles cmdGammes.Click

    Dim row As DataRow = apiGrid.GetFocusedDataRow()
    If row Is Nothing Then Exit Sub

    Dim oFrmGestGammeLie As New frmGestGammeLie(iNCLINUM, row("NCLIDEST"))
    oFrmGestGammeLie.ShowDialog()

  End Sub
End Class