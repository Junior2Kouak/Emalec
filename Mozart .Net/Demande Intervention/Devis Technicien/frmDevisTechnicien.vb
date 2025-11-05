Imports MozartLib

Public Class frmDevisTechnicien

  Dim oDevistechDetail As CDEVISTECH

  Dim IsLoadingForm As Boolean = False

  Public Sub New(ByVal c_oDevisTech As CDEVISTECH)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    oDevistechDetail = c_oDevisTech

  End Sub

  Private Sub frmDevisTechnicien_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    IsLoadingForm = True

    AfficheData()

    IsLoadingForm = False

  End Sub

  Private Sub AfficheData()

    txtTitre.Text = oDevistechDetail.VDEVISTECHTITRE
    txtSujet.Text = oDevistechDetail.VDEVISTECHSUJET
    txtConstat.Text = oDevistechDetail.VDEVISTECHCONSTAT
    txtPrestation.Text = oDevistechDetail.VDEVISTECHPREST
    txtFourniture.Text = oDevistechDetail.VDEVISTECHFOU
    txtHeuresJ.Text = oDevistechDetail.NDEVISTECHHJ
    txtHeuresHP.Text = oDevistechDetail.NDEVISTECHHP
    txtHeuresHN.Text = oDevistechDetail.NDEVISTECHHN
    TxtSecu.Text = oDevistechDetail.VDEVISTECHSECU

    If oDevistechDetail.NDEVISTECHNB = 1 Then
      rb1tech.Checked = True
      rb2tech.Checked = False
    ElseIf oDevistechDetail.NDEVISTECHNB = 2 Then
      rb1tech.Checked = False
      rb2tech.Checked = True
    Else
      rb1tech.Checked = False
      rb2tech.Checked = False
    End If

    cboClient.ValueMember = "NCLINUM"
    cboClient.DisplayMember = "VCLINOM"

    cboSite.ValueMember = "NSITNUM"
    cboSite.DisplayMember = "VSITNOM"

    cboCompte.ValueMember = "NCANNUM"
    cboCompte.DisplayMember = "VCANLIB"

    cboClient.DataSource = oDevistechDetail.GetDataTableClient()
    cboClient.SelectedValue = oDevistechDetail.NCLINUM


  End Sub

  Private Sub BtnQuit_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuit.Click
    Me.Close()
  End Sub

  Private Sub BtnValider_Click(sender As System.Object, e As System.EventArgs) Handles BtnValider.Click

    'Verif des champs        
    If cboClient.Text = "" Then
      MessageBox.Show(My.Resources.DemandeIntervention_frmDevisTechnicien_MsgSelectClient, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Warning)
      Exit Sub
    End If
    If cboSite.Text = "" Then
      MessageBox.Show(My.Resources.DemandeIntervention_frmDevisTechnicien_MsgSelectSite, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Warning)
      Exit Sub
    End If
    If cboCompte.Text = "" Then
      MessageBox.Show(My.Resources.DemandeIntervention_frmDevisTechnicien_MsgSelectCompte, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Warning)
      Exit Sub
    End If

    If txtHeuresJ.Text <> "" Then
      If IsNumeric(txtHeuresJ.Text) = False Then
        MessageBox.Show(My.Resources.DemandeIntervention_frmDevisTechnicien_MsgFormatJ, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Exit Sub
      End If
    End If
    If txtHeuresHP.Text <> "" Then
      If IsNumeric(txtHeuresHP.Text) = False Then
        MessageBox.Show(My.Resources.DemandeIntervention_frmDevisTechnicien_MsgFormatP, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Exit Sub
      End If
    End If
    If txtHeuresHN.Text <> "" Then
      If IsNumeric(txtHeuresHN.Text) = False Then
        MessageBox.Show(My.Resources.DemandeIntervention_frmDevisTechnicien_MsgFormatN, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Exit Sub
      End If
    End If

    oDevistechDetail.DDEVISTECHDATE = Now
    oDevistechDetail.DDEVISTECHSAISIE = DateTimeSaisie.Text

    oDevistechDetail.VDEVISTECHTITRE = txtTitre.Text
    oDevistechDetail.VDEVISTECHSUJET = txtSujet.Text
    oDevistechDetail.VDEVISTECHCONSTAT = txtConstat.Text
    oDevistechDetail.VDEVISTECHPREST = txtPrestation.Text
    oDevistechDetail.VDEVISTECHFOU = txtFourniture.Text
    oDevistechDetail.NDEVISTECHHJ = txtHeuresJ.Text
    oDevistechDetail.NDEVISTECHHP = txtHeuresHP.Text
    oDevistechDetail.NDEVISTECHHN = txtHeuresHN.Text

    oDevistechDetail.VDEVISTECHSECU = TxtSecu.Text

    If rb1tech.Checked = True Then
      oDevistechDetail.NDEVISTECHNB = 1
    ElseIf rb2tech.Checked = True Then
      oDevistechDetail.NDEVISTECHNB = 2
    Else
      oDevistechDetail.NDEVISTECHNB = 0
    End If

    If MessageBox.Show("Voulez-vous enregistrer ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

      oDevistechDetail.SaveDevisTech()

    End If


  End Sub

  Private Sub cboClient_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboClient.SelectedIndexChanged

    'selection auto des sites et compte du client
    If cboClient.SelectedIndex >= 0 Then

      oDevistechDetail.NCLINUM = cboClient.SelectedItem.item(0)
      oDevistechDetail.VCLINOM = cboClient.SelectedItem.item(1)
      cboSite.DataSource = oDevistechDetail.GetDataTableSiteByClient(oDevistechDetail.NCLINUM, MozartParams.UID)
      cboCompte.DataSource = oDevistechDetail.GetDataTableCompteByClient(oDevistechDetail.NCLINUM, MozartParams.UID)

      If IsLoadingForm = True Then

        cboSite.SelectedValue = oDevistechDetail.NSITNUM
        cboCompte.SelectedValue = oDevistechDetail.NDINCTE

      End If

    Else

      oDevistechDetail.NCLINUM = 0
      oDevistechDetail.VCLINOM = ""
      cboSite.Items.Clear()
      cboCompte.Items.Clear()

    End If

  End Sub

  Private Sub cboSite_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSite.SelectedIndexChanged
    If cboSite.SelectedIndex >= 0 Then
      oDevistechDetail.NSITNUM = cboSite.SelectedItem.item(0)
      oDevistechDetail.VSITNOM = cboSite.SelectedItem.item(1)
    Else
      oDevistechDetail.NSITNUM = 0
      oDevistechDetail.VSITNOM = ""
    End If
  End Sub

  Private Sub cboCompte_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCompte.SelectedIndexChanged
    If cboSite.SelectedIndex >= 0 Then
      oDevistechDetail.NDINCTE = cboCompte.SelectedItem.item(0)
    Else
      oDevistechDetail.NDINCTE = 0
    End If
  End Sub

  Private Sub BtnAjoutPhotos_Click(sender As System.Object, e As System.EventArgs) Handles BtnAjoutPhotos.Click

    If oDevistechDetail.NDEVISTECHNUM > 0 Then
      Dim ofrmDevisTechPhotos As New frmDevisTechnicienPhotos(oDevistechDetail.NDEVISTECHNUM)
      ofrmDevisTechPhotos.ShowDialog()
    Else
      MessageBox.Show("Il faut enregistrer le devis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If

  End Sub
End Class