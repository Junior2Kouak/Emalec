Imports System.Data.SqlClient
Imports MozartLib

Public Class frmCommandeReapproDetail


  Dim _DTListeFouCommand As DataTable

  Dim _DtCboLieu As DataTable
  Dim bReadOnly As Boolean = False
  Dim oCMDWebTech_Info As CCMDWEBTECH_INFO

  Public Sub New(ByVal c_NCMDWEBNUM As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    oCMDWebTech_Info = New CCMDWEBTECH_INFO(Convert.ToInt32(c_NCMDWEBNUM))

    If oCMDWebTech_Info Is Nothing Then Return

  End Sub

  Private Sub frmCommandeReapproDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'Init
    LoadDataCbo()

    LoadData()

    CboLieuLivr.SelectedValue = oCMDWebTech_Info.CLIEU_LIVR
    DTP_LIVR.Value = oCMDWebTech_Info.DDATELIVR

    GestionColorBtn()

    'passage en read only
    If oCMDWebTech_Info.CCMDWEB_INFO_ETAT = "E" Or oCMDWebTech_Info.CCMDWEB_INFO_ETAT = "S" Then
      bReadOnly = True
    End If
    SetReadOnly()

  End Sub

  Private Sub SetReadOnly()

    If bReadOnly = True Then

      CboLieuLivr.Enabled = False
      DTP_LIVR.Enabled = False
      BtnSave.Visible = False
      BtnPasseCmd.Visible = False
      GVREAPPRO.OptionsBehavior.ReadOnly = True
      GVREAPPRO.OptionsBehavior.Editable = False

    End If

  End Sub

  Private Sub LoadData()

    _DTListeFouCommand = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_CommandeReapproTechDetailListeFO]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_NCMDWEBTECH", SqlDbType.Int).Value = oCMDWebTech_Info.NCMDWEBNUM
    _DTListeFouCommand.Load(sqlcmd.ExecuteReader())

    GCREAPPRO.DataSource = _DTListeFouCommand

  End Sub

  Private Sub LoadDataCbo()

    _DtCboLieu = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListeCbo_LieuLivr]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_LANGUE", SqlDbType.Char).Value = MozartParams.Langue
    _DtCboLieu.Load(sqlcmd.ExecuteReader())

    CboLieuLivr.DataSource = _DtCboLieu

  End Sub

  Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
    Me.Close()
  End Sub

  Private Sub BtnMessage_Click(sender As Object, e As EventArgs) Handles BtnMessage.Click

    Using ofrmCommandeReapproMessageHisto As New frmCommandeReapproMessageHisto(oCMDWebTech_Info.NCMDWEBNUM, oCMDWebTech_Info.VMESSAGE.ToString)

      'read only
      If bReadOnly = True Then ofrmCommandeReapproMessageHisto.BtnMessageAdd.Visible = False
      ofrmCommandeReapproMessageHisto.ShowDialog()
      oCMDWebTech_Info.VMESSAGE = ofrmCommandeReapproMessageHisto.TxtMessages.Text

      GestionColorBtn()

    End Using

  End Sub

  Private Sub GestionColorBtn()

    If oCMDWebTech_Info.VMESSAGE <> "" Then

      BtnMessage.BackColor = Color.Yellow
    Else

      BtnMessage.BackColor = Color.Gainsboro

    End If

  End Sub

  Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

    'on detecte s'il y a eu des modifs
    'si oui, alors on enregistre un message
    Dim DtChanges As DataTable = _DTListeFouCommand.GetChanges(DataRowState.Modified Or DataRowState.Added Or DataRowState.Deleted)

    If DtChanges IsNot Nothing AndAlso DtChanges.Rows.Count > 0 Then

      Dim sqlcmdSave As New SqlCommand("[api_sp_CommandeReapproTechDetail_AddMessage]", MozartDatabase.cnxMozart)
      sqlcmdSave.CommandType = CommandType.StoredProcedure
      sqlcmdSave.Parameters.Add("@P_NCMDWEBTECH", SqlDbType.Int).Value = oCMDWebTech_Info.NCMDWEBNUM
      sqlcmdSave.Parameters.Add("@P_MSGADD", SqlDbType.VarChar).Value = "Votre demande de réappro Dd" & oCMDWebTech_Info.NCMDWEBNUM.ToString & " a été modifiée par le valideur " & MozartParams.strUID & " le " & Now.Date.ToShortDateString & ". Vous pouvez consulter le contenu de ces modifications sur votre portail Web personnel."

      sqlcmdSave.ExecuteNonQuery()

    End If

    For Each drSave As DataRow In _DTListeFouCommand.Rows

      SaveRowCmdReappro(drSave)

    Next

    'on save la date livraison et le lieu de livraison
    Dim sqlSave As New SqlCommand("[api_sp_CommandeReapproTechDetailSave]", MozartDatabase.cnxMozart)
    sqlSave.CommandType = CommandType.StoredProcedure
    sqlSave.Parameters.Add("@P_NCMDWEBTECH", SqlDbType.Int).Value = oCMDWebTech_Info.NCMDWEBNUM
    sqlSave.Parameters.Add("@P_CLIEU_LIVR", SqlDbType.Char).Value = CboLieuLivr.SelectedValue
    sqlSave.Parameters.Add("@P_DDATELIVR", SqlDbType.DateTime).Value = DTP_LIVR.Value
    sqlSave.ExecuteNonQuery()


  End Sub

  Private Sub SaveRowCmdReappro(ByVal dr_data As DataRow)


    Dim sqlcmdSave As New SqlCommand("[api_sp_CommandeReapproTechDetailSaveFO]", MozartDatabase.cnxMozart)
    sqlcmdSave.CommandType = CommandType.StoredProcedure
    sqlcmdSave.Parameters.Add("@P_NCMDWEBTECH", SqlDbType.Int).Value = dr_data.Item("NCMDWEBNUM")
    sqlcmdSave.Parameters.Add("@P_DCMDDATE", SqlDbType.DateTime).Value = dr_data.Item("DCMDDATE")
    sqlcmdSave.Parameters.Add("@P_NFOUNUM", SqlDbType.Int).Value = dr_data.Item("NFOUNUM")
    sqlcmdSave.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = dr_data.Item("NPERNUM")
    sqlcmdSave.Parameters.Add("@P_NCMDQTE", SqlDbType.Int).Value = dr_data.Item("NCMDQTE")

    sqlcmdSave.ExecuteNonQuery()

  End Sub

  Private Sub BtnPasseCmd_Click(sender As Object, e As EventArgs) Handles BtnPasseCmd.Click

    'test définir lieu de livraison
    If CboLieuLivr.SelectedIndex < 0 Then
      MessageBox.Show("Il faut sélectionner un lieu de livraison", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If

    'test sur date livraison
    If DTP_LIVR.Value < Now.AddDays(4) Then
      MessageBox.Show("La date de livraison doit être supérieur à J+4", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If


    If MessageBox.Show("Voulez-vous passer commande à EMALEC pour cette demande de réappro technicien ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      'on sauvegarde avant
      BtnSave.PerformClick()

      Dim sqlcmdSave As New SqlCommand("[api_sp_CommandeReapproTechDetailSaveValidation]", MozartDatabase.cnxMozart)
      sqlcmdSave.CommandType = CommandType.StoredProcedure
      sqlcmdSave.Parameters.Add("@P_NCMDWEBTECH", SqlDbType.Int).Value = oCMDWebTech_Info.NCMDWEBNUM

      sqlcmdSave.ExecuteNonQuery()

      bReadOnly = True

      SetReadOnly()

      'traitement spécifique pour un technicien EMALEC
      If oCMDWebTech_Info.VSOCIETE = "EMALEC" Then

        '********************************************************************************************
        ' création d'une DI est d'une action de fournitures web
        ' passage du nom de la procédure stockée
        Dim cmd As New SqlCommand("", MozartDatabase.cnxMozart)
        Dim iSite As Integer

        Select Case oCMDWebTech_Info.VSOCIETE
          Case "EMALEC"
            iSite = 8974
          Case "FITELEC"
            iSite = 81240
          Case "SCS"
            iSite = 209724
          Case "ALC"
            iSite = 210306
          Case "EQUIPAGE"
            iSite = 100149
          Case "EMALECIDF"
            iSite = 336616  'siège emalec idf
        End Select

        cmd.CommandText = String.Format("Api_sp_www_CreationDIActionReapproWebTech {0}, {1}, '{2}', 'Cde web de {3}'", oCMDWebTech_Info.NPERNUM_DEMAND, iSite, oCMDWebTech_Info.VSOCIETE.Replace("'", "''"), oCMDWebTech_Info.VTECHNOM.Replace("'", "''"))

        ' exécuter la commande.
        ' récupération du numéro crée
        Dim iAction As Int32 = cmd.ExecuteScalar()

        ' gestion des erreurs
        If iAction = 0 Then Exit Sub

        '********************************************************************************************
        ' Mise a jour du numero d'action sur la commande web
        cmd.CommandText = "update TCMDWEBTECH set NACTNUM = " & iAction & " WHERE NCMDWEBNUM= " & oCMDWebTech_Info.NCMDWEBNUM
        cmd.ExecuteNonQuery()

        ''********************************************************************************************
        '' création de la demande de sortie de stock au magasin sur cette action
        cmd.CommandText = "exec api_sp_www_CreationSortieStockReappro " & iAction & ", '" & DTP_LIVR.Value.ToShortDateString & "'"
        cmd.ExecuteNonQuery()

      Else

        'création de la commande sur filiale + creation ss sur EMALEC
        Dim oGestReapproFiliale As New CGESTREAPPROFILIALE(MozartDatabase.cnxMozart, MozartParams.NomSociete)
        oGestReapproFiliale.Init()
        oGestReapproFiliale.NPERNUM_TECH_FILIALE = oCMDWebTech_Info.NPERNUM_DEMAND
        oGestReapproFiliale.TotalHT = 0
        oGestReapproFiliale.Date_Livr = DTP_LIVR.Value

        Select Case CboLieuLivr.SelectedValue.ToString
          Case "T" 'technicien
            oGestReapproFiliale.CreateReapproTechFilialeFromEMALECTo_ATHOME(oCMDWebTech_Info.NCMDWEBNUM)
          Case "E" 'Siege
            oGestReapproFiliale.CreateReapproTechFilialeFromEMALECTo_SiegeFiliale(oCMDWebTech_Info.NCMDWEBNUM)
        End Select

      End If

      'envoi du sms
      'Votre demande de réappro N° a été validée. La date de livraison est prévue le à votre domicile ou au siège de la société.
      Dim sqlSMS As New SqlCommand("[api_sp_CommandeReapproTech_SendSMSValide]", MozartDatabase.cnxMozart)
      sqlSMS.CommandType = CommandType.StoredProcedure
      sqlSMS.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = oCMDWebTech_Info.NPERNUM_DEMAND
      sqlSMS.Parameters.Add("@P_NCMDWEBNUM", SqlDbType.Int).Value = oCMDWebTech_Info.NCMDWEBNUM
      sqlSMS.Parameters.Add("@P_DATELIVR", SqlDbType.DateTime).Value = _DTP_LIVR.Value
      sqlSMS.Parameters.Add("@P_CLIEULIVR", SqlDbType.Char).Value = CboLieuLivr.SelectedValue.ToString
      sqlSMS.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = oCMDWebTech_Info.VSOCIETE

      sqlSMS.ExecuteNonQuery()

      MessageBox.Show("La demande de réappro a été créée avec succès", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End If
  End Sub

End Class