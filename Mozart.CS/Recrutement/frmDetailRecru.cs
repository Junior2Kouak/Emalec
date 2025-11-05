using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDetailRecru : Form
  {

    public string mstrStatut = "";
    public int miNumPer = 0;
    public string msLibNomSoc;

    bool bPrem = true;
    private string[] tFormats = new string[0];
    private string strImage = "";
    private string strRepImage = "";

    public frmDetailRecru()
    {
      InitializeComponent();
    }

    private void frmDetailRecru_Load(object sender, EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        bPrem = true;

        Label1.Text += " - " + msLibNomSoc;
        cmdTransfert.Text = cmdTransfert.Text.Replace("$NomSoc", msLibNomSoc);

        //  recherche du répertoire de sauvegarde des images sur le serveur
        strRepImage = ModuleData.RechercheParam("REP_PHOTOS_PER", msLibNomSoc);

        ModuleData.RemplirCboFormat(cboImgFormat, ref tFormats);
        ModuleData.RemplirCombo(cboPays, "select NPAYSNUM, VPAYSNOM from TPAYS order by VPAYSNOM");
        cboPays.ValueMember = "NPAYSNUM";
        cboPays.DisplayMember = "VPAYSNOM";

        ModuleData.RemplirCombo(cboService, "select NSERNUM, VSERLIB from TSER WHERE NSERACTIF = 1 ORDER BY VSERLIB");
        cboService.ValueMember = "NSERNUM";
        cboService.DisplayMember = "VSERLIB";

        cboContrat.Init(MozartDatabase.cnxMozart, $"SELECT NTYPECONTRATSAL, VTYPECONTRATSAL FROM TREF_TYPECONTRATSAL WHERE LANGUE='{MozartParams.Langue}' ORDER BY VTYPECONTRATSAL",
                        "NTYPECONTRATSAL", "VTYPECONTRATSAL", new List<string>() { Resources.col_Num, Resources.col_Contrat }, 200, 200);

        fillCboSituation();

        //  traitement du cas de modification ou de création
        if (mstrStatut == "C")
          OuvertureEnCreation();
        else
          OuvertureEnModification();

        //  couleur des boutons
        int? count = ModuleData.ExecuteScalarInt("SELECT count(NIDFICPERSO) FROM dbo.TFICPERSO WHERE NIDPERSO = " + miNumPer + " and VTYPE='RECRU'");
        CmdDocPerso.BackColor = count == 0 ? Color.White : Color.Gold;
        bPrem = false;

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()

    //Dim adoDocPerso As Recordset

    //On Error GoTo handler

    //  InitBoutons Me, frmMenu

    //  imgX = Image1.Left
    //  ImgY = Image1.Top
    //  ImgH = Image1.height
    //  ImgW = Image1.width

    //  bPrem = True

    //  Label1.Caption = Label1.Caption & " - " & IIf(gstrNomSocieteTemp = "GROUPE", sLibNomSoc, gstrNomSocieteTemp)
    //  cmdTransfert.Caption = Replace(cmdTransfert.Caption, "$NomSoc", IIf(gstrNomSocieteTemp = "GROUPE", sLibNomSoc, gstrNomSocieteTemp))

    //  ' recherche du répertoire de sauvegarde des images sur le serveur
    //  'mRepertoireDoc = RechercheParam("REP_PHOTOS_PER")
    //  mRepertoireDoc = RepSortieBySociete("REP_PHOTOS_PER", IIf(gstrNomSocieteTemp = "GROUPE", sLibNomSoc, gstrNomSocieteTemp))

    //  RemplirCboFormat cboImgFormat, tFormats()
    //  RemplirCombo cboPays, "select NPAYSNUM, VPAYSNOM from TPAYS order by VPAYSNOM", , True
    //  RemplirCombo cboService, "select NSERNUM, VSERLIB from TSER WHERE NSERACTIF = 1 ORDER BY VSERLIB"

    //  ' traitement du cas de modification ou de création
    //  If Me.mstrStatut = "C" Then
    //    OuvertureEnCreation
    //  Else
    //    OuvertureEnModification
    //  End If

    //  'couleur des boutons
    //  Set adoDocPerso = New ADODB.Recordset
    //  adoDocPerso.Open "SELECT count(NIDFICPERSO) FROM dbo.TFICPERSO WHERE NIDPERSO = " & Me.miNumPer & " and VTYPE='RECRU'", cnx
    //  CmdDocPerso.BackColor = IIf(adoDocPerso(0) = 0, &H8000000F, &H80FFFF)
    //  adoDocPerso.Close
    //  Set adoDocPerso = Nothing

    //  bPrem = False

    //Exit Sub
    //Resume
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    private void chkGrp_CheckedChanged(object sender, EventArgs e)
    {
      if (bPrem) return;

      if (chkGrp.Visible)
        MessageBox.Show(Resources.msg_person_visible_if_checked, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    //Private Sub chkGrp_Click()
    //  If bPrem Then Exit Sub
    //  MsgBox "§Si coché, la personne est visible sur toutes les messageries des entreprises du groupe EMALEC§"
    //End Sub

    private void CmdDocPerso_Click(object sender, EventArgs e)
    {
      if (miNumPer == 0) return;

      new frmListeFicPerso
      {
        msLibNomSoc = msLibNomSoc,
        mstrNomPerso = txtNom.Text,
        mstrPrenomPerso = txtprenom.Text,
        mlIdPerso = miNumPer,
        mstrTypePerso = "RECRU"
      }.ShowDialog();
    }
    //Private Sub CmdDocPerso_Click()
    //  If Me.miNumPer = 0 Then Exit Sub

    //  frmListeFicPerso.sLibNomSoc = IIf(gstrNomSocieteTemp = "GROUPE", sLibNomSoc, gstrNomSocieteTemp)
    //  frmListeFicPerso.mstrNomPerso = txtNom.Text
    //  frmListeFicPerso.mstrPrenomPerso = txtprenom.Text
    //  frmListeFicPerso.mlIdPerso = Me.miNumPer
    //  frmListeFicPerso.mstrTypePerso = "RECRU"
    //  frmListeFicPerso.Show vbModal
    //End Sub

    private void cmdTransfert_Click(object sender, EventArgs e)
    {
      try
      {
        if (miNumPer == 0)
          return;

        if (MessageBox.Show(Resources.msg_confirm_transfer_person, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
          return;

        //  ' test si le transfert n'a pas déjà été fait
        int count = (int)ModuleData.ExecuteScalarInt("select count(*) from TPER where VSOCIETE = '" + msLibNomSoc + "' AND VPERNOM ='" + txtNom.Text + "' and vperpre = '" + txtprenom.Text + "'");
        if (count > 0)
        {
          MessageBox.Show(Resources.msg_this_person_already_exist, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        //  Transfert des données
        int iNewPer = (int)ModuleData.ExecuteScalarInt($"EXEC api_sp_CreationPersonnelAtRecru2 {miNumPer}");

        //  copie des compétences techniciens
        ModuleData.ExecuteNonQuery($"insert into TPERTYPECONTRAT select {iNewPer}, NTYPECONTRAT from TRECRUTYPECONTRAT where NPERNUM = {iNewPer}");

        //  transfert des documents perso : ici iNewPer = NPERNUM de TPER et miNumPer = IDRECRU de TRECRU
        //  Renommer les fichier par le NPERNUM
        RenameFichPersoForTransfert(miNumPer, iNewPer);
        ModuleData.ExecuteNonQuery($"UPDATE TFICPERSO SET VTYPE='PERSO', NIDPERSO = {iNewPer} WHERE VTYPE = 'RECRU' AND NIDPERSO = {miNumPer}");

        //  transfert de la fiche personnelle
        ModuleData.ExecuteNonQuery($"exec api_sp_TransfertFichePersonelleRecruToPer {miNumPer}, {iNewPer}");

        //  archiver le contact
        ModuleData.ExecuteNonQuery($"UPDATE TRECRU set CPERACTIF = 'N' WHERE NPERNUM = {miNumPer}");

        MessageBox.Show(Resources.msg_transfer_ended_with_success, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cboType_SelectedIndexChanged(object sender, EventArgs e)
    {
      cmdContrat.Enabled = cboType.Text.ToUpper().StartsWith("TE");
    }
    //Private Sub cboType_Click()
    //  If Left(cboType.Text, 2) = "TE" Then
    //    cmdContrat.Enabled = True
    //  Else
    //    cmdContrat.Enabled = False
    //  End If
    //End Sub

    private void cmdCarte_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        frmBrowser f = new frmBrowser();

        f.msStartingAddress = "https://maps.emalec.com/SiteParAdresse.asp?NOM=" + txtNom.Text + "&AD1=" + txtAD1.Text + "&VILLE=" + txtCP.Text + " " + cboVille.Text + "&PAYS=" + cboPays.Text;
        f.ShowDialog();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

    }
    //Private Sub cmdCarte_Click()
    //On Error GoTo handler
    //  Screen.MousePointer = vbHourglass

    //  frmBrowser.StartingAddress = "http://maps.emalec.com/SiteParAdresse.asp?NOM=" & txtNom & "&AD1=" & txtAD1 & "&VILLE=" & txtCP & " " & cboVille.Text & "&PAYS=" & cboPays.Text
    //  frmBrowser.Show vbModal

    //  Screen.MousePointer = vbDefault

    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //End Sub

    private void cmdContrat_Click(object sender, EventArgs e)
    {
      frmSaisieContratTech f = new frmSaisieContratTech
      {
        miNumTech = miNumPer,
        mstrType = "RECRU"
      };
      f.Text = f.Text + " (" + txtNom.Text + " " + txtprenom.Text + ")";
      f.ShowDialog();
    }
    //Private Sub cmdContrat_Click()
    //  frmSaisieContratTech.miNumTech = miNumPer
    //  frmSaisieContratTech.mstrType = "RECRU"
    //  frmSaisieContratTech.Caption = frmSaisieContratTech.Caption & " (" & txtNom & " " & txtprenom & ")"
    //  frmSaisieContratTech.Show vbModal
    //End Sub

    private void cmdFichePerso_Click(object sender, EventArgs e)
    {
      if (miNumPer == 0)
      {
        MessageBox.Show(Resources.msg_must_save_record, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      
      new frmFicheRecru(miNumPer).ShowDialog();
    }
    //Private Sub cmdFichePerso_Click()

    //    If miNumPer = 0 Then
    //        MsgBox "§Il faut enregistrer la fiche§", vbInformation
    //        Exit Sub
    //    End If
    //    VerifMOZARTNET
    //    Shell gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " " & "frmFicheRecru" & " " & miNumPer, vbNormalFocus
    //End Sub

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      try
      {
        // Champs obligatoires
        if (txtNom.Text == "") { MessageBox.Show(Resources.msg_must_type_nom_personne, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtNom.Focus(); return; }
        if (txtprenom.Text == "") { MessageBox.Show(Resources.msg_must_type_prenom_personne, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtprenom.Focus(); return; }
        if (cboCiv.Text == "") { MessageBox.Show(Resources.msg_must_type_civilite_personne, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); cboCiv.Focus(); return; }
        if (cboRegion.Text == "") { MessageBox.Show(Resources.msg_must_type_region_personne, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); cboRegion.Focus(); return; }
        if (cboService.Text == "") { MessageBox.Show(Resources.msg_must_type_service_personne, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); cboService.Focus(); return; }
        if (cboType.Text == "") { MessageBox.Show(Resources.msg_must_type_type_personne, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); cboType.Focus(); return; }
        if (txtDateEntree.Text == "") { MessageBox.Show(Resources.msg_must_type_date_entree, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtDateEntree.Focus(); return; }

        // Champs date
        if (txtDateNaissance.Text != "" && !Utils.IsDate(txtDateNaissance.Text)) { MessageBox.Show(Resources.msg_date_invalide, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtDateNaissance.Focus(); return; }
        if (txtDateEntreeInt.Text != "" && !Utils.IsDate(txtDateEntreeInt.Text)) { MessageBox.Show(Resources.msg_date_invalide, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtDateEntreeInt.Focus(); return; }
        if (txtDateEntree.Text != "" && !Utils.IsDate(txtDateEntree.Text)) { MessageBox.Show(Resources.msg_date_invalide, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtDateEntree.Focus(); return; }
        if (txtDateSortie.Text != "" && !Utils.IsDate(txtDateSortie.Text)) { MessageBox.Show(Resources.msg_date_invalide, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtDateSortie.Focus(); return; }
        if (txtDateHabilitation.Text != "" && !Utils.IsDate(txtDateHabilitation.Text)) { MessageBox.Show(Resources.msg_date_invalide, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtDateHabilitation.Focus(); return; }
        if (txtDateAvance.Text != "" && !Utils.IsDate(txtDateAvance.Text)) { MessageBox.Show(Resources.msg_date_invalide, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtDateAvance.Focus(); return; }
        if (txtDateVisite.Text != "" && !Utils.IsDate(txtDateVisite.Text)) { MessageBox.Show(Resources.msg_date_invalide, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtDateVisite.Focus(); return; }

        // Champs numériques
        if (txtNumStd.Text != "" && !Utils.IsNumeric(txtNumStd.Text)) { MessageBox.Show(Resources.msg_champ_numerique, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ; txtNumStd.Focus(); return; }
        if (txtAvance.Text != "" && !Utils.IsNumeric(txtAvance.Text)) { MessageBox.Show(Resources.msg_champ_numerique, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtAvance.Focus(); return; }
        if (txtNbHeures.Text != "" && !Utils.IsNumeric(txtNbHeures.Text)) { MessageBox.Show(Resources.msg_champ_numerique, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtNbHeures.Focus(); return; }
        if (txtSalaire.Text != "" && !Utils.IsNumeric(txtSalaire.Text)) { MessageBox.Show(Resources.msg_champ_numerique, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtSalaire.Focus(); return; }
        if (txtNumStd.Text != "" && !Utils.IsNumeric(txtNumStd.Text)) { MessageBox.Show(Resources.msg_champ_numerique, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtNumStd.Focus(); return; }

        Enregistrer();

        // on passe la feuille en statut modifier
        mstrStatut = "M";
        OuvertureEnModification();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdEnregistrer_Click()
    //On Error GoTo handler

    //  ' Champs obligatoires
    //  If txtNom.Text = "" Then MsgBox "§Saisissez le nom de la personne§":         txtNom.SetFocus:        Exit Sub
    //  If txtprenom.Text = "" Then MsgBox "§Saisissez le prénom de la personne§":   txtprenom.SetFocus:     Exit Sub
    //  If cboCiv.Text = "" Then MsgBox "Saisissez la civilité de la personne":    cboCiv.SetFocus:        Exit Sub
    //  If cboRegion.Text = "" Then MsgBox "Saisissez la région de la personne":   cboRegion.SetFocus:     Exit Sub
    //  If cboService.Text = "" Then MsgBox "Saisissez le service de la personne": cboService.SetFocus:    Exit Sub
    //  If cboType.Text = "" Then MsgBox "Saisissez le type de la personne":       cboType.SetFocus:       Exit Sub
    //  If txtDateEntree.Text = "" Then MsgBox "§Saisissez la date d'entrée §":      txtDateEntree.SetFocus: Exit Sub

    //  ' Champs date
    //  If txtDateNaissance <> "" And Not IsDate(txtDateNaissance) Then MsgBox "§Date invalide§": txtDateNaissance.SetFocus: Exit Sub
    //  If txtDateEntreeInt <> "" And Not IsDate(txtDateEntreeInt) Then MsgBox "§Date invalide§": txtDateEntreeInt.SetFocus: Exit Sub
    //  If txtDateEntree <> "" And Not IsDate(txtDateEntree) Then MsgBox "§Date invalide§": txtDateEntree.SetFocus: Exit Sub
    //  If txtDateSortie <> "" And Not IsDate(txtDateSortie) Then MsgBox "§Date invalide§": txtDateSortie.SetFocus: Exit Sub
    //  If txtDateHabilitation <> "" And Not IsDate(txtDateHabilitation) Then MsgBox "§Date invalide§": txtDateHabilitation.SetFocus: Exit Sub
    //  If txtDateAvance <> "" And Not IsDate(txtDateAvance) Then MsgBox "§Date invalide§": txtDateAvance.SetFocus: Exit Sub
    //  If txtDateVisite <> "" And Not IsDate(txtDateVisite) Then MsgBox "§Date invalide§": txtDateVisite.SetFocus: Exit Sub

    //  ' Champs numériques
    //  If txtNumStd <> "" And Not IsNumeric(txtNumStd) Then MsgBox "§Ce champ doit être numérique§": txtNumStd.SetFocus: Exit Sub
    //  If txtAvance <> "" And Not IsNumeric(txtAvance) Then MsgBox "§Ce champ doit être numérique§": txtAvance.SetFocus: Exit Sub
    //  If txtNbHeures <> "" And Not IsNumeric(txtNbHeures) Then MsgBox "§Ce champ doit être numérique§": txtNbHeures.SetFocus: Exit Sub
    //  If txtSalaire <> "" And Not IsNumeric(txtSalaire) Then MsgBox "§Ce champ doit être numérique§": txtSalaire.SetFocus: Exit Sub
    //  If txtNumStd <> "" And Not IsNumeric(txtNumStd) Then MsgBox "§Ce champ doit être numérique§": txtNumStd.SetFocus: Exit Sub

    //  Call Enregistrer

    //  ' on passe la feuille en statut modifier
    //  Me.mstrStatut = "M"
    //  Call OuvertureEnModification
    //  Exit Sub
    //  Resume

    //handler:
    //  ShowError "cmdEnregistrer_Click dans " & Me.Name
    //End Sub

    private void cmdVisualiser_Click(object sender, EventArgs e)
    {
      if (miNumPer == 0)
      {
        MessageBox.Show(Resources.msg_print_not_possible_must_save_fiche, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      string[,] TdbGlobal = { { "Date", DateTime.Now.ToShortDateString() } };
      string CheminModelesTemp = ModuleData.RechercheParam("REP_MODELES", msLibNomSoc);

      frmBrowser f = new frmBrowser();
      f.Preview_Print(CheminModelesTemp + MozartParams.Langue + @"\TFichePersonnelPhoto2.rtf",
                      @"TFichePersonnel.Out.rtf",
                      TdbGlobal,
                      "exec api_sp_InfoRecruRtf " + miNumPer.ToString() + "," + msLibNomSoc,
                      " (Visualisation fiche personnel)",
                      "PREVIEW");
    }
    //Private Sub cmdVisualiser_Click()

    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //Dim gstrCheminModelesTemp As String


    //  On Error Resume Next

    //  If miNumPer = 0 Then
    //    MsgBox "§Impression impossible, il faut enregistrer la fiche§", vbInformation
    //    Exit Sub
    //  Else

    //    TdbGlobal(0, 0) = "Date"
    //    TdbGlobal(0, 1) = Date

    //    gstrCheminModelesTemp = RechercheParam("REP_MODELES", IIf(gstrNomSocieteTemp = "GROUPE", sLibNomSoc, gstrNomSocieteTemp))

    //    frmBrowser.bPlanningAn = 0
    //    frmBrowser.Preview_Print gstrCheminModelesTemp & gstrLangue & "\" & "TFichePersonnelPhoto2.rtf", _
    //                           "\TFichePersonnel.Out.rtf", _
    //                           TdbGlobal(), _
    //                           "exec api_sp_InfoRecruRtf " & miNumPer & "," & IIf(gstrNomSocieteTemp = "GROUPE", sLibNomSoc, gstrNomSocieteTemp), _
    //                           " (Visualisation fiche personnel)", _
    //                           "PREVIEW"
    //  End If

    //End Sub

    private void cmdRecherche_Click(object sender, EventArgs e)
    {
      new frmRechCodePostal
      {
        ControlCible1 = txtCP,
        ControlCible2 = cboVille
      }.ShowDialog();
    }

    private void fillCboSituation()
    {
      ModuleData.RemplirCombo(cboSituation, "SELECT NSITUFAM, VSITUFAM from commun.dbo.TREF_SITUFAM WHERE LANGUE='" + MozartParams.Langue + "'order by NSITUFAM");
      cboSituation.ValueMember = "NSITUFAM";
      cboSituation.DisplayMember = "VSITUFAM";
    }

    private void OuvertureEnCreation()
    {
      try
      {
        //  renseignement de la partie client
        //foreach (Control ctrl in Utils.GetAllControls(this, typeof(TextBox)))
        //  ctrl.Text = "";

        strImage = "";

        cboSituation.SelectedValue = 8;

        cboPays.Text = "FRANCE";
        ModuleData.RemplirCombo(cboRegion, "select NREGCOD, VDEPLIB from TREF_REG where npaysnum = " + cboPays.GetItemData() + " order by VDEPLIB");
        cboRegion.ValueMember = "NREGCOD";
        cboRegion.DisplayMember = "VDEPLIB";

        cboContrat.SetItemData(3);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub OuvertureEnCreation()
    //Dim c As Object
    //On Error GoTo handler

    //  ' renseignement de la partie client
    //  For Each c In Me.Controls
    //    If TypeOf c Is TextBox Then c.Text = ""
    //  Next
    //  strImage = ""
    //  RemplirCombo cboSituation, "select NSITUFAM, VSITUFAM from commun.dbo.TREF_SITUFAM WHERE LANGUE='" & gstrLangue & "'order by NSITUFAM", , True
    //  'Non connue
    //  SelectLB cboSituation, 8
    //  cboPays.Text = "FRANCE"
    //  RemplirCombo cboRegion, "select NREGCOD, VDEPLIB from TREF_REG where npaysnum = " & cboPays.ItemData(cboPays.ListIndex) & " order by VDEPLIB", , True
    //Exit Sub
    //handler:
    //  ShowError "OuvertureEnCreation dans " & Me.Name
    //End Sub

    private void OuvertureEnModification()
    {
      try
      {
        //  recherche des informations de l'action
        using (SqlDataReader pRS = ModuleData.ExecuteReader("EXEC api_sp_InfoRecru " + miNumPer + ", " + msLibNomSoc))
        {
          if (pRS.Read())
          {
            txtNom.Text = Utils.BlankIfNull(pRS["VPERNOM"]);
            txtprenom.Text = Utils.BlankIfNull(pRS["VPERPRE"]);
            cboCiv.Text = Strings.Trim(Utils.BlankIfNull(pRS["CPERCIV"]));

            txtAD1.Text = Utils.BlankIfNull(pRS["VPERAD1"]);
            txtAD2.Text = Utils.BlankIfNull(pRS["VPERAD2"]);
            txtCP.Text = Utils.BlankIfNull(pRS["VPERCP"]);
            txtVille.Text = Utils.BlankIfNull(pRS["VPERVIL"]);

            txtTel.Text = Utils.BlankIfNull(pRS["VPERTEL"]);
            txtFax.Text = Utils.BlankIfNull(pRS["VPERFAX"]);
            txtMail.Text = Utils.BlankIfNull(pRS["VPERMAI"]);
            txtPort.Text = Utils.BlankIfNull(pRS["VPERPOR"]);
            txtNumStd.Text = Utils.BlankIfNull(pRS["NPERSTD"]);
            cboService.Text = pRS["VSERLIB"].ToString();
            cboType.Text = pRS["CPERTYP"].ToString();
            cboContrat.SetItemData(Convert.ToInt32(pRS["NPERCONTRAT"]));
            txtDateEntree.Text = Utils.DateBlankIfNull(pRS["DPERENT"]);
            txtDateEntreeInt.Text = Utils.DateBlankIfNull(pRS["DPERENTINT"]);
            txtDateSortie.Text = Utils.DateBlankIfNull(pRS["DPERSOR"]);
            txtDateNaissance.Text = Utils.DateBlankIfNull(pRS["DPERNAI"]);
            txtAnciennete.Text = Utils.BlankIfNull(pRS["ANC"]);
            txtAncienneteInt.Text = Utils.BlankIfNull(pRS["ANCINT"]);
            txtAge.Text = Utils.BlankIfNull(pRS["Age"]);
            cboCollege.Text = pRS["VPERCOL"].ToString();
            txtCategorie.Text = pRS["VPERCAT"].ToString();
            txtEchelon.Text = pRS["VPERECH"].ToString();
            txtNiveau.Text = pRS["VPERNIV"].ToString();
            txtCoef.Text = pRS["VPERCOE"].ToString();
            txtNbHeures.Text = pRS["NPERHEU"].ToString();
            txtSalaire.Text = pRS["NPERSAL"] == DBNull.Value ? "" : Strings.FormatNumber(pRS["NPERSAL"], 2);
            txtCoutHor.Text = pRS["NPERCOU"] == DBNull.Value ? "" : Strings.FormatNumber(pRS["NPERCOU"], 2);
            txtDateHabilitation.Text = Utils.DateBlankIfNull(pRS["DPERHAB"]);
            txtDateAvance.Text = Utils.DateBlankIfNull(pRS["DPERAVF"]);
            txtDateVisite.Text = Utils.DateBlankIfNull(pRS["DPERVIS"]);
            txtAvance.Text = pRS["NPERMAV"] == DBNull.Value ? "" : Strings.FormatNumber(pRS["NPERMAV"], 2);
            if (pRS["VPERSITFAM"] != DBNull.Value)
              cboSituation.Text = pRS["VPERSITFAM"].ToString();
            if (Strings.InStr(1, pRS["VPERPERMI"].ToString(), "B", CompareMethod.Text) > 0)
              chkB.Checked = true;
            if (Strings.InStr(1, pRS["VPERPERMI"].ToString(), "C", CompareMethod.Text) > 0)
              chkC.Checked = true;
            if (Strings.InStr(1, pRS["VPERPERMI"].ToString(), "E", CompareMethod.Text) > 0)
              chkE.Checked = true;
            chkGrp.Checked = Convert.ToInt32(pRS["BGROUPE"]) == 0;

            cboSituation.SelectedValue = pRS["NSITUFAM"] != DBNull.Value ? Convert.ToInt32(pRS["NSITUFAM"]) : 8;

            cboVille.Text = pRS["VPERVIL"].ToString();      // combo de la ville
            if (cboVille.SelectedIndex == -1)
            {
              cboVille.Items.Add(pRS["VPERVIL"].ToString());
              cboVille.Text = pRS["VPERVIL"].ToString();
            }

            cboPays.Text = pRS["VPERPAYS"].ToString();     // combo des pays
            if (cboPays.SelectedIndex == -1)
            {
              cboPays.Items.Add(pRS["VPERPAYS"].ToString());
              cboPays.SelectedValue = pRS["VPERPAYS"].ToString();
            }

            ModuleData.RemplirCombo(cboRegion, "SELECT NREGCOD, VDEPLIB from TREF_REG where npaysnum = " + cboPays.GetItemData() + " order by VDEPLIB");
            cboRegion.ValueMember = "NREGCOD";
            cboRegion.DisplayMember = "VDEPLIB";
            cboRegion.SelectedValue = Convert.ToInt32(pRS["NREGCOD"]);

            if (Utils.BlankIfNull(pRS["VPERIMAGE"]) != "")
            {
              strImage = strRepImage + pRS["VPERIMAGE"].ToString();
              ImageEnModification(pRS["VPERIMAGE"].ToString());
            }
            else
              strImage = "";

            //  Remplir la grille d'historique
            //  Cette grille n'est pas utilisée

            // si la personne est un technicien, la saisie des compétences preventives est possible
            if (Strings.Left(cboType.Text, 2) != "TE")
              cmdContrat.Enabled = false;

            //  gestion des droit sur les données restreintes
            //  on affiche pas les informations de salaires
#if ! APITECHTEST
            Frame6.Visible = Convert.ToBoolean(pRS["DROITSAL"]);
            Frame11.Visible = Convert.ToBoolean(pRS["DROITSAL"]);
            cmdVisualiser.Visible = Convert.ToBoolean(pRS["DROITSAL"]);
            cmdFichePerso.Visible = Convert.ToBoolean(pRS["DROITSAL"]);
#endif
          }
          pRS.Close();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub OuvertureEnModification()
    //Dim pRS As ADODB.Recordset
    //On Error GoTo handler


    //  ' 'recherche des informations de l'action
    //  Set pRS = New ADODB.Recordset
    //  pRS.Open "exec api_sp_InfoRecru " & miNumPer & "," & IIf(gstrNomSocieteTemp = "GROUPE", sLibNomSoc, gstrNomSocieteTemp), cnx

    //  txtNom = BlankIfNull(pRS("VPERNOM"))
    //  txtprenom = BlankIfNull(pRS("VPERPRE"))
    //  cboCiv = Trim(BlankIfNull(pRS("CPERCIV")))

    //  txtAD1 = BlankIfNull(pRS("VPERAD1"))
    //  txtAD2 = BlankIfNull(pRS("VPERAD2"))
    //  txtCP = BlankIfNull(pRS("VPERCP"))
    //  txtVille = BlankIfNull(pRS("VPERVIL"))

    //  txtTel = BlankIfNull(pRS("VPERTEL"))
    //  txtFax = BlankIfNull(pRS("VPERFAX"))
    //  txtMail = BlankIfNull(pRS("VPERMAI"))
    //  txtPort = BlankIfNull(pRS("VPERPOR"))
    //  txtNumStd = BlankIfNull(pRS("NPERSTD"))
    //  cboService.Text = pRS("VSERLIB")
    //  cboType.Text = pRS("CPERTYP")
    //  txtContrat = BlankIfNull(pRS("CPERTCT2"))
    //  txtDateEntree = BlankIfNull(pRS("DPERENT"))
    //  txtDateEntreeInt = BlankIfNull(pRS("DPERENTINT"))
    //  txtDateSortie = BlankIfNull(pRS("DPERSOR"))
    //  txtDateNaissance = BlankIfNull(pRS("DPERNAI"))
    //  txtAnciennete = BlankIfNull(pRS("ANC"))
    //  txtAncienneteInt = BlankIfNull(pRS("ANCINT"))
    //  txtAge = BlankIfNull(pRS("Age"))
    //  cboCollege = pRS("VPERCOL")
    //  txtCategorie = pRS("VPERCAT") & ""
    //  txtEchelon = pRS("VPERECH") & ""
    //  txtNiveau = pRS("VPERNIV") & ""
    //  txtCoef = pRS("VPERCOE") & ""
    //  txtNbHeures = pRS("NPERHEU") & ""
    //  txtSalaire = IIf(IsNull(pRS("NPERSAL")), "", FormatNumber(pRS("NPERSAL"), 2))
    //  txtCoutHor = IIf(IsNull(pRS("NPERCOU")), "", FormatNumber(pRS("NPERCOU"), 2))
    //  txtDateHabilitation = pRS("DPERHAB") & ""
    //  txtDateAvance = pRS("DPERAVF") & ""
    //  txtDateVisite = pRS("DPERVIS") & ""
    //  txtAvance = IIf(IsNull(pRS("NPERMAV")), "", FormatNumber(pRS("NPERMAV"), 2))
    //  If Not IsNull(pRS("VPERSITFAM")) Then cboSituation.Text = pRS("VPERSITFAM")
    //  If InStr(1, pRS("VPERPERMI"), "B", vbTextCompare) > 0 Then chkB = 1
    //  If InStr(1, pRS("VPERPERMI"), "C") > 0 Then chkC = 1
    //  If InStr(1, pRS("VPERPERMI"), "E") > 0 Then chkE = 1
    //  chkGrp = IIf(pRS("BGROUPE") = 0, 0, 1)

    //  RemplirCombo cboSituation, "select NSITUFAM, VSITUFAM from commun.dbo.TREF_SITUFAM WHERE LANGUE='" & gstrLangue & "'order by NSITUFAM", , True

    //  If Not IsNull(pRS("NSITUFAM")) Then

    //    SelectLB cboSituation, pRS("NSITUFAM")

    //  Else

    //    SelectLB cboSituation, 8

    //  End If

    //On Error Resume Next

    //  cboVille.Text = pRS("VPERVIL")      ' combo de la ville
    //  If Err Then
    //    cboVille.AddItem pRS("VPERVIL")
    //    cboVille.Text = pRS("VPERVIL")
    //  End If
    //  Err.Clear

    //  cboPays.Text = pRS("VPERPAYS")      ' combo du pays
    //  If Err Then
    //    cboPays.AddItem pRS("VPERPAYS")
    //    cboPays.Text = pRS("VPERPAYS")
    //  End If
    //  Err.Clear

    //  RemplirCombo cboRegion, "select NREGCOD, VDEPLIB from TREF_REG where npaysnum = " & cboPays.ItemData(cboPays.ListIndex) & " order by VDEPLIB", , True
    //  SelectLB cboRegion, pRS("NREGCOD")

    //On Error GoTo handler

    //  If pRS("VPERIMAGE") <> "" And Not IsNull(pRS("VPERIMAGE")) Then
    //    strImage = mRepertoireDoc & pRS("VPERIMAGE")
    //    ImageEnModification pRS("VPERIMAGE")
    //  Else
    //    strImage = ""
    //  End If

    //  ' Remplir la grille d'historique
    //  Dim db As New ADODB.Connection
    //  db.CursorLocation = adUseClient
    //  db.Open gstrConnectionSA

    //  ' si la personne est un technicien, la saisie des compétences preventives est possible
    //  If Left(cboType.Text, 2) <> "TE" Then
    //    cmdContrat.Enabled = False
    //  End If

    //  '
    //  ' gestion des droit sur les données restreintes
    //  ' on affiche pas les informations de salaires
    //  If pRS("DROITSAL") Then
    //    Frame6.Visible = True
    //    Frame11.Visible = True
    //    cmdVisualiser.Visible = True
    //    cmdFichePerso.Visible = True
    //  Else
    //    Frame6.Visible = False
    //    Frame11.Visible = False
    //    cmdVisualiser.Visible = False
    //    cmdFichePerso.Visible = False
    //  End If

    //Exit Sub
    //Resume
    //handler:
    //  ShowError "OuvertureEnModification dans " & Me.Name
    //End Sub

    private void Enregistrer()
    {
      try
      {
        string permissions = "";

        //   Création ou la modification, c'est la proc stock qui gère
        //   création d'une commande
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationRecru2", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          //  ' liste des paramètres
          SqlCommandBuilder.DeriveParameters(cmd);
          // liste des paramètres
          cmd.Parameters["@iNum"].Value = miNumPer;   // 0 si création
          cmd.Parameters["@vNom"].Value = txtNom.Text;
          cmd.Parameters["@vPrenom"].Value = txtprenom.Text;
          cmd.Parameters["@vCiv"].Value = cboCiv.Text;

          cmd.Parameters["@vAd1"].Value = txtAD1.Text;
          cmd.Parameters["@vAd2"].Value = txtAD2.Text;
          cmd.Parameters["@vCp"].Value = txtCP.Text;
          cmd.Parameters["@vVille"].Value = (cboPays.Text == "FRANCE" ? cboVille.Text : txtVille.Text);
          cmd.Parameters["@vPays"].Value = cboPays.Text;

          cmd.Parameters["@vTel"].Value = txtTel.Text;
          if (txtNumStd.Text != "") cmd.Parameters["@nTelStd"].Value = txtNumStd.Text;
          cmd.Parameters["@vFax"].Value = txtFax.Text;
          cmd.Parameters["@vPort"].Value = txtPort.Text;
          cmd.Parameters["@vMail"].Value = txtMail.Text;

          //  NL le 04/10/2016
          string cboTypeText2 = Strings.Left(cboType.Text, 2);
          switch (cboTypeText2)
          {
            case "OU":
            case "CE":
            case "CM":
              cmd.Parameters["@vType"].Value = "TE";
              break;
            case "CG":
              cmd.Parameters["@vType"].Value = "CA";
              break;
            default:
              cmd.Parameters["@vType"].Value = cboTypeText2;
              break;
          }
          cmd.Parameters["@vTypeDetail"].Value = cboTypeText2;

          cmd.Parameters["@nService"].Value = cboService.SelectedValue;   // Code service
          cmd.Parameters["@nRegion"].Value = cboRegion.SelectedValue;     // Code région
          cmd.Parameters["@nContrat"].Value = cboContrat.GetItemData();
          cmd.Parameters["@vCollege"].Value = cboCollege.Text;
          cmd.Parameters["@vNiveau"].Value = txtNiveau.Text;
          cmd.Parameters["@vEchelon"].Value = txtEchelon.Text;
          cmd.Parameters["@vCategorie"].Value = txtCategorie.Text;
          cmd.Parameters["@vCoef"].Value = txtCoef.Text;
          cmd.Parameters["@vsociete"].Value = msLibNomSoc;

          cmd.Parameters["@dEntree"].Value = txtDateEntree.Text;  // Champ obligatoire
          if (txtDateEntreeInt.Text != "") cmd.Parameters["@dEntreeInt"].Value = txtDateEntreeInt.Text;

          //Champs numériques
          if (txtNbHeures.Text != "") cmd.Parameters["@nHeures"].Value = txtNbHeures.Text;
          if (txtSalaire.Text != "") cmd.Parameters["@fSalaire"].Value = Strings.Replace(txtSalaire.Text, ".", ",");
          if (txtAvance.Text != "") cmd.Parameters["@fAvance"].Value = Strings.Replace(txtAvance.Text, ".", ",");

          //Champs dates
          if (txtDateNaissance.Text != "") cmd.Parameters["@dNaissance"].Value = txtDateNaissance.Text;
          if (txtDateSortie.Text != "") cmd.Parameters["@dSortie"].Value = txtDateSortie.Text;
          if (txtDateVisite.Text != "") cmd.Parameters["@dVisiteMed"].Value = txtDateVisite.Text;
          if (txtDateAvance.Text != "") cmd.Parameters["@dAvance"].Value = txtDateAvance.Text;
          if (txtDateHabilitation.Text != "") cmd.Parameters["@dHabilitation"].Value = txtDateHabilitation.Text;

          if (cboSituation.Text != "") cmd.Parameters["@vSitFam"].Value = cboSituation.Text;
          if (cboSituation.Text != "") cmd.Parameters["@nSituFam"].Value = cboSituation.SelectedValue;
          //gestion des permissions
          permissions = "";
          if (chkB.Checked) permissions = "B,";
          if (chkC.Checked) permissions = permissions + "C,";
          if (chkE.Checked) permissions = permissions + "E";
          if (Strings.Right(permissions, 1) == ",") permissions = Strings.Left(permissions, permissions.Length - 1);  // afin d'enlever le dernier ,
          cmd.Parameters["@vPermi"].Value = permissions;
          cmd.Parameters["@vGroupe"].Value = chkGrp.Checked ? 1 : 0;

          if (strImage != strRepImage + txtImgFichier.Text)
            EnregistrerImage();
          cmd.Parameters["@vimage"].Value = txtImgFichier.Text;

          cmd.ExecuteNonQuery();

          miNumPer = Convert.ToInt32(cmd.Parameters[0].Value);    // récupération du numéro crée
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Public Sub Enregistrer()

    //Dim cmd As New ADODB.Command
    //Dim ado_rs As New ADODB.Recordset
    //Dim permi As String

    //On Error GoTo handler

    //  ' Création ou la modification, c'est la proc stock qui gère
    //  ' création d'une commande
    //  Set cmd.ActiveConnection = cnx

    //  ' passage du nom de la procédure stockée
    //  cmd.CommandText = "api_sp_CreationRecru"
    //  cmd.CommandType = adCmdStoredProc
    //  'cmd.Parameters.Refresh

    //   ' liste des paramètres
    //  cmd.Parameters("@iNum").value = miNumPer   ' 0 si création
    //  cmd.Parameters("@vNom").value = txtNom
    //  cmd.Parameters("@vPrenom").value = txtprenom
    //  cmd.Parameters("@vCiv").value = cboCiv.Text

    //  cmd.Parameters("@vAd1").value = txtAD1
    //  cmd.Parameters("@vAd2").value = txtAD2
    //  cmd.Parameters("@vCp").value = txtCP
    //  cmd.Parameters("@vVille").value = IIf(cboPays.Text = "FRANCE", cboVille.Text, txtVille.Text)
    //  cmd.Parameters("@vPays").value = Me.cboPays.Text

    //  cmd.Parameters("@vTel").value = txtTel
    //  If txtNumStd <> "" Then cmd.Parameters("@nTelStd").value = txtNumStd
    //  cmd.Parameters("@vFax").value = txtFax
    //  cmd.Parameters("@vPort").value = txtPort
    //  cmd.Parameters("@vMail").value = txtMail

    //  ' NL le 04/10/2016
    //  If Left(cboType.Text, 2) = "OU" Or Left(cboType.Text, 2) = "CE" Or Left(cboType.Text, 2) = "CM" Then
    //    cmd.Parameters("@vType").value = "TE"
    //  ElseIf Left(cboType.Text, 2) = "CG" Then
    //    cmd.Parameters("@vType").value = "CA"
    //  Else
    //    cmd.Parameters("@vType").value = Left(cboType.Text, 2)
    //  End If
    //  cmd.Parameters("@vTypeDetail").value = Left(cboType.Text, 2)

    //  cmd.Parameters("@nService").value = cboService.ItemData(cboService.ListIndex)   'Code service
    //  cmd.Parameters("@nRegion").value = cboRegion.ItemData(cboRegion.ListIndex)     ' Code région
    //  cmd.Parameters("@vContrat").value = txtContrat
    //  cmd.Parameters("@vCollege").value = cboCollege
    //  cmd.Parameters("@vNiveau").value = txtNiveau
    //  cmd.Parameters("@vEchelon").value = txtEchelon
    //  cmd.Parameters("@vCategorie").value = txtCategorie
    //  cmd.Parameters("@vCoef").value = txtCoef
    //  cmd.Parameters("@vsociete").value = IIf(gstrNomSocieteTemp = "GROUPE", sLibNomSoc, gstrNomSocieteTemp)

    //  cmd.Parameters("@dEntree").value = txtDateEntree  ' Champ obligatoire
    //  If txtDateEntreeInt <> "" Then cmd.Parameters("@dEntreeInt").value = txtDateEntreeInt

    //  ' Champs numériques
    //  If txtNbHeures <> "" Then cmd.Parameters("@nHeures").value = txtNbHeures
    //  If txtSalaire <> "" Then cmd.Parameters("@fSalaire").value = Replace(txtSalaire, ".", ",")
    //  If txtAvance <> "" Then cmd.Parameters("@fAvance").value = Replace(txtAvance, ".", ",")

    //  ' Champs dates
    //  If txtDateNaissance <> "" Then cmd.Parameters("@dNaissance").value = txtDateNaissance
    //  If txtDateSortie <> "" Then cmd.Parameters("@dSortie").value = txtDateSortie
    //  If txtDateVisite <> "" Then cmd.Parameters("@dVisiteMed").value = txtDateVisite
    //  If txtDateAvance <> "" Then cmd.Parameters("@dAvance").value = txtDateAvance
    //  If txtDateHabilitation <> "" Then cmd.Parameters("@dHabilitation").value = txtDateHabilitation

    //  If cboSituation.Text <> "" Then cmd.Parameters("@vSitFam").value = cboSituation.Text
    //  If cboSituation.Text <> "" Then cmd.Parameters("@nSituFam").value = cboSituation.ItemData(cboSituation.ListIndex)
    //  ' gestion des permi
    //  permi = ""
    //  If chkB Then permi = "B,"
    //  If chkC Then permi = permi + "C,"
    //  If chkE Then permi = permi + "E"
    //  If Right(permi, 1) = "," Then permi = Left(permi, Len(permi) - 1)  ' afin d'enlever le dernier ,
    //  cmd.Parameters("@vPermi").value = permi
    //  cmd.Parameters("@vGroupe").value = IIf(chkGrp = 1, 1, 0)


    //  If strImage <> mRepertoireDoc & txtImgFichier Then EnregistrerImage
    //  cmd.Parameters("@vimage").value = txtImgFichier

    //  Set ado_rs = cmd.Execute()

    //  miNumPer = cmd.Parameters(0).value    ' récupération du numéro crée

    //  Set cmd = Nothing
    //  Exit Sub
    //  Resume

    //handler:
    //  ShowError "EnregistrerAction dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void txtCP_TextChanged(object sender, EventArgs e)
    {
      string sDep = "";

      if (txtCP.Text.Length == 5 && cboPays.Text == "FRANCE")
      {
        ModuleMain.RechercheCommune(txtCP.Text, cboVille);

        sDep = txtCP.Text.Substring(0, 2);
        cboRegion.SelectedValue = Convert.ToInt32(sDep);
      }
    }
    //Private Sub txtCP_Change()
    //Dim sDep As String

    //    If Len(txtCP) = 5 And cboPays = "FRANCE" Then
    //        RechercheCommune txtCP.Text, cboVille

    //        sDep = Left(txtCP, 2)
    //        SelectLB cboRegion, val(sDep)
    //    End If
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    // Prendre ModuleMain.RechercheCommune()
    //private void RechercheCommune(string strCp, ComboBox cbo)
    //{
    //}
    //Private Sub RechercheCommune(strCp As String, cbo As ComboBox)
    //  Static rs As New ADODB.Recordset
    //  cbo.Clear
    //  rs.Open "select Ville from TCOMMUNE WHERE CodePostal like '" & strCp & "%'", cnx
    //  ' dans le cas d'un cedex avec code postal spécial, on recherche les communes du département
    //  If rs.EOF Then
    //    rs.Close
    //    rs.Open "select Ville from TCOMMUNE WHERE CodePostal like '" & Left(strCp, 2) & "%'", cnx
    //  End If
    //  While Not rs.EOF
    //    cbo.AddItem rs!ville
    //    rs.MoveNext
    //  Wend
    //  If rs.RecordCount > 0 Then cbo.ListIndex = 0
    //  rs.Close
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cboPays_SelectedIndexChanged(object sender, EventArgs e)
    {
      cboVille.Visible = cmdRecherche.Visible = cboPays.Text == "FRANCE";
      txtVille.Visible = cboPays.Text != "FRANCE";

      if (!bPrem)
        ModuleData.RemplirCombo(cboRegion, "select NREGCOD, VDEPLIB from TREF_REG where npaysnum = " + cboPays.GetItemData() + " order by VDEPLIB");
    }
    //Private Sub cboPays_Click()
    //  If cboPays.Text <> "FRANCE" Then
    //    cboVille.Visible = False
    //    txtVille.Visible = True
    //    cmdRecherche.Visible = False
    //  Else
    //    cboVille.Visible = True
    //    txtVille.Visible = False
    //    cmdRecherche.Visible = True
    //  End If
    //  If Not bPrem Then RemplirCombo cboRegion, "select NREGCOD, VDEPLIB from TREF_REG where npaysnum = " & cboPays.ItemData(cboPays.ListIndex) & " order by VDEPLIB", , True
    //End Sub

    /* OK ----------pour Tel + Fax + Port ------------------------------------------------------- */
    private void txtTelFaxPort_Leave(object sender, EventArgs e)
    {
      TextBox tb = sender as TextBox;
      tb.Text = ModuleMain.FormatTel(tb.Text);
    }
    //Private Sub txtTel_LostFocus()
    //  txtTel = FormatTel(txtTel)
    //End Sub
    //Private Sub txtFax_LostFocus()
    //  txtFax = FormatTel(txtFax)
    //End Sub
    //Private Sub txtPort_LostFocus()
    //  txtPort = FormatTel(txtPort)
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void txtMail_Leave(object sender, EventArgs e)
    {
      TextBox tb = sender as TextBox;
      ModuleMain.FormatMail(sender as TextBox);
    }
    //Private Sub txtMail_LostFocus()
    //  txtMail = FormatMail(txtMail)
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void txtNomVille_Leave(object sender, EventArgs e)
    {
      (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
    }
    //Private Sub txtNom_LostFocus()
    //  txtNom = Majuscule(txtNom)
    //End Sub
    //Private Sub txtVille_lostfocus()
    //  txtVille = Majuscule(txtVille)
    //End Sub

    /* OK ----------Proc valable pour tous les boutons de type cmdDateSet ----------------------- */
    DateTime _curDate = DateTime.MinValue;
    private void cmdDatesAll_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Calendar1.Tag = btn.Tag;

      TextBox txt = (TextBox)this.Controls.Find(Calendar1.Tag as string, true)[0];
      DateTime d;
      if (DateTime.TryParse(txt.Text, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }

      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    //Private Sub cmdDate2_Click(Index As Integer)

    //  Select Case Index
    //    Case 0:    Set mstrCurDateCtrl = txtDateEntree
    //    Case 1:    Set mstrCurDateCtrl = txtDateSortie
    //    Case 2:    Set mstrCurDateCtrl = txtDateNaissance
    //    Case 3:    Set mstrCurDateCtrl = txtDateHabilitation
    //    Case 4:    Set mstrCurDateCtrl = txtDateAvance
    //    Case 5:    Set mstrCurDateCtrl = txtDateVisite
    //    Case 6:    Set mstrCurDateCtrl = txtDateEntreeInt
    //  End Select

    //  If Calendar1.Visible Then
    //    Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    Calendar1.value = mstrCurDateCtrl
    //  End If
    //End Sub

    /* OK ---------- Proc valable pour tous les boutons de type cmdDateSupp --------------------- */
    private void cmdDateSuppAll_Click(object sender, EventArgs e)
    {
      (Controls.Find((sender as Button).Tag as string, true)[0] as TextBox).Text = "";
    }
    //Private Sub cmdSupp2_Click(Index As Integer)
    //  Select Case Index
    //    Case 0:      txtDateEntree = ""
    //    Case 1:      txtDateSortie = ""
    //    Case 2:      txtDateNaissance = ""
    //    Case 3:      txtDateHabilitation = ""
    //    Case 4:      txtDateAvance = ""
    //    Case 5:      txtDateVisite = ""
    //    Case 6:      txtDateEntreeInt = ""
    //  End Select
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      TextBox txt = (TextBox)this.Controls.Find(Calendar1.Tag as string, true)[0];
      txt.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }
    //Private Sub Calendar1_Click()
    //  On Error GoTo handler
    //  mstrCurDateCtrl.Text = Calendar1.value

    //  ' si on saisie la date d'entree interim et que la date d'entree est vide
    //  ' alors on met la même valeur dans la date d'entrée interim
    //  If mstrCurDateCtrl.Name = "txtDateEntreeInt" And txtDateEntree = "" Then
    //    txtDateEntree.Text = Calendar1.value
    //  End If

    //  Calendar1.Visible = False
    //  Exit Sub

    //handler:
    //  ShowError "Calendar1_Click dans " & Me.Name
    //End Sub

    /* OK ------------------------------------------------------------------------------------- */
    private void EnregistrerImage()
    {
      if (openFileDialog1.FileName == "")
        return;

      long lcount = (long)ModuleData.ExecuteScalarInt("Exec api_sp_GetCpt2 'IMGPER'");

      string[] ts = txtImgFichier.Text.Split('.');
      txtImgFichier.Text = "PER_" + miNumPer + "_" + ts[0].Replace(" ", "_") + "_" + lcount + "." + ts[1];

      //  ' Recopier le fichier sélectionné sur le serveur
      File.Copy(openFileDialog1.FileName, strRepImage + txtImgFichier.Text);

      //  ' suppression de l'ancienne image si elle existe !  VL 11/06/04)
      if (strImage != "")
        File.Delete(strImage);

      strImage = strRepImage + txtImgFichier.Text;
    }
    //Private Sub EnregistrerImage()

    //Dim ado_cmd As New ADODB.Command
    //Dim lcount As Long
    //Dim fs As New Scripting.FileSystemObject
    //Dim ts

    //  On Error GoTo handler
    //  If CommonDialog1.FileName = "" Then Exit Sub

    //' Récupération compteur et mise à jour dans la table
    //  Set ado_cmd.ActiveConnection = cnx
    //  ado_cmd.CommandText = "api_sp_GetCpt"
    //  ado_cmd.CommandType = adCmdStoredProc
    //  ado_cmd.Parameters.Refresh
    //  ado_cmd.Parameters("@cElt").value = "IMGPER"
    //  ado_cmd.Execute
    //  lcount = ado_cmd.Parameters("@iCpt").value
    //  Set ado_cmd = Nothing

    //  ts = Split(txtImgFichier, ".")
    //  txtImgFichier = "PER_" & miNumPer & "_" & Replace(ts(0), " ", "_") & "_" & lcount & "." & ts(1)

    //  ' Recopier le fichier sélectionné sur le serveur
    //  fs.CopyFile CommonDialog1.FileName, mRepertoireDoc & txtImgFichier

    //  ' suppression de l'ancienne image si elle existe !  VL 11/06/04)
    //  If strImage <> "" Then fs.DeleteFile strImage

    //  strImage = mRepertoireDoc & txtImgFichier
    //  Exit Sub
    //  Resume

    //handler:
    //  ShowError "FormatGrid dans " & Me.Name
    //End Sub

    /* OK ------------------------------------------------------------------------------------- */
    private void Image1_DoubleClick(object sender, EventArgs e)
    {
      //if (Image1.Tag.ToString() == "OK")
      if (strImage != "")
      {
        frmxVisuImg f = new frmxVisuImg();
        f.msImage = strImage;
        f.ShowDialog();
      }
    }
    //Private Sub Image1_DblClick()
    //  If Image1.Tag = "OK" Then
    //    frmxVisuImg.mstrImage = strImage
    //    frmxVisuImg.Show vbModal
    //  End If
    //End Sub

    /* OK ------------------------------------------------------------------------------------- */
    private void cmdImgOpen_Click(object sender, EventArgs e)
    {
      try
      {
        //openFileDialog1.CancelError = true;
        //  ' Définit la propriété Flags
        openFileDialog1.ReadOnlyChecked = true;
        //  ' titre de la boite
        openFileDialog1.Title = Resources.msg_select_image_file;

        //  ' Affiche la boîte de dialogue Ouverture
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
          if (openFileDialog1.FileName.Contains("'"))
          {
            MessageBox.Show(Resources.msg_filename_incorrect, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
          }
          else
          {
            //  Afficher l'image resizée
            Image1.Load(openFileDialog1.FileName);
            //  Affiche le nom du fichier sélectionné
            txtImgFichier.Text = Path.GetFileName(openFileDialog1.FileName);
            Image resized = ModuleMain.ScaleImage(Image1.Image, new Size(Image1.Width, Image1.Height));
            Image1.Image = resized;
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdImgOpen_Click()
    //Dim ts

    //  On Error GoTo errHandler

    //  ' Attribue à CancelError la valeur True
    //  CommonDialog1.CancelError = True
    //  ' Définit la propriété Flags
    //  CommonDialog1.flags = cdlOFNHideReadOnly
    //  ' titre de la aboite
    //  CommonDialog1.DialogTitle = "§Choix d'un fichier image§"

    //  ' Affiche la boîte de dialogue Ouverture
    //  On Error GoTo ExitHandler
    //  CommonDialog1.ShowOpen
    //  On Error GoTo errHandler

    //  If InStr(1, CommonDialog1.FileName, "'") > 0 Then
    //    MsgBox "Le nom du fichier n'est pas conforme. Les simples côtes sont interdites.", vbCritical + vbOKOnly
    //    Exit Sub
    //  End If

    //  ' Afficher l'image
    //  'AfficheImg2 Me, Image1, CommonDialog1.FileName, imgX, ImgY, ImgW, ImgH
    //  Image1.Picture = LoadPicture(CommonDialog1.FileName)

    //  ' Affiche le nom du fichier sélectionné
    //  ts = Split(CommonDialog1.FileName, "\")
    //  txtImgFichier = ts(UBound(ts))

    //  Set Image1.Picture = ScaleBitmapPic(Image1.Picture, Image1.ScaleWidth, Image1.ScaleHeight)
    //  SavePicture Image1.Picture, "c:\temp\" & txtImgFichier
    //  Image1.Picture = LoadPicture("c:\temp\" & txtImgFichier)

    //ExitHandler:
    //  Exit Sub
    //  Resume

    //errHandler:
    //  'L'utilisateur a cliqué sur Annuler
    //  ShowError "CmdImgOpen_Click dans " & Me.Name
    //End Sub

    /* OK ------------------------------------------------------------------------------------- */
    private void ImageEnModification(string sFichier)
    {
      try
      {
        for (int i = 0; i < tFormats.Length; i++)
        {
          if (tFormats[i] == Strings.Right(sFichier, 3))
          {
            cboImgFormat.SelectedIndex = i;
            break;
          }
        }
        txtImgFichier.Text = sFichier;
        Image1.Load(strImage);
        Image resized = ModuleMain.ScaleImage(Image1.Image, new Size(Image1.Width, Image1.Height));
        //MemoryStream memStream = new MemoryStream();
        //resized.Save(memStream, ImageFormat.Jpeg);
        Image1.Image = resized;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void RenameFichPersoForTransfert(long OldIdPerso, long NewIdPerso)
    {
      string newFileName = "";
      //string repFileRH = ModuleData.RechercheParam("REP_FILE_RH", msLibNomSoc);
      string repFileRH = ModuleData.RechercheParam("REP_DOC_PERSONNEL", msLibNomSoc);


      using (SqlDataReader dr = ModuleData.ExecuteReader("SELECT VFICHIER, NIDFICPERSO FROM TFICPERSO WHERE VTYPE = 'RECRU' AND NIDPERSO = " + OldIdPerso.ToString()))
      {
        while (dr.Read())
        {
          newFileName = dr["VFICHIER"].ToString().Replace("'", "");
          newFileName = newFileName.Replace(OldIdPerso.ToString() + "_", NewIdPerso.ToString() + "_");
          // on retire le mot recru et on laisse le npernum
          newFileName = newFileName.Replace("_RECRU_", "_");

          try
          {
            CImpersonation.MoveFileImpersonated(repFileRH + dr["VFICHIER"], repFileRH + newFileName);

            ModuleData.ExecuteNonQuery($"UPDATE TFICPERSO SET VFICHIER = '{newFileName}' WHERE VTYPE = 'RECRU' AND NIDPERSO = {OldIdPerso} AND NIDFICPERSO={dr["NIDFICPERSO"]}");
          }
          catch {  /* on passe au doc suivant si erreur  */ }
        }
      }
    }


    /* OK ------------------------------------------------------------------------------------- */
    private void cmdImgDel_Click(object sender, EventArgs e)
    {
      if (strImage == "")
        return;
      if (MessageBox.Show(Resources.msg_confirm_image_deletion, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        // suppression en base
        ModuleData.CnxExecute("UPDATE TRECRU SET VPERIMAGE = '' WHERE NPERNUM=" + miNumPer);
        // suppression physique du fichier
        if (strImage != "")
          File.Delete(strImage);

        strImage = "";
        txtImgFichier.Text = "";

        Image1.Load(strImage);
      }
    }


  }
}

