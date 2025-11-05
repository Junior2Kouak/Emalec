using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDetailsSiteSTF : Form
  {
    public string mstrStatut;
    public string msCSTFTYP;
    public long miNumSTFGRP;
    public long miNumSTF;

        private bool bIsLoading;

    DataTable dtHisto = new DataTable();
    DataTable dtSec = new DataTable();
    private string strStatut;

    private DateTime? mDateValiditeContratCadre = null;

    public frmDetailsSiteSTF() { InitializeComponent(); }

    private void frmDetailsSiteSTF_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

                bIsLoading = true;

        //chargement de toutes les combos
        ModuleData.RemplirCombo(cboPays, $"select NPAYSNUM, VPAYSNOM from TPAYS where VPAYSNOM <> 'BELGIË' and VPAYSNOM <> 'SWITZERLAND' and VPAYSNOM <> 'SVIZZERA' order by VPAYSNOM");
        cboPays.ValueMember = "NPAYSNUM";
        cboPays.DisplayMember = "VPAYSNOM";

        RemplirComboLangues();

        ModuleData.RemplirCombo(CboINT_TSTTECH, $"SELECT NINTNUM, ISNULL(VINTNOM, '') + ' ' + ISNULL(VINTPRE, '') AS VINTNOM FROM TINT WITH (NOLOCK) WHERE TINT.CINTACTIF = 'O' AND TINT.NSTFNUM = {miNumSTF} ORDER BY TINT.VINTNOM, TINT.VINTPRE");
        CboINT_TSTTECH.ValueMember = "NINTNUM";
        CboINT_TSTTECH.DisplayMember = "VINTNOM";

        if (msCSTFTYP == "FO")
          cmdGestVillesCibles.Visible = cmdFormulaire.Visible = cmdRecupTout.Visible = cmdPrestations.Visible = false;
        else
        {
          // Test de valeur:
          // Si date d'intégration du formulaire renseignée, on désactive le bouton permettant de le faire (le 21/04/2017)
          using (SqlDataReader dr = ModuleData.ExecuteReader($"select DSTFINTEGRFORMULAIRE from TSTF Where NstfNum = {miNumSTF}"))
          {
            if (dr.Read())
            {
              if (Utils.DateBlankIfNull(dr["DSTFINTEGRFORMULAIRE"]) != "")
              {
                cmdRecupTout.Enabled = false;
                lblDtIntegrFormulaire.Text += " " + ((DateTime)dr["DSTFINTEGRFORMULAIRE"]).ToString("dd/MM/yyyy");
                lblDtIntegrFormulaire.Visible = true;
              }
            }
          }
        }
        //traitement du cas de modification ou de création
        if (mstrStatut == "C")
        {
          OuvertureEnCreation();

          updateFormContratCadre();
        }
        else
        {
          OuvertureEnModification();

          updateFormContratCadre();

          FormatGridHisto();
          InitApigrid();
          apiTGrid1_SelectionChanged(null, null);
          cboPays_SelectionChangeCommitted(null, null);
        }
        chkPrev_Click(null, null);

                bIsLoading = false;

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtNom.Text == "")      // test du nom
        {
          MessageBox.Show(Resources.msg_Saisir_nom_site);
          txtNom.Focus();
          return;
        }

        // 14/12/2016, NL suite demande de Jean :
        // ' " - _ . sont interdits et le nom ne peut commence par un espace
        if (txtNom.Text.IndexOfAny(new char[] { '\'', '\"', '-', '_', '.' }) != -1)
        {
          MessageBox.Show("Le nom de site contient un ou des caractères interdits");
          return;
        }

        if (cboPays.Text == "")     // test de la sélection d'un pays
        {
          MessageBox.Show(Resources.msg_must_select_pays);
          return;
        }

        if (cboLangue.Text == "")     // langue liée au pays 04/04/2016
        {
          MessageBox.Show(Resources.msg_must_select_langue);
          return;
        }

        if (cboPays.Text == "FRANCE")   // test de la sélection d'une ville
        {
          if (cboVille.Text == "")
          {
            MessageBox.Show(Resources.msg_must_select_ville);
            return;
          }
        }
        else
        {
          if (txtVille.Text == "")
          {
            MessageBox.Show(Resources.msg_must_select_ville);
            return;
          }
        }

        if (txtSiret.Text == "" && cboPays.Text == "FRANCE")
        {
          MessageBox.Show("Il faut saisir le numéro SIRET du sous-traitant (14 chiffres).");
          return;
        }

        if (txtSiret.Text.Length != 14 && cboPays.Text == "FRANCE")
        {
          MessageBox.Show("Le numéro SIRET doit comporter exactement 14 chiffres");
          return;
        }

        Enregistrer();

        mstrStatut = "M";
        OuvertureEnModification();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdContST_Click(object sender, EventArgs e)
    {
      new frmSaisieContratST { mlNumSTF = miNumSTF }.ShowDialog();
    }

    private void CmdCarteSiteSTF_Click(object sender, EventArgs e)
    {
      if (miNumSTF == 0) return;

      new frmBrowser
      {
        msStartingAddress = $"https://maps.emalec.com/SiteFournisseur.asp?base=MULTI&NOM={txtNom.Text}&NUM={miNumSTF}&APP={MozartParams.NomSociete}"
      }.ShowDialog();
    }

    private void cmdGestVillesCibles_Click(object sender, EventArgs e)
    {
      new frmGestionVillesCibles(miNumSTF).ShowDialog();
    }

    private void cmdFormulaire_Click(object sender, EventArgs e)
    {
      try
      {
        string res = ModuleData.ExecuteScalarString($"select SSTFNUMCODE from TREF_STT Where NstfNum = {miNumSTF}");
        if (res == "")
        {
          MessageBox.Show("Pas de formulaire disponible pour ce sous-traitant...");
          return;
        }
        new frmBrowser
        {
          msStartingAddress = $"https://stt.emalec.com/formulaire.aspx?LANGUE=FR&NSTFNUM={res}&NINTNUM={CboINT_TSTTECH.GetItemData()}"
        }.ShowDialog();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdRecupTout_Click(object sender, EventArgs e)
    {
      RecupVilles();
      RecupPrestations();
    }

    private void cmdPrestations_Click(object sender, EventArgs e)
    {
      new frmGestionPrestations(miNumSTF).ShowDialog();
    }

    private void cmdRecherche_Click(object sender, EventArgs e)
    {
      new frmRechCodePostal { ControlCible1 = txtCP, ControlCible2 = cboVille }.ShowDialog();
    }

    private void CmdInitMatSTF_Click(object sender, EventArgs e)
    {
      if (miNumSTF == 0) return;

      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      try
      {
        if (MessageBox.Show("L'accès tablette de cet intervenant est déjà configuré sur une tablette." + "\r\n" +
                            "Voulez-vous autoriser la configuration de cet accès sur une autre tablette ?", "CONFIRMATION",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
          return;
        ModuleData.ExecuteNonQuery($"UPDATE TSTTECH SET VSTTECHADDRMAC = NULL WHERE NSTTNUM = {row["NSTTNUM"]}");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      try
      {
        if (miNumSTF == 0) return;
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (row == null) return;

        try { ModuleData.ExecuteNonQuery($"DELETE FROM TSTTECH WHERE NSTTNUM = {row["NSTTNUM"]}"); }
        catch (Exception) { MessageBox.Show(Resources.msg_ImpFaireModifEnrgExistant); }

        apiTGrid1.Requery(dtSec, MozartDatabase.cnxMozart);

        //Lier le datagrid avec le recordset secondaire
        loadApiTGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdNew_Click(object sender, EventArgs e)
    {
      if (miNumSTF == 0)
      {
        MessageBox.Show(Resources.msg_Save_sous_traitant_avant_saisir_tech, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      strStatut = "C";
      txtNoms.Text = txtPrenom.Text = txtPort.Text = txtMail.Text = "";
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      string sSQL = "";
      try
      {
        if (miNumSTF == 0)
        {
          MessageBox.Show(Resources.msg_Saisir_nom_tech, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        // on teste si ce contact a déjà été affecté
        // Règle N° 1 : un contact = un seul accès web
        if (Convert.ToInt32(CboINT_TSTTECH.GetItemData()) > 0)
        {
          if ((int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TSTTECH WITH (NOLOCK) WHERE NINTNUM = {CboINT_TSTTECH.GetItemData()}") > 1)
          {
            MessageBox.Show("Le contact est déjà affecté à un accès web. 1 seul contact par accès web.");
            return;
          }
        }

        //Creation
        if (strStatut == "C")
        {
          sSQL = $"Insert into TSTTECH (NSTFNUM, VSTTNOM, VSTTPRENOM, VSTTPORT, VSTTMAIL, NSTFGRPNUM, NINTNUM) " +
                 $"Values ({miNumSTF} , '{txtNoms.Text.Replace("'", "''")}' , '{txtPrenom.Text.Replace("'", "''")}','{txtPort.Text.Replace("'", "''")}', " +
                 $"'{txtMail.Text}', {miNumSTFGRP}, {CboINT_TSTTECH.GetItemData()})";
          try
          {
            ModuleData.ExecuteNonQuery(sSQL);
          }
          catch (Exception)
          {
            MessageBox.Show(Resources.msg_ImpFaireModifEnrgExistant);
          }
        }
        else // en  modification
        {
          sSQL = $"UPDATE TSTTECH set VSTTNOM = '{txtNoms.Text.Replace("'", "''")}',  VSTTPRENOM = '{txtPrenom.Text.Replace("'", "''")}', " +
                 $"VSTTPORT = '{txtPort.Text.Replace("'", "''")}',  VSTTMAIL = '{txtMail.Text}',  NINTNUM = {CboINT_TSTTECH.GetItemData()} " +
                 $"WHERE NSTTNUM = {currentRow["NSTTNUM"]}";
          try { ModuleData.ExecuteNonQuery(sSQL); }
          catch (Exception) { MessageBox.Show(Resources.msg_ImpFaireModifEnrgExistant); }
        }

        apiTGrid1.Requery(dtSec, MozartDatabase.cnxMozart);
        cmdEnregistrer_Click(null, null);
        // Lier le datagrid avec le recordset secondaire
        loadApiTGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdAccesWeb_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null)
        return;

      new frmGestWebPer
      {
        miNumPersonne = (int)currentRow["NSTTNUM"],
        msTypePer = "S"
      }.ShowDialog();
    }

    private async void ApiTelAuto1_Click(object sender, EventArgs e)
    {
      //ApiTelAuto1.TelDial(txtTel.Text);
            if (txtTel.Text != "") 
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtTel.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    private void cboLangue_Leave(object sender, EventArgs e)
    {
      cboLangueAbrev.SelectedIndex = cboLangue.SelectedIndex;
    }

    private void RemplirComboLangues()
    {
      try
      {
        using (SqlDataReader dr = ModuleData.ExecuteReader("SELECT DISTINCT VLANGUEDEFAUT, VLANGUEABR FROM TPAYS ORDER BY VLANGUEDEFAUT"))
        {
          while (dr.Read())
          {
            cboLangue.Items.Add(dr["VLANGUEDEFAUT"].ToString());
            cboLangueAbrev.Items.Add(dr["VLANGUEABR"].ToString());
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void RecupPrestations()
    {
      // Récupérer les données renseignée en web et les intégrer au sous-traitant, dans Mozart
      try
      {
        //Recherche des informations du formulaire
        string sListeActivites = ModuleData.ExecuteScalarString($"select VListeActivites from TREF_STT Where NstfNum = {miNumSTF}");
        {
          if (sListeActivites == "")
          {
            MessageBox.Show("Pas de formulaire disponible pour ce sous-traitant...");
            return;
          }
        }
        string[] competences = sListeActivites.Split(';'); //competences contient la liste des activités au format "1_Inst" où 1 représente l'id et Inst la prestation détaillée

        string sListeActivitesRecherche = "";
        for (int i = 0; i < competences.Length - 1; i++)
        {
          string lReq = $"select VCategorie, VActivite from TACTIVITES Where id = " + Strings.Left(competences[i], competences[i].IndexOf("_"));
          using (SqlDataReader dr = ModuleData.ExecuteReader(lReq))
          {
            while (dr.Read())
            {
              if (sListeActivitesRecherche.IndexOf(dr["VCategorie"].ToString()) == -1)
                sListeActivitesRecherche += dr["VCategorie"] + ";";

              if (sListeActivitesRecherche.IndexOf(dr["VActivite"].ToString()) == -1)
                sListeActivitesRecherche += dr["VActivite"] + ";";
            }
          }
        }
        //Recherche des informations du sous - traitant
        string res = ModuleData.ExecuteScalarString($"select VListeActivites from TSTF Where NstfNum = {miNumSTF}");
        string sListeActivitesActuelle = Utils.BlankIfNull(res);

        bool bUpdate = true;

        if (sListeActivitesActuelle != "")
        {
          bUpdate = (MessageBox.Show("Etes-vous sûr(e) de vouloir récupérer les données du formulaire WEB et écraser les activités déjà existantes pour ce sous-traitant ?",
                              "CONFIRMATION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        }

        if (bUpdate)
        {
          // Mise à jour de TSTF
          sListeActivitesRecherche = sListeActivitesRecherche.Replace("'", "''");
          string sSql = $"UPDATE TSTF set VListeActivites = '{sListeActivites}', VListeActivitesRecherche = '{sListeActivitesRecherche}' WHERE NSTFNUM = {miNumSTF}";
          ModuleData.ExecuteNonQuery(sSql);

          // Tout s'est bien passé, mise à jour de la date d'intégration, à condition qu'on ait intégré villes + prestations :
          ModuleData.ExecuteNonQuery($"UPDATE TSTF set DSTFINTEGRFORMULAIRE = GetDate() WHERE NSTFNUM = {miNumSTF}");
          MessageBox.Show("Fin de traitement", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void RecupVilles()
    {
      // Récupérer les données renseignées en web et les intégrer au sous-traitant, dans Mozart
      try
      {
        string sListeVilles = "";
        // Recherche des informations du formulaire
        using (SqlDataReader dr = ModuleData.ExecuteReader($"select VListeVilles from Tref_STt Where NstfNum = {miNumSTF}"))
        {
          if (dr.Read())
            sListeVilles = dr["VListeVilles"].ToString();
          else
          {
            MessageBox.Show("Pas de formulaire disponible pour ce sous-traitant...");
            return;
          }
        }

        string[] villes = sListeVilles.Split(';');  // villes contient la liste des ids de villes cibles

        string sListeVillesRecherche = "";
        foreach (string item in villes)
        {
          if (item != "")
          {
            string sVille = ModuleData.ExecuteScalarString($"select VILLE from TVILLES Where id = {item}");
            if (sListeVillesRecherche.IndexOf(sVille) == -1)
              sListeVillesRecherche += sVille + ";";
          }
        }

        // Recherche des informations du sous-traitant
        string res = ModuleData.ExecuteScalarString($"select VListeVilles from TSTF Where NstfNum = {miNumSTF}");

        string sListeVillesActuelle = Utils.BlankIfNull(res);

        if (sListeVillesActuelle != "")
        {
          if (MessageBox.Show("Etes-vous sûr(e) de vouloir récupérer les données du formulaire WEB et écraser les villes cibles déjà existantes pour ce sous-traitant ?",
                            "CONFIRMATION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            // Mise à jour de TSTF
            sListeVillesRecherche = sListeVillesRecherche.Replace("'", "''");
            string sSQL = $"UPDATE TSTF set VListeVilles = '{sListeVilles}', VListeVillesRecherche = '{sListeVillesRecherche}' WHERE NSTFNUM = {miNumSTF}";
            ModuleData.ExecuteNonQuery(sSQL);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void chkPrev_Click(object sender, EventArgs e)
    {
      Frame9.Visible = chkPrev.Checked;
    }

    private void OuvertureEnCreation()
    {
      try
      {
        cboPays.Text = "FRANCE";
        cboLangue.Text = "FRANCAIS";
        cboLangueAbrev.SelectedIndex = cboLangue.SelectedIndex;
        txtNbAT.Text = "0";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void OuvertureEnModification()
    {
      bool bTmpBool;

      try
      {
        // recherche des informatiopn de l'action
        using (SqlDataReader dr = ModuleData.ExecuteReader($"exec api_sp_InfoSiteSTF {miNumSTF}"))
        {
          if (dr.Read())
          {
            txtNom.Text = dr["VSTFNOM"] + "";

            txtAD1.Text = Utils.BlankIfNull(dr["VSTFAD1"]);
            txtAD2.Text = Utils.BlankIfNull(dr["VSTFAD2"]);
            txtCP.Text = Utils.BlankIfNull(dr["VSTFCP"]);
            txtVille.Text = Utils.BlankIfNull(dr["VSTFVIL"]);

            txtTel.Text = Utils.BlankIfNull(dr["VSTFTEL"]);
            txtObs.Text = Utils.BlankIfNull(dr["VSTFOBS"]);
            txtActivite.Text = Utils.BlankIfNull(dr["VSTFAC1"]);
            txtVilleCible.Text = Utils.BlankIfNull(dr["VSTFVIC"]);
            txtHor.Text = Utils.BlankIfNull(dr["NSTFMOE"]);
            txtDep.Text = Utils.BlankIfNull(dr["NSTFDEP"]);
            txtHorAstr.Text = Utils.BlankIfNull(dr["NSTFASTR"]);
            txtCPCedex.Text = Utils.BlankIfNull(dr["VSTFCPCEDEX"]);
            txtCedex.Text = Utils.BlankIfNull(dr["VSTFCEDEX"]);
            chkActif.Checked = Utils.BlankIfNull(dr["CSTFACTIF"]) == "O";
            chkCde.Checked = Utils.BlankIfNull(dr["CSTFCDEAUTO"]) == "O";
            chkPrev.Checked = Utils.BlankIfNull(dr["CSTFPREV"]) == "O";
            txtCptClient.Text = Utils.BlankIfNull(dr["VCPTCLIEMALEC"]);
            chkInter.Checked = Convert.ToBoolean(dr["BSTFINTERIM"]);
            txtSiret.Text = Utils.BlankIfNull(dr["VSTFSIRET"]);
            chkCdeWeb.Checked = Convert.ToBoolean(dr["BSTFCDEWEB"]);
            TxtTVAIntraCom.Text = Utils.BlankIfNull(dr["VTVAINTRACOM"]);
            txtNbAT.Text = Utils.BlankIfNull(dr["NBJOURAT"]);
            if (dr["DSTFCONTRATCADRE"] != DBNull.Value)
            {
              mDateValiditeContratCadre = ((DateTime)dr["DSTFCONTRATCADRE"]).Date;
              txtDateValidContratCadre.DateTime = (DateTime)mDateValiditeContratCadre;
            }
            else
            {
              txtDateValidContratCadre.EditValue = null;
            }

            if (Utils.ZeroIfNull(dr["FORMULAIRE"]) > 0)
              cmdFormulaire.BackColor = Color.Gold; // Jaune pale

            bTmpBool = (Utils.ZeroIfNull(dr["NSTFGRPTYPFO"]) != 1 || Utils.ZeroIfNull(dr["NSTFGRPTYPMNT"]) != 0 ||
                        Utils.ZeroIfNull(dr["NSTFGRPTYPINST"]) != 0 || Utils.ZeroIfNull(dr["NSTFGRPTYPGAR"]) != 0);
            setCostState(bTmpBool);

            // devise du pays
            lblLabels14.Text = lblLabels12.Text = lblLabels11.Text = Utils.BlankIfNull(dr["VDEVISE"]);

            // combo de la ville
            cboVille.Text = Utils.BlankIfNull(dr["VSTFVIL"].ToString());
            if (cboVille.SelectedIndex == -1)
            {
              cboVille.Items.Add(Utils.BlankIfNull(dr["VSTFVIL"].ToString()));
              cboVille.Text = Utils.BlankIfNull(dr["VSTFVIL"].ToString());
            }

            // combo du pays
            cboPays.Text = DBNull.Value == dr["VSTFPAYS"] ? "FRANCE" : dr["VSTFPAYS"].ToString();
            if (cboPays.SelectedIndex == -1)
            {
              cboPays.Items.Add(dr["VSTFPAYS"]);
              cboPays.Text = dr["VSTFPAYS"].ToString();
            }

            // combo de la langue (04/04/2016)
            cboLangueAbrev.Text = DBNull.Value == dr["VLANGUEABR"] ? "FR" : dr["VLANGUEABR"].ToString();
            cboLangue.SelectedIndex = cboLangueAbrev.SelectedIndex;

            apiFilEMALEC.Checked = Convert.ToBoolean(dr["BFILIALEEMALEC"]);
          }
        }
        //TB SAMSIC CITY DATASHAPE
        // Lier le datagrid avec le recordset secondaire
        loadApiTGrid();

        grdHisto.LoadData(dtHisto, MozartDatabase.cnxMozart, $"SELECT NSTFNUM, DSTFHDAT, VSTFHQUI, VSTFHOBJET, VSTFHLIB FROM TSTFHISTO WHERE NSTFNUM = {miNumSTF} ORDER BY DSTFHDAT DESC");
        grdHisto.GridControl.DataSource = dtHisto;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void setCostState(bool bEnabled)
    {
      txtHor.Enabled = txtDep.Enabled = txtHorAstr.Enabled = bEnabled;
      if (bEnabled)
      {
        txtHor.BackColor = txtDep.BackColor = txtHorAstr.BackColor = Color.LightGreen;
      }
      else
      {
        txtHor.BackColor = txtDep.BackColor = txtHorAstr.BackColor = Color.Silver;
      }
    }

    private void updateFormContratCadre()
    {
      string lSql;
      bool bExistContratCadre;
      bool bRightToModify;

      try
      {
        // Droits pour la coche existence contrat cadre
        bRightToModify = ModuleMain.RechercheDroitMenu(717);

        lSql = $"SELECT TSTFGRP.NSTFGRPCONTRATCADRE AS NSTFGRPCONTRATCADRE,";
        lSql += $"(SELECT VPERPRE + ' ' + VPERNOM FROM TPER WHERE NPERNUM = NSTFGRPQUICONTRATCADRE) AS VQUICC,";
        lSql += $"TSTFGRP.DSTFGRPDCONTRATCADRE AS DSTFGRPDCONTRATCADRE";
        lSql += $" FROM TSTFGRP WHERE NSTFGRPNUM = {miNumSTFGRP}";
        using (SqlDataReader dr = ModuleData.ExecuteReader(lSql))
        {
          if (dr.Read())
          {
            // CheckBox contrat cadre
            bExistContratCadre = Convert.ToInt32(Utils.ZeroIfNull(dr["NSTFGRPCONTRATCADRE"])) == 1;

            if (bExistContratCadre)
            {
              apiLblDValiContratCadre.Visible = txtDateValidContratCadre.Visible = lblModifCC.Visible = apiLabel2.Visible = bExistContratCadre;

              string lDate = Utils.DateBlankIfNull(mDateValiditeContratCadre);
              lblModifCC.Text = $"{Utils.BlankIfNull(dr["VQUICC"])}";
              if (lDate != "01/01/0001")
              {
                lblModifCC.Text += $" {Resources.lib_le} {lDate}";
              }
              else
              {
                lblModifCC.Text += $" (Aucune date définie)";

                apiLblDValiContratCadre.Visible = txtDateValidContratCadre.Visible = false;
              }

              apiLblDValiContratCadre.Enabled = txtDateValidContratCadre.Enabled = bRightToModify;

              setCostState(bRightToModify || (DateTime.Now.Date > mDateValiditeContratCadre));
            }
            else
            {
              setCostState(true);
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void loadApiTGrid()
    {
      apiTGrid1.LoadData(dtSec, MozartDatabase.cnxMozart, $"select NSTTNUM, NSTFNUM, VSTTNOM, VSTTPRENOM, VSTTPORT, VSTTMAIL, NINTNUM from TSTTECH " +
                                                $"WHERE NSTFNUM={miNumSTF} Order by VSTTNOM");
      apiTGrid1.GridControl.DataSource = dtSec;
    }

    private void Enregistrer()
    {
      try
      {
        // pour la création ou la modification, c'est la proc stock qui gère
        // création d'une commande
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationFournisseurSite", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iFournSite"].Value = miNumSTF;   // 0 si création
          cmd.Parameters["@iFournisseur"].Value = miNumSTFGRP;
          cmd.Parameters["@vNom"].Value = txtNom.Text.ToUpper();

          cmd.Parameters["@vAd1"].Value = txtAD1.Text;
          cmd.Parameters["@vAd2"].Value = txtAD2.Text;
          cmd.Parameters["@vCp"].Value = txtCP.Text;
          cmd.Parameters["@vVille"].Value = cboPays.Text == "FRANCE" ? cboVille.Text : txtVille.Text;
          cmd.Parameters["@vCpCedex"].Value = txtCPCedex.Text == "" ? null : txtCPCedex.Text;
          cmd.Parameters["@vCedex"].Value = txtCedex.Text == "" ? null : txtCedex.Text;
          cmd.Parameters["@vPays"].Value = cboPays.Text;
          cmd.Parameters["@vTel"].Value = txtTel.Text;
          cmd.Parameters["@vObs"].Value = txtObs.Text;
          cmd.Parameters["@iCoutHor"].Value = Utils.ZeroIfNull(txtHor.Text);
          cmd.Parameters["@iCoutDep"].Value = Utils.ZeroIfNull(txtDep.Text);
          cmd.Parameters["@iCoutAstr"].Value = Utils.ZeroIfNull(txtHorAstr.Text);  // NL le 01/02/2016, ajout du coût horaire astreinte
          cmd.Parameters["@vActivite"].Value = txtActivite.Text;
          cmd.Parameters["@vVilleCible"].Value = txtVilleCible.Text;
          cmd.Parameters["@vCptClient"].Value = txtCptClient.Text;
          cmd.Parameters["@cActif"].Value = chkActif.Checked ? "O" : "N";
          cmd.Parameters["@cdeDefaut"].Value = chkCde.Checked ? "O" : "N";
          cmd.Parameters["@cPrev"].Value = chkPrev.Checked ? "O" : "N";
          cmd.Parameters["@bInterim"].Value = chkInter.Checked ? 1 : 0;
          cmd.Parameters["@siret"].Value = txtSiret.Text;
          cmd.Parameters["@vlangueabr"].Value = cboLangueAbrev.Text;
          cmd.Parameters["@bCdeWeb"].Value = chkCdeWeb.Checked ? 1 : 0;
          cmd.Parameters["@nbAT"].Value = txtNbAT.Text == "" ? 0 : int.Parse(txtNbAT.Text);
          if (txtDateValidContratCadre.EditValue == null)
          {
            cmd.Parameters["@dSTFCONTRATCADRE"].Value = null;
          }
          else
          {
            cmd.Parameters["@dSTFCONTRATCADRE"].Value = txtDateValidContratCadre.DateTime;
          }

          cmd.Parameters["@bFilialeEMALEC"].Value = apiFilEMALEC.Checked ? 1 : 0;

          cmd.ExecuteNonQuery();
          miNumSTF = (int)cmd.Parameters[0].Value; // récupération du numéro créé
        }
        // on save le TVA INTRACOM
        //passage du nom de la procédure stockée
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationSTFVTVAINTRACOM", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          cmd.Parameters["@p_NSTFNUM"].Value = miNumSTF;   // 0 si création
          cmd.Parameters["@p_VSOCIETE"].Value = MozartParams.NomSociete;
          cmd.Parameters["@p_VTVAINTRACOM"].Value = TxtTVAIntraCom.Text;

          cmd.ExecuteNonQuery();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void txtCP_TextChanged(object sender, EventArgs e)
    {
      if (txtCP.Text.Length == 5 && cboPays.Text == "FRANCE")
        ModuleMain.RechercheCommune(txtCP.Text, cboVille);
    }

    private void txtCPCedex_Leave(object sender, EventArgs e)
    {
      if (txtCPCedex.Text != "" && txtCedex.Text == "")
      {
        txtCedex.Text = "CEDEX ";
      }
    }

    private void txtCedex_Leave(object sender, EventArgs e)
    {
      txtCedex.Text = txtCedex.Text.ToUpper();
    }

    private void txtVille_Leave(object sender, EventArgs e)
    {
      txtVille.Text = txtVille.Text.ToUpper();
    }

    private void InitApigrid()
    {
      apiTGrid1.AddColumn("numOut", "NSTTNUM", 0);
      apiTGrid1.AddColumn("numFou", "NSTFNUM", 0);
      apiTGrid1.AddColumn(Resources.col_Nom, "VSTTNOM", 1400, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Prenom, "VSTTPRENOM", 1300, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Port, "VSTTPORT", 1400, "", 0, true);
      apiTGrid1.AddColumn("Mail", "VSTTMAIL", 1000, "", 0, true);
      apiTGrid1.AddColumn("NINTNUM", "NINTNUM", 0);

      apiTGrid1.FilterBar = false;
      apiTGrid1.InitColumnList();
    }

    private void apiTGrid1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (miNumSTF == 0)
          return;

        if (currentRow != null)
        {
          txtNoms.Text = Utils.BlankIfNull(currentRow["VSTTNOM"]);
          txtPrenom.Text = Utils.BlankIfNull(currentRow["VSTTPRENOM"]);
          txtPort.Text = Utils.BlankIfNull(currentRow["VSTTPORT"]);
          txtMail.Text = Utils.BlankIfNull(currentRow["VSTTMAIL"]);
          CboINT_TSTTECH.SelectedValue = (Utils.ZeroIfNull(currentRow["NINTNUM"]));
          strStatut = "M";
        }
        else
        {
          if (miNumSTF == 0)
          {
            MessageBox.Show(Resources.msg_Save_sous_traitant_avant_saisir_tech, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }

          strStatut = "C";
          txtNoms.Text = "";
          txtPrenom.Text = "";
          txtPort.Text = "";
          txtMail.Text = "";
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void FormatGridHisto()
    {
      try
      {
        grdHisto.AddColumn("nPerNum", "NSTFNUM", 0);
        grdHisto.AddColumn("Date", "DSTFHDAT", 2000, "Date");
        grdHisto.AddColumn("Qui", "VSTFHQUI", 1500);
        grdHisto.AddColumn("objet", "VSTFHOBJET", 2300);
        grdHisto.AddColumn("Libellé", "VSTFHLIB", 1700);

        grdHisto.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cboPays_SelectionChangeCommitted(object sender, EventArgs e)
    {
      bool bDisplayForFrance = (cboPays.Text == "FRANCE");

      cboVille.Visible = bDisplayForFrance;
      txtVille.Visible = !bDisplayForFrance;
      cmdRecherche.Visible = bDisplayForFrance;
            
      try
      {
        if (cboPays.Text != "" & !bIsLoading)
        {
          string res = ModuleData.ExecuteScalarString($"select VLANGUEDEFAUT from TPAYS where VPAYSNOM = '{cboPays.Text}'");
          for (int i = 0; i < cboLangue.Items.Count; i++)
          {
            cboLangue.SelectedIndex = i;
            if (cboLangue.Text == res)
            {
              cboLangueAbrev.SelectedIndex = cboLangue.SelectedIndex;
              break;
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}

