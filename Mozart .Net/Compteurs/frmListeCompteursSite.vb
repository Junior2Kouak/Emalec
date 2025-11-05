
Imports System.Data.SqlClient
Imports System.Reflection.MethodBase
Imports MozartLib

Public Class frmListeCompteursSite

  Private dtL As DataTable = New DataTable()
  Dim iNSITNUM As Int32


  Public Sub New(ByVal c_iNSITNUM As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNSITNUM = Convert.ToInt32(c_iNSITNUM)


  End Sub

  Private Sub frmListeCompteursSite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LblTitre.Text = LblTitre.Text & RechercheNomDuSite()

    ModuleMain.Initboutons(Me)

    ChargerListeCompteurs()
    InitApigridSite()

  End Sub

  Private Sub InitApigridSite()

    apiGridSite.AddColumn("Nom compteur", "VCOMPTNOM", 2500)
    apiGridSite.AddColumn("Type", "VINFOLIB", 2500)
    apiGridSite.AddColumn("Numéro", "VCOMPTNUM", 1000)
    apiGridSite.AddColumn("Emplacement", "VCOMPTLIEU", 2000)
    apiGridSite.AddColumn("Création", "DCOMPTDATE", 1500)
    apiGridSite.AddColumn("Remarque", "VCOMPTOBS", 1200)
    apiGridSite.AddColumn("Identifiant Adaptiv", "VNUMLIASON", 1500)

    apiGridSite.InitColumnList()

  End Sub

  Private Sub ChargerListeCompteurs()

    ' Liste des liaisons de sites
    Dim sSQL As String = "exec api_sp_ListeCompteursSite " & iNSITNUM
    apiGridSite.LoadData(dtL, MozartDatabase.cnxMozart, sSQL)
    apiGridSite.GridControl.DataSource = dtL

  End Sub

  Private Sub cmdSupLiaison_Click(sender As Object, e As EventArgs) Handles cmdSupprimer.Click
    Dim sqlcmdUpdate As SqlCommand
    Dim Msg As String
    Dim NomSite As String = ""

    If (dtL.Rows.Count = 0) Then Exit Sub

    Dim row As DataRow = apiGridSite.GetFocusedDataRow()
    If row Is Nothing Then Exit Sub

    ' on test si la suppression est possible ?
    'If Not RechercheSiSiteEtLibre(row("NSITNUM"), NomSite) Then
    '  Msg = "Ce site est déjà lié avec un autre site (" & NomSite & ") du client d'origine." & vbCrLf & "Vous ne pouvez pas le choisir"
    '  MessageBox.Show(Msg, My.Resources.Global_Information, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '  Exit Sub
    'End If

    ' message de confirmation avant de supprimer le compteur
    Msg = String.Format("Merci de confirmer la suppression du compteur sélectionné")
    If MessageBox.Show(Msg, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

      ' suppression dans la table des compteurs
      Dim ssql As String = String.Format("DELETE from TCOMPTEURSITE where NCOMPTID={0}", row("NCOMPTID"))
      sqlcmdUpdate = New SqlCommand(ssql, MozartDatabase.cnxMozart)
      sqlcmdUpdate.ExecuteNonQuery()
      sqlcmdUpdate.Dispose()

      ' rafraichir la liste
      ChargerListeCompteurs()

    End If

  End Sub

  Private Function RechercheNomDuSite() As String

    Dim sqlcmd As SqlCommand
    Dim dr As SqlDataReader

    Try
      RechercheNomDuSite = ""
      ' 
      ' recherche si le client est lié a un client pour cette société
      Dim SSQL As String = "SELECT VSITNOM FROM TSIT WHERE NSITNUM=" & iNSITNUM

      sqlcmd = New SqlCommand(SSQL, MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.Text
      dr = sqlcmd.ExecuteReader()

      If dr.HasRows Then
        dr.Read()
        RechercheNomDuSite = dr("VSITNOM")
      End If

      dr.Close()
      sqlcmd.Dispose()

    Catch ex As Exception
      RechercheNomDuSite = ""
      MessageBox.Show($"{My.Resources.Global_Erreur} : {ex.Message} {My.Resources.Global_dans} {GetCurrentMethod().Name} ({Me.GetType.Name})",
                          My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Try
  End Function

  Private Sub cmdFermer_Click(sender As Object, e As EventArgs) Handles cmdFermer.Click
    Me.Close()
  End Sub

  Private Sub cmdModifier_Click(sender As Object, e As EventArgs) Handles cmdModifier.Click

    Dim row As DataRow = apiGridSite.GetFocusedDataRow()
    If row Is Nothing Then Exit Sub

    Dim oFrmDetailCompteurSite As New frmDetailCompteurSite(iNSITNUM, row("NCOMPTID"))
    oFrmDetailCompteurSite.ShowDialog()

    ChargerListeCompteurs()

  End Sub

  Private Sub cmdAjout_Click(sender As Object, e As EventArgs) Handles cmdAjout.Click

    ' ajout d'un nouveau compteur (passsage avec compteur = 0)
    Dim oFrmDetailCompteurSite As New frmDetailCompteurSite(iNSITNUM, 0)
    oFrmDetailCompteurSite.ShowDialog()

    ChargerListeCompteurs()

  End Sub
End Class