
Imports System.Data.SqlClient
Imports System.Reflection.MethodBase
Imports MozartLib

Public Class frmGestSiteLie

  Private dtL As DataTable = New DataTable()
  Private dtSite As DataTable = New DataTable()
  Dim dtCbo As DataTable
  Dim iNSITNUM As Int32
  Dim sNomSite As String
  Dim iClientLie As Int32

  Public Sub New(ByVal c_iNSITNUM As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNSITNUM = Convert.ToInt32(c_iNSITNUM)


  End Sub

  Private Sub frmGestClientLie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LblTitre.Text = LblTitre.Text & RechercheNomDuSite()

    ModuleMain.Initboutons(Me)

    ChargerListeLiaisons()
    InitApigridLiaison()
    InitApigridSite()

  End Sub

  Private Sub InitApigridLiaison()

    apiGrid.AddColumn(My.Resources.col_Societe, "VSOCIETE", 2000)
    apiGrid.AddColumn(My.Resources.col_Client, "VCLINOM", 2500)
    apiGrid.AddColumn(My.Resources.col_Site, "VSITNOM", 2500)
    apiGrid.AddColumn(My.Resources.col_Numero, "NSITNUE", 1500)

    apiGrid.InitColumnList()

  End Sub

  Private Sub InitApigridSite()

    'apiGrid.AddColumn(My.Resources.col_Societe, "VSOCIETE", 2000)

    ApiGridSite.AddColumn(My.Resources.col_Site, "VSITNOM", 2500)
    ApiGridSite.AddColumn(My.Resources.col_Enseigne, "VSITENSEIGNE", 2500)
    ApiGridSite.AddColumn(My.Resources.col_Numero, "NSITNUE", 1000)
    ApiGridSite.AddColumn(My.Resources.col_Adresse, "VSITAD1", 2000)
    ApiGridSite.AddColumn(My.Resources.col_Adresse, "VSITAD2", 1500)
    ApiGridSite.AddColumn(My.Resources.col_CP, "VSITCP", 1200)
    ApiGridSite.AddColumn(My.Resources.col_Ville, "VSITVIL", 1500)


    ApiGridSite.InitColumnList()

  End Sub

  Private Sub cmdAjoutLiaison_Click(sender As Object, e As EventArgs) Handles cmdAjoutLiaison.Click

    ' chargement de la combo filiale
    LoadComboFiliale()

    ' affichage de la form
    Panel1.Visible = True

  End Sub

  Private Sub ChargerListeLiaisons()

    ' Liste des liaisons de sites
    Dim sSQL As String = "exec api_sp_ListeLiaisonSite " & iNSITNUM
    apiGrid.LoadData(dtL, MozartDatabase.cnxMozart, sSQL)
    apiGrid.GridControl.DataSource = dtL

  End Sub

  Private Sub ChargerListeSites()

    ' liste des sites du client lié
    Dim sSQL As String = "select NSITNUM,VSITNOM,VSITENSEIGNE,NSITNUE,VSITAD1,VSITAD2,VSITCP,VSITVIL FROM TSIT WHERE CSITACTIF='O' AND NCLINUM=" & iClientLie
    ApiGridSite.LoadData(dtSite, MozartDatabase.cnxMozart, sSQL)
    ApiGridSite.GridControl.DataSource = dtSite

  End Sub

  Private Sub LoadComboFiliale()

    Dim sqlcmdCbo As SqlCommand
    dtCbo = New DataTable

    Try
      ' liste des filiales
      ' uniquement les filiales vers lequelles on a pas déjà une liaison sur un site avec ce site
      ' et pas la société du site en cours bien sur
      ' et pas romania, alc, emalecdev
      Dim sSQL As String = "Select NSOCIETEID, VSOCIETENOM FROM Tsociete where VSOCIETEACTIF = 'O' and NSOCIETEID not in (20,5,9)"
      sSQL = sSQL & " And VSOCIETENOM Not in (select VSOCIETE from tcli C INNER JOIN TSIT S ON S.NCLINUM=C.NCLINUM where S.NSITNUM = " & iNSITNUM & ")"
      sSQL = sSQL & " And VSOCIETENOM Not in (select VSOCIETE from tcli where nclinum in (select nclinum from tsit where nsitnum in  "
      sSQL = sSQL & " (SELECT NSITDEST FROM TSITLIAISON WHERE NSITORIGINE=" & iNSITNUM & ")))"

      sqlcmdCbo = New SqlCommand(sSQL, MozartDatabase.cnxMozart)
      sqlcmdCbo.CommandType = CommandType.Text
      dtCbo.Load(sqlcmdCbo.ExecuteReader)
      CboSociete.DataSource = dtCbo
      CboSociete.SelectedValue = CboSociete.SelectedItem(0)

    Catch ex As Exception
      MessageBox.Show($"{My.Resources.Global_Erreur} : {ex.Message} {My.Resources.Global_dans} {GetCurrentMethod().Name} ({Me.GetType.Name})",
                          My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try
  End Sub

  Private Sub CboSociete_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSociete.SelectedIndexChanged

    ' recherche du client lié dans cette filiale
    iClientLie = RechercheClientFilialeLie()

  End Sub

  Private Sub CmdRechercherSite_Click(sender As Object, e As EventArgs) Handles CmdRechercherSite.Click

    ' test si le client du site actuel est bien lié sur un client dans la filiale choisie
    If iClientLie > 0 Then
      ' affiche de la lite des sites du client lié  
      ChargerListeSites()

      PanelSite.Location = New Point(7, 7)
      PanelSite.Visible = True
      Panel1.Visible = False
    Else
      MessageBox.Show("Ce client n'a pas de lien dans cette filiale" & vbCrLf & "Vous devez d'abord paramétrer le client lié", My.Resources.Global_Information, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub
  Private Sub cmdSupLiaison_Click(sender As Object, e As EventArgs) Handles cmdSupprimer.Click
    Dim sqlcmdUpdate As SqlCommand
    Dim Msg As String
    Dim NomSite As String = ""

    ' liaison du site choisi avec le site actuel
    If (dtL.Rows.Count = 0) Then Exit Sub

    'If (ApiGridSite.GetFocusedDataRow() Is Nothing) Then Exit Sub

    Dim row As DataRow = apiGrid.GetFocusedDataRow()
    If row Is Nothing Then Exit Sub

    ' on test si la suppression est possible ?
    'If Not RechercheSiSiteEtLibre(row("NSITNUM"), NomSite) Then
    '  Msg = "Ce site est déjà lié avec un autre site (" & NomSite & ") du client d'origine." & vbCrLf & "Vous ne pouvez pas le choisir"
    '  MessageBox.Show(Msg, My.Resources.Global_Information, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '  Exit Sub
    'End If

    ' message de confirmation avant de supprimer la liaison
    Msg = String.Format("Merci de confirmer la suppression de la liaison sélectionnée {0}  {1} ", sNomSite, row("VSITNOM"))
    If MessageBox.Show(Msg, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

      ' suppression dans la table des laisons de sites 
      Dim ssql As String = String.Format("DELETE from TSITLIAISON where NSITORIGINE={0} and NSITDEST = {1}", iNSITNUM, row("NSITNUM"))
      sqlcmdUpdate = New SqlCommand(ssql, MozartDatabase.cnxMozart)
      sqlcmdUpdate.ExecuteNonQuery()
      sqlcmdUpdate.Dispose()

      ' rafraichir la liste
      ChargerListeLiaisons()

    End If

  End Sub

  Private Sub cmdLierSite_Click(sender As Object, e As EventArgs) Handles cmdLierSite.Click

    Dim sqlcmdUpdate As SqlCommand
    Dim Msg As String
    Dim NomSite As String = ""

    ' liaison du site choisi avec le site actuel
    If (dtSite.Rows.Count = 0) Then Exit Sub

    'If (ApiGridSite.GetFocusedDataRow() Is Nothing) Then Exit Sub

    Dim row As DataRow = ApiGridSite.GetFocusedDataRow()
    If row Is Nothing Then Exit Sub

    ' on test si le site choisi n'est pas déjà lié sur un site du client d'origine pour cette société
    If Not RechercheSiSiteEtLibre(row("NSITNUM"), NomSite) Then
      Msg = "Ce site est déjà lié avec un autre site (" & NomSite & ") du client d'origine." & vbCrLf & "Vous ne pouvez pas le choisir"
      MessageBox.Show(Msg, My.Resources.Global_Information, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If

    ' message de confirmation avant de copier le site
    Msg = String.Format("Merci de confirmer la création du lien entre le site d'origine {0} et le site de réception filiale  {1}", sNomSite, row("VSITNOM"))
    If MessageBox.Show(Msg, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

      ' insertion dans la table des liaisons de sites 
      Dim ssql As String = "INSERT INTO TSITLIAISON (NSITORIGINE, NSITDEST, DDATELIEN, NQUILIEN) values ("
      ssql = ssql & iNSITNUM & "," & row("NSITNUM") & ",  Getdate(), " & MozartParams.UID & ")"

      sqlcmdUpdate = New SqlCommand(ssql, MozartDatabase.cnxMozart)
      sqlcmdUpdate.ExecuteNonQuery()
      sqlcmdUpdate.Dispose()

      ' update dans la table TCONT des contrats du site de destination en fonction des contrats du site d'origine
      ' les contrats sont insérés lors de la liaison des clients donc normalement ils existent bien dans TCONT pour le site destination
      ssql = "UPDATE TCONT SET VCONTETAT='OUI' WHERE NSITNUM=" & row("NSITNUM") & " And NTYPECONTRAT in (select NTYPECONTRAT from tcont where NSITNUM = " & iNSITNUM & ")"

      sqlcmdUpdate = New SqlCommand(ssql, MozartDatabase.cnxMozart)
      sqlcmdUpdate.ExecuteNonQuery()
      sqlcmdUpdate.Dispose()

      ' fermeture fenêtre et rafraichissement liste
      ChargerListeLiaisons()
      PanelSite.Visible = False
    End If

  End Sub

  Private Sub cmdCopierSite_Click(sender As Object, e As EventArgs) Handles cmdCopierSite.Click

    Dim sqlcmdUpdate As SqlCommand
    Dim Msg As String

    Try
      ' test si le client du site actuel est bien lié sur un client dans la filiale choisie
      If iClientLie > 0 Then

        ' test si le nom du site existe déjà et sortie si c'est le cas
        If RechercheSiNomDuSiteExiste() Then
          Msg = "Un site avec le même nom existe déjà dans le client lié." & vbCrLf & "Vous ne pouvez pas copier ce site"
          MessageBox.Show(Msg, My.Resources.Global_Information, MessageBoxButtons.OK, MessageBoxIcon.Information)
          Exit Sub
        End If

        ' message de confirmation avant de copier le site
        Msg = "Merci de confirmer que le site n'existe pas dans la filiale et que vous souhaitez copier ce site "
        If MessageBox.Show(Msg, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
          ' création du site sur le client lié dans la filiale (NCLINUM=iClientLie)
          ' et ajout du lien du site créé avec le site actuel
          sqlcmdUpdate = New SqlCommand("api_sp_CreationSiteEtLiasonFiliale", MozartDatabase.cnxMozart)
          sqlcmdUpdate.CommandType = CommandType.StoredProcedure
          sqlcmdUpdate.Parameters.Clear()
          'declaration des parametres
          sqlcmdUpdate.Parameters.Add("@iClientDestination", SqlDbType.Int)
          sqlcmdUpdate.Parameters.Add("@iSiteOrigine", SqlDbType.Int)
          sqlcmdUpdate.Parameters("@iClientDestination").Value = iClientLie
          sqlcmdUpdate.Parameters("@iSiteOrigine").Value = iNSITNUM
          sqlcmdUpdate.ExecuteNonQuery()

          sqlcmdUpdate.Dispose()

          ' fermeture fenêtre et rafraichissement liste
          ChargerListeLiaisons()
          Panel1.Visible = False
        End If

      Else
        MessageBox.Show("Ce client n'a pas de lien dans cette filiale" & vbCrLf & "Vous devez d'abord paramétrer le client lié", My.Resources.Global_Information, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If

    Catch ex As Exception

      MessageBox.Show($"{My.Resources.Global_Erreur} : {ex.Message} {My.Resources.Global_dans} {GetCurrentMethod().Name} ({Me.GetType.Name})",
                        My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try
  End Sub

  Private Function RechercheClientFilialeLie() As Int32

    Dim sqlcmd As SqlCommand
    Dim dr As SqlDataReader

    Try
      RechercheClientFilialeLie = 0
      ' 
      ' recherche si le client est lié a un client pour cette société
      Dim SSQL As String = "SELECT L.NCLIDEST FROM TCLI INNER JOIN TCLILIAISON L ON TCLI.NCLINUM=L.NCLIDEST "
      SSQL = SSQL & " AND L.NCLIORIGINE = (SELECT NCLINUM FROM TSIT WHERE NSITNUM=" & iNSITNUM & ")"
      SSQL = SSQL & " WHERE TCLI.VSOCIETE = '" & CboSociete.Text & "'"

      sqlcmd = New SqlCommand(SSQL, MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.Text
      dr = sqlcmd.ExecuteReader()

      If dr.HasRows Then
        dr.Read()
        RechercheClientFilialeLie = dr("NCLIDEST")
      End If

      dr.Close()
      sqlcmd.Dispose()

    Catch ex As Exception
      RechercheClientFilialeLie = 0
      MessageBox.Show($"{My.Resources.Global_Erreur} : {ex.Message} {My.Resources.Global_dans} {GetCurrentMethod().Name} ({Me.GetType.Name})",
                          My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Try
  End Function

  Private Function RechercheSiNomDuSiteExiste() As Boolean

    Dim sqlcmd As SqlCommand
    Dim dr As SqlDataReader

    Try
      RechercheSiNomDuSiteExiste = False
      ' 
      ' recherche si le site existe déjà sur le client lié pour cette société
      Dim SSQL As String = "SELECT NSITNUM FROM TSIT WHERE NCLINUM=" & iClientLie & " AND VSITNOM='" & sNomSite & "'"

      sqlcmd = New SqlCommand(SSQL, MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.Text
      dr = sqlcmd.ExecuteReader()

      If dr.HasRows Then RechercheSiNomDuSiteExiste = True

      dr.Close()
      sqlcmd.Dispose()

    Catch ex As Exception
      RechercheSiNomDuSiteExiste = True
      MessageBox.Show($"{My.Resources.Global_Erreur} : {ex.Message} {My.Resources.Global_dans} {GetCurrentMethod().Name} ({Me.GetType.Name})",
                          My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Try
  End Function

  Private Function RechercheSiSiteEtLibre(ByVal iSite As Int32, ByRef NomDuSite As String) As Boolean

    Dim sqlcmd As SqlCommand
    Dim dr As SqlDataReader

    Try
      RechercheSiSiteEtLibre = True

      'Dim SSQL As String = "SELECT NSITDEST FROM TSITLIAISON WHERE NSITDEST=" & iSite
      'SSQL = SSQL & " AND NSITORIGINE IN (SELECT NSITNUM FROM TSIT WHERE NCLINUM=(SELECT NCLINUM FROM TSIT WHERE NSITNUM=" & iNSITNUM & "))"

      ' recherche si le site choisi n'est pas déjà lié à un site sur le client lié pour cette société
      Dim SSQL As String = "SELECT VSITNOM FROM TSITLIAISON L INNER JOIN TSIT S ON S.NSITNUM=L.NSITORIGINE WHERE NSITDEST=" & iSite
      SSQL = SSQL & "  AND S.NCLINUM=(SELECT NCLINUM FROM TSIT WHERE NSITNUM=" & iNSITNUM & ")"

      sqlcmd = New SqlCommand(SSQL, MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.Text
      dr = sqlcmd.ExecuteReader()

      If dr.HasRows Then
        RechercheSiSiteEtLibre = False
        dr.Read()
        NomDuSite = dr("VSITNOM").ToString
      End If

      dr.Close()
      sqlcmd.Dispose()

    Catch ex As Exception
      RechercheSiSiteEtLibre = False
      MessageBox.Show($"{My.Resources.Global_Erreur} : {ex.Message} {My.Resources.Global_dans} {GetCurrentMethod().Name} ({Me.GetType.Name})",
                          My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Try
  End Function

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

  Private Sub cmdCacherPanel_Click(sender As Object, e As EventArgs) Handles cmdCacherPanel.Click
    Panel1.Visible = False
  End Sub

  Private Sub cmdFermerPanelSite_Click(sender As Object, e As EventArgs) Handles cmdFermerPanelSite.Click
    Panel1.Visible = True
    PanelSite.Visible = False
  End Sub

End Class