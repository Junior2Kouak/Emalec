Imports System.Data.SqlClient
Imports System.Reflection.MethodBase
Imports MozartLib

Public Class frmGestGammeLie

  Private dtL As DataTable = New DataTable()
  Dim dtCboO As DataTable
  Dim dtCboD As DataTable
  Dim iClientOrigine As Int32
  Dim iClientDest As Int32



  Public Sub New(ByVal c_iClientOrigine As Object, ByVal c_iClientDest As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iClientOrigine = Convert.ToInt32(c_iClientOrigine)
    iClientDest = Convert.ToInt32(c_iClientDest)


  End Sub

  Private Sub frmGestClientLie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'LblTitre.Text = LblTitre.Text & RechercheNomDuSite()

    ModuleMain.Initboutons(Me)

    ChargerListeLiaisons()
    InitApigridLiaison()
    LoadComboGammes()

  End Sub

  Private Sub InitApigridLiaison()

    apiGrid.AddColumn("Client origine", "VCLIORIGINE", 2000)
    apiGrid.AddColumn(My.Resources.col_Numero, "NGAMORIGINE", 1400)
    apiGrid.AddColumn(My.Resources.col_Gamme, "NOMORIGINE", 3500)
    apiGrid.AddColumn("Client destination", "VCLIDEST", 2000)
    apiGrid.AddColumn(My.Resources.col_Numero, "NGAMDEST", 1400)
    apiGrid.AddColumn(My.Resources.col_Gamme, "NOMDEST", 3500)

    apiGrid.InitColumnList()

  End Sub

  Private Sub ChargerListeLiaisons()

    ' Liste des liaisons de sites
    Dim sSQL As String = "exec api_sp_ListeLiaisonGamme " & iClientOrigine & "," & iClientDest
    apiGrid.LoadData(dtL, MozartDatabase.cnxMozart, sSQL)
    apiGrid.GridControl.DataSource = dtL

  End Sub

  Private Sub LoadComboGammes()

    Dim sqlcmdCbo As SqlCommand
    dtCboO = New DataTable
    dtCboD = New DataTable

    Try
      ' liste des gammes du client d' origine sauf celles déjà liées pour le client et de destination sélectionné
      Dim SSQL As String = "SELECT DISTINCT NTRACLINUM, VGAMTYPE  FROM TGAMCLIENT WHERE CTRACLIACTIF = 'O' AND NCLINUM = " & iClientOrigine
      SSQL = SSQL & " AND	NTRACLINUM NOT IN (SELECT NGAMORIGINE FROM TGAMLIAISON G INNER JOIN TGAMCLIENT O "
      SSQL = SSQL & " ON G.NGAMDEST = O.NTRACLINUM  WHERE O.NCLINUM =  " & iClientDest & ") ORDER BY VGAMTYPE"

      sqlcmdCbo = New SqlCommand(SSQL, MozartDatabase.cnxMozart)
      sqlcmdCbo.CommandType = CommandType.Text
      dtCboO.Load(sqlcmdCbo.ExecuteReader)
      CboGamClientOrigine.DataSource = dtCboO
      sqlcmdCbo.Dispose()

      ' liste des gammes du client de destination sauf celles déjà liées
      SSQL = "SELECT DISTINCT NTRACLINUM, VGAMTYPE  FROM TGAMCLIENT WHERE CTRACLIACTIF = 'O' AND NCLINUM = " & iClientDest
      SSQL = SSQL & " AND	NTRACLINUM NOT IN (SELECT NGAMDEST FROM TGAMLIAISON G INNER JOIN TGAMCLIENT O "
      SSQL = SSQL & " ON G.NGAMDEST = O.NTRACLINUM  WHERE O.NCLINUM =  " & iClientDest & ") ORDER BY VGAMTYPE"

      sqlcmdCbo = New SqlCommand(SSQL, MozartDatabase.cnxMozart)
      sqlcmdCbo.CommandType = CommandType.Text
      dtCboD.Load(sqlcmdCbo.ExecuteReader)
      cboGamClientDest.DataSource = dtCboD
      sqlcmdCbo.Dispose()


    Catch ex As Exception
      MessageBox.Show($"{My.Resources.Global_Erreur} : {ex.Message} {My.Resources.Global_dans} {GetCurrentMethod().Name} ({Me.GetType.Name})",
                          My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try
  End Sub

  Private Sub cmdSupLiaison_Click(sender As Object, e As EventArgs) Handles cmdSupprimer.Click
    Dim sqlcmdUpdate As SqlCommand
    Dim Msg As String
    Dim NomSite As String = ""

    Dim row As DataRow = apiGrid.GetFocusedDataRow()
    If row Is Nothing Then Exit Sub

    ' message de confirmation avant de supprimer la liaison
    Msg = String.Format("Merci de confirmer la suppression de la liaison sélectionnée : " & vbCrLf & "{0}" & vbCrLf & "et" & vbCrLf & "{1}", row("NOMORIGINE"), row("NOMDEST"))
    If MessageBox.Show(Msg, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

      ' suppression dans la table des laisons de sites 
      Dim ssql As String = String.Format("DELETE from TGAMLIAISON where NGAMORIGINE={0} and NGAMDEST = {1}", row("NGAMORIGINE"), row("NGAMDEST"))
      sqlcmdUpdate = New SqlCommand(ssql, MozartDatabase.cnxMozart)
      sqlcmdUpdate.ExecuteNonQuery()
      sqlcmdUpdate.Dispose()

      ' rafraichir les listes
      ChargerListeLiaisons()
      LoadComboGammes()
    End If

  End Sub

  Private Sub cmdLierGamme_Click(sender As Object, e As EventArgs) Handles cmdLierGamme.Click


    Dim sqlcmdUpdate As SqlCommand
    Dim Msg As String
    Dim NomSite As String = ""


    ' on test si le site choisi n'est pas déjà lié sur un site du client d'origine pour cette société
    If CboGamClientOrigine.Text = "" Or cboGamClientDest.Text = "" Then
      Msg = "Il faut sélectionner une gamme d'origine et une gamme de destination"
      MessageBox.Show(Msg, My.Resources.Global_Information, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If

    ' message de confirmation avant de copier le site
    Msg = String.Format("Merci de confirmer la création du lien entre la gamme " & vbCrLf & "{0}" & vbCrLf & "et la gamme " & vbCrLf & "{1}", CboGamClientOrigine.Text, cboGamClientDest.Text)
    If MessageBox.Show(Msg, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

      ' insertion dans la table des liaisons de sites 
      Dim ssql As String = "INSERT INTO TGAMLIAISON (NGAMORIGINE, NGAMDEST, DDATELIEN, NQUILIEN) values ("
      ssql = ssql & CboGamClientOrigine.SelectedItem(0) & "," & cboGamClientDest.SelectedItem(0) & ",  Getdate(), " & MozartParams.UID & ")"

      sqlcmdUpdate = New SqlCommand(ssql, MozartDatabase.cnxMozart)
      sqlcmdUpdate.ExecuteNonQuery()
      sqlcmdUpdate.Dispose()

      ' rafraichissement des listes
      ChargerListeLiaisons()
      LoadComboGammes()
    End If

  End Sub

  Private Sub cmdCopierGamme_Click(sender As Object, e As EventArgs) Handles cmdCopierGamme.Click

    Dim sqlcmdUpdate As SqlCommand
    Dim Msg As String

    Try
      ' test si gamme choisi
      If CboGamClientOrigine.Text = "" Then
        Msg = "Il faut sélectionner une gamme d'origine à copier"
        MessageBox.Show(Msg, My.Resources.Global_Information, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
      End If

      ' message de confirmation avant de copier le site
      Msg = "Merci de confirmer que la gamme '" & CboGamClientOrigine.Text & "' n'existe pas sur le client de destination et que vous souhaitez la copier"
      If MessageBox.Show(Msg, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        sqlcmdUpdate = New SqlCommand("api_sp_CopieGamme", MozartDatabase.cnxMozart)
        sqlcmdUpdate.CommandType = CommandType.StoredProcedure
        sqlcmdUpdate.Parameters.Clear()
        'declaration des parametres
        sqlcmdUpdate.Parameters.Add("@iNumGamme", SqlDbType.Int)
        sqlcmdUpdate.Parameters.Add("@iClientDestination", SqlDbType.Int)
        sqlcmdUpdate.Parameters("@iNumGamme").Value = CboGamClientOrigine.SelectedItem(0)
        sqlcmdUpdate.Parameters("@iClientDestination").Value = iClientDest
        sqlcmdUpdate.ExecuteNonQuery()

        sqlcmdUpdate.Dispose()

        ' rafraichir liste gamme
        LoadComboGammes()
      End If

    Catch ex As Exception

      MessageBox.Show($"{My.Resources.Global_Erreur} : {ex.Message} {My.Resources.Global_dans} {GetCurrentMethod().Name} ({Me.GetType.Name})",
                        My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try
  End Sub


  Private Sub cmdFermer_Click(sender As Object, e As EventArgs) Handles cmdFermer.Click
    Me.Close()
  End Sub


End Class