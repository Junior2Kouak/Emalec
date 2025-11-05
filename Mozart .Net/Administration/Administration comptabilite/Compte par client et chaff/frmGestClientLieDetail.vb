Imports System.Data.SqlClient
Imports MozartLib

Public Class frmGestClientLieDetail

  Dim dtCbo As DataTable
  Dim iNCLINUM As Int32
  Dim sNomClient As String

  Public Sub New(ByVal c_iNCLINUM As Object, ByVal c_sNomClient As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNCLINUM = Convert.ToInt32(c_iNCLINUM)
    sNomClient = c_sNomClient.ToString

  End Sub
  Private Sub frmGestCliLieDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LblTitre.Text = LblTitre.Text & sNomClient

    ' chargement de la liste des filiales
    LoadComboFiliale()

  End Sub

  Private Sub cmdNouvelle_Click(sender As Object, e As EventArgs) Handles cmdNouvelle.Click

    Dim sqlcmdUpdate As SqlCommand

    Dim iClientDest As Int32 = ApiComboClient.GetItemData

    If iClientDest = -1 Then
      MsgBox("Il faut choisir un client")
      Exit Sub
    End If

    ' donc insertion dans la table des liaisons de clients 
    ' insert into TL
    Dim ssql As String = "INSERT INTO TCLILIAISON (NCLIORIGINE, NCLIDEST, NCANNUMDEST, DDATELIEN, NQUILIEN) values "
    ssql = ssql & "(" & iNCLINUM & "," & iClientDest & "," & txtCompte.Text & ",'" & Date.Today & "'," & MozartParams.UID & ")"

    sqlcmdUpdate = New SqlCommand(ssql, MozartDatabase.cnxMozart)
    sqlcmdUpdate.ExecuteNonQuery()
    sqlcmdUpdate.Dispose()

    ' ajout des contrats du client d'origine sur le client destination (sauf si ils y sont déjà)
    ' Ajout des contrats sur les sites du client destination
    ssql = "EXEC api_sp_LierContratSite " & iNCLINUM & "," & iClientDest
    sqlcmdUpdate = New SqlCommand(ssql, MozartDatabase.cnxMozart)
    sqlcmdUpdate.ExecuteNonQuery()
    sqlcmdUpdate.Dispose()

    MsgBox("Les clients ont été correctement liés")

    ' fermeture de la fenêtre
    Me.Close()
  End Sub

  Private Sub LoadComboFiliale()

    Dim sqlcmdCbo As SqlCommand
    dtCbo = New DataTable

    ' liste des filiales
    ' uniquement les filiales vers lequelles on a pas déjà une liaison sur un client avec ce client
    ' et pas la société du client en cours bien sur
    ' et pas emalecdev, emafi
    Dim sSQL As String = "SELECT NSOCIETEID, VSOCIETENOM FROM Tsociete where VSOCIETEACTIF = 'O' and NSOCIETEID not in (9,23)"
    sSQL = sSQL & " And VSOCIETENOM Not in (select VSOCIETE from tcli where nclinum = " & iNCLINUM & ")"
    sSQL = sSQL & " And VSOCIETENOM Not in (select VSOCIETE from tcli where nclinum in (SELECT NCLIDEST FROM TCLILIAISON WHERE NCLIORIGINE=" & iNCLINUM & "))"

    sqlcmdCbo = New SqlCommand(sSQL, MozartDatabase.cnxMozart)
    sqlcmdCbo.CommandType = CommandType.Text
    dtCbo.Load(sqlcmdCbo.ExecuteReader)
    CboSociete.DataSource = dtCbo
    CboSociete.SelectedValue = CboSociete.SelectedItem(0)
  End Sub

  Private Sub CboSociete_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSociete.SelectedIndexChanged

    If txtCompte.Text = "" Then Exit Sub

    If Not IsNumeric(txtCompte.Text) Then Exit Sub

    'lors du changement de société et du compte analytique, on change la liste des clients
    Dim sSql As String = "SELECT TCLI.NCLINUM, VCLINOM FROM TCLI inner join TCAN on tcli.nclinum=tcan.nclinum "
    sSql = sSql & "WHERE CCLIACTIF= 'O' AND CCANACTIF='O' AND VSOCIETE = '" & CboSociete.Text & "' AND NCANNUM = " & txtCompte.Text & " ORDER By VCLINOM"
    ApiComboClient.Init(MozartDatabase.cnxMozart, sSql, "NCLINUM", "VCLINOM", New List(Of String)() From {"N°", "Client"}, 500, 500)

  End Sub

  Private Sub txtCompte_TextChanged(sender As Object, e As EventArgs) Handles txtCompte.TextChanged

    If txtCompte.Text = "" Then Exit Sub

    If Not IsNumeric(txtCompte.Text) Then Exit Sub

    'lors du changement de société et du compte analytique, on change la liste des clients
    Dim sSql As String = "SELECT TCLI.NCLINUM, VCLINOM FROM TCLI inner join TCAN on tcli.nclinum=tcan.nclinum "
    sSql = sSql & "WHERE CCLIACTIF= 'O' AND CCANACTIF='O' AND VSOCIETE = '" & CboSociete.Text & "' AND NCANNUM = " & txtCompte.Text & " ORDER By VCLINOM"
    ApiComboClient.Init(MozartDatabase.cnxMozart, sSql, "NCLINUM", "VCLINOM", New List(Of String)() From {"N°", "Client"}, 500, 500)

  End Sub

  Private Sub txtCompte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompte.KeyPress
    ' controle de numéricité du compte analytique
    If (Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar)) Then
      e.Handled = True
    End If
  End Sub

  Private Sub cmdFermer_Click(sender As Object, e As EventArgs) Handles cmdFermer.Click
    Me.Close()
  End Sub

End Class