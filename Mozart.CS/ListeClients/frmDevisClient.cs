using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDevisClient : Form
  {
    public int miNumDI;
    public int miNumAction;
    public int miNumDevis;
    public int miNumDevisCL;
    public int NCLINUM;
    double iCoefNuiDim;

    List<TextBox> lstTxtFields = new List<TextBox>();

    private int iIndexEnCours = 99;       //  Lors de l'ouverture de la feuille pour ne pas appliquer * 2.5
    private int NSITNUM;
    private double mdecTva;
    private bool bMail;
    private int iClientNumForTxHor;
    private string cEnvMail;

    public frmDevisClient() { InitializeComponent(); }

    private void frmDevisClient_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        optqui1.Text = optqui1.Text.Replace("$ste", MozartParams.NomSociete);

        lstTxtFields.Add(txtFields0); lstTxtFields.Add(txtFields1); lstTxtFields.Add(txtFields2); lstTxtFields.Add(txtFields3); lstTxtFields.Add(txtFields4); lstTxtFields.Add(txtFields5);
        lstTxtFields.Add(txtFields6); lstTxtFields.Add(txtFields7); lstTxtFields.Add(txtFields8); lstTxtFields.Add(txtFields9); lstTxtFields.Add(txtFields10); lstTxtFields.Add(txtFields11);

        // Inutile car cboLangue jamais utilisé
        //RemplirComboLangues();

        string sSql = "select NPERNUM, VPERNOM + ' ' + VPERPRE [VPERNOM] from TPER where CPERACTIF = 'O' AND VSOCIETE = App_Name() ORDER BY  VPERNOM, VPERPRE";
        cbotech.Init(MozartDatabase.cnxMozart, sSql, "NPERNUM", "VPERNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, bHideFirstColumn: true);  // apiCombo

        ModuleData.RemplirCombo(cboTVA, $"SELECT ID, TVA FROM TREF_TVA where VSOCIETE = '{MozartParams.NomSociete}' ORDER BY TVA", bSupprSpace: true); // combo
        cboTVA.ValueMember = "ID";
        cboTVA.DisplayMember = "TVA";

        ModuleData.RemplirCombo(cboUrg, $"select CURGCOD, VURGLIB from api_v_comboUrg where CURGCOD <> 4 AND langue = '{MozartParams.Langue}'", true); // combo
        cboUrg.ValueMember = "CURGCOD";
        cboUrg.DisplayMember = "VURGLIB";
        DataTable dtUrg = cboUrg.DataSource as DataTable;
        DataRow r = dtUrg.NewRow();
        r[0] = "0"; r[1] = "";
        dtUrg.Rows.InsertAt(r, 0);

        ModuleData.RemplirCombo(cboTheme, $"select NTHEME, VTHEME from TREF_THEMES where langue = '{MozartParams.Langue}' ORDER BY  VTHEME"); // combo
        cboTheme.ValueMember = "NTHEME";
        cboTheme.DisplayMember = "VTHEME";

        InitialiserFeuille();

        //cboTVA.SelectedIndexChanged += new EventHandler(cboTVA_SelectedIndexChanged);

        // utilisé pour la copie automatique des actions avec devis
        if (miNumDevis != 0)
          CopieDevis();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      EnregistrerDevisCL();
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      try
      {
        if (miNumDevisCL == 0)
        {
          MessageBox.Show(Resources.msg_Impression_impossible_enregistrer_devis, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // recherche de la langue d'affichage du devis
        // la langue par défaut du client est dans le tag du pays du client
        // si on sélectionnne une langue dans la combo, on prend cette langue, sinon, on prend la langue du pays du client ou du site selon le destinataire
        string sLgMod = cboDemandeur.GetItemData() == 0 ? ModuleMain.CodePays(txtFields13.Text) : txtFields14.Tag.ToString();
        sLgMod = sLgMod.Substring(0, 2);

        // recherche du modèle
        string sModele = RechercheModeleDevis();

        // version Report
        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = sModele,
          sIdentifiant = miNumDevisCL.ToString(),
          InfosMail = $"TCCL|NCCLCODE|000",
          sNomSociete = MozartParams.NomSociete,
          sLangue = sLgMod,
          sOption = "PRINT",
          strType = "DC",
          numAction = miNumAction
        }.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdVisualiser_Click(object sender, EventArgs e)
    {
      string sDest = "";

      //  type de destinataire (site, raison sociale ou contact)
      if (cboDemandeur.SelectedIndex == 0)
        sDest = "TCSIT|NSITNUM|" + NSITNUM;
      else if (cboDemandeur.SelectedIndex == 1)
        sDest = "TRSF|NRSFNUM|" + cboDemandeur.GetItemData();
      else
        sDest = "TCCL|NCCLCODE|" + cboDemandeur.GetItemData();

      // recherche de la langue d'affichage du devis
      // la langue par défaut du client est dans le tag du pays du client
      // si on sélectionnne une langue dans la combo, on prend cette langue, sinon, on prend la langue du pays du client ou du site selon le destinataire
      string sLgMod = cboDemandeur.GetItemData() == 0 ? ModuleMain.CodePays(txtFields13.Text) : txtFields14.Tag.ToString();
      sLgMod = sLgMod.Substring(0, 2);

      // recherche du modèle
      string sModele = RechercheModeleDevis();

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = sModele,
        sIdentifiant = miNumDevisCL.ToString(),
        InfosMail = sDest,
        sNomSociete = MozartParams.NomSociete,
        sLangue = sLgMod,
        sOption = "PREVIEW",
        strType = "DC",
        numAction = miNumAction
      }.ShowDialog();
    }

    private void cmdBrouillon_Click(object sender, EventArgs e)
    {
      // recherche de la langue d'affichage du devis
      // la langue par défaut du client est dans le tag du pays du client
      // si on sélectionnne une langue dans la combo, on prend cette langue, sinon, on prend la langue du pays du client ou du site selon le destinataire
      string sLgMod = cboDemandeur.GetItemData() == 0 ? ModuleMain.CodePays(txtFields13.Text) : txtFields14.Tag.ToString();
      sLgMod = sLgMod.Substring(0, 2);

      string[,] TdbGlobal = { { "Copie", "ORIGINAL" } };

      frmBrowser f = new frmBrowser();
      f.Preview_Print(MozartParams.CheminModeles + sLgMod + @"\TDevisClientBrouillon.rtf",
                      @"TDevisClientBrouillonOut.rtf",
                      TdbGlobal,
                      $"exec api_sp_impBrouillonDevisCL {miNumAction}, {cboDemandeur.GetItemData()}",
                      " (Visualisation devis client brouillon)",
                      "PREVIEW");
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void frmDevisClient_FormClosing(object sender, FormClosingEventArgs e)
    {
      // envoi du devis si nécessaire
      if (bMail && miNumDevisCL > 0)
        ModuleData.ExecuteNonQuery($"exec api_sp_SendMailNewDevis {miNumAction}");
    }

    private void optCout_CheckedChanged(object sender, EventArgs e)
    {
      if ((sender as RadioButton).Name == "optCout1" && optCout1.Checked) //forfait
      {
        txtForfait.Visible = lblForfait.Visible = lbleForfait.Visible = true;

        txtDep.Visible = txtFour.Visible = txtOeuvre.Visible = txtNbrDep.Visible = txtTauxDep.Visible = txtTauxHeures.Visible = txtNbrHeures.Visible = false;
        lblDep.Visible = lblFour.Visible = lblOeuvre.Visible = lblA0.Visible = lblA1.Visible = false;
        lbleDep.Visible = lbleFour.Visible = lbleOeuvre.Visible = false;

        txtNbrKm.Visible = txtNbrRepas.Visible = txtNbrNuit.Visible = txtTKm.Visible = txtTRepas.Visible = false;
        txtTNuit.Visible = txtKM.Visible = txtRepas.Visible = txtNuit.Visible = false;

        //  Partie MPM invisible (donc pas besoin de tester si MPM)
        lblMpM0.Visible = lblMpM1.Visible = lblMpM2.Visible = lblMpM3.Visible = lblMpM4.Visible = lblMpM5.Visible = false;

        //  le modele doit passer a forfait
        optMod0.Checked = true;

        txtForfait_TextChanged(null, null);
      }
      if ((sender as RadioButton).Name == "optCout0" && optCout0.Checked) //détail
      {
        txtDep.Visible = txtFour.Visible = txtOeuvre.Visible = txtNbrDep.Visible = txtTauxDep.Visible = txtTauxHeures.Visible = txtNbrHeures.Visible = true;
        lblDep.Visible = lblFour.Visible = lblOeuvre.Visible = lblA0.Visible = lblA1.Visible = true;
        lbleDep.Visible = lbleFour.Visible = lbleOeuvre.Visible = true;
        txtForfait.Visible = lblForfait.Visible = lbleForfait.Visible = false;

        //
        //  Partie MPM invisible (donc pas besoin de tester si MPM)
        if (MozartParams.NomSociete == "EMALECMPM")
        {
          lblMpM0.Visible = lblMpM1.Visible = lblMpM2.Visible = lblMpM3.Visible = lblMpM4.Visible = lblMpM5.Visible = true;
          txtNbrKm.Visible = txtNbrRepas.Visible = txtNbrNuit.Visible = txtTKm.Visible = txtTRepas.Visible = true;
          txtTNuit.Visible = txtKM.Visible = txtRepas.Visible = txtNuit.Visible = true;
        }

        // le modele doit passer à detail si on etait à forfait
        if (optMod0.Checked)
          optMod1.Checked = true;

        txtOeuvreDepFour_TextChanged(null, null);
      }
    }

    private void optMod_CheckedChanged(object sender, EventArgs e)
    {
      //' si forfait, alors modele forfait
      if (optCout1.Checked) optMod0.Checked = true;
      if (optCout0.Checked && (sender as RadioButton).Name == "optMod0") optMod1.Checked = true;
    }

    private void optObs_CheckedChanged(object sender, EventArgs e)
    {
      int index = Convert.ToInt32((sender as RadioButton).Name.Substring(6));

      //  si passage de nuit, x2.5 sur heures
      if (index == 2 && iIndexEnCours != 99)
      {
        txtTauxHeures.Text = (iCoefNuiDim * Convert.ToDouble(txtTauxHeures.Text)).ToString();
      }
      else if (index == 0)
      {
        if (iIndexEnCours == 2)
        {
          txtTauxHeures.Text = (Convert.ToDouble(txtTauxHeures.Text) / iCoefNuiDim).ToString();
        }
      }
      else if (index == 1)
      {
        if (iIndexEnCours == 2)
        {
          txtTauxHeures.Text = (Convert.ToDouble(txtTauxHeures.Text) / iCoefNuiDim).ToString();
        }
      }

      iIndexEnCours = index;
    }

    private void optQui_CheckedChanged(object sender, EventArgs e)
    {
      int index = Convert.ToInt32((sender as RadioButton).Name.Substring(6));
      cbotech.Visible = index != 0;
    }

    private void InitialiserFeuille()
    {
      try
      {
        // on verifie si le contrat existe toujours pour ce client
        if (miNumDevisCL == 0)
          if (VerifIfContratActif() == false)
          {
            MessageBox.Show("Vous ne pouvez pas créer de devis. Le contrat de la DI n'est plus affecté a ce client !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Dispose();
            return;
          }

        //  recherche des info du devis (que le devis existe ou pas)
        using (SqlDataReader drD = ModuleData.ExecuteReader($"api_sp_RetourInfoDevisCL {miNumAction}"))
        {
          if (drD.Read())
          {
            txtFields0.Text = drD["VCLINOM"].ToString();
            txtFields1.Text = drD["VDINNOM"].ToString();
            txtFields2.Text = drD["DDCLDAT"].ToString();
            txtFields3.Text = drD["NDINCTE"].ToString();
            txtFields4.Text = drD["VSITNOM"].ToString();
            txtFields5.Text = drD["VSITRES"].ToString();
            txtFields6.Text = drD["VSITAD1"].ToString();
            txtFields7.Text = drD["VSITAD2"].ToString();
            txtFields8.Text = drD["VSITCP"].ToString();
            txtFields9.Text = drD["VSITVIL"].ToString();
            txtFields10.Text = drD["NDINNUM"].ToString();
            txtFields11.Text = drD["NDCLNUM"].ToString();
            txtFields12.Text = drD["NACTNUM"].ToString();
            txtFields13.Text = drD["VSITPAYS"].ToString();
            txtFields14.Text = drD["VCLIPAYS"].ToString();

            NCLINUM = Convert.ToInt32(drD["NCLINUM"]);
            // langue du client
            txtFields14.Tag = Utils.BlankIfNull(drD["VCLILANGUE"]);

            //  on rempli la combo contact client
            UtilsDevis.RemplirCboContact(cboDemandeur, Convert.ToInt32(drD["NCLINUM"]), miNumAction);

            if (drD["NDCLDESTNUM"].ToString() != "")
              cboDemandeur.SetItemData(drD["NDCLDESTNUM"].ToString());

            if (cboDemandeur.SelectedIndex == -1) cboDemandeur.SelectedIndex = 0;

            //  'gestion RFA
            double dValRFA = UtilsDevis.GetTauxRFA(miNumAction);
            if (dValRFA < -1)
            {
              lblRFA.Visible = false;
              lblRFA.Text = "";
            }
            else
            {
              lblRFA.Visible = true;
              lblRFA.Text = Resources.msg_contrat_inclut + " " + (dValRFA * 100).ToString() + " % " + Resources.msg_remise_fin_annee + "\r\n" + Resources.msg_majorer_devis;
            }

            //  ' si on est en modification ou en création
            if (drD["NDCLNUM"].ToString().Substring(0, 1) == "0")
            {
              mdecTva = UtilsDevis.RechercheTauxDeTVA(miNumAction);
              bMail = true;
              //mstrStatutDevis = "C";
              miNumDevisCL = 0;
              txtObjet.Text = drD["VACTDES"].ToString();

              cboUrg.SelectedValue = Convert.ToInt32(drD["CURGCOD"]) == 4 ? 1 : Convert.ToInt32(drD["CURGCOD"]);

              txtTauxHeures.Text = Utils.BlankIfNull(drD["NHRTAUX"]);
              if (txtTauxHeures.Text == "")
                txtTauxDep.Text = "48";

              txtTauxDep.Text = Utils.BlankIfNull(drD["NDEPTAUX"]);
              if (txtTauxDep.Text == "")
                txtTauxDep.Text = "68";

              iIndexEnCours = 98;  // en création du devis, il faut prendre en compte les infos de l'action

              //MPM
              txtTNuit.Text = Utils.BlankIfNull(drD["NDCLTNUIT"]);
              txtTRepas.Text = Utils.BlankIfNull(drD["NDCLTREPAS"]);
              txtTKm.Text = Utils.BlankIfNull(drD["NDCLTKM"]);
            }
            else
            {
              //mstrStatutDevis = "M";
              bMail = false;
              mdecTva = Convert.ToDouble(drD["NDCLTTVA"]);
              miNumDevisCL = Convert.ToInt32(drD["NDCLNUM"].ToString().Substring(2));
              txtObjet.Text = drD["VACTDES"].ToString();
              txtMot.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(drD["TDCLMOT"]), "RTF");
              txtPrest.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(drD["TDCLPRE"]), "RTF");
              txtObs.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(drD["TDCLOBS"]), "RTF");
              txtPJ.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(drD["VDCLPJ"]), "RTF");

              txtForfait.Text = Utils.BlankIfNull(drD["NDCLFOR"]);
              txtDep.Text = drD["NDCLDEP"].ToString();

              txtNbrDep.Text = Utils.ZeroIfNull(drD["NDEPNB"]).ToString();
              txtTauxDep.Text = Utils.ZeroIfNull(drD["NDEPTAUX"]).ToString();

              txtNbrHeures.Text = Utils.ZeroIfNull(drD["NHEURESNB"]).ToString();
              txtTauxHeures.Text = Utils.ZeroIfNull(drD["NHRTAUX"]).ToString();

              txtOeuvre.Text = Utils.ZeroIfNull(drD["NDCLMOE"]).ToString("# ##0.00");
              txtFour.Text = Utils.ZeroIfNull(drD["NDCLFOU"]).ToString("###0.00");
              txtDap.Text = Utils.BlankIfNull(drD["NDCLDAP"]);
              txtDre.Text = Utils.BlankIfNull(drD["NDCLDRE"]);
              NSITNUM = Convert.ToInt32(drD["NSITNUM"]);

              // MPM
              txtNbrNuit.Text = Utils.ZeroIfNull(drD["NDCLNUIT"]).ToString();
              txtNbrRepas.Text = Utils.ZeroIfNull(drD["NDCLREPAS"]).ToString();
              txtNbrKm.Text = Utils.ZeroIfNull(drD["NDCLKM"]).ToString();
              txtTNuit.Text = Utils.ZeroIfNull(drD["NDCLTNUIT"]).ToString();
              txtTRepas.Text = Utils.ZeroIfNull(drD["NDCLTREPAS"]).ToString();
              txtTKm.Text = Utils.ZeroIfNull(drD["NDCLTKM"]).ToString();

              // urgence
              if (Utils.ZeroIfNull(drD["CDCLURGENCE"]) > 0)
                cboUrg.SelectedValue = drD["CDCLURGENCE"];

              // theme
              cboTheme.SelectedValue = drD["NDCLTHEME"];

              // on se positionne sur le bon tech
              if (Convert.ToInt32(drD["NDCLTECH"]) != 0)
              {
                cbotech.SetItemData(Convert.ToInt32(drD["NDCLTECH"]));
                optqui1.Checked = true;
              }
              else
                optqui0.Checked = true;
            }

            cboTVA.Text = mdecTva.ToString("#.00");

            txtHT.Text = Utils.BlankIfNull(drD["NDCLHT"]);
            txtTVA.Text = Utils.BlankIfNull(drD["NDCLTVA"]);

            Frame7.Text = $"{Resources.msg_saisie_infos_par}{Utils.BlankIfNull(drD["QUI"])} le {Utils.BlankIfNull(drD["DDCLDCRE"])})";

            //  On se positionne sur le bon message en reprenant les données de l'action
            if (Strings.InStr(drD["VDCLOBST"].ToString(), "journée") != 0)
            {
              optObs0.Checked = true;
              iIndexEnCours = 0;
            }
            else if (Strings.InStr(drD["VDCLOBST"].ToString(), "nuit") != 0)
            {
              optObs2.Checked = true;
            }
            else
            {
              optObs1.Checked = true;
              iIndexEnCours = 1;
            }
          }

          //  choix entre détail et forfait (si pas forfait alors detail)
          optCout0.Checked = txtForfait.Text == "";
          optCout1.Checked = !optCout0.Checked;

          //  En creation, on est en detail par default
          switch (drD["CTYPEMODELE"].ToString())
          {
            case "F":  //forfait
              optMod0.Checked = true;
              break;
            case "D": //detail ou creation du devis donc detail par defaut
            case "C":  //detail ou creation du devis donc detail par defaut
              optMod1.Checked = true;
              break;
            case "A": // detail + article sans prix
              optMod2.Checked = true;
              break;
            case "P": // Detail + article avec prix
              optMod3.Checked = true;
              break;
            case "M": // fournitures + MO/Dep
              optMod4.Checked = true;
              break;
            case "H": // détail (MO/Dep+fourniture) et liste tableau avec prix
              optMod5.Checked = true;
              break;
          }

          //  Choix des charges ou immo
          OptChargImmo1.Checked = drD["CDCLIMMO"].ToString() == "O";
          OptChargImmo0.Checked = !OptChargImmo1.Checked;

          //  Couleur du bouton quantitatif
          cmdArticlesDevis.BackColor = Utils.ZeroIfNull(drD["NDCLQUATHT"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;

          //  Recherche du coef de nuit et dimanche
          using (SqlDataReader dr = ModuleData.ExecuteReader($"EXEC api_sp_RetourInfoDevisCLCoef {miNumAction}"))
          {
            if (dr.Read())
            {
              iCoefNuiDim = Utils.ZeroIfNull(dr["NCLICONTHORNUIDIM"]) == 0 ? 2.5 : Utils.ZeroIfNull(dr["NCLICONTHORNUIDIM"]);

              //  APPLE STORE -- Taux horaire fixe à 135 € pour nuit et dimanche
              iClientNumForTxHor = Convert.ToInt32(Utils.ZeroIfNull(dr["NCLINUM"]));
            }
            else
            { iCoefNuiDim = 2.5; }
          }
        }
        // Forcer la mise à jour des totaux
        txtHT_TextChanged(null, null);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void EnregistrerDevisCL()
    {
      try
      {
        //  GREG 13/07/2010 si on est en modif, on verifie l'état de l'action
        // on propose à l'utilisateur d'enregistrer ou non les modifications si O,P,E,W ou F
        if (miNumDevisCL != 0)
        {
          if (ModuleData.ExecuteScalarObject($"SELECT NACTNUM FROM TACT WITH (NOLOCK) WHERE NACTNUM = {miNumAction} AND (CETACOD in ('O','P','E','W') OR CACTSTA = 'F')") != null)
          {
            if (MessageBox.Show("ATTENTION : Vous allez modifier le texte d'un devis déjà accepté par le client. Le texte modifié de l'action va modifier le texte du devis."
                                + "\r\n" + "Voulez-vous quand même modifier le devis ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
              InitialiserFeuille();
              return;
            }
          }
        }
        // Emalec -> il faut choisir un tech
        if (optqui1.Checked && cbotech.GetText() == "")
        {
          MessageBox.Show(Resources.msg_choisir_tech_devis, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (cboUrg.Text == "")
        {
          MessageBox.Show(Resources.msg_definir_urgence, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (cboTheme.Text == "")
        {
          MessageBox.Show(Resources.msg_definir_theme, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (txtDap.Text == "")
        {
          MessageBox.Show(Resources.msg_definir_delai_prep, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (txtDre.Text == "")
        {
          MessageBox.Show(Resources.msg_definir_delai_real, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        //  Mise a zero des chiffres non utilisées
        if (optCout0.Checked)
        {         // details
          txtForfait.Text = "";
          txtOeuvreDepFour_TextChanged(txtOeuvre, null);
        }
        else
        {
          txtOeuvre.Text = "";
          txtDep.Text = "";
          txtFour.Text = "";
          txtNuit.Text = "";
          txtRepas.Text = "";
          txtKM.Text = "";
          txtForfait_TextChanged(txtForfait, null);
        }

        // uniquement traitement lors de la creation du devis. L'utilisateur choisi
        cEnvMail = "N"; // valeur par default

        // pour les clients avec envoi de mail le soir
        //  TB SAMSIC CITY SPEC
        if ((txtFields0.Text == "AGIP FRANCE" || txtFields0.Text == "LA COMPAGNIE FINANCIERE EDMOND DE ROTHSCHILD"
            || txtFields0.Text == "NOCIBE" || txtFields0.Text == "HABITAT") && miNumDevisCL == 0 && MozartParams.NomGroupe == "EMALEC")
        {
          if (MessageBox.Show(Resources.msg_realiser_devis + txtFields0.Text + ". " + "\r\n"
                            + Resources.msg_rappel_envoi_auto_19h + "\r\n"
                            + Resources.msg_dde_validation_envoi, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            cEnvMail = "N";
          else
            cEnvMail = "B";   // ne pas envoyer de mail car blocage de l'utilisateur
        }

        int iNumDevisAvant = miNumDevisCL;

        using (SqlCommand cmd = new SqlCommand("api_sp_CreationDevisCL", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@iDevis"].Value = miNumDevisCL;
          cmd.Parameters["@iAction"].Value = miNumAction;
          cmd.Parameters["@tObj"].Value = ModuleMain.ReplaceCharToBD(txtObjet.Text, "RTF");
          cmd.Parameters["@tMot"].Value = ModuleMain.ReplaceCharToBD(txtMot.Text, "RTF");
          cmd.Parameters["@tPre"].Value = ModuleMain.ReplaceCharToBD(txtPrest.Text, "RTF");
          cmd.Parameters["@tObs"].Value = ModuleMain.ReplaceCharToBD(txtObs.Text, "RTF");
          cmd.Parameters["@vPj"].Value = ModuleMain.ReplaceCharToBD(txtPJ.Text, "RTF");
          cmd.Parameters["@nFor"].Value = txtForfait.Text == "" ? DBNull.Value : (object)txtForfait.Text;
          cmd.Parameters["@nFou"].Value = txtFour.Text == "" ? DBNull.Value : (object)txtFour.Text;
          cmd.Parameters["@nMoe"].Value = txtOeuvre.Text == "" ? DBNull.Value : (object)txtOeuvre.Text;
          cmd.Parameters["@nNbHeures"].Value = txtNbrHeures.Text == "" ? DBNull.Value : (object)txtNbrHeures.Text;
          cmd.Parameters["@nTxHeures"].Value = txtTauxHeures.Text == "" ? DBNull.Value : (object)txtTauxHeures.Text;
          cmd.Parameters["@nDep"].Value = txtDep.Text == "" ? DBNull.Value : (object)txtDep.Text;
          cmd.Parameters["@nNbDep"].Value = txtNbrDep.Text == "" ? DBNull.Value : (object)txtNbrDep.Text;
          cmd.Parameters["@nTxDep"].Value = txtTauxDep.Text == "" ? DBNull.Value : (object)txtTauxDep.Text;
          cmd.Parameters["@nHt"].Value = txtHT.Text == "" ? "0" : txtHT.Text;
          cmd.Parameters["@nTva"].Value = txtTVA.Text == "" ? DBNull.Value : (object)txtTVA.Text;
          cmd.Parameters["@nDap"].Value = txtDap.Text == "" ? DBNull.Value : (object)txtDap.Text;
          cmd.Parameters["@nDre"].Value = txtDre.Text == "" ? DBNull.Value : (object)txtDre.Text;
          // Destinataire site (S) ou raison sociale (R) ou contact(C)
          int aux = cboDemandeur.SelectedIndex;
          cmd.Parameters["@envSite"].Value = (aux == 0 ? "S" : aux == 1 ? "R" : aux > 1 ? "C" : "");
          cmd.Parameters["@iDest"].Value = cboDemandeur.GetItemData();
          cmd.Parameters["@iTech"].Value = optqui1.Checked ? cbotech.GetItemData() : 0;
          cmd.Parameters["@vobsTrav"].Value = optObs0.Checked ? optObs0.Tag : optObs1.Checked ? optObs1.Tag : optObs2.Checked ? optObs2.Tag : "";
          cmd.Parameters["@curgence"].Value = cboUrg.GetItemData();
          cmd.Parameters["@vtheme"].Value = cboTheme.SelectedValue;
          // F:forfait-D:Detail-A:Article sans prix-P:Article avec prix
          cmd.Parameters["@cModele"].Value = optMod0.Checked ? "F" : optMod1.Checked ? "D" : optMod2.Checked ? "A" : optMod3.Checked ? "P" : optMod4.Checked ? "M" : optMod5.Checked ? "H" : "";
          cmd.Parameters["@cEnvMail"].Value = cEnvMail;
          cmd.Parameters["@ntheme"].Value = cboTheme.GetItemData();


          cmd.Parameters["@cDclImmo"].Value = OptChargImmo0.Checked ? "N" : OptChargImmo1.Checked ? "O" : "";
          cmd.Parameters["@nTauxTva"].Value = mdecTva;

          // Spécifique MPM
          cmd.Parameters["@nNuitee"].Value = txtNbrNuit.Text == "" ? DBNull.Value : (object)txtNbrNuit.Text;
          cmd.Parameters["@nRepas"].Value = txtNbrRepas.Text == "" ? DBNull.Value : (object)txtNbrRepas.Text;
          cmd.Parameters["@nKM"].Value = txtNbrKm.Text == "" ? DBNull.Value : (object)txtNbrKm.Text;
          cmd.Parameters["@nTNuitee"].Value = txtTNuit.Text == "" ? DBNull.Value : (object)txtTNuit.Text;
          cmd.Parameters["@nTRepas"].Value = txtTRepas.Text == "" ? DBNull.Value : (object)txtTRepas.Text;
          cmd.Parameters["@nTKM"].Value = txtTKm.Text == "" ? DBNull.Value : (object)txtTKm.Text;

          cmd.Parameters["@iNumDevisCL"].Value = 0;

          cmd.ExecuteNonQuery();
          miNumDevisCL = Convert.ToInt32(cmd.Parameters[0].Value);
        }


        //  on réinitialise le devis
        InitialiserFeuille();

        //  Si on était en création mail a envoyer
        if (iNumDevisAvant == 0 && miNumDevisCL != iNumDevisAvant)
          bMail = true;

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdArticlesDevis_Click(object sender, EventArgs e)
    {
      if (miNumDevisCL == 0)
      {
        MessageBox.Show(Resources.msg_impossible_enregistrer_devis, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      frmDevisClientArticles f = new frmDevisClientArticles();
      f.miNumDI = miNumDI;
      f.miNumAction = miNumAction;
      f.miNumClient = iClientNumForTxHor;
      f.miNumDevis = miNumDevisCL;
      f.iCoefNuiDimArt = iCoefNuiDim;
      f.lstFields = lstTxtFields;
      f.ShowDialog();

      //  ' retour, poser les chiffres ou pas : poser la question
      if (MessageBox.Show(Resources.msg_dde_maj_devis_quantitatif, Program.AppTitle,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        MajDonneesQuantitatif();
        EnregistrerDevisCL();
      }
    }

    private void MajDonneesQuantitatif()
    {

      using (SqlDataReader dr = ModuleData.ExecuteReader("exec api_sp_RetourInfoQuantitatif " + miNumDevisCL))
      {
        if (dr.Read())
        {
          if (dr["CASTREINTE"].ToString() == "O")
          {
            optObs0.Checked = optObs1.Checked = false;
            optObs2.Checked = true;
          }
          else if (dr["CASTREINTE"].ToString() == "P")
          {
            optObs0.Checked = optObs2.Checked = false;
            optObs1.Checked = true;
          }
          else
          {
            optObs0.Checked = true;
            optObs1.Checked = optObs2.Checked = false;
          }

          txtOeuvre.Text = (Utils.ZeroIfNull(dr["NHRTAUX"]) * Utils.ZeroIfNull(dr["NHEURESNB"])).ToString("# ##0.00");
          txtDep.Text = (Utils.ZeroIfNull(dr["NDEPTAUX"]) * Utils.ZeroIfNull(dr["NDEPNB"])).ToString("# ##0.00");
          txtFour.Text = Utils.ZeroIfNull(dr["tot"]).ToString("# ##0.00");
          txtForfait.Text = (Utils.ZeroIfNull(dr["tot"]) + Convert.ToDouble(txtOeuvre.Text) + Convert.ToDouble(txtDep.Text)).ToString("# ##0.00");

          txtNbrHeures.Text = Utils.ZeroIfNull(dr["NHEURESNB"]).ToString();
          txtNbrDep.Text = Utils.ZeroIfNull(dr["NDEPNB"]).ToString();
          txtTauxHeures.Text = Utils.ZeroIfNull(dr["NHRTAUX"]).ToString("# ##0.00");
          txtTauxDep.Text = Utils.ZeroIfNull(dr["NDEPTAUX"]).ToString("# ##0.00");
        }
        else
          return;
      }
    }

    private void CopieDevis()
    {
      try
      {
        //  On se place sur le bon champ de la combo
        using (SqlDataReader drD = ModuleData.ExecuteReader("select * from TDCL WHERE NDCLNUM = " + miNumDevis))
        {
          if (drD.Read())
          {
            if (drD["NDCLDESTNUM"].ToString() != "")
              cboDemandeur.SelectedValue = Convert.ToInt32(drD["NDCLDESTNUM"]);

            txtPrest.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(drD["TDCLPRE"]), "RTF");
            txtObs.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(drD["TDCLOBS"]), "RTF");
            txtPJ.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(drD["VDCLPJ"]), "RTF");
            txtForfait.Text = Utils.BlankIfNull(drD["NDCLFOR"]);
            txtDep.Text = Utils.BlankIfNull(drD["NDCLDEP"]);
            txtOeuvre.Text = Utils.BlankIfNull(drD["NDCLMOE"]);
            txtFour.Text = Utils.BlankIfNull(drD["NDCLFOU"]);
            txtHT.Text = Utils.BlankIfNull(drD["NDCLHT"]);
            txtTVA.Text = Utils.BlankIfNull(drD["NDCLTVA"]);
            txtDap.Text = Utils.BlankIfNull(drD["NDCLDAP"]);
            txtDre.Text = Utils.BlankIfNull(drD["NDCLDRE"]);

            //  Urgence
            if (Utils.ZeroIfNull(drD["CDCLURGENCE"]) > 0)
              cboUrg.SelectedValue = drD["CDCLURGENCE"];

            //  ' theme
            cboTheme.SelectedValue = drD["NDCLTHEME"];

            optCout0.Checked = txtForfait.Text == "";
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void txtOeuvreDepFour_TextChanged(object sender, EventArgs e)
    {
      txtHT.Text = (Utils.ZeroIfNull(txtDep.Text) + Utils.ZeroIfNull(txtFour.Text) + Utils.ZeroIfNull(txtOeuvre.Text)).ToString("# ##0.00");
      if (MozartParams.NomSociete == "EMALECMPM")
        txtHT.Text = (Utils.ZeroIfNull(txtHT.Text) + Utils.ZeroIfNull(txtNuit.Text) + Utils.ZeroIfNull(txtRepas.Text)
                    + Utils.ZeroIfNull(txtKM.Text)).ToString("# ##0.00");
    }

    private void txtNuitRepasKm_TextChanged(object sender, EventArgs e)
    {
      txtHT.Text = (Utils.ZeroIfNull(txtDep.Text) + Utils.ZeroIfNull(txtFour.Text) + Utils.ZeroIfNull(txtOeuvre.Text)
                 + Utils.ZeroIfNull(txtNuit.Tag) + Utils.ZeroIfNull(txtRepas.Text) + Utils.ZeroIfNull(txtKM.Text)).ToString("# ##0.00");
    }

    private void txtForfait_TextChanged(object sender, EventArgs e)
    {
      txtHT.Text = Utils.ZeroIfBlank(txtForfait.Text).ToString("# ##0.00");
    }

    private void txtHT_TextChanged(object sender, EventArgs e)
    {
      txtTVA.Text = (Utils.ZeroIfNull(txtHT.Text) * mdecTva / 100).ToString("# ##0.00");
      txtTTC.Text = (Utils.ZeroIfNull(txtHT.Text) + Utils.ZeroIfNull(txtTVA.Text)).ToString("# ##0.00");
    }

    private void txtTVA_TextChanged(object sender, EventArgs e)
    {
      txtTTC.Text = (Utils.ZeroIfNull(txtHT.Text) + Utils.ZeroIfNull(txtTVA.Text)).ToString("# ##0.00");
    }

    private void txtNbrDep_TextChanged(object sender, EventArgs e)
    {
      txtDep.Text = (Utils.ZeroIfNull(txtTauxDep.Text) * Utils.ZeroIfNull(txtNbrDep.Text)).ToString("# ##0.00");
    }

    private void txtTauxHeures_TextChanged(object sender, EventArgs e)
    {
      txtOeuvre.Text = (Utils.ZeroIfNull(txtTauxHeures.Text) * Utils.ZeroIfNull(txtNbrHeures.Text)).ToString("# ##0.00");
    }

    private void txtTauxDep_TextChanged(object sender, EventArgs e)
    {
      txtDep.Text = (Utils.ZeroIfNull(txtTauxDep.Text) * Utils.ZeroIfNull(txtNbrDep.Text)).ToString("# ##0.00");
    }

    private void txtNbrNuit_TextChanged(object sender, EventArgs e)
    {
      txtNuit.Text = (Utils.ZeroIfNull(txtTNuit.Text) * Utils.ZeroIfBlank(txtNbrNuit.Text)).ToString("# ##0.00");
    }

    private void txtNbrRepas_TextChanged(object sender, EventArgs e)
    {
      txtRepas.Text = (Utils.ZeroIfNull(txtTRepas.Text) * Utils.ZeroIfBlank(txtNbrRepas.Text)).ToString("# ##0.00");
    }

    private void txtNbrKm_TextChanged(object sender, EventArgs e)
    {
      txtKM.Text = (Utils.ZeroIfNull(txtTKm.Text) * Utils.ZeroIfBlank(txtNbrKm.Text)).ToString("# ##0.00");
    }

    private void txtNbrHeures_TextChanged(object sender, EventArgs e)
    {
      txtOeuvre.Text = (Utils.ZeroIfNull(txtTauxHeures.Text) * Utils.ZeroIfNull(txtNbrHeures.Text)).ToString("# ##0.00");
    }

    private void CmdVisuDeviseETR_Click(object sender, EventArgs e)
    {
      if (miNumDevisCL == 0)
      {
        MessageBox.Show(Resources.msg_Impression_impossible_enregistrer_devis, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      string[,] TdbGlobal = { { "Copie", "ORIGINAL" } };

      frmBrowser f = new frmBrowser();
      f.mstrType = "DC" + miNumDevisCL;

      if (cboDemandeur.SelectedIndex == 0)
        f.msInfosMail = $"TCSIT|NSITNUM|{NSITNUM}";
      else if (cboDemandeur.SelectedIndex == 1)
        f.msInfosMail = $"TRSF|NRSFNUM|{cboDemandeur.SelectedIndex}";
      else
        f.msInfosMail = $"TCCL|NCCLCODE|{cboDemandeur.SelectedIndex}";

      string sLgMod = cboDemandeur.GetItemData() == 0 ? ModuleMain.CodePays(txtFields13.Text) : txtFields14.Tag.ToString();
      sLgMod = sLgMod.Substring(0, 2);

      string sModele = RechercheModeleDevis();

      f.Preview_Print($"{MozartParams.CheminModeles}{ModuleMain.CodePays(sLgMod)}{sModele}ETR.rtf",
                      $@"{ReturnFileNameForWindows("TDevisClient_" + miNumDevisCL + "_" + txtFields4.Text + "ETR.rtf")}",
                      TdbGlobal,
                      $"exec api_sp_ImpDevisCLETR {miNumDevisCL},'{sLgMod}'",
                      " (Visualisation devis client en devis étrangère)",
                      "PREVIEW");
    }

    private string ReturnFileNameForWindows(string name)
    {
      string invalidChars = System.Text.RegularExpressions.Regex.Escape(new string(Path.GetInvalidFileNameChars()));
      string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);

      return System.Text.RegularExpressions.Regex.Replace(name, invalidRegStr, "_");
    }

    private void txtNbr_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieNombre(e);
    }

    private void txtTaux_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieMontant(e);
    }

    private void cboTVA_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cboTVA.Text == "System.Data.DataRowView") return;
      mdecTva = Convert.ToDouble(cboTVA.Text);
      txtTVA.Text = (Utils.ZeroIfNull(txtHT.Text) * mdecTva / 100).ToString("# ##0.00"); ;
    }

    private bool VerifIfContratActif()
    {
      // Recherche des info du devis (que le devis existe ou pas)
      return (int)ModuleData.ExecuteScalarInt($"exec api_sp_VerifContratExistAction {miNumAction}") != 0;
    }

    private string RechercheModeleDevis()
    {
      string sTypePrix = optMod0.Checked ? "F" : optMod1.Checked ? "D" : optMod2.Checked ? "A" : optMod3.Checked ? "P" : optMod4.Checked ? "M" : optMod5.Checked ? "H" : "";

      return DetailstravauxUtils.RechercheModeleDevis("F", sTypePrix);
    }
  }
}
