Imports System.Data.SqlClient
Imports MozartLib

Public Class frmChoixDestMailByAction

  Dim DtListeDest As DataTable

  Dim _NACTNUM As Int32
  Dim _NCLINUM As Int32
  Dim bPJ As Boolean

  Public Sub New(ByVal NACTNUM As Object, ByVal NCLINUM As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NACTNUM = NACTNUM
    _NCLINUM = NCLINUM

  End Sub

  Private Sub frmChoixDestMailByAction_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    DtListeDest = New DataTable

    Dim sqlcmdList As New SqlCommand("api_sp_ListeDestMailAction", MozartDatabase.cnxMozart)
    sqlcmdList.CommandType = CommandType.StoredProcedure
    sqlcmdList.Parameters.Add("@p_NACTNUM", SqlDbType.Int).Value = _NACTNUM
    DtListeDest.Load(sqlcmdList.ExecuteReader)

    DtListeDest.Columns("VCHECK").ReadOnly = False

    GCDestMail.DataSource = DtListeDest

  End Sub

  Private Sub BtnCoche_Click(sender As System.Object, e As System.EventArgs) Handles BtnCoche.Click

    If DtListeDest Is Nothing Then Exit Sub

    CocherAllFilterTous_Or_DecocheAllFilter(DtListeDest, "VCHECK", GVDestMail.ActiveFilterCriteria, True)
    GCDestMail.Refresh()

  End Sub

  Private Sub BtnDecoche_Click(sender As System.Object, e As System.EventArgs) Handles BtnDecoche.Click

    If DtListeDest Is Nothing Then Exit Sub

    CocherAllFilterTous_Or_DecocheAllFilter(DtListeDest, "VCHECK", GVDestMail.ActiveFilterCriteria, False)
    GCDestMail.Refresh()

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub BtnValid_Click(sender As System.Object, e As System.EventArgs) Handles BtnValid.Click

    Dim sListeDestinataire As String = ""

    Try

      If Not DtListeDest Is Nothing AndAlso Not DtListeDest.GetChanges(DataRowState.Modified) Is Nothing Then

        For Each oDtrChecked As DataRow In DtListeDest.GetChanges(DataRowState.Modified).Rows

          If oDtrChecked.Item("VCHECK") = 1 Then

            sListeDestinataire = If(sListeDestinataire = "", oDtrChecked.Item("VMAIL"), oDtrChecked.Item("VMAIL") & ";" & sListeDestinataire)

          End If

        Next

      End If

      If TxtAddMail.Text <> "" Then
        If IsEmail(TxtAddMail.Text) Then
          sListeDestinataire = If(sListeDestinataire = "", TxtAddMail.Text, TxtAddMail.Text & ";" & sListeDestinataire)
        Else
          MessageBox.Show("Le format de l'adresse mail n'est pas correct !", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
          Exit Sub
        End If
      End If


    Catch ex As Exception

      MessageBox.Show(My.Resources.DemandeIntervention_frmChoixDestMailByAction_btnclick + ex.Message)

    End Try

    If sListeDestinataire = "" Then MessageBox.Show(My.Resources.Global_select_desti, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub

    ' choix ajout pj ou pas
    If MessageBox.Show(My.Resources.DemandeIntervention_frmChoixDestMailByAction_note, My.Resources.Global_confirmation_envoi, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
      bPJ = True
    Else
      bPJ = False
    End If

    If MessageBox.Show(My.Resources.DemandeIntervention_frmChoixDestMailByAction_envoi_mail, My.Resources.Global_confirmation_envoi, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

      ' enregistrement de la date de suivi client
      Dim sqlc As New SqlCommand($"Update tactcomp set dactmailcli = GetDate() where nactnum={_NACTNUM}", MozartDatabase.cnxMozart)
      sqlc.CommandType = CommandType.Text
      sqlc.ExecuteNonQuery()
      sqlc.Dispose()


      'load info mail
      Dim sqlDR As SqlDataReader
      Dim sqlcmddata As New SqlCommand("api_sp_SendMailDocClientAction", MozartDatabase.cnxMozart)
      sqlcmddata.CommandType = CommandType.StoredProcedure
      sqlcmddata.Parameters.Add("@p_NACTNUM", SqlDbType.Int).Value = _NACTNUM
      sqlcmddata.Parameters.Add("@P_NCLINUM", SqlDbType.Int).Value = _NCLINUM
      sqlcmddata.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = MozartParams.NomSociete
      sqlcmddata.Parameters.Add("@P_VCOM", SqlDbType.VarChar).Value = TxtObs.Text

      ' gestion du délai d'appro
      ' si rien dans la case, mettre zéro (pas de gestion du délai)
      ' si checkbox cochée, mettre 999 (code qui veut dire pas de délai annoncé mais on communique sur cela)
      If chkAppro.Checked Then
        sqlcmddata.Parameters.Add("@P_NBJREAPPRO", SqlDbType.Int).Value = 999
      Else
        sqlcmddata.Parameters.Add("@P_NBJREAPPRO", SqlDbType.Int).Value = IIf(txtAppro.Text = "", 0, txtAppro.Text)
      End If

      sqlDR = sqlcmddata.ExecuteReader()

      If sqlDR.HasRows = True Then

        While sqlDR.Read

          Dim oMail As New CSendMail
          oMail.Dest = sListeDestinataire
          If (sqlDR.Item("VMAILEXP") <> "") Then
            oMail.CopyDest = sqlDR.Item("VMAILEXP")
          End If

          ' TB SAMSIC CITY SPEC
          ' Email spécifique à Emalec
          oMail.BlindCopyDest = "info@emalec.com"

          oMail.Subject = sqlDR.Item("VSUBJECT")

          oMail.Message = sqlDR.Item("VMAIL")

          ' pièce jointe ou pas selon choix de l'utilisateur
          oMail.PJ = IIf(bPJ, sqlDR.Item("FILE_JOIN"), "")

          oMail.SendMail("HTML")

        End While

      End If

      If sqlDR.IsClosed = False Then sqlDR.Close()

      ' mentionnant un délai d’approvisionnement des fournitures de x jours
      Dim Message As String = ""
      ' si rien dans la case, mettre zéro (pas de gestion du délai)
      ' si checkbox cochée, on communique sur pas de  délai
      Message = String.Format(My.Resources.DemandeIntervention_frmChoixDestMailByAction_envoi_rapport, Now, sListeDestinataire, MozartParams.strUID)
      If chkAppro.Checked Then
        Message &= " mentionnant un délai non connu d’approvisionnement des fournitures"
      ElseIf txtAppro.Text <> "" Then
        Message &= " " & String.Format(My.Resources.DemandeIntervention_frmChoixDestMailByAction_Reappro, txtAppro.Text.ToString)
      End If

      ' ajout des commentaires dans l'obs
      If TxtObs.Text <> "" Then Message &= " " & ".Commentaires: " & TxtObs.Text

      'on mets à jour les observations dans l'action
      Dim sqlcmdUpdateObs As New SqlCommand("api_sp_UpdateActionObs", MozartDatabase.cnxMozart)
      sqlcmdUpdateObs.CommandType = CommandType.StoredProcedure
      sqlcmdUpdateObs.Parameters.Add("@p_NACTNUM", SqlDbType.VarChar).Value = _NACTNUM
      sqlcmdUpdateObs.Parameters.Add("@p_VOBS", SqlDbType.VarChar).Value = Message

      'MsgBox(String.Format("{0} : Envoi rapport action à {1} par {2}", Now, sListeDestinataire, gstrUID))

      sqlcmdUpdateObs.ExecuteNonQuery()

    End If


  End Sub

  Private Sub txtAppro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAppro.KeyPress

    ' controle de numéricité du compte analytique
    If (Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar)) Then
      e.Handled = True
    End If

  End Sub
End Class